using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace NetAtmo.NET
{
  public partial class Form1 : Form
  {
    public static string ErrorOATHMessage = "";
    public static string AccessToken = "";
    public static string DeviceID = "";
    public static string ModuleID = "";

    private int measurementInterval = 60;
    private bool measuring = true;
    private bool measuringManualHalt = false;
    private int reconnectTimes = 0;

    public Form1()
    {
      InitializeComponent();
      AccessToken = tbAccessToken.Text;
      DeviceID = tbDeviceID.Text;
      measurementInterval = int.Parse(cbMeasurementsInterval.Text);

      /*
      Thread t = new Thread(startMeasuring);
      t.IsBackground = true;
      t.Start();*/
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //Load settings later on
    }


    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      Properties.Settings.Default.Save();
      measuring = false;
    }

    /// <summary>
    ///  http://stackoverflow.com/a/4088699/2770404
    /// </summary>
    /// 
    public static class Http
    {
      public static byte[] Post(string uri, NameValueCollection pairs)
      {
        byte[] response = null;

        using (WebClient client = new WebClient())
        {
          response = client.UploadValues(uri, pairs);
        }
        return response;
      }
    }

    private void startMeasuring()
    {
      while (measuring)
      {
        if (measuringManualHalt == false)
        {
          Form1 form = new Form1();
          form.getMeasurements();
        }

        Thread.Sleep(measurementInterval * 1000);
      }
    }
    private void AuthenticateOATH()
    {
      try
      {
        ErrorOATHMessage = "";
        var response = new byte[10000];
        try
        {
          response = Http.Post("https://api.netatmo.net/oauth2/token", new NameValueCollection() {
            { "grant_type", "password" },
            { "client_id", tbClientID.Text },
            { "client_secret", tbClientSecret.Text },
            { "username", tbClientUsername.Text },
            { "password", tbClientPassword.Text },
            { "scope", "read_station read_thermostat write_thermostat" }}
          );
        }
        catch (Exception e)
        {
          ErrorOATHMessage = e.Message;
        }

        string responseDecoded = System.Text.Encoding.UTF8.GetString(response);
        string expiresIn = "";
        string refreshToken = "";

        dynamic data = JsonConvert.DeserializeObject(responseDecoded);
        AccessToken = data.access_token;
        expiresIn = data.expires_in;
        refreshToken = data.refresh_token;

        lvDebug.Items.Add("Access Token: " + AccessToken);
        lvDebug.Items.Add("Expires in: " + expiresIn);
        lvDebug.Items.Add("Refresh Token: " + refreshToken);
        tbAccessToken.Text = AccessToken;

        if (string.IsNullOrEmpty(ErrorOATHMessage) == false)
        {
          lvDebug.Items.Add(ErrorOATHMessage);
        }
      }
      catch (Exception e)
      {
        lvDebug.Items.Add("Error during access token retrieval: " + e.Message);
      }
    }

    private void getDeviceID()
    {
      var response = new byte[10000];

      try
      {
        if (string.IsNullOrEmpty(tbAccessToken.Text) == false)
        {
          try
          {
            WebClient client = new WebClient();
            string url = "http://api.netatmo.net/api/devicelist?access_token=" + tbAccessToken.Text;
            response = client.DownloadData(url);
          }
          catch (Exception e)
          {
            if (reconnectTimes < 3)
            {
              reconnectTimes++;
              AuthenticateOATH();
              getDeviceID();
            }
          }
        }
        else
        {
          if(reconnectTimes < 3)
          {
            reconnectTimes++;
            AuthenticateOATH();
            getDeviceID();
          }
        }
        reconnectTimes = 0;
        string responseDecoded = System.Text.Encoding.UTF8.GetString(response);

        dynamic data = JsonConvert.DeserializeObject(responseDecoded);
        var deviceID = data.body.devices[0]._id;
        var moduleID = data.body.modules[0]._id;
        var altitude = data.body.devices[0].place.altitude;
        var country = data.body.devices[0].place.country;
        var latitude = data.body.devices[0].place.location[0];
        var longitude = data.body.devices[0].place.location[1];
        var timezone = data.body.devices[0].place.timezone;

        DeviceID = (string)deviceID;
        ModuleID = (string)moduleID;
        tbDeviceID.Text = DeviceID;
        tbModuleID.Text = ModuleID;
        tbAltitude.Text = (string)altitude;
        tbCountry.Text = (string)country;
        tbLatitude.Text = (string)latitude;
        tbLongtitude.Text = (string)longitude;
        tbTimeZone.Text = (string)timezone;

        lvDebug.Items.Add("Device ID: " + DeviceID);
      }
      catch (Exception e)
      {
        lvDebug.Items.Add("Error during Device ID retrieval: " + e.Message);
      }
    }
    private void getMeasurements()
    {
      try
      {
        var response = new byte[10000];
        string measurementType = cbMeasureType.Text;

        if (string.IsNullOrEmpty(AccessToken))
        {
          if (reconnectTimes < 3)
          {
            reconnectTimes++;
            AuthenticateOATH();
          }
        }

        if (string.IsNullOrEmpty(DeviceID))
        {
          if (reconnectTimes < 3)
          {
            reconnectTimes++;
            getDeviceID();
          }
        }
        reconnectTimes = 0;

        try
        {
          WebClient client = new WebClient();
          string url = "";
          if (measurementType == "Remote")
          {
            url = "http://api.netatmo.net/api/getmeasure?access_token=" + AccessToken + "&device_id=" + DeviceID + "&module_id=" + ModuleID + "&type=Temperature,Humidity,Pressure,CO2&limit=1&date_end=last&scale=30min";
          }
          else if (measurementType == "Station")
          {
            url = "http://api.netatmo.net/api/getmeasure?access_token=" + AccessToken + "&device_id=" + DeviceID + "&type=Temperature,Humidity,Pressure,CO2&limit=1&date_end=last&scale=30min";
          }
          response = client.DownloadData(url);
        }
        catch (Exception e)
        {
          AuthenticateOATH();
          getDeviceID();
        }

        string responseDecoded = System.Text.Encoding.UTF8.GetString(response);
        dynamic data = JsonConvert.DeserializeObject(responseDecoded);

        string temperature = data.body[0].value[0][0]; // temperature
        string humidity = data.body[0].value[0][1]; //  humidity
        string pressure = data.body[0].value[0][2]; //  pressure
        string CO2 = data.body[0].value[0][3]; //  CO2

        lvDebug.Items.Add("Temperature: " + temperature);
        lvDebug.Items.Add("Humidity: " + humidity);
        lvDebug.Items.Add("Pressure: " + pressure);
        lvDebug.Items.Add("CO2: " + CO2);

        if (string.IsNullOrEmpty(temperature) == false)
        {
          outputToXML(temperature, humidity, pressure, CO2);
        }
      }
      catch (Exception e)
      {
        lvDebug.Items.Add("Error during measurement retrieval: " + e.Message);
      }
    }

    //Should use proper XML formatter here to prevent input errors but for the time being this works.
    private void outputToXML(string temperature, string humidity, string pressure, string C02)
    {
      string saveLocation = "WorldWeather_NetAtmo.xml";

      StreamWriter sw = new StreamWriter(saveLocation);
      sw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
      sw.WriteLine("<data>");
        sw.WriteLine("<provider>");
          sw.WriteLine("<name>NetAtmo</name>");
          sw.WriteLine("<version>1.0</version>");
        sw.WriteLine("</provider>");
        sw.WriteLine("<location>");
          sw.WriteLine("<city></city>");
          sw.WriteLine("<country>" + tbCountry.Text + "</country>");
          sw.WriteLine("<region></region>");
          sw.WriteLine("<postalcode></postalcode>");
          sw.WriteLine("<longitude>" + tbLongtitude.Text + "</longitude>");
          sw.WriteLine("<latitude>" + tbLatitude.Text + "</latitude>");
          sw.WriteLine("<altitude>" + tbAltitude.Text + "</altitude>");
          sw.WriteLine("<unit>SI</unit>");
        sw.WriteLine("</location>");
        sw.WriteLine("<current>");
        sw.WriteLine("<date>" + DateTime.Now.ToShortDateString() + "</date>");
          sw.WriteLine("<temperature>" + temperature + "</temperature>");
          sw.WriteLine("<temperatureFeelsLike></temperatureFeelsLike>");
          sw.WriteLine("<weatherCode></weatherCode>");
          sw.WriteLine("<weatherDescription></weatherDescription>");
          sw.WriteLine("<windSpeed></windSpeed>");
          sw.WriteLine("<windDirectionDegree></windDirectionDegree>");
          sw.WriteLine("<precipitation></precipitation>");
          sw.WriteLine("<pressure>" + pressure + "</pressure>");
          sw.WriteLine("<barometricPressure></barometricPressure>");
          sw.WriteLine("<humidity>" + humidity + "</humidity>");
          sw.WriteLine("<visibility></visibility>");
          sw.WriteLine("<cloudCoverage></cloudCoverage>");
          sw.WriteLine("<uvIndex></uvIndex>");
        sw.WriteLine("</current>");
        sw.WriteLine("<forecast>");
        sw.WriteLine("</forecast>");
      sw.WriteLine("</data>");
      sw.Close();

      lvDebug.Items.Add("Created XML file for World Weather plugin : " + saveLocation);
    }

    private void btnGetAuth_Click(object sender, EventArgs e)
    {
      AuthenticateOATH();
    }
    private void btnGetDeviceID_Click(object sender, EventArgs e)
    {
      getDeviceID();
    }

    private void btnGetMeasurements_Click(object sender, EventArgs e)
    {
      getMeasurements();
    }

    private void cbMeasurementsInterval_TextChanged(object sender, EventArgs e)
    {
      measurementInterval = int.Parse(cbMeasurementsInterval.Text);
    }

    private void cbMeasurementsInterval_TextUpdate(object sender, EventArgs e)
    {
      measurementInterval = int.Parse(cbMeasurementsInterval.Text);
    }

    private void cbUpdateMeasurementsBackground_CheckedChanged(object sender, EventArgs e)
    {
      if (cbUpdateMeasurementsBackground.Checked)
      {
        measuringManualHalt = false;
      }
      else
      {
        measuringManualHalt = true;
      }
    }
  }
}

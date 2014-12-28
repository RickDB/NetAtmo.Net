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

    public Form1()
    {
      InitializeComponent();
      AccessToken = tbAccessToken.Text;
      DeviceID = tbDeviceID.Text;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //Load settings later on
    }


    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      Properties.Settings.Default.Save();
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
            AuthenticateOATH();
            getDeviceID();
          }
        }
        else
        {
          AuthenticateOATH();
          getDeviceID();
        }

        string responseDecoded = System.Text.Encoding.UTF8.GetString(response);
        dynamic data = JsonConvert.DeserializeObject(responseDecoded);
        var id = data.body.devices[0]._id;

        DeviceID = (string)id;
        tbDeviceID.Text = DeviceID;
        lvDebug.Items.Add("Device ID: " + DeviceID);
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
        lvDebug.Items.Add("Error during Device ID retrieval: " + e.Message);
      }
    }
    private void getMeasurements()
    {
      try
      {
        if (string.IsNullOrEmpty(AccessToken))
        {
          AuthenticateOATH();
        }

        if (string.IsNullOrEmpty(DeviceID))
        {
          getDeviceID();
        }

        var response = new byte[10000];
        try
        {
          WebClient client = new WebClient();
          string url = "http://api.netatmo.net/api/getmeasure?access_token=" + AccessToken + "&device_id=" + DeviceID + "&type=Temperature,Humidity&limit=1&date_end=last&scale=30min";
          response = client.DownloadData(url);
        }
        catch (Exception e)
        {
          AuthenticateOATH();
          getDeviceID();
        }

        string responseDecoded = System.Text.Encoding.UTF8.GetString(response);
        dynamic data = JsonConvert.DeserializeObject(responseDecoded);

        var temperature = data.body[0].value[0][0]; // indoor temperature
        var humidity = data.body[0].value[0][1]; // indoor humidity
        lvDebug.Items.Add("Temperature: " + (string)temperature);
        lvDebug.Items.Add("Humidity: " + (string)humidity);
      }
      catch (Exception e)
      {
        lvDebug.Items.Add("Error during measurement retrieval: " + e.Message);
      }
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
  }
}

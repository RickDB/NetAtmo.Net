namespace NetAtmo.NET
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.lvDebug = new System.Windows.Forms.ListView();
      this.chLogEntry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.lblClientId = new System.Windows.Forms.Label();
      this.lblClientSecret = new System.Windows.Forms.Label();
      this.lblClientUsername = new System.Windows.Forms.Label();
      this.lblClientPassword = new System.Windows.Forms.Label();
      this.btnGetAuth = new System.Windows.Forms.Button();
      this.lblAccessToken = new System.Windows.Forms.Label();
      this.btnGetDeviceID = new System.Windows.Forms.Button();
      this.btnGetMeasurements = new System.Windows.Forms.Button();
      this.lblDeviceID = new System.Windows.Forms.Label();
      this.lblLong = new System.Windows.Forms.Label();
      this.lblLat = new System.Windows.Forms.Label();
      this.lblAlt = new System.Windows.Forms.Label();
      this.lblCountry = new System.Windows.Forms.Label();
      this.lblTimeZone = new System.Windows.Forms.Label();
      this.lblModule = new System.Windows.Forms.Label();
      this.cbMeasureType = new System.Windows.Forms.ComboBox();
      this.lblMeasureType = new System.Windows.Forms.Label();
      this.lblSaveMeasurements = new System.Windows.Forms.Label();
      this.cbUpdateMeasurementsBackground = new System.Windows.Forms.CheckBox();
      this.cbMeasurementsInterval = new System.Windows.Forms.ComboBox();
      this.tbModuleID = new System.Windows.Forms.TextBox();
      this.tbTimeZone = new System.Windows.Forms.TextBox();
      this.tbCountry = new System.Windows.Forms.TextBox();
      this.tbAltitude = new System.Windows.Forms.TextBox();
      this.tbLatitude = new System.Windows.Forms.TextBox();
      this.tbLongtitude = new System.Windows.Forms.TextBox();
      this.tbDeviceID = new System.Windows.Forms.TextBox();
      this.tbAccessToken = new System.Windows.Forms.TextBox();
      this.tbClientPassword = new System.Windows.Forms.TextBox();
      this.tbClientUsername = new System.Windows.Forms.TextBox();
      this.tbClientSecret = new System.Windows.Forms.TextBox();
      this.tbClientID = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lvDebug
      // 
      this.lvDebug.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLogEntry});
      this.lvDebug.Location = new System.Drawing.Point(13, 166);
      this.lvDebug.Name = "lvDebug";
      this.lvDebug.Size = new System.Drawing.Size(527, 261);
      this.lvDebug.TabIndex = 0;
      this.lvDebug.UseCompatibleStateImageBehavior = false;
      this.lvDebug.View = System.Windows.Forms.View.Details;
      // 
      // chLogEntry
      // 
      this.chLogEntry.Text = "Log entry";
      this.chLogEntry.Width = 506;
      // 
      // lblClientId
      // 
      this.lblClientId.AutoSize = true;
      this.lblClientId.Location = new System.Drawing.Point(12, 13);
      this.lblClientId.Name = "lblClientId";
      this.lblClientId.Size = new System.Drawing.Size(47, 13);
      this.lblClientId.TabIndex = 5;
      this.lblClientId.Text = "Client ID";
      // 
      // lblClientSecret
      // 
      this.lblClientSecret.AutoSize = true;
      this.lblClientSecret.Location = new System.Drawing.Point(12, 39);
      this.lblClientSecret.Name = "lblClientSecret";
      this.lblClientSecret.Size = new System.Drawing.Size(65, 13);
      this.lblClientSecret.TabIndex = 6;
      this.lblClientSecret.Text = "Client secret";
      // 
      // lblClientUsername
      // 
      this.lblClientUsername.AutoSize = true;
      this.lblClientUsername.Location = new System.Drawing.Point(12, 65);
      this.lblClientUsername.Name = "lblClientUsername";
      this.lblClientUsername.Size = new System.Drawing.Size(55, 13);
      this.lblClientUsername.TabIndex = 7;
      this.lblClientUsername.Text = "Username";
      // 
      // lblClientPassword
      // 
      this.lblClientPassword.AutoSize = true;
      this.lblClientPassword.Location = new System.Drawing.Point(12, 91);
      this.lblClientPassword.Name = "lblClientPassword";
      this.lblClientPassword.Size = new System.Drawing.Size(53, 13);
      this.lblClientPassword.TabIndex = 8;
      this.lblClientPassword.Text = "Password";
      // 
      // btnGetAuth
      // 
      this.btnGetAuth.Location = new System.Drawing.Point(343, 13);
      this.btnGetAuth.Name = "btnGetAuth";
      this.btnGetAuth.Size = new System.Drawing.Size(76, 43);
      this.btnGetAuth.TabIndex = 9;
      this.btnGetAuth.Text = "Get Auth";
      this.btnGetAuth.UseVisualStyleBackColor = true;
      this.btnGetAuth.Click += new System.EventHandler(this.btnGetAuth_Click);
      // 
      // lblAccessToken
      // 
      this.lblAccessToken.AutoSize = true;
      this.lblAccessToken.Location = new System.Drawing.Point(10, 520);
      this.lblAccessToken.Name = "lblAccessToken";
      this.lblAccessToken.Size = new System.Drawing.Size(76, 13);
      this.lblAccessToken.TabIndex = 11;
      this.lblAccessToken.Text = "Access Token";
      // 
      // btnGetDeviceID
      // 
      this.btnGetDeviceID.Location = new System.Drawing.Point(436, 14);
      this.btnGetDeviceID.Name = "btnGetDeviceID";
      this.btnGetDeviceID.Size = new System.Drawing.Size(104, 42);
      this.btnGetDeviceID.TabIndex = 12;
      this.btnGetDeviceID.Text = "Get Device ID";
      this.btnGetDeviceID.UseVisualStyleBackColor = true;
      this.btnGetDeviceID.Click += new System.EventHandler(this.btnGetDeviceID_Click);
      // 
      // btnGetMeasurements
      // 
      this.btnGetMeasurements.Location = new System.Drawing.Point(343, 65);
      this.btnGetMeasurements.Name = "btnGetMeasurements";
      this.btnGetMeasurements.Size = new System.Drawing.Size(197, 42);
      this.btnGetMeasurements.TabIndex = 13;
      this.btnGetMeasurements.Text = "Get Measurements";
      this.btnGetMeasurements.UseVisualStyleBackColor = true;
      this.btnGetMeasurements.Click += new System.EventHandler(this.btnGetMeasurements_Click);
      // 
      // lblDeviceID
      // 
      this.lblDeviceID.AutoSize = true;
      this.lblDeviceID.Location = new System.Drawing.Point(12, 436);
      this.lblDeviceID.Name = "lblDeviceID";
      this.lblDeviceID.Size = new System.Drawing.Size(41, 13);
      this.lblDeviceID.TabIndex = 15;
      this.lblDeviceID.Text = "Device";
      // 
      // lblLong
      // 
      this.lblLong.AutoSize = true;
      this.lblLong.Location = new System.Drawing.Point(12, 462);
      this.lblLong.Name = "lblLong";
      this.lblLong.Size = new System.Drawing.Size(31, 13);
      this.lblLong.TabIndex = 19;
      this.lblLong.Text = "Long";
      // 
      // lblLat
      // 
      this.lblLat.AutoSize = true;
      this.lblLat.Location = new System.Drawing.Point(131, 462);
      this.lblLat.Name = "lblLat";
      this.lblLat.Size = new System.Drawing.Size(22, 13);
      this.lblLat.TabIndex = 21;
      this.lblLat.Text = "Lat";
      // 
      // lblAlt
      // 
      this.lblAlt.AutoSize = true;
      this.lblAlt.Location = new System.Drawing.Point(230, 462);
      this.lblAlt.Name = "lblAlt";
      this.lblAlt.Size = new System.Drawing.Size(19, 13);
      this.lblAlt.TabIndex = 23;
      this.lblAlt.Text = "Alt";
      // 
      // lblCountry
      // 
      this.lblCountry.AutoSize = true;
      this.lblCountry.Location = new System.Drawing.Point(334, 462);
      this.lblCountry.Name = "lblCountry";
      this.lblCountry.Size = new System.Drawing.Size(43, 13);
      this.lblCountry.TabIndex = 25;
      this.lblCountry.Text = "Country";
      // 
      // lblTimeZone
      // 
      this.lblTimeZone.AutoSize = true;
      this.lblTimeZone.Location = new System.Drawing.Point(10, 494);
      this.lblTimeZone.Name = "lblTimeZone";
      this.lblTimeZone.Size = new System.Drawing.Size(56, 13);
      this.lblTimeZone.TabIndex = 27;
      this.lblTimeZone.Text = "Time zone";
      // 
      // lblModule
      // 
      this.lblModule.AutoSize = true;
      this.lblModule.Location = new System.Drawing.Point(186, 436);
      this.lblModule.Name = "lblModule";
      this.lblModule.Size = new System.Drawing.Size(42, 13);
      this.lblModule.TabIndex = 30;
      this.lblModule.Text = "Module";
      // 
      // cbMeasureType
      // 
      this.cbMeasureType.FormattingEnabled = true;
      this.cbMeasureType.Items.AddRange(new object[] {
            "Remote",
            "Station"});
      this.cbMeasureType.Location = new System.Drawing.Point(419, 433);
      this.cbMeasureType.Name = "cbMeasureType";
      this.cbMeasureType.Size = new System.Drawing.Size(121, 21);
      this.cbMeasureType.TabIndex = 31;
      this.cbMeasureType.Text = "Remote";
      // 
      // lblMeasureType
      // 
      this.lblMeasureType.AutoSize = true;
      this.lblMeasureType.Location = new System.Drawing.Point(362, 436);
      this.lblMeasureType.Name = "lblMeasureType";
      this.lblMeasureType.Size = new System.Drawing.Size(51, 13);
      this.lblMeasureType.TabIndex = 32;
      this.lblMeasureType.Text = "Measure:";
      // 
      // lblSaveMeasurements
      // 
      this.lblSaveMeasurements.AutoSize = true;
      this.lblSaveMeasurements.Location = new System.Drawing.Point(10, 121);
      this.lblSaveMeasurements.Name = "lblSaveMeasurements";
      this.lblSaveMeasurements.Size = new System.Drawing.Size(147, 13);
      this.lblSaveMeasurements.TabIndex = 33;
      this.lblSaveMeasurements.Text = "Read measurements every (s)";
      this.lblSaveMeasurements.Visible = false;
      // 
      // cbUpdateMeasurementsBackground
      // 
      this.cbUpdateMeasurementsBackground.AutoSize = true;
      this.cbUpdateMeasurementsBackground.Checked = global::NetAtmo.NET.Properties.Settings.Default.UpdateMeasurementsBackground;
      this.cbUpdateMeasurementsBackground.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetAtmo.NET.Properties.Settings.Default, "UpdateMeasurementsBackground", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.cbUpdateMeasurementsBackground.Location = new System.Drawing.Point(12, 143);
      this.cbUpdateMeasurementsBackground.Name = "cbUpdateMeasurementsBackground";
      this.cbUpdateMeasurementsBackground.Size = new System.Drawing.Size(248, 17);
      this.cbUpdateMeasurementsBackground.TabIndex = 35;
      this.cbUpdateMeasurementsBackground.Text = "Update measurements while program is running";
      this.cbUpdateMeasurementsBackground.UseVisualStyleBackColor = true;
      this.cbUpdateMeasurementsBackground.Visible = false;
      this.cbUpdateMeasurementsBackground.CheckedChanged += new System.EventHandler(this.cbUpdateMeasurementsBackground_CheckedChanged);
      // 
      // cbMeasurementsInterval
      // 
      this.cbMeasurementsInterval.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "MeasurementsInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.cbMeasurementsInterval.FormattingEnabled = true;
      this.cbMeasurementsInterval.Location = new System.Drawing.Point(163, 117);
      this.cbMeasurementsInterval.Name = "cbMeasurementsInterval";
      this.cbMeasurementsInterval.Size = new System.Drawing.Size(65, 21);
      this.cbMeasurementsInterval.TabIndex = 34;
      this.cbMeasurementsInterval.Text = global::NetAtmo.NET.Properties.Settings.Default.MeasurementsInterval;
      this.cbMeasurementsInterval.Visible = false;
      this.cbMeasurementsInterval.TextUpdate += new System.EventHandler(this.cbMeasurementsInterval_TextUpdate);
      this.cbMeasurementsInterval.TextChanged += new System.EventHandler(this.cbMeasurementsInterval_TextChanged);
      // 
      // tbModuleID
      // 
      this.tbModuleID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "ModuleID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbModuleID.Location = new System.Drawing.Point(233, 433);
      this.tbModuleID.Name = "tbModuleID";
      this.tbModuleID.ReadOnly = true;
      this.tbModuleID.Size = new System.Drawing.Size(123, 20);
      this.tbModuleID.TabIndex = 29;
      this.tbModuleID.Text = global::NetAtmo.NET.Properties.Settings.Default.ModuleID;
      // 
      // tbTimeZone
      // 
      this.tbTimeZone.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "TimeZone", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbTimeZone.Location = new System.Drawing.Point(90, 491);
      this.tbTimeZone.Name = "tbTimeZone";
      this.tbTimeZone.ReadOnly = true;
      this.tbTimeZone.Size = new System.Drawing.Size(153, 20);
      this.tbTimeZone.TabIndex = 28;
      this.tbTimeZone.Text = global::NetAtmo.NET.Properties.Settings.Default.TimeZone;
      // 
      // tbCountry
      // 
      this.tbCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "Country", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbCountry.Location = new System.Drawing.Point(383, 459);
      this.tbCountry.Name = "tbCountry";
      this.tbCountry.ReadOnly = true;
      this.tbCountry.Size = new System.Drawing.Size(157, 20);
      this.tbCountry.TabIndex = 26;
      this.tbCountry.Text = global::NetAtmo.NET.Properties.Settings.Default.Country;
      // 
      // tbAltitude
      // 
      this.tbAltitude.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "Altitude", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbAltitude.Location = new System.Drawing.Point(258, 459);
      this.tbAltitude.Name = "tbAltitude";
      this.tbAltitude.ReadOnly = true;
      this.tbAltitude.Size = new System.Drawing.Size(66, 20);
      this.tbAltitude.TabIndex = 24;
      this.tbAltitude.Text = global::NetAtmo.NET.Properties.Settings.Default.Altitude;
      // 
      // tbLatitude
      // 
      this.tbLatitude.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "Latitude", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbLatitude.Location = new System.Drawing.Point(159, 459);
      this.tbLatitude.Name = "tbLatitude";
      this.tbLatitude.ReadOnly = true;
      this.tbLatitude.Size = new System.Drawing.Size(66, 20);
      this.tbLatitude.TabIndex = 22;
      this.tbLatitude.Text = global::NetAtmo.NET.Properties.Settings.Default.Latitude;
      // 
      // tbLongtitude
      // 
      this.tbLongtitude.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "Longtitude", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbLongtitude.Location = new System.Drawing.Point(59, 459);
      this.tbLongtitude.Name = "tbLongtitude";
      this.tbLongtitude.ReadOnly = true;
      this.tbLongtitude.Size = new System.Drawing.Size(66, 20);
      this.tbLongtitude.TabIndex = 18;
      this.tbLongtitude.Text = global::NetAtmo.NET.Properties.Settings.Default.Longtitude;
      // 
      // tbDeviceID
      // 
      this.tbDeviceID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "DeviceID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbDeviceID.Location = new System.Drawing.Point(59, 433);
      this.tbDeviceID.Name = "tbDeviceID";
      this.tbDeviceID.ReadOnly = true;
      this.tbDeviceID.Size = new System.Drawing.Size(123, 20);
      this.tbDeviceID.TabIndex = 14;
      this.tbDeviceID.Text = global::NetAtmo.NET.Properties.Settings.Default.DeviceID;
      // 
      // tbAccessToken
      // 
      this.tbAccessToken.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "AccessToken", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbAccessToken.Location = new System.Drawing.Point(90, 517);
      this.tbAccessToken.Name = "tbAccessToken";
      this.tbAccessToken.ReadOnly = true;
      this.tbAccessToken.Size = new System.Drawing.Size(254, 20);
      this.tbAccessToken.TabIndex = 10;
      this.tbAccessToken.Text = global::NetAtmo.NET.Properties.Settings.Default.AccessToken;
      // 
      // tbClientPassword
      // 
      this.tbClientPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "ClientPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbClientPassword.Location = new System.Drawing.Point(90, 88);
      this.tbClientPassword.Name = "tbClientPassword";
      this.tbClientPassword.Size = new System.Drawing.Size(234, 20);
      this.tbClientPassword.TabIndex = 4;
      this.tbClientPassword.Text = global::NetAtmo.NET.Properties.Settings.Default.ClientPassword;
      // 
      // tbClientUsername
      // 
      this.tbClientUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "ClientUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbClientUsername.Location = new System.Drawing.Point(90, 62);
      this.tbClientUsername.Name = "tbClientUsername";
      this.tbClientUsername.Size = new System.Drawing.Size(234, 20);
      this.tbClientUsername.TabIndex = 3;
      this.tbClientUsername.Text = global::NetAtmo.NET.Properties.Settings.Default.ClientUsername;
      // 
      // tbClientSecret
      // 
      this.tbClientSecret.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "ClientSecret", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbClientSecret.Location = new System.Drawing.Point(90, 36);
      this.tbClientSecret.Name = "tbClientSecret";
      this.tbClientSecret.Size = new System.Drawing.Size(234, 20);
      this.tbClientSecret.TabIndex = 2;
      this.tbClientSecret.Text = global::NetAtmo.NET.Properties.Settings.Default.ClientSecret;
      // 
      // tbClientID
      // 
      this.tbClientID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "ClientID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbClientID.Location = new System.Drawing.Point(90, 10);
      this.tbClientID.Name = "tbClientID";
      this.tbClientID.Size = new System.Drawing.Size(234, 20);
      this.tbClientID.TabIndex = 1;
      this.tbClientID.Text = global::NetAtmo.NET.Properties.Settings.Default.ClientID;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(552, 588);
      this.Controls.Add(this.cbUpdateMeasurementsBackground);
      this.Controls.Add(this.cbMeasurementsInterval);
      this.Controls.Add(this.lblSaveMeasurements);
      this.Controls.Add(this.lblMeasureType);
      this.Controls.Add(this.cbMeasureType);
      this.Controls.Add(this.lblModule);
      this.Controls.Add(this.tbModuleID);
      this.Controls.Add(this.tbTimeZone);
      this.Controls.Add(this.lblTimeZone);
      this.Controls.Add(this.tbCountry);
      this.Controls.Add(this.lblCountry);
      this.Controls.Add(this.tbAltitude);
      this.Controls.Add(this.lblAlt);
      this.Controls.Add(this.tbLatitude);
      this.Controls.Add(this.lblLat);
      this.Controls.Add(this.lblLong);
      this.Controls.Add(this.tbLongtitude);
      this.Controls.Add(this.lblDeviceID);
      this.Controls.Add(this.tbDeviceID);
      this.Controls.Add(this.btnGetMeasurements);
      this.Controls.Add(this.btnGetDeviceID);
      this.Controls.Add(this.lblAccessToken);
      this.Controls.Add(this.tbAccessToken);
      this.Controls.Add(this.btnGetAuth);
      this.Controls.Add(this.lblClientPassword);
      this.Controls.Add(this.lblClientUsername);
      this.Controls.Add(this.lblClientSecret);
      this.Controls.Add(this.lblClientId);
      this.Controls.Add(this.tbClientPassword);
      this.Controls.Add(this.tbClientUsername);
      this.Controls.Add(this.tbClientSecret);
      this.Controls.Add(this.tbClientID);
      this.Controls.Add(this.lvDebug);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "NetAtmo .NET - 0.15";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView lvDebug;
    private System.Windows.Forms.TextBox tbClientID;
    private System.Windows.Forms.TextBox tbClientSecret;
    private System.Windows.Forms.TextBox tbClientUsername;
    private System.Windows.Forms.TextBox tbClientPassword;
    private System.Windows.Forms.Label lblClientId;
    private System.Windows.Forms.Label lblClientSecret;
    private System.Windows.Forms.Label lblClientUsername;
    private System.Windows.Forms.Label lblClientPassword;
    private System.Windows.Forms.Button btnGetAuth;
    private System.Windows.Forms.ColumnHeader chLogEntry;
    private System.Windows.Forms.TextBox tbAccessToken;
    private System.Windows.Forms.Label lblAccessToken;
    private System.Windows.Forms.Button btnGetDeviceID;
    private System.Windows.Forms.Button btnGetMeasurements;
    private System.Windows.Forms.Label lblDeviceID;
    private System.Windows.Forms.TextBox tbDeviceID;
    private System.Windows.Forms.Label lblLong;
    private System.Windows.Forms.TextBox tbLongtitude;
    private System.Windows.Forms.Label lblLat;
    private System.Windows.Forms.TextBox tbLatitude;
    private System.Windows.Forms.TextBox tbAltitude;
    private System.Windows.Forms.Label lblAlt;
    private System.Windows.Forms.TextBox tbCountry;
    private System.Windows.Forms.Label lblCountry;
    private System.Windows.Forms.TextBox tbTimeZone;
    private System.Windows.Forms.Label lblTimeZone;
    private System.Windows.Forms.Label lblModule;
    private System.Windows.Forms.TextBox tbModuleID;
    private System.Windows.Forms.ComboBox cbMeasureType;
    private System.Windows.Forms.Label lblMeasureType;
    private System.Windows.Forms.Label lblSaveMeasurements;
    private System.Windows.Forms.ComboBox cbMeasurementsInterval;
    private System.Windows.Forms.CheckBox cbUpdateMeasurementsBackground;
  }
}


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
      this.lvDebug.Location = new System.Drawing.Point(13, 126);
      this.lvDebug.Name = "lvDebug";
      this.lvDebug.Size = new System.Drawing.Size(527, 264);
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
      this.lblClientId.Location = new System.Drawing.Point(12, 25);
      this.lblClientId.Name = "lblClientId";
      this.lblClientId.Size = new System.Drawing.Size(47, 13);
      this.lblClientId.TabIndex = 5;
      this.lblClientId.Text = "Client ID";
      // 
      // lblClientSecret
      // 
      this.lblClientSecret.AutoSize = true;
      this.lblClientSecret.Location = new System.Drawing.Point(12, 51);
      this.lblClientSecret.Name = "lblClientSecret";
      this.lblClientSecret.Size = new System.Drawing.Size(65, 13);
      this.lblClientSecret.TabIndex = 6;
      this.lblClientSecret.Text = "Client secret";
      // 
      // lblClientUsername
      // 
      this.lblClientUsername.AutoSize = true;
      this.lblClientUsername.Location = new System.Drawing.Point(12, 77);
      this.lblClientUsername.Name = "lblClientUsername";
      this.lblClientUsername.Size = new System.Drawing.Size(55, 13);
      this.lblClientUsername.TabIndex = 7;
      this.lblClientUsername.Text = "Username";
      // 
      // lblClientPassword
      // 
      this.lblClientPassword.AutoSize = true;
      this.lblClientPassword.Location = new System.Drawing.Point(12, 103);
      this.lblClientPassword.Name = "lblClientPassword";
      this.lblClientPassword.Size = new System.Drawing.Size(53, 13);
      this.lblClientPassword.TabIndex = 8;
      this.lblClientPassword.Text = "Password";
      // 
      // btnGetAuth
      // 
      this.btnGetAuth.Location = new System.Drawing.Point(343, 21);
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
      this.lblAccessToken.Location = new System.Drawing.Point(204, 399);
      this.lblAccessToken.Name = "lblAccessToken";
      this.lblAccessToken.Size = new System.Drawing.Size(76, 13);
      this.lblAccessToken.TabIndex = 11;
      this.lblAccessToken.Text = "Access Token";
      // 
      // btnGetDeviceID
      // 
      this.btnGetDeviceID.Location = new System.Drawing.Point(436, 22);
      this.btnGetDeviceID.Name = "btnGetDeviceID";
      this.btnGetDeviceID.Size = new System.Drawing.Size(104, 42);
      this.btnGetDeviceID.TabIndex = 12;
      this.btnGetDeviceID.Text = "Get Device ID";
      this.btnGetDeviceID.UseVisualStyleBackColor = true;
      this.btnGetDeviceID.Click += new System.EventHandler(this.btnGetDeviceID_Click);
      // 
      // btnGetMeasurements
      // 
      this.btnGetMeasurements.Location = new System.Drawing.Point(343, 78);
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
      this.lblDeviceID.Location = new System.Drawing.Point(12, 399);
      this.lblDeviceID.Name = "lblDeviceID";
      this.lblDeviceID.Size = new System.Drawing.Size(41, 13);
      this.lblDeviceID.TabIndex = 15;
      this.lblDeviceID.Text = "Device";
      // 
      // tbDeviceID
      // 
      this.tbDeviceID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "DeviceID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbDeviceID.Location = new System.Drawing.Point(59, 396);
      this.tbDeviceID.Name = "tbDeviceID";
      this.tbDeviceID.ReadOnly = true;
      this.tbDeviceID.Size = new System.Drawing.Size(123, 20);
      this.tbDeviceID.TabIndex = 14;
      this.tbDeviceID.Text = global::NetAtmo.NET.Properties.Settings.Default.DeviceID;
      // 
      // tbAccessToken
      // 
      this.tbAccessToken.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "AccessToken", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbAccessToken.Location = new System.Drawing.Point(286, 396);
      this.tbAccessToken.Name = "tbAccessToken";
      this.tbAccessToken.ReadOnly = true;
      this.tbAccessToken.Size = new System.Drawing.Size(254, 20);
      this.tbAccessToken.TabIndex = 10;
      this.tbAccessToken.Text = global::NetAtmo.NET.Properties.Settings.Default.AccessToken;
      // 
      // tbClientPassword
      // 
      this.tbClientPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "ClientPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbClientPassword.Location = new System.Drawing.Point(90, 100);
      this.tbClientPassword.Name = "tbClientPassword";
      this.tbClientPassword.Size = new System.Drawing.Size(234, 20);
      this.tbClientPassword.TabIndex = 4;
      this.tbClientPassword.Text = global::NetAtmo.NET.Properties.Settings.Default.ClientPassword;
      // 
      // tbClientUsername
      // 
      this.tbClientUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "ClientUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbClientUsername.Location = new System.Drawing.Point(90, 74);
      this.tbClientUsername.Name = "tbClientUsername";
      this.tbClientUsername.Size = new System.Drawing.Size(234, 20);
      this.tbClientUsername.TabIndex = 3;
      this.tbClientUsername.Text = global::NetAtmo.NET.Properties.Settings.Default.ClientUsername;
      // 
      // tbClientSecret
      // 
      this.tbClientSecret.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "ClientSecret", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbClientSecret.Location = new System.Drawing.Point(90, 48);
      this.tbClientSecret.Name = "tbClientSecret";
      this.tbClientSecret.Size = new System.Drawing.Size(234, 20);
      this.tbClientSecret.TabIndex = 2;
      this.tbClientSecret.Text = global::NetAtmo.NET.Properties.Settings.Default.ClientSecret;
      // 
      // tbClientID
      // 
      this.tbClientID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetAtmo.NET.Properties.Settings.Default, "ClientID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbClientID.Location = new System.Drawing.Point(90, 22);
      this.tbClientID.Name = "tbClientID";
      this.tbClientID.Size = new System.Drawing.Size(234, 20);
      this.tbClientID.TabIndex = 1;
      this.tbClientID.Text = global::NetAtmo.NET.Properties.Settings.Default.ClientID;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(552, 418);
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
      this.Text = "NetAtmo .NET";
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
  }
}


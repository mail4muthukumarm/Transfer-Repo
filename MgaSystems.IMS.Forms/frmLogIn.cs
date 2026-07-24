// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmLogIn
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.Common.CustomExceptions;
using MGASystems.Common.DataAccess;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.LogonServer;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.Serialization;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[Preference("Screens.Login.Username", "", true)]
[Preference("Screens.Login.RememberMe.Enabled", false, true)]
public class frmLogIn : Form, ILogInForm
{
  private IContainer components;
  internal const string Preference_LoginName = "Screens.Login.Username";
  internal const string Preference_LoginRememberMe = "Screens.Login.RememberMe.Enabled";
  private bool _loginSuccess;
  private bool _painted;
  private const int CS_DROPSHADOW = 131072 /*0x020000*/;

  [field: AccessedThroughProperty("txtPassword")]
  protected virtual MGATextBox txtPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtUsername")]
  protected virtual MGATextBox txtUsername { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnLogin
  {
    get => this._btnLogin;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnLogin_Click);
      MGAButton btnLogin1 = this._btnLogin;
      if (btnLogin1 != null)
        ((Control) btnLogin1).Click -= eventHandler;
      this._btnLogin = value;
      MGAButton btnLogin2 = this._btnLogin;
      if (btnLogin2 == null)
        return;
      ((Control) btnLogin2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("pbLogo")]
  protected virtual PictureBox pbLogo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLoginStatus")]
  protected virtual Label lblLoginStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ContextMenu1")]
  protected virtual ContextMenu ContextMenu1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MenuItem MenuItem1
  {
    get => this._MenuItem1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MenuItem1_Click);
      MenuItem menuItem1_1 = this._MenuItem1;
      if (menuItem1_1 != null)
        menuItem1_1.Click -= eventHandler;
      this._MenuItem1 = value;
      MenuItem menuItem1_2 = this._MenuItem1;
      if (menuItem1_2 == null)
        return;
      menuItem1_2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("err")]
  protected virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  protected virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  protected virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGroupBox UltraGroupBox1
  {
    get => this._UltraGroupBox1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.UltraGroupBox1_Click);
      UltraGroupBox ultraGroupBox1_1 = this._UltraGroupBox1;
      if (ultraGroupBox1_1 != null)
        ((Control) ultraGroupBox1_1).Click -= eventHandler;
      this._UltraGroupBox1 = value;
      UltraGroupBox ultraGroupBox1_2 = this._UltraGroupBox1;
      if (ultraGroupBox1_2 == null)
        return;
      ((Control) ultraGroupBox1_2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkRemember")]
  protected virtual MGACheckBox chkRemember { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    this.txtPassword = new MGATextBox();
    this.btnLogin = new MGAButton();
    this.btnCancel = new MGAButton();
    this.txtUsername = new MGATextBox();
    this.lblLoginStatus = new Label();
    this.ContextMenu1 = new ContextMenu();
    this.MenuItem1 = new MenuItem();
    this.err = new ErrorProvider(this.components);
    this.chkRemember = new MGACheckBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.UltraGroupBox1 = new UltraGroupBox();
    this.pbLogo = new PictureBox();
    ((ISupportInitialize) this.txtPassword).BeginInit();
    ((ISupportInitialize) this.btnLogin).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.txtUsername).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.chkRemember).BeginInit();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.pbLogo).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPassword).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtPassword).BackColor = Color.White;
    ((Control) this.txtPassword).Enabled = false;
    ((Control) this.txtPassword).Location = new Point(86, 360);
    this.txtPassword.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPassword).Name = "txtPassword";
    this.txtPassword.PasswordChar = '*';
    ((Control) this.txtPassword).Size = new Size(206, 20);
    ((Control) this.txtPassword).TabIndex = 1;
    ((UltraControlBase) this.txtPassword).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPassword).UseOsThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnLogin).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnLogin).BackColorInternal = SystemColors.Control;
    ((Control) this.btnLogin).Enabled = false;
    ((Control) this.btnLogin).Location = new Point(86, 405);
    ((Control) this.btnLogin).Name = "btnLogin";
    ((Control) this.btnLogin).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnLogin).TabIndex = 2;
    ((ControlBase) this.btnLogin).Text = "&Login";
    this.btnLogin.UseOSThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.btnCancel).BackColorInternal = SystemColors.Control;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Enabled = false;
    ((Control) this.btnCancel).Location = new Point(212, 405);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnCancel).TabIndex = 3;
    ((ControlBase) this.btnCancel).Text = "&Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtUsername).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtUsername).BackColor = Color.White;
    ((Control) this.txtUsername).Enabled = false;
    ((Control) this.txtUsername).Location = new Point(86, 300);
    this.txtUsername.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtUsername).Name = "txtUsername";
    ((Control) this.txtUsername).Size = new Size(206, 20);
    ((Control) this.txtUsername).TabIndex = 0;
    ((UltraControlBase) this.txtUsername).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtUsername).UseOsThemes = (DefaultableBoolean) 2;
    this.lblLoginStatus.Location = new Point(40, 384);
    this.lblLoginStatus.Name = "lblLoginStatus";
    this.lblLoginStatus.Size = new Size(296, 15);
    this.lblLoginStatus.TabIndex = 21;
    this.lblLoginStatus.TextAlign = ContentAlignment.MiddleCenter;
    this.ContextMenu1.MenuItems.AddRange(new MenuItem[1]
    {
      this.MenuItem1
    });
    this.MenuItem1.Index = 0;
    this.MenuItem1.Text = "View/Update my CD-Key";
    this.err.ContainerControl = (ContainerControl) this;
    appearance5.BorderColor = Color.Gray;
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkRemember).Appearance = (AppearanceBase) appearance5;
    ((UltraToggleEditorBase) this.chkRemember).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkRemember).Location = new Point(88, 440);
    ((Control) this.chkRemember).Name = "chkRemember";
    ((Control) this.chkRemember).Size = new Size(120, 20);
    ((Control) this.chkRemember).TabIndex = 22;
    ((UltraToggleEditorBase) this.chkRemember).Text = "Remember Me";
    ((UltraControlBase) this.chkRemember).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkRemember).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(84, 275);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(86, 19);
    this.Label1.TabIndex = 23;
    this.Label1.Text = "Username:";
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(82, 335);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(82, 19);
    this.Label2.TabIndex = 24;
    this.Label2.Text = "Password:";
    this.UltraGroupBox1.BorderStyle = (GroupBoxBorderStyle) 12;
    appearance6.BorderColor = Color.Black;
    this.UltraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance6;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.pbLogo);
    this.UltraGroupBox1.Dock = DockStyle.Fill;
    ((Control) this.UltraGroupBox1).Location = new Point(0, 0);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(381, 474);
    ((Control) this.UltraGroupBox1).TabIndex = 25;
    this.pbLogo.BackColor = Color.Transparent;
    this.pbLogo.Image = (Image) MGASystems.IMS.Forms.My.Resources.Resources.MGA_Logo_Small;
    this.pbLogo.Location = new Point(12, 12);
    this.pbLogo.Name = "pbLogo";
    this.pbLogo.Size = new Size(357, 260);
    this.pbLogo.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pbLogo.TabIndex = 20;
    this.pbLogo.TabStop = false;
    this.AcceptButton = (IButtonControl) this.btnLogin;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(381, 474);
    this.ContextMenu = this.ContextMenu1;
    this.ControlBox = false;
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.chkRemember);
    this.Controls.Add((Control) this.lblLoginStatus);
    this.Controls.Add((Control) this.txtUsername);
    this.Controls.Add((Control) this.txtPassword);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnLogin);
    this.Controls.Add((Control) this.UltraGroupBox1);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (frmLogIn);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Log-In";
    ((ISupportInitialize) this.txtPassword).EndInit();
    ((ISupportInitialize) this.btnLogin).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.txtUsername).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.chkRemember).EndInit();
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.pbLogo).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmLogIn()
  {
    this.Activated += new EventHandler(this.frmLogIn_Activated);
    this.InitializeComponent();
    string str = Path.Combine(Application.StartupPath, "logo.ims");
    if (!System.IO.File.Exists(str))
      return;
    try
    {
      this.pbLogo.Image = Image.FromFile(str);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public bool LoginSuccess => this.OnLoginSuccess();

  protected virtual bool OnLoginSuccess() => this._loginSuccess;

  protected virtual void OnLoginLoad()
  {
    if (this.DesignMode)
      return;
    this.CancelButton = (IButtonControl) this.btnCancel;
    ((Control) this.chkRemember).Enabled = true;
    ((Control) this.txtUsername).Enabled = true;
    ((Control) this.txtPassword).Enabled = true;
    ((Control) this.btnLogin).Enabled = true;
    ((Control) this.btnCancel).Enabled = true;
    ((UltraToggleEditorBase) this.chkRemember).Checked = Preferences.GetPreferenceBool("Screens.Login.RememberMe.Enabled");
    if (((UltraToggleEditorBase) this.chkRemember).Checked)
      ((TextEditorControlBase) this.txtUsername).Text = Preferences.GetPreferenceString("Screens.Login.Username");
    this.SetStatusBarText("Please Login");
    this.AutoFillDeveloperCredentials();
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtUsername).Text) || string.IsNullOrEmpty(((TextEditorControlBase) this.txtPassword).Text))
      return;
    object appSetting = (object) ConfigurationManager.AppSettings["AutoLogin"];
    if (appSetting == null)
      return;
    bool result;
    bool.TryParse(appSetting.ToString(), out result);
    if (!result)
      return;
    this.DoLogon();
  }

  public void AutoFillDeveloperCredentials()
  {
    try
    {
      if (!frmLogIn.IsOnMGADomain)
        return;
      Encryption encryption = new Encryption();
      using (SqlConnection connection = new SqlConnection(encryption.DecryptTripleDes("YttKmr201xW09ISpEZMNWGCM7b9AO/vvPQe083HvC1bNsOk64O+UR0zTtKZtz/HqISxi/2I3+cQEA8wAQjkMEYfqzVumk97TVdEDSLT/3L4=")))
      {
        using (SqlCommand sqlCommand = new SqlCommand(encryption.DecryptTripleDes("XCHV5UYLRHe8C7AeVJWgkPKQG3LLAeu12ZQg9Nc8vl0="), connection)
        {
          CommandType = CommandType.StoredProcedure
        })
        {
          if (((string) new AppSettingsReader().GetValue("LogOnDomainName", typeof (string))).StartsWith(encryption.DecryptTripleDes("ou+EyB437F1vRDceBzbpiw==")))
            sqlCommand.Parameters.AddWithValue(encryption.DecryptTripleDes("4S6a7EYIIINe7TJI9ueyWYXdThj+7bL7"), (object) encryption.DecryptTripleDes("0IZBHKfHsmqskPxeinin9ninAqjez+YcwujCPkrw5CJGhbloSD1hvA=="));
          else
            sqlCommand.Parameters.AddWithValue(encryption.DecryptTripleDes("4S6a7EYIIINe7TJI9ueyWYXdThj+7bL7"), (object) encryption.DecryptTripleDes("0IZBHKfHsmqskPxeinin9m9ENx4HNumL"));
          connection.Open();
          string base64Text1 = sqlCommand.ExecuteScalar() as string;
          if (!string.IsNullOrEmpty(base64Text1))
            ((TextEditorControlBase) this.txtPassword).Text = encryption.DecryptTripleDes(base64Text1);
          sqlCommand.Parameters.Clear();
          sqlCommand.Parameters.AddWithValue(encryption.DecryptTripleDes("4S6a7EYIIINe7TJI9ueyWYXdThj+7bL7"), (object) encryption.DecryptTripleDes("0IZBHKfHsmqOPv2z7pNWhlXRA0i0/9y+"));
          string base64Text2 = sqlCommand.ExecuteScalar() as string;
          if (string.IsNullOrEmpty(base64Text2))
            return;
          ((TextEditorControlBase) this.txtUsername).Text = encryption.DecryptTripleDes(base64Text2);
        }
      }
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ex2.InnerException?.Message, "The network path was not found", false) != 0)
        ErrorHandler.SilentHandleError(ex2);
      ProjectData.ClearProjectError();
    }
  }

  protected override void OnLoad(EventArgs e)
  {
    base.OnLoad(e);
    this.OnLoginLoad();
  }

  private static bool IsOnMGADomain
  {
    get
    {
      bool isOnMgaDomain;
      try
      {
        Dns.GetHostEntry("teammga");
        isOnMgaDomain = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        isOnMgaDomain = false;
        ProjectData.ClearProjectError();
      }
      return isOnMgaDomain;
    }
  }

  private void frmLogIn_Activated(object sender, EventArgs e)
  {
    if (this._painted)
      return;
    this._painted = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtUsername).Text, string.Empty, false) != 0)
      ((TextEditorControlBase) this.txtPassword).Focus();
    else
      ((TextEditorControlBase) this.txtUsername).Focus();
  }

  private void MenuItem1_Click(object sender, EventArgs e)
  {
    frmUpdateCDKey frmUpdateCdKey = new frmUpdateCDKey();
    try
    {
      if (frmUpdateCdKey.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      int num = (int) MessageBox.Show("The IMS must be resarted in order for this change to take effect");
      this.Owner.Close();
    }
    finally
    {
      frmUpdateCdKey.Dispose();
    }
  }

  protected virtual void SetStatusBarText(string text)
  {
    MDIControls.Instance.StatusBar.Text = text;
  }

  protected virtual void PerformCurrentUserLogon(string username, string password)
  {
    CurrentUser.Instance.Login(username, password);
  }

  protected virtual bool ValidForm()
  {
    bool flag = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtUsername).Text, string.Empty, false) == 0)
    {
      this.err.SetError((Control) this.txtUsername, "Please enter your username");
      ((TextEditorControlBase) this.txtUsername).Focus();
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtUsername, string.Empty);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtPassword).Text, string.Empty, false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.err.GetError((Control) this.txtUsername), string.Empty, false) == 0)
        ((TextEditorControlBase) this.txtPassword).Focus();
      this.err.SetError((Control) this.txtPassword, "Please enter your username");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtPassword, string.Empty);
    return flag;
  }

  private void LogonThread(object state)
  {
    this.BetterInvoke((Delegate) new frmLogIn.LogonCompleteHandler(this.LogonComplete), (object) (!IMSClientLogOn.UseLogOnService ? IMSClientLogOn.LogonUser(((TextEditorControlBase) this.txtUsername).Text, ((TextEditorControlBase) this.txtPassword).Text, ServerXML.LogOnServerXMLVersion) : IMSClientLogOn.NewLogonUser(((TextEditorControlBase) this.txtUsername).Text, ((TextEditorControlBase) this.txtPassword).Text)));
  }

  public static bool InitializeDataObjects(
    string connectionString,
    string userName,
    string password)
  {
    string str = $". {"\r\n"}Would you like to run diagnostics?";
    MGASystems.BusinessObjects.Common.UserName = userName;
    MGASystems.BusinessObjects.Common.UserPassword = password;
    SqlConnection sqlConnection = new SqlConnection(connectionString);
    bool flag;
    try
    {
      sqlConnection.Open();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      sqlConnection.Close();
      int num = (int) MessageBox.Show($"The IMS was unable to connect to the database after a succesful login.{"\n"}{"\n"}Please contact technical support.{"\n"}{"\n"}{exception.Message}{str}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      flag = false;
      ProjectData.ClearProjectError();
      goto label_20;
    }
    finally
    {
      sqlConnection.Dispose();
    }
    Database.Initialize((Control) MDIControls.Instance.MDIParent, connectionString);
    if (string.IsNullOrEmpty(DefaultDatabase.ConnectionString))
      DefaultDatabase.ConnectionString = connectionString;
    MGASystems.IMS.NoteDocuments.Common.Initialize(connectionString, (Control) MDIControls.Instance.MDIParent, (ICurrentUser) CurrentUser.Instance);
    try
    {
      CurrentUser instance = CurrentUser.Instance;
      instance.ConnectionString = connectionString;
      MGASystems.BusinessObjects.Common.ConnectionString = instance.ConnectionString;
      try
      {
        CurrentUser.Instance.Login(userName, password);
      }
      catch (UserAlreadyLoggedInException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show($"Your user account is already logged into the system.{"\n"}{"\n"}If you believe this is in error, please contact your system administrator to reset your login.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_20;
      }
      catch (InvalidOperationException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        if (ex.Message.IndexOf("Microsoft Data Access Components") != -1)
        {
          int num = (int) MessageBox.Show($"Your version of the Microsoft Data Access Components (MDAC) is out of date.{"\n"}{"\n"}Please install the latest copy of MDAC from the Microsoft web site, and re-run the IMS.", "Invalid MDAC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          flag = false;
          ProjectData.ClearProjectError();
          goto label_20;
        }
        ProjectData.ClearProjectError();
      }
      MGASystems.IMS.DocumentAutomation.Common.Initialize(connectionString, (Control) MDIControls.Instance.MDIParent, CurrentUser.Instance.UserGUID);
      CurrentUser.Instance.LogAction("Logged In");
      SecurityManager.Initialize(CurrentUser.Instance.UserGUID);
      SecurityManager.Instance.Reset();
      try
      {
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "Update tblUsers set IsNetFx40FullInstalled = @isInstalled where UserGuid = @UserGuid", new object[4]
        {
          (object) "@isInstalled",
          (object) (DotnetEnvironment.IsNetFx40FullInstalled() ? 1 : 0),
          (object) "@UserGuid",
          (object) CurrentUser.Instance.UserGUID
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      Cursor.Current = Cursors.Default;
      int num = (int) MessageBox.Show(SR.GetString("LO_GENERAL_NETWORK_ERROR"), SR.GetString("LO_FAIL_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      flag = false;
      ProjectData.ClearProjectError();
      goto label_20;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
    }
    flag = true;
label_20:
    return flag;
  }

  private void LogonComplete(IMSClientLogOn.LogonReturn logonReturn)
  {
    try
    {
      if (logonReturn.LogonStatus != IMSClientLogOn.LogonStatus.Ok)
      {
        switch (logonReturn.LogonStatus)
        {
          case IMSClientLogOn.LogonStatus.InvalidUserName:
          case IMSClientLogOn.LogonStatus.InvalidPassword:
            if (CurrentUser.Instance.UsingXP)
            {
              BalloonTip.ShowEditTip(logonReturn.LogonStatus != IMSClientLogOn.LogonStatus.InvalidUserName ? (Control) this.txtPassword : (Control) this.txtUsername, "Login Failed", logonReturn.LogonMessage, BalloonTip.BalloonTipIcons.Exclamation);
              break;
            }
            int num1 = (int) MessageBox.Show(logonReturn.LogonMessage, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;
          case IMSClientLogOn.LogonStatus.AccessDenied:
            int num2 = (int) MessageBox.Show($"Access denied {logonReturn.LogonMessage}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          case IMSClientLogOn.LogonStatus.HostError:
            int num3 = (int) MessageBox.Show($"Host error {logonReturn.LogonMessage}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          case IMSClientLogOn.LogonStatus.InvalidProtocol:
            int num4 = (int) MessageBox.Show($"Invalid protocol {logonReturn.LogonMessage}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          case IMSClientLogOn.LogonStatus.LocalError:
            int num5 = (int) MessageBox.Show($"Local error {logonReturn.LogonMessage}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          case IMSClientLogOn.LogonStatus.InvalidDomain:
            int num6 = (int) MessageBox.Show($"Invalid domain {logonReturn.LogonMessage}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          default:
            int num7 = (int) MessageBox.Show(logonReturn.LogonMessage, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
        }
        Cursor.Current = Cursors.Default;
        this.SetFormEnabled(true);
        this.lblLoginStatus.Text = "Invalid Logon";
        this.lblLoginStatus.Refresh();
        return;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(IMSClientLogOn.DatabaseConnection, string.Empty, false) == 0)
        throw new InvalidOperationException("Invalid connection string returned from IMS client login.");
      this.lblLoginStatus.Text = "User Authenticated";
      this.lblLoginStatus.Refresh();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show($"An error has occured while trying to log in.{"\n"}{"\n"}Please contact technical support.{"\n"}{"\n"}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.SetFormEnabled(true);
      ProjectData.ClearProjectError();
      return;
    }
    string databaseConnection = IMSClientLogOn.DatabaseConnection;
    SqlConnection sqlConnection = new SqlConnection(databaseConnection);
    try
    {
      sqlConnection.Open();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      sqlConnection.Close();
      int num = (int) MessageBox.Show($"The IMS was unable to connect to the database after a succesful login.{"\n"}{"\n"}Please contact technical support.{"\n"}{"\n"}{exception.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.SetFormEnabled(true);
      ProjectData.ClearProjectError();
      return;
    }
    finally
    {
      sqlConnection.Dispose();
    }
    Database.Initialize((Control) MDIControls.Instance.MDIParent, databaseConnection);
    if (string.IsNullOrEmpty(DefaultDatabase.ConnectionString))
      DefaultDatabase.ConnectionString = databaseConnection;
    MGASystems.IMS.NoteDocuments.Common.Initialize(databaseConnection, (Control) MDIControls.Instance.MDIParent, (ICurrentUser) CurrentUser.Instance);
    try
    {
      this.lblLoginStatus.Text = "Retrieving user information...";
      this.lblLoginStatus.Refresh();
      CurrentUser instance = CurrentUser.Instance;
      instance.ConnectionString = databaseConnection;
      MGASystems.BusinessObjects.Common.ConnectionString = instance.ConnectionString;
      try
      {
        this.PerformCurrentUserLogon(((TextEditorControlBase) this.txtUsername).Text, ((TextEditorControlBase) this.txtPassword).Text);
      }
      catch (UserAlreadyLoggedInException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show($"Your user account is already logged into the system.{"\n"}{"\n"}If you believe this is in error, please contact your system administrator to reset your login.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.SetFormEnabled(true);
        ProjectData.ClearProjectError();
        return;
      }
      catch (InvalidOperationException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        if (ex.Message.IndexOf("Microsoft Data Access Components") != -1)
        {
          int num = (int) MessageBox.Show($"Your version of the Microsoft Data Access Components (MDAC) is out of date.{"\n"}{"\n"}Please install the latest copy of MDAC from the Microsoft web site, and re-run the IMS.", "Invalid MDAC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.SetFormEnabled(true);
          ProjectData.ClearProjectError();
          return;
        }
        ProjectData.ClearProjectError();
      }
      MGASystems.IMS.DocumentAutomation.Common.Initialize(databaseConnection, (Control) MDIControls.Instance.MDIParent, CurrentUser.Instance.UserGUID);
      this.lblLoginStatus.Text = "Retrieving custom settings...";
      Preferences.SetPreference("Screens.Login.RememberMe.Enabled", ((UltraToggleEditorBase) this.chkRemember).Checked);
      if (((UltraToggleEditorBase) this.chkRemember).Checked)
        Preferences.SetPreference("Screens.Login.Username", ((TextEditorControlBase) this.txtUsername).Text);
      this.SetStatusBarText($"{CurrentUser.Instance.FirstName} {CurrentUser.Instance.LastName} logged in at {DateAndTime.Now}");
      CurrentUser.Instance.LogAction("Logged In");
      SecurityManager.Initialize(CurrentUser.Instance.UserGUID);
      SecurityManager.Instance.Reset();
      this._loginSuccess = true;
      try
      {
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "Update tblUsers set IsNetFx40FullInstalled = @isInstalled where UserGuid = @UserGuid", new object[4]
        {
          (object) "@isInstalled",
          (object) (DotnetEnvironment.IsNetFx40FullInstalled() ? 1 : 0),
          (object) "@UserGuid",
          (object) CurrentUser.Instance.UserGUID
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      Cursor.Current = Cursors.Default;
      int num = (int) MessageBox.Show(SR.GetString("LO_GENERAL_NETWORK_ERROR"), SR.GetString("LO_FAIL_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.SetFormEnabled(true);
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
      if (!this._loginSuccess)
        this.SetFormEnabled(true);
    }
  }

  protected virtual void DoLogon()
  {
    if (!this.ValidForm())
      return;
    Cursor.Current = Cursors.WaitCursor;
    this.SetFormEnabled(false);
    this.lblLoginStatus.Text = "Verifying username and password...";
    this.lblLoginStatus.Refresh();
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.LogonThread));
  }

  protected void SetFormEnabled(bool IsEnabled)
  {
    ((Control) this.btnLogin).Enabled = IsEnabled;
    ((Control) this.btnCancel).Enabled = IsEnabled;
    ((Control) this.txtPassword).Enabled = IsEnabled;
    ((Control) this.txtUsername).Enabled = IsEnabled;
    if (!IsEnabled)
      return;
    ((TextEditorControlBase) this.txtPassword).Focus();
    ((TextEditorControlBase) this.txtPassword).SelectAll();
  }

  private void btnLogin_Click(object sender, EventArgs e) => this.DoLogon();

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this._loginSuccess = false;
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (!this.pbLogo.IsDisposed)
        this.pbLogo.Dispose();
    }
    base.Dispose(disposing);
  }

  protected override CreateParams CreateParams
  {
    get
    {
      CreateParams createParams1;
      if (frmLogIn.UsingWindowsXP())
      {
        CreateParams createParams2 = base.CreateParams;
        createParams2.ClassStyle |= 131072 /*0x020000*/;
        createParams1 = createParams2;
      }
      else
        createParams1 = base.CreateParams;
      return createParams1;
    }
  }

  private static bool UsingWindowsXP()
  {
    return Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1 || Environment.OSVersion.Version.Minor > 5;
  }

  private void UltraGroupBox1_Click(object sender, EventArgs e)
  {
  }

  private delegate void LogonCompleteHandler(IMSClientLogOn.LogonReturn logonReturn);
}

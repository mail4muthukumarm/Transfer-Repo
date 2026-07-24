// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ErrorHandling.FormCustomExceptionHandler
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common.Functions;
using MGASystems.Common.MgaReportingServices;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace MGASystems.Common.ErrorHandling;

[DesignerGenerated]
public sealed class FormCustomExceptionHandler : Form
{
  private IContainer components;
  private Label Label1;
  private PictureBox PictureBox1;
  private Label Label2;
  private BouncingProgress BouncingProgress;
  private Label lblSupportID;
  private Image _desktopImage;
  private readonly Exception _ex;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton DetailsButton
  {
    get => this._DetailsButton;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DetailsButton_Click);
      MGAButton detailsButton1 = this._DetailsButton;
      if (detailsButton1 != null)
        ((Control) detailsButton1).Click -= eventHandler;
      this._DetailsButton = value;
      MGAButton detailsButton2 = this._DetailsButton;
      if (detailsButton2 == null)
        return;
      ((Control) detailsButton2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("FlowLayoutPanel1")]
  internal virtual FlowLayoutPanel FlowLayoutPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBoxSending")]
  internal virtual TextBox TextBoxSending { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormCustomExceptionHandler));
    Appearance appearance = new Appearance();
    this.Label1 = new Label();
    this.PictureBox1 = new PictureBox();
    this.Label2 = new Label();
    this.BouncingProgress = new BouncingProgress();
    this.lblSupportID = new Label();
    this.DetailsButton = new MGAButton();
    this.FlowLayoutPanel1 = new FlowLayoutPanel();
    this.TextBoxSending = new TextBox();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.DetailsButton).BeginInit();
    this.SuspendLayout();
    this.Label1.Font = new Font("Tahoma", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(114, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(324, 32 /*0x20*/);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "An Error Has Occured";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(12, 12);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(96 /*0x60*/, 88);
    this.PictureBox1.TabIndex = 1;
    this.PictureBox1.TabStop = false;
    this.Label2.Location = new Point(114, 41);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(318, 59);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "An error report is being generated, and will be sent to MGA Systems for further analysis. \r\nOnce the error report has been sent, please contact MGA Systems tech support to troubleshoot this error.";
    this.BouncingProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.BouncingProgress.Border = BorderStyle.Fixed3D;
    this.BouncingProgress.BorderColor = Color.DarkGray;
    this.BouncingProgress.Bounce = false;
    this.BouncingProgress.BounceColor = SystemColors.Highlight;
    this.BouncingProgress.Location = new Point(12, 192 /*0xC0*/);
    this.BouncingProgress.Name = "BouncingProgress";
    this.BouncingProgress.Size = new Size(346, 12);
    this.BouncingProgress.TabIndex = 6;
    this.BouncingProgress.Visible = false;
    this.lblSupportID.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lblSupportID.AutoSize = true;
    this.lblSupportID.Font = new Font("Tahoma", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblSupportID.Location = new Point(364, 192 /*0xC0*/);
    this.lblSupportID.Name = "lblSupportID";
    this.lblSupportID.Size = new Size(74, 12);
    this.lblSupportID.TabIndex = 8;
    this.lblSupportID.Text = "Support ID 123";
    ((Control) this.DetailsButton).Anchor = AnchorStyles.Top;
    appearance.BackColor = Color.FromArgb(248, 248, 248);
    appearance.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance.BackGradientStyle = (GradientStyle) 2;
    appearance.BorderColor = Color.DarkGray;
    appearance.ImageHAlign = (HAlign) 2;
    appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.DetailsButton).Appearance = (AppearanceBase) appearance;
    ((ControlBase) this.DetailsButton).BackColorInternal = Color.WhiteSmoke;
    ((Control) this.DetailsButton).Location = new Point(169, 102);
    ((Control) this.DetailsButton).Name = "DetailsButton";
    ((Control) this.DetailsButton).Size = new Size(112 /*0x70*/, 32 /*0x20*/);
    ((Control) this.DetailsButton).TabIndex = 5;
    ((ControlBase) this.DetailsButton).Text = "Details";
    this.DetailsButton.UseOSThemes = (DefaultableBoolean) 2;
    this.FlowLayoutPanel1.AutoSize = true;
    this.FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.FlowLayoutPanel1.Location = new Point(107, 123);
    this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
    this.FlowLayoutPanel1.Size = new Size(0, 0);
    this.FlowLayoutPanel1.TabIndex = 9;
    this.FlowLayoutPanel1.WrapContents = false;
    this.TextBoxSending.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.TextBoxSending.Location = new Point(12, 141);
    this.TextBoxSending.Multiline = true;
    this.TextBoxSending.Name = "TextBoxSending";
    this.TextBoxSending.ScrollBars = ScrollBars.Vertical;
    this.TextBoxSending.Size = new Size(426, 45);
    this.TextBoxSending.TabIndex = 10;
    this.TextBoxSending.Text = "Sending error report ...";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(450, 214);
    this.Controls.Add((Control) this.TextBoxSending);
    this.Controls.Add((Control) this.DetailsButton);
    this.Controls.Add((Control) this.FlowLayoutPanel1);
    this.Controls.Add((Control) this.lblSupportID);
    this.Controls.Add((Control) this.BouncingProgress);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.PictureBox1);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormCustomExceptionHandler);
    this.Text = "IMS Error Reporting Service";
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.DetailsButton).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public FormCustomExceptionHandler(Exception ex)
  {
    this.Load += new EventHandler(this.FormCustomExceptionHandler_Load);
    this.FormClosing += new FormClosingEventHandler(this.FormCustomExceptionHandler_FormClosing);
    this.InitializeComponent();
    this._ex = ex;
  }

  private void SendErrorReport()
  {
    Exception exception = (Exception) null;
    string message = "Your error report was received successfully.";
    int num;
    try
    {
      int supportCenterClientId = CurrentUser.Instance.SupportCenterClientID;
      string userName = CurrentUser.Instance.UserName;
      if (string.IsNullOrEmpty(userName))
      {
        userName = $"Unknown User: {Environment.MachineName}/{Environment.UserName}";
        if (userName.Length > 45)
          userName = userName.Substring(0, 45);
      }
      string secondaryErrorMessage = string.Empty;
      if (this._ex.InnerException != null)
        secondaryErrorMessage = this._ex.InnerException.Message;
      StringBuilder stringBuilder = new StringBuilder(this._ex.Message);
      if (this._ex.Data != null && this._ex.Data.Count > 0)
      {
        stringBuilder.AppendLine("");
        foreach (object obj in this._ex.Data)
        {
          DictionaryEntry dictionaryEntry = obj != null ? (DictionaryEntry) obj : new DictionaryEntry();
          stringBuilder.AppendLine($"Exception Data Key: {RuntimeHelpers.GetObjectValue(dictionaryEntry.Key)}, Value: {RuntimeHelpers.GetObjectValue(dictionaryEntry.Value)}");
        }
      }
      string stackTrace1 = (string) null;
      if (string.IsNullOrEmpty(this._ex.StackTrace) & this._ex.TargetSite != null)
      {
        try
        {
          stackTrace1 = $"TargetSite: {this._ex.TargetSite.ReflectedType.FullName}.{this._ex.TargetSite.Name}";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      else if (!string.IsNullOrEmpty(this._ex.StackTrace))
      {
        string stackTrace2 = this._ex.StackTrace;
        Func<char, string> selector;
        // ISSUE: reference to a compiler-generated field
        if (FormCustomExceptionHandler._Closure\u0024__.\u0024I23\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector = FormCustomExceptionHandler._Closure\u0024__.\u0024I23\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          FormCustomExceptionHandler._Closure\u0024__.\u0024I23\u002D0 = selector = (Func<char, string>) ([SpecialName] (c) => !XmlConvert.IsXmlChar(c) ? "?" : Conversions.ToString(c));
        }
        stackTrace1 = string.Concat(stackTrace2.Select<char, string>(selector));
      }
      using (CriticalErrorService criticalErrorService = new CriticalErrorService())
      {
        if (ConfigurationManager.AppSettings["CriticalErrorServiceURL"] != null)
          criticalErrorService.Url = ConfigurationManager.AppSettings["CriticalErrorServiceURL"];
        using (MemoryStream memoryStream = new MemoryStream())
        {
          this._desktopImage.Save((Stream) memoryStream, ImageFormat.Png);
          try
          {
            if (this._ex is SqlException)
            {
              SqlException ex = (SqlException) this._ex;
              num = criticalErrorService.ReportCriticalErrorSqlWithScreenshot(supportCenterClientId, userName, stringBuilder.ToString(), secondaryErrorMessage, stackTrace1, this._ex.GetType().ToString(), memoryStream.ToArray(), ex.Procedure, ex.LineNumber);
            }
            else
              num = this._ex.InnerException != null ? criticalErrorService.ReportCriticalError(supportCenterClientId, userName, stringBuilder.ToString(), secondaryErrorMessage, stackTrace1, this._ex.GetType().ToString(), memoryStream.ToArray(), this._ex.InnerException.Source, this._ex.InnerException.StackTrace, this._ex.InnerException.TargetSite?.ToString(), this._ex.InnerException.GetType().ToString()) : criticalErrorService.ReportCriticalError(supportCenterClientId, userName, stringBuilder.ToString(), secondaryErrorMessage, stackTrace1, this._ex.GetType().ToString(), memoryStream.ToArray());
          }
          catch (WebException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            exception = (Exception) ex;
            ProjectData.ClearProjectError();
          }
          catch (SoapException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            exception = (Exception) ex;
            ProjectData.ClearProjectError();
          }
          catch (InvalidOperationException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            exception = (Exception) ex;
            ProjectData.ClearProjectError();
          }
          finally
          {
            if (this._desktopImage != null)
            {
              this._desktopImage.Dispose();
              this._desktopImage = (Image) null;
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      exception = ex;
      ProjectData.ClearProjectError();
    }
    if (exception != null)
    {
      message = Environment.NewLine + $"We were unable to send the error report at this time.{Environment.NewLine}{Environment.NewLine}" + $"Please contact technical support with the following information:{Environment.NewLine}{Environment.NewLine}" + $"{exception.Message}{Environment.NewLine}{Environment.NewLine}" + $"{exception.StackTrace}";
      MGASystems.IMS.Logging.Log.Write(message, "MgaSystems.IMS.Common.ErrorHandling");
      this.Invoke((Delegate) ([SpecialName] () => this.Height += 150));
    }
    if (num > 1)
      message = $"{message}{Environment.NewLine}Error ID: {Conversions.ToString(num)}";
    this.SetErrorReportSent(message);
  }

  private void SetErrorReportSent(string message)
  {
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new Action<string>(this.SetErrorReportSent), (object) message);
    }
    else
    {
      TextBox textBoxSending;
      string str = (textBoxSending = this.TextBoxSending).Text + Environment.NewLine + message;
      textBoxSending.Text = str;
      this.BouncingProgress.Hide();
      this.BouncingProgress.Bounce = false;
    }
  }

  public void GetDesktopImage()
  {
    try
    {
      this.Refresh();
      Application.DoEvents();
      this._desktopImage = ScreenCapture.GetDesktopImage();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void FormCustomExceptionHandler_Load(object sender, EventArgs e)
  {
    this.lblSupportID.Text = $"Client ID {CurrentUser.Instance.SupportCenterClientID}";
    bool flag = false;
    try
    {
      flag = CurrentUser.IsMGADeveloper || SystemSettings.GetBoolSetting("ErrorHandling.EnableDetailedDialog");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    if (!flag)
      ((Control) this.DetailsButton).Hide();
    this.RunErrorReporting();
  }

  private void FormCustomExceptionHandler_FormClosing(object sender, FormClosingEventArgs e)
  {
  }

  public void RunErrorReporting()
  {
    this.TextBoxSending.Visible = true;
    this.BouncingProgress.Visible = true;
    this.BouncingProgress.Bounce = true;
    new Thread(new ThreadStart(this.SendErrorReport))
    {
      Name = "Exception Report Sending Thread"
    }.Start();
  }

  private void DetailsButton_Click(object sender, EventArgs e)
  {
    int num = (int) new FormDeveloperDebugHelper(this._ex).ShowDialog();
  }
}

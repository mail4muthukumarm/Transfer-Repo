// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Controls.Forms.MGAWebView
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.Controls.Forms;

public class MGAWebView : UserControl, IWebBrowserController, IDisposable
{
  private const string WebView2BrowserName = "WebView2";
  private readonly IWebBrowserController webBrowserController;
  private IContainer components;
  private Microsoft.Web.WebView2.WinForms.WebView2 webView;
  private Label lblWarning;

  public static string AvailableBrowserVersionString { get; } = MGAWebViewSettings.GetAvailableBrowserVersionString();

  public static string ActiveBrowserVersionString => MGAWebView.AvailableBrowserVersionString;

  public event EventHandler LoadCompleted;

  public event EventHandler BrowserInitialized;

  public event EventHandler<Uri> SourceChanged;

  public event EventHandler<MouseButtonClickedEventArgs> MouseButtonClicked;

  public MGAWebView()
  {
    this.InitializeComponent();
    if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
      return;
    if (MGAWebView.ActiveBrowserVersionString.Contains("WebView2"))
    {
      this.webBrowserController = (IWebBrowserController) new FormWebView2Controller(this.webView);
      this.lblWarning?.Hide();
    }
    else
    {
      this.webBrowserController = (IWebBrowserController) new WebViewWarningController();
      this.lblWarning.Text = "In order to provide a secure browsing experience for hosted content in the IMS, MGA Systems is following Microsoft guidance and requiring their WebView2 browsing component to be installed.\nIf the WebView2 component is not installed we will not be able to render web based content.\nIf you have any questions or concerns please contact MGA Systems Tech Support (TechSupport@MGASystems.com).";
      ((Control) this.webView)?.Hide();
    }
    this.webBrowserController.LoadCompleted += new EventHandler(this.WebBrowserController_LoadCompleted);
    this.webBrowserController.SourceChanged += new EventHandler<Uri>(this.WebBrowserController_SourceChanged);
    this.webBrowserController.BrowserInitialized += new EventHandler(this.WebBrowserController_BrowserInitialized);
    this.webBrowserController.MouseButtonClicked += new EventHandler<MouseButtonClickedEventArgs>(this.WebBrowserController_MouseButtonClicked);
  }

  private async void MGAWebView_Load(object sender, EventArgs e)
  {
    if (!MGAWebView.ActiveBrowserVersionString.Contains("WebView2"))
      return;
    await this.webView.EnsureCoreWebView2Async((CoreWebView2Environment) null);
  }

  private void WebBrowserController_LoadCompleted(object sender, EventArgs e)
  {
    EventHandler loadCompleted = this.LoadCompleted;
    if (loadCompleted == null)
      return;
    loadCompleted(sender, EventArgs.Empty);
  }

  private void WebBrowserController_BrowserInitialized(object sender, EventArgs e)
  {
    EventHandler browserInitialized = this.BrowserInitialized;
    if (browserInitialized == null)
      return;
    browserInitialized(sender, EventArgs.Empty);
  }

  private void WebBrowserController_SourceChanged(object sender, Uri e)
  {
    EventHandler<Uri> sourceChanged = this.SourceChanged;
    if (sourceChanged == null)
      return;
    sourceChanged(sender, e);
  }

  private void WebBrowserController_MouseButtonClicked(object sender, MouseButtonClickedEventArgs e)
  {
    EventHandler<MouseButtonClickedEventArgs> mouseButtonClicked = this.MouseButtonClicked;
    if (mouseButtonClicked == null)
      return;
    mouseButtonClicked(sender, e);
  }

  public void Navigate(string source) => this.webBrowserController.Navigate(new Uri(source));

  public void Navigate(Uri source) => this.webBrowserController.Navigate(source);

  public void NavigateToString(string text) => this.webBrowserController.NavigateToString(text);

  public void Navigate(string source, byte[] postData, string additionalHeaders)
  {
    this.webBrowserController.Navigate(source, postData, additionalHeaders);
  }

  public void ReleaseWebBrowserControl() => this.webBrowserController.ReleaseWebBrowserControl();

  public Task<string> GetElementValueByIdAsync(string id)
  {
    return this.webBrowserController.GetElementValueByIdAsync(id);
  }

  public void AddOrUpdateCookie(Cookie cookie)
  {
    this.webBrowserController.AddOrUpdateCookie(cookie);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    this.lblWarning?.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
    this.lblWarning = new Label();
    ((ISupportInitialize) this.webView).BeginInit();
    this.SuspendLayout();
    this.webView.CreationProperties = (CoreWebView2CreationProperties) null;
    this.webView.DefaultBackgroundColor = Color.White;
    ((Control) this.webView).Dock = DockStyle.Fill;
    ((Control) this.webView).Location = new Point(0, 0);
    ((Control) this.webView).Name = "webView";
    ((Control) this.webView).Size = new Size(765, 612);
    ((Control) this.webView).TabIndex = 0;
    this.webView.ZoomFactor = 1.0;
    this.lblWarning.Dock = DockStyle.Fill;
    this.lblWarning.Location = new Point(0, 0);
    this.lblWarning.MinimumSize = new Size(20, 20);
    this.lblWarning.Name = "lblWarning";
    this.lblWarning.Size = new Size(765, 612);
    this.lblWarning.TabIndex = 1;
    this.lblWarning.TextAlign = ContentAlignment.MiddleCenter;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.lblWarning);
    this.Controls.Add((Control) this.webView);
    this.Name = nameof (MGAWebView);
    this.Size = new Size(765, 612);
    this.Load += new EventHandler(this.MGAWebView_Load);
    ((ISupportInitialize) this.webView).EndInit();
    this.ResumeLayout(false);
  }
}

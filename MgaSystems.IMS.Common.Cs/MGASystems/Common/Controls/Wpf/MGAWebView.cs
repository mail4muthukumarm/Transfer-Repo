// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Controls.Wpf.MGAWebView
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Microsoft.Web.WebView2.Core;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

#nullable disable
namespace MGASystems.Common.Controls.Wpf;

public class MGAWebView : UserControl, IWebBrowserController, IDisposable, IComponentConnector
{
  private const string WebView2BrowserName = "WebView2";
  private readonly IWebBrowserController webBrowserController;
  [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
  internal ContentControl browserHost;
  private bool _contentLoaded;

  public static string AvailableBrowserVersionString { get; } = MGAWebViewSettings.GetAvailableBrowserVersionString();

  public static string ActiveBrowserVersionString => MGAWebView.AvailableBrowserVersionString;

  public event EventHandler LoadCompleted;

  public event EventHandler BrowserInitialized;

  public event EventHandler<Uri> SourceChanged;

  public event EventHandler<MouseButtonClickedEventArgs> MouseButtonClicked;

  public MGAWebView()
  {
    this.InitializeComponent();
    if (MGAWebView.ActiveBrowserVersionString.Contains("WebView2"))
    {
      this.browserHost.Content = (object) new Microsoft.Web.WebView2.Wpf.WebView2();
      this.webBrowserController = (IWebBrowserController) new WebView2Controller((Microsoft.Web.WebView2.Wpf.WebView2) this.browserHost.Content);
    }
    else
    {
      ContentControl browserHost = this.browserHost;
      Label label = new Label();
      label.Content = (object) new TextBlock()
      {
        Text = "In order to provide a secure browsing experience for hosted content in the IMS, MGA Systems is following Microsoft guidance and requiring their WebView2 browsing component to be installed.\nIf the WebView2 component is not installed we will not be able to render web based content.\nIf you have any questions or concerns please contact MGA Systems Tech Support (TechSupport@MGASystems.com).",
        TextWrapping = TextWrapping.Wrap
      };
      label.VerticalContentAlignment = VerticalAlignment.Center;
      label.HorizontalContentAlignment = HorizontalAlignment.Center;
      browserHost.Content = (object) label;
      this.webBrowserController = (IWebBrowserController) new WebViewWarningController();
    }
    this.webBrowserController.LoadCompleted += new EventHandler(this.WebBrowserController_LoadCompleted);
    this.webBrowserController.SourceChanged += new EventHandler<Uri>(this.WebBrowserController_SourceChanged);
    this.webBrowserController.BrowserInitialized += new EventHandler(this.WebBrowserController_BrowserInitialized);
    this.webBrowserController.MouseButtonClicked += new EventHandler<MouseButtonClickedEventArgs>(this.WebBrowserController_SubmitButtonClicked);
  }

  private async void UserControl_Loaded(object sender, RoutedEventArgs e)
  {
    if (!MGAWebView.ActiveBrowserVersionString.Contains("WebView2"))
      return;
    await ((Microsoft.Web.WebView2.Wpf.WebView2) this.browserHost.Content).EnsureCoreWebView2Async((CoreWebView2Environment) null);
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

  private void WebBrowserController_SubmitButtonClicked(
    object sender,
    MouseButtonClickedEventArgs e)
  {
    EventHandler<MouseButtonClickedEventArgs> mouseButtonClicked = this.MouseButtonClicked;
    if (mouseButtonClicked == null)
      return;
    mouseButtonClicked(sender, e);
  }

  private void WebBrowserController_SourceChanged(object sender, Uri e)
  {
    EventHandler<Uri> sourceChanged = this.SourceChanged;
    if (sourceChanged == null)
      return;
    sourceChanged(sender, e);
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

  public void Dispose()
  {
    this.webBrowserController.Dispose();
    GC.SuppressFinalize((object) this);
  }

  public void AddOrUpdateCookie(Cookie cookie)
  {
    this.webBrowserController.AddOrUpdateCookie(cookie);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Common.Cs;component/controls/wpf/mgawebview.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  [SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
  [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
  [SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    if (connectionId != 1)
    {
      if (connectionId == 2)
        this.browserHost = (ContentControl) target;
      else
        this._contentLoaded = true;
    }
    else
      ((FrameworkElement) target).Loaded += new RoutedEventHandler(this.UserControl_Loaded);
  }
}

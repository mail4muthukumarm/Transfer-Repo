// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Controls.Forms.FormWebView2Controller
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Microsoft.Web.WebView2.Core;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

#nullable disable
namespace MGASystems.Common.Controls.Forms;

internal class FormWebView2Controller : IWebBrowserController, IDisposable
{
  private Microsoft.Web.WebView2.WinForms.WebView2 webView2;

  public event EventHandler LoadCompleted;

  public event EventHandler BrowserInitialized;

  public event EventHandler<Uri> SourceChanged;

  public event EventHandler<MouseButtonClickedEventArgs> MouseButtonClicked;

  public FormWebView2Controller(Microsoft.Web.WebView2.WinForms.WebView2 control)
  {
    this.webView2 = control;
    this.webView2.CoreWebView2InitializationCompleted += new EventHandler<CoreWebView2InitializationCompletedEventArgs>(this.WebView2_CoreWebView2InitializationCompleted);
    this.webView2.NavigationCompleted += new EventHandler<CoreWebView2NavigationCompletedEventArgs>(this.WebView2_NavigationCompleted);
    this.webView2.SourceChanged += new EventHandler<CoreWebView2SourceChangedEventArgs>(this.WebView2_SourceChanged);
  }

  private void WebView2_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
  {
    string webMessageAsString = e.TryGetWebMessageAsString();
    if (!webMessageAsString.StartsWith("MGAmousedown"))
      return;
    string[] strArray = webMessageAsString.Split(':');
    MouseButtonClickedEventArgs e1 = new MouseButtonClickedEventArgs();
    if (strArray.Length <= 3)
      return;
    e1.ID = strArray[1];
    e1.ClassName = strArray[2];
    e1.TagName = strArray[3];
    EventHandler<MouseButtonClickedEventArgs> mouseButtonClicked = this.MouseButtonClicked;
    if (mouseButtonClicked == null)
      return;
    mouseButtonClicked(sender, e1);
  }

  private async void WebView2_CoreWebView2InitializationCompleted(
    object sender,
    CoreWebView2InitializationCompletedEventArgs e)
  {
    if (e.IsSuccess && this.webView2 != null && this.webView2.CoreWebView2 != null && this.webView2.CoreWebView2.Settings != null)
    {
      this.webView2.CoreWebView2.Settings.IsWebMessageEnabled = true;
      this.webView2.CoreWebView2.Settings.IsGeneralAutofillEnabled = MGAWebViewSettings.IsGeneralAutofillEnabled;
      this.webView2.CoreWebView2.WebMessageReceived += new EventHandler<CoreWebView2WebMessageReceivedEventArgs>(this.WebView2_WebMessageReceived);
      string documentCreatedAsync = await this.webView2.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("document.addEventListener('mousedown', function(event) {\r\n    let postMessage = 'MGAmousedown:';\r\n    let ele1 = document.elementFromPoint(event.clientX, event.clientY);\r\n    if (ele1 !== undefined && ele1 !== null) {\r\n        let eleId = ele1.getAttribute('id');\r\n        if (eleId !== undefined && eleId !== null) {\r\n            postMessage += ele1.getAttribute('id');\r\n            postMessage += ':';\r\n            postMessage += ele1.getAttribute('class');\r\n            postMessage += ':';\r\n            postMessage += ele1.tagName;\r\n        } else {\r\n            let eleParent = ele1.parentElement;\r\n            if(eleParent !== undefined && eleParent !== null) {\r\n                postMessage += eleParent.getAttribute('id');\r\n                postMessage += ':';\r\n                postMessage += eleParent.getAttribute('class');\r\n                postMessage += ':';\r\n                postMessage += eleParent.tagName;\r\n            }\r\n        }\r\n    }\r\n    window.chrome.webview.postMessage(postMessage);\r\n});");
      this.webView2.CoreWebView2.Settings.IsPasswordAutosaveEnabled = true;
    }
    else if (e.InitializationException != null)
      ExceptionDispatchInfo.Capture(e.InitializationException).Throw();
    EventHandler browserInitialized = this.BrowserInitialized;
    if (browserInitialized == null)
      return;
    browserInitialized(sender, EventArgs.Empty);
  }

  private void WebView2_NavigationCompleted(
    object sender,
    CoreWebView2NavigationCompletedEventArgs e)
  {
    EventHandler loadCompleted = this.LoadCompleted;
    if (loadCompleted == null)
      return;
    loadCompleted(sender, EventArgs.Empty);
  }

  private void WebView2_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
  {
    EventHandler<Uri> sourceChanged = this.SourceChanged;
    if (sourceChanged == null)
      return;
    sourceChanged(sender, this.webView2.Source);
  }

  public void AddOrUpdateCookie(Cookie cookie)
  {
    this.webView2.CoreWebView2.CookieManager.AddOrUpdateCookie(this.webView2.CoreWebView2.CookieManager.CreateCookie(cookie.Name, cookie.Value, cookie.Domain, cookie.Path));
  }

  public void Dispose() => ((Component) this.webView2)?.Dispose();

  public async Task<string> GetElementValueByIdAsync(string id)
  {
    string str = await this.webView2.ExecuteScriptAsync($"document.getElementById('{id}').getAttribute('value')");
    return string.IsNullOrEmpty(str) ? str : (str == "null" ? (string) null : str.Replace("\"", ""));
  }

  public void Navigate(string source) => this.webView2.Source = new Uri(source);

  public void Navigate(Uri source) => this.webView2.Source = source;

  public void Navigate(string source, byte[] postData, string additionalHeaders)
  {
    using (MemoryStream memoryStream = new MemoryStream(postData))
      this.webView2.CoreWebView2.NavigateWithWebResourceRequest(this.webView2.CoreWebView2.Environment.CreateWebResourceRequest(source, "POST", (Stream) memoryStream, additionalHeaders));
  }

  public void NavigateToString(string text) => this.webView2.NavigateToString(text);

  public void ReleaseWebBrowserControl()
  {
    this.webView2.NavigationCompleted -= new EventHandler<CoreWebView2NavigationCompletedEventArgs>(this.WebView2_NavigationCompleted);
    this.webView2.SourceChanged -= new EventHandler<CoreWebView2SourceChangedEventArgs>(this.WebView2_SourceChanged);
    ((Component) this.webView2).Dispose();
    this.webView2 = (Microsoft.Web.WebView2.WinForms.WebView2) null;
    GC.Collect();
    GC.WaitForPendingFinalizers();
    GC.Collect();
  }
}

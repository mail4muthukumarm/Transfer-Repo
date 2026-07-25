// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Controls.IWebBrowserController
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.Net;
using System.Threading.Tasks;

#nullable disable
namespace MGASystems.Common.Controls;

internal interface IWebBrowserController : IDisposable
{
  void Navigate(string source);

  void Navigate(Uri source);

  void NavigateToString(string text);

  void Navigate(string source, byte[] postData, string additionalHeaders);

  event EventHandler LoadCompleted;

  event EventHandler BrowserInitialized;

  event EventHandler<Uri> SourceChanged;

  event EventHandler<MouseButtonClickedEventArgs> MouseButtonClicked;

  void ReleaseWebBrowserControl();

  Task<string> GetElementValueByIdAsync(string id);

  void AddOrUpdateCookie(Cookie cookie);
}

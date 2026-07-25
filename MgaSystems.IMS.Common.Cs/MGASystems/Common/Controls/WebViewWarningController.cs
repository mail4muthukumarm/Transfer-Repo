// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Controls.WebViewWarningController
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.Net;
using System.Threading.Tasks;

#nullable disable
namespace MGASystems.Common.Controls;

internal class WebViewWarningController : IWebBrowserController, IDisposable
{
  public event EventHandler LoadCompleted
  {
    add
    {
    }
    remove
    {
    }
  }

  public event EventHandler BrowserInitialized
  {
    add
    {
    }
    remove
    {
    }
  }

  public event EventHandler<Uri> SourceChanged
  {
    add
    {
    }
    remove
    {
    }
  }

  public event EventHandler<MouseButtonClickedEventArgs> MouseButtonClicked
  {
    add
    {
    }
    remove
    {
    }
  }

  public void AddOrUpdateCookie(Cookie cookie)
  {
  }

  public void Dispose()
  {
  }

  public Task<string> GetElementValueByIdAsync(string id) => Task.FromResult<string>(string.Empty);

  public void Navigate(string source)
  {
  }

  public void Navigate(Uri source)
  {
  }

  public void Navigate(string source, byte[] postData, string additionalHeaders)
  {
  }

  public void NavigateToString(string text)
  {
  }

  public void ReleaseWebBrowserControl()
  {
  }
}

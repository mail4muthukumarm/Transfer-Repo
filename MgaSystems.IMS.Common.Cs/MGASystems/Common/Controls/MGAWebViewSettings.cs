// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Controls.MGAWebViewSettings
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Microsoft.Web.WebView2.Core;

#nullable disable
namespace MGASystems.Common.Controls;

public static class MGAWebViewSettings
{
  internal const string EventListenerScriptMouseDown = "document.addEventListener('mousedown', function(event) {\r\n    let postMessage = 'MGAmousedown:';\r\n    let ele1 = document.elementFromPoint(event.clientX, event.clientY);\r\n    if (ele1 !== undefined && ele1 !== null) {\r\n        let eleId = ele1.getAttribute('id');\r\n        if (eleId !== undefined && eleId !== null) {\r\n            postMessage += ele1.getAttribute('id');\r\n            postMessage += ':';\r\n            postMessage += ele1.getAttribute('class');\r\n            postMessage += ':';\r\n            postMessage += ele1.tagName;\r\n        } else {\r\n            let eleParent = ele1.parentElement;\r\n            if(eleParent !== undefined && eleParent !== null) {\r\n                postMessage += eleParent.getAttribute('id');\r\n                postMessage += ':';\r\n                postMessage += eleParent.getAttribute('class');\r\n                postMessage += ':';\r\n                postMessage += eleParent.tagName;\r\n            }\r\n        }\r\n    }\r\n    window.chrome.webview.postMessage(postMessage);\r\n});";
  internal const string WarningLabelText = "In order to provide a secure browsing experience for hosted content in the IMS, MGA Systems is following Microsoft guidance and requiring their WebView2 browsing component to be installed.\nIf the WebView2 component is not installed we will not be able to render web based content.\nIf you have any questions or concerns please contact MGA Systems Tech Support (TechSupport@MGASystems.com).";

  internal static string GetAvailableBrowserVersionString()
  {
    try
    {
      return "WebView2: " + CoreWebView2Environment.GetAvailableBrowserVersionString((string) null);
    }
    catch
    {
      return "WebBrowser";
    }
  }

  internal static bool IsGeneralAutofillEnabled { get; } = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("MGAWebViewSettings.IsGeneralAutofillEnabled");
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.iixService.auth
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.Common.iixService;

[GeneratedCode("System.Web.Services", "4.8.4084.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "AuthSoapBinding", Namespace = "http://com/iix/soap/SoapAuth.wsdl")]
public class auth : SoapHttpClientProtocol
{
  private SendOrPostCallback sendRequest2OperationCompleted;
  private SendOrPostCallback sendRequestOperationCompleted;
  private SendOrPostCallback getResponseOperationCompleted;
  private SendOrPostCallback getResponse2OperationCompleted;
  private SendOrPostCallback getXmlResponseOperationCompleted;
  private SendOrPostCallback getXmlResponse2OperationCompleted;
  private SendOrPostCallback getPdfResponseOperationCompleted;
  private SendOrPostCallback getPdfResponse2OperationCompleted;
  private bool useDefaultCredentialsSetExplicitly;

  public auth()
  {
    this.Url = "https://expressnet.iix.com:8903/web-services/Auth?WSDL";
    if (this.IsLocalFileSystemWebService(this.Url))
    {
      this.UseDefaultCredentials = true;
      this.useDefaultCredentialsSetExplicitly = false;
    }
    else
      this.useDefaultCredentialsSetExplicitly = true;
  }

  public new string Url
  {
    get => base.Url;
    set
    {
      if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
        base.UseDefaultCredentials = false;
      base.Url = value;
    }
  }

  public new bool UseDefaultCredentials
  {
    get => base.UseDefaultCredentials;
    set
    {
      base.UseDefaultCredentials = value;
      this.useDefaultCredentialsSetExplicitly = true;
    }
  }

  public event sendRequest2CompletedEventHandler sendRequest2Completed;

  public event sendRequestCompletedEventHandler sendRequestCompleted;

  public event getResponseCompletedEventHandler getResponseCompleted;

  public event getResponse2CompletedEventHandler getResponse2Completed;

  public event getXmlResponseCompletedEventHandler getXmlResponseCompleted;

  public event getXmlResponse2CompletedEventHandler getXmlResponse2Completed;

  public event getPdfResponseCompletedEventHandler getPdfResponseCompleted;

  public event getPdfResponse2CompletedEventHandler getPdfResponse2Completed;

  [SoapRpcMethod("", RequestNamespace = "auth", ResponseNamespace = "http://com/iix/soap/SoapAuth.wsdl")]
  [return: SoapElement("return")]
  public string sendRequest2(string msgString)
  {
    return Conversions.ToString(this.Invoke(nameof (sendRequest2), new object[1]
    {
      (object) msgString
    })[0]);
  }

  public void sendRequest2Async(string msgString)
  {
    this.sendRequest2Async(msgString, (object) null);
  }

  public void sendRequest2Async(string msgString, object userState)
  {
    if (this.sendRequest2OperationCompleted == null)
      this.sendRequest2OperationCompleted = new SendOrPostCallback(this.OnsendRequest2OperationCompleted);
    this.InvokeAsync("sendRequest2", new object[1]
    {
      (object) msgString
    }, this.sendRequest2OperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnsendRequest2OperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.sendRequest2CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    sendRequest2CompletedEventHandler request2CompletedEvent = this.sendRequest2CompletedEvent;
    if (request2CompletedEvent == null)
      return;
    request2CompletedEvent((object) this, new sendRequest2CompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapRpcMethod("", RequestNamespace = "auth", ResponseNamespace = "http://com/iix/soap/SoapAuth.wsdl")]
  [return: SoapElement("return")]
  public string sendRequest(string msgString)
  {
    return Conversions.ToString(this.Invoke(nameof (sendRequest), new object[1]
    {
      (object) msgString
    })[0]);
  }

  public void sendRequestAsync(string msgString) => this.sendRequestAsync(msgString, (object) null);

  public void sendRequestAsync(string msgString, object userState)
  {
    if (this.sendRequestOperationCompleted == null)
      this.sendRequestOperationCompleted = new SendOrPostCallback(this.OnsendRequestOperationCompleted);
    this.InvokeAsync("sendRequest", new object[1]
    {
      (object) msgString
    }, this.sendRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnsendRequestOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.sendRequestCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    sendRequestCompletedEventHandler requestCompletedEvent = this.sendRequestCompletedEvent;
    if (requestCompletedEvent == null)
      return;
    requestCompletedEvent((object) this, new sendRequestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapRpcMethod("", RequestNamespace = "auth", ResponseNamespace = "http://com/iix/soap/SoapAuth.wsdl")]
  [return: SoapElement("return")]
  public string getResponse(string msgString)
  {
    return Conversions.ToString(this.Invoke(nameof (getResponse), new object[1]
    {
      (object) msgString
    })[0]);
  }

  public void getResponseAsync(string msgString) => this.getResponseAsync(msgString, (object) null);

  public void getResponseAsync(string msgString, object userState)
  {
    if (this.getResponseOperationCompleted == null)
      this.getResponseOperationCompleted = new SendOrPostCallback(this.OngetResponseOperationCompleted);
    this.InvokeAsync("getResponse", new object[1]
    {
      (object) msgString
    }, this.getResponseOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OngetResponseOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.getResponseCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    getResponseCompletedEventHandler responseCompletedEvent = this.getResponseCompletedEvent;
    if (responseCompletedEvent == null)
      return;
    responseCompletedEvent((object) this, new getResponseCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapRpcMethod("", RequestNamespace = "auth", ResponseNamespace = "http://com/iix/soap/SoapAuth.wsdl")]
  [return: SoapElement("return")]
  public string getResponse2(string msgString)
  {
    return Conversions.ToString(this.Invoke(nameof (getResponse2), new object[1]
    {
      (object) msgString
    })[0]);
  }

  public void getResponse2Async(string msgString)
  {
    this.getResponse2Async(msgString, (object) null);
  }

  public void getResponse2Async(string msgString, object userState)
  {
    if (this.getResponse2OperationCompleted == null)
      this.getResponse2OperationCompleted = new SendOrPostCallback(this.OngetResponse2OperationCompleted);
    this.InvokeAsync("getResponse2", new object[1]
    {
      (object) msgString
    }, this.getResponse2OperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OngetResponse2OperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.getResponse2CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    getResponse2CompletedEventHandler response2CompletedEvent = this.getResponse2CompletedEvent;
    if (response2CompletedEvent == null)
      return;
    response2CompletedEvent((object) this, new getResponse2CompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapRpcMethod("", RequestNamespace = "auth", ResponseNamespace = "http://com/iix/soap/SoapAuth.wsdl")]
  [return: SoapElement("return")]
  public string getXmlResponse(string msgString)
  {
    return Conversions.ToString(this.Invoke(nameof (getXmlResponse), new object[1]
    {
      (object) msgString
    })[0]);
  }

  public void getXmlResponseAsync(string msgString)
  {
    this.getXmlResponseAsync(msgString, (object) null);
  }

  public void getXmlResponseAsync(string msgString, object userState)
  {
    if (this.getXmlResponseOperationCompleted == null)
      this.getXmlResponseOperationCompleted = new SendOrPostCallback(this.OngetXmlResponseOperationCompleted);
    this.InvokeAsync("getXmlResponse", new object[1]
    {
      (object) msgString
    }, this.getXmlResponseOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OngetXmlResponseOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.getXmlResponseCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    getXmlResponseCompletedEventHandler responseCompletedEvent = this.getXmlResponseCompletedEvent;
    if (responseCompletedEvent == null)
      return;
    responseCompletedEvent((object) this, new getXmlResponseCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapRpcMethod("", RequestNamespace = "auth", ResponseNamespace = "http://com/iix/soap/SoapAuth.wsdl")]
  [return: SoapElement("return")]
  public string getXmlResponse2(string msgString)
  {
    return Conversions.ToString(this.Invoke(nameof (getXmlResponse2), new object[1]
    {
      (object) msgString
    })[0]);
  }

  public void getXmlResponse2Async(string msgString)
  {
    this.getXmlResponse2Async(msgString, (object) null);
  }

  public void getXmlResponse2Async(string msgString, object userState)
  {
    if (this.getXmlResponse2OperationCompleted == null)
      this.getXmlResponse2OperationCompleted = new SendOrPostCallback(this.OngetXmlResponse2OperationCompleted);
    this.InvokeAsync("getXmlResponse2", new object[1]
    {
      (object) msgString
    }, this.getXmlResponse2OperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OngetXmlResponse2OperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.getXmlResponse2CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    getXmlResponse2CompletedEventHandler response2CompletedEvent = this.getXmlResponse2CompletedEvent;
    if (response2CompletedEvent == null)
      return;
    response2CompletedEvent((object) this, new getXmlResponse2CompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapRpcMethod("", RequestNamespace = "auth", ResponseNamespace = "http://com/iix/soap/SoapAuth.wsdl")]
  [return: SoapElement("return")]
  public string getPdfResponse(string msgString)
  {
    return Conversions.ToString(this.Invoke(nameof (getPdfResponse), new object[1]
    {
      (object) msgString
    })[0]);
  }

  public void getPdfResponseAsync(string msgString)
  {
    this.getPdfResponseAsync(msgString, (object) null);
  }

  public void getPdfResponseAsync(string msgString, object userState)
  {
    if (this.getPdfResponseOperationCompleted == null)
      this.getPdfResponseOperationCompleted = new SendOrPostCallback(this.OngetPdfResponseOperationCompleted);
    this.InvokeAsync("getPdfResponse", new object[1]
    {
      (object) msgString
    }, this.getPdfResponseOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OngetPdfResponseOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.getPdfResponseCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    getPdfResponseCompletedEventHandler responseCompletedEvent = this.getPdfResponseCompletedEvent;
    if (responseCompletedEvent == null)
      return;
    responseCompletedEvent((object) this, new getPdfResponseCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapRpcMethod("", RequestNamespace = "auth", ResponseNamespace = "http://com/iix/soap/SoapAuth.wsdl")]
  [return: SoapElement("return")]
  public string getPdfResponse2(string msgString)
  {
    return Conversions.ToString(this.Invoke(nameof (getPdfResponse2), new object[1]
    {
      (object) msgString
    })[0]);
  }

  public void getPdfResponse2Async(string msgString)
  {
    this.getPdfResponse2Async(msgString, (object) null);
  }

  public void getPdfResponse2Async(string msgString, object userState)
  {
    if (this.getPdfResponse2OperationCompleted == null)
      this.getPdfResponse2OperationCompleted = new SendOrPostCallback(this.OngetPdfResponse2OperationCompleted);
    this.InvokeAsync("getPdfResponse2", new object[1]
    {
      (object) msgString
    }, this.getPdfResponse2OperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OngetPdfResponse2OperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.getPdfResponse2CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    getPdfResponse2CompletedEventHandler response2CompletedEvent = this.getPdfResponse2CompletedEvent;
    if (response2CompletedEvent == null)
      return;
    response2CompletedEvent((object) this, new getPdfResponse2CompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  public new void CancelAsync(object userState)
  {
    base.CancelAsync(RuntimeHelpers.GetObjectValue(userState));
  }

  private bool IsLocalFileSystemWebService(string url)
  {
    bool flag;
    if (url == null || (object) url == (object) string.Empty)
    {
      flag = false;
    }
    else
    {
      Uri uri = new Uri(url);
      flag = uri.Port >= 1024 /*0x0400*/ && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
    }
    return flag;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.RegionalReporting.Requests
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections.RegionalReporting;

[GeneratedCode("System.Web.Services", "4.8.3761.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "RequestsSoap", Namespace = "http://www.regionalreporting.com/")]
public class Requests : SoapHttpClientProtocol
{
  private SendOrPostCallback SubmitRequestOperationCompleted;
  private SendOrPostCallback SubmitRequestV2OperationCompleted;
  private SendOrPostCallback SubmitNewAUSUMRequestOperationCompleted;
  private SendOrPostCallback SubmitReturnedAUSUMRequestOperationCompleted;
  private SendOrPostCallback SubmitSurveyResendOperationCompleted;
  private SendOrPostCallback CancelRequestOperationCompleted;
  private SendOrPostCallback RequestStatusOperationCompleted;
  private bool useDefaultCredentialsSetExplicitly;

  public Requests()
  {
    this.Url = "https://www.regionalreporting.com/requests.asmx";
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

  public event SubmitRequestCompletedEventHandler SubmitRequestCompleted;

  public event SubmitRequestV2CompletedEventHandler SubmitRequestV2Completed;

  public event SubmitNewAUSUMRequestCompletedEventHandler SubmitNewAUSUMRequestCompleted;

  public event SubmitReturnedAUSUMRequestCompletedEventHandler SubmitReturnedAUSUMRequestCompleted;

  public event SubmitSurveyResendCompletedEventHandler SubmitSurveyResendCompleted;

  public event CancelRequestCompletedEventHandler CancelRequestCompleted;

  public event RequestStatusCompletedEventHandler RequestStatusCompleted;

  [SoapRpcMethod("http://www.regionalreporting.com/Requests/SubmitRequest", RequestNamespace = "http://www.regionalreporting.com/Requests", ResponseNamespace = "http://www.regionalreporting.com/Requests")]
  public string SubmitRequest(string Username, string Password, string xmlData)
  {
    return Conversions.ToString(this.Invoke(nameof (SubmitRequest), new object[3]
    {
      (object) Username,
      (object) Password,
      (object) xmlData
    })[0]);
  }

  public IAsyncResult BeginSubmitRequest(
    string Username,
    string Password,
    string xmlData,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("SubmitRequest", new object[3]
    {
      (object) Username,
      (object) Password,
      (object) xmlData
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public string EndSubmitRequest(IAsyncResult asyncResult)
  {
    return Conversions.ToString(this.EndInvoke(asyncResult)[0]);
  }

  public void SubmitRequestAsync(string Username, string Password, string xmlData)
  {
    this.SubmitRequestAsync(Username, Password, xmlData, (object) null);
  }

  public void SubmitRequestAsync(
    string Username,
    string Password,
    string xmlData,
    object userState)
  {
    if (this.SubmitRequestOperationCompleted == null)
      this.SubmitRequestOperationCompleted = new SendOrPostCallback(this.OnSubmitRequestOperationCompleted);
    this.InvokeAsync("SubmitRequest", new object[3]
    {
      (object) Username,
      (object) Password,
      (object) xmlData
    }, this.SubmitRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnSubmitRequestOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.SubmitRequestCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    SubmitRequestCompletedEventHandler requestCompletedEvent = this.SubmitRequestCompletedEvent;
    if (requestCompletedEvent == null)
      return;
    requestCompletedEvent((object) this, new SubmitRequestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapRpcMethod("http://www.regionalreporting.com/Requests/SubmitRequestV2", RequestNamespace = "http://www.regionalreporting.com/Requests", ResponseNamespace = "http://www.regionalreporting.com/Requests")]
  public string SubmitRequestV2(string Username, string Password, string xmlData)
  {
    return Conversions.ToString(this.Invoke(nameof (SubmitRequestV2), new object[3]
    {
      (object) Username,
      (object) Password,
      (object) xmlData
    })[0]);
  }

  public IAsyncResult BeginSubmitRequestV2(
    string Username,
    string Password,
    string xmlData,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("SubmitRequestV2", new object[3]
    {
      (object) Username,
      (object) Password,
      (object) xmlData
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public string EndSubmitRequestV2(IAsyncResult asyncResult)
  {
    return Conversions.ToString(this.EndInvoke(asyncResult)[0]);
  }

  public void SubmitRequestV2Async(string Username, string Password, string xmlData)
  {
    this.SubmitRequestV2Async(Username, Password, xmlData, (object) null);
  }

  public void SubmitRequestV2Async(
    string Username,
    string Password,
    string xmlData,
    object userState)
  {
    if (this.SubmitRequestV2OperationCompleted == null)
      this.SubmitRequestV2OperationCompleted = new SendOrPostCallback(this.OnSubmitRequestV2OperationCompleted);
    this.InvokeAsync("SubmitRequestV2", new object[3]
    {
      (object) Username,
      (object) Password,
      (object) xmlData
    }, this.SubmitRequestV2OperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnSubmitRequestV2OperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.SubmitRequestV2CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    SubmitRequestV2CompletedEventHandler v2CompletedEvent = this.SubmitRequestV2CompletedEvent;
    if (v2CompletedEvent == null)
      return;
    v2CompletedEvent((object) this, new SubmitRequestV2CompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://www.regionalreporting.com/SubmitNewAUSUMRequest", RequestNamespace = "http://www.regionalreporting.com/", ResponseNamespace = "http://www.regionalreporting.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string SubmitNewAUSUMRequest(string Username, string Password, string xmlData)
  {
    return Conversions.ToString(this.Invoke(nameof (SubmitNewAUSUMRequest), new object[3]
    {
      (object) Username,
      (object) Password,
      (object) xmlData
    })[0]);
  }

  public IAsyncResult BeginSubmitNewAUSUMRequest(
    string Username,
    string Password,
    string xmlData,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("SubmitNewAUSUMRequest", new object[3]
    {
      (object) Username,
      (object) Password,
      (object) xmlData
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public string EndSubmitNewAUSUMRequest(IAsyncResult asyncResult)
  {
    return Conversions.ToString(this.EndInvoke(asyncResult)[0]);
  }

  public void SubmitNewAUSUMRequestAsync(string Username, string Password, string xmlData)
  {
    this.SubmitNewAUSUMRequestAsync(Username, Password, xmlData, (object) null);
  }

  public void SubmitNewAUSUMRequestAsync(
    string Username,
    string Password,
    string xmlData,
    object userState)
  {
    if (this.SubmitNewAUSUMRequestOperationCompleted == null)
      this.SubmitNewAUSUMRequestOperationCompleted = new SendOrPostCallback(this.OnSubmitNewAUSUMRequestOperationCompleted);
    this.InvokeAsync("SubmitNewAUSUMRequest", new object[3]
    {
      (object) Username,
      (object) Password,
      (object) xmlData
    }, this.SubmitNewAUSUMRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnSubmitNewAUSUMRequestOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.SubmitNewAUSUMRequestCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    SubmitNewAUSUMRequestCompletedEventHandler requestCompletedEvent = this.SubmitNewAUSUMRequestCompletedEvent;
    if (requestCompletedEvent == null)
      return;
    requestCompletedEvent((object) this, new SubmitNewAUSUMRequestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://www.regionalreporting.com/SubmitReturnedAUSUMRequest", RequestNamespace = "http://www.regionalreporting.com/", ResponseNamespace = "http://www.regionalreporting.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string SubmitReturnedAUSUMRequest(string Username, string Password, string xmlData)
  {
    return Conversions.ToString(this.Invoke(nameof (SubmitReturnedAUSUMRequest), new object[3]
    {
      (object) Username,
      (object) Password,
      (object) xmlData
    })[0]);
  }

  public IAsyncResult BeginSubmitReturnedAUSUMRequest(
    string Username,
    string Password,
    string xmlData,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("SubmitReturnedAUSUMRequest", new object[3]
    {
      (object) Username,
      (object) Password,
      (object) xmlData
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public string EndSubmitReturnedAUSUMRequest(IAsyncResult asyncResult)
  {
    return Conversions.ToString(this.EndInvoke(asyncResult)[0]);
  }

  public void SubmitReturnedAUSUMRequestAsync(string Username, string Password, string xmlData)
  {
    this.SubmitReturnedAUSUMRequestAsync(Username, Password, xmlData, (object) null);
  }

  public void SubmitReturnedAUSUMRequestAsync(
    string Username,
    string Password,
    string xmlData,
    object userState)
  {
    if (this.SubmitReturnedAUSUMRequestOperationCompleted == null)
      this.SubmitReturnedAUSUMRequestOperationCompleted = new SendOrPostCallback(this.OnSubmitReturnedAUSUMRequestOperationCompleted);
    this.InvokeAsync("SubmitReturnedAUSUMRequest", new object[3]
    {
      (object) Username,
      (object) Password,
      (object) xmlData
    }, this.SubmitReturnedAUSUMRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnSubmitReturnedAUSUMRequestOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.SubmitReturnedAUSUMRequestCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    SubmitReturnedAUSUMRequestCompletedEventHandler requestCompletedEvent = this.SubmitReturnedAUSUMRequestCompletedEvent;
    if (requestCompletedEvent == null)
      return;
    requestCompletedEvent((object) this, new SubmitReturnedAUSUMRequestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://www.regionalreporting.com/SubmitSurveyResend", RequestNamespace = "http://www.regionalreporting.com/", ResponseNamespace = "http://www.regionalreporting.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string SubmitSurveyResend(string Username, string Password, long rlID)
  {
    return Conversions.ToString(this.Invoke(nameof (SubmitSurveyResend), new object[3]
    {
      (object) Username,
      (object) Password,
      (object) rlID
    })[0]);
  }

  public IAsyncResult BeginSubmitSurveyResend(
    string Username,
    string Password,
    long rlID,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("SubmitSurveyResend", new object[3]
    {
      (object) Username,
      (object) Password,
      (object) rlID
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public string EndSubmitSurveyResend(IAsyncResult asyncResult)
  {
    return Conversions.ToString(this.EndInvoke(asyncResult)[0]);
  }

  public void SubmitSurveyResendAsync(string Username, string Password, long rlID)
  {
    this.SubmitSurveyResendAsync(Username, Password, rlID, (object) null);
  }

  public void SubmitSurveyResendAsync(
    string Username,
    string Password,
    long rlID,
    object userState)
  {
    if (this.SubmitSurveyResendOperationCompleted == null)
      this.SubmitSurveyResendOperationCompleted = new SendOrPostCallback(this.OnSubmitSurveyResendOperationCompleted);
    this.InvokeAsync("SubmitSurveyResend", new object[3]
    {
      (object) Username,
      (object) Password,
      (object) rlID
    }, this.SubmitSurveyResendOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnSubmitSurveyResendOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.SubmitSurveyResendCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    SubmitSurveyResendCompletedEventHandler resendCompletedEvent = this.SubmitSurveyResendCompletedEvent;
    if (resendCompletedEvent == null)
      return;
    resendCompletedEvent((object) this, new SubmitSurveyResendCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://www.regionalreporting.com/CancelRequest", RequestNamespace = "http://www.regionalreporting.com/", ResponseNamespace = "http://www.regionalreporting.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string CancelRequest(string Username, string Password, long rlID)
  {
    return Conversions.ToString(this.Invoke(nameof (CancelRequest), new object[3]
    {
      (object) Username,
      (object) Password,
      (object) rlID
    })[0]);
  }

  public IAsyncResult BeginCancelRequest(
    string Username,
    string Password,
    long rlID,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("CancelRequest", new object[3]
    {
      (object) Username,
      (object) Password,
      (object) rlID
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public string EndCancelRequest(IAsyncResult asyncResult)
  {
    return Conversions.ToString(this.EndInvoke(asyncResult)[0]);
  }

  public void CancelRequestAsync(string Username, string Password, long rlID)
  {
    this.CancelRequestAsync(Username, Password, rlID, (object) null);
  }

  public void CancelRequestAsync(string Username, string Password, long rlID, object userState)
  {
    if (this.CancelRequestOperationCompleted == null)
      this.CancelRequestOperationCompleted = new SendOrPostCallback(this.OnCancelRequestOperationCompleted);
    this.InvokeAsync("CancelRequest", new object[3]
    {
      (object) Username,
      (object) Password,
      (object) rlID
    }, this.CancelRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnCancelRequestOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.CancelRequestCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    CancelRequestCompletedEventHandler requestCompletedEvent = this.CancelRequestCompletedEvent;
    if (requestCompletedEvent == null)
      return;
    requestCompletedEvent((object) this, new CancelRequestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://www.regionalreporting.com/RequestStatus", RequestNamespace = "http://www.regionalreporting.com/", ResponseNamespace = "http://www.regionalreporting.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string RequestStatus(string Username, string Password, long rlID)
  {
    return Conversions.ToString(this.Invoke(nameof (RequestStatus), new object[3]
    {
      (object) Username,
      (object) Password,
      (object) rlID
    })[0]);
  }

  public IAsyncResult BeginRequestStatus(
    string Username,
    string Password,
    long rlID,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("RequestStatus", new object[3]
    {
      (object) Username,
      (object) Password,
      (object) rlID
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public string EndRequestStatus(IAsyncResult asyncResult)
  {
    return Conversions.ToString(this.EndInvoke(asyncResult)[0]);
  }

  public void RequestStatusAsync(string Username, string Password, long rlID)
  {
    this.RequestStatusAsync(Username, Password, rlID, (object) null);
  }

  public void RequestStatusAsync(string Username, string Password, long rlID, object userState)
  {
    if (this.RequestStatusOperationCompleted == null)
      this.RequestStatusOperationCompleted = new SendOrPostCallback(this.OnRequestStatusOperationCompleted);
    this.InvokeAsync("RequestStatus", new object[3]
    {
      (object) Username,
      (object) Password,
      (object) rlID
    }, this.RequestStatusOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnRequestStatusOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.RequestStatusCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    RequestStatusCompletedEventHandler statusCompletedEvent = this.RequestStatusCompletedEvent;
    if (statusCompletedEvent == null)
      return;
    statusCompletedEvent((object) this, new RequestStatusCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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

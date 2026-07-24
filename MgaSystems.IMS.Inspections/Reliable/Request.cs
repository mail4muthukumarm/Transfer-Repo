// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.Reliable.Request
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using MGASystems.IMS.Policies.Inspections.My;
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
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections.Reliable;

[GeneratedCode("System.Web.Services", "4.6.1586.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "RequestSoap", Namespace = "http://tempuri.org/ReliableInspectionsService/Request")]
public class Request : SoapHttpClientProtocol
{
  private SOAPHeaderAuth sOAPHeaderAuthValueField;
  private SendOrPostCallback SendInspectionRequestOperationCompleted;
  private SendOrPostCallback SendInspectionRequestWithIDOperationCompleted;
  private SendOrPostCallback SendInspectionRequest_RetIDOperationCompleted;
  private SendOrPostCallback UpdateInspectionRequestOperationCompleted;
  private SendOrPostCallback GetInspectionRequestOperationCompleted;
  private SendOrPostCallback GetInspectionRequest1OperationCompleted;
  private SendOrPostCallback ContainInspectionRequestOperationCompleted;
  private SendOrPostCallback ValidateRequestDataOperationCompleted;
  private SendOrPostCallback AuthenticationTestOperationCompleted;
  private SendOrPostCallback GetClientCodeOperationCompleted;
  private SendOrPostCallback GetClientNameOperationCompleted;
  private bool useDefaultCredentialsSetExplicitly;

  public Request()
  {
    this.Url = MySettings.Default.MgaSystems_IMS_Inspections_Reliable_Request;
    if (this.IsLocalFileSystemWebService(this.Url))
    {
      this.UseDefaultCredentials = true;
      this.useDefaultCredentialsSetExplicitly = false;
    }
    else
      this.useDefaultCredentialsSetExplicitly = true;
  }

  public SOAPHeaderAuth SOAPHeaderAuthValue
  {
    get => this.sOAPHeaderAuthValueField;
    set => this.sOAPHeaderAuthValueField = value;
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

  public event SendInspectionRequestCompletedEventHandler SendInspectionRequestCompleted;

  public event SendInspectionRequestWithIDCompletedEventHandler SendInspectionRequestWithIDCompleted;

  public event SendInspectionRequest_RetIDCompletedEventHandler SendInspectionRequest_RetIDCompleted;

  public event UpdateInspectionRequestCompletedEventHandler UpdateInspectionRequestCompleted;

  public event GetInspectionRequestCompletedEventHandler GetInspectionRequestCompleted;

  public event GetInspectionRequest1CompletedEventHandler GetInspectionRequest1Completed;

  public event ContainInspectionRequestCompletedEventHandler ContainInspectionRequestCompleted;

  public event ValidateRequestDataCompletedEventHandler ValidateRequestDataCompleted;

  public event AuthenticationTestCompletedEventHandler AuthenticationTestCompleted;

  public event GetClientCodeCompletedEventHandler GetClientCodeCompleted;

  public event GetClientNameCompletedEventHandler GetClientNameCompleted;

  [SoapHeader("SOAPHeaderAuthValue", Direction = SoapHeaderDirection.InOut)]
  [SoapDocumentMethod("http://tempuri.org/ReliableInspectionsService/Request/SendInspectionRequest", RequestNamespace = "http://tempuri.org/ReliableInspectionsService/Request", ResponseNamespace = "http://tempuri.org/ReliableInspectionsService/Request", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public bool SendInspectionRequest(dsRequest RequestData, ref string ErrorMessage)
  {
    object[] objArray = this.Invoke(nameof (SendInspectionRequest), new object[2]
    {
      (object) RequestData,
      (object) ErrorMessage
    });
    ErrorMessage = Conversions.ToString(objArray[1]);
    return Conversions.ToBoolean(objArray[0]);
  }

  public IAsyncResult BeginSendInspectionRequest(
    dsRequest RequestData,
    string ErrorMessage,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("SendInspectionRequest", new object[2]
    {
      (object) RequestData,
      (object) ErrorMessage
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public bool EndSendInspectionRequest(IAsyncResult asyncResult, ref string ErrorMessage)
  {
    object[] objArray = this.EndInvoke(asyncResult);
    ErrorMessage = Conversions.ToString(objArray[1]);
    return Conversions.ToBoolean(objArray[0]);
  }

  public void SendInspectionRequestAsync(dsRequest RequestData, string ErrorMessage)
  {
    this.SendInspectionRequestAsync(RequestData, ErrorMessage, (object) null);
  }

  public void SendInspectionRequestAsync(
    dsRequest RequestData,
    string ErrorMessage,
    object userState)
  {
    if (this.SendInspectionRequestOperationCompleted == null)
      this.SendInspectionRequestOperationCompleted = new SendOrPostCallback(this.OnSendInspectionRequestOperationCompleted);
    this.InvokeAsync("SendInspectionRequest", new object[2]
    {
      (object) RequestData,
      (object) ErrorMessage
    }, this.SendInspectionRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnSendInspectionRequestOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.SendInspectionRequestCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    SendInspectionRequestCompletedEventHandler requestCompletedEvent = this.SendInspectionRequestCompletedEvent;
    if (requestCompletedEvent == null)
      return;
    requestCompletedEvent((object) this, new SendInspectionRequestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("SOAPHeaderAuthValue", Direction = SoapHeaderDirection.InOut)]
  [SoapDocumentMethod("http://tempuri.org/ReliableInspectionsService/Request/SendInspectionRequestWithID", RequestNamespace = "http://tempuri.org/ReliableInspectionsService/Request", ResponseNamespace = "http://tempuri.org/ReliableInspectionsService/Request", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string SendInspectionRequestWithID(dsRequest RequestData, ref string ErrorMessage)
  {
    object[] objArray = this.Invoke(nameof (SendInspectionRequestWithID), new object[2]
    {
      (object) RequestData,
      (object) ErrorMessage
    });
    ErrorMessage = Conversions.ToString(objArray[1]);
    return Conversions.ToString(objArray[0]);
  }

  public IAsyncResult BeginSendInspectionRequestWithID(
    dsRequest RequestData,
    string ErrorMessage,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("SendInspectionRequestWithID", new object[2]
    {
      (object) RequestData,
      (object) ErrorMessage
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public string EndSendInspectionRequestWithID(IAsyncResult asyncResult, ref string ErrorMessage)
  {
    object[] objArray = this.EndInvoke(asyncResult);
    ErrorMessage = Conversions.ToString(objArray[1]);
    return Conversions.ToString(objArray[0]);
  }

  public void SendInspectionRequestWithIDAsync(dsRequest RequestData, string ErrorMessage)
  {
    this.SendInspectionRequestWithIDAsync(RequestData, ErrorMessage, (object) null);
  }

  public void SendInspectionRequestWithIDAsync(
    dsRequest RequestData,
    string ErrorMessage,
    object userState)
  {
    if (this.SendInspectionRequestWithIDOperationCompleted == null)
      this.SendInspectionRequestWithIDOperationCompleted = new SendOrPostCallback(this.OnSendInspectionRequestWithIDOperationCompleted);
    this.InvokeAsync("SendInspectionRequestWithID", new object[2]
    {
      (object) RequestData,
      (object) ErrorMessage
    }, this.SendInspectionRequestWithIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnSendInspectionRequestWithIDOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.SendInspectionRequestWithIDCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    SendInspectionRequestWithIDCompletedEventHandler idCompletedEvent = this.SendInspectionRequestWithIDCompletedEvent;
    if (idCompletedEvent == null)
      return;
    idCompletedEvent((object) this, new SendInspectionRequestWithIDCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("SOAPHeaderAuthValue", Direction = SoapHeaderDirection.InOut)]
  [SoapDocumentMethod("http://tempuri.org/ReliableInspectionsService/Request/SendInspectionRequest_RetID", RequestNamespace = "http://tempuri.org/ReliableInspectionsService/Request", ResponseNamespace = "http://tempuri.org/ReliableInspectionsService/Request", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public bool SendInspectionRequest_RetID(
    dsRequest RequestData,
    ref string ErrorMessage,
    ref string[] ID)
  {
    object[] objArray = this.Invoke(nameof (SendInspectionRequest_RetID), new object[3]
    {
      (object) RequestData,
      (object) ErrorMessage,
      (object) ID
    });
    ErrorMessage = Conversions.ToString(objArray[1]);
    ID = (string[]) objArray[2];
    return Conversions.ToBoolean(objArray[0]);
  }

  public IAsyncResult BeginSendInspectionRequest_RetID(
    dsRequest RequestData,
    string ErrorMessage,
    string[] ID,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("SendInspectionRequest_RetID", new object[3]
    {
      (object) RequestData,
      (object) ErrorMessage,
      (object) ID
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public bool EndSendInspectionRequest_RetID(
    IAsyncResult asyncResult,
    ref string ErrorMessage,
    ref string[] ID)
  {
    object[] objArray = this.EndInvoke(asyncResult);
    ErrorMessage = Conversions.ToString(objArray[1]);
    ID = (string[]) objArray[2];
    return Conversions.ToBoolean(objArray[0]);
  }

  public void SendInspectionRequest_RetIDAsync(
    dsRequest RequestData,
    string ErrorMessage,
    string[] ID)
  {
    this.SendInspectionRequest_RetIDAsync(RequestData, ErrorMessage, ID, (object) null);
  }

  public void SendInspectionRequest_RetIDAsync(
    dsRequest RequestData,
    string ErrorMessage,
    string[] ID,
    object userState)
  {
    if (this.SendInspectionRequest_RetIDOperationCompleted == null)
      this.SendInspectionRequest_RetIDOperationCompleted = new SendOrPostCallback(this.OnSendInspectionRequest_RetIDOperationCompleted);
    this.InvokeAsync("SendInspectionRequest_RetID", new object[3]
    {
      (object) RequestData,
      (object) ErrorMessage,
      (object) ID
    }, this.SendInspectionRequest_RetIDOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnSendInspectionRequest_RetIDOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.SendInspectionRequest_RetIDCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    SendInspectionRequest_RetIDCompletedEventHandler idCompletedEvent = this.SendInspectionRequest_RetIDCompletedEvent;
    if (idCompletedEvent == null)
      return;
    idCompletedEvent((object) this, new SendInspectionRequest_RetIDCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("SOAPHeaderAuthValue", Direction = SoapHeaderDirection.InOut)]
  [SoapDocumentMethod("http://tempuri.org/ReliableInspectionsService/Request/UpdateInspectionRequest", RequestNamespace = "http://tempuri.org/ReliableInspectionsService/Request", ResponseNamespace = "http://tempuri.org/ReliableInspectionsService/Request", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public bool UpdateInspectionRequest(
    string RequestID,
    string InspectionID,
    dsRequest RequestData,
    ref string ErrorMessage)
  {
    object[] objArray = this.Invoke(nameof (UpdateInspectionRequest), new object[4]
    {
      (object) RequestID,
      (object) InspectionID,
      (object) RequestData,
      (object) ErrorMessage
    });
    ErrorMessage = Conversions.ToString(objArray[1]);
    return Conversions.ToBoolean(objArray[0]);
  }

  public IAsyncResult BeginUpdateInspectionRequest(
    string RequestID,
    string InspectionID,
    dsRequest RequestData,
    string ErrorMessage,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("UpdateInspectionRequest", new object[4]
    {
      (object) RequestID,
      (object) InspectionID,
      (object) RequestData,
      (object) ErrorMessage
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public bool EndUpdateInspectionRequest(IAsyncResult asyncResult, ref string ErrorMessage)
  {
    object[] objArray = this.EndInvoke(asyncResult);
    ErrorMessage = Conversions.ToString(objArray[1]);
    return Conversions.ToBoolean(objArray[0]);
  }

  public void UpdateInspectionRequestAsync(
    string RequestID,
    string InspectionID,
    dsRequest RequestData,
    string ErrorMessage)
  {
    this.UpdateInspectionRequestAsync(RequestID, InspectionID, RequestData, ErrorMessage, (object) null);
  }

  public void UpdateInspectionRequestAsync(
    string RequestID,
    string InspectionID,
    dsRequest RequestData,
    string ErrorMessage,
    object userState)
  {
    if (this.UpdateInspectionRequestOperationCompleted == null)
      this.UpdateInspectionRequestOperationCompleted = new SendOrPostCallback(this.OnUpdateInspectionRequestOperationCompleted);
    this.InvokeAsync("UpdateInspectionRequest", new object[4]
    {
      (object) RequestID,
      (object) InspectionID,
      (object) RequestData,
      (object) ErrorMessage
    }, this.UpdateInspectionRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnUpdateInspectionRequestOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.UpdateInspectionRequestCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    UpdateInspectionRequestCompletedEventHandler requestCompletedEvent = this.UpdateInspectionRequestCompletedEvent;
    if (requestCompletedEvent == null)
      return;
    requestCompletedEvent((object) this, new UpdateInspectionRequestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("SOAPHeaderAuthValue", Direction = SoapHeaderDirection.InOut)]
  [SoapDocumentMethod("http://tempuri.org/ReliableInspectionsService/Request/GetOpenInspectionRequest", RequestElementName = "GetOpenInspectionRequest", RequestNamespace = "http://tempuri.org/ReliableInspectionsService/Request", ResponseElementName = "GetOpenInspectionRequestResponse", ResponseNamespace = "http://tempuri.org/ReliableInspectionsService/Request", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement("GetOpenInspectionRequestResult")]
  public dsRequest GetInspectionRequest(
    string RequestID,
    string InspectionID,
    ref string ErrorMessage)
  {
    object[] objArray = this.Invoke(nameof (GetInspectionRequest), new object[3]
    {
      (object) RequestID,
      (object) InspectionID,
      (object) ErrorMessage
    });
    ErrorMessage = Conversions.ToString(objArray[1]);
    return (dsRequest) objArray[0];
  }

  public IAsyncResult BeginGetInspectionRequest(
    string RequestID,
    string InspectionID,
    string ErrorMessage,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("GetInspectionRequest", new object[3]
    {
      (object) RequestID,
      (object) InspectionID,
      (object) ErrorMessage
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public dsRequest EndGetInspectionRequest(IAsyncResult asyncResult, ref string ErrorMessage)
  {
    object[] objArray = this.EndInvoke(asyncResult);
    ErrorMessage = Conversions.ToString(objArray[1]);
    return (dsRequest) objArray[0];
  }

  public void GetInspectionRequestAsync(string RequestID, string InspectionID, string ErrorMessage)
  {
    this.GetInspectionRequestAsync(RequestID, InspectionID, ErrorMessage, (object) null);
  }

  public void GetInspectionRequestAsync(
    string RequestID,
    string InspectionID,
    string ErrorMessage,
    object userState)
  {
    if (this.GetInspectionRequestOperationCompleted == null)
      this.GetInspectionRequestOperationCompleted = new SendOrPostCallback(this.OnGetInspectionRequestOperationCompleted);
    this.InvokeAsync("GetInspectionRequest", new object[3]
    {
      (object) RequestID,
      (object) InspectionID,
      (object) ErrorMessage
    }, this.GetInspectionRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnGetInspectionRequestOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.GetInspectionRequestCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    GetInspectionRequestCompletedEventHandler requestCompletedEvent = this.GetInspectionRequestCompletedEvent;
    if (requestCompletedEvent == null)
      return;
    requestCompletedEvent((object) this, new GetInspectionRequestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("SOAPHeaderAuthValue", Direction = SoapHeaderDirection.InOut)]
  [WebMethod(MessageName = "GetInspectionRequest1")]
  [SoapDocumentMethod("http://tempuri.org/ReliableInspectionsService/Request/GetInspectionRequest", RequestElementName = "GetInspectionRequest", RequestNamespace = "http://tempuri.org/ReliableInspectionsService/Request", ResponseElementName = "GetInspectionRequestResponse", ResponseNamespace = "http://tempuri.org/ReliableInspectionsService/Request", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement("GetInspectionRequestResult")]
  public dsRequest GetInspectionRequest(string RequestID, string InspectionID)
  {
    return (dsRequest) this.Invoke("GetInspectionRequest1", new object[2]
    {
      (object) RequestID,
      (object) InspectionID
    })[0];
  }

  public IAsyncResult BeginGetInspectionRequest1(
    string RequestID,
    string InspectionID,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("GetInspectionRequest1", new object[2]
    {
      (object) RequestID,
      (object) InspectionID
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public dsRequest EndGetInspectionRequest1(IAsyncResult asyncResult)
  {
    return (dsRequest) this.EndInvoke(asyncResult)[0];
  }

  public void GetInspectionRequest1Async(string RequestID, string InspectionID)
  {
    this.GetInspectionRequest1Async(RequestID, InspectionID, (object) null);
  }

  public void GetInspectionRequest1Async(string RequestID, string InspectionID, object userState)
  {
    if (this.GetInspectionRequest1OperationCompleted == null)
      this.GetInspectionRequest1OperationCompleted = new SendOrPostCallback(this.OnGetInspectionRequest1OperationCompleted);
    this.InvokeAsync("GetInspectionRequest1", new object[2]
    {
      (object) RequestID,
      (object) InspectionID
    }, this.GetInspectionRequest1OperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnGetInspectionRequest1OperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.GetInspectionRequest1CompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    GetInspectionRequest1CompletedEventHandler request1CompletedEvent = this.GetInspectionRequest1CompletedEvent;
    if (request1CompletedEvent == null)
      return;
    request1CompletedEvent((object) this, new GetInspectionRequest1CompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("SOAPHeaderAuthValue", Direction = SoapHeaderDirection.InOut)]
  [SoapDocumentMethod("http://tempuri.org/ReliableInspectionsService/Request/ContainInspectionRequest", RequestNamespace = "http://tempuri.org/ReliableInspectionsService/Request", ResponseNamespace = "http://tempuri.org/ReliableInspectionsService/Request", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public bool ContainInspectionRequest(string RequestID, string InspectionID)
  {
    return Conversions.ToBoolean(this.Invoke(nameof (ContainInspectionRequest), new object[2]
    {
      (object) RequestID,
      (object) InspectionID
    })[0]);
  }

  public IAsyncResult BeginContainInspectionRequest(
    string RequestID,
    string InspectionID,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("ContainInspectionRequest", new object[2]
    {
      (object) RequestID,
      (object) InspectionID
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public bool EndContainInspectionRequest(IAsyncResult asyncResult)
  {
    return Conversions.ToBoolean(this.EndInvoke(asyncResult)[0]);
  }

  public void ContainInspectionRequestAsync(string RequestID, string InspectionID)
  {
    this.ContainInspectionRequestAsync(RequestID, InspectionID, (object) null);
  }

  public void ContainInspectionRequestAsync(
    string RequestID,
    string InspectionID,
    object userState)
  {
    if (this.ContainInspectionRequestOperationCompleted == null)
      this.ContainInspectionRequestOperationCompleted = new SendOrPostCallback(this.OnContainInspectionRequestOperationCompleted);
    this.InvokeAsync("ContainInspectionRequest", new object[2]
    {
      (object) RequestID,
      (object) InspectionID
    }, this.ContainInspectionRequestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnContainInspectionRequestOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ContainInspectionRequestCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ContainInspectionRequestCompletedEventHandler requestCompletedEvent = this.ContainInspectionRequestCompletedEvent;
    if (requestCompletedEvent == null)
      return;
    requestCompletedEvent((object) this, new ContainInspectionRequestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("SOAPHeaderAuthValue", Direction = SoapHeaderDirection.InOut)]
  [SoapDocumentMethod("http://tempuri.org/ReliableInspectionsService/Request/ValidateRequestData", RequestNamespace = "http://tempuri.org/ReliableInspectionsService/Request", ResponseNamespace = "http://tempuri.org/ReliableInspectionsService/Request", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public bool ValidateRequestData(dsRequest RequestData, ref string ErrorMessage)
  {
    object[] objArray = this.Invoke(nameof (ValidateRequestData), new object[2]
    {
      (object) RequestData,
      (object) ErrorMessage
    });
    ErrorMessage = Conversions.ToString(objArray[1]);
    return Conversions.ToBoolean(objArray[0]);
  }

  public IAsyncResult BeginValidateRequestData(
    dsRequest RequestData,
    string ErrorMessage,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("ValidateRequestData", new object[2]
    {
      (object) RequestData,
      (object) ErrorMessage
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public bool EndValidateRequestData(IAsyncResult asyncResult, ref string ErrorMessage)
  {
    object[] objArray = this.EndInvoke(asyncResult);
    ErrorMessage = Conversions.ToString(objArray[1]);
    return Conversions.ToBoolean(objArray[0]);
  }

  public void ValidateRequestDataAsync(dsRequest RequestData, string ErrorMessage)
  {
    this.ValidateRequestDataAsync(RequestData, ErrorMessage, (object) null);
  }

  public void ValidateRequestDataAsync(
    dsRequest RequestData,
    string ErrorMessage,
    object userState)
  {
    if (this.ValidateRequestDataOperationCompleted == null)
      this.ValidateRequestDataOperationCompleted = new SendOrPostCallback(this.OnValidateRequestDataOperationCompleted);
    this.InvokeAsync("ValidateRequestData", new object[2]
    {
      (object) RequestData,
      (object) ErrorMessage
    }, this.ValidateRequestDataOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnValidateRequestDataOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ValidateRequestDataCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ValidateRequestDataCompletedEventHandler dataCompletedEvent = this.ValidateRequestDataCompletedEvent;
    if (dataCompletedEvent == null)
      return;
    dataCompletedEvent((object) this, new ValidateRequestDataCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://tempuri.org/ReliableInspectionsService/Request/AuthenticationTest", RequestNamespace = "http://tempuri.org/ReliableInspectionsService/Request", ResponseNamespace = "http://tempuri.org/ReliableInspectionsService/Request", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public bool AuthenticationTest(string Username, string password)
  {
    return Conversions.ToBoolean(this.Invoke(nameof (AuthenticationTest), new object[2]
    {
      (object) Username,
      (object) password
    })[0]);
  }

  public IAsyncResult BeginAuthenticationTest(
    string Username,
    string password,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("AuthenticationTest", new object[2]
    {
      (object) Username,
      (object) password
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public bool EndAuthenticationTest(IAsyncResult asyncResult)
  {
    return Conversions.ToBoolean(this.EndInvoke(asyncResult)[0]);
  }

  public void AuthenticationTestAsync(string Username, string password)
  {
    this.AuthenticationTestAsync(Username, password, (object) null);
  }

  public void AuthenticationTestAsync(string Username, string password, object userState)
  {
    if (this.AuthenticationTestOperationCompleted == null)
      this.AuthenticationTestOperationCompleted = new SendOrPostCallback(this.OnAuthenticationTestOperationCompleted);
    this.InvokeAsync("AuthenticationTest", new object[2]
    {
      (object) Username,
      (object) password
    }, this.AuthenticationTestOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnAuthenticationTestOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.AuthenticationTestCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    AuthenticationTestCompletedEventHandler testCompletedEvent = this.AuthenticationTestCompletedEvent;
    if (testCompletedEvent == null)
      return;
    testCompletedEvent((object) this, new AuthenticationTestCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("SOAPHeaderAuthValue", Direction = SoapHeaderDirection.InOut)]
  [SoapDocumentMethod("http://tempuri.org/ReliableInspectionsService/Request/GetClientCode", RequestNamespace = "http://tempuri.org/ReliableInspectionsService/Request", ResponseNamespace = "http://tempuri.org/ReliableInspectionsService/Request", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string GetClientCode(string ClientName)
  {
    return Conversions.ToString(this.Invoke(nameof (GetClientCode), new object[1]
    {
      (object) ClientName
    })[0]);
  }

  public IAsyncResult BeginGetClientCode(
    string ClientName,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("GetClientCode", new object[1]
    {
      (object) ClientName
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public string EndGetClientCode(IAsyncResult asyncResult)
  {
    return Conversions.ToString(this.EndInvoke(asyncResult)[0]);
  }

  public void GetClientCodeAsync(string ClientName)
  {
    this.GetClientCodeAsync(ClientName, (object) null);
  }

  public void GetClientCodeAsync(string ClientName, object userState)
  {
    if (this.GetClientCodeOperationCompleted == null)
      this.GetClientCodeOperationCompleted = new SendOrPostCallback(this.OnGetClientCodeOperationCompleted);
    this.InvokeAsync("GetClientCode", new object[1]
    {
      (object) ClientName
    }, this.GetClientCodeOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnGetClientCodeOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.GetClientCodeCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    GetClientCodeCompletedEventHandler codeCompletedEvent = this.GetClientCodeCompletedEvent;
    if (codeCompletedEvent == null)
      return;
    codeCompletedEvent((object) this, new GetClientCodeCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapHeader("SOAPHeaderAuthValue", Direction = SoapHeaderDirection.InOut)]
  [SoapDocumentMethod("http://tempuri.org/ReliableInspectionsService/Request/GetClientName", RequestNamespace = "http://tempuri.org/ReliableInspectionsService/Request", ResponseNamespace = "http://tempuri.org/ReliableInspectionsService/Request", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  public string GetClientName(string ClientCode)
  {
    return Conversions.ToString(this.Invoke(nameof (GetClientName), new object[1]
    {
      (object) ClientCode
    })[0]);
  }

  public IAsyncResult BeginGetClientName(
    string ClientCode,
    AsyncCallback callback,
    object asyncState)
  {
    return this.BeginInvoke("GetClientName", new object[1]
    {
      (object) ClientCode
    }, callback, RuntimeHelpers.GetObjectValue(asyncState));
  }

  public string EndGetClientName(IAsyncResult asyncResult)
  {
    return Conversions.ToString(this.EndInvoke(asyncResult)[0]);
  }

  public void GetClientNameAsync(string ClientCode)
  {
    this.GetClientNameAsync(ClientCode, (object) null);
  }

  public void GetClientNameAsync(string ClientCode, object userState)
  {
    if (this.GetClientNameOperationCompleted == null)
      this.GetClientNameOperationCompleted = new SendOrPostCallback(this.OnGetClientNameOperationCompleted);
    this.InvokeAsync("GetClientName", new object[1]
    {
      (object) ClientCode
    }, this.GetClientNameOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnGetClientNameOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.GetClientNameCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    GetClientNameCompletedEventHandler nameCompletedEvent = this.GetClientNameCompletedEvent;
    if (nameCompletedEvent == null)
      return;
    nameCompletedEvent((object) this, new GetClientNameCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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

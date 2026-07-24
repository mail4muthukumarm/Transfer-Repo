// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.adrconnect.AdrConnectWebService
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

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
namespace MGASystems.Common.adrconnect;

[GeneratedCode("System.Web.Services", "4.6.1586.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "BasicHttpBinding_IAdrConnectWebService", Namespace = "http://adrconnect.mvrs.com/adrconnect/2013/04")]
public class AdrConnectWebService : SoapHttpClientProtocol
{
  private SendOrPostCallback ChangePasswordOperationCompleted;
  private SendOrPostCallback OrderInteractiveOperationCompleted;
  private SendOrPostCallback SendOrdersOperationCompleted;
  private SendOrPostCallback ReceiveRecordsOperationCompleted;
  private bool useDefaultCredentialsSetExplicitly;

  public AdrConnectWebService()
  {
    this.Url = MySettings.Default.MgaSystems_IMS_Common_adrconnect_AdrConnectWebService;
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

  public event ChangePasswordCompletedEventHandler ChangePasswordCompleted;

  public event OrderInteractiveCompletedEventHandler OrderInteractiveCompleted;

  public event SendOrdersCompletedEventHandler SendOrdersCompleted;

  public event ReceiveRecordsCompletedEventHandler ReceiveRecordsCompleted;

  [SoapDocumentMethod("http://adrconnect.mvrs.com/adrconnect/2013/04/IAdrConnectWebService/ChangePassword", RequestNamespace = "http://adrconnect.mvrs.com/adrconnect/2013/04/", ResponseNamespace = "http://adrconnect.mvrs.com/adrconnect/2013/04/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement(IsNullable = true)]
  public ChangePasswordResponseEntity ChangePassword(
    [XmlElement(IsNullable = true)] string inAccountID,
    [XmlElement(IsNullable = true)] string InUserID,
    [XmlElement(IsNullable = true)] string inCurrentPassword,
    [XmlElement(IsNullable = true)] string inNewPassword)
  {
    return (ChangePasswordResponseEntity) this.Invoke(nameof (ChangePassword), new object[4]
    {
      (object) inAccountID,
      (object) InUserID,
      (object) inCurrentPassword,
      (object) inNewPassword
    })[0];
  }

  public void ChangePasswordAsync(
    string inAccountID,
    string InUserID,
    string inCurrentPassword,
    string inNewPassword)
  {
    this.ChangePasswordAsync(inAccountID, InUserID, inCurrentPassword, inNewPassword, (object) null);
  }

  public void ChangePasswordAsync(
    string inAccountID,
    string InUserID,
    string inCurrentPassword,
    string inNewPassword,
    object userState)
  {
    if (this.ChangePasswordOperationCompleted == null)
      this.ChangePasswordOperationCompleted = new SendOrPostCallback(this.OnChangePasswordOperationCompleted);
    this.InvokeAsync("ChangePassword", new object[4]
    {
      (object) inAccountID,
      (object) InUserID,
      (object) inCurrentPassword,
      (object) inNewPassword
    }, this.ChangePasswordOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnChangePasswordOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ChangePasswordCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ChangePasswordCompletedEventHandler passwordCompletedEvent = this.ChangePasswordCompletedEvent;
    if (passwordCompletedEvent == null)
      return;
    passwordCompletedEvent((object) this, new ChangePasswordCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://adrconnect.mvrs.com/adrconnect/2013/04/IAdrConnectWebService/OrderInteractive", RequestNamespace = "http://adrconnect.mvrs.com/adrconnect/2013/04/", ResponseNamespace = "http://adrconnect.mvrs.com/adrconnect/2013/04/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement(IsNullable = true)]
  public InteractiveResponseEntity OrderInteractive([XmlElement(IsNullable = true)] string inCommunications, [XmlElement(IsNullable = true)] OrderEntity inOrder)
  {
    return (InteractiveResponseEntity) this.Invoke(nameof (OrderInteractive), new object[2]
    {
      (object) inCommunications,
      (object) inOrder
    })[0];
  }

  public void OrderInteractiveAsync(string inCommunications, OrderEntity inOrder)
  {
    this.OrderInteractiveAsync(inCommunications, inOrder, (object) null);
  }

  public void OrderInteractiveAsync(string inCommunications, OrderEntity inOrder, object userState)
  {
    if (this.OrderInteractiveOperationCompleted == null)
      this.OrderInteractiveOperationCompleted = new SendOrPostCallback(this.OnOrderInteractiveOperationCompleted);
    this.InvokeAsync("OrderInteractive", new object[2]
    {
      (object) inCommunications,
      (object) inOrder
    }, this.OrderInteractiveOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnOrderInteractiveOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.OrderInteractiveCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    OrderInteractiveCompletedEventHandler interactiveCompletedEvent = this.OrderInteractiveCompletedEvent;
    if (interactiveCompletedEvent == null)
      return;
    interactiveCompletedEvent((object) this, new OrderInteractiveCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://adrconnect.mvrs.com/adrconnect/2013/04/IAdrConnectWebService/SendOrders", RequestNamespace = "http://adrconnect.mvrs.com/adrconnect/2013/04/", ResponseNamespace = "http://adrconnect.mvrs.com/adrconnect/2013/04/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement(IsNullable = true)]
  public SendOrdersResponseEntity SendOrders([XmlElement(IsNullable = true)] string inCommunication, [XmlArray(IsNullable = true)] OrderEntity[] inOrders)
  {
    return (SendOrdersResponseEntity) this.Invoke(nameof (SendOrders), new object[2]
    {
      (object) inCommunication,
      (object) inOrders
    })[0];
  }

  public void SendOrdersAsync(string inCommunication, OrderEntity[] inOrders)
  {
    this.SendOrdersAsync(inCommunication, inOrders, (object) null);
  }

  public void SendOrdersAsync(string inCommunication, OrderEntity[] inOrders, object userState)
  {
    if (this.SendOrdersOperationCompleted == null)
      this.SendOrdersOperationCompleted = new SendOrPostCallback(this.OnSendOrdersOperationCompleted);
    this.InvokeAsync("SendOrders", new object[2]
    {
      (object) inCommunication,
      (object) inOrders
    }, this.SendOrdersOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnSendOrdersOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.SendOrdersCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    SendOrdersCompletedEventHandler ordersCompletedEvent = this.SendOrdersCompletedEvent;
    if (ordersCompletedEvent == null)
      return;
    ordersCompletedEvent((object) this, new SendOrdersCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
  }

  [SoapDocumentMethod("http://adrconnect.mvrs.com/adrconnect/2013/04/IAdrConnectWebService/ReceiveRecords", RequestNamespace = "http://adrconnect.mvrs.com/adrconnect/2013/04/", ResponseNamespace = "http://adrconnect.mvrs.com/adrconnect/2013/04/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
  [return: XmlElement(IsNullable = true)]
  public ReceiveRecordsResponseEntity ReceiveRecords([XmlElement(IsNullable = true)] string inCommunications)
  {
    return (ReceiveRecordsResponseEntity) this.Invoke(nameof (ReceiveRecords), new object[1]
    {
      (object) inCommunications
    })[0];
  }

  public void ReceiveRecordsAsync(string inCommunications)
  {
    this.ReceiveRecordsAsync(inCommunications, (object) null);
  }

  public void ReceiveRecordsAsync(string inCommunications, object userState)
  {
    if (this.ReceiveRecordsOperationCompleted == null)
      this.ReceiveRecordsOperationCompleted = new SendOrPostCallback(this.OnReceiveRecordsOperationCompleted);
    this.InvokeAsync("ReceiveRecords", new object[1]
    {
      (object) inCommunications
    }, this.ReceiveRecordsOperationCompleted, RuntimeHelpers.GetObjectValue(userState));
  }

  private void OnReceiveRecordsOperationCompleted(object arg)
  {
    // ISSUE: reference to a compiler-generated field
    if (this.ReceiveRecordsCompletedEvent == null)
      return;
    InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
    // ISSUE: reference to a compiler-generated field
    ReceiveRecordsCompletedEventHandler recordsCompletedEvent = this.ReceiveRecordsCompletedEvent;
    if (recordsCompletedEvent == null)
      return;
    recordsCompletedEvent((object) this, new ReceiveRecordsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, RuntimeHelpers.GetObjectValue(completedEventArgs.UserState)));
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

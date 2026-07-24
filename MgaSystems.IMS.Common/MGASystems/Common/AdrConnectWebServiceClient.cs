// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.AdrConnectWebServiceClient
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

#nullable disable
namespace MGASystems.Common;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class AdrConnectWebServiceClient : ClientBase<IAdrConnectWebService>, IAdrConnectWebService
{
  public AdrConnectWebServiceClient()
  {
  }

  public AdrConnectWebServiceClient(string endpointConfigurationName)
    : base(endpointConfigurationName)
  {
  }

  public AdrConnectWebServiceClient(string endpointConfigurationName, string remoteAddress)
    : base(endpointConfigurationName, remoteAddress)
  {
  }

  public AdrConnectWebServiceClient(string endpointConfigurationName, EndpointAddress remoteAddress)
    : base(endpointConfigurationName, remoteAddress)
  {
  }

  public AdrConnectWebServiceClient(Binding binding, EndpointAddress remoteAddress)
    : base(binding, remoteAddress)
  {
  }

  public ChangePasswordResponseEntity ChangePassword(
    string inAccountID,
    string InUserID,
    string inCurrentPassword,
    string inNewPassword)
  {
    return this.Channel.ChangePassword(inAccountID, InUserID, inCurrentPassword, inNewPassword);
  }

  public InteractiveResponseEntity OrderInteractive(string inCommunications, OrderEntity inOrder)
  {
    return this.Channel.OrderInteractive(inCommunications, inOrder);
  }

  public SendOrdersResponseEntity SendOrders(string inCommunication, OrderEntity[] inOrders)
  {
    return this.Channel.SendOrders(inCommunication, inOrders);
  }

  public ReceiveRecordsResponseEntity ReceiveRecords(string inCommunications)
  {
    return this.Channel.ReceiveRecords(inCommunications);
  }
}

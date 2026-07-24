// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.IAdrConnectWebService
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04;
using System.CodeDom.Compiler;
using System.ServiceModel;

#nullable disable
namespace MGASystems.Common;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[ServiceContract(Namespace = "http://adrconnect.mvrs.com/adrconnect/2013/04/", ConfigurationName = "IAdrConnectWebService")]
public interface IAdrConnectWebService
{
  [OperationContract(Action = "http://adrconnect.mvrs.com/adrconnect/2013/04/IAdrConnectWebService/ChangePassword", ReplyAction = "http://adrconnect.mvrs.com/adrconnect/2013/04/IAdrConnectWebService/ChangePasswordResponse")]
  ChangePasswordResponseEntity ChangePassword(
    string inAccountID,
    string InUserID,
    string inCurrentPassword,
    string inNewPassword);

  [OperationContract(Action = "http://adrconnect.mvrs.com/adrconnect/2013/04/IAdrConnectWebService/OrderInteractive", ReplyAction = "http://adrconnect.mvrs.com/adrconnect/2013/04/IAdrConnectWebService/OrderInteractiveResponse")]
  InteractiveResponseEntity OrderInteractive(string inCommunications, OrderEntity inOrder);

  [OperationContract(Action = "http://adrconnect.mvrs.com/adrconnect/2013/04/IAdrConnectWebService/SendOrders", ReplyAction = "http://adrconnect.mvrs.com/adrconnect/2013/04/IAdrConnectWebService/SendOrdersResponse")]
  SendOrdersResponseEntity SendOrders(string inCommunication, OrderEntity[] inOrders);

  [OperationContract(Action = "http://adrconnect.mvrs.com/adrconnect/2013/04/IAdrConnectWebService/ReceiveRecords", ReplyAction = "http://adrconnect.mvrs.com/adrconnect/2013/04/IAdrConnectWebService/ReceiveRecordsResponse")]
  ReceiveRecordsResponseEntity ReceiveRecords(string inCommunications);
}

// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Proxy.Verisk.Iix.SoapAuthPortType
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Proxy.Verisk.Iix;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[ServiceContract(Namespace = "http://com/iix/soap/SoapAuth.wsdl", ConfigurationName = "Proxy.Verisk.Iix.SoapAuthPortType")]
public interface SoapAuthPortType
{
  [OperationContract(Action = "", ReplyAction = "*")]
  [XmlSerializerFormat(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
  sendRequest2Response sendRequest2(sendRequest2Request request);

  [OperationContract(Action = "", ReplyAction = "*")]
  Task<sendRequest2Response> sendRequest2Async(sendRequest2Request request);

  [OperationContract(Action = "", ReplyAction = "*")]
  [XmlSerializerFormat(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
  sendRequestResponse sendRequest(sendRequestRequest request);

  [OperationContract(Action = "", ReplyAction = "*")]
  Task<sendRequestResponse> sendRequestAsync(sendRequestRequest request);

  [OperationContract(Action = "", ReplyAction = "*")]
  [XmlSerializerFormat(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
  getResponseResponse getResponse(getResponseRequest request);

  [OperationContract(Action = "", ReplyAction = "*")]
  Task<getResponseResponse> getResponseAsync(getResponseRequest request);

  [OperationContract(Action = "", ReplyAction = "*")]
  [XmlSerializerFormat(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
  getResponse2Response getResponse2(getResponse2Request request);

  [OperationContract(Action = "", ReplyAction = "*")]
  Task<getResponse2Response> getResponse2Async(getResponse2Request request);

  [OperationContract(Action = "", ReplyAction = "*")]
  [XmlSerializerFormat(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
  getXmlResponseResponse getXmlResponse(getXmlResponseRequest request);

  [OperationContract(Action = "", ReplyAction = "*")]
  Task<getXmlResponseResponse> getXmlResponseAsync(getXmlResponseRequest request);

  [OperationContract(Action = "", ReplyAction = "*")]
  [XmlSerializerFormat(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
  getXmlResponse2Response getXmlResponse2(getXmlResponse2Request request);

  [OperationContract(Action = "", ReplyAction = "*")]
  Task<getXmlResponse2Response> getXmlResponse2Async(getXmlResponse2Request request);

  [OperationContract(Action = "", ReplyAction = "*")]
  [XmlSerializerFormat(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
  getPdfResponseResponse getPdfResponse(getPdfResponseRequest request);

  [OperationContract(Action = "", ReplyAction = "*")]
  Task<getPdfResponseResponse> getPdfResponseAsync(getPdfResponseRequest request);

  [OperationContract(Action = "", ReplyAction = "*")]
  [XmlSerializerFormat(Style = OperationFormatStyle.Rpc, SupportFaults = true, Use = OperationFormatUse.Encoded)]
  getPdfResponse2Response getPdfResponse2(getPdfResponse2Request request);

  [OperationContract(Action = "", ReplyAction = "*")]
  Task<getPdfResponse2Response> getPdfResponse2Async(getPdfResponse2Request request);
}

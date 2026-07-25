// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Proxy.Verisk.Iix.SoapAuthPortTypeClient
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Proxy.Verisk.Iix;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class SoapAuthPortTypeClient : ClientBase<SoapAuthPortType>, SoapAuthPortType
{
  public SoapAuthPortTypeClient()
  {
  }

  public SoapAuthPortTypeClient(string endpointConfigurationName)
    : base(endpointConfigurationName)
  {
  }

  public SoapAuthPortTypeClient(string endpointConfigurationName, string remoteAddress)
    : base(endpointConfigurationName, remoteAddress)
  {
  }

  public SoapAuthPortTypeClient(string endpointConfigurationName, EndpointAddress remoteAddress)
    : base(endpointConfigurationName, remoteAddress)
  {
  }

  public SoapAuthPortTypeClient(Binding binding, EndpointAddress remoteAddress)
    : base(binding, remoteAddress)
  {
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  sendRequest2Response SoapAuthPortType.sendRequest2(sendRequest2Request request)
  {
    return this.Channel.sendRequest2(request);
  }

  public string sendRequest2(string msgString)
  {
    return ((SoapAuthPortType) this).sendRequest2(new sendRequest2Request()
    {
      msgString = msgString
    }).@return;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<sendRequest2Response> SoapAuthPortType.sendRequest2Async(sendRequest2Request request)
  {
    return this.Channel.sendRequest2Async(request);
  }

  public Task<sendRequest2Response> sendRequest2Async(string msgString)
  {
    return ((SoapAuthPortType) this).sendRequest2Async(new sendRequest2Request()
    {
      msgString = msgString
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  sendRequestResponse SoapAuthPortType.sendRequest(sendRequestRequest request)
  {
    return this.Channel.sendRequest(request);
  }

  public string sendRequest(string msgString)
  {
    return ((SoapAuthPortType) this).sendRequest(new sendRequestRequest()
    {
      msgString = msgString
    }).@return;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<sendRequestResponse> SoapAuthPortType.sendRequestAsync(sendRequestRequest request)
  {
    return this.Channel.sendRequestAsync(request);
  }

  public Task<sendRequestResponse> sendRequestAsync(string msgString)
  {
    return ((SoapAuthPortType) this).sendRequestAsync(new sendRequestRequest()
    {
      msgString = msgString
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  getResponseResponse SoapAuthPortType.getResponse(getResponseRequest request)
  {
    return this.Channel.getResponse(request);
  }

  public string getResponse(string msgString)
  {
    return ((SoapAuthPortType) this).getResponse(new getResponseRequest()
    {
      msgString = msgString
    }).@return;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<getResponseResponse> SoapAuthPortType.getResponseAsync(getResponseRequest request)
  {
    return this.Channel.getResponseAsync(request);
  }

  public Task<getResponseResponse> getResponseAsync(string msgString)
  {
    return ((SoapAuthPortType) this).getResponseAsync(new getResponseRequest()
    {
      msgString = msgString
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  getResponse2Response SoapAuthPortType.getResponse2(getResponse2Request request)
  {
    return this.Channel.getResponse2(request);
  }

  public string getResponse2(string msgString)
  {
    return ((SoapAuthPortType) this).getResponse2(new getResponse2Request()
    {
      msgString = msgString
    }).@return;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<getResponse2Response> SoapAuthPortType.getResponse2Async(getResponse2Request request)
  {
    return this.Channel.getResponse2Async(request);
  }

  public Task<getResponse2Response> getResponse2Async(string msgString)
  {
    return ((SoapAuthPortType) this).getResponse2Async(new getResponse2Request()
    {
      msgString = msgString
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  getXmlResponseResponse SoapAuthPortType.getXmlResponse(getXmlResponseRequest request)
  {
    return this.Channel.getXmlResponse(request);
  }

  public string getXmlResponse(string msgString)
  {
    return ((SoapAuthPortType) this).getXmlResponse(new getXmlResponseRequest()
    {
      msgString = msgString
    }).@return;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<getXmlResponseResponse> SoapAuthPortType.getXmlResponseAsync(getXmlResponseRequest request)
  {
    return this.Channel.getXmlResponseAsync(request);
  }

  public Task<getXmlResponseResponse> getXmlResponseAsync(string msgString)
  {
    return ((SoapAuthPortType) this).getXmlResponseAsync(new getXmlResponseRequest()
    {
      msgString = msgString
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  getXmlResponse2Response SoapAuthPortType.getXmlResponse2(getXmlResponse2Request request)
  {
    return this.Channel.getXmlResponse2(request);
  }

  public string getXmlResponse2(string msgString)
  {
    return ((SoapAuthPortType) this).getXmlResponse2(new getXmlResponse2Request()
    {
      msgString = msgString
    }).@return;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<getXmlResponse2Response> SoapAuthPortType.getXmlResponse2Async(getXmlResponse2Request request)
  {
    return this.Channel.getXmlResponse2Async(request);
  }

  public Task<getXmlResponse2Response> getXmlResponse2Async(string msgString)
  {
    return ((SoapAuthPortType) this).getXmlResponse2Async(new getXmlResponse2Request()
    {
      msgString = msgString
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  getPdfResponseResponse SoapAuthPortType.getPdfResponse(getPdfResponseRequest request)
  {
    return this.Channel.getPdfResponse(request);
  }

  public string getPdfResponse(string msgString)
  {
    return ((SoapAuthPortType) this).getPdfResponse(new getPdfResponseRequest()
    {
      msgString = msgString
    }).@return;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<getPdfResponseResponse> SoapAuthPortType.getPdfResponseAsync(getPdfResponseRequest request)
  {
    return this.Channel.getPdfResponseAsync(request);
  }

  public Task<getPdfResponseResponse> getPdfResponseAsync(string msgString)
  {
    return ((SoapAuthPortType) this).getPdfResponseAsync(new getPdfResponseRequest()
    {
      msgString = msgString
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  getPdfResponse2Response SoapAuthPortType.getPdfResponse2(getPdfResponse2Request request)
  {
    return this.Channel.getPdfResponse2(request);
  }

  public string getPdfResponse2(string msgString)
  {
    return ((SoapAuthPortType) this).getPdfResponse2(new getPdfResponse2Request()
    {
      msgString = msgString
    }).@return;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<getPdfResponse2Response> SoapAuthPortType.getPdfResponse2Async(getPdfResponse2Request request)
  {
    return this.Channel.getPdfResponse2Async(request);
  }

  public Task<getPdfResponse2Response> getPdfResponse2Async(string msgString)
  {
    return ((SoapAuthPortType) this).getPdfResponse2Async(new getPdfResponse2Request()
    {
      msgString = msgString
    });
  }
}

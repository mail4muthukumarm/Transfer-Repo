// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Proxy.Verisk.Iix.sendRequest2Response
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Proxy.Verisk.Iix;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "sendRequest2Response", WrapperNamespace = "http://com/iix/soap/SoapAuth.wsdl", IsWrapped = true)]
public class sendRequest2Response
{
  [MessageBodyMember(Namespace = "", Order = 0)]
  public string @return;

  public sendRequest2Response()
  {
  }

  public sendRequest2Response(string @return) => this.@return = @return;
}

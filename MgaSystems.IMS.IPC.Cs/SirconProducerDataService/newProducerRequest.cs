// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.newProducerRequest
// Assembly: MgaSystems.IMS.IPC.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 902BD8FA-9BAE-43A4-A4AA-C9585D23F16B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.Cs.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(IsWrapped = false)]
public class newProducerRequest
{
  [MessageHeader(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
  public SecurityHeaderType Security;
  [MessageHeader(Namespace = "http://sdb.sircon.com/webservice/2006/06/ProducerLifecycleService")]
  public VersionType Version;
  [MessageHeader(Namespace = "http://www.sircon.com/WebServices/services/CommonHeaders.xsd")]
  public int SubscriberId;
  [MessageBodyMember(Namespace = "http://px.sircon.com/schemas/2006/06/Transaction.xsd", Order = 0)]
  public Transactions Transactions;

  public newProducerRequest()
  {
  }

  public newProducerRequest(
    SecurityHeaderType Security,
    VersionType Version,
    int SubscriberId,
    Transactions Transactions)
  {
    this.Security = Security;
    this.Version = Version;
    this.SubscriberId = SubscriberId;
    this.Transactions = Transactions;
  }
}

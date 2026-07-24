// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.buildPotentialAppointmentsRequest1
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
public class buildPotentialAppointmentsRequest1
{
  [MessageHeader(Namespace = "http://www.sircon.com/WebServices/services/CommonHeaders.xsd")]
  public int SubscriberId;
  [MessageBodyMember(Namespace = "http://px.sircon.com/schemas/2006/06/Transaction.xsd", Order = 0)]
  public BuildPotentialAppointmentsRequest BuildPotentialAppointmentsRequest;

  public buildPotentialAppointmentsRequest1()
  {
  }

  public buildPotentialAppointmentsRequest1(
    int SubscriberId,
    BuildPotentialAppointmentsRequest BuildPotentialAppointmentsRequest)
  {
    this.SubscriberId = SubscriberId;
    this.BuildPotentialAppointmentsRequest = BuildPotentialAppointmentsRequest;
  }
}

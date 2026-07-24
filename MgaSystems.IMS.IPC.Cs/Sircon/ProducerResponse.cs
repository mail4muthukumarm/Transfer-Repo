// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Sircon.ProducerResponse
// Assembly: MgaSystems.IMS.IPC.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 902BD8FA-9BAE-43A4-A4AA-C9585D23F16B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.Cs.dll

using MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Sircon;

public class ProducerResponse
{
  public ProducerData producerData = new ProducerData();

  public ProducerData ProcessSirconResponse(ProducerQueryResponse SirconResponse)
  {
    this.producerData.isValid = false;
    if (SirconResponse == null)
    {
      this.producerData.statusMessage = this.producerData.SirconStatus = "No Respone from Sircon";
    }
    else
    {
      this.ProcessGenericSection(SirconResponse);
      string str = SirconResponse.Producer == null ? string.Empty : SirconResponse.Producer.Item.GetType().ToString();
      if (str.Contains("SirconProducerDataService.ProducerTypeIndividual"))
        this.ProcessIndividualSection((ProducerTypeIndividual) SirconResponse.Producer.Item);
      else if (str.Contains("SirconProducerDataService.ProducerTypeOrganization"))
        this.ProcessOrganizationSection((ProducerTypeOrganization) SirconResponse.Producer.Item);
      this.ProcessLicensesSection(SirconResponse);
      this.ProcessLOASection(SirconResponse);
    }
    return this.producerData;
  }

  private void ProcessGenericSection(ProducerQueryResponse SirconResponse)
  {
    if (SirconResponse.GenericResponse == null)
      return;
    if (SirconResponse.GenericResponse.Status == StatusType.Processed)
      this.producerData.isValid = true;
    this.producerData.SirconStatus = SirconResponse.GenericResponse.Status.ToString();
    this.producerData.statusMessage = string.Empty;
    if (SirconResponse.GenericResponse.ProcessingMessages == null)
      return;
    int num = ((IEnumerable<GenericResponseTypeProcessingMessage>) SirconResponse.GenericResponse.ProcessingMessages).Count<GenericResponseTypeProcessingMessage>();
    for (int index = 0; index < num; ++index)
    {
      ProducerData producerData = this.producerData;
      producerData.statusMessage = $"{producerData.statusMessage}{SirconResponse.GenericResponse.ProcessingMessages[index].Value}\n";
    }
  }

  private void ProcessIndividualSection(ProducerTypeIndividual individualSection)
  {
    this.producerData.indFullName = individualSection.FullName;
    this.producerData.indNPN = individualSection.NPN;
  }

  private void ProcessOrganizationSection(ProducerTypeOrganization organizationSection)
  {
    this.producerData.orgName = organizationSection.Name;
    this.producerData.orgNPN = organizationSection.NPN;
  }

  private void ProcessLicensesSection(ProducerQueryResponse SirconResponse)
  {
    int num = 0;
    if (SirconResponse != null && SirconResponse.Producer != null && SirconResponse.Producer.Licenses != null)
      num = ((IEnumerable<LicenseType>) SirconResponse.Producer.Licenses).Count<LicenseType>();
    for (int index = 0; index < num; ++index)
      this.producerData.lstLicenseData.Add(new LicenseData()
      {
        Type = SirconResponse.Producer.Licenses[index].Type.Description,
        State = this.StateCodeToString(SirconResponse.Producer.Licenses[index].State),
        Status = this.StatusCodeToString(SirconResponse.Producer.Licenses[index].Status),
        ExpirationDate = SirconResponse.Producer.Licenses[index].ExpirationDate,
        Number = SirconResponse.Producer.Licenses[index].Number
      });
  }

  private void ProcessLOASection(ProducerQueryResponse SirconResponse)
  {
    int num = 0;
    if (SirconResponse != null && SirconResponse.Producer != null && SirconResponse.Producer.LOAs != null)
      num = ((IEnumerable<LOAType>) SirconResponse.Producer.LOAs).Count<LOAType>();
    for (int index = 0; index < num; ++index)
      this.producerData.lstLOAData.Add(new LOAData()
      {
        Type = SirconResponse.Producer.LOAs[index].Type.Description,
        State = this.StateCodeToString(SirconResponse.Producer.LOAs[index].State),
        Status = this.StatusCodeToString(SirconResponse.Producer.LOAs[index].Status),
        StatusDate = SirconResponse.Producer.LOAs[index].StatusDate,
        ExpirationDate = SirconResponse.Producer.LOAs[index].ExpirationDate
      });
  }

  private string StateCodeToString(StateCodeType stateCode)
  {
    switch (stateCode)
    {
      case StateCodeType.AA:
        return "AA";
      case StateCodeType.AE:
        return "AE";
      case StateCodeType.AK:
        return "AK";
      case StateCodeType.AL:
        return "AL";
      case StateCodeType.AP:
        return "AP";
      case StateCodeType.AR:
        return "AR";
      case StateCodeType.AS:
        return "AS";
      case StateCodeType.AZ:
        return "AZ";
      case StateCodeType.CA:
        return "CA";
      case StateCodeType.CO:
        return "CO";
      case StateCodeType.CT:
        return "CT";
      case StateCodeType.DC:
        return "DC";
      case StateCodeType.DE:
        return "DE";
      case StateCodeType.FL:
        return "FL";
      case StateCodeType.GA:
        return "GA";
      case StateCodeType.GU:
        return "GU";
      case StateCodeType.HI:
        return "HI";
      case StateCodeType.IA:
        return "IA";
      case StateCodeType.ID:
        return "ID";
      case StateCodeType.IL:
        return "IL";
      case StateCodeType.IN:
        return "IN";
      case StateCodeType.KS:
        return "KS";
      case StateCodeType.KY:
        return "KY";
      case StateCodeType.LA:
        return "LA";
      case StateCodeType.MA:
        return "MA";
      case StateCodeType.MD:
        return "MD";
      case StateCodeType.ME:
        return "ME";
      case StateCodeType.MI:
        return "MI";
      case StateCodeType.MN:
        return "MN";
      case StateCodeType.MO:
        return "MO";
      case StateCodeType.MS:
        return "MS";
      case StateCodeType.MT:
        return "MT";
      case StateCodeType.NC:
        return "NC";
      case StateCodeType.ND:
        return "ND";
      case StateCodeType.NE:
        return "NE";
      case StateCodeType.NH:
        return "NH";
      case StateCodeType.NJ:
        return "NJ";
      case StateCodeType.NM:
        return "NM";
      case StateCodeType.NV:
        return "NV";
      case StateCodeType.NY:
        return "NY";
      case StateCodeType.OH:
        return "OH";
      case StateCodeType.OK:
        return "OK";
      case StateCodeType.OR:
        return "OR";
      case StateCodeType.PA:
        return "PA";
      case StateCodeType.PR:
        return "PR";
      case StateCodeType.RI:
        return "RI";
      case StateCodeType.SC:
        return "SC";
      case StateCodeType.SD:
        return "SD";
      case StateCodeType.TN:
        return "TN";
      case StateCodeType.TX:
        return "TX";
      case StateCodeType.UT:
        return "UT";
      case StateCodeType.VA:
        return "VA";
      case StateCodeType.VI:
        return "VI";
      case StateCodeType.VT:
        return "VT";
      case StateCodeType.WA:
        return "WA";
      case StateCodeType.WI:
        return "WI";
      case StateCodeType.WV:
        return "WV";
      case StateCodeType.WY:
        return "WY";
      default:
        return string.Empty;
    }
  }

  private string StatusCodeToString(GeneralStatusType statusCode)
  {
    switch (statusCode)
    {
      case GeneralStatusType.Active:
        return "Active";
      case GeneralStatusType.ActiveLapsed:
        return "Active - Lapsed";
      case GeneralStatusType.Inactive:
        return "Inactive";
      case GeneralStatusType.Pending:
        return "Pending";
      default:
        return string.Empty;
    }
  }
}

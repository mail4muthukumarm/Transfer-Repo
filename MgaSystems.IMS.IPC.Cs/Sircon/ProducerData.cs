// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Sircon.ProducerData
// Assembly: MgaSystems.IMS.IPC.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 902BD8FA-9BAE-43A4-A4AA-C9585D23F16B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.Cs.dll

using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Sircon;

public class ProducerData
{
  public string statusMessage = string.Empty;
  public List<LicenseData> lstLicenseData = new List<LicenseData>();
  public List<LOAData> lstLOAData = new List<LOAData>();

  public bool isValid { get; set; }

  public string SirconStatus { get; set; } = string.Empty;

  public string indFullName { get; set; } = string.Empty;

  public string indNPN { get; set; } = string.Empty;

  public string orgName { get; set; } = string.Empty;

  public string orgNPN { get; set; } = string.Empty;
}

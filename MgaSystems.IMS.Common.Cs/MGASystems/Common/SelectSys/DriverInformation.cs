// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.DriverInformation
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class DriverInformation
{
  [JsonProperty("No")]
  public int No { get; set; }

  [JsonProperty("Name")]
  public string Name { get; set; }

  [JsonProperty("Address")]
  public Acord_AddressInfo Address { get; set; }

  [JsonProperty("Sex")]
  public string Sex { get; set; }

  [JsonProperty("MaritalStatus")]
  public string MaritalStatus { get; set; }

  [JsonProperty("DateOfBirth")]
  public string DateOfBirth { get; set; }

  [JsonProperty("YearsExp")]
  public string YearsExp { get; set; }

  [JsonProperty("YearsLIC")]
  public string YearsLIC { get; set; }

  [JsonProperty("DriverLicenseOrSSN")]
  public string DriverLicenseOrSSN { get; set; }

  [JsonProperty("StateLIC")]
  public string StateLIC { get; set; }

  [JsonProperty("DateHire")]
  public string DateHire { get; set; }

  [JsonProperty("BroadenNoFault")]
  public string BroadenNoFault { get; set; }

  [JsonProperty("Doc")]
  public string Doc { get; set; }

  [JsonProperty("USEVEH")]
  public string USEVEH { get; set; }

  [JsonProperty("USEPer")]
  public string USEPer { get; set; }
}

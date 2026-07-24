// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.Data.PolicyAgencyInfo
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.Policies.E2Value.Data;

[GeneratedCode("xsd", "4.6.1590.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(TypeName = "tPOLICYAGENCYINFO")]
[Serializable]
public class PolicyAgencyInfo
{
  private string clientPolicyCarrierField;
  private string clientPolicyNumberField;
  private DateTime clientPolicyEffDateField;
  private bool clientPolicyEffDateFieldSpecified;
  private string clientAgencyNameField;
  private string clientAgencyAddressField;
  private string clientAgencyAddress2Field;
  private string clientAgencyCityField;
  private State clientAgencyStateField;
  private bool clientAgencyStateFieldSpecified;
  private string clientAgencyZipField;
  private string clientAgencyPhoneField;
  private string clientAgencyCodeField;
  private string clientPolicyAgentField;
  private string clientRequestorField;
  private string clientPersonInterviewedField;
  private DateTime clientInterviewDateField;
  private bool clientInterviewDateFieldSpecified;
  private string clientInspectedByField;

  public string ClientPolicyCarrier
  {
    get => this.clientPolicyCarrierField;
    set => this.clientPolicyCarrierField = value;
  }

  public string ClientPolicyNumber
  {
    get => this.clientPolicyNumberField;
    set => this.clientPolicyNumberField = value;
  }

  [XmlElement(DataType = "date")]
  public DateTime ClientPolicyEffDate
  {
    get => this.clientPolicyEffDateField;
    set => this.clientPolicyEffDateField = value;
  }

  [XmlIgnore]
  public bool ClientPolicyEffDateSpecified
  {
    get => this.clientPolicyEffDateFieldSpecified;
    set => this.clientPolicyEffDateFieldSpecified = value;
  }

  public string ClientAgencyName
  {
    get => this.clientAgencyNameField;
    set => this.clientAgencyNameField = value;
  }

  public string ClientAgencyAddress
  {
    get => this.clientAgencyAddressField;
    set => this.clientAgencyAddressField = value;
  }

  public string ClientAgencyAddress2
  {
    get => this.clientAgencyAddress2Field;
    set => this.clientAgencyAddress2Field = value;
  }

  public string ClientAgencyCity
  {
    get => this.clientAgencyCityField;
    set => this.clientAgencyCityField = value;
  }

  public State ClientAgencyState
  {
    get => this.clientAgencyStateField;
    set => this.clientAgencyStateField = value;
  }

  [XmlIgnore]
  public bool ClientAgencyStateSpecified
  {
    get => this.clientAgencyStateFieldSpecified;
    set => this.clientAgencyStateFieldSpecified = value;
  }

  public string ClientAgencyZip
  {
    get => this.clientAgencyZipField;
    set => this.clientAgencyZipField = value;
  }

  public string ClientAgencyPhone
  {
    get => this.clientAgencyPhoneField;
    set => this.clientAgencyPhoneField = value;
  }

  public string ClientAgencyCode
  {
    get => this.clientAgencyCodeField;
    set => this.clientAgencyCodeField = value;
  }

  public string ClientPolicyAgent
  {
    get => this.clientPolicyAgentField;
    set => this.clientPolicyAgentField = value;
  }

  public string ClientRequestor
  {
    get => this.clientRequestorField;
    set => this.clientRequestorField = value;
  }

  public string ClientPersonInterviewed
  {
    get => this.clientPersonInterviewedField;
    set => this.clientPersonInterviewedField = value;
  }

  [XmlElement(DataType = "date")]
  public DateTime ClientInterviewDate
  {
    get => this.clientInterviewDateField;
    set => this.clientInterviewDateField = value;
  }

  [XmlIgnore]
  public bool ClientInterviewDateSpecified
  {
    get => this.clientInterviewDateFieldSpecified;
    set => this.clientInterviewDateFieldSpecified = value;
  }

  public string ClientInspectedBy
  {
    get => this.clientInspectedByField;
    set => this.clientInspectedByField = value;
  }
}

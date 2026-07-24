// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.RCT.Inspection
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections.RCT;

[GeneratedCode("xsd", "4.8.3928.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false)]
[Serializable]
public class Inspection
{
  private string inspectionUniqueIDField;
  private string descriptionField;
  private string policyNoField;
  private DateTime dateAssignedField;
  private bool dateAssignedFieldSpecified;
  private DateTime dateRequiredField;
  private bool dateRequiredFieldSpecified;
  private DateTime dateCompletedField;
  private bool dateCompletedFieldSpecified;
  private DateTime dateArchiveField;
  private bool dateArchiveFieldSpecified;
  private string noteField;
  private string inspectionStatusField;
  private string inspectionTypeField;
  private string priorityField;
  private string severityField;
  private string riskQualityField;
  private string regionField;
  private string writingCompanyField;
  private InspectionCreateInspection createInspectionField;
  private bool createInspectionFieldSpecified;
  private Address addressField;
  private InspectionBroker inspectionBrokerField;
  private Client clientField;
  private UnderWriter underWriterField;
  private Inspector inspectorField;
  private ExtField[] extFieldsField;
  private InspectionForms formsField;

  public string InspectionUniqueID
  {
    get => this.inspectionUniqueIDField;
    set => this.inspectionUniqueIDField = value;
  }

  public string Description
  {
    get => this.descriptionField;
    set => this.descriptionField = value;
  }

  public string PolicyNo
  {
    get => this.policyNoField;
    set => this.policyNoField = value;
  }

  [XmlElement(DataType = "date")]
  public DateTime DateAssigned
  {
    get => this.dateAssignedField;
    set => this.dateAssignedField = value;
  }

  [XmlIgnore]
  public bool DateAssignedSpecified
  {
    get => this.dateAssignedFieldSpecified;
    set => this.dateAssignedFieldSpecified = value;
  }

  [XmlElement(DataType = "date")]
  public DateTime DateRequired
  {
    get => this.dateRequiredField;
    set => this.dateRequiredField = value;
  }

  [XmlIgnore]
  public bool DateRequiredSpecified
  {
    get => this.dateRequiredFieldSpecified;
    set => this.dateRequiredFieldSpecified = value;
  }

  [XmlElement(DataType = "date")]
  public DateTime DateCompleted
  {
    get => this.dateCompletedField;
    set => this.dateCompletedField = value;
  }

  [XmlIgnore]
  public bool DateCompletedSpecified
  {
    get => this.dateCompletedFieldSpecified;
    set => this.dateCompletedFieldSpecified = value;
  }

  [XmlElement(DataType = "date")]
  public DateTime DateArchive
  {
    get => this.dateArchiveField;
    set => this.dateArchiveField = value;
  }

  [XmlIgnore]
  public bool DateArchiveSpecified
  {
    get => this.dateArchiveFieldSpecified;
    set => this.dateArchiveFieldSpecified = value;
  }

  public string Note
  {
    get => this.noteField;
    set => this.noteField = value;
  }

  public string InspectionStatus
  {
    get => this.inspectionStatusField;
    set => this.inspectionStatusField = value;
  }

  public string InspectionType
  {
    get => this.inspectionTypeField;
    set => this.inspectionTypeField = value;
  }

  public string Priority
  {
    get => this.priorityField;
    set => this.priorityField = value;
  }

  public string Severity
  {
    get => this.severityField;
    set => this.severityField = value;
  }

  public string RiskQuality
  {
    get => this.riskQualityField;
    set => this.riskQualityField = value;
  }

  public string Region
  {
    get => this.regionField;
    set => this.regionField = value;
  }

  public string WritingCompany
  {
    get => this.writingCompanyField;
    set => this.writingCompanyField = value;
  }

  public InspectionCreateInspection CreateInspection
  {
    get => this.createInspectionField;
    set => this.createInspectionField = value;
  }

  [XmlIgnore]
  public bool CreateInspectionSpecified
  {
    get => this.createInspectionFieldSpecified;
    set => this.createInspectionFieldSpecified = value;
  }

  public Address Address
  {
    get => this.addressField;
    set => this.addressField = value;
  }

  public InspectionBroker InspectionBroker
  {
    get => this.inspectionBrokerField;
    set => this.inspectionBrokerField = value;
  }

  public Client Client
  {
    get => this.clientField;
    set => this.clientField = value;
  }

  public UnderWriter UnderWriter
  {
    get => this.underWriterField;
    set => this.underWriterField = value;
  }

  public Inspector Inspector
  {
    get => this.inspectorField;
    set => this.inspectorField = value;
  }

  [XmlArrayItem("ExtField", IsNullable = false)]
  public ExtField[] ExtFields
  {
    get => this.extFieldsField;
    set => this.extFieldsField = value;
  }

  public InspectionForms Forms
  {
    get => this.formsField;
    set => this.formsField = value;
  }
}

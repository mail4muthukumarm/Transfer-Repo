// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.Data.EstimateProperty
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.Policies.E2Value.Data;

[XmlInclude(typeof (object))]
[GeneratedCode("xsd", "4.6.1590.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(TypeName = "estimateProperty", AnonymousType = true)]
[Serializable]
public class EstimateProperty
{
  private StructureType structuretypeField;
  private int total_square_footageField;
  private string address1Field;
  private string address2Field;
  private string cityField;
  private State? stateField;
  private bool stateFieldSpecified;
  private string zipcodeField;
  private Decimal coverage_aField;
  private bool coverage_aFieldSpecified;
  private ConstructionQuality construction_qualityField;
  private bool construction_qualityFieldSpecified;
  private ConstructionType construction_typeField;
  private bool construction_typeFieldSpecified;
  private Exterior exteriorField;
  private bool exteriorFieldSpecified;
  private RoofCovering roof_coveringField;
  private bool roof_coveringFieldSpecified;
  private string businessEntityNameField;
  private PolicyAgencyInfo policyAgencyInfoField;
  private ReturnAcv return_acvField;
  private Area[] other_areasField;

  public EstimateProperty()
  {
    this.policyAgencyInfoField = new PolicyAgencyInfo();
    this.return_acvField = new ReturnAcv();
  }

  public StructureType structuretype
  {
    get => this.structuretypeField;
    set => this.structuretypeField = value;
  }

  [XmlElement(DataType = "integer")]
  public string total_square_footage
  {
    get => this.total_square_footageField.ToString();
    set => this.total_square_footageField = int.Parse(value, NumberStyles.Any);
  }

  public virtual string address1
  {
    get => this.address1Field;
    set => this.address1Field = value;
  }

  public virtual string address2
  {
    get => this.address2Field;
    set => this.address2Field = value;
  }

  public virtual string city
  {
    get => this.cityField;
    set => this.cityField = value;
  }

  public virtual State? state
  {
    get => this.stateField;
    set => this.stateField = value;
  }

  [XmlIgnore]
  public bool stateSpecified
  {
    get => this.stateFieldSpecified;
    set => this.stateFieldSpecified = value;
  }

  public string zipcode
  {
    get => this.zipcodeField;
    set => this.zipcodeField = value;
  }

  public Decimal coverage_a
  {
    get => this.coverage_aField;
    set => this.coverage_aField = value;
  }

  [XmlIgnore]
  public bool coverage_aSpecified
  {
    get => this.coverage_aFieldSpecified;
    set => this.coverage_aFieldSpecified = value;
  }

  public ConstructionQuality construction_quality
  {
    get => this.construction_qualityField;
    set => this.construction_qualityField = value;
  }

  [XmlIgnore]
  public bool construction_qualitySpecified
  {
    get => this.construction_qualityFieldSpecified;
    set => this.construction_qualityFieldSpecified = value;
  }

  public ConstructionType construction_type
  {
    get => this.construction_typeField;
    set => this.construction_typeField = value;
  }

  [XmlIgnore]
  public bool construction_typeSpecified
  {
    get => this.construction_typeFieldSpecified;
    set => this.construction_typeFieldSpecified = value;
  }

  public Exterior exterior
  {
    get => this.exteriorField;
    set => this.exteriorField = value;
  }

  [XmlIgnore]
  public bool exteriorSpecified
  {
    get => this.exteriorFieldSpecified;
    set => this.exteriorFieldSpecified = value;
  }

  public RoofCovering roof_covering
  {
    get => this.roof_coveringField;
    set => this.roof_coveringField = value;
  }

  [XmlIgnore]
  public bool roof_coveringSpecified
  {
    get => this.roof_coveringFieldSpecified;
    set => this.roof_coveringFieldSpecified = value;
  }

  public string BusinessEntityName
  {
    get => this.businessEntityNameField;
    set => this.businessEntityNameField = value;
  }

  public PolicyAgencyInfo PolicyAgencyInfo
  {
    get => this.policyAgencyInfoField;
    set => this.policyAgencyInfoField = value;
  }

  public ReturnAcv return_acv
  {
    get => this.return_acvField;
    set => this.return_acvField = value;
  }

  [XmlArrayItem("area", IsNullable = false)]
  public Area[] other_areas
  {
    get => this.other_areasField;
    set => this.other_areasField = value;
  }
}

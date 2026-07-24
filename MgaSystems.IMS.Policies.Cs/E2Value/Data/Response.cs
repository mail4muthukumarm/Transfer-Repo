// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.Data.Response
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Data.Binding;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.Policies.E2Value.Data;

[DesignerCategory("code")]
[XmlType("tRESPONSE")]
[XmlRoot("response", IsNullable = false)]
[Serializable]
public class Response
{
  private CostDetails cost_detailsField;
  private Avc acvField;
  private Area[] other_areasField;
  private TotalReplacementCost total_replacement_costField;
  private ConstructionQuality construction_qualityField;
  private bool construction_qualityFieldSpecified;
  private ConstructionType construction_typeField;
  private bool construction_typeFieldSpecified;
  private Exterior exteriorField;
  private bool exteriorFieldSpecified;
  private RoofCovering roof_coveringField;
  private bool roof_coveringFieldSpecified;
  private PolicyAgencyInfo policyAgencyInfoField;
  private Status statusField;
  private bool statusFieldSpecified;

  public string RawResponse { get; set; }

  public string message { get; set; }

  public CostDetails cost_details
  {
    get => this.cost_detailsField;
    set => this.cost_detailsField = value;
  }

  public Avc acv
  {
    get => this.acvField;
    set => this.acvField = value;
  }

  [XmlArrayItem("area", IsNullable = false)]
  public Area[] other_areas
  {
    get => this.other_areasField;
    set => this.other_areasField = value;
  }

  [NotificationProperty]
  public TotalReplacementCost total_replacement_cost
  {
    get => this.total_replacement_costField;
    set => this.total_replacement_costField = value;
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

  public PolicyAgencyInfo PolicyAgencyInfo
  {
    get => this.policyAgencyInfoField;
    set => this.policyAgencyInfoField = value;
  }

  [XmlAttribute]
  public Status status
  {
    get => this.statusField;
    set => this.statusField = value;
  }

  [XmlIgnore]
  public bool statusSpecified
  {
    get => this.statusFieldSpecified;
    set => this.statusFieldSpecified = value;
  }
}

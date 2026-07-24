// Decompiled with JetBrains decompiler
// Type: Area
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MgaSystems.IMS.Policies.E2Value.Data;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
[GeneratedCode("xsd", "4.6.1590.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[Serializable]
public class Area
{
  private string area_cost_range_highField;
  private bool area_cost_range_highFieldSpecified;
  private string area_cost_range_lowField;
  private bool area_cost_range_lowFieldSpecified;
  private string area_cost_range_medField;
  private bool area_cost_range_medFieldSpecified;
  private AreaName area_nameField;
  private string square_footageField;

  public AreaName area_name
  {
    get => this.area_nameField;
    set => this.area_nameField = value;
  }

  public string area_cost_range_low
  {
    get => this.area_cost_range_lowField;
    set => this.area_cost_range_lowField = value;
  }

  [XmlIgnore]
  public bool area_cost_range_lowSpecified
  {
    get => this.area_cost_range_lowFieldSpecified;
    set => this.area_cost_range_lowFieldSpecified = value;
  }

  public string area_cost_range_med
  {
    get => this.area_cost_range_medField;
    set => this.area_cost_range_medField = value;
  }

  [XmlIgnore]
  public bool area_cost_range_medSpecified
  {
    get => this.area_cost_range_medFieldSpecified;
    set => this.area_cost_range_medFieldSpecified = value;
  }

  public string area_cost_range_high
  {
    get => this.area_cost_range_highField;
    set => this.area_cost_range_highField = value;
  }

  [XmlIgnore]
  public bool area_cost_range_highSpecified
  {
    get => this.area_cost_range_highFieldSpecified;
    set => this.area_cost_range_highFieldSpecified = value;
  }

  [XmlElement(DataType = "integer")]
  public string square_footage
  {
    get => this.square_footageField;
    set => this.square_footageField = value;
  }
}

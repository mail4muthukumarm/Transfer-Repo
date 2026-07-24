// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.Data.CostDetails
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
[XmlType(TypeName = "tCOSTDETAILS")]
[Serializable]
public class CostDetails
{
  private StructureCostRange structure_cost_range_lowField;
  private StructureCostRange structure_cost_range_medField;
  private StructureCostRange structure_cost_range_highField;

  public StructureCostRange structure_cost_range_low
  {
    get => this.structure_cost_range_lowField;
    set => this.structure_cost_range_lowField = value;
  }

  public StructureCostRange structure_cost_range_med
  {
    get => this.structure_cost_range_medField;
    set => this.structure_cost_range_medField = value;
  }

  public StructureCostRange structure_cost_range_high
  {
    get => this.structure_cost_range_highField;
    set => this.structure_cost_range_highField = value;
  }
}

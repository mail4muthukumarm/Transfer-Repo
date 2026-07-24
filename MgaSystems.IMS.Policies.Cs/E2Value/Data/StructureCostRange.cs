// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.Data.StructureCostRange
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
[XmlType("tSTRUCTURECOSTRANGE")]
[Serializable]
public class StructureCostRange
{
  private string cost_per_sqftField;
  private string total_replacement_costField;

  public string cost_per_sqft
  {
    get => this.cost_per_sqftField;
    set => this.cost_per_sqftField = value;
  }

  public string total_replacement_cost
  {
    get => this.total_replacement_costField;
    set => this.total_replacement_costField = value;
  }
}

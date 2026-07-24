// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.Data.Avc
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
[XmlType(TypeName = "tACV")]
[Serializable]
public class Avc
{
  private string acv_range_lowField;
  private string acv_range_medField;
  private string acv_range_highField;

  public string acv_range_low
  {
    get => this.acv_range_lowField;
    set => this.acv_range_lowField = value;
  }

  public string acv_range_med
  {
    get => this.acv_range_medField;
    set => this.acv_range_medField = value;
  }

  public string acv_range_high
  {
    get => this.acv_range_highField;
    set => this.acv_range_highField = value;
  }
}

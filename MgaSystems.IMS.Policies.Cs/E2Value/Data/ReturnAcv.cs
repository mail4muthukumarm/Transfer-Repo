// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.Data.ReturnAcv
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
[XmlType("tRETURNACV")]
[Serializable]
public class ReturnAcv
{
  private YesNo structure_in_useField;
  private ReturnAcvCondition conditionField;
  private YesNo valueField;

  public ReturnAcv() => this.conditionField = new ReturnAcvCondition();

  public YesNo structure_in_use
  {
    get => this.structure_in_useField;
    set => this.structure_in_useField = value;
  }

  public ReturnAcvCondition condition
  {
    get => this.conditionField;
    set => this.conditionField = value;
  }

  [XmlAttribute]
  public YesNo value
  {
    get => this.valueField;
    set => this.valueField = value;
  }
}

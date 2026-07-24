// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.Data.ReturnAcvCondition
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
[XmlType("tRETURNACVCondition", AnonymousType = true)]
[Serializable]
public class ReturnAcvCondition
{
  private Condition generalField;
  private Condition roofField;
  private Condition wallField;
  private Condition foundationField;

  public Condition general
  {
    get => this.generalField;
    set => this.generalField = value;
  }

  public Condition roof
  {
    get => this.roofField;
    set => this.roofField = value;
  }

  public Condition wall
  {
    get => this.wallField;
    set => this.wallField = value;
  }

  public Condition foundation
  {
    get => this.foundationField;
    set => this.foundationField = value;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.RCT.ExtField
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
public class ExtField
{
  private string fieldNameField;
  private string fieldValueField;

  public string FieldName
  {
    get => this.fieldNameField;
    set => this.fieldNameField = value;
  }

  public string FieldValue
  {
    get => this.fieldValueField;
    set => this.fieldValueField = value;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.AdrDemo.SummaryEntity
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.Common.AdrDemo;

[GeneratedCode("System.Xml", "4.8.4084.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://adrconnect.mvrs.com/adrconnect/2013/04/")]
[Serializable]
public class SummaryEntity
{
  private string hostField;
  private string licenseField;
  private string referenceField;
  private string resultField;

  [XmlElement(IsNullable = true)]
  public string Host
  {
    get => this.hostField;
    set => this.hostField = value;
  }

  [XmlElement(IsNullable = true)]
  public string License
  {
    get => this.licenseField;
    set => this.licenseField = value;
  }

  [XmlElement(IsNullable = true)]
  public string Reference
  {
    get => this.referenceField;
    set => this.referenceField = value;
  }

  [XmlElement(IsNullable = true)]
  public string Result
  {
    get => this.resultField;
    set => this.resultField = value;
  }
}

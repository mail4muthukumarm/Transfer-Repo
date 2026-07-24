// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.AdrDemo.CallValidationResponseEntity
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
public class CallValidationResponseEntity
{
  private int daysLeftField;
  private bool daysLeftFieldSpecified;
  private string errorDescriptionField;
  private int errorIdField;
  private bool errorIdFieldSpecified;
  private string messageField;

  public int DaysLeft
  {
    get => this.daysLeftField;
    set => this.daysLeftField = value;
  }

  [XmlIgnore]
  public bool DaysLeftSpecified
  {
    get => this.daysLeftFieldSpecified;
    set => this.daysLeftFieldSpecified = value;
  }

  [XmlElement(IsNullable = true)]
  public string ErrorDescription
  {
    get => this.errorDescriptionField;
    set => this.errorDescriptionField = value;
  }

  public int ErrorId
  {
    get => this.errorIdField;
    set => this.errorIdField = value;
  }

  [XmlIgnore]
  public bool ErrorIdSpecified
  {
    get => this.errorIdFieldSpecified;
    set => this.errorIdFieldSpecified = value;
  }

  [XmlElement(IsNullable = true)]
  public string Message
  {
    get => this.messageField;
    set => this.messageField = value;
  }
}

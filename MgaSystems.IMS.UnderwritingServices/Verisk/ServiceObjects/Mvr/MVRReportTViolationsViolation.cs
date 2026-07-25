// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr.MVRReportTViolationsViolation
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr;

[GeneratedCode("xsd", "4.8.3928.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "http://www.iix.com/mvr")]
[Serializable]
public class MVRReportTViolationsViolation
{
  private string violationTypeField;
  private string violationDateField;
  private string convictionDateField;
  private string violationCodeField;
  private string pointsField;
  private string assignedViolationCodeField;
  private string assignedPointsField;
  private string[] violationDetailField;

  public string ViolationType
  {
    get => this.violationTypeField;
    set => this.violationTypeField = value;
  }

  public string ViolationDate
  {
    get => this.violationDateField;
    set => this.violationDateField = value;
  }

  public string ConvictionDate
  {
    get => this.convictionDateField;
    set => this.convictionDateField = value;
  }

  public string ViolationCode
  {
    get => this.violationCodeField;
    set => this.violationCodeField = value;
  }

  public string Points
  {
    get => this.pointsField;
    set => this.pointsField = value;
  }

  public string AssignedViolationCode
  {
    get => this.assignedViolationCodeField;
    set => this.assignedViolationCodeField = value;
  }

  public string AssignedPoints
  {
    get => this.assignedPointsField;
    set => this.assignedPointsField = value;
  }

  [XmlArrayItem("Detail", IsNullable = false)]
  public string[] ViolationDetail
  {
    get => this.violationDetailField;
    set => this.violationDetailField = value;
  }
}

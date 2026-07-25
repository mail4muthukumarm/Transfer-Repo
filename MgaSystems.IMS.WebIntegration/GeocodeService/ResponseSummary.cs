// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.GeocodeService.ResponseSummary
// Assembly: MgaSystems.IMS.WebIntegration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 82DEE314-E11A-4163-B1B3-C42062AE6494
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.WebIntegration.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.WebIntegration.GeocodeService;

[GeneratedCode("System.Xml", "4.7.2102.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://dev.virtualearth.net/webservices/v1/common")]
[Serializable]
public class ResponseSummary
{
  private AuthenticationResultCode authenticationResultCodeField;
  private bool authenticationResultCodeFieldSpecified;
  private string copyrightField;
  private string faultReasonField;
  private ResponseStatusCode statusCodeField;
  private bool statusCodeFieldSpecified;
  private string traceIdField;

  public AuthenticationResultCode AuthenticationResultCode
  {
    get => this.authenticationResultCodeField;
    set => this.authenticationResultCodeField = value;
  }

  [XmlIgnore]
  public bool AuthenticationResultCodeSpecified
  {
    get => this.authenticationResultCodeFieldSpecified;
    set => this.authenticationResultCodeFieldSpecified = value;
  }

  [XmlElement(IsNullable = true)]
  public string Copyright
  {
    get => this.copyrightField;
    set => this.copyrightField = value;
  }

  [XmlElement(IsNullable = true)]
  public string FaultReason
  {
    get => this.faultReasonField;
    set => this.faultReasonField = value;
  }

  public ResponseStatusCode StatusCode
  {
    get => this.statusCodeField;
    set => this.statusCodeField = value;
  }

  [XmlIgnore]
  public bool StatusCodeSpecified
  {
    get => this.statusCodeFieldSpecified;
    set => this.statusCodeFieldSpecified = value;
  }

  [XmlElement(IsNullable = true)]
  public string TraceId
  {
    get => this.traceIdField;
    set => this.traceIdField = value;
  }
}

// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.ImageryService.RequestBase
// Assembly: MgaSystems.IMS.WebIntegration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 82DEE314-E11A-4163-B1B3-C42062AE6494
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.WebIntegration.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.WebIntegration.ImageryService;

[XmlInclude(typeof (MapUriRequest))]
[XmlInclude(typeof (ImageryMetadataRequest))]
[GeneratedCode("System.Xml", "4.6.1586.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://dev.virtualearth.net/webservices/v1/common")]
[Serializable]
public class RequestBase
{
  private Credentials credentialsField;
  private string cultureField;
  private ExecutionOptions executionOptionsField;
  private UserProfile userProfileField;

  [XmlElement(IsNullable = true)]
  public Credentials Credentials
  {
    get => this.credentialsField;
    set => this.credentialsField = value;
  }

  [XmlElement(IsNullable = true)]
  public string Culture
  {
    get => this.cultureField;
    set => this.cultureField = value;
  }

  [XmlElement(IsNullable = true)]
  public ExecutionOptions ExecutionOptions
  {
    get => this.executionOptionsField;
    set => this.executionOptionsField = value;
  }

  [XmlElement(IsNullable = true)]
  public UserProfile UserProfile
  {
    get => this.userProfileField;
    set => this.userProfileField = value;
  }
}

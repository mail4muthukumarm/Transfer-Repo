// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.ImageryService.ImageryProvider
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

[GeneratedCode("System.Xml", "4.6.1586.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://dev.virtualearth.net/webservices/v1/imagery")]
[Serializable]
public class ImageryProvider
{
  private string attributionField;
  private CoverageArea[] coverageAreasField;

  [XmlElement(IsNullable = true)]
  public string Attribution
  {
    get => this.attributionField;
    set => this.attributionField = value;
  }

  [XmlArray(IsNullable = true)]
  public CoverageArea[] CoverageAreas
  {
    get => this.coverageAreasField;
    set => this.coverageAreasField = value;
  }
}

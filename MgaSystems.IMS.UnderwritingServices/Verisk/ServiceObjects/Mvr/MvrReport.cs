// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr.MvrReport
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
[XmlRoot(Namespace = "http://www.iix.com/mvr", IsNullable = false, ElementName = "MVR")]
[Serializable]
public class MvrReport
{
  private MVRRequestT mVRRequestField;
  private MVRReportT[] mVRReportsField;

  public MVRRequestT MVRRequest
  {
    get => this.mVRRequestField;
    set => this.mVRRequestField = value;
  }

  [XmlArrayItem("MVRReport", IsNullable = false)]
  public MVRReportT[] MVRReports
  {
    get => this.mVRReportsField;
    set => this.mVRReportsField = value;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.UpdateServices.UpdateFileInformation
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.Common.UpdateServices;

[GeneratedCode("System.Xml", "4.8.9032.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://MGASystems.com")]
[Serializable]
public class UpdateFileInformation
{
  private string fileNameField;
  private byte[] fileDataField;

  public string FileName
  {
    get => this.fileNameField;
    set => this.fileNameField = value;
  }

  [XmlElement(DataType = "base64Binary")]
  public byte[] FileData
  {
    get => this.fileDataField;
    set => this.fileDataField = value;
  }
}

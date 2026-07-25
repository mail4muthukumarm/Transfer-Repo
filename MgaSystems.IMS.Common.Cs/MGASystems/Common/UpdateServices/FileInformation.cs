// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.UpdateServices.FileInformation
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
public class FileInformation
{
  private string fileNameField;
  private string fileHashField;
  private string fileURLField;
  private string nameField;
  private bool deleteClientCopyField;

  public string FileName
  {
    get => this.fileNameField;
    set => this.fileNameField = value;
  }

  public string FileHash
  {
    get => this.fileHashField;
    set => this.fileHashField = value;
  }

  public string FileURL
  {
    get => this.fileURLField;
    set => this.fileURLField = value;
  }

  public string Name
  {
    get => this.nameField;
    set => this.nameField = value;
  }

  public bool DeleteClientCopy
  {
    get => this.deleteClientCopyField;
    set => this.deleteClientCopyField = value;
  }
}

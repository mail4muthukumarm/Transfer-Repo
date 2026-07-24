// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.Data.ErrorResponse
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System;
using System.ComponentModel;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.Policies.E2Value.Data;

[DesignerCategory("code")]
[XmlRoot("response", IsNullable = false)]
[Serializable]
public class ErrorResponse
{
  private string messageField;
  private Status statusField;

  public string message
  {
    get => this.messageField;
    set => this.messageField = value;
  }

  [XmlAttribute]
  public Status status
  {
    get => this.statusField;
    set => this.statusField = value;
  }
}

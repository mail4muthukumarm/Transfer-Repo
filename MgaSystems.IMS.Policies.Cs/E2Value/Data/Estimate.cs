// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.Data.Estimate
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System;
using System.ComponentModel;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.Policies.E2Value.Data;

[DesignerCategory("code")]
[XmlRoot("estimate")]
[XmlType(TypeName = "estimate", AnonymousType = true)]
[Serializable]
public class Estimate
{
  private EstimateProperty propertyField;
  private string usernameField;
  private string passwordField;
  private EstType typeField;
  private bool typeFieldSpecified;

  public Estimate() => this.propertyField = new EstimateProperty();

  public EstimateProperty property
  {
    get => this.propertyField;
    set => this.propertyField = value;
  }

  [XmlAttribute]
  public string username
  {
    get => this.usernameField;
    set => this.usernameField = value;
  }

  [XmlAttribute]
  public string password
  {
    get => this.passwordField;
    set => this.passwordField = value;
  }

  [XmlAttribute]
  public EstType type
  {
    get => this.typeField;
    set => this.typeField = value;
  }

  [XmlIgnore]
  public bool typeSpecified
  {
    get => this.typeFieldSpecified;
    set => this.typeFieldSpecified = value;
  }
}

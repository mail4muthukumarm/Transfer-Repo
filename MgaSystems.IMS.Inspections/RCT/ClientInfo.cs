// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.RCT.ClientInfo
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections.RCT;

[GeneratedCode("xsd", "4.8.3928.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false)]
[Serializable]
public class ClientInfo
{
  private string clientUniqueIDField;
  private string contactNumberField;
  private Name nameField;
  private string phoneField;
  private string faxField;
  private string emailField;
  private string noteField;
  private Address addressField;
  private ExtField[] extFieldsField;
  private Locations locationsField;
  private Company companyField;
  private Inspector inspectorField;

  public string ClientUniqueID
  {
    get => this.clientUniqueIDField;
    set => this.clientUniqueIDField = value;
  }

  public string ContactNumber
  {
    get => this.contactNumberField;
    set => this.contactNumberField = value;
  }

  public Name Name
  {
    get => this.nameField;
    set => this.nameField = value;
  }

  public string Phone
  {
    get => this.phoneField;
    set => this.phoneField = value;
  }

  public string Fax
  {
    get => this.faxField;
    set => this.faxField = value;
  }

  public string Email
  {
    get => this.emailField;
    set => this.emailField = value;
  }

  public string Note
  {
    get => this.noteField;
    set => this.noteField = value;
  }

  public Address Address
  {
    get => this.addressField;
    set => this.addressField = value;
  }

  [XmlArrayItem("ExtField", IsNullable = false)]
  public ExtField[] ExtFields
  {
    get => this.extFieldsField;
    set => this.extFieldsField = value;
  }

  public Locations Locations
  {
    get => this.locationsField;
    set => this.locationsField = value;
  }

  public Company Company
  {
    get => this.companyField;
    set => this.companyField = value;
  }

  public Inspector Inspector
  {
    get => this.inspectorField;
    set => this.inspectorField = value;
  }
}

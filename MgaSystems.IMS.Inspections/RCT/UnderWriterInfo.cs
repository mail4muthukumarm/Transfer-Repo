// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.RCT.UnderWriterInfo
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
public class UnderWriterInfo
{
  private string underWriterUniqueIDField;
  private string contactNumberField;
  private Name nameField;
  private string phoneField;
  private string faxField;
  private string emailField;
  private string noteField;
  private Address addressField;
  private Company companyField;

  public string UnderWriterUniqueID
  {
    get => this.underWriterUniqueIDField;
    set => this.underWriterUniqueIDField = value;
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

  public Company Company
  {
    get => this.companyField;
    set => this.companyField = value;
  }
}

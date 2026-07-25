// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.RCT.CompanyInfo
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
public class CompanyInfo
{
  private string companyUniqueIDField;
  private string companyNumberField;
  private string companyNameField;
  private CompanyInfoType typeField;
  private string phoneField;
  private string faxField;
  private string noteField;
  private string divisionField;
  private Address addressField;

  public string CompanyUniqueID
  {
    get => this.companyUniqueIDField;
    set => this.companyUniqueIDField = value;
  }

  public string CompanyNumber
  {
    get => this.companyNumberField;
    set => this.companyNumberField = value;
  }

  public string CompanyName
  {
    get => this.companyNameField;
    set => this.companyNameField = value;
  }

  public CompanyInfoType Type
  {
    get => this.typeField;
    set => this.typeField = value;
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

  public string Note
  {
    get => this.noteField;
    set => this.noteField = value;
  }

  public string Division
  {
    get => this.divisionField;
    set => this.divisionField = value;
  }

  public Address Address
  {
    get => this.addressField;
    set => this.addressField = value;
  }
}

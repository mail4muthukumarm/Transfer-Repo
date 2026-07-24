// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.RCT.Form
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
public class Form
{
  private string formTemplateUniqueIDField;
  private string inspectionFormInstanceUniqueIDField;
  private string formNameField;
  private string locationNumberField;
  private string descriptionField;
  private Address addressField;
  private string notesField;
  private string oldValueField;
  private string oldValueDescriptionField;
  private string newValueField;
  private string newValueDescriptionField;

  public string FormTemplateUniqueID
  {
    get => this.formTemplateUniqueIDField;
    set => this.formTemplateUniqueIDField = value;
  }

  public string InspectionFormInstanceUniqueID
  {
    get => this.inspectionFormInstanceUniqueIDField;
    set => this.inspectionFormInstanceUniqueIDField = value;
  }

  public string FormName
  {
    get => this.formNameField;
    set => this.formNameField = value;
  }

  public string LocationNumber
  {
    get => this.locationNumberField;
    set => this.locationNumberField = value;
  }

  public string Description
  {
    get => this.descriptionField;
    set => this.descriptionField = value;
  }

  public Address Address
  {
    get => this.addressField;
    set => this.addressField = value;
  }

  public string Notes
  {
    get => this.notesField;
    set => this.notesField = value;
  }

  [XmlElement(DataType = "integer")]
  public string OldValue
  {
    get => this.oldValueField;
    set => this.oldValueField = value;
  }

  [XmlElement(DataType = "integer")]
  public string OldValueDescription
  {
    get => this.oldValueDescriptionField;
    set => this.oldValueDescriptionField = value;
  }

  [XmlElement(DataType = "integer")]
  public string NewValue
  {
    get => this.newValueField;
    set => this.newValueField = value;
  }

  [XmlElement(DataType = "integer")]
  public string NewValueDescription
  {
    get => this.newValueDescriptionField;
    set => this.newValueDescriptionField = value;
  }
}

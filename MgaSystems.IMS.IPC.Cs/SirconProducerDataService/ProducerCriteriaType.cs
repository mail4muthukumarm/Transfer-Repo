// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.ProducerCriteriaType
// Assembly: MgaSystems.IMS.IPC.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 902BD8FA-9BAE-43A4-A4AA-C9585D23F16B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.Cs.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService;

[GeneratedCode("System.Xml", "4.8.4161.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://px.sircon.com/schemas/2006/06/Transaction.xsd")]
[Serializable]
public class ProducerCriteriaType : INotifyPropertyChanged
{
  private EntityType entityTypeField;
  private bool entityTypeFieldSpecified;
  private string nameField;
  private object itemField;
  private ItemChoiceType itemElementNameField;

  [XmlElement(Order = 0)]
  public EntityType EntityType
  {
    get => this.entityTypeField;
    set
    {
      this.entityTypeField = value;
      this.RaisePropertyChanged(nameof (EntityType));
    }
  }

  [XmlIgnore]
  public bool EntityTypeSpecified
  {
    get => this.entityTypeFieldSpecified;
    set
    {
      this.entityTypeFieldSpecified = value;
      this.RaisePropertyChanged(nameof (EntityTypeSpecified));
    }
  }

  [XmlElement(Order = 1)]
  public string Name
  {
    get => this.nameField;
    set
    {
      this.nameField = value;
      this.RaisePropertyChanged(nameof (Name));
    }
  }

  [XmlElement("CustomerId", typeof (ProducerCriteriaTypeCustomerId), Order = 2)]
  [XmlElement("NPN", typeof (string), DataType = "integer", Order = 2)]
  [XmlElement("ProducerId", typeof (int), Order = 2)]
  [XmlElement("TIN", typeof (string), Order = 2)]
  [XmlChoiceIdentifier("ItemElementName")]
  public object Item
  {
    get => this.itemField;
    set
    {
      this.itemField = value;
      this.RaisePropertyChanged(nameof (Item));
    }
  }

  [XmlElement(Order = 3)]
  [XmlIgnore]
  public ItemChoiceType ItemElementName
  {
    get => this.itemElementNameField;
    set
    {
      this.itemElementNameField = value;
      this.RaisePropertyChanged(nameof (ItemElementName));
    }
  }

  public event PropertyChangedEventHandler PropertyChanged;

  protected void RaisePropertyChanged(string propertyName)
  {
    PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
    if (propertyChanged == null)
      return;
    propertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
  }
}

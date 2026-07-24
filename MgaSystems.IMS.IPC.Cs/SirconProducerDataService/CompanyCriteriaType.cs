// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.CompanyCriteriaType
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
public class CompanyCriteriaType : INotifyPropertyChanged
{
  private string itemField;
  private ItemChoiceType1 itemElementNameField;

  [XmlElement("CompanyId", typeof (string), Order = 0)]
  [XmlElement("NaicId", typeof (string), Order = 0)]
  [XmlChoiceIdentifier("ItemElementName")]
  public string Item
  {
    get => this.itemField;
    set
    {
      this.itemField = value;
      this.RaisePropertyChanged(nameof (Item));
    }
  }

  [XmlElement(Order = 1)]
  [XmlIgnore]
  public ItemChoiceType1 ItemElementName
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

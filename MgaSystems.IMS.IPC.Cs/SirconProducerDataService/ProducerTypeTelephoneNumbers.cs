// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.ProducerTypeTelephoneNumbers
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
[XmlType(AnonymousType = true, Namespace = "http://px.sircon.com/schemas/2006/06/Transaction.xsd")]
[Serializable]
public class ProducerTypeTelephoneNumbers : INotifyPropertyChanged
{
  private TelephoneNumberType residentialNumberField;
  private TelephoneNumberType businessNumberField;
  private TelephoneNumberType faxNumberField;
  private TelephoneNumberType cellularNumberField;
  private TelephoneNumberType tollFreeNumberField;

  [XmlElement(Order = 0)]
  public TelephoneNumberType ResidentialNumber
  {
    get => this.residentialNumberField;
    set
    {
      this.residentialNumberField = value;
      this.RaisePropertyChanged(nameof (ResidentialNumber));
    }
  }

  [XmlElement(Order = 1)]
  public TelephoneNumberType BusinessNumber
  {
    get => this.businessNumberField;
    set
    {
      this.businessNumberField = value;
      this.RaisePropertyChanged(nameof (BusinessNumber));
    }
  }

  [XmlElement(Order = 2)]
  public TelephoneNumberType FaxNumber
  {
    get => this.faxNumberField;
    set
    {
      this.faxNumberField = value;
      this.RaisePropertyChanged(nameof (FaxNumber));
    }
  }

  [XmlElement(Order = 3)]
  public TelephoneNumberType CellularNumber
  {
    get => this.cellularNumberField;
    set
    {
      this.cellularNumberField = value;
      this.RaisePropertyChanged(nameof (CellularNumber));
    }
  }

  [XmlElement(Order = 4)]
  public TelephoneNumberType TollFreeNumber
  {
    get => this.tollFreeNumberField;
    set
    {
      this.tollFreeNumberField = value;
      this.RaisePropertyChanged(nameof (TollFreeNumber));
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

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.OrganizationType
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
public class OrganizationType : INotifyPropertyChanged
{
  private string nameField;
  private string eINField;
  private WritingNumberType writingNumberField;
  private IndividualType principalField;
  private OrganizationTypeProducerRating producerRatingField;
  private string nPNField;
  private bool captiveField;
  private bool captiveFieldSpecified;
  private int idField;
  private bool idFieldSpecified;
  private string customerIdField;

  [XmlElement(Order = 0)]
  public string Name
  {
    get => this.nameField;
    set
    {
      this.nameField = value;
      this.RaisePropertyChanged(nameof (Name));
    }
  }

  [XmlElement(Order = 1)]
  public string EIN
  {
    get => this.eINField;
    set
    {
      this.eINField = value;
      this.RaisePropertyChanged(nameof (EIN));
    }
  }

  [XmlElement(Order = 2)]
  public WritingNumberType WritingNumber
  {
    get => this.writingNumberField;
    set
    {
      this.writingNumberField = value;
      this.RaisePropertyChanged(nameof (WritingNumber));
    }
  }

  [XmlElement(Order = 3)]
  public IndividualType Principal
  {
    get => this.principalField;
    set
    {
      this.principalField = value;
      this.RaisePropertyChanged(nameof (Principal));
    }
  }

  [XmlElement(Order = 4)]
  public OrganizationTypeProducerRating ProducerRating
  {
    get => this.producerRatingField;
    set
    {
      this.producerRatingField = value;
      this.RaisePropertyChanged(nameof (ProducerRating));
    }
  }

  [XmlElement(Order = 5)]
  public string NPN
  {
    get => this.nPNField;
    set
    {
      this.nPNField = value;
      this.RaisePropertyChanged(nameof (NPN));
    }
  }

  [XmlElement(Order = 6)]
  public bool Captive
  {
    get => this.captiveField;
    set
    {
      this.captiveField = value;
      this.RaisePropertyChanged(nameof (Captive));
    }
  }

  [XmlIgnore]
  public bool CaptiveSpecified
  {
    get => this.captiveFieldSpecified;
    set
    {
      this.captiveFieldSpecified = value;
      this.RaisePropertyChanged(nameof (CaptiveSpecified));
    }
  }

  [XmlAttribute]
  public int id
  {
    get => this.idField;
    set
    {
      this.idField = value;
      this.RaisePropertyChanged(nameof (id));
    }
  }

  [XmlIgnore]
  public bool idSpecified
  {
    get => this.idFieldSpecified;
    set
    {
      this.idFieldSpecified = value;
      this.RaisePropertyChanged(nameof (idSpecified));
    }
  }

  [XmlAttribute]
  public string customerId
  {
    get => this.customerIdField;
    set
    {
      this.customerIdField = value;
      this.RaisePropertyChanged(nameof (customerId));
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

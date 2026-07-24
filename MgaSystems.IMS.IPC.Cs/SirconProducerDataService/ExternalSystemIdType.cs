// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.ExternalSystemIdType
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
public class ExternalSystemIdType : INotifyPropertyChanged
{
  private CodeType typeField;
  private string externalIdField;
  private bool primaryIndicatorField;
  private bool primaryIndicatorFieldSpecified;
  private bool inactiveIndicatorField;
  private bool inactiveIndicatorFieldSpecified;
  private DateTime createdDateField;
  private bool createdDateFieldSpecified;

  [XmlElement(Order = 0)]
  public CodeType Type
  {
    get => this.typeField;
    set
    {
      this.typeField = value;
      this.RaisePropertyChanged(nameof (Type));
    }
  }

  [XmlElement(Order = 1)]
  public string ExternalId
  {
    get => this.externalIdField;
    set
    {
      this.externalIdField = value;
      this.RaisePropertyChanged(nameof (ExternalId));
    }
  }

  [XmlElement(Order = 2)]
  public bool PrimaryIndicator
  {
    get => this.primaryIndicatorField;
    set
    {
      this.primaryIndicatorField = value;
      this.RaisePropertyChanged(nameof (PrimaryIndicator));
    }
  }

  [XmlIgnore]
  public bool PrimaryIndicatorSpecified
  {
    get => this.primaryIndicatorFieldSpecified;
    set
    {
      this.primaryIndicatorFieldSpecified = value;
      this.RaisePropertyChanged(nameof (PrimaryIndicatorSpecified));
    }
  }

  [XmlElement(Order = 3)]
  public bool InactiveIndicator
  {
    get => this.inactiveIndicatorField;
    set
    {
      this.inactiveIndicatorField = value;
      this.RaisePropertyChanged(nameof (InactiveIndicator));
    }
  }

  [XmlIgnore]
  public bool InactiveIndicatorSpecified
  {
    get => this.inactiveIndicatorFieldSpecified;
    set
    {
      this.inactiveIndicatorFieldSpecified = value;
      this.RaisePropertyChanged(nameof (InactiveIndicatorSpecified));
    }
  }

  [XmlElement(DataType = "date", Order = 4)]
  public DateTime CreatedDate
  {
    get => this.createdDateField;
    set
    {
      this.createdDateField = value;
      this.RaisePropertyChanged(nameof (CreatedDate));
    }
  }

  [XmlIgnore]
  public bool CreatedDateSpecified
  {
    get => this.createdDateFieldSpecified;
    set
    {
      this.createdDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (CreatedDateSpecified));
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

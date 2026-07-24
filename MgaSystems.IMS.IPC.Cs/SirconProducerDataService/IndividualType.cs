// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.IndividualType
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
public class IndividualType : INotifyPropertyChanged
{
  private string titleField;
  private string prefixField;
  private string firstNameField;
  private string middleNameField;
  private string lastNameField;
  private string suffixField;
  private string sSNField;
  private string emailField;
  private DateTime birthDateField;
  private bool birthDateFieldSpecified;
  private WritingNumberType writingNumberField;
  private string fullNameField;
  private IndividualTypeProducerRating producerRatingField;
  private DateTime deceasedDateField;
  private bool deceasedDateFieldSpecified;
  private string nPNField;
  private bool captiveField;
  private bool captiveFieldSpecified;
  private int idField;
  private bool idFieldSpecified;
  private string customerIdField;

  [XmlElement(Order = 0)]
  public string Title
  {
    get => this.titleField;
    set
    {
      this.titleField = value;
      this.RaisePropertyChanged(nameof (Title));
    }
  }

  [XmlElement(Order = 1)]
  public string Prefix
  {
    get => this.prefixField;
    set
    {
      this.prefixField = value;
      this.RaisePropertyChanged(nameof (Prefix));
    }
  }

  [XmlElement(Order = 2)]
  public string FirstName
  {
    get => this.firstNameField;
    set
    {
      this.firstNameField = value;
      this.RaisePropertyChanged(nameof (FirstName));
    }
  }

  [XmlElement(Order = 3)]
  public string MiddleName
  {
    get => this.middleNameField;
    set
    {
      this.middleNameField = value;
      this.RaisePropertyChanged(nameof (MiddleName));
    }
  }

  [XmlElement(Order = 4)]
  public string LastName
  {
    get => this.lastNameField;
    set
    {
      this.lastNameField = value;
      this.RaisePropertyChanged(nameof (LastName));
    }
  }

  [XmlElement(Order = 5)]
  public string Suffix
  {
    get => this.suffixField;
    set
    {
      this.suffixField = value;
      this.RaisePropertyChanged(nameof (Suffix));
    }
  }

  [XmlElement(Order = 6)]
  public string SSN
  {
    get => this.sSNField;
    set
    {
      this.sSNField = value;
      this.RaisePropertyChanged(nameof (SSN));
    }
  }

  [XmlElement(Order = 7)]
  public string Email
  {
    get => this.emailField;
    set
    {
      this.emailField = value;
      this.RaisePropertyChanged(nameof (Email));
    }
  }

  [XmlElement(DataType = "date", Order = 8)]
  public DateTime BirthDate
  {
    get => this.birthDateField;
    set
    {
      this.birthDateField = value;
      this.RaisePropertyChanged(nameof (BirthDate));
    }
  }

  [XmlIgnore]
  public bool BirthDateSpecified
  {
    get => this.birthDateFieldSpecified;
    set
    {
      this.birthDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (BirthDateSpecified));
    }
  }

  [XmlElement(Order = 9)]
  public WritingNumberType WritingNumber
  {
    get => this.writingNumberField;
    set
    {
      this.writingNumberField = value;
      this.RaisePropertyChanged(nameof (WritingNumber));
    }
  }

  [XmlElement(Order = 10)]
  public string FullName
  {
    get => this.fullNameField;
    set
    {
      this.fullNameField = value;
      this.RaisePropertyChanged(nameof (FullName));
    }
  }

  [XmlElement(Order = 11)]
  public IndividualTypeProducerRating ProducerRating
  {
    get => this.producerRatingField;
    set
    {
      this.producerRatingField = value;
      this.RaisePropertyChanged(nameof (ProducerRating));
    }
  }

  [XmlElement(DataType = "date", Order = 12)]
  public DateTime DeceasedDate
  {
    get => this.deceasedDateField;
    set
    {
      this.deceasedDateField = value;
      this.RaisePropertyChanged(nameof (DeceasedDate));
    }
  }

  [XmlIgnore]
  public bool DeceasedDateSpecified
  {
    get => this.deceasedDateFieldSpecified;
    set
    {
      this.deceasedDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (DeceasedDateSpecified));
    }
  }

  [XmlElement(Order = 13)]
  public string NPN
  {
    get => this.nPNField;
    set
    {
      this.nPNField = value;
      this.RaisePropertyChanged(nameof (NPN));
    }
  }

  [XmlElement(Order = 14)]
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

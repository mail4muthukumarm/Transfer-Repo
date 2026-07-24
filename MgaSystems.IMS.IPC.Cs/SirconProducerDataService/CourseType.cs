// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.CourseType
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
public class CourseType : INotifyPropertyChanged
{
  private string numberField;
  private DateTime completionDateField;
  private bool completionDateFieldSpecified;
  private string nameField;
  private Decimal hoursField;
  private bool hoursFieldSpecified;
  private CodeType categoryField;
  private ProviderType providerField;
  private CodeType statusField;
  private int idField;
  private bool idFieldSpecified;

  [XmlElement(Order = 0)]
  public string Number
  {
    get => this.numberField;
    set
    {
      this.numberField = value;
      this.RaisePropertyChanged(nameof (Number));
    }
  }

  [XmlElement(DataType = "date", Order = 1)]
  public DateTime CompletionDate
  {
    get => this.completionDateField;
    set
    {
      this.completionDateField = value;
      this.RaisePropertyChanged(nameof (CompletionDate));
    }
  }

  [XmlIgnore]
  public bool CompletionDateSpecified
  {
    get => this.completionDateFieldSpecified;
    set
    {
      this.completionDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (CompletionDateSpecified));
    }
  }

  [XmlElement(Order = 2)]
  public string Name
  {
    get => this.nameField;
    set
    {
      this.nameField = value;
      this.RaisePropertyChanged(nameof (Name));
    }
  }

  [XmlElement(Order = 3)]
  public Decimal Hours
  {
    get => this.hoursField;
    set
    {
      this.hoursField = value;
      this.RaisePropertyChanged(nameof (Hours));
    }
  }

  [XmlIgnore]
  public bool HoursSpecified
  {
    get => this.hoursFieldSpecified;
    set
    {
      this.hoursFieldSpecified = value;
      this.RaisePropertyChanged(nameof (HoursSpecified));
    }
  }

  [XmlElement(Order = 4)]
  public CodeType Category
  {
    get => this.categoryField;
    set
    {
      this.categoryField = value;
      this.RaisePropertyChanged(nameof (Category));
    }
  }

  [XmlElement(Order = 5)]
  public ProviderType Provider
  {
    get => this.providerField;
    set
    {
      this.providerField = value;
      this.RaisePropertyChanged(nameof (Provider));
    }
  }

  [XmlElement(Order = 6)]
  public CodeType Status
  {
    get => this.statusField;
    set
    {
      this.statusField = value;
      this.RaisePropertyChanged(nameof (Status));
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

  public event PropertyChangedEventHandler PropertyChanged;

  protected void RaisePropertyChanged(string propertyName)
  {
    PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
    if (propertyChanged == null)
      return;
    propertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
  }
}

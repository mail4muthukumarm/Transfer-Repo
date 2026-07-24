// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.EducationCredentialType
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
public class EducationCredentialType : INotifyPropertyChanged
{
  private string nameField;
  private GeneralStatusType statusField;
  private string referenceCodeField;
  private EducationCredentialTypeRegulatoryBody regulatoryBodyField;
  private DateTime startDateField;
  private DateTime endDateField;
  private bool endDateFieldSpecified;

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
  public GeneralStatusType Status
  {
    get => this.statusField;
    set
    {
      this.statusField = value;
      this.RaisePropertyChanged(nameof (Status));
    }
  }

  [XmlElement(Order = 2)]
  public string ReferenceCode
  {
    get => this.referenceCodeField;
    set
    {
      this.referenceCodeField = value;
      this.RaisePropertyChanged(nameof (ReferenceCode));
    }
  }

  [XmlElement(Order = 3)]
  public EducationCredentialTypeRegulatoryBody RegulatoryBody
  {
    get => this.regulatoryBodyField;
    set
    {
      this.regulatoryBodyField = value;
      this.RaisePropertyChanged(nameof (RegulatoryBody));
    }
  }

  [XmlElement(DataType = "date", Order = 4)]
  public DateTime StartDate
  {
    get => this.startDateField;
    set
    {
      this.startDateField = value;
      this.RaisePropertyChanged(nameof (StartDate));
    }
  }

  [XmlElement(DataType = "date", Order = 5)]
  public DateTime EndDate
  {
    get => this.endDateField;
    set
    {
      this.endDateField = value;
      this.RaisePropertyChanged(nameof (EndDate));
    }
  }

  [XmlIgnore]
  public bool EndDateSpecified
  {
    get => this.endDateFieldSpecified;
    set
    {
      this.endDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (EndDateSpecified));
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

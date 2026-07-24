// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.AssociationStateType
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
public class AssociationStateType : INotifyPropertyChanged
{
  private StateCodeType stateField;
  private CodeType associationTypeCodeField;
  private CodeType positionCodeField;
  private DateTime startDateField;
  private DateTime endDateField;
  private bool endDateFieldSpecified;
  private bool stateRegisteredField;

  public AssociationStateType() => this.stateRegisteredField = false;

  [XmlElement(Order = 0)]
  public StateCodeType State
  {
    get => this.stateField;
    set
    {
      this.stateField = value;
      this.RaisePropertyChanged(nameof (State));
    }
  }

  [XmlElement(Order = 1)]
  public CodeType AssociationTypeCode
  {
    get => this.associationTypeCodeField;
    set
    {
      this.associationTypeCodeField = value;
      this.RaisePropertyChanged(nameof (AssociationTypeCode));
    }
  }

  [XmlElement(Order = 2)]
  public CodeType PositionCode
  {
    get => this.positionCodeField;
    set
    {
      this.positionCodeField = value;
      this.RaisePropertyChanged(nameof (PositionCode));
    }
  }

  [XmlElement(DataType = "date", Order = 3)]
  public DateTime StartDate
  {
    get => this.startDateField;
    set
    {
      this.startDateField = value;
      this.RaisePropertyChanged(nameof (StartDate));
    }
  }

  [XmlElement(DataType = "date", Order = 4)]
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

  [XmlAttribute]
  [DefaultValue(false)]
  public bool stateRegistered
  {
    get => this.stateRegisteredField;
    set
    {
      this.stateRegisteredField = value;
      this.RaisePropertyChanged(nameof (stateRegistered));
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

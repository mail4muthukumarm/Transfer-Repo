// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SecuritiesType
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
public class SecuritiesType : INotifyPropertyChanged
{
  private StateRegistrationType[] stateRegistrationsField;
  private SroRegistrationType[] sroRegistrationsField;
  private FinraExamType[] finraExamsField;

  [XmlArray(Order = 0)]
  [XmlArrayItem("StateRegistration", IsNullable = false)]
  public StateRegistrationType[] StateRegistrations
  {
    get => this.stateRegistrationsField;
    set
    {
      this.stateRegistrationsField = value;
      this.RaisePropertyChanged(nameof (StateRegistrations));
    }
  }

  [XmlArray(Order = 1)]
  [XmlArrayItem("SroRegistration", IsNullable = false)]
  public SroRegistrationType[] SroRegistrations
  {
    get => this.sroRegistrationsField;
    set
    {
      this.sroRegistrationsField = value;
      this.RaisePropertyChanged(nameof (SroRegistrations));
    }
  }

  [XmlArray(Order = 2)]
  [XmlArrayItem("FinraExam", IsNullable = false)]
  public FinraExamType[] FinraExams
  {
    get => this.finraExamsField;
    set
    {
      this.finraExamsField = value;
      this.RaisePropertyChanged(nameof (FinraExams));
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

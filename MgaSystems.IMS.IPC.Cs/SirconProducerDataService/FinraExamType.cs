// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.FinraExamType
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
public class FinraExamType : INotifyPropertyChanged
{
  private CodeType examTypeCodeField;
  private CodeType statusCodeField;
  private DateTime statusDateField;
  private bool statusDateFieldSpecified;

  public CodeType ExamTypeCode
  {
    get => this.examTypeCodeField;
    set
    {
      this.examTypeCodeField = value;
      this.RaisePropertyChanged(nameof (ExamTypeCode));
    }
  }

  public CodeType StatusCode
  {
    get => this.statusCodeField;
    set
    {
      this.statusCodeField = value;
      this.RaisePropertyChanged(nameof (StatusCode));
    }
  }

  [XmlElement(DataType = "date")]
  public DateTime StatusDate
  {
    get => this.statusDateField;
    set
    {
      this.statusDateField = value;
      this.RaisePropertyChanged(nameof (StatusDate));
    }
  }

  [XmlIgnore]
  public bool StatusDateSpecified
  {
    get => this.statusDateFieldSpecified;
    set
    {
      this.statusDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (StatusDateSpecified));
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

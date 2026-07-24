// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.ParentAgreementType
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
public class ParentAgreementType : INotifyPropertyChanged
{
  private CodeType levelCodeField;
  private ProducerType producerField;
  private ExternalSystemIdType externalSystemIdField;
  private int orderField;
  private int idField;
  private bool idFieldSpecified;

  [XmlElement(Order = 0)]
  public CodeType LevelCode
  {
    get => this.levelCodeField;
    set
    {
      this.levelCodeField = value;
      this.RaisePropertyChanged(nameof (LevelCode));
    }
  }

  [XmlElement(Order = 1)]
  public ProducerType Producer
  {
    get => this.producerField;
    set
    {
      this.producerField = value;
      this.RaisePropertyChanged(nameof (Producer));
    }
  }

  [XmlElement(Order = 2)]
  public ExternalSystemIdType ExternalSystemId
  {
    get => this.externalSystemIdField;
    set
    {
      this.externalSystemIdField = value;
      this.RaisePropertyChanged(nameof (ExternalSystemId));
    }
  }

  [XmlAttribute]
  public int order
  {
    get => this.orderField;
    set
    {
      this.orderField = value;
      this.RaisePropertyChanged(nameof (order));
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

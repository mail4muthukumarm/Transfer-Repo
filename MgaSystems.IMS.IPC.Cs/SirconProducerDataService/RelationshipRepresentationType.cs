// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.RelationshipRepresentationType
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
public class RelationshipRepresentationType : INotifyPropertyChanged
{
  private GenericResponseType processingStatusField;
  private object itemField;
  private RelationshipRepresentationTypeType typeField;

  [XmlElement(Order = 0)]
  public GenericResponseType ProcessingStatus
  {
    get => this.processingStatusField;
    set
    {
      this.processingStatusField = value;
      this.RaisePropertyChanged(nameof (ProcessingStatus));
    }
  }

  [XmlElement("Agreements", typeof (RelationshipRepresentationTypeAgreements), Order = 1)]
  [XmlElement("Associations", typeof (RelationshipRepresentationTypeAssociations), Order = 1)]
  public object Item
  {
    get => this.itemField;
    set
    {
      this.itemField = value;
      this.RaisePropertyChanged(nameof (Item));
    }
  }

  [XmlAttribute]
  public RelationshipRepresentationTypeType type
  {
    get => this.typeField;
    set
    {
      this.typeField = value;
      this.RaisePropertyChanged(nameof (type));
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

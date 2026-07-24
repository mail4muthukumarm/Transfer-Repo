// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.InactivateLicenseStateResponseStateResponse
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
[XmlType(AnonymousType = true, Namespace = "http://px.sircon.com/schemas/2006/06/Transaction.xsd")]
[Serializable]
public class InactivateLicenseStateResponseStateResponse : INotifyPropertyChanged
{
  private StateCodeType stateField;
  private GenericResponseType processingStatusField;
  private string[] protectedAppointmentTypeField;
  private string[] protectedQualTypeField;

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
  public GenericResponseType ProcessingStatus
  {
    get => this.processingStatusField;
    set
    {
      this.processingStatusField = value;
      this.RaisePropertyChanged(nameof (ProcessingStatus));
    }
  }

  [XmlElement("ProtectedAppointmentType", Order = 2)]
  public string[] ProtectedAppointmentType
  {
    get => this.protectedAppointmentTypeField;
    set
    {
      this.protectedAppointmentTypeField = value;
      this.RaisePropertyChanged(nameof (ProtectedAppointmentType));
    }
  }

  [XmlElement("ProtectedQualType", Order = 3)]
  public string[] ProtectedQualType
  {
    get => this.protectedQualTypeField;
    set
    {
      this.protectedQualTypeField = value;
      this.RaisePropertyChanged(nameof (ProtectedQualType));
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

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.AvailableAppointmentProfilesRequest
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
public class AvailableAppointmentProfilesRequest : INotifyPropertyChanged
{
  private EntityType entityTypeField;
  private StateCodeType[] statesField;
  private bool includeAppointmentsField;
  private bool includeAppointmentsFieldSpecified;

  [XmlElement(Order = 0)]
  public EntityType EntityType
  {
    get => this.entityTypeField;
    set
    {
      this.entityTypeField = value;
      this.RaisePropertyChanged(nameof (EntityType));
    }
  }

  [XmlArray(Order = 1)]
  [XmlArrayItem("StateCode", IsNullable = false)]
  public StateCodeType[] States
  {
    get => this.statesField;
    set
    {
      this.statesField = value;
      this.RaisePropertyChanged(nameof (States));
    }
  }

  [XmlAttribute]
  public bool includeAppointments
  {
    get => this.includeAppointmentsField;
    set
    {
      this.includeAppointmentsField = value;
      this.RaisePropertyChanged(nameof (includeAppointments));
    }
  }

  [XmlIgnore]
  public bool includeAppointmentsSpecified
  {
    get => this.includeAppointmentsFieldSpecified;
    set
    {
      this.includeAppointmentsFieldSpecified = value;
      this.RaisePropertyChanged(nameof (includeAppointmentsSpecified));
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

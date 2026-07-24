// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.BuildPotentialTerminationsRequest
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
public class BuildPotentialTerminationsRequest : INotifyPropertyChanged
{
  private EntityType entityTypeField;
  private int producerIdField;
  private StateCodeType[] statesField;
  private CompanyType[] companiesField;
  private AppointmentProfileType[] appointmentProfilesField;

  public EntityType EntityType
  {
    get => this.entityTypeField;
    set
    {
      this.entityTypeField = value;
      this.RaisePropertyChanged(nameof (EntityType));
    }
  }

  public int ProducerId
  {
    get => this.producerIdField;
    set
    {
      this.producerIdField = value;
      this.RaisePropertyChanged(nameof (ProducerId));
    }
  }

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

  [XmlArrayItem("Company", IsNullable = false)]
  public CompanyType[] Companies
  {
    get => this.companiesField;
    set
    {
      this.companiesField = value;
      this.RaisePropertyChanged(nameof (Companies));
    }
  }

  [XmlArrayItem("AppointmentProfile", IsNullable = false)]
  public AppointmentProfileType[] AppointmentProfiles
  {
    get => this.appointmentProfilesField;
    set
    {
      this.appointmentProfilesField = value;
      this.RaisePropertyChanged(nameof (AppointmentProfiles));
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

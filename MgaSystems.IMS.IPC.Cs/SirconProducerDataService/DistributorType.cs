// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.DistributorType
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
public class DistributorType : INotifyPropertyChanged
{
  private IndividualType contactField;
  private string doingBusinessAsField;
  private string childDistributorIdRefField;
  private string nameField;
  private string eINField;
  private string roleField;
  private string idField;

  [XmlElement(Order = 0)]
  public IndividualType Contact
  {
    get => this.contactField;
    set
    {
      this.contactField = value;
      this.RaisePropertyChanged(nameof (Contact));
    }
  }

  [XmlElement(Order = 1)]
  public string DoingBusinessAs
  {
    get => this.doingBusinessAsField;
    set
    {
      this.doingBusinessAsField = value;
      this.RaisePropertyChanged(nameof (DoingBusinessAs));
    }
  }

  [XmlElement(Order = 2)]
  public string ChildDistributorIdRef
  {
    get => this.childDistributorIdRefField;
    set
    {
      this.childDistributorIdRefField = value;
      this.RaisePropertyChanged(nameof (ChildDistributorIdRef));
    }
  }

  [XmlElement(Order = 3)]
  public string Name
  {
    get => this.nameField;
    set
    {
      this.nameField = value;
      this.RaisePropertyChanged(nameof (Name));
    }
  }

  [XmlElement(Order = 4)]
  public string EIN
  {
    get => this.eINField;
    set
    {
      this.eINField = value;
      this.RaisePropertyChanged(nameof (EIN));
    }
  }

  [XmlElement(Order = 5)]
  public string Role
  {
    get => this.roleField;
    set
    {
      this.roleField = value;
      this.RaisePropertyChanged(nameof (Role));
    }
  }

  [XmlAttribute]
  public string id
  {
    get => this.idField;
    set
    {
      this.idField = value;
      this.RaisePropertyChanged(nameof (id));
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

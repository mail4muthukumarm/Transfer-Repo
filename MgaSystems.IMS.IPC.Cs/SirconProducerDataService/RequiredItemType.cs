// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.RequiredItemType
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
public class RequiredItemType : INotifyPropertyChanged
{
  private CodeType typeCodeField;
  private CodeType statusCodeField;
  private StateCodeType stateCodeField;
  private bool stateCodeFieldSpecified;
  private DateTime requestedDateField;
  private bool requestedDateFieldSpecified;
  private DateTime receivedDateField;
  private bool receivedDateFieldSpecified;
  private DateTime followUpDateField;
  private bool followUpDateFieldSpecified;
  private string businessUnitField;
  private string otherIdentifierField;
  private string commentField;
  private int idField;
  private bool idFieldSpecified;

  [XmlElement(Order = 0)]
  public CodeType TypeCode
  {
    get => this.typeCodeField;
    set
    {
      this.typeCodeField = value;
      this.RaisePropertyChanged(nameof (TypeCode));
    }
  }

  [XmlElement(Order = 1)]
  public CodeType StatusCode
  {
    get => this.statusCodeField;
    set
    {
      this.statusCodeField = value;
      this.RaisePropertyChanged(nameof (StatusCode));
    }
  }

  [XmlElement(Order = 2)]
  public StateCodeType StateCode
  {
    get => this.stateCodeField;
    set
    {
      this.stateCodeField = value;
      this.RaisePropertyChanged(nameof (StateCode));
    }
  }

  [XmlIgnore]
  public bool StateCodeSpecified
  {
    get => this.stateCodeFieldSpecified;
    set
    {
      this.stateCodeFieldSpecified = value;
      this.RaisePropertyChanged(nameof (StateCodeSpecified));
    }
  }

  [XmlElement(DataType = "date", Order = 3)]
  public DateTime RequestedDate
  {
    get => this.requestedDateField;
    set
    {
      this.requestedDateField = value;
      this.RaisePropertyChanged(nameof (RequestedDate));
    }
  }

  [XmlIgnore]
  public bool RequestedDateSpecified
  {
    get => this.requestedDateFieldSpecified;
    set
    {
      this.requestedDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (RequestedDateSpecified));
    }
  }

  [XmlElement(DataType = "date", Order = 4)]
  public DateTime ReceivedDate
  {
    get => this.receivedDateField;
    set
    {
      this.receivedDateField = value;
      this.RaisePropertyChanged(nameof (ReceivedDate));
    }
  }

  [XmlIgnore]
  public bool ReceivedDateSpecified
  {
    get => this.receivedDateFieldSpecified;
    set
    {
      this.receivedDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (ReceivedDateSpecified));
    }
  }

  [XmlElement(DataType = "date", Order = 5)]
  public DateTime FollowUpDate
  {
    get => this.followUpDateField;
    set
    {
      this.followUpDateField = value;
      this.RaisePropertyChanged(nameof (FollowUpDate));
    }
  }

  [XmlIgnore]
  public bool FollowUpDateSpecified
  {
    get => this.followUpDateFieldSpecified;
    set
    {
      this.followUpDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (FollowUpDateSpecified));
    }
  }

  [XmlElement(Order = 6)]
  public string BusinessUnit
  {
    get => this.businessUnitField;
    set
    {
      this.businessUnitField = value;
      this.RaisePropertyChanged(nameof (BusinessUnit));
    }
  }

  [XmlElement(Order = 7)]
  public string OtherIdentifier
  {
    get => this.otherIdentifierField;
    set
    {
      this.otherIdentifierField = value;
      this.RaisePropertyChanged(nameof (OtherIdentifier));
    }
  }

  [XmlElement(Order = 8)]
  public string Comment
  {
    get => this.commentField;
    set
    {
      this.commentField = value;
      this.RaisePropertyChanged(nameof (Comment));
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

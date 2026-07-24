// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.AddressType
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
public class AddressType : INotifyPropertyChanged
{
  private CodeType typeField;
  private string lineOneField;
  private string lineTwoField;
  private string lineThreeField;
  private string lineFourField;
  private string cityField;
  private StateCodeType stateField;
  private string countyField;
  private string postalCodeField;
  private bool invalidAddressField;
  private bool invalidAddressFieldSpecified;

  public CodeType Type
  {
    get => this.typeField;
    set
    {
      this.typeField = value;
      this.RaisePropertyChanged(nameof (Type));
    }
  }

  public string LineOne
  {
    get => this.lineOneField;
    set
    {
      this.lineOneField = value;
      this.RaisePropertyChanged(nameof (LineOne));
    }
  }

  public string LineTwo
  {
    get => this.lineTwoField;
    set
    {
      this.lineTwoField = value;
      this.RaisePropertyChanged(nameof (LineTwo));
    }
  }

  public string LineThree
  {
    get => this.lineThreeField;
    set
    {
      this.lineThreeField = value;
      this.RaisePropertyChanged(nameof (LineThree));
    }
  }

  public string LineFour
  {
    get => this.lineFourField;
    set
    {
      this.lineFourField = value;
      this.RaisePropertyChanged(nameof (LineFour));
    }
  }

  public string City
  {
    get => this.cityField;
    set
    {
      this.cityField = value;
      this.RaisePropertyChanged(nameof (City));
    }
  }

  public StateCodeType State
  {
    get => this.stateField;
    set
    {
      this.stateField = value;
      this.RaisePropertyChanged(nameof (State));
    }
  }

  public string County
  {
    get => this.countyField;
    set
    {
      this.countyField = value;
      this.RaisePropertyChanged(nameof (County));
    }
  }

  public string PostalCode
  {
    get => this.postalCodeField;
    set
    {
      this.postalCodeField = value;
      this.RaisePropertyChanged(nameof (PostalCode));
    }
  }

  [XmlAttribute]
  public bool invalidAddress
  {
    get => this.invalidAddressField;
    set
    {
      this.invalidAddressField = value;
      this.RaisePropertyChanged(nameof (invalidAddress));
    }
  }

  [XmlIgnore]
  public bool invalidAddressSpecified
  {
    get => this.invalidAddressFieldSpecified;
    set
    {
      this.invalidAddressFieldSpecified = value;
      this.RaisePropertyChanged(nameof (invalidAddressSpecified));
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

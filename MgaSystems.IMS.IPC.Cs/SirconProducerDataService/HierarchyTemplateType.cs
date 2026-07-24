// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.HierarchyTemplateType
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
public class HierarchyTemplateType : INotifyPropertyChanged
{
  private string nameField;
  private string descriptionField;
  private CodeType baseRoleCodeField;

  [XmlElement(Order = 0)]
  public string Name
  {
    get => this.nameField;
    set
    {
      this.nameField = value;
      this.RaisePropertyChanged(nameof (Name));
    }
  }

  [XmlElement(Order = 1)]
  public string Description
  {
    get => this.descriptionField;
    set
    {
      this.descriptionField = value;
      this.RaisePropertyChanged(nameof (Description));
    }
  }

  [XmlElement(Order = 2)]
  public CodeType BaseRoleCode
  {
    get => this.baseRoleCodeField;
    set
    {
      this.baseRoleCodeField = value;
      this.RaisePropertyChanged(nameof (BaseRoleCode));
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

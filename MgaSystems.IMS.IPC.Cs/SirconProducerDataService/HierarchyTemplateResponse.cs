// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.HierarchyTemplateResponse
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
public class HierarchyTemplateResponse : INotifyPropertyChanged
{
  private GenericResponseType genericResponseField;
  private HierarchyTemplateType[] hierarchyTemplatesField;
  private AgreementType[] potentialParentAgreementsField;

  [XmlElement(Order = 0)]
  public GenericResponseType GenericResponse
  {
    get => this.genericResponseField;
    set
    {
      this.genericResponseField = value;
      this.RaisePropertyChanged(nameof (GenericResponse));
    }
  }

  [XmlArray(Order = 1)]
  [XmlArrayItem("HierarchyTemplate", IsNullable = false)]
  public HierarchyTemplateType[] HierarchyTemplates
  {
    get => this.hierarchyTemplatesField;
    set
    {
      this.hierarchyTemplatesField = value;
      this.RaisePropertyChanged(nameof (HierarchyTemplates));
    }
  }

  [XmlArray(Order = 2)]
  [XmlArrayItem("Agreement", IsNullable = false)]
  public AgreementType[] PotentialParentAgreements
  {
    get => this.potentialParentAgreementsField;
    set
    {
      this.potentialParentAgreementsField = value;
      this.RaisePropertyChanged(nameof (PotentialParentAgreements));
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

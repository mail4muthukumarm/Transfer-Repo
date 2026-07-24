// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.CourseRequirementType
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
public class CourseRequirementType : INotifyPropertyChanged
{
  private CodeType typeField;
  private StateCodeType stateField;
  private bool stateFieldSpecified;
  private DateTime assignedReviewDateField;
  private bool assignedReviewDateFieldSpecified;
  private Decimal requiredHoursField;
  private bool requiredHoursFieldSpecified;
  private Decimal appliedHoursField;
  private bool appliedHoursFieldSpecified;
  private CodeType statusField;
  private DateTime statusDateField;
  private bool statusDateFieldSpecified;
  private CourseRequirementTypeAppliedCourses appliedCoursesField;

  [XmlElement(Order = 0)]
  public CodeType Type
  {
    get => this.typeField;
    set
    {
      this.typeField = value;
      this.RaisePropertyChanged(nameof (Type));
    }
  }

  [XmlElement(Order = 1)]
  public StateCodeType State
  {
    get => this.stateField;
    set
    {
      this.stateField = value;
      this.RaisePropertyChanged(nameof (State));
    }
  }

  [XmlIgnore]
  public bool StateSpecified
  {
    get => this.stateFieldSpecified;
    set
    {
      this.stateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (StateSpecified));
    }
  }

  [XmlElement(DataType = "date", Order = 2)]
  public DateTime AssignedReviewDate
  {
    get => this.assignedReviewDateField;
    set
    {
      this.assignedReviewDateField = value;
      this.RaisePropertyChanged(nameof (AssignedReviewDate));
    }
  }

  [XmlIgnore]
  public bool AssignedReviewDateSpecified
  {
    get => this.assignedReviewDateFieldSpecified;
    set
    {
      this.assignedReviewDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (AssignedReviewDateSpecified));
    }
  }

  [XmlElement(Order = 3)]
  public Decimal RequiredHours
  {
    get => this.requiredHoursField;
    set
    {
      this.requiredHoursField = value;
      this.RaisePropertyChanged(nameof (RequiredHours));
    }
  }

  [XmlIgnore]
  public bool RequiredHoursSpecified
  {
    get => this.requiredHoursFieldSpecified;
    set
    {
      this.requiredHoursFieldSpecified = value;
      this.RaisePropertyChanged(nameof (RequiredHoursSpecified));
    }
  }

  [XmlElement(Order = 4)]
  public Decimal AppliedHours
  {
    get => this.appliedHoursField;
    set
    {
      this.appliedHoursField = value;
      this.RaisePropertyChanged(nameof (AppliedHours));
    }
  }

  [XmlIgnore]
  public bool AppliedHoursSpecified
  {
    get => this.appliedHoursFieldSpecified;
    set
    {
      this.appliedHoursFieldSpecified = value;
      this.RaisePropertyChanged(nameof (AppliedHoursSpecified));
    }
  }

  [XmlElement(Order = 5)]
  public CodeType Status
  {
    get => this.statusField;
    set
    {
      this.statusField = value;
      this.RaisePropertyChanged(nameof (Status));
    }
  }

  [XmlElement(DataType = "date", Order = 6)]
  public DateTime StatusDate
  {
    get => this.statusDateField;
    set
    {
      this.statusDateField = value;
      this.RaisePropertyChanged(nameof (StatusDate));
    }
  }

  [XmlIgnore]
  public bool StatusDateSpecified
  {
    get => this.statusDateFieldSpecified;
    set
    {
      this.statusDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (StatusDateSpecified));
    }
  }

  [XmlElement(Order = 7)]
  public CourseRequirementTypeAppliedCourses AppliedCourses
  {
    get => this.appliedCoursesField;
    set
    {
      this.appliedCoursesField = value;
      this.RaisePropertyChanged(nameof (AppliedCourses));
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

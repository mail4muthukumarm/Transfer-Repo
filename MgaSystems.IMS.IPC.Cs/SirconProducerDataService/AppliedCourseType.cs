// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.AppliedCourseType
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
public class AppliedCourseType : INotifyPropertyChanged
{
  private Decimal appliedHoursField;
  private Decimal ineligibleHoursField;
  private Decimal carryForwardHoursField;
  private DateTime carryForwardReviewDateField;
  private bool carryForwardReviewDateFieldSpecified;
  private CourseType courseField;

  [XmlElement(Order = 0)]
  public Decimal AppliedHours
  {
    get => this.appliedHoursField;
    set
    {
      this.appliedHoursField = value;
      this.RaisePropertyChanged(nameof (AppliedHours));
    }
  }

  [XmlElement(Order = 1)]
  public Decimal IneligibleHours
  {
    get => this.ineligibleHoursField;
    set
    {
      this.ineligibleHoursField = value;
      this.RaisePropertyChanged(nameof (IneligibleHours));
    }
  }

  [XmlElement(Order = 2)]
  public Decimal CarryForwardHours
  {
    get => this.carryForwardHoursField;
    set
    {
      this.carryForwardHoursField = value;
      this.RaisePropertyChanged(nameof (CarryForwardHours));
    }
  }

  [XmlElement(DataType = "date", Order = 3)]
  public DateTime CarryForwardReviewDate
  {
    get => this.carryForwardReviewDateField;
    set
    {
      this.carryForwardReviewDateField = value;
      this.RaisePropertyChanged(nameof (CarryForwardReviewDate));
    }
  }

  [XmlIgnore]
  public bool CarryForwardReviewDateSpecified
  {
    get => this.carryForwardReviewDateFieldSpecified;
    set
    {
      this.carryForwardReviewDateFieldSpecified = value;
      this.RaisePropertyChanged(nameof (CarryForwardReviewDateSpecified));
    }
  }

  [XmlElement(Order = 4)]
  public CourseType Course
  {
    get => this.courseField;
    set
    {
      this.courseField = value;
      this.RaisePropertyChanged(nameof (Course));
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

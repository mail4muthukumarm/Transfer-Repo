// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.AutomationReports.AutomationReportAttribute
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Reporting.AutomationReports;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class AutomationReportAttribute : Attribute
{
  private Guid _automationReportGuid;
  private Enums.AutomationDocGroups _group;
  private string _title;
  private string _description;

  public string Description => this._description;

  public string Title => this._title;

  public Guid AutomationReportGuid => this._automationReportGuid;

  public Enums.AutomationDocGroups Group => this._group;

  [EditorBrowsable(EditorBrowsableState.Never)]
  public AutomationReportAttribute()
  {
  }

  public AutomationReportAttribute(
    string automationReportGuid,
    Enums.AutomationDocGroups group,
    string title,
    string description)
  {
    this._automationReportGuid = new Guid(automationReportGuid);
    this._group = group;
    this._title = title;
    this._description = description;
  }

  public override bool Match(object obj) => obj is AutomationReportAttribute;
}

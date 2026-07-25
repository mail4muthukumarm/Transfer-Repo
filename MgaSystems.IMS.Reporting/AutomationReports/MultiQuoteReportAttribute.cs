// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.AutomationReports.MultiQuoteReportAttribute
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

#nullable disable
namespace MGASystems.IMS.Reporting.AutomationReports;

public class MultiQuoteReportAttribute : AutomationReportAttribute
{
  public MultiQuoteReportAttribute(
    string automationReportGuid,
    Enums.AutomationDocGroups group,
    string title,
    string description)
    : base(automationReportGuid, group, title, description)
  {
  }

  public MultiQuoteReportAttribute()
  {
  }
}

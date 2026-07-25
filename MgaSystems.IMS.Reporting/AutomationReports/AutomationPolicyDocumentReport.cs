// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.AutomationReports.AutomationPolicyDocumentReport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using System;

#nullable disable
namespace MGASystems.IMS.Reporting.AutomationReports;

public class AutomationPolicyDocumentReport : SectionReport, IQuoteDocument, IStateSpecific
{
  private Guid _quoteOptionGuid;
  private int _placedByCompanyLineID;

  public bool RequiresQuoteOptionGuids() => true;

  public void SetQuoteOptionGuids(Guid[] quoteOptionGuids)
  {
    this._quoteOptionGuid = quoteOptionGuids[0];
  }

  public void SetPlacedByCompanyLineID(int companyLineID)
  {
    this._placedByCompanyLineID = companyLineID;
  }
}

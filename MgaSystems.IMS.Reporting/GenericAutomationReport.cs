// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.GenericAutomationReport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using MGASystems.IMS.Reporting.AutomationReports;
using MGASystems.IMS.Reporting.GenericReport;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public abstract class GenericAutomationReport : MGASystems.IMS.Reporting.GenericReport.GenericReport, IQuoteDocument
{
  private readonly object _automationContext;
  private ReadOnlyCollection<Guid> _quoteOptionGuids;

  protected object AutomationContext => this._automationContext;

  public GenericAutomationReport(object automationContext)
  {
    this._automationContext = RuntimeHelpers.GetObjectValue(automationContext);
  }

  public GenericAutomationReport()
  {
  }

  public virtual bool RequiresQuoteOptionGuids => false;

  bool IQuoteDocument.RequiresQuoteOptionGuidsInternal() => this.RequiresQuoteOptionGuids;

  protected ReadOnlyCollection<Guid> QuoteOptionGuids
  {
    get
    {
      if (!this.RequiresQuoteOptionGuids)
        throw new InvalidOperationException("To access QuoteOptionGuids, you must override RequiresQuoteOptionGuids and return true");
      return this._quoteOptionGuids;
    }
  }

  void IQuoteDocument.SetQuoteOptionGuids(Guid[] quoteOptionGuids)
  {
    this._quoteOptionGuids = new ReadOnlyCollection<Guid>((IList<Guid>) new List<Guid>((IEnumerable<Guid>) quoteOptionGuids));
  }

  protected override RunCompletedResult OnRun(object runContext)
  {
    return base.OnRun(RuntimeHelpers.GetObjectValue(this.AutomationContext));
  }
}

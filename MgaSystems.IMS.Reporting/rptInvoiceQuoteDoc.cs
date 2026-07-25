// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptInvoiceQuoteDoc
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Reporting.AutomationReports;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[AutomationReport("{9EA57343-8AB4-48f6-84A6-2FC5D1D75790}", Enums.AutomationDocGroups.PolicyDoc, "Invoice Listing", "Quote document that displays all non-void invoices for the policy.")]
public class rptInvoiceQuoteDoc : MGAReport, IQuoteDocument
{
  private Guid _QuoteGuid;

  public rptInvoiceQuoteDoc(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptInvoiceQuoteDoc_ReportStart);
    this.ReportEnd += new EventHandler(this.rptInvoiceQuoteDoc_ReportEnd);
    this.InitializeComponent();
    this._QuoteGuid = QuoteGuid;
  }

  private void InitializeComponent()
  {
    this.Detail = new Detail();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Height = 0.0f;
    ((Section) this.Detail).Name = "Detail";
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.Sections.Add((Section) this.Detail);
  }

  private void rptInvoiceQuoteDoc_ReportStart(object sender, EventArgs e)
  {
    if (SystemSettings.KeyExists("Report.InvoiceListing.HidePrintDateAndTime") && SystemSettings.GetBoolSetting("Report.InvoiceListing.HidePrintDateAndTime"))
      this.HidePrintDateAndTime();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT tblFin_Invoices.InvoiceNum FROM tblQuotes INNER JOIN tblFin_Invoices ON tblQuotes.QuoteID = tblFin_Invoices.QuoteID WHERE tblQuotes.QuoteGUID = @QG AND tblFin_Invoices.Failed = 0", new object[2]
    {
      (object) "@QG",
      (object) this._QuoteGuid
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
        this.Document.Pages.AddRange(new Invoice(Conversions.ToInteger(row["InvoiceNum"])).Report().Document.Pages);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void rptInvoiceQuoteDoc_ReportEnd(object sender, EventArgs e)
  {
    if (this.Document.Pages.Count <= 0)
      return;
    this.Document.Pages.RemoveAt(this.Document.Pages.Count - 1);
  }

  public bool RequiresQuoteOptionGuids() => false;

  public void SetQuoteOptionGuids(Guid[] quoteOptionGuids)
  {
  }

  public override bool HasRecords => true;

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}

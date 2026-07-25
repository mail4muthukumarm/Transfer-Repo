// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptDownPaymentInvoice
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.BusinessObjects;
using MGASystems.Data;
using MGASystems.IMS.Reporting.AutomationReports;
using System;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[AutomationReport("{5E286DA8-B2DC-4580-9A5C-313EBFBC635E}", Enums.AutomationDocGroups.PolicyDoc, "Down Payment Invoice", "Displays the downpayment invoice for the quote.")]
public class rptDownPaymentInvoice : SectionReport, IQuoteDocument
{
  private Guid _QuoteGuid;

  public rptDownPaymentInvoice(Guid quoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptDownPaymentInvoice_ReportStart);
    this.ReportEnd += new EventHandler(this.rptDownPaymentInvoice_ReportEnd);
    this.InitializeComponent();
    this._QuoteGuid = quoteGuid;
  }

  private void rptDownPaymentInvoice_ReportStart(object sender, EventArgs e)
  {
    int invoiceNum = DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT dbo.GetDownPaymentInvoiceNumber(QuoteID) FROM dbo.tblQuotes WITH(NOLOCK) WHERE QuoteGuid = @QG", new object[2]
    {
      (object) "@QG",
      (object) this._QuoteGuid
    }) ?? -1;
    if (invoiceNum == -1)
      return;
    this.Document.Pages.AddRange(new Invoice(invoiceNum).Report().Document.Pages);
  }

  private void rptDownPaymentInvoice_ReportEnd(object sender, EventArgs e)
  {
    if (this.Document.Pages.Count <= 0)
      return;
    this.Document.Pages.RemoveAt(this.Document.Pages.Count - 1);
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

  public bool RequiresQuoteOptionGuids() => false;

  public void SetQuoteOptionGuids(Guid[] quoteOptionGuids)
  {
  }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}

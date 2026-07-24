// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.PolicyServicesInstance
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using CancellationNotices;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Services.Forms;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.Reporting;
using System;
using System.Data;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services;

public class PolicyServicesInstance
{
  private DateTime _effectiveDate;
  private DateTime _printDate;

  public DateTime EffectiveDate
  {
    get => this._effectiveDate;
    set => this._effectiveDate = value;
  }

  public DateTime PrintDate
  {
    get => this._printDate;
    set => this._printDate = value;
  }

  public virtual void ReinstatePolicy(
    int quoteId,
    DateTime printDate,
    DateTime reinstatementEffective,
    bool printNotice,
    bool printEnvelopes,
    bool addToDocumentHandler,
    string envelopePrinterName,
    string envelopePrinterTray,
    bool runThreaded = true)
  {
    using (SectionReport report = this.CreateReport(quoteId, (object) printDate, (object) reinstatementEffective))
    {
      if (addToDocumentHandler)
        this.AddToDocumentHandler(quoteId, report, runThreaded);
      if (printNotice)
        PrintExtension.Print(report.Document, false, false, false);
      if (printEnvelopes)
        this.PrintEnvelopes(envelopePrinterName, envelopePrinterTray, (DataTable) report.DataSource);
    }
    this.WriteReinstateQuoteForID(quoteId);
  }

  public virtual void ReinstatePolicy(int quoteId, int controlNumber, bool runThreaded = false)
  {
    DateTime fromControlNumber = this.GetReinstatementEffectiveDateFromControlNumber(controlNumber);
    using (SectionReport report = this.CreateReport(quoteId, (object) DateTime.Now, (object) fromControlNumber))
      this.AddToDocumentHandler(quoteId, report, runThreaded);
    this.WriteReinstateQuoteForID(quoteId);
  }

  public virtual void ReinstatePolicy(
    int quoteId,
    bool isReprint,
    Type reportType,
    bool runThreaded = true)
  {
    using (SectionReport userEnteredDates = this.CreateReportFromUserEnteredDates(quoteId, reportType))
    {
      if (this.AskPrintDocument())
        PrintExtension.Print(userEnteredDates.Document, false, false, false);
      if (isReprint)
      {
        if (this.AskAddReprintToDocumentHandler())
          this.AddToDocumentHandler(quoteId, userEnteredDates, runThreaded);
      }
      else
        this.AddToDocumentHandler(quoteId, userEnteredDates, runThreaded);
      if (this.AskPrintEnvelopes())
      {
        (string, string) tuple = this.ShowEnvolopePrinterDialog();
        this.PrintEnvelopes(tuple.Item1, tuple.Item2, (DataTable) userEnteredDates.DataSource);
      }
    }
    if (isReprint)
      return;
    this.WriteReinstateQuoteForID(quoteId);
  }

  public virtual void ReinstatePolicyFromControlNumber(int controlNumber)
  {
    this.ReinstatePolicy(Quote.FromControlNo(controlNumber).QuoteID, controlNumber);
  }

  public virtual void ReinstatePolicy(int quoteId) => this.ReinstatePolicy(quoteId, false);

  public virtual void ReinstatePolicy(Quote quoteObject, bool isReprint)
  {
    this.ReinstatePolicy(quoteObject, isReprint, typeof (rptReinstatementNotice));
  }

  public virtual void ReinstatePolicy(int quoteId, bool isReprint)
  {
    this.ReinstatePolicy(quoteId, isReprint, typeof (rptReinstatementNotice));
  }

  public virtual void ReinstatePolicy(Quote quoteObject, bool isReprint, Type reportType)
  {
    this._effectiveDate = this.GetReinstatementEffectiveDateFromQuote(quoteObject);
    this._printDate = DateTime.Now;
    this.ReinstatePolicy(Quote.FromControlNo(quoteObject.ControlNo).QuoteID, isReprint, reportType);
  }

  public bool IsUnderNotice(int InvoiceNumber)
  {
    return DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "Select dbo.AccountingIsUnderNotice(@inv)", new object[2]
    {
      (object) "@inv",
      (object) InvoiceNumber
    });
  }

  public void DeletePolicyInquiryComment(int commentId)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_DeletePolicyInquiryComment", new object[2]
    {
      (object) "@commentId",
      (object) commentId
    });
  }

  public int GetManualCancellationEffectiveDays(int controlNumber)
  {
    return DefaultDatabase.ExecuteScalar<int>("spFin_GetManualCancellation_EffectiveDays", new object[2]
    {
      (object) "@controlNumber",
      (object) controlNumber
    });
  }

  public DataSet GetPolicyReinstatementInvoicesNOC(
    int quoteId,
    DateTime issuanceDate,
    int transactionNumber)
  {
    return DefaultDatabase.ExecuteDataSet("spFin_GetReinstatementInvoicesNOC", new object[6]
    {
      (object) "@quoteId",
      (object) quoteId,
      (object) "@NOCIssuanceDate",
      (object) issuanceDate,
      (object) "@transactNum",
      (object) transactionNumber
    });
  }

  public DataSet GetPolicyReinstatementInvoices(
    int quoteId,
    DateTime issuanceDate,
    int transactionNumber)
  {
    return DefaultDatabase.ExecuteDataSet("spFin_GetReinstatementInvoices", new object[6]
    {
      (object) "@quoteId",
      (object) quoteId,
      (object) "@NOCIssuanceDate",
      (object) issuanceDate,
      (object) "@transactNum",
      (object) transactionNumber
    });
  }

  public void LogPolicyReinstatementDates(
    int controlNumber,
    DateTime ReinstatementDate,
    DateTime EffectiveDate)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spFin_LogPolicyReinstatement", new object[6]
    {
      (object) "@controlNumber",
      (object) controlNumber,
      (object) "@reinstatementDate",
      (object) ReinstatementDate,
      (object) "@reinstatementEffective",
      (object) EffectiveDate
    });
  }

  public DateTime GetReinstatementEffectiveDateFromQuote(Quote quoteObject)
  {
    return this.GetReinstatementEffectiveDateFromControlNumber(quoteObject.ControlNo);
  }

  public DateTime GetReinstatementEffectiveDateFromControlNumber(int controlNumber)
  {
    return DefaultDatabase.ExecuteScalar<DateTime?>("dbo.GetReinstatementEffectiveDate", new object[2]
    {
      (object) "@quoteId",
      (object) Quote.FromControlNo(controlNumber).QuoteID
    }) ?? DateTime.Now;
  }

  public void WriteReinstateQuoteForID(int quoteID)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_ReinstateQuote", new object[2]
    {
      (object) "@quoteId",
      (object) quoteID
    });
    CurrentUser.Instance.LogAction($"Reinstated Quote Id #{quoteID}", "Accounting Logs");
  }

  protected bool AskOverrideDates()
  {
    return MessageBox.Show("Do you want to override the printing and effective date?", "Override Dates", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
  }

  protected bool AskPrintDocument()
  {
    return MessageBox.Show("Do you wish to print the reinstatement notice?", "Print Document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
  }

  protected bool AskAddReprintToDocumentHandler()
  {
    return MessageBox.Show("Do you wish to add the newly print reinstatement notice to the document handler?", "Add Document To Document Handler?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
  }

  protected bool AskPrintEnvelopes()
  {
    return MessageBox.Show("Print envelopes?", "Print Cancellation Envelopes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
  }

  public void LaunchFormPolicyDetails(int controlNumber)
  {
    Form form = ObjectFactory.Instance.CreateForm(ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail"), new object[1]
    {
      (object) controlNumber
    });
    form.MdiParent = MDIControls.Instance.MDIParent;
    form.Show();
  }

  protected (string, string) ShowEnvolopePrinterDialog()
  {
    string str1 = string.Empty;
    string str2 = string.Empty;
    using (PrintDialog printDialog = new PrintDialog())
    {
      using (PrintDocument printDocument = new PrintDocument())
      {
        printDocument.DocumentName = "Notice Of Cancellation Envelopes";
        printDialog.Document = printDocument;
        printDialog.AllowPrintToFile = false;
        printDialog.AllowSelection = true;
        if (printDialog.ShowDialog() == DialogResult.OK)
        {
          str1 = printDialog.PrinterSettings.PrinterName;
          str2 = printDialog.Document.DefaultPageSettings.PaperSource.SourceName;
        }
      }
    }
    return (str1, str2);
  }

  protected void ShowOverrideDatesDialog()
  {
    using (formReinstatementDatesOverRide reinstatementDatesOverRide = new formReinstatementDatesOverRide())
    {
      reinstatementDatesOverRide.EffectiveDate = this._effectiveDate;
      reinstatementDatesOverRide.PrintDate = this._printDate;
      int num = (int) reinstatementDatesOverRide.ShowDialog();
      this._effectiveDate = reinstatementDatesOverRide.EffectiveDate;
      this._printDate = reinstatementDatesOverRide.PrintDate;
    }
  }

  protected SectionReport CreateReport(
    int quoteID,
    object printDate,
    object reinstatementEffective)
  {
    SectionReport objectTypeAs = ObjectFactory.Instance.CreateObjectTypeAs<SectionReport>(typeof (rptReinstatementNotice), (object) quoteID, printDate, reinstatementEffective);
    objectTypeAs.Run();
    return objectTypeAs;
  }

  protected virtual SectionReport CreateReportFromUserEnteredDates(int quoteId, Type reportType)
  {
    SectionReport objectTypeAs;
    if (this.AskOverrideDates())
    {
      this.ShowOverrideDatesDialog();
      objectTypeAs = ObjectFactory.Instance.CreateObjectTypeAs<SectionReport>(reportType, (object) quoteId, (object) this._printDate, (object) this._effectiveDate);
    }
    else
      objectTypeAs = ObjectFactory.Instance.CreateObjectTypeAs<SectionReport>(reportType, (object) quoteId);
    objectTypeAs.Run();
    return objectTypeAs;
  }

  protected void PrintEnvelopes(
    string envelopePrinterName,
    string envelopePrinterTray,
    DataTable reportDataSource)
  {
    using (SectionReport objectAs = (SectionReport) ObjectFactory.Instance.CreateObjectAs<StandardNo10Envelope>())
      NoticeOfCancellation.PrintEnvelopes(objectAs, reportDataSource, envelopePrinterName, envelopePrinterTray);
  }

  protected virtual void AddToDocumentHandler(int quoteId, SectionReport report, bool runThreaded)
  {
    using (PdfExport pdfExport = new PdfExport())
    {
      string filePathForQuoteId = this.GetFilePathForQuoteId(quoteId);
      pdfExport.Export(report.Document, filePathForQuoteId);
      DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) null, filePathForQuoteId, -1, "Policy Reinstatement Notice", (ISupportDocumentSystem) new Quote(quoteId), true, string.Empty, runThreaded);
      if (runThreaded)
        return;
      File.Delete(filePathForQuoteId);
    }
  }

  protected virtual string GetFilePathForQuoteId(int quoteId)
  {
    return Path.Combine(MGATempFolder.MGATempPath, $"PolicyReinstatement_{quoteId}.pdf");
  }
}

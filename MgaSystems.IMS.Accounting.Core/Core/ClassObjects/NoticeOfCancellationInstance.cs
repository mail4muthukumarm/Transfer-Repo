// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.ClassObjects.NoticeOfCancellationInstance
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using CancellationNotices;
using CancellationNotices.LogonService;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.ClassObjects;

public class NoticeOfCancellationInstance
{
  private string _description = string.Empty;
  public string fileName;

  public string FileName { get; set; }

  public virtual bool PrintCancellationNotices(
    string sqlConnectionString,
    int quoteId,
    int officeLocationId,
    string printerName,
    string paperTray,
    string description)
  {
    this._description = description;
    return this.PrintCancellationNotices(sqlConnectionString, quoteId, officeLocationId, printerName, paperTray);
  }

  public virtual bool PrintCancellationNotices(
    string sqlConnectionString,
    int quoteId,
    int officeLocationId,
    string printerName,
    string paperTray)
  {
    SectionReport cancellationReport = (SectionReport) null;
    dsCancellationList.CancellationListDataTable cancellationListDataTable = this.GetCancelList(officeLocationId, quoteId);
    string documentServiceUrl = ConfigurationManager.AppSettings["WebServicesDocumentsUrl"];
    string logonServiceUrl = ConfigurationManager.AppSettings["WebServicesLogonUrl"];
    try
    {
      if (cancellationListDataTable.Rows.Count == 0)
        return false;
      this.LogNOCIssuance(cancellationListDataTable);
      if (MessageBox.Show("Print envelopes?", "Print Cancellation Envelopes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.PrintWithEnvelopes(cancellationListDataTable, printerName, paperTray, documentServiceUrl, logonServiceUrl);
      }
      else
      {
        cancellationReport = ObjectFactory.Instance.CreateObjectTypeAs<SectionReport>(typeof (PendingCancellation), (object) CurrentUser.Instance.ConnectionString);
        DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
        {
          this.PrintCancellationNotices(cancellationReport, cancellationListDataTable, printerName, paperTray, CurrentUser.Instance.UserName, CurrentUser.Instance.Password, CurrentUser.Instance.UserGUID, documentServiceUrl, logonServiceUrl, true, false, true);
          e.Transaction.Commit();
        }));
      }
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
      {
        NoticeOfCancellation.SetQuotesNOC(quoteId);
        e.Transaction.Commit();
      }));
      CurrentUser.Instance.LogAction("NOC Issued for Non-Payment", new Quote(quoteId).QuoteGuid);
      return true;
    }
    finally
    {
      cancellationReport?.Dispose();
    }
  }

  public virtual bool PrintCancellationNotices(
    string sqlConnectionString,
    int quoteId,
    int officeLocationId,
    DateTime effectiveDate,
    int reasonId,
    DateTime mailingDate,
    string printerName,
    string paperTray,
    string description)
  {
    this._description = description;
    return this.PrintCancellationNotices(sqlConnectionString, quoteId, officeLocationId, effectiveDate, reasonId, mailingDate, printerName, paperTray);
  }

  public virtual bool PrintCancellationNotices(
    string sqlConnectionString,
    int quoteId,
    int officeLocationId,
    DateTime effectiveDate,
    int reasonId,
    DateTime mailingDate,
    string printerName,
    string paperTray)
  {
    SectionReport cancellationReport = (SectionReport) null;
    dsCancellationList.CancellationListDataTable cancellationListDataTable = this.GetCancelList(officeLocationId, quoteId, effectiveDate, mailingDate);
    string documentServiceUrl = ConfigurationManager.AppSettings["WebServicesDocumentsUrl"];
    string logonServiceUrl = ConfigurationManager.AppSettings["WebServicesLogonUrl"];
    try
    {
      if (cancellationListDataTable.Rows.Count == 0)
        return false;
      this.LogNOCIssuance(cancellationListDataTable);
      if (MessageBox.Show("Print envelopes?", "Print Cancellation Envelopes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.PrintWithEnvelopes(cancellationListDataTable, printerName, paperTray, documentServiceUrl, logonServiceUrl);
      }
      else
      {
        cancellationReport = ObjectFactory.Instance.CreateObjectTypeAs<SectionReport>(typeof (PendingCancellation), (object) CurrentUser.Instance.ConnectionString);
        DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
        {
          this.PrintCancellationNotices(cancellationReport, cancellationListDataTable, printerName, paperTray, CurrentUser.Instance.UserName, CurrentUser.Instance.Password, CurrentUser.Instance.UserGUID, documentServiceUrl, logonServiceUrl, true, false, true);
          e.Transaction.Commit();
        }));
      }
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
      {
        NoticeOfCancellation.SetQuotesNOC(quoteId, reasonId);
        e.Transaction.Commit();
      }));
      CurrentUser.Instance.LogAction("NOC Issued for Non-Payment", new Quote(quoteId).QuoteGuid);
      return true;
    }
    finally
    {
      cancellationReport?.Dispose();
    }
  }

  public virtual void PrintCancellationNotices(
    SectionReport rpt,
    dsCancellationList.CancellationListDataTable dt,
    string printerName,
    string paperTray,
    string userName,
    string password,
    Guid userGuid,
    string documentServiceUrl,
    string logonServiceUrl,
    bool addToDocumentHandler,
    bool printedFromAutomation,
    bool sendToPrinter)
  {
    this.PrintNotices(rpt, dt, printerName, paperTray, userName, password, userGuid, (SectionReport) null, string.Empty, string.Empty, documentServiceUrl, logonServiceUrl, addToDocumentHandler, printedFromAutomation, sendToPrinter);
  }

  public virtual void PrintCancellationNotices(
    SectionReport rpt,
    dsCancellationList.CancellationListDataTable dt,
    string printerName,
    string paperTray,
    string userName,
    string password,
    Guid userGuid,
    SectionReport rptEnvelope,
    string envelopePrinterName,
    string envelopePrinterTray,
    string documentServiceUrl,
    string logonServiceUrl,
    bool addToDocumentHandler,
    bool printedFromAutomation,
    bool sendToPrinter)
  {
    this.PrintNotices(rpt, dt, printerName, paperTray, userName, password, userGuid, rptEnvelope, envelopePrinterName, envelopePrinterTray, documentServiceUrl, logonServiceUrl, addToDocumentHandler, printedFromAutomation, sendToPrinter);
  }

  public virtual void LogNOCIssuance(dsCancellationList.CancellationListDataTable dt)
  {
    int num = DefaultDatabase.ExecuteScalar<int>("dbo.spFin_CreateNOCIssuanceLogHeader");
    foreach (dsCancellationList.CancellationListRow cancellationListRow in (TypedTableBase<dsCancellationList.CancellationListRow>) dt)
      DefaultDatabase.ExecuteNonQuery("dbo.spFin_LogNOCIssuance", new object[38]
      {
        (object) "@IssuanceBatchID",
        (object) num,
        (object) "@InvoiceNum",
        (object) cancellationListRow.invoicenum,
        (object) "@DueDate",
        (object) cancellationListRow.duedate,
        (object) "@Insured",
        (object) cancellationListRow.insured,
        (object) "@Producer",
        (object) cancellationListRow.producer,
        (object) "@Retailer",
        (object) cancellationListRow.retailer,
        (object) "@Company",
        (object) cancellationListRow.company,
        (object) "@OfficeLocation",
        (object) cancellationListRow.officelocation,
        (object) "@PolicyNumber",
        (object) cancellationListRow.policynumber,
        (object) "@Line",
        (object) cancellationListRow.line,
        (object) "@ControlNo",
        (object) cancellationListRow.controlno,
        (object) "@Initials",
        (object) cancellationListRow.initials,
        (object) "@StateId",
        (object) cancellationListRow.stateid,
        (object) "@ReceivableBalance",
        (object) cancellationListRow.receivablebalance,
        (object) "@Mortgagee",
        (object) cancellationListRow.mortgagee,
        (object) "@QuoteID",
        (object) cancellationListRow.quoteid,
        (object) "@PrintFor",
        (object) cancellationListRow.printfor,
        (object) "@MailingDate",
        (object) cancellationListRow.MailingDate,
        (object) "@Description",
        (object) this._description
      });
  }

  public virtual void PrintNotices(
    SectionReport rpt,
    dsCancellationList.CancellationListDataTable dt,
    string printerName,
    string paperTray,
    string userName,
    string password,
    Guid userGuid,
    SectionReport rptEnvelope,
    string envelopePrinterName,
    string envelopePrinterTray,
    string documentServiceURL,
    string logonServiceURL,
    bool addToDocumentHandler,
    bool printedFromAutomation,
    bool sendToPrinter)
  {
    this.PrintNotices(rpt, dt, printerName, paperTray, userName, password, userGuid, rptEnvelope, envelopePrinterName, envelopePrinterTray, documentServiceURL, logonServiceURL, addToDocumentHandler, printedFromAutomation, sendToPrinter, -1);
  }

  public virtual void PrintNotices(
    SectionReport rpt,
    dsCancellationList.CancellationListDataTable dt,
    string printerName,
    string paperTray,
    SectionReport rptEnvelope,
    string envelopePrinterName,
    string envelopePrinterTray,
    bool addToDocumentHandler,
    bool printedFromAutomation,
    bool sendToPrinter,
    ISupportDocumentSystem entity,
    int documentFolderId)
  {
    SectionReport sectionReport = new SectionReport();
    if (dt.Rows.Count == 0)
      throw new InvalidOperationException("Cannot print notices when the provided cancellation list dataset is empty");
    Encryption encryption = new Encryption();
    DateTime dateTime = new DateTime();
    this.fileName = $"NoticeOfCancellation_{dateTime.Month}{dateTime.Day}{dateTime.Year}.pdf";
    if (printedFromAutomation)
      NoticeOfCancellation.PrintCertifiedMailStatement(dt, printerName, paperTray, dt.Rows[0].Field<string>("officelocation"));
    SortedList cancellationNotices = NoticeOfCancellation.ParseCancellationNotices(dt);
    for (int index1 = 0; index1 <= cancellationNotices.Count - 1; ++index1)
    {
      NoticeOfCancellation.ParseObj byIndex = (NoticeOfCancellation.ParseObj) cancellationNotices.GetByIndex(index1);
      dsCancellationList.CancellationListRow[] cancellationListRowArray = (dsCancellationList.CancellationListRow[]) dt.Select($"controlGuid = '{byIndex.ControlGuid}' and quoteId = {byIndex.QuoteId}");
      if (cancellationListRowArray.Length != 0)
      {
        dsCancellationList.CancellationListDataTable dt1 = new dsCancellationList.CancellationListDataTable();
        for (int index2 = 0; index2 <= cancellationListRowArray.Length - 1; ++index2)
        {
          dsCancellationList.CancellationListRow row = dt1.NewCancellationListRow();
          row.company = cancellationListRowArray[index2].company;
          row.controlGuid = cancellationListRowArray[index2].controlGuid;
          row.controlno = cancellationListRowArray[index2].controlno;
          row.duedate = cancellationListRowArray[index2].duedate;
          row.effectiveDate = cancellationListRowArray[index2].effectiveDate;
          row.expirationDate = cancellationListRowArray[index2].expirationDate;
          row.initials = cancellationListRowArray[index2].initials;
          row.insured = cancellationListRowArray[index2].insured;
          row.invoicenum = cancellationListRowArray[index2].invoicenum;
          row.line = cancellationListRowArray[index2].line;
          row.minQuoteId = cancellationListRowArray[index2].minQuoteId;
          row.mortgagee = cancellationListRowArray[index2].mortgagee;
          row.officelocation = cancellationListRowArray[index2].officelocation;
          row.policynumber = cancellationListRowArray[index2].policynumber;
          row.printfor = cancellationListRowArray[index2].printfor;
          row.producer = cancellationListRowArray[index2].producer;
          row.quoteid = cancellationListRowArray[index2].quoteid;
          row.receivablebalance = cancellationListRowArray[index2].receivablebalance;
          row.retailer = cancellationListRowArray[index2].retailer;
          row.stateid = cancellationListRowArray[index2].stateid;
          row.MailingDate = cancellationListRowArray[index2].MailingDate;
          row.PolicyPeriod = cancellationListRowArray[index2].PolicyPeriod;
          dt1.Rows.Add((DataRow) row);
        }
        if (dt1.Rows.Count > 0)
        {
          rpt.DataSource = (object) dt1;
          rpt.Document.Printer.PrinterName = string.Empty;
          rpt.Run();
          sectionReport.Document.Pages.AddRange(rpt.Document.Pages);
          if (rptEnvelope != null)
            NoticeOfCancellation.PrintEnvelopes(rptEnvelope, (DataTable) dt1, envelopePrinterName, envelopePrinterTray);
          if (addToDocumentHandler)
          {
            PdfExport pdfExport = new PdfExport();
            string path = $"{Path.GetTempPath()}\\{this.fileName}";
            pdfExport.Export(rpt.Document, path);
            DocumentManager.FileAddWithBind(path, documentFolderId, "Notice of Cancellation", entity, true);
          }
        }
      }
    }
    if (!sendToPrinter)
      return;
    if (printerName.Trim() != string.Empty)
    {
      sectionReport.Document.Printer.PrinterName = printerName;
      sectionReport.Document.Printer.PaperKind = PaperKind.Letter;
      foreach (PaperSource paperSource in ((PrintDocument) sectionReport.Document.Printer).PrinterSettings.PaperSources)
      {
        if (paperSource.SourceName == paperTray)
        {
          ((PrintDocument) sectionReport.Document.Printer).PrinterSettings.DefaultPageSettings.PaperSource = paperSource;
          break;
        }
      }
    }
    if (sectionReport.Document.Pages.Count <= 0)
      return;
    PrintExtension.Print(sectionReport.Document, false, false, false);
  }

  public virtual void PrintNotices(
    SectionReport rpt,
    dsCancellationList.CancellationListDataTable dt,
    string printerName,
    string paperTray,
    string userName,
    string password,
    Guid userGuid,
    SectionReport rptEnvelope,
    string envelopePrinterName,
    string envelopePrinterTray,
    string documentServiceURL,
    string logonServiceURL,
    bool addToDocumentHandler,
    bool printedFromAutomation,
    bool sendToPrinter,
    int documentFolderId)
  {
    SectionReport sectionReport = new SectionReport();
    if (dt.Rows.Count == 0)
      throw new InvalidOperationException("The cancellation list dataset was empty!");
    CancellationNotices.DocumentFunctions.DocumentFunctions documentFunctions = (CancellationNotices.DocumentFunctions.DocumentFunctions) null;
    Logon logon = new Logon() { Url = logonServiceURL };
    Encryption encryption = new Encryption();
    int index1 = 0;
    int index2 = 0;
    // ISSUE: variable of a boxed type
    __Boxed<int> month = (System.ValueType) DateTime.Now.Month;
    DateTime now = DateTime.Now;
    // ISSUE: variable of a boxed type
    __Boxed<int> day = (System.ValueType) now.Day;
    now = DateTime.Now;
    // ISSUE: variable of a boxed type
    __Boxed<int> year = (System.ValueType) now.Year;
    this.fileName = $"NoticeOfCancellation_{month}{day}{year}.pdf";
    FileInfo fileInfo = (FileInfo) null;
    FileStream fileStream = (FileStream) null;
    if (printedFromAutomation)
      NoticeOfCancellation.PrintCertifiedMailStatement(dt, printerName, paperTray, dt.Rows[0].Field<string>("officelocation"));
    try
    {
      for (SortedList cancellationNotices = NoticeOfCancellation.ParseCancellationNotices(dt); index1 < cancellationNotices.Count; ++index1)
      {
        NoticeOfCancellation.ParseObj byIndex = (NoticeOfCancellation.ParseObj) cancellationNotices.GetByIndex(index1);
        dsCancellationList.CancellationListRow[] cancellationListRowArray = (dsCancellationList.CancellationListRow[]) dt.Select($"controlGuid = '{byIndex.ControlGuid.ToString()}' and quoteId = {byIndex.QuoteId}");
        if (cancellationListRowArray.Length != 0)
        {
          dsCancellationList.CancellationListDataTable dt1 = new dsCancellationList.CancellationListDataTable();
          for (; index2 < cancellationListRowArray.Length; ++index2)
          {
            dsCancellationList.CancellationListRow row = dt1.NewCancellationListRow();
            row.company = cancellationListRowArray[index2].company;
            row.controlGuid = cancellationListRowArray[index2].controlGuid;
            row.controlno = cancellationListRowArray[index2].controlno;
            row.duedate = cancellationListRowArray[index2].duedate;
            row.effectiveDate = cancellationListRowArray[index2].effectiveDate;
            row.expirationDate = cancellationListRowArray[index2].expirationDate;
            row.initials = cancellationListRowArray[index2].initials;
            row.insured = cancellationListRowArray[index2].insured;
            row.invoicenum = cancellationListRowArray[index2].invoicenum;
            row.line = cancellationListRowArray[index2].line;
            row.minQuoteId = cancellationListRowArray[index2].minQuoteId;
            row.mortgagee = cancellationListRowArray[index2].mortgagee;
            row.officelocation = cancellationListRowArray[index2].officelocation;
            row.policynumber = cancellationListRowArray[index2].policynumber;
            row.printfor = cancellationListRowArray[index2].printfor;
            row.producer = cancellationListRowArray[index2].producer;
            row.quoteid = cancellationListRowArray[index2].quoteid;
            row.receivablebalance = cancellationListRowArray[index2].receivablebalance;
            row.retailer = cancellationListRowArray[index2].retailer;
            row.stateid = cancellationListRowArray[index2].stateid;
            row.MailingDate = cancellationListRowArray[index2].MailingDate;
            row.PolicyPeriod = cancellationListRowArray[index2].PolicyPeriod;
            dt1.Rows.Add((DataRow) row);
          }
          rpt.DataSource = (object) dt1;
          rpt.Document.Printer.PrinterName = string.Empty;
          rpt.Run();
          sectionReport.Document.Pages.AddRange(rpt.Document.Pages);
          if (rptEnvelope != null && dt1 != null)
            NoticeOfCancellation.PrintEnvelopes(rptEnvelope, (DataTable) dt1, envelopePrinterName, envelopePrinterTray);
          if (addToDocumentHandler)
          {
            new PdfExport().Export(rpt.Document, $"{Path.GetTempPath()}\\{this.fileName}");
            if (File.Exists($"{Path.GetTempPath()}\\{this.fileName}"))
            {
              fileInfo = new FileInfo($"{Path.GetTempPath()}\\{this.fileName}");
              fileStream = fileInfo.OpenRead();
              int int32 = Convert.ToInt32(fileInfo.Length);
              byte[] numArray = new byte[int32 + 1];
              fileStream.Read(numArray, 0, int32);
              if (numArray.Length != 0)
              {
                if (documentFunctions == null)
                  documentFunctions = new CancellationNotices.DocumentFunctions.DocumentFunctions();
                documentFunctions.Url = documentServiceURL;
                documentFunctions.TokenHeaderValue = new CancellationNotices.DocumentFunctions.TokenHeader()
                {
                  Token = logon.LoginUser(userName, encryption.EncryptTripleDes(password))
                };
                documentFunctions.InsertDocumentAssociatedToControlGUID(userGuid, this.fileName, numArray, "Notice Of Cancellation", byIndex.ControlGuid, "MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail", "", documentFolderId);
                File.Delete(this.fileName);
              }
              fileInfo = (FileInfo) null;
              fileStream.Close();
            }
          }
        }
        index2 = 0;
      }
      if (!sendToPrinter)
        return;
      if (printerName.Trim() != string.Empty)
      {
        sectionReport.Document.Printer.PrinterName = printerName;
        sectionReport.Document.Printer.PaperKind = PaperKind.Letter;
        using (IEnumerator<PaperSource> enumerator = ((PrintDocument) sectionReport.Document.Printer).PrinterSettings.PaperSources.Cast<PaperSource>().Where<PaperSource>((System.Func<PaperSource, bool>) (p => p.SourceName == paperTray)).GetEnumerator())
        {
          if (enumerator.MoveNext())
          {
            PaperSource current = enumerator.Current;
            ((PrintDocument) sectionReport.Document.Printer).PrinterSettings.DefaultPageSettings.PaperSource = current;
          }
        }
      }
      if (sectionReport.Document.Pages.Count <= 0)
        return;
      PrintExtension.Print(sectionReport.Document, false, false, false);
    }
    finally
    {
      if (fileInfo != null)
        ;
      if (fileStream != null)
        ;
    }
  }

  private dsCancellationList.CancellationListDataTable GetCancelList(
    int officeID,
    int quoteID,
    DateTime EffectiveDate,
    DateTime MailingDate)
  {
    dsCancellationList.CancellationListDataTable cancelTable = new dsCancellationList().CancellationList;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
    {
      foreach (DataRow row in (InternalDataCollectionBase) DefaultDatabase.ExecuteDataTable(Utility.GetManualNOCProcedure(), new object[8]
      {
        (object) "@glcompanyid",
        (object) officeID,
        (object) "quoteId",
        (object) quoteID,
        (object) "@effectiveDate",
        (object) EffectiveDate,
        (object) "@mailingDate",
        (object) MailingDate
      }).Rows)
        cancelTable.AddCancellationListRow(row.Field<int>("invoiceNum"), row.Field<DateTime>("duedate"), row.Field<string>("insured"), row.Field<string>("producer"), row.Field<string>("retailer"), row.Field<string>("company"), row.Field<string>("officelocation"), row.Field<string>("policynumber"), row.Field<string>("line"), (long) row.Field<int>("controlno"), row.Field<string>("initials"), row.Field<string>("stateid"), row.Field<Decimal>("receivablebalance"), row.Field<string>("mortgagee"), (long) row.Field<int>("quoteid"), row.Field<string>("printfor"), row.Field<DateTime>("effectiveDate"), row.Field<DateTime>("expirationDate"), row.Field<Guid>("controlGuid").ToString(), row.Field<int>("minQuoteId"), row.Field<DateTime>(nameof (MailingDate)), row.Field<string>("PolicyPeriod"), true, 0M);
    }));
    return cancelTable;
  }

  private dsCancellationList.CancellationListDataTable GetCancelList(int officeID, int quoteID)
  {
    dsCancellationList.CancellationListDataTable cancelTable = new dsCancellationList().CancellationList;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
    {
      foreach (DataRow row in (InternalDataCollectionBase) DefaultDatabase.ExecuteDataTable("dbo.spFin_GetNOCIssuance_Quote", new object[4]
      {
        (object) "@glcompanyid",
        (object) officeID,
        (object) "quoteId",
        (object) quoteID
      }).Rows)
        cancelTable.AddCancellationListRow(row.Field<int>("invoiceNum"), row.Field<DateTime>("duedate"), row.Field<string>("insured"), row.Field<string>("producer"), row.Field<string>("retailer"), row.Field<string>("company"), row.Field<string>("officelocation"), row.Field<string>("policynumber"), row.Field<string>("line"), ExtensionsMethods.FieldAs<long>(row, "controlno", DataRowVersion.Current), row.Field<string>("initials"), row.Field<string>("stateid"), row.Field<Decimal>("receivablebalance"), row.Field<string>("mortgagee"), ExtensionsMethods.FieldAs<long>(row, "quoteid", DataRowVersion.Current), row.Field<string>("printfor"), row.Field<DateTime>("effectiveDate"), row.Field<DateTime>("expirationDate"), row.Field<Guid>("controlGuid").ToString(), row.Field<int>("minQuoteId"), row.Field<DateTime>("MailingDate"), row.Field<string>("PolicyPeriod"), true, 0M);
    }));
    return cancelTable;
  }

  public void PrintWithEnvelopes(
    dsCancellationList.CancellationListDataTable ds,
    string printerName,
    string paperTray,
    string documentServiceURL,
    string logonServiceURL)
  {
    StandardNo10Envelope reportEnvironment = ObjectFactory.Instance.CreateObjectAs<StandardNo10Envelope>();
    PrintDialog printDialog = new PrintDialog();
    printDialog.Document = new PrintDocument()
    {
      DocumentName = "Notice Of Cancellation Envelopes"
    };
    printDialog.AllowPrintToFile = false;
    printDialog.AllowSelection = true;
    if (printDialog.ShowDialog() != DialogResult.OK)
      return;
    string envelopePrinterName = printDialog.PrinterSettings.PrinterName;
    string envelopePrinterTray = printDialog.Document.DefaultPageSettings.PaperSource.SourceName;
    SectionReport cancellationReport = ObjectFactory.Instance.CreateObjectTypeAs<SectionReport>(typeof (PendingCancellation), (object) CurrentUser.Instance.ConnectionString);
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
    {
      this.PrintCancellationNotices(cancellationReport, ds, printerName, paperTray, CurrentUser.Instance.UserName, CurrentUser.Instance.Password, CurrentUser.Instance.UserGUID, (SectionReport) reportEnvironment, envelopePrinterName, envelopePrinterTray, documentServiceURL, logonServiceURL, true, false, true);
      e.Transaction.Commit();
    }));
  }
}

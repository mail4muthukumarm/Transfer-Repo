// Decompiled with JetBrains decompiler
// Type: CancellationNotices.NoticeOfCancellation
// Assembly: MgaSystems.IMS.CancellationNotices, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 212B4515-7BA8-45EF-B7D5-4974627BD234
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.CancellationNotices.dll

using CancellationNotices.LogonService;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
namespace CancellationNotices;

[Preference("NoticeOfCancellation.PreventLocalPrint", false)]
public class NoticeOfCancellation
{
  internal const string PREFERENCE_PREVENT_LOCAL_PRINT = "NoticeOfCancellation.PreventLocalPrint";
  private const string AccountingDocumentFolderGuid = "{49DF864B-0908-436D-9FDA-1BC3941B21DE}";
  private const string ACTIVEREPORTS_LICENSEKEY = "John Bennis,MGA Systems,DD-ARN-30-E000764,7OVFUFVM7JS48FVS7WF7";

  public static void PrintCancellationNotices(
    SectionReport rpt,
    dsCancellationList.CancellationListDataTable dt,
    string printerName,
    string paperTray,
    bool addToDocumentHandler,
    bool printedFromAutomation,
    bool sendToPrinter,
    ISupportDocumentSystem entity)
  {
    NoticeOfCancellation.PrintCancellationNotices(rpt, dt, printerName, paperTray, addToDocumentHandler, printedFromAutomation, sendToPrinter, entity, -1);
  }

  public static void PrintCancellationNotices(
    SectionReport rpt,
    dsCancellationList.CancellationListDataTable dt,
    string printerName,
    string paperTray,
    bool addToDocumentHandler,
    bool printedFromAutomation,
    bool sendToPrinter,
    ISupportDocumentSystem entity,
    int documentFolderID)
  {
    NoticeOfCancellation.PrintCancellationNotices(rpt, dt, printerName, paperTray, (SectionReport) null, string.Empty, string.Empty, addToDocumentHandler, printedFromAutomation, sendToPrinter, entity, documentFolderID);
  }

  public static void PrintCancellationNotices(
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
    int documentFolderID = -1)
  {
    NoticeOfCancellation.PrintNotices(rpt, dt, printerName, paperTray, rptEnvelope, envelopePrinterName, envelopePrinterTray, addToDocumentHandler, printedFromAutomation, sendToPrinter, entity, documentFolderID);
  }

  public static void PrintCancellationNotices(
    SectionReport rpt,
    dsCancellationList.CancellationListDataTable dt,
    string PrinterName,
    string PaperTray,
    string userName,
    string Password,
    Guid UserGuid,
    string DocumentServiceURL,
    string LogonServiceURL,
    bool AddToDocumentHandler,
    bool PrintedFromAutomation)
  {
    NoticeOfCancellation.PrintNotices(rpt, dt, PrinterName, PaperTray, userName, Password, UserGuid, (SectionReport) null, string.Empty, string.Empty, DocumentServiceURL, LogonServiceURL, AddToDocumentHandler, PrintedFromAutomation, true);
  }

  public static void PrintCancellationNotices(
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
    bool printedFromAutomation)
  {
    NoticeOfCancellation.PrintNotices(rpt, dt, printerName, paperTray, userName, password, userGuid, rptEnvelope, envelopePrinterName, envelopePrinterTray, documentServiceURL, logonServiceURL, addToDocumentHandler, printedFromAutomation, true);
  }

  public static void PrintCancellationNotices(
    SectionReport rpt,
    dsCancellationList.CancellationListDataTable dt,
    string PrinterName,
    string PaperTray,
    string userName,
    string Password,
    Guid UserGuid,
    string DocumentServiceURL,
    string LogonServiceURL,
    bool AddToDocumentHandler,
    bool printedFromAutomation,
    bool sendToPrinter)
  {
    NoticeOfCancellation.PrintNotices(rpt, dt, PrinterName, PaperTray, userName, Password, UserGuid, (SectionReport) null, string.Empty, string.Empty, DocumentServiceURL, LogonServiceURL, AddToDocumentHandler, printedFromAutomation, sendToPrinter);
  }

  public static void PrintCancellationNotices(
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
    bool AddToDocumentHandler,
    bool printedFromAutomation,
    bool sendToPrinter)
  {
    NoticeOfCancellation.PrintNotices(rpt, dt, printerName, paperTray, userName, password, userGuid, rptEnvelope, envelopePrinterName, envelopePrinterTray, documentServiceURL, logonServiceURL, AddToDocumentHandler, printedFromAutomation, sendToPrinter);
  }

  public static void PrintCancellationNotices(
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
    bool AddToDocumentHandler,
    bool printedFromAutomation,
    bool sendToPrinter,
    int documentFolderId)
  {
    NoticeOfCancellation.PrintNotices(rpt, dt, printerName, paperTray, userName, password, userGuid, rptEnvelope, envelopePrinterName, envelopePrinterTray, documentServiceURL, logonServiceURL, AddToDocumentHandler, printedFromAutomation, sendToPrinter, documentFolderId);
  }

  private static void PrintNotices(
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
    NoticeOfCancellation.PrintNotices(rpt, dt, printerName, paperTray, userName, password, userGuid, rptEnvelope, envelopePrinterName, envelopePrinterTray, documentServiceURL, logonServiceURL, addToDocumentHandler, printedFromAutomation, sendToPrinter, -1);
  }

  private static void PrintNotices(
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
    SectionReport sectionReport1 = new SectionReport();
    if (dt.Rows.Count == 0)
      throw new InvalidOperationException("Cannot print notices when the provided cancellation list dataset is empty");
    Encryption encryption = new Encryption();
    string str1 = $"NoticeOfCancellation_{DateAndTime.Month(DateAndTime.Now)}{DateAndTime.Day(DateAndTime.Now)}{DateAndTime.Year(DateAndTime.Now)}.pdf";
    if (printedFromAutomation)
      NoticeOfCancellation.PrintCertifiedMailStatement(dt, printerName, paperTray, dt.Rows[0].Field<string>("officelocation"));
    try
    {
      SortedList cancellationNotices = NoticeOfCancellation.ParseCancellationNotices(dt);
      int num1 = cancellationNotices.Count - 1;
      for (int index1 = 0; index1 <= num1; ++index1)
      {
        NoticeOfCancellation.ParseObj byIndex = (NoticeOfCancellation.ParseObj) cancellationNotices.GetByIndex(index1);
        dsCancellationList.CancellationListRow[] cancellationListRowArray = (dsCancellationList.CancellationListRow[]) dt.Select($"controlGuid = '{byIndex.ControlGuid}' and quoteId = {byIndex.QuoteId}");
        if (cancellationListRowArray.Length != 0)
        {
          dsCancellationList.CancellationListDataTable dt1 = new dsCancellationList.CancellationListDataTable();
          int num2 = cancellationListRowArray.Length - 1;
          for (int index2 = 0; index2 <= num2; ++index2)
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
          if (dt1 != null && dt1.Rows.Count > 0)
          {
            SectionReport sectionReport2 = rpt;
            sectionReport2.DataSource = (object) dt1;
            sectionReport2.Document.Printer.PrinterName = string.Empty;
            sectionReport2.Run();
            sectionReport1.Document.Pages.AddRange(sectionReport2.Document.Pages);
            if (rptEnvelope != null && dt1 != null)
              NoticeOfCancellation.PrintEnvelopes(rptEnvelope, (DataTable) dt1, envelopePrinterName, envelopePrinterTray);
            if (addToDocumentHandler)
            {
              PdfExport pdfExport = new PdfExport();
              string path = $"{Path.GetTempPath()}\\{str1}";
              SectionDocument document = rpt.Document;
              string str2 = path;
              pdfExport.Export(document, str2);
              DocumentManager.FileAddWithBind(path, documentFolderId, "Notice of Cancellation", entity, true);
            }
          }
        }
      }
      bool flag = false;
      if (!sendToPrinter || flag)
        return;
      SectionReport sectionReport3 = sectionReport1;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(printerName.Trim(), string.Empty, false) != 0)
      {
        sectionReport3.Document.Printer.PrinterName = printerName;
        sectionReport3.Document.Printer.PaperKind = PaperKind.Letter;
        try
        {
          foreach (PaperSource paperSource in ((PrintDocument) sectionReport3.Document.Printer).PrinterSettings.PaperSources)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paperSource.SourceName, paperTray, false) == 0)
            {
              ((PrintDocument) sectionReport3.Document.Printer).PrinterSettings.DefaultPageSettings.PaperSource = paperSource;
              break;
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      if (sectionReport1.Document.Pages.Count > 0)
        PrintExtension.Print(sectionReport1.Document, false, false, false);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw;
    }
  }

  private static void PrintNotices(
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
    SectionReport sectionReport1 = new SectionReport();
    if (dt.Rows.Count == 0)
      throw new InvalidOperationException("The cancellation list dataset was empty!");
    CancellationNotices.DocumentFunctions.DocumentFunctions documentFunctions = (CancellationNotices.DocumentFunctions.DocumentFunctions) null;
    Logon logon = new Logon();
    logon.Url = logonServiceURL;
    Encryption encryption = new Encryption();
    int index1 = 0;
    int index2 = 0;
    string str = $"NoticeOfCancellation_{DateAndTime.Month(DateTime.Now).ToString()}{DateAndTime.Day(DateTime.Now).ToString()}{DateAndTime.Year(DateTime.Now).ToString()}.pdf";
    FileInfo fileInfo = (FileInfo) null;
    FileStream fileStream = (FileStream) null;
    if (printedFromAutomation)
      NoticeOfCancellation.PrintCertifiedMailStatement(dt, printerName, paperTray, dt.Rows[0]["officelocation"].ToString());
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
          if (dt1 != null && dt1.Rows.Count > 0)
          {
            SectionReport sectionReport2 = rpt;
            sectionReport2.DataSource = (object) dt1;
            sectionReport2.Document.Printer.PrinterName = string.Empty;
            sectionReport2.Run();
            sectionReport1.Document.Pages.AddRange(sectionReport2.Document.Pages);
            if (rptEnvelope != null && dt1 != null)
              NoticeOfCancellation.PrintEnvelopes(rptEnvelope, (DataTable) dt1, envelopePrinterName, envelopePrinterTray);
            if (addToDocumentHandler)
            {
              new PdfExport().Export(rpt.Document, $"{Path.GetTempPath()}\\{str}");
              if (File.Exists($"{Path.GetTempPath()}\\{str}"))
              {
                fileInfo = new FileInfo($"{Path.GetTempPath()}\\{str}");
                fileStream = fileInfo.OpenRead();
                int length = (int) fileInfo.Length;
                byte[] numArray = new byte[length + 1];
                fileStream.Read(numArray, 0, length);
                if (numArray.Length != 0)
                {
                  if (documentFunctions == null)
                    documentFunctions = new CancellationNotices.DocumentFunctions.DocumentFunctions();
                  documentFunctions.Url = documentServiceURL;
                  documentFunctions.TokenHeaderValue = new CancellationNotices.DocumentFunctions.TokenHeader();
                  documentFunctions.TokenHeaderValue.Token = logon.LoginUser(userName, encryption.EncryptTripleDes(password));
                  documentFunctions.InsertDocumentAssociatedToControlGUID(userGuid, str, numArray, "Notice Of Cancellation", byIndex.ControlGuid, "MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail", "", documentFolderId);
                  File.Delete(str);
                }
                fileInfo = (FileInfo) null;
                fileStream.Close();
              }
            }
          }
        }
        index2 = 0;
      }
      bool flag = false;
      if (!sendToPrinter || flag)
        return;
      SectionReport sectionReport3 = sectionReport1;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(printerName.Trim(), string.Empty, false) != 0)
      {
        sectionReport3.Document.Printer.PrinterName = printerName;
        sectionReport3.Document.Printer.PaperKind = PaperKind.Letter;
        try
        {
          foreach (PaperSource paperSource in ((PrintDocument) sectionReport3.Document.Printer).PrinterSettings.PaperSources)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paperSource.SourceName, paperTray, false) == 0)
            {
              ((PrintDocument) sectionReport3.Document.Printer).PrinterSettings.DefaultPageSettings.PaperSource = paperSource;
              break;
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      if (sectionReport1.Document.Pages.Count > 0)
        PrintExtension.Print(sectionReport1.Document, false, false, false);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw;
    }
    finally
    {
      if (fileInfo != null)
        ;
      if (fileStream != null)
        ;
    }
  }

  public static void PrintCancellationNotices(
    bool IsSentinelDriven,
    SectionReport rpt,
    dsCancellationList.CancellationListDataTable dt,
    string PrinterName,
    string PaperTray,
    string userName,
    string Password,
    Guid UserGuid,
    SectionReport rptEnvelope,
    string EnvelopePrinterName,
    string EnvelopePrinterTray,
    string DocumentServiceURL,
    string LogonServiceURL,
    bool AddToDocumentHandler = true,
    bool PrintedFromAutomation = false,
    int DocumentFolderId = -1)
  {
    SectionReport sectionReport1 = new SectionReport();
    if (dt.Rows.Count == 0)
    {
      EventLog.WriteEntry("Sentinel Debugging", "Sentinel - Empty Dataset", EventLogEntryType.Information);
      throw new InvalidOperationException("The cancellation list dataset was empty!");
    }
    CancellationNotices.DocumentFunctions.DocumentFunctions documentFunctions = (CancellationNotices.DocumentFunctions.DocumentFunctions) null;
    Logon logon = new Logon();
    logon.Url = LogonServiceURL;
    Encryption encryption = new Encryption();
    string[] strArray = new string[5]
    {
      "NoticeOfCancellation_",
      DateAndTime.Month(DateTime.Now).ToString(),
      null,
      null,
      null
    };
    int num = DateAndTime.Day(DateTime.Now);
    strArray[2] = num.ToString();
    num = DateAndTime.Year(DateTime.Now);
    strArray[3] = num.ToString();
    strArray[4] = ".pdf";
    string str = string.Concat(strArray);
    FileInfo fileInfo = (FileInfo) null;
    FileStream fileStream = (FileStream) null;
    Guid controlGUID = new Guid(dt.Rows[0]["controlGuid"].ToString());
    dt.Rows[0]["policyNumber"].ToString();
    try
    {
      SectionReport sectionReport2 = rpt;
      sectionReport2.DataSource = (object) dt;
      sectionReport2.Document.Printer.PrinterName = string.Empty;
      sectionReport2.Run();
      sectionReport1.Document.Pages.AddRange(sectionReport2.Document.Pages);
      if (AddToDocumentHandler)
      {
        PdfExport pdfExport = new PdfExport();
        try
        {
          pdfExport.Export(rpt.Document, $"{Path.GetTempPath()}\\{str}");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          EventLog.WriteEntry("Cancellation Notices", $"Error creating .pdf - {exception.Message} Stack: {exception.StackTrace}", EventLogEntryType.Error);
          ProjectData.ClearProjectError();
        }
        if (File.Exists($"{Path.GetTempPath()}\\{str}"))
        {
          fileInfo = new FileInfo($"{Path.GetTempPath()}\\{str}");
          fileStream = fileInfo.OpenRead();
          int length = (int) fileInfo.Length;
          byte[] numArray = new byte[length + 1];
          fileStream.Read(numArray, 0, length);
          if (numArray.Length != 0)
          {
            if (documentFunctions == null)
              documentFunctions = new CancellationNotices.DocumentFunctions.DocumentFunctions();
            documentFunctions.Url = DocumentServiceURL;
            documentFunctions.TokenHeaderValue = new CancellationNotices.DocumentFunctions.TokenHeader();
            documentFunctions.TokenHeaderValue.Token = logon.LoginUser(userName, encryption.EncryptTripleDes(Password));
            try
            {
              documentFunctions.InsertDocumentAssociatedToControlGUID(UserGuid, str, numArray, "Notice Of Cancellation", controlGUID, "MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail", "", DocumentFolderId);
              File.Delete(str);
            }
            catch (Exception ex1)
            {
              ProjectData.SetProjectError(ex1);
              Exception exception = ex1;
              try
              {
                EventLog eventLog = new EventLog();
                EventLog.WriteEntry("NOC Service", "An error has occurred while trying to send to notices to the document handler. " + exception.Message, EventLogEntryType.Error);
                eventLog.Dispose();
              }
              catch (System.Security.SecurityException ex2)
              {
                ProjectData.SetProjectError((Exception) ex2);
                ProjectData.ClearProjectError();
              }
              throw exception;
            }
          }
          fileInfo = (FileInfo) null;
          fileStream.Close();
        }
      }
      if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Sentinel.NOC.ByPassPrintingNOC"))
        return;
      SectionReport sectionReport3 = sectionReport1;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(PrinterName.Trim(), string.Empty, false) != 0)
      {
        sectionReport3.Document.Printer.PrinterName = PrinterName;
        sectionReport3.Document.Printer.PaperKind = PaperKind.Letter;
        try
        {
          foreach (PaperSource paperSource in ((PrintDocument) sectionReport3.Document.Printer).PrinterSettings.PaperSources)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paperSource.SourceName, PaperTray, false) == 0)
            {
              ((PrintDocument) sectionReport3.Document.Printer).PrinterSettings.DefaultPageSettings.PaperSource = paperSource;
              break;
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      if (sectionReport1.Document.Pages.Count > 0)
        PrintExtension.Print(sectionReport1.Document, false, false, false);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw ex;
    }
    finally
    {
      if (fileInfo != null)
        ;
      if (fileStream != null)
        ;
    }
  }

  public static SortedList ParseCancellationNotices(dsCancellationList.CancellationListDataTable dt)
  {
    SortedList cancellationNotices = new SortedList();
    try
    {
      foreach (dsCancellationList.CancellationListRow cancellationListRow in (TypedTableBase<dsCancellationList.CancellationListRow>) dt)
      {
        if (!cancellationNotices.ContainsKey((object) cancellationListRow.controlGuid))
        {
          NoticeOfCancellation.ParseObj parseObj = new NoticeOfCancellation.ParseObj(new Guid(cancellationListRow.controlGuid.ToString()), (int) cancellationListRow.quoteid, cancellationListRow.policynumber.ToString());
          cancellationNotices.Add((object) parseObj.ControlGuid.ToString(), (object) parseObj);
        }
      }
    }
    finally
    {
      IEnumerator<dsCancellationList.CancellationListRow> enumerator;
      enumerator?.Dispose();
    }
    return cancellationNotices;
  }

  public static void SetQuotesNOC(int quoteId, SqlCommand cmd)
  {
    cmd.CommandText = "spFin_SetQuoteNOC";
    SqlCommand sqlCommand = cmd;
    sqlCommand.CommandType = CommandType.StoredProcedure;
    sqlCommand.Parameters.Clear();
    sqlCommand.Parameters.AddWithValue("@quoteid", (object) quoteId);
    sqlCommand.ExecuteNonQuery();
  }

  public static void SetQuotesNOC(int quoteId, SqlCommand cmd, int ReasonId)
  {
    cmd.CommandText = "spFin_SetQuoteNOC";
    SqlCommand sqlCommand = cmd;
    sqlCommand.CommandType = CommandType.StoredProcedure;
    sqlCommand.Parameters.Clear();
    sqlCommand.Parameters.AddWithValue("@quoteid", (object) quoteId);
    sqlCommand.Parameters.AddWithValue("@reasonid", (object) ReasonId);
    sqlCommand.ExecuteNonQuery();
  }

  public static void SetQuotesNOC(int quoteId, int ReasonId)
  {
    if (!DefaultDatabase.HasTransaction)
      throw new InvalidOperationException("SetQuotesNOC must be called in the context of a transaction.");
    DefaultDatabase.ExecuteNonQuery("spFin_SetQuoteNOC", new object[4]
    {
      (object) "@quoteid",
      (object) quoteId,
      (object) "@reasonid",
      (object) ReasonId
    });
  }

  public static void SetQuotesNOC(int quoteId)
  {
    if (!DefaultDatabase.HasTransaction)
      throw new InvalidOperationException("SetQuotesNOC must be called in the context of a transaction.");
    DefaultDatabase.ExecuteNonQuery("spFin_SetQuoteNOC", new object[2]
    {
      (object) "@quoteid",
      (object) quoteId
    });
  }

  public static void PrintEnvelopes(
    SectionReport envelope,
    DataTable dt,
    string printerName,
    string paperTray)
  {
    EventLog eventLog = new EventLog();
    if (envelope == null)
      return;
    try
    {
      DataTable dataTable = (DataTable) NoticeOfCancellation.BuildEnvelopeDataTable(dt);
      SectionReport sectionReport = envelope;
      if (dataTable != null)
        sectionReport.DataSource = (object) dataTable;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(printerName.Trim(), string.Empty, false) != 0)
      {
        sectionReport.Document.Printer.PrinterName = printerName;
        sectionReport.Document.Printer.PaperKind = PaperKind.Number10Envelope;
        try
        {
          foreach (PaperSource paperSource in ((PrintDocument) sectionReport.Document.Printer).PrinterSettings.PaperSources)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paperSource.SourceName, paperTray, false) == 0)
            {
              ((PrintDocument) sectionReport.Document.Printer).PrinterSettings.DefaultPageSettings.PaperSource = paperSource;
              break;
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      if (dataTable.Rows.Count > 0)
      {
        sectionReport.Run();
        PrintExtension.Print(sectionReport.Document, false, false, false);
      }
    }
    finally
    {
      eventLog.Dispose();
    }
  }

  private static dsCancellationList.EnvelopeListDataTable BuildEnvelopeDataTable(DataTable dt)
  {
    dsCancellationList.EnvelopeListDataTable envelopeListDataTable = new dsCancellationList.EnvelopeListDataTable();
    try
    {
      if (dt is dsCancellationList.CancellationListDataTable)
      {
        try
        {
          foreach (dsCancellationList.CancellationListRow cancellationListRow in (TypedTableBase<dsCancellationList.CancellationListRow>) dt)
          {
            string printfor = cancellationListRow.printfor;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(printfor, "Insured Copy", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(printfor, "Broker Copy", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(printfor, "Retailer Copy", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(printfor, "Mortgagee Copy", false) == 0 && !Information.IsDBNull((object) cancellationListRow.mortgagee) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cancellationListRow.mortgagee.Trim(), "", false) != 0)
                  {
                    dsCancellationList.EnvelopeListRow row = envelopeListDataTable.NewEnvelopeListRow();
                    row.Address = cancellationListRow.mortgagee;
                    row.PolicyNumber = cancellationListRow.policynumber;
                    envelopeListDataTable.AddEnvelopeListRow(row);
                  }
                }
                else if (!Information.IsDBNull((object) cancellationListRow.retailer) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cancellationListRow.retailer.Trim(), "", false) != 0)
                {
                  dsCancellationList.EnvelopeListRow row = envelopeListDataTable.NewEnvelopeListRow();
                  row.Address = cancellationListRow.retailer;
                  row.PolicyNumber = cancellationListRow.policynumber;
                  envelopeListDataTable.AddEnvelopeListRow(row);
                }
              }
              else if (!Information.IsDBNull((object) cancellationListRow.producer) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cancellationListRow.producer.Trim(), "", false) != 0)
              {
                dsCancellationList.EnvelopeListRow row = envelopeListDataTable.NewEnvelopeListRow();
                row.Address = cancellationListRow.producer;
                row.PolicyNumber = cancellationListRow.policynumber;
                envelopeListDataTable.AddEnvelopeListRow(row);
              }
            }
            else if (!Information.IsDBNull((object) cancellationListRow.insured) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cancellationListRow.insured.Trim(), "", false) != 0)
            {
              dsCancellationList.EnvelopeListRow row = envelopeListDataTable.NewEnvelopeListRow();
              row.Address = cancellationListRow.insured;
              row.PolicyNumber = cancellationListRow.policynumber;
              envelopeListDataTable.AddEnvelopeListRow(row);
            }
          }
        }
        finally
        {
          IEnumerator<dsCancellationList.CancellationListRow> enumerator;
          enumerator?.Dispose();
        }
      }
      else
      {
        try
        {
          foreach (DataRow row1 in dt.Rows)
          {
            string Left = row1["copy"].ToString();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "(Mortgagee Copy)", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "(Broker Copy)", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "(Retailer Copy)", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "(Insured Copy)", false) == 0 && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(row1["Insured"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row1["Insured"].ToString().Trim(), "", false) != 0)
                  {
                    dsCancellationList.EnvelopeListRow row2 = envelopeListDataTable.NewEnvelopeListRow();
                    row2.Address = row1["Insured"].ToString();
                    row2.PolicyNumber = row1["policyNumber"].ToString();
                    envelopeListDataTable.Rows.Add((DataRow) row2);
                  }
                }
                else if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row1["Retailer"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row1["Retailer"].ToString().Trim(), "", false) != 0)
                {
                  dsCancellationList.EnvelopeListRow row3 = envelopeListDataTable.NewEnvelopeListRow();
                  row3.Address = row1["Retailer"].ToString();
                  row3.PolicyNumber = row1["policyNumber"].ToString();
                  envelopeListDataTable.Rows.Add((DataRow) row3);
                }
              }
              else if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row1["Producer"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row1["Producer"].ToString().Trim(), "", false) != 0)
              {
                dsCancellationList.EnvelopeListRow row4 = envelopeListDataTable.NewEnvelopeListRow();
                row4.Address = row1["Producer"].ToString();
                row4.PolicyNumber = row1["policyNumber"].ToString();
                envelopeListDataTable.Rows.Add((DataRow) row4);
              }
            }
            else if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row1["mortgagee"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row1["mortgagee"].ToString().Trim(), "", false) != 0)
            {
              dsCancellationList.EnvelopeListRow row5 = envelopeListDataTable.NewEnvelopeListRow();
              row5.Address = row1["mortgagee"].ToString();
              row5.PolicyNumber = row1["policyNumber"].ToString();
              envelopeListDataTable.Rows.Add((DataRow) row5);
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw new Exception("Build envelope list exception-" + ex.Message);
    }
    return envelopeListDataTable;
  }

  public static void PrintCertifiedMailStatement(
    dsCancellationList.CancellationListDataTable dt,
    string PrinterName,
    string PrinterTray,
    string Office_Location)
  {
    dsCancellationList.CertifiedMailListDataTable mailListDataTable = NoticeOfCancellation.BuildCertifiedMailList(dt, PrinterName, PrinterTray);
    SectionReport sectionReport1 = (SectionReport) new CertifiedMailStatement(Office_Location);
    try
    {
      SectionReport sectionReport2 = sectionReport1;
      sectionReport2.DataSource = (object) mailListDataTable;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(PrinterName, "", false) != 0)
      {
        sectionReport2.Document.Printer.PrinterName = PrinterName;
        sectionReport2.Document.Printer.PaperKind = PaperKind.Letter;
        if (((PrintDocument) sectionReport2.Document.Printer).PrinterSettings.CanDuplex)
          ((PrintDocument) sectionReport2.Document.Printer).PrinterSettings.Duplex = Duplex.Vertical;
        try
        {
          foreach (PaperSource paperSource in ((PrintDocument) sectionReport2.Document.Printer).PrinterSettings.PaperSources)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paperSource.SourceName, PrinterTray, false) == 0)
              ((PrintDocument) sectionReport2.Document.Printer).PrinterSettings.DefaultPageSettings.PaperSource = paperSource;
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      sectionReport2.Run();
      try
      {
        PrintExtension.Print(sectionReport2.Document, false, false, false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw new Exception("Printing Certified Mail Exception Thrown");
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw ex;
    }
    finally
    {
      sectionReport1.Dispose();
    }
  }

  private static void PrintCertifiedMailStatement(
    DataTable dt,
    string PrinterName,
    string PrinterTray,
    string Office_Location)
  {
    SectionReport sectionReport1 = (SectionReport) new CertifiedMailStatement(Office_Location);
    try
    {
      SectionReport sectionReport2 = sectionReport1;
      sectionReport2.DataSource = (object) dt;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(PrinterName.Trim(), string.Empty, false) != 0)
      {
        sectionReport2.Document.Printer.PrinterName = PrinterName;
        sectionReport2.Document.Printer.PaperKind = PaperKind.Letter;
        try
        {
          foreach (PaperSource paperSource in ((PrintDocument) sectionReport2.Document.Printer).PrinterSettings.PaperSources)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paperSource.SourceName, PrinterTray, false) == 0)
            {
              ((PrintDocument) sectionReport2.Document.Printer).PrinterSettings.DefaultPageSettings.PaperSource = paperSource;
              break;
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      sectionReport2.Run();
      PrintExtension.Print(sectionReport2.Document, false, false, false);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw ex;
    }
    finally
    {
      sectionReport1?.Dispose();
    }
  }

  private static dsCancellationList.CertifiedMailListDataTable BuildCertifiedMailList(
    dsCancellationList.CancellationListDataTable dt,
    string PrinterName,
    string PaperTray)
  {
    dsCancellationList.CancellationListRow[] cancellationListRowArray = (dsCancellationList.CancellationListRow[]) null;
    dsCancellationList.CancellationListDataTable cancellationListDataTable = (dsCancellationList.CancellationListDataTable) null;
    DataTable dataTable = new DataTable();
    dsCancellationList cancellationList = new dsCancellationList();
    int num = 0;
    int index1 = 0;
    int index2 = 0;
    SortedList certifiedMailList = NoticeOfCancellation.ParseCertifiedMailList(dt);
    try
    {
      for (; index2 < certifiedMailList.Count; ++index2)
      {
        NoticeOfCancellation.ParseObj byIndex = (NoticeOfCancellation.ParseObj) certifiedMailList.GetByIndex(index2);
        cancellationListRowArray = (dsCancellationList.CancellationListRow[]) dt.Select($"controlGuid = '{byIndex.ControlGuid.ToString()}' and quoteId = {byIndex.QuoteId}");
        if (cancellationListRowArray.Length != 0)
        {
          if (cancellationListDataTable == null)
            cancellationListDataTable = new dsCancellationList.CancellationListDataTable();
          for (; index1 < cancellationListRowArray.Length; ++index1)
          {
            dsCancellationList.CancellationListRow row = cancellationListDataTable.NewCancellationListRow();
            row.company = cancellationListRowArray[index1].company;
            row.controlGuid = cancellationListRowArray[index1].controlGuid;
            row.controlno = cancellationListRowArray[index1].controlno;
            row.duedate = cancellationListRowArray[index1].duedate;
            row.effectiveDate = cancellationListRowArray[index1].effectiveDate;
            row.expirationDate = cancellationListRowArray[index1].expirationDate;
            row.initials = cancellationListRowArray[index1].initials;
            row.insured = cancellationListRowArray[index1].insured;
            row.invoicenum = cancellationListRowArray[index1].invoicenum;
            row.line = cancellationListRowArray[index1].line;
            row.minQuoteId = cancellationListRowArray[index1].minQuoteId;
            row.mortgagee = cancellationListRowArray[index1].mortgagee;
            row.officelocation = cancellationListRowArray[index1].officelocation;
            row.policynumber = Conversions.ToString(Interaction.IIf(cancellationListRowArray[index1].policynumber.Equals((object) DBNull.Value), (object) string.Empty, (object) cancellationListRowArray[index1].policynumber));
            row.printfor = cancellationListRowArray[index1].printfor;
            row.producer = cancellationListRowArray[index1].producer;
            row.quoteid = cancellationListRowArray[index1].quoteid;
            row.receivablebalance = cancellationListRowArray[index1].receivablebalance;
            row.retailer = cancellationListRowArray[index1].retailer;
            row.stateid = cancellationListRowArray[index1].stateid;
            row.PrintNOC = cancellationListRowArray[index1].PrintNOC;
            cancellationListDataTable.Rows.Add((DataRow) row);
          }
        }
        index1 = 0;
      }
      dsCancellationList.CertifiedMailListRow certListRow = cancellationList.CertifiedMailList.NewCertifiedMailListRow();
      if (cancellationListDataTable != null && cancellationListRowArray != null)
      {
        cancellationListDataTable.DefaultView.Sort = "stateid, controlno asc";
        DataTable table = cancellationListDataTable.DefaultView.ToTable();
        cancellationListDataTable.Clear();
        cancellationListDataTable.Merge(table);
        try
        {
          foreach (dsCancellationList.CancellationListRow cancellationListRow in (TypedTableBase<dsCancellationList.CancellationListRow>) cancellationListDataTable)
          {
            string printfor = cancellationListRow.printfor;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(printfor, "Insured Copy", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(printfor, "Broker Copy", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(printfor, "Mortgagee Copy", false) != 0)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(printfor, "Retailer Copy", false) == 0 && !Information.IsDBNull((object) cancellationListRow.retailer) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cancellationListRow.retailer.Trim(), "", false) != 0)
                  {
                    NoticeOfCancellation.BuildCertifiedMailListHelper(ref certListRow, num + 1, cancellationListRow.policynumber, cancellationListRow.retailer);
                    ++num;
                    if (num == 8)
                    {
                      cancellationList.CertifiedMailList.AddCertifiedMailListRow(certListRow);
                      NoticeOfCancellation.PrintCertifiedMailStatement((DataTable) cancellationList.CertifiedMailList, PrinterName, PaperTray, cancellationListRowArray[0].officelocation.ToString());
                      cancellationList.Clear();
                      certListRow = cancellationList.CertifiedMailList.NewCertifiedMailListRow();
                      num = 0;
                    }
                  }
                }
                else if (!Information.IsDBNull((object) cancellationListRow.mortgagee) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cancellationListRow.mortgagee.Trim(), "", false) != 0)
                {
                  NoticeOfCancellation.BuildCertifiedMailListHelper(ref certListRow, num + 1, cancellationListRow.policynumber, cancellationListRow.mortgagee);
                  ++num;
                  if (num == 8)
                  {
                    cancellationList.CertifiedMailList.AddCertifiedMailListRow(certListRow);
                    NoticeOfCancellation.PrintCertifiedMailStatement((DataTable) cancellationList.CertifiedMailList, PrinterName, PaperTray, cancellationListRowArray[0].officelocation.ToString());
                    cancellationList.Clear();
                    certListRow = cancellationList.CertifiedMailList.NewCertifiedMailListRow();
                    num = 0;
                  }
                }
              }
              else if (MGASystems.Common.SystemSettings.KeyExists("NocCertifiedMailPrintBrokerCopy") && MGASystems.Common.SystemSettings.GetBoolSetting("NocCertifiedMailPrintBrokerCopy") && !Information.IsDBNull((object) cancellationListRow.producer) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cancellationListRow.producer.Trim(), "", false) != 0)
              {
                NoticeOfCancellation.BuildCertifiedMailListHelper(ref certListRow, num + 1, cancellationListRow.policynumber, cancellationListRow.producer);
                ++num;
                if (num == 8)
                {
                  cancellationList.CertifiedMailList.AddCertifiedMailListRow(certListRow);
                  NoticeOfCancellation.PrintCertifiedMailStatement((DataTable) cancellationList.CertifiedMailList, PrinterName, PaperTray, cancellationListRowArray[0].officelocation.ToString());
                  cancellationList.Clear();
                  certListRow = cancellationList.CertifiedMailList.NewCertifiedMailListRow();
                  num = 0;
                }
              }
            }
            else if (!Information.IsDBNull((object) cancellationListRow.insured) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cancellationListRow.insured.Trim(), "", false) != 0)
            {
              NoticeOfCancellation.BuildCertifiedMailListHelper(ref certListRow, num + 1, cancellationListRow.policynumber, cancellationListRow.insured);
              ++num;
              if (num == 8)
              {
                cancellationList.CertifiedMailList.AddCertifiedMailListRow(certListRow);
                NoticeOfCancellation.PrintCertifiedMailStatement((DataTable) cancellationList.CertifiedMailList, PrinterName, PaperTray, cancellationListRowArray[0].officelocation.ToString());
                cancellationList.Clear();
                certListRow = cancellationList.CertifiedMailList.NewCertifiedMailListRow();
                num = 0;
              }
            }
          }
        }
        finally
        {
          IEnumerator<dsCancellationList.CancellationListRow> enumerator;
          enumerator?.Dispose();
        }
      }
      if (num != 8)
        cancellationList.CertifiedMailList.AddCertifiedMailListRow(certListRow);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw ex;
    }
    return cancellationList.CertifiedMailList;
  }

  private static void BuildCertifiedMailListHelper(
    ref dsCancellationList.CertifiedMailListRow certListRow,
    int x,
    string PolicyNumber,
    string Address)
  {
    switch (x)
    {
      case 1:
        certListRow.articlenum1 = PolicyNumber;
        certListRow.address1 = Address;
        break;
      case 2:
        certListRow.articlenum2 = PolicyNumber;
        certListRow.address2 = Address;
        break;
      case 3:
        certListRow.articlenum3 = PolicyNumber;
        certListRow.address3 = Address;
        break;
      case 4:
        certListRow.articlenum4 = PolicyNumber;
        certListRow.address4 = Address;
        break;
      case 5:
        certListRow.articlenum5 = PolicyNumber;
        certListRow.address5 = Address;
        break;
      case 6:
        certListRow.articlenum6 = PolicyNumber;
        certListRow.address6 = Address;
        break;
      case 7:
        certListRow.articlenum7 = PolicyNumber;
        certListRow.address7 = Address;
        break;
      case 8:
        certListRow.articlenum8 = PolicyNumber;
        certListRow.address8 = Address;
        break;
    }
  }

  private static SortedList ParseCertifiedMailList(dsCancellationList.CancellationListDataTable dt)
  {
    SortedList certifiedMailList = new SortedList();
    try
    {
      foreach (dsCancellationList.CancellationListRow cancellationListRow in (TypedTableBase<dsCancellationList.CancellationListRow>) dt)
      {
        if (cancellationListRow.PrintNOC && !certifiedMailList.ContainsKey((object) cancellationListRow.controlGuid))
        {
          NoticeOfCancellation.ParseObj parseObj = new NoticeOfCancellation.ParseObj(new Guid(cancellationListRow.controlGuid.ToString()), cancellationListRow.minQuoteId, cancellationListRow.policynumber.ToString());
          certifiedMailList.Add((object) parseObj.ControlGuid.ToString(), (object) parseObj);
        }
      }
    }
    finally
    {
      IEnumerator<dsCancellationList.CancellationListRow> enumerator;
      enumerator?.Dispose();
    }
    return certifiedMailList;
  }

  public static string GetNOCType(Guid companylineGuid, string connectionString)
  {
    if (string.IsNullOrEmpty(DefaultDatabase.ConnectionString))
      DefaultDatabase.ConnectionString = connectionString;
    return Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("spFin_GetNOCFormOverride", new object[2]
    {
      (object) "@CompanyLineGuid",
      (object) companylineGuid
    })), string.Empty);
  }

  public class ParseObj
  {
    private Guid _controlGuid;
    private int _quoteId;
    private string _policyNumber;

    private ParseObj()
    {
    }

    public ParseObj(Guid ControlGuid, int QuoteId, string PolicyNumber)
    {
      this._controlGuid = ControlGuid;
      this._quoteId = QuoteId;
      this._policyNumber = PolicyNumber;
    }

    public Guid ControlGuid => this._controlGuid;

    public int QuoteId => this._quoteId;

    public string PolicyNumber => this._policyNumber;
  }
}

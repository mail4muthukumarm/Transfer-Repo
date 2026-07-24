// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.PolicyServices.NoticeOfCancellation
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using CancellationNotices;
using GrapeCity.ActiveReports;
using MGASystems.Common;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.NoteDocuments;
using System;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Accounting.PolicyServices;

public class NoticeOfCancellation
{
  public static NoticeOfCancellationInstance Instance = ObjectFactory.Instance.CreateObjectAs<NoticeOfCancellationInstance>();

  public static bool PrintCancellationNotices(
    string SQLConnectionString,
    int QuoteID,
    int OfficeLocationId,
    string PrinterName,
    string PaperTray,
    string Description)
  {
    return NoticeOfCancellation.Instance.PrintCancellationNotices(SQLConnectionString, QuoteID, OfficeLocationId, PrinterName, PaperTray, Description);
  }

  public static bool PrintCancellationNotices(
    string SQLConnectionString,
    int QuoteID,
    int OfficeLocationId,
    DateTime EffectiveDate,
    int ReasonID,
    DateTime MailingDate,
    string PrinterName,
    string PaperTray,
    string Description)
  {
    return NoticeOfCancellation.Instance.PrintCancellationNotices(SQLConnectionString, QuoteID, OfficeLocationId, EffectiveDate, ReasonID, MailingDate, PrinterName, PaperTray, Description);
  }

  public static bool PrintCancellationNotices(
    string SQLConnectionString,
    int QuoteID,
    int OfficeLocationId,
    string PrinterName,
    string PaperTray)
  {
    return NoticeOfCancellation.Instance.PrintCancellationNotices(SQLConnectionString, QuoteID, OfficeLocationId, PrinterName, PaperTray);
  }

  public static bool PrintCancellationNotices(
    string SQLConnectionString,
    int QuoteID,
    int OfficeLocationId,
    DateTime EffectiveDate,
    int ReasonID,
    DateTime MailingDate,
    string PrinterName,
    string PaperTray)
  {
    return NoticeOfCancellation.Instance.PrintCancellationNotices(SQLConnectionString, QuoteID, OfficeLocationId, EffectiveDate, ReasonID, MailingDate, PrinterName, PaperTray);
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
    NoticeOfCancellation.Instance.PrintCancellationNotices(rpt, dt, PrinterName, PaperTray, userName, Password, UserGuid, DocumentServiceURL, LogonServiceURL, AddToDocumentHandler, printedFromAutomation, sendToPrinter);
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

  private static void LogNOCIssuance(SqlCommand cmd, dsCancellationList ds)
  {
    NoticeOfCancellation.Instance.LogNOCIssuance(ds.CancellationList);
  }

  private static void LogNOCIssuance(dsCancellationList.CancellationListDataTable dt)
  {
    NoticeOfCancellation.Instance.LogNOCIssuance(dt);
  }

  protected static void PrintNotices(
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
    NoticeOfCancellation.Instance.PrintNotices(rpt, dt, printerName, paperTray, userName, password, userGuid, rptEnvelope, envelopePrinterName, envelopePrinterTray, documentServiceURL, logonServiceURL, addToDocumentHandler, printedFromAutomation, sendToPrinter, -1);
  }

  protected static void PrintNotices(
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
    NoticeOfCancellation.Instance.PrintNotices(rpt, dt, printerName, paperTray, rptEnvelope, envelopePrinterName, envelopePrinterTray, addToDocumentHandler, printedFromAutomation, sendToPrinter, entity, documentFolderId);
  }

  protected static void PrintNotices(
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
    NoticeOfCancellation.Instance.PrintNotices(rpt, dt, printerName, paperTray, userName, password, userGuid, rptEnvelope, envelopePrinterName, envelopePrinterTray, documentServiceURL, logonServiceURL, addToDocumentHandler, printedFromAutomation, sendToPrinter, documentFolderId);
  }
}

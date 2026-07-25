// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportFactory
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using MGASystems.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

public sealed class ReportFactory : IReportManager
{
  private static ReportFactory _reportFactory = (ReportFactory) null;

  public static ReportFactory Instance
  {
    get
    {
      if (ReportFactory._reportFactory == null)
        ReportFactory._reportFactory = new ReportFactory();
      return ReportFactory._reportFactory;
    }
  }

  public void PrintReport(SectionReport rpt) => PrintExtension.Print(rpt.Document, false, false);

  public void ShowReport(bool showAsDialog, Type reportType, params object[] args)
  {
    SectionReport objectEx = (SectionReport) ObjectFactory.Instance.CreateObjectEX(reportType, args);
    objectEx.Run();
    this.ShowReport(objectEx, showAsDialog);
  }

  public void ShowReport(SectionReport rpt) => this.ShowReport(rpt, false);

  public void ShowReport(SectionReport rpt, bool showAsDialog)
  {
    CurrentUser.Instance.LogAction($"Ran {frmPrint.FormatReportName(rpt)} Report");
    frmPrint frmPrint = new frmPrint(rpt);
    frmPrint.ShowInTaskbar = false;
    if (showAsDialog)
    {
      int num = (int) frmPrint.ShowDialog();
      frmPrint.Dispose();
    }
    else
    {
      frmPrint.MdiParent = MDIControls.Instance.MDIParent;
      frmPrint.Show();
    }
  }

  public void ShowThirdPartyReport(bool showAsDialog, Type reportType, params object[] args)
  {
    this.ShowThirdPartyReport((ThirdPartyReport) ObjectFactory.Instance.CreateObjectEX(reportType, args), showAsDialog);
  }

  public void ShowThirdPartyReport(ThirdPartyReport rpt) => this.ShowThirdPartyReport(rpt, false);

  public void ShowThirdPartyReport(ThirdPartyReport rpt, bool showAsDialog)
  {
    CurrentUser.Instance.LogAction($"Ran {rpt.Text} Report");
    rpt.ShowInTaskbar = false;
    if (showAsDialog)
    {
      int num = (int) rpt.ShowDialog();
      rpt.Dispose();
    }
    else
    {
      rpt.MdiParent = MDIControls.Instance.MDIParent;
      rpt.Show();
      rpt = (ThirdPartyReport) null;
    }
  }

  public void ExportReport(Type reportType, params object[] args)
  {
    if (ObjectFactory.Instance.CreateObjectEX(reportType, args) is MGAExcelReport objectEx)
    {
      objectEx.Run();
      if (objectEx.HasRecords)
      {
        objectEx.Export();
      }
      else
      {
        int num = (int) MessageBox.Show("No results found", "No Results");
      }
    }
    else
    {
      int num1 = (int) MessageBox.Show("This is not an excel exportable report", "Can't export to Excel");
    }
  }

  public string ExportReportPDF(Type reportType, string filename, params object[] args)
  {
    string str1;
    if (ObjectFactory.Instance.CreateObjectEX(reportType, args) is MGAReport objectEx)
    {
      objectEx.Run();
      PdfExport pdfExport = new PdfExport();
      if (string.IsNullOrEmpty(filename))
        filename = Regex.Replace($"{reportType.Name}{string.Join("", args)}", $"[{new string(Path.GetInvalidPathChars())}:]", "") + ".pdf";
      else if (!Path.HasExtension(filename))
        filename += ".pdf";
      filename = Path.Combine(MGATempFolder.MGATempPath, filename);
      SectionDocument document = objectEx.Document;
      string str2 = filename;
      pdfExport.Export(document, str2);
      str1 = filename;
    }
    else
    {
      if (!Environment.UserInteractive)
        throw new InvalidOperationException("Unable to export a non-MGA report to PDF");
      int num = (int) MessageBox.Show("This is not an MGA report", "Can't export to PDF");
      str1 = (string) null;
    }
    return str1;
  }

  public void ShowInvoices(int invoiceNumber)
  {
    ArrayList @params = new ArrayList();
    this.ShowInvoices(invoiceNumber, @params);
  }

  public void ShowInvoices(int invoiceNumber, ArrayList @params)
  {
    this.ShowInvoices(new List<int>() { invoiceNumber }, @params);
  }

  public void ShowInvoices(List<int> invoiceNumbers, ArrayList @params)
  {
    InvoiceItem[] invoices = new InvoiceItem[invoiceNumbers.Count - 1 + 1];
    int num = invoiceNumbers.Count - 1;
    for (int index = 0; index <= num; ++index)
      invoices[index] = new InvoiceItem(invoiceNumbers[index], @params);
    this.ShowInvoices(invoices);
  }

  public void ShowInvoices(InvoiceItem[] invoices)
  {
    new InvoiceGeneration().ShowInvoices(invoices);
  }

  public void ShowInvoices(int invoiceNumber, SectionReport rpt)
  {
    this.ShowInvoices(new List<int>() { invoiceNumber }, rpt);
  }

  public void ShowInvoices(List<int> invoiceNumbers, SectionReport rpt)
  {
    frmPrint frmPrint = new frmPrint(rpt);
    frmPrint.IssueInvoices = true;
    frmPrint.InvoiceNumbers = invoiceNumbers;
    frmPrint.MdiParent = MDIControls.Instance.MDIParent;
    frmPrint.ShowInTaskbar = false;
    frmPrint.Show();
  }

  public void PrintInvoices(int invoiceNumber, ArrayList @params)
  {
    this.PrintInvoices(new InvoiceItem[1]
    {
      new InvoiceItem(invoiceNumber, @params)
    });
  }

  public void PrintInvoices(int invoiceNumber, SectionReport rpt)
  {
    this.PrintInvoices(new List<int>() { invoiceNumber }, rpt);
  }

  public void PrintInvoices(int[] invoiceNumbers, ArrayList @params)
  {
    InvoiceItem[] invoices = new InvoiceItem[invoiceNumbers.Length - 1 + 1];
    int num = invoiceNumbers.Length - 1;
    for (int index = 0; index <= num; ++index)
      invoices[index] = new InvoiceItem(invoiceNumbers[index], @params);
    this.PrintInvoices(invoices);
  }

  public void PrintInvoices(List<int> invoiceNumbers, ArrayList @params)
  {
    InvoiceItem[] invoices = new InvoiceItem[invoiceNumbers.Count - 1 + 1];
    int num = invoiceNumbers.Count - 1;
    for (int index = 0; index <= num; ++index)
      invoices[index] = new InvoiceItem(invoiceNumbers[index], @params);
    this.PrintInvoices(invoices);
  }

  public void PrintInvoices(List<int> invoiceNumbers, SectionReport rpt)
  {
    InvoiceItem[] Invoices = new InvoiceItem[invoiceNumbers.Count - 1 + 1];
    int num = invoiceNumbers.Count - 1;
    for (int index = 0; index <= num; ++index)
      Invoices[index] = new InvoiceItem(invoiceNumbers[index]);
    new InvoiceGeneration().PrintInvoicesFromPregeneratedReport(Invoices, rpt);
  }

  public void PrintInvoices(InvoiceItem[] invoices) => this.PrintInvoices(invoices, true);

  public void PrintInvoices(InvoiceItem[] invoices, bool sendBroadcastMessage)
  {
    new InvoiceGeneration().GenerateAndPrintInvoices(invoices, sendBroadcastMessage);
  }

  public void PrintInvoices(InvoiceItem[] invoices, bool sendBroadcastMessage, int DocFolderID)
  {
    new InvoiceGeneration().GenerateAndPrintInvoices(invoices, sendBroadcastMessage, DocFolderID);
  }

  public void SaveInvoicesPDF(InvoiceItem[] invoices, string FilePath, int DocFolderID)
  {
    new InvoiceGeneration().GenerateAndSaveInvoicesPDF(invoices, true, FilePath, DocFolderID);
  }

  public SectionReport QueryReport(string reportName, params object[] args)
  {
    Type typeFromString = ObjectFactory.Instance.CreateTypeFromString($"MGASystems.IMS.Reporting.{reportName}");
    if ((object) typeFromString == null)
      typeFromString = ObjectFactory.Instance.CreateTypeFromString(reportName);
    SectionReport sectionReport;
    if ((object) typeFromString != null)
    {
      object objectValue = RuntimeHelpers.GetObjectValue(ObjectFactory.Instance.CreateObject(typeFromString, args));
      sectionReport = objectValue != null ? (SectionReport) objectValue : (SectionReport) null;
    }
    else
      sectionReport = (SectionReport) null;
    return sectionReport;
  }
}

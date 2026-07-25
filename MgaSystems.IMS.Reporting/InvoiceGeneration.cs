// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.InvoiceGeneration
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

public sealed class InvoiceGeneration
{
  private InvoiceItem[] _invoices;
  private SectionReport _currentReport;
  private frmPrint _frmPrintForCurrentReport;

  private void DisplayInvoiceOnPrintForm(SectionReport rpt)
  {
    if (this._frmPrintForCurrentReport == null)
      return;
    if (this._frmPrintForCurrentReport.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new InvoiceGeneration.DisplayInvoiceOnPrintFormHandler(this.DisplayInvoiceOnPrintForm), (object) rpt);
    }
    else
    {
      try
      {
        this._frmPrintForCurrentReport.HideWaitMessage();
        this._frmPrintForCurrentReport.Report = rpt;
        this._frmPrintForCurrentReport.ShowReport();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.HandleError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void CreateInvoicesForPrintForm(object state)
  {
    SectionReport sectionReport = new SectionReport();
    sectionReport.Document.Name = "Invoices";
    try
    {
      int num = this._invoices.Length - 1;
      for (int index = 0; index <= num; ++index)
      {
        Invoice invoice = new Invoice(this._invoices[index].InvoiceNumber);
        sectionReport.Document.Pages.AddRange(invoice.Report(this._invoices[index].Params).Document.Pages);
      }
      MDIControls.Instance.MDIParent.Invoke((Delegate) new InvoiceGeneration.DisplayInvoiceOnPrintFormHandler(this.DisplayInvoiceOnPrintForm), (object) sectionReport);
    }
    catch (WebServiceLogonFailedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.SilentHandleError((Exception) ex);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show("The server was unable to create an invoice.\n\nThe web service logon failed.", "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    catch (ArgumentNullException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.SilentHandleError((Exception) ex);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show("The server was unable to create an invoice.", "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    catch (WebException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.SilentHandleError((Exception) ex);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show(SR.GetString("REPORTFACTORY_INVOICE_GENERATION_ERROR"), "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    catch (SoapException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      SoapException ex2 = ex1;
      ErrorHandler.SilentHandleError((Exception) ex2);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show(SR.GetString("REPORTFACTORY_INVOICE_GENERATION_ERROR"), $"Invoice Error: {ex2.Code.Name}", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    catch (InvalidOperationException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.SilentHandleError((Exception) ex);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show(SR.GetString("REPORTFACTORY_INVOICE_GENERATION_ERROR"), "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
  }

  private void PrintInvoicesFromPregeneratedReport(object state)
  {
    ReportFactory.Instance.PrintReport(this._currentReport);
    MDIControls.Instance.MDIParent.Invoke((Delegate) new InvoiceGeneration.MarkInvoicesAsPrintedHandler(this.MarkInvoicesAsPrinted));
  }

  private void GenerateAndPrintInvoices(object state)
  {
    SectionReport rpt = new SectionReport();
    bool flag = (bool) state;
    try
    {
      try
      {
        int num = this._invoices.Length - 1;
        for (int index = 0; index <= num; ++index)
        {
          Invoice invoice = new Invoice(this._invoices[index].InvoiceNumber);
          try
          {
            rpt.Document.Pages.AddRange(invoice.Report(this._invoices[index].Params).Document.Pages);
            if (flag)
              Messaging.SendBroadcastMessage(BroadcastMessages.InvoicePrinted, (object) invoice.InvoiceNum);
          }
          catch (InvalidOperationException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            MGASystems.Common.ThreadingFunctions.MessageBox.Show("An error occured while trying to generate an invoice:\n\nThe invoicing webservice is down.", "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            ProjectData.ClearProjectError();
          }
        }
      }
      catch (WebServiceLogonFailedException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MGASystems.Common.ThreadingFunctions.MessageBox.Show("Logon to the invoicing webservice failed.", "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
        return;
      }
      catch (ArgumentNullException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MGASystems.Common.ThreadingFunctions.MessageBox.Show("An error occured while trying to generate an invoice.", "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
        return;
      }
      ReportFactory.Instance.PrintReport(rpt);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show("Selected Invoices were successfully sent to printer.", "Invoice Printing Done.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    catch (WebException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show("An error occured while trying to generate an invoice.", "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    finally
    {
      rpt.Dispose();
    }
  }

  private void GenerateAndPrintInvoicesDocFolder(object sender, DoWorkEventArgs e)
  {
    object[] objArray = (object[]) e.Argument;
    bool flag = (bool) objArray[0];
    int folderId = (int) objArray[1];
    InvoiceItem[] invoiceItemArray = (InvoiceItem[]) objArray[2];
    SectionReport rpt = new SectionReport();
    try
    {
      try
      {
        int num = this._invoices.Length - 1;
        for (int index = 0; index <= num; ++index)
        {
          Invoice inv = new Invoice(invoiceItemArray[index].InvoiceNumber);
          try
          {
            string path = Path.GetTempPath() + Conversions.ToString(Path.DirectorySeparatorChar) + this.GenInvoiceFileName(inv);
            PdfExport pdfExport = new PdfExport();
            MemoryStream memoryStream1 = new MemoryStream();
            SectionDocument document = inv.Report(invoiceItemArray[index].Params).Document;
            MemoryStream memoryStream2 = memoryStream1;
            pdfExport.Export(document, (Stream) memoryStream2);
            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
              memoryStream1.WriteTo((Stream) fileStream);
              fileStream.Write(memoryStream1.ToArray(), 0, (int) memoryStream1.Position);
            }
            if (folderId >= 0)
              DocumentManager.BeginFileAddWithBind(path, folderId, "Invoice", (ISupportDocumentSystem) inv.Quote, true);
            rpt.Document.Pages.AddRange(inv.Report(this._invoices[index].Params).Document.Pages);
            if (flag)
              Messaging.SendBroadcastMessage(BroadcastMessages.InvoicePrinted, (object) inv.InvoiceNum);
          }
          catch (InvalidOperationException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            MGASystems.Common.ThreadingFunctions.MessageBox.Show("An error occured while trying to generate an invoice:\n\nThe invoicing webservice is down.", "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            ProjectData.ClearProjectError();
          }
        }
      }
      catch (WebServiceLogonFailedException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MGASystems.Common.ThreadingFunctions.MessageBox.Show("Logon to the invoicing webservice failed.", "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
        return;
      }
      catch (ArgumentNullException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MGASystems.Common.ThreadingFunctions.MessageBox.Show("An error occured while trying to generate an invoice.", "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
        return;
      }
      ReportFactory.Instance.PrintReport(rpt);
    }
    catch (WebException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show("An error occured while trying to generate an invoice.", "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    finally
    {
      rpt.Dispose();
    }
  }

  private string GenInvoiceFileName(Invoice inv)
  {
    int num = inv.OfficeInvoiceNum;
    string str1 = num.ToString() + "-";
    num = inv.Quote.ControlNo;
    string str2 = num.ToString();
    return $"{$"{str1}{str2}-"}{Strings.Format((object) DateAndTime.Now, "yyyyMMddhhmmss")}.pdf";
  }

  private void MarkInvoicesAsPrinted()
  {
    int num = this._invoices.Length - 1;
    for (int index = 0; index <= num; ++index)
      Messaging.SendBroadcastMessage(BroadcastMessages.InvoicePrinted, (object) this._invoices[index].InvoiceNumber);
  }

  public void GenerateAndPrintInvoices(InvoiceItem[] invoices, bool sendBroadcastMessage)
  {
    this._invoices = invoices;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.GenerateAndPrintInvoices), (object) sendBroadcastMessage);
  }

  public void GenerateAndPrintInvoices(
    InvoiceItem[] invoices,
    bool sendBroadcastMessage,
    int DocFolderID)
  {
    this._invoices = invoices;
    Utility.ExecuteThread((object) new object[3]
    {
      (object) sendBroadcastMessage,
      (object) DocFolderID,
      (object) invoices
    }, new DoWorkEventHandler(this.GenerateAndPrintInvoicesDocFolder), new RunWorkerCompletedEventHandler(this.GenerateAndPrintInvoicesDocFolderDone), (ProgressChangedEventHandler) null);
  }

  private void GenerateAndPrintInvoicesDocFolderDone(object sender, RunWorkerCompletedEventArgs e)
  {
    MGASystems.Common.ThreadingFunctions.MessageBox.Show("Selected Invoices were successfully sent to printer.", "Invoice Printing Done.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  public void GenerateAndPrintInvoices(InvoiceItem[] invoices)
  {
    this.GenerateAndPrintInvoices(invoices, true);
  }

  public void GenerateAndSaveInvoicesPDF(
    InvoiceItem[] invoices,
    bool sendBroadcastMessage,
    string FilePath,
    int DocFolderID)
  {
    this._invoices = invoices;
    Utility.ExecuteThread((object) new object[4]
    {
      (object) sendBroadcastMessage,
      (object) FilePath,
      (object) DocFolderID,
      (object) invoices
    }, new DoWorkEventHandler(this.GenerateAndSaveInvoicesPDF), new RunWorkerCompletedEventHandler(this.GenerateAndSaveInvoicesPDFDone), (ProgressChangedEventHandler) null);
  }

  private void GenerateAndSaveInvoicesPDFDone(object sender, RunWorkerCompletedEventArgs e)
  {
    MGASystems.Common.ThreadingFunctions.MessageBox.Show("Selected Invoices were successfully exported to PDF files.", "Invoice Export Done.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  private void GenerateAndSaveInvoicesPDF(object sender, DoWorkEventArgs e)
  {
    object[] objArray = (object[]) e.Argument;
    bool flag = (bool) objArray[0];
    string str = (string) objArray[1];
    int folderId = (int) objArray[2];
    InvoiceItem[] invoiceItemArray = (InvoiceItem[]) objArray[3];
    SectionReport sectionReport = new SectionReport();
    try
    {
      try
      {
        int num = this._invoices.Length - 1;
        for (int index = 0; index <= num; ++index)
        {
          Invoice inv = new Invoice(invoiceItemArray[index].InvoiceNumber);
          string path = str + Conversions.ToString(Path.DirectorySeparatorChar) + this.GenInvoiceFileName(inv);
          try
          {
            PdfExport pdfExport = new PdfExport();
            MemoryStream memoryStream1 = new MemoryStream();
            SectionDocument document = inv.Report(invoiceItemArray[index].Params).Document;
            MemoryStream memoryStream2 = memoryStream1;
            pdfExport.Export(document, (Stream) memoryStream2);
            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
              memoryStream1.WriteTo((Stream) fileStream);
              fileStream.Write(memoryStream1.ToArray(), 0, (int) memoryStream1.Position);
            }
            if (folderId >= 0)
              DocumentManager.BeginFileAddWithBind(path, folderId, "Invoice", (ISupportDocumentSystem) inv.Quote);
            if (flag)
              Messaging.SendBroadcastMessage(BroadcastMessages.InvoicePrinted, (object) inv.InvoiceNum);
          }
          catch (InvalidOperationException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            MGASystems.Common.ThreadingFunctions.MessageBox.Show("An error occured while trying to generate an invoice:\n\nThe invoicing webservice is down.", "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            ProjectData.ClearProjectError();
          }
        }
      }
      catch (WebServiceLogonFailedException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MGASystems.Common.ThreadingFunctions.MessageBox.Show("Logon to the invoicing webservice failed.", "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
      catch (ArgumentNullException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MGASystems.Common.ThreadingFunctions.MessageBox.Show("An error occured while trying to generate an invoice.", "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
    }
    catch (WebException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show("An error occured while trying to generate an invoice.", "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    finally
    {
      sectionReport.Dispose();
    }
  }

  public void PrintInvoicesFromPregeneratedReport(InvoiceItem[] Invoices, SectionReport rpt)
  {
    this._invoices = Invoices;
    this._currentReport = rpt;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.PrintInvoicesFromPregeneratedReport));
  }

  public void ShowInvoices(InvoiceItem[] invoices) => this.ShowInvoices(invoices, true);

  public void ShowInvoices(InvoiceItem[] invoices, bool issueInvoices)
  {
    List<int> intList = new List<int>();
    int num = invoices.Length - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (!intList.Contains(invoices[index].InvoiceNumber))
        intList.Add(invoices[index].InvoiceNumber);
    }
    this._frmPrintForCurrentReport = new frmPrint();
    frmPrint forCurrentReport = this._frmPrintForCurrentReport;
    forCurrentReport.MdiParent = MDIControls.Instance.MDIParent;
    forCurrentReport.IssueInvoices = issueInvoices;
    forCurrentReport.InvoiceNumbers = intList;
    forCurrentReport.WaitMessage = "Generating Invoices...";
    forCurrentReport.ShowWaitMessage();
    forCurrentReport.Show();
    this._invoices = invoices;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.CreateInvoicesForPrintForm));
  }

  private delegate void DisplayInvoiceOnPrintFormHandler(SectionReport rpt);

  private delegate void MarkInvoicesAsPrintedHandler();
}

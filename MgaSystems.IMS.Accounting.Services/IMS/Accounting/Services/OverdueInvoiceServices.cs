// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.OverdueInvoiceServices
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using GrapeCity.ActiveReports.Export.Pdf.Section;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Services.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

#nullable disable
namespace MGASystems.IMS.Accounting.Services;

public class OverdueInvoiceServices
{
  private dsOverdueInvoices _overdueInvoices;
  private DateTime? _datefrom;
  private DateTime? _dateTo;

  public OverdueInvoiceServices() => this.InitializeObject();

  public OverdueInvoiceServices(DateTime? dateFrom, DateTime? dateTo)
  {
    this._datefrom = dateFrom;
    this._dateTo = dateTo;
    this.InitializeObject();
  }

  public dsOverdueInvoices OverdueInvoices => this._overdueInvoices;

  public DateTime? DateFrom
  {
    get => this._datefrom;
    set => this._datefrom = value;
  }

  public DateTime? DateTo
  {
    get => this._dateTo;
    set => this._dateTo = value;
  }

  protected virtual void InitializeObject()
  {
    this._overdueInvoices = new dsOverdueInvoices();
    this.LoadOverdueInvoices();
  }

  protected virtual string GetProcedureName() => "spFin_OverdueInvoices";

  protected virtual void LoadOverdueInvoices()
  {
    if (this._datefrom.HasValue && this._dateTo.HasValue)
      DefaultDatabase.LoadDataSet((DataSet) this._overdueInvoices, new string[2]
      {
        "Remitters",
        "Invoices"
      }, this.GetProcedureName(), new object[4]
      {
        (object) "@DateFrom",
        (object) this._datefrom.Value,
        (object) "@DateTo",
        (object) this._dateTo.Value
      });
    else
      DefaultDatabase.LoadDataSet((DataSet) this._overdueInvoices, new string[2]
      {
        "Remitters",
        "Invoices"
      }, this.GetProcedureName());
  }

  public virtual void ProcessEmail(
    string emailSubject,
    string emailHeader,
    dsOverdueInvoices data,
    string emailFooter,
    List<string> invoiceFieldListing)
  {
    this.ProcessEmail(emailSubject, emailHeader, (DataSet) data, emailFooter, invoiceFieldListing);
  }

  public virtual void ProcessEmail(
    string emailSubject,
    string emailHeader,
    DataSet data,
    string emailFooter,
    List<string> invoiceFieldListing)
  {
    bool flag = false;
    if (SystemSettings.KeyExists("OVERDUE_ATTACHINVOICE") && SystemSettings.GetBoolSetting("OVERDUE_ATTACHINVOICE"))
      flag = true;
    foreach (DataRow row in (InternalDataCollectionBase) data.Tables[0].Rows)
    {
      string emailTo = row.Field<string>("ContactEmail");
      if (CurrentUser.UsingOutlook)
      {
        List<string> recipients = new List<string>()
        {
          emailTo
        };
        if (flag)
        {
          string tempSubdirectory = MGATempFolder.CreateTempSubdirectory();
          SMTP_Email.SendUsingOutlook(this.GetInvoiceAttachments(row.GetChildRows(data.Relations[0]), tempSubdirectory), recipients, emailSubject, this.BuildEmailBody(emailHeader, emailFooter, invoiceFieldListing, row.GetChildRows(data.Relations[0])), (List<string>) null, SMTP_Email.ShowOrSend.Send);
          this.DeleteTempInvoices(tempSubdirectory);
        }
        else
          SMTP_Email.SendUsingOutlook((List<string>) null, recipients, emailSubject, this.BuildEmailBody(emailHeader, emailFooter, invoiceFieldListing, row.GetChildRows(data.Relations[0])), (List<string>) null, SMTP_Email.ShowOrSend.Send);
      }
      else
        SMTP_Email.SendMailEx(emailTo, emailSubject, this.BuildEmailBody(emailHeader, emailFooter, invoiceFieldListing, row.GetChildRows(data.Relations[0])), true);
    }
  }

  protected virtual string BuildEmailBody(
    string emailHeader,
    string emailFooter,
    List<string> invoiceFieldListing,
    DataRow[] invoiceRows)
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(EmailBodyUtility.ReplaceCarriageReturnsIfHtml(emailHeader));
    EmailBodyUtility.AppendCarriageReturn(ref stringBuilder, 2);
    for (int invoiceRowIndex = 0; invoiceRowIndex < invoiceRows.Length; ++invoiceRowIndex)
    {
      EmailBodyUtility.AppendCarriageReturn(ref stringBuilder, 1);
      this.BuildInvoiceFields(invoiceFieldListing, invoiceRows, invoiceRowIndex, ref stringBuilder);
    }
    EmailBodyUtility.AppendCarriageReturn(ref stringBuilder, 2);
    stringBuilder.Append(EmailBodyUtility.ReplaceCarriageReturnsIfHtml(emailFooter));
    return stringBuilder.ToString();
  }

  protected virtual StringBuilder BuildInvoiceFields(
    List<string> invoiceFieldListing,
    DataRow[] invoiceRows,
    int invoiceRowIndex,
    ref StringBuilder invoiceFieldStringBuilder)
  {
    foreach (string str in invoiceFieldListing)
    {
      invoiceFieldStringBuilder.Append(str + ":");
      EmailBodyUtility.AppendTabs(ref invoiceFieldStringBuilder);
      switch (str)
      {
        case "Invoice #":
          invoiceFieldStringBuilder.Append(invoiceRows[invoiceRowIndex].Field<string>("OfficeInvoiceNum").PadRight(str.Length));
          EmailBodyUtility.AppendCarriageReturn(ref invoiceFieldStringBuilder, 1);
          continue;
        case "Policy #":
          invoiceFieldStringBuilder.Append(invoiceRows[invoiceRowIndex].Field<string>("PolicyNumber"));
          EmailBodyUtility.AppendCarriageReturn(ref invoiceFieldStringBuilder, 1);
          continue;
        case "Insured":
          invoiceFieldStringBuilder.Append(invoiceRows[invoiceRowIndex].Field<string>("InsuredPolicyName"));
          EmailBodyUtility.AppendCarriageReturn(ref invoiceFieldStringBuilder, 1);
          continue;
        case "Amount":
          invoiceFieldStringBuilder.Append(invoiceRows[invoiceRowIndex].Field<Decimal>("Amount").ToString("c"));
          EmailBodyUtility.AppendCarriageReturn(ref invoiceFieldStringBuilder, 1);
          continue;
        case "Due Date":
          invoiceFieldStringBuilder.Append(invoiceRows[invoiceRowIndex].Field<DateTime>("DueDate").ToString("d"));
          EmailBodyUtility.AppendCarriageReturn(ref invoiceFieldStringBuilder, 1);
          continue;
        default:
          continue;
      }
    }
    return invoiceFieldStringBuilder;
  }

  private List<string> GetInvoiceAttachments(DataRow[] invoices, string path)
  {
    PdfExport pdfExport = new PdfExport();
    List<string> invoiceAttachments = new List<string>();
    for (int index = 0; index < invoices.Length; ++index)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(path);
      stringBuilder.Append(invoices[index].Field<string>("OfficeInvoiceNum"));
      stringBuilder.Append(".pdf");
      Invoice invoice = new Invoice(invoices[index].Field<int>("InvoiceNum"));
      pdfExport.Export(invoice.Report().Document, stringBuilder.ToString());
      invoiceAttachments.Add(stringBuilder.ToString());
    }
    return invoiceAttachments;
  }

  private void DeleteTempInvoices(string folderPath)
  {
    try
    {
      foreach (string file in Directory.GetFiles(folderPath))
      {
        try
        {
          File.Delete(file);
        }
        catch (IOException ex)
        {
        }
        catch (UnauthorizedAccessException ex)
        {
        }
      }
    }
    catch (UnauthorizedAccessException ex)
    {
    }
  }
}

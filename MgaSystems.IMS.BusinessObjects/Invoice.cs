// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.Invoice
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using MGASystems.BusinessObjects.MGAInvoiceFactory;
using MGASystems.BusinessObjects.MGAWebServicesLogon;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblFin_Invoices")]
public class Invoice : BaseDataObject
{
  private int _invoiceNum;
  private Quote _quote;
  private static DateTime? TokenTimestamp;

  public Invoice(int invoiceNum) => this._invoiceNum = invoiceNum;

  public bool InstantiatedViaAutomation { get; set; }

  [DataKey]
  public int InvoiceNum
  {
    get => this._invoiceNum;
    protected set
    {
      this._invoiceNum = this._invoiceNum <= 0 ? value : throw new InvalidOperationException($"Specified Invoice {this._invoiceNum} has already been initialized");
    }
  }

  [TableFieldMapping]
  public int OfficeInvoiceNum
  {
    get => this.GetField<int>(nameof (OfficeInvoiceNum), nameof (OfficeInvoiceNum));
  }

  [TableFieldMapping]
  public int QuoteID => this.GetField<int>(nameof (QuoteID), nameof (QuoteID));

  [TableFieldMapping]
  public DateTime? DateIssued => this.GetField<DateTime?>(nameof (DateIssued), nameof (DateIssued));

  [TableFieldMapping]
  public bool IssuedViaAutomation
  {
    get => this.GetField<bool>(nameof (IssuedViaAutomation), nameof (IssuedViaAutomation));
  }

  [TableFieldMapping("dbo.GetInvoiceAmount(InvoiceNum) AmountBilled")]
  public Decimal Amount => this.GetField<Decimal>("AmountBilled", nameof (Amount));

  public bool IsPrinted => this.IsIssued;

  public bool IsIssued => this.DateIssued.HasValue;

  public Decimal InvNetDue
  {
    get
    {
      Decimal? nullable;
      return !(nullable = this.CacheManualValue<Decimal?>(nameof (InvNetDue), (Func<Decimal?>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<Decimal?>("dbo.Template_InvNetDue", new object[2]
      {
        (object) "@InvoiceNum",
        (object) this._invoiceNum
      })))).HasValue ? -1M : nullable.GetValueOrDefault();
    }
  }

  public Decimal TotalPremium
  {
    get
    {
      return this.GetLazyField<Decimal?>(nameof (TotalPremium), "dbo.GetInvoiceGrossPremium(InvoiceNum)").GetValueOrDefault();
    }
  }

  public double TotalFees
  {
    get
    {
      return Convert.ToDouble(this.GetLazyField<Decimal?>(nameof (TotalFees), $"dbo.GetInvoiceFeesAmount({"InvoiceNum"})").GetValueOrDefault());
    }
  }

  public Quote Quote
  {
    get
    {
      if (this._quote == null)
        this._quote = ObjectFactory.Instance.CreateObjectAs<Quote>((object) this.QuoteID);
      return this._quote;
    }
  }

  [TableFieldMapping]
  public DateTime DueDate
  {
    get => this.GetField<DateTime>(nameof (DueDate), nameof (DueDate));
    set
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblFin_Invoices SET DueDate=@dueDate WHERE InvoiceNum=@Inv", new object[4]
      {
        (object) "@Inv",
        (object) this.InvoiceNum,
        (object) "@dueDate",
        (object) value
      });
      this.ObjectDataStore[nameof (DueDate)] = (object) value;
    }
  }

  public void Issue()
  {
    if (this.IsIssued && (!this.InstantiatedViaAutomation || this.IssuedViaAutomation))
      return;
    this.ObjectDataStore.SetField<DateTime?>("DateIssued", new DateTime?(DefaultDatabase.ExecuteScalar<DateTime>(CommandType.Text, "UPDATE dbo.tblFin_Invoices SET DateIssued=GETDATE(), IssuedViaAutomation=@IssuedViaAutomation WHERE InvoiceNum = @InvoiceNum; SELECT DateIssued FROM tblFin_Invoices WHERE InvoiceNum = @InvoiceNum", new object[4]
    {
      (object) "@IssuedViaAutomation",
      (object) this.InstantiatedViaAutomation,
      (object) "@InvoiceNum",
      (object) this.InvoiceNum
    })));
  }

  public void Print() => this.Print(new ArrayList());

  public void Print(ArrayList @params) => this.Print(@params, string.Empty, string.Empty);

  public void Print(string printerName, string paperSource)
  {
    this.Print(new ArrayList(), printerName, paperSource);
  }

  public void Print(ArrayList @params, string printerName, string paperSource, bool printColor = true)
  {
    if (paperSource == null)
      throw new ArgumentNullException(nameof (paperSource));
    if (printerName == null)
      throw new ArgumentNullException(nameof (printerName));
    SectionReport sectionReport = this.Report(@params);
    SectionDocument document = sectionReport.Document;
    try
    {
      if (printerName.Length != 0)
      {
        document.Printer.PrinterName = printerName;
        ((PrintDocument) document.Printer).DefaultPageSettings.Color = printColor;
        if (paperSource.Length != 0)
        {
          bool flag;
          try
          {
            foreach (PaperSource paperSource1 in ((PrintDocument) document.Printer).PrinterSettings.PaperSources)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paperSource1.SourceName, paperSource, false) == 0)
              {
                ((PrintDocument) document.Printer).DefaultPageSettings.PaperSource = paperSource1;
                flag = true;
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
          if (!flag)
            throw new ArgumentException("Printer or papersource could not be found when printing the invoice.");
        }
      }
      PrintExtension.Print(document, false, false);
      this.Issue();
    }
    finally
    {
      sectionReport?.Dispose();
    }
  }

  public string InvoiceToEmail(ArrayList @params, string invoiceNo)
  {
    SectionReport sectionReport = this.Report(@params);
    SectionDocument document = sectionReport.Document;
    string email = "";
    try
    {
      email = $"{MGATempFolder.MGATempPath}Invoice {invoiceNo}.pdf";
      PdfExport pdfExport = new PdfExport();
      pdfExport.Export(document, email);
      this.Issue();
      Application.DoEvents();
      ((Component) pdfExport).Dispose();
    }
    finally
    {
      sectionReport?.Dispose();
    }
    return email;
  }

  public SectionReport Report() => this.Report(new ArrayList());

  private SectionReport GetReport(ArrayList @params)
  {
    SectionReport report = new SectionReport();
    TokenHeader tokenHeader = new TokenHeader()
    {
      Token = MGASystems.BusinessObjects.Common.WebServicesToken
    };
    if (!this.InstantiatedViaAutomation)
    {
      @params.Add((object) "NotInstantiatedViaAutomation");
      @params.Add((object) true);
    }
    InvoiceFactory_Fix invoiceFactoryFix1 = new InvoiceFactory_Fix();
    invoiceFactoryFix1.Url = MGASystems.BusinessObjects.Common.WebServicesInvoicingUrl;
    invoiceFactoryFix1.TokenHeaderValue = tokenHeader;
    using (InvoiceFactory_Fix invoiceFactoryFix2 = invoiceFactoryFix1)
    {
      int num = 0;
      do
      {
        try
        {
          report.Document.Content = invoiceFactoryFix2.GenerateInvoice(this.InvoiceNum, @params.ToArray());
          break;
        }
        catch (WebException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          if (ex.Message.Contains("The underlying connection was closed") || num == 2)
            throw;
          ProjectData.ClearProjectError();
        }
        ++num;
      }
      while (num <= 2);
    }
    return report;
  }

  public SectionReport Report(ArrayList @params) => this.Report(@params, true);

  public SectionReport Report(ArrayList @params, bool attemptReauthenticate)
  {
    if (!this.RecordExists())
      throw new Exception("Invoice Not Found");
    Type baseType = (Type) null;
    SectionReport sectionReport;
    Exception innerException;
    try
    {
      baseType = ObjectFactory.Instance.CreateTypeFromString("GenericInvoice.rptInvoice");
      if ((object) baseType != null)
      {
        if (!this.InstantiatedViaAutomation)
        {
          @params.Add((object) "NotInstantiatedViaAutomation");
          @params.Add((object) true);
        }
        SectionReport objectEx = (SectionReport) ObjectFactory.Instance.CreateObjectEX(baseType, (object) DefaultDatabase.ConnectionString, (object) this.InvoiceNum, (object) @params);
        DefaultDatabase.ExecuteNonQuery("dbo.UpdateInvoiceAddresses", new object[2]
        {
          (object) "@invoiceNum",
          (object) this.InvoiceNum
        });
        objectEx.Document.Printer.PrinterName = "";
        objectEx.Run();
        sectionReport = objectEx;
        goto label_28;
      }
    }
    catch (Exception ex) when (
    {
      // ISSUE: unable to correctly present filter
      ProjectData.SetProjectError(ex);
      innerException = ex;
      if ((object) baseType == null)
      {
        SuccessfulFiltering;
      }
      else
        throw;
    }
    )
    {
      ErrorHandler.SilentLogError(new Exception("Invoice.Report threw exception attempting to resolve GenericInvoice.rptInvoice type.", innerException));
      ProjectData.ClearProjectError();
    }
    Encryption encryption = new Encryption();
    try
    {
      if (MGASystems.BusinessObjects.Common.WebServicesToken.Equals(Guid.Empty))
      {
        using (Logon logon = new Logon()
        {
          Url = MGASystems.BusinessObjects.Common.WebServicesLogonUrl
        })
        {
          int num = 0;
          do
          {
            try
            {
              MGASystems.BusinessObjects.Common.WebServicesToken = logon.LoginUser(MGASystems.BusinessObjects.Common.UserName, encryption.EncryptTripleDes(MGASystems.BusinessObjects.Common.UserPassword));
              Invoice.TokenTimestamp = new DateTime?(DateTime.Now);
              break;
            }
            catch (WebException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              if (num == 2)
                throw;
              Thread.Sleep(3000);
              ProjectData.ClearProjectError();
            }
            ++num;
          }
          while (num <= 2);
        }
        if (MGASystems.BusinessObjects.Common.WebServicesToken.Equals(Guid.Empty))
          throw new WebServiceLogonFailedException();
      }
      sectionReport = this.GetReport(@params);
    }
    catch (SoapException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      SoapException ex2 = ex1;
      DateTime? tokenTimestamp;
      if (ex2.Code.Name.ValueInNoCase("LoginExpired", "IPMismatch") && attemptReauthenticate && (DateTime.Now - ((tokenTimestamp = Invoice.TokenTimestamp).HasValue ? tokenTimestamp.GetValueOrDefault() : DateTime.MinValue)).TotalMinutes > 5.0)
      {
        ErrorHandler.SilentLogError((Exception) ex2);
        MGASystems.BusinessObjects.Common.WebServicesToken = Guid.Empty;
        sectionReport = this.Report(@params, false);
        ProjectData.ClearProjectError();
      }
      else
        throw;
    }
label_28:
    return sectionReport;
  }

  public enum InvoiceType
  {
    Internal = 1,
    External = 2,
    Both = 3,
  }
}

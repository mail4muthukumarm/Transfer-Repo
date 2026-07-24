// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.ACHStatementServices
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH;

public class ACHStatementServices
{
  private string _customACHReportName;
  private string _customACHReportNameOverFlow;

  public string CustomACHReportName
  {
    get => this._customACHReportName;
    set => this._customACHReportName = value;
  }

  public string CustomACHReportNameOverFlow
  {
    get => this._customACHReportNameOverFlow;
    set => this._customACHReportNameOverFlow = value;
  }

  public virtual void ProcessEmail(
    string emailSubject,
    string emailHeader,
    List<string> statementFieldListing,
    dsACHStatements ds,
    string emailFooter,
    ACHStatementReportOption ACHRptOption)
  {
    bool flag = true;
    if (SystemSettings.KeyExists("ACHSTATEMENT_ATTACHSTATEMENT") & SystemSettings.GetBoolSetting("ACHSTATEMENT_ATTACHSTATEMENT"))
      flag = SystemSettings.GetBoolSetting("ACHSTATEMENT_ATTACHSTATEMENT");
    foreach (dsACHStatements.ACHTransactionsRow achTransaction in (TypedTableBase<dsACHStatements.ACHTransactionsRow>) ds.ACHTransactions)
    {
      if (flag)
      {
        string tempSubdirectory = MGATempFolder.CreateTempSubdirectory();
        int transactnum = achTransaction.transactnum;
        List<string> statementAttachments = this.GetACHStatementAttachments(transactnum, tempSubdirectory, achTransaction.payeeguid, ACHRptOption);
        List<string> stringList = new List<string>();
        List<string> recipients = this.GetRecipients(achTransaction.payeeguid, ref ds);
        if (recipients.Count > 0)
        {
          SMTP_Email.SendUsingOutlook(statementAttachments, recipients, emailSubject, this.BuildACHEmailBody(emailHeader, emailFooter, statementFieldListing, ds.Invoices, transactnum), (List<string>) null, SMTP_Email.ShowOrSend.Send, true);
          DefaultDatabase.ExecuteNonQuery("spfin_Insert_ACHPaymentStatementSent", new object[6]
          {
            (object) "@ACHPaymentSentID",
            (object) achTransaction.ACHPaymentSentID,
            (object) "@transactnum",
            (object) achTransaction.transactnum,
            (object) "@UserID",
            (object) CurrentUser.Instance.UserGUID
          });
          CurrentUser.Instance.LogAction(string.Format("Sent Payment Statement Transaction # {0}", (object) transactnum.ToString(), (object) "ACH Payment Statement Sent Logs"));
        }
        this.DeleteACHTempStatements(tempSubdirectory);
      }
    }
  }

  protected List<string> GetRecipients(Guid payeeGuid, ref dsACHStatements ds)
  {
    return ds.Producers.AsEnumerable<dsACHStatements.ProducersRow>().Where<dsACHStatements.ProducersRow>((System.Func<dsACHStatements.ProducersRow, bool>) (producers => producers.Field<Guid>("ProducerGuid") == payeeGuid)).Select<dsACHStatements.ProducersRow, string>((System.Func<dsACHStatements.ProducersRow, string>) (producers => producers.Field<string>("ContactEmail"))).Distinct<string>().ToList<string>();
  }

  private void DeleteACHTempStatements(string folderPath)
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

  public virtual List<string> GetACHStatementAttachments(
    int transactNum,
    string path,
    Guid payeeGuid,
    ACHStatementReportOption rptOption)
  {
    PdfExport pdfExport = new PdfExport();
    List<string> statementAttachments = new List<string>();
    StringBuilder stringBuilder = new StringBuilder();
    int num1 = (int) rptOption;
    bool flag = DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.IsOperatingTrans(@transactnum)", new object[2]
    {
      (object) "@transactnum",
      (object) transactNum
    });
    string str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.GetEntityName(@ENTITYGUID)", new object[2]
    {
      (object) "@ENTITYGUID",
      (object) payeeGuid
    });
    stringBuilder.Append(path);
    stringBuilder.Append(transactNum.ToString());
    stringBuilder.Append(".pdf");
    if (flag)
    {
      switch (num1)
      {
        case 0:
          SectionReport sectionReport1 = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (CheckOverFlow_Operating), new object[3]
          {
            (object) DefaultDatabase.ExecuteDataSet("spFin_GetCheckDetails_Operating", new object[2]
            {
              (object) "@transactnum",
              (object) transactNum
            }).Tables[0],
            (object) str,
            (object) "ACH"
          });
          sectionReport1.Run();
          pdfExport.Export(sectionReport1.Document, stringBuilder.ToString());
          statementAttachments.Add(stringBuilder.ToString());
          break;
        case 1:
          SectionReport sectionReport2 = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (rptPaymentStatement), new object[1]
          {
            (object) transactNum
          });
          sectionReport2.Run();
          pdfExport.Export(sectionReport2.Document, stringBuilder.ToString());
          statementAttachments.Add(stringBuilder.ToString());
          break;
        case 2:
          statementAttachments = this.GetCustomReport();
          break;
        default:
          int num2 = (int) MessageBox.Show("An error has occurred while trying to use the ACH Payment Statement Utility. The report option is invalid. Please try to choose another report option and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return statementAttachments;
      }
    }
    else
    {
      switch (num1)
      {
        case 0:
          SectionReport sectionReport3 = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (CheckOverFlow), new object[3]
          {
            (object) DefaultDatabase.ExecuteDataSet("spfin_GetCheckDetails", new object[2]
            {
              (object) "@transactnum",
              (object) transactNum
            }).Tables[0],
            (object) str,
            (object) "ACH"
          });
          sectionReport3.Run();
          pdfExport.Export(sectionReport3.Document, stringBuilder.ToString());
          statementAttachments.Add(stringBuilder.ToString());
          break;
        case 1:
          SectionReport sectionReport4 = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (rptPaymentStatement), new object[1]
          {
            (object) transactNum
          });
          sectionReport4.Run();
          pdfExport.Export(sectionReport4.Document, stringBuilder.ToString());
          statementAttachments.Add(stringBuilder.ToString());
          break;
        case 2:
          statementAttachments = this.GetCustomReport();
          break;
        default:
          int num3 = (int) MessageBox.Show("An error has occurred while trying to use the ACH Payment Statement Utility. The report option is invalid. Please try to choose another report option and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return statementAttachments;
      }
    }
    return statementAttachments;
  }

  public virtual string BuildACHEmailBody(
    string emailHeader,
    string emailFooter,
    List<string> statementFieldListing,
    dsACHStatements.InvoicesDataTable statements,
    int transactNum)
  {
    StringBuilder sb = new StringBuilder();
    sb.Append(emailHeader);
    this.AppendCarriageReturn(ref sb);
    this.AppendCarriageReturn(ref sb);
    statements.DefaultView.RowFilter = (string) null;
    statements.DefaultView.RowFilter = "TransActNum = " + transactNum.ToString();
    foreach (DataRowView dataRowView in statements.DefaultView)
    {
      this.AppendCarriageReturn(ref sb);
      for (int index = 0; index <= statementFieldListing.Count - 1; ++index)
      {
        sb.Append(statementFieldListing[index] + ":");
        this.AppendTabs(ref sb);
        switch (statementFieldListing[index])
        {
          case "Invoice #":
            sb.Append(dataRowView.Row.Field<int>("OfficeInvoiceNum").ToString().PadRight(statementFieldListing[index].Length));
            this.AppendCarriageReturn(ref sb);
            break;
          case "Policy #":
            sb.Append(dataRowView.Row.Field<string>("PolicyNumber").ToString());
            this.AppendCarriageReturn(ref sb);
            break;
          case "Insured":
            sb.Append(dataRowView.Row.Field<string>("InsuredPolicyName").ToString());
            this.AppendCarriageReturn(ref sb);
            break;
        }
      }
    }
    this.AppendCarriageReturn(ref sb);
    this.AppendCarriageReturn(ref sb);
    sb.Append(emailFooter);
    return sb.ToString();
  }

  public virtual List<string> GetCustomReport() => throw new NotImplementedException();

  protected void AppendTabs(ref StringBuilder sb) => sb.Append('\t');

  protected void AppendCarriageReturn(ref StringBuilder sb) => sb.Append(Environment.NewLine);

  protected bool ValidateCustomReport() => !string.IsNullOrEmpty(this.CustomACHReportName);
}

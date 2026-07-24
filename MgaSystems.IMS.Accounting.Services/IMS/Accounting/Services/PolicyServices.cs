// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.PolicyServices
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using System;
using System.Data;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services;

public static class PolicyServices
{
  public static PolicyServicesInstance Instance = ObjectFactory.Instance.CreateObjectAs<PolicyServicesInstance>();

  public static void ReinstatePolicy(
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
    PolicyServices.Instance.ReinstatePolicy(quoteId, printDate, reinstatementEffective, printNotice, printEnvelopes, addToDocumentHandler, envelopePrinterName, envelopePrinterTray, runThreaded);
  }

  public static void ReinstatePolicy(int quoteId, int controlNumber, bool runThreaded = false)
  {
    PolicyServices.Instance.ReinstatePolicy(quoteId, controlNumber, runThreaded);
  }

  public static void ReinstatePolicy(
    int quoteId,
    bool isReprint,
    Type reportType,
    bool runThreaded = true)
  {
    PolicyServices.Instance.ReinstatePolicy(quoteId, isReprint, reportType, runThreaded);
  }

  public static void ReinstatePolicyFromControlNumber(int controlNumber)
  {
    PolicyServices.Instance.ReinstatePolicyFromControlNumber(controlNumber);
  }

  public static void ReinstatePolicy(int quoteId)
  {
    PolicyServices.Instance.ReinstatePolicy(quoteId);
  }

  public static void ReinstatePolicy(Quote quoteObject, bool isReprint)
  {
    PolicyServices.Instance.ReinstatePolicy(quoteObject, isReprint);
  }

  public static void ReinstatePolicy(int quoteId, bool isReprint)
  {
    PolicyServices.Instance.ReinstatePolicy(quoteId, isReprint);
  }

  public static void ReinstatePolicy(Quote quoteObject, bool isReprint, Type reportType)
  {
    PolicyServices.Instance.ReinstatePolicy(quoteObject, isReprint, reportType);
  }

  public static bool IsUnderNotice(int InvoiceNumber)
  {
    return DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "Select dbo.AccountingIsUnderNotice(@inv)", new object[2]
    {
      (object) "@inv",
      (object) InvoiceNumber
    });
  }

  public static void DeletePolicyInquiryComment(int commentId)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_DeletePolicyInquiryComment", new object[2]
    {
      (object) "@commentId",
      (object) commentId
    });
  }

  public static int GetManualCancellationEffectiveDays(int controlNumber)
  {
    return DefaultDatabase.ExecuteScalar<int>("spFin_GetManualCancellation_EffectiveDays", new object[2]
    {
      (object) "@controlNumber",
      (object) controlNumber
    });
  }

  public static DataSet GetPolicyReinstatementInvoicesNOC(
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

  public static DataSet GetPolicyReinstatementInvoices(
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

  public static void LogPolicyReinstatementDates(
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

  public static void LaunchFormPolicyDetails(int controlNumber)
  {
    Form form = ObjectFactory.Instance.CreateForm(ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail"), new object[1]
    {
      (object) controlNumber
    });
    form.MdiParent = MDIControls.Instance.MDIParent;
    form.Show();
  }
}

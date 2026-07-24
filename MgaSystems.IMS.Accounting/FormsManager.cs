// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.FormsManager
// Assembly: MgaSystems.IMS.Accounting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 118B765D-C703-4927-A662-CA3DF0A8B869
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountsPayable;
using MGASystems.IMS.Accounting.Banking.Forms;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.GeneralLedger.Forms;
using MGASystems.IMS.Accounting.OperatingExpenses.Forms;
using MGASystems.IMS.Accounting.PolicyServices;

#nullable disable
namespace MGASystems.IMS.Accounting;

public class FormsManager
{
  private static FormsManager _instance;

  private FormsManager()
  {
  }

  public static FormsManager Instance
  {
    get
    {
      if (FormsManager._instance == null)
        FormsManager._instance = new FormsManager();
      return FormsManager._instance;
    }
  }

  public void LaunchForm(FormsManager.FormType formType)
  {
    switch (formType)
    {
      case FormsManager.FormType.BankingManagement:
        frmBanking frmBanking = new frmBanking();
        frmBanking.MdiParent = MDIControls.Instance.MDIParent;
        frmBanking.Show();
        break;
      case FormsManager.FormType.DirectBillPayables:
        formDirectBillPayables directBillPayables = new formDirectBillPayables();
        directBillPayables.MdiParent = MDIControls.Instance.MDIParent;
        directBillPayables.Show();
        break;
      case FormsManager.FormType.GeneralLedger:
        formGLAccountManagement accountManagement = new formGLAccountManagement();
        accountManagement.MdiParent = MDIControls.Instance.MDIParent;
        accountManagement.Show();
        break;
      case FormsManager.FormType.OperatingAutomationAccounts:
        formOperatingAutomationAccounts automationAccounts = new formOperatingAutomationAccounts();
        automationAccounts.MdiParent = MDIControls.Instance.MDIParent;
        automationAccounts.Show();
        break;
      case FormsManager.FormType.OperatingExpenses:
        formOperatingExpenses operatingExpenses = new formOperatingExpenses();
        operatingExpenses.MdiParent = MDIControls.Instance.MDIParent;
        operatingExpenses.Show();
        break;
      case FormsManager.FormType.PolicyInquiry:
        formPolicyInquiry formPolicyInquiry = new formPolicyInquiry();
        formPolicyInquiry.MdiParent = MDIControls.Instance.MDIParent;
        formPolicyInquiry.Show();
        break;
      case FormsManager.FormType.SearchTransaction:
        formSearchTransaction searchTransaction = new formSearchTransaction();
        searchTransaction.MdiParent = MDIControls.Instance.MDIParent;
        searchTransaction.Show();
        break;
    }
  }

  public enum FormType
  {
    AccountClassification,
    AccountLinking,
    AccountingPeriods,
    AccountingPrinters,
    AccountsPayable,
    AccountsReceivable,
    AgingPeriods,
    AutomationAccounts,
    BankingManagement,
    DirectBillPayables,
    ExtendedSettings,
    GeneralLedger,
    JournalViewer,
    OperatingAutomationAccounts,
    OperatingExpenses,
    PolicyInquiry,
    SearchTransaction,
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.AccountingProvider
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinExplorerBar;
using MGASystems.IMS.Accounting.GeneralLedger.Forms;
using MGASystems.IMS.Accounting.GeneralLedger.Properties;
using MGASystems.IMS.Accounting.Interfaces;
using System.Drawing;
using System.Reflection;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;

public class AccountingProvider : IAccountingExplorerProvider
{
  public UltraExplorerBarGroup BuildExplorerMenu()
  {
    foreach (string manifestResourceName in Assembly.GetExecutingAssembly().GetManifestResourceNames())
      ;
    UltraExplorerBarGroup explorerBarGroup = new UltraExplorerBarGroup("GL");
    explorerBarGroup.Text = "General Ledger";
    UltraExplorerBarItem ultraExplorerBarItem1 = new UltraExplorerBarItem("GL");
    ultraExplorerBarItem1.Text = "General Ledger Management";
    ((SubObjectBase) ultraExplorerBarItem1).Tag = (object) new object[3]
    {
      (object) typeof (formGLAccountManagement),
      (object) false,
      (object) "{E5A20506-6E0C-49b0-BD04-31C0BC68D00B}"
    };
    ultraExplorerBarItem1.Settings.AppearancesSmall.Appearance.Image = (object) Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Accounting.GeneralLedger.Resources.gl.png"));
    explorerBarGroup.Items.Add(ultraExplorerBarItem1);
    UltraExplorerBarItem ultraExplorerBarItem2 = new UltraExplorerBarItem("FISCAL");
    ultraExplorerBarItem2.Text = "Fiscal Configurations";
    ((SubObjectBase) ultraExplorerBarItem2).Tag = (object) new object[3]
    {
      (object) typeof (formFiscalConfiguration),
      (object) false,
      (object) "{C61CFA14-8F4A-4cbe-95F3-9773FA38F96F}"
    };
    ultraExplorerBarItem2.Settings.AppearancesSmall.Appearance.Image = (object) Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Accounting.GeneralLedger.Resources.fiscal.png"));
    explorerBarGroup.Items.Add(ultraExplorerBarItem2);
    UltraExplorerBarItem ultraExplorerBarItem3 = new UltraExplorerBarItem("JOURNAL");
    ultraExplorerBarItem3.Text = "Journal Entry";
    ((SubObjectBase) ultraExplorerBarItem3).Tag = (object) new object[3]
    {
      (object) typeof (FormJournalEntry_Advanced),
      (object) false,
      (object) "{C2FD50F8-2B5C-44b6-A521-12EA29B24FC1}"
    };
    ultraExplorerBarItem3.Settings.AppearancesSmall.Appearance.Image = (object) Resources.application_get;
    explorerBarGroup.Items.Add(ultraExplorerBarItem3);
    return explorerBarGroup;
  }

  public UltraExplorerBarItem[] ProvideAdministrativeOptions()
  {
    UltraExplorerBarItem ultraExplorerBarItem1 = new UltraExplorerBarItem("CLOSEFISCAL");
    ultraExplorerBarItem1.Text = "Close Fiscal Year Utility";
    ((SubObjectBase) ultraExplorerBarItem1).Tag = (object) new object[3]
    {
      (object) typeof (formCloseFiscalYear),
      (object) false,
      (object) "{1D6326A2-7300-4f39-A531-4A119F657C5F}"
    };
    ultraExplorerBarItem1.Settings.AppearancesSmall.Appearance.Image = (object) Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Accounting.GeneralLedger.Resources.CloseFiscal.png"));
    UltraExplorerBarItem ultraExplorerBarItem2 = new UltraExplorerBarItem("AUTOMATION");
    ultraExplorerBarItem2.Text = "Add/Edit Automation Settings";
    ((SubObjectBase) ultraExplorerBarItem2).Tag = (object) new AccountingProviderExtensions(typeof (formAutomationAccounts), true, "{5FB0F07D-0F17-47e0-82F3-B65AEB20BB07}");
    ultraExplorerBarItem2.Settings.AppearancesSmall.Appearance.Image = (object) Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Accounting.GeneralLedger.Resources.automation.png"));
    return new UltraExplorerBarItem[2]
    {
      ultraExplorerBarItem1,
      ultraExplorerBarItem2
    };
  }

  public UltraExplorerBarItem[] ProvideTools()
  {
    UltraExplorerBarItem ultraExplorerBarItem1 = new UltraExplorerBarItem("AGING");
    ultraExplorerBarItem1.Text = "Define Aging Periods";
    ((SubObjectBase) ultraExplorerBarItem1).Tag = (object) new object[3]
    {
      (object) typeof (formAgingBuckets),
      (object) true,
      (object) "{30C38296-8098-4a12-9768-5AD6C183CD87}"
    };
    ultraExplorerBarItem1.Settings.AppearancesSmall.Appearance.Image = (object) Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Accounting.GeneralLedger.Resources.date.png"));
    UltraExplorerBarItem ultraExplorerBarItem2 = new UltraExplorerBarItem("JOURNALVIEWER");
    ultraExplorerBarItem2.Text = "Journal Viewer";
    ((SubObjectBase) ultraExplorerBarItem2).Tag = (object) new object[3]
    {
      (object) typeof (formJournalViewer),
      (object) false,
      (object) "{FE42072A-5A73-4035-B48E-E5E7FBFC59C1}"
    };
    ultraExplorerBarItem2.Settings.AppearancesSmall.Appearance.Image = (object) Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Accounting.GeneralLedger.Resources.jview.png"));
    return new UltraExplorerBarItem[2]
    {
      ultraExplorerBarItem1,
      ultraExplorerBarItem2
    };
  }

  public int ExplorerMenuIndex => 2;
}

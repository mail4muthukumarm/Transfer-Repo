// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.AccountingProvider
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinExplorerBar;
using MGASystems.IMS.Accounting.Interfaces;
using MGASystems.IMS.Accounting.OperatingExpenses.Forms;
using System.Drawing;
using System.Reflection;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;

public class AccountingProvider : IAccountingExplorerProvider
{
  public UltraExplorerBarGroup BuildExplorerMenu()
  {
    UltraExplorerBarGroup explorerBarGroup = new UltraExplorerBarGroup("OPERATING");
    explorerBarGroup.Text = "Operating Expenses";
    UltraExplorerBarItem ultraExplorerBarItem1 = new UltraExplorerBarItem("OE");
    ultraExplorerBarItem1.Text = "Operating Expense Management";
    ((SubObjectBase) ultraExplorerBarItem1).Tag = (object) new object[3]
    {
      (object) typeof (formOperatingExpenses),
      (object) false,
      (object) "{A425EB6C-9B4D-46d9-BF1F-D0903E3B2798}"
    };
    ultraExplorerBarItem1.Settings.AppearancesSmall.Appearance.Image = (object) Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Accounting.OperatingExpenses.Resources.operating.png"));
    explorerBarGroup.Items.Add(ultraExplorerBarItem1);
    UltraExplorerBarItem ultraExplorerBarItem2 = new UltraExplorerBarItem("OEA");
    ultraExplorerBarItem2.Text = "Operating Automation Accounts";
    ((SubObjectBase) ultraExplorerBarItem2).Tag = (object) new object[3]
    {
      (object) typeof (formOperatingAutomationAccounts),
      (object) true,
      (object) "{98D8D393-D2D3-4a91-943C-FDD3D369B3E9}"
    };
    ultraExplorerBarItem2.Settings.AppearancesSmall.Appearance.Image = (object) Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Accounting.OperatingExpenses.Resources.automation.png"));
    explorerBarGroup.Items.Add(ultraExplorerBarItem2);
    UltraExplorerBarItem ultraExplorerBarItem3 = new UltraExplorerBarItem("OECOMM");
    ultraExplorerBarItem3.Text = "Expensed Commissions";
    ((SubObjectBase) ultraExplorerBarItem3).Tag = (object) new AccountingProviderExtension(typeof (formExpensedCommissions), false, "{B9A8254E-03C8-4226-B96F-4FE4B5D5C752}");
    ultraExplorerBarItem3.Settings.AppearancesSmall.Appearance.Image = (object) Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Accounting.OperatingExpenses.Resources.expensed.png"));
    explorerBarGroup.Items.Add(ultraExplorerBarItem3);
    return explorerBarGroup;
  }

  public UltraExplorerBarItem[] ProvideAdministrativeOptions() => (UltraExplorerBarItem[]) null;

  public UltraExplorerBarItem[] ProvideTools() => (UltraExplorerBarItem[]) null;

  public int ExplorerMenuIndex => 3;
}

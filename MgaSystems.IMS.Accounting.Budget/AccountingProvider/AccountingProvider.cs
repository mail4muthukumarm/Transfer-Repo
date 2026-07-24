// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Budget.AccountingProvider.AccountingProvider
// Assembly: MgaSystems.IMS.Accounting.Budget, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6BC25DF1-D5D5-4DAC-8821-336F88BA639E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Budget.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinExplorerBar;
using MGASystems.IMS.Accounting.Budget.BudgetForm;
using MGASystems.IMS.Accounting.Budget.Properties;
using MGASystems.IMS.Accounting.Interfaces;

#nullable disable
namespace MGASystems.IMS.Accounting.Budget.AccountingProvider;

internal class AccountingProvider : IAccountingExplorerProvider
{
  public UltraExplorerBarGroup BuildExplorerMenu()
  {
    UltraExplorerBarGroup explorerBarGroup = new UltraExplorerBarGroup("GLBUDGET");
    explorerBarGroup.Text = "GL Budget";
    UltraExplorerBarItem ultraExplorerBarItem = new UltraExplorerBarItem("GLBUDGET");
    ultraExplorerBarItem.Text = "General Ledger Budget Management";
    ((SubObjectBase) ultraExplorerBarItem).Tag = (object) new object[3]
    {
      (object) typeof (formBudget),
      (object) false,
      (object) "{A767F4EC-3E41-438B-B80F-2686297BE699}"
    };
    ultraExplorerBarItem.Settings.AppearancesSmall.Appearance.Image = (object) Resources.chart_bar;
    explorerBarGroup.Items.Add(ultraExplorerBarItem);
    return explorerBarGroup;
  }

  public UltraExplorerBarItem[] ProvideAdministrativeOptions() => (UltraExplorerBarItem[]) null;

  public UltraExplorerBarItem[] ProvideTools() => (UltraExplorerBarItem[]) null;

  public int ExplorerMenuIndex => 2;
}

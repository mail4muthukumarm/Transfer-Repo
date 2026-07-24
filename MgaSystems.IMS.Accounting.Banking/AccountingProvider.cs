// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.AccountingProvider
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win.UltraWinExplorerBar;
using MGASystems.IMS.Accounting.Banking.Forms;
using MGASystems.IMS.Accounting.Interfaces;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public class AccountingProvider : IAccountingExplorerProvider
{
  public UltraExplorerBarGroup BuildExplorerMenu()
  {
    UltraExplorerBarGroup explorerBarGroup = new UltraExplorerBarGroup("Banking");
    explorerBarGroup.Text = "Banking";
    explorerBarGroup.Items.Add(new UltraExplorerBarItem("BM")
    {
      Text = "Bank Management",
      Tag = (object) new AccountingProviderExtension(typeof (frmBanking), false, "{E7CE118D-D5DD-4e32-BB79-A486589A92AE}"),
      Settings = {
        AppearancesSmall = {
          Appearance = {
            Image = (object) MGASystems.IMS.Accounting.Banking.My.Resources.Resources.BankingHome
          }
        }
      }
    });
    return explorerBarGroup;
  }

  public UltraExplorerBarItem[] ProvideAdministrativeOptions1()
  {
    return new UltraExplorerBarItem[1]
    {
      new UltraExplorerBarItem("PI")
      {
        Text = "Payee Instruction Utility",
        Tag = (object) new AccountingProviderExtension(typeof (formPayeeInstructions), true, "{E7D0695A-0C0C-42D7-830E-0BD1128BA182}"),
        Settings = {
          AppearancesSmall = {
            Appearance = {
              Image = (object) MGASystems.IMS.Accounting.Banking.My.Resources.Resources.PayeeInstruction
            }
          }
        }
      }
    };
  }

  public UltraExplorerBarItem[] ProvideTools() => (UltraExplorerBarItem[]) null;

  public int ExplorerMenuIndex => 1;
}

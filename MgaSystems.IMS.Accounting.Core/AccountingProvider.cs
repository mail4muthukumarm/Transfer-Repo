// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingProvider
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinExplorerBar;
using MGASystems.Common.Settings;
using MGASystems.IMS.Accounting.AccountsPayable;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.EnhancedPolicyInquiry;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.Core.Forms.ACH;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.UserInterface;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.UserInterface;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Interfaces;
using MGASystems.IMS.Accounting.PolicyServices;
using System;
using System.Collections.Generic;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting;

public class AccountingProvider : IAccountingExplorerProvider
{
  public UltraExplorerBarGroup BuildExplorerMenu()
  {
    List<UltraExplorerBarItem> ultraExplorerBarItemList = new List<UltraExplorerBarItem>()
    {
      AccountingProvider.CreateTransactionBuilderBarItem(),
      AccountingProvider.CreateSeparator(1),
      AccountingProvider.CreateExcelImportBarItem(),
      AccountingProvider.CreateExcelImportAutomationBarItem(),
      AccountingProvider.CreateSeparator(100),
      AccountingProvider.CreateDirectBillExcelImportBarItem(),
      AccountingProvider.CreateSeparator(0),
      AccountingProvider.CreateDirectBillUtilityBarItem(),
      AccountingProvider.CreateSeparator(1),
      AccountingProvider.CreatePolicyInquiryBarItem(),
      AccountingProvider.CreateAdvancedPolicySearchBarItem()
    };
    UltraExplorerBarGroup explorerBarGroup = new UltraExplorerBarGroup("Accounting");
    explorerBarGroup.Text = "Accounting";
    explorerBarGroup.Items.AddRange(ultraExplorerBarItemList.ToArray());
    return explorerBarGroup;
  }

  public UltraExplorerBarItem[] ProvideAdministrativeOptions()
  {
    List<UltraExplorerBarItem> ultraExplorerBarItemList = new List<UltraExplorerBarItem>()
    {
      AccountingProvider.CreateClosePeriodExplorerBarItem(),
      AccountingProvider.CreateAccountPrintersExplorerBarItem(),
      AccountingProvider.CreateExtendedSettingsExplorerBarItem(),
      AccountingProvider.CreateWriteOfSettingsExplorerBarItem(),
      AccountingProvider.CreateCostCenterDataServiceExplorerBarItem(),
      AccountingProvider.CreateRebuildWorkingTablesExplorerBarItem(),
      AccountingProvider.CreateRebuildIdentityLookupExplorerBarItem(),
      AccountingProvider.CreateW9EditBarItem()
    };
    if (SystemSettings.GetSetting<bool>("PostedSettlementsNeedApproval"))
      ultraExplorerBarItemList.Add(AccountingProvider.CreateSettlementApprovalEditorBarItem());
    if (SystemSettings.GetSetting<bool>("ENABLE_ACH"))
      ultraExplorerBarItemList.Add(AccountingProvider.CreateAchSettingsExplorerBarItem());
    if (SystemSettings.GetSetting<bool>("ENABLE_ACHEXPORT"))
      ultraExplorerBarItemList.Add(AccountingProvider.CreateAchExportExplorerBarItem());
    if (SystemSettings.GetSetting<bool>("PolicyCancelWashAll") || SystemSettings.GetSetting<bool>("PolicyCancelWashFlat") || SystemSettings.GetSetting<bool>("PolicyEndorsementWashAll"))
      ultraExplorerBarItemList.Add(AccountingProvider.CreateFlatCancelConfigBarItem());
    if (SystemSettings.GetSetting<bool>("PolicyCharge.ViewAccountingOffice"))
      ultraExplorerBarItemList.Add(this.CreateChargeCodeGLAccountMappingBarItem());
    return ultraExplorerBarItemList.ToArray();
  }

  public UltraExplorerBarItem[] ProvideTools()
  {
    List<UltraExplorerBarItem> ultraExplorerBarItemList = new List<UltraExplorerBarItem>()
    {
      AccountingProvider.CreateSearchTransExplorerBaritem()
    };
    if (SystemSettings.GetSetting<bool>("ENABLE_ACHSTATEMENTUTILITY"))
      ultraExplorerBarItemList.Add(AccountingProvider.CreateAchStatementEmailExplorerBarItem());
    return ultraExplorerBarItemList.ToArray();
  }

  public static UltraExplorerBarItem CreateBarItem(
    string key,
    string displayText,
    Bitmap image,
    Type onClickShowFormOfType,
    bool showFormModal,
    string securityGuid)
  {
    return AccountingProvider.CreateBarItem(key, displayText, image, (object) new AccountingProviderExtensions(onClickShowFormOfType, showFormModal, securityGuid));
  }

  public static UltraExplorerBarItem CreateBarItem(
    string key,
    string displayText,
    Bitmap image,
    object tag)
  {
    UltraExplorerBarItem ultraExplorerBarItem = new UltraExplorerBarItem(key);
    ultraExplorerBarItem.Text = displayText;
    ((SubObjectBase) ultraExplorerBarItem).Tag = tag;
    UltraExplorerBarItem barItem = ultraExplorerBarItem;
    barItem.Settings.AppearancesSmall.Appearance.Image = (object) image;
    return barItem;
  }

  private UltraExplorerBarItem CreateChargeCodeGLAccountMappingBarItem()
  {
    return AccountingProvider.CreateBarItem("Charge Code GL Account Mapping", "Charge Code GL Account Mapping", Resources.book_edit, typeof (ChargeCodeGLAccountMappingEditor), true, "{E06DEBA8-3FC9-429F-A1E7-938DE99AD1A1}");
  }

  private static UltraExplorerBarItem CreateFlatCancelConfigBarItem()
  {
    return AccountingProvider.CreateBarItem("FLATCANCELCONFIG", "Policy Cancel Configuration", Resources.bricks, (object) new object[3]
    {
      (object) typeof (formFlatCancelConfiguration),
      (object) true,
      (object) "{9F7DFA24-F2E6-419B-A7B3-FFA16F2A98B3}"
    });
  }

  private static UltraExplorerBarItem CreateW9EditBarItem()
  {
    return AccountingProvider.CreateBarItem("W9EDIT", "W9 Information Management", Resources.application_form_edit, (object) new object[3]
    {
      (object) typeof (W9Editor),
      (object) true,
      (object) "{B5B5FE6B-D355-4746-B8BB-5BE2D78DDB04}"
    });
  }

  private static UltraExplorerBarItem CreateSettlementApprovalEditorBarItem()
  {
    return AccountingProvider.CreateBarItem("Settlement Approval", "Settlement Approval", Resources.money_delete, (object) new object[3]
    {
      (object) typeof (PendingApprovalSettlementEditor),
      (object) true,
      (object) "{0B82413E-D6D3-4F80-81E2-27BC5D5D3EEC}"
    });
  }

  private static UltraExplorerBarItem CreateClosePeriodExplorerBarItem()
  {
    return AccountingProvider.CreateBarItem("CLOSEPERIOD", "Close Accounting Period", Resources.CloseAccountingPeriod, typeof (formCloseAccountingPeriod), true, "{2FD97FF8-9A8C-4b9e-8D2B-88603D43D796}");
  }

  private static UltraExplorerBarItem CreateAccountPrintersExplorerBarItem()
  {
    return AccountingProvider.CreateBarItem("ACCTPRINTERS", "Accounting Printers", Resources.AccountingPrinters, typeof (formAccountingPrinters), true, "{091A13EC-A3E5-4c41-A72A-B3C0901064E6}");
  }

  private static UltraExplorerBarItem CreateExtendedSettingsExplorerBarItem()
  {
    return AccountingProvider.CreateBarItem("EXTENDEDSETTINGS", "Extended Setting Management", Resources.ExtendedSettings, typeof (formExtendedSettings), true, "{3519F03A-EFAD-440d-8105-037D44565571}");
  }

  private static UltraExplorerBarItem CreateWriteOfSettingsExplorerBarItem()
  {
    return AccountingProvider.CreateBarItem("WRITEOFFSETTINGSMNG", "Write-Off Settings Management", Resources.writeoffsettings, typeof (formWriteOffSettings), true, "{3107D19D-141A-4d05-9870-74956C181765}");
  }

  private static UltraExplorerBarItem CreateCostCenterDataServiceExplorerBarItem()
  {
    return AccountingProvider.CreateBarItem("COSTCENTERDATASERVICE", "Period End Maintenance Tool", Resources.cog_edit, typeof (formCostCenterDataService), true, "{6EA9ECFF-49EB-49A4-8076-0D2ED6147DE7}");
  }

  private static UltraExplorerBarItem CreateRebuildWorkingTablesExplorerBarItem()
  {
    return AccountingProvider.CreateBarItem("REBUILDWORKING", "Rebuild Working Tables", Resources.building_edit, typeof (formRebuildWorkingTables), true, "{F8A3D1A6-84C0-4296-93AC-B0F95F5446ED}");
  }

  private static UltraExplorerBarItem CreateRebuildIdentityLookupExplorerBarItem()
  {
    return AccountingProvider.CreateBarItem("REBUILDENTITYLOOKUP", "Refresh Entity Lookup Tables", Resources.user_edit, typeof (FormRebuildEntityLookup), true, "{C1832FBF-7793-4844-9211-708267099FEA}");
  }

  private static UltraExplorerBarItem CreateAchSettingsExplorerBarItem()
  {
    return AccountingProvider.CreateBarItem("ACHSETTINGS", "ACH Settings Management", Resources.money, SystemSettings.GetSetting<bool>("EnableMultiACHSettings") ? typeof (formMultiACHSettingsManagement) : typeof (formACHSettingsManagement), true, "{4189A3B5-B157-4284-8B73-3DDFDE602B85}");
  }

  private static UltraExplorerBarItem CreateAchExportExplorerBarItem()
  {
    return AccountingProvider.CreateBarItem("ACHEXPORT", "ACH Export", Resources.money, typeof (FormACHWireExport), true, "{DA6E30C6-7098-4CF6-863A-3B07F5FD10A4}");
  }

  private static UltraExplorerBarItem CreateAchStatementEmailExplorerBarItem()
  {
    return AccountingProvider.CreateBarItem("ACHSTATEMENTEMAIL", "ACH Statement Email Utility", Resources.email_open_image, (object) new object[3]
    {
      (object) typeof (formACHStatementEmailUtility),
      (object) false,
      (object) "{D0C06931-0DC8-408F-95D0-5BC2C3B1D750}"
    });
  }

  private static UltraExplorerBarItem CreateSearchTransExplorerBaritem()
  {
    return AccountingProvider.CreateBarItem("SEARCHTRANS", "Search Transaction", Resources.SearchTransaction, (object) new object[3]
    {
      (object) typeof (formSearchTransaction),
      (object) false,
      (object) "{F4EA2CF0-C1F6-44F0-AB91-35CCB20E9CD1}"
    });
  }

  private static UltraExplorerBarItem CreateDirectBillExcelImportBarItem()
  {
    return AccountingProvider.CreateBarItem("DB_EXCEL", "Direct Bill Excel Import Tool", Resources.page_white_excel, (object) new object[3]
    {
      (object) typeof (FormDirectBillExcelImport),
      (object) true,
      (object) "{E4D5F3A2-78FF-4628-8DAE-4CCD0EA466FD}"
    });
  }

  private static UltraExplorerBarItem CreateAdvancedPolicySearchBarItem()
  {
    return AccountingProvider.CreateBarItem("ADVPOLICY", "Advanced Policy Search Utility", Resources.bricks, (object) new object[3]
    {
      (object) typeof (FormPolicyInquiryDrillDown),
      (object) false,
      (object) "{C6E6F51E-79FC-42DE-A122-D497F2CF4F55}"
    });
  }

  private static UltraExplorerBarItem CreatePolicyInquiryBarItem()
  {
    return AccountingProvider.CreateBarItem("POLICY", "Policy Inquiry", Resources.PolicyInquiry, (object) new object[2]
    {
      (object) typeof (formPolicyInquiry),
      (object) false
    });
  }

  private static UltraExplorerBarItem CreateExcelImportAutomationBarItem()
  {
    return AccountingProvider.CreateBarItem("EXCEL2", "Excel Import Automation", Resources.Excel, (object) new object[3]
    {
      (object) typeof (FormExcelImport),
      (object) true,
      (object) "{3A8C6F34-D03A-449E-9DB1-BBC43F26B8D8}"
    });
  }

  private static UltraExplorerBarItem CreateExcelImportBarItem()
  {
    return AccountingProvider.CreateBarItem("EXCEL", "Excel Import Automation Wizard (Legacy)", Resources.ExcelImport, (object) new object[3]
    {
      (object) typeof (formExcelImportWizard),
      (object) true,
      (object) "{3A8C6F34-D03A-449E-9DB1-BBC43F26B8D8}"
    });
  }

  private static UltraExplorerBarItem CreateTransactionBuilderBarItem()
  {
    return AccountingProvider.CreateBarItem("TRANSBUILDER", "Transaction Builder", Resources.TransactionBuilder, (object) new object[3]
    {
      (object) typeof (formTransactionBuilder),
      (object) false,
      (object) "{5389EE28-AD3B-4233-B7A1-557D29CEB138}"
    });
  }

  private static UltraExplorerBarItem CreateDirectBillUtilityBarItem()
  {
    return AccountingProvider.CreateBarItem("DIRBILL", "Direct Bill Payables Utility", Resources.DirectBillPayables, (object) new object[3]
    {
      (object) (SystemSettings.GetSetting<bool>("DIRECTBILL_USEOPTIMIZATION") ? typeof (FormDirectBillPayablesUtility) : typeof (formDirectBillPayables)),
      (object) false,
      (object) "{950FB803-408B-460F-A9D0-238435BF3203}"
    });
  }

  private static UltraExplorerBarItem CreateSeparator(int id)
  {
    return new UltraExplorerBarItem($"SEP{id}")
    {
      Settings = {
        Style = (ItemStyle) 4
      },
      Text = "-"
    };
  }

  public int ExplorerMenuIndex => 0;
}

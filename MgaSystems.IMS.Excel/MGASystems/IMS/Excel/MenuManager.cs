// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.MenuManager
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Excel.Data.StandardRating;
using MGASystems.IMS.Excel.ImportFileUtil;
using MgaSystems.IMS.Excel.Properties;
using MGASystems.IMS.Excel.Rating;
using MgaSystems.IMS.Excel.Views;
using MGASystems.IMS.Excel.Views;
using MGASystems.IMS.Logging;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Excel;

[MenuManager]
[SecureResource("{D57DE89C-A197-484F-AFD7-87B61EC4C4AC}", "Controls access to the Import File Utility menu item", "Allows users to view/use Import File Utility function", "Tools")]
public class MenuManager : IMenuConsumer
{
  private const string adminExcelRatingManager = "Admin_ExcelRatingManagement";
  private const string adminExcelUserTagManager = "Admin_UserTagRatingManagement";
  private const string policyExportExcelRatingData = "Policy_ExportExcelData";
  private const string policyEditReturnedPremiums = "Policy_EditReturnedPremiums";
  private const string policyViewExcelPremiumData = "Policy_ViewExcelPremiumData";
  private const string tools_ImportFileUtility = "Tools_ImportFileUtility";
  private static bool useDynamicCaptureSheets = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("ExcelRating.UseDynamicCaptureSheets");
  private readonly Dictionary<string, int> captureSheetsDictionary = new Dictionary<string, int>();

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  private static void WriteLog(string message) => Log.Write(message, "EIL");

  private static void WriteLog(string message, IRecreatableEntity recreateableEntity)
  {
    MenuManager.WriteLog($"{recreateableEntity?.RecreateTypeName} {recreateableEntity?.EntityGuid}\r\n{message}");
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    MenuManager.WriteLog(nameof (OnIGMenuToolClicked));
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "Tools_ImportFileUtility":
        new frmImportFileUtility().Show();
        break;
      case "Admin_ExcelRatingManagement":
        MenuManager.ShowForm(typeof (ExcelRatingAdmin2));
        break;
      case "Admin_UserTagRatingManagement":
        MenuManager.ShowForm(typeof (UserTaggingAdmin));
        break;
      case "Policy_ExportExcelData":
        this.ExportExcelRatingData();
        break;
      case "Policy_EditReturnedPremiums":
        this.DisplayExcelReturnPremiumEditScreen();
        break;
      case "Policy_ViewExcelPremiumData":
        this.DisplayViewExcelPremiumDataScreen();
        break;
    }
    if (!MenuManager.useDynamicCaptureSheets)
      return;
    Form activeMdiChild = MDIControls.Instance.MDIParent.ActiveMdiChild;
    if (activeMdiChild == null || !MenuManager.IsPolicyDetail(activeMdiChild) || !(activeMdiChild is IRecreatableEntity recreateableEntity))
      return;
    string key = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key.Replace("Reset ", "");
    Guid entityGuid = recreateableEntity.EntityGuid;
    int raterId;
    if (this.captureSheetsDictionary.TryGetValue(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key, out raterId))
    {
      ExcelRater.InvokeRaterForDataCaptureDirect(raterId, entityGuid);
    }
    else
    {
      if (!this.captureSheetsDictionary.TryGetValue(key, out raterId) || MessageBox.Show($"Are you sure you'd like to reset all value for {key} for this quote?", $"Reset {key}?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      MenuManager.WriteLog("Invoked reset for capture sheet " + key, recreateableEntity);
      DefaultDatabase.ExecuteNonQuery("ExcelRating_ResetCaptureSheet", new object[6]
      {
        (object) "@QuoteGUID",
        (object) entityGuid,
        (object) "@RatingTypeID",
        (object) raterId,
        (object) "@UserID",
        (object) CurrentUser.Instance.UserID
      });
    }
  }

  private void DisplayViewExcelPremiumDataScreen()
  {
    Form activeMdiChild = MDIControls.Instance.MDIParent.ActiveMdiChild;
    if (activeMdiChild == null || !MenuManager.IsPolicyDetail(activeMdiChild) || !(activeMdiChild is IRecreatableEntity recreatableEntity))
      return;
    Form form = ObjectFactory.Instance.CreateForm(typeof (QuickDataView), new object[1]
    {
      (object) recreatableEntity.EntityGuid
    });
    form.MdiParent = MDIControls.Instance.MDIParent;
    form.Show();
  }

  private void DisplayExcelReturnPremiumEditScreen()
  {
    Form activeMdiChild = MDIControls.Instance.MDIParent.ActiveMdiChild;
    if (activeMdiChild == null || !MenuManager.IsPolicyDetail(activeMdiChild) || !(activeMdiChild is IRecreatableEntity recreatableEntity))
      return;
    Form form = ObjectFactory.Instance.CreateForm(typeof (AdminPremiumAdjustment), new object[1]
    {
      (object) recreatableEntity.EntityGuid
    });
    form.MdiParent = MDIControls.Instance.MDIParent;
    form.Show();
  }

  private void ExportExcelRatingData()
  {
    try
    {
      Form activeMdiChild = MDIControls.Instance.MDIParent.ActiveMdiChild;
      if (activeMdiChild == null || !MenuManager.IsPolicyDetail(activeMdiChild) || !(activeMdiChild is IRecreatableEntity recreatableEntity))
        return;
      Guid entityGuid = recreatableEntity.EntityGuid;
      DataSet ratingData = ObjectFactory.Instance.CreateObjectAs<ExcelDataExporter>(typeof (ExcelDataExporter)).GetRatingData(entityGuid);
      using (SaveFileDialog saveFileDialog = new SaveFileDialog())
      {
        saveFileDialog.FileName = "Export.xls";
        saveFileDialog.DefaultExt = "xls";
        saveFileDialog.Filter = "Excel document (*.xls)|*.xls";
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
          return;
        ExcelExport.ToExcel(ratingData, saveFileDialog.FileName);
      }
    }
    catch (Exception ex)
    {
      ErrorHandler.SilentHandleError(ex);
      int num = (int) MessageBox.Show(ex.Message, "We encountered a problem exporting your data.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
  }

  private static void ShowForm(Type formType)
  {
    Form form = ObjectFactory.Instance.CreateForm(formType);
    form.MdiParent = MDIControls.Instance.MDIParent;
    form.Show();
  }

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    MenuManager.WriteLog(nameof (OnSetupIGMenu));
    if (SecurityManager.Instance.AssertPermission("{D57DE89C-A197-484F-AFD7-87B61EC4C4AC}"))
      ((ToolPropsBase) ((ToolBase) MenuManager.AddMainMenuTool(menu, "Tools", "Tools_ImportFileUtility", "Import File Utility...")).SharedProps).AppearancesSmall.Appearance.Image = (object) ImageCache.Instance.Run;
    ((ToolPropsBase) ((ToolBase) MenuManager.AddMainMenuTool(menu, "Administration", "Admin_ExcelRatingManagement", "Excel Rating Management")).SharedProps).AppearancesSmall.Appearance.Image = (object) Resources.excel;
    ((ToolPropsBase) ((ToolBase) MenuManager.AddMainMenuTool(menu, "Administration", "Admin_UserTagRatingManagement", "User Tag Management")).SharedProps).AppearancesSmall.Appearance.Image = (object) Resources.tag;
  }

  private static ButtonTool AddMainMenuTool(
    UltraToolbarsManager menu,
    string AddToMenuKey,
    string NewToolKey,
    string NewToolCaption)
  {
    MenuManager.WriteLog(nameof (AddMainMenuTool));
    ButtonTool buttonTool = new ButtonTool(NewToolKey);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = NewToolCaption;
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesSmall.Appearance.Image = (object) Resources.excel;
    ((ToolsCollectionBase) menu.Tools).Add((ToolBase) buttonTool);
    ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) menu.Toolbars["mainMenu"]).Tools)[AddToMenuKey]).Tools.AddTool(NewToolKey);
    return buttonTool;
  }

  private static bool IsPolicyDetail(Form form)
  {
    return form != null && typeof (frmPolicyDetail).IsAssignableFrom(form.GetType());
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
    MenuManager.WriteLog(nameof (OnRefreshTopLevelTools));
    Form activeMdiChild = MDIControls.Instance.MDIParent.ActiveMdiChild;
    if (activeMdiChild == null || !MenuManager.IsPolicyDetail(activeMdiChild))
      return;
    menu.FindMergedTool("Policy", (Action<ToolBase>) (policyMenu => this.AddPolicyMenuTools((PopupMenuTool) policyMenu)));
    menu.FindMergedTool("Reports", (Action<ToolBase>) (reportsMenu => this.AddReportMenuTools((PopupMenuTool) reportsMenu)));
  }

  private bool IsRatingWithExcel(Guid entityGuid)
  {
    MenuManager.WriteLog(nameof (IsRatingWithExcel));
    return entityGuid != Guid.Empty && ExcelDataExporter.GetExcelTableName(entityGuid) != null;
  }

  private void AddPolicyMenuTools(PopupMenuTool policyMenu)
  {
    MenuManager.WriteLog(nameof (AddPolicyMenuTools));
    if (!(MDIControls.Instance.MDIParent.ActiveMdiChild is IRecreatableEntity activeMdiChild) || !(activeMdiChild.EntityGuid != Guid.Empty))
      return;
    bool isExcelRated = this.IsRatingWithExcel(activeMdiChild.EntityGuid);
    if (MenuManager.useDynamicCaptureSheets)
      this.ProcessDataCaptureSheets(activeMdiChild.EntityGuid, policyMenu);
    policyMenu.AddOrShowButtonTool("Policy_ViewExcelPremiumData", "MGA Debug: Excel Rating and Premium Information...", (Func<bool>) (() => MGASystems.IMS.Excel.Data.Security.CanViewMGAExcelOptions & isExcelRated));
    policyMenu.AddOrShowButtonTool("Policy_EditReturnedPremiums", "Administrators: View/Adjust Returned Premiums...", (Func<bool>) (() => MGASystems.IMS.Excel.Data.Security.CanEditReturnedPremiums), (Action<ButtonTool>) (button => ((ToolBase) button).SharedProps.MergeOrder = int.MaxValue));
    MenuManager.WriteLog("AddPolicyMenuTools Found Policy Window/Policy Menu", activeMdiChild);
  }

  private void AddReportMenuTools(PopupMenuTool reportsMenu)
  {
    MenuManager.WriteLog(nameof (AddReportMenuTools));
    if (!(MDIControls.Instance.MDIParent.ActiveMdiChild is IRecreatableEntity activeMdiChild) || !(activeMdiChild.EntityGuid != Guid.Empty))
      return;
    bool isExcelRated = this.IsRatingWithExcel(activeMdiChild.EntityGuid);
    reportsMenu.AddOrShowButtonTool("Policy_ExportExcelData", "Export Excel Rating Data", (Func<bool>) (() => MGASystems.IMS.Excel.Data.Security.CanExportExcelRatingData & isExcelRated), (Action<ButtonTool>) (tool => ((ToolPropsBase) ((ToolBase) tool).SharedProps).AppearancesSmall.Appearance.Image = (object) Resources.excel));
  }

  public void ProcessDataCaptureSheets(Guid quoteGuid, PopupMenuTool policyMenu)
  {
    if (this.captureSheetsDictionary.Count > 0)
    {
      foreach (KeyValuePair<string, int> captureSheets in this.captureSheetsDictionary)
      {
        string key = captureSheets.Key;
        if (((KeyedSubObjectsCollectionBase) policyMenu.Tools).Exists(key))
        {
          ToolBase tool1 = ((ToolsCollectionBase) policyMenu.Tools)[key];
          ToolBase tool2 = ((ToolsCollectionBase) policyMenu.Tools)["Reset " + key];
          ((ToolsCollectionBase) policyMenu.Tools).Remove(tool1);
          ((ToolsCollectionBase) policyMenu.Tools).Remove(tool2);
        }
      }
      this.captureSheetsDictionary.Clear();
    }
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("ExcelRating_DetermineCaptureSheetsOnPolicy", new object[2]
    {
      (object) "@QuoteGUID",
      (object) quoteGuid
    });
    if (dataTable.Rows.Count <= 0)
      return;
    foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
    {
      int raterID = row.Field<int>("RatingTypeID");
      if (!this.captureSheetsDictionary.ContainsValue(raterID))
      {
        string key = row.Field<string>("SheetName");
        this.captureSheetsDictionary.Add(key, raterID);
        policyMenu.AddOrShowButtonTool(key, key + "...", 0, (Func<bool>) (() => MGASystems.IMS.Excel.Data.Security.CanInvokeCaptureSheet(raterID)));
        policyMenu.AddOrShowButtonTool("Reset " + key, $"Reset {key}...", 1, (Func<bool>) (() => MGASystems.IMS.Excel.Data.Security.CanResetCaptureSheet(raterID)));
      }
    }
  }
}

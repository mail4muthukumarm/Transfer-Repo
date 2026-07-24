// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.GLMasterAccounts.FormMasterChartSyncAccounts
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Analysis.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.GLMasterAccounts;

public class FormMasterChartSyncAccounts : FormBase
{
  private int _glCompanyId;
  public string sprocName = "spFin_GLMasterGLAccountsMissing";
  private IContainer components;
  internal UltraGrid gridMasterMissingGLAccounts;
  private UltraDropDown dropDownAutomationSettings;
  private UltraDropDown dropDownAccountTypes;
  private dsGLMasterAutomationSettings dsGLMasterAutomationSettings1;
  private dsMasterAccountClassifications dsMasterAccountClassifications1;
  private dsGLAccountMaster dsGLAccountMaster1;
  private dsGLAccountTypes dsGLAccountTypes1;
  private UltraToolbarsManager uTbManagerSyncAcct;
  private UltraToolbarsDockArea _FormMasterChartSync_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormMasterChartSync_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormMasterChartSync_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormMasterChartSync_Toolbars_Dock_Area_Top;

  public FormMasterChartSyncAccounts() => this.InitializeComponent();

  public FormMasterChartSyncAccounts(int glCompanyID)
  {
    this.InitializeComponent();
    this._glCompanyId = glCompanyID;
  }

  private void FormMasterChartSyncAccounts_Load(object sender, EventArgs e)
  {
    if (this._glCompanyId == 0)
      return;
    this.LoadMasterGlAccounts(this._glCompanyId);
    this.LoadAccountTypes();
    this.LoadAutomationSettings();
  }

  public virtual void CreateGLAccounts()
  {
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.RowFilterMode = (RowFilterMode) 1;
    UltraGridBand band = ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Bands[0];
    band.ColumnFilters["Select"].FilterConditions.Add((FilterComparisionOperator) 0, (object) true);
    ((UltraGridBase) this.gridMasterMissingGLAccounts).UpdateData();
    if (((UltraGridBase) this.gridMasterMissingGLAccounts).Rows.GetFilteredInNonGroupByRows().Length == 0)
    {
      int num = (int) MessageBox.Show("You have not selected any GL Accounts to add.", "Nothing Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      band.ColumnFilters.ClearAllFilters();
      ((UltraGridBase) this.gridMasterMissingGLAccounts).UpdateData();
    }
    else
    {
      foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) this.gridMasterMissingGLAccounts).Rows.GetFilteredInNonGroupByRows())
        this.PostGLAccount(this._glCompanyId, (int) filteredInNonGroupByRow.Cells["GLMasterId"].Value);
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }

  public virtual void PostGLAccount(int GLCompanyId, int GLMasterId)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_GLMasterCreateGLAccount", new object[6]
    {
      (object) "@GLCompanyId",
      (object) GLCompanyId,
      (object) "@GLMasterAccountId",
      (object) GLMasterId,
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
  }

  public virtual void LoadMasterGlAccounts(int glCompanyId)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsGLAccountMaster1, new string[1]
    {
      "MasterAccounts"
    }, this.sprocName, new object[2]
    {
      (object) "@GlCompanyID",
      (object) glCompanyId
    });
  }

  private void LoadAccountTypes()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsGLAccountTypes1, new string[1]
    {
      this.dsGLAccountTypes1.Tables[0].TableName
    }, "[spFin_GetFinancialAcctTypes]");
  }

  private void LoadAutomationSettings()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsGLMasterAutomationSettings1, new string[1]
    {
      this.dsGLMasterAutomationSettings1.Tables[0].TableName
    }, "[spFin_GetAccountMasterAutomationSettingsList]");
  }

  private void uTbManagerSyncAcct_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "ADDGLACCOUNTS":
        this.CreateGLAccounts();
        break;
      case "CANCEL":
        this.Close();
        break;
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("MasterAccounts", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("GLMasterId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("GLAccountName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("GLAccountShortName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("GLAccountNumber");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("GLFinancialAccountNumber");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("AcctTypeDescription", -1, (object) "dropDownAccountTypes");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("AutomationSettingId");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("AutomationSetting", -1, (object) "dropDownAutomationSettings");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("IsBankAccount");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Select", 0);
    ColScrollRegion colScrollRegion1 = new ColScrollRegion(977);
    ColScrollRegion colScrollRegion2 = new ColScrollRegion(977);
    ColScrollRegion colScrollRegion3 = new ColScrollRegion(985);
    ColScrollRegion colScrollRegion4 = new ColScrollRegion(985);
    ColScrollRegion colScrollRegion5 = new ColScrollRegion(985);
    ColScrollRegion colScrollRegion6 = new ColScrollRegion(985);
    ColScrollRegion colScrollRegion7 = new ColScrollRegion(676);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridLayout ultraGridLayout1 = new UltraGridLayout("Layout1");
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("MasterAccounts", -1);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("GLMasterId");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("GLAccountName");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("GLAccountShortName");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("GLAccountNumber");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("GLFinancialAccountNumber");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("AcctTypeDescription", -1, (object) "dropDownAccountTypes");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("AutomationSettingId");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("AutomationSetting", -1, (object) "dropDownAutomationSettings");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("IsBankAccount");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Select", 0);
    ColScrollRegion colScrollRegion8 = new ColScrollRegion(977);
    ColScrollRegion colScrollRegion9 = new ColScrollRegion(676);
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    UltraGridLayout ultraGridLayout2 = new UltraGridLayout("Layout2");
    Appearance appearance21 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("MasterAccounts", -1);
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("GLMasterId");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("GLAccountName");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("GLAccountShortName");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("GLAccountNumber");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("GLFinancialAccountNumber");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("AcctTypeDescription", -1, (object) "dropDownAccountTypes");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("AutomationSettingId");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("AutomationSetting", -1, (object) "dropDownAutomationSettings");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("IsBankAccount");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("Select", 0);
    ColScrollRegion colScrollRegion10 = new ColScrollRegion(977);
    ColScrollRegion colScrollRegion11 = new ColScrollRegion(676);
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("AutomationSettings", -1);
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("AutomationSettingId");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("AutomationSetting");
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("TypesList", -1);
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("AcctTypeId");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("AcctTypeDescription");
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("ADDGLACCOUNTS");
    ButtonTool buttonTool2 = new ButtonTool("CANCEL");
    ButtonTool buttonTool3 = new ButtonTool("ADDGLACCOUNTS");
    Appearance appearance58 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("CANCEL");
    Appearance appearance59 = new Appearance();
    this.gridMasterMissingGLAccounts = new UltraGrid();
    this.dropDownAutomationSettings = new UltraDropDown();
    this.dropDownAccountTypes = new UltraDropDown();
    this.dsGLMasterAutomationSettings1 = new dsGLMasterAutomationSettings();
    this.dsMasterAccountClassifications1 = new dsMasterAccountClassifications();
    this.dsGLAccountMaster1 = new dsGLAccountMaster();
    this.dsGLAccountTypes1 = new dsGLAccountTypes();
    this.uTbManagerSyncAcct = new UltraToolbarsManager(this.components);
    this._FormMasterChartSync_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormMasterChartSync_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._FormMasterChartSync_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormMasterChartSync_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.gridMasterMissingGLAccounts).BeginInit();
    ((ISupportInitialize) this.dropDownAutomationSettings).BeginInit();
    ((ISupportInitialize) this.dropDownAccountTypes).BeginInit();
    this.dsGLMasterAutomationSettings1.BeginInit();
    this.dsMasterAccountClassifications1.BeginInit();
    this.dsGLAccountMaster1.BeginInit();
    this.dsGLAccountTypes1.BeginInit();
    ((ISupportInitialize) this.uTbManagerSyncAcct).BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DataSource = (object) this.dsGLAccountMaster1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Master ID";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 1;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 152;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Account Name";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 2;
    ultraGridColumn2.Width = 217;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Account Short Name";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 3;
    ultraGridColumn3.MaxLength = 15;
    ultraGridColumn3.Width = 148;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Account Number";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 4;
    ultraGridColumn4.Width = 100;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 5;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 189;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Account Type";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 6;
    ultraGridColumn6.Style = (ColumnStyle) 6;
    ultraGridColumn6.Width = 217;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 7;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 96 /*0x60*/;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Automation Setting";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 8;
    ultraGridColumn8.Style = (ColumnStyle) 6;
    ultraGridColumn8.Width = 155;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ultraGridColumn9.DefaultCellValue = (object) "False";
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Bank Account";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 9;
    ultraGridColumn9.Width = 105;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn10.Header).Caption = "";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 0;
    ultraGridColumn10.Style = (ColumnStyle) 3;
    ultraGridColumn10.Width = 35;
    ultraGridBand1.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion1);
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion2);
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion3);
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion4);
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion5);
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion6);
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion7);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.Override.TemplateAddRowPrompt = "Please type here to add a new GL Account...";
    ((AppearanceBase) appearance9).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance9).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridMasterMissingGLAccounts).Dock = DockStyle.Fill;
    ((Control) this.gridMasterMissingGLAccounts).Font = new Font("Tahoma", 8.25f);
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout1.Appearance = (AppearanceBase) appearance11;
    ultraGridLayout1.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Master ID";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 1;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 152;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Account Name";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 2;
    ultraGridColumn12.Width = 229;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Account Short Name";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 3;
    ultraGridColumn13.MaxLength = 15;
    ultraGridColumn13.Width = 151;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Account Number";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 4;
    ultraGridColumn14.Width = 102;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 5;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 189;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Account Type";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 6;
    ultraGridColumn16.Style = (ColumnStyle) 6;
    ultraGridColumn16.Width = 230;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 7;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 96 /*0x60*/;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Automation Setting";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 8;
    ultraGridColumn18.Style = (ColumnStyle) 6;
    ultraGridColumn18.Width = 161;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn19.DefaultCellValue = (object) "False";
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Bank Account";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 9;
    ultraGridColumn19.Width = 104;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn20.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn20.Header).Caption = "";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 0;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Style = (ColumnStyle) 3;
    ultraGridColumn20.Width = 28;
    ultraGridBand2.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20
    });
    ultraGridLayout1.BandsSerializer.Add((object) ultraGridBand2);
    ultraGridLayout1.BorderStyle = (UIElementBorderStyle) 4;
    ultraGridLayout1.ColScrollRegions.Add((object) colScrollRegion8);
    ultraGridLayout1.ColScrollRegions.Add((object) colScrollRegion9);
    ((KeyedSubObjectBase) ultraGridLayout1).Key = "Layout1";
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance12).ForeColor = Color.Black;
    ultraGridLayout1.Override.ActiveRowAppearance = (AppearanceBase) appearance12;
    ultraGridLayout1.Override.AllowAddNew = (AllowAddNew) 4;
    ultraGridLayout1.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridLayout1.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridLayout1.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridLayout1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout1.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridLayout1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance13).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.CellAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    ultraGridLayout1.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ultraGridLayout1.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout1.Override.RowAlternateAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.RowAppearance = (AppearanceBase) appearance16;
    ultraGridLayout1.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance17).BackColor = Color.Transparent;
    ((AppearanceBase) appearance17).ForeColor = Color.Black;
    ultraGridLayout1.Override.SelectedRowAppearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).BackColor = Color.LightSteelBlue;
    ultraGridLayout1.Override.TemplateAddRowAppearance = (AppearanceBase) appearance18;
    ultraGridLayout1.Override.TemplateAddRowPrompt = "Please type here to add a new GL Account...";
    ((AppearanceBase) appearance19).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance19).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance20;
    ultraGridLayout1.ScrollBarLook = scrollBarLook2;
    ((AppearanceBase) appearance21).BackColor = Color.White;
    ((AppearanceBase) appearance21).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout2.Appearance = (AppearanceBase) appearance21;
    ultraGridLayout2.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn21.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Master ID";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 1;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 152;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn22.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Account Name";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 2;
    ultraGridColumn22.Width = 277;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn23.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn23.Header).Caption = "Account Short Name";
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 3;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 146;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn24.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn24.Header).Caption = "Account Number";
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 4;
    ultraGridColumn24.Width = 151;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn25.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn25.Header).VisiblePosition = 5;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 189;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn26.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn26.Header).Caption = "Account Type";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn26.Header).VisiblePosition = 6;
    ultraGridColumn26.Style = (ColumnStyle) 6;
    ultraGridColumn26.Width = 236;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn27.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn27.Header).VisiblePosition = 7;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 96 /*0x60*/;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn28.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "Automation Setting";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn28.Header).VisiblePosition = 8;
    ultraGridColumn28.Style = (ColumnStyle) 6;
    ultraGridColumn28.Width = 172;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn29.CellActivation = (Activation) 3;
    ultraGridColumn29.DefaultCellValue = (object) "False";
    ((HeaderBase) ultraGridColumn29.Header).Caption = "Bank Account";
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn29.Header).VisiblePosition = 9;
    ultraGridColumn29.Width = 108;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn30.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn30.Header).Caption = "";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn30.Header).VisiblePosition = 0;
    ultraGridColumn30.Style = (ColumnStyle) 3;
    ultraGridColumn30.Width = 33;
    ultraGridBand3.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30
    });
    ultraGridLayout2.BandsSerializer.Add((object) ultraGridBand3);
    ultraGridLayout2.BorderStyle = (UIElementBorderStyle) 4;
    ultraGridLayout2.ColScrollRegions.Add((object) colScrollRegion10);
    ultraGridLayout2.ColScrollRegions.Add((object) colScrollRegion11);
    ((KeyedSubObjectBase) ultraGridLayout2).Key = "Layout2";
    ((AppearanceBase) appearance22).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance22).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance22).ForeColor = Color.Black;
    ultraGridLayout2.Override.ActiveRowAppearance = (AppearanceBase) appearance22;
    ultraGridLayout2.Override.AllowAddNew = (AllowAddNew) 4;
    ultraGridLayout2.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridLayout2.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridLayout2.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridLayout2.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout2.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance23).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.CellAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance24).TextHAlignAsString = "Left";
    ultraGridLayout2.Override.HeaderAppearance = (AppearanceBase) appearance24;
    ultraGridLayout2.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance25).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout2.Override.RowAlternateAppearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.RowAppearance = (AppearanceBase) appearance26;
    ultraGridLayout2.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance27).BackColor = Color.Transparent;
    ((AppearanceBase) appearance27).ForeColor = Color.Black;
    ultraGridLayout2.Override.SelectedRowAppearance = (AppearanceBase) appearance27;
    ((AppearanceBase) appearance28).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance28).BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance29;
    ultraGridLayout2.ScrollBarLook = scrollBarLook3;
    ((UltraGridBase) this.gridMasterMissingGLAccounts).Layouts.Add(ultraGridLayout1);
    ((UltraGridBase) this.gridMasterMissingGLAccounts).Layouts.Add(ultraGridLayout2);
    ((Control) this.gridMasterMissingGLAccounts).Location = new Point(0, 51);
    ((Control) this.gridMasterMissingGLAccounts).Name = "gridMasterMissingGLAccounts";
    ((Control) this.gridMasterMissingGLAccounts).Size = new Size(979, 399);
    ((Control) this.gridMasterMissingGLAccounts).TabIndex = 1;
    this.gridMasterMissingGLAccounts.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridMasterMissingGLAccounts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridMasterMissingGLAccounts).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dropDownAutomationSettings).DataMember = "AutomationSettings";
    ((AppearanceBase) appearance30).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance30).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 210);
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Appearance = (AppearanceBase) appearance30;
    ultraGridBand4.ColHeadersVisible = false;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn31.Header).VisiblePosition = 0;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn32.Header).VisiblePosition = 1;
    ultraGridColumn32.Width = 285;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn31,
      (object) ultraGridColumn32
    });
    ((AppearanceBase) appearance31).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridBand4.Override.CellAppearance = (AppearanceBase) appearance31;
    ((AppearanceBase) appearance32).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridBand4.Override.RowAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance33).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance33).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance33).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance33).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance33;
    ((AppearanceBase) appearance34).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance34;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance35).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance35).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance35).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance35).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance35;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance36).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance36).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance36;
    ((AppearanceBase) appearance37).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance37).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance37;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance38).BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance38;
    ((AppearanceBase) appearance39).BorderColor = Color.Silver;
    ((AppearanceBase) appearance39).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance40).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance40).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance40).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance40).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance40).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance40;
    ((AppearanceBase) appearance41).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance41;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance42).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance42).BorderColor = Color.Silver;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance42;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance43).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.dropDownAutomationSettings).DisplayMember = "AutomationSetting";
    ((Control) this.dropDownAutomationSettings).Location = new Point(476, 185);
    ((Control) this.dropDownAutomationSettings).Name = "dropDownAutomationSettings";
    ((Control) this.dropDownAutomationSettings).Size = new Size(290, 80 /*0x50*/);
    ((Control) this.dropDownAutomationSettings).TabIndex = 4;
    ((UltraDropDownBase) this.dropDownAutomationSettings).ValueMember = "AutomationSettingId";
    ((Control) this.dropDownAutomationSettings).Visible = false;
    ((UltraGridBase) this.dropDownAccountTypes).DataMember = "TypesList";
    ((AppearanceBase) appearance44).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance44).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 210);
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Appearance = (AppearanceBase) appearance44;
    ultraGridBand5.ColHeadersVisible = false;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn33.Header).VisiblePosition = 0;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn34.Header).VisiblePosition = 1;
    ultraGridColumn34.Width = 272;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn33,
      (object) ultraGridColumn34
    });
    ((AppearanceBase) appearance45).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridBand5.Override.CellAppearance = (AppearanceBase) appearance45;
    ((AppearanceBase) appearance46).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridBand5.Override.RowAppearance = (AppearanceBase) appearance46;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance47).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance47).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance47).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance47).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance47;
    ((AppearanceBase) appearance48).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance48;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance49).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance49).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance49).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance49).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance49;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance50).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance50).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance50;
    ((AppearanceBase) appearance51).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance51).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance51;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance52).BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance52;
    ((AppearanceBase) appearance53).BorderColor = Color.Silver;
    ((AppearanceBase) appearance53).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance53;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance54).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance54).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance54).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance54).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance54).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance54;
    ((AppearanceBase) appearance55).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance55;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance56).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance56).BorderColor = Color.Silver;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance56;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance57).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance57;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.dropDownAccountTypes).DisplayMember = "AcctTypeDescription";
    ((Control) this.dropDownAccountTypes).Location = new Point(213, 185);
    ((Control) this.dropDownAccountTypes).Name = "dropDownAccountTypes";
    ((Control) this.dropDownAccountTypes).Size = new Size(280, 80 /*0x50*/);
    ((Control) this.dropDownAccountTypes).TabIndex = 3;
    ((Control) this.dropDownAccountTypes).Text = "ultraDropDown1";
    ((UltraDropDownBase) this.dropDownAccountTypes).ValueMember = "AcctTypeId";
    ((Control) this.dropDownAccountTypes).Visible = false;
    this.dsGLMasterAutomationSettings1.DataSetName = "dsGLMasterAutomationSettings";
    this.dsGLMasterAutomationSettings1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.dsMasterAccountClassifications1.DataSetName = "dsMasterAccountClassifications";
    this.dsMasterAccountClassifications1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.dsGLAccountMaster1.DataSetName = "dsGLAccountMaster";
    this.dsGLAccountMaster1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.dsGLAccountTypes1.DataSetName = "dsGLAccountTypes";
    this.dsGLAccountTypes1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.uTbManagerSyncAcct.DesignerFlags = 1;
    this.uTbManagerSyncAcct.DockWithinContainer = (Control) this;
    this.uTbManagerSyncAcct.DockWithinContainerBaseType = typeof (FormBase);
    this.uTbManagerSyncAcct.MdiMergeable = false;
    this.uTbManagerSyncAcct.ShowFullMenusDelay = 500;
    this.uTbManagerSyncAcct.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(744, 173);
    ultraToolbar.FloatingSize = new Size(176 /*0xB0*/, 48 /*0x30*/);
    ultraToolbar.IsMainMenuBar = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Text = "UltraToolbar1";
    this.uTbManagerSyncAcct.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance58).Image = (object) Resources.table_refresh;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance58;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Add GL Accounts";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance59).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance59;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.uTbManagerSyncAcct.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.uTbManagerSyncAcct.ToolClick += new ToolClickEventHandler(this.uTbManagerSyncAcct_ToolClick);
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMasterChartSync_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Top).Name = "_FormMasterChartSync_Toolbars_Dock_Area_Top";
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Top).Size = new Size(979, 51);
    this._FormMasterChartSync_Toolbars_Dock_Area_Top.ToolbarsManager = this.uTbManagerSyncAcct;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMasterChartSync_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Bottom).Location = new Point(0, 450);
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Bottom).Name = "_FormMasterChartSync_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Bottom).Size = new Size(979, 0);
    this._FormMasterChartSync_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.uTbManagerSyncAcct;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMasterChartSync_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Left).Location = new Point(0, 51);
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Left).Name = "_FormMasterChartSync_Toolbars_Dock_Area_Left";
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Left).Size = new Size(0, 399);
    this._FormMasterChartSync_Toolbars_Dock_Area_Left.ToolbarsManager = this.uTbManagerSyncAcct;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMasterChartSync_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Right).Location = new Point(979, 51);
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Right).Name = "_FormMasterChartSync_Toolbars_Dock_Area_Right";
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Right).Size = new Size(0, 399);
    this._FormMasterChartSync_Toolbars_Dock_Area_Right.ToolbarsManager = this.uTbManagerSyncAcct;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(979, 450);
    this.Controls.Add((Control) this.dropDownAutomationSettings);
    this.Controls.Add((Control) this.dropDownAccountTypes);
    this.Controls.Add((Control) this.gridMasterMissingGLAccounts);
    this.Controls.Add((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Top);
    this.Name = nameof (FormMasterChartSyncAccounts);
    this.Text = "Master Chart Account Syncronization Utility";
    this.Load += new EventHandler(this.FormMasterChartSyncAccounts_Load);
    ((ISupportInitialize) this.gridMasterMissingGLAccounts).EndInit();
    ((ISupportInitialize) this.dropDownAutomationSettings).EndInit();
    ((ISupportInitialize) this.dropDownAccountTypes).EndInit();
    this.dsGLMasterAutomationSettings1.EndInit();
    this.dsMasterAccountClassifications1.EndInit();
    this.dsGLAccountMaster1.EndInit();
    this.dsGLAccountTypes1.EndInit();
    ((ISupportInitialize) this.uTbManagerSyncAcct).EndInit();
    this.ResumeLayout(false);
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Unaccounted_Management.FormUnaccountedManagement
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Forms;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Unaccounted_Management;

[TestForm]
public class FormUnaccountedManagement : FormBase
{
  private bool _matchesHidden;
  private IContainer components;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraPanel FormUnaccountedManagement_Fill_Panel;
  private UltraToolbarsDockArea _FormUnaccountedManagement_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormUnaccountedManagement_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormUnaccountedManagement_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormUnaccountedManagement_Toolbars_Dock_Area_Top;
  private UltraGrid gridEntityList;
  private Splitter splitter1;
  private UltraGrid gridUnAccountedChanges;
  private UltraGrid gridUnaccountedDetail;
  private Panel panel1;
  private Panel panel2;
  private Label label1;
  private MGASimpleComboBox comboGLCompanyId;
  private PictureBox pictureLoading;

  public FormUnaccountedManagement() => this.InitializeComponent();

  private void FormUnaccountedManagement_Load(object sender, EventArgs e)
  {
    this.LoadGLCompanies();
    this.LoadUnaccountedData();
  }

  private void LoadUnaccountedData()
  {
    ((UltraGridBase) this.gridEntityList).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_UnaccountedManagement");
    this.FormatEntityListGrid();
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridEntityList).Rows).Count == 0)
      return;
    ((GridItemBase) ((UltraGridBase) this.gridEntityList).Rows[0]).Selected = true;
  }

  private void FormatEntityListGrid()
  {
    UltraGridBand band = ((UltraGridBase) this.gridEntityList).DisplayLayout.Bands[0];
    band.Columns["EntityGuid"].Hidden = true;
    ((HeaderBase) band.Columns["Entity Name"].Header).Appearance.TextHAlign = (HAlign) 1;
    band.Columns["Entity Name"].CellAppearance.TextHAlign = (HAlign) 1;
    ((HeaderBase) band.Columns["Entity Type"].Header).Appearance.TextHAlign = (HAlign) 1;
    band.Columns["Entity Name"].CellAppearance.TextHAlign = (HAlign) 1;
    band.Columns["balance"].CellAppearance.TextHAlign = (HAlign) 3;
    ((HeaderBase) band.Columns["balance"].Header).Appearance.TextHAlign = (HAlign) 3;
    band.Columns["balance"].Format = "c";
    band.Summaries.Clear();
    SummarySettings summarySettings = band.Summaries.Add("balanceSum", (SummaryType) 1, band.Columns["balance"]);
    summarySettings.SummaryPosition = (SummaryPosition) 3;
    summarySettings.DisplayFormat = "{0:c}";
    summarySettings.Appearance.TextHAlign = (HAlign) 3;
    summarySettings.Appearance.BackColor = Color.LightSteelBlue;
    summarySettings.Band.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    band.SummaryFooterCaption = string.Empty;
  }

  private void GetEntityUnaccountedDetail(object entityGuid)
  {
    this._matchesHidden = false;
    ((ToolPropsBase) ((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars[0]).Tools)["HIDEMATCHES"].SharedProps).Caption = "Hide Matched Items";
    ((UltraGridBase) this.gridUnaccountedDetail).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_UnaccountedManagement_EntityDetail", new object[2]
    {
      (object) "@entityGuid",
      entityGuid
    });
    this.FormatUnaccountedDetailGrid();
  }

  private void gridEntityList_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
  {
    if (((SparseCollectionBase) this.gridEntityList.Selected.Rows).Count == 0 || ((UltraDropDownBase) this.comboGLCompanyId).SelectedRow == null)
      return;
    this.GetEntityUnaccountedDetail(this.gridEntityList.Selected.Rows[0].Cells["entityGuid"].Value);
    this.LoadEntityAR((int) this.comboGLCompanyId.Value, this.gridEntityList.Selected.Rows[0].Cells["entityGuid"].Value);
  }

  private void FormatUnaccountedDetailGrid()
  {
    UltraGridBand band = ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.Bands[0];
    band.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    band.Columns["invoicenum"].Hidden = true;
    band.Columns["CompanyLineGuid"].Hidden = true;
    band.Columns["chargecode"].Hidden = true;
    band.Columns["Entity Name"].Hidden = true;
    band.Columns["Amount"].CellAppearance.TextHAlign = (HAlign) 3;
    ((HeaderBase) band.Columns["Amount"].Header).Appearance.TextHAlign = (HAlign) 3;
    band.Columns["Amount"].Format = "c";
    ((HeaderBase) band.Columns["Transaction Number"].Header).Caption = "Transaction #";
    ((HeaderBase) band.Columns["postdate"].Header).Caption = "Post Date";
    ((HeaderBase) band.Columns["InsuredPolicyName"].Header).Caption = "Insured";
    ((HeaderBase) band.Columns["PolicyNumber"].Header).Caption = "Policy #";
    band.Summaries.Clear();
    SummarySettings summarySettings = band.Summaries.Add("AmountSum", (SummaryType) 1, band.Columns["Amount"]);
    summarySettings.SummaryPosition = (SummaryPosition) 3;
    summarySettings.DisplayFormat = "{0:c}";
    summarySettings.Appearance.TextHAlign = (HAlign) 3;
    summarySettings.Appearance.BackColor = Color.LightSteelBlue;
    summarySettings.Band.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    band.SummaryFooterCaption = string.Empty;
    this.AdornUnaccountedDetailGrid();
  }

  private void AdornUnaccountedDetailGrid()
  {
    if (((UltraGridBase) this.gridUnaccountedDetail).DataSource == null || !(((UltraGridBase) this.gridUnaccountedDetail).DataSource is DataTable dataSource))
      return;
    List<int> intList = new List<int>();
    foreach (DataRow row1 in (InternalDataCollectionBase) dataSource.Rows)
    {
      DataRow[] dataRowArray = dataSource.Select($"(Amount * -1) = {row1["Amount"]} AND [Transaction Number] > {row1["Transaction Number"]}");
      if (dataRowArray.Length != 0 && !intList.Contains((int) row1["transaction number"]))
      {
        intList.Add((int) row1["transaction number"]);
        intList.Add((int) dataRowArray[0]["transaction number"]);
        foreach (UltraGridRow row2 in ((UltraGridBase) this.gridUnaccountedDetail).Rows)
        {
          if ((Decimal) row2.Cells["Amount"].Value == (Decimal) row1["amount"] * -1M || (int) row2.Cells["Transaction Number"].Value == (int) row1["Transaction Number"])
          {
            if ((int) row2.Cells["Transaction Number"].Value == (int) row1["Transaction Number"])
            {
              ((AppearanceBase) row2.Cells["Transaction Number"].Appearance).Image = (object) Resources.arrow_switch;
              row2.Cells["Transaction Number"].ToolTipText = $"This transaction has an offset. transaction #{dataRowArray[0]["Transaction Number"]}.";
            }
            if ((int) row2.Cells["Transaction Number"].Value == (int) dataRowArray[0]["Transaction Number"])
            {
              ((AppearanceBase) row2.Cells["Transaction Number"].Appearance).Image = (object) Resources.arrow_switch;
              row2.Cells["Transaction Number"].ToolTipText = $"This transaction has an offset. transaction #{row1["Transaction Number"]}.";
            }
          }
        }
      }
    }
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "HIDEMATCHES":
        this.ToggleMatchesHidden();
        break;
    }
  }

  private void ToggleMatchesHidden()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridUnaccountedDetail).Rows)
    {
      if (((AppearanceBase) row.Cells["Transaction Number"].Appearance).Image != null)
        row.Hidden = !this._matchesHidden;
    }
    this._matchesHidden = !this._matchesHidden;
    if (this._matchesHidden)
      ((ToolPropsBase) ((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars[0]).Tools)["HIDEMATCHES"].SharedProps).Caption = "Show Matched Items";
    else
      ((ToolPropsBase) ((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars[0]).Tools)["HIDEMATCHES"].SharedProps).Caption = "Hide Matched Items";
  }

  private void LoadGLCompanies()
  {
    ((UltraGridBase) this.comboGLCompanyId).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboGLCompanyId).ValueMember = "id";
    ((UltraDropDownBase) this.comboGLCompanyId).DisplayMember = "office location";
    this.comboGLCompanyId.SelectedIndex = 0;
  }

  private void LoadEntityAR(int glCompanyId, object entityGuid)
  {
    ((Control) this.gridUnAccountedChanges).Visible = false;
    this.pictureLoading.Visible = true;
    DataTable dt = new DataTable();
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((s, e) => this.DoLoadEntityAR(ref dt, entityGuid, glCompanyId));
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((sender, eArg) =>
      {
        ((Control) this.gridUnAccountedChanges).Visible = true;
        this.pictureLoading.Visible = false;
        ((UltraGridBase) this.gridUnAccountedChanges).DataSource = (object) dt;
        this.FormatInvoiceGrid();
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  private void DoLoadEntityAR(ref DataTable dt, object entityGuid, int glCompanyId)
  {
    dt = DefaultDatabase.ExecuteDataTable("[spFin_GetAR]", new object[6]
    {
      (object) "@RemitterGuid",
      entityGuid,
      (object) "@EntityGuid",
      entityGuid,
      (object) "@GLCompanyId",
      (object) glCompanyId
    });
  }

  private void FormatInvoiceGrid()
  {
    UltraGridBand band = ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Bands[0];
    band.Columns["companyLineGuid"].Hidden = true;
    band.Columns["chargecode"].Hidden = true;
    band.Columns["financeCompanyGuid"].Hidden = true;
    band.Columns["remitterGuid"].Hidden = true;
    band.Columns["costcenterid"].Hidden = true;
    band.Columns["UAGL"].Hidden = true;
    band.Columns["ARGL"].Hidden = true;
    band.Columns["EXGL"].Hidden = true;
    band.Columns["currencycode"].Hidden = true;
    band.Columns["currencycode_functional"].Hidden = true;
    band.Columns["currencycode_reporting"].Hidden = true;
    band.Columns["accountnumber"].Hidden = true;
    band.Columns["quoteid"].Hidden = true;
    band.Columns["lob"].Hidden = true;
    band.Columns["convrate_functional"].Hidden = true;
    band.Columns["convrate_reporting"].Hidden = true;
    band.Columns["invoicenum"].Hidden = true;
    band.Columns["endorsement effective"].Hidden = true;
    band.Columns["producer"].Hidden = true;
    band.Columns["currentstatus"].Hidden = true;
    band.Columns["amtptc"].Hidden = true;
    band.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    ((HeaderBase) band.Columns["quotecontrolnum"].Header).Caption = "Control #";
    ((HeaderBase) band.Columns["officeinvoicenum"].Header).Caption = "Invoice #";
    ((HeaderBase) band.Columns["insuredPolicyName"].Header).Caption = "Insured";
    ((HeaderBase) band.Columns["policyNumber"].Header).Caption = "Policy #";
    ((HeaderBase) band.Columns["effectiveDate"].Header).Caption = "Effective Date";
    ((HeaderBase) band.Columns["expirationDate"].Header).Caption = "Expiration Date";
    ((HeaderBase) band.Columns["invoiceDate"].Header).Caption = "Invoice Date";
    ((HeaderBase) band.Columns["DueDate"].Header).Caption = "Due Date";
    ((HeaderBase) band.Columns["chargename"].Header).Caption = "Description";
    ((HeaderBase) band.Columns["amtbilled"].Header).Appearance.TextHAlign = (HAlign) 3;
    band.Columns["amtbilled"].CellAppearance.TextHAlign = (HAlign) 3;
    ((HeaderBase) band.Columns["amtbilled"].Header).Caption = "Gross Billed";
    band.Columns["amtbilled"].Format = "c";
    ((HeaderBase) band.Columns["amtrtd"].Header).Appearance.TextHAlign = (HAlign) 3;
    band.Columns["amtrtd"].CellAppearance.TextHAlign = (HAlign) 3;
    ((HeaderBase) band.Columns["amtrtd"].Header).Caption = "Amt Rcvd.";
    band.Columns["amtrtd"].Format = "c";
    ((HeaderBase) band.Columns["netdue"].Header).Appearance.TextHAlign = (HAlign) 3;
    band.Columns["netdue"].CellAppearance.TextHAlign = (HAlign) 3;
    ((HeaderBase) band.Columns["netdue"].Header).Caption = "Net Due";
    band.Columns["netdue"].Format = "c";
    ((HeaderBase) band.Columns["UnacctBalance"].Header).Appearance.TextHAlign = (HAlign) 3;
    band.Columns["UnacctBalance"].CellAppearance.TextHAlign = (HAlign) 3;
    ((HeaderBase) band.Columns["UnacctBalance"].Header).Caption = "Unacct Balance";
    band.Columns["UnacctBalance"].Format = "c";
    ((HeaderBase) band.Columns["ExchBalance"].Header).Appearance.TextHAlign = (HAlign) 3;
    band.Columns["ExchBalance"].CellAppearance.TextHAlign = (HAlign) 3;
    ((HeaderBase) band.Columns["ExchBalance"].Header).Caption = "Exch. Balance";
    band.Columns["ExchBalance"].Format = "c";
    if (!((KeyedSubObjectsCollectionBase) band.Columns).Exists("appliedAmt"))
    {
      UltraGridColumn ultraGridColumn = band.Columns.Add("appliedAmt", "Applied Amt");
      ultraGridColumn.DataType = typeof (Decimal);
      ultraGridColumn.CellAppearance.BackColor = Color.LightSteelBlue;
      ultraGridColumn.CellAppearance.TextHAlign = (HAlign) 3;
      ((HeaderBase) ultraGridColumn.Header).Appearance.TextHAlign = (HAlign) 3;
      ultraGridColumn.CellActivation = (Activation) 0;
      ultraGridColumn.Format = "c";
      ((HeaderBase) ultraGridColumn.Header).VisiblePosition = ((HeaderBase) band.Columns["netdue"].Header).VisiblePosition + 1;
    }
    band.Summaries.Clear();
    SummarySettings summarySettings1 = band.Summaries.Add("BilledSum", (SummaryType) 1, band.Columns["amtbilled"], (SummaryPosition) 3);
    summarySettings1.DisplayFormat = "{0:c}";
    summarySettings1.Appearance.TextHAlign = (HAlign) 3;
    summarySettings1.Appearance.BackColor = Color.LightSteelBlue;
    SummarySettings summarySettings2 = band.Summaries.Add("RCVDSum", (SummaryType) 1, band.Columns["amtrtd"], (SummaryPosition) 3);
    summarySettings2.DisplayFormat = "{0:c}";
    summarySettings2.Appearance.TextHAlign = (HAlign) 3;
    summarySettings2.Appearance.BackColor = Color.LightSteelBlue;
    SummarySettings summarySettings3 = band.Summaries.Add("NetDueSum", (SummaryType) 1, band.Columns["netdue"], (SummaryPosition) 3);
    summarySettings3.DisplayFormat = "{0:c}";
    summarySettings3.Appearance.TextHAlign = (HAlign) 3;
    summarySettings3.Appearance.BackColor = Color.LightSteelBlue;
    SummarySettings summarySettings4 = band.Summaries.Add("UnacctSum", (SummaryType) 1, band.Columns["UnacctBalance"], (SummaryPosition) 3);
    summarySettings4.DisplayFormat = "{0:c}";
    summarySettings4.Appearance.TextHAlign = (HAlign) 3;
    summarySettings4.Appearance.BackColor = Color.LightSteelBlue;
    SummarySettings summarySettings5 = band.Summaries.Add("ExchSum", (SummaryType) 1, band.Columns["ExchBalance"], (SummaryPosition) 3);
    summarySettings5.DisplayFormat = "{0:c}";
    summarySettings5.Appearance.TextHAlign = (HAlign) 3;
    summarySettings5.Appearance.BackColor = Color.LightSteelBlue;
    SummarySettings summarySettings6 = band.Summaries.Add("AppliedSum", (SummaryType) 1, band.Columns["appliedAmt"], (SummaryPosition) 3);
    summarySettings6.DisplayFormat = "{0:c}";
    summarySettings6.Appearance.TextHAlign = (HAlign) 3;
    summarySettings6.Appearance.BackColor = Color.LightSteelBlue;
    band.Override.SummaryFooterAppearance.BackColor = Color.LightSteelBlue;
    band.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    band.Columns["OfficeInvoiceNum"].Style = (ColumnStyle) 2;
    band.Columns["OfficeInvoiceNum"].ButtonDisplayStyle = (ButtonDisplayStyle) 0;
    band.Columns["OfficeInvoiceNum"].CellButtonAppearance.Image = (object) Resources.wrench_orange;
  }

  private void gridUnaccountedDetail_ClickCellButton(object sender, CellEventArgs e)
  {
    if (((SparseCollectionBase) this.gridUnAccountedChanges.Selected.Rows).Count == 0)
      return;
    this.gridUnAccountedChanges.Selected.Rows[0].Cells["appliedAmt"].Value = e.Cell.Row.Cells["Amount"].Value;
  }

  private void gridUnAccountedChanges_ClickCellButton(object sender, CellEventArgs e)
  {
    if (((SparseCollectionBase) this.gridUnaccountedDetail.Selected.Rows).Count == 0 || !(((KeyedSubObjectBase) e.Cell.Column).Key == "OfficeInvoiceNum"))
      return;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Bands[0].ColumnFilters["OfficeInvoiceNum"].FilterConditions.Add((FilterComparisionOperator) 0, e.Cell.Value);
    UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridUnAccountedChanges).Rows.GetFilteredInNonGroupByRows();
    for (int index = 0; index < inNonGroupByRows.Length; ++index)
      inNonGroupByRows[index].Cells["appliedamt"].Value = inNonGroupByRows[index].Cells["netdue"].Value;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
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
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("PROCESS");
    ButtonTool buttonTool2 = new ButtonTool("HIDEMATCHES");
    ButtonTool buttonTool3 = new ButtonTool("PROCESS");
    Appearance appearance1 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("HIDEMATCHES");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormUnaccountedManagement));
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.FormUnaccountedManagement_Fill_Panel = new UltraPanel();
    this.gridUnaccountedDetail = new UltraGrid();
    this.panel1 = new Panel();
    this.gridEntityList = new UltraGrid();
    this.splitter1 = new Splitter();
    this.gridUnAccountedChanges = new UltraGrid();
    this.pictureLoading = new PictureBox();
    this._FormUnaccountedManagement_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormUnaccountedManagement_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormUnaccountedManagement_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormUnaccountedManagement_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.panel2 = new Panel();
    this.label1 = new Label();
    this.comboGLCompanyId = new MGASimpleComboBox();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((Control) this.FormUnaccountedManagement_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.FormUnaccountedManagement_Fill_Panel).SuspendLayout();
    ((ISupportInitialize) this.gridUnaccountedDetail).BeginInit();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.gridEntityList).BeginInit();
    ((ISupportInitialize) this.gridUnAccountedChanges).BeginInit();
    ((ISupportInitialize) this.pictureLoading).BeginInit();
    this.panel2.SuspendLayout();
    ((ISupportInitialize) this.comboGLCompanyId).BeginInit();
    this.SuspendLayout();
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(481, 154);
    ultraToolbar.FloatingSize = new Size(261, 86);
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
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((SettingsBase) ultraToolbar.Settings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ultraToolbar.Text = "UltraToolbar1";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    this.ultraToolbarsManager1.ToolbarSettings.CaptionPlacement = (TextPlacement) 2;
    ((AppearanceBase) appearance1).Image = (object) Resources.bricks;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance1;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Process Un-Accounted";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance2).Image = (object) Resources.arrow_switch;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Hide Matched Items";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ((UltraComponentControlManagerBase) this.ultraToolbarsManager1).UseOsThemes = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((AppearanceBase) appearance3).BackColor = Color.Transparent;
    this.FormUnaccountedManagement_Fill_Panel.Appearance = (AppearanceBase) appearance3;
    ((Control) this.FormUnaccountedManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.gridUnaccountedDetail);
    ((Control) this.FormUnaccountedManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.panel1);
    ((Control) this.FormUnaccountedManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.splitter1);
    ((Control) this.FormUnaccountedManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.gridUnAccountedChanges);
    ((Control) this.FormUnaccountedManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.pictureLoading);
    ((Control) this.FormUnaccountedManagement_Fill_Panel).Cursor = Cursors.Default;
    ((Control) this.FormUnaccountedManagement_Fill_Panel).Dock = DockStyle.Fill;
    ((Control) this.FormUnaccountedManagement_Fill_Panel).Location = new Point(0, 73);
    ((Control) this.FormUnaccountedManagement_Fill_Panel).Name = "FormUnaccountedManagement_Fill_Panel";
    ((Control) this.FormUnaccountedManagement_Fill_Panel).Size = new Size(1213, 645);
    ((Control) this.FormUnaccountedManagement_Fill_Panel).TabIndex = 0;
    ((AppearanceBase) appearance4).BackColor = Color.Transparent;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BackColor = Color.Transparent;
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance11).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridUnaccountedDetail).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridUnaccountedDetail).Dock = DockStyle.Fill;
    ((Control) this.gridUnaccountedDetail).Location = new Point(548, 0);
    ((Control) this.gridUnaccountedDetail).Name = "gridUnaccountedDetail";
    ((Control) this.gridUnaccountedDetail).Size = new Size(665, 0);
    ((Control) this.gridUnaccountedDetail).TabIndex = 3;
    ((UltraControlBase) this.gridUnaccountedDetail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridUnaccountedDetail).UseOsThemes = (DefaultableBoolean) 2;
    this.gridUnaccountedDetail.ClickCellButton += new CellEventHandler(this.gridUnaccountedDetail_ClickCellButton);
    this.panel1.Controls.Add((Control) this.gridEntityList);
    this.panel1.Dock = DockStyle.Left;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(548, 0);
    this.panel1.TabIndex = 4;
    ((AppearanceBase) appearance13).BackColor = Color.Transparent;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Appearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance15).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance16).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance19).BackColor = Color.Transparent;
    ((AppearanceBase) appearance19).ForeColor = Color.Black;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance20).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridEntityList).Dock = DockStyle.Fill;
    ((Control) this.gridEntityList).Location = new Point(0, 0);
    ((Control) this.gridEntityList).Name = "gridEntityList";
    ((Control) this.gridEntityList).Size = new Size(548, 0);
    ((Control) this.gridEntityList).TabIndex = 2;
    ((UltraControlBase) this.gridEntityList).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridEntityList).UseOsThemes = (DefaultableBoolean) 2;
    this.gridEntityList.AfterSelectChange += new AfterSelectChangeEventHandler(this.gridEntityList_AfterSelectChange);
    this.splitter1.BackColor = Color.DarkSlateGray;
    this.splitter1.Cursor = Cursors.HSplit;
    this.splitter1.Dock = DockStyle.Bottom;
    this.splitter1.Location = new Point(0, -68);
    this.splitter1.Name = "splitter1";
    this.splitter1.Size = new Size(1213, 3);
    this.splitter1.TabIndex = 1;
    this.splitter1.TabStop = false;
    ((AppearanceBase) appearance22).BackColor = Color.White;
    ((AppearanceBase) appearance22).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Appearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance23).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance23).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance23).ForeColor = Color.Black;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((AppearanceBase) appearance24).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance25).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance26).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance26;
    ((AppearanceBase) appearance27).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance28).BackColor = Color.Transparent;
    ((AppearanceBase) appearance28).ForeColor = Color.Black;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance29).BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance29;
    ((AppearanceBase) appearance30).BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.gridUnAccountedChanges).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((Control) this.gridUnAccountedChanges).Dock = DockStyle.Bottom;
    ((Control) this.gridUnAccountedChanges).Location = new Point(0, -65);
    ((Control) this.gridUnAccountedChanges).Name = "gridUnAccountedChanges";
    ((Control) this.gridUnAccountedChanges).Size = new Size(1213, 355);
    ((Control) this.gridUnAccountedChanges).TabIndex = 0;
    ((UltraControlBase) this.gridUnAccountedChanges).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridUnAccountedChanges).UseOsThemes = (DefaultableBoolean) 2;
    this.gridUnAccountedChanges.ClickCellButton += new CellEventHandler(this.gridUnAccountedChanges_ClickCellButton);
    this.pictureLoading.BackColor = Color.White;
    this.pictureLoading.Dock = DockStyle.Bottom;
    this.pictureLoading.Image = (Image) componentResourceManager.GetObject("pictureLoading.Image");
    this.pictureLoading.Location = new Point(0, 290);
    this.pictureLoading.Name = "pictureLoading";
    this.pictureLoading.Size = new Size(1213, 355);
    this.pictureLoading.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureLoading.TabIndex = 0;
    this.pictureLoading.TabStop = false;
    this.pictureLoading.Visible = false;
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormUnaccountedManagement_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Left).Location = new Point(0, 45);
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Left).Name = "_FormUnaccountedManagement_Toolbars_Dock_Area_Left";
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Left).Size = new Size(0, 673);
    this._FormUnaccountedManagement_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormUnaccountedManagement_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Right).Location = new Point(1213, 45);
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Right).Name = "_FormUnaccountedManagement_Toolbars_Dock_Area_Right";
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Right).Size = new Size(0, 673);
    this._FormUnaccountedManagement_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormUnaccountedManagement_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Top).Name = "_FormUnaccountedManagement_Toolbars_Dock_Area_Top";
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Top).Size = new Size(1213, 45);
    this._FormUnaccountedManagement_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormUnaccountedManagement_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Bottom).Location = new Point(0, 718);
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Bottom).Name = "_FormUnaccountedManagement_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Bottom).Size = new Size(1213, 0);
    this._FormUnaccountedManagement_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.panel2.BackColor = Color.LightSteelBlue;
    this.panel2.Controls.Add((Control) this.label1);
    this.panel2.Controls.Add((Control) this.comboGLCompanyId);
    this.panel2.Dock = DockStyle.Top;
    this.panel2.Location = new Point(0, 45);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(1213, 28);
    this.panel2.TabIndex = 5;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(12, 6);
    this.label1.Name = "label1";
    this.label1.Size = new Size(71, 13);
    this.label1.TabIndex = 1;
    this.label1.Text = "GL Company:";
    this.comboGLCompanyId.BorderStyle = (UIElementBorderStyle) 4;
    this.comboGLCompanyId.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboGLCompanyId).Location = new Point(89, 4);
    this.comboGLCompanyId.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboGLCompanyId).Name = "comboGLCompanyId";
    ((Control) this.comboGLCompanyId).Size = new Size(281, 21);
    ((Control) this.comboGLCompanyId).TabIndex = 0;
    ((UltraControlBase) this.comboGLCompanyId).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboGLCompanyId).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1213, 718);
    this.Controls.Add((Control) this.FormUnaccountedManagement_Fill_Panel);
    this.Controls.Add((Control) this.panel2);
    this.Controls.Add((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormUnaccountedManagement_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormUnaccountedManagement);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Un-Accounted Management";
    this.Load += new EventHandler(this.FormUnaccountedManagement_Load);
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((Control) this.FormUnaccountedManagement_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.FormUnaccountedManagement_Fill_Panel).ResumeLayout(false);
    ((ISupportInitialize) this.gridUnaccountedDetail).EndInit();
    this.panel1.ResumeLayout(false);
    ((ISupportInitialize) this.gridEntityList).EndInit();
    ((ISupportInitialize) this.gridUnAccountedChanges).EndInit();
    ((ISupportInitialize) this.pictureLoading).EndInit();
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    ((ISupportInitialize) this.comboGLCompanyId).EndInit();
    this.ResumeLayout(false);
  }
}

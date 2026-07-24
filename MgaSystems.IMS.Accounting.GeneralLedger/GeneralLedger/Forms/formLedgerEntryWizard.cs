// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.formLedgerEntryWizard
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinDataSource;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

public class formLedgerEntryWizard : Form
{
  private IContainer components;
  private MGAButton btnBack;
  private MGAButton btnNext;
  private Label lblCreditsTotal;
  private Label lblDebitsTotal;
  private int _glCompanyID;
  private Decimal _debitsTotal;
  private Decimal _creditsTotal;
  private PictureBox pictureBox1;
  private UltraLabel ultraLabel9;
  internal MGADateTimePicker dateTimePostDate;
  private Label label5;
  private UltraLabel ultraLabel8;
  private JournalEntry _journal;
  private UltraToolbarsManager toolManager;
  private UltraToolbarsDockArea _formLedgerEntryWizard_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _formLedgerEntryWizard_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _formLedgerEntryWizard_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formLedgerEntryWizard_Toolbars_Dock_Area_Right;
  private Panel pnlBottom;
  internal MGAButton btnFinish;
  private MGAButton btnCancel;
  private SqlCommand sqlSelectCommand1;
  private SqlConnection FormDataConnection;
  private Panel panelTop;
  private Label label1;
  private Panel pnlContainer;
  private UltraGrid grid;
  private Panel pnlContainerSide;
  private ExtendedTreeViewDropDown dropTreeGLAccounts;
  private MGAButton btnAdd;
  private MGATextBox txtAmount;
  private MGATextBox txtComments;
  private MGASimpleComboBox comboCostCenters;
  internal MGASimpleComboBox comboType;
  private UltraLabel ultraLabel5;
  private UltraLabel ultraLabel7;
  private UltraLabel ultraLabel3;
  private UltraLabel ultraLabel2;
  private UltraLabel ultraLabel1;
  private UltraLabel ultraLabel6;
  internal MGASimpleComboBox comboOfficeLocation;
  private UltraLabel ultraLabel4;
  private MGAButton btnCancelChanges;
  private UltraLabel lblSideBar;
  private Panel pnlSummary;
  private Label label4;
  private Label label3;
  private MGATextBox textComments;
  private Label label6;
  private dsOfficeLocations dsOfficeLocations1;
  private UltraDataSource dataSource;
  private UltraDataSource comboSource;
  private SqlDataAdapter daGetOfficeLocations;
  private Label lblLine;
  private bool _isInEditMode;

  public formLedgerEntryWizard()
  {
    this.InitializeComponent();
    this.dropTreeGLAccounts.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.dropTreeGLAccounts.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.dsOfficeLocations1 = Methods.GetOfficeLocationDataset();
    this.comboSource.Rows.Add(true, new object[2]
    {
      (object) "Credit",
      (object) "0"
    }, true);
    this.comboSource.Rows.Add(true, new object[2]
    {
      (object) "Debit",
      (object) "1"
    }, true);
    ((UltraGridBase) this.comboType).DataSource = (object) this.comboSource;
    ((UltraGridBase) this.comboType).DataMember = "Band 0";
    ((UltraDropDownBase) this.comboType).DisplayMember = "Key";
    ((UltraDropDownBase) this.comboType).ValueMember = "Value";
    this.comboType.Value = (object) 1;
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
    PopupMenuTool popupMenuTool = new PopupMenuTool("ContextMenu");
    ButtonTool buttonTool1 = new ButtonTool("Edit");
    ButtonTool buttonTool2 = new ButtonTool("Delete");
    ButtonTool buttonTool3 = new ButtonTool("Edit");
    Appearance appearance1 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("Delete");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("Band 0", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("TransactionType");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("GlAccountName");
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("GlAccountId");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CostCenterName");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CostCenterId");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Amount");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Comments");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraDataColumn ultraDataColumn1 = new UltraDataColumn("TransactionType");
    UltraDataColumn ultraDataColumn2 = new UltraDataColumn("GlAccountName");
    UltraDataColumn ultraDataColumn3 = new UltraDataColumn("GlAccountId");
    UltraDataColumn ultraDataColumn4 = new UltraDataColumn("CostCenterName");
    UltraDataColumn ultraDataColumn5 = new UltraDataColumn("CostCenterId");
    UltraDataColumn ultraDataColumn6 = new UltraDataColumn("Amount");
    UltraDataColumn ultraDataColumn7 = new UltraDataColumn("Comments");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formLedgerEntryWizard));
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    UltraDataColumn ultraDataColumn8 = new UltraDataColumn("Key");
    UltraDataColumn ultraDataColumn9 = new UltraDataColumn("Value");
    this.toolManager = new UltraToolbarsManager(this.components);
    this.grid = new UltraGrid();
    this.dataSource = new UltraDataSource(this.components);
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.pnlBottom = new Panel();
    this.btnFinish = new MGAButton();
    this.btnBack = new MGAButton();
    this.btnNext = new MGAButton();
    this.btnCancel = new MGAButton();
    this.sqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.panelTop = new Panel();
    this.lblLine = new Label();
    this.label1 = new Label();
    this.pictureBox1 = new PictureBox();
    this.pnlContainer = new Panel();
    this.pnlContainerSide = new Panel();
    this.ultraLabel9 = new UltraLabel();
    this.ultraLabel7 = new UltraLabel();
    this.dropTreeGLAccounts = new ExtendedTreeViewDropDown();
    this.btnAdd = new MGAButton();
    this.txtAmount = new MGATextBox();
    this.txtComments = new MGATextBox();
    this.comboCostCenters = new MGASimpleComboBox();
    this.comboType = new MGASimpleComboBox();
    this.ultraLabel5 = new UltraLabel();
    this.ultraLabel3 = new UltraLabel();
    this.ultraLabel2 = new UltraLabel();
    this.ultraLabel1 = new UltraLabel();
    this.ultraLabel6 = new UltraLabel();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.dsOfficeLocations1 = new dsOfficeLocations();
    this.ultraLabel4 = new UltraLabel();
    this.btnCancelChanges = new MGAButton();
    this.lblSideBar = new UltraLabel();
    this.pnlSummary = new Panel();
    this.dateTimePostDate = new MGADateTimePicker();
    this.label5 = new Label();
    this.label4 = new Label();
    this.label3 = new Label();
    this.lblCreditsTotal = new Label();
    this.lblDebitsTotal = new Label();
    this.textComments = new MGATextBox();
    this.label6 = new Label();
    this.ultraLabel8 = new UltraLabel();
    this.comboSource = new UltraDataSource(this.components);
    this.daGetOfficeLocations = new SqlDataAdapter();
    ((ISupportInitialize) this.toolManager).BeginInit();
    ((ISupportInitialize) this.grid).BeginInit();
    ((ISupportInitialize) this.dataSource).BeginInit();
    this.pnlBottom.SuspendLayout();
    ((ISupportInitialize) this.btnFinish).BeginInit();
    ((ISupportInitialize) this.btnBack).BeginInit();
    ((ISupportInitialize) this.btnNext).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.panelTop.SuspendLayout();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.pnlContainer.SuspendLayout();
    this.pnlContainerSide.SuspendLayout();
    ((ISupportInitialize) this.btnAdd).BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.txtComments).BeginInit();
    ((ISupportInitialize) this.comboCostCenters).BeginInit();
    ((ISupportInitialize) this.comboType).BeginInit();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    this.dsOfficeLocations1.BeginInit();
    ((ISupportInitialize) this.btnCancelChanges).BeginInit();
    this.pnlSummary.SuspendLayout();
    ((ISupportInitialize) this.dateTimePostDate).BeginInit();
    ((ISupportInitialize) this.textComments).BeginInit();
    ((ISupportInitialize) this.comboSource).BeginInit();
    this.SuspendLayout();
    this.toolManager.DesignerFlags = 0;
    this.toolManager.DockWithinContainer = (Control) this;
    this.toolManager.DockWithinContainerBaseType = typeof (Form);
    this.toolManager.ShowFullMenusDelay = 500;
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).Caption = "ContextMenu";
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ((AppearanceBase) appearance1).Image = componentResourceManager.GetObject("appearance36.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance1;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).Caption = "&Edit";
    ((AppearanceBase) appearance2).Image = componentResourceManager.GetObject("appearance37.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = "&Delete";
    ((ToolsCollectionBase) this.toolManager.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.toolManager.BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.toolManager_BeforeToolDropdown);
    this.toolManager.ToolClick += new ToolClickEventHandler(this.toolManager_ToolClick);
    this.toolManager.SetContextMenuUltra((Component) this.grid, "ContextMenu");
    ((UltraGridBase) this.grid).DataMember = "Band 0";
    ((UltraGridBase) this.grid).DataSource = (object) this.dataSource;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.grid).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.grid).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Transaction Type";
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = (int) sbyte.MaxValue;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "GL Account";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 2;
    ultraGridColumn2.Width = 175;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 6;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 95;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Cost Center";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 1;
    ultraGridColumn4.Width = 149;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 5;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 95;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance7;
    ultraGridColumn6.Format = "C";
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 3;
    ultraGridColumn6.Width = 133;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 4;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 70;
    ultraGridBand.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((UltraGridBase) this.grid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.grid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((UltraGridBase) this.grid).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.grid).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.grid).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.grid).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BorderColor = Color.LightGray;
    ((UltraGridBase) this.grid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.grid).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.grid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.grid).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BorderColor = Color.LightGray;
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance14).BackColor = Color.Transparent;
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((UltraGridBase) this.grid).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance15).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.grid).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.grid).Dock = DockStyle.Fill;
    ((Control) this.grid).Font = new Font("Tahoma", 8f);
    ((Control) this.grid).Location = new Point(0, 0);
    ((Control) this.grid).Name = "grid";
    ((Control) this.grid).Size = new Size(586, 384);
    ((Control) this.grid).TabIndex = 0;
    ((UltraControlBase) this.grid).UseOsThemes = (DefaultableBoolean) 2;
    ultraDataColumn6.DataType = typeof (Decimal);
    this.dataSource.Band.Columns.AddRange(new object[7]
    {
      (object) ultraDataColumn1,
      (object) ultraDataColumn2,
      (object) ultraDataColumn3,
      (object) ultraDataColumn4,
      (object) ultraDataColumn5,
      (object) ultraDataColumn6,
      (object) ultraDataColumn7
    });
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Top).Name = "_formLedgerEntryWizard_Toolbars_Dock_Area_Top";
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Top).Size = new Size(906, 0);
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Top.ToolbarsManager = this.toolManager;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom).Location = new Point(0, 504);
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom).Name = "_formLedgerEntryWizard_Toolbars_Dock_Area_Bottom";
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom).Size = new Size(906, 0);
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.toolManager;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Left).Name = "_formLedgerEntryWizard_Toolbars_Dock_Area_Left";
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Left).Size = new Size(0, 504);
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Left.ToolbarsManager = this.toolManager;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Right).Location = new Point(906, 0);
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Right).Name = "_formLedgerEntryWizard_Toolbars_Dock_Area_Right";
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Right).Size = new Size(0, 504);
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Right.ToolbarsManager = this.toolManager;
    this.pnlBottom.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.pnlBottom.Controls.Add((Control) this.btnFinish);
    this.pnlBottom.Controls.Add((Control) this.btnBack);
    this.pnlBottom.Controls.Add((Control) this.btnNext);
    this.pnlBottom.Controls.Add((Control) this.btnCancel);
    this.pnlBottom.Dock = DockStyle.Bottom;
    this.pnlBottom.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.pnlBottom.ForeColor = Color.Black;
    this.pnlBottom.Location = new Point(0, 464);
    this.pnlBottom.Name = "pnlBottom";
    this.pnlBottom.Size = new Size(906, 40);
    this.pnlBottom.TabIndex = 188;
    ((Control) this.btnFinish).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance17).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance17).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance17).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance17).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance17).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnFinish).Appearance = (AppearanceBase) appearance17;
    ((Control) this.btnFinish).Enabled = false;
    ((Control) this.btnFinish).Location = new Point(712, 8);
    ((Control) this.btnFinish).Name = "btnFinish";
    ((Control) this.btnFinish).Size = new Size(88, 24);
    ((Control) this.btnFinish).TabIndex = 2;
    ((Control) this.btnFinish).Text = "Finish";
    ((UltraControlBase) this.btnFinish).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnFinish).Click += new EventHandler(this.btnFinish_Click);
    ((Control) this.btnBack).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance18).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance18).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance18).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance18).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance18).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnBack).Appearance = (AppearanceBase) appearance18;
    ((ControlBase) this.btnBack).BackColorInternal = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((Control) this.btnBack).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnBack).ForeColor = Color.Black;
    ((Control) this.btnBack).Location = new Point(488, 8);
    ((Control) this.btnBack).Name = "btnBack";
    ((Control) this.btnBack).Size = new Size(88, 24);
    ((Control) this.btnBack).TabIndex = 0;
    ((Control) this.btnBack).Text = "<< &Back";
    ((UltraControlBase) this.btnBack).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnBack).Click += new EventHandler(this.btnBack_Click);
    ((Control) this.btnNext).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance19).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance19).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance19).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance19).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance19).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance19).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnNext).Appearance = (AppearanceBase) appearance19;
    ((ControlBase) this.btnNext).BackColorInternal = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((Control) this.btnNext).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnNext).ForeColor = Color.Black;
    ((Control) this.btnNext).Location = new Point(584, 8);
    ((Control) this.btnNext).Name = "btnNext";
    ((Control) this.btnNext).Size = new Size(88, 24);
    ((Control) this.btnNext).TabIndex = 1;
    ((Control) this.btnNext).Text = "&Next >>";
    ((UltraControlBase) this.btnNext).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnNext).Click += new EventHandler(this.btnNext_Click);
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance20).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance20).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance20).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance20).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance20).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance20;
    ((Control) this.btnCancel).Location = new Point(808, 8);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(88, 24);
    ((Control) this.btnCancel).TabIndex = 3;
    ((Control) this.btnCancel).Text = "Cancel";
    ((UltraControlBase) this.btnCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Click += new EventHandler(this.btnCancel_Click);
    this.sqlSelectCommand1.CommandText = "[spFin_GetOfficeLocations]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.FormDataConnection;
    this.sqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.panelTop.BackColor = Color.White;
    this.panelTop.Controls.Add((Control) this.lblLine);
    this.panelTop.Controls.Add((Control) this.label1);
    this.panelTop.Controls.Add((Control) this.pictureBox1);
    this.panelTop.Dock = DockStyle.Top;
    this.panelTop.Location = new Point(0, 0);
    this.panelTop.Name = "panelTop";
    this.panelTop.Size = new Size(906, 80 /*0x50*/);
    this.panelTop.TabIndex = 187;
    this.lblLine.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.lblLine.Dock = DockStyle.Bottom;
    this.lblLine.Location = new Point(0, 79);
    this.lblLine.Name = "lblLine";
    this.lblLine.Size = new Size(906, 1);
    this.lblLine.TabIndex = 1;
    this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Arial", 14f, FontStyle.Bold);
    this.label1.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label1.Location = new Point(699, 48 /*0x30*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(204, 22);
    this.label1.TabIndex = 0;
    this.label1.Text = "Journal Entry Wizard";
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(0, -8);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(96 /*0x60*/, 88);
    this.pictureBox1.TabIndex = 2;
    this.pictureBox1.TabStop = false;
    this.pnlContainer.BackColor = Color.White;
    this.pnlContainer.Controls.Add((Control) this.grid);
    this.pnlContainer.Dock = DockStyle.Fill;
    this.pnlContainer.Location = new Point(320, 80 /*0x50*/);
    this.pnlContainer.Name = "pnlContainer";
    this.pnlContainer.Size = new Size(586, 384);
    this.pnlContainer.TabIndex = 182;
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel9);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel7);
    this.pnlContainerSide.Controls.Add((Control) this.dropTreeGLAccounts);
    this.pnlContainerSide.Controls.Add((Control) this.btnAdd);
    this.pnlContainerSide.Controls.Add((Control) this.txtAmount);
    this.pnlContainerSide.Controls.Add((Control) this.txtComments);
    this.pnlContainerSide.Controls.Add((Control) this.comboCostCenters);
    this.pnlContainerSide.Controls.Add((Control) this.comboType);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel5);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel3);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel2);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel1);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel6);
    this.pnlContainerSide.Controls.Add((Control) this.comboOfficeLocation);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel4);
    this.pnlContainerSide.Controls.Add((Control) this.btnCancelChanges);
    this.pnlContainerSide.Controls.Add((Control) this.lblSideBar);
    this.pnlContainerSide.Dock = DockStyle.Left;
    this.pnlContainerSide.Location = new Point(0, 80 /*0x50*/);
    this.pnlContainerSide.Name = "pnlContainerSide";
    this.pnlContainerSide.Size = new Size(320, 384);
    this.pnlContainerSide.TabIndex = 207;
    ((AppearanceBase) appearance21).BackColor = Color.White;
    ((AppearanceBase) appearance21).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance21).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance21).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance21).ForeColor = Color.DimGray;
    ((ControlBase) this.ultraLabel9).Appearance = (AppearanceBase) appearance21;
    ((Control) this.ultraLabel9).AutoSize = true;
    ((ControlBase) this.ultraLabel9).BackColorInternal = Color.White;
    ((Control) this.ultraLabel9).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel9).ForeColor = Color.Black;
    ((Control) this.ultraLabel9).Location = new Point(8, 8);
    ((Control) this.ultraLabel9).Name = "ultraLabel9";
    ((Control) this.ultraLabel9).Size = new Size(120, 15);
    ((Control) this.ultraLabel9).TabIndex = 206;
    ((Control) this.ultraLabel9).Text = "Journal Entry Wizard";
    ((AppearanceBase) appearance22).BackColor = Color.White;
    ((AppearanceBase) appearance22).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance22).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance22).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance22).ForeColor = Color.DimGray;
    ((ControlBase) this.ultraLabel7).Appearance = (AppearanceBase) appearance22;
    ((ControlBase) this.ultraLabel7).BackColorInternal = Color.White;
    ((Control) this.ultraLabel7).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel7).ForeColor = Color.Black;
    ((Control) this.ultraLabel7).Location = new Point(8, 24);
    ((Control) this.ultraLabel7).Name = "ultraLabel7";
    ((Control) this.ultraLabel7).Size = new Size(304, 72);
    ((Control) this.ultraLabel7).TabIndex = 203;
    ((Control) this.ultraLabel7).Text = componentResourceManager.GetString("ultraLabel7.Text");
    this.dropTreeGLAccounts.BackColor = Color.White;
    this.dropTreeGLAccounts.DropDownHeight = 300;
    this.dropTreeGLAccounts.DropDownWidth = 300;
    this.dropTreeGLAccounts.Font = new Font("Tahoma", 8f);
    this.dropTreeGLAccounts.ForeColor = Color.Black;
    this.dropTreeGLAccounts.Location = new Point(96 /*0x60*/, 136);
    this.dropTreeGLAccounts.Name = "dropTreeGLAccounts";
    this.dropTreeGLAccounts.ShowEquityAccounts = true;
    this.dropTreeGLAccounts.ShowExpenseAccounts = true;
    this.dropTreeGLAccounts.ShowIncomeAccounts = true;
    this.dropTreeGLAccounts.ShowSystemDefinedAccounts = true;
    this.dropTreeGLAccounts.Size = new Size(216, 20);
    this.dropTreeGLAccounts.TabIndex = 1;
    this.dropTreeGLAccounts.UseCheckedStateSelectionOverride = false;
    ((AppearanceBase) appearance23).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance23).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance23).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance23).BorderColor = Color.DarkGray;
    ((ControlBase) this.btnAdd).Appearance = (AppearanceBase) appearance23;
    ((ControlBase) this.btnAdd).BackColorInternal = Color.White;
    ((Control) this.btnAdd).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnAdd).ForeColor = Color.Black;
    ((Control) this.btnAdd).Location = new Point(96 /*0x60*/, 352);
    ((Control) this.btnAdd).Name = "btnAdd";
    ((Control) this.btnAdd).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnAdd).TabIndex = 6;
    ((Control) this.btnAdd).Text = "&Add";
    ((UltraControlBase) this.btnAdd).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnAdd).Click += new EventHandler(this.btnAdd_Click);
    ((AppearanceBase) appearance24).BackColor = Color.White;
    ((AppearanceBase) appearance24).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance24).ForeColor = Color.Black;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.txtAmount).Appearance = (AppearanceBase) appearance24;
    ((Control) this.txtAmount).BackColor = Color.White;
    ((Control) this.txtAmount).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.txtAmount).ForeColor = Color.Black;
    ((Control) this.txtAmount).Location = new Point(96 /*0x60*/, 296);
    ((TextEditorControlBase) this.txtAmount).MaxLength = 50;
    this.txtAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAmount).Name = "txtAmount";
    ((Control) this.txtAmount).Size = new Size(216, 20);
    ((Control) this.txtAmount).TabIndex = 4;
    ((UltraControlBase) this.txtAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtAmount).Validating += new CancelEventHandler(this.txtAmount_Validating);
    ((AppearanceBase) appearance25).BackColor = Color.White;
    ((AppearanceBase) appearance25).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance25).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtComments).Appearance = (AppearanceBase) appearance25;
    ((Control) this.txtComments).BackColor = Color.White;
    ((Control) this.txtComments).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.txtComments).ForeColor = Color.Black;
    ((Control) this.txtComments).Location = new Point(96 /*0x60*/, 184);
    ((TextEditorControlBase) this.txtComments).MaxLength = 2000;
    this.txtComments.MGAStyle = MGAStyles.Blue;
    this.txtComments.Multiline = true;
    ((Control) this.txtComments).Name = "txtComments";
    ((Control) this.txtComments).Size = new Size(216, 104);
    ((Control) this.txtComments).TabIndex = 3;
    ((UltraControlBase) this.txtComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtComments).UseOsThemes = (DefaultableBoolean) 2;
    this.comboCostCenters.AutoSelectOnOneItem = true;
    this.comboCostCenters.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCostCenters.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboCostCenters).DataSource = (object) this.dataSource;
    this.comboCostCenters.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboCostCenters.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCostCenters).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.comboCostCenters).Location = new Point(96 /*0x60*/, 160 /*0xA0*/);
    this.comboCostCenters.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCostCenters).Name = "comboCostCenters";
    ((Control) this.comboCostCenters).Size = new Size(216, 21);
    ((Control) this.comboCostCenters).TabIndex = 2;
    ((UltraControlBase) this.comboCostCenters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCostCenters).UseOsThemes = (DefaultableBoolean) 2;
    this.comboType.AutoSelectOnOneItem = true;
    this.comboType.BorderStyle = (UIElementBorderStyle) 4;
    this.comboType.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboType).DataMember = "Band 0";
    ((UltraDropDownBase) this.comboType).DisplayMember = "Key";
    this.comboType.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboType).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.comboType).Location = new Point(96 /*0x60*/, 320);
    this.comboType.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboType).Name = "comboType";
    ((Control) this.comboType).Size = new Size(216, 21);
    ((Control) this.comboType).TabIndex = 5;
    ((UltraControlBase) this.comboType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboType).ValueMember = "Value";
    ((AppearanceBase) appearance26).BackColor = Color.White;
    ((AppearanceBase) appearance26).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance26).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance26).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance26).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel5).Appearance = (AppearanceBase) appearance26;
    ((Control) this.ultraLabel5).AutoSize = true;
    ((ControlBase) this.ultraLabel5).BackColorInternal = Color.White;
    ((Control) this.ultraLabel5).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel5).ForeColor = Color.Black;
    ((Control) this.ultraLabel5).Location = new Point(8, 328);
    ((Control) this.ultraLabel5).Name = "ultraLabel5";
    ((Control) this.ultraLabel5).Size = new Size(35, 14);
    ((Control) this.ultraLabel5).TabIndex = 204;
    ((Control) this.ultraLabel5).Text = "Type :";
    ((AppearanceBase) appearance27).BackColor = Color.White;
    ((AppearanceBase) appearance27).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance27).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance27).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance27).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance27;
    ((Control) this.ultraLabel3).AutoSize = true;
    ((ControlBase) this.ultraLabel3).BackColorInternal = Color.White;
    ((Control) this.ultraLabel3).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel3).ForeColor = Color.Black;
    ((Control) this.ultraLabel3).Location = new Point(8, 192 /*0xC0*/);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(63 /*0x3F*/, 14);
    ((Control) this.ultraLabel3).TabIndex = 201;
    ((Control) this.ultraLabel3).Text = "Comments : ";
    ((AppearanceBase) appearance28).BackColor = Color.White;
    ((AppearanceBase) appearance28).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance28).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance28).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance28).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance28;
    ((Control) this.ultraLabel2).AutoSize = true;
    ((ControlBase) this.ultraLabel2).BackColorInternal = Color.White;
    ((Control) this.ultraLabel2).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel2).ForeColor = Color.Black;
    ((Control) this.ultraLabel2).Location = new Point(8, 160 /*0xA0*/);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(69, 14);
    ((Control) this.ultraLabel2).TabIndex = 200;
    ((Control) this.ultraLabel2).Text = "Cost Center : ";
    ((AppearanceBase) appearance29).BackColor = Color.White;
    ((AppearanceBase) appearance29).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance29).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance29).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance29).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance29;
    ((Control) this.ultraLabel1).AutoSize = true;
    ((ControlBase) this.ultraLabel1).BackColorInternal = Color.White;
    ((Control) this.ultraLabel1).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel1).ForeColor = Color.Black;
    ((Control) this.ultraLabel1).Location = new Point(8, 112 /*0x70*/);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(83, 14);
    ((Control) this.ultraLabel1).TabIndex = 199;
    ((Control) this.ultraLabel1).Text = "Office Location : ";
    ((AppearanceBase) appearance30).BackColor = Color.White;
    ((AppearanceBase) appearance30).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance30).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance30).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance30).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel6).Appearance = (AppearanceBase) appearance30;
    ((Control) this.ultraLabel6).AutoSize = true;
    ((ControlBase) this.ultraLabel6).BackColorInternal = Color.White;
    ((Control) this.ultraLabel6).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel6).ForeColor = Color.Black;
    ((Control) this.ultraLabel6).Location = new Point(8, 304);
    ((Control) this.ultraLabel6).Name = "ultraLabel6";
    ((Control) this.ultraLabel6).Size = new Size(48 /*0x30*/, 14);
    ((Control) this.ultraLabel6).TabIndex = 198;
    ((Control) this.ultraLabel6).Text = "Amount :";
    this.comboOfficeLocation.AutoSelectOnOneItem = true;
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocation.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboOfficeLocation).DataMember = "spFin_GetOfficeLocations";
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) this.dsOfficeLocations1;
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    this.comboOfficeLocation.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.comboOfficeLocation).Location = new Point(96 /*0x60*/, 112 /*0x70*/);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(216, 21);
    ((Control) this.comboOfficeLocation).TabIndex = 0;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    this.comboOfficeLocation.RowSelected += new RowSelectedEventHandler(this.comboOfficeLocation_RowSelected);
    this.dsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.dsOfficeLocations1.Locale = new CultureInfo("en-US");
    ((AppearanceBase) appearance31).BackColor = Color.White;
    ((AppearanceBase) appearance31).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance31).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance31).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance31).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance31;
    ((Control) this.ultraLabel4).AutoSize = true;
    ((ControlBase) this.ultraLabel4).BackColorInternal = Color.White;
    ((Control) this.ultraLabel4).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel4).ForeColor = Color.Black;
    ((Control) this.ultraLabel4).Location = new Point(8, 136);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(64 /*0x40*/, 14);
    ((Control) this.ultraLabel4).TabIndex = 202;
    ((Control) this.ultraLabel4).Text = "Gl Account : ";
    ((AppearanceBase) appearance32).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance32).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance32).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance32).BorderColor = Color.DarkGray;
    ((ControlBase) this.btnCancelChanges).Appearance = (AppearanceBase) appearance32;
    ((ControlBase) this.btnCancelChanges).BackColorInternal = Color.White;
    ((Control) this.btnCancelChanges).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnCancelChanges).ForeColor = Color.Black;
    ((Control) this.btnCancelChanges).Location = new Point(192 /*0xC0*/, 352);
    ((Control) this.btnCancelChanges).Name = "btnCancelChanges";
    ((Control) this.btnCancelChanges).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnCancelChanges).TabIndex = 7;
    ((Control) this.btnCancelChanges).Text = "&Cancel";
    ((UltraControlBase) this.btnCancelChanges).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancelChanges).Click += new EventHandler(this.btnCancelChanges_Click);
    ((AppearanceBase) appearance33).BackColor = Color.White;
    ((AppearanceBase) appearance33).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance33).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance33).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.lblSideBar).Appearance = (AppearanceBase) appearance33;
    ((ControlBase) this.lblSideBar).BackColorInternal = Color.White;
    this.lblSideBar.BorderStyleOuter = (UIElementBorderStyle) 1;
    ((Control) this.lblSideBar).Dock = DockStyle.Fill;
    ((Control) this.lblSideBar).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblSideBar).ForeColor = Color.Black;
    ((Control) this.lblSideBar).Location = new Point(0, 0);
    ((Control) this.lblSideBar).Name = "lblSideBar";
    ((Control) this.lblSideBar).Size = new Size(320, 384);
    ((Control) this.lblSideBar).TabIndex = 183;
    this.pnlSummary.BackColor = Color.White;
    this.pnlSummary.Controls.Add((Control) this.dateTimePostDate);
    this.pnlSummary.Controls.Add((Control) this.label5);
    this.pnlSummary.Controls.Add((Control) this.label4);
    this.pnlSummary.Controls.Add((Control) this.label3);
    this.pnlSummary.Controls.Add((Control) this.lblCreditsTotal);
    this.pnlSummary.Controls.Add((Control) this.lblDebitsTotal);
    this.pnlSummary.Controls.Add((Control) this.textComments);
    this.pnlSummary.Controls.Add((Control) this.label6);
    this.pnlSummary.Controls.Add((Control) this.ultraLabel8);
    this.pnlSummary.Dock = DockStyle.Fill;
    this.pnlSummary.Location = new Point(0, 0);
    this.pnlSummary.Name = "pnlSummary";
    this.pnlSummary.Size = new Size(906, 504);
    this.pnlSummary.TabIndex = 208 /*0xD0*/;
    ((AppearanceBase) appearance34).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimePostDate.Appearance = (AppearanceBase) appearance34;
    ((AppearanceBase) appearance35).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance35).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance35).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance35).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance35).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance35).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance35).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance35).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance35).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance35).ForegroundAlpha = (Alpha) 2;
    this.dateTimePostDate.ButtonAppearance = (AppearanceBase) appearance35;
    ((Control) this.dateTimePostDate).Location = new Point(136, 160 /*0xA0*/);
    this.dateTimePostDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimePostDate).Name = "dateTimePostDate";
    ((Control) this.dateTimePostDate).Size = new Size(176 /*0xB0*/, 20);
    ((Control) this.dateTimePostDate).TabIndex = 25;
    ((UltraControlBase) this.dateTimePostDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimePostDate).UseOsThemes = (DefaultableBoolean) 2;
    this.label5.AutoSize = true;
    this.label5.Location = new Point(48 /*0x30*/, 160 /*0xA0*/);
    this.label5.Name = "label5";
    this.label5.Size = new Size(78, 13);
    this.label5.TabIndex = 24;
    this.label5.Text = "Posting Date : ";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(48 /*0x30*/, 80 /*0x50*/);
    this.label4.Name = "label4";
    this.label4.Size = new Size(69, 13);
    this.label4.TabIndex = 19;
    this.label4.Text = "Debit Total : ";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(48 /*0x30*/, 112 /*0x70*/);
    this.label3.Name = "label3";
    this.label3.Size = new Size(78, 13);
    this.label3.TabIndex = 18;
    this.label3.Text = "Credits Total : ";
    this.lblCreditsTotal.Location = new Point(144 /*0x90*/, 112 /*0x70*/);
    this.lblCreditsTotal.Name = "lblCreditsTotal";
    this.lblCreditsTotal.Size = new Size(320, 17);
    this.lblCreditsTotal.TabIndex = 22;
    this.lblCreditsTotal.TextAlign = ContentAlignment.MiddleLeft;
    this.lblDebitsTotal.Location = new Point(144 /*0x90*/, 80 /*0x50*/);
    this.lblDebitsTotal.Name = "lblDebitsTotal";
    this.lblDebitsTotal.Size = new Size(320, 17);
    this.lblDebitsTotal.TabIndex = 21;
    this.lblDebitsTotal.TextAlign = ContentAlignment.MiddleLeft;
    ((AppearanceBase) appearance36).BackColor = Color.White;
    ((AppearanceBase) appearance36).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance36).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textComments).Appearance = (AppearanceBase) appearance36;
    ((Control) this.textComments).BackColor = Color.White;
    ((Control) this.textComments).Location = new Point(136, 200);
    ((TextEditorControlBase) this.textComments).MaxLength = 2000;
    this.textComments.MGAStyle = MGAStyles.Blue;
    this.textComments.Multiline = true;
    ((Control) this.textComments).Name = "textComments";
    ((Control) this.textComments).Size = new Size(328, 64 /*0x40*/);
    ((Control) this.textComments).TabIndex = 17;
    ((UltraControlBase) this.textComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textComments).UseOsThemes = (DefaultableBoolean) 2;
    this.label6.AutoSize = true;
    this.label6.Location = new Point(48 /*0x30*/, 200);
    this.label6.Name = "label6";
    this.label6.Size = new Size(57, 13);
    this.label6.TabIndex = 16 /*0x10*/;
    this.label6.Text = "Comments";
    ((AppearanceBase) appearance37).BackColor = Color.White;
    ((AppearanceBase) appearance37).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance37).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance37).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel8).Appearance = (AppearanceBase) appearance37;
    ((Control) this.ultraLabel8).AutoSize = true;
    ((ControlBase) this.ultraLabel8).BackColorInternal = Color.White;
    ((Control) this.ultraLabel8).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel8).ForeColor = Color.Black;
    ((Control) this.ultraLabel8).Location = new Point(48 /*0x30*/, 32 /*0x20*/);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(125, 15);
    ((Control) this.ultraLabel8).TabIndex = 207;
    ((Control) this.ultraLabel8).Text = "Transaction Summary";
    this.comboSource.Band.Columns.AddRange(new object[2]
    {
      (object) ultraDataColumn8,
      (object) ultraDataColumn9
    });
    this.daGetOfficeLocations.SelectCommand = this.sqlSelectCommand1;
    this.daGetOfficeLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOfficeLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Office Location", "Office Location")
      })
    });
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(906, 504);
    this.ControlBox = false;
    this.Controls.Add((Control) this.pnlContainer);
    this.Controls.Add((Control) this.pnlContainerSide);
    this.Controls.Add((Control) this.pnlBottom);
    this.Controls.Add((Control) this.panelTop);
    this.Controls.Add((Control) this.pnlSummary);
    this.Controls.Add((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom);
    this.Cursor = Cursors.Default;
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (formLedgerEntryWizard);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Journal Entry";
    this.Resize += new EventHandler(this.formLedgerEntryWizard_Resize);
    this.Load += new EventHandler(this.formLedgerEntryWizard_Load);
    ((ISupportInitialize) this.toolManager).EndInit();
    ((ISupportInitialize) this.grid).EndInit();
    ((ISupportInitialize) this.dataSource).EndInit();
    this.pnlBottom.ResumeLayout(false);
    ((ISupportInitialize) this.btnFinish).EndInit();
    ((ISupportInitialize) this.btnBack).EndInit();
    ((ISupportInitialize) this.btnNext).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.panelTop.ResumeLayout(false);
    this.panelTop.PerformLayout();
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.pnlContainer.ResumeLayout(false);
    this.pnlContainerSide.ResumeLayout(false);
    this.pnlContainerSide.PerformLayout();
    ((ISupportInitialize) this.btnAdd).EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.txtComments).EndInit();
    ((ISupportInitialize) this.comboCostCenters).EndInit();
    ((ISupportInitialize) this.comboType).EndInit();
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    this.dsOfficeLocations1.EndInit();
    ((ISupportInitialize) this.btnCancelChanges).EndInit();
    this.pnlSummary.ResumeLayout(false);
    this.pnlSummary.PerformLayout();
    ((ISupportInitialize) this.dateTimePostDate).EndInit();
    ((ISupportInitialize) this.textComments).EndInit();
    ((ISupportInitialize) this.comboSource).EndInit();
    this.ResumeLayout(false);
  }

  private void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (this.comboOfficeLocation.SelectedIndex == -1)
      return;
    this._glCompanyID = int.Parse(this.comboOfficeLocation.Value.ToString());
    this.LoadCostCenters();
    this.dropTreeGLAccounts.ResetText();
    this.dropTreeGLAccounts.LoadGLAccounts(this._glCompanyID);
  }

  private void LoadCostCenters()
  {
    DataSet dataSet = new DataSet();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetCostCentersList", new SqlConnection(CurrentUser.Instance.ConnectionString)));
    try
    {
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@glcompanyid", (object) this._glCompanyID);
      sqlDataAdapter.Fill(dataSet);
      ((UltraDropDownBase) this.comboCostCenters).DisplayMember = "Name";
      ((UltraDropDownBase) this.comboCostCenters).ValueMember = "CostCenterID";
      ((UltraGridBase) this.comboCostCenters).DataSource = (object) dataSet;
      if (dataSet == null || dataSet.Tables.Count != 2 || dataSet.Tables[1].Rows.Count <= 0)
        return;
      this.comboCostCenters.Value = dataSet.Tables[1].Rows[0][0];
    }
    finally
    {
      if (sqlDataAdapter.SelectCommand.Connection.State != ConnectionState.Closed)
        sqlDataAdapter.SelectCommand.Connection.Close();
      sqlDataAdapter.SelectCommand.Connection.Dispose();
      sqlDataAdapter.SelectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
  }

  private void ResetControlValues()
  {
    this.dropTreeGLAccounts.ResetText();
    this.comboCostCenters.SelectedIndex = -1;
    ((Control) this.txtComments).Text = string.Empty;
    ((Control) this.txtAmount).Text = string.Empty;
    this.comboType.SelectedIndex = 1;
    this._isInEditMode = false;
  }

  private bool ValidateValues()
  {
    if (((Control) this.txtAmount).Text == string.Empty)
    {
      int num = (int) MessageBox.Show("You must specify an amount to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!Information.IsNumeric((object) ((Control) this.txtAmount).Text))
    {
      int num = (int) MessageBox.Show("The amount specified must numeric.", "Invlid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.comboCostCenters.SelectedIndex == -1)
    {
      int num = (int) MessageBox.Show("You must select a cost center to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.comboType.SelectedIndex == -1 || ((UltraDropDownBase) this.comboType).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must specify an entry type.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.dropTreeGLAccounts.GLAccountSelected)
      return true;
    int num1 = (int) MessageBox.Show("You must select a GL account to continue.", "Required Item Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    if (!this.ValidateValues())
      return;
    this.pnlContainer.BringToFront();
    ((Control) this.btnBack).Enabled = false;
    ((Control) this.btnNext).Enabled = true;
    ((Control) this.btnFinish).Enabled = false;
    Decimal num1 = Math.Abs(Decimal.Parse(((Control) this.txtAmount).Text, NumberStyles.Any));
    int glAccountId = this.dropTreeGLAccounts.GLAccountID;
    int num2 = int.Parse(this.comboCostCenters.Value.ToString());
    string text1 = ((Control) this.comboType).Text;
    string accountShortName = this.dropTreeGLAccounts.GLAccountShortName;
    string text2 = ((Control) this.comboCostCenters).Text;
    Decimal num3 = int.Parse(this.comboType.Value.ToString()) == 0 ? num1 * -1M : num1;
    string text3 = ((Control) this.txtComments).Text;
    if (this._isInEditMode)
    {
      UltraGridRow activeRow = ((UltraGridBase) this.grid).ActiveRow;
      activeRow.Cells["TransactionType"].Value = (object) text1;
      activeRow.Cells["GlAccountName"].Value = (object) accountShortName;
      activeRow.Cells["GlAccountId"].Value = (object) glAccountId.ToString();
      activeRow.Cells["CostCenterName"].Value = (object) text2;
      activeRow.Cells["CostCenterID"].Value = (object) num2.ToString();
      activeRow.Cells["Amount"].Value = (object) num3.ToString();
      activeRow.Cells["Comments"].Value = (object) text3;
    }
    else
    {
      this.dataSource.Rows.Add(true, new object[7]
      {
        (object) text1,
        (object) accountShortName,
        (object) glAccountId,
        (object) text2,
        (object) num2,
        (object) num3,
        (object) text3
      }, true);
      if (((DisposableObjectCollectionBase) ((UltraGridBase) this.grid).Rows).Count == 1)
        this.AddGridSummaries();
    }
    this.ResetControlValues();
    if (((Control) this.btnAdd).Text == "Save")
      ((Control) this.btnAdd).Text = "Add";
    ((Control) this.comboOfficeLocation).Enabled = false;
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnCancelChanges_Click(object sender, EventArgs e) => this.ResetControlValues();

  private void btnFinish_Click(object sender, EventArgs e)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.grid).Rows).Count == 0)
    {
      int num1 = (int) MessageBox.Show("You have not specified and debits or credits for this journal entry. Please check the entries and try again.", "No Entries Specified!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (this._journal.CreditsCol.Total() == 0M && this._journal.DebitsCol.Total() == 0.0M)
    {
      int num2 = (int) MessageBox.Show(MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("NoEntriesSpecified"), MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("NoEntriesSpecifiedMessageBoxHeader"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (this._journal.DebitsCol.Total() != this._journal.CreditsCol.Total())
    {
      int num3 = (int) MessageBox.Show(MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("JournalEntryNotInBalance"), "Journal Entry Not In Balance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this._journal.Comments = ((Control) this.textComments).Text;
      this._journal.PostDate = this.dateTimePostDate.DateTime;
      this._journal.Save();
      this.Close();
      int num4 = (int) MessageBox.Show("The journal entry has been added to the ledger successfully.", "Posted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private void btnBack_Click(object sender, EventArgs e)
  {
    ((Control) this.btnBack).Enabled = false;
    ((Control) this.btnNext).Enabled = true;
    this.pnlContainer.BringToFront();
    ((Control) this.btnFinish).Enabled = false;
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnNext_Click(object sender, EventArgs e)
  {
    ((Control) this.btnNext).Enabled = false;
    ((Control) this.btnBack).Enabled = true;
    ((Control) this.btnFinish).Enabled = true;
    this.pnlSummary.BringToFront();
    this.CreateJournalEntries();
    this.lblCreditsTotal.Text = this._creditsTotal.ToString("C");
    this.lblDebitsTotal.Text = this._debitsTotal.ToString("C");
  }

  private void AddGridSummaries()
  {
    ((UltraGridBase) this.grid).DisplayLayout.Bands[0].Summaries.Clear();
    ((UltraGridBase) this.grid).DisplayLayout.Bands[0].Summaries.Add("Total", (SummaryType) 1, ((UltraGridBase) this.grid).DisplayLayout.Bands[0].Columns["amount"], (SummaryPosition) 3);
    ((UltraGridBase) this.grid).DisplayLayout.Bands[0].Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((UltraGridBase) this.grid).DisplayLayout.Bands[0].Override.SummaryFooterAppearance.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    foreach (SummarySettings summary in (IEnumerable) ((UltraGridBase) this.grid).DisplayLayout.Bands[0].Summaries)
    {
      summary.DisplayFormat = "{0:c}";
      summary.Appearance.TextHAlign = (HAlign) 3;
      summary.Appearance.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    }
  }

  private void grid_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    ((UltraGridBase) this.grid).DisplayLayout.Bands[0].Summaries.Clear();
  }

  private void txtAmount_Validating(object sender, CancelEventArgs e)
  {
    if (((Control) this.txtAmount).Text == string.Empty)
      return;
    if (!Information.IsNumeric((object) ((Control) this.txtAmount).Text))
    {
      int num = (int) MessageBox.Show("Amount must be numeric", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
      ((Control) this.txtAmount).Text = string.Empty;
    }
    else
      ((Control) this.txtAmount).Text = Decimal.Parse(((Control) this.txtAmount).Text, NumberStyles.Any).ToString("C");
  }

  private void formLedgerEntryWizard_Resize(object sender, EventArgs e) => this.Refresh();

  private void CreateJournalEntries()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.grid).Rows).Count == 0)
      return;
    this._journal = new JournalEntry();
    foreach (UltraGridRow row in ((UltraGridBase) this.grid).Rows)
    {
      int CostCenterId = int.Parse(row.Cells["CostCenterId"].Value.ToString());
      int ledgerAccount = int.Parse(row.Cells["GlAccountId"].Value.ToString());
      Decimal num = Math.Abs(Decimal.Parse(row.Cells["Amount"].Value.ToString(), NumberStyles.Any));
      string comments = row.Cells["Comments"].Value.ToString();
      string str = row.Cells["TransactionType"].Value.ToString();
      CostCenterAllocation centerAllocation = new CostCenterAllocation(CostCenterId, num);
      LedgerEntry ledgerEntry = new LedgerEntry(ledgerAccount, num, comments, new CostCenterAllocationCollection()
      {
        {
          centerAllocation,
          num
        }
      });
      if (str == "Credit")
        this._journal.CreditsCol.Add(ledgerEntry);
      else
        this._journal.DebitsCol.Add(ledgerEntry);
    }
    this._creditsTotal = this._journal.CreditsCol.Total();
    this._debitsTotal = this._journal.DebitsCol.Total();
  }

  private void toolManager_BeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = ((DisposableObjectCollectionBase) ((UltraGridBase) this.grid).Rows).Count == 0;
    if (!(((ControlUIElementBase) ((UltraGridBase) this.grid).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridRow), true) is UltraGridRow context))
      return;
    context.Activate();
    ((GridItemBase) context).Selected = true;
  }

  private void toolManager_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (((UltraGridBase) this.grid).ActiveRow == null)
      return;
    UltraGridRow activeRow = ((UltraGridBase) this.grid).ActiveRow;
    Decimal num = 0.0M;
    if (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key.ToUpper() == "DELETE")
    {
      this.dataSource.Rows.RemoveAt(((Control) this.grid).BindingContext[(object) this.dataSource, ((KeyedSubObjectBase) this.dataSource.Band).Key].Position);
      this.ResetControlValues();
      if (((DisposableObjectCollectionBase) ((UltraGridBase) this.grid).Rows).Count != 0)
        return;
      ((Control) this.comboOfficeLocation).Enabled = true;
    }
    else
    {
      if (!(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key.ToUpper() == "EDIT"))
        return;
      num = Decimal.Parse(((UltraGridBase) this.grid).ActiveRow.Cells["Amount"].Value.ToString());
      this.comboCostCenters.Value = (object) ((UltraGridBase) this.grid).ActiveRow.Cells["CostCenterId"].Value.ToString();
      this.dropTreeGLAccounts.SetSelectedNodeByKey(((UltraGridBase) this.grid).ActiveRow.Cells["GlAccountId"].Value.ToString());
      if (((UltraGridBase) this.grid).ActiveRow.Cells["TransactionType"].Value.ToString() == "Credit")
      {
        this.comboType.Value = (object) 0;
        ((Control) this.txtAmount).Text = (-1M * num).ToString("C");
      }
      else
      {
        this.comboType.Value = (object) 1;
        ((Control) this.txtAmount).Text = num.ToString("C");
      }
      ((Control) this.txtComments).Text = ((UltraGridBase) this.grid).ActiveRow.Cells["Comments"].Value.ToString();
      ((Control) this.btnAdd).Text = "Save";
      ((Control) this.btnCancelChanges).Visible = true;
      this._isInEditMode = true;
    }
  }

  private void formLedgerEntryWizard_Load(object sender, EventArgs e)
  {
    this.pnlContainer.BringToFront();
  }
}

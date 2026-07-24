// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.formGLAccountManagement
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using Infragistics.Win.UltraWinTree;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.GeneralLedger.Exceptions;
using MGASystems.IMS.Accounting.Reports;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

[SecureResource("{E5A20506-6E0C-49b0-BD04-31C0BC68D00B}", "General Ledger Management Access Rights", "Determines whether or not a user is allowed access to the general ledger management screen.", "Accounting")]
public class formGLAccountManagement : Form
{
  private UltraTree treeGlAccounts;
  private ImageList imageListGlAccountImages;
  private Splitter splitter1;
  private Label labelAccountClassName;
  private Label labelAccountNameCaption;
  private Label labelFullName;
  private Label labelShortName;
  private Label label2;
  private Label label1;
  private Label labelGLAccountID;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _formGLAccountManagement_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formGLAccountManagement_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formGLAccountManagement_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _formGLAccountManagement_Toolbars_Dock_Area_Bottom;
  private Panel panelAccountInformation;
  private Panel panelControlAccountInformation;
  private Label labelControlGroupHeader;
  private Panel panelStart;
  private PictureBox pictureBox1;
  private PictureBox pictureBox2;
  private Label label5;
  private UltraGrid gridRecentTransactions;
  private Label label6;
  private Label label8;
  private dsGLAccount_RecentTransactions dsGLAccount_RecentTransactions1;
  private Label labelLinkedEntity;
  private Label labelAccountNumber;
  private PictureBox pictureBox3;
  private Label label3;
  private Label labelCurrentBalance;
  private RadioButton radioLastTen;
  private RadioButton radioCustomizeView;
  private DateRangeOptionPicker dateRangeOptionPicker1;
  private MGAButton buttonPrintAccountLedger;
  private TextBox textBallonTip;
  private IContainer components;
  private GLAccount glAccount;
  private formGLAccountManagement.SelectedAccountType _selectedAccountType;
  private const int KEYSTATE_CONTROL = 8;
  private Point _lastMouseDownPoint = Point.Empty;

  public formGLAccountManagement()
  {
    this.InitializeComponent();
    this.LoadIcon();
    this.LoadOfficeLocationNodes();
    this.dateRangeOptionPicker1.DataBindings.Add("Enabled", (object) this.radioCustomizeView, "Checked");
  }

  private void LoadIcon()
  {
    this.Icon = Icon.FromHandle((Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Accounting.GeneralLedger.Resources.gl.png")) as Bitmap).GetHicon());
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
    UltraTreeNode ultraTreeNode = new UltraTreeNode();
    Override override1 = new Override();
    Appearance appearance2 = new Appearance();
    Override override2 = new Override();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("TransactionList", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("TransactNum");
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PostDate");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("TransDescription");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Voided");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formGLAccountManagement));
    UltraToolbar ultraToolbar1 = new UltraToolbar("GLAccountManagement");
    ButtonTool buttonTool1 = new ButtonTool("ChartOfAccounts");
    ButtonTool buttonTool2 = new ButtonTool("JournalEntry");
    ButtonTool buttonTool3 = new ButtonTool("INVOICECORRECTION");
    ButtonTool buttonTool4 = new ButtonTool("FISCAL");
    Appearance appearance14 = new Appearance();
    UltraToolbar ultraToolbar2 = new UltraToolbar("GLTreeContextMenu");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("Context1");
    Appearance appearance15 = new Appearance();
    ButtonTool buttonTool5 = new ButtonTool("NewGLAccount");
    Appearance appearance16 = new Appearance();
    ButtonTool buttonTool6 = new ButtonTool("NewControlAccount");
    Appearance appearance17 = new Appearance();
    ButtonTool buttonTool7 = new ButtonTool("ChartOfAccounts");
    Appearance appearance18 = new Appearance();
    ButtonTool buttonTool8 = new ButtonTool("CloseAccount");
    Appearance appearance19 = new Appearance();
    ButtonTool buttonTool9 = new ButtonTool("JournalEntry");
    Appearance appearance20 = new Appearance();
    ButtonTool buttonTool10 = new ButtonTool("FISCAL");
    Appearance appearance21 = new Appearance();
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("New");
    Appearance appearance22 = new Appearance();
    ButtonTool buttonTool11 = new ButtonTool("NewControlAccount");
    ButtonTool buttonTool12 = new ButtonTool("NewGLAccount");
    ButtonTool buttonTool13 = new ButtonTool("GLControlAccount");
    ButtonTool buttonTool14 = new ButtonTool("GlAccount");
    ButtonTool buttonTool15 = new ButtonTool("Refresh");
    Appearance appearance23 = new Appearance();
    ButtonTool buttonTool16 = new ButtonTool("Expand");
    Appearance appearance24 = new Appearance();
    ButtonTool buttonTool17 = new ButtonTool("Delete");
    Appearance appearance25 = new Appearance();
    PopupMenuTool popupMenuTool3 = new PopupMenuTool("Context1");
    Appearance appearance26 = new Appearance();
    PopupMenuTool popupMenuTool4 = new PopupMenuTool("New");
    ButtonTool buttonTool18 = new ButtonTool("Refresh");
    ButtonTool buttonTool19 = new ButtonTool("Expand");
    ButtonTool buttonTool20 = new ButtonTool("CloseAccount");
    ButtonTool buttonTool21 = new ButtonTool("Delete");
    ButtonTool buttonTool22 = new ButtonTool("Properties");
    ButtonTool buttonTool23 = new ButtonTool("DeleteChart");
    ButtonTool buttonTool24 = new ButtonTool("Properties");
    Appearance appearance27 = new Appearance();
    ButtonTool buttonTool25 = new ButtonTool("DeleteChart");
    Appearance appearance28 = new Appearance();
    ButtonTool buttonTool26 = new ButtonTool("INVOICECORRECTION");
    Appearance appearance29 = new Appearance();
    ButtonTool buttonTool27 = new ButtonTool("CLOSE");
    PopupMenuTool popupMenuTool5 = new PopupMenuTool("Context2");
    ButtonTool buttonTool28 = new ButtonTool("CLOSE");
    this.treeGlAccounts = new UltraTree();
    this.imageListGlAccountImages = new ImageList(this.components);
    this.panelAccountInformation = new Panel();
    this.buttonPrintAccountLedger = new MGAButton();
    this.gridRecentTransactions = new UltraGrid();
    this.dsGLAccount_RecentTransactions1 = new dsGLAccount_RecentTransactions();
    this.radioCustomizeView = new RadioButton();
    this.radioLastTen = new RadioButton();
    this.label3 = new Label();
    this.labelCurrentBalance = new Label();
    this.label8 = new Label();
    this.labelLinkedEntity = new Label();
    this.label6 = new Label();
    this.labelAccountNumber = new Label();
    this.label5 = new Label();
    this.label1 = new Label();
    this.labelGLAccountID = new Label();
    this.label2 = new Label();
    this.labelAccountNameCaption = new Label();
    this.labelShortName = new Label();
    this.labelFullName = new Label();
    this.labelAccountClassName = new Label();
    this.dateRangeOptionPicker1 = new DateRangeOptionPicker();
    this.textBallonTip = new TextBox();
    this.splitter1 = new Splitter();
    this._formGLAccountManagement_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formGLAccountManagement_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formGLAccountManagement_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formGLAccountManagement_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.panelControlAccountInformation = new Panel();
    this.labelControlGroupHeader = new Label();
    this.panelStart = new Panel();
    this.pictureBox3 = new PictureBox();
    this.pictureBox2 = new PictureBox();
    this.pictureBox1 = new PictureBox();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    ((ISupportInitialize) this.treeGlAccounts).BeginInit();
    this.panelAccountInformation.SuspendLayout();
    ((ISupportInitialize) this.buttonPrintAccountLedger).BeginInit();
    ((ISupportInitialize) this.gridRecentTransactions).BeginInit();
    this.dsGLAccount_RecentTransactions1.BeginInit();
    this.panelControlAccountInformation.SuspendLayout();
    this.panelStart.SuspendLayout();
    ((ISupportInitialize) this.pictureBox3).BeginInit();
    ((ISupportInitialize) this.pictureBox2).BeginInit();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((Control) this.treeGlAccounts).AllowDrop = true;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.treeGlAccounts.Appearance = (AppearanceBase) appearance1;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.treeGlAccounts, "Context1");
    ((Control) this.treeGlAccounts).Dock = DockStyle.Left;
    this.treeGlAccounts.HideSelection = false;
    this.treeGlAccounts.ImageList = this.imageListGlAccountImages;
    ((Control) this.treeGlAccounts).Location = new Point(0, 28);
    ((Control) this.treeGlAccounts).Name = "treeGlAccounts";
    ((AppearanceBase) appearance2).Image = (object) 0;
    override1.ActiveNodeAppearance = (AppearanceBase) appearance2;
    ultraTreeNode.Override = override1;
    ultraTreeNode.Text = "Accounting - Chart Of Accounts";
    this.treeGlAccounts.Nodes.AddRange(new UltraTreeNode[1]
    {
      ultraTreeNode
    });
    override2.SelectionType = (SelectType) 1;
    override2.ShowExpansionIndicator = (ShowExpansionIndicator) 1;
    this.treeGlAccounts.Override = override2;
    ((Control) this.treeGlAccounts).Size = new Size(288, 648);
    ((Control) this.treeGlAccounts).TabIndex = 0;
    ((UltraControlBase) this.treeGlAccounts).UseFlatMode = (DefaultableBoolean) 1;
    this.treeGlAccounts.AfterSelect += new AfterNodeSelectEventHandler(this.treeGlAccounts_AfterSelect);
    ((Control) this.treeGlAccounts).MouseMove += new MouseEventHandler(this.treeGlAccounts_MouseMove);
    ((Control) this.treeGlAccounts).MouseDown += new MouseEventHandler(this.treeGlAccounts_MouseDown);
    this.treeGlAccounts.BeforeExpand += new BeforeNodeChangedEventHandler(this.treeGlAccounts_BeforeExpand);
    ((Control) this.treeGlAccounts).DragOver += new DragEventHandler(this.treeGlAccounts_DragOver);
    ((Control) this.treeGlAccounts).DragDrop += new DragEventHandler(this.treeGlAccounts_DragDrop);
    ((UltraControlBase) this.treeGlAccounts).MouseEnterElement += new UIElementEventHandler(this.treeGlAccounts_MouseEnterElement);
    this.imageListGlAccountImages.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imageListGlAccountImages.ImageStream");
    this.imageListGlAccountImages.TransparentColor = Color.Transparent;
    this.imageListGlAccountImages.Images.SetKeyName(0, "");
    this.imageListGlAccountImages.Images.SetKeyName(1, "");
    this.imageListGlAccountImages.Images.SetKeyName(2, "");
    this.imageListGlAccountImages.Images.SetKeyName(3, "");
    this.imageListGlAccountImages.Images.SetKeyName(4, "");
    this.imageListGlAccountImages.Images.SetKeyName(5, "");
    this.imageListGlAccountImages.Images.SetKeyName(6, "");
    this.imageListGlAccountImages.Images.SetKeyName(7, "cross.png");
    this.panelAccountInformation.BackColor = Color.White;
    this.panelAccountInformation.Controls.Add((Control) this.buttonPrintAccountLedger);
    this.panelAccountInformation.Controls.Add((Control) this.gridRecentTransactions);
    this.panelAccountInformation.Controls.Add((Control) this.radioCustomizeView);
    this.panelAccountInformation.Controls.Add((Control) this.radioLastTen);
    this.panelAccountInformation.Controls.Add((Control) this.label3);
    this.panelAccountInformation.Controls.Add((Control) this.labelCurrentBalance);
    this.panelAccountInformation.Controls.Add((Control) this.label8);
    this.panelAccountInformation.Controls.Add((Control) this.labelLinkedEntity);
    this.panelAccountInformation.Controls.Add((Control) this.label6);
    this.panelAccountInformation.Controls.Add((Control) this.labelAccountNumber);
    this.panelAccountInformation.Controls.Add((Control) this.label5);
    this.panelAccountInformation.Controls.Add((Control) this.label1);
    this.panelAccountInformation.Controls.Add((Control) this.labelGLAccountID);
    this.panelAccountInformation.Controls.Add((Control) this.label2);
    this.panelAccountInformation.Controls.Add((Control) this.labelAccountNameCaption);
    this.panelAccountInformation.Controls.Add((Control) this.labelShortName);
    this.panelAccountInformation.Controls.Add((Control) this.labelFullName);
    this.panelAccountInformation.Controls.Add((Control) this.labelAccountClassName);
    this.panelAccountInformation.Controls.Add((Control) this.dateRangeOptionPicker1);
    this.panelAccountInformation.Controls.Add((Control) this.textBallonTip);
    this.panelAccountInformation.Dock = DockStyle.Fill;
    this.panelAccountInformation.Location = new Point(291, 28);
    this.panelAccountInformation.Name = "panelAccountInformation";
    this.panelAccountInformation.Size = new Size(651, 648);
    this.panelAccountInformation.TabIndex = 1;
    ((Control) this.buttonPrintAccountLedger).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonPrintAccountLedger).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonPrintAccountLedger).Location = new Point(512 /*0x0200*/, 16 /*0x10*/);
    ((Control) this.buttonPrintAccountLedger).Name = "buttonPrintAccountLedger";
    ((Control) this.buttonPrintAccountLedger).Size = new Size(128 /*0x80*/, 24);
    ((Control) this.buttonPrintAccountLedger).TabIndex = 22;
    ((Control) this.buttonPrintAccountLedger).Text = "Print Account Ledger";
    ((UltraControlBase) this.buttonPrintAccountLedger).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonPrintAccountLedger).Visible = false;
    ((Control) this.buttonPrintAccountLedger).Click += new EventHandler(this.buttonPrintAccountLedger_Click);
    ((Control) this.gridRecentTransactions).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridRecentTransactions).DataSource = (object) this.dsGLAccount_RecentTransactions1;
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance5).FontData.UnderlineAsString = "True";
    ((AppearanceBase) appearance5).ForeColor = Color.Blue;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Center";
    ultraGridColumn1.CellAppearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Transaction #";
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 73;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Post Date";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 79;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 468;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 47;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BackColor = Color.Transparent;
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance12).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridRecentTransactions).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridRecentTransactions).Location = new Point(16 /*0x10*/, 317);
    ((Control) this.gridRecentTransactions).Name = "gridRecentTransactions";
    ((Control) this.gridRecentTransactions).Size = new Size(622, 264);
    ((Control) this.gridRecentTransactions).TabIndex = 12;
    ((UltraControlBase) this.gridRecentTransactions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridRecentTransactions).UseOsThemes = (DefaultableBoolean) 2;
    this.gridRecentTransactions.DoubleClickRow += new DoubleClickRowEventHandler(this.gridRecentTransactions_DoubleClickRow);
    ((UltraControlBase) this.gridRecentTransactions).MouseEnterElement += new UIElementEventHandler(this.gridRecentTransactions_MouseEnterElement);
    this.dsGLAccount_RecentTransactions1.DataSetName = "dsGLAccount_RecentTransactions";
    this.dsGLAccount_RecentTransactions1.Locale = new CultureInfo("en-US");
    this.radioCustomizeView.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.radioCustomizeView.CheckAlign = ContentAlignment.MiddleRight;
    this.radioCustomizeView.FlatStyle = FlatStyle.Flat;
    this.radioCustomizeView.ForeColor = Color.DarkSlateGray;
    this.radioCustomizeView.Location = new Point(472, 301);
    this.radioCustomizeView.Name = "radioCustomizeView";
    this.radioCustomizeView.Size = new Size(160 /*0xA0*/, 16 /*0x10*/);
    this.radioCustomizeView.TabIndex = 20;
    this.radioCustomizeView.Text = "Select Transactions to View";
    this.radioCustomizeView.TextAlign = ContentAlignment.MiddleCenter;
    this.radioCustomizeView.Click += new EventHandler(this.AccountViewOptionClicked);
    this.radioLastTen.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.radioLastTen.CheckAlign = ContentAlignment.MiddleRight;
    this.radioLastTen.Checked = true;
    this.radioLastTen.FlatStyle = FlatStyle.Flat;
    this.radioLastTen.ForeColor = Color.DarkSlateGray;
    this.radioLastTen.Location = new Point(312, 301);
    this.radioLastTen.Name = "radioLastTen";
    this.radioLastTen.Size = new Size(160 /*0xA0*/, 16 /*0x10*/);
    this.radioLastTen.TabIndex = 19;
    this.radioLastTen.TabStop = true;
    this.radioLastTen.Text = "Show Last 10 Transactions";
    this.radioLastTen.TextAlign = ContentAlignment.MiddleCenter;
    this.radioLastTen.Click += new EventHandler(this.AccountViewOptionClicked);
    this.radioLastTen.CheckedChanged += new EventHandler(this.AccountViewOptionChanged);
    this.label3.AutoSize = true;
    this.label3.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label3.ForeColor = Color.LightSlateGray;
    this.label3.Location = new Point(16 /*0x10*/, 288);
    this.label3.Name = "label3";
    this.label3.Size = new Size(97, 13);
    this.label3.TabIndex = 17;
    this.label3.Text = "Current Balance";
    this.label3.UseMnemonic = false;
    this.labelCurrentBalance.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelCurrentBalance.ForeColor = Color.SteelBlue;
    this.labelCurrentBalance.Location = new Point(15, 304);
    this.labelCurrentBalance.Name = "labelCurrentBalance";
    this.labelCurrentBalance.Size = new Size(296, 16 /*0x10*/);
    this.labelCurrentBalance.TabIndex = 18;
    this.labelCurrentBalance.Text = "[Current Balance]";
    this.labelCurrentBalance.UseMnemonic = false;
    this.label8.AutoSize = true;
    this.label8.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label8.ForeColor = Color.LightSlateGray;
    this.label8.Location = new Point(16 /*0x10*/, 240 /*0xF0*/);
    this.label8.Name = "label8";
    this.label8.Size = new Size(80 /*0x50*/, 13);
    this.label8.TabIndex = 15;
    this.label8.Text = "Linked Entity";
    this.label8.UseMnemonic = false;
    this.labelLinkedEntity.ForeColor = Color.SteelBlue;
    this.labelLinkedEntity.Location = new Point(16 /*0x10*/, 256 /*0x0100*/);
    this.labelLinkedEntity.Name = "labelLinkedEntity";
    this.labelLinkedEntity.Size = new Size(296, 16 /*0x10*/);
    this.labelLinkedEntity.TabIndex = 16 /*0x10*/;
    this.labelLinkedEntity.Text = "[Linked Entity]";
    this.labelLinkedEntity.UseMnemonic = false;
    this.label6.AutoSize = true;
    this.label6.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label6.ForeColor = Color.LightSlateGray;
    this.label6.Location = new Point(16 /*0x10*/, 192 /*0xC0*/);
    this.label6.Name = "label6";
    this.label6.Size = new Size(82, 13);
    this.label6.TabIndex = 13;
    this.label6.Text = "GL Account #";
    this.label6.UseMnemonic = false;
    this.labelAccountNumber.ForeColor = Color.SteelBlue;
    this.labelAccountNumber.Location = new Point(16 /*0x10*/, 208 /*0xD0*/);
    this.labelAccountNumber.Name = "labelAccountNumber";
    this.labelAccountNumber.Size = new Size(224 /*0xE0*/, 16 /*0x10*/);
    this.labelAccountNumber.TabIndex = 14;
    this.labelAccountNumber.Text = "[GL Account Number]";
    this.labelAccountNumber.UseMnemonic = false;
    this.label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label5.AutoSize = true;
    this.label5.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    this.label5.ForeColor = Color.LightSlateGray;
    this.label5.Location = new Point(16 /*0x10*/, 301);
    this.label5.Name = "label5";
    this.label5.Size = new Size(123, 13);
    this.label5.TabIndex = 11;
    this.label5.Text = "Recent Transactions";
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label1.ForeColor = Color.LightSlateGray;
    this.label1.Location = new Point(16 /*0x10*/, 144 /*0x90*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(86, 13);
    this.label1.TabIndex = 9;
    this.label1.Text = "GL Account ID";
    this.label1.UseMnemonic = false;
    this.labelGLAccountID.ForeColor = Color.SteelBlue;
    this.labelGLAccountID.Location = new Point(16 /*0x10*/, 160 /*0xA0*/);
    this.labelGLAccountID.Name = "labelGLAccountID";
    this.labelGLAccountID.Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    this.labelGLAccountID.TabIndex = 10;
    this.labelGLAccountID.Text = "[GL Account Name]";
    this.labelGLAccountID.UseMnemonic = false;
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label2.ForeColor = Color.LightSlateGray;
    this.label2.Location = new Point(16 /*0x10*/, 96 /*0x60*/);
    this.label2.Name = "label2";
    this.label2.Size = new Size(139, 13);
    this.label2.TabIndex = 7;
    this.label2.Text = "GL Account Short Name";
    this.label2.UseMnemonic = false;
    this.labelAccountNameCaption.AutoSize = true;
    this.labelAccountNameCaption.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelAccountNameCaption.ForeColor = Color.LightSlateGray;
    this.labelAccountNameCaption.Location = new Point(16 /*0x10*/, 48 /*0x30*/);
    this.labelAccountNameCaption.Name = "labelAccountNameCaption";
    this.labelAccountNameCaption.Size = new Size(105, 13);
    this.labelAccountNameCaption.TabIndex = 1;
    this.labelAccountNameCaption.Text = "GL Account Name";
    this.labelAccountNameCaption.UseMnemonic = false;
    this.labelShortName.ForeColor = Color.SteelBlue;
    this.labelShortName.Location = new Point(16 /*0x10*/, 112 /*0x70*/);
    this.labelShortName.Name = "labelShortName";
    this.labelShortName.Size = new Size(496, 16 /*0x10*/);
    this.labelShortName.TabIndex = 8;
    this.labelShortName.Text = "[GL Account Name]";
    this.labelShortName.UseMnemonic = false;
    this.labelFullName.ForeColor = Color.SteelBlue;
    this.labelFullName.Location = new Point(16 /*0x10*/, 64 /*0x40*/);
    this.labelFullName.Name = "labelFullName";
    this.labelFullName.Size = new Size(496, 16 /*0x10*/);
    this.labelFullName.TabIndex = 6;
    this.labelFullName.Text = "[GL Account Name]";
    this.labelFullName.UseMnemonic = false;
    this.labelAccountClassName.AutoSize = true;
    this.labelAccountClassName.Font = new Font("Tahoma", 15f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelAccountClassName.ForeColor = Color.SlateGray;
    this.labelAccountClassName.Location = new Point(16 /*0x10*/, 8);
    this.labelAccountClassName.Name = "labelAccountClassName";
    this.labelAccountClassName.Size = new Size(92, 24);
    this.labelAccountClassName.TabIndex = 0;
    this.labelAccountClassName.Text = "[Assets]";
    this.labelAccountClassName.UseMnemonic = false;
    this.dateRangeOptionPicker1.Anchor = AnchorStyles.Bottom;
    this.dateRangeOptionPicker1.Enabled = false;
    this.dateRangeOptionPicker1.Location = new Point(32 /*0x20*/, 589);
    this.dateRangeOptionPicker1.Name = "dateRangeOptionPicker1";
    this.dateRangeOptionPicker1.Size = new Size(576, 24);
    this.dateRangeOptionPicker1.TabIndex = 21;
    this.dateRangeOptionPicker1.DateChanged += new DateRangeOptionPicker.DateChangedEventHandler(this.dateRangeOptionPicker1_DateChanged);
    this.textBallonTip.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.textBallonTip.Location = new Point(624, 317);
    this.textBallonTip.Name = "textBallonTip";
    this.textBallonTip.ReadOnly = true;
    this.textBallonTip.Size = new Size(8, 21);
    this.textBallonTip.TabIndex = 23;
    this.textBallonTip.TabStop = false;
    this.splitter1.BackColor = Color.Silver;
    this.splitter1.Location = new Point(288, 28);
    this.splitter1.Name = "splitter1";
    this.splitter1.Size = new Size(3, 648);
    this.splitter1.TabIndex = 2;
    this.splitter1.TabStop = false;
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(229, 229, 215);
    this._formGLAccountManagement_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Left).Location = new Point(0, 28);
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Left).Name = "_formGLAccountManagement_Toolbars_Dock_Area_Left";
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Left).Size = new Size(0, 648);
    this._formGLAccountManagement_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(229, 229, 215);
    this._formGLAccountManagement_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Right).Location = new Point(942, 28);
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Right).Name = "_formGLAccountManagement_Toolbars_Dock_Area_Right";
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Right).Size = new Size(0, 648);
    this._formGLAccountManagement_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(229, 229, 215);
    this._formGLAccountManagement_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Top).Name = "_formGLAccountManagement_Toolbars_Dock_Area_Top";
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Top).Size = new Size(942, 28);
    this._formGLAccountManagement_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(229, 229, 215);
    this._formGLAccountManagement_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Bottom).Location = new Point(0, 676);
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Bottom).Name = "_formGLAccountManagement_Toolbars_Dock_Area_Bottom";
    ((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Bottom).Size = new Size(942, 0);
    this._formGLAccountManagement_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.panelControlAccountInformation.BackColor = Color.White;
    this.panelControlAccountInformation.Controls.Add((Control) this.labelControlGroupHeader);
    this.panelControlAccountInformation.Dock = DockStyle.Fill;
    this.panelControlAccountInformation.Location = new Point(291, 28);
    this.panelControlAccountInformation.Name = "panelControlAccountInformation";
    this.panelControlAccountInformation.Size = new Size(651, 648);
    this.panelControlAccountInformation.TabIndex = 7;
    this.labelControlGroupHeader.AutoSize = true;
    this.labelControlGroupHeader.Font = new Font("Tahoma", 15f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelControlGroupHeader.ForeColor = Color.SlateGray;
    this.labelControlGroupHeader.Location = new Point(16 /*0x10*/, 8);
    this.labelControlGroupHeader.Name = "labelControlGroupHeader";
    this.labelControlGroupHeader.Size = new Size(236, 24);
    this.labelControlGroupHeader.TabIndex = 0;
    this.labelControlGroupHeader.Text = "[ControlGroupHeader]";
    this.labelControlGroupHeader.UseMnemonic = false;
    this.panelStart.BackColor = Color.White;
    this.panelStart.Controls.Add((Control) this.pictureBox3);
    this.panelStart.Controls.Add((Control) this.pictureBox2);
    this.panelStart.Controls.Add((Control) this.pictureBox1);
    this.panelStart.Dock = DockStyle.Fill;
    this.panelStart.Location = new Point(291, 28);
    this.panelStart.Name = "panelStart";
    this.panelStart.Size = new Size(651, 648);
    this.panelStart.TabIndex = 8;
    this.pictureBox3.Anchor = AnchorStyles.Top;
    this.pictureBox3.Image = (Image) componentResourceManager.GetObject("pictureBox3.Image");
    this.pictureBox3.Location = new Point(112 /*0x70*/, 40);
    this.pictureBox3.Name = "pictureBox3";
    this.pictureBox3.Size = new Size(425, 30);
    this.pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox3.TabIndex = 4;
    this.pictureBox3.TabStop = false;
    this.pictureBox2.Anchor = AnchorStyles.Top;
    this.pictureBox2.Image = (Image) componentResourceManager.GetObject("pictureBox2.Image");
    this.pictureBox2.Location = new Point(161, 103);
    this.pictureBox2.Name = "pictureBox2";
    this.pictureBox2.Size = new Size(333, 121);
    this.pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox2.TabIndex = 3;
    this.pictureBox2.TabStop = false;
    this.pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(558, 547);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(84, 65);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox1.TabIndex = 2;
    this.pictureBox1.TabStop = false;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 3;
    ultraToolbar1.DockedColumn = 0;
    ultraToolbar1.DockedRow = 0;
    ((ToolBase) buttonTool1).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool4).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar1).NonInheritedTools.AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ultraToolbar1.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockTop = (DefaultableBoolean) 1;
    ultraToolbar1.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowHiding = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance14).AlphaLevel = (short) 90;
    ((AppearanceBase) appearance14).BackColor = Color.GhostWhite;
    ((AppearanceBase) appearance14).BackColor2 = Color.GhostWhite;
    ((AppearanceBase) appearance14).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance14).BorderAlpha = (Alpha) 2;
    ((AppearanceBase) appearance14).FontData.BoldAsString = "False";
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((AppearanceBase) appearance14).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance14).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance14).ImageBackground = (Image) componentResourceManager.GetObject("appearance13.ImageBackground");
    ((SettingsBase) ultraToolbar1.Settings).Appearance = (AppearanceBase) appearance14;
    ultraToolbar1.Settings.CaptionPlacement = (TextPlacement) 4;
    ultraToolbar1.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar1.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((ToolbarSettingsBase) ultraToolbar1.Settings).PaddingLeft = 5;
    ((SettingsBase) ultraToolbar1.Settings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ((ToolbarSettingsBase) ultraToolbar1.Settings).ToolSpacing = 5;
    ultraToolbar1.ShowInToolbarList = false;
    ultraToolbar1.Text = "GLAccountManagement";
    ultraToolbar2.DockedColumn = 0;
    ultraToolbar2.DockedRow = 1;
    ultraToolbar2.FloatingLocation = new Point(303, 437);
    ultraToolbar2.FloatingSize = new Size(107, 44);
    ((UltraToolbarBase) ultraToolbar2).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb(160 /*0xA0*/, 190, 220);
    ((AppearanceBase) appearance15).BackColor2 = Color.White;
    ((AppearanceBase) appearance15).BackGradientStyle = (GradientStyle) 7;
    ((SettingsBase) ultraToolbar2.Settings).Appearance = (AppearanceBase) appearance15;
    ultraToolbar2.ShowInToolbarList = false;
    ultraToolbar2.Text = "GLTreeContextMenu";
    ultraToolbar2.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[2]
    {
      ultraToolbar1,
      ultraToolbar2
    });
    ((AppearanceBase) appearance16).Image = componentResourceManager.GetObject("appearance15.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance16;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).Caption = "New GL Account";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance17).Image = componentResourceManager.GetObject("appearance16.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance17;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "New GL Control Account";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance18).Image = componentResourceManager.GetObject("appearance17.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance18;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).Caption = "Chart Of Accounts";
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance19).Image = componentResourceManager.GetObject("appearance18.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance19;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Close Account";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance20).Image = componentResourceManager.GetObject("appearance19.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance20;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "Journal Entry";
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance21).Image = componentResourceManager.GetObject("appearance20.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance21;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "Fiscal Configuration";
    ((AppearanceBase) appearance22).BackColor = Color.FromArgb(160 /*0xA0*/, 190, 220);
    ((AppearanceBase) appearance22).BackColor2 = Color.White;
    ((AppearanceBase) appearance22).BackGradientStyle = (GradientStyle) 3;
    popupMenuTool2.Settings.SideStripAppearance = (AppearanceBase) appearance22;
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "New";
    ((ToolBase) popupMenuTool2).SharedPropsInternal.Category = "TreeContextMenu";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12
    });
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).Caption = "GL Control Account";
    ((ToolBase) buttonTool13).SharedPropsInternal.Category = "TreeContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).Caption = "GL Account";
    ((ToolBase) buttonTool14).SharedPropsInternal.Category = "TreeContextMenu";
    ((AppearanceBase) appearance23).Image = componentResourceManager.GetObject("appearance22.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance23;
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).Caption = "Refresh";
    ((ToolBase) buttonTool15).SharedPropsInternal.Category = "TreeContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance24).Image = componentResourceManager.GetObject("appearance23.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance24;
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).Caption = "Expand";
    ((ToolBase) buttonTool16).SharedPropsInternal.Category = "TreeContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance25).Image = componentResourceManager.GetObject("appearance24.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance25;
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).Caption = "Delete";
    ((ToolBase) buttonTool17).SharedPropsInternal.Category = "TreeContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance26).BackColor = Color.FromArgb(160 /*0xA0*/, 190, 220);
    ((AppearanceBase) appearance26).BackColor2 = Color.White;
    popupMenuTool3.Settings.SideStripAppearance = (AppearanceBase) appearance26;
    ((ToolPropsBase) ((ToolBase) popupMenuTool3).SharedPropsInternal).Caption = "Context1";
    ((ToolBase) buttonTool18).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool19).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool20).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool21).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool23).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool3.Tools).AddRange(new ToolBase[7]
    {
      (ToolBase) popupMenuTool4,
      (ToolBase) buttonTool18,
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20,
      (ToolBase) buttonTool21,
      (ToolBase) buttonTool22,
      (ToolBase) buttonTool23
    });
    ((AppearanceBase) appearance27).Image = componentResourceManager.GetObject("appearance26.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance27;
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).Caption = "Properties...";
    ((ToolBase) buttonTool24).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance28).Image = componentResourceManager.GetObject("appearance27.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance28;
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).Caption = "Delete Chart Of Accounts";
    ((ToolBase) buttonTool25).SharedPropsInternal.Category = "TreeContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance29).Image = componentResourceManager.GetObject("appearance28.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance29;
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).Caption = "Invoice Correction Utility";
    ((ToolBase) buttonTool26).SharedPropsInternal.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool27).SharedPropsInternal).Caption = "Close Account";
    ((ToolPropsBase) ((ToolBase) popupMenuTool5).SharedPropsInternal).Caption = "PopupMenuTool1";
    ((ToolsCollectionBase) popupMenuTool5.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool28
    });
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[18]
    {
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) popupMenuTool3,
      (ToolBase) buttonTool24,
      (ToolBase) buttonTool25,
      (ToolBase) buttonTool26,
      (ToolBase) buttonTool27,
      (ToolBase) popupMenuTool5
    });
    ((UltraComponentControlManagerBase) this.ultraToolbarsManager1).UseOsThemes = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.ultraToolbarsManager1_BeforeToolDropdown);
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(942, 676);
    this.Controls.Add((Control) this.panelStart);
    this.Controls.Add((Control) this.panelAccountInformation);
    this.Controls.Add((Control) this.panelControlAccountInformation);
    this.Controls.Add((Control) this.splitter1);
    this.Controls.Add((Control) this.treeGlAccounts);
    this.Controls.Add((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._formGLAccountManagement_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (formGLAccountManagement);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "GL Account Management";
    ((ISupportInitialize) this.treeGlAccounts).EndInit();
    this.panelAccountInformation.ResumeLayout(false);
    this.panelAccountInformation.PerformLayout();
    ((ISupportInitialize) this.buttonPrintAccountLedger).EndInit();
    ((ISupportInitialize) this.gridRecentTransactions).EndInit();
    this.dsGLAccount_RecentTransactions1.EndInit();
    this.panelControlAccountInformation.ResumeLayout(false);
    this.panelControlAccountInformation.PerformLayout();
    this.panelStart.ResumeLayout(false);
    this.panelStart.PerformLayout();
    ((ISupportInitialize) this.pictureBox3).EndInit();
    ((ISupportInitialize) this.pictureBox2).EndInit();
    ((ISupportInitialize) this.pictureBox1).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  private void LoadOfficeLocationNodes()
  {
    this.treeGlAccounts.Nodes[0].Nodes.Clear();
    foreach (DataRow row in (InternalDataCollectionBase) Methods.GetOfficeLocationDataset().spFin_GetOfficeLocations.Rows)
    {
      MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode glNode = new MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode(true);
      glNode.AllowLoadChildren = false;
      ((KeyedSubObjectBase) glNode).Key = "LOCATION" + row["ID"].ToString();
      glNode.Text = row["Office Location"].ToString();
      glNode.LeftImages.Add((object) this.imageListGlAccountImages.Images[1]);
      glNode.IsLocationNode = true;
      glNode.GlCompanyId = int.Parse(row["ID"].ToString());
      this.LoadGLAccounts(int.Parse(row["ID"].ToString()), glNode);
      try
      {
        this.treeGlAccounts.Nodes[0].Nodes.Add((UltraTreeNode) glNode);
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    this.treeGlAccounts.Nodes[0].Expanded = true;
  }

  private void LoadGLAccounts(int glCompany, MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode glNode)
  {
    this.LoadTreeMasterNodes(glCompany, glNode);
  }

  private void LoadTreeMasterNodes(int glCompany, MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode glMasterNode)
  {
    MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode GLNode1 = new MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode(true);
    ((KeyedSubObjectBase) GLNode1).Key = glCompany.ToString() + "AssetsMaster";
    GLNode1.Text = "Assets";
    GLNode1.LeftImages.Add((object) this.imageListGlAccountImages.Images[2]);
    GLNode1.IsMasterAccountNode = true;
    GLNode1.AllowLoadChildren = true;
    GLNode1.MasterAccountLoadType = "Assets";
    GLNode1.GlCompanyId = glCompany;
    GLNode1.GLAccountClass = AccountingCache.Instance.GlCompany(glCompany).AssetsClass;
    this.LoadMasterAccounts(GLNode1, GLNode1.MasterAccountLoadType, GLNode1.GlCompanyId);
    glMasterNode.Nodes.Add((UltraTreeNode) GLNode1);
    GLAccount masterAccount1 = Utilities.GetMasterAccount(Utilities.MasterAccountType.Receivables, glCompany);
    GLNode1.GLAccountClass = AccountingCache.Instance.GlCompany(glCompany).AssetsClass;
    MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode glTreeNode1 = new MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode(true);
    glTreeNode1.Text = "Receivable Accounts";
    glTreeNode1.LeftImages.Add((object) this.imageListGlAccountImages.Images[3]);
    glTreeNode1.IsMasterAccountNode = true;
    glTreeNode1.MasterAccountLoadType = "A/R";
    glTreeNode1.AllowLoadChildren = true;
    glTreeNode1.GlAccount = masterAccount1;
    glTreeNode1.GlCompanyId = glCompany;
    glMasterNode.Nodes[0].Nodes.Add((UltraTreeNode) glTreeNode1);
    GLAccount masterAccount2 = Utilities.GetMasterAccount(Utilities.MasterAccountType.Cash, glCompany);
    MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode glTreeNode2 = new MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode(true);
    glTreeNode2.GLAccountClass = AccountingCache.Instance.GlCompany(glCompany).AssetsClass;
    glTreeNode2.Text = "Cash Accounts";
    glTreeNode2.GlAccount = masterAccount2;
    glTreeNode2.LeftImages.Add((object) this.imageListGlAccountImages.Images[3]);
    glTreeNode2.IsMasterAccountNode = true;
    glTreeNode2.MasterAccountLoadType = "Cash";
    glTreeNode2.AllowLoadChildren = true;
    glTreeNode2.IsBankAccount = true;
    glTreeNode2.GlCompanyId = glCompany;
    glMasterNode.Nodes[0].Nodes.Add((UltraTreeNode) glTreeNode2);
    MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode GLNode2 = new MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode(true);
    ((KeyedSubObjectBase) GLNode2).Key = glCompany.ToString() + "LiabilityMaster";
    GLNode2.Text = "Liabilities";
    GLNode2.IsMasterAccountNode = true;
    GLNode2.AllowLoadChildren = true;
    GLNode2.LeftImages.Add((object) this.imageListGlAccountImages.Images[2]);
    GLNode2.GLAccountClass = AccountingCache.Instance.GlCompany(glCompany).LiabilityClass;
    GLNode2.MasterAccountLoadType = "Liabilities";
    GLNode2.GlCompanyId = glCompany;
    this.LoadMasterAccounts(GLNode2, GLNode2.MasterAccountLoadType, GLNode2.GlCompanyId);
    glMasterNode.Nodes.Add((UltraTreeNode) GLNode2);
    GLAccount masterAccount3 = Utilities.GetMasterAccount(Utilities.MasterAccountType.Payables, glCompany);
    MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode glTreeNode3 = new MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode(true);
    glTreeNode3.GLAccountClass = AccountingCache.Instance.GlCompany(glCompany).LiabilityClass;
    glTreeNode3.Text = "Payable Accounts";
    glTreeNode3.GlAccount = masterAccount3;
    glTreeNode3.IsMasterAccountNode = true;
    glTreeNode3.MasterAccountLoadType = "A/P";
    glTreeNode3.AllowLoadChildren = true;
    glTreeNode3.LeftImages.Add((object) this.imageListGlAccountImages.Images[3]);
    glTreeNode3.GlCompanyId = glCompany;
    glMasterNode.Nodes[((DisposableObjectCollectionBase) glMasterNode.Nodes).Count - 1].Nodes.Add((UltraTreeNode) glTreeNode3);
    GLAccount masterAccount4 = Utilities.GetMasterAccount(Utilities.MasterAccountType.UnAccounted, glCompany);
    MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode glTreeNode4 = new MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode(true);
    glTreeNode4.GLAccountClass = AccountingCache.Instance.GlCompany(glCompany).LiabilityClass;
    glTreeNode4.Text = "Un-Accounted Accounts";
    glTreeNode4.GlAccount = masterAccount4;
    glTreeNode4.IsMasterAccountNode = true;
    glTreeNode4.MasterAccountLoadType = "S/R";
    glTreeNode4.AllowLoadChildren = true;
    glTreeNode4.LeftImages.Add((object) this.imageListGlAccountImages.Images[3]);
    glTreeNode4.GlCompanyId = glCompany;
    glMasterNode.Nodes[((DisposableObjectCollectionBase) glMasterNode.Nodes).Count - 1].Nodes.Add((UltraTreeNode) glTreeNode4);
    GLAccount masterAccount5 = Utilities.GetMasterAccount(Utilities.MasterAccountType.Exchange, glCompany);
    MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode glTreeNode5 = new MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode(true);
    glTreeNode5.GLAccountClass = AccountingCache.Instance.GlCompany(glCompany).LiabilityClass;
    glTreeNode5.Text = "Exchange Accounts";
    ((KeyedSubObjectBase) glTreeNode5).Key = masterAccount5.GLAccountID.ToString();
    glTreeNode5.GlAccount = masterAccount5;
    glTreeNode5.LeftImages.Add((object) this.imageListGlAccountImages.Images[3]);
    glTreeNode5.IsMasterAccountNode = true;
    glTreeNode5.MasterAccountLoadType = "X/F";
    glTreeNode5.AllowLoadChildren = true;
    glTreeNode5.GlCompanyId = glCompany;
    glMasterNode.Nodes[((DisposableObjectCollectionBase) glMasterNode.Nodes).Count - 1].Nodes.Add((UltraTreeNode) glTreeNode5);
    MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode glTreeNode6 = new MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode(true);
    glTreeNode6.Text = "Equity Accounts";
    ((KeyedSubObjectBase) glTreeNode6).Key = glCompany.ToString() + "EquityMaster";
    glTreeNode6.LeftImages.Add((object) this.imageListGlAccountImages.Images[2]);
    glTreeNode6.GlCompanyId = glCompany;
    glTreeNode6.IsMasterAccountNode = true;
    glTreeNode6.MasterAccountLoadType = "Equity";
    glTreeNode6.AllowLoadChildren = true;
    glTreeNode6.GLAccountClass = AccountingCache.Instance.GlCompany(glCompany).EquityClass;
    glTreeNode6.GlCompanyId = glCompany;
    glMasterNode.Nodes.Add((UltraTreeNode) glTreeNode6);
    MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode glTreeNode7 = new MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode(true);
    glTreeNode7.Text = "Income Accounts";
    ((KeyedSubObjectBase) glTreeNode7).Key = glCompany.ToString() + "IncomeMaster";
    glTreeNode7.LeftImages.Add((object) this.imageListGlAccountImages.Images[2]);
    glTreeNode7.GlCompanyId = glCompany;
    glTreeNode7.IsMasterAccountNode = true;
    glTreeNode7.MasterAccountLoadType = "Income";
    glTreeNode7.AllowLoadChildren = true;
    glTreeNode7.GLAccountClass = AccountingCache.Instance.GlCompany(glCompany).IncomeClass;
    glMasterNode.Nodes.Add((UltraTreeNode) glTreeNode7);
    MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode glTreeNode8 = new MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode(true);
    glTreeNode8.Text = "Expense Accounts";
    ((KeyedSubObjectBase) glTreeNode8).Key = glCompany.ToString() + "ExpenseMaster";
    glTreeNode8.LeftImages.Add((object) this.imageListGlAccountImages.Images[2]);
    glTreeNode8.GlCompanyId = glCompany;
    glTreeNode8.IsMasterAccountNode = true;
    glTreeNode8.MasterAccountLoadType = "Expenses";
    glTreeNode8.AllowLoadChildren = true;
    glTreeNode8.GLAccountClass = AccountingCache.Instance.GlCompany(glCompany).ExpensesClass;
    glMasterNode.Nodes.Add((UltraTreeNode) glTreeNode8);
  }

  private void LoadMasterAccounts(MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode GLNode, string MasterAcctClass, int glCompanyId)
  {
    SqlCommand sqlCommand1 = (SqlCommand) null;
    GLNode.Nodes.Clear();
    SqlCommand sqlCommand2 = new SqlCommand("spFin_getChildAccounts", new SqlConnection(CurrentUser.Instance.ConnectionString));
    sqlCommand2.CommandType = CommandType.StoredProcedure;
    try
    {
      sqlCommand2.Parameters.Clear();
      sqlCommand2.Parameters.Add("@searchtype", SqlDbType.BigInt);
      sqlCommand2.Parameters.AddWithValue("@classtype", (object) MasterAcctClass);
      sqlCommand2.Parameters.AddWithValue("@glacctid", (object) DBNull.Value);
      sqlCommand2.Parameters.AddWithValue("@glcompanyid", (object) glCompanyId);
      sqlCommand2.Parameters.AddWithValue("@showsystem", (object) 1);
      sqlCommand2.Connection.Open();
      SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader(CommandBehavior.CloseConnection);
      while (sqlDataReader.Read())
      {
        MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode glTreeNode = new MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode(Convert.ToBoolean(sqlDataReader["controlacct"]));
        glTreeNode.IsBankAccount = GLNode.IsBankAccount;
        glTreeNode.IsMasterAccountNode = false;
        ((KeyedSubObjectBase) glTreeNode).Key = sqlDataReader["glacctid"].ToString();
        glTreeNode.GLAccountShortName = sqlDataReader["shortname"].ToString();
        glTreeNode.GLAccountFullName = sqlDataReader["fullname"].ToString();
        glTreeNode.GLAccountID = Convert.ToInt32(sqlDataReader["glacctid"]);
        glTreeNode.GlAccount = new GLAccount(int.Parse(sqlDataReader["glacctid"].ToString()));
        if (glTreeNode.IsControlNode)
        {
          glTreeNode.LeftImages.Add((object) this.imageListGlAccountImages.Images[4]);
          glTreeNode.Expanded = false;
          glTreeNode.AllowLoadChildren = true;
        }
        else
        {
          glTreeNode.Override.ShowExpansionIndicator = (ShowExpansionIndicator) 2;
          if (!glTreeNode.GlAccount.IsClosed)
            glTreeNode.LeftImages.Add((object) this.imageListGlAccountImages.Images[5]);
          else
            glTreeNode.LeftImages.Add((object) this.imageListGlAccountImages.Images[7]);
        }
        if (!glTreeNode.GlAccount.IsControlAccount && glTreeNode.GlAccount.RollUpTo == 0 && !glTreeNode.GlAccount.IsSystemDefined && GLNode.IsMasterAccountNode)
          glTreeNode.GLAccountClass = GLNode.GLAccountClass;
        GLNode.Nodes.Add((UltraTreeNode) glTreeNode);
      }
      sqlDataReader.Close();
    }
    catch (SqlException ex)
    {
      int num = (int) MessageBox.Show("An error has occurred while trying to load the general ledger accounts in to the drop down tree.\r\n\r\n" + ex.Errors[0].Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    catch (Exception ex)
    {
      int num = (int) MessageBox.Show("An error has occurred while trying to load the general ledger accounts in to the drop down tree.\r\n\r\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    finally
    {
      if (sqlCommand2.Connection.State != ConnectionState.Closed)
        sqlCommand2.Connection.Close();
      sqlCommand2.Connection.Dispose();
      sqlCommand2.Connection = (SqlConnection) null;
      sqlCommand2.Dispose();
      sqlCommand1 = (SqlCommand) null;
    }
  }

  private void LoadChildAccounts(MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode GLNode, int GLAcctID, int glCompanyId)
  {
    SqlCommand sqlCommand1 = (SqlCommand) null;
    SqlCommand sqlCommand2 = new SqlCommand("spFin_getChildAccounts", new SqlConnection(CurrentUser.Instance.ConnectionString));
    sqlCommand2.CommandType = CommandType.StoredProcedure;
    try
    {
      sqlCommand2.Parameters.Clear();
      sqlCommand2.Parameters.AddWithValue("@searchtype", (object) 1);
      sqlCommand2.Parameters.AddWithValue("@classtype", (object) DBNull.Value);
      sqlCommand2.Parameters.AddWithValue("@glacctid", (object) GLAcctID);
      sqlCommand2.Parameters.AddWithValue("@glcompanyid", (object) glCompanyId);
      sqlCommand2.Parameters.AddWithValue("@showsystem", (object) 1);
      sqlCommand2.Connection.Open();
      SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader(CommandBehavior.CloseConnection);
      while (sqlDataReader.Read())
      {
        MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode glTreeNode = new MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode(Convert.ToBoolean(sqlDataReader["controlacct"]));
        glTreeNode.IsMasterAccountNode = false;
        glTreeNode.IsBankAccount = GLNode.IsBankAccount;
        ((KeyedSubObjectBase) glTreeNode).Key = sqlDataReader["glacctid"].ToString();
        glTreeNode.GLAccountShortName = sqlDataReader["shortname"].ToString();
        glTreeNode.GLAccountFullName = sqlDataReader["fullname"].ToString();
        glTreeNode.GLAccountID = Convert.ToInt32(sqlDataReader["glacctid"]);
        glTreeNode.GlAccount = new GLAccount(int.Parse(sqlDataReader["glacctid"].ToString()));
        if (glTreeNode.IsControlNode)
        {
          glTreeNode.LeftImages.Add((object) this.imageListGlAccountImages.Images[4]);
          glTreeNode.Expanded = false;
          glTreeNode.AllowLoadChildren = true;
        }
        else
        {
          glTreeNode.Override.ShowExpansionIndicator = (ShowExpansionIndicator) 2;
          if (!glTreeNode.GlAccount.IsClosed)
            glTreeNode.LeftImages.Add((object) this.imageListGlAccountImages.Images[5]);
          else
            glTreeNode.LeftImages.Add((object) this.imageListGlAccountImages.Images[7]);
        }
        GLNode.Nodes.Add((UltraTreeNode) glTreeNode);
      }
      sqlDataReader.Close();
    }
    catch (SqlException ex)
    {
      int num = (int) MessageBox.Show("An error has occurred while trying to load the receivable accounts in to the drop down tree.\r\n\r\n" + ex.Errors[0].Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    catch (Exception ex)
    {
      int num = (int) MessageBox.Show("An error has occurred while trying to load the receivable accounts in to the drop down tree.\r\n\r\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    finally
    {
      if (sqlCommand2.Connection.State != ConnectionState.Closed)
        sqlCommand2.Connection.Close();
      sqlCommand2.Connection.Dispose();
      sqlCommand2.Connection = (SqlConnection) null;
      sqlCommand2.Dispose();
      sqlCommand1 = (SqlCommand) null;
    }
  }

  private void treeGlAccounts_AfterSelect(object sender, SelectEventArgs e)
  {
    if (((DisposableObjectCollectionBase) e.NewSelections).Count == 0)
      return;
    if (e.NewSelections[0] is MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode)
    {
      try
      {
        this.glAccount = new GLAccount(int.Parse(((KeyedSubObjectBase) e.NewSelections[0]).Key, NumberStyles.Any));
        this.radioLastTen.Checked = true;
        this.BindToObject();
        this.panelAccountInformation.Visible = true;
        this.panelControlAccountInformation.Visible = false;
        this.panelStart.Visible = false;
      }
      catch (FormatException ex)
      {
        this.panelAccountInformation.Visible = false;
        this.panelStart.Visible = false;
        this.panelControlAccountInformation.Visible = true;
        this.labelControlGroupHeader.Text = e.NewSelections[0].Text;
      }
      catch (GLAccountNotFoundException ex)
      {
        this.panelAccountInformation.Visible = false;
        this.panelStart.Visible = false;
        this.panelControlAccountInformation.Visible = true;
        this.labelControlGroupHeader.Text = e.NewSelections[0].Text;
      }
    }
    else
    {
      this.panelAccountInformation.Visible = false;
      this.panelControlAccountInformation.Visible = false;
      this.panelStart.Visible = true;
    }
  }

  private void BindToObject()
  {
    if (this.glAccount == null)
      return;
    this.labelAccountClassName.DataBindings.Clear();
    this.labelAccountClassName.DataBindings.Add("Text", (object) this.glAccount, "GLAccountClassName");
    this.labelFullName.DataBindings.Clear();
    this.labelFullName.DataBindings.Add("Text", (object) this.glAccount, "AccountFullName");
    this.labelShortName.DataBindings.Clear();
    this.labelShortName.DataBindings.Add("Text", (object) this.glAccount, "AccountShortName");
    this.labelGLAccountID.DataBindings.Clear();
    this.labelGLAccountID.DataBindings.Add("Text", (object) this.glAccount, "GLAccountId");
    this.labelAccountNumber.DataBindings.Clear();
    this.labelAccountNumber.DataBindings.Add("Text", (object) this.glAccount, "GlAccountNumber");
    this.labelLinkedEntity.DataBindings.Clear();
    this.labelLinkedEntity.DataBindings.Add("Text", (object) this.glAccount, "LinkedEntityName");
    this.labelCurrentBalance.DataBindings.Clear();
    this.labelCurrentBalance.DataBindings.Add("Text", (object) this.glAccount, "CurrentBalance");
    this.LoadGLRecentTransactions(this.glAccount.GLAccountID);
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key;
    if (key == null)
      return;
    switch (key.Length)
    {
      case 5:
        if (!(key == "CLOSE"))
          return;
        break;
      case 6:
        switch (key[0])
        {
          case 'D':
            if (!(key == "Delete"))
              return;
            MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode selectedNode1 = this.treeGlAccounts.SelectedNodes[0] as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode;
            if (selectedNode1.GlAccount == null)
              return;
            if (selectedNode1.GlAccount.IsSystemDefined)
            {
              int num = (int) MessageBox.Show("The GL account you are trying to delete is system-defined and can not be deleted.", "Can Not Delete System Defined Accounts!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
            this.DeleteGLAccount(selectedNode1.GlAccount);
            return;
          case 'F':
            if (!(key == "FISCAL"))
              return;
            using (formFiscalConfiguration fiscalConfiguration = new formFiscalConfiguration())
            {
              int num = (int) fiscalConfiguration.ShowDialog();
              return;
            }
          default:
            return;
        }
      case 7:
        return;
      case 8:
        return;
      case 9:
        return;
      case 10:
        if (!(key == "Properties"))
          return;
        MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode selectedNode2 = this.treeGlAccounts.SelectedNodes[0] as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode;
        using (formGLAccountDialog formGlAccountDialog = new formGLAccountDialog(selectedNode2.IsControlNode ? formGLAccountDialog.AccountType.ControlAccount : formGLAccountDialog.AccountType.GlAccount, ref selectedNode2, true))
        {
          int num = (int) formGlAccountDialog.ShowDialog();
          return;
        }
      case 11:
        if (!(key == "DeleteChart"))
          return;
        this.DeleteChartOfAccounts((this.treeGlAccounts.SelectedNodes[0] as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode).GlCompanyId);
        return;
      case 12:
        switch (key[0])
        {
          case 'C':
            if (!(key == "CloseAccount"))
              return;
            break;
          case 'J':
            if (!(key == "JournalEntry"))
              return;
            using (Form form = ObjectFactory.Instance.CreateForm(typeof (FormJournalEntry_Advanced)))
            {
              int num = (int) form.ShowDialog();
              return;
            }
          case 'N':
            if (!(key == "NewGLAccount"))
              return;
            this.NewGLAccount();
            return;
          default:
            return;
        }
        break;
      case 13:
        return;
      case 14:
        return;
      case 15:
        if (!(key == "ChartOfAccounts"))
          return;
        using (formCreateCompany formCreateCompany = new formCreateCompany())
        {
          if (formCreateCompany.ShowDialog() != DialogResult.OK)
            return;
          this.Cursor = Cursors.WaitCursor;
          try
          {
            this.LoadOfficeLocationNodes();
            return;
          }
          finally
          {
            this.Cursor = Cursors.Default;
          }
        }
      case 16 /*0x10*/:
        return;
      case 17:
        switch (key[0])
        {
          case 'I':
            if (!(key == "INVOICECORRECTION"))
              return;
            if (!SecurityManager.Instance.AssertPermission("{840AB406-22A8-41a2-B7E6-71AF171E2C75}"))
            {
              int num = (int) MessageBox.Show("You do not have rights to access the requested resource. Please contact your system administrator.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
            using (formInvoiceLedgerEntryWizard ledgerEntryWizard = new formInvoiceLedgerEntryWizard())
            {
              int num = (int) ledgerEntryWizard.ShowDialog();
              return;
            }
          case 'N':
            if (!(key == "NewControlAccount"))
              return;
            this.NewControlAccount();
            return;
          default:
            return;
        }
      default:
        return;
    }
    MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode selectedNode3 = this.treeGlAccounts.SelectedNodes[0] as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode;
    if (selectedNode3.GlAccount == null)
      return;
    if (selectedNode3.GlAccount.IsSystemDefined)
    {
      int num1 = (int) MessageBox.Show("The GL account you are trying to close is system-defined and cannot be closed.", "Cannot Close System Defined Accounts!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (selectedNode3.GlAccount.IsControlAccount)
    {
      int num2 = (int) MessageBox.Show("The GL account you are trying to close a control account and cannot be closed.", "Cannot Close Control Accounts!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
      this.CloseGLAccount(selectedNode3.GlAccount);
  }

  private void CloseGLAccount(GLAccount glAccount)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DefaultDatabase.ExecuteNonQuery("spFin_OpenCloseGLAccount", new object[4]
      {
        (object) "@Closed",
        (object) !glAccount.IsClosed,
        (object) "@GLAcctId",
        (object) glAccount.GLAccountID
      });
      this.LoadIcon();
      this.LoadOfficeLocationNodes();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void NewControlAccount()
  {
    if (((DisposableObjectCollectionBase) this.treeGlAccounts.SelectedNodes).Count == 0 || this.treeGlAccounts.SelectedNodes[0] == null)
      return;
    MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode selectedNode = this.treeGlAccounts.SelectedNodes[0] as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode;
    if (selectedNode.IsLocationNode)
      return;
    using (formGLAccountDialog formGlAccountDialog = new formGLAccountDialog(formGLAccountDialog.AccountType.ControlAccount, ref selectedNode, false))
    {
      int num = (int) formGlAccountDialog.ShowDialog();
    }
  }

  private void NewGLAccount()
  {
    if (((DisposableObjectCollectionBase) this.treeGlAccounts.SelectedNodes).Count == 0 || this.treeGlAccounts.SelectedNodes[0] == null)
      return;
    MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode selectedNode = this.treeGlAccounts.SelectedNodes[0] as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode;
    if (selectedNode.IsLocationNode)
      return;
    using (formGLAccountDialog formGlAccountDialog = new formGLAccountDialog(formGLAccountDialog.AccountType.GlAccount, ref selectedNode, false))
    {
      int num = (int) formGlAccountDialog.ShowDialog();
    }
  }

  private void LoadGLRecentTransactions(int glAccountId)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
      {
        using (SqlCommand selectCommand = new SqlCommand("spFin_GetGLAccountRecentTransactions", connection))
        {
          selectCommand.CommandType = CommandType.StoredProcedure;
          selectCommand.Parameters.AddWithValue("@glacctid", (object) glAccountId);
          using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
          {
            this.dsGLAccount_RecentTransactions1.Clear();
            sqlDataAdapter.Fill((DataTable) this.dsGLAccount_RecentTransactions1.TransactionList);
          }
        }
      }
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void LoadGLRecentTransactions(int glAccountId, DateTime dateFrom, DateTime dateTo)
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand selectCommand = new SqlCommand("spFin_GetGLAccountRecentTransactions", connection))
      {
        selectCommand.CommandType = CommandType.StoredProcedure;
        selectCommand.Parameters.AddWithValue("@glacctid", (object) glAccountId);
        selectCommand.Parameters.AddWithValue("@dateFrom", (object) dateFrom);
        selectCommand.Parameters.AddWithValue("@dateTo", (object) dateTo);
        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
        {
          this.dsGLAccount_RecentTransactions1.Clear();
          sqlDataAdapter.Fill((DataTable) this.dsGLAccount_RecentTransactions1.TransactionList);
        }
      }
    }
  }

  private void ultraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    if (this.treeGlAccounts.SelectedNodes[0].IsRootLevelNode)
    {
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      if ((this.treeGlAccounts.SelectedNodes[0] as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode).GlAccount != null && (this.treeGlAccounts.SelectedNodes[0] as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode).GlAccount.IsClosed)
        ((ToolPropsBase) ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools)["CLOSE"].SharedProps).Caption = "Open Account";
      else
        ((ToolPropsBase) ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools)["CLOSE"].SharedProps).Caption = "Close Account";
      if (((KeyedSubObjectBase) ((CancelableToolEventArgs) e).Tool).Key != "Context1")
        return;
      if ((this.treeGlAccounts.SelectedNodes[0] as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode).IsLocationNode)
      {
        foreach (ToolBase tool in (ToolsCollectionBase) (((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars["GLTreeContextMenu"]).Tools)["Context1"] as PopupMenuTool).Tools)
          tool.SharedProps.Visible = ((KeyedSubObjectBase) tool).Key == "DeleteChart";
      }
      else
      {
        foreach (ToolBase tool in (ToolsCollectionBase) (((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars["GLTreeContextMenu"]).Tools)["Context1"] as PopupMenuTool).Tools)
          tool.SharedProps.Visible = !(((KeyedSubObjectBase) tool).Key == "DeleteChart");
        ButtonTool tool1 = ((ToolsCollectionBase) (((ToolsCollectionBase) (((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars["GLTreeContextMenu"]).Tools)["Context1"] as PopupMenuTool).Tools)["New"] as PopupMenuTool).Tools)["NewControlAccount"] as ButtonTool;
        ButtonTool tool2 = ((ToolsCollectionBase) (((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars["GLTreeContextMenu"]).Tools)["Context1"] as PopupMenuTool).Tools)["Properties"] as ButtonTool;
        if (this.treeGlAccounts.SelectedNodes[0] is MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode)
          ((ToolBase) tool1).SharedProps.Visible = (this.treeGlAccounts.SelectedNodes[0] as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode).IsControlNode;
        if ((this.treeGlAccounts.SelectedNodes[0] as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode).GlAccount != null)
          ((ToolBase) tool2).SharedProps.Visible = !(this.treeGlAccounts.SelectedNodes[0] as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode).GlAccount.IsSystemDefined;
        else
          ((ToolBase) tool2).SharedProps.Visible = false;
      }
    }
  }

  private int GetNodeOfficeLocation(MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode node)
  {
    return node.IsLocationNode ? int.Parse(((KeyedSubObjectBase) node).Key) : this.GetNodeOfficeLocation(node.Parent as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode);
  }

  private void treeGlAccounts_BeforeExpand(object sender, CancelableNodeEventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    string text = e.TreeNode.Text;
    try
    {
      if (!(e.TreeNode is MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode) || !(e.TreeNode as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode).AllowLoadChildren || ((DisposableObjectCollectionBase) e.TreeNode.Nodes).Count != 0)
        return;
      e.TreeNode.Text = "Please wait, loading child accounts....";
      this.Refresh();
      if ((e.TreeNode as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode).IsMasterAccountNode)
        this.LoadMasterAccounts(e.TreeNode as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode, (e.TreeNode as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode).MasterAccountLoadType, (e.TreeNode as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode).GlCompanyId);
      else
        this.LoadChildAccounts(e.TreeNode as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode, (e.TreeNode as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode).GlAccount.GLAccountID, (e.TreeNode as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode).GlCompanyId);
    }
    finally
    {
      e.TreeNode.Text = text;
      this.Cursor = Cursors.Default;
    }
  }

  public void RefreshChildNodes()
  {
    if (((DisposableObjectCollectionBase) this.treeGlAccounts.SelectedNodes).Count <= 0)
      return;
    MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode glTreeNode = (this.treeGlAccounts.SelectedNodes[0] as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode).IsMasterAccountNode || (this.treeGlAccounts.SelectedNodes[0] as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode).IsControlNode ? this.treeGlAccounts.SelectedNodes[0] as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode : this.treeGlAccounts.SelectedNodes[0].Parent as MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLTreeNode;
    if (glTreeNode.HasNodes && ((DisposableObjectCollectionBase) glTreeNode.Nodes).Count > 0)
      glTreeNode.Nodes.Clear();
    glTreeNode.Expanded = false;
    glTreeNode.Expanded = true;
  }

  private void treeGlAccounts_MouseEnterElement(object sender, UIElementEventArgs e)
  {
  }

  private void DeleteGLAccount(GLAccount glAccount)
  {
    if (MessageBox.Show("This will permanently delete the specified GL Account, continue?", "Delete GL Account?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("spFin_DeleteGLAccount", connection))
      {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@delId", (object) glAccount.GLAccountID);
        sqlCommand.Connection.Open();
        sqlCommand.ExecuteNonQuery();
        this.RefreshChildNodes();
      }
    }
  }

  private void gridRecentTransactions_MouseEnterElement(object sender, UIElementEventArgs e)
  {
    if (!(e.Element.GetContext(typeof (UltraGridColumn)) is UltraGridColumn context))
      return;
    if (((KeyedSubObjectBase) context).Key == "Transactnum")
      ((Control) this.gridRecentTransactions).Cursor = Cursors.Hand;
    else
      ((Control) this.gridRecentTransactions).Cursor = Cursors.Default;
  }

  private void ViewTransaction(int transactionNumber)
  {
    try
    {
      Type typeFromString = ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Accounting.SharedForms.formTransactionViewer");
      using (Form form = ObjectFactory.Instance.CreateObject(typeFromString, typeFromString, new object[2]
      {
        (object) transactionNumber,
        (object) 0
      }) as Form)
      {
        int num = (int) form.ShowDialog();
      }
    }
    catch (Exception ex)
    {
      ErrorHandler.SilentHandleError(ex);
    }
  }

  private void gridRecentTransactions_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    if (e.Row == null)
      return;
    this.ViewTransaction(int.Parse(e.Row.Cells["transactnum"].Value.ToString()));
  }

  private void DeleteChartOfAccounts(int glCompanyId)
  {
    Utilities.DeleteChartOfAccounts(glCompanyId, true);
    this.Cursor = Cursors.WaitCursor;
    try
    {
      this.LoadOfficeLocationNodes();
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void AccountViewOptionClicked(object sender, EventArgs e)
  {
    if (this.radioLastTen.Checked)
      this.LoadGLRecentTransactions(this.glAccount.GLAccountID);
    else
      this.LoadGLRecentTransactions(this.glAccount.GLAccountID, this.dateRangeOptionPicker1.DateRangeFrom, this.dateRangeOptionPicker1.DateRangeTo);
  }

  private void AccountViewOptionChanged(object sender, EventArgs e)
  {
    ((Control) this.buttonPrintAccountLedger).Visible = !this.radioLastTen.Checked;
  }

  private void dateRangeOptionPicker1_DateChanged(object sender, MGASystems.IMS.Accounting.Controls.DateRangeEventArgs e)
  {
    if (this.radioLastTen.Checked || this.glAccount == null)
      return;
    this.LoadGLRecentTransactions(this.glAccount.GLAccountID, this.dateRangeOptionPicker1.DateRangeFrom, this.dateRangeOptionPicker1.DateRangeTo);
  }

  private void buttonPrintAccountLedger_Click(object sender, EventArgs e)
  {
    if (this.radioLastTen.Checked)
    {
      int num1 = (int) MessageBox.Show("You can not print an Account Ledger when only showing the last 10 transactions. You must specify a date range using the date range selection tool below.", "Please Select a Date Range!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (this.glAccount == null)
    {
      int num2 = (int) MessageBox.Show("The system can not determine the current GL account.", "Can Not Determine Current GL Account!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.Cursor = Cursors.WaitCursor;
      ReportFactory.Instance.ShowReport(false, typeof (rptAccountTransactionLedger), (object) this.glAccount.GLCompanyId, (object) 0, (object) this.glAccount.GLAccountID.ToString(), (object) this.dateRangeOptionPicker1.DateRangeFrom, (object) this.dateRangeOptionPicker1.DateRangeTo, (object) Guid.Empty, (object) false, (object) false);
      this.Cursor = Cursors.Default;
    }
  }

  public void ToggleToolbarVisible(bool value)
  {
    ((UltraComponentControlManagerBase) this.ultraToolbarsManager1).Visible = value;
    if (value)
      this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.treeGlAccounts, "Context1");
    else
      this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.treeGlAccounts, "Context2");
  }

  private void treeGlAccounts_MouseDown(object sender, MouseEventArgs e)
  {
    this._lastMouseDownPoint = new Point(e.X, e.Y);
  }

  private void treeGlAccounts_MouseMove(object sender, MouseEventArgs e)
  {
    UltraTree ultraTree = sender as UltraTree;
    if (e.Button != MouseButtons.Left)
      return;
    Point pt = new Point(e.X, e.Y);
    Rectangle rectangle = new Rectangle(this._lastMouseDownPoint, SystemInformation.DragSize);
    rectangle.X -= SystemInformation.DragSize.Width / 2;
    rectangle.Y -= SystemInformation.DragSize.Height / 2;
    if (!rectangle.Contains(pt))
      return;
    int num = (int) ((Control) ultraTree).DoDragDrop((object) ultraTree.ActiveNode, DragDropEffects.All);
  }

  private void treeGlAccounts_DragOver(object sender, DragEventArgs e)
  {
    UltraTree ultraTree = sender as UltraTree;
    Point client = ((Control) ultraTree).PointToClient(new Point(e.X, e.Y));
    UltraTreeNode nodeFromPoint = ultraTree.GetNodeFromPoint(client);
    if (nodeFromPoint == null)
    {
      e.Effect = DragDropEffects.None;
    }
    else
    {
      e.Effect = (e.KeyState & 8) == 8 ? DragDropEffects.Copy : DragDropEffects.Move;
      nodeFromPoint.Selected = true;
      ((Control) ultraTree).Refresh();
    }
  }

  private void treeGlAccounts_DragDrop(object sender, DragEventArgs e)
  {
    UltraTree ultraTree = sender as UltraTree;
    Point client = ((Control) ultraTree).PointToClient(new Point(e.X, e.Y));
    UltraTreeNode nodeFromPoint = ultraTree.GetNodeFromPoint(client);
    if (nodeFromPoint == null || !(e.Data.GetData(typeof (UltraTreeNode)) is UltraTreeNode data))
      return;
    ((Control) ultraTree).Select();
    ultraTree.ActiveNode = nodeFromPoint;
    if ((e.KeyState & 8) == 8)
    {
      UltraTreeNode ultraTreeNode = data.Clone() as UltraTreeNode;
      nodeFromPoint.Nodes.Add(ultraTreeNode);
    }
    else
      data.Reposition(nodeFromPoint.Nodes);
  }

  private enum SelectedAccountType
  {
    None,
    GlAccount,
    GlClass,
    GLControlAccount,
    TreeRoot,
  }
}

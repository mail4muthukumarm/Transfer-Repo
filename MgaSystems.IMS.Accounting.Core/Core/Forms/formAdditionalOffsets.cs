// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formAdditionalOffsets
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class formAdditionalOffsets : AccountingNoteDocumentSupport
{
  private IContainer components;
  private int _glCompanyId;
  private int replacementIndex;
  private int glAccountId;
  private string glAccountShortName;
  private string postingComments;
  private Decimal amount;
  private string costCenterName;
  private UltraGrid gridIntercompany;
  private Panel panel3;
  private Panel panel1;
  private Label label5;
  internal PictureBox pictureBox18;
  private Label label4;
  private Panel panel4;
  private MGAButton btnSave;
  private MGAButton btnCancel;
  private int costCenterId;
  private Panel formAdditionalOffsets_Fill_Panel;
  private UltraToolbarsDockArea _formAdditionalOffsets_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formAdditionalOffsets_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formAdditionalOffsets_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _formAdditionalOffsets_Toolbars_Dock_Area_Bottom;
  private MGAButton btnCancelChanges;
  private RadioButton radioDebit;
  private RadioButton radioCredit;
  private MGAButton btnAdd;
  private Label label2;
  private Label label3;
  private MGATextBox txtAmount;
  private MGATextBox txtComments;
  private Label labelGLAccount;
  private ExtendedTreeViewDropDown dropTreeGLAccounts;
  private Label lblCostCenter;
  private MGASimpleComboBox comboCostCenters;
  private Label lblDescription;
  private UltraToolbarsManager AdditionalOffsetToolManager;
  private MGAButton mgaButton1;
  private MGAButton mgaButton2;
  private RadioButton radioButton3;
  private RadioButton radioButton4;
  private Label label10;
  private MGATextBox mgaTextBox3;
  private RadioButton radioButton1;
  private RadioButton radioButton2;
  private Label label1;
  private Label label6;
  private InterCompanyTransferCollection _interCompanyTransfers;
  private bool _isInEditMode;

  public formAdditionalOffsets(int glCompanyId)
  {
    this.InitializeComponent();
    this._glCompanyId = glCompanyId;
    this.dropTreeGLAccounts.LoadGLAccounts(this._glCompanyId);
    this.LoadCostCenters();
  }

  public formAdditionalOffsets(
    int glCompanyId,
    InterCompanyTransferCollection interCompanyTransfer)
  {
    this.InitializeComponent();
    this._glCompanyId = glCompanyId;
    this.InterCompanyTransafers = interCompanyTransfer;
    this.dropTreeGLAccounts.LoadGLAccounts(this._glCompanyId);
    this.LoadCostCenters();
  }

  public formAdditionalOffsets(
    int glCompanyId,
    InterCompanyTransfer transferObject,
    int replacementIndex)
  {
    this.InitializeComponent();
    this._glCompanyId = glCompanyId;
    this.replacementIndex = replacementIndex;
    this.dropTreeGLAccounts.LoadGLAccounts(this._glCompanyId);
    this.glAccountId = transferObject.GlAccountId;
    this.glAccountShortName = transferObject.GlAccountShortName;
    this.amount = transferObject.Amount;
    this.postingComments = transferObject.Comments;
  }

  public int GlAccountId => this.glAccountId;

  public string GlAccountShortName => this.glAccountShortName;

  public string PostingComments => this.postingComments;

  public Decimal Amount => this.amount;

  public int ReplacementIndex => this.replacementIndex;

  public InterCompanyTransferCollection InterCompanyTransafers
  {
    get
    {
      if (this._interCompanyTransfers == null)
        this._interCompanyTransfers = new InterCompanyTransferCollection();
      return this._interCompanyTransfers;
    }
    set => this._interCompanyTransfers = value;
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
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (formAdditionalOffsets));
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    PopupMenuTool popupMenuTool = new PopupMenuTool("ContextMenu");
    ButtonTool buttonTool1 = new ButtonTool("Edit");
    ButtonTool buttonTool2 = new ButtonTool("Delete");
    ButtonTool buttonTool3 = new ButtonTool("Edit");
    Appearance appearance16 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("Delete");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    this.gridIntercompany = new UltraGrid();
    this.panel3 = new Panel();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.panel1 = new Panel();
    this.label5 = new Label();
    this.pictureBox18 = new PictureBox();
    this.label4 = new Label();
    this.panel4 = new Panel();
    this.btnCancelChanges = new MGAButton();
    this.radioDebit = new RadioButton();
    this.radioCredit = new RadioButton();
    this.btnAdd = new MGAButton();
    this.label2 = new Label();
    this.label3 = new Label();
    this.txtAmount = new MGATextBox();
    this.txtComments = new MGATextBox();
    this.labelGLAccount = new Label();
    this.dropTreeGLAccounts = new ExtendedTreeViewDropDown();
    this.lblCostCenter = new Label();
    this.comboCostCenters = new MGASimpleComboBox();
    this.lblDescription = new Label();
    this.AdditionalOffsetToolManager = new UltraToolbarsManager(this.components);
    this.formAdditionalOffsets_Fill_Panel = new Panel();
    this._formAdditionalOffsets_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formAdditionalOffsets_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formAdditionalOffsets_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.mgaButton1 = new MGAButton();
    this.mgaButton2 = new MGAButton();
    this.radioButton3 = new RadioButton();
    this.radioButton4 = new RadioButton();
    this.label10 = new Label();
    this.mgaTextBox3 = new MGATextBox();
    this.radioButton1 = new RadioButton();
    this.radioButton2 = new RadioButton();
    this.label1 = new Label();
    this.label6 = new Label();
    ((ISupportInitialize) this.gridIntercompany).BeginInit();
    this.panel3.SuspendLayout();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.panel1.SuspendLayout();
    this.panel4.SuspendLayout();
    ((ISupportInitialize) this.btnCancelChanges).BeginInit();
    ((ISupportInitialize) this.btnAdd).BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.txtComments).BeginInit();
    ((ISupportInitialize) this.comboCostCenters).BeginInit();
    ((ISupportInitialize) this.AdditionalOffsetToolManager).BeginInit();
    this.formAdditionalOffsets_Fill_Panel.SuspendLayout();
    ((ISupportInitialize) this.mgaButton1).BeginInit();
    ((ISupportInitialize) this.mgaButton2).BeginInit();
    ((ISupportInitialize) this.mgaTextBox3).BeginInit();
    this.SuspendLayout();
    ((Control) this.gridIntercompany).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.AdditionalOffsetToolManager.SetContextMenuUltra((Component) this.gridIntercompany, "ContextMenu");
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridIntercompany).Location = new Point(304, 80 /*0x50*/);
    ((Control) this.gridIntercompany).Name = "gridIntercompany";
    ((Control) this.gridIntercompany).Size = new Size(488, 392);
    ((UltraControlBase) this.gridIntercompany).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridIntercompany).TabIndex = 78;
    this.gridIntercompany.InitializeLayout += new InitializeLayoutEventHandler(this.gridIntercompany_InitializeLayout);
    this.panel3.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panel3.Controls.Add((Control) this.btnSave);
    this.panel3.Controls.Add((Control) this.btnCancel);
    this.panel3.Dock = DockStyle.Bottom;
    this.panel3.Location = new Point(0, 472);
    this.panel3.Name = "panel3";
    this.panel3.Size = new Size(794, 40);
    this.panel3.TabIndex = 80 /*0x50*/;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance10).BorderColor = Color.DarkGray;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance10;
    ((UltraButtonBase) this.btnSave).DialogResult = DialogResult.OK;
    ((Control) this.btnSave).Location = new Point(616, 8);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnSave).TabIndex = 0;
    ((Control) this.btnSave).Text = "&Save";
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance11).BorderColor = Color.DarkGray;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance11;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(704, 8);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnCancel).TabIndex = 1;
    ((Control) this.btnCancel).Text = "&Cancel";
    this.panel1.Controls.Add((Control) this.label5);
    this.panel1.Controls.Add((Control) this.pictureBox18);
    this.panel1.Controls.Add((Control) this.label4);
    this.panel1.Dock = DockStyle.Top;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(794, 80 /*0x50*/);
    this.panel1.TabIndex = 79;
    this.label5.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label5.Dock = DockStyle.Bottom;
    this.label5.ForeColor = Color.Gray;
    this.label5.Location = new Point(0, 79);
    this.label5.Name = "label5";
    this.label5.Size = new Size(762, 1);
    this.label5.TabIndex = 81;
    this.pictureBox18.Image = (Image) resourceManager.GetObject("pictureBox18.Image");
    this.pictureBox18.Location = new Point(16 /*0x10*/, 8);
    this.pictureBox18.Name = "pictureBox18";
    this.pictureBox18.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.pictureBox18.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox18.TabIndex = 4;
    this.pictureBox18.TabStop = false;
    this.label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.label4.AutoSize = true;
    this.label4.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label4.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label4.Location = new Point(568, 48 /*0x30*/);
    this.label4.Name = "label4";
    this.label4.Size = new Size(224 /*0xE0*/, 25);
    this.label4.TabIndex = 1;
    this.label4.Text = "Additional Offset Utility";
    this.panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.panel4.Controls.Add((Control) this.btnCancelChanges);
    this.panel4.Controls.Add((Control) this.radioDebit);
    this.panel4.Controls.Add((Control) this.radioCredit);
    this.panel4.Controls.Add((Control) this.btnAdd);
    this.panel4.Controls.Add((Control) this.label2);
    this.panel4.Controls.Add((Control) this.label3);
    this.panel4.Controls.Add((Control) this.txtAmount);
    this.panel4.Controls.Add((Control) this.txtComments);
    this.panel4.Controls.Add((Control) this.labelGLAccount);
    this.panel4.Controls.Add((Control) this.dropTreeGLAccounts);
    this.panel4.Controls.Add((Control) this.lblCostCenter);
    this.panel4.Controls.Add((Control) this.comboCostCenters);
    this.panel4.Controls.Add((Control) this.lblDescription);
    this.panel4.Controls.Add((Control) this.radioButton1);
    this.panel4.Controls.Add((Control) this.radioButton2);
    this.panel4.Controls.Add((Control) this.label1);
    this.panel4.Controls.Add((Control) this.label6);
    this.panel4.Location = new Point(0, 80 /*0x50*/);
    this.panel4.Name = "panel4";
    this.panel4.Size = new Size(304, 392);
    this.panel4.TabIndex = 81;
    ((Control) this.btnCancelChanges).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance12).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance12).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance12).BorderColor = Color.DarkGray;
    ((ControlBase) this.btnCancelChanges).Appearance = (AppearanceBase) appearance12;
    ((Control) this.btnCancelChanges).BackColor = Color.FromArgb(239, 247, 253);
    ((Control) this.btnCancelChanges).Font = new Font("Tahoma", 8f);
    ((Control) this.btnCancelChanges).ForeColor = Color.Black;
    ((Control) this.btnCancelChanges).Location = new Point(208 /*0xD0*/, 360);
    ((Control) this.btnCancelChanges).Name = "btnCancelChanges";
    ((Control) this.btnCancelChanges).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnCancelChanges).TabIndex = 99;
    ((Control) this.btnCancelChanges).Text = "&Cancel";
    ((Control) this.btnCancelChanges).Visible = false;
    ((Control) this.btnCancelChanges).Click += new EventHandler(this.btnCancelChanges_Click);
    this.radioDebit.FlatStyle = FlatStyle.Flat;
    this.radioDebit.Font = new Font("Tahoma", 8f);
    this.radioDebit.ForeColor = Color.Black;
    this.radioDebit.Location = new Point(88, 248);
    this.radioDebit.Name = "radioDebit";
    this.radioDebit.Size = new Size(56, 16 /*0x10*/);
    this.radioDebit.TabIndex = 98;
    this.radioDebit.Text = "Debit";
    this.radioCredit.FlatStyle = FlatStyle.Flat;
    this.radioCredit.Font = new Font("Tahoma", 8f);
    this.radioCredit.ForeColor = Color.Black;
    this.radioCredit.Location = new Point(144 /*0x90*/, 248);
    this.radioCredit.Name = "radioCredit";
    this.radioCredit.Size = new Size(72, 16 /*0x10*/);
    this.radioCredit.TabIndex = 97;
    this.radioCredit.Text = "Credit";
    ((Control) this.btnAdd).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance13).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance13).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance13).BorderColor = Color.DarkGray;
    ((ControlBase) this.btnAdd).Appearance = (AppearanceBase) appearance13;
    ((Control) this.btnAdd).BackColor = Color.FromArgb(239, 247, 253);
    ((Control) this.btnAdd).Font = new Font("Tahoma", 8f);
    ((Control) this.btnAdd).ForeColor = Color.Black;
    ((Control) this.btnAdd).Location = new Point(104, 360);
    ((Control) this.btnAdd).Name = "btnAdd";
    ((Control) this.btnAdd).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.btnAdd).TabIndex = 95;
    ((Control) this.btnAdd).Text = "&Add";
    ((Control) this.btnAdd).Click += new EventHandler(this.btnAddItem_Click);
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 8f);
    this.label2.ForeColor = Color.Black;
    this.label2.Location = new Point(16 /*0x10*/, 224 /*0xE0*/);
    this.label2.Name = "label2";
    this.label2.Size = new Size(46, 16 /*0x10*/);
    this.label2.TabIndex = 93;
    this.label2.Text = "Amount:";
    this.label3.AutoSize = true;
    this.label3.Font = new Font("Tahoma", 8f);
    this.label3.ForeColor = Color.Black;
    this.label3.Location = new Point(8, 112 /*0x70*/);
    this.label3.Name = "label3";
    this.label3.Size = new Size(59, 16 /*0x10*/);
    this.label3.TabIndex = 91;
    this.label3.Text = "Comments:";
    ((AppearanceBase) appearance14).BackColor = Color.White;
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((AppearanceBase) appearance14).TextHAlign = (HAlign) 3;
    ((TextEditorControlBase) this.txtAmount).Appearance = (AppearanceBase) appearance14;
    ((Control) this.txtAmount).BackColor = Color.FromArgb(239, 247, 253);
    ((Control) this.txtAmount).Font = new Font("Tahoma", 8f);
    ((Control) this.txtAmount).ForeColor = Color.Black;
    ((Control) this.txtAmount).Location = new Point(88, 224 /*0xE0*/);
    ((TextEditorControlBase) this.txtAmount).MaxLength = 50;
    this.txtAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAmount).Name = "txtAmount";
    ((Control) this.txtAmount).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.txtAmount).TabIndex = 94;
    ((AppearanceBase) appearance15).BackColor = Color.White;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtComments).Appearance = (AppearanceBase) appearance15;
    ((Control) this.txtComments).BackColor = Color.FromArgb(239, 247, 253);
    ((Control) this.txtComments).Font = new Font("Tahoma", 8f);
    ((Control) this.txtComments).ForeColor = Color.Black;
    ((Control) this.txtComments).Location = new Point(88, 112 /*0x70*/);
    ((TextEditorControlBase) this.txtComments).MaxLength = 2000;
    this.txtComments.MGAStyle = MGAStyles.Blue;
    this.txtComments.Multiline = true;
    ((Control) this.txtComments).Name = "txtComments";
    ((Control) this.txtComments).Size = new Size(208 /*0xD0*/, 104);
    ((Control) this.txtComments).TabIndex = 92;
    this.labelGLAccount.AutoSize = true;
    this.labelGLAccount.Font = new Font("Tahoma", 8f);
    this.labelGLAccount.ForeColor = Color.Black;
    this.labelGLAccount.Location = new Point(8, 88);
    this.labelGLAccount.Name = "labelGLAccount";
    this.labelGLAccount.Size = new Size(63 /*0x3F*/, 16 /*0x10*/);
    this.labelGLAccount.TabIndex = 89;
    this.labelGLAccount.Text = "GL Account:";
    this.dropTreeGLAccounts.BackColor = Color.FromArgb(239, 247, 253);
    this.dropTreeGLAccounts.DropDownHeight = 300;
    this.dropTreeGLAccounts.DropDownWidth = 300;
    this.dropTreeGLAccounts.Font = new Font("Tahoma", 8f);
    this.dropTreeGLAccounts.ForeColor = Color.Black;
    this.dropTreeGLAccounts.Location = new Point(88, 88);
    this.dropTreeGLAccounts.Name = "dropTreeGLAccounts";
    this.dropTreeGLAccounts.ShowEquityAccounts = true;
    this.dropTreeGLAccounts.ShowExpenseAccounts = true;
    this.dropTreeGLAccounts.ShowIncomeAccounts = true;
    this.dropTreeGLAccounts.ShowSystemDefinedAccounts = true;
    this.dropTreeGLAccounts.Size = new Size(208 /*0xD0*/, 20);
    this.dropTreeGLAccounts.TabIndex = 90;
    this.dropTreeGLAccounts.UseCheckedStateSelectionOverride = false;
    this.lblCostCenter.AutoSize = true;
    this.lblCostCenter.Font = new Font("Tahoma", 8f);
    this.lblCostCenter.ForeColor = Color.Black;
    this.lblCostCenter.Location = new Point(8, 64 /*0x40*/);
    this.lblCostCenter.Name = "lblCostCenter";
    this.lblCostCenter.Size = new Size(71, 16 /*0x10*/);
    this.lblCostCenter.TabIndex = 88;
    this.lblCostCenter.Text = "Cost Center : ";
    this.comboCostCenters.AutoSelectOnOneItem = true;
    this.comboCostCenters.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCostCenters.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboCostCenters).DisplayMember = "";
    this.comboCostCenters.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCostCenters).Font = new Font("Tahoma", 8f);
    ((Control) this.comboCostCenters).Location = new Point(88, 64 /*0x40*/);
    this.comboCostCenters.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCostCenters).Name = "comboCostCenters";
    ((Control) this.comboCostCenters).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.comboCostCenters).TabIndex = 87;
    ((UltraDropDownBase) this.comboCostCenters).ValueMember = "";
    this.lblDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblDescription.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblDescription.ForeColor = Color.Black;
    this.lblDescription.Location = new Point(8, 36);
    this.lblDescription.Name = "lblDescription";
    this.lblDescription.Size = new Size(288, 32 /*0x20*/);
    this.lblDescription.TabIndex = 77;
    this.lblDescription.Text = "This utilty Allows you to enter additional offset entirs. ";
    this.AdditionalOffsetToolManager.DesignerFlags = 1;
    this.AdditionalOffsetToolManager.DockWithinContainer = (Control) this;
    this.AdditionalOffsetToolManager.ShowFullMenusDelay = 500;
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).Caption = "ContextMenu";
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ((AppearanceBase) appearance16).Image = resourceManager.GetObject("appearance16.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance16;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).Caption = "&Edit";
    ((AppearanceBase) appearance17).Image = resourceManager.GetObject("appearance17.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance17;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = "&Delete";
    ((ToolsCollectionBase) this.AdditionalOffsetToolManager.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.AdditionalOffsetToolManager.ToolClick += new ToolClickEventHandler(this.ultraToolbars_ToolClick);
    this.formAdditionalOffsets_Fill_Panel.Controls.Add((Control) this.mgaButton1);
    this.formAdditionalOffsets_Fill_Panel.Controls.Add((Control) this.mgaButton2);
    this.formAdditionalOffsets_Fill_Panel.Controls.Add((Control) this.panel4);
    this.formAdditionalOffsets_Fill_Panel.Controls.Add((Control) this.gridIntercompany);
    this.formAdditionalOffsets_Fill_Panel.Controls.Add((Control) this.panel3);
    this.formAdditionalOffsets_Fill_Panel.Controls.Add((Control) this.panel1);
    this.formAdditionalOffsets_Fill_Panel.Controls.Add((Control) this.radioButton3);
    this.formAdditionalOffsets_Fill_Panel.Controls.Add((Control) this.radioButton4);
    this.formAdditionalOffsets_Fill_Panel.Controls.Add((Control) this.label10);
    this.formAdditionalOffsets_Fill_Panel.Controls.Add((Control) this.mgaTextBox3);
    this.formAdditionalOffsets_Fill_Panel.Cursor = Cursors.Default;
    this.formAdditionalOffsets_Fill_Panel.Dock = DockStyle.Fill;
    this.formAdditionalOffsets_Fill_Panel.Location = new Point(0, 0);
    this.formAdditionalOffsets_Fill_Panel.Name = "formAdditionalOffsets_Fill_Panel";
    this.formAdditionalOffsets_Fill_Panel.Size = new Size(794, 512 /*0x0200*/);
    this.formAdditionalOffsets_Fill_Panel.TabIndex = 0;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._formAdditionalOffsets_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Left).Name = "_formAdditionalOffsets_Toolbars_Dock_Area_Left";
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Left).Size = new Size(0, 512 /*0x0200*/);
    this._formAdditionalOffsets_Toolbars_Dock_Area_Left.ToolbarsManager = this.AdditionalOffsetToolManager;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._formAdditionalOffsets_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Right).Location = new Point(794, 0);
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Right).Name = "_formAdditionalOffsets_Toolbars_Dock_Area_Right";
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Right).Size = new Size(0, 512 /*0x0200*/);
    this._formAdditionalOffsets_Toolbars_Dock_Area_Right.ToolbarsManager = this.AdditionalOffsetToolManager;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._formAdditionalOffsets_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Top).Name = "_formAdditionalOffsets_Toolbars_Dock_Area_Top";
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Top).Size = new Size(794, 0);
    this._formAdditionalOffsets_Toolbars_Dock_Area_Top.ToolbarsManager = this.AdditionalOffsetToolManager;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom).Location = new Point(0, 512 /*0x0200*/);
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom).Name = "_formAdditionalOffsets_Toolbars_Dock_Area_Bottom";
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom).Size = new Size(794, 0);
    this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.AdditionalOffsetToolManager;
    ((Control) this.mgaButton1).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance18).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance18).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance18).BorderColor = Color.DarkGray;
    ((ControlBase) this.mgaButton1).Appearance = (AppearanceBase) appearance18;
    ((Control) this.mgaButton1).BackColor = Color.FromArgb(239, 247, 253);
    ((Control) this.mgaButton1).Font = new Font("Tahoma", 8f);
    ((Control) this.mgaButton1).ForeColor = Color.Black;
    ((Control) this.mgaButton1).Location = new Point(616, 424);
    ((Control) this.mgaButton1).Name = "mgaButton1";
    ((Control) this.mgaButton1).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.mgaButton1).TabIndex = 112 /*0x70*/;
    ((Control) this.mgaButton1).Text = "&Cancel";
    ((Control) this.mgaButton1).Visible = false;
    ((Control) this.mgaButton2).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance19).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance19).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance19).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance19).BorderColor = Color.DarkGray;
    ((ControlBase) this.mgaButton2).Appearance = (AppearanceBase) appearance19;
    ((Control) this.mgaButton2).BackColor = Color.FromArgb(239, 247, 253);
    ((Control) this.mgaButton2).Font = new Font("Tahoma", 8f);
    ((Control) this.mgaButton2).ForeColor = Color.Black;
    ((Control) this.mgaButton2).Location = new Point(512 /*0x0200*/, 424);
    ((Control) this.mgaButton2).Name = "mgaButton2";
    ((Control) this.mgaButton2).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.mgaButton2).TabIndex = 109;
    ((Control) this.mgaButton2).Text = "&Add";
    this.radioButton3.BackColor = Color.White;
    this.radioButton3.FlatStyle = FlatStyle.Flat;
    this.radioButton3.Font = new Font("Tahoma", 8f);
    this.radioButton3.ForeColor = Color.Black;
    this.radioButton3.Location = new Point(496, 312);
    this.radioButton3.Name = "radioButton3";
    this.radioButton3.Size = new Size(56, 16 /*0x10*/);
    this.radioButton3.TabIndex = 111;
    this.radioButton3.Text = "Debit";
    this.radioButton4.BackColor = Color.White;
    this.radioButton4.FlatStyle = FlatStyle.Flat;
    this.radioButton4.Font = new Font("Tahoma", 8f);
    this.radioButton4.ForeColor = Color.Black;
    this.radioButton4.Location = new Point(552, 312);
    this.radioButton4.Name = "radioButton4";
    this.radioButton4.Size = new Size(72, 16 /*0x10*/);
    this.radioButton4.TabIndex = 110;
    this.radioButton4.Text = "Credit";
    this.label10.AutoSize = true;
    this.label10.BackColor = Color.White;
    this.label10.Font = new Font("Tahoma", 8f);
    this.label10.ForeColor = Color.Black;
    this.label10.Location = new Point(424, 288);
    this.label10.Name = "label10";
    this.label10.Size = new Size(46, 16 /*0x10*/);
    this.label10.TabIndex = 107;
    this.label10.Text = "Amount:";
    ((AppearanceBase) appearance20).BackColor = Color.White;
    ((AppearanceBase) appearance20).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ((AppearanceBase) appearance20).TextHAlign = (HAlign) 3;
    ((TextEditorControlBase) this.mgaTextBox3).Appearance = (AppearanceBase) appearance20;
    ((Control) this.mgaTextBox3).BackColor = Color.FromArgb(239, 247, 253);
    ((Control) this.mgaTextBox3).Font = new Font("Tahoma", 8f);
    ((Control) this.mgaTextBox3).ForeColor = Color.Black;
    ((Control) this.mgaTextBox3).Location = new Point(496, 288);
    ((TextEditorControlBase) this.mgaTextBox3).MaxLength = 50;
    this.mgaTextBox3.MGAStyle = MGAStyles.Blue;
    ((Control) this.mgaTextBox3).Name = "mgaTextBox3";
    ((Control) this.mgaTextBox3).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.mgaTextBox3).TabIndex = 108;
    this.radioButton1.FlatStyle = FlatStyle.Flat;
    this.radioButton1.Font = new Font("Tahoma", 8f);
    this.radioButton1.ForeColor = Color.Black;
    this.radioButton1.Location = new Point(88, 248);
    this.radioButton1.Name = "radioButton1";
    this.radioButton1.Size = new Size(56, 16 /*0x10*/);
    this.radioButton1.TabIndex = 98;
    this.radioButton1.Text = "Debit";
    this.radioButton2.FlatStyle = FlatStyle.Flat;
    this.radioButton2.Font = new Font("Tahoma", 8f);
    this.radioButton2.ForeColor = Color.Black;
    this.radioButton2.Location = new Point(144 /*0x90*/, 248);
    this.radioButton2.Name = "radioButton2";
    this.radioButton2.Size = new Size(72, 16 /*0x10*/);
    this.radioButton2.TabIndex = 97;
    this.radioButton2.Text = "Credit";
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 8f);
    this.label1.ForeColor = Color.Black;
    this.label1.Location = new Point(16 /*0x10*/, 224 /*0xE0*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(46, 16 /*0x10*/);
    this.label1.TabIndex = 93;
    this.label1.Text = "Amount:";
    this.label6.AutoSize = true;
    this.label6.Font = new Font("Tahoma", 8f);
    this.label6.ForeColor = Color.Black;
    this.label6.Location = new Point(8, 112 /*0x70*/);
    this.label6.Name = "label6";
    this.label6.Size = new Size(59, 16 /*0x10*/);
    this.label6.TabIndex = 91;
    this.label6.Text = "Comments:";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(794, 512 /*0x0200*/);
    this.ControlBox = false;
    this.Controls.Add((Control) this.formAdditionalOffsets_Fill_Panel);
    this.Controls.Add((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formAdditionalOffsets);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Additional Offset";
    this.Load += new EventHandler(this.formAdditionalOffsets_Load);
    ((ISupportInitialize) this.gridIntercompany).EndInit();
    this.panel3.ResumeLayout(false);
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.panel1.ResumeLayout(false);
    this.panel4.ResumeLayout(false);
    ((ISupportInitialize) this.btnCancelChanges).EndInit();
    ((ISupportInitialize) this.btnAdd).EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.txtComments).EndInit();
    ((ISupportInitialize) this.comboCostCenters).EndInit();
    ((ISupportInitialize) this.AdditionalOffsetToolManager).EndInit();
    this.formAdditionalOffsets_Fill_Panel.ResumeLayout(false);
    ((ISupportInitialize) this.mgaButton1).EndInit();
    ((ISupportInitialize) this.mgaButton2).EndInit();
    ((ISupportInitialize) this.mgaTextBox3).EndInit();
    this.ResumeLayout(false);
  }

  private void LoadCostCenters()
  {
    DataSet dataSet = new DataSet();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetCostCentersList", new SqlConnection(CurrentUser.Instance.ConnectionString)));
    SqlCommand sqlCommand = (SqlCommand) null;
    try
    {
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@glcompanyid", (object) this._glCompanyId);
      sqlDataAdapter.Fill(dataSet);
      ((UltraGridBase) this.comboCostCenters).DataSource = (object) dataSet;
      ((UltraGridBase) this.comboCostCenters).DataMember = dataSet.Tables[0].TableName;
      ((UltraDropDownBase) this.comboCostCenters).DisplayMember = "Name";
      ((UltraDropDownBase) this.comboCostCenters).ValueMember = "CostCenterId";
    }
    finally
    {
      if (sqlDataAdapter.SelectCommand.Connection.State != ConnectionState.Closed)
        sqlDataAdapter.SelectCommand.Connection.Close();
      sqlDataAdapter.SelectCommand.Connection.Dispose();
      sqlDataAdapter.SelectCommand.Dispose();
      sqlDataAdapter.Dispose();
      if (sqlCommand != null)
      {
        if (sqlCommand.Connection.State != ConnectionState.Closed)
          sqlCommand.Connection.Close();
        sqlCommand.Connection.Dispose();
        sqlCommand.Dispose();
      }
    }
  }

  private void gridIntercompany_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    ((HeaderBase) ((UltraGridBase) this.gridIntercompany).DisplayLayout.Bands[0].Columns["TransactionType"].Header).VisiblePosition = 0;
    ((HeaderBase) ((UltraGridBase) this.gridIntercompany).DisplayLayout.Bands[0].Columns["GlAccountShortName"].Header).VisiblePosition = 1;
    ((HeaderBase) ((UltraGridBase) this.gridIntercompany).DisplayLayout.Bands[0].Columns["CostCenterName"].Header).VisiblePosition = 2;
    ((HeaderBase) ((UltraGridBase) this.gridIntercompany).DisplayLayout.Bands[0].Columns["Amount"].Header).VisiblePosition = 3;
    ((HeaderBase) ((UltraGridBase) this.gridIntercompany).DisplayLayout.Bands[0].Columns["Amount"].Header).Appearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Bands[0].Columns["Amount"].CellAppearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Bands[0].Columns["Amount"].Format = "c";
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Bands[0].Columns["GlAccountId"].Hidden = true;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Bands[0].Columns["Comments"].Hidden = true;
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Bands[0].Columns["CostCenterId"].Hidden = true;
    ((HeaderBase) ((UltraGridBase) this.gridIntercompany).DisplayLayout.Bands[0].Columns["TransactionType"].Header).Caption = " Transaction Type";
    ((HeaderBase) ((UltraGridBase) this.gridIntercompany).DisplayLayout.Bands[0].Columns["GlAccountShortName"].Header).Caption = "Gl Account";
    ((HeaderBase) ((UltraGridBase) this.gridIntercompany).DisplayLayout.Bands[0].Columns["CostCenterName"].Header).Caption = "Cost Center";
    ((UltraGridBase) this.gridIntercompany).DisplayLayout.Bands[0].ScrollTipField = "Comments";
  }

  private void formAdditionalOffsets_Load(object sender, EventArgs e)
  {
    ((UltraGridBase) this.gridIntercompany).DataSource = (object) this.InterCompanyTransafers;
  }

  private bool ValidateValues()
  {
    if (((Control) this.txtAmount).Text == string.Empty)
    {
      int num = (int) MessageBox.Show("Amount is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!Information.IsNumeric((object) ((Control) this.txtAmount).Text))
    {
      int num = (int) MessageBox.Show("Amount must numeric", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.comboCostCenters.SelectedIndex == -1)
    {
      int num = (int) MessageBox.Show("Must select a cost center", "Required Item Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.radioCredit.Checked || this.radioDebit.Checked)
      return true;
    int num1 = (int) MessageBox.Show("Must Select either a credit or debit", "Required Item Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void btnAddItem_Click(object sender, EventArgs e)
  {
    if (!this.ValidateValues())
      return;
    this.glAccountId = this.dropTreeGLAccounts.GLAccountID;
    this.amount = Decimal.Parse(((Control) this.txtAmount).Text, NumberStyles.Any);
    this.costCenterId = int.Parse(this.comboCostCenters.Value.ToString());
    this.postingComments = ((Control) this.txtComments).Text;
    this.glAccountShortName = this.dropTreeGLAccounts.GLAccountShortName;
    this.costCenterName = ((Control) this.comboCostCenters).Text;
    if (!this._isInEditMode)
    {
      this.InterCompanyTransafers.Add(new InterCompanyTransfer(this.glAccountId, this.glAccountShortName, this.postingComments, this.amount, this.costCenterId, this.costCenterName, this.radioCredit.Checked));
    }
    else
    {
      InterCompanyTransfer companyTransafer = this.InterCompanyTransafers[((Control) this.gridIntercompany).BindingContext[(object) this.InterCompanyTransafers].Position];
      companyTransafer.Amount = this.amount;
      companyTransafer.Comments = this.postingComments;
      companyTransafer.CostCenterId = this.costCenterId;
      companyTransafer.CostCenterName = this.costCenterName;
      companyTransafer.GlAccountId = this.glAccountId;
      companyTransafer.GlAccountShortName = this.GlAccountShortName;
      companyTransafer.SetTransactionType = this.radioCredit.Checked;
      ((Control) this.btnCancelChanges).Visible = false;
      ((Control) this.btnSave).Text = "Add";
    }
    this.ResetControlValues();
  }

  private void ResetControlValues()
  {
    this.dropTreeGLAccounts.ResetText();
    this.comboCostCenters.SelectedIndex = -1;
    ((Control) this.txtComments).Text = string.Empty;
    ((Control) this.txtAmount).Text = string.Empty;
    this.radioCredit.Checked = this.radioDebit.Checked = false;
  }

  private void ultraToolbars_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (this.gridIntercompany.Selected == null || ((SparseCollectionBase) this.gridIntercompany.Selected.Rows).Count == 0)
      return;
    UltraGridRow row = this.gridIntercompany.Selected.Rows[0];
    int position = ((Control) this.gridIntercompany).BindingContext[(object) this.InterCompanyTransafers].Position;
    if (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key.ToUpper() == "DELETE")
    {
      this.InterCompanyTransafers.RemoveAt(position);
      this.ResetControlValues();
    }
    else
    {
      if (!(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key.ToUpper() == "EDIT"))
        return;
      ((Control) this.txtComments).Text = this.InterCompanyTransafers[position].Comments;
      ((Control) this.txtAmount).Text = this.InterCompanyTransafers[position].Amount.ToString("C");
      this.comboCostCenters.Value = (object) this.InterCompanyTransafers[position].CostCenterId;
      this.dropTreeGLAccounts.SetSelectedNodeByKey(this.InterCompanyTransafers[position].GlAccountId.ToString());
      if (this.InterCompanyTransafers[position].TransactionType == "Credit")
        this.radioCredit.Checked = true;
      else
        this.radioDebit.Checked = true;
      ((Control) this.btnAdd).Text = "Save";
      ((Control) this.btnCancelChanges).Visible = true;
      this._isInEditMode = true;
    }
  }

  private void btnCancelChanges_Click(object sender, EventArgs e)
  {
    ((Control) this.btnCancelChanges).Visible = false;
    ((Control) this.btnAdd).Text = "Add";
    this._isInEditMode = false;
    this.ResetControlValues();
  }
}

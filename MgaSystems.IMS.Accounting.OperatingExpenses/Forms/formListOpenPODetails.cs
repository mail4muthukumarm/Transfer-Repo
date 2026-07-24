// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formListOpenPODetails
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

public class formListOpenPODetails : AccountingNoteDocumentSupport
{
  internal Panel Panel2;
  internal Label label7;
  internal PictureBox PictureBox1;
  internal Panel Panel1;
  internal MGAButton buttonCancel;
  internal MGAButton buttonSave;
  private UltraGrid gridOpenPODetails;
  private dsOpenPODetails dsOpenPODetails1;
  private Panel panel3;
  private MGATextBox textPostingComments;
  internal UltraLabel ultraLabel6;
  private MGADateTimePicker dateTimeCheckDate;
  internal UltraLabel ultraLabel5;
  private MGASimpleComboBox comboPaymentMethod;
  internal UltraLabel ultraLabel3;
  private MGASimpleComboBox comboBankAccounts;
  internal UltraLabel ultraLabel2;
  internal Label labelHeader;
  private System.ComponentModel.Container components;
  private int _glCompanyId;
  private Guid _payeeGuid;
  private object _originalCellValue;
  private ArrayList _detailObjects;

  public formListOpenPODetails() => this.InitializeComponent();

  public formListOpenPODetails(int[] poNumbers, int glCompanyId, Guid payeeGuid, string payeeName)
  {
    this.InitializeComponent();
    this._glCompanyId = glCompanyId;
    this._payeeGuid = payeeGuid;
    this.labelHeader.Text = $"{payeeName} {this.labelHeader.Text}";
    for (int index = 0; index < poNumbers.Length; ++index)
      this.LoadOpenPODetails(poNumbers[index]);
    this.GetBankAccounts();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (formListOpenPODetails));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("DetailsTable", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ExpenseName");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Amount");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Balance");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("PONum");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("GLAcctId");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ExpenseCode");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("PAY", 0);
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    this.Panel2 = new Panel();
    this.label7 = new Label();
    this.PictureBox1 = new PictureBox();
    this.labelHeader = new Label();
    this.Panel1 = new Panel();
    this.buttonSave = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.gridOpenPODetails = new UltraGrid();
    this.dsOpenPODetails1 = new dsOpenPODetails();
    this.panel3 = new Panel();
    this.ultraLabel2 = new UltraLabel();
    this.comboBankAccounts = new MGASimpleComboBox();
    this.ultraLabel3 = new UltraLabel();
    this.comboPaymentMethod = new MGASimpleComboBox();
    this.dateTimeCheckDate = new MGADateTimePicker();
    this.ultraLabel5 = new UltraLabel();
    this.textPostingComments = new MGATextBox();
    this.ultraLabel6 = new UltraLabel();
    this.Panel2.SuspendLayout();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.gridOpenPODetails).BeginInit();
    this.dsOpenPODetails1.BeginInit();
    this.panel3.SuspendLayout();
    ((ISupportInitialize) this.comboBankAccounts).BeginInit();
    ((ISupportInitialize) this.comboPaymentMethod).BeginInit();
    ((ISupportInitialize) this.dateTimeCheckDate).BeginInit();
    ((ISupportInitialize) this.textPostingComments).BeginInit();
    this.SuspendLayout();
    this.Panel2.Controls.Add((Control) this.label7);
    this.Panel2.Controls.Add((Control) this.PictureBox1);
    this.Panel2.Controls.Add((Control) this.labelHeader);
    this.Panel2.Dock = DockStyle.Top;
    this.Panel2.Location = new Point(0, 0);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(714, 80 /*0x50*/);
    this.Panel2.TabIndex = 41;
    this.label7.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label7.Dock = DockStyle.Bottom;
    this.label7.ForeColor = Color.FromArgb(239, 247, 253);
    this.label7.Location = new Point(0, 79);
    this.label7.Name = "label7";
    this.label7.Size = new Size(714, 1);
    this.label7.TabIndex = 1;
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(8, -8);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(100, 100);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox1.TabIndex = 1;
    this.PictureBox1.TabStop = false;
    this.labelHeader.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.labelHeader.Font = new Font("Arial", 12f, FontStyle.Bold);
    this.labelHeader.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.labelHeader.Location = new Point(120, 56);
    this.labelHeader.Name = "labelHeader";
    this.labelHeader.Size = new Size(584, 22);
    this.labelHeader.TabIndex = 0;
    this.labelHeader.Text = "Multi PO Payment Utility";
    this.labelHeader.TextAlign = ContentAlignment.TopRight;
    this.Panel1.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Panel1.Controls.Add((Control) this.buttonSave);
    this.Panel1.Controls.Add((Control) this.buttonCancel);
    this.Panel1.Dock = DockStyle.Bottom;
    this.Panel1.Location = new Point(0, 568);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(714, 40);
    this.Panel1.TabIndex = 43;
    ((Control) this.buttonSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonSave).Location = new Point(506, 8);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonSave).TabIndex = 5;
    ((Control) this.buttonSave).Text = "Save Changes";
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(610, 8);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonCancel).TabIndex = 3;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((UltraGridBase) this.gridOpenPODetails).DataSource = (object) this.dsOpenPODetails1;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance4).TextHAlign = (HAlign) 1;
    ultraGridColumn1.CellAppearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Expense";
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 1;
    ultraGridColumn1.Width = 181;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance6).TextHAlign = (HAlign) 3;
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance6;
    ultraGridColumn2.Format = "c";
    ((AppearanceBase) appearance7).TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 2;
    ultraGridColumn2.Width = 138;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance8).TextHAlign = (HAlign) 3;
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance8;
    ultraGridColumn3.Format = "c";
    ((AppearanceBase) appearance9).TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 3;
    ultraGridColumn3.Width = 120;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance10).TextHAlign = (HAlign) 1;
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance11;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Purchase Order #";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 0;
    ultraGridColumn4.Width = 115;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 53;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 77;
    ((AppearanceBase) appearance12).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance12).TextHAlign = (HAlign) 3;
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance12;
    ultraGridColumn7.DataType = typeof (Decimal);
    ultraGridColumn7.Format = "c";
    ((AppearanceBase) appearance13).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance13).TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Pay This Amount";
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Nullable = (Nullable) 1;
    ultraGridColumn7.Width = 158;
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
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance15).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance19).BackColor = Color.Transparent;
    ((AppearanceBase) appearance19).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance20).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridOpenPODetails).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridOpenPODetails).Dock = DockStyle.Fill;
    ((UltraControlBase) this.gridOpenPODetails).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridOpenPODetails).Location = new Point(0, 224 /*0xE0*/);
    ((Control) this.gridOpenPODetails).Name = "gridOpenPODetails";
    ((Control) this.gridOpenPODetails).Size = new Size(714, 344);
    ((UltraControlBase) this.gridOpenPODetails).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridOpenPODetails).TabIndex = 44;
    this.gridOpenPODetails.UpdateMode = (UpdateMode) 2;
    this.gridOpenPODetails.AfterCellUpdate += new CellEventHandler(this.gridOpenPODetails_AfterCellUpdate);
    this.gridOpenPODetails.InitializeLayout += new InitializeLayoutEventHandler(this.gridOpenPODetails_InitializeLayout);
    this.gridOpenPODetails.BeforeCellUpdate += new BeforeCellUpdateEventHandler(this.gridOpenPODetails_BeforeCellUpdate);
    ((Control) this.gridOpenPODetails).KeyDown += new KeyEventHandler(this.gridOpenPODetails_KeyDown);
    ((Control) this.gridOpenPODetails).KeyUp += new KeyEventHandler(this.gridOpenPODetails_KeyUp);
    this.dsOpenPODetails1.DataSetName = "dsOpenPODetails";
    this.dsOpenPODetails1.Locale = new CultureInfo("en-US");
    this.panel3.Controls.Add((Control) this.ultraLabel2);
    this.panel3.Controls.Add((Control) this.comboBankAccounts);
    this.panel3.Controls.Add((Control) this.ultraLabel3);
    this.panel3.Controls.Add((Control) this.comboPaymentMethod);
    this.panel3.Controls.Add((Control) this.dateTimeCheckDate);
    this.panel3.Controls.Add((Control) this.ultraLabel5);
    this.panel3.Controls.Add((Control) this.textPostingComments);
    this.panel3.Controls.Add((Control) this.ultraLabel6);
    this.panel3.Dock = DockStyle.Top;
    this.panel3.Location = new Point(0, 80 /*0x50*/);
    this.panel3.Name = "panel3";
    this.panel3.Size = new Size(714, 144 /*0x90*/);
    this.panel3.TabIndex = 45;
    ((AppearanceBase) appearance22).BackColor = Color.White;
    ((AppearanceBase) appearance22).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance22).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance22).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance22).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance22;
    ((Control) this.ultraLabel2).AutoSize = true;
    ((Control) this.ultraLabel2).Font = new Font("Tahoma", 8f);
    ((Control) this.ultraLabel2).Location = new Point(8, 8);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(70, 15);
    ((Control) this.ultraLabel2).TabIndex = 46;
    ((Control) this.ultraLabel2).Text = "Bank Account";
    this.comboBankAccounts.BorderStyle = (UIElementBorderStyle) 4;
    this.comboBankAccounts.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboBankAccounts).DisplayMember = "";
    this.comboBankAccounts.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboBankAccounts).DropDownWidth = 250;
    ((Control) this.comboBankAccounts).Location = new Point(8, 24);
    this.comboBankAccounts.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboBankAccounts).Name = "comboBankAccounts";
    ((Control) this.comboBankAccounts).Size = new Size(272, 20);
    ((Control) this.comboBankAccounts).TabIndex = 47;
    ((UltraDropDownBase) this.comboBankAccounts).ValueMember = "";
    this.comboBankAccounts.RowSelected += new RowSelectedEventHandler(this.comboBankAccounts_RowSelected);
    ((AppearanceBase) appearance23).BackColor = Color.White;
    ((AppearanceBase) appearance23).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance23).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance23).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance23).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance23;
    ((Control) this.ultraLabel3).AutoSize = true;
    ((Control) this.ultraLabel3).Font = new Font("Tahoma", 8f);
    ((Control) this.ultraLabel3).Location = new Point(8, 48 /*0x30*/);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(86, 15);
    ((Control) this.ultraLabel3).TabIndex = 48 /*0x30*/;
    ((Control) this.ultraLabel3).Text = "Payment Method";
    this.comboPaymentMethod.BorderStyle = (UIElementBorderStyle) 4;
    this.comboPaymentMethod.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboPaymentMethod).DisplayMember = "";
    this.comboPaymentMethod.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboPaymentMethod).DropDownWidth = 250;
    ((Control) this.comboPaymentMethod).Location = new Point(8, 64 /*0x40*/);
    this.comboPaymentMethod.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboPaymentMethod).Name = "comboPaymentMethod";
    ((Control) this.comboPaymentMethod).Size = new Size(272, 20);
    ((Control) this.comboPaymentMethod).TabIndex = 49;
    ((UltraDropDownBase) this.comboPaymentMethod).ValueMember = "";
    ((AppearanceBase) appearance24).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeCheckDate.Appearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance25).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance25).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance25).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance25).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance25).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance25).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance25).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance25).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance25).ForegroundAlpha = (Alpha) 2;
    this.dateTimeCheckDate.ButtonAppearance = (AppearanceBase) appearance25;
    ((Control) this.dateTimeCheckDate).Location = new Point(8, 104);
    this.dateTimeCheckDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeCheckDate).Name = "dateTimeCheckDate";
    ((Control) this.dateTimeCheckDate).Size = new Size(104, 20);
    ((Control) this.dateTimeCheckDate).TabIndex = 51;
    ((AppearanceBase) appearance26).BackColor = Color.White;
    ((AppearanceBase) appearance26).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance26).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance26).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance26).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel5).Appearance = (AppearanceBase) appearance26;
    ((Control) this.ultraLabel5).AutoSize = true;
    ((Control) this.ultraLabel5).Font = new Font("Tahoma", 8f);
    ((Control) this.ultraLabel5).Location = new Point(8, 88);
    ((Control) this.ultraLabel5).Name = "ultraLabel5";
    ((Control) this.ultraLabel5).Size = new Size(59, 15);
    ((Control) this.ultraLabel5).TabIndex = 50;
    ((Control) this.ultraLabel5).Text = "Check Date";
    ((AppearanceBase) appearance27).BackColor = Color.White;
    ((AppearanceBase) appearance27).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance27).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPostingComments).Appearance = (AppearanceBase) appearance27;
    ((Control) this.textPostingComments).Location = new Point(328, 24);
    ((TextEditorControlBase) this.textPostingComments).MaxLength = 600;
    this.textPostingComments.MGAStyle = MGAStyles.Blue;
    this.textPostingComments.Multiline = true;
    ((Control) this.textPostingComments).Name = "textPostingComments";
    ((Control) this.textPostingComments).Size = new Size(376, 104);
    ((Control) this.textPostingComments).TabIndex = 53;
    ((AppearanceBase) appearance28).BackColor = Color.White;
    ((AppearanceBase) appearance28).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance28).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance28).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance28).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel6).Appearance = (AppearanceBase) appearance28;
    ((Control) this.ultraLabel6).AutoSize = true;
    ((Control) this.ultraLabel6).Font = new Font("Tahoma", 8f);
    ((Control) this.ultraLabel6).Location = new Point(328, 8);
    ((Control) this.ultraLabel6).Name = "ultraLabel6";
    ((Control) this.ultraLabel6).Size = new Size(94, 15);
    ((Control) this.ultraLabel6).TabIndex = 52;
    ((Control) this.ultraLabel6).Text = "Posting Comments";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(714, 608);
    this.ControlBox = false;
    this.Controls.Add((Control) this.gridOpenPODetails);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.panel3);
    this.Controls.Add((Control) this.Panel2);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formListOpenPODetails);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Multi Purchase Order Payment Utility";
    this.Panel2.ResumeLayout(false);
    this.Panel1.ResumeLayout(false);
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.gridOpenPODetails).EndInit();
    this.dsOpenPODetails1.EndInit();
    this.panel3.ResumeLayout(false);
    ((ISupportInitialize) this.comboBankAccounts).EndInit();
    ((ISupportInitialize) this.comboPaymentMethod).EndInit();
    ((ISupportInitialize) this.dateTimeCheckDate).EndInit();
    ((ISupportInitialize) this.textPostingComments).EndInit();
    this.ResumeLayout(false);
  }

  private void LoadOpenPODetails(int purchaseOrderNumber)
  {
    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetOpenPODetails", new SqlConnection(CurrentUser.Instance.ConnectionString))))
    {
      try
      {
        sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@poNum", (object) purchaseOrderNumber);
        sqlDataAdapter.Fill((DataTable) this.dsOpenPODetails1.DetailsTable);
      }
      finally
      {
        if (sqlDataAdapter.SelectCommand.Connection.State != ConnectionState.Closed)
          sqlDataAdapter.SelectCommand.Connection.Close();
        sqlDataAdapter.SelectCommand.Connection.Dispose();
        sqlDataAdapter.SelectCommand.Dispose();
      }
    }
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    this.CreateDetailsArray();
    if (this._detailObjects == null)
    {
      int num = (int) MessageBox.Show("You must specify at least one detail item to pay.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
      this.CreateOperatingTransaction();
  }

  public ArrayList Details
  {
    get
    {
      if (this._detailObjects == null)
        this._detailObjects = new ArrayList();
      return this._detailObjects;
    }
  }

  private void gridOpenPODetails_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridOpenPODetails).Rows)
      row.Cells["PAY"].Value = row.Cells["BALANCE"].Value;
  }

  private void gridOpenPODetails_KeyUp(object sender, KeyEventArgs e)
  {
    switch (e.KeyCode)
    {
      case Keys.Tab:
        ((UltraGridBase) this.gridOpenPODetails).ActiveRow.Update();
        this.gridOpenPODetails.ActiveCell = ((UltraGridBase) this.gridOpenPODetails).ActiveRow.Cells["PAY"];
        this.gridOpenPODetails.ActiveCell.Activate();
        this.gridOpenPODetails.PerformAction((UltraGridAction) 24);
        break;
      case Keys.Return:
        ((UltraGridBase) this.gridOpenPODetails).ActiveRow.Update();
        break;
    }
  }

  private void CreateDetailsArray()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridOpenPODetails).Rows)
    {
      if (!row.Cells["PAY"].Value.Equals((object) DBNull.Value) && !row.Cells["PAY"].Value.ToString().Equals(string.Empty))
      {
        if (this._detailObjects == null)
          this._detailObjects = new ArrayList();
        TransactionDetail transactionDetail = new TransactionDetail();
        if (row.Cells["PAY"].Value != DBNull.Value || !row.Cells["PAY"].Value.ToString().Equals(string.Empty))
          transactionDetail.Amount = Decimal.Parse(row.Cells["PAY"].Value.ToString());
        if (row.Cells["glacctid"].Value != DBNull.Value || !row.Cells["glacctid"].Value.ToString().Equals(string.Empty))
          transactionDetail.GLAccountId = int.Parse(row.Cells["glacctid"].Value.ToString());
        if (row.Cells["expenseCode"].Value != DBNull.Value || !row.Cells["expenseCode"].Value.ToString().Equals(string.Empty))
          transactionDetail.ExpenseCode = int.Parse(row.Cells["expenseCode"].Value.ToString());
        if (row.Cells["poNum"].Value != DBNull.Value || !row.Cells["poNum"].Value.ToString().Equals(string.Empty))
          transactionDetail.PurchaseOrderNumber = int.Parse(row.Cells["poNum"].Value.ToString());
        this._detailObjects.Add((object) transactionDetail);
      }
    }
  }

  private void GetBankAccounts()
  {
    ((UltraGridBase) this.comboBankAccounts).DataSource = (object) AccountingCache.Instance.GlCompany(this._glCompanyId).GetBankAccounts();
    ((UltraDropDownBase) this.comboBankAccounts).DisplayMember = "BANKNAME";
    ((UltraDropDownBase) this.comboBankAccounts).ValueMember = "GLACCTID";
    this.comboBankAccounts.Value = (object) AccountingCache.Instance.GlCompany(this._glCompanyId).OperatingBankAccount.GLAccountID;
  }

  private void comboBankAccounts_RowSelected(object sender, RowSelectedEventArgs e)
  {
    ((UltraGridBase) this.comboPaymentMethod).DataSource = (object) Utility.GetEntityPaymentMethods(this._payeeGuid, this._glCompanyId, int.Parse(this.comboBankAccounts.Value.ToString()));
    ((UltraDropDownBase) this.comboPaymentMethod).DisplayMember = "MethodName";
    ((UltraDropDownBase) this.comboPaymentMethod).ValueMember = "PayMethodID";
    this.comboPaymentMethod.Value = (object) "C";
  }

  private void CreateOperatingTransaction()
  {
    if (this._detailObjects == null)
      return;
    OperatingTransaction operatingTransaction = new OperatingTransaction(CurrentUser.Instance.UserGUID, true, false, false);
    try
    {
      operatingTransaction.PostDate = this.dateTimeCheckDate.DateTime;
      operatingTransaction.TransactionComments = ((Control) this.textPostingComments).Text;
      operatingTransaction.CreateCheck = true;
      for (int index = 0; index < this._detailObjects.Count; ++index)
      {
        TransactionDetail detailObject = (TransactionDetail) this._detailObjects[index];
        detailObject.PayeeGuid = this._payeeGuid;
        detailObject.GLAccount = new GLAccount(detailObject.GLAccountId);
        TransactionDetail transactionDetail = detailObject.Copy();
        transactionDetail.GLAccountId = int.Parse(this.comboBankAccounts.Value.ToString());
        transactionDetail.GLAccount = new GLAccount(transactionDetail.GLAccountId);
        if (detailObject.Amount > 0M)
        {
          operatingTransaction.Debits.Add(detailObject);
          operatingTransaction.Credits.Add(transactionDetail);
        }
        else
        {
          operatingTransaction.Credits.Add(detailObject);
          operatingTransaction.Debits.Add(transactionDetail);
        }
      }
      if (operatingTransaction.Debits.Count == 0 && operatingTransaction.Credits.Count == 0 || operatingTransaction.Debits.TransactionsTotal() == 0M && operatingTransaction.Credits.TransactionsTotal() == 0M)
      {
        int num = (int) MessageBox.Show("You have must specify at least one detail item to pay.", "Required Selection Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        CheckInformation checkInformation = Utility.GetCheckInformation(this._payeeGuid, int.Parse(this.comboBankAccounts.Value.ToString()), this.comboPaymentMethod.Value.ToString(), this.dateTimeCheckDate.DateTime, true);
        if (checkInformation == null)
          return;
        operatingTransaction.CheckData = checkInformation;
        if (!operatingTransaction.IsBalanced())
          return;
        operatingTransaction.Save();
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
    }
    finally
    {
      operatingTransaction.Dispose();
    }
  }

  private void gridOpenPODetails_BeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
  {
    this._originalCellValue = e.Cell.OriginalValue;
  }

  private void gridOpenPODetails_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (e.Cell.Row.Cells["PAY"].Value == null || e.Cell.Row.Cells["PAY"].Value.Equals((object) DBNull.Value) || e.Cell.Row.Cells["PAY"].Value.ToString().Equals(string.Empty))
      return;
    if (!Utility.IsDecimalValue(e.Cell.Row.Cells["PAY"].Value))
    {
      int num = (int) MessageBox.Show("The payment amount must be numeric.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.gridOpenPODetails.PerformAction((UltraGridAction) 21);
    }
    else
    {
      Decimal num1 = Decimal.Parse(e.Cell.Row.Cells["PAY"].Value.ToString());
      if (num1 == 0M || !(num1 > Decimal.Parse(e.Cell.Row.Cells["balance"].Value.ToString())))
        return;
      int num2 = (int) MessageBox.Show("The payment amount can not exceed the balance due.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void gridOpenPODetails_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyValue == 38)
    {
      this.gridOpenPODetails.PerformAction((UltraGridAction) 19, false, false);
      e.Handled = true;
      this.gridOpenPODetails.PerformAction((UltraGridAction) 24, false, false);
    }
    else if (e.KeyValue == 40)
    {
      this.gridOpenPODetails.PerformAction((UltraGridAction) 20, false, false);
      e.Handled = true;
      this.gridOpenPODetails.PerformAction((UltraGridAction) 24, false, false);
    }
    else if (e.KeyValue == 39)
    {
      this.gridOpenPODetails.PerformAction((UltraGridAction) 42, false, false);
      e.Handled = true;
      this.gridOpenPODetails.PerformAction((UltraGridAction) 24, false, false);
    }
    else
    {
      if (e.KeyValue != 37)
        return;
      this.gridOpenPODetails.PerformAction((UltraGridAction) 43, false, false);
      e.Handled = true;
      this.gridOpenPODetails.PerformAction((UltraGridAction) 24, false, false);
    }
  }
}

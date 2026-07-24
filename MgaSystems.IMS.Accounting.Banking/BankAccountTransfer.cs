// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.BankAccountTransfer
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.AccountingDatasets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public sealed class BankAccountTransfer : UserControl
{
  private const string balanceSQL = "select isnull(sum(amount), 0) from tblfin_journalpostings jp  inner join tblfin_journal j on j.transactnum = jp.transactnum  and (j.voidedby is null and j.voiderfor is null)  where glacctid = {0}";
  private IContainer components;

  public BankAccountTransfer()
  {
    this.Load += new EventHandler(this.BankAccountTransfer_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("BottomPanel")]
  internal virtual Panel BottomPanel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridTransfers")]
  internal virtual UltraGrid gridTransfers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraCombo cmbPaymentMethod
  {
    get => this._cmbPaymentMethod;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.cmbPaymentMethod_InitializeLayout);
      UltraCombo cmbPaymentMethod1 = this._cmbPaymentMethod;
      if (cmbPaymentMethod1 != null)
        cmbPaymentMethod1.InitializeLayout -= layoutEventHandler;
      this._cmbPaymentMethod = value;
      UltraCombo cmbPaymentMethod2 = this._cmbPaymentMethod;
      if (cmbPaymentMethod2 == null)
        return;
      cmbPaymentMethod2.InitializeLayout += layoutEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtComments")]
  internal virtual TextBox txtComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual TextBox txtAmount
  {
    get => this._txtAmount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.txtAmount_Validating);
      TextBox txtAmount1 = this._txtAmount;
      if (txtAmount1 != null)
        txtAmount1.Validating -= cancelEventHandler;
      this._txtAmount = value;
      TextBox txtAmount2 = this._txtAmount;
      if (txtAmount2 == null)
        return;
      txtAmount2.Validating += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("cmbFromBank")]
  internal virtual UltraCombo cmbFromBank { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraCombo cmbToBank
  {
    get => this._cmbToBank;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.cmbToBank_RowSelected);
      UltraCombo cmbToBank1 = this._cmbToBank;
      if (cmbToBank1 != null)
        cmbToBank1.RowSelected -= selectedEventHandler;
      this._cmbToBank = value;
      UltraCombo cmbToBank2 = this._cmbToBank;
      if (cmbToBank2 == null)
        return;
      cmbToBank2.RowSelected += selectedEventHandler;
    }
  }

  internal virtual Button btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      Button btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        btnCancel1.Click -= eventHandler;
      this._btnCancel = value;
      Button btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      btnCancel2.Click += eventHandler;
    }
  }

  internal virtual Button btnTransfer
  {
    get => this._btnTransfer;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnTransfer_Click);
      Button btnTransfer1 = this._btnTransfer;
      if (btnTransfer1 != null)
        btnTransfer1.Click -= eventHandler;
      this._btnTransfer = value;
      Button btnTransfer2 = this._btnTransfer;
      if (btnTransfer2 == null)
        return;
      btnTransfer2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ImageList1")]
  internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsGetBankAccountsDropDown1")]
  internal virtual dsGetBankAccountsDropDown DsGetBankAccountsDropDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("FormDataConnection")]
  internal virtual SqlConnection FormDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetBankAccountDropDown")]
  internal virtual SqlDataAdapter daGetBankAccountDropDown { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsBankTransfers1")]
  internal virtual dsBankTransfers DsBankTransfers1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetBankTransfers")]
  internal virtual SqlDataAdapter daGetBankTransfers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand2")]
  internal virtual SqlCommand SqlSelectCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    UltraGridBand ultraGridBand1 = new UltraGridBand("", -1);
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("Table", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("bank");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("glacctid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("journalentrytype");
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("Table", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("bank");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("glacctid");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("journalentrytype");
    Appearance appearance6 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (BankAccountTransfer));
    Appearance appearance7 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("Transfers", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("transactNum");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("transferDate");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("transferDescription");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("amount");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("reconciled");
    Appearance appearance14 = new Appearance();
    this.BottomPanel = new Panel();
    this.cmbPaymentMethod = new UltraCombo();
    this.Label5 = new Label();
    this.txtComments = new TextBox();
    this.Label4 = new Label();
    this.txtAmount = new TextBox();
    this.cmbFromBank = new UltraCombo();
    this.DsGetBankAccountsDropDown1 = new dsGetBankAccountsDropDown();
    this.cmbToBank = new UltraCombo();
    this.btnCancel = new Button();
    this.ImageList1 = new ImageList(this.components);
    this.btnTransfer = new Button();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.gridTransfers = new UltraGrid();
    this.FormDataConnection = new SqlConnection();
    this.SqlSelectCommand1 = new SqlCommand();
    this.daGetBankAccountDropDown = new SqlDataAdapter();
    this.DsBankTransfers1 = new dsBankTransfers();
    this.daGetBankTransfers = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.BottomPanel.SuspendLayout();
    ((ISupportInitialize) this.cmbPaymentMethod).BeginInit();
    ((ISupportInitialize) this.cmbFromBank).BeginInit();
    this.DsGetBankAccountsDropDown1.BeginInit();
    ((ISupportInitialize) this.cmbToBank).BeginInit();
    ((ISupportInitialize) this.gridTransfers).BeginInit();
    this.DsBankTransfers1.BeginInit();
    this.SuspendLayout();
    this.BottomPanel.BackColor = Color.WhiteSmoke;
    this.BottomPanel.Controls.Add((Control) this.cmbPaymentMethod);
    this.BottomPanel.Controls.Add((Control) this.Label5);
    this.BottomPanel.Controls.Add((Control) this.txtComments);
    this.BottomPanel.Controls.Add((Control) this.Label4);
    this.BottomPanel.Controls.Add((Control) this.txtAmount);
    this.BottomPanel.Controls.Add((Control) this.cmbFromBank);
    this.BottomPanel.Controls.Add((Control) this.cmbToBank);
    this.BottomPanel.Controls.Add((Control) this.btnCancel);
    this.BottomPanel.Controls.Add((Control) this.btnTransfer);
    this.BottomPanel.Controls.Add((Control) this.Label3);
    this.BottomPanel.Controls.Add((Control) this.Label2);
    this.BottomPanel.Controls.Add((Control) this.Label1);
    this.BottomPanel.Dock = DockStyle.Bottom;
    this.BottomPanel.Location = new Point(0, 344);
    this.BottomPanel.Name = "BottomPanel";
    this.BottomPanel.Size = new Size(752, 112 /*0x70*/);
    this.BottomPanel.TabIndex = 0;
    this.cmbPaymentMethod.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.AddButtonCaption = "PaymentMethods";
    ultraGridBand1.GroupHeadersVisible = false;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    appearance1.BorderAlpha = (Alpha) 3;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance1;
    appearance2.BackColor = SystemColors.Control;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.White;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.White;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance4;
    ((UltraDropDownBase) this.cmbPaymentMethod).DisplayMember = "MethodName";
    ((Control) this.cmbPaymentMethod).Location = new Point(120, 80 /*0x50*/);
    ((Control) this.cmbPaymentMethod).Name = "cmbPaymentMethod";
    ((Control) this.cmbPaymentMethod).Size = new Size(178, 21);
    ((Control) this.cmbPaymentMethod).TabIndex = 23;
    ((UltraDropDownBase) this.cmbPaymentMethod).ValueMember = "PayMethodID";
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(8, 80 /*0x50*/);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(78, 16 /*0x10*/);
    this.Label5.TabIndex = 22;
    this.Label5.Text = "Transfer Type:";
    this.txtComments.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtComments.BorderStyle = BorderStyle.FixedSingle;
    this.txtComments.Location = new Point(456, 8);
    this.txtComments.MaxLength = 2000;
    this.txtComments.Multiline = true;
    this.txtComments.Name = "txtComments";
    this.txtComments.Size = new Size(288, 64 /*0x40*/);
    this.txtComments.TabIndex = 18;
    this.txtComments.Text = "";
    this.Label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(392, 8);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(62, 16 /*0x10*/);
    this.Label4.TabIndex = 21;
    this.Label4.Text = "Comments:";
    this.txtAmount.BorderStyle = BorderStyle.FixedSingle;
    this.txtAmount.Location = new Point(120, 56);
    this.txtAmount.MaxLength = 25;
    this.txtAmount.Name = "txtAmount";
    this.txtAmount.Size = new Size(136, 20);
    this.txtAmount.TabIndex = 17;
    this.txtAmount.Text = "";
    this.txtAmount.TextAlign = HorizontalAlignment.Right;
    this.cmbFromBank.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cmbFromBank).DataMember = "Table";
    ((UltraGridBase) this.cmbFromBank).DataSource = (object) this.DsGetBankAccountsDropDown1;
    ((UltraGridBase) this.cmbFromBank).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "";
    ultraGridColumn1.Width = 229;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 74;
    ultraGridBand2.Columns.Add((object) ultraGridColumn1);
    ultraGridBand2.Columns.Add((object) ultraGridColumn2);
    ultraGridBand2.Columns.Add((object) ultraGridColumn3);
    ultraGridBand2.GroupHeadersVisible = false;
    ((UltraGridBase) this.cmbFromBank).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.cmbFromBank).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cmbFromBank).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbFromBank).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbFromBank).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbFromBank).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbFromBank).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbFromBank).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbFromBank).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    appearance5.BorderAlpha = (Alpha) 3;
    ((UltraGridBase) this.cmbFromBank).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.cmbFromBank).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cmbFromBank).DisplayMember = "bank";
    this.cmbFromBank.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbFromBank).Location = new Point(120, 8);
    ((Control) this.cmbFromBank).Name = "cmbFromBank";
    ((Control) this.cmbFromBank).Size = new Size(248, 21);
    ((Control) this.cmbFromBank).TabIndex = 12;
    ((UltraDropDownBase) this.cmbFromBank).ValueMember = "glacctid";
    this.DsGetBankAccountsDropDown1.DataSetName = "dsGetBankAccountsDropDown";
    this.DsGetBankAccountsDropDown1.Locale = new CultureInfo("en-US");
    this.cmbToBank.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cmbToBank).DataMember = "Table";
    ((UltraGridBase) this.cmbToBank).DataSource = (object) this.DsGetBankAccountsDropDown1;
    ((UltraGridBase) this.cmbToBank).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "";
    ultraGridColumn4.Width = 229;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 74;
    ultraGridBand3.Columns.Add((object) ultraGridColumn4);
    ultraGridBand3.Columns.Add((object) ultraGridColumn5);
    ultraGridBand3.Columns.Add((object) ultraGridColumn6);
    ultraGridBand3.GroupHeadersVisible = false;
    ((UltraGridBase) this.cmbToBank).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.cmbToBank).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cmbToBank).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbToBank).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbToBank).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbToBank).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbToBank).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbToBank).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbToBank).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbToBank).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance6.BorderAlpha = (Alpha) 3;
    ((UltraGridBase) this.cmbToBank).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.cmbToBank).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cmbToBank).DisplayMember = "";
    this.cmbToBank.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbToBank).Location = new Point(120, 32 /*0x20*/);
    ((Control) this.cmbToBank).Name = "cmbToBank";
    ((Control) this.cmbToBank).Size = new Size(248, 21);
    ((Control) this.cmbToBank).TabIndex = 14;
    ((UltraDropDownBase) this.cmbToBank).ValueMember = "bank";
    this.btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
    this.btnCancel.ImageIndex = 1;
    this.btnCancel.ImageList = this.ImageList1;
    this.btnCancel.Location = new Point(672, 80 /*0x50*/);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.TabIndex = 20;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.TextAlign = ContentAlignment.MiddleRight;
    this.ImageList1.ImageSize = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    this.btnTransfer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnTransfer.FlatStyle = FlatStyle.Flat;
    this.btnTransfer.ImageAlign = ContentAlignment.MiddleLeft;
    this.btnTransfer.ImageIndex = 0;
    this.btnTransfer.ImageList = this.ImageList1;
    this.btnTransfer.Location = new Point(576, 80 /*0x50*/);
    this.btnTransfer.Name = "btnTransfer";
    this.btnTransfer.Size = new Size(88, 23);
    this.btnTransfer.TabIndex = 19;
    this.btnTransfer.Text = "Transfer..";
    this.btnTransfer.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(8, 32 /*0x20*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(95, 16 /*0x10*/);
    this.Label3.TabIndex = 16 /*0x10*/;
    this.Label3.Text = "Transfer To Bank:";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(8, 56);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(46, 16 /*0x10*/);
    this.Label2.TabIndex = 15;
    this.Label2.Text = "Amount:";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(108, 16 /*0x10*/);
    this.Label1.TabIndex = 13;
    this.Label1.Text = "Transfer From Bank:";
    ((UltraGridBase) this.gridTransfers).DataMember = "Transfers";
    ((UltraGridBase) this.gridTransfers).DataSource = (object) this.DsBankTransfers1;
    appearance7.BackColor = Color.White;
    appearance7.FontData.Name = "Tahoma";
    appearance7.FontData.SizeInPoints = 8f;
    ((UltraGridBase) this.gridTransfers).DisplayLayout.Appearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridTransfers).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand4.ColHeadersVisible = false;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 134;
    appearance8.TextHAlign = (HAlign) 1;
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance8;
    appearance9.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Date";
    ultraGridColumn8.Width = 80 /*0x50*/;
    appearance10.TextHAlign = (HAlign) 1;
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance10;
    appearance11.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance11;
    ultraGridColumn9.Width = 554;
    appearance12.TextHAlign = (HAlign) 3;
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance12;
    ultraGridColumn10.Format = "c";
    appearance13.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance13;
    ultraGridColumn10.Width = 118;
    appearance14.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance14;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 195;
    ultraGridBand4.Columns.Add((object) ultraGridColumn7);
    ultraGridBand4.Columns.Add((object) ultraGridColumn8);
    ultraGridBand4.Columns.Add((object) ultraGridColumn9);
    ultraGridBand4.Columns.Add((object) ultraGridColumn10);
    ultraGridBand4.Columns.Add((object) ultraGridColumn11);
    ultraGridBand4.GroupHeadersVisible = false;
    ((UltraGridBase) this.gridTransfers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.gridTransfers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridTransfers).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridTransfers).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridTransfers).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridTransfers).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridTransfers).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridTransfers).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridTransfers).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridTransfers).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridTransfers).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridTransfers).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((UltraGridBase) this.gridTransfers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((Control) this.gridTransfers).Dock = DockStyle.Fill;
    ((Control) this.gridTransfers).Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridTransfers).Location = new Point(0, 0);
    ((Control) this.gridTransfers).Name = "gridTransfers";
    ((Control) this.gridTransfers).Size = new Size(752, 344);
    ((UltraControlBase) this.gridTransfers).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridTransfers).TabIndex = 1;
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.SqlSelectCommand1.CommandText = "spFin_GetBankAccountsForDropDown";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.daGetBankAccountDropDown.SelectCommand = this.SqlSelectCommand1;
    this.DsBankTransfers1.DataSetName = "dsBankTransfers";
    this.DsBankTransfers1.Locale = new CultureInfo("en-US");
    this.daGetBankTransfers.SelectCommand = this.SqlSelectCommand2;
    this.daGetBankTransfers.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankTransfers", new DataColumnMapping[5]
      {
        new DataColumnMapping("transactNum", "transactNum"),
        new DataColumnMapping("transferDate", "transferDate"),
        new DataColumnMapping("TransferDescription", "TransferDescription"),
        new DataColumnMapping("amount", "amount"),
        new DataColumnMapping("Reconciled", "Reconciled")
      })
    });
    this.SqlSelectCommand2.CommandText = "[spFin_GetBankTransfers]";
    this.SqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand2.Connection = this.FormDataConnection;
    this.SqlSelectCommand2.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.Controls.Add((Control) this.gridTransfers);
    this.Controls.Add((Control) this.BottomPanel);
    this.Name = nameof (BankAccountTransfer);
    this.Size = new Size(752, 456);
    this.BottomPanel.ResumeLayout(false);
    ((ISupportInitialize) this.cmbPaymentMethod).EndInit();
    ((ISupportInitialize) this.cmbFromBank).EndInit();
    this.DsGetBankAccountsDropDown1.EndInit();
    ((ISupportInitialize) this.cmbToBank).EndInit();
    ((ISupportInitialize) this.gridTransfers).EndInit();
    this.DsBankTransfers1.EndInit();
    this.ResumeLayout(false);
  }

  private void BankAccountTransfer_Load(object sender, EventArgs e)
  {
    this.Dock = DockStyle.Fill;
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.daGetBankAccountDropDown.Fill((DataSet) this.DsGetBankAccountsDropDown1);
    this.GetBankTransfers();
  }

  private void GetBankTransfers()
  {
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.DsBankTransfers1.Clear();
    this.daGetBankTransfers.Fill((DataTable) this.DsBankTransfers1.Transfers);
  }

  private bool ValidateForm()
  {
    bool flag;
    if (((UltraDropDownBase) this.cmbFromBank).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a bank to transfer from!", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.cmbFromBank.Focus();
      flag = false;
    }
    else if (((UltraDropDownBase) this.cmbToBank).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a bank to transfer to!", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.cmbToBank.Focus();
      flag = false;
    }
    else if (Conversions.ToInteger(((UltraDropDownBase) this.cmbFromBank).SelectedRow.Cells["glacctid"].Value) == Conversions.ToInteger(((UltraDropDownBase) this.cmbToBank).SelectedRow.Cells["glacctid"].Value))
    {
      int num = (int) MessageBox.Show("You can not transfer funds between the same bank account!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAmount.Text.Trim(), "", false) == 0)
    {
      int num = (int) MessageBox.Show("You must enter an amount!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.txtAmount.Focus();
      flag = false;
    }
    else if (!Versioned.IsNumeric((object) this.txtAmount.Text))
    {
      int num = (int) MessageBox.Show("Amount must be numeric!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.txtAmount.Focus();
      flag = false;
    }
    else if (Decimal.Compare(Conversions.ToDecimal(this.txtAmount.Text), 0M) < 0)
    {
      int num = (int) MessageBox.Show("Amount must be greater than zero!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.txtAmount.Focus();
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void btnTransfer_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm() || !this.VerifyBalance())
      return;
    this.TransferFunds();
    this.ClearScreen();
    this.GetBankTransfers();
  }

  private bool VerifyBalance()
  {
    Decimal num1 = Conversions.ToDecimal(this.txtAmount.Text);
    Decimal balance = this.GetBalance();
    bool flag;
    if (Decimal.Compare(num1, balance) > 0)
    {
      int num2 = (int) MessageBox.Show($"The following transfer will exceed the balance of the transferring bank account.\r\n\r\nAccount Balance: {Strings.Format((object) balance, "Currency")}\r\nTransfer Amount: {Strings.Format((object) num1, "Currency")}\r\n\r\nYou can not process this transfer at this time!", "Amount Exceeds Balance!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private Decimal GetBalance()
  {
    return Conversions.ToDecimal(Database.Instance.QueryText.PerformScalarQuery($"select isnull(sum(amount), 0) from tblfin_journalpostings jp  inner join tblfin_journal j on j.transactnum = jp.transactnum  and (j.voidedby is null and j.voiderfor is null)  where glacctid = {Conversions.ToInteger(((UltraDropDownBase) this.cmbFromBank).SelectedRow.Cells["glacctid"].Value)}"));
  }

  private void TransferFunds()
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_BankTransfer", new SqlConnection(CurrentUser.Instance.ConnectionString));
    SqlCommand sqlCommand2 = sqlCommand1;
    sqlCommand2.CommandType = CommandType.StoredProcedure;
    sqlCommand2.Parameters.AddWithValue("@journalentrytype", (object) ((UltraDropDownBase) this.cmbFromBank).SelectedRow.Cells["journalentrytype"].Value.ToString());
    sqlCommand2.Parameters.AddWithValue("@comments", (object) this.txtComments.Text);
    sqlCommand2.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
    sqlCommand2.Parameters.AddWithValue("@fromglacctid", (object) Conversions.ToInteger(((UltraDropDownBase) this.cmbFromBank).SelectedRow.Cells["glacctid"].Value));
    sqlCommand2.Parameters.AddWithValue("@toglacctid", (object) Conversions.ToInteger(((UltraDropDownBase) this.cmbToBank).SelectedRow.Cells["glacctid"].Value));
    sqlCommand2.Parameters.AddWithValue("@amount", (object) Conversions.ToDecimal(this.txtAmount.Text));
    sqlCommand2.Parameters.AddWithValue("@paymethodid", (object) ((UltraDropDownBase) this.cmbPaymentMethod).SelectedRow.Cells[0].Value.ToString());
    try
    {
      sqlCommand1.Connection.Open();
      sqlCommand1.Transaction = sqlCommand1.Connection.BeginTransaction();
      sqlCommand1.ExecuteNonQuery();
      sqlCommand1.Transaction.Commit();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      sqlCommand1.Transaction.Rollback();
      throw;
    }
    finally
    {
      sqlCommand1.Connection.Close();
      sqlCommand1.Connection.Dispose();
      sqlCommand1.Dispose();
    }
  }

  private dsPaymentMethods GetPayeePaymentMethods(string PayeeGUID, int GLCOMPANYID)
  {
    dsPaymentMethods payeePaymentMethods = new dsPaymentMethods();
    SqlCommand selectCommand = new SqlCommand($"SELECT DISTINCT TBLFIN_PAYMENTMETHODS.PAYMETHODID, TBLFIN_PAYMENTMETHODS.METHODNAME FROM TBLFIN_PAYMENTMETHODS INNER JOIN TBLFIN_PAYEEINSTRUCTIONS ON TBLFIN_PAYEEINSTRUCTIONS.PAYMETHODID = TBLFIN_PAYMENTMETHODS.PAYMETHODID WHERE TBLFIN_PAYEEINSTRUCTIONS.PAYEEGUID IN (SELECT * FROM dbo.GetLinkedEntities('{PayeeGUID}')) AND dbo.GetGLCompanyID(FROMBANKGLACCTID)  = {GLCOMPANYID} ORDER BY TBLFIN_PAYMENTMETHODS.METHODNAME", new SqlConnection(CurrentUser.Instance.ConnectionString));
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    try
    {
      sqlDataAdapter.Fill((DataTable) payeePaymentMethods.PaymentMethods);
      if (payeePaymentMethods.PaymentMethods.Count == 0)
      {
        dsPaymentMethods.PaymentMethodsRow row = payeePaymentMethods.PaymentMethods.NewPaymentMethodsRow();
        row.PayMethodID = "C";
        row.MethodName = "Check";
        payeePaymentMethods.PaymentMethods.AddPaymentMethodsRow(row);
      }
      return payeePaymentMethods;
    }
    finally
    {
      selectCommand.Connection.Dispose();
      selectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
  }

  private void cmbToBank_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (e.Row == null)
      return;
    DataRow dataRow = Database.Instance.QueryText.PerformRowQuery($"select officeguid, officeid from tblclientoffices where officeid = dbo.getglcompanyid({Conversions.ToInteger(e.Row.Cells["glacctid"].Value)})");
    if (dataRow == null)
      return;
    ((UltraGridBase) this.cmbPaymentMethod).DataSource = (object) this.GetPayeePaymentMethods(dataRow[0].ToString(), Conversions.ToInteger(dataRow[1]));
  }

  private void cmbPaymentMethod_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    if (((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.Bands.Count == 0)
      return;
    UltraGridLayout displayLayout = ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout;
    displayLayout.AutoFitStyle = (AutoFitStyle) 1;
    displayLayout.Bands[0].Columns[0].Hidden = true;
    displayLayout.Bands[0].ColHeadersVisible = false;
  }

  private void txtAmount_Validating(object sender, CancelEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAmount.Text.Trim(), "", false) == 0 || !Versioned.IsNumeric((object) this.txtAmount.Text))
      return;
    this.txtAmount.Text = Strings.Format((object) this.txtAmount.Text, "Currency");
  }

  private void ClearScreen()
  {
    try
    {
      foreach (Control control in this.BottomPanel.Controls)
      {
        switch (control)
        {
          case TextBox _:
            ((TextBox) control).Text = "";
            continue;
          case ComboBox _:
          case UltraCombo _:
            control.ResetText();
            continue;
          default:
            continue;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.ClearScreen();
}

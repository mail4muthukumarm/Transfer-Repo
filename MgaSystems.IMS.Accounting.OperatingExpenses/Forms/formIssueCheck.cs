// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formIssueCheck
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Accounting.SharedForms;
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

public class formIssueCheck : AccountingNoteDocumentSupport
{
  private Label label1;
  private EllipsePanel ellipsePanel1;
  private Label labelPayeeName;
  private MGATextBox textPayee;
  private MGAButton buttonIssuePayment;
  private MGAButton buttonCancel;
  private Label label2;
  private MGASimpleComboBox comboBankAccount;
  private Label label3;
  private MGADateTimePicker dateCheckDate;
  private Label label4;
  private UltraGrid gridDetails;
  private MGATextBox textCheckAmount;
  private dsOpenExpenseDetails dsOpenExpenseDetails1;
  private System.ComponentModel.Container components;
  private int glCompanyId;
  private int poNum;
  private Guid payeeGuid;
  private string payeeName;
  private DateTime checkDate;
  private GLAccount bankAccount;

  private formIssueCheck() => this.InitializeComponent();

  public formIssueCheck(int glCompanyId, int poNum, Guid payeeGuid, string payeeName)
  {
    this.InitializeComponent();
    this.glCompanyId = glCompanyId;
    this.poNum = poNum;
    this.payeeGuid = payeeGuid;
    this.payeeName = payeeName;
    this.DisplayExpenseInformation();
    this.LoadExpenseDetails();
    this.LoadBankAccounts();
    this.dateCheckDate.NullText = DateTime.Now.ToShortDateString();
  }

  public int GlCompanyId => this.glCompanyId;

  public int PoNum => this.poNum;

  public Guid PayeeGuid => this.payeeGuid;

  public string PayeeName => this.payeeName;

  public DateTime CheckDate => this.checkDate;

  public GLAccount BankAccount => this.bankAccount;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (formIssueCheck));
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("OpenExpenseDetail", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ExpenseCode");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("GlAcctId");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ExpenseName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Balance");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("PayAmt");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CostCenterId");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    this.label1 = new Label();
    this.ellipsePanel1 = new EllipsePanel();
    this.gridDetails = new UltraGrid();
    this.dsOpenExpenseDetails1 = new dsOpenExpenseDetails();
    this.textCheckAmount = new MGATextBox();
    this.label4 = new Label();
    this.dateCheckDate = new MGADateTimePicker();
    this.label3 = new Label();
    this.comboBankAccount = new MGASimpleComboBox();
    this.label2 = new Label();
    this.buttonCancel = new MGAButton();
    this.buttonIssuePayment = new MGAButton();
    this.textPayee = new MGATextBox();
    this.labelPayeeName = new Label();
    this.ellipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.gridDetails).BeginInit();
    this.dsOpenExpenseDetails1.BeginInit();
    ((ISupportInitialize) this.textCheckAmount).BeginInit();
    ((ISupportInitialize) this.dateCheckDate).BeginInit();
    ((ISupportInitialize) this.comboBankAccount).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonIssuePayment).BeginInit();
    ((ISupportInitialize) this.textPayee).BeginInit();
    this.SuspendLayout();
    this.label1.Font = new Font("Tahoma", 12f, FontStyle.Bold | FontStyle.Underline);
    this.label1.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label1.Image = (Image) resourceManager.GetObject("label1.Image");
    this.label1.ImageAlign = ContentAlignment.MiddleRight;
    this.label1.Location = new Point(8, 8);
    this.label1.Name = "label1";
    this.label1.Size = new Size(584, 32 /*0x20*/);
    this.label1.TabIndex = 0;
    this.label1.Text = "ISSUE PAYMENT";
    this.label1.TextAlign = ContentAlignment.MiddleLeft;
    this.ellipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel1.Controls.Add((Control) this.gridDetails);
    this.ellipsePanel1.Controls.Add((Control) this.textCheckAmount);
    this.ellipsePanel1.Controls.Add((Control) this.label4);
    this.ellipsePanel1.Controls.Add((Control) this.dateCheckDate);
    this.ellipsePanel1.Controls.Add((Control) this.label3);
    this.ellipsePanel1.Controls.Add((Control) this.comboBankAccount);
    this.ellipsePanel1.Controls.Add((Control) this.label2);
    this.ellipsePanel1.Controls.Add((Control) this.buttonCancel);
    this.ellipsePanel1.Controls.Add((Control) this.buttonIssuePayment);
    this.ellipsePanel1.Controls.Add((Control) this.textPayee);
    this.ellipsePanel1.Controls.Add((Control) this.labelPayeeName);
    this.ellipsePanel1.Controls.Add((Control) this.label1);
    this.ellipsePanel1.CornerOffset = 1;
    this.ellipsePanel1.Location = new Point(8, 8);
    this.ellipsePanel1.Name = "ellipsePanel1";
    this.ellipsePanel1.Size = new Size(600, 272);
    this.ellipsePanel1.TabIndex = 1;
    ((UltraGridBase) this.gridDetails).DataMember = "OpenExpenseDetail";
    ((UltraGridBase) this.gridDetails).DataSource = (object) this.dsOpenExpenseDetails1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridDetails).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridDetails).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Expense Code";
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 126;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 112 /*0x70*/;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Expense Name";
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 283;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlign = (HAlign) 3;
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn4.Format = "c";
    ((AppearanceBase) appearance3).TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 168;
    ((AppearanceBase) appearance4).TextHAlign = (HAlign) 3;
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn5.Format = "c";
    ((AppearanceBase) appearance5).TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Pay Amount";
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 131;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 70;
    ultraGridBand.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.gridDetails).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridDetails).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((UltraGridBase) this.gridDetails).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridDetails).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridDetails).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridDetails).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance7).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridDetails).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance8).TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridDetails).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridDetails).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridDetails).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridDetails).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridDetails).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridDetails).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BackColor = Color.Transparent;
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((UltraGridBase) this.gridDetails).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridDetails).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance12).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance12).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridDetails).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraControlBase) this.gridDetails).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridDetails).Font = new Font("Tahoma", 8f);
    ((Control) this.gridDetails).Location = new Point(8, 104);
    ((Control) this.gridDetails).Name = "gridDetails";
    ((Control) this.gridDetails).Size = new Size(584, 120);
    ((UltraControlBase) this.gridDetails).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridDetails).TabIndex = 10;
    this.gridDetails.UpdateMode = (UpdateMode) 2;
    this.gridDetails.AfterRowUpdate += new RowEventHandler(this.gridDetails_AfterRowUpdate);
    this.gridDetails.BeforeCellUpdate += new BeforeCellUpdateEventHandler(this.gridDetails_BeforeCellUpdate);
    ((Control) this.gridDetails).KeyDown += new KeyEventHandler(this.gridDetails_KeyDown);
    this.dsOpenExpenseDetails1.DataSetName = "dsOpenExpenseDetails";
    this.dsOpenExpenseDetails1.Locale = new CultureInfo("en-US");
    ((AppearanceBase) appearance14).BackColor = Color.White;
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((AppearanceBase) appearance14).TextHAlign = (HAlign) 3;
    ((TextEditorControlBase) this.textCheckAmount).Appearance = (AppearanceBase) appearance14;
    ((Control) this.textCheckAmount).Location = new Point(464, 72);
    this.textCheckAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.textCheckAmount).Name = "textCheckAmount";
    ((EditorButtonControlBase) this.textCheckAmount).ReadOnly = true;
    ((Control) this.textCheckAmount).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.textCheckAmount).TabIndex = 9;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(392, 72);
    this.label4.Name = "label4";
    this.label4.Size = new Size(60, 16 /*0x10*/);
    this.label4.TabIndex = 8;
    this.label4.Text = "Check Amt:";
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateCheckDate.Appearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance16).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance16).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance16).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance16).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance16).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance16).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance16).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance16).ForegroundAlpha = (Alpha) 2;
    this.dateCheckDate.ButtonAppearance = (AppearanceBase) appearance16;
    ((Control) this.dateCheckDate).Location = new Point(464, 48 /*0x30*/);
    this.dateCheckDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateCheckDate).Name = "dateCheckDate";
    this.dateCheckDate.Nullable = false;
    ((Control) this.dateCheckDate).Size = new Size(88, 20);
    ((Control) this.dateCheckDate).TabIndex = 7;
    this.dateCheckDate.ValueChanged += new EventHandler(this.dateCheckDate_ValueChanged);
    this.label3.AutoSize = true;
    this.label3.Location = new Point(392, 48 /*0x30*/);
    this.label3.Name = "label3";
    this.label3.Size = new Size(63 /*0x3F*/, 16 /*0x10*/);
    this.label3.TabIndex = 6;
    this.label3.Text = "Check Date:";
    this.comboBankAccount.BorderStyle = (UIElementBorderStyle) 4;
    this.comboBankAccount.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboBankAccount).DisplayMember = "";
    this.comboBankAccount.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboBankAccount).Location = new Point(88, 72);
    this.comboBankAccount.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboBankAccount).Name = "comboBankAccount";
    ((Control) this.comboBankAccount).Size = new Size(288, 20);
    ((Control) this.comboBankAccount).TabIndex = 5;
    ((UltraDropDownBase) this.comboBankAccount).ValueMember = "";
    this.comboBankAccount.ValueChanged += new EventHandler(this.comboBankAccount_ValueChanged);
    this.comboBankAccount.RowSelected += new RowSelectedEventHandler(this.comboBankAccount_RowSelected);
    this.label2.AutoSize = true;
    this.label2.Location = new Point(8, 72);
    this.label2.Name = "label2";
    this.label2.Size = new Size(74, 16 /*0x10*/);
    this.label2.TabIndex = 4;
    this.label2.Text = "Bank Account:";
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance17).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance17).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance17).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance17).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance17).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance17;
    ((Control) this.buttonCancel).Location = new Point(480, 240 /*0xF0*/);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(112 /*0x70*/, 24);
    ((Control) this.buttonCancel).TabIndex = 3;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance18).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance18).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance18).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance18).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance18).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonIssuePayment).Appearance = (AppearanceBase) appearance18;
    ((Control) this.buttonIssuePayment).Location = new Point(360, 240 /*0xF0*/);
    ((Control) this.buttonIssuePayment).Name = "buttonIssuePayment";
    ((Control) this.buttonIssuePayment).Size = new Size(112 /*0x70*/, 24);
    ((Control) this.buttonIssuePayment).TabIndex = 2;
    ((Control) this.buttonIssuePayment).Text = "Issue Check";
    ((Control) this.buttonIssuePayment).Click += new EventHandler(this.buttonIssuePayment_Click);
    ((AppearanceBase) appearance19).BackColor = Color.White;
    ((AppearanceBase) appearance19).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance19).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPayee).Appearance = (AppearanceBase) appearance19;
    ((Control) this.textPayee).Location = new Point(88, 48 /*0x30*/);
    this.textPayee.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPayee).Name = "textPayee";
    ((EditorButtonControlBase) this.textPayee).ReadOnly = true;
    ((Control) this.textPayee).Size = new Size(288, 20);
    ((Control) this.textPayee).TabIndex = 1;
    this.labelPayeeName.AutoSize = true;
    this.labelPayeeName.Location = new Point(8, 48 /*0x30*/);
    this.labelPayeeName.Name = "labelPayeeName";
    this.labelPayeeName.Size = new Size(37, 16 /*0x10*/);
    this.labelPayeeName.TabIndex = 0;
    this.labelPayeeName.Text = "Payee:";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(616, 288);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ellipsePanel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formIssueCheck);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Issue Payment";
    this.ellipsePanel1.ResumeLayout(false);
    ((ISupportInitialize) this.gridDetails).EndInit();
    this.dsOpenExpenseDetails1.EndInit();
    ((ISupportInitialize) this.textCheckAmount).EndInit();
    ((ISupportInitialize) this.dateCheckDate).EndInit();
    ((ISupportInitialize) this.comboBankAccount).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonIssuePayment).EndInit();
    ((ISupportInitialize) this.textPayee).EndInit();
    this.ResumeLayout(false);
  }

  private void DisplayExpenseInformation()
  {
    ((Control) this.textPayee).Text = this.PayeeName;
    this.checkDate = DateTime.Now;
    this.dateCheckDate.DateTime = DateTime.Now;
  }

  private void LoadBankAccounts()
  {
    ((UltraGridBase) this.comboBankAccount).DataSource = (object) AccountingCache.Instance.GlCompany(this.GlCompanyId).GetBankAccounts();
    ((UltraDropDownBase) this.comboBankAccount).DisplayMember = "BANKNAME";
    ((UltraDropDownBase) this.comboBankAccount).ValueMember = "GLACCTID";
    this.comboBankAccount.Value = (object) AccountingCache.Instance.GlCompany(this.GlCompanyId).OperatingBankAccount.GLAccountID;
  }

  private void LoadExpenseDetails()
  {
    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spfin_GetOpenExpenseDetails", new SqlConnection(CurrentUser.Instance.ConnectionString))))
    {
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@poNum", (object) this.PoNum);
      sqlDataAdapter.Fill((DataTable) this.dsOpenExpenseDetails1.OpenExpenseDetail);
    }
    this.BuildGridSummary();
    this.CalculateBalance();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void dateCheckDate_ValueChanged(object sender, EventArgs e)
  {
    if (this.dateCheckDate.DateTime.Equals((object) DBNull.Value) || this.dateCheckDate.Value == null)
      this.dateCheckDate.DateTime = DateTime.Now;
    this.checkDate = this.dateCheckDate.DateTime;
  }

  private void comboBankAccount_ValueChanged(object sender, EventArgs e)
  {
  }

  private void BuildGridSummary()
  {
    foreach (UltraGridBand band in ((UltraGridBase) this.gridDetails).DisplayLayout.Bands)
    {
      band.Summaries.Add("BalanceSum", (SummaryType) 1, band.Columns["Balance"], (SummaryPosition) 3);
      band.Summaries.Add("PayAmountSum", (SummaryType) 1, band.Columns["PayAmt"], (SummaryPosition) 3);
      foreach (SummarySettings summary in (IEnumerable) band.Summaries)
      {
        summary.DisplayFormat = "{0:c}";
        summary.Appearance.TextHAlign = (HAlign) 3;
      }
    }
  }

  private void CalculateBalance()
  {
    Decimal num = 0M;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridDetails).Rows)
    {
      if (row.Cells["PayAmt"].Value.ToString() != string.Empty)
        num += Decimal.Parse(row.Cells["PayAmt"].Value.ToString());
    }
    ((Control) this.textCheckAmount).Text = num.ToString("c");
  }

  private void gridDetails_AfterRowUpdate(object sender, RowEventArgs e) => this.CalculateBalance();

  private void gridDetails_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return || this.gridDetails.ActiveCell == null)
      return;
    this.gridDetails.ActiveCell.Row.Update();
  }

  private void gridDetails_BeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
  {
    if (!MGASystems.IMS.Accounting.OperatingExpenses.Utilities.IsDecimal(e.NewValue.ToString()) || !(Decimal.Parse(e.NewValue.ToString(), NumberStyles.Any) > Decimal.Parse(e.Cell.Row.Cells["balance"].Value.ToString(), NumberStyles.Any)))
      return;
    ((CancelEventArgs) e).Cancel = true;
    int num = (int) MessageBox.Show("Pay amount can not exceed the balance.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
  }

  private void IssuePayment()
  {
    if (!this.ValidateForm())
      return;
    OperatingTransaction operatingTransaction = new OperatingTransaction(CurrentUser.Instance.UserGUID, true, false);
    operatingTransaction.PostDate = this.CheckDate;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridDetails).Rows)
    {
      if (!(row.Cells["payAmt"].Value.ToString() == string.Empty))
      {
        Decimal num = Decimal.Parse(row.Cells["payAmt"].Value.ToString());
        int glAccountId = int.Parse(row.Cells["glacctid"].Value.ToString());
        int expenseCode = int.Parse(row.Cells["expenseCode"].Value.ToString());
        int CostCenterId = int.Parse(row.Cells["CostCenterId"].Value.ToString());
        CostCenterAllocationCollection allocations = new CostCenterAllocationCollection();
        allocations.Add(new CostCenterAllocation(CostCenterId, num), num);
        if (num > 0M)
        {
          operatingTransaction.Debits.Add(new TransactionDetail(0, 0, this.PoNum, expenseCode, 0, 0, glAccountId, Guid.Empty, this.PayeeGuid, Math.Abs(num), this.PayeeGuid, allocations));
          operatingTransaction.Credits.Add(new TransactionDetail(0, 0, this.PoNum, expenseCode, 0, 0, this.BankAccount.GLAccountID, Guid.Empty, this.PayeeGuid, -Math.Abs(num), this.PayeeGuid, allocations));
        }
        else if (num < 0M)
        {
          operatingTransaction.Credits.Add(new TransactionDetail(0, 0, this.PoNum, expenseCode, 0, 0, glAccountId, Guid.Empty, this.PayeeGuid, -Math.Abs(num), this.PayeeGuid, allocations));
          operatingTransaction.Debits.Add(new TransactionDetail(0, 0, this.PoNum, expenseCode, 0, 0, this.BankAccount.GLAccountID, Guid.Empty, this.PayeeGuid, Math.Abs(num), this.PayeeGuid, allocations));
        }
      }
    }
    using (formPayeeAddressSelection addressSelection = new formPayeeAddressSelection(this.PayeeGuid))
    {
      if (addressSelection.ShowDialog() != DialogResult.OK)
        return;
      operatingTransaction.CheckData = new CheckInformation(Utility.PaymentMethod.Check, this.PayeeGuid, this.CheckDate, this.BankAccount, addressSelection.PayeeName, addressSelection.Address1, addressSelection.Address2, addressSelection.City, addressSelection.State, addressSelection.ZipCode, addressSelection.ZipPlus, addressSelection.PayeeName);
    }
    if (Math.Abs(operatingTransaction.Debits.TransactionsTotal()) == Math.Abs(operatingTransaction.Credits.TransactionsTotal()))
      operatingTransaction.Save();
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void buttonIssuePayment_Click(object sender, EventArgs e) => this.IssuePayment();

  private void comboBankAccount_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) sender).SelectedRow == null)
      return;
    if (int.Parse(((UltraCombo) sender).Value.ToString()) == -1)
      this.bankAccount = (GLAccount) null;
    else
      this.bankAccount = new GLAccount(int.Parse(((UltraCombo) sender).Value.ToString()));
  }

  private bool ValidateForm()
  {
    if (this.BankAccount == null)
    {
      int num = (int) MessageBox.Show("You must select a bank account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.dateCheckDate.DateTime.Equals((object) DBNull.Value))
    {
      int num = (int) MessageBox.Show("You must specify a check date to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!(Decimal.Parse(((Control) this.textCheckAmount).Text, NumberStyles.Currency) == 0M))
      return true;
    int num1 = (int) MessageBox.Show("The check amount must be greater than zero.", "Invalid Check Amount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }
}

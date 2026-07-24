// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmTransferFunds
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
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

public sealed class frmTransferFunds : Form
{
  private const string balanceSQL = "select isnull(sum(amount), 0) from tblfin_journalpostings jp  inner join tblfin_journal j on j.transactnum = jp.transactnum  and (j.voidedby is null and j.voiderfor is null)  where glacctid = {0}";
  private IContainer components;

  public frmTransferFunds()
  {
    this.Load += new EventHandler(this.frmTransferFunds_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("cmbFromBank")]
  internal virtual UltraCombo cmbFromBank { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtComments")]
  internal virtual TextBox txtComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetBankAccountDropDown")]
  internal virtual SqlDataAdapter daGetBankAccountDropDown { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("FormDataConnection")]
  internal virtual SqlConnection FormDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsGetBankAccountsDropDown1")]
  internal virtual dsGetBankAccountsDropDown DsGetBankAccountsDropDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    UltraGridBand ultraGridBand1 = new UltraGridBand("Table", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("bank");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("glacctid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("journalentrytype");
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("Table", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("bank");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("glacctid");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("journalentrytype");
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("", -1);
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.btnTransfer = new Button();
    this.btnCancel = new Button();
    this.cmbToBank = new UltraCombo();
    this.DsGetBankAccountsDropDown1 = new dsGetBankAccountsDropDown();
    this.cmbFromBank = new UltraCombo();
    this.txtAmount = new TextBox();
    this.Label4 = new Label();
    this.txtComments = new TextBox();
    this.daGetBankAccountDropDown = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.Label5 = new Label();
    this.cmbPaymentMethod = new UltraCombo();
    ((ISupportInitialize) this.cmbToBank).BeginInit();
    this.DsGetBankAccountsDropDown1.BeginInit();
    ((ISupportInitialize) this.cmbFromBank).BeginInit();
    ((ISupportInitialize) this.cmbPaymentMethod).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(108, 16 /*0x10*/);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Transfer From Bank:";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(8, 56);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(46, 16 /*0x10*/);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Amount:";
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(8, 32 /*0x20*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(95, 16 /*0x10*/);
    this.Label3.TabIndex = 2;
    this.Label3.Text = "Transfer To Bank:";
    this.btnTransfer.Location = new Point(232, 272);
    this.btnTransfer.Name = "btnTransfer";
    this.btnTransfer.TabIndex = 4;
    this.btnTransfer.Text = "Transfer..";
    this.btnCancel.Location = new Point(328, 272);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.TabIndex = 5;
    this.btnCancel.Text = "Cancel";
    this.cmbToBank.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cmbToBank).DataMember = "Table";
    ((UltraGridBase) this.cmbToBank).DataSource = (object) this.DsGetBankAccountsDropDown1;
    ((UltraGridBase) this.cmbToBank).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "";
    ultraGridColumn1.Width = 269;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 74;
    ultraGridBand1.Columns.Add((object) ultraGridColumn1);
    ultraGridBand1.Columns.Add((object) ultraGridColumn2);
    ultraGridBand1.Columns.Add((object) ultraGridColumn3);
    ((UltraGridBase) this.cmbToBank).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    appearance1.BorderAlpha = (Alpha) 3;
    ((UltraGridBase) this.cmbToBank).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.cmbToBank).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cmbToBank).DisplayMember = "";
    this.cmbToBank.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbToBank).Location = new Point(120, 32 /*0x20*/);
    ((Control) this.cmbToBank).Name = "cmbToBank";
    ((Control) this.cmbToBank).Size = new Size(288, 21);
    ((Control) this.cmbToBank).TabIndex = 1;
    ((UltraDropDownBase) this.cmbToBank).ValueMember = "bank";
    this.DsGetBankAccountsDropDown1.DataSetName = "dsGetBankAccountsDropDown";
    this.DsGetBankAccountsDropDown1.Locale = new CultureInfo("en-US");
    this.cmbFromBank.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cmbFromBank).DataMember = "Table";
    ((UltraGridBase) this.cmbFromBank).DataSource = (object) this.DsGetBankAccountsDropDown1;
    ((UltraGridBase) this.cmbFromBank).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "";
    ultraGridColumn4.Width = 269;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 74;
    ultraGridBand2.Columns.Add((object) ultraGridColumn4);
    ultraGridBand2.Columns.Add((object) ultraGridColumn5);
    ultraGridBand2.Columns.Add((object) ultraGridColumn6);
    ((UltraGridBase) this.cmbFromBank).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    appearance2.BorderAlpha = (Alpha) 3;
    ((UltraGridBase) this.cmbFromBank).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.cmbFromBank).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cmbFromBank).DisplayMember = "bank";
    this.cmbFromBank.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbFromBank).Location = new Point(120, 8);
    ((Control) this.cmbFromBank).Name = "cmbFromBank";
    ((Control) this.cmbFromBank).Size = new Size(288, 21);
    ((Control) this.cmbFromBank).TabIndex = 0;
    ((UltraDropDownBase) this.cmbFromBank).ValueMember = "glacctid";
    this.txtAmount.Location = new Point(120, 56);
    this.txtAmount.MaxLength = 25;
    this.txtAmount.Name = "txtAmount";
    this.txtAmount.Size = new Size(136, 20);
    this.txtAmount.TabIndex = 2;
    this.txtAmount.Text = "";
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(8, 80 /*0x50*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(62, 16 /*0x10*/);
    this.Label4.TabIndex = 8;
    this.Label4.Text = "Comments:";
    this.txtComments.Location = new Point(120, 80 /*0x50*/);
    this.txtComments.MaxLength = 2000;
    this.txtComments.Multiline = true;
    this.txtComments.Name = "txtComments";
    this.txtComments.Size = new Size(288, 146);
    this.txtComments.TabIndex = 3;
    this.txtComments.Text = "";
    this.daGetBankAccountDropDown.SelectCommand = this.SqlSelectCommand1;
    this.SqlSelectCommand1.CommandText = "spFin_GetBankAccountsForDropDown";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(8, 232);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(78, 16 /*0x10*/);
    this.Label5.TabIndex = 9;
    this.Label5.Text = "Transfer Type:";
    this.cmbPaymentMethod.CharacterCasing = CharacterCasing.Normal;
    ultraGridBand3.AddButtonCaption = "PaymentMethods";
    ultraGridBand3.GroupHeadersVisible = false;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    appearance3.BorderAlpha = (Alpha) 3;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    appearance4.BackColor = SystemColors.Control;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.White;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.White;
    ((UltraGridBase) this.cmbPaymentMethod).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraDropDownBase) this.cmbPaymentMethod).DisplayMember = "MethodName";
    ((Control) this.cmbPaymentMethod).Location = new Point(120, 232);
    ((Control) this.cmbPaymentMethod).Name = "cmbPaymentMethod";
    ((Control) this.cmbPaymentMethod).Size = new Size(178, 21);
    ((Control) this.cmbPaymentMethod).TabIndex = 11;
    ((UltraDropDownBase) this.cmbPaymentMethod).ValueMember = "PayMethodID";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(416, 304);
    this.ControlBox = false;
    this.Controls.Add((Control) this.cmbPaymentMethod);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.txtComments);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.txtAmount);
    this.Controls.Add((Control) this.cmbFromBank);
    this.Controls.Add((Control) this.cmbToBank);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnTransfer);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (frmTransferFunds);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Bank To Bank Transfers";
    ((ISupportInitialize) this.cmbToBank).EndInit();
    this.DsGetBankAccountsDropDown1.EndInit();
    ((ISupportInitialize) this.cmbFromBank).EndInit();
    ((ISupportInitialize) this.cmbPaymentMethod).EndInit();
    this.ResumeLayout(false);
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void frmTransferFunds_Load(object sender, EventArgs e)
  {
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.daGetBankAccountDropDown.Fill((DataSet) this.DsGetBankAccountsDropDown1);
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
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Dispose();
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
      sqlDataAdapter.Dispose();
      selectCommand.Dispose();
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
      foreach (Control control in this.Controls)
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
}

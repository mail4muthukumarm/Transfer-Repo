// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.formGLAccountDialog
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

public class formGLAccountDialog : Form
{
  private formGLAccountDialog.AccountType _accountType;
  private readonly GLTreeNode _node;
  private readonly bool _isEditMode;
  private int _glCompanyId;
  private int _glAccountId;
  private int _glControlAccountId;
  private bool _isClassLevelAccount;
  private int _glClassId;
  private readonly bool _isBankAccount;
  private MGAGroupBox groupBankInformation;
  private MGAGroupBox groupGLInformation;
  private MGATextBox textFullName;
  private MGATextBox textShortName;
  private Label label1;
  private Label label2;
  private Label label3;
  private NumericUpDown numericGlAccountNumber;
  private MGATextBox textBankName;
  private MGASimpleComboBox comboAccountType;
  private MGATextBox textAccountNumber;
  private MGATextBox textABARoutingNumber;
  private Label label4;
  private Label label5;
  private Label label6;
  private Label label7;
  private CheckBox checkNextCheckNumber;
  private MGATextBox textDepositSlipSuffix;
  private MGATextBox textBankContactName;
  private MGATextBox textBankContactEmail;
  private MGATextBox textBankContactFax;
  private MGATextBox textABAFractional;
  private Label label8;
  private Label label9;
  private Label label10;
  private Label label11;
  private Label label12;
  private Label label13;
  private Label label14;
  private Label label15;
  private EllipsePanel ellipsePanel1;
  private MGAButton buttonSave;
  private MGAButton buttonCancel;
  private ImageList imageList1;
  private NumericUpDown numericNextCheckNumber;
  private dsBankAccountTypes dsBankAccountTypes1;
  private MGATextBox textBankContactPhone;
  private AddressResolver_MULTI addressBankAddress;
  private Label label16;
  private dsGLAccountTypes dsGLAccountTypes1;
  private MGASimpleComboBox comboFinancialTypes;
  private Label labelSystemDefined;
  private MGATextBox textDepositRoutingNumber;
  private Label label17;
  private Label label27;
  private CheckBox checkACHSettings;
  private Label label25;
  private MGATextBox textBankACHOrginatingDFI;
  private Label label23;
  private Label label24;
  private MGATextBox textBankACHImmedOrgName;
  private MGATextBox textBankACHImmedOrgin;
  private Label label18;
  private Label label19;
  private Label label20;
  private Label label21;
  private Label label22;
  private MGATextBox textBankACHImmedDestName;
  private MGATextBox textBankACHImmedDest;
  private MGATextBox textBankACHCompanyName;
  private MGATextBox textBankACHCompanyID;
  private IContainer components;

  private formGLAccountDialog()
  {
    this.InitializeComponent();
    this.numericNextCheckNumber.DataBindings.Add("Enabled", (object) this.checkNextCheckNumber, "Checked");
  }

  public formGLAccountDialog(
    formGLAccountDialog.AccountType accountType,
    ref GLTreeNode nodeObject,
    bool isEdit)
  {
    this.InitializeComponent();
    this.LoadFinancialTypes();
    this._isBankAccount = nodeObject.IsBankAccount;
    if (this.IsBankAccount)
      this.GetBankAccountTypes();
    this._isEditMode = isEdit;
    this._node = nodeObject;
    this.SetFormText(accountType);
    this.numericGlAccountNumber.Value = (Decimal) this.GetNextAccountNumber();
    this.SetAddressResolverConnectionProperties();
    if (this._isEditMode)
      this.DisplayGLAccountForEdit();
    this.numericNextCheckNumber.DataBindings.Add("Enabled", (object) this.checkNextCheckNumber, "Checked");
  }

  private void LoadFinancialTypes()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand selectCommand = new SqlCommand("dbo.spFin_GetFinancialAcctTypes", connection))
      {
        selectCommand.CommandType = CommandType.StoredProcedure;
        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
          sqlDataAdapter.Fill((DataTable) this.dsGLAccountTypes1.TypesList);
      }
    }
  }

  private void SetFormText(formGLAccountDialog.AccountType acctType)
  {
    this._accountType = acctType;
    if (!this._isEditMode)
      this.Text = acctType == formGLAccountDialog.AccountType.ControlAccount ? "GL Control Account" : "GL Account";
    else
      this.Text = acctType == formGLAccountDialog.AccountType.ControlAccount ? "New GL Control Account" : "New GL Account";
    this.Icon = Icon.FromHandle(new Bitmap(this.imageList1.Images[acctType != 0 ? 1 : 0]).GetHicon());
    ((Control) this.groupBankInformation).Enabled = this._isBankAccount;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
      this.components?.Dispose();
    base.Dispose(disposing);
  }

  public int GlCompanyId => this._glCompanyId;

  public int GlAccountId => this._glAccountId;

  public int GlControlAccountId => this._glControlAccountId;

  public bool IsClassLevelAccount => this._isClassLevelAccount;

  public int GlClassId => this._glClassId;

  public bool IsBankAccount => this._isBankAccount;

  private void buttonCancel_Click(object sender, EventArgs e) => this.Close();

  private int GetNextAccountNumber()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("", connection))
      {
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.CommandText = this._node.GlAccount != null ? $"SELECT dbo.GetNextAccountNumber({this._node.GlAccount.GLAccountID})" : $"SELECT dbo.GetNextAccountNumber_Class({this._node.GLAccountClass.ClassId})";
        sqlCommand.Connection.Open();
        return int.Parse(sqlCommand.ExecuteScalar().ToString());
      }
    }
  }

  private void SaveNewGLAccount()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("dbo.spFin_InsertNewGLAccount", connection))
      {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@fullName", (object) ((Control) this.textFullName).Text);
        sqlCommand.Parameters.AddWithValue("@shortName", (object) ((Control) this.textShortName).Text);
        sqlCommand.Parameters.AddWithValue("@acctNum", (object) this.numericGlAccountNumber.Value);
        sqlCommand.Parameters.AddWithValue("@financialType", (object) int.Parse(this.comboFinancialTypes.Value.ToString()));
        if (this._node.GlAccount != null)
        {
          sqlCommand.Parameters.AddWithValue("@rollUpTo", (object) (this._node.GlAccount.IsControlAccount ? this._node.GlAccount.GLAccountID : this._node.GlAccount.RollUpTo));
          sqlCommand.Parameters.AddWithValue("@glCompanyId", (object) this._node.GlAccount.GLCompanyId);
        }
        else
        {
          sqlCommand.Parameters.AddWithValue("@glCompanyClassId", (object) this._node.GLAccountClass.ClassId);
          sqlCommand.Parameters.AddWithValue("@glCompanyId", (object) this._node.GLAccountClass.GLCompanyId);
        }
        try
        {
          sqlCommand.Connection.Open();
          sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
          sqlCommand.ExecuteNonQuery();
          sqlCommand.Transaction.Commit();
          CurrentUser.Instance.LogAction("Created new GL account. " + ((Control) this.textFullName).Text, "Accounting Logs");
        }
        catch (SqlException ex)
        {
          sqlCommand.Transaction.Rollback();
          throw;
        }
      }
    }
  }

  private void SaveNewGLBankAccount()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("dbo.spFin_InsertNewGLBankAccount", connection))
      {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@fullName", (object) ((Control) this.textFullName).Text);
        sqlCommand.Parameters.AddWithValue("@shortName", (object) ((Control) this.textShortName).Text);
        sqlCommand.Parameters.AddWithValue("@acctNum", (object) this.numericGlAccountNumber.Value);
        sqlCommand.Parameters.AddWithValue("@financialType", (object) int.Parse(this.comboFinancialTypes.Value.ToString()));
        if (this._node.GlAccount != null && this._node.GlAccount.RollUpTo != 0)
        {
          sqlCommand.Parameters.AddWithValue("@rollUpTo", (object) (this._node.GlAccount.IsControlAccount ? this._node.GlAccount.GLAccountID : this._node.GlAccount.RollUpTo));
          sqlCommand.Parameters.AddWithValue("@glCompanyId", (object) this._node.GlAccount.GLCompanyId);
        }
        else if (this._node.GlAccount == null)
        {
          sqlCommand.Parameters.AddWithValue("@glCompanyClassId", (object) this._node.GLAccountClass.ClassId);
          sqlCommand.Parameters.AddWithValue("@glCompanyId", (object) this._node.GLAccountClass.GLCompanyId);
        }
        else
        {
          sqlCommand.Parameters.AddWithValue("@rollUpTo", (object) this._node.GlAccount.GLAccountID);
          sqlCommand.Parameters.AddWithValue("@glCompanyId", (object) this._node.GlAccount.GLCompanyId);
        }
        sqlCommand.Parameters.AddWithValue("@bankAcctTypeId", (object) this.comboAccountType.Value.ToString());
        sqlCommand.Parameters.AddWithValue("@bankAcctNum", (object) ((Control) this.textAccountNumber).Text);
        sqlCommand.Parameters.AddWithValue("@DepositRouting", (object) ((Control) this.textDepositRoutingNumber).Text);
        sqlCommand.Parameters.AddWithValue("@abaRouting", (object) ((Control) this.textABARoutingNumber).Text);
        sqlCommand.Parameters.AddWithValue("@abaFractional", (object) ((Control) this.textABAFractional).Text);
        sqlCommand.Parameters.AddWithValue("@nextCheckNumber", (object) this.numericNextCheckNumber.Value);
        sqlCommand.Parameters.AddWithValue("@bankName", (object) ((Control) this.textBankName).Text);
        sqlCommand.Parameters.AddWithValue("@addr1", (object) this.addressBankAddress.Address1);
        sqlCommand.Parameters.AddWithValue("@addr2", (object) this.addressBankAddress.Address2);
        sqlCommand.Parameters.AddWithValue("@city", (object) this.addressBankAddress.City);
        sqlCommand.Parameters.AddWithValue("@state", (object) this.addressBankAddress.State);
        sqlCommand.Parameters.AddWithValue("@zip", (object) this.addressBankAddress.ZipCode);
        sqlCommand.Parameters.AddWithValue("@zipext", (object) this.addressBankAddress.ZipCodeExtension);
        sqlCommand.Parameters.AddWithValue("@contact", (object) ((Control) this.textBankContactName).Text);
        sqlCommand.Parameters.AddWithValue("@fax", (object) ((Control) this.textBankContactFax).Text);
        sqlCommand.Parameters.AddWithValue("@phone", (object) ((Control) this.textBankContactPhone).Text);
        sqlCommand.Parameters.AddWithValue("@email", (object) ((Control) this.textBankContactEmail).Text);
        sqlCommand.Parameters.AddWithValue("@userGuid", (object) CurrentUser.Instance.UserGUID);
        sqlCommand.Parameters.AddWithValue("@depositSlipSuffix", (object) ((Control) this.textDepositSlipSuffix).Text);
        sqlCommand.Parameters.AddWithValue("@ISOCountryCode", (object) this.addressBankAddress.ISOCountryCode);
        try
        {
          sqlCommand.Connection.Open();
          sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
          this._glAccountId = int.Parse(sqlCommand.ExecuteScalar().ToString());
          sqlCommand.Transaction.Commit();
          CurrentUser.Instance.LogAction("Created new GL bank account. " + ((Control) this.textFullName).Text, "Accounting Logs");
        }
        catch (SqlException ex)
        {
          sqlCommand.Transaction.Rollback();
          throw;
        }
      }
    }
  }

  private void SaveNewGLControlAccount()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("dbo.spFin_InsertNewGLAccount", connection))
      {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@fullName", (object) ((Control) this.textFullName).Text);
        sqlCommand.Parameters.AddWithValue("@shortName", (object) ((Control) this.textShortName).Text);
        sqlCommand.Parameters.AddWithValue("@acctNum", (object) this.numericGlAccountNumber.Value);
        sqlCommand.Parameters.AddWithValue("@controlAcct", (object) 1);
        sqlCommand.Parameters.AddWithValue("@financialType", (object) int.Parse(this.comboFinancialTypes.Value.ToString()));
        if (this._node.GlAccount != null && this._node.GlAccount.RollUpTo != 0)
        {
          sqlCommand.Parameters.AddWithValue("@rollUpTo", (object) (this._node.GlAccount.IsControlAccount ? this._node.GlAccount.GLAccountID : this._node.GlAccount.RollUpTo));
          sqlCommand.Parameters.AddWithValue("@glCompanyId", (object) this._node.GlAccount.GLCompanyId);
        }
        else if (this._node.GlAccount == null)
        {
          sqlCommand.Parameters.AddWithValue("@glCompanyClassId", (object) this._node.GLAccountClass.ClassId);
          sqlCommand.Parameters.AddWithValue("@glCompanyId", (object) this._node.GLAccountClass.GLCompanyId);
        }
        else
        {
          sqlCommand.Parameters.AddWithValue("@rollUpTo", (object) this._node.GlAccount.GLAccountID);
          sqlCommand.Parameters.AddWithValue("@glCompanyId", (object) this._node.GlAccount.GLCompanyId);
        }
        try
        {
          sqlCommand.Connection.Open();
          sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
          sqlCommand.ExecuteNonQuery();
          sqlCommand.Transaction.Commit();
          CurrentUser.Instance.LogAction("Created new GL control account. " + ((Control) this.textFullName).Text, "Accounting Logs");
        }
        catch (SqlException ex)
        {
          sqlCommand.Transaction.Rollback();
          throw;
        }
      }
    }
  }

  private void UpdateGLAccount()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("dbo.spFin_UpdateGLAccount", connection))
      {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@glAcctId", (object) this._node.GlAccount.GLAccountID);
        sqlCommand.Parameters.AddWithValue("@fullName", (object) ((Control) this.textFullName).Text);
        sqlCommand.Parameters.AddWithValue("@shortName", (object) ((Control) this.textShortName).Text);
        sqlCommand.Parameters.AddWithValue("@acctNum", (object) this.numericGlAccountNumber.Value);
        sqlCommand.Parameters.AddWithValue("@financialType", (object) int.Parse(this.comboFinancialTypes.Value.ToString()));
        try
        {
          sqlCommand.Connection.Open();
          sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
          sqlCommand.ExecuteNonQuery();
          sqlCommand.Transaction.Commit();
          CurrentUser.Instance.LogAction("Updated GL account. " + ((Control) this.textFullName).Text, "Accounting Logs");
        }
        catch (SqlException ex)
        {
          sqlCommand.Transaction.Rollback();
          throw;
        }
      }
    }
  }

  private void UpdateGLBankAccount()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("spFin_UpdateGLBankAccount", connection))
      {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@glAcctId", (object) this._node.GlAccount.GLAccountID);
        sqlCommand.Parameters.AddWithValue("@fullName", (object) ((Control) this.textFullName).Text);
        sqlCommand.Parameters.AddWithValue("@shortName", (object) ((Control) this.textShortName).Text);
        sqlCommand.Parameters.AddWithValue("@acctNum", (object) this.numericGlAccountNumber.Value);
        sqlCommand.Parameters.AddWithValue("@bankAcctTypeId", (object) this.comboAccountType.Value.ToString());
        sqlCommand.Parameters.AddWithValue("@bankAcctNum", (object) ((Control) this.textAccountNumber).Text);
        sqlCommand.Parameters.AddWithValue("@abaRouting", (object) ((Control) this.textABARoutingNumber).Text);
        sqlCommand.Parameters.AddWithValue("@DepositRouting", (object) ((Control) this.textDepositRoutingNumber).Text);
        sqlCommand.Parameters.AddWithValue("@abaFractional", (object) ((Control) this.textABAFractional).Text);
        if (this.checkNextCheckNumber.Checked)
          sqlCommand.Parameters.AddWithValue("@nextCheckNumber", (object) this.numericNextCheckNumber.Value);
        sqlCommand.Parameters.AddWithValue("@bankName", (object) ((Control) this.textBankName).Text);
        sqlCommand.Parameters.AddWithValue("@addr1", (object) this.addressBankAddress.Address1);
        sqlCommand.Parameters.AddWithValue("@addr2", (object) this.addressBankAddress.Address2);
        sqlCommand.Parameters.AddWithValue("@city", (object) this.addressBankAddress.City);
        sqlCommand.Parameters.AddWithValue("@state", (object) this.addressBankAddress.State);
        sqlCommand.Parameters.AddWithValue("@zip", (object) this.addressBankAddress.ZipCode);
        sqlCommand.Parameters.AddWithValue("@zipext", (object) this.addressBankAddress.ZipCodeExtension);
        sqlCommand.Parameters.AddWithValue("@contact", (object) ((Control) this.textBankContactName).Text);
        sqlCommand.Parameters.AddWithValue("@fax", (object) ((Control) this.textBankContactFax).Text);
        sqlCommand.Parameters.AddWithValue("@phone", (object) ((Control) this.textBankContactPhone).Text);
        sqlCommand.Parameters.AddWithValue("@email", (object) ((Control) this.textBankContactEmail).Text);
        sqlCommand.Parameters.AddWithValue("@userGuid", (object) CurrentUser.Instance.UserGUID);
        sqlCommand.Parameters.AddWithValue("@depositSlipSuffix", (object) ((Control) this.textDepositSlipSuffix).Text);
        sqlCommand.Parameters.AddWithValue("@ISOCountryCode", (object) this.addressBankAddress.ISOCountryCode);
        sqlCommand.Parameters.AddWithValue("@financialType", (object) int.Parse(this.comboFinancialTypes.Value.ToString()));
        try
        {
          sqlCommand.Connection.Open();
          sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
          sqlCommand.ExecuteNonQuery();
          sqlCommand.Transaction.Commit();
          CurrentUser.Instance.LogAction("Updated GL bank account. " + ((Control) this.textFullName).Text, "Accounting Logs");
        }
        catch (SqlException ex)
        {
          sqlCommand.Transaction.Rollback();
          throw;
        }
      }
    }
  }

  private bool ValidateNewGLAccount(bool newAccount)
  {
    if (((Control) this.textFullName).Text.Equals(string.Empty) || ((Control) this.textShortName).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must enter a GL Account full name and short name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this._node.GlAccount == null && this._node.GLAccountClass == null || this._node.GlAccount != null && this._node.GlAccount.RollUpTo == 0 && !this._node.IsControlNode && this._node.GLAccountClass == null)
    {
      int num = (int) MessageBox.Show("The GL account master account and the GL account class could not be determined.", "Required Objects Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (newAccount)
    {
      int accountNumber = int.Parse(this.numericGlAccountNumber.Value.ToString());
      int rollUpTo = this._node.GlAccount == null ? 0 : (this._node.GlAccount.IsControlAccount ? this._node.GlAccount.GLAccountID : this._node.GlAccount.RollUpTo);
      GLClass glAccountClass = this._node.GLAccountClass;
      int classId = glAccountClass != null ? glAccountClass.ClassId : 0;
      if (GLAccount.GlAccountExists(accountNumber, rollUpTo, classId))
      {
        int num = (int) MessageBox.Show("The system has determined that a GL account with the specified GL account number already exists. Please specify a different GL account number to save this account.", "GL Account Already Exists!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    if (((UltraDropDownBase) this.comboFinancialTypes).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a financial account type to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboAccountType).SelectedRow != null || !this._isBankAccount)
      return true;
    int num1 = (int) MessageBox.Show("You must select a account type to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private bool ValidateNewGLBankAccount(bool newAccount)
  {
    if (((Control) this.textFullName).Text.Equals(string.Empty) || ((Control) this.textShortName).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must enter a GL Account full name and short name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this._node.GlAccount == null && this._node.GLAccountClass == null || this._node.GlAccount != null && this._node.GlAccount.RollUpTo == 0 && this._node.GLAccountClass == null)
    {
      int num = (int) MessageBox.Show("The GL account master account and the GL account class could not be determined.", "Required Objects Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (newAccount)
    {
      int accountNumber = int.Parse(this.numericGlAccountNumber.Value.ToString());
      int rollUpTo = this._node.GlAccount == null ? 0 : (this._node.GlAccount.IsControlAccount ? this._node.GlAccount.GLAccountID : this._node.GlAccount.RollUpTo);
      GLClass glAccountClass = this._node.GLAccountClass;
      int classId = glAccountClass != null ? glAccountClass.ClassId : 0;
      if (GLAccount.GlAccountExists(accountNumber, rollUpTo, classId))
      {
        int num = (int) MessageBox.Show("The system has determined that a GL account with the specified GL account number already exists. Please specify a different GL account number to save this account.", "GL Account Already Exists!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    if (((UltraDropDownBase) this.comboFinancialTypes).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a financial account type to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textBankName).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must enter a bank name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textAccountNumber).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must enter a bank account number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.checkNextCheckNumber.Checked && this.numericNextCheckNumber.Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must enter a bank name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.addressBankAddress.Address1.Equals(string.Empty) || this.addressBankAddress.City.Equals(string.Empty) || this.addressBankAddress.ZipCode.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("When entering a bank address you must supply an address, city, state and a zip code to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textABARoutingNumber).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must specify a routing number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textABARoutingNumber).Text.Length != 9)
    {
      int num = (int) MessageBox.Show("Routing number must be 9 characters long.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textDepositRoutingNumber).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must specify a routing number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textDepositRoutingNumber).Text.Length != 9)
    {
      int num = (int) MessageBox.Show("Routing number must be 9 characters long.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboAccountType).SelectedRow != null || !this._isBankAccount)
      return true;
    int num1 = (int) MessageBox.Show("You must select a account type to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this._isEditMode)
    {
      if (this._accountType == formGLAccountDialog.AccountType.GlAccount)
      {
        if (!this.IsBankAccount)
        {
          if (!this.ValidateNewGLAccount(true))
            return;
          this.SaveNewGLAccount();
        }
        else
        {
          if (!this.ValidateNewGLBankAccount(true))
            return;
          this.SaveNewGLBankAccount();
          this.SaveNewACHInformation();
        }
      }
      else
      {
        if (!this.ValidateNewGLAccount(true))
          return;
        this.SaveNewGLControlAccount();
      }
      using (formReloadingGLAccounts reloadingGlAccounts = new formReloadingGLAccounts())
      {
        int num = (int) reloadingGlAccounts.ShowDialog();
      }
    }
    else if (!this.IsBankAccount)
    {
      if (!this.ValidateNewGLAccount(false))
        return;
      this.UpdateGLAccount();
    }
    else
    {
      if (!this.ValidateNewGLBankAccount(false))
        return;
      this.UpdateGLBankAccount();
      this.UpdateACHInformation(this._node.GlAccount.GLAccountID);
    }
    this._node.RefreshNode();
    this.Close();
  }

  private void GetBankAccountTypes()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand selectCommand = new SqlCommand("dbo.spfin_GetBankAccountTypes", connection))
      {
        selectCommand.CommandType = CommandType.StoredProcedure;
        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
          sqlDataAdapter.Fill((DataTable) this.dsBankAccountTypes1.BankAccountTypes);
      }
    }
  }

  private void SetAddressResolverConnectionProperties()
  {
    this.addressBankAddress.WebserviceUrl = AddressResolverSettings.AddressResolverURL;
    this.addressBankAddress.UserID = AddressResolverSettings.AddressResolveUserName;
    this.addressBankAddress.Password = AddressResolverSettings.AddressResolverPassword;
  }

  private void DisplayGLAccountForEdit()
  {
    if (this._node.GlAccount == null)
      return;
    this.numericGlAccountNumber.Value = Decimal.Parse(this._node.GlAccount.AccountNumber.ToString());
    ((Control) this.textFullName).Text = this._node.GlAccount.AccountFullName;
    ((Control) this.textShortName).Text = this._node.GlAccount.AccountShortName;
    if (this._node.GlAccount.FinancialAccountTypeId != -1)
      this.comboFinancialTypes.Value = (object) this._node.GlAccount.FinancialAccountTypeId;
    if (!this._node.IsBankAccount)
      return;
    this.DisplayBankAccountForEdit(this._node.GlAccount.GLAccountID);
  }

  private void DisplayBankAccountForEdit(int glAccountId)
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("spFin_GetBankAccountForEdit", connection))
      {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@GlAcctId", (object) glAccountId);
        sqlCommand.Connection.Open();
        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);
        if (sqlDataReader.Read())
        {
          ((Control) this.textBankName).Text = sqlDataReader["BankName"].ToString();
          this.comboAccountType.Value = (object) sqlDataReader["BankAcctTypeId"].ToString();
          ((Control) this.textABARoutingNumber).Text = sqlDataReader["ABARouteNum"].ToString();
          ((Control) this.textAccountNumber).Text = sqlDataReader["BankAcctNum"].ToString();
          ((Control) this.textABAFractional).Text = sqlDataReader["ABAFractionalTransitNum"].ToString();
          if (!sqlDataReader["NextCheckNum"].ToString().Equals(string.Empty))
            this.numericNextCheckNumber.Value = (Decimal) int.Parse(sqlDataReader["NextCheckNum"].ToString());
          else
            this.checkNextCheckNumber.Checked = false;
          this.addressBankAddress.ISOCountryCode = sqlDataReader["ISOCountryCode"].ToString();
          this.addressBankAddress.Address1 = sqlDataReader["Addr1"].ToString();
          this.addressBankAddress.Address2 = sqlDataReader["Addr2"].ToString();
          this.addressBankAddress.City = sqlDataReader["City"].ToString();
          this.addressBankAddress.State = sqlDataReader["State"].ToString().Trim();
          this.addressBankAddress.ZipCode = sqlDataReader["zip"].ToString();
          this.addressBankAddress.ZipCodeExtension = sqlDataReader["zipExt"].ToString();
          ((Control) this.textBankContactName).Text = sqlDataReader["ContactName"].ToString();
          ((Control) this.textBankContactPhone).Text = sqlDataReader["ContactPhone"].ToString();
          ((Control) this.textBankContactFax).Text = sqlDataReader["ContactFax"].ToString();
          ((Control) this.textBankContactEmail).Text = sqlDataReader["ContactEmail"].ToString();
          ((Control) this.textDepositSlipSuffix).Text = sqlDataReader["DepositSlipSuffix"].ToString();
          ((Control) this.textDepositRoutingNumber).Text = sqlDataReader["DepositRoutingNumber"].ToString();
          if (int.Parse(sqlDataReader["financialType"].ToString()) != -1)
            this.comboFinancialTypes.Value = (object) int.Parse(sqlDataReader["financialType"].ToString());
        }
      }
    }
    this.LoadACHInformation(glAccountId);
  }

  private void numericGlAccountNumber_ValueChanged(object sender, EventArgs e)
  {
  }

  private void checkACHSettings_CheckedChanged(object sender, EventArgs e)
  {
    this.DoEnableACHFields(this.checkACHSettings.Checked);
  }

  private void DoEnableACHFields(bool enable)
  {
    ((Control) this.textBankACHCompanyID).Enabled = enable;
    ((Control) this.textBankACHCompanyName).Enabled = enable;
    ((Control) this.textBankACHImmedDest).Enabled = enable;
    ((Control) this.textBankACHImmedDestName).Enabled = enable;
    ((Control) this.textBankACHImmedOrgin).Enabled = enable;
    ((Control) this.textBankACHImmedOrgName).Enabled = enable;
    ((Control) this.textBankACHOrginatingDFI).Enabled = enable;
  }

  private void LoadACHInformation(int glAccountId)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.spFin_GetACHBankInformationForEdit", new object[2]
    {
      (object) "@glAccountId",
      (object) glAccountId
    });
    if (dataTable.Rows.Count == 0)
    {
      this.checkACHSettings.Checked = false;
    }
    else
    {
      this.DoEnableACHFields(true);
      this.checkACHSettings.Checked = bool.Parse(dataTable.Rows[0]["UseACH"].ToString());
      ((Control) this.textBankACHCompanyID).Text = dataTable.Rows[0]["ACHCompanyID"].ToString();
      ((Control) this.textBankACHCompanyName).Text = dataTable.Rows[0]["ACHCompanyName"].ToString();
      ((Control) this.textBankACHImmedDest).Text = dataTable.Rows[0]["ImmediateDestination"].ToString();
      ((Control) this.textBankACHImmedDestName).Text = dataTable.Rows[0]["ImmediateDestName"].ToString();
      ((Control) this.textBankACHImmedOrgin).Text = dataTable.Rows[0]["ImmediateOrigin"].ToString();
      ((Control) this.textBankACHImmedOrgName).Text = dataTable.Rows[0]["ImmediateOrginName"].ToString();
      ((Control) this.textBankACHOrginatingDFI).Text = dataTable.Rows[0]["OriginatingDFI"].ToString();
    }
  }

  private void SaveNewACHInformation()
  {
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
    {
      try
      {
        DefaultDatabase.ExecuteNonQuery("dbo.spFin_InsertGLACHFileInformation", new object[20]
        {
          (object) "@bankAcctNum",
          (object) ((Control) this.textAccountNumber).Text,
          (object) "@ImmediateDestination",
          (object) ((Control) this.textBankACHImmedDest).Text,
          (object) "@ImmediateOrigin",
          (object) ((Control) this.textBankACHImmedOrgin).Text,
          (object) "@ImmediateDestName",
          (object) ((Control) this.textBankACHImmedDestName).Text,
          (object) "@ImmediateOrginName",
          (object) ((Control) this.textBankACHImmedOrgName).Text,
          (object) "@OriginatingDFI",
          (object) ((Control) this.textBankACHOrginatingDFI).Text,
          (object) "@ACHCompanyId",
          (object) ((Control) this.textBankACHCompanyID).Text,
          (object) "@ACHCompanyName",
          (object) ((Control) this.textBankACHCompanyName).Text,
          (object) "@UserGuid",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@GlAcctId",
          (object) this.GlAccountId
        });
        e.Transaction.Commit();
      }
      catch (Exception ex)
      {
        e.Transaction.Rollback();
        throw;
      }
    }));
  }

  private void UpdateACHInformation(int glAccountId)
  {
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
    {
      try
      {
        DefaultDatabase.ExecuteNonQuery("dbo.spFin_UpdateGLACHFileInformation", new object[18]
        {
          (object) "@glAccountId",
          (object) glAccountId,
          (object) "@ImmediateDestination",
          (object) ((Control) this.textBankACHImmedDest).Text,
          (object) "@ImmediateOrigin",
          (object) ((Control) this.textBankACHImmedOrgin).Text,
          (object) "@ImmediateDestName",
          (object) ((Control) this.textBankACHImmedDestName).Text,
          (object) "@ImmediateOrginName",
          (object) ((Control) this.textBankACHImmedOrgName).Text,
          (object) "@OriginatingDFI",
          (object) ((Control) this.textBankACHOrginatingDFI).Text,
          (object) "@ACHCompanyId",
          (object) ((Control) this.textBankACHCompanyID).Text,
          (object) "@ACHCompanyName",
          (object) ((Control) this.textBankACHCompanyName).Text,
          (object) "@UserGuid",
          (object) CurrentUser.Instance.UserGUID
        });
        e.Transaction.Commit();
      }
      catch (Exception ex)
      {
        e.Transaction.Rollback();
        throw;
      }
    }));
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formGLAccountDialog));
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    this.groupBankInformation = new MGAGroupBox();
    this.label27 = new Label();
    this.checkACHSettings = new CheckBox();
    this.label25 = new Label();
    this.textBankACHOrginatingDFI = new MGATextBox();
    this.label23 = new Label();
    this.label24 = new Label();
    this.textBankACHImmedOrgName = new MGATextBox();
    this.textBankACHImmedOrgin = new MGATextBox();
    this.label18 = new Label();
    this.label19 = new Label();
    this.label20 = new Label();
    this.label21 = new Label();
    this.label22 = new Label();
    this.textBankACHImmedDestName = new MGATextBox();
    this.textBankACHImmedDest = new MGATextBox();
    this.textBankACHCompanyName = new MGATextBox();
    this.textBankACHCompanyID = new MGATextBox();
    this.label17 = new Label();
    this.textDepositRoutingNumber = new MGATextBox();
    this.textBankName = new MGATextBox();
    this.addressBankAddress = new AddressResolver_MULTI();
    this.label15 = new Label();
    this.label14 = new Label();
    this.label13 = new Label();
    this.label12 = new Label();
    this.label11 = new Label();
    this.label10 = new Label();
    this.label9 = new Label();
    this.label8 = new Label();
    this.textABAFractional = new MGATextBox();
    this.numericNextCheckNumber = new NumericUpDown();
    this.checkNextCheckNumber = new CheckBox();
    this.label7 = new Label();
    this.label6 = new Label();
    this.label5 = new Label();
    this.label4 = new Label();
    this.textBankContactFax = new MGATextBox();
    this.textBankContactPhone = new MGATextBox();
    this.textBankContactEmail = new MGATextBox();
    this.textBankContactName = new MGATextBox();
    this.textDepositSlipSuffix = new MGATextBox();
    this.textABARoutingNumber = new MGATextBox();
    this.textAccountNumber = new MGATextBox();
    this.comboAccountType = new MGASimpleComboBox();
    this.dsBankAccountTypes1 = new dsBankAccountTypes();
    this.groupGLInformation = new MGAGroupBox();
    this.comboFinancialTypes = new MGASimpleComboBox();
    this.dsGLAccountTypes1 = new dsGLAccountTypes();
    this.label16 = new Label();
    this.numericGlAccountNumber = new NumericUpDown();
    this.label3 = new Label();
    this.label2 = new Label();
    this.textShortName = new MGATextBox();
    this.textFullName = new MGATextBox();
    this.label1 = new Label();
    this.ellipsePanel1 = new EllipsePanel();
    this.labelSystemDefined = new Label();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.imageList1 = new ImageList(this.components);
    ((ISupportInitialize) this.groupBankInformation).BeginInit();
    ((Control) this.groupBankInformation).SuspendLayout();
    ((ISupportInitialize) this.textBankACHOrginatingDFI).BeginInit();
    ((ISupportInitialize) this.textBankACHImmedOrgName).BeginInit();
    ((ISupportInitialize) this.textBankACHImmedOrgin).BeginInit();
    ((ISupportInitialize) this.textBankACHImmedDestName).BeginInit();
    ((ISupportInitialize) this.textBankACHImmedDest).BeginInit();
    ((ISupportInitialize) this.textBankACHCompanyName).BeginInit();
    ((ISupportInitialize) this.textBankACHCompanyID).BeginInit();
    ((ISupportInitialize) this.textDepositRoutingNumber).BeginInit();
    ((ISupportInitialize) this.textBankName).BeginInit();
    ((ISupportInitialize) this.textABAFractional).BeginInit();
    this.numericNextCheckNumber.BeginInit();
    ((ISupportInitialize) this.textBankContactFax).BeginInit();
    ((ISupportInitialize) this.textBankContactPhone).BeginInit();
    ((ISupportInitialize) this.textBankContactEmail).BeginInit();
    ((ISupportInitialize) this.textBankContactName).BeginInit();
    ((ISupportInitialize) this.textDepositSlipSuffix).BeginInit();
    ((ISupportInitialize) this.textABARoutingNumber).BeginInit();
    ((ISupportInitialize) this.textAccountNumber).BeginInit();
    ((ISupportInitialize) this.comboAccountType).BeginInit();
    this.dsBankAccountTypes1.BeginInit();
    ((ISupportInitialize) this.groupGLInformation).BeginInit();
    ((Control) this.groupGLInformation).SuspendLayout();
    ((ISupportInitialize) this.comboFinancialTypes).BeginInit();
    this.dsGLAccountTypes1.BeginInit();
    this.numericGlAccountNumber.BeginInit();
    ((ISupportInitialize) this.textShortName).BeginInit();
    ((ISupportInitialize) this.textFullName).BeginInit();
    this.ellipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    this.SuspendLayout();
    this.groupBankInformation.BackColorInternal = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupBankInformation.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label27);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.checkACHSettings);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label25);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textBankACHOrginatingDFI);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label23);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label24);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textBankACHImmedOrgName);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textBankACHImmedOrgin);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label18);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label19);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label20);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label21);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label22);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textBankACHImmedDestName);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textBankACHImmedDest);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textBankACHCompanyName);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textBankACHCompanyID);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label17);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textDepositRoutingNumber);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textBankName);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.addressBankAddress);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label15);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label14);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label13);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label12);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label11);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label10);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label9);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label8);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textABAFractional);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.numericNextCheckNumber);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.checkNextCheckNumber);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label7);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label6);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label5);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.label4);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textBankContactFax);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textBankContactPhone);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textBankContactEmail);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textBankContactName);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textDepositSlipSuffix);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textABARoutingNumber);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.textAccountNumber);
    ((Control) this.groupBankInformation).Controls.Add((Control) this.comboAccountType);
    ((AppearanceBase) appearance2).AlphaLevel = (short) 230;
    ((AppearanceBase) appearance2).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance2).ForeColor = Color.White;
    ((AppearanceBase) appearance2).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).ImageBackground = (Image) componentResourceManager.GetObject("appearance19.ImageBackground");
    ((AppearanceBase) appearance2).ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.groupBankInformation.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.groupBankInformation).Location = new Point(8, 128 /*0x80*/);
    ((Control) this.groupBankInformation).Name = "groupBankInformation";
    ((Control) this.groupBankInformation).Size = new Size(520, 446);
    ((Control) this.groupBankInformation).TabIndex = 1;
    ((Control) this.groupBankInformation).Text = "Bank Account Information";
    this.groupBankInformation.ViewStyle = (GroupBoxViewStyle) 2;
    this.label27.AutoSize = true;
    this.label27.BackColor = Color.Transparent;
    this.label27.ForeColor = Color.Black;
    this.label27.Location = new Point(285, 207);
    this.label27.Name = "label27";
    this.label27.Size = new Size(72, 13);
    this.label27.TabIndex = 42;
    this.label27.Text = "Use For ACH:";
    this.checkACHSettings.BackColor = Color.Transparent;
    this.checkACHSettings.Checked = true;
    this.checkACHSettings.CheckState = CheckState.Checked;
    this.checkACHSettings.FlatStyle = FlatStyle.Flat;
    this.checkACHSettings.Location = new Point(363, 204);
    this.checkACHSettings.Name = "checkACHSettings";
    this.checkACHSettings.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.checkACHSettings.TabIndex = 43;
    this.checkACHSettings.UseVisualStyleBackColor = false;
    this.checkACHSettings.CheckedChanged += new EventHandler(this.checkACHSettings_CheckedChanged);
    this.label25.AutoSize = true;
    this.label25.BackColor = Color.Transparent;
    this.label25.ForeColor = Color.Black;
    this.label25.Location = new Point(296, 390);
    this.label25.Name = "label25";
    this.label25.Size = new Size(83, 13);
    this.label25.TabIndex = 40;
    this.label25.Text = "Originating DFI:";
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankACHOrginatingDFI).Appearance = (AppearanceBase) appearance3;
    ((Control) this.textBankACHOrginatingDFI).BackColor = Color.White;
    ((Control) this.textBankACHOrginatingDFI).Location = new Point(401, 390);
    ((TextEditorControlBase) this.textBankACHOrginatingDFI).MaxLength = 40;
    this.textBankACHOrginatingDFI.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankACHOrginatingDFI).Name = "textBankACHOrginatingDFI";
    ((Control) this.textBankACHOrginatingDFI).Size = new Size(103, 20);
    ((Control) this.textBankACHOrginatingDFI).TabIndex = 41;
    ((UltraControlBase) this.textBankACHOrginatingDFI).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankACHOrginatingDFI).UseOsThemes = (DefaultableBoolean) 2;
    this.label23.AutoSize = true;
    this.label23.BackColor = Color.Transparent;
    this.label23.ForeColor = Color.Black;
    this.label23.Location = new Point(296, 364);
    this.label23.Name = "label23";
    this.label23.Size = new Size(106, 13);
    this.label23.TabIndex = 38;
    this.label23.Text = "Immed. Orgin Name:";
    this.label24.AutoSize = true;
    this.label24.BackColor = Color.Transparent;
    this.label24.ForeColor = Color.Black;
    this.label24.Location = new Point(295, 340);
    this.label24.Name = "label24";
    this.label24.Size = new Size(76, 13);
    this.label24.TabIndex = 36;
    this.label24.Text = "Immed. Orgin:";
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankACHImmedOrgName).Appearance = (AppearanceBase) appearance4;
    ((Control) this.textBankACHImmedOrgName).BackColor = Color.White;
    ((Control) this.textBankACHImmedOrgName).Location = new Point(401, 364);
    ((TextEditorControlBase) this.textBankACHImmedOrgName).MaxLength = 40;
    this.textBankACHImmedOrgName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankACHImmedOrgName).Name = "textBankACHImmedOrgName";
    ((Control) this.textBankACHImmedOrgName).Size = new Size(103, 20);
    ((Control) this.textBankACHImmedOrgName).TabIndex = 39;
    ((UltraControlBase) this.textBankACHImmedOrgName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankACHImmedOrgName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankACHImmedOrgin).Appearance = (AppearanceBase) appearance5;
    ((Control) this.textBankACHImmedOrgin).BackColor = Color.White;
    ((Control) this.textBankACHImmedOrgin).Location = new Point(401, 340);
    ((TextEditorControlBase) this.textBankACHImmedOrgin).MaxLength = 25;
    this.textBankACHImmedOrgin.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankACHImmedOrgin).Name = "textBankACHImmedOrgin";
    ((Control) this.textBankACHImmedOrgin).Size = new Size(103, 20);
    ((Control) this.textBankACHImmedOrgin).TabIndex = 37;
    ((UltraControlBase) this.textBankACHImmedOrgin).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankACHImmedOrgin).UseOsThemes = (DefaultableBoolean) 2;
    this.label18.AutoSize = true;
    this.label18.BackColor = Color.Transparent;
    this.label18.ForeColor = Color.Black;
    this.label18.Location = new Point(8, 367);
    this.label18.Name = "label18";
    this.label18.Size = new Size(86, 13);
    this.label18.TabIndex = 30;
    this.label18.Text = "Company Name:";
    this.label19.AutoSize = true;
    this.label19.BackColor = Color.Transparent;
    this.label19.ForeColor = Color.Black;
    this.label19.Location = new Point(7, 420);
    this.label19.Name = "label19";
    this.label19.Size = new Size(106, 13);
    this.label19.TabIndex = 34;
    this.label19.Text = "Immed. Dest. Name:";
    this.label20.AutoSize = true;
    this.label20.BackColor = Color.Transparent;
    this.label20.ForeColor = Color.Black;
    this.label20.Location = new Point(8, 394);
    this.label20.Name = "label20";
    this.label20.Size = new Size(72, 13);
    this.label20.TabIndex = 32 /*0x20*/;
    this.label20.Text = "Immed. Dest:";
    this.label21.AutoSize = true;
    this.label21.BackColor = Color.Transparent;
    this.label21.ForeColor = Color.Black;
    this.label21.Location = new Point(7, 343);
    this.label21.Name = "label21";
    this.label21.Size = new Size(70, 13);
    this.label21.TabIndex = 28;
    this.label21.Text = "Company ID:";
    this.label22.AutoSize = true;
    this.label22.BackColor = Color.Transparent;
    this.label22.Font = new Font("Tahoma", 8f, FontStyle.Underline);
    this.label22.ForeColor = Color.Black;
    this.label22.Location = new Point(10, 319);
    this.label22.Name = "label22";
    this.label22.Size = new Size(80 /*0x50*/, 13);
    this.label22.TabIndex = 27;
    this.label22.Text = "Bank ACH Data";
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankACHImmedDestName).Appearance = (AppearanceBase) appearance6;
    ((Control) this.textBankACHImmedDestName).BackColor = Color.White;
    ((Control) this.textBankACHImmedDestName).Location = new Point(120, 419);
    ((TextEditorControlBase) this.textBankACHImmedDestName).MaxLength = 20;
    this.textBankACHImmedDestName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankACHImmedDestName).Name = "textBankACHImmedDestName";
    ((Control) this.textBankACHImmedDestName).Size = new Size(170, 20);
    ((Control) this.textBankACHImmedDestName).TabIndex = 35;
    ((UltraControlBase) this.textBankACHImmedDestName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankACHImmedDestName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankACHImmedDest).Appearance = (AppearanceBase) appearance7;
    ((Control) this.textBankACHImmedDest).BackColor = Color.White;
    ((Control) this.textBankACHImmedDest).Location = new Point(120, 393);
    ((TextEditorControlBase) this.textBankACHImmedDest).MaxLength = 20;
    this.textBankACHImmedDest.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankACHImmedDest).Name = "textBankACHImmedDest";
    ((Control) this.textBankACHImmedDest).Size = new Size(170, 20);
    ((Control) this.textBankACHImmedDest).TabIndex = 33;
    ((UltraControlBase) this.textBankACHImmedDest).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankACHImmedDest).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankACHCompanyName).Appearance = (AppearanceBase) appearance8;
    ((Control) this.textBankACHCompanyName).BackColor = Color.White;
    ((Control) this.textBankACHCompanyName).Location = new Point(120, 367);
    ((TextEditorControlBase) this.textBankACHCompanyName).MaxLength = 40;
    this.textBankACHCompanyName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankACHCompanyName).Name = "textBankACHCompanyName";
    ((Control) this.textBankACHCompanyName).Size = new Size(170, 20);
    ((Control) this.textBankACHCompanyName).TabIndex = 31 /*0x1F*/;
    ((UltraControlBase) this.textBankACHCompanyName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankACHCompanyName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankACHCompanyID).Appearance = (AppearanceBase) appearance9;
    ((Control) this.textBankACHCompanyID).BackColor = Color.White;
    ((Control) this.textBankACHCompanyID).Location = new Point(120, 343);
    ((TextEditorControlBase) this.textBankACHCompanyID).MaxLength = 25;
    this.textBankACHCompanyID.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankACHCompanyID).Name = "textBankACHCompanyID";
    ((Control) this.textBankACHCompanyID).Size = new Size(170, 20);
    ((Control) this.textBankACHCompanyID).TabIndex = 29;
    ((UltraControlBase) this.textBankACHCompanyID).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankACHCompanyID).UseOsThemes = (DefaultableBoolean) 2;
    this.label17.AutoSize = true;
    this.label17.BackColor = Color.Transparent;
    this.label17.ForeColor = Color.Black;
    this.label17.Location = new Point(8, 128 /*0x80*/);
    this.label17.Name = "label17";
    this.label17.Size = new Size(98, 13);
    this.label17.TabIndex = 8;
    this.label17.Text = "Deposit Routing #:";
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textDepositRoutingNumber).Appearance = (AppearanceBase) appearance10;
    ((Control) this.textDepositRoutingNumber).BackColor = Color.White;
    ((Control) this.textDepositRoutingNumber).Location = new Point(120, 128 /*0x80*/);
    ((TextEditorControlBase) this.textDepositRoutingNumber).MaxLength = 9;
    this.textDepositRoutingNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textDepositRoutingNumber).Name = "textDepositRoutingNumber";
    ((Control) this.textDepositRoutingNumber).Size = new Size(136, 20);
    ((Control) this.textDepositRoutingNumber).TabIndex = 9;
    ((UltraControlBase) this.textDepositRoutingNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textDepositRoutingNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankName).Appearance = (AppearanceBase) appearance11;
    ((Control) this.textBankName).BackColor = Color.White;
    ((Control) this.textBankName).Location = new Point(120, 32 /*0x20*/);
    ((TextEditorControlBase) this.textBankName).MaxLength = 100;
    this.textBankName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankName).Name = "textBankName";
    ((Control) this.textBankName).Size = new Size(384, 20);
    ((Control) this.textBankName).TabIndex = 1;
    ((UltraControlBase) this.textBankName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankName).UseOsThemes = (DefaultableBoolean) 2;
    this.addressBankAddress.Address1 = "";
    this.addressBankAddress.Address2 = "";
    ((Control) this.addressBankAddress).BackColor = Color.FromArgb(239, 247, 253);
    this.addressBankAddress.City = "";
    this.addressBankAddress.County = "";
    ((Control) this.addressBankAddress).Font = new Font("Tahoma", 8f);
    this.addressBankAddress.ISOCountryCode = "";
    this.addressBankAddress.ISOCountryCodeMember = "";
    this.addressBankAddress.ISOCountryList = (object) null;
    this.addressBankAddress.ISOCountryNameMember = "";
    ((Control) this.addressBankAddress).Location = new Point(272, 48 /*0x30*/);
    this.addressBankAddress.MGAStyle = MGAStyles.Blue;
    ((Control) this.addressBankAddress).Name = "addressBankAddress";
    this.addressBankAddress.Password = (string) null;
    ((Control) this.addressBankAddress).Size = new Size(240 /*0xF0*/, 152);
    this.addressBankAddress.State = "";
    ((Control) this.addressBankAddress).TabIndex = 17;
    this.addressBankAddress.TextAlign = ContentAlignment.MiddleLeft;
    this.addressBankAddress.UserID = (string) null;
    this.addressBankAddress.WebserviceUrl = (string) null;
    this.addressBankAddress.ZipCode = "";
    this.addressBankAddress.ZipCodeExtension = "";
    this.label15.AutoSize = true;
    this.label15.BackColor = Color.Transparent;
    this.label15.ForeColor = Color.Black;
    this.label15.Location = new Point(8, 288);
    this.label15.Name = "label15";
    this.label15.Size = new Size(35, 13);
    this.label15.TabIndex = 21;
    this.label15.Text = "Email:";
    this.label14.AutoSize = true;
    this.label14.BackColor = Color.Transparent;
    this.label14.ForeColor = Color.Black;
    this.label14.Location = new Point(296, 288);
    this.label14.Name = "label14";
    this.label14.Size = new Size(29, 13);
    this.label14.TabIndex = 25;
    this.label14.Text = "Fax:";
    this.label13.AutoSize = true;
    this.label13.BackColor = Color.Transparent;
    this.label13.ForeColor = Color.Black;
    this.label13.Location = new Point(296, 264);
    this.label13.Name = "label13";
    this.label13.Size = new Size(41, 13);
    this.label13.TabIndex = 23;
    this.label13.Text = "Phone:";
    this.label12.AutoSize = true;
    this.label12.BackColor = Color.Transparent;
    this.label12.ForeColor = Color.Black;
    this.label12.Location = new Point(8, 264);
    this.label12.Name = "label12";
    this.label12.Size = new Size(38, 13);
    this.label12.TabIndex = 19;
    this.label12.Text = "Name:";
    this.label11.AutoSize = true;
    this.label11.BackColor = Color.Transparent;
    this.label11.Font = new Font("Tahoma", 8f, FontStyle.Underline);
    this.label11.ForeColor = Color.Black;
    this.label11.Location = new Point(8, 240 /*0xF0*/);
    this.label11.Name = "label11";
    this.label11.Size = new Size(130, 13);
    this.label11.TabIndex = 18;
    this.label11.Text = "Bank Contact Information";
    this.label10.AutoSize = true;
    this.label10.BackColor = Color.Transparent;
    this.label10.ForeColor = Color.Black;
    this.label10.Location = new Point(8, 200);
    this.label10.Name = "label10";
    this.label10.Size = new Size(97, 13);
    this.label10.TabIndex = 15;
    this.label10.Text = "Deposit Slip Suffix:";
    this.label9.AutoSize = true;
    this.label9.BackColor = Color.Transparent;
    this.label9.ForeColor = Color.Black;
    this.label9.Location = new Point(8, 176 /*0xB0*/);
    this.label9.Name = "label9";
    this.label9.Size = new Size(92, 13);
    this.label9.TabIndex = 13;
    this.label9.Text = "ABA Fractional #:";
    this.label8.AutoSize = true;
    this.label8.BackColor = Color.Transparent;
    this.label8.ForeColor = Color.Black;
    this.label8.Location = new Point(8, 152);
    this.label8.Name = "label8";
    this.label8.Size = new Size(106, 13);
    this.label8.TabIndex = 10;
    this.label8.Text = "Next Check Number:";
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance12).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textABAFractional).Appearance = (AppearanceBase) appearance12;
    ((Control) this.textABAFractional).BackColor = Color.White;
    ((Control) this.textABAFractional).Location = new Point(120, 176 /*0xB0*/);
    ((TextEditorControlBase) this.textABAFractional).MaxLength = 20;
    this.textABAFractional.MGAStyle = MGAStyles.Blue;
    ((Control) this.textABAFractional).Name = "textABAFractional";
    ((Control) this.textABAFractional).Size = new Size(136, 20);
    ((Control) this.textABAFractional).TabIndex = 14;
    ((UltraControlBase) this.textABAFractional).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textABAFractional).UseOsThemes = (DefaultableBoolean) 2;
    this.numericNextCheckNumber.BorderStyle = BorderStyle.FixedSingle;
    this.numericNextCheckNumber.ForeColor = Color.Black;
    this.numericNextCheckNumber.Location = new Point(136, 152);
    this.numericNextCheckNumber.Maximum = new Decimal(new int[4]
    {
      999999999,
      0,
      0,
      0
    });
    this.numericNextCheckNumber.Minimum = new Decimal(new int[4]
    {
      101,
      0,
      0,
      0
    });
    this.numericNextCheckNumber.Name = "numericNextCheckNumber";
    this.numericNextCheckNumber.Size = new Size(120, 20);
    this.numericNextCheckNumber.TabIndex = 12;
    this.numericNextCheckNumber.TextAlign = HorizontalAlignment.Right;
    this.numericNextCheckNumber.Value = new Decimal(new int[4]
    {
      101,
      0,
      0,
      0
    });
    this.checkNextCheckNumber.BackColor = Color.FromArgb(239, 247, 253);
    this.checkNextCheckNumber.Checked = true;
    this.checkNextCheckNumber.CheckState = CheckState.Checked;
    this.checkNextCheckNumber.FlatStyle = FlatStyle.Flat;
    this.checkNextCheckNumber.Location = new Point(120, 152);
    this.checkNextCheckNumber.Name = "checkNextCheckNumber";
    this.checkNextCheckNumber.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.checkNextCheckNumber.TabIndex = 11;
    this.checkNextCheckNumber.UseVisualStyleBackColor = false;
    this.label7.AutoSize = true;
    this.label7.BackColor = Color.Transparent;
    this.label7.ForeColor = Color.Black;
    this.label7.Location = new Point(8, 80 /*0x50*/);
    this.label7.Name = "label7";
    this.label7.Size = new Size(90, 13);
    this.label7.TabIndex = 4;
    this.label7.Text = "Account Number:";
    this.label6.AutoSize = true;
    this.label6.BackColor = Color.Transparent;
    this.label6.ForeColor = Color.Black;
    this.label6.Location = new Point(8, 104);
    this.label6.Name = "label6";
    this.label6.Size = new Size(91, 13);
    this.label6.TabIndex = 6;
    this.label6.Text = "Check Routing #:";
    this.label5.AutoSize = true;
    this.label5.BackColor = Color.Transparent;
    this.label5.ForeColor = Color.Black;
    this.label5.Location = new Point(8, 56);
    this.label5.Name = "label5";
    this.label5.Size = new Size(77, 13);
    this.label5.TabIndex = 2;
    this.label5.Text = "Account Type:";
    this.label4.AutoSize = true;
    this.label4.BackColor = Color.Transparent;
    this.label4.ForeColor = Color.Black;
    this.label4.Location = new Point(8, 32 /*0x20*/);
    this.label4.Name = "label4";
    this.label4.Size = new Size(64 /*0x40*/, 13);
    this.label4.TabIndex = 0;
    this.label4.Text = "Bank Name:";
    ((AppearanceBase) appearance13).BackColor = Color.White;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankContactFax).Appearance = (AppearanceBase) appearance13;
    ((Control) this.textBankContactFax).BackColor = Color.White;
    ((Control) this.textBankContactFax).Location = new Point(336, 288);
    ((TextEditorControlBase) this.textBankContactFax).MaxLength = 20;
    this.textBankContactFax.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankContactFax).Name = "textBankContactFax";
    ((Control) this.textBankContactFax).Size = new Size(168, 20);
    ((Control) this.textBankContactFax).TabIndex = 26;
    ((UltraControlBase) this.textBankContactFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankContactFax).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance14).BackColor = Color.White;
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankContactPhone).Appearance = (AppearanceBase) appearance14;
    ((Control) this.textBankContactPhone).BackColor = Color.White;
    ((Control) this.textBankContactPhone).Location = new Point(336, 264);
    ((TextEditorControlBase) this.textBankContactPhone).MaxLength = 20;
    this.textBankContactPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankContactPhone).Name = "textBankContactPhone";
    ((Control) this.textBankContactPhone).Size = new Size(168, 20);
    ((Control) this.textBankContactPhone).TabIndex = 24;
    ((UltraControlBase) this.textBankContactPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankContactPhone).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance15).BackColor = Color.White;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankContactEmail).Appearance = (AppearanceBase) appearance15;
    ((Control) this.textBankContactEmail).BackColor = Color.White;
    ((Control) this.textBankContactEmail).Location = new Point(64 /*0x40*/, 288);
    ((TextEditorControlBase) this.textBankContactEmail).MaxLength = 40;
    this.textBankContactEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankContactEmail).Name = "textBankContactEmail";
    ((Control) this.textBankContactEmail).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.textBankContactEmail).TabIndex = 22;
    ((UltraControlBase) this.textBankContactEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankContactEmail).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance16).BackColor = Color.White;
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance16).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankContactName).Appearance = (AppearanceBase) appearance16;
    ((Control) this.textBankContactName).BackColor = Color.White;
    ((Control) this.textBankContactName).Location = new Point(64 /*0x40*/, 264);
    ((TextEditorControlBase) this.textBankContactName).MaxLength = 25;
    this.textBankContactName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankContactName).Name = "textBankContactName";
    ((Control) this.textBankContactName).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.textBankContactName).TabIndex = 20;
    ((UltraControlBase) this.textBankContactName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankContactName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance17).BackColor = Color.White;
    ((AppearanceBase) appearance17).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance17).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textDepositSlipSuffix).Appearance = (AppearanceBase) appearance17;
    ((Control) this.textDepositSlipSuffix).BackColor = Color.White;
    ((Control) this.textDepositSlipSuffix).Location = new Point(120, 200);
    ((TextEditorControlBase) this.textDepositSlipSuffix).MaxLength = 5;
    this.textDepositSlipSuffix.MGAStyle = MGAStyles.Blue;
    ((Control) this.textDepositSlipSuffix).Name = "textDepositSlipSuffix";
    ((Control) this.textDepositSlipSuffix).Size = new Size(136, 20);
    ((Control) this.textDepositSlipSuffix).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.textDepositSlipSuffix).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textDepositSlipSuffix).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance18).BackColor = Color.White;
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance18).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textABARoutingNumber).Appearance = (AppearanceBase) appearance18;
    ((Control) this.textABARoutingNumber).BackColor = Color.White;
    ((Control) this.textABARoutingNumber).Location = new Point(120, 104);
    ((TextEditorControlBase) this.textABARoutingNumber).MaxLength = 9;
    this.textABARoutingNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textABARoutingNumber).Name = "textABARoutingNumber";
    ((Control) this.textABARoutingNumber).Size = new Size(136, 20);
    ((Control) this.textABARoutingNumber).TabIndex = 7;
    ((UltraControlBase) this.textABARoutingNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textABARoutingNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance19).BackColor = Color.White;
    ((AppearanceBase) appearance19).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance19).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textAccountNumber).Appearance = (AppearanceBase) appearance19;
    ((Control) this.textAccountNumber).BackColor = Color.White;
    ((Control) this.textAccountNumber).Location = new Point(120, 80 /*0x50*/);
    ((TextEditorControlBase) this.textAccountNumber).MaxLength = 25;
    this.textAccountNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textAccountNumber).Name = "textAccountNumber";
    ((Control) this.textAccountNumber).Size = new Size(136, 20);
    ((Control) this.textAccountNumber).TabIndex = 5;
    ((UltraControlBase) this.textAccountNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textAccountNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.comboAccountType.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboAccountType).DataMember = "BankAccountTypes";
    ((UltraGridBase) this.comboAccountType).DataSource = (object) this.dsBankAccountTypes1;
    ((UltraDropDownBase) this.comboAccountType).DisplayMember = "BankAcctType";
    this.comboAccountType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboAccountType).Location = new Point(120, 56);
    this.comboAccountType.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboAccountType).Name = "comboAccountType";
    ((Control) this.comboAccountType).Size = new Size(136, 21);
    ((Control) this.comboAccountType).TabIndex = 3;
    ((UltraControlBase) this.comboAccountType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboAccountType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboAccountType).ValueMember = "BankAcctTypeId";
    this.dsBankAccountTypes1.DataSetName = "dsBankAccountTypes";
    this.dsBankAccountTypes1.Locale = new CultureInfo("en-US");
    this.dsBankAccountTypes1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance20).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupGLInformation.ContentAreaAppearance = (AppearanceBase) appearance20;
    ((Control) this.groupGLInformation).Controls.Add((Control) this.comboFinancialTypes);
    ((Control) this.groupGLInformation).Controls.Add((Control) this.label16);
    ((Control) this.groupGLInformation).Controls.Add((Control) this.numericGlAccountNumber);
    ((Control) this.groupGLInformation).Controls.Add((Control) this.label3);
    ((Control) this.groupGLInformation).Controls.Add((Control) this.label2);
    ((Control) this.groupGLInformation).Controls.Add((Control) this.textShortName);
    ((Control) this.groupGLInformation).Controls.Add((Control) this.textFullName);
    ((Control) this.groupGLInformation).Controls.Add((Control) this.label1);
    ((AppearanceBase) appearance21).AlphaLevel = (short) 230;
    ((AppearanceBase) appearance21).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance21).ForeColor = Color.White;
    ((AppearanceBase) appearance21).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance21).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance21).ImageBackground = (Image) componentResourceManager.GetObject("appearance23.ImageBackground");
    ((AppearanceBase) appearance21).ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.groupGLInformation.HeaderAppearance = (AppearanceBase) appearance21;
    ((Control) this.groupGLInformation).Location = new Point(8, 8);
    ((Control) this.groupGLInformation).Name = "groupGLInformation";
    ((Control) this.groupGLInformation).Size = new Size(520, 112 /*0x70*/);
    ((Control) this.groupGLInformation).TabIndex = 0;
    ((Control) this.groupGLInformation).Text = "GL Account Information";
    this.groupGLInformation.ViewStyle = (GroupBoxViewStyle) 2;
    this.comboFinancialTypes.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboFinancialTypes).DataMember = "TypesList";
    ((UltraGridBase) this.comboFinancialTypes).DataSource = (object) this.dsGLAccountTypes1;
    ((UltraDropDownBase) this.comboFinancialTypes).DisplayMember = "AcctTypeDescription";
    this.comboFinancialTypes.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboFinancialTypes).Location = new Point(288, 80 /*0x50*/);
    this.comboFinancialTypes.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboFinancialTypes).Name = "comboFinancialTypes";
    ((Control) this.comboFinancialTypes).Size = new Size(216, 21);
    ((Control) this.comboFinancialTypes).TabIndex = 7;
    ((UltraControlBase) this.comboFinancialTypes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboFinancialTypes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboFinancialTypes).ValueMember = "AcctTypeId";
    this.dsGLAccountTypes1.DataSetName = "dsGLAccountTypes";
    this.dsGLAccountTypes1.Locale = new CultureInfo("en-US");
    this.dsGLAccountTypes1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.label16.AutoSize = true;
    this.label16.BackColor = Color.Transparent;
    this.label16.ForeColor = Color.Black;
    this.label16.Location = new Point(208 /*0xD0*/, 80 /*0x50*/);
    this.label16.Name = "label16";
    this.label16.Size = new Size(79, 13);
    this.label16.TabIndex = 6;
    this.label16.Text = "Financial Type:";
    this.numericGlAccountNumber.BorderStyle = BorderStyle.FixedSingle;
    this.numericGlAccountNumber.ForeColor = Color.Black;
    this.numericGlAccountNumber.Location = new Point(128 /*0x80*/, 80 /*0x50*/);
    this.numericGlAccountNumber.Maximum = new Decimal(new int[4]
    {
      32760,
      0,
      0,
      0
    });
    this.numericGlAccountNumber.Name = "numericGlAccountNumber";
    this.numericGlAccountNumber.Size = new Size(72, 20);
    this.numericGlAccountNumber.TabIndex = 5;
    this.numericGlAccountNumber.TextAlign = HorizontalAlignment.Right;
    this.numericGlAccountNumber.ValueChanged += new EventHandler(this.numericGlAccountNumber_ValueChanged);
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.ForeColor = Color.Black;
    this.label3.Location = new Point(16 /*0x10*/, 80 /*0x50*/);
    this.label3.Name = "label3";
    this.label3.Size = new Size(61, 13);
    this.label3.TabIndex = 4;
    this.label3.Text = "Account #:";
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.ForeColor = Color.Black;
    this.label2.Location = new Point(16 /*0x10*/, 56);
    this.label2.Name = "label2";
    this.label2.Size = new Size(109, 13);
    this.label2.TabIndex = 2;
    this.label2.Text = "Account Short Name:";
    ((AppearanceBase) appearance22).BackColor = Color.White;
    ((AppearanceBase) appearance22).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance22).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textShortName).Appearance = (AppearanceBase) appearance22;
    ((Control) this.textShortName).BackColor = Color.White;
    ((Control) this.textShortName).Location = new Point(128 /*0x80*/, 56);
    this.textShortName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textShortName).Name = "textShortName";
    ((Control) this.textShortName).Size = new Size(376, 20);
    ((Control) this.textShortName).TabIndex = 3;
    ((UltraControlBase) this.textShortName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textShortName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance23).BackColor = Color.White;
    ((AppearanceBase) appearance23).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance23).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textFullName).Appearance = (AppearanceBase) appearance23;
    ((Control) this.textFullName).BackColor = Color.White;
    ((Control) this.textFullName).Location = new Point(128 /*0x80*/, 32 /*0x20*/);
    this.textFullName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textFullName).Name = "textFullName";
    ((Control) this.textFullName).Size = new Size(376, 20);
    ((Control) this.textFullName).TabIndex = 1;
    ((UltraControlBase) this.textFullName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textFullName).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.ForeColor = Color.Black;
    this.label1.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(99, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "Account Full Name:";
    this.ellipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel1.Controls.Add((Control) this.labelSystemDefined);
    this.ellipsePanel1.Controls.Add((Control) this.buttonCancel);
    this.ellipsePanel1.Controls.Add((Control) this.buttonSave);
    this.ellipsePanel1.CornerOffset = 1;
    this.ellipsePanel1.Location = new Point(8, 580);
    this.ellipsePanel1.Name = "ellipsePanel1";
    this.ellipsePanel1.Size = new Size(520, 40);
    this.ellipsePanel1.TabIndex = 2;
    this.labelSystemDefined.AutoSize = true;
    this.labelSystemDefined.Font = new Font("Tahoma", 11f, FontStyle.Bold);
    this.labelSystemDefined.ForeColor = Color.DimGray;
    this.labelSystemDefined.Location = new Point(8, 8);
    this.labelSystemDefined.Name = "labelSystemDefined";
    this.labelSystemDefined.Size = new Size(125, 18);
    this.labelSystemDefined.TabIndex = 2;
    this.labelSystemDefined.Text = "System Defined";
    this.labelSystemDefined.Visible = false;
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance24).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance24).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance24).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance24).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance24).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance24;
    ((Control) this.buttonCancel).Location = new Point(424, 8);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.buttonCancel).TabIndex = 1;
    ((Control) this.buttonCancel).Text = "&Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance25).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance25).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance25).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance25).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance25).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance25).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance25;
    ((Control) this.buttonSave).Location = new Point(336, 8);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.buttonSave).TabIndex = 0;
    ((Control) this.buttonSave).Text = "&Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    this.imageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imageList1.ImageStream");
    this.imageList1.TransparentColor = Color.Transparent;
    this.imageList1.Images.SetKeyName(0, "");
    this.imageList1.Images.SetKeyName(1, "");
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(538, 641);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ellipsePanel1);
    this.Controls.Add((Control) this.groupGLInformation);
    this.Controls.Add((Control) this.groupBankInformation);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (formGLAccountDialog);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "GL Account";
    ((ISupportInitialize) this.groupBankInformation).EndInit();
    ((Control) this.groupBankInformation).ResumeLayout(false);
    ((Control) this.groupBankInformation).PerformLayout();
    ((ISupportInitialize) this.textBankACHOrginatingDFI).EndInit();
    ((ISupportInitialize) this.textBankACHImmedOrgName).EndInit();
    ((ISupportInitialize) this.textBankACHImmedOrgin).EndInit();
    ((ISupportInitialize) this.textBankACHImmedDestName).EndInit();
    ((ISupportInitialize) this.textBankACHImmedDest).EndInit();
    ((ISupportInitialize) this.textBankACHCompanyName).EndInit();
    ((ISupportInitialize) this.textBankACHCompanyID).EndInit();
    ((ISupportInitialize) this.textDepositRoutingNumber).EndInit();
    ((ISupportInitialize) this.textBankName).EndInit();
    ((ISupportInitialize) this.textABAFractional).EndInit();
    this.numericNextCheckNumber.EndInit();
    ((ISupportInitialize) this.textBankContactFax).EndInit();
    ((ISupportInitialize) this.textBankContactPhone).EndInit();
    ((ISupportInitialize) this.textBankContactEmail).EndInit();
    ((ISupportInitialize) this.textBankContactName).EndInit();
    ((ISupportInitialize) this.textDepositSlipSuffix).EndInit();
    ((ISupportInitialize) this.textABARoutingNumber).EndInit();
    ((ISupportInitialize) this.textAccountNumber).EndInit();
    ((ISupportInitialize) this.comboAccountType).EndInit();
    this.dsBankAccountTypes1.EndInit();
    ((ISupportInitialize) this.groupGLInformation).EndInit();
    ((Control) this.groupGLInformation).ResumeLayout(false);
    ((Control) this.groupGLInformation).PerformLayout();
    ((ISupportInitialize) this.comboFinancialTypes).EndInit();
    this.dsGLAccountTypes1.EndInit();
    this.numericGlAccountNumber.EndInit();
    ((ISupportInitialize) this.textShortName).EndInit();
    ((ISupportInitialize) this.textFullName).EndInit();
    this.ellipsePanel1.ResumeLayout(false);
    this.ellipsePanel1.PerformLayout();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    this.ResumeLayout(false);
  }

  public enum AccountType
  {
    ControlAccount,
    GlAccount,
  }
}

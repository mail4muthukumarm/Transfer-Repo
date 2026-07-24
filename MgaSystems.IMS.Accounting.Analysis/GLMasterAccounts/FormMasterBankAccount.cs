// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.GLMasterAccounts.FormMasterBankAccount
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Analysis.Master_GL_Accounts;
using MGASystems.IMS.Accounting.Analysis.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.GLMasterAccounts;

public class FormMasterBankAccount : FormBase
{
  private int _passedGLMasterAcctId = -1;
  private string _oldBankNameValue;
  private IContainer components;
  private Label label17;
  private MGATextBox textDepositRoutingNumber;
  private MGATextBox textBankName;
  private AddressResolver_MULTI addressBankAddress;
  private Label label15;
  private Label label14;
  private Label label13;
  private Label label12;
  private Label label11;
  private Label label10;
  private Label label9;
  private Label label8;
  private MGATextBox textABAFractional;
  private NumericUpDown numericNextCheckNumber;
  private CheckBox checkNextCheckNumber;
  private Label label7;
  private Label label6;
  private Label label5;
  private Label label4;
  private MGATextBox textBankContactFax;
  private MGATextBox textBankContactPhone;
  private MGATextBox textBankContactEmail;
  private MGATextBox textBankContactName;
  private MGATextBox textDepositSlipSuffix;
  private MGATextBox textABARoutingNumber;
  private MGATextBox textAccountNumber;
  private MGASimpleComboBox comboAccountType;
  private dsBankAccountTypes dsBankAccountTypes1;
  private dsGLAccountTypes dsGLAccountTypes1;
  private ImageList imageList1;
  private UltraToolbarsManager ultraToolbarsManager1;
  private Panel FormBackground_Fill_Panel;
  private UltraToolbarsDockArea _FormBackground_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormBackground_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormBackground_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _FormBackground_Toolbars_Dock_Area_Bottom;
  private Label label16;
  private MGATextBox textCheckLine3;
  private Label label3;
  private Label label2;
  private Label label1;
  private MGATextBox textCheckLine2;
  private MGATextBox textCheckLine1;
  private Label label19;
  private MGASimpleComboBox comboCurrencyCode;
  private Label label18;
  private MGATextBox textCheckLine4;
  private Panel ACHPanel;
  private Label label21;
  private Label label20;
  private Label label22;
  private MGATextBox textBankACHCompanyName;
  private MGATextBox textBankACHCompanyID;
  private Label label23;
  private Label label24;
  private MGATextBox textBankACHImmedOrgin;
  private MGATextBox textBankACHImmedDest;
  private Label label26;
  private MGATextBox textBankACHImmedOrgName;
  private Label label25;
  private MGATextBox textBankACHImmedDestName;
  private Label label27;
  private CheckBox checkACHSettings;
  private Label label28;
  private MGATextBox textBankACHOrginatingDFI;
  private dsBankAccountSignatures dsBankAccountSignatures1;
  private Panel signaturePanel;
  private Label label31;
  private Label label30;
  private Label label29;
  private MGAButton buttonAddUserSignature;
  private MGATextBox textUserSignatureOrder;
  private MGAComboBox comboUserSignature;
  public UltraGrid gridBankSignatures;

  public FormMasterBankAccount() => this.InitializeComponent();

  public FormMasterBankAccount(int glMasterId)
  {
    this.InitializeComponent();
    this._passedGLMasterAcctId = glMasterId;
  }

  private void GetBankAccountTypes()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand selectCommand = new SqlCommand("spfin_GetBankAccountTypes", connection))
      {
        selectCommand.CommandType = CommandType.StoredProcedure;
        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
          sqlDataAdapter.Fill((DataTable) this.dsBankAccountTypes1.BankAccountTypes);
      }
    }
  }

  internal string BankName => ((Control) this.textBankName).Text;

  internal string AccountType => this.comboAccountType.Value.ToString();

  internal string AccountNumber => ((Control) this.textAccountNumber).Text;

  internal string CheckRoutingNumber => ((Control) this.textABARoutingNumber).Text;

  internal string DepositRoutingNumber => ((Control) this.textDepositRoutingNumber).Text;

  internal string DepositSlipSuffix => ((Control) this.textDepositSlipSuffix).Text;

  internal string AbaFractional => ((Control) this.textABAFractional).Text;

  internal int NextCheckNumber => (int) this.numericNextCheckNumber.Value;

  internal string ISOCountryCode => this.addressBankAddress.ISOCountryCode;

  internal string Address1 => this.addressBankAddress.Address1;

  internal string Address2 => this.addressBankAddress.Address2;

  internal string City => this.addressBankAddress.City;

  internal string State => this.addressBankAddress.State;

  internal string ZipCode => this.addressBankAddress.ZipCode;

  internal string ZipPlus => this.addressBankAddress.ZipCodeExtension;

  internal string County => this.addressBankAddress.County;

  internal string ContactName => ((Control) this.textBankContactName).Text;

  internal string ContactEmail => ((Control) this.textBankContactEmail).Text;

  internal string ContactPhone => ((Control) this.textBankContactPhone).Text;

  internal string ContactFax => ((Control) this.textBankContactFax).Text;

  internal string CurrencyCode
  {
    get
    {
      if (((UltraDropDownBase) this.comboCurrencyCode).SelectedRow == null)
        this.comboCurrencyCode.Value = (object) "USD";
      return this.comboCurrencyCode.Value.ToString();
    }
  }

  internal string CheckText1 => ((Control) this.textCheckLine1).Text;

  internal string CheckText2 => ((Control) this.textCheckLine2).Text;

  internal string CheckText3 => ((Control) this.textCheckLine3).Text;

  internal string CheckText4 => ((Control) this.textCheckLine4).Text;

  internal bool UseACH => this.checkACHSettings.Checked;

  internal string CompanyID => ((Control) this.textBankACHCompanyID).Text;

  internal new string CompanyName => ((Control) this.textBankACHCompanyName).Text;

  internal string ImmediateDest => ((Control) this.textBankACHImmedDest).Text;

  internal string ImmediateDestName => ((Control) this.textBankACHImmedDestName).Text;

  internal string ImmediateOrgin => ((Control) this.textBankACHImmedOrgin).Text;

  internal string ImmediateOrginName => ((Control) this.textBankACHImmedOrgName).Text;

  internal string OrginatingDFI => ((Control) this.textBankACHOrginatingDFI).Text;

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "Save":
        if (!this.ValidateEntry())
          break;
        this.DialogResult = DialogResult.OK;
        this.Close();
        break;
      case "Cancel":
        this.DialogResult = DialogResult.Cancel;
        this.Close();
        break;
      case "DELETESIGNATURE":
        this.DeleteBankSignature();
        ((UltraDropDownBase) this.comboUserSignature).SelectedRow = (UltraGridRow) null;
        this.LoadSignatures(this.AccountNumber);
        this.SetSignatureOrder();
        break;
    }
  }

  private void SetAddressResolverConnectionProperties()
  {
    this.addressBankAddress.WebserviceUrl = AddressResolverSettings.AddressResolverURL;
    this.addressBankAddress.UserID = AddressResolverSettings.AddressResolveUserName;
    this.addressBankAddress.Password = AddressResolverSettings.AddressResolverPassword;
  }

  private bool ValidateEntry()
  {
    if (((Control) this.textBankName).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show(Resources.BANKACCOUNTERROR_BANKNAME_MISSING, Resources.ERROR_REQUIRED_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textAccountNumber).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show(Resources.BANKACCOUNTERROR_ACCOUNTNUMBER_MISSING, Resources.ERROR_REQUIRED_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.checkNextCheckNumber.Checked && this.numericNextCheckNumber.Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show(Resources.BANKACCOUNTERROR_CHECKNUMBER_MISSING, Resources.ERROR_REQUIRED_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.addressBankAddress.Address1.Equals(string.Empty) || this.addressBankAddress.City.Equals(string.Empty) || this.addressBankAddress.ZipCode.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show(Resources.BANKACCOUNTERROR_ADDRESS_MISSING, Resources.ERROR_REQUIRED_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textABARoutingNumber).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show(Resources.BANKACCOUNTERROR_ROUTINGNUMBER_MISSING, Resources.ERROR_REQUIRED_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textABARoutingNumber).Text.Length != 9)
    {
      int num = (int) MessageBox.Show(Resources.BANKACCOUNTERROR_ROUTINGNUMBER_INVALID, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textDepositRoutingNumber).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show(Resources.BANKACCOUNTERROR_DEPOSITROUTING_MISSING, Resources.ERROR_REQUIRED_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textDepositRoutingNumber).Text.Length == 9)
      return true;
    int num1 = (int) MessageBox.Show(Resources.BANKACCOUNTERROR_DEPOSITROUTING_INVALID, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void textBankName_Enter(object sender, EventArgs e)
  {
    this._oldBankNameValue = ((Control) this.textBankName).Text;
  }

  private void textBankName_Leave(object sender, EventArgs e)
  {
    if (string.IsNullOrEmpty(((Control) this.textBankName).Text) || !(((Control) this.textBankName).Text.ToLower() != this._oldBankNameValue.ToLower()) || !MGASystems.IMS.Accounting.Analysis.Utilities.Utilities.BankAccountExists(((Control) this.textBankName).Text) || MessageBox.Show(Resources.QUESTION_BANKNAMEFOUND, Resources.QUESTION_BANKNAMEFOUND_HEADER, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.DisplayBankInformation(((Control) this.textBankName).Text);
  }

  private void DisplayBankInformation(string bankName)
  {
    DataSet dataSet = DefaultDatabase.ExecuteDataSet("spFin_GLMasterGetBankInformation", new object[2]
    {
      (object) "@bankName",
      (object) bankName
    });
    if (dataSet.Tables[0].Rows.Count == 0)
      return;
    if (dataSet.Tables[0].Rows.Count == 1)
      this.DoDisplayBankInformation(dataSet.Tables[0].Rows[0]);
    else
      this.DoDisplayBankInformation(dataSet.Tables[0].Rows[0]);
  }

  private void DoDisplayBankInformation(DataRow dr)
  {
    this.addressBankAddress.Address1 = dr["Addr1"].ToString();
    this.addressBankAddress.Address2 = dr["Addr2"].ToString();
    this.addressBankAddress.City = dr["City"].ToString();
    this.addressBankAddress.State = dr["State"].ToString();
    this.addressBankAddress.ZipCode = dr["Zip"].ToString();
    this.addressBankAddress.ZipCodeExtension = dr["ZipPlus"].ToString();
    this.addressBankAddress.ISOCountryCode = dr["ISOCountryCode"].ToString();
    ((Control) this.textBankContactName).Text = dr["ContactName"].ToString();
    ((Control) this.textBankContactPhone).Text = dr["ContactPhone"].ToString();
    ((Control) this.textBankContactEmail).Text = dr["ContactEmail"].ToString();
    ((Control) this.textBankContactFax).Text = dr["ContactFax"].ToString();
    ((Control) this.textABAFractional).Text = dr["ABAFractionalTransitNum"].ToString();
    ((Control) this.textABARoutingNumber).Text = dr["ABARouteNum"].ToString();
    ((Control) this.textDepositRoutingNumber).Text = dr["DepositRoutingNumber"].ToString();
    ((Control) this.textDepositSlipSuffix).Text = dr["DepositSlipSuffix"].ToString();
    ((Control) this.textCheckLine1).Text = dr["CheckText1"].ToString();
    ((Control) this.textCheckLine2).Text = dr["CheckText2"].ToString();
    ((Control) this.textCheckLine3).Text = dr["CheckText3"].ToString();
    ((Control) this.textCheckLine4).Text = dr["CheckText4"].ToString();
    this.comboCurrencyCode.Value = (object) dr["CurrencyCode"].ToString();
    this.numericNextCheckNumber.Value = (Decimal) (!dr.Field<int?>("nextchecknum").HasValue ? new int?(101).Value : dr.Field<int?>("nextchecknum").Value);
  }

  private void GetExistingBankInformation(int glMasterId)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spFIn_GLMasterGetExistingBank", new object[2]
    {
      (object) "@GLMasterId",
      (object) glMasterId
    });
    if (dataTable.Rows.Count == 0)
      return;
    ((Control) this.textBankName).Text = dataTable.Rows[0]["BankName"].ToString();
    this.comboAccountType.Value = (object) dataTable.Rows[0]["BankAcctTypeId"].ToString();
    ((Control) this.textAccountNumber).Text = dataTable.Rows[0]["BankAcctNum"].ToString();
    this.DoDisplayBankInformation(dataTable.Rows[0]);
    this.DisplayACHBankInformation(dataTable.Rows[0]["BankAcctNum"].ToString());
  }

  private void DisplayACHBankInformation(string BankAcctNum)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spFin_GetACHBankInformation", new object[2]
    {
      (object) "@BankAcctNum",
      (object) BankAcctNum
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

  private void LoadCurrencyCode()
  {
    ((UltraGridBase) this.comboCurrencyCode).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_GetCurrencies");
    ((UltraDropDownBase) this.comboCurrencyCode).DisplayMember = "Currency";
    ((UltraDropDownBase) this.comboCurrencyCode).ValueMember = "CurrencyCode";
    this.comboCurrencyCode.Value = (object) "USD";
  }

  private void SetSignatureOrder()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridBankSignatures).Rows).Count == 0)
      ((Control) this.textUserSignatureOrder).Text = "1";
    else
      ((Control) this.textUserSignatureOrder).Text = (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridBankSignatures).Rows).Count + 1).ToString();
  }

  private void LoadSignatures(string accountNumber)
  {
    this.dsBankAccountSignatures1.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsBankAccountSignatures1, new string[1]
    {
      "BankAccountSignatures"
    }, "spFin_GetBankCheckSignatures", new object[2]
    {
      (object) "@AccountNumber",
      (object) accountNumber
    });
  }

  private void LoadAvailableSignatureUsers(string accountNumber)
  {
    ((UltraGridBase) this.comboUserSignature).DataSource = (object) DefaultDatabase.ExecuteDataSet("dbo.spFin_GetGlOfficeUserSignatures");
    ((UltraDropDownBase) this.comboUserSignature).DisplayMember = "UserName";
    ((UltraDropDownBase) this.comboUserSignature).ValueMember = "userGuid";
    this.comboUserSignature.DisplayLayout.Bands[0].ColHeadersVisible = false;
    this.comboUserSignature.DisplayLayout.Bands[0].Columns[0].Hidden = true;
    this.comboUserSignature.DisplayLayout.Bands[0].Columns[1].Width = 300;
  }

  private bool MultipleGLCompanys(string accountNumber)
  {
    return DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "Select dbo.CheckBankAcctGlCompany(@AccountNumber)", new object[2]
    {
      (object) "@AccountNumber",
      (object) accountNumber
    });
  }

  private void buttonAddUserSignature_Click(object sender, EventArgs e)
  {
    if (this.MultipleGLCompanys(this.AccountNumber))
    {
      if (MessageBox.Show("Would you like to use the same the signature for all the Office Locations that use this Bank Account?", "Set Signature for All Office Locations", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        if (!this.VerifySignature())
          return;
        DefaultDatabase.ExecuteNonQuery("dbo.spfin_SaveCheckUserSignature", new object[8]
        {
          (object) "@GLMasterAccountNumber",
          (object) this.AccountNumber,
          (object) "@userGuid",
          this.comboUserSignature.Value,
          (object) "@enteredBy",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@signOrder",
          (object) (int) ((TextEditorControlBase) this.textUserSignatureOrder).Value
        });
        ((UltraDropDownBase) this.comboUserSignature).SelectedRow = (UltraGridRow) null;
        this.LoadSignatures(this.AccountNumber);
        this.SetSignatureOrder();
      }
    }
    else
    {
      if (!this.VerifySignature())
        return;
      DefaultDatabase.ExecuteNonQuery("dbo.spfin_SaveCheckUserSignature", new object[8]
      {
        (object) "@GLMasterAccountNumber",
        (object) this.AccountNumber,
        (object) "@userGuid",
        this.comboUserSignature.Value,
        (object) "@enteredBy",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@signOrder",
        ((TextEditorControlBase) this.textUserSignatureOrder).Value
      });
      ((UltraDropDownBase) this.comboUserSignature).SelectedRow = (UltraGridRow) null;
      this.LoadSignatures(this.AccountNumber);
      this.SetSignatureOrder();
    }
  }

  private bool VerifySignature()
  {
    if (((Control) this.textUserSignatureOrder).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show(Resources.BANKACCOUNTERROR_BANKSIGNATUREORDER_MISSING, Resources.ERROR_REQUIRED_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!int.TryParse(((Control) this.textUserSignatureOrder).Text.ToString(), out int _))
    {
      int num = (int) MessageBox.Show(Resources.BANKACCOUNTERROR_BANKSIGNATUREORDER_NOTNUMERIC, Resources.ERROR_REQUIRED_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboUserSignature).SelectedRow != null)
      return true;
    int num1 = (int) MessageBox.Show(Resources.BANKACCOUNTERROR_BANKSIGNATURENAME_MISSING, Resources.ERROR_REQUIRED_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void DeleteBankSignature()
  {
    UltraGridRow activeRow = ((UltraGridBase) this.gridBankSignatures).ActiveRow;
    DefaultDatabase.ExecuteNonQuery("dbo.spFin_DeleteCheckUserSignature", new object[4]
    {
      (object) "@glAcctId",
      activeRow.Cells["GLAcctId"].Value,
      (object) "@userGuid",
      activeRow.Cells["UserGuid"].Value
    });
  }

  private void gridBankSignatures_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Right)
      return;
    if (((UIElement) ((UltraGridBase) this.gridBankSignatures).DisplayLayout.UIElement).ElementFromPoint(e.Location).GetContext(typeof (UltraGridRow)) is UltraGridRow context && context.IsDataRow)
    {
      ((UltraGridBase) this.gridBankSignatures).ActiveRow = context;
      if (((GridItemBase) context).Selected)
        return;
      this.gridBankSignatures.Selected.Rows.Clear();
      ((GridItemBase) context).Selected = true;
    }
    else
      this.gridBankSignatures.Selected.Rows.Clear();
  }

  private void FormMasterBankAccount_Load(object sender, EventArgs e)
  {
    this.GetBankAccountTypes();
    this.SetAddressResolverConnectionProperties();
    this.LoadCurrencyCode();
    if (this._passedGLMasterAcctId == -1)
      return;
    this.DoEnableSignatureFields(true);
    this.GetExistingBankInformation(this._passedGLMasterAcctId);
    this.DoEnableSignatureFields(true);
    this.LoadSignatures(this.AccountNumber);
    this.LoadAvailableSignatureUsers(this.AccountNumber);
    this.SetSignatureOrder();
  }

  private void mgaTextBox1_ValueChanged(object sender, EventArgs e)
  {
  }

  private void mgaTextBox2_ValueChanged(object sender, EventArgs e)
  {
  }

  private void checkACHSettings_CheckedChanged(object sender, EventArgs e)
  {
    if (this.checkACHSettings.Checked)
      this.DoEnableACHFields(true);
    else
      this.DoEnableACHFields(false);
  }

  private void DoEnableACHFields(bool value)
  {
    foreach (Control control in (ArrangedElementCollection) this.ACHPanel.Controls)
      control.Enabled = value;
  }

  private void DoEnableSignatureFields(bool value)
  {
    foreach (Control control in (ArrangedElementCollection) this.signaturePanel.Controls)
      control.Enabled = value;
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
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormMasterBankAccount));
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("Save");
    ButtonTool buttonTool2 = new ButtonTool("Cancel");
    Appearance appearance11 = new Appearance();
    ButtonTool buttonTool3 = new ButtonTool("Save");
    Appearance appearance12 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("Cancel");
    Appearance appearance13 = new Appearance();
    PopupMenuTool popupMenuTool = new PopupMenuTool("signatureGridPopupMenu");
    ButtonTool buttonTool5 = new ButtonTool("DELETESIGNATURE");
    ButtonTool buttonTool6 = new ButtonTool("DELETESIGNATURE");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("BankAccountSignatures", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("GLAcctId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("UserGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Name_FirstLast");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("SignOrder", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("EnteredBy");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("UpdatedDate");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("UserSignature");
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    UltraGridLayout ultraGridLayout = new UltraGridLayout("Layout1");
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("", -1);
    Appearance appearance30 = new Appearance();
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
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
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
    this.dsGLAccountTypes1 = new dsGLAccountTypes();
    this.imageList1 = new ImageList(this.components);
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.gridBankSignatures = new UltraGrid();
    this.dsBankAccountSignatures1 = new dsBankAccountSignatures();
    this.FormBackground_Fill_Panel = new Panel();
    this.signaturePanel = new Panel();
    this.label31 = new Label();
    this.label30 = new Label();
    this.comboUserSignature = new MGAComboBox();
    this.label29 = new Label();
    this.buttonAddUserSignature = new MGAButton();
    this.textUserSignatureOrder = new MGATextBox();
    this.label27 = new Label();
    this.checkACHSettings = new CheckBox();
    this.ACHPanel = new Panel();
    this.label28 = new Label();
    this.textBankACHOrginatingDFI = new MGATextBox();
    this.label26 = new Label();
    this.textBankACHImmedOrgName = new MGATextBox();
    this.label25 = new Label();
    this.textBankACHImmedDestName = new MGATextBox();
    this.label23 = new Label();
    this.label24 = new Label();
    this.textBankACHImmedOrgin = new MGATextBox();
    this.textBankACHImmedDest = new MGATextBox();
    this.label21 = new Label();
    this.label20 = new Label();
    this.label22 = new Label();
    this.textBankACHCompanyName = new MGATextBox();
    this.textBankACHCompanyID = new MGATextBox();
    this.label19 = new Label();
    this.comboCurrencyCode = new MGASimpleComboBox();
    this.label18 = new Label();
    this.textCheckLine4 = new MGATextBox();
    this.label16 = new Label();
    this.textCheckLine3 = new MGATextBox();
    this.label3 = new Label();
    this.label2 = new Label();
    this.label1 = new Label();
    this.textCheckLine2 = new MGATextBox();
    this.textCheckLine1 = new MGATextBox();
    this._FormBackground_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormBackground_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormBackground_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormBackground_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
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
    this.dsGLAccountTypes1.BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.gridBankSignatures).BeginInit();
    this.dsBankAccountSignatures1.BeginInit();
    this.FormBackground_Fill_Panel.SuspendLayout();
    this.signaturePanel.SuspendLayout();
    ((ISupportInitialize) this.comboUserSignature).BeginInit();
    ((ISupportInitialize) this.buttonAddUserSignature).BeginInit();
    ((ISupportInitialize) this.textUserSignatureOrder).BeginInit();
    this.ACHPanel.SuspendLayout();
    ((ISupportInitialize) this.textBankACHOrginatingDFI).BeginInit();
    ((ISupportInitialize) this.textBankACHImmedOrgName).BeginInit();
    ((ISupportInitialize) this.textBankACHImmedDestName).BeginInit();
    ((ISupportInitialize) this.textBankACHImmedOrgin).BeginInit();
    ((ISupportInitialize) this.textBankACHImmedDest).BeginInit();
    ((ISupportInitialize) this.textBankACHCompanyName).BeginInit();
    ((ISupportInitialize) this.textBankACHCompanyID).BeginInit();
    ((ISupportInitialize) this.comboCurrencyCode).BeginInit();
    ((ISupportInitialize) this.textCheckLine4).BeginInit();
    ((ISupportInitialize) this.textCheckLine3).BeginInit();
    ((ISupportInitialize) this.textCheckLine2).BeginInit();
    ((ISupportInitialize) this.textCheckLine1).BeginInit();
    this.SuspendLayout();
    this.label17.AutoSize = true;
    this.label17.BackColor = Color.Transparent;
    this.label17.ForeColor = Color.Black;
    this.label17.Location = new Point(5, 103);
    this.label17.Name = "label17";
    this.label17.Size = new Size(98, 13);
    this.label17.TabIndex = 8;
    this.label17.Text = "Deposit Routing #:";
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textDepositRoutingNumber).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textDepositRoutingNumber).BackColor = Color.White;
    ((Control) this.textDepositRoutingNumber).Location = new Point(117, 103);
    ((TextEditorControlBase) this.textDepositRoutingNumber).MaxLength = 9;
    this.textDepositRoutingNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textDepositRoutingNumber).Name = "textDepositRoutingNumber";
    ((Control) this.textDepositRoutingNumber).Size = new Size(136, 20);
    ((Control) this.textDepositRoutingNumber).TabIndex = 9;
    ((UltraControlBase) this.textDepositRoutingNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textDepositRoutingNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankName).Appearance = (AppearanceBase) appearance2;
    ((Control) this.textBankName).BackColor = Color.White;
    ((Control) this.textBankName).Location = new Point(117, 7);
    ((TextEditorControlBase) this.textBankName).MaxLength = 100;
    this.textBankName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankName).Name = "textBankName";
    ((Control) this.textBankName).Size = new Size(384, 20);
    ((Control) this.textBankName).TabIndex = 1;
    ((UltraControlBase) this.textBankName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankName).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textBankName).Enter += new EventHandler(this.textBankName_Enter);
    ((Control) this.textBankName).Leave += new EventHandler(this.textBankName_Leave);
    this.addressBankAddress.Address1 = "";
    this.addressBankAddress.Address2 = "";
    ((Control) this.addressBankAddress).BackColor = Color.Transparent;
    this.addressBankAddress.City = "";
    this.addressBankAddress.County = "";
    ((Control) this.addressBankAddress).Font = new Font("Tahoma", 8f);
    ((Control) this.addressBankAddress).Location = new Point(267, 42);
    this.addressBankAddress.MGAStyle = MGAStyles.Blue;
    ((Control) this.addressBankAddress).Name = "addressBankAddress";
    this.addressBankAddress.Password = (string) null;
    ((Control) this.addressBankAddress).Size = new Size(240 /*0xF0*/, 152);
    this.addressBankAddress.State = "";
    ((Control) this.addressBankAddress).TabIndex = 19;
    this.addressBankAddress.TextAlign = ContentAlignment.MiddleLeft;
    this.addressBankAddress.UserID = (string) null;
    this.addressBankAddress.WebserviceUrl = (string) null;
    this.addressBankAddress.ZipCode = "";
    this.addressBankAddress.ZipCodeExtension = "";
    this.label15.AutoSize = true;
    this.label15.BackColor = Color.Transparent;
    this.label15.ForeColor = Color.Black;
    this.label15.Location = new Point(5, 275);
    this.label15.Name = "label15";
    this.label15.Size = new Size(35, 13);
    this.label15.TabIndex = 23;
    this.label15.Text = "Email:";
    this.label14.AutoSize = true;
    this.label14.BackColor = Color.Transparent;
    this.label14.ForeColor = Color.Black;
    this.label14.Location = new Point(293, 275);
    this.label14.Name = "label14";
    this.label14.Size = new Size(29, 13);
    this.label14.TabIndex = 27;
    this.label14.Text = "Fax:";
    this.label13.AutoSize = true;
    this.label13.BackColor = Color.Transparent;
    this.label13.ForeColor = Color.Black;
    this.label13.Location = new Point(293, 251);
    this.label13.Name = "label13";
    this.label13.Size = new Size(41, 13);
    this.label13.TabIndex = 25;
    this.label13.Text = "Phone:";
    this.label12.AutoSize = true;
    this.label12.BackColor = Color.Transparent;
    this.label12.ForeColor = Color.Black;
    this.label12.Location = new Point(5, 251);
    this.label12.Name = "label12";
    this.label12.Size = new Size(38, 13);
    this.label12.TabIndex = 21;
    this.label12.Text = "Name:";
    this.label11.AutoSize = true;
    this.label11.BackColor = Color.Transparent;
    this.label11.Font = new Font("Tahoma", 8f, FontStyle.Underline);
    this.label11.ForeColor = Color.Black;
    this.label11.Location = new Point(5, 227);
    this.label11.Name = "label11";
    this.label11.Size = new Size(130, 13);
    this.label11.TabIndex = 20;
    this.label11.Text = "Bank Contact Information";
    this.label10.AutoSize = true;
    this.label10.BackColor = Color.Transparent;
    this.label10.ForeColor = Color.Black;
    this.label10.Location = new Point(5, 175);
    this.label10.Name = "label10";
    this.label10.Size = new Size(97, 13);
    this.label10.TabIndex = 15;
    this.label10.Text = "Deposit Slip Suffix:";
    this.label9.AutoSize = true;
    this.label9.BackColor = Color.Transparent;
    this.label9.ForeColor = Color.Black;
    this.label9.Location = new Point(5, 151);
    this.label9.Name = "label9";
    this.label9.Size = new Size(92, 13);
    this.label9.TabIndex = 13;
    this.label9.Text = "ABA Fractional #:";
    this.label8.AutoSize = true;
    this.label8.BackColor = Color.Transparent;
    this.label8.ForeColor = Color.Black;
    this.label8.Location = new Point(5, (int) sbyte.MaxValue);
    this.label8.Name = "label8";
    this.label8.Size = new Size(106, 13);
    this.label8.TabIndex = 10;
    this.label8.Text = "Next Check Number:";
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textABAFractional).Appearance = (AppearanceBase) appearance3;
    ((Control) this.textABAFractional).BackColor = Color.White;
    ((Control) this.textABAFractional).Location = new Point(117, 151);
    ((TextEditorControlBase) this.textABAFractional).MaxLength = 20;
    this.textABAFractional.MGAStyle = MGAStyles.Blue;
    ((Control) this.textABAFractional).Name = "textABAFractional";
    ((Control) this.textABAFractional).Size = new Size(136, 20);
    ((Control) this.textABAFractional).TabIndex = 14;
    ((UltraControlBase) this.textABAFractional).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textABAFractional).UseOsThemes = (DefaultableBoolean) 2;
    this.numericNextCheckNumber.BorderStyle = BorderStyle.FixedSingle;
    this.numericNextCheckNumber.ForeColor = Color.Black;
    this.numericNextCheckNumber.Location = new Point(133, (int) sbyte.MaxValue);
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
    this.numericNextCheckNumber.Size = new Size(120, 21);
    this.numericNextCheckNumber.TabIndex = 12;
    this.numericNextCheckNumber.TextAlign = HorizontalAlignment.Right;
    this.numericNextCheckNumber.Value = new Decimal(new int[4]
    {
      101,
      0,
      0,
      0
    });
    this.checkNextCheckNumber.BackColor = Color.Transparent;
    this.checkNextCheckNumber.Checked = true;
    this.checkNextCheckNumber.CheckState = CheckState.Checked;
    this.checkNextCheckNumber.FlatStyle = FlatStyle.Flat;
    this.checkNextCheckNumber.Location = new Point(117, (int) sbyte.MaxValue);
    this.checkNextCheckNumber.Name = "checkNextCheckNumber";
    this.checkNextCheckNumber.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.checkNextCheckNumber.TabIndex = 11;
    this.checkNextCheckNumber.UseVisualStyleBackColor = false;
    this.label7.AutoSize = true;
    this.label7.BackColor = Color.Transparent;
    this.label7.ForeColor = Color.Black;
    this.label7.Location = new Point(5, 55);
    this.label7.Name = "label7";
    this.label7.Size = new Size(90, 13);
    this.label7.TabIndex = 4;
    this.label7.Text = "Account Number:";
    this.label6.AutoSize = true;
    this.label6.BackColor = Color.Transparent;
    this.label6.ForeColor = Color.Black;
    this.label6.Location = new Point(5, 79);
    this.label6.Name = "label6";
    this.label6.Size = new Size(91, 13);
    this.label6.TabIndex = 6;
    this.label6.Text = "Check Routing #:";
    this.label5.AutoSize = true;
    this.label5.BackColor = Color.Transparent;
    this.label5.ForeColor = Color.Black;
    this.label5.Location = new Point(5, 31 /*0x1F*/);
    this.label5.Name = "label5";
    this.label5.Size = new Size(77, 13);
    this.label5.TabIndex = 2;
    this.label5.Text = "Account Type:";
    this.label4.AutoSize = true;
    this.label4.BackColor = Color.Transparent;
    this.label4.ForeColor = Color.Black;
    this.label4.Location = new Point(5, 7);
    this.label4.Name = "label4";
    this.label4.Size = new Size(64 /*0x40*/, 13);
    this.label4.TabIndex = 0;
    this.label4.Text = "Bank Name:";
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankContactFax).Appearance = (AppearanceBase) appearance4;
    ((Control) this.textBankContactFax).BackColor = Color.White;
    ((Control) this.textBankContactFax).Location = new Point(333, 275);
    ((TextEditorControlBase) this.textBankContactFax).MaxLength = 20;
    this.textBankContactFax.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankContactFax).Name = "textBankContactFax";
    ((Control) this.textBankContactFax).Size = new Size(168, 20);
    ((Control) this.textBankContactFax).TabIndex = 28;
    ((UltraControlBase) this.textBankContactFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankContactFax).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankContactPhone).Appearance = (AppearanceBase) appearance5;
    ((Control) this.textBankContactPhone).BackColor = Color.White;
    ((Control) this.textBankContactPhone).Location = new Point(333, 248);
    ((TextEditorControlBase) this.textBankContactPhone).MaxLength = 20;
    this.textBankContactPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankContactPhone).Name = "textBankContactPhone";
    ((Control) this.textBankContactPhone).Size = new Size(168, 20);
    ((Control) this.textBankContactPhone).TabIndex = 26;
    ((UltraControlBase) this.textBankContactPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankContactPhone).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankContactEmail).Appearance = (AppearanceBase) appearance6;
    ((Control) this.textBankContactEmail).BackColor = Color.White;
    ((Control) this.textBankContactEmail).Location = new Point(61, 275);
    ((TextEditorControlBase) this.textBankContactEmail).MaxLength = 40;
    this.textBankContactEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankContactEmail).Name = "textBankContactEmail";
    ((Control) this.textBankContactEmail).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.textBankContactEmail).TabIndex = 24;
    ((UltraControlBase) this.textBankContactEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankContactEmail).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankContactName).Appearance = (AppearanceBase) appearance7;
    ((Control) this.textBankContactName).BackColor = Color.White;
    ((Control) this.textBankContactName).Location = new Point(61, 251);
    ((TextEditorControlBase) this.textBankContactName).MaxLength = 25;
    this.textBankContactName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankContactName).Name = "textBankContactName";
    ((Control) this.textBankContactName).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.textBankContactName).TabIndex = 22;
    ((UltraControlBase) this.textBankContactName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankContactName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textDepositSlipSuffix).Appearance = (AppearanceBase) appearance8;
    ((Control) this.textDepositSlipSuffix).BackColor = Color.White;
    ((Control) this.textDepositSlipSuffix).Location = new Point(117, 175);
    ((TextEditorControlBase) this.textDepositSlipSuffix).MaxLength = 5;
    this.textDepositSlipSuffix.MGAStyle = MGAStyles.Blue;
    ((Control) this.textDepositSlipSuffix).Name = "textDepositSlipSuffix";
    ((Control) this.textDepositSlipSuffix).Size = new Size(136, 20);
    ((Control) this.textDepositSlipSuffix).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.textDepositSlipSuffix).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textDepositSlipSuffix).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textABARoutingNumber).Appearance = (AppearanceBase) appearance9;
    ((Control) this.textABARoutingNumber).BackColor = Color.White;
    ((Control) this.textABARoutingNumber).Location = new Point(117, 79);
    ((TextEditorControlBase) this.textABARoutingNumber).MaxLength = 9;
    this.textABARoutingNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textABARoutingNumber).Name = "textABARoutingNumber";
    ((Control) this.textABARoutingNumber).Size = new Size(136, 20);
    ((Control) this.textABARoutingNumber).TabIndex = 7;
    ((UltraControlBase) this.textABARoutingNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textABARoutingNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textAccountNumber).Appearance = (AppearanceBase) appearance10;
    ((Control) this.textAccountNumber).BackColor = Color.White;
    ((Control) this.textAccountNumber).Location = new Point(117, 55);
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
    ((Control) this.comboAccountType).Location = new Point(117, 31 /*0x1F*/);
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
    this.dsGLAccountTypes1.DataSetName = "dsGLAccountTypes";
    this.dsGLAccountTypes1.Locale = new CultureInfo("en-US");
    this.dsGLAccountTypes1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.imageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imageList1.ImageStream");
    this.imageList1.TransparentColor = Color.Transparent;
    this.imageList1.Images.SetKeyName(0, "");
    this.imageList1.Images.SetKeyName(1, "");
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (FormBase);
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
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
    ultraToolbar.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.Settings.ToolOrientation = (ToolOrientation) 2;
    ((ToolbarSettingsBase) ultraToolbar.Settings).ToolSpacing = 5;
    ultraToolbar.Text = "UltraToolbar1";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    this.ultraToolbarsManager1.ToolbarSettings.AllowCustomize = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockBottom = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockLeft = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockRight = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockTop = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowFloating = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowHiding = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance11).BackColor2 = Color.White;
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 26;
    ((SettingsBase) this.ultraToolbarsManager1.ToolbarSettings).Appearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).Image = (object) Resources.disk;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance12;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Save";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance13).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance13;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "signatureGridPopupMenu";
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool5
    });
    ((AppearanceBase) appearance14).Image = (object) Resources.cross;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance14;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "Delete Signature";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool6
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridBankSignatures, "signatureGridPopupMenu");
    ((UltraGridBase) this.gridBankSignatures).DataSource = (object) this.dsBankAccountSignatures1;
    ((AppearanceBase) appearance15).BackColor = Color.White;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.Appearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 33;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 133;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Signature";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 317;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Signature Order";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 168;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 154;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 82;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 130;
    ultraGridBand1.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ultraGridBand1.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand1.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand1.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand1.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand1.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand1.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand1.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ultraGridBand1.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridBand1.Override.RowSelectors = (DefaultableBoolean) 2;
    ultraGridBand1.SummaryFooterCaption = "";
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance16).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance17).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.Override.SummaryFooterAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance21).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridBankSignatures).DisplayLayout.Override.SummaryValueAppearance = (AppearanceBase) appearance21;
    ((Control) this.gridBankSignatures).Font = new Font("Tahoma", 8.25f);
    ((AppearanceBase) appearance22).BackColor = Color.White;
    ((AppearanceBase) appearance22).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance22).ForeColor = Color.Black;
    ultraGridLayout.Appearance = (AppearanceBase) appearance22;
    ultraGridLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout).Key = "Layout1";
    ultraGridLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance23).BorderColor = Color.Silver;
    ultraGridLayout.Override.CellAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout.Override.HeaderAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).BorderColor = Color.Silver;
    ultraGridLayout.Override.RowAppearance = (AppearanceBase) appearance26;
    ((AppearanceBase) appearance27).BackColor = Color.LightSteelBlue;
    ultraGridLayout.Override.SummaryFooterAppearance = (AppearanceBase) appearance27;
    ultraGridLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance28).BackColor = Color.LightSteelBlue;
    ultraGridLayout.Override.SummaryValueAppearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.gridBankSignatures).Layouts.Add(ultraGridLayout);
    ((Control) this.gridBankSignatures).Location = new Point(4, 63 /*0x3F*/);
    ((Control) this.gridBankSignatures).Name = "gridBankSignatures";
    ((Control) this.gridBankSignatures).Size = new Size(487, 120);
    ((Control) this.gridBankSignatures).TabIndex = 60;
    this.gridBankSignatures.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridBankSignatures).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridBankSignatures).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridBankSignatures).MouseDown += new MouseEventHandler(this.gridBankSignatures_MouseDown);
    this.dsBankAccountSignatures1.DataSetName = "dsBankAccountSignatures";
    this.dsBankAccountSignatures1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.FormBackground_Fill_Panel.BackColor = Color.Transparent;
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.signaturePanel);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label27);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.checkACHSettings);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.ACHPanel);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label19);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.comboCurrencyCode);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label18);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.textCheckLine4);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label16);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.textCheckLine3);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label3);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label2);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label1);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.textCheckLine2);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.textCheckLine1);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.textBankContactPhone);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label17);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.textDepositRoutingNumber);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.textBankName);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.addressBankAddress);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label15);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label14);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label13);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label12);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label11);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label10);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label9);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label8);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.textABAFractional);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.numericNextCheckNumber);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.checkNextCheckNumber);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label7);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label6);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label5);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.label4);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.textBankContactFax);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.textBankContactEmail);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.textBankContactName);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.textDepositSlipSuffix);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.textABARoutingNumber);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.textAccountNumber);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.comboAccountType);
    this.FormBackground_Fill_Panel.Cursor = Cursors.Default;
    this.FormBackground_Fill_Panel.Dock = DockStyle.Fill;
    this.FormBackground_Fill_Panel.Location = new Point(0, 46);
    this.FormBackground_Fill_Panel.Name = "FormBackground_Fill_Panel";
    this.FormBackground_Fill_Panel.Size = new Size(507, 749);
    this.FormBackground_Fill_Panel.TabIndex = 0;
    this.signaturePanel.Controls.Add((Control) this.gridBankSignatures);
    this.signaturePanel.Controls.Add((Control) this.label31);
    this.signaturePanel.Controls.Add((Control) this.label30);
    this.signaturePanel.Controls.Add((Control) this.comboUserSignature);
    this.signaturePanel.Controls.Add((Control) this.label29);
    this.signaturePanel.Controls.Add((Control) this.buttonAddUserSignature);
    this.signaturePanel.Controls.Add((Control) this.textUserSignatureOrder);
    this.signaturePanel.Location = new Point(4, 556);
    this.signaturePanel.Name = "signaturePanel";
    this.signaturePanel.Size = new Size(497, 188);
    this.signaturePanel.TabIndex = 42;
    this.label31.AutoSize = true;
    this.label31.BackColor = Color.Transparent;
    this.label31.Font = new Font("Tahoma", 8f, FontStyle.Underline);
    this.label31.ForeColor = Color.Black;
    this.label31.Location = new Point(3, 6);
    this.label31.Name = "label31";
    this.label31.Size = new Size(105, 13);
    this.label31.TabIndex = 54;
    this.label31.Text = "Bank Signature Data";
    this.label30.AutoSize = true;
    this.label30.Location = new Point(260, 30);
    this.label30.Name = "label30";
    this.label30.Size = new Size(39, 13);
    this.label30.TabIndex = 57;
    this.label30.Text = "Order:";
    this.comboUserSignature.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance29).BackColor = Color.White;
    ((AppearanceBase) appearance29).BorderColor = Color.FromArgb(78, 122, 171);
    this.comboUserSignature.DisplayLayout.Appearance = (AppearanceBase) appearance29;
    this.comboUserSignature.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    this.comboUserSignature.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.comboUserSignature.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.comboUserSignature.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance30).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance30).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance30).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance30).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.comboUserSignature.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).ForeColor = SystemColors.GrayText;
    this.comboUserSignature.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance31;
    ((SpecialBoxBase) this.comboUserSignature.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance32).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance32).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance32).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance32).ForeColor = SystemColors.GrayText;
    this.comboUserSignature.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance32;
    this.comboUserSignature.DisplayLayout.MaxColScrollRegions = 1;
    this.comboUserSignature.DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance33).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance33).ForeColor = SystemColors.ControlText;
    this.comboUserSignature.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance33;
    ((AppearanceBase) appearance34).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance34).ForeColor = SystemColors.HighlightText;
    this.comboUserSignature.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance34;
    this.comboUserSignature.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.comboUserSignature.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance35).BackColor = SystemColors.Window;
    this.comboUserSignature.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance35;
    ((AppearanceBase) appearance36).BorderColor = Color.Silver;
    ((AppearanceBase) appearance36).TextTrimming = (TextTrimming) 3;
    this.comboUserSignature.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance36;
    this.comboUserSignature.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.comboUserSignature.DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance37).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance37).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance37).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance37).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance37).BorderColor = SystemColors.Window;
    this.comboUserSignature.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).TextHAlignAsString = "Left";
    this.comboUserSignature.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance38;
    this.comboUserSignature.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.comboUserSignature.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance39).BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    ((AppearanceBase) appearance39).BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.comboUserSignature.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance39;
    ((AppearanceBase) appearance40).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance40).BorderColor = Color.White;
    this.comboUserSignature.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance40;
    this.comboUserSignature.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.comboUserSignature.DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance41).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance41).BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    ((AppearanceBase) appearance41).ForeColor = Color.Black;
    this.comboUserSignature.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance41;
    ((AppearanceBase) appearance42).BackColor = SystemColors.ControlLight;
    this.comboUserSignature.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance42;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.comboUserSignature.DisplayLayout.ScrollBarLook = scrollBarLook;
    this.comboUserSignature.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.comboUserSignature.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.comboUserSignature.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.comboUserSignature).DisplayMember = "UserName";
    this.comboUserSignature.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboUserSignature).Location = new Point(66, 31 /*0x1F*/);
    this.comboUserSignature.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboUserSignature).Name = "comboUserSignature";
    ((Control) this.comboUserSignature).Size = new Size(183, 21);
    ((Control) this.comboUserSignature).TabIndex = 56;
    ((UltraControlBase) this.comboUserSignature).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboUserSignature).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboUserSignature).ValueMember = "userGuid";
    this.label29.AutoSize = true;
    this.label29.Location = new Point(5, 30);
    this.label29.Name = "label29";
    this.label29.Size = new Size(57, 13);
    this.label29.TabIndex = 55;
    this.label29.Text = "Signature:";
    ((AppearanceBase) appearance43).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance43).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance43).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance43).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance43).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance43).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonAddUserSignature).Appearance = (AppearanceBase) appearance43;
    ((Control) this.buttonAddUserSignature).Location = new Point(360, 30);
    ((Control) this.buttonAddUserSignature).Name = "buttonAddUserSignature";
    ((Control) this.buttonAddUserSignature).Size = new Size(117, 21);
    ((Control) this.buttonAddUserSignature).TabIndex = 59;
    ((Control) this.buttonAddUserSignature).Text = "Add Signature";
    ((UltraControlBase) this.buttonAddUserSignature).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonAddUserSignature).Click += new EventHandler(this.buttonAddUserSignature_Click);
    ((AppearanceBase) appearance44).BackColor = Color.White;
    ((AppearanceBase) appearance44).BorderColor = Color.Gray;
    ((AppearanceBase) appearance44).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textUserSignatureOrder).Appearance = (AppearanceBase) appearance44;
    ((Control) this.textUserSignatureOrder).BackColor = Color.White;
    ((Control) this.textUserSignatureOrder).Location = new Point(305, 30);
    ((Control) this.textUserSignatureOrder).Name = "textUserSignatureOrder";
    ((Control) this.textUserSignatureOrder).Size = new Size(39, 20);
    ((Control) this.textUserSignatureOrder).TabIndex = 58;
    ((UltraControlBase) this.textUserSignatureOrder).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textUserSignatureOrder).UseOsThemes = (DefaultableBoolean) 2;
    this.label27.AutoSize = true;
    this.label27.BackColor = Color.Transparent;
    this.label27.ForeColor = Color.Black;
    this.label27.Location = new Point(276, 199);
    this.label27.Name = "label27";
    this.label27.Size = new Size(72, 13);
    this.label27.TabIndex = 40;
    this.label27.Text = "Use For ACH:";
    this.checkACHSettings.BackColor = Color.Transparent;
    this.checkACHSettings.Checked = true;
    this.checkACHSettings.CheckState = CheckState.Checked;
    this.checkACHSettings.FlatStyle = FlatStyle.Flat;
    this.checkACHSettings.Location = new Point(354, 196);
    this.checkACHSettings.Name = "checkACHSettings";
    this.checkACHSettings.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.checkACHSettings.TabIndex = 41;
    this.checkACHSettings.UseVisualStyleBackColor = false;
    this.checkACHSettings.CheckedChanged += new EventHandler(this.checkACHSettings_CheckedChanged);
    this.ACHPanel.Controls.Add((Control) this.label28);
    this.ACHPanel.Controls.Add((Control) this.textBankACHOrginatingDFI);
    this.ACHPanel.Controls.Add((Control) this.label26);
    this.ACHPanel.Controls.Add((Control) this.textBankACHImmedOrgName);
    this.ACHPanel.Controls.Add((Control) this.label25);
    this.ACHPanel.Controls.Add((Control) this.textBankACHImmedDestName);
    this.ACHPanel.Controls.Add((Control) this.label23);
    this.ACHPanel.Controls.Add((Control) this.label24);
    this.ACHPanel.Controls.Add((Control) this.textBankACHImmedOrgin);
    this.ACHPanel.Controls.Add((Control) this.textBankACHImmedDest);
    this.ACHPanel.Controls.Add((Control) this.label21);
    this.ACHPanel.Controls.Add((Control) this.label20);
    this.ACHPanel.Controls.Add((Control) this.label22);
    this.ACHPanel.Controls.Add((Control) this.textBankACHCompanyName);
    this.ACHPanel.Controls.Add((Control) this.textBankACHCompanyID);
    this.ACHPanel.Location = new Point(4, 422);
    this.ACHPanel.Name = "ACHPanel";
    this.ACHPanel.Size = new Size(497, (int) sbyte.MaxValue);
    this.ACHPanel.TabIndex = 39;
    this.label28.AutoSize = true;
    this.label28.BackColor = Color.Transparent;
    this.label28.ForeColor = Color.Black;
    this.label28.Location = new Point(3, 104);
    this.label28.Name = "label28";
    this.label28.Size = new Size(83, 13);
    this.label28.TabIndex = 52;
    this.label28.Text = "Originating DFI:";
    ((AppearanceBase) appearance45).BackColor = Color.White;
    ((AppearanceBase) appearance45).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance45).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankACHOrginatingDFI).Appearance = (AppearanceBase) appearance45;
    ((Control) this.textBankACHOrginatingDFI).BackColor = Color.White;
    ((Control) this.textBankACHOrginatingDFI).Location = new Point(93, 101);
    ((TextEditorControlBase) this.textBankACHOrginatingDFI).MaxLength = 40;
    this.textBankACHOrginatingDFI.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankACHOrginatingDFI).Name = "textBankACHOrginatingDFI";
    ((Control) this.textBankACHOrginatingDFI).Size = new Size(125, 20);
    ((Control) this.textBankACHOrginatingDFI).TabIndex = 53;
    ((UltraControlBase) this.textBankACHOrginatingDFI).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankACHOrginatingDFI).UseOsThemes = (DefaultableBoolean) 2;
    this.label26.AutoSize = true;
    this.label26.BackColor = Color.Transparent;
    this.label26.ForeColor = Color.Black;
    this.label26.Location = new Point(224 /*0xE0*/, 77);
    this.label26.Name = "label26";
    this.label26.Size = new Size(106, 13);
    this.label26.TabIndex = 50;
    this.label26.Text = "Immed. Orgin Name:";
    ((AppearanceBase) appearance46).BackColor = Color.White;
    ((AppearanceBase) appearance46).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance46).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankACHImmedOrgName).Appearance = (AppearanceBase) appearance46;
    ((Control) this.textBankACHImmedOrgName).BackColor = Color.White;
    ((Control) this.textBankACHImmedOrgName).Location = new Point(332, 74);
    ((TextEditorControlBase) this.textBankACHImmedOrgName).MaxLength = 40;
    this.textBankACHImmedOrgName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankACHImmedOrgName).Name = "textBankACHImmedOrgName";
    ((Control) this.textBankACHImmedOrgName).Size = new Size(162, 20);
    ((Control) this.textBankACHImmedOrgName).TabIndex = 51;
    ((UltraControlBase) this.textBankACHImmedOrgName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankACHImmedOrgName).UseOsThemes = (DefaultableBoolean) 2;
    this.label25.AutoSize = true;
    this.label25.BackColor = Color.Transparent;
    this.label25.ForeColor = Color.Black;
    this.label25.Location = new Point(224 /*0xE0*/, 51);
    this.label25.Name = "label25";
    this.label25.Size = new Size(106, 13);
    this.label25.TabIndex = 48 /*0x30*/;
    this.label25.Text = "Immed. Dest. Name:";
    ((AppearanceBase) appearance47).BackColor = Color.White;
    ((AppearanceBase) appearance47).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance47).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankACHImmedDestName).Appearance = (AppearanceBase) appearance47;
    ((Control) this.textBankACHImmedDestName).BackColor = Color.White;
    ((Control) this.textBankACHImmedDestName).Location = new Point(332, 47);
    ((TextEditorControlBase) this.textBankACHImmedDestName).MaxLength = 40;
    this.textBankACHImmedDestName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankACHImmedDestName).Name = "textBankACHImmedDestName";
    ((Control) this.textBankACHImmedDestName).Size = new Size(162, 20);
    ((Control) this.textBankACHImmedDestName).TabIndex = 49;
    ((UltraControlBase) this.textBankACHImmedDestName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankACHImmedDestName).UseOsThemes = (DefaultableBoolean) 2;
    this.label23.AutoSize = true;
    this.label23.BackColor = Color.Transparent;
    this.label23.ForeColor = Color.Black;
    this.label23.Location = new Point(3, 77);
    this.label23.Name = "label23";
    this.label23.Size = new Size(76, 13);
    this.label23.TabIndex = 46;
    this.label23.Text = "Immed. Orgin:";
    this.label24.AutoSize = true;
    this.label24.BackColor = Color.Transparent;
    this.label24.ForeColor = Color.Black;
    this.label24.Location = new Point(3, 54);
    this.label24.Name = "label24";
    this.label24.Size = new Size(72, 13);
    this.label24.TabIndex = 44;
    this.label24.Text = "Immed. Dest:";
    ((AppearanceBase) appearance48).BackColor = Color.White;
    ((AppearanceBase) appearance48).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance48).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankACHImmedOrgin).Appearance = (AppearanceBase) appearance48;
    ((Control) this.textBankACHImmedOrgin).BackColor = Color.White;
    ((Control) this.textBankACHImmedOrgin).Location = new Point(93, 77);
    ((TextEditorControlBase) this.textBankACHImmedOrgin).MaxLength = 40;
    this.textBankACHImmedOrgin.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankACHImmedOrgin).Name = "textBankACHImmedOrgin";
    ((Control) this.textBankACHImmedOrgin).Size = new Size(125, 20);
    ((Control) this.textBankACHImmedOrgin).TabIndex = 47;
    ((UltraControlBase) this.textBankACHImmedOrgin).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankACHImmedOrgin).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance49).BackColor = Color.White;
    ((AppearanceBase) appearance49).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance49).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankACHImmedDest).Appearance = (AppearanceBase) appearance49;
    ((Control) this.textBankACHImmedDest).BackColor = Color.White;
    ((Control) this.textBankACHImmedDest).Location = new Point(93, 51);
    ((TextEditorControlBase) this.textBankACHImmedDest).MaxLength = 25;
    this.textBankACHImmedDest.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankACHImmedDest).Name = "textBankACHImmedDest";
    ((Control) this.textBankACHImmedDest).Size = new Size(125, 20);
    ((Control) this.textBankACHImmedDest).TabIndex = 45;
    ((UltraControlBase) this.textBankACHImmedDest).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankACHImmedDest).UseOsThemes = (DefaultableBoolean) 2;
    this.label21.AutoSize = true;
    this.label21.BackColor = Color.Transparent;
    this.label21.ForeColor = Color.Black;
    this.label21.Location = new Point(224 /*0xE0*/, 25);
    this.label21.Name = "label21";
    this.label21.Size = new Size(86, 13);
    this.label21.TabIndex = 42;
    this.label21.Text = "Company Name:";
    this.label20.AutoSize = true;
    this.label20.BackColor = Color.Transparent;
    this.label20.Font = new Font("Tahoma", 8f, FontStyle.Underline);
    this.label20.ForeColor = Color.Black;
    this.label20.Location = new Point(3, 6);
    this.label20.Name = "label20";
    this.label20.Size = new Size(80 /*0x50*/, 13);
    this.label20.TabIndex = 38;
    this.label20.Text = "Bank ACH Data";
    this.label22.AutoSize = true;
    this.label22.BackColor = Color.Transparent;
    this.label22.ForeColor = Color.Black;
    this.label22.Location = new Point(1, 30);
    this.label22.Name = "label22";
    this.label22.Size = new Size(70, 13);
    this.label22.TabIndex = 40;
    this.label22.Text = "Company ID:";
    ((AppearanceBase) appearance50).BackColor = Color.White;
    ((AppearanceBase) appearance50).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance50).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankACHCompanyName).Appearance = (AppearanceBase) appearance50;
    ((Control) this.textBankACHCompanyName).BackColor = Color.White;
    ((Control) this.textBankACHCompanyName).Location = new Point(332, 21);
    ((TextEditorControlBase) this.textBankACHCompanyName).MaxLength = 40;
    this.textBankACHCompanyName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankACHCompanyName).Name = "textBankACHCompanyName";
    ((Control) this.textBankACHCompanyName).Size = new Size(162, 20);
    ((Control) this.textBankACHCompanyName).TabIndex = 43;
    ((UltraControlBase) this.textBankACHCompanyName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankACHCompanyName).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.textBankACHCompanyName).ValueChanged += new EventHandler(this.mgaTextBox1_ValueChanged);
    ((AppearanceBase) appearance51).BackColor = Color.White;
    ((AppearanceBase) appearance51).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance51).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankACHCompanyID).Appearance = (AppearanceBase) appearance51;
    ((Control) this.textBankACHCompanyID).BackColor = Color.White;
    ((Control) this.textBankACHCompanyID).Location = new Point(93, 25);
    ((TextEditorControlBase) this.textBankACHCompanyID).MaxLength = 25;
    this.textBankACHCompanyID.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankACHCompanyID).Name = "textBankACHCompanyID";
    ((Control) this.textBankACHCompanyID).Size = new Size(125, 20);
    ((Control) this.textBankACHCompanyID).TabIndex = 41;
    ((UltraControlBase) this.textBankACHCompanyID).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankACHCompanyID).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.textBankACHCompanyID).ValueChanged += new EventHandler(this.mgaTextBox2_ValueChanged);
    this.label19.AutoSize = true;
    this.label19.BackColor = Color.Transparent;
    this.label19.ForeColor = Color.Black;
    this.label19.Location = new Point(5, 199);
    this.label19.Name = "label19";
    this.label19.Size = new Size(83, 13);
    this.label19.TabIndex = 17;
    this.label19.Text = "Currency Code:";
    this.comboCurrencyCode.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboCurrencyCode).DataMember = "BankAccountTypes";
    ((UltraGridBase) this.comboCurrencyCode).DataSource = (object) this.dsBankAccountTypes1;
    ((UltraDropDownBase) this.comboCurrencyCode).DisplayMember = "BankAcctType";
    this.comboCurrencyCode.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCurrencyCode).Location = new Point(117, 199);
    this.comboCurrencyCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCurrencyCode).Name = "comboCurrencyCode";
    ((Control) this.comboCurrencyCode).Size = new Size(136, 21);
    ((Control) this.comboCurrencyCode).TabIndex = 18;
    ((UltraControlBase) this.comboCurrencyCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCurrencyCode).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboCurrencyCode).ValueMember = "BankAcctTypeId";
    this.label18.AutoSize = true;
    this.label18.BackColor = Color.Transparent;
    this.label18.ForeColor = Color.Black;
    this.label18.Location = new Point(5, 396);
    this.label18.Name = "label18";
    this.label18.Size = new Size(39, 13);
    this.label18.TabIndex = 36;
    this.label18.Text = "Line 4:";
    ((AppearanceBase) appearance52).BackColor = Color.White;
    ((AppearanceBase) appearance52).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance52).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCheckLine4).Appearance = (AppearanceBase) appearance52;
    ((Control) this.textCheckLine4).BackColor = Color.White;
    ((Control) this.textCheckLine4).Location = new Point(61, 396);
    ((TextEditorControlBase) this.textCheckLine4).MaxLength = 100;
    this.textCheckLine4.MGAStyle = MGAStyles.Blue;
    ((Control) this.textCheckLine4).Name = "textCheckLine4";
    ((Control) this.textCheckLine4).Size = new Size(440, 20);
    ((Control) this.textCheckLine4).TabIndex = 37;
    ((UltraControlBase) this.textCheckLine4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCheckLine4).UseOsThemes = (DefaultableBoolean) 2;
    this.label16.AutoSize = true;
    this.label16.BackColor = Color.Transparent;
    this.label16.ForeColor = Color.Black;
    this.label16.Location = new Point(5, 373);
    this.label16.Name = "label16";
    this.label16.Size = new Size(39, 13);
    this.label16.TabIndex = 34;
    this.label16.Text = "Line 3:";
    ((AppearanceBase) appearance53).BackColor = Color.White;
    ((AppearanceBase) appearance53).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance53).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCheckLine3).Appearance = (AppearanceBase) appearance53;
    ((Control) this.textCheckLine3).BackColor = Color.White;
    ((Control) this.textCheckLine3).Location = new Point(61, 373);
    ((TextEditorControlBase) this.textCheckLine3).MaxLength = 100;
    this.textCheckLine3.MGAStyle = MGAStyles.Blue;
    ((Control) this.textCheckLine3).Name = "textCheckLine3";
    ((Control) this.textCheckLine3).Size = new Size(440, 20);
    ((Control) this.textCheckLine3).TabIndex = 35;
    ((UltraControlBase) this.textCheckLine3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCheckLine3).UseOsThemes = (DefaultableBoolean) 2;
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.ForeColor = Color.Black;
    this.label3.Location = new Point(5, 350);
    this.label3.Name = "label3";
    this.label3.Size = new Size(39, 13);
    this.label3.TabIndex = 32 /*0x20*/;
    this.label3.Text = "Line 2:";
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.ForeColor = Color.Black;
    this.label2.Location = new Point(5, 328);
    this.label2.Name = "label2";
    this.label2.Size = new Size(39, 13);
    this.label2.TabIndex = 30;
    this.label2.Text = "Line 1:";
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Font = new Font("Tahoma", 8f, FontStyle.Underline);
    this.label1.ForeColor = Color.Black;
    this.label1.Location = new Point(5, 304);
    this.label1.Name = "label1";
    this.label1.Size = new Size(88, 13);
    this.label1.TabIndex = 29;
    this.label1.Text = "Bank Check Data";
    ((AppearanceBase) appearance54).BackColor = Color.White;
    ((AppearanceBase) appearance54).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance54).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCheckLine2).Appearance = (AppearanceBase) appearance54;
    ((Control) this.textCheckLine2).BackColor = Color.White;
    ((Control) this.textCheckLine2).Location = new Point(61, 350);
    ((TextEditorControlBase) this.textCheckLine2).MaxLength = 100;
    this.textCheckLine2.MGAStyle = MGAStyles.Blue;
    ((Control) this.textCheckLine2).Name = "textCheckLine2";
    ((Control) this.textCheckLine2).Size = new Size(440, 20);
    ((Control) this.textCheckLine2).TabIndex = 33;
    ((UltraControlBase) this.textCheckLine2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCheckLine2).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance55).BackColor = Color.White;
    ((AppearanceBase) appearance55).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance55).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCheckLine1).Appearance = (AppearanceBase) appearance55;
    ((Control) this.textCheckLine1).BackColor = Color.White;
    ((Control) this.textCheckLine1).Location = new Point(61, 328);
    ((TextEditorControlBase) this.textCheckLine1).MaxLength = 100;
    this.textCheckLine1.MGAStyle = MGAStyles.Blue;
    ((Control) this.textCheckLine1).Name = "textCheckLine1";
    ((Control) this.textCheckLine1).Size = new Size(440, 20);
    ((Control) this.textCheckLine1).TabIndex = 31 /*0x1F*/;
    ((UltraControlBase) this.textCheckLine1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCheckLine1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._FormBackground_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).Location = new Point(0, 46);
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).Name = "_FormBackground_Toolbars_Dock_Area_Left";
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).Size = new Size(0, 749);
    this._FormBackground_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._FormBackground_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).Location = new Point(507, 46);
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).Name = "_FormBackground_Toolbars_Dock_Area_Right";
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).Size = new Size(0, 749);
    this._FormBackground_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._FormBackground_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).Name = "_FormBackground_Toolbars_Dock_Area_Top";
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).Size = new Size(507, 46);
    this._FormBackground_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._FormBackground_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).Location = new Point(0, 795);
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).Name = "_FormBackground_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).Size = new Size(507, 0);
    this._FormBackground_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(507, 795);
    this.Controls.Add((Control) this.FormBackground_Fill_Panel);
    this.Controls.Add((Control) this._FormBackground_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormBackground_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormBackground_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormBackground_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormMasterBankAccount);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = " ";
    this.Load += new EventHandler(this.FormMasterBankAccount_Load);
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
    this.dsGLAccountTypes1.EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.gridBankSignatures).EndInit();
    this.dsBankAccountSignatures1.EndInit();
    this.FormBackground_Fill_Panel.ResumeLayout(false);
    this.FormBackground_Fill_Panel.PerformLayout();
    this.signaturePanel.ResumeLayout(false);
    this.signaturePanel.PerformLayout();
    ((ISupportInitialize) this.comboUserSignature).EndInit();
    ((ISupportInitialize) this.buttonAddUserSignature).EndInit();
    ((ISupportInitialize) this.textUserSignatureOrder).EndInit();
    this.ACHPanel.ResumeLayout(false);
    this.ACHPanel.PerformLayout();
    ((ISupportInitialize) this.textBankACHOrginatingDFI).EndInit();
    ((ISupportInitialize) this.textBankACHImmedOrgName).EndInit();
    ((ISupportInitialize) this.textBankACHImmedDestName).EndInit();
    ((ISupportInitialize) this.textBankACHImmedOrgin).EndInit();
    ((ISupportInitialize) this.textBankACHImmedDest).EndInit();
    ((ISupportInitialize) this.textBankACHCompanyName).EndInit();
    ((ISupportInitialize) this.textBankACHCompanyID).EndInit();
    ((ISupportInitialize) this.comboCurrencyCode).EndInit();
    ((ISupportInitialize) this.textCheckLine4).EndInit();
    ((ISupportInitialize) this.textCheckLine3).EndInit();
    ((ISupportInitialize) this.textCheckLine2).EndInit();
    ((ISupportInitialize) this.textCheckLine1).EndInit();
    this.ResumeLayout(false);
  }
}

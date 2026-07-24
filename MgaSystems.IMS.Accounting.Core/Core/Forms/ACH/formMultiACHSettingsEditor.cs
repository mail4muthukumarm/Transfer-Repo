// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.formMultiACHSettingsEditor
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using ChoETL;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Forms.ACH.DataAccess;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Utilities;
using MGASystems.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH;

public class formMultiACHSettingsEditor : FormBase
{
  private readonly formMultiACHSettingsEditor.ActiveRow _activeRow;
  private readonly bool _allowEdit = true;
  private DataSet _data;
  private bool _defaultChangeInProcess;
  private readonly List<int> _deletedAccountIds = new List<int>();
  private readonly List<int> _deletedBankIds = new List<int>();
  private Guid _entityGuid = Guid.Empty;
  private readonly bool _isLoadFromNewEntityGuid;
  private DataSet _paymentFormats;
  private DataSet _currencies;
  private readonly int _rowId;
  private bool _saveSucceeded;
  private readonly IMultiACHBankRepository _bankRepository = ObjectFactory.Instance.CreateObjectAs<IMultiACHBankRepository>();
  protected int _accountTabControlHeight = 275;
  protected int _accountTabHeight = 234;
  protected int _bankTabControlHeight = 518;
  protected string _getACHSettingProc = "dbo.spFin_GetACHSetting";
  protected string _saveACHSettingAccountProc = "dbo.spFin_SaveACHSetting_Account";
  protected string _updateACHSettingAccountProc = "dbo.spFin_UpdateACHSetting_Account";
  private PictureBox entitySearch;
  private MGATextBox entityName;
  private Label entityLabel;
  private UltraToolbarsManager ultraToolbarsManager;
  private IContainer components;
  private UltraToolbarsDockArea _formACHSettingsManagement_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formACHSettingsManagement_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formACHSettingsManagement_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _formACHSettingsManagement_Toolbars_Dock_Area_Top;
  protected Panel editPanel;
  protected UltraTabControl banksTabControl;
  private UltraTabSharedControlsPage ultraTabSharedControlsPage1;
  private UltraTabPageControl ultraTabPageControl1;

  public Guid OpenEntity { get; private set; }

  public string OpenName { get; private set; }

  public formMultiACHSettingsEditor() => this.InitializeComponent();

  public formMultiACHSettingsEditor(Guid entityGuid, string name)
    : this(entityGuid, name, true)
  {
  }

  public formMultiACHSettingsEditor(Guid entityGuid, string name, bool isLoadedFromNewEntityGuid)
    : this()
  {
    this._entityGuid = entityGuid;
    this._isLoadFromNewEntityGuid = isLoadedFromNewEntityGuid;
    ((Control) this.entityName).Text = name;
  }

  public formMultiACHSettingsEditor(
    Guid entityGuid,
    formMultiACHSettingsEditor.ActiveRow activeRow,
    int rowId = 0,
    bool allowEdit = true)
    : this()
  {
    this._activeRow = activeRow;
    this._allowEdit = allowEdit;
    this._entityGuid = entityGuid;
    this._rowId = rowId;
  }

  protected virtual bool CheckForAccountChanges(
    DataRow dataRow,
    ACHSettingsAccountDetails accountDetail,
    int accountId,
    StringBuilder logAction)
  {
    bool flag = false;
    string result;
    if (this.CompareAndLogField(dataRow, "AccountName", "Account Name", accountDetail.AccountName, logAction, out result))
      flag = true;
    else
      logAction.Append($"   Account Name: {result}{Environment.NewLine}");
    return flag | this.CompareAndLogPaymentFormatChanges(accountId, accountDetail, logAction) | this.CompareAndLogField(dataRow, "AlternativePayee", "ALternative Payee", accountDetail.AlternativePayee, logAction, out string _) | this.CompareAndLogField(dataRow, "IBAN", "IBAN", accountDetail.Iban, logAction, out string _, true) | this.CompareAndLogField(dataRow, "CHIPNumber", "CHIP Number", accountDetail.ChipNumber, logAction, out string _, true) | this.CompareAndLogField(dataRow, "AccountNumber", "Account Number", accountDetail.AccountNumber, logAction, out string _, true) | this.CompareAndLogField(dataRow, "RoutingNumber", "Routing Number", accountDetail.RoutingNumber, logAction, out string _, true) | formMultiACHSettingsEditor.CompareAndLogField<object>(dataRow, "AccountType", "Account Type", accountDetail.AccountType, logAction) | formMultiACHSettingsEditor.CompareAndLogField<string>(dataRow, "Currency", "Currency", ((Control) accountDetail.currencyComboBox).Text, logAction) | formMultiACHSettingsEditor.CompareAndLogField<bool>(dataRow, "IsDefault", "Is Default", accountDetail.IsDefault, logAction);
  }

  protected virtual List<DbParameter> GetAccountParameters(ACHSettingsAccountDetails accountDetail)
  {
    List<DbParameter> accountParameters = new List<DbParameter>()
    {
      (DbParameter) formMultiACHSettingsEditor.GetSelectedPaymentMethodsParameter(accountDetail)
    };
    accountParameters.AddRange((IEnumerable<DbParameter>) DefaultDatabase.ParseNamedValueArgs(new object[20]
    {
      (object) "@AccountName",
      (object) accountDetail.AccountName,
      (object) "@AlternativePayee",
      (object) accountDetail.AlternativePayee,
      (object) "@IBAN",
      (object) MultiACHSettingsSecurity.Encrypt(accountDetail.Iban),
      (object) "@CHIPNumber",
      (object) MultiACHSettingsSecurity.Encrypt(accountDetail.ChipNumber),
      (object) "@AccountNumber",
      (object) MultiACHSettingsSecurity.Encrypt(accountDetail.AccountNumber),
      (object) "@RoutingNumber",
      (object) MultiACHSettingsSecurity.Encrypt(accountDetail.RoutingNumber),
      (object) "@AccountType",
      accountDetail.AccountType,
      (object) "@Currency",
      accountDetail.currencyComboBox.Value,
      (object) "@IsDefault",
      (object) accountDetail.IsDefault,
      (object) "@EnteredBy",
      (object) CurrentUser.Instance.UserGUID
    }));
    return accountParameters;
  }

  protected virtual void InitializeAccountFields(ACHSettingsAccountDetails accountDetail)
  {
    accountDetail.LoadPaymentFormats(this._paymentFormats);
    accountDetail.LoadCurrencies(this._currencies);
  }

  protected virtual void LoadDataSets()
  {
    this.LoadPaymentMethods();
    this.LoadCurrencies();
  }

  protected virtual void PopulateAccountDetail(
    ACHSettingsAccountDetails accountDetail,
    DataRow row,
    int accountId)
  {
    accountDetail.AccountId = new int?(accountId);
    accountDetail.AccountName = ExtensionsMethods.FieldAs<string>(row, "AccountName", DataRowVersion.Current);
    accountDetail.AlternativePayee = ExtensionsMethods.FieldAs<string>(row, "AlternativePayee", DataRowVersion.Current);
    accountDetail.AccountNumber = MultiACHSettingsSecurity.Decrypt(ExtensionsMethods.FieldAs<string>(row, "AccountNumber", DataRowVersion.Current));
    accountDetail.RoutingNumber = MultiACHSettingsSecurity.Decrypt(ExtensionsMethods.FieldAs<string>(row, "RoutingNumber", DataRowVersion.Current));
    accountDetail.AccountType = (object) ExtensionsMethods.FieldAs<string>(row, "accountType", DataRowVersion.Current);
    accountDetail.Iban = MultiACHSettingsSecurity.Decrypt(ExtensionsMethods.FieldAs<string>(row, "IBAN", DataRowVersion.Current));
    accountDetail.ChipNumber = MultiACHSettingsSecurity.Decrypt(ExtensionsMethods.FieldAs<string>(row, "CHIPNumber", DataRowVersion.Current));
    accountDetail.IsDefault = ExtensionsMethods.FieldAs<bool>(row, "IsDefault", DataRowVersion.Current);
    accountDetail.SetCurrencyValue(ExtensionsMethods.FieldAs<string>(row, "Currency", DataRowVersion.Current));
    if (this._data.Tables[3].Rows.Count > 0)
    {
      HashSet<string> hashSet = ChoLinqEx.ToHashSet<string>(this._data.Tables[3].Rows.Cast<DataRow>().Where<DataRow>((System.Func<DataRow, bool>) (r => ExtensionsMethods.FieldAs<int>(r, "ACHSettingsAccountID", DataRowVersion.Current) == accountId)).Select<DataRow, string>((System.Func<DataRow, string>) (r => ExtensionsMethods.FieldAs<string>(r, "PayMethodID", DataRowVersion.Current))));
      accountDetail.SetSelectedPaymentFormats((IEnumerable<string>) hashSet);
    }
    MGATextBox accountNumber = accountDetail.accountNumber;
    MGATextBox routingNumber = accountDetail.routingNumber;
    char ch1;
    accountDetail.iban.PasswordChar = ch1 = MultiACHSettingsSecurity.CanViewEncryptedSettings ? char.MinValue : '*';
    int num1;
    char ch2 = (char) (num1 = (int) ch1);
    routingNumber.PasswordChar = (char) num1;
    int num2 = (int) ch2;
    accountNumber.PasswordChar = (char) num2;
  }

  private void formMultiACHSettingsEditor_Load(object sender, EventArgs e)
  {
    this.LoadDataSets();
    this.PopulateEditor();
    if (!string.IsNullOrWhiteSpace(((Control) this.entityName).Text))
      this.Text = ((Control) this.entityName).Text;
    if (this._allowEdit)
      return;
    ((ToolsCollectionBase) this.ultraToolbarsManager.Tools)["SAVE"].SharedProps.Enabled = false;
    ((ToolsCollectionBase) this.ultraToolbarsManager.Tools)["SAVE"].SharedProps.Visible = false;
    ((ToolPropsBase) ((ToolsCollectionBase) this.ultraToolbarsManager.Tools)["CANCEL"].SharedProps).Caption = "Close";
    ((UltraTabControlBase) this.banksTabControl).NewTabButtonLocation = (NewTabButtonLocation) 0;
    ((UltraTabControlBase) this.banksTabControl).CloseButtonLocation = (TabCloseButtonLocation) 1;
  }

  private void formMultiACHSettingsEditor_Shown(object sender, EventArgs e)
  {
    if (this._activeRow != formMultiACHSettingsEditor.ActiveRow.None || this._isLoadFromNewEntityGuid)
    {
      ((Control) this.entityName).Enabled = false;
      this.entitySearch.Enabled = false;
      this.entitySearch.Visible = false;
    }
    switch (this._activeRow)
    {
      case formMultiACHSettingsEditor.ActiveRow.Entity:
        this.SetSelectedBankTab(((UltraTabControlBase) this.banksTabControl).Tabs[0]);
        formMultiACHSettingsEditor.SetTextBoxFocus(((UltraTabControlBase) this.banksTabControl).Tabs[0], "bankName");
        break;
      case formMultiACHSettingsEditor.ActiveRow.Bank:
        UltraTabsCollection.TabEnumerator enumerator1 = ((UltraTabControlBase) this.banksTabControl).Tabs.GetEnumerator();
        try
        {
          while (((DisposableObjectEnumeratorBase) enumerator1).MoveNext())
          {
            UltraTab current = enumerator1.Current;
            ACHSettingsBankDetails control;
            if (formMultiACHSettingsEditor.FindTabControl<ACHSettingsBankDetails>(current, "bankDetail", out control))
            {
              int? bankId = control.BankId;
              int rowId = this._rowId;
              if (bankId.GetValueOrDefault() == rowId & bankId.HasValue)
              {
                this.SetSelectedBankTab(current);
                formMultiACHSettingsEditor.SetTextBoxFocus(current, "bankName");
                break;
              }
            }
          }
          break;
        }
        finally
        {
          if (enumerator1 is IDisposable disposable)
            disposable.Dispose();
        }
      case formMultiACHSettingsEditor.ActiveRow.Account:
        UltraTabsCollection.TabEnumerator enumerator2 = ((UltraTabControlBase) this.banksTabControl).Tabs.GetEnumerator();
        try
        {
          while (((DisposableObjectEnumeratorBase) enumerator2).MoveNext())
          {
            UltraTab current = enumerator2.Current;
            UltraTabControl control1;
            if (formMultiACHSettingsEditor.FindTabControl<UltraTabControl>(current, "accountsTabControl", out control1))
            {
              foreach (UltraTab tab in ((UltraTabControlBase) control1).Tabs)
              {
                ACHSettingsAccountDetails control2;
                if (formMultiACHSettingsEditor.FindTabControl<ACHSettingsAccountDetails>(tab, "accountDetail", out control2))
                {
                  int? accountId = control2.AccountId;
                  int rowId = this._rowId;
                  if (accountId.GetValueOrDefault() == rowId & accountId.HasValue)
                  {
                    ((UltraTabControlBase) this.banksTabControl).SelectedTab = current;
                    ((UltraTabControlBase) control1).SelectedTab = tab;
                    formMultiACHSettingsEditor.SetTextBoxFocus(tab, "accountName");
                    break;
                  }
                }
              }
            }
          }
          break;
        }
        finally
        {
          if (enumerator2 is IDisposable disposable)
            disposable.Dispose();
        }
    }
  }

  private static void accountsTabControl_ActiveTabChanged(
    object sender,
    ActiveTabChangedEventArgs e)
  {
    formMultiACHSettingsEditor.EnableTabCloseButtonVisibility((UltraTabControl) ((Control) ((TabEventArgs) e).Tab.TabPage).Parent, ((TabEventArgs) e).Tab, e.PreviousActiveTab);
  }

  private void accountsTabControl_AfterNewTabButtonClicked(object sender, TabEventArgs e)
  {
    this.InitializeAccountsTab(e.Tab, ((KeyedSubObjectBase) ((UltraTabControlBase) this.banksTabControl).SelectedTab).Key);
  }

  private void accountsTabControl_TabClosed(object sender, TabClosedEventArgs e)
  {
    UltraTabControl parent = (UltraTabControl) ((Control) ((TabEventArgs) e).Tab.TabPage).Parent;
    Control control;
    if (formMultiACHSettingsEditor.FindTabControl(((TabEventArgs) e).Tab, "accountId", out control) && !string.IsNullOrEmpty(control.Text))
      this._deletedAccountIds.Add(Convert.ToInt32(control.Text));
    ((UltraTabControlBase) parent).Tabs.Remove(((TabEventArgs) e).Tab);
    formMultiACHSettingsEditor.DisableTabCloseButtonVisibility(parent);
  }

  private static void accountsTabControl_TabClosing(object sender, TabClosingEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete the account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.No)
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  private void banksTabControl_ActiveTabChanged(object sender, ActiveTabChangedEventArgs e)
  {
    formMultiACHSettingsEditor.EnableTabCloseButtonVisibility(this.banksTabControl, ((TabEventArgs) e).Tab, e.PreviousActiveTab);
  }

  private void banksTabControl_AfterNewTabButtonClicked(object sender, TabEventArgs e)
  {
    this.InitializeNewBankTab(e.Tab);
  }

  private void banksTabControl_TabClosed(object sender, TabClosedEventArgs e)
  {
    Control control1;
    if (formMultiACHSettingsEditor.FindTabControl(((TabEventArgs) e).Tab, "bankId", out control1) && !string.IsNullOrEmpty(control1.Text))
      this._deletedBankIds.Add(Convert.ToInt32(control1.Text));
    UltraTabControl control2;
    if (formMultiACHSettingsEditor.FindTabControl<UltraTabControl>(((TabEventArgs) e).Tab, "accountsTabControl", out control2))
    {
      foreach (UltraTab tab in ((UltraTabControlBase) control2).Tabs)
      {
        Control control3;
        if (formMultiACHSettingsEditor.FindTabControl(tab, "accountId", out control3) && !string.IsNullOrEmpty(control3.Text))
          this._deletedAccountIds.Add(Convert.ToInt32(control3.Text));
      }
    }
    ((UltraTabControlBase) this.banksTabControl).Tabs.Remove(((TabEventArgs) e).Tab);
    formMultiACHSettingsEditor.DisableTabCloseButtonVisibility(this.banksTabControl);
  }

  private void banksTabControl_TabClosing(object sender, TabClosingEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete the bank? This will also delete all the accounts for the bank.", "Delete Bank", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.No)
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  private void formMultiACHSettingsEditor_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (e.CloseReason != CloseReason.UserClosing)
      return;
    if (this._saveSucceeded)
    {
      this.DialogResult = DialogResult.OK;
    }
    else
    {
      if (!this._allowEdit || MessageBox.Show("Are you sure you want to exit the editor? All unsaved changes will be lost.", "Exit Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.No)
        return;
      e.Cancel = true;
    }
  }

  private void ultraToolbarsManager_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "CANCEL":
        this.Close();
        break;
      case "SAVE":
        this.SaveSetting();
        break;
    }
  }

  private static bool CheckRequiredFieldValue(string text, string description)
  {
    if (!string.IsNullOrWhiteSpace(text))
      return true;
    int num = (int) MessageBox.Show($"You must enter {description} to continue.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private static bool CheckRequiredFieldValue(
    string detailOne,
    string detailTwo,
    string description)
  {
    if (!string.IsNullOrWhiteSpace(detailOne) || !string.IsNullOrWhiteSpace(detailTwo))
      return true;
    int num = (int) MessageBox.Show($"You must enter {description} to continue.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private bool CompareAndLogPaymentFormatChanges(
    int accountId,
    ACHSettingsAccountDetails accountDetail,
    StringBuilder logAction)
  {
    List<string> list = this._data.Tables[3].Rows.Cast<DataRow>().Where<DataRow>((System.Func<DataRow, bool>) (r => ExtensionsMethods.FieldAs<int>(r, "ACHSettingsAccountID", DataRowVersion.Current) == accountId)).Select<DataRow, string>((System.Func<DataRow, string>) (r => ExtensionsMethods.FieldAs<string>(r, "PayMethodID", DataRowVersion.Current))).ToList<string>();
    List<string> selectedPaymentFormats = accountDetail.GetSelectedPaymentFormats();
    if (!list.Except<string>((IEnumerable<string>) selectedPaymentFormats).Any<string>() && !selectedPaymentFormats.Except<string>((IEnumerable<string>) list).Any<string>())
      return false;
    logAction.Append(formMultiACHSettingsEditor.FormatUpdatedFieldLogAction<string>("Payment Format", string.Join(",", (IEnumerable<string>) selectedPaymentFormats), string.Join(",", (IEnumerable<string>) list)));
    return true;
  }

  protected static bool CompareAndLogField<T>(
    DataRow dataRow,
    string column,
    string fieldName,
    T value,
    StringBuilder logAction)
  {
    T previousValue;
    if (!formMultiACHSettingsEditor.CompareField<T>(dataRow, column, value, out previousValue))
      return false;
    logAction.Append(formMultiACHSettingsEditor.FormatUpdatedFieldLogAction<T>(fieldName, value, previousValue));
    return true;
  }

  private bool CompareAndLogField(
    DataRow dataRow,
    string column,
    string fieldName,
    string value,
    StringBuilder logAction,
    out string result,
    bool isEncrypted = false)
  {
    if (!isEncrypted)
    {
      result = value;
      return formMultiACHSettingsEditor.CompareAndLogField<string>(dataRow, column, fieldName, value, logAction);
    }
    string str1 = MultiACHSettingsSecurity.Encrypt(value);
    result = str1;
    string previousValue;
    if (!formMultiACHSettingsEditor.CompareField<string>(dataRow, column, str1, out previousValue))
      return false;
    string str2 = MultiACHSettingsSecurity.Decrypt(previousValue);
    logAction.Append(formMultiACHSettingsEditor.FormatUpdatedFieldLogAction<string>(fieldName, value.TruncateToLastFour(), str2.TruncateToLastFour()));
    return true;
  }

  private static bool CompareField<T>(DataRow row, string column, T value, out T previousValue)
  {
    previousValue = ExtensionsMethods.FieldAs<T>(row, column, DataRowVersion.Current);
    return !typeof (T).IsValueType && (object) previousValue == null ? (object) value != null : !previousValue.Equals((object) value);
  }

  private UltraTab CreateAccountTab(UltraTab bankTab)
  {
    UltraTabControl control;
    if (!formMultiACHSettingsEditor.FindTabControl<UltraTabControl>(bankTab, "accountsTabControl", out control))
      throw new Exception("Accounts tab control missing from bank tab.");
    UltraTab tab = formMultiACHSettingsEditor.CreateTab(control, this._accountTabHeight, 471);
    this.InitializeAccountsTab(tab, ((KeyedSubObjectBase) bankTab).Key);
    return tab;
  }

  private UltraTab CreateBankTab()
  {
    UltraTab tab = formMultiACHSettingsEditor.CreateTab(this.banksTabControl, this._bankTabControlHeight, 478);
    this.CreateAccountsTabControl(tab);
    this.InitializeBanksTab(tab);
    return tab;
  }

  private void CreateAccountsTabControl(UltraTab tab)
  {
    Appearance appearance1 = new Appearance();
    ((AppearanceBase) appearance1).BackColor = Color.Gainsboro;
    Appearance appearance2 = appearance1;
    Appearance appearance3 = new Appearance();
    ((AppearanceBase) appearance3).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance3).BorderColor = Color.Gray;
    Appearance appearance4 = appearance3;
    UltraTabControl ultraTabControl1 = new UltraTabControl();
    ((UltraTabControlBase) ultraTabControl1).Appearance = (AppearanceBase) appearance2;
    ((UltraTabControlBase) ultraTabControl1).CloseButtonLocation = !MultiACHSettingsSecurity.CanDeleteSettings || !this._allowEdit ? (TabCloseButtonLocation) 1 : (TabCloseButtonLocation) 3;
    ((Control) ultraTabControl1).Font = new Font("Tahoma", 8.25f);
    ((Control) ultraTabControl1).Location = new Point(2, 235);
    ((Control) ultraTabControl1).Name = "accountsTabControl";
    ((UltraTabControlBase) ultraTabControl1).NewTabButtonLocation = !MultiACHSettingsSecurity.CanCreateSettings || !this._allowEdit ? (NewTabButtonLocation) 0 : (NewTabButtonLocation) 3;
    ((UltraTabControlBase) ultraTabControl1).SelectedTabAppearance = (AppearanceBase) appearance4;
    ((Control) ultraTabControl1).Size = new Size(473, this._accountTabControlHeight);
    ((Control) ultraTabControl1).TabIndex = 4;
    ((Control) ultraTabControl1).TabStop = true;
    ((UltraControlBase) ultraTabControl1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) ultraTabControl1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTabControlBase) ultraTabControl1).ViewStyle = (ViewStyle) 4;
    UltraTabControl ultraTabControl2 = ultraTabControl1;
    ((UltraTabControlBase) ultraTabControl2).ActiveTabChanged += new ActiveTabChangedEventHandler(formMultiACHSettingsEditor.accountsTabControl_ActiveTabChanged);
    ((UltraTabControlBase) ultraTabControl2).AfterNewTabButtonClicked += new AfterNewTabButtonClickedEventHandler(this.accountsTabControl_AfterNewTabButtonClicked);
    ((UltraTabControlBase) ultraTabControl2).TabClosed += new TabClosedEventHandler(this.accountsTabControl_TabClosed);
    ((UltraTabControlBase) ultraTabControl2).TabClosing += new TabClosingEventHandler(formMultiACHSettingsEditor.accountsTabControl_TabClosing);
    ((Control) tab.TabPage).Controls.Add((Control) ultraTabControl2);
  }

  private static UltraTab CreateTab(UltraTabControl tabControl, int height, int width)
  {
    UltraTabPageControl ultraTabPageControl1 = new UltraTabPageControl();
    ((Control) ultraTabPageControl1).Location = new Point(1, 22);
    ((Control) ultraTabPageControl1).Size = new Size()
    {
      Height = height,
      Width = width
    };
    UltraTabPageControl ultraTabPageControl2 = ultraTabPageControl1;
    UltraTab tab = new UltraTab()
    {
      Active = true,
      CloseButtonVisibility = (TabCloseButtonVisibility) 4,
      TabPage = ultraTabPageControl2
    };
    ((UltraTabControlBase) tabControl).Tabs.Add((object) tab);
    ((Control) tabControl).Controls.Add((Control) ultraTabPageControl2);
    ((UltraTabControlBase) tabControl).SelectedTab = tab;
    return tab;
  }

  private void CustomizeBankComponents(UltraTab tab)
  {
    this.SuspendLayout();
    formMultiACHSettingsEditor.ResizeAddressControl(tab, "cboCountries", width: 360);
    formMultiACHSettingsEditor.ResizeAddressControl(tab, "txtAddress1", width: 360);
    formMultiACHSettingsEditor.ResizeAddressControl(tab, "txtAddress2", width: 360);
    formMultiACHSettingsEditor.ResizeAddressControl(tab, "txtCounty", width: 360);
    formMultiACHSettingsEditor.ResizeAddressControl(tab, "txtCity", width: 240 /*0xF0*/);
    formMultiACHSettingsEditor.ResizeAddressControl(tab, "lblState", -45);
    formMultiACHSettingsEditor.ResizeAddressControl(tab, "txtState", -45, 82);
    formMultiACHSettingsEditor.ResizeAddressControl(tab, "txtZipCode", width: 240 /*0xF0*/);
    formMultiACHSettingsEditor.ResizeAddressControl(tab, "lblZipExtension", -35);
    formMultiACHSettingsEditor.ResizeAddressControl(tab, "txtZipExtension", -27, 82);
    formMultiACHSettingsEditor.ResizeAddressControl(tab, "txtZipCode_Intl", width: 240 /*0xF0*/);
    this.ResumeLayout(false);
  }

  private void DeleteAccounts()
  {
    if (this._deletedAccountIds.Count == 0)
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_DeleteACHSetting_Account", (CommandArgumentType) 2, new object[1]
    {
      (object) new List<DbParameter>()
      {
        (DbParameter) formMultiACHSettingsEditor.GetIntListParameter("@ACHSettingsAccountIDs", (IEnumerable<int>) this._deletedAccountIds)
      }
    });
    foreach (int deletedAccountId in this._deletedAccountIds)
    {
      int accountId = deletedAccountId;
      DataRow dataRow = this._data.Tables[2].Rows.Cast<DataRow>().First<DataRow>((System.Func<DataRow, bool>) (r => ExtensionsMethods.FieldAs<int>(r, "ACHSettingsAccountID", DataRowVersion.Current) == accountId));
      string str1 = ExtensionsMethods.FieldAs<string>(dataRow, "AccountName", DataRowVersion.Current);
      int bankId = ExtensionsMethods.FieldAs<int>(dataRow, "ACHSettingsBankID", DataRowVersion.Current);
      string str2 = ExtensionsMethods.FieldAs<string>(this._data.Tables[1].Rows.Cast<DataRow>().First<DataRow>((System.Func<DataRow, bool>) (r => ExtensionsMethods.FieldAs<int>(r, "ACHSettingsBankID", DataRowVersion.Current) == bankId)), "BankName", DataRowVersion.Current);
      StringBuilder stringBuilder = new StringBuilder(200);
      stringBuilder.Append("Deleted ACH account setting:" + Environment.NewLine);
      stringBuilder.Append($"   Entity: {((Control) this.entityName).Text} ({this._entityGuid}){Environment.NewLine}");
      stringBuilder.Append($"   Bank Name: {str2}{Environment.NewLine}");
      stringBuilder.Append($"   Account Name: {str1}{Environment.NewLine}");
      CurrentUser.Instance.LogAction(stringBuilder.ToString(), MultiACHSettingsSecurity.LogContext);
    }
  }

  private void DeleteBanks()
  {
    if (this._deletedBankIds.Count == 0)
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_DeleteACHSetting_Bank", (CommandArgumentType) 2, new object[1]
    {
      (object) new List<DbParameter>()
      {
        (DbParameter) formMultiACHSettingsEditor.GetIntListParameter("@ACHSettingsBankIDs", (IEnumerable<int>) this._deletedBankIds)
      }
    });
    foreach (int deletedBankId in this._deletedBankIds)
    {
      int bankId = deletedBankId;
      string str = ExtensionsMethods.FieldAs<string>(this._data.Tables[1].Rows.Cast<DataRow>().First<DataRow>((System.Func<DataRow, bool>) (r => ExtensionsMethods.FieldAs<int>(r, "ACHSettingsBankID", DataRowVersion.Current) == bankId)), "BankName", DataRowVersion.Current);
      StringBuilder stringBuilder = new StringBuilder(200);
      stringBuilder.Append("Deleted ACH bank setting:" + Environment.NewLine);
      stringBuilder.Append($"   Entity: {((Control) this.entityName).Text} ({this._entityGuid}){Environment.NewLine}");
      stringBuilder.Append($"   Bank Name: {str}{Environment.NewLine}");
      CurrentUser.Instance.LogAction(stringBuilder.ToString(), MultiACHSettingsSecurity.LogContext);
    }
  }

  private static void DisableTabCloseButtonVisibility(UltraTabControl tabControl)
  {
    if (((DisposableObjectCollectionBase) ((UltraTabControlBase) tabControl).Tabs).Count >= 2)
      return;
    ((UltraTabControlBase) tabControl).Tabs[0].CloseButtonVisibility = (TabCloseButtonVisibility) 4;
  }

  private static void EnableTabCloseButtonVisibility(
    UltraTabControl tabControl,
    UltraTab tab,
    UltraTab previousTab)
  {
    if (tab == null)
      return;
    if (((DisposableObjectCollectionBase) ((UltraTabControlBase) tabControl).Tabs).Count == 1)
    {
      tab.CloseButtonVisibility = (TabCloseButtonVisibility) 4;
    }
    else
    {
      tab.CloseButtonVisibility = (TabCloseButtonVisibility) 0;
      if (previousTab == null)
        return;
      previousTab.CloseButtonVisibility = (TabCloseButtonVisibility) 0;
      if (previousTab.Index != 0)
        return;
      int length = previousTab.Text.Length;
      previousTab.Text += " ";
      previousTab.Text = previousTab.Text.Substring(0, length);
    }
  }

  private void entitySearch_Click(object sender, EventArgs e)
  {
    using (FormSearchEntity form = new FormSearchEntity(Utility.SearchEntityTypes.All))
    {
      if (form.ShowDialog() != DialogResult.OK)
        return;
      if (((IEnumerable<ACHBankDto>) this._bankRepository.GetByEntityGuid(form.EntityGuid)).Any<ACHBankDto>())
      {
        if (MessageBox.Show("An entry already exists for this entity. Would you like to view it instead?\nUnsaved changes will be lost.", "An entry already exists for this entity.", MessageBoxButtons.YesNo) != DialogResult.Yes)
          return;
        this.SetOpenEntityAndClose(form);
      }
      else
        this.SetSelection(form);
    }
  }

  private static SqlParameter GetIntListParameter(string parameterName, IEnumerable<int> source)
  {
    DataTable dataTable = new DataTable();
    dataTable.Columns.Add("Item", typeof (int));
    foreach (int num in source)
      dataTable.Rows.Add((object) num);
    SqlParameter intListParameter = new SqlParameter(parameterName, SqlDbType.Structured);
    intListParameter.TypeName = "dbo.IntList";
    intListParameter.Value = (object) dataTable;
    return intListParameter;
  }

  private static SqlParameter GetSelectedPaymentMethodsParameter(
    ACHSettingsAccountDetails accountDetail)
  {
    return formMultiACHSettingsEditor.GetIntListParameter("@PaymentMethodIDs", (IEnumerable<int>) accountDetail.GetSelectedPaymentFormats().Select<string, int>((System.Func<string, int>) (p => (int) p[0])).ToList<int>());
  }

  private void SetOpenEntityAndClose(FormSearchEntity form)
  {
    this.DialogResult = DialogResult.Abort;
    this.OpenEntity = form.EntityGuid;
    this.OpenName = form.EntityName;
    this.FormClosing -= new FormClosingEventHandler(this.formMultiACHSettingsEditor_FormClosing);
    this.Close();
  }

  private void SetSelection(FormSearchEntity form)
  {
    this._entityGuid = form.EntityGuid;
    ((Control) this.entityName).Text = form.EntityName;
    this.Text = form.EntityName;
  }

  private static bool FindTabControl(UltraTab tab, string controlName, out Control control)
  {
    control = tab != null ? ((IEnumerable<Control>) ((Control) tab.TabPage).Controls.Find(controlName, true)).FirstOrDefault<Control>() : (Control) null;
    return control != null;
  }

  private static bool FindTabControl<T>(UltraTab tab, string controlName, out T control) where T : Control
  {
    Control control1;
    if (!formMultiACHSettingsEditor.FindTabControl(tab, controlName, out control1))
    {
      control = default (T);
      return false;
    }
    control = control1 as T;
    return (object) control != null;
  }

  private static string FormatUpdatedFieldLogAction<T>(
    string fieldName,
    T newValue,
    T previousValue)
  {
    return $"   {fieldName}: {newValue} (original: {previousValue}){Environment.NewLine}";
  }

  private void InitializeAccountsTab(UltraTab tab, string parentTabKey)
  {
    ((KeyedSubObjectBase) tab).Key = Guid.NewGuid().ToString();
    tab.Text = "New Account";
    ACHSettingsAccountDetails detail = ObjectFactory.Instance.CreateObjectAs<ACHSettingsAccountDetails>();
    detail.Enabled = this._allowEdit;
    detail.Location = new Point(-2, 4);
    detail.Name = "accountDetail";
    this.InitializeAccountFields(detail);
    detail.ParentTabKey = parentTabKey;
    ((Control) detail.accountName).TextChanged += (EventHandler) ((o, args) => Debouncer.Debounce(300, (Action<object>) (_ =>
    {
      if (detail.AccountName == null)
        return;
      tab.Text = detail.AccountName;
    })));
    ((Control) tab.TabPage).Controls.Add((Control) detail);
    ((UltraToggleEditorBase) detail.isDefault).CheckedChanged += (EventHandler) ((o, args) =>
    {
      if (!this._defaultChangeInProcess)
      {
        this._defaultChangeInProcess = true;
        foreach (UltraTab tab1 in ((UltraTabControlBase) this.banksTabControl).Tabs)
        {
          UltraTabControl control1;
          if (formMultiACHSettingsEditor.FindTabControl<UltraTabControl>(tab1, "accountsTabControl", out control1))
          {
            foreach (UltraTab tab2 in ((UltraTabControlBase) control1).Tabs)
            {
              ACHSettingsAccountDetails control2;
              if (formMultiACHSettingsEditor.FindTabControl<ACHSettingsAccountDetails>(tab2, "accountDetail", out control2) && ((KeyedSubObjectBase) tab2).Key != ((KeyedSubObjectBase) tab).Key)
                ((UltraToggleEditorBase) control2.isDefault).Checked = false;
            }
          }
        }
        this._defaultChangeInProcess = false;
      }
      tab.Appearance.Image = ((UltraToggleEditorBase) detail.isDefault).Checked ? (object) Resources.accept : (object) (Bitmap) null;
      UltraTab ultraTab = ((IEnumerable) ((UltraTabControlBase) this.banksTabControl).Tabs).Cast<UltraTab>().FirstOrDefault<UltraTab>((System.Func<UltraTab, bool>) (t => ((KeyedSubObjectBase) t).Key == detail.ParentTabKey));
      if (ultraTab == null)
        return;
      ultraTab.Appearance.Image = ((UltraToggleEditorBase) detail.isDefault).Checked ? (object) Resources.accept : (object) (Bitmap) null;
    });
  }

  private void InitializeBanksTab(UltraTab tab)
  {
    ((KeyedSubObjectBase) tab).Key = Guid.NewGuid().ToString();
    tab.Text = "New Bank";
    ACHSettingsBankDetails settingsBankDetails = new ACHSettingsBankDetails();
    settingsBankDetails.Name = "bankDetail";
    settingsBankDetails.Location = new Point(-2, 4);
    ACHSettingsBankDetails detail = settingsBankDetails;
    detail.Enabled = this._allowEdit;
    ((Control) detail.bankName).TextChanged += (EventHandler) ((o, args) => Debouncer.Debounce(300, (Action<object>) (_ =>
    {
      if (detail.BankName == null)
        return;
      tab.Text = detail.BankName;
    })));
    ((Control) tab.TabPage).Controls.Add((Control) detail);
    this.CustomizeBankComponents(tab);
  }

  private void InitializeNewBankTab(UltraTab tab)
  {
    if (!MultiACHSettingsSecurity.CanCreateSettings)
      ((UltraTabControlBase) this.banksTabControl).NewTabButtonLocation = (NewTabButtonLocation) 0;
    if (!MultiACHSettingsSecurity.CanDeleteSettings)
      ((UltraTabControlBase) this.banksTabControl).CloseButtonLocation = (TabCloseButtonLocation) 1;
    this.InitializeBanksTab(tab);
    this.CreateAccountsTabControl(tab);
    this.CreateAccountTab(tab);
    UltraTabControl control;
    if (!formMultiACHSettingsEditor.FindTabControl<UltraTabControl>(tab, "accountsTabControl", out control))
      return;
    this.InitializeAccountsTab(((UltraTabControlBase) control).Tabs[0], ((KeyedSubObjectBase) tab).Key);
  }

  private void LoadPaymentMethods()
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this._paymentFormats = DefaultDatabase.ExecuteDataSet("dbo.spFin_GetAllPaymentMethods");
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void LoadCurrencies()
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this._currencies = DefaultDatabase.ExecuteDataSet("dbo.spFin_GetAllCurrencies");
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void PopulateEditor()
  {
    if (this._activeRow == formMultiACHSettingsEditor.ActiveRow.None)
    {
      this.InitializeNewBankTab(((UltraTabControlBase) this.banksTabControl).Tabs[0]);
    }
    else
    {
      if (!MultiACHSettingsSecurity.CanCreateSettings)
        ((UltraTabControlBase) this.banksTabControl).NewTabButtonLocation = (NewTabButtonLocation) 0;
      if (!MultiACHSettingsSecurity.CanDeleteSettings)
        ((UltraTabControlBase) this.banksTabControl).CloseButtonLocation = (TabCloseButtonLocation) 1;
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        this._data = DefaultDatabase.ExecuteDataSet(this._getACHSettingProc, new object[2]
        {
          (object) "@EntityGuid",
          (object) this._entityGuid
        });
        ((Control) this.entityName).Text = ExtensionsMethods.FieldAs<string>(this._data.Tables[0].Rows[0], "EntityName", DataRowVersion.Current);
        ((UltraTabControlBase) this.banksTabControl).Tabs.Clear();
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        if (this._data.Tables[1].Rows.Count > 0)
        {
          foreach (DataRow row in (InternalDataCollectionBase) this._data.Tables[1].Rows)
          {
            UltraTab bankTab = this.CreateBankTab();
            ACHSettingsBankDetails control;
            if (formMultiACHSettingsEditor.FindTabControl<ACHSettingsBankDetails>(bankTab, "bankDetail", out control))
            {
              int num = ExtensionsMethods.FieldAs<int>(row, "ACHSettingsBankID", DataRowVersion.Current);
              dictionary.Add(num, ((KeyedSubObjectBase) bankTab).Key);
              formMultiACHSettingsEditor.PopulateBankDetail(control, row, num);
              bankTab.Text = control.BankName;
            }
          }
        }
        else
          this.CreateBankTab();
        if (this._data.Tables[2].Rows.Count > 0)
        {
          HashSet<string> usedBankTabs = new HashSet<string>();
          foreach (DataRow row in (InternalDataCollectionBase) this._data.Tables[2].Rows)
          {
            int key = ExtensionsMethods.FieldAs<int>(row, "ACHSettingsBankID", DataRowVersion.Current);
            string tabKey;
            if (dictionary.TryGetValue(key, out tabKey))
            {
              UltraTab bankTab = ((IEnumerable) ((UltraTabControlBase) this.banksTabControl).Tabs).Cast<UltraTab>().FirstOrDefault<UltraTab>((System.Func<UltraTab, bool>) (t => ((KeyedSubObjectBase) t).Key == tabKey));
              if (bankTab != null)
              {
                UltraTab accountTab = this.CreateAccountTab(bankTab);
                ACHSettingsAccountDetails control;
                if (formMultiACHSettingsEditor.FindTabControl<ACHSettingsAccountDetails>(accountTab, "accountDetail", out control))
                {
                  int accountId = ExtensionsMethods.FieldAs<int>(row, "ACHSettingsAccountID", DataRowVersion.Current);
                  this.PopulateAccountDetail(control, row, accountId);
                  accountTab.Text = control.AccountName;
                  usedBankTabs.Add(((KeyedSubObjectBase) bankTab).Key);
                }
              }
            }
          }
          foreach (UltraTab bankTab in ((IEnumerable) ((UltraTabControlBase) this.banksTabControl).Tabs).Cast<UltraTab>().Where<UltraTab>((System.Func<UltraTab, bool>) (t => !usedBankTabs.Contains(((KeyedSubObjectBase) t).Key))))
            this.CreateAccountTab(bankTab);
        }
        else
        {
          foreach (UltraTab tab in ((UltraTabControlBase) this.banksTabControl).Tabs)
            this.CreateAccountTab(tab);
        }
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  private static void PopulateBankDetail(
    ACHSettingsBankDetails bankDetail,
    DataRow row,
    int bankId)
  {
    bankDetail.BankId = new int?(bankId);
    bankDetail.BankName = ExtensionsMethods.FieldAs<string>(row, "BankName", DataRowVersion.Current);
    bankDetail.SwiftCode = MultiACHSettingsSecurity.Decrypt(ExtensionsMethods.FieldAs<string>(row, "SWIFTCode", DataRowVersion.Current));
    bankDetail.SortCode = MultiACHSettingsSecurity.Decrypt(ExtensionsMethods.FieldAs<string>(row, "SortCode", DataRowVersion.Current));
    bankDetail.IsoCountryCode = ExtensionsMethods.FieldAs<string>(row, "BankISOCountryCode", DataRowVersion.Current);
    bankDetail.Address1 = ExtensionsMethods.FieldAs<string>(row, "BankAddress1", DataRowVersion.Current);
    bankDetail.Address2 = ExtensionsMethods.FieldAs<string>(row, "BankAddress2", DataRowVersion.Current);
    bankDetail.City = ExtensionsMethods.FieldAs<string>(row, "BankCity", DataRowVersion.Current);
    bankDetail.State = ExtensionsMethods.FieldAs<string>(row, "BankState", DataRowVersion.Current);
    bankDetail.ZipCode = ExtensionsMethods.FieldAs<string>(row, "BankZipCode", DataRowVersion.Current);
    bankDetail.ZipCodeExtension = ExtensionsMethods.FieldAs<string>(row, "BankZipExt", DataRowVersion.Current);
    bankDetail.swiftCode.PasswordChar = MultiACHSettingsSecurity.CanViewEncryptedSettings ? char.MinValue : '*';
  }

  private static void ResizeAddressControl(UltraTab tab, string name, int offset = 0, int width = 0)
  {
    Control control;
    if (!formMultiACHSettingsEditor.FindTabControl(tab, name, out control))
      return;
    int x = offset != 0 ? control.Location.X + offset : 108;
    control.Location = new Point(x, control.Location.Y);
    if (width <= 0)
      return;
    control.Width = width;
  }

  private void SaveAccountSetting(
    int bankId,
    string bankName,
    ACHSettingsAccountDetails accountDetail)
  {
    try
    {
      List<DbParameter> accountParameters = this.GetAccountParameters(accountDetail);
      accountParameters.AddRange((IEnumerable<DbParameter>) DefaultDatabase.ParseNamedValueArgs(new object[4]
      {
        (object) "@ACHSettingsBankID",
        (object) bankId,
        (object) "@EntityGuid",
        (object) this._entityGuid
      }));
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, this._saveACHSettingAccountProc, (CommandArgumentType) 2, new object[1]
      {
        (object) accountParameters
      });
      StringBuilder stringBuilder = new StringBuilder(200);
      stringBuilder.Append("Created new ACH account setting:" + Environment.NewLine);
      stringBuilder.Append($"   Entity: {((Control) this.entityName).Text} ({this._entityGuid}){Environment.NewLine}");
      stringBuilder.Append($"   Bank Name: {bankName}{Environment.NewLine}");
      stringBuilder.Append($"   Account Name: {accountDetail.AccountName}{Environment.NewLine}");
      CurrentUser.Instance.LogAction(stringBuilder.ToString(), MultiACHSettingsSecurity.LogContext);
    }
    catch (Exception ex)
    {
      int num = (int) MessageBox.Show(ex.Message ?? "", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
  }

  private int SaveBankSetting(ACHSettingsBankDetails bankDetail)
  {
    int int32 = Convert.ToInt32(DefaultDatabase.ExecuteScalar("dbo.spFin_SaveACHSetting_Bank", new object[24]
    {
      (object) "@EntityGuid",
      (object) this._entityGuid,
      (object) "@BankName",
      (object) bankDetail.BankName,
      (object) "@BankISOCountryCode",
      (object) bankDetail.IsoCountryCode,
      (object) "@BankAddress1",
      (object) bankDetail.Address1,
      (object) "@BankAddress2",
      (object) bankDetail.Address2,
      (object) "@BankCity",
      (object) bankDetail.City,
      (object) "@BankState",
      (object) bankDetail.State,
      (object) "@BankZipCode",
      (object) bankDetail.ZipCode,
      (object) "@BankZipExt",
      (object) bankDetail.ZipCodeExtension,
      (object) "@SWIFTCode",
      (object) MultiACHSettingsSecurity.Encrypt(bankDetail.SwiftCode),
      (object) "@SortCode",
      (object) MultiACHSettingsSecurity.Encrypt(bankDetail.SortCode),
      (object) "@EnteredBy",
      (object) CurrentUser.Instance.UserGUID
    }));
    StringBuilder stringBuilder = new StringBuilder(200);
    stringBuilder.Append("Created new ACH bank setting:" + Environment.NewLine);
    stringBuilder.Append($"   Entity: {((Control) this.entityName).Text} ({this._entityGuid}){Environment.NewLine}");
    stringBuilder.Append("   Bank Name: " + bankDetail.BankName);
    CurrentUser.Instance.LogAction(stringBuilder.ToString(), MultiACHSettingsSecurity.LogContext);
    return int32;
  }

  private void SaveSetting()
  {
    if (!this.ValidateInputs())
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
      {
        foreach (UltraTab tab1 in ((UltraTabControlBase) this.banksTabControl).Tabs)
        {
          ACHSettingsBankDetails control1;
          if (formMultiACHSettingsEditor.FindTabControl<ACHSettingsBankDetails>(tab1, "bankDetail", out control1))
          {
            int bankId;
            if (!control1.BankId.HasValue)
            {
              bankId = this.SaveBankSetting(control1);
            }
            else
            {
              bankId = control1.BankId.Value;
              this.UpdateBankSetting(bankId, control1);
            }
            UltraTabControl control2;
            if (formMultiACHSettingsEditor.FindTabControl<UltraTabControl>(tab1, "accountsTabControl", out control2))
            {
              foreach (UltraTab tab2 in ((UltraTabControlBase) control2).Tabs)
              {
                ACHSettingsAccountDetails control3;
                if (formMultiACHSettingsEditor.FindTabControl<ACHSettingsAccountDetails>(tab2, "accountDetail", out control3))
                {
                  if (!control3.AccountId.HasValue)
                    this.SaveAccountSetting(bankId, control1.BankName, control3);
                  else
                    this.UpdateAccountSetting(control3.AccountId.Value, control3);
                }
              }
            }
          }
        }
        this.DeleteBanks();
        this.DeleteAccounts();
        e.Transaction.Commit();
      }));
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    this._saveSucceeded = true;
    this.Close();
  }

  private void SetFailedAccountControlFocus(
    UltraTab bankTab,
    UltraTabControl accountsTabControl,
    UltraTab accountTab,
    Control control)
  {
    ((UltraTabControlBase) this.banksTabControl).SelectedTab = bankTab;
    ((UltraTabControlBase) accountsTabControl).SelectedTab = accountTab;
    control.Focus();
  }

  private void SetFailedBankControlFocus(UltraTab tab, Control control)
  {
    ((UltraTabControlBase) this.banksTabControl).SelectedTab = tab;
    control.Focus();
  }

  private void SetSelectedBankTab(UltraTab bankTab)
  {
    ((UltraTabControlBase) this.banksTabControl).SelectedTab = bankTab;
    UltraTabControl control;
    if (!formMultiACHSettingsEditor.FindTabControl<UltraTabControl>(bankTab, "accountsTabControl", out control))
      return;
    ((UltraTabControlBase) control).SelectedTab = ((UltraTabControlBase) control).Tabs[0];
  }

  private static void SetTextBoxFocus(MGATextBox control)
  {
    ((TextEditorControlBase) control).Focus();
    ((TextEditorControlBase) control).Select(0, 0);
  }

  private static void SetTextBoxFocus(UltraTab tab, string controlName)
  {
    MGATextBox control;
    if (!formMultiACHSettingsEditor.FindTabControl<MGATextBox>(tab, controlName, out control))
      return;
    formMultiACHSettingsEditor.SetTextBoxFocus(control);
  }

  private void UpdateAccountSetting(int accountId, ACHSettingsAccountDetails accountDetail)
  {
    StringBuilder logAction = new StringBuilder(200);
    logAction.Append("Updated ACH account setting:" + Environment.NewLine);
    logAction.Append($"   Entity: {((Control) this.entityName).Text} ({this._entityGuid}){Environment.NewLine}");
    if (!this.CheckForAccountChanges(this._data.Tables[2].Rows.Cast<DataRow>().First<DataRow>((System.Func<DataRow, bool>) (r => ExtensionsMethods.FieldAs<int>(r, "ACHSettingsAccountID", DataRowVersion.Current) == accountId)), accountDetail, accountId, logAction))
      return;
    try
    {
      List<DbParameter> accountParameters = this.GetAccountParameters(accountDetail);
      accountParameters.AddRange((IEnumerable<DbParameter>) DefaultDatabase.ParseNamedValueArgs(new object[2]
      {
        (object) "@ACHSettingsAccountID",
        (object) accountId
      }));
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, this._updateACHSettingAccountProc, (CommandArgumentType) 2, new object[1]
      {
        (object) accountParameters
      });
      CurrentUser.Instance.LogAction(logAction.ToString(), MultiACHSettingsSecurity.LogContext);
    }
    catch (Exception ex)
    {
      int num = (int) MessageBox.Show(ex.Message ?? "", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void UpdateBankSetting(int bankId, ACHSettingsBankDetails bankDetail)
  {
    StringBuilder logAction = new StringBuilder(200);
    logAction.Append("Updated ACH bank setting:" + Environment.NewLine);
    logAction.Append($"   Entity: {((Control) this.entityName).Text} ({this._entityGuid}){Environment.NewLine}");
    DataRow dataRow = this._data.Tables[1].Rows.Cast<DataRow>().First<DataRow>((System.Func<DataRow, bool>) (r => ExtensionsMethods.FieldAs<int>(r, "ACHSettingsBankID", DataRowVersion.Current) == bankId));
    bool flag = false;
    string result1;
    if (this.CompareAndLogField(dataRow, "BankName", "Bank Name", bankDetail.BankName, logAction, out result1))
      flag = true;
    else
      logAction.Append($"   Bank Name: {result1}{Environment.NewLine}");
    string result2;
    string result3;
    string result4;
    string result5;
    string result6;
    string result7;
    string result8;
    string result9;
    string result10;
    if (!(flag | this.CompareAndLogField(dataRow, "BankISOCountryCode", "ISO Country Code", bankDetail.IsoCountryCode, logAction, out result2) | this.CompareAndLogField(dataRow, "BankAddress1", "Address 1", bankDetail.Address1, logAction, out result3) | this.CompareAndLogField(dataRow, "BankAddress2", "Address 2", bankDetail.Address2, logAction, out result4) | this.CompareAndLogField(dataRow, "BankCity", "City", bankDetail.City, logAction, out result5) | this.CompareAndLogField(dataRow, "BankState", "State", bankDetail.State, logAction, out result6) | this.CompareAndLogField(dataRow, "BankZipCode", "Zip Code", bankDetail.ZipCode, logAction, out result7) | this.CompareAndLogField(dataRow, "BankZipExt", "Zip Extension", bankDetail.ZipCodeExtension, logAction, out result8) | this.CompareAndLogField(dataRow, "SWIFTCode", "SWIFT Code", bankDetail.SwiftCode, logAction, out result9, true) | this.CompareAndLogField(dataRow, "SortCode", "Sort Code", bankDetail.SortCode, logAction, out result10, true)))
      return;
    DefaultDatabase.ExecuteNonQuery("dbo.spFin_UpdateACHSetting_Bank", new object[24]
    {
      (object) "@ACHSettingsBankID",
      (object) bankId,
      (object) "@BankName",
      (object) result1,
      (object) "@BankISOCountryCode",
      (object) result2,
      (object) "@BankAddress1",
      (object) result3,
      (object) "@BankAddress2",
      (object) result4,
      (object) "@BankCity",
      (object) result5,
      (object) "@BankState",
      (object) result6,
      (object) "@BankZipCode",
      (object) result7,
      (object) "@BankZipExt",
      (object) result8,
      (object) "@SWIFTCode",
      (object) result9,
      (object) "@SortCode",
      (object) result10,
      (object) "@EnteredBy",
      (object) CurrentUser.Instance.UserGUID
    });
    CurrentUser.Instance.LogAction(logAction.ToString(), MultiACHSettingsSecurity.LogContext);
  }

  private bool ValidateInputs()
  {
    if (!formMultiACHSettingsEditor.CheckRequiredFieldValue(((Control) this.entityName).Text, "an entity"))
    {
      ((TextEditorControlBase) this.entityName).Focus();
      return false;
    }
    foreach (UltraTab tab1 in ((UltraTabControlBase) this.banksTabControl).Tabs)
    {
      ACHSettingsBankDetails control1;
      Control failedControl1;
      if (formMultiACHSettingsEditor.FindTabControl<ACHSettingsBankDetails>(tab1, "bankDetail", out control1) && !this.ValidateBankTab(control1, out failedControl1))
      {
        this.SetFailedBankControlFocus(tab1, failedControl1);
        return false;
      }
      UltraTabControl control2;
      if (formMultiACHSettingsEditor.FindTabControl<UltraTabControl>(tab1, "accountsTabControl", out control2))
      {
        foreach (UltraTab tab2 in ((UltraTabControlBase) control2).Tabs)
        {
          ACHSettingsAccountDetails control3;
          if (formMultiACHSettingsEditor.FindTabControl<ACHSettingsAccountDetails>(tab2, "accountDetail", out control3))
          {
            Control failedControl2;
            if (!this.ValidateAccountTab(control3, out failedControl2))
            {
              this.SetFailedAccountControlFocus(tab1, control2, tab2, failedControl2);
              return false;
            }
            if (!string.IsNullOrWhiteSpace(control3.Iban))
            {
              if (string.IsNullOrWhiteSpace(control1.SwiftCode))
              {
                int num = (int) MessageBox.Show("If an IBAN is entered, then a SWIFT Code must also be entered.", "IBAN Requires SWIFT Code", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.SetFailedBankControlFocus(tab1, (Control) control1.swiftCode);
                ((UltraTabControlBase) control2).SelectedTab = tab2;
                return false;
              }
              if (!string.IsNullOrWhiteSpace(control3.AccountNumber))
              {
                int num = (int) MessageBox.Show("If an IBAN is entered, the account number must be left blank.", "Cannot Have Account Number with IBAN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.SetFailedAccountControlFocus(tab1, control2, tab2, (Control) control3.accountNumber);
                return false;
              }
              if (!string.IsNullOrWhiteSpace(control3.RoutingNumber))
              {
                int num = (int) MessageBox.Show("If an IBAN is entered, the routing number must be left blank.", "Cannot Have Routing Number with IBAN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.SetFailedAccountControlFocus(tab1, control2, tab2, (Control) control3.routingNumber);
                return false;
              }
            }
          }
        }
      }
    }
    return true;
  }

  private bool ValidateAccountTab(ACHSettingsAccountDetails details, out Control failedControl)
  {
    failedControl = (Control) null;
    if (!formMultiACHSettingsEditor.CheckRequiredFieldValue(details.AccountName, "an account name"))
    {
      failedControl = (Control) details.accountName;
      return false;
    }
    if (!formMultiACHSettingsEditor.CheckRequiredFieldValue(details.AccountNumber, details.Iban, "an account number or an IBAN number"))
    {
      failedControl = (Control) details.accountNumber;
      return false;
    }
    if (!string.IsNullOrWhiteSpace(details.AccountNumber) && !formMultiACHSettingsEditor.CheckRequiredFieldValue(details.RoutingNumber, "a routing number"))
    {
      failedControl = (Control) details.routingNumber;
      return false;
    }
    if (DefaultDatabase.ExecuteScalar<int>("dbo.spFin_CheckForDuplicate_Account", new object[10]
    {
      (object) "@EntityGuid",
      (object) this._entityGuid,
      (object) "@IBAN",
      (object) MultiACHSettingsSecurity.Encrypt(details.Iban),
      (object) "@AccountNumber",
      (object) MultiACHSettingsSecurity.Encrypt(details.AccountNumber),
      (object) "@RoutingNumber",
      (object) MultiACHSettingsSecurity.Encrypt(details.RoutingNumber),
      (object) "@ACHSettingsAccountID",
      (object) details.AccountId
    }) == 1)
    {
      int num = (int) MessageBox.Show("This entity type already has an entry for this account.", "Duplicate Account", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      failedControl = (Control) details.accountName;
      return false;
    }
    if (!formMultiACHSettingsEditor.CheckRequiredFieldValue(((Control) details.currencyComboBox).Text, "currency"))
    {
      failedControl = (Control) details.currencyComboBox;
      return false;
    }
    if (details.GetSelectedPaymentFormats().Any<string>())
      return true;
    int num1 = (int) MessageBox.Show("You must select at least one payment format to continue.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    failedControl = (Control) details.paymentFormat;
    return false;
  }

  private bool ValidateBankTab(ACHSettingsBankDetails bankDetails, out Control failedControl)
  {
    failedControl = (Control) null;
    if (!formMultiACHSettingsEditor.CheckRequiredFieldValue(bankDetails.BankName, "a bank name"))
    {
      failedControl = (Control) bankDetails.bankName;
      return false;
    }
    if (!formMultiACHSettingsEditor.CheckRequiredFieldValue(bankDetails.IsoCountryCode, "a country") || !formMultiACHSettingsEditor.CheckRequiredFieldValue(bankDetails.Address1, "an address") || !formMultiACHSettingsEditor.CheckRequiredFieldValue(bankDetails.City, "a city"))
    {
      failedControl = (Control) bankDetails.bankAddress;
      return false;
    }
    if (DefaultDatabase.ExecuteScalar<int>("dbo.spFin_CheckForDuplicate_Bank", new object[16 /*0x10*/]
    {
      (object) "@EntityGuid",
      (object) this._entityGuid,
      (object) "@BankName",
      (object) bankDetails.BankName,
      (object) "@BankAddress1",
      (object) bankDetails.Address1,
      (object) "@BankAddress2",
      (object) bankDetails.Address2,
      (object) "@BankCity",
      (object) bankDetails.City,
      (object) "@BankState",
      (object) bankDetails.State,
      (object) "@BankZipCode",
      (object) bankDetails.ZipCode,
      (object) "@ACHSettingsBankID",
      (object) bankDetails.BankId
    }) != 1)
      return true;
    int num = (int) MessageBox.Show("This entity already has an entry for this bank.", "Duplicate Bank", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    failedControl = (Control) bankDetails.bankName;
    return false;
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraToolbar ultraToolbar1 = new UltraToolbar("gridContext");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("gridContext");
    UltraToolbar ultraToolbar2 = new UltraToolbar("mainToolbar");
    ButtonTool buttonTool1 = new ButtonTool("SAVE");
    ButtonTool buttonTool2 = new ButtonTool("CANCEL");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("gridContext");
    ButtonTool buttonTool3 = new ButtonTool("EDIT");
    ButtonTool buttonTool4 = new ButtonTool("DELETE");
    ButtonTool buttonTool5 = new ButtonTool("DEFAULT");
    ButtonTool buttonTool6 = new ButtonTool("EDIT");
    ButtonTool buttonTool7 = new ButtonTool("DELETE");
    ButtonTool buttonTool8 = new ButtonTool("SAVE");
    Appearance appearance2 = new Appearance();
    ButtonTool buttonTool9 = new ButtonTool("CANCEL");
    Appearance appearance3 = new Appearance();
    ButtonTool buttonTool10 = new ButtonTool("DEFAULT");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraTab ultraTab = new UltraTab();
    Appearance appearance10 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formMultiACHSettingsEditor));
    this.ultraTabPageControl1 = new UltraTabPageControl();
    this.entityName = new MGATextBox();
    this.entityLabel = new Label();
    this._formACHSettingsManagement_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager = new UltraToolbarsManager(this.components);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formACHSettingsManagement_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.editPanel = new Panel();
    this.banksTabControl = new UltraTabControl();
    this.ultraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.entitySearch = new PictureBox();
    ((ISupportInitialize) this.entityName).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager).BeginInit();
    this.editPanel.SuspendLayout();
    ((ISupportInitialize) this.banksTabControl).BeginInit();
    ((Control) this.banksTabControl).SuspendLayout();
    ((ISupportInitialize) this.entitySearch).BeginInit();
    this.SuspendLayout();
    ((Control) this.ultraTabPageControl1).Font = new Font("Tahoma", 8.25f);
    ((Control) this.ultraTabPageControl1).Location = new Point(1, 23);
    ((Control) this.ultraTabPageControl1).Name = "ultraTabPageControl1";
    ((Control) this.ultraTabPageControl1).Size = new Size(478, 518);
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.entityName).Appearance = (AppearanceBase) appearance1;
    ((Control) this.entityName).BackColor = Color.White;
    ((Control) this.entityName).Location = new Point(67, 9);
    this.entityName.MGAStyle = MGAStyles.Blue;
    ((Control) this.entityName).Name = "entityName";
    ((EditorButtonControlBase) this.entityName).ReadOnly = true;
    ((Control) this.entityName).Size = new Size(381, 20);
    ((Control) this.entityName).TabIndex = 1;
    ((UltraControlBase) this.entityName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.entityName).UseOsThemes = (DefaultableBoolean) 2;
    this.entityLabel.AutoSize = true;
    this.entityLabel.BackColor = Color.Transparent;
    this.entityLabel.Location = new Point(12, 9);
    this.entityLabel.Name = "entityLabel";
    this.entityLabel.Size = new Size(39, 13);
    this.entityLabel.TabIndex = 30;
    this.entityLabel.Text = "Entity:";
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Left).Location = new Point(0, 70);
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Left).Name = "_formACHSettingsManagement_Toolbars_Dock_Area_Left";
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Left).Size = new Size(0, 556);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager;
    this.ultraToolbarsManager.DesignerFlags = 1;
    this.ultraToolbarsManager.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager.DockWithinContainerBaseType = typeof (FormBase);
    this.ultraToolbarsManager.MdiMergeable = false;
    this.ultraToolbarsManager.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager.Style = (ToolbarStyle) 5;
    ultraToolbar1.DockedColumn = 0;
    ultraToolbar1.DockedRow = 1;
    ((UltraToolbarBase) ultraToolbar1).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar1.Text = "gridContext";
    ultraToolbar1.Visible = false;
    ultraToolbar2.DockedColumn = 0;
    ultraToolbar2.DockedRow = 0;
    ultraToolbar2.IsMainMenuBar = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar2).NonInheritedTools.AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ultraToolbar2.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar2.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar2.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar2.Text = "mainToolbar";
    this.ultraToolbarsManager.Toolbars.AddRange(new UltraToolbar[2]
    {
      ultraToolbar1,
      ultraToolbar2
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "gridContext";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5
    });
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "Edit ACH Setting";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).Caption = "Delete ACH Setting";
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance2).Image = (object) Resources.disk;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Save";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance3).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance3;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance4).Image = (object) Resources.accept;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).Image = (object) Resources.accept;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance5;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "Set as Default";
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager.Tools).AddRange(new ToolBase[6]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10
    });
    this.ultraToolbarsManager.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager_ToolClick);
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Right).Location = new Point(486, 70);
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Right).Name = "_formACHSettingsManagement_Toolbars_Dock_Area_Right";
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Right).Size = new Size(0, 556);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Top).Name = "_formACHSettingsManagement_Toolbars_Dock_Area_Top";
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Top).Size = new Size(486, 70);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom).Location = new Point(0, 626);
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom).Name = "_formACHSettingsManagement_Toolbars_Dock_Area_Bottom";
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom).Size = new Size(486, 0);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager;
    this.editPanel.BackColor = Color.Transparent;
    this.editPanel.Controls.Add((Control) this.banksTabControl);
    this.editPanel.Controls.Add((Control) this.entitySearch);
    this.editPanel.Controls.Add((Control) this.entityLabel);
    this.editPanel.Controls.Add((Control) this.entityName);
    this.editPanel.Location = new Point(0, 45);
    this.editPanel.Name = "editPanel";
    this.editPanel.Size = new Size(485, 580);
    this.editPanel.TabIndex = 20;
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((UltraTabControlBase) this.banksTabControl).Appearance = (AppearanceBase) appearance6;
    ((UltraTabControlBase) this.banksTabControl).CloseButtonLocation = (TabCloseButtonLocation) 3;
    ((Control) this.banksTabControl).Controls.Add((Control) this.ultraTabSharedControlsPage1);
    ((Control) this.banksTabControl).Controls.Add((Control) this.ultraTabPageControl1);
    ((Control) this.banksTabControl).Font = new Font("Tahoma", 8.25f);
    ((Control) this.banksTabControl).Location = new Point(3, 35);
    ((Control) this.banksTabControl).Name = "banksTabControl";
    ((AppearanceBase) appearance7).Image = (object) Resources.book_add;
    ((UltraTabControlBase) this.banksTabControl).NewTabButtonAppearance = (AppearanceBase) appearance7;
    ((UltraTabControlBase) this.banksTabControl).NewTabButtonLocation = (NewTabButtonLocation) 3;
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((UltraTabControlBase) this.banksTabControl).SelectedTabAppearance = (AppearanceBase) appearance8;
    ((UltraTabControlBase) this.banksTabControl).SharedControlsPage = this.ultraTabSharedControlsPage1;
    ((Control) this.banksTabControl).Size = new Size(480, 542);
    ((AppearanceBase) appearance9).BackColor = Color.LightSteelBlue;
    ((UltraTabControlBase) this.banksTabControl).TabHeaderAreaAppearance = (AppearanceBase) appearance9;
    ((Control) this.banksTabControl).TabIndex = 3;
    ((UltraTabControlBase) this.banksTabControl).TabLayoutStyle = (TabLayoutStyle) 5;
    ((AppearanceBase) appearance10).FontData.BoldAsString = "True";
    ultraTab.ActiveAppearance = (AppearanceBase) appearance10;
    ultraTab.TabPage = this.ultraTabPageControl1;
    ultraTab.Text = "New Bank";
    ((UltraTabControlBase) this.banksTabControl).Tabs.AddRange(new UltraTab[1]
    {
      ultraTab
    });
    ((UltraControlBase) this.banksTabControl).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.banksTabControl).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTabControlBase) this.banksTabControl).ViewStyle = (ViewStyle) 4;
    ((UltraTabControlBase) this.banksTabControl).ActiveTabChanged += new ActiveTabChangedEventHandler(this.banksTabControl_ActiveTabChanged);
    ((UltraTabControlBase) this.banksTabControl).TabClosing += new TabClosingEventHandler(this.banksTabControl_TabClosing);
    ((UltraTabControlBase) this.banksTabControl).TabClosed += new TabClosedEventHandler(this.banksTabControl_TabClosed);
    ((UltraTabControlBase) this.banksTabControl).AfterNewTabButtonClicked += new AfterNewTabButtonClickedEventHandler(this.banksTabControl_AfterNewTabButtonClicked);
    ((Control) this.ultraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabSharedControlsPage1).Name = "ultraTabSharedControlsPage1";
    ((Control) this.ultraTabSharedControlsPage1).Size = new Size(478, 518);
    this.entitySearch.BorderStyle = BorderStyle.FixedSingle;
    this.entitySearch.Image = (Image) componentResourceManager.GetObject("entitySearch.Image");
    this.entitySearch.Location = new Point(454, 9);
    this.entitySearch.Name = "entitySearch";
    this.entitySearch.Size = new Size(20, 20);
    this.entitySearch.SizeMode = PictureBoxSizeMode.CenterImage;
    this.entitySearch.TabIndex = 36;
    this.entitySearch.TabStop = false;
    this.entitySearch.Click += new EventHandler(this.entitySearch_Click);
    this.ClientSize = new Size(486, 626);
    this.Controls.Add((Control) this.editPanel);
    this.Controls.Add((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formMultiACHSettingsEditor);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "New Setting";
    this.FormClosing += new FormClosingEventHandler(this.formMultiACHSettingsEditor_FormClosing);
    this.Load += new EventHandler(this.formMultiACHSettingsEditor_Load);
    this.Shown += new EventHandler(this.formMultiACHSettingsEditor_Shown);
    ((ISupportInitialize) this.entityName).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager).EndInit();
    this.editPanel.ResumeLayout(false);
    this.editPanel.PerformLayout();
    ((ISupportInitialize) this.banksTabControl).EndInit();
    ((Control) this.banksTabControl).ResumeLayout(false);
    ((ISupportInitialize) this.entitySearch).EndInit();
    this.ResumeLayout(false);
  }

  public enum ActiveRow
  {
    None,
    Entity,
    Bank,
    Account,
  }
}

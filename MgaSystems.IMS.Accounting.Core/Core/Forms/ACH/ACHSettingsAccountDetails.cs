// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.ACHSettingsAccountDetails
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH;

public class ACHSettingsAccountDetails : UserControl
{
  private IContainer components;
  private MGATextBox altPayee;
  private Label altPayeeLabel;
  public MGATextBox accountName;
  private Label accountNameLabel;
  public MGACheckBox isDefault;
  private Label paymentFormatLabel;
  public MGASimpleComboBox paymentFormat;
  private MGATextBox chipNumber;
  private Label chipLabel;
  public MGATextBox iban;
  private Label ibanLabel;
  private UltraOptionSet optionAccountType;
  private Label accountTypeLabel;
  public MGATextBox routingNumber;
  public MGATextBox accountNumber;
  private Label routingLabel;
  private Label accountNumberLabel;
  private Label accountId;
  private Label parentTabKey;
  private Label label1;
  public MGASimpleComboBox currencyComboBox;

  public int? AccountId
  {
    get
    {
      return !string.IsNullOrEmpty(this.accountId.Text) ? new int?(Convert.ToInt32(this.accountId.Text)) : new int?();
    }
    set => this.accountId.Text = value.HasValue ? value.ToString() : string.Empty;
  }

  public string AccountName
  {
    get => ACHSettingsAccountDetails.GetValueOrNull(((Control) this.accountName).Text, 150);
    set => ((Control) this.accountName).Text = value;
  }

  public string AlternativePayee
  {
    get => ACHSettingsAccountDetails.GetValueOrNull(((Control) this.altPayee).Text, 150);
    set => ((Control) this.altPayee).Text = value;
  }

  public string Iban
  {
    get => ACHSettingsAccountDetails.GetValueOrNull(((Control) this.iban).Text, 100);
    set => ((Control) this.iban).Text = value;
  }

  public string ChipNumber
  {
    get => ACHSettingsAccountDetails.GetValueOrNull(((Control) this.chipNumber).Text, 30);
    set => ((Control) this.chipNumber).Text = value;
  }

  public string AccountNumber
  {
    get => ACHSettingsAccountDetails.GetValueOrNull(((Control) this.accountNumber).Text, 45);
    set => ((Control) this.accountNumber).Text = value;
  }

  public string RoutingNumber
  {
    get => ACHSettingsAccountDetails.GetValueOrNull(((Control) this.routingNumber).Text, 25);
    set => ((Control) this.routingNumber).Text = value;
  }

  public object AccountType
  {
    get => this.optionAccountType.Value;
    set => this.optionAccountType.Value = value;
  }

  public bool IsDefault
  {
    get => ((UltraToggleEditorBase) this.isDefault).Checked;
    set => ((UltraToggleEditorBase) this.isDefault).Checked = value;
  }

  public string ParentTabKey
  {
    get => this.parentTabKey.Text;
    set => this.parentTabKey.Text = value;
  }

  public ACHSettingsAccountDetails()
  {
    this.InitializeComponent();
    this.EnablePaymentMethodMultiSelect();
  }

  public List<string> GetSelectedPaymentFormats()
  {
    return ((IEnumerable<UltraGridRow>) this.paymentFormat.CheckedRows).AsEnumerable<UltraGridRow>().Select<UltraGridRow, string>((System.Func<UltraGridRow, string>) (r => r.Field<string>("PayMethodID"))).ToList<string>();
  }

  public void LoadPaymentFormats(DataSet paymentFormats)
  {
    if (paymentFormats == null)
      throw new ArgumentNullException(nameof (paymentFormats));
    ((UltraControlBase) this.paymentFormat).BeginUpdate();
    ((UltraGridBase) this.paymentFormat).DataSource = (object) paymentFormats;
    ((UltraControlBase) this.paymentFormat).EndUpdate();
    this.SetSelectedPaymentFormats((IEnumerable<string>) new string[1]
    {
      "C"
    });
  }

  public void LoadCurrencies(DataSet currencies)
  {
    if (currencies == null)
      throw new ArgumentNullException(nameof (currencies));
    ((UltraControlBase) this.currencyComboBox).BeginUpdate();
    ((UltraGridBase) this.currencyComboBox).DataSource = (object) currencies;
    ((UltraDropDownBase) this.currencyComboBox).DisplayMember = "Currency";
    ((UltraDropDownBase) this.currencyComboBox).ValueMember = "Currency";
    ((UltraControlBase) this.currencyComboBox).EndUpdate();
    this.currencyComboBox.Value = (object) "USD";
  }

  public void SetSelectedPaymentFormats(IEnumerable<string> selectedPaymentFormats)
  {
    if (((UltraGridBase) this.paymentFormat).Rows == null)
      return;
    ((UltraControlBase) this.paymentFormat).BeginUpdate();
    List<UltraGridRow> list1 = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.paymentFormat).Rows).AsEnumerable<UltraGridRow>().Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (r => selectedPaymentFormats.Contains<string>(r.Field<string>("PayMethodID")))).ToList<UltraGridRow>();
    List<UltraGridRow> list2 = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.paymentFormat).Rows).AsEnumerable<UltraGridRow>().Except<UltraGridRow>((IEnumerable<UltraGridRow>) list1).ToList<UltraGridRow>();
    foreach (UltraGridRow ultraGridRow in list1)
      ultraGridRow.Cells["Selected"].Value = (object) true;
    foreach (UltraGridRow ultraGridRow in list2)
      ultraGridRow.Cells["Selected"].Value = (object) false;
    ((UltraControlBase) this.paymentFormat).EndUpdate();
  }

  public void SetCurrencyValue(string value)
  {
    if (value == null)
      throw new ArgumentNullException(nameof (value));
    if (string.IsNullOrWhiteSpace(value))
      return;
    this.currencyComboBox.Value = (object) value;
  }

  private void ACHSettingsAccountDetails_Load(object sender, EventArgs e)
  {
    this.optionAccountType.CheckedIndex = 0;
  }

  private static string GetValueOrNull(string value, int maxLength)
  {
    return !string.IsNullOrWhiteSpace(value) ? value.Truncate(maxLength) : (string) null;
  }

  private void EnablePaymentMethodMultiSelect()
  {
    UltraGridColumn ultraGridColumn = this.paymentFormat.DisplayLayout.Bands[0].Columns.Add();
    ultraGridColumn.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn.Header).Caption = string.Empty;
    ultraGridColumn.Header.CheckBoxVisibility = (HeaderCheckBoxVisibility) 2;
    ((HeaderBase) ultraGridColumn.Header).VisiblePosition = 0;
    ((KeyedSubObjectBase) ultraGridColumn).Key = "Selected";
    this.paymentFormat.CheckedListSettings.CheckStateMember = "Selected";
    ((EditorCheckedListSettings) this.paymentFormat.CheckedListSettings).EditorValueSource = (EditorWithComboValueSource) 1;
    ((EditorCheckedListSettings) this.paymentFormat.CheckedListSettings).ItemCheckArea = (ItemCheckArea) 1;
  }

  private void accountNumber_ValueChanged(object sender, EventArgs e)
  {
    if (this.accountNumber.PasswordChar == char.MinValue)
      return;
    ((Control) this.accountNumber).Text = string.Empty;
    this.accountNumber.PasswordChar = char.MinValue;
  }

  private void routingNumber_ValueChanged(object sender, EventArgs e)
  {
    if (this.routingNumber.PasswordChar == char.MinValue)
      return;
    ((Control) this.routingNumber).Text = string.Empty;
    this.routingNumber.PasswordChar = char.MinValue;
  }

  private void iban_ValueChanged(object sender, EventArgs e)
  {
    if (this.iban.PasswordChar == char.MinValue)
      return;
    ((Control) this.iban).Text = string.Empty;
    this.iban.PasswordChar = char.MinValue;
  }

  private void paymentFormat_AfterDropDown(object sender, EventArgs e)
  {
    this.paymentFormat.DisplayLayout.Bands[0].Columns["Selected"].Hidden = false;
  }

  protected void ComboBox_ItemNotInList(object sender, ValidationErrorEventArgs e)
  {
    if (!string.IsNullOrEmpty(e.InvalidText))
      return;
    e.RetainFocus = false;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    this.altPayee = new MGATextBox();
    this.altPayeeLabel = new Label();
    this.accountName = new MGATextBox();
    this.accountNameLabel = new Label();
    this.isDefault = new MGACheckBox();
    this.paymentFormatLabel = new Label();
    this.paymentFormat = new MGASimpleComboBox();
    this.chipNumber = new MGATextBox();
    this.chipLabel = new Label();
    this.iban = new MGATextBox();
    this.ibanLabel = new Label();
    this.optionAccountType = new UltraOptionSet();
    this.accountTypeLabel = new Label();
    this.routingNumber = new MGATextBox();
    this.accountNumber = new MGATextBox();
    this.routingLabel = new Label();
    this.accountNumberLabel = new Label();
    this.accountId = new Label();
    this.parentTabKey = new Label();
    this.label1 = new Label();
    this.currencyComboBox = new MGASimpleComboBox();
    ((ISupportInitialize) this.altPayee).BeginInit();
    ((ISupportInitialize) this.accountName).BeginInit();
    ((ISupportInitialize) this.isDefault).BeginInit();
    ((ISupportInitialize) this.paymentFormat).BeginInit();
    ((ISupportInitialize) this.chipNumber).BeginInit();
    ((ISupportInitialize) this.iban).BeginInit();
    ((ISupportInitialize) this.optionAccountType).BeginInit();
    ((ISupportInitialize) this.routingNumber).BeginInit();
    ((ISupportInitialize) this.accountNumber).BeginInit();
    ((ISupportInitialize) this.currencyComboBox).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.altPayee).Appearance = (AppearanceBase) appearance1;
    ((Control) this.altPayee).BackColor = Color.White;
    ((Control) this.altPayee).Location = new Point(105, 30);
    ((TextEditorControlBase) this.altPayee).MaxLength = 150;
    this.altPayee.MGAStyle = MGAStyles.Blue;
    ((Control) this.altPayee).Name = "altPayee";
    ((Control) this.altPayee).Size = new Size(360, 20);
    ((Control) this.altPayee).TabIndex = 2;
    ((UltraControlBase) this.altPayee).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.altPayee).UseOsThemes = (DefaultableBoolean) 2;
    this.altPayeeLabel.AutoSize = true;
    this.altPayeeLabel.BackColor = Color.Transparent;
    this.altPayeeLabel.Location = new Point(3, 30);
    this.altPayeeLabel.Name = "altPayeeLabel";
    this.altPayeeLabel.Size = new Size(61, 13);
    this.altPayeeLabel.TabIndex = 111;
    this.altPayeeLabel.Text = "Alt. Payee:";
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.accountName).Appearance = (AppearanceBase) appearance2;
    ((Control) this.accountName).BackColor = Color.White;
    ((Control) this.accountName).Location = new Point(105, 6);
    ((TextEditorControlBase) this.accountName).MaxLength = 100;
    this.accountName.MGAStyle = MGAStyles.Blue;
    ((Control) this.accountName).Name = "accountName";
    ((Control) this.accountName).Size = new Size(360, 20);
    ((Control) this.accountName).TabIndex = 1;
    ((UltraControlBase) this.accountName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.accountName).UseOsThemes = (DefaultableBoolean) 2;
    this.accountNameLabel.AutoSize = true;
    this.accountNameLabel.BackColor = Color.Transparent;
    this.accountNameLabel.Location = new Point(3, 6);
    this.accountNameLabel.Name = "accountNameLabel";
    this.accountNameLabel.Size = new Size(80 /*0x50*/, 13);
    this.accountNameLabel.TabIndex = 109;
    this.accountNameLabel.Text = "Account Name:";
    ((AppearanceBase) appearance3).BorderColor = Color.Gray;
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.isDefault).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.isDefault).CheckAlign = ContentAlignment.MiddleRight;
    ((UltraToggleEditorBase) this.isDefault).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.isDefault).Location = new Point(3, 223);
    ((Control) this.isDefault).Name = "isDefault";
    ((Control) this.isDefault).Size = new Size(116, 20);
    ((Control) this.isDefault).TabIndex = 10;
    ((Control) this.isDefault).Text = "Default Account:";
    ((UltraControlBase) this.isDefault).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.isDefault).UseOsThemes = (DefaultableBoolean) 2;
    this.paymentFormatLabel.AutoSize = true;
    this.paymentFormatLabel.BackColor = Color.Transparent;
    this.paymentFormatLabel.Location = new Point(3, 173);
    this.paymentFormatLabel.Name = "paymentFormatLabel";
    this.paymentFormatLabel.Size = new Size(90, 13);
    this.paymentFormatLabel.TabIndex = 107;
    this.paymentFormatLabel.Text = "Payment Format:";
    this.paymentFormat.BorderStyle = (UIElementBorderStyle) 4;
    this.paymentFormat.CheckedListSettings.CheckStateMember = "Selected";
    ((EditorCheckedListSettings) this.paymentFormat.CheckedListSettings).EditorValueSource = (EditorWithComboValueSource) 1;
    ((EditorCheckedListSettings) this.paymentFormat.CheckedListSettings).ItemCheckArea = (ItemCheckArea) 1;
    ((UltraDropDownBase) this.paymentFormat).DisplayMember = "MethodName";
    this.paymentFormat.DropDownStyle = (UltraComboStyle) 1;
    this.paymentFormat.LimitToList = true;
    ((Control) this.paymentFormat).Location = new Point(105, 173);
    this.paymentFormat.MGAStyle = MGAStyles.Blue;
    ((Control) this.paymentFormat).Name = "paymentFormat";
    ((Control) this.paymentFormat).Size = new Size(360, 21);
    ((Control) this.paymentFormat).TabIndex = 8;
    ((UltraControlBase) this.paymentFormat).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.paymentFormat).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.paymentFormat).ValueMember = "PayMethodID";
    this.paymentFormat.AfterDropDown += new EventHandler(this.paymentFormat_AfterDropDown);
    this.paymentFormat.ItemNotInList += new ItemNotInListEventHandler(this.ComboBox_ItemNotInList);
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.chipNumber).Appearance = (AppearanceBase) appearance4;
    ((Control) this.chipNumber).BackColor = Color.White;
    ((Control) this.chipNumber).Location = new Point(105, 148);
    ((TextEditorControlBase) this.chipNumber).MaxLength = 30;
    this.chipNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.chipNumber).Name = "chipNumber";
    ((Control) this.chipNumber).Size = new Size(360, 20);
    ((Control) this.chipNumber).TabIndex = 7;
    ((UltraControlBase) this.chipNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chipNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.chipLabel.AutoSize = true;
    this.chipLabel.BackColor = Color.Transparent;
    this.chipLabel.Location = new Point(3, 148);
    this.chipLabel.Name = "chipLabel";
    this.chipLabel.Size = new Size(100, 13);
    this.chipLabel.TabIndex = 104;
    this.chipLabel.Text = "CHIP Participant #:";
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((TextEditorControlBase) this.iban).Appearance = (AppearanceBase) appearance5;
    ((Control) this.iban).BackColor = Color.White;
    ((Control) this.iban).Location = new Point(105, 123);
    ((TextEditorControlBase) this.iban).MaxLength = 50;
    this.iban.MGAStyle = MGAStyles.Blue;
    ((Control) this.iban).Name = "iban";
    ((Control) this.iban).Size = new Size(360, 20);
    ((Control) this.iban).TabIndex = 6;
    ((UltraControlBase) this.iban).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.iban).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.iban).ValueChanged += new EventHandler(this.iban_ValueChanged);
    this.ibanLabel.AutoSize = true;
    this.ibanLabel.BackColor = Color.Transparent;
    this.ibanLabel.Location = new Point(3, 126);
    this.ibanLabel.Name = "ibanLabel";
    this.ibanLabel.Size = new Size(35, 13);
    this.ibanLabel.TabIndex = 102;
    this.ibanLabel.Text = "IBAN:";
    this.optionAccountType.BorderStyle = (UIElementBorderStyle) 1;
    this.optionAccountType.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem1.CheckState = CheckState.Checked;
    valueListItem1.DataValue = (object) "C";
    valueListItem1.DisplayText = "Checking";
    valueListItem2.DataValue = (object) "S";
    valueListItem2.DisplayText = "Savings";
    this.optionAccountType.Items.AddRange(new ValueListItem[2]
    {
      valueListItem1,
      valueListItem2
    });
    ((Control) this.optionAccountType).Location = new Point(107, 104);
    ((Control) this.optionAccountType).Name = "optionAccountType";
    ((Control) this.optionAccountType).Size = new Size(152, 19);
    ((Control) this.optionAccountType).TabIndex = 5;
    this.accountTypeLabel.AutoSize = true;
    this.accountTypeLabel.BackColor = Color.Transparent;
    this.accountTypeLabel.Location = new Point(3, 103);
    this.accountTypeLabel.Name = "accountTypeLabel";
    this.accountTypeLabel.Size = new Size(77, 13);
    this.accountTypeLabel.TabIndex = 100;
    this.accountTypeLabel.Text = "Account Type:";
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((TextEditorControlBase) this.routingNumber).Appearance = (AppearanceBase) appearance6;
    ((Control) this.routingNumber).BackColor = Color.White;
    ((Control) this.routingNumber).Location = new Point(105, 78);
    ((TextEditorControlBase) this.routingNumber).MaxLength = 25;
    this.routingNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.routingNumber).Name = "routingNumber";
    ((Control) this.routingNumber).Size = new Size(360, 20);
    ((Control) this.routingNumber).TabIndex = 4;
    ((UltraControlBase) this.routingNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.routingNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.routingNumber).ValueChanged += new EventHandler(this.routingNumber_ValueChanged);
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((TextEditorControlBase) this.accountNumber).Appearance = (AppearanceBase) appearance7;
    ((Control) this.accountNumber).BackColor = Color.White;
    ((Control) this.accountNumber).Location = new Point(105, 54);
    ((TextEditorControlBase) this.accountNumber).MaxLength = 45;
    this.accountNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.accountNumber).Name = "accountNumber";
    ((Control) this.accountNumber).Size = new Size(360, 20);
    ((Control) this.accountNumber).TabIndex = 3;
    ((UltraControlBase) this.accountNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.accountNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.accountNumber).ValueChanged += new EventHandler(this.accountNumber_ValueChanged);
    this.routingLabel.AutoSize = true;
    this.routingLabel.BackColor = Color.Transparent;
    this.routingLabel.Location = new Point(3, 78);
    this.routingLabel.Name = "routingLabel";
    this.routingLabel.Size = new Size(59, 13);
    this.routingLabel.TabIndex = 98;
    this.routingLabel.Text = "Routing #:";
    this.accountNumberLabel.AutoSize = true;
    this.accountNumberLabel.BackColor = Color.Transparent;
    this.accountNumberLabel.Location = new Point(3, 54);
    this.accountNumberLabel.Name = "accountNumberLabel";
    this.accountNumberLabel.Size = new Size(61, 13);
    this.accountNumberLabel.TabIndex = 96 /*0x60*/;
    this.accountNumberLabel.Text = "Account #:";
    this.accountId.AutoSize = true;
    this.accountId.Location = new Point(6, 236);
    this.accountId.Name = "accountId";
    this.accountId.Size = new Size(0, 13);
    this.accountId.TabIndex = 113;
    this.accountId.Visible = false;
    this.parentTabKey.AutoSize = true;
    this.parentTabKey.Location = new Point(424, 207);
    this.parentTabKey.Name = "parentTabKey";
    this.parentTabKey.Size = new Size(0, 13);
    this.parentTabKey.TabIndex = 114;
    this.parentTabKey.Visible = false;
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(3, 199);
    this.label1.Name = "label1";
    this.label1.Size = new Size(55, 13);
    this.label1.TabIndex = 115;
    this.label1.Text = "Currency:";
    this.currencyComboBox.BorderStyle = (UIElementBorderStyle) 4;
    this.currencyComboBox.DropDownStyle = (UltraComboStyle) 1;
    this.currencyComboBox.LimitToList = true;
    ((Control) this.currencyComboBox).Location = new Point(105, 199);
    this.currencyComboBox.MGAStyle = MGAStyles.Blue;
    ((Control) this.currencyComboBox).Name = "currencyComboBox";
    ((Control) this.currencyComboBox).Size = new Size(112 /*0x70*/, 21);
    ((Control) this.currencyComboBox).TabIndex = 9;
    ((UltraControlBase) this.currencyComboBox).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.currencyComboBox).UseOsThemes = (DefaultableBoolean) 2;
    this.currencyComboBox.ItemNotInList += new ItemNotInListEventHandler(this.ComboBox_ItemNotInList);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.currencyComboBox);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.parentTabKey);
    this.Controls.Add((Control) this.accountId);
    this.Controls.Add((Control) this.altPayee);
    this.Controls.Add((Control) this.altPayeeLabel);
    this.Controls.Add((Control) this.accountName);
    this.Controls.Add((Control) this.accountNameLabel);
    this.Controls.Add((Control) this.isDefault);
    this.Controls.Add((Control) this.paymentFormatLabel);
    this.Controls.Add((Control) this.paymentFormat);
    this.Controls.Add((Control) this.chipNumber);
    this.Controls.Add((Control) this.chipLabel);
    this.Controls.Add((Control) this.iban);
    this.Controls.Add((Control) this.ibanLabel);
    this.Controls.Add((Control) this.optionAccountType);
    this.Controls.Add((Control) this.accountTypeLabel);
    this.Controls.Add((Control) this.routingNumber);
    this.Controls.Add((Control) this.accountNumber);
    this.Controls.Add((Control) this.routingLabel);
    this.Controls.Add((Control) this.accountNumberLabel);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (ACHSettingsAccountDetails);
    this.Size = new Size(471, 244);
    this.Load += new EventHandler(this.ACHSettingsAccountDetails_Load);
    ((ISupportInitialize) this.altPayee).EndInit();
    ((ISupportInitialize) this.accountName).EndInit();
    ((ISupportInitialize) this.isDefault).EndInit();
    ((ISupportInitialize) this.paymentFormat).EndInit();
    ((ISupportInitialize) this.chipNumber).EndInit();
    ((ISupportInitialize) this.iban).EndInit();
    ((ISupportInitialize) this.optionAccountType).EndInit();
    ((ISupportInitialize) this.routingNumber).EndInit();
    ((ISupportInitialize) this.accountNumber).EndInit();
    ((ISupportInitialize) this.currencyComboBox).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}

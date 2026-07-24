// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.ACHEntry
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH;

public class ACHEntry : UserControl
{
  private IContainer components;
  private PictureBox picSearch;
  private MGATextBox textEntityName;
  private Label label6;
  private MGAButton buttonSave;
  private MGAButton buttonCancel;
  private UltraOptionSet optionAccountType;
  private MGATextBox textRoutingNumber;
  private MGATextBox textAccountNumber;
  private MGATextBox textBankName;
  private MGATextBox textAccountName;
  private Label label5;
  private Label label4;
  private Label label3;
  private Label label2;
  private Label label1;
  private MGATextBox textSWIFTCode;
  private MGATextBox textIBAN;
  private Label label7;
  private Label label8;
  private AddressResolver_MULTI addressBank;
  private MGATextBox textCHIPNumber;
  private Label label9;
  private MGASimpleComboBox comboPaymentFormats;
  private Label label10;

  public Guid EntityGuid { get; set; }

  public string EntityName
  {
    get => ((Control) this.textEntityName).Text;
    set => ((Control) this.textEntityName).Text = value;
  }

  public string AccountName
  {
    get => ((Control) this.textAccountName).Text;
    set => ((Control) this.textAccountName).Text = value;
  }

  public string BankName
  {
    get => ((Control) this.textBankName).Text;
    set => ((Control) this.textBankName).Text = value;
  }

  public string AccountNumber
  {
    get => ((Control) this.textAccountNumber).Text;
    set => ((Control) this.textAccountNumber).Text = value;
  }

  public string RoutingNumber
  {
    get => ((Control) this.textRoutingNumber).Text;
    set => ((Control) this.textRoutingNumber).Text = value;
  }

  public string AccountType
  {
    get => this.optionAccountType.Value != null ? this.optionAccountType.Value.ToString() : "C";
    set => this.optionAccountType.Value = (object) value;
  }

  public string IBAN
  {
    get => ((Control) this.textIBAN).Text;
    set => ((Control) this.textIBAN).Text = value;
  }

  public string SWIFTCode
  {
    get => ((Control) this.textSWIFTCode).Text;
    set => ((Control) this.textSWIFTCode).Text = value;
  }

  public string CHIPNumber
  {
    get => ((Control) this.textCHIPNumber).Text;
    set => ((Control) this.textCHIPNumber).Text = value;
  }

  public string BankCountryCode
  {
    get => this.addressBank.ISOCountryCode;
    set => this.addressBank.ISOCountryCode = value;
  }

  public string BankAddress1
  {
    get => this.addressBank.Address1;
    set => this.addressBank.Address1 = value;
  }

  public string BankAddress2
  {
    get => this.addressBank.Address2;
    set => this.addressBank.Address2 = value;
  }

  public string BankCity
  {
    get => this.addressBank.City;
    set => this.addressBank.City = value;
  }

  public string BankState
  {
    get => this.addressBank.State;
    set => this.addressBank.State = value;
  }

  public string BankZipCode
  {
    get => this.addressBank.ZipCode;
    set => this.addressBank.ISOCountryCode = value;
  }

  public int PaymentFormat
  {
    get
    {
      return ((UltraDropDownBase) this.comboPaymentFormats).SelectedRow == null ? -1 : (int) this.comboPaymentFormats.Value;
    }
    set => this.comboPaymentFormats.Value = (object) value;
  }

  public ACHEntry() => this.InitializeComponent();

  private bool ValidateInputs()
  {
    if (string.IsNullOrEmpty(((Control) this.textAccountName).Text))
    {
      int num = (int) MessageBox.Show("You must enter an account name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (string.IsNullOrEmpty(((Control) this.textBankName).Text))
    {
      int num = (int) MessageBox.Show("You must enter a bank name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (string.IsNullOrEmpty(((Control) this.textAccountNumber).Text))
    {
      int num = (int) MessageBox.Show("You must enter an account number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!string.IsNullOrEmpty(((Control) this.textRoutingNumber).Text))
      return true;
    int num1 = (int) MessageBox.Show("You must enter a routing number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateInputs())
      return;
    this.Save();
    this.ClearScreen();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.ClearScreen();
    this.ParentForm.DialogResult = DialogResult.Cancel;
    this.ParentForm.Close();
  }

  private void ClearScreen()
  {
    foreach (Control control in this.Controls.OfType<MGATextBox>())
      control.Text = string.Empty;
    this.addressBank.Clear();
    this.optionAccountType.Value = (object) "C";
    this.EntityGuid = Guid.Empty;
  }

  private void Save()
  {
    Encryption encryption = new Encryption();
    DefaultDatabase.ExecuteNonQuery("spFin_SaveACHInformation", new object[36]
    {
      (object) "@entityGuid",
      (object) this.EntityGuid,
      (object) "@accountName",
      (object) this.AccountName,
      (object) "@accountNumber",
      (object) encryption.EncryptTripleDes(this.AccountNumber),
      (object) "@routingNumber",
      (object) encryption.EncryptTripleDes(this.RoutingNumber),
      (object) "@accountType",
      (object) this.AccountType,
      (object) "@bankName",
      (object) this.BankName,
      (object) "@enteredBy",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@dateEntered",
      (object) DateTime.Now,
      (object) "@IBAN",
      (object) encryption.EncryptTripleDes(this.IBAN),
      (object) "@SWIFTCode",
      (object) encryption.EncryptTripleDes(this.SWIFTCode),
      (object) "@BankISOCountryCode",
      (object) this.BankCountryCode,
      (object) "@BankAddress1",
      (object) this.BankAddress1,
      (object) "@BankAddress2",
      (object) this.BankAddress2,
      (object) "@BankCity",
      (object) this.BankCity,
      (object) "@BankState",
      (object) this.BankState,
      (object) "@BankZipCode",
      (object) this.BankZipCode,
      (object) "@CHIPNumber",
      (object) encryption.EncryptTripleDes(this.CHIPNumber),
      (object) "@PaymentFormatId",
      (object) this.PaymentFormat
    });
    this.OnACHSaveComplete();
    if (this.ParentForm.GetType() == typeof (ACHEntry))
    {
      this.ParentForm.DialogResult = DialogResult.OK;
      this.ParentForm.Close();
    }
    else
      this.ClearScreen();
  }

  public void SetEntityGuid(Guid entityGuid)
  {
    this.EntityGuid = entityGuid;
    ((Control) this.textAccountName).Text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.GetEntityName(@entityGuid)", new object[2]
    {
      (object) "@entityGuid",
      (object) entityGuid
    });
    this.SetEntityName(((Control) this.textAccountName).Text);
  }

  public void LoadACHInformation(Guid entityGuid)
  {
    this.EntityGuid = entityGuid;
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("spFin_GetEntityACHInformation", new object[2]
    {
      (object) "@entityGuid",
      (object) this.EntityGuid
    });
    if (dataRow == null)
      return;
    this.AccountNumber = this.DecryptValue(ExtensionsMethods.FieldIsNull<string>(dataRow, "AccountNumber", string.Empty));
    this.RoutingNumber = this.DecryptValue(ExtensionsMethods.FieldIsNull<string>(dataRow, "RoutingNumber", string.Empty));
    this.IBAN = this.DecryptValue(ExtensionsMethods.FieldIsNull<string>(dataRow, "IBAN", string.Empty));
    this.SWIFTCode = this.DecryptValue(ExtensionsMethods.FieldIsNull<string>(dataRow, "SWIFTCode", string.Empty));
    this.CHIPNumber = this.DecryptValue(ExtensionsMethods.FieldIsNull<string>(dataRow, "CHIPNumber", string.Empty));
    this.AccountName = ExtensionsMethods.FieldIsNull<string>(dataRow, "AccountName", string.Empty);
    this.BankName = ExtensionsMethods.FieldIsNull<string>(dataRow, "BankName", string.Empty);
    this.AccountType = ExtensionsMethods.FieldIsNull<string>(dataRow, "AccountType", string.Empty);
    this.BankCountryCode = ExtensionsMethods.FieldIsNull<string>(dataRow, "BankISOCountryCode", string.Empty);
    this.BankAddress1 = ExtensionsMethods.FieldIsNull<string>(dataRow, "BankAddress1", string.Empty);
    this.BankAddress2 = ExtensionsMethods.FieldIsNull<string>(dataRow, "BankAddress2", string.Empty);
    this.BankCity = ExtensionsMethods.FieldIsNull<string>(dataRow, "BankCity", string.Empty);
    this.BankState = ExtensionsMethods.FieldIsNull<string>(dataRow, "BankState", string.Empty);
    this.BankZipCode = ExtensionsMethods.FieldIsNull<string>(dataRow, "BankZipCode", string.Empty);
    this.PaymentFormat = ExtensionsMethods.FieldIsNull<int>(dataRow, "PaymentFormatId", -1);
    this.SetEntityName(this.EntityGuid);
  }

  private string DecryptValue(string valueString)
  {
    Encryption encryption = new Encryption();
    if (!string.IsNullOrEmpty(valueString.ToString()) && Utility.IsBase64(valueString.ToString()))
      return encryption.DecryptTripleDes(valueString.ToString());
    return string.IsNullOrEmpty(valueString.ToString()) ? string.Empty : valueString;
  }

  private void SetEntityName(string entityName)
  {
    ((Control) this.textEntityName).Text = entityName;
  }

  private void SetEntityName(Guid entityGuid)
  {
    ((Control) this.textEntityName).Text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.GetEntityName(@entityGuid)", new object[2]
    {
      (object) "@entityGuid",
      (object) entityGuid
    });
  }

  public void LoadACHInformation(
    Guid entityGuid,
    string accountName,
    string accountNumber,
    string routingNumber,
    string bankName,
    string accountType)
  {
    this.EntityGuid = entityGuid;
    this.AccountName = accountName;
    this.AccountNumber = accountNumber;
    this.RoutingNumber = routingNumber;
    this.BankName = bankName;
    this.AccountType = accountType;
    this.SetEntityName(this.EntityGuid);
  }

  [Browsable(true)]
  [EditorBrowsable(EditorBrowsableState.Always)]
  public event ACHEntry.ACHSaveCompleteHandler ACHSaveComplete;

  protected void OnACHSaveComplete()
  {
    ACHEntry.ACHSaveCompleteHandler achSaveComplete = this.ACHSaveComplete;
    if (achSaveComplete == null)
      return;
    achSaveComplete((object) this, new ACHSaveCompleteArgs(this.EntityGuid, this.AccountName, this.AccountNumber, this.BankName, this.RoutingNumber, this.AccountType));
  }

  private void picSearch_Click(object sender, EventArgs e)
  {
    using (FormSearchEntity formSearchEntity = new FormSearchEntity(Utility.SearchEntityTypes.All))
    {
      if (formSearchEntity.ShowDialog() != DialogResult.OK)
        return;
      this.EntityGuid = formSearchEntity.EntityGuid;
      this.AccountName = formSearchEntity.EntityName;
      ((Control) this.textEntityName).Text = formSearchEntity.EntityName;
    }
  }

  private void LoadPaymentFormats()
  {
    ((UltraGridBase) this.comboPaymentFormats).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_GetPaymentFormatList");
    ((UltraDropDownBase) this.comboPaymentFormats).DisplayMember = "PaymentFormat";
    ((UltraDropDownBase) this.comboPaymentFormats).ValueMember = "PaymentFormatId";
  }

  private void ACHEntry_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadPaymentFormats();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ACHEntry));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    this.picSearch = new PictureBox();
    this.textEntityName = new MGATextBox();
    this.label6 = new Label();
    this.buttonSave = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.optionAccountType = new UltraOptionSet();
    this.textRoutingNumber = new MGATextBox();
    this.textAccountNumber = new MGATextBox();
    this.textBankName = new MGATextBox();
    this.textAccountName = new MGATextBox();
    this.label5 = new Label();
    this.label4 = new Label();
    this.label3 = new Label();
    this.label2 = new Label();
    this.label1 = new Label();
    this.textSWIFTCode = new MGATextBox();
    this.textIBAN = new MGATextBox();
    this.label7 = new Label();
    this.label8 = new Label();
    this.addressBank = new AddressResolver_MULTI();
    this.textCHIPNumber = new MGATextBox();
    this.label9 = new Label();
    this.comboPaymentFormats = new MGASimpleComboBox();
    this.label10 = new Label();
    ((ISupportInitialize) this.picSearch).BeginInit();
    ((ISupportInitialize) this.textEntityName).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.optionAccountType).BeginInit();
    ((ISupportInitialize) this.textRoutingNumber).BeginInit();
    ((ISupportInitialize) this.textAccountNumber).BeginInit();
    ((ISupportInitialize) this.textBankName).BeginInit();
    ((ISupportInitialize) this.textAccountName).BeginInit();
    ((ISupportInitialize) this.textSWIFTCode).BeginInit();
    ((ISupportInitialize) this.textIBAN).BeginInit();
    ((ISupportInitialize) this.textCHIPNumber).BeginInit();
    ((ISupportInitialize) this.comboPaymentFormats).BeginInit();
    this.SuspendLayout();
    this.picSearch.BorderStyle = BorderStyle.FixedSingle;
    this.picSearch.Image = (Image) componentResourceManager.GetObject("picSearch.Image");
    this.picSearch.Location = new Point(341, 4);
    this.picSearch.Name = "picSearch";
    this.picSearch.Size = new Size(20, 20);
    this.picSearch.SizeMode = PictureBoxSizeMode.CenterImage;
    this.picSearch.TabIndex = 29;
    this.picSearch.TabStop = false;
    this.picSearch.Click += new EventHandler(this.picSearch_Click);
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEntityName).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textEntityName).BackColor = Color.White;
    ((Control) this.textEntityName).Location = new Point(110, 4);
    this.textEntityName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textEntityName).Name = "textEntityName";
    ((EditorButtonControlBase) this.textEntityName).ReadOnly = true;
    ((Control) this.textEntityName).Size = new Size(230, 20);
    ((Control) this.textEntityName).TabIndex = 1;
    ((UltraControlBase) this.textEntityName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEntityName).UseOsThemes = (DefaultableBoolean) 2;
    this.label6.AutoSize = true;
    this.label6.BackColor = Color.Transparent;
    this.label6.Location = new Point(8, 4);
    this.label6.Name = "label6";
    this.label6.Size = new Size(80 /*0x50*/, 13);
    this.label6.TabIndex = 0;
    this.label6.Text = "Account Name:";
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).Image = componentResourceManager.GetObject("appearance11.Image");
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonSave).Location = new Point(196, 435);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(81, 28);
    ((Control) this.buttonSave).TabIndex = 19;
    ((Control) this.buttonSave).Text = "Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).Image = componentResourceManager.GetObject("appearance12.Image");
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonCancel).Location = new Point(283, 435);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(81, 28);
    ((Control) this.buttonCancel).TabIndex = 20;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
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
    ((Control) this.optionAccountType).Location = new Point(110, 146);
    ((Control) this.optionAccountType).Name = "optionAccountType";
    ((Control) this.optionAccountType).Size = new Size(152, 19);
    ((Control) this.optionAccountType).TabIndex = 11;
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textRoutingNumber).Appearance = (AppearanceBase) appearance4;
    ((Control) this.textRoutingNumber).BackColor = Color.White;
    ((Control) this.textRoutingNumber).Location = new Point(110, 116);
    ((TextEditorControlBase) this.textRoutingNumber).MaxLength = 25;
    this.textRoutingNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textRoutingNumber).Name = "textRoutingNumber";
    ((Control) this.textRoutingNumber).Size = new Size(254, 20);
    ((Control) this.textRoutingNumber).TabIndex = 9;
    ((UltraControlBase) this.textRoutingNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textRoutingNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textAccountNumber).Appearance = (AppearanceBase) appearance5;
    ((Control) this.textAccountNumber).BackColor = Color.White;
    ((Control) this.textAccountNumber).Location = new Point(110, 88);
    ((TextEditorControlBase) this.textAccountNumber).MaxLength = 45;
    this.textAccountNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textAccountNumber).Name = "textAccountNumber";
    ((Control) this.textAccountNumber).Size = new Size(254, 20);
    ((Control) this.textAccountNumber).TabIndex = 7;
    ((UltraControlBase) this.textAccountNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textAccountNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankName).Appearance = (AppearanceBase) appearance6;
    ((Control) this.textBankName).BackColor = Color.White;
    ((Control) this.textBankName).Location = new Point(110, 60);
    ((TextEditorControlBase) this.textBankName).MaxLength = 300;
    this.textBankName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankName).Name = "textBankName";
    ((Control) this.textBankName).Size = new Size(254, 20);
    ((Control) this.textBankName).TabIndex = 5;
    ((UltraControlBase) this.textBankName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textAccountName).Appearance = (AppearanceBase) appearance7;
    ((Control) this.textAccountName).BackColor = Color.White;
    ((Control) this.textAccountName).Location = new Point(110, 32 /*0x20*/);
    ((TextEditorControlBase) this.textAccountName).MaxLength = 150;
    this.textAccountName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textAccountName).Name = "textAccountName";
    ((Control) this.textAccountName).Size = new Size(254, 20);
    ((Control) this.textAccountName).TabIndex = 3;
    ((UltraControlBase) this.textAccountName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textAccountName).UseOsThemes = (DefaultableBoolean) 2;
    this.label5.AutoSize = true;
    this.label5.BackColor = Color.Transparent;
    this.label5.Location = new Point(6, 144 /*0x90*/);
    this.label5.Name = "label5";
    this.label5.Size = new Size(77, 13);
    this.label5.TabIndex = 10;
    this.label5.Text = "Account Type:";
    this.label4.AutoSize = true;
    this.label4.BackColor = Color.Transparent;
    this.label4.Location = new Point(8, 60);
    this.label4.Name = "label4";
    this.label4.Size = new Size(64 /*0x40*/, 13);
    this.label4.TabIndex = 4;
    this.label4.Text = "Bank Name:";
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(8, 116);
    this.label3.Name = "label3";
    this.label3.Size = new Size(59, 13);
    this.label3.TabIndex = 8;
    this.label3.Text = "Routing #:";
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(8, 88);
    this.label2.Name = "label2";
    this.label2.Size = new Size(61, 13);
    this.label2.TabIndex = 6;
    this.label2.Text = "Account #:";
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(8, 32 /*0x20*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(80 /*0x50*/, 13);
    this.label1.TabIndex = 2;
    this.label1.Text = "Account Name:";
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textSWIFTCode).Appearance = (AppearanceBase) appearance8;
    ((Control) this.textSWIFTCode).BackColor = Color.White;
    ((Control) this.textSWIFTCode).Location = new Point(110, 201);
    ((TextEditorControlBase) this.textSWIFTCode).MaxLength = 100;
    this.textSWIFTCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.textSWIFTCode).Name = "textSWIFTCode";
    ((Control) this.textSWIFTCode).Size = new Size(254, 20);
    ((Control) this.textSWIFTCode).TabIndex = 15;
    ((UltraControlBase) this.textSWIFTCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textSWIFTCode).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textIBAN).Appearance = (AppearanceBase) appearance9;
    ((Control) this.textIBAN).BackColor = Color.White;
    ((Control) this.textIBAN).Location = new Point(110, 173);
    ((TextEditorControlBase) this.textIBAN).MaxLength = 100;
    this.textIBAN.MGAStyle = MGAStyles.Blue;
    ((Control) this.textIBAN).Name = "textIBAN";
    ((Control) this.textIBAN).Size = new Size(254, 20);
    ((Control) this.textIBAN).TabIndex = 13;
    ((UltraControlBase) this.textIBAN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textIBAN).UseOsThemes = (DefaultableBoolean) 2;
    this.label7.AutoSize = true;
    this.label7.BackColor = Color.Transparent;
    this.label7.Location = new Point(7, 201);
    this.label7.Name = "label7";
    this.label7.Size = new Size(71, 13);
    this.label7.TabIndex = 14;
    this.label7.Text = "SWIFT Code:";
    this.label8.AutoSize = true;
    this.label8.BackColor = Color.Transparent;
    this.label8.Location = new Point(7, 173);
    this.label8.Name = "label8";
    this.label8.Size = new Size(35, 13);
    this.label8.TabIndex = 12;
    this.label8.Text = "IBAN:";
    this.addressBank.Address1 = "";
    this.addressBank.Address2 = "";
    this.addressBank.City = "";
    this.addressBank.County = "";
    ((Control) this.addressBank).Font = new Font("Tahoma", 8f);
    this.addressBank.ISOCountryCode = "";
    this.addressBank.ISOCountryCodeMember = "";
    this.addressBank.ISOCountryList = (object) null;
    this.addressBank.ISOCountryNameMember = "";
    ((Control) this.addressBank).Location = new Point(0, 220);
    this.addressBank.MGAStyle = MGAStyles.Blue;
    ((Control) this.addressBank).Name = "addressBank";
    this.addressBank.Password = (string) null;
    ((Control) this.addressBank).Size = new Size(286, 152);
    this.addressBank.State = "";
    ((Control) this.addressBank).TabIndex = 16 /*0x10*/;
    this.addressBank.TextAlign = ContentAlignment.TopLeft;
    this.addressBank.UserID = (string) null;
    this.addressBank.WebserviceUrl = (string) null;
    this.addressBank.ZipCode = "";
    this.addressBank.ZipCodeExtension = "";
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCHIPNumber).Appearance = (AppearanceBase) appearance10;
    ((Control) this.textCHIPNumber).BackColor = Color.White;
    ((Control) this.textCHIPNumber).Location = new Point(110, 374);
    ((TextEditorControlBase) this.textCHIPNumber).MaxLength = 30;
    this.textCHIPNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textCHIPNumber).Name = "textCHIPNumber";
    ((Control) this.textCHIPNumber).Size = new Size(254, 20);
    ((Control) this.textCHIPNumber).TabIndex = 18;
    ((UltraControlBase) this.textCHIPNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCHIPNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.label9.AutoSize = true;
    this.label9.BackColor = Color.Transparent;
    this.label9.Location = new Point(7, 374);
    this.label9.Name = "label9";
    this.label9.Size = new Size(100, 13);
    this.label9.TabIndex = 17;
    this.label9.Text = "CHIP Participant #:";
    this.comboPaymentFormats.BorderStyle = (UIElementBorderStyle) 4;
    this.comboPaymentFormats.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboPaymentFormats).Location = new Point(110, 401);
    this.comboPaymentFormats.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboPaymentFormats).Name = "comboPaymentFormats";
    ((Control) this.comboPaymentFormats).Size = new Size(167, 21);
    ((Control) this.comboPaymentFormats).TabIndex = 30;
    ((UltraControlBase) this.comboPaymentFormats).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboPaymentFormats).UseOsThemes = (DefaultableBoolean) 2;
    this.label10.AutoSize = true;
    this.label10.BackColor = Color.Transparent;
    this.label10.Location = new Point(7, 401);
    this.label10.Name = "label10";
    this.label10.Size = new Size(90, 13);
    this.label10.TabIndex = 31 /*0x1F*/;
    this.label10.Text = "Payment Format:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.label10);
    this.Controls.Add((Control) this.comboPaymentFormats);
    this.Controls.Add((Control) this.textCHIPNumber);
    this.Controls.Add((Control) this.label9);
    this.Controls.Add((Control) this.textSWIFTCode);
    this.Controls.Add((Control) this.textIBAN);
    this.Controls.Add((Control) this.label7);
    this.Controls.Add((Control) this.label8);
    this.Controls.Add((Control) this.picSearch);
    this.Controls.Add((Control) this.textEntityName);
    this.Controls.Add((Control) this.label6);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.optionAccountType);
    this.Controls.Add((Control) this.textRoutingNumber);
    this.Controls.Add((Control) this.textAccountNumber);
    this.Controls.Add((Control) this.textBankName);
    this.Controls.Add((Control) this.textAccountName);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.addressBank);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (ACHEntry);
    this.Size = new Size(374, 466);
    this.Load += new EventHandler(this.ACHEntry_Load);
    ((ISupportInitialize) this.picSearch).EndInit();
    ((ISupportInitialize) this.textEntityName).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.optionAccountType).EndInit();
    ((ISupportInitialize) this.textRoutingNumber).EndInit();
    ((ISupportInitialize) this.textAccountNumber).EndInit();
    ((ISupportInitialize) this.textBankName).EndInit();
    ((ISupportInitialize) this.textAccountName).EndInit();
    ((ISupportInitialize) this.textSWIFTCode).EndInit();
    ((ISupportInitialize) this.textIBAN).EndInit();
    ((ISupportInitialize) this.textCHIPNumber).EndInit();
    ((ISupportInitialize) this.comboPaymentFormats).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public delegate void ACHSaveCompleteHandler(object sender, ACHSaveCompleteArgs e);
}

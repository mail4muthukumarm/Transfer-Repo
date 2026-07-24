// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.formPayeeInstructions
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

[SecureResource("{E7D0695A-0C0C-42D7-830E-0BD1128BA182}", "Payee Instruction Rights", "Determines whether or not the user can access the payee instruction managment screen.", "Accounting")]
public class formPayeeInstructions : Form
{
  private IContainer components;
  private Guid _entityGuid;

  public formPayeeInstructions()
  {
    this.InitializeComponent();
    this.LoadOfficeLocations();
    this.LoadPaymentMethods();
    this.SetAddressResolverSettings();
  }

  public formPayeeInstructions(Guid entityGuid)
  {
    this.InitializeComponent();
    this._entityGuid = entityGuid;
    ((TextEditorControlBase) this.textEntityName).Text = MGASystems.IMS.Accounting.Utilities.Tools.GetEntityName(this._entityGuid);
    this.SetAddressResolverSettings();
    this.LoadOfficeLocations();
    this.LoadPaymentMethods();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel1")]
  internal virtual UltraLabel UltraLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboPaymentMethod")]
  internal virtual MGASimpleComboBox comboPaymentMethod { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ultraLabel4")]
  internal virtual UltraLabel ultraLabel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ultraLabel8")]
  internal virtual UltraLabel ultraLabel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBankName")]
  internal virtual MGATextBox textBankName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("addressResolver")]
  internal virtual AddressResolver_MULTI addressResolver { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textAccountNumber")]
  internal virtual MGATextBox textAccountNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textContactName")]
  internal virtual MGATextBox textContactName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textPayeeBankMemo")]
  internal virtual MGATextBox textPayeeBankMemo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textIssuingBankMemo")]
  internal virtual MGATextBox textIssuingBankMemo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsPaymentMethods1")]
  internal virtual dsPaymentMethods DsPaymentMethods1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetEntityPaymentMethodsList")]
  internal virtual SqlDataAdapter daGetEntityPaymentMethodsList { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("FormDataConnection")]
  internal virtual SqlConnection FormDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox comboOfficeLocation
  {
    get => this._comboOfficeLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.comboOfficeLocation_RowSelected);
      MGASimpleComboBox comboOfficeLocation1 = this._comboOfficeLocation;
      if (comboOfficeLocation1 != null)
        comboOfficeLocation1.RowSelected -= selectedEventHandler;
      this._comboOfficeLocation = value;
      MGASimpleComboBox comboOfficeLocation2 = this._comboOfficeLocation;
      if (comboOfficeLocation2 == null)
        return;
      comboOfficeLocation2.RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("textContactPhone")]
  internal virtual MGAMaskedEdit textContactPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textContactFax")]
  internal virtual MGAMaskedEdit textContactFax { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("groupBanks")]
  internal virtual UltraGroupBox groupBanks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonSearchEntity
  {
    get => this._buttonSearchEntity;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonSearchEntity_Click);
      MGAButton buttonSearchEntity1 = this._buttonSearchEntity;
      if (buttonSearchEntity1 != null)
        ((Control) buttonSearchEntity1).Click -= eventHandler;
      this._buttonSearchEntity = value;
      MGAButton buttonSearchEntity2 = this._buttonSearchEntity;
      if (buttonSearchEntity2 == null)
        return;
      ((Control) buttonSearchEntity2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("textEntityName")]
  internal virtual MGATextBox textEntityName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelContents")]
  internal virtual Panel panelContents { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBankRoutingNumber")]
  internal virtual MGATextBox textBankRoutingNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonCancel
  {
    get => this._buttonCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonCancel_Click);
      MGAButton buttonCancel1 = this._buttonCancel;
      if (buttonCancel1 != null)
        ((Control) buttonCancel1).Click -= eventHandler;
      this._buttonCancel = value;
      MGAButton buttonCancel2 = this._buttonCancel;
      if (buttonCancel2 == null)
        return;
      ((Control) buttonCancel2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonSave
  {
    get => this._buttonSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonSave_Click);
      MGAButton buttonSave1 = this._buttonSave;
      if (buttonSave1 != null)
        ((Control) buttonSave1).Click -= eventHandler;
      this._buttonSave = value;
      MGAButton buttonSave2 = this._buttonSave;
      if (buttonSave2 == null)
        return;
      ((Control) buttonSave2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formPayeeInstructions));
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
    this.Panel1 = new Panel();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.Panel2 = new Panel();
    this.PictureBox1 = new PictureBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.UltraLabel1 = new UltraLabel();
    this.Label3 = new Label();
    this.comboPaymentMethod = new MGASimpleComboBox();
    this.DsPaymentMethods1 = new dsPaymentMethods();
    this.textBankName = new MGATextBox();
    this.addressResolver = new AddressResolver_MULTI();
    this.Label4 = new Label();
    this.textAccountNumber = new MGATextBox();
    this.Label5 = new Label();
    this.textContactName = new MGATextBox();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.textPayeeBankMemo = new MGATextBox();
    this.Label9 = new Label();
    this.textIssuingBankMemo = new MGATextBox();
    this.Label10 = new Label();
    this.ultraLabel4 = new UltraLabel();
    this.ultraLabel8 = new UltraLabel();
    this.daGetEntityPaymentMethodsList = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.textContactPhone = new MGAMaskedEdit();
    this.textContactFax = new MGAMaskedEdit();
    this.groupBanks = new UltraGroupBox();
    this.panelContents = new Panel();
    this.textEntityName = new MGATextBox();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.buttonSearchEntity = new MGAButton();
    this.textBankRoutingNumber = new MGATextBox();
    this.Label13 = new Label();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.comboPaymentMethod).BeginInit();
    this.DsPaymentMethods1.BeginInit();
    ((ISupportInitialize) this.textBankName).BeginInit();
    ((ISupportInitialize) this.textAccountNumber).BeginInit();
    ((ISupportInitialize) this.textContactName).BeginInit();
    ((ISupportInitialize) this.textPayeeBankMemo).BeginInit();
    ((ISupportInitialize) this.textIssuingBankMemo).BeginInit();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    ((ISupportInitialize) this.textContactPhone).BeginInit();
    ((ISupportInitialize) this.textContactFax).BeginInit();
    ((ISupportInitialize) this.groupBanks).BeginInit();
    ((Control) this.groupBanks).SuspendLayout();
    ((ISupportInitialize) this.textEntityName).BeginInit();
    ((ISupportInitialize) this.buttonSearchEntity).BeginInit();
    ((ISupportInitialize) this.textBankRoutingNumber).BeginInit();
    this.SuspendLayout();
    this.Panel1.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Panel1.Controls.Add((Control) this.buttonCancel);
    this.Panel1.Controls.Add((Control) this.buttonSave);
    this.Panel1.Dock = DockStyle.Bottom;
    this.Panel1.Location = new Point(0, 470);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(808, 40);
    this.Panel1.TabIndex = 29;
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonCancel).Location = new Point(704, 8);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonCancel).TabIndex = 1;
    ((ControlBase) this.buttonCancel).Text = "&Cancel";
    this.buttonCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonSave).Location = new Point(600, 8);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonSave).TabIndex = 0;
    ((ControlBase) this.buttonSave).Text = "&Save";
    this.buttonSave.UseOSThemes = (DefaultableBoolean) 2;
    this.Panel2.Controls.Add((Control) this.PictureBox1);
    this.Panel2.Controls.Add((Control) this.Label1);
    this.Panel2.Controls.Add((Control) this.Label2);
    this.Panel2.Dock = DockStyle.Top;
    this.Panel2.Location = new Point(0, 0);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(808, 88);
    this.Panel2.TabIndex = 0;
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(24, 8);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(75, 75);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox1.TabIndex = 2;
    this.PictureBox1.TabStop = false;
    this.Label1.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label1.Dock = DockStyle.Bottom;
    this.Label1.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label1.Location = new Point(0, 87);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(808, 1);
    this.Label1.TabIndex = 1;
    this.Label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Arial", 12f, FontStyle.Bold);
    this.Label2.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label2.Location = new Point(600, 64 /*0x40*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(198, 19);
    this.Label2.TabIndex = 0;
    this.Label2.Text = "Payee Instructions Utility";
    appearance3.BackColor = Color.White;
    appearance3.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.UltraLabel1).Appearance = (AppearanceBase) appearance3;
    ((Control) this.UltraLabel1).Dock = DockStyle.Left;
    ((Control) this.UltraLabel1).Location = new Point(0, 88);
    ((Control) this.UltraLabel1).Name = "UltraLabel1";
    ((Control) this.UltraLabel1).Size = new Size(192 /*0xC0*/, 382);
    ((Control) this.UltraLabel1).TabIndex = 1;
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(208 /*0xD0*/, 152);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(92, 13);
    this.Label3.TabIndex = 9;
    this.Label3.Text = "Payment Method:";
    this.comboPaymentMethod.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboPaymentMethod).DataMember = "PaymentMethods";
    ((UltraGridBase) this.comboPaymentMethod).DataSource = (object) this.DsPaymentMethods1;
    ((UltraDropDownBase) this.comboPaymentMethod).DisplayMember = "MethodName";
    this.comboPaymentMethod.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboPaymentMethod).DropDownWidth = 325;
    ((Control) this.comboPaymentMethod).Location = new Point(304, 152);
    this.comboPaymentMethod.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboPaymentMethod).Name = "comboPaymentMethod";
    ((Control) this.comboPaymentMethod).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.comboPaymentMethod).TabIndex = 10;
    ((UltraControlBase) this.comboPaymentMethod).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboPaymentMethod).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboPaymentMethod).ValueMember = "PayMethodID";
    this.DsPaymentMethods1.DataSetName = "dsPaymentMethods";
    this.DsPaymentMethods1.Locale = new CultureInfo("en-US");
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankName).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.textBankName).BackColor = Color.White;
    ((Control) this.textBankName).Location = new Point(304, 176 /*0xB0*/);
    ((TextEditorControlBase) this.textBankName).MaxLength = 100;
    this.textBankName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankName).Name = "textBankName";
    ((Control) this.textBankName).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.textBankName).TabIndex = 12;
    ((UltraControlBase) this.textBankName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankName).UseOsThemes = (DefaultableBoolean) 2;
    this.addressResolver.Address1 = "";
    this.addressResolver.Address2 = "";
    this.addressResolver.City = "";
    this.addressResolver.County = "";
    ((Control) this.addressResolver).Font = new Font("Tahoma", 8f);
    this.addressResolver.ISOCountryCode = "";
    this.addressResolver.ISOCountryCodeMember = "";
    this.addressResolver.ISOCountryList = (object) null;
    this.addressResolver.ISOCountryNameMember = "";
    ((Control) this.addressResolver).Location = new Point(200, 312);
    this.addressResolver.MGAStyle = MGAStyles.Blue;
    ((Control) this.addressResolver).Name = "addressResolver";
    this.addressResolver.Password = (string) null;
    ((Control) this.addressResolver).Size = new Size(280, 152);
    this.addressResolver.State = "";
    ((Control) this.addressResolver).TabIndex = 23;
    this.addressResolver.TextAlign = ContentAlignment.TopLeft;
    this.addressResolver.UserID = (string) null;
    this.addressResolver.WebserviceUrl = (string) null;
    this.addressResolver.ZipCode = "";
    this.addressResolver.ZipCodeExtension = "";
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(208 /*0xD0*/, 176 /*0xB0*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(64 /*0x40*/, 13);
    this.Label4.TabIndex = 11;
    this.Label4.Text = "Bank Name:";
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textAccountNumber).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.textAccountNumber).BackColor = Color.White;
    ((Control) this.textAccountNumber).Location = new Point(304, 200);
    ((TextEditorControlBase) this.textAccountNumber).MaxLength = 25;
    this.textAccountNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textAccountNumber).Name = "textAccountNumber";
    ((Control) this.textAccountNumber).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.textAccountNumber).TabIndex = 14;
    ((UltraControlBase) this.textAccountNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textAccountNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(208 /*0xD0*/, 200);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(90, 13);
    this.Label5.TabIndex = 13;
    this.Label5.Text = "Account Number:";
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textContactName).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.textContactName).BackColor = Color.White;
    ((Control) this.textContactName).Location = new Point(304, 248);
    ((TextEditorControlBase) this.textContactName).MaxLength = 25;
    this.textContactName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textContactName).Name = "textContactName";
    ((Control) this.textContactName).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.textContactName).TabIndex = 18;
    ((UltraControlBase) this.textContactName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textContactName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.Location = new Point(208 /*0xD0*/, 248);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(79, 13);
    this.Label6.TabIndex = 17;
    this.Label6.Text = "Contact Name:";
    this.Label7.AutoSize = true;
    this.Label7.Location = new Point(208 /*0xD0*/, 296);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(70, 13);
    this.Label7.TabIndex = 21;
    this.Label7.Text = "Contact Fax:";
    this.Label8.AutoSize = true;
    this.Label8.Location = new Point(208 /*0xD0*/, 272);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(82, 13);
    this.Label8.TabIndex = 19;
    this.Label8.Text = "Contact Phone:";
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPayeeBankMemo).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.textPayeeBankMemo).BackColor = Color.White;
    ((Control) this.textPayeeBankMemo).Location = new Point(568, 112 /*0x70*/);
    ((TextEditorControlBase) this.textPayeeBankMemo).MaxLength = 300;
    this.textPayeeBankMemo.MGAStyle = MGAStyles.Blue;
    this.textPayeeBankMemo.Multiline = true;
    ((Control) this.textPayeeBankMemo).Name = "textPayeeBankMemo";
    ((Control) this.textPayeeBankMemo).Size = new Size(224 /*0xE0*/, 64 /*0x40*/);
    ((Control) this.textPayeeBankMemo).TabIndex = 25;
    ((UltraControlBase) this.textPayeeBankMemo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textPayeeBankMemo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.AutoSize = true;
    this.Label9.Location = new Point(568, 96 /*0x60*/);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(98, 13);
    this.Label9.TabIndex = 24;
    this.Label9.Text = "Payee Bank Memo:";
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textIssuingBankMemo).Appearance = (AppearanceBase) appearance8;
    ((TextEditorControlBase) this.textIssuingBankMemo).BackColor = Color.White;
    ((Control) this.textIssuingBankMemo).Location = new Point(568, 200);
    ((TextEditorControlBase) this.textIssuingBankMemo).MaxLength = 300;
    this.textIssuingBankMemo.MGAStyle = MGAStyles.Blue;
    this.textIssuingBankMemo.Multiline = true;
    ((Control) this.textIssuingBankMemo).Name = "textIssuingBankMemo";
    ((Control) this.textIssuingBankMemo).Size = new Size(224 /*0xE0*/, 72);
    ((Control) this.textIssuingBankMemo).TabIndex = 27;
    ((UltraControlBase) this.textIssuingBankMemo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textIssuingBankMemo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label10.AutoSize = true;
    this.Label10.Location = new Point(568, 184);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(102, 13);
    this.Label10.TabIndex = 26;
    this.Label10.Text = "Issuing Bank Memo:";
    appearance9.BackColor = Color.White;
    appearance9.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance9.BackGradientAlignment = (GradientAlignment) 3;
    appearance9.BackGradientStyle = (GradientStyle) 2;
    appearance9.ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance9;
    ((AutoSizeControlBase) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Location = new Point(24, 120);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(159, 15);
    ((Control) this.ultraLabel4).TabIndex = 3;
    ((ControlBase) this.ultraLabel4).Text = "Specify Payee Bank Instructions";
    appearance10.BackColor = Color.White;
    appearance10.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance10.BackGradientAlignment = (GradientAlignment) 2;
    appearance10.BackGradientStyle = (GradientStyle) 2;
    appearance10.ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel8).Appearance = (AppearanceBase) appearance10;
    ((AutoSizeControlBase) this.ultraLabel8).AutoSize = true;
    ((Control) this.ultraLabel8).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel8).Location = new Point(8, 96 /*0x60*/);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(130, 15);
    ((Control) this.ultraLabel8).TabIndex = 2;
    ((ControlBase) this.ultraLabel8).Text = "PAYEE INSTRUCTIONS";
    this.daGetEntityPaymentMethodsList.SelectCommand = this.SqlSelectCommand1;
    this.daGetEntityPaymentMethodsList.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetEntityPaymentMethodsList", new DataColumnMapping[2]
      {
        new DataColumnMapping("paymethodid", "paymethodid"),
        new DataColumnMapping("methodname", "methodname")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_GetEntityPaymentMethodsList]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.FormDataConnection.ConnectionString = "workstation id=WREYES2;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(304, 104);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.comboOfficeLocation).TabIndex = 5;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.textContactPhone.Appearance = (AppearanceBase) appearance11;
    this.textContactPhone.DataMode = (MaskMode) 0;
    this.textContactPhone.EditAs = (EditAsType) 1;
    this.textContactPhone.InputMask = "(###) ###-####";
    ((Control) this.textContactPhone).Location = new Point(304, 272);
    this.textContactPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.textContactPhone).Name = "textContactPhone";
    ((Control) this.textContactPhone).Size = new Size(100, 20);
    ((Control) this.textContactPhone).TabIndex = 20;
    ((UltraControlBase) this.textContactPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textContactPhone).UseOsThemes = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.textContactFax.Appearance = (AppearanceBase) appearance12;
    this.textContactFax.EditAs = (EditAsType) 1;
    this.textContactFax.InputMask = "(###) ###-####";
    ((Control) this.textContactFax).Location = new Point(304, 296);
    this.textContactFax.MGAStyle = MGAStyles.Blue;
    ((Control) this.textContactFax).Name = "textContactFax";
    ((Control) this.textContactFax).Size = new Size(100, 20);
    ((Control) this.textContactFax).TabIndex = 22;
    this.textContactFax.Text = "() -";
    ((UltraControlBase) this.textContactFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textContactFax).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupBanks.Appearance = (AppearanceBase) appearance13;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupBanks.ContentAreaAppearance = (AppearanceBase) appearance14;
    ((Control) this.groupBanks).Controls.Add((Control) this.panelContents);
    appearance15.ForeColor = Color.Black;
    this.groupBanks.HeaderAppearance = (AppearanceBase) appearance15;
    ((Control) this.groupBanks).Location = new Point(488, 288);
    ((Control) this.groupBanks).Name = "groupBanks";
    ((Control) this.groupBanks).Size = new Size(312, 176 /*0xB0*/);
    ((Control) this.groupBanks).TabIndex = 28;
    this.groupBanks.Text = "Apply Settings To Bank(s)";
    this.panelContents.Location = new Point(8, 24);
    this.panelContents.Name = "panelContents";
    this.panelContents.Size = new Size(296, 144 /*0x90*/);
    this.panelContents.TabIndex = 0;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEntityName).Appearance = (AppearanceBase) appearance16;
    ((TextEditorControlBase) this.textEntityName).BackColor = Color.White;
    ((Control) this.textEntityName).Location = new Point(304, 128 /*0x80*/);
    this.textEntityName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textEntityName).Name = "textEntityName";
    ((EditorButtonControlBase) this.textEntityName).ReadOnly = true;
    ((Control) this.textEntityName).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.textEntityName).TabIndex = 7;
    ((UltraControlBase) this.textEntityName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEntityName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.White;
    this.Label11.Font = new Font("Tahoma", 8f);
    this.Label11.ForeColor = Color.Black;
    this.Label11.Location = new Point(208 /*0xD0*/, 104);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(83, 13);
    this.Label11.TabIndex = 4;
    this.Label11.Text = "Office Location:";
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.White;
    this.Label12.Font = new Font("Tahoma", 8f);
    this.Label12.ForeColor = Color.Black;
    this.Label12.Location = new Point(208 /*0xD0*/, 128 /*0x80*/);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(71, 13);
    this.Label12.TabIndex = 6;
    this.Label12.Text = "Payee Name:";
    appearance17.BackColor = Color.FromArgb(248, 248, 248);
    appearance17.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance17.BackGradientStyle = (GradientStyle) 2;
    appearance17.BorderColor = Color.DarkGray;
    appearance17.Cursor = Cursors.Hand;
    appearance17.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance17.Image"));
    appearance17.ImageHAlign = (HAlign) 2;
    appearance17.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearchEntity).Appearance = (AppearanceBase) appearance17;
    this.buttonSearchEntity.ButtonStyle = (UIElementButtonStyle) 3;
    ((Control) this.buttonSearchEntity).Location = new Point(529, 128 /*0x80*/);
    ((Control) this.buttonSearchEntity).Name = "buttonSearchEntity";
    ((Control) this.buttonSearchEntity).Size = new Size(20, 20);
    ((Control) this.buttonSearchEntity).TabIndex = 8;
    this.buttonSearchEntity.UseOSThemes = (DefaultableBoolean) 2;
    appearance18.BackColor = Color.White;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance18.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textBankRoutingNumber).Appearance = (AppearanceBase) appearance18;
    ((TextEditorControlBase) this.textBankRoutingNumber).BackColor = Color.White;
    ((Control) this.textBankRoutingNumber).Location = new Point(304, 224 /*0xE0*/);
    ((TextEditorControlBase) this.textBankRoutingNumber).MaxLength = 9;
    this.textBankRoutingNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textBankRoutingNumber).Name = "textBankRoutingNumber";
    ((Control) this.textBankRoutingNumber).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.textBankRoutingNumber).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.textBankRoutingNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textBankRoutingNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.AutoSize = true;
    this.Label13.Location = new Point(208 /*0xD0*/, 224 /*0xE0*/);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(88, 13);
    this.Label13.TabIndex = 15;
    this.Label13.Text = "Routing Number:";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(808, 510);
    this.ControlBox = false;
    this.Controls.Add((Control) this.Label13);
    this.Controls.Add((Control) this.textBankRoutingNumber);
    this.Controls.Add((Control) this.buttonSearchEntity);
    this.Controls.Add((Control) this.Label12);
    this.Controls.Add((Control) this.textEntityName);
    this.Controls.Add((Control) this.groupBanks);
    this.Controls.Add((Control) this.textContactFax);
    this.Controls.Add((Control) this.textContactPhone);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.comboOfficeLocation);
    this.Controls.Add((Control) this.ultraLabel4);
    this.Controls.Add((Control) this.ultraLabel8);
    this.Controls.Add((Control) this.textIssuingBankMemo);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.textPayeeBankMemo);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.textContactName);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.textAccountNumber);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.textBankName);
    this.Controls.Add((Control) this.comboPaymentMethod);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.UltraLabel1);
    this.Controls.Add((Control) this.Panel2);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.addressResolver);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formPayeeInstructions);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Payee Instruction Utility";
    this.Panel1.ResumeLayout(false);
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.comboPaymentMethod).EndInit();
    this.DsPaymentMethods1.EndInit();
    ((ISupportInitialize) this.textBankName).EndInit();
    ((ISupportInitialize) this.textAccountNumber).EndInit();
    ((ISupportInitialize) this.textContactName).EndInit();
    ((ISupportInitialize) this.textPayeeBankMemo).EndInit();
    ((ISupportInitialize) this.textIssuingBankMemo).EndInit();
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    ((ISupportInitialize) this.textContactPhone).EndInit();
    ((ISupportInitialize) this.textContactFax).EndInit();
    ((ISupportInitialize) this.groupBanks).EndInit();
    ((Control) this.groupBanks).ResumeLayout(false);
    ((ISupportInitialize) this.textEntityName).EndInit();
    ((ISupportInitialize) this.buttonSearchEntity).EndInit();
    ((ISupportInitialize) this.textBankRoutingNumber).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public Guid EntityGuid => this._entityGuid;

  public string EntityName => ((TextEditorControlBase) this.textEntityName).Text;

  private void SetAddressResolverSettings()
  {
    this.addressResolver.UserID = AddressResolverSettings.AddressResolveUserName;
    this.addressResolver.Password = AddressResolverSettings.AddressResolverPassword;
    this.addressResolver.WebserviceUrl = AddressResolverSettings.AddressResolverURL;
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    if (((UltraGridBase) this.comboOfficeLocation).Rows.Count <= 0)
      return;
    this.comboOfficeLocation.Value = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.comboOfficeLocation).Rows[0].Cells["ID"].Value);
  }

  private void buttonSearchEntity_Click(object sender, EventArgs e)
  {
    FormSearchEntity formSearchEntity = new FormSearchEntity(MGASystems.IMS.Accounting.Core.ClassObjects.Utility.SearchEntityTypes.All);
    try
    {
      if (formSearchEntity.ShowDialog() != DialogResult.OK)
        return;
      ((TextEditorControlBase) this.textEntityName).Text = formSearchEntity.EntityName;
      this._entityGuid = formSearchEntity.EntityGuid;
    }
    finally
    {
      formSearchEntity.Dispose();
    }
  }

  private void LoadPaymentMethods()
  {
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.daGetEntityPaymentMethodsList.Fill((DataTable) this.DsPaymentMethods1.PaymentMethods);
  }

  private void LoadBankAccounts(int glCompanyId)
  {
    this.panelContents.Controls.Clear();
    DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("spFin_GetBankAccounts", (object) "@glCompanyId", (object) glCompanyId);
    if (dataTable == null)
      return;
    if (dataTable.Rows.Count == 0)
      return;
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        if (!row["Bankname"].Equals((object) DBNull.Value) && !row["bankName"].ToString().Equals(string.Empty))
        {
          CheckBox checkBox = new CheckBox();
          checkBox.Tag = RuntimeHelpers.GetObjectValue(row["glacctid"]);
          checkBox.Text = row["bankname"].ToString();
          checkBox.FlatStyle = FlatStyle.Flat;
          this.panelContents.Controls.Add((Control) checkBox);
          checkBox.Dock = DockStyle.Top;
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

  private void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null || this.comboOfficeLocation.Text.Equals(string.Empty) || int.Parse(((UltraDropDownBase) this.comboOfficeLocation).SelectedRow.Cells["ID"].Value.ToString()) == -1)
      return;
    this.LoadBankAccounts(int.Parse(((UltraDropDownBase) this.comboOfficeLocation).SelectedRow.Cells["ID"].Value.ToString()));
  }

  private void Save(int bankGLAccountId)
  {
    SqlCommand sqlCommand1 = new SqlCommand("dbo.spFin_InsertPayeeInstruction", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Connection.Open();
      sqlCommand2.Transaction = sqlCommand2.Connection.BeginTransaction();
      sqlCommand2.Parameters.AddWithValue("@payeeGuid", (object) this._entityGuid);
      sqlCommand2.Parameters.AddWithValue("@payMethodId", (object) this.comboPaymentMethod.Value.ToString());
      sqlCommand2.Parameters.AddWithValue("@fromBankGLAcctId", (object) bankGLAccountId);
      sqlCommand2.Parameters.AddWithValue("@toBankName", (object) ((TextEditorControlBase) this.textBankName).Text);
      sqlCommand2.Parameters.AddWithValue("@toBankAddr1", (object) this.addressResolver.Address1);
      sqlCommand2.Parameters.AddWithValue("@toBankAddr2", (object) this.addressResolver.Address2);
      sqlCommand2.Parameters.AddWithValue("@toBankCity", (object) this.addressResolver.City);
      sqlCommand2.Parameters.AddWithValue("@toBankState", (object) this.addressResolver.State);
      sqlCommand2.Parameters.AddWithValue("@toBankZip", (object) this.addressResolver.ZipCode);
      sqlCommand2.Parameters.AddWithValue("@toBankCountry", (object) this.addressResolver.ISOCountryCode);
      sqlCommand2.Parameters.AddWithValue("@toBankAbaRouteNum", (object) ((TextEditorControlBase) this.textBankRoutingNumber).Text);
      sqlCommand2.Parameters.AddWithValue("@toBankIntlAbaRouteNum", (object) DBNull.Value);
      sqlCommand2.Parameters.AddWithValue("@toBankMemo", (object) ((TextEditorControlBase) this.textIssuingBankMemo).Text);
      sqlCommand2.Parameters.AddWithValue("@payeeBankAcctNum", (object) ((TextEditorControlBase) this.textAccountNumber).Text);
      sqlCommand2.Parameters.AddWithValue("@payeeContact", (object) ((TextEditorControlBase) this.textContactName).Text);
      sqlCommand2.Parameters.AddWithValue("@payeeContactPhone", (object) this.textContactPhone.Text);
      sqlCommand2.Parameters.AddWithValue("@payeeContactFax", (object) this.textContactFax.Text);
      sqlCommand2.Parameters.AddWithValue("@payeeContactEmail", (object) string.Empty);
      sqlCommand2.Parameters.AddWithValue("@payeeMemo", (object) ((TextEditorControlBase) this.textPayeeBankMemo).Text);
      sqlCommand2.Parameters.AddWithValue("@userGuid", (object) CurrentUser.Instance.UserGUID);
      sqlCommand2.ExecuteNonQuery();
      sqlCommand2.Transaction.Commit();
      if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.comboPaymentMethod.Value.ToString(), "A", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.comboPaymentMethod.Value.ToString(), "D", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.comboPaymentMethod.Value.ToString(), "H", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.comboPaymentMethod.Value.ToString(), "M", false) == 0))
        return;
      this.SaveACHInformation();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      SqlException sqlException = ex;
      sqlCommand1.Transaction.Rollback();
      throw sqlException;
    }
    finally
    {
      if (sqlCommand1 != null && sqlCommand1.Connection != null)
      {
        if (sqlCommand1.Connection.State != ConnectionState.Closed)
        {
          sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
          sqlCommand1.Connection = (SqlConnection) null;
        }
        sqlCommand1.Dispose();
      }
    }
  }

  private void SaveACHInformation()
  {
    formPayeeInstructions payeeInstructions = this;
    Encryption encryption = new Encryption();
    string str = "dbo.spFin_SaveACHInformation";
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, eth) =>
    {
      try
      {
        DefaultDatabase.ExecuteNonQuery(str, new object[36]
        {
          (object) "@entityGuid",
          (object) payeeInstructions._entityGuid,
          (object) "@accountName",
          (object) payeeInstructions.EntityName,
          (object) "@PaymentFormatId",
          (object) 1,
          (object) "@bankName",
          (object) ((TextEditorControlBase) payeeInstructions.textBankName).Text,
          (object) "@BankAddress1",
          (object) payeeInstructions.addressResolver.Address1,
          (object) "@BankAddress2",
          (object) payeeInstructions.addressResolver.Address2,
          (object) "@BankCity",
          (object) payeeInstructions.addressResolver.City,
          (object) "@BankState",
          (object) payeeInstructions.addressResolver.State,
          (object) "@BankZipCode",
          (object) payeeInstructions.addressResolver.ZipCode,
          (object) "@BankISOCountryCode",
          (object) payeeInstructions.addressResolver.ISOCountryCode,
          (object) "@routingNumber",
          (object) encryption.EncryptTripleDes(((TextEditorControlBase) payeeInstructions.textBankRoutingNumber).Text),
          (object) "@accountNumber",
          (object) encryption.EncryptTripleDes(((TextEditorControlBase) payeeInstructions.textAccountNumber).Text),
          (object) "@enteredBy",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@dateEntered",
          (object) DateAndTime.Now,
          (object) "@IBAN",
          (object) encryption.EncryptTripleDes(string.Empty),
          (object) "@SWIFTCode",
          (object) encryption.EncryptTripleDes(string.Empty),
          (object) "@CHIPNumber",
          (object) encryption.EncryptTripleDes(string.Empty),
          (object) "@accountType",
          (object) "C"
        });
        eth.Transaction.Commit();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        eth.Transaction.Rollback();
        throw;
      }
    }));
  }

  private bool ValidateForm()
  {
    bool flag;
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select an office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboPaymentMethod).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a payment method to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((TextEditorControlBase) this.textEntityName).Text.Equals(string.Empty) || this._entityGuid.Equals(Guid.Empty))
    {
      int num = (int) MessageBox.Show("You must select a payee to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((TextEditorControlBase) this.textBankName).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must specify a bank name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((TextEditorControlBase) this.textBankRoutingNumber).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must specify a routing number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (this.addressResolver.Address1.Equals(string.Empty) && this.addressResolver.Address2.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must specify either an address 1 or address 2 to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (this.addressResolver.City.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must specify a city to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (this.addressResolver.ZipCode.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must specify a zipcode to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    try
    {
      foreach (Control control in this.panelContents.Controls)
      {
        if (control is CheckBox)
          this.Save(int.Parse(control.Tag.ToString()));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.Close();
}

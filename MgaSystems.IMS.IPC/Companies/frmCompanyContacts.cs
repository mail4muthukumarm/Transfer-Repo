// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmCompanyContacts
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

[SecureResource("{44E2196F-B453-45b2-AB6B-AC6A4802E210}", "Update Special Company Contacts", "Controls the ability to update special company compacts.", "Companies")]
[SecureResource("{9BC3B275-3F72-4f46-98E4-70964474C587}", "Edit Company Contacts", "Controls the ability to edit company compacts.", "Companies")]
[SecureResource("{9E984B61-1845-45b0-8392-A168A918F0DC}", "Delete Company Contacts", "Controls the ability to delete company compacts.", "Companies")]
[SecureResource("{3C3844F1-CA95-4f3e-9794-9ABC240CA762}", "Add New Company Contacts", "Controls the ability to add new company compacts.", "Companies")]
public class frmCompanyContacts : Form
{
  private IContainer components;
  protected Label lblAddress1;
  protected Label lblAddress2;
  protected Label lblPhone;
  protected Label Label3;
  protected Label Label8;
  protected Label Label13;
  protected MGAListBox lstContacts;
  protected Label Label7;
  protected MGASimpleComboBox cboDeliveryMethod;
  protected MGAGroupBox grpContacts;
  protected ToolTip ToolTip;
  protected MGAListBox lstLocations;
  protected SqlDataAdapter daContacts;
  protected MGATextBox txtEmail;
  protected MGATextBox txtTitle;
  protected MGATextBox txtLName;
  protected MGATextBox txtFName;
  protected MGATextBox txtExt;
  private Label Label4;
  private MGAGroupBox grpContactInfo;
  private Label Label2;
  private SqlDataAdapter daSpecialContacts;
  private dsCompanyContacts dsContacts;
  private MGASimpleComboBox cboStatus;
  private MGAMaskedEdit txtPhone;
  private MGAMaskedEdit txtCell;
  private MGAMaskedEdit txtFax;
  private SqlCommand SqlSelectCommand2;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private DataView dvProducerContacts;
  private SqlCommand SqlSelectCommand6;
  private SqlCommand SqlInsertCommand2;
  private SqlCommand SqlUpdateCommand2;
  private SqlCommand SqlDeleteCommand2;
  private Guid _companyGuid;
  private Guid _companyLocationGuid;
  private Guid _companyContactGuid;
  private readonly bool _newContactOnLoad;
  private bool _painted;
  private bool _canUpdateSpecialContacts;
  private bool _permissionToAddCompanyContact;
  private bool _permissionToEditCompanyContact;
  private bool _permissionToDeleteCompanyContact;
  private DbConnection _cn;
  internal const string CanUpdateSpecialCompanyContacts = "{44E2196F-B453-45b2-AB6B-AC6A4802E210}";
  internal const string CanAddNewCompanyContact = "{3C3844F1-CA95-4f3e-9794-9ABC240CA762}";
  internal const string CanEditCompanyContacts = "{9BC3B275-3F72-4f46-98E4-70964474C587}";
  internal const string CanDeleteCompanyContacts = "{9E984B61-1845-45b0-8392-A168A918F0DC}";

  [field: AccessedThroughProperty("lblCompany")]
  protected virtual UltraLabel lblCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  protected virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckedListBox lstSpecialContacts
  {
    get => this._lstSpecialContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
      MGACheckedListBox lstSpecialContacts1 = this._lstSpecialContacts;
      if (lstSpecialContacts1 != null)
        lstSpecialContacts1.ItemCheck -= checkEventHandler;
      this._lstSpecialContacts = value;
      MGACheckedListBox lstSpecialContacts2 = this._lstSpecialContacts;
      if (lstSpecialContacts2 == null)
        return;
      lstSpecialContacts2.ItemCheck += checkEventHandler;
    }
  }

  private virtual MGAButton btnSpecialContact
  {
    get => this._btnSpecialContact;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSpecialContact_Click);
      MGAButton btnSpecialContact1 = this._btnSpecialContact;
      if (btnSpecialContact1 != null)
        ((Control) btnSpecialContact1).Click -= eventHandler;
      this._btnSpecialContact = value;
      MGAButton btnSpecialContact2 = this._btnSpecialContact;
      if (btnSpecialContact2 == null)
        return;
      ((Control) btnSpecialContact2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label5")]
  protected virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpLocations")]
  protected virtual MGAGroupBox grpLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkAuthorize
  {
    get => this._lnkAuthorize;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAuthorize_LinkClicked);
      LinkLabel lnkAuthorize1 = this._lnkAuthorize;
      if (lnkAuthorize1 != null)
        lnkAuthorize1.LinkClicked -= clickedEventHandler;
      this._lnkAuthorize = value;
      LinkLabel lnkAuthorize2 = this._lnkAuthorize;
      if (lnkAuthorize2 == null)
        return;
      lnkAuthorize2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingEdit);
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.dbSave_ClickingCancel);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingEdit -= cancelEventHandler1;
        dbSave1.UIStateChanged -= eventHandler;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickingNew -= cancelEventHandler3;
        dbSave1.ClickingDelete -= cancelEventHandler4;
        dbSave1.ClickingCancel -= cancelEventHandler5;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingEdit += cancelEventHandler1;
      dbSave2.UIStateChanged += eventHandler;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickingNew += cancelEventHandler3;
      dbSave2.ClickingDelete += cancelEventHandler4;
      dbSave2.ClickingCancel += cancelEventHandler5;
    }
  }

  [field: AccessedThroughProperty("err")]
  private virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox chkFilterActive
  {
    get => this._chkFilterActive;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkFilterActive_CheckedChanged);
      MGACheckBox chkFilterActive1 = this._chkFilterActive;
      if (chkFilterActive1 != null)
        ((UltraToggleEditorBase) chkFilterActive1).CheckedChanged -= eventHandler;
      this._chkFilterActive = value;
      MGACheckBox chkFilterActive2 = this._chkFilterActive;
      if (chkFilterActive2 == null)
        return;
      ((UltraToggleEditorBase) chkFilterActive2).CheckedChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkFilterInActive
  {
    get => this._chkFilterInActive;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkFilterInActive_CheckedChanged);
      MGACheckBox chkFilterInActive1 = this._chkFilterInActive;
      if (chkFilterInActive1 != null)
        ((UltraToggleEditorBase) chkFilterInActive1).CheckedChanged -= eventHandler;
      this._chkFilterInActive = value;
      MGACheckBox chkFilterInActive2 = this._chkFilterInActive;
      if (chkFilterInActive2 == null)
        return;
      ((UltraToggleEditorBase) chkFilterInActive2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("MgaSimpleComboBox1")]
  protected virtual MGASimpleComboBox MgaSimpleComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCompanyContacts));
    Appearance appearance21 = new Appearance();
    this.grpContactInfo = new MGAGroupBox();
    this.MgaSimpleComboBox1 = new MGASimpleComboBox();
    this.dsContacts = new dsCompanyContacts();
    this.txtFax = new MGAMaskedEdit();
    this.Label5 = new Label();
    this.txtCell = new MGAMaskedEdit();
    this.txtPhone = new MGAMaskedEdit();
    this.Label1 = new Label();
    this.cboStatus = new MGASimpleComboBox();
    this.lstSpecialContacts = new MGACheckedListBox();
    this.btnSpecialContact = new MGAButton();
    this.Label2 = new Label();
    this.txtExt = new MGATextBox();
    this.Label7 = new Label();
    this.cboDeliveryMethod = new MGASimpleComboBox();
    this.Label4 = new Label();
    this.txtEmail = new MGATextBox();
    this.Label13 = new Label();
    this.txtTitle = new MGATextBox();
    this.Label8 = new Label();
    this.Label3 = new Label();
    this.txtLName = new MGATextBox();
    this.lblAddress1 = new Label();
    this.lblAddress2 = new Label();
    this.txtFName = new MGATextBox();
    this.lblPhone = new Label();
    this.lstContacts = new MGAListBox();
    this.dvProducerContacts = new DataView();
    this.grpContacts = new MGAGroupBox();
    this.chkFilterActive = new MGACheckBox();
    this.chkFilterInActive = new MGACheckBox();
    this.ToolTip = new ToolTip(this.components);
    this.grpLocations = new MGAGroupBox();
    this.lstLocations = new MGAListBox();
    this.daContacts = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.daSpecialContacts = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand6 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    this.lblCompany = new UltraLabel();
    this.err = new ErrorProvider(this.components);
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.lnkAuthorize = new LinkLabel();
    ((ISupportInitialize) this.grpContactInfo).BeginInit();
    ((Control) this.grpContactInfo).SuspendLayout();
    ((ISupportInitialize) this.MgaSimpleComboBox1).BeginInit();
    this.dsContacts.BeginInit();
    ((ISupportInitialize) this.txtFax).BeginInit();
    ((ISupportInitialize) this.txtCell).BeginInit();
    ((ISupportInitialize) this.txtPhone).BeginInit();
    ((ISupportInitialize) this.cboStatus).BeginInit();
    ((ISupportInitialize) this.lstSpecialContacts).BeginInit();
    ((ISupportInitialize) this.btnSpecialContact).BeginInit();
    ((ISupportInitialize) this.txtExt).BeginInit();
    ((ISupportInitialize) this.cboDeliveryMethod).BeginInit();
    ((ISupportInitialize) this.txtEmail).BeginInit();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    ((ISupportInitialize) this.txtLName).BeginInit();
    ((ISupportInitialize) this.txtFName).BeginInit();
    ((ISupportInitialize) this.lstContacts).BeginInit();
    this.dvProducerContacts.BeginInit();
    ((ISupportInitialize) this.grpContacts).BeginInit();
    ((Control) this.grpContacts).SuspendLayout();
    ((ISupportInitialize) this.chkFilterActive).BeginInit();
    ((ISupportInitialize) this.chkFilterInActive).BeginInit();
    ((ISupportInitialize) this.grpLocations).BeginInit();
    ((Control) this.grpLocations).SuspendLayout();
    ((ISupportInitialize) this.lstLocations).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpContactInfo.Appearance = (AppearanceBase) appearance1;
    this.grpContactInfo.BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance2.BackColor = Color.FromArgb(239, 247, 253);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpContactInfo.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.grpContactInfo).Controls.Add((Control) this.MgaSimpleComboBox1);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtFax);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label5);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtCell);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtPhone);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label1);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.cboStatus);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.lstSpecialContacts);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.btnSpecialContact);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label2);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtExt);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label7);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.cboDeliveryMethod);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label4);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtEmail);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label13);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtTitle);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label8);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label3);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtLName);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.lblAddress1);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.lblAddress2);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtFName);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.lblPhone);
    ((Control) this.grpContactInfo).Enabled = false;
    appearance3.ForeColor = Color.FromArgb(21, 66, 139);
    this.grpContactInfo.HeaderAppearance = (AppearanceBase) appearance3;
    ((Control) this.grpContactInfo).Location = new Point(343, 45);
    ((Control) this.grpContactInfo).Name = "grpContactInfo";
    ((Control) this.grpContactInfo).Size = new Size(360, 267);
    ((Control) this.grpContactInfo).TabIndex = 2;
    this.grpContactInfo.Text = "Contact Information";
    this.grpContactInfo.ViewStyle = (GroupBoxViewStyle) 2;
    this.MgaSimpleComboBox1.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MgaSimpleComboBox1).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblCompanyContacts.Salutation", true));
    ((UltraGridBase) this.MgaSimpleComboBox1).DataSource = (object) this.dsContacts.lstSalutations;
    ((UltraDropDownBase) this.MgaSimpleComboBox1).DisplayMember = "Salutation";
    this.MgaSimpleComboBox1.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.MgaSimpleComboBox1).Location = new Point(64 /*0x40*/, 28);
    this.MgaSimpleComboBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaSimpleComboBox1).Name = "MgaSimpleComboBox1";
    ((Control) this.MgaSimpleComboBox1).Size = new Size(56, 21);
    ((Control) this.MgaSimpleComboBox1).TabIndex = 154;
    ((UltraControlBase) this.MgaSimpleComboBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaSimpleComboBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaSimpleComboBox1).ValueMember = "Salutation";
    this.dsContacts.DataSetName = "dsCompanyContacts";
    this.dsContacts.Locale = new CultureInfo("en-US");
    this.dsContacts.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtFax.Appearance = (AppearanceBase) appearance4;
    ((Control) this.txtFax).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblCompanyContacts.Fax", true));
    this.txtFax.EditAs = (EditAsType) 1;
    this.txtFax.InputMask = "###-###-####";
    ((Control) this.txtFax).Location = new Point(64 /*0x40*/, 168);
    this.txtFax.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFax).Name = "txtFax";
    this.txtFax.NonAutoSizeHeight = 20;
    ((Control) this.txtFax).Size = new Size(80 /*0x50*/, 21);
    ((Control) this.txtFax).TabIndex = 7;
    this.txtFax.Text = "--";
    ((UltraControlBase) this.txtFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFax).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(28, 168);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(32 /*0x20*/, 23);
    this.Label5.TabIndex = 153;
    this.Label5.Text = "Fax";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtCell.Appearance = (AppearanceBase) appearance5;
    ((Control) this.txtCell).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblCompanyContacts.Cell", true));
    this.txtCell.EditAs = (EditAsType) 1;
    this.txtCell.InputMask = "###-###-####";
    ((Control) this.txtCell).Location = new Point(64 /*0x40*/, 148);
    this.txtCell.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCell).Name = "txtCell";
    this.txtCell.NonAutoSizeHeight = 20;
    ((Control) this.txtCell).Size = new Size(80 /*0x50*/, 21);
    ((Control) this.txtCell).TabIndex = 6;
    this.txtCell.Text = "--";
    ((UltraControlBase) this.txtCell).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCell).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtPhone.Appearance = (AppearanceBase) appearance6;
    ((Control) this.txtPhone).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblCompanyContacts.Phone", true));
    this.txtPhone.EditAs = (EditAsType) 1;
    this.txtPhone.InputMask = "###-###-####";
    ((Control) this.txtPhone).Location = new Point(64 /*0x40*/, 124);
    this.txtPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPhone).Name = "txtPhone";
    this.txtPhone.NonAutoSizeHeight = 20;
    ((Control) this.txtPhone).Size = new Size(80 /*0x50*/, 21);
    ((Control) this.txtPhone).TabIndex = 4;
    this.txtPhone.Text = "--";
    ((UltraControlBase) this.txtPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPhone).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(12, 240 /*0xF0*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(48 /*0x30*/, 23);
    this.Label1.TabIndex = 151;
    this.Label1.Text = "Status";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.cboStatus.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboStatus).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblCompanyContacts.StatusID", true));
    ((UltraGridBase) this.cboStatus).DataSource = (object) this.dsContacts.lstStatus;
    ((UltraDropDownBase) this.cboStatus).DisplayMember = "Status";
    this.cboStatus.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboStatus).Location = new Point(64 /*0x40*/, 240 /*0xF0*/);
    this.cboStatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboStatus).Name = "cboStatus";
    ((Control) this.cboStatus).Size = new Size(128 /*0x80*/, 21);
    ((Control) this.cboStatus).TabIndex = 10;
    ((UltraControlBase) this.cboStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboStatus).ValueMember = "StatusID";
    this.lstSpecialContacts.CheckOnClick = true;
    this.lstSpecialContacts.DataSource = (object) this.dsContacts.lstCompanySpecialContactTypes;
    this.lstSpecialContacts.DisplayMember = "SpecialContactType";
    this.lstSpecialContacts.Location = new Point(200, 50);
    this.lstSpecialContacts.MGAStyle = MGAStyles.Blue;
    this.lstSpecialContacts.Name = "lstSpecialContacts";
    this.lstSpecialContacts.Size = new Size(144 /*0x90*/, 196);
    this.lstSpecialContacts.TabIndex = 11;
    this.lstSpecialContacts.ValueMember = "SpecialContactTypeID";
    appearance7.BackColor = Color.Gainsboro;
    appearance7.BackColor2 = Color.White;
    appearance7.BackGradientStyle = (GradientStyle) 2;
    appearance7.BorderColor = Color.Gray;
    ((ControlBase) this.btnSpecialContact).Appearance = (AppearanceBase) appearance7;
    ((Control) this.btnSpecialContact).Location = new Point(294, 30);
    ((Control) this.btnSpecialContact).Name = "btnSpecialContact";
    ((Control) this.btnSpecialContact).Size = new Size(24, 16 /*0x10*/);
    ((Control) this.btnSpecialContact).TabIndex = 149;
    ((ControlBase) this.btnSpecialContact).Text = "...";
    this.btnSpecialContact.UseOSThemes = (DefaultableBoolean) 2;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(196, 30);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.Label2.TabIndex = 148;
    this.Label2.Text = "Special Contacts";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtExt).Appearance = (AppearanceBase) appearance8;
    ((TextEditorControlBase) this.txtExt).BackColor = Color.White;
    ((Control) this.txtExt).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblCompanyContacts.Extension", true));
    ((Control) this.txtExt).Location = new Point(152, 124);
    this.txtExt.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtExt).Name = "txtExt";
    ((Control) this.txtExt).Size = new Size(40, 20);
    ((Control) this.txtExt).TabIndex = 5;
    ((UltraControlBase) this.txtExt).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtExt).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(12, 216);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(48 /*0x30*/, 23);
    this.Label7.TabIndex = 136;
    this.Label7.Text = "Delivery";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.cboDeliveryMethod.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboDeliveryMethod).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblCompanyContacts.DeliveryMethodID", true));
    ((UltraGridBase) this.cboDeliveryMethod).DataSource = (object) this.dsContacts.lstDeliveryMethod;
    ((UltraDropDownBase) this.cboDeliveryMethod).DisplayMember = "Description";
    this.cboDeliveryMethod.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDeliveryMethod).Location = new Point(64 /*0x40*/, 216);
    this.cboDeliveryMethod.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDeliveryMethod).Name = "cboDeliveryMethod";
    ((Control) this.cboDeliveryMethod).Size = new Size(128 /*0x80*/, 21);
    ((Control) this.cboDeliveryMethod).TabIndex = 9;
    ((UltraControlBase) this.cboDeliveryMethod).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDeliveryMethod).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDeliveryMethod).ValueMember = "DeliveryMethodID";
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(4, 27);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(56, 23);
    this.Label4.TabIndex = 130;
    this.Label4.Text = "Salutation";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEmail).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.txtEmail).BackColor = Color.White;
    ((Control) this.txtEmail).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblCompanyContacts.Email", true));
    ((Control) this.txtEmail).Location = new Point(64 /*0x40*/, 192 /*0xC0*/);
    this.txtEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEmail).Name = "txtEmail";
    ((Control) this.txtEmail).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.txtEmail).TabIndex = 8;
    ((UltraControlBase) this.txtEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(20, 192 /*0xC0*/);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(40, 23);
    this.Label13.TabIndex = 121;
    this.Label13.Text = "Email";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTitle).Appearance = (AppearanceBase) appearance10;
    ((TextEditorControlBase) this.txtTitle).BackColor = Color.White;
    ((Control) this.txtTitle).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblCompanyContacts.Title", true));
    ((Control) this.txtTitle).Location = new Point(63 /*0x3F*/, 100);
    this.txtTitle.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtTitle).Name = "txtTitle";
    ((Control) this.txtTitle).Size = new Size(129, 20);
    ((Control) this.txtTitle).TabIndex = 3;
    ((UltraControlBase) this.txtTitle).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTitle).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(20, 99);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(40, 23);
    this.Label8.TabIndex = 111;
    this.Label8.Text = "Title";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(28, 147);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(32 /*0x20*/, 23);
    this.Label3.TabIndex = 98;
    this.Label3.Text = "Cell";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLName).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.txtLName).BackColor = Color.White;
    ((Control) this.txtLName).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblCompanyContacts.LName", true));
    ((Control) this.txtLName).Location = new Point(63 /*0x3F*/, 76);
    this.txtLName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLName).Name = "txtLName";
    ((Control) this.txtLName).Size = new Size(129, 20);
    ((Control) this.txtLName).TabIndex = 2;
    ((UltraControlBase) this.txtLName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLName).UseOsThemes = (DefaultableBoolean) 2;
    this.lblAddress1.BackColor = Color.Transparent;
    this.lblAddress1.Location = new Point(30, 51);
    this.lblAddress1.Name = "lblAddress1";
    this.lblAddress1.Size = new Size(30, 23);
    this.lblAddress1.TabIndex = 89;
    this.lblAddress1.Text = "First";
    this.lblAddress1.TextAlign = ContentAlignment.MiddleRight;
    this.lblAddress2.BackColor = Color.Transparent;
    this.lblAddress2.Location = new Point(30, 75);
    this.lblAddress2.Name = "lblAddress2";
    this.lblAddress2.Size = new Size(30, 23);
    this.lblAddress2.TabIndex = 90;
    this.lblAddress2.Text = "Last";
    this.lblAddress2.TextAlign = ContentAlignment.MiddleRight;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFName).Appearance = (AppearanceBase) appearance12;
    ((TextEditorControlBase) this.txtFName).BackColor = Color.White;
    ((Control) this.txtFName).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblCompanyContacts.FName", true));
    ((Control) this.txtFName).Location = new Point(63 /*0x3F*/, 52);
    this.txtFName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFName).Name = "txtFName";
    ((Control) this.txtFName).Size = new Size(129, 20);
    ((Control) this.txtFName).TabIndex = 1;
    ((UltraControlBase) this.txtFName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFName).UseOsThemes = (DefaultableBoolean) 2;
    this.lblPhone.BackColor = Color.Transparent;
    this.lblPhone.Location = new Point(20, 123);
    this.lblPhone.Name = "lblPhone";
    this.lblPhone.Size = new Size(40, 23);
    this.lblPhone.TabIndex = 92;
    this.lblPhone.Text = "Phone";
    this.lblPhone.TextAlign = ContentAlignment.MiddleRight;
    this.lstContacts.DataSource = (object) this.dvProducerContacts;
    this.lstContacts.DisplayMember = "Name";
    this.lstContacts.Location = new Point(7, 32 /*0x20*/);
    this.lstContacts.MGAStyle = MGAStyles.Blue;
    this.lstContacts.Name = "lstContacts";
    this.lstContacts.Size = new Size(147, 249);
    this.lstContacts.TabIndex = 0;
    this.lstContacts.ValueMember = "CompanyContactGuid";
    this.dvProducerContacts.RowFilter = "StatusID = 1";
    this.dvProducerContacts.Table = (DataTable) this.dsContacts.tblCompanyContacts;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpContacts.Appearance = (AppearanceBase) appearance13;
    this.grpContacts.BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance14.BackColor = Color.FromArgb(239, 247, 253);
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpContacts.ContentAreaAppearance = (AppearanceBase) appearance14;
    ((Control) this.grpContacts).Controls.Add((Control) this.lstContacts);
    ((Control) this.grpContacts).Controls.Add((Control) this.chkFilterActive);
    ((Control) this.grpContacts).Controls.Add((Control) this.chkFilterInActive);
    ((Control) this.grpContacts).Enabled = false;
    appearance15.ForeColor = Color.FromArgb(21, 66, 139);
    this.grpContacts.HeaderAppearance = (AppearanceBase) appearance15;
    ((Control) this.grpContacts).Location = new Point(175, 45);
    ((Control) this.grpContacts).Name = "grpContacts";
    ((Control) this.grpContacts).Size = new Size(160 /*0xA0*/, 315);
    ((Control) this.grpContacts).TabIndex = 1;
    this.grpContacts.Text = "Contacts";
    this.grpContacts.ViewStyle = (GroupBoxViewStyle) 2;
    appearance16.BackColor = Color.FromArgb(239, 247, 253);
    appearance16.BorderColor = Color.Gray;
    appearance16.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFilterActive).Appearance = (AppearanceBase) appearance16;
    ((UltraToggleEditorBase) this.chkFilterActive).BackColor = Color.FromArgb(239, 247, 253);
    ((UltraToggleEditorBase) this.chkFilterActive).BackColorInternal = Color.WhiteSmoke;
    ((UltraToggleEditorBase) this.chkFilterActive).Checked = true;
    ((UltraToggleEditorBase) this.chkFilterActive).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkFilterActive).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((UltraToggleEditorBase) this.chkFilterActive).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFilterActive).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFilterActive).Location = new Point(16 /*0x10*/, 288);
    ((Control) this.chkFilterActive).Name = "chkFilterActive";
    ((Control) this.chkFilterActive).Size = new Size(58, 14);
    ((Control) this.chkFilterActive).TabIndex = 6;
    ((UltraToggleEditorBase) this.chkFilterActive).Text = "Active";
    ((UltraControlBase) this.chkFilterActive).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFilterActive).UseOsThemes = (DefaultableBoolean) 2;
    appearance17.BackColor = Color.FromArgb(239, 247, 253);
    appearance17.BorderColor = Color.Gray;
    appearance17.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFilterInActive).Appearance = (AppearanceBase) appearance17;
    ((UltraToggleEditorBase) this.chkFilterInActive).BackColor = Color.FromArgb(239, 247, 253);
    ((UltraToggleEditorBase) this.chkFilterInActive).BackColorInternal = Color.WhiteSmoke;
    ((UltraToggleEditorBase) this.chkFilterInActive).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((UltraToggleEditorBase) this.chkFilterInActive).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFilterInActive).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFilterInActive).Location = new Point(80 /*0x50*/, 288);
    ((Control) this.chkFilterInActive).Name = "chkFilterInActive";
    ((Control) this.chkFilterInActive).Size = new Size(64 /*0x40*/, 14);
    ((Control) this.chkFilterInActive).TabIndex = 7;
    ((UltraToggleEditorBase) this.chkFilterInActive).Text = "Inactive";
    ((UltraControlBase) this.chkFilterInActive).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFilterInActive).UseOsThemes = (DefaultableBoolean) 2;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpLocations.Appearance = (AppearanceBase) appearance18;
    this.grpLocations.BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance19.BackColor = Color.FromArgb(239, 247, 253);
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpLocations.ContentAreaAppearance = (AppearanceBase) appearance19;
    ((Control) this.grpLocations).Controls.Add((Control) this.lstLocations);
    ((Control) this.grpLocations).Enabled = false;
    appearance20.ForeColor = Color.FromArgb(21, 66, 139);
    this.grpLocations.HeaderAppearance = (AppearanceBase) appearance20;
    ((Control) this.grpLocations).Location = new Point(7, 45);
    ((Control) this.grpLocations).Name = "grpLocations";
    ((Control) this.grpLocations).Size = new Size(160 /*0xA0*/, 315);
    ((Control) this.grpLocations).TabIndex = 0;
    this.grpLocations.Text = "Locations";
    this.grpLocations.ViewStyle = (GroupBoxViewStyle) 2;
    this.lstLocations.DataSource = (object) this.dsContacts.tblCompanyLocations;
    this.lstLocations.DisplayMember = "Name";
    this.lstLocations.Location = new Point(7, 32 /*0x20*/);
    this.lstLocations.MGAStyle = MGAStyles.Blue;
    this.lstLocations.Name = "lstLocations";
    this.lstLocations.Size = new Size(140, 275);
    this.lstLocations.TabIndex = 0;
    this.lstLocations.ValueMember = "CompanyLocationGuid";
    this.daContacts.DeleteCommand = this.SqlDeleteCommand1;
    this.daContacts.InsertCommand = this.SqlInsertCommand1;
    this.daContacts.SelectCommand = this.SqlSelectCommand2;
    this.daContacts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyContacts", new DataColumnMapping[13]
      {
        new DataColumnMapping("CompanyContactGuid", "CompanyContactGuid"),
        new DataColumnMapping("CompanyLocationGuid", "CompanyLocationGuid"),
        new DataColumnMapping("DeliveryMethodID", "DeliveryMethodID"),
        new DataColumnMapping("FName", "FName"),
        new DataColumnMapping("LName", "LName"),
        new DataColumnMapping("Title", "Title"),
        new DataColumnMapping("Phone", "Phone"),
        new DataColumnMapping("Extension", "Extension"),
        new DataColumnMapping("Cell", "Cell"),
        new DataColumnMapping("Email", "Email"),
        new DataColumnMapping("Salutation", "Salutation"),
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("Fax", "Fax")
      })
    });
    this.daContacts.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = componentResourceManager.GetString("SqlDeleteCommand1.CommandText");
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[13]
    {
      new SqlParameter("@Original_CompanyContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyContactGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Cell", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Cell", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLocationGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_DeliveryMethodID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "DeliveryMethodID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Email", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Email", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Extension", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Extension", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_FName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Fax", SqlDbType.VarChar, 12, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_LName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Phone", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Salutation", SqlDbType.VarChar, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Salutation", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_StatusID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "StatusID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Title", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Title", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[13]
    {
      new SqlParameter("@CompanyContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyContactGuid"),
      new SqlParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGuid"),
      new SqlParameter("@DeliveryMethodID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "DeliveryMethodID", DataRowVersion.Current, (object) null),
      new SqlParameter("@FName", SqlDbType.VarChar, 50, "FName"),
      new SqlParameter("@LName", SqlDbType.VarChar, 50, "LName"),
      new SqlParameter("@Title", SqlDbType.VarChar, 50, "Title"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 50, "Phone"),
      new SqlParameter("@Extension", SqlDbType.VarChar, 50, "Extension"),
      new SqlParameter("@Cell", SqlDbType.VarChar, 50, "Cell"),
      new SqlParameter("@Email", SqlDbType.VarChar, 50, "Email"),
      new SqlParameter("@Salutation", SqlDbType.VarChar, 4, "Salutation"),
      new SqlParameter("@StatusID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "StatusID", DataRowVersion.Current, (object) null),
      new SqlParameter("@Fax", SqlDbType.VarChar, 12, "Fax")
    });
    this.SqlSelectCommand2.CommandText = componentResourceManager.GetString("SqlSelectCommand2.CommandText");
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGuid")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[26]
    {
      new SqlParameter("@CompanyContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyContactGuid"),
      new SqlParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGuid"),
      new SqlParameter("@DeliveryMethodID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "DeliveryMethodID", DataRowVersion.Current, (object) null),
      new SqlParameter("@FName", SqlDbType.VarChar, 50, "FName"),
      new SqlParameter("@LName", SqlDbType.VarChar, 50, "LName"),
      new SqlParameter("@Title", SqlDbType.VarChar, 50, "Title"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 50, "Phone"),
      new SqlParameter("@Extension", SqlDbType.VarChar, 50, "Extension"),
      new SqlParameter("@Cell", SqlDbType.VarChar, 50, "Cell"),
      new SqlParameter("@Email", SqlDbType.VarChar, 50, "Email"),
      new SqlParameter("@Salutation", SqlDbType.VarChar, 4, "Salutation"),
      new SqlParameter("@StatusID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "StatusID", DataRowVersion.Current, (object) null),
      new SqlParameter("@Fax", SqlDbType.VarChar, 12, "Fax"),
      new SqlParameter("@Original_CompanyContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyContactGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Cell", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Cell", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLocationGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_DeliveryMethodID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "DeliveryMethodID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Email", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Email", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Extension", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Extension", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_FName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Fax", SqlDbType.VarChar, 12, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_LName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Phone", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Salutation", SqlDbType.VarChar, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Salutation", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_StatusID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "StatusID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Title", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Title", DataRowVersion.Original, (object) null)
    });
    this.daSpecialContacts.DeleteCommand = this.SqlDeleteCommand2;
    this.daSpecialContacts.InsertCommand = this.SqlInsertCommand2;
    this.daSpecialContacts.SelectCommand = this.SqlSelectCommand6;
    this.daSpecialContacts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanySpecialContacts", new DataColumnMapping[2]
      {
        new DataColumnMapping("CompanyContactGuid", "CompanyContactGuid"),
        new DataColumnMapping("SpecialContactTypeID", "SpecialContactTypeID")
      })
    });
    this.daSpecialContacts.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM tblCompanySpecialContacts WHERE (CompanyContactGuid = @Original_CompanyContactGuid) AND (SpecialContactTypeID = @Original_SpecialContactTypeID)";
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_CompanyContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyContactGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SpecialContactTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SpecialContactTypeID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = "INSERT INTO tblCompanySpecialContacts(CompanyContactGuid, SpecialContactTypeID) VALUES (@CompanyContactGuid, @SpecialContactTypeID)";
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@CompanyContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyContactGuid"),
      new SqlParameter("@SpecialContactTypeID", SqlDbType.Int, 4, "SpecialContactTypeID")
    });
    this.SqlSelectCommand6.CommandText = "SELECT CompanyContactGuid, SpecialContactTypeID FROM tblCompanySpecialContacts WHERE (CompanyContactGuid = @CompanyContactGuid)";
    this.SqlSelectCommand6.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@CompanyContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyContactGuid")
    });
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@CompanyContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyContactGuid"),
      new SqlParameter("@SpecialContactTypeID", SqlDbType.Int, 4, "SpecialContactTypeID"),
      new SqlParameter("@Original_CompanyContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyContactGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SpecialContactTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SpecialContactTypeID", DataRowVersion.Original, (object) null)
    });
    ((AppearanceBase) appearance21).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance21).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblCompany).Appearance = (AppearanceBase) appearance21;
    ((Control) this.lblCompany).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblCompany).Location = new Point(5, 5);
    ((Control) this.lblCompany).Name = "lblCompany";
    ((Control) this.lblCompany).Size = new Size(695, 32 /*0x20*/);
    ((Control) this.lblCompany).TabIndex = 5;
    ((ControlBase) this.lblCompany).Text = "Label2";
    ((ControlBase) this.lblCompany).UseMnemonic = false;
    this.err.ContainerControl = (ContainerControl) this;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(344, 320);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(120, 40);
    this.dbSave.TabIndex = 6;
    this.lnkAuthorize.Cursor = Cursors.Hand;
    this.lnkAuthorize.Location = new Point(480, 329);
    this.lnkAuthorize.Name = "lnkAuthorize";
    this.lnkAuthorize.Size = new Size(203, 23);
    this.lnkAuthorize.TabIndex = 131;
    this.lnkAuthorize.TabStop = true;
    this.lnkAuthorize.Text = "Authorize Contact for External Access";
    this.lnkAuthorize.TextAlign = ContentAlignment.MiddleCenter;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(708, 367);
    this.Controls.Add((Control) this.lnkAuthorize);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.lblCompany);
    this.Controls.Add((Control) this.grpContactInfo);
    this.Controls.Add((Control) this.grpContacts);
    this.Controls.Add((Control) this.grpLocations);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.Name = nameof (frmCompanyContacts);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Company Contacts";
    ((ISupportInitialize) this.grpContactInfo).EndInit();
    ((Control) this.grpContactInfo).ResumeLayout(false);
    ((Control) this.grpContactInfo).PerformLayout();
    ((ISupportInitialize) this.MgaSimpleComboBox1).EndInit();
    this.dsContacts.EndInit();
    ((ISupportInitialize) this.txtFax).EndInit();
    ((ISupportInitialize) this.txtCell).EndInit();
    ((ISupportInitialize) this.txtPhone).EndInit();
    ((ISupportInitialize) this.cboStatus).EndInit();
    ((ISupportInitialize) this.lstSpecialContacts).EndInit();
    ((ISupportInitialize) this.btnSpecialContact).EndInit();
    ((ISupportInitialize) this.txtExt).EndInit();
    ((ISupportInitialize) this.cboDeliveryMethod).EndInit();
    ((ISupportInitialize) this.txtEmail).EndInit();
    ((ISupportInitialize) this.txtTitle).EndInit();
    ((ISupportInitialize) this.txtLName).EndInit();
    ((ISupportInitialize) this.txtFName).EndInit();
    ((ISupportInitialize) this.lstContacts).EndInit();
    this.dvProducerContacts.EndInit();
    ((ISupportInitialize) this.grpContacts).EndInit();
    ((Control) this.grpContacts).ResumeLayout(false);
    ((ISupportInitialize) this.chkFilterActive).EndInit();
    ((ISupportInitialize) this.chkFilterInActive).EndInit();
    ((ISupportInitialize) this.grpLocations).EndInit();
    ((Control) this.grpLocations).ResumeLayout(false);
    ((ISupportInitialize) this.lstLocations).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
  }

  public frmCompanyContacts(Guid companyGuid, Guid companyLocationGuid, Guid companyContactGuid)
    : this(companyGuid, companyLocationGuid)
  {
    this._newContactOnLoad = false;
    this._companyContactGuid = companyContactGuid;
    this.lstContacts.SelectedValue = (object) this._companyContactGuid;
    this.bmbContacts.Position = this.lstContacts.SelectedIndex;
  }

  public frmCompanyContacts(Guid companyGuid, Guid companyLocationGuid)
  {
    this.Load += new EventHandler(this.frmCompanyContacts_Load);
    this.Paint += new PaintEventHandler(this.frmCompanyContacts_Paint);
    this.Closing += new CancelEventHandler(this.frmCompaniesContacts_Closing);
    this._newContactOnLoad = false;
    this._canUpdateSpecialContacts = true;
    this._permissionToAddCompanyContact = true;
    this._permissionToEditCompanyContact = true;
    this._permissionToDeleteCompanyContact = true;
    this._cn = (DbConnection) null;
    this.InitializeComponent();
    this._companyGuid = companyGuid;
    this._companyLocationGuid = companyLocationGuid;
    this.InitializeConnection();
    this.PopulateDataSet();
    this._newContactOnLoad = true;
  }

  public frmCompanyContacts(Guid companyLocationGuid)
  {
    this.Load += new EventHandler(this.frmCompanyContacts_Load);
    this.Paint += new PaintEventHandler(this.frmCompanyContacts_Paint);
    this.Closing += new CancelEventHandler(this.frmCompaniesContacts_Closing);
    this._newContactOnLoad = false;
    this._canUpdateSpecialContacts = true;
    this._permissionToAddCompanyContact = true;
    this._permissionToEditCompanyContact = true;
    this._permissionToDeleteCompanyContact = true;
    this._cn = (DbConnection) null;
    this.InitializeComponent();
    this._companyGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT CompanyGuid FROM tblCompanyLocations WHERE CompanyLocationGuid=@CompanyLocationGuid", new object[2]
    {
      (object) "@CompanyLocationGuid",
      (object) companyLocationGuid
    });
    this._companyLocationGuid = companyLocationGuid;
    this.InitializeConnection();
    this.PopulateDataSet();
    this._newContactOnLoad = true;
  }

  protected bool IsNewContactOnLoad => this._newContactOnLoad;

  protected Guid CompanyLocationGuid => this._companyLocationGuid;

  protected bool IsIntermediary
  {
    get
    {
      return !Utility.IsNull(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT IntermediaryGuid FROM tblCompanyLocations (NOLOCK) WHERE CompanyLocationGuid=@CompanyLocationGuid", new object[2]
      {
        (object) "@CompanyLocationGuid",
        (object) this.CompanyLocationGuid
      }))));
    }
  }

  protected virtual bool IntermediaryCheck() => false;

  private BindingManagerBase bmbContacts
  {
    get
    {
      return this.BindingContext[(object) this.dsContacts, this.dsContacts.tblCompanyContacts.TableName];
    }
  }

  private dsCompanyContacts.tblCompanyContactsRow CurrentContactRow
  {
    get => this.dsContacts.tblCompanyContacts[this.bmbContacts.Position];
  }

  private bool ValidForm
  {
    get
    {
      bool validForm = true;
      if (this.bmbContacts.Position != -1 && !string.IsNullOrEmpty(((TextEditorControlBase) this.txtEmail).Text) && !string.IsNullOrEmpty(this.cboStatus.Text) && Conversions.ToByte(this.cboStatus.Value) == (byte) 1)
      {
        object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetDuplicateEmailAddressContact(@Email,@ContactTypeGUID,@ContactType)", new object[6]
        {
          (object) "@Email",
          (object) ((TextEditorControlBase) this.txtEmail).Text,
          (object) "@ContactTypeGUID",
          (object) this.dsContacts.tblCompanyContacts[this.bmbContacts.Position].CompanyContactGuid,
          (object) "@ContactType",
          (object) "C"
        }));
        if (objectValue != DBNull.Value && objectValue != null)
        {
          if (MessageBox.Show($"There is at least one contact:\n\n{objectValue.ToString()}\n\nthat uses the current email address of '{((TextEditorControlBase) this.txtEmail).Text}'\n\nDo you wish to continue?", "Email Address In Use. Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            validForm = false;
        }
      }
      if (((TextEditorControlBase) this.txtFName).Text.Length == 0)
      {
        this.err.SetError((Control) this.txtFName, "Please enter a first name.");
        validForm = false;
      }
      else
        this.err.SetError((Control) this.txtFName, string.Empty);
      if (((TextEditorControlBase) this.txtLName).Text.Length == 0)
      {
        this.err.SetError((Control) this.txtLName, "Please enter a last name.");
        validForm = false;
      }
      else
        this.err.SetError((Control) this.txtLName, string.Empty);
      if (this.cboDeliveryMethod.Text.Length == 0 || this.cboDeliveryMethod.Value == null)
      {
        this.err.SetError((Control) this.cboDeliveryMethod, "Please enter a delivery method.");
        validForm = false;
      }
      else if (Conversions.ToInteger(this.cboDeliveryMethod.Value) == 3 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtEmail).Text, string.Empty, false) == 0)
      {
        this.err.SetError((Control) this.txtEmail, "Email must be provided when selecting email delivery type.");
        this.err.SetError((Control) this.txtFax, string.Empty);
        this.err.SetError((Control) this.cboDeliveryMethod, string.Empty);
        validForm = false;
      }
      else if (Conversions.ToInteger(this.cboDeliveryMethod.Value) == 2 && this.txtFax.Value == DBNull.Value | this.txtFax.Value == (object) string.Empty)
      {
        this.err.SetError((Control) this.txtFax, "Fax must be provided when selecting fax delivery type.");
        this.err.SetError((Control) this.txtEmail, string.Empty);
        this.err.SetError((Control) this.cboDeliveryMethod, string.Empty);
        validForm = false;
      }
      else
      {
        this.err.SetError((Control) this.txtFax, string.Empty);
        this.err.SetError((Control) this.txtEmail, string.Empty);
        this.err.SetError((Control) this.cboDeliveryMethod, string.Empty);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtEmail).Text, string.Empty, false) != 0 && !Parsing.IsValidEmailAddress(((TextEditorControlBase) this.txtEmail).Text))
      {
        this.err.SetError((Control) this.txtEmail, "Please enter a valid email address.");
        validForm = false;
      }
      if (this.cboStatus.Text.Length == 0)
      {
        this.err.SetError((Control) this.cboStatus, "Please select a status.");
        validForm = false;
      }
      else
        this.err.SetError((Control) this.cboStatus, string.Empty);
      return validForm;
    }
  }

  private void frmCompanyContacts_Load(object sender, EventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    this.SetupSecurity();
    this.lstLocations.SelectedValue = (object) this._companyLocationGuid;
    this._canUpdateSpecialContacts = SecurityManager.Instance.AssertPermission("{44E2196F-B453-45b2-AB6B-AC6A4802E210}");
    this.lstLocations.SelectedIndexChanged += new EventHandler(this.lstLocations_SelectedIndexChanged);
    this.lstContacts.MouseUp += new MouseEventHandler(this.SelectContact);
    this.lstContacts.KeyUp += new KeyEventHandler(this.SelectContact);
    this.lstSpecialContacts.Enabled = this._canUpdateSpecialContacts;
    ((Control) this.btnSpecialContact).Enabled = this._canUpdateSpecialContacts;
  }

  private void frmCompanyContacts_Paint(object sender, PaintEventArgs e)
  {
    if (this._painted)
      return;
    this._painted = true;
    if (this._newContactOnLoad)
    {
      this.dbSave.FreezeEvents = false;
      this.dbSave.PerformAction(DBSaveUIAction.ClickNewButton);
    }
    else
    {
      this.dbSave.UIState = this.dsContacts.tblCompanyContacts.Count <= 0 ? UIState.NoRecordsNotEditing : UIState.HasRecordsNotEditing;
      this.UpdateContactBinding();
    }
  }

  private void SetupSecurity()
  {
    this._permissionToAddCompanyContact = SecurityManager.Instance.AssertPermission("{3C3844F1-CA95-4f3e-9794-9ABC240CA762}");
    this._permissionToEditCompanyContact = SecurityManager.Instance.AssertPermission("{9BC3B275-3F72-4f46-98E4-70964474C587}");
    this._permissionToDeleteCompanyContact = SecurityManager.Instance.AssertPermission("{9E984B61-1845-45b0-8392-A168A918F0DC}");
  }

  private void lnkAuthorize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.bmbContacts.Position == -1)
      return;
    if (this.dsContacts.tblCompanyContacts[this.bmbContacts.Position].RowState == DataRowState.Added)
    {
      int num = (int) MessageBox.Show("Please save this contact before configuring them for external access.", "Save Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      using (FormSettings.ShowFormDialog(typeof (frmAuthorizeContact), (object) this.dsContacts.tblCompanyContacts[this.bmbContacts.Position].CompanyContactGuid))
        ;
    }
  }

  private void UpdateContactBinding()
  {
    Database.MoveTo(RuntimeHelpers.GetObjectValue(this.lstContacts.SelectedValue), "CompanyContactGuid", (DataTable) this.dsContacts.tblCompanyContacts, this.bmbContacts);
    if (this.lstContacts.SelectedValue == null || this.bmbContacts.Position == -1)
      return;
    this.LoadSpecialContacts((Guid) this.lstContacts.SelectedValue);
    if (this.dsContacts.tblCompanyContacts[this.bmbContacts.Position].RowState == DataRowState.Deleted)
      return;
    this._companyContactGuid = this.dsContacts.tblCompanyContacts[this.bmbContacts.Position].CompanyContactGuid;
  }

  private void PopulateDataSet()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsContacts, new string[5]
    {
      "tblCompanies",
      "lstDeliveryMethod",
      "lstStatus",
      "lstCompanySpecialContactTypes",
      "lstSalutations"
    }, "dbo.spGetCompanyContactsFormData", new object[2]
    {
      (object) "@CompanyGuid",
      (object) this._companyGuid
    });
    DefaultDatabase.LoadDataSet((DataSet) this.dsContacts, new string[1]
    {
      "tblCompanyLocations"
    }, CommandType.Text, "SELECT CompanyLocationGuid, CompanyGuid, Name FROM tblCompanyLocations WHERE (CompanyGuid = @CompanyGuid) ORDER BY Name", new object[2]
    {
      (object) "@CompanyGuid",
      (object) this._companyGuid
    });
    this.lstLocations.SelectedValue = (object) this._companyLocationGuid;
    this.daContacts.SelectCommand.Parameters["@CompanyLocationGuid"].Value = (object) this._companyLocationGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblCompanyContacts);
    if (this.dsContacts.tblCompanyContacts.Rows.Count > 0)
    {
      this.daSpecialContacts.SelectCommand.Parameters["@CompanyContactGuid"].Value = (object) this.dsContacts.tblCompanyContacts[0].CompanyContactGuid;
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblCompanySpecialContacts);
    }
    ((ControlBase) this.lblCompany).Text = this.dsContacts.tblCompanies[0].CompanyName;
  }

  internal void RefillSpecialContactsListTable()
  {
    this.dsContacts.EnforceConstraints = false;
    this.dsContacts.lstCompanySpecialContactTypes.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsContacts, new string[1]
    {
      "lstCompanySpecialContactTypes"
    }, CommandType.Text, "SELECT SpecialContactTypeID, SpecialContactType FROM lstCompanySpecialContactTypes WHERE (Hidden = 0) ORDER BY SpecialContactType");
    this.dsContacts.EnforceConstraints = true;
    this.FillSpecialContactsListbox();
  }

  private void lstLocations_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.bmbContacts.EndCurrentEdit();
    if (this.dsContacts.HasChanges() && MessageBox.Show($"You have unsaved changes to contacts at this location.{Environment.NewLine}{Environment.NewLine}Would you like to save?", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboDeliveryMethod.Text, string.Empty, false) == 0)
      {
        int num = (int) MessageBox.Show("Delivery Method must not be empty.", "Empty Delivery Method", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        return;
      }
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblCompanyContacts);
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblCompanyContacts);
    }
    this.dsContacts.tblCompanySpecialContacts.Clear();
    this.dsContacts.tblCompanyContacts.Clear();
    this.daContacts.SelectCommand.Parameters["@CompanyLocationGuid"].Value = RuntimeHelpers.GetObjectValue(this.lstLocations.SelectedValue);
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblCompanyContacts);
    this.ClearSpecialContacts();
    if (this.lstContacts.SelectedIndex > -1)
    {
      this.UpdateContactBinding();
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    }
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void ClearSpecialContacts()
  {
    this.dsContacts.tblCompanySpecialContacts.Clear();
    this.dsContacts.tblCompanySpecialContacts.Clear();
    this.lstSpecialContacts.ItemCheck -= new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
    int num = this.lstSpecialContacts.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
      this.lstSpecialContacts.SetItemChecked(index, false);
    this.lstSpecialContacts.ItemCheck += new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
  }

  private void LoadSpecialContacts(Guid contactGuid)
  {
    this.dsContacts.tblCompanySpecialContacts.Clear();
    this.daSpecialContacts.SelectCommand.Parameters["@CompanyContactGuid"].Value = (object) contactGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblCompanySpecialContacts);
    this.FillSpecialContactsListbox();
  }

  private void lstSpecialContacts_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    int specialContactTypeId = ((dsCompanyContacts.lstCompanySpecialContactTypesRow) ((DataRowView) this.lstSpecialContacts.Items[this.lstSpecialContacts.SelectedIndex]).Row).SpecialContactTypeID;
    Guid companyContactGuid = this.CurrentContactRow.CompanyContactGuid;
    if (e.CurrentValue == CheckState.Unchecked)
    {
      dsCompanyContacts.tblCompanySpecialContactsRow row = this.dsContacts.tblCompanySpecialContacts.NewtblCompanySpecialContactsRow();
      row.CompanyContactGuid = companyContactGuid;
      row.SpecialContactTypeID = specialContactTypeId;
      this.dsContacts.tblCompanySpecialContacts.AddtblCompanySpecialContactsRow(row);
    }
    else
    {
      try
      {
        this.dsContacts.tblCompanySpecialContacts.FindByCompanyContactGuidSpecialContactTypeID(companyContactGuid, specialContactTypeId).Delete();
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
    Cursor.Current = MgaCursors.Default;
  }

  private void FillSpecialContactsListbox()
  {
    this.lstSpecialContacts.ItemCheck -= new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
    int num1 = this.lstSpecialContacts.Items.Count - 1;
    for (int index = 0; index <= num1; ++index)
      this.lstSpecialContacts.SetItemChecked(index, false);
    try
    {
      foreach (dsCompanyContacts.tblCompanySpecialContactsRow companySpecialContact in (TypedTableBase<dsCompanyContacts.tblCompanySpecialContactsRow>) this.dsContacts.tblCompanySpecialContacts)
      {
        int num2 = this.lstSpecialContacts.Items.Count - 1;
        for (int index = 0; index <= num2; ++index)
        {
          int specialContactTypeId = ((dsCompanyContacts.lstCompanySpecialContactTypesRow) ((DataRowView) this.lstSpecialContacts.Items[index]).Row).SpecialContactTypeID;
          if (companySpecialContact.SpecialContactTypeID == specialContactTypeId)
            this.lstSpecialContacts.SetItemChecked(index, true);
        }
      }
    }
    finally
    {
      IEnumerator<dsCompanyContacts.tblCompanySpecialContactsRow> enumerator;
      enumerator?.Dispose();
    }
    this.lstSpecialContacts.ItemCheck += new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
  }

  private void SelectContact(object sender, KeyEventArgs e)
  {
    MouseEventArgs e1 = (MouseEventArgs) null;
    this.SelectContact(RuntimeHelpers.GetObjectValue(sender), e1);
  }

  private void SelectContact(object sender, MouseEventArgs e)
  {
    if (this.lstContacts.SelectedIndex <= -1)
      return;
    this.UpdateContactBinding();
  }

  private void RefreshOpenForms()
  {
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      Form form = mdiChildren[index];
      if (form is frmCompanies && ((frmCompanies) form).CompanyGuid.Equals(this._companyGuid))
        ((frmCompanies) form).LoadContacts();
      checked { ++index; }
    }
  }

  private void frmCompaniesContacts_Closing(object sender, CancelEventArgs e)
  {
    this.bmbContacts.EndCurrentEdit();
    if (!this.dsContacts.HasChanges())
      return;
    switch (MessageBox.Show("You have unsaved changes.  Would you like to save before closing the form?", "Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
    {
      case DialogResult.Cancel:
        e.Cancel = true;
        break;
      case DialogResult.Yes:
        if (this.ValidForm)
        {
          if (!this.dsContacts.tblCompanyContacts[this.bmbContacts.Position].IsDeliveryMethodIDNull())
          {
            DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblCompanyContacts);
            DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblCompanySpecialContacts);
            this.RefreshOpenForms();
            break;
          }
          e.Cancel = true;
          break;
        }
        e.Cancel = true;
        break;
    }
  }

  private void btnSpecialContact_Click(object sender, EventArgs e)
  {
    FormSettings.ShowForm(typeof (frmAdminCompanySpecialContacts), (object) new EventHandler(this.frmAdminCompanySpecialContacts_closing));
  }

  private void frmAdminCompanySpecialContacts_closing(object sender, EventArgs e)
  {
    this.RefillSpecialContactsListTable();
  }

  private void chkFilterActive_CheckedChanged(object sender, EventArgs e) => this.FilterContacts();

  private void chkFilterInActive_CheckedChanged(object sender, EventArgs e)
  {
    this.FilterContacts();
  }

  private void FilterContacts()
  {
    this.dvProducerContacts.RowFilter = !((UltraToggleEditorBase) this.chkFilterActive).Checked || !((UltraToggleEditorBase) this.chkFilterInActive).Checked ? (!((UltraToggleEditorBase) this.chkFilterActive).Checked ? (!((UltraToggleEditorBase) this.chkFilterInActive).Checked ? "StatusID = 1 AND StatusID = 2" : "StatusID = 2") : "StatusID = 1") : "StatusID = 1 OR StatusID = 2";
    if (this.dbSave.UIState != UIState.Editing && this.lstContacts.SelectedIndex > -1)
    {
      this.UpdateContactBinding();
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    }
    else
    {
      this.bmbContacts.Position = -1;
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    }
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (this._permissionToEditCompanyContact)
      return;
    int num = (int) MessageBox.Show("You do not have sufficient security to edit company contacts.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    e.Cancel = true;
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    bool flag = this.dbSave.UIState == UIState.Editing;
    ((Control) this.grpContactInfo).Enabled = flag;
    ((Control) this.grpContacts).Enabled = flag;
    ((Control) this.grpLocations).Enabled = flag;
    this.dbSave.UIStateChanged -= new EventHandler(this.dbSave_UIStateChanged);
    if (!flag)
      this.dbSave.UIState = this.dsContacts.tblCompanyContacts.Count != 0 ? UIState.HasRecordsNotEditing : UIState.NoRecordsNotEditing;
    this.dbSave.UIStateChanged += new EventHandler(this.dbSave_UIStateChanged);
    this.lstSpecialContacts.Enabled = this._canUpdateSpecialContacts;
    ((Control) this.btnSpecialContact).Enabled = this._canUpdateSpecialContacts;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.bmbContacts.Position == -1)
      e.Cancel = true;
    else if (this.dsContacts.tblCompanyContacts[this.bmbContacts.Position].RowState == DataRowState.Added && !this._permissionToAddCompanyContact)
    {
      int num = (int) MessageBox.Show("You do not have sufficient security to add new company contacts.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else if (!this._permissionToEditCompanyContact)
    {
      int num = (int) MessageBox.Show("You do not have sufficient security to edit company contacts.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      if (this.ValidForm)
      {
        this.bmbContacts.EndCurrentEdit();
        if (this.dsContacts.tblCompanyContacts[this.bmbContacts.Position].IsDeliveryMethodIDNull())
        {
          this.err.SetError((Control) this.cboStatus, "Please enter a delivery method.");
          e.Cancel = true;
          return;
        }
        this.err.SetError((Control) this.cboDeliveryMethod, string.Empty);
        if (this.CurrentContactRow.RowState == DataRowState.Added || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.CurrentContactRow.Name, $"{((TextEditorControlBase) this.txtLName).Text}, {((TextEditorControlBase) this.txtFName).Text}", false) != 0)
          this.CurrentContactRow.Name = $"{((TextEditorControlBase) this.txtLName).Text}, {((TextEditorControlBase) this.txtFName).Text}";
        if (this.dsContacts.HasChanges())
        {
          try
          {
            DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblCompanyContacts);
            DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblCompanySpecialContacts);
          }
          catch (SqlException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            if (ex.Message.Contains("NULL into column 'DeliveryMethodID'"))
            {
              int num = (int) MessageBox.Show("Missing delivery method on a contact", "Missing Delivery Method", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              e.Cancel = true;
              ProjectData.ClearProjectError();
              return;
            }
            ProjectData.ClearProjectError();
          }
          this.RefreshOpenForms();
        }
        MDIControls.Instance.StatusBarText = "Your changes were saved successfully.";
        if (this.lstContacts.Items.Count == 0)
          this.dbSave.UIState = UIState.HasRecordsNotEditing;
      }
      else
        e.Cancel = true;
      this.lstContacts.Enabled = true;
      this.lstLocations.Enabled = true;
    }
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (!this._permissionToAddCompanyContact)
    {
      int num = (int) MessageBox.Show("You do not have sufficient security to add new company contacts.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      if (this.IntermediaryCheck())
        e.Cancel = true;
      dsCompanyContacts.tblCompanyContactsDataTable tblCompanyContacts = this.dsContacts.tblCompanyContacts;
      dsCompanyContacts.tblCompanyContactsRow row = tblCompanyContacts.NewtblCompanyContactsRow();
      this._companyContactGuid = Guid.NewGuid();
      row.CompanyContactGuid = this._companyContactGuid;
      row.CompanyLocationGuid = (Guid) this.lstLocations.SelectedValue;
      tblCompanyContacts.AddtblCompanyContactsRow(row);
      this.bmbContacts.Position = this.bmbContacts.Count - 1;
      ((UltraDropDownBase) this.cboDeliveryMethod).SelectedRow = (UltraGridRow) null;
      ((UltraDropDownBase) this.cboStatus).SelectedRow = (UltraGridRow) null;
      this.lstContacts.Enabled = false;
      this.lstLocations.Enabled = false;
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.bmbContacts.Position == -1)
      e.Cancel = true;
    else if (!this._permissionToDeleteCompanyContact)
    {
      int num = (int) MessageBox.Show("You do not have sufficient security to delete company contacts.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      if (MessageBox.Show($"Are you sure you want to delete {this.dsContacts.tblCompanyContacts.FindByCompanyContactGuid(this.dsContacts.tblCompanyContacts[this.bmbContacts.Position].CompanyContactGuid).LName}, {this.dsContacts.tblCompanyContacts.FindByCompanyContactGuid(this.dsContacts.tblCompanyContacts[this.bmbContacts.Position].CompanyContactGuid).FName}?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        try
        {
          DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
          {
            try
            {
              DataRow[] dataRowArray = this.dsContacts.tblCompanySpecialContacts.Select($"CompanyContactGuid = '{this.dsContacts.tblCompanyContacts[this.bmbContacts.Position].CompanyContactGuid.ToString()}'");
              int index = 0;
              while (index < dataRowArray.Length)
              {
                dataRowArray[index].Delete();
                checked { ++index; }
              }
              this.dsContacts.tblCompanyContacts.FindByCompanyContactGuid(this.dsContacts.tblCompanyContacts[this.bmbContacts.Position].CompanyContactGuid).Delete();
              DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblCompanySpecialContacts);
              DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblCompanyContacts);
              args.Transaction.Commit();
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              args.Transaction.Rollback();
              throw;
            }
          }));
        }
        catch (SqlException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) MessageBox.Show("This user cannot be deleted because they are associated with one or more policies.", "Cannot Delete User", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          ProjectData.ClearProjectError();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ErrorHandler.HandleError(ex);
          ProjectData.ClearProjectError();
        }
        this.RefreshOpenForms();
        if (this.lstContacts.Items.Count == 0)
          this.dbSave.UIState = UIState.NoRecordsNotEditing;
      }
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    }
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.dsContacts.tblCompanyContacts[this.bmbContacts.Position].RejectChanges();
    this.err.SetError((Control) this.txtFName, string.Empty);
    this.err.SetError((Control) this.txtLName, string.Empty);
    this.err.SetError((Control) this.cboDeliveryMethod, string.Empty);
    this.err.SetError((Control) this.cboStatus, string.Empty);
    this.lstContacts.Enabled = true;
    this.lstLocations.Enabled = true;
  }

  private void InitializeConnection()
  {
    Utility.SetDataAdapterConnections((DbDataAdapter) this.daContacts, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    Utility.SetDataAdapterConnections((DbDataAdapter) this.daSpecialContacts, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._cn != null)
        this._cn.Dispose();
    }
    base.Dispose(disposing);
  }
}

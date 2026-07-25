// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Insureds.frmInsuredContacts
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using MGASystems.AddressResolver;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Insureds;

public class frmInsuredContacts : Form
{
  private Guid _insuredGuid;
  private Guid _insuredLocationGuid;
  private Guid _insuredContactGuid;
  private frmInsuredContacts.ScreenMode _screenMode;
  private bool _isNew;
  private bool _hasSpecialContactType;
  private int _specialContactTypeID;
  private IContainer components;
  private Label lblAddress1;
  private Label lblAddress2;
  private Label lblPhone;
  private Label Label3;
  private Label Label8;
  private Label Label13;
  private Label Label4;
  private Label Label7;
  private MGASimpleComboBox cboDeliveryMethod;
  private UltraLabel lblInsured;
  private UltraGroupBox grpContacts;
  private ToolTip ToolTip;
  private SqlDataAdapter daContacts;
  private MGATextBox txtTitle;
  private MGATextBox txtLName;
  private MGATextBox txtFName;
  private MGATextBox txtExt;
  private UltraGroupBox grpContactInfo;
  private SqlDataAdapter daSpecialContacts;
  private Label Label2;
  private SqlDataAdapter daSpecialContactsList;
  private SqlConnection cnSQL;
  private Label Label5;
  private MGASimpleComboBox cboStatus;
  private SqlDataAdapter daStatus;
  private SqlCommand SqlSelectCommand7;
  private DataView dvlstSpecialContacts;
  private SqlCommand SqlSelectCommand6;
  private Label Label1;
  private UltraGroupBox GroupBox3;
  private DataView dvInsuredContacts;
  private SqlCommand SqlSelectCommand5;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand2;
  private SqlCommand SqlUpdateCommand2;
  private SqlCommand SqlDeleteCommand2;
  private MGASimpleComboBox cboSalutations;

  protected virtual BindingManagerBase bmb
  {
    get => this._bmb;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.bmb_PositionChanged);
      BindingManagerBase bmb1 = this._bmb;
      if (bmb1 != null)
        bmb1.PositionChanged -= eventHandler;
      this._bmb = value;
      BindingManagerBase bmb2 = this._bmb;
      if (bmb2 == null)
        return;
      bmb2.PositionChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkOptOut")]
  private virtual MGACheckBox chkOptOut { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAListBox lstContacts
  {
    get => this._lstContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lstContacts_VisibleChanged);
      MGAListBox lstContacts1 = this._lstContacts;
      if (lstContacts1 != null)
        lstContacts1.VisibleChanged -= eventHandler;
      this._lstContacts = value;
      MGAListBox lstContacts2 = this._lstContacts;
      if (lstContacts2 == null)
        return;
      lstContacts2.VisibleChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtEmail")]
  protected virtual MGATextBox txtEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  private virtual MGAButton btnInsSpecialContact
  {
    get => this._btnInsSpecialContact;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnInsSpecialContact_Click);
      MGAButton insSpecialContact1 = this._btnInsSpecialContact;
      if (insSpecialContact1 != null)
        ((Control) insSpecialContact1).Click -= eventHandler;
      this._btnInsSpecialContact = value;
      MGAButton insSpecialContact2 = this._btnInsSpecialContact;
      if (insSpecialContact2 == null)
        return;
      ((Control) insSpecialContact2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtCell")]
  protected virtual MGAMaskedEdit txtCell { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPhone")]
  protected virtual MGAMaskedEdit txtPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ErrProvider")]
  protected virtual ErrorProvider ErrProvider { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ctlZipCode")]
  protected virtual MGA_ZipCodeResolver ctlZipCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("umFax")]
  protected virtual MGAMaskedEdit umFax { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingCancel);
      QueryRowCountHandler queryRowCountHandler = new QueryRowCountHandler(this.dbSave_QueryRowCount);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingDelete);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.UIStateChanged -= eventHandler;
        dbSave1.ClickingSave -= cancelEventHandler1;
        dbSave1.ClickingNew -= cancelEventHandler2;
        dbSave1.ClickingCancel -= cancelEventHandler3;
        dbSave1.QueryRowCount -= queryRowCountHandler;
        dbSave1.ClickingDelete -= cancelEventHandler4;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.UIStateChanged += eventHandler;
      dbSave2.ClickingSave += cancelEventHandler1;
      dbSave2.ClickingNew += cancelEventHandler2;
      dbSave2.ClickingCancel += cancelEventHandler3;
      dbSave2.QueryRowCount += queryRowCountHandler;
      dbSave2.ClickingDelete += cancelEventHandler4;
    }
  }

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

  [field: AccessedThroughProperty("dsContacts")]
  protected virtual dsInsuredContacts dsContacts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmInsuredContacts));
    this.grpContactInfo = new UltraGroupBox();
    this.chkOptOut = new MGACheckBox();
    this.dsContacts = new dsInsuredContacts();
    this.cboSalutations = new MGASimpleComboBox();
    this.cboStatus = new MGASimpleComboBox();
    this.txtTitle = new MGATextBox();
    this.Label1 = new Label();
    this.umFax = new MGAMaskedEdit();
    this.ctlZipCode = new MGA_ZipCodeResolver();
    this.txtCell = new MGAMaskedEdit();
    this.txtPhone = new MGAMaskedEdit();
    this.Label5 = new Label();
    this.btnInsSpecialContact = new MGAButton();
    this.Label2 = new Label();
    this.txtExt = new MGATextBox();
    this.Label7 = new Label();
    this.cboDeliveryMethod = new MGASimpleComboBox();
    this.Label4 = new Label();
    this.txtEmail = new MGATextBox();
    this.Label13 = new Label();
    this.Label8 = new Label();
    this.txtLName = new MGATextBox();
    this.lblAddress1 = new Label();
    this.lblAddress2 = new Label();
    this.txtFName = new MGATextBox();
    this.lblPhone = new Label();
    this.Label3 = new Label();
    this.lstSpecialContacts = new MGACheckedListBox();
    this.dvlstSpecialContacts = new DataView();
    this.lstContacts = new MGAListBox();
    this.dvInsuredContacts = new DataView();
    this.lblInsured = new UltraLabel();
    this.grpContacts = new UltraGroupBox();
    this.GroupBox3 = new UltraGroupBox();
    this.chkFilterActive = new MGACheckBox();
    this.chkFilterInActive = new MGACheckBox();
    this.ToolTip = new ToolTip(this.components);
    this.cnSQL = new SqlConnection();
    this.daContacts = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    this.daSpecialContacts = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand5 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.daSpecialContactsList = new SqlDataAdapter();
    this.SqlSelectCommand6 = new SqlCommand();
    this.daStatus = new SqlDataAdapter();
    this.SqlSelectCommand7 = new SqlCommand();
    this.ErrProvider = new ErrorProvider(this.components);
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.lnkAuthorize = new LinkLabel();
    ((ISupportInitialize) this.grpContactInfo).BeginInit();
    ((Control) this.grpContactInfo).SuspendLayout();
    ((ISupportInitialize) this.chkOptOut).BeginInit();
    this.dsContacts.BeginInit();
    ((ISupportInitialize) this.cboSalutations).BeginInit();
    ((ISupportInitialize) this.cboStatus).BeginInit();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    ((ISupportInitialize) this.umFax).BeginInit();
    ((ISupportInitialize) this.txtCell).BeginInit();
    ((ISupportInitialize) this.txtPhone).BeginInit();
    ((ISupportInitialize) this.btnInsSpecialContact).BeginInit();
    ((ISupportInitialize) this.txtExt).BeginInit();
    ((ISupportInitialize) this.cboDeliveryMethod).BeginInit();
    ((ISupportInitialize) this.txtEmail).BeginInit();
    ((ISupportInitialize) this.txtLName).BeginInit();
    ((ISupportInitialize) this.txtFName).BeginInit();
    ((ISupportInitialize) this.lstSpecialContacts).BeginInit();
    this.dvlstSpecialContacts.BeginInit();
    ((ISupportInitialize) this.lstContacts).BeginInit();
    this.dvInsuredContacts.BeginInit();
    ((ISupportInitialize) this.grpContacts).BeginInit();
    ((Control) this.grpContacts).SuspendLayout();
    ((ISupportInitialize) this.GroupBox3).BeginInit();
    ((Control) this.GroupBox3).SuspendLayout();
    ((ISupportInitialize) this.chkFilterActive).BeginInit();
    ((ISupportInitialize) this.chkFilterInActive).BeginInit();
    ((ISupportInitialize) this.ErrProvider).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    this.grpContactInfo.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.grpContactInfo).Controls.Add((Control) this.chkOptOut);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.cboSalutations);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.cboStatus);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtTitle);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label1);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.umFax);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.ctlZipCode);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtCell);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtPhone);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label5);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.btnInsSpecialContact);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label2);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtExt);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label7);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.cboDeliveryMethod);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label4);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtEmail);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label13);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label8);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtLName);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.lblAddress1);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.lblAddress2);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtFName);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.lblPhone);
    ((Control) this.grpContactInfo).Controls.Add((Control) this.Label3);
    ((Control) this.grpContactInfo).Enabled = false;
    appearance2.ForeColor = Color.FromArgb(21, 66, 139);
    this.grpContactInfo.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.grpContactInfo).Location = new Point(177, 40);
    ((Control) this.grpContactInfo).Name = "grpContactInfo";
    ((Control) this.grpContactInfo).Size = new Size(484, 317);
    ((Control) this.grpContactInfo).TabIndex = 2;
    this.grpContactInfo.Text = "Contact Information";
    this.grpContactInfo.ViewStyle = (GroupBoxViewStyle) 2;
    appearance3.BackColor = Color.Transparent;
    appearance3.BorderColor = Color.Gray;
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkOptOut).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.chkOptOut).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOptOut).BackColorInternal = Color.Transparent;
    ((Control) this.chkOptOut).DataBindings.Add(new Binding("Checked", (object) this.dsContacts, "tblInsuredContacts.OptOut", true));
    ((UltraToggleEditorBase) this.chkOptOut).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkOptOut).Location = new Point(341, 287);
    ((Control) this.chkOptOut).Name = "chkOptOut";
    ((Control) this.chkOptOut).Size = new Size(83, 14);
    ((Control) this.chkOptOut).TabIndex = 24;
    ((UltraToggleEditorBase) this.chkOptOut).Text = "Opt Out";
    ((UltraControlBase) this.chkOptOut).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkOptOut).UseOsThemes = (DefaultableBoolean) 2;
    this.dsContacts.DataSetName = "dsInsuredContacts";
    this.dsContacts.Locale = new CultureInfo("en-US");
    this.dsContacts.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cboSalutations.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboSalutations).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblInsuredContacts.Salutation", true));
    ((UltraGridBase) this.cboSalutations).DataSource = (object) this.dsContacts.lstSalutations;
    ((UltraDropDownBase) this.cboSalutations).DisplayMember = "Salutation";
    this.cboSalutations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboSalutations).Location = new Point(72, 24);
    this.cboSalutations.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboSalutations).Name = "cboSalutations";
    ((Control) this.cboSalutations).Size = new Size(172, 21);
    ((Control) this.cboSalutations).TabIndex = 1;
    ((UltraControlBase) this.cboSalutations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboSalutations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboSalutations).ValueMember = "Salutation";
    this.cboStatus.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboStatus).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblInsuredContacts.StatusID", true));
    ((UltraGridBase) this.cboStatus).DataMember = "lstStatus";
    ((UltraGridBase) this.cboStatus).DataSource = (object) this.dsContacts;
    ((UltraDropDownBase) this.cboStatus).DisplayMember = "Status";
    this.cboStatus.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboStatus).Location = new Point(72, 280);
    this.cboStatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboStatus).Name = "cboStatus";
    ((Control) this.cboStatus).Size = new Size(172, 21);
    ((Control) this.cboStatus).TabIndex = 10;
    ((UltraControlBase) this.cboStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboStatus).ValueMember = "StatusID";
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTitle).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtTitle).BackColor = Color.White;
    ((Control) this.txtTitle).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblInsuredContacts.Title", true));
    ((Control) this.txtTitle).Location = new Point(72, 96 /*0x60*/);
    this.txtTitle.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtTitle).Name = "txtTitle";
    ((Control) this.txtTitle).Size = new Size(172, 20);
    ((Control) this.txtTitle).TabIndex = 7;
    ((UltraControlBase) this.txtTitle).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTitle).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(301, 220);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(25, 13);
    this.Label1.TabIndex = 16 /*0x10*/;
    this.Label1.Text = "Fax";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.umFax.Appearance = (AppearanceBase) appearance5;
    ((Control) this.umFax).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblInsuredContacts.Fax", true));
    this.umFax.EditAs = (EditAsType) 1;
    this.umFax.InputMask = "###-###-####";
    ((Control) this.umFax).Location = new Point(341, 216);
    this.umFax.MGAStyle = MGAStyles.Blue;
    ((Control) this.umFax).Name = "umFax";
    this.umFax.NonAutoSizeHeight = 20;
    ((Control) this.umFax).Size = new Size(131, 21);
    ((Control) this.umFax).TabIndex = 17;
    this.umFax.Text = "--";
    ((UltraControlBase) this.umFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.umFax).UseOsThemes = (DefaultableBoolean) 2;
    this.ctlZipCode.AddressServiceURL = "";
    this.ctlZipCode.AutoScrollMargin = new Size(0, 0);
    this.ctlZipCode.AutoScrollMinSize = new Size(0, 0);
    this.ctlZipCode.BackColor = Color.Transparent;
    this.ctlZipCode.City = "";
    this.ctlZipCode.County = "";
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("City", (object) this.dsContacts, "tblInsuredContacts.City", true));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("County", (object) this.dsContacts, "tblInsuredContacts.County", true));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("GeoRegion", (object) this.dsContacts, "tblInsuredContacts.Region", true));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("ISOCountryCode", (object) this.dsContacts, "tblInsuredContacts.ISOCountryCode", true));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("State", (object) this.dsContacts, "tblInsuredContacts.State", true));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("Street1", (object) this.dsContacts, "tblInsuredContacts.Address1", true));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("Street2", (object) this.dsContacts, "tblInsuredContacts.Address2", true));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("ZipCode", (object) this.dsContacts, "tblInsuredContacts.ZipCode", true));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("ZipCodeExtension", (object) this.dsContacts, "tblInsuredContacts.ZipPlus", true));
    this.ctlZipCode.GeoRegion = "";
    this.ctlZipCode.ISOCountryCode = "";
    this.ctlZipCode.ISOCountryCodeMember = "";
    this.ctlZipCode.ISOCountryList = (object) null;
    this.ctlZipCode.ISOCountryNameMember = "";
    ((Control) this.ctlZipCode).Location = new Point(9, 112 /*0x70*/);
    this.ctlZipCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.ctlZipCode).Name = "ctlZipCode";
    this.ctlZipCode.Password = "";
    this.ctlZipCode.ShowGlobal = true;
    ((Control) this.ctlZipCode).Size = new Size(232, 171);
    this.ctlZipCode.State = "";
    this.ctlZipCode.Street1 = "";
    this.ctlZipCode.Street2 = "";
    ((Control) this.ctlZipCode).TabIndex = 8;
    this.ctlZipCode.UserID = "";
    this.ctlZipCode.ZipCode = "";
    this.ctlZipCode.ZipCodeExtension = "";
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtCell.Appearance = (AppearanceBase) appearance6;
    ((Control) this.txtCell).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblInsuredContacts.Cell", true));
    this.txtCell.EditAs = (EditAsType) 1;
    this.txtCell.InputMask = "###-###-####";
    ((Control) this.txtCell).Location = new Point(341, 192 /*0xC0*/);
    this.txtCell.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCell).Name = "txtCell";
    this.txtCell.NonAutoSizeHeight = 20;
    ((Control) this.txtCell).Size = new Size(131, 21);
    ((Control) this.txtCell).TabIndex = 15;
    this.txtCell.Text = "--";
    ((UltraControlBase) this.txtCell).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCell).UseOsThemes = (DefaultableBoolean) 2;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtPhone.Appearance = (AppearanceBase) appearance7;
    ((Control) this.txtPhone).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblInsuredContacts.Phone", true));
    this.txtPhone.EditAs = (EditAsType) 1;
    this.txtPhone.InputMask = "###-###-####";
    ((Control) this.txtPhone).Location = new Point(341, 168);
    this.txtPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPhone).Name = "txtPhone";
    this.txtPhone.NonAutoSizeHeight = 20;
    ((Control) this.txtPhone).Size = new Size(83, 21);
    ((Control) this.txtPhone).TabIndex = 12;
    this.txtPhone.Text = "--";
    ((UltraControlBase) this.txtPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPhone).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(26, 284);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(38, 13);
    this.Label5.TabIndex = 9;
    this.Label5.Text = "Status";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    appearance8.BackColor = Color.FromArgb(248, 248, 248);
    appearance8.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance8.BackGradientStyle = (GradientStyle) 2;
    appearance8.BorderColor = Color.DarkGray;
    appearance8.ImageHAlign = (HAlign) 2;
    appearance8.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnInsSpecialContact).Appearance = (AppearanceBase) appearance8;
    ((Control) this.btnInsSpecialContact).Location = new Point(352, 26);
    ((Control) this.btnInsSpecialContact).Name = "btnInsSpecialContact";
    ((Control) this.btnInsSpecialContact).Size = new Size(24, 16 /*0x10*/);
    ((Control) this.btnInsSpecialContact).TabIndex = 23;
    ((ControlBase) this.btnInsSpecialContact).Text = "...";
    this.btnInsSpecialContact.UseOSThemes = (DefaultableBoolean) 2;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(256 /*0x0100*/, 26);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.Label2.TabIndex = 22;
    this.Label2.Text = "Special Contacts";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtExt).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.txtExt).BackColor = Color.White;
    ((Control) this.txtExt).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblInsuredContacts.Extension", true));
    ((Control) this.txtExt).Location = new Point(425, 168);
    this.txtExt.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtExt).Name = "txtExt";
    ((Control) this.txtExt).Size = new Size(47, 20);
    ((Control) this.txtExt).TabIndex = 13;
    ((UltraControlBase) this.txtExt).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtExt).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(279, 268);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(46, 13);
    this.Label7.TabIndex = 20;
    this.Label7.Text = "Delivery";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.cboDeliveryMethod.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboDeliveryMethod).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblInsuredContacts.DeliveryMethodID", true));
    ((UltraGridBase) this.cboDeliveryMethod).DataSource = (object) this.dsContacts.lstDeliveryMethod;
    ((UltraDropDownBase) this.cboDeliveryMethod).DisplayMember = "Description";
    this.cboDeliveryMethod.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDeliveryMethod).Location = new Point(341, 264);
    this.cboDeliveryMethod.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDeliveryMethod).Name = "cboDeliveryMethod";
    ((Control) this.cboDeliveryMethod).Size = new Size(131, 21);
    ((Control) this.cboDeliveryMethod).TabIndex = 21;
    ((UltraControlBase) this.cboDeliveryMethod).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDeliveryMethod).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDeliveryMethod).ValueMember = "DeliveryMethodID";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(7, 28);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(55, 13);
    this.Label4.TabIndex = 0;
    this.Label4.Text = "Salutation";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEmail).Appearance = (AppearanceBase) appearance10;
    ((TextEditorControlBase) this.txtEmail).BackColor = Color.White;
    ((Control) this.txtEmail).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblInsuredContacts.Email", true));
    ((Control) this.txtEmail).Location = new Point(341, 240 /*0xF0*/);
    this.txtEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEmail).Name = "txtEmail";
    ((Control) this.txtEmail).Size = new Size(131, 20);
    ((Control) this.txtEmail).TabIndex = 19;
    ((UltraControlBase) this.txtEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(292, 244);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(31 /*0x1F*/, 13);
    this.Label13.TabIndex = 18;
    this.Label13.Text = "Email";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(35, 100);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(27, 13);
    this.Label8.TabIndex = 6;
    this.Label8.Text = "Title";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLName).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.txtLName).BackColor = Color.White;
    ((Control) this.txtLName).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblInsuredContacts.LName", true));
    ((Control) this.txtLName).Location = new Point(72, 72);
    this.txtLName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLName).Name = "txtLName";
    ((Control) this.txtLName).Size = new Size(172, 20);
    ((Control) this.txtLName).TabIndex = 5;
    ((UltraControlBase) this.txtLName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLName).UseOsThemes = (DefaultableBoolean) 2;
    this.lblAddress1.AutoSize = true;
    this.lblAddress1.BackColor = Color.Transparent;
    this.lblAddress1.Location = new Point(35, 52);
    this.lblAddress1.Name = "lblAddress1";
    this.lblAddress1.Size = new Size(28, 13);
    this.lblAddress1.TabIndex = 2;
    this.lblAddress1.Text = "First";
    this.lblAddress1.TextAlign = ContentAlignment.MiddleRight;
    this.lblAddress2.AutoSize = true;
    this.lblAddress2.BackColor = Color.Transparent;
    this.lblAddress2.Location = new Point(36, 76);
    this.lblAddress2.Name = "lblAddress2";
    this.lblAddress2.Size = new Size(27, 13);
    this.lblAddress2.TabIndex = 4;
    this.lblAddress2.Text = "Last";
    this.lblAddress2.TextAlign = ContentAlignment.MiddleRight;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFName).Appearance = (AppearanceBase) appearance12;
    ((TextEditorControlBase) this.txtFName).BackColor = Color.White;
    ((Control) this.txtFName).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblInsuredContacts.FName", true));
    ((Control) this.txtFName).Location = new Point(72, 48 /*0x30*/);
    this.txtFName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFName).Name = "txtFName";
    ((Control) this.txtFName).Size = new Size(172, 20);
    ((Control) this.txtFName).TabIndex = 3;
    ((UltraControlBase) this.txtFName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFName).UseOsThemes = (DefaultableBoolean) 2;
    this.lblPhone.AutoSize = true;
    this.lblPhone.BackColor = Color.Transparent;
    this.lblPhone.Location = new Point(290, 172);
    this.lblPhone.Name = "lblPhone";
    this.lblPhone.Size = new Size(36, 13);
    this.lblPhone.TabIndex = 11;
    this.lblPhone.Text = "Office";
    this.lblPhone.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(267, 196);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(55, 13);
    this.Label3.TabIndex = 14;
    this.Label3.Text = "Home/Cell";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.lstSpecialContacts.CheckOnClick = true;
    this.lstSpecialContacts.DataSource = (object) this.dvlstSpecialContacts;
    this.lstSpecialContacts.DisplayMember = "SpecialContactType";
    this.lstSpecialContacts.Enabled = false;
    this.lstSpecialContacts.Font = new Font("Tahoma", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lstSpecialContacts.Location = new Point(433, 88);
    this.lstSpecialContacts.MGAStyle = MGAStyles.Blue;
    this.lstSpecialContacts.Name = "lstSpecialContacts";
    this.lstSpecialContacts.Size = new Size(216, 95);
    this.lstSpecialContacts.TabIndex = 24;
    this.lstSpecialContacts.ValueMember = "SpecialContactTypeID";
    this.dvlstSpecialContacts.RowFilter = "Hidden  = 0";
    this.dvlstSpecialContacts.Table = (DataTable) this.dsContacts.lstInsuredSpecialContactTypes;
    this.lstContacts.DataSource = (object) this.dvInsuredContacts;
    this.lstContacts.DisplayMember = "Name";
    this.lstContacts.Location = new Point(12, 29);
    this.lstContacts.MGAStyle = MGAStyles.Blue;
    this.lstContacts.Name = "lstContacts";
    this.lstContacts.Size = new Size(140, 223);
    this.lstContacts.TabIndex = 0;
    this.lstContacts.ValueMember = "InsuredContactGuid";
    this.dvInsuredContacts.Table = (DataTable) this.dsContacts.tblInsuredContacts;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance13).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblInsured).Appearance = (AppearanceBase) appearance13;
    ((Control) this.lblInsured).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblInsured).Location = new Point(13, 8);
    ((Control) this.lblInsured).Name = "lblInsured";
    ((Control) this.lblInsured).Size = new Size(648, 24);
    ((Control) this.lblInsured).TabIndex = 0;
    ((ControlBase) this.lblInsured).Text = "insured name goes here";
    appearance14.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    this.grpContacts.ContentAreaAppearance = (AppearanceBase) appearance14;
    ((Control) this.grpContacts).Controls.Add((Control) this.GroupBox3);
    ((Control) this.grpContacts).Controls.Add((Control) this.lstContacts);
    appearance15.ForeColor = Color.FromArgb(21, 66, 139);
    this.grpContacts.HeaderAppearance = (AppearanceBase) appearance15;
    ((Control) this.grpContacts).Location = new Point(13, 40);
    ((Control) this.grpContacts).Name = "grpContacts";
    ((Control) this.grpContacts).Size = new Size(160 /*0xA0*/, 317);
    ((Control) this.grpContacts).TabIndex = 1;
    this.grpContacts.Text = "Contacts";
    this.grpContacts.ViewStyle = (GroupBoxViewStyle) 2;
    appearance16.BackColor = Color.Transparent;
    this.GroupBox3.Appearance = (AppearanceBase) appearance16;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.GroupBox3.ContentAreaAppearance = (AppearanceBase) appearance17;
    ((Control) this.GroupBox3).Controls.Add((Control) this.chkFilterActive);
    ((Control) this.GroupBox3).Controls.Add((Control) this.chkFilterInActive);
    ((Control) this.GroupBox3).Location = new Point(8, 262);
    ((Control) this.GroupBox3).Name = "GroupBox3";
    ((Control) this.GroupBox3).Size = new Size(147, 47);
    ((Control) this.GroupBox3).TabIndex = 1;
    this.GroupBox3.Text = "Filter by";
    appearance18.BackColor = Color.Transparent;
    appearance18.BorderColor = Color.Gray;
    appearance18.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFilterActive).Appearance = (AppearanceBase) appearance18;
    ((UltraToggleEditorBase) this.chkFilterActive).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFilterActive).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFilterActive).Checked = true;
    ((UltraToggleEditorBase) this.chkFilterActive).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkFilterActive).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFilterActive).Location = new Point(14, 21);
    ((Control) this.chkFilterActive).Name = "chkFilterActive";
    ((Control) this.chkFilterActive).Size = new Size(58, 14);
    ((Control) this.chkFilterActive).TabIndex = 0;
    ((UltraToggleEditorBase) this.chkFilterActive).Text = "Active";
    ((UltraControlBase) this.chkFilterActive).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFilterActive).UseOsThemes = (DefaultableBoolean) 2;
    appearance19.BackColor = Color.Transparent;
    appearance19.BorderColor = Color.Gray;
    appearance19.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFilterInActive).Appearance = (AppearanceBase) appearance19;
    ((UltraToggleEditorBase) this.chkFilterInActive).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFilterInActive).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFilterInActive).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFilterInActive).Location = new Point(80 /*0x50*/, 21);
    ((Control) this.chkFilterInActive).Name = "chkFilterInActive";
    ((Control) this.chkFilterInActive).Size = new Size(64 /*0x40*/, 14);
    ((Control) this.chkFilterInActive).TabIndex = 1;
    ((UltraToggleEditorBase) this.chkFilterInActive).Text = "Inactive";
    ((UltraControlBase) this.chkFilterInActive).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFilterInActive).UseOsThemes = (DefaultableBoolean) 2;
    this.cnSQL.ConnectionString = "workstation id=PSARNOWSKI2;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.daContacts.DeleteCommand = this.SqlDeleteCommand2;
    this.daContacts.InsertCommand = this.SqlInsertCommand2;
    this.daContacts.SelectCommand = this.SqlSelectCommand1;
    this.daContacts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblInsuredContacts", new DataColumnMapping[23]
      {
        new DataColumnMapping("InsuredContactGUID", "InsuredContactGUID"),
        new DataColumnMapping("InsuredLocationGUID", "InsuredLocationGUID"),
        new DataColumnMapping("DeliveryMethodID", "DeliveryMethodID"),
        new DataColumnMapping("FName", "FName"),
        new DataColumnMapping("LName", "LName"),
        new DataColumnMapping("Title", "Title"),
        new DataColumnMapping("Phone", "Phone"),
        new DataColumnMapping("Extension", "Extension"),
        new DataColumnMapping("Cell", "Cell"),
        new DataColumnMapping("Email", "Email"),
        new DataColumnMapping("Salutation", "Salutation"),
        new DataColumnMapping("RmNumber", "RmNumber"),
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("Fax", "Fax"),
        new DataColumnMapping("Region", "Region"),
        new DataColumnMapping("ISOCountryCode", "ISOCountryCode")
      })
    });
    this.daContacts.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = componentResourceManager.GetString("SqlDeleteCommand2.CommandText");
    this.SqlDeleteCommand2.Connection = this.cnSQL;
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[23]
    {
      new SqlParameter("@Original_InsuredContactGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InsuredContactGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Address1", SqlDbType.VarChar, 250, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Address2", SqlDbType.VarChar, 250, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address2", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Cell", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Cell", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_City", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "City", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_County", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "County", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_DeliveryMethodID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DeliveryMethodID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Email", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Email", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Extension", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Extension", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_FName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Fax", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ISOCountryCode", SqlDbType.VarChar, 3, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ISOCountryCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_InsuredLocationGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InsuredLocationGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_LName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Phone", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Region", SqlDbType.VarChar, 100, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_RmNumber", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RmNumber", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Salutation", SqlDbType.VarChar, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Salutation", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_State", SqlDbType.VarChar, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "State", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_StatusID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StatusID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Title", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Title", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ZipCode", SqlDbType.VarChar, 5, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ZipPlus", SqlDbType.VarChar, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipPlus", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = componentResourceManager.GetString("SqlInsertCommand2.CommandText");
    this.SqlInsertCommand2.Connection = this.cnSQL;
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[24]
    {
      new SqlParameter("@InsuredContactGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InsuredContactGUID"),
      new SqlParameter("@InsuredLocationGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InsuredLocationGUID"),
      new SqlParameter("@DeliveryMethodID", SqlDbType.TinyInt, 1, "DeliveryMethodID"),
      new SqlParameter("@FName", SqlDbType.VarChar, 50, "FName"),
      new SqlParameter("@LName", SqlDbType.VarChar, 50, "LName"),
      new SqlParameter("@Title", SqlDbType.VarChar, 50, "Title"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 50, "Phone"),
      new SqlParameter("@Extension", SqlDbType.VarChar, 50, "Extension"),
      new SqlParameter("@Cell", SqlDbType.VarChar, 50, "Cell"),
      new SqlParameter("@Email", SqlDbType.VarChar, 50, "Email"),
      new SqlParameter("@Salutation", SqlDbType.VarChar, 4, "Salutation"),
      new SqlParameter("@RmNumber", SqlDbType.VarChar, 50, "RmNumber"),
      new SqlParameter("@StatusID", SqlDbType.TinyInt, 1, "StatusID"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 250, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 250, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 50, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 50, "County"),
      new SqlParameter("@State", SqlDbType.VarChar, 2, "State"),
      new SqlParameter("@ZipCode", SqlDbType.VarChar, 5, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 4, "ZipPlus"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 50, "Fax"),
      new SqlParameter("@Region", SqlDbType.VarChar, 100, "Region"),
      new SqlParameter("@ISOCountryCode", SqlDbType.VarChar, 3, "ISOCountryCode"),
      new SqlParameter("@OptOut", SqlDbType.Bit, 0, "OptOut")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@InsuredLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InsuredLocationGUID")
    });
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Connection = this.cnSQL;
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[47]
    {
      new SqlParameter("@InsuredContactGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InsuredContactGUID"),
      new SqlParameter("@InsuredLocationGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InsuredLocationGUID"),
      new SqlParameter("@DeliveryMethodID", SqlDbType.TinyInt, 1, "DeliveryMethodID"),
      new SqlParameter("@FName", SqlDbType.VarChar, 50, "FName"),
      new SqlParameter("@LName", SqlDbType.VarChar, 50, "LName"),
      new SqlParameter("@Title", SqlDbType.VarChar, 50, "Title"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 50, "Phone"),
      new SqlParameter("@Extension", SqlDbType.VarChar, 50, "Extension"),
      new SqlParameter("@Cell", SqlDbType.VarChar, 50, "Cell"),
      new SqlParameter("@Email", SqlDbType.VarChar, 50, "Email"),
      new SqlParameter("@Salutation", SqlDbType.VarChar, 4, "Salutation"),
      new SqlParameter("@RmNumber", SqlDbType.VarChar, 50, "RmNumber"),
      new SqlParameter("@StatusID", SqlDbType.TinyInt, 1, "StatusID"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 250, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 250, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 50, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 50, "County"),
      new SqlParameter("@State", SqlDbType.VarChar, 2, "State"),
      new SqlParameter("@ZipCode", SqlDbType.VarChar, 5, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 4, "ZipPlus"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 50, "Fax"),
      new SqlParameter("@Region", SqlDbType.VarChar, 100, "Region"),
      new SqlParameter("@ISOCountryCode", SqlDbType.VarChar, 3, "ISOCountryCode"),
      new SqlParameter("@Original_InsuredContactGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InsuredContactGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Address1", SqlDbType.VarChar, 250, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Address2", SqlDbType.VarChar, 250, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address2", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Cell", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Cell", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_City", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "City", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_County", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "County", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_DeliveryMethodID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DeliveryMethodID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Email", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Email", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Extension", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Extension", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_FName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Fax", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ISOCountryCode", SqlDbType.VarChar, 3, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ISOCountryCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_InsuredLocationGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InsuredLocationGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_LName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Phone", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Region", SqlDbType.VarChar, 100, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_RmNumber", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RmNumber", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Salutation", SqlDbType.VarChar, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Salutation", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_State", SqlDbType.VarChar, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "State", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_StatusID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StatusID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Title", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Title", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ZipCode", SqlDbType.VarChar, 5, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ZipPlus", SqlDbType.VarChar, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipPlus", DataRowVersion.Original, (object) null),
      new SqlParameter("@OptOut", SqlDbType.Bit, 0, "OptOut")
    });
    this.daSpecialContacts.DeleteCommand = this.SqlDeleteCommand1;
    this.daSpecialContacts.InsertCommand = this.SqlInsertCommand1;
    this.daSpecialContacts.SelectCommand = this.SqlSelectCommand5;
    this.daSpecialContacts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblInsuredSpecialContacts", new DataColumnMapping[2]
      {
        new DataColumnMapping("InsuredContactGuid", "InsuredContactGuid"),
        new DataColumnMapping("SpecialContactTypeID", "SpecialContactTypeID")
      })
    });
    this.daSpecialContacts.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblInsuredSpecialContacts WHERE (SpecialContactTypeID = @Original_SpecialContactTypeID) AND (InsuredContactGuid = @Original_InsuredContactGuid)";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_SpecialContactTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SpecialContactTypeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_InsuredContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InsuredContactGuid", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = "INSERT INTO tblInsuredSpecialContacts(InsuredContactGuid, SpecialContactTypeID) VALUES (@InsuredContactGuid, @SpecialContactTypeID)";
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@InsuredContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InsuredContactGuid"),
      new SqlParameter("@SpecialContactTypeID", SqlDbType.Int, 4, "SpecialContactTypeID")
    });
    this.SqlSelectCommand5.CommandText = "SELECT InsuredContactGuid, SpecialContactTypeID FROM tblInsuredSpecialContacts WHERE (InsuredContactGuid = @InsuredContactGuid)";
    this.SqlSelectCommand5.Connection = this.cnSQL;
    this.SqlSelectCommand5.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@InsuredContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InsuredContactGuid")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@InsuredContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InsuredContactGuid"),
      new SqlParameter("@SpecialContactTypeID", SqlDbType.Int, 4, "SpecialContactTypeID"),
      new SqlParameter("@Original_SpecialContactTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SpecialContactTypeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_InsuredContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InsuredContactGuid", DataRowVersion.Original, (object) null)
    });
    this.daSpecialContactsList.SelectCommand = this.SqlSelectCommand6;
    this.daSpecialContactsList.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstInsuredSpecialContactTypes", new DataColumnMapping[3]
      {
        new DataColumnMapping("SpecialContactTypeID", "SpecialContactTypeID"),
        new DataColumnMapping("SpecialContactType", "SpecialContactType"),
        new DataColumnMapping("Hidden", "Hidden")
      })
    });
    this.SqlSelectCommand6.CommandText = "SELECT SpecialContactTypeID, SpecialContactType, Hidden FROM lstInsuredSpecialContactTypes ORDER BY SpecialContactType";
    this.SqlSelectCommand6.Connection = this.cnSQL;
    this.daStatus.SelectCommand = this.SqlSelectCommand7;
    this.daStatus.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstStatus", new DataColumnMapping[2]
      {
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("Status", "Status")
      })
    });
    this.SqlSelectCommand7.CommandText = "SELECT StatusID, Status FROM lstStatus";
    this.SqlSelectCommand7.Connection = this.cnSQL;
    this.ErrProvider.ContainerControl = (ContainerControl) this;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(536, 368);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 4;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
    this.lnkAuthorize.Cursor = Cursors.Hand;
    this.lnkAuthorize.Location = new Point(320, 376);
    this.lnkAuthorize.Name = "lnkAuthorize";
    this.lnkAuthorize.Size = new Size(203, 23);
    this.lnkAuthorize.TabIndex = 3;
    this.lnkAuthorize.TabStop = true;
    this.lnkAuthorize.Text = "Authorize Contact for External Access";
    this.lnkAuthorize.TextAlign = ContentAlignment.MiddleCenter;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(674, 416);
    this.Controls.Add((Control) this.lnkAuthorize);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.lstSpecialContacts);
    this.Controls.Add((Control) this.grpContactInfo);
    this.Controls.Add((Control) this.grpContacts);
    this.Controls.Add((Control) this.lblInsured);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.Name = nameof (frmInsuredContacts);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Insured Contacts";
    ((ISupportInitialize) this.grpContactInfo).EndInit();
    ((Control) this.grpContactInfo).ResumeLayout(false);
    ((Control) this.grpContactInfo).PerformLayout();
    ((ISupportInitialize) this.chkOptOut).EndInit();
    this.dsContacts.EndInit();
    ((ISupportInitialize) this.cboSalutations).EndInit();
    ((ISupportInitialize) this.cboStatus).EndInit();
    ((ISupportInitialize) this.txtTitle).EndInit();
    ((ISupportInitialize) this.umFax).EndInit();
    ((ISupportInitialize) this.txtCell).EndInit();
    ((ISupportInitialize) this.txtPhone).EndInit();
    ((ISupportInitialize) this.btnInsSpecialContact).EndInit();
    ((ISupportInitialize) this.txtExt).EndInit();
    ((ISupportInitialize) this.cboDeliveryMethod).EndInit();
    ((ISupportInitialize) this.txtEmail).EndInit();
    ((ISupportInitialize) this.txtLName).EndInit();
    ((ISupportInitialize) this.txtFName).EndInit();
    ((ISupportInitialize) this.lstSpecialContacts).EndInit();
    this.dvlstSpecialContacts.EndInit();
    ((ISupportInitialize) this.lstContacts).EndInit();
    this.dvInsuredContacts.EndInit();
    ((ISupportInitialize) this.grpContacts).EndInit();
    ((Control) this.grpContacts).ResumeLayout(false);
    ((ISupportInitialize) this.GroupBox3).EndInit();
    ((Control) this.GroupBox3).ResumeLayout(false);
    ((ISupportInitialize) this.chkFilterActive).EndInit();
    ((ISupportInitialize) this.chkFilterInActive).EndInit();
    ((ISupportInitialize) this.ErrProvider).EndInit();
    this.ResumeLayout(false);
  }

  public frmInsuredContacts(Guid insuredLocationGuid)
  {
    this.Load += new EventHandler(this.frmInsured_Load);
    this.Closing += new CancelEventHandler(this.frmInsuredContacts_Closing);
    this._insuredContactGuid = Guid.Empty;
    this._specialContactTypeID = int.MinValue;
    this.InitializeComponent();
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._insuredLocationGuid = insuredLocationGuid;
    this._insuredGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT InsuredGuid FROM tblInsuredLocations WHERE InsuredLocationGuid=@ILG", new object[2]
    {
      (object) "@ILG",
      (object) insuredLocationGuid
    });
  }

  public frmInsuredContacts(Guid insuredLocationGuid, Guid insuredContactGuid)
    : this(insuredLocationGuid)
  {
    this._insuredContactGuid = insuredContactGuid;
  }

  private bool DefaultInspectionType
  {
    get
    {
      bool defaultInspectionType;
      if (MGASystems.Common.SystemSettings.KeyExists("DefaultInsuredSpecialContactType"))
      {
        this._specialContactTypeID = Convert.ToInt32(MGASystems.Common.SystemSettings.GetNumericSetting("DefaultInsuredSpecialContactType"));
        defaultInspectionType = DefaultDatabase.ExecuteScalar<bool>("HasSpecialContactType", new object[4]
        {
          (object) "@InsuredLocationGuid",
          (object) this._insuredLocationGuid,
          (object) "@SpecialContactTypeID",
          (object) this._specialContactTypeID
        });
      }
      else
        defaultInspectionType = false;
      return defaultInspectionType;
    }
  }

  private void frmInsured_Load(object sender, EventArgs e)
  {
    try
    {
      this.bmb = this.BindingContext[(object) this.dsContacts, this.dsContacts.tblInsuredContacts.TableName];
      ((Control) this.chkOptOut).Visible = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("ShowInsuredOptOut", false);
      this.lstSpecialContacts.SelectionMode = SelectionMode.One;
      this._hasSpecialContactType = this.DefaultInspectionType;
      this.PopulateDataSet();
      this.FillContacts();
      this.LoadSpecialContacts(this._insuredContactGuid);
      if (!this._insuredContactGuid.Equals(Guid.Empty))
      {
        this.lstContacts.SelectedValue = (object) this._insuredContactGuid;
        this.lstSpecialContacts.Enabled = true;
        this.lstSpecialContacts.SelectionMode = SelectionMode.None;
      }
      this.FillSpecialContactsListbox();
      this.lstContacts.MouseUp += new MouseEventHandler(this.SelectContact);
      this.lstContacts.KeyUp += new KeyEventHandler(this.SelectContact);
      if (!this._insuredContactGuid.Equals(Guid.Empty))
        return;
      this._isNew = true;
      this.dvInsuredContacts.RowFilter = "StatusID = 1 OR StatusID = 2";
      ((UltraToggleEditorBase) this.chkFilterInActive).CheckedChanged -= new EventHandler(this.chkFilterInActive_CheckedChanged);
      ((UltraToggleEditorBase) this.chkFilterInActive).Checked = true;
      ((UltraToggleEditorBase) this.chkFilterInActive).CheckedChanged += new EventHandler(this.chkFilterInActive_CheckedChanged);
      this.dbSave_ClickingNew(RuntimeHelpers.GetObjectValue(sender), (CancelEventArgs) null);
      this.dbSave.UIState = UIState.Editing;
      this.dbSave_UIStateChanged((object) null, (EventArgs) null);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void lnkAuthorize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.dsContacts.tblInsuredContacts[this.bmb.Position].RowState == DataRowState.Added)
    {
      int num = (int) MessageBox.Show("Please save this contact before configuring them for external access.", "Save Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      using (FormSettings.ShowFormDialog(typeof (frmAuthorizeContact), (object) this.dsContacts.tblInsuredContacts[this.bmb.Position].InsuredContactGuid))
        ;
    }
  }

  private void PopulateDataSet()
  {
    ((ControlBase) this.lblInsured).Text = new InsuredLocation(this._insuredLocationGuid).Insured.Name;
    DefaultDatabase.LoadDataSet((DataSet) this.dsContacts, new string[1]
    {
      "lstSalutations"
    }, CommandType.Text, "SELECT Salutation FROM lstSalutations ORDER BY Salutation");
    DefaultDatabase.LoadDataSet((DataSet) this.dsContacts, new string[1]
    {
      "lstDeliveryMethod"
    }, CommandType.Text, "SELECT DeliveryMethodID, Description FROM dbo.lstDeliveryMethod ORDER BY Description");
    DefaultDatabase.LoadDataSet((DataSet) this.dsContacts, new string[1]
    {
      "lstStatus"
    }, CommandType.Text, "SELECT StatusID, Status FROM lstStatus ORDER BY Status");
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSpecialContactsList, (DataTable) this.dsContacts.lstInsuredSpecialContactTypes);
    if (this.dsContacts.tblInsuredContacts.Rows.Count <= 0)
      return;
    this.daSpecialContacts.SelectCommand.Parameters["@InsuredContactGuid"].Value = (object) this.dsContacts.tblInsuredContacts[0].InsuredContactGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblInsuredSpecialContacts);
  }

  protected virtual void FillContacts()
  {
    // ISSUE: reference to a compiler-generated field
    this._bmb.PositionChanged -= new EventHandler(this.bmb_PositionChanged);
    this.daContacts.SelectCommand.Parameters["@InsuredLocationGuid"].Value = (object) this._insuredLocationGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblInsuredContacts);
    // ISSUE: reference to a compiler-generated field
    this._bmb.PositionChanged += new EventHandler(this.bmb_PositionChanged);
  }

  private void ClearSpecialContacts()
  {
    this.dsContacts.tblInsuredSpecialContacts.Clear();
    this.dsContacts.tblInsuredSpecialContacts.Clear();
    this.lstSpecialContacts.ItemCheck -= new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
    int num = this.lstSpecialContacts.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
      this.lstSpecialContacts.SetItemChecked(index, false);
    this.lstSpecialContacts.ItemCheck += new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
  }

  private void LoadSpecialContacts(Guid ContactGuid)
  {
    this.dsContacts.tblInsuredSpecialContacts.Clear();
    this.daSpecialContacts.SelectCommand.Parameters["@InsuredContactGuid"].Value = (object) ContactGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblInsuredSpecialContacts);
    this.FillSpecialContactsListbox();
  }

  private void lstSpecialContacts_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    int specialContactTypeId = ((dsInsuredContacts.lstInsuredSpecialContactTypesRow) ((DataRowView) this.lstSpecialContacts.Items[this.lstSpecialContacts.SelectedIndex]).Row).SpecialContactTypeID;
    Guid insuredContactGuid = this.dsContacts.tblInsuredContacts[this.bmb.Position].InsuredContactGuid;
    if (e.CurrentValue == CheckState.Unchecked)
    {
      dsInsuredContacts.tblInsuredSpecialContactsRow row = this.dsContacts.tblInsuredSpecialContacts.NewtblInsuredSpecialContactsRow();
      row.InsuredContactGuid = insuredContactGuid;
      row.SpecialContactTypeID = specialContactTypeId;
      this.dsContacts.tblInsuredSpecialContacts.AddtblInsuredSpecialContactsRow(row);
    }
    else
      this.dsContacts.tblInsuredSpecialContacts.FindByInsuredContactGuidSpecialContactTypeID(insuredContactGuid, specialContactTypeId).Delete();
    Cursor.Current = MgaCursors.Default;
  }

  internal void RefillSpecialContactsListTable()
  {
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSpecialContactsList, (DataTable) this.dsContacts.lstInsuredSpecialContactTypes);
    this.FillSpecialContactsListbox();
  }

  private void FillSpecialContactsListbox()
  {
    this.lstSpecialContacts.ItemCheck -= new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
    int num1 = this.lstSpecialContacts.Items.Count - 1;
    for (int index = 0; index <= num1; ++index)
      this.lstSpecialContacts.SetItemChecked(index, false);
    if (this.lstContacts.Items.Count > 0)
    {
      this.dsContacts.tblInsuredSpecialContacts.Clear();
      this.daSpecialContacts.SelectCommand.Parameters["@InsuredContactGuid"].Value = RuntimeHelpers.GetObjectValue(this.lstContacts.SelectedValue);
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblInsuredSpecialContacts);
    }
    try
    {
      foreach (dsInsuredContacts.tblInsuredSpecialContactsRow insuredSpecialContact in (TypedTableBase<dsInsuredContacts.tblInsuredSpecialContactsRow>) this.dsContacts.tblInsuredSpecialContacts)
      {
        int num2 = this.lstSpecialContacts.Items.Count - 1;
        for (int index = 0; index <= num2; ++index)
        {
          int specialContactTypeId = ((dsInsuredContacts.lstInsuredSpecialContactTypesRow) ((DataRowView) this.lstSpecialContacts.Items[index]).Row).SpecialContactTypeID;
          if (insuredSpecialContact.SpecialContactTypeID == specialContactTypeId)
            this.lstSpecialContacts.SetItemChecked(index, true);
        }
      }
    }
    finally
    {
      IEnumerator<dsInsuredContacts.tblInsuredSpecialContactsRow> enumerator;
      enumerator?.Dispose();
    }
    this.lstSpecialContacts.ItemCheck += new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
  }

  private void SelectContact()
  {
    if (!this._isNew)
    {
      if (this.lstContacts.SelectedIndex <= -1)
        return;
      int num = this.dsContacts.tblInsuredContacts.Count - 1;
      for (int index = 0; index <= num; ++index)
      {
        if (this.dsContacts.tblInsuredContacts[index].InsuredContactGuid.Equals(RuntimeHelpers.GetObjectValue(this.lstContacts.SelectedValue)))
        {
          this.bmb.Position = index;
          break;
        }
      }
      this.FillSpecialContactsListbox();
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
      this.bmb.ResumeBinding();
    }
    else
    {
      this._isNew = false;
      this.ClearSpecialContacts();
    }
  }

  private void SelectContact(object sender, KeyEventArgs e) => this.SelectContact();

  private void SelectContact(object sender, MouseEventArgs e) => this.SelectContact();

  private void frmInsuredContacts_Closing(object sender, CancelEventArgs e)
  {
    this.lstContacts.MouseUp -= new MouseEventHandler(this.SelectContact);
    this.lstContacts.KeyUp -= new KeyEventHandler(this.SelectContact);
  }

  private void btnInsSpecialContact_Click(object sender, EventArgs e)
  {
    using (FormSettings.ShowFormDialog(typeof (frmAdminInsuredSpecialContacts), (object) new EventHandler(this.frmAdminInsuredSpecialContacts_Closing)))
      ;
  }

  private void frmAdminInsuredSpecialContacts_Closing(object sender, EventArgs e)
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
    this.dvInsuredContacts.RowFilter = !((UltraToggleEditorBase) this.chkFilterActive).Checked || !((UltraToggleEditorBase) this.chkFilterInActive).Checked ? (!((UltraToggleEditorBase) this.chkFilterActive).Checked ? (!((UltraToggleEditorBase) this.chkFilterInActive).Checked ? "StatusID = 1 AND StatusID = 2" : "StatusID = 2") : "StatusID = 1") : "StatusID = 1 OR StatusID = 2";
    if (this.dvInsuredContacts.Count > 0)
    {
      this.bmb.ResumeBinding();
      this.SelectContact();
    }
    else
    {
      if (this.bmb != null)
      {
        this.bmb.SuspendBinding();
        this.ClearSpecialContacts();
      }
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    }
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.grpContactInfo).Enabled = this.dbSave.UIState == UIState.Editing;
    if (this.dbSave.UIState == UIState.Editing)
      this.lstSpecialContacts.SelectionMode = SelectionMode.One;
    else
      this.lstSpecialContacts.SelectionMode = SelectionMode.None;
  }

  protected virtual bool IsValidLastName()
  {
    return ((TextEditorControlBase) this.txtLName).Text.Replace(" ", string.Empty).Length != 0;
  }

  protected virtual bool ValidForm()
  {
    bool flag = true;
    this.ErrProvider.SetError((Control) this.txtFName, string.Empty);
    this.ErrProvider.SetError((Control) this.txtLName, string.Empty);
    this.ErrProvider.SetError((Control) this.cboDeliveryMethod, string.Empty);
    this.ErrProvider.SetError((Control) this.cboStatus, string.Empty);
    if (((TextEditorControlBase) this.txtFName).Text.Replace(" ", string.Empty).Length == 0)
    {
      this.ErrProvider.SetError((Control) this.txtFName, "Must enter first name to continue");
      flag = false;
    }
    if (!this.IsValidLastName())
    {
      this.ErrProvider.SetError((Control) this.txtLName, "Must enter last name to continue");
      flag = false;
    }
    if (this.cboDeliveryMethod.Text.Length == 0)
    {
      this.ErrProvider.SetError((Control) this.cboDeliveryMethod, "Must enter delivery method to continue");
      flag = false;
    }
    if (this.cboStatus.Text.Length == 0)
    {
      this.ErrProvider.SetError((Control) this.cboStatus, "Must enter status to continue");
      flag = false;
    }
    this.ErrProvider.SetError((Control) this.umFax, string.Empty);
    this.ErrProvider.SetError((Control) this.txtEmail, string.Empty);
    this.ErrProvider.SetError((Control) this.ctlZipCode, string.Empty);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboDeliveryMethod.Text, string.Empty, false) == 0)
    {
      this.ErrProvider.SetError((Control) this.cboDeliveryMethod, "Please enter a delivery method.");
      flag = false;
    }
    else if (Conversions.ToInteger(this.cboDeliveryMethod.Value) == 3 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtEmail).Text, string.Empty, false) == 0)
    {
      this.ErrProvider.SetError((Control) this.txtEmail, "Email must be provided when selecting email delivery type.");
      flag = false;
    }
    else if (Conversions.ToInteger(this.cboDeliveryMethod.Value) == 2 && this.umFax.Value == DBNull.Value | this.umFax.Value == (object) string.Empty)
    {
      this.ErrProvider.SetError((Control) this.umFax, "Fax must be provided when selecting fax delivery type.");
      flag = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtEmail).Text, string.Empty, false) != 0 && !Parsing.IsValidEmailAddress(((TextEditorControlBase) this.txtEmail).Text))
    {
      this.ErrProvider.SetError((Control) this.txtEmail, "Please enter a valid email address.");
      flag = false;
    }
    if (flag && this.dsContacts.tblInsuredContacts[this.bmb.Position].IsStatusIDNull())
    {
      this.bmb.EndCurrentEdit();
      this.dsContacts.tblInsuredContacts[this.bmb.Position].StatusID = Conversions.ToInteger(this.cboStatus.Value);
      this.bmb.ResumeBinding();
    }
    return flag;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    string rowFilter = this.dvInsuredContacts.RowFilter;
    this.dvInsuredContacts.RowFilter = "StatusID = 1 OR StatusID = 2";
    if (!this.ValidForm())
    {
      e.Cancel = true;
    }
    else
    {
      try
      {
        this.bmb.EndCurrentEdit();
        if (this.dsContacts.tblInsuredContacts[this.bmb.Position].RowState == DataRowState.Added || this.dsContacts.tblInsuredContacts[this.bmb.Position].IsNameNull())
          this.dsContacts.tblInsuredContacts[this.bmb.Position].Name = $"{((TextEditorControlBase) this.txtLName).Text}, {((TextEditorControlBase) this.txtFName).Text}";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dsContacts.tblInsuredContacts[this.bmb.Position].Name, $"{((TextEditorControlBase) this.txtLName).Text}, {((TextEditorControlBase) this.txtFName).Text}", false) != 0)
          this.dsContacts.tblInsuredContacts[this.bmb.Position].Name = $"{((TextEditorControlBase) this.txtLName).Text}, {((TextEditorControlBase) this.txtFName).Text}";
        if (this.dsContacts.tblInsuredContacts[this.bmb.Position].IsStatusIDNull())
          this.dsContacts.tblInsuredContacts[this.bmb.Position].StatusID = (int) this.cboStatus.Value;
        if (this.dsContacts.HasChanges())
        {
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblInsuredContacts);
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblInsuredSpecialContacts);
          this.UpdateOpenForms();
        }
        MDIControls.Instance.StatusBarText = "Insured contact information saved.";
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleError((Exception) ex);
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.dvInsuredContacts.RowFilter = rowFilter;
      }
    }
  }

  private void UpdateOpenForms()
  {
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      Form form = mdiChildren[index];
      if (form is frmInsureds && ((frmInsureds) form).InsuredGuid.Equals(this._insuredGuid))
        ((frmInsureds) form).LoadContacts();
      checked { ++index; }
    }
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    dsInsuredContacts.tblInsuredContactsRow insuredContactsRow = this.dsContacts.tblInsuredContacts.NewtblInsuredContactsRow();
    this._insuredContactGuid = Guid.NewGuid();
    insuredContactsRow.InsuredContactGuid = this._insuredContactGuid;
    insuredContactsRow.InsuredLocationGuid = this._insuredLocationGuid;
    this.DefaultNewInsuredContacts(insuredContactsRow);
    this.dsContacts.tblInsuredContacts.AddtblInsuredContactsRow(insuredContactsRow);
    this.bmb.Position = this.bmb.Count - 1;
    this.DefaultDeliveryMethod();
    this.ClearSpecialContacts();
    this.DefaultInsuredSpecialContact();
    this.lstSpecialContacts.Enabled = true;
    this.lstSpecialContacts.SelectionMode = SelectionMode.One;
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
      return;
    this.dsContacts.tblInsuredSpecialContacts.RejectChanges();
    this.dsContacts.tblInsuredContacts[this.bmb.Position].RejectChanges();
    this.ClearErrorProviders();
    this.bmb.Position = 0;
  }

  private void ClearErrorProviders()
  {
    try
    {
      foreach (Control control in ((Control) this.grpContactInfo).Controls)
        this.ErrProvider.SetError(control, string.Empty);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void dbSave_QueryRowCount(object sender, QueryRowCountEventArgs e)
  {
    e.RowCount = this.dsContacts.tblInsuredContacts.Rows.Count;
  }

  private void bmb_PositionChanged(object sender, EventArgs e)
  {
    if (this.lstContacts.SelectedValue == null)
      return;
    this.LoadSpecialContacts((Guid) this.lstContacts.SelectedValue);
    this.FillSpecialContactsListbox();
  }

  private void lstContacts_VisibleChanged(object sender, EventArgs e)
  {
    if (this.bmb == null)
      return;
    if (this.lstContacts.Items.Count == 0)
    {
      this.bmb.Position = -1;
    }
    else
    {
      this.FillSpecialContactsListbox();
      this.SelectContact();
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete this contact?", "Delete Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
    {
      int num = this.dsContacts.tblInsuredSpecialContacts.Rows.Count - 1;
      for (int index = 0; index <= num; ++index)
      {
        if (this.dsContacts.tblInsuredSpecialContacts[index].InsuredContactGuid.Equals(RuntimeHelpers.GetObjectValue(this.lstContacts.SelectedValue)))
          this.dsContacts.tblInsuredSpecialContacts[index].Delete();
      }
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblInsuredSpecialContacts);
      this.dsContacts.tblInsuredContacts[this.bmb.Position].Delete();
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblInsuredContacts);
      this.UpdateOpenForms();
      this.ClearSpecialContacts();
    }
    else
      e.Cancel = true;
  }

  protected virtual void DefaultNewInsuredContacts(dsInsuredContacts.tblInsuredContactsRow dr)
  {
  }

  protected virtual void DefaultDeliveryMethod()
  {
    ((UltraDropDownBase) this.cboDeliveryMethod).SelectedRow = (UltraGridRow) null;
  }

  private void DefaultInsuredSpecialContact()
  {
    if (this._hasSpecialContactType || this._specialContactTypeID == int.MinValue)
      return;
    int num = this.lstSpecialContacts.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (this._specialContactTypeID == ((dsInsuredContacts.lstInsuredSpecialContactTypesRow) ((DataRowView) this.lstSpecialContacts.Items[index]).Row).SpecialContactTypeID)
      {
        this.lstSpecialContacts.SelectedItem = RuntimeHelpers.GetObjectValue(this.lstSpecialContacts.Items[index]);
        this.lstSpecialContacts.SetItemChecked(index, true);
        break;
      }
    }
    this._hasSpecialContactType = true;
  }

  private enum ScreenMode
  {
    NewMode,
    EditMode,
    Locked,
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.Intermediaries.frmIntermediaryContacts
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using MGASystems.BusinessObjects;
using MGASystems.Common;
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies.Intermediaries;

public sealed class frmIntermediaryContacts : Form
{
  private readonly int _intermediaryID;
  private Guid _intermediaryContactGuid;
  private bool _newContactOnLoad;
  private SqlConnection _cn;
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
  protected UltraGroupBox grpContacts;
  protected ToolTip ToolTip;
  protected SqlDataAdapter daContacts;
  protected MGATextBox txtEmail;
  protected MGATextBox txtTitle;
  protected MGATextBox txtLName;
  protected MGATextBox txtFName;
  protected MGATextBox txtExt;
  private Label Label4;
  private UltraGroupBox grpContactInfo;
  private Label Label2;
  private SqlDataAdapter daSpecialContactList;
  private SqlDataAdapter daSpecialContacts;
  private MGATextBox txtSalutation;
  private dsIntermediaryContacts dsContacts;
  private MGASimpleComboBox cboStatus;
  private SqlCommand SqlSelectCommand5;
  private ErrorProvider ErrProvider;
  private MGAMaskedEdit txtPhone;
  private MGAMaskedEdit txtCell;
  private MGAMaskedEdit txtFax;
  private UltraGroupBox GroupBox2;
  private DataView dvProducerContacts;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private SqlCommand SqlSelectCommand2;
  private SqlCommand SqlInsertCommand2;
  private SqlCommand SqlUpdateCommand2;
  private SqlCommand SqlDeleteCommand2;

  [field: AccessedThroughProperty("SignatureCapturePanel1")]
  protected virtual SignatureCapturePanel SignatureCapturePanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblIntermediary")]
  protected virtual Label lblIntermediary { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI DbSaveUI
  {
    get => this._DbSaveUI;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.DbSaveUI_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.DbSaveUI_ClickingNew);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.DbSaveUI_ClickingEdit);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.DbSaveUI_ClickingDelete);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.DbSaveUI_ClickingCancel);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUi1 = this._DbSaveUI;
      if (dbSaveUi1 != null)
      {
        dbSaveUi1.ClickingSave -= cancelEventHandler1;
        dbSaveUi1.ClickingNew -= cancelEventHandler2;
        dbSaveUi1.ClickingEdit -= cancelEventHandler3;
        dbSaveUi1.ClickingDelete -= cancelEventHandler4;
        dbSaveUi1.ClickingCancel -= cancelEventHandler5;
      }
      this._DbSaveUI = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUi2 = this._DbSaveUI;
      if (dbSaveUi2 == null)
        return;
      dbSaveUi2.ClickingSave += cancelEventHandler1;
      dbSaveUi2.ClickingNew += cancelEventHandler2;
      dbSaveUi2.ClickingEdit += cancelEventHandler3;
      dbSaveUi2.ClickingDelete += cancelEventHandler4;
      dbSaveUi2.ClickingCancel += cancelEventHandler5;
    }
  }

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmIntermediaryContacts));
    this.grpContactInfo = new UltraGroupBox();
    this.SignatureCapturePanel1 = new SignatureCapturePanel();
    this.txtFax = new MGAMaskedEdit();
    this.dsContacts = new dsIntermediaryContacts();
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
    this.txtSalutation = new MGATextBox();
    this.lstContacts = new MGAListBox();
    this.dvProducerContacts = new DataView();
    this.grpContacts = new UltraGroupBox();
    this.GroupBox2 = new UltraGroupBox();
    this.chkFilterActive = new MGACheckBox();
    this.chkFilterInActive = new MGACheckBox();
    this.ToolTip = new ToolTip(this.components);
    this.daContacts = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.daSpecialContactList = new SqlDataAdapter();
    this.SqlSelectCommand5 = new SqlCommand();
    this.daSpecialContacts = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    this.lblIntermediary = new Label();
    this.ErrProvider = new ErrorProvider(this.components);
    this.DbSaveUI = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    ((ISupportInitialize) this.grpContactInfo).BeginInit();
    ((Control) this.grpContactInfo).SuspendLayout();
    ((ISupportInitialize) this.txtFax).BeginInit();
    this.dsContacts.BeginInit();
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
    ((ISupportInitialize) this.txtSalutation).BeginInit();
    ((ISupportInitialize) this.lstContacts).BeginInit();
    this.dvProducerContacts.BeginInit();
    ((ISupportInitialize) this.grpContacts).BeginInit();
    ((Control) this.grpContacts).SuspendLayout();
    ((ISupportInitialize) this.GroupBox2).BeginInit();
    ((Control) this.GroupBox2).SuspendLayout();
    ((ISupportInitialize) this.chkFilterActive).BeginInit();
    ((ISupportInitialize) this.chkFilterInActive).BeginInit();
    ((ISupportInitialize) this.ErrProvider).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    this.grpContactInfo.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.grpContactInfo).Controls.Add((Control) this.SignatureCapturePanel1);
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
    ((Control) this.grpContactInfo).Controls.Add((Control) this.txtSalutation);
    ((Control) this.grpContactInfo).Enabled = false;
    appearance2.ForeColor = Color.FromArgb(21, 66, 139);
    this.grpContactInfo.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.grpContactInfo).Location = new Point(178, 40);
    ((Control) this.grpContactInfo).Name = "grpContactInfo";
    ((Control) this.grpContactInfo).Size = new Size(436, 457);
    ((Control) this.grpContactInfo).TabIndex = 2;
    this.grpContactInfo.Text = "Contact Information";
    this.grpContactInfo.ViewStyle = (GroupBoxViewStyle) 2;
    this.SignatureCapturePanel1.BackColor = Color.White;
    this.SignatureCapturePanel1.CaptureSize = new Size(240 /*0xF0*/, 100);
    this.SignatureCapturePanel1.Location = new Point(15, 282);
    this.SignatureCapturePanel1.Name = "SignatureCapturePanel1";
    this.SignatureCapturePanel1.Size = new Size(405, 160 /*0xA0*/);
    this.SignatureCapturePanel1.TabIndex = 154;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtFax.Appearance = (AppearanceBase) appearance3;
    ((Control) this.txtFax).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblIntermediaryContacts.Fax", true));
    this.txtFax.EditAs = (EditAsType) 1;
    this.txtFax.InputMask = "###-###-####";
    ((Control) this.txtFax).Location = new Point(78, 178);
    this.txtFax.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFax).Name = "txtFax";
    this.txtFax.NonAutoSizeHeight = 20;
    ((Control) this.txtFax).Size = new Size(96 /*0x60*/, 21);
    ((Control) this.txtFax).TabIndex = 7;
    this.txtFax.Text = "--";
    ((UltraControlBase) this.txtFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFax).UseOsThemes = (DefaultableBoolean) 2;
    this.dsContacts.DataSetName = "dsIntermediaryContacts";
    this.dsContacts.Locale = new CultureInfo("en-US");
    this.dsContacts.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(12, 177);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(56, 23);
    this.Label5.TabIndex = 153;
    this.Label5.Text = "Fax";
    this.Label5.TextAlign = ContentAlignment.MiddleLeft;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtCell.Appearance = (AppearanceBase) appearance4;
    ((Control) this.txtCell).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblIntermediaryContacts.Cell", true));
    this.txtCell.EditAs = (EditAsType) 1;
    this.txtCell.InputMask = "###-###-####";
    ((Control) this.txtCell).Location = new Point(78, 153);
    this.txtCell.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCell).Name = "txtCell";
    this.txtCell.NonAutoSizeHeight = 20;
    ((Control) this.txtCell).Size = new Size(96 /*0x60*/, 21);
    ((Control) this.txtCell).TabIndex = 6;
    this.txtCell.Text = "--";
    ((UltraControlBase) this.txtCell).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCell).UseOsThemes = (DefaultableBoolean) 2;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtPhone.Appearance = (AppearanceBase) appearance5;
    ((Control) this.txtPhone).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblIntermediaryContacts.Phone", true));
    this.txtPhone.EditAs = (EditAsType) 1;
    this.txtPhone.InputMask = "###-###-####";
    ((Control) this.txtPhone).Location = new Point(78, 128 /*0x80*/);
    this.txtPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPhone).Name = "txtPhone";
    this.txtPhone.NonAutoSizeHeight = 20;
    ((Control) this.txtPhone).Size = new Size(96 /*0x60*/, 21);
    ((Control) this.txtPhone).TabIndex = 4;
    this.txtPhone.Text = "--";
    ((UltraControlBase) this.txtPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPhone).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(12, 252);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(56, 23);
    this.Label1.TabIndex = 151;
    this.Label1.Text = "Status";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.cboStatus.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboStatus).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblIntermediaryContacts.StatusID", true));
    ((UltraGridBase) this.cboStatus).DataSource = (object) this.dsContacts.lstStatus;
    ((UltraDropDownBase) this.cboStatus).DisplayMember = "Status";
    this.cboStatus.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboStatus).Location = new Point(78, 253);
    this.cboStatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboStatus).Name = "cboStatus";
    ((Control) this.cboStatus).Size = new Size(149, 21);
    ((Control) this.cboStatus).TabIndex = 10;
    ((UltraControlBase) this.cboStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboStatus).ValueMember = "StatusID";
    this.lstSpecialContacts.CheckOnClick = true;
    this.lstSpecialContacts.DataSource = (object) this.dsContacts.lstIntermediarySpecialContactTypes;
    this.lstSpecialContacts.DisplayMember = "SpecialContactType";
    this.lstSpecialContacts.Location = new Point(247, 48 /*0x30*/);
    this.lstSpecialContacts.MGAStyle = MGAStyles.Blue;
    this.lstSpecialContacts.Name = "lstSpecialContacts";
    this.lstSpecialContacts.Size = new Size(173, 228);
    this.lstSpecialContacts.TabIndex = 11;
    this.lstSpecialContacts.ValueMember = "SpecialContactTypeID";
    appearance6.BackColor = Color.Gainsboro;
    appearance6.BackColor2 = Color.White;
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.Gray;
    ((ControlBase) this.btnSpecialContact).Appearance = (AppearanceBase) appearance6;
    ((Control) this.btnSpecialContact).Location = new Point(346, 27);
    ((Control) this.btnSpecialContact).Name = "btnSpecialContact";
    ((Control) this.btnSpecialContact).Size = new Size(30, 16 /*0x10*/);
    ((Control) this.btnSpecialContact).TabIndex = 149;
    ((ControlBase) this.btnSpecialContact).Text = "...";
    this.btnSpecialContact.UseOSThemes = (DefaultableBoolean) 2;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(244, 27);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.Label2.TabIndex = 148;
    this.Label2.Text = "Special Contacts";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtExt).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.txtExt).BackColor = Color.White;
    ((Control) this.txtExt).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblIntermediaryContacts.Extension", true));
    ((Control) this.txtExt).Location = new Point(180, 128 /*0x80*/);
    this.txtExt.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtExt).Name = "txtExt";
    ((Control) this.txtExt).Size = new Size(47, 20);
    ((Control) this.txtExt).TabIndex = 5;
    ((UltraControlBase) this.txtExt).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtExt).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(12, 227);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(56, 23);
    this.Label7.TabIndex = 136;
    this.Label7.Text = "Delivery";
    this.Label7.TextAlign = ContentAlignment.MiddleLeft;
    this.cboDeliveryMethod.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboDeliveryMethod).DataBindings.Add(new Binding("Value", (object) this.dsContacts, "tblIntermediaryContacts.DeliveryMethodID", true));
    ((UltraGridBase) this.cboDeliveryMethod).DataSource = (object) this.dsContacts.lstDeliveryMethod;
    ((UltraDropDownBase) this.cboDeliveryMethod).DisplayMember = "Description";
    this.cboDeliveryMethod.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDeliveryMethod).Location = new Point(78, 228);
    this.cboDeliveryMethod.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDeliveryMethod).Name = "cboDeliveryMethod";
    ((Control) this.cboDeliveryMethod).Size = new Size(149, 21);
    ((Control) this.cboDeliveryMethod).TabIndex = 9;
    ((UltraControlBase) this.cboDeliveryMethod).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDeliveryMethod).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDeliveryMethod).ValueMember = "DeliveryMethodID";
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(12, 27);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(56, 23);
    this.Label4.TabIndex = 130;
    this.Label4.Text = "Salutation";
    this.Label4.TextAlign = ContentAlignment.MiddleLeft;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEmail).Appearance = (AppearanceBase) appearance8;
    ((TextEditorControlBase) this.txtEmail).BackColor = Color.White;
    ((Control) this.txtEmail).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblIntermediaryContacts.Email", true));
    ((Control) this.txtEmail).Location = new Point(78, 203);
    this.txtEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEmail).Name = "txtEmail";
    ((Control) this.txtEmail).Size = new Size(149, 20);
    ((Control) this.txtEmail).TabIndex = 8;
    ((UltraControlBase) this.txtEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(12, 202);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(56, 23);
    this.Label13.TabIndex = 121;
    this.Label13.Text = "Email";
    this.Label13.TextAlign = ContentAlignment.MiddleLeft;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTitle).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.txtTitle).BackColor = Color.White;
    ((Control) this.txtTitle).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblIntermediaryContacts.Title", true));
    ((Control) this.txtTitle).Location = new Point(77, 103);
    this.txtTitle.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtTitle).Name = "txtTitle";
    ((Control) this.txtTitle).Size = new Size(150, 20);
    ((Control) this.txtTitle).TabIndex = 3;
    ((UltraControlBase) this.txtTitle).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTitle).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(12, 102);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(56, 23);
    this.Label8.TabIndex = 111;
    this.Label8.Text = "Title";
    this.Label8.TextAlign = ContentAlignment.MiddleLeft;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(12, 152);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(56, 23);
    this.Label3.TabIndex = 98;
    this.Label3.Text = "Cell";
    this.Label3.TextAlign = ContentAlignment.MiddleLeft;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLName).Appearance = (AppearanceBase) appearance10;
    ((TextEditorControlBase) this.txtLName).BackColor = Color.White;
    ((Control) this.txtLName).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblIntermediaryContacts.LName", true));
    ((Control) this.txtLName).Location = new Point(77, 78);
    this.txtLName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLName).Name = "txtLName";
    ((Control) this.txtLName).Size = new Size(150, 20);
    ((Control) this.txtLName).TabIndex = 2;
    ((UltraControlBase) this.txtLName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLName).UseOsThemes = (DefaultableBoolean) 2;
    this.lblAddress1.BackColor = Color.Transparent;
    this.lblAddress1.Location = new Point(12, 52);
    this.lblAddress1.Name = "lblAddress1";
    this.lblAddress1.Size = new Size(56, 23);
    this.lblAddress1.TabIndex = 89;
    this.lblAddress1.Text = "First";
    this.lblAddress1.TextAlign = ContentAlignment.MiddleLeft;
    this.lblAddress2.BackColor = Color.Transparent;
    this.lblAddress2.Location = new Point(12, 77);
    this.lblAddress2.Name = "lblAddress2";
    this.lblAddress2.Size = new Size(56, 23);
    this.lblAddress2.TabIndex = 90;
    this.lblAddress2.Text = "Last";
    this.lblAddress2.TextAlign = ContentAlignment.MiddleLeft;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFName).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.txtFName).BackColor = Color.White;
    ((Control) this.txtFName).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblIntermediaryContacts.FName", true));
    ((Control) this.txtFName).Location = new Point(77, 53);
    this.txtFName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFName).Name = "txtFName";
    ((Control) this.txtFName).Size = new Size(150, 20);
    ((Control) this.txtFName).TabIndex = 1;
    ((UltraControlBase) this.txtFName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFName).UseOsThemes = (DefaultableBoolean) 2;
    this.lblPhone.BackColor = Color.Transparent;
    this.lblPhone.Location = new Point(12, (int) sbyte.MaxValue);
    this.lblPhone.Name = "lblPhone";
    this.lblPhone.Size = new Size(56, 23);
    this.lblPhone.TabIndex = 92;
    this.lblPhone.Text = "Phone";
    this.lblPhone.TextAlign = ContentAlignment.MiddleLeft;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSalutation).Appearance = (AppearanceBase) appearance12;
    ((TextEditorControlBase) this.txtSalutation).BackColor = Color.White;
    ((Control) this.txtSalutation).DataBindings.Add(new Binding("Text", (object) this.dsContacts, "tblIntermediaryContacts.Salutation", true));
    ((Control) this.txtSalutation).Location = new Point(77, 28);
    ((TextEditorControlBase) this.txtSalutation).MaxLength = 4;
    this.txtSalutation.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtSalutation).Name = "txtSalutation";
    ((Control) this.txtSalutation).Size = new Size(32 /*0x20*/, 20);
    ((Control) this.txtSalutation).TabIndex = 0;
    ((UltraControlBase) this.txtSalutation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSalutation).UseOsThemes = (DefaultableBoolean) 2;
    this.lstContacts.DataSource = (object) this.dvProducerContacts;
    this.lstContacts.DisplayMember = "Name";
    this.lstContacts.Location = new Point(7, 29);
    this.lstContacts.MGAStyle = MGAStyles.Blue;
    this.lstContacts.Name = "lstContacts";
    this.lstContacts.Size = new Size(147, 340);
    this.lstContacts.TabIndex = 0;
    this.lstContacts.ValueMember = "IntermediaryContactGuid";
    this.dvProducerContacts.RowFilter = "StatusID = 1";
    this.dvProducerContacts.Table = (DataTable) this.dsContacts.tblIntermediaryContacts;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpContacts.Appearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    this.grpContacts.ContentAreaAppearance = (AppearanceBase) appearance14;
    ((Control) this.grpContacts).Controls.Add((Control) this.GroupBox2);
    ((Control) this.grpContacts).Controls.Add((Control) this.lstContacts);
    appearance15.ForeColor = Color.FromArgb(21, 66, 139);
    this.grpContacts.HeaderAppearance = (AppearanceBase) appearance15;
    ((Control) this.grpContacts).Location = new Point(12, 40);
    ((Control) this.grpContacts).Name = "grpContacts";
    ((Control) this.grpContacts).Size = new Size(160 /*0xA0*/, 457);
    ((Control) this.grpContacts).TabIndex = 1;
    this.grpContacts.Text = "Contacts";
    this.grpContacts.ViewStyle = (GroupBoxViewStyle) 2;
    appearance16.BackColor = Color.Transparent;
    this.GroupBox2.Appearance = (AppearanceBase) appearance16;
    this.GroupBox2.BackColorInternal = Color.WhiteSmoke;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.GroupBox2.ContentAreaAppearance = (AppearanceBase) appearance17;
    ((Control) this.GroupBox2).Controls.Add((Control) this.chkFilterActive);
    ((Control) this.GroupBox2).Controls.Add((Control) this.chkFilterInActive);
    ((Control) this.GroupBox2).Location = new Point(7, 393);
    ((Control) this.GroupBox2).Name = "GroupBox2";
    ((Control) this.GroupBox2).Size = new Size(147, 49);
    ((Control) this.GroupBox2).TabIndex = 10;
    this.GroupBox2.Text = "Filter by";
    appearance18.BorderColor = Color.Gray;
    appearance18.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFilterActive).Appearance = (AppearanceBase) appearance18;
    ((UltraToggleEditorBase) this.chkFilterActive).Checked = true;
    ((UltraToggleEditorBase) this.chkFilterActive).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkFilterActive).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFilterActive).Location = new Point(14, 21);
    ((Control) this.chkFilterActive).Name = "chkFilterActive";
    ((Control) this.chkFilterActive).Size = new Size(58, 14);
    ((Control) this.chkFilterActive).TabIndex = 6;
    ((UltraToggleEditorBase) this.chkFilterActive).Text = "Active";
    ((UltraControlBase) this.chkFilterActive).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFilterActive).UseOsThemes = (DefaultableBoolean) 2;
    appearance19.BorderColor = Color.Gray;
    appearance19.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFilterInActive).Appearance = (AppearanceBase) appearance19;
    ((UltraToggleEditorBase) this.chkFilterInActive).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFilterInActive).Location = new Point(80 /*0x50*/, 21);
    ((Control) this.chkFilterInActive).Name = "chkFilterInActive";
    ((Control) this.chkFilterInActive).Size = new Size(64 /*0x40*/, 14);
    ((Control) this.chkFilterInActive).TabIndex = 7;
    ((UltraToggleEditorBase) this.chkFilterInActive).Text = "Inactive";
    ((UltraControlBase) this.chkFilterInActive).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFilterInActive).UseOsThemes = (DefaultableBoolean) 2;
    this.daContacts.DeleteCommand = this.SqlDeleteCommand1;
    this.daContacts.InsertCommand = this.SqlInsertCommand1;
    this.daContacts.SelectCommand = this.SqlSelectCommand1;
    this.daContacts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblIntermediaryContacts", new DataColumnMapping[15]
      {
        new DataColumnMapping("IntermediaryContactGUID", "IntermediaryContactGUID"),
        new DataColumnMapping("IntermediaryID", "IntermediaryID"),
        new DataColumnMapping("DeliveryMethodID", "DeliveryMethodID"),
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("FName", "FName"),
        new DataColumnMapping("LName", "LName"),
        new DataColumnMapping("Title", "Title"),
        new DataColumnMapping("Phone", "Phone"),
        new DataColumnMapping("Extension", "Extension"),
        new DataColumnMapping("Cell", "Cell"),
        new DataColumnMapping("Email", "Email"),
        new DataColumnMapping("Salutation", "Salutation"),
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("Fax", "Fax"),
        new DataColumnMapping("ContactSignature", "ContactSignature")
      })
    });
    this.daContacts.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblIntermediaryContacts] WHERE (([IntermediaryContactGUID] = @Original_IntermediaryContactGUID))";
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_IntermediaryContactGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IntermediaryContactGUID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[14]
    {
      new SqlParameter("@IntermediaryContactGUID", SqlDbType.UniqueIdentifier, 0, "IntermediaryContactGUID"),
      new SqlParameter("@IntermediaryID", SqlDbType.Int, 0, "IntermediaryID"),
      new SqlParameter("@DeliveryMethodID", SqlDbType.TinyInt, 0, "DeliveryMethodID"),
      new SqlParameter("@FName", SqlDbType.VarChar, 0, "FName"),
      new SqlParameter("@LName", SqlDbType.VarChar, 0, "LName"),
      new SqlParameter("@Title", SqlDbType.VarChar, 0, "Title"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 0, "Phone"),
      new SqlParameter("@Extension", SqlDbType.VarChar, 0, "Extension"),
      new SqlParameter("@Cell", SqlDbType.VarChar, 0, "Cell"),
      new SqlParameter("@Email", SqlDbType.VarChar, 0, "Email"),
      new SqlParameter("@Salutation", SqlDbType.VarChar, 0, "Salutation"),
      new SqlParameter("@StatusID", SqlDbType.TinyInt, 0, "StatusID"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 0, "Fax"),
      new SqlParameter("@ContactSignature", SqlDbType.Image, 0, "ContactSignature")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@IntermediaryID", SqlDbType.Int, 4, "IntermediaryID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[15]
    {
      new SqlParameter("@IntermediaryContactGUID", SqlDbType.UniqueIdentifier, 0, "IntermediaryContactGUID"),
      new SqlParameter("@IntermediaryID", SqlDbType.Int, 0, "IntermediaryID"),
      new SqlParameter("@DeliveryMethodID", SqlDbType.TinyInt, 0, "DeliveryMethodID"),
      new SqlParameter("@FName", SqlDbType.VarChar, 0, "FName"),
      new SqlParameter("@LName", SqlDbType.VarChar, 0, "LName"),
      new SqlParameter("@Title", SqlDbType.VarChar, 0, "Title"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 0, "Phone"),
      new SqlParameter("@Extension", SqlDbType.VarChar, 0, "Extension"),
      new SqlParameter("@Cell", SqlDbType.VarChar, 0, "Cell"),
      new SqlParameter("@Email", SqlDbType.VarChar, 0, "Email"),
      new SqlParameter("@Salutation", SqlDbType.VarChar, 0, "Salutation"),
      new SqlParameter("@StatusID", SqlDbType.TinyInt, 0, "StatusID"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 0, "Fax"),
      new SqlParameter("@ContactSignature", SqlDbType.Image, 0, "ContactSignature"),
      new SqlParameter("@Original_IntermediaryContactGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IntermediaryContactGUID", DataRowVersion.Original, (object) null)
    });
    this.daSpecialContactList.SelectCommand = this.SqlSelectCommand5;
    this.daSpecialContactList.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstIntermediarySpecialContactTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("SpecialContactTypeID", "SpecialContactTypeID"),
        new DataColumnMapping("SpecialContactType", "SpecialContactType")
      })
    });
    this.SqlSelectCommand5.CommandText = "SELECT SpecialContactTypeID, SpecialContactType FROM lstIntermediarySpecialContactTypes WHERE (Hidden = 0) ORDER BY SpecialContactType";
    this.daSpecialContacts.DeleteCommand = this.SqlDeleteCommand2;
    this.daSpecialContacts.InsertCommand = this.SqlInsertCommand2;
    this.daSpecialContacts.SelectCommand = this.SqlSelectCommand2;
    this.daSpecialContacts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblIntermediarySpecialContacts", new DataColumnMapping[2]
      {
        new DataColumnMapping("IntermediaryContactGuid", "IntermediaryContactGuid"),
        new DataColumnMapping("SpecialContactTypeID", "SpecialContactTypeID")
      })
    });
    this.daSpecialContacts.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM tblIntermediarySpecialContacts WHERE (IntermediaryContactGuid = @Original_intermediaryContactGuid) AND (SpecialContactTypeID = @Original_SpecialContactTypeID)";
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_intermediaryContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IntermediaryContactGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SpecialContactTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SpecialContactTypeID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = componentResourceManager.GetString("SqlInsertCommand2.CommandText");
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@IntermediaryContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "IntermediaryContactGuid"),
      new SqlParameter("@SpecialContactTypeID", SqlDbType.Int, 4, "SpecialContactTypeID")
    });
    this.SqlSelectCommand2.CommandText = "SELECT IntermediaryContactGuid, SpecialContactTypeID FROM tblIntermediarySpecialContacts WHERE (IntermediaryContactGuid = @IntermediaryContactGuid)";
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@IntermediaryContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "IntermediaryContactGuid")
    });
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@IntermediaryContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "IntermediaryContactGuid"),
      new SqlParameter("@SpecialContactTypeID", SqlDbType.Int, 4, "SpecialContactTypeID"),
      new SqlParameter("@Original_intermediaryContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IntermediaryContactGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SpecialContactTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SpecialContactTypeID", DataRowVersion.Original, (object) null)
    });
    this.lblIntermediary.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblIntermediary.Location = new Point(12, 5);
    this.lblIntermediary.Name = "lblIntermediary";
    this.lblIntermediary.Size = new Size(576, 32 /*0x20*/);
    this.lblIntermediary.TabIndex = 5;
    this.lblIntermediary.Text = "Label2";
    this.lblIntermediary.TextAlign = ContentAlignment.MiddleCenter;
    this.ErrProvider.ContainerControl = (ContainerControl) this;
    this.DbSaveUI.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.DbSaveUI.AutoQueryRowCountOnLoad = false;
    this.DbSaveUI.EditStyle = EditStyle.ShowEditButton;
    this.DbSaveUI.FreezeEvents = false;
    this.DbSaveUI.Location = new Point(494, 505);
    this.DbSaveUI.Name = "DbSaveUI";
    this.DbSaveUI.Size = new Size(120, 40);
    this.DbSaveUI.TabIndex = 6;
    this.DbSaveUI.UIState = UIState.HasRecordsNotEditing;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(626, 553);
    this.Controls.Add((Control) this.DbSaveUI);
    this.Controls.Add((Control) this.lblIntermediary);
    this.Controls.Add((Control) this.grpContactInfo);
    this.Controls.Add((Control) this.grpContacts);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.Name = nameof (frmIntermediaryContacts);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Intermediary Contacts";
    ((ISupportInitialize) this.grpContactInfo).EndInit();
    ((Control) this.grpContactInfo).ResumeLayout(false);
    ((Control) this.grpContactInfo).PerformLayout();
    ((ISupportInitialize) this.txtFax).EndInit();
    this.dsContacts.EndInit();
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
    ((ISupportInitialize) this.txtSalutation).EndInit();
    ((ISupportInitialize) this.lstContacts).EndInit();
    this.dvProducerContacts.EndInit();
    ((ISupportInitialize) this.grpContacts).EndInit();
    ((Control) this.grpContacts).ResumeLayout(false);
    ((ISupportInitialize) this.GroupBox2).EndInit();
    ((Control) this.GroupBox2).ResumeLayout(false);
    ((ISupportInitialize) this.chkFilterActive).EndInit();
    ((ISupportInitialize) this.chkFilterInActive).EndInit();
    ((ISupportInitialize) this.ErrProvider).EndInit();
    this.ResumeLayout(false);
  }

  public frmIntermediaryContacts(int intermediaryID, Guid intermediaryContactGuid)
    : this(intermediaryID)
  {
    this._newContactOnLoad = false;
    this._intermediaryContactGuid = intermediaryContactGuid;
    this.lstContacts.SelectedValue = (object) this._intermediaryContactGuid;
    this.bmbContacts.Position = this.lstContacts.SelectedIndex;
  }

  public frmIntermediaryContacts(int intermediaryID)
  {
    this.Load += new EventHandler(this.frmIntermediaryContacts_Load);
    this.InitializeComponent();
    this.InitializeConnection();
    this._intermediaryID = intermediaryID;
    this.PopulateDataSet();
    this._newContactOnLoad = true;
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

  private void InitializeConnection()
  {
    this._cn = DefaultDatabase.CreateConnection();
    SqlDataAdapter daContacts = this.daContacts;
    daContacts.SelectCommand.Connection = this._cn;
    daContacts.InsertCommand.Connection = this._cn;
    daContacts.DeleteCommand.Connection = this._cn;
    daContacts.UpdateCommand.Connection = this._cn;
    SqlDataAdapter daSpecialContacts = this.daSpecialContacts;
    daSpecialContacts.SelectCommand.Connection = this._cn;
    daSpecialContacts.InsertCommand.Connection = this._cn;
    daSpecialContacts.DeleteCommand.Connection = this._cn;
    daSpecialContacts.UpdateCommand.Connection = this._cn;
    this.daSpecialContactList.SelectCommand.Connection = this._cn;
  }

  private BindingManagerBase bmbContacts
  {
    get
    {
      return this.BindingContext[(object) this.dsContacts, this.dsContacts.tblIntermediaryContacts.TableName];
    }
  }

  private dsIntermediaryContacts.tblIntermediaryContactsRow CurrentContactRow
  {
    get => this.dsContacts.tblIntermediaryContacts[this.bmbContacts.Position];
  }

  private bool ValidForm
  {
    get
    {
      bool validForm = true;
      if (((TextEditorControlBase) this.txtFName).Text.Length == 0)
      {
        this.ErrProvider.SetError((Control) this.txtFName, "Please enter a first name.");
        validForm = false;
      }
      else
        this.ErrProvider.SetError((Control) this.txtFName, string.Empty);
      if (((TextEditorControlBase) this.txtLName).Text.Length == 0)
      {
        this.ErrProvider.SetError((Control) this.txtLName, "Please enter a last name.");
        validForm = false;
      }
      else
        this.ErrProvider.SetError((Control) this.txtLName, string.Empty);
      if (this.cboDeliveryMethod.Text.Length == 0)
      {
        this.ErrProvider.SetError((Control) this.cboDeliveryMethod, "Please enter a delivery method.");
        validForm = false;
      }
      else if (Conversions.ToInteger(this.cboDeliveryMethod.Value) == 3 && ((TextEditorControlBase) this.txtEmail).Text.Length == 0)
      {
        this.ErrProvider.SetError((Control) this.txtEmail, "Email must be provided when selecting email delivery type.");
        this.ErrProvider.SetError((Control) this.txtFax, string.Empty);
        this.ErrProvider.SetError((Control) this.cboDeliveryMethod, string.Empty);
        validForm = false;
      }
      else if (Conversions.ToInteger(this.cboDeliveryMethod.Value) == 2 && this.txtFax.Value == DBNull.Value | this.txtFax.Value == (object) string.Empty)
      {
        this.ErrProvider.SetError((Control) this.txtFax, "Email must be provided when selecting email delivery type.");
        this.ErrProvider.SetError((Control) this.txtEmail, string.Empty);
        this.ErrProvider.SetError((Control) this.cboDeliveryMethod, string.Empty);
        validForm = false;
      }
      else
      {
        this.ErrProvider.SetError((Control) this.txtEmail, string.Empty);
        this.ErrProvider.SetError((Control) this.txtFax, string.Empty);
        this.ErrProvider.SetError((Control) this.cboDeliveryMethod, string.Empty);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtEmail).Text, string.Empty, false) != 0 && !Parsing.IsValidEmailAddress(((TextEditorControlBase) this.txtEmail).Text))
      {
        this.ErrProvider.SetError((Control) this.txtEmail, "Please enter a valid email address.");
        validForm = false;
      }
      if (this.cboStatus.Text.Length == 0)
      {
        this.ErrProvider.SetError((Control) this.cboStatus, "Please select a status.");
        validForm = false;
      }
      else
        this.ErrProvider.SetError((Control) this.cboStatus, string.Empty);
      return validForm;
    }
  }

  private void UpdateContactBinding()
  {
    Guid contactGuid = this.lstContacts.SelectedValue == null ? this._intermediaryContactGuid : (Guid) this.lstContacts.SelectedValue;
    Database.MoveTo((object) contactGuid, "IntermediaryContactGuid", (DataTable) this.dsContacts.tblIntermediaryContacts, this.bmbContacts);
    this.LoadSpecialContacts(contactGuid);
    this._intermediaryContactGuid = this.dsContacts.tblIntermediaryContacts[this.bmbContacts.Position].IntermediaryContactGuid;
    try
    {
      if (!this.dsContacts.tblIntermediaryContacts[this.bmbContacts.Position].IsContactSignatureNull())
        this.SignatureCapturePanel1.SetSignatureImageBytes(this.dsContacts.tblIntermediaryContacts[this.bmbContacts.Position].ContactSignature);
      else
        this.SignatureCapturePanel1.Clear();
    }
    catch (StrongTypingException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this.SignatureCapturePanel1.Clear();
      ProjectData.ClearProjectError();
    }
  }

  private void setEditModeOn(bool setMode)
  {
    ((Control) this.grpContacts).Enabled = !setMode;
    ((Control) this.grpContactInfo).Enabled = setMode;
  }

  private void frmIntermediaryContacts_Load(object sender, EventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    this.lstContacts.MouseUp += new MouseEventHandler(this.SelectContact);
    this.lstContacts.KeyUp += new KeyEventHandler(this.SelectContact);
    if (this._newContactOnLoad)
    {
      this.DbSaveUI.UIState = UIState.Editing;
      this.AddNewContact();
      this.setEditModeOn(true);
      this._newContactOnLoad = false;
    }
    else
      this.UpdateContactBinding();
  }

  private void PopulateDataSet()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsContacts, new string[1]
    {
      "tblIntermediaries"
    }, CommandType.Text, "SELECT IntermediaryID, IntermediaryName FROM tblIntermediaries WHERE IntermediaryID = @IntermediaryID ORDER BY IntermediaryName", new object[2]
    {
      (object) "@IntermediaryID",
      (object) this._intermediaryID
    });
    DefaultDatabase.LoadDataSet((DataSet) this.dsContacts, new string[1]
    {
      "lstDeliveryMethod"
    }, CommandType.Text, "SELECT DeliveryMethodID, Description FROM dbo.lstDeliveryMethod ORDER BY Description");
    DefaultDatabase.LoadDataSet((DataSet) this.dsContacts, new string[1]
    {
      "lstStatus"
    }, CommandType.Text, "SELECT StatusID, Status FROM lstStatus ORDER BY Status");
    this.daContacts.SelectCommand.Parameters["@IntermediaryID"].Value = (object) this._intermediaryID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblIntermediaryContacts);
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSpecialContactList, (DataTable) this.dsContacts.lstIntermediarySpecialContactTypes);
    if (this.dsContacts.tblIntermediaryContacts.Rows.Count > 0)
    {
      this.daSpecialContacts.SelectCommand.Parameters["@IntermediaryContactGuid"].Value = (object) this.dsContacts.tblIntermediaryContacts[0].IntermediaryContactGuid;
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblIntermediarySpecialContacts);
    }
    this.lblIntermediary.Text = this.dsContacts.tblIntermediaries[0].IntermediaryName;
  }

  internal void RefillSpecialContactsListTable()
  {
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSpecialContactList, (DataTable) this.dsContacts.lstIntermediarySpecialContactTypes);
    this.FillSpecialContactsListbox();
  }

  private void lstLocations_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.bmbContacts.EndCurrentEdit();
    if (this.dsContacts.HasChanges() && MessageBox.Show($"You have unsaved changes to contacts at this location.{Environment.NewLine}{Environment.NewLine}Would you like to save?", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
    {
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblIntermediaryContacts);
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblIntermediaryContacts);
    }
    string commandText = this.daContacts.SelectCommand.CommandText;
    this.dsContacts.tblIntermediarySpecialContacts.Clear();
    this.dsContacts.tblIntermediaryContacts.Clear();
    this.daContacts.SelectCommand.Parameters["@IntermediaryID"].Value = (object) this._intermediaryID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblIntermediaryContacts);
    this.daContacts.SelectCommand.CommandText = commandText;
    this.ClearSpecialContacts();
    if (this.lstContacts.SelectedIndex > -1)
    {
      this.UpdateContactBinding();
      this.DbSaveUI.UIState = UIState.HasRecordsNotEditing;
    }
    else
      this.DbSaveUI.UIState = UIState.NoRecordsNotEditing;
  }

  private void ClearSpecialContacts()
  {
    this.dsContacts.tblIntermediarySpecialContacts.Clear();
    this.dsContacts.tblIntermediarySpecialContacts.Clear();
    this.lstSpecialContacts.ItemCheck -= new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
    int num = this.lstSpecialContacts.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
      this.lstSpecialContacts.SetItemChecked(index, false);
    this.lstSpecialContacts.ItemCheck += new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
  }

  private void LoadSpecialContacts(Guid contactGuid)
  {
    this.dsContacts.tblIntermediarySpecialContacts.Clear();
    this.daSpecialContacts.SelectCommand.Parameters["@IntermediaryContactGuid"].Value = (object) contactGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblIntermediarySpecialContacts);
    this.FillSpecialContactsListbox();
  }

  private void lstSpecialContacts_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    int specialContactTypeId = ((dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow) ((DataRowView) this.lstSpecialContacts.Items[this.lstSpecialContacts.SelectedIndex]).Row).SpecialContactTypeID;
    Guid intermediaryContactGuid = this.CurrentContactRow.IntermediaryContactGuid;
    if (e.CurrentValue == CheckState.Unchecked)
    {
      dsIntermediaryContacts.tblIntermediarySpecialContactsRow row = this.dsContacts.tblIntermediarySpecialContacts.NewtblIntermediarySpecialContactsRow();
      row.IntermediaryContactGuid = intermediaryContactGuid;
      row.SpecialContactTypeID = specialContactTypeId;
      this.dsContacts.tblIntermediarySpecialContacts.AddtblIntermediarySpecialContactsRow(row);
    }
    else
      this.dsContacts.tblIntermediarySpecialContacts.FindByIntermediaryContactGuidSpecialContactTypeID(intermediaryContactGuid, specialContactTypeId).Delete();
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
      foreach (dsIntermediaryContacts.tblIntermediarySpecialContactsRow intermediarySpecialContact in (TypedTableBase<dsIntermediaryContacts.tblIntermediarySpecialContactsRow>) this.dsContacts.tblIntermediarySpecialContacts)
      {
        int num2 = this.lstSpecialContacts.Items.Count - 1;
        for (int index = 0; index <= num2; ++index)
        {
          int specialContactTypeId = ((dsIntermediaryContacts.lstIntermediarySpecialContactTypesRow) ((DataRowView) this.lstSpecialContacts.Items[index]).Row).SpecialContactTypeID;
          if (intermediarySpecialContact.SpecialContactTypeID == specialContactTypeId)
            this.lstSpecialContacts.SetItemChecked(index, true);
        }
      }
    }
    finally
    {
      IEnumerator<dsIntermediaryContacts.tblIntermediarySpecialContactsRow> enumerator;
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

  private void btnSpecialContact_Click(object sender, EventArgs e)
  {
    using (FormSettings.ShowFormDialog(typeof (frmAdminIntermediarySpecialContacts), (object) new EventHandler(this.frmAdminIntermediarySpecialContacts_closing)))
      ;
  }

  private void frmAdminIntermediarySpecialContacts_closing(object sender, EventArgs e)
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
    if (this.DbSaveUI.UIState != UIState.Editing && this.lstContacts.SelectedIndex > -1)
    {
      this.UpdateContactBinding();
      this.DbSaveUI.UIState = UIState.HasRecordsNotEditing;
    }
    else
    {
      this.bmbContacts.Position = -1;
      this.DbSaveUI.UIState = UIState.NoRecordsNotEditing;
    }
  }

  private void ClearContacts()
  {
    try
    {
      this.lstSpecialContacts.ItemCheck -= new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
      int num = this.lstSpecialContacts.Items.Count - 1;
      for (int index = 0; index <= num; ++index)
        this.lstSpecialContacts.SetItemChecked(index, false);
    }
    finally
    {
      this.lstSpecialContacts.ItemCheck += new ItemCheckEventHandler(this.lstSpecialContacts_ItemCheck);
    }
  }

  private void DbSaveUI_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidForm)
    {
      e.Cancel = true;
    }
    else
    {
      bool isNewRow = this.CurrentContactRow.RowState == DataRowState.Added;
      bool flag = false;
      this.CurrentContactRow.ContactSignature = this.SignatureCapturePanel1.GetSignatureImageBytes();
      this.bmbContacts.EndCurrentEdit();
      if (this.CurrentContactRow.RowState == DataRowState.Added || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.CurrentContactRow.Name, $"{((TextEditorControlBase) this.txtLName).Text}, {((TextEditorControlBase) this.txtFName).Text}", false) != 0)
        this.CurrentContactRow.Name = $"{((TextEditorControlBase) this.txtLName).Text}, {((TextEditorControlBase) this.txtFName).Text}";
      List<string> lst = new List<string>();
      if (this.dsContacts.HasChanges())
      {
        this.GatherChanges(lst, isNewRow);
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblIntermediaryContacts);
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblIntermediarySpecialContacts);
        flag = true;
      }
      MDIControls.Instance.StatusBarText = "Your changes were saved successfully.";
      if (flag)
        this.LogChanges(lst, isNewRow);
      this.setEditModeOn(false);
      if (this.lstContacts.Items.Count == 0)
        this.DbSaveUI.UIState = UIState.HasRecordsNotEditing;
      if (this.lstContacts.SelectedIndex <= -1)
        return;
      this.UpdateContactBinding();
    }
  }

  private void DbSaveUI_ClickingNew(object sender, CancelEventArgs e)
  {
    this.AddNewContact();
    this.ClearContacts();
    this.setEditModeOn(true);
  }

  private void DbSaveUI_ClickingEdit(object sender, CancelEventArgs e) => this.setEditModeOn(true);

  private void DbSaveUI_ClickingDelete(object sender, CancelEventArgs e)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT QuoteGuid FROM tblQuoteDetails WITH (NOLOCK) WHERE IntermediaryContactGuid=@ICG", new object[2]
    {
      (object) "@ICG",
      (object) this._intermediaryContactGuid
    }));
    if (objectValue != null && objectValue != DBNull.Value)
    {
      Quote quote = new Quote((Guid) objectValue);
      int num = (int) MessageBox.Show($"This contact cannot be deleted.  It is in user on \n\nInsured - {quote.InsuredPolicyName}\nControl # - {quote.ControlNo.ToString()}", "Contact In Use", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (MessageBox.Show($"Are you sure you want to delete {this.dsContacts.tblIntermediaryContacts.FindByIntermediaryContactGuid(this._intermediaryContactGuid).LName}, {this.dsContacts.tblIntermediaryContacts.FindByIntermediaryContactGuid(this._intermediaryContactGuid).FName}?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      try
      {
        DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
        {
          try
          {
            this.dsContacts.tblIntermediaryContacts.FindByIntermediaryContactGuid(this._intermediaryContactGuid).Delete();
            DataRow[] dataRowArray = this.dsContacts.tblIntermediarySpecialContacts.Select($"IntermediaryContactGuid = '{this._intermediaryContactGuid.ToString()}'");
            int index = 0;
            while (index < dataRowArray.Length)
            {
              dataRowArray[index].Delete();
              checked { ++index; }
            }
            DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSpecialContacts, (DataTable) this.dsContacts.tblIntermediarySpecialContacts);
            DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daContacts, (DataTable) this.dsContacts.tblIntermediaryContacts);
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
        if (ex.Message.IndexOf("FK_tblQuoteDetails_tblIntermediaryContacts") != -1)
        {
          int num = (int) MessageBox.Show("Cannot delete Intermediary Contact because of an association with quotes in the system.", "Cannot Delete Intermediary Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        throw;
      }
      if (this.lstContacts.Items.Count == 0)
        this.DbSaveUI.UIState = UIState.NoRecordsNotEditing;
      if (this.lstContacts.SelectedIndex > -1)
        this.UpdateContactBinding();
      else
        this.ClearContacts();
    }
  }

  private void DbSaveUI_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.dsContacts.RejectChanges();
    this.setEditModeOn(false);
    this.DbSaveUI.UIState = this.lstContacts.Items.Count <= 0 ? UIState.NoRecordsNotEditing : UIState.HasRecordsNotEditing;
    this.ErrProvider.SetError((Control) this.txtFName, string.Empty);
    this.ErrProvider.SetError((Control) this.txtLName, string.Empty);
    this.ErrProvider.SetError((Control) this.cboDeliveryMethod, string.Empty);
    this.ErrProvider.SetError((Control) this.cboStatus, string.Empty);
    if (this.bmbContacts.Position != -1)
      this.UpdateContactBinding();
    else
      this.ClearContacts();
  }

  private void AddNewContact()
  {
    this.SignatureCapturePanel1.Clear();
    dsIntermediaryContacts.tblIntermediaryContactsDataTable intermediaryContacts = this.dsContacts.tblIntermediaryContacts;
    dsIntermediaryContacts.tblIntermediaryContactsRow row = intermediaryContacts.NewtblIntermediaryContactsRow();
    this._intermediaryContactGuid = Guid.NewGuid();
    row.IntermediaryID = this._intermediaryID;
    row.IntermediaryContactGuid = this._intermediaryContactGuid;
    intermediaryContacts.AddtblIntermediaryContactsRow(row);
    this.bmbContacts.Position = this.bmbContacts.Count - 1;
    this.cboDeliveryMethod.SelectedIndex = -1;
    this.cboStatus.SelectedIndex = -1;
  }

  private void GatherChanges(List<string> lst, bool isNewRow)
  {
    if (isNewRow)
    {
      lst.Add("Created new intermediary contact - " + this.CurrentContactRow.Name);
    }
    else
    {
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) this.dsContacts.tblIntermediaryContacts.Columns)
        {
          if (!column.ColumnName.Equals("ContactSignature") && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.CurrentContactRow[column.ColumnName, DataRowVersion.Original].ToString(), this.CurrentContactRow[column.ColumnName, DataRowVersion.Current].ToString(), false) != 0)
          {
            string str1 = this.CurrentContactRow[column.ColumnName] == DBNull.Value ? "<null>" : this.CurrentContactRow[column.ColumnName, DataRowVersion.Current].ToString();
            string str2 = this.CurrentContactRow[column.ColumnName, DataRowVersion.Original] == DBNull.Value ? "<null>" : this.CurrentContactRow[column.ColumnName, DataRowVersion.Original].ToString();
            lst.Add($"changed '{column.ColumnName}' changed from {str2} to {str1}");
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

  private void LogChanges(List<string> lst, bool isNewRow)
  {
    if (isNewRow)
    {
      CurrentUser.Instance.LogAction(lst[0]);
    }
    else
    {
      try
      {
        foreach (string str in lst)
          CurrentUser.Instance.LogAction($"Updated intermediary Contact '{this.CurrentContactRow.Name}' {str}");
      }
      finally
      {
        List<string>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmQuoteEdit2
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.AddressResolver;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Policies.PolicyBusinessObjects;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[SecureResource("{85D01871-DCAC-44b6-85EC-E50AFD8226EF}", "Allow Editing Cost Center After Account Issued", "Allow for users to edit Cost Center when a policy has been issued.", "Policies")]
[SecureResource("{7AC4429F-734B-4e0a-8CE1-468C15B6C4AF}", "Allow Editing of Producer Information After Account Bound", "Allow for users to edit Producer Information after a policy has been bound.", "Policies")]
[SecureResource("{15E267C1-0A94-4026-A720-A2E0895F5F3C}", "Allow Editing of Insured Information After Binding", "Allow for users to edit insured information after the account has been bound.", "Policies")]
[DocumentFolderFilter("Policy Info - Insured/Producer")]
public class frmQuoteEdit2 : Form, ISupportNoteSystem, ISupportDocumentSystem
{
  private IContainer components;
  private DbDataAdapter daQuote;
  private DbConnection cnSQL;
  protected dsQuoteEdit2 ds;
  private Label Label13;
  private Label Label12;
  private Label Label11;
  private Label Label10;
  private Label lblFEIN;
  private Label Label6;
  private Label Label5;
  private MGAMaskedEdit UltraMaskedEdit1;
  private Label Label4;
  private Label Label2;
  private Label Label7;
  private MGATextBox txtLocation;
  private MGAMaskedEdit UltraMaskedEdit2;
  private MGAMaskedEdit UltraMaskedEdit3;
  protected MGAMaskedEdit UltraMaskedEdit4;
  protected MGASimpleComboBox cboCostCenters;
  private Label Label9;
  private UltraGroupBox UltraGroupBox3;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private MGAMaskedEdit UltraMaskedEdit5;
  private MGAMaskedEdit UltraMaskedEdit6;
  private Label Label22;
  private Label Label23;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage2;
  private UltraTabPageControl UltraTabPageControl4;
  private UltraTabPageControl UltraTabPageControl5;
  private UltraTabPageControl UltraTabPageControl6;
  private MGAMaskedEdit UltraMaskedEdit7;
  private MGAMaskedEdit UltraMaskedEdit8;
  private Label Label14;
  private Label Label15;
  private Label Label16;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  private bool _isNewQuote;
  private Guid _quoteGuid;
  private bool _isConvertToFullQuote;
  private Quote _quote;
  private object _isIndividual;
  private bool _UnlockIndividualType;
  internal const string AllowEditingOfCostCenterOnBoundAccount = "{85D01871-DCAC-44b6-85EC-E50AFD8226EF}";
  internal const string CanEditInsuredInformationAfterBinding = "{15E267C1-0A94-4026-A720-A2E0895F5F3C}";
  internal const string CanEditProducerInformationAfterBinding = "{7AC4429F-734B-4e0a-8CE1-468C15B6C4AF}";

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  protected virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cboSalutations")]
  protected virtual MGASimpleComboBox cboSalutations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLast")]
  protected virtual MGATextBox txtLast { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtMiddle")]
  protected virtual MGATextBox txtMiddle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFirst")]
  protected virtual MGATextBox txtFirst { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBusiness")]
  protected virtual MGATextBox txtBusiness { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFEIN")]
  protected virtual MGAMaskedEdit txtFEIN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSSN")]
  protected virtual MGAMaskedEdit txtSSN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDBA")]
  protected virtual MGATextBox txtDBA { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPhone")]
  private virtual Label lblPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  protected virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtProducerName")]
  protected virtual MGATextBox txtProducerName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  protected virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  protected virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPolicyName")]
  protected virtual MGATextBox txtPolicyName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabControl1")]
  protected virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  protected virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  protected virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl3")]
  protected virtual UltraTabPageControl UltraTabPageControl3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPolicyIssued")]
  protected virtual UltraLabel lblPolicyIssued { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabControl2")]
  protected virtual UltraTabControl UltraTabControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboInsuredType")]
  protected virtual MGASimpleComboBox cboInsuredType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtRiskID")]
  protected virtual MGATextBox txtRiskID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblRiskID")]
  private virtual Label lblRiskID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkShowMap
  {
    get => this._lnkShowMap;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkShowMap_LinkClicked);
      LinkLabel lnkShowMap1 = this._lnkShowMap;
      if (lnkShowMap1 != null)
        lnkShowMap1.LinkClicked -= clickedEventHandler;
      this._lnkShowMap = value;
      LinkLabel lnkShowMap2 = this._lnkShowMap;
      if (lnkShowMap2 == null)
        return;
      lnkShowMap2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblMobile")]
  private virtual Label lblMobile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("mmeMobileNumber")]
  private virtual MGAMaskedEdit mmeMobileNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblEmailLabel")]
  private virtual Label lblEmailLabel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEmail")]
  protected virtual MGATextBox txtEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTaxID")]
  private virtual Label lblTaxID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtTaxID")]
  protected virtual MGATextBox txtTaxID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cmbGender")]
  protected virtual MGASimpleComboBox cmbGender { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblGender")]
  private virtual Label lblGender { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("mgaTxtBillingContact")]
  protected virtual MGATextBox mgaTxtBillingContact { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBillingContact")]
  private virtual Label lblBillingContact { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBillingEmail")]
  private virtual Label lblBillingEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("mgaTxtBillingEmail")]
  protected virtual MGATextBox mgaTxtBillingEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual AddressResolver_MULTI ctlZipCode
  {
    get => this._ctlZipCode;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      AddressResolver_MULTI.FocusOnZipEventHandler onZipEventHandler = new AddressResolver_MULTI.FocusOnZipEventHandler(this.CtlZipCode_ZipCodeLookupCompleted);
      EventHandler eventHandler1 = new EventHandler(this.CtlZipCode_CountryChanged);
      EventHandler eventHandler2 = new EventHandler(this.ctlZipCode_Leave);
      AddressResolver_MULTI ctlZipCode1 = this._ctlZipCode;
      if (ctlZipCode1 != null)
      {
        ctlZipCode1.ZipCodeLookupCompleted -= onZipEventHandler;
        ctlZipCode1.CountryChanged -= eventHandler1;
        ((Control) ctlZipCode1).Leave -= eventHandler2;
      }
      this._ctlZipCode = value;
      AddressResolver_MULTI ctlZipCode2 = this._ctlZipCode;
      if (ctlZipCode2 == null)
        return;
      ctlZipCode2.ZipCodeLookupCompleted += onZipEventHandler;
      ctlZipCode2.CountryChanged += eventHandler1;
      ((Control) ctlZipCode2).Leave += eventHandler2;
    }
  }

  protected virtual AddressResolver_MULTI CtrlInsuredMailing
  {
    get => this._CtrlInsuredMailing;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      AddressResolver_MULTI.FocusOnZipEventHandler onZipEventHandler = new AddressResolver_MULTI.FocusOnZipEventHandler(this.CtrlInsuredMailing_ZipCodeLookupCompleted);
      EventHandler eventHandler1 = new EventHandler(this.CtrlInsuredMailing_CountryChanged);
      EventHandler eventHandler2 = new EventHandler(this.CtrlInsuredMailing_CountryChanged);
      EventHandler eventHandler3 = new EventHandler(this.CtrlInsuredMailing_Leave);
      AddressResolver_MULTI ctrlInsuredMailing1 = this._CtrlInsuredMailing;
      if (ctrlInsuredMailing1 != null)
      {
        ctrlInsuredMailing1.ZipCodeLookupCompleted -= onZipEventHandler;
        ctrlInsuredMailing1.CountryChanged -= eventHandler1;
        ctrlInsuredMailing1.CountryValueChanged -= eventHandler2;
        ((Control) ctrlInsuredMailing1).Leave -= eventHandler3;
      }
      this._CtrlInsuredMailing = value;
      AddressResolver_MULTI ctrlInsuredMailing2 = this._CtrlInsuredMailing;
      if (ctrlInsuredMailing2 == null)
        return;
      ctrlInsuredMailing2.ZipCodeLookupCompleted += onZipEventHandler;
      ctrlInsuredMailing2.CountryChanged += eventHandler1;
      ctrlInsuredMailing2.CountryValueChanged += eventHandler2;
      ((Control) ctrlInsuredMailing2).Leave += eventHandler3;
    }
  }

  protected virtual AddressResolver_MULTI ctrlInsuredBilling
  {
    get => this._ctrlInsuredBilling;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      AddressResolver_MULTI.FocusOnZipEventHandler onZipEventHandler = new AddressResolver_MULTI.FocusOnZipEventHandler(this.CtrlInsuredBilling_ZipCodeLookupCompleted);
      EventHandler eventHandler1 = new EventHandler(this.CtrlInsuredBilling_CountryChanged);
      EventHandler eventHandler2 = new EventHandler(this.CtrlInsuredBilling_CountryChanged);
      EventHandler eventHandler3 = new EventHandler(this.ctrlInsuredBilling_Leave);
      AddressResolver_MULTI ctrlInsuredBilling1 = this._ctrlInsuredBilling;
      if (ctrlInsuredBilling1 != null)
      {
        ctrlInsuredBilling1.ZipCodeLookupCompleted -= onZipEventHandler;
        ctrlInsuredBilling1.CountryChanged -= eventHandler1;
        ctrlInsuredBilling1.CountryValueChanged -= eventHandler2;
        ((Control) ctrlInsuredBilling1).Leave -= eventHandler3;
      }
      this._ctrlInsuredBilling = value;
      AddressResolver_MULTI ctrlInsuredBilling2 = this._ctrlInsuredBilling;
      if (ctrlInsuredBilling2 == null)
        return;
      ctrlInsuredBilling2.ZipCodeLookupCompleted += onZipEventHandler;
      ctrlInsuredBilling2.CountryChanged += eventHandler1;
      ctrlInsuredBilling2.CountryValueChanged += eventHandler2;
      ((Control) ctrlInsuredBilling2).Leave += eventHandler3;
    }
  }

  protected virtual AddressResolver_MULTI CtrlBillingAddress
  {
    get => this._CtrlBillingAddress;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      AddressResolver_MULTI.FocusOnZipEventHandler onZipEventHandler = new AddressResolver_MULTI.FocusOnZipEventHandler(this.CtrlBillingAddress_ZipCodeLookupCompleted);
      EventHandler eventHandler1 = new EventHandler(this.CtrlBillingAddress_CountryChanged);
      EventHandler eventHandler2 = new EventHandler(this.CtrlBillingAddress_CountryChanged);
      EventHandler eventHandler3 = new EventHandler(this.CtrlBillingAddress_Leave);
      AddressResolver_MULTI ctrlBillingAddress1 = this._CtrlBillingAddress;
      if (ctrlBillingAddress1 != null)
      {
        ctrlBillingAddress1.ZipCodeLookupCompleted -= onZipEventHandler;
        ctrlBillingAddress1.CountryValueChanged -= eventHandler1;
        ctrlBillingAddress1.CountryChanged -= eventHandler2;
        ((Control) ctrlBillingAddress1).Leave -= eventHandler3;
      }
      this._CtrlBillingAddress = value;
      AddressResolver_MULTI ctrlBillingAddress2 = this._CtrlBillingAddress;
      if (ctrlBillingAddress2 == null)
        return;
      ctrlBillingAddress2.ZipCodeLookupCompleted += onZipEventHandler;
      ctrlBillingAddress2.CountryValueChanged += eventHandler1;
      ctrlBillingAddress2.CountryChanged += eventHandler2;
      ((Control) ctrlBillingAddress2).Leave += eventHandler3;
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
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmQuoteEdit2));
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance29 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance30 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance33 = new Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Appearance appearance34 = new Appearance();
    UltraTab ultraTab6 = new UltraTab();
    Appearance appearance35 = new Appearance();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.lblGender = new Label();
    this.cmbGender = new MGASimpleComboBox();
    this.ds = new dsQuoteEdit2();
    this.lblTaxID = new Label();
    this.txtTaxID = new MGATextBox();
    this.lblEmailLabel = new Label();
    this.txtEmail = new MGATextBox();
    this.lblRiskID = new Label();
    this.txtRiskID = new MGATextBox();
    this.cboInsuredType = new MGASimpleComboBox();
    this.Label16 = new Label();
    this.txtSSN = new MGAMaskedEdit();
    this.Label6 = new Label();
    this.txtMiddle = new MGATextBox();
    this.txtLast = new MGATextBox();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.cboSalutations = new MGASimpleComboBox();
    this.Label5 = new Label();
    this.txtDBA = new MGATextBox();
    this.txtBusiness = new MGATextBox();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.txtFEIN = new MGAMaskedEdit();
    this.txtPolicyName = new MGATextBox();
    this.lblFEIN = new Label();
    this.txtFirst = new MGATextBox();
    this.Label9 = new Label();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.CtrlInsuredMailing = new AddressResolver_MULTI();
    this.lblMobile = new Label();
    this.mmeMobileNumber = new MGAMaskedEdit();
    this.lnkShowMap = new LinkLabel();
    this.UltraMaskedEdit4 = new MGAMaskedEdit();
    this.UltraMaskedEdit3 = new MGAMaskedEdit();
    this.Label3 = new Label();
    this.lblPhone = new Label();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.ctrlInsuredBilling = new AddressResolver_MULTI();
    this.mgaTxtBillingContact = new MGATextBox();
    this.lblBillingContact = new Label();
    this.lblBillingEmail = new Label();
    this.mgaTxtBillingEmail = new MGATextBox();
    this.UltraMaskedEdit6 = new MGAMaskedEdit();
    this.UltraMaskedEdit5 = new MGAMaskedEdit();
    this.Label22 = new Label();
    this.Label23 = new Label();
    this.UltraTabPageControl4 = new UltraTabPageControl();
    this.txtLocation = new MGATextBox();
    this.txtProducerName = new MGATextBox();
    this.Label1 = new Label();
    this.Label4 = new Label();
    this.UltraTabPageControl5 = new UltraTabPageControl();
    this.ctlZipCode = new AddressResolver_MULTI();
    this.Label2 = new Label();
    this.Label7 = new Label();
    this.UltraMaskedEdit2 = new MGAMaskedEdit();
    this.UltraMaskedEdit1 = new MGAMaskedEdit();
    this.UltraTabPageControl6 = new UltraTabPageControl();
    this.CtrlBillingAddress = new AddressResolver_MULTI();
    this.UltraMaskedEdit7 = new MGAMaskedEdit();
    this.UltraMaskedEdit8 = new MGAMaskedEdit();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.btnSave = new MGAButton();
    this.daQuote = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.cnSQL = DefaultDatabase.CreateDbConnection();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.cboCostCenters = new MGASimpleComboBox();
    this.Label8 = new Label();
    this.err = new ErrorProvider(this.components);
    this.UltraGroupBox3 = new UltraGroupBox();
    this.lblPolicyIssued = new UltraLabel();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.UltraTabControl2 = new UltraTabControl();
    this.UltraTabSharedControlsPage2 = new UltraTabSharedControlsPage();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.cmbGender).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.txtTaxID).BeginInit();
    ((ISupportInitialize) this.txtEmail).BeginInit();
    ((ISupportInitialize) this.txtRiskID).BeginInit();
    ((ISupportInitialize) this.cboInsuredType).BeginInit();
    ((ISupportInitialize) this.txtSSN).BeginInit();
    ((ISupportInitialize) this.txtMiddle).BeginInit();
    ((ISupportInitialize) this.txtLast).BeginInit();
    ((ISupportInitialize) this.cboSalutations).BeginInit();
    ((ISupportInitialize) this.txtDBA).BeginInit();
    ((ISupportInitialize) this.txtBusiness).BeginInit();
    ((ISupportInitialize) this.txtFEIN).BeginInit();
    ((ISupportInitialize) this.txtPolicyName).BeginInit();
    ((ISupportInitialize) this.txtFirst).BeginInit();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.mmeMobileNumber).BeginInit();
    ((ISupportInitialize) this.UltraMaskedEdit4).BeginInit();
    ((ISupportInitialize) this.UltraMaskedEdit3).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.mgaTxtBillingContact).BeginInit();
    ((ISupportInitialize) this.mgaTxtBillingEmail).BeginInit();
    ((ISupportInitialize) this.UltraMaskedEdit6).BeginInit();
    ((ISupportInitialize) this.UltraMaskedEdit5).BeginInit();
    ((Control) this.UltraTabPageControl4).SuspendLayout();
    ((ISupportInitialize) this.txtLocation).BeginInit();
    ((ISupportInitialize) this.txtProducerName).BeginInit();
    ((Control) this.UltraTabPageControl5).SuspendLayout();
    ((ISupportInitialize) this.UltraMaskedEdit2).BeginInit();
    ((ISupportInitialize) this.UltraMaskedEdit1).BeginInit();
    ((Control) this.UltraTabPageControl6).SuspendLayout();
    ((ISupportInitialize) this.UltraMaskedEdit7).BeginInit();
    ((ISupportInitialize) this.UltraMaskedEdit8).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.cboCostCenters).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraGroupBox3).BeginInit();
    ((Control) this.UltraGroupBox3).SuspendLayout();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((ISupportInitialize) this.UltraTabControl2).BeginInit();
    ((Control) this.UltraTabControl2).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblGender);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.cmbGender);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblTaxID);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtTaxID);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblEmailLabel);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtEmail);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblRiskID);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtRiskID);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.cboInsuredType);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label16);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtSSN);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label6);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtMiddle);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtLast);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label12);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label13);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.cboSalutations);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label5);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtDBA);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtBusiness);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label10);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label11);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtFEIN);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtPolicyName);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblFEIN);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtFirst);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label9);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(521, 189);
    this.lblGender.BackColor = Color.Transparent;
    this.lblGender.Location = new Point(346, 161);
    this.lblGender.Name = "lblGender";
    this.lblGender.Size = new Size(56, 16 /*0x10*/);
    this.lblGender.TabIndex = 188;
    this.lblGender.Text = "Gender:";
    this.lblGender.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cmbGender).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cmbGender).DataSource = (object) this.ds.lstClaims_Gender;
    ((UltraDropDownBase) this.cmbGender).DisplayMember = "Gender";
    ((UltraCombo) this.cmbGender).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbGender).Location = new Point(408, 156);
    this.cmbGender.MGAStyle = (MGAStyles) 2;
    ((Control) this.cmbGender).Name = "cmbGender";
    ((Control) this.cmbGender).Size = new Size(99, 21);
    ((Control) this.cmbGender).TabIndex = 187;
    ((UltraControlBase) this.cmbGender).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbGender).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cmbGender).ValueMember = "GenderId";
    this.ds.DataSetName = "dsQuoteEdit2";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lblTaxID.BackColor = Color.Transparent;
    this.lblTaxID.Location = new Point(405, 111);
    this.lblTaxID.Name = "lblTaxID";
    this.lblTaxID.Size = new Size(54, 17);
    this.lblTaxID.TabIndex = 186;
    this.lblTaxID.Text = "Tax ID";
    this.lblTaxID.TextAlign = ContentAlignment.MiddleLeft;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTaxID).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtTaxID).BackColor = Color.White;
    ((Control) this.txtTaxID).Location = new Point(408, 130);
    ((TextEditorControlBase) this.txtTaxID).MaxLength = 15;
    this.txtTaxID.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtTaxID).Name = "txtTaxID";
    ((Control) this.txtTaxID).Size = new Size(99, 20);
    ((Control) this.txtTaxID).TabIndex = 185;
    ((UltraControlBase) this.txtTaxID).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTaxID).UseOsThemes = (DefaultableBoolean) 2;
    this.lblEmailLabel.AutoSize = true;
    this.lblEmailLabel.BackColor = Color.Transparent;
    this.lblEmailLabel.Location = new Point(56, 165);
    this.lblEmailLabel.Name = "lblEmailLabel";
    this.lblEmailLabel.Size = new Size(35, 13);
    this.lblEmailLabel.TabIndex = 184;
    this.lblEmailLabel.Text = "Email:";
    this.lblEmailLabel.TextAlign = ContentAlignment.MiddleRight;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEmail).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtEmail).BackColor = Color.White;
    ((Control) this.txtEmail).Location = new Point(104, 161);
    ((TextEditorControlBase) this.txtEmail).MaxLength = 50;
    this.txtEmail.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtEmail).Name = "txtEmail";
    ((Control) this.txtEmail).Size = new Size(192 /*0xC0*/, 20);
    ((Control) this.txtEmail).TabIndex = 10;
    ((UltraControlBase) this.txtEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.lblRiskID.BackColor = Color.Transparent;
    this.lblRiskID.Location = new Point(405, 61);
    this.lblRiskID.Name = "lblRiskID";
    this.lblRiskID.Size = new Size(53, 16 /*0x10*/);
    this.lblRiskID.TabIndex = 182;
    this.lblRiskID.Text = "Risk ID";
    this.lblRiskID.TextAlign = ContentAlignment.BottomLeft;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtRiskID).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtRiskID).BackColor = Color.White;
    ((Control) this.txtRiskID).Location = new Point(408, 83);
    this.txtRiskID.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtRiskID).Name = "txtRiskID";
    ((Control) this.txtRiskID).Size = new Size(99, 20);
    ((Control) this.txtRiskID).TabIndex = 7;
    ((UltraControlBase) this.txtRiskID).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRiskID).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboInsuredType).BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboInsuredType).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuotes.InsuredBusinessTypeID", true));
    ((UltraGridBase) this.cboInsuredType).DataSource = (object) this.ds.lstBusinessTypes;
    ((UltraDropDownBase) this.cboInsuredType).DisplayMember = "BusinessType";
    ((UltraCombo) this.cboInsuredType).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboInsuredType).Location = new Point(104, 8);
    this.cboInsuredType.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboInsuredType).Name = "cboInsuredType";
    ((Control) this.cboInsuredType).Size = new Size(272, 21);
    ((Control) this.cboInsuredType).TabIndex = 0;
    ((UltraControlBase) this.cboInsuredType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInsuredType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInsuredType).ValueMember = "BusinessTypeID";
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(56, 10);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(35, 16 /*0x10*/);
    this.Label16.TabIndex = 179;
    this.Label16.Text = "Type:";
    this.Label16.TextAlign = ContentAlignment.MiddleRight;
    appearance4.BackColorDisabled = Color.Gainsboro;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.txtSSN).Appearance = (AppearanceBase) appearance4;
    ((Control) this.txtSSN).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuotes.InsuredSSN", true));
    ((UltraMaskedEdit) this.txtSSN).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.txtSSN).InputMask = "###-##-####";
    ((Control) this.txtSSN).Location = new Point(437, 35);
    this.txtSSN.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtSSN).Name = "txtSSN";
    ((UltraMaskedEdit) this.txtSSN).NonAutoSizeHeight = 20;
    ((Control) this.txtSSN).Size = new Size(70, 21);
    ((Control) this.txtSSN).TabIndex = 3;
    ((UltraMaskedEdit) this.txtSSN).Text = "--";
    ((UltraControlBase) this.txtSSN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSSN).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(399, 34);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(32 /*0x20*/, 23);
    this.Label6.TabIndex = 163;
    this.Label6.Text = "SSN:";
    this.Label6.TextAlign = ContentAlignment.MiddleCenter;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtMiddle).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtMiddle).BackColor = Color.White;
    ((Control) this.txtMiddle).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.InsuredMiddleName", true));
    ((Control) this.txtMiddle).Enabled = false;
    ((Control) this.txtMiddle).Location = new Point(184, 83);
    this.txtMiddle.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtMiddle).Name = "txtMiddle";
    ((Control) this.txtMiddle).Size = new Size(49, 20);
    ((Control) this.txtMiddle).TabIndex = 6;
    ((UltraControlBase) this.txtMiddle).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtMiddle).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLast).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.txtLast).BackColor = Color.White;
    ((Control) this.txtLast).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.InsuredLastName", true));
    ((Control) this.txtLast).Enabled = false;
    ((Control) this.txtLast).Location = new Point(240 /*0xF0*/, 83);
    this.txtLast.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtLast).Name = "txtLast";
    ((Control) this.txtLast).Size = new Size(136, 20);
    ((Control) this.txtLast).TabIndex = 6;
    ((UltraControlBase) this.txtLast).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLast).UseOsThemes = (DefaultableBoolean) 2;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(184, 61);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(42, 16 /*0x10*/);
    this.Label12.TabIndex = 168;
    this.Label12.Text = "Middle";
    this.Label12.TextAlign = ContentAlignment.BottomLeft;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(240 /*0xF0*/, 61);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(32 /*0x20*/, 16 /*0x10*/);
    this.Label13.TabIndex = 171;
    this.Label13.Text = "Last";
    this.Label13.TextAlign = ContentAlignment.BottomLeft;
    ((UltraCombo) this.cboSalutations).BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboSalutations).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuotes.InsuredSalutation", true));
    ((UltraGridBase) this.cboSalutations).DataSource = (object) this.ds.lstSalutations;
    ((UltraDropDownBase) this.cboSalutations).DisplayMember = "Salutation";
    ((UltraCombo) this.cboSalutations).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboSalutations).Enabled = false;
    ((Control) this.cboSalutations).Location = new Point(49, 83);
    this.cboSalutations.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboSalutations).Name = "cboSalutations";
    ((Control) this.cboSalutations).Size = new Size(42, 21);
    ((Control) this.cboSalutations).TabIndex = 4;
    ((UltraControlBase) this.cboSalutations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboSalutations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboSalutations).ValueMember = "Salutation";
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(56, 111);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(35, 16 /*0x10*/);
    this.Label5.TabIndex = 173;
    this.Label5.Text = "DBA:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDBA).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.txtDBA).BackColor = Color.White;
    ((Control) this.txtDBA).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.InsuredDBA", true));
    ((Control) this.txtDBA).Location = new Point(104, 109);
    this.txtDBA.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtDBA).Name = "txtDBA";
    ((Control) this.txtDBA).Size = new Size(192 /*0xC0*/, 20);
    ((Control) this.txtDBA).TabIndex = 8;
    ((UltraControlBase) this.txtDBA).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDBA).UseOsThemes = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtBusiness).Appearance = (AppearanceBase) appearance8;
    ((TextEditorControlBase) this.txtBusiness).BackColor = Color.White;
    ((Control) this.txtBusiness).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.InsuredCorporationName", true));
    ((Control) this.txtBusiness).Enabled = false;
    ((Control) this.txtBusiness).Location = new Point(104, 35);
    ((TextEditorControlBase) this.txtBusiness).MaxLength = 250;
    this.txtBusiness.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtBusiness).Name = "txtBusiness";
    ((Control) this.txtBusiness).Size = new Size(272, 20);
    ((Control) this.txtBusiness).TabIndex = 2;
    ((UltraControlBase) this.txtBusiness).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtBusiness).UseOsThemes = (DefaultableBoolean) 2;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(104, 61);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(32 /*0x20*/, 16 /*0x10*/);
    this.Label10.TabIndex = 6;
    this.Label10.Text = "First";
    this.Label10.TextAlign = ContentAlignment.BottomLeft;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(0, 37);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(91, 16 /*0x10*/);
    this.Label11.TabIndex = 164;
    this.Label11.Text = "Business Name:";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    appearance9.BackColorDisabled = Color.Gainsboro;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.txtFEIN).Appearance = (AppearanceBase) appearance9;
    ((Control) this.txtFEIN).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuotes.InsuredFEIN", true));
    ((UltraMaskedEdit) this.txtFEIN).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.txtFEIN).InputMask = "##-#######";
    ((Control) this.txtFEIN).Location = new Point(437, 8);
    this.txtFEIN.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtFEIN).Name = "txtFEIN";
    ((UltraMaskedEdit) this.txtFEIN).NonAutoSizeHeight = 20;
    ((Control) this.txtFEIN).Size = new Size(70, 21);
    ((Control) this.txtFEIN).TabIndex = 1;
    ((UltraMaskedEdit) this.txtFEIN).Text = "-";
    ((UltraControlBase) this.txtFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFEIN).UseOsThemes = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPolicyName).Appearance = (AppearanceBase) appearance10;
    ((TextEditorControlBase) this.txtPolicyName).BackColor = Color.White;
    ((Control) this.txtPolicyName).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.InsuredPolicyName", true));
    ((Control) this.txtPolicyName).Location = new Point(104, 135);
    ((TextEditorControlBase) this.txtPolicyName).MaxLength = 500;
    this.txtPolicyName.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtPolicyName).Name = "txtPolicyName";
    ((Control) this.txtPolicyName).Size = new Size(192 /*0xC0*/, 20);
    ((Control) this.txtPolicyName).TabIndex = 9;
    ((UltraControlBase) this.txtPolicyName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPolicyName).UseOsThemes = (DefaultableBoolean) 2;
    this.lblFEIN.BackColor = Color.Transparent;
    this.lblFEIN.Location = new Point(396, 7);
    this.lblFEIN.Name = "lblFEIN";
    this.lblFEIN.Size = new Size(35, 23);
    this.lblFEIN.TabIndex = 121;
    this.lblFEIN.Text = "FEIN:";
    this.lblFEIN.TextAlign = ContentAlignment.MiddleCenter;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFirst).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.txtFirst).BackColor = Color.White;
    ((Control) this.txtFirst).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.InsuredFirstName", true));
    ((Control) this.txtFirst).Enabled = false;
    ((Control) this.txtFirst).Location = new Point(104, 83);
    this.txtFirst.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtFirst).Name = "txtFirst";
    ((Control) this.txtFirst).Size = new Size(70, 20);
    ((Control) this.txtFirst).TabIndex = 5;
    ((UltraControlBase) this.txtFirst).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFirst).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(6, 139);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(83, 13);
    this.Label9.TabIndex = 177;
    this.Label9.Text = "Name on Policy:";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.CtrlInsuredMailing);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblMobile);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.mmeMobileNumber);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkShowMap);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.UltraMaskedEdit4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.UltraMaskedEdit3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblPhone);
    ((Control) this.UltraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(521, 189);
    this.CtrlInsuredMailing.Address1 = "";
    this.CtrlInsuredMailing.Address2 = "";
    ((Control) this.CtrlInsuredMailing).BackColor = Color.Transparent;
    this.CtrlInsuredMailing.City = "";
    this.CtrlInsuredMailing.County = "";
    ((Control) this.CtrlInsuredMailing).DataBindings.Add(new Binding("Address1", (object) this.ds, "tblQuotes.InsuredAddress1", true));
    ((Control) this.CtrlInsuredMailing).DataBindings.Add(new Binding("Address2", (object) this.ds, "tblQuotes.InsuredAddress2", true));
    ((Control) this.CtrlInsuredMailing).DataBindings.Add(new Binding("City", (object) this.ds, "tblQuotes.InsuredCity", true));
    ((Control) this.CtrlInsuredMailing).DataBindings.Add(new Binding("County", (object) this.ds, "tblQuotes.InsuredCounty", true));
    ((Control) this.CtrlInsuredMailing).DataBindings.Add(new Binding("ISOCountryCode", (object) this.ds, "tblQuotes.InsuredISOCountryCode", true));
    ((Control) this.CtrlInsuredMailing).DataBindings.Add(new Binding("State", (object) this.ds, "tblQuotes.InsuredState", true));
    ((Control) this.CtrlInsuredMailing).DataBindings.Add(new Binding("ZipCode", (object) this.ds, "tblQuotes.InsuredZipCode", true));
    ((Control) this.CtrlInsuredMailing).DataBindings.Add(new Binding("ZipCodeExtension", (object) this.ds, "tblQuotes.InsuredZipPlus", true));
    ((Control) this.CtrlInsuredMailing).Font = new Font("Tahoma", 8f);
    this.CtrlInsuredMailing.ISOCountryCode = "";
    this.CtrlInsuredMailing.ISOCountryCodeMember = "";
    this.CtrlInsuredMailing.ISOCountryList = (object) null;
    this.CtrlInsuredMailing.ISOCountryNameMember = "";
    ((Control) this.CtrlInsuredMailing).Location = new Point(2, 10);
    this.CtrlInsuredMailing.MGAStyle = (MGAStyles) 2;
    ((Control) this.CtrlInsuredMailing).Name = "CtrlInsuredMailing";
    this.CtrlInsuredMailing.Password = "";
    ((Control) this.CtrlInsuredMailing).Size = new Size(257, 155);
    this.CtrlInsuredMailing.State = "";
    ((Control) this.CtrlInsuredMailing).TabIndex = 203;
    this.CtrlInsuredMailing.UserID = "";
    this.CtrlInsuredMailing.WebserviceUrl = (string) null;
    this.CtrlInsuredMailing.ZipCode = "";
    this.CtrlInsuredMailing.ZipCodeExtension = "";
    this.lblMobile.AutoSize = true;
    this.lblMobile.BackColor = Color.Transparent;
    this.lblMobile.Location = new Point(277, 71);
    this.lblMobile.Name = "lblMobile";
    this.lblMobile.Size = new Size(41, 13);
    this.lblMobile.TabIndex = 181;
    this.lblMobile.Text = "Mobile:";
    this.lblMobile.TextAlign = ContentAlignment.MiddleRight;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.mmeMobileNumber).Appearance = (AppearanceBase) appearance12;
    ((Control) this.mmeMobileNumber).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.InsuredMobileNumber", true));
    ((UltraMaskedEdit) this.mmeMobileNumber).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.mmeMobileNumber).EditAs = (EditAsType) 1;
    ((Control) this.mmeMobileNumber).Location = new Point(325, 67);
    this.mmeMobileNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.mmeMobileNumber).Name = "mmeMobileNumber";
    ((UltraMaskedEdit) this.mmeMobileNumber).NonAutoSizeHeight = 20;
    ((Control) this.mmeMobileNumber).Size = new Size(130, 21);
    ((Control) this.mmeMobileNumber).TabIndex = 3;
    ((UltraMaskedEdit) this.mmeMobileNumber).Text = "--";
    ((UltraControlBase) this.mmeMobileNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mmeMobileNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkShowMap.AutoSize = true;
    this.lnkShowMap.BackColor = Color.Transparent;
    this.lnkShowMap.Location = new Point(331, 100);
    this.lnkShowMap.Name = "lnkShowMap";
    this.lnkShowMap.Size = new Size(70, 13);
    this.lnkShowMap.TabIndex = 4;
    this.lnkShowMap.TabStop = true;
    this.lnkShowMap.Text = "Map Location";
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.UltraMaskedEdit4).Appearance = (AppearanceBase) appearance13;
    ((Control) this.UltraMaskedEdit4).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.InsuredPhone", true));
    ((UltraMaskedEdit) this.UltraMaskedEdit4).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.UltraMaskedEdit4).EditAs = (EditAsType) 1;
    ((Control) this.UltraMaskedEdit4).Location = new Point(325, 19);
    this.UltraMaskedEdit4.MGAStyle = (MGAStyles) 2;
    ((Control) this.UltraMaskedEdit4).Name = "UltraMaskedEdit4";
    ((UltraMaskedEdit) this.UltraMaskedEdit4).NonAutoSizeHeight = 20;
    ((Control) this.UltraMaskedEdit4).Size = new Size(130, 21);
    ((Control) this.UltraMaskedEdit4).TabIndex = 1;
    ((UltraMaskedEdit) this.UltraMaskedEdit4).Text = "--";
    ((UltraControlBase) this.UltraMaskedEdit4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraMaskedEdit4).UseOsThemes = (DefaultableBoolean) 2;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.UltraMaskedEdit3).Appearance = (AppearanceBase) appearance14;
    ((Control) this.UltraMaskedEdit3).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.InsuredFax", true));
    ((UltraMaskedEdit) this.UltraMaskedEdit3).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.UltraMaskedEdit3).EditAs = (EditAsType) 1;
    ((Control) this.UltraMaskedEdit3).Location = new Point(325, 43);
    this.UltraMaskedEdit3.MGAStyle = (MGAStyles) 2;
    ((Control) this.UltraMaskedEdit3).Name = "UltraMaskedEdit3";
    ((UltraMaskedEdit) this.UltraMaskedEdit3).NonAutoSizeHeight = 20;
    ((Control) this.UltraMaskedEdit3).Size = new Size(130, 21);
    ((Control) this.UltraMaskedEdit3).TabIndex = 2;
    ((UltraMaskedEdit) this.UltraMaskedEdit3).Text = "--";
    ((UltraControlBase) this.UltraMaskedEdit3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraMaskedEdit3).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(290, 47);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(29, 13);
    this.Label3.TabIndex = 171;
    this.Label3.Text = "Fax:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.lblPhone.AutoSize = true;
    this.lblPhone.BackColor = Color.Transparent;
    this.lblPhone.Location = new Point(277, 23);
    this.lblPhone.Name = "lblPhone";
    this.lblPhone.Size = new Size(41, 13);
    this.lblPhone.TabIndex = 1;
    this.lblPhone.Text = "Phone:";
    this.lblPhone.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.ctrlInsuredBilling);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.mgaTxtBillingContact);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblBillingContact);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblBillingEmail);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.mgaTxtBillingEmail);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.UltraMaskedEdit6);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.UltraMaskedEdit5);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label22);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label23);
    ((Control) this.UltraTabPageControl2).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(521, 189);
    this.ctrlInsuredBilling.Address1 = "";
    this.ctrlInsuredBilling.Address2 = "";
    ((Control) this.ctrlInsuredBilling).BackColor = Color.Transparent;
    this.ctrlInsuredBilling.City = "";
    this.ctrlInsuredBilling.County = "";
    ((Control) this.ctrlInsuredBilling).DataBindings.Add(new Binding("Address1", (object) this.ds, "tblQuotes.InsuredAddress1_Billing", true));
    ((Control) this.ctrlInsuredBilling).DataBindings.Add(new Binding("Address2", (object) this.ds, "tblQuotes.InsuredAddress2_Billing", true));
    ((Control) this.ctrlInsuredBilling).DataBindings.Add(new Binding("City", (object) this.ds, "tblQuotes.InsuredCity_Billing", true));
    ((Control) this.ctrlInsuredBilling).DataBindings.Add(new Binding("County", (object) this.ds, "tblQuotes.InsuredCounty_Billing", true));
    ((Control) this.ctrlInsuredBilling).DataBindings.Add(new Binding("ISOCountryCode", (object) this.ds, "tblQuotes.InsuredISOCountryCode_Billing", true));
    ((Control) this.ctrlInsuredBilling).DataBindings.Add(new Binding("State", (object) this.ds, "tblQuotes.InsuredState_Billing", true));
    ((Control) this.ctrlInsuredBilling).DataBindings.Add(new Binding("ZipCode", (object) this.ds, "tblQuotes.InsuredZipCode_Billing", true));
    ((Control) this.ctrlInsuredBilling).DataBindings.Add(new Binding("ZipCodeExtension", (object) this.ds, "tblQuotes.InsuredZipPlus_Billing", true));
    ((Control) this.ctrlInsuredBilling).Font = new Font("Tahoma", 8f);
    this.ctrlInsuredBilling.ISOCountryCode = "";
    this.ctrlInsuredBilling.ISOCountryCodeMember = "";
    this.ctrlInsuredBilling.ISOCountryList = (object) null;
    this.ctrlInsuredBilling.ISOCountryNameMember = "";
    ((Control) this.ctrlInsuredBilling).Location = new Point(2, 10);
    this.ctrlInsuredBilling.MGAStyle = (MGAStyles) 2;
    ((Control) this.ctrlInsuredBilling).Name = "ctrlInsuredBilling";
    this.ctrlInsuredBilling.Password = "";
    ((Control) this.ctrlInsuredBilling).Size = new Size(257, 155);
    this.ctrlInsuredBilling.State = "";
    ((Control) this.ctrlInsuredBilling).TabIndex = 205;
    this.ctrlInsuredBilling.UserID = "";
    this.ctrlInsuredBilling.WebserviceUrl = (string) null;
    this.ctrlInsuredBilling.ZipCode = "";
    this.ctrlInsuredBilling.ZipCodeExtension = "";
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((TextEditorControlBase) this.mgaTxtBillingContact).Appearance = (AppearanceBase) appearance15;
    ((TextEditorControlBase) this.mgaTxtBillingContact).BackColor = Color.White;
    ((Control) this.mgaTxtBillingContact).Location = new Point(316, 100);
    ((TextEditorControlBase) this.mgaTxtBillingContact).MaxLength = 250;
    this.mgaTxtBillingContact.MGAStyle = (MGAStyles) 2;
    ((Control) this.mgaTxtBillingContact).Name = "mgaTxtBillingContact";
    ((Control) this.mgaTxtBillingContact).Size = new Size(192 /*0xC0*/, 20);
    ((Control) this.mgaTxtBillingContact).TabIndex = 203;
    ((UltraControlBase) this.mgaTxtBillingContact).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaTxtBillingContact).UseOsThemes = (DefaultableBoolean) 2;
    this.lblBillingContact.BackColor = Color.Transparent;
    this.lblBillingContact.Location = new Point(259, 87);
    this.lblBillingContact.Name = "lblBillingContact";
    this.lblBillingContact.Size = new Size(51, 37);
    this.lblBillingContact.TabIndex = 204;
    this.lblBillingContact.Text = "Billing Contact:";
    this.lblBillingContact.TextAlign = ContentAlignment.MiddleRight;
    this.lblBillingEmail.AutoSize = true;
    this.lblBillingEmail.BackColor = Color.Transparent;
    this.lblBillingEmail.Location = new Point(268, 74);
    this.lblBillingEmail.Name = "lblBillingEmail";
    this.lblBillingEmail.Size = new Size(35, 13);
    this.lblBillingEmail.TabIndex = 202;
    this.lblBillingEmail.Text = "Email:";
    this.lblBillingEmail.TextAlign = ContentAlignment.MiddleRight;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((TextEditorControlBase) this.mgaTxtBillingEmail).Appearance = (AppearanceBase) appearance16;
    ((TextEditorControlBase) this.mgaTxtBillingEmail).BackColor = Color.White;
    ((Control) this.mgaTxtBillingEmail).Location = new Point(316, 67);
    ((TextEditorControlBase) this.mgaTxtBillingEmail).MaxLength = 50;
    this.mgaTxtBillingEmail.MGAStyle = (MGAStyles) 2;
    ((Control) this.mgaTxtBillingEmail).Name = "mgaTxtBillingEmail";
    ((Control) this.mgaTxtBillingEmail).Size = new Size(192 /*0xC0*/, 20);
    ((Control) this.mgaTxtBillingEmail).TabIndex = 201;
    ((UltraControlBase) this.mgaTxtBillingEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaTxtBillingEmail).UseOsThemes = (DefaultableBoolean) 2;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.UltraMaskedEdit6).Appearance = (AppearanceBase) appearance17;
    ((Control) this.UltraMaskedEdit6).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.InsuredFax_Billing", true));
    ((UltraMaskedEdit) this.UltraMaskedEdit6).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.UltraMaskedEdit6).EditAs = (EditAsType) 1;
    ((Control) this.UltraMaskedEdit6).Location = new Point(316, 40);
    this.UltraMaskedEdit6.MGAStyle = (MGAStyles) 2;
    ((Control) this.UltraMaskedEdit6).Name = "UltraMaskedEdit6";
    ((UltraMaskedEdit) this.UltraMaskedEdit6).NonAutoSizeHeight = 20;
    ((Control) this.UltraMaskedEdit6).Size = new Size(130, 21);
    ((Control) this.UltraMaskedEdit6).TabIndex = 197;
    ((UltraMaskedEdit) this.UltraMaskedEdit6).Text = "--";
    ((UltraControlBase) this.UltraMaskedEdit6).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraMaskedEdit6).UseOsThemes = (DefaultableBoolean) 2;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.UltraMaskedEdit5).Appearance = (AppearanceBase) appearance18;
    ((Control) this.UltraMaskedEdit5).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.InsuredPhone_Billing", true));
    ((UltraMaskedEdit) this.UltraMaskedEdit5).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.UltraMaskedEdit5).EditAs = (EditAsType) 1;
    ((Control) this.UltraMaskedEdit5).Location = new Point(316, 16 /*0x10*/);
    this.UltraMaskedEdit5.MGAStyle = (MGAStyles) 2;
    ((Control) this.UltraMaskedEdit5).Name = "UltraMaskedEdit5";
    ((UltraMaskedEdit) this.UltraMaskedEdit5).NonAutoSizeHeight = 20;
    ((Control) this.UltraMaskedEdit5).Size = new Size(130, 21);
    ((Control) this.UltraMaskedEdit5).TabIndex = 196;
    ((UltraMaskedEdit) this.UltraMaskedEdit5).Text = "--";
    ((UltraControlBase) this.UltraMaskedEdit5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraMaskedEdit5).UseOsThemes = (DefaultableBoolean) 2;
    this.Label22.AutoSize = true;
    this.Label22.BackColor = Color.Transparent;
    this.Label22.Location = new Point(274, 48 /*0x30*/);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(29, 13);
    this.Label22.TabIndex = 193;
    this.Label22.Text = "Fax:";
    this.Label22.TextAlign = ContentAlignment.MiddleRight;
    this.Label23.AutoSize = true;
    this.Label23.BackColor = Color.Transparent;
    this.Label23.Location = new Point(268, 20);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(41, 13);
    this.Label23.TabIndex = 191;
    this.Label23.Text = "Phone:";
    this.Label23.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.txtLocation);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.txtProducerName);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Label1);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Label4);
    ((Control) this.UltraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(519, 158);
    appearance19.BackColor = Color.White;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance19.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLocation).Appearance = (AppearanceBase) appearance19;
    ((TextEditorControlBase) this.txtLocation).BackColor = Color.White;
    ((Control) this.txtLocation).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.ProducerName", true));
    ((Control) this.txtLocation).Location = new Point(72, 16 /*0x10*/);
    this.txtLocation.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtLocation).Name = "txtLocation";
    ((Control) this.txtLocation).Size = new Size(432, 20);
    ((Control) this.txtLocation).TabIndex = 133;
    ((UltraControlBase) this.txtLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLocation).UseOsThemes = (DefaultableBoolean) 2;
    appearance20.BackColor = Color.White;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance20.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtProducerName).Appearance = (AppearanceBase) appearance20;
    ((TextEditorControlBase) this.txtProducerName).BackColor = Color.White;
    ((Control) this.txtProducerName).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.ProducerLocationName", true));
    ((Control) this.txtProducerName).Location = new Point(72, 40);
    this.txtProducerName.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtProducerName).Name = "txtProducerName";
    ((Control) this.txtProducerName).Size = new Size(432, 20);
    ((Control) this.txtProducerName).TabIndex = 134;
    ((UltraControlBase) this.txtProducerName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducerName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(8, 18);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(54, 13);
    this.Label1.TabIndex = 141;
    this.Label1.Text = "Producer:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(16 /*0x10*/, 42);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(47, 13);
    this.Label4.TabIndex = 140;
    this.Label4.Text = "Location";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.ctlZipCode);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.Label2);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.Label7);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.UltraMaskedEdit2);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.UltraMaskedEdit1);
    ((Control) this.UltraTabPageControl5).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl5).Name = "UltraTabPageControl5";
    ((Control) this.UltraTabPageControl5).Size = new Size(519, 158);
    this.ctlZipCode.Address1 = "";
    this.ctlZipCode.Address2 = "";
    ((Control) this.ctlZipCode).BackColor = Color.Transparent;
    this.ctlZipCode.City = "";
    this.ctlZipCode.County = "";
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("Address1", (object) this.ds, "tblQuotes.ProducerAddress1", true));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("Address2", (object) this.ds, "tblQuotes.ProducerAddress2", true));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("City", (object) this.ds, "tblQuotes.ProducerCity", true));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("County", (object) this.ds, "tblQuotes.ProducerCounty", true));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("State", (object) this.ds, "tblQuotes.ProducerState", true));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("ZipCode", (object) this.ds, "tblQuotes.ProducerZipCode", true));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("ZipCodeExtension", (object) this.ds, "tblQuotes.ProducerZipPlus", true));
    ((Control) this.ctlZipCode).DataBindings.Add(new Binding("ISOCountryCode", (object) this.ds, "tblQuotes.ProducerISOCountryCode", true));
    ((Control) this.ctlZipCode).Font = new Font("Tahoma", 8f);
    this.ctlZipCode.ISOCountryCode = "";
    this.ctlZipCode.ISOCountryCodeMember = "";
    this.ctlZipCode.ISOCountryList = (object) null;
    this.ctlZipCode.ISOCountryNameMember = "";
    ((Control) this.ctlZipCode).Location = new Point(2, 3);
    this.ctlZipCode.MGAStyle = (MGAStyles) 2;
    ((Control) this.ctlZipCode).Name = "ctlZipCode";
    this.ctlZipCode.Password = "";
    ((Control) this.ctlZipCode).Size = new Size(257, 155);
    this.ctlZipCode.State = "";
    ((Control) this.ctlZipCode).TabIndex = 143;
    this.ctlZipCode.UserID = "";
    this.ctlZipCode.WebserviceUrl = (string) null;
    this.ctlZipCode.ZipCode = "";
    this.ctlZipCode.ZipCodeExtension = "";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(288, 36);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(29, 13);
    this.Label2.TabIndex = 139;
    this.Label2.Text = "Fax:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(275, 12);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(41, 13);
    this.Label7.TabIndex = 138;
    this.Label7.Text = "Phone:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance21.TextTrimming = (TextTrimming) 2;
    ((UltraMaskedEdit) this.UltraMaskedEdit2).Appearance = (AppearanceBase) appearance21;
    ((Control) this.UltraMaskedEdit2).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.ProducerPhone", true));
    ((UltraMaskedEdit) this.UltraMaskedEdit2).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.UltraMaskedEdit2).EditAs = (EditAsType) 1;
    ((Control) this.UltraMaskedEdit2).Location = new Point(328, 8);
    this.UltraMaskedEdit2.MGAStyle = (MGAStyles) 2;
    ((Control) this.UltraMaskedEdit2).Name = "UltraMaskedEdit2";
    ((UltraMaskedEdit) this.UltraMaskedEdit2).NonAutoSizeHeight = 20;
    ((Control) this.UltraMaskedEdit2).Size = new Size(130, 21);
    ((Control) this.UltraMaskedEdit2).TabIndex = 136;
    ((UltraMaskedEdit) this.UltraMaskedEdit2).Text = "--";
    ((UltraControlBase) this.UltraMaskedEdit2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraMaskedEdit2).UseOsThemes = (DefaultableBoolean) 2;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.UltraMaskedEdit1).Appearance = (AppearanceBase) appearance22;
    ((Control) this.UltraMaskedEdit1).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.ProducerFax", true));
    ((UltraMaskedEdit) this.UltraMaskedEdit1).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.UltraMaskedEdit1).EditAs = (EditAsType) 1;
    ((Control) this.UltraMaskedEdit1).Location = new Point(328, 32 /*0x20*/);
    this.UltraMaskedEdit1.MGAStyle = (MGAStyles) 2;
    ((Control) this.UltraMaskedEdit1).Name = "UltraMaskedEdit1";
    ((UltraMaskedEdit) this.UltraMaskedEdit1).NonAutoSizeHeight = 20;
    ((Control) this.UltraMaskedEdit1).Size = new Size(130, 21);
    ((Control) this.UltraMaskedEdit1).TabIndex = 137;
    ((UltraMaskedEdit) this.UltraMaskedEdit1).Text = "--";
    ((UltraControlBase) this.UltraMaskedEdit1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraMaskedEdit1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl6).Controls.Add((Control) this.CtrlBillingAddress);
    ((Control) this.UltraTabPageControl6).Controls.Add((Control) this.UltraMaskedEdit7);
    ((Control) this.UltraTabPageControl6).Controls.Add((Control) this.UltraMaskedEdit8);
    ((Control) this.UltraTabPageControl6).Controls.Add((Control) this.Label14);
    ((Control) this.UltraTabPageControl6).Controls.Add((Control) this.Label15);
    ((Control) this.UltraTabPageControl6).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl6).Name = "UltraTabPageControl6";
    ((Control) this.UltraTabPageControl6).Size = new Size(519, 158);
    this.CtrlBillingAddress.Address1 = "";
    this.CtrlBillingAddress.Address2 = "";
    ((Control) this.CtrlBillingAddress).BackColor = Color.Transparent;
    this.CtrlBillingAddress.City = "";
    this.CtrlBillingAddress.County = "";
    ((Control) this.CtrlBillingAddress).DataBindings.Add(new Binding("Address1", (object) this.ds, "tblQuotes.ProducerAddress1_Billing", true));
    ((Control) this.CtrlBillingAddress).DataBindings.Add(new Binding("Address2", (object) this.ds, "tblQuotes.ProducerAddress2_Billing", true));
    ((Control) this.CtrlBillingAddress).DataBindings.Add(new Binding("City", (object) this.ds, "tblQuotes.ProducerCity_Billing", true));
    ((Control) this.CtrlBillingAddress).DataBindings.Add(new Binding("County", (object) this.ds, "tblQuotes.ProducerCounty_Billing", true));
    ((Control) this.CtrlBillingAddress).DataBindings.Add(new Binding("ISOCountryCode", (object) this.ds, "tblQuotes.ProducerISOCountryCode_Billing", true));
    ((Control) this.CtrlBillingAddress).DataBindings.Add(new Binding("State", (object) this.ds, "tblQuotes.ProducerState_Billing", true));
    ((Control) this.CtrlBillingAddress).DataBindings.Add(new Binding("ZipCode", (object) this.ds, "tblQuotes.ProducerZipCode_Billing", true));
    ((Control) this.CtrlBillingAddress).DataBindings.Add(new Binding("ZipCodeExtension", (object) this.ds, "tblQuotes.ProducerZipPlus_Billing", true));
    ((Control) this.CtrlBillingAddress).Font = new Font("Tahoma", 8f);
    this.CtrlBillingAddress.ISOCountryCode = "";
    this.CtrlBillingAddress.ISOCountryCodeMember = "";
    this.CtrlBillingAddress.ISOCountryList = (object) null;
    this.CtrlBillingAddress.ISOCountryNameMember = "";
    ((Control) this.CtrlBillingAddress).Location = new Point(2, 3);
    this.CtrlBillingAddress.MGAStyle = (MGAStyles) 2;
    ((Control) this.CtrlBillingAddress).Name = "CtrlBillingAddress";
    this.CtrlBillingAddress.Password = "";
    ((Control) this.CtrlBillingAddress).Size = new Size(257, 155);
    this.CtrlBillingAddress.State = "";
    ((Control) this.CtrlBillingAddress).TabIndex = 202;
    this.CtrlBillingAddress.UserID = "";
    this.CtrlBillingAddress.WebserviceUrl = (string) null;
    this.CtrlBillingAddress.ZipCode = "";
    this.CtrlBillingAddress.ZipCodeExtension = "";
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.UltraMaskedEdit7).Appearance = (AppearanceBase) appearance23;
    ((Control) this.UltraMaskedEdit7).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.ProducerFax_Billing", true));
    ((UltraMaskedEdit) this.UltraMaskedEdit7).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.UltraMaskedEdit7).EditAs = (EditAsType) 1;
    ((Control) this.UltraMaskedEdit7).Location = new Point(328, 32 /*0x20*/);
    this.UltraMaskedEdit7.MGAStyle = (MGAStyles) 2;
    ((Control) this.UltraMaskedEdit7).Name = "UltraMaskedEdit7";
    ((UltraMaskedEdit) this.UltraMaskedEdit7).NonAutoSizeHeight = 20;
    ((Control) this.UltraMaskedEdit7).Size = new Size(130, 21);
    ((Control) this.UltraMaskedEdit7).TabIndex = 201;
    ((UltraMaskedEdit) this.UltraMaskedEdit7).Text = "--";
    ((UltraControlBase) this.UltraMaskedEdit7).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraMaskedEdit7).UseOsThemes = (DefaultableBoolean) 2;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.UltraMaskedEdit8).Appearance = (AppearanceBase) appearance24;
    ((Control) this.UltraMaskedEdit8).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuotes.ProducerPhone_Billing", true));
    ((UltraMaskedEdit) this.UltraMaskedEdit8).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.UltraMaskedEdit8).EditAs = (EditAsType) 1;
    ((Control) this.UltraMaskedEdit8).Location = new Point(328, 8);
    this.UltraMaskedEdit8.MGAStyle = (MGAStyles) 2;
    ((Control) this.UltraMaskedEdit8).Name = "UltraMaskedEdit8";
    ((UltraMaskedEdit) this.UltraMaskedEdit8).NonAutoSizeHeight = 20;
    ((Control) this.UltraMaskedEdit8).Size = new Size(130, 21);
    ((Control) this.UltraMaskedEdit8).TabIndex = 200;
    ((UltraMaskedEdit) this.UltraMaskedEdit8).Text = "--";
    ((UltraControlBase) this.UltraMaskedEdit8).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraMaskedEdit8).UseOsThemes = (DefaultableBoolean) 2;
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(288, 36);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(29, 13);
    this.Label14.TabIndex = 199;
    this.Label14.Text = "Fax:";
    this.Label14.TextAlign = ContentAlignment.MiddleRight;
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(275, 12);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(41, 13);
    this.Label15.TabIndex = 198;
    this.Label15.Text = "Phone:";
    this.Label15.TextAlign = ContentAlignment.MiddleRight;
    appearance25.BackColor = Color.FromArgb(248, 248, 248);
    appearance25.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance25.BackGradientStyle = (GradientStyle) 2;
    appearance25.BorderColor = Color.DarkGray;
    appearance25.ImageHAlign = (HAlign) 2;
    appearance25.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance25;
    ((Control) this.btnSave).Location = new Point(487, 484);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 0;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.daQuote.AcceptChangesDuringUpdate = false;
    this.daQuote.DeleteCommand = this.DbDeleteCommand1;
    this.daQuote.InsertCommand = this.DbInsertCommand1;
    this.daQuote.SelectCommand = this.DbSelectCommand1;
    this.daQuote.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuotes", new DataColumnMapping[57]
      {
        new DataColumnMapping("QuoteGUID", "QuoteGUID"),
        new DataColumnMapping("InsuredDBA", "InsuredDBA"),
        new DataColumnMapping("InsuredFEIN", "InsuredFEIN"),
        new DataColumnMapping("InsuredSSN", "InsuredSSN"),
        new DataColumnMapping("InsuredCorporationName", "InsuredCorporationName"),
        new DataColumnMapping("InsuredPolicyName", "InsuredPolicyName"),
        new DataColumnMapping("InsuredSalutation", "InsuredSalutation"),
        new DataColumnMapping("InsuredFirstName", "InsuredFirstName"),
        new DataColumnMapping("InsuredMiddleName", "InsuredMiddleName"),
        new DataColumnMapping("InsuredLastName", "InsuredLastName"),
        new DataColumnMapping("InsuredCounty", "InsuredCounty"),
        new DataColumnMapping("InsuredCity", "InsuredCity"),
        new DataColumnMapping("InsuredAddress1", "InsuredAddress1"),
        new DataColumnMapping("InsuredAddress2", "InsuredAddress2"),
        new DataColumnMapping("InsuredState", "InsuredState"),
        new DataColumnMapping("InsuredZipCode", "InsuredZipCode"),
        new DataColumnMapping("InsuredZipPlus", "InsuredZipPlus"),
        new DataColumnMapping("InsuredPhone", "InsuredPhone"),
        new DataColumnMapping("InsuredFax", "InsuredFax"),
        new DataColumnMapping("ProducerFax", "ProducerFax"),
        new DataColumnMapping("ProducerPhone", "ProducerPhone"),
        new DataColumnMapping("ProducerZipPlus", "ProducerZipPlus"),
        new DataColumnMapping("ProducerZipCode", "ProducerZipCode"),
        new DataColumnMapping("ProducerCounty", "ProducerCounty"),
        new DataColumnMapping("ProducerState", "ProducerState"),
        new DataColumnMapping("ProducerCity", "ProducerCity"),
        new DataColumnMapping("ProducerAddress2", "ProducerAddress2"),
        new DataColumnMapping("ProducerAddress1", "ProducerAddress1"),
        new DataColumnMapping("ProducerLocationName", "ProducerLocationName"),
        new DataColumnMapping("ProducerName", "ProducerName"),
        new DataColumnMapping("CostCenterID", "CostCenterID"),
        new DataColumnMapping("InsuredAddress1_Billing", "InsuredAddress1_Billing"),
        new DataColumnMapping("InsuredAddress2_Billing", "InsuredAddress2_Billing"),
        new DataColumnMapping("InsuredCity_Billing", "InsuredCity_Billing"),
        new DataColumnMapping("InsuredCounty_Billing", "InsuredCounty_Billing"),
        new DataColumnMapping("InsuredState_Billing", "InsuredState_Billing"),
        new DataColumnMapping("InsuredISOCountryCode_Billing", "InsuredISOCountryCode_Billing"),
        new DataColumnMapping("InsuredRegion_Billing", "InsuredRegion_Billing"),
        new DataColumnMapping("InsuredZipCode_Billing", "InsuredZipCode_Billing"),
        new DataColumnMapping("InsuredZipPlus_Billing", "InsuredZipPlus_Billing"),
        new DataColumnMapping("InsuredPhone_Billing", "InsuredPhone_Billing"),
        new DataColumnMapping("InsuredFax_Billing", "InsuredFax_Billing"),
        new DataColumnMapping("InsuredISOCountryCode", "InsuredISOCountryCode"),
        new DataColumnMapping("ProducerISOCountryCode", "ProducerISOCountryCode"),
        new DataColumnMapping("InsuredRegion", "InsuredRegion"),
        new DataColumnMapping("ProducerAddress1_Billing", "ProducerAddress1_Billing"),
        new DataColumnMapping("ProducerAddress2_Billing", "ProducerAddress2_Billing"),
        new DataColumnMapping("ProducerCity_Billing", "ProducerCity_Billing"),
        new DataColumnMapping("ProducerCounty_Billing", "ProducerCounty_Billing"),
        new DataColumnMapping("ProducerState_Billing", "ProducerState_Billing"),
        new DataColumnMapping("ProducerISOCountryCode_Billing", "ProducerISOCountryCode_Billing"),
        new DataColumnMapping("ProducerRegion_Billing", "ProducerRegion_Billing"),
        new DataColumnMapping("ProducerZipCode_Billing", "ProducerZipCode_Billing"),
        new DataColumnMapping("ProducerZipPlus_Billing", "ProducerZipPlus_Billing"),
        new DataColumnMapping("ProducerPhone_Billing", "ProducerPhone_Billing"),
        new DataColumnMapping("ProducerFax_Billing", "ProducerFax_Billing"),
        new DataColumnMapping("InsuredBusinessTypeID", "InsuredBusinessTypeID")
      })
    });
    this.daQuote.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = "DELETE FROM tblQuotes WHERE (QuoteGUID = @Original_QuoteGUID)";
    this.DbDeleteCommand1.Connection = this.cnSQL;
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteGUID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Connection = this.cnSQL;
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[58]
    {
      DefaultDatabase.CreateParameter("@QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      DefaultDatabase.CreateParameter("@InsuredDBA", SqlDbType.VarChar, 500, "InsuredDBA"),
      DefaultDatabase.CreateParameter("@InsuredFEIN", SqlDbType.VarChar, 12, "InsuredFEIN"),
      DefaultDatabase.CreateParameter("@InsuredSSN", SqlDbType.VarChar, 11, "InsuredSSN"),
      DefaultDatabase.CreateParameter("@InsuredCorporationName", SqlDbType.VarChar, 500, "InsuredCorporationName"),
      DefaultDatabase.CreateParameter("@InsuredPolicyName", SqlDbType.VarChar, 500, "InsuredPolicyName"),
      DefaultDatabase.CreateParameter("@InsuredSalutation", SqlDbType.VarChar, 4, "InsuredSalutation"),
      DefaultDatabase.CreateParameter("@InsuredFirstName", SqlDbType.VarChar, 50, "InsuredFirstName"),
      DefaultDatabase.CreateParameter("@InsuredMiddleName", SqlDbType.VarChar, 50, "InsuredMiddleName"),
      DefaultDatabase.CreateParameter("@InsuredLastName", SqlDbType.VarChar, 50, "InsuredLastName"),
      DefaultDatabase.CreateParameter("@InsuredCounty", SqlDbType.VarChar, 50, "InsuredCounty"),
      DefaultDatabase.CreateParameter("@InsuredCity", SqlDbType.VarChar, 50, "InsuredCity"),
      DefaultDatabase.CreateParameter("@InsuredAddress1", SqlDbType.VarChar, 250, "InsuredAddress1"),
      DefaultDatabase.CreateParameter("@InsuredAddress2", SqlDbType.VarChar, 250, "InsuredAddress2"),
      DefaultDatabase.CreateParameter("@InsuredState", SqlDbType.Char, 2, "InsuredState"),
      DefaultDatabase.CreateParameter("@InsuredZipCode", SqlDbType.VarChar, 15, "InsuredZipCode"),
      DefaultDatabase.CreateParameter("@InsuredZipPlus", SqlDbType.Char, 4, "InsuredZipPlus"),
      DefaultDatabase.CreateParameter("@InsuredPhone", SqlDbType.VarChar, 12, "InsuredPhone"),
      DefaultDatabase.CreateParameter("@InsuredFax", SqlDbType.VarChar, 12, "InsuredFax"),
      DefaultDatabase.CreateParameter("@ProducerFax", SqlDbType.VarChar, 20, "ProducerFax"),
      DefaultDatabase.CreateParameter("@ProducerPhone", SqlDbType.VarChar, 20, "ProducerPhone"),
      DefaultDatabase.CreateParameter("@ProducerZipPlus", SqlDbType.Char, 4, "ProducerZipPlus"),
      DefaultDatabase.CreateParameter("@ProducerZipCode", SqlDbType.VarChar, 15, "ProducerZipCode"),
      DefaultDatabase.CreateParameter("@ProducerCounty", SqlDbType.VarChar, 50, "ProducerCounty"),
      DefaultDatabase.CreateParameter("@ProducerState", SqlDbType.Char, 2, "ProducerState"),
      DefaultDatabase.CreateParameter("@ProducerCity", SqlDbType.VarChar, 50, "ProducerCity"),
      DefaultDatabase.CreateParameter("@ProducerAddress2", SqlDbType.VarChar, 250, "ProducerAddress2"),
      DefaultDatabase.CreateParameter("@ProducerAddress1", SqlDbType.VarChar, 250, "ProducerAddress1"),
      DefaultDatabase.CreateParameter("@ProducerLocationName", SqlDbType.VarChar, 300, "ProducerLocationName"),
      DefaultDatabase.CreateParameter("@ProducerName", SqlDbType.VarChar, 300, "ProducerName"),
      DefaultDatabase.CreateParameter("@CostCenterID", SqlDbType.Int, 4, "CostCenterID"),
      DefaultDatabase.CreateParameter("@InsuredAddress1_Billing", SqlDbType.VarChar, 250, "InsuredAddress1_Billing"),
      DefaultDatabase.CreateParameter("@InsuredAddress2_Billing", SqlDbType.VarChar, 250, "InsuredAddress2_Billing"),
      DefaultDatabase.CreateParameter("@InsuredCity_Billing", SqlDbType.VarChar, 50, "InsuredCity_Billing"),
      DefaultDatabase.CreateParameter("@InsuredCounty_Billing", SqlDbType.VarChar, 50, "InsuredCounty_Billing"),
      DefaultDatabase.CreateParameter("@InsuredState_Billing", SqlDbType.Char, 2, "InsuredState_Billing"),
      DefaultDatabase.CreateParameter("@InsuredISOCountryCode_Billing", SqlDbType.Char, 3, "InsuredISOCountryCode_Billing"),
      DefaultDatabase.CreateParameter("@InsuredRegion_Billing", SqlDbType.VarChar, 50, "InsuredRegion_Billing"),
      DefaultDatabase.CreateParameter("@InsuredZipCode_Billing", SqlDbType.VarChar, 15, "InsuredZipCode_Billing"),
      DefaultDatabase.CreateParameter("@InsuredZipPlus_Billing", SqlDbType.Char, 4, "InsuredZipPlus_Billing"),
      DefaultDatabase.CreateParameter("@InsuredPhone_Billing", SqlDbType.VarChar, 12, "InsuredPhone_Billing"),
      DefaultDatabase.CreateParameter("@InsuredFax_Billing", SqlDbType.VarChar, 12, "InsuredFax_Billing"),
      DefaultDatabase.CreateParameter("@InsuredISOCountryCode", SqlDbType.Char, 3, "InsuredISOCountryCode"),
      DefaultDatabase.CreateParameter("@ProducerISOCountryCode", SqlDbType.Char, 3, "ProducerISOCountryCode"),
      DefaultDatabase.CreateParameter("@InsuredRegion", SqlDbType.VarChar, 50, "InsuredRegion"),
      DefaultDatabase.CreateParameter("@ProducerAddress1_Billing", SqlDbType.VarChar, 250, "ProducerAddress1_Billing"),
      DefaultDatabase.CreateParameter("@ProducerAddress2_Billing", SqlDbType.VarChar, 250, "ProducerAddress2_Billing"),
      DefaultDatabase.CreateParameter("@ProducerCity_Billing", SqlDbType.VarChar, 50, "ProducerCity_Billing"),
      DefaultDatabase.CreateParameter("@ProducerCounty_Billing", SqlDbType.VarChar, 50, "ProducerCounty_Billing"),
      DefaultDatabase.CreateParameter("@ProducerState_Billing", SqlDbType.Char, 2, "ProducerState_Billing"),
      DefaultDatabase.CreateParameter("@ProducerISOCountryCode_Billing", SqlDbType.Char, 3, "ProducerISOCountryCode_Billing"),
      DefaultDatabase.CreateParameter("@ProducerRegion_Billing", SqlDbType.VarChar, 50, "ProducerRegion_Billing"),
      DefaultDatabase.CreateParameter("@ProducerZipCode_Billing", SqlDbType.VarChar, 15, "ProducerZipCode_Billing"),
      DefaultDatabase.CreateParameter("@ProducerZipPlus_Billing", SqlDbType.Char, 4, "ProducerZipPlus_Billing"),
      DefaultDatabase.CreateParameter("@ProducerPhone_Billing", SqlDbType.VarChar, 20, "ProducerPhone_Billing"),
      DefaultDatabase.CreateParameter("@ProducerFax_Billing", SqlDbType.VarChar, 20, "ProducerFax_Billing"),
      DefaultDatabase.CreateParameter("@InsuredBusinessTypeID", SqlDbType.TinyInt, 1, "InsuredBusinessTypeID"),
      DefaultDatabase.CreateParameter("@InsuredMobileNumber", SqlDbType.VarChar, 12, "InsuredMobileNumber")
    });
    this.DbSelectCommand1.CommandText = componentResourceManager.GetString("DbSelectCommand1.CommandText");
    this.DbSelectCommand1.Connection = this.cnSQL;
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID")
    });
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Connection = this.cnSQL;
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[59]
    {
      DefaultDatabase.CreateParameter("@QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      DefaultDatabase.CreateParameter("@InsuredDBA", SqlDbType.VarChar, 500, "InsuredDBA"),
      DefaultDatabase.CreateParameter("@InsuredFEIN", SqlDbType.VarChar, 12, "InsuredFEIN"),
      DefaultDatabase.CreateParameter("@InsuredSSN", SqlDbType.VarChar, 11, "InsuredSSN"),
      DefaultDatabase.CreateParameter("@InsuredCorporationName", SqlDbType.VarChar, 500, "InsuredCorporationName"),
      DefaultDatabase.CreateParameter("@InsuredPolicyName", SqlDbType.VarChar, 500, "InsuredPolicyName"),
      DefaultDatabase.CreateParameter("@InsuredSalutation", SqlDbType.VarChar, 4, "InsuredSalutation"),
      DefaultDatabase.CreateParameter("@InsuredFirstName", SqlDbType.VarChar, 50, "InsuredFirstName"),
      DefaultDatabase.CreateParameter("@InsuredMiddleName", SqlDbType.VarChar, 50, "InsuredMiddleName"),
      DefaultDatabase.CreateParameter("@InsuredLastName", SqlDbType.VarChar, 50, "InsuredLastName"),
      DefaultDatabase.CreateParameter("@InsuredCounty", SqlDbType.VarChar, 50, "InsuredCounty"),
      DefaultDatabase.CreateParameter("@InsuredCity", SqlDbType.VarChar, 50, "InsuredCity"),
      DefaultDatabase.CreateParameter("@InsuredAddress1", SqlDbType.VarChar, 250, "InsuredAddress1"),
      DefaultDatabase.CreateParameter("@InsuredAddress2", SqlDbType.VarChar, 250, "InsuredAddress2"),
      DefaultDatabase.CreateParameter("@InsuredState", SqlDbType.Char, 2, "InsuredState"),
      DefaultDatabase.CreateParameter("@InsuredZipCode", SqlDbType.VarChar, 15, "InsuredZipCode"),
      DefaultDatabase.CreateParameter("@InsuredZipPlus", SqlDbType.Char, 4, "InsuredZipPlus"),
      DefaultDatabase.CreateParameter("@InsuredPhone", SqlDbType.VarChar, 12, "InsuredPhone"),
      DefaultDatabase.CreateParameter("@InsuredFax", SqlDbType.VarChar, 12, "InsuredFax"),
      DefaultDatabase.CreateParameter("@ProducerFax", SqlDbType.VarChar, 20, "ProducerFax"),
      DefaultDatabase.CreateParameter("@ProducerPhone", SqlDbType.VarChar, 20, "ProducerPhone"),
      DefaultDatabase.CreateParameter("@ProducerZipPlus", SqlDbType.Char, 4, "ProducerZipPlus"),
      DefaultDatabase.CreateParameter("@ProducerZipCode", SqlDbType.VarChar, 15, "ProducerZipCode"),
      DefaultDatabase.CreateParameter("@ProducerCounty", SqlDbType.VarChar, 50, "ProducerCounty"),
      DefaultDatabase.CreateParameter("@ProducerState", SqlDbType.Char, 2, "ProducerState"),
      DefaultDatabase.CreateParameter("@ProducerCity", SqlDbType.VarChar, 50, "ProducerCity"),
      DefaultDatabase.CreateParameter("@ProducerAddress2", SqlDbType.VarChar, 250, "ProducerAddress2"),
      DefaultDatabase.CreateParameter("@ProducerAddress1", SqlDbType.VarChar, 250, "ProducerAddress1"),
      DefaultDatabase.CreateParameter("@ProducerLocationName", SqlDbType.VarChar, 300, "ProducerLocationName"),
      DefaultDatabase.CreateParameter("@ProducerName", SqlDbType.VarChar, 300, "ProducerName"),
      DefaultDatabase.CreateParameter("@CostCenterID", SqlDbType.Int, 4, "CostCenterID"),
      DefaultDatabase.CreateParameter("@InsuredAddress1_Billing", SqlDbType.VarChar, 250, "InsuredAddress1_Billing"),
      DefaultDatabase.CreateParameter("@InsuredAddress2_Billing", SqlDbType.VarChar, 250, "InsuredAddress2_Billing"),
      DefaultDatabase.CreateParameter("@InsuredCity_Billing", SqlDbType.VarChar, 50, "InsuredCity_Billing"),
      DefaultDatabase.CreateParameter("@InsuredCounty_Billing", SqlDbType.VarChar, 50, "InsuredCounty_Billing"),
      DefaultDatabase.CreateParameter("@InsuredState_Billing", SqlDbType.Char, 2, "InsuredState_Billing"),
      DefaultDatabase.CreateParameter("@InsuredISOCountryCode_Billing", SqlDbType.Char, 3, "InsuredISOCountryCode_Billing"),
      DefaultDatabase.CreateParameter("@InsuredRegion_Billing", SqlDbType.VarChar, 50, "InsuredRegion_Billing"),
      DefaultDatabase.CreateParameter("@InsuredZipCode_Billing", SqlDbType.VarChar, 15, "InsuredZipCode_Billing"),
      DefaultDatabase.CreateParameter("@InsuredZipPlus_Billing", SqlDbType.Char, 4, "InsuredZipPlus_Billing"),
      DefaultDatabase.CreateParameter("@InsuredPhone_Billing", SqlDbType.VarChar, 12, "InsuredPhone_Billing"),
      DefaultDatabase.CreateParameter("@InsuredFax_Billing", SqlDbType.VarChar, 12, "InsuredFax_Billing"),
      DefaultDatabase.CreateParameter("@InsuredISOCountryCode", SqlDbType.Char, 3, "InsuredISOCountryCode"),
      DefaultDatabase.CreateParameter("@ProducerISOCountryCode", SqlDbType.Char, 3, "ProducerISOCountryCode"),
      DefaultDatabase.CreateParameter("@InsuredRegion", SqlDbType.VarChar, 50, "InsuredRegion"),
      DefaultDatabase.CreateParameter("@ProducerAddress1_Billing", SqlDbType.VarChar, 250, "ProducerAddress1_Billing"),
      DefaultDatabase.CreateParameter("@ProducerAddress2_Billing", SqlDbType.VarChar, 250, "ProducerAddress2_Billing"),
      DefaultDatabase.CreateParameter("@ProducerCity_Billing", SqlDbType.VarChar, 50, "ProducerCity_Billing"),
      DefaultDatabase.CreateParameter("@ProducerCounty_Billing", SqlDbType.VarChar, 50, "ProducerCounty_Billing"),
      DefaultDatabase.CreateParameter("@ProducerState_Billing", SqlDbType.Char, 2, "ProducerState_Billing"),
      DefaultDatabase.CreateParameter("@ProducerISOCountryCode_Billing", SqlDbType.Char, 3, "ProducerISOCountryCode_Billing"),
      DefaultDatabase.CreateParameter("@ProducerRegion_Billing", SqlDbType.VarChar, 50, "ProducerRegion_Billing"),
      DefaultDatabase.CreateParameter("@ProducerZipCode_Billing", SqlDbType.VarChar, 15, "ProducerZipCode_Billing"),
      DefaultDatabase.CreateParameter("@ProducerZipPlus_Billing", SqlDbType.Char, 4, "ProducerZipPlus_Billing"),
      DefaultDatabase.CreateParameter("@ProducerPhone_Billing", SqlDbType.VarChar, 20, "ProducerPhone_Billing"),
      DefaultDatabase.CreateParameter("@ProducerFax_Billing", SqlDbType.VarChar, 20, "ProducerFax_Billing"),
      DefaultDatabase.CreateParameter("@InsuredBusinessTypeID", SqlDbType.TinyInt, 1, "InsuredBusinessTypeID"),
      DefaultDatabase.CreateParameter("@InsuredMobileNumber", SqlDbType.VarChar, 12, "InsuredMobileNumber"),
      DefaultDatabase.CreateParameter("@Original_QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteGUID", DataRowVersion.Original, (object) null)
    });
    ((UltraCombo) this.cboCostCenters).BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboCostCenters).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuotes.CostCenterID", true));
    ((UltraGridBase) this.cboCostCenters).DataSource = (object) this.ds.tblEntityGroups;
    ((UltraDropDownBase) this.cboCostCenters).DisplayMember = "GroupName";
    ((UltraCombo) this.cboCostCenters).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboCostCenters).Location = new Point(82, 24);
    this.cboCostCenters.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboCostCenters).Name = "cboCostCenters";
    ((Control) this.cboCostCenters).Size = new Size(426, 21);
    ((Control) this.cboCostCenters).TabIndex = 0;
    ((UltraControlBase) this.cboCostCenters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCostCenters).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCostCenters).ValueMember = "GroupId";
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(12, 28);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(69, 13);
    this.Label8.TabIndex = 143;
    this.Label8.Text = "Cost Center:";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    this.err.ContainerControl = (ContainerControl) this;
    appearance26.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox3.ContentAreaAppearance = (AppearanceBase) appearance26;
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.cboCostCenters);
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.Label8);
    appearance27.ForeColor = Color.Black;
    this.UltraGroupBox3.HeaderAppearance = (AppearanceBase) appearance27;
    ((Control) this.UltraGroupBox3).Location = new Point(5, 8);
    ((Control) this.UltraGroupBox3).Name = "UltraGroupBox3";
    ((Control) this.UltraGroupBox3).Size = new Size(523, 56);
    ((Control) this.UltraGroupBox3).TabIndex = 196;
    this.UltraGroupBox3.Text = "Cost Center";
    appearance28.BorderColor = Color.DarkGoldenrod;
    appearance28.ForeColor = Color.Red;
    appearance28.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance39.Image"));
    ((AppearanceBase) appearance28).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance28).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblPolicyIssued).Appearance = (AppearanceBase) appearance28;
    ((ControlBase) this.lblPolicyIssued).BackColorInternal = Color.LightYellow;
    this.lblPolicyIssued.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblPolicyIssued).Font = new Font("Tahoma", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblPolicyIssued).Location = new Point(8, 485);
    ((Control) this.lblPolicyIssued).Name = "lblPolicyIssued";
    ((ControlBase) this.lblPolicyIssued).Padding = new Size(5, 0);
    ((Control) this.lblPolicyIssued).Size = new Size(473, 40);
    ((Control) this.lblPolicyIssued).TabIndex = 197;
    ((ControlBase) this.lblPolicyIssued).Text = "Certain items above are unavailable because this policy has been issued.";
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.UltraTabControl1).Location = new Point(5, 72);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(523, 216);
    ((Control) this.UltraTabControl1).TabIndex = 198;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.UltraTabControl1).TabPadding = new Size(5, 3);
    appearance29.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance30.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance29;
    ultraTab1.TabPage = this.UltraTabPageControl3;
    ultraTab1.Text = "Insured Information";
    appearance30.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance31.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance30;
    ultraTab2.Key = "tabMailing";
    ultraTab2.TabPage = this.UltraTabPageControl1;
    ultraTab2.Text = "Mailing Address";
    appearance31.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance32.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance31;
    ultraTab3.Key = "tabBillingAddress";
    ultraTab3.TabPage = this.UltraTabPageControl2;
    ultraTab3.Text = "Billing Address";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[3]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(150, 25);
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(521, 189);
    ((Control) this.UltraTabControl2).Controls.Add((Control) this.UltraTabSharedControlsPage2);
    ((Control) this.UltraTabControl2).Controls.Add((Control) this.UltraTabPageControl4);
    ((Control) this.UltraTabControl2).Controls.Add((Control) this.UltraTabPageControl5);
    ((Control) this.UltraTabControl2).Controls.Add((Control) this.UltraTabPageControl6);
    ((Control) this.UltraTabControl2).Location = new Point(8, 294);
    ((Control) this.UltraTabControl2).Name = "UltraTabControl2";
    appearance32.BackColor = Color.WhiteSmoke;
    ((UltraTabControlBase) this.UltraTabControl2).SelectedTabAppearance = (AppearanceBase) appearance32;
    ((UltraTabControlBase) this.UltraTabControl2).SharedControlsPage = this.UltraTabSharedControlsPage2;
    ((Control) this.UltraTabControl2).Size = new Size(521, 185);
    ((Control) this.UltraTabControl2).TabIndex = 199;
    ((UltraTabControlBase) this.UltraTabControl2).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.UltraTabControl2).TabPadding = new Size(5, 3);
    appearance33.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance27.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance33;
    ultraTab4.TabPage = this.UltraTabPageControl4;
    ultraTab4.Text = "Producer Information";
    appearance34.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance28.Image"));
    ultraTab5.Appearance = (AppearanceBase) appearance34;
    ultraTab5.TabPage = this.UltraTabPageControl5;
    ultraTab5.Text = "Mailing Address";
    appearance35.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance29.Image"));
    ultraTab6.Appearance = (AppearanceBase) appearance35;
    ultraTab6.TabPage = this.UltraTabPageControl6;
    ultraTab6.Text = "Billing Address";
    ((UltraTabControlBase) this.UltraTabControl2).Tabs.AddRange(new UltraTab[3]
    {
      ultraTab4,
      ultraTab5,
      ultraTab6
    });
    ((UltraTabControlBase) this.UltraTabControl2).TabSize = new Size(150, 25);
    ((UltraTabControlBase) this.UltraTabControl2).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage2).Name = "UltraTabSharedControlsPage2";
    ((Control) this.UltraTabSharedControlsPage2).Size = new Size(519, 158);
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(535, 534);
    this.ControlBox = false;
    this.Controls.Add((Control) this.UltraTabControl2);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Controls.Add((Control) this.lblPolicyIssued);
    this.Controls.Add((Control) this.UltraGroupBox3);
    this.Controls.Add((Control) this.btnSave);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (frmQuoteEdit2);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Policy Information - Insured/Producer";
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((Control) this.UltraTabPageControl3).PerformLayout();
    ((ISupportInitialize) this.cmbGender).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.txtTaxID).EndInit();
    ((ISupportInitialize) this.txtEmail).EndInit();
    ((ISupportInitialize) this.txtRiskID).EndInit();
    ((ISupportInitialize) this.cboInsuredType).EndInit();
    ((ISupportInitialize) this.txtSSN).EndInit();
    ((ISupportInitialize) this.txtMiddle).EndInit();
    ((ISupportInitialize) this.txtLast).EndInit();
    ((ISupportInitialize) this.cboSalutations).EndInit();
    ((ISupportInitialize) this.txtDBA).EndInit();
    ((ISupportInitialize) this.txtBusiness).EndInit();
    ((ISupportInitialize) this.txtFEIN).EndInit();
    ((ISupportInitialize) this.txtPolicyName).EndInit();
    ((ISupportInitialize) this.txtFirst).EndInit();
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.mmeMobileNumber).EndInit();
    ((ISupportInitialize) this.UltraMaskedEdit4).EndInit();
    ((ISupportInitialize) this.UltraMaskedEdit3).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.mgaTxtBillingContact).EndInit();
    ((ISupportInitialize) this.mgaTxtBillingEmail).EndInit();
    ((ISupportInitialize) this.UltraMaskedEdit6).EndInit();
    ((ISupportInitialize) this.UltraMaskedEdit5).EndInit();
    ((Control) this.UltraTabPageControl4).ResumeLayout(false);
    ((Control) this.UltraTabPageControl4).PerformLayout();
    ((ISupportInitialize) this.txtLocation).EndInit();
    ((ISupportInitialize) this.txtProducerName).EndInit();
    ((Control) this.UltraTabPageControl5).ResumeLayout(false);
    ((Control) this.UltraTabPageControl5).PerformLayout();
    ((ISupportInitialize) this.UltraMaskedEdit2).EndInit();
    ((ISupportInitialize) this.UltraMaskedEdit1).EndInit();
    ((Control) this.UltraTabPageControl6).ResumeLayout(false);
    ((Control) this.UltraTabPageControl6).PerformLayout();
    ((ISupportInitialize) this.UltraMaskedEdit7).EndInit();
    ((ISupportInitialize) this.UltraMaskedEdit8).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.cboCostCenters).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraGroupBox3).EndInit();
    ((Control) this.UltraGroupBox3).ResumeLayout(false);
    ((Control) this.UltraGroupBox3).PerformLayout();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((ISupportInitialize) this.UltraTabControl2).EndInit();
    ((Control) this.UltraTabControl2).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public bool IsNewQuote
  {
    get => this._isNewQuote;
    set => this._isNewQuote = value;
  }

  public bool IsConvertToFullQuote
  {
    get => this._isConvertToFullQuote;
    set => this._isConvertToFullQuote = value;
  }

  public Quote Quote => this._quote;

  public int IndividualID
  {
    get
    {
      if (this._isIndividual == null)
        this._isIndividual = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("dbo.GetBusinessIndividual"));
      return (int) this._isIndividual;
    }
  }

  public frmQuoteEdit2()
  {
    this.Load += new EventHandler(this.frmQuoteEdit2_Load);
    this._isIndividual = (object) null;
    this._UnlockIndividualType = false;
    this.InitializeComponent();
  }

  public frmQuoteEdit2(Guid quoteGuid)
    : this()
  {
    this._quoteGuid = quoteGuid;
    this._quote = Quote.CreateNewAs<Quote>(this._quoteGuid);
  }

  private void frmQuoteEdit2_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this._UnlockIndividualType = SystemSettings.GetSetting<bool>("UnLockIndividualTypeInsureds", false);
    this.SetupSaveButton();
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
    {
      this.ds.lstBusinessTypes.TableName,
      this.ds.lstClaims_Gender.TableName
    }, "GetQuoteEdit2_data");
    this.daQuote.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._quoteGuid;
    this.ds.EnforceConstraints = false;
    DefaultDatabase.DataAdapterFill(this.daQuote, (DataTable) this.ds.tblQuotes);
    this.GetCostCenters(this.ds.tblEntityGroups, this._quoteGuid);
    this.DefaultCostCenter();
    if (this.ds.tblQuotes[0].IsInsuredISOCountryCodeNull())
      this.ds.tblQuotes[0].InsuredISOCountryCode = "USA";
    this.CleanPhoneNumbers();
    this.HideDefaultCostCenter();
    bool isIndividual = this.ds.tblQuotes[0].IsInsuredCorporationNameNull();
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstSalutations"
    }, CommandType.Text, "SELECT Salutation FROM dbo.lstSalutations WITH(NOLOCK) ORDER BY Salutation");
    if (!this.ds.tblQuotes[0].IsInsuredSalutationNull() && (string.IsNullOrEmpty(this.ds.tblQuotes[0].InsuredSalutation) || this.ds.tblQuotes[0].InsuredSalutation.Replace(" ", string.Empty).Length == 0))
      this.ds.tblQuotes[0].SetInsuredSalutationNull();
    try
    {
      this.ds.EnforceConstraints = true;
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    this.SetIndividualControlsEnabled(isIndividual);
    bool isIssued = new Quote(this._quoteGuid).IsIssued;
    ((Control) this.lblPolicyIssued).Visible = isIssued;
    this.SetTabsEnabled(isIssued);
    ((Control) this.cboCostCenters).Enabled = !isIssued;
    if (isIssued && SecurityManager.Instance.AssertPermission("{85D01871-DCAC-44b6-85EC-E50AFD8226EF}"))
      ((Control) this.cboCostCenters).Enabled = true;
    this.OnlyAllowSaveOnCurrentTransaction();
    this.SetupSecurity();
    if (!this.IsNewQuote)
    {
      this.ControlBox = true;
      this.MinimizeBox = false;
      this.MaximizeBox = false;
    }
    ((Control) this.txtProducerName).Enabled = false;
    ((Control) this.txtLocation).Enabled = false;
    ((Control) this.txtRiskID).Enabled = false;
    ((TextEditorControlBase) this.txtRiskID).Text = this.Quote.SubmissionGroup.Insured.RiskID;
    this.GetDataValues();
    ((UltraCombo) this.cboInsuredType).ValueChanged += new EventHandler(this.cboInsuredType_ValueChanged);
    this.FormatPhoneNumbers();
    this.AfterLoad();
  }

  protected virtual void GetCostCenters(dsQuoteEdit2.tblEntityGroupsDataTable tbl, Guid quoteguid)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblEntityGroups"
    }, "spGetQuoteCostCenters", new object[2]
    {
      (object) "@QuoteGuid",
      (object) quoteguid
    });
  }

  private void SetupSaveButton()
  {
    MGAButton btnSave = this.btnSave;
    ((ControlBase) btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) btnSave).Appearance.ImageHAlign = (HAlign) 2;
    ((ControlBase) btnSave).Appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) btnSave).ImageTransparentColor = Color.Magenta;
  }

  private void DefaultCostCenter()
  {
    if (!this.IsNewQuote || this.ds.tblEntityGroups.Select("IsDefault=1").Length <= 0)
      return;
    this.ds.tblQuotes[0].CostCenterID = ((dsQuoteEdit2.tblEntityGroupsRow) this.ds.tblEntityGroups.Select("IsDefault=1")[0]).GroupId;
  }

  private void HideDefaultCostCenter()
  {
    if (this.ds.tblEntityGroups.Select("IsDefault=1").Length <= 0 || this.ds.tblEntityGroups.Rows.Count <= 1)
      return;
    for (int index = this.ds.tblEntityGroups.Rows.Count - 1; index >= 0; index += -1)
    {
      DataRow row = this.ds.tblEntityGroups.Rows[index];
      if (this.IsNewQuote && (bool) row["SystemDefined"])
      {
        this.ds.tblEntityGroups.Rows.Remove(row);
        break;
      }
      if (!this.IsNewQuote && (bool) row["SystemDefined"] && (int) row["GroupId"] != this.ds.tblQuotes[0].CostCenterID)
      {
        this.ds.tblEntityGroups.Rows.Remove(row);
        break;
      }
    }
  }

  private void CleanPhoneNumbers()
  {
    if (this.ds.Tables[0].Rows.Count <= 0)
      return;
    this.ds.Tables[0].Rows[0]["ProducerPhone"] = (object) this.ds.Tables[0].Rows[0]["ProducerPhone"].ToString().Replace("-", "").Replace(" ", "");
    this.ds.Tables[0].Rows[0]["ProducerFax"] = (object) this.ds.Tables[0].Rows[0]["ProducerFax"].ToString().Replace("-", "").Replace(" ", "");
    this.ds.Tables[0].Rows[0]["ProducerPhone_Billing"] = (object) this.ds.Tables[0].Rows[0]["ProducerPhone_Billing"].ToString().Replace("-", "").Replace(" ", "");
    this.ds.Tables[0].Rows[0]["ProducerFax_Billing"] = (object) this.ds.Tables[0].Rows[0]["ProducerFax_Billing"].ToString().Replace("-", "").Replace(" ", "");
    this.ds.Tables[0].Rows[0]["InsuredPhone"] = (object) this.ds.Tables[0].Rows[0]["InsuredPhone"].ToString().Replace("-", "").Replace(" ", "");
    this.ds.Tables[0].Rows[0]["InsuredFax"] = (object) this.ds.Tables[0].Rows[0]["InsuredFax"].ToString().Replace("-", "").Replace(" ", "");
    this.ds.Tables[0].Rows[0]["InsuredPhone_Billing"] = (object) this.ds.Tables[0].Rows[0]["InsuredPhone_Billing"].ToString().Replace("-", "").Replace(" ", "");
    this.ds.Tables[0].Rows[0]["InsuredFax_Billing"] = (object) this.ds.Tables[0].Rows[0]["InsuredFax_Billing"].ToString().Replace("-", "").Replace(" ", "");
    this.ds.Tables[0].Rows[0]["InsuredMobileNumber"] = (object) this.ds.Tables[0].Rows[0]["InsuredMobileNumber"].ToString().Replace("-", "").Replace(" ", "");
  }

  private void SetupSecurity()
  {
    if (!this.Quote.IsBound)
      return;
    int num = SecurityManager.Instance.AssertPermission("{15E267C1-0A94-4026-A720-A2E0895F5F3C}") ? 1 : 0;
    bool flag = SecurityManager.Instance.AssertPermission("{7AC4429F-734B-4e0a-8CE1-468C15B6C4AF}");
    if (num == 0)
    {
      try
      {
        foreach (Control control in ((Control) this.UltraTabPageControl1).Controls)
          control.Enabled = false;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        foreach (Control control in ((Control) this.UltraTabPageControl2).Controls)
          control.Enabled = false;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        foreach (Control control in ((Control) this.UltraTabPageControl3).Controls)
          control.Enabled = false;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    if (flag)
      return;
    try
    {
      foreach (Control control in ((Control) this.UltraTabPageControl4).Controls)
        control.Enabled = false;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (Control control in ((Control) this.UltraTabPageControl5).Controls)
        control.Enabled = false;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (Control control in ((Control) this.UltraTabPageControl6).Controls)
        control.Enabled = false;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void OnlyAllowSaveOnCurrentTransaction()
  {
    bool flag = true;
    if (!this.IsNewQuote)
      flag = this.Quote.IsCurrent;
    if (flag)
      return;
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
          control.Enabled = false;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl2).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
          control.Enabled = false;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }

  private void SetTabsEnabled(bool isIssued)
  {
    try
    {
      foreach (Control control in ((Control) this.UltraTabPageControl3).Controls)
        control.Enabled = !isIssued && control.Enabled;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (Control control in ((Control) this.UltraTabPageControl1).Controls)
        control.Enabled = !isIssued && control.Enabled;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (Control control in ((Control) this.UltraTabPageControl2).Controls)
        control.Enabled = !isIssued && control.Enabled;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (Control control in ((Control) this.UltraTabPageControl4).Controls)
        control.Enabled = !isIssued && control.Enabled;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (Control control in ((Control) this.UltraTabPageControl5).Controls)
        control.Enabled = !isIssued && control.Enabled;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (Control control in ((Control) this.UltraTabPageControl6).Controls)
        control.Enabled = !isIssued && control.Enabled;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void GetDataValues()
  {
    ((TextEditorControlBase) this.txtEmail).Text = string.Empty;
    ((TextEditorControlBase) this.txtTaxID).Text = string.Empty;
    ((UltraCombo) this.cmbGender).Value = (object) 1;
    ((TextEditorControlBase) this.mgaTxtBillingEmail).Text = string.Empty;
    ((TextEditorControlBase) this.mgaTxtBillingContact).Text = string.Empty;
    if (this.IsNewQuote)
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("spGetInsuredTaxID", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      }));
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
        return;
      ((TextEditorControlBase) this.txtTaxID).Text = objectValue.ToString();
    }
    else
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT Email, TaxID, Gender,InsuredBillingEmail, InsuredBillingContact FROM dbo.tblQuotes2 WITH (NOLOCK) WHERE QuoteID = @QuoteID", new object[2]
      {
        (object) "@QuoteID",
        (object) this.Quote.QuoteID
      });
      if (dataRow == null)
        return;
      if (dataRow[0] != DBNull.Value)
        ((TextEditorControlBase) this.txtEmail).Text = dataRow[0].ToString();
      if (dataRow[1] != DBNull.Value)
        ((TextEditorControlBase) this.txtTaxID).Text = dataRow[1].ToString();
      if (dataRow[2] != DBNull.Value)
        ((UltraCombo) this.cmbGender).Value = (object) dataRow[2].ToString();
      if (dataRow[3] != DBNull.Value)
        ((TextEditorControlBase) this.mgaTxtBillingEmail).Text = dataRow[3].ToString();
      if (dataRow[4] == DBNull.Value)
        return;
      ((TextEditorControlBase) this.mgaTxtBillingContact).Text = dataRow[4].ToString();
    }
  }

  private void SaveDataValues()
  {
    object obj1 = (object) null;
    object obj2 = (object) null;
    object obj3 = (object) null;
    object obj4 = (object) null;
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtEmail).Text))
      obj1 = (object) ((TextEditorControlBase) this.txtEmail).Text;
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtTaxID).Text))
      obj2 = (object) ((TextEditorControlBase) this.txtTaxID).Text;
    object obj5;
    if (((UltraCombo) this.cmbGender).Value != null)
    {
      obj5 = RuntimeHelpers.GetObjectValue(((UltraCombo) this.cmbGender).Value);
    }
    else
    {
      ((UltraCombo) this.cmbGender).Value = (object) 1;
      obj5 = (object) 1;
    }
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.mgaTxtBillingEmail).Text))
      obj3 = (object) ((TextEditorControlBase) this.mgaTxtBillingEmail).Text;
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.mgaTxtBillingContact).Text))
      obj4 = (object) ((TextEditorControlBase) this.mgaTxtBillingContact).Text;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, " UPDATE tblQuotes2  SET Email = @Email,  TaxID = @TaxID,  Gender = @Gender,  InsuredBillingEmail  = @InsuredBillingEmail,  InsuredBillingContact  = @InsuredBillingContact  WHERE QuoteID = @QuoteID", new object[12]
    {
      (object) "@Email",
      obj1,
      (object) "@TaxID",
      obj2,
      (object) "@Gender",
      obj5,
      (object) "@InsuredBillingEmail",
      obj3,
      (object) "@InsuredBillingContact",
      obj4,
      (object) "@QuoteID",
      (object) this.Quote.QuoteID
    });
  }

  private void cboInsuredType_ValueChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboInsuredType).Value.ToString(), string.Empty, false) == 0)
      return;
    this.SetIndividualControlsEnabled(this.ds.lstBusinessTypes.FindByBusinessTypeID(Conversions.ToInteger(((UltraCombo) this.cboInsuredType).Value)).Individual);
  }

  protected virtual void SetIndividualControlsEnabled(bool isIndividual)
  {
    ((Control) this.cboSalutations).Enabled = isIndividual;
    ((Control) this.txtFirst).Enabled = isIndividual;
    ((Control) this.txtLast).Enabled = isIndividual;
    ((Control) this.txtMiddle).Enabled = isIndividual;
    ((Control) this.txtBusiness).Enabled = !isIndividual;
    ((Control) this.txtFEIN).Enabled = !isIndividual || this._UnlockIndividualType;
    ((Control) this.txtSSN).Enabled = isIndividual;
    ((Control) this.cmbGender).Enabled = isIndividual;
    ((UltraCombo) this.cmbGender).Value = (object) 1;
    if (isIndividual)
    {
      ((TextEditorControlBase) this.txtBusiness).Text = string.Empty;
      ((UltraMaskedEdit) this.txtFEIN).Value = (object) null;
    }
    else
    {
      ((UltraCombo) this.cboSalutations).Value = (object) DBNull.Value;
      ((TextEditorControlBase) this.txtFirst).Text = string.Empty;
      ((TextEditorControlBase) this.txtMiddle).Text = string.Empty;
      ((TextEditorControlBase) this.txtLast).Text = string.Empty;
      ((UltraMaskedEdit) this.txtSSN).Value = (object) null;
    }
  }

  private void lnkShowMap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.CtrlInsuredMailing.ShowInGoogleMaps();
  }

  protected virtual bool IsCostCenterValid()
  {
    bool flag = true;
    if (((Control) this.cboCostCenters).Enabled && !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboCostCenters).Value)))
    {
      this.err.SetError((Control) this.cboCostCenters, "Please select a cost center.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboCostCenters, string.Empty);
    return flag;
  }

  protected virtual bool IsValidForm()
  {
    try
    {
      foreach (Control control in ((Control) this.UltraTabPageControl3).Controls)
        this.err.SetError(control, string.Empty);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    bool flag = this.IsCostCenterValid();
    if (flag && !string.IsNullOrEmpty(((UltraCombo) this.cboInsuredType).Text))
    {
      if ((int) ((UltraCombo) this.cboInsuredType).Value == this.IndividualID)
      {
        if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtFirst).Text))
        {
          this.err.SetError((Control) this.txtFirst, "Please enter a value");
          flag = false;
        }
        else
          this.err.SetError((Control) this.txtFirst, string.Empty);
        if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtLast).Text))
        {
          this.err.SetError((Control) this.txtLast, "Please enter a value");
          flag = false;
        }
        else
          this.err.SetError((Control) this.txtLast, string.Empty);
      }
      else
      {
        if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtBusiness).Text))
        {
          this.err.SetError((Control) this.txtBusiness, "Please enter a value");
          flag = false;
        }
        else
          this.err.SetError((Control) this.txtBusiness, string.Empty);
        if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtPolicyName).Text))
        {
          this.err.SetError((Control) this.txtPolicyName, "Please enter a value");
          flag = false;
        }
        else
          this.err.SetError((Control) this.txtPolicyName, string.Empty);
      }
    }
    if (!flag)
      ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[0];
    return flag;
  }

  protected virtual void SaveModifiedInformation(dsQuoteEdit2.tblQuotesRow dr)
  {
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.IsValidForm())
      return;
    if (!this.CtrlInsuredMailing.ValidateFields())
      ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[1];
    else if (!this.ctlZipCode.ValidateFields())
    {
      ((UltraTabControlBase) this.UltraTabControl2).SelectedTab = ((UltraTabControlBase) this.UltraTabControl2).Tabs[1];
    }
    else
    {
      this.SaveData();
      if (this.ds.tblQuotes[0].RowState == DataRowState.Modified)
        this.SaveModifiedInformation(this.ds.tblQuotes[0]);
      this.SaveDataValues();
      if (!this.IsNewQuote)
      {
        if (!this._isConvertToFullQuote)
        {
          try
          {
            foreach (frmPolicyDetail frmPolicyDetail in MDIControls.Instance.MDIParent.MdiChildren.OfType<frmPolicyDetail>())
            {
              if (this._quoteGuid.Equals((object) frmPolicyDetail?.Quote?.QuoteGuid))
                frmPolicyDetail.RefreshPolicyData();
            }
            goto label_18;
          }
          finally
          {
            IEnumerator<frmPolicyDetail> enumerator;
            enumerator?.Dispose();
          }
        }
      }
      FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
      {
        (object) this._quoteGuid
      });
label_18:
      this.Close();
    }
  }

  protected virtual void SaveData()
  {
    this.BindingContext[(object) this.ds, this.ds.tblQuotes.TableName].EndCurrentEdit();
    if (!this.ds.tblQuotes[0].IsInsuredCorporationNameNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ds.tblQuotes[0].InsuredCorporationName, string.Empty, false) == 0)
      this.ds.tblQuotes[0].SetInsuredCorporationNameNull();
    if (!this.ds.tblQuotes[0].IsProducerAddress1_BillingNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.CtrlBillingAddress.Address1, string.Empty, false) == 0)
      this.ds.tblQuotes[0].SetProducerAddress1_BillingNull();
    if (!this.ds.tblQuotes[0].IsProducerAddress2_BillingNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.CtrlBillingAddress.Address2, string.Empty, false) == 0)
      this.ds.tblQuotes[0].SetProducerAddress2_BillingNull();
    if (!this.ds.tblQuotes[0].IsProducerCity_BillingNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.CtrlBillingAddress.City, string.Empty, false) == 0)
      this.ds.tblQuotes[0].SetProducerCity_BillingNull();
    if (!this.ds.tblQuotes[0].IsProducerState_BillingNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.CtrlBillingAddress.State, string.Empty, false) == 0)
      this.ds.tblQuotes[0].SetProducerState_BillingNull();
    if (!this.ds.tblQuotes[0].IsProducerCounty_BillingNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.CtrlBillingAddress.County, string.Empty, false) == 0)
      this.ds.tblQuotes[0].SetProducerCounty_BillingNull();
    if (!this.ds.tblQuotes[0].IsProducerZipCode_BillingNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.CtrlBillingAddress.ZipCode, string.Empty, false) == 0)
      this.ds.tblQuotes[0].SetProducerZipCode_BillingNull();
    if (!this.ds.tblQuotes[0].IsProducerZipPlus_BillingNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.CtrlBillingAddress.ZipCodeExtension, string.Empty, false) == 0)
      this.ds.tblQuotes[0].SetProducerZipPlus_BillingNull();
    if (((TextEditorControlBase) this.txtDBA).Text.Replace(" ", string.Empty).Length == 0)
      this.ds.tblQuotes[0].SetInsuredDBANull();
    if (((TextEditorControlBase) this.mgaTxtBillingEmail).Text.Replace(" ", string.Empty).Length == 0)
      this.ds.tblQuotes[0].SetInsuredBillingEmailNull();
    if (((TextEditorControlBase) this.mgaTxtBillingContact).Text.Replace(" ", string.Empty).Length == 0)
      this.ds.tblQuotes[0].SetInsuredBillingContactNull();
    this.SetproducerFieldsNullIfEmptyMailling();
    this.SetInsuredFieldNullIfEmpty();
    this.SetInsuredFieldNullIfEmpty_Billing();
    bool flag = false;
    if (!this.IsNewQuote)
    {
      dsQuoteEdit2.tblQuotesRow tblQuote = this.ds.tblQuotes[0];
      string str = tblQuote.Field<string>(this.ds.tblQuotes.InsuredPolicyNameColumn, DataRowVersion.Original);
      string insuredPolicyName = tblQuote.InsuredPolicyName;
      if (!StringExtensions.EqualsNoCase(str, insuredPolicyName))
        CurrentUser.Instance.LogAction($"Change Insured Policy Name from '{str}' to '{insuredPolicyName}'", this._quote.QuoteGuid);
      int num;
      if (!SystemSettings.GetSetting<bool>("OFAC.Policy.SkipOnModified", false))
        num = ExtensionsMethods.AnyColumnsChanged<string>((DataRow) tblQuote, (IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase, new DataColumn[7]
        {
          this.ds.tblQuotes.InsuredPolicyNameColumn,
          this.ds.tblQuotes.InsuredAddress1Column,
          this.ds.tblQuotes.InsuredAddress2Column,
          this.ds.tblQuotes.InsuredCityColumn,
          this.ds.tblQuotes.InsuredStateColumn,
          this.ds.tblQuotes.InsuredZipCodeColumn,
          this.ds.tblQuotes.InsuredISOCountryCodeColumn
        }) ? 1 : 0;
      else
        num = 0;
      flag = num != 0;
    }
    DefaultDatabase.DataAdapterUpdate(this.daQuote, (DataTable) this.ds.tblQuotes);
    if (!flag)
      return;
    Quote quote = Quote.CreateNew(this._quoteGuid);
    if (!quote.SearchQuoteOfac)
      return;
    OfacSystem.Instance.CheckOfac<Quote>(quote);
  }

  private void SetInsuredFieldNullIfEmpty()
  {
    if (!this.ds.tblQuotes[0].IsInsuredZipPlusNull() && string.IsNullOrEmpty(this.CtrlInsuredMailing.ZipCodeExtension))
      this.ds.tblQuotes[0].SetInsuredZipPlusNull();
    if (!this.ds.tblQuotes[0].IsInsuredPhoneNull() && string.IsNullOrEmpty(((UltraMaskedEdit) this.UltraMaskedEdit4).Text))
      this.ds.tblQuotes[0].SetInsuredPhoneNull();
    if (!this.ds.tblQuotes[0].IsInsuredFaxNull() && string.IsNullOrEmpty(((UltraMaskedEdit) this.UltraMaskedEdit3).Text))
      this.ds.tblQuotes[0].SetInsuredFaxNull();
    if (!this.ds.tblQuotes[0].IsInsuredAddress2Null() && string.IsNullOrEmpty(this.CtrlInsuredMailing.Address2))
      this.ds.tblQuotes[0].SetInsuredAddress2Null();
    if (this.ds.tblQuotes[0].IsInsuredStateNull() || !string.IsNullOrEmpty(this.CtrlInsuredMailing.State))
      return;
    this.ds.tblQuotes[0].SetInsuredStateNull();
  }

  private void SetInsuredFieldNullIfEmpty_Billing()
  {
    if (!this.ds.tblQuotes[0].IsInsuredZipPlus_BillingNull() && string.IsNullOrEmpty(this.ctrlInsuredBilling.ZipCodeExtension))
      this.ds.tblQuotes[0].SetInsuredZipPlus_BillingNull();
    if (!this.ds.tblQuotes[0].IsInsuredPhone_BillingNull() && string.IsNullOrEmpty(((UltraMaskedEdit) this.UltraMaskedEdit5).Text))
      this.ds.tblQuotes[0].SetInsuredPhone_BillingNull();
    if (!this.ds.tblQuotes[0].IsInsuredFax_BillingNull() && string.IsNullOrEmpty(((UltraMaskedEdit) this.UltraMaskedEdit6).Text))
      this.ds.tblQuotes[0].SetInsuredFax_BillingNull();
    if (!this.ds.tblQuotes[0].IsInsuredAddress1_BillingNull() && string.IsNullOrEmpty(this.ctrlInsuredBilling.Address1))
      this.ds.tblQuotes[0].SetInsuredAddress1_BillingNull();
    if (!this.ds.tblQuotes[0].IsInsuredAddress2_BillingNull() && string.IsNullOrEmpty(this.ctrlInsuredBilling.Address2))
      this.ds.tblQuotes[0].SetInsuredAddress2_BillingNull();
    if (!this.ds.tblQuotes[0].IsInsuredCity_BillingNull() && string.IsNullOrEmpty(this.ctrlInsuredBilling.City))
      this.ds.tblQuotes[0].SetInsuredCity_BillingNull();
    if (this.ds.tblQuotes[0].IsInsuredState_BillingNull() || !string.IsNullOrEmpty(this.ctrlInsuredBilling.State))
      return;
    this.ds.tblQuotes[0].SetInsuredState_BillingNull();
  }

  private void SetproducerFieldsNullIfEmptyMailling()
  {
    if (!this.ds.tblQuotes[0].IsProducerAddress2Null() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ctlZipCode.Address2, string.Empty, false) == 0)
      this.ds.tblQuotes[0].SetProducerAddress2Null();
    if (!this.ds.tblQuotes[0].IsProducerStateNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ctlZipCode.State, string.Empty, false) == 0)
      this.ds.tblQuotes[0].SetProducerStateNull();
    if (!this.ds.tblQuotes[0].IsProducerCountyNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ctlZipCode.County, string.Empty, false) == 0)
      this.ds.tblQuotes[0].SetProducerCountyNull();
    if (this.ds.tblQuotes[0].IsProducerZipPlusNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ctlZipCode.ZipCodeExtension, string.Empty, false) != 0)
      return;
    this.ds.tblQuotes[0].SetProducerZipPlusNull();
  }

  protected virtual void AfterLoad()
  {
  }

  bool IRecreatableEntity.CanReCreateEntity => !this.IsNewQuote;

  Guid IRecreatableEntity.ControlGUID => this._quote.ControlGuid;

  Guid IRecreatableEntity.EntityGuid => this._quote.EntityGuid;

  string IRecreatableEntity.EntityName => this._quote.EntityName;

  string IRecreatableEntity.FriendlyEntityName => this._quote.FriendlyEntityName;

  bool IRecreatableEntity.HasControlGUID => this._quote.HasControlGUID;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    bool flag;
    try
    {
      this._quote = Quote.FromControlGuid(entityGuid) as Quote;
      this._quoteGuid = this._quote.QuoteGuid;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      exception.Data.Add((object) "ControlGuid", (object) entityGuid);
      ErrorHandler.SilentLogError(exception);
      flag = false;
      ProjectData.ClearProjectError();
      goto label_3;
    }
    flag = true;
label_3:
    return flag;
  }

  string IRecreatableEntity.RecreateTypeName
  {
    get => !this.IsNewQuote ? this._quote.RecreateTypeName : string.Empty;
  }

  public bool CanCreateNewNote => !this.IsNewQuote;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged1;

  private void CtlZipCode_ZipCodeLookupCompleted(object sender, ZipLookupCompletedEventArgs e)
  {
    this.ctlZipCode.DataChanged();
  }

  private void CtrlBillingAddress_ZipCodeLookupCompleted(
    object sender,
    ZipLookupCompletedEventArgs e)
  {
    this.CtrlBillingAddress.DataChanged();
  }

  private DataRow GetCountryPhoneDataRow()
  {
    return DefaultDatabase.ExecuteDataRow(CommandType.Text, "select CountryCode,AdditionalDescription,PhoneInputMask from Globalization_CountryList WITH (NOLOCK) Where PhoneInputMask is Not Null and CountryCode=@CountryCode ", new object[2]
    {
      (object) "@CountryCode",
      (object) this.ctlZipCode.ISOCountryCode
    });
  }

  private void FormatPhoneNumbers()
  {
    DataRow countryPhoneDataRow = this.GetCountryPhoneDataRow();
    this.FormatProducerMailingPhoneNumbers(countryPhoneDataRow);
    this.FormatProducerBillingPhoneNumbers(countryPhoneDataRow);
    this.FormatInsuredPhoneNumbers(countryPhoneDataRow);
    this.FormatInsuredBillingPhoneNumbers(countryPhoneDataRow);
  }

  private void CtlZipCode_CountryChanged(object sender, EventArgs e)
  {
    this.FormatProducerMailingPhoneNumbers(this.GetCountryPhoneDataRow());
  }

  private void FormatProducerMailingPhoneNumbers(DataRow dr)
  {
    if (dr != null && dr["PhoneInputMask"] != DBNull.Value && dr["AdditionalDescription"] != DBNull.Value)
    {
      ((UltraMaskedEdit) this.UltraMaskedEdit2).InputMask = $"{dr["AdditionalDescription"].ToString()} {dr["PhoneInputMask"].ToString()}";
      ((UltraMaskedEdit) this.UltraMaskedEdit1).InputMask = $"{dr["AdditionalDescription"].ToString()} {dr["PhoneInputMask"].ToString()}";
    }
    else
    {
      ((UltraMaskedEdit) this.UltraMaskedEdit2).InputMask = (string) null;
      ((UltraMaskedEdit) this.UltraMaskedEdit1).InputMask = (string) null;
    }
  }

  private void CtrlBillingAddress_CountryChanged(object sender, EventArgs e)
  {
    this.FormatProducerBillingPhoneNumbers(this.GetCountryPhoneDataRow());
  }

  private void FormatProducerBillingPhoneNumbers(DataRow dr)
  {
    if (dr != null && dr["PhoneInputMask"] != DBNull.Value)
    {
      ((UltraMaskedEdit) this.UltraMaskedEdit8).InputMask = $"{dr["AdditionalDescription"].ToString()} {dr["PhoneInputMask"].ToString()}";
      ((UltraMaskedEdit) this.UltraMaskedEdit7).InputMask = $"{dr["AdditionalDescription"].ToString()} {dr["PhoneInputMask"].ToString()}";
    }
    else
    {
      ((UltraMaskedEdit) this.UltraMaskedEdit8).InputMask = (string) null;
      ((UltraMaskedEdit) this.UltraMaskedEdit7).InputMask = (string) null;
    }
  }

  private void CtrlInsuredMailing_ZipCodeLookupCompleted(
    object sender,
    ZipLookupCompletedEventArgs e)
  {
    this.CtrlInsuredMailing.DataChanged();
  }

  private void CtrlInsuredMailing_CountryChanged(object sender, EventArgs e)
  {
    this.FormatInsuredPhoneNumbers(this.GetCountryPhoneDataRow());
  }

  private void FormatInsuredPhoneNumbers(DataRow dr)
  {
    if (dr != null && dr["PhoneInputMask"] != DBNull.Value)
    {
      ((UltraMaskedEdit) this.UltraMaskedEdit4).InputMask = $"{dr["AdditionalDescription"].ToString()} {dr["PhoneInputMask"].ToString()}";
      ((UltraMaskedEdit) this.UltraMaskedEdit3).InputMask = $"{dr["AdditionalDescription"].ToString()} {dr["PhoneInputMask"].ToString()}";
      ((UltraMaskedEdit) this.mmeMobileNumber).InputMask = $"{dr["AdditionalDescription"].ToString()} {dr["PhoneInputMask"].ToString()}";
    }
    else
    {
      ((UltraMaskedEdit) this.UltraMaskedEdit4).InputMask = (string) null;
      ((UltraMaskedEdit) this.UltraMaskedEdit3).InputMask = (string) null;
      ((UltraMaskedEdit) this.mmeMobileNumber).InputMask = (string) null;
    }
  }

  private void CtrlInsuredBilling_ZipCodeLookupCompleted(
    object sender,
    ZipLookupCompletedEventArgs e)
  {
    this.ctrlInsuredBilling.DataChanged();
  }

  private void CtrlInsuredBilling_CountryChanged(object sender, EventArgs e)
  {
    this.FormatInsuredBillingPhoneNumbers(this.GetCountryPhoneDataRow());
  }

  private void FormatInsuredBillingPhoneNumbers(DataRow dr)
  {
    if (dr != null && dr["PhoneInputMask"] != DBNull.Value)
    {
      ((UltraMaskedEdit) this.UltraMaskedEdit5).InputMask = $"{dr["AdditionalDescription"].ToString()} {dr["PhoneInputMask"].ToString()}";
      ((UltraMaskedEdit) this.UltraMaskedEdit6).InputMask = $"{dr["AdditionalDescription"].ToString()} {dr["PhoneInputMask"].ToString()}";
    }
    else
    {
      ((UltraMaskedEdit) this.UltraMaskedEdit5).InputMask = (string) null;
      ((UltraMaskedEdit) this.UltraMaskedEdit6).InputMask = (string) null;
    }
  }

  private void CtrlInsuredMailing_Leave(object sender, EventArgs e)
  {
    this.CtrlInsuredMailing.DataChanged();
  }

  private void ctrlInsuredBilling_Leave(object sender, EventArgs e)
  {
    this.ctrlInsuredBilling.DataChanged();
  }

  private void ctlZipCode_Leave(object sender, EventArgs e) => this.ctlZipCode.DataChanged();

  private void CtrlBillingAddress_Leave(object sender, EventArgs e)
  {
    this.CtrlBillingAddress.DataChanged();
  }
}

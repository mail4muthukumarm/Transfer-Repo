// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmAdminCompanyPolicyFees
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.CustomExceptions;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic;
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

[SecureResource("{667030DC-114D-41e5-882A-0C7BB7C46A0D}", "Access Company Fees Screen", "Controls access to the Company Fees screen.", "Companies")]
[SecureResource("{25F2A8F1-8DD5-422d-8B72-9E13D3DE73E1}", "Edit / Change Company Fees Screen", "Controls editing / changing of fees on the Company Fees screen.", "Companies")]
[SecureResource("{559D04BC-6154-43EC-AC8B-2910F82BBC85}", "Update Mandatory Charge Fees", "Controls updating of fees designated as Mandatory Charge.", "Companies")]
public class frmAdminCompanyPolicyFees : Form
{
  private readonly Guid _companyLineGuid;
  private readonly bool _enableDropDowns;
  private bool _showAll;
  private readonly bool _showOnlyGenericFees;
  private bool _showSurplusLines;
  private bool _ShowCountyTaxIncludedInRate;
  private Dictionary<int, bool> _feeAppliedDictionary;
  private bool _isEditing;
  private bool _hasMandatoryChargePermission;
  private IContainer components;
  private Label Label1;
  private Label Label2;
  private MGACheckBox chkAutoApply;
  private Label Label3;
  private Label Label4;
  private ErrorProvider err;
  private SqlConnection cnSQL;
  protected dsCompanyPolicyFees dsFees;
  private MGATextBox txtFlatFee;
  private MGATextBox txtPercentage;
  private Label Label5;
  private Label Label6;
  private Label lblOffices;
  private Label lblEntityGuid;
  private Panel Panel1;
  private MGADateTimePicker dtEffective;
  private MGANumericEditor txtPercentageMinimum;
  private MGACheckBox chkExcludeFiling;
  private MGATextBox lblPayableTo;
  private MGACheckBox chkExcludeEndorsements;
  private Label Label8;
  private MGASimpleComboBox cboInstallmentBilling;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private UltraTabPageControl UltraTabPageControl2;
  private UltraTabPageControl UltraTabPageControl3;
  private UltraTabPageControl UltraTabPageControl4;
  private MGACheckBox chkFullyEarned;
  private UltraTabPageControl UltraTabPageControl1;
  private Label Label9;
  private Label Label10;
  private MGANumericEditor txtMaxPercentage;
  private MGANumericEditor txtMaxDollars;
  private MGACheckBox MgaCheckBox2;
  internal const string CanEditFees = "{25F2A8F1-8DD5-422d-8B72-9E13D3DE73E1}";
  public const string OpenForm = "{667030DC-114D-41e5-882A-0C7BB7C46A0D}";
  internal const string CanUpdateMandatoryChargeFees = "{559D04BC-6154-43EC-AC8B-2910F82BBC85}";

  [field: AccessedThroughProperty("Label22")]
  private virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGATextBox txtFeeFilter
  {
    get => this._txtFeeFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtFeeFilter_TextChanged);
      MGATextBox txtFeeFilter1 = this._txtFeeFilter;
      if (txtFeeFilter1 != null)
        ((Control) txtFeeFilter1).TextChanged -= eventHandler;
      this._txtFeeFilter = value;
      MGATextBox txtFeeFilter2 = this._txtFeeFilter;
      if (txtFeeFilter2 == null)
        return;
      ((Control) txtFeeFilter2).TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("SqlCommand1")]
  internal virtual SqlCommand SqlCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFullyEarnedDays")]
  private virtual MGANumericEditor txtFullyEarnedDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGACheckBox checkIncludeNonGlobal
  {
    get => this._checkIncludeNonGlobal;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.checkIncludeNonGlobal_CheckedChanged);
      MGACheckBox includeNonGlobal1 = this._checkIncludeNonGlobal;
      if (includeNonGlobal1 != null)
        ((UltraToggleEditorBase) includeNonGlobal1).CheckedChanged -= eventHandler;
      this._checkIncludeNonGlobal = value;
      MGACheckBox includeNonGlobal2 = this._checkIncludeNonGlobal;
      if (includeNonGlobal2 == null)
        return;
      ((UltraToggleEditorBase) includeNonGlobal2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("MgaCheckBox1")]
  protected virtual MGACheckBox MgaCheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingCancel);
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedNew);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingEdit);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingDelete -= cancelEventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickingCancel -= cancelEventHandler3;
        dbSave1.ClickedNew -= eventHandler1;
        dbSave1.ClickingEdit -= cancelEventHandler4;
        dbSave1.UIStateChanged -= eventHandler2;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingDelete += cancelEventHandler1;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickingCancel += cancelEventHandler3;
      dbSave2.ClickedNew += eventHandler1;
      dbSave2.ClickingEdit += cancelEventHandler4;
      dbSave2.UIStateChanged += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("rbRoundUp")]
  private virtual RadioButton rbRoundUp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbRoundToDollar")]
  private virtual RadioButton rbRoundToDollar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbNoRounding")]
  private virtual RadioButton rbNoRounding { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbRoundDown")]
  private virtual RadioButton rbRoundDown { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox1")]
  internal virtual UltraGroupBox UltraGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboKentuckyCities")]
  internal virtual MGASimpleComboBox cboKentuckyCities { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkApplyPackagePolicy")]
  private virtual MGACheckBox chkApplyPackagePolicy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox5")]
  private virtual MGACheckBox MgaCheckBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("optionPremiumAmtAuto")]
  protected virtual UltraOptionSet optionPremiumAmtAuto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkFeeBasedOnNumberVehicles")]
  internal virtual MGACheckBox chkFeeBasedOnNumberVehicles { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("checkPayHomeState")]
  private virtual MGACheckBox checkPayHomeState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("checkMasterPayee")]
  private virtual MGACheckBox checkMasterPayee { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("checkAppliesToAllStates")]
  private virtual MGACheckBox checkAppliesToAllStates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkSLConfig
  {
    get => this._lnkSLConfig;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSLConfig_LinkClicked);
      LinkLabel lnkSlConfig1 = this._lnkSLConfig;
      if (lnkSlConfig1 != null)
        lnkSlConfig1.LinkClicked -= clickedEventHandler;
      this._lnkSLConfig = value;
      LinkLabel lnkSlConfig2 = this._lnkSLConfig;
      if (lnkSlConfig2 == null)
        return;
      lnkSlConfig2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("chkCountInternational")]
  private virtual MGACheckBox chkCountInternational { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkExcInternational")]
  internal virtual MGACheckBox chkExcInternational { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkApplyToChildLines")]
  private virtual MGACheckBox chkApplyToChildLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbRoundCent")]
  private virtual RadioButton rbRoundCent { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbRoundUpToCent")]
  private virtual RadioButton rbRoundUpToCent { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkExcludeMultiCarrier")]
  private virtual MGACheckBox chkExcludeMultiCarrier { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkApplyToFlatCancellations")]
  private virtual MGACheckBox chkApplyToFlatCancellations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkExcludeOriginalBinder")]
  private virtual MGACheckBox chkExcludeOriginalBinder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabHistory")]
  protected virtual UltraTabPageControl tabHistory { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNotes")]
  protected virtual Label lblNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNotes")]
  private virtual MGATextBox txtNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpEdited")]
  internal virtual MGADateTimePicker dtpEdited { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLastEditedDate")]
  protected virtual Label lblLastEditedDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblEditedBy")]
  protected virtual Label lblEditedBy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboEditedBy")]
  private virtual MGASimpleComboBox cboEditedBy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblAddedBy")]
  protected virtual Label lblAddedBy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboAddedBy")]
  private virtual MGASimpleComboBox cboAddedBy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpAddedDate")]
  internal virtual MGADateTimePicker dtpAddedDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lstPolicyTypeExcl")]
  private virtual MGACheckedListBox lstPolicyTypeExcl { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label31")]
  private virtual Label label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("da")]
  private virtual SqlDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand2")]
  private virtual SqlCommand SqlDeleteCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand2")]
  private virtual SqlCommand SqlInsertCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand4")]
  private virtual SqlCommand SqlSelectCommand4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand2")]
  private virtual SqlCommand SqlUpdateCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblAddedDate")]
  protected virtual Label lblAddedDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkCopyFees
  {
    get => this._lnkCopyFees;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopyFees_LinkClicked);
      LinkLabel lnkCopyFees1 = this._lnkCopyFees;
      if (lnkCopyFees1 != null)
        lnkCopyFees1.LinkClicked -= clickedEventHandler;
      this._lnkCopyFees = value;
      LinkLabel lnkCopyFees2 = this._lnkCopyFees;
      if (lnkCopyFees2 == null)
        return;
      lnkCopyFees2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("chkCountyTaxIncRate")]
  internal virtual MGACheckBox chkCountyTaxIncRate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabClientInfo")]
  protected virtual UltraTabPageControl tabClientInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkMandatoryCharge")]
  protected virtual MGACheckBox chkMandatoryCharge { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chckPackageApplyOnce")]
  private virtual MGACheckBox chckPackageApplyOnce { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual RadioButton rbFlat
  {
    get => this._rbFlat;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RadioChanged);
      RadioButton rbFlat1 = this._rbFlat;
      if (rbFlat1 != null)
        rbFlat1.CheckedChanged -= eventHandler;
      this._rbFlat = value;
      RadioButton rbFlat2 = this._rbFlat;
      if (rbFlat2 == null)
        return;
      rbFlat2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbPercentage
  {
    get => this._rbPercentage;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RadioChanged);
      RadioButton rbPercentage1 = this._rbPercentage;
      if (rbPercentage1 != null)
        rbPercentage1.CheckedChanged -= eventHandler;
      this._rbPercentage = value;
      RadioButton rbPercentage2 = this._rbPercentage;
      if (rbPercentage2 == null)
        return;
      rbPercentage2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cboFee")]
  private virtual MGASimpleComboBox cboFee { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daCompanyPolicyCharges")]
  private virtual SqlDataAdapter daCompanyPolicyCharges { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkSplittable")]
  private virtual MGACheckBox chkSplittable { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboFeeComm")]
  private virtual MGASimpleComboBox cboFeeComm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cboOffices
  {
    get => this._cboOffices;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboOffices_BeforeDropDown);
      MGASimpleComboBox cboOffices1 = this._cboOffices;
      if (cboOffices1 != null)
        cboOffices1.BeforeDropDown -= cancelEventHandler;
      this._cboOffices = value;
      MGASimpleComboBox cboOffices2 = this._cboOffices;
      if (cboOffices2 == null)
        return;
      cboOffices2.BeforeDropDown += cancelEventHandler;
    }
  }

  private virtual RadioButton rbPayable
  {
    get => this._rbPayable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangePayableStatus);
      RadioButton rbPayable1 = this._rbPayable;
      if (rbPayable1 != null)
        rbPayable1.CheckedChanged -= eventHandler;
      this._rbPayable = value;
      RadioButton rbPayable2 = this._rbPayable;
      if (rbPayable2 == null)
        return;
      rbPayable2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbPayableTo
  {
    get => this._rbPayableTo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangePayableStatus);
      RadioButton rbPayableTo1 = this._rbPayableTo;
      if (rbPayableTo1 != null)
        rbPayableTo1.CheckedChanged -= eventHandler;
      this._rbPayableTo = value;
      RadioButton rbPayableTo2 = this._rbPayableTo;
      if (rbPayableTo2 == null)
        return;
      rbPayableTo2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblEntityType")]
  private virtual Label lblEntityType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual RadioButton rbNotPayable
  {
    get => this._rbNotPayable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangePayableStatus);
      RadioButton rbNotPayable1 = this._rbNotPayable;
      if (rbNotPayable1 != null)
        rbNotPayable1.CheckedChanged -= eventHandler;
      this._rbNotPayable = value;
      RadioButton rbNotPayable2 = this._rbNotPayable;
      if (rbNotPayable2 == null)
        return;
      rbNotPayable2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtPremiumLess")]
  private virtual MGATextBox txtPremiumLess { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPremiumGreater")]
  private virtual MGATextBox txtPremiumGreater { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid dgFees
  {
    get => this._dgFees;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dgFees_AfterRowActivate);
      UltraGrid dgFees1 = this._dgFees;
      if (dgFees1 != null)
        dgFees1.AfterRowActivate -= eventHandler;
      this._dgFees = value;
      UltraGrid dgFees2 = this._dgFees;
      if (dgFees2 == null)
        return;
      dgFees2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("tabControl")]
  protected virtual UltraTabControl tabControl { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkSelectPayableEntity
  {
    get => this._lnkSelectPayableEntity;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectPayableEntity_LinkClicked);
      LinkLabel selectPayableEntity1 = this._lnkSelectPayableEntity;
      if (selectPayableEntity1 != null)
        selectPayableEntity1.LinkClicked -= clickedEventHandler;
      this._lnkSelectPayableEntity = value;
      LinkLabel selectPayableEntity2 = this._lnkSelectPayableEntity;
      if (selectPayableEntity2 == null)
        return;
      selectPayableEntity2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("tabFeeInfo")]
  protected virtual UltraTabPageControl tabFeeInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox3")]
  internal virtual MGACheckBox MgaCheckBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaDateTimePicker1")]
  internal virtual MGADateTimePicker MgaDateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ToolTip1")]
  internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLicenseTypes")]
  internal virtual MGASimpleComboBox cboLicenseTypes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboStates")]
  internal virtual MGASimpleComboBox cboStates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLines")]
  internal virtual MGASimpleComboBox cboLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboCompanyLocations")]
  internal virtual MGASimpleComboBox cboCompanyLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkTerrorismExcluded")]
  internal virtual MGACheckBox chkTerrorismExcluded { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkFeeBasedOnNumberOfLocations")]
  internal virtual MGACheckBox chkFeeBasedOnNumberOfLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkTaxable
  {
    get => this._lnkTaxable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkTaxable_LinkClicked);
      LinkLabel lnkTaxable1 = this._lnkTaxable;
      if (lnkTaxable1 != null)
        lnkTaxable1.LinkClicked -= clickedEventHandler;
      this._lnkTaxable = value;
      LinkLabel lnkTaxable2 = this._lnkTaxable;
      if (lnkTaxable2 == null)
        return;
      lnkTaxable2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  private virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  private virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  private virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  private virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numMaxStrat")]
  private virtual MGATextBox numMaxStrat { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numMinStrat")]
  private virtual MGATextBox numMinStrat { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label21")]
  private virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Label Label20
  {
    get => this._Label20;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Label20_Click);
      Label label20_1 = this._Label20;
      if (label20_1 != null)
        label20_1.Click -= eventHandler;
      this._Label20 = value;
      Label label20_2 = this._Label20;
      if (label20_2 == null)
        return;
      label20_2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkStateOfIssuanceOnly")]
  internal virtual UltraCheckEditor chkStateOfIssuanceOnly { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdminCompanyPolicyFees));
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
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
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
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblCompanyPolicyCharges", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyFeeID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("FeeTypeID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CompanyLicenceTypeID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Payable");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("PayableEntityGuid");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("PayableEntityType");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("FlatRate");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("PercentageRate");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ApplyPremiumEqualOrLess");
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ApplyPremiumEqualOrOver");
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("AutoApply");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Effective");
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Splittable");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("PayableEntity");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Description", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance55 = new Appearance();
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("Minimum");
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("ExcludeWhenNotFiling");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("ExcludeOnEndorsements");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("ExcludeOnRenewal");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("AppliesToPaymentID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("FullyEarned");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("RoundToDollar");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("MaxPercentage");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("MaxDollars");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("Disabled");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("PercentageNet");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("TerrorismExcluded");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("FeeBasedOnNumberOfLocations");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("StateOfIssuanceOnly");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("MinStrat");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("MaxStrat");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("FullyEarnedNumDays");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("SendToAccounting");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("RoundDown");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("RoundUp");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("NoRounding");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("KentuckyCityID");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("ApplyPackagePolicyOnly");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("DoNotApplyPackagePolicyOnly");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("PremiumAllocationType");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("FeeBasedOnNumberOfVehicles");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("AppliesToAllStates");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("MasterPayee");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("PayHomeState");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("InternationalStratification");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("ExcludeInternationalPremiums");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("ApplyToChildLines");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("RoundToCent");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("RoundUpToCent");
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("ExcludeMultiCarrier");
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("ApplytoFlatCanc");
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("ExcludeOriginalBinder");
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("AddedBy");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("EditedBy");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("AddedDate");
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("EditedDate");
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("Notes");
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("CountyTaxIncludedInRate");
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("MandatoryCharge");
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("ApplyOnce");
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance65 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance66 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance67 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance68 = new Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Appearance appearance69 = new Appearance();
    UltraTab ultraTab6 = new UltraTab();
    Appearance appearance70 = new Appearance();
    UltraTab ultraTab7 = new UltraTab();
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    Appearance appearance73 = new Appearance();
    this.tabFeeInfo = new UltraTabPageControl();
    this.chkCountyTaxIncRate = new MGACheckBox();
    this.dsFees = new dsCompanyPolicyFees();
    this.lnkCopyFees = new LinkLabel();
    this.lnkSLConfig = new LinkLabel();
    this.chkFeeBasedOnNumberVehicles = new MGACheckBox();
    this.cboKentuckyCities = new MGASimpleComboBox();
    this.Label24 = new Label();
    this.MgaCheckBox1 = new MGACheckBox();
    this.txtFullyEarnedDays = new MGANumericEditor();
    this.lnkTaxable = new LinkLabel();
    this.chkFeeBasedOnNumberOfLocations = new MGACheckBox();
    this.chkTerrorismExcluded = new MGACheckBox();
    this.cboLicenseTypes = new MGASimpleComboBox();
    this.Label15 = new Label();
    this.cboStates = new MGASimpleComboBox();
    this.Label14 = new Label();
    this.cboLines = new MGASimpleComboBox();
    this.Label13 = new Label();
    this.cboCompanyLocations = new MGASimpleComboBox();
    this.Label12 = new Label();
    this.MgaDateTimePicker1 = new MGADateTimePicker();
    this.Label11 = new Label();
    this.MgaCheckBox3 = new MGACheckBox();
    this.chkFullyEarned = new MGACheckBox();
    this.cboFee = new MGASimpleComboBox();
    this.dtEffective = new MGADateTimePicker();
    this.Label1 = new Label();
    this.lblOffices = new Label();
    this.Label8 = new Label();
    this.Label2 = new Label();
    this.cboOffices = new MGASimpleComboBox();
    this.cboInstallmentBilling = new MGASimpleComboBox();
    this.Label6 = new Label();
    this.chkSplittable = new MGACheckBox();
    this.Label5 = new Label();
    this.cboFeeComm = new MGASimpleComboBox();
    this.Panel1 = new Panel();
    this.txtPercentageMinimum = new MGANumericEditor();
    this.Label7 = new Label();
    this.rbFlat = new RadioButton();
    this.rbPercentage = new RadioButton();
    this.txtFlatFee = new MGATextBox();
    this.txtPercentage = new MGATextBox();
    this.chkExcInternational = new MGACheckBox();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.tabClientInfo = new UltraTabPageControl();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.chckPackageApplyOnce = new MGACheckBox();
    this.chkMandatoryCharge = new MGACheckBox();
    this.chkApplyToFlatCancellations = new MGACheckBox();
    this.chkCountInternational = new MGACheckBox();
    this.checkAppliesToAllStates = new MGACheckBox();
    this.optionPremiumAmtAuto = new UltraOptionSet();
    this.chkApplyToChildLines = new MGACheckBox();
    this.chkApplyPackagePolicy = new MGACheckBox();
    this.UltraGroupBox1 = new UltraGroupBox();
    this.rbNoRounding = new RadioButton();
    this.rbRoundToDollar = new RadioButton();
    this.rbRoundUpToCent = new RadioButton();
    this.rbRoundCent = new RadioButton();
    this.rbRoundDown = new RadioButton();
    this.rbRoundUp = new RadioButton();
    this.Label21 = new Label();
    this.Label20 = new Label();
    this.Label19 = new Label();
    this.Label18 = new Label();
    this.Label17 = new Label();
    this.Label16 = new Label();
    this.numMaxStrat = new MGATextBox();
    this.numMinStrat = new MGATextBox();
    this.chkStateOfIssuanceOnly = new UltraCheckEditor();
    this.chkAutoApply = new MGACheckBox();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.txtPremiumLess = new MGATextBox();
    this.txtPremiumGreater = new MGATextBox();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.checkMasterPayee = new MGACheckBox();
    this.lnkSelectPayableEntity = new LinkLabel();
    this.rbNotPayable = new RadioButton();
    this.rbPayableTo = new RadioButton();
    this.rbPayable = new RadioButton();
    this.lblPayableTo = new MGATextBox();
    this.UltraTabPageControl4 = new UltraTabPageControl();
    this.lstPolicyTypeExcl = new MGACheckedListBox();
    this.label31 = new Label();
    this.chkExcludeOriginalBinder = new MGACheckBox();
    this.checkPayHomeState = new MGACheckBox();
    this.MgaCheckBox5 = new MGACheckBox();
    this.chkExcludeMultiCarrier = new MGACheckBox();
    this.MgaCheckBox2 = new MGACheckBox();
    this.chkExcludeEndorsements = new MGACheckBox();
    this.chkExcludeFiling = new MGACheckBox();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.txtMaxDollars = new MGANumericEditor();
    this.txtMaxPercentage = new MGANumericEditor();
    this.Label10 = new Label();
    this.Label9 = new Label();
    this.tabHistory = new UltraTabPageControl();
    this.lblNotes = new Label();
    this.txtNotes = new MGATextBox();
    this.dtpEdited = new MGADateTimePicker();
    this.lblLastEditedDate = new Label();
    this.lblEditedBy = new Label();
    this.cboEditedBy = new MGASimpleComboBox();
    this.lblAddedBy = new Label();
    this.cboAddedBy = new MGASimpleComboBox();
    this.dtpAddedDate = new MGADateTimePicker();
    this.lblAddedDate = new Label();
    this.err = new ErrorProvider(this.components);
    this.daCompanyPolicyCharges = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.lblEntityGuid = new Label();
    this.lblEntityType = new Label();
    this.dgFees = new UltraGrid();
    this.tabControl = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.ToolTip1 = new ToolTip(this.components);
    this.Label22 = new Label();
    this.txtFeeFilter = new MGATextBox();
    this.checkIncludeNonGlobal = new MGACheckBox();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand4 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    PictureBox pictureBox = new PictureBox();
    Label label = new Label();
    ((ISupportInitialize) pictureBox).BeginInit();
    ((Control) this.tabFeeInfo).SuspendLayout();
    ((ISupportInitialize) this.chkCountyTaxIncRate).BeginInit();
    this.dsFees.BeginInit();
    ((ISupportInitialize) this.chkFeeBasedOnNumberVehicles).BeginInit();
    ((ISupportInitialize) this.cboKentuckyCities).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox1).BeginInit();
    ((ISupportInitialize) this.txtFullyEarnedDays).BeginInit();
    ((ISupportInitialize) this.chkFeeBasedOnNumberOfLocations).BeginInit();
    ((ISupportInitialize) this.chkTerrorismExcluded).BeginInit();
    ((ISupportInitialize) this.cboLicenseTypes).BeginInit();
    ((ISupportInitialize) this.cboStates).BeginInit();
    ((ISupportInitialize) this.cboLines).BeginInit();
    ((ISupportInitialize) this.cboCompanyLocations).BeginInit();
    ((ISupportInitialize) this.MgaDateTimePicker1).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox3).BeginInit();
    ((ISupportInitialize) this.chkFullyEarned).BeginInit();
    ((ISupportInitialize) this.cboFee).BeginInit();
    ((ISupportInitialize) this.dtEffective).BeginInit();
    ((ISupportInitialize) this.cboOffices).BeginInit();
    ((ISupportInitialize) this.cboInstallmentBilling).BeginInit();
    ((ISupportInitialize) this.chkSplittable).BeginInit();
    ((ISupportInitialize) this.cboFeeComm).BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.txtPercentageMinimum).BeginInit();
    ((ISupportInitialize) this.txtFlatFee).BeginInit();
    ((ISupportInitialize) this.txtPercentage).BeginInit();
    ((ISupportInitialize) this.chkExcInternational).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.chckPackageApplyOnce).BeginInit();
    ((ISupportInitialize) this.chkMandatoryCharge).BeginInit();
    ((ISupportInitialize) this.chkApplyToFlatCancellations).BeginInit();
    ((ISupportInitialize) this.chkCountInternational).BeginInit();
    ((ISupportInitialize) this.checkAppliesToAllStates).BeginInit();
    ((ISupportInitialize) this.optionPremiumAmtAuto).BeginInit();
    ((ISupportInitialize) this.chkApplyToChildLines).BeginInit();
    ((ISupportInitialize) this.chkApplyPackagePolicy).BeginInit();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.numMaxStrat).BeginInit();
    ((ISupportInitialize) this.numMinStrat).BeginInit();
    ((ISupportInitialize) this.chkStateOfIssuanceOnly).BeginInit();
    ((ISupportInitialize) this.chkAutoApply).BeginInit();
    ((ISupportInitialize) this.txtPremiumLess).BeginInit();
    ((ISupportInitialize) this.txtPremiumGreater).BeginInit();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.checkMasterPayee).BeginInit();
    ((ISupportInitialize) this.lblPayableTo).BeginInit();
    ((Control) this.UltraTabPageControl4).SuspendLayout();
    ((ISupportInitialize) this.lstPolicyTypeExcl).BeginInit();
    ((ISupportInitialize) this.chkExcludeOriginalBinder).BeginInit();
    ((ISupportInitialize) this.checkPayHomeState).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox5).BeginInit();
    ((ISupportInitialize) this.chkExcludeMultiCarrier).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox2).BeginInit();
    ((ISupportInitialize) this.chkExcludeEndorsements).BeginInit();
    ((ISupportInitialize) this.chkExcludeFiling).BeginInit();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.txtMaxDollars).BeginInit();
    ((ISupportInitialize) this.txtMaxPercentage).BeginInit();
    ((Control) this.tabHistory).SuspendLayout();
    ((ISupportInitialize) this.txtNotes).BeginInit();
    ((ISupportInitialize) this.dtpEdited).BeginInit();
    ((ISupportInitialize) this.cboEditedBy).BeginInit();
    ((ISupportInitialize) this.cboAddedBy).BeginInit();
    ((ISupportInitialize) this.dtpAddedDate).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.dgFees).BeginInit();
    ((ISupportInitialize) this.tabControl).BeginInit();
    ((Control) this.tabControl).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.txtFeeFilter).BeginInit();
    ((ISupportInitialize) this.checkIncludeNonGlobal).BeginInit();
    this.SuspendLayout();
    pictureBox.BackColor = Color.Transparent;
    pictureBox.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    pictureBox.Location = new Point(64 /*0x40*/, 263);
    pictureBox.Name = "PictureBox1";
    pictureBox.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
    pictureBox.TabIndex = 32 /*0x20*/;
    pictureBox.TabStop = false;
    label.AutoSize = true;
    label.BackColor = Color.Transparent;
    label.Location = new Point(671, 183);
    label.Name = "Label23";
    label.Size = new Size(35, 13);
    label.TabIndex = 30;
    label.Text = "Days:";
    label.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.chkCountyTaxIncRate);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.lnkCopyFees);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.lnkSLConfig);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.chkFeeBasedOnNumberVehicles);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.cboKentuckyCities);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.Label24);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.MgaCheckBox1);
    ((Control) this.tabFeeInfo).Controls.Add((Control) pictureBox);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.txtFullyEarnedDays);
    ((Control) this.tabFeeInfo).Controls.Add((Control) label);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.lnkTaxable);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.chkFeeBasedOnNumberOfLocations);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.chkTerrorismExcluded);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.cboLicenseTypes);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.Label15);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.cboStates);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.Label14);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.cboLines);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.Label13);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.cboCompanyLocations);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.Label12);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.MgaDateTimePicker1);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.Label11);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.MgaCheckBox3);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.chkFullyEarned);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.cboFee);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.dtEffective);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.Label1);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.lblOffices);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.Label8);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.Label2);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.cboOffices);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.cboInstallmentBilling);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.Label6);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.chkSplittable);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.Label5);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.cboFeeComm);
    ((Control) this.tabFeeInfo).Controls.Add((Control) this.Panel1);
    ((Control) this.tabFeeInfo).Location = new Point(-10000, -10000);
    ((Control) this.tabFeeInfo).Name = "tabFeeInfo";
    ((Control) this.tabFeeInfo).Size = new Size(793, 328);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCountyTaxIncRate).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.chkCountyTaxIncRate).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCountyTaxIncRate).BackColorInternal = Color.Transparent;
    ((Control) this.chkCountyTaxIncRate).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.CountyTaxIncludedInRate", true));
    ((UltraToggleEditorBase) this.chkCountyTaxIncRate).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCountyTaxIncRate).Location = new Point(384, 186);
    this.chkCountyTaxIncRate.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCountyTaxIncRate).Name = "chkCountyTaxIncRate";
    ((Control) this.chkCountyTaxIncRate).Size = new Size(175, 24);
    ((Control) this.chkCountyTaxIncRate).TabIndex = 40;
    ((UltraToggleEditorBase) this.chkCountyTaxIncRate).Text = "County Tax Included in Rate";
    ((UltraControlBase) this.chkCountyTaxIncRate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCountyTaxIncRate).UseOsThemes = (DefaultableBoolean) 2;
    this.dsFees.DataSetName = "dsCompanyPolicyFees";
    this.dsFees.Locale = new CultureInfo("en-US");
    this.dsFees.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lnkCopyFees.AutoSize = true;
    this.lnkCopyFees.BackColor = Color.Transparent;
    this.lnkCopyFees.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lnkCopyFees.Location = new Point(81, 308);
    this.lnkCopyFees.Name = "lnkCopyFees";
    this.lnkCopyFees.Size = new Size(63 /*0x3F*/, 14);
    this.lnkCopyFees.TabIndex = 38;
    this.lnkCopyFees.TabStop = true;
    this.lnkCopyFees.Text = "Copy Fees";
    this.lnkCopyFees.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkSLConfig.AutoSize = true;
    this.lnkSLConfig.BackColor = Color.Transparent;
    this.lnkSLConfig.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lnkSLConfig.Location = new Point(81, 286);
    this.lnkSLConfig.Name = "lnkSLConfig";
    this.lnkSLConfig.Size = new Size(115, 14);
    this.lnkSLConfig.TabIndex = 37;
    this.lnkSLConfig.TabStop = true;
    this.lnkSLConfig.Text = "Surplus Lines Config";
    this.lnkSLConfig.TextAlign = ContentAlignment.MiddleLeft;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFeeBasedOnNumberVehicles).Appearance = (AppearanceBase) appearance2;
    ((UltraToggleEditorBase) this.chkFeeBasedOnNumberVehicles).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFeeBasedOnNumberVehicles).BackColorInternal = Color.Transparent;
    ((Control) this.chkFeeBasedOnNumberVehicles).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.FeeBasedOnNumberOfVehicles", true));
    ((UltraToggleEditorBase) this.chkFeeBasedOnNumberVehicles).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFeeBasedOnNumberVehicles).Location = new Point(384, 272);
    this.chkFeeBasedOnNumberVehicles.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkFeeBasedOnNumberVehicles).Name = "chkFeeBasedOnNumberVehicles";
    ((Control) this.chkFeeBasedOnNumberVehicles).Size = new Size(211, 23);
    ((Control) this.chkFeeBasedOnNumberVehicles).TabIndex = 36;
    ((UltraToggleEditorBase) this.chkFeeBasedOnNumberVehicles).Text = "Fee Multiplied by Number of Vehicles";
    ((UltraControlBase) this.chkFeeBasedOnNumberVehicles).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFeeBasedOnNumberVehicles).UseOsThemes = (DefaultableBoolean) 2;
    this.cboKentuckyCities.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboKentuckyCities).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.KentuckyCityID", true));
    ((UltraGridBase) this.cboKentuckyCities).DataMember = "tblKentuckyCities";
    ((UltraGridBase) this.cboKentuckyCities).DataSource = (object) this.dsFees;
    ((UltraDropDownBase) this.cboKentuckyCities).DisplayMember = "City";
    this.cboKentuckyCities.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboKentuckyCities).DropDownWidth = 350;
    ((Control) this.cboKentuckyCities).Location = new Point(84, 125);
    this.cboKentuckyCities.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboKentuckyCities).Name = "cboKentuckyCities";
    ((Control) this.cboKentuckyCities).Size = new Size(280, 21);
    ((Control) this.cboKentuckyCities).TabIndex = 35;
    this.ToolTip1.SetToolTip((Control) this.cboKentuckyCities, "Kentucky City");
    ((UltraControlBase) this.cboKentuckyCities).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboKentuckyCities).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboKentuckyCities).ValueMember = "CityID";
    this.Label24.AutoSize = true;
    this.Label24.BackColor = Color.Transparent;
    this.Label24.Location = new Point(14, 129);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(30, 13);
    this.Label24.TabIndex = 34;
    this.Label24.Text = "City:";
    this.Label24.TextAlign = ContentAlignment.MiddleRight;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox1).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.SendToAccounting", true));
    ((UltraToggleEditorBase) this.MgaCheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox1).Location = new Point(384, 299);
    this.MgaCheckBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaCheckBox1).Name = "MgaCheckBox1";
    ((Control) this.MgaCheckBox1).Size = new Size(123, 24);
    ((Control) this.MgaCheckBox1).TabIndex = 33;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Text = "Send to Accounting";
    ((UltraControlBase) this.MgaCheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraNumericEditorBase) this.txtFullyEarnedDays).Appearance = (AppearanceBase) appearance4;
    ((UltraNumericEditorBase) this.txtFullyEarnedDays).BackColor = Color.White;
    ((Control) this.txtFullyEarnedDays).CausesValidation = false;
    ((Control) this.txtFullyEarnedDays).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.FullyEarnedNumDays", true));
    ((UltraNumericEditorBase) this.txtFullyEarnedDays).FormatString = "";
    ((Control) this.txtFullyEarnedDays).Location = new Point(712, 179);
    this.txtFullyEarnedDays.MaskInput = "nnn";
    this.txtFullyEarnedDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFullyEarnedDays).Name = "txtFullyEarnedDays";
    this.txtFullyEarnedDays.Nullable = true;
    ((Control) this.txtFullyEarnedDays).Size = new Size(30, 20);
    ((Control) this.txtFullyEarnedDays).TabIndex = 31 /*0x1F*/;
    ((UltraControlBase) this.txtFullyEarnedDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFullyEarnedDays).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkTaxable.AutoSize = true;
    this.lnkTaxable.BackColor = Color.Transparent;
    this.lnkTaxable.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lnkTaxable.Location = new Point(81, 264);
    this.lnkTaxable.Name = "lnkTaxable";
    this.lnkTaxable.Size = new Size(144 /*0x90*/, 14);
    this.lnkTaxable.TabIndex = 29;
    this.lnkTaxable.TabStop = true;
    this.lnkTaxable.Text = "Configure Taxable States";
    this.lnkTaxable.TextAlign = ContentAlignment.MiddleLeft;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFeeBasedOnNumberOfLocations).Appearance = (AppearanceBase) appearance5;
    ((UltraToggleEditorBase) this.chkFeeBasedOnNumberOfLocations).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFeeBasedOnNumberOfLocations).BackColorInternal = Color.Transparent;
    ((Control) this.chkFeeBasedOnNumberOfLocations).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.FeeBasedOnNumberOfLocations", true));
    ((UltraToggleEditorBase) this.chkFeeBasedOnNumberOfLocations).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFeeBasedOnNumberOfLocations).Location = new Point(384, 244);
    this.chkFeeBasedOnNumberOfLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkFeeBasedOnNumberOfLocations).Name = "chkFeeBasedOnNumberOfLocations";
    ((Control) this.chkFeeBasedOnNumberOfLocations).Size = new Size(217, 24);
    ((Control) this.chkFeeBasedOnNumberOfLocations).TabIndex = 12;
    ((UltraToggleEditorBase) this.chkFeeBasedOnNumberOfLocations).Text = "Fee Multiplied by Number of Locations";
    ((UltraControlBase) this.chkFeeBasedOnNumberOfLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFeeBasedOnNumberOfLocations).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkTerrorismExcluded).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.chkTerrorismExcluded).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkTerrorismExcluded).BackColorInternal = Color.Transparent;
    ((Control) this.chkTerrorismExcluded).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.TerrorismExcluded", true));
    ((UltraToggleEditorBase) this.chkTerrorismExcluded).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkTerrorismExcluded).Location = new Point(384, 216);
    this.chkTerrorismExcluded.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkTerrorismExcluded).Name = "chkTerrorismExcluded";
    ((Control) this.chkTerrorismExcluded).Size = new Size(196, 24);
    ((Control) this.chkTerrorismExcluded).TabIndex = 11;
    ((UltraToggleEditorBase) this.chkTerrorismExcluded).Text = "Exclude Terrorism In Calculation";
    ((UltraControlBase) this.chkTerrorismExcluded).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkTerrorismExcluded).UseOsThemes = (DefaultableBoolean) 2;
    this.cboLicenseTypes.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLicenseTypes).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.CompanyLicenceTypeID", true));
    ((UltraGridBase) this.cboLicenseTypes).DataSource = (object) this.dsFees.lstCompanyLicenseTypes;
    ((UltraDropDownBase) this.cboLicenseTypes).DisplayMember = "CompanyLicenceType";
    this.cboLicenseTypes.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLicenseTypes).DropDownWidth = 350;
    ((Control) this.cboLicenseTypes).Location = new Point(84, 152);
    this.cboLicenseTypes.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLicenseTypes).Name = "cboLicenseTypes";
    ((Control) this.cboLicenseTypes).Size = new Size(280, 21);
    ((Control) this.cboLicenseTypes).TabIndex = 26;
    ((UltraControlBase) this.cboLicenseTypes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLicenseTypes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLicenseTypes).ValueMember = "CompanyLicenceTypeID";
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(14, 156);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(46, 13);
    this.Label15.TabIndex = 25;
    this.Label15.Text = "License:";
    this.Label15.TextAlign = ContentAlignment.MiddleRight;
    this.cboStates.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboStates).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.StateID", true));
    ((UltraGridBase) this.cboStates).DataSource = (object) this.dsFees.lstStates;
    ((UltraDropDownBase) this.cboStates).DisplayMember = "State";
    this.cboStates.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboStates).DropDownWidth = 350;
    ((Control) this.cboStates).Location = new Point(84, 98);
    this.cboStates.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboStates).Name = "cboStates";
    ((Control) this.cboStates).Size = new Size(280, 21);
    ((Control) this.cboStates).TabIndex = 3;
    ((UltraControlBase) this.cboStates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboStates).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboStates).ValueMember = "StateID";
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(14, 102);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(37, 13);
    this.Label14.TabIndex = 23;
    this.Label14.Text = "State:";
    this.Label14.TextAlign = ContentAlignment.MiddleRight;
    this.cboLines.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLines).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.LineGuid", true));
    ((UltraGridBase) this.cboLines).DataSource = (object) this.dsFees.lstLines;
    ((UltraDropDownBase) this.cboLines).DisplayMember = "LineName";
    this.cboLines.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLines).DropDownWidth = 350;
    ((Control) this.cboLines).Location = new Point(84, 70);
    this.cboLines.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLines).Name = "cboLines";
    ((Control) this.cboLines).Size = new Size(370, 21);
    ((Control) this.cboLines).TabIndex = 2;
    ((UltraControlBase) this.cboLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLines).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLines).ValueMember = "LineGuid";
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(14, 74);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(30, 13);
    this.Label13.TabIndex = 21;
    this.Label13.Text = "Line:";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    this.cboCompanyLocations.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboCompanyLocations).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.CompanyLocationGuid", true));
    ((UltraGridBase) this.cboCompanyLocations).DataSource = (object) this.dsFees.tblCompanyLocations;
    ((UltraDropDownBase) this.cboCompanyLocations).DisplayMember = "LocationName";
    this.cboCompanyLocations.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCompanyLocations).DropDownWidth = 550;
    ((Control) this.cboCompanyLocations).Location = new Point(84, 42);
    this.cboCompanyLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompanyLocations).Name = "cboCompanyLocations";
    ((Control) this.cboCompanyLocations).Size = new Size(370, 21);
    ((Control) this.cboCompanyLocations).TabIndex = 1;
    ((UltraControlBase) this.cboCompanyLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanyLocations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompanyLocations).ValueMember = "CompanyLocationGuid";
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(14, 46);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(56, 13);
    this.Label12.TabIndex = 19;
    this.Label12.Text = "Company:";
    this.Label12.TextAlign = ContentAlignment.MiddleRight;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaDateTimePicker1.Appearance = (AppearanceBase) appearance7;
    appearance8.AlphaLevel = (short) 14;
    appearance8.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance8.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance8.BackColorAlpha = (Alpha) 2;
    appearance8.BackGradientAlignment = (GradientAlignment) 4;
    appearance8.BackGradientStyle = (GradientStyle) 5;
    appearance8.BorderAlpha = (Alpha) 1;
    appearance8.BorderColor = Color.FromArgb(78, 122, 171);
    appearance8.ForeColor = Color.FromArgb(49, 85, 153);
    appearance8.ForegroundAlpha = (Alpha) 2;
    this.MgaDateTimePicker1.ButtonAppearance = (AppearanceBase) appearance8;
    ((Control) this.MgaDateTimePicker1).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.Disabled", true));
    this.MgaDateTimePicker1.DateTime = new DateTime(2004, 2, 3, 14, 54, 42, 449);
    ((Control) this.MgaDateTimePicker1).Location = new Point(566, 126);
    this.MgaDateTimePicker1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaDateTimePicker1).Name = "MgaDateTimePicker1";
    ((Control) this.MgaDateTimePicker1).Size = new Size(105, 20);
    ((Control) this.MgaDateTimePicker1).TabIndex = 8;
    ((UltraControlBase) this.MgaDateTimePicker1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaDateTimePicker1).UseOsThemes = (DefaultableBoolean) 2;
    this.MgaDateTimePicker1.Value = (object) new DateTime(2004, 2, 3, 14, 54, 42, 449);
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(508, 130);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(51, 13);
    this.Label11.TabIndex = 17;
    this.Label11.Text = "Disabled:";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox3).Appearance = (AppearanceBase) appearance9;
    ((UltraToggleEditorBase) this.MgaCheckBox3).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox3).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox3).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.PercentageNet", true));
    ((UltraToggleEditorBase) this.MgaCheckBox3).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox3).Location = new Point(294, 202);
    this.MgaCheckBox3.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaCheckBox3).Name = "MgaCheckBox3";
    ((Control) this.MgaCheckBox3).Size = new Size(70, 24);
    ((Control) this.MgaCheckBox3).TabIndex = 16 /*0x10*/;
    ((UltraToggleEditorBase) this.MgaCheckBox3).Text = "% of Net";
    ((UltraControlBase) this.MgaCheckBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox3).UseOsThemes = (DefaultableBoolean) 2;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFullyEarned).Appearance = (AppearanceBase) appearance10;
    ((UltraToggleEditorBase) this.chkFullyEarned).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFullyEarned).BackColorInternal = Color.Transparent;
    ((Control) this.chkFullyEarned).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.FullyEarned", true));
    ((UltraToggleEditorBase) this.chkFullyEarned).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFullyEarned).Location = new Point(566, 175);
    this.chkFullyEarned.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkFullyEarned).Name = "chkFullyEarned";
    ((Control) this.chkFullyEarned).Size = new Size(98, 28);
    ((Control) this.chkFullyEarned).TabIndex = 10;
    ((UltraToggleEditorBase) this.chkFullyEarned).Text = "Fully Earned";
    ((UltraControlBase) this.chkFullyEarned).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFullyEarned).UseOsThemes = (DefaultableBoolean) 2;
    this.cboFee.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboFee).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.ChargeCode", true));
    ((UltraGridBase) this.cboFee).DataSource = (object) this.dsFees.tblFin_PolicyCharges;
    ((UltraDropDownBase) this.cboFee).DisplayMember = "Description";
    this.cboFee.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboFee).DropDownWidth = 350;
    ((Control) this.cboFee).Location = new Point(84, 14);
    this.cboFee.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboFee).Name = "cboFee";
    ((Control) this.cboFee).Size = new Size(370, 21);
    ((Control) this.cboFee).TabIndex = 0;
    ((UltraControlBase) this.cboFee).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboFee).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboFee).ValueMember = "ChargeCode";
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtEffective.Appearance = (AppearanceBase) appearance11;
    appearance12.AlphaLevel = (short) 14;
    appearance12.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance12.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance12.BackColorAlpha = (Alpha) 2;
    appearance12.BackGradientAlignment = (GradientAlignment) 4;
    appearance12.BackGradientStyle = (GradientStyle) 5;
    appearance12.BorderAlpha = (Alpha) 1;
    appearance12.BorderColor = Color.FromArgb(78, 122, 171);
    appearance12.ForeColor = Color.FromArgb(49, 85, 153);
    appearance12.ForegroundAlpha = (Alpha) 2;
    this.dtEffective.ButtonAppearance = (AppearanceBase) appearance12;
    ((Control) this.dtEffective).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.Effective", true));
    this.dtEffective.DateTime = new DateTime(2004, 2, 3, 14, 54, 42, 449);
    ((Control) this.dtEffective).Location = new Point(566, 14);
    this.dtEffective.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtEffective).Name = "dtEffective";
    ((Control) this.dtEffective).Size = new Size(105, 20);
    ((Control) this.dtEffective).TabIndex = 4;
    ((UltraControlBase) this.dtEffective).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEffective).UseOsThemes = (DefaultableBoolean) 2;
    this.dtEffective.Value = (object) new DateTime(2004, 2, 3, 14, 54, 42, 449);
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(14, 18);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(29, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Fee:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.lblOffices.AutoSize = true;
    this.lblOffices.BackColor = Color.Transparent;
    this.lblOffices.Location = new Point(519, 74);
    this.lblOffices.Name = "lblOffices";
    this.lblOffices.Size = new Size(40, 13);
    this.lblOffices.TabIndex = 10;
    this.lblOffices.Text = "Office:";
    this.lblOffices.TextAlign = ContentAlignment.MiddleRight;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(466, 102);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(93, 13);
    this.Label8.TabIndex = 12;
    this.Label8.Text = "Installment Billing:";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(14, 179);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(35, 23);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Type:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.cboOffices.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboOffices).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.OfficeID", true));
    ((UltraGridBase) this.cboOffices).DataSource = (object) this.dsFees.tblClientOffices;
    ((UltraDropDownBase) this.cboOffices).DisplayMember = "Location";
    this.cboOffices.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboOffices).DropDownWidth = 350;
    ((Control) this.cboOffices).Location = new Point(566, 70);
    this.cboOffices.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboOffices).Name = "cboOffices";
    ((Control) this.cboOffices).Size = new Size(210, 21);
    ((Control) this.cboOffices).TabIndex = 6;
    ((UltraControlBase) this.cboOffices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboOffices).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboOffices).ValueMember = "OfficeID";
    this.cboInstallmentBilling.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboInstallmentBilling).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.AppliesToPaymentID", true));
    ((UltraGridBase) this.cboInstallmentBilling).DataSource = (object) this.dsFees.lstFeeAppliesToPayment;
    ((UltraDropDownBase) this.cboInstallmentBilling).DisplayMember = "Description";
    this.cboInstallmentBilling.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboInstallmentBilling).Location = new Point(566, 98);
    this.cboInstallmentBilling.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboInstallmentBilling).Name = "cboInstallmentBilling";
    ((Control) this.cboInstallmentBilling).Size = new Size(210, 21);
    ((Control) this.cboInstallmentBilling).TabIndex = 7;
    ((UltraControlBase) this.cboInstallmentBilling).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInstallmentBilling).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInstallmentBilling).ValueMember = "ID";
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(505, 18);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(54, 13);
    this.Label6.TabIndex = 6;
    this.Label6.Text = "Effective:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkSplittable).Appearance = (AppearanceBase) appearance13;
    ((UltraToggleEditorBase) this.chkSplittable).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkSplittable).BackColorInternal = Color.Transparent;
    ((Control) this.chkSplittable).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.Splittable", true));
    ((UltraToggleEditorBase) this.chkSplittable).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkSplittable).Location = new Point(566, 154);
    this.chkSplittable.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkSplittable).Name = "chkSplittable";
    ((Control) this.chkSplittable).Size = new Size(140, 28);
    ((Control) this.chkSplittable).TabIndex = 9;
    ((UltraToggleEditorBase) this.chkSplittable).Text = "Split by participation %";
    this.ToolTip1.SetToolTip((Control) this.chkSplittable, "Determines if a fee will be split by the company participation percentage on multi-company policies");
    ((UltraControlBase) this.chkSplittable).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkSplittable).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(473, 46);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(86, 13);
    this.Label5.TabIndex = 8;
    this.Label5.Text = "Commissionable:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.cboFeeComm.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboFeeComm).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.FeeTypeID", true));
    ((UltraGridBase) this.cboFeeComm).DataSource = (object) this.dsFees.lstFeeTypes;
    ((UltraDropDownBase) this.cboFeeComm).DisplayMember = "FeeType";
    this.cboFeeComm.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboFeeComm).Location = new Point(566, 42);
    this.cboFeeComm.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboFeeComm).Name = "cboFeeComm";
    ((Control) this.cboFeeComm).Size = new Size(210, 21);
    ((Control) this.cboFeeComm).TabIndex = 5;
    ((UltraControlBase) this.cboFeeComm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboFeeComm).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboFeeComm).ValueMember = "ID";
    this.Panel1.BackColor = Color.Transparent;
    this.Panel1.Controls.Add((Control) this.txtPercentageMinimum);
    this.Panel1.Controls.Add((Control) this.Label7);
    this.Panel1.Controls.Add((Control) this.rbFlat);
    this.Panel1.Controls.Add((Control) this.rbPercentage);
    this.Panel1.Controls.Add((Control) this.txtFlatFee);
    this.Panel1.Controls.Add((Control) this.txtPercentage);
    this.Panel1.Controls.Add((Control) this.chkExcInternational);
    this.Panel1.Location = new Point(84, 181);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(210, 70);
    this.Panel1.TabIndex = 3;
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((UltraNumericEditorBase) this.txtPercentageMinimum).Appearance = (AppearanceBase) appearance14;
    ((UltraNumericEditorBase) this.txtPercentageMinimum).BackColor = Color.White;
    ((Control) this.txtPercentageMinimum).CausesValidation = false;
    ((Control) this.txtPercentageMinimum).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.Minimum", true));
    ((UltraNumericEditorBase) this.txtPercentageMinimum).FormatString = "c";
    ((Control) this.txtPercentageMinimum).Location = new Point(154, 45);
    this.txtPercentageMinimum.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPercentageMinimum).Name = "txtPercentageMinimum";
    this.txtPercentageMinimum.Nullable = true;
    ((Control) this.txtPercentageMinimum).Size = new Size(49, 20);
    ((Control) this.txtPercentageMinimum).TabIndex = 5;
    ((UltraControlBase) this.txtPercentageMinimum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPercentageMinimum).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.Location = new Point(91, 49);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(56, 12);
    this.Label7.TabIndex = 4;
    this.Label7.Text = "Minimum:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.rbFlat.Checked = true;
    this.rbFlat.Location = new Point(0, 0);
    this.rbFlat.Name = "rbFlat";
    this.rbFlat.Size = new Size(77, 24);
    this.rbFlat.TabIndex = 0;
    this.rbFlat.TabStop = true;
    this.rbFlat.Text = "Flat Fee of";
    this.rbPercentage.Location = new Point(0, 21);
    this.rbPercentage.Name = "rbPercentage";
    this.rbPercentage.Size = new Size(154, 24);
    this.rbPercentage.TabIndex = 2;
    this.rbPercentage.Text = "Percentage of Premium of";
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFlatFee).Appearance = (AppearanceBase) appearance15;
    ((TextEditorControlBase) this.txtFlatFee).BackColor = Color.White;
    ((Control) this.txtFlatFee).DataBindings.Add(new Binding("Text", (object) this.dsFees, "tblCompanyPolicyCharges.FlatRate", true));
    ((Control) this.txtFlatFee).Location = new Point(77, 0);
    this.txtFlatFee.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFlatFee).Name = "txtFlatFee";
    ((Control) this.txtFlatFee).Size = new Size(63 /*0x3F*/, 20);
    ((Control) this.txtFlatFee).TabIndex = 1;
    ((UltraControlBase) this.txtFlatFee).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFlatFee).UseOsThemes = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPercentage).Appearance = (AppearanceBase) appearance16;
    ((TextEditorControlBase) this.txtPercentage).BackColor = Color.White;
    ((Control) this.txtPercentage).DataBindings.Add(new Binding("Text", (object) this.dsFees, "tblCompanyPolicyCharges.PercentageRate", true));
    ((Control) this.txtPercentage).Enabled = false;
    ((Control) this.txtPercentage).Location = new Point(154, 21);
    this.txtPercentage.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPercentage).Name = "txtPercentage";
    ((Control) this.txtPercentage).Size = new Size(49, 20);
    ((Control) this.txtPercentage).TabIndex = 3;
    ((UltraControlBase) this.txtPercentage).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPercentage).UseOsThemes = (DefaultableBoolean) 2;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkExcInternational).Appearance = (AppearanceBase) appearance17;
    ((UltraToggleEditorBase) this.chkExcInternational).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkExcInternational).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkExcInternational).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkExcInternational).Location = new Point(0, 45);
    this.chkExcInternational.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkExcInternational).Name = "chkExcInternational";
    ((Control) this.chkExcInternational).Size = new Size(85, 24);
    ((Control) this.chkExcInternational).TabIndex = 16 /*0x10*/;
    ((UltraToggleEditorBase) this.chkExcInternational).Text = "Exclude Int'l";
    ((UltraControlBase) this.chkExcInternational).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkExcInternational).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.chkExcInternational).Visible = false;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(676, 276);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 14;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
    ((Control) this.tabClientInfo).Location = new Point(-10000, -10000);
    ((Control) this.tabClientInfo).Name = "tabClientInfo";
    ((Control) this.tabClientInfo).Size = new Size(793, 328);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.chckPackageApplyOnce);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.chkMandatoryCharge);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.chkApplyToFlatCancellations);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.chkCountInternational);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.checkAppliesToAllStates);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.optionPremiumAmtAuto);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.chkApplyToChildLines);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.chkApplyPackagePolicy);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.UltraGroupBox1);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label21);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label20);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label19);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label18);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label17);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label16);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.numMaxStrat);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.numMinStrat);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.chkStateOfIssuanceOnly);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.chkAutoApply);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label4);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtPremiumLess);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtPremiumGreater);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabPageControl2).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(1002, 328);
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance18.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chckPackageApplyOnce).Appearance = (AppearanceBase) appearance18;
    ((UltraToggleEditorBase) this.chckPackageApplyOnce).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chckPackageApplyOnce).BackColorInternal = Color.Transparent;
    ((Control) this.chckPackageApplyOnce).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.ApplyOnce", true));
    ((UltraToggleEditorBase) this.chckPackageApplyOnce).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chckPackageApplyOnce).Location = new Point(17, 90);
    this.chckPackageApplyOnce.MGAStyle = MGAStyles.Blue;
    ((Control) this.chckPackageApplyOnce).Name = "chckPackageApplyOnce";
    ((Control) this.chckPackageApplyOnce).Size = new Size(123, 24);
    ((Control) this.chckPackageApplyOnce).TabIndex = 42;
    ((UltraToggleEditorBase) this.chckPackageApplyOnce).Text = "Apply Only Once";
    this.ToolTip1.SetToolTip((Control) this.chckPackageApplyOnce, "Applies to first option for a given transaction.");
    ((UltraControlBase) this.chckPackageApplyOnce).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chckPackageApplyOnce).UseOsThemes = (DefaultableBoolean) 2;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance19.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkMandatoryCharge).Appearance = (AppearanceBase) appearance19;
    ((UltraToggleEditorBase) this.chkMandatoryCharge).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkMandatoryCharge).BackColorInternal = Color.Transparent;
    ((Control) this.chkMandatoryCharge).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.MandatoryCharge", true));
    ((UltraToggleEditorBase) this.chkMandatoryCharge).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkMandatoryCharge).Location = new Point(508, 230);
    this.chkMandatoryCharge.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkMandatoryCharge).Name = "chkMandatoryCharge";
    ((Control) this.chkMandatoryCharge).Size = new Size(122, 24);
    ((Control) this.chkMandatoryCharge).TabIndex = 41;
    ((UltraToggleEditorBase) this.chkMandatoryCharge).Text = "Mandatory Charge";
    ((UltraControlBase) this.chkMandatoryCharge).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkMandatoryCharge).UseOsThemes = (DefaultableBoolean) 2;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance20.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkApplyToFlatCancellations).Appearance = (AppearanceBase) appearance20;
    ((UltraToggleEditorBase) this.chkApplyToFlatCancellations).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkApplyToFlatCancellations).BackColorInternal = Color.Transparent;
    ((Control) this.chkApplyToFlatCancellations).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.ApplytoFlatCanc", true));
    ((UltraToggleEditorBase) this.chkApplyToFlatCancellations).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkApplyToFlatCancellations).Location = new Point(215, 65);
    this.chkApplyToFlatCancellations.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkApplyToFlatCancellations).Name = "chkApplyToFlatCancellations";
    ((Control) this.chkApplyToFlatCancellations).Size = new Size(182, 24);
    ((Control) this.chkApplyToFlatCancellations).TabIndex = 24;
    ((UltraToggleEditorBase) this.chkApplyToFlatCancellations).Text = "Applies to Flat Cancellations";
    ((UltraControlBase) this.chkApplyToFlatCancellations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkApplyToFlatCancellations).UseOsThemes = (DefaultableBoolean) 2;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance21.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCountInternational).Appearance = (AppearanceBase) appearance21;
    ((UltraToggleEditorBase) this.chkCountInternational).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCountInternational).BackColorInternal = Color.Transparent;
    ((Control) this.chkCountInternational).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.InternationalStratification", true));
    ((UltraToggleEditorBase) this.chkCountInternational).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCountInternational).Location = new Point(222, 294);
    this.chkCountInternational.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCountInternational).Name = "chkCountInternational";
    ((Control) this.chkCountInternational).Size = new Size(182, 24);
    ((Control) this.chkCountInternational).TabIndex = 23;
    ((UltraToggleEditorBase) this.chkCountInternational).Text = "Count International States";
    ((UltraControlBase) this.chkCountInternational).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCountInternational).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.chkCountInternational).Visible = false;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance22.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkAppliesToAllStates).Appearance = (AppearanceBase) appearance22;
    ((UltraToggleEditorBase) this.checkAppliesToAllStates).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkAppliesToAllStates).BackColorInternal = Color.Transparent;
    ((Control) this.checkAppliesToAllStates).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.AppliesToAllStates", true));
    ((UltraToggleEditorBase) this.checkAppliesToAllStates).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkAppliesToAllStates).Location = new Point(215, 39);
    this.checkAppliesToAllStates.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkAppliesToAllStates).Name = "checkAppliesToAllStates";
    ((Control) this.checkAppliesToAllStates).Size = new Size(182, 24);
    ((Control) this.checkAppliesToAllStates).TabIndex = 23;
    ((UltraToggleEditorBase) this.checkAppliesToAllStates).Text = "Applies to all states";
    ((UltraControlBase) this.checkAppliesToAllStates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkAppliesToAllStates).UseOsThemes = (DefaultableBoolean) 2;
    this.optionPremiumAmtAuto.BackColor = Color.Transparent;
    this.optionPremiumAmtAuto.BackColorInternal = Color.Transparent;
    this.optionPremiumAmtAuto.BorderStyle = (UIElementBorderStyle) 1;
    this.optionPremiumAmtAuto.CheckedIndex = 0;
    ((Control) this.optionPremiumAmtAuto).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.PremiumAllocationType", true));
    this.optionPremiumAmtAuto.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem1.DataValue = (object) 'L';
    valueListItem1.DisplayText = "By Line";
    valueListItem2.DataValue = (object) 'P';
    valueListItem2.DisplayText = "By Policy";
    this.optionPremiumAmtAuto.Items.AddRange(new ValueListItem[2]
    {
      valueListItem1,
      valueListItem2
    });
    this.optionPremiumAmtAuto.ItemSpacingVertical = 5;
    ((Control) this.optionPremiumAmtAuto).Location = new Point(273, 197);
    ((Control) this.optionPremiumAmtAuto).Name = "optionPremiumAmtAuto";
    ((Control) this.optionPremiumAmtAuto).Size = new Size(122, 24);
    ((Control) this.optionPremiumAmtAuto).TabIndex = 6;
    this.optionPremiumAmtAuto.Text = "By Line";
    ((UltraControlBase) this.optionPremiumAmtAuto).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optionPremiumAmtAuto).UseOsThemes = (DefaultableBoolean) 2;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance23.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkApplyToChildLines).Appearance = (AppearanceBase) appearance23;
    ((UltraToggleEditorBase) this.chkApplyToChildLines).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkApplyToChildLines).BackColorInternal = Color.Transparent;
    ((Control) this.chkApplyToChildLines).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.ApplyToChildLines", true));
    ((UltraToggleEditorBase) this.chkApplyToChildLines).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkApplyToChildLines).Location = new Point(17, 65);
    this.chkApplyToChildLines.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkApplyToChildLines).Name = "chkApplyToChildLines";
    ((Control) this.chkApplyToChildLines).Size = new Size(182, 24);
    ((Control) this.chkApplyToChildLines).TabIndex = 2;
    ((UltraToggleEditorBase) this.chkApplyToChildLines).Text = "Apply to Child Lines";
    ((UltraControlBase) this.chkApplyToChildLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkApplyToChildLines).UseOsThemes = (DefaultableBoolean) 2;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance24.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkApplyPackagePolicy).Appearance = (AppearanceBase) appearance24;
    ((UltraToggleEditorBase) this.chkApplyPackagePolicy).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkApplyPackagePolicy).BackColorInternal = Color.Transparent;
    ((Control) this.chkApplyPackagePolicy).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.ApplyPackagePolicyOnly", true));
    ((UltraToggleEditorBase) this.chkApplyPackagePolicy).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkApplyPackagePolicy).Location = new Point(17, 39);
    this.chkApplyPackagePolicy.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkApplyPackagePolicy).Name = "chkApplyPackagePolicy";
    ((Control) this.chkApplyPackagePolicy).Size = new Size(182, 24);
    ((Control) this.chkApplyPackagePolicy).TabIndex = 2;
    ((UltraToggleEditorBase) this.chkApplyPackagePolicy).Text = "Apply when Package Policy Only";
    ((UltraControlBase) this.chkApplyPackagePolicy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkApplyPackagePolicy).UseOsThemes = (DefaultableBoolean) 2;
    appearance25.BackColor = Color.Transparent;
    this.UltraGroupBox1.Appearance = (AppearanceBase) appearance25;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.rbNoRounding);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.rbRoundToDollar);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.rbRoundUpToCent);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.rbRoundCent);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.rbRoundDown);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.rbRoundUp);
    ((Control) this.UltraGroupBox1).Location = new Point(508, 10);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(171, 211);
    ((Control) this.UltraGroupBox1).TabIndex = 9;
    this.UltraGroupBox1.Text = "Rounding";
    this.rbNoRounding.Location = new Point(6, 20);
    this.rbNoRounding.Name = "rbNoRounding";
    this.rbNoRounding.Size = new Size(128 /*0x80*/, 24);
    this.rbNoRounding.TabIndex = 0;
    this.rbNoRounding.Text = "No Rounding";
    this.rbRoundToDollar.Checked = true;
    this.rbRoundToDollar.Location = new Point(6, 50);
    this.rbRoundToDollar.Name = "rbRoundToDollar";
    this.rbRoundToDollar.Size = new Size(160 /*0xA0*/, 24);
    this.rbRoundToDollar.TabIndex = 1;
    this.rbRoundToDollar.TabStop = true;
    this.rbRoundToDollar.Text = "Round to the nearest dollar";
    this.rbRoundUpToCent.Location = new Point(6, 170);
    this.rbRoundUpToCent.Name = "rbRoundUpToCent";
    this.rbRoundUpToCent.Size = new Size(159, 24);
    this.rbRoundUpToCent.TabIndex = 3;
    this.rbRoundUpToCent.Text = "Round Up (cent)";
    this.rbRoundCent.Location = new Point(6, 140);
    this.rbRoundCent.Name = "rbRoundCent";
    this.rbRoundCent.Size = new Size(159, 24);
    this.rbRoundCent.TabIndex = 3;
    this.rbRoundCent.Text = "Round to nearest cent";
    this.rbRoundDown.Location = new Point(6, 110);
    this.rbRoundDown.Name = "rbRoundDown";
    this.rbRoundDown.Size = new Size(128 /*0x80*/, 24);
    this.rbRoundDown.TabIndex = 3;
    this.rbRoundDown.Text = "Round Down (dollar)";
    this.rbRoundUp.Location = new Point(6, 80 /*0x50*/);
    this.rbRoundUp.Name = "rbRoundUp";
    this.rbRoundUp.Size = new Size(128 /*0x80*/, 24);
    this.rbRoundUp.TabIndex = 2;
    this.rbRoundUp.Text = "Round Up (dollar)";
    this.Label21.AutoSize = true;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label21.Location = new Point(84, 230);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(205, 13);
    this.Label21.TabIndex = 7;
    this.Label21.Text = "Premium Stratification Automation";
    this.Label21.TextAlign = ContentAlignment.MiddleRight;
    this.Label20.AutoSize = true;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label20.Location = new Point(91, 125);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(176 /*0xB0*/, 13);
    this.Label20.TabIndex = 3;
    this.Label20.Text = "Premium Amount Automation";
    this.Label20.TextAlign = ContentAlignment.MiddleRight;
    this.Label19.AutoSize = true;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Location = new Point(360, 281);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(41, 13);
    this.Label19.TabIndex = 22;
    this.Label19.Text = "states.";
    this.Label19.TextAlign = ContentAlignment.MiddleRight;
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(187, 278);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(47, 13);
    this.Label18.TabIndex = 21;
    this.Label18.Text = "... up to";
    this.Label18.TextAlign = ContentAlignment.MiddleRight;
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(360, 257);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(128 /*0x80*/, 13);
    this.Label17.TabIndex = 10;
    this.Label17.Text = "states with on the policy,";
    this.Label17.TextAlign = ContentAlignment.MiddleRight;
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(84, 253);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(150, 13);
    this.Label16.TabIndex = 8;
    this.Label16.Text = "Apply when there are at least";
    this.Label16.TextAlign = ContentAlignment.MiddleRight;
    appearance26.BackColor = Color.White;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance26.ForeColor = Color.Black;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.numMaxStrat).Appearance = (AppearanceBase) appearance26;
    ((TextEditorControlBase) this.numMaxStrat).BackColor = Color.White;
    ((Control) this.numMaxStrat).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.MaxStrat", true));
    ((Control) this.numMaxStrat).Location = new Point(273, 278);
    ((TextEditorControlBase) this.numMaxStrat).MaxLength = 2;
    this.numMaxStrat.MGAStyle = MGAStyles.Blue;
    ((Control) this.numMaxStrat).Name = "numMaxStrat";
    ((Control) this.numMaxStrat).Size = new Size(63 /*0x3F*/, 20);
    ((Control) this.numMaxStrat).TabIndex = 8;
    ((UltraControlBase) this.numMaxStrat).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numMaxStrat).UseOsThemes = (DefaultableBoolean) 2;
    appearance27.BackColor = Color.White;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((AppearanceBase) appearance27).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.numMinStrat).Appearance = (AppearanceBase) appearance27;
    ((TextEditorControlBase) this.numMinStrat).BackColor = Color.White;
    ((Control) this.numMinStrat).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.MinStrat", true));
    ((Control) this.numMinStrat).Location = new Point(273, 250);
    ((TextEditorControlBase) this.numMinStrat).MaxLength = 2;
    this.numMinStrat.MGAStyle = MGAStyles.Blue;
    ((Control) this.numMinStrat).Name = "numMinStrat";
    ((Control) this.numMinStrat).Size = new Size(63 /*0x3F*/, 20);
    ((Control) this.numMinStrat).TabIndex = 7;
    ((UltraControlBase) this.numMinStrat).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numMinStrat).UseOsThemes = (DefaultableBoolean) 2;
    appearance28.BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkStateOfIssuanceOnly).Appearance = (AppearanceBase) appearance28;
    ((UltraToggleEditorBase) this.chkStateOfIssuanceOnly).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkStateOfIssuanceOnly).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkStateOfIssuanceOnly).Checked = true;
    ((UltraToggleEditorBase) this.chkStateOfIssuanceOnly).CheckState = CheckState.Checked;
    ((Control) this.chkStateOfIssuanceOnly).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.StateOfIssuanceOnly", true));
    ((UltraToggleEditorBase) this.chkStateOfIssuanceOnly).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkStateOfIssuanceOnly).Location = new Point(215, 13);
    ((Control) this.chkStateOfIssuanceOnly).Name = "chkStateOfIssuanceOnly";
    ((Control) this.chkStateOfIssuanceOnly).Size = new Size(212, 20);
    ((Control) this.chkStateOfIssuanceOnly).TabIndex = 1;
    ((UltraToggleEditorBase) this.chkStateOfIssuanceOnly).Text = "Only applies to the state of issuance";
    ((UltraControlBase) this.chkStateOfIssuanceOnly).UseOsThemes = (DefaultableBoolean) 2;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance29.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkAutoApply).Appearance = (AppearanceBase) appearance29;
    ((UltraToggleEditorBase) this.chkAutoApply).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkAutoApply).BackColorInternal = Color.Transparent;
    ((Control) this.chkAutoApply).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.AutoApply", true));
    ((UltraToggleEditorBase) this.chkAutoApply).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkAutoApply).Location = new Point(17, 13);
    this.chkAutoApply.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkAutoApply).Name = "chkAutoApply";
    ((Control) this.chkAutoApply).Size = new Size(182, 24);
    ((Control) this.chkAutoApply).TabIndex = 0;
    ((UltraToggleEditorBase) this.chkAutoApply).Text = "Apply Automatically on Binding";
    ((UltraControlBase) this.chkAutoApply).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkAutoApply).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(44, 175);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(221, 13);
    this.Label3.TabIndex = 5;
    this.Label3.Text = "Apply when premium is less than or equal to:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(27, 155);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(239, 13);
    this.Label4.TabIndex = 4;
    this.Label4.Text = "Apply when premium is greater than or equal to:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    appearance30.BackColor = Color.White;
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance30.ForeColor = Color.Black;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.txtPremiumLess).Appearance = (AppearanceBase) appearance30;
    ((TextEditorControlBase) this.txtPremiumLess).BackColor = Color.White;
    ((Control) this.txtPremiumLess).DataBindings.Add(new Binding("Text", (object) this.dsFees, "tblCompanyPolicyCharges.ApplyPremiumEqualOrLess", true));
    ((Control) this.txtPremiumLess).Location = new Point(273, 172);
    this.txtPremiumLess.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPremiumLess).Name = "txtPremiumLess";
    ((Control) this.txtPremiumLess).Size = new Size(63 /*0x3F*/, 20);
    ((Control) this.txtPremiumLess).TabIndex = 5;
    ((UltraControlBase) this.txtPremiumLess).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPremiumLess).UseOsThemes = (DefaultableBoolean) 2;
    appearance31.BackColor = Color.White;
    appearance31.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance31.ForeColor = Color.Black;
    ((AppearanceBase) appearance31).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.txtPremiumGreater).Appearance = (AppearanceBase) appearance31;
    ((TextEditorControlBase) this.txtPremiumGreater).BackColor = Color.White;
    ((Control) this.txtPremiumGreater).DataBindings.Add(new Binding("Text", (object) this.dsFees, "tblCompanyPolicyCharges.ApplyPremiumEqualOrOver", true));
    ((Control) this.txtPremiumGreater).Location = new Point(273, 147);
    this.txtPremiumGreater.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPremiumGreater).Name = "txtPremiumGreater";
    ((Control) this.txtPremiumGreater).Size = new Size(63 /*0x3F*/, 20);
    ((Control) this.txtPremiumGreater).TabIndex = 4;
    ((UltraControlBase) this.txtPremiumGreater).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPremiumGreater).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.checkMasterPayee);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lnkSelectPayableEntity);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.rbNotPayable);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.rbPayableTo);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.rbPayable);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblPayableTo);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(793, 328);
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance32.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkMasterPayee).Appearance = (AppearanceBase) appearance32;
    ((UltraToggleEditorBase) this.checkMasterPayee).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkMasterPayee).BackColorInternal = Color.Transparent;
    ((Control) this.checkMasterPayee).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.MasterPayee", true));
    ((UltraToggleEditorBase) this.checkMasterPayee).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.checkMasterPayee).Location = new Point(373, 68);
    this.checkMasterPayee.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkMasterPayee).Name = "checkMasterPayee";
    ((Control) this.checkMasterPayee).Size = new Size(207, 24);
    ((Control) this.checkMasterPayee).TabIndex = 18;
    ((UltraToggleEditorBase) this.checkMasterPayee).Text = "Master payee when home state";
    ((UltraControlBase) this.checkMasterPayee).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkMasterPayee).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkSelectPayableEntity.AutoSize = true;
    this.lnkSelectPayableEntity.BackColor = Color.Transparent;
    this.lnkSelectPayableEntity.Location = new Point(259, 74);
    this.lnkSelectPayableEntity.Name = "lnkSelectPayableEntity";
    this.lnkSelectPayableEntity.Size = new Size(108, 13);
    this.lnkSelectPayableEntity.TabIndex = 4;
    this.lnkSelectPayableEntity.TabStop = true;
    this.lnkSelectPayableEntity.Text = "Select Payable Entity";
    this.lnkSelectPayableEntity.TextAlign = ContentAlignment.MiddleLeft;
    this.rbNotPayable.BackColor = Color.Transparent;
    this.rbNotPayable.Location = new Point(14, 14);
    this.rbNotPayable.Name = "rbNotPayable";
    this.rbNotPayable.Size = new Size(84, 24);
    this.rbNotPayable.TabIndex = 0;
    this.rbNotPayable.Text = "Not Payable";
    this.rbNotPayable.UseVisualStyleBackColor = false;
    this.rbPayableTo.BackColor = Color.Transparent;
    this.rbPayableTo.Location = new Point(14, 70);
    this.rbPayableTo.Name = "rbPayableTo";
    this.rbPayableTo.Size = new Size(84, 24);
    this.rbPayableTo.TabIndex = 2;
    this.rbPayableTo.Text = "Payable To";
    this.rbPayableTo.UseVisualStyleBackColor = false;
    this.rbPayable.BackColor = Color.Transparent;
    this.rbPayable.Location = new Point(14, 42);
    this.rbPayable.Name = "rbPayable";
    this.rbPayable.Size = new Size(133, 24);
    this.rbPayable.TabIndex = 1;
    this.rbPayable.Text = "Payable To Company";
    this.rbPayable.UseVisualStyleBackColor = false;
    appearance33.BackColor = Color.White;
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance33.ForeColor = Color.Black;
    ((TextEditorControlBase) this.lblPayableTo).Appearance = (AppearanceBase) appearance33;
    ((TextEditorControlBase) this.lblPayableTo).BackColor = Color.White;
    ((Control) this.lblPayableTo).DataBindings.Add(new Binding("Text", (object) this.dsFees, "tblCompanyPolicyCharges.PayableEntity", true));
    ((Control) this.lblPayableTo).Location = new Point(105, 72);
    this.lblPayableTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.lblPayableTo).Name = "lblPayableTo";
    ((EditorButtonControlBase) this.lblPayableTo).ReadOnly = true;
    ((Control) this.lblPayableTo).Size = new Size(147, 20);
    ((Control) this.lblPayableTo).TabIndex = 3;
    ((UltraControlBase) this.lblPayableTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.lblPayableTo).UseOsThemes = (DefaultableBoolean) 2;
    this.lblPayableTo.WordWrap = false;
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.lstPolicyTypeExcl);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.label31);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.chkExcludeOriginalBinder);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.checkPayHomeState);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.MgaCheckBox5);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.chkExcludeMultiCarrier);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.MgaCheckBox2);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.chkExcludeEndorsements);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.chkExcludeFiling);
    ((Control) this.UltraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(793, 328);
    this.lstPolicyTypeExcl.CheckOnClick = true;
    this.lstPolicyTypeExcl.Location = new Point(403, 14);
    this.lstPolicyTypeExcl.Name = "lstPolicyTypeExcl";
    this.lstPolicyTypeExcl.Size = new Size(195, 196);
    this.lstPolicyTypeExcl.TabIndex = 398;
    this.label31.AutoSize = true;
    this.label31.BackColor = Color.Transparent;
    this.label31.Location = new Point(272, 14);
    this.label31.Name = "label31";
    this.label31.Size = new Size(125, 13);
    this.label31.TabIndex = 397;
    this.label31.Text = "Exclude on Policy Types:";
    this.label31.TextAlign = ContentAlignment.MiddleRight;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance34.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkExcludeOriginalBinder).Appearance = (AppearanceBase) appearance34;
    ((UltraToggleEditorBase) this.chkExcludeOriginalBinder).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkExcludeOriginalBinder).BackColorInternal = Color.Transparent;
    ((Control) this.chkExcludeOriginalBinder).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.ExcludeOriginalBinder", true));
    ((UltraToggleEditorBase) this.chkExcludeOriginalBinder).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.chkExcludeOriginalBinder).Location = new Point(14, 190);
    this.chkExcludeOriginalBinder.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkExcludeOriginalBinder).Name = "chkExcludeOriginalBinder";
    ((Control) this.chkExcludeOriginalBinder).Size = new Size(216, 24);
    ((Control) this.chkExcludeOriginalBinder).TabIndex = 18;
    ((UltraToggleEditorBase) this.chkExcludeOriginalBinder).Text = "Exclude on original binder";
    ((UltraControlBase) this.chkExcludeOriginalBinder).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkExcludeOriginalBinder).UseOsThemes = (DefaultableBoolean) 2;
    appearance35.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance35.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkPayHomeState).Appearance = (AppearanceBase) appearance35;
    ((UltraToggleEditorBase) this.checkPayHomeState).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkPayHomeState).BackColorInternal = Color.Transparent;
    ((Control) this.checkPayHomeState).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.PayHomeState", true));
    ((UltraToggleEditorBase) this.checkPayHomeState).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.checkPayHomeState).Location = new Point(14, 130);
    this.checkPayHomeState.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkPayHomeState).Name = "checkPayHomeState";
    ((Control) this.checkPayHomeState).Size = new Size(140, 24);
    ((Control) this.checkPayHomeState).TabIndex = 17;
    ((UltraToggleEditorBase) this.checkPayHomeState).Text = "Pay home state";
    ((UltraControlBase) this.checkPayHomeState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkPayHomeState).UseOsThemes = (DefaultableBoolean) 2;
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance36.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox5).Appearance = (AppearanceBase) appearance36;
    ((UltraToggleEditorBase) this.MgaCheckBox5).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox5).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox5).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.DoNotApplyPackagePolicyOnly", true));
    ((UltraToggleEditorBase) this.MgaCheckBox5).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox5).Location = new Point(14, 100);
    this.MgaCheckBox5.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaCheckBox5).Name = "MgaCheckBox5";
    ((Control) this.MgaCheckBox5).Size = new Size(227, 24);
    ((Control) this.MgaCheckBox5).TabIndex = 16 /*0x10*/;
    ((UltraToggleEditorBase) this.MgaCheckBox5).Text = "Do not apply when package policy only";
    ((UltraControlBase) this.MgaCheckBox5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox5).UseOsThemes = (DefaultableBoolean) 2;
    appearance37.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance37.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkExcludeMultiCarrier).Appearance = (AppearanceBase) appearance37;
    ((UltraToggleEditorBase) this.chkExcludeMultiCarrier).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkExcludeMultiCarrier).BackColorInternal = Color.Transparent;
    ((Control) this.chkExcludeMultiCarrier).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.ExcludeMultiCarrier", true));
    ((UltraToggleEditorBase) this.chkExcludeMultiCarrier).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.chkExcludeMultiCarrier).Location = new Point(14, 160 /*0xA0*/);
    this.chkExcludeMultiCarrier.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkExcludeMultiCarrier).Name = "chkExcludeMultiCarrier";
    ((Control) this.chkExcludeMultiCarrier).Size = new Size(216, 24);
    ((Control) this.chkExcludeMultiCarrier).TabIndex = 15;
    ((UltraToggleEditorBase) this.chkExcludeMultiCarrier).Text = "Exclude on multi-carrier policy";
    ((UltraControlBase) this.chkExcludeMultiCarrier).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkExcludeMultiCarrier).UseOsThemes = (DefaultableBoolean) 2;
    appearance38.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance38.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox2).Appearance = (AppearanceBase) appearance38;
    ((UltraToggleEditorBase) this.MgaCheckBox2).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox2).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox2).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.ExcludeOnRenewal", true));
    ((UltraToggleEditorBase) this.MgaCheckBox2).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox2).Location = new Point(14, 70);
    this.MgaCheckBox2.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaCheckBox2).Name = "MgaCheckBox2";
    ((Control) this.MgaCheckBox2).Size = new Size(154, 24);
    ((Control) this.MgaCheckBox2).TabIndex = 15;
    ((UltraToggleEditorBase) this.MgaCheckBox2).Text = "Exclude on renewal";
    ((UltraControlBase) this.MgaCheckBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox2).UseOsThemes = (DefaultableBoolean) 2;
    appearance39.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance39.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkExcludeEndorsements).Appearance = (AppearanceBase) appearance39;
    ((UltraToggleEditorBase) this.chkExcludeEndorsements).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkExcludeEndorsements).BackColorInternal = Color.Transparent;
    ((Control) this.chkExcludeEndorsements).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.ExcludeOnEndorsements", true));
    ((UltraToggleEditorBase) this.chkExcludeEndorsements).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.chkExcludeEndorsements).Location = new Point(14, 42);
    this.chkExcludeEndorsements.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkExcludeEndorsements).Name = "chkExcludeEndorsements";
    ((Control) this.chkExcludeEndorsements).Size = new Size(154, 24);
    ((Control) this.chkExcludeEndorsements).TabIndex = 1;
    ((UltraToggleEditorBase) this.chkExcludeEndorsements).Text = "Exclude on endorsements";
    ((UltraControlBase) this.chkExcludeEndorsements).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkExcludeEndorsements).UseOsThemes = (DefaultableBoolean) 2;
    appearance40.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance40.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkExcludeFiling).Appearance = (AppearanceBase) appearance40;
    ((UltraToggleEditorBase) this.chkExcludeFiling).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkExcludeFiling).BackColorInternal = Color.Transparent;
    ((Control) this.chkExcludeFiling).DataBindings.Add(new Binding("Checked", (object) this.dsFees, "tblCompanyPolicyCharges.ExcludeWhenNotFiling", true));
    ((UltraToggleEditorBase) this.chkExcludeFiling).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.chkExcludeFiling).Location = new Point(14, 14);
    this.chkExcludeFiling.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkExcludeFiling).Name = "chkExcludeFiling";
    ((Control) this.chkExcludeFiling).Size = new Size(140, 24);
    ((Control) this.chkExcludeFiling).TabIndex = 0;
    ((UltraToggleEditorBase) this.chkExcludeFiling).Text = "Exclude when not filing";
    ((UltraControlBase) this.chkExcludeFiling).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkExcludeFiling).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtMaxDollars);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtMaxPercentage);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label10);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label9);
    ((Control) this.UltraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(793, 328);
    appearance41.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtMaxDollars).Appearance = (AppearanceBase) appearance41;
    ((Control) this.txtMaxDollars).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.MaxDollars", true));
    ((Control) this.txtMaxDollars).Location = new Point(98, 49);
    this.txtMaxDollars.MGAStyle = MGAStyles.Blue;
    this.txtMaxDollars.MinValue = (object) 0;
    ((Control) this.txtMaxDollars).Name = "txtMaxDollars";
    this.txtMaxDollars.Nullable = true;
    ((Control) this.txtMaxDollars).Size = new Size(77, 20);
    ((Control) this.txtMaxDollars).TabIndex = 19;
    ((UltraControlBase) this.txtMaxDollars).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtMaxDollars).UseOsThemes = (DefaultableBoolean) 2;
    appearance42.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtMaxPercentage).Appearance = (AppearanceBase) appearance42;
    ((Control) this.txtMaxPercentage).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.MaxPercentage", true));
    ((Control) this.txtMaxPercentage).Location = new Point(98, 21);
    this.txtMaxPercentage.MaskInput = "{LOC}nnn.nnnn";
    this.txtMaxPercentage.MaxValue = (object) 1;
    this.txtMaxPercentage.MGAStyle = MGAStyles.Blue;
    this.txtMaxPercentage.MinValue = (object) 0;
    ((Control) this.txtMaxPercentage).Name = "txtMaxPercentage";
    this.txtMaxPercentage.Nullable = true;
    this.txtMaxPercentage.NumericType = (NumericType) 1;
    ((Control) this.txtMaxPercentage).Size = new Size(77, 20);
    ((Control) this.txtMaxPercentage).TabIndex = 18;
    ((UltraControlBase) this.txtMaxPercentage).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtMaxPercentage).UseOsThemes = (DefaultableBoolean) 2;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(14, 52);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(64 /*0x40*/, 13);
    this.Label10.TabIndex = 17;
    this.Label10.Text = "Maximum $:";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(14, 24);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(69, 13);
    this.Label9.TabIndex = 15;
    this.Label9.Text = "Maximum %:";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.tabHistory).Controls.Add((Control) this.lblNotes);
    ((Control) this.tabHistory).Controls.Add((Control) this.txtNotes);
    ((Control) this.tabHistory).Controls.Add((Control) this.dtpEdited);
    ((Control) this.tabHistory).Controls.Add((Control) this.lblLastEditedDate);
    ((Control) this.tabHistory).Controls.Add((Control) this.lblEditedBy);
    ((Control) this.tabHistory).Controls.Add((Control) this.cboEditedBy);
    ((Control) this.tabHistory).Controls.Add((Control) this.lblAddedBy);
    ((Control) this.tabHistory).Controls.Add((Control) this.cboAddedBy);
    ((Control) this.tabHistory).Controls.Add((Control) this.dtpAddedDate);
    ((Control) this.tabHistory).Controls.Add((Control) this.lblAddedDate);
    ((Control) this.tabHistory).Location = new Point(-10000, -10000);
    ((Control) this.tabHistory).Name = "tabHistory";
    ((Control) this.tabHistory).Size = new Size(793, 328);
    this.lblNotes.AutoSize = true;
    this.lblNotes.BackColor = Color.Transparent;
    this.lblNotes.Location = new Point(21, 116);
    this.lblNotes.Name = "lblNotes";
    this.lblNotes.Size = new Size(39, 13);
    this.lblNotes.TabIndex = 27;
    this.lblNotes.Text = "Notes:";
    this.lblNotes.TextAlign = ContentAlignment.MiddleRight;
    appearance43.BackColor = Color.White;
    appearance43.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance43.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNotes).Appearance = (AppearanceBase) appearance43;
    ((TextEditorControlBase) this.txtNotes).BackColor = Color.White;
    ((Control) this.txtNotes).DataBindings.Add(new Binding("Text", (object) this.dsFees, "tblCompanyPolicyCharges.Notes", true));
    ((Control) this.txtNotes).Location = new Point(109, 116);
    ((TextEditorControlBase) this.txtNotes).MaxLength = 2000;
    this.txtNotes.MGAStyle = MGAStyles.Blue;
    this.txtNotes.Multiline = true;
    ((Control) this.txtNotes).Name = "txtNotes";
    ((Control) this.txtNotes).Size = new Size(210, 207);
    ((Control) this.txtNotes).TabIndex = 4;
    ((UltraControlBase) this.txtNotes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNotes).UseOsThemes = (DefaultableBoolean) 2;
    appearance44.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpEdited.Appearance = (AppearanceBase) appearance44;
    appearance45.AlphaLevel = (short) 14;
    appearance45.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance45.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance45.BackColorAlpha = (Alpha) 2;
    appearance45.BackGradientAlignment = (GradientAlignment) 4;
    appearance45.BackGradientStyle = (GradientStyle) 5;
    appearance45.BorderAlpha = (Alpha) 1;
    appearance45.BorderColor = Color.FromArgb(78, 122, 171);
    appearance45.ForeColor = Color.FromArgb(49, 85, 153);
    appearance45.ForegroundAlpha = (Alpha) 2;
    this.dtpEdited.ButtonAppearance = (AppearanceBase) appearance45;
    ((Control) this.dtpEdited).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.EditedDate", true));
    this.dtpEdited.DateTime = new DateTime(2004, 2, 3, 14, 54, 42, 449);
    ((Control) this.dtpEdited).Location = new Point(109, 89);
    this.dtpEdited.MaskInput = "{LOC}mm/dd/yyyy hh:mm:ss tt";
    this.dtpEdited.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpEdited).Name = "dtpEdited";
    ((EditorButtonControlBase) this.dtpEdited).ReadOnly = true;
    ((Control) this.dtpEdited).Size = new Size(153, 20);
    ((Control) this.dtpEdited).TabIndex = 3;
    ((UltraControlBase) this.dtpEdited).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpEdited).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpEdited.Value = (object) new DateTime(2004, 2, 3, 14, 54, 42, 449);
    this.lblLastEditedDate.AutoSize = true;
    this.lblLastEditedDate.BackColor = Color.Transparent;
    this.lblLastEditedDate.Location = new Point(21, 93);
    this.lblLastEditedDate.Name = "lblLastEditedDate";
    this.lblLastEditedDate.Size = new Size(34, 13);
    this.lblLastEditedDate.TabIndex = 25;
    this.lblLastEditedDate.Text = "Date:";
    this.lblLastEditedDate.TextAlign = ContentAlignment.MiddleRight;
    this.lblEditedBy.AutoSize = true;
    this.lblEditedBy.BackColor = Color.Transparent;
    this.lblEditedBy.Location = new Point(21, 64 /*0x40*/);
    this.lblEditedBy.Name = "lblEditedBy";
    this.lblEditedBy.Size = new Size(79, 13);
    this.lblEditedBy.TabIndex = 23;
    this.lblEditedBy.Text = "Last Edited By:";
    this.lblEditedBy.TextAlign = ContentAlignment.MiddleRight;
    this.cboEditedBy.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboEditedBy).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.EditedBy", true));
    ((UltraGridBase) this.cboEditedBy).DataMember = "tblUsers";
    ((UltraGridBase) this.cboEditedBy).DataSource = (object) this.dsFees;
    ((UltraDropDownBase) this.cboEditedBy).DisplayMember = "Name_LastFirst";
    this.cboEditedBy.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboEditedBy).DropDownWidth = 350;
    ((Control) this.cboEditedBy).Location = new Point(109, 60);
    this.cboEditedBy.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboEditedBy).Name = "cboEditedBy";
    this.cboEditedBy.ReadOnly = true;
    ((Control) this.cboEditedBy).Size = new Size(210, 21);
    ((Control) this.cboEditedBy).TabIndex = 1;
    ((UltraControlBase) this.cboEditedBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboEditedBy).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboEditedBy).ValueMember = "UserGUID";
    this.lblAddedBy.AutoSize = true;
    this.lblAddedBy.BackColor = Color.Transparent;
    this.lblAddedBy.Location = new Point(21, 7);
    this.lblAddedBy.Name = "lblAddedBy";
    this.lblAddedBy.Size = new Size(57, 13);
    this.lblAddedBy.TabIndex = 21;
    this.lblAddedBy.Text = "Added By:";
    this.lblAddedBy.TextAlign = ContentAlignment.MiddleRight;
    this.cboAddedBy.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboAddedBy).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.AddedBy", true));
    ((UltraGridBase) this.cboAddedBy).DataMember = "tblUsers";
    ((UltraGridBase) this.cboAddedBy).DataSource = (object) this.dsFees;
    ((UltraDropDownBase) this.cboAddedBy).DisplayMember = "Name_LastFirst";
    this.cboAddedBy.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboAddedBy).DropDownWidth = 350;
    ((Control) this.cboAddedBy).Location = new Point(109, 3);
    this.cboAddedBy.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboAddedBy).Name = "cboAddedBy";
    this.cboAddedBy.ReadOnly = true;
    ((Control) this.cboAddedBy).Size = new Size(210, 21);
    ((Control) this.cboAddedBy).TabIndex = 0;
    ((UltraControlBase) this.cboAddedBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboAddedBy).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboAddedBy).ValueMember = "UserGUID";
    appearance46.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpAddedDate.Appearance = (AppearanceBase) appearance46;
    appearance47.AlphaLevel = (short) 14;
    appearance47.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance47.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance47.BackColorAlpha = (Alpha) 2;
    appearance47.BackGradientAlignment = (GradientAlignment) 4;
    appearance47.BackGradientStyle = (GradientStyle) 5;
    appearance47.BorderAlpha = (Alpha) 1;
    appearance47.BorderColor = Color.FromArgb(78, 122, 171);
    appearance47.ForeColor = Color.FromArgb(49, 85, 153);
    appearance47.ForegroundAlpha = (Alpha) 2;
    this.dtpAddedDate.ButtonAppearance = (AppearanceBase) appearance47;
    ((Control) this.dtpAddedDate).DataBindings.Add(new Binding("Value", (object) this.dsFees, "tblCompanyPolicyCharges.AddedDate", true));
    this.dtpAddedDate.DateTime = new DateTime(2004, 2, 3, 14, 54, 42, 449);
    ((Control) this.dtpAddedDate).Location = new Point(109, 32 /*0x20*/);
    this.dtpAddedDate.MaskInput = "{LOC}mm/dd/yyyy hh:mm:ss tt";
    this.dtpAddedDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpAddedDate).Name = "dtpAddedDate";
    ((EditorButtonControlBase) this.dtpAddedDate).ReadOnly = true;
    ((Control) this.dtpAddedDate).Size = new Size(153, 20);
    ((Control) this.dtpAddedDate).TabIndex = 2;
    ((UltraControlBase) this.dtpAddedDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpAddedDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpAddedDate.Value = (object) new DateTime(2004, 2, 3, 14, 54, 42, 449);
    this.lblAddedDate.AutoSize = true;
    this.lblAddedDate.BackColor = Color.Transparent;
    this.lblAddedDate.Location = new Point(21, 36);
    this.lblAddedDate.Name = "lblAddedDate";
    this.lblAddedDate.Size = new Size(34, 13);
    this.lblAddedDate.TabIndex = 19;
    this.lblAddedDate.Text = "Date:";
    this.lblAddedDate.TextAlign = ContentAlignment.MiddleRight;
    this.err.ContainerControl = (ContainerControl) this;
    this.daCompanyPolicyCharges.AcceptChangesDuringUpdate = false;
    this.daCompanyPolicyCharges.DeleteCommand = this.SqlDeleteCommand1;
    this.daCompanyPolicyCharges.InsertCommand = this.SqlInsertCommand1;
    this.daCompanyPolicyCharges.SelectCommand = this.SqlCommand1;
    this.daCompanyPolicyCharges.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyPolicyCharges", new DataColumnMapping[50]
      {
        new DataColumnMapping("ChargeCode", "ChargeCode"),
        new DataColumnMapping("FeeTypeID", "FeeTypeID"),
        new DataColumnMapping("Payable", "Payable"),
        new DataColumnMapping("FlatRate", "FlatRate"),
        new DataColumnMapping("PercentageRate", "PercentageRate"),
        new DataColumnMapping("ApplyPremiumEqualOrLess", "ApplyPremiumEqualOrLess"),
        new DataColumnMapping("ApplyPremiumEqualOrOver", "ApplyPremiumEqualOrOver"),
        new DataColumnMapping("AutoApply", "AutoApply"),
        new DataColumnMapping("Effective", "Effective"),
        new DataColumnMapping("Splittable", "Splittable"),
        new DataColumnMapping("OfficeID", "OfficeID"),
        new DataColumnMapping("PayableEntityType", "PayableEntityType"),
        new DataColumnMapping("PayableEntityGuid", "PayableEntityGuid"),
        new DataColumnMapping("Minimum", "Minimum"),
        new DataColumnMapping("ExcludeWhenNotFiling", "ExcludeWhenNotFiling"),
        new DataColumnMapping("ExcludeOnEndorsements", "ExcludeOnEndorsements"),
        new DataColumnMapping("AppliesToPaymentID", "AppliesToPaymentID"),
        new DataColumnMapping("FullyEarned", "FullyEarned"),
        new DataColumnMapping("RoundToDollar", "RoundToDollar"),
        new DataColumnMapping("MaxPercentage", "MaxPercentage"),
        new DataColumnMapping("MaxDollars", "MaxDollars"),
        new DataColumnMapping("Disabled", "Disabled"),
        new DataColumnMapping("ExcludeOnRenewal", "ExcludeOnRenewal"),
        new DataColumnMapping("PercentageNet", "PercentageNet"),
        new DataColumnMapping("CompanyLocationGuid", "CompanyLocationGuid"),
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("CompanyLicenceTypeID", "CompanyLicenceTypeID"),
        new DataColumnMapping("TerrorismExcluded", "TerrorismExcluded"),
        new DataColumnMapping("FeeBasedOnNumberOfLocations", "FeeBasedOnNumberOfLocations"),
        new DataColumnMapping("StateOfIssuanceOnly", "StateOfIssuanceOnly"),
        new DataColumnMapping("MinStrat", "MinStrat"),
        new DataColumnMapping("MaxStrat", "MaxStrat"),
        new DataColumnMapping("KentuckyCityID", "KentuckyCityID"),
        new DataColumnMapping("ApplyPackagePolicyOnly", "ApplyPackagePolicyOnly"),
        new DataColumnMapping("DoNotApplyPackagePolicyOnly", "DoNotApplyPackagePolicyOnly"),
        new DataColumnMapping("PremiumAllocationType", "PremiumAllocationType"),
        new DataColumnMapping("SendToAccounting", "SendToAccounting"),
        new DataColumnMapping("FeeBasedOnNumberOfVehicles", "FeeBasedOnNumberOfVehicles"),
        new DataColumnMapping("CompanyFeeID", "CompanyFeeID"),
        new DataColumnMapping("AppliesToAllStates", "AppliesToAllStates"),
        new DataColumnMapping("MasterPayee", "MasterPayee"),
        new DataColumnMapping("PayHomeState", "PayHomeState"),
        new DataColumnMapping("InternationalStratification", "InternationalStratification"),
        new DataColumnMapping("ExcludeInternationalPremiums", "ExcludeInternationalPremiums"),
        new DataColumnMapping("ApplyToChildLines", "ApplyToChildLines"),
        new DataColumnMapping("ExcludeMultiCarrier", "ExcludeMultiCarrier"),
        new DataColumnMapping("RoundToCent", "RoundToCent"),
        new DataColumnMapping("RoundUpToCent", "RoundUpToCent"),
        new DataColumnMapping("ApplyOnce", "ApplyOnce")
      })
    });
    this.daCompanyPolicyCharges.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [tblCompanyPolicyCharges] WHERE (([CompanyFeeID] = @Original_CompanyFeeID))";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_CompanyFeeID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyFeeID", DataRowVersion.Original, (object) null)
    });
    this.cnSQL.ConnectionString = "Data Source=mgasystems2012.ny.mgasystems.com;Initial Catalog=IMS;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[62]
    {
      new SqlParameter("@ChargeCode", SqlDbType.Int, 4, "ChargeCode"),
      new SqlParameter("@FeeTypeID", SqlDbType.TinyInt, 1, "FeeTypeID"),
      new SqlParameter("@Payable", SqlDbType.Bit, 1, "Payable"),
      new SqlParameter("@FlatRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 7, (byte) 2, "FlatRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@PercentageRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 7, (byte) 6, "PercentageRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@ApplyPremiumEqualOrLess", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 11, (byte) 2, "ApplyPremiumEqualOrLess", DataRowVersion.Current, (object) null),
      new SqlParameter("@ApplyPremiumEqualOrOver", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 11, (byte) 2, "ApplyPremiumEqualOrOver", DataRowVersion.Current, (object) null),
      new SqlParameter("@AutoApply", SqlDbType.Bit, 1, "AutoApply"),
      new SqlParameter("@Effective", SqlDbType.DateTime, 8, "Effective"),
      new SqlParameter("@Splittable", SqlDbType.Bit, 1, "Splittable"),
      new SqlParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      new SqlParameter("@PayableEntityType", SqlDbType.Char, 1, "PayableEntityType"),
      new SqlParameter("@PayableEntityGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "PayableEntityGuid"),
      new SqlParameter("@Minimum", SqlDbType.Int, 4, "Minimum"),
      new SqlParameter("@ExcludeWhenNotFiling", SqlDbType.Bit, 1, "ExcludeWhenNotFiling"),
      new SqlParameter("@ExcludeOnEndorsements", SqlDbType.Bit, 1, "ExcludeOnEndorsements"),
      new SqlParameter("@AppliesToPaymentID", SqlDbType.Char, 1, "AppliesToPaymentID"),
      new SqlParameter("@FullyEarned", SqlDbType.Bit, 1, "FullyEarned"),
      new SqlParameter("@RoundToDollar", SqlDbType.Bit, 1, "RoundToDollar"),
      new SqlParameter("@MaxPercentage", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 7, (byte) 6, "MaxPercentage", DataRowVersion.Current, (object) null),
      new SqlParameter("@MaxDollars", SqlDbType.Int, 4, "MaxDollars"),
      new SqlParameter("@Disabled", SqlDbType.DateTime, 8, "Disabled"),
      new SqlParameter("@ExcludeOnRenewal", SqlDbType.Bit, 1, "ExcludeOnRenewal"),
      new SqlParameter("@PercentageNet", SqlDbType.Bit, 1, "PercentageNet"),
      new SqlParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGuid"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGuid"),
      new SqlParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      new SqlParameter("@CompanyLicenceTypeID", SqlDbType.TinyInt, 1, "CompanyLicenceTypeID"),
      new SqlParameter("@TerrorismExcluded", SqlDbType.Bit, 1, "TerrorismExcluded"),
      new SqlParameter("@FeeBasedOnNumberOfLocations", SqlDbType.Bit, 1, "FeeBasedOnNumberOfLocations"),
      new SqlParameter("@StateOfIssuanceOnly", SqlDbType.Bit, 1, "StateOfIssuanceOnly"),
      new SqlParameter("@MinStrat", SqlDbType.TinyInt, 1, "MinStrat"),
      new SqlParameter("@MaxStrat", SqlDbType.TinyInt, 1, "MaxStrat"),
      new SqlParameter("@KentuckyCityID", SqlDbType.Int, 4, "KentuckyCityID"),
      new SqlParameter("@ApplyPackagePolicyOnly", SqlDbType.Bit, 1, "ApplyPackagePolicyOnly"),
      new SqlParameter("@DoNotApplyPackagePolicyOnly", SqlDbType.Bit, 1, "DoNotApplyPackagePolicyOnly"),
      new SqlParameter("@PremiumAllocationType", SqlDbType.Char, 1, "PremiumAllocationType"),
      new SqlParameter("@SendToAccounting", SqlDbType.Bit, 1, "SendToAccounting"),
      new SqlParameter("@FeeBasedOnNumberOfVehicles", SqlDbType.Bit, 1, "FeeBasedOnNumberOfVehicles"),
      new SqlParameter("@AppliesToAllStates", SqlDbType.Bit, 1, "AppliesToAllStates"),
      new SqlParameter("@MasterPayee", SqlDbType.Bit, 1, "MasterPayee"),
      new SqlParameter("@PayHomeState", SqlDbType.Bit, 1, "PayHomeState"),
      new SqlParameter("@RoundDown", SqlDbType.Bit, 1, "RoundDown"),
      new SqlParameter("@RoundUp", SqlDbType.Bit, 1, "RoundUp"),
      new SqlParameter("@NoRounding", SqlDbType.Bit, 1, "NoRounding"),
      new SqlParameter("@InternationalStratification", SqlDbType.Bit, 1, "InternationalStratification"),
      new SqlParameter("@ExcludeInternationalPremiums", SqlDbType.Bit, 1, "ExcludeInternationalPremiums"),
      new SqlParameter("@ApplyToChildLines", SqlDbType.Bit, 1, "ApplyToChildLines"),
      new SqlParameter("@RoundToCent", SqlDbType.Bit, 1, "RoundToCent"),
      new SqlParameter("@RoundUpToCent", SqlDbType.Bit, 1, "RoundUpToCent"),
      new SqlParameter("@ExcludeMultiCarrier", SqlDbType.Bit, 1, "ExcludeMultiCarrier"),
      new SqlParameter("@ApplytoFlatCanc", SqlDbType.Bit, 1, "ApplytoFlatCanc"),
      new SqlParameter("@ExcludeOriginalBinder", SqlDbType.Bit, 1, "ExcludeOriginalBinder"),
      new SqlParameter("@AddedBy", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "AddedBy"),
      new SqlParameter("@EditedBy", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "EditedBy"),
      new SqlParameter("@AddedDate", SqlDbType.DateTime, 8, "AddedDate"),
      new SqlParameter("@EditedDate", SqlDbType.DateTime, 8, "EditedDate"),
      new SqlParameter("@Notes", SqlDbType.VarChar, 2000, "Notes"),
      new SqlParameter("@CountyTaxIncludedInRate", SqlDbType.Bit, 1, "CountyTaxIncludedInRate"),
      new SqlParameter("@MandatoryCharge", SqlDbType.Bit, 1, "MandatoryCharge"),
      new SqlParameter("@FullyEarnedNumDays", SqlDbType.SmallInt, 2, "FullyEarnedNumDays"),
      new SqlParameter("@ApplyOnce", SqlDbType.Bit, 1, "ApplyOnce")
    });
    this.SqlCommand1.CommandText = "[spCompanyFeesFormData_ExistingFees]";
    this.SqlCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlCommand1.Connection = this.cnSQL;
    this.SqlCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@companyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      new SqlParameter("@showOnlyGenericFees", SqlDbType.Bit, 1),
      new SqlParameter("@showAll", SqlDbType.Bit, 1)
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[64 /*0x40*/]
    {
      new SqlParameter("@ChargeCode", SqlDbType.Int, 4, "ChargeCode"),
      new SqlParameter("@FeeTypeID", SqlDbType.TinyInt, 1, "FeeTypeID"),
      new SqlParameter("@Payable", SqlDbType.Bit, 1, "Payable"),
      new SqlParameter("@FlatRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 7, (byte) 2, "FlatRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@PercentageRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 7, (byte) 6, "PercentageRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@ApplyPremiumEqualOrLess", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 11, (byte) 2, "ApplyPremiumEqualOrLess", DataRowVersion.Current, (object) null),
      new SqlParameter("@ApplyPremiumEqualOrOver", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 11, (byte) 2, "ApplyPremiumEqualOrOver", DataRowVersion.Current, (object) null),
      new SqlParameter("@AutoApply", SqlDbType.Bit, 1, "AutoApply"),
      new SqlParameter("@Effective", SqlDbType.DateTime, 8, "Effective"),
      new SqlParameter("@Splittable", SqlDbType.Bit, 1, "Splittable"),
      new SqlParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      new SqlParameter("@PayableEntityType", SqlDbType.Char, 1, "PayableEntityType"),
      new SqlParameter("@PayableEntityGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "PayableEntityGuid"),
      new SqlParameter("@Minimum", SqlDbType.Int, 4, "Minimum"),
      new SqlParameter("@ExcludeWhenNotFiling", SqlDbType.Bit, 1, "ExcludeWhenNotFiling"),
      new SqlParameter("@ExcludeOnEndorsements", SqlDbType.Bit, 1, "ExcludeOnEndorsements"),
      new SqlParameter("@AppliesToPaymentID", SqlDbType.Char, 1, "AppliesToPaymentID"),
      new SqlParameter("@FullyEarned", SqlDbType.Bit, 1, "FullyEarned"),
      new SqlParameter("@RoundToDollar", SqlDbType.Bit, 1, "RoundToDollar"),
      new SqlParameter("@MaxPercentage", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 7, (byte) 6, "MaxPercentage", DataRowVersion.Current, (object) null),
      new SqlParameter("@MaxDollars", SqlDbType.Int, 4, "MaxDollars"),
      new SqlParameter("@Disabled", SqlDbType.DateTime, 8, "Disabled"),
      new SqlParameter("@ExcludeOnRenewal", SqlDbType.Bit, 1, "ExcludeOnRenewal"),
      new SqlParameter("@PercentageNet", SqlDbType.Bit, 1, "PercentageNet"),
      new SqlParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGuid"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGuid"),
      new SqlParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      new SqlParameter("@CompanyLicenceTypeID", SqlDbType.TinyInt, 1, "CompanyLicenceTypeID"),
      new SqlParameter("@TerrorismExcluded", SqlDbType.Bit, 1, "TerrorismExcluded"),
      new SqlParameter("@FeeBasedOnNumberOfLocations", SqlDbType.Bit, 1, "FeeBasedOnNumberOfLocations"),
      new SqlParameter("@StateOfIssuanceOnly", SqlDbType.Bit, 1, "StateOfIssuanceOnly"),
      new SqlParameter("@MinStrat", SqlDbType.TinyInt, 1, "MinStrat"),
      new SqlParameter("@MaxStrat", SqlDbType.TinyInt, 1, "MaxStrat"),
      new SqlParameter("@KentuckyCityID", SqlDbType.Int, 4, "KentuckyCityID"),
      new SqlParameter("@ApplyPackagePolicyOnly", SqlDbType.Bit, 1, "ApplyPackagePolicyOnly"),
      new SqlParameter("@DoNotApplyPackagePolicyOnly", SqlDbType.Bit, 1, "DoNotApplyPackagePolicyOnly"),
      new SqlParameter("@PremiumAllocationType", SqlDbType.Char, 1, "PremiumAllocationType"),
      new SqlParameter("@SendToAccounting", SqlDbType.Bit, 1, "SendToAccounting"),
      new SqlParameter("@FeeBasedOnNumberOfVehicles", SqlDbType.Bit, 1, "FeeBasedOnNumberOfVehicles"),
      new SqlParameter("@AppliesToAllStates", SqlDbType.Bit, 1, "AppliesToAllStates"),
      new SqlParameter("@MasterPayee", SqlDbType.Bit, 1, "MasterPayee"),
      new SqlParameter("@PayHomeState", SqlDbType.Bit, 1, "PayHomeState"),
      new SqlParameter("@RoundDown", SqlDbType.Bit, 1, "RoundDown"),
      new SqlParameter("@RoundUp", SqlDbType.Bit, 1, "RoundUp"),
      new SqlParameter("@NoRounding", SqlDbType.Bit, 1, "NoRounding"),
      new SqlParameter("@InternationalStratification", SqlDbType.Bit, 1, "InternationalStratification"),
      new SqlParameter("@ExcludeInternationalPremiums", SqlDbType.Bit, 1, "ExcludeInternationalPremiums"),
      new SqlParameter("@ApplyToChildLines", SqlDbType.Bit, 1, "ApplyToChildLines"),
      new SqlParameter("@RoundToCent", SqlDbType.Bit, 1, "RoundToCent"),
      new SqlParameter("@RoundUpToCent", SqlDbType.Bit, 1, "RoundUpToCent"),
      new SqlParameter("@ExcludeMultiCarrier", SqlDbType.Bit, 1, "ExcludeMultiCarrier"),
      new SqlParameter("@ApplytoFlatCanc", SqlDbType.Bit, 1, "ApplytoFlatCanc"),
      new SqlParameter("@ExcludeOriginalBinder", SqlDbType.Bit, 1, "ExcludeOriginalBinder"),
      new SqlParameter("@AddedBy", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "AddedBy"),
      new SqlParameter("@EditedBy", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "EditedBy"),
      new SqlParameter("@AddedDate", SqlDbType.DateTime, 8, "AddedDate"),
      new SqlParameter("@EditedDate", SqlDbType.DateTime, 8, "EditedDate"),
      new SqlParameter("@Notes", SqlDbType.VarChar, 2000, "Notes"),
      new SqlParameter("@CountyTaxIncludedInRate", SqlDbType.Bit, 1, "CountyTaxIncludedInRate"),
      new SqlParameter("@MandatoryCharge", SqlDbType.Bit, 1, "MandatoryCharge"),
      new SqlParameter("@FullyEarnedNumDays", SqlDbType.SmallInt, 2, "FullyEarnedNumDays"),
      new SqlParameter("@Original_CompanyFeeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyFeeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@CompanyFeeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyFeeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ApplyOnce", SqlDbType.Bit, 1, "ApplyOnce")
    });
    this.lblEntityGuid.BorderStyle = BorderStyle.Fixed3D;
    this.lblEntityGuid.DataBindings.Add(new Binding("Text", (object) this.dsFees, "tblCompanyPolicyCharges.PayableEntityGuid", true));
    this.lblEntityGuid.Location = new Point(560, 140);
    this.lblEntityGuid.Name = "lblEntityGuid";
    this.lblEntityGuid.Size = new Size(28, 21);
    this.lblEntityGuid.TabIndex = 3;
    this.lblEntityGuid.Visible = false;
    this.lblEntityType.BorderStyle = BorderStyle.Fixed3D;
    this.lblEntityType.DataBindings.Add(new Binding("Text", (object) this.dsFees, "tblCompanyPolicyCharges.PayableEntityType", true));
    this.lblEntityType.Location = new Point(525, 140);
    this.lblEntityType.Name = "lblEntityType";
    this.lblEntityType.Size = new Size(28, 21);
    this.lblEntityType.TabIndex = 2;
    this.lblEntityType.Visible = false;
    ((Control) this.dgFees).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgFees).DataSource = (object) this.dsFees.tblCompanyPolicyCharges;
    appearance48.BackColor = Color.White;
    appearance48.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgFees).DisplayLayout.Appearance = (AppearanceBase) appearance48;
    ((UltraGridBase) this.dgFees).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 8;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 19;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 135;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 140;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 5;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 57;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 4;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 18;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 8;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 80 /*0x50*/;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 6;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 16 /*0x10*/;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 7;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 60;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 91;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 21;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 24;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance49).TextHAlignAsString = "Right";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance49;
    ultraGridColumn13.Format = "c";
    ((AppearanceBase) appearance50).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance50;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Less or Equal";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 13;
    ultraGridColumn13.Width = 126;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance51).TextHAlignAsString = "Right";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance51;
    ultraGridColumn14.Format = "c";
    ((AppearanceBase) appearance52).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance52;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Greater or Equal";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 14;
    ultraGridColumn14.Width = (int) sbyte.MaxValue;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Auto";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 15;
    ultraGridColumn15.Width = 96 /*0x60*/;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance53).TextHAlignAsString = "Right";
    ultraGridColumn16.CellAppearance = (AppearanceBase) appearance53;
    ultraGridColumn16.Format = "d";
    ((AppearanceBase) appearance54).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn16.Header).Appearance = (AppearanceBase) appearance54;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn16.Width = 71;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 17;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 16 /*0x10*/;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 18;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 15;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 19;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 25;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance55).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn20.Header).Appearance = (AppearanceBase) appearance55;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Fee";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 12;
    ultraGridColumn20.Width = 290;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance56).TextHAlignAsString = "Right";
    ultraGridColumn21.CellAppearance = (AppearanceBase) appearance56;
    ultraGridColumn21.Format = "c";
    ((AppearanceBase) appearance57).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn21.Header).Appearance = (AppearanceBase) appearance57;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 20;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 56;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 21;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 32 /*0x20*/;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 22;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 36;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 23;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 28;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 24;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 31 /*0x1F*/;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 25;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 19;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 26;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 23;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 27;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 24;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 28;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 18;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 60;
    ultraGridColumn30.Width = 73;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 29;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 76;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 30;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 78;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn33.Width = 147;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 32 /*0x20*/;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn34.Width = 87;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 33;
    ultraGridColumn35.Hidden = true;
    ultraGridColumn35.Width = 67;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 34;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn36.Width = 67;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 35;
    ultraGridColumn37.Hidden = true;
    ultraGridColumn37.Width = 117;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 36;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 107;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 37;
    ultraGridColumn39.Hidden = true;
    ultraGridColumn39.Width = 67;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 38;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 63 /*0x3F*/;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 39;
    ultraGridColumn41.Hidden = true;
    ultraGridColumn41.Width = 82;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 40;
    ultraGridColumn42.Hidden = true;
    ultraGridColumn42.Width = 94;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 41;
    ultraGridColumn43.Hidden = true;
    ultraGridColumn43.Width = 106;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 42;
    ultraGridColumn44.Hidden = true;
    ultraGridColumn44.Width = 128 /*0x80*/;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 43;
    ultraGridColumn45.Hidden = true;
    ultraGridColumn45.Width = 124;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 44;
    ultraGridColumn46.Hidden = true;
    ultraGridColumn46.Width = 152;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 45;
    ultraGridColumn47.Hidden = true;
    ultraGridColumn47.Width = 72;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 46;
    ultraGridColumn48.Hidden = true;
    ultraGridColumn48.Width = 72;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 47;
    ultraGridColumn49.Hidden = true;
    ultraGridColumn49.Width = 72;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 48 /*0x30*/;
    ultraGridColumn50.Hidden = true;
    ultraGridColumn50.Width = 129;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 49;
    ultraGridColumn51.Hidden = true;
    ultraGridColumn51.Width = 145;
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 50;
    ultraGridColumn52.Hidden = true;
    ultraGridColumn52.Width = 103;
    ((HeaderBase) ultraGridColumn53.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 51;
    ultraGridColumn53.Width = 108;
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.Header.VisiblePosition = 52;
    ultraGridColumn54.Hidden = true;
    ultraGridColumn54.Width = 67;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.Header.VisiblePosition = 53;
    ultraGridColumn55.Hidden = true;
    ultraGridColumn55.Width = 85;
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn56.Header.VisiblePosition = 54;
    ultraGridColumn56.Hidden = true;
    ultraGridColumn56.Width = 108;
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn57.Header.VisiblePosition = 55;
    ultraGridColumn57.Hidden = true;
    ultraGridColumn57.Width = 96 /*0x60*/;
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn58.Header.VisiblePosition = 56;
    ultraGridColumn58.Hidden = true;
    ultraGridColumn58.Width = 118;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn59.Header.VisiblePosition = 57;
    ultraGridColumn59.Hidden = true;
    ultraGridColumn59.Width = 117;
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn60.Header.VisiblePosition = 58;
    ultraGridColumn60.Hidden = true;
    ultraGridColumn60.Width = 169;
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn61.Header.VisiblePosition = 59;
    ultraGridColumn61.Hidden = true;
    ultraGridColumn61.Width = 59;
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn62.Header.VisiblePosition = 61;
    ultraGridColumn62.Hidden = true;
    ultraGridColumn62.Width = 80 /*0x50*/;
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn63.Header.VisiblePosition = 62;
    ultraGridColumn63.Hidden = true;
    ultraGridColumn63.Width = 104;
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn64.Header.VisiblePosition = 63 /*0x3F*/;
    ultraGridColumn64.Hidden = true;
    ultraGridColumn64.Width = 133;
    ((HeaderBase) ultraGridColumn65.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn65.Header.VisiblePosition = 64 /*0x40*/;
    ultraGridColumn65.Hidden = true;
    ultraGridColumn65.Width = 102;
    ((HeaderBase) ultraGridColumn66.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn66.Header.VisiblePosition = 65;
    ultraGridColumn66.Width = 111;
    ultraGridBand.Columns.AddRange(new object[66]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47,
      (object) ultraGridColumn48,
      (object) ultraGridColumn49,
      (object) ultraGridColumn50,
      (object) ultraGridColumn51,
      (object) ultraGridColumn52,
      (object) ultraGridColumn53,
      (object) ultraGridColumn54,
      (object) ultraGridColumn55,
      (object) ultraGridColumn56,
      (object) ultraGridColumn57,
      (object) ultraGridColumn58,
      (object) ultraGridColumn59,
      (object) ultraGridColumn60,
      (object) ultraGridColumn61,
      (object) ultraGridColumn62,
      (object) ultraGridColumn63,
      (object) ultraGridColumn64,
      (object) ultraGridColumn65,
      (object) ultraGridColumn66
    });
    ((UltraGridBase) this.dgFees).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgFees).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance58.BackColor = Color.LightSteelBlue;
    appearance58.FontData.SizeInPoints = 10f;
    appearance58.ForeColor = Color.Black;
    ((UltraGridBase) this.dgFees).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance58;
    appearance59.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance59.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance59.ForeColor = Color.Black;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance59;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance60.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance60;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance61.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance61;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance62.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance62;
    appearance63.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance63;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance64.BackColor = Color.Transparent;
    appearance64.ForeColor = Color.Black;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance64;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgFees).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgFees).Location = new Point(7, 41);
    ((Control) this.dgFees).Name = "dgFees";
    ((Control) this.dgFees).Size = new Size(1004, 164);
    ((Control) this.dgFees).TabIndex = 1;
    ((UltraControlBase) this.dgFees).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgFees).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tabControl).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.tabControl).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.tabControl).Controls.Add((Control) this.tabFeeInfo);
    ((Control) this.tabControl).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.tabControl).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.tabControl).Controls.Add((Control) this.UltraTabPageControl4);
    ((Control) this.tabControl).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.tabControl).Controls.Add((Control) this.tabHistory);
    ((Control) this.tabControl).Controls.Add((Control) this.tabClientInfo);
    ((Control) this.tabControl).Location = new Point(7, 211);
    ((Control) this.tabControl).Name = "tabControl";
    appearance65.BackColor = Color.WhiteSmoke;
    ((UltraTabControlBase) this.tabControl).SelectedTabAppearance = (AppearanceBase) appearance65;
    ((UltraTabControlBase) this.tabControl).SharedControls.AddRange(new Control[1]
    {
      (Control) this.dbSave
    });
    ((UltraTabControlBase) this.tabControl).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.tabControl).Size = new Size(1004, 355);
    ((Control) this.tabControl).TabIndex = 0;
    ((UltraTabControlBase) this.tabControl).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.tabControl).TabPadding = new Size(10, 3);
    appearance66.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance51.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance66;
    ultraTab1.Key = "tabFeeInfo";
    ultraTab1.TabPage = this.tabFeeInfo;
    ultraTab1.Text = "Fee Info";
    ultraTab2.Key = "tabClientInfo";
    ultraTab2.TabPage = this.tabClientInfo;
    ultraTab2.Text = "Client Info";
    ultraTab2.Visible = false;
    appearance67.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance52.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance67;
    ultraTab3.TabPage = this.UltraTabPageControl2;
    ultraTab3.Text = "Auto Apply";
    appearance68.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance53.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance68;
    ultraTab4.Key = "tabPayable";
    ultraTab4.TabPage = this.UltraTabPageControl3;
    ultraTab4.Text = "Payable Info";
    appearance69.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance54.Image"));
    ultraTab5.Appearance = (AppearanceBase) appearance69;
    ultraTab5.Key = "tabExclusions";
    ultraTab5.TabPage = this.UltraTabPageControl4;
    ultraTab5.Text = "Exclusions";
    appearance70.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance55.Image"));
    ultraTab6.Appearance = (AppearanceBase) appearance70;
    ultraTab6.Key = "tabMaximums";
    ultraTab6.TabPage = this.UltraTabPageControl1;
    ultraTab6.Text = "Maximums";
    appearance71.Image = (object) MGASystems.IMS.InsuredsProducersCompanies.My.Resources.Resources.application_cascade;
    ultraTab7.Appearance = (AppearanceBase) appearance71;
    ultraTab7.TabPage = this.tabHistory;
    ultraTab7.Text = "History";
    ((UltraTabControlBase) this.tabControl).Tabs.AddRange(new UltraTab[7]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5,
      ultraTab6,
      ultraTab7
    });
    ((UltraTabControlBase) this.tabControl).TabSize = new Size(125, 0);
    ((UltraTabControlBase) this.tabControl).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(1002, 328);
    this.Label22.AutoSize = true;
    this.Label22.BackColor = Color.Transparent;
    this.Label22.Location = new Point(5, 16 /*0x10*/);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(56, 13);
    this.Label22.TabIndex = 23;
    this.Label22.Text = "Fee Filter:";
    this.Label22.TextAlign = ContentAlignment.MiddleRight;
    appearance72.BackColor = Color.White;
    appearance72.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance72.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFeeFilter).Appearance = (AppearanceBase) appearance72;
    ((TextEditorControlBase) this.txtFeeFilter).BackColor = Color.White;
    ((Control) this.txtFeeFilter).Location = new Point(67, 13);
    ((TextEditorControlBase) this.txtFeeFilter).MaxLength = 35;
    this.txtFeeFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFeeFilter).Name = "txtFeeFilter";
    ((Control) this.txtFeeFilter).Size = new Size(260, 20);
    ((Control) this.txtFeeFilter).TabIndex = 24;
    ((UltraControlBase) this.txtFeeFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFeeFilter).UseOsThemes = (DefaultableBoolean) 2;
    appearance73.BorderColor = Color.Gray;
    appearance73.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkIncludeNonGlobal).Appearance = (AppearanceBase) appearance73;
    ((UltraToggleEditorBase) this.checkIncludeNonGlobal).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.checkIncludeNonGlobal).Location = new Point(588, 12);
    ((Control) this.checkIncludeNonGlobal).Name = "checkIncludeNonGlobal";
    ((Control) this.checkIncludeNonGlobal).Size = new Size(147, 20);
    ((Control) this.checkIncludeNonGlobal).TabIndex = 34;
    ((UltraToggleEditorBase) this.checkIncludeNonGlobal).Text = "Show Non-global fees";
    this.da.DeleteCommand = this.SqlDeleteCommand2;
    this.da.InsertCommand = this.SqlInsertCommand2;
    this.da.SelectCommand = this.SqlSelectCommand4;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyPolicyChargesPolicyTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("CompanyFeeID", "CompanyFeeID"),
        new DataColumnMapping("PolicyTypeID", "PolicyTypeID")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM [dbo].[tblCompanyPolicyChargesPolicyTypes] WHERE (([CompanyFeeID] = @Original_CompanyFeeID) AND ([PolicyTypeID] = @Original_PolicyTypeID))";
    this.SqlDeleteCommand2.Connection = this.cnSQL;
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_CompanyFeeID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyFeeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_PolicyTypeID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PolicyTypeID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = componentResourceManager.GetString("SqlInsertCommand2.CommandText");
    this.SqlInsertCommand2.Connection = this.cnSQL;
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@CompanyFeeID", SqlDbType.Int, 0, "CompanyFeeID"),
      new SqlParameter("@PolicyTypeID", SqlDbType.Int, 0, "PolicyTypeID")
    });
    this.SqlSelectCommand4.CommandText = componentResourceManager.GetString("SqlSelectCommand4.CommandText");
    this.SqlSelectCommand4.Connection = this.cnSQL;
    this.SqlSelectCommand4.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@companyLineGuid", SqlDbType.UniqueIdentifier)
    });
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Connection = this.cnSQL;
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@CompanyFeeID", SqlDbType.Int, 0, "CompanyFeeID"),
      new SqlParameter("@PolicyTypeID", SqlDbType.Int, 0, "PolicyTypeID"),
      new SqlParameter("@Original_CompanyFeeID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyFeeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_PolicyTypeID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PolicyTypeID", DataRowVersion.Original, (object) null)
    });
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(1017, 574);
    this.Controls.Add((Control) this.checkIncludeNonGlobal);
    this.Controls.Add((Control) this.txtFeeFilter);
    this.Controls.Add((Control) this.Label22);
    this.Controls.Add((Control) this.lblEntityGuid);
    this.Controls.Add((Control) this.lblEntityType);
    this.Controls.Add((Control) this.tabControl);
    this.Controls.Add((Control) this.dgFees);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmAdminCompanyPolicyFees);
    this.Text = "Policy Fee Administration";
    ((ISupportInitialize) pictureBox).EndInit();
    ((Control) this.tabFeeInfo).ResumeLayout(false);
    ((Control) this.tabFeeInfo).PerformLayout();
    ((ISupportInitialize) this.chkCountyTaxIncRate).EndInit();
    this.dsFees.EndInit();
    ((ISupportInitialize) this.chkFeeBasedOnNumberVehicles).EndInit();
    ((ISupportInitialize) this.cboKentuckyCities).EndInit();
    ((ISupportInitialize) this.MgaCheckBox1).EndInit();
    ((ISupportInitialize) this.txtFullyEarnedDays).EndInit();
    ((ISupportInitialize) this.chkFeeBasedOnNumberOfLocations).EndInit();
    ((ISupportInitialize) this.chkTerrorismExcluded).EndInit();
    ((ISupportInitialize) this.cboLicenseTypes).EndInit();
    ((ISupportInitialize) this.cboStates).EndInit();
    ((ISupportInitialize) this.cboLines).EndInit();
    ((ISupportInitialize) this.cboCompanyLocations).EndInit();
    ((ISupportInitialize) this.MgaDateTimePicker1).EndInit();
    ((ISupportInitialize) this.MgaCheckBox3).EndInit();
    ((ISupportInitialize) this.chkFullyEarned).EndInit();
    ((ISupportInitialize) this.cboFee).EndInit();
    ((ISupportInitialize) this.dtEffective).EndInit();
    ((ISupportInitialize) this.cboOffices).EndInit();
    ((ISupportInitialize) this.cboInstallmentBilling).EndInit();
    ((ISupportInitialize) this.chkSplittable).EndInit();
    ((ISupportInitialize) this.cboFeeComm).EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    ((ISupportInitialize) this.txtPercentageMinimum).EndInit();
    ((ISupportInitialize) this.txtFlatFee).EndInit();
    ((ISupportInitialize) this.txtPercentage).EndInit();
    ((ISupportInitialize) this.chkExcInternational).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.chckPackageApplyOnce).EndInit();
    ((ISupportInitialize) this.chkMandatoryCharge).EndInit();
    ((ISupportInitialize) this.chkApplyToFlatCancellations).EndInit();
    ((ISupportInitialize) this.chkCountInternational).EndInit();
    ((ISupportInitialize) this.checkAppliesToAllStates).EndInit();
    ((ISupportInitialize) this.optionPremiumAmtAuto).EndInit();
    ((ISupportInitialize) this.chkApplyToChildLines).EndInit();
    ((ISupportInitialize) this.chkApplyPackagePolicy).EndInit();
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.numMaxStrat).EndInit();
    ((ISupportInitialize) this.numMinStrat).EndInit();
    ((ISupportInitialize) this.chkStateOfIssuanceOnly).EndInit();
    ((ISupportInitialize) this.chkAutoApply).EndInit();
    ((ISupportInitialize) this.txtPremiumLess).EndInit();
    ((ISupportInitialize) this.txtPremiumGreater).EndInit();
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((Control) this.UltraTabPageControl3).PerformLayout();
    ((ISupportInitialize) this.checkMasterPayee).EndInit();
    ((ISupportInitialize) this.lblPayableTo).EndInit();
    ((Control) this.UltraTabPageControl4).ResumeLayout(false);
    ((Control) this.UltraTabPageControl4).PerformLayout();
    ((ISupportInitialize) this.lstPolicyTypeExcl).EndInit();
    ((ISupportInitialize) this.chkExcludeOriginalBinder).EndInit();
    ((ISupportInitialize) this.checkPayHomeState).EndInit();
    ((ISupportInitialize) this.MgaCheckBox5).EndInit();
    ((ISupportInitialize) this.chkExcludeMultiCarrier).EndInit();
    ((ISupportInitialize) this.MgaCheckBox2).EndInit();
    ((ISupportInitialize) this.chkExcludeEndorsements).EndInit();
    ((ISupportInitialize) this.chkExcludeFiling).EndInit();
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.txtMaxDollars).EndInit();
    ((ISupportInitialize) this.txtMaxPercentage).EndInit();
    ((Control) this.tabHistory).ResumeLayout(false);
    ((Control) this.tabHistory).PerformLayout();
    ((ISupportInitialize) this.txtNotes).EndInit();
    ((ISupportInitialize) this.dtpEdited).EndInit();
    ((ISupportInitialize) this.cboEditedBy).EndInit();
    ((ISupportInitialize) this.cboAddedBy).EndInit();
    ((ISupportInitialize) this.dtpAddedDate).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.dgFees).EndInit();
    ((ISupportInitialize) this.tabControl).EndInit();
    ((Control) this.tabControl).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((ISupportInitialize) this.txtFeeFilter).EndInit();
    ((ISupportInitialize) this.checkIncludeNonGlobal).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmAdminCompanyPolicyFees(Guid companyLineGuid)
  {
    this.Load += new EventHandler(this.frmCompanyPolicyFees_Load);
    this._companyLineGuid = Guid.Empty;
    this._enableDropDowns = true;
    this._showSurplusLines = false;
    this._ShowCountyTaxIncludedInRate = false;
    this._feeAppliedDictionary = new Dictionary<int, bool>();
    this.InitializeComponent();
    this._companyLineGuid = companyLineGuid;
    this._enableDropDowns = false;
    ((Control) this.checkIncludeNonGlobal).Visible = false;
  }

  public frmAdminCompanyPolicyFees()
  {
    this.Load += new EventHandler(this.frmCompanyPolicyFees_Load);
    this._companyLineGuid = Guid.Empty;
    this._enableDropDowns = true;
    this._showSurplusLines = false;
    this._ShowCountyTaxIncludedInRate = false;
    this._feeAppliedDictionary = new Dictionary<int, bool>();
    this.InitializeComponent();
    this._showOnlyGenericFees = true;
  }

  protected BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.dsFees, this.dsFees.tblCompanyPolicyCharges.TableName];
  }

  protected dsCompanyPolicyFees BaseDataset => this.dsFees;

  private void frmCompanyPolicyFees_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    dsCompanyPolicyFees.tblCompanyLocationsRow row1 = this.dsFees.tblCompanyLocations.NewtblCompanyLocationsRow();
    row1.CompanyLocationGuid = Guid.Empty;
    row1.LocationName = string.Empty;
    this.dsFees.tblCompanyLocations.AddtblCompanyLocationsRow(row1);
    dsCompanyPolicyFees.lstLinesRow row2 = this.dsFees.lstLines.NewlstLinesRow();
    row2.LineGuid = Guid.Empty;
    row2.LineName = string.Empty;
    this.dsFees.lstLines.AddlstLinesRow(row2);
    dsCompanyPolicyFees.lstStatesRow row3 = this.dsFees.lstStates.NewlstStatesRow();
    row3.StateID = string.Empty;
    row3.State = string.Empty;
    this.dsFees.lstStates.AddlstStatesRow(row3);
    dsCompanyPolicyFees.lstCompanyLicenseTypesRow row4 = this.dsFees.lstCompanyLicenseTypes.NewlstCompanyLicenseTypesRow();
    row4.CompanyLicenceType = string.Empty;
    row4.CompanyLicenceTypeID = -1;
    this.dsFees.lstCompanyLicenseTypes.AddlstCompanyLicenseTypesRow(row4);
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.dsFees, new string[10]
      {
        "lstFeeTypes",
        "tblFin_PolicyCharges",
        "lstFeeAppliesToPayment",
        "tblClientOffices",
        "tblCompanyLocations",
        "lstLines",
        "lstStates",
        "lstCompanyLicenseTypes",
        "tblKentuckyCities",
        "tblUsers"
      }, "dbo.spCompanyFeesFormData");
      this._showSurplusLines = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("EnableSurplusLinesTax");
      this._ShowCountyTaxIncludedInRate = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ShowCountyTaxIncludedInRate");
      if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("UsingInternationalStateStratification"))
      {
        ((Control) this.chkCountInternational).Visible = true;
        ((Control) this.chkExcInternational).Visible = true;
      }
      this.FillPolicyTypes();
      this.FillData();
      this.SetTabPagesEnabledState(false);
      IEnumerator enumerator;
      try
      {
        enumerator = ((Control) this.tabClientInfo).Controls.GetEnumerator();
        if (enumerator.MoveNext())
        {
          Control current = (Control) enumerator.Current;
          this.tabClientInfo.Tab.Visible = true;
        }
      }
      finally
      {
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this._hasMandatoryChargePermission = SecurityManager.Instance.AssertPermission("{559D04BC-6154-43EC-AC8B-2910F82BBC85}");
      this.lnkCopyFees.Visible = !this._companyLineGuid.Equals(Guid.Empty);
      ((Control) this.txtPremiumGreater).DataBindings["Text"].Parse += new ConvertEventHandler(this.ParseNumber);
      ((Control) this.txtPremiumLess).DataBindings["Text"].Parse += new ConvertEventHandler(this.ParseNumber);
      ((Control) this.txtFlatFee).DataBindings["Text"].Parse += new ConvertEventHandler(this.ParseNumber);
      ((Control) this.txtPercentage).DataBindings["Text"].Parse += new ConvertEventHandler(this.ParseNumber);
      this.bmb.PositionChanged += new EventHandler(this.bmb_PositionChanged);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void FillData()
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this.daCompanyPolicyCharges.SelectCommand.Parameters["@CompanyLineGuid"].Value = !this._companyLineGuid.Equals(Guid.Empty) ? (object) this._companyLineGuid : (object) null;
      this.daCompanyPolicyCharges.SelectCommand.Parameters["@showOnlyGenericFees"].Value = (object) this._showOnlyGenericFees;
      this.daCompanyPolicyCharges.SelectCommand.Parameters["@showAll"].Value = (object) this._showAll;
      try
      {
        DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daCompanyPolicyCharges, (DataTable) this.dsFees.tblCompanyPolicyCharges);
      }
      catch (ConstraintException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.ShowDataSetErrors((DataSet) this.dsFees, ex);
        ProjectData.ClearProjectError();
      }
      if (this.dsFees.tblCompanyPolicyCharges.Count > 0)
      {
        this.dgFees.Selected.Rows.Clear();
        if (((UltraGridBase) this.dgFees).Rows.Count > 0)
        {
          ((UltraGridBase) this.dgFees).Rows[0].Selected = true;
          ((UltraGridBase) this.dgFees).Rows[0].Activate();
        }
      }
      this.dbSave.UIState = this.dsFees.tblCompanyPolicyCharges.Rows.Count != 0 ? UIState.HasRecordsNotEditing : UIState.NoRecordsNotEditing;
      if (this.dsFees.tblCompanyPolicyCharges.Rows.Count > 0)
        this.bmb_PositionChanged((object) null, (EventArgs) null);
      this.LookForAndShowDisabledFees();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void LookForAndShowDisabledFees()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.dgFees).Rows)
    {
      row.Appearance.ForeColor = Color.Black;
      row.Appearance.FontData.Strikeout = (DefaultableBoolean) 0;
      if (row.Cells["Disabled"].Value != DBNull.Value)
      {
        Appearance appearance = row.Appearance;
        appearance.ForeColor = Color.Red;
        appearance.FontData.Strikeout = (DefaultableBoolean) 1;
      }
    }
  }

  private void lnkSelectPayableEntity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (frmSelectEntity formEx = (frmSelectEntity) ObjectFactory.Instance.CreateFormEX(typeof (frmSelectEntity)))
    {
      int num = (int) formEx.ShowDialog();
      this.bmb.EndCurrentEdit();
      if (!formEx.EntityGuid.Equals(Guid.Empty))
      {
        dsCompanyPolicyFees.tblCompanyPolicyChargesRow companyPolicyCharge = this.dsFees.tblCompanyPolicyCharges[this.bmb.Position];
        companyPolicyCharge.PayableEntity = formEx.EntityName;
        companyPolicyCharge.PayableEntityGuid = formEx.EntityGuid;
        companyPolicyCharge.PayableEntityType = formEx.EntityTypeID;
      }
      else
      {
        dsCompanyPolicyFees.tblCompanyPolicyChargesRow companyPolicyCharge = this.dsFees.tblCompanyPolicyCharges[this.bmb.Position];
        companyPolicyCharge.PayableEntity = string.Empty;
        companyPolicyCharge.SetPayableEntityGuidNull();
        companyPolicyCharge.SetPayableEntityTypeNull();
        this.rbNotPayable.Checked = true;
      }
    }
  }

  private void ChangePayableStatus(object sender, EventArgs e)
  {
    if (this.dbSave.UIState == UIState.Editing && this.bmb.Position != -1)
    {
      dsCompanyPolicyFees.tblCompanyPolicyChargesRow companyPolicyCharge = this.dsFees.tblCompanyPolicyCharges[this.bmb.Position];
      companyPolicyCharge.PayableEntity = string.Empty;
      companyPolicyCharge.SetPayableEntityGuidNull();
      companyPolicyCharge.SetPayableEntityTypeNull();
    }
    this.lnkSelectPayableEntity.Enabled = this.rbPayableTo.Checked;
  }

  private void MassageColumnNames(Dictionary<string, string> dictCols)
  {
    dictCols.Add("CompanyLocationGuid", "Company Location");
    dictCols.Add("LineGuid", "Line");
    dictCols.Add("StateID", "State");
    dictCols.Add("FeeTypeID", "Commissionable");
    dictCols.Add("CompanyLicenceTypeID", "License Type");
    dictCols.Add("Payable", "Payable");
    dictCols.Add("Taxable", "Taxable");
    dictCols.Add("Override", "Override");
    dictCols.Add("TerrorismExcluded", "Terrorism Excluded");
    dictCols.Add("PercentageRate", "Percentage Rate");
    dictCols.Add("ExcludeOnEndorsements", "Exclude On Endorsements");
    dictCols.Add("ExcludeOnRenewal", "Exclude On Renewal");
    dictCols.Add("MaxPercentage", "Maximum %");
    dictCols.Add("Effective", "Effective");
    dictCols.Add("AutoApply", "Auto Apply");
    dictCols.Add("Disabled", "Disabled");
    dictCols.Add("RoundToDollar", "Round To Dollar");
    dictCols.Add("OfficeID", "Office");
    dictCols.Add("ExcludeWhenNotFiling", "Exclude When Not Filing");
    dictCols.Add("MaxDollars", "Maximum $");
    dictCols.Add("PercentageNet", "% of net");
    dictCols.Add("FlatRate", "Flat Rate");
    dictCols.Add("FeeBasedOnNumberOfLocations", "Fee Multiply by Number Of Locations");
    dictCols.Add("MinStrat", "Premium Stratification Minimum");
    dictCols.Add("MaxStrat", "Premium Stratification Maximum");
    dictCols.Add("Minimum", "Minimum");
    dictCols.Add("Splittable", "Split by participation %");
    dictCols.Add("StateOfIssuanceOnly", "Only applies to State Of Issuance Only");
    dictCols.Add("PayableEntityGuid", "Payable to");
    dictCols.Add("FullyEarned", "Fully Earned");
    dictCols.Add("ApplyPremiumEqualOrLess", "Apply when premium is equal or less");
    dictCols.Add("ApplyPremiumEqualOrOver", "Apply when premium is equal or over");
    dictCols.Add("FullyEarnedNumDays", "Days");
    dictCols.Add("AppliesToPaymentID", "Installment Billing");
    dictCols.Add("ApplyOnce", "Apply Once");
  }

  private string GetEntityValue(string objStr, object objValue)
  {
    string str1 = string.Empty;
    string str2 = objStr;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
    {
      case 293759076:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "OfficeID", false) == 0 && this.dsFees.tblClientOffices.Select("OfficeID = " + Conversions.ToString(Conversions.ToInteger(objValue))).Length > 0)
        {
          dsCompanyPolicyFees.tblClientOfficesRow clientOfficesRow = (dsCompanyPolicyFees.tblClientOfficesRow) this.dsFees.tblClientOffices.Select("OfficeID = " + Conversions.ToString(Conversions.ToInteger(objValue)))[0];
          if (clientOfficesRow != null)
          {
            str1 = clientOfficesRow.Location;
            break;
          }
          break;
        }
        break;
      case 338466441:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "AppliesToPaymentID", false) == 0)
        {
          dsCompanyPolicyFees.lstFeeAppliesToPaymentRow byId = this.dsFees.lstFeeAppliesToPayment.FindByID(objValue.ToString());
          if (byId != null)
          {
            str1 = byId.Description;
            break;
          }
          break;
        }
        break;
      case 1932964798:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CompanyLocationGuid", false) == 0)
        {
          dsCompanyPolicyFees.tblCompanyLocationsRow companyLocationGuid = this.dsFees.tblCompanyLocations.FindByCompanyLocationGuid((Guid) objValue);
          if (companyLocationGuid != null)
          {
            str1 = companyLocationGuid.LocationName;
            break;
          }
          break;
        }
        break;
      case 2523683638:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "FeeTypeID", false) == 0)
        {
          dsCompanyPolicyFees.lstFeeTypesRow byId = this.dsFees.lstFeeTypes.FindByID(Conversions.ToInteger(objValue));
          if (byId != null)
          {
            str1 = byId.FeeType;
            break;
          }
          break;
        }
        break;
      case 2881949570:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "CompanyLicenceTypeID", false) == 0)
        {
          dsCompanyPolicyFees.lstCompanyLicenseTypesRow companyLicenceTypeId = this.dsFees.lstCompanyLicenseTypes.FindByCompanyLicenceTypeID(Conversions.ToInteger(objValue));
          if (companyLicenceTypeId != null)
          {
            str1 = companyLicenceTypeId.CompanyLicenceType;
            break;
          }
          break;
        }
        break;
      case 2891989995:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "StateID", false) == 0)
        {
          dsCompanyPolicyFees.lstStatesRow byStateId = this.dsFees.lstStates.FindByStateID(objValue.ToString());
          if (byStateId != null)
          {
            str1 = byStateId.State;
            break;
          }
          break;
        }
        break;
      case 3062656610:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "LineGuid", false) == 0)
        {
          dsCompanyPolicyFees.lstLinesRow byLineGuid = this.dsFees.lstLines.FindByLineGuid((Guid) objValue);
          if (byLineGuid != null)
          {
            str1 = byLineGuid.LineName;
            break;
          }
          break;
        }
        break;
      case 3835556023:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "PayableEntityGuid", false) == 0)
        {
          object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT [PRIMARY] from dbo.GetEntityName(@ENTITYGUID)", new object[2]
          {
            (object) "@ENTITYGUID",
            (object) (Guid) objValue
          }));
          if (objectValue != null && objectValue != DBNull.Value)
          {
            str1 = objectValue.ToString();
            break;
          }
          break;
        }
        break;
    }
    return string.IsNullOrEmpty(str1) ? "NOT_AN_ENTITY_TYPE" : str1;
  }

  private string GetFeeInfo()
  {
    string feeInfo = string.Empty;
    if (!string.IsNullOrEmpty(this.cboFee.Text))
      feeInfo = $"Fee Name: '{this.cboFee.Text}' ";
    if (!string.IsNullOrEmpty(this.cboCompanyLocations.Text))
      feeInfo = $"{feeInfo} Company : '{this.cboCompanyLocations.Text}' ";
    if (!string.IsNullOrEmpty(this.cboLines.Text))
      feeInfo = $"{feeInfo} Line: '{this.cboLines.Text}' ";
    if (!string.IsNullOrEmpty(this.cboStates.Text))
      feeInfo = $"{feeInfo} State: '{this.cboStates.Text}' ";
    return feeInfo;
  }

  private void GetChanges(
    bool isNewRow,
    string feeInfo,
    dsCompanyPolicyFees.tblCompanyPolicyChargesRow dr,
    List<string> feeChangeList)
  {
    if (isNewRow)
    {
      CurrentUser.Instance.LogAction("Add New Fee. " + feeInfo, this._companyLineGuid);
    }
    else
    {
      Dictionary<string, string> dictCols = new Dictionary<string, string>();
      this.MassageColumnNames(dictCols);
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) this.dsFees.tblCompanyPolicyCharges.Columns)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr[column.ColumnName, DataRowVersion.Original].ToString(), dr[column.ColumnName, DataRowVersion.Current].ToString(), false) != 0)
          {
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            string str1 = !dictCols.ContainsKey(column.ColumnName) ? column.ColumnName : dictCols[column.ColumnName];
            string str2;
            if (dr[column.ColumnName] != DBNull.Value)
            {
              str2 = this.GetEntityValue(column.ColumnName, RuntimeHelpers.GetObjectValue(dr[column.ColumnName, DataRowVersion.Current]));
              if (str2.Equals("NOT_AN_ENTITY_TYPE"))
                str2 = dr[column.ColumnName, DataRowVersion.Current].ToString();
            }
            else
              str2 = "<empty>";
            string str3;
            if (dr[column.ColumnName, DataRowVersion.Original] != DBNull.Value)
            {
              str3 = this.GetEntityValue(column.ColumnName, RuntimeHelpers.GetObjectValue(dr[column.ColumnName, DataRowVersion.Original]));
              if (str3.Equals("NOT_AN_ENTITY_TYPE"))
                str3 = dr[column.ColumnName, DataRowVersion.Original].ToString();
            }
            else
              str3 = "<empty>";
            feeChangeList.Add($"Modified Fee: {feeInfo}.  Change {str1} from {str3} to {str2}");
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

  private void LogChanges(List<string> feeChangeList)
  {
    if (feeChangeList.Count == 0)
      return;
    int num = feeChangeList.Count - 1;
    for (int index = 0; index <= num; ++index)
      CurrentUser.Instance.LogAction(feeChangeList[index], this._companyLineGuid);
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (!this.IsSecuritySufficient() || !this.CanEditMandatoryChargeFees())
    {
      e.Cancel = true;
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to delete this fee setup?", "Delete Fee Setup?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      this.Cursor = MgaCursors.WaitCursor;
      string feeInfo = this.GetFeeInfo();
      string str = "DELETE FROM tblCompanyPolicyCharges WHERE CompanyFeeID=@ID";
      try
      {
        if (DefaultDatabase.ExecuteNonQuery(CommandType.Text, str, new object[2]
        {
          (object) "@ID",
          (object) this.dsFees.tblCompanyPolicyCharges[this.bmb.Position].CompanyFeeID
        }) == 0)
          throw new IncorrectNumberOfRowsAffectedException();
        this.dsFees.tblCompanyPolicyCharges.RemovetblCompanyPolicyChargesRow(this.dsFees.tblCompanyPolicyCharges[this.bmb.Position]);
      }
      catch (SqlException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SqlException ex2 = ex1;
        if (ex2.Message.Contains("FK_tblQuoteOptionCharges_tblCompanyPolicyCharges"))
        {
          int num = (int) MessageBox.Show("This fee can not be deleted because it is in use on one or more policies.\n\n If you would like to prevent this fee from being applied, please enter a disabled date.", "Fee In Use", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
          ErrorHandler.HandleError((Exception) ex2);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
      CurrentUser.Instance.LogAction("Deleted " + feeInfo, this._companyLineGuid);
    }
  }

  private void dgFees_AfterRowActivate(object sender, EventArgs e)
  {
    if (this.dbSave.UIState == UIState.Editing)
      return;
    Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgFees).ActiveRow.Cells["CompanyFeeID"].Value), "CompanyFeeID", (DataTable) this.dsFees.tblCompanyPolicyCharges, this.bmb);
    this.ClientAfterRowActivated(((UltraGridBase) this.dgFees).ActiveRow);
    try
    {
      int num = 0;
      try
      {
        foreach (dsCompanyPolicyFees.tblCompanyPolicyChargesRow row in this.dsFees.tblCompanyPolicyCharges.Rows)
        {
          if (row.RowState != DataRowState.Deleted)
          {
            if (row.CompanyFeeID == Conversions.ToInteger(((UltraGridBase) this.dgFees).ActiveRow.Cells["CompanyFeeID"].Value))
            {
              this.bmb.Position = num;
              dsCompanyPolicyFees.tblCompanyPolicyChargesRow companyPolicyCharge = this.dsFees.tblCompanyPolicyCharges[this.bmb.Position];
              this.rbFlat.Checked = !companyPolicyCharge.IsFlatRateNull();
              this.rbPercentage.Checked = !companyPolicyCharge.IsPercentageRateNull();
              ((UltraToggleEditorBase) this.chkExcInternational).Checked = companyPolicyCharge.ExcludeInternationalPremiums && this.rbPercentage.Checked;
              if (companyPolicyCharge.Payable)
                this.rbPayable.Checked = true;
              else if (!companyPolicyCharge.IsPayableEntityGuidNull())
                this.rbPayableTo.Checked = true;
              else
                this.rbNotPayable.Checked = true;
              this.SetDollarRounding(this.dsFees.tblCompanyPolicyCharges[this.bmb.Position]);
              this.ShowSelectedPolicyTypes();
              break;
            }
            ++num;
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
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  protected void ClientAfterRowActivated(UltraGridRow CurrentRow)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(CurrentRow.Cells["STATEID"].Value.ToString(), "KY", false) == 0 && this._ShowCountyTaxIncludedInRate)
      ((Control) this.chkCountyTaxIncRate).Visible = true;
    else
      ((Control) this.chkCountyTaxIncRate).Visible = false;
  }

  private void RadioChanged(object sender, EventArgs e)
  {
    ((Control) this.txtFlatFee).Enabled = this.rbFlat.Checked;
    ((Control) this.txtPercentage).Enabled = this.rbPercentage.Checked;
    ((Control) this.txtPercentageMinimum).Enabled = this.rbPercentage.Checked;
    ((Control) this.chkExcInternational).Enabled = this.rbPercentage.Checked;
  }

  private void ParseNumber(object sender, ConvertEventArgs e)
  {
    if (!e.Value.Equals((object) string.Empty))
      return;
    e.Value = (object) DBNull.Value;
  }

  private void bmb_PositionChanged(object sender, EventArgs e)
  {
    this.BindingManagerChangedEvent(this.bmb.Position);
  }

  protected virtual void BindingManagerChangedEvent(int bmbPosition)
  {
    if (this.bmb.Position == -1 || this.dsFees.tblCompanyPolicyCharges.Count == 0)
      return;
    dsCompanyPolicyFees.tblCompanyPolicyChargesRow companyPolicyCharge = this.dsFees.tblCompanyPolicyCharges[this.bmb.Position];
    this.rbFlat.Checked = !companyPolicyCharge.IsFlatRateNull();
    this.rbPercentage.Checked = !companyPolicyCharge.IsPercentageRateNull();
    ((UltraToggleEditorBase) this.chkExcInternational).Checked = companyPolicyCharge.ExcludeInternationalPremiums && this.rbPercentage.Checked;
    if (companyPolicyCharge.Payable)
      this.rbPayable.Checked = true;
    else if (!companyPolicyCharge.IsPayableEntityGuidNull())
      this.rbPayableTo.Checked = true;
    else
      this.rbNotPayable.Checked = true;
    this.SetDollarRounding(this.dsFees.tblCompanyPolicyCharges[this.bmb.Position]);
    this.lnkSLConfig.Visible = this._showSurplusLines && companyPolicyCharge.RowState != DataRowState.Added && this.dsFees.tblFin_PolicyCharges.Select($"SurplusLinesTax = 1 AND ChargeCode = {companyPolicyCharge.ChargeCode}").Length > 0;
  }

  private void DisableControls(bool enabled)
  {
    if (this.FeeApplied() && this._isEditing)
    {
      ((Control) this.cboFee).Enabled = false;
      ((Control) this.cboCompanyLocations).Enabled = false;
      ((Control) this.cboLines).Enabled = false;
      ((Control) this.cboStates).Enabled = false;
      ((Control) this.cboLicenseTypes).Enabled = false;
      this.Panel1.Enabled = false;
      ((Control) this.cboFeeComm).Enabled = false;
      ((Control) this.cboOffices).Enabled = false;
      this.rbPayable.Enabled = false;
      this.rbNotPayable.Enabled = false;
      this.rbPayableTo.Enabled = false;
      this.lnkSelectPayableEntity.Enabled = false;
    }
    else
      this.SetControlState(enabled);
  }

  private void SetControlState(bool enabled)
  {
    ((Control) this.cboFee).Enabled = enabled;
    enabled = this._enableDropDowns && enabled;
    ((Control) this.cboCompanyLocations).Enabled = enabled;
    ((Control) this.cboLines).Enabled = enabled;
    ((Control) this.cboStates).Enabled = enabled;
    ((Control) this.cboLicenseTypes).Enabled = enabled;
  }

  private void SetTabPagesEnabledState(bool enabled)
  {
    foreach (UltraTab tab in ((UltraTabControlBase) this.tabControl).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
        {
          if (control != this.dbSave && control != this.cboCompanyLocations && control != this.cboLines && control != this.cboStates && control != this.cboLicenseTypes && control != this.cboFee)
            control.Enabled = enabled;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this.DisableControls(enabled);
    this.lnkCopyFees.Enabled = !this._companyLineGuid.Equals(Guid.Empty);
  }

  private bool NoItemSelected(MGASimpleComboBox cbo)
  {
    return ((Control) cbo).Enabled && (((UltraDropDownBase) cbo).SelectedRow == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraDropDownBase) cbo).SelectedRow.Cells[((UltraDropDownBase) cbo).DisplayMember].Value.ToString(), string.Empty, false) == 0);
  }

  private bool IsSecuritySufficient()
  {
    bool flag;
    if (!SecurityManager.Instance.AssertPermission("{25F2A8F1-8DD5-422d-8B72-9E13D3DE73E1}"))
    {
      int num = (int) MessageBox.Show("You do not have sufficient security to change / edit company policy fees.", "Insufficient Security to Edit / Change Fees", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private bool ValidForm()
  {
    bool flag1 = true;
    this.err.SetError((Control) this.cboFeeComm, string.Empty);
    this.err.SetError((Control) this.cboFee, string.Empty);
    this.err.SetError((Control) this.cboInstallmentBilling, string.Empty);
    this.err.SetError((Control) this.dtEffective, string.Empty);
    this.err.SetError((Control) this.txtFlatFee, string.Empty);
    this.err.SetError((Control) this.txtPercentage, string.Empty);
    this.err.SetError((Control) this.numMaxStrat, string.Empty);
    this.err.SetError((Control) this.numMinStrat, string.Empty);
    this.err.SetError((Control) this.txtFullyEarnedDays, string.Empty);
    this.err.SetError((Control) this.chkExcludeFiling, string.Empty);
    this.err.SetError((Control) this.rbNotPayable, string.Empty);
    this.err.SetError((Control) this.rbNotPayable, string.Empty);
    this.err.SetError((Control) this.txtPremiumLess, string.Empty);
    this.err.SetError((Control) this.chkFeeBasedOnNumberOfLocations, string.Empty);
    this.err.SetError((Control) this.chkFeeBasedOnNumberVehicles, string.Empty);
    if (this.NoItemSelected(this.cboFeeComm))
    {
      this.err.SetError((Control) this.cboFeeComm, "Please select a fee commission type.");
      flag1 = false;
    }
    if (this.NoItemSelected(this.cboFee))
    {
      this.err.SetError((Control) this.cboFee, "Please select a fee.");
      flag1 = false;
    }
    if (this.NoItemSelected(this.cboInstallmentBilling))
    {
      this.err.SetError((Control) this.cboInstallmentBilling, "Please select an installment billing setup.");
      flag1 = false;
    }
    if (!Information.IsDate(RuntimeHelpers.GetObjectValue(this.dtEffective.Value)))
    {
      this.err.SetError((Control) this.dtEffective, "Please select an effective date for this fee.");
      flag1 = false;
    }
    if (!Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtPercentage).Text) && !Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtFlatFee).Text))
    {
      this.err.SetError((Control) this.txtFlatFee, "Please enter a value for this fee.");
      flag1 = false;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtFlatFee).Text, string.Empty, false) != 0 && !Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtFlatFee).Text))
      this.err.SetError((Control) this.txtFlatFee, "Invalid amount.");
    if (flag1 && !string.IsNullOrEmpty(((TextEditorControlBase) this.txtFlatFee).Text) && Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtFlatFee).Text) && Decimal.Compare(Conversions.ToDecimal(((TextEditorControlBase) this.txtFlatFee).Text), 99999.99M) > 0)
    {
      this.err.SetError((Control) this.txtFlatFee, "Flat Fee is greater than maximum value, 99,999.99");
      flag1 = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtPercentage).Text, string.Empty, false) != 0 && !Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtPercentage).Text))
    {
      this.err.SetError((Control) this.txtPercentage, "Invalid amount.");
      flag1 = false;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtPercentage).Text, string.Empty, false) != 0 && Decimal.Compare(Conversions.ToDecimal(((TextEditorControlBase) this.txtPercentage).Text), 1M) > 0)
    {
      this.err.SetError((Control) this.txtPercentage, "Please enter a number between 0 and 1.");
      flag1 = false;
    }
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.numMaxStrat).Text) && !Versioned.IsNumeric((object) ((TextEditorControlBase) this.numMaxStrat).Text))
    {
      this.err.SetError((Control) this.numMaxStrat, "Please enter a valid numeric value");
      flag1 = false;
    }
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.numMinStrat).Text) && !Versioned.IsNumeric((object) ((TextEditorControlBase) this.numMinStrat).Text))
    {
      this.err.SetError((Control) this.numMinStrat, "Please enter a valid numeric value");
      flag1 = false;
    }
    if (flag1 && this.txtFullyEarnedDays.Value != DBNull.Value && this.txtFullyEarnedDays.Value != null && Conversions.ToInteger(this.txtFullyEarnedDays.Value) > 365)
    {
      this.err.SetError((Control) this.txtFullyEarnedDays, "# days fully earned is not supposed to be greater than 365");
      flag1 = false;
    }
    if (((UltraToggleEditorBase) this.chkFeeBasedOnNumberOfLocations).Checked && ((UltraToggleEditorBase) this.chkFeeBasedOnNumberVehicles).Checked)
    {
      this.err.SetError((Control) this.chkFeeBasedOnNumberOfLocations, "Both # of locations and vehicles cannot be checked.");
      this.err.SetError((Control) this.chkFeeBasedOnNumberVehicles, "Both # of locations and vehicles cannot be checked.");
      flag1 = false;
    }
    bool flag2;
    if (!flag1)
    {
      ((UltraTabControlBase) this.tabControl).SelectedTab = ((UltraTabControlBase) this.tabControl).Tabs["tabFeeInfo"];
      flag2 = false;
    }
    else
    {
      if (!this.NoItemSelected(this.cboFee) && this.dsFees.tblFin_PolicyCharges.FindByChargeCode(Conversions.ToInteger(this.cboFee.Value)).IsStateIDNull() && ((UltraToggleEditorBase) this.chkExcludeFiling).Checked)
      {
        this.err.SetError((Control) this.chkExcludeFiling, "Can not exclude from filing when fee is not state-specific.");
        flag1 = false;
      }
      if (!flag1)
      {
        ((UltraTabControlBase) this.tabControl).SelectedTab = ((UltraTabControlBase) this.tabControl).Tabs["tabExclusions"];
        flag2 = false;
      }
      else
      {
        if (!this.rbNotPayable.Checked && !this.rbPayable.Checked && !this.rbPayableTo.Checked)
        {
          this.err.SetError((Control) this.rbNotPayable, "Please select a payable status for this fee.");
          flag1 = false;
        }
        if (((TextEditorControlBase) this.lblPayableTo).Text.Length > 0 && Conversions.ToInteger(this.cboFeeComm.Value) == 2)
        {
          this.err.SetError((Control) this.lblPayableTo, "Internally-commissionable fees can not be payable to a third party.");
          flag1 = false;
        }
        if (!flag1)
          ((UltraTabControlBase) this.tabControl).SelectedTab = ((UltraTabControlBase) this.tabControl).Tabs["tabPayable"];
        if (((TextEditorControlBase) this.txtPremiumGreater).Text.Length > 0 && ((TextEditorControlBase) this.txtPremiumGreater).Text.Replace(" ", string.Empty).Length > 0 && ((TextEditorControlBase) this.txtPremiumLess).Text.Length > 0 && ((TextEditorControlBase) this.txtPremiumLess).Text.Replace(" ", string.Empty).Length > 0 && Decimal.Compare(Conversions.ToDecimal(((TextEditorControlBase) this.txtPremiumGreater).Text), Conversions.ToDecimal(((TextEditorControlBase) this.txtPremiumLess).Text)) > 0)
        {
          this.err.SetError((Control) this.txtPremiumLess, "This value must be equal or greater than " + ((TextEditorControlBase) this.txtPremiumGreater).Text);
          flag1 = false;
          ((UltraTabControlBase) this.tabControl).SelectedTab = ((UltraTabControlBase) this.tabControl).Tabs[1];
        }
        flag2 = flag1;
      }
    }
    return flag2;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.IsSecuritySufficient())
      e.Cancel = true;
    else if (!this.ValidForm())
    {
      e.Cancel = true;
    }
    else
    {
      int companyFeeID = int.MinValue;
      bool isNewRow = this.dsFees.tblCompanyPolicyCharges[this.bmb.Position].RowState == DataRowState.Added;
      string feeInfo = this.GetFeeInfo();
      dsCompanyPolicyFees.tblCompanyPolicyChargesRow companyPolicyCharge = this.dsFees.tblCompanyPolicyCharges[this.bmb.Position];
      int num = int.MinValue;
      if (this.txtPercentageMinimum.Value != DBNull.Value && this.txtPercentageMinimum.Value != null)
        num = Conversions.ToInteger(this.txtPercentageMinimum.Value);
      if (this.txtFullyEarnedDays.Value != DBNull.Value && this.txtFullyEarnedDays.Value != null)
        companyPolicyCharge.FullyEarnedNumDays = Conversions.ToShort(this.txtFullyEarnedDays.Value);
      else
        companyPolicyCharge.SetFullyEarnedNumDaysNull();
      if (this.rbFlat.Checked)
      {
        companyPolicyCharge.SetPercentageRateNull();
        this.txtPercentageMinimum.Value = (object) DBNull.Value;
      }
      else
        companyPolicyCharge.SetFlatRateNull();
      companyPolicyCharge.ExcludeInternationalPremiums = this.rbPercentage.Checked && ((UltraToggleEditorBase) this.chkExcInternational).Checked;
      if (this.rbNotPayable.Checked)
      {
        companyPolicyCharge.SetPayableEntityGuidNull();
        companyPolicyCharge.SetPayableEntityNull();
        companyPolicyCharge.SetPayableEntityTypeNull();
        companyPolicyCharge.Payable = false;
      }
      else if (this.rbPayable.Checked)
      {
        companyPolicyCharge.SetPayableEntityGuidNull();
        companyPolicyCharge.SetPayableEntityNull();
        companyPolicyCharge.SetPayableEntityTypeNull();
        companyPolicyCharge.Payable = true;
      }
      else
        companyPolicyCharge.Payable = false;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboCompanyLocations.Text, string.Empty, false) == 0)
        companyPolicyCharge.SetCompanyLocationGuidNull();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboLines.Text, string.Empty, false) == 0)
      {
        companyPolicyCharge.SetLineGuidNull();
        companyPolicyCharge.SetLineNameNull();
      }
      else
        companyPolicyCharge.LineName = this.cboLines.Text;
      companyPolicyCharge.Description = this.cboFee.Text;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboStates.Text, string.Empty, false) == 0)
        companyPolicyCharge.SetStateIDNull();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboKentuckyCities.Text, string.Empty, false) == 0)
        companyPolicyCharge.SetKentuckyCityIDNull();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboLicenseTypes.Text, string.Empty, false) == 0)
        companyPolicyCharge.SetCompanyLicenceTypeIDNull();
      if (num != int.MinValue)
        companyPolicyCharge.Minimum = num;
      else
        companyPolicyCharge.SetMinimumNull();
      companyPolicyCharge.RoundToDollar = this.rbRoundToDollar.Checked;
      companyPolicyCharge.RoundDown = this.rbRoundDown.Checked;
      companyPolicyCharge.RoundUp = this.rbRoundUp.Checked;
      companyPolicyCharge.NoRounding = this.rbNoRounding.Checked;
      companyPolicyCharge.RoundToCent = this.rbRoundCent.Checked;
      companyPolicyCharge.RoundUpToCent = this.rbRoundUpToCent.Checked;
      if (isNewRow)
      {
        companyPolicyCharge.AddedBy = CurrentUser.Instance.UserGUID;
        companyPolicyCharge.AddedDate = DateTime.Now;
      }
      List<string> feeChangeList = new List<string>();
      try
      {
        this.bmb.EndCurrentEdit();
        if (!this.ValidForm())
        {
          e.Cancel = true;
          return;
        }
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daCompanyPolicyCharges, (DataTable) this.dsFees.tblCompanyPolicyCharges);
        companyFeeID = this.dsFees.tblCompanyPolicyCharges[this.bmb.Position].CompanyFeeID;
        this.SaveSelectedPolicyTypes(companyFeeID);
        this.ClientSave(companyFeeID);
        this.GetChanges(isNewRow, feeInfo, companyPolicyCharge, feeChangeList);
        companyPolicyCharge.AcceptChanges();
        MDIControls.Instance.StatusBarText = "Policy fee information saved.";
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        e.Cancel = true;
        ErrorHandler.HandleError(ex2);
        ProjectData.ClearProjectError();
      }
      this.LookForAndShowDisabledFees();
      if (feeChangeList.Count > 0)
      {
        Guid userGuid = CurrentUser.Instance.UserGUID;
        DateTime now = DateTime.Now;
        this.cboEditedBy.Value = (object) userGuid;
        this.dtpEdited.Value = (object) now;
        companyPolicyCharge.EditedBy = userGuid;
        companyPolicyCharge.EditedDate = now;
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblCompanyPolicyCharges SET EditedDate =@CT,EditedBy=@UG WHERE CompanyFeeID= @CompanyFeeID", new object[6]
        {
          (object) "@CT",
          (object) now,
          (object) "@UG",
          (object) userGuid,
          (object) "@CompanyFeeID",
          (object) companyFeeID
        });
        companyPolicyCharge.AcceptChanges();
      }
      this.LogChanges(feeChangeList);
    }
  }

  protected virtual void ClientSave(int companyFeeID)
  {
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    int position = this.bmb.Position;
    this.bmb.PositionChanged -= new EventHandler(this.bmb_PositionChanged);
    this.dsFees.tblCompanyPolicyCharges.RejectChanges();
    this.bmb.Position = 0;
    this.bmb.PositionChanged += new EventHandler(this.bmb_PositionChanged);
    if (position != -1)
      this.bmb.Position = position;
    ((UltraGridBase) this.dgFees).ActiveRow = (UltraGridRow) null;
    this.dgFees.Selected.Rows.Clear();
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    if (!this.IsSecuritySufficient())
      return;
    dsCompanyPolicyFees.tblCompanyPolicyChargesRow row = this.dsFees.tblCompanyPolicyCharges.NewtblCompanyPolicyChargesRow();
    this.bmb.SuspendBinding();
    this.dsFees.tblCompanyPolicyCharges.BeginLoadData();
    if (!this._companyLineGuid.Equals(Guid.Empty))
    {
      CompanyLine companyLine = new CompanyLine(this._companyLineGuid);
      row.CompanyLocationGuid = companyLine.CompanyLocationGuid;
      row.LineGuid = companyLine.LineGuid;
      row.LineName = companyLine.LineName;
      row.StateID = companyLine.StateID;
    }
    row.Effective = DateAndTime.Now;
    row.PremiumAllocationType = "L";
    this.dsFees.tblCompanyPolicyCharges.AddtblCompanyPolicyChargesRow(row);
    this.bmb.ResumeBinding();
    this.dsFees.tblCompanyPolicyCharges.EndLoadData();
    this.bmb.Position = this.dsFees.tblCompanyPolicyCharges.Rows.Count - 1;
    this.rbNotPayable.Checked = false;
    this.rbPayable.Checked = false;
    this.rbPayableTo.Checked = false;
    this.rbNoRounding.Checked = false;
    this.rbRoundDown.Checked = false;
    this.rbRoundToDollar.Checked = false;
    this.rbRoundUp.Checked = false;
    this.rbRoundCent.Checked = false;
    this.rbRoundUpToCent.Checked = false;
    try
    {
      foreach (Control control in ((Control) this.tabFeeInfo).Controls)
      {
        if (control is ComboBox)
        {
          ((ComboBox) control).SelectedIndex = -1;
          ((ComboBox) control).SelectedIndex = -1;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.SetTabPagesEnabledState(true);
    this.SetControlState(true);
    this.ShowSelectedPolicyTypes();
  }

  private void lnkTaxable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.dsFees.tblCompanyPolicyCharges[this.bmb.Position].RowState == DataRowState.Added)
    {
      int num = (int) MessageBox.Show("Please save this fee configuration prior to setting up the taxable states.", "Save Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (this.dsFees.tblCompanyPolicyCharges[this.bmb.Position].IsStateIDNull())
    {
      using (FormSettings.ShowFormDialog(typeof (frmTaxableFees), (object) this.dsFees.tblCompanyPolicyCharges[this.bmb.Position].CompanyFeeID))
        ;
    }
    else
    {
      using (FormSettings.ShowFormDialog(typeof (frmTaxableFees), (object) this.dsFees.tblCompanyPolicyCharges[this.bmb.Position].CompanyFeeID, (object) this.dsFees.tblCompanyPolicyCharges[this.bmb.Position].StateID))
        ;
    }
  }

  private void lnkSLConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.dsFees.tblCompanyPolicyCharges[this.bmb.Position].RowState == DataRowState.Added)
    {
      int num = (int) MessageBox.Show("Please save this fee configuration prior to setting up additional SL rules.", "Save Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      dsCompanyPolicyFees.tblCompanyPolicyChargesRow companyPolicyCharge = this.dsFees.tblCompanyPolicyCharges[this.bmb.Position];
      using (FormSettings.ShowFormDialog(typeof (frmSLConfig), (object) companyPolicyCharge.CompanyFeeID, (object) companyPolicyCharge.Field<string>("StateID")))
        ;
    }
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1 || !this.IsSecuritySufficient() || !this.CanEditMandatoryChargeFees())
      e.Cancel = true;
    else
      this._isEditing = true;
  }

  private bool FeeApplied()
  {
    bool flag1;
    if (this.bmb.Position < 0)
    {
      flag1 = false;
    }
    else
    {
      bool flag2;
      if (this._feeAppliedDictionary.ContainsKey(this.dsFees.tblCompanyPolicyCharges[this.bmb.Position].CompanyFeeID))
      {
        flag2 = this._feeAppliedDictionary[this.dsFees.tblCompanyPolicyCharges[this.bmb.Position].CompanyFeeID];
      }
      else
      {
        flag2 = DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.IsFeeApplied(@CFID)", new object[2]
        {
          (object) "@CFID",
          (object) this.dsFees.tblCompanyPolicyCharges[this.bmb.Position].CompanyFeeID
        });
        this._feeAppliedDictionary.Add(this.dsFees.tblCompanyPolicyCharges[this.bmb.Position].CompanyFeeID, flag2);
      }
      flag1 = flag2;
    }
    return flag1;
  }

  private void txtFeeFilter_TextChanged(object sender, EventArgs e)
  {
    string str = string.Empty;
    if (((TextEditorControlBase) this.txtFeeFilter).Text.Replace(" ", string.Empty).Length > 0)
      str = $"Description LIKE '%{((TextEditorControlBase) this.txtFeeFilter).Text}%'";
    this.dsFees.tblCompanyPolicyCharges.DefaultView.RowFilter = str;
    this.LookForAndShowDisabledFees();
  }

  private void checkIncludeNonGlobal_CheckedChanged(object sender, EventArgs e)
  {
    this._showAll = !this._showAll;
    this.dsFees.tblCompanyPolicyCharges.Clear();
    this.FillData();
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    bool enabled = this.dbSave.UIState == UIState.Editing;
    ((Control) this.dgFees).Enabled = !enabled;
    this.SetTabPagesEnabledState(enabled);
  }

  private void SetDollarRounding(dsCompanyPolicyFees.tblCompanyPolicyChargesRow dr)
  {
    this.rbNoRounding.Checked = false;
    this.rbRoundDown.Checked = false;
    this.rbRoundToDollar.Checked = false;
    this.rbRoundUp.Checked = false;
    this.rbRoundCent.Checked = false;
    dsCompanyPolicyFees.tblCompanyPolicyChargesRow policyChargesRow = dr;
    if (policyChargesRow.NoRounding)
      this.rbNoRounding.Checked = true;
    else if (policyChargesRow.RoundDown)
      this.rbRoundDown.Checked = true;
    else if (policyChargesRow.RoundToDollar)
      this.rbRoundToDollar.Checked = true;
    else if (policyChargesRow.RoundUp)
      this.rbRoundUp.Checked = true;
    else if (policyChargesRow.RoundToCent)
      this.rbRoundCent.Checked = true;
    else if (policyChargesRow.RoundUpToCent)
      this.rbRoundUpToCent.Checked = true;
  }

  private void cboOffices_BeforeDropDown(object sender, CancelEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.cboOffices).Rows)
      row.Hidden = Conversions.ToInteger(row.Cells["StatusID"].Value) != 1;
  }

  private void FillPolicyTypes()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsFees, new string[1]
    {
      "lstPolicyTypes"
    }, CommandType.Text, "SELECT PolicyTypeID, Description FROM lstPolicyTypes ORDER BY Description");
    try
    {
      foreach (dsCompanyPolicyFees.lstPolicyTypesRow row in this.dsFees.lstPolicyTypes.Rows)
        this.lstPolicyTypeExcl.Items.Add((object) new frmAdminCompanyPolicyFees.FeePolicyType(row.PolicyTypeID, row.Description));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    object obj = (object) null;
    if (!this._companyLineGuid.Equals(Guid.Empty))
      obj = (object) this._companyLineGuid;
    this.da.SelectCommand.Parameters["@CompanyLineGuid"].Value = RuntimeHelpers.GetObjectValue(obj);
    DefaultDatabase.LoadDataSet((DataSet) this.dsFees, new string[1]
    {
      "tblCompanyPolicyChargesPolicyTypes"
    }, CommandType.Text, "SELECT CompanyFeeID, PolicyTypeID FROM dbo.tblCompanyPolicyChargesPolicyTypes WHERE (CompanyFeeID IN (SELECT CompanyFeeID FROM dbo.GetCompanyFees(@companyLineGuid))) OR (@companyLineGuid IS NULL)", new object[2]
    {
      (object) "@companyLineGuid",
      obj
    });
  }

  private void ShowSelectedPolicyTypes()
  {
    if (this.dsFees.tblCompanyPolicyCharges[this.bmb.Position].RowState == DataRowState.Deleted)
      return;
    for (int index = this.lstPolicyTypeExcl.Items.Count - 1; index >= 0; index += -1)
    {
      frmAdminCompanyPolicyFees.FeePolicyType feePolicyType = (frmAdminCompanyPolicyFees.FeePolicyType) this.lstPolicyTypeExcl.Items[index];
      dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow feeIdPolicyTypeId = this.dsFees.tblCompanyPolicyChargesPolicyTypes.FindByCompanyFeeIDPolicyTypeID(this.dsFees.tblCompanyPolicyCharges[this.bmb.Position].CompanyFeeID, feePolicyType.PolicyTypeID);
      this.lstPolicyTypeExcl.SetItemChecked(this.lstPolicyTypeExcl.FindStringExact(feePolicyType.ToString()), feeIdPolicyTypeId != null);
    }
  }

  private void SaveSelectedPolicyTypes(int companyFeeID)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblCompanyPolicyChargesPolicyTypes WHERE CompanyFeeID=@CFID", new object[2]
    {
      (object) "@CFID",
      (object) companyFeeID
    });
    DataRow[] dataRowArray = this.dsFees.tblCompanyPolicyChargesPolicyTypes.Select("CompanyFeeID=" + companyFeeID.ToString());
    int index1 = 0;
    while (index1 < dataRowArray.Length)
    {
      this.dsFees.tblCompanyPolicyChargesPolicyTypes.RemovetblCompanyPolicyChargesPolicyTypesRow((dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow) dataRowArray[index1]);
      checked { ++index1; }
    }
    int num = this.lstPolicyTypeExcl.Items.Count - 1;
    for (int index2 = 0; index2 <= num; ++index2)
    {
      if (this.lstPolicyTypeExcl.GetItemChecked(index2))
      {
        frmAdminCompanyPolicyFees.FeePolicyType feePolicyType = (frmAdminCompanyPolicyFees.FeePolicyType) this.lstPolicyTypeExcl.Items[index2];
        dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow row = this.dsFees.tblCompanyPolicyChargesPolicyTypes.NewtblCompanyPolicyChargesPolicyTypesRow();
        row.CompanyFeeID = companyFeeID;
        row.PolicyTypeID = feePolicyType.PolicyTypeID;
        this.dsFees.tblCompanyPolicyChargesPolicyTypes.AddtblCompanyPolicyChargesPolicyTypesRow(row);
      }
    }
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.dsFees.tblCompanyPolicyChargesPolicyTypes);
  }

  private void lnkCopyFees_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.dsFees.tblCompanyPolicyCharges.Count == 0)
    {
      int num = (int) MessageBox.Show("There are no fees available to copy over.", "No Fees Available", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      List<int> intList = new List<int>();
      try
      {
        foreach (dsCompanyPolicyFees.tblCompanyPolicyChargesRow row in this.dsFees.tblCompanyPolicyCharges.Rows)
          intList.Add(row.CompanyFeeID);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      using (FormSettings.ShowFormDialog(typeof (FormCopyFees), (object) this._companyLineGuid, (object) intList))
        ;
    }
  }

  private bool CanEditMandatoryChargeFees()
  {
    bool flag;
    if (((UltraToggleEditorBase) this.chkMandatoryCharge).Checked && !this._hasMandatoryChargePermission)
    {
      int num = (int) MessageBox.Show("You do not have permission to update mandatory charge fees.", "Insufficient Permission", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void Label20_Click(object sender, EventArgs e)
  {
  }

  private class FeePolicyType
  {
    private readonly int _policyTypeID;
    private readonly string _Description;

    public FeePolicyType(int policyTypeID, string description)
    {
      this._policyTypeID = policyTypeID;
      this._Description = description;
    }

    public override string ToString() => this._Description;

    public int PolicyTypeID => this._policyTypeID;

    public string Description => this._Description;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmCompanyInstallments
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
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
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

[SecureResource("{E2E48817-AB10-480E-B4C3-788D4107602D}", "Installment Billing Options", "Controls the ability to assign installment options to a specific company/line setup.", "Company")]
public class frmCompanyInstallments : Form
{
  private IContainer components;
  private CurrencyLabel CurrencyLabel2;
  private Label Label1;
  private MGATextBox txtName;
  private Label Label2;
  private Label Label4;
  private CurrencyLabel CurrencyLabel1;
  private Label Label5;
  private CurrencyLabel CurrencyLabel3;
  private Label Label6;
  private ErrorProvider err;
  private Label Label7;
  private MGASimpleComboBox cboDownpaymentBillingType;
  private RadioButton rbDownpaymentDateBilled;
  private RadioButton rbDownpaymentEffective;
  private RadioButton rbInstallmentDateBilled;
  private RadioButton rbInstallmentEffective;
  private CurrencyLabel CurrencyLabel4;
  private Panel Panel1;
  private MGANumericEditor numDownPaymentTerm;
  private MGANumericEditor numPayments;
  private MGANumericEditor txtInstallmentTerms;
  private readonly CompanyLine _companyLine;
  private bool _painted;
  public const string AssignInstallmentBillingOptions = "{E2E48817-AB10-480E-B4C3-788D4107602D}";

  [field: AccessedThroughProperty("GroupBox1")]
  protected virtual MGAGroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingDelete);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.UIStateChanged -= eventHandler;
        dbSave1.ClickingNew -= cancelEventHandler1;
        dbSave1.ClickingCancel -= cancelEventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler3;
        dbSave1.ClickingDelete -= cancelEventHandler4;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.UIStateChanged += eventHandler;
      dbSave2.ClickingNew += cancelEventHandler1;
      dbSave2.ClickingCancel += cancelEventHandler2;
      dbSave2.ClickingSave += cancelEventHandler3;
      dbSave2.ClickingDelete += cancelEventHandler4;
    }
  }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsCompanyInstallments ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid dg
  {
    get => this._dg;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dg_AfterRowActivate);
      UltraGrid dg1 = this._dg;
      if (dg1 != null)
        dg1.AfterRowActivate -= eventHandler;
      this._dg = value;
      UltraGrid dg2 = this._dg;
      if (dg2 == null)
        return;
      dg2.AfterRowActivate += eventHandler;
    }
  }

  private virtual MGANumericEditor numDP
  {
    get => this._numDP;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.numDP_ValueChanged);
      MGANumericEditor numDp1 = this._numDP;
      if (numDp1 != null)
        ((UltraNumericEditorBase) numDp1).ValueChanged -= eventHandler;
      this._numDP = value;
      MGANumericEditor numDp2 = this._numDP;
      if (numDp2 == null)
        return;
      ((UltraNumericEditorBase) numDp2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkFinanced")]
  protected virtual MGACheckBox chkFinanced { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkDisallow")]
  protected virtual MGACheckBox chkDisallow { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CheckBox1")]
  protected virtual MGACheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkDisabled")]
  protected virtual MGACheckBox chkDisabled { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkDateBilled")]
  private virtual MGACheckBox chkDateBilled { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpInstallment")]
  internal virtual GroupBox grpInstallment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual RadioButton rbDayOfMonth
  {
    get => this._rbDayOfMonth;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PolicyTerms_CheckedChanged);
      RadioButton rbDayOfMonth1 = this._rbDayOfMonth;
      if (rbDayOfMonth1 != null)
        rbDayOfMonth1.CheckedChanged -= eventHandler;
      this._rbDayOfMonth = value;
      RadioButton rbDayOfMonth2 = this._rbDayOfMonth;
      if (rbDayOfMonth2 == null)
        return;
      rbDayOfMonth2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbPolicyEffective
  {
    get => this._rbPolicyEffective;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PolicyTerms_CheckedChanged);
      RadioButton rbPolicyEffective1 = this._rbPolicyEffective;
      if (rbPolicyEffective1 != null)
        rbPolicyEffective1.CheckedChanged -= eventHandler;
      this._rbPolicyEffective = value;
      RadioButton rbPolicyEffective2 = this._rbPolicyEffective;
      if (rbPolicyEffective2 == null)
        return;
      rbPolicyEffective2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbEffectiveDateBilled
  {
    get => this._rbEffectiveDateBilled;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PolicyTerms_CheckedChanged);
      RadioButton effectiveDateBilled1 = this._rbEffectiveDateBilled;
      if (effectiveDateBilled1 != null)
        effectiveDateBilled1.CheckedChanged -= eventHandler;
      this._rbEffectiveDateBilled = value;
      RadioButton effectiveDateBilled2 = this._rbEffectiveDateBilled;
      if (effectiveDateBilled2 == null)
        return;
      effectiveDateBilled2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("CurrencyLabel5")]
  private virtual CurrencyLabel CurrencyLabel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numDayofMonth")]
  private virtual MGANumericEditor numDayofMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numDayOfMonthInstallmentTerm")]
  private virtual MGANumericEditor numDayOfMonthInstallmentTerm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel6")]
  private virtual CurrencyLabel CurrencyLabel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("NumPolicyEffectiveInstallmentTerm")]
  private virtual MGANumericEditor NumPolicyEffectiveInstallmentTerm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox2")]
  internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel7")]
  private virtual CurrencyLabel CurrencyLabel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkFollowingDownPayment_DayOfMonth")]
  private virtual MGACheckBox chkFollowingDownPayment_DayOfMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkFollowingDownPayment_Eff_DateBilled")]
  private virtual MGACheckBox chkFollowingDownPayment_Eff_DateBilled { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkFollowingDownPayment_Eff")]
  private virtual MGACheckBox chkFollowingDownPayment_Eff { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel9")]
  private virtual CurrencyLabel CurrencyLabel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel8")]
  private virtual CurrencyLabel CurrencyLabel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numEffectiveAltFirstInstallDays")]
  private virtual MGANumericEditor numEffectiveAltFirstInstallDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numEffDateBilledAltFirstInstallDays")]
  private virtual MGANumericEditor numEffDateBilledAltFirstInstallDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkUseMonth")]
  private virtual MGACheckBox chkUseMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numDayOfMonthAltFirstInstallDays")]
  private virtual MGANumericEditor numDayOfMonthAltFirstInstallDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel10")]
  private virtual CurrencyLabel CurrencyLabel10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkCopy
  {
    get => this._lnkCopy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopy_LinkClicked);
      LinkLabel lnkCopy1 = this._lnkCopy;
      if (lnkCopy1 != null)
        lnkCopy1.LinkClicked -= clickedEventHandler;
      this._lnkCopy = value;
      LinkLabel lnkCopy2 = this._lnkCopy;
      if (lnkCopy2 == null)
        return;
      lnkCopy2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGACheckBox chkSinglePay
  {
    get => this._chkSinglePay;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkSinglePay_CheckedChanged);
      MGACheckBox chkSinglePay1 = this._chkSinglePay;
      if (chkSinglePay1 != null)
        ((UltraToggleEditorBase) chkSinglePay1).CheckedChanged -= eventHandler;
      this._chkSinglePay = value;
      MGACheckBox chkSinglePay2 = this._chkSinglePay;
      if (chkSinglePay2 == null)
        return;
      ((UltraToggleEditorBase) chkSinglePay2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkUseEffectiveDateForBilling")]
  protected virtual MGACheckBox chkUseEffectiveDateForBilling { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel11")]
  protected virtual CurrencyLabel CurrencyLabel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numBillingDateDaysFromDueDate")]
  protected virtual MGANumericEditor numBillingDateDaysFromDueDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDownPaymentGAAP")]
  private virtual RadioButton rbDownPaymentGAAP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkUseMonthForAltFirstInstallment")]
  private virtual MGACheckBox chkUseMonthForAltFirstInstallment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox1")]
  private virtual MGACheckBox MgaCheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual RadioButton rbPolicyExpiration
  {
    get => this._rbPolicyExpiration;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PolicyTerms_CheckedChanged);
      RadioButton policyExpiration1 = this._rbPolicyExpiration;
      if (policyExpiration1 != null)
        policyExpiration1.CheckedChanged -= eventHandler;
      this._rbPolicyExpiration = value;
      RadioButton policyExpiration2 = this._rbPolicyExpiration;
      if (policyExpiration2 == null)
        return;
      policyExpiration2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("CurrencyLabel12")]
  private virtual CurrencyLabel CurrencyLabel12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("NumPolicyExpirationInstallmentTerm")]
  private virtual MGANumericEditor NumPolicyExpirationInstallmentTerm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numExpirationAltFirstInstallDays")]
  private virtual MGANumericEditor numExpirationAltFirstInstallDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CurrencyLabel13")]
  private virtual CurrencyLabel CurrencyLabel13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkFollowingDownPayment_Exp")]
  private virtual MGACheckBox chkFollowingDownPayment_Exp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDownpaymentExpiration")]
  private virtual RadioButton rbDownpaymentExpiration { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numMinimumDownPayment")]
  private virtual MGANumericEditor numMinimumDownPayment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMinimumDownPayment")]
  private virtual Label lblMinimumDownPayment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDownPaymentFromEffEndMonth")]
  private virtual RadioButton rbDownPaymentFromEffEndMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkAssignBillingTypes
  {
    get => this._lnkAssignBillingTypes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkAssignBillingTypes_LinkClicked);
      LinkLabel assignBillingTypes1 = this._lnkAssignBillingTypes;
      if (assignBillingTypes1 != null)
        assignBillingTypes1.LinkClicked -= clickedEventHandler;
      this._lnkAssignBillingTypes = value;
      LinkLabel assignBillingTypes2 = this._lnkAssignBillingTypes;
      if (assignBillingTypes2 == null)
        return;
      assignBillingTypes2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("cLabelOn")]
  private virtual CurrencyLabel cLabelOn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numDownPaymentDayofMonth")]
  private virtual MGANumericEditor numDownPaymentDayofMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cLabelDayOfMonth")]
  private virtual CurrencyLabel cLabelDayOfMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkTransDateInstallment
  {
    get => this._lnkTransDateInstallment;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkTransDateInstallment_LinkClicked);
      LinkLabel transDateInstallment1 = this._lnkTransDateInstallment;
      if (transDateInstallment1 != null)
        transDateInstallment1.LinkClicked -= clickedEventHandler;
      this._lnkTransDateInstallment = value;
      LinkLabel transDateInstallment2 = this._lnkTransDateInstallment;
      if (transDateInstallment2 == null)
        return;
      transDateInstallment2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ultraTab")]
  protected virtual UltraTabControl ultraTab { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  private virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabOptions")]
  protected virtual UltraTabPageControl tabOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabThresholds")]
  protected virtual UltraTabPageControl tabThresholds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numMinimumPremium")]
  protected virtual MGANumericEditor numMinimumPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  private virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numMaximumPremium")]
  protected virtual MGANumericEditor numMaximumPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  private virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblEffDateBilledAltFinalInstallDays")]
  private virtual CurrencyLabel lblEffDateBilledAltFinalInstallDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numDayOfMonthAltFinalInstallDays")]
  private virtual MGANumericEditor numDayOfMonthAltFinalInstallDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblEffectiveAltFinalInstallDays")]
  private virtual CurrencyLabel lblEffectiveAltFinalInstallDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblExpirationAltFinalInstallDays")]
  private virtual CurrencyLabel lblExpirationAltFinalInstallDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblDayOfMonthAltFinalInstallDays")]
  private virtual CurrencyLabel lblDayOfMonthAltFinalInstallDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numExpirationAltFinalInstallDays")]
  private virtual MGANumericEditor numExpirationAltFinalInstallDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numEffectiveAltFinalInstallDays")]
  private virtual MGANumericEditor numEffectiveAltFinalInstallDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numEffDateBilledAltFinalInstallDays")]
  private virtual MGANumericEditor numEffDateBilledAltFinalInstallDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox3")]
  internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkUseMonthFinalInstallment")]
  private virtual MGACheckBox chkUseMonthFinalInstallment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkAssignRemainderFinalInstallment")]
  private virtual MGACheckBox chkAssignRemainderFinalInstallment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpThresholds")]
  internal virtual GroupBox grpThresholds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    UltraGridBand ultraGridBand = new UltraGridBand("tblCompanyLineInstallments", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("OptionName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("DownpaymentPercentage");
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("DownpaymentTerm");
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("NumPayments");
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("InstallmentTerms");
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("DownpaymentBillingTypeID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("DownpaymentFromEffectiveDate");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("DownpaymentFromDateBilled");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("InstallmentFromEffectiveDate");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("InstallmentFromDateBilled");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Financed");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("DisallowAutomatedPrinting");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("DisallowAutomatedNOC");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Disabled");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("DateBilledEqualToDueDate");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("EffectiveDateBilled");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("PolicyEffective");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("DayOfMonth");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("DayOfMonthNumber");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("PolicyEffectiveInstallmentTerm");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("DayOfMonthInstallmentTerm");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("MonthFollowingDownPayment");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("MonthFollowingDownPayment_Eff");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("MonthFollowingDownPayment_Eff_DateBilled");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("EffectiveAltFirstInstallDays");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("EffDateBilledAltFirstInstallDays");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("UseMonth");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("DayOfMonthAltFirstInstallDays");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("SinglePay");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("BillingDateDaysFromDueDate");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("UseEffectiveDateForBilling");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("DownPaymentGAAP");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("UseMonthForAltFirstInstallment");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("DownPaymentUsingBusinessDays");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("PolicyExpiration");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("ExpirationAltFirstInstallDays");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("MonthFollowingDownPayment_Exp");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("PolicyExpirationInstallmentTerm");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("DownpaymentFromExpirationDate");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("MinimumDownPayment");
    Appearance appearance51 = new Appearance();
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("DownPaymentFromEffEndMonth");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("DownPaymentDayofMonth");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("MinimumPremium");
    Appearance appearance52 = new Appearance();
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("MaximumPremium");
    Appearance appearance53 = new Appearance();
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("EffDateBilledAltFinalInstallDays");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("EffectiveAltFinalInstallDays");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("ExpirationAltFinalInstallDays");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("DayOfMonthAltFinalInstallDays");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("UseMonthFinalInstallment");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("AssignRemainderFinalInstallment");
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance61 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCompanyInstallments));
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance62 = new Appearance();
    this.tabOptions = new UltraTabPageControl();
    this.GroupBox1 = new MGAGroupBox();
    this.chkAssignRemainderFinalInstallment = new MGACheckBox();
    this.ds = new dsCompanyInstallments();
    this.GroupBox3 = new GroupBox();
    this.chkUseMonthFinalInstallment = new MGACheckBox();
    this.lblEffDateBilledAltFinalInstallDays = new CurrencyLabel();
    this.lblEffectiveAltFinalInstallDays = new CurrencyLabel();
    this.numEffDateBilledAltFinalInstallDays = new MGANumericEditor();
    this.numEffectiveAltFinalInstallDays = new MGANumericEditor();
    this.lblExpirationAltFinalInstallDays = new CurrencyLabel();
    this.numDayOfMonthAltFinalInstallDays = new MGANumericEditor();
    this.numExpirationAltFinalInstallDays = new MGANumericEditor();
    this.lblDayOfMonthAltFinalInstallDays = new CurrencyLabel();
    this.cLabelOn = new CurrencyLabel();
    this.numDownPaymentDayofMonth = new MGANumericEditor();
    this.cLabelDayOfMonth = new CurrencyLabel();
    this.lblMinimumDownPayment = new Label();
    this.numMinimumDownPayment = new MGANumericEditor();
    this.MgaCheckBox1 = new MGACheckBox();
    this.chkUseEffectiveDateForBilling = new MGACheckBox();
    this.CurrencyLabel11 = new CurrencyLabel();
    this.numBillingDateDaysFromDueDate = new MGANumericEditor();
    this.chkSinglePay = new MGACheckBox();
    this.GroupBox2 = new GroupBox();
    this.numExpirationAltFirstInstallDays = new MGANumericEditor();
    this.CurrencyLabel13 = new CurrencyLabel();
    this.chkFollowingDownPayment_Exp = new MGACheckBox();
    this.CurrencyLabel12 = new CurrencyLabel();
    this.NumPolicyExpirationInstallmentTerm = new MGANumericEditor();
    this.Label9 = new Label();
    this.chkUseMonthForAltFirstInstallment = new MGACheckBox();
    this.numDayOfMonthAltFirstInstallDays = new MGANumericEditor();
    this.CurrencyLabel10 = new CurrencyLabel();
    this.chkUseMonth = new MGACheckBox();
    this.chkFollowingDownPayment_Eff_DateBilled = new MGACheckBox();
    this.chkFollowingDownPayment_Eff = new MGACheckBox();
    this.CurrencyLabel9 = new CurrencyLabel();
    this.chkFollowingDownPayment_DayOfMonth = new MGACheckBox();
    this.CurrencyLabel7 = new CurrencyLabel();
    this.CurrencyLabel8 = new CurrencyLabel();
    this.numEffectiveAltFirstInstallDays = new MGANumericEditor();
    this.txtInstallmentTerms = new MGANumericEditor();
    this.numDayOfMonthInstallmentTerm = new MGANumericEditor();
    this.Label6 = new Label();
    this.Label8 = new Label();
    this.numEffDateBilledAltFirstInstallDays = new MGANumericEditor();
    this.rbInstallmentEffective = new RadioButton();
    this.CurrencyLabel6 = new CurrencyLabel();
    this.rbInstallmentDateBilled = new RadioButton();
    this.NumPolicyEffectiveInstallmentTerm = new MGANumericEditor();
    this.CurrencyLabel4 = new CurrencyLabel();
    this.Label3 = new Label();
    this.numDayofMonth = new MGANumericEditor();
    this.CurrencyLabel5 = new CurrencyLabel();
    this.grpInstallment = new GroupBox();
    this.rbPolicyExpiration = new RadioButton();
    this.rbEffectiveDateBilled = new RadioButton();
    this.rbDayOfMonth = new RadioButton();
    this.rbPolicyEffective = new RadioButton();
    this.chkDateBilled = new MGACheckBox();
    this.chkDisabled = new MGACheckBox();
    this.CheckBox1 = new MGACheckBox();
    this.chkFinanced = new MGACheckBox();
    this.numPayments = new MGANumericEditor();
    this.numDownPaymentTerm = new MGANumericEditor();
    this.numDP = new MGANumericEditor();
    this.cboDownpaymentBillingType = new MGASimpleComboBox();
    this.CurrencyLabel3 = new CurrencyLabel();
    this.Label5 = new Label();
    this.CurrencyLabel1 = new CurrencyLabel();
    this.Label4 = new Label();
    this.Label2 = new Label();
    this.txtName = new MGATextBox();
    this.Label1 = new Label();
    this.CurrencyLabel2 = new CurrencyLabel();
    this.Label7 = new Label();
    this.Panel1 = new Panel();
    this.rbDownPaymentFromEffEndMonth = new RadioButton();
    this.rbDownpaymentExpiration = new RadioButton();
    this.rbDownPaymentGAAP = new RadioButton();
    this.rbDownpaymentDateBilled = new RadioButton();
    this.rbDownpaymentEffective = new RadioButton();
    this.chkDisallow = new MGACheckBox();
    this.tabThresholds = new UltraTabPageControl();
    this.grpThresholds = new GroupBox();
    this.numMinimumPremium = new MGANumericEditor();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.numMaximumPremium = new MGANumericEditor();
    this.dg = new UltraGrid();
    this.lnkTransDateInstallment = new LinkLabel();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.err = new ErrorProvider(this.components);
    this.lnkCopy = new LinkLabel();
    this.lnkAssignBillingTypes = new LinkLabel();
    this.ultraTab = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    ((Control) this.tabOptions).SuspendLayout();
    ((ISupportInitialize) this.GroupBox1).BeginInit();
    ((Control) this.GroupBox1).SuspendLayout();
    ((ISupportInitialize) this.chkAssignRemainderFinalInstallment).BeginInit();
    this.ds.BeginInit();
    this.GroupBox3.SuspendLayout();
    ((ISupportInitialize) this.chkUseMonthFinalInstallment).BeginInit();
    ((ISupportInitialize) this.numEffDateBilledAltFinalInstallDays).BeginInit();
    ((ISupportInitialize) this.numEffectiveAltFinalInstallDays).BeginInit();
    ((ISupportInitialize) this.numDayOfMonthAltFinalInstallDays).BeginInit();
    ((ISupportInitialize) this.numExpirationAltFinalInstallDays).BeginInit();
    ((ISupportInitialize) this.numDownPaymentDayofMonth).BeginInit();
    ((ISupportInitialize) this.numMinimumDownPayment).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox1).BeginInit();
    ((ISupportInitialize) this.chkUseEffectiveDateForBilling).BeginInit();
    ((ISupportInitialize) this.numBillingDateDaysFromDueDate).BeginInit();
    ((ISupportInitialize) this.chkSinglePay).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.numExpirationAltFirstInstallDays).BeginInit();
    ((ISupportInitialize) this.chkFollowingDownPayment_Exp).BeginInit();
    ((ISupportInitialize) this.NumPolicyExpirationInstallmentTerm).BeginInit();
    ((ISupportInitialize) this.chkUseMonthForAltFirstInstallment).BeginInit();
    ((ISupportInitialize) this.numDayOfMonthAltFirstInstallDays).BeginInit();
    ((ISupportInitialize) this.chkUseMonth).BeginInit();
    ((ISupportInitialize) this.chkFollowingDownPayment_Eff_DateBilled).BeginInit();
    ((ISupportInitialize) this.chkFollowingDownPayment_Eff).BeginInit();
    ((ISupportInitialize) this.chkFollowingDownPayment_DayOfMonth).BeginInit();
    ((ISupportInitialize) this.numEffectiveAltFirstInstallDays).BeginInit();
    ((ISupportInitialize) this.txtInstallmentTerms).BeginInit();
    ((ISupportInitialize) this.numDayOfMonthInstallmentTerm).BeginInit();
    ((ISupportInitialize) this.numEffDateBilledAltFirstInstallDays).BeginInit();
    ((ISupportInitialize) this.NumPolicyEffectiveInstallmentTerm).BeginInit();
    ((ISupportInitialize) this.numDayofMonth).BeginInit();
    this.grpInstallment.SuspendLayout();
    ((ISupportInitialize) this.chkDateBilled).BeginInit();
    ((ISupportInitialize) this.chkDisabled).BeginInit();
    ((ISupportInitialize) this.CheckBox1).BeginInit();
    ((ISupportInitialize) this.chkFinanced).BeginInit();
    ((ISupportInitialize) this.numPayments).BeginInit();
    ((ISupportInitialize) this.numDownPaymentTerm).BeginInit();
    ((ISupportInitialize) this.numDP).BeginInit();
    ((ISupportInitialize) this.cboDownpaymentBillingType).BeginInit();
    ((ISupportInitialize) this.txtName).BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.chkDisallow).BeginInit();
    ((Control) this.tabThresholds).SuspendLayout();
    this.grpThresholds.SuspendLayout();
    ((ISupportInitialize) this.numMinimumPremium).BeginInit();
    ((ISupportInitialize) this.numMaximumPremium).BeginInit();
    ((ISupportInitialize) this.dg).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ultraTab).BeginInit();
    ((Control) this.ultraTab).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.tabOptions).Controls.Add((Control) this.GroupBox1);
    ((Control) this.tabOptions).Location = new Point(1, 26);
    ((Control) this.tabOptions).Name = "tabOptions";
    ((Control) this.tabOptions).Size = new Size(897, 446);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.GroupBox1.Appearance = (AppearanceBase) appearance1;
    this.GroupBox1.BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance2.BackColor = Color.FromArgb(239, 247, 253);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForegroundAlpha = (Alpha) 2;
    this.GroupBox1.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.GroupBox1).Controls.Add((Control) this.chkAssignRemainderFinalInstallment);
    ((Control) this.GroupBox1).Controls.Add((Control) this.GroupBox3);
    ((Control) this.GroupBox1).Controls.Add((Control) this.cLabelOn);
    ((Control) this.GroupBox1).Controls.Add((Control) this.numDownPaymentDayofMonth);
    ((Control) this.GroupBox1).Controls.Add((Control) this.cLabelDayOfMonth);
    ((Control) this.GroupBox1).Controls.Add((Control) this.lblMinimumDownPayment);
    ((Control) this.GroupBox1).Controls.Add((Control) this.numMinimumDownPayment);
    ((Control) this.GroupBox1).Controls.Add((Control) this.MgaCheckBox1);
    ((Control) this.GroupBox1).Controls.Add((Control) this.chkUseEffectiveDateForBilling);
    ((Control) this.GroupBox1).Controls.Add((Control) this.CurrencyLabel11);
    ((Control) this.GroupBox1).Controls.Add((Control) this.numBillingDateDaysFromDueDate);
    ((Control) this.GroupBox1).Controls.Add((Control) this.chkSinglePay);
    ((Control) this.GroupBox1).Controls.Add((Control) this.GroupBox2);
    ((Control) this.GroupBox1).Controls.Add((Control) this.grpInstallment);
    ((Control) this.GroupBox1).Controls.Add((Control) this.chkDateBilled);
    ((Control) this.GroupBox1).Controls.Add((Control) this.chkDisabled);
    ((Control) this.GroupBox1).Controls.Add((Control) this.CheckBox1);
    ((Control) this.GroupBox1).Controls.Add((Control) this.chkFinanced);
    ((Control) this.GroupBox1).Controls.Add((Control) this.numPayments);
    ((Control) this.GroupBox1).Controls.Add((Control) this.numDownPaymentTerm);
    ((Control) this.GroupBox1).Controls.Add((Control) this.numDP);
    ((Control) this.GroupBox1).Controls.Add((Control) this.cboDownpaymentBillingType);
    ((Control) this.GroupBox1).Controls.Add((Control) this.CurrencyLabel3);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label5);
    ((Control) this.GroupBox1).Controls.Add((Control) this.CurrencyLabel1);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label4);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label2);
    ((Control) this.GroupBox1).Controls.Add((Control) this.txtName);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label1);
    ((Control) this.GroupBox1).Controls.Add((Control) this.CurrencyLabel2);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label7);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Panel1);
    ((Control) this.GroupBox1).Controls.Add((Control) this.chkDisallow);
    this.GroupBox1.Dock = DockStyle.Fill;
    ((Control) this.GroupBox1).Enabled = false;
    appearance3.AlphaLevel = (short) 230;
    appearance3.FontData.SizeInPoints = 10f;
    appearance3.ForeColor = Color.White;
    appearance3.ForegroundAlpha = (Alpha) 2;
    appearance3.ImageBackgroundAlpha = (Alpha) 1;
    appearance3.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.GroupBox1.HeaderAppearance = (AppearanceBase) appearance3;
    ((Control) this.GroupBox1).Location = new Point(0, 0);
    ((Control) this.GroupBox1).Name = "GroupBox1";
    ((Control) this.GroupBox1).Size = new Size(897, 446);
    ((Control) this.GroupBox1).TabIndex = 1;
    this.GroupBox1.Text = "Installment Options";
    this.GroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkAssignRemainderFinalInstallment).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkAssignRemainderFinalInstallment).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkAssignRemainderFinalInstallment).BackColorInternal = Color.Transparent;
    ((Control) this.chkAssignRemainderFinalInstallment).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallments.AssignRemainderFinalInstallment", true));
    ((UltraToggleEditorBase) this.chkAssignRemainderFinalInstallment).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkAssignRemainderFinalInstallment).Location = new Point(531, 150);
    this.chkAssignRemainderFinalInstallment.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkAssignRemainderFinalInstallment).Name = "chkAssignRemainderFinalInstallment";
    ((Control) this.chkAssignRemainderFinalInstallment).Size = new Size(225, 24);
    ((Control) this.chkAssignRemainderFinalInstallment).TabIndex = 49;
    ((UltraToggleEditorBase) this.chkAssignRemainderFinalInstallment).Text = "Assign Remainder To Final Installlment";
    ((UltraControlBase) this.chkAssignRemainderFinalInstallment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkAssignRemainderFinalInstallment).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCompanyInstallments";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.GroupBox3.Controls.Add((Control) this.chkUseMonthFinalInstallment);
    this.GroupBox3.Controls.Add((Control) this.lblEffDateBilledAltFinalInstallDays);
    this.GroupBox3.Controls.Add((Control) this.lblEffectiveAltFinalInstallDays);
    this.GroupBox3.Controls.Add((Control) this.numEffDateBilledAltFinalInstallDays);
    this.GroupBox3.Controls.Add((Control) this.numEffectiveAltFinalInstallDays);
    this.GroupBox3.Controls.Add((Control) this.lblExpirationAltFinalInstallDays);
    this.GroupBox3.Controls.Add((Control) this.numDayOfMonthAltFinalInstallDays);
    this.GroupBox3.Controls.Add((Control) this.numExpirationAltFinalInstallDays);
    this.GroupBox3.Controls.Add((Control) this.lblDayOfMonthAltFinalInstallDays);
    this.GroupBox3.Location = new Point(749, 227);
    this.GroupBox3.Name = "GroupBox3";
    this.GroupBox3.Size = new Size(123, 148);
    this.GroupBox3.TabIndex = 48 /*0x30*/;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Alt. Final Installment";
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseMonthFinalInstallment).Appearance = (AppearanceBase) appearance5;
    ((UltraToggleEditorBase) this.chkUseMonthFinalInstallment).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseMonthFinalInstallment).BackColorInternal = Color.Transparent;
    ((Control) this.chkUseMonthFinalInstallment).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallments.UseMonthFinalInstallment", true));
    ((UltraToggleEditorBase) this.chkUseMonthFinalInstallment).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseMonthFinalInstallment).Location = new Point(10, 118);
    this.chkUseMonthFinalInstallment.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkUseMonthFinalInstallment).Name = "chkUseMonthFinalInstallment";
    ((Control) this.chkUseMonthFinalInstallment).Size = new Size(82, 24);
    ((Control) this.chkUseMonthFinalInstallment).TabIndex = 40;
    ((UltraToggleEditorBase) this.chkUseMonthFinalInstallment).Text = "Use Months";
    ((UltraControlBase) this.chkUseMonthFinalInstallment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUseMonthFinalInstallment).UseOsThemes = (DefaultableBoolean) 2;
    this.lblEffDateBilledAltFinalInstallDays.AutoSize = true;
    this.lblEffDateBilledAltFinalInstallDays.BackColor = Color.Transparent;
    this.lblEffDateBilledAltFinalInstallDays.Location = new Point(3, 21);
    this.lblEffDateBilledAltFinalInstallDays.Name = "lblEffDateBilledAltFinalInstallDays";
    this.lblEffDateBilledAltFinalInstallDays.Size = new Size(46, 13);
    this.lblEffDateBilledAltFinalInstallDays.TabIndex = 41;
    this.lblEffDateBilledAltFinalInstallDays.Text = "# Days:";
    this.lblEffectiveAltFinalInstallDays.AutoSize = true;
    this.lblEffectiveAltFinalInstallDays.BackColor = Color.Transparent;
    this.lblEffectiveAltFinalInstallDays.Location = new Point(3, 47);
    this.lblEffectiveAltFinalInstallDays.Name = "lblEffectiveAltFinalInstallDays";
    this.lblEffectiveAltFinalInstallDays.Size = new Size(46, 13);
    this.lblEffectiveAltFinalInstallDays.TabIndex = 47;
    this.lblEffectiveAltFinalInstallDays.Text = "# Days:";
    appearance6.BackColorDisabled = Color.Gainsboro;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numEffDateBilledAltFinalInstallDays).Appearance = (AppearanceBase) appearance6;
    ((Control) this.numEffDateBilledAltFinalInstallDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.EffDateBilledAltFinalInstallDays", true));
    ((Control) this.numEffDateBilledAltFinalInstallDays).Location = new Point(65, 17);
    this.numEffDateBilledAltFinalInstallDays.MaskInput = "nnn";
    this.numEffDateBilledAltFinalInstallDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.numEffDateBilledAltFinalInstallDays).Name = "numEffDateBilledAltFinalInstallDays";
    this.numEffDateBilledAltFinalInstallDays.Nullable = true;
    ((Control) this.numEffDateBilledAltFinalInstallDays).Size = new Size(27, 20);
    ((Control) this.numEffDateBilledAltFinalInstallDays).TabIndex = 44;
    ((UltraControlBase) this.numEffDateBilledAltFinalInstallDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numEffDateBilledAltFinalInstallDays).UseOsThemes = (DefaultableBoolean) 2;
    appearance7.BackColorDisabled = Color.Gainsboro;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numEffectiveAltFinalInstallDays).Appearance = (AppearanceBase) appearance7;
    ((Control) this.numEffectiveAltFinalInstallDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.EffectiveAltFinalInstallDays", true));
    ((Control) this.numEffectiveAltFinalInstallDays).Location = new Point(65, 43);
    this.numEffectiveAltFinalInstallDays.MaskInput = "nnn";
    this.numEffectiveAltFinalInstallDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.numEffectiveAltFinalInstallDays).Name = "numEffectiveAltFinalInstallDays";
    this.numEffectiveAltFinalInstallDays.Nullable = true;
    ((Control) this.numEffectiveAltFinalInstallDays).Size = new Size(27, 20);
    ((Control) this.numEffectiveAltFinalInstallDays).TabIndex = 43;
    ((UltraControlBase) this.numEffectiveAltFinalInstallDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numEffectiveAltFinalInstallDays).UseOsThemes = (DefaultableBoolean) 2;
    this.lblExpirationAltFinalInstallDays.AutoSize = true;
    this.lblExpirationAltFinalInstallDays.BackColor = Color.Transparent;
    this.lblExpirationAltFinalInstallDays.Location = new Point(3, 73);
    this.lblExpirationAltFinalInstallDays.Name = "lblExpirationAltFinalInstallDays";
    this.lblExpirationAltFinalInstallDays.Size = new Size(46, 13);
    this.lblExpirationAltFinalInstallDays.TabIndex = 46;
    this.lblExpirationAltFinalInstallDays.Text = "# Days:";
    appearance8.BackColorDisabled = Color.Gainsboro;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numDayOfMonthAltFinalInstallDays).Appearance = (AppearanceBase) appearance8;
    ((Control) this.numDayOfMonthAltFinalInstallDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.DayOfMonthAltFinalInstallDays", true));
    ((Control) this.numDayOfMonthAltFinalInstallDays).Location = new Point(65, 95);
    this.numDayOfMonthAltFinalInstallDays.MaskInput = "nnn";
    this.numDayOfMonthAltFinalInstallDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.numDayOfMonthAltFinalInstallDays).Name = "numDayOfMonthAltFinalInstallDays";
    this.numDayOfMonthAltFinalInstallDays.Nullable = true;
    ((Control) this.numDayOfMonthAltFinalInstallDays).Size = new Size(27, 20);
    ((Control) this.numDayOfMonthAltFinalInstallDays).TabIndex = 12;
    ((UltraControlBase) this.numDayOfMonthAltFinalInstallDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numDayOfMonthAltFinalInstallDays).UseOsThemes = (DefaultableBoolean) 2;
    appearance9.BackColorDisabled = Color.Gainsboro;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numExpirationAltFinalInstallDays).Appearance = (AppearanceBase) appearance9;
    ((Control) this.numExpirationAltFinalInstallDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.ExpirationAltFinalInstallDays", true));
    ((Control) this.numExpirationAltFinalInstallDays).Location = new Point(65, 69);
    this.numExpirationAltFinalInstallDays.MaskInput = "nnn";
    this.numExpirationAltFinalInstallDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.numExpirationAltFinalInstallDays).Name = "numExpirationAltFinalInstallDays";
    this.numExpirationAltFinalInstallDays.Nullable = true;
    ((Control) this.numExpirationAltFinalInstallDays).Size = new Size(27, 20);
    ((Control) this.numExpirationAltFinalInstallDays).TabIndex = 42;
    ((UltraControlBase) this.numExpirationAltFinalInstallDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numExpirationAltFinalInstallDays).UseOsThemes = (DefaultableBoolean) 2;
    this.lblDayOfMonthAltFinalInstallDays.AutoSize = true;
    this.lblDayOfMonthAltFinalInstallDays.BackColor = Color.Transparent;
    this.lblDayOfMonthAltFinalInstallDays.Location = new Point(3, 99);
    this.lblDayOfMonthAltFinalInstallDays.Name = "lblDayOfMonthAltFinalInstallDays";
    this.lblDayOfMonthAltFinalInstallDays.Size = new Size(46, 13);
    this.lblDayOfMonthAltFinalInstallDays.TabIndex = 45;
    this.lblDayOfMonthAltFinalInstallDays.Text = "# Days:";
    this.cLabelOn.AutoSize = true;
    this.cLabelOn.BackColor = Color.Transparent;
    this.cLabelOn.Location = new Point(459, 75);
    this.cLabelOn.Name = "cLabelOn";
    this.cLabelOn.Size = new Size(19, 13);
    this.cLabelOn.TabIndex = 38;
    this.cLabelOn.Text = "on";
    appearance10.BackColorDisabled = Color.Gainsboro;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numDownPaymentDayofMonth).Appearance = (AppearanceBase) appearance10;
    ((Control) this.numDownPaymentDayofMonth).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.DownPaymentDayofMonth", true));
    ((Control) this.numDownPaymentDayofMonth).Location = new Point(488, 71);
    this.numDownPaymentDayofMonth.MaskInput = "nn";
    this.numDownPaymentDayofMonth.MaxValue = (object) 31 /*0x1F*/;
    this.numDownPaymentDayofMonth.MGAStyle = MGAStyles.Blue;
    this.numDownPaymentDayofMonth.MinValue = (object) 0;
    ((Control) this.numDownPaymentDayofMonth).Name = "numDownPaymentDayofMonth";
    this.numDownPaymentDayofMonth.Nullable = true;
    ((Control) this.numDownPaymentDayofMonth).Size = new Size(21, 20);
    ((Control) this.numDownPaymentDayofMonth).TabIndex = 39;
    ((UltraControlBase) this.numDownPaymentDayofMonth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numDownPaymentDayofMonth).UseOsThemes = (DefaultableBoolean) 2;
    this.cLabelDayOfMonth.AutoSize = true;
    this.cLabelDayOfMonth.BackColor = Color.Transparent;
    this.cLabelDayOfMonth.Location = new Point(519, 75);
    this.cLabelDayOfMonth.Name = "cLabelDayOfMonth";
    this.cLabelDayOfMonth.Size = new Size(94, 13);
    this.cLabelDayOfMonth.TabIndex = 40;
    this.cLabelDayOfMonth.Text = "day of the month.";
    this.lblMinimumDownPayment.AutoSize = true;
    this.lblMinimumDownPayment.BackColor = Color.Transparent;
    this.lblMinimumDownPayment.Location = new Point(220, 75);
    this.lblMinimumDownPayment.Name = "lblMinimumDownPayment";
    this.lblMinimumDownPayment.Size = new Size(123, 13);
    this.lblMinimumDownPayment.TabIndex = 37;
    this.lblMinimumDownPayment.Text = "DownPayment Minimum:";
    appearance11.BackColorDisabled = Color.Gainsboro;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numMinimumDownPayment).Appearance = (AppearanceBase) appearance11;
    ((Control) this.numMinimumDownPayment).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.MinimumDownPayment", true));
    ((Control) this.numMinimumDownPayment).Location = new Point(367, 71);
    this.numMinimumDownPayment.MaskInput = "nnnnnnn.nn";
    this.numMinimumDownPayment.MGAStyle = MGAStyles.Blue;
    this.numMinimumDownPayment.MinValue = (object) new Decimal(new int[4]);
    ((Control) this.numMinimumDownPayment).Name = "numMinimumDownPayment";
    this.numMinimumDownPayment.Nullable = true;
    this.numMinimumDownPayment.NumericType = (NumericType) 2;
    ((Control) this.numMinimumDownPayment).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.numMinimumDownPayment).TabIndex = 36;
    ((UltraControlBase) this.numMinimumDownPayment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numMinimumDownPayment).UseOsThemes = (DefaultableBoolean) 2;
    this.numMinimumDownPayment.Value = (object) null;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Appearance = (AppearanceBase) appearance12;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox1).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallments.DownPaymentUsingBusinessDays", true));
    ((UltraToggleEditorBase) this.MgaCheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox1).Location = new Point(437, 126);
    this.MgaCheckBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaCheckBox1).Name = "MgaCheckBox1";
    ((Control) this.MgaCheckBox1).Size = new Size(215, 24);
    ((Control) this.MgaCheckBox1).TabIndex = 35;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Text = "Downpayment Using Business Days";
    ((UltraControlBase) this.MgaCheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseEffectiveDateForBilling).Appearance = (AppearanceBase) appearance13;
    ((UltraToggleEditorBase) this.chkUseEffectiveDateForBilling).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseEffectiveDateForBilling).BackColorInternal = Color.Transparent;
    ((Control) this.chkUseEffectiveDateForBilling).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallments.UseEffectiveDateForBilling", true));
    ((UltraToggleEditorBase) this.chkUseEffectiveDateForBilling).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseEffectiveDateForBilling).Location = new Point(414, 409);
    this.chkUseEffectiveDateForBilling.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkUseEffectiveDateForBilling).Name = "chkUseEffectiveDateForBilling";
    ((Control) this.chkUseEffectiveDateForBilling).Size = new Size(155, 24);
    ((Control) this.chkUseEffectiveDateForBilling).TabIndex = 34;
    ((UltraToggleEditorBase) this.chkUseEffectiveDateForBilling).Text = "using policy effective day.";
    ((UltraControlBase) this.chkUseEffectiveDateForBilling).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUseEffectiveDateForBilling).UseOsThemes = (DefaultableBoolean) 2;
    this.CurrencyLabel11.AutoSize = true;
    this.CurrencyLabel11.BackColor = Color.Transparent;
    this.CurrencyLabel11.Location = new Point(258, 415);
    this.CurrencyLabel11.Name = "CurrencyLabel11";
    this.CurrencyLabel11.Size = new Size(150, 13);
    this.CurrencyLabel11.TabIndex = 33;
    this.CurrencyLabel11.Text = "days/months before due date";
    appearance14.BackColorDisabled = Color.Gainsboro;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numBillingDateDaysFromDueDate).Appearance = (AppearanceBase) appearance14;
    ((Control) this.numBillingDateDaysFromDueDate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.BillingDateDaysFromDueDate", true));
    ((Control) this.numBillingDateDaysFromDueDate).Location = new Point(200, 411);
    this.numBillingDateDaysFromDueDate.MaskInput = "-nnn";
    this.numBillingDateDaysFromDueDate.MaxValue = (object) 999;
    this.numBillingDateDaysFromDueDate.MGAStyle = MGAStyles.Blue;
    this.numBillingDateDaysFromDueDate.MinValue = (object) -999;
    ((Control) this.numBillingDateDaysFromDueDate).Name = "numBillingDateDaysFromDueDate";
    this.numBillingDateDaysFromDueDate.Nullable = true;
    ((Control) this.numBillingDateDaysFromDueDate).Size = new Size(45, 20);
    ((Control) this.numBillingDateDaysFromDueDate).TabIndex = 33;
    ((UltraWinEditorMaskedControlBase) this.numBillingDateDaysFromDueDate).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numBillingDateDaysFromDueDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numBillingDateDaysFromDueDate).UseOsThemes = (DefaultableBoolean) 2;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkSinglePay).Appearance = (AppearanceBase) appearance15;
    ((UltraToggleEditorBase) this.chkSinglePay).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkSinglePay).BackColorInternal = Color.Transparent;
    ((Control) this.chkSinglePay).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallments.SinglePay", true));
    ((UltraToggleEditorBase) this.chkSinglePay).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkSinglePay).Location = new Point(437, 150);
    this.chkSinglePay.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkSinglePay).Name = "chkSinglePay";
    ((Control) this.chkSinglePay).Size = new Size(88, 24);
    ((Control) this.chkSinglePay).TabIndex = 11;
    ((UltraToggleEditorBase) this.chkSinglePay).Text = "Single Pay";
    ((UltraControlBase) this.chkSinglePay).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkSinglePay).UseOsThemes = (DefaultableBoolean) 2;
    this.GroupBox2.Controls.Add((Control) this.numExpirationAltFirstInstallDays);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel13);
    this.GroupBox2.Controls.Add((Control) this.chkFollowingDownPayment_Exp);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel12);
    this.GroupBox2.Controls.Add((Control) this.NumPolicyExpirationInstallmentTerm);
    this.GroupBox2.Controls.Add((Control) this.Label9);
    this.GroupBox2.Controls.Add((Control) this.chkUseMonthForAltFirstInstallment);
    this.GroupBox2.Controls.Add((Control) this.numDayOfMonthAltFirstInstallDays);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel10);
    this.GroupBox2.Controls.Add((Control) this.chkUseMonth);
    this.GroupBox2.Controls.Add((Control) this.chkFollowingDownPayment_Eff_DateBilled);
    this.GroupBox2.Controls.Add((Control) this.chkFollowingDownPayment_Eff);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel9);
    this.GroupBox2.Controls.Add((Control) this.chkFollowingDownPayment_DayOfMonth);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel7);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel8);
    this.GroupBox2.Controls.Add((Control) this.numEffectiveAltFirstInstallDays);
    this.GroupBox2.Controls.Add((Control) this.txtInstallmentTerms);
    this.GroupBox2.Controls.Add((Control) this.numDayOfMonthInstallmentTerm);
    this.GroupBox2.Controls.Add((Control) this.Label6);
    this.GroupBox2.Controls.Add((Control) this.Label8);
    this.GroupBox2.Controls.Add((Control) this.numEffDateBilledAltFirstInstallDays);
    this.GroupBox2.Controls.Add((Control) this.rbInstallmentEffective);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel6);
    this.GroupBox2.Controls.Add((Control) this.rbInstallmentDateBilled);
    this.GroupBox2.Controls.Add((Control) this.NumPolicyEffectiveInstallmentTerm);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel4);
    this.GroupBox2.Controls.Add((Control) this.Label3);
    this.GroupBox2.Controls.Add((Control) this.numDayofMonth);
    this.GroupBox2.Controls.Add((Control) this.CurrencyLabel5);
    this.GroupBox2.Location = new Point(11, 227);
    this.GroupBox2.Name = "GroupBox2";
    this.GroupBox2.Size = new Size(733, 148);
    this.GroupBox2.TabIndex = 8;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Installment Term Details";
    appearance16.BackColorDisabled = Color.Gainsboro;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numExpirationAltFirstInstallDays).Appearance = (AppearanceBase) appearance16;
    ((Control) this.numExpirationAltFirstInstallDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.ExpirationAltFirstInstallDays", true));
    ((Control) this.numExpirationAltFirstInstallDays).Location = new Point(544, 69);
    this.numExpirationAltFirstInstallDays.MaskInput = "nnn";
    this.numExpirationAltFirstInstallDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.numExpirationAltFirstInstallDays).Name = "numExpirationAltFirstInstallDays";
    this.numExpirationAltFirstInstallDays.Nullable = true;
    ((Control) this.numExpirationAltFirstInstallDays).Size = new Size(27, 20);
    ((Control) this.numExpirationAltFirstInstallDays).TabIndex = 38;
    ((UltraControlBase) this.numExpirationAltFirstInstallDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numExpirationAltFirstInstallDays).UseOsThemes = (DefaultableBoolean) 2;
    this.CurrencyLabel13.AutoSize = true;
    this.CurrencyLabel13.BackColor = Color.Transparent;
    this.CurrencyLabel13.Location = new Point(577, 73);
    this.CurrencyLabel13.Name = "CurrencyLabel13";
    this.CurrencyLabel13.Size = new Size(148, 13);
    this.CurrencyLabel13.TabIndex = 39;
    this.CurrencyLabel13.Text = "alt.  days for 1st  installment.";
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Appearance = (AppearanceBase) appearance17;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).BackColorInternal = Color.Transparent;
    ((Control) this.chkFollowingDownPayment_Exp).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallments.MonthFollowingDownPayment_Exp", true));
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFollowingDownPayment_Exp).Location = new Point(404, 69);
    this.chkFollowingDownPayment_Exp.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkFollowingDownPayment_Exp).Name = "chkFollowingDownPayment_Exp";
    ((Control) this.chkFollowingDownPayment_Exp).Size = new Size((int) sbyte.MaxValue, 20);
    ((Control) this.chkFollowingDownPayment_Exp).TabIndex = 37;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Text = "Following DownPymt";
    ((UltraControlBase) this.chkFollowingDownPayment_Exp).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFollowingDownPayment_Exp).UseOsThemes = (DefaultableBoolean) 2;
    this.CurrencyLabel12.AutoSize = true;
    this.CurrencyLabel12.BackColor = Color.Transparent;
    this.CurrencyLabel12.Location = new Point(154, 73);
    this.CurrencyLabel12.Name = "CurrencyLabel12";
    this.CurrencyLabel12.Size = new Size(178, 13);
    this.CurrencyLabel12.TabIndex = 35;
    this.CurrencyLabel12.Text = "days from expiration date of policy.";
    appearance18.BackColorDisabled = Color.Gainsboro;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.NumPolicyExpirationInstallmentTerm).Appearance = (AppearanceBase) appearance18;
    ((Control) this.NumPolicyExpirationInstallmentTerm).Location = new Point(117, 69);
    this.NumPolicyExpirationInstallmentTerm.MaskInput = "nnn";
    this.NumPolicyExpirationInstallmentTerm.MGAStyle = MGAStyles.Blue;
    ((Control) this.NumPolicyExpirationInstallmentTerm).Name = "NumPolicyExpirationInstallmentTerm";
    this.NumPolicyExpirationInstallmentTerm.Nullable = true;
    ((Control) this.NumPolicyExpirationInstallmentTerm).Size = new Size(27, 20);
    ((Control) this.NumPolicyExpirationInstallmentTerm).TabIndex = 34;
    ((UltraControlBase) this.NumPolicyExpirationInstallmentTerm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.NumPolicyExpirationInstallmentTerm).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(22, 74);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(89, 13);
    this.Label9.TabIndex = 36;
    this.Label9.Text = "Policy Expiration:";
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance19.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseMonthForAltFirstInstallment).Appearance = (AppearanceBase) appearance19;
    ((UltraToggleEditorBase) this.chkUseMonthForAltFirstInstallment).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseMonthForAltFirstInstallment).BackColorInternal = Color.Transparent;
    ((Control) this.chkUseMonthForAltFirstInstallment).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallments.UseMonthForAltFirstInstallment", true));
    ((UltraToggleEditorBase) this.chkUseMonthForAltFirstInstallment).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseMonthForAltFirstInstallment).Location = new Point(403, 118);
    this.chkUseMonthForAltFirstInstallment.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkUseMonthForAltFirstInstallment).Name = "chkUseMonthForAltFirstInstallment";
    ((Control) this.chkUseMonthForAltFirstInstallment).Size = new Size(280, 24);
    ((Control) this.chkUseMonthForAltFirstInstallment).TabIndex = 33;
    ((UltraToggleEditorBase) this.chkUseMonthForAltFirstInstallment).Text = "Use Months in lieu of Days for Alt. 1st Installment";
    ((UltraControlBase) this.chkUseMonthForAltFirstInstallment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUseMonthForAltFirstInstallment).UseOsThemes = (DefaultableBoolean) 2;
    appearance20.BackColorDisabled = Color.Gainsboro;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numDayOfMonthAltFirstInstallDays).Appearance = (AppearanceBase) appearance20;
    ((Control) this.numDayOfMonthAltFirstInstallDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.DayOfMonthAltFirstInstallDays", true));
    ((Control) this.numDayOfMonthAltFirstInstallDays).Location = new Point(544, 95);
    this.numDayOfMonthAltFirstInstallDays.MaskInput = "nnn";
    this.numDayOfMonthAltFirstInstallDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.numDayOfMonthAltFirstInstallDays).Name = "numDayOfMonthAltFirstInstallDays";
    this.numDayOfMonthAltFirstInstallDays.Nullable = true;
    ((Control) this.numDayOfMonthAltFirstInstallDays).Size = new Size(27, 20);
    ((Control) this.numDayOfMonthAltFirstInstallDays).TabIndex = 18;
    ((UltraControlBase) this.numDayOfMonthAltFirstInstallDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numDayOfMonthAltFirstInstallDays).UseOsThemes = (DefaultableBoolean) 2;
    this.CurrencyLabel10.AutoSize = true;
    this.CurrencyLabel10.BackColor = Color.Transparent;
    this.CurrencyLabel10.Location = new Point(577, 99);
    this.CurrencyLabel10.Name = "CurrencyLabel10";
    this.CurrencyLabel10.Size = new Size(148, 13);
    this.CurrencyLabel10.TabIndex = 19;
    this.CurrencyLabel10.Text = "alt.  days for 1st  installment.";
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance21.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseMonth).Appearance = (AppearanceBase) appearance21;
    ((UltraToggleEditorBase) this.chkUseMonth).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseMonth).BackColorInternal = Color.Transparent;
    ((Control) this.chkUseMonth).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallments.UseMonth", true));
    ((UltraToggleEditorBase) this.chkUseMonth).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseMonth).Location = new Point(117, 121);
    this.chkUseMonth.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkUseMonth).Name = "chkUseMonth";
    ((Control) this.chkUseMonth).Size = new Size(167, 24);
    ((Control) this.chkUseMonth).TabIndex = 20;
    ((UltraToggleEditorBase) this.chkUseMonth).Text = "Use Months in lieu of Days";
    ((UltraControlBase) this.chkUseMonth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUseMonth).UseOsThemes = (DefaultableBoolean) 2;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance22.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Appearance = (AppearanceBase) appearance22;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).BackColorInternal = Color.Transparent;
    ((Control) this.chkFollowingDownPayment_Eff_DateBilled).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallments.MonthFollowingDownPayment_Eff_DateBilled", true));
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFollowingDownPayment_Eff_DateBilled).Location = new Point(404, 17);
    this.chkFollowingDownPayment_Eff_DateBilled.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkFollowingDownPayment_Eff_DateBilled).Name = "chkFollowingDownPayment_Eff_DateBilled";
    ((Control) this.chkFollowingDownPayment_Eff_DateBilled).Size = new Size((int) sbyte.MaxValue, 20);
    ((Control) this.chkFollowingDownPayment_Eff_DateBilled).TabIndex = 4;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Text = "Following DownPymt";
    ((UltraControlBase) this.chkFollowingDownPayment_Eff_DateBilled).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFollowingDownPayment_Eff_DateBilled).UseOsThemes = (DefaultableBoolean) 2;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance23.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Appearance = (AppearanceBase) appearance23;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).BackColorInternal = Color.Transparent;
    ((Control) this.chkFollowingDownPayment_Eff).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallments.MonthFollowingDownPayment_Eff", true));
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFollowingDownPayment_Eff).Location = new Point(404, 43);
    this.chkFollowingDownPayment_Eff.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkFollowingDownPayment_Eff).Name = "chkFollowingDownPayment_Eff";
    ((Control) this.chkFollowingDownPayment_Eff).Size = new Size((int) sbyte.MaxValue, 20);
    ((Control) this.chkFollowingDownPayment_Eff).TabIndex = 10;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Text = "Following DownPymt";
    ((UltraControlBase) this.chkFollowingDownPayment_Eff).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFollowingDownPayment_Eff).UseOsThemes = (DefaultableBoolean) 2;
    this.CurrencyLabel9.AutoSize = true;
    this.CurrencyLabel9.BackColor = Color.Transparent;
    this.CurrencyLabel9.Location = new Point(577, 47);
    this.CurrencyLabel9.Name = "CurrencyLabel9";
    this.CurrencyLabel9.Size = new Size(148, 13);
    this.CurrencyLabel9.TabIndex = 12;
    this.CurrencyLabel9.Text = "alt.  days for 1st  installment.";
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance24.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).Appearance = (AppearanceBase) appearance24;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).BackColorInternal = Color.Transparent;
    ((Control) this.chkFollowingDownPayment_DayOfMonth).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallments.MonthFollowingDownPayment", true));
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFollowingDownPayment_DayOfMonth).Location = new Point(404, 95);
    this.chkFollowingDownPayment_DayOfMonth.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkFollowingDownPayment_DayOfMonth).Name = "chkFollowingDownPayment_DayOfMonth";
    ((Control) this.chkFollowingDownPayment_DayOfMonth).Size = new Size((int) sbyte.MaxValue, 20);
    ((Control) this.chkFollowingDownPayment_DayOfMonth).TabIndex = 17;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).Text = "Following DownPymt";
    ((UltraControlBase) this.chkFollowingDownPayment_DayOfMonth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFollowingDownPayment_DayOfMonth).UseOsThemes = (DefaultableBoolean) 2;
    this.CurrencyLabel7.AutoSize = true;
    this.CurrencyLabel7.BackColor = Color.Transparent;
    this.CurrencyLabel7.Location = new Point(153, 47);
    this.CurrencyLabel7.Name = "CurrencyLabel7";
    this.CurrencyLabel7.Size = new Size(173, 13);
    this.CurrencyLabel7.TabIndex = 9;
    this.CurrencyLabel7.Text = "days from effective date of policy.";
    this.CurrencyLabel8.AutoSize = true;
    this.CurrencyLabel8.BackColor = Color.Transparent;
    this.CurrencyLabel8.Location = new Point(577, 21);
    this.CurrencyLabel8.Name = "CurrencyLabel8";
    this.CurrencyLabel8.Size = new Size(148, 13);
    this.CurrencyLabel8.TabIndex = 6;
    this.CurrencyLabel8.Text = "alt.  days for 1st  installment.";
    appearance25.BackColorDisabled = Color.Gainsboro;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numEffectiveAltFirstInstallDays).Appearance = (AppearanceBase) appearance25;
    ((Control) this.numEffectiveAltFirstInstallDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.EffectiveAltFirstInstallDays", true));
    ((Control) this.numEffectiveAltFirstInstallDays).Location = new Point(544, 43);
    this.numEffectiveAltFirstInstallDays.MaskInput = "nnn";
    this.numEffectiveAltFirstInstallDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.numEffectiveAltFirstInstallDays).Name = "numEffectiveAltFirstInstallDays";
    this.numEffectiveAltFirstInstallDays.Nullable = true;
    ((Control) this.numEffectiveAltFirstInstallDays).Size = new Size(27, 20);
    ((Control) this.numEffectiveAltFirstInstallDays).TabIndex = 11;
    ((UltraControlBase) this.numEffectiveAltFirstInstallDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numEffectiveAltFirstInstallDays).UseOsThemes = (DefaultableBoolean) 2;
    appearance26.BackColorDisabled = Color.Gainsboro;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtInstallmentTerms).Appearance = (AppearanceBase) appearance26;
    ((Control) this.txtInstallmentTerms).Location = new Point(117, 17);
    this.txtInstallmentTerms.MaskInput = "nnn";
    this.txtInstallmentTerms.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtInstallmentTerms).Name = "txtInstallmentTerms";
    this.txtInstallmentTerms.Nullable = true;
    ((Control) this.txtInstallmentTerms).Size = new Size(27, 20);
    ((Control) this.txtInstallmentTerms).TabIndex = 0;
    ((UltraControlBase) this.txtInstallmentTerms).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInstallmentTerms).UseOsThemes = (DefaultableBoolean) 2;
    appearance27.BackColorDisabled = Color.Gainsboro;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numDayOfMonthInstallmentTerm).Appearance = (AppearanceBase) appearance27;
    ((Control) this.numDayOfMonthInstallmentTerm).Location = new Point(117, 95);
    this.numDayOfMonthInstallmentTerm.MaskInput = "nnn";
    this.numDayOfMonthInstallmentTerm.MGAStyle = MGAStyles.Blue;
    ((Control) this.numDayOfMonthInstallmentTerm).Name = "numDayOfMonthInstallmentTerm";
    this.numDayOfMonthInstallmentTerm.Nullable = true;
    ((Control) this.numDayOfMonthInstallmentTerm).Size = new Size(27, 20);
    ((Control) this.numDayOfMonthInstallmentTerm).TabIndex = 13;
    ((UltraControlBase) this.numDayOfMonthInstallmentTerm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numDayOfMonthInstallmentTerm).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(6, 21);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(105, 13);
    this.Label6.TabIndex = 14;
    this.Label6.Text = "Effective/DateBilled:";
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(35, 99);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(76, 13);
    this.Label8.TabIndex = 32 /*0x20*/;
    this.Label8.Text = "Day of Month:";
    appearance28.BackColorDisabled = Color.Gainsboro;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numEffDateBilledAltFirstInstallDays).Appearance = (AppearanceBase) appearance28;
    ((Control) this.numEffDateBilledAltFirstInstallDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.EffDateBilledAltFirstInstallDays", true));
    ((Control) this.numEffDateBilledAltFirstInstallDays).Location = new Point(544, 17);
    this.numEffDateBilledAltFirstInstallDays.MaskInput = "nnn";
    this.numEffDateBilledAltFirstInstallDays.MGAStyle = MGAStyles.Blue;
    ((Control) this.numEffDateBilledAltFirstInstallDays).Name = "numEffDateBilledAltFirstInstallDays";
    this.numEffDateBilledAltFirstInstallDays.Nullable = true;
    ((Control) this.numEffDateBilledAltFirstInstallDays).Size = new Size(27, 20);
    ((Control) this.numEffDateBilledAltFirstInstallDays).TabIndex = 5;
    ((UltraControlBase) this.numEffDateBilledAltFirstInstallDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numEffDateBilledAltFirstInstallDays).UseOsThemes = (DefaultableBoolean) 2;
    this.rbInstallmentEffective.BackColor = Color.Transparent;
    this.rbInstallmentEffective.Location = new Point(214, 18);
    this.rbInstallmentEffective.Name = "rbInstallmentEffective";
    this.rbInstallmentEffective.Size = new Size(98, 18);
    this.rbInstallmentEffective.TabIndex = 2;
    this.rbInstallmentEffective.Text = "Effective Date";
    this.rbInstallmentEffective.UseVisualStyleBackColor = false;
    this.CurrencyLabel6.AutoSize = true;
    this.CurrencyLabel6.BackColor = Color.Transparent;
    this.CurrencyLabel6.Location = new Point(154, 99);
    this.CurrencyLabel6.Name = "CurrencyLabel6";
    this.CurrencyLabel6.Size = new Size(45, 13);
    this.CurrencyLabel6.TabIndex = 14;
    this.CurrencyLabel6.Text = "days on";
    this.rbInstallmentDateBilled.BackColor = Color.Transparent;
    this.rbInstallmentDateBilled.Location = new Point(318, 19);
    this.rbInstallmentDateBilled.Name = "rbInstallmentDateBilled";
    this.rbInstallmentDateBilled.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.rbInstallmentDateBilled.TabIndex = 3;
    this.rbInstallmentDateBilled.Text = "Date Billed";
    this.rbInstallmentDateBilled.UseVisualStyleBackColor = false;
    appearance29.BackColorDisabled = Color.Gainsboro;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.NumPolicyEffectiveInstallmentTerm).Appearance = (AppearanceBase) appearance29;
    ((Control) this.NumPolicyEffectiveInstallmentTerm).Location = new Point(117, 43);
    this.NumPolicyEffectiveInstallmentTerm.MaskInput = "nnn";
    this.NumPolicyEffectiveInstallmentTerm.MGAStyle = MGAStyles.Blue;
    ((Control) this.NumPolicyEffectiveInstallmentTerm).Name = "NumPolicyEffectiveInstallmentTerm";
    this.NumPolicyEffectiveInstallmentTerm.Nullable = true;
    ((Control) this.NumPolicyEffectiveInstallmentTerm).Size = new Size(27, 20);
    ((Control) this.NumPolicyEffectiveInstallmentTerm).TabIndex = 7;
    ((UltraControlBase) this.NumPolicyEffectiveInstallmentTerm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.NumPolicyEffectiveInstallmentTerm).UseOsThemes = (DefaultableBoolean) 2;
    this.CurrencyLabel4.AutoSize = true;
    this.CurrencyLabel4.BackColor = Color.Transparent;
    this.CurrencyLabel4.Location = new Point(153, 21);
    this.CurrencyLabel4.Name = "CurrencyLabel4";
    this.CurrencyLabel4.Size = new Size(55, 13);
    this.CurrencyLabel4.TabIndex = 1;
    this.CurrencyLabel4.Text = "days from";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(27, 47);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(84, 13);
    this.Label3.TabIndex = 29;
    this.Label3.Text = "Policy Effective:";
    appearance30.BackColorDisabled = Color.Gainsboro;
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numDayofMonth).Appearance = (AppearanceBase) appearance30;
    ((Control) this.numDayofMonth).Location = new Point(214, 95);
    this.numDayofMonth.MaskInput = "nn";
    this.numDayofMonth.MGAStyle = MGAStyles.Blue;
    ((Control) this.numDayofMonth).Name = "numDayofMonth";
    this.numDayofMonth.Nullable = true;
    ((Control) this.numDayofMonth).Size = new Size(21, 20);
    ((Control) this.numDayofMonth).TabIndex = 15;
    ((UltraControlBase) this.numDayofMonth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numDayofMonth).UseOsThemes = (DefaultableBoolean) 2;
    this.CurrencyLabel5.AutoSize = true;
    this.CurrencyLabel5.BackColor = Color.Transparent;
    this.CurrencyLabel5.Location = new Point(247, 99);
    this.CurrencyLabel5.Name = "CurrencyLabel5";
    this.CurrencyLabel5.Size = new Size(94, 13);
    this.CurrencyLabel5.TabIndex = 16 /*0x10*/;
    this.CurrencyLabel5.Text = "day of the month.";
    this.grpInstallment.Controls.Add((Control) this.rbPolicyExpiration);
    this.grpInstallment.Controls.Add((Control) this.rbEffectiveDateBilled);
    this.grpInstallment.Controls.Add((Control) this.rbDayOfMonth);
    this.grpInstallment.Controls.Add((Control) this.rbPolicyEffective);
    this.grpInstallment.Location = new Point(11, 178);
    this.grpInstallment.Name = "grpInstallment";
    this.grpInstallment.Size = new Size(602, 43);
    this.grpInstallment.TabIndex = 7;
    this.grpInstallment.TabStop = false;
    this.grpInstallment.Text = "Installment Terms";
    this.rbPolicyExpiration.BackColor = Color.Transparent;
    this.rbPolicyExpiration.Location = new Point(346, 14);
    this.rbPolicyExpiration.Name = "rbPolicyExpiration";
    this.rbPolicyExpiration.Size = new Size(112 /*0x70*/, 22);
    this.rbPolicyExpiration.TabIndex = 3;
    this.rbPolicyExpiration.Text = "Policy Expiration";
    this.rbPolicyExpiration.UseVisualStyleBackColor = false;
    this.rbEffectiveDateBilled.BackColor = Color.Transparent;
    this.rbEffectiveDateBilled.Location = new Point(38, 13);
    this.rbEffectiveDateBilled.Name = "rbEffectiveDateBilled";
    this.rbEffectiveDateBilled.Size = new Size(128 /*0x80*/, 24);
    this.rbEffectiveDateBilled.TabIndex = 0;
    this.rbEffectiveDateBilled.Text = "Effective / DateBilled";
    this.rbEffectiveDateBilled.UseVisualStyleBackColor = false;
    this.rbDayOfMonth.BackColor = Color.Transparent;
    this.rbDayOfMonth.Location = new Point(497, 13);
    this.rbDayOfMonth.Name = "rbDayOfMonth";
    this.rbDayOfMonth.Size = new Size(98, 24);
    this.rbDayOfMonth.TabIndex = 2;
    this.rbDayOfMonth.Text = "Day of Month";
    this.rbDayOfMonth.UseVisualStyleBackColor = false;
    this.rbPolicyEffective.BackColor = Color.Transparent;
    this.rbPolicyEffective.Location = new Point(205, 14);
    this.rbPolicyEffective.Name = "rbPolicyEffective";
    this.rbPolicyEffective.Size = new Size(102, 22);
    this.rbPolicyEffective.TabIndex = 1;
    this.rbPolicyEffective.Text = "Policy Effective";
    this.rbPolicyEffective.UseVisualStyleBackColor = false;
    appearance31.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance31.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDateBilled).Appearance = (AppearanceBase) appearance31;
    ((UltraToggleEditorBase) this.chkDateBilled).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDateBilled).BackColorInternal = Color.Transparent;
    ((Control) this.chkDateBilled).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallments.DateBilledEqualToDueDate", true));
    ((UltraToggleEditorBase) this.chkDateBilled).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDateBilled).Location = new Point(5, 409);
    this.chkDateBilled.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkDateBilled).Name = "chkDateBilled";
    ((Control) this.chkDateBilled).Size = new Size(189, 24);
    ((Control) this.chkDateBilled).TabIndex = 12;
    ((UltraToggleEditorBase) this.chkDateBilled).Text = "Set date billed equal to due date";
    ((UltraControlBase) this.chkDateBilled).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDateBilled).UseOsThemes = (DefaultableBoolean) 2;
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance32.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDisabled).Appearance = (AppearanceBase) appearance32;
    ((UltraToggleEditorBase) this.chkDisabled).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDisabled).BackColorInternal = Color.Transparent;
    ((Control) this.chkDisabled).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallments.Disabled", true));
    ((UltraToggleEditorBase) this.chkDisabled).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDisabled).Location = new Point(492, 381);
    this.chkDisabled.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkDisabled).Name = "chkDisabled";
    ((Control) this.chkDisabled).Size = new Size(77, 24);
    ((Control) this.chkDisabled).TabIndex = 11;
    ((UltraToggleEditorBase) this.chkDisabled).Text = "Disabled";
    ((UltraControlBase) this.chkDisabled).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDisabled).UseOsThemes = (DefaultableBoolean) 2;
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance33.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.CheckBox1).Appearance = (AppearanceBase) appearance33;
    ((UltraToggleEditorBase) this.CheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.CheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.CheckBox1).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallments.DisallowAutomatedNOC", true));
    ((UltraToggleEditorBase) this.CheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.CheckBox1).Location = new Point(5, 381);
    this.CheckBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.CheckBox1).Name = "CheckBox1";
    ((Control) this.CheckBox1).Size = new Size(240 /*0xF0*/, 24);
    ((Control) this.CheckBox1).TabIndex = 9;
    ((UltraToggleEditorBase) this.CheckBox1).Text = "Disallow Automated Notices of Cancellation";
    ((UltraControlBase) this.CheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.CheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance34.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFinanced).Appearance = (AppearanceBase) appearance34;
    ((UltraToggleEditorBase) this.chkFinanced).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFinanced).BackColorInternal = Color.Transparent;
    ((Control) this.chkFinanced).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallments.Financed", true));
    ((UltraToggleEditorBase) this.chkFinanced).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFinanced).Location = new Point(591, 381);
    this.chkFinanced.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkFinanced).Name = "chkFinanced";
    ((Control) this.chkFinanced).Size = new Size(72, 24);
    ((Control) this.chkFinanced).TabIndex = 13;
    ((UltraToggleEditorBase) this.chkFinanced).Text = "Financed";
    ((UltraControlBase) this.chkFinanced).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFinanced).UseOsThemes = (DefaultableBoolean) 2;
    appearance35.BackColorDisabled = Color.Gainsboro;
    appearance35.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numPayments).Appearance = (AppearanceBase) appearance35;
    ((Control) this.numPayments).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.NumPayments", true));
    ((Control) this.numPayments).Location = new Point(159, 147);
    this.numPayments.MaskInput = "nn";
    this.numPayments.MGAStyle = MGAStyles.Blue;
    ((Control) this.numPayments).Name = "numPayments";
    this.numPayments.Nullable = true;
    ((Control) this.numPayments).Size = new Size(64 /*0x40*/, 20);
    ((Control) this.numPayments).TabIndex = 5;
    ((UltraWinEditorMaskedControlBase) this.numPayments).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numPayments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numPayments).UseOsThemes = (DefaultableBoolean) 2;
    appearance36.BackColorDisabled = Color.Gainsboro;
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numDownPaymentTerm).Appearance = (AppearanceBase) appearance36;
    ((Control) this.numDownPaymentTerm).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.DownpaymentTerm", true));
    ((Control) this.numDownPaymentTerm).Location = new Point(159, 96 /*0x60*/);
    this.numDownPaymentTerm.MaskInput = "nnn";
    this.numDownPaymentTerm.MGAStyle = MGAStyles.Blue;
    ((Control) this.numDownPaymentTerm).Name = "numDownPaymentTerm";
    this.numDownPaymentTerm.Nullable = true;
    ((Control) this.numDownPaymentTerm).Size = new Size(51, 20);
    ((Control) this.numDownPaymentTerm).TabIndex = 2;
    ((UltraControlBase) this.numDownPaymentTerm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numDownPaymentTerm).UseOsThemes = (DefaultableBoolean) 2;
    appearance37.BackColorDisabled = Color.Gainsboro;
    appearance37.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numDP).Appearance = (AppearanceBase) appearance37;
    ((Control) this.numDP).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.DownpaymentPercentage", true));
    ((UltraNumericEditorBase) this.numDP).FormatString = "p";
    ((Control) this.numDP).Location = new Point(159, 71);
    this.numDP.MaskInput = "nnn.nnnnn";
    this.numDP.MaxValue = (object) 100;
    this.numDP.MGAStyle = MGAStyles.Blue;
    this.numDP.MinValue = (object) 0;
    ((Control) this.numDP).Name = "numDP";
    this.numDP.Nullable = true;
    this.numDP.NumericType = (NumericType) 2;
    ((Control) this.numDP).Size = new Size(51, 20);
    ((Control) this.numDP).TabIndex = 1;
    ((UltraWinEditorMaskedControlBase) this.numDP).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numDP).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numDP).UseOsThemes = (DefaultableBoolean) 2;
    this.cboDownpaymentBillingType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboDownpaymentBillingType).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.DownpaymentBillingTypeID", true));
    ((UltraGridBase) this.cboDownpaymentBillingType).DataSource = (object) this.ds.tblCompanyBillingTypes;
    ((UltraDropDownBase) this.cboDownpaymentBillingType).DisplayMember = "BillingType";
    this.cboDownpaymentBillingType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDownpaymentBillingType).Location = new Point(159, 121);
    this.cboDownpaymentBillingType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDownpaymentBillingType).Name = "cboDownpaymentBillingType";
    ((Control) this.cboDownpaymentBillingType).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.cboDownpaymentBillingType).TabIndex = 4;
    ((UltraControlBase) this.cboDownpaymentBillingType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDownpaymentBillingType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDownpaymentBillingType).ValueMember = "BillingTypeID";
    this.CurrencyLabel3.AutoSize = true;
    this.CurrencyLabel3.BackColor = Color.Transparent;
    this.CurrencyLabel3.Location = new Point(222, 100);
    this.CurrencyLabel3.Name = "CurrencyLabel3";
    this.CurrencyLabel3.Size = new Size(55, 13);
    this.CurrencyLabel3.TabIndex = 7;
    this.CurrencyLabel3.Text = "days from";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(48 /*0x30*/, 100);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(107, 13);
    this.Label5.TabIndex = 5;
    this.Label5.Text = "Downpayment Term:";
    this.CurrencyLabel1.AutoSize = true;
    this.CurrencyLabel1.BackColor = Color.Transparent;
    this.CurrencyLabel1.Font = new Font("Tahoma", 7f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.CurrencyLabel1.Location = new Point(240 /*0xF0*/, 151);
    this.CurrencyLabel1.Name = "CurrencyLabel1";
    this.CurrencyLabel1.Size = new Size(141, 12);
    this.CurrencyLabel1.TabIndex = 13;
    this.CurrencyLabel1.Text = "(excluding the downpayment)";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(65, 151);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(80 /*0x50*/, 13);
    this.Label4.TabIndex = 11;
    this.Label4.Text = "# Of Payments";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(58, 75);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(94, 13);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Downpayment %:";
    appearance38.BackColor = Color.White;
    appearance38.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance38.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtName).Appearance = (AppearanceBase) appearance38;
    ((TextEditorControlBase) this.txtName).BackColor = Color.White;
    ((Control) this.txtName).DataBindings.Add(new Binding("Text", (object) this.ds, "tblCompanyLineInstallments.OptionName", true));
    ((Control) this.txtName).Location = new Point(68, 27);
    ((TextEditorControlBase) this.txtName).MaxLength = 100;
    this.txtName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtName).Name = "txtName";
    ((Control) this.txtName).Size = new Size(529, 20);
    ((Control) this.txtName).TabIndex = 0;
    ((UltraControlBase) this.txtName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(16 /*0x10*/, 31 /*0x1F*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(38, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Name:";
    this.CurrencyLabel2.AutoSize = true;
    this.CurrencyLabel2.BackColor = Color.Transparent;
    this.CurrencyLabel2.Font = new Font("Tahoma", 7f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.CurrencyLabel2.Location = new Point(66, 53);
    this.CurrencyLabel2.Name = "CurrencyLabel2";
    this.CurrencyLabel2.Size = new Size(309, 12);
    this.CurrencyLabel2.TabIndex = 1;
    this.CurrencyLabel2.Text = "(the name as you would like it to appear for selection on the policy)";
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(16 /*0x10*/, 125);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(136, 13);
    this.Label7.TabIndex = 9;
    this.Label7.Text = "Downpayment Billing Type:";
    this.Panel1.BackColor = Color.Transparent;
    this.Panel1.Controls.Add((Control) this.rbDownPaymentFromEffEndMonth);
    this.Panel1.Controls.Add((Control) this.rbDownpaymentExpiration);
    this.Panel1.Controls.Add((Control) this.rbDownPaymentGAAP);
    this.Panel1.Controls.Add((Control) this.rbDownpaymentDateBilled);
    this.Panel1.Controls.Add((Control) this.rbDownpaymentEffective);
    this.Panel1.Location = new Point(283, 93);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(523, 27);
    this.Panel1.TabIndex = 3;
    this.rbDownPaymentFromEffEndMonth.BackColor = Color.Transparent;
    this.rbDownPaymentFromEffEndMonth.Location = new Point(369, 5);
    this.rbDownPaymentFromEffEndMonth.Name = "rbDownPaymentFromEffEndMonth";
    this.rbDownPaymentFromEffEndMonth.Size = new Size(134, 20);
    this.rbDownPaymentFromEffEndMonth.TabIndex = 38;
    this.rbDownPaymentFromEffEndMonth.Text = "End Month of Eff Date";
    this.rbDownPaymentFromEffEndMonth.UseVisualStyleBackColor = false;
    this.rbDownpaymentExpiration.BackColor = Color.Transparent;
    this.rbDownpaymentExpiration.Location = new Point(264, 5);
    this.rbDownpaymentExpiration.Name = "rbDownpaymentExpiration";
    this.rbDownpaymentExpiration.Size = new Size(99, 20);
    this.rbDownpaymentExpiration.TabIndex = 3;
    this.rbDownpaymentExpiration.Text = "Expiration Date";
    this.rbDownpaymentExpiration.UseVisualStyleBackColor = false;
    this.rbDownPaymentGAAP.BackColor = Color.Transparent;
    this.rbDownPaymentGAAP.Location = new Point(198, 5);
    this.rbDownPaymentGAAP.Name = "rbDownPaymentGAAP";
    this.rbDownPaymentGAAP.Size = new Size(60, 20);
    this.rbDownPaymentGAAP.TabIndex = 2;
    this.rbDownPaymentGAAP.Text = "GAAP";
    this.rbDownPaymentGAAP.UseVisualStyleBackColor = false;
    this.rbDownpaymentDateBilled.BackColor = Color.Transparent;
    this.rbDownpaymentDateBilled.Location = new Point(112 /*0x70*/, 5);
    this.rbDownpaymentDateBilled.Name = "rbDownpaymentDateBilled";
    this.rbDownpaymentDateBilled.Size = new Size(80 /*0x50*/, 20);
    this.rbDownpaymentDateBilled.TabIndex = 1;
    this.rbDownpaymentDateBilled.Text = "Date Billed";
    this.rbDownpaymentDateBilled.UseVisualStyleBackColor = false;
    this.rbDownpaymentEffective.BackColor = Color.Transparent;
    this.rbDownpaymentEffective.Location = new Point(8, 5);
    this.rbDownpaymentEffective.Name = "rbDownpaymentEffective";
    this.rbDownpaymentEffective.Size = new Size(98, 20);
    this.rbDownpaymentEffective.TabIndex = 0;
    this.rbDownpaymentEffective.Text = "Effective Date";
    this.rbDownpaymentEffective.UseVisualStyleBackColor = false;
    appearance39.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance39.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDisallow).Appearance = (AppearanceBase) appearance39;
    ((UltraToggleEditorBase) this.chkDisallow).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDisallow).BackColorInternal = Color.Transparent;
    ((Control) this.chkDisallow).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineInstallments.DisallowAutomatedPrinting", true));
    ((UltraToggleEditorBase) this.chkDisallow).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDisallow).Location = new Point(267, 381);
    this.chkDisallow.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkDisallow).Name = "chkDisallow";
    ((Control) this.chkDisallow).Size = new Size(203, 24);
    ((Control) this.chkDisallow).TabIndex = 10;
    ((UltraToggleEditorBase) this.chkDisallow).Text = "Disallow Automated Invoice Printing";
    ((UltraControlBase) this.chkDisallow).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDisallow).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tabThresholds).Controls.Add((Control) this.grpThresholds);
    ((Control) this.tabThresholds).Location = new Point(-10000, -10000);
    ((Control) this.tabThresholds).Name = "tabThresholds";
    ((Control) this.tabThresholds).Size = new Size(897, 446);
    this.grpThresholds.BackColor = Color.Transparent;
    this.grpThresholds.Controls.Add((Control) this.numMinimumPremium);
    this.grpThresholds.Controls.Add((Control) this.Label10);
    this.grpThresholds.Controls.Add((Control) this.Label11);
    this.grpThresholds.Controls.Add((Control) this.numMaximumPremium);
    this.grpThresholds.Location = new Point(3, 13);
    this.grpThresholds.Name = "grpThresholds";
    this.grpThresholds.Size = new Size(256 /*0x0100*/, 77);
    this.grpThresholds.TabIndex = 24;
    this.grpThresholds.TabStop = false;
    this.grpThresholds.Text = "Thresholds";
    appearance40.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numMinimumPremium).Appearance = (AppearanceBase) appearance40;
    ((Control) this.numMinimumPremium).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.MinimumPremium", true));
    ((Control) this.numMinimumPremium).Location = new Point(100, 20);
    this.numMinimumPremium.MaxValue = (object) new Decimal(new int[4]
    {
      1316134911,
      2328,
      0,
      0
    });
    this.numMinimumPremium.MGAStyle = MGAStyles.Blue;
    this.numMinimumPremium.MinValue = (object) new Decimal(new int[4]
    {
      1316134911,
      2328,
      0,
      int.MinValue
    });
    ((Control) this.numMinimumPremium).Name = "numMinimumPremium";
    this.numMinimumPremium.Nullable = true;
    this.numMinimumPremium.NumericType = (NumericType) 2;
    ((Control) this.numMinimumPremium).Size = new Size(102, 20);
    ((Control) this.numMinimumPremium).TabIndex = 23;
    ((UltraControlBase) this.numMinimumPremium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numMinimumPremium).UseOsThemes = (DefaultableBoolean) 2;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(16 /*0x10*/, 50);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(64 /*0x40*/, 13);
    this.Label10.TabIndex = 20;
    this.Label10.Text = "Maximum $:";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(16 /*0x10*/, 24);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(60, 13);
    this.Label11.TabIndex = 22;
    this.Label11.Text = "Minimum $:";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    appearance41.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numMaximumPremium).Appearance = (AppearanceBase) appearance41;
    ((Control) this.numMaximumPremium).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineInstallments.MaximumPremium", true));
    ((Control) this.numMaximumPremium).Location = new Point(100, 46);
    this.numMaximumPremium.MaxValue = (object) new Decimal(new int[4]
    {
      1316134911,
      2328,
      0,
      0
    });
    this.numMaximumPremium.MGAStyle = MGAStyles.Blue;
    this.numMaximumPremium.MinValue = (object) new Decimal(new int[4]
    {
      1316134911,
      2328,
      0,
      int.MinValue
    });
    ((Control) this.numMaximumPremium).Name = "numMaximumPremium";
    this.numMaximumPremium.Nullable = true;
    this.numMaximumPremium.NumericType = (NumericType) 2;
    ((Control) this.numMaximumPremium).Size = new Size(102, 20);
    ((Control) this.numMaximumPremium).TabIndex = 21;
    ((UltraControlBase) this.numMaximumPremium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numMaximumPremium).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.dg).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dg).DataSource = (object) this.ds.tblCompanyLineInstallments;
    appearance42.BackColor = Color.White;
    appearance42.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dg).DisplayLayout.Appearance = (AppearanceBase) appearance42;
    ((UltraGridBase) this.dg).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 5;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 74;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 0;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 20;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Option";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 1;
    ultraGridColumn3.Width = 335;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance43).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance43;
    ultraGridColumn4.Format = "p";
    ((AppearanceBase) appearance44).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance44;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "DP %";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 2;
    ultraGridColumn4.Width = 118;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance45).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance45;
    ((AppearanceBase) appearance46).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance46;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "DP Term";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 3;
    ultraGridColumn5.Width = 81;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance47).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance47;
    ((AppearanceBase) appearance48).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance48;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "# Payments";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 4;
    ultraGridColumn6.Width = 87;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance49).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance49;
    ((AppearanceBase) appearance50).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance50;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Inst. Terms";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 7;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 52;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 8;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 44;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 9;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 58;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 10;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 51;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 11;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 51;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 12;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 47;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 13;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 19;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 14;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 47;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 15;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 42;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 33;
    ultraGridColumn16.Width = 48 /*0x30*/;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 119;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 65;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 18;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 52;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 19;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 46;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 20;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 69;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 21;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 107;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 22;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 101;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 23;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 81;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 24;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 114;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 25;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 150;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 26;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 91;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 27;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 105;
    ((HeaderBase) ultraGridColumn29.Header).Caption = "Use Month";
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 28;
    ultraGridColumn29.Width = 68;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 29;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 138;
    ((HeaderBase) ultraGridColumn31.Header).Caption = "Single Pay";
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 30;
    ultraGridColumn31.Width = 72;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 134;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 32 /*0x20*/;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn33.Width = 104;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 34;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn34.Width = 101;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 35;
    ultraGridColumn35.Hidden = true;
    ultraGridColumn35.Width = 141;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 36;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn36.Width = 147;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 37;
    ultraGridColumn37.Hidden = true;
    ultraGridColumn37.Width = 56;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 38;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 111;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 39;
    ultraGridColumn39.Hidden = true;
    ultraGridColumn39.Width = 192 /*0xC0*/;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 40;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 143;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 41;
    ultraGridColumn41.Hidden = true;
    ultraGridColumn41.Width = 150;
    ((AppearanceBase) appearance51).TextHAlignAsString = "Right";
    ultraGridColumn42.CellAppearance = (AppearanceBase) appearance51;
    ultraGridColumn42.Format = "c";
    ((HeaderBase) ultraGridColumn42.Header).Caption = "Min DP";
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 6;
    ultraGridColumn42.Width = 88;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 42;
    ultraGridColumn43.Hidden = true;
    ultraGridColumn43.Width = 148;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 43;
    ultraGridColumn44.Hidden = true;
    ultraGridColumn44.Width = 126;
    ((AppearanceBase) appearance52).TextHAlignAsString = "Right";
    ultraGridColumn45.CellAppearance = (AppearanceBase) appearance52;
    ((HeaderBase) ultraGridColumn45.Header).Caption = "Min Premium$";
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 44;
    ultraGridColumn45.Hidden = true;
    ultraGridColumn45.Width = 86;
    ((AppearanceBase) appearance53).TextHAlignAsString = "Right";
    ultraGridColumn46.CellAppearance = (AppearanceBase) appearance53;
    ((HeaderBase) ultraGridColumn46.Header).Caption = "Max Premium$";
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 45;
    ultraGridColumn46.Hidden = true;
    ultraGridColumn46.Width = 97;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 46;
    ultraGridColumn47.Hidden = true;
    ultraGridColumn47.Width = 100;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 47;
    ultraGridColumn48.Hidden = true;
    ultraGridColumn48.Width = 128 /*0x80*/;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 48 /*0x30*/;
    ultraGridColumn49.Hidden = true;
    ultraGridColumn49.Width = 117;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 49;
    ultraGridColumn50.Hidden = true;
    ultraGridColumn50.Width = 111;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 50;
    ultraGridColumn51.Hidden = true;
    ultraGridColumn51.Width = 125;
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 51;
    ultraGridColumn52.Hidden = true;
    ultraGridColumn52.Width = 151;
    ultraGridBand.Columns.AddRange(new object[52]
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
      (object) ultraGridColumn52
    });
    ((UltraGridBase) this.dg).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dg).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance54.BackColor = Color.LightSteelBlue;
    appearance54.FontData.SizeInPoints = 10f;
    appearance54.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance54;
    appearance55.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance55.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance55.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance55;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance56.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance56;
    appearance57.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dg).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance57;
    ((UltraGridBase) this.dg).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance58.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance58;
    appearance59.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance59;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance60.BackColor = Color.Transparent;
    appearance60.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance60;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dg).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dg).Location = new Point(8, 9);
    ((Control) this.dg).Name = "dg";
    ((Control) this.dg).Size = new Size(899, 147);
    ((Control) this.dg).TabIndex = 0;
    ((Control) this.dg).Text = "Existing Installment Options";
    ((UltraControlBase) this.dg).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dg).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkTransDateInstallment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkTransDateInstallment.AutoSize = true;
    this.lnkTransDateInstallment.Location = new Point(513, 651);
    this.lnkTransDateInstallment.Name = "lnkTransDateInstallment";
    this.lnkTransDateInstallment.Size = new Size(145, 13);
    this.lnkTransDateInstallment.TabIndex = 5;
    this.lnkTransDateInstallment.TabStop = true;
    this.lnkTransDateInstallment.Text = "Transaction Date Installment";
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(738, 641);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.lnkCopy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCopy.AutoSize = true;
    this.lnkCopy.Location = new Point(5, 651);
    this.lnkCopy.Name = "lnkCopy";
    this.lnkCopy.Size = new Size(292, 13);
    this.lnkCopy.TabIndex = 3;
    this.lnkCopy.TabStop = true;
    this.lnkCopy.Text = "Copy Existing Installment Options to other Company / Lines";
    this.lnkAssignBillingTypes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAssignBillingTypes.AutoSize = true;
    this.lnkAssignBillingTypes.Location = new Point(350, 651);
    this.lnkAssignBillingTypes.Name = "lnkAssignBillingTypes";
    this.lnkAssignBillingTypes.Size = new Size(99, 13);
    this.lnkAssignBillingTypes.TabIndex = 4;
    this.lnkAssignBillingTypes.TabStop = true;
    this.lnkAssignBillingTypes.Text = "Assign Billing Types";
    ((Control) this.ultraTab).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.ultraTab).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.ultraTab).Controls.Add((Control) this.tabOptions);
    ((Control) this.ultraTab).Controls.Add((Control) this.tabThresholds);
    ((Control) this.ultraTab).Location = new Point(8, 162);
    ((Control) this.ultraTab).Name = "ultraTab";
    ((UltraTabControlBase) this.ultraTab).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.ultraTab).Size = new Size(899, 473);
    ((Control) this.ultraTab).TabIndex = 9;
    ((UltraTabControlBase) this.ultraTab).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.ultraTab).TabPadding = new Size(5, 3);
    appearance61.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance61.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance61;
    ultraTab1.Key = "tabInstallmentOptions";
    ultraTab1.TabPage = this.tabOptions;
    ultraTab1.Text = "Installment Options";
    appearance62.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance62.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance62;
    ultraTab2.Key = "tabThresholds";
    ultraTab2.TabPage = this.tabThresholds;
    ultraTab2.Text = "Thresholds";
    ((UltraTabControlBase) this.ultraTab).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraTabControlBase) this.ultraTab).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(897, 446);
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(912, 684);
    this.Controls.Add((Control) this.ultraTab);
    this.Controls.Add((Control) this.lnkTransDateInstallment);
    this.Controls.Add((Control) this.lnkAssignBillingTypes);
    this.Controls.Add((Control) this.lnkCopy);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.dg);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.MinimumSize = new Size(528, 464);
    this.Name = nameof (frmCompanyInstallments);
    this.Text = "Company/Line Installment Administration";
    ((Control) this.tabOptions).ResumeLayout(false);
    ((ISupportInitialize) this.GroupBox1).EndInit();
    ((Control) this.GroupBox1).ResumeLayout(false);
    ((Control) this.GroupBox1).PerformLayout();
    ((ISupportInitialize) this.chkAssignRemainderFinalInstallment).EndInit();
    this.ds.EndInit();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    ((ISupportInitialize) this.chkUseMonthFinalInstallment).EndInit();
    ((ISupportInitialize) this.numEffDateBilledAltFinalInstallDays).EndInit();
    ((ISupportInitialize) this.numEffectiveAltFinalInstallDays).EndInit();
    ((ISupportInitialize) this.numDayOfMonthAltFinalInstallDays).EndInit();
    ((ISupportInitialize) this.numExpirationAltFinalInstallDays).EndInit();
    ((ISupportInitialize) this.numDownPaymentDayofMonth).EndInit();
    ((ISupportInitialize) this.numMinimumDownPayment).EndInit();
    ((ISupportInitialize) this.MgaCheckBox1).EndInit();
    ((ISupportInitialize) this.chkUseEffectiveDateForBilling).EndInit();
    ((ISupportInitialize) this.numBillingDateDaysFromDueDate).EndInit();
    ((ISupportInitialize) this.chkSinglePay).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.numExpirationAltFirstInstallDays).EndInit();
    ((ISupportInitialize) this.chkFollowingDownPayment_Exp).EndInit();
    ((ISupportInitialize) this.NumPolicyExpirationInstallmentTerm).EndInit();
    ((ISupportInitialize) this.chkUseMonthForAltFirstInstallment).EndInit();
    ((ISupportInitialize) this.numDayOfMonthAltFirstInstallDays).EndInit();
    ((ISupportInitialize) this.chkUseMonth).EndInit();
    ((ISupportInitialize) this.chkFollowingDownPayment_Eff_DateBilled).EndInit();
    ((ISupportInitialize) this.chkFollowingDownPayment_Eff).EndInit();
    ((ISupportInitialize) this.chkFollowingDownPayment_DayOfMonth).EndInit();
    ((ISupportInitialize) this.numEffectiveAltFirstInstallDays).EndInit();
    ((ISupportInitialize) this.txtInstallmentTerms).EndInit();
    ((ISupportInitialize) this.numDayOfMonthInstallmentTerm).EndInit();
    ((ISupportInitialize) this.numEffDateBilledAltFirstInstallDays).EndInit();
    ((ISupportInitialize) this.NumPolicyEffectiveInstallmentTerm).EndInit();
    ((ISupportInitialize) this.numDayofMonth).EndInit();
    this.grpInstallment.ResumeLayout(false);
    ((ISupportInitialize) this.chkDateBilled).EndInit();
    ((ISupportInitialize) this.chkDisabled).EndInit();
    ((ISupportInitialize) this.CheckBox1).EndInit();
    ((ISupportInitialize) this.chkFinanced).EndInit();
    ((ISupportInitialize) this.numPayments).EndInit();
    ((ISupportInitialize) this.numDownPaymentTerm).EndInit();
    ((ISupportInitialize) this.numDP).EndInit();
    ((ISupportInitialize) this.cboDownpaymentBillingType).EndInit();
    ((ISupportInitialize) this.txtName).EndInit();
    this.Panel1.ResumeLayout(false);
    ((ISupportInitialize) this.chkDisallow).EndInit();
    ((Control) this.tabThresholds).ResumeLayout(false);
    this.grpThresholds.ResumeLayout(false);
    this.grpThresholds.PerformLayout();
    ((ISupportInitialize) this.numMinimumPremium).EndInit();
    ((ISupportInitialize) this.numMaximumPremium).EndInit();
    ((ISupportInitialize) this.dg).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ultraTab).EndInit();
    ((Control) this.ultraTab).ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected CompanyLine CompanyLine => this._companyLine;

  [EditorBrowsable(EditorBrowsableState.Never)]
  public frmCompanyInstallments()
  {
    this.Load += new EventHandler(this.frmCompanyInstallments_Load);
    this.Activated += new EventHandler(this.frmCompanyInstallments_Activated);
    this.InitializeComponent();
  }

  public frmCompanyInstallments(Guid companyLineGuid)
  {
    this.Load += new EventHandler(this.frmCompanyInstallments_Load);
    this.Activated += new EventHandler(this.frmCompanyInstallments_Activated);
    this.InitializeComponent();
    this._companyLine = new CompanyLine(companyLineGuid);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private bool ValidForm
  {
    get
    {
      bool validForm = true;
      this.err.SetError((Control) this.txtName, string.Empty);
      this.err.SetError((Control) this.cboDownpaymentBillingType, string.Empty);
      this.err.SetError((Control) this.numDP, string.Empty);
      this.err.SetError((Control) this.numDownPaymentTerm, string.Empty);
      this.err.SetError((Control) this.numPayments, string.Empty);
      this.err.SetError((Control) this.numDayofMonth, string.Empty);
      this.err.SetError((Control) this.numDayOfMonthInstallmentTerm, string.Empty);
      this.err.SetError((Control) this.NumPolicyEffectiveInstallmentTerm, string.Empty);
      this.err.SetError((Control) this.chkUseEffectiveDateForBilling, string.Empty);
      this.err.SetError((Control) this.numBillingDateDaysFromDueDate, string.Empty);
      if (!((UltraToggleEditorBase) this.chkDateBilled).Checked && ((UltraToggleEditorBase) this.chkUseEffectiveDateForBilling).Checked)
      {
        this.err.SetError((Control) this.chkUseEffectiveDateForBilling, "Required if Billed Date equals to Due Date is checked.");
        validForm = false;
      }
      if (!((UltraToggleEditorBase) this.chkDateBilled).Checked && this.numBillingDateDaysFromDueDate.Value != null && this.numBillingDateDaysFromDueDate.Value != DBNull.Value)
      {
        this.err.SetError((Control) this.numBillingDateDaysFromDueDate, "Required if Billed Date equals to Due Date is checked.");
        validForm = false;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtName).Text, string.Empty, false) == 0)
      {
        this.err.SetError((Control) this.txtName, "Please enter a name for this option.");
        validForm = false;
      }
      if (this.numPayments.Value == null || this.numPayments.Value == DBNull.Value)
      {
        validForm = false;
        this.err.SetError((Control) this.numPayments, "Please enter a value.");
      }
      int integer = this.numPayments.Value != DBNull.Value ? Conversions.ToInteger(this.numPayments.Value) : 0;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboDownpaymentBillingType.Text, string.Empty, false) == 0 && integer != 1)
      {
        this.err.SetError((Control) this.cboDownpaymentBillingType, "Please select a downpayment billing type.");
        validForm = false;
      }
      if (!this.rbDayOfMonth.Checked && !this.rbEffectiveDateBilled.Checked && !this.rbPolicyEffective.Checked && !this.rbPolicyExpiration.Checked)
      {
        validForm = false;
        int num = (int) System.Windows.Forms.MessageBox.Show("At least one installment term must be chosen.", "No Installment Term Chosen", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      if (this.numDP.Value == null || this.numDP.Value == DBNull.Value)
      {
        validForm = false;
        this.err.SetError((Control) this.numDP, "Please enter a value.");
      }
      if (this.numDownPaymentTerm.Value == null || this.numDownPaymentTerm.Value == DBNull.Value)
      {
        validForm = false;
        this.err.SetError((Control) this.numDownPaymentTerm, "Please enter a value.");
      }
      if (this.rbEffectiveDateBilled.Checked && this.txtInstallmentTerms.Value == DBNull.Value | this.txtInstallmentTerms.Value == null)
      {
        validForm = false;
        this.err.SetError((Control) this.txtInstallmentTerms, "Please enter a value.");
      }
      if (this.rbDayOfMonth.Checked)
      {
        if (this.numDayofMonth.Value == DBNull.Value || this.numDayofMonth.Value == null)
        {
          validForm = false;
          this.err.SetError((Control) this.numDayofMonth, "'Day of Month' is checked.  Please enter a value.");
        }
        if (this.numDayOfMonthInstallmentTerm.Value == DBNull.Value || this.numDayOfMonthInstallmentTerm.Value == null)
        {
          validForm = false;
          this.err.SetError((Control) this.numDayOfMonthInstallmentTerm, "'Day of Month' is checked.  Please enter a value.");
        }
      }
      if (this.rbPolicyEffective.Checked && (this.NumPolicyEffectiveInstallmentTerm.Value == DBNull.Value || this.NumPolicyEffectiveInstallmentTerm.Value == null))
      {
        validForm = false;
        this.err.SetError((Control) this.NumPolicyEffectiveInstallmentTerm, "'Policy Effective' is checked.  Please enter a value.");
      }
      if (this.rbPolicyExpiration.Checked && (this.NumPolicyExpirationInstallmentTerm.Value == DBNull.Value || this.NumPolicyExpirationInstallmentTerm.Value == null))
      {
        validForm = false;
        this.err.SetError((Control) this.NumPolicyExpirationInstallmentTerm, "'Policy Expiration' is checked.  Please enter a value.");
      }
      if (validForm && ((UltraToggleEditorBase) this.chkSinglePay).Checked && Conversions.ToInteger(this.numPayments.Value) != 1)
      {
        validForm = false;
        this.err.SetError((Control) this.numPayments, "Single Pay is selected. # Payments must be 1.");
      }
      if (validForm && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numDownPaymentTerm.Value)) && !this.rbDownpaymentEffective.Checked && !this.rbDownpaymentDateBilled.Checked && !this.rbDownpaymentExpiration.Checked && !this.rbDownPaymentGAAP.Checked && !this.rbDownPaymentFromEffEndMonth.Checked)
      {
        validForm = false;
        int num = (int) System.Windows.Forms.MessageBox.Show("At least one down payment installment term must be chosen.", "No Down Payment Installment Term Chosen", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      if (!validForm)
        ((UltraTabControlBase) this.ultraTab).SelectedTab = ((UltraTabControlBase) this.ultraTab).Tabs[0];
      return validForm;
    }
  }

  protected BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblCompanyLineInstallments.TableName];
  }

  private void frmCompanyInstallments_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.ds.tblCompanyBillingTypes.AddtblCompanyBillingTypesRow(-1, string.Empty);
    DefaultDatabase.LoadDataTable((DataTable) this.ds.tblCompanyBillingTypes, "dbo.GetCompanyBillingTypes", new object[2]
    {
      (object) "@CompanyLineGuid",
      (object) this._companyLine.CompanyLineGuid
    });
    try
    {
      ((UltraToggleEditorBase) this.chkSinglePay).CheckedChanged -= new EventHandler(this.chkSinglePay_CheckedChanged);
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblCompanyLineInstallments"
      }, CommandType.Text, "SELECT ID, CompanyLineID, OptionName, DownpaymentPercentage, DownpaymentTerm, NumPayments, InstallmentTerms, DownpaymentBillingTypeID, InstallmentFromEffectiveDate, InstallmentFromDateBilled, Financed, DownpaymentFromEffectiveDate, DownpaymentFromDateBilled,  DisallowAutomatedPrinting, DisallowAutomatedNOC, Disabled, DateBilledEqualToDueDate, EffectiveDateBilled, PolicyEffective, DayOfMonth, DayOfMonthNumber, PolicyEffectiveInstallmentTerm, DayOfMonthInstallmentTerm, MonthFollowingDownPayment, MonthFollowingDownPayment_Eff,  MonthFollowingDownPayment_Eff_DateBilled, EffectiveAltFirstInstallDays, EffDateBilledAltFirstInstallDays, UseMonth, DayOfMonthAltFirstInstallDays, SinglePay, BillingDateDaysFromDueDate, UseEffectiveDateForBilling, DownPaymentGAAP, UseMonthForAltFirstInstallment,  DownPaymentUsingBusinessDays, PolicyExpiration, ExpirationAltFirstInstallDays, MonthFollowingDownPayment_Exp, PolicyExpirationInstallmentTerm, DownpaymentFromExpirationDate, MinimumDownPayment, DownPaymentFromEffEndMonth, DownPaymentDayofMonth, MinimumPremium,  MaximumPremium,EffDateBilledAltFinalInstallDays,EffectiveAltFinalInstallDays,ExpirationAltFinalInstallDays, DayOfMonthAltFinalInstallDays, UseMonthFinalInstallment, AssignRemainderFinalInstallment  FROM  tblCompanyLineInstallments  WHERE CompanyLineID = @CompanyLineID ORDER BY OptionName", new object[2]
      {
        (object) "@CompanyLineID",
        (object) this._companyLine.CompanyLineID
      });
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      ((UltraToggleEditorBase) this.chkSinglePay).CheckedChanged += new EventHandler(this.chkSinglePay_CheckedChanged);
    }
    this.SetRadioButtons();
    this.dbSave.UIState = this.ds.tblCompanyLineInstallments.Count <= 0 ? UIState.NoRecordsNotEditing : UIState.HasRecordsNotEditing;
    ((UltraGridBase) this.dg).DisplayLayout.Bands[0].Columns["DownpaymentPercentage"].Editor.DataFilter = (IEditorDataFilter) new PercentageDataFilter();
    ((UltraGridBase) this.dg).DisplayLayout.Bands[0].Columns["DownpaymentPercentage"].MaskInput = "nnnn.nnnn\\%";
    ((Control) this.numPayments).DataBindings.Add(new Binding("ReadOnly", (object) this.chkSinglePay, "Checked", false, DataSourceUpdateMode.OnPropertyChanged));
    ((Control) this.cboDownpaymentBillingType).DataBindings.Add(new Binding("ReadOnly", (object) this.chkSinglePay, "Checked", false, DataSourceUpdateMode.OnPropertyChanged));
    this.ReOrderControls();
    this.lnkAssignBillingTypes.Visible = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ShowInstallmentBillingTypeOptions");
  }

  private void ReOrderControls()
  {
    if (!MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ReOrderCompanyLineInstallmentControls"))
      return;
    ((Control) this.dg).Size = new Size(510, 110);
    ((Control) this.GroupBox1).Location = new Point(8, 120);
    ((Control) this.GroupBox1).Size = new Size(539, 395);
    this.dbSave.Location = new Point(375, 518);
    this.Size = new Size(589, 690);
    ((UltraGridBase) this.dg).DisplayLayout.Bands[0].Columns["DownpaymentPercentage"].Width = 45;
    ((UltraGridBase) this.dg).DisplayLayout.Bands[0].Columns["DownpaymentTerm"].Width = 45;
    ((UltraGridBase) this.dg).DisplayLayout.Bands[0].Columns["NumPayments"].Width = 45;
    try
    {
      foreach (Control control in ((Control) this.GroupBox1).Controls)
      {
        if (control is MGACheckBox && control.Text.Equals("Paygo Policy"))
        {
          control.Location = new Point(327, 371);
          break;
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

  private void dg_AfterRowActivate(object sender, EventArgs e)
  {
    Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dg).ActiveRow.Cells["ID"].Value), "ID", (DataTable) this.ds.tblCompanyLineInstallments, this.bmb);
    this.SelectedInstallmentChanged(this.ds.tblCompanyLineInstallments[this.bmb.Position].ID);
    this.SetRadioButtons();
  }

  protected virtual void SelectedInstallmentChanged(int installmentID)
  {
  }

  private void SetRadioButtons()
  {
    if (this.bmb.Position < 0)
      return;
    dsCompanyInstallments.tblCompanyLineInstallmentsRow companyLineInstallment = this.ds.tblCompanyLineInstallments[this.bmb.Position];
    this.rbDownpaymentDateBilled.Checked = companyLineInstallment.DownpaymentFromDateBilled;
    this.rbDownpaymentEffective.Checked = companyLineInstallment.DownpaymentFromEffectiveDate;
    this.rbInstallmentDateBilled.Checked = companyLineInstallment.InstallmentFromDateBilled;
    this.rbInstallmentEffective.Checked = companyLineInstallment.InstallmentFromEffectiveDate;
    this.rbDownPaymentGAAP.Checked = companyLineInstallment.DownPaymentGAAP;
    this.rbDownPaymentFromEffEndMonth.Checked = companyLineInstallment.DownPaymentFromEffEndMonth;
    this.rbEffectiveDateBilled.Checked = companyLineInstallment.EffectiveDateBilled;
    this.rbPolicyEffective.Checked = companyLineInstallment.PolicyEffective;
    this.rbPolicyExpiration.Checked = companyLineInstallment.PolicyExpiration;
    this.rbDayOfMonth.Checked = companyLineInstallment.DayOfMonth;
    if (!companyLineInstallment.IsInstallmentTermsNull())
      this.txtInstallmentTerms.Value = (object) companyLineInstallment.InstallmentTerms;
    if (!companyLineInstallment.IsDayOfMonthNumberNull())
      this.numDayofMonth.Value = (object) companyLineInstallment.DayOfMonthNumber;
    if (!companyLineInstallment.IsPolicyEffectiveInstallmentTermNull())
      this.NumPolicyEffectiveInstallmentTerm.Value = (object) companyLineInstallment.PolicyEffectiveInstallmentTerm;
    if (!companyLineInstallment.IsDayOfMonthInstallmentTermNull())
      this.numDayOfMonthInstallmentTerm.Value = (object) companyLineInstallment.DayOfMonthInstallmentTerm;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).Checked = false;
    if (!companyLineInstallment.IsMonthFollowingDownPaymentNull())
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).Checked = companyLineInstallment.MonthFollowingDownPayment;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Checked = false;
    if (!companyLineInstallment.IsMonthFollowingDownPayment_EffNull())
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Checked = companyLineInstallment.MonthFollowingDownPayment_Eff;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Checked = false;
    if (!companyLineInstallment.IsMonthFollowingDownPayment_Eff_DateBilledNull())
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Checked = companyLineInstallment.MonthFollowingDownPayment_Eff_DateBilled;
    if (!companyLineInstallment.IsPolicyExpirationInstallmentTermNull())
      this.NumPolicyExpirationInstallmentTerm.Value = (object) companyLineInstallment.PolicyExpirationInstallmentTerm;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Checked = false;
    if (!companyLineInstallment.IsMonthFollowingDownPayment_ExpNull())
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Checked = companyLineInstallment.MonthFollowingDownPayment_Exp;
    this.rbDownpaymentExpiration.Checked = companyLineInstallment.DownpaymentFromExpirationDate;
    if (!companyLineInstallment.IsEffDateBilledAltFirstInstallDaysNull())
      this.numEffDateBilledAltFirstInstallDays.Value = (object) companyLineInstallment.EffDateBilledAltFirstInstallDays;
    else
      this.numEffDateBilledAltFirstInstallDays.Value = (object) null;
    if (!companyLineInstallment.IsEffectiveAltFirstInstallDaysNull())
      this.numEffectiveAltFirstInstallDays.Value = (object) companyLineInstallment.EffectiveAltFirstInstallDays;
    else
      this.numEffectiveAltFirstInstallDays.Value = (object) null;
    if (!companyLineInstallment.IsExpirationAltFirstInstallDaysNull())
      this.numExpirationAltFirstInstallDays.Value = (object) companyLineInstallment.ExpirationAltFirstInstallDays;
    else
      this.numExpirationAltFirstInstallDays.Value = (object) null;
    if (!companyLineInstallment.IsDayOfMonthAltFirstInstallDaysNull())
      this.numDayOfMonthAltFirstInstallDays.Value = (object) companyLineInstallment.DayOfMonthAltFirstInstallDays;
    else
      this.numDayOfMonthAltFirstInstallDays.Value = (object) null;
    if (!companyLineInstallment.IsEffDateBilledAltFinalInstallDaysNull())
      this.numEffDateBilledAltFinalInstallDays.Value = (object) companyLineInstallment.EffDateBilledAltFinalInstallDays;
    else
      this.numEffDateBilledAltFinalInstallDays.Value = (object) null;
    if (!companyLineInstallment.IsEffectiveAltFinalInstallDaysNull())
      this.numEffectiveAltFinalInstallDays.Value = (object) companyLineInstallment.EffectiveAltFinalInstallDays;
    else
      this.numEffectiveAltFinalInstallDays.Value = (object) null;
    if (!companyLineInstallment.IsExpirationAltFinalInstallDaysNull())
      this.numExpirationAltFinalInstallDays.Value = (object) companyLineInstallment.ExpirationAltFinalInstallDays;
    else
      this.numExpirationAltFinalInstallDays.Value = (object) null;
    if (!companyLineInstallment.IsDayOfMonthAltFinalInstallDaysNull())
      this.numDayOfMonthAltFinalInstallDays.Value = (object) companyLineInstallment.DayOfMonthAltFinalInstallDays;
    else
      this.numDayOfMonthAltFinalInstallDays.Value = (object) null;
    ((UltraToggleEditorBase) this.chkUseMonthFinalInstallment).Checked = companyLineInstallment.UseMonthFinalInstallment;
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.dg).Enabled = this.dbSave.UIState != UIState.Editing;
    ((Control) this.GroupBox1).Enabled = this.dbSave.UIState == UIState.Editing;
    this.grpThresholds.Enabled = this.dbSave.UIState == UIState.Editing;
    if (this.dbSave.UIState != UIState.Editing)
      this.dbSave.UIState = this.ds.tblCompanyLineInstallments.Count <= 0 ? UIState.NoRecordsNotEditing : UIState.HasRecordsNotEditing;
    this.lnkAssignBillingTypes.Enabled = this.dbSave.UIState != UIState.Editing;
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    dsCompanyInstallments.tblCompanyLineInstallmentsRow row = this.ds.tblCompanyLineInstallments.NewtblCompanyLineInstallmentsRow();
    row.CompanyLineID = this._companyLine.CompanyLineID;
    if (this.ds.tblCompanyBillingTypes.Count == 2)
    {
      row.DownpaymentBillingTypeID = this.ds.tblCompanyBillingTypes[1].BillingTypeID;
      this.cboDownpaymentBillingType.Value = (object) row.DownpaymentBillingTypeID;
    }
    else
      row.SetDownpaymentBillingTypeIDNull();
    this.txtInstallmentTerms.Value = (object) 30;
    this.rbEffectiveDateBilled.Checked = true;
    this.rbInstallmentEffective.Checked = true;
    row.DownpaymentPercentage = 0M;
    row.NumPayments = 1;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Checked = false;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Checked = false;
    this.ds.tblCompanyLineInstallments.AddtblCompanyLineInstallmentsRow(row);
    this.bmb.Position = this.ds.tblCompanyLineInstallments.Rows.Count - 1;
    this.ClickedNew();
  }

  protected virtual void ClickedNew()
  {
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ds.RejectChanges();
    this.SetRadioButtons();
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidForm)
    {
      e.Cancel = true;
    }
    else
    {
      try
      {
        Cursor.Current = MgaCursors.WaitCursor;
        this.bmb.EndCurrentEdit();
        dsCompanyInstallments.tblCompanyLineInstallmentsRow companyLineInstallment = this.ds.tblCompanyLineInstallments[this.bmb.Position];
        companyLineInstallment.InstallmentFromEffectiveDate = this.rbInstallmentEffective.Checked;
        companyLineInstallment.InstallmentFromDateBilled = this.rbInstallmentDateBilled.Checked;
        companyLineInstallment.DownpaymentFromEffectiveDate = this.rbDownpaymentEffective.Checked;
        companyLineInstallment.DownpaymentFromDateBilled = this.rbDownpaymentDateBilled.Checked;
        companyLineInstallment.DownPaymentGAAP = this.rbDownPaymentGAAP.Checked;
        companyLineInstallment.DownPaymentFromEffEndMonth = this.rbDownPaymentFromEffEndMonth.Checked;
        companyLineInstallment.EffectiveDateBilled = this.rbEffectiveDateBilled.Checked;
        companyLineInstallment.PolicyEffective = this.rbPolicyEffective.Checked;
        companyLineInstallment.PolicyExpiration = this.rbPolicyExpiration.Checked;
        companyLineInstallment.DayOfMonth = this.rbDayOfMonth.Checked;
        if (Decimal.Compare(companyLineInstallment.DownpaymentPercentage, 1M) > 0)
          companyLineInstallment.DownpaymentPercentage = Decimal.Divide(companyLineInstallment.DownpaymentPercentage, 100M);
        if (this.txtInstallmentTerms.Value != null && this.txtInstallmentTerms.Value != DBNull.Value)
          companyLineInstallment.InstallmentTerms = Conversions.ToInteger(this.txtInstallmentTerms.Value);
        else
          companyLineInstallment.SetInstallmentTermsNull();
        if (this.numDayofMonth.Value != null && this.numDayofMonth.Value != DBNull.Value)
          companyLineInstallment.DayOfMonthNumber = (byte) Conversions.ToInteger(this.numDayofMonth.Value);
        else
          companyLineInstallment.SetDayOfMonthNumberNull();
        if (this.numDayOfMonthInstallmentTerm.Value != null && this.numDayOfMonthInstallmentTerm.Value != DBNull.Value)
          companyLineInstallment.DayOfMonthInstallmentTerm = Conversions.ToInteger(this.numDayOfMonthInstallmentTerm.Value);
        else
          companyLineInstallment.SetDayOfMonthInstallmentTermNull();
        if (this.NumPolicyEffectiveInstallmentTerm.Value != null && this.NumPolicyEffectiveInstallmentTerm.Value != DBNull.Value)
          companyLineInstallment.PolicyEffectiveInstallmentTerm = Conversions.ToInteger(this.NumPolicyEffectiveInstallmentTerm.Value);
        else
          companyLineInstallment.SetPolicyEffectiveInstallmentTermNull();
        if (this.NumPolicyExpirationInstallmentTerm.Value != null && this.NumPolicyExpirationInstallmentTerm.Value != DBNull.Value)
          companyLineInstallment.PolicyExpirationInstallmentTerm = Conversions.ToInteger(this.NumPolicyExpirationInstallmentTerm.Value);
        else
          companyLineInstallment.SetPolicyExpirationInstallmentTermNull();
        companyLineInstallment.MonthFollowingDownPayment = ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).Checked;
        companyLineInstallment.MonthFollowingDownPayment_Eff = ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Checked;
        companyLineInstallment.MonthFollowingDownPayment_Eff_DateBilled = ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Checked;
        companyLineInstallment.UseMonth = ((UltraToggleEditorBase) this.chkUseMonth).Checked;
        companyLineInstallment.UseMonthForAltFirstInstallment = ((UltraToggleEditorBase) this.chkUseMonthForAltFirstInstallment).Checked;
        companyLineInstallment.MonthFollowingDownPayment_Exp = ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Checked;
        companyLineInstallment.DownpaymentFromExpirationDate = this.rbDownpaymentExpiration.Checked;
        companyLineInstallment.UseMonthFinalInstallment = ((UltraToggleEditorBase) this.chkUseMonthFinalInstallment).Checked;
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numEffDateBilledAltFinalInstallDays.Value)))
          companyLineInstallment.EffDateBilledAltFinalInstallDays = Conversions.ToInteger(this.numEffDateBilledAltFinalInstallDays.Value);
        else
          companyLineInstallment.SetEffDateBilledAltFinalInstallDaysNull();
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numEffectiveAltFinalInstallDays.Value)))
          companyLineInstallment.EffectiveAltFinalInstallDays = Conversions.ToInteger(this.numEffectiveAltFinalInstallDays.Value);
        else
          companyLineInstallment.SetEffectiveAltFinalInstallDaysNull();
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numExpirationAltFinalInstallDays.Value)))
          companyLineInstallment.ExpirationAltFinalInstallDays = Conversions.ToInteger(this.numExpirationAltFinalInstallDays.Value);
        else
          companyLineInstallment.SetExpirationAltFinalInstallDaysNull();
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numDayOfMonthAltFinalInstallDays.Value)))
          companyLineInstallment.DayOfMonthAltFinalInstallDays = Conversions.ToInteger(this.numDayOfMonthAltFinalInstallDays.Value);
        else
          companyLineInstallment.SetDayOfMonthAltFinalInstallDaysNull();
        if (!companyLineInstallment.IsDownpaymentBillingTypeIDNull() && companyLineInstallment.DownpaymentBillingTypeID == -1)
          companyLineInstallment.SetDownpaymentBillingTypeIDNull();
        this.UpdateInstallmentOptions();
        this.SaveData(this.ds.tblCompanyLineInstallments[this.bmb.Position].ID);
      }
      catch (SqlException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SqlException ex2 = ex1;
        if (ex2.Message.Contains("FK_tblQuoteOptions_tblCompanyLineInstallments"))
        {
          int num1 = (int) System.Windows.Forms.MessageBox.Show("This installment setup can Not be deleted, as it Is use on one Or more policies.\n\nPlease mark the setup as disabled to make it unavailable on future billings.", "Unable to Delete Setup", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (ex2.Message.Contains("IX_tblCompanyLineInstallments_1"))
        {
          int num2 = (int) System.Windows.Forms.MessageBox.Show("This is a duplicate installment setup.", "Duplicate Installment Setup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else if (ex2.Message.Contains("IX_tblCompanyLineInstallments"))
        {
          int num3 = (int) System.Windows.Forms.MessageBox.Show("The current installment setup name is already in use.", "Duplicate Installment Setup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
          ErrorHandler.HandleError((Exception) ex2);
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
    }
  }

  protected virtual void SaveData(int installmentID)
  {
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (System.Windows.Forms.MessageBox.Show("Are you sure you want to delete this installment setup?", "Delete Installment?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    this.ds.tblCompanyLineInstallments.FindByID(Conversions.ToInteger(((UltraGridBase) this.dg).ActiveRow.Cells["ID"].Value)).Delete();
    try
    {
      this.UpdateInstallmentOptions();
    }
    catch (SqlException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      SqlException ex2 = ex1;
      if (ex2.Message.Contains("FK_tblQuoteOptions_tblCompanyLineInstallments"))
      {
        int num = (int) System.Windows.Forms.MessageBox.Show("Options have been created that used this company line installment setup.", "Cannot Delete Company Line Installment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
      else
      {
        ErrorHandler.HandleError((Exception) ex2);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void frmCompanyInstallments_Activated(object sender, EventArgs e)
  {
    if (this._painted)
      return;
    if (this.ds.tblCompanyBillingTypes.Rows.Count == 0)
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("There are no available downpayment billing types assigned to this company/line setup.\n\nDownpayment billing types must be entered before installment options can be saved.", "No Billing Types Available", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    this._painted = true;
  }

  private void GetMinMaxInfoHelper(ref Message m)
  {
    frmCompanyInstallments.MINMAXINFO lparam = (frmCompanyInstallments.MINMAXINFO) m.GetLParam(typeof (frmCompanyInstallments.MINMAXINFO));
    Size size;
    if (!this.MinimumSize.IsEmpty)
    {
      ref frmCompanyInstallments.POINTAPI local1 = ref lparam.ptMinTrackSize;
      size = this.MinimumSize;
      int width = size.Width;
      local1.x = width;
      ref frmCompanyInstallments.POINTAPI local2 = ref lparam.ptMinTrackSize;
      size = this.MinimumSize;
      int height = size.Height;
      local2.y = height;
    }
    size = this.MaximumSize;
    if (!size.IsEmpty)
    {
      ref frmCompanyInstallments.POINTAPI local3 = ref lparam.ptMaxTrackSize;
      size = this.MaximumSize;
      int width = size.Width;
      local3.x = width;
      ref frmCompanyInstallments.POINTAPI local4 = ref lparam.ptMaxTrackSize;
      size = this.MaximumSize;
      int height = size.Height;
      local4.y = height;
    }
    Marshal.StructureToPtr<frmCompanyInstallments.MINMAXINFO>(lparam, m.LParam, true);
    m.Result = IntPtr.Zero;
  }

  protected override void WndProc(ref Message m)
  {
    if (m.Msg == 36)
      this.GetMinMaxInfoHelper(ref m);
    else
      base.WndProc(ref m);
  }

  private void numDP_ValueChanged(object sender, EventArgs e)
  {
    if (this.numDP.Value == null || this.numDP.Value == DBNull.Value)
      return;
    ((UltraNumericEditorBase) this.numDP).ValueChanged -= new EventHandler(this.numDP_ValueChanged);
    try
    {
      if (Decimal.Compare(Conversions.ToDecimal(this.numDP.Value), 1M) <= 0)
        return;
      this.numDP.Value = (object) Decimal.Divide(Conversions.ToDecimal(this.numDP.Value), 100M);
    }
    finally
    {
      ((UltraNumericEditorBase) this.numDP).ValueChanged += new EventHandler(this.numDP_ValueChanged);
    }
  }

  private void PolicyTerms_CheckedChanged(object sender, EventArgs e)
  {
    if (this.rbEffectiveDateBilled.Checked)
    {
      this.rbInstallmentDateBilled.Enabled = true;
      this.rbInstallmentEffective.Enabled = true;
      ((Control) this.txtInstallmentTerms).Enabled = true;
      this.numDayofMonth.Value = (object) null;
      ((Control) this.numDayofMonth).Enabled = false;
      ((Control) this.NumPolicyEffectiveInstallmentTerm).Enabled = false;
      ((Control) this.numDayOfMonthInstallmentTerm).Enabled = false;
      this.NumPolicyEffectiveInstallmentTerm.Value = (object) null;
      this.numDayOfMonthInstallmentTerm.Value = (object) null;
      ((Control) this.numDayOfMonthAltFirstInstallDays).Enabled = false;
      this.numDayOfMonthAltFirstInstallDays.Value = (object) null;
      ((Control) this.NumPolicyExpirationInstallmentTerm).Enabled = false;
      this.NumPolicyExpirationInstallmentTerm.Value = (object) null;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).Checked = false;
      ((Control) this.chkFollowingDownPayment_DayOfMonth).Enabled = false;
      ((Control) this.chkFollowingDownPayment_Eff).Enabled = false;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Checked = false;
      ((Control) this.chkFollowingDownPayment_Eff_DateBilled).Enabled = true;
      ((Control) this.numEffDateBilledAltFirstInstallDays).Enabled = true;
      ((Control) this.numEffectiveAltFirstInstallDays).Enabled = false;
      this.numEffectiveAltFirstInstallDays.Value = (object) null;
      ((Control) this.NumPolicyExpirationInstallmentTerm).Enabled = false;
      this.NumPolicyExpirationInstallmentTerm.Value = (object) null;
      ((Control) this.numExpirationAltFirstInstallDays).Enabled = false;
      this.numExpirationAltFirstInstallDays.Value = (object) null;
      ((Control) this.chkFollowingDownPayment_Exp).Enabled = false;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Checked = false;
      ((Control) this.numEffDateBilledAltFinalInstallDays).Enabled = true;
      ((Control) this.numEffectiveAltFinalInstallDays).Enabled = false;
      ((Control) this.numExpirationAltFinalInstallDays).Enabled = false;
      ((Control) this.numDayOfMonthAltFinalInstallDays).Enabled = false;
      this.numEffectiveAltFinalInstallDays.Value = (object) null;
      this.numExpirationAltFinalInstallDays.Value = (object) null;
      this.numDayOfMonthAltFinalInstallDays.Value = (object) null;
    }
    if (this.rbDayOfMonth.Checked)
    {
      this.rbInstallmentDateBilled.Enabled = false;
      this.rbInstallmentEffective.Enabled = false;
      ((Control) this.txtInstallmentTerms).Enabled = false;
      this.txtInstallmentTerms.Value = (object) null;
      this.rbInstallmentEffective.Checked = false;
      this.rbInstallmentDateBilled.Checked = false;
      ((Control) this.NumPolicyEffectiveInstallmentTerm).Enabled = false;
      this.NumPolicyEffectiveInstallmentTerm.Value = (object) null;
      ((Control) this.numDayOfMonthInstallmentTerm).Enabled = true;
      ((Control) this.numDayofMonth).Enabled = true;
      ((Control) this.chkFollowingDownPayment_DayOfMonth).Enabled = true;
      ((Control) this.numDayOfMonthAltFirstInstallDays).Enabled = true;
      ((Control) this.chkFollowingDownPayment_Eff).Enabled = false;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Checked = false;
      ((Control) this.chkFollowingDownPayment_Eff_DateBilled).Enabled = false;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Checked = false;
      this.numEffectiveAltFirstInstallDays.Value = (object) null;
      this.numEffDateBilledAltFirstInstallDays.Value = (object) null;
      ((Control) this.numEffectiveAltFirstInstallDays).Enabled = false;
      ((Control) this.numEffDateBilledAltFirstInstallDays).Enabled = false;
      ((Control) this.NumPolicyExpirationInstallmentTerm).Enabled = false;
      this.NumPolicyExpirationInstallmentTerm.Value = (object) null;
      ((Control) this.numExpirationAltFirstInstallDays).Enabled = false;
      this.numExpirationAltFirstInstallDays.Value = (object) null;
      ((Control) this.chkFollowingDownPayment_Exp).Enabled = false;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Checked = false;
      ((Control) this.numDayOfMonthAltFinalInstallDays).Enabled = true;
      ((Control) this.numEffDateBilledAltFinalInstallDays).Enabled = false;
      ((Control) this.numEffectiveAltFinalInstallDays).Enabled = false;
      ((Control) this.numExpirationAltFinalInstallDays).Enabled = false;
      this.numEffectiveAltFinalInstallDays.Value = (object) null;
      this.numExpirationAltFinalInstallDays.Value = (object) null;
      this.numEffDateBilledAltFinalInstallDays.Value = (object) null;
    }
    if (this.rbPolicyEffective.Checked)
    {
      this.txtInstallmentTerms.Value = (object) null;
      this.rbInstallmentDateBilled.Enabled = false;
      this.rbInstallmentEffective.Enabled = false;
      ((Control) this.txtInstallmentTerms).Enabled = false;
      this.rbInstallmentEffective.Checked = false;
      this.rbInstallmentDateBilled.Checked = false;
      this.numDayofMonth.Value = (object) null;
      ((Control) this.numDayofMonth).Enabled = false;
      ((Control) this.numDayOfMonthInstallmentTerm).Enabled = false;
      this.numDayOfMonthInstallmentTerm.Value = (object) null;
      ((Control) this.numDayOfMonthAltFirstInstallDays).Enabled = false;
      this.numDayOfMonthAltFirstInstallDays.Value = (object) null;
      ((Control) this.chkFollowingDownPayment_DayOfMonth).Enabled = false;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).Checked = false;
      ((Control) this.NumPolicyEffectiveInstallmentTerm).Enabled = true;
      ((Control) this.chkFollowingDownPayment_Eff).Enabled = true;
      ((Control) this.chkFollowingDownPayment_Eff_DateBilled).Enabled = false;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Checked = false;
      ((Control) this.numEffectiveAltFirstInstallDays).Enabled = true;
      ((Control) this.numEffDateBilledAltFirstInstallDays).Enabled = false;
      this.numEffDateBilledAltFirstInstallDays.Value = (object) null;
      ((Control) this.NumPolicyExpirationInstallmentTerm).Enabled = false;
      this.NumPolicyExpirationInstallmentTerm.Value = (object) null;
      ((Control) this.numExpirationAltFirstInstallDays).Enabled = false;
      this.numExpirationAltFirstInstallDays.Value = (object) null;
      ((Control) this.chkFollowingDownPayment_Exp).Enabled = false;
      ((UltraToggleEditorBase) this.chkFollowingDownPayment_Exp).Checked = false;
      ((Control) this.numEffectiveAltFinalInstallDays).Enabled = true;
      ((Control) this.numEffDateBilledAltFinalInstallDays).Enabled = false;
      ((Control) this.numExpirationAltFinalInstallDays).Enabled = false;
      ((Control) this.numDayOfMonthAltFinalInstallDays).Enabled = false;
      this.numDayOfMonthAltFinalInstallDays.Value = (object) null;
      this.numExpirationAltFinalInstallDays.Value = (object) null;
      this.numEffDateBilledAltFinalInstallDays.Value = (object) null;
    }
    if (!this.rbPolicyExpiration.Checked)
      return;
    this.txtInstallmentTerms.Value = (object) null;
    this.rbInstallmentDateBilled.Enabled = false;
    this.rbInstallmentEffective.Enabled = false;
    ((Control) this.txtInstallmentTerms).Enabled = false;
    this.rbInstallmentEffective.Checked = false;
    this.rbInstallmentDateBilled.Checked = false;
    this.numDayofMonth.Value = (object) null;
    ((Control) this.numDayofMonth).Enabled = false;
    ((Control) this.numDayOfMonthInstallmentTerm).Enabled = false;
    this.numDayOfMonthInstallmentTerm.Value = (object) null;
    ((Control) this.numDayOfMonthAltFirstInstallDays).Enabled = false;
    this.numDayOfMonthAltFirstInstallDays.Value = (object) null;
    ((Control) this.chkFollowingDownPayment_DayOfMonth).Enabled = false;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_DayOfMonth).Checked = false;
    ((Control) this.NumPolicyExpirationInstallmentTerm).Enabled = true;
    ((Control) this.chkFollowingDownPayment_Exp).Enabled = true;
    ((Control) this.chkFollowingDownPayment_Eff_DateBilled).Enabled = false;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Checked = false;
    ((Control) this.chkFollowingDownPayment_Eff).Enabled = false;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff).Checked = false;
    ((Control) this.numExpirationAltFirstInstallDays).Enabled = true;
    ((Control) this.numEffDateBilledAltFirstInstallDays).Enabled = false;
    this.numEffDateBilledAltFirstInstallDays.Value = (object) null;
    ((Control) this.NumPolicyEffectiveInstallmentTerm).Enabled = false;
    this.NumPolicyEffectiveInstallmentTerm.Value = (object) null;
    ((Control) this.chkFollowingDownPayment_Eff_DateBilled).Enabled = false;
    ((UltraToggleEditorBase) this.chkFollowingDownPayment_Eff_DateBilled).Checked = false;
    ((Control) this.numEffectiveAltFirstInstallDays).Enabled = false;
    this.numEffectiveAltFirstInstallDays.Value = (object) null;
    ((Control) this.numExpirationAltFinalInstallDays).Enabled = true;
    ((Control) this.numEffDateBilledAltFinalInstallDays).Enabled = false;
    ((Control) this.numEffectiveAltFinalInstallDays).Enabled = false;
    ((Control) this.numDayOfMonthAltFinalInstallDays).Enabled = false;
    this.numDayOfMonthAltFinalInstallDays.Value = (object) null;
    this.numEffectiveAltFinalInstallDays.Value = (object) null;
    this.numEffDateBilledAltFinalInstallDays.Value = (object) null;
  }

  private void lnkCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowForm(typeof (FormCopyCompanyLineInstallments), (object) this._companyLine.CompanyLineID);
  }

  private void chkSinglePay_CheckedChanged(object sender, EventArgs e)
  {
    if (!((UltraToggleEditorBase) this.chkSinglePay).Checked)
      return;
    this.numPayments.Value = (object) 1;
    this.cboDownpaymentBillingType.Value = (object) -1;
  }

  private void LnkAssignBillingTypes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    CompanyLineInstallmentBillingTypeView installmentBillingTypeView = MgaMdiChild.Create<CompanyLineInstallmentBillingTypeView>(new object[0]);
    ((FrameworkElement) installmentBillingTypeView).DataContext = (object) CompanyLineInstallmentBillingTypeViewModel.Create((IWinMsgBoxService) new WinMsgBoxService(), this._companyLine.CompanyLineID, this.ds.tblCompanyLineInstallments[this.bmb.Position].ID);
    installmentBillingTypeView.Form.MdiParent = MDIControls.Instance.MDIParent;
    installmentBillingTypeView.Form.Show();
  }

  private void LnkTransDateInstallment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraGridBase) this.dg).ActiveRow == null)
    {
      int num1 = (int) System.Windows.Forms.MessageBox.Show("Please select an active row in the grid to continue", "No Active Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      using (FormTransDateInstallment objectAs = ObjectFactory.Instance.CreateObjectAs<FormTransDateInstallment>(((UltraGridBase) this.dg).ActiveRow.Cells["ID"].Value, (object) this.ds.tblCompanyBillingTypes))
      {
        int num2 = (int) objectAs.ShowDialog();
      }
    }
  }

  private void UpdateInstallmentOptions()
  {
    using (DbDataAdapter dbDataAdapter = DefaultDatabase.BuildDataAdapter((DataTable) this.ds.tblCompanyLineInstallments, "dbo.InsertInstallmentOptions", "dbo.UpdateInstallmentOptions", "dbo.DeleteInstallmentOptions", true, 30, (DbTransaction) null))
      DefaultDatabase.DataAdapterUpdate(dbDataAdapter, (DataTable) this.ds.tblCompanyLineInstallments);
  }

  private struct POINTAPI
  {
    public int x;
    public int y;
  }

  private struct MINMAXINFO
  {
    public frmCompanyInstallments.POINTAPI ptReserved;
    public frmCompanyInstallments.POINTAPI ptMaxSize;
    public frmCompanyInstallments.POINTAPI ptMaxPosition;
    public frmCompanyInstallments.POINTAPI ptMinTrackSize;
    public frmCompanyInstallments.POINTAPI ptMaxTrackSize;
  }
}

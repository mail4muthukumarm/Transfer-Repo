// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Administration.frmAdminPolicyCharges
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.FormattedLinkLabel;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Administration;

[SecureResource("{9AB9CC0E-9359-4005-9F6D-E11CAB9503D2}", "Access Policy Charges Screen", "Controls access to the Policy Charges Screen.", "Users")]
public class frmAdminPolicyCharges : Form
{
  private IContainer components;
  private dsAdminPolicyCharges ds;
  private SqlDataAdapter daPolicyCharges;
  private UltraDropDown ddStates;
  private Label Label1;
  private RadioButton rbPremium;
  private ErrorProvider err;
  private Label Label2;
  private Label Label3;
  private MGASimpleComboBox cboState;
  private Label Label4;
  private MGACheckBox chkTax;
  private MGATextBox txtDescription;
  private MGATextBox txtName;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private DataView dvStateFilter;
  private Label Label5;
  public const string canViewPolicyChargesForm = "{9AB9CC0E-9359-4005-9F6D-E11CAB9503D2}";
  protected Lazy<bool> _canViewDBEligible;
  protected Lazy<bool> _showSurplusLinesTaxFields;
  private bool _hasSLFees;

  protected virtual UltraGrid dgChargeCodes
  {
    get => this._dgChargeCodes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DgChargeCodes_AfterRowActivate);
      UltraGrid dgChargeCodes1 = this._dgChargeCodes;
      if (dgChargeCodes1 != null)
        dgChargeCodes1.AfterRowActivate -= eventHandler;
      this._dgChargeCodes = value;
      UltraGrid dgChargeCodes2 = this._dgChargeCodes;
      if (dgChargeCodes2 == null)
        return;
      dgChargeCodes2.AfterRowActivate += eventHandler;
    }
  }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.DbSave_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.DbSave_ClickingNew);
      EventHandler eventHandler1 = new EventHandler(this.DbSave_ClickedNew);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.DbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.DbSave_ClickingCancel);
      EventHandler eventHandler2 = new EventHandler(this.DbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingSave -= cancelEventHandler1;
        dbSave1.ClickingNew -= cancelEventHandler2;
        dbSave1.ClickedNew -= eventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler3;
        dbSave1.ClickingCancel -= cancelEventHandler4;
        dbSave1.UIStateChanged -= eventHandler2;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingSave += cancelEventHandler1;
      dbSave2.ClickingNew += cancelEventHandler2;
      dbSave2.ClickedNew += eventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler3;
      dbSave2.ClickingCancel += cancelEventHandler4;
      dbSave2.UIStateChanged += eventHandler2;
    }
  }

  private virtual RadioButton rbFee
  {
    get => this._rbFee;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RbFee_CheckedChanged);
      RadioButton rbFee1 = this._rbFee;
      if (rbFee1 != null)
        rbFee1.CheckedChanged -= eventHandler;
      this._rbFee = value;
      RadioButton rbFee2 = this._rbFee;
      if (rbFee2 == null)
        return;
      rbFee2.CheckedChanged += eventHandler;
    }
  }

  private virtual MGASimpleComboBox cboStateFilter
  {
    get => this._cboStateFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CboStateFilter_ValueChanged);
      MGASimpleComboBox cboStateFilter1 = this._cboStateFilter;
      if (cboStateFilter1 != null)
        cboStateFilter1.ValueChanged -= eventHandler;
      this._cboStateFilter = value;
      MGASimpleComboBox cboStateFilter2 = this._cboStateFilter;
      if (cboStateFilter2 == null)
        return;
      cboStateFilter2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabControl1")]
  internal virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  internal virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabInfo")]
  protected internal virtual UltraTabPageControl tabInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  internal virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpTaxDue")]
  private virtual MGAGroupBox grpTaxDue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("udTaxDueDays")]
  private virtual MGANumericEditor udTaxDueDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDADfromEffective")]
  private virtual RadioButton rbDADfromEffective { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDADfromBilling")]
  private virtual RadioButton rbDADfromBilling { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDADEndYear")]
  private virtual RadioButton rbDADEndYear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDADEndQuarter")]
  private virtual RadioButton rbDADEndQuarter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDADEndMonth")]
  private virtual RadioButton rbDADEndMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpFilingDue")]
  private virtual MGAGroupBox grpFilingDue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("udFilingDueDays")]
  private virtual MGANumericEditor udFilingDueDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDFDFromEffective")]
  private virtual RadioButton rbDFDFromEffective { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDFDFromBilling")]
  private virtual RadioButton rbDFDFromBilling { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDFDEndYear")]
  private virtual RadioButton rbDFDEndYear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  private virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDFDEndQuarter")]
  private virtual RadioButton rbDFDEndQuarter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  private virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDFDEndMonth")]
  private virtual RadioButton rbDFDEndMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  private virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtMonthDay")]
  private virtual MGADateTimePicker dtMonthDay { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbPresetMonthAndDay")]
  private virtual RadioButton rbPresetMonthAndDay { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkClear
  {
    get => this._lnkClear;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkClearMonthDayDue_LinkClicked);
      LinkLabel lnkClear1 = this._lnkClear;
      if (lnkClear1 != null)
        lnkClear1.LinkClicked -= clickedEventHandler;
      this._lnkClear = value;
      LinkLabel lnkClear2 = this._lnkClear;
      if (lnkClear2 == null)
        return;
      lnkClear2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("dtTaxDueSemiAnnual1")]
  private virtual MGADateTimePicker dtTaxDueSemiAnnual1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtFilingDueSemiAnnual2")]
  private virtual MGADateTimePicker dtFilingDueSemiAnnual2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtFilingDueSemiAnnual1")]
  private virtual MGADateTimePicker dtFilingDueSemiAnnual1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtTaxDueSemiAnnual2")]
  private virtual MGADateTimePicker dtTaxDueSemiAnnual2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel LinkLabel1
  {
    get => this._LinkLabel1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
      LinkLabel linkLabel1_1 = this._LinkLabel1;
      if (linkLabel1_1 != null)
        linkLabel1_1.LinkClicked -= clickedEventHandler;
      this._LinkLabel1 = value;
      LinkLabel linkLabel1_2 = this._LinkLabel1;
      if (linkLabel1_2 == null)
        return;
      linkLabel1_2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("rbDADSemiAnnual")]
  private virtual RadioButton rbDADSemiAnnual { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbDFDSemiAnnual")]
  private virtual RadioButton rbDFDSemiAnnual { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox chkSurplusLinesTax
  {
    get => this._chkSurplusLinesTax;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChkSurplusLinesTax_CheckedChanged);
      MGACheckBox chkSurplusLinesTax1 = this._chkSurplusLinesTax;
      if (chkSurplusLinesTax1 != null)
        ((UltraToggleEditorBase) chkSurplusLinesTax1).CheckedChanged -= eventHandler;
      this._chkSurplusLinesTax = value;
      MGACheckBox chkSurplusLinesTax2 = this._chkSurplusLinesTax;
      if (chkSurplusLinesTax2 == null)
        return;
      ((UltraToggleEditorBase) chkSurplusLinesTax2).CheckedChanged += eventHandler;
    }
  }

  internal virtual UltraFormattedLinkLabel lnkSLPriority
  {
    get => this._lnkSLPriority;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkClickedEventHandler clickedEventHandler = new LinkClickedEventHandler(this.LnkSLPriority_LinkClicked);
      UltraFormattedLinkLabel lnkSlPriority1 = this._lnkSLPriority;
      if (lnkSlPriority1 != null)
        ((UltraFormattedTextEditorBase) lnkSlPriority1).LinkClicked -= clickedEventHandler;
      this._lnkSLPriority = value;
      UltraFormattedLinkLabel lnkSlPriority2 = this._lnkSLPriority;
      if (lnkSlPriority2 == null)
        return;
      ((UltraFormattedTextEditorBase) lnkSlPriority2).LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("chkDBEligible")]
  private virtual MGACheckBox chkDBEligible { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdminPolicyCharges));
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("lstStatestblFin_PolicyCharges");
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstStatestblFin_PolicyCharges", 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ChargeType");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Tax");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("DaysTaxDue");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("DaysTaxDueType");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("DaysFilingDue");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("DaysFilingDueType");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("TaxDueMonthAndDay");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("TaxDueSemiAnnual1");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("TaxDueSemiAnnual2");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("FilingDueSemiAnnual1");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("FilingDueSemiAnnual2");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("SurplusLinesTax");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("SLPriority");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("DirectBillEligible");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("FeeClassID");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("ChargeID");
    Appearance appearance23 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblFin_PolicyCharges", -1);
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("ChargeType");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("StateID", -1, (object) "ddStates");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("Tax");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("DaysTaxDue");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("DaysTaxDueType");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("DaysFilingDue");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("DaysFilingDueType");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("TaxDueMonthAndDay");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("TaxDueSemiAnnual1");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("TaxDueSemiAnnual2");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("FilingDueSemiAnnual1");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("FilingDueSemiAnnual2");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("SurplusLinesTax");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("SLPriority");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("DirectBillEligible", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("FeeClassID");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("ChargeID");
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.tabInfo = new UltraTabPageControl();
    this.chkDBEligible = new MGACheckBox();
    this.ds = new dsAdminPolicyCharges();
    this.lnkSLPriority = new UltraFormattedLinkLabel();
    this.chkSurplusLinesTax = new MGACheckBox();
    this.chkTax = new MGACheckBox();
    this.lblFeeClass = new Label();
    this.Label4 = new Label();
    this.Label1 = new Label();
    this.cboFeeClass = new MGASimpleComboBox();
    this.cboState = new MGASimpleComboBox();
    this.rbPremium = new RadioButton();
    this.Label3 = new Label();
    this.rbFee = new RadioButton();
    this.Label2 = new Label();
    this.txtName = new MGATextBox();
    this.txtDescription = new MGATextBox();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.grpFilingDue = new MGAGroupBox();
    this.rbDFDSemiAnnual = new RadioButton();
    this.LinkLabel1 = new LinkLabel();
    this.dtFilingDueSemiAnnual2 = new MGADateTimePicker();
    this.dtFilingDueSemiAnnual1 = new MGADateTimePicker();
    this.udFilingDueDays = new MGANumericEditor();
    this.rbDFDFromEffective = new RadioButton();
    this.Label9 = new Label();
    this.rbDFDFromBilling = new RadioButton();
    this.rbDFDEndYear = new RadioButton();
    this.Label10 = new Label();
    this.rbDFDEndQuarter = new RadioButton();
    this.Label11 = new Label();
    this.rbDFDEndMonth = new RadioButton();
    this.grpTaxDue = new MGAGroupBox();
    this.rbDADSemiAnnual = new RadioButton();
    this.dtTaxDueSemiAnnual2 = new MGADateTimePicker();
    this.dtTaxDueSemiAnnual1 = new MGADateTimePicker();
    this.lnkClear = new LinkLabel();
    this.rbPresetMonthAndDay = new RadioButton();
    this.Label12 = new Label();
    this.dtMonthDay = new MGADateTimePicker();
    this.udTaxDueDays = new MGANumericEditor();
    this.rbDADfromEffective = new RadioButton();
    this.Label7 = new Label();
    this.rbDADfromBilling = new RadioButton();
    this.rbDADEndYear = new RadioButton();
    this.Label8 = new Label();
    this.rbDADEndQuarter = new RadioButton();
    this.Label6 = new Label();
    this.rbDADEndMonth = new RadioButton();
    this.daPolicyCharges = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.err = new ErrorProvider(this.components);
    this.Label5 = new Label();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.dvStateFilter = new DataView();
    this.ddStates = new UltraDropDown();
    this.dgChargeCodes = new UltraGrid();
    this.cboStateFilter = new MGASimpleComboBox();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    ((Control) this.tabInfo).SuspendLayout();
    ((ISupportInitialize) this.chkDBEligible).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.chkSurplusLinesTax).BeginInit();
    ((ISupportInitialize) this.chkTax).BeginInit();
    ((ISupportInitialize) this.cboFeeClass).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((ISupportInitialize) this.txtName).BeginInit();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.grpFilingDue).BeginInit();
    ((Control) this.grpFilingDue).SuspendLayout();
    ((ISupportInitialize) this.dtFilingDueSemiAnnual2).BeginInit();
    ((ISupportInitialize) this.dtFilingDueSemiAnnual1).BeginInit();
    ((ISupportInitialize) this.udFilingDueDays).BeginInit();
    ((ISupportInitialize) this.grpTaxDue).BeginInit();
    ((Control) this.grpTaxDue).SuspendLayout();
    ((ISupportInitialize) this.dtTaxDueSemiAnnual2).BeginInit();
    ((ISupportInitialize) this.dtTaxDueSemiAnnual1).BeginInit();
    ((ISupportInitialize) this.dtMonthDay).BeginInit();
    ((ISupportInitialize) this.udTaxDueDays).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    this.dvStateFilter.BeginInit();
    ((ISupportInitialize) this.ddStates).BeginInit();
    ((ISupportInitialize) this.dgChargeCodes).BeginInit();
    ((ISupportInitialize) this.cboStateFilter).BeginInit();
    this.SuspendLayout();
    ((Control) this.tabInfo).Controls.Add((Control) this.chkDBEligible);
    ((Control) this.tabInfo).Controls.Add((Control) this.lnkSLPriority);
    ((Control) this.tabInfo).Controls.Add((Control) this.chkSurplusLinesTax);
    ((Control) this.tabInfo).Controls.Add((Control) this.chkTax);
    ((Control) this.tabInfo).Controls.Add((Control) this.lblFeeClass);
    ((Control) this.tabInfo).Controls.Add((Control) this.Label4);
    ((Control) this.tabInfo).Controls.Add((Control) this.Label1);
    ((Control) this.tabInfo).Controls.Add((Control) this.cboFeeClass);
    ((Control) this.tabInfo).Controls.Add((Control) this.cboState);
    ((Control) this.tabInfo).Controls.Add((Control) this.rbPremium);
    ((Control) this.tabInfo).Controls.Add((Control) this.Label3);
    ((Control) this.tabInfo).Controls.Add((Control) this.rbFee);
    ((Control) this.tabInfo).Controls.Add((Control) this.Label2);
    ((Control) this.tabInfo).Controls.Add((Control) this.txtName);
    ((Control) this.tabInfo).Controls.Add((Control) this.txtDescription);
    ((Control) this.tabInfo).Location = new Point(1, 26);
    ((Control) this.tabInfo).Name = "tabInfo";
    ((Control) this.tabInfo).Size = new Size(589, 256 /*0x0100*/);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDBEligible).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.chkDBEligible).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDBEligible).BackColorInternal = Color.Transparent;
    ((Control) this.chkDBEligible).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblFin_PolicyCharges.DirectBillEligible", true, DataSourceUpdateMode.OnPropertyChanged));
    ((UltraToggleEditorBase) this.chkDBEligible).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDBEligible).Location = new Point(140, 131);
    this.chkDBEligible.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkDBEligible).Name = "chkDBEligible";
    ((Control) this.chkDBEligible).Size = new Size(136, 24);
    ((Control) this.chkDBEligible).TabIndex = 12;
    ((UltraToggleEditorBase) this.chkDBEligible).Text = "Direct Bill Eligible";
    ((UltraControlBase) this.chkDBEligible).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDBEligible).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAdminPolicyCharges";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance2.BackColor = Color.Transparent;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance2).TextVAlignAsString = "Middle";
    ((UltraFormattedTextEditorBase) this.lnkSLPriority).Appearance = (AppearanceBase) appearance2;
    ((UltraFormattedTextEditorBase) this.lnkSLPriority).AutoSize = true;
    ((Control) this.lnkSLPriority).Location = new Point(92, 191);
    ((Control) this.lnkSLPriority).Name = "lnkSLPriority";
    ((Control) this.lnkSLPriority).Size = new Size(76, 15);
    ((Control) this.lnkSLPriority).TabIndex = 11;
    this.lnkSLPriority.TabStop = true;
    ((UltraFormattedTextEditorBase) this.lnkSLPriority).TreatValueAs = (TreatValueAs) 2;
    ((UltraFormattedTextEditorBase) this.lnkSLPriority).Value = (object) "SL Tax Priority";
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkSurplusLinesTax).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.chkSurplusLinesTax).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkSurplusLinesTax).BackColorInternal = Color.Transparent;
    ((Control) this.chkSurplusLinesTax).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblFin_PolicyCharges.SurplusLinesTax", true));
    ((UltraToggleEditorBase) this.chkSurplusLinesTax).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkSurplusLinesTax).Location = new Point(92, 161);
    this.chkSurplusLinesTax.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkSurplusLinesTax).Name = "chkSurplusLinesTax";
    ((Control) this.chkSurplusLinesTax).Size = new Size(154, 24);
    ((Control) this.chkSurplusLinesTax).TabIndex = 10;
    ((UltraToggleEditorBase) this.chkSurplusLinesTax).Text = "Surplus Lines Tax";
    ((UltraControlBase) this.chkSurplusLinesTax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkSurplusLinesTax).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkTax).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkTax).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkTax).BackColorInternal = Color.Transparent;
    ((Control) this.chkTax).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblFin_PolicyCharges.Tax", true));
    ((UltraToggleEditorBase) this.chkTax).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkTax).Location = new Point(92, 131);
    this.chkTax.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkTax).Name = "chkTax";
    ((Control) this.chkTax).Size = new Size(42, 24);
    ((Control) this.chkTax).TabIndex = 9;
    ((UltraToggleEditorBase) this.chkTax).Text = "Tax";
    ((UltraControlBase) this.chkTax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkTax).UseOsThemes = (DefaultableBoolean) 2;
    this.lblFeeClass.BackColor = Color.Transparent;
    this.lblFeeClass.Location = new Point(245, 19);
    this.lblFeeClass.Name = "lblFeeClass";
    this.lblFeeClass.Size = new Size(62, 23);
    this.lblFeeClass.TabIndex = 8;
    this.lblFeeClass.Text = "Fee Class:";
    this.lblFeeClass.TextAlign = ContentAlignment.MiddleRight;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(22, 103);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(56, 23);
    this.Label4.TabIndex = 8;
    this.Label4.Text = "State:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(22, 19);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(56, 23);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Type:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.cboFeeClass).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboFeeClass.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboFeeClass).DataBindings.Add(new Binding("Value", (object) this.ds, "tblFin_PolicyCharges.FeeClassID", true, DataSourceUpdateMode.OnPropertyChanged, (object) "-1"));
    ((UltraGridBase) this.cboFeeClass).DataMember = "lstFeeClasses";
    ((UltraGridBase) this.cboFeeClass).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboFeeClass).DisplayMember = "FeeClass";
    this.cboFeeClass.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboFeeClass).Location = new Point(324, 19);
    this.cboFeeClass.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboFeeClass).Name = "cboFeeClass";
    ((Control) this.cboFeeClass).Size = new Size(154, 21);
    ((Control) this.cboFeeClass).TabIndex = 7;
    ((UltraControlBase) this.cboFeeClass).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboFeeClass).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboFeeClass).ValueMember = "FeeClassID";
    this.cboState.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboState).DataBindings.Add(new Binding("Value", (object) this.ds, "tblFin_PolicyCharges.StateID", true));
    ((UltraGridBase) this.cboState).DataSource = (object) this.ds.lstStates;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboState).Location = new Point(92, 103);
    this.cboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(154, 21);
    ((Control) this.cboState).TabIndex = 7;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    this.rbPremium.BackColor = Color.Transparent;
    this.rbPremium.Location = new Point(92, 19);
    this.rbPremium.Name = "rbPremium";
    this.rbPremium.Size = new Size(70, 24);
    this.rbPremium.TabIndex = 1;
    this.rbPremium.Text = "Premium";
    this.rbPremium.UseVisualStyleBackColor = false;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(8, 75);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(70, 23);
    this.Label3.TabIndex = 6;
    this.Label3.Text = "Description:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.rbFee.BackColor = Color.Transparent;
    this.rbFee.Location = new Point(169, 19);
    this.rbFee.Name = "rbFee";
    this.rbFee.Size = new Size(70, 24);
    this.rbFee.TabIndex = 2;
    this.rbFee.Text = "Fee";
    this.rbFee.UseVisualStyleBackColor = false;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(22, 47);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(56, 23);
    this.Label2.TabIndex = 5;
    this.Label2.Text = "Name:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtName).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtName).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtName).BackColor = Color.White;
    ((Control) this.txtName).DataBindings.Add(new Binding("Text", (object) this.ds, "tblFin_PolicyCharges.ChargeName", true));
    ((Control) this.txtName).Location = new Point(92, 47);
    ((TextEditorControlBase) this.txtName).MaxLength = 150;
    this.txtName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtName).Name = "txtName";
    ((Control) this.txtName).Size = new Size(386, 20);
    ((Control) this.txtName).TabIndex = 3;
    ((UltraControlBase) this.txtName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtName).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtDescription).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescription).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.txtDescription).BackColor = Color.White;
    ((Control) this.txtDescription).DataBindings.Add(new Binding("Text", (object) this.ds, "tblFin_PolicyCharges.Description", true));
    ((Control) this.txtDescription).Location = new Point(92, 75);
    ((TextEditorControlBase) this.txtDescription).MaxLength = 100;
    this.txtDescription.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtDescription).Name = "txtDescription";
    ((Control) this.txtDescription).Size = new Size(386, 20);
    ((Control) this.txtDescription).TabIndex = 4;
    ((UltraControlBase) this.txtDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescription).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.grpFilingDue);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.grpTaxDue);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(589, 256 /*0x0100*/);
    ((Control) this.grpFilingDue).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance7.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    this.grpFilingDue.ContentAreaAppearance = (AppearanceBase) appearance7;
    ((Control) this.grpFilingDue).Controls.Add((Control) this.rbDFDSemiAnnual);
    ((Control) this.grpFilingDue).Controls.Add((Control) this.LinkLabel1);
    ((Control) this.grpFilingDue).Controls.Add((Control) this.dtFilingDueSemiAnnual2);
    ((Control) this.grpFilingDue).Controls.Add((Control) this.dtFilingDueSemiAnnual1);
    ((Control) this.grpFilingDue).Controls.Add((Control) this.udFilingDueDays);
    ((Control) this.grpFilingDue).Controls.Add((Control) this.rbDFDFromEffective);
    ((Control) this.grpFilingDue).Controls.Add((Control) this.Label9);
    ((Control) this.grpFilingDue).Controls.Add((Control) this.rbDFDFromBilling);
    ((Control) this.grpFilingDue).Controls.Add((Control) this.rbDFDEndYear);
    ((Control) this.grpFilingDue).Controls.Add((Control) this.Label10);
    ((Control) this.grpFilingDue).Controls.Add((Control) this.rbDFDEndQuarter);
    ((Control) this.grpFilingDue).Controls.Add((Control) this.Label11);
    ((Control) this.grpFilingDue).Controls.Add((Control) this.rbDFDEndMonth);
    ((Control) this.grpFilingDue).Enabled = false;
    appearance8.ForeColor = Color.FromArgb(21, 66, 139);
    this.grpFilingDue.HeaderAppearance = (AppearanceBase) appearance8;
    ((Control) this.grpFilingDue).Location = new Point(303, 7);
    ((Control) this.grpFilingDue).Name = "grpFilingDue";
    ((Control) this.grpFilingDue).Size = new Size(276, 246);
    ((Control) this.grpFilingDue).TabIndex = 23;
    ((Control) this.grpFilingDue).Tag = (object) "DFD";
    this.grpFilingDue.Text = "Date Filing Due";
    this.grpFilingDue.ViewStyle = (GroupBoxViewStyle) 2;
    this.rbDFDSemiAnnual.BackColor = Color.Transparent;
    this.rbDFDSemiAnnual.Location = new Point(73, 186);
    this.rbDFDSemiAnnual.Name = "rbDFDSemiAnnual";
    this.rbDFDSemiAnnual.Size = new Size(88, 22);
    this.rbDFDSemiAnnual.TabIndex = 47;
    this.rbDFDSemiAnnual.Text = "Semi-Annual";
    this.rbDFDSemiAnnual.UseVisualStyleBackColor = false;
    this.LinkLabel1.AutoSize = true;
    this.LinkLabel1.Location = new Point(190, 159);
    this.LinkLabel1.Name = "LinkLabel1";
    this.LinkLabel1.Size = new Size(72, 13);
    this.LinkLabel1.TabIndex = 44;
    this.LinkLabel1.TabStop = true;
    this.LinkLabel1.Text = "Clear All Data";
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtFilingDueSemiAnnual2.Appearance = (AppearanceBase) appearance9;
    appearance10.AlphaLevel = (short) 14;
    appearance10.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance10.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance10.BackColorAlpha = (Alpha) 2;
    appearance10.BackGradientAlignment = (GradientAlignment) 4;
    appearance10.BackGradientStyle = (GradientStyle) 5;
    appearance10.BorderAlpha = (Alpha) 1;
    appearance10.BorderColor = Color.FromArgb(78, 122, 171);
    appearance10.ForeColor = Color.FromArgb(49, 85, 153);
    appearance10.ForegroundAlpha = (Alpha) 2;
    this.dtFilingDueSemiAnnual2.ButtonAppearance = (AppearanceBase) appearance10;
    ((Control) this.dtFilingDueSemiAnnual2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblFin_PolicyCharges.FilingDueSemiAnnual2", true));
    this.dtFilingDueSemiAnnual2.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtFilingDueSemiAnnual2).Location = new Point(167, 214);
    this.dtFilingDueSemiAnnual2.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtFilingDueSemiAnnual2).Name = "dtFilingDueSemiAnnual2";
    ((Control) this.dtFilingDueSemiAnnual2).Size = new Size(84, 20);
    ((Control) this.dtFilingDueSemiAnnual2).TabIndex = 46;
    ((UltraControlBase) this.dtFilingDueSemiAnnual2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtFilingDueSemiAnnual2).UseOsThemes = (DefaultableBoolean) 2;
    this.dtFilingDueSemiAnnual2.Value = (object) null;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtFilingDueSemiAnnual1.Appearance = (AppearanceBase) appearance11;
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
    this.dtFilingDueSemiAnnual1.ButtonAppearance = (AppearanceBase) appearance12;
    ((Control) this.dtFilingDueSemiAnnual1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblFin_PolicyCharges.FilingDueSemiAnnual1", true));
    this.dtFilingDueSemiAnnual1.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtFilingDueSemiAnnual1).Location = new Point(167, 188);
    this.dtFilingDueSemiAnnual1.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtFilingDueSemiAnnual1).Name = "dtFilingDueSemiAnnual1";
    ((Control) this.dtFilingDueSemiAnnual1).Size = new Size(84, 20);
    ((Control) this.dtFilingDueSemiAnnual1).TabIndex = 44;
    ((UltraControlBase) this.dtFilingDueSemiAnnual1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtFilingDueSemiAnnual1).UseOsThemes = (DefaultableBoolean) 2;
    this.dtFilingDueSemiAnnual1.Value = (object) null;
    appearance13.BackColor = Color.Transparent;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.udFilingDueDays).Appearance = (AppearanceBase) appearance13;
    ((UltraNumericEditorBase) this.udFilingDueDays).BackColor = Color.Transparent;
    ((Control) this.udFilingDueDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblFin_PolicyCharges.DaysFilingDue", true));
    ((Control) this.udFilingDueDays).Location = new Point(73, 25);
    this.udFilingDueDays.MaskInput = "nnnn";
    this.udFilingDueDays.MaxValue = (object) 9999;
    this.udFilingDueDays.MGAStyle = MGAStyles.Blue;
    this.udFilingDueDays.MinValue = (object) 0;
    ((Control) this.udFilingDueDays).Name = "udFilingDueDays";
    this.udFilingDueDays.Nullable = true;
    ((Control) this.udFilingDueDays).Size = new Size(64 /*0x40*/, 20);
    ((Control) this.udFilingDueDays).TabIndex = 30;
    ((UltraControlBase) this.udFilingDueDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.udFilingDueDays).UseOsThemes = (DefaultableBoolean) 2;
    this.rbDFDFromEffective.BackColor = Color.Transparent;
    this.rbDFDFromEffective.Location = new Point(73, 78);
    this.rbDFDFromEffective.Name = "rbDFDFromEffective";
    this.rbDFDFromEffective.Size = new Size(97, 20);
    this.rbDFDFromEffective.TabIndex = 35;
    this.rbDFDFromEffective.Text = "Effective Date";
    this.rbDFDFromEffective.UseVisualStyleBackColor = false;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(157, 19);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(59, 23);
    this.Label9.TabIndex = 37;
    this.Label9.Text = "days";
    this.Label9.TextAlign = ContentAlignment.MiddleLeft;
    this.rbDFDFromBilling.BackColor = Color.Transparent;
    this.rbDFDFromBilling.Location = new Point(73, 52);
    this.rbDFDFromBilling.Name = "rbDFDFromBilling";
    this.rbDFDFromBilling.Size = new Size(88, 20);
    this.rbDFDFromBilling.TabIndex = 29;
    this.rbDFDFromBilling.Text = "Billing Date";
    this.rbDFDFromBilling.UseVisualStyleBackColor = false;
    this.rbDFDEndYear.BackColor = Color.Transparent;
    this.rbDFDEndYear.Location = new Point(73, 158);
    this.rbDFDEndYear.Name = "rbDFDEndYear";
    this.rbDFDEndYear.Size = new Size(95, 22);
    this.rbDFDEndYear.TabIndex = 36;
    this.rbDFDEndYear.Text = "End Of Year";
    this.rbDFDEndYear.UseVisualStyleBackColor = false;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(6, 23);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(63 /*0x3F*/, 23);
    this.Label10.TabIndex = 31 /*0x1F*/;
    this.Label10.Text = "Filing Due";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    this.rbDFDEndQuarter.BackColor = Color.Transparent;
    this.rbDFDEndQuarter.Location = new Point(73, 104);
    this.rbDFDEndQuarter.Name = "rbDFDEndQuarter";
    this.rbDFDEndQuarter.Size = new Size(110, 20);
    this.rbDFDEndQuarter.TabIndex = 34;
    this.rbDFDEndQuarter.Text = "End Of Quarter";
    this.rbDFDEndQuarter.UseVisualStyleBackColor = false;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(23, 46);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(33, 23);
    this.Label11.TabIndex = 32 /*0x20*/;
    this.Label11.Text = "From";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    this.rbDFDEndMonth.BackColor = Color.Transparent;
    this.rbDFDEndMonth.Location = new Point(73, 130);
    this.rbDFDEndMonth.Name = "rbDFDEndMonth";
    this.rbDFDEndMonth.Size = new Size(97, 22);
    this.rbDFDEndMonth.TabIndex = 33;
    this.rbDFDEndMonth.Text = "End Of Month";
    this.rbDFDEndMonth.UseVisualStyleBackColor = false;
    ((Control) this.grpTaxDue).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance14.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    this.grpTaxDue.ContentAreaAppearance = (AppearanceBase) appearance14;
    ((Control) this.grpTaxDue).Controls.Add((Control) this.rbDADSemiAnnual);
    ((Control) this.grpTaxDue).Controls.Add((Control) this.dtTaxDueSemiAnnual2);
    ((Control) this.grpTaxDue).Controls.Add((Control) this.dtTaxDueSemiAnnual1);
    ((Control) this.grpTaxDue).Controls.Add((Control) this.lnkClear);
    ((Control) this.grpTaxDue).Controls.Add((Control) this.rbPresetMonthAndDay);
    ((Control) this.grpTaxDue).Controls.Add((Control) this.Label12);
    ((Control) this.grpTaxDue).Controls.Add((Control) this.dtMonthDay);
    ((Control) this.grpTaxDue).Controls.Add((Control) this.udTaxDueDays);
    ((Control) this.grpTaxDue).Controls.Add((Control) this.rbDADfromEffective);
    ((Control) this.grpTaxDue).Controls.Add((Control) this.Label7);
    ((Control) this.grpTaxDue).Controls.Add((Control) this.rbDADfromBilling);
    ((Control) this.grpTaxDue).Controls.Add((Control) this.rbDADEndYear);
    ((Control) this.grpTaxDue).Controls.Add((Control) this.Label8);
    ((Control) this.grpTaxDue).Controls.Add((Control) this.rbDADEndQuarter);
    ((Control) this.grpTaxDue).Controls.Add((Control) this.Label6);
    ((Control) this.grpTaxDue).Controls.Add((Control) this.rbDADEndMonth);
    ((Control) this.grpTaxDue).Enabled = false;
    appearance15.ForeColor = Color.FromArgb(21, 66, 139);
    this.grpTaxDue.HeaderAppearance = (AppearanceBase) appearance15;
    ((Control) this.grpTaxDue).Location = new Point(13, 7);
    ((Control) this.grpTaxDue).Name = "grpTaxDue";
    ((Control) this.grpTaxDue).Size = new Size(284, 246);
    ((Control) this.grpTaxDue).TabIndex = 22;
    ((Control) this.grpTaxDue).Tag = (object) "DAD";
    this.grpTaxDue.Text = "Date Tax Due";
    this.grpTaxDue.ViewStyle = (GroupBoxViewStyle) 2;
    this.rbDADSemiAnnual.BackColor = Color.Transparent;
    this.rbDADSemiAnnual.Location = new Point(57, 195);
    this.rbDADSemiAnnual.Name = "rbDADSemiAnnual";
    this.rbDADSemiAnnual.Size = new Size(102, 22);
    this.rbDADSemiAnnual.TabIndex = 44;
    this.rbDADSemiAnnual.Text = "Semi-Annual";
    this.rbDADSemiAnnual.UseVisualStyleBackColor = false;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtTaxDueSemiAnnual2.Appearance = (AppearanceBase) appearance16;
    appearance17.AlphaLevel = (short) 14;
    appearance17.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance17.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance17.BackColorAlpha = (Alpha) 2;
    appearance17.BackGradientAlignment = (GradientAlignment) 4;
    appearance17.BackGradientStyle = (GradientStyle) 5;
    appearance17.BorderAlpha = (Alpha) 1;
    appearance17.BorderColor = Color.FromArgb(78, 122, 171);
    appearance17.ForeColor = Color.FromArgb(49, 85, 153);
    appearance17.ForegroundAlpha = (Alpha) 2;
    this.dtTaxDueSemiAnnual2.ButtonAppearance = (AppearanceBase) appearance17;
    ((Control) this.dtTaxDueSemiAnnual2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblFin_PolicyCharges.TaxDueSemiAnnual2", true));
    this.dtTaxDueSemiAnnual2.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtTaxDueSemiAnnual2).Location = new Point(179, 221);
    this.dtTaxDueSemiAnnual2.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtTaxDueSemiAnnual2).Name = "dtTaxDueSemiAnnual2";
    ((Control) this.dtTaxDueSemiAnnual2).Size = new Size(84, 20);
    ((Control) this.dtTaxDueSemiAnnual2).TabIndex = 43;
    ((UltraControlBase) this.dtTaxDueSemiAnnual2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtTaxDueSemiAnnual2).UseOsThemes = (DefaultableBoolean) 2;
    this.dtTaxDueSemiAnnual2.Value = (object) null;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtTaxDueSemiAnnual1.Appearance = (AppearanceBase) appearance18;
    appearance19.AlphaLevel = (short) 14;
    appearance19.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance19.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance19.BackColorAlpha = (Alpha) 2;
    appearance19.BackGradientAlignment = (GradientAlignment) 4;
    appearance19.BackGradientStyle = (GradientStyle) 5;
    appearance19.BorderAlpha = (Alpha) 1;
    appearance19.BorderColor = Color.FromArgb(78, 122, 171);
    appearance19.ForeColor = Color.FromArgb(49, 85, 153);
    appearance19.ForegroundAlpha = (Alpha) 2;
    this.dtTaxDueSemiAnnual1.ButtonAppearance = (AppearanceBase) appearance19;
    ((Control) this.dtTaxDueSemiAnnual1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblFin_PolicyCharges.TaxDueSemiAnnual1", true));
    this.dtTaxDueSemiAnnual1.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtTaxDueSemiAnnual1).Location = new Point(179, 195);
    this.dtTaxDueSemiAnnual1.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtTaxDueSemiAnnual1).Name = "dtTaxDueSemiAnnual1";
    ((Control) this.dtTaxDueSemiAnnual1).Size = new Size(84, 20);
    ((Control) this.dtTaxDueSemiAnnual1).TabIndex = 41;
    ((UltraControlBase) this.dtTaxDueSemiAnnual1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtTaxDueSemiAnnual1).UseOsThemes = (DefaultableBoolean) 2;
    this.dtTaxDueSemiAnnual1.Value = (object) null;
    this.lnkClear.AutoSize = true;
    this.lnkClear.Location = new Point(163, 167);
    this.lnkClear.Name = "lnkClear";
    this.lnkClear.Size = new Size(72, 13);
    this.lnkClear.TabIndex = 40;
    this.lnkClear.TabStop = true;
    this.lnkClear.Text = "Clear All Data";
    this.rbPresetMonthAndDay.BackColor = Color.Transparent;
    this.rbPresetMonthAndDay.Location = new Point(166, 61);
    this.rbPresetMonthAndDay.Name = "rbPresetMonthAndDay";
    this.rbPresetMonthAndDay.Size = new Size(113, 20);
    this.rbPresetMonthAndDay.TabIndex = 39;
    this.rbPresetMonthAndDay.Text = "Preset Month/Day";
    this.rbPresetMonthAndDay.UseVisualStyleBackColor = false;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(163, 87);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(88, 23);
    this.Label12.TabIndex = 38;
    this.Label12.Text = "Month/Day Due";
    this.Label12.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.dtMonthDay).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtMonthDay.Appearance = (AppearanceBase) appearance20;
    appearance21.AlphaLevel = (short) 14;
    appearance21.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance21.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance21.BackColorAlpha = (Alpha) 2;
    appearance21.BackGradientAlignment = (GradientAlignment) 4;
    appearance21.BackGradientStyle = (GradientStyle) 5;
    appearance21.BorderAlpha = (Alpha) 1;
    appearance21.BorderColor = Color.FromArgb(78, 122, 171);
    appearance21.ForeColor = Color.FromArgb(49, 85, 153);
    appearance21.ForegroundAlpha = (Alpha) 2;
    this.dtMonthDay.ButtonAppearance = (AppearanceBase) appearance21;
    ((Control) this.dtMonthDay).DataBindings.Add(new Binding("Value", (object) this.ds, "tblFin_PolicyCharges.TaxDueMonthAndDay", true));
    this.dtMonthDay.DateTime = new DateTime(2007, 3, 1, 0, 0, 0, 0);
    ((Control) this.dtMonthDay).Location = new Point(166, 113);
    this.dtMonthDay.MaskInput = "{LOC}mm/dd";
    this.dtMonthDay.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtMonthDay).Name = "dtMonthDay";
    ((Control) this.dtMonthDay).Size = new Size(62, 20);
    ((Control) this.dtMonthDay).TabIndex = 30;
    ((UltraControlBase) this.dtMonthDay).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtMonthDay).UseOsThemes = (DefaultableBoolean) 2;
    this.dtMonthDay.Value = (object) new DateTime(2007, 3, 1, 0, 0, 0, 0);
    appearance22.BackColor = Color.Transparent;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.udTaxDueDays).Appearance = (AppearanceBase) appearance22;
    ((UltraNumericEditorBase) this.udTaxDueDays).BackColor = Color.Transparent;
    ((Control) this.udTaxDueDays).DataBindings.Add(new Binding("Value", (object) this.ds, "tblFin_PolicyCharges.DaysTaxDue", true));
    ((Control) this.udTaxDueDays).Location = new Point(57, 24);
    this.udTaxDueDays.MaskInput = "nnnn";
    this.udTaxDueDays.MaxValue = (object) 9999;
    this.udTaxDueDays.MGAStyle = MGAStyles.Blue;
    this.udTaxDueDays.MinValue = (object) 0;
    ((Control) this.udTaxDueDays).Name = "udTaxDueDays";
    this.udTaxDueDays.Nullable = true;
    ((Control) this.udTaxDueDays).Size = new Size(64 /*0x40*/, 20);
    ((Control) this.udTaxDueDays).TabIndex = 29;
    ((UltraControlBase) this.udTaxDueDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.udTaxDueDays).UseOsThemes = (DefaultableBoolean) 2;
    this.rbDADfromEffective.BackColor = Color.Transparent;
    this.rbDADfromEffective.Location = new Point(57, 87);
    this.rbDADfromEffective.Name = "rbDADfromEffective";
    this.rbDADfromEffective.Size = new Size(97, 20);
    this.rbDADfromEffective.TabIndex = 26;
    this.rbDADfromEffective.Text = "Effective Date";
    this.rbDADfromEffective.UseVisualStyleBackColor = false;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point((int) sbyte.MaxValue, 24);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(32 /*0x20*/, 23);
    this.Label7.TabIndex = 28;
    this.Label7.Text = "days";
    this.Label7.TextAlign = ContentAlignment.MiddleLeft;
    this.rbDADfromBilling.BackColor = Color.Transparent;
    this.rbDADfromBilling.Location = new Point(57, 61);
    this.rbDADfromBilling.Name = "rbDADfromBilling";
    this.rbDADfromBilling.Size = new Size(102, 20);
    this.rbDADfromBilling.TabIndex = 21;
    this.rbDADfromBilling.Text = "Billing Date";
    this.rbDADfromBilling.UseVisualStyleBackColor = false;
    this.rbDADEndYear.BackColor = Color.Transparent;
    this.rbDADEndYear.Location = new Point(57, 167);
    this.rbDADEndYear.Name = "rbDADEndYear";
    this.rbDADEndYear.Size = new Size(84, 22);
    this.rbDADEndYear.TabIndex = 27;
    this.rbDADEndYear.Text = "End Of Year";
    this.rbDADEndYear.UseVisualStyleBackColor = false;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(5, 21);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(47, 23);
    this.Label8.TabIndex = 22;
    this.Label8.Text = "Tax Due";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    this.rbDADEndQuarter.BackColor = Color.Transparent;
    this.rbDADEndQuarter.Location = new Point(57, 113);
    this.rbDADEndQuarter.Name = "rbDADEndQuarter";
    this.rbDADEndQuarter.Size = new Size(110, 20);
    this.rbDADEndQuarter.TabIndex = 25;
    this.rbDADEndQuarter.Text = "End Of Quarter";
    this.rbDADEndQuarter.UseVisualStyleBackColor = false;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(3, 55);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(37, 23);
    this.Label6.TabIndex = 23;
    this.Label6.Text = "From";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.rbDADEndMonth.BackColor = Color.Transparent;
    this.rbDADEndMonth.Location = new Point(57, 139);
    this.rbDADEndMonth.Name = "rbDADEndMonth";
    this.rbDADEndMonth.Size = new Size(97, 22);
    this.rbDADEndMonth.TabIndex = 24;
    this.rbDADEndMonth.Text = "End Of Month";
    this.rbDADEndMonth.UseVisualStyleBackColor = false;
    this.daPolicyCharges.DeleteCommand = this.SqlDeleteCommand1;
    this.daPolicyCharges.InsertCommand = this.SqlInsertCommand1;
    this.daPolicyCharges.SelectCommand = this.SqlSelectCommand1;
    this.daPolicyCharges.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblFin_PolicyCharges", new DataColumnMapping[14]
      {
        new DataColumnMapping("ChargeCode", "ChargeCode"),
        new DataColumnMapping("ChargeType", "ChargeType"),
        new DataColumnMapping("ChargeName", "ChargeName"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("Tax", "Tax"),
        new DataColumnMapping("DaysTaxDue", "DaysTaxDue"),
        new DataColumnMapping("DaysFilingDue", "DaysFilingDue"),
        new DataColumnMapping("DaysTaxDueType", "DaysTaxDueType"),
        new DataColumnMapping("DaysFilingDueType", "DaysFilingDueType"),
        new DataColumnMapping("SurplusLinesTax", "SurplusLinesTax"),
        new DataColumnMapping("SLPriority", "SLPriority"),
        new DataColumnMapping("DirectBillEligible", "DirectBillEligible"),
        new DataColumnMapping("FeeClassID", "FeeClassID")
      })
    });
    this.daPolicyCharges.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblFin_PolicyCharges] WHERE (([ChargeCode] = @Original_ChargeCode))";
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ChargeCode", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ChargeCode", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[17]
    {
      new SqlParameter("@ChargeType", SqlDbType.Char, 1, "ChargeType"),
      new SqlParameter("@ChargeName", SqlDbType.VarChar, 150, "ChargeName"),
      new SqlParameter("@Description", SqlDbType.VarChar, 100, "Description"),
      new SqlParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      new SqlParameter("@Tax", SqlDbType.Bit, 1, "Tax"),
      new SqlParameter("@DaysTaxDue", SqlDbType.TinyInt, 1, "DaysTaxDue"),
      new SqlParameter("@DaysFilingDue", SqlDbType.TinyInt, 1, "DaysFilingDue"),
      new SqlParameter("@DaysTaxDueType", SqlDbType.Char, 1, "DaysTaxDueType"),
      new SqlParameter("@DaysFilingDueType", SqlDbType.Char, 1, "DaysFilingDueType"),
      new SqlParameter("@TaxDueMonthAndDay", SqlDbType.DateTime, 8, "TaxDueMonthAndDay"),
      new SqlParameter("@TaxDueSemiAnnual1", SqlDbType.DateTime, 8, "TaxDueSemiAnnual1"),
      new SqlParameter("@TaxDueSemiAnnual2", SqlDbType.DateTime, 8, "TaxDueSemiAnnual2"),
      new SqlParameter("@FilingDueSemiAnnual1", SqlDbType.DateTime, 8, "FilingDueSemiAnnual1"),
      new SqlParameter("@FilingDueSemiAnnual2", SqlDbType.DateTime, 8, "FilingDueSemiAnnual2"),
      new SqlParameter("@SurplusLinesTax", SqlDbType.Bit, 1, "SurplusLinesTax"),
      new SqlParameter("@DirectBillEligible", SqlDbType.Bit, 1, "DirectBillEligible"),
      new SqlParameter("@FeeClassID", SqlDbType.Int, 4, "FeeClassID")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[19]
    {
      new SqlParameter("@ChargeType", SqlDbType.Char, 1, "ChargeType"),
      new SqlParameter("@ChargeName", SqlDbType.VarChar, 150, "ChargeName"),
      new SqlParameter("@Description", SqlDbType.VarChar, 100, "Description"),
      new SqlParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      new SqlParameter("@Tax", SqlDbType.Bit, 1, "Tax"),
      new SqlParameter("@DaysTaxDue", SqlDbType.TinyInt, 1, "DaysTaxDue"),
      new SqlParameter("@DaysFilingDue", SqlDbType.TinyInt, 1, "DaysFilingDue"),
      new SqlParameter("@DaysTaxDueType", SqlDbType.Char, 1, "DaysTaxDueType"),
      new SqlParameter("@DaysFilingDueType", SqlDbType.Char, 1, "DaysFilingDueType"),
      new SqlParameter("@TaxDueMonthAndDay", SqlDbType.DateTime, 8, "TaxDueMonthAndDay"),
      new SqlParameter("@TaxDueSemiAnnual1", SqlDbType.DateTime, 8, "TaxDueSemiAnnual1"),
      new SqlParameter("@TaxDueSemiAnnual2", SqlDbType.DateTime, 8, "TaxDueSemiAnnual2"),
      new SqlParameter("@FilingDueSemiAnnual1", SqlDbType.DateTime, 8, "FilingDueSemiAnnual1"),
      new SqlParameter("@FilingDueSemiAnnual2", SqlDbType.DateTime, 8, "FilingDueSemiAnnual2"),
      new SqlParameter("@SurplusLinesTax", SqlDbType.Bit, 1, "SurplusLinesTax"),
      new SqlParameter("@DirectBillEligible", SqlDbType.Bit, 1, "DirectBillEligible"),
      new SqlParameter("@FeeClassID", SqlDbType.Int, 4, "FeeClassID"),
      new SqlParameter("@Original_ChargeCode", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ChargeCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@ChargeCode", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ChargeCode", DataRowVersion.Original, (object) null)
    });
    this.err.ContainerControl = (ContainerControl) this;
    this.Label5.Location = new Point(14, 7);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(70, 23);
    this.Label5.TabIndex = 5;
    this.Label5.Text = "State Filter:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.tabInfo);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Location = new Point(7, 243);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(591, 283);
    ((Control) this.UltraTabControl1).TabIndex = 6;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 1;
    ultraTab1.TabPage = this.tabInfo;
    ultraTab1.Text = "Policy/Fee Information";
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Filing Management";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(150, 25);
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(589, 256 /*0x0100*/);
    this.dvStateFilter.Table = (DataTable) this.ds.lstStates;
    ((UltraGridBase) this.ddStates).DataSource = (object) this.ds.lstStates;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 7;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 8;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 9;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 11;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 12;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 15;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 16 /*0x10*/;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 17;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 18;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 19;
    ultraGridBand2.Columns.AddRange(new object[20]
    {
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
      (object) ultraGridColumn23
    });
    ((UltraGridBase) this.ddStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ddStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddStates).DisplayMember = "State";
    ((Control) this.ddStates).Location = new Point(165, 130);
    ((Control) this.ddStates).Name = "ddStates";
    ((Control) this.ddStates).Size = new Size(203, 63 /*0x3F*/);
    ((Control) this.ddStates).TabIndex = 1;
    ((UltraDropDownBase) this.ddStates).ValueMember = "StateID";
    ((Control) this.ddStates).Visible = false;
    ((Control) this.dgChargeCodes).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgChargeCodes).DataSource = (object) this.ds.tblFin_PolicyCharges;
    appearance23.BackColor = Color.White;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.Appearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn24.Header).Caption = "Charge Code";
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 5;
    ultraGridColumn24.Width = 70;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 0;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 134;
    ((HeaderBase) ultraGridColumn26.Header).Caption = "Item";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 1;
    ultraGridColumn26.Width = 121;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 2;
    ultraGridColumn27.Width = 158;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 3;
    ultraGridColumn28.Style = (ColumnStyle) 6;
    ultraGridColumn28.Width = 111;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 6;
    ultraGridColumn29.Width = 52;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 7;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 49;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 8;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 63 /*0x3F*/;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 9;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 54;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 10;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn33.Width = 68;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 11;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn34.Width = 57;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 12;
    ultraGridColumn35.Hidden = true;
    ultraGridColumn35.Width = 117;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 13;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn36.Width = 65;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 14;
    ultraGridColumn37.Hidden = true;
    ultraGridColumn37.Width = 70;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 15;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 70;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn39.Hidden = true;
    ultraGridColumn39.Width = 84;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 17;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 57;
    ((HeaderBase) ultraGridColumn41.Header).Caption = "Direct Bill";
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 18;
    ultraGridColumn41.Width = 77;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 19;
    ultraGridColumn42.Hidden = true;
    ultraGridColumn42.Width = 64 /*0x40*/;
    ultraGridColumn43.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn43.Header).Caption = "Charge ID";
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 4;
    ultraGridColumn43.Hidden = true;
    ultraGridColumn43.Width = 85;
    ultraGridBand3.Columns.AddRange(new object[20]
    {
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
      (object) ultraGridColumn43
    });
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance24.BackColor = Color.LightSteelBlue;
    appearance24.FontData.SizeInPoints = 10f;
    appearance24.ForeColor = Color.Black;
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance24;
    appearance25.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance25.ForeColor = Color.Black;
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance26.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance27.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance28.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance28;
    appearance29.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance30.BackColor = Color.Transparent;
    appearance30.ForeColor = Color.Black;
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance30;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgChargeCodes).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgChargeCodes).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgChargeCodes).Location = new Point(7, 35);
    ((Control) this.dgChargeCodes).Name = "dgChargeCodes";
    ((Control) this.dgChargeCodes).Size = new Size(591, 202);
    ((Control) this.dgChargeCodes).TabIndex = 0;
    ((UltraControlBase) this.dgChargeCodes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgChargeCodes).UseOsThemes = (DefaultableBoolean) 2;
    this.cboStateFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboStateFilter).DataSource = (object) this.dvStateFilter;
    ((UltraDropDownBase) this.cboStateFilter).DisplayMember = "State";
    this.cboStateFilter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboStateFilter).Location = new Point(91, 8);
    this.cboStateFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboStateFilter).Name = "cboStateFilter";
    ((Control) this.cboStateFilter).Size = new Size(168, 21);
    ((Control) this.cboStateFilter).TabIndex = 4;
    ((UltraControlBase) this.cboStateFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboStateFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboStateFilter).ValueMember = "StateID";
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(484, 532);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 3;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(604, 584);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.cboStateFilter);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.ddStates);
    this.Controls.Add((Control) this.dgChargeCodes);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (frmAdminPolicyCharges);
    this.Text = "Policy Charges Administration";
    ((Control) this.tabInfo).ResumeLayout(false);
    ((Control) this.tabInfo).PerformLayout();
    ((ISupportInitialize) this.chkDBEligible).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.chkSurplusLinesTax).EndInit();
    ((ISupportInitialize) this.chkTax).EndInit();
    ((ISupportInitialize) this.cboFeeClass).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((ISupportInitialize) this.txtName).EndInit();
    ((ISupportInitialize) this.txtDescription).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.grpFilingDue).EndInit();
    ((Control) this.grpFilingDue).ResumeLayout(false);
    ((Control) this.grpFilingDue).PerformLayout();
    ((ISupportInitialize) this.dtFilingDueSemiAnnual2).EndInit();
    ((ISupportInitialize) this.dtFilingDueSemiAnnual1).EndInit();
    ((ISupportInitialize) this.udFilingDueDays).EndInit();
    ((ISupportInitialize) this.grpTaxDue).EndInit();
    ((Control) this.grpTaxDue).ResumeLayout(false);
    ((Control) this.grpTaxDue).PerformLayout();
    ((ISupportInitialize) this.dtTaxDueSemiAnnual2).EndInit();
    ((ISupportInitialize) this.dtTaxDueSemiAnnual1).EndInit();
    ((ISupportInitialize) this.dtMonthDay).EndInit();
    ((ISupportInitialize) this.udTaxDueDays).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    this.dvStateFilter.EndInit();
    ((ISupportInitialize) this.ddStates).EndInit();
    ((ISupportInitialize) this.dgChargeCodes).EndInit();
    ((ISupportInitialize) this.cboStateFilter).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("lblFeeClass")]
  private virtual Label lblFeeClass { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboFeeClass")]
  private virtual MGASimpleComboBox cboFeeClass { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public frmAdminPolicyCharges()
  {
    this.Load += new EventHandler(this.FrmAdminPolicyCharges_Load);
    this._canViewDBEligible = MGASystems.Common.Settings.SystemSettings.GetLazySetting<bool>("PolicyCharges.Fees.DirectBillEligible", false, true);
    this._showSurplusLinesTaxFields = MGASystems.Common.Settings.SystemSettings.GetLazySetting<bool>("EnableSurplusLinesTax", false, true);
    this._hasSLFees = false;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
      this.components?.Dispose();
    base.Dispose(disposing);
  }

  private BindingManagerBase ChargeBinding
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblFin_PolicyCharges.TableName];
  }

  protected dsAdminPolicyCharges.tblFin_PolicyChargesRow CurrentCharge
  {
    get
    {
      dsAdminPolicyCharges.tblFin_PolicyChargesRow currentCharge;
      if (this.ChargeBinding.Position > -1)
      {
        try
        {
          currentCharge = this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position];
          goto label_4;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      currentCharge = (dsAdminPolicyCharges.tblFin_PolicyChargesRow) null;
label_4:
      return currentCharge;
    }
  }

  protected dsAdminPolicyCharges ChargeData => this.ds;

  private void FrmAdminPolicyCharges_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    Utility.SetDataAdapterConnections((DbDataAdapter) this.daPolicyCharges, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    this.ds.lstStates.AddlstStatesRow(string.Empty, "All");
    this.ds.lstFeeClasses.AddlstFeeClassesRow(-1, string.Empty, (string) null);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[3]
    {
      this.ds.lstStates.TableName,
      this.ds.lstFeeClasses.TableName,
      this.ds.tblFin_PolicyCharges.TableName
    }, "spPolicyCharges_FormLoad");
    this.dbSave.UIState = this.ds.tblFin_PolicyCharges.Rows.Count <= 0 ? UIState.NoRecordsNotEditing : UIState.HasRecordsNotEditing;
    ((Control) this.chkSurplusLinesTax).Visible = this._showSurplusLinesTaxFields.Value;
    ((Control) this.lnkSLPriority).Visible = this._showSurplusLinesTaxFields.Value;
    if (CurrentUser.IsMGADeveloper)
      ((UltraGridBase) this.dgChargeCodes).DisplayLayout.Bands[0].Columns["ChargeID"].Hidden = false;
    this.AfterLoad();
  }

  public virtual void AfterLoad()
  {
  }

  protected virtual bool ValidForm()
  {
    bool valid1 = true;
    bool flag;
    if (string.IsNullOrEmpty(this.cboState.Text) && this.rbPremium.Checked)
    {
      this.err.SetError((Control) this.cboState, "Premium items require a state to be selected.");
      flag = false;
    }
    else
    {
      this.err.SetError((Control) this.cboState, string.Empty);
      if ((this.cboState.Value == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboState.Text, string.Empty, false) == 0) && ((UltraToggleEditorBase) this.chkTax).Checked)
      {
        this.err.SetError((Control) this.cboState, "Fees marked as taxes require a state to be selected.");
        flag = false;
      }
      else
      {
        this.err.SetError((Control) this.cboState, string.Empty);
        if (((TextEditorControlBase) this.txtName).Text.Length == 0)
        {
          this.err.SetError((Control) this.txtName, "Please enter a name for this item.");
          flag = false;
        }
        else
        {
          this.err.SetError((Control) this.txtName, string.Empty);
          if (((TextEditorControlBase) this.txtDescription).Text.Length == 0)
          {
            this.err.SetError((Control) this.txtDescription, "Please enter a name for this item.");
            flag = false;
          }
          else
          {
            this.err.SetError((Control) this.txtDescription, string.Empty);
            if (!this.rbPremium.Checked && !this.rbFee.Checked)
            {
              this.err.SetError((Control) this.rbFee, "Please select the type for this item.");
              flag = false;
            }
            else
            {
              this.err.SetError((Control) this.rbFee, string.Empty);
              if (((UltraToggleEditorBase) this.chkTax).Checked && this.rbPremium.Checked)
              {
                this.err.SetError((Control) this.chkTax, "Only fee items can be marked as taxes.");
                flag = false;
              }
              else
              {
                this.err.SetError((Control) this.chkTax, string.Empty);
                bool valid2 = this.ValidateExistingRecord(this.ValidateFilingDue(this.ValidateTaxDue(valid1)));
                if (valid2)
                  valid2 = this.ValidateSemiAnnualDates(this.dtTaxDueSemiAnnual1, this.dtTaxDueSemiAnnual2, this.grpTaxDue, valid2);
                if (valid2)
                  valid2 = this.ValidateSemiAnnualDates(this.dtFilingDueSemiAnnual1, this.dtFilingDueSemiAnnual2, this.grpFilingDue, valid2);
                flag = valid2;
              }
            }
          }
        }
      }
    }
    return flag;
  }

  private bool IsRadioButtonChecked(MGAGroupBox GroupBox)
  {
    bool flag = false;
    try
    {
      foreach (Control control in ((Control) GroupBox).Controls)
      {
        if (control is RadioButton radioButton && radioButton.Checked)
        {
          flag = true;
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
    return flag;
  }

  private bool ValidateSemiAnnualDates(
    MGADateTimePicker date1,
    MGADateTimePicker date2,
    MGAGroupBox groupBox,
    bool valid)
  {
    bool flag1;
    if (valid)
    {
      bool flag2 = false;
      bool flag3 = false;
      if (date1.Value != null && date1.Value != DBNull.Value)
        flag2 = true;
      if (date2.Value != null && date2.Value != DBNull.Value)
        flag3 = true;
      valid = flag2 == flag3;
      if (!valid)
      {
        this.err.SetError((Control) date1, "Both semi-annual dates must be set or blank");
        this.err.SetError((Control) date2, "Both semi-annual dates must be set or blank");
        valid = false;
      }
      else if (valid)
      {
        this.err.SetError((Control) date1, string.Empty);
        this.err.SetError((Control) date2, string.Empty);
      }
      bool flag4 = false;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((Control) groupBox).Tag.ToString(), "DAD", false) == 0)
        flag4 = this.rbDADSemiAnnual.Checked;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((Control) groupBox).Tag.ToString(), "DFD", false) == 0)
        flag4 = this.rbDFDSemiAnnual.Checked;
      if (valid && flag2 && !flag4)
      {
        this.err.SetError((Control) date1, "Need to check off Semi-Annual");
        valid = false;
      }
      else if (valid)
        this.err.SetError((Control) date1, string.Empty);
      if (valid && flag2 && DateTime.Compare(Conversions.ToDate(date1.Value), Conversions.ToDate(date2.Value)) > 0)
      {
        this.err.SetError((Control) date1, "This date should be the lesser date");
        valid = false;
      }
      else if (valid)
        this.err.SetError((Control) date1, string.Empty);
      if (valid && flag4 && (!flag2 || !flag3))
      {
        this.err.SetError((Control) date1, "Semi-Annual checked. Enter semi-annual dates");
        valid = false;
      }
      else if (valid)
        this.err.SetError((Control) date1, string.Empty);
      if (!valid)
        ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[1];
      flag1 = valid;
    }
    return flag1;
  }

  private bool ValidateExistingRecord(bool valid)
  {
    if (valid && this.ChargeBinding.Position != -1 && !this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position].IsStateIDNull())
    {
      string chargeName = this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position].ChargeName;
      string stateId = this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position].StateID;
      string str = "SELECT COUNT(*) FROM tblFin_PolicyCharges WHERE ChargeName = @cName AND StateID = @sID";
      if (!this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position].IsStateIDNull() && this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position].RowState == DataRowState.Added)
      {
        if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, str, new object[4]
        {
          (object) "@cName",
          (object) chargeName,
          (object) "@sID",
          (object) stateId
        }) > 0)
        {
          this.err.SetError((Control) this.txtName, "Duplicate Name and State");
          valid = false;
          goto label_5;
        }
      }
      this.err.SetError((Control) this.txtName, string.Empty);
    }
label_5:
    return valid;
  }

  private bool ValidateFilingDue(bool valid)
  {
    if (this.udFilingDueDays.Value != DBNull.Value && !this.IsRadioButtonChecked(this.grpFilingDue) && this.IsSemiAnnualDatesEmpty(this.grpFilingDue))
    {
      this.err.SetError((Control) this.rbDFDFromBilling, "Please select an option");
      valid = false;
    }
    else
      this.err.SetError((Control) this.rbDFDFromBilling, string.Empty);
    return valid;
  }

  private bool IsSemiAnnualDatesEmpty(MGAGroupBox GroupBox)
  {
    bool flag = true;
    try
    {
      foreach (Control control in ((Control) GroupBox).Controls)
      {
        if (control is MGADateTimePicker mgaDateTimePicker && mgaDateTimePicker.Value != DBNull.Value && mgaDateTimePicker.Value != null)
        {
          flag = false;
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
    return flag;
  }

  private bool ValidateTaxDue(bool valid)
  {
    if (this.udTaxDueDays.Value != DBNull.Value && !this.IsRadioButtonChecked(this.grpTaxDue) && this.IsSemiAnnualDatesEmpty(this.grpTaxDue))
    {
      this.err.SetError((Control) this.rbDADfromBilling, "Please select an option or semi-annual date");
      valid = false;
    }
    else
      this.err.SetError((Control) this.rbDADfromBilling, string.Empty);
    if (this.rbPresetMonthAndDay.Checked)
    {
      if (this.dtMonthDay.Value != DBNull.Value && this.dtMonthDay.Value != null)
      {
        this.err.SetError((Control) this.dtMonthDay, string.Empty);
      }
      else
      {
        this.err.SetError((Control) this.dtMonthDay, "Preset Month and Day selected. Enter month/Day");
        valid = false;
      }
      if (this.udTaxDueDays.Value != DBNull.Value && this.udTaxDueDays.Value != null)
      {
        this.err.SetError((Control) this.udTaxDueDays, "Please delete this value. Preset Month and Day Selected.");
        valid = false;
      }
      else
        this.err.SetError((Control) this.udTaxDueDays, string.Empty);
    }
    else if (this.dtMonthDay.Value != DBNull.Value && this.dtMonthDay.Value != null)
    {
      this.err.SetError((Control) this.dtMonthDay, "This must not be filled in when preset Month and Day NOT selected.");
      valid = false;
    }
    else
      this.err.SetError((Control) this.dtMonthDay, string.Empty);
    return valid;
  }

  private void AssignTaxAndFilingInfo()
  {
    dsAdminPolicyCharges.tblFin_PolicyChargesRow tblFinPolicyCharge = this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position];
    if (this.rbFee.Checked)
    {
      if (this.rbDADEndMonth.Checked)
        tblFinPolicyCharge.DaysTaxDueType = "M";
      else if (this.rbDADEndQuarter.Checked)
        tblFinPolicyCharge.DaysTaxDueType = "Q";
      else if (this.rbDADEndYear.Checked)
        tblFinPolicyCharge.DaysTaxDueType = "Y";
      else if (this.rbDADfromBilling.Checked)
        tblFinPolicyCharge.DaysTaxDueType = "B";
      else if (this.rbDADfromEffective.Checked)
        tblFinPolicyCharge.DaysTaxDueType = "E";
      else if (this.rbPresetMonthAndDay.Checked)
      {
        tblFinPolicyCharge.DaysTaxDueType = "P";
        tblFinPolicyCharge.TaxDueMonthAndDay = (DateTime) this.dtMonthDay.Value;
      }
      else if (this.rbDADSemiAnnual.Checked)
        tblFinPolicyCharge.DaysTaxDueType = "S";
      else
        tblFinPolicyCharge.SetDaysTaxDueTypeNull();
      if (this.rbDFDEndMonth.Checked)
        tblFinPolicyCharge.DaysFilingDueType = "M";
      else if (this.rbDFDEndQuarter.Checked)
        tblFinPolicyCharge.DaysFilingDueType = "Q";
      else if (this.rbDFDEndYear.Checked)
        tblFinPolicyCharge.DaysFilingDueType = "Y";
      else if (this.rbDFDFromBilling.Checked)
        tblFinPolicyCharge.DaysFilingDueType = "B";
      else if (this.rbDFDFromEffective.Checked)
        tblFinPolicyCharge.DaysFilingDueType = "E";
      else if (this.rbDFDSemiAnnual.Checked)
        tblFinPolicyCharge.DaysFilingDueType = "S";
      else
        tblFinPolicyCharge.SetDaysFilingDueTypeNull();
    }
    else
    {
      tblFinPolicyCharge.SetDaysFilingDueNull();
      tblFinPolicyCharge.SetDaysFilingDueTypeNull();
      tblFinPolicyCharge.SetDaysTaxDueNull();
      tblFinPolicyCharge.SetDaysTaxDueTypeNull();
      tblFinPolicyCharge.SetTaxDueMonthAndDayNull();
    }
  }

  private void ClearErrorProviders()
  {
    try
    {
      foreach (Control control in ((Control) this.grpTaxDue).Controls)
        this.err.SetError(control, string.Empty);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (Control control in ((Control) this.grpFilingDue).Controls)
        this.err.SetError(control, string.Empty);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void DbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidForm())
    {
      e.Cancel = true;
    }
    else
    {
      Cursor.Current = Cursors.WaitCursor;
      this.ClearErrorProviders();
      try
      {
        dsAdminPolicyCharges.tblFin_PolicyChargesRow currentCharge = this.CurrentCharge;
        currentCharge.ChargeType = this.rbFee.Checked ? "F" : "P";
        if (string.IsNullOrEmpty(currentCharge.StateID))
          currentCharge.SetStateIDNull();
        if (!currentCharge.IsFeeClassIDNull() && currentCharge.FeeClassID == -1)
          currentCharge.SetFeeClassIDNull();
        this.AssignTaxAndFilingInfo();
        this.ChargeBinding.EndCurrentEdit();
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daPolicyCharges, (DataTable) this.ds.tblFin_PolicyCharges);
        this.ClientSaveData();
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        if (ex2.Message.Contains("Update canceled, cannot update system defined policy charges"))
        {
          int num = (int) MessageBox.Show(ex2.Message, "Cannot Update System Defined Charges", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          e.Cancel = true;
          ProjectData.ClearProjectError();
        }
        else if (ex2.Message.Contains("IX_tblFin_PolicyCharges_3"))
        {
          int num = (int) MessageBox.Show("A policy charge with the same name already exists", "Policy Charge Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          e.Cancel = true;
          ProjectData.ClearProjectError();
        }
        else if (ex2.Message.Contains("CK_PremiumsRequireState"))
        {
          int num = (int) MessageBox.Show("A premium policy charge requires a state", "State Not Specified", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          e.Cancel = true;
          ProjectData.ClearProjectError();
        }
        else
        {
          ErrorHandler.HandleError(ex2);
          ProjectData.ClearProjectError();
        }
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }
  }

  protected virtual void ClientSaveData()
  {
  }

  private void DbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    this.ds.tblFin_PolicyCharges.AddtblFin_PolicyChargesRow(this.ds.tblFin_PolicyCharges.NewtblFin_PolicyChargesRow());
    this.ChargeBinding.Position = this.ds.tblFin_PolicyCharges.Rows.Count - 1;
  }

  private void DbSave_ClickedNew(object sender, EventArgs e)
  {
    ((Control) this.lnkSLPriority).Enabled = false;
  }

  private void DbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
    {
      this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position].Delete();
      this.ChargeBinding.EndCurrentEdit();
      try
      {
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daPolicyCharges, (DataTable) this.ds.tblFin_PolicyCharges);
      }
      catch (SqlException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SqlException ex2 = ex1;
        if (ex2.Number == 547)
        {
          int num = (int) MessageBox.Show("You can not delete this policy charge, because it has been\nassigned to policies in the system.", "Unable to Delete Policy Charge", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
          ErrorHandler.HandleError((Exception) ex2);
        this.ds.tblFin_PolicyCharges.RejectChanges();
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.ds.tblFin_PolicyCharges.RejectChanges();
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
    }
    else
      e.Cancel = true;
  }

  private void DbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ClearErrorProviders();
    this.ChargeBinding.EndCurrentEdit();
    this.ds.tblFin_PolicyCharges.RejectChanges();
    this.DgChargeCodes_AfterRowActivate((object) null, (EventArgs) null);
  }

  private void DbSave_UIStateChanged(object sender, EventArgs e)
  {
    bool flag = this.dbSave.UIState == UIState.Editing;
    try
    {
      foreach (Control control in ((Control) this.tabInfo).Controls)
        control.Enabled = flag;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((Control) this.dgChargeCodes).Enabled = !flag;
    ((Control) this.lnkSLPriority).Enabled = flag && ((UltraToggleEditorBase) this.chkSurplusLinesTax).Checked && this._hasSLFees;
    ((Control) this.grpTaxDue).Enabled = flag && this.rbFee.Checked;
    ((Control) this.grpFilingDue).Enabled = flag && this.rbFee.Checked;
    ((Control) this.cboFeeClass).Enabled = flag && this.rbFee.Checked;
  }

  private void SetRadioButtonsChecked(bool value, MGAGroupBox GroupBox)
  {
    try
    {
      foreach (Control control in ((Control) GroupBox).Controls)
      {
        if (control is RadioButton radioButton)
          radioButton.Checked = value;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void SetUpTaxAndFilingDate(bool typeIsFee)
  {
    if (this.ChargeBinding.Position < 0)
      return;
    dsAdminPolicyCharges.tblFin_PolicyChargesRow tblFinPolicyCharge = this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position];
    if (typeIsFee && !tblFinPolicyCharge.IsDaysTaxDueTypeNull())
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblFinPolicyCharge.DaysTaxDueType, "M", false) == 0)
        this.rbDADEndMonth.Checked = true;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblFinPolicyCharge.DaysTaxDueType, "Q", false) == 0)
        this.rbDADEndQuarter.Checked = true;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblFinPolicyCharge.DaysTaxDueType, "Y", false) == 0)
        this.rbDADEndYear.Checked = true;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblFinPolicyCharge.DaysTaxDueType, "B", false) == 0)
        this.rbDADfromBilling.Checked = true;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblFinPolicyCharge.DaysTaxDueType, "E", false) == 0)
        this.rbDADfromEffective.Checked = true;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblFinPolicyCharge.DaysTaxDueType, "P", false) == 0)
        this.rbPresetMonthAndDay.Checked = true;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblFinPolicyCharge.DaysTaxDueType, "S", false) == 0)
        this.rbDADSemiAnnual.Checked = true;
      if (!tblFinPolicyCharge.IsTaxDueMonthAndDayNull())
        this.dtMonthDay.Value = (object) tblFinPolicyCharge.TaxDueMonthAndDay;
      else
        this.dtMonthDay.Value = (object) DBNull.Value;
      if (!tblFinPolicyCharge.IsDaysTaxDueNull())
        this.udTaxDueDays.Value = (object) tblFinPolicyCharge.DaysTaxDue;
      else
        this.udTaxDueDays.Value = (object) DBNull.Value;
    }
    else
    {
      this.SetRadioButtonsChecked(false, this.grpTaxDue);
      this.dtMonthDay.Value = (object) DBNull.Value;
    }
    if (typeIsFee && !tblFinPolicyCharge.IsDaysFilingDueTypeNull())
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblFinPolicyCharge.DaysFilingDueType, "M", false) == 0)
        this.rbDFDEndMonth.Checked = true;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblFinPolicyCharge.DaysFilingDueType, "Q", false) == 0)
        this.rbDFDEndQuarter.Checked = true;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblFinPolicyCharge.DaysFilingDueType, "Y", false) == 0)
        this.rbDFDEndYear.Checked = true;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblFinPolicyCharge.DaysFilingDueType, "B", false) == 0)
        this.rbDFDFromBilling.Checked = true;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblFinPolicyCharge.DaysFilingDueType, "E", false) == 0)
        this.rbDFDFromEffective.Checked = true;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblFinPolicyCharge.DaysFilingDueType, "S", false) == 0)
        this.rbDFDSemiAnnual.Checked = true;
    }
    else
      this.SetRadioButtonsChecked(false, this.grpFilingDue);
  }

  private void DgChargeCodes_AfterRowActivate(object sender, EventArgs e)
  {
    int num = 0;
    try
    {
      foreach (dsAdminPolicyCharges.tblFin_PolicyChargesRow tblFinPolicyCharge in (TypedTableBase<dsAdminPolicyCharges.tblFin_PolicyChargesRow>) this.ds.tblFin_PolicyCharges)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        frmAdminPolicyCharges._Closure\u0024__232\u002D0 closure2320 = new frmAdminPolicyCharges._Closure\u0024__232\u002D0(closure2320);
        // ISSUE: reference to a compiler-generated field
        closure2320.\u0024VB\u0024Local_dr = tblFinPolicyCharge;
        // ISSUE: reference to a compiler-generated field
        if (closure2320.\u0024VB\u0024Local_dr.ChargeCode == Conversions.ToInteger(((UltraGridBase) this.dgChargeCodes).ActiveRow.Cells["ChargeCode"].Value))
        {
          this.ChargeBinding.Position = num;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.rbFee.Checked = !closure2320.\u0024VB\u0024Local_dr.IsChargeTypeNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(closure2320.\u0024VB\u0024Local_dr.ChargeType, "F", false) == 0;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.rbPremium.Checked = !closure2320.\u0024VB\u0024Local_dr.IsChargeTypeNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(closure2320.\u0024VB\u0024Local_dr.ChargeType, "P", false) == 0;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          this._hasSLFees = !closure2320.\u0024VB\u0024Local_dr.IsStateIDNull() && this.ds.tblFin_PolicyCharges.Where<dsAdminPolicyCharges.tblFin_PolicyChargesRow>(new System.Func<dsAdminPolicyCharges.tblFin_PolicyChargesRow, bool>(closure2320._Lambda\u0024__0)).Count<dsAdminPolicyCharges.tblFin_PolicyChargesRow>() > 1;
          this.SetUpTaxAndFilingDate(this.rbFee.Checked);
          // ISSUE: reference to a compiler-generated field
          this.OnRowActivated(closure2320.\u0024VB\u0024Local_dr);
          break;
        }
        ++num;
      }
    }
    finally
    {
      IEnumerator<dsAdminPolicyCharges.tblFin_PolicyChargesRow> enumerator;
      enumerator?.Dispose();
    }
  }

  protected virtual void OnRowActivated(dsAdminPolicyCharges.tblFin_PolicyChargesRow dr)
  {
  }

  private void CboStateFilter_ValueChanged(object sender, EventArgs e)
  {
    this.ds.tblFin_PolicyCharges.DefaultView.RowFilter = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboStateFilter.Text, string.Empty, false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboStateFilter.Text, "All", false) == 0 ? string.Empty : $"StateID='{this.cboStateFilter.Value.ToString()}'";
  }

  private void RbFee_CheckedChanged(object sender, EventArgs e)
  {
    bool flag1 = this.dbSave.UIState == UIState.Editing;
    bool flag2 = this.rbFee.Checked;
    ((Control) this.grpTaxDue).Enabled = flag2 && flag1;
    ((Control) this.grpFilingDue).Enabled = flag2 && flag1;
    ((Control) this.cboFeeClass).Enabled = flag2 && flag1;
    ((Control) this.chkDBEligible).Visible = flag2 && this._canViewDBEligible.Value;
    if (!flag1 || flag2)
      return;
    ((UltraToggleEditorBase) this.chkDBEligible).Checked = false;
    this.cboFeeClass.Value = (object) null;
  }

  private void LnkClearMonthDayDue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.ChargeBinding.Position != -1)
    {
      this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position].SetTaxDueMonthAndDayNull();
      this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position].SetTaxDueSemiAnnual1Null();
      this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position].SetTaxDueSemiAnnual2Null();
      this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position].SetDaysTaxDueNull();
    }
    this.ClearControls(this.grpTaxDue);
  }

  private void ClearControls(MGAGroupBox groupbox)
  {
    try
    {
      foreach (Control control in ((Control) groupbox).Controls)
      {
        if (control is RadioButton radioButton)
          radioButton.Checked = false;
        if (control is MGANumericEditor mgaNumericEditor && mgaNumericEditor.Value != DBNull.Value && mgaNumericEditor.Value != null)
          mgaNumericEditor.Value = (object) DBNull.Value;
        if (control is MGADateTimePicker mgaDateTimePicker)
          mgaDateTimePicker.Value = (object) DBNull.Value;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ClearControls(this.grpFilingDue);
    this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position].SetFilingDueSemiAnnual2Null();
    this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position].SetFilingDueSemiAnnual1Null();
    this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position].SetDaysFilingDueNull();
  }

  private void LnkSLPriority_LinkClicked(object sender, LinkClickedEventArgs e)
  {
    // ISSUE: variable of a compiler-generated type
    frmAdminPolicyCharges._Closure\u0024__239\u002D0 closure2390;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: reference to a compiler-generated method
    List<dsAdminPolicyCharges.tblFin_PolicyChargesRow> list = this.ds.tblFin_PolicyCharges.Where<dsAdminPolicyCharges.tblFin_PolicyChargesRow>(new System.Func<dsAdminPolicyCharges.tblFin_PolicyChargesRow, bool>(new frmAdminPolicyCharges._Closure\u0024__239\u002D0(closure2390)
    {
      \u0024W2 = this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position]
    }._Lambda\u0024__0)).ToList<dsAdminPolicyCharges.tblFin_PolicyChargesRow>();
    if (list.Count < 2)
    {
      ((Control) this.lnkSLPriority).Enabled = false;
    }
    else
    {
      dsAdminPolicyCharges.tblFin_PolicyChargesDataTable chargesDataTable = new dsAdminPolicyCharges.tblFin_PolicyChargesDataTable();
      chargesDataTable.Merge(list.CopyToDataTable<dsAdminPolicyCharges.tblFin_PolicyChargesRow>());
      frmAdminSLPriority frmAdminSlPriority = (frmAdminSLPriority) FormSettings.ShowFormDialog(typeof (frmAdminSLPriority), (object) chargesDataTable);
      if (frmAdminSlPriority.DialogResult != DialogResult.OK)
        return;
      try
      {
        foreach (dsAdminPolicyCharges.tblFin_PolicyChargesRow savedCharge in (TypedTableBase<dsAdminPolicyCharges.tblFin_PolicyChargesRow>) frmAdminSlPriority.SavedCharges)
          this.ds.tblFin_PolicyCharges.FindByChargeCode(savedCharge.ChargeCode).SLPriority = savedCharge.SLPriority;
      }
      finally
      {
        IEnumerator<dsAdminPolicyCharges.tblFin_PolicyChargesRow> enumerator;
        enumerator?.Dispose();
      }
    }
  }

  private void ChkSurplusLinesTax_CheckedChanged(object sender, EventArgs e)
  {
    if (this.ChargeBinding.Position == -1 || this.ds.tblFin_PolicyCharges[this.ChargeBinding.Position].RowState == DataRowState.Added)
      ((Control) this.lnkSLPriority).Enabled = false;
    else
      ((Control) this.lnkSLPriority).Enabled = ((Control) this.chkSurplusLinesTax).Enabled && ((UltraToggleEditorBase) this.chkSurplusLinesTax).Checked && this._hasSLFees;
  }
}

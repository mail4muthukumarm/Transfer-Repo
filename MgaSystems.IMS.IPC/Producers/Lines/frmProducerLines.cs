// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Producers.Lines.frmProducerLines
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
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Producers.Lines;

[SecureResource("{4092C509-B8E1-4f32-8C75-FEFC70E6BD11}", "Access Producer Lines Screen", "Controls access to the Producer Lines screen.", "Producers")]
public class frmProducerLines : Form
{
  private IContainer components;
  private ToolTip ToolTip;
  private dsProducersLinesStates dsProducers;
  private UltraLabel lblDefaultNew;
  private UltraLabel lblDefaultRenewal;
  private MGACheckBox chkAccountCurrent;
  private MGATextBox txtDaysDue;
  private MGANumericEditor txtNewFixed;
  private MGANumericEditor txtRenewalFixed;
  private MGASimpleComboBox cbStatus;
  internal const string OpenForm = "{4092C509-B8E1-4f32-8C75-FEFC70E6BD11}";
  private readonly Guid _producerGuid;
  private readonly Guid _producerLocationGuid;
  private int _daysDueDefault;
  private int _daysDueEndorsementDefault;
  private bool _isFormLoaded;
  private bool _clickedEdit;
  private readonly bool _entireProducer;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual MGASimpleComboBox cboStates
  {
    get => this._cboStates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboStates_ValueChanged);
      MGASimpleComboBox cboStates1 = this._cboStates;
      if (cboStates1 != null)
        cboStates1.ValueChanged -= eventHandler;
      this._cboStates = value;
      MGASimpleComboBox cboStates2 = this._cboStates;
      if (cboStates2 == null)
        return;
      cboStates2.ValueChanged += eventHandler;
    }
  }

  internal virtual MGASimpleComboBox cboLines
  {
    get => this._cboLines;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboLines_ValueChanged);
      MGASimpleComboBox cboLines1 = this._cboLines;
      if (cboLines1 != null)
        cboLines1.ValueChanged -= eventHandler;
      this._cboLines = value;
      MGASimpleComboBox cboLines2 = this._cboLines;
      if (cboLines2 == null)
        return;
      cboLines2.ValueChanged += eventHandler;
    }
  }

  internal virtual MGASimpleComboBox cboCompanies
  {
    get => this._cboCompanies;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboCompanies_ValueChanged);
      MGASimpleComboBox cboCompanies1 = this._cboCompanies;
      if (cboCompanies1 != null)
        cboCompanies1.ValueChanged -= eventHandler;
      this._cboCompanies = value;
      MGASimpleComboBox cboCompanies2 = this._cboCompanies;
      if (cboCompanies2 == null)
        return;
      cboCompanies2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("labelProducerLocation")]
  internal virtual UltraLabel labelProducerLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelProducer")]
  internal virtual UltraLabel labelProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkDefaultNew")]
  private virtual MGACheckBox chkDefaultNew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkDefaultRenewal")]
  private virtual MGACheckBox chkDefaultRenewal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gbNew")]
  protected virtual UltraGroupBox gbNew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gbRenewal")]
  protected virtual UltraGroupBox gbRenewal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gbOptions")]
  protected virtual UltraGroupBox gbOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("errProvider")]
  protected virtual ErrorProvider errProvider { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedNew);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_UIStateChanged);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler4 = new EventHandler(this.dbSave_ClickedEdit);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedNew -= eventHandler1;
        dbSave1.UIStateChanged -= eventHandler2;
        dbSave1.ClickedCancel -= eventHandler3;
        dbSave1.ClickingSave -= cancelEventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler2;
        dbSave1.ClickedEdit -= eventHandler4;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedNew += eventHandler1;
      dbSave2.UIStateChanged += eventHandler2;
      dbSave2.ClickedCancel += eventHandler3;
      dbSave2.ClickingSave += cancelEventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler2;
      dbSave2.ClickedEdit += eventHandler4;
    }
  }

  [field: AccessedThroughProperty("cboRenewalStatus")]
  internal virtual MGASimpleComboBox cboRenewalStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvStatus")]
  internal virtual DataView dvStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvRenewalStatus")]
  internal virtual DataView dvRenewalStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtEffective")]
  internal virtual MGADateTimePicker dtEffective { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabControl1")]
  protected virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridSetups")]
  protected virtual UltraGrid gridSetups { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddCompanies")]
  internal virtual UltraDropDown ddCompanies { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddLines")]
  internal virtual UltraDropDown ddLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddStates")]
  internal virtual UltraDropDown ddStates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox chkUseCompanyEndorsementDaysDue
  {
    get => this._chkUseCompanyEndorsementDaysDue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkUseCompanyEndorsementDaysDue_CheckedChanged);
      MGACheckBox endorsementDaysDue1 = this._chkUseCompanyEndorsementDaysDue;
      if (endorsementDaysDue1 != null)
        ((UltraToggleEditorBase) endorsementDaysDue1).CheckedChanged -= eventHandler;
      this._chkUseCompanyEndorsementDaysDue = value;
      MGACheckBox endorsementDaysDue2 = this._chkUseCompanyEndorsementDaysDue;
      if (endorsementDaysDue2 == null)
        return;
      ((UltraToggleEditorBase) endorsementDaysDue2).CheckedChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkUseCompanyDaysDue
  {
    get => this._chkUseCompanyDaysDue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkUseCompanyDaysDue_CheckedChanged);
      MGACheckBox useCompanyDaysDue1 = this._chkUseCompanyDaysDue;
      if (useCompanyDaysDue1 != null)
        ((UltraToggleEditorBase) useCompanyDaysDue1).CheckedChanged -= eventHandler;
      this._chkUseCompanyDaysDue = value;
      MGACheckBox useCompanyDaysDue2 = this._chkUseCompanyDaysDue;
      if (useCompanyDaysDue2 == null)
        return;
      ((UltraToggleEditorBase) useCompanyDaysDue2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("comboStateFilter")]
  internal virtual MGASimpleComboBox comboStateFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboLineFilter")]
  internal virtual MGASimpleComboBox comboLineFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboCompanyFilter")]
  internal virtual MGASimpleComboBox comboCompanyFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel linkApplyFilter
  {
    get => this._linkApplyFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkApplyFilter_LinkClicked);
      LinkLabel linkApplyFilter1 = this._linkApplyFilter;
      if (linkApplyFilter1 != null)
        linkApplyFilter1.LinkClicked -= clickedEventHandler;
      this._linkApplyFilter = value;
      LinkLabel linkApplyFilter2 = this._linkApplyFilter;
      if (linkApplyFilter2 == null)
        return;
      linkApplyFilter2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("dvCompanyFilter")]
  internal virtual DataView dvCompanyFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvLineFilter")]
  internal virtual DataView dvLineFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvStateFilter")]
  internal virtual DataView dvStateFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkBlocked")]
  private virtual MGACheckBox chkBlocked { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkApplyToPackage")]
  private virtual MGACheckBox chkApplyToPackage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboPackages")]
  internal virtual MGASimpleComboBox cboPackages { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPackage")]
  internal virtual UltraLabel lblPackage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox MgaCheckBox1
  {
    get => this._MgaCheckBox1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MgaCheckBox1_CheckedChanged);
      MGACheckBox mgaCheckBox1_1 = this._MgaCheckBox1;
      if (mgaCheckBox1_1 != null)
        ((UltraToggleEditorBase) mgaCheckBox1_1).CheckedChanged -= eventHandler;
      this._MgaCheckBox1 = value;
      MGACheckBox mgaCheckBox1_2 = this._MgaCheckBox1;
      if (mgaCheckBox1_2 == null)
        return;
      ((UltraToggleEditorBase) mgaCheckBox1_2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cboQuotingOffice")]
  internal virtual MGASimpleComboBox cboQuotingOffice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddQuotingOffice")]
  internal virtual UltraDropDown ddQuotingOffice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numCompanyCommissionNew")]
  private virtual MGANumericEditor numCompanyCommissionNew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numCompanyCommissionRenewal")]
  private virtual MGANumericEditor numCompanyCommissionRenewal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEffectiveDatePlus")]
  internal virtual MGATextBox txtEffectiveDatePlus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEndofMonthPlus")]
  internal virtual MGATextBox txtEndofMonthPlus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox chkEffectiveDatePlus
  {
    get => this._chkEffectiveDatePlus;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkEffectiveDatePlus_CheckedChanged);
      MGACheckBox effectiveDatePlus1 = this._chkEffectiveDatePlus;
      if (effectiveDatePlus1 != null)
        ((UltraToggleEditorBase) effectiveDatePlus1).CheckedChanged -= eventHandler;
      this._chkEffectiveDatePlus = value;
      MGACheckBox effectiveDatePlus2 = this._chkEffectiveDatePlus;
      if (effectiveDatePlus2 == null)
        return;
      ((UltraToggleEditorBase) effectiveDatePlus2).CheckedChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkEndOfMonthPlus
  {
    get => this._chkEndOfMonthPlus;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkEndOfMonthPlus_CheckedChanged);
      MGACheckBox chkEndOfMonthPlus1 = this._chkEndOfMonthPlus;
      if (chkEndOfMonthPlus1 != null)
        ((UltraToggleEditorBase) chkEndOfMonthPlus1).CheckedChanged -= eventHandler;
      this._chkEndOfMonthPlus = value;
      MGACheckBox chkEndOfMonthPlus2 = this._chkEndOfMonthPlus;
      if (chkEndOfMonthPlus2 == null)
        return;
      ((UltraToggleEditorBase) chkEndOfMonthPlus2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkKeepExpiringOnRenewal")]
  internal virtual MGACheckBox chkKeepExpiringOnRenewal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugbOther")]
  protected virtual UltraGroupBox ugbOther { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPremiumLessThanEqualTo")]
  private virtual Label lblPremiumLessThanEqualTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPremiumGreaterEqualTo")]
  private virtual Label lblPremiumGreaterEqualTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numPremiumLess")]
  private virtual MGANumericEditor numPremiumLess { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numPremiumGreater")]
  private virtual MGANumericEditor numPremiumGreater { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numTargetPremiumGreater")]
  private virtual MGANumericEditor numTargetPremiumGreater { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblQuotingOffice")]
  protected virtual UltraLabel lblQuotingOffice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEndorsementDaysDue")]
  internal virtual MGATextBox txtEndorsementDaysDue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance37 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmProducerLines));
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblProducerLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ProducerLineID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("UsingDefaultCommNew");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("UsingDefaultCommRenewal");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CommNew");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CommRenewal");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("AccountCurrent");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("DaysDue");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("DaysDueEndorsement");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("RenewalStatusID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("CompanyLocationGuid", -1, (object) "ddCompanies");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("LineGuid", -1, (object) "ddLines");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("StateID", -1, (object) "ddStates");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Blocked");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Entity");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ApplyToPackageOnly");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("PackageLine", -1, (object) "ddLines");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("GAAP");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("QuotingLocationGuid", -1, (object) "ddQuotingOffice");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("CompanyCommissionNew");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("CompanyCommissionRenewal");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("EndOfMonthEffDatePlusDays");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("EffectiveDatePlusDays");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("UseEndOfMonthEffDatePlusDays");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("Prod_KeepExpCommissionsOnRenewal");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("ApplyPremiumEqualOrOver");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("ApplyPremiumEqualOrLess");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("ApplyTargetPremumEqualOrOver");
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance47 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblCompanyLocations", -1);
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("CompanyLocationGUID");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("tblCompanyLocations_tblProducerLines");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblCompanyLocations_tblProducerLines", 0);
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("ProducerLineID");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("UsingDefaultCommNew");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("UsingDefaultCommRenewal");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("CommNew");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("CommRenewal");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("AccountCurrent");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("DaysDue");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("DaysDueEndorsement");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("RenewalStatusID");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("Blocked");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("Entity");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("ApplyToPackageOnly");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("PackageLine");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("GAAP");
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("QuotingLocationGuid");
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("CompanyCommissionNew");
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("CompanyCommissionRenewal");
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("EndOfMonthEffDatePlusDays");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("EffectiveDatePlusDays");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("UseEndOfMonthEffDatePlusDays");
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("Prod_KeepExpCommissionsOnRenewal");
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("ApplyPremiumEqualOrOver");
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("ApplyPremiumEqualOrLess");
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("ApplyTargetPremumEqualOrOver");
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("StateID", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("lstStates_tblProducerLines");
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstStates_tblProducerLines", 0);
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("ProducerLineID");
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("UsingDefaultCommNew");
    UltraGridColumn ultraGridColumn72 = new UltraGridColumn("UsingDefaultCommRenewal");
    UltraGridColumn ultraGridColumn73 = new UltraGridColumn("CommNew");
    UltraGridColumn ultraGridColumn74 = new UltraGridColumn("CommRenewal");
    UltraGridColumn ultraGridColumn75 = new UltraGridColumn("AccountCurrent");
    UltraGridColumn ultraGridColumn76 = new UltraGridColumn("DaysDue");
    UltraGridColumn ultraGridColumn77 = new UltraGridColumn("DaysDueEndorsement");
    UltraGridColumn ultraGridColumn78 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn79 = new UltraGridColumn("RenewalStatusID");
    UltraGridColumn ultraGridColumn80 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn81 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn82 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn83 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn84 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn85 = new UltraGridColumn("Blocked");
    UltraGridColumn ultraGridColumn86 = new UltraGridColumn("Entity");
    UltraGridColumn ultraGridColumn87 = new UltraGridColumn("ApplyToPackageOnly");
    UltraGridColumn ultraGridColumn88 = new UltraGridColumn("PackageLine");
    UltraGridColumn ultraGridColumn89 = new UltraGridColumn("GAAP");
    UltraGridColumn ultraGridColumn90 = new UltraGridColumn("QuotingLocationGuid");
    UltraGridColumn ultraGridColumn91 = new UltraGridColumn("CompanyCommissionNew");
    UltraGridColumn ultraGridColumn92 = new UltraGridColumn("CompanyCommissionRenewal");
    UltraGridColumn ultraGridColumn93 = new UltraGridColumn("EndOfMonthEffDatePlusDays");
    UltraGridColumn ultraGridColumn94 = new UltraGridColumn("EffectiveDatePlusDays");
    UltraGridColumn ultraGridColumn95 = new UltraGridColumn("UseEndOfMonthEffDatePlusDays");
    UltraGridColumn ultraGridColumn96 = new UltraGridColumn("Prod_KeepExpCommissionsOnRenewal");
    UltraGridColumn ultraGridColumn97 = new UltraGridColumn("ApplyPremiumEqualOrOver");
    UltraGridColumn ultraGridColumn98 = new UltraGridColumn("ApplyPremiumEqualOrLess");
    UltraGridColumn ultraGridColumn99 = new UltraGridColumn("ApplyTargetPremumEqualOrOver");
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    Appearance appearance71 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn100 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn101 = new UltraGridColumn("LineGUID", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn102 = new UltraGridColumn("lstLines_tblProducerLines");
    UltraGridBand ultraGridBand7 = new UltraGridBand("lstLines_tblProducerLines", 0);
    UltraGridColumn ultraGridColumn103 = new UltraGridColumn("ProducerLineID");
    UltraGridColumn ultraGridColumn104 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn105 = new UltraGridColumn("UsingDefaultCommNew");
    UltraGridColumn ultraGridColumn106 = new UltraGridColumn("UsingDefaultCommRenewal");
    UltraGridColumn ultraGridColumn107 = new UltraGridColumn("CommNew");
    UltraGridColumn ultraGridColumn108 = new UltraGridColumn("CommRenewal");
    UltraGridColumn ultraGridColumn109 = new UltraGridColumn("AccountCurrent");
    UltraGridColumn ultraGridColumn110 = new UltraGridColumn("DaysDue");
    UltraGridColumn ultraGridColumn111 = new UltraGridColumn("DaysDueEndorsement");
    UltraGridColumn ultraGridColumn112 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn113 = new UltraGridColumn("RenewalStatusID");
    UltraGridColumn ultraGridColumn114 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn115 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn116 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn117 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn118 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn119 = new UltraGridColumn("Blocked");
    UltraGridColumn ultraGridColumn120 = new UltraGridColumn("Entity");
    UltraGridColumn ultraGridColumn121 = new UltraGridColumn("ApplyToPackageOnly");
    UltraGridColumn ultraGridColumn122 = new UltraGridColumn("PackageLine");
    UltraGridColumn ultraGridColumn123 = new UltraGridColumn("GAAP");
    UltraGridColumn ultraGridColumn124 = new UltraGridColumn("QuotingLocationGuid");
    UltraGridColumn ultraGridColumn125 = new UltraGridColumn("CompanyCommissionNew");
    UltraGridColumn ultraGridColumn126 = new UltraGridColumn("CompanyCommissionRenewal");
    UltraGridColumn ultraGridColumn127 = new UltraGridColumn("EndOfMonthEffDatePlusDays");
    UltraGridColumn ultraGridColumn128 = new UltraGridColumn("EffectiveDatePlusDays");
    UltraGridColumn ultraGridColumn129 = new UltraGridColumn("UseEndOfMonthEffDatePlusDays");
    UltraGridColumn ultraGridColumn130 = new UltraGridColumn("Prod_KeepExpCommissionsOnRenewal");
    UltraGridColumn ultraGridColumn131 = new UltraGridColumn("ApplyPremiumEqualOrOver");
    UltraGridColumn ultraGridColumn132 = new UltraGridColumn("ApplyPremiumEqualOrLess");
    UltraGridColumn ultraGridColumn133 = new UltraGridColumn("ApplyTargetPremumEqualOrOver");
    Appearance appearance72 = new Appearance();
    Appearance appearance73 = new Appearance();
    Appearance appearance74 = new Appearance();
    Appearance appearance75 = new Appearance();
    Appearance appearance76 = new Appearance();
    Appearance appearance77 = new Appearance();
    Appearance appearance78 = new Appearance();
    Appearance appearance79 = new Appearance();
    Appearance appearance80 = new Appearance();
    Appearance appearance81 = new Appearance();
    Appearance appearance82 = new Appearance();
    Appearance appearance83 = new Appearance();
    UltraGridBand ultraGridBand8 = new UltraGridBand("tblClientOffices", -1);
    UltraGridColumn ultraGridColumn134 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn135 = new UltraGridColumn("OfficeGuid");
    UltraGridColumn ultraGridColumn136 = new UltraGridColumn("tblClientOffices_tblProducerLines");
    UltraGridBand ultraGridBand9 = new UltraGridBand("tblClientOffices_tblProducerLines", 0);
    UltraGridColumn ultraGridColumn137 = new UltraGridColumn("ProducerLineID");
    UltraGridColumn ultraGridColumn138 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn139 = new UltraGridColumn("UsingDefaultCommNew");
    UltraGridColumn ultraGridColumn140 = new UltraGridColumn("UsingDefaultCommRenewal");
    UltraGridColumn ultraGridColumn141 = new UltraGridColumn("CommNew");
    UltraGridColumn ultraGridColumn142 = new UltraGridColumn("CommRenewal");
    UltraGridColumn ultraGridColumn143 = new UltraGridColumn("AccountCurrent");
    UltraGridColumn ultraGridColumn144 = new UltraGridColumn("DaysDue");
    UltraGridColumn ultraGridColumn145 = new UltraGridColumn("DaysDueEndorsement");
    UltraGridColumn ultraGridColumn146 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn147 = new UltraGridColumn("RenewalStatusID");
    UltraGridColumn ultraGridColumn148 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn149 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn150 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn151 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn152 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn153 = new UltraGridColumn("Blocked");
    UltraGridColumn ultraGridColumn154 = new UltraGridColumn("Entity");
    UltraGridColumn ultraGridColumn155 = new UltraGridColumn("ApplyToPackageOnly");
    UltraGridColumn ultraGridColumn156 = new UltraGridColumn("PackageLine");
    UltraGridColumn ultraGridColumn157 = new UltraGridColumn("GAAP");
    UltraGridColumn ultraGridColumn158 = new UltraGridColumn("QuotingLocationGuid");
    UltraGridColumn ultraGridColumn159 = new UltraGridColumn("CompanyCommissionNew");
    UltraGridColumn ultraGridColumn160 = new UltraGridColumn("CompanyCommissionRenewal");
    UltraGridColumn ultraGridColumn161 = new UltraGridColumn("EndOfMonthEffDatePlusDays");
    UltraGridColumn ultraGridColumn162 = new UltraGridColumn("EffectiveDatePlusDays");
    UltraGridColumn ultraGridColumn163 = new UltraGridColumn("UseEndOfMonthEffDatePlusDays");
    UltraGridColumn ultraGridColumn164 = new UltraGridColumn("Prod_KeepExpCommissionsOnRenewal");
    UltraGridColumn ultraGridColumn165 = new UltraGridColumn("ApplyPremiumEqualOrOver");
    UltraGridColumn ultraGridColumn166 = new UltraGridColumn("ApplyPremiumEqualOrLess");
    UltraGridColumn ultraGridColumn167 = new UltraGridColumn("ApplyTargetPremumEqualOrOver");
    Appearance appearance84 = new Appearance();
    Appearance appearance85 = new Appearance();
    Appearance appearance86 = new Appearance();
    Appearance appearance87 = new Appearance();
    Appearance appearance88 = new Appearance();
    Appearance appearance89 = new Appearance();
    Appearance appearance90 = new Appearance();
    Appearance appearance91 = new Appearance();
    Appearance appearance92 = new Appearance();
    Appearance appearance93 = new Appearance();
    Appearance appearance94 = new Appearance();
    this.lblQuotingOffice = new UltraLabel();
    this.cboQuotingOffice = new MGASimpleComboBox();
    this.dsProducers = new dsProducersLinesStates();
    this.chkApplyToPackage = new MGACheckBox();
    this.labelProducerLocation = new UltraLabel();
    this.labelProducer = new UltraLabel();
    this.cboStates = new MGASimpleComboBox();
    this.cboPackages = new MGASimpleComboBox();
    this.cboLines = new MGASimpleComboBox();
    this.lblPackage = new UltraLabel();
    this.cboCompanies = new MGASimpleComboBox();
    this.ugbOther = new UltraGroupBox();
    this.numTargetPremiumGreater = new MGANumericEditor();
    this.Label1 = new Label();
    this.numPremiumLess = new MGANumericEditor();
    this.numPremiumGreater = new MGANumericEditor();
    this.lblPremiumLessThanEqualTo = new Label();
    this.lblPremiumGreaterEqualTo = new Label();
    this.gbOptions = new UltraGroupBox();
    this.txtEffectiveDatePlus = new MGATextBox();
    this.txtEndofMonthPlus = new MGATextBox();
    this.chkEffectiveDatePlus = new MGACheckBox();
    this.chkEndOfMonthPlus = new MGACheckBox();
    this.MgaCheckBox1 = new MGACheckBox();
    this.chkBlocked = new MGACheckBox();
    this.chkUseCompanyEndorsementDaysDue = new MGACheckBox();
    this.chkUseCompanyDaysDue = new MGACheckBox();
    this.txtEndorsementDaysDue = new MGATextBox();
    this.dtEffective = new MGADateTimePicker();
    this.cboRenewalStatus = new MGASimpleComboBox();
    this.dvRenewalStatus = new DataView();
    this.cbStatus = new MGASimpleComboBox();
    this.dvStatus = new DataView();
    this.chkAccountCurrent = new MGACheckBox();
    this.txtDaysDue = new MGATextBox();
    this.gbNew = new UltraGroupBox();
    this.numCompanyCommissionNew = new MGANumericEditor();
    this.txtNewFixed = new MGANumericEditor();
    this.chkDefaultNew = new MGACheckBox();
    this.lblDefaultNew = new UltraLabel();
    this.gbRenewal = new UltraGroupBox();
    this.chkKeepExpiringOnRenewal = new MGACheckBox();
    this.txtRenewalFixed = new MGANumericEditor();
    this.numCompanyCommissionRenewal = new MGANumericEditor();
    this.chkDefaultRenewal = new MGACheckBox();
    this.lblDefaultRenewal = new UltraLabel();
    this.ToolTip = new ToolTip(this.components);
    this.errProvider = new ErrorProvider(this.components);
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.UltraTabControl1 = new UltraTabControl();
    this.gridSetups = new UltraGrid();
    this.ddCompanies = new UltraDropDown();
    this.ddStates = new UltraDropDown();
    this.ddLines = new UltraDropDown();
    this.comboCompanyFilter = new MGASimpleComboBox();
    this.comboLineFilter = new MGASimpleComboBox();
    this.comboStateFilter = new MGASimpleComboBox();
    this.linkApplyFilter = new LinkLabel();
    this.dvCompanyFilter = new DataView();
    this.dvLineFilter = new DataView();
    this.dvStateFilter = new DataView();
    this.ddQuotingOffice = new UltraDropDown();
    UltraLabel ultraLabel1 = new UltraLabel();
    UltraLabel ultraLabel2 = new UltraLabel();
    UltraLabel ultraLabel3 = new UltraLabel();
    UltraLabel ultraLabel4 = new UltraLabel();
    UltraLabel ultraLabel5 = new UltraLabel();
    UltraLabel ultraLabel6 = new UltraLabel();
    UltraLabel ultraLabel7 = new UltraLabel();
    UltraLabel ultraLabel8 = new UltraLabel();
    UltraLabel ultraLabel9 = new UltraLabel();
    UltraLabel ultraLabel10 = new UltraLabel();
    UltraLabel ultraLabel11 = new UltraLabel();
    UltraLabel ultraLabel12 = new UltraLabel();
    UltraLabel ultraLabel13 = new UltraLabel();
    UltraLabel ultraLabel14 = new UltraLabel();
    UltraTabPageControl ultraTabPageControl1 = new UltraTabPageControl();
    UltraTabPageControl ultraTabPageControl2 = new UltraTabPageControl();
    UltraLabel ultraLabel15 = new UltraLabel();
    UltraLabel ultraLabel16 = new UltraLabel();
    UltraTabSharedControlsPage sharedControlsPage = new UltraTabSharedControlsPage();
    ((Control) ultraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.cboQuotingOffice).BeginInit();
    this.dsProducers.BeginInit();
    ((ISupportInitialize) this.chkApplyToPackage).BeginInit();
    ((ISupportInitialize) this.cboStates).BeginInit();
    ((ISupportInitialize) this.cboPackages).BeginInit();
    ((ISupportInitialize) this.cboLines).BeginInit();
    ((ISupportInitialize) this.cboCompanies).BeginInit();
    ((Control) ultraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.ugbOther).BeginInit();
    ((Control) this.ugbOther).SuspendLayout();
    ((ISupportInitialize) this.numTargetPremiumGreater).BeginInit();
    ((ISupportInitialize) this.numPremiumLess).BeginInit();
    ((ISupportInitialize) this.numPremiumGreater).BeginInit();
    ((ISupportInitialize) this.gbOptions).BeginInit();
    ((Control) this.gbOptions).SuspendLayout();
    ((ISupportInitialize) this.txtEffectiveDatePlus).BeginInit();
    ((ISupportInitialize) this.txtEndofMonthPlus).BeginInit();
    ((ISupportInitialize) this.chkEffectiveDatePlus).BeginInit();
    ((ISupportInitialize) this.chkEndOfMonthPlus).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox1).BeginInit();
    ((ISupportInitialize) this.chkBlocked).BeginInit();
    ((ISupportInitialize) this.chkUseCompanyEndorsementDaysDue).BeginInit();
    ((ISupportInitialize) this.chkUseCompanyDaysDue).BeginInit();
    ((ISupportInitialize) this.txtEndorsementDaysDue).BeginInit();
    ((ISupportInitialize) this.dtEffective).BeginInit();
    ((ISupportInitialize) this.cboRenewalStatus).BeginInit();
    this.dvRenewalStatus.BeginInit();
    ((ISupportInitialize) this.cbStatus).BeginInit();
    this.dvStatus.BeginInit();
    ((ISupportInitialize) this.chkAccountCurrent).BeginInit();
    ((ISupportInitialize) this.txtDaysDue).BeginInit();
    ((ISupportInitialize) this.gbNew).BeginInit();
    ((Control) this.gbNew).SuspendLayout();
    ((ISupportInitialize) this.numCompanyCommissionNew).BeginInit();
    ((ISupportInitialize) this.txtNewFixed).BeginInit();
    ((ISupportInitialize) this.chkDefaultNew).BeginInit();
    ((ISupportInitialize) this.gbRenewal).BeginInit();
    ((Control) this.gbRenewal).SuspendLayout();
    ((ISupportInitialize) this.chkKeepExpiringOnRenewal).BeginInit();
    ((ISupportInitialize) this.txtRenewalFixed).BeginInit();
    ((ISupportInitialize) this.numCompanyCommissionRenewal).BeginInit();
    ((ISupportInitialize) this.chkDefaultRenewal).BeginInit();
    ((ISupportInitialize) this.errProvider).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((ISupportInitialize) this.gridSetups).BeginInit();
    ((ISupportInitialize) this.ddCompanies).BeginInit();
    ((ISupportInitialize) this.ddStates).BeginInit();
    ((ISupportInitialize) this.ddLines).BeginInit();
    ((ISupportInitialize) this.comboCompanyFilter).BeginInit();
    ((ISupportInitialize) this.comboLineFilter).BeginInit();
    ((ISupportInitialize) this.comboStateFilter).BeginInit();
    this.dvCompanyFilter.BeginInit();
    this.dvLineFilter.BeginInit();
    this.dvStateFilter.BeginInit();
    ((ISupportInitialize) this.ddQuotingOffice).BeginInit();
    this.SuspendLayout();
    ((AutoSizeControlBase) ultraLabel1).AutoSize = true;
    ((ControlBase) ultraLabel1).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel1).Location = new Point(3, 49);
    ((Control) ultraLabel1).Name = "UltraLabel4";
    ((Control) ultraLabel1).Size = new Size(98, 15);
    ((Control) ultraLabel1).TabIndex = 19;
    ((ControlBase) ultraLabel1).Text = "Producer Location:";
    ((AutoSizeControlBase) ultraLabel2).AutoSize = true;
    ((ControlBase) ultraLabel2).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel2).Location = new Point(48 /*0x30*/, 19);
    ((Control) ultraLabel2).Name = "UltraLabel5";
    ((Control) ultraLabel2).Size = new Size(53, 15);
    ((Control) ultraLabel2).TabIndex = 17;
    ((ControlBase) ultraLabel2).Text = "Producer:";
    ((AutoSizeControlBase) ultraLabel3).AutoSize = true;
    ((ControlBase) ultraLabel3).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel3).Location = new Point(46, 78);
    ((Control) ultraLabel3).Name = "UltraLabel6";
    ((Control) ultraLabel3).Size = new Size(55, 15);
    ((Control) ultraLabel3).TabIndex = 21;
    ((ControlBase) ultraLabel3).Text = "Company:";
    ((AutoSizeControlBase) ultraLabel4).AutoSize = true;
    ((ControlBase) ultraLabel4).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel4).Location = new Point(72, 134);
    ((Control) ultraLabel4).Name = "UltraLabel7";
    ((Control) ultraLabel4).Size = new Size(29, 15);
    ((Control) ultraLabel4).TabIndex = 23;
    ((ControlBase) ultraLabel4).Text = "Line:";
    ((AutoSizeControlBase) ultraLabel5).AutoSize = true;
    ((ControlBase) ultraLabel5).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel5).Location = new Point(71, 162);
    ((Control) ultraLabel5).Name = "UltraLabel8";
    ((Control) ultraLabel5).Size = new Size(30, 15);
    ((Control) ultraLabel5).TabIndex = 25;
    ((ControlBase) ultraLabel5).Text = "State";
    ((AutoSizeControlBase) ultraLabel6).AutoSize = true;
    ((ControlBase) ultraLabel6).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel6).Location = new Point(49, 140);
    ((Control) ultraLabel6).Name = "Label11";
    ((Control) ultraLabel6).Size = new Size(39, 15);
    ((Control) ultraLabel6).TabIndex = 13;
    ((ControlBase) ultraLabel6).Text = "Status:";
    ((AutoSizeControlBase) ultraLabel7).AutoSize = true;
    ((ControlBase) ultraLabel7).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel7).Location = new Point(67, 55);
    ((Control) ultraLabel7).Name = "Label10";
    ((Control) ultraLabel7).Size = new Size(50, 15);
    ((Control) ultraLabel7).TabIndex = 145;
    ((ControlBase) ultraLabel7).Text = "Renewal:";
    ((AutoSizeControlBase) ultraLabel8).AutoSize = true;
    ((ControlBase) ultraLabel8).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel8).Location = new Point(29, 55);
    ((Control) ultraLabel8).Name = "Label2";
    ((Control) ultraLabel8).Size = new Size(105, 15);
    ((Control) ultraLabel8).TabIndex = 143;
    ((ControlBase) ultraLabel8).Text = "Default Comm New:";
    ((AutoSizeControlBase) ultraLabel9).AutoSize = true;
    ((ControlBase) ultraLabel9).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel9).Location = new Point(30, 81);
    ((Control) ultraLabel9).Name = "Label6";
    ((Control) ultraLabel9).Size = new Size(104, 15);
    ((Control) ultraLabel9).TabIndex = 146;
    ((ControlBase) ultraLabel9).Text = "Non-Default Comm:";
    ((AutoSizeControlBase) ultraLabel10).AutoSize = true;
    ((ControlBase) ultraLabel10).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel10).Location = new Point(13, 81);
    ((Control) ultraLabel10).Name = "Label7";
    ((Control) ultraLabel10).Size = new Size(104, 15);
    ((Control) ultraLabel10).TabIndex = 146;
    ((ControlBase) ultraLabel10).Text = "Non-Default Comm:";
    ((AutoSizeControlBase) ultraLabel11).AutoSize = true;
    ((ControlBase) ultraLabel11).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel11).Location = new Point(31 /*0x1F*/, 52);
    ((Control) ultraLabel11).Name = "Label9";
    ((Control) ultraLabel11).Size = new Size(56, 15);
    ((Control) ultraLabel11).TabIndex = 0;
    ((ControlBase) ultraLabel11).Text = "Days Due:";
    ((AutoSizeControlBase) ultraLabel12).AutoSize = true;
    ((ControlBase) ultraLabel12).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel12).Location = new Point(5, 80 /*0x50*/);
    ((Control) ultraLabel12).Name = "UltraLabel3";
    ((Control) ultraLabel12).Size = new Size(82, 15);
    ((Control) ultraLabel12).TabIndex = 19;
    ((ControlBase) ultraLabel12).Text = "End. Days Due:";
    ((AutoSizeControlBase) ultraLabel13).AutoSize = true;
    ((ControlBase) ultraLabel13).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel13).Location = new Point(37, 24);
    ((Control) ultraLabel13).Name = "UltraLabel2";
    ((Control) ultraLabel13).Size = new Size(51, 15);
    ((Control) ultraLabel13).TabIndex = 17;
    ((ControlBase) ultraLabel13).Text = "Effective:";
    ((AutoSizeControlBase) ultraLabel14).AutoSize = true;
    ((ControlBase) ultraLabel14).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel14).Location = new Point(7, 168);
    ((Control) ultraLabel14).Name = "UltraLabel1";
    ((Control) ultraLabel14).Size = new Size(85, 15);
    ((Control) ultraLabel14).TabIndex = 15;
    ((ControlBase) ultraLabel14).Text = "Renewal Status:";
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.lblQuotingOffice);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.cboQuotingOffice);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.chkApplyToPackage);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.labelProducerLocation);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.labelProducer);
    ((Control) ultraTabPageControl1).Controls.Add((Control) ultraLabel2);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.cboStates);
    ((Control) ultraTabPageControl1).Controls.Add((Control) ultraLabel1);
    ((Control) ultraTabPageControl1).Controls.Add((Control) ultraLabel5);
    ((Control) ultraTabPageControl1).Controls.Add((Control) ultraLabel3);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.cboPackages);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.cboLines);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.lblPackage);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.cboCompanies);
    ((Control) ultraTabPageControl1).Controls.Add((Control) ultraLabel4);
    ((Control) ultraTabPageControl1).Location = new Point(1, 26);
    ((Control) ultraTabPageControl1).Name = "tabAppliesTo";
    ((Control) ultraTabPageControl1).Size = new Size(696, 323);
    ((AutoSizeControlBase) this.lblQuotingOffice).AutoSize = true;
    ((ControlBase) this.lblQuotingOffice).BackColorInternal = Color.Transparent;
    ((Control) this.lblQuotingOffice).Location = new Point(21, 106);
    ((Control) this.lblQuotingOffice).Name = "lblQuotingOffice";
    ((Control) this.lblQuotingOffice).Size = new Size(80 /*0x50*/, 15);
    ((Control) this.lblQuotingOffice).TabIndex = 30;
    ((ControlBase) this.lblQuotingOffice).Text = "Quoting Office:";
    this.cboQuotingOffice.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboQuotingOffice).DataBindings.Add(new Binding("Value", (object) this.dsProducers, "tblProducerLines.QuotingLocationGuid", true));
    ((UltraGridBase) this.cboQuotingOffice).DataMember = "tblClientOffices";
    ((UltraGridBase) this.cboQuotingOffice).DataSource = (object) this.dsProducers;
    ((UltraDropDownBase) this.cboQuotingOffice).DisplayMember = "Location";
    this.cboQuotingOffice.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboQuotingOffice).Location = new Point(112 /*0x70*/, 103);
    this.cboQuotingOffice.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboQuotingOffice).Name = "cboQuotingOffice";
    this.cboQuotingOffice.NullText = "Any";
    ((Control) this.cboQuotingOffice).Size = new Size(524, 21);
    ((Control) this.cboQuotingOffice).TabIndex = 3;
    ((UltraControlBase) this.cboQuotingOffice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboQuotingOffice).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboQuotingOffice).ValueMember = "OfficeGuid";
    this.dsProducers.DataSetName = "dsProducersLinesStates";
    this.dsProducers.Locale = new CultureInfo("en-US");
    this.dsProducers.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkApplyToPackage).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.chkApplyToPackage).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkApplyToPackage).BackColorInternal = Color.Transparent;
    ((Control) this.chkApplyToPackage).DataBindings.Add(new Binding("Checked", (object) this.dsProducers, "tblProducerLines.ApplyToPackageOnly", true));
    ((UltraToggleEditorBase) this.chkApplyToPackage).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkApplyToPackage).Location = new Point(112 /*0x70*/, 187);
    this.chkApplyToPackage.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkApplyToPackage).Name = "chkApplyToPackage";
    ((Control) this.chkApplyToPackage).Size = new Size(138, 14);
    ((Control) this.chkApplyToPackage).TabIndex = 6;
    ((UltraToggleEditorBase) this.chkApplyToPackage).Text = "Apply to Package Only";
    ((UltraControlBase) this.chkApplyToPackage).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkApplyToPackage).UseOsThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.Transparent;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((AppearanceBase) appearance2).TextVAlignAsString = "Middle";
    ((ControlBase) this.labelProducerLocation).Appearance = (AppearanceBase) appearance2;
    this.labelProducerLocation.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.labelProducerLocation).Location = new Point(112 /*0x70*/, 45);
    ((Control) this.labelProducerLocation).Name = "labelProducerLocation";
    ((Control) this.labelProducerLocation).Size = new Size(524, 23);
    ((Control) this.labelProducerLocation).TabIndex = 1;
    ((ControlBase) this.labelProducerLocation).UseMnemonic = false;
    appearance3.BackColor = Color.Transparent;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((AppearanceBase) appearance3).TextVAlignAsString = "Middle";
    ((ControlBase) this.labelProducer).Appearance = (AppearanceBase) appearance3;
    this.labelProducer.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.labelProducer).Location = new Point(112 /*0x70*/, 15);
    ((Control) this.labelProducer).Name = "labelProducer";
    ((Control) this.labelProducer).Size = new Size(524, 23);
    ((Control) this.labelProducer).TabIndex = 0;
    ((ControlBase) this.labelProducer).UseMnemonic = false;
    this.cboStates.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboStates).DataBindings.Add(new Binding("Value", (object) this.dsProducers, "tblProducerLines.StateID", true));
    ((UltraGridBase) this.cboStates).DataMember = "lstStates";
    ((UltraGridBase) this.cboStates).DataSource = (object) this.dsProducers;
    ((UltraDropDownBase) this.cboStates).DisplayMember = "State";
    this.cboStates.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboStates).Location = new Point(112 /*0x70*/, 159);
    this.cboStates.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboStates).Name = "cboStates";
    this.cboStates.NullText = "Any";
    ((Control) this.cboStates).Size = new Size(524, 21);
    ((Control) this.cboStates).TabIndex = 5;
    ((UltraControlBase) this.cboStates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboStates).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboStates).ValueMember = "StateID";
    this.cboPackages.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboPackages).DataBindings.Add(new Binding("Value", (object) this.dsProducers, "tblProducerLines.PackageLine", true));
    ((UltraGridBase) this.cboPackages).DataMember = "lstPackages";
    ((UltraGridBase) this.cboPackages).DataSource = (object) this.dsProducers;
    ((UltraDropDownBase) this.cboPackages).DisplayMember = "LineName";
    this.cboPackages.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboPackages).Location = new Point(326, 184);
    this.cboPackages.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboPackages).Name = "cboPackages";
    this.cboPackages.NullText = "Any";
    ((Control) this.cboPackages).Size = new Size(310, 21);
    ((Control) this.cboPackages).TabIndex = 7;
    ((UltraControlBase) this.cboPackages).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPackages).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboPackages).ValueMember = "LineGUID";
    this.cboLines.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLines).DataBindings.Add(new Binding("Value", (object) this.dsProducers, "tblProducerLines.LineGuid", true));
    ((UltraGridBase) this.cboLines).DataMember = "lstLines";
    ((UltraGridBase) this.cboLines).DataSource = (object) this.dsProducers;
    ((UltraDropDownBase) this.cboLines).DisplayMember = "LineName";
    this.cboLines.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboLines).Location = new Point(112 /*0x70*/, 131);
    this.cboLines.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLines).Name = "cboLines";
    this.cboLines.NullText = "Any";
    ((Control) this.cboLines).Size = new Size(524, 21);
    ((Control) this.cboLines).TabIndex = 4;
    ((UltraControlBase) this.cboLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLines).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLines).ValueMember = "LineGUID";
    ((AutoSizeControlBase) this.lblPackage).AutoSize = true;
    ((ControlBase) this.lblPackage).BackColorInternal = Color.Transparent;
    ((Control) this.lblPackage).Location = new Point(271, 187);
    ((Control) this.lblPackage).Name = "lblPackage";
    ((Control) this.lblPackage).Size = new Size(49, 15);
    ((Control) this.lblPackage).TabIndex = 23;
    ((ControlBase) this.lblPackage).Text = "Package:";
    this.cboCompanies.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboCompanies).DataBindings.Add(new Binding("Value", (object) this.dsProducers, "tblProducerLines.CompanyLocationGuid", true));
    ((UltraGridBase) this.cboCompanies).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.cboCompanies).DataSource = (object) this.dsProducers;
    ((UltraDropDownBase) this.cboCompanies).DisplayMember = "Name";
    this.cboCompanies.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboCompanies).Location = new Point(112 /*0x70*/, 75);
    this.cboCompanies.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompanies).Name = "cboCompanies";
    this.cboCompanies.NullText = "Any";
    ((Control) this.cboCompanies).Size = new Size(524, 21);
    ((Control) this.cboCompanies).TabIndex = 2;
    ((UltraControlBase) this.cboCompanies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanies).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompanies).ValueMember = "CompanyLocationGUID";
    ((Control) ultraTabPageControl2).Controls.Add((Control) this.ugbOther);
    ((Control) ultraTabPageControl2).Controls.Add((Control) this.gbOptions);
    ((Control) ultraTabPageControl2).Controls.Add((Control) this.gbNew);
    ((Control) ultraTabPageControl2).Controls.Add((Control) this.gbRenewal);
    ((Control) ultraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) ultraTabPageControl2).Name = "tabSettings";
    ((Control) ultraTabPageControl2).Size = new Size(696, 323);
    appearance4.BackColor = Color.FromArgb(246, 250, 253);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ugbOther.ContentAreaAppearance = (AppearanceBase) appearance4;
    ((Control) this.ugbOther).Controls.Add((Control) this.numTargetPremiumGreater);
    ((Control) this.ugbOther).Controls.Add((Control) this.Label1);
    ((Control) this.ugbOther).Controls.Add((Control) this.numPremiumLess);
    ((Control) this.ugbOther).Controls.Add((Control) this.numPremiumGreater);
    ((Control) this.ugbOther).Controls.Add((Control) this.lblPremiumLessThanEqualTo);
    ((Control) this.ugbOther).Controls.Add((Control) this.lblPremiumGreaterEqualTo);
    ((Control) this.ugbOther).Enabled = false;
    appearance5.ForeColor = Color.Black;
    this.ugbOther.HeaderAppearance = (AppearanceBase) appearance5;
    ((Control) this.ugbOther).Location = new Point(254, 208 /*0xD0*/);
    ((Control) this.ugbOther).Name = "ugbOther";
    ((Control) this.ugbOther).Size = new Size(439, 113);
    ((Control) this.ugbOther).TabIndex = 150;
    this.ugbOther.Text = "Other Options";
    this.ugbOther.ViewStyle = (GroupBoxViewStyle) 3;
    appearance6.BackColorDisabled = Color.Gainsboro;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numTargetPremiumGreater).Appearance = (AppearanceBase) appearance6;
    ((Control) this.numTargetPremiumGreater).DataBindings.Add(new Binding("Value", (object) this.dsProducers, "tblProducerLines.ApplyTargetPremumEqualOrOver", true));
    ((UltraNumericEditorBase) this.numTargetPremiumGreater).FormatString = "c";
    ((Control) this.numTargetPremiumGreater).Location = new Point(292, 75);
    this.numTargetPremiumGreater.MaskInput = "nnnnnnnnnnn.nn";
    this.numTargetPremiumGreater.MaxValue = (object) 99999999999.99;
    this.numTargetPremiumGreater.MGAStyle = MGAStyles.Blue;
    this.numTargetPremiumGreater.MinValue = (object) 0;
    ((Control) this.numTargetPremiumGreater).Name = "numTargetPremiumGreater";
    this.numTargetPremiumGreater.Nullable = true;
    this.numTargetPremiumGreater.NumericType = (NumericType) 2;
    ((Control) this.numTargetPremiumGreater).Size = new Size(103, 20);
    ((Control) this.numTargetPremiumGreater).TabIndex = 13;
    ((UltraWinEditorMaskedControlBase) this.numTargetPremiumGreater).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numTargetPremiumGreater).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numTargetPremiumGreater).UseOsThemes = (DefaultableBoolean) 2;
    this.numTargetPremiumGreater.Value = (object) null;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(13, 79);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(272, 13);
    this.Label1.TabIndex = 12;
    this.Label1.Text = "Apply when target premium is greater than or equal to:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    appearance7.BackColorDisabled = Color.Gainsboro;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numPremiumLess).Appearance = (AppearanceBase) appearance7;
    ((Control) this.numPremiumLess).DataBindings.Add(new Binding("Value", (object) this.dsProducers, "tblProducerLines.ApplyPremiumEqualOrLess", true));
    ((UltraNumericEditorBase) this.numPremiumLess).FormatString = "c";
    ((Control) this.numPremiumLess).Location = new Point(292, 50);
    this.numPremiumLess.MaskInput = "nnnnnnnnnnn.nn";
    this.numPremiumLess.MaxValue = (object) 99999999999.99;
    this.numPremiumLess.MGAStyle = MGAStyles.Blue;
    this.numPremiumLess.MinValue = (object) 0;
    ((Control) this.numPremiumLess).Name = "numPremiumLess";
    this.numPremiumLess.Nullable = true;
    this.numPremiumLess.NumericType = (NumericType) 2;
    ((Control) this.numPremiumLess).Size = new Size(103, 20);
    ((Control) this.numPremiumLess).TabIndex = 11;
    ((UltraWinEditorMaskedControlBase) this.numPremiumLess).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numPremiumLess).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numPremiumLess).UseOsThemes = (DefaultableBoolean) 2;
    this.numPremiumLess.Value = (object) null;
    appearance8.BackColorDisabled = Color.Gainsboro;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numPremiumGreater).Appearance = (AppearanceBase) appearance8;
    ((Control) this.numPremiumGreater).DataBindings.Add(new Binding("Value", (object) this.dsProducers, "tblProducerLines.ApplyPremiumEqualOrOver", true));
    ((UltraNumericEditorBase) this.numPremiumGreater).FormatString = "c";
    ((Control) this.numPremiumGreater).Location = new Point(292, 25);
    this.numPremiumGreater.MaskInput = "nnnnnnnnnnn.nn";
    this.numPremiumGreater.MaxValue = (object) new Decimal(new int[4]
    {
      1316134911,
      2328,
      0,
      131072 /*0x020000*/
    });
    this.numPremiumGreater.MGAStyle = MGAStyles.Blue;
    this.numPremiumGreater.MinValue = (object) 0;
    ((Control) this.numPremiumGreater).Name = "numPremiumGreater";
    this.numPremiumGreater.Nullable = true;
    this.numPremiumGreater.NumericType = (NumericType) 2;
    ((Control) this.numPremiumGreater).Size = new Size(103, 20);
    ((Control) this.numPremiumGreater).TabIndex = 10;
    ((UltraWinEditorMaskedControlBase) this.numPremiumGreater).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numPremiumGreater).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numPremiumGreater).UseOsThemes = (DefaultableBoolean) 2;
    this.numPremiumGreater.Value = (object) null;
    this.lblPremiumLessThanEqualTo.AutoSize = true;
    this.lblPremiumLessThanEqualTo.BackColor = Color.Transparent;
    this.lblPremiumLessThanEqualTo.Location = new Point(27, 54);
    this.lblPremiumLessThanEqualTo.Name = "lblPremiumLessThanEqualTo";
    this.lblPremiumLessThanEqualTo.Size = new Size(221, 13);
    this.lblPremiumLessThanEqualTo.TabIndex = 8;
    this.lblPremiumLessThanEqualTo.Text = "Apply when premium is less than or equal to:";
    this.lblPremiumLessThanEqualTo.TextAlign = ContentAlignment.MiddleRight;
    this.lblPremiumGreaterEqualTo.AutoSize = true;
    this.lblPremiumGreaterEqualTo.BackColor = Color.Transparent;
    this.lblPremiumGreaterEqualTo.Location = new Point(9, 29);
    this.lblPremiumGreaterEqualTo.Name = "lblPremiumGreaterEqualTo";
    this.lblPremiumGreaterEqualTo.Size = new Size(239, 13);
    this.lblPremiumGreaterEqualTo.TabIndex = 6;
    this.lblPremiumGreaterEqualTo.Text = "Apply when premium is greater than or equal to:";
    this.lblPremiumGreaterEqualTo.TextAlign = ContentAlignment.MiddleRight;
    appearance9.BackColor = Color.FromArgb(246, 250, 253);
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gbOptions.ContentAreaAppearance = (AppearanceBase) appearance9;
    ((Control) this.gbOptions).Controls.Add((Control) this.txtEffectiveDatePlus);
    ((Control) this.gbOptions).Controls.Add((Control) this.txtEndofMonthPlus);
    ((Control) this.gbOptions).Controls.Add((Control) this.chkEffectiveDatePlus);
    ((Control) this.gbOptions).Controls.Add((Control) this.chkEndOfMonthPlus);
    ((Control) this.gbOptions).Controls.Add((Control) this.MgaCheckBox1);
    ((Control) this.gbOptions).Controls.Add((Control) this.chkBlocked);
    ((Control) this.gbOptions).Controls.Add((Control) this.chkUseCompanyEndorsementDaysDue);
    ((Control) this.gbOptions).Controls.Add((Control) this.chkUseCompanyDaysDue);
    ((Control) this.gbOptions).Controls.Add((Control) this.txtEndorsementDaysDue);
    ((Control) this.gbOptions).Controls.Add((Control) ultraLabel12);
    ((Control) this.gbOptions).Controls.Add((Control) this.dtEffective);
    ((Control) this.gbOptions).Controls.Add((Control) ultraLabel13);
    ((Control) this.gbOptions).Controls.Add((Control) this.cboRenewalStatus);
    ((Control) this.gbOptions).Controls.Add((Control) ultraLabel14);
    ((Control) this.gbOptions).Controls.Add((Control) this.cbStatus);
    ((Control) this.gbOptions).Controls.Add((Control) this.chkAccountCurrent);
    ((Control) this.gbOptions).Controls.Add((Control) this.txtDaysDue);
    ((Control) this.gbOptions).Controls.Add((Control) ultraLabel11);
    ((Control) this.gbOptions).Controls.Add((Control) ultraLabel6);
    ((Control) this.gbOptions).Enabled = false;
    appearance10.ForeColor = Color.Black;
    this.gbOptions.HeaderAppearance = (AppearanceBase) appearance10;
    ((Control) this.gbOptions).Location = new Point(16 /*0x10*/, 13);
    ((Control) this.gbOptions).Name = "gbOptions";
    ((Control) this.gbOptions).Size = new Size(232, 307);
    ((Control) this.gbOptions).TabIndex = 2;
    this.gbOptions.Text = "Options";
    this.gbOptions.ViewStyle = (GroupBoxViewStyle) 3;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEffectiveDatePlus).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.txtEffectiveDatePlus).BackColor = Color.White;
    ((Control) this.txtEffectiveDatePlus).DataBindings.Add(new Binding("Text", (object) this.dsProducers, "tblProducerLines.EffectiveDatePlusDays", true));
    ((Control) this.txtEffectiveDatePlus).Location = new Point(119, 278);
    this.txtEffectiveDatePlus.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEffectiveDatePlus).Name = "txtEffectiveDatePlus";
    ((Control) this.txtEffectiveDatePlus).Size = new Size(31 /*0x1F*/, 20);
    ((Control) this.txtEffectiveDatePlus).TabIndex = 24;
    ((UltraControlBase) this.txtEffectiveDatePlus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEffectiveDatePlus).UseOsThemes = (DefaultableBoolean) 2;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEndofMonthPlus).Appearance = (AppearanceBase) appearance12;
    ((TextEditorControlBase) this.txtEndofMonthPlus).BackColor = Color.White;
    ((Control) this.txtEndofMonthPlus).DataBindings.Add(new Binding("Text", (object) this.dsProducers, "tblProducerLines.EndOfMonthEffDatePlusDays", true));
    ((Control) this.txtEndofMonthPlus).Location = new Point(172, 259);
    this.txtEndofMonthPlus.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEndofMonthPlus).Name = "txtEndofMonthPlus";
    ((Control) this.txtEndofMonthPlus).Size = new Size(31 /*0x1F*/, 20);
    ((Control) this.txtEndofMonthPlus).TabIndex = 23;
    ((UltraControlBase) this.txtEndofMonthPlus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEndofMonthPlus).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkEffectiveDatePlus).Appearance = (AppearanceBase) appearance13;
    ((UltraToggleEditorBase) this.chkEffectiveDatePlus).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkEffectiveDatePlus).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkEffectiveDatePlus).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkEffectiveDatePlus).Location = new Point(8, 277);
    this.chkEffectiveDatePlus.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkEffectiveDatePlus).Name = "chkEffectiveDatePlus";
    ((Control) this.chkEffectiveDatePlus).Size = new Size(105, 24);
    ((Control) this.chkEffectiveDatePlus).TabIndex = 22;
    ((UltraToggleEditorBase) this.chkEffectiveDatePlus).Text = "Effective Date +";
    ((UltraControlBase) this.chkEffectiveDatePlus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkEffectiveDatePlus).UseOsThemes = (DefaultableBoolean) 2;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkEndOfMonthPlus).Appearance = (AppearanceBase) appearance14;
    ((UltraToggleEditorBase) this.chkEndOfMonthPlus).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkEndOfMonthPlus).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkEndOfMonthPlus).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkEndOfMonthPlus).Location = new Point(8, 258);
    this.chkEndOfMonthPlus.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkEndOfMonthPlus).Name = "chkEndOfMonthPlus";
    ((Control) this.chkEndOfMonthPlus).Size = new Size(158, 24);
    ((Control) this.chkEndOfMonthPlus).TabIndex = 21;
    ((UltraToggleEditorBase) this.chkEndOfMonthPlus).Text = "End of Month of Eff Date +";
    ((UltraControlBase) this.chkEndOfMonthPlus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkEndOfMonthPlus).UseOsThemes = (DefaultableBoolean) 2;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Appearance = (AppearanceBase) appearance15;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox1).Location = new Point(98, 216);
    this.MgaCheckBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaCheckBox1).Name = "MgaCheckBox1";
    ((Control) this.MgaCheckBox1).Size = new Size(69, 24);
    ((Control) this.MgaCheckBox1).TabIndex = 7;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Text = "GAAP";
    ((UltraControlBase) this.MgaCheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkBlocked).Appearance = (AppearanceBase) appearance16;
    ((UltraToggleEditorBase) this.chkBlocked).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkBlocked).BackColorInternal = Color.Transparent;
    ((Control) this.chkBlocked).DataBindings.Add(new Binding("Checked", (object) this.dsProducers, "tblProducerLines.Blocked", true));
    ((UltraToggleEditorBase) this.chkBlocked).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkBlocked).Location = new Point(98, 192 /*0xC0*/);
    this.chkBlocked.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkBlocked).Name = "chkBlocked";
    ((Control) this.chkBlocked).Size = new Size(69, 24);
    ((Control) this.chkBlocked).TabIndex = 6;
    ((UltraToggleEditorBase) this.chkBlocked).Text = "Blocked";
    ((UltraControlBase) this.chkBlocked).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkBlocked).UseOsThemes = (DefaultableBoolean) 2;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseCompanyEndorsementDaysDue).Appearance = (AppearanceBase) appearance17;
    ((UltraToggleEditorBase) this.chkUseCompanyEndorsementDaysDue).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseCompanyEndorsementDaysDue).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseCompanyEndorsementDaysDue).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseCompanyEndorsementDaysDue).Location = new Point(135, 81);
    this.chkUseCompanyEndorsementDaysDue.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkUseCompanyEndorsementDaysDue).Name = "chkUseCompanyEndorsementDaysDue";
    ((Control) this.chkUseCompanyEndorsementDaysDue).Size = new Size(104, 14);
    ((Control) this.chkUseCompanyEndorsementDaysDue).TabIndex = 2;
    ((UltraToggleEditorBase) this.chkUseCompanyEndorsementDaysDue).Text = "Use Company";
    ((UltraControlBase) this.chkUseCompanyEndorsementDaysDue).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUseCompanyEndorsementDaysDue).UseOsThemes = (DefaultableBoolean) 2;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance18.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseCompanyDaysDue).Appearance = (AppearanceBase) appearance18;
    ((UltraToggleEditorBase) this.chkUseCompanyDaysDue).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseCompanyDaysDue).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseCompanyDaysDue).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseCompanyDaysDue).Location = new Point(135, 52);
    this.chkUseCompanyDaysDue.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkUseCompanyDaysDue).Name = "chkUseCompanyDaysDue";
    ((Control) this.chkUseCompanyDaysDue).Size = new Size(104, 14);
    ((Control) this.chkUseCompanyDaysDue).TabIndex = 1;
    ((UltraToggleEditorBase) this.chkUseCompanyDaysDue).Text = "Use Company";
    ((UltraControlBase) this.chkUseCompanyDaysDue).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUseCompanyDaysDue).UseOsThemes = (DefaultableBoolean) 2;
    appearance19.BackColor = Color.White;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance19.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEndorsementDaysDue).Appearance = (AppearanceBase) appearance19;
    ((TextEditorControlBase) this.txtEndorsementDaysDue).BackColor = Color.White;
    ((Control) this.txtEndorsementDaysDue).DataBindings.Add(new Binding("Text", (object) this.dsProducers, "tblProducerLines.DaysDueEndorsement", true));
    ((Control) this.txtEndorsementDaysDue).Location = new Point(98, 77);
    this.txtEndorsementDaysDue.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEndorsementDaysDue).Name = "txtEndorsementDaysDue";
    ((Control) this.txtEndorsementDaysDue).Size = new Size(31 /*0x1F*/, 20);
    ((Control) this.txtEndorsementDaysDue).TabIndex = 20;
    ((UltraControlBase) this.txtEndorsementDaysDue).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEndorsementDaysDue).UseOsThemes = (DefaultableBoolean) 2;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtEffective.Appearance = (AppearanceBase) appearance20;
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
    this.dtEffective.ButtonAppearance = (AppearanceBase) appearance21;
    ((Control) this.dtEffective).DataBindings.Add(new Binding("Value", (object) this.dsProducers, "tblProducerLines.Effective", true));
    this.dtEffective.DateTime = new DateTime(2021, 3, 1, 0, 0, 0, 0);
    ((Control) this.dtEffective).Location = new Point(98, 21);
    this.dtEffective.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtEffective).Name = "dtEffective";
    ((Control) this.dtEffective).Size = new Size(98, 20);
    ((Control) this.dtEffective).TabIndex = 0;
    ((UltraControlBase) this.dtEffective).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEffective).UseOsThemes = (DefaultableBoolean) 2;
    this.dtEffective.Value = (object) new DateTime(2021, 3, 1, 0, 0, 0, 0);
    this.cboRenewalStatus.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboRenewalStatus).DataBindings.Add(new Binding("Value", (object) this.dsProducers, "tblProducerLines.RenewalStatusID", true));
    ((UltraGridBase) this.cboRenewalStatus).DataSource = (object) this.dvRenewalStatus;
    ((UltraDropDownBase) this.cboRenewalStatus).DisplayMember = "Status";
    this.cboRenewalStatus.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboRenewalStatus).Location = new Point(98, 165);
    this.cboRenewalStatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboRenewalStatus).Name = "cboRenewalStatus";
    ((Control) this.cboRenewalStatus).Size = new Size(119, 21);
    ((Control) this.cboRenewalStatus).TabIndex = 5;
    ((UltraControlBase) this.cboRenewalStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboRenewalStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboRenewalStatus).ValueMember = "StatusID";
    this.dvRenewalStatus.Table = (DataTable) this.dsProducers.lstStatus;
    this.cbStatus.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbStatus).DataBindings.Add(new Binding("Value", (object) this.dsProducers, "tblProducerLines.StatusID", true));
    ((UltraGridBase) this.cbStatus).DataSource = (object) this.dvStatus;
    ((UltraDropDownBase) this.cbStatus).DisplayMember = "Status";
    this.cbStatus.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbStatus).Location = new Point(98, 137);
    this.cbStatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbStatus).Name = "cbStatus";
    ((Control) this.cbStatus).Size = new Size(119, 21);
    ((Control) this.cbStatus).TabIndex = 4;
    ((UltraControlBase) this.cbStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbStatus).ValueMember = "StatusID";
    this.dvStatus.Table = (DataTable) this.dsProducers.lstStatus;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance22.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkAccountCurrent).Appearance = (AppearanceBase) appearance22;
    ((UltraToggleEditorBase) this.chkAccountCurrent).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkAccountCurrent).BackColorInternal = Color.Transparent;
    ((Control) this.chkAccountCurrent).DataBindings.Add(new Binding("Checked", (object) this.dsProducers, "tblProducerLines.AccountCurrent", true));
    ((UltraToggleEditorBase) this.chkAccountCurrent).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkAccountCurrent).Location = new Point(98, 105);
    this.chkAccountCurrent.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkAccountCurrent).Name = "chkAccountCurrent";
    ((Control) this.chkAccountCurrent).Size = new Size(105, 24);
    ((Control) this.chkAccountCurrent).TabIndex = 3;
    ((UltraToggleEditorBase) this.chkAccountCurrent).Text = "Account Current";
    ((UltraControlBase) this.chkAccountCurrent).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkAccountCurrent).UseOsThemes = (DefaultableBoolean) 2;
    appearance23.BackColor = Color.White;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance23.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDaysDue).Appearance = (AppearanceBase) appearance23;
    ((TextEditorControlBase) this.txtDaysDue).BackColor = Color.White;
    ((Control) this.txtDaysDue).DataBindings.Add(new Binding("Text", (object) this.dsProducers, "tblProducerLines.DaysDue", true));
    ((Control) this.txtDaysDue).Location = new Point(98, 49);
    this.txtDaysDue.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtDaysDue).Name = "txtDaysDue";
    ((Control) this.txtDaysDue).Size = new Size(31 /*0x1F*/, 20);
    ((Control) this.txtDaysDue).TabIndex = 1;
    ((UltraControlBase) this.txtDaysDue).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDaysDue).UseOsThemes = (DefaultableBoolean) 2;
    appearance24.BackColor = Color.FromArgb(246, 250, 253);
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gbNew.ContentAreaAppearance = (AppearanceBase) appearance24;
    ((Control) this.gbNew).Controls.Add((Control) ultraLabel15);
    ((Control) this.gbNew).Controls.Add((Control) this.numCompanyCommissionNew);
    ((Control) this.gbNew).Controls.Add((Control) this.txtNewFixed);
    ((Control) this.gbNew).Controls.Add((Control) this.chkDefaultNew);
    ((Control) this.gbNew).Controls.Add((Control) ultraLabel9);
    ((Control) this.gbNew).Controls.Add((Control) this.lblDefaultNew);
    ((Control) this.gbNew).Controls.Add((Control) ultraLabel8);
    ((Control) this.gbNew).Enabled = false;
    appearance25.ForeColor = Color.Black;
    this.gbNew.HeaderAppearance = (AppearanceBase) appearance25;
    ((Control) this.gbNew).Location = new Point(254, 13);
    ((Control) this.gbNew).Name = "gbNew";
    ((Control) this.gbNew).Size = new Size(228, 186);
    ((Control) this.gbNew).TabIndex = 3;
    this.gbNew.Text = "New Business";
    this.gbNew.ViewStyle = (GroupBoxViewStyle) 3;
    ((AutoSizeControlBase) ultraLabel15).AutoSize = true;
    ((ControlBase) ultraLabel15).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel15).Location = new Point(16 /*0x10*/, 107);
    ((Control) ultraLabel15).Name = "lblCompanyCommissionNew";
    ((Control) ultraLabel15).Size = new Size(118, 15);
    ((Control) ultraLabel15).TabIndex = 149;
    ((ControlBase) ultraLabel15).Text = "Company Commission:";
    appearance26.BackColorDisabled = Color.Gainsboro;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numCompanyCommissionNew).Appearance = (AppearanceBase) appearance26;
    ((Control) this.numCompanyCommissionNew).DataBindings.Add(new Binding("Value", (object) this.dsProducers, "tblProducerLines.CompanyCommissionNew", true));
    ((UltraNumericEditorBase) this.numCompanyCommissionNew).FormatString = "#,##0.00## %";
    ((Control) this.numCompanyCommissionNew).Location = new Point(141, 104);
    this.numCompanyCommissionNew.MaskInput = "n.nnnnnnnnn";
    this.numCompanyCommissionNew.MaxValue = (object) 1;
    this.numCompanyCommissionNew.MGAStyle = MGAStyles.Blue;
    this.numCompanyCommissionNew.MinValue = (object) 0;
    ((Control) this.numCompanyCommissionNew).Name = "numCompanyCommissionNew";
    this.numCompanyCommissionNew.Nullable = true;
    this.numCompanyCommissionNew.NumericType = (NumericType) 1;
    ((Control) this.numCompanyCommissionNew).Size = new Size(69, 20);
    ((Control) this.numCompanyCommissionNew).TabIndex = 3;
    ((UltraWinEditorMaskedControlBase) this.numCompanyCommissionNew).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numCompanyCommissionNew).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numCompanyCommissionNew).UseOsThemes = (DefaultableBoolean) 2;
    appearance27.BackColorDisabled = Color.Gainsboro;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtNewFixed).Appearance = (AppearanceBase) appearance27;
    ((Control) this.txtNewFixed).DataBindings.Add(new Binding("Value", (object) this.dsProducers, "tblProducerLines.CommNew", true));
    ((UltraNumericEditorBase) this.txtNewFixed).FormatString = "#,##0.00## %";
    ((Control) this.txtNewFixed).Location = new Point(141, 78);
    this.txtNewFixed.MaskInput = "n.nnnnnnnnn";
    this.txtNewFixed.MaxValue = (object) 1;
    this.txtNewFixed.MGAStyle = MGAStyles.Blue;
    this.txtNewFixed.MinValue = (object) 0;
    ((Control) this.txtNewFixed).Name = "txtNewFixed";
    this.txtNewFixed.Nullable = true;
    this.txtNewFixed.NumericType = (NumericType) 1;
    ((Control) this.txtNewFixed).Size = new Size(69, 20);
    ((Control) this.txtNewFixed).TabIndex = 2;
    ((UltraWinEditorMaskedControlBase) this.txtNewFixed).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.txtNewFixed).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNewFixed).UseOsThemes = (DefaultableBoolean) 2;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance28.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDefaultNew).Appearance = (AppearanceBase) appearance28;
    ((UltraToggleEditorBase) this.chkDefaultNew).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDefaultNew).BackColorInternal = Color.Transparent;
    ((Control) this.chkDefaultNew).DataBindings.Add(new Binding("Checked", (object) this.dsProducers, "tblProducerLines.UsingDefaultCommNew", true));
    ((UltraToggleEditorBase) this.chkDefaultNew).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDefaultNew).Location = new Point(15, 24);
    this.chkDefaultNew.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkDefaultNew).Name = "chkDefaultNew";
    ((Control) this.chkDefaultNew).Size = new Size(119, 14);
    ((Control) this.chkDefaultNew).TabIndex = 0;
    ((UltraToggleEditorBase) this.chkDefaultNew).Text = "Use Default Comm";
    ((UltraControlBase) this.chkDefaultNew).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDefaultNew).UseOsThemes = (DefaultableBoolean) 2;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblDefaultNew).Appearance = (AppearanceBase) appearance29;
    ((ControlBase) this.lblDefaultNew).BackColorInternal = Color.Transparent;
    this.lblDefaultNew.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblDefaultNew).Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblDefaultNew).Location = new Point(141, 52);
    ((Control) this.lblDefaultNew).Name = "lblDefaultNew";
    ((Control) this.lblDefaultNew).Size = new Size(69, 21);
    ((Control) this.lblDefaultNew).TabIndex = 1;
    appearance30.BackColor = Color.FromArgb(246, 250, 253);
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gbRenewal.ContentAreaAppearance = (AppearanceBase) appearance30;
    ((Control) this.gbRenewal).Controls.Add((Control) this.chkKeepExpiringOnRenewal);
    ((Control) this.gbRenewal).Controls.Add((Control) ultraLabel16);
    ((Control) this.gbRenewal).Controls.Add((Control) this.txtRenewalFixed);
    ((Control) this.gbRenewal).Controls.Add((Control) this.numCompanyCommissionRenewal);
    ((Control) this.gbRenewal).Controls.Add((Control) this.chkDefaultRenewal);
    ((Control) this.gbRenewal).Controls.Add((Control) ultraLabel10);
    ((Control) this.gbRenewal).Controls.Add((Control) ultraLabel7);
    ((Control) this.gbRenewal).Controls.Add((Control) this.lblDefaultRenewal);
    ((Control) this.gbRenewal).Enabled = false;
    appearance31.ForeColor = Color.Black;
    this.gbRenewal.HeaderAppearance = (AppearanceBase) appearance31;
    ((Control) this.gbRenewal).Location = new Point(488, 13);
    ((Control) this.gbRenewal).Name = "gbRenewal";
    ((Control) this.gbRenewal).Size = new Size(206, 186);
    ((Control) this.gbRenewal).TabIndex = 4;
    this.gbRenewal.Text = "Renewal";
    this.gbRenewal.ViewStyle = (GroupBoxViewStyle) 3;
    appearance32.BorderColor = Color.Gray;
    appearance32.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkKeepExpiringOnRenewal).Appearance = (AppearanceBase) appearance32;
    ((UltraToggleEditorBase) this.chkKeepExpiringOnRenewal).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkKeepExpiringOnRenewal).BackColorInternal = Color.Transparent;
    ((Control) this.chkKeepExpiringOnRenewal).DataBindings.Add(new Binding("Checked", (object) this.dsProducers, "tblProducerLines.Prod_KeepExpCommissionsOnRenewal", true));
    ((UltraToggleEditorBase) this.chkKeepExpiringOnRenewal).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkKeepExpiringOnRenewal).Location = new Point(6, 137);
    ((Control) this.chkKeepExpiringOnRenewal).Name = "chkKeepExpiringOnRenewal";
    ((Control) this.chkKeepExpiringOnRenewal).Size = new Size(194, 40);
    ((Control) this.chkKeepExpiringOnRenewal).TabIndex = 153;
    ((UltraToggleEditorBase) this.chkKeepExpiringOnRenewal).Text = "Keep Expiring Policy Commissions on Renewal";
    ((UltraControlBase) this.chkKeepExpiringOnRenewal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkKeepExpiringOnRenewal).UseOsThemes = (DefaultableBoolean) 2;
    ((AutoSizeControlBase) ultraLabel16).AutoSize = true;
    ((ControlBase) ultraLabel16).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel16).Location = new Point(27, 107);
    ((Control) ultraLabel16).Name = "lblCompanyCommissionRenewal";
    ((Control) ultraLabel16).Size = new Size(90, 15);
    ((Control) ultraLabel16).TabIndex = 151;
    ((ControlBase) ultraLabel16).Text = "Company Comm:";
    appearance33.BackColorDisabled = Color.Gainsboro;
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtRenewalFixed).Appearance = (AppearanceBase) appearance33;
    ((Control) this.txtRenewalFixed).DataBindings.Add(new Binding("Value", (object) this.dsProducers, "tblProducerLines.CommRenewal", true));
    ((UltraNumericEditorBase) this.txtRenewalFixed).FormatString = "#,##0.00## %";
    ((Control) this.txtRenewalFixed).Location = new Point(123, 78);
    this.txtRenewalFixed.MaskInput = "n.nnnnnnnnn";
    this.txtRenewalFixed.MaxValue = (object) 1;
    this.txtRenewalFixed.MGAStyle = MGAStyles.Blue;
    this.txtRenewalFixed.MinValue = (object) 0;
    ((Control) this.txtRenewalFixed).Name = "txtRenewalFixed";
    this.txtRenewalFixed.Nullable = true;
    this.txtRenewalFixed.NumericType = (NumericType) 1;
    ((Control) this.txtRenewalFixed).Size = new Size(69, 20);
    ((Control) this.txtRenewalFixed).TabIndex = 2;
    ((UltraWinEditorMaskedControlBase) this.txtRenewalFixed).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.txtRenewalFixed).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRenewalFixed).UseOsThemes = (DefaultableBoolean) 2;
    appearance34.BackColorDisabled = Color.Gainsboro;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numCompanyCommissionRenewal).Appearance = (AppearanceBase) appearance34;
    ((Control) this.numCompanyCommissionRenewal).DataBindings.Add(new Binding("Value", (object) this.dsProducers, "tblProducerLines.CompanyCommissionRenewal", true));
    ((UltraNumericEditorBase) this.numCompanyCommissionRenewal).FormatString = "#,##0.00## %";
    ((Control) this.numCompanyCommissionRenewal).Location = new Point(123, 103);
    this.numCompanyCommissionRenewal.MaskInput = "n.nnnnnnnnn";
    this.numCompanyCommissionRenewal.MaxValue = (object) 1;
    this.numCompanyCommissionRenewal.MGAStyle = MGAStyles.Blue;
    this.numCompanyCommissionRenewal.MinValue = (object) 0;
    ((Control) this.numCompanyCommissionRenewal).Name = "numCompanyCommissionRenewal";
    this.numCompanyCommissionRenewal.Nullable = true;
    this.numCompanyCommissionRenewal.NumericType = (NumericType) 1;
    ((Control) this.numCompanyCommissionRenewal).Size = new Size(69, 20);
    ((Control) this.numCompanyCommissionRenewal).TabIndex = 3;
    ((UltraWinEditorMaskedControlBase) this.numCompanyCommissionRenewal).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numCompanyCommissionRenewal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numCompanyCommissionRenewal).UseOsThemes = (DefaultableBoolean) 2;
    appearance35.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance35.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDefaultRenewal).Appearance = (AppearanceBase) appearance35;
    ((UltraToggleEditorBase) this.chkDefaultRenewal).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDefaultRenewal).BackColorInternal = Color.Transparent;
    ((Control) this.chkDefaultRenewal).DataBindings.Add(new Binding("Checked", (object) this.dsProducers, "tblProducerLines.UsingDefaultCommRenewal", true));
    ((UltraToggleEditorBase) this.chkDefaultRenewal).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDefaultRenewal).Location = new Point(23, 25);
    this.chkDefaultRenewal.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkDefaultRenewal).Name = "chkDefaultRenewal";
    ((Control) this.chkDefaultRenewal).Size = new Size(119, 14);
    ((Control) this.chkDefaultRenewal).TabIndex = 0;
    ((UltraToggleEditorBase) this.chkDefaultRenewal).Text = "Use Default Comm";
    ((UltraControlBase) this.chkDefaultRenewal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDefaultRenewal).UseOsThemes = (DefaultableBoolean) 2;
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblDefaultRenewal).Appearance = (AppearanceBase) appearance36;
    ((ControlBase) this.lblDefaultRenewal).BackColorInternal = Color.Transparent;
    this.lblDefaultRenewal.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblDefaultRenewal).Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblDefaultRenewal).Location = new Point(123, 52);
    ((Control) this.lblDefaultRenewal).Name = "lblDefaultRenewal";
    ((Control) this.lblDefaultRenewal).Size = new Size(69, 20);
    ((Control) this.lblDefaultRenewal).TabIndex = 1;
    ((Control) sharedControlsPage).Location = new Point(-10000, -10000);
    ((Control) sharedControlsPage).Name = "UltraTabSharedControlsPage1";
    ((Control) sharedControlsPage).Size = new Size(696, 323);
    this.errProvider.ContainerControl = (ContainerControl) this;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(594, 686);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 146;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.UltraTabControl1).Controls.Add((Control) sharedControlsPage);
    ((Control) this.UltraTabControl1).Controls.Add((Control) ultraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) ultraTabPageControl2);
    ((Control) this.UltraTabControl1).Location = new Point(12, 330);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = sharedControlsPage;
    ((Control) this.UltraTabControl1).Size = new Size(698, 350);
    ((Control) this.UltraTabControl1).TabIndex = 150;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 1;
    appearance37.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance93.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance37;
    ultraTab1.TabPage = ultraTabPageControl1;
    ultraTab1.Text = "Applies To";
    appearance38.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance94.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance38;
    ultraTab2.TabPage = ultraTabPageControl2;
    ultraTab2.Text = "Settings";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(125, 25);
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.gridSetups).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridSetups).DataMember = "tblProducerLines";
    ((UltraGridBase) this.gridSetups).DataSource = (object) this.dsProducers;
    appearance39.BackColor = Color.White;
    appearance39.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridSetups).DisplayLayout.Appearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.gridSetups).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 115;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Def New";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 7;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Def Ren";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 8;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Comm New";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 9;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Comm Ren";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 10;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Act Cur";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 11;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Days Due";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 12;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Days Due End";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 13;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 14;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 15;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Company Location";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 2;
    ultraGridColumn13.NullText = "Any";
    ultraGridColumn13.Width = 160 /*0xA0*/;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 4;
    ultraGridColumn14.NullText = "Any";
    ultraGridColumn14.Width = 97;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 6;
    ultraGridColumn15.NullText = "Any";
    ultraGridColumn15.Width = 58;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 17;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 18;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 88;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 19;
    ultraGridColumn18.Width = 42;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Package Only";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 20;
    ultraGridColumn19.Width = 58;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Package";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 5;
    ultraGridColumn20.NullText = "Any";
    ultraGridColumn20.Width = 82;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 21;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 42;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Quoting Office";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 3;
    ultraGridColumn22.NullText = "Any";
    ultraGridColumn22.Style = (ColumnStyle) 6;
    ultraGridColumn22.Width = 195;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 22;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 100;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 23;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 134;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 24;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 101;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 25;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 106;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 26;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 142;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 27;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 162;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 28;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 124;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 29;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 104;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 30;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 144 /*0x90*/;
    ultraGridBand1.Columns.AddRange(new object[31 /*0x1F*/]
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
      (object) ultraGridColumn31
    });
    ((UltraGridBase) this.gridSetups).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridSetups).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance40.BackColor = Color.LightSteelBlue;
    appearance40.FontData.SizeInPoints = 10f;
    appearance40.ForeColor = Color.FromArgb(21, 66, 139);
    ((UltraGridBase) this.gridSetups).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance40;
    appearance41.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance41.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance41.ForeColor = Color.Black;
    ((UltraGridBase) this.gridSetups).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance41;
    ((UltraGridBase) this.gridSetups).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridSetups).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridSetups).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance42.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSetups).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance42;
    appearance43.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridSetups).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.gridSetups).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridSetups).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance44.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridSetups).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance44;
    appearance45.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSetups).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance45;
    ((UltraGridBase) this.gridSetups).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance46.BackColor = Color.Transparent;
    appearance46.ForeColor = Color.Black;
    ((UltraGridBase) this.gridSetups).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance46;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridSetups).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridSetups).Location = new Point(12, 64 /*0x40*/);
    ((Control) this.gridSetups).Name = "gridSetups";
    ((Control) this.gridSetups).Size = new Size(694, 260);
    ((Control) this.gridSetups).TabIndex = 151;
    ((Control) this.gridSetups).Text = "Applicable Setups for this Producer";
    ((UltraControlBase) this.gridSetups).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridSetups).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ddCompanies).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.ddCompanies).DataSource = (object) this.dsProducers;
    appearance47.BackColor = SystemColors.Window;
    appearance47.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Appearance = (AppearanceBase) appearance47;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 0;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 1;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 2;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34
    });
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 0;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 1;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 2;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 3;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 4;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 5;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 6;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 7;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 8;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 9;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 10;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 11;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 12;
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 13;
    ultraGridColumn49.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 14;
    ultraGridColumn50.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 15;
    ultraGridColumn51.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn52.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 17;
    ultraGridColumn53.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 18;
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.Header.VisiblePosition = 19;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.Header.VisiblePosition = 20;
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn56.Header.VisiblePosition = 21;
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn57.Header.VisiblePosition = 22;
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn58.Header.VisiblePosition = 23;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn59.Header.VisiblePosition = 24;
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn60.Header.VisiblePosition = 25;
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn61.Header.VisiblePosition = 26;
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn62.Header.VisiblePosition = 27;
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn63.Header.VisiblePosition = 28;
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn64.Header.VisiblePosition = 29;
    ((HeaderBase) ultraGridColumn65.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn65.Header.VisiblePosition = 30;
    ultraGridBand3.Columns.AddRange(new object[31 /*0x1F*/]
    {
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
      (object) ultraGridColumn65
    });
    ((UltraGridBase) this.ddCompanies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddCompanies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ddCompanies).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance48.BackColor = SystemColors.ActiveBorder;
    appearance48.BackColor2 = SystemColors.ControlDark;
    appearance48.BackGradientStyle = (GradientStyle) 2;
    appearance48.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddCompanies).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance48;
    appearance49.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance49;
    ((SpecialBoxBase) ((UltraGridBase) this.ddCompanies).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance50.BackColor = SystemColors.ControlLightLight;
    appearance50.BackColor2 = SystemColors.Control;
    appearance50.BackGradientStyle = (GradientStyle) 3;
    appearance50.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance50;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.MaxRowScrollRegions = 1;
    appearance51.BackColor = SystemColors.Window;
    appearance51.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance51;
    appearance52.BackColor = SystemColors.Highlight;
    appearance52.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance52;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance53.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance53;
    appearance54.BorderColor = Color.Silver;
    appearance54.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance54;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.CellPadding = 0;
    appearance55.BackColor = SystemColors.Control;
    appearance55.BackColor2 = SystemColors.ControlDark;
    appearance55.BackGradientAlignment = (GradientAlignment) 1;
    appearance55.BackGradientStyle = (GradientStyle) 3;
    appearance55.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance55;
    ((AppearanceBase) appearance56).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance56;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance57.BackColor = SystemColors.Window;
    appearance57.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance57;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance58.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance58;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddCompanies).DisplayMember = "Name";
    ((Control) this.ddCompanies).Location = new Point(360, 157);
    ((Control) this.ddCompanies).Name = "ddCompanies";
    ((Control) this.ddCompanies).Size = new Size(148, 65);
    ((Control) this.ddCompanies).TabIndex = 152;
    ((Control) this.ddCompanies).Text = "UltraDropDown1";
    ((UltraDropDownBase) this.ddCompanies).ValueMember = "CompanyLocationGUID";
    ((Control) this.ddCompanies).Visible = false;
    ((UltraGridBase) this.ddStates).DataMember = "lstStates";
    ((UltraGridBase) this.ddStates).DataSource = (object) this.dsProducers;
    appearance59.BackColor = SystemColors.Window;
    appearance59.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddStates).DisplayLayout.Appearance = (AppearanceBase) appearance59;
    ultraGridColumn66.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn66.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn66.Header.VisiblePosition = 1;
    ultraGridColumn67.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn67.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn67.Header.VisiblePosition = 0;
    ultraGridColumn68.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn68.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn68.Header.VisiblePosition = 2;
    ultraGridBand4.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn66,
      (object) ultraGridColumn67,
      (object) ultraGridColumn68
    });
    ultraGridColumn69.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn69.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn69.Header.VisiblePosition = 0;
    ultraGridColumn70.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn70.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn70.Header.VisiblePosition = 1;
    ultraGridColumn71.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn71.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn71.Header.VisiblePosition = 2;
    ultraGridColumn72.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn72.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn72.Header.VisiblePosition = 3;
    ultraGridColumn73.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn73.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn73.Header.VisiblePosition = 4;
    ultraGridColumn74.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn74.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn74.Header.VisiblePosition = 5;
    ultraGridColumn75.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn75.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn75.Header.VisiblePosition = 6;
    ultraGridColumn76.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn76.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn76.Header.VisiblePosition = 7;
    ultraGridColumn77.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn77.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn77.Header.VisiblePosition = 8;
    ultraGridColumn78.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn78.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn78.Header.VisiblePosition = 9;
    ultraGridColumn79.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn79.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn79.Header.VisiblePosition = 10;
    ultraGridColumn80.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn80.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn80.Header.VisiblePosition = 11;
    ultraGridColumn81.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn81.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn81.Header.VisiblePosition = 12;
    ultraGridColumn82.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn82.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn82.Header.VisiblePosition = 13;
    ultraGridColumn83.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn83.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn83.Header.VisiblePosition = 14;
    ultraGridColumn84.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn84.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn84.Header.VisiblePosition = 15;
    ultraGridColumn85.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn85.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn85.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn86.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn86.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn86.Header.VisiblePosition = 17;
    ultraGridColumn87.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn87.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn87.Header.VisiblePosition = 18;
    ((HeaderBase) ultraGridColumn88.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn88.Header.VisiblePosition = 19;
    ((HeaderBase) ultraGridColumn89.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn89.Header.VisiblePosition = 20;
    ((HeaderBase) ultraGridColumn90.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn90.Header.VisiblePosition = 21;
    ((HeaderBase) ultraGridColumn91.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn91.Header.VisiblePosition = 22;
    ((HeaderBase) ultraGridColumn92.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn92.Header.VisiblePosition = 23;
    ((HeaderBase) ultraGridColumn93.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn93.Header.VisiblePosition = 24;
    ((HeaderBase) ultraGridColumn94.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn94.Header.VisiblePosition = 25;
    ((HeaderBase) ultraGridColumn95.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn95.Header.VisiblePosition = 26;
    ((HeaderBase) ultraGridColumn96.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn96.Header.VisiblePosition = 27;
    ((HeaderBase) ultraGridColumn97.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn97.Header.VisiblePosition = 28;
    ((HeaderBase) ultraGridColumn98.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn98.Header.VisiblePosition = 29;
    ((HeaderBase) ultraGridColumn99.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn99.Header.VisiblePosition = 30;
    ultraGridBand5.Columns.AddRange(new object[31 /*0x1F*/]
    {
      (object) ultraGridColumn69,
      (object) ultraGridColumn70,
      (object) ultraGridColumn71,
      (object) ultraGridColumn72,
      (object) ultraGridColumn73,
      (object) ultraGridColumn74,
      (object) ultraGridColumn75,
      (object) ultraGridColumn76,
      (object) ultraGridColumn77,
      (object) ultraGridColumn78,
      (object) ultraGridColumn79,
      (object) ultraGridColumn80,
      (object) ultraGridColumn81,
      (object) ultraGridColumn82,
      (object) ultraGridColumn83,
      (object) ultraGridColumn84,
      (object) ultraGridColumn85,
      (object) ultraGridColumn86,
      (object) ultraGridColumn87,
      (object) ultraGridColumn88,
      (object) ultraGridColumn89,
      (object) ultraGridColumn90,
      (object) ultraGridColumn91,
      (object) ultraGridColumn92,
      (object) ultraGridColumn93,
      (object) ultraGridColumn94,
      (object) ultraGridColumn95,
      (object) ultraGridColumn96,
      (object) ultraGridColumn97,
      (object) ultraGridColumn98,
      (object) ultraGridColumn99
    });
    ((UltraGridBase) this.ddStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ddStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ddStates).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddStates).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance60.BackColor = SystemColors.ActiveBorder;
    appearance60.BackColor2 = SystemColors.ControlDark;
    appearance60.BackGradientStyle = (GradientStyle) 2;
    appearance60.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddStates).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance60;
    appearance61.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddStates).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance61;
    ((SpecialBoxBase) ((UltraGridBase) this.ddStates).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance62.BackColor = SystemColors.ControlLightLight;
    appearance62.BackColor2 = SystemColors.Control;
    appearance62.BackGradientStyle = (GradientStyle) 3;
    appearance62.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddStates).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance62;
    ((UltraGridBase) this.ddStates).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddStates).DisplayLayout.MaxRowScrollRegions = 1;
    appearance63.BackColor = SystemColors.Window;
    appearance63.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance63;
    appearance64.BackColor = SystemColors.Highlight;
    appearance64.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance64;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance65.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance65;
    appearance66.BorderColor = Color.Silver;
    appearance66.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance66;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.CellPadding = 0;
    appearance67.BackColor = SystemColors.Control;
    appearance67.BackColor2 = SystemColors.ControlDark;
    appearance67.BackGradientAlignment = (GradientAlignment) 1;
    appearance67.BackGradientStyle = (GradientStyle) 3;
    appearance67.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance67;
    ((AppearanceBase) appearance68).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance68;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance69.BackColor = SystemColors.Window;
    appearance69.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance69;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance70.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance70;
    ((UltraGridBase) this.ddStates).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddStates).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddStates).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddStates).DisplayMember = "State";
    ((Control) this.ddStates).Location = new Point(201, 157);
    ((Control) this.ddStates).Name = "ddStates";
    ((Control) this.ddStates).Size = new Size(162, 65);
    ((Control) this.ddStates).TabIndex = 153;
    ((Control) this.ddStates).Text = "UltraDropDown1";
    ((UltraDropDownBase) this.ddStates).ValueMember = "StateID";
    ((Control) this.ddStates).Visible = false;
    ((UltraGridBase) this.ddLines).DataMember = "lstLines";
    ((UltraGridBase) this.ddLines).DataSource = (object) this.dsProducers;
    appearance71.BackColor = SystemColors.Window;
    appearance71.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddLines).DisplayLayout.Appearance = (AppearanceBase) appearance71;
    ultraGridColumn100.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn100.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn100.Header.VisiblePosition = 0;
    ultraGridColumn101.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn101.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn101.Header.VisiblePosition = 1;
    ultraGridColumn102.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn102.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn102.Header.VisiblePosition = 2;
    ultraGridBand6.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn100,
      (object) ultraGridColumn101,
      (object) ultraGridColumn102
    });
    ultraGridColumn103.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn103.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn103.Header.VisiblePosition = 0;
    ultraGridColumn104.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn104.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn104.Header.VisiblePosition = 1;
    ultraGridColumn105.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn105.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn105.Header.VisiblePosition = 2;
    ultraGridColumn106.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn106.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn106.Header.VisiblePosition = 3;
    ultraGridColumn107.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn107.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn107.Header.VisiblePosition = 4;
    ultraGridColumn108.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn108.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn108.Header.VisiblePosition = 5;
    ultraGridColumn109.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn109.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn109.Header.VisiblePosition = 6;
    ultraGridColumn110.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn110.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn110.Header.VisiblePosition = 7;
    ultraGridColumn111.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn111.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn111.Header.VisiblePosition = 8;
    ultraGridColumn112.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn112.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn112.Header.VisiblePosition = 9;
    ultraGridColumn113.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn113.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn113.Header.VisiblePosition = 10;
    ultraGridColumn114.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn114.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn114.Header.VisiblePosition = 11;
    ultraGridColumn115.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn115.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn115.Header.VisiblePosition = 12;
    ultraGridColumn116.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn116.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn116.Header.VisiblePosition = 13;
    ultraGridColumn117.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn117.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn117.Header.VisiblePosition = 14;
    ultraGridColumn118.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn118.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn118.Header.VisiblePosition = 15;
    ultraGridColumn119.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn119.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn119.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn120.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn120.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn120.Header.VisiblePosition = 17;
    ultraGridColumn121.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn121.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn121.Header.VisiblePosition = 18;
    ((HeaderBase) ultraGridColumn122.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn122.Header.VisiblePosition = 19;
    ((HeaderBase) ultraGridColumn123.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn123.Header.VisiblePosition = 20;
    ((HeaderBase) ultraGridColumn124.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn124.Header.VisiblePosition = 21;
    ((HeaderBase) ultraGridColumn125.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn125.Header.VisiblePosition = 22;
    ((HeaderBase) ultraGridColumn126.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn126.Header.VisiblePosition = 23;
    ((HeaderBase) ultraGridColumn127.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn127.Header.VisiblePosition = 24;
    ((HeaderBase) ultraGridColumn128.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn128.Header.VisiblePosition = 25;
    ((HeaderBase) ultraGridColumn129.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn129.Header.VisiblePosition = 26;
    ((HeaderBase) ultraGridColumn130.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn130.Header.VisiblePosition = 27;
    ((HeaderBase) ultraGridColumn131.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn131.Header.VisiblePosition = 28;
    ((HeaderBase) ultraGridColumn132.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn132.Header.VisiblePosition = 29;
    ((HeaderBase) ultraGridColumn133.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn133.Header.VisiblePosition = 30;
    ultraGridBand7.Columns.AddRange(new object[31 /*0x1F*/]
    {
      (object) ultraGridColumn103,
      (object) ultraGridColumn104,
      (object) ultraGridColumn105,
      (object) ultraGridColumn106,
      (object) ultraGridColumn107,
      (object) ultraGridColumn108,
      (object) ultraGridColumn109,
      (object) ultraGridColumn110,
      (object) ultraGridColumn111,
      (object) ultraGridColumn112,
      (object) ultraGridColumn113,
      (object) ultraGridColumn114,
      (object) ultraGridColumn115,
      (object) ultraGridColumn116,
      (object) ultraGridColumn117,
      (object) ultraGridColumn118,
      (object) ultraGridColumn119,
      (object) ultraGridColumn120,
      (object) ultraGridColumn121,
      (object) ultraGridColumn122,
      (object) ultraGridColumn123,
      (object) ultraGridColumn124,
      (object) ultraGridColumn125,
      (object) ultraGridColumn126,
      (object) ultraGridColumn127,
      (object) ultraGridColumn128,
      (object) ultraGridColumn129,
      (object) ultraGridColumn130,
      (object) ultraGridColumn131,
      (object) ultraGridColumn132,
      (object) ultraGridColumn133
    });
    ((UltraGridBase) this.ddLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.ddLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    ((UltraGridBase) this.ddLines).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddLines).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance72.BackColor = SystemColors.ActiveBorder;
    appearance72.BackColor2 = SystemColors.ControlDark;
    appearance72.BackGradientStyle = (GradientStyle) 2;
    appearance72.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddLines).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance72;
    appearance73.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddLines).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance73;
    ((SpecialBoxBase) ((UltraGridBase) this.ddLines).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance74.BackColor = SystemColors.ControlLightLight;
    appearance74.BackColor2 = SystemColors.Control;
    appearance74.BackGradientStyle = (GradientStyle) 3;
    appearance74.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddLines).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance74;
    ((UltraGridBase) this.ddLines).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddLines).DisplayLayout.MaxRowScrollRegions = 1;
    appearance75.BackColor = SystemColors.Window;
    appearance75.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance75;
    appearance76.BackColor = SystemColors.Highlight;
    appearance76.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance76;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance77.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance77;
    appearance78.BorderColor = Color.Silver;
    appearance78.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance78;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.CellPadding = 0;
    appearance79.BackColor = SystemColors.Control;
    appearance79.BackColor2 = SystemColors.ControlDark;
    appearance79.BackGradientAlignment = (GradientAlignment) 1;
    appearance79.BackGradientStyle = (GradientStyle) 3;
    appearance79.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance79;
    ((AppearanceBase) appearance80).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance80;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance81.BackColor = SystemColors.Window;
    appearance81.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance81;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance82.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance82;
    ((UltraGridBase) this.ddLines).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddLines).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddLines).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddLines).DisplayMember = "LineName";
    ((Control) this.ddLines).Location = new Point(37, 157);
    ((Control) this.ddLines).Name = "ddLines";
    ((Control) this.ddLines).Size = new Size(158, 80 /*0x50*/);
    ((Control) this.ddLines).TabIndex = 154;
    ((Control) this.ddLines).Text = "UltraDropDown2";
    ((UltraDropDownBase) this.ddLines).ValueMember = "LineGUID";
    ((Control) this.ddLines).Visible = false;
    this.comboCompanyFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboCompanyFilter).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.comboCompanyFilter).DataSource = (object) this.dsProducers;
    ((UltraDropDownBase) this.comboCompanyFilter).DisplayMember = "Name";
    this.comboCompanyFilter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCompanyFilter).Location = new Point(37, 12);
    this.comboCompanyFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCompanyFilter).Name = "comboCompanyFilter";
    ((Control) this.comboCompanyFilter).Size = new Size(211, 21);
    ((Control) this.comboCompanyFilter).TabIndex = 155;
    ((UltraControlBase) this.comboCompanyFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCompanyFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboCompanyFilter).ValueMember = "CompanyLocationGUID";
    this.comboLineFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboLineFilter).DataMember = "lstLines";
    ((UltraGridBase) this.comboLineFilter).DataSource = (object) this.dsProducers;
    ((UltraDropDownBase) this.comboLineFilter).DisplayMember = "LineName";
    this.comboLineFilter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboLineFilter).Location = new Point(254, 12);
    this.comboLineFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboLineFilter).Name = "comboLineFilter";
    ((Control) this.comboLineFilter).Size = new Size(211, 21);
    ((Control) this.comboLineFilter).TabIndex = 156;
    ((UltraControlBase) this.comboLineFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboLineFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboLineFilter).ValueMember = "LineGUID";
    this.comboStateFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboStateFilter).DataMember = "lstStates";
    ((UltraGridBase) this.comboStateFilter).DataSource = (object) this.dsProducers;
    ((UltraDropDownBase) this.comboStateFilter).DisplayMember = "State";
    this.comboStateFilter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboStateFilter).Location = new Point(471, 12);
    this.comboStateFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboStateFilter).Name = "comboStateFilter";
    ((Control) this.comboStateFilter).Size = new Size(211, 21);
    ((Control) this.comboStateFilter).TabIndex = 157;
    ((UltraControlBase) this.comboStateFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboStateFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboStateFilter).ValueMember = "StateID";
    this.linkApplyFilter.AutoSize = true;
    this.linkApplyFilter.Location = new Point(329, 40);
    this.linkApplyFilter.Name = "linkApplyFilter";
    this.linkApplyFilter.Size = new Size(61, 13);
    this.linkApplyFilter.TabIndex = 158;
    this.linkApplyFilter.TabStop = true;
    this.linkApplyFilter.Text = "Apply Filter";
    this.dvCompanyFilter.Table = (DataTable) this.dsProducers.tblCompanyLocations;
    this.dvLineFilter.Table = (DataTable) this.dsProducers.lstLines;
    this.dvStateFilter.Table = (DataTable) this.dsProducers.lstStates;
    ((UltraGridBase) this.ddQuotingOffice).DataMember = "tblClientOffices";
    ((UltraGridBase) this.ddQuotingOffice).DataSource = (object) this.dsProducers;
    appearance83.BackColor = SystemColors.Window;
    appearance83.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Appearance = (AppearanceBase) appearance83;
    ((HeaderBase) ultraGridColumn134.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn134.Header.VisiblePosition = 0;
    ultraGridColumn134.Width = 191;
    ((HeaderBase) ultraGridColumn135.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn135.Header.VisiblePosition = 1;
    ultraGridColumn135.Hidden = true;
    ((HeaderBase) ultraGridColumn136.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn136.Header.VisiblePosition = 2;
    ultraGridBand8.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn134,
      (object) ultraGridColumn135,
      (object) ultraGridColumn136
    });
    ((HeaderBase) ultraGridColumn137.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn137.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn138.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn138.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn139.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn139.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn140.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn140.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn141.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn141.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn142.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn142.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn143.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn143.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn144.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn144.Header.VisiblePosition = 7;
    ((HeaderBase) ultraGridColumn145.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn145.Header.VisiblePosition = 8;
    ((HeaderBase) ultraGridColumn146.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn146.Header.VisiblePosition = 9;
    ((HeaderBase) ultraGridColumn147.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn147.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn148.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn148.Header.VisiblePosition = 11;
    ((HeaderBase) ultraGridColumn149.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn149.Header.VisiblePosition = 12;
    ((HeaderBase) ultraGridColumn150.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn150.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn151.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn151.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn152.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn152.Header.VisiblePosition = 15;
    ((HeaderBase) ultraGridColumn153.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn153.Header.VisiblePosition = 16 /*0x10*/;
    ((HeaderBase) ultraGridColumn154.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn154.Header.VisiblePosition = 17;
    ((HeaderBase) ultraGridColumn155.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn155.Header.VisiblePosition = 18;
    ((HeaderBase) ultraGridColumn156.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn156.Header.VisiblePosition = 19;
    ((HeaderBase) ultraGridColumn157.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn157.Header.VisiblePosition = 20;
    ((HeaderBase) ultraGridColumn158.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn158.Header.VisiblePosition = 21;
    ((HeaderBase) ultraGridColumn159.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn159.Header.VisiblePosition = 22;
    ((HeaderBase) ultraGridColumn160.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn160.Header.VisiblePosition = 23;
    ((HeaderBase) ultraGridColumn161.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn161.Header.VisiblePosition = 24;
    ((HeaderBase) ultraGridColumn162.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn162.Header.VisiblePosition = 25;
    ((HeaderBase) ultraGridColumn163.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn163.Header.VisiblePosition = 26;
    ((HeaderBase) ultraGridColumn164.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn164.Header.VisiblePosition = 27;
    ((HeaderBase) ultraGridColumn165.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn165.Header.VisiblePosition = 28;
    ((HeaderBase) ultraGridColumn166.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn166.Header.VisiblePosition = 29;
    ((HeaderBase) ultraGridColumn167.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn167.Header.VisiblePosition = 30;
    ultraGridBand9.Columns.AddRange(new object[31 /*0x1F*/]
    {
      (object) ultraGridColumn137,
      (object) ultraGridColumn138,
      (object) ultraGridColumn139,
      (object) ultraGridColumn140,
      (object) ultraGridColumn141,
      (object) ultraGridColumn142,
      (object) ultraGridColumn143,
      (object) ultraGridColumn144,
      (object) ultraGridColumn145,
      (object) ultraGridColumn146,
      (object) ultraGridColumn147,
      (object) ultraGridColumn148,
      (object) ultraGridColumn149,
      (object) ultraGridColumn150,
      (object) ultraGridColumn151,
      (object) ultraGridColumn152,
      (object) ultraGridColumn153,
      (object) ultraGridColumn154,
      (object) ultraGridColumn155,
      (object) ultraGridColumn156,
      (object) ultraGridColumn157,
      (object) ultraGridColumn158,
      (object) ultraGridColumn159,
      (object) ultraGridColumn160,
      (object) ultraGridColumn161,
      (object) ultraGridColumn162,
      (object) ultraGridColumn163,
      (object) ultraGridColumn164,
      (object) ultraGridColumn165,
      (object) ultraGridColumn166,
      (object) ultraGridColumn167
    });
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.BandsSerializer.Add((object) ultraGridBand8);
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.BandsSerializer.Add((object) ultraGridBand9);
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance84.BackColor = SystemColors.ActiveBorder;
    appearance84.BackColor2 = SystemColors.ControlDark;
    appearance84.BackGradientStyle = (GradientStyle) 2;
    appearance84.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance84;
    appearance85.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance85;
    ((SpecialBoxBase) ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance86.BackColor = SystemColors.ControlLightLight;
    appearance86.BackColor2 = SystemColors.Control;
    appearance86.BackGradientStyle = (GradientStyle) 3;
    appearance86.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance86;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.MaxRowScrollRegions = 1;
    appearance87.BackColor = SystemColors.Window;
    appearance87.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance87;
    appearance88.BackColor = SystemColors.Highlight;
    appearance88.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance88;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance89.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance89;
    appearance90.BorderColor = Color.Silver;
    appearance90.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance90;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.CellPadding = 0;
    appearance91.BackColor = SystemColors.Control;
    appearance91.BackColor2 = SystemColors.ControlDark;
    appearance91.BackGradientAlignment = (GradientAlignment) 1;
    appearance91.BackGradientStyle = (GradientStyle) 3;
    appearance91.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance91;
    ((AppearanceBase) appearance92).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance92;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance93.BackColor = SystemColors.Window;
    appearance93.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance93;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance94.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance94;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddQuotingOffice).DisplayMember = "Location";
    ((Control) this.ddQuotingOffice).Location = new Point(514, 157);
    ((Control) this.ddQuotingOffice).Name = "ddQuotingOffice";
    ((Control) this.ddQuotingOffice).Size = new Size(148, 65);
    ((Control) this.ddQuotingOffice).TabIndex = 159;
    ((Control) this.ddQuotingOffice).Text = "UltraDropDown1";
    ((UltraDropDownBase) this.ddQuotingOffice).ValueMember = "OfficeGuid";
    ((Control) this.ddQuotingOffice).Visible = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(718, 737);
    this.Controls.Add((Control) this.ddQuotingOffice);
    this.Controls.Add((Control) this.linkApplyFilter);
    this.Controls.Add((Control) this.comboStateFilter);
    this.Controls.Add((Control) this.comboLineFilter);
    this.Controls.Add((Control) this.comboCompanyFilter);
    this.Controls.Add((Control) this.ddLines);
    this.Controls.Add((Control) this.ddStates);
    this.Controls.Add((Control) this.ddCompanies);
    this.Controls.Add((Control) this.gridSetups);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Controls.Add((Control) this.dbSave);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmProducerLines);
    this.Text = "Producer Lines Management";
    ((Control) ultraTabPageControl1).ResumeLayout(false);
    ((Control) ultraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.cboQuotingOffice).EndInit();
    this.dsProducers.EndInit();
    ((ISupportInitialize) this.chkApplyToPackage).EndInit();
    ((ISupportInitialize) this.cboStates).EndInit();
    ((ISupportInitialize) this.cboPackages).EndInit();
    ((ISupportInitialize) this.cboLines).EndInit();
    ((ISupportInitialize) this.cboCompanies).EndInit();
    ((Control) ultraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.ugbOther).EndInit();
    ((Control) this.ugbOther).ResumeLayout(false);
    ((Control) this.ugbOther).PerformLayout();
    ((ISupportInitialize) this.numTargetPremiumGreater).EndInit();
    ((ISupportInitialize) this.numPremiumLess).EndInit();
    ((ISupportInitialize) this.numPremiumGreater).EndInit();
    ((ISupportInitialize) this.gbOptions).EndInit();
    ((Control) this.gbOptions).ResumeLayout(false);
    ((Control) this.gbOptions).PerformLayout();
    ((ISupportInitialize) this.txtEffectiveDatePlus).EndInit();
    ((ISupportInitialize) this.txtEndofMonthPlus).EndInit();
    ((ISupportInitialize) this.chkEffectiveDatePlus).EndInit();
    ((ISupportInitialize) this.chkEndOfMonthPlus).EndInit();
    ((ISupportInitialize) this.MgaCheckBox1).EndInit();
    ((ISupportInitialize) this.chkBlocked).EndInit();
    ((ISupportInitialize) this.chkUseCompanyEndorsementDaysDue).EndInit();
    ((ISupportInitialize) this.chkUseCompanyDaysDue).EndInit();
    ((ISupportInitialize) this.txtEndorsementDaysDue).EndInit();
    ((ISupportInitialize) this.dtEffective).EndInit();
    ((ISupportInitialize) this.cboRenewalStatus).EndInit();
    this.dvRenewalStatus.EndInit();
    ((ISupportInitialize) this.cbStatus).EndInit();
    this.dvStatus.EndInit();
    ((ISupportInitialize) this.chkAccountCurrent).EndInit();
    ((ISupportInitialize) this.txtDaysDue).EndInit();
    ((ISupportInitialize) this.gbNew).EndInit();
    ((Control) this.gbNew).ResumeLayout(false);
    ((Control) this.gbNew).PerformLayout();
    ((ISupportInitialize) this.numCompanyCommissionNew).EndInit();
    ((ISupportInitialize) this.txtNewFixed).EndInit();
    ((ISupportInitialize) this.chkDefaultNew).EndInit();
    ((ISupportInitialize) this.gbRenewal).EndInit();
    ((Control) this.gbRenewal).ResumeLayout(false);
    ((Control) this.gbRenewal).PerformLayout();
    ((ISupportInitialize) this.chkKeepExpiringOnRenewal).EndInit();
    ((ISupportInitialize) this.txtRenewalFixed).EndInit();
    ((ISupportInitialize) this.numCompanyCommissionRenewal).EndInit();
    ((ISupportInitialize) this.chkDefaultRenewal).EndInit();
    ((ISupportInitialize) this.errProvider).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((ISupportInitialize) this.gridSetups).EndInit();
    ((ISupportInitialize) this.ddCompanies).EndInit();
    ((ISupportInitialize) this.ddStates).EndInit();
    ((ISupportInitialize) this.ddLines).EndInit();
    ((ISupportInitialize) this.comboCompanyFilter).EndInit();
    ((ISupportInitialize) this.comboLineFilter).EndInit();
    ((ISupportInitialize) this.comboStateFilter).EndInit();
    this.dvCompanyFilter.EndInit();
    this.dvLineFilter.EndInit();
    this.dvStateFilter.EndInit();
    ((ISupportInitialize) this.ddQuotingOffice).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private virtual BindingManagerBase _bmb
  {
    get => this.__bmb;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this._bmb_PositionChanged);
      BindingManagerBase bmb1 = this.__bmb;
      if (bmb1 != null)
        bmb1.PositionChanged -= eventHandler;
      this.__bmb = value;
      BindingManagerBase bmb2 = this.__bmb;
      if (bmb2 == null)
        return;
      bmb2.PositionChanged += eventHandler;
    }
  }

  public frmProducerLines()
  {
    this.Load += new EventHandler(this.frmProducerLines_Load);
    this._producerGuid = Guid.Empty;
    this._producerLocationGuid = Guid.Empty;
    this._daysDueDefault = int.MinValue;
    this._daysDueEndorsementDefault = int.MinValue;
    this._isFormLoaded = false;
    this.InitializeComponent();
  }

  public frmProducerLines(Guid producerLocationGuid)
  {
    this.Load += new EventHandler(this.frmProducerLines_Load);
    this._producerGuid = Guid.Empty;
    this._producerLocationGuid = Guid.Empty;
    this._daysDueDefault = int.MinValue;
    this._daysDueEndorsementDefault = int.MinValue;
    this._isFormLoaded = false;
    this.InitializeComponent();
    this._producerLocationGuid = producerLocationGuid;
    this._entireProducer = false;
    ((ControlBase) this.labelProducerLocation).Text = new ProducerLocation(producerLocationGuid).LocationName;
  }

  public frmProducerLines(Guid producerGuid, Guid producerLocationGuid)
  {
    this.Load += new EventHandler(this.frmProducerLines_Load);
    this._producerGuid = Guid.Empty;
    this._producerLocationGuid = Guid.Empty;
    this._daysDueDefault = int.MinValue;
    this._daysDueEndorsementDefault = int.MinValue;
    this._isFormLoaded = false;
    this.InitializeComponent();
    ((ControlBase) this.labelProducer).Text = new Producer(producerGuid).ProducerName;
    this._producerGuid = producerGuid;
    this._producerLocationGuid = producerLocationGuid;
    this._entireProducer = true;
  }

  private void frmProducerLines_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this._bmb = this.BindingContext[(object) this.dsProducers, this.dsProducers.tblProducerLines.TableName];
    ((Control) this.txtNewFixed).DataBindings.Add("ReadOnly", (object) this.chkDefaultNew, "Checked");
    ((Control) this.txtRenewalFixed).DataBindings.Add("ReadOnly", (object) this.chkDefaultRenewal, "Checked");
    ((Control) this.cboPackages).DataBindings.Add("Visible", (object) this.chkApplyToPackage, "Checked").Format += new ConvertEventHandler(this.NullValueOnFalse);
    ((Control) this.lblPackage).DataBindings.Add("Visible", (object) this.chkApplyToPackage, "Checked");
    ((Control) this.numCompanyCommissionNew).DataBindings.Add("ReadOnly", (object) this.chkDefaultNew, "Checked");
    ((Control) this.numCompanyCommissionRenewal).DataBindings.Add("ReadOnly", (object) this.chkDefaultRenewal, "Checked");
    ((Control) this.lblPackage).Visible = false;
    ((Control) this.cboPackages).Visible = false;
    this.FillData();
    this.FillProducerLinesData();
    this.SetControlsEnabled(false);
    if (SystemSettings.KeyExists("ProducerLinesDaysDueDefault"))
      this._daysDueDefault = Convert.ToInt32(SystemSettings.GetNumericSetting("ProducerLinesDaysDueDefault"));
    if (SystemSettings.KeyExists("ProducerLinesDaysDueEndorsementDefault"))
      this._daysDueEndorsementDefault = Convert.ToInt32(SystemSettings.GetNumericSetting("ProducerLinesDaysDueEndorsementDefault"));
    this.AfterFormLoad();
    this._bmb.Position = this.dsProducers.tblProducerLines.Count - 1;
    this._isFormLoaded = true;
  }

  public virtual void AfterFormLoad()
  {
  }

  private void FillData()
  {
    try
    {
      string str = "spGetProducerLinesFormData";
      if (SystemSettings.KeyExists("ProducerLines.FillDataStoredProcName"))
        str = SystemSettings.GetStringSetting("ProducerLines.FillDataStoredProcName");
      DefaultDatabase.LoadDataSet((DataSet) this.dsProducers, new string[6]
      {
        "lstLines",
        "lstStates",
        "tblCompanyLocations",
        "lstStatus",
        "lstPackages",
        "tblClientOffices"
      }, str);
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.dsProducers, ex);
      ProjectData.ClearProjectError();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void FormatPercentage(object sender, ConvertEventArgs e)
  {
    if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.Value)))
      return;
    e.Value = (object) Strings.FormatPercent(RuntimeHelpers.GetObjectValue(e.Value), 2);
  }

  private void NullValueOnFalse(object sender, ConvertEventArgs e)
  {
    if (!e.Value.Equals((object) false))
      return;
    ((UltraCombo) ((Binding) sender).Control).Value = (object) null;
  }

  private bool IsValid()
  {
    bool flag = true;
    this.errProvider.SetError((Control) this.chkEffectiveDatePlus, string.Empty);
    this.errProvider.SetError((Control) this.chkEndOfMonthPlus, string.Empty);
    this.errProvider.SetError((Control) this.numPremiumLess, string.Empty);
    this.errProvider.SetError((Control) this.txtNewFixed, string.Empty);
    this.errProvider.SetError((Control) this.txtRenewalFixed, string.Empty);
    this.errProvider.SetError((Control) this.dtEffective, string.Empty);
    this.errProvider.SetError((Control) this.txtEffectiveDatePlus, string.Empty);
    if (!((UltraToggleEditorBase) this.chkDefaultNew).Checked && this.txtNewFixed.Value == DBNull.Value)
    {
      this.errProvider.SetError((Control) this.txtNewFixed, "Please enter a number between 0 and 1");
      flag = false;
    }
    if (!((UltraToggleEditorBase) this.chkDefaultRenewal).Checked && this.txtRenewalFixed.Value == DBNull.Value)
    {
      this.errProvider.SetError((Control) this.txtRenewalFixed, "Please enter a number between 0 and 1");
      flag = false;
    }
    if (((UltraToggleEditorBase) this.chkEffectiveDatePlus).Checked && ((TextEditorControlBase) this.txtEffectiveDatePlus).Value == null)
    {
      this.errProvider.SetError((Control) this.txtEffectiveDatePlus, "Number of days must be >= 0");
      flag = false;
    }
    if (((UltraToggleEditorBase) this.chkEffectiveDatePlus).Checked && ((UltraToggleEditorBase) this.chkEndOfMonthPlus).Checked)
    {
      this.errProvider.SetError((Control) this.chkEffectiveDatePlus, "Choose either End of Month of Effective Date or Effective Date");
      this.errProvider.SetError((Control) this.chkEndOfMonthPlus, "Choose either End of Month of Effective Date or Effective Date");
      flag = false;
    }
    if (((UltraWinEditorMaskedControlBase) this.numPremiumGreater).Text.Length > 0 && !Versioned.IsNumeric((object) ((UltraWinEditorMaskedControlBase) this.numPremiumGreater).Text))
    {
      this.errProvider.SetError((Control) this.numPremiumGreater, "Please enter a valid numeric value");
      flag = false;
    }
    if (((UltraWinEditorMaskedControlBase) this.numPremiumLess).Text.Length > 0 && !Versioned.IsNumeric((object) ((UltraWinEditorMaskedControlBase) this.numPremiumLess).Text))
    {
      this.errProvider.SetError((Control) this.numPremiumLess, "Please enter a valid numeric value");
      flag = false;
    }
    if (((UltraWinEditorMaskedControlBase) this.numPremiumGreater).Text.Length > 0 && ((UltraWinEditorMaskedControlBase) this.numPremiumGreater).Text.Replace(" ", string.Empty).Length > 0 && ((UltraWinEditorMaskedControlBase) this.numPremiumLess).Text.Length > 0 && ((UltraWinEditorMaskedControlBase) this.numPremiumLess).Text.Replace(" ", string.Empty).Length > 0 && Decimal.Compare(Conversions.ToDecimal(((UltraWinEditorMaskedControlBase) this.numPremiumGreater).Text), Conversions.ToDecimal(((UltraWinEditorMaskedControlBase) this.numPremiumLess).Text)) > 0)
    {
      this.errProvider.SetError((Control) this.numPremiumLess, "This value must be equal or greater than " + ((UltraWinEditorMaskedControlBase) this.numPremiumGreater).Text);
      flag = false;
    }
    if (!flag)
      ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[1];
    if (!this.dtEffective.IsDateValid | this.dtEffective.Value == null)
    {
      this.errProvider.SetError((Control) this.dtEffective, "Please enter a valid effective date");
      flag = false;
      ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[0];
    }
    return flag;
  }

  private bool CompanyLocationSelected
  {
    get => this.cboCompanies.Value != null && !this.cboCompanies.Value.Equals((object) Guid.Empty);
  }

  public bool LineSelected
  {
    get => this.cboLines.Value != null && !this.cboLines.Value.Equals((object) Guid.Empty);
  }

  public bool StateSelected
  {
    get => this.cboStates.Value != null && !string.IsNullOrEmpty(this.cboStates.Value.ToString());
  }

  public Guid LineGuid => (Guid) this.cboLines.Value;

  public Guid CompanyLocationGuid => (Guid) this.cboCompanies.Value;

  public string StateID => (string) this.cboStates.Value;

  private bool QuotingOfficeSelected
  {
    get
    {
      return this.cboQuotingOffice.Value != null && !this.cboQuotingOffice.Value.Equals((object) Guid.Empty);
    }
  }

  private void ShowDefaultCommission()
  {
    if (this.HasValidCompanyLine)
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT ProducerCommNew, ProducerCommRenewal FROM tblCompanyLineCommissions WHERE CompanyLineID=@CompanyLineID", new object[2]
      {
        (object) "@CompanyLineID",
        (object) new CompanyLine(this.CompanyLocationGuid, this.LineGuid, this.StateID).CompanyLineID
      });
      if (dataRow != null)
      {
        ((ControlBase) this.lblDefaultNew).Text = Strings.FormatPercent(RuntimeHelpers.GetObjectValue(dataRow[0]));
        ((ControlBase) this.lblDefaultRenewal).Text = Strings.FormatPercent(RuntimeHelpers.GetObjectValue(dataRow[1]));
      }
      else
      {
        ((ControlBase) this.lblDefaultNew).Text = "n/a";
        ((ControlBase) this.lblDefaultRenewal).Text = "n/a";
      }
    }
    else
    {
      ((ControlBase) this.lblDefaultNew).Text = "n/a";
      ((ControlBase) this.lblDefaultRenewal).Text = "n/a";
    }
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    dsProducersLinesStates.tblProducerLinesRow row = this.dsProducers.tblProducerLines.NewtblProducerLinesRow();
    this.dsProducers.tblProducerLines.BeginLoadData();
    if (this._entireProducer || !this._producerGuid.Equals(Guid.Empty))
      row.ProducerGuid = this._producerGuid;
    else
      row.ProducerLocationGUID = this._producerLocationGuid;
    dsProducersLinesStates.tblProducerLinesRow producerLinesRow = row;
    producerLinesRow.UsingDefaultCommNew = true;
    producerLinesRow.UsingDefaultCommRenewal = true;
    producerLinesRow.AccountCurrent = this.AccountCurrentDefault;
    producerLinesRow.Effective = DateAndTime.Now;
    producerLinesRow.StatusID = 1;
    producerLinesRow.RenewalStatusID = 1;
    producerLinesRow.GAAP = this.GaapDefault;
    producerLinesRow.Prod_KeepExpCommissionsOnRenewal = false;
    producerLinesRow.ProducerLineID = 0;
    if (this._daysDueDefault != int.MinValue)
    {
      row.DaysDue = this._daysDueDefault;
      try
      {
        int num = 0;
        do
        {
          ((UltraToggleEditorBase) this.chkUseCompanyDaysDue).CheckedChanged -= new EventHandler(this.chkUseCompanyDaysDue_CheckedChanged);
          ++num;
        }
        while (num <= 3);
        ((UltraToggleEditorBase) this.chkUseCompanyDaysDue).Checked = false;
      }
      finally
      {
        ((UltraToggleEditorBase) this.chkUseCompanyDaysDue).CheckedChanged += new EventHandler(this.chkUseCompanyDaysDue_CheckedChanged);
      }
    }
    if (this._daysDueEndorsementDefault != int.MinValue)
    {
      row.DaysDueEndorsement = this._daysDueEndorsementDefault;
      try
      {
        int num = 0;
        do
        {
          ((UltraToggleEditorBase) this.chkUseCompanyEndorsementDaysDue).CheckedChanged -= new EventHandler(this.chkUseCompanyEndorsementDaysDue_CheckedChanged);
          ++num;
        }
        while (num <= 3);
        ((UltraToggleEditorBase) this.chkUseCompanyEndorsementDaysDue).Checked = false;
      }
      finally
      {
        ((UltraToggleEditorBase) this.chkUseCompanyEndorsementDaysDue).CheckedChanged += new EventHandler(this.chkUseCompanyEndorsementDaysDue_CheckedChanged);
      }
    }
    row.SetQuotingLocationGuidNull();
    this.dsProducers.tblProducerLines.AddtblProducerLinesRow(row);
    this.dsProducers.tblProducerLines.EndLoadData();
    this._bmb.Position = this.dsProducers.tblProducerLines.Rows.Count - 1;
  }

  private bool HasValidCompanyLine
  {
    get => this.CompanyLocationSelected && this.LineSelected && this.StateSelected;
  }

  private void SetControlsEnabled(bool enabled)
  {
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
          control.Enabled = enabled;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    ((Control) this.gridSetups).Enabled = !enabled;
  }

  private void SetUIState()
  {
    if (this.dsProducers.tblProducerLines.Rows.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    this.SetControlsEnabled(this.dbSave.UIState == UIState.Editing);
    if (this.dbSave.UIState == UIState.Editing)
      return;
    this.SetUIState();
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this._clickedEdit = false;
    this.dsProducers.RejectChanges();
    this.SetUIState();
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    try
    {
      this._clickedEdit = false;
      if (!this.IsValid())
      {
        e.Cancel = true;
      }
      else
      {
        this.Cursor = MgaCursors.WaitCursor;
        MDIControls.Instance.StatusBarText = "Attempting to save Producer Line information ...";
        ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[0];
        this._bmb.EndCurrentEdit();
        dsProducersLinesStates.tblProducerLinesRow tblProducerLine = this.dsProducers.tblProducerLines[this._bmb.Position];
        bool flag = tblProducerLine.RowState == DataRowState.Added;
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboCompanies.Value)))
          tblProducerLine.CompanyLocationGuid = (Guid) this.cboCompanies.Value;
        else
          tblProducerLine.SetCompanyLocationGuidNull();
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboLines.Value)))
          tblProducerLine.LineGuid = (Guid) this.cboLines.Value;
        else
          tblProducerLine.SetLineGuidNull();
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboStates.Value)))
          tblProducerLine.StateID = this.cboStates.Value.ToString();
        else
          tblProducerLine.SetStateIDNull();
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboPackages.Value)))
          tblProducerLine.PackageLine = (Guid) this.cboPackages.Value;
        else
          tblProducerLine.SetPackageLineNull();
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboQuotingOffice.Value)))
          tblProducerLine.QuotingLocationGuid = (Guid) this.cboQuotingOffice.Value;
        else
          tblProducerLine.SetQuotingLocationGuidNull();
        if (((UltraToggleEditorBase) this.chkUseCompanyDaysDue).Checked)
          tblProducerLine.SetDaysDueNull();
        if (((UltraToggleEditorBase) this.chkUseCompanyEndorsementDaysDue).Checked)
          tblProducerLine.SetDaysDueEndorsementNull();
        if (tblProducerLine.UsingDefaultCommNew && !tblProducerLine.IsCommNewNull())
          tblProducerLine.SetCommNewNull();
        if (tblProducerLine.UsingDefaultCommNew && !tblProducerLine.IsCompanyCommissionNewNull())
          tblProducerLine.SetCompanyCommissionNewNull();
        if (tblProducerLine.UsingDefaultCommRenewal && !tblProducerLine.IsCommRenewalNull())
          tblProducerLine.SetCommRenewalNull();
        if (tblProducerLine.UsingDefaultCommRenewal && !tblProducerLine.IsCompanyCommissionRenewalNull())
          tblProducerLine.SetCompanyCommissionRenewalNull();
        if (this.dsProducers.HasChanges())
        {
          string empty1 = string.Empty;
          string empty2 = string.Empty;
          string empty3 = string.Empty;
          string str1 = "<empty>";
          string str2 = "";
          Dictionary<string, string> dictionary1 = new Dictionary<string, string>();
          Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
          Dictionary<string, string> dictionary3 = dictionary1;
          dictionary3.Add("AccountCurrent", "Account Current");
          dictionary3.Add("DaysDue", "Days Due");
          dictionary3.Add("DaysDueEndorsement", "Days Due Endorsement");
          dictionary3.Add("EndOfMonthEffDatePlusDays", "End of Month Effective Date Plus Days");
          dictionary3.Add("UseEndOfMonthEffDatePlusDays", "Use End Of Month Eff Date Plus Days");
          dictionary3.Add("EffectiveDatePlusDays", "Effective Date Plus Days");
          dictionary3.Add("UsingDefaultCommNew", "Using Default Comm New");
          dictionary3.Add("CommNew", "Comm New");
          dictionary3.Add("CompanyCommissionNew", "Company Commission New");
          dictionary3.Add("UsingDefaultCommRenewal", "Using Default Comm Renewal");
          dictionary3.Add("CommRenewal", "Comm Renewal");
          dictionary3.Add("CompanyCommissionRenewal", "Company Commission Renewal");
          dictionary3.Add("LineGuid", "Line");
          dictionary3.Add("QuotingLocationGuid", "Quoting Office");
          dictionary3.Add("CompanyLocationGuid", "Company Location");
          dictionary3.Add("StatusID", "Status");
          dictionary3.Add("RenewalStatusID", "Renewal Status");
          Dictionary<string, string> dictionary4 = dictionary2;
          dictionary4.Add("LineGuid", "Line");
          dictionary4.Add("QuotingLocationGuid", "Quoting Office");
          dictionary4.Add("CompanyLocationGuid", "Company Location");
          dictionary4.Add("StatusID", "Status");
          dictionary4.Add("RenewalStatusID", "Renewal Status");
          dictionary4.Add("Effective", "Effective");
          Guid identifier;
          string str3;
          if (this._entireProducer || !this._producerGuid.Equals(Guid.Empty))
          {
            identifier = this._producerGuid;
            str3 = "Producer:  " + ((ControlBase) this.labelProducer).Text;
          }
          else
          {
            identifier = this._producerLocationGuid;
            str3 = "Producer Location:  " + ((ControlBase) this.labelProducerLocation).Text;
          }
          string action;
          if (this.DataTableModified((DataRow) tblProducerLine))
          {
            try
            {
              foreach (DataColumn column in (InternalDataCollectionBase) this.dsProducers.tblProducerLines.Columns)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblProducerLine[column.ColumnName, DataRowVersion.Original].ToString(), tblProducerLine[column.ColumnName, DataRowVersion.Current].ToString(), false) != 0)
                {
                  string rowValue1 = tblProducerLine[column] == DBNull.Value ? str1 : tblProducerLine[column, DataRowVersion.Current].ToString();
                  string rowValue2 = tblProducerLine[column, DataRowVersion.Original] == DBNull.Value ? str1 : tblProducerLine[column, DataRowVersion.Original].ToString();
                  string columnName = column.ColumnName;
                  if (dictionary1.ContainsKey(column.ColumnName))
                    columnName = dictionary1[column.ColumnName];
                  if (!rowValue1.Equals(str1) && dictionary2.ContainsKey(column.ColumnName))
                    rowValue1 = this.GetEntityTableValue(column.ColumnName, tblProducerLine, (object) rowValue1);
                  if (!rowValue2.Equals(str1) && dictionary2.ContainsKey(column.ColumnName))
                    rowValue2 = this.GetEntityTableValue(column.ColumnName, tblProducerLine, (object) rowValue2);
                  str2 = $"{str2}\r\n {columnName}: was changed FROM {rowValue2} TO {rowValue1}";
                }
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
            action = $"The producer line was modified for: {str3}, {this.GetLineCompanyLocQuotingOfficeInfo(tblProducerLine)}, {str2} (ProducerLineID: {tblProducerLine.ProducerLineID})";
          }
          else
          {
            try
            {
              foreach (DataColumn column in (InternalDataCollectionBase) this.dsProducers.tblProducerLines.Columns)
              {
                if (!string.IsNullOrEmpty(tblProducerLine[column.ColumnName, DataRowVersion.Current].ToString()))
                {
                  string rowValue = tblProducerLine[column] == DBNull.Value ? str1 : tblProducerLine[column, DataRowVersion.Current].ToString();
                  string columnName = column.ColumnName;
                  if (dictionary1.ContainsKey(column.ColumnName))
                    columnName = dictionary1[column.ColumnName];
                  if (!rowValue.Equals(str1) && dictionary2.ContainsKey(column.ColumnName))
                    rowValue = this.GetEntityTableValue(column.ColumnName, tblProducerLine, (object) rowValue);
                  str2 = $"{str2}\r\n {columnName}: {rowValue}";
                }
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
            action = $"The producer line was added for: {str3}, {this.GetLineCompanyLocQuotingOfficeInfo(tblProducerLine)}, {str2}";
          }
          object producerGuid = (object) DBNull.Value;
          object producerLocationGuid = (object) DBNull.Value;
          if (this._entireProducer || !this._producerGuid.Equals(Guid.Empty))
            producerGuid = (object) this._producerGuid;
          else
            producerLocationGuid = (object) this._producerLocationGuid;
          int num = DefaultDatabase.ExecuteScalar<int>("dbo.SaveProducerLines", new object[60]
          {
            (object) "@ProducerLineID",
            (object) tblProducerLine.ProducerLineID,
            (object) "@ProducerLocationGUID",
            producerLocationGuid,
            (object) "@UsingDefaultCommNew",
            (object) tblProducerLine.UsingDefaultCommNew,
            (object) "@UsingDefaultCommRenewal",
            (object) tblProducerLine.UsingDefaultCommRenewal,
            (object) "@CommNew",
            this.GetRowValue((DataRow) tblProducerLine, "CommNew", "D"),
            (object) "@CommRenewal",
            this.GetRowValue((DataRow) tblProducerLine, "CommRenewal", "D"),
            (object) "@AccountCurrent",
            (object) tblProducerLine.AccountCurrent,
            (object) "@DaysDue",
            this.GetRowValue((DataRow) tblProducerLine, "DaysDue", "I"),
            (object) "@DaysDueEndorsement",
            this.GetRowValue((DataRow) tblProducerLine, "DaysDueEndorsement", "I"),
            (object) "@StatusID",
            (object) tblProducerLine.StatusID,
            (object) "@RenewalStatusID",
            (object) tblProducerLine.RenewalStatusID,
            (object) "@Effective",
            (object) tblProducerLine.Effective,
            (object) "@CompanyLocationGuid",
            this.GetRowValue((DataRow) tblProducerLine, "CompanyLocationGuid", "G"),
            (object) "@LineGuid",
            this.GetRowValue((DataRow) tblProducerLine, "LineGuid", "G"),
            (object) "@StateID",
            this.GetRowValue((DataRow) tblProducerLine, "StateID", "S"),
            (object) "@ProducerGuid",
            producerGuid,
            (object) "@Blocked",
            (object) tblProducerLine.Blocked,
            (object) "@ApplyToPackageOnly",
            this.GetRowValue((DataRow) tblProducerLine, "ApplyToPackageOnly", "B"),
            (object) "@PackageLine",
            this.GetRowValue((DataRow) tblProducerLine, "PackageLine", "G"),
            (object) "@GAAP",
            this.GetRowValue((DataRow) tblProducerLine, "GAAP", "B"),
            (object) "@QuotingLocationGuid",
            this.GetRowValue((DataRow) tblProducerLine, "QuotingLocationGuid", "G"),
            (object) "@CompanyCommissionNew",
            this.GetRowValue((DataRow) tblProducerLine, "CompanyCommissionNew", "D"),
            (object) "@CompanyCommissionRenewal",
            this.GetRowValue((DataRow) tblProducerLine, "CompanyCommissionRenewal", "D"),
            (object) "@EndOfMonthEffDatePlusDays",
            this.GetRowValue((DataRow) tblProducerLine, "EndOfMonthEffDatePlusDays", "I"),
            (object) "@EffectiveDatePlusDays",
            this.GetRowValue((DataRow) tblProducerLine, "EffectiveDatePlusDays", "I"),
            (object) "@UseEndOfMonthEffDatePlusDays",
            this.GetRowValue((DataRow) tblProducerLine, "UseEndOfMonthEffDatePlusDays", "B"),
            (object) "@Prod_KeepExpCommissionsOnRenewal",
            this.GetRowValue((DataRow) tblProducerLine, "Prod_KeepExpCommissionsOnRenewal", "B"),
            (object) "@ApplyPremiumEqualOrLess",
            this.GetRowValue((DataRow) tblProducerLine, "ApplyPremiumEqualOrLess", "D"),
            (object) "@ApplyPremiumEqualOrOver",
            this.GetRowValue((DataRow) tblProducerLine, "ApplyPremiumEqualOrOver", "D"),
            (object) "@ApplyTargetPremumEqualOrOver",
            this.GetRowValue((DataRow) tblProducerLine, "ApplyTargetPremumEqualOrOver", "D")
          });
          CurrentUser.Instance.LogAction(action, identifier);
          if (flag)
            tblProducerLine.ProducerLineID = num;
        }
        this.AfterBaseSave(tblProducerLine.ProducerLineID);
        if (!flag || this.dsProducers.tblProducerLines.Rows.Count <= 0)
          return;
        this._bmb.Position = this.dsProducers.tblProducerLines.Rows.Count - 1;
        this.dsProducers.AcceptChanges();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      e.Cancel = true;
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
      MDIControls.Instance.StatusBarText = "Producer line information saved succesfully.";
    }
  }

  private object GetRowValue(DataRow r, string columnName, string dataType)
  {
    return !r.IsNull(columnName) ? r[columnName] : (!dataType.Equals("B") ? (object) DBNull.Value : (object) false);
  }

  private bool DataTableModified(DataRow currRow)
  {
    bool flag;
    switch (currRow.RowState)
    {
      case DataRowState.Added:
      case DataRowState.Deleted:
        flag = false;
        break;
      default:
        try
        {
          foreach (DataColumn column in (InternalDataCollectionBase) currRow.Table.Columns)
          {
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            if (currRow[column, DataRowVersion.Original] != DBNull.Value)
              empty1 = currRow[column, DataRowVersion.Original].ToString();
            if (currRow[column] != DBNull.Value)
              empty2 = currRow[column].ToString();
            if (!empty1.Equals(empty2))
            {
              flag = true;
              goto label_14;
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        flag = false;
        break;
    }
label_14:
    return flag;
  }

  private string GetEntityTableValue(
    string columnName,
    dsProducersLinesStates.tblProducerLinesRow row,
    object rowValue)
  {
    string entityTableValue = string.Empty;
    string Left = columnName;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "LineGuid", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "QuotingLocationGuid", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "CompanyLocationGuid", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "StatusID", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "RenewalStatusID", false) != 0)
          {
            DateTime result;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Effective", false) == 0 && DateTime.TryParse(rowValue.ToString(), out result))
              entityTableValue = result.ToString("MM/dd/yyyy");
          }
          else
          {
            int result;
            if (int.TryParse(rowValue.ToString(), out result))
            {
              dsProducersLinesStates.lstStatusRow byStatusId = this.dsProducers.lstStatus.FindByStatusID(result);
              if (byStatusId != null)
                entityTableValue = byStatusId.Status;
            }
          }
        }
        else
        {
          Guid result;
          if (!row.IsCompanyLocationGuidNull() && Guid.TryParse(rowValue.ToString(), out result))
          {
            dsProducersLinesStates.tblCompanyLocationsRow companyLocationGuid = this.dsProducers.tblCompanyLocations.FindByCompanyLocationGUID(result);
            if (companyLocationGuid != null)
              entityTableValue = companyLocationGuid.Name;
          }
        }
      }
      else
      {
        Guid result;
        if (!row.IsQuotingLocationGuidNull() && Guid.TryParse(rowValue.ToString(), out result))
        {
          dsProducersLinesStates.tblClientOfficesRow byOfficeGuid = this.dsProducers.tblClientOffices.FindByOfficeGuid(result);
          if (byOfficeGuid != null)
            entityTableValue = byOfficeGuid.Location;
        }
      }
    }
    else
    {
      Guid result;
      if (!row.IsLineGuidNull() && Guid.TryParse(rowValue.ToString(), out result))
      {
        dsProducersLinesStates.lstLinesRow byLineGuid = this.dsProducers.lstLines.FindByLineGUID(result);
        if (byLineGuid != null)
          entityTableValue = byLineGuid.LineName;
      }
    }
    return entityTableValue;
  }

  public virtual void AfterBaseSave(int producerLineID)
  {
  }

  private void _bmb_PositionChanged(object sender, EventArgs e)
  {
    if (this._bmb.Position == -1)
      return;
    ((UltraToggleEditorBase) this.chkUseCompanyDaysDue).Checked = this.dsProducers.tblProducerLines[this._bmb.Position].IsDaysDueNull();
    ((UltraToggleEditorBase) this.chkUseCompanyEndorsementDaysDue).Checked = this.dsProducers.tblProducerLines[this._bmb.Position].IsDaysDueEndorsementNull();
    ((Control) this.txtDaysDue).Enabled = !((UltraToggleEditorBase) this.chkUseCompanyDaysDue).Checked;
    ((Control) this.txtEndorsementDaysDue).Enabled = !((UltraToggleEditorBase) this.chkUseCompanyEndorsementDaysDue).Checked;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Checked = this.dsProducers.tblProducerLines[this._bmb.Position].GAAP;
    ((UltraToggleEditorBase) this.chkEffectiveDatePlus).Checked = !this.dsProducers.tblProducerLines[this._bmb.Position].IsEffectiveDatePlusDaysNull();
    ((UltraToggleEditorBase) this.chkEndOfMonthPlus).Checked = this.dsProducers.tblProducerLines[this._bmb.Position].UseEndOfMonthEffDatePlusDays;
    ((UltraToggleEditorBase) this.chkKeepExpiringOnRenewal).Checked = this.dsProducers.tblProducerLines[this._bmb.Position].Prod_KeepExpCommissionsOnRenewal;
    this.EnableAddlPaymentTerms();
    this.BindingMananagerPositionChanged(this.dsProducers.tblProducerLines[this._bmb.Position]);
  }

  public virtual void BindingMananagerPositionChanged(dsProducersLinesStates.tblProducerLinesRow row)
  {
  }

  private void chkUseCompanyDaysDue_CheckedChanged(object sender, EventArgs e)
  {
    if (this._bmb.Position < 0)
      return;
    if (((UltraToggleEditorBase) this.chkUseCompanyDaysDue).Checked)
    {
      ((TextEditorControlBase) this.txtDaysDue).Value = (object) null;
      ((Control) this.txtDaysDue).Enabled = false;
      if (!this._isFormLoaded)
        return;
      this.dsProducers.tblProducerLines[this._bmb.Position].SetDaysDueNull();
    }
    else
      ((Control) this.txtDaysDue).Enabled = true;
  }

  private void chkUseCompanyEndorsementDaysDue_CheckedChanged(object sender, EventArgs e)
  {
    if (this._bmb.Position < 0)
      return;
    if (((UltraToggleEditorBase) this.chkUseCompanyEndorsementDaysDue).Checked)
    {
      ((TextEditorControlBase) this.txtEndorsementDaysDue).Value = (object) null;
      ((Control) this.txtEndorsementDaysDue).Enabled = false;
      if (!this._isFormLoaded)
        return;
      this.dsProducers.tblProducerLines[this._bmb.Position].SetDaysDueEndorsementNull();
    }
    else
      ((Control) this.txtEndorsementDaysDue).Enabled = true;
  }

  private void linkApplyFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.FillProducerLinesData();
  }

  private void FillProducerLinesData()
  {
    this.dsProducers.tblProducerLines.Clear();
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      string[] strArray1 = new string[1]
      {
        "tblProducerLines"
      };
      dsProducersLinesStates dsProducers = this.dsProducers;
      string[] strArray2 = strArray1;
      object[] objArray = new object[10];
      objArray[0] = (object) "@ProducerGuid";
      Guid guid1 = this._producerGuid;
      Guid guid2;
      if (!guid1.Equals(Guid.Empty))
      {
        guid2 = this._producerGuid;
      }
      else
      {
        guid1 = new Guid();
        guid2 = guid1;
      }
      objArray[1] = (object) guid2;
      objArray[2] = (object) "@ProducerLocationGuid";
      guid1 = this._producerLocationGuid;
      Guid guid3;
      if (!guid1.Equals(Guid.Empty))
      {
        guid3 = this._producerLocationGuid;
      }
      else
      {
        guid1 = new Guid();
        guid3 = guid1;
      }
      objArray[3] = (object) guid3;
      objArray[4] = (object) "@CompanyLocationGuid";
      objArray[5] = this.comboCompanyFilter.Value;
      objArray[6] = (object) "@LineGuid";
      objArray[7] = this.comboLineFilter.Value;
      objArray[8] = (object) "@StateID";
      objArray[9] = this.comboStateFilter.Value;
      DefaultDatabase.LoadDataSet((DataSet) dsProducers, strArray2, "dbo.spGetProducerLinesData", objArray);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    try
    {
      foreach (dsProducersLinesStates.tblProducerLinesRow tblProducerLine in (TypedTableBase<dsProducersLinesStates.tblProducerLinesRow>) this.dsProducers.tblProducerLines)
        tblProducerLine.Entity = !tblProducerLine.IsProducerGuidNull() || tblProducerLine.IsProducerLocationGUIDNull() ? (tblProducerLine.IsProducerGuidNull() || !tblProducerLine.IsProducerLocationGUIDNull() ? string.Empty : "Producer") : "Location";
    }
    finally
    {
      IEnumerator<dsProducersLinesStates.tblProducerLinesRow> enumerator;
      enumerator?.Dispose();
    }
    this.SetUIState();
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    this._clickedEdit = false;
    if (MessageBox.Show("Are you sure you want to delete this setup?", "Delete Setup?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    int producerLineId1 = this.dsProducers.tblProducerLines[this._bmb.Position].ProducerLineID;
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      Guid identifier;
      string str;
      if (this._producerGuid.Equals(Guid.Empty))
      {
        identifier = this._producerLocationGuid;
        str = "Producer Location:  " + ((ControlBase) this.labelProducerLocation).Text;
      }
      else
      {
        identifier = this._producerGuid;
        str = "Producer:  " + ((ControlBase) this.labelProducer).Text;
      }
      dsProducersLinesStates.tblProducerLinesRow tblProducerLine = this.dsProducers.tblProducerLines[this._bmb.Position];
      string action = $"The producer line was deleted for {str}: {this.GetLineCompanyLocQuotingOfficeInfo(tblProducerLine)}";
      int producerLineId2 = tblProducerLine.ProducerLineID;
      this.dsProducers.tblProducerLines[this._bmb.Position].Delete();
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblProducerLines WHERE  ProducerLineID = @ID", new object[2]
      {
        (object) "@ID",
        (object) producerLineId2
      });
      this.dsProducers.tblProducerLines.AcceptChanges();
      CurrentUser.Instance.LogAction(action, identifier);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    this.SetUIState();
  }

  private string GetLineCompanyLocQuotingOfficeInfo(dsProducersLinesStates.tblProducerLinesRow dr)
  {
    return $"Line: {this.GetEntityTableValue("LineGuid", dr, (object) dr["LineGuid", DataRowVersion.Current].ToString())}, Company Location: {this.GetEntityTableValue("CompanyLocationGuid", dr, (object) dr["CompanyLocationGuid", DataRowVersion.Current].ToString())}, Quoting Office: {this.GetEntityTableValue("QuotingLocationGuid", dr, (object) dr["QuotingLocationGuid", DataRowVersion.Current].ToString())}";
  }

  private void chkEndOfMonthPlus_CheckedChanged(object sender, EventArgs e)
  {
    if (this._bmb.Position < 0)
      return;
    if (((UltraToggleEditorBase) this.chkEndOfMonthPlus).Checked)
    {
      ((Control) this.txtEndofMonthPlus).Enabled = true;
    }
    else
    {
      ((TextEditorControlBase) this.txtEndofMonthPlus).Value = (object) null;
      ((Control) this.txtEndofMonthPlus).Enabled = false;
      if (this._isFormLoaded)
        this.dsProducers.tblProducerLines[this._bmb.Position].SetEndOfMonthEffDatePlusDaysNull();
    }
    if (!this._isFormLoaded)
      return;
    this.dsProducers.tblProducerLines[this._bmb.Position].UseEndOfMonthEffDatePlusDays = ((UltraToggleEditorBase) this.chkEndOfMonthPlus).Checked;
  }

  private void chkEffectiveDatePlus_CheckedChanged(object sender, EventArgs e)
  {
    if (this._bmb.Position < 0)
      return;
    if (((UltraToggleEditorBase) this.chkEffectiveDatePlus).Checked)
    {
      ((Control) this.txtEffectiveDatePlus).Enabled = true;
    }
    else
    {
      ((TextEditorControlBase) this.txtEffectiveDatePlus).Value = (object) null;
      ((Control) this.txtEffectiveDatePlus).Enabled = false;
      if (!this._isFormLoaded)
        return;
      this.dsProducers.tblProducerLines[this._bmb.Position].SetEffectiveDatePlusDaysNull();
    }
  }

  private void MgaCheckBox1_CheckedChanged(object sender, EventArgs e)
  {
    if (this._bmb.Position < 0)
      return;
    this.EnableAddlPaymentTerms();
  }

  private void EnableAddlPaymentTerms()
  {
    if (((UltraToggleEditorBase) this.MgaCheckBox1).Checked)
    {
      ((Control) this.chkEndOfMonthPlus).Enabled = true;
      ((Control) this.chkEffectiveDatePlus).Enabled = true;
      ((Control) this.txtEffectiveDatePlus).Enabled = ((UltraToggleEditorBase) this.chkEffectiveDatePlus).Checked;
      ((Control) this.txtEndofMonthPlus).Enabled = ((UltraToggleEditorBase) this.chkEndOfMonthPlus).Checked;
    }
    else
    {
      ((Control) this.chkEndOfMonthPlus).Enabled = false;
      ((Control) this.chkEffectiveDatePlus).Enabled = false;
      ((Control) this.txtEffectiveDatePlus).Enabled = false;
      ((Control) this.txtEndofMonthPlus).Enabled = false;
      ((UltraToggleEditorBase) this.chkEndOfMonthPlus).Checked = false;
      ((UltraToggleEditorBase) this.chkEffectiveDatePlus).Checked = false;
    }
    if (!this._isFormLoaded)
      return;
    this.dsProducers.tblProducerLines[this._bmb.Position].GAAP = ((UltraToggleEditorBase) this.MgaCheckBox1).Checked;
  }

  protected virtual bool AccountCurrentDefault => false;

  protected virtual bool GaapDefault => false;

  private void cboCompanies_ValueChanged(object sender, EventArgs e) => this.SetPaymentTerm();

  private void cboLines_ValueChanged(object sender, EventArgs e) => this.SetPaymentTerm();

  private void cboStates_ValueChanged(object sender, EventArgs e) => this.SetPaymentTerm();

  private void SetPaymentTerm()
  {
    try
    {
      if (!this._isFormLoaded || this._clickedEdit || this._bmb.Position < 0 || this.dsProducers.tblProducerLines[this._bmb.Position].RowState == DataRowState.Deleted || this.dsProducers.tblProducerLines[this._bmb.Position].RowState != DataRowState.Added)
        return;
      if (!this.HasValidCompanyLine)
        return;
      try
      {
        Guid? parentLineGuid;
        CompanyLine companyLine = new CompanyLine(this.CompanyLocationGuid, this.LineGuid, this.StateID, parentLineGuid);
        if (!Utility.IsNull((object) companyLine.DefaultProducerTermsOfPayment))
        {
          this.dsProducers.tblProducerLines[this._bmb.Position].DaysDue = companyLine.DefaultProducerTermsOfPayment;
          ((TextEditorControlBase) this.txtDaysDue).Value = (object) this.dsProducers.tblProducerLines[this._bmb.Position].DaysDue;
          ((Control) this.txtDaysDue).Enabled = true;
        }
        try
        {
          int num = 0;
          do
          {
            ((UltraToggleEditorBase) this.chkUseCompanyDaysDue).CheckedChanged -= new EventHandler(this.chkUseCompanyDaysDue_CheckedChanged);
            ++num;
          }
          while (num <= 3);
          ((UltraToggleEditorBase) this.chkUseCompanyDaysDue).Checked = false;
        }
        finally
        {
          ((UltraToggleEditorBase) this.chkUseCompanyDaysDue).CheckedChanged += new EventHandler(this.chkUseCompanyDaysDue_CheckedChanged);
        }
      }
      catch (CompanyLine.CompanyLineGuidNotFoundException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void dbSave_ClickedEdit(object sender, EventArgs e) => this._clickedEdit = true;
}

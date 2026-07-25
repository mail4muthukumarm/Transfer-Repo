// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Clearance.TabClearanceSearch
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinDock;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinListView;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.Common;
using MGASystems.Common.DockingManagement;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.HotKeyManagement;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.Serialization;
using MGASystems.IMS.Security;
using MGASystems.Tools;
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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Clearance;

[SecureTabResource("{59E11BBE-415C-4eac-9AE3-CC675A0DA02A}", "Clearance Search", "Controls whether or not the tab will be loaded at runtime.", "Clearance")]
[SecureResource("{CDC44561-14F4-4c8c-B485-1FF4B71C3A84}", "Allow Access to Unbound Quotes", "Allows users to view unbound quotes in the clearance search", "Clearance")]
[SecureHotkeyResource("{9CAF7677-3F75-4119-8039-D89370362156}", "Clearance Search", "Controls whether or not the user has the ability to view the clearance search by using the HotKey bar or View menu", "Clearance")]
[HotKeyInfo("ClearanceSearch", "Clearance Search", "Clearance Search", Keys.F2, "MGASystems.Tools.clearancesearch24.bmp")]
[Preference("Clearance.AutoSuggest", true)]
[Preference("TabClearanceSearchLimitValue", 25)]
[Preference("TabClearanceSearch.MaxSearchResults", -1)]
[Preference("PREFERENCE_CLEARANCESEARCH_SHOWALLINSUREDCHECKED", false)]
public class TabClearanceSearch : DelayLoadUserControl, IDockingInfoProvider, IHotKeyDisplayItem
{
  private IContainer components;
  private Label Label1;
  private ToolTip ToolTip1;
  private DataView dvInsuredState;
  private DataView dvPolicyState;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private Label Label17;
  private MGATextBox txtInsuredCode;
  private Label Label15;
  private MGAMaskedEdit txtFEIN;
  private Label Label7;
  private MGATextBox txtAddress;
  private Label Label2;
  private MGASimpleComboBox cboInsuredType;
  private Label Label9;
  private Label Label13;
  private Label Label6;
  private MGASimpleComboBox cboProducer;
  private MGASimpleComboBox cboPolicyState;
  private Label Label16;
  private Label Label8;
  private MGATextBox txtControlNo;
  private MGASimpleComboBox cboPolicyStatus;
  private Label Label3;
  private MGATextBox txtPolicyNum;
  private Label Label5;
  private Label Label4;
  private Label Label14;
  private UltraTabPageControl tabProducer;
  private UltraTabPageControl tabCompany;
  private Label Label11;
  private MGASimpleComboBox cboCompanyLocations;
  private ErrorProvider err;
  private MGADateTimePicker dtEffectiveEnd;
  private MGADateTimePicker dtExpirationEnd;
  private Label Label18;
  private Label Label19;
  private MGACheckBox chkHideVoid;
  private DataView dvQuotingOffice;
  private Label Label10;
  internal const string SecurityIDTabClearanceSearchHotKey = "{9CAF7677-3F75-4119-8039-D89370362156}";
  internal const string SecurityIDTabClearanceSearchTab = "{59E11BBE-415C-4eac-9AE3-CC675A0DA02A}";
  public const string AllowUnboundStatusOnly = "{CDC44561-14F4-4c8c-B485-1FF4B71C3A84}";
  internal const string PREFERENCE_CLEARANCESEARCH_SHOWALLINSUREDCHECKED = "PREFERENCE_CLEARANCESEARCH_SHOWALLINSUREDCHECKED";
  private bool _limitToBoundStatusOnly;
  private Guid _currentUserGuid;
  private bool inDelayLoad;
  private int SubmissionGroupID;
  private int ShowAll_InsuredID;
  private bool _flag;
  private Thread _suggestThread;
  private string ShowAll_InsuredName;

  private virtual MGATextBox txtInsured
  {
    get => this._txtInsured;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.TxtInsured_KeyDown);
      EventHandler eventHandler = new EventHandler(this.TxtInsured_LostFocus);
      MGATextBox txtInsured1 = this._txtInsured;
      if (txtInsured1 != null)
      {
        ((Control) txtInsured1).KeyDown -= keyEventHandler;
        ((Control) txtInsured1).LostFocus -= eventHandler;
      }
      this._txtInsured = value;
      MGATextBox txtInsured2 = this._txtInsured;
      if (txtInsured2 == null)
        return;
      ((Control) txtInsured2).KeyDown += keyEventHandler;
      ((Control) txtInsured2).LostFocus += eventHandler;
    }
  }

  private virtual MGAButton btnSearch
  {
    get => this._btnSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.BtnSearch_Click);
      EventHandler eventHandler2 = new EventHandler(this.TxtInsured_LostFocus);
      MGAButton btnSearch1 = this._btnSearch;
      if (btnSearch1 != null)
      {
        ((Control) btnSearch1).Click -= eventHandler1;
        ((Control) btnSearch1).MouseEnter -= eventHandler2;
      }
      this._btnSearch = value;
      MGAButton btnSearch2 = this._btnSearch;
      if (btnSearch2 == null)
        return;
      ((Control) btnSearch2).Click += eventHandler1;
      ((Control) btnSearch2).MouseEnter += eventHandler2;
    }
  }

  private virtual MGAButton btnReset
  {
    get => this._btnReset;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BtnReset_Click);
      MGAButton btnReset1 = this._btnReset;
      if (btnReset1 != null)
        ((Control) btnReset1).Click -= eventHandler;
      this._btnReset = value;
      MGAButton btnReset2 = this._btnReset;
      if (btnReset2 == null)
        return;
      ((Control) btnReset2).Click += eventHandler;
    }
  }

  private virtual MGASimpleComboBox cboInsuredState
  {
    get => this._cboInsuredState;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CboInsuredState_ValueChanged);
      MGASimpleComboBox cboInsuredState1 = this._cboInsuredState;
      if (cboInsuredState1 != null)
        ((UltraCombo) cboInsuredState1).ValueChanged -= eventHandler;
      this._cboInsuredState = value;
      MGASimpleComboBox cboInsuredState2 = this._cboInsuredState;
      if (cboInsuredState2 == null)
        return;
      ((UltraCombo) cboInsuredState2).ValueChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkInForce
  {
    get => this._chkInForce;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChkInForce_CheckedChanged);
      MGACheckBox chkInForce1 = this._chkInForce;
      if (chkInForce1 != null)
        ((UltraToggleEditorBase) chkInForce1).CheckedChanged -= eventHandler;
      this._chkInForce = value;
      MGACheckBox chkInForce2 = this._chkInForce;
      if (chkInForce2 == null)
        return;
      ((UltraToggleEditorBase) chkInForce2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("tab_Insured")]
  protected virtual UltraTabPageControl tab_Insured { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabPolicy")]
  protected virtual UltraTabPageControl tabPolicy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraTabControl tabAdvancedFilters
  {
    get => this._tabAdvancedFilters;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      SelectedTabChangedEventHandler changedEventHandler = new SelectedTabChangedEventHandler(this.TabCompany_SelectedTabChanged);
      UltraTabControl tabAdvancedFilters1 = this._tabAdvancedFilters;
      if (tabAdvancedFilters1 != null)
        ((UltraTabControlBase) tabAdvancedFilters1).SelectedTabChanged -= changedEventHandler;
      this._tabAdvancedFilters = value;
      UltraTabControl tabAdvancedFilters2 = this._tabAdvancedFilters;
      if (tabAdvancedFilters2 == null)
        return;
      ((UltraTabControlBase) tabAdvancedFilters2).SelectedTabChanged += changedEventHandler;
    }
  }

  [field: AccessedThroughProperty("cboLine")]
  private virtual MGASimpleComboBox cboLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtEffectiveStart")]
  private virtual MGADateTimePicker dtEffectiveStart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtExpirationStart")]
  private virtual MGADateTimePicker dtExpirationStart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  protected virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboPolicyType")]
  protected virtual MGASimpleComboBox cboPolicyType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboUnderwriters")]
  protected virtual MGASimpleComboBox cboUnderwriters { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label21")]
  protected virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsTabClearance ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual System.Windows.Forms.Timer timerSearchDelay
  {
    get => this._timerSearchDelay;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.TimerSearchDelay_Tick);
      System.Windows.Forms.Timer timerSearchDelay1 = this._timerSearchDelay;
      if (timerSearchDelay1 != null)
        timerSearchDelay1.Tick -= eventHandler;
      this._timerSearchDelay = value;
      System.Windows.Forms.Timer timerSearchDelay2 = this._timerSearchDelay;
      if (timerSearchDelay2 == null)
        return;
      timerSearchDelay2.Tick += eventHandler;
    }
  }

  private virtual MGANumericEditor numResults
  {
    get => this._numResults;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.NumResults_ValueChanged);
      MGANumericEditor numResults1 = this._numResults;
      if (numResults1 != null)
        ((UltraNumericEditorBase) numResults1).ValueChanged -= eventHandler;
      this._numResults = value;
      MGANumericEditor numResults2 = this._numResults;
      if (numResults2 == null)
        return;
      ((UltraNumericEditorBase) numResults2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("optionSearch")]
  private virtual UltraOptionSet optionSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label22")]
  private virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  protected virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvStates")]
  private virtual DataView dvStates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboQuotingOffice")]
  protected virtual MGASimpleComboBox cboQuotingOffice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboIssuingOffice")]
  private virtual MGASimpleComboBox cboIssuingOffice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkQuickJump
  {
    get => this._lnkQuickJump;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkQuickJump_LinkClicked);
      LinkLabel lnkQuickJump1 = this._lnkQuickJump;
      if (lnkQuickJump1 != null)
        lnkQuickJump1.LinkClicked -= clickedEventHandler;
      this._lnkQuickJump = value;
      LinkLabel lnkQuickJump2 = this._lnkQuickJump;
      if (lnkQuickJump2 == null)
        return;
      lnkQuickJump2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("chkOpenInNewWindow")]
  private virtual MGACheckBox chkOpenInNewWindow { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel linkPolicyNumberQuickJump
  {
    get => this._linkPolicyNumberQuickJump;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkPolicyNumberQuickJump_LinkClicked);
      LinkLabel policyNumberQuickJump1 = this._linkPolicyNumberQuickJump;
      if (policyNumberQuickJump1 != null)
        policyNumberQuickJump1.LinkClicked -= clickedEventHandler;
      this._linkPolicyNumberQuickJump = value;
      LinkLabel policyNumberQuickJump2 = this._linkPolicyNumberQuickJump;
      if (policyNumberQuickJump2 == null)
        return;
      policyNumberQuickJump2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual UltraListView listSuggest
  {
    get => this._listSuggest;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemSelectionChangedEventHandler changedEventHandler = new ItemSelectionChangedEventHandler(this.ListSuggest_ItemSelectionChanged);
      EventHandler eventHandler = new EventHandler(this.ListSuggest_MouseLeave);
      UltraListView listSuggest1 = this._listSuggest;
      if (listSuggest1 != null)
      {
        listSuggest1.ItemSelectionChanged -= changedEventHandler;
        ((Control) listSuggest1).MouseLeave -= eventHandler;
      }
      this._listSuggest = value;
      UltraListView listSuggest2 = this._listSuggest;
      if (listSuggest2 == null)
        return;
      listSuggest2.ItemSelectionChanged += changedEventHandler;
      ((Control) listSuggest2).MouseLeave += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtInsuredPhone")]
  private virtual MGAMaskedEdit txtInsuredPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPhone")]
  private virtual Label lblPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label23")]
  private virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSubmissionNumber")]
  private virtual MGATextBox txtSubmissionNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabUndLocations")]
  protected virtual UltraTabPageControl tabUndLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGATextBox txtLocZip
  {
    get => this._txtLocZip;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.TxtLocZip_AfterExitEditMode);
      MGATextBox txtLocZip1 = this._txtLocZip;
      if (txtLocZip1 != null)
        ((TextEditorControlBase) txtLocZip1).AfterExitEditMode -= eventHandler;
      this._txtLocZip = value;
      MGATextBox txtLocZip2 = this._txtLocZip;
      if (txtLocZip2 == null)
        return;
      ((TextEditorControlBase) txtLocZip2).AfterExitEditMode += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label27")]
  private virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label26")]
  private virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label25")]
  private virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASimpleComboBox cboLocCity
  {
    get => this._cboLocCity;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CboLocCity_ValueChanged);
      MGASimpleComboBox cboLocCity1 = this._cboLocCity;
      if (cboLocCity1 != null)
        ((UltraCombo) cboLocCity1).ValueChanged -= eventHandler;
      this._cboLocCity = value;
      MGASimpleComboBox cboLocCity2 = this._cboLocCity;
      if (cboLocCity2 == null)
        return;
      ((UltraCombo) cboLocCity2).ValueChanged += eventHandler;
    }
  }

  protected virtual MGATextBox txtLocAddress
  {
    get => this._txtLocAddress;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.TxtLocAddress_AfterExitEditMode);
      MGATextBox txtLocAddress1 = this._txtLocAddress;
      if (txtLocAddress1 != null)
        ((TextEditorControlBase) txtLocAddress1).AfterExitEditMode -= eventHandler;
      this._txtLocAddress = value;
      MGATextBox txtLocAddress2 = this._txtLocAddress;
      if (txtLocAddress2 == null)
        return;
      ((TextEditorControlBase) txtLocAddress2).AfterExitEditMode += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label24")]
  private virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASimpleComboBox cboLocState
  {
    get => this._cboLocState;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CboLocState_ValueChanged);
      MGASimpleComboBox cboLocState1 = this._cboLocState;
      if (cboLocState1 != null)
        ((UltraCombo) cboLocState1).ValueChanged -= eventHandler;
      this._cboLocState = value;
      MGASimpleComboBox cboLocState2 = this._cboLocState;
      if (cboLocState2 == null)
        return;
      ((UltraCombo) cboLocState2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dvLocCity")]
  protected virtual DataView dvLocCity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkLocInForce")]
  protected virtual MGACheckBox chkLocInForce { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkSubmissionShowAll
  {
    get => this._lnkSubmissionShowAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkSubmissionShowAll_LinkClicked);
      LinkLabel submissionShowAll1 = this._lnkSubmissionShowAll;
      if (submissionShowAll1 != null)
        submissionShowAll1.LinkClicked -= clickedEventHandler;
      this._lnkSubmissionShowAll = value;
      LinkLabel submissionShowAll2 = this._lnkSubmissionShowAll;
      if (submissionShowAll2 == null)
        return;
      submissionShowAll2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("dvIssuingOffice")]
  private virtual DataView dvIssuingOffice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label28")]
  private virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAccountNumber")]
  private virtual MGATextBox txtAccountNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label29")]
  private virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtClaimNo")]
  private virtual MGATextBox txtClaimNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabDrivers")]
  protected virtual UltraTabPageControl tabDrivers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label37")]
  private virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDriverLast")]
  private virtual MGATextBox txtDriverLast { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label36")]
  private virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDriverFirst")]
  private virtual MGATextBox txtDriverFirst { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label35")]
  private virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDriverAddress")]
  private virtual MGATextBox txtDriverAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label34")]
  private virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDriverControlNo")]
  private virtual MGATextBox txtDriverControlNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkDriverInforce")]
  protected virtual MGACheckBox chkDriverInforce { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDriverZip")]
  protected virtual MGATextBox txtDriverZip { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label30")]
  private virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label31")]
  private virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDriverLicenseNumber")]
  protected virtual MGATextBox txtDriverLicenseNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label33")]
  private virtual Label Label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboDriverState")]
  protected virtual MGASimpleComboBox cboDriverState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabAdditionalInterest")]
  internal virtual UltraTabPageControl tabAdditionalInterest { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblInterestName")]
  private virtual Label lblInterestName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInterestName")]
  private virtual MGATextBox txtInterestName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label32")]
  private virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInterestLast")]
  private virtual MGATextBox txtInterestLast { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label38")]
  private virtual Label Label38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInterestFirst")]
  private virtual MGATextBox txtInterestFirst { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label39")]
  private virtual Label Label39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInterestAddress")]
  private virtual MGATextBox txtInterestAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label40")]
  private virtual Label Label40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInterestControlNo")]
  private virtual MGATextBox txtInterestControlNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkInterestInforce")]
  protected virtual MGACheckBox chkInterestInforce { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInterestZip")]
  protected virtual MGATextBox txtInterestZip { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label41")]
  private virtual Label Label41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label42")]
  private virtual Label Label42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInterest")]
  protected virtual MGATextBox txtInterest { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label43")]
  private virtual Label Label43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboInterestStateID")]
  protected virtual MGASimpleComboBox cboInterestStateID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMailingAddress")]
  protected virtual Label lblMailingAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgatxtMailingAdd")]
  protected virtual MGATextBox MgatxtMailingAdd { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkShowAll
  {
    get => this._lnkShowAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkShowAll_LinkClicked);
      LinkLabel lnkShowAll1 = this._lnkShowAll;
      if (lnkShowAll1 != null)
        lnkShowAll1.LinkClicked -= clickedEventHandler;
      this._lnkShowAll = value;
      LinkLabel lnkShowAll2 = this._lnkShowAll;
      if (lnkShowAll2 == null)
        return;
      lnkShowAll2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label44")]
  private virtual Label Label44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGATextBox txtProducerEmail
  {
    get => this._txtProducerEmail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.TxtProducerEmail_KeyDown);
      MGATextBox txtProducerEmail1 = this._txtProducerEmail;
      if (txtProducerEmail1 != null)
        ((Control) txtProducerEmail1).KeyDown -= keyEventHandler;
      this._txtProducerEmail = value;
      MGATextBox txtProducerEmail2 = this._txtProducerEmail;
      if (txtProducerEmail2 == null)
        return;
      ((Control) txtProducerEmail2).KeyDown += keyEventHandler;
    }
  }

  private virtual UltraListView lstSuggestEmail
  {
    get => this._lstSuggestEmail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemSelectionChangedEventHandler changedEventHandler = new ItemSelectionChangedEventHandler(this.LstSuggestEmail_ItemSelectionChanged);
      UltraListView lstSuggestEmail1 = this._lstSuggestEmail;
      if (lstSuggestEmail1 != null)
        lstSuggestEmail1.ItemSelectionChanged -= changedEventHandler;
      this._lstSuggestEmail = value;
      UltraListView lstSuggestEmail2 = this._lstSuggestEmail;
      if (lstSuggestEmail2 == null)
        return;
      lstSuggestEmail2.ItemSelectionChanged += changedEventHandler;
    }
  }

  private virtual MGACheckBox chkShowallInsured
  {
    get => this._chkShowallInsured;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChkShowallInsured_CheckedChanged);
      MGACheckBox chkShowallInsured1 = this._chkShowallInsured;
      if (chkShowallInsured1 != null)
        ((UltraToggleEditorBase) chkShowallInsured1).CheckedChanged -= eventHandler;
      this._chkShowallInsured = value;
      MGACheckBox chkShowallInsured2 = this._chkShowallInsured;
      if (chkShowallInsured2 == null)
        return;
      ((UltraToggleEditorBase) chkShowallInsured2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblInsuredCity")]
  private virtual Label lblInsuredCity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboInsuredCity")]
  protected virtual MGASimpleComboBox cboInsuredCity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvInsuredCity")]
  protected virtual DataView dvInsuredCity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtRiskID")]
  private virtual MGATextBox txtRiskID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblRiskID")]
  private virtual Label lblRiskID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
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
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance52 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TabClearanceSearch));
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance53 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance54 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance55 = new Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    UltraTab ultraTab6 = new UltraTab();
    Appearance appearance58 = new Appearance();
    UltraTab ultraTab7 = new UltraTab();
    Appearance appearance59 = new Appearance();
    this.tabPolicy = new UltraTabPageControl();
    this.chkShowallInsured = new MGACheckBox();
    this.lnkShowAll = new LinkLabel();
    this.lblMailingAddress = new Label();
    this.MgatxtMailingAdd = new MGATextBox();
    this.Label29 = new Label();
    this.txtClaimNo = new MGATextBox();
    this.Label28 = new Label();
    this.Label23 = new Label();
    this.txtAccountNumber = new MGATextBox();
    this.txtSubmissionNumber = new MGATextBox();
    this.linkPolicyNumberQuickJump = new LinkLabel();
    this.chkOpenInNewWindow = new MGACheckBox();
    this.lnkSubmissionShowAll = new LinkLabel();
    this.lnkQuickJump = new LinkLabel();
    this.cboIssuingOffice = new MGASimpleComboBox();
    this.dvIssuingOffice = new DataView();
    this.ds = new dsTabClearance();
    this.cboQuotingOffice = new MGASimpleComboBox();
    this.dvQuotingOffice = new DataView();
    this.Label22 = new Label();
    this.Label12 = new Label();
    this.cboUnderwriters = new MGASimpleComboBox();
    this.Label21 = new Label();
    this.chkHideVoid = new MGACheckBox();
    this.cboPolicyType = new MGASimpleComboBox();
    this.Label20 = new Label();
    this.Label19 = new Label();
    this.Label18 = new Label();
    this.dtExpirationEnd = new MGADateTimePicker();
    this.dtEffectiveEnd = new MGADateTimePicker();
    this.cboPolicyState = new MGASimpleComboBox();
    this.dvPolicyState = new DataView();
    this.Label16 = new Label();
    this.Label8 = new Label();
    this.txtControlNo = new MGATextBox();
    this.cboPolicyStatus = new MGASimpleComboBox();
    this.chkInForce = new MGACheckBox();
    this.Label3 = new Label();
    this.txtPolicyNum = new MGATextBox();
    this.dtEffectiveStart = new MGADateTimePicker();
    this.Label5 = new Label();
    this.Label4 = new Label();
    this.dtExpirationStart = new MGADateTimePicker();
    this.Label14 = new Label();
    this.tab_Insured = new UltraTabPageControl();
    this.txtRiskID = new MGATextBox();
    this.lblRiskID = new Label();
    this.lblInsuredCity = new Label();
    this.cboInsuredCity = new MGASimpleComboBox();
    this.dvInsuredCity = new DataView();
    this.txtInsuredPhone = new MGAMaskedEdit();
    this.lblPhone = new Label();
    this.cboInsuredState = new MGASimpleComboBox();
    this.dvInsuredState = new DataView();
    this.Label17 = new Label();
    this.txtInsuredCode = new MGATextBox();
    this.Label15 = new Label();
    this.txtFEIN = new MGAMaskedEdit();
    this.Label7 = new Label();
    this.txtAddress = new MGATextBox();
    this.Label2 = new Label();
    this.cboInsuredType = new MGASimpleComboBox();
    this.Label9 = new Label();
    this.optionSearch = new UltraOptionSet();
    this.btnReset = new MGAButton();
    this.btnSearch = new MGAButton();
    this.numResults = new MGANumericEditor();
    this.Label10 = new Label();
    this.tabCompany = new UltraTabPageControl();
    this.cboCompanyLocations = new MGASimpleComboBox();
    this.Label11 = new Label();
    this.cboLine = new MGASimpleComboBox();
    this.Label13 = new Label();
    this.tabProducer = new UltraTabPageControl();
    this.lstSuggestEmail = new UltraListView();
    this.Label44 = new Label();
    this.txtProducerEmail = new MGATextBox();
    this.Label6 = new Label();
    this.cboProducer = new MGASimpleComboBox();
    this.tabUndLocations = new UltraTabPageControl();
    this.chkLocInForce = new MGACheckBox();
    this.txtLocZip = new MGATextBox();
    this.Label27 = new Label();
    this.Label26 = new Label();
    this.Label25 = new Label();
    this.cboLocCity = new MGASimpleComboBox();
    this.dvLocCity = new DataView();
    this.txtLocAddress = new MGATextBox();
    this.Label24 = new Label();
    this.cboLocState = new MGASimpleComboBox();
    this.tabDrivers = new UltraTabPageControl();
    this.Label37 = new Label();
    this.txtDriverLast = new MGATextBox();
    this.Label36 = new Label();
    this.txtDriverFirst = new MGATextBox();
    this.Label35 = new Label();
    this.txtDriverAddress = new MGATextBox();
    this.Label34 = new Label();
    this.txtDriverControlNo = new MGATextBox();
    this.chkDriverInforce = new MGACheckBox();
    this.txtDriverZip = new MGATextBox();
    this.Label30 = new Label();
    this.Label31 = new Label();
    this.txtDriverLicenseNumber = new MGATextBox();
    this.Label33 = new Label();
    this.cboDriverState = new MGASimpleComboBox();
    this.tabAdditionalInterest = new UltraTabPageControl();
    this.lblInterestName = new Label();
    this.txtInterestName = new MGATextBox();
    this.Label32 = new Label();
    this.txtInterestLast = new MGATextBox();
    this.Label38 = new Label();
    this.txtInterestFirst = new MGATextBox();
    this.Label39 = new Label();
    this.txtInterestAddress = new MGATextBox();
    this.Label40 = new Label();
    this.txtInterestControlNo = new MGATextBox();
    this.chkInterestInforce = new MGACheckBox();
    this.txtInterestZip = new MGATextBox();
    this.Label41 = new Label();
    this.Label42 = new Label();
    this.txtInterest = new MGATextBox();
    this.Label43 = new Label();
    this.cboInterestStateID = new MGASimpleComboBox();
    this.listSuggest = new UltraListView();
    this.txtInsured = new MGATextBox();
    this.Label1 = new Label();
    this.ToolTip1 = new ToolTip(this.components);
    this.tabAdvancedFilters = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.err = new ErrorProvider(this.components);
    this.timerSearchDelay = new System.Windows.Forms.Timer(this.components);
    this.dvStates = new DataView();
    ((Control) this.tabPolicy).SuspendLayout();
    ((ISupportInitialize) this.chkShowallInsured).BeginInit();
    ((ISupportInitialize) this.MgatxtMailingAdd).BeginInit();
    ((ISupportInitialize) this.txtClaimNo).BeginInit();
    ((ISupportInitialize) this.txtAccountNumber).BeginInit();
    ((ISupportInitialize) this.txtSubmissionNumber).BeginInit();
    ((ISupportInitialize) this.chkOpenInNewWindow).BeginInit();
    ((ISupportInitialize) this.cboIssuingOffice).BeginInit();
    this.dvIssuingOffice.BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboQuotingOffice).BeginInit();
    this.dvQuotingOffice.BeginInit();
    ((ISupportInitialize) this.cboUnderwriters).BeginInit();
    ((ISupportInitialize) this.chkHideVoid).BeginInit();
    ((ISupportInitialize) this.cboPolicyType).BeginInit();
    ((ISupportInitialize) this.dtExpirationEnd).BeginInit();
    ((ISupportInitialize) this.dtEffectiveEnd).BeginInit();
    ((ISupportInitialize) this.cboPolicyState).BeginInit();
    this.dvPolicyState.BeginInit();
    ((ISupportInitialize) this.txtControlNo).BeginInit();
    ((ISupportInitialize) this.cboPolicyStatus).BeginInit();
    ((ISupportInitialize) this.chkInForce).BeginInit();
    ((ISupportInitialize) this.txtPolicyNum).BeginInit();
    ((ISupportInitialize) this.dtEffectiveStart).BeginInit();
    ((ISupportInitialize) this.dtExpirationStart).BeginInit();
    ((Control) this.tab_Insured).SuspendLayout();
    ((ISupportInitialize) this.txtRiskID).BeginInit();
    ((ISupportInitialize) this.cboInsuredCity).BeginInit();
    this.dvInsuredCity.BeginInit();
    ((ISupportInitialize) this.txtInsuredPhone).BeginInit();
    ((ISupportInitialize) this.cboInsuredState).BeginInit();
    this.dvInsuredState.BeginInit();
    ((ISupportInitialize) this.txtInsuredCode).BeginInit();
    ((ISupportInitialize) this.txtFEIN).BeginInit();
    ((ISupportInitialize) this.txtAddress).BeginInit();
    ((ISupportInitialize) this.cboInsuredType).BeginInit();
    ((ISupportInitialize) this.optionSearch).BeginInit();
    ((ISupportInitialize) this.btnReset).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.numResults).BeginInit();
    ((Control) this.tabCompany).SuspendLayout();
    ((ISupportInitialize) this.cboCompanyLocations).BeginInit();
    ((ISupportInitialize) this.cboLine).BeginInit();
    ((Control) this.tabProducer).SuspendLayout();
    ((ISupportInitialize) this.lstSuggestEmail).BeginInit();
    ((ISupportInitialize) this.txtProducerEmail).BeginInit();
    ((ISupportInitialize) this.cboProducer).BeginInit();
    ((Control) this.tabUndLocations).SuspendLayout();
    ((ISupportInitialize) this.chkLocInForce).BeginInit();
    ((ISupportInitialize) this.txtLocZip).BeginInit();
    ((ISupportInitialize) this.cboLocCity).BeginInit();
    this.dvLocCity.BeginInit();
    ((ISupportInitialize) this.txtLocAddress).BeginInit();
    ((ISupportInitialize) this.cboLocState).BeginInit();
    ((Control) this.tabDrivers).SuspendLayout();
    ((ISupportInitialize) this.txtDriverLast).BeginInit();
    ((ISupportInitialize) this.txtDriverFirst).BeginInit();
    ((ISupportInitialize) this.txtDriverAddress).BeginInit();
    ((ISupportInitialize) this.txtDriverControlNo).BeginInit();
    ((ISupportInitialize) this.chkDriverInforce).BeginInit();
    ((ISupportInitialize) this.txtDriverZip).BeginInit();
    ((ISupportInitialize) this.txtDriverLicenseNumber).BeginInit();
    ((ISupportInitialize) this.cboDriverState).BeginInit();
    ((Control) this.tabAdditionalInterest).SuspendLayout();
    ((ISupportInitialize) this.txtInterestName).BeginInit();
    ((ISupportInitialize) this.txtInterestLast).BeginInit();
    ((ISupportInitialize) this.txtInterestFirst).BeginInit();
    ((ISupportInitialize) this.txtInterestAddress).BeginInit();
    ((ISupportInitialize) this.txtInterestControlNo).BeginInit();
    ((ISupportInitialize) this.chkInterestInforce).BeginInit();
    ((ISupportInitialize) this.txtInterestZip).BeginInit();
    ((ISupportInitialize) this.txtInterest).BeginInit();
    ((ISupportInitialize) this.cboInterestStateID).BeginInit();
    ((ISupportInitialize) this.listSuggest).BeginInit();
    ((ISupportInitialize) this.txtInsured).BeginInit();
    ((ISupportInitialize) this.tabAdvancedFilters).BeginInit();
    ((Control) this.tabAdvancedFilters).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.err).BeginInit();
    this.dvStates.BeginInit();
    ((Control) this).SuspendLayout();
    ((Control) this.tabPolicy).Controls.Add((Control) this.chkShowallInsured);
    ((Control) this.tabPolicy).Controls.Add((Control) this.lnkShowAll);
    ((Control) this.tabPolicy).Controls.Add((Control) this.lblMailingAddress);
    ((Control) this.tabPolicy).Controls.Add((Control) this.MgatxtMailingAdd);
    ((Control) this.tabPolicy).Controls.Add((Control) this.Label29);
    ((Control) this.tabPolicy).Controls.Add((Control) this.txtClaimNo);
    ((Control) this.tabPolicy).Controls.Add((Control) this.Label28);
    ((Control) this.tabPolicy).Controls.Add((Control) this.Label23);
    ((Control) this.tabPolicy).Controls.Add((Control) this.txtAccountNumber);
    ((Control) this.tabPolicy).Controls.Add((Control) this.txtSubmissionNumber);
    ((Control) this.tabPolicy).Controls.Add((Control) this.linkPolicyNumberQuickJump);
    ((Control) this.tabPolicy).Controls.Add((Control) this.chkOpenInNewWindow);
    ((Control) this.tabPolicy).Controls.Add((Control) this.lnkSubmissionShowAll);
    ((Control) this.tabPolicy).Controls.Add((Control) this.lnkQuickJump);
    ((Control) this.tabPolicy).Controls.Add((Control) this.cboIssuingOffice);
    ((Control) this.tabPolicy).Controls.Add((Control) this.cboQuotingOffice);
    ((Control) this.tabPolicy).Controls.Add((Control) this.Label22);
    ((Control) this.tabPolicy).Controls.Add((Control) this.Label12);
    ((Control) this.tabPolicy).Controls.Add((Control) this.cboUnderwriters);
    ((Control) this.tabPolicy).Controls.Add((Control) this.Label21);
    ((Control) this.tabPolicy).Controls.Add((Control) this.chkHideVoid);
    ((Control) this.tabPolicy).Controls.Add((Control) this.cboPolicyType);
    ((Control) this.tabPolicy).Controls.Add((Control) this.Label20);
    ((Control) this.tabPolicy).Controls.Add((Control) this.Label19);
    ((Control) this.tabPolicy).Controls.Add((Control) this.Label18);
    ((Control) this.tabPolicy).Controls.Add((Control) this.dtExpirationEnd);
    ((Control) this.tabPolicy).Controls.Add((Control) this.dtEffectiveEnd);
    ((Control) this.tabPolicy).Controls.Add((Control) this.cboPolicyState);
    ((Control) this.tabPolicy).Controls.Add((Control) this.Label16);
    ((Control) this.tabPolicy).Controls.Add((Control) this.Label8);
    ((Control) this.tabPolicy).Controls.Add((Control) this.txtControlNo);
    ((Control) this.tabPolicy).Controls.Add((Control) this.cboPolicyStatus);
    ((Control) this.tabPolicy).Controls.Add((Control) this.chkInForce);
    ((Control) this.tabPolicy).Controls.Add((Control) this.Label3);
    ((Control) this.tabPolicy).Controls.Add((Control) this.txtPolicyNum);
    ((Control) this.tabPolicy).Controls.Add((Control) this.dtEffectiveStart);
    ((Control) this.tabPolicy).Controls.Add((Control) this.Label5);
    ((Control) this.tabPolicy).Controls.Add((Control) this.Label4);
    ((Control) this.tabPolicy).Controls.Add((Control) this.dtExpirationStart);
    ((Control) this.tabPolicy).Controls.Add((Control) this.Label14);
    ((Control) this.tabPolicy).Controls.Add((Control) this.optionSearch);
    ((Control) this.tabPolicy).Controls.Add((Control) this.btnReset);
    ((Control) this.tabPolicy).Controls.Add((Control) this.btnSearch);
    ((Control) this.tabPolicy).Controls.Add((Control) this.numResults);
    ((Control) this.tabPolicy).Controls.Add((Control) this.Label10);
    ((Control) this.tabPolicy).Location = new Point(20, 1);
    ((Control) this.tabPolicy).Name = "tabPolicy";
    ((Control) this.tabPolicy).Size = new Size(286, 622);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkShowallInsured).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.chkShowallInsured).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkShowallInsured).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkShowallInsured).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkShowallInsured).Location = new Point(88, 595);
    this.chkShowallInsured.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkShowallInsured).Name = "chkShowallInsured";
    ((Control) this.chkShowallInsured).Size = new Size(181, 24);
    ((Control) this.chkShowallInsured).TabIndex = 42;
    ((UltraToggleEditorBase) this.chkShowallInsured).Text = "Show All Insured (Control #)";
    ((UltraControlBase) this.chkShowallInsured).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkShowallInsured).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkShowAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lnkShowAll.AutoSize = true;
    this.lnkShowAll.Location = new Point(220, 112 /*0x70*/);
    this.lnkShowAll.Name = "lnkShowAll";
    this.lnkShowAll.Size = new Size(55, 13);
    this.lnkShowAll.TabIndex = 41;
    this.lnkShowAll.TabStop = true;
    this.lnkShowAll.Text = "(Show All)";
    this.lnkShowAll.TextAlign = ContentAlignment.MiddleLeft;
    this.ToolTip1.SetToolTip((Control) this.lnkShowAll, "Will return all cards in that chosen cards Submission group");
    this.lblMailingAddress.AutoSize = true;
    this.lblMailingAddress.BackColor = Color.Transparent;
    this.lblMailingAddress.Location = new Point(35, 492);
    this.lblMailingAddress.Name = "lblMailingAddress";
    this.lblMailingAddress.Size = new Size(50, 13);
    this.lblMailingAddress.TabIndex = 40;
    this.lblMailingAddress.Text = "Address:";
    this.lblMailingAddress.TextAlign = ContentAlignment.MiddleRight;
    this.lblMailingAddress.Visible = false;
    ((Control) this.MgatxtMailingAdd).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgatxtMailingAdd).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.MgatxtMailingAdd).BackColor = Color.White;
    ((Control) this.MgatxtMailingAdd).Location = new Point(88, 489);
    this.MgatxtMailingAdd.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgatxtMailingAdd).Name = "MgatxtMailingAdd";
    ((Control) this.MgatxtMailingAdd).Size = new Size(153, 20);
    ((Control) this.MgatxtMailingAdd).TabIndex = 39;
    ((UltraControlBase) this.MgatxtMailingAdd).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgatxtMailingAdd).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgatxtMailingAdd).Visible = false;
    this.Label29.AutoSize = true;
    this.Label29.BackColor = Color.Transparent;
    this.Label29.Location = new Point(36, 466);
    this.Label29.Name = "Label29";
    this.Label29.Size = new Size(47, 13);
    this.Label29.TabIndex = 38;
    this.Label29.Text = "Claim #:";
    this.Label29.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtClaimNo).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtClaimNo).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtClaimNo).BackColor = Color.White;
    ((Control) this.txtClaimNo).Location = new Point(88, 463);
    this.txtClaimNo.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtClaimNo).Name = "txtClaimNo";
    ((Control) this.txtClaimNo).Size = new Size(153, 20);
    ((Control) this.txtClaimNo).TabIndex = 37;
    ((UltraControlBase) this.txtClaimNo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtClaimNo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label28.AutoSize = true;
    this.Label28.BackColor = Color.Transparent;
    this.Label28.Location = new Point(23, 165);
    this.Label28.Name = "Label28";
    this.Label28.Size = new Size(61, 13);
    this.Label28.TabIndex = 36;
    this.Label28.Text = "Account #:";
    this.Label28.TextAlign = ContentAlignment.MiddleRight;
    this.Label23.AutoSize = true;
    this.Label23.BackColor = Color.Transparent;
    this.Label23.Location = new Point(11, 138);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(74, 13);
    this.Label23.TabIndex = 36;
    this.Label23.Text = "Submission #:";
    this.Label23.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtAccountNumber).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAccountNumber).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtAccountNumber).BackColor = Color.White;
    ((Control) this.txtAccountNumber).Location = new Point(88, 161);
    this.txtAccountNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtAccountNumber).Name = "txtAccountNumber";
    ((Control) this.txtAccountNumber).Size = new Size(67, 20);
    ((Control) this.txtAccountNumber).TabIndex = 35;
    this.ToolTip1.SetToolTip((Control) this.txtAccountNumber, "Does an exact search");
    ((UltraControlBase) this.txtAccountNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAccountNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtSubmissionNumber).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSubmissionNumber).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtSubmissionNumber).BackColor = Color.White;
    ((Control) this.txtSubmissionNumber).Location = new Point(88, 134);
    this.txtSubmissionNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtSubmissionNumber).Name = "txtSubmissionNumber";
    ((Control) this.txtSubmissionNumber).Size = new Size(67, 20);
    ((Control) this.txtSubmissionNumber).TabIndex = 35;
    ((UltraControlBase) this.txtSubmissionNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSubmissionNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.linkPolicyNumberQuickJump.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.linkPolicyNumberQuickJump.AutoSize = true;
    this.linkPolicyNumberQuickJump.Location = new Point(156, 85);
    this.linkPolicyNumberQuickJump.Name = "linkPolicyNumberQuickJump";
    this.linkPolicyNumberQuickJump.Size = new Size(65, 13);
    this.linkPolicyNumberQuickJump.TabIndex = 19;
    this.linkPolicyNumberQuickJump.TabStop = true;
    this.linkPolicyNumberQuickJump.Text = "(quick jump)";
    this.linkPolicyNumberQuickJump.TextAlign = ContentAlignment.MiddleLeft;
    this.ToolTip1.SetToolTip((Control) this.linkPolicyNumberQuickJump, "Automatically takes you to the quote edit form (for quick quotes) or policy detail form");
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkOpenInNewWindow).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.chkOpenInNewWindow).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOpenInNewWindow).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOpenInNewWindow).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkOpenInNewWindow).Location = new Point(88, 568);
    this.chkOpenInNewWindow.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkOpenInNewWindow).Name = "chkOpenInNewWindow";
    ((Control) this.chkOpenInNewWindow).Size = new Size(136, 24);
    ((Control) this.chkOpenInNewWindow).TabIndex = 16 /*0x10*/;
    ((UltraToggleEditorBase) this.chkOpenInNewWindow).Text = "Open In New Window";
    ((UltraControlBase) this.chkOpenInNewWindow).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkOpenInNewWindow).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkSubmissionShowAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lnkSubmissionShowAll.AutoSize = true;
    this.lnkSubmissionShowAll.Location = new Point(156, 137);
    this.lnkSubmissionShowAll.Name = "lnkSubmissionShowAll";
    this.lnkSubmissionShowAll.Size = new Size(53, 13);
    this.lnkSubmissionShowAll.TabIndex = 20;
    this.lnkSubmissionShowAll.TabStop = true;
    this.lnkSubmissionShowAll.Text = "(show all)";
    this.lnkSubmissionShowAll.TextAlign = ContentAlignment.MiddleLeft;
    this.ToolTip1.SetToolTip((Control) this.lnkSubmissionShowAll, "Finds all submissions for the insured\r\nassociated with the specified submission.");
    this.lnkQuickJump.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lnkQuickJump.AutoSize = true;
    this.lnkQuickJump.Location = new Point(155, 112 /*0x70*/);
    this.lnkQuickJump.Name = "lnkQuickJump";
    this.lnkQuickJump.Size = new Size(65, 13);
    this.lnkQuickJump.TabIndex = 20;
    this.lnkQuickJump.TabStop = true;
    this.lnkQuickJump.Text = "(quick jump)";
    this.lnkQuickJump.TextAlign = ContentAlignment.MiddleLeft;
    this.ToolTip1.SetToolTip((Control) this.lnkQuickJump, "Automatically takes you to the quote edit form (for quick quotes) or policy detail form");
    ((UltraCombo) this.cboIssuingOffice).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboIssuingOffice).DataSource = (object) this.dvIssuingOffice;
    ((UltraDropDownBase) this.cboIssuingOffice).DisplayMember = "Location";
    ((UltraCombo) this.cboIssuingOffice).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboIssuingOffice).DropDownWidth = 300;
    ((Control) this.cboIssuingOffice).Location = new Point(88, 436);
    this.cboIssuingOffice.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboIssuingOffice).Name = "cboIssuingOffice";
    ((Control) this.cboIssuingOffice).Size = new Size(128 /*0x80*/, 21);
    ((Control) this.cboIssuingOffice).TabIndex = 13;
    ((UltraControlBase) this.cboIssuingOffice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboIssuingOffice).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboIssuingOffice).ValueMember = "OfficeGUID";
    this.dvIssuingOffice.Table = (DataTable) this.ds.dtIssuingOffice;
    this.ds.DataSetName = "dsTabClearance";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraCombo) this.cboQuotingOffice).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboQuotingOffice).DataSource = (object) this.dvQuotingOffice;
    ((UltraDropDownBase) this.cboQuotingOffice).DisplayMember = "Location";
    ((UltraCombo) this.cboQuotingOffice).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboQuotingOffice).DropDownWidth = 300;
    ((Control) this.cboQuotingOffice).Location = new Point(88, 408);
    this.cboQuotingOffice.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboQuotingOffice).Name = "cboQuotingOffice";
    ((Control) this.cboQuotingOffice).Size = new Size(128 /*0x80*/, 21);
    ((Control) this.cboQuotingOffice).TabIndex = 12;
    ((UltraControlBase) this.cboQuotingOffice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboQuotingOffice).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboQuotingOffice).ValueMember = "OfficeGUID";
    this.dvQuotingOffice.Table = (DataTable) this.ds.tblClientOffices;
    this.Label22.AutoSize = true;
    this.Label22.BackColor = Color.Transparent;
    this.Label22.Location = new Point(9, 440);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(77, 13);
    this.Label22.TabIndex = 33;
    this.Label22.Text = "Issuing Office:";
    this.Label22.TextAlign = ContentAlignment.MiddleRight;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(3, 412);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(81, 13);
    this.Label12.TabIndex = 32 /*0x20*/;
    this.Label12.Text = "Quoting Office:";
    this.Label12.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboUnderwriters).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboUnderwriters).DataSource = (object) this.ds.Underwriters;
    ((UltraDropDownBase) this.cboUnderwriters).DisplayMember = "Underwriter";
    ((UltraCombo) this.cboUnderwriters).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboUnderwriters).DropDownWidth = 200;
    ((Control) this.cboUnderwriters).Location = new Point(88, 380);
    this.cboUnderwriters.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboUnderwriters).Name = "cboUnderwriters";
    ((Control) this.cboUnderwriters).Size = new Size(128 /*0x80*/, 21);
    ((Control) this.cboUnderwriters).TabIndex = 11;
    ((UltraControlBase) this.cboUnderwriters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUnderwriters).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUnderwriters).ValueMember = "UserGUID";
    this.Label21.AutoSize = true;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Location = new Point(16 /*0x10*/, 384);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(68, 13);
    this.Label21.TabIndex = 22;
    this.Label21.Text = "Underwriter:";
    this.Label21.TextAlign = ContentAlignment.MiddleRight;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHideVoid).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.chkHideVoid).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideVoid).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideVoid).Checked = true;
    ((UltraToggleEditorBase) this.chkHideVoid).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkHideVoid).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHideVoid).Location = new Point(88, 538);
    this.chkHideVoid.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkHideVoid).Name = "chkHideVoid";
    ((Control) this.chkHideVoid).Size = new Size(136, 24);
    ((Control) this.chkHideVoid).TabIndex = 15;
    ((UltraToggleEditorBase) this.chkHideVoid).Text = "Hide Voided Policies";
    ((UltraControlBase) this.chkHideVoid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHideVoid).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboPolicyType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboPolicyType).DataSource = (object) this.ds.lstPolicyTypes;
    ((UltraDropDownBase) this.cboPolicyType).DisplayMember = "Description";
    ((UltraCombo) this.cboPolicyType).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboPolicyType).DropDownWidth = 200;
    ((Control) this.cboPolicyType).Location = new Point(88, 352);
    this.cboPolicyType.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboPolicyType).Name = "cboPolicyType";
    ((Control) this.cboPolicyType).Size = new Size(128 /*0x80*/, 21);
    ((Control) this.cboPolicyType).TabIndex = 10;
    ((UltraControlBase) this.cboPolicyType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPolicyType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboPolicyType).ValueMember = "PolicyTypeID";
    this.Label20.AutoSize = true;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Location = new Point(18, 356);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(65, 13);
    this.Label20.TabIndex = 20;
    this.Label20.Text = "Policy Type:";
    this.Label20.TextAlign = ContentAlignment.MiddleRight;
    this.Label19.AutoSize = true;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Location = new Point(62, 273);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(23, 13);
    this.Label19.TabIndex = 14;
    this.Label19.Text = "<=";
    this.Label19.TextAlign = ContentAlignment.MiddleRight;
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(62, 219);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(23, 13);
    this.Label18.TabIndex = 10;
    this.Label18.Text = "<=";
    this.Label18.TextAlign = ContentAlignment.MiddleRight;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtExpirationEnd).Appearance = (AppearanceBase) appearance8;
    appearance9.AlphaLevel = (short) 14;
    appearance9.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance9.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance9.BackColorAlpha = (Alpha) 2;
    appearance9.BackGradientAlignment = (GradientAlignment) 4;
    appearance9.BackGradientStyle = (GradientStyle) 5;
    appearance9.BorderAlpha = (Alpha) 1;
    appearance9.BorderColor = Color.FromArgb(78, 122, 171);
    appearance9.ForeColor = Color.FromArgb(49, 85, 153);
    appearance9.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtExpirationEnd).ButtonAppearance = (AppearanceBase) appearance9;
    ((Control) this.dtExpirationEnd).Location = new Point(88, 269);
    this.dtExpirationEnd.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtExpirationEnd).Name = "dtExpirationEnd";
    ((Control) this.dtExpirationEnd).Size = new Size(104, 20);
    ((Control) this.dtExpirationEnd).TabIndex = 7;
    ((UltraControlBase) this.dtExpirationEnd).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtExpirationEnd).UseOsThemes = (DefaultableBoolean) 2;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtEffectiveEnd).Appearance = (AppearanceBase) appearance10;
    appearance11.AlphaLevel = (short) 14;
    appearance11.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance11.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance11.BackColorAlpha = (Alpha) 2;
    appearance11.BackGradientAlignment = (GradientAlignment) 4;
    appearance11.BackGradientStyle = (GradientStyle) 5;
    appearance11.BorderAlpha = (Alpha) 1;
    appearance11.BorderColor = Color.FromArgb(78, 122, 171);
    appearance11.ForeColor = Color.FromArgb(49, 85, 153);
    appearance11.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtEffectiveEnd).ButtonAppearance = (AppearanceBase) appearance11;
    ((Control) this.dtEffectiveEnd).Location = new Point(88, 215);
    this.dtEffectiveEnd.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtEffectiveEnd).Name = "dtEffectiveEnd";
    ((Control) this.dtEffectiveEnd).Size = new Size(104, 20);
    ((Control) this.dtEffectiveEnd).TabIndex = 5;
    ((UltraControlBase) this.dtEffectiveEnd).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEffectiveEnd).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboPolicyState).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboPolicyState).DataSource = (object) this.dvPolicyState;
    ((UltraDropDownBase) this.cboPolicyState).DisplayMember = "State";
    ((UltraCombo) this.cboPolicyState).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboPolicyState).Location = new Point(88, 324);
    this.cboPolicyState.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboPolicyState).Name = "cboPolicyState";
    ((Control) this.cboPolicyState).Size = new Size(128 /*0x80*/, 21);
    ((Control) this.cboPolicyState).TabIndex = 9;
    ((UltraControlBase) this.cboPolicyState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPolicyState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboPolicyState).ValueMember = "StateID";
    this.dvPolicyState.Table = (DataTable) this.ds.lstStates;
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(17, 328);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(67, 13);
    this.Label16.TabIndex = 18;
    this.Label16.Text = "Policy State:";
    this.Label16.TextAlign = ContentAlignment.MiddleRight;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(27, 111);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(57, 13);
    this.Label8.TabIndex = 6;
    this.Label8.Text = "Control #:";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtControlNo).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtControlNo).Appearance = (AppearanceBase) appearance12;
    ((TextEditorControlBase) this.txtControlNo).BackColor = Color.White;
    ((Control) this.txtControlNo).Location = new Point(88, 107);
    this.txtControlNo.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtControlNo).Name = "txtControlNo";
    ((Control) this.txtControlNo).Size = new Size(67, 20);
    ((Control) this.txtControlNo).TabIndex = 3;
    ((UltraControlBase) this.txtControlNo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtControlNo).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboPolicyStatus).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboPolicyStatus).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboPolicyStatus).DropDownWidth = 200;
    ((Control) this.cboPolicyStatus).Location = new Point(88, 296);
    this.cboPolicyStatus.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboPolicyStatus).Name = "cboPolicyStatus";
    ((Control) this.cboPolicyStatus).Size = new Size(128 /*0x80*/, 21);
    ((Control) this.cboPolicyStatus).TabIndex = 8;
    ((UltraControlBase) this.cboPolicyStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPolicyStatus).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkInForce).Appearance = (AppearanceBase) appearance13;
    ((UltraToggleEditorBase) this.chkInForce).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInForce).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInForce).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkInForce).Location = new Point(88, 507);
    this.chkInForce.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkInForce).Name = "chkInForce";
    ((Control) this.chkInForce).Size = new Size(140, 24);
    ((Control) this.chkInForce).TabIndex = 14;
    ((UltraToggleEditorBase) this.chkInForce).Text = "In-Force Policies Only";
    ((UltraControlBase) this.chkInForce).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkInForce).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(34, 84);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(49, 13);
    this.Label3.TabIndex = 4;
    this.Label3.Text = "Policy #:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtPolicyNum).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPolicyNum).Appearance = (AppearanceBase) appearance14;
    ((TextEditorControlBase) this.txtPolicyNum).BackColor = Color.White;
    ((Control) this.txtPolicyNum).Location = new Point(88, 80 /*0x50*/);
    this.txtPolicyNum.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtPolicyNum).Name = "txtPolicyNum";
    ((Control) this.txtPolicyNum).Size = new Size(67, 20);
    ((Control) this.txtPolicyNum).TabIndex = 2;
    ((UltraControlBase) this.txtPolicyNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPolicyNum).UseOsThemes = (DefaultableBoolean) 2;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtEffectiveStart).Appearance = (AppearanceBase) appearance15;
    appearance16.AlphaLevel = (short) 14;
    appearance16.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance16.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance16.BackColorAlpha = (Alpha) 2;
    appearance16.BackGradientAlignment = (GradientAlignment) 4;
    appearance16.BackGradientStyle = (GradientStyle) 5;
    appearance16.BorderAlpha = (Alpha) 1;
    appearance16.BorderColor = Color.FromArgb(78, 122, 171);
    appearance16.ForeColor = Color.FromArgb(49, 85, 153);
    appearance16.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtEffectiveStart).ButtonAppearance = (AppearanceBase) appearance16;
    ((Control) this.dtEffectiveStart).Location = new Point(88, 188);
    this.dtEffectiveStart.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtEffectiveStart).Name = "dtEffectiveStart";
    ((Control) this.dtEffectiveStart).Size = new Size(104, 20);
    ((Control) this.dtEffectiveStart).TabIndex = 4;
    ((UltraControlBase) this.dtEffectiveStart).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEffectiveStart).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(9, 246);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(74, 13);
    this.Label5.TabIndex = 12;
    this.Label5.Text = "Expiration >=";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(16 /*0x10*/, 192 /*0xC0*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(69, 13);
    this.Label4.TabIndex = 8;
    this.Label4.Text = "Effective >=";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtExpirationStart).Appearance = (AppearanceBase) appearance17;
    appearance18.AlphaLevel = (short) 14;
    appearance18.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance18.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance18.BackColorAlpha = (Alpha) 2;
    appearance18.BackGradientAlignment = (GradientAlignment) 4;
    appearance18.BackGradientStyle = (GradientStyle) 5;
    appearance18.BorderAlpha = (Alpha) 1;
    appearance18.BorderColor = Color.FromArgb(78, 122, 171);
    appearance18.ForeColor = Color.FromArgb(49, 85, 153);
    appearance18.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtExpirationStart).ButtonAppearance = (AppearanceBase) appearance18;
    ((Control) this.dtExpirationStart).Location = new Point(88, 242);
    this.dtExpirationStart.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtExpirationStart).Name = "dtExpirationStart";
    ((Control) this.dtExpirationStart).Size = new Size(104, 20);
    ((Control) this.dtExpirationStart).TabIndex = 6;
    ((UltraControlBase) this.dtExpirationStart).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtExpirationStart).UseOsThemes = (DefaultableBoolean) 2;
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(44, 300);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(42, 13);
    this.Label14.TabIndex = 16 /*0x10*/;
    this.Label14.Text = "Status:";
    this.Label14.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.tab_Insured).Controls.Add((Control) this.txtRiskID);
    ((Control) this.tab_Insured).Controls.Add((Control) this.lblRiskID);
    ((Control) this.tab_Insured).Controls.Add((Control) this.lblInsuredCity);
    ((Control) this.tab_Insured).Controls.Add((Control) this.cboInsuredCity);
    ((Control) this.tab_Insured).Controls.Add((Control) this.txtInsuredPhone);
    ((Control) this.tab_Insured).Controls.Add((Control) this.lblPhone);
    ((Control) this.tab_Insured).Controls.Add((Control) this.cboInsuredState);
    ((Control) this.tab_Insured).Controls.Add((Control) this.Label17);
    ((Control) this.tab_Insured).Controls.Add((Control) this.txtInsuredCode);
    ((Control) this.tab_Insured).Controls.Add((Control) this.Label15);
    ((Control) this.tab_Insured).Controls.Add((Control) this.txtFEIN);
    ((Control) this.tab_Insured).Controls.Add((Control) this.Label7);
    ((Control) this.tab_Insured).Controls.Add((Control) this.txtAddress);
    ((Control) this.tab_Insured).Controls.Add((Control) this.Label2);
    ((Control) this.tab_Insured).Controls.Add((Control) this.cboInsuredType);
    ((Control) this.tab_Insured).Controls.Add((Control) this.Label9);
    ((Control) this.tab_Insured).Location = new Point(-10000, -10000);
    ((Control) this.tab_Insured).Name = "tab_Insured";
    ((Control) this.tab_Insured).Size = new Size(286, 622);
    appearance19.BackColor = Color.White;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance19.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtRiskID).Appearance = (AppearanceBase) appearance19;
    ((TextEditorControlBase) this.txtRiskID).BackColor = Color.White;
    ((Control) this.txtRiskID).Location = new Point(94, 267);
    this.txtRiskID.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtRiskID).Name = "txtRiskID";
    ((Control) this.txtRiskID).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.txtRiskID).TabIndex = 98;
    ((UltraControlBase) this.txtRiskID).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRiskID).UseOsThemes = (DefaultableBoolean) 2;
    this.lblRiskID.AutoSize = true;
    this.lblRiskID.BackColor = Color.Transparent;
    this.lblRiskID.Location = new Point(2, 271);
    this.lblRiskID.Name = "lblRiskID";
    this.lblRiskID.Size = new Size(84, 13);
    this.lblRiskID.TabIndex = 97;
    this.lblRiskID.Text = "Insured Risk ID:";
    this.lblRiskID.TextAlign = ContentAlignment.MiddleRight;
    this.lblInsuredCity.AutoSize = true;
    this.lblInsuredCity.BackColor = Color.Transparent;
    this.lblInsuredCity.Location = new Point(16 /*0x10*/, 217);
    this.lblInsuredCity.Name = "lblInsuredCity";
    this.lblInsuredCity.Size = new Size(70, 13);
    this.lblInsuredCity.TabIndex = 96 /*0x60*/;
    this.lblInsuredCity.Text = "Insured City:";
    this.lblInsuredCity.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboInsuredCity).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboInsuredCity).DataSource = (object) this.dvInsuredCity;
    ((UltraDropDownBase) this.cboInsuredCity).DisplayMember = "CityAndState";
    ((UltraCombo) this.cboInsuredCity).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboInsuredCity).DropDownWidth = 500;
    ((Control) this.cboInsuredCity).Location = new Point(96 /*0x60*/, 213);
    this.cboInsuredCity.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboInsuredCity).Name = "cboInsuredCity";
    ((Control) this.cboInsuredCity).Size = new Size(130, 21);
    ((Control) this.cboInsuredCity).TabIndex = 7;
    ((UltraControlBase) this.cboInsuredCity).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInsuredCity).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInsuredCity).ValueMember = "City";
    this.dvInsuredCity.Table = (DataTable) this.ds.InsuredsCityStates;
    appearance20.BackColorDisabled = Color.Gainsboro;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.txtInsuredPhone).Appearance = (AppearanceBase) appearance20;
    ((UltraMaskedEdit) this.txtInsuredPhone).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.txtInsuredPhone).InputMask = "###-###-####";
    ((Control) this.txtInsuredPhone).Location = new Point(96 /*0x60*/, 240 /*0xF0*/);
    this.txtInsuredPhone.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtInsuredPhone).Name = "txtInsuredPhone";
    ((UltraMaskedEdit) this.txtInsuredPhone).NonAutoSizeHeight = 20;
    ((Control) this.txtInsuredPhone).Size = new Size(126, 21);
    ((Control) this.txtInsuredPhone).TabIndex = 8;
    ((UltraMaskedEdit) this.txtInsuredPhone).Text = "--";
    ((UltraControlBase) this.txtInsuredPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInsuredPhone).UseOsThemes = (DefaultableBoolean) 2;
    this.lblPhone.AutoSize = true;
    this.lblPhone.BackColor = Color.Transparent;
    this.lblPhone.Location = new Point(9, 244);
    this.lblPhone.Name = "lblPhone";
    this.lblPhone.Size = new Size(81, 13);
    this.lblPhone.TabIndex = 94;
    this.lblPhone.Text = "Insured Phone:";
    this.lblPhone.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboInsuredState).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboInsuredState).DataSource = (object) this.dvInsuredState;
    ((UltraDropDownBase) this.cboInsuredState).DisplayMember = "State";
    ((UltraCombo) this.cboInsuredState).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboInsuredState).Location = new Point(96 /*0x60*/, 186);
    this.cboInsuredState.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboInsuredState).Name = "cboInsuredState";
    ((Control) this.cboInsuredState).Size = new Size(128 /*0x80*/, 21);
    ((Control) this.cboInsuredState).TabIndex = 6;
    ((UltraControlBase) this.cboInsuredState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInsuredState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInsuredState).ValueMember = "StateID";
    this.dvInsuredState.Table = (DataTable) this.ds.lstStates;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(2, 189);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(88, 14);
    this.Label17.TabIndex = 8;
    this.Label17.Text = "Insured State:";
    this.Label17.TextAlign = ContentAlignment.MiddleRight;
    appearance21.BackColor = Color.White;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance21.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInsuredCode).Appearance = (AppearanceBase) appearance21;
    ((TextEditorControlBase) this.txtInsuredCode).BackColor = Color.White;
    ((Control) this.txtInsuredCode).Location = new Point(96 /*0x60*/, 158);
    this.txtInsuredCode.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtInsuredCode).Name = "txtInsuredCode";
    ((Control) this.txtInsuredCode).Size = new Size(40, 20);
    ((Control) this.txtInsuredCode).TabIndex = 5;
    ((UltraControlBase) this.txtInsuredCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInsuredCode).UseOsThemes = (DefaultableBoolean) 2;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(18, 161);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(72, 14);
    this.Label15.TabIndex = 6;
    this.Label15.Text = "Ins. Number:";
    this.Label15.TextAlign = ContentAlignment.MiddleRight;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.txtFEIN).Appearance = (AppearanceBase) appearance22;
    ((UltraMaskedEdit) this.txtFEIN).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.txtFEIN).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.txtFEIN).InputMask = "999999999";
    ((Control) this.txtFEIN).Location = new Point(96 /*0x60*/, 129);
    this.txtFEIN.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtFEIN).Name = "txtFEIN";
    ((UltraMaskedEdit) this.txtFEIN).NonAutoSizeHeight = 20;
    ((UltraMaskedEdit) this.txtFEIN).PromptChar = ' ';
    ((Control) this.txtFEIN).Size = new Size(77, 21);
    ((Control) this.txtFEIN).TabIndex = 4;
    ((UltraControlBase) this.txtFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFEIN).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(25, 132);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(65, 14);
    this.Label7.TabIndex = 4;
    this.Label7.Text = "FEIN/SSN:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    appearance23.BackColor = Color.White;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance23.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAddress).Appearance = (AppearanceBase) appearance23;
    ((TextEditorControlBase) this.txtAddress).BackColor = Color.White;
    ((Control) this.txtAddress).Location = new Point(96 /*0x60*/, 72);
    this.txtAddress.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtAddress).Name = "txtAddress";
    ((Control) this.txtAddress).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.txtAddress).TabIndex = 2;
    ((UltraControlBase) this.txtAddress).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAddress).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(18, 75);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(72, 13);
    this.Label2.TabIndex = 0;
    this.Label2.Text = "Ins. Address:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboInsuredType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboInsuredType).DataSource = (object) this.ds.lstBusinessTypes;
    ((UltraDropDownBase) this.cboInsuredType).DisplayMember = "BusinessType";
    ((UltraCombo) this.cboInsuredType).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboInsuredType).DropDownWidth = 250;
    ((Control) this.cboInsuredType).Location = new Point(96 /*0x60*/, 100);
    this.cboInsuredType.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboInsuredType).Name = "cboInsuredType";
    ((Control) this.cboInsuredType).Size = new Size(128 /*0x80*/, 21);
    ((Control) this.cboInsuredType).TabIndex = 3;
    ((UltraControlBase) this.cboInsuredType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInsuredType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInsuredType).ValueMember = "BusinessTypeID";
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(11, 104);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(79, 13);
    this.Label9.TabIndex = 2;
    this.Label9.Text = "Business Type:";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    this.optionSearch.BorderStyle = (UIElementBorderStyle) 1;
    this.optionSearch.CheckedIndex = 1;
    valueListItem1.DataValue = (object) "ValueListItem0";
    valueListItem1.DisplayText = "Starts With";
    valueListItem2.DataValue = (object) "ValueListItem1";
    valueListItem2.DisplayText = "Contains";
    this.optionSearch.Items.AddRange(new ValueListItem[2]
    {
      valueListItem1,
      valueListItem2
    });
    ((Control) this.optionSearch).Location = new Point(5, 13);
    ((Control) this.optionSearch).Name = "optionSearch";
    ((Control) this.optionSearch).Size = new Size(150, 26);
    ((Control) this.optionSearch).TabIndex = 0;
    this.optionSearch.Text = "Contains";
    this.optionSearch.TextIndentation = 3;
    ((Control) this.btnReset).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance24.BackColor = Color.Gainsboro;
    appearance24.BackColor2 = Color.White;
    appearance24.BackGradientStyle = (GradientStyle) 2;
    appearance24.BorderColor = Color.Gray;
    appearance24.ImageHAlign = (HAlign) 2;
    appearance24.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnReset).Appearance = (AppearanceBase) appearance24;
    ((ControlBase) this.btnReset).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnReset).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnReset).Location = new Point(186, 8);
    ((Control) this.btnReset).Name = "btnReset";
    ((Control) this.btnReset).Size = new Size(40, 40);
    ((Control) this.btnReset).TabIndex = 9;
    this.ToolTip1.SetToolTip((Control) this.btnReset, "Reset Search");
    this.btnReset.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSearch).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance25.BackColor = Color.Gainsboro;
    appearance25.BackColor2 = Color.White;
    appearance25.BackGradientStyle = (GradientStyle) 2;
    appearance25.BorderColor = Color.Gray;
    appearance25.ImageHAlign = (HAlign) 2;
    appearance25.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance25;
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSearch).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSearch).Location = new Point(234, 8);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 40);
    ((Control) this.btnSearch).TabIndex = 10;
    this.ToolTip1.SetToolTip((Control) this.btnSearch, "Search");
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numResults).Appearance = (AppearanceBase) appearance26;
    appearance27.BackColor = Color.WhiteSmoke;
    appearance27.BorderColor = Color.Gray;
    ((UltraNumericEditorBase) this.numResults).ButtonAppearance = (AppearanceBase) appearance27;
    ((Control) this.numResults).Location = new Point(72, 40);
    ((UltraNumericEditor) this.numResults).MaxValue = (object) 100;
    this.numResults.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.numResults).MinValue = (object) 1;
    ((Control) this.numResults).Name = "numResults";
    ((UltraNumericEditorBase) this.numResults).PromptChar = ' ';
    ((Control) this.numResults).Size = new Size(72, 20);
    ((UltraNumericEditorBase) this.numResults).SpinButtonDisplayStyle = (ButtonDisplayStyle) 1;
    ((Control) this.numResults).TabIndex = 1;
    ((UltraControlBase) this.numResults).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numResults).UseOsThemes = (DefaultableBoolean) 2;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(16 /*0x10*/, 42);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(48 /*0x30*/, 16 /*0x10*/);
    this.Label10.TabIndex = 2;
    this.Label10.Text = "Results:";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.tabCompany).Controls.Add((Control) this.cboCompanyLocations);
    ((Control) this.tabCompany).Controls.Add((Control) this.Label11);
    ((Control) this.tabCompany).Controls.Add((Control) this.cboLine);
    ((Control) this.tabCompany).Controls.Add((Control) this.Label13);
    ((Control) this.tabCompany).Location = new Point(-10000, -10000);
    ((Control) this.tabCompany).Name = "tabCompany";
    ((Control) this.tabCompany).Size = new Size(286, 622);
    ((UltraCombo) this.cboCompanyLocations).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboCompanyLocations).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCompanyLocations).DropDownWidth = 450;
    ((Control) this.cboCompanyLocations).Location = new Point(72, 72);
    this.cboCompanyLocations.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboCompanyLocations).Name = "cboCompanyLocations";
    ((Control) this.cboCompanyLocations).Size = new Size(168, 21);
    ((Control) this.cboCompanyLocations).TabIndex = 1;
    ((UltraControlBase) this.cboCompanyLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanyLocations).UseOsThemes = (DefaultableBoolean) 2;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(16 /*0x10*/, 74);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(51, 13);
    this.Label11.TabIndex = 0;
    this.Label11.Text = "Location:";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboLine).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboLine).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLine).DropDownWidth = 300;
    ((Control) this.cboLine).Location = new Point(72, 104);
    this.cboLine.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboLine).Name = "cboLine";
    ((Control) this.cboLine).Size = new Size(168, 21);
    ((Control) this.cboLine).TabIndex = 3;
    ((UltraControlBase) this.cboLine).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLine).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(37, 106);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(30, 13);
    this.Label13.TabIndex = 2;
    this.Label13.Text = "Line:";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.tabProducer).Controls.Add((Control) this.lstSuggestEmail);
    ((Control) this.tabProducer).Controls.Add((Control) this.Label44);
    ((Control) this.tabProducer).Controls.Add((Control) this.txtProducerEmail);
    ((Control) this.tabProducer).Controls.Add((Control) this.Label6);
    ((Control) this.tabProducer).Controls.Add((Control) this.cboProducer);
    ((Control) this.tabProducer).Location = new Point(-10000, -10000);
    ((Control) this.tabProducer).Name = "tabProducer";
    ((Control) this.tabProducer).Size = new Size(286, 622);
    this.lstSuggestEmail.ItemSettings.AllowEdit = (DefaultableBoolean) 2;
    appearance28.Cursor = Cursors.Hand;
    this.lstSuggestEmail.ItemSettings.Appearance = (AppearanceBase) appearance28;
    appearance29.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance29.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.lstSuggestEmail.ItemSettings.HotTrackingAppearance = (AppearanceBase) appearance29;
    this.lstSuggestEmail.ItemSettings.SelectionType = (SelectionType) 2;
    ((Control) this.lstSuggestEmail).Location = new Point(70, 126);
    ((Control) this.lstSuggestEmail).Name = "LstSuggestEmail";
    ((Control) this.lstSuggestEmail).Size = new Size(154, 68);
    ((Control) this.lstSuggestEmail).TabIndex = 35;
    this.lstSuggestEmail.View = (UltraListViewStyle) 2;
    this.lstSuggestEmail.ViewSettingsList.MultiColumn = false;
    ((Control) this.lstSuggestEmail).Visible = false;
    this.Label44.AutoSize = true;
    this.Label44.FlatStyle = FlatStyle.System;
    this.Label44.Location = new Point(20, 109);
    this.Label44.Name = "Label44";
    this.Label44.Size = new Size(35, 13);
    this.Label44.TabIndex = 19;
    this.Label44.Text = "Email:";
    this.Label44.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtProducerEmail).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance30.BackColor = Color.White;
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance30.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtProducerEmail).Appearance = (AppearanceBase) appearance30;
    ((TextEditorControlBase) this.txtProducerEmail).BackColor = Color.White;
    ((Control) this.txtProducerEmail).Location = new Point(70, 106);
    this.txtProducerEmail.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtProducerEmail).Name = "txtProducerEmail";
    ((Control) this.txtProducerEmail).Size = new Size(154, 20);
    ((Control) this.txtProducerEmail).TabIndex = 20;
    ((Control) this.txtProducerEmail).Tag = (object) "Producer Email";
    ((UltraControlBase) this.txtProducerEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducerEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(16 /*0x10*/, 74);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(50, 13);
    this.Label6.TabIndex = 0;
    this.Label6.Text = "Producer";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboProducer).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboProducer).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProducer).DropDownWidth = 500;
    ((Control) this.cboProducer).Enabled = false;
    ((Control) this.cboProducer).Location = new Point(72, 72);
    this.cboProducer.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboProducer).Name = "cboProducer";
    ((Control) this.cboProducer).Size = new Size(152, 21);
    ((Control) this.cboProducer).TabIndex = 1;
    ((UltraControlBase) this.cboProducer).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducer).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tabUndLocations).Controls.Add((Control) this.chkLocInForce);
    ((Control) this.tabUndLocations).Controls.Add((Control) this.txtLocZip);
    ((Control) this.tabUndLocations).Controls.Add((Control) this.Label27);
    ((Control) this.tabUndLocations).Controls.Add((Control) this.Label26);
    ((Control) this.tabUndLocations).Controls.Add((Control) this.Label25);
    ((Control) this.tabUndLocations).Controls.Add((Control) this.cboLocCity);
    ((Control) this.tabUndLocations).Controls.Add((Control) this.txtLocAddress);
    ((Control) this.tabUndLocations).Controls.Add((Control) this.Label24);
    ((Control) this.tabUndLocations).Controls.Add((Control) this.cboLocState);
    ((Control) this.tabUndLocations).Location = new Point(-10000, -10000);
    ((Control) this.tabUndLocations).Name = "tabUndLocations";
    ((Control) this.tabUndLocations).Size = new Size(286, 622);
    appearance31.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance31.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkLocInForce).Appearance = (AppearanceBase) appearance31;
    ((UltraToggleEditorBase) this.chkLocInForce).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkLocInForce).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkLocInForce).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkLocInForce).Location = new Point(72, 175);
    this.chkLocInForce.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkLocInForce).Name = "chkLocInForce";
    ((Control) this.chkLocInForce).Size = new Size(140, 24);
    ((Control) this.chkLocInForce).TabIndex = 50;
    ((UltraToggleEditorBase) this.chkLocInForce).Text = "In-Force Policies Only";
    ((UltraControlBase) this.chkLocInForce).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkLocInForce).UseOsThemes = (DefaultableBoolean) 2;
    appearance32.BackColor = Color.White;
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance32.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLocZip).Appearance = (AppearanceBase) appearance32;
    ((TextEditorControlBase) this.txtLocZip).BackColor = Color.White;
    ((Control) this.txtLocZip).Location = new Point(71, 146);
    ((TextEditorControlBase) this.txtLocZip).MaxLength = 5;
    this.txtLocZip.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtLocZip).Name = "txtLocZip";
    ((Control) this.txtLocZip).Size = new Size(73, 20);
    ((Control) this.txtLocZip).TabIndex = 49;
    ((UltraControlBase) this.txtLocZip).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLocZip).UseOsThemes = (DefaultableBoolean) 2;
    this.Label27.AutoSize = true;
    this.Label27.BackColor = Color.Transparent;
    this.Label27.Location = new Point(39, 149);
    this.Label27.Name = "Label27";
    this.Label27.Size = new Size(25, 13);
    this.Label27.TabIndex = 48 /*0x30*/;
    this.Label27.Text = "Zip:";
    this.Label27.TextAlign = ContentAlignment.MiddleRight;
    this.Label26.AutoSize = true;
    this.Label26.BackColor = Color.Transparent;
    this.Label26.Location = new Point(29, 96 /*0x60*/);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(37, 13);
    this.Label26.TabIndex = 47;
    this.Label26.Text = "State:";
    this.Label26.TextAlign = ContentAlignment.MiddleRight;
    this.Label25.AutoSize = true;
    this.Label25.BackColor = Color.Transparent;
    this.Label25.Location = new Point(36, 123);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(30, 13);
    this.Label25.TabIndex = 46;
    this.Label25.Text = "City:";
    this.Label25.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboLocCity).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboLocCity).DataSource = (object) this.dvLocCity;
    ((UltraDropDownBase) this.cboLocCity).DisplayMember = "CityAndState";
    ((UltraCombo) this.cboLocCity).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLocCity).DropDownWidth = 500;
    ((Control) this.cboLocCity).Location = new Point(72, 119);
    this.cboLocCity.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboLocCity).Name = "cboLocCity";
    ((Control) this.cboLocCity).Size = new Size(166, 21);
    ((Control) this.cboLocCity).TabIndex = 45;
    ((UltraControlBase) this.cboLocCity).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLocCity).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLocCity).ValueMember = "City";
    this.dvLocCity.Table = (DataTable) this.ds.UnderwritingLocations;
    appearance33.BackColor = Color.White;
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance33.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLocAddress).Appearance = (AppearanceBase) appearance33;
    ((TextEditorControlBase) this.txtLocAddress).BackColor = Color.White;
    ((Control) this.txtLocAddress).Location = new Point(72, 66);
    ((TextEditorControlBase) this.txtLocAddress).MaxLength = 20;
    this.txtLocAddress.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtLocAddress).Name = "txtLocAddress";
    ((Control) this.txtLocAddress).Size = new Size(167, 20);
    ((Control) this.txtLocAddress).TabIndex = 44;
    ((UltraControlBase) this.txtLocAddress).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLocAddress).UseOsThemes = (DefaultableBoolean) 2;
    this.Label24.AutoSize = true;
    this.Label24.BackColor = Color.Transparent;
    this.Label24.Location = new Point(16 /*0x10*/, 70);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(50, 13);
    this.Label24.TabIndex = 43;
    this.Label24.Text = "Address:";
    this.Label24.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboLocState).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboLocState).DataSource = (object) this.ds.lstStates;
    ((UltraDropDownBase) this.cboLocState).DisplayMember = "State";
    ((UltraCombo) this.cboLocState).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLocState).DropDownWidth = 500;
    ((Control) this.cboLocState).Location = new Point(72, 92);
    this.cboLocState.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboLocState).Name = "cboLocState";
    ((Control) this.cboLocState).Size = new Size(166, 21);
    ((Control) this.cboLocState).TabIndex = 42;
    ((UltraControlBase) this.cboLocState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLocState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLocState).ValueMember = "StateID";
    ((Control) this.tabDrivers).Controls.Add((Control) this.Label37);
    ((Control) this.tabDrivers).Controls.Add((Control) this.txtDriverLast);
    ((Control) this.tabDrivers).Controls.Add((Control) this.Label36);
    ((Control) this.tabDrivers).Controls.Add((Control) this.txtDriverFirst);
    ((Control) this.tabDrivers).Controls.Add((Control) this.Label35);
    ((Control) this.tabDrivers).Controls.Add((Control) this.txtDriverAddress);
    ((Control) this.tabDrivers).Controls.Add((Control) this.Label34);
    ((Control) this.tabDrivers).Controls.Add((Control) this.txtDriverControlNo);
    ((Control) this.tabDrivers).Controls.Add((Control) this.chkDriverInforce);
    ((Control) this.tabDrivers).Controls.Add((Control) this.txtDriverZip);
    ((Control) this.tabDrivers).Controls.Add((Control) this.Label30);
    ((Control) this.tabDrivers).Controls.Add((Control) this.Label31);
    ((Control) this.tabDrivers).Controls.Add((Control) this.txtDriverLicenseNumber);
    ((Control) this.tabDrivers).Controls.Add((Control) this.Label33);
    ((Control) this.tabDrivers).Controls.Add((Control) this.cboDriverState);
    ((Control) this.tabDrivers).Location = new Point(-10000, -10000);
    ((Control) this.tabDrivers).Name = "tabDrivers";
    ((Control) this.tabDrivers).Size = new Size(286, 622);
    this.Label37.AutoSize = true;
    this.Label37.BackColor = Color.Transparent;
    this.Label37.Location = new Point(42, 116);
    this.Label37.Name = "Label37";
    this.Label37.Size = new Size(31 /*0x1F*/, 13);
    this.Label37.TabIndex = 67;
    this.Label37.Text = "Last:";
    this.Label37.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtDriverLast).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance34.BackColor = Color.White;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance34.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDriverLast).Appearance = (AppearanceBase) appearance34;
    ((TextEditorControlBase) this.txtDriverLast).BackColor = Color.White;
    ((Control) this.txtDriverLast).Location = new Point(87, 112 /*0x70*/);
    this.txtDriverLast.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtDriverLast).Name = "txtDriverLast";
    ((Control) this.txtDriverLast).Size = new Size(114, 20);
    ((Control) this.txtDriverLast).TabIndex = 66;
    ((UltraControlBase) this.txtDriverLast).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDriverLast).UseOsThemes = (DefaultableBoolean) 2;
    this.Label36.AutoSize = true;
    this.Label36.BackColor = Color.Transparent;
    this.Label36.Location = new Point(41, 87);
    this.Label36.Name = "Label36";
    this.Label36.Size = new Size(32 /*0x20*/, 13);
    this.Label36.TabIndex = 65;
    this.Label36.Text = "First:";
    this.Label36.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtDriverFirst).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance35.BackColor = Color.White;
    appearance35.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance35.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDriverFirst).Appearance = (AppearanceBase) appearance35;
    ((TextEditorControlBase) this.txtDriverFirst).BackColor = Color.White;
    ((Control) this.txtDriverFirst).Location = new Point(87, 83);
    this.txtDriverFirst.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtDriverFirst).Name = "txtDriverFirst";
    ((Control) this.txtDriverFirst).Size = new Size(114, 20);
    ((Control) this.txtDriverFirst).TabIndex = 64 /*0x40*/;
    ((UltraControlBase) this.txtDriverFirst).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDriverFirst).UseOsThemes = (DefaultableBoolean) 2;
    this.Label35.AutoSize = true;
    this.Label35.BackColor = Color.Transparent;
    this.Label35.Location = new Point(23, 203);
    this.Label35.Name = "Label35";
    this.Label35.Size = new Size(50, 13);
    this.Label35.TabIndex = 63 /*0x3F*/;
    this.Label35.Text = "Address:";
    this.Label35.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtDriverAddress).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance36.BackColor = Color.White;
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance36.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDriverAddress).Appearance = (AppearanceBase) appearance36;
    ((TextEditorControlBase) this.txtDriverAddress).BackColor = Color.White;
    ((Control) this.txtDriverAddress).Location = new Point(87, 199);
    this.txtDriverAddress.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtDriverAddress).Name = "txtDriverAddress";
    ((Control) this.txtDriverAddress).Size = new Size(151, 20);
    ((Control) this.txtDriverAddress).TabIndex = 62;
    ((UltraControlBase) this.txtDriverAddress).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDriverAddress).UseOsThemes = (DefaultableBoolean) 2;
    this.Label34.AutoSize = true;
    this.Label34.BackColor = Color.Transparent;
    this.Label34.Location = new Point(16 /*0x10*/, 174);
    this.Label34.Name = "Label34";
    this.Label34.Size = new Size(57, 13);
    this.Label34.TabIndex = 61;
    this.Label34.Text = "Control #:";
    this.Label34.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtDriverControlNo).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance37.BackColor = Color.White;
    appearance37.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance37.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDriverControlNo).Appearance = (AppearanceBase) appearance37;
    ((TextEditorControlBase) this.txtDriverControlNo).BackColor = Color.White;
    ((Control) this.txtDriverControlNo).Location = new Point(87, 170);
    this.txtDriverControlNo.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtDriverControlNo).Name = "txtDriverControlNo";
    ((Control) this.txtDriverControlNo).Size = new Size(114, 20);
    ((Control) this.txtDriverControlNo).TabIndex = 60;
    ((UltraControlBase) this.txtDriverControlNo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDriverControlNo).UseOsThemes = (DefaultableBoolean) 2;
    appearance38.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance38.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDriverInforce).Appearance = (AppearanceBase) appearance38;
    ((UltraToggleEditorBase) this.chkDriverInforce).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDriverInforce).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDriverInforce).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDriverInforce).Location = new Point(87, 287);
    this.chkDriverInforce.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkDriverInforce).Name = "chkDriverInforce";
    ((Control) this.chkDriverInforce).Size = new Size(140, 24);
    ((Control) this.chkDriverInforce).TabIndex = 59;
    ((UltraToggleEditorBase) this.chkDriverInforce).Text = "In-Force Policies Only";
    ((UltraControlBase) this.chkDriverInforce).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDriverInforce).UseOsThemes = (DefaultableBoolean) 2;
    appearance39.BackColor = Color.White;
    appearance39.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance39.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDriverZip).Appearance = (AppearanceBase) appearance39;
    ((TextEditorControlBase) this.txtDriverZip).BackColor = Color.White;
    ((Control) this.txtDriverZip).Location = new Point(87, 258);
    ((TextEditorControlBase) this.txtDriverZip).MaxLength = 5;
    this.txtDriverZip.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtDriverZip).Name = "txtDriverZip";
    ((Control) this.txtDriverZip).Size = new Size(73, 20);
    ((Control) this.txtDriverZip).TabIndex = 58;
    ((UltraControlBase) this.txtDriverZip).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDriverZip).UseOsThemes = (DefaultableBoolean) 2;
    this.Label30.AutoSize = true;
    this.Label30.BackColor = Color.Transparent;
    this.Label30.Location = new Point(48 /*0x30*/, 262);
    this.Label30.Name = "Label30";
    this.Label30.Size = new Size(25, 13);
    this.Label30.TabIndex = 57;
    this.Label30.Text = "Zip:";
    this.Label30.TextAlign = ContentAlignment.MiddleRight;
    this.Label31.AutoSize = true;
    this.Label31.BackColor = Color.Transparent;
    this.Label31.Location = new Point(36, 232);
    this.Label31.Name = "Label31";
    this.Label31.Size = new Size(37, 13);
    this.Label31.TabIndex = 56;
    this.Label31.Text = "State:";
    this.Label31.TextAlign = ContentAlignment.MiddleRight;
    appearance40.BackColor = Color.White;
    appearance40.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance40.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDriverLicenseNumber).Appearance = (AppearanceBase) appearance40;
    ((TextEditorControlBase) this.txtDriverLicenseNumber).BackColor = Color.White;
    ((Control) this.txtDriverLicenseNumber).Location = new Point(87, 141);
    ((TextEditorControlBase) this.txtDriverLicenseNumber).MaxLength = 20;
    this.txtDriverLicenseNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtDriverLicenseNumber).Name = "txtDriverLicenseNumber";
    ((Control) this.txtDriverLicenseNumber).Size = new Size(114, 20);
    ((Control) this.txtDriverLicenseNumber).TabIndex = 53;
    ((UltraControlBase) this.txtDriverLicenseNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDriverLicenseNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.Label33.AutoSize = true;
    this.Label33.BackColor = Color.Transparent;
    this.Label33.Location = new Point(16 /*0x10*/, 145);
    this.Label33.Name = "Label33";
    this.Label33.Size = new Size(57, 13);
    this.Label33.TabIndex = 52;
    this.Label33.Text = "License #:";
    this.Label33.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboDriverState).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboDriverState).DataSource = (object) this.ds.lstStates;
    ((UltraDropDownBase) this.cboDriverState).DisplayMember = "State";
    ((UltraCombo) this.cboDriverState).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboDriverState).DropDownWidth = 500;
    ((Control) this.cboDriverState).Location = new Point(87, 228);
    this.cboDriverState.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboDriverState).Name = "cboDriverState";
    ((Control) this.cboDriverState).Size = new Size(151, 21);
    ((Control) this.cboDriverState).TabIndex = 51;
    ((UltraControlBase) this.cboDriverState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDriverState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDriverState).ValueMember = "StateID";
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.lblInterestName);
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.txtInterestName);
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.Label32);
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.txtInterestLast);
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.Label38);
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.txtInterestFirst);
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.Label39);
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.txtInterestAddress);
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.Label40);
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.txtInterestControlNo);
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.chkInterestInforce);
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.txtInterestZip);
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.Label41);
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.Label42);
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.txtInterest);
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.Label43);
    ((Control) this.tabAdditionalInterest).Controls.Add((Control) this.cboInterestStateID);
    ((Control) this.tabAdditionalInterest).Location = new Point(-10000, -10000);
    ((Control) this.tabAdditionalInterest).Name = "tabAdditionalInterest";
    ((Control) this.tabAdditionalInterest).Size = new Size(286, 622);
    this.lblInterestName.AutoSize = true;
    this.lblInterestName.BackColor = Color.Transparent;
    this.lblInterestName.Location = new Point(8, 88);
    this.lblInterestName.Name = "lblInterestName";
    this.lblInterestName.Size = new Size(80 /*0x50*/, 13);
    this.lblInterestName.TabIndex = 84;
    this.lblInterestName.Text = "Interest Name:";
    this.lblInterestName.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtInterestName).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance41.BackColor = Color.White;
    appearance41.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance41.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInterestName).Appearance = (AppearanceBase) appearance41;
    ((TextEditorControlBase) this.txtInterestName).BackColor = Color.White;
    ((Control) this.txtInterestName).Location = new Point(94, 84);
    this.txtInterestName.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtInterestName).Name = "txtInterestName";
    ((Control) this.txtInterestName).Size = new Size(114, 20);
    ((Control) this.txtInterestName).TabIndex = 5;
    ((UltraControlBase) this.txtInterestName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInterestName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label32.AutoSize = true;
    this.Label32.BackColor = Color.Transparent;
    this.Label32.Location = new Point(8, 148);
    this.Label32.Name = "Label32";
    this.Label32.Size = new Size(61, 13);
    this.Label32.TabIndex = 82;
    this.Label32.Text = "Last Name:";
    this.Label32.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtInterestLast).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance42.BackColor = Color.White;
    appearance42.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance42.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInterestLast).Appearance = (AppearanceBase) appearance42;
    ((TextEditorControlBase) this.txtInterestLast).BackColor = Color.White;
    ((Control) this.txtInterestLast).Location = new Point(94, 144 /*0x90*/);
    this.txtInterestLast.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtInterestLast).Name = "txtInterestLast";
    ((Control) this.txtInterestLast).Size = new Size(114, 20);
    ((Control) this.txtInterestLast).TabIndex = 7;
    ((UltraControlBase) this.txtInterestLast).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInterestLast).UseOsThemes = (DefaultableBoolean) 2;
    this.Label38.AutoSize = true;
    this.Label38.BackColor = Color.Transparent;
    this.Label38.Location = new Point(8, 118);
    this.Label38.Name = "Label38";
    this.Label38.Size = new Size(62, 13);
    this.Label38.TabIndex = 80 /*0x50*/;
    this.Label38.Text = "First Name:";
    this.Label38.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtInterestFirst).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance43.BackColor = Color.White;
    appearance43.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance43.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInterestFirst).Appearance = (AppearanceBase) appearance43;
    ((TextEditorControlBase) this.txtInterestFirst).BackColor = Color.White;
    ((Control) this.txtInterestFirst).Location = new Point(94, 114);
    this.txtInterestFirst.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtInterestFirst).Name = "txtInterestFirst";
    ((Control) this.txtInterestFirst).Size = new Size(114, 20);
    ((Control) this.txtInterestFirst).TabIndex = 6;
    ((UltraControlBase) this.txtInterestFirst).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInterestFirst).UseOsThemes = (DefaultableBoolean) 2;
    this.Label39.AutoSize = true;
    this.Label39.BackColor = Color.Transparent;
    this.Label39.Location = new Point(27, 238);
    this.Label39.Name = "Label39";
    this.Label39.Size = new Size(50, 13);
    this.Label39.TabIndex = 78;
    this.Label39.Text = "Address:";
    this.Label39.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtInterestAddress).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance44.BackColor = Color.White;
    appearance44.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance44.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInterestAddress).Appearance = (AppearanceBase) appearance44;
    ((TextEditorControlBase) this.txtInterestAddress).BackColor = Color.White;
    ((Control) this.txtInterestAddress).Location = new Point(94, 234);
    this.txtInterestAddress.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtInterestAddress).Name = "txtInterestAddress";
    ((Control) this.txtInterestAddress).Size = new Size(151, 20);
    ((Control) this.txtInterestAddress).TabIndex = 10;
    ((UltraControlBase) this.txtInterestAddress).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInterestAddress).UseOsThemes = (DefaultableBoolean) 2;
    this.Label40.AutoSize = true;
    this.Label40.BackColor = Color.Transparent;
    this.Label40.Location = new Point(8, 208 /*0xD0*/);
    this.Label40.Name = "Label40";
    this.Label40.Size = new Size(57, 13);
    this.Label40.TabIndex = 76;
    this.Label40.Text = "Control #:";
    this.Label40.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtInterestControlNo).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance45.BackColor = Color.White;
    appearance45.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance45.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInterestControlNo).Appearance = (AppearanceBase) appearance45;
    ((TextEditorControlBase) this.txtInterestControlNo).BackColor = Color.White;
    ((Control) this.txtInterestControlNo).Location = new Point(94, 204);
    this.txtInterestControlNo.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtInterestControlNo).Name = "txtInterestControlNo";
    ((Control) this.txtInterestControlNo).Size = new Size(114, 20);
    ((Control) this.txtInterestControlNo).TabIndex = 9;
    ((UltraControlBase) this.txtInterestControlNo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInterestControlNo).UseOsThemes = (DefaultableBoolean) 2;
    appearance46.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance46.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkInterestInforce).Appearance = (AppearanceBase) appearance46;
    ((UltraToggleEditorBase) this.chkInterestInforce).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInterestInforce).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInterestInforce).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkInterestInforce).Location = new Point(94, 325);
    this.chkInterestInforce.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkInterestInforce).Name = "chkInterestInforce";
    ((Control) this.chkInterestInforce).Size = new Size(140, 24);
    ((Control) this.chkInterestInforce).TabIndex = 13;
    ((UltraToggleEditorBase) this.chkInterestInforce).Text = "In-Force Policies Only";
    ((UltraControlBase) this.chkInterestInforce).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkInterestInforce).UseOsThemes = (DefaultableBoolean) 2;
    appearance47.BackColor = Color.White;
    appearance47.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance47.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInterestZip).Appearance = (AppearanceBase) appearance47;
    ((TextEditorControlBase) this.txtInterestZip).BackColor = Color.White;
    ((Control) this.txtInterestZip).Location = new Point(94, 295);
    ((TextEditorControlBase) this.txtInterestZip).MaxLength = 5;
    this.txtInterestZip.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtInterestZip).Name = "txtInterestZip";
    ((Control) this.txtInterestZip).Size = new Size(73, 20);
    ((Control) this.txtInterestZip).TabIndex = 12;
    ((UltraControlBase) this.txtInterestZip).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInterestZip).UseOsThemes = (DefaultableBoolean) 2;
    this.Label41.AutoSize = true;
    this.Label41.BackColor = Color.Transparent;
    this.Label41.Location = new Point(27, 299);
    this.Label41.Name = "Label41";
    this.Label41.Size = new Size(25, 13);
    this.Label41.TabIndex = 72;
    this.Label41.Text = "Zip:";
    this.Label41.TextAlign = ContentAlignment.MiddleRight;
    this.Label42.AutoSize = true;
    this.Label42.BackColor = Color.Transparent;
    this.Label42.Location = new Point(27, 268);
    this.Label42.Name = "Label42";
    this.Label42.Size = new Size(37, 13);
    this.Label42.TabIndex = 71;
    this.Label42.Text = "State:";
    this.Label42.TextAlign = ContentAlignment.MiddleRight;
    appearance48.BackColor = Color.White;
    appearance48.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance48.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInterest).Appearance = (AppearanceBase) appearance48;
    ((TextEditorControlBase) this.txtInterest).BackColor = Color.White;
    ((Control) this.txtInterest).Location = new Point(94, 174);
    ((TextEditorControlBase) this.txtInterest).MaxLength = 20;
    this.txtInterest.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtInterest).Name = "txtInterest";
    ((Control) this.txtInterest).Size = new Size(114, 20);
    ((Control) this.txtInterest).TabIndex = 8;
    ((UltraControlBase) this.txtInterest).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInterest).UseOsThemes = (DefaultableBoolean) 2;
    this.Label43.AutoSize = true;
    this.Label43.BackColor = Color.Transparent;
    this.Label43.Location = new Point(8, 178);
    this.Label43.Name = "Label43";
    this.Label43.Size = new Size(50, 13);
    this.Label43.TabIndex = 69;
    this.Label43.Text = "Interest:";
    this.Label43.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboInterestStateID).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboInterestStateID).DataSource = (object) this.ds.lstStates;
    ((UltraDropDownBase) this.cboInterestStateID).DisplayMember = "State";
    ((UltraCombo) this.cboInterestStateID).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboInterestStateID).DropDownWidth = 500;
    ((Control) this.cboInterestStateID).Location = new Point(93, 264);
    this.cboInterestStateID.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboInterestStateID).Name = "cboInterestStateID";
    ((Control) this.cboInterestStateID).Size = new Size(151, 21);
    ((Control) this.cboInterestStateID).TabIndex = 11;
    ((UltraControlBase) this.cboInterestStateID).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInterestStateID).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInterestStateID).ValueMember = "StateID";
    appearance49.Cursor = Cursors.Hand;
    this.listSuggest.ItemSettings.Appearance = (AppearanceBase) appearance49;
    this.listSuggest.ItemSettings.HotTracking = true;
    appearance50.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance50.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.listSuggest.ItemSettings.HotTrackingAppearance = (AppearanceBase) appearance50;
    this.listSuggest.ItemSettings.SelectionType = (SelectionType) 2;
    ((Control) this.listSuggest).Location = new Point((int) sbyte.MaxValue, 36);
    ((Control) this.listSuggest).Name = "listSuggest";
    ((Control) this.listSuggest).Size = new Size(162, 270);
    ((Control) this.listSuggest).TabIndex = 34;
    this.listSuggest.View = (UltraListViewStyle) 2;
    this.listSuggest.ViewSettingsList.MultiColumn = false;
    ((Control) this.txtInsured).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance51.BackColor = Color.White;
    appearance51.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance51.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInsured).Appearance = (AppearanceBase) appearance51;
    ((TextEditorControlBase) this.txtInsured).BackColor = Color.White;
    ((Control) this.txtInsured).Location = new Point(58, 16 /*0x10*/);
    this.txtInsured.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtInsured).Name = "txtInsured";
    ((Control) this.txtInsured).Size = new Size(231, 20);
    ((Control) this.txtInsured).TabIndex = 0;
    ((UltraControlBase) this.txtInsured).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInsured).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.FlatStyle = FlatStyle.System;
    this.Label1.Location = new Point(8, 18);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(44, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Insured";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.tabAdvancedFilters).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.tabAdvancedFilters).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.tabAdvancedFilters).Controls.Add((Control) this.tab_Insured);
    ((Control) this.tabAdvancedFilters).Controls.Add((Control) this.tabCompany);
    ((Control) this.tabAdvancedFilters).Controls.Add((Control) this.tabProducer);
    ((Control) this.tabAdvancedFilters).Controls.Add((Control) this.tabPolicy);
    ((Control) this.tabAdvancedFilters).Controls.Add((Control) this.tabUndLocations);
    ((Control) this.tabAdvancedFilters).Controls.Add((Control) this.tabDrivers);
    ((Control) this.tabAdvancedFilters).Controls.Add((Control) this.tabAdditionalInterest);
    ((Control) this.tabAdvancedFilters).Location = new Point(0, 48 /*0x30*/);
    ((Control) this.tabAdvancedFilters).Name = "tabAdvancedFilters";
    ((UltraTabControlBase) this.tabAdvancedFilters).SharedControls.AddRange(new Control[5]
    {
      (Control) this.optionSearch,
      (Control) this.btnReset,
      (Control) this.btnSearch,
      (Control) this.numResults,
      (Control) this.Label10
    });
    ((UltraTabControlBase) this.tabAdvancedFilters).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.tabAdvancedFilters).Size = new Size(307, 624);
    ((UltraTabControlBase) this.tabAdvancedFilters).Style = (UltraTabControlStyle) 12;
    ((Control) this.tabAdvancedFilters).TabIndex = 0;
    ((UltraTabControlBase) this.tabAdvancedFilters).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.tabAdvancedFilters).TabOrientation = (TabOrientation) 5;
    appearance52.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance52.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance52;
    ultraTab1.TabPage = this.tabPolicy;
    ultraTab1.Text = "Policy";
    appearance53.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance53.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance53;
    ultraTab2.TabPage = this.tab_Insured;
    ultraTab2.Text = "Insured";
    appearance54.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance54.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance54;
    ultraTab3.TabPage = this.tabCompany;
    ultraTab3.Text = "Company";
    appearance55.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance55.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance55;
    ultraTab4.TabPage = this.tabProducer;
    ultraTab4.Text = "Producer";
    appearance56.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance56.Image"));
    ultraTab5.ActiveAppearance = (AppearanceBase) appearance56;
    appearance57.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance57.Image"));
    ultraTab5.Appearance = (AppearanceBase) appearance57;
    ultraTab5.TabPage = this.tabUndLocations;
    ultraTab5.Text = "Locations";
    appearance58.Image = (object) strings.car;
    ultraTab6.Appearance = (AppearanceBase) appearance58;
    ultraTab6.TabPage = this.tabDrivers;
    ultraTab6.Text = "Drivers";
    appearance59.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance59.Image"));
    ultraTab7.Appearance = (AppearanceBase) appearance59;
    ultraTab7.FixedWidth = 95;
    ultraTab7.TabPage = this.tabAdditionalInterest;
    ultraTab7.Text = "Add'l Interest";
    ((UltraTabControlBase) this.tabAdvancedFilters).Tabs.AddRange(new UltraTab[7]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5,
      ultraTab6,
      ultraTab7
    });
    ((UltraTabControlBase) this.tabAdvancedFilters).TabSize = new Size(75, 0);
    ((UltraControlBase) this.tabAdvancedFilters).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTabControlBase) this.tabAdvancedFilters).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.optionSearch);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnReset);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnSearch);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.numResults);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.Label10);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(286, 622);
    this.err.ContainerControl = (ContainerControl) this;
    this.dvStates.Table = (DataTable) this.ds.lstStates;
    ((Control) this).BackColor = Color.FromArgb(246, 250, 253);
    ((Control) this).Controls.Add((Control) this.tabAdvancedFilters);
    ((Control) this).Controls.Add((Control) this.Label1);
    ((Control) this).Controls.Add((Control) this.txtInsured);
    ((Control) this).Controls.Add((Control) this.listSuggest);
    ((Control) this).DoubleBuffered = true;
    ((Control) this).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this).ForeColor = Color.Black;
    ((Control) this).Name = nameof (TabClearanceSearch);
    ((Control) this).Size = new Size(297, 672);
    ((Control) this.tabPolicy).ResumeLayout(false);
    ((Control) this.tabPolicy).PerformLayout();
    ((ISupportInitialize) this.chkShowallInsured).EndInit();
    ((ISupportInitialize) this.MgatxtMailingAdd).EndInit();
    ((ISupportInitialize) this.txtClaimNo).EndInit();
    ((ISupportInitialize) this.txtAccountNumber).EndInit();
    ((ISupportInitialize) this.txtSubmissionNumber).EndInit();
    ((ISupportInitialize) this.chkOpenInNewWindow).EndInit();
    ((ISupportInitialize) this.cboIssuingOffice).EndInit();
    this.dvIssuingOffice.EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboQuotingOffice).EndInit();
    this.dvQuotingOffice.EndInit();
    ((ISupportInitialize) this.cboUnderwriters).EndInit();
    ((ISupportInitialize) this.chkHideVoid).EndInit();
    ((ISupportInitialize) this.cboPolicyType).EndInit();
    ((ISupportInitialize) this.dtExpirationEnd).EndInit();
    ((ISupportInitialize) this.dtEffectiveEnd).EndInit();
    ((ISupportInitialize) this.cboPolicyState).EndInit();
    this.dvPolicyState.EndInit();
    ((ISupportInitialize) this.txtControlNo).EndInit();
    ((ISupportInitialize) this.cboPolicyStatus).EndInit();
    ((ISupportInitialize) this.chkInForce).EndInit();
    ((ISupportInitialize) this.txtPolicyNum).EndInit();
    ((ISupportInitialize) this.dtEffectiveStart).EndInit();
    ((ISupportInitialize) this.dtExpirationStart).EndInit();
    ((Control) this.tab_Insured).ResumeLayout(false);
    ((Control) this.tab_Insured).PerformLayout();
    ((ISupportInitialize) this.txtRiskID).EndInit();
    ((ISupportInitialize) this.cboInsuredCity).EndInit();
    this.dvInsuredCity.EndInit();
    ((ISupportInitialize) this.txtInsuredPhone).EndInit();
    ((ISupportInitialize) this.cboInsuredState).EndInit();
    this.dvInsuredState.EndInit();
    ((ISupportInitialize) this.txtInsuredCode).EndInit();
    ((ISupportInitialize) this.txtFEIN).EndInit();
    ((ISupportInitialize) this.txtAddress).EndInit();
    ((ISupportInitialize) this.cboInsuredType).EndInit();
    ((ISupportInitialize) this.optionSearch).EndInit();
    ((ISupportInitialize) this.btnReset).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.numResults).EndInit();
    ((Control) this.tabCompany).ResumeLayout(false);
    ((Control) this.tabCompany).PerformLayout();
    ((ISupportInitialize) this.cboCompanyLocations).EndInit();
    ((ISupportInitialize) this.cboLine).EndInit();
    ((Control) this.tabProducer).ResumeLayout(false);
    ((Control) this.tabProducer).PerformLayout();
    ((ISupportInitialize) this.lstSuggestEmail).EndInit();
    ((ISupportInitialize) this.txtProducerEmail).EndInit();
    ((ISupportInitialize) this.cboProducer).EndInit();
    ((Control) this.tabUndLocations).ResumeLayout(false);
    ((Control) this.tabUndLocations).PerformLayout();
    ((ISupportInitialize) this.chkLocInForce).EndInit();
    ((ISupportInitialize) this.txtLocZip).EndInit();
    ((ISupportInitialize) this.cboLocCity).EndInit();
    this.dvLocCity.EndInit();
    ((ISupportInitialize) this.txtLocAddress).EndInit();
    ((ISupportInitialize) this.cboLocState).EndInit();
    ((Control) this.tabDrivers).ResumeLayout(false);
    ((Control) this.tabDrivers).PerformLayout();
    ((ISupportInitialize) this.txtDriverLast).EndInit();
    ((ISupportInitialize) this.txtDriverFirst).EndInit();
    ((ISupportInitialize) this.txtDriverAddress).EndInit();
    ((ISupportInitialize) this.txtDriverControlNo).EndInit();
    ((ISupportInitialize) this.chkDriverInforce).EndInit();
    ((ISupportInitialize) this.txtDriverZip).EndInit();
    ((ISupportInitialize) this.txtDriverLicenseNumber).EndInit();
    ((ISupportInitialize) this.cboDriverState).EndInit();
    ((Control) this.tabAdditionalInterest).ResumeLayout(false);
    ((Control) this.tabAdditionalInterest).PerformLayout();
    ((ISupportInitialize) this.txtInterestName).EndInit();
    ((ISupportInitialize) this.txtInterestLast).EndInit();
    ((ISupportInitialize) this.txtInterestFirst).EndInit();
    ((ISupportInitialize) this.txtInterestAddress).EndInit();
    ((ISupportInitialize) this.txtInterestControlNo).EndInit();
    ((ISupportInitialize) this.chkInterestInforce).EndInit();
    ((ISupportInitialize) this.txtInterestZip).EndInit();
    ((ISupportInitialize) this.txtInterest).EndInit();
    ((ISupportInitialize) this.cboInterestStateID).EndInit();
    ((ISupportInitialize) this.listSuggest).EndInit();
    ((ISupportInitialize) this.txtInsured).EndInit();
    ((ISupportInitialize) this.tabAdvancedFilters).EndInit();
    ((Control) this.tabAdvancedFilters).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).PerformLayout();
    ((ISupportInitialize) this.err).EndInit();
    this.dvStates.EndInit();
    ((Control) this).ResumeLayout(false);
    ((Control) this).PerformLayout();
  }

  public TabClearanceSearch()
  {
    this.DelayLoad += new EventHandler(this.TabClearanceSearch_DelayLoad);
    this._currentUserGuid = CurrentUser.Instance.UserGUID;
    this.inDelayLoad = false;
    this.AutoLookupTimer = new System.Windows.Forms.Timer();
    this.ProdEmailLookupTimer = new System.Windows.Forms.Timer();
    this.InitializeComponent();
    ClearanceSearch.TabClearance = this;
  }

  private void SetShowAllInsuredCheckBox()
  {
    ((Control) this.chkShowallInsured).Visible = SystemSettings.GetSetting<bool>("Clearance.Search.Show.ShowAllInsured.Checkbox", false);
    if (((Control) this.chkShowallInsured).Visible)
      ((UltraToggleEditorBase) this.chkShowallInsured).Checked = Preferences.GetPreferenceBool("PREFERENCE_CLEARANCESEARCH_SHOWALLINSUREDCHECKED");
    else
      ((UltraToggleEditorBase) this.chkShowallInsured).Checked = false;
  }

  protected virtual void Dispose(bool disposing)
  {
    try
    {
      foreach (Control control in ((Control) this).Controls)
      {
        if (control is TextBox textBox)
          textBox.KeyDown -= new KeyEventHandler(this.TextBox_KeyDown);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    foreach (UltraTab tab in ((UltraTabControlBase) this.tabAdvancedFilters).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
        {
          if (control is TextBox textBox)
            textBox.KeyDown -= new KeyEventHandler(this.TextBox_KeyDown);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    if (disposing)
    {
      this.AutoLookupTimer?.Dispose();
      this.components?.Dispose();
    }
    try
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((ContainerControl) this).Dispose(disposing));
    }
    catch (ArgumentOutOfRangeException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  public MGATextBox InsuredTextBox => this.txtInsured;

  public MGATextBox PolicyNumTextBox => this.txtPolicyNum;

  private void BtnSearch_Click(object sender, EventArgs e) => this.timerSearchDelay.Enabled = true;

  private bool IsInteger(string numberToTest)
  {
    bool flag;
    try
    {
      Conversions.ToInteger(numberToTest);
    }
    catch (OverflowException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      flag = false;
      ProjectData.ClearProjectError();
      goto label_3;
    }
    flag = true;
label_3:
    return flag;
  }

  private bool IsValid()
  {
    bool flag = true;
    if (((TextEditorControlBase) this.txtControlNo).TextLength > 0)
    {
      if (!Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtControlNo).Text) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtControlNo).Text, string.Empty, false) != 0 || !this.IsInteger(((TextEditorControlBase) this.txtControlNo).Text))
      {
        this.err.SetError((Control) this.txtControlNo, "Please enter a valid control number.");
        ((UltraTabControlBase) this.tabAdvancedFilters).SelectedTab = this.tabPolicy.Tab;
        flag = false;
      }
      else
        this.err.SetError((Control) this.txtControlNo, string.Empty);
    }
    return flag;
  }

  private void DoSearch()
  {
    if (((UltraTabControlBase) this.tabAdvancedFilters).SelectedTab == this.tabUndLocations.Tab)
    {
      if (!this.IsValidLocationSearch())
        return;
      Cursor.Current = MgaCursors.WaitCursor;
      try
      {
        FormClearanceLocation clearanceLocation;
        if (!((UltraToggleEditorBase) this.chkOpenInNewWindow).Checked)
        {
          clearanceLocation = (FormClearanceLocation) MDIControls.Instance.ActivateForm(typeof (FormClearanceLocation), true);
        }
        else
        {
          clearanceLocation = (FormClearanceLocation) ObjectFactory.Instance.CreateForm(typeof (FormClearanceLocation));
          clearanceLocation.StartPosition = FormStartPosition.WindowsDefaultLocation;
          clearanceLocation.MdiParent = MDIControls.Instance.MDIParent;
          clearanceLocation.Show();
        }
        LocationClearance searchLoc = this.SetLocationFields();
        clearanceLocation.StartSearch(searchLoc);
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
    }
    else if (((UltraTabControlBase) this.tabAdvancedFilters).SelectedTab == this.tabDrivers.Tab)
    {
      if (!this.IsValidDriverSearch())
        return;
      Cursor.Current = MgaCursors.WaitCursor;
      try
      {
        FormDriverClearance formDriverClearance;
        if (!((UltraToggleEditorBase) this.chkOpenInNewWindow).Checked)
        {
          formDriverClearance = (FormDriverClearance) MDIControls.Instance.ActivateForm(typeof (FormDriverClearance), true);
        }
        else
        {
          formDriverClearance = (FormDriverClearance) ObjectFactory.Instance.CreateForm(typeof (FormDriverClearance));
          formDriverClearance.StartPosition = FormStartPosition.WindowsDefaultLocation;
          formDriverClearance.MdiParent = MDIControls.Instance.MDIParent;
          formDriverClearance.Show();
        }
        DriverClearance dSearch = this.SetDriverFields();
        formDriverClearance.StartSearch(dSearch);
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
    }
    else if (((UltraTabControlBase) this.tabAdvancedFilters).SelectedTab == this.tabAdditionalInterest.Tab)
    {
      if (!this.IsValidAdditionalInterestSearch())
        return;
      Cursor.Current = MgaCursors.WaitCursor;
      try
      {
        FormAdditionalInterestClearance interestClearance;
        if (!((UltraToggleEditorBase) this.chkOpenInNewWindow).Checked)
        {
          interestClearance = (FormAdditionalInterestClearance) MDIControls.Instance.ActivateForm(typeof (FormAdditionalInterestClearance), true);
        }
        else
        {
          interestClearance = (FormAdditionalInterestClearance) ObjectFactory.Instance.CreateForm(typeof (FormAdditionalInterestClearance));
          interestClearance.StartPosition = FormStartPosition.WindowsDefaultLocation;
          interestClearance.MdiParent = MDIControls.Instance.MDIParent;
          interestClearance.Show();
        }
        AdditionalInterestSearch addlSearch = this.SetAdditionalInterestFields();
        interestClearance.StartSearch(addlSearch);
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
    }
    else if (this.IsClientSelectedTab())
    {
      this.ClientSelectedTab();
    }
    else
    {
      if (!this.IsValid())
        return;
      Cursor.Current = MgaCursors.WaitCursor;
      try
      {
        frmClearance frmClearance;
        if (!((UltraToggleEditorBase) this.chkOpenInNewWindow).Checked)
        {
          frmClearance = (frmClearance) MDIControls.Instance.ActivateForm(typeof (frmClearance), true);
        }
        else
        {
          frmClearance = (frmClearance) ObjectFactory.Instance.CreateForm(typeof (frmClearance));
          frmClearance.StartPosition = FormStartPosition.WindowsDefaultLocation;
          frmClearance.MdiParent = MDIControls.Instance.MDIParent;
          frmClearance.Show();
        }
        frmClearance.TabClearanceSearch = this;
        ClearanceSearchInfo searchInfo = this.AddClientSearchInfo(this.SetFields());
        frmClearance.InitiateSearch(searchInfo);
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
    }
  }

  protected virtual void ClientSelectedTab()
  {
  }

  protected virtual bool IsClientSelectedTab() => false;

  protected virtual ClearanceSearchInfo AddClientSearchInfo(ClearanceSearchInfo si) => si;

  private bool IsValidLocationSearch()
  {
    bool flag = true;
    if (((TextEditorControlBase) this.txtInsured).Text.Replace(" ", string.Empty).Length == 0 && ((TextEditorControlBase) this.txtLocAddress).Text.Replace(" ", string.Empty).Length == 0 && ((UltraCombo) this.cboLocState).Text.Replace(" ", string.Empty).Length == 0 && ((UltraCombo) this.cboLocCity).Text.Replace(" ", string.Empty).Length == 0 && !((UltraToggleEditorBase) this.chkLocInForce).Checked && ((TextEditorControlBase) this.txtLocZip).Text.Replace(" ", string.Empty).Length == 0)
    {
      flag = false;
      int num = (int) MessageBox.Show("Please enter underwriting location info to commence search on.", "Empty Underwriting Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    return flag;
  }

  protected virtual LocationClearance SetLocationFields()
  {
    LocationClearance locationClearance = new LocationClearance();
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtInsured).Text))
      locationClearance.InsuredName = ((TextEditorControlBase) this.txtInsured).Text;
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtLocAddress).Text))
      locationClearance.LocAddress = ((TextEditorControlBase) this.txtLocAddress).Text;
    if (((UltraCombo) this.cboLocCity).Text.Replace(" ", string.Empty).Length > 0 && ((UltraCombo) this.cboLocCity).Text.Contains("("))
      locationClearance.LocCity = ((UltraCombo) this.cboLocCity).Text.Substring(0, ((UltraCombo) this.cboLocCity).Text.IndexOf("(") - 1);
    else if (((UltraCombo) this.cboLocCity).Text.Replace(" ", string.Empty).Length > 0)
      locationClearance.LocCity = ((UltraCombo) this.cboLocCity).Text;
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboLocState).Text))
      locationClearance.LocState = ((UltraCombo) this.cboLocState).Value.ToString();
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtLocZip).Text))
      locationClearance.LocZip = ((TextEditorControlBase) this.txtLocZip).Text;
    locationClearance.NumResults = (int) ((UltraNumericEditor) this.numResults).Value;
    locationClearance.InforceOnly = ((UltraToggleEditorBase) this.chkLocInForce).Checked;
    return locationClearance;
  }

  private ClearanceSearchInfo BaseFields()
  {
    return new ClearanceSearchInfo()
    {
      StartsWith = this.optionSearch.CheckedIndex == 0,
      NumResults = Conversions.ToInteger(((UltraNumericEditor) this.numResults).Value),
      HideVoids = ((UltraToggleEditorBase) this.chkHideVoid).Checked
    };
  }

  private ClearanceSearchInfo SetFields()
  {
    ClearanceSearchInfo clearanceSearchInfo = this.BaseFields();
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtAddress).Text))
      clearanceSearchInfo.Address = ((TextEditorControlBase) this.txtAddress).Text;
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.MgatxtMailingAdd).Text))
      clearanceSearchInfo.MailingAddress = ((TextEditorControlBase) this.MgatxtMailingAdd).Text;
    clearanceSearchInfo.BusinessTypeID = string.IsNullOrEmpty(((UltraCombo) this.cboInsuredType).Text) ? new int?() : new int?(Conversions.ToInteger(((UltraCombo) this.cboInsuredType).Value));
    if (((UltraDateTimeEditor) this.dtExpirationStart).Value != null)
      clearanceSearchInfo.ExpirationStart = new DateTime?(((UltraDateTimeEditor) this.dtExpirationStart).DateTime);
    if (((UltraDateTimeEditor) this.dtExpirationEnd).Value != null)
      clearanceSearchInfo.ExpirationEnd = new DateTime?(((UltraDateTimeEditor) this.dtExpirationEnd).DateTime);
    if (((UltraDateTimeEditor) this.dtEffectiveStart).Value != null)
      clearanceSearchInfo.EffectiveStart = new DateTime?(((UltraDateTimeEditor) this.dtEffectiveStart).DateTime);
    if (((UltraDateTimeEditor) this.dtEffectiveEnd).Value != null)
      clearanceSearchInfo.EffectiveEnd = new DateTime?(((UltraDateTimeEditor) this.dtEffectiveEnd).DateTime);
    if (!string.IsNullOrEmpty(((UltraMaskedEdit) this.txtFEIN).Text))
      clearanceSearchInfo.FEIN = ((UltraMaskedEdit) this.txtFEIN).Text;
    clearanceSearchInfo.InForce = ((UltraToggleEditorBase) this.chkInForce).Checked;
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtInsured).Text))
      clearanceSearchInfo.InsuredName = ((TextEditorControlBase) this.txtInsured).Text;
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboCompanyLocations).Text))
      clearanceSearchInfo.CompanyLocationGuid = new Guid?((Guid) ((UltraCombo) this.cboCompanyLocations).Value);
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboLine).Text))
      clearanceSearchInfo.LineGuid = new Guid?((Guid) ((UltraCombo) this.cboLine).Value);
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboPolicyType).Text))
      clearanceSearchInfo.PolicyTypeID = new int?(Conversions.ToInteger(((UltraCombo) this.cboPolicyType).Value));
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtPolicyNum).Text))
      clearanceSearchInfo.PolicyNumber = ((TextEditorControlBase) this.txtPolicyNum).Text;
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboPolicyStatus).Text))
      clearanceSearchInfo.PolicyStatus = ((UltraCombo) this.cboPolicyStatus).Value.ToString();
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboProducer).Text))
      clearanceSearchInfo.ProducerLocationGuid = new Guid?((Guid) ((UltraCombo) this.cboProducer).Value);
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtInsuredCode).Text) && Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtInsuredCode).Text))
      clearanceSearchInfo.InsuredID = new int?(Conversions.ToInteger(((TextEditorControlBase) this.txtInsuredCode).Text));
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtSubmissionNumber).Text) && Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtSubmissionNumber).Text))
      clearanceSearchInfo.SubmissionID = new int?(Conversions.ToInteger(((TextEditorControlBase) this.txtSubmissionNumber).Text));
    if (!string.IsNullOrWhiteSpace(((TextEditorControlBase) this.txtAccountNumber).Text.Trim()))
      clearanceSearchInfo.AccountNumber = ((TextEditorControlBase) this.txtAccountNumber).Text.Trim();
    int result = -1;
    if (int.TryParse(((TextEditorControlBase) this.txtControlNo).Text, out result))
    {
      clearanceSearchInfo.ControlNo = new int?(result);
      clearanceSearchInfo.IsSinglePolicySearch = true;
    }
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboPolicyState).Text))
      clearanceSearchInfo.PolicyStateID = ((UltraCombo) this.cboPolicyState).Value.ToString();
    if (!string.IsNullOrEmpty(((UltraMaskedEdit) this.txtInsuredPhone).Value as string))
      clearanceSearchInfo.InsuredPhone = ((UltraMaskedEdit) this.txtInsuredPhone).Value.ToString();
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboInsuredState).Text))
      clearanceSearchInfo.InsuredStateID = ((UltraCombo) this.cboInsuredState).Value.ToString();
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboUnderwriters).Text))
      clearanceSearchInfo.Undewriter = new Guid?((Guid) ((UltraCombo) this.cboUnderwriters).Value);
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboQuotingOffice).Text))
      clearanceSearchInfo.QuotingOffice = new Guid?((Guid) ((UltraCombo) this.cboQuotingOffice).Value);
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboIssuingOffice).Text))
      clearanceSearchInfo.IssuingOffice = new Guid?((Guid) ((UltraCombo) this.cboIssuingOffice).Value);
    if (!string.IsNullOrWhiteSpace(((TextEditorControlBase) this.txtClaimNo).Text.Trim()))
      clearanceSearchInfo.ClaimNo = ((TextEditorControlBase) this.txtClaimNo).Text.Trim();
    clearanceSearchInfo.LimitToBoundStatusOnly = this._limitToBoundStatusOnly;
    if (!string.IsNullOrWhiteSpace(((TextEditorControlBase) this.txtProducerEmail).Text.Trim()))
      clearanceSearchInfo.ProducerEmail = ((TextEditorControlBase) this.txtProducerEmail).Text.Trim();
    if (!string.IsNullOrWhiteSpace(((UltraCombo) this.cboInsuredCity).Text) && !Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboInsuredCity).Value)))
      clearanceSearchInfo.InsuredCity = ((UltraCombo) this.cboInsuredCity).Value.ToString();
    if (this.SubmissionGroupID != 0)
    {
      clearanceSearchInfo.SubmissionID = new int?(this.SubmissionGroupID);
      clearanceSearchInfo.ControlNo = new int?();
      this.SubmissionGroupID = 0;
    }
    if (((UltraToggleEditorBase) this.chkShowallInsured).Checked)
    {
      clearanceSearchInfo.SubmissionID = new int?();
      clearanceSearchInfo.ControlNo = new int?();
      this.SubmissionGroupID = 0;
      clearanceSearchInfo.InsuredID = new int?(this.ShowAll_InsuredID);
      clearanceSearchInfo.InsuredName = this.ShowAll_InsuredName;
      this.ShowAll_InsuredID = 0;
      this.ShowAll_InsuredName = (string) null;
    }
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtRiskID).Text))
      clearanceSearchInfo.RiskID = ((TextEditorControlBase) this.txtRiskID).Text;
    return clearanceSearchInfo;
  }

  private void ChkInForce_CheckedChanged(object sender, EventArgs e)
  {
    try
    {
      foreach (Control control in ((Control) this.tabPolicy).Controls)
      {
        if (control is DateTimePicker dateTimePicker)
          dateTimePicker.Enabled = !((UltraToggleEditorBase) this.chkInForce).Checked;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((Control) this.cboPolicyStatus).Enabled = !((UltraToggleEditorBase) this.chkInForce).Checked;
    if (((UltraToggleEditorBase) this.chkInForce).Checked)
      ((UltraCombo) this.cboPolicyStatus).Value = (object) (QuoteStatus) 3;
    else
      ((UltraCombo) this.cboPolicyStatus).Value = (object) null;
  }

  private void BtnReset_Click(object sender, EventArgs e) => this.ClearSearch();

  private void TabClearanceSearch_DelayLoad(object sender, EventArgs e)
  {
    if (((Component) this).DesignMode)
      return;
    try
    {
      this.inDelayLoad = true;
      this.SetShowAllInsuredCheckBox();
      ((UltraListViewSettingsBase) this.listSuggest.ViewSettingsList).ImageSize = Size.Empty;
      this.listSuggest.ItemSettings.Appearance.Cursor = MgaCursors.Hand;
      this.SetSuggestListSize();
      this._limitToBoundStatusOnly = SecurityManager.Instance.AssertPermission("{CDC44561-14F4-4c8c-B485-1FF4B71C3A84}");
      ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
      ((ControlBase) this.btnReset).Appearance.Image = (object) ImageCache.Instance.Refresh;
      int num = Preferences.GetPreferenceInt("TabClearanceSearch.MaxSearchResults");
      if (num == -1)
        num = SystemSettings.GetSetting<int>("TabClearanceSearch.MaxSearchResults", 75);
      int preferenceInt = Preferences.GetPreferenceInt("TabClearanceSearchLimitValue");
      ((UltraNumericEditor) this.numResults).MaxValue = (object) num;
      ((UltraNumericEditor) this.numResults).Value = (object) Conversions.ToInteger(preferenceInt > num ? ((UltraNumericEditor) this.numResults).MaxValue : (object) preferenceInt);
      try
      {
        foreach (Control control in ((Control) this).Controls)
        {
          if (control is UltraTextEditor ultraTextEditor)
            ((Control) ultraTextEditor).KeyDown += new KeyEventHandler(this.TextBox_KeyDown);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      UltraTabsCollection.TabEnumerator enumerator1 = ((UltraTabControlBase) this.tabAdvancedFilters).Tabs.GetEnumerator();
      while (((DisposableObjectEnumeratorBase) enumerator1).MoveNext())
      {
        UltraTab current = enumerator1.Current;
        try
        {
          foreach (Control control in ((Control) current.TabPage).Controls)
          {
            if (control is UltraTextEditor ultraTextEditor)
              ((Control) ultraTextEditor).KeyDown += new KeyEventHandler(this.TextBox_KeyDown);
          }
        }
        finally
        {
          IEnumerator enumerator2;
          if (enumerator2 is IDisposable)
            (enumerator2 as IDisposable).Dispose();
        }
      }
      MGASimpleComboBox cboProducer = this.cboProducer;
      ((UltraGridBase) cboProducer).DataSource = RuntimeHelpers.GetObjectValue(PreLoadCache.Instance.Cache[(object) "tblProducerLocations"]);
      ((UltraDropDownBase) cboProducer).DisplayMember = "Name";
      ((UltraDropDownBase) cboProducer).ValueMember = "ProducerLocationGuid";
      ((Control) cboProducer).Enabled = true;
      this.ClearSearch();
    }
    finally
    {
      this.inDelayLoad = false;
    }
  }

  private void TextBox_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.DoSearch();
  }

  private void QuoteStatusThreadExit(object sender, EventArgs e)
  {
    ((UltraGridBase) this.cboPolicyStatus).DataSource = (object) this.ds.lstQuoteStatus;
    ((UltraDropDownBase) this.cboPolicyStatus).DisplayMember = "Description";
    ((UltraDropDownBase) this.cboPolicyStatus).ValueMember = "QuoteStatusID";
  }

  private void CompanyTabDataThreadExit(object sender, EventArgs e)
  {
    ((UltraDropDownBase) this.cboCompanyLocations).DisplayMember = "Name";
    ((UltraDropDownBase) this.cboCompanyLocations).ValueMember = "CompanyLocationGuid";
    ((UltraGridBase) this.cboCompanyLocations).DataSource = (object) this.ds.tblCompanyLocations;
    ((UltraDropDownBase) this.cboLine).DisplayMember = "LineName";
    ((UltraDropDownBase) this.cboLine).ValueMember = "LineGuid";
    ((UltraGridBase) this.cboLine).DataSource = (object) this.ds.lstLines;
  }

  private void LoadQuoteStatus(object state)
  {
    this.ds.lstQuoteStatus.AddlstQuoteStatusRow(0, string.Empty);
    DefaultDatabase.LoadDataTable((DataTable) this.ds.lstQuoteStatus, "dbo.GetClearanceSearchQuoteStatus");
    ((Control) this).Invoke((Delegate) new EventHandler(this.QuoteStatusThreadExit));
  }

  private void LoadCompanyTabData(object state)
  {
    Guid userGuid = CurrentUser.Instance.UserGUID;
    this.ds.lstLines.AddlstLinesRow(Guid.Empty, string.Empty);
    DefaultDatabase.ExecuteReader((EventHandler<ExecuteReaderArgs>) ([SpecialName] (s, lineReader) => this.ds.lstLines.Load(lineReader.Reader)), "dbo.GetClearanceLinesOfBusiness", new object[2]
    {
      (object) "@UserGuid",
      (object) userGuid
    });
    this.ds.tblCompanyLocations.AddtblCompanyLocationsRow(Guid.Empty, string.Empty);
    DefaultDatabase.ExecuteReader((EventHandler<ExecuteReaderArgs>) ([SpecialName] (s, compReader) => this.ds.tblCompanyLocations.Load(compReader.Reader)), "dbo.GetClearanceCompanyLocations", new object[2]
    {
      (object) "@UserGuid",
      (object) userGuid
    });
    ((Control) this).Invoke((Delegate) new EventHandler(this.CompanyTabDataThreadExit));
  }

  private void TabCompany_SelectedTabChanged(object sender, SelectedTabChangedEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TabEventArgs) e).Tab.Text, "Policy", false) == 0)
    {
      if (this.ds.lstQuoteStatus.Count == 0)
        ThreadPool.QueueUserWorkItem(new WaitCallback(this.LoadQuoteStatus));
      if (this.ds.lstPolicyTypes.Count == 0)
      {
        this.ds.lstPolicyTypes.AddlstPolicyTypesRow(-1, string.Empty);
        this.ds.Underwriters.AddUnderwritersRow(Guid.Empty, string.Empty);
        DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
        {
          this.ds.lstPolicyTypes.TableName.ToString(),
          this.ds.Underwriters.TableName.ToString()
        }, "dbo.GetClearancePolicyTabData");
      }
      if (this.ds.tblClientOffices.Rows.Count == 0)
      {
        this.ds.tblClientOffices.AddtblClientOfficesRow(new Guid(), string.Empty);
        DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
        {
          "tblClientOffices"
        }, "spGetClearanceQuotingOffices", new object[2]
        {
          (object) "@CurrentUserGuid",
          (object) CurrentUser.Instance.UserGUID
        });
      }
      if (this.ds.dtIssuingOffice.Rows.Count == 0)
      {
        this.ds.dtIssuingOffice.AdddtIssuingOfficeRow(new Guid(), string.Empty);
        DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
        {
          "dtIssuingOffice"
        }, "dbo.spGetClearanceIssuingOffices", new object[2]
        {
          (object) "@CurrentUserGuid",
          (object) CurrentUser.Instance.UserGUID
        });
      }
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TabEventArgs) e).Tab.Text, "Company", false) == 0)
    {
      if (this.ds.tblCompanyLocations.Count == 0)
        ThreadPool.QueueUserWorkItem(new WaitCallback(this.LoadCompanyTabData));
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TabEventArgs) e).Tab.Text, "Locations", false) == 0)
    {
      if (this.ds.UnderwritingLocations.Count == 0)
        ThreadPool.QueueUserWorkItem(new WaitCallback(this.GetUnderwritingLocationsThread));
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TabEventArgs) e).Tab.Text, "Insured", false) == 0 && this.ds.InsuredsCityStates.Count == 0)
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.GetInsuredCities));
    MDIControls.Instance.ProgressPanel.Visible = false;
  }

  private void GetInsuredCities(object state)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "InsuredsCityStates"
    }, CommandType.StoredProcedure, "dbo.spGetSearchInsuredCities", 180, (CommandArgumentType) 2, (object[]) null);
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new TabClearanceSearch.GetInsuredCitiesCompleteHandler(this.LocationComplete), new object[0]);
  }

  private void GetUnderwritingLocationsThread(object state)
  {
    SqlCommand sqlCommand = new SqlCommand("dbo.spGetSearchUnderwritingLocations", DefaultDatabase.CreateConnection());
    SqlDataReader sqlDataReader = (SqlDataReader) null;
    try
    {
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Connection.Open();
      sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult);
      while (sqlDataReader.Read())
        this.ds.UnderwritingLocations.AddUnderwritingLocationsRow(sqlDataReader.GetString(0), sqlDataReader.GetString(1), $"{sqlDataReader.GetString(0)} ({sqlDataReader.GetString(1)})");
      sqlDataReader.Close();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      SqlException sqlException = ex;
      sqlCommand.Connection.Close();
      ErrorHandler.HandleError((Exception) sqlException);
      ProjectData.ClearProjectError();
    }
    finally
    {
      if (sqlDataReader != null && !sqlDataReader.IsClosed)
        sqlDataReader.Close();
      sqlCommand.Connection.Close();
      sqlCommand.Connection.Dispose();
      sqlCommand.Dispose();
    }
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new TabClearanceSearch.GetLocationCompleteHandler(this.LocationComplete), new object[0]);
  }

  private void LocationComplete()
  {
    ((UltraCombo) this.cboLocCity).DropDownStyle = (UltraComboStyle) 0;
  }

  private void InsuredCitiesComplete()
  {
    ((UltraCombo) this.cboInsuredCity).DropDownStyle = (UltraComboStyle) 0;
  }

  private void TimerSearchDelay_Tick(object sender, EventArgs e)
  {
    this.timerSearchDelay.Enabled = false;
    this.DoSearch();
  }

  public void ShowItem() => DockingManager.ShowAndActivate(this.CreationInfo.Key);

  public void ClearSearch()
  {
    ((TextEditorControlBase) this.txtInsured).Text = string.Empty;
    try
    {
      IEnumerable<UltraTab> source = ((IEnumerable) ((UltraTabControlBase) this.tabAdvancedFilters).Tabs.TabControl.Tabs).OfType<UltraTab>();
      System.Func<UltraTab, IEnumerable<Control>> selector;
      // ISSUE: reference to a compiler-generated field
      if (TabClearanceSearch._Closure\u0024__.\u0024I466\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = TabClearanceSearch._Closure\u0024__.\u0024I466\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        TabClearanceSearch._Closure\u0024__.\u0024I466\u002D0 = selector = (System.Func<UltraTab, IEnumerable<Control>>) ([SpecialName] (tab) => ((Control) tab.TabPage).Controls.OfType<Control>());
      }
      foreach (Control control in source.SelectMany<UltraTab, Control>(selector))
      {
        switch (control)
        {
          case MGATextBox _:
            ((TextEditorControlBase) control).Text = string.Empty;
            continue;
          case MGASimpleComboBox _:
            ((UltraCombo) control).Value = (object) null;
            continue;
          case MGADateTimePicker _:
            ((UltraDateTimeEditor) control).Value = (object) DBNull.Value;
            continue;
          case CheckBox _ when control != this.chkHideVoid:
            (control as CheckBox).Checked = false;
            continue;
          case MGAMaskedEdit _:
            ((UltraMaskedEdit) (control as MGAMaskedEdit)).Text = string.Empty;
            continue;
          default:
            continue;
        }
      }
    }
    finally
    {
      IEnumerator<Control> enumerator;
      enumerator?.Dispose();
    }
    ((Control) this.txtInsured).Select();
  }

  public void AddStateAndCity(string state, string city)
  {
    if (state.Length == 0 || city.Length == 0 || this.ds.UnderwritingLocations.Select($"City='{city}'").Length > 0)
      return;
    dsTabClearance.UnderwritingLocationsRow row = this.ds.UnderwritingLocations.NewUnderwritingLocationsRow();
    row.City = city;
    row.State = state;
    row.CityAndState = $"{city} ({state})";
    this.ds.UnderwritingLocations.AddUnderwritingLocationsRow(row);
    this.ds.UnderwritingLocations.AcceptChanges();
    this.dvLocCity.Table = (DataTable) this.ds.UnderwritingLocations;
    ((UltraGridBase) this.cboLocCity).DataSource = (object) this.dvLocCity;
    ((UltraDropDownBase) this.cboLocCity).DisplayMember = "CityAndState";
    ((UltraDropDownBase) this.cboLocCity).ValueMember = "City";
  }

  public void BeforeLogOut()
  {
  }

  public DockWindowCreationInfo CreationInfo
  {
    get
    {
      return new DockWindowCreationInfo("ClearanceSearch", "Search", (DockedLocation) 1, "LeftGroupKey", ImageCache.Instance.Search, false);
    }
  }

  void IMdiActivationListener.MDIChildActivating(Form mdiChild)
  {
  }

  void IMdiActivationListener.MDIChildDeActivate(Form mdiChild)
  {
  }

  public void InitializeOnSplashLoad()
  {
    this.ds.lstBusinessTypes.AddlstBusinessTypesRow(0, string.Empty);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstBusinessTypes"
    }, CommandType.Text, "SELECT BusinessTypeID, BusinessType FROM dbo.lstBusinessTypes");
    this.ds.lstStates.AddlstStatesRow((string) null, string.Empty);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstStates"
    }, CommandType.Text, "SELECT StateID, State FROM dbo.lstStates ORDER BY State");
  }

  public void AfterLogon()
  {
  }

  public int PreferredPosition => 1;

  public void ShowBalloonTip(string title, string text, BalloonTip.BalloonTipIcons icon)
  {
    BalloonTip.ShowEditTip((Control) this.txtInsured, title, text, icon);
  }

  public void SwitchToTab(TabClearanceSearch.ClearanceTabs tab)
  {
    if (tab > TabClearanceSearch.ClearanceTabs.AdditionalInterest)
      return;
    if (tab < TabClearanceSearch.ClearanceTabs.Insured)
      return;
    try
    {
      switch (tab)
      {
        case TabClearanceSearch.ClearanceTabs.Insured:
          ((UltraTabControlBase) this.tabAdvancedFilters).SelectedTab = this.tab_Insured.Tab;
          break;
        case TabClearanceSearch.ClearanceTabs.Company:
          ((UltraTabControlBase) this.tabAdvancedFilters).SelectedTab = this.tabCompany.Tab;
          break;
        case TabClearanceSearch.ClearanceTabs.Producer:
          ((UltraTabControlBase) this.tabAdvancedFilters).SelectedTab = this.tabProducer.Tab;
          break;
        case TabClearanceSearch.ClearanceTabs.Policy:
          ((UltraTabControlBase) this.tabAdvancedFilters).SelectedTab = this.tabPolicy.Tab;
          break;
        case TabClearanceSearch.ClearanceTabs.UnderwritingLocation:
          ((UltraTabControlBase) this.tabAdvancedFilters).SelectedTab = this.tabUndLocations.Tab;
          break;
        case TabClearanceSearch.ClearanceTabs.Drivers:
          ((UltraTabControlBase) this.tabAdvancedFilters).SelectedTab = this.tabDrivers.Tab;
          break;
        case TabClearanceSearch.ClearanceTabs.AdditionalInterest:
          ((UltraTabControlBase) this.tabAdvancedFilters).SelectedTab = this.tabAdditionalInterest.Tab;
          break;
      }
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void LnkQuickJump_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.err.SetError((Control) this.txtControlNo, string.Empty);
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtControlNo).Text))
    {
      this.err.SetError((Control) this.txtControlNo, "A control number is not entered.");
      ((UltraTabControlBase) this.tabAdvancedFilters).SelectedTab = this.tabPolicy.Tab;
    }
    else
    {
      if (!this.IsValid())
        return;
      if (!Conversions.ToBoolean(DefaultDatabase.ExecuteScalar("ValidateUserRightControlNo", new object[4]
      {
        (object) "@ControlNo",
        (object) Conversions.ToInteger(((TextEditorControlBase) this.txtControlNo).Text),
        (object) "@UserGuid",
        (object) CurrentUser.Instance.UserGUID
      })))
      {
        this.err.SetError((Control) this.txtControlNo, "Control # does not exist.");
        ((UltraTabControlBase) this.tabAdvancedFilters).SelectedTab = this.tabPolicy.Tab;
      }
      else
        frmControlNumberJump.LaunchAppropriateQuoteForm(Conversions.ToInteger(((TextEditorControlBase) this.txtControlNo).Text));
    }
  }

  private void LinkPolicyNumberQuickJump_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtPolicyNum).Text))
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    int? nullable = DefaultDatabase.ExecuteScalar<int?>("dbo.GetControlNoFromJump", new object[2]
    {
      (object) "@PolicyNumber",
      (object) ((TextEditorControlBase) this.txtPolicyNum).Text
    });
    if (nullable.HasValue)
    {
      if (!DefaultDatabase.ExecuteScalar<bool>("dbo.ValidateUserRightControlNo", new object[4]
      {
        (object) "@ControlNo",
        (object) nullable,
        (object) "@UserGuid",
        (object) CurrentUser.Instance.UserGUID
      }))
      {
        Cursor.Current = MgaCursors.Default;
        int num = (int) MessageBox.Show("This policy number was not found.", "Policy Not Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
        frmControlNumberJump.LaunchAppropriateQuoteForm(nullable.Value);
    }
    else
    {
      Cursor.Current = MgaCursors.Default;
      int num = (int) MessageBox.Show("This policy number was not found.", "Policy Not Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private void LnkSubmissionShowAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtSubmissionNumber).Text))
      return;
    int result;
    if (!int.TryParse(((TextEditorControlBase) this.txtSubmissionNumber).Text, out result))
    {
      int num1 = (int) MessageBox.Show("Invalid submission number entered.", "Invalid Submission", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      Cursor.Current = MgaCursors.WaitCursor;
      int? nullable = DefaultDatabase.ExecuteFunction<int?>("dbo.GetInsuredIDBySubmissionNumber", new object[2]
      {
        (object) "@SubmissionID",
        (object) result
      });
      if (!nullable.HasValue)
      {
        Cursor.Current = MgaCursors.Default;
        int num2 = (int) MessageBox.Show("This submission number was not found.", "Submission Not Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        try
        {
          frmClearance frmClearance;
          if (!((UltraToggleEditorBase) this.chkOpenInNewWindow).Checked)
          {
            frmClearance = (frmClearance) MDIControls.Instance.ActivateForm(typeof (frmClearance), true);
          }
          else
          {
            frmClearance = (frmClearance) ObjectFactory.Instance.CreateForm(typeof (frmClearance));
            frmClearance.StartPosition = FormStartPosition.WindowsDefaultLocation;
            frmClearance.MdiParent = MDIControls.Instance.MDIParent;
            frmClearance.Show();
          }
          frmClearance.TabClearanceSearch = this;
          ClearanceSearchInfo searchInfo = this.BaseFields() with
          {
            InsuredID = new int?(nullable.Value)
          };
          frmClearance.InitiateSearch(searchInfo);
        }
        finally
        {
          Cursor.Current = MgaCursors.Default;
        }
      }
    }
  }

  private virtual System.Windows.Forms.Timer AutoLookupTimer
  {
    get => this._AutoLookupTimer;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.AutoLookupTimer_Tick);
      System.Windows.Forms.Timer autoLookupTimer1 = this._AutoLookupTimer;
      if (autoLookupTimer1 != null)
        autoLookupTimer1.Tick -= eventHandler;
      this._AutoLookupTimer = value;
      System.Windows.Forms.Timer autoLookupTimer2 = this._AutoLookupTimer;
      if (autoLookupTimer2 == null)
        return;
      autoLookupTimer2.Tick += eventHandler;
    }
  }

  private virtual System.Windows.Forms.Timer ProdEmailLookupTimer
  {
    get => this._ProdEmailLookupTimer;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ProdEmailLookupTimer_Tick);
      System.Windows.Forms.Timer emailLookupTimer1 = this._ProdEmailLookupTimer;
      if (emailLookupTimer1 != null)
        emailLookupTimer1.Tick -= eventHandler;
      this._ProdEmailLookupTimer = value;
      System.Windows.Forms.Timer emailLookupTimer2 = this._ProdEmailLookupTimer;
      if (emailLookupTimer2 == null)
        return;
      emailLookupTimer2.Tick += eventHandler;
    }
  }

  private void TxtInsured_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode == Keys.Escape)
    {
      if (((Control) this.listSuggest).Visible)
      {
        ((Control) this.listSuggest).Visible = false;
        this.AutoLookupTimer.Stop();
      }
      else
        ((TextEditorControlBase) this.txtInsured).Text = string.Empty;
    }
    else
    {
      if (((Control) this.listSuggest).Visible)
      {
        for (int index = this.listSuggest.Items.Count - 1; index >= 0; index += -1)
        {
          if (!this.listSuggest.Items[index].ToString().Contains(((TextEditorControlBase) this.txtInsured).Text))
            this.listSuggest.Items.Remove(this.listSuggest.Items[index]);
        }
      }
      this.SetSuggestListSize();
      if (Preferences.GetPreferenceBool("Clearance.AutoSuggest") && !this.AutoLookupTimer.Enabled && ((TextEditorControlBase) this.txtInsured).Text.Length >= 3)
      {
        ((Control) this).Cursor = MgaCursors.Working;
        this.AutoLookupTimer.Interval = 1000;
        this.AutoLookupTimer.Start();
      }
      else
      {
        if (!this.AutoLookupTimer.Enabled)
          return;
        this.AutoLookupTimer.Stop();
        this.AutoLookupTimer.Start();
      }
    }
  }

  private void SetSuggestListSize()
  {
    if (this.listSuggest.Items.Count == 0)
    {
      ((Control) this.listSuggest).Height = 0;
    }
    else
    {
      ((Control) this.listSuggest).Height = this.listSuggest.ItemSizeResolved.Height * this.listSuggest.Items.Count + 5;
      ((Control) this.listSuggest).Width = this.listSuggest.ItemSizeResolved.Width + 5;
    }
  }

  private void SetSuggestLstSizeProdEmail()
  {
    if (this.lstSuggestEmail.Items.Count == 0)
    {
      ((Control) this.lstSuggestEmail).Height = 0;
    }
    else
    {
      ((Control) this.lstSuggestEmail).Height = this.lstSuggestEmail.ItemSizeResolved.Height * this.lstSuggestEmail.Items.Count + 10;
      ((Control) this.lstSuggestEmail).Width = this.lstSuggestEmail.ItemSizeResolved.Width + 5;
    }
  }

  private void AutoLookupTimer_Tick(object sender, EventArgs e)
  {
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtInsured).Text))
    {
      Thread suggestThread = this._suggestThread;
      if ((suggestThread != null ? (suggestThread.IsAlive ? 1 : 0) : 0) == 0)
      {
        this.AutoLookupTimer.Stop();
        this.listSuggest.Items.Clear();
        ((Control) this).Cursor = MgaCursors.Working;
        this._suggestThread = new Thread(new ThreadStart(this.DoSuggestSearch));
        this._suggestThread.Start();
        return;
      }
    }
    ((Control) this.listSuggest).Visible = false;
    ((Control) this).Cursor = MgaCursors.Default;
  }

  private void ProdEmailLookupTimer_Tick(object sender, EventArgs e)
  {
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtProducerEmail).Text))
    {
      Thread suggestThread = this._suggestThread;
      if ((suggestThread != null ? (suggestThread.IsAlive ? 1 : 0) : 0) == 0)
      {
        this.ProdEmailLookupTimer.Stop();
        this.lstSuggestEmail.Items.Clear();
        ((Control) this).Cursor = MgaCursors.Working;
        this._suggestThread = new Thread(new ThreadStart(this.DoSuggestSearchForProdEmail));
        this._suggestThread.Start();
        return;
      }
    }
    ((Control) this.lstSuggestEmail).Visible = false;
    ((Control) this).Cursor = MgaCursors.Default;
  }

  private void DoSuggestSearch()
  {
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new TabClearanceSearch.SuggestSearchCompleteHandler(this.SuggestSearchComplete), new object[1]
    {
      (object) DefaultDatabase.ExecuteDataTable("dbo.spSuggest", new object[6]
      {
        (object) "@sw",
        (object) (this.optionSearch.CheckedIndex == 0),
        (object) "@name",
        (object) ((TextEditorControlBase) this.txtInsured).Text,
        (object) "@ug",
        (object) this._currentUserGuid
      })
    });
  }

  private void DoSuggestSearchForProdEmail()
  {
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new TabClearanceSearch.SuggestProducerEmailSearchCompleteHandler(this.SuggestSearchCompleteProdEmail), new object[1]
    {
      (object) DefaultDatabase.ExecuteDataTable("dbo.spSuggestProdEmail", new object[6]
      {
        (object) "@sw",
        (object) (this.optionSearch.CheckedIndex == 0),
        (object) "@name",
        (object) ((TextEditorControlBase) this.txtProducerEmail).Text,
        (object) "@ug",
        (object) this._currentUserGuid
      })
    });
  }

  private void SuggestSearchComplete(DataTable dt)
  {
    try
    {
      foreach (DataRow row in dt.Rows)
        this.listSuggest.Items.Add(row[0].ToString(), (object) row[0].ToString());
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (dt.Rows.Count > 0)
    {
      this.SetSuggestListSize();
      ((Control) this.listSuggest).Visible = true;
      ((Control) this.listSuggest).BringToFront();
    }
    else
      ((Control) this.listSuggest).Visible = false;
    ((Control) this).Cursor = MgaCursors.Default;
  }

  private void SuggestSearchCompleteProdEmail(DataTable dt)
  {
    try
    {
      foreach (DataRow row in dt.Rows)
        this.lstSuggestEmail.Items.Add(row[0].ToString(), (object) row[0].ToString());
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (dt.Rows.Count > 0)
    {
      this.SetSuggestLstSizeProdEmail();
      ((Control) this.lstSuggestEmail).Visible = true;
      ((Control) this.lstSuggestEmail).BringToFront();
    }
    else
      ((Control) this.lstSuggestEmail).Visible = false;
    ((Control) this).Cursor = MgaCursors.Default;
  }

  private void ListSuggest_ItemSelectionChanged(object sender, ItemSelectionChangedEventArgs e)
  {
    ((Control) this.listSuggest).Visible = false;
    if (((DisposableObjectCollectionBase) this.listSuggest.SelectedItems).Count <= 0)
      return;
    ((TextEditorControlBase) this.txtInsuredCode).Value = (object) DefaultDatabase.ExecuteFunction<int>("dbo.GetInsuredIDByPolicyName", new object[2]
    {
      (object) "@IPN",
      (object) ((UltraListViewItemBase) ((UltraListViewStateSpecificItemsCollectionBase) this.listSuggest.SelectedItems)[0]).Text
    });
    this.DoSearch();
    ((TextEditorControlBase) this.txtInsuredCode).Value = (object) null;
  }

  private void ListSuggest_MouseLeave(object sender, EventArgs e)
  {
    ((Control) this.listSuggest).Visible = false;
  }

  private void TxtInsured_LostFocus(object sender, EventArgs e)
  {
    ((Control) this.listSuggest).Visible = false;
  }

  private void CboLocState_ValueChanged(object sender, EventArgs e)
  {
    this.SetLocationParameters();
    ((UltraCombo) this.cboLocCity).Value = (object) null;
    if (((UltraCombo) this.cboLocState).Text != null && ((UltraCombo) this.cboLocState).Text.Length > 0)
      this.dvLocCity.RowFilter = $"State='{RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboLocState).Value)}'";
    else
      this.dvLocCity.RowFilter = string.Empty;
  }

  private void CboLocCity_ValueChanged(object sender, EventArgs e)
  {
    this.SetLocationParameters();
    if (((UltraCombo) this.cboLocCity).Value == null || ((UltraCombo) this.cboLocCity).Value == DBNull.Value || !((UltraCombo) this.cboLocCity).Text.Contains("(") || !((UltraCombo) this.cboLocCity).Text.Contains(")"))
      return;
    string text = ((UltraCombo) this.cboLocCity).Text;
    DataRow[] dataRowArray = this.dvStates.Table.Select($"StateId = '{text.Substring(text.IndexOf("(") + 1, text.Length - 1 - (text.IndexOf("(") + 1))}'");
    int index = 0;
    while (index < dataRowArray.Length)
    {
      ((UltraCombo) this.cboLocState).Text = dataRowArray[index].Field<string>("State");
      ((UltraCombo) this.cboLocCity).Text = text;
      checked { ++index; }
    }
  }

  private void TxtLocAddress_AfterExitEditMode(object sender, EventArgs e)
  {
    this.SetLocationParameters();
  }

  private void TxtLocZip_AfterExitEditMode(object sender, EventArgs e)
  {
    this.SetLocationParameters();
  }

  private void SetLocationParameters()
  {
    ClearanceSearch.StateInfo = string.Empty;
    ClearanceSearch.CityInfo = string.Empty;
    ClearanceSearch.StreetInfo = string.Empty;
    ClearanceSearch.ZipInfo = string.Empty;
    if (((UltraDropDownBase) this.cboLocState).SelectedRow != null)
      ClearanceSearch.StateInfo = ((UltraCombo) this.cboLocState).Value.ToString();
    if (((UltraDropDownBase) this.cboLocCity).SelectedRow != null && ((UltraCombo) this.cboLocCity).Text.Contains("(") && ((UltraCombo) this.cboLocCity).Text.Contains(")"))
      ClearanceSearch.CityInfo = ((UltraCombo) this.cboLocCity).Value.ToString();
    else if (((UltraCombo) this.cboLocCity).Text.Replace(" ", string.Empty).Length > 0)
      ClearanceSearch.CityInfo = ((UltraCombo) this.cboLocCity).Text;
    if (((TextEditorControlBase) this.txtLocAddress).Text.Replace(" ", string.Empty).Length > 0)
      ClearanceSearch.StreetInfo = ((TextEditorControlBase) this.txtLocAddress).Text;
    if (((TextEditorControlBase) this.txtLocZip).Text.Replace(" ", string.Empty).Length <= 0)
      return;
    ClearanceSearch.ZipInfo = ((TextEditorControlBase) this.txtLocZip).Text;
  }

  private void NumResults_ValueChanged(object sender, EventArgs e)
  {
    if (this.inDelayLoad)
      return;
    Preferences.SetPreference("TabClearanceSearchLimitValue", RuntimeHelpers.GetObjectValue(((UltraNumericEditor) this.numResults).Value));
    int num = Preferences.GetPreferenceInt("TabClearanceSearch.MaxSearchResults");
    if (num == -1)
      num = SystemSettings.GetSetting<int>("TabClearanceSearch.MaxSearchResults", 75);
    ((UltraNumericEditor) this.numResults).MaxValue = (object) num;
  }

  private bool IsValidDriverSearch()
  {
    bool flag = true;
    if (((TextEditorControlBase) this.txtDriverFirst).Text.Replace(" ", string.Empty).Length == 0 && ((TextEditorControlBase) this.txtDriverLast).Text.Replace(" ", string.Empty).Length == 0 && ((TextEditorControlBase) this.txtDriverLicenseNumber).Text.Replace(" ", string.Empty).Length == 0 && ((TextEditorControlBase) this.txtInsured).Text.Replace(" ", string.Empty).Length == 0 && ((TextEditorControlBase) this.txtDriverControlNo).Text.Replace(" ", string.Empty).Length == 0 && ((TextEditorControlBase) this.txtDriverAddress).Text.Replace(" ", string.Empty).Length == 0 && ((UltraCombo) this.cboDriverState).Text.Replace(" ", string.Empty).Length == 0 && ((TextEditorControlBase) this.txtDriverZip).Text.Replace(" ", string.Empty).Length == 0 && !((UltraToggleEditorBase) this.chkDriverInforce).Checked)
    {
      flag = false;
      int num = (int) MessageBox.Show("Please enter driver information to commence search.", "Empty Driver Search Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    if (flag && ((TextEditorControlBase) this.txtDriverControlNo).Text.Replace(" ", string.Empty).Length > 0)
    {
      int result = int.MinValue;
      if (!int.TryParse(((TextEditorControlBase) this.txtDriverControlNo).Text, out result))
      {
        flag = false;
        int num = (int) MessageBox.Show("Control # must be a numberic.", "Invalid Control #", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
    return flag;
  }

  protected virtual DriverClearance SetDriverFields()
  {
    DriverClearance driverClearance = new DriverClearance();
    if (((TextEditorControlBase) this.txtInsured).Text.Replace(" ", string.Empty).Length > 0)
      driverClearance.InsuredName = ((TextEditorControlBase) this.txtInsured).Text;
    if (((TextEditorControlBase) this.txtDriverFirst).Text.Replace(" ", string.Empty).Length > 0)
      driverClearance.FirstName = ((TextEditorControlBase) this.txtDriverFirst).Text;
    if (((TextEditorControlBase) this.txtDriverLast).Text.Replace(" ", string.Empty).Length > 0)
      driverClearance.LastName = ((TextEditorControlBase) this.txtDriverLast).Text;
    if (((TextEditorControlBase) this.txtDriverLicenseNumber).Text.Replace(" ", string.Empty).Length > 0)
      driverClearance.LicenseNumber = ((TextEditorControlBase) this.txtDriverLicenseNumber).Text;
    if (((TextEditorControlBase) this.txtDriverControlNo).Text.Replace(" ", string.Empty).Length > 0)
      driverClearance.ControlNo = ((TextEditorControlBase) this.txtDriverControlNo).Text;
    if (((TextEditorControlBase) this.txtDriverAddress).Text.Replace(" ", string.Empty).Length > 0)
      driverClearance.Address = ((TextEditorControlBase) this.txtDriverAddress).Text;
    if (((UltraCombo) this.cboDriverState).Text.Replace(" ", string.Empty).Length > 0)
      driverClearance.StateID = ((UltraCombo) this.cboDriverState).Value.ToString();
    if (((TextEditorControlBase) this.txtDriverZip).Text.Replace(" ", string.Empty).Length > 0)
      driverClearance.Zip = ((TextEditorControlBase) this.txtDriverZip).Text;
    driverClearance.NumResults = (int) ((UltraNumericEditor) this.numResults).Value;
    driverClearance.InforceOnly = ((UltraToggleEditorBase) this.chkDriverInforce).Checked;
    return driverClearance;
  }

  private bool IsValidAdditionalInterestSearch()
  {
    bool flag = true;
    if (((TextEditorControlBase) this.txtInsured).Text.Replace(" ", string.Empty).Length == 0 && ((TextEditorControlBase) this.txtInterestName).Text.Replace(" ", string.Empty).Length == 0 && ((TextEditorControlBase) this.txtInterest).Text.Replace(" ", string.Empty).Length == 0 && ((TextEditorControlBase) this.txtInterestFirst).Text.Replace(" ", string.Empty).Length == 0 && ((TextEditorControlBase) this.txtInterestLast).Text.Replace(" ", string.Empty).Length == 0 && ((TextEditorControlBase) this.txtInterestControlNo).Text.Replace(" ", string.Empty).Length == 0 && ((TextEditorControlBase) this.txtInterestAddress).Text.Replace(" ", string.Empty).Length == 0 && ((UltraCombo) this.cboInterestStateID).Text.Replace(" ", string.Empty).Length == 0 && ((TextEditorControlBase) this.txtInterestZip).Text.Replace(" ", string.Empty).Length == 0 && !((UltraToggleEditorBase) this.chkInterestInforce).Checked)
    {
      flag = false;
      int num = (int) MessageBox.Show("Please enter additional interest info to commence search.", "Empty Add'l Interest Search Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    if (flag && ((TextEditorControlBase) this.txtDriverControlNo).Text.Replace(" ", string.Empty).Length > 0)
    {
      int result = int.MinValue;
      if (!int.TryParse(((TextEditorControlBase) this.txtDriverControlNo).Text, out result))
      {
        flag = false;
        int num = (int) MessageBox.Show("Control # must be a numberic.", "Invalid Control #", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
    return flag;
  }

  protected virtual AdditionalInterestSearch SetAdditionalInterestFields()
  {
    AdditionalInterestSearch additionalInterestSearch = new AdditionalInterestSearch();
    if (((TextEditorControlBase) this.txtInsured).Text.Replace(" ", string.Empty).Length > 0)
      additionalInterestSearch.InsuredName = ((TextEditorControlBase) this.txtInsured).Text;
    if (((TextEditorControlBase) this.txtInterestName).Text.Replace(" ", string.Empty).Length > 0)
      additionalInterestSearch.InterestName = ((TextEditorControlBase) this.txtInterestName).Text;
    if (((TextEditorControlBase) this.txtInterestFirst).Text.Replace(" ", string.Empty).Length > 0)
      additionalInterestSearch.FirstName = ((TextEditorControlBase) this.txtInterestFirst).Text;
    if (((TextEditorControlBase) this.txtInterestLast).Text.Replace(" ", string.Empty).Length > 0)
      additionalInterestSearch.LastName = ((TextEditorControlBase) this.txtInterestLast).Text;
    if (((TextEditorControlBase) this.txtInterest).Text.Replace(" ", string.Empty).Length > 0)
      additionalInterestSearch.Interest = ((TextEditorControlBase) this.txtInterest).Text;
    if (((TextEditorControlBase) this.txtInterestControlNo).Text.Replace(" ", string.Empty).Length > 0)
      additionalInterestSearch.ControlNo = ((TextEditorControlBase) this.txtInterestControlNo).Text;
    if (((TextEditorControlBase) this.txtInterestAddress).Text.Replace(" ", string.Empty).Length > 0)
      additionalInterestSearch.Address = ((TextEditorControlBase) this.txtInterestAddress).Text;
    if (((UltraCombo) this.cboInterestStateID).Text.Replace(" ", string.Empty).Length > 0)
      additionalInterestSearch.StateID = ((UltraCombo) this.cboInterestStateID).Value.ToString();
    if (((TextEditorControlBase) this.txtInterestZip).Text.Replace(" ", string.Empty).Length > 0)
      additionalInterestSearch.Zip = ((TextEditorControlBase) this.txtInterestZip).Text;
    additionalInterestSearch.NumResults = (int) ((UltraNumericEditor) this.numResults).Value;
    additionalInterestSearch.InforceOnly = ((UltraToggleEditorBase) this.chkInterestInforce).Checked;
    return additionalInterestSearch;
  }

  private void LnkShowAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtControlNo).Text))
      return;
    int result;
    if (!int.TryParse(((TextEditorControlBase) this.txtControlNo).Text, out result))
    {
      int num1 = (int) MessageBox.Show("Invalid submission number entered.", "Invalid Submission", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      Cursor.Current = MgaCursors.WaitCursor;
      int? nullable;
      using (DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT I.InsuredID,SG.SubmissionGroupID,I.Name\tFROM tblSubmissionGroup SG\tJOIN dbo.tblInsureds I ON SG.InsuredGuid = I.InsuredGUID\tJOIN dbo.tblQuotes tq ON tq.SubmissionGroupGuid = SG.SubmissionGroupGUID\tWHERE tq.ControlNo=@ControlNumber", new object[2]
      {
        (object) "@ControlNumber",
        (object) result
      }))
      {
        if (dataTable != null & dataTable.Rows.Count > 0)
        {
          nullable = new int?(dataTable.Rows[0].Field<int>("InsuredID"));
          this.ShowAll_InsuredID = dataTable.Rows[0].Field<int>("InsuredID");
          this.ShowAll_InsuredName = dataTable.Rows[0].Field<string>("Name");
          this.SubmissionGroupID = dataTable.Rows[0].Field<int>("SubmissionGroupID");
        }
      }
      if (!nullable.HasValue)
      {
        Cursor.Current = MgaCursors.Default;
        int num2 = (int) MessageBox.Show("Submission number was not found.", "Submission Not Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        try
        {
          frmClearance frmClearance;
          if (!((UltraToggleEditorBase) this.chkOpenInNewWindow).Checked)
          {
            frmClearance = (frmClearance) MDIControls.Instance.ActivateForm(typeof (frmClearance), true);
          }
          else
          {
            frmClearance = (frmClearance) ObjectFactory.Instance.CreateForm(typeof (frmClearance));
            frmClearance.StartPosition = FormStartPosition.WindowsDefaultLocation;
            frmClearance.MdiParent = MDIControls.Instance.MDIParent;
            frmClearance.Show();
          }
          frmClearance.TabClearanceSearch = this;
          this.DoSearch();
        }
        finally
        {
          Cursor.Current = MgaCursors.Default;
        }
      }
    }
  }

  private void TxtProducerEmail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode == Keys.Escape)
    {
      if (((Control) this.lstSuggestEmail).Visible)
      {
        ((Control) this.lstSuggestEmail).Visible = false;
        this.ProdEmailLookupTimer.Stop();
      }
      else
        ((TextEditorControlBase) this.txtProducerEmail).Text = string.Empty;
    }
    else
    {
      if (((Control) this.lstSuggestEmail).Visible)
      {
        for (int index = this.lstSuggestEmail.Items.Count - 1; index >= 0; index += -1)
        {
          if (!this.lstSuggestEmail.Items[index].ToString().Contains(((TextEditorControlBase) this.txtProducerEmail).Text))
            this.lstSuggestEmail.Items.Remove(this.lstSuggestEmail.Items[index]);
        }
      }
      this.SetSuggestLstSizeProdEmail();
      if (Preferences.GetPreferenceBool("Clearance.AutoSuggest") && !this.ProdEmailLookupTimer.Enabled && ((TextEditorControlBase) this.txtProducerEmail).Text.Length >= 3)
      {
        ((Control) this).Cursor = MgaCursors.Working;
        this.ProdEmailLookupTimer.Interval = 1000;
        this.ProdEmailLookupTimer.Start();
      }
      else
      {
        if (!this.ProdEmailLookupTimer.Enabled)
          return;
        this.ProdEmailLookupTimer.Stop();
        this.ProdEmailLookupTimer.Start();
      }
    }
  }

  private void LstSuggestEmail_ItemSelectionChanged(object sender, ItemSelectionChangedEventArgs e)
  {
    ((Control) this.lstSuggestEmail).Visible = false;
    if (((DisposableObjectCollectionBase) this.lstSuggestEmail.SelectedItems).Count <= 0)
      return;
    ((TextEditorControlBase) this.txtProducerEmail).Text = ((UltraListViewItemBase) ((UltraListViewStateSpecificItemsCollectionBase) this.lstSuggestEmail.SelectedItems)[0]).Text;
  }

  private void ChkShowallInsured_CheckedChanged(object sender, EventArgs e)
  {
    Preferences.SetPreference("PREFERENCE_CLEARANCESEARCH_SHOWALLINSUREDCHECKED", ((UltraToggleEditorBase) this.chkShowallInsured).Checked);
  }

  private void CboInsuredState_ValueChanged(object sender, EventArgs e)
  {
    ((UltraCombo) this.cboInsuredCity).Value = (object) null;
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboInsuredState).Text))
      this.dvInsuredCity.RowFilter = $"State='{RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboInsuredState).Value)}'";
    else
      this.dvInsuredCity.RowFilter = string.Empty;
  }

  public enum ClearanceTabs
  {
    Insured,
    Company,
    Producer,
    Policy,
    UnderwritingLocation,
    Drivers,
    AdditionalInterest,
  }

  private delegate void GetLocationCompleteHandler();

  private delegate void GetInsuredCitiesCompleteHandler();

  private delegate void SuggestSearchCompleteHandler(DataTable dt);

  private delegate void SuggestProducerEmailSearchCompleteHandler(DataTable dt);
}

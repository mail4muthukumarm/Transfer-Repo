// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmQuoteEdit
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.AddressResolver;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.Functions;
using MGASystems.Common.NativeWindowMethods;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.IMS.InsuredsProducersCompanies;
using MGASystems.IMS.InsuredsProducersCompanies.Companies;
using MGASystems.IMS.InsuredsProducersCompanies.Companies.Intermediaries;
using MGASystems.IMS.InsuredsProducersCompanies.Producers;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.Serialization;
using MGASystems.IMS.Policies.Clearance;
using MGASystems.IMS.Policies.PolicyBusinessObjects;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Security;
using MGASystems.Tools;
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
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DocumentFolderFilter("Quote Screen")]
[Preference("QuoteEditSettings.Override.DateCreatedUseServerTime", -1)]
[Preference("QuoteEditSettings.Override.EffectiveDateUseServerTime", -1)]
[SecureResource("{2530D549-1747-4133-84D9-D6ECAE73DB37}", "Save With Closed Retailer", "Allows the user to save a policy with a closed retailer.", "Policies")]
[SecureResource("{57F1F42F-760B-43ef-A9FF-F14523944E84}", "Override Locked Carrier Commission", "Allows the user to override a locked carrier commission.", "Policies")]
[SecureResource("{B30F4951-B61B-4501-87B6-180553B30E47}", "Override Producer Max Commission", "Allows the user to override a maximum producer commission restriction.", "Policies")]
[SecureResource("{6FDE3229-A777-4a37-B2D7-EF88D357E316}", "Allows Editing of Finance Company When Policy is Bound", "Allows the user to edit Finance Company when policy is bound.", "Policies")]
[SecureResource("{191A228F-EADB-4bbd-A342-63F8B8E37B61}", "Allows Editing of Inspection Company When Policy is Bound", "Allows the user to edit Inspection Company when policy is bound.", "Policies")]
[SecureResource("{7731D90C-52BF-420f-9DB1-075B51D8D89D}", "Allows Editing of Producer Contact When Policy is Bound", "Allows the user to edit Producer Contact when policy is bound.", "Policies")]
[SecureResource("{CFC66ADA-B479-428f-9CF9-183B37725ECA}", "Allows Editing of Secondary Producer Contact When Policy is Bound", "Allows the user to edit Secondary Producer Contact when policy is bound.", "Policies")]
[SecureResource("{3FF32726-1409-4dd6-BFFB-DB6D6EA5A5A6}", "Allows Editing of Account Number When Policy is Bound", "Allows the user to edit Account Number when policy is bound.", "Policies")]
[SecureResource("{FE1BF3E0-0FEE-4fa0-BBAB-383369CDDC85}", "Allows Editing of Risk Class When Policy is Bound", "Allows the user to edit Risk Class when policy is bound.", "Policies")]
[SecureResource("{7D0C4D1D-4445-412c-9D77-43436A839F2D}", "Allows Editing of TA/CSR When Policy is Bound", "Allows the user to edit TA/CSR when policy is bound.", "Policies")]
[SecureResource("{44BD78C5-76E7-484a-9E7D-228494098679}", "Allows Editing of Expiring Policy Number When Policy is Bound", "Allows the user to edit Expiring Policy Number when policy is bound.", "Policies")]
[SecureResource("{6ecfc08a-4cc6-4185-8b1c-69f770cf5388}", "Allows Editing of Expiring Control Number", "Allows the user to edit Expiring Control.", "Policies")]
[SecureResource("{4521E064-9025-42ca-A3F3-C01C095D6760}", "Allows Editing of Previous Premium When Policy is Bound", "Allows the user to edit Previous Premium when policy is bound.", "Policies")]
[SecureResource("{1B32F6E3-7CBC-42da-A410-C6197CB9704E}", "Allows Editing of Target Premium When Policy is Bound", "Allows the user to edit Target Premium when policy is bound.", "Policies")]
[SecureResource("{4D4B36F1-8FC0-4480-B4FF-8E1B471AB47E}", "Allows Editing of Minimum Earned When Policy is Bound", "Allows the user to edit Minimum Earned when policy is bound.", "Policies")]
[SecureResource("{5C3CAE9D-AB77-4555-AC3D-54A15925303D}", "Allows Editing of Description When Policy is Bound", "Allows the user to edit Description when policy is bound.", "Policies")]
[SecureResource("{0FA0118C-D65D-49da-8330-220B26A5B652}", "Allows Selection of an Underwriter from a Different Issuing Office", "Allows the user to select an underwriter that is not part of the issuing office.", "Policies")]
[SecureResource("{A629F23B-707F-4b2d-8A47-1354E42D291F}", "Allows Update of Company / Line Contact After Policy Bound", "Allows the user to update company / line contact after policy is bound.", "Policies")]
[SecureResource("{EBFAD226-E0D7-423b-A808-207916EEE30F}", "Update Retailers", "Allows the user to update the retailer on a quote.", "Policies")]
[SecureResource("{3494008D-2F8D-45df-85F9-D1CDE496ED25}", "Update Commissions on EffectiveDate Change", "Allows the user to skip the updating of commissions on effective date change.", "Policies")]
[SecureResource("{FE9DCF65-E1BA-46c8-89B3-AD8D50C2150C}", "Allow Editing of Effective Date on Renewals", "Allows the user to change / edit policy effective dates on renewals.", "Policies")]
[SecureResource("{BA0D58C3-9159-4f16-9474-5C313C8D20F7}", "Allow Users to View Company Commissions on Policies", "Allows the user to view Company commissions.", "Policies")]
[SecureResource("{650C55A1-7C7B-4AA7-9116-D2801432324A}", "Allow Users to View Producer Commissions on Policies", "Allows the user to view Producer commissions.", "Policies")]
[SecureResource("{F3297CF1-407C-488F-821A-B2B794C130CF}", "Can Change Effective Dates on Endorsements", "Allows the user to change effective dates on endorsements.", "Policies")]
[SecureResource("{80222C62-0EB6-442C-8629-72F5672725F1}", "Override Carrier Commission Additive", "Allows the user to override carrier commmission additives", "Policies")]
[SecureResource("{D4799BEF-067F-45A8-995D-338D44734FCA}", "Allow Edit Currency Code Post Bind", "Allows editing of currency code on an unbound transaction post bind.", "Policies")]
[SecureResource("{CE7C9240-9944-4bdc-96A1-E75EB0F5EADF}", "Update Producer Comission", "Allows the user to update the producer commission on a quote.", "Policies")]
[SecureResource("{EFCE8526-D7F9-4DCE-9BEF-B7C6CE7C0C5A}", "Allow Update of Underwriter on Unbound Endorsements", "Allows the user to update an underwriter on unbound endorsements.", "Policies")]
[SecureResource("{FCF6D2E7-7F57-4D50-B249-AF92DC42840B}", "Allow Update Of Program Codes On Endorsements", "Allows users to update program code on endorsements even if system setting prohibits.", "Policies")]
[SecureResource("{c5f0b321-0570-4b5f-9b25-1f058c45ce34}", "Allow Previous Premium to be updated ON BOR and Renewal", "Allows the user to update the previous premium to be updated on BOR and Renewal policies.", "Policies")]
[SecureResource("{3E1E7811-974B-4283-808E-6DCC4192B144}", "Allow update of program codes post bind ", "Allow users to update of program codes post bind ", "Policies")]
[SecureResource("{1710472B-2938-4DCF-A61D-F75F770B1629}", "Override Max Company Commission", "Allows the user to override the maximum company commission.", "Policies")]
[SecureResource("{C6A1B712-0297-409C-B961-9EBCCC59CF6A}", "Allow Users to Assign Policy #s", "Allows the user to assign policy #s.", "Policies")]
public class frmQuoteEdit : 
  FormBase,
  ISupportNoteSystem,
  ISupportDocumentSystem,
  ISupportQuoteContacts
{
  private IContainer components;
  protected MGASimpleComboBox cboCompanies;
  protected MGASimpleComboBox cboState;
  private DbConnection cnDB;
  private DataView dvQuotingOffice;
  protected ErrorProvider err;
  private DbDataAdapter daQuoteDetails;
  private ToolTip Tip;
  private DbDataAdapter daQuotes;
  private Label Label15;
  private Label Label16;
  private MGADateTimePicker dtEndorsement;
  private MGATextBox txtEndorsementComment;
  private MGASimpleComboBox cboFinanceCompany;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  protected MGANumericEditor numMinimumEarned;
  protected UltraDropDown ddIntermediaryContacts;
  private DbCommand DbSelectCommand3;
  private DbCommand DbInsertCommand2;
  private DbCommand DbUpdateCommand2;
  private DbCommand DbDeleteCommand2;
  protected MGATextBox txtAccountNum;
  protected UltraLabel lblDisabledItems;
  protected MGATextBox txtRiskDescription;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  protected Label lblRiskDescription;
  protected bool ClientPolicyTypeShowComnPopup;
  internal const string AllowSaveWithClosedRetailer = "{2530D549-1747-4133-84D9-D6ECAE73DB37}";
  internal const string OverrideLockedCarrierCommission = "{57F1F42F-760B-43ef-A9FF-F14523944E84}";
  internal const string OverrideMaxProducerCommission = "{B30F4951-B61B-4501-87B6-180553B30E47}";
  internal const string AllowToUpdateRetailer = "{EBFAD226-E0D7-423b-A808-207916EEE30F}";
  internal const string AllowUpdateProducerCommission = "{CE7C9240-9944-4bdc-96A1-E75EB0F5EADF}";
  internal const string CanEditFinanceCompany = "{6FDE3229-A777-4a37-B2D7-EF88D357E316}";
  internal const string CanEditInspectionCompany = "{191A228F-EADB-4bbd-A342-63F8B8E37B61}";
  internal const string CanEditProducerContact = "{7731D90C-52BF-420f-9DB1-075B51D8D89D}";
  internal const string CanEditSecProducerContact = "{CFC66ADA-B479-428f-9CF9-183B37725ECA}";
  internal const string CanEditAccountNum = "{3FF32726-1409-4dd6-BFFB-DB6D6EA5A5A6}";
  internal const string CanEditRiskClass = "{FE1BF3E0-0FEE-4fa0-BBAB-383369CDDC85}";
  internal const string CanEditTA = "{7D0C4D1D-4445-412c-9D77-43436A839F2D}";
  internal const string CanEditExpPolicyNum = "{44BD78C5-76E7-484a-9E7D-228494098679}";
  internal const string CanEditExpControlNum = "{6ecfc08a-4cc6-4185-8b1c-69f770cf5388}";
  internal const string CanEditPreviousPremium = "{4521E064-9025-42ca-A3F3-C01C095D6760}";
  internal const string CanEditTargetPremium = "{1B32F6E3-7CBC-42da-A410-C6197CB9704E}";
  internal const string CanEditMinimumEarned = "{4D4B36F1-8FC0-4480-B4FF-8E1B471AB47E}";
  internal const string CanEditDescription = "{5C3CAE9D-AB77-4555-AC3D-54A15925303D}";
  public const string CanSelectUnderFromDifferentOffice = "{0FA0118C-D65D-49da-8330-220B26A5B652}";
  public const string CanUpdateCompanyLineContactsAfterPolicyBound = "{A629F23B-707F-4b2d-8A47-1354E42D291F}";
  public const string CanSkipUpdateCommissionsOnEffectiveDateChange = "{3494008D-2F8D-45df-85F9-D1CDE496ED25}";
  internal const string AllowPolicyEffectiveDateChangeOnRenewals = "{FE9DCF65-E1BA-46c8-89B3-AD8D50C2150C}";
  public const string AllowViewingOfCommissions = "{BA0D58C3-9159-4f16-9474-5C313C8D20F7}";
  public const string CanChangeEffectiveDateOnEndorsements = "{F3297CF1-407C-488F-821A-B2B794C130CF}";
  public const string OverrideCommissionAdditive = "{80222C62-0EB6-442C-8629-72F5672725F1}";
  public const string AllowViewingOfProducerCommissions = "{650C55A1-7C7B-4AA7-9116-D2801432324A}";
  public const string CanEditCurrencyCodePostBind = "{D4799BEF-067F-45A8-995D-338D44734FCA}";
  public const string AllowUpdatePreviousPremium = "{c5f0b321-0570-4b5f-9b25-1f058c45ce34}";
  public const string AllowUpdateProgramCodes = "{3E1E7811-974B-4283-808E-6DCC4192B144}";
  public const string CanUpdateUnderwriterOnUnboundEndorsements = "{EFCE8526-D7F9-4DCE-9BEF-B7C6CE7C0C5A}";
  public const string AllowEditingProgramCodesOnEndorsements = "{FCF6D2E7-7F57-4D50-B249-AF92DC42840B}";
  public const string OverrideMaxCompanyCommission = "{1710472B-2938-4DCF-A61D-F75F770B1629}";
  public const string AllowPolicyNumbersAssignment = "{C6A1B712-0297-409C-B961-9EBCCC59CF6A}";
  private Quote _quote;
  protected readonly SubmissionGroup _submission;
  private const int renewalTypeID = 2;
  private bool _dateCreatedUseServerTime;
  private bool _effectiveDateUseServerTime;
  private Guid _quoteGuid;
  private Guid _producerLocationGuid;
  private bool _isNewQuote;
  private Guid _submissionGroupGuid;
  protected bool _readyToShowParticipants;
  private Guid _defaultUnderwriterGuid;
  private Guid _defaultTAGuid;
  private bool _isQuickQuote;
  private Guid _originalCompanyLocationGuid;
  private Dictionary<Guid, CompanyLine> _companyLineObjectCache;
  private bool _isConvertToFullQuote;
  private bool _isFullQuoteLinkPressed;
  private bool _ignoreCommissionsUpdateOnEffectiveDateChanged;
  private Guid _underWriterAssistantGuid;
  private Guid _underWriterGuid;
  private DateTime _effectiveDate;
  private Guid _currentProducerContactGuid;
  private int _maxControlNo;
  private Guid _issuingOfficeGuid;
  private bool _allowClearance;
  private bool _allowLapseInRenewalPolicyTerms;
  private string _originalCompany;
  private bool _producerCommissionCellChanged;
  protected int _ProgramID;
  private Guid _currentCompanyLineGuid;
  private Guid _currentQuotingOfficeGuid;
  private bool _ignoreDuplicateProgramCodes;
  private bool _autoSelectProgramCode;
  private int _originalPolicyTypeId;
  private string _originalStateID;
  private bool _resetMinEarnedOnCarrierChange;
  private bool _canChangeEffectiveDateOnEffectiveDate;
  protected bool _isBound;
  private bool _isRated;
  private bool _isEndorsement;
  private bool _hasIssuedQuoteDetailDeletes;
  private bool _hasUpdatedFinanceCompanyByDefault;
  private bool _validateProducerLicenseOnQuoteCreation;
  private Dictionary<string, Guid> _financeCompanyLine;
  protected bool _canSelectAllUsers;
  protected object _issuingOffice;
  private bool _setBillingTypeOnEdits;
  private bool _OverrideCommissionAdditive;
  private bool _isImsRewrite;
  private bool _companyCommissionCellChanged;
  private bool _replicateQuote;
  private Guid _replicateQuoteGuid;
  private int _OrigExpiringcontrolno;
  private bool _programCodeCellChanged;
  protected string _SpNameForClients;
  private Guid _currentUserGuid;
  private bool _useCurrentUserAsDefaultUnderwriter;
  private bool _isMultiCurrencyActive;
  private string _objOriginalAuditable;
  private bool _showSlaNumber;
  private bool _canUpdateUnderwriterOnUnboundEndorsements;
  private object _renewalQuoteGuid;
  private DataTable _lineGroupTable;
  private bool _quoteEditIgnoreCommissionsUpdateOnProgramCodeChange;
  private bool _savingData;
  private bool _lockDownProgramCodeWhenBound;
  private bool _AllowUpdateProgramCodes;
  private bool _UseEffectiveDateForPolicyParticipants;
  private bool _lockDownProgramCodeOnEndorsements;
  private bool _allowEditingProgramCodesOnEndorsements;
  private static object _promptedForRenewalSequence;
  private bool _onSavingkeepSequenceOnCompanyChange;
  private bool _promptResetPolicyNumber;
  private Guid _originalLineGuid;
  private bool _IgnoreCostCenterDefaultUpdate;
  private bool _costCenterCheckOnCompanyLineChanged;
  private bool _canOverrideMaxCompanyComm;
  private bool _validateMaxCompanyCommission;
  private readonly Dictionary<Guid, Decimal> _companyCommissionsCache;
  private bool _usingSettlementCurrency;
  private readonly Dictionary<Guid, bool> _detailCompanyLine;
  private bool _enforceUniqueChildPolicyNumbers;
  private bool _showRetailerContact;
  private bool _useIssuingOfficeForProducerLines;
  private string _getQuoteEditCompanyLocationsProcName;
  private bool _keepRenewalSequenceAfterPrompt;
  private bool _includeProgCodeOnMaxProdComm;
  private static dsQuoteEdit.lstSIC_CodesDataTable _sicCodeCache;
  private static dsQuoteEdit.ExpiringCarriersDataTable _expiringCarrierCache;
  private static dsQuoteEdit.lstNAICSCodesDataTable _naicsCodeCache;
  private static object _syncLockExpiringCarrierObject = RuntimeHelpers.GetObjectValue(new object());
  private bool _modifiedEffectiveDate;
  private Dictionary<Guid, dsQuoteEdit.tblIntermediaryContactsDataTable> _intermediaryContacts;
  private Guid _lastBillingCompanyLineGuid;

  protected virtual MGASimpleComboBox cboIssuingOffice
  {
    get => this._cboIssuingOffice;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CboIssuingOffice_ValueChanged);
      MGASimpleComboBox cboIssuingOffice1 = this._cboIssuingOffice;
      if (cboIssuingOffice1 != null)
        ((UltraCombo) cboIssuingOffice1).ValueChanged -= eventHandler;
      this._cboIssuingOffice = value;
      MGASimpleComboBox cboIssuingOffice2 = this._cboIssuingOffice;
      if (cboIssuingOffice2 == null)
        return;
      ((UltraCombo) cboIssuingOffice2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cboProducerContact")]
  protected virtual MGASimpleComboBox cboProducerContact { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboBillingTypes")]
  protected virtual MGASimpleComboBox cboBillingTypes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual FixedUltraGrid ugPolicyDetail
  {
    get => this._ugPolicyDetail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      BeforeCellUpdateEventHandler updateEventHandler = new BeforeCellUpdateEventHandler(this.ugPolicyDetail_BeforeCellUpdate);
      EventHandler eventHandler = new EventHandler(this.ugPolicyDetail_AfterExitEditMode);
      CellEventHandler cellEventHandler1 = new CellEventHandler(this.UgPolicyDetail_CellChange);
      CellEventHandler cellEventHandler2 = new CellEventHandler(this.UgPolicyDetail_AfterCellUpdate);
      FixedUltraGrid ugPolicyDetail1 = this._ugPolicyDetail;
      if (ugPolicyDetail1 != null)
      {
        ugPolicyDetail1.BeforeCellUpdate -= updateEventHandler;
        ugPolicyDetail1.AfterExitEditMode -= eventHandler;
        ugPolicyDetail1.CellChange -= cellEventHandler1;
        ugPolicyDetail1.AfterCellUpdate -= cellEventHandler2;
      }
      this._ugPolicyDetail = value;
      FixedUltraGrid ugPolicyDetail2 = this._ugPolicyDetail;
      if (ugPolicyDetail2 == null)
        return;
      ugPolicyDetail2.BeforeCellUpdate += updateEventHandler;
      ugPolicyDetail2.AfterExitEditMode += eventHandler;
      ugPolicyDetail2.CellChange += cellEventHandler1;
      ugPolicyDetail2.AfterCellUpdate += cellEventHandler2;
    }
  }

  protected virtual UltraDropDown ddCompanyContacts
  {
    get => this._ddCompanyContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.DdCompanyContacts_BeforeDropDown);
      DropDownEventHandler downEventHandler = new DropDownEventHandler(this.DdCompanyContacts_AfterCloseUp);
      UltraDropDown ddCompanyContacts1 = this._ddCompanyContacts;
      if (ddCompanyContacts1 != null)
      {
        ddCompanyContacts1.BeforeDropDown -= cancelEventHandler;
        ddCompanyContacts1.AfterCloseUp -= downEventHandler;
      }
      this._ddCompanyContacts = value;
      UltraDropDown ddCompanyContacts2 = this._ddCompanyContacts;
      if (ddCompanyContacts2 == null)
        return;
      ddCompanyContacts2.BeforeDropDown += cancelEventHandler;
      ddCompanyContacts2.AfterCloseUp += downEventHandler;
    }
  }

  protected virtual MGAButton btnNext
  {
    get => this._btnNext;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BtnNext_Click);
      MGAButton btnNext1 = this._btnNext;
      if (btnNext1 != null)
        ((Control) btnNext1).Click -= eventHandler;
      this._btnNext = value;
      MGAButton btnNext2 = this._btnNext;
      if (btnNext2 == null)
        return;
      ((Control) btnNext2).Click += eventHandler;
    }
  }

  private virtual LinkLabel lnkUpdateRetailer
  {
    get => this._lnkUpdateRetailer;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkUpdateRetailer_LinkClicked);
      LinkLabel lnkUpdateRetailer1 = this._lnkUpdateRetailer;
      if (lnkUpdateRetailer1 != null)
        lnkUpdateRetailer1.LinkClicked -= clickedEventHandler;
      this._lnkUpdateRetailer = value;
      LinkLabel lnkUpdateRetailer2 = this._lnkUpdateRetailer;
      if (lnkUpdateRetailer2 == null)
        return;
      lnkUpdateRetailer2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkRemoveRetailer
  {
    get => this._lnkRemoveRetailer;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkRemoveRetailer_LinkClicked);
      LinkLabel lnkRemoveRetailer1 = this._lnkRemoveRetailer;
      if (lnkRemoveRetailer1 != null)
        lnkRemoveRetailer1.LinkClicked -= clickedEventHandler;
      this._lnkRemoveRetailer = value;
      LinkLabel lnkRemoveRetailer2 = this._lnkRemoveRetailer;
      if (lnkRemoveRetailer2 == null)
        return;
      lnkRemoveRetailer2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("tabOtherInfo")]
  protected virtual UltraTabPageControl tabOtherInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabEndorsement")]
  protected virtual UltraTabPageControl tabEndorsement { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabPolicyInfo")]
  protected virtual UltraTabControl tabPolicyInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboInspectionCompanies")]
  protected virtual MGASimpleComboBox cboInspectionCompanies { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkConvertQuickQuote
  {
    get => this._lnkConvertQuickQuote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkConvertQuickQuote_LinkClicked);
      LinkLabel convertQuickQuote1 = this._lnkConvertQuickQuote;
      if (convertQuickQuote1 != null)
        convertQuickQuote1.LinkClicked -= clickedEventHandler;
      this._lnkConvertQuickQuote = value;
      LinkLabel convertQuickQuote2 = this._lnkConvertQuickQuote;
      if (convertQuickQuote2 == null)
        return;
      convertQuickQuote2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual MGADateTimePicker dtExpirationDate
  {
    get => this._dtExpirationDate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DtEffectiveDate_Enter);
      MGADateTimePicker dtExpirationDate1 = this._dtExpirationDate;
      if (dtExpirationDate1 != null)
        ((Control) dtExpirationDate1).Enter -= eventHandler;
      this._dtExpirationDate = value;
      MGADateTimePicker dtExpirationDate2 = this._dtExpirationDate;
      if (dtExpirationDate2 == null)
        return;
      ((Control) dtExpirationDate2).Enter += eventHandler;
    }
  }

  protected virtual MGADateTimePicker dtEffectiveDate
  {
    get => this._dtEffectiveDate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.DtEffectiveDate_AfterExitEditMode);
      EventHandler eventHandler2 = new EventHandler(this.DtEffectiveDate_Enter);
      EventHandler eventHandler3 = new EventHandler(this.dtEffectiveDate_ValueChanged);
      MGADateTimePicker dtEffectiveDate1 = this._dtEffectiveDate;
      if (dtEffectiveDate1 != null)
      {
        ((UltraDateTimeEditor) dtEffectiveDate1).AfterExitEditMode -= eventHandler1;
        ((Control) dtEffectiveDate1).Enter -= eventHandler2;
        ((UltraDateTimeEditor) dtEffectiveDate1).ValueChanged -= eventHandler3;
      }
      this._dtEffectiveDate = value;
      MGADateTimePicker dtEffectiveDate2 = this._dtEffectiveDate;
      if (dtEffectiveDate2 == null)
        return;
      ((UltraDateTimeEditor) dtEffectiveDate2).AfterExitEditMode += eventHandler1;
      ((Control) dtEffectiveDate2).Enter += eventHandler2;
      ((UltraDateTimeEditor) dtEffectiveDate2).ValueChanged += eventHandler3;
    }
  }

  protected virtual UltraLabel lblRetailer
  {
    get => this._lblRetailer;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.LblRetailer_MouseHover);
      UltraLabel lblRetailer1 = this._lblRetailer;
      if (lblRetailer1 != null)
        ((Control) lblRetailer1).MouseHover -= eventHandler;
      this._lblRetailer = value;
      UltraLabel lblRetailer2 = this._lblRetailer;
      if (lblRetailer2 == null)
        return;
      ((Control) lblRetailer2).MouseHover += eventHandler;
    }
  }

  private virtual LinkLabel lnkAddModifyProducerContacts
  {
    get => this._lnkAddModifyProducerContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkAddModifyProducerContacts_LinkClicked);
      LinkLabel producerContacts1 = this._lnkAddModifyProducerContacts;
      if (producerContacts1 != null)
        producerContacts1.LinkClicked -= clickedEventHandler;
      this._lnkAddModifyProducerContacts = value;
      LinkLabel producerContacts2 = this._lnkAddModifyProducerContacts;
      if (producerContacts2 == null)
        return;
      producerContacts2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkNewCompanyContact
  {
    get => this._lnkNewCompanyContact;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkNewCompanyContact_LinkClicked);
      LinkLabel newCompanyContact1 = this._lnkNewCompanyContact;
      if (newCompanyContact1 != null)
        newCompanyContact1.LinkClicked -= clickedEventHandler;
      this._lnkNewCompanyContact = value;
      LinkLabel newCompanyContact2 = this._lnkNewCompanyContact;
      if (newCompanyContact2 == null)
        return;
      newCompanyContact2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("numPreviousPremium")]
  protected virtual MGANumericEditor numPreviousPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numTargetPremium")]
  protected virtual MGANumericEditor numTargetPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabPremiumInfo")]
  protected virtual UltraTabPageControl tabPremiumInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtExpiringPolicyNumber")]
  protected virtual MGATextBox txtExpiringPolicyNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASimpleComboBox cboPolicyType
  {
    get => this._cboPolicyType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CboPolicyType_ValueChanged);
      MGASimpleComboBox cboPolicyType1 = this._cboPolicyType;
      if (cboPolicyType1 != null)
        ((UltraCombo) cboPolicyType1).ValueChanged -= eventHandler;
      this._cboPolicyType = value;
      MGASimpleComboBox cboPolicyType2 = this._cboPolicyType;
      if (cboPolicyType2 == null)
        return;
      ((UltraCombo) cboPolicyType2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cboUnderwriter")]
  protected virtual MGASimpleComboBox cboUnderwriter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASimpleComboBox cboQuotingOffice
  {
    get => this._cboQuotingOffice;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CboQuotingOffice_ValueChanged);
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.CboQuotingOffice_RowSelected);
      MGASimpleComboBox cboQuotingOffice1 = this._cboQuotingOffice;
      if (cboQuotingOffice1 != null)
      {
        ((UltraCombo) cboQuotingOffice1).ValueChanged -= eventHandler;
        ((UltraCombo) cboQuotingOffice1).RowSelected -= selectedEventHandler;
      }
      this._cboQuotingOffice = value;
      MGASimpleComboBox cboQuotingOffice2 = this._cboQuotingOffice;
      if (cboQuotingOffice2 == null)
        return;
      ((UltraCombo) cboQuotingOffice2).ValueChanged += eventHandler;
      ((UltraCombo) cboQuotingOffice2).RowSelected += selectedEventHandler;
    }
  }

  protected virtual MGASimpleComboBox cboLine
  {
    get => this._cboLine;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboLine_TextChanged);
      MGASimpleComboBox cboLine1 = this._cboLine;
      if (cboLine1 != null)
        ((Control) cboLine1).TextChanged -= eventHandler;
      this._cboLine = value;
      MGASimpleComboBox cboLine2 = this._cboLine;
      if (cboLine2 == null)
        return;
      ((Control) cboLine2).TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cboTA")]
  protected virtual MGASimpleComboBox cboTA { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTA")]
  protected virtual Label lblTA { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabRequiredInfo")]
  protected virtual UltraTabPageControl tabRequiredInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dsQuoteEdit")]
  protected virtual dsQuoteEdit dsQuoteEdit { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboUnderwritingAssistant")]
  protected virtual MGASimpleComboBox cboUnderwritingAssistant { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAComboBox cboRiskClass
  {
    get => this._cboRiskClass;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.CboRiskClass_ValueChanged);
      EventHandler eventHandler2 = new EventHandler(this.CboRiskClass_AfterCloseUp);
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.CboRiskClass_BeforeDropDown);
      KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CboRiskClass_KeyPress);
      MGAComboBox cboRiskClass1 = this._cboRiskClass;
      if (cboRiskClass1 != null)
      {
        ((UltraCombo) cboRiskClass1).ValueChanged -= eventHandler1;
        ((UltraCombo) cboRiskClass1).AfterCloseUp -= eventHandler2;
        ((UltraCombo) cboRiskClass1).BeforeDropDown -= cancelEventHandler;
        ((Control) cboRiskClass1).KeyPress -= pressEventHandler;
      }
      this._cboRiskClass = value;
      MGAComboBox cboRiskClass2 = this._cboRiskClass;
      if (cboRiskClass2 == null)
        return;
      ((UltraCombo) cboRiskClass2).ValueChanged += eventHandler1;
      ((UltraCombo) cboRiskClass2).AfterCloseUp += eventHandler2;
      ((UltraCombo) cboRiskClass2).BeforeDropDown += cancelEventHandler;
      ((Control) cboRiskClass2).KeyPress += pressEventHandler;
    }
  }

  [field: AccessedThroughProperty("cboEarnedPremiumType")]
  protected virtual MGASimpleComboBox cboEarnedPremiumType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("optionAuditable")]
  protected virtual UltraOptionSet optionAuditable { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  protected virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label27")]
  protected virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  protected virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASimpleComboBox comboExpiringCarrier
  {
    get => this._comboExpiringCarrier;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ComboExpiringCarrier_ValueChanged);
      MGASimpleComboBox comboExpiringCarrier1 = this._comboExpiringCarrier;
      if (comboExpiringCarrier1 != null)
        ((UltraCombo) comboExpiringCarrier1).ValueChanged -= eventHandler;
      this._comboExpiringCarrier = value;
      MGASimpleComboBox comboExpiringCarrier2 = this._comboExpiringCarrier;
      if (comboExpiringCarrier2 == null)
        return;
      ((UltraCombo) comboExpiringCarrier2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkNonRenewed")]
  protected virtual MGACheckBox chkNonRenewed { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkCommentsByLine
  {
    get => this._lnkCommentsByLine;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkCommentsByLine_LinkClicked);
      LinkLabel lnkCommentsByLine1 = this._lnkCommentsByLine;
      if (lnkCommentsByLine1 != null)
        lnkCommentsByLine1.LinkClicked -= clickedEventHandler;
      this._lnkCommentsByLine = value;
      LinkLabel lnkCommentsByLine2 = this._lnkCommentsByLine;
      if (lnkCommentsByLine2 == null)
        return;
      lnkCommentsByLine2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("numMinCancellationDays")]
  protected virtual MGANumericEditor numMinCancellationDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboSecProducerContact")]
  protected virtual MGASimpleComboBox cboSecProducerContact { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboCurrencyCode")]
  protected virtual MGASimpleComboBox comboCurrencyCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tmpToolTip")]
  private virtual ToolTip tmpToolTip { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblProgramCode")]
  protected virtual Label lblProgramCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label29")]
  protected virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraDropDown ddProgramCodes
  {
    get => this._ddProgramCodes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.DdProgramCodes_BeforeDropDown);
      UltraDropDown ddProgramCodes1 = this._ddProgramCodes;
      if (ddProgramCodes1 != null)
        ddProgramCodes1.BeforeDropDown -= cancelEventHandler;
      this._ddProgramCodes = value;
      UltraDropDown ddProgramCodes2 = this._ddProgramCodes;
      if (ddProgramCodes2 == null)
        return;
      ddProgramCodes2.BeforeDropDown += cancelEventHandler;
    }
  }

  protected virtual MGAComboBox cboNAICSCode
  {
    get => this._cboNAICSCode;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CboNAICSCode_ValueChanged);
      MGAComboBox cboNaicsCode1 = this._cboNAICSCode;
      if (cboNaicsCode1 != null)
        ((UltraCombo) cboNaicsCode1).ValueChanged -= eventHandler;
      this._cboNAICSCode = value;
      MGAComboBox cboNaicsCode2 = this._cboNAICSCode;
      if (cboNaicsCode2 == null)
        return;
      ((UltraCombo) cboNaicsCode2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dvNAICS")]
  protected virtual DataView dvNAICS { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvSIC")]
  protected virtual DataView dvSIC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkAddCarrier
  {
    get => this._lnkAddCarrier;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkAddCarrier_LinkClicked);
      LinkLabel lnkAddCarrier1 = this._lnkAddCarrier;
      if (lnkAddCarrier1 != null)
        lnkAddCarrier1.LinkClicked -= clickedEventHandler;
      this._lnkAddCarrier = value;
      LinkLabel lnkAddCarrier2 = this._lnkAddCarrier;
      if (lnkAddCarrier2 == null)
        return;
      lnkAddCarrier2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("numExchangeRate")]
  protected virtual MGANumericEditor numExchangeRate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkFacultative")]
  protected virtual MGACheckBox chkFacultative { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label31")]
  internal virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dateNeededBy")]
  protected internal virtual MGADateTimePicker dateNeededBy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gbPleaseWait")]
  protected virtual UltraGroupBox gbPleaseWait { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("BouncingProgress1")]
  protected virtual BouncingProgress BouncingProgress1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  protected virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numMinimumEarnedAmount")]
  protected virtual MGANumericEditor numMinimumEarnedAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMinEarnedAmount")]
  protected virtual Label lblMinEarnedAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtExpiringControlNumber")]
  protected virtual MGANumericEditor txtExpiringControlNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkRefreshChildPolicyNumbering
  {
    get => this._lnkRefreshChildPolicyNumbering;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkRefreshChildPolicyNumbering_LinkClicked);
      LinkLabel childPolicyNumbering1 = this._lnkRefreshChildPolicyNumbering;
      if (childPolicyNumbering1 != null)
        childPolicyNumbering1.LinkClicked -= clickedEventHandler;
      this._lnkRefreshChildPolicyNumbering = value;
      LinkLabel childPolicyNumbering2 = this._lnkRefreshChildPolicyNumbering;
      if (childPolicyNumbering2 == null)
        return;
      childPolicyNumbering2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkOpenExpiring
  {
    get => this._lnkOpenExpiring;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkOpenExpiring_LinkClicked);
      LinkLabel lnkOpenExpiring1 = this._lnkOpenExpiring;
      if (lnkOpenExpiring1 != null)
        lnkOpenExpiring1.LinkClicked -= clickedEventHandler;
      this._lnkOpenExpiring = value;
      LinkLabel lnkOpenExpiring2 = this._lnkOpenExpiring;
      if (lnkOpenExpiring2 == null)
        return;
      lnkOpenExpiring2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblExchangeRate")]
  protected virtual Label lblExchangeRate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblFacultativePercentage")]
  protected internal virtual Label lblFacultativePercentage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numFacultativePercentage")]
  protected virtual MGANumericEditor numFacultativePercentage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabKYTaxLocation")]
  internal virtual UltraTabPageControl tabKYTaxLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkSIC
  {
    get => this._lnkSIC;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkSIC_LinkClicked);
      LinkLabel lnkSic1 = this._lnkSIC;
      if (lnkSic1 != null)
        lnkSic1.LinkClicked -= clickedEventHandler;
      this._lnkSIC = value;
      LinkLabel lnkSic2 = this._lnkSIC;
      if (lnkSic2 == null)
        return;
      lnkSic2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label21")]
  protected virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ctlKYTaxLocation")]
  protected virtual AddressResolver_MULTI ctlKYTaxLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboSettlementCurrency")]
  protected virtual MGASimpleComboBox cboSettlementCurrency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblSettlementCurrency")]
  protected virtual Label lblSettlementCurrency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label32")]
  protected virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboRetailerContact")]
  protected virtual MGASimpleComboBox cboRetailerContact { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblRetailerContact")]
  protected virtual Label lblRetailerContact { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstNAICSCodes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("NAICSCode");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("NAICSDescription");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("SICCode");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("SICDescription");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstSIC_Codes", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("SIC_Code");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("SIC_Description");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("SIC_Family_Description");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("lstSIC_CodestblQuotes");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstSIC_CodestblQuotes", 0);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ControlGuid");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("UnderwriterUserGuid");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("QuotingLocationGuid");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("IssuingLocationGuid");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ProducerContactGuid");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("PolicyTypeID");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("DateCreated");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("SubmissionGroupGuid");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("SIC_Code");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("BillingTypeID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("TermsOfPayment");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("TACSRUserGuid");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("EndorsementEffective");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("EndorsementComment");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("FinanceCompanyGuid");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("Retailer");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("RetailerGuid");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("MinimumEarnedPercentage");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("AccountNumber");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("CostCenterID");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("InspectionCompanyID");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("QuickQuote");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("PreviousPremium");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("TargetPremium");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("ExpiringPolicyNumber");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("RiskDescription");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("UnderwritingAssistantGuid");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("ProducerLocationID");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("SecProducerContactGuid");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("EarnedPremiumTypeID");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("Auditable");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("NAICSCode");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("RenewalofControlNum");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("RenewalofQuoteGUID");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("tblQuotestblQuoteDetails");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblQuotestblQuoteDetails", 1);
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("CompanyContactGuid");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("IntermediaryContactGuid");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("CompanyCommission");
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("ProducerCommission");
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("Participation");
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("TermsOfPayment");
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("UsingAdditiveCommission");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("CompanyLine");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("ProgramID");
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("SLA_Number");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmQuoteEdit));
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance34 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance35 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance36 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance37 = new Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Appearance appearance38 = new Appearance();
    UltraTab ultraTab6 = new UltraTab();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("tblCompanyProgramCodes", -1);
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("CompanyLocationGUID");
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("ContractEffective");
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("ContractExpiration");
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("IssuingOfficeGUID");
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("ProgCode");
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("ProgramID");
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("GroupCode");
    UltraGridColumn ultraGridColumn72 = new UltraGridColumn("ParentLineGUID");
    Appearance appearance41 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("tblIntermediaryContacts", -1);
    UltraGridColumn ultraGridColumn73 = new UltraGridColumn("IntermediaryContactGuid");
    UltraGridColumn ultraGridColumn74 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn75 = new UltraGridColumn("CompanyLocationGuid");
    Appearance appearance42 = new Appearance();
    UltraGridBand ultraGridBand7 = new UltraGridBand("tblCompanyContacts", -1);
    UltraGridColumn ultraGridColumn76 = new UltraGridColumn("CompanyContactGuid");
    UltraGridColumn ultraGridColumn77 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn78 = new UltraGridColumn("CompanyLocationGuid");
    Appearance appearance43 = new Appearance();
    UltraGridBand ultraGridBand8 = new UltraGridBand("tblQuoteDetails", -1);
    UltraGridColumn ultraGridColumn79 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn80 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn81 = new UltraGridColumn("CompanyContactGuid", -1, (object) "ddCompanyContacts");
    UltraGridColumn ultraGridColumn82 = new UltraGridColumn("IntermediaryContactGuid", -1, (object) "ddIntermediaryContacts");
    UltraGridColumn ultraGridColumn83 = new UltraGridColumn("CompanyCommission");
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    UltraGridColumn ultraGridColumn84 = new UltraGridColumn("ProducerCommission");
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    UltraGridColumn ultraGridColumn85 = new UltraGridColumn("Participation");
    UltraGridColumn ultraGridColumn86 = new UltraGridColumn("TermsOfPayment");
    UltraGridColumn ultraGridColumn87 = new UltraGridColumn("UsingAdditiveCommission");
    UltraGridColumn ultraGridColumn88 = new UltraGridColumn("CompanyLine");
    UltraGridColumn ultraGridColumn89 = new UltraGridColumn("ProgramID", -1, (object) "ddProgramCodes");
    UltraGridColumn ultraGridColumn90 = new UltraGridColumn("SLA_Number");
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    this.tabRequiredInfo = new UltraTabPageControl();
    this.cboSettlementCurrency = new MGASimpleComboBox();
    this.dvQuotingOffice = new DataView();
    this.dsQuoteEdit = new dsQuoteEdit();
    this.lblSettlementCurrency = new Label();
    this.lnkRefreshChildPolicyNumbering = new LinkLabel();
    this.comboCurrencyCode = new MGASimpleComboBox();
    this.lnkNewCompanyContact = new LinkLabel();
    this.dtExpirationDate = new MGADateTimePicker();
    this.dtEffectiveDate = new MGADateTimePicker();
    this.cboCompanies = new MGASimpleComboBox();
    this.Label11 = new Label();
    this.cboIssuingOffice = new MGASimpleComboBox();
    this.cboQuotingOffice = new MGASimpleComboBox();
    this.cboState = new MGASimpleComboBox();
    this.cboUnderwriter = new MGASimpleComboBox();
    this.cboLine = new MGASimpleComboBox();
    this.cboBillingTypes = new MGASimpleComboBox();
    this.cboPolicyType = new MGASimpleComboBox();
    this.tabOtherInfo = new UltraTabPageControl();
    this.cboRetailerContact = new MGASimpleComboBox();
    this.lnkSIC = new LinkLabel();
    this.cboNAICSCode = new MGAComboBox();
    this.dvNAICS = new DataView();
    this.Label29 = new Label();
    this.lblProgramCode = new Label();
    this.cboSecProducerContact = new MGASimpleComboBox();
    this.Label27 = new Label();
    this.cboUnderwritingAssistant = new MGASimpleComboBox();
    this.lnkAddModifyProducerContacts = new LinkLabel();
    this.lblRetailer = new UltraLabel();
    this.cboInspectionCompanies = new MGASimpleComboBox();
    this.lnkUpdateRetailer = new LinkLabel();
    this.cboFinanceCompany = new MGASimpleComboBox();
    this.lnkRemoveRetailer = new LinkLabel();
    this.cboProducerContact = new MGASimpleComboBox();
    this.cboRiskClass = new MGAComboBox();
    this.dvSIC = new DataView();
    this.cboTA = new MGASimpleComboBox();
    this.lblTA = new Label();
    this.txtAccountNum = new MGATextBox();
    this.tabPremiumInfo = new UltraTabPageControl();
    this.lblFacultativePercentage = new Label();
    this.numFacultativePercentage = new MGANumericEditor();
    this.lblMinEarnedAmount = new Label();
    this.numMinimumEarnedAmount = new MGANumericEditor();
    this.Label31 = new Label();
    this.dateNeededBy = new MGADateTimePicker();
    this.lblExchangeRate = new Label();
    this.numExchangeRate = new MGANumericEditor();
    this.gbPleaseWait = new UltraGroupBox();
    this.BouncingProgress1 = new BouncingProgress();
    this.Label5 = new Label();
    this.chkFacultative = new MGACheckBox();
    this.numMinCancellationDays = new MGANumericEditor();
    this.lnkCommentsByLine = new LinkLabel();
    this.optionAuditable = new UltraOptionSet();
    this.lblRiskDescription = new Label();
    this.txtRiskDescription = new MGATextBox();
    this.numPreviousPremium = new MGANumericEditor();
    this.Label21 = new Label();
    this.numTargetPremium = new MGANumericEditor();
    this.numMinimumEarned = new MGANumericEditor();
    this.cboEarnedPremiumType = new MGASimpleComboBox();
    this.tabEndorsement = new UltraTabPageControl();
    this.txtEndorsementComment = new MGATextBox();
    this.dtEndorsement = new MGADateTimePicker();
    this.Label16 = new Label();
    this.Label15 = new Label();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.lnkOpenExpiring = new LinkLabel();
    this.txtExpiringControlNumber = new MGANumericEditor();
    this.lnkAddCarrier = new LinkLabel();
    this.chkNonRenewed = new MGACheckBox();
    this.comboExpiringCarrier = new MGASimpleComboBox();
    this.txtExpiringPolicyNumber = new MGATextBox();
    this.tabKYTaxLocation = new UltraTabPageControl();
    this.ctlKYTaxLocation = new AddressResolver_MULTI();
    this.btnNext = new MGAButton();
    this.cnDB = DefaultDatabase.CreateDbConnection();
    this.err = new ErrorProvider(this.components);
    this.daQuoteDetails = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand2 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand2 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand3 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand2 = DefaultDatabase.CreateCommand();
    this.Tip = new ToolTip(this.components);
    this.daQuotes = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.tabPolicyInfo = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.lnkConvertQuickQuote = new LinkLabel();
    this.lblDisabledItems = new UltraLabel();
    this.tmpToolTip = new ToolTip(this.components);
    this.ddProgramCodes = new UltraDropDown();
    this.ddIntermediaryContacts = new UltraDropDown();
    this.ddCompanyContacts = new UltraDropDown();
    this.ugPolicyDetail = new FixedUltraGrid();
    this.Label32 = new Label();
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    Label label4 = new Label();
    Label label5 = new Label();
    Label label6 = new Label();
    Label label7 = new Label();
    Label label8 = new Label();
    Label label9 = new Label();
    Label label10 = new Label();
    Label label11 = new Label();
    Label label12 = new Label();
    Label label13 = new Label();
    Label label14 = new Label();
    Label label15 = new Label();
    Label label16 = new Label();
    Label label17 = new Label();
    Label label18 = new Label();
    Label label19 = new Label();
    Label label20 = new Label();
    Label label21 = new Label();
    Label label22 = new Label();
    Label label23 = new Label();
    Label label24 = new Label();
    Label label25 = new Label();
    this.lblRetailerContact = new Label();
    ((Control) this.tabRequiredInfo).SuspendLayout();
    ((ISupportInitialize) this.cboSettlementCurrency).BeginInit();
    this.dvQuotingOffice.BeginInit();
    this.dsQuoteEdit.BeginInit();
    ((ISupportInitialize) this.comboCurrencyCode).BeginInit();
    ((ISupportInitialize) this.dtExpirationDate).BeginInit();
    ((ISupportInitialize) this.dtEffectiveDate).BeginInit();
    ((ISupportInitialize) this.cboCompanies).BeginInit();
    ((ISupportInitialize) this.cboIssuingOffice).BeginInit();
    ((ISupportInitialize) this.cboQuotingOffice).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((ISupportInitialize) this.cboUnderwriter).BeginInit();
    ((ISupportInitialize) this.cboLine).BeginInit();
    ((ISupportInitialize) this.cboBillingTypes).BeginInit();
    ((ISupportInitialize) this.cboPolicyType).BeginInit();
    ((Control) this.tabOtherInfo).SuspendLayout();
    ((ISupportInitialize) this.cboRetailerContact).BeginInit();
    ((ISupportInitialize) this.cboNAICSCode).BeginInit();
    this.dvNAICS.BeginInit();
    ((ISupportInitialize) this.cboSecProducerContact).BeginInit();
    ((ISupportInitialize) this.cboUnderwritingAssistant).BeginInit();
    ((ISupportInitialize) this.cboInspectionCompanies).BeginInit();
    ((ISupportInitialize) this.cboFinanceCompany).BeginInit();
    ((ISupportInitialize) this.cboProducerContact).BeginInit();
    ((ISupportInitialize) this.cboRiskClass).BeginInit();
    this.dvSIC.BeginInit();
    ((ISupportInitialize) this.cboTA).BeginInit();
    ((ISupportInitialize) this.txtAccountNum).BeginInit();
    ((Control) this.tabPremiumInfo).SuspendLayout();
    ((ISupportInitialize) this.numFacultativePercentage).BeginInit();
    ((ISupportInitialize) this.numMinimumEarnedAmount).BeginInit();
    ((ISupportInitialize) this.dateNeededBy).BeginInit();
    ((ISupportInitialize) this.numExchangeRate).BeginInit();
    ((ISupportInitialize) this.gbPleaseWait).BeginInit();
    ((Control) this.gbPleaseWait).SuspendLayout();
    ((ISupportInitialize) this.chkFacultative).BeginInit();
    ((ISupportInitialize) this.numMinCancellationDays).BeginInit();
    ((ISupportInitialize) this.optionAuditable).BeginInit();
    ((ISupportInitialize) this.txtRiskDescription).BeginInit();
    ((ISupportInitialize) this.numPreviousPremium).BeginInit();
    ((ISupportInitialize) this.numTargetPremium).BeginInit();
    ((ISupportInitialize) this.numMinimumEarned).BeginInit();
    ((ISupportInitialize) this.cboEarnedPremiumType).BeginInit();
    ((Control) this.tabEndorsement).SuspendLayout();
    ((ISupportInitialize) this.txtEndorsementComment).BeginInit();
    ((ISupportInitialize) this.dtEndorsement).BeginInit();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.txtExpiringControlNumber).BeginInit();
    ((ISupportInitialize) this.chkNonRenewed).BeginInit();
    ((ISupportInitialize) this.comboExpiringCarrier).BeginInit();
    ((ISupportInitialize) this.txtExpiringPolicyNumber).BeginInit();
    ((Control) this.tabKYTaxLocation).SuspendLayout();
    ((ISupportInitialize) this.btnNext).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.tabPolicyInfo).BeginInit();
    ((Control) this.tabPolicyInfo).SuspendLayout();
    ((ISupportInitialize) this.ddProgramCodes).BeginInit();
    ((ISupportInitialize) this.ddIntermediaryContacts).BeginInit();
    ((ISupportInitialize) this.ddCompanyContacts).BeginInit();
    ((ISupportInitialize) this.ugPolicyDetail).BeginInit();
    ((Control) this).SuspendLayout();
    label1.AutoSize = true;
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(50, 72);
    label1.Name = "Label7";
    label1.Size = new Size(37, 13);
    label1.TabIndex = 157;
    label1.Text = "State:";
    label1.TextAlign = ContentAlignment.MiddleRight;
    label2.AutoSize = true;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(23, 132);
    label2.Name = "Label1";
    label2.Size = new Size(64 /*0x40*/, 13);
    label2.TabIndex = 189;
    label2.Text = "Billing Type:";
    label2.TextAlign = ContentAlignment.MiddleRight;
    label3.AutoSize = true;
    label3.BackColor = Color.Transparent;
    label3.Location = new Point(425, 132);
    label3.Name = "Label3";
    label3.Size = new Size(59, 13);
    label3.TabIndex = 162;
    label3.Text = "Expiration:";
    label3.TextAlign = ContentAlignment.MiddleRight;
    label4.AutoSize = true;
    label4.BackColor = Color.Transparent;
    label4.Location = new Point(432, 102);
    label4.Name = "Label4";
    label4.Size = new Size(54, 13);
    label4.TabIndex = 161;
    label4.Text = "Effective:";
    label4.TextAlign = ContentAlignment.MiddleRight;
    label5.AutoSize = true;
    label5.BackColor = Color.Transparent;
    label5.Location = new Point(6, 12);
    label5.Name = "Label12";
    label5.Size = new Size(81, 13);
    label5.TabIndex = 164;
    label5.Text = "Quoting Office:";
    label5.TextAlign = ContentAlignment.MiddleRight;
    label6.AutoSize = true;
    label6.BackColor = Color.Transparent;
    label6.Location = new Point(404, 12);
    label6.Name = "Label10";
    label6.Size = new Size(77, 13);
    label6.TabIndex = 166;
    label6.Text = "Issuing Office:";
    label6.TextAlign = ContentAlignment.MiddleRight;
    label7.AutoSize = true;
    label7.BackColor = Color.Transparent;
    label7.Location = new Point(33, 102);
    label7.Name = "Label8";
    label7.Size = new Size(56, 13);
    label7.TabIndex = 168;
    label7.Text = "Company:";
    label7.TextAlign = ContentAlignment.MiddleRight;
    label8.AutoSize = true;
    label8.BackColor = Color.Transparent;
    label8.Location = new Point(57, 42);
    label8.Name = "Label9";
    label8.Size = new Size(30, 13);
    label8.TabIndex = 153;
    label8.Text = "Line:";
    label8.TextAlign = ContentAlignment.MiddleRight;
    label9.AutoSize = true;
    label9.BackColor = Color.Transparent;
    label9.Location = new Point(418, 72);
    label9.Name = "Label26";
    label9.Size = new Size(65, 13);
    label9.TabIndex = 158;
    label9.Text = "Policy Type:";
    label9.TextAlign = ContentAlignment.MiddleRight;
    label10.AutoSize = true;
    label10.BackColor = Color.Transparent;
    label10.Location = new Point(43, 111);
    label10.Name = "Label14";
    label10.Size = new Size(77, 13);
    label10.TabIndex = 202;
    label10.Text = "Producer CSR:";
    label10.TextAlign = ContentAlignment.MiddleRight;
    label11.AutoSize = true;
    label11.BackColor = Color.Transparent;
    label11.Location = new Point(7, 16 /*0x10*/);
    label11.Name = "Label24";
    label11.Size = new Size(90, 13);
    label11.TabIndex = 199;
    label11.Text = "Expiring Policy #:";
    label11.TextAlign = ContentAlignment.MiddleRight;
    label12.AutoSize = true;
    label12.BackColor = Color.Transparent;
    label12.Location = new Point(11, 37);
    label12.Name = "Label20";
    label12.Size = new Size(109, 13);
    label12.TabIndex = 192 /*0xC0*/;
    label12.Text = "Inspection Company:";
    label12.TextAlign = ContentAlignment.MiddleRight;
    label13.AutoSize = true;
    label13.BackColor = Color.Transparent;
    label13.Location = new Point(416, 62);
    label13.Name = "Label17";
    label13.Size = new Size(11, 13);
    label13.TabIndex = 186;
    label13.Text = "/";
    label14.AutoSize = true;
    label14.BackColor = Color.Transparent;
    label14.Location = new Point(72, 62);
    label14.Name = "Label13";
    label14.Size = new Size(48 /*0x30*/, 13);
    label14.TabIndex = 183;
    label14.Text = "Retailer:";
    label14.TextAlign = ContentAlignment.MiddleRight;
    label15.AutoSize = true;
    label15.BackColor = Color.Transparent;
    label15.Location = new Point(24, 12);
    label15.Name = "Label6";
    label15.Size = new Size(96 /*0x60*/, 13);
    label15.TabIndex = 182;
    label15.Text = "Finance Company:";
    label15.TextAlign = ContentAlignment.MiddleRight;
    label16.AutoSize = true;
    label16.BackColor = Color.Transparent;
    label16.Location = new Point(25, 86);
    label16.Name = "Label41";
    label16.Size = new Size(95, 13);
    label16.TabIndex = 154;
    label16.Text = "Producer Contact:";
    label16.TextAlign = ContentAlignment.MiddleRight;
    label17.AutoSize = true;
    label17.BackColor = Color.Transparent;
    label17.Location = new Point(487, 62);
    label17.Name = "Label2";
    label17.Size = new Size(86, 13);
    label17.TabIndex = 178;
    label17.Text = "Risk Class (SIC):";
    label17.TextAlign = ContentAlignment.MiddleRight;
    label18.AutoSize = true;
    label18.BackColor = Color.Transparent;
    label18.Location = new Point(59, 135);
    label18.Name = "Label19";
    label18.Size = new Size(61, 13);
    label18.TabIndex = 190;
    label18.Text = "Account #:";
    label18.TextAlign = ContentAlignment.MiddleRight;
    label19.AutoSize = true;
    label19.BackColor = Color.Transparent;
    label19.Location = new Point(7, 46);
    label19.Name = "Label25";
    label19.Size = new Size(85, 13);
    label19.TabIndex = 201;
    label19.Text = "Expiring Carrier:";
    label19.TextAlign = ContentAlignment.MiddleRight;
    label20.AutoSize = true;
    label20.BackColor = Color.Transparent;
    label20.Location = new Point(317, 90);
    label20.Name = "Label28";
    label20.Size = new Size(139, 13);
    label20.TabIndex = 205;
    label20.Text = "Minimum Cancellation Days:";
    label20.TextAlign = ContentAlignment.MiddleRight;
    label21.AutoSize = true;
    label21.BackColor = Color.Transparent;
    label21.Location = new Point(506, 86);
    label21.Name = "Label30";
    label21.Size = new Size(70, 13);
    label21.TabIndex = 206;
    label21.Text = "NAICS Code:";
    label21.TextAlign = ContentAlignment.MiddleRight;
    label22.AutoSize = true;
    label22.BackColor = Color.Transparent;
    label22.Location = new Point(4, 98);
    label22.Name = "Label23";
    label22.Size = new Size(115, 13);
    label22.TabIndex = 202;
    label22.Text = "Earned Premium Type:";
    label22.TextAlign = ContentAlignment.MiddleRight;
    label23.AutoSize = true;
    label23.BackColor = Color.Transparent;
    label23.Location = new Point(5, 29);
    label23.Name = "Label22";
    label23.Size = new Size(86, 13);
    label23.TabIndex = 197;
    label23.Text = "Target Premium:";
    label23.TextAlign = ContentAlignment.MiddleRight;
    label24.AutoSize = true;
    label24.BackColor = Color.Transparent;
    label24.Location = new Point(5, 52);
    label24.Name = "Label18";
    label24.Size = new Size(82, 13);
    label24.TabIndex = 189;
    label24.Text = "Min. Earned %:";
    label24.TextAlign = ContentAlignment.MiddleRight;
    label25.AutoSize = true;
    label25.BackColor = Color.Transparent;
    label25.Location = new Point(7, 121);
    label25.Name = "LblexpiredControlno";
    label25.Size = new Size(98, 13);
    label25.TabIndex = 205;
    label25.Text = "Expiring Control #:";
    label25.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.tabRequiredInfo).Controls.Add((Control) this.cboSettlementCurrency);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) this.lblSettlementCurrency);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) this.lnkRefreshChildPolicyNumbering);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) this.comboCurrencyCode);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) this.lnkNewCompanyContact);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) this.dtExpirationDate);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) this.dtEffectiveDate);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) label1);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) label2);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) label3);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) label4);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) label5);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) label6);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) label7);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) this.cboCompanies);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) label8);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) this.Label11);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) this.cboIssuingOffice);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) this.cboQuotingOffice);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) this.cboState);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) this.cboUnderwriter);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) this.cboLine);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) this.cboBillingTypes);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) this.cboPolicyType);
    ((Control) this.tabRequiredInfo).Controls.Add((Control) label9);
    ((Control) this.tabRequiredInfo).Location = new Point(-10000, -10000);
    ((Control) this.tabRequiredInfo).Name = "tabRequiredInfo";
    ((Control) this.tabRequiredInfo).Size = new Size(791, 160 /*0xA0*/);
    ((UltraCombo) this.cboSettlementCurrency).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboSettlementCurrency).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboSettlementCurrency).DropDownWidth = 150;
    ((Control) this.cboSettlementCurrency).Location = new Point(299, 68);
    this.cboSettlementCurrency.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboSettlementCurrency).Name = "cboSettlementCurrency";
    ((Control) this.cboSettlementCurrency).Size = new Size(77, 21);
    ((Control) this.cboSettlementCurrency).TabIndex = 196;
    ((UltraControlBase) this.cboSettlementCurrency).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboSettlementCurrency).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.cboSettlementCurrency).Visible = false;
    this.dvQuotingOffice.Table = (DataTable) this.dsQuoteEdit.tblClientOffices;
    this.dsQuoteEdit.DataSetName = "dsQuoteEdit";
    this.dsQuoteEdit.Locale = new CultureInfo("en-US");
    this.dsQuoteEdit.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lblSettlementCurrency.AutoSize = true;
    this.lblSettlementCurrency.BackColor = Color.Transparent;
    this.lblSettlementCurrency.Location = new Point(300, 52);
    this.lblSettlementCurrency.Name = "lblSettlementCurrency";
    this.lblSettlementCurrency.Size = new Size(110, 13);
    this.lblSettlementCurrency.TabIndex = 195;
    this.lblSettlementCurrency.Text = "Settlement Currency:";
    this.lblSettlementCurrency.TextAlign = ContentAlignment.MiddleRight;
    this.lnkRefreshChildPolicyNumbering.BackColor = Color.Transparent;
    this.lnkRefreshChildPolicyNumbering.Location = new Point(667, 128 /*0x80*/);
    this.lnkRefreshChildPolicyNumbering.Name = "lnkRefreshChildPolicyNumbering";
    this.lnkRefreshChildPolicyNumbering.Size = new Size(81, 20);
    this.lnkRefreshChildPolicyNumbering.TabIndex = 194;
    this.lnkRefreshChildPolicyNumbering.TabStop = true;
    this.lnkRefreshChildPolicyNumbering.Text = "Child Policy #s";
    this.lnkRefreshChildPolicyNumbering.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkRefreshChildPolicyNumbering.Visible = false;
    ((UltraCombo) this.comboCurrencyCode).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboCurrencyCode).DataSource = (object) this.dvQuotingOffice;
    ((UltraDropDownBase) this.comboCurrencyCode).DisplayMember = "Location";
    ((UltraCombo) this.comboCurrencyCode).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboCurrencyCode).DropDownWidth = 300;
    ((Control) this.comboCurrencyCode).Location = new Point(299, 8);
    this.comboCurrencyCode.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboCurrencyCode).Name = "comboCurrencyCode";
    ((Control) this.comboCurrencyCode).Size = new Size(77, 21);
    ((Control) this.comboCurrencyCode).TabIndex = 193;
    ((UltraControlBase) this.comboCurrencyCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCurrencyCode).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboCurrencyCode).ValueMember = "OfficeGuid";
    ((Control) this.comboCurrencyCode).Visible = false;
    this.lnkNewCompanyContact.BackColor = Color.Transparent;
    this.lnkNewCompanyContact.Location = new Point(296, 98);
    this.lnkNewCompanyContact.Name = "lnkNewCompanyContact";
    this.lnkNewCompanyContact.Size = new Size(93, 20);
    this.lnkNewCompanyContact.TabIndex = 192 /*0xC0*/;
    this.lnkNewCompanyContact.TabStop = true;
    this.lnkNewCompanyContact.Text = "(new contact)";
    this.lnkNewCompanyContact.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkNewCompanyContact.Visible = false;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtExpirationDate).Appearance = (AppearanceBase) appearance1;
    appearance2.AlphaLevel = (short) 14;
    appearance2.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance2.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance2.BackColorAlpha = (Alpha) 2;
    appearance2.BackGradientAlignment = (GradientAlignment) 4;
    appearance2.BackGradientStyle = (GradientStyle) 5;
    appearance2.BorderAlpha = (Alpha) 1;
    appearance2.BorderColor = Color.FromArgb(78, 122, 171);
    appearance2.ForeColor = Color.FromArgb(49, 85, 153);
    appearance2.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtExpirationDate).ButtonAppearance = (AppearanceBase) appearance2;
    ((UltraDateTimeEditor) this.dtExpirationDate).DateTime = new DateTime(2016, 1, 5, 0, 0, 0, 0);
    ((Control) this.dtExpirationDate).Location = new Point(489, 128 /*0x80*/);
    this.dtExpirationDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtExpirationDate).Name = "dtExpirationDate";
    ((Control) this.dtExpirationDate).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.dtExpirationDate).TabIndex = 9;
    ((UltraControlBase) this.dtExpirationDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtExpirationDate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtExpirationDate).Value = (object) new DateTime(2016, 1, 5, 0, 0, 0, 0);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtEffectiveDate).Appearance = (AppearanceBase) appearance3;
    appearance4.AlphaLevel = (short) 14;
    appearance4.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance4.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance4.BackColorAlpha = (Alpha) 2;
    appearance4.BackGradientAlignment = (GradientAlignment) 4;
    appearance4.BackGradientStyle = (GradientStyle) 5;
    appearance4.BorderAlpha = (Alpha) 1;
    appearance4.BorderColor = Color.FromArgb(78, 122, 171);
    appearance4.ForeColor = Color.FromArgb(49, 85, 153);
    appearance4.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtEffectiveDate).ButtonAppearance = (AppearanceBase) appearance4;
    ((UltraDateTimeEditor) this.dtEffectiveDate).DateTime = new DateTime(2016, 1, 5, 0, 0, 0, 0);
    ((Control) this.dtEffectiveDate).Location = new Point(489, 98);
    this.dtEffectiveDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtEffectiveDate).Name = "dtEffectiveDate";
    ((UltraDateTimeEditor) this.dtEffectiveDate).Nullable = false;
    ((Control) this.dtEffectiveDate).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.dtEffectiveDate).TabIndex = 8;
    ((UltraControlBase) this.dtEffectiveDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEffectiveDate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtEffectiveDate).Value = (object) new DateTime(2016, 1, 5, 0, 0, 0, 0);
    ((UltraCombo) this.cboCompanies).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboCompanies).DataSource = (object) this.dsQuoteEdit.tblCompanyLocations;
    ((UltraDropDownBase) this.cboCompanies).DisplayMember = "Name";
    ((UltraCombo) this.cboCompanies).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCompanies).DropDownWidth = 520;
    ((Control) this.cboCompanies).Location = new Point(96 /*0x60*/, 98);
    this.cboCompanies.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboCompanies).Name = "cboCompanies";
    ((Control) this.cboCompanies).Size = new Size(189, 21);
    ((Control) this.cboCompanies).TabIndex = 3;
    ((UltraControlBase) this.cboCompanies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanies).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompanies).ValueMember = "CompanyLocationGuid";
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(416, 42);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(68, 13);
    this.Label11.TabIndex = 152;
    this.Label11.Text = "Underwriter:";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboIssuingOffice).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboIssuingOffice).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboIssuingOffice).DropDownWidth = 300;
    ((Control) this.cboIssuingOffice).Location = new Point(489, 8);
    this.cboIssuingOffice.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboIssuingOffice).Name = "cboIssuingOffice";
    ((Control) this.cboIssuingOffice).Size = new Size(200, 21);
    ((Control) this.cboIssuingOffice).TabIndex = 5;
    ((UltraControlBase) this.cboIssuingOffice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboIssuingOffice).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboQuotingOffice).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboQuotingOffice).DataSource = (object) this.dvQuotingOffice;
    ((UltraDropDownBase) this.cboQuotingOffice).DisplayMember = "Location";
    ((UltraCombo) this.cboQuotingOffice).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboQuotingOffice).DropDownWidth = 300;
    ((Control) this.cboQuotingOffice).Location = new Point(96 /*0x60*/, 8);
    this.cboQuotingOffice.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboQuotingOffice).Name = "cboQuotingOffice";
    ((Control) this.cboQuotingOffice).Size = new Size(189, 21);
    ((Control) this.cboQuotingOffice).TabIndex = 0;
    ((UltraControlBase) this.cboQuotingOffice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboQuotingOffice).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboQuotingOffice).ValueMember = "OfficeGuid";
    ((UltraCombo) this.cboState).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboState).DataSource = (object) this.dsQuoteEdit.lstStates;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    ((UltraCombo) this.cboState).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboState).DropDownWidth = 300;
    ((Control) this.cboState).Location = new Point(96 /*0x60*/, 68);
    this.cboState.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(189, 21);
    ((Control) this.cboState).TabIndex = 2;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    ((UltraCombo) this.cboUnderwriter).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboUnderwriter).DataSource = (object) this.dsQuoteEdit.tblUsers;
    ((UltraDropDownBase) this.cboUnderwriter).DisplayMember = "FullName";
    ((UltraCombo) this.cboUnderwriter).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboUnderwriter).DropDownWidth = 300;
    ((Control) this.cboUnderwriter).Location = new Point(489, 38);
    this.cboUnderwriter.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboUnderwriter).Name = "cboUnderwriter";
    ((Control) this.cboUnderwriter).Size = new Size(200, 21);
    ((Control) this.cboUnderwriter).TabIndex = 6;
    ((UltraControlBase) this.cboUnderwriter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUnderwriter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUnderwriter).ValueMember = "UserGuid";
    ((UltraCombo) this.cboLine).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboLine).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLine).DropDownWidth = 300;
    ((Control) this.cboLine).Location = new Point(96 /*0x60*/, 38);
    this.cboLine.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboLine).Name = "cboLine";
    ((Control) this.cboLine).Size = new Size(189, 21);
    ((Control) this.cboLine).TabIndex = 1;
    this.Tip.SetToolTip((Control) this.cboLine, "Limited to only the lines that this producer and quoting office are authorized to write.");
    ((UltraControlBase) this.cboLine).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLine).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboBillingTypes).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboBillingTypes).DataSource = (object) this.dsQuoteEdit.lstBillingTypes;
    ((UltraDropDownBase) this.cboBillingTypes).DisplayMember = "BillingType";
    ((UltraCombo) this.cboBillingTypes).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboBillingTypes).DropDownWidth = 300;
    ((Control) this.cboBillingTypes).Location = new Point(96 /*0x60*/, 128 /*0x80*/);
    this.cboBillingTypes.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboBillingTypes).Name = "cboBillingTypes";
    ((Control) this.cboBillingTypes).Size = new Size(189, 21);
    ((Control) this.cboBillingTypes).TabIndex = 4;
    ((UltraControlBase) this.cboBillingTypes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboBillingTypes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboBillingTypes).ValueMember = "BillingTypeID";
    ((UltraCombo) this.cboPolicyType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboPolicyType).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboPolicyType).Location = new Point(489, 68);
    this.cboPolicyType.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboPolicyType).Name = "cboPolicyType";
    ((Control) this.cboPolicyType).Size = new Size(200, 21);
    ((Control) this.cboPolicyType).TabIndex = 7;
    ((UltraControlBase) this.cboPolicyType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPolicyType).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.lblRetailerContact);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.cboRetailerContact);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.lnkSIC);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.cboNAICSCode);
    ((Control) this.tabOtherInfo).Controls.Add((Control) label21);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.Label29);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.lblProgramCode);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.cboSecProducerContact);
    ((Control) this.tabOtherInfo).Controls.Add((Control) label10);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.Label27);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.cboUnderwritingAssistant);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.lnkAddModifyProducerContacts);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.lblRetailer);
    ((Control) this.tabOtherInfo).Controls.Add((Control) label12);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.cboInspectionCompanies);
    ((Control) this.tabOtherInfo).Controls.Add((Control) label13);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.lnkUpdateRetailer);
    ((Control) this.tabOtherInfo).Controls.Add((Control) label14);
    ((Control) this.tabOtherInfo).Controls.Add((Control) label15);
    ((Control) this.tabOtherInfo).Controls.Add((Control) label16);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.cboFinanceCompany);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.lnkRemoveRetailer);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.cboProducerContact);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.cboRiskClass);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.cboTA);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.lblTA);
    ((Control) this.tabOtherInfo).Controls.Add((Control) label17);
    ((Control) this.tabOtherInfo).Controls.Add((Control) label18);
    ((Control) this.tabOtherInfo).Controls.Add((Control) this.txtAccountNum);
    ((Control) this.tabOtherInfo).Location = new Point(-10000, -10000);
    ((Control) this.tabOtherInfo).Name = "tabOtherInfo";
    ((Control) this.tabOtherInfo).Size = new Size(791, 160 /*0xA0*/);
    this.lblRetailerContact.AutoSize = true;
    this.lblRetailerContact.BackColor = Color.Transparent;
    this.lblRetailerContact.Location = new Point(484, 139);
    this.lblRetailerContact.Name = "lblRetailerContact";
    this.lblRetailerContact.Size = new Size(89, 13);
    this.lblRetailerContact.TabIndex = 217;
    this.lblRetailerContact.Text = "Retailer Contact:";
    this.lblRetailerContact.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboRetailerContact).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboRetailerContact).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboRetailerContact).DropDownWidth = 200;
    ((Control) this.cboRetailerContact).Location = new Point(586, 132);
    this.cboRetailerContact.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboRetailerContact).Name = "cboRetailerContact";
    ((Control) this.cboRetailerContact).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboRetailerContact).TabIndex = 216;
    ((UltraControlBase) this.cboRetailerContact).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboRetailerContact).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkSIC.AutoSize = true;
    this.lnkSIC.BackColor = Color.Transparent;
    this.lnkSIC.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lnkSIC.Location = new Point(748, 62);
    this.lnkSIC.Name = "lnkSIC";
    this.lnkSIC.Size = new Size(42, 13);
    this.lnkSIC.TabIndex = 207;
    this.lnkSIC.TabStop = true;
    this.lnkSIC.Text = "Update";
    this.lnkSIC.TextAlign = ContentAlignment.MiddleCenter;
    ((UltraCombo) this.cboNAICSCode).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboNAICSCode).DataSource = (object) this.dvNAICS;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboNAICSCode.DisplayLayout.Appearance = (AppearanceBase) appearance5;
    this.cboNAICSCode.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 228;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 19;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 117;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 117;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    this.cboNAICSCode.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboNAICSCode.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboNAICSCode.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboNAICSCode.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance6.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance6.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboNAICSCode.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.White;
    this.cboNAICSCode.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    this.cboNAICSCode.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance8.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance8.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance8.ForeColor = Color.Black;
    this.cboNAICSCode.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboNAICSCode.DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraDropDownBase) this.cboNAICSCode).DisplayMember = "NAICSDescription";
    ((UltraCombo) this.cboNAICSCode).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboNAICSCode).DropDownWidth = 500;
    ((Control) this.cboNAICSCode).Location = new Point(586, 82);
    ((MGASimpleComboBox) this.cboNAICSCode).MGAStyle = (MGAStyles) 2;
    ((Control) this.cboNAICSCode).Name = "cboNAICSCode";
    ((Control) this.cboNAICSCode).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboNAICSCode).TabIndex = 205;
    ((UltraControlBase) this.cboNAICSCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboNAICSCode).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboNAICSCode).ValueMember = "NAICSCode";
    this.dvNAICS.Table = (DataTable) this.dsQuoteEdit.lstNAICSCodes;
    this.Label29.AutoSize = true;
    this.Label29.BackColor = Color.Transparent;
    this.Label29.Location = new Point(497, 111);
    this.Label29.Name = "Label29";
    this.Label29.Size = new Size(79, 13);
    this.Label29.TabIndex = 204;
    this.Label29.Text = "Program Code:";
    this.Label29.TextAlign = ContentAlignment.MiddleRight;
    this.lblProgramCode.AutoSize = true;
    this.lblProgramCode.BackColor = Color.Transparent;
    this.lblProgramCode.Location = new Point(583, 111);
    this.lblProgramCode.Name = "lblProgramCode";
    this.lblProgramCode.Size = new Size(44, 13);
    this.lblProgramCode.TabIndex = 203;
    this.lblProgramCode.Text = "Label29";
    ((UltraCombo) this.cboSecProducerContact).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboSecProducerContact).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboSecProducerContact).DropDownWidth = 300;
    ((Control) this.cboSecProducerContact).Location = new Point(128 /*0x80*/, 107);
    this.cboSecProducerContact.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboSecProducerContact).Name = "cboSecProducerContact";
    ((Control) this.cboSecProducerContact).Size = new Size(238, 21);
    ((Control) this.cboSecProducerContact).TabIndex = 4;
    ((UltraControlBase) this.cboSecProducerContact).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboSecProducerContact).UseOsThemes = (DefaultableBoolean) 2;
    this.Label27.AutoSize = true;
    this.Label27.BackColor = Color.Transparent;
    this.Label27.Location = new Point(522, 37);
    this.Label27.Name = "Label27";
    this.Label27.Size = new Size(55, 13);
    this.Label27.TabIndex = 201;
    this.Label27.Text = "Assistant:";
    this.Label27.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboUnderwritingAssistant).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboUnderwritingAssistant).DataSource = (object) this.dsQuoteEdit.Assistants;
    ((UltraDropDownBase) this.cboUnderwritingAssistant).DisplayMember = "FullName";
    ((UltraCombo) this.cboUnderwritingAssistant).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboUnderwritingAssistant).DropDownWidth = 300;
    ((Control) this.cboUnderwritingAssistant).Location = new Point(586, 33);
    this.cboUnderwritingAssistant.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboUnderwritingAssistant).Name = "cboUnderwritingAssistant";
    ((Control) this.cboUnderwritingAssistant).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboUnderwritingAssistant).TabIndex = 9;
    ((UltraControlBase) this.cboUnderwritingAssistant).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUnderwritingAssistant).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUnderwritingAssistant).ValueMember = "UserGuid";
    this.lnkAddModifyProducerContacts.AutoSize = true;
    this.lnkAddModifyProducerContacts.BackColor = Color.Transparent;
    this.lnkAddModifyProducerContacts.Location = new Point(376, 86);
    this.lnkAddModifyProducerContacts.Name = "lnkAddModifyProducerContacts";
    this.lnkAddModifyProducerContacts.Size = new Size(54, 13);
    this.lnkAddModifyProducerContacts.TabIndex = 194;
    this.lnkAddModifyProducerContacts.TabStop = true;
    this.lnkAddModifyProducerContacts.Text = "Add / Edit";
    this.lnkAddModifyProducerContacts.TextAlign = ContentAlignment.MiddleLeft;
    appearance9.BackColor = Color.Transparent;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblRetailer).Appearance = (AppearanceBase) appearance9;
    ((ControlBase) this.lblRetailer).BackColorInternal = Color.WhiteSmoke;
    this.lblRetailer.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblRetailer).Location = new Point(128 /*0x80*/, 58);
    ((Control) this.lblRetailer).Name = "lblRetailer";
    ((Control) this.lblRetailer).Size = new Size(238, 20);
    ((Control) this.lblRetailer).TabIndex = 2;
    ((UltraControlBase) this.lblRetailer).UseFlatMode = (DefaultableBoolean) 1;
    ((ControlBase) this.lblRetailer).UseMnemonic = false;
    ((UltraControlBase) this.lblRetailer).UseOsThemes = (DefaultableBoolean) 2;
    ((ControlBase) this.lblRetailer).WrapText = false;
    ((UltraCombo) this.cboInspectionCompanies).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboInspectionCompanies).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboInspectionCompanies).DropDownWidth = 300;
    ((Control) this.cboInspectionCompanies).Location = new Point(128 /*0x80*/, 33);
    this.cboInspectionCompanies.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboInspectionCompanies).Name = "cboInspectionCompanies";
    ((Control) this.cboInspectionCompanies).Size = new Size(238, 21);
    ((Control) this.cboInspectionCompanies).TabIndex = 1;
    ((UltraControlBase) this.cboInspectionCompanies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInspectionCompanies).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkUpdateRetailer.AutoSize = true;
    this.lnkUpdateRetailer.BackColor = Color.Transparent;
    this.lnkUpdateRetailer.Location = new Point(376, 62);
    this.lnkUpdateRetailer.Name = "lnkUpdateRetailer";
    this.lnkUpdateRetailer.Size = new Size(42, 13);
    this.lnkUpdateRetailer.TabIndex = 185;
    this.lnkUpdateRetailer.TabStop = true;
    this.lnkUpdateRetailer.Text = "Update";
    this.lnkUpdateRetailer.TextAlign = ContentAlignment.MiddleLeft;
    ((UltraCombo) this.cboFinanceCompany).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboFinanceCompany).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboFinanceCompany).DropDownWidth = 300;
    ((Control) this.cboFinanceCompany).Location = new Point(128 /*0x80*/, 8);
    this.cboFinanceCompany.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboFinanceCompany).Name = "cboFinanceCompany";
    ((Control) this.cboFinanceCompany).Size = new Size(238, 21);
    ((Control) this.cboFinanceCompany).TabIndex = 0;
    ((UltraControlBase) this.cboFinanceCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboFinanceCompany).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkRemoveRetailer.AutoSize = true;
    this.lnkRemoveRetailer.BackColor = Color.Transparent;
    this.lnkRemoveRetailer.Location = new Point(424, 62);
    this.lnkRemoveRetailer.Name = "lnkRemoveRetailer";
    this.lnkRemoveRetailer.Size = new Size(46, 13);
    this.lnkRemoveRetailer.TabIndex = 187;
    this.lnkRemoveRetailer.TabStop = true;
    this.lnkRemoveRetailer.Text = "Remove";
    this.lnkRemoveRetailer.TextAlign = ContentAlignment.MiddleLeft;
    ((UltraCombo) this.cboProducerContact).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboProducerContact).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProducerContact).DropDownWidth = 300;
    ((Control) this.cboProducerContact).Location = new Point(128 /*0x80*/, 82);
    this.cboProducerContact.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboProducerContact).Name = "cboProducerContact";
    ((Control) this.cboProducerContact).Size = new Size(238, 21);
    ((Control) this.cboProducerContact).TabIndex = 3;
    ((UltraControlBase) this.cboProducerContact).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducerContact).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboRiskClass).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboRiskClass).DataSource = (object) this.dvSIC;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboRiskClass.DisplayLayout.Appearance = (AppearanceBase) appearance10;
    this.cboRiskClass.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Width = 215;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Width = 62;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Width = 204;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 3;
    ultraGridColumn8.Width = 81;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 7;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 8;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 9;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 11;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 12;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 15;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 16 /*0x10*/;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 17;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 18;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 19;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 20;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 21;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 22;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 23;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 24;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 25;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 26;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 27;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 28;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 29;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 30;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 31 /*0x1F*/;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 32 /*0x20*/;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 33;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 34;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 35;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 36;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 37;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 38;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 39;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 40;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 41;
    ultraGridBand3.Columns.AddRange(new object[42]
    {
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
      (object) ultraGridColumn50
    });
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn56.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn57.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn58.Header.VisiblePosition = 7;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn59.Header.VisiblePosition = 8;
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn60.Header.VisiblePosition = 9;
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn61.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn62.Header.VisiblePosition = 11;
    ultraGridBand4.Columns.AddRange(new object[12]
    {
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
      (object) ultraGridColumn62
    });
    this.cboRiskClass.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboRiskClass.DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    this.cboRiskClass.DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    this.cboRiskClass.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboRiskClass.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboRiskClass.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance11.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance11.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboRiskClass.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance11;
    appearance12.BorderColor = Color.White;
    this.cboRiskClass.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    this.cboRiskClass.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance13.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance13.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance13.ForeColor = Color.Black;
    this.cboRiskClass.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboRiskClass.DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraDropDownBase) this.cboRiskClass).DisplayMember = "SIC_Description";
    ((UltraCombo) this.cboRiskClass).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboRiskClass).DropDownWidth = 500;
    ((Control) this.cboRiskClass).Location = new Point(586, 58);
    ((MGASimpleComboBox) this.cboRiskClass).MGAStyle = (MGAStyles) 2;
    ((Control) this.cboRiskClass).Name = "cboRiskClass";
    ((Control) this.cboRiskClass).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboRiskClass).TabIndex = 6;
    ((UltraControlBase) this.cboRiskClass).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboRiskClass).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboRiskClass).ValueMember = "SIC_Code";
    this.dvSIC.Table = (DataTable) this.dsQuoteEdit.lstSIC_Codes;
    ((UltraCombo) this.cboTA).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboTA).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboTA).DropDownWidth = 300;
    ((Control) this.cboTA).Location = new Point(586, 8);
    this.cboTA.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboTA).Name = "cboTA";
    ((Control) this.cboTA).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboTA).TabIndex = 7;
    ((UltraControlBase) this.cboTA).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboTA).UseOsThemes = (DefaultableBoolean) 2;
    this.lblTA.AutoSize = true;
    this.lblTA.BackColor = Color.Transparent;
    this.lblTA.Location = new Point(528, 12);
    this.lblTA.Name = "lblTA";
    this.lblTA.Size = new Size(48 /*0x30*/, 13);
    this.lblTA.TabIndex = 180;
    this.lblTA.Text = "TA/CSR:";
    this.lblTA.TextAlign = ContentAlignment.MiddleRight;
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAccountNum).Appearance = (AppearanceBase) appearance14;
    ((TextEditorControlBase) this.txtAccountNum).BackColor = Color.White;
    ((Control) this.txtAccountNum).Location = new Point(128 /*0x80*/, 132);
    this.txtAccountNum.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtAccountNum).Name = "txtAccountNum";
    ((Control) this.txtAccountNum).Size = new Size(160 /*0xA0*/, 20);
    ((Control) this.txtAccountNum).TabIndex = 5;
    ((UltraControlBase) this.txtAccountNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAccountNum).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.lblFacultativePercentage);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.numFacultativePercentage);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.lblMinEarnedAmount);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.numMinimumEarnedAmount);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.Label31);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.dateNeededBy);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.lblExchangeRate);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.numExchangeRate);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.gbPleaseWait);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.chkFacultative);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.numMinCancellationDays);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) label20);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.lnkCommentsByLine);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.optionAuditable);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) label22);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.lblRiskDescription);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.txtRiskDescription);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.numPreviousPremium);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.Label21);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.numTargetPremium);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) label23);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.numMinimumEarned);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) label24);
    ((Control) this.tabPremiumInfo).Controls.Add((Control) this.cboEarnedPremiumType);
    ((Control) this.tabPremiumInfo).Location = new Point(1, 26);
    ((Control) this.tabPremiumInfo).Name = "tabPremiumInfo";
    ((Control) this.tabPremiumInfo).Size = new Size(791, 160 /*0xA0*/);
    this.lblFacultativePercentage.AutoSize = true;
    this.lblFacultativePercentage.BackColor = Color.Transparent;
    this.lblFacultativePercentage.Location = new Point(409, 116);
    this.lblFacultativePercentage.Name = "lblFacultativePercentage";
    this.lblFacultativePercentage.Size = new Size(78, 13);
    this.lblFacultativePercentage.TabIndex = 213;
    this.lblFacultativePercentage.Text = "Facultative %:";
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numFacultativePercentage).Appearance = (AppearanceBase) appearance15;
    ((UltraNumericEditorBase) this.numFacultativePercentage).FormatString = "";
    ((Control) this.numFacultativePercentage).Location = new Point(493, 112 /*0x70*/);
    ((UltraNumericEditor) this.numFacultativePercentage).MaskInput = "nnn.nn";
    ((UltraNumericEditor) this.numFacultativePercentage).MaxValue = (object) new Decimal(new int[4]
    {
      10000,
      0,
      0,
      131072 /*0x020000*/
    });
    this.numFacultativePercentage.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.numFacultativePercentage).MinValue = (object) new Decimal(new int[4]
    {
      0,
      0,
      0,
      131072 /*0x020000*/
    });
    ((Control) this.numFacultativePercentage).Name = "numFacultativePercentage";
    ((UltraNumericEditor) this.numFacultativePercentage).Nullable = true;
    ((UltraNumericEditor) this.numFacultativePercentage).NumericType = (NumericType) 2;
    ((Control) this.numFacultativePercentage).Size = new Size(49, 20);
    ((Control) this.numFacultativePercentage).TabIndex = 212;
    ((UltraControlBase) this.numFacultativePercentage).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numFacultativePercentage).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraNumericEditor) this.numFacultativePercentage).Value = (object) null;
    this.lblMinEarnedAmount.AutoSize = true;
    this.lblMinEarnedAmount.BackColor = Color.Transparent;
    this.lblMinEarnedAmount.Location = new Point(5, 75);
    this.lblMinEarnedAmount.Name = "lblMinEarnedAmount";
    this.lblMinEarnedAmount.Size = new Size(108, 13);
    this.lblMinEarnedAmount.TabIndex = 211;
    this.lblMinEarnedAmount.Text = "Min. Earned Amount:";
    this.lblMinEarnedAmount.TextAlign = ContentAlignment.MiddleRight;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numMinimumEarnedAmount).Appearance = (AppearanceBase) appearance16;
    ((UltraNumericEditorBase) this.numMinimumEarnedAmount).FormatString = "c";
    ((Control) this.numMinimumEarnedAmount).Location = new Point(125, 71);
    ((UltraNumericEditor) this.numMinimumEarnedAmount).MaskInput = "nnnnnnnnn.nn";
    this.numMinimumEarnedAmount.MGAStyle = (MGAStyles) 2;
    ((Control) this.numMinimumEarnedAmount).Name = "numMinimumEarnedAmount";
    ((UltraNumericEditor) this.numMinimumEarnedAmount).Nullable = true;
    ((UltraNumericEditor) this.numMinimumEarnedAmount).NumericType = (NumericType) 2;
    ((Control) this.numMinimumEarnedAmount).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.numMinimumEarnedAmount).TabIndex = 3;
    ((UltraWinEditorMaskedControlBase) this.numMinimumEarnedAmount).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numMinimumEarnedAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numMinimumEarnedAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraNumericEditor) this.numMinimumEarnedAmount).Value = (object) null;
    this.Label31.AutoSize = true;
    this.Label31.BackColor = Color.Transparent;
    this.Label31.Location = new Point(323, 140);
    this.Label31.Name = "Label31";
    this.Label31.Size = new Size(63 /*0x3F*/, 13);
    this.Label31.TabIndex = 210;
    this.Label31.Text = "Needed By:";
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateNeededBy).Appearance = (AppearanceBase) appearance17;
    ((UltraDateTimeEditor) this.dateNeededBy).BackColor = Color.White;
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
    ((UltraDateTimeEditor) this.dateNeededBy).ButtonAppearance = (AppearanceBase) appearance18;
    ((UltraDateTimeEditor) this.dateNeededBy).DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dateNeededBy).Location = new Point(412, 137);
    this.dateNeededBy.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateNeededBy).Name = "dateNeededBy";
    ((Control) this.dateNeededBy).Size = new Size(91, 20);
    ((Control) this.dateNeededBy).TabIndex = 10;
    ((UltraControlBase) this.dateNeededBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateNeededBy).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateNeededBy).Value = (object) null;
    this.lblExchangeRate.AutoSize = true;
    this.lblExchangeRate.BackColor = Color.Transparent;
    this.lblExchangeRate.Location = new Point(5, 122);
    this.lblExchangeRate.Name = "lblExchangeRate";
    this.lblExchangeRate.Size = new Size(84, 13);
    this.lblExchangeRate.TabIndex = 208 /*0xD0*/;
    this.lblExchangeRate.Text = "Exchange Rate:";
    this.lblExchangeRate.TextAlign = ContentAlignment.MiddleRight;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numExchangeRate).Appearance = (AppearanceBase) appearance19;
    ((UltraNumericEditorBase) this.numExchangeRate).FormatString = "";
    ((Control) this.numExchangeRate).Location = new Point(125, 118);
    ((UltraNumericEditor) this.numExchangeRate).MaskInput = "n.nnnnn";
    ((UltraNumericEditor) this.numExchangeRate).MaxValue = (object) 365;
    this.numExchangeRate.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.numExchangeRate).MinValue = (object) 0;
    ((Control) this.numExchangeRate).Name = "numExchangeRate";
    ((UltraNumericEditor) this.numExchangeRate).Nullable = true;
    ((UltraNumericEditor) this.numExchangeRate).NumericType = (NumericType) 2;
    ((Control) this.numExchangeRate).Size = new Size(52, 20);
    ((Control) this.numExchangeRate).TabIndex = 5;
    ((UltraWinEditorMaskedControlBase) this.numExchangeRate).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numExchangeRate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numExchangeRate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraNumericEditor) this.numExchangeRate).Value = (object) null;
    this.gbPleaseWait.BorderStyle = (GroupBoxBorderStyle) 13;
    appearance20.BackColor = Color.White;
    appearance20.BorderColor = Color.Gray;
    this.gbPleaseWait.ContentAreaAppearance = (AppearanceBase) appearance20;
    ((Control) this.gbPleaseWait).Controls.Add((Control) this.BouncingProgress1);
    ((Control) this.gbPleaseWait).Controls.Add((Control) this.Label5);
    ((Control) this.gbPleaseWait).Location = new Point(227, 18);
    ((Control) this.gbPleaseWait).Name = "gbPleaseWait";
    ((Control) this.gbPleaseWait).Size = new Size(328, 88);
    ((Control) this.gbPleaseWait).TabIndex = 193;
    this.BouncingProgress1.Border = BorderStyle.FixedSingle;
    this.BouncingProgress1.BorderColor = Color.DarkGray;
    this.BouncingProgress1.Bounce = false;
    this.BouncingProgress1.BounceColor = Color.LightSteelBlue;
    ((Control) this.BouncingProgress1).Location = new Point(16 /*0x10*/, 64 /*0x40*/);
    ((Control) this.BouncingProgress1).Name = "BouncingProgress1";
    ((Control) this.BouncingProgress1).Size = new Size(296, 8);
    ((Control) this.BouncingProgress1).TabIndex = 166;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Font = new Font("Tahoma", 14f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label5.Location = new Point(52, 16 /*0x10*/);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(225, 23);
    this.Label5.TabIndex = 165;
    this.Label5.Text = "Loading ... Please Wait ...";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance21.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFacultative).Appearance = (AppearanceBase) appearance21;
    ((UltraToggleEditorBase) this.chkFacultative).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFacultative).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFacultative).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFacultative).Location = new Point(320, 112 /*0x70*/);
    this.chkFacultative.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkFacultative).Name = "chkFacultative";
    ((Control) this.chkFacultative).Size = new Size(83, 20);
    ((Control) this.chkFacultative).TabIndex = 9;
    ((UltraToggleEditorBase) this.chkFacultative).Text = "Facultative";
    ((UltraControlBase) this.chkFacultative).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFacultative).UseOsThemes = (DefaultableBoolean) 2;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numMinCancellationDays).Appearance = (AppearanceBase) appearance22;
    ((UltraNumericEditorBase) this.numMinCancellationDays).FormatString = "";
    ((Control) this.numMinCancellationDays).Location = new Point(481, 86);
    ((UltraNumericEditor) this.numMinCancellationDays).MaskInput = "nnn";
    ((UltraNumericEditor) this.numMinCancellationDays).MaxValue = (object) 365;
    this.numMinCancellationDays.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.numMinCancellationDays).MinValue = (object) 0;
    ((Control) this.numMinCancellationDays).Name = "numMinCancellationDays";
    ((UltraNumericEditor) this.numMinCancellationDays).Nullable = true;
    ((Control) this.numMinCancellationDays).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.numMinCancellationDays).TabIndex = 8;
    ((UltraControlBase) this.numMinCancellationDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numMinCancellationDays).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkCommentsByLine.AutoSize = true;
    this.lnkCommentsByLine.BackColor = Color.Transparent;
    this.lnkCommentsByLine.Location = new Point(567, 9);
    this.lnkCommentsByLine.Name = "lnkCommentsByLine";
    this.lnkCommentsByLine.Size = new Size(151, 13);
    this.lnkCommentsByLine.TabIndex = 203;
    this.lnkCommentsByLine.TabStop = true;
    this.lnkCommentsByLine.Text = "Comments by Line of Business";
    this.lnkCommentsByLine.TextAlign = ContentAlignment.MiddleLeft;
    this.optionAuditable.BackColor = Color.Transparent;
    this.optionAuditable.BackColorInternal = Color.Transparent;
    this.optionAuditable.BorderStyle = (UIElementBorderStyle) 1;
    this.optionAuditable.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem1.DataValue = (object) true;
    valueListItem1.DisplayText = "Auditable";
    valueListItem2.DataValue = (object) false;
    valueListItem2.DisplayText = "Non-Auditable";
    this.optionAuditable.Items.AddRange(new ValueListItem[2]
    {
      valueListItem1,
      valueListItem2
    });
    ((Control) this.optionAuditable).Location = new Point(125, 141);
    ((Control) this.optionAuditable).Name = "optionAuditable";
    ((Control) this.optionAuditable).Size = new Size(171, 13);
    ((Control) this.optionAuditable).TabIndex = 6;
    ((UltraControlBase) this.optionAuditable).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optionAuditable).UseOsThemes = (DefaultableBoolean) 2;
    this.lblRiskDescription.AutoSize = true;
    this.lblRiskDescription.BackColor = Color.Transparent;
    this.lblRiskDescription.Location = new Point(224 /*0xE0*/, 7);
    this.lblRiskDescription.Name = "lblRiskDescription";
    this.lblRiskDescription.Size = new Size(86, 13);
    this.lblRiskDescription.TabIndex = 200;
    this.lblRiskDescription.Text = "Risk Description:";
    this.lblRiskDescription.TextAlign = ContentAlignment.MiddleRight;
    appearance23.BackColor = Color.White;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance23.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtRiskDescription).Appearance = (AppearanceBase) appearance23;
    ((TextEditorControlBase) this.txtRiskDescription).BackColor = Color.White;
    ((Control) this.txtRiskDescription).Location = new Point(320, 7);
    ((TextEditorControlBase) this.txtRiskDescription).MaxLength = 1000;
    this.txtRiskDescription.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.txtRiskDescription).Multiline = true;
    ((Control) this.txtRiskDescription).Name = "txtRiskDescription";
    ((Control) this.txtRiskDescription).Size = new Size(241, 73);
    ((Control) this.txtRiskDescription).TabIndex = 7;
    ((UltraControlBase) this.txtRiskDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRiskDescription).UseOsThemes = (DefaultableBoolean) 2;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numPreviousPremium).Appearance = (AppearanceBase) appearance24;
    ((UltraNumericEditorBase) this.numPreviousPremium).FormatString = "c";
    ((Control) this.numPreviousPremium).Location = new Point(125, 2);
    ((UltraNumericEditor) this.numPreviousPremium).MaskInput = "nnnnnnnnn.nn";
    this.numPreviousPremium.MGAStyle = (MGAStyles) 2;
    ((Control) this.numPreviousPremium).Name = "numPreviousPremium";
    ((UltraNumericEditor) this.numPreviousPremium).Nullable = true;
    ((UltraNumericEditor) this.numPreviousPremium).NumericType = (NumericType) 1;
    ((Control) this.numPreviousPremium).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.numPreviousPremium).TabIndex = 0;
    ((UltraControlBase) this.numPreviousPremium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numPreviousPremium).UseOsThemes = (DefaultableBoolean) 2;
    this.Label21.AutoSize = true;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Location = new Point(5, 6);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(95, 13);
    this.Label21.TabIndex = 195;
    this.Label21.Text = "Previous Premium:";
    this.Label21.TextAlign = ContentAlignment.MiddleRight;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numTargetPremium).Appearance = (AppearanceBase) appearance25;
    ((UltraNumericEditorBase) this.numTargetPremium).FormatString = "c";
    ((Control) this.numTargetPremium).Location = new Point(125, 25);
    ((UltraNumericEditor) this.numTargetPremium).MaskInput = "nnnnnnnnn.nn";
    this.numTargetPremium.MGAStyle = (MGAStyles) 2;
    ((Control) this.numTargetPremium).Name = "numTargetPremium";
    ((UltraNumericEditor) this.numTargetPremium).Nullable = true;
    ((UltraNumericEditor) this.numTargetPremium).NumericType = (NumericType) 1;
    ((Control) this.numTargetPremium).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.numTargetPremium).TabIndex = 1;
    ((UltraControlBase) this.numTargetPremium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numTargetPremium).UseOsThemes = (DefaultableBoolean) 2;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numMinimumEarned).Appearance = (AppearanceBase) appearance26;
    ((UltraNumericEditorBase) this.numMinimumEarned).FormatString = "p";
    ((Control) this.numMinimumEarned).Location = new Point(125, 48 /*0x30*/);
    ((UltraNumericEditor) this.numMinimumEarned).MaskInput = "nnn.nnnn";
    this.numMinimumEarned.MGAStyle = (MGAStyles) 2;
    ((Control) this.numMinimumEarned).Name = "numMinimumEarned";
    ((UltraNumericEditor) this.numMinimumEarned).Nullable = true;
    ((UltraNumericEditor) this.numMinimumEarned).NumericType = (NumericType) 1;
    ((Control) this.numMinimumEarned).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.numMinimumEarned).TabIndex = 2;
    ((UltraControlBase) this.numMinimumEarned).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numMinimumEarned).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboEarnedPremiumType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboEarnedPremiumType).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboEarnedPremiumType).DropDownWidth = 200;
    ((Control) this.cboEarnedPremiumType).Location = new Point(125, 94);
    this.cboEarnedPremiumType.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboEarnedPremiumType).Name = "cboEarnedPremiumType";
    ((Control) this.cboEarnedPremiumType).Size = new Size(123, 21);
    ((Control) this.cboEarnedPremiumType).TabIndex = 4;
    ((UltraControlBase) this.cboEarnedPremiumType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboEarnedPremiumType).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tabEndorsement).Controls.Add((Control) this.txtEndorsementComment);
    ((Control) this.tabEndorsement).Controls.Add((Control) this.dtEndorsement);
    ((Control) this.tabEndorsement).Controls.Add((Control) this.Label16);
    ((Control) this.tabEndorsement).Controls.Add((Control) this.Label15);
    ((Control) this.tabEndorsement).Location = new Point(-10000, -10000);
    ((Control) this.tabEndorsement).Name = "tabEndorsement";
    ((Control) this.tabEndorsement).Size = new Size(791, 160 /*0xA0*/);
    appearance27.BackColor = Color.White;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEndorsementComment).Appearance = (AppearanceBase) appearance27;
    ((TextEditorControlBase) this.txtEndorsementComment).BackColor = Color.White;
    ((Control) this.txtEndorsementComment).Location = new Point(144 /*0x90*/, 48 /*0x30*/);
    this.txtEndorsementComment.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtEndorsementComment).Name = "txtEndorsementComment";
    ((Control) this.txtEndorsementComment).Size = new Size(252, 20);
    ((Control) this.txtEndorsementComment).TabIndex = 1;
    ((UltraControlBase) this.txtEndorsementComment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEndorsementComment).UseOsThemes = (DefaultableBoolean) 2;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtEndorsement).Appearance = (AppearanceBase) appearance28;
    appearance29.AlphaLevel = (short) 14;
    appearance29.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance29.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance29.BackColorAlpha = (Alpha) 2;
    appearance29.BackGradientAlignment = (GradientAlignment) 4;
    appearance29.BackGradientStyle = (GradientStyle) 5;
    appearance29.BorderAlpha = (Alpha) 1;
    appearance29.BorderColor = Color.FromArgb(78, 122, 171);
    appearance29.ForeColor = Color.FromArgb(49, 85, 153);
    appearance29.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtEndorsement).ButtonAppearance = (AppearanceBase) appearance29;
    ((UltraDateTimeEditor) this.dtEndorsement).DateTime = new DateTime(2004, 3, 8, 13, 49, 23, 321);
    ((Control) this.dtEndorsement).Location = new Point(144 /*0x90*/, 16 /*0x10*/);
    this.dtEndorsement.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtEndorsement).Name = "dtEndorsement";
    ((Control) this.dtEndorsement).Size = new Size(105, 20);
    ((Control) this.dtEndorsement).TabIndex = 0;
    ((UltraControlBase) this.dtEndorsement).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEndorsement).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtEndorsement).Value = (object) new DateTime(2004, 3, 8, 13, 49, 23, 321);
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(72, 50);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(56, 13);
    this.Label16.TabIndex = 1;
    this.Label16.Text = "Comment:";
    this.Label16.TextAlign = ContentAlignment.MiddleRight;
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(8, 18);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(120, 13);
    this.Label15.TabIndex = 0;
    this.Label15.Text = "Endorsement Effective:";
    this.Label15.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkOpenExpiring);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtExpiringControlNumber);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label25);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkAddCarrier);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkNonRenewed);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label19);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.comboExpiringCarrier);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtExpiringPolicyNumber);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label11);
    ((Control) this.UltraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(791, 160 /*0xA0*/);
    this.lnkOpenExpiring.AutoSize = true;
    this.lnkOpenExpiring.BackColor = Color.Transparent;
    this.lnkOpenExpiring.Location = new Point(215, 124);
    this.lnkOpenExpiring.Name = "lnkOpenExpiring";
    this.lnkOpenExpiring.Size = new Size(74, 13);
    this.lnkOpenExpiring.TabIndex = 207;
    this.lnkOpenExpiring.TabStop = true;
    this.lnkOpenExpiring.Text = "Open Expiring";
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtExpiringControlNumber).Appearance = (AppearanceBase) appearance30;
    ((UltraNumericEditorBase) this.txtExpiringControlNumber).FormatString = "";
    ((Control) this.txtExpiringControlNumber).Location = new Point(111, 121);
    this.txtExpiringControlNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtExpiringControlNumber).Name = "txtExpiringControlNumber";
    ((UltraNumericEditor) this.txtExpiringControlNumber).Nullable = true;
    ((UltraNumericEditorBase) this.txtExpiringControlNumber).PromptChar = ' ';
    ((Control) this.txtExpiringControlNumber).Size = new Size(98, 20);
    ((Control) this.txtExpiringControlNumber).TabIndex = 206;
    ((UltraWinEditorMaskedControlBase) this.txtExpiringControlNumber).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.txtExpiringControlNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtExpiringControlNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraNumericEditor) this.txtExpiringControlNumber).Value = (object) null;
    this.lnkAddCarrier.AutoSize = true;
    this.lnkAddCarrier.BackColor = Color.Transparent;
    this.lnkAddCarrier.Location = new Point(461, 46);
    this.lnkAddCarrier.Name = "lnkAddCarrier";
    this.lnkAddCarrier.Size = new Size(86, 13);
    this.lnkAddCarrier.TabIndex = 203;
    this.lnkAddCarrier.TabStop = true;
    this.lnkAddCarrier.Text = "Add New Carrier";
    appearance31.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance31.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkNonRenewed).Appearance = (AppearanceBase) appearance31;
    ((UltraToggleEditorBase) this.chkNonRenewed).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkNonRenewed).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkNonRenewed).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkNonRenewed).Location = new Point(111, 72);
    this.chkNonRenewed.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkNonRenewed).Name = "chkNonRenewed";
    ((Control) this.chkNonRenewed).Size = new Size(120, 20);
    ((Control) this.chkNonRenewed).TabIndex = 202;
    ((UltraToggleEditorBase) this.chkNonRenewed).Text = "Non-Renewed";
    ((UltraControlBase) this.chkNonRenewed).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkNonRenewed).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.comboExpiringCarrier).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboExpiringCarrier).DataMember = "ExpiringCarriers";
    ((UltraGridBase) this.comboExpiringCarrier).DataSource = (object) this.dsQuoteEdit;
    ((UltraDropDownBase) this.comboExpiringCarrier).DisplayMember = "LocationName";
    ((UltraCombo) this.comboExpiringCarrier).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboExpiringCarrier).Location = new Point(111, 38);
    this.comboExpiringCarrier.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboExpiringCarrier).Name = "comboExpiringCarrier";
    ((Control) this.comboExpiringCarrier).Size = new Size(329, 21);
    ((Control) this.comboExpiringCarrier).TabIndex = 200;
    ((UltraControlBase) this.comboExpiringCarrier).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboExpiringCarrier).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboExpiringCarrier).ValueMember = "CompanyLocationGuid";
    appearance32.BackColor = Color.White;
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance32.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtExpiringPolicyNumber).Appearance = (AppearanceBase) appearance32;
    ((TextEditorControlBase) this.txtExpiringPolicyNumber).BackColor = Color.White;
    ((Control) this.txtExpiringPolicyNumber).Location = new Point(111, 12);
    this.txtExpiringPolicyNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtExpiringPolicyNumber).Name = "txtExpiringPolicyNumber";
    ((Control) this.txtExpiringPolicyNumber).Size = new Size(160 /*0xA0*/, 20);
    ((Control) this.txtExpiringPolicyNumber).TabIndex = 8;
    ((UltraControlBase) this.txtExpiringPolicyNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtExpiringPolicyNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tabKYTaxLocation).Controls.Add((Control) this.ctlKYTaxLocation);
    ((Control) this.tabKYTaxLocation).Location = new Point(-10000, -10000);
    ((Control) this.tabKYTaxLocation).Name = "tabKYTaxLocation";
    ((Control) this.tabKYTaxLocation).Size = new Size(791, 160 /*0xA0*/);
    this.ctlKYTaxLocation.Address1 = "";
    this.ctlKYTaxLocation.Address2 = "";
    ((Control) this.ctlKYTaxLocation).BackColor = Color.Transparent;
    this.ctlKYTaxLocation.City = "";
    this.ctlKYTaxLocation.County = "";
    ((Control) this.ctlKYTaxLocation).Font = new Font("Tahoma", 8f);
    this.ctlKYTaxLocation.ISOCountryCode = "";
    this.ctlKYTaxLocation.ISOCountryCodeMember = "";
    this.ctlKYTaxLocation.ISOCountryList = (object) null;
    this.ctlKYTaxLocation.ISOCountryNameMember = "";
    ((Control) this.ctlKYTaxLocation).Location = new Point(4, -29);
    this.ctlKYTaxLocation.MGAStyle = (MGAStyles) 2;
    ((Control) this.ctlKYTaxLocation).Name = "ctlKYTaxLocation";
    this.ctlKYTaxLocation.Password = "";
    ((Control) this.ctlKYTaxLocation).Size = new Size(265, 156);
    this.ctlKYTaxLocation.State = "";
    ((Control) this.ctlKYTaxLocation).TabIndex = 202;
    this.ctlKYTaxLocation.UserID = "";
    this.ctlKYTaxLocation.WebserviceUrl = (string) null;
    this.ctlKYTaxLocation.ZipCode = "";
    this.ctlKYTaxLocation.ZipCodeExtension = "";
    ((Control) this.btnNext).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance33.BackColor = Color.Gainsboro;
    appearance33.BackColor2 = Color.White;
    appearance33.BackGradientStyle = (GradientStyle) 2;
    appearance33.ImageHAlign = (HAlign) 3;
    ((ControlBase) this.btnNext).Appearance = (AppearanceBase) appearance33;
    ((Control) this.btnNext).Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnNext).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnNext).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNext).Location = new Point(704, 364);
    ((Control) this.btnNext).Name = "btnNext";
    ((ControlBase) this.btnNext).Padding = new Size(5, 0);
    ((Control) this.btnNext).Size = new Size(96 /*0x60*/, 36);
    ((Control) this.btnNext).TabIndex = 2;
    ((ControlBase) this.btnNext).Text = "Next";
    this.Tip.SetToolTip((Control) this.btnNext, "Save Quote");
    this.btnNext.UseOSThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.daQuoteDetails.AcceptChangesDuringUpdate = false;
    this.daQuoteDetails.DeleteCommand = this.DbDeleteCommand2;
    this.daQuoteDetails.InsertCommand = this.DbInsertCommand2;
    this.daQuoteDetails.SelectCommand = this.DbSelectCommand3;
    this.daQuoteDetails.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteDetails", new DataColumnMapping[8]
      {
        new DataColumnMapping("QuoteGuid", "QuoteGuid"),
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid"),
        new DataColumnMapping("CompanyContactGuid", "CompanyContactGuid"),
        new DataColumnMapping("CompanyCommission", "CompanyCommission"),
        new DataColumnMapping("ProducerCommission", "ProducerCommission"),
        new DataColumnMapping("Participation", "Participation"),
        new DataColumnMapping("TermsOfPayment", "TermsOfPayment"),
        new DataColumnMapping("IntermediaryContactGuid", "IntermediaryContactGuid")
      })
    });
    this.daQuoteDetails.UpdateCommand = this.DbUpdateCommand2;
    this.DbDeleteCommand2.CommandText = "DELETE FROM [tblQuoteDetails] WHERE (([QuoteGuid] = @Original_QuoteGuid) AND ([CompanyLineGuid] = @Original_CompanyLineGuid))";
    this.DbDeleteCommand2.Connection = this.cnDB;
    this.DbDeleteCommand2.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@Original_QuoteGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompanyLineGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand2.CommandText = componentResourceManager.GetString("DbInsertCommand2.CommandText");
    this.DbInsertCommand2.Connection = this.cnDB;
    this.DbInsertCommand2.Parameters.AddRange((Array) new DbParameter[10]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid"),
      DefaultDatabase.CreateParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      DefaultDatabase.CreateParameter("@CompanyContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyContactGuid"),
      DefaultDatabase.CreateParameter("@CompanyCommission", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 11, (byte) 10, "CompanyCommission", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@ProducerCommission", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 11, (byte) 10, "ProducerCommission", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@Participation", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 5, "Participation", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@TermsOfPayment", SqlDbType.SmallInt, 2, "TermsOfPayment"),
      DefaultDatabase.CreateParameter("@IntermediaryContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "IntermediaryContactGuid"),
      DefaultDatabase.CreateParameter("@ProgramID", SqlDbType.Int, 4, "ProgramID"),
      DefaultDatabase.CreateParameter("@SLA_Number", SqlDbType.VarChar, 50, "SLA_Number")
    });
    this.DbSelectCommand3.CommandText = componentResourceManager.GetString("DbSelectCommand3.CommandText");
    this.DbSelectCommand3.Connection = this.cnDB;
    this.DbSelectCommand3.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid")
    });
    this.DbUpdateCommand2.CommandText = componentResourceManager.GetString("DbUpdateCommand2.CommandText");
    this.DbUpdateCommand2.Connection = this.cnDB;
    this.DbUpdateCommand2.Parameters.AddRange((Array) new DbParameter[12]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid"),
      DefaultDatabase.CreateParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      DefaultDatabase.CreateParameter("@CompanyContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyContactGuid"),
      DefaultDatabase.CreateParameter("@CompanyCommission", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 11, (byte) 10, "CompanyCommission", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@ProducerCommission", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 11, (byte) 10, "ProducerCommission", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@Participation", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 5, "Participation", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@TermsOfPayment", SqlDbType.SmallInt, 2, "TermsOfPayment"),
      DefaultDatabase.CreateParameter("@IntermediaryContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "IntermediaryContactGuid"),
      DefaultDatabase.CreateParameter("@ProgramID", SqlDbType.Int, 4, "ProgramID"),
      DefaultDatabase.CreateParameter("@SLA_Number", SqlDbType.VarChar, 50, "SLA_Number"),
      DefaultDatabase.CreateParameter("@Original_QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null)
    });
    this.daQuotes.AcceptChangesDuringUpdate = false;
    this.daQuotes.DeleteCommand = this.DbDeleteCommand1;
    this.daQuotes.InsertCommand = this.DbInsertCommand1;
    this.daQuotes.SelectCommand = this.DbSelectCommand1;
    this.daQuotes.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuotes", new DataColumnMapping[35]
      {
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("UnderwriterUserGuid", "UnderwriterUserGuid"),
        new DataColumnMapping("LineGUID", "LineGUID"),
        new DataColumnMapping("CompanyLocationGuid", "CompanyLocationGuid"),
        new DataColumnMapping("EffectiveDate", "EffectiveDate"),
        new DataColumnMapping("ExpirationDate", "ExpirationDate"),
        new DataColumnMapping("QuotingLocationGuid", "QuotingLocationGuid"),
        new DataColumnMapping("IssuingLocationGuid", "IssuingLocationGuid"),
        new DataColumnMapping("ProducerContactGuid", "ProducerContactGuid"),
        new DataColumnMapping("PolicyTypeID", "PolicyTypeID"),
        new DataColumnMapping("DateCreated", "DateCreated"),
        new DataColumnMapping("SubmissionGroupGuid", "SubmissionGroupGuid"),
        new DataColumnMapping("QuoteGUID", "QuoteGUID"),
        new DataColumnMapping("BillingTypeID", "BillingTypeID"),
        new DataColumnMapping("ControlNo", "ControlNo"),
        new DataColumnMapping("TACSRUserGuid", "TACSRUserGuid"),
        new DataColumnMapping("EndorsementEffective", "EndorsementEffective"),
        new DataColumnMapping("EndorsementComment", "EndorsementComment"),
        new DataColumnMapping("FinanceCompanyGuid", "FinanceCompanyGuid"),
        new DataColumnMapping("ControlGuid", "ControlGuid"),
        new DataColumnMapping("RetailerGuid", "RetailerGuid"),
        new DataColumnMapping("MinimumEarnedPercentage", "MinimumEarnedPercentage"),
        new DataColumnMapping("AccountNumber", "AccountNumber"),
        new DataColumnMapping("CostCenterID", "CostCenterID"),
        new DataColumnMapping("InspectionCompanyID", "InspectionCompanyID"),
        new DataColumnMapping("SIC_Code", "SIC_Code"),
        new DataColumnMapping("QuickQuote", "QuickQuote"),
        new DataColumnMapping("PreviousPremium", "PreviousPremium"),
        new DataColumnMapping("TargetPremium", "TargetPremium"),
        new DataColumnMapping("ExpiringPolicyNumber", "ExpiringPolicyNumber"),
        new DataColumnMapping("RiskDescription", "RiskDescription"),
        new DataColumnMapping("UnderwritingAssistantGuid", "UnderwritingAssistantGuid"),
        new DataColumnMapping("ProducerLocationID", "ProducerLocationID"),
        new DataColumnMapping("RenewalOfQuoteGuid", "RenewalOfQuoteGuid"),
        new DataColumnMapping("RenewalOfControlNum", "RenewalOfControlNum")
      })
    });
    this.daQuotes.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = "DELETE FROM tblQuotes WHERE (QuoteGUID = @Original_QuoteGUID)";
    this.DbDeleteCommand1.Connection = this.cnDB;
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteGUID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Connection = this.cnDB;
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[39]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      DefaultDatabase.CreateParameter("@UnderwriterUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UnderwriterUserGuid"),
      DefaultDatabase.CreateParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID"),
      DefaultDatabase.CreateParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGuid"),
      DefaultDatabase.CreateParameter("@EffectiveDate", SqlDbType.SmallDateTime, 4, "EffectiveDate"),
      DefaultDatabase.CreateParameter("@ExpirationDate", SqlDbType.SmallDateTime, 4, "ExpirationDate"),
      DefaultDatabase.CreateParameter("@QuotingLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuotingLocationGuid"),
      DefaultDatabase.CreateParameter("@IssuingLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "IssuingLocationGuid"),
      DefaultDatabase.CreateParameter("@ProducerContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerContactGuid"),
      DefaultDatabase.CreateParameter("@PolicyTypeID", SqlDbType.TinyInt, 1, "PolicyTypeID"),
      DefaultDatabase.CreateParameter("@DateCreated", SqlDbType.DateTime, 8, "DateCreated"),
      DefaultDatabase.CreateParameter("@SubmissionGroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "SubmissionGroupGuid"),
      DefaultDatabase.CreateParameter("@QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      DefaultDatabase.CreateParameter("@BillingTypeID", SqlDbType.TinyInt, 1, "BillingTypeID"),
      DefaultDatabase.CreateParameter("@ControlNo", SqlDbType.Int, 4, "ControlNo"),
      DefaultDatabase.CreateParameter("@TACSRUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "TACSRUserGuid"),
      DefaultDatabase.CreateParameter("@EndorsementEffective", SqlDbType.SmallDateTime, 4, "EndorsementEffective"),
      DefaultDatabase.CreateParameter("@EndorsementComment", SqlDbType.VarChar, 250, "EndorsementComment"),
      DefaultDatabase.CreateParameter("@FinanceCompanyGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "FinanceCompanyGuid"),
      DefaultDatabase.CreateParameter("@ControlGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ControlGuid"),
      DefaultDatabase.CreateParameter("@RetailerGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "RetailerGuid"),
      DefaultDatabase.CreateParameter("@MinimumEarnedPercentage", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 5, (byte) 4, "MinimumEarnedPercentage", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@AccountNumber", SqlDbType.VarChar, 20, "AccountNumber"),
      DefaultDatabase.CreateParameter("@CostCenterID", SqlDbType.Int, 4, "CostCenterID"),
      DefaultDatabase.CreateParameter("@InspectionCompanyID", SqlDbType.Int, 4, "InspectionCompanyID"),
      DefaultDatabase.CreateParameter("@SIC_Code", SqlDbType.Char, 4, "SIC_Code"),
      DefaultDatabase.CreateParameter("@QuickQuote", SqlDbType.Bit, 1, "QuickQuote"),
      DefaultDatabase.CreateParameter("@PreviousPremium", SqlDbType.Money, 8, "PreviousPremium"),
      DefaultDatabase.CreateParameter("@TargetPremium", SqlDbType.Money, 8, "TargetPremium"),
      DefaultDatabase.CreateParameter("@ExpiringPolicyNumber", SqlDbType.VarChar, 50, "ExpiringPolicyNumber"),
      DefaultDatabase.CreateParameter("@RiskDescription", SqlDbType.VarChar, 1000, "RiskDescription"),
      DefaultDatabase.CreateParameter("@UnderwritingAssistantGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UnderwritingAssistantGuid"),
      DefaultDatabase.CreateParameter("@ProducerLocationID", SqlDbType.Int, 4, "ProducerLocationID"),
      DefaultDatabase.CreateParameter("@SecProducerContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "SecProducerContactGuid"),
      DefaultDatabase.CreateParameter("@EarnedPremiumTypeID", SqlDbType.TinyInt, 1, "EarnedPremiumTypeID"),
      DefaultDatabase.CreateParameter("@Auditable", SqlDbType.Bit, 1, "Auditable"),
      DefaultDatabase.CreateParameter("@NAICSCode", SqlDbType.VarChar, 10, "NAICSCode"),
      DefaultDatabase.CreateParameter("@RenewalOfQuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "RenewalOfQuoteGuid"),
      DefaultDatabase.CreateParameter("@RenewalOfControlNum", SqlDbType.Int, 4, "RenewalOfControlNum")
    });
    this.DbSelectCommand1.CommandText = componentResourceManager.GetString("DbSelectCommand1.CommandText");
    this.DbSelectCommand1.Connection = this.cnDB;
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID")
    });
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Connection = this.cnDB;
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[40]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      DefaultDatabase.CreateParameter("@UnderwriterUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UnderwriterUserGuid"),
      DefaultDatabase.CreateParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID"),
      DefaultDatabase.CreateParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGuid"),
      DefaultDatabase.CreateParameter("@EffectiveDate", SqlDbType.SmallDateTime, 4, "EffectiveDate"),
      DefaultDatabase.CreateParameter("@ExpirationDate", SqlDbType.SmallDateTime, 4, "ExpirationDate"),
      DefaultDatabase.CreateParameter("@QuotingLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuotingLocationGuid"),
      DefaultDatabase.CreateParameter("@IssuingLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "IssuingLocationGuid"),
      DefaultDatabase.CreateParameter("@ProducerContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerContactGuid"),
      DefaultDatabase.CreateParameter("@PolicyTypeID", SqlDbType.TinyInt, 1, "PolicyTypeID"),
      DefaultDatabase.CreateParameter("@DateCreated", SqlDbType.DateTime, 8, "DateCreated"),
      DefaultDatabase.CreateParameter("@SubmissionGroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "SubmissionGroupGuid"),
      DefaultDatabase.CreateParameter("@QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      DefaultDatabase.CreateParameter("@BillingTypeID", SqlDbType.TinyInt, 1, "BillingTypeID"),
      DefaultDatabase.CreateParameter("@ControlNo", SqlDbType.Int, 4, "ControlNo"),
      DefaultDatabase.CreateParameter("@TACSRUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "TACSRUserGuid"),
      DefaultDatabase.CreateParameter("@EndorsementEffective", SqlDbType.SmallDateTime, 4, "EndorsementEffective"),
      DefaultDatabase.CreateParameter("@EndorsementComment", SqlDbType.VarChar, 250, "EndorsementComment"),
      DefaultDatabase.CreateParameter("@FinanceCompanyGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "FinanceCompanyGuid"),
      DefaultDatabase.CreateParameter("@ControlGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ControlGuid"),
      DefaultDatabase.CreateParameter("@RetailerGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "RetailerGuid"),
      DefaultDatabase.CreateParameter("@MinimumEarnedPercentage", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 5, (byte) 4, "MinimumEarnedPercentage", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@AccountNumber", SqlDbType.VarChar, 20, "AccountNumber"),
      DefaultDatabase.CreateParameter("@CostCenterID", SqlDbType.Int, 4, "CostCenterID"),
      DefaultDatabase.CreateParameter("@InspectionCompanyID", SqlDbType.Int, 4, "InspectionCompanyID"),
      DefaultDatabase.CreateParameter("@SIC_Code", SqlDbType.Char, 4, "SIC_Code"),
      DefaultDatabase.CreateParameter("@QuickQuote", SqlDbType.Bit, 1, "QuickQuote"),
      DefaultDatabase.CreateParameter("@PreviousPremium", SqlDbType.Money, 8, "PreviousPremium"),
      DefaultDatabase.CreateParameter("@TargetPremium", SqlDbType.Money, 8, "TargetPremium"),
      DefaultDatabase.CreateParameter("@ExpiringPolicyNumber", SqlDbType.VarChar, 50, "ExpiringPolicyNumber"),
      DefaultDatabase.CreateParameter("@RiskDescription", SqlDbType.VarChar, 1000, "RiskDescription"),
      DefaultDatabase.CreateParameter("@UnderwritingAssistantGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UnderwritingAssistantGuid"),
      DefaultDatabase.CreateParameter("@ProducerLocationID", SqlDbType.Int, 4, "ProducerLocationID"),
      DefaultDatabase.CreateParameter("@SecProducerContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "SecProducerContactGuid"),
      DefaultDatabase.CreateParameter("@EarnedPremiumTypeID", SqlDbType.TinyInt, 1, "EarnedPremiumTypeID"),
      DefaultDatabase.CreateParameter("@Auditable", SqlDbType.Bit, 1, "Auditable"),
      DefaultDatabase.CreateParameter("@NAICSCode", SqlDbType.VarChar, 10, "NAICSCode"),
      DefaultDatabase.CreateParameter("@RenewalOfQuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "RenewalOfQuoteGuid"),
      DefaultDatabase.CreateParameter("@RenewalOfControlNum", SqlDbType.Int, 4, "RenewalOfControlNum"),
      DefaultDatabase.CreateParameter("@Original_QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteGUID", DataRowVersion.Original, (object) null)
    });
    ((Control) this.tabPolicyInfo).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.tabPolicyInfo).Controls.Add((Control) this.tabRequiredInfo);
    ((Control) this.tabPolicyInfo).Controls.Add((Control) this.tabOtherInfo);
    ((Control) this.tabPolicyInfo).Controls.Add((Control) this.tabEndorsement);
    ((Control) this.tabPolicyInfo).Controls.Add((Control) this.tabPremiumInfo);
    ((Control) this.tabPolicyInfo).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.tabPolicyInfo).Controls.Add((Control) this.tabKYTaxLocation);
    ((Control) this.tabPolicyInfo).Location = new Point(7, 8);
    ((Control) this.tabPolicyInfo).Name = "tabPolicyInfo";
    ((UltraTabControlBase) this.tabPolicyInfo).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.tabPolicyInfo).Size = new Size(793, 187);
    ((Control) this.tabPolicyInfo).TabIndex = 0;
    ((UltraTabControlBase) this.tabPolicyInfo).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.tabPolicyInfo).TabPadding = new Size(5, 3);
    appearance34.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance50.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance34;
    ultraTab1.Key = "tabRequiredInfo";
    ultraTab1.TabPage = this.tabRequiredInfo;
    ultraTab1.Text = "Required Info";
    appearance35.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance51.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance35;
    ultraTab2.Key = "tabOtherInfo";
    ultraTab2.TabPage = this.tabOtherInfo;
    ultraTab2.Text = "Other Info";
    appearance36.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance52.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance36;
    ultraTab3.Key = "tabPremiumInfo";
    ultraTab3.TabPage = this.tabPremiumInfo;
    ultraTab3.Text = "Premium Info";
    appearance37.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance53.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance37;
    ultraTab4.Key = "tabEndorsement";
    ultraTab4.TabPage = this.tabEndorsement;
    ultraTab4.Text = "Endorsement";
    appearance38.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance54.Image"));
    ultraTab5.Appearance = (AppearanceBase) appearance38;
    ultraTab5.Key = "tabRenewalInfo";
    ultraTab5.TabPage = this.UltraTabPageControl1;
    ultraTab5.Text = "Renewal Info";
    ultraTab6.Key = "KYTaxLocation";
    ultraTab6.TabPage = this.tabKYTaxLocation;
    ultraTab6.Text = "KY Tax Location";
    ultraTab6.Visible = false;
    ((UltraTabControlBase) this.tabPolicyInfo).Tabs.AddRange(new UltraTab[6]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5,
      ultraTab6
    });
    ((UltraTabControlBase) this.tabPolicyInfo).TabSize = new Size(130, 0);
    ((UltraTabControlBase) this.tabPolicyInfo).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(791, 160 /*0xA0*/);
    this.lnkConvertQuickQuote.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkConvertQuickQuote.Location = new Point(5, 384);
    this.lnkConvertQuickQuote.Name = "lnkConvertQuickQuote";
    this.lnkConvertQuickQuote.Size = new Size(272, 16 /*0x10*/);
    this.lnkConvertQuickQuote.TabIndex = 200;
    this.lnkConvertQuickQuote.TabStop = true;
    this.lnkConvertQuickQuote.Text = "To convert this quick quote to a full quote, click here.";
    appearance39.BorderColor = Color.Goldenrod;
    appearance39.ForeColor = Color.Red;
    ((AppearanceBase) appearance39).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance39).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblDisabledItems).Appearance = (AppearanceBase) appearance39;
    ((ControlBase) this.lblDisabledItems).BackColorInternal = Color.LightYellow;
    this.lblDisabledItems.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblDisabledItems).Location = new Point(403, 365);
    ((Control) this.lblDisabledItems).Name = "lblDisabledItems";
    ((Control) this.lblDisabledItems).Size = new Size(238, 35);
    ((Control) this.lblDisabledItems).TabIndex = 201;
    ((ControlBase) this.lblDisabledItems).Text = "Certain items have been disabled because options have been created on this quote.";
    ((UltraControlBase) this.lblDisabledItems).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.lblDisabledItems).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ddProgramCodes).DataMember = "tblCompanyProgramCodes";
    ((UltraGridBase) this.ddProgramCodes).DataSource = (object) this.dsQuoteEdit;
    appearance40.BackColor = Color.White;
    appearance40.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddProgramCodes).DisplayLayout.Appearance = (AppearanceBase) appearance40;
    ultraGridBand5.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn63.Header.VisiblePosition = 0;
    ultraGridColumn63.Hidden = true;
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn64.Header.VisiblePosition = 1;
    ultraGridColumn64.Hidden = true;
    ((HeaderBase) ultraGridColumn65.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn65.Header.VisiblePosition = 2;
    ultraGridColumn65.Hidden = true;
    ((HeaderBase) ultraGridColumn66.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn66.Header.VisiblePosition = 3;
    ultraGridColumn66.Hidden = true;
    ((HeaderBase) ultraGridColumn67.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn67.Header.VisiblePosition = 4;
    ultraGridColumn67.Hidden = true;
    ((HeaderBase) ultraGridColumn68.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn68.Header.VisiblePosition = 5;
    ultraGridColumn68.Hidden = true;
    ((HeaderBase) ultraGridColumn69.Header).Caption = "Prog. Code";
    ((HeaderBase) ultraGridColumn69.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn69.Header.VisiblePosition = 6;
    ultraGridColumn69.Width = 300;
    ((HeaderBase) ultraGridColumn70.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn70.Header.VisiblePosition = 7;
    ultraGridColumn70.Hidden = true;
    ((HeaderBase) ultraGridColumn71.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn71.Header.VisiblePosition = 8;
    ((HeaderBase) ultraGridColumn72.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn72.Header.VisiblePosition = 9;
    ultraGridBand5.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn63,
      (object) ultraGridColumn64,
      (object) ultraGridColumn65,
      (object) ultraGridColumn66,
      (object) ultraGridColumn67,
      (object) ultraGridColumn68,
      (object) ultraGridColumn69,
      (object) ultraGridColumn70,
      (object) ultraGridColumn71,
      (object) ultraGridColumn72
    });
    ((UltraGridBase) this.ddProgramCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ddProgramCodes).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddProgramCodes).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddProgramCodes).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddProgramCodes).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddProgramCodes).DisplayMember = "ProgCode";
    ((UltraDropDownBase) this.ddProgramCodes).DropDownWidth = 300;
    ((Control) this.ddProgramCodes).Location = new Point(191, 292);
    ((Control) this.ddProgramCodes).Name = "ddProgramCodes";
    ((Control) this.ddProgramCodes).Size = new Size(203, 57);
    ((Control) this.ddProgramCodes).TabIndex = 202;
    ((UltraDropDownBase) this.ddProgramCodes).ValueMember = "ProgramID";
    ((Control) this.ddProgramCodes).Visible = false;
    ((UltraGridBase) this.ddIntermediaryContacts).DataSource = (object) this.dsQuoteEdit.tblIntermediaryContacts;
    appearance41.BackColor = Color.White;
    appearance41.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddIntermediaryContacts).DisplayLayout.Appearance = (AppearanceBase) appearance41;
    ultraGridBand6.ColHeadersVisible = false;
    ultraGridColumn73.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn73.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn73.Header.VisiblePosition = 0;
    ultraGridColumn73.Hidden = true;
    ultraGridColumn74.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn74.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn74.Header.VisiblePosition = 1;
    ultraGridColumn74.Width = 212;
    ultraGridColumn75.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn75.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn75.Header.VisiblePosition = 2;
    ultraGridColumn75.Hidden = true;
    ultraGridBand6.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn73,
      (object) ultraGridColumn74,
      (object) ultraGridColumn75
    });
    ((UltraGridBase) this.ddIntermediaryContacts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.ddIntermediaryContacts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddIntermediaryContacts).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddIntermediaryContacts).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddIntermediaryContacts).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddIntermediaryContacts).DisplayMember = "Name";
    ((Control) this.ddIntermediaryContacts).Location = new Point(240 /*0xF0*/, 304);
    ((Control) this.ddIntermediaryContacts).Name = "ddIntermediaryContacts";
    ((Control) this.ddIntermediaryContacts).Size = new Size(216, 40);
    ((Control) this.ddIntermediaryContacts).TabIndex = 198;
    ((UltraDropDownBase) this.ddIntermediaryContacts).ValueMember = "IntermediaryContactGuid";
    ((Control) this.ddIntermediaryContacts).Visible = false;
    ((UltraGridBase) this.ddCompanyContacts).DataSource = (object) this.dsQuoteEdit.tblCompanyContacts;
    appearance42.BackColor = Color.White;
    appearance42.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddCompanyContacts).DisplayLayout.Appearance = (AppearanceBase) appearance42;
    ultraGridBand7.ColHeadersVisible = false;
    ultraGridColumn76.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn76.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn76.Header.VisiblePosition = 0;
    ultraGridColumn76.Hidden = true;
    ultraGridColumn77.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn77.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn77.Header.VisiblePosition = 1;
    ultraGridColumn77.Width = 212;
    ultraGridColumn78.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn78.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn78.Header.VisiblePosition = 2;
    ultraGridColumn78.Hidden = true;
    ultraGridBand7.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn76,
      (object) ultraGridColumn77,
      (object) ultraGridColumn78
    });
    ((UltraGridBase) this.ddCompanyContacts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    ((UltraGridBase) this.ddCompanyContacts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddCompanyContacts).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddCompanyContacts).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddCompanyContacts).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddCompanyContacts).DisplayMember = "Name";
    ((Control) this.ddCompanyContacts).Location = new Point(16 /*0x10*/, 304);
    ((Control) this.ddCompanyContacts).Name = "ddCompanyContacts";
    ((Control) this.ddCompanyContacts).Size = new Size(216, 40);
    ((Control) this.ddCompanyContacts).TabIndex = 196;
    ((UltraDropDownBase) this.ddCompanyContacts).ValueMember = "CompanyContactGuid";
    ((Control) this.ddCompanyContacts).Visible = false;
    ((UltraGridBase) this.ugPolicyDetail).DataSource = (object) this.dsQuoteEdit.tblQuoteDetails;
    appearance43.BackColor = Color.White;
    appearance43.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Appearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn79.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn79.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn79.Header.VisiblePosition = 0;
    ultraGridColumn79.Hidden = true;
    ultraGridColumn79.Width = 105;
    ultraGridColumn80.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn80.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn80.Header.VisiblePosition = 1;
    ultraGridColumn80.Hidden = true;
    ultraGridColumn80.Width = 108;
    ultraGridColumn81.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn81.Header).Caption = "Company Contact";
    ((HeaderBase) ultraGridColumn81.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn81.Header.VisiblePosition = 3;
    ultraGridColumn81.Style = (ColumnStyle) 6;
    ultraGridColumn81.Width = 227;
    ultraGridColumn82.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn82.Header).Caption = "Intermediary Contact";
    ((HeaderBase) ultraGridColumn82.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn82.Header.VisiblePosition = 4;
    ultraGridColumn82.Style = (ColumnStyle) 6;
    ultraGridColumn82.Width = 175;
    ultraGridColumn83.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance44).TextHAlignAsString = "Right";
    ultraGridColumn83.CellAppearance = (AppearanceBase) appearance44;
    ultraGridColumn83.CellClickAction = (CellClickAction) 4;
    ultraGridColumn83.Format = "P4";
    ((AppearanceBase) appearance45).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn83.Header).Appearance = (AppearanceBase) appearance45;
    ((HeaderBase) ultraGridColumn83.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn83.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn83.Header.VisiblePosition = 5;
    ultraGridColumn83.Width = 79;
    ultraGridColumn84.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance46).TextHAlignAsString = "Right";
    ultraGridColumn84.CellAppearance = (AppearanceBase) appearance46;
    ultraGridColumn84.CellClickAction = (CellClickAction) 4;
    ultraGridColumn84.Format = "p4";
    ((AppearanceBase) appearance47).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn84.Header).Appearance = (AppearanceBase) appearance47;
    ((HeaderBase) ultraGridColumn84.Header).Caption = "Producer";
    ((HeaderBase) ultraGridColumn84.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn84.Header.VisiblePosition = 6;
    ultraGridColumn84.Width = 77;
    ultraGridColumn85.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn85.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn85.Header.VisiblePosition = 7;
    ultraGridColumn85.Hidden = true;
    ultraGridColumn85.Width = 89;
    ultraGridColumn86.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn86.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn86.Header.VisiblePosition = 8;
    ultraGridColumn86.Hidden = true;
    ultraGridColumn86.Width = 197;
    ultraGridColumn87.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn87.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn87.Header.VisiblePosition = 9;
    ultraGridColumn87.Hidden = true;
    ultraGridColumn87.Width = 177;
    ultraGridColumn88.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn88.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn88.Header).Caption = "Company / Line / State";
    ((HeaderBase) ultraGridColumn88.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn88.Header.VisiblePosition = 2;
    ultraGridColumn88.Width = 170;
    ((HeaderBase) ultraGridColumn89.Header).Caption = "Prog. Code";
    ((HeaderBase) ultraGridColumn89.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn89.Header.VisiblePosition = 10;
    ultraGridColumn89.Style = (ColumnStyle) 6;
    ultraGridColumn89.Width = 63 /*0x3F*/;
    ((HeaderBase) ultraGridColumn90.Header).Caption = "SLA #";
    ((HeaderBase) ultraGridColumn90.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn90.Header.VisiblePosition = 11;
    ultraGridColumn90.Hidden = true;
    ultraGridColumn90.Width = 88;
    ultraGridBand8.Columns.AddRange(new object[12]
    {
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
      (object) ultraGridColumn90
    });
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.BandsSerializer.Add((object) ultraGridBand8);
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance48.BackColor = Color.LightSteelBlue;
    appearance48.FontData.SizeInPoints = 10f;
    appearance48.ForeColor = Color.Black;
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance48;
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance49.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance49;
    appearance50.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance50;
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance51.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance51;
    appearance52.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance52;
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance53.BackColor = Color.Transparent;
    appearance53.ForeColor = Color.Black;
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Override.SelectedCellAppearance = (AppearanceBase) appearance53;
    appearance54.BackColor = Color.Transparent;
    appearance54.ForeColor = Color.Black;
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance54;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((Control) this.ugPolicyDetail).Location = new Point(7, 200);
    ((Control) this.ugPolicyDetail).Name = "ugPolicyDetail";
    ((Control) this.ugPolicyDetail).Size = new Size(793, 109);
    ((Control) this.ugPolicyDetail).TabIndex = 1;
    ((UltraControlBase) this.ugPolicyDetail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugPolicyDetail).UseOsThemes = (DefaultableBoolean) 2;
    this.Label32.AutoSize = true;
    this.Label32.BackColor = Color.Transparent;
    this.Label32.Location = new Point(293, 52);
    this.Label32.Name = "Label32";
    this.Label32.Size = new Size(110, 13);
    this.Label32.TabIndex = 195;
    this.Label32.Text = "Settlement Currency:";
    this.Label32.TextAlign = ContentAlignment.MiddleRight;
    ((Form) this).AutoScaleBaseSize = new Size(5, 14);
    ((Form) this).BackColor = Color.White;
    ((Form) this).ClientSize = new Size(812, 403);
    ((Control) this).Controls.Add((Control) this.ddProgramCodes);
    ((Control) this).Controls.Add((Control) this.ugPolicyDetail);
    ((Control) this).Controls.Add((Control) this.lblDisabledItems);
    ((Control) this).Controls.Add((Control) this.lnkConvertQuickQuote);
    ((Control) this).Controls.Add((Control) this.btnNext);
    ((Control) this).Controls.Add((Control) this.ddIntermediaryContacts);
    ((Control) this).Controls.Add((Control) this.ddCompanyContacts);
    ((Control) this).Controls.Add((Control) this.tabPolicyInfo);
    ((Control) this).DoubleBuffered = true;
    ((Control) this).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this).ForeColor = Color.Black;
    ((Form) this).FormBorderStyle = FormBorderStyle.FixedSingle;
    ((Form) this).MaximizeBox = false;
    ((Control) this).Name = nameof (frmQuoteEdit);
    ((Control) this.tabRequiredInfo).ResumeLayout(false);
    ((Control) this.tabRequiredInfo).PerformLayout();
    ((ISupportInitialize) this.cboSettlementCurrency).EndInit();
    this.dvQuotingOffice.EndInit();
    this.dsQuoteEdit.EndInit();
    ((ISupportInitialize) this.comboCurrencyCode).EndInit();
    ((ISupportInitialize) this.dtExpirationDate).EndInit();
    ((ISupportInitialize) this.dtEffectiveDate).EndInit();
    ((ISupportInitialize) this.cboCompanies).EndInit();
    ((ISupportInitialize) this.cboIssuingOffice).EndInit();
    ((ISupportInitialize) this.cboQuotingOffice).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((ISupportInitialize) this.cboUnderwriter).EndInit();
    ((ISupportInitialize) this.cboLine).EndInit();
    ((ISupportInitialize) this.cboBillingTypes).EndInit();
    ((ISupportInitialize) this.cboPolicyType).EndInit();
    ((Control) this.tabOtherInfo).ResumeLayout(false);
    ((Control) this.tabOtherInfo).PerformLayout();
    ((ISupportInitialize) this.cboRetailerContact).EndInit();
    ((ISupportInitialize) this.cboNAICSCode).EndInit();
    this.dvNAICS.EndInit();
    ((ISupportInitialize) this.cboSecProducerContact).EndInit();
    ((ISupportInitialize) this.cboUnderwritingAssistant).EndInit();
    ((ISupportInitialize) this.cboInspectionCompanies).EndInit();
    ((ISupportInitialize) this.cboFinanceCompany).EndInit();
    ((ISupportInitialize) this.cboProducerContact).EndInit();
    ((ISupportInitialize) this.cboRiskClass).EndInit();
    this.dvSIC.EndInit();
    ((ISupportInitialize) this.cboTA).EndInit();
    ((ISupportInitialize) this.txtAccountNum).EndInit();
    ((Control) this.tabPremiumInfo).ResumeLayout(false);
    ((Control) this.tabPremiumInfo).PerformLayout();
    ((ISupportInitialize) this.numFacultativePercentage).EndInit();
    ((ISupportInitialize) this.numMinimumEarnedAmount).EndInit();
    ((ISupportInitialize) this.dateNeededBy).EndInit();
    ((ISupportInitialize) this.numExchangeRate).EndInit();
    ((ISupportInitialize) this.gbPleaseWait).EndInit();
    ((Control) this.gbPleaseWait).ResumeLayout(false);
    ((Control) this.gbPleaseWait).PerformLayout();
    ((ISupportInitialize) this.chkFacultative).EndInit();
    ((ISupportInitialize) this.numMinCancellationDays).EndInit();
    ((ISupportInitialize) this.optionAuditable).EndInit();
    ((ISupportInitialize) this.txtRiskDescription).EndInit();
    ((ISupportInitialize) this.numPreviousPremium).EndInit();
    ((ISupportInitialize) this.numTargetPremium).EndInit();
    ((ISupportInitialize) this.numMinimumEarned).EndInit();
    ((ISupportInitialize) this.cboEarnedPremiumType).EndInit();
    ((Control) this.tabEndorsement).ResumeLayout(false);
    ((Control) this.tabEndorsement).PerformLayout();
    ((ISupportInitialize) this.txtEndorsementComment).EndInit();
    ((ISupportInitialize) this.dtEndorsement).EndInit();
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.txtExpiringControlNumber).EndInit();
    ((ISupportInitialize) this.chkNonRenewed).EndInit();
    ((ISupportInitialize) this.comboExpiringCarrier).EndInit();
    ((ISupportInitialize) this.txtExpiringPolicyNumber).EndInit();
    ((Control) this.tabKYTaxLocation).ResumeLayout(false);
    ((ISupportInitialize) this.btnNext).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.tabPolicyInfo).EndInit();
    ((Control) this.tabPolicyInfo).ResumeLayout(false);
    ((ISupportInitialize) this.ddProgramCodes).EndInit();
    ((ISupportInitialize) this.ddIntermediaryContacts).EndInit();
    ((ISupportInitialize) this.ddCompanyContacts).EndInit();
    ((ISupportInitialize) this.ugPolicyDetail).EndInit();
    ((Control) this).ResumeLayout(false);
  }

  public event frmQuoteEdit.DataLoadCompletedEventHandler DataLoadCompleted;

  public frmQuoteEdit()
  {
    ((Form) this).Load += new EventHandler(this.FrmQuoteEdit_Load);
    this.ClientPolicyTypeShowComnPopup = true;
    this._defaultTAGuid = Guid.Empty;
    this._ignoreCommissionsUpdateOnEffectiveDateChanged = false;
    this._underWriterAssistantGuid = Guid.Empty;
    this._underWriterGuid = Guid.Empty;
    this._effectiveDate = DateTime.MinValue;
    this._currentProducerContactGuid = Guid.Empty;
    this._maxControlNo = -1;
    this._issuingOfficeGuid = Guid.Empty;
    this._allowClearance = true;
    this._allowLapseInRenewalPolicyTerms = false;
    this._originalCompany = string.Empty;
    this._producerCommissionCellChanged = false;
    this._ProgramID = -1;
    this._currentCompanyLineGuid = Guid.Empty;
    this._currentQuotingOfficeGuid = Guid.Empty;
    this._originalPolicyTypeId = -1;
    this._originalStateID = string.Empty;
    this._canChangeEffectiveDateOnEffectiveDate = true;
    this._isBound = false;
    this._isRated = false;
    this._isEndorsement = false;
    this._hasIssuedQuoteDetailDeletes = false;
    this._hasUpdatedFinanceCompanyByDefault = false;
    this._validateProducerLicenseOnQuoteCreation = false;
    this._financeCompanyLine = new Dictionary<string, Guid>();
    this._issuingOffice = (object) null;
    this._setBillingTypeOnEdits = false;
    this._isImsRewrite = false;
    this._companyCommissionCellChanged = false;
    this._replicateQuote = false;
    this._replicateQuoteGuid = Guid.Empty;
    this._programCodeCellChanged = false;
    this._useCurrentUserAsDefaultUnderwriter = false;
    this._isMultiCurrencyActive = false;
    this._objOriginalAuditable = "<empty>";
    this._showSlaNumber = false;
    this._canUpdateUnderwriterOnUnboundEndorsements = true;
    this._renewalQuoteGuid = (object) null;
    this._lineGroupTable = (DataTable) null;
    this._quoteEditIgnoreCommissionsUpdateOnProgramCodeChange = false;
    this._savingData = false;
    this._lockDownProgramCodeWhenBound = false;
    this._AllowUpdateProgramCodes = true;
    this._UseEffectiveDateForPolicyParticipants = false;
    this._lockDownProgramCodeOnEndorsements = false;
    this._allowEditingProgramCodesOnEndorsements = true;
    this._onSavingkeepSequenceOnCompanyChange = false;
    this._promptResetPolicyNumber = false;
    this._originalLineGuid = Guid.Empty;
    this._companyCommissionsCache = new Dictionary<Guid, Decimal>();
    this._detailCompanyLine = new Dictionary<Guid, bool>();
    this._keepRenewalSequenceAfterPrompt = true;
    this._intermediaryContacts = new Dictionary<Guid, dsQuoteEdit.tblIntermediaryContactsDataTable>();
    this.InitializeComponent();
  }

  public frmQuoteEdit(Guid quoteGuid, Guid submissionGroupGuid)
    : this()
  {
    this._quoteGuid = quoteGuid;
    this._submissionGroupGuid = submissionGroupGuid;
    this._submission = ObjectFactory.Instance.CreateObjectAs<SubmissionGroup>(new object[1]
    {
      (object) this._submissionGroupGuid
    });
    this._quote = Quote.CreateNewAs<Quote>(quoteGuid);
  }

  protected string StateID
  {
    get
    {
      return ((UltraCombo) this.cboState).Value == null || ((UltraCombo) this.cboState).Value == DBNull.Value ? string.Empty : ((UltraCombo) this.cboState).Value.ToString();
    }
  }

  protected Guid QuoteGuid => this._quoteGuid;

  protected DateTime EffectiveDate => (DateTime) ((UltraDateTimeEditor) this.dtEffectiveDate).Value;

  protected DateTime ExpirationDate
  {
    get => (DateTime) ((UltraDateTimeEditor) this.dtExpirationDate).Value;
  }

  protected Guid ProducerLocationGuid => this._submission.ProducerLocationGuid;

  protected virtual Guid DefaultUnderwriterGuid
  {
    get => this._submission.UnderwriterUserGuid ?? Guid.Empty;
  }

  protected virtual bool IsCommissionRenewal => this.IsRenewal;

  protected Quote Quote
  {
    get
    {
      if (this._quote == null && this.IsNewQuote)
        throw new InvalidOperationException("Can not query Quote property for new quotes");
      if (this._quote == null)
        this._quote = ObjectFactory.Instance.CreateObjectAs<Quote>(new object[1]
        {
          (object) this.QuoteGuid
        });
      return (Quote) this._quote;
    }
  }

  protected SubmissionGroup SubmissionGroup => this._submission;

  private bool AllowSaveWithLapseInRenewalPolicyTerms
  {
    get => this._allowLapseInRenewalPolicyTerms;
    set => this._allowLapseInRenewalPolicyTerms = value;
  }

  private bool ValidCompanyLineGuid => !this.CompanyLineGuid.Equals(Guid.Empty);

  private Guid DefaultTAGuid => this._submission.TACSRUserGuid ?? Guid.Empty;

  private BindingManagerBase RowBinding
  {
    get
    {
      return ((ContainerControl) this).BindingContext[(object) this.dsQuoteEdit, this.dsQuoteEdit.tblQuotes.TableName];
    }
  }

  private DataTable LineGroupTable
  {
    get
    {
      if (this._lineGroupTable == null)
        this._lineGroupTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "select l.GroupCode as GroupCode, l.LineGUID as LineGuid from lstLines l inner join lstLineGroups g on g.GroupCode = l.GroupCode");
      return this._lineGroupTable;
    }
  }

  private bool PerformQuoteDetailsRatingCheck
  {
    get
    {
      bool detailsRatingCheck;
      if (!SystemSettings.GetSetting<bool>(nameof (PerformQuoteDetailsRatingCheck), false))
        detailsRatingCheck = false;
      else
        detailsRatingCheck = DefaultDatabase.ExecuteScalar<bool>("dbo.spPerformQuoteDetailsRatingCheck", new object[2]
        {
          (object) "@QuoteGuid",
          (object) this._quoteGuid
        });
      return detailsRatingCheck;
    }
  }

  private bool LockDownProgramCodeOnEndorsements
  {
    get
    {
      return !this._isNewQuote && !this._isImsRewrite && !this.IsRenewal && this._isEndorsement && !this._allowEditingProgramCodesOnEndorsements && this._lockDownProgramCodeOnEndorsements;
    }
  }

  public bool IsConvertToFullQuote
  {
    get => this._isConvertToFullQuote;
    set => this._isConvertToFullQuote = value;
  }

  public bool IsQuickQuote
  {
    get => this._isQuickQuote;
    set => this._isQuickQuote = value;
  }

  public bool IsValidCompanyLineSelected
  {
    get
    {
      return ((UltraCombo) this.cboCompanies).Value != null && ((UltraCombo) this.cboLine).Value != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboState).Text, string.Empty, false) != 0;
    }
  }

  public bool IsRenewal
  {
    get
    {
      return ((UltraCombo) this.cboPolicyType).Value != null && (int) ((UltraCombo) this.cboPolicyType).Value == 2;
    }
  }

  public Guid CompanyLineGuid
  {
    get
    {
      return ((UltraCombo) this.cboCompanies).Value == null || ((UltraCombo) this.cboLine).Value == null || ((UltraCombo) this.cboState).Value == null ? Guid.Empty : this.GetCompanyLineGuid((Guid) ((UltraCombo) this.cboCompanies).Value, (Guid) ((UltraCombo) this.cboLine).Value, ((UltraCombo) this.cboState).Value.ToString());
    }
  }

  public Guid QuotingOfficeGuid
  {
    get
    {
      return ((UltraCombo) this.cboQuotingOffice).Value == null || ((UltraCombo) this.cboQuotingOffice).Value == DBNull.Value || !(((UltraCombo) this.cboQuotingOffice).Value is Guid) ? Guid.Empty : (Guid) ((UltraCombo) this.cboQuotingOffice).Value;
    }
  }

  public Guid IssuingOfficeGuid
  {
    get
    {
      return ((UltraCombo) this.cboIssuingOffice).Value == null || ((UltraCombo) this.cboIssuingOffice).Value == DBNull.Value || !(((UltraCombo) this.cboIssuingOffice).Value is Guid) ? Guid.Empty : (Guid) ((UltraCombo) this.cboIssuingOffice).Value;
    }
  }

  public bool IsNewQuote => this._isNewQuote;

  public bool AllowClearance => this._allowClearance;

  public MGANumericEditor TargetPremium => this.numTargetPremium;

  public Guid OriginalCompanyLocationGuid => this._originalCompanyLocationGuid;

  public bool ReplicateQuote
  {
    get => this._replicateQuote;
    set => this._replicateQuote = value;
  }

  public Guid ReplicateQuoteGuid
  {
    get => this._replicateQuoteGuid;
    set => this._replicateQuoteGuid = value;
  }

  public Guid OfficeGuidForProducerLocation
  {
    get => this._useIssuingOfficeForProducerLines ? this.IssuingOfficeGuid : this.QuotingOfficeGuid;
  }

  protected virtual void SetupForm()
  {
    ((Control) this.comboCurrencyCode).DataBindings.Add("Enabled", (object) this.cboQuotingOffice, "Enabled");
    ((Control) this.comboCurrencyCode).Visible = this._isMultiCurrencyActive;
    ((Control) this.cboSettlementCurrency).DataBindings.Add("Enabled", (object) this.cboQuotingOffice, "Enabled");
    ((Control) this.cboSettlementCurrency).Visible = this._isMultiCurrencyActive && this._usingSettlementCurrency;
    this.lblSettlementCurrency.Visible = this._isMultiCurrencyActive && this._usingSettlementCurrency;
    ((Control) this.cboRetailerContact).Visible = this._showRetailerContact;
    this.lblRetailerContact.Visible = this._showRetailerContact;
    ((Control) this.numExchangeRate).Visible = this._isMultiCurrencyActive;
    this.lblExchangeRate.Visible = this._isMultiCurrencyActive;
    ((ControlBase) this.btnNext).Appearance.Image = (object) ImageCache.Instance.Forward;
    ((Control) this.btnNext).Enabled = false;
    this.lnkConvertQuickQuote.Enabled = false;
    ((UltraTabControlBase) this.tabPolicyInfo).Tabs["tabEndorsement"].Visible = false;
    this.BouncingProgress1.Bounce = true;
    ((Control) this.gbPleaseWait).Top = (int) Math.Round((double) ((Control) this).Height / 2.0) - (int) Math.Round((double) ((Control) this.gbPleaseWait).Height / 2.0);
    if (!this.IsQuickQuote)
      ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Bands[0].Columns["IntermediaryContactGuid"].Hidden = true;
    if (this._isNewQuote)
      this.ConfigureQuickQuoteAppearance(this.IsQuickQuote);
    else
      this.ConfigureQuickQuoteAppearance(DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT QuickQuote FROM tblQuotes WITH (NOLOCK)  WHERE QuoteGuid = @QuoteGuid", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      }));
    foreach (UltraTab tab in ((UltraTabControlBase) this.tabPolicyInfo).Tabs)
      tab.Enabled = false;
    ((UltraDateTimeEditor) this.dtEffectiveDate).Value = (object) DateAndTime.Now;
    ((UltraDateTimeEditor) this.dtExpirationDate).Value = (object) DateAndTime.Now.AddYears(1);
    ((Control) this.lblDisabledItems).Visible = false;
    if (CurrentUser.Instance.IsAccountingPackageActive)
      this.dvQuotingOffice.RowFilter = "HasChartOfAccounts=1";
    bool flag = SecurityManager.Instance.AssertPermission("{EBFAD226-E0D7-423b-A808-207916EEE30F}");
    this.lnkRemoveRetailer.Enabled = flag;
    this.lnkUpdateRetailer.Enabled = flag;
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Bands[0].Columns["CompanyCommission"].Hidden = !SecurityManager.Instance.AssertPermission("{BA0D58C3-9159-4f16-9474-5C313C8D20F7}");
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Bands[0].Columns["ProducerCommission"].Hidden = !SecurityManager.Instance.AssertPermission("{650C55A1-7C7B-4AA7-9116-D2801432324A}");
    bool setting = SystemSettings.GetSetting<bool>("ImplementMinimumEarnedAmount", false);
    this.lblMinEarnedAmount.Visible = setting;
    ((Control) this.numMinimumEarnedAmount).Visible = setting;
    ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Bands[0].Columns["SLA_Number"].Hidden = !this._showSlaNumber;
    this.cboNAICSCode.DisplayLayout.Bands[0].Columns["NAICSCode"].Width = 60;
    this.cboNAICSCode.DisplayLayout.Bands[0].Columns["NAICSDescription"].Width = 200;
    this.cboNAICSCode.DisplayLayout.Bands[0].Columns["SICCode"].Width = 60;
    this.cboNAICSCode.DisplayLayout.Bands[0].Columns["SICDescription"].Width = 200;
    this._quoteEditIgnoreCommissionsUpdateOnProgramCodeChange = SystemSettings.GetSetting<bool>("QuoteEditIgnoreCommissionsUpdateOnProgramCodeChange", false);
    if (SystemSettings.GetSetting<bool>("AllowSICSort", false))
      this.dvSIC.Sort = "SIC_Code";
    if (this._isBound && this._lockDownProgramCodeWhenBound || this.LockDownProgramCodeOnEndorsements)
      ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Bands[0].Columns["ProgramID"].CellActivation = (Activation) 3;
    if (!this._AllowUpdateProgramCodes && !this.IsNewQuote)
    {
      Quote quote = new Quote(this._quoteGuid);
      if (quote.IsBound | quote.QuoteStatus == 7)
        ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Bands[0].Columns["ProgramID"].CellActivation = (Activation) 3;
    }
    this._canOverrideMaxCompanyComm = SecurityManager.Instance.AssertPermission("{1710472B-2938-4DCF-A61D-F75F770B1629}");
    this._validateMaxCompanyCommission = SystemSettings.GetSetting<bool>("QuoteInformation.ValidateMaxCompanyCommissions", false);
    this._enforceUniqueChildPolicyNumbers = SystemSettings.GetSetting<bool>("QuoteInformation.EnforceUniqueChildPolicyNumbers", false);
    this._useIssuingOfficeForProducerLines = SystemSettings.GetSetting<bool>("QuoteInformation.UseIssuingOfficeForProducerLines", false);
  }

  private void SetDefaultsSecurityAndSettings()
  {
    this._isNewQuote = this._quoteGuid.Equals(Guid.Empty);
    this._isBound = !this.IsNewQuote && this._quote.IsBound;
    this._isEndorsement = !this.IsNewQuote && this._quote.IsEndorsement;
    this._isImsRewrite = !this.IsNewQuote && this._quote.IsImsRewrite;
    this._dateCreatedUseServerTime = frmQuoteEdit.InitializeSetting("DateCreatedUseServerTime", false);
    this._effectiveDateUseServerTime = frmQuoteEdit.InitializeSetting("EffectiveDateUseServerTime", false);
    this._ignoreDuplicateProgramCodes = SystemSettings.GetSetting<bool>("IgnoreDuplicateProgramCodes", false);
    this._autoSelectProgramCode = SystemSettings.GetSetting<bool>("AutoSelectProgramCode", false);
    this._ignoreCommissionsUpdateOnEffectiveDateChanged = SystemSettings.GetSetting<bool>("IgnoreCommissionsUpdateOnEffectiveDateChanged", false);
    this._resetMinEarnedOnCarrierChange = SystemSettings.GetSetting<bool>("ResetMinimumEarnedOnCarrierChanged", false);
    if (!this.IsNewQuote)
    {
      if (this._isEndorsement && !this._isBound)
      {
        this._canChangeEffectiveDateOnEffectiveDate = SecurityManager.Instance.AssertPermission("{F3297CF1-407C-488F-821A-B2B794C130CF}");
        this._canUpdateUnderwriterOnUnboundEndorsements = SecurityManager.Instance.AssertPermission("{EFCE8526-D7F9-4DCE-9BEF-B7C6CE7C0C5A}");
      }
      this._isRated = this._isEndorsement || this._isBound || this._isImsRewrite || this._quote.IsRated || this.PerformQuoteDetailsRatingCheck;
      this._setBillingTypeOnEdits = SystemSettings.GetSetting<bool>("SetQuoteEditInfoBillingType", false);
    }
    if (this.IsNewQuote)
    {
      this._validateProducerLicenseOnQuoteCreation = SystemSettings.GetSetting<bool>("ValidateProducerLicenseOnQuoteCreation", false);
    }
    else
    {
      this._lockDownProgramCodeWhenBound = SystemSettings.GetSetting<bool>("LockDownProgramCodeWhenBound", false);
      this._lockDownProgramCodeOnEndorsements = SystemSettings.GetSetting<bool>("LockDownProgramCodeOnEndorsements", false);
    }
    this._OverrideCommissionAdditive = SecurityManager.Instance.AssertPermission("{80222C62-0EB6-442C-8629-72F5672725F1}");
    this._currentUserGuid = CurrentUser.Instance.UserGUID;
    this._useCurrentUserAsDefaultUnderwriter = SystemSettings.GetSetting<bool>("UseCurrentUserAsDefaultUnderwriter", false);
    this._isMultiCurrencyActive = MultiCurrencyUtilities.IsMultiCurrencyActive();
    this._showSlaNumber = SystemSettings.GetSetting<bool>("ShowSLANumberOnQuoteEdit", false);
    this._UseEffectiveDateForPolicyParticipants = SystemSettings.GetSetting<bool>("UseEffectiveDateForPolicyParticipants", false);
    if (this._isEndorsement)
      this._allowEditingProgramCodesOnEndorsements = SecurityManager.Instance.AssertPermission("{FCF6D2E7-7F57-4D50-B249-AF92DC42840B}");
    this._onSavingkeepSequenceOnCompanyChange = SystemSettings.GetSetting<bool>("QuoteInformation.KeepSequenceOnCompanyChange", false);
    this._AllowUpdateProgramCodes = SecurityManager.Instance.AssertPermission("{3E1E7811-974B-4283-808E-6DCC4192B144}");
    this._promptResetPolicyNumber = SystemSettings.GetSetting<bool>("QuoteInformation.PromptResetPolicy", false);
    this._IgnoreCostCenterDefaultUpdate = SystemSettings.GetSetting<bool>("IgnoreCostCenterDefaultUpdate", false);
    this._costCenterCheckOnCompanyLineChanged = SystemSettings.GetSetting<bool>("CostCenterCheckOnCompanyLineChanged", false);
    this._usingSettlementCurrency = SystemSettings.GetSetting<bool>("UsingSettlementCurrency", false);
    this._showRetailerContact = SystemSettings.GetSetting<bool>("QuoteInformation.ShowRetailerContact", false);
    this._getQuoteEditCompanyLocationsProcName = SystemSettings.GetSetting<string>("QuoteInformation.GetQuoteEditCompanyLocations", "dbo.GetQuoteEditCompanyLocations");
    this._includeProgCodeOnMaxProdComm = SystemSettings.GetSetting<bool>("QuoteInformation.IncludeProCodeOnMaxProducerCommission", false);
  }

  private void EditQuote()
  {
    if (!this.dsQuoteEdit.tblQuotes[0].IsCompanyLocationGuidNull())
      this._originalCompanyLocationGuid = this.dsQuoteEdit.tblQuotes[0].CompanyLocationGuid;
    if (!this.dsQuoteEdit.tblQuotes[0].IsLineGuidNull())
      this._originalLineGuid = this.dsQuoteEdit.tblQuotes[0].LineGuid;
    if (!this.dsQuoteEdit.tblQuotes[0].IsQuotingLocationGuidNull())
      this.dsQuoteEdit.lstLines.DefaultView.RowFilter = $"OfficeGuid='{this.dsQuoteEdit.tblQuotes[0].QuotingLocationGuid.ToString()}' OR OfficeGuid='{Guid.Empty.ToString()}'";
    if (!this.dsQuoteEdit.tblQuotes[0].IsRetailerGuidNull())
    {
      ProducerLocation producerLocation = new ProducerLocation(this.dsQuoteEdit.tblQuotes[0].RetailerGuid);
      string empty = string.Empty;
      string str = producerLocation.LocationName;
      if (!string.IsNullOrEmpty(producerLocation.City))
        str = $"{str}, {producerLocation.City}";
      if (!string.IsNullOrEmpty(producerLocation.State))
        str = $"{str}, {producerLocation.State}";
      if (!string.IsNullOrEmpty(producerLocation.Zip))
        str = $"{str} {producerLocation.Zip}";
      ((ControlBase) this.lblRetailer).Text = str;
    }
    if (this._isBound)
      this.DisableBoundItems();
    else if (this._quote.OptionCount > 0 || !this._quote.IsOriginalQuoteRecord && Decimal.Compare(Decimal.Add(this._quote.AggregatePremium, this._quote.AggregateFees), 0M) != 0)
    {
      this.DisableOptionItems();
      this.lnkConvertQuickQuote.Visible = false;
    }
    ((UltraTabControlBase) this.tabPolicyInfo).Tabs["tabEndorsement"].Visible = this._quote.QuoteStatus == 9;
    dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
    this.IsQuickQuote = tblQuote.QuickQuote;
    if (!tblQuote.IsInspectionCompanyIDNull())
      ((UltraCombo) this.cboInspectionCompanies).Value = (object) tblQuote.InspectionCompanyID;
    ((UltraCombo) this.cboQuotingOffice).ValueChanged -= new EventHandler(this.CboQuotingOffice_ValueChanged);
    ((UltraCombo) this.cboQuotingOffice).Value = (object) tblQuote.QuotingLocationGuid;
    ((UltraCombo) this.cboQuotingOffice).ValueChanged -= new EventHandler(this.CboQuotingOffice_ValueChanged);
    ((UltraCombo) this.cboLine).Value = (object) tblQuote.LineGuid;
    this.CboLine_ValueChanged((object) null, (EventArgs) null);
    if (!tblQuote.IsStateIDNull())
    {
      ((UltraCombo) this.cboState).ValueChanged -= new EventHandler(this.CboState_ValueChanged);
      ((UltraCombo) this.cboState).ValueChanged -= new EventHandler(this.CboState_ValueChanged);
      ((UltraCombo) this.cboState).Value = (object) tblQuote.StateID;
      if (!this.dsQuoteEdit.tblQuotes[0].IsStateIDNull())
      {
        this.LoadCompanyLocations(this.dsQuoteEdit.tblQuotes[0].LineGuid, this.ProducerLocationGuid, this.dsQuoteEdit.tblQuotes[0].StateID, true);
        if (!this.dsQuoteEdit.tblQuotes[0].IsCompanyLocationGuidNull())
        {
          ((UltraCombo) this.cboCompanies).ValueChanged -= new EventHandler(this.CboCompanies_ValueChanged);
          ((UltraCombo) this.cboCompanies).ValueChanged -= new EventHandler(this.CboCompanies_ValueChanged);
          ((UltraCombo) this.cboCompanies).ValueChanged -= new EventHandler(this.CboCompanies_ValueChanged);
          ((UltraCombo) this.cboCompanies).Value = (object) this.dsQuoteEdit.tblQuotes[0].CompanyLocationGuid;
          ((UltraCombo) this.cboCompanies).ValueChanged += new EventHandler(this.CboCompanies_ValueChanged);
          Guid companyLineGuid = this.GetCompanyLineGuid(this.dsQuoteEdit.tblQuotes[0].CompanyLocationGuid, this.dsQuoteEdit.tblQuotes[0].LineGuid, this.dsQuoteEdit.tblQuotes[0].StateID);
          if (this.dsQuoteEdit.lstBillingTypes.Count == 0)
            this.GetAvailableBillingTypes(companyLineGuid);
          this.DeleteDetailRows();
          MDIControls.Instance.StatusBarText = "Getting policy detail items...";
          this.daQuoteDetails.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._quoteGuid;
          try
          {
            this.SetStoredProcforClients();
            DefaultDatabase.LoadDataSet((DataSet) this.dsQuoteEdit, new string[1]
            {
              "tblQuoteDetails"
            }, this._SpNameForClients, new object[4]
            {
              (object) "@QuoteGuid",
              (object) this._quoteGuid,
              (object) "@IsRated",
              (object) this._isRated
            });
            this.DeleteInvalidQuoteDetailRows();
          }
          catch (ConstraintException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            ErrorHandler.ShowDataSetErrors((DataSet) this.dsQuoteEdit, ex);
            ProjectData.ClearProjectError();
          }
          this.FillContactsDropdownList();
          this.LockdownCompanyCommissionCells();
        }
      }
    }
    if (!tblQuote.IsTACSRUserGuidNull())
      ((UltraCombo) this.cboTA).Value = (object) tblQuote.TACSRUserGuid;
    if (!tblQuote.IsUnderwriterUserGuidNull())
      this._underWriterGuid = tblQuote.UnderwriterUserGuid;
    ((UltraCombo) this.cboUnderwriter).Value = (object) tblQuote.UnderwriterUserGuid;
    ((UltraDateTimeEditor) this.dtEffectiveDate).Value = (object) tblQuote.EffectiveDate;
    ((UltraDateTimeEditor) this.dtExpirationDate).Value = (object) tblQuote.ExpirationDate;
    ((UltraCombo) this.cboIssuingOffice).Value = (object) tblQuote.IssuingLocationGuid;
    ((UltraCombo) this.cboProducerContact).Value = (object) tblQuote.ProducerContactGuid;
    ((UltraCombo) this.cboPolicyType).Value = (object) tblQuote.PolicyTypeID;
    if (this.dsQuoteEdit.tblQuotes2.Count > 0)
    {
      if (!this.dsQuoteEdit.tblQuotes2[0].IsExpiringCompanyLocationGuidNull())
        ((UltraCombo) this.comboExpiringCarrier).Value = (object) this.dsQuoteEdit.tblQuotes2[0].ExpiringCompanyLocationGuid;
      if (!this.dsQuoteEdit.tblQuotes2[0].IsNonRenewedNull())
        ((UltraToggleEditorBase) this.chkNonRenewed).Checked = this.dsQuoteEdit.tblQuotes2[0].NonRenewed;
      if (!this.dsQuoteEdit.tblQuotes2[0].IsMinimumCancellationDaysNull())
        ((UltraNumericEditor) this.numMinCancellationDays).Value = (object) this.dsQuoteEdit.tblQuotes2[0].MinimumCancellationDays;
      if (!this.dsQuoteEdit.tblQuotes2[0].IsFacultativeNull())
        ((UltraToggleEditorBase) this.chkFacultative).Checked = this.dsQuoteEdit.tblQuotes2[0].Facultative;
      if (!this.dsQuoteEdit.tblQuotes2[0].IsExchangeRateNull())
        ((UltraNumericEditor) this.numExchangeRate).Value = (object) this.dsQuoteEdit.tblQuotes2[0].ExchangeRate;
      if (!this.dsQuoteEdit.tblQuotes2[0].IsNeededByDateNull())
        ((UltraDateTimeEditor) this.dateNeededBy).Value = (object) this.dsQuoteEdit.tblQuotes2[0].NeededByDate;
      if (!this.dsQuoteEdit.tblQuotes2[0].IsMinimumEarnedAmountNull())
        ((UltraNumericEditor) this.numMinimumEarnedAmount).Value = (object) this.dsQuoteEdit.tblQuotes2[0].MinimumEarnedAmount;
      if (!this.dsQuoteEdit.tblQuotes2[0].IsFacultativePercentageNull())
        ((UltraNumericEditor) this.numFacultativePercentage).Value = (object) this.dsQuoteEdit.tblQuotes2[0].FacultativePercentage;
      if (!this.dsQuoteEdit.tblQuotes2[0].IsTaxAddress1Null())
        this.ctlKYTaxLocation.Address1 = this.dsQuoteEdit.tblQuotes2[0].TaxAddress1;
      if (!this.dsQuoteEdit.tblQuotes2[0].IsTaxAddress2Null())
        this.ctlKYTaxLocation.Address2 = this.dsQuoteEdit.tblQuotes2[0].TaxAddress2;
      if (!this.dsQuoteEdit.tblQuotes2[0].IsTaxCityNull())
        this.ctlKYTaxLocation.City = this.dsQuoteEdit.tblQuotes2[0].TaxCity;
      if (!this.dsQuoteEdit.tblQuotes2[0].IsTaxStateNull())
        this.ctlKYTaxLocation.State = this.dsQuoteEdit.tblQuotes2[0].TaxState;
      if (!this.dsQuoteEdit.tblQuotes2[0].IsTaxZipNull())
        this.ctlKYTaxLocation.ZipCode = this.dsQuoteEdit.tblQuotes2[0].TaxZip;
      if (!this.dsQuoteEdit.tblQuotes2[0].IsTaxCountyNull())
        this.ctlKYTaxLocation.County = this.dsQuoteEdit.tblQuotes2[0].TaxCounty;
      if (!this.dsQuoteEdit.tblQuotes2[0].IsSettlementCurrencyCodeNull())
        ((UltraCombo) this.cboSettlementCurrency).Value = (object) this.dsQuoteEdit.tblQuotes2[0].SettlementCurrencyCode;
      if (!this.dsQuoteEdit.tblQuotes2[0].IsRetailerContactGuidNull())
        ((UltraCombo) this.cboRetailerContact).Value = (object) this.dsQuoteEdit.tblQuotes2[0].RetailerContactGuid;
    }
    if (!tblQuote.IsUnderwritingAssistantGuidNull())
    {
      ((UltraCombo) this.cboUnderwritingAssistant).Value = (object) tblQuote.UnderwritingAssistantGuid;
      this._underWriterAssistantGuid = tblQuote.UnderwritingAssistantGuid;
    }
    if (!tblQuote.IsBillingTypeIDNull())
      ((UltraCombo) this.cboBillingTypes).Value = (object) tblQuote.BillingTypeID;
    if (!tblQuote.IsFinanceCompanyGuidNull())
      ((UltraCombo) this.cboFinanceCompany).Value = (object) tblQuote.FinanceCompanyGuid;
    if (tblQuote.IsSIC_CodeNull())
      ((UltraCombo) this.cboRiskClass).Value = (object) DBNull.Value;
    else
      ((UltraCombo) this.cboRiskClass).Value = (object) tblQuote.SIC_Code;
    if (SystemSettings.GetSetting<bool>("Policy.UseNetrate.NaicsClass", false))
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.GetNetRateNaicsClassCode", new object[2]
      {
        (object) "@quoteGuid",
        (object) this.QuoteGuid
      });
      if (dataTable.Rows.Count > 0 && !dataTable.Rows[0].IsNull("NaicsClass"))
        tblQuote.NAICSCode = dataTable.Rows[0].Field<string>("NaicsClass");
    }
    if (tblQuote.IsNAICSCodeNull())
      ((UltraCombo) this.cboNAICSCode).Value = (object) DBNull.Value;
    else
      ((UltraCombo) this.cboNAICSCode).Value = (object) tblQuote.NAICSCode;
    if (tblQuote.IsUnderwritingAssistantGuidNull())
      ((UltraCombo) this.cboUnderwritingAssistant).Value = (object) DBNull.Value;
    else
      ((UltraCombo) this.cboUnderwritingAssistant).Value = (object) tblQuote.UnderwritingAssistantGuid;
    if (tblQuote.IsSecProducerContactGuidNull())
      ((UltraCombo) this.cboSecProducerContact).Value = (object) DBNull.Value;
    else
      ((UltraCombo) this.cboSecProducerContact).Value = (object) tblQuote.SecProducerContactGuid;
    if (tblQuote.IsEarnedPremiumTypeIDNull())
      ((UltraCombo) this.cboEarnedPremiumType).Value = (object) DBNull.Value;
    else
      ((UltraCombo) this.cboEarnedPremiumType).Value = (object) tblQuote.EarnedPremiumTypeID;
    if (!tblQuote.IsAuditableNull())
      this.optionAuditable.CheckedItem = tblQuote.Auditable ? this.optionAuditable.Items[0] : this.optionAuditable.Items[1];
    if (!tblQuote.IsRenewalofQuoteGUIDNull())
      this._renewalQuoteGuid = (object) tblQuote.RenewalofQuoteGUID;
    ((UltraCombo) this.cboState).ValueChanged += new EventHandler(this.CboState_ValueChanged);
    if (this.ValidCompanyLineGuid && this.dsQuoteEdit.tblQuoteDetails.Count == 0)
    {
      this._readyToShowParticipants = true;
      this.ShowParticipants();
    }
    this.RefillCompanyCommissions();
  }

  protected virtual void NewQuote()
  {
    dsQuoteEdit.tblQuotesRow row1 = this.dsQuoteEdit.tblQuotes.NewtblQuotesRow();
    this._quoteGuid = Guid.NewGuid();
    dsQuoteEdit.tblQuotesRow tblQuotesRow = row1;
    tblQuotesRow.QuickQuote = this.IsQuickQuote;
    tblQuotesRow.ControlGuid = Guid.NewGuid();
    tblQuotesRow.QuoteGuid = this._quoteGuid;
    tblQuotesRow.SubmissionGroupGuid = this._submissionGroupGuid;
    tblQuotesRow.DateCreated = !this._dateCreatedUseServerTime ? DateAndTime.Now : CurrentUser.ServerTime;
    tblQuotesRow.EffectiveDate = !this._effectiveDateUseServerTime ? DateAndTime.Now : CurrentUser.ServerTime;
    tblQuotesRow.ExpirationDate = tblQuotesRow.EffectiveDate.AddYears(1);
    tblQuotesRow.ProducerLocationID = this._submission.ProducerLocation.ProducerLocationID;
    row1.PolicyTypeID = 1;
    ((UltraCombo) this.cboPolicyType).Value = (object) 1;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("dbo.GetUnderwriterOfficeGuid", new object[2]
    {
      (object) "@submissionGroupGuid",
      (object) this._submissionGroupGuid
    }));
    if (objectValue != null && objectValue != DBNull.Value && this.dsQuoteEdit.dtIssuingOffice.FindByOfficeGuid((Guid) objectValue) != null)
    {
      row1.IssuingLocationGuid = (Guid) objectValue;
      ((UltraCombo) this.cboIssuingOffice).Value = (object) row1.IssuingLocationGuid;
    }
    ValueListItem valueListItem = this.optionAuditable.Items[0];
    row1.Auditable = true;
    if (SystemSettings.GetSetting<bool>("DefaultNonAuditable", false))
    {
      valueListItem = this.optionAuditable.Items[1];
      row1.Auditable = false;
    }
    this.optionAuditable.CheckedItem = valueListItem;
    this.dsQuoteEdit.tblQuotes.AddtblQuotesRow(row1);
    ((UltraCombo) this.cboRiskClass).Value = (object) DBNull.Value;
    ((UltraCombo) this.cboNAICSCode).Value = (object) DBNull.Value;
    DataRow row2 = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT C.ProducerContactGuid, SC.ProducerContactGuid SecondaryContactGuid FROM dbo.tblSubmissionGroup S WITH (NOLOCK) JOIN dbo.tblProducerContacts C WITH (NOLOCK) ON C.ProducerContactID = S.ProducerContactID LEFT JOIN dbo.tblProducerContacts SC WITH (NOLOCK) ON SC.ProducerContactID = S.SecProducerContactID WHERE S.SubmissionGroupGuid=@SubmissionGroupGuid", new object[2]
    {
      (object) "@SubmissionGroupGuid",
      (object) this._submissionGroupGuid
    });
    ((UltraCombo) this.cboProducerContact).Value = (object) row2.Field<Guid>("ProducerContactGuid");
    if (row2.IsNull("SecondaryContactGuid"))
      return;
    ((UltraCombo) this.cboSecProducerContact).Value = (object) row2.Field<Guid>("SecondaryContactGuid");
  }

  private void FrmQuoteEdit_Load(object sender, EventArgs e)
  {
    if (((Component) this).DesignMode)
      return;
    if (!SecurityManager.Instance.AssertPermission("{CE7C9240-9944-4bdc-96A1-E75EB0F5EADF}"))
      ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Bands[0].Columns["ProducerCommission"].CellActivation = (Activation) 3;
    ((Form) this).Text = $"Quote Information for {this._submission.Insured.Name}";
    this.SetDefaultsSecurityAndSettings();
    this.SetupForm();
    this.OnFormLoad();
  }

  private void ThreadedFill(object state)
  {
    dsQuoteEdit dsQuoteEdit = this.dsQuoteEdit;
    dsQuoteEdit.TAs.AddTAsRow(Guid.Empty, string.Empty);
    dsQuoteEdit.lstPolicyTypes.AddlstPolicyTypesRow(string.Empty, false);
    dsQuoteEdit.tblClientOffices.AddtblClientOfficesRow(string.Empty, Guid.Empty, true);
    dsQuoteEdit.lstLines.AddlstLinesRow(Guid.Empty, Guid.Empty, string.Empty);
    dsQuoteEdit.FinanceCompanies.AddFinanceCompaniesRow(Guid.Empty, string.Empty);
    dsQuoteEdit.tblFin_ExpensePayees.AddtblFin_ExpensePayeesRow(-1, string.Empty);
    dsQuoteEdit.tblProducerContacts.AddtblProducerContactsRow(string.Empty, Guid.Empty);
    dsQuoteEdit.Assistants.AddAssistantsRow(string.Empty, Guid.Empty);
    dsQuoteEdit.dtIssuingOffice.AdddtIssuingOfficeRow(string.Empty, Guid.Empty);
    dsQuoteEdit.dtRetailerContacts.AdddtRetailerContactsRow(string.Empty, Guid.Empty);
    dsQuoteEdit.lstEarnedPremiumTypeRow row = this.dsQuoteEdit.lstEarnedPremiumType.NewlstEarnedPremiumTypeRow();
    row.EarnedPremiumType = string.Empty;
    row.ID = byte.MaxValue;
    this.dsQuoteEdit.lstEarnedPremiumType.AddlstEarnedPremiumTypeRow(row);
    string setting = SystemSettings.GetSetting<string>("DataOverride_QuoteEditData", "dbo.QuoteEditData");
    try
    {
      object obj = (object) null;
      if (!this.IsNewQuote)
        obj = (object) this.QuoteGuid;
      try
      {
        DefaultDatabase.LoadDataSet((DataSet) this.dsQuoteEdit, new string[15]
        {
          this.dsQuoteEdit.TAs.TableName,
          this.dsQuoteEdit.lstLines.TableName,
          this.dsQuoteEdit.lstPolicyTypes.TableName,
          this.dsQuoteEdit.tblClientOffices.TableName,
          this.dsQuoteEdit.FinanceCompanies.TableName,
          this.dsQuoteEdit.tblProducerContacts.TableName,
          this.dsQuoteEdit.tblFin_ExpensePayees.TableName,
          this.dsQuoteEdit.lstSIC_Codes.TableName,
          this.dsQuoteEdit.lstEarnedPremiumType.TableName,
          this.dsQuoteEdit.ExpiringCarriers.TableName,
          this.dsQuoteEdit.Assistants.TableName,
          this.dsQuoteEdit.tblCompanyProgramCodes.TableName,
          this.dsQuoteEdit.lstNAICSCodes.TableName,
          this.dsQuoteEdit.dtIssuingOffice.TableName,
          this.dsQuoteEdit.dtRetailerContacts.TableName
        }, CommandType.StoredProcedure, setting, 500, (CommandArgumentType) 0, new object[12]
        {
          (object) "@ProducerLocationGuid",
          (object) this.ProducerLocationGuid,
          (object) "@getSICs",
          (object) (frmQuoteEdit._sicCodeCache == null),
          (object) "@getNAICS",
          (object) (frmQuoteEdit._naicsCodeCache == null),
          (object) "@getExpiringCarriers",
          (object) (frmQuoteEdit._expiringCarrierCache == null),
          (object) "@QuoteGuid",
          obj,
          (object) "@CurrentUserGuid",
          (object) CurrentUser.Instance.UserGUID
        });
      }
      catch (DbException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
    catch (DbException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) ex);
      ((Form) this).Close();
      ProjectData.ClearProjectError();
      return;
    }
    if (!this.IsNewQuote)
    {
      try
      {
        DefaultDatabase.LoadDataTable((DataTable) this.dsQuoteEdit.tblQuotes2, CommandType.Text, "SELECT QuoteID, ExpiringCompanyLocationGuid, NonRenewed, MinimumCancellationDays,Facultative, ExchangeRate, NeededByDate, MinimumEarnedAmount, FacultativePercentage,TaxAddress1,TaxAddress2,TaxCity,TaxState,TaxZip,TaxCounty, SettlementCurrencyCode, RetailerContactGuid FROM tblQuotes2 WHERE QuoteID=(SELECT QuoteID FROM tblQuotes WHERE QuoteGuid=@QG)", new object[2]
        {
          (object) "@QG",
          (object) this.QuoteGuid
        });
      }
      catch (ConstraintException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.ShowDataSetErrors((DataSet) this.dsQuoteEdit, ex);
        ProjectData.ClearProjectError();
      }
    }
    if (frmQuoteEdit._sicCodeCache != null)
    {
      this.dsQuoteEdit.lstSIC_Codes.BeginLoadData();
      this.dsQuoteEdit.lstSIC_Codes.Load((IDataReader) frmQuoteEdit._sicCodeCache.CreateDataReader());
      this.dsQuoteEdit.lstSIC_Codes.EndLoadData();
    }
    else
    {
      frmQuoteEdit._sicCodeCache = new dsQuoteEdit.lstSIC_CodesDataTable();
      frmQuoteEdit._sicCodeCache.BeginLoadData();
      frmQuoteEdit._sicCodeCache.Load((IDataReader) this.dsQuoteEdit.lstSIC_Codes.CreateDataReader());
      frmQuoteEdit._sicCodeCache.EndLoadData();
    }
    if (frmQuoteEdit._naicsCodeCache != null)
    {
      this.dsQuoteEdit.lstNAICSCodes.BeginLoadData();
      this.dsQuoteEdit.lstNAICSCodes.Load((IDataReader) frmQuoteEdit._naicsCodeCache.CreateDataReader());
      this.dsQuoteEdit.lstNAICSCodes.EndLoadData();
    }
    else
    {
      frmQuoteEdit._naicsCodeCache = new dsQuoteEdit.lstNAICSCodesDataTable();
      frmQuoteEdit._naicsCodeCache.BeginLoadData();
      frmQuoteEdit._naicsCodeCache.Load((IDataReader) this.dsQuoteEdit.lstNAICSCodes.CreateDataReader());
      frmQuoteEdit._naicsCodeCache.EndLoadData();
    }
    if (frmQuoteEdit._expiringCarrierCache != null)
    {
      this.dsQuoteEdit.ExpiringCarriers.BeginLoadData();
      this.dsQuoteEdit.ExpiringCarriers.Load((IDataReader) frmQuoteEdit._expiringCarrierCache.CreateDataReader());
      this.dsQuoteEdit.ExpiringCarriers.EndLoadData();
    }
    else
    {
      frmQuoteEdit._expiringCarrierCache = new dsQuoteEdit.ExpiringCarriersDataTable();
      frmQuoteEdit._expiringCarrierCache.BeginLoadData();
      frmQuoteEdit._expiringCarrierCache.Load((IDataReader) this.dsQuoteEdit.ExpiringCarriers.CreateDataReader());
      frmQuoteEdit._expiringCarrierCache.EndLoadData();
    }
    if (!this.IsNewQuote)
    {
      this.daQuotes.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._quoteGuid;
      DefaultDatabase.DataAdapterFill(this.daQuotes, (DataTable) this.dsQuoteEdit.tblQuotes);
      if (this.dsQuoteEdit.tblQuotes.Count == 0)
        throw new InvalidOperationException("Could Not find quote in database");
    }
    try
    {
      if (!((Control) this).IsHandleCreated || ((Control) this).IsDisposed || ((Control) this).Disposing)
        return;
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) this, (Delegate) new MethodInvoker(this.LoadComplete), new object[0]);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (ObjectDisposedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void LockdownCommissions()
  {
    if (SecurityManager.Instance.AssertPermission("{57F1F42F-760B-43ef-A9FF-F14523944E84}") || this.dsQuoteEdit.tblQuoteDetails.Rows.Count <= 0)
      return;
    MDIControls.Instance.StatusBarText = "Checking for locked commissions...";
    try
    {
      foreach (dsQuoteEdit.tblQuoteDetailsRow tblQuoteDetail in (TypedTableBase<dsQuoteEdit.tblQuoteDetailsRow>) this.dsQuoteEdit.tblQuoteDetails)
      {
        if (DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT LockedCommissions FROM tblCompanyLineCommissions WITH (NOLOCK)  WHERE CompanyLineID=@CompanyLineID", new object[2]
        {
          (object) "@CompanyLineID",
          (object) new CompanyLine(tblQuoteDetail.CompanyLineGuid).CompanyLineID
        }))
        {
          foreach (UltraGridRow row in ((UltraGridBase) this.ugPolicyDetail).Rows)
          {
            if (row.Cells["CompanyLineGuid"].Value.Equals((object) tblQuoteDetail.CompanyLineGuid))
            {
              row.Cells["CompanyCommission"].Activation = (Activation) 2;
              break;
            }
          }
        }
      }
    }
    finally
    {
      IEnumerator<dsQuoteEdit.tblQuoteDetailsRow> enumerator;
      enumerator?.Dispose();
    }
  }

  protected virtual void AutoSelectOffices()
  {
    if (((UltraGridBase) this.cboQuotingOffice).Rows.Count != 2)
      return;
    ((UltraDropDownBase) this.cboQuotingOffice).SelectedRow = ((UltraGridBase) this.cboQuotingOffice).Rows[1];
    if (((UltraDropDownBase) this.cboIssuingOffice).SelectedRow != null && ((UltraDropDownBase) this.cboIssuingOffice).SelectedRow.Index != 0 || this.dsQuoteEdit.dtIssuingOffice.FindByOfficeGuid((Guid) ((UltraCombo) this.cboQuotingOffice).Value) == null)
      return;
    ((UltraCombo) this.cboIssuingOffice).Value = RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboQuotingOffice).Value);
  }

  private void SetupSecurity()
  {
    ((Control) this.txtExpiringControlNumber).Enabled = SecurityManager.Instance.AssertPermission("{6ecfc08a-4cc6-4185-8b1c-69f770cf5388}");
    int num = -1;
    if (this.cboPolicyType != null && ((UltraCombo) this.cboPolicyType).Value != null && ((UltraCombo) this.cboPolicyType).Value != DBNull.Value)
      num = Conversions.ToInteger(((UltraCombo) this.cboPolicyType).Value);
    if (this.IsRenewal || num == 5)
      ((Control) this.numPreviousPremium).Enabled = SecurityManager.Instance.AssertPermission("{c5f0b321-0570-4b5f-9b25-1f058c45ce34}");
    if (this.IsNewQuote || !this._isBound)
      return;
    ((Control) this.cboFinanceCompany).Enabled = SecurityManager.Instance.AssertPermission("{6FDE3229-A777-4a37-B2D7-EF88D357E316}");
    ((Control) this.cboInspectionCompanies).Enabled = SecurityManager.Instance.AssertPermission("{191A228F-EADB-4bbd-A342-63F8B8E37B61}");
    ((Control) this.cboProducerContact).Enabled = SecurityManager.Instance.AssertPermission("{7731D90C-52BF-420f-9DB1-075B51D8D89D}");
    ((Control) this.cboSecProducerContact).Enabled = SecurityManager.Instance.AssertPermission("{CFC66ADA-B479-428f-9CF9-183B37725ECA}");
    ((Control) this.txtAccountNum).Enabled = SecurityManager.Instance.AssertPermission("{3FF32726-1409-4dd6-BFFB-DB6D6EA5A5A6}");
    ((Control) this.cboRiskClass).Enabled = SecurityManager.Instance.AssertPermission("{FE1BF3E0-0FEE-4fa0-BBAB-383369CDDC85}");
    ((Control) this.cboTA).Enabled = SecurityManager.Instance.AssertPermission("{7D0C4D1D-4445-412c-9D77-43436A839F2D}");
    ((Control) this.txtExpiringPolicyNumber).Enabled = SecurityManager.Instance.AssertPermission("{44BD78C5-76E7-484a-9E7D-228494098679}");
    ((Control) this.numPreviousPremium).Enabled = SecurityManager.Instance.AssertPermission("{4521E064-9025-42ca-A3F3-C01C095D6760}");
    ((Control) this.numTargetPremium).Enabled = SecurityManager.Instance.AssertPermission("{1B32F6E3-7CBC-42da-A410-C6197CB9704E}");
    ((Control) this.numMinimumEarned).Enabled = SecurityManager.Instance.AssertPermission("{4D4B36F1-8FC0-4480-B4FF-8E1B471AB47E}");
    ((Control) this.txtRiskDescription).Enabled = SecurityManager.Instance.AssertPermission("{5C3CAE9D-AB77-4555-AC3D-54A15925303D}");
  }

  protected virtual void LoadComplete()
  {
    // ISSUE: unable to decompile the method.
  }

  protected virtual bool ClientShowCompanyContact() => true;

  private void DisableControls()
  {
    foreach (UltraTab tab in ((UltraTabControlBase) this.tabPolicyInfo).Tabs)
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

  protected virtual void OnFormLoad()
  {
    if (((Component) this).DesignMode)
      return;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedFill));
  }

  private void SetDataBindings()
  {
    ((Control) this.txtRiskDescription).DataBindings.Add(new Binding("Value", (object) this.dsQuoteEdit, "tblQuotes.RiskDescription"));
    ((Control) this.numTargetPremium).DataBindings.Add(new Binding("Value", (object) this.dsQuoteEdit, "tblQuotes.TargetPremium"));
    ((Control) this.numPreviousPremium).DataBindings.Add(new Binding("Value", (object) this.dsQuoteEdit, "tblQuotes.PreviousPremium"));
    ((Control) this.txtExpiringPolicyNumber).DataBindings.Add(new Binding("Value", (object) this.dsQuoteEdit, "tblQuotes.ExpiringPolicyNumber", true));
    ((Control) this.txtExpiringControlNumber).DataBindings.Add(new Binding("Value", (object) this.dsQuoteEdit, "tblQuotes.RenewalofControlNum", true));
    ((UltraGridBase) this.cboTA).DataSource = (object) this.dsQuoteEdit.TAs;
    ((UltraDropDownBase) this.cboTA).DisplayMember = "Name";
    ((UltraDropDownBase) this.cboTA).ValueMember = "UserGuid";
    ((UltraGridBase) this.cboUnderwritingAssistant).DataSource = (object) this.dsQuoteEdit.Assistants;
    ((UltraDropDownBase) this.cboUnderwritingAssistant).DisplayMember = "FullName";
    ((UltraDropDownBase) this.cboUnderwritingAssistant).ValueMember = "UserGuid";
    ((UltraGridBase) this.cboPolicyType).DataSource = (object) this.dsQuoteEdit.lstPolicyTypes;
    ((UltraDropDownBase) this.cboPolicyType).DisplayMember = "Description";
    ((UltraDropDownBase) this.cboPolicyType).ValueMember = "PolicyTypeID";
    ((UltraGridBase) this.cboIssuingOffice).DataSource = (object) this.dsQuoteEdit.dtIssuingOffice;
    ((UltraDropDownBase) this.cboIssuingOffice).DisplayMember = "Location";
    ((UltraDropDownBase) this.cboIssuingOffice).ValueMember = "OfficeGuid";
    ((UltraGridBase) this.cboFinanceCompany).DataSource = (object) this.dsQuoteEdit.FinanceCompanies;
    ((UltraDropDownBase) this.cboFinanceCompany).DisplayMember = "PayeeName";
    ((UltraDropDownBase) this.cboFinanceCompany).ValueMember = "PayeeGuid";
    ((UltraGridBase) this.cboInspectionCompanies).DataSource = (object) this.dsQuoteEdit.tblFin_ExpensePayees;
    ((UltraDropDownBase) this.cboInspectionCompanies).DisplayMember = "PayeeName";
    ((UltraDropDownBase) this.cboInspectionCompanies).ValueMember = "PayeeID";
    ((UltraGridBase) this.cboProducerContact).DataSource = (object) this.dsQuoteEdit.tblProducerContacts;
    ((UltraDropDownBase) this.cboProducerContact).DisplayMember = "FullName";
    ((UltraDropDownBase) this.cboProducerContact).ValueMember = "ProducerContactGuid";
    ((Control) this.dtEndorsement).DataBindings.Add(new Binding("Value", (object) this.dsQuoteEdit, "tblQuotes.EndorsementEffective"));
    ((Control) this.numMinimumEarned).DataBindings.Add(new Binding("Value", (object) this.dsQuoteEdit, "tblQuotes.MinimumEarnedPercentage"));
    ((Control) this.txtAccountNum).DataBindings.Add(new Binding("Text", (object) this.dsQuoteEdit, "tblQuotes.AccountNumber"));
    ((Control) this.cboRiskClass).DataBindings.Add(new Binding("Value", (object) this.dsQuoteEdit, "tblQuotes.SIC_Code"));
    ((Control) this.cboNAICSCode).DataBindings.Add(new Binding("Value", (object) this.dsQuoteEdit, "tblQuotes.NAICSCode"));
    ((UltraGridBase) this.cboLine).DataSource = (object) this.dsQuoteEdit.lstLines;
    ((UltraDropDownBase) this.cboLine).DisplayMember = "LineName";
    ((UltraDropDownBase) this.cboLine).ValueMember = "LineGuid";
    MGASimpleComboBox secProducerContact = this.cboSecProducerContact;
    ((UltraGridBase) secProducerContact).DataSource = (object) this.dsQuoteEdit.tblProducerContacts;
    ((UltraDropDownBase) secProducerContact).DisplayMember = "FullName";
    ((UltraDropDownBase) secProducerContact).ValueMember = "ProducerContactGuid";
    MGASimpleComboBox earnedPremiumType = this.cboEarnedPremiumType;
    ((UltraGridBase) earnedPremiumType).DataSource = (object) this.dsQuoteEdit.lstEarnedPremiumType;
    ((UltraDropDownBase) earnedPremiumType).DisplayMember = "EarnedPremiumType";
    ((UltraDropDownBase) earnedPremiumType).ValueMember = "ID";
    MGASimpleComboBox cboRetailerContact = this.cboRetailerContact;
    ((UltraGridBase) cboRetailerContact).DataSource = (object) this.dsQuoteEdit.dtRetailerContacts;
    ((UltraDropDownBase) cboRetailerContact).DisplayMember = "FullName";
    ((UltraDropDownBase) cboRetailerContact).ValueMember = "ProducerContactGuid";
  }

  private static bool InitializeSetting(string settingName, bool defaultValue)
  {
    int num = Preferences.GetPreferenceInt($"QuoteEditSettings.Override.{settingName}");
    if (num == -1)
      num = SystemSettings.GetSetting<int>("QuoteEditSettings.{settingName}", Convert.ToInt32(defaultValue));
    if (num == -1)
      throw new InvalidOperationException($"QuoteEdit setting cannot be null. Setting name: {settingName}");
    return num == 1;
  }

  public void RefillProgramCodes()
  {
    string str = "SELECT  CompanyLocationGUID, StateID,  CONVERT(DATETIME, CONVERT(VARCHAR(11), ContractEffective, 101)) AS ContractEffective, ContractExpiration, LineGUID, IssuingOfficeGUID, ProgCode, ProgramID, GroupCode, ParentLineGUID FROM dbo.tblCompanyProgramCodes WITH (NOLOCK) ORDER BY StateID DESC, CompanyLocationGUID DESC, IssuingOfficeGUID DESC, LineGUID DESC, ContractEffective DESC";
    this.dsQuoteEdit.tblCompanyProgramCodes.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsQuoteEdit, new string[1]
    {
      "tblCompanyProgramCodes"
    }, CommandType.Text, str);
  }

  protected virtual void AssignCompanyLineProgramCode(Guid quoteGuid, Guid companylineGuid)
  {
    if (this._isBound && this._lockDownProgramCodeWhenBound || this.LockDownProgramCodeOnEndorsements)
      return;
    dsQuoteEdit.tblQuoteDetailsRow guidCompanyLineGuid = this.dsQuoteEdit.tblQuoteDetails.FindByQuoteGuidCompanyLineGuid(this.QuoteGuid, companylineGuid);
    if (guidCompanyLineGuid.RowState == DataRowState.Deleted)
      return;
    int detailProgramCode = this.GetQuoteDetailProgramCode(guidCompanyLineGuid.CompanyLineGuid);
    switch (detailProgramCode)
    {
      case int.MinValue:
      case -1:
        guidCompanyLineGuid.SetProgramIDNull();
        break;
      default:
        guidCompanyLineGuid.ProgramID = detailProgramCode;
        break;
    }
  }

  private void PreSelectProgramCodes()
  {
    if (this._isBound && this._lockDownProgramCodeWhenBound)
      return;
    if (this.LockDownProgramCodeOnEndorsements)
      return;
    try
    {
      foreach (dsQuoteEdit.tblQuoteDetailsRow row in this.dsQuoteEdit.tblQuoteDetails.Rows)
      {
        if (row.RowState != DataRowState.Deleted && row.IsProgramIDNull())
        {
          int detailProgramCode = this.GetQuoteDetailProgramCode(row.CompanyLineGuid);
          switch (detailProgramCode)
          {
            case int.MinValue:
            case -1:
              continue;
            default:
              row.ProgramID = detailProgramCode;
              continue;
          }
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

  private void FillProgramCodeDropDown()
  {
    if (this._isBound && this._lockDownProgramCodeWhenBound)
      return;
    if (this.LockDownProgramCodeOnEndorsements)
      return;
    try
    {
      foreach (dsQuoteEdit.tblQuoteDetailsRow row in this.dsQuoteEdit.tblQuoteDetails.Rows)
      {
        if (row.RowState != DataRowState.Deleted)
        {
          int detailProgramCode = this.GetQuoteDetailProgramCode(row.CompanyLineGuid);
          if (!this._savingData)
          {
            if (detailProgramCode != int.MinValue && detailProgramCode != -1)
              row.ProgramID = detailProgramCode;
            else
              row.SetProgramIDNull();
          }
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

  private bool ValidateNewQuotesCompLineReq()
  {
    bool flag;
    if (!this.IsNewQuote)
    {
      flag = true;
    }
    else
    {
      Decimal? nullable = new Decimal?(SystemSettings.GetSetting<Decimal>("BindingRequirements.NewQuoteStatusID", 0M));
      if (!nullable.HasValue)
      {
        flag = true;
      }
      else
      {
        StringBuilder stringBuilder = new StringBuilder();
        try
        {
          foreach (dsQuoteEdit.tblQuoteDetailsRow row in this.dsQuoteEdit.tblQuoteDetails.Rows)
            stringBuilder.Append(row.CompanyLineGuid.ToString()).Append(',');
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        if (this.dsQuoteEdit.tblQuoteDetails.Rows.Count > 1)
          stringBuilder.Append(this.CompanyLineGuid.ToString()).Append(',');
        object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.StoredProcedure, "spCheckNewQuoteStatusRequirements", 0, (CommandArgumentType) 0, new object[6]
        {
          (object) "@SubmissionGroupGuid",
          (object) this._submissionGroupGuid,
          (object) "@CompanyLineString",
          (object) stringBuilder.ToString(),
          (object) "@QuoteStatusID",
          (object) Convert.ToInt32(nullable.Value)
        }));
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
        {
          int num = (int) MessageBox.Show(objectValue.ToString(), "Company/line New Quote Requirements Are Not Satisfied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
        }
        else
          flag = true;
      }
    }
    return flag;
  }

  protected virtual bool ValidForm()
  {
    bool flag1 = this.ValidatePolicyTerm(this.ValidatePolicyType(this.ValidateBillingType(this.ValidateUnderwriter(this.ValidateOffices(this.ValidateCompanyLineState())))));
    ((UltraGridBase) this.ugPolicyDetail).UpdateData();
    if (flag1)
      flag1 = this.ValidGrid();
    if (flag1 && this.IsNewQuote && this.ValidCompanyLineGuid)
      flag1 = this.VerifyAuthorizedProducer();
    if (flag1)
      flag1 = this.ValidateParticipation();
    if (flag1)
      flag1 = this.CheckValidDates();
    if (flag1)
      flag1 = this.WarnOnEffectiveDate();
    bool flag2;
    if (!flag1)
    {
      ((UltraTabControlBase) this.tabPolicyInfo).SelectedTab = ((UltraTabControlBase) this.tabPolicyInfo).Tabs["tabRequiredInfo"];
      flag2 = false;
    }
    else
    {
      if (flag1)
      {
        flag1 = this.ValidateSecondTab();
        if (!flag1)
        {
          ((UltraTabControlBase) this.tabPolicyInfo).SelectedTab = ((UltraTabControlBase) this.tabPolicyInfo).Tabs["tabOtherInfo"];
          flag2 = false;
          goto label_42;
        }
      }
      if (!this.IsNewQuote && !this._quote.IsEndorsement && !this.dsQuoteEdit.tblQuotes[0].IsRetailerGuidNull())
        flag1 = this.VerifyOpenRetailer();
      if (!flag1)
      {
        ((UltraTabControlBase) this.tabPolicyInfo).SelectedTab = ((UltraTabControlBase) this.tabPolicyInfo).Tabs["tabOtherInfo"];
        flag2 = false;
      }
      else
      {
        bool flag3 = this.ValidatePremiumInfoTab();
        if (!flag3)
        {
          ((UltraTabControlBase) this.tabPolicyInfo).SelectedTab = ((UltraTabControlBase) this.tabPolicyInfo).Tabs["tabPremiumInfo"];
          flag2 = false;
        }
        else
        {
          if (flag3)
            this.VerifyDetailRecords();
          if (!this.IsNewQuote && flag3)
            flag3 = this.ClearCompanyForms();
          if (flag3)
            flag3 = this.VerifySICCodes();
          if (flag3 && this.IsNewQuote && this.ValidCompanyLineGuid)
            flag3 = this.VerifyActiveSetup();
          if (flag3 && this.IsNewQuote)
            flag3 = this.VerifyClearance() && this.VerifyProducerRequirements() && this.VerifyProducerLineBlocked();
          if (flag3)
            flag3 = this.ValidateProgramCode();
          if (flag3 && this.IsNewQuote && this._validateProducerLicenseOnQuoteCreation)
            flag3 = this.ValidateProducerLicense();
          if (flag3)
            flag3 = this.ValidateChildPolicyNumbers();
          if (flag3)
            flag3 = this.ValidateNewQuotesCompLineReq();
          if (flag3)
            this.OnCompanyChanged();
          flag2 = flag3;
        }
      }
    }
label_42:
    return flag2;
  }

  protected virtual void DoSave(SqlTransaction t)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmQuoteEdit._Closure\u0024__549\u002D0 closure5490 = new frmQuoteEdit._Closure\u0024__549\u002D0();
    // ISSUE: reference to a compiler-generated field
    closure5490.\u0024VB\u0024Me = this;
    MDIControls.Instance.StatusBarText = "Saving data...";
    if (this.IsNewQuote)
    {
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) t, new ExecuteHandler((object) this, __methodptr(_Lambda\u0024__549\u002D0)));
    }
    if (this._maxControlNo != -1)
      this.dsQuoteEdit.tblQuotes[0].ControlNo = this._maxControlNo;
    else
      this._maxControlNo = this.dsQuoteEdit.tblQuotes[0].ControlNo;
    this.daQuotes.InsertCommand.Transaction = (DbTransaction) t;
    this.daQuotes.UpdateCommand.Transaction = (DbTransaction) t;
    DefaultDatabase.DataAdapterUpdate(this.daQuotes, (DataTable) this.dsQuoteEdit.tblQuotes);
    // ISSUE: method pointer
    DefaultDatabase.EnlistTransaction((DbTransaction) t, new ExecuteHandler((object) closure5490, __methodptr(_Lambda\u0024__1)));
    // ISSUE: reference to a compiler-generated field
    closure5490.\u0024VB\u0024Local_tmpCurrencyCode = "USD";
    if (this._isMultiCurrencyActive)
    {
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraCombo) this.comboCurrencyCode).Value)))
        ((UltraCombo) this.comboCurrencyCode).Value = (object) "USD";
      // ISSUE: reference to a compiler-generated field
      closure5490.\u0024VB\u0024Local_tmpCurrencyCode = ((UltraCombo) this.comboCurrencyCode).Value.ToString();
    }
    // ISSUE: method pointer
    DefaultDatabase.EnlistTransaction((DbTransaction) t, new ExecuteHandler((object) closure5490, __methodptr(_Lambda\u0024__2)));
    DbDataAdapter daQuoteDetails = this.daQuoteDetails;
    daQuoteDetails.InsertCommand.Transaction = (DbTransaction) t;
    daQuoteDetails.InsertCommand.CommandTimeout = 300;
    daQuoteDetails.UpdateCommand.Transaction = (DbTransaction) t;
    daQuoteDetails.UpdateCommand.CommandTimeout = 300;
    daQuoteDetails.DeleteCommand.Transaction = (DbTransaction) t;
    daQuoteDetails.DeleteCommand.CommandTimeout = 300;
    DefaultDatabase.DataAdapterUpdate(this.daQuoteDetails, (DataTable) this.dsQuoteEdit.tblQuoteDetails);
    if (!this.IsNewQuote && !this.dsQuoteEdit.tblQuotes[0].IsFinanceCompanyGuidNull())
    {
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) t, new ExecuteHandler((object) closure5490, __methodptr(_Lambda\u0024__3)));
    }
    this._quoteGuid = this.dsQuoteEdit.tblQuotes[0].QuoteGuid;
    MDIControls.Instance.StatusBarText = string.Empty;
  }

  protected bool NoItemSelected(MGASimpleComboBox cbo)
  {
    if (cbo == null)
      throw new ArgumentNullException(nameof (cbo));
    if (((UltraDropDownBase) cbo).SelectedRow == null)
      return true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraDropDownBase) cbo).SelectedRow.Cells[((UltraDropDownBase) cbo).DisplayMember].Value.ToString(), string.Empty, false) != 0)
      return false;
    return !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(((UltraCombo) cbo).Value)) || Conversions.ToInteger(((UltraCombo) cbo).Value) <= 1;
  }

  protected virtual void AfterEffectiveDateValueChange()
  {
  }

  protected virtual bool CheckValidEffectiveDate()
  {
    bool flag;
    if (DateTime.Compare(Conversions.ToDate(((UltraDateTimeEditor) this.dtEffectiveDate).Value), Conversions.ToDate(((UltraDateTimeEditor) this.dtExpirationDate).Value)) >= 0)
    {
      int num = (int) MessageBox.Show("The Expiration date must occur after the the Effective Date.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  protected virtual void QuoteDataChanged(dsQuoteEdit.tblQuotesRow dr)
  {
  }

  protected virtual void QuotingOfficeValueChange(object sender, EventArgs e)
  {
  }

  protected virtual bool ReComputeCommissionsOnOnExpiringCarrier() => true;

  protected virtual bool ValidateProgramCode()
  {
    bool flag = true;
    Conversions.ToDate(Conversions.ToDate(((UltraDateTimeEditor) this.dtEffectiveDate).Value).ToShortDateString());
    foreach (UltraGridRow row in ((UltraGridBase) this.ugPolicyDetail).Rows)
    {
      if (row.Cells["ProgramID"].Value == DBNull.Value)
      {
        switch (this.GetQuoteDetailProgramCode((Guid) row.Cells["CompanyLineGuid"].Value))
        {
          case int.MinValue:
            continue;
          default:
            flag = false;
            int num = (int) MessageBox.Show("Please select a valid program code in the grid.", "Missing Program Code", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            continue;
        }
      }
    }
    return flag;
  }

  private static bool NoItemGuidSelected(MGASimpleComboBox cbo)
  {
    return ((UltraDropDownBase) cbo).SelectedRow == null || ((UltraCombo) cbo).Value.Equals((object) Guid.Empty);
  }

  private bool ValidateCommissions(UltraGridRow row, ProducerLocation pl)
  {
    bool flag = true;
    object objectValue1 = RuntimeHelpers.GetObjectValue(row.Cells["CompanyCommission"].Value);
    object objectValue2 = RuntimeHelpers.GetObjectValue(row.Cells["ProducerCommission"].Value);
    Guid companyLineGuid = (Guid) row.Cells["CompanyLineGuid"].Value;
    object obj1 = (object) null;
    object obj2 = (object) null;
    if (row.Cells["ProgramID"].Value != DBNull.Value && row.Cells["ProgramID"].Value != null)
      obj2 = RuntimeHelpers.GetObjectValue(row.Cells["ProgramID"].Value);
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboPolicyType).Text))
      obj1 = RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboPolicyType).Value);
    Decimal producerMaxCommission = this.GetProducerMaxCommission(companyLineGuid, this.IsCommissionRenewal, RuntimeHelpers.GetObjectValue(obj2));
    Decimal commission = pl.GetCommission(companyLineGuid, this.IsCommissionRenewal, this.EffectiveDate, (SqlTransaction) null, RuntimeHelpers.GetObjectValue(obj1), RuntimeHelpers.GetObjectValue(obj2), this.OfficeGuidForProducerLocation);
    if (objectValue2 != DBNull.Value)
    {
      if (Decimal.Compare(producerMaxCommission, Decimal.MaxValue) == 0 && Decimal.Compare((Decimal) objectValue2, commission) > 0)
      {
        Appearance appearance = row.Cells["ProducerCommission"].Appearance;
        appearance.BackColor = Color.MistyRose;
        appearance.BackColor2 = Color.Red;
        appearance.BackGradientStyle = (GradientStyle) 3;
        flag = false;
        try
        {
          this.Tip.SetToolTip((Control) this.ugPolicyDetail, $"The producer commission must be less than or equal to the producer default commission ({commission.ToString("p")}).");
        }
        catch (InvalidOperationException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
      }
      else if (Decimal.Compare((Decimal) objectValue2, producerMaxCommission) > 0 && !SecurityManager.Instance.AssertPermission("{B30F4951-B61B-4501-87B6-180553B30E47}"))
      {
        Appearance appearance = row.Cells["ProducerCommission"].Appearance;
        appearance.BackColor = Color.MistyRose;
        appearance.BackColor2 = Color.Red;
        appearance.BackGradientStyle = (GradientStyle) 3;
        flag = false;
        try
        {
          this.Tip.SetToolTip((Control) this.ugPolicyDetail, $"The producer commission must be less than or equal to the maximum producer commission ({producerMaxCommission.ToString("p")}).");
        }
        catch (InvalidOperationException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
      }
    }
    if (objectValue1 != DBNull.Value && (Decimal.Compare((Decimal) objectValue1, 1M) > 0 || Decimal.Compare((Decimal) objectValue1, 0M) < 0))
    {
      Appearance appearance = row.Cells["CompanyCommission"].Appearance;
      appearance.BackColor = Color.MistyRose;
      appearance.BackColor2 = Color.Red;
      appearance.BackGradientStyle = (GradientStyle) 3;
      flag = false;
      try
      {
        this.Tip.SetToolTip((Control) this.ugPolicyDetail, "The company commission must be a number from 0 to 1.");
      }
      catch (InvalidOperationException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
    if (objectValue2 != DBNull.Value && (Decimal.Compare((Decimal) objectValue2, 1M) > 0 || Decimal.Compare((Decimal) objectValue2, 0M) < 0))
    {
      Appearance appearance = row.Cells["ProducerCommission"].Appearance;
      appearance.BackColor = Color.MistyRose;
      appearance.BackColor2 = Color.Red;
      appearance.BackGradientStyle = (GradientStyle) 3;
      flag = false;
      try
      {
        this.Tip.SetToolTip((Control) this.ugPolicyDetail, "The producer commission must be a number from 0 to 1.");
      }
      catch (InvalidOperationException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
    if (objectValue1 != DBNull.Value && objectValue2 != DBNull.Value && Decimal.Compare((Decimal) objectValue2, (Decimal) objectValue1) > 0)
    {
      Appearance appearance = row.Cells["ProducerCommission"].Appearance;
      appearance.BackColor = Color.MistyRose;
      appearance.BackColor2 = Color.Red;
      appearance.BackGradientStyle = (GradientStyle) 3;
      flag = false;
      try
      {
        this.Tip.SetToolTip((Control) this.ugPolicyDetail, "The producer commission must be less than the company commission for all items on this policy.");
      }
      catch (InvalidOperationException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
    return flag;
  }

  private bool ValidGrid()
  {
    try
    {
      if (this._showSlaNumber)
        ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Bands[0].Columns["SLA_Number"].Hidden = true;
      bool flag = true;
      RowEnumerator enumerator = ((UltraGridBase) this.ugPolicyDetail).Rows.GetEnumerator();
      while (enumerator.MoveNext())
      {
        UltraGridRow current = enumerator.Current;
        foreach (UltraGridCell cell in current.Cells)
        {
          if (!cell.Column.Hidden && cell.Value == DBNull.Value && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cell.Column.Key, "Participation", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cell.Column.Key, "ProgramID", false) != 0 && !this.ClientValidCells(cell))
          {
            if ((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cell.Column.Key, "IntermediaryContactGuid", false) != 0 || cell.Row.Cells["CompanyContactGuid"].Value == DBNull.Value) && (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cell.Column.Key, "CompanyContactGuid", false) != 0 || cell.Row.Cells["IntermediaryContactGuid"].Value == DBNull.Value))
            {
              Appearance appearance = cell.Appearance;
              appearance.BackColor = Color.MistyRose;
              appearance.BackColor2 = Color.Red;
              appearance.BackGradientStyle = (GradientStyle) 3;
              flag = false;
            }
          }
          else
            cell.Appearance.Reset();
        }
        Guid CompanyLineGuid = (Guid) current.Cells["CompanyLineGuid"].Value;
        ProducerLocation pl = new ProducerLocation(this.ProducerLocationGuid);
        if (!this.IsNewQuote)
        {
          dsQuoteEdit.tblQuoteDetailsRow guidCompanyLineGuid = this.dsQuoteEdit.tblQuoteDetails.FindByQuoteGuidCompanyLineGuid(this.QuoteGuid, CompanyLineGuid);
          if ((Database.DataHasChanged((DataRow) guidCompanyLineGuid, guidCompanyLineGuid.Table.Columns["CompanyCommission"]) || Database.DataHasChanged((DataRow) guidCompanyLineGuid, guidCompanyLineGuid.Table.Columns["ProducerCommission"]) || !string.IsNullOrEmpty(((UltraCombo) this.cboPolicyType).Text) && this._originalPolicyTypeId != Conversions.ToInteger(((UltraCombo) this.cboPolicyType).Value)) && pl.IsAuthorizedForCompanyLine(CompanyLineGuid) && !this.ValidateCommissions(current, pl))
            flag = false;
        }
        else if (flag)
          flag = this.ValidateCommissions(current, pl);
      }
      if (flag)
        flag = this.ValidMaxCompanyCommisison();
      return flag;
    }
    finally
    {
      if (this._showSlaNumber)
        ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Bands[0].Columns["SLA_Number"].Hidden = false;
    }
  }

  private bool WarnOnEffectiveDate()
  {
    DateTime serverTime = CurrentUser.ServerTime;
    TimeSpan timeSpan = Conversions.ToDate(((UltraDateTimeEditor) this.dtEffectiveDate).Value) - serverTime;
    int days = timeSpan.Days;
    if (timeSpan.Hours >= 12)
      ++days;
    bool flag;
    if (days > 0)
    {
      Decimal? setting = SystemSettings.GetSetting<Decimal?>("WarnOnEffectiveDateDays", new Decimal?());
      if (setting.HasValue && Decimal.Compare(new Decimal(timeSpan.Days), setting.Value) > 0 && MessageBox.Show($"The effective date of this policy is {timeSpan.Days} days from today.{"\n"}{"\n"}Is this correct?", "Confirm Effective Date", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      {
        flag = false;
        goto label_9;
      }
    }
    if (days < 0)
    {
      Decimal? setting = SystemSettings.GetSetting<Decimal?>("BackDaysForEffectiveDate", new Decimal?());
      if (setting.HasValue && Decimal.Compare(new Decimal(-timeSpan.Days), setting.Value) > 0 && MessageBox.Show($"The effective date of this policy is {-timeSpan.Days} days in the past.{"\n"}{"\n"}Is this correct?", "Confirm Effective Date", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      {
        flag = false;
        goto label_9;
      }
    }
    flag = true;
label_9:
    return flag;
  }

  private bool ValidateCompanyLineState()
  {
    bool flag = true;
    this.err.SetError((Control) this.cboCompanies, string.Empty);
    this.err.SetError((Control) this.comboCurrencyCode, string.Empty);
    this.err.SetError((Control) this.cboState, string.Empty);
    this.err.SetError((Control) this.cboLine, string.Empty);
    if (!this.IsQuickQuote && this.NoItemSelected(this.cboCompanies))
    {
      this.err.SetError((Control) this.cboCompanies, "Please select a company before saving.");
      flag = false;
    }
    if (((Control) this.comboCurrencyCode).Visible && this.NoItemSelected(this.comboCurrencyCode))
    {
      this.err.SetError((Control) this.comboCurrencyCode, "Please select a currency code before saving.");
      flag = false;
    }
    if (!this.IsQuickQuote && this.NoItemSelected(this.cboState))
    {
      this.err.SetError((Control) this.cboState, "Please select a state.");
      flag = false;
    }
    if (this.NoItemSelected(this.cboLine))
    {
      this.err.SetError((Control) this.cboLine, "Please select a line of business.");
      flag = false;
    }
    return flag;
  }

  private bool ValidateOffices(bool valid)
  {
    if (this.NoItemSelected(this.cboQuotingOffice))
    {
      this.err.SetError((Control) this.cboQuotingOffice, "Please select the quoting office.");
      valid = false;
    }
    else
      this.err.SetError((Control) this.cboQuotingOffice, string.Empty);
    if (this.NoItemSelected(this.cboIssuingOffice))
    {
      this.err.SetError((Control) this.cboIssuingOffice, "Please select the issuing office.");
      valid = false;
    }
    else
      this.err.SetError((Control) this.cboIssuingOffice, string.Empty);
    return valid;
  }

  private bool ValidateBillingType(bool valid)
  {
    if (!this.IsQuickQuote && this.NoItemSelected(this.cboBillingTypes))
    {
      this.err.SetError((Control) this.cboBillingTypes, "Please select the billing type for this policy.");
      valid = false;
    }
    else
      this.err.SetError((Control) this.cboBillingTypes, string.Empty);
    if (valid && !this.IsNewQuote && !this.IsQuickQuote && !this.NoItemSelected(this.cboBillingTypes) && ((UltraGridBase) this.cboBillingTypes).Rows.Count > 2)
    {
      if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblCompanyBillingTypes WITH (NOLOCK) WHERE CompanyLineGuid = @CL AND Downpayment = 0 AND BillingTypeID = @BT", new object[4]
      {
        (object) "@CL",
        (object) this.CompanyLineGuid,
        (object) "@BT",
        (object) Conversions.ToInteger(((UltraCombo) this.cboBillingTypes).Value)
      }) == 0)
      {
        int num = (int) MessageBox.Show($"Please note that the selected billing type \n\n{((UltraCombo) this.cboBillingTypes).Text}\n\nis not a selection on the company / line.", "Company / Line Billing Type", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }
    return valid;
  }

  private bool ValidateUnderwriter(bool valid)
  {
    if (frmQuoteEdit.NoItemGuidSelected(this.cboUnderwriter))
    {
      this.err.SetError((Control) this.cboUnderwriter, "Please select the underwriter for this policy.");
      valid = false;
    }
    else
      this.err.SetError((Control) this.cboUnderwriter, string.Empty);
    return valid;
  }

  private bool ValidatePolicyType(bool valid)
  {
    if (this.NoItemSelected(this.cboPolicyType))
    {
      this.err.SetError((Control) this.cboPolicyType, "Please select a policy type from the list.");
      valid = false;
    }
    else
      this.err.SetError((Control) this.cboPolicyType, string.Empty);
    return valid;
  }

  private bool ValidatePolicyTerm(bool valid)
  {
    this.err.SetError((Control) this.dtEffectiveDate, string.Empty);
    this.err.SetError((Control) this.dtExpirationDate, string.Empty);
    if (((UltraDateTimeEditor) this.dtEffectiveDate).Value == null && ((UltraDateTimeEditor) this.dtEffectiveDate).Value != DBNull.Value)
    {
      this.err.SetError((Control) this.dtEffectiveDate, "Please enter value.");
      valid = false;
    }
    if (((UltraDateTimeEditor) this.dtExpirationDate).Value == null && ((UltraDateTimeEditor) this.dtExpirationDate).Value != DBNull.Value)
    {
      this.err.SetError((Control) this.dtExpirationDate, "Please enter value.");
      valid = false;
    }
    return valid;
  }

  private bool VerifyProducerLineBlocked()
  {
    bool flag;
    if (!SystemSettings.GetSetting<bool>("VerifyProducerLinesBlockedOnNewQuotes", false))
    {
      flag = true;
    }
    else
    {
      Guid guid = this.CompanyLineGuid;
      if (guid.Equals(Guid.Empty))
      {
        flag = true;
      }
      else
      {
        guid = this.QuotingOfficeGuid;
        if (guid.Equals(Guid.Empty))
          flag = true;
        else if (!new ProducerLine(this.ProducerLocationGuid, this.CompanyLineGuid, this.EffectiveDate, this.QuotingOfficeGuid).Exists)
          flag = true;
        else if (Conversions.ToBoolean(DefaultDatabase.ExecuteScalar("spIsTheCurrentProducerLineBlocked", new object[6]
        {
          (object) "@producerLocationGuid",
          (object) this.ProducerLocationGuid,
          (object) "@CompanyLineGuid",
          (object) this.CompanyLineGuid,
          (object) "@PolicyTypeID",
          (object) Conversions.ToInteger(((UltraCombo) this.cboPolicyType).Value)
        })))
        {
          int num = (int) MessageBox.Show("This producer/line is currently blocked.  No quotes can be created.", "Blocked Setup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          flag = false;
        }
        else
          flag = true;
      }
    }
    return flag;
  }

  private bool VerifyClearance()
  {
    this._allowClearance = DefaultDatabase.ExecuteScalar<bool>("spIsValidUserClearance", new object[6]
    {
      (object) "@userGUID",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@lineGUID",
      (object) (Guid) ((UltraCombo) this.cboLine).Value,
      (object) "@submissionGroupGuid",
      (object) this._submissionGroupGuid
    });
    if (!this._allowClearance)
    {
      int num = (int) MessageBox.Show($"You are not allowed to create new quotes using '{((UltraCombo) this.cboLine).Text}' line.\n\nPlease Note: If there are no quotes under the submission group, it will be deleted.\nIf there are no submissions under the insured, it will be deleted as well.", "New Quotes Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      ((Form) this).Close();
    }
    return this._allowClearance;
  }

  private bool VerifyProducerRequirements()
  {
    int num1 = DefaultDatabase.ExecuteScalar<bool>(SystemSettings.GetSetting<string>("ProducerRequirementsSatisfiedStoredProc", "dbo.spIsProducerRequirementsSatisfied"), new object[10]
    {
      (object) "@submissionGroupGuid",
      (object) this._submissionGroupGuid,
      (object) "@producerLocationGuid",
      (object) this.ProducerLocationGuid,
      (object) "@requirementType",
      (object) "N",
      (object) "@ExpirationDate",
      (object) this.ExpirationDate,
      (object) "@EffectiveDate",
      (object) this.EffectiveDate
    }) ? 1 : 0;
    if (num1 != 0)
      return num1 != 0;
    int num2 = (int) MessageBox.Show("At least one specified producer requirement marked 'Needed to Clear' is not on file.\n\nOr its 'Valid Through' date occurs before the current date.", "Invalid Producer Requirement", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    return num1 != 0;
  }

  private bool VerifyDetailRecords()
  {
    bool flag;
    if (!this.IsQuickQuote && this.dsQuoteEdit.tblQuoteDetails.Rows.Count == 0)
    {
      int num = (int) MessageBox.Show("Unable to save: there are no participating companies assigned to this policy.", "No Companies On Policy", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private bool VerifyAuthorizedProducer()
  {
    bool flag;
    if ((PolicyTypes) Enum.Parse(typeof (PolicyTypes), ((UltraCombo) this.cboPolicyType).Value.ToString()) == 2)
    {
      ProducerLine producerLine = new ProducerLine(this.ProducerLocationGuid, this.CompanyLineGuid, this.EffectiveDate, this.QuotingOfficeGuid);
      bool disabled;
      try
      {
        disabled = producerLine.Disabled;
      }
      catch (NoProducerLineException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show(ex.Message, "No Setups Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_8;
      }
      if (disabled)
      {
        this.err.SetError((Control) this.cboPolicyType, "This producer is not active for renewals.");
        int num = (int) MessageBox.Show("This producer is not active for renewals.", "Invalid Policy Type", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag = false;
        goto label_8;
      }
      this.err.SetError((Control) this.cboPolicyType, string.Empty);
    }
    flag = true;
label_8:
    return flag;
  }

  private bool ValidateParticipation()
  {
    double num1 = 0.0;
    try
    {
      foreach (dsQuoteEdit.tblQuoteDetailsRow tblQuoteDetail in (TypedTableBase<dsQuoteEdit.tblQuoteDetailsRow>) this.dsQuoteEdit.tblQuoteDetails)
      {
        if (tblQuoteDetail.RowState != DataRowState.Deleted && !tblQuoteDetail.IsParticipationNull())
          num1 += Convert.ToDouble(tblQuoteDetail.Participation);
      }
    }
    finally
    {
      IEnumerator<dsQuoteEdit.tblQuoteDetailsRow> enumerator;
      enumerator?.Dispose();
    }
    bool flag;
    if (num1 != 0.0 && (num1 < 0.9999 || num1 > 1.0))
    {
      int num2 = (int) MessageBox.Show($"When participation values are specified, they must sum to 100% for the policy.\n\nThe participations on this policy currently add up to {((int) Math.Round(num1 * 100.0)).ToString()}%", "Invalid Participation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private bool CheckValidDates()
  {
    return RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT OriginalQuoteGuid FROM tblQuotes WITH (NOLOCK) WHERE QuoteGuid=@QuoteGuid", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid
    })) != DBNull.Value || this.CheckValidEffectiveDate();
  }

  private bool ValidateSecondTab()
  {
    bool flag;
    if (this.NoItemSelected(this.cboProducerContact))
    {
      this.err.SetError((Control) this.cboProducerContact, "Please select a contact at this producer.");
      flag = false;
    }
    else
    {
      this.err.SetError((Control) this.cboProducerContact, string.Empty);
      flag = true;
    }
    return flag;
  }

  private bool ValidatePremiumInfoTab()
  {
    bool flag;
    if (((UltraNumericEditor) this.numMinimumEarned).Value != DBNull.Value && Decimal.Compare(Conversions.ToDecimal(((UltraNumericEditor) this.numMinimumEarned).Value), 1M) > 0)
    {
      this.err.SetError((Control) this.numMinimumEarned, "Invalid minimum earned percentage.");
      flag = false;
    }
    else
    {
      if (((UltraNumericEditor) this.numMinimumEarned).Value != DBNull.Value && Decimal.Compare(Conversions.ToDecimal(((UltraNumericEditor) this.numMinimumEarned).Value), 0M) == 0)
        ((UltraNumericEditor) this.numMinimumEarned).Value = (object) DBNull.Value;
      else
        this.err.SetError((Control) this.numMinimumEarned, string.Empty);
      if (!SecurityManager.Instance.AssertPermission("{4F98C444-D47F-456d-8C81-9BF3B09214CE}") && ((UltraCombo) this.cboLine).Value != null)
      {
        if (DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "select ReqTargetPremium from lstLines where LineGuid = @LineGuid", new object[2]
        {
          (object) "@LineGuid",
          ((UltraCombo) this.cboLine).Value
        }))
        {
          if (((UltraNumericEditor) this.numTargetPremium).Value.Equals((object) DBNull.Value))
          {
            this.err.SetError((Control) this.numTargetPremium, "Target premium required for this line of business.");
            flag = false;
            goto label_11;
          }
          this.err.SetError((Control) this.numTargetPremium, string.Empty);
        }
      }
      flag = true;
    }
label_11:
    return flag;
  }

  private bool VerifyOpenRetailer()
  {
    bool flag;
    if (DefaultDatabase.ExecuteScalar<byte>(CommandType.Text, "SELECT StatusID FROM tblProducerLocations WITH (NOLOCK) WHERE ProducerLocationGuid = @ProducerLocationGuid", new object[2]
    {
      (object) "@ProducerLocationGuid",
      (object) this.dsQuoteEdit.tblQuotes[0].RetailerGuid
    }) == (byte) 3)
    {
      if (SecurityManager.Instance.AssertPermission("{2530D549-1747-4133-84D9-D6ECAE73DB37}"))
      {
        flag = MessageBox.Show("Warning: This retailer is closed.\n\nWould you like to save anyway?", "Closed Retailer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes;
      }
      else
      {
        int num = (int) MessageBox.Show("This policy can not be saved, because the retailer is closed.", "Closed Retailer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag = false;
      }
    }
    else
      flag = true;
    return flag;
  }

  private bool VerifyActiveSetup()
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT StatusID FROM tblCompanyLines WITH (NOLOCK) WHERE CompanyLineGuid=@CompanyLineGuid", new object[2]
    {
      (object) "@CompanyLineGuid",
      (object) this.CompanyLineGuid
    }));
    int num1 = -1;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
      num1 = Conversions.ToInteger(objectValue);
    bool flag;
    if (num1 != 1)
    {
      int num2 = (int) MessageBox.Show("This company/line setup is not currently active, and can not be saved.", "Inactive Company/Line Setup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private bool VerifySICCodes()
  {
    bool flag;
    if (((UltraCombo) this.cboRiskClass).Value != DBNull.Value && this.ValidCompanyLineGuid)
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Access FROM tblCompany_SIC WITH (NOLOCK) WHERE SIC_Code=@SIC_Code AND CompanyLineGuid=@CompanyLineGuid", new object[4]
      {
        (object) "@SIC_Code",
        (object) (string) ((UltraCombo) this.cboRiskClass).Value,
        (object) "@CompanyLineGuid",
        (object) this.CompanyLineGuid
      }));
      if (objectValue != null)
      {
        string Left = objectValue.ToString();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "R", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "P", false) == 0)
          {
            int num = (int) MessageBox.Show("This quote can not be saved, because the SIC code is restricted.", "Restricted SIC Code", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            flag = false;
            goto label_9;
          }
        }
        else if (MessageBox.Show("This SIC code is restricted.\n\nDo you want to continue?", "Restricted SIC Code", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        {
          CurrentUser.Instance.LogAction("Confirmed save with restricted SIC Code", this.QuoteGuid);
        }
        else
        {
          flag = false;
          goto label_9;
        }
      }
    }
    flag = true;
label_9:
    return flag;
  }

  private bool ValidateProducerLicense()
  {
    bool flag = true;
    if (!this.IsEmptyComboBoxValue(this.cboState))
    {
      if (!DefaultDatabase.ExecuteScalar<bool>(nameof (ValidateProducerLicense), new object[4]
      {
        (object) "@StateID",
        ((UltraCombo) this.cboState).Value,
        (object) "@SubmissionGroupGuid",
        (object) this._submissionGroupGuid
      }))
      {
        flag = false;
        int num = (int) MessageBox.Show("This producer needs a valid license to create policies in the state of " + ((UltraCombo) this.cboState).Text, "Invalid Producer License", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
    return flag;
  }

  private bool ClearCompanyForms()
  {
    bool flag1;
    if (!this.dsQuoteEdit.tblQuotes[0].IsCompanyLocationGuidNull() && ((UltraCombo) this.cboCompanies).Value == null)
      flag1 = true;
    else if (!this.dsQuoteEdit.tblQuotes[0].IsCompanyLocationGuidNull() && !this._originalCompanyLocationGuid.Equals(Guid.Empty) && !((UltraCombo) this.cboCompanies).Value.Equals((object) this._originalCompanyLocationGuid))
      flag1 = true;
    bool flag2;
    if (flag1)
    {
      if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblQuoteFormsConditionsWarranties WITH (NOLOCK)  WHERE QuoteID=@QuoteID", new object[2]
      {
        (object) "@QuoteID",
        (object) this._quote.QuoteID
      }) > 0)
      {
        if (MessageBox.Show("You have changed the company on this quote.\n\nThis will remove all policy forms, conditions, and warranties currently applied.\n\nAre you sure you want to continue?", "Company Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        {
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteFormsConditionsWarranties WHERE QuoteID=@QuoteID", new object[2]
          {
            (object) "@QuoteID",
            (object) this._quote.QuoteID
          });
        }
        else
        {
          flag2 = false;
          goto label_10;
        }
      }
    }
    flag2 = true;
label_10:
    return flag2;
  }

  private void ComboExpiringCarrier_ValueChanged(object sender, EventArgs e)
  {
    if (!this._readyToShowParticipants || !this.IsNewQuote && this.Quote.IsBound || !this.ReComputeCommissionsOnOnExpiringCarrier())
      return;
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT COUNT(tblQuotes.QuoteID) AS ExpiringCommExists FROM tblCompanyLineCommissions INNER JOIN tblCompanyLines ON tblCompanyLineCommissions.CompanyLineID = tblCompanyLines.CompanyLineID INNER JOIN tblQuoteDetails ON tblCompanyLines.CompanyLineGUID = tblQuoteDetails.CompanyLineGuid INNER JOIN tblQuotes ON tblQuoteDetails.QuoteGuid = tblQuotes.QuoteGUID WHERE (tblQuotes.QuoteGUID = @QuoteGUID) AND (tblCompanyLineCommissions.ExpiringCompanyLocationGuid = @ExpiringCarrier)", new object[4]
    {
      (object) "@QuoteGUID",
      (object) this.QuoteGuid,
      (object) "@ExpiringCarrier",
      ((UltraCombo) this.comboExpiringCarrier).Value
    }))))
      return;
    if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(tblQuotes.QuoteID) AS ExpiringCommExists FROM tblCompanyLineCommissions INNER JOIN tblCompanyLines ON tblCompanyLineCommissions.CompanyLineID = tblCompanyLines.CompanyLineID INNER JOIN tblQuoteDetails ON tblCompanyLines.CompanyLineGUID = tblQuoteDetails.CompanyLineGuid INNER JOIN tblQuotes ON tblQuoteDetails.QuoteGuid = tblQuotes.QuoteGUID WHERE (tblQuotes.QuoteGUID = @QuoteGUID) AND (tblCompanyLineCommissions.ExpiringCompanyLocationGuid = @ExpiringCarrier)", new object[4]
    {
      (object) "@QuoteGUID",
      (object) this.QuoteGuid,
      (object) "@ExpiringCarrier",
      ((UltraCombo) this.comboExpiringCarrier).Value
    }) < 1 || MessageBox.Show("Changing the expiring carrier can alter commission amounts.\n\nWould you like to refresh the commission values now?", "Refresh Commissions?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    this.GetCommissions(false);
  }

  private bool ValidatePolicyEffectiveVersusRenewal()
  {
    bool flag1 = true;
    this.AllowSaveWithLapseInRenewalPolicyTerms = false;
    bool flag2;
    if (((UltraDateTimeEditor) this.dtEffectiveDate).Value == null || ((UltraDateTimeEditor) this.dtEffectiveDate).Value == DBNull.Value)
      flag2 = false;
    else if (this.IsNewQuote)
      flag2 = true;
    else if (this._effectiveDate.Equals(Conversions.ToDate(((UltraDateTimeEditor) this.dtEffectiveDate).Value)))
      flag2 = true;
    else if ((PolicyTypes) Enum.Parse(typeof (PolicyTypes), ((UltraCombo) this.cboPolicyType).Value.ToString()) != 2)
    {
      flag2 = true;
    }
    else
    {
      Guid guid = Utility.IsNull<Guid>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT RenewalOfQuoteGuid FROM tblQuotes WITH (NOLOCK)  WHERE QuoteGuid = @QG", new object[2]
      {
        (object) "@QG",
        (object) this.Quote.QuoteGuid
      })), Guid.Empty);
      if (guid.Equals(Guid.Empty))
      {
        flag2 = true;
      }
      else
      {
        if (!DefaultDatabase.ExecuteScalar<bool>("dbo.spValidateCurrentAndRenewalPolicyPeriod", new object[4]
        {
          (object) "@currentQuoteGuid",
          (object) this._quote.QuoteGuid,
          (object) "@currentQuoteEffectiveDate",
          ((UltraDateTimeEditor) this.dtEffectiveDate).Value
        }))
        {
          Quote quote = new Quote(guid);
          if (SecurityManager.Instance.AssertPermission("{FE9DCF65-E1BA-46c8-89B3-AD8D50C2150C}"))
          {
            string[] strArray = new string[7];
            strArray[0] = "The current policy effective date of ";
            DateTime dateTime = Conversions.ToDate(((UltraDateTimeEditor) this.dtEffectiveDate).Value);
            strArray[1] = dateTime.ToShortDateString();
            strArray[2] = " does not match the expiration date of ";
            dateTime = quote.ExpirationDate;
            strArray[3] = dateTime.ToShortDateString();
            strArray[4] = " on the renewal (control # ";
            strArray[5] = quote.ControlNo.ToString();
            strArray[6] = ").\n\nDo you wish to continue?";
            if (MessageBox.Show(string.Concat(strArray), "Renewal Policy Date Discrepancy", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
              ((UltraDateTimeEditor) this.dtEffectiveDate).AfterExitEditMode -= new EventHandler(this.DtEffectiveDate_AfterExitEditMode);
              ((UltraDateTimeEditor) this.dtEffectiveDate).Value = (object) this.Quote.EffectiveDate;
              ((UltraDateTimeEditor) this.dtEffectiveDate).AfterExitEditMode += new EventHandler(this.DtEffectiveDate_AfterExitEditMode);
            }
            else
              this.AllowSaveWithLapseInRenewalPolicyTerms = true;
          }
          else
          {
            string[] strArray = new string[6];
            strArray[0] = "Effective Date is not updated.\n\nThe effective date of \n\n";
            DateTime dateTime = Conversions.ToDate(((UltraDateTimeEditor) this.dtEffectiveDate).Value);
            strArray[1] = dateTime.ToShortDateString();
            strArray[2] = "\n\n does not match the expiration date of \n\n";
            dateTime = quote.ExpirationDate;
            strArray[3] = dateTime.ToShortDateString();
            strArray[4] = "\n\n on the renewed quote with control# ";
            strArray[5] = quote.ControlNo.ToString();
            int num = (int) MessageBox.Show(string.Concat(strArray), "Insufficient Security. Renewal Policy Dates Not Matching", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ((UltraDateTimeEditor) this.dtEffectiveDate).AfterExitEditMode -= new EventHandler(this.DtEffectiveDate_AfterExitEditMode);
            ((UltraDateTimeEditor) this.dtEffectiveDate).Value = (object) this.Quote.EffectiveDate;
            ((UltraDateTimeEditor) this.dtEffectiveDate).AfterExitEditMode += new EventHandler(this.DtEffectiveDate_AfterExitEditMode);
          }
        }
        flag2 = flag1;
      }
    }
    return flag2;
  }

  protected virtual void AfterEffectiveDateExitEditMode()
  {
  }

  private void DtEffectiveDate_AfterExitEditMode(object sender, EventArgs e)
  {
    if (!this.IsNewQuote)
      this._modifiedEffectiveDate = true;
    this.AfterEffectiveDateExitEditMode();
    if (!this.ValidatePolicyEffectiveVersusRenewal())
      return;
    string str1 = string.Empty;
    bool flag = false;
    DateTime effectiveDate1 = this._effectiveDate;
    DateTime dateTime = (DateTime) ((UltraDateTimeEditor) this.dtEffectiveDate).Value;
    if (!effectiveDate1.Equals(dateTime) && !effectiveDate1.Equals(DateTime.MinValue) && !this._ignoreCommissionsUpdateOnEffectiveDateChanged)
    {
      str1 = $"The commission structure in effect on {((DateTime) ((UltraDateTimeEditor) this.dtEffectiveDate).Value).ToShortDateString()} is as follows: ";
      Conversions.ToDate(Conversions.ToDate(((UltraDateTimeEditor) this.dtEffectiveDate).Value).ToShortDateString());
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboIssuingOffice).Value)))
      {
        Guid guid1 = (Guid) ((UltraCombo) this.cboIssuingOffice).Value;
      }
      try
      {
        foreach (dsQuoteEdit.tblQuoteDetailsRow tblQuoteDetail in (TypedTableBase<dsQuoteEdit.tblQuoteDetailsRow>) this.dsQuoteEdit.tblQuoteDetails)
        {
          if (tblQuoteDetail.RowState != DataRowState.Deleted)
          {
            Decimal producerCommission;
            if (!tblQuoteDetail.IsProducerCommissionNull())
              producerCommission = tblQuoteDetail.ProducerCommission;
            Decimal companyCommission;
            if (!tblQuoteDetail.IsCompanyCommissionNull())
              companyCommission = tblQuoteDetail.CompanyCommission;
            ProducerLocation producerLocation1 = new ProducerLocation(this.ProducerLocationGuid);
            CompanyLine companyLine = new CompanyLine(tblQuoteDetail.CompanyLineGuid);
            string str2 = (string) Strings.Split(tblQuoteDetail.CompanyLine, "-").GetValue(1);
            int integer = Conversions.ToInteger(((UltraCombo) this.cboPolicyType).Value);
            Guid empty = Guid.Empty;
            if (((UltraCombo) this.comboExpiringCarrier).Value != null)
              empty = (Guid) ((UltraCombo) this.comboExpiringCarrier).Value;
            object obj = (object) null;
            if (!tblQuoteDetail.IsProgramIDNull())
              obj = (object) tblQuoteDetail.ProgramID;
            Decimal commission1 = producerLocation1.GetCommission(tblQuoteDetail.CompanyLineGuid, this.IsCommissionRenewal, this.EffectiveDate, (SqlTransaction) null, (object) integer, RuntimeHelpers.GetObjectValue(obj), this.OfficeGuidForProducerLocation);
            int num1 = this.IsCommissionRenewal ? 1 : 0;
            Guid producerLocationGuid = this.ProducerLocationGuid;
            Decimal num2 = commission1;
            DateTime effectiveDate2 = this.EffectiveDate;
            int num3 = integer;
            Guid guid2 = empty;
            object objectValue = RuntimeHelpers.GetObjectValue(obj);
            Guid producerLocation2 = this.OfficeGuidForProducerLocation;
            Decimal commission2 = companyLine.GetCommission(num1 != 0, producerLocationGuid, num2, effectiveDate2, num3, (SqlTransaction) null, guid2, objectValue, producerLocation2);
            if (Decimal.Compare(companyCommission, commission2) != 0 && Decimal.Compare(commission2, 0M) != 0 || Decimal.Compare(producerCommission, commission1) != 0 && Decimal.Compare(commission1, 0M) != 0)
            {
              if (Decimal.Compare(companyCommission, commission2) != 0)
                str1 = $"{str1}\nFor {str2}, Company Commission = {Strings.FormatPercent((object) commission2)}";
              if (Decimal.Compare(producerCommission, commission1) != 0)
                str1 = $"{str1}\nFor {str2}, Producer Commission = {Strings.FormatPercent((object) commission1)}";
              flag = true;
            }
          }
        }
      }
      finally
      {
        IEnumerator<dsQuoteEdit.tblQuoteDetailsRow> enumerator;
        enumerator?.Dispose();
      }
    }
    if (flag)
    {
      if (!SecurityManager.Instance.AssertPermission("{3494008D-2F8D-45df-85F9-D1CDE496ED25}"))
      {
        this.MessageWithoutSecurityPermission($"The effective date has changed.\n\n{str1}\n\nCommission(s) will revert to the current structure(s) in effect as shown above.");
        this.GetCommissions();
        CurrentUser.Instance.LogAction("Commission updated on the change of the effective date.", this.QuoteGuid);
      }
      else if (this.ContinueCommissionUpdate(str1 + "\n\nThe effective date has changed.\n\nDo you want to update the commission now?"))
      {
        this.GetCommissions();
        CurrentUser.Instance.LogAction("Accept update to commission on the change of the effective date.", this.QuoteGuid);
      }
      else
        CurrentUser.Instance.LogAction("Reject update to commission on the change of the effective date.", this.QuoteGuid);
    }
    this.SetProgramCode();
    this.FillProgramCodeDropDown();
  }

  protected virtual bool ContinueCommissionUpdate(string strMessage)
  {
    return MessageBox.Show(strMessage, "Effective Date Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
  }

  protected virtual void MessageWithoutSecurityPermission(string strMessage)
  {
    int num = (int) MessageBox.Show(strMessage, "Effective Date Changed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
  }

  private CompanyLine GetCompanyLineObject(Guid companyLineGuid)
  {
    CompanyLine companyLineObject;
    if (this._companyLineObjectCache == null || !this._companyLineObjectCache.ContainsKey(companyLineGuid))
    {
      CompanyLine companyLine = new CompanyLine(companyLineGuid);
      if (this._companyLineObjectCache == null)
        this._companyLineObjectCache = new Dictionary<Guid, CompanyLine>();
      this._companyLineObjectCache.Add(companyLineGuid, companyLine);
      companyLineObject = companyLine;
    }
    else
      companyLineObject = this._companyLineObjectCache[companyLineGuid];
    return companyLineObject;
  }

  private void LnkAddModifyProducerContacts_LinkClicked(
    object sender,
    LinkLabelLinkClickedEventArgs e)
  {
    Guid empty = Guid.Empty;
    frmProducerContacts formEx;
    if (((UltraCombo) this.cboProducerContact).Text.Length == 0)
    {
      formEx = (frmProducerContacts) ObjectFactory.Instance.CreateFormEX(typeof (frmProducerContacts), new object[1]
      {
        (object) this.ProducerLocationGuid
      });
    }
    else
    {
      empty = (Guid) ((UltraCombo) this.cboProducerContact).Value;
      formEx = (frmProducerContacts) ObjectFactory.Instance.CreateFormEX(typeof (frmProducerContacts), new object[2]
      {
        (object) this.ProducerLocationGuid,
        (object) empty
      });
    }
    ((Form) formEx).ShowInTaskbar = false;
    try
    {
      int num = (int) ((Form) formEx).ShowDialog();
    }
    finally
    {
      ((Component) formEx).Dispose();
    }
    this.RefillProducerContacts();
    if (empty.Equals(Guid.Empty))
      return;
    ((UltraCombo) this.cboProducerContact).Value = (object) empty;
  }

  protected virtual bool ContinueAndRemoveRenewalLink() => true;

  protected virtual bool AlwaysClearRenewalsPolicyNumberingInfo() => false;

  private void LnkNewCompanyContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (!((Control) this.cboCompanies).Enabled)
    {
      if (MessageBox.Show("WARNING:\n\nAll options will be removed from this quote in order to change the company.\n\nAre you sure you want to delete all options?", "Remove Options?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (tmpObject, transArgs) =>
      {
        this.DeleteQuoteOptions(RuntimeHelpers.GetObjectValue(tmpObject), transArgs);
        transArgs.Transaction.Commit();
      }));
      CurrentUser.Instance.LogAction("Via Change Company Link - Remove all options on the quote.", this.QuoteGuid);
      this.OptionsRemove();
      if (this.ContinueAndRemoveRenewalLink())
      {
        frmQuoteEdit._promptedForRenewalSequence = (object) true;
        this.UpdateRenewalSequence();
      }
      if (((Form) this).Modal)
      {
        ((Form) this).Close();
        FormSettings.ShowFormDialog(typeof (frmQuoteEdit), new object[2]
        {
          (object) this.QuoteGuid,
          (object) this._submissionGroupGuid
        });
      }
      else
      {
        FormSettings.ShowForm(typeof (frmQuoteEdit), new object[2]
        {
          (object) this.QuoteGuid,
          (object) this._submissionGroupGuid
        });
        ((Form) this).Close();
      }
    }
    else
    {
      if (frmQuoteEdit.NoItemGuidSelected(this.cboCompanies))
        return;
      Guid guid = (Guid) ((UltraCombo) this.cboCompanies).Value;
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "Select IntermediaryGuid FROM tblCompanyLocations With (NOLOCK) WHERE CompanyLocationGuid = @compGuid", new object[2]
      {
        (object) "@compGuid",
        (object) guid
      }));
      if (objectValue == DBNull.Value)
        FormSettings.ShowFormDialog(typeof (frmCompanyContacts), new object[1]
        {
          (object) guid
        }).Dispose();
      else
        FormSettings.ShowFormDialog(typeof (frmIntermediaryContacts), new object[1]
        {
          (object) DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "Select IntermediaryID FROM tblIntermediaries With (NOLOCK) WHERE IntermediaryGuid = @intMedGuid", new object[2]
          {
            (object) "@intMedGuid",
            (object) (Guid) objectValue
          })
        }).Dispose();
      this.FillContactsDropdownList();
    }
  }

  private object DeleteQuoteOptions(object sender, ExecuteTransactionEventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery("DeleteOptionsOnChangeOfCompany", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid
    });
    return (object) null;
  }

  private void RefillProducerContacts()
  {
    this.dsQuoteEdit.EnforceConstraints = false;
    this.dsQuoteEdit.tblProducerContacts.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsQuoteEdit, new string[1]
    {
      "tblProducerContacts"
    }, "dbo.QuoteEditData_ProducerContacts", new object[2]
    {
      (object) "@ProducerLocationGuid",
      (object) this.ProducerLocationGuid
    });
    this.dsQuoteEdit.EnforceConstraints = true;
  }

  protected virtual void ConfigureQuickQuoteAppearance(bool isQuickQuote)
  {
    ((Control) this).SuspendLayout();
    if (isQuickQuote)
    {
      ((Control) this).Height = 290;
      this.lnkConvertQuickQuote.Text = "To convert this quick quote To a full quote, click here.";
      this.DeleteDetailRows();
    }
    else
    {
      this._isFullQuoteLinkPressed = true;
      ((Control) this).Height = 400;
      this.lnkConvertQuickQuote.Text = "To convert this full quote To a quick quote, click here.";
      if (this.ValidCompanyLineGuid)
        this.SetupQuoteDetailRows();
    }
    ((Control) this.ugPolicyDetail).Visible = !isQuickQuote;
    ((Control) this.gbPleaseWait).Top = (int) Math.Round((double) ((Control) this).Height / 2.0 - (double) ((Control) this.gbPleaseWait).Height / 2.0);
    ((Control) this).ResumeLayout();
    ((Control) this).Refresh();
  }

  private void LnkConvertQuickQuote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.IsQuickQuote = !this.IsQuickQuote;
    if (this.IsQuickQuote)
    {
      this.dsQuoteEdit.tblQuoteDetails.Clear();
      if (this.dsQuoteEdit.tblQuotes[0].RowState != DataRowState.Added)
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteDetails WHERE QuoteGuid=@QuoteGuid", new object[2]
        {
          (object) "@QuoteGuid",
          (object) this._quoteGuid
        });
      Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
      int index = 0;
      while (index < mdiChildren.Length)
      {
        if (mdiChildren[index] is frmPolicyDetail frmPolicyDetail && frmPolicyDetail.Quote.QuoteGuid.Equals(this._quoteGuid))
        {
          ((Form) frmPolicyDetail).Close();
          break;
        }
        checked { ++index; }
      }
    }
    this.ConfigureQuickQuoteAppearance(this.IsQuickQuote);
  }

  protected virtual object[] FillStatesParameters()
  {
    return new object[4]
    {
      (object) "@lineGuid",
      ((UltraCombo) this.cboLine).Value,
      (object) "@producerLocationGuid",
      (object) this.ProducerLocationGuid
    };
  }

  protected virtual void SetStateDefault()
  {
    if (this.dsQuoteEdit.lstStates.Count == 1)
    {
      ((UltraCombo) this.cboState).Value = (object) this.dsQuoteEdit.lstStates[0].StateID;
      this.CboState_ValueChanged((object) this, EventArgs.Empty);
    }
    else
      ((UltraCombo) this.cboState).Value = (object) null;
  }

  private void FillStates()
  {
    MDIControls.Instance.StatusBarText = "Getting available states For this producer And line...";
    ((UltraCombo) this.cboState).ValueChanged -= new EventHandler(this.CboState_ValueChanged);
    try
    {
      this.dsQuoteEdit.lstStates.Clear();
    }
    catch (IndexOutOfRangeException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    DefaultDatabase.LoadDataSet((DataSet) this.dsQuoteEdit, new string[1]
    {
      "lstStates"
    }, SystemSettings.GetSetting<string>("DataOverride_QuoteEditData_GetStates", "dbo.QuoteEditData_GetStates"), this.FillStatesParameters());
    this.SetStateDefault();
    ((UltraCombo) this.cboState).ValueChanged += new EventHandler(this.CboState_ValueChanged);
    MDIControls.Instance.StatusBarText = string.Empty;
  }

  private void BtnNext_Click(object sender, EventArgs e)
  {
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "Select BlockUIExitOnBlankRenewalInformation FROM tblCompanyLines WITH (NOLOCK) WHERE CompanyLineGuid=@CompanyLineGuid", new object[2]
    {
      (object) "@CompanyLineGuid",
      (object) this.CompanyLineGuid
    }))))
    {
      if (((Conversions.ToBoolean(DefaultDatabase.ExecuteScalar(CommandType.Text, "Select BlockUIExitOnBlankRenewalInformation FROM tblCompanyLines WITH (NOLOCK) WHERE CompanyLineGuid=@CompanyLineGuid", new object[2]
      {
        (object) "@CompanyLineGuid",
        (object) this.CompanyLineGuid
      })) ? 1 : 0) & (Conversions.ToInteger(DefaultDatabase.ExecuteScalar(CommandType.Text, "Select PolicyTypeID FROM tblQuotes WHERE QuoteGUID=@QuoteGUID", new object[2]
      {
        (object) "@QuoteGUID",
        (object) this.QuoteGuid
      })) == 1 ? 1 : 0)) != 0 && ((UltraCombo) this.comboExpiringCarrier).Value == null)
      {
        int num = (int) MessageBox.Show("Value \"Quote Renewal Info Mandatory\" has been enabled In Company Lines Management. Please Select an Expiring Carrier To Continue.");
        return;
      }
    }
    if (this.IsNewQuote)
    {
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "Select BlockUIExitOnBlankRenewalInformation FROM tblCompanyLines WITH (NOLOCK) WHERE CompanyLineGuid=@CompanyLineGuid", new object[2]
      {
        (object) "@CompanyLineGuid",
        (object) this.CompanyLineGuid
      }))))
      {
        if (Conversions.ToBoolean(DefaultDatabase.ExecuteScalar(CommandType.Text, "Select BlockUIExitOnBlankRenewalInformation FROM tblCompanyLines WITH (NOLOCK) WHERE CompanyLineGuid=@CompanyLineGuid", new object[2]
        {
          (object) "@CompanyLineGuid",
          (object) this.CompanyLineGuid
        })) && ((UltraCombo) this.comboExpiringCarrier).Value == null)
        {
          int num = (int) MessageBox.Show("Value \"Quote Renewal Info Mandatory\" has been enabled In Company Lines Management. Please Select an Expiring Carrier To Continue.");
          return;
        }
      }
    }
    if (this._hasUpdatedFinanceCompanyByDefault && MessageBox.Show("The finance company has been updated To the Default For this Company/Line.\r\n\r\nContinue?", "Validate Save", MessageBoxButtons.YesNo) != DialogResult.Yes)
      return;
    try
    {
      this._savingData = true;
      this.DoSave();
    }
    finally
    {
      this._savingData = false;
      frmQuoteEdit._promptedForRenewalSequence = (object) false;
      this._keepRenewalSequenceAfterPrompt = true;
    }
  }

  private void DtEffectiveDate_Enter(object sender, EventArgs e)
  {
    this.EffectiveExpirationDatesEnter(RuntimeHelpers.GetObjectValue(sender), e);
  }

  protected virtual void EffectiveExpirationDatesEnter(object sender, EventArgs e)
  {
  }

  private void EvaluateAffidavitNumber()
  {
    if (this.IsNewQuote)
      return;
    DateTime effectiveDate = this._effectiveDate;
    DateTime dateTime = (DateTime) ((UltraDateTimeEditor) this.dtEffectiveDate).Value;
    string empty = string.Empty;
    if (((UltraCombo) this.cboState).Value != null && ((UltraCombo) this.cboState).Value != DBNull.Value)
      empty = ((UltraCombo) this.cboState).Value.ToString();
    if (effectiveDate.Year >= dateTime.Year && this._originalStateID.Equals(empty))
      return;
    int num1 = DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteAffidavitNumbers WHERE QuoteID = @QID", new object[2]
    {
      (object) "@QID",
      (object) this.Quote.QuoteID
    });
    if (num1 <= 0)
      return;
    int num2 = (int) MessageBox.Show((effectiveDate.Year >= dateTime.Year ? $"You have changed the state On this policy.\n\nOriginal State - {this._originalStateID}\nCurrent State  - {empty}" : $"You have moved the effective Date into another year.\n\nOriginal Effective Date - {effectiveDate.ToShortDateString()}\nCurrent Effective Date  - {dateTime.ToShortDateString()}") + "\n\nThis has removed the currently assigned affidavit number(s).", num1.ToString() + " affidavit number(s) were removed.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  protected virtual void dtEffectiveDate_ValueChanged(object sender, EventArgs e)
  {
    if (((UltraDateTimeEditor) this.dtEffectiveDate).Value != null && ((UltraDateTimeEditor) this.dtExpirationDate).Value != null)
    {
      if (this._readyToShowParticipants)
        ((UltraDateTimeEditor) this.dtExpirationDate).Value = (object) Conversions.ToDate(((UltraDateTimeEditor) this.dtEffectiveDate).Value).AddYears(1);
      if (this.IsNewQuote && this._UseEffectiveDateForPolicyParticipants)
      {
        if (this._readyToShowParticipants)
        {
          try
          {
            ((Control) this).Cursor = MgaCursors.WaitCursor;
            this.ShowParticipants();
          }
          finally
          {
            ((Control) this).Cursor = MgaCursors.Default;
          }
        }
      }
      if (this.IsNewQuote || !this._readyToShowParticipants)
        return;
    }
    this.AfterEffectiveDateValueChange();
  }

  private void CboQuotingOffice_ValueChanged(object sender, EventArgs e)
  {
    if (((UltraCombo) this.cboQuotingOffice).Value != null)
    {
      this.dsQuoteEdit.lstLines.DefaultView.RowFilter = $"OfficeGuid='{((UltraCombo) this.cboQuotingOffice).Value.ToString()}' OR OfficeGuid='{Guid.Empty.ToString()}'";
      if (this.dsQuoteEdit.lstLines.DefaultView.Count == 2)
      {
        this.dsQuoteEdit.tblQuotes[0].QuotingLocationGuid = (Guid) this.dsQuoteEdit.lstLines.DefaultView[1]["OfficeGuid"];
        ((UltraCombo) this.cboLine).Value = (object) this.dsQuoteEdit.tblQuotes[0].QuotingLocationGuid;
      }
    }
    this.QuotingOfficeValueChange(RuntimeHelpers.GetObjectValue(sender), e);
  }

  private void LoadCompanyLocations(
    Guid lineGuid,
    Guid prodLocationGuid,
    string stateID,
    bool initialLoad)
  {
    this.LoadCompanyLocations(lineGuid, prodLocationGuid, stateID, true, initialLoad);
  }

  private void LoadCompanyLocations(
    Guid lineGuid,
    Guid prodLocationGuid,
    string stateID,
    bool showParticipantInfo,
    bool initialLoad)
  {
    if (stateID == null)
      return;
    int num1 = 0;
    do
    {
      ((UltraCombo) this.cboCompanies).ValueChanged -= new EventHandler(this.CboCompanies_ValueChanged);
      ++num1;
    }
    while (num1 <= 5);
    object quoteGuid = this.IsNewQuote || !initialLoad ? (object) null : (object) this.QuoteGuid;
    object objectValue = Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboQuotingOffice).Value)) ? (object) null : RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboQuotingOffice).Value);
    MDIControls.Instance.StatusBarText = "Getting company locations...";
    this.dsQuoteEdit.tblCompanyLocations.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsQuoteEdit, new string[1]
    {
      "tblCompanyLocations"
    }, this._getQuoteEditCompanyLocationsProcName, new object[12]
    {
      (object) "@StateID",
      (object) stateID,
      (object) "@ProducerLocationGuid",
      (object) prodLocationGuid,
      (object) "@LineGuid",
      (object) lineGuid,
      (object) "@OfficeGuid",
      objectValue,
      (object) "@quoteGuid",
      quoteGuid,
      (object) "@UserGuid",
      (object) this._currentUserGuid
    });
    MDIControls.Instance.StatusBarText = string.Empty;
    this.dsQuoteEdit.tblCompanyContacts.Clear();
    if (this.dsQuoteEdit.tblCompanyLocations.Count == 1)
    {
      this.dsQuoteEdit.tblQuotes[0].CompanyLocationGuid = this.dsQuoteEdit.tblCompanyLocations[0].CompanyLocationGuid;
      ((UltraCombo) this.cboCompanies).Value = (object) this.dsQuoteEdit.tblQuotes[0].CompanyLocationGuid;
      int num2 = ((UltraGridBase) this.cboCompanies).Rows.Count - 1;
      for (int index = 0; index <= num2; ++index)
      {
        if (((UltraGridBase) this.cboCompanies).Rows[index].Cells["CompanyLocationGuid"].Value.Equals((object) this.dsQuoteEdit.tblCompanyLocations[0].CompanyLocationGuid))
        {
          ((UltraDropDownBase) this.cboCompanies).SelectedRow = ((UltraGridBase) this.cboCompanies).Rows[index];
          break;
        }
      }
      this.CboCompanies_ValueChanged((object) this, EventArgs.Empty);
    }
    else
    {
      ((UltraDropDownBase) this.cboCompanies).SelectedRow = (UltraGridRow) null;
      if (!this.ValidCompanyLineGuid && !this._isNewQuote && this.dsQuoteEdit.tblCompanyLocations.Count > 1 && !this.IsQuickQuote && this.dsQuoteEdit.tblQuotes.Count > 0 && !this.dsQuoteEdit.tblQuotes[0].IsCompanyLocationGuidNull() && !this.dsQuoteEdit.tblQuotes[0].CompanyLocationGuid.Equals(this._originalCompanyLocationGuid))
      {
        this.dsQuoteEdit.tblQuotes[0].CompanyLocationGuid = this._originalCompanyLocationGuid;
        ((UltraCombo) this.cboCompanies).Value = (object) this._originalCompanyLocationGuid;
      }
    }
    if (showParticipantInfo && this.ValidCompanyLineGuid)
      this.ShowParticipants();
    ((UltraCombo) this.cboCompanies).ValueChanged += new EventHandler(this.CboCompanies_ValueChanged);
  }

  private void LoadStatesAndUnderwriters()
  {
    ((UltraCombo) this.cboState).ValueChanged -= new EventHandler(this.CboState_ValueChanged);
    this.FillStates();
    this.dsQuoteEdit.tblUsers.Clear();
    MDIControls.Instance.StatusBarText = "Getting users...";
    this._canSelectAllUsers = SecurityManager.Instance.AssertPermission("{0FA0118C-D65D-49da-8330-220B26A5B652}");
    if (((UltraCombo) this.cboIssuingOffice).Value != null && ((UltraCombo) this.cboIssuingOffice).Value != DBNull.Value)
      this._issuingOffice = RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboIssuingOffice).Value);
    DefaultDatabase.LoadDataSet((DataSet) this.dsQuoteEdit, new string[1]
    {
      "tblUsers"
    }, "dbo.QuoteEditData_GetUnderwriters", new object[10]
    {
      (object) "@lineGuid",
      ((UltraCombo) this.cboLine).Value,
      (object) "@quoteGuid",
      (object) this._quoteGuid,
      (object) "@selectAllOffices",
      (object) this._canSelectAllUsers,
      (object) "@issuingOffice",
      this._issuingOffice,
      (object) "@ProducerLocationGuid",
      (object) this.ProducerLocationGuid
    });
    Guid UserGuid = this.DefaultUnderwriterGuid;
    if (this.IsNewQuote && this._useCurrentUserAsDefaultUnderwriter && this.dsQuoteEdit.tblUsers.FindByUserGuid(this._currentUserGuid) != null)
      UserGuid = this._currentUserGuid;
    if (this.IsNewQuote && !UserGuid.Equals(Guid.Empty) && this.dsQuoteEdit.tblUsers.FindByUserGuid(UserGuid) != null)
    {
      ((UltraCombo) this.cboUnderwriter).ValueChanged -= new EventHandler(this.CboUnderwriter_ValueChanged);
      ((UltraCombo) this.cboUnderwriter).Value = (object) UserGuid;
      ((UltraCombo) this.cboUnderwriter).ValueChanged += new EventHandler(this.CboUnderwriter_ValueChanged);
      ((UltraDropDownBase) this.cboUnderwriter).SelectedRow?.Activate();
      this.dsQuoteEdit.tblQuotes[0].UnderwriterUserGuid = UserGuid;
    }
    MDIControls.Instance.StatusBarText = string.Empty;
    ((UltraCombo) this.cboState).ValueChanged += new EventHandler(this.CboState_ValueChanged);
  }

  private void LockdownCompanyCommissionCells()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugPolicyDetail).Rows)
      row.Cells["CompanyCommission"].Activation = !Conversions.ToBoolean(row.Cells["UsingAdditiveCommission"].Value) || this._OverrideCommissionAdditive ? (Activation) 0 : (Activation) 2;
  }

  private void ShowParticipants()
  {
    if (this.IsQuickQuote || !this._readyToShowParticipants)
      return;
    object objectValue = (object) DBNull.Value;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtEffectiveDate).Value)) && ((UltraDateTimeEditor) this.dtEffectiveDate).IsDateValid && DateTime.Compare(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtEffectiveDate).Value)), DateTime.MinValue) != 0)
      objectValue = RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtEffectiveDate).Value);
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.QuoteEditData_GetPolicyParticipants", new object[8]
    {
      (object) "@CompanyLineGuid",
      (object) this.CompanyLineGuid,
      (object) "@IsNewQuote",
      (object) this.IsNewQuote,
      (object) "@IsRated",
      (object) this._isRated,
      (object) "@PolicyEffective",
      objectValue
    });
    this.DeleteDetailRows();
    if (dataTable.Rows.Count != 0)
    {
      if (dataTable.Columns.Count > 2)
      {
        try
        {
          foreach (DataRow row1 in dataTable.Rows)
          {
            dsQuoteEdit.tblQuoteDetailsRow row2 = this.dsQuoteEdit.tblQuoteDetails.NewtblQuoteDetailsRow();
            dsQuoteEdit.tblQuoteDetailsRow tblQuoteDetailsRow = row2;
            tblQuoteDetailsRow.QuoteGuid = this._quoteGuid;
            tblQuoteDetailsRow.CompanyLineGuid = (Guid) row1["CompanyLineGuid"];
            tblQuoteDetailsRow.CompanyLine = row1["CompanyLine"].ToString();
            tblQuoteDetailsRow.TermsOfPayment = Conversions.ToInteger(row1["TermsOfPayment"]);
            tblQuoteDetailsRow.UsingAdditiveCommission = Conversions.ToBoolean(row1["UsingAdditiveCommission"]);
            this.dsQuoteEdit.tblQuoteDetails.AddtblQuoteDetailsRow(row2);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      else
      {
        dsQuoteEdit.tblQuoteDetailsRow row = this.dsQuoteEdit.tblQuoteDetails.NewtblQuoteDetailsRow();
        dsQuoteEdit.tblQuoteDetailsRow tblQuoteDetailsRow = row;
        tblQuoteDetailsRow.QuoteGuid = this._quoteGuid;
        tblQuoteDetailsRow.CompanyLineGuid = this.CompanyLineGuid;
        tblQuoteDetailsRow.CompanyLine = $"{((UltraCombo) this.cboCompanies).Text} - {((UltraCombo) this.cboLine).Text} - {((UltraCombo) this.cboState).Value.ToString()}";
        tblQuoteDetailsRow.TermsOfPayment = Conversions.ToInteger(dataTable.Rows[0]["TermsOfPayment"]);
        tblQuoteDetailsRow.UsingAdditiveCommission = (bool) dataTable.Rows[0]["UsingAdditiveCommission"];
        this.dsQuoteEdit.tblQuoteDetails.AddtblQuoteDetailsRow(row);
      }
      this.FillProgramCodeDropDown();
    }
    ((Control) this.btnNext).Enabled = dataTable.Rows.Count > 0;
    this.GetCommissions();
    this.FillContactsDropdownList();
    this.LockdownCompanyCommissionCells();
  }

  protected virtual void GetCommissions() => this.GetCommissions(true);

  private void GetCommissions(bool overwriteIfZero)
  {
    if (((UltraDateTimeEditor) this.dtEffectiveDate).Value == null || ((UltraDateTimeEditor) this.dtEffectiveDate).Value == DBNull.Value)
      return;
    ProducerLocation producerLocation1 = new ProducerLocation(this.ProducerLocationGuid);
    int integer = Conversions.ToInteger(((UltraCombo) this.cboPolicyType).Value);
    Guid empty = Guid.Empty;
    if (((UltraCombo) this.comboExpiringCarrier).Value != null && ((UltraCombo) this.comboExpiringCarrier).Value != DBNull.Value)
      empty = (Guid) ((UltraCombo) this.comboExpiringCarrier).Value;
    try
    {
      foreach (dsQuoteEdit.tblQuoteDetailsRow tblQuoteDetail in (TypedTableBase<dsQuoteEdit.tblQuoteDetailsRow>) this.dsQuoteEdit.tblQuoteDetails)
      {
        if (tblQuoteDetail.RowState != DataRowState.Deleted)
        {
          CompanyLine companyLine = new CompanyLine(tblQuoteDetail.CompanyLineGuid);
          object obj = (object) null;
          if (!tblQuoteDetail.IsProgramIDNull())
            obj = (object) tblQuoteDetail.ProgramID;
          Decimal commission1 = producerLocation1.GetCommission(tblQuoteDetail.CompanyLineGuid, this.IsCommissionRenewal, this.EffectiveDate, (SqlTransaction) null, (object) integer, RuntimeHelpers.GetObjectValue(obj), this.OfficeGuidForProducerLocation);
          if (Decimal.Compare(commission1, 0M) != 0 || overwriteIfZero)
            tblQuoteDetail.ProducerCommission = commission1;
          int num1 = this.IsCommissionRenewal ? 1 : 0;
          Guid producerLocationGuid = this.ProducerLocationGuid;
          Decimal producerCommission = tblQuoteDetail.ProducerCommission;
          DateTime effectiveDate = this.EffectiveDate;
          int num2 = integer;
          Guid guid = empty;
          object objectValue = RuntimeHelpers.GetObjectValue(obj);
          Guid producerLocation2 = this.OfficeGuidForProducerLocation;
          Decimal commission2 = companyLine.GetCommission(num1 != 0, producerLocationGuid, producerCommission, effectiveDate, num2, (SqlTransaction) null, guid, objectValue, producerLocation2);
          if (Decimal.Compare(commission2, 0M) != 0 || overwriteIfZero)
            tblQuoteDetail.CompanyCommission = commission2;
        }
      }
    }
    finally
    {
      IEnumerator<dsQuoteEdit.tblQuoteDetailsRow> enumerator;
      enumerator?.Dispose();
    }
    this.RefillCompanyCommissions();
  }

  private void GetContacts(Guid companyLineGuid)
  {
    bool flag = !((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Bands[0].Columns["CompanyContactGuid"].Hidden;
    if (flag)
    {
      this.dsQuoteEdit.EnforceConstraints = false;
      DefaultDatabase.LoadDataSet((DataSet) this.dsQuoteEdit, new string[1]
      {
        "tblCompanyContacts"
      }, "dbo.QuoteEditData_GetCompanyContacts", new object[6]
      {
        (object) "@companyLineGuid",
        (object) companyLineGuid,
        (object) "@includeCompanyContacts",
        (object) flag,
        (object) "@quoteGuid",
        (object) this.QuoteGuid
      });
      for (int count = this.dsQuoteEdit.tblCompanyContacts.Rows.Count; count > 0; --count)
      {
        dsQuoteEdit.tblCompanyContactsRow row = (dsQuoteEdit.tblCompanyContactsRow) this.dsQuoteEdit.tblCompanyContacts.Rows[count - 1];
        if (this.dsQuoteEdit.tblCompanyContacts.Select($"CompanyContactGuid='{row.CompanyContactGuid.ToString()}'").Length > 1)
          this.dsQuoteEdit.tblCompanyContacts.Rows.Remove(this.dsQuoteEdit.tblCompanyContacts.Select($"CompanyContactGuid='{row.CompanyContactGuid.ToString()}'")[0]);
      }
      this.dsQuoteEdit.EnforceConstraints = true;
    }
    if (((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Bands[0].Columns["IntermediaryContactGuid"].Hidden)
      return;
    this.dsQuoteEdit.EnforceConstraints = false;
    DefaultDatabase.LoadDataSet((DataSet) this.dsQuoteEdit, new string[1]
    {
      "tblIntermediaryContacts"
    }, "dbo.QuoteEditData_GetCompanyContacts", new object[6]
    {
      (object) "@companyLineGuid",
      (object) companyLineGuid,
      (object) "@includeCompanyContacts",
      (object) false,
      (object) "@quoteGuid",
      (object) this.QuoteGuid
    });
    for (int count = this.dsQuoteEdit.tblIntermediaryContacts.Rows.Count; count > 0; --count)
    {
      dsQuoteEdit.tblIntermediaryContactsRow row = (dsQuoteEdit.tblIntermediaryContactsRow) this.dsQuoteEdit.tblIntermediaryContacts.Rows[count - 1];
      if (this.dsQuoteEdit.tblIntermediaryContacts.Select($"IntermediaryContactGuid='{row.IntermediaryContactGuid.ToString()}'").Length > 1)
        this.dsQuoteEdit.tblIntermediaryContacts.Rows.Remove(this.dsQuoteEdit.tblIntermediaryContacts.Select($"IntermediaryContactGuid='{row.IntermediaryContactGuid.ToString()}'")[0]);
    }
    this.dsQuoteEdit.EnforceConstraints = true;
  }

  private void FillContactsDropdownList()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    int num1 = 0;
    int num2 = 0;
    Dictionary<Guid, bool> dictionary = new Dictionary<Guid, bool>();
    int num3;
    try
    {
      foreach (dsQuoteEdit.tblQuoteDetailsRow tblQuoteDetail in (TypedTableBase<dsQuoteEdit.tblQuoteDetailsRow>) this.dsQuoteEdit.tblQuoteDetails)
      {
        if (tblQuoteDetail.RowState != DataRowState.Deleted)
        {
          ++num2;
          bool usingIntermediary = new CompanyLocation(this.GetCompanyLineObject(tblQuoteDetail.CompanyLineGuid).CompanyLocationGuid).UsingIntermediary;
          if (!dictionary.ContainsKey(tblQuoteDetail.CompanyLineGuid))
            dictionary.Add(tblQuoteDetail.CompanyLineGuid, usingIntermediary);
          if (usingIntermediary)
          {
            ++num3;
            if (!tblQuoteDetail.IsCompanyContactGuidNull())
              tblQuoteDetail.SetCompanyContactGuidNull();
          }
          else
          {
            ++num1;
            if (!tblQuoteDetail.IsIntermediaryContactGuidNull())
              tblQuoteDetail.SetIntermediaryContactGuidNull();
          }
        }
      }
    }
    finally
    {
      IEnumerator<dsQuoteEdit.tblQuoteDetailsRow> enumerator;
      enumerator?.Dispose();
    }
    UltraGridBand band = ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Bands[0];
    if (num3 == num2)
    {
      band.Columns["CompanyContactGuid"].Hidden = true;
      band.Columns["IntermediaryContactGuid"].Hidden = false;
    }
    else if (num1 == num2)
    {
      band.Columns["CompanyContactGuid"].Hidden = false;
      band.Columns["IntermediaryContactGuid"].Hidden = true;
    }
    else
    {
      band.Columns["CompanyContactGuid"].Hidden = false;
      band.Columns["IntermediaryContactGuid"].Hidden = false;
    }
    if (!this.IsNewQuote && this.Quote.IsBound && !SecurityManager.Instance.AssertPermission("{A629F23B-707F-4b2d-8A47-1354E42D291F}"))
    {
      band.Columns["CompanyContactGuid"].CellActivation = (Activation) 3;
      band.Columns["IntermediaryContactGuid"].CellActivation = (Activation) 3;
    }
    this.dsQuoteEdit.tblCompanyContacts.Clear();
    this.dsQuoteEdit.tblIntermediaryContacts.Clear();
    try
    {
      foreach (dsQuoteEdit.tblQuoteDetailsRow tblQuoteDetail in (TypedTableBase<dsQuoteEdit.tblQuoteDetailsRow>) this.dsQuoteEdit.tblQuoteDetails)
      {
        if (tblQuoteDetail.RowState != DataRowState.Deleted)
        {
          this.GetContacts(tblQuoteDetail.CompanyLineGuid);
          Guid guid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT CompanyLocationGuid FROM tblCompanyLines WITH (NOLOCK)  WHERE CompanyLineGuid=@CompanyLineGuid", new object[2]
          {
            (object) "@CompanyLineGuid",
            (object) tblQuoteDetail.CompanyLineGuid
          });
          int num4 = ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Bands[0].Columns["CompanyContactGuid"].Hidden ? 1 : 0;
          if (!dictionary[tblQuoteDetail.CompanyLineGuid] && tblQuoteDetail.IsCompanyContactGuidNull() && this.dsQuoteEdit.tblCompanyContacts.Select($"CompanyLocationGuid='{guid.ToString()}'").Length >= 1)
            tblQuoteDetail.CompanyContactGuid = (Guid) this.dsQuoteEdit.tblCompanyContacts.Select($"CompanyLocationGuid='{guid.ToString()}'")[0]["CompanyContactGuid"];
          if (dictionary[tblQuoteDetail.CompanyLineGuid] && tblQuoteDetail.IsIntermediaryContactGuidNull() && this.dsQuoteEdit.tblIntermediaryContacts.Select($"CompanyLocationGuid='{guid.ToString()}'").Length >= 1)
            tblQuoteDetail.IntermediaryContactGuid = (Guid) this.dsQuoteEdit.tblIntermediaryContacts.Select($"CompanyLocationGuid='{guid.ToString()}'")[0]["IntermediaryContactGuid"];
        }
      }
    }
    finally
    {
      IEnumerator<dsQuoteEdit.tblQuoteDetailsRow> enumerator;
      enumerator?.Dispose();
    }
    Cursor.Current = MgaCursors.Default;
  }

  private void CboLine_ValueChanged(object sender, EventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    this.DeleteDetailRows();
    this.dsQuoteEdit.lstStates.Clear();
    this.dsQuoteEdit.tblCompanyLocations.Clear();
    if (((UltraCombo) this.cboLine).Value == null)
      return;
    Guid lineGuid = (Guid) ((UltraCombo) this.cboLine).Value;
    this.LoadStatesAndUnderwriters();
    if (this.dsQuoteEdit.lstStates.Rows.Count == 0)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboState).Text, string.Empty, false) != 0)
    {
      string stateId = ((dsQuoteEdit.lstStatesRow) this.dsQuoteEdit.lstStates.Rows[0]).StateID;
      this.LoadCompanyLocations(lineGuid, this.ProducerLocationGuid, stateId, false);
    }
    this.SetProgramCode();
    Cursor.Current = MgaCursors.Default;
  }

  protected virtual void SetProgramCode()
  {
    if (this._isBound && this._lockDownProgramCodeWhenBound || this.LockDownProgramCodeOnEndorsements)
      return;
    this.lblProgramCode.Text = string.Empty;
    this._ProgramID = -1;
    if (this.dsQuoteEdit.tblCompanyProgramCodes.Count == 0 || ((UltraCombo) this.cboCompanies).Value == null || ((UltraCombo) this.cboLine).Value == null || ((UltraCombo) this.cboIssuingOffice).Value == null || ((UltraDateTimeEditor) this.dtEffectiveDate).Value == null)
      return;
    string empty = string.Empty;
    if (((UltraCombo) this.cboState).Value != null)
      empty = ((UltraCombo) this.cboState).Value.ToString();
    DateTime date = Conversions.ToDate(Conversions.ToDate(((UltraDateTimeEditor) this.dtEffectiveDate).Value).ToShortDateString());
    try
    {
      foreach (dsQuoteEdit.tblCompanyProgramCodesRow row in this.dsQuoteEdit.tblCompanyProgramCodes.Rows)
      {
        if ((row.LineGUID == (Guid) ((UltraCombo) this.cboLine).Value || row.LineGUID.Equals(new Guid("00000000-0000-0000-0000-000000000000"))) && (row.StateID.Equals(empty) || row.StateID.Equals("&&")) && (row.IssuingOfficeGUID == (Guid) ((UltraCombo) this.cboIssuingOffice).Value || row.IssuingOfficeGUID.Equals(new Guid("00000000-0000-0000-0000-000000000000"))) && (row.CompanyLocationGUID == (Guid) ((UltraCombo) this.cboCompanies).Value || row.CompanyLocationGUID.Equals(new Guid("00000000-0000-0000-0000-000000000000"))) && (row.IsGroupCodeNull() || row.GroupCode.Equals(this.LineGroupProgramCode((Guid) ((UltraCombo) this.cboLine).Value)) || row.GroupCode.Equals("&&")) && DateTime.Compare(date, row.ContractEffective) >= 0 && DateTime.Compare(date, row.ContractExpiration) <= 0)
        {
          this.lblProgramCode.Text = row.ProgCode;
          this._ProgramID = row.ProgramID;
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

  private void CboState_ValueChanged(object sender, EventArgs e)
  {
    ((UltraCombo) this.cboState).ValueChanged -= new EventHandler(this.CboState_ValueChanged);
    this.DeleteDetailRows();
    ((UltraCombo) this.cboCompanies).Value = (object) null;
    this.StateChange(RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboState).Value));
    if (((UltraCombo) this.cboLine).Value == null)
      return;
    this.LoadCompanyLocations((Guid) ((UltraCombo) this.cboLine).Value, this.ProducerLocationGuid, (string) ((UltraCombo) this.cboState).Value, false);
    this.SetProgramCode();
    ((UltraCombo) this.cboState).ValueChanged += new EventHandler(this.CboState_ValueChanged);
  }

  private void CboIssuingOffice_ValueChanged(object sender, EventArgs e)
  {
    this.IssuingOfficeChange(RuntimeHelpers.GetObjectValue(sender), e);
    this.SetProgramCode();
    if (!this._readyToShowParticipants)
      return;
    this.FillProgramCodeDropDown();
  }

  protected virtual void StateChange(object StateID)
  {
  }

  protected virtual void LineChanged(Guid LineGuid)
  {
  }

  protected virtual void CompanyChange()
  {
  }

  protected virtual void IssuingOfficeChange(object sender, EventArgs e)
  {
  }

  protected virtual void DefaultFinanceCompany()
  {
    if (!this.IsNewQuote)
      return;
    try
    {
      this._hasUpdatedFinanceCompanyByDefault = false;
      if (this.IsEmptyComboBoxValue(this.cboLine) || this.IsEmptyComboBoxValue(this.cboState) || this.IsEmptyComboBoxValue(this.cboCompanies))
        return;
      string key = ((UltraCombo) this.cboCompanies).Value.ToString() + ((UltraCombo) this.cboState).Value.ToString() + ((UltraCombo) this.cboLine).Value.ToString();
      Guid guid;
      if (this._financeCompanyLine.ContainsKey(key))
      {
        guid = this._financeCompanyLine[key];
      }
      else
      {
        guid = DefaultDatabase.ExecuteScalar<Guid>("spGetDefaultFinanceCompany", new object[6]
        {
          (object) "@LineGUID",
          ((UltraCombo) this.cboLine).Value,
          (object) "@StateID",
          ((UltraCombo) this.cboState).Value,
          (object) "@CompanyLocationGUID",
          ((UltraCombo) this.cboCompanies).Value
        });
        this._financeCompanyLine.Add(key, guid);
      }
      if (guid.Equals(Guid.Empty))
        return;
      ((UltraCombo) this.cboFinanceCompany).Value = (object) guid;
      this._hasUpdatedFinanceCompanyByDefault = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual void SetExpiringPolicyNumberOnCompanyChange()
  {
    if (string.IsNullOrEmpty(this._originalCompany) || this._originalCompany.Equals(((UltraCombo) this.cboCompanies).Text) || this._keepRenewalSequenceAfterPrompt)
      return;
    ((TextEditorControlBase) this.txtExpiringPolicyNumber).Text = string.Empty;
  }

  private bool IsEmptyComboBoxValue(MGASimpleComboBox cb)
  {
    return cb == null || ((UltraCombo) cb).Value == null || ((UltraCombo) cb).Value == DBNull.Value;
  }

  protected void cboLine_TextChanged(object sender, EventArgs e)
  {
    if (((UltraCombo) this.cboLine).Value == null)
      return;
    this.LineChanged((Guid) ((UltraCombo) this.cboLine).Value);
  }

  private void CboCompanies_ValueChanged(object sender, EventArgs e)
  {
    ((UltraCombo) this.cboCompanies).ValueChanged -= new EventHandler(this.CboCompanies_ValueChanged);
    if (this.ValidCompanyLineGuid)
    {
      this.GetAvailableBillingTypes(this.CompanyLineGuid);
      this.SetupQuoteDetailRows();
      this.SetMinimumEarned();
    }
    this.SetExpiringPolicyNumberOnCompanyChange();
    this.CompanyChange();
    this.SetProgramCode();
    this.DefaultFinanceCompany();
    ((UltraCombo) this.cboCompanies).ValueChanged += new EventHandler(this.CboCompanies_ValueChanged);
  }

  private void SetMinimumEarned()
  {
    if (!this._readyToShowParticipants || !this._resetMinEarnedOnCarrierChange && !this.dsQuoteEdit.tblQuotes[0].IsMinimumEarnedPercentageNull())
      return;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT MinimumEarnedPercentage FROM tblCompanyLines WITH (NOLOCK) WHERE CompanyLineGuid=@CompanyLineGuid", new object[2]
    {
      (object) "@CompanyLineGuid",
      (object) this.CompanyLineGuid
    }));
    if (objectValue != DBNull.Value)
    {
      this.dsQuoteEdit.tblQuotes[0].MinimumEarnedPercentage = Conversions.ToDecimal(objectValue);
      ((UltraNumericEditor) this.numMinimumEarned).Value = (object) Conversions.ToDecimal(objectValue);
    }
    else
    {
      this.dsQuoteEdit.tblQuotes[0].SetMinimumEarnedPercentageNull();
      ((UltraNumericEditor) this.numMinimumEarned).Value = (object) DBNull.Value;
    }
  }

  private void SetupQuoteDetailRows()
  {
    this.ShowParticipants();
    if (!this.IsNewQuote)
      return;
    this.SetMinimumEarned();
  }

  private void GetAvailableBillingTypes(Guid companyLineGuid)
  {
    if (this._lastBillingCompanyLineGuid.Equals(companyLineGuid))
      return;
    this._lastBillingCompanyLineGuid = companyLineGuid;
    this.dsQuoteEdit.EnforceConstraints = false;
    this.dsQuoteEdit.lstBillingTypes.Clear();
    this.dsQuoteEdit.lstBillingTypes.AddlstBillingTypesRow(-1, string.Empty, string.Empty, false);
    MDIControls.Instance.StatusBarText = "Getting billing types...";
    DefaultDatabase.LoadDataSet((DataSet) this.dsQuoteEdit, new string[1]
    {
      "lstBillingTypes"
    }, "dbo.QuoteEditData_GetBillingTypes", new object[6]
    {
      (object) "@companyLineGuid",
      (object) companyLineGuid,
      (object) "@quoteGuid",
      (object) this.QuoteGuid,
      (object) "@submissionGroupGuid",
      (object) this._submissionGroupGuid
    });
    if (this.IsNewQuote)
    {
      if (((UltraGridBase) this.cboBillingTypes).Rows.Count == 2)
      {
        this.dsQuoteEdit.tblQuotes[0].BillingTypeID = this.dsQuoteEdit.lstBillingTypes[1].BillingTypeID;
        ((UltraCombo) this.cboBillingTypes).Value = (object) this.dsQuoteEdit.tblQuotes[0].BillingTypeID;
      }
      else
      {
        this.dsQuoteEdit.tblQuotes[0].SetBillingTypeIDNull();
        ((UltraDropDownBase) this.cboBillingTypes).SelectedRow = (UltraGridRow) null;
      }
    }
    else if (!this._setBillingTypeOnEdits)
    {
      if (!this.dsQuoteEdit.tblQuotes[0].IsBillingTypeIDNull())
        ((UltraCombo) this.cboBillingTypes).Value = (object) this.dsQuoteEdit.tblQuotes[0].BillingTypeID;
    }
    else if (!this.dsQuoteEdit.tblQuotes[0].IsBillingTypeIDNull())
    {
      if (this.dsQuoteEdit.lstBillingTypes.FindByBillingTypeID(this.dsQuoteEdit.tblQuotes[0].BillingTypeID) != null && this.dsQuoteEdit.lstBillingTypes.FindByBillingTypeID(this.dsQuoteEdit.tblQuotes[0].BillingTypeID).OnCompanyLine)
        ((UltraCombo) this.cboBillingTypes).Value = (object) this.dsQuoteEdit.tblQuotes[0].BillingTypeID;
      else if (this.dsQuoteEdit.lstBillingTypes.Select("OnCompanyLine = 1").Length == 1)
      {
        this.dsQuoteEdit.tblQuotes[0].BillingTypeID = ((dsQuoteEdit.lstBillingTypesRow) this.dsQuoteEdit.lstBillingTypes.Select("OnCompanyLine = 1")[0]).BillingTypeID;
        ((UltraCombo) this.cboBillingTypes).Value = (object) this.dsQuoteEdit.tblQuotes[0].BillingTypeID;
      }
      else
      {
        this.dsQuoteEdit.tblQuotes[0].SetBillingTypeIDNull();
        ((UltraDropDownBase) this.cboBillingTypes).SelectedRow = (UltraGridRow) null;
      }
    }
    try
    {
      this.dsQuoteEdit.EnforceConstraints = true;
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.dsQuoteEdit, ex);
      ProjectData.ClearProjectError();
    }
  }

  public void GetAvailableBillingTypes() => this.GetAvailableBillingTypes(this.CompanyLineGuid);

  public bool ProducerUsingDefaultCommission(
    Guid producerLocationGUID,
    Guid companyLineGuid,
    bool renewal)
  {
    string str = "SELECT TOP 1 ";
    return DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, (!renewal ? str + "UsingDefaultCommNew" : str + "UsingDefaultCommRenewal") + " FROM tblProducerLines WITH (NOLOCK) WHERE ProducerLocationGUID=@ProducerLocationGUID AND CompanyLineGUID=@CompanyLineGUID", new object[4]
    {
      (object) "@ProducerLocationGUID",
      (object) producerLocationGUID,
      (object) "@CompanyLineGuid",
      (object) companyLineGuid
    });
  }

  private Decimal GetProducerMaxCommission(
    Guid companyLineGuid,
    bool renewal,
    object tmpProgramCodeID)
  {
    string str1 = "SELECT TOP 1 ";
    string str2 = !renewal ? str1 + "ProducerCommNewMax" : str1 + "ProducerCommRenewalMax";
    CompanyLine companyLineObject = this.GetCompanyLineObject(companyLineGuid);
    object objectValue;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(tmpProgramCodeID)) && this._includeProgCodeOnMaxProdComm)
      objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, str2 + " FROM tblCompanyLineCommissions WITH (NOLOCK) WHERE CompanyLineID = @CompanyLineID AND (ProgramID = @ProgramID OR ProgramID IS NULL) AND Effective <= @EffectiveDate ORDER BY Effective DESC", new object[6]
      {
        (object) "@CompanyLineID",
        (object) companyLineObject.CompanyLineID,
        (object) "@EffectiveDate",
        ((UltraDateTimeEditor) this.dtEffectiveDate).Value,
        (object) "@ProgramID",
        tmpProgramCodeID
      }));
    else
      objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, str2 + " FROM tblCompanyLineCommissions WITH (NOLOCK) WHERE CompanyLineID = @CompanyLineID AND Effective <= @EffectiveDate ORDER BY Effective DESC", new object[4]
      {
        (object) "@CompanyLineID",
        (object) companyLineObject.CompanyLineID,
        (object) "@EffectiveDate",
        ((UltraDateTimeEditor) this.dtEffectiveDate).Value
      }));
    return !Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? (Decimal) objectValue : Decimal.MaxValue;
  }

  private Guid GetCompanyLineGuid(Guid companyLocationGuid, Guid lineGuid, string stateID)
  {
    Guid? nullable = CompanyLine.ResolveCompanyLineGuid(companyLocationGuid, lineGuid, stateID, new Guid?());
    if (!nullable.HasValue)
    {
      InvalidCastException invalidCastException = new InvalidCastException("Could not determine the CompanyLineGuid");
      invalidCastException.Data.Add((object) "CompanyLocationGuid", (object) companyLocationGuid);
      invalidCastException.Data.Add((object) "LineGuid", (object) lineGuid);
      invalidCastException.Data.Add((object) "StateID", (object) stateID);
      throw invalidCastException;
    }
    return nullable.Value;
  }

  private void DeleteInvalidQuoteDetailRows()
  {
    if (this.dsQuoteEdit.tblQuoteDetails.Count <= 0 || this.IsNewQuote || this._hasIssuedQuoteDetailDeletes || this._isBound || this._isEndorsement || this._isImsRewrite)
      return;
    this._hasIssuedQuoteDetailDeletes = true;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT CompanyLineGuid FROM tblQuoteDetails WITH (NOLOCK) WHERE QuoteGuid = @QG", new object[2]
    {
      (object) "@QG",
      (object) this._quoteGuid
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        if (this.dsQuoteEdit.tblQuoteDetails.FindByQuoteGuidCompanyLineGuid(this._quoteGuid, (Guid) row[0]) == null)
          DefaultDatabase.ExecuteNonQuery("spDetailInvalidCompanyLine", new object[4]
          {
            (object) "@QuoteGuid",
            (object) this._quoteGuid,
            (object) "@CompanyLineGuid",
            (object) (Guid) row[0]
          });
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void DeleteDetailRows()
  {
    for (int recordIndex = this.dsQuoteEdit.tblQuoteDetails.DefaultView.Count - 1; recordIndex >= 0; recordIndex += -1)
      this.dsQuoteEdit.tblQuoteDetails.DefaultView[recordIndex].Row.Delete();
  }

  private bool RefillQuoteDetailProgramCode()
  {
    return !(this.IsQuickQuote | this.IsNewQuote) && this.dsQuoteEdit.tblQuoteDetails.GetChanges() != null && (!this._effectiveDate.Equals(Conversions.ToDate(((UltraDateTimeEditor) this.dtEffectiveDate).Value)) || !((Guid) ((UltraCombo) this.cboIssuingOffice).Value).Equals(this._issuingOfficeGuid) || this._currentCompanyLineGuid != this.CompanyLineGuid);
  }

  private void DoSave()
  {
    if (!this.IsNewQuote && !this.Quote.IsCurrent)
    {
      this.LaunchSecondScreen();
      ((Form) this).Close();
    }
    else
    {
      if (!this.ValidForm())
        return;
      Cursor.Current = MgaCursors.WaitCursor;
      try
      {
        ((UltraGridBase) this.ugPolicyDetail).UpdateData();
        if (this.RefillQuoteDetailProgramCode())
          this.FillProgramCodeDropDown();
        Guid quotingLocationGuid = (Guid) ((UltraCombo) this.cboQuotingOffice).Value;
        dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
        if (this.IsNewQuote)
        {
          tblQuote.CostCenterID = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT dbo.GetDefaultCostCenterID(@quotingLocationGuid)", new object[2]
          {
            (object) "@quotingLocationGuid",
            (object) quotingLocationGuid
          });
          if (tblQuote.CostCenterID == 0)
            throw new frmQuoteEdit.CostCenterNotFoundException();
        }
        else
        {
          bool flag = DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT QuickQuote FROM tblQuotes WITH (NOLOCK) WHERE QuoteGuid=@QuoteGuid", new object[2]
          {
            (object) "@QuoteGuid",
            (object) this._quoteGuid
          });
          if (flag && !this.IsQuickQuote)
            DefaultDatabase.ExecuteNonQuery("dbo.UpdateEntityType", new object[4]
            {
              (object) "@EntityGUID",
              (object) this._quoteGuid,
              (object) "@EntityType",
              (object) typeof (frmPolicyDetail).ToString()
            });
          else if (!flag && this.IsQuickQuote)
            DefaultDatabase.ExecuteNonQuery("dbo.UpdateEntityType", new object[4]
            {
              (object) "@EntityGUID",
              (object) this._quoteGuid,
              (object) "@EntityType",
              (object) typeof (frmQuoteEdit).ToString()
            });
        }
        this.SetChangedFields(quotingLocationGuid);
        this.RowBinding.EndCurrentEdit();
        if (this.dsQuoteEdit.tblQuotes.GetChanges() != null || this.dsQuoteEdit.tblQuoteDetails.GetChanges() != null)
        {
          if (!this.SaveToDatabase())
            return;
          if (this.IsNewQuote)
          {
            this.SendBroadcastMessage(false);
          }
          else
          {
            this.RelinkRenewal();
            this.SendBroadcastMessage(true);
            this.CheckForChangedUnderwriter();
            this.CheckForChangedProducerContactOnQuote();
          }
          this.RefreshForms();
          this.LogChanges();
          this.UpdateAllQuotesIssuingLocation();
          this.UpdateCostCenter();
          this.EvaluateAffidavitNumber();
          this.ValidatePolicyNumberOnLineChanged();
          if (!this.IsNewQuote && this._modifiedEffectiveDate)
          {
            DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT QuoteOptionGuid FROM tblQuoteOptions WITH (NOLOCK) WHERE QuoteGuid=@QG", new object[2]
            {
              (object) "@QG",
              (object) this._quoteGuid
            });
            try
            {
              foreach (DataRow row in dataTable.Rows)
                this.Quote.AutoApplyFees((Guid) row[0]);
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
          }
          this.ResetPolicyForms();
        }
        Cursor.Current = MgaCursors.WaitCursor;
        this.IsConvertToFullQuote = this._isFullQuoteLinkPressed;
        this.LaunchSecondScreen();
        ((Form) this).Close();
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
    }
  }

  private void RelinkRenewal()
  {
    if (this.IsNewQuote || this._isEndorsement)
      return;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT RenewalOfControlNum FROM tblQuotes WITH (NOLOCK) WHERE QuoteGuid = @QG AND RenewalOfControlNum IS NOT NULL AND RenewalOfQuoteGuid IS NULL", new object[2]
    {
      (object) "@QG",
      (object) this.QuoteGuid
    }));
    if (objectValue == null || objectValue == DBNull.Value)
      return;
    Quote quote = Quote.FromControlNo(Conversions.ToInteger(objectValue));
    if (quote == null || this._quote.HasValidCompanyLineGuid && !quote.CompanyLineGuid.Equals((object) this._quote.CompanyLineGuid) || DialogResult.Yes != MessageBox.Show($"Do you wish to reestablish a renewal link to control # {objectValue.ToString()}?", "Reestablish Renewal Link", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      return;
    DefaultDatabase.ExecuteNonQuery("spReestablishRenewalLink", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid
    });
  }

  private void UpdateCostCenter()
  {
    if (this.IsNewQuote || this.IsQuickQuote || this._quote.IsEndorsement)
      return;
    DefaultDatabase.ExecuteNonQuery("GetQuoteCostCenterID", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid
    });
    if (this._isBound || !this._IgnoreCostCenterDefaultUpdate || !this._costCenterCheckOnCompanyLineChanged)
      return;
    dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
    if (tblQuote.IsCompanyLocationGuidNull() || tblQuote.IsLineGuidNull() || tblQuote.IsStateIDNull())
      return;
    if ((this._originalCompanyLocationGuid.Equals(Guid.Empty) || ((UltraCombo) this.cboCompanies).Value.Equals((object) this._originalCompanyLocationGuid)) && (this._originalLineGuid.Equals(Guid.Empty) || ((UltraCombo) this.cboLine).Value.Equals((object) this._originalLineGuid)) && (this._originalStateID.Equals(string.Empty) || ((UltraCombo) this.cboState).Value.Equals((object) this._originalStateID)))
      return;
    if (DefaultDatabase.ExecuteScalar<bool>("IsValidCostCenter", new object[2]
    {
      (object) "@quoteGuid",
      (object) this._quoteGuid
    }))
      return;
    string str1 = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.GetQuoteCurrentCostCenterName(@QuoteGuid)", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid
    });
    if (6 != (int) MessageBox.Show($"Company/line has changed and the cost center on this policy {"\n"}{"\n"} '{str1}' {"\n"}{"\n"} is invalid.{"\n"}{"\n"}Do you wish to update the cost center and continue?", "Invalid Cost Center.  Continue Update?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
    {
      CurrentUser.Instance.LogAction($"Company/line was changed. User opted to keep cost center {str1}", this._quoteGuid);
    }
    else
    {
      DefaultDatabase.ExecuteNonQuery("UpdateQuoteCostCenter", new object[2]
      {
        (object) "@QuoteGUID",
        (object) this._quoteGuid
      });
      string str2 = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.GetQuoteCurrentCostCenterName(@QuoteGuid)", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      });
      CurrentUser.Instance.LogAction($"Company/line was changed. Update cost center from '{str1}' to '{str2}'", this._quoteGuid);
    }
  }

  protected virtual bool ClientProgCodeSelection(
    CompanyLine cl,
    Guid issuingOfficeGuid,
    DateTime tmpEffDate,
    dsQuoteEdit.tblCompanyProgramCodesRow pRow)
  {
    return pRow.StateID.Equals(cl.StateID) && pRow.LineGUID == cl.LineGuid && DateTime.Compare(tmpEffDate, pRow.ContractEffective) >= 0 && DateTime.Compare(tmpEffDate, pRow.ContractExpiration) <= 0 && pRow.IssuingOfficeGUID == issuingOfficeGuid && pRow.CompanyLocationGUID == cl.CompanyLocationGuid;
  }

  protected virtual int GetQuoteDetailProgramCode(Guid companyLineGuid)
  {
    int detailProgramCode;
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboIssuingOffice).Value)))
    {
      detailProgramCode = int.MinValue;
    }
    else
    {
      DateTime date = Conversions.ToDate(Conversions.ToDate(((UltraDateTimeEditor) this.dtEffectiveDate).Value).ToShortDateString());
      CompanyLine companyLineObject = this.GetCompanyLineObject(companyLineGuid);
      int num = int.MinValue;
      Guid? nullable = new Guid?();
      if (companyLineObject.ParentCompanyLineGuid.HasValue)
        nullable = new Guid?(this.GetCompanyLineObject(companyLineObject.ParentCompanyLineGuid.Value).LineGuid);
      try
      {
        foreach (dsQuoteEdit.tblCompanyProgramCodesRow row in this.dsQuoteEdit.tblCompanyProgramCodes.Rows)
        {
          if ((row.LineGUID == companyLineObject.LineGuid || row.LineGUID.Equals(Guid.Empty)) && (row.StateID.Equals(companyLineObject.StateID) || row.StateID.Equals("&&")) && (row.IssuingOfficeGUID == (Guid) ((UltraCombo) this.cboIssuingOffice).Value || row.IssuingOfficeGUID.Equals(Guid.Empty)) && (row.CompanyLocationGUID == companyLineObject.CompanyLocationGuid || row.CompanyLocationGUID.Equals(Guid.Empty)) && (row.IsGroupCodeNull() || row.GroupCode.Equals(this.LineGroupProgramCode(companyLineObject.LineGuid)) || row.GroupCode.Equals("&&")) && DateTime.Compare(date, row.ContractEffective) >= 0 && DateTime.Compare(date, row.ContractExpiration) <= 0 && (row.IsParentLineGUIDNull() || row.ParentLineGUID.Equals(Guid.Empty) || row.ParentLineGUID.Equals((object) nullable)))
          {
            if (this._autoSelectProgramCode && this.ClientProgCodeSelection(companyLineObject, (Guid) ((UltraCombo) this.cboIssuingOffice).Value, date, row))
            {
              detailProgramCode = row.ProgramID;
              goto label_19;
            }
            if (this._ignoreDuplicateProgramCodes && !this._autoSelectProgramCode)
            {
              detailProgramCode = row.ProgramID;
              goto label_19;
            }
            if (num != int.MinValue)
            {
              detailProgramCode = -1;
              goto label_19;
            }
            num = row.ProgramID;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      detailProgramCode = num;
    }
label_19:
    return detailProgramCode;
  }

  private object GetQuoteDetailProgramCode(
    Guid companyLineGuid,
    Guid issuingOfficeGuid,
    DateTime quoteEffectiveDate,
    bool ignoreDuplicates)
  {
    CompanyLine companyLineObject = this.GetCompanyLineObject(companyLineGuid);
    object obj = (object) null;
    Guid? nullable = new Guid?();
    if (companyLineObject.ParentCompanyLineGuid.HasValue)
      nullable = new Guid?(this.GetCompanyLineObject(companyLineObject.ParentCompanyLineGuid.Value).LineGuid);
    object detailProgramCode;
    try
    {
      foreach (dsQuoteEdit.tblCompanyProgramCodesRow row in this.dsQuoteEdit.tblCompanyProgramCodes.Rows)
      {
        Guid guid;
        if (!(row.LineGUID == companyLineObject.LineGuid))
        {
          guid = row.LineGUID;
          if (!guid.Equals(Guid.Empty))
            continue;
        }
        if (row.StateID.Equals(companyLineObject.StateID) || row.StateID.Equals("&&"))
        {
          if (!(row.IssuingOfficeGUID == issuingOfficeGuid))
          {
            guid = row.IssuingOfficeGUID;
            if (!guid.Equals(Guid.Empty))
              continue;
          }
          if (!(row.CompanyLocationGUID == companyLineObject.CompanyLocationGuid))
          {
            guid = row.CompanyLocationGUID;
            if (!guid.Equals(Guid.Empty))
              continue;
          }
          if ((row.IsGroupCodeNull() || row.GroupCode.Equals(this.LineGroupProgramCode(companyLineObject.LineGuid)) || row.GroupCode.Equals("&&")) && DateTime.Compare(quoteEffectiveDate, row.ContractEffective) >= 0 && DateTime.Compare(quoteEffectiveDate, row.ContractExpiration) <= 0)
          {
            if (!row.IsParentLineGUIDNull())
            {
              guid = row.ParentLineGUID;
              if (!guid.Equals(Guid.Empty))
              {
                guid = row.ParentLineGUID;
                if (!guid.Equals((object) nullable))
                  continue;
              }
            }
            if (ignoreDuplicates)
            {
              detailProgramCode = (object) row.ProgramID;
              goto label_25;
            }
            if (obj != null)
            {
              detailProgramCode = (object) null;
              goto label_25;
            }
            obj = (object) row.ProgramID;
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    detailProgramCode = obj;
label_25:
    return detailProgramCode;
  }

  private string LineGroupProgramCode(Guid lineGuid)
  {
    string str;
    try
    {
      foreach (DataRow row in this.LineGroupTable.Rows)
      {
        if (((Guid) row["LineGuid"]).Equals(lineGuid))
        {
          str = row["GroupCode"].ToString();
          goto label_8;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    str = "##";
label_8:
    return str;
  }

  protected virtual void ResetPolicyForms()
  {
    if (this.IsNewQuote || DateTime.Compare(this._effectiveDate, Conversions.ToDate(((UltraDateTimeEditor) this.dtEffectiveDate).Value)) == 0)
      return;
    this.Quote.ResetPolicyForms();
  }

  protected virtual void UpdateAllQuotesIssuingLocation()
  {
    if (this.IsNewQuote || this._issuingOfficeGuid.Equals(Guid.Empty) || string.IsNullOrEmpty(((UltraCombo) this.cboIssuingOffice).Text) || ((Guid) ((UltraCombo) this.cboIssuingOffice).Value).Equals(this._issuingOfficeGuid))
      return;
    if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "Select COUNT(*) FROM tblQuotes WITH (NOLOCK) WHERE QuoteGuid <> @QG AND QuoteStatusID <> 3 AND SubmissionGroupGuid = @SG", new object[4]
    {
      (object) "@QG",
      (object) this._quoteGuid,
      (object) "@SG",
      (object) this.Quote.SubmissionGroupGuid
    }) <= 0 || MessageBox.Show("The issuing office has changed.\n\nWould you like to update all quotes in the submission group with the new issuing office?", "Issuing Office Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    DefaultDatabase.ExecuteNonQuery("dbo.spUpdateSubmissionQuotesIssuingOffice", new object[4]
    {
      (object) "@quoteGuid",
      (object) this._quoteGuid,
      (object) "@issuingLocationGuid",
      ((UltraCombo) this.cboIssuingOffice).Value
    });
  }

  private void SendBroadcastMessage(bool isModification)
  {
    Quote quote = new Quote(this.dsQuoteEdit.tblQuotes[0].QuoteGuid);
    if (!isModification)
    {
      if (quote.IsRenewal)
        Messaging.SendBroadcastMessage(BroadcastMessages.NewRenewal, (object) this.QuoteGuid);
      else
        Messaging.SendBroadcastMessage(BroadcastMessages.NewQuote, (object) this.QuoteGuid);
      if (quote.SubmissionGroup.QuoteCount == 1)
      {
        Thread.Sleep(3000);
        Messaging.SendBroadcastMessage(BroadcastMessages.FirstQuoteOnSubmission, (object) this.QuoteGuid);
      }
    }
    Messaging.SendBroadcastMessage(BroadcastMessages.QuoteModified, (object) this.QuoteGuid);
  }

  private void SetStateField()
  {
    dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
    if (((UltraCombo) this.cboState).Text.Length == 0)
    {
      if (!this.IsQuickQuote)
        throw new InvalidOperationException("Should not have passed ValidForm() - State required if not a quick quote");
      if (!tblQuote.IsStateIDNull())
        tblQuote.SetStateIDNull();
    }
    else if (tblQuote.IsStateIDNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblQuote.StateID, (string) ((UltraCombo) this.cboState).Value, false) != 0)
      tblQuote.StateID = (string) ((UltraCombo) this.cboState).Value;
  }

  private void SetCompanyField()
  {
    dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
    if (((UltraCombo) this.cboCompanies).Text.Length == 0)
    {
      if (!this.IsQuickQuote)
        throw new InvalidOperationException("Should not have passed ValidForm() - Company required if not a quick quote");
      if (!tblQuote.IsCompanyLocationGuidNull())
        tblQuote.SetCompanyLocationGuidNull();
    }
    else if (tblQuote.IsCompanyLocationGuidNull() || !tblQuote.CompanyLocationGuid.Equals((Guid) ((UltraCombo) this.cboCompanies).Value))
      tblQuote.CompanyLocationGuid = (Guid) ((UltraCombo) this.cboCompanies).Value;
  }

  private void SetExpiringControlNorelatedFields()
  {
    dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
    int num1;
    if (((UltraNumericEditor) this.txtExpiringControlNumber).Value != null && ((UltraNumericEditor) this.txtExpiringControlNumber).Value != DBNull.Value)
    {
      ((UltraNumericEditor) this.txtExpiringControlNumber).Value = (object) Conversions.ToInteger(((UltraNumericEditor) this.txtExpiringControlNumber).Value);
      num1 = Conversions.ToInteger(((UltraNumericEditor) this.txtExpiringControlNumber).Value);
    }
    else
      num1 = -1;
    if (this._OrigExpiringcontrolno != num1)
    {
      if (num1 == -1)
      {
        tblQuote.SetRenewalofQuoteGUIDNull();
        tblQuote.SetRenewalofControlNumNull();
      }
      else
      {
        object objectValue1 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT COUNT(*) FROM tblquotes where controlno = @RenewalOfControlNum", new object[2]
        {
          (object) "@RenewalOfControlNum",
          ((UltraNumericEditor) this.txtExpiringControlNumber).Value
        }));
        if (objectValue1 == null | Conversions.ToInteger(objectValue1) == 0)
        {
          int num2 = (int) MessageBox.Show("Please enter a valid expired control number.  The expired control number you entered does not exist.", "Invalid Expired Control Number ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          if (this._OrigExpiringcontrolno == -1)
            ((UltraNumericEditor) this.txtExpiringControlNumber).Value = (object) null;
          else
            ((UltraNumericEditor) this.txtExpiringControlNumber).Value = (object) this._OrigExpiringcontrolno;
        }
        else
        {
          object objectValue2 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1  QuoteGuid FROM tblQuotes WITH (NOLOCK) WHERE ControlNo = @RenewalOfControlNum ORDER BY QuoteID DESC", new object[2]
          {
            (object) "@RenewalOfControlNum",
            ((UltraNumericEditor) this.txtExpiringControlNumber).Value
          }));
          if (objectValue2 != null)
            tblQuote.RenewalofQuoteGUID = (Guid) objectValue2;
          else
            tblQuote.SetRenewalofQuoteGUIDNull();
          tblQuote.RenewalofControlNum = Conversions.ToInteger(((UltraNumericEditor) this.txtExpiringControlNumber).Value);
        }
      }
    }
  }

  private void SetBillingField()
  {
    dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
    if ((tblQuote.IsBillingTypeIDNull() || tblQuote.BillingTypeID != Conversions.ToInteger(((UltraCombo) this.cboBillingTypes).Value)) && ((UltraCombo) this.cboBillingTypes).Value != null)
    {
      if (!this.IsQuickQuote && ((UltraCombo) this.cboBillingTypes).Value == null)
        throw new InvalidOperationException("cboBillingTypes.Value can not be null when not a Quick Quote");
      if (((UltraCombo) this.cboBillingTypes).Text.Replace(" ", string.Empty).Length == 0)
        tblQuote.SetBillingTypeIDNull();
      else
        tblQuote.BillingTypeID = Conversions.ToInteger(((UltraCombo) this.cboBillingTypes).Value);
    }
  }

  private void SetFinanceCompanyField()
  {
    dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
    if (((UltraDropDownBase) this.cboFinanceCompany).SelectedRow == null || ((UltraDropDownBase) this.cboFinanceCompany).SelectedRow.Index == 0)
    {
      if (!tblQuote.IsFinanceCompanyGuidNull())
        tblQuote.SetFinanceCompanyGuidNull();
    }
    else if (tblQuote.IsFinanceCompanyGuidNull() || !tblQuote.FinanceCompanyGuid.Equals((Guid) ((UltraCombo) this.cboFinanceCompany).Value))
      tblQuote.FinanceCompanyGuid = (Guid) ((UltraCombo) this.cboFinanceCompany).Value;
  }

  private void SetLocationFields(Guid quotingLocationGuid)
  {
    dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
    if (tblQuote.IsQuotingLocationGuidNull() || !quotingLocationGuid.Equals(tblQuote.QuotingLocationGuid))
      tblQuote.QuotingLocationGuid = quotingLocationGuid;
    if (tblQuote.IsIssuingLocationGuidNull() || !tblQuote.IssuingLocationGuid.Equals((Guid) ((UltraCombo) this.cboIssuingOffice).Value))
      tblQuote.IssuingLocationGuid = (Guid) ((UltraCombo) this.cboIssuingOffice).Value;
  }

  private void SetDateFields()
  {
    dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
    if (DateTime.Compare(tblQuote.EffectiveDate, ((UltraDateTimeEditor) this.dtEffectiveDate).DateTime) != 0)
      tblQuote.EffectiveDate = ((UltraDateTimeEditor) this.dtEffectiveDate).DateTime;
    if (DateTime.Compare(tblQuote.ExpirationDate, ((UltraDateTimeEditor) this.dtExpirationDate).DateTime) != 0)
      tblQuote.ExpirationDate = ((UltraDateTimeEditor) this.dtExpirationDate).DateTime;
  }

  private void SetChangedFields(Guid quotingLocationGuid)
  {
    dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
    tblQuote.ExpiringPolicyNumber = ((TextEditorControlBase) this.txtExpiringPolicyNumber).Text;
    if (tblQuote.IsLineGuidNull() || !tblQuote.LineGuid.Equals((Guid) ((UltraCombo) this.cboLine).Value))
      tblQuote.LineGuid = (Guid) ((UltraCombo) this.cboLine).Value;
    if (tblQuote.QuickQuote != this.IsQuickQuote)
      tblQuote.QuickQuote = this.IsQuickQuote;
    this.SetStateField();
    if (tblQuote.IsUnderwriterUserGuidNull() || !tblQuote.UnderwriterUserGuid.Equals((Guid) ((UltraCombo) this.cboUnderwriter).Value))
      tblQuote.UnderwriterUserGuid = (Guid) ((UltraCombo) this.cboUnderwriter).Value;
    this.SetCompanyField();
    this.SetBillingField();
    this.SetExpiringControlNorelatedFields();
    this.SetDateFields();
    this.SetLocationFields(quotingLocationGuid);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboProducerContact).Text, string.Empty, false) != 0 && (tblQuote.IsProducerContactGuidNull() || !tblQuote.ProducerContactGuid.Equals((Guid) ((UltraCombo) this.cboProducerContact).Value)))
      tblQuote.ProducerContactGuid = (Guid) ((UltraCombo) this.cboProducerContact).Value;
    if (tblQuote.PolicyTypeID != (int) ((UltraCombo) this.cboPolicyType).Value)
      tblQuote.PolicyTypeID = (int) ((UltraCombo) this.cboPolicyType).Value;
    this.SetFinanceCompanyField();
    this.SetSICCodeField();
    this.SetNaicsCodeField();
    this.SetTACSRField();
    if (((UltraCombo) this.cboInspectionCompanies).Text.Length == 0 && !tblQuote.IsInspectionCompanyIDNull())
      tblQuote.SetInspectionCompanyIDNull();
    else if (((UltraCombo) this.cboInspectionCompanies).Value != null && ((UltraCombo) this.cboInspectionCompanies).Value != DBNull.Value && Conversions.ToInteger(((UltraCombo) this.cboInspectionCompanies).Value) != -1)
      tblQuote.InspectionCompanyID = Conversions.ToInteger(((UltraCombo) this.cboInspectionCompanies).Value);
    else
      tblQuote.SetInspectionCompanyIDNull();
    this.SetUnderwriterField();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboSecProducerContact).Text, string.Empty, false) != 0)
      tblQuote.SecProducerContactGuid = (Guid) ((UltraCombo) this.cboSecProducerContact).Value;
    else
      tblQuote.SetSecProducerContactGuidNull();
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboEarnedPremiumType).Text))
      tblQuote.EarnedPremiumTypeID = (byte) ((UltraCombo) this.cboEarnedPremiumType).Value;
    else
      tblQuote.SetEarnedPremiumTypeIDNull();
    if (this.optionAuditable.Value != null)
      tblQuote.Auditable = (bool) this.optionAuditable.Value;
  }

  private void SetTACSRField()
  {
    dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboTA).Text, string.Empty, false) != 0)
    {
      if (tblQuote.IsTACSRUserGuidNull() || !tblQuote.TACSRUserGuid.Equals((Guid) ((UltraCombo) this.cboTA).Value))
        tblQuote.TACSRUserGuid = (Guid) ((UltraCombo) this.cboTA).Value;
    }
    else
      tblQuote.SetTACSRUserGuidNull();
  }

  private void SetSICCodeField()
  {
    dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
    if (((UltraCombo) this.cboRiskClass).Value == DBNull.Value || ((UltraCombo) this.cboRiskClass).Value == null)
    {
      if (!tblQuote.IsSIC_CodeNull())
        tblQuote.SetSIC_CodeNull();
    }
    else if (tblQuote.IsSIC_CodeNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblQuote.SIC_Code, (string) ((UltraCombo) this.cboRiskClass).Value, false) != 0)
      tblQuote.SIC_Code = (string) ((UltraCombo) this.cboRiskClass).Value;
  }

  private void SetNaicsCodeField()
  {
    dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
    if (((UltraCombo) this.cboNAICSCode).Value == DBNull.Value || ((UltraCombo) this.cboNAICSCode).Value == null)
    {
      if (!tblQuote.IsNAICSCodeNull())
        tblQuote.SetNAICSCodeNull();
    }
    else if (tblQuote.IsNAICSCodeNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblQuote.NAICSCode, (string) ((UltraCombo) this.cboNAICSCode).Value, false) != 0)
      tblQuote.NAICSCode = (string) ((UltraCombo) this.cboNAICSCode).Value;
  }

  private void SetUnderwriterField()
  {
    dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboUnderwritingAssistant).Text, string.Empty, false) != 0)
    {
      if (tblQuote.IsUnderwritingAssistantGuidNull() || !tblQuote.IsUnderwritingAssistantGuidNull().Equals((object) (Guid) ((UltraCombo) this.cboUnderwritingAssistant).Value))
        tblQuote.UnderwritingAssistantGuid = (Guid) ((UltraCombo) this.cboUnderwritingAssistant).Value;
    }
    else
      tblQuote.SetUnderwritingAssistantGuidNull();
  }

  private bool SaveToDatabase()
  {
    int num1 = 2;
    object objectValue1 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("GetPolicyNumberRule", new object[2]
    {
      (object) "@quoteGuid",
      (object) this.QuoteGuid
    }));
    int num2 = num1 - 1;
    for (int index = 0; index <= num2; ++index)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmQuoteEdit._Closure\u0024__662\u002D0 closure6620 = new frmQuoteEdit._Closure\u0024__662\u002D0(closure6620);
      // ISSUE: reference to a compiler-generated field
      closure6620.\u0024VB\u0024Me = this;
      // ISSUE: reference to a compiler-generated field
      closure6620.\u0024VB\u0024Local_success = false;
      // ISSUE: reference to a compiler-generated method
      DefaultDatabase.ExecuteTransaction(new EventHandler<ExecuteTransactionEventArgs>(closure6620._Lambda\u0024__0));
      // ISSUE: reference to a compiler-generated field
      if (closure6620.\u0024VB\u0024Local_success)
      {
        if (!this._isBound && !this._isEndorsement)
        {
          object objectValue2 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("GetPolicyNumberRule", new object[2]
          {
            (object) "@quoteGuid",
            (object) this.QuoteGuid
          }));
          if (!this.AreObjectsEqual(RuntimeHelpers.GetObjectValue(objectValue1), RuntimeHelpers.GetObjectValue(objectValue2)) && this.ResetPolicyNumber(RuntimeHelpers.GetObjectValue(objectValue1), RuntimeHelpers.GetObjectValue(objectValue2)))
          {
            bool flag = true;
            if (!this._promptResetPolicyNumber && DialogResult.Yes != MessageBox.Show("Company/line or effective date has changed or the administered policy # rule is different." + $"{Environment.NewLine}{Environment.NewLine}Clear Policy # Information?", "Clear Policy # Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
              flag = false;
            if (flag)
            {
              DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET PolicyNumberRuleID = NULL, PolicyNumberIndex = NULL, PolicyNumber = NULL WHERE QuoteGuid = @QuoteGuid", new object[2]
              {
                (object) "@QuoteGuid",
                (object) this.QuoteGuid
              });
              CurrentUser.Instance.LogAction("Clear policy # - Company/line or effective date has changed or the Policy # rule is different for the new line.", this.QuoteGuid);
            }
          }
          if (this._originalPolicyTypeId != 1 && this.dsQuoteEdit.tblQuotes[0].PolicyTypeID == 1)
          {
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET RenewalOfQuoteGuid = NULL WHERE QuoteGuid = @QuoteGuid", new object[2]
            {
              (object) "@QuoteGuid",
              (object) this.QuoteGuid
            });
            CurrentUser.Instance.LogAction("Clear Renewal link - Policy type is changed to new.", this.QuoteGuid);
            break;
          }
          break;
        }
        break;
      }
    }
    return true;
  }

  private bool ResetPolicyNumber(object originalPolicyNumberingRule, object newPolicyNumberingRule)
  {
    bool flag;
    if (this._isEndorsement || this._isNewQuote)
      flag = false;
    else if (this._currentCompanyLineGuid.Equals(this.CompanyLineGuid) && this._effectiveDate.Date.Equals(Conversions.ToDate(((UltraDateTimeEditor) this.dtEffectiveDate).Value).Date))
      flag = false;
    else if (!this._promptResetPolicyNumber)
    {
      flag = true;
    }
    else
    {
      string str1 = string.Empty;
      string str2 = string.Empty;
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(originalPolicyNumberingRule)))
        str1 = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT RuleName FROM tblPolicyNumberRules WITH (NOLOCK) WHERE RuleID = @ID", new object[2]
        {
          (object) "@ID",
          originalPolicyNumberingRule
        });
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(newPolicyNumberingRule)))
        str2 = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT RuleName FROM tblPolicyNumberRules WITH (NOLOCK) WHERE RuleID = @ID", new object[2]
        {
          (object) "@ID",
          newPolicyNumberingRule
        });
      if (DialogResult.Yes != MessageBox.Show($"Company/line or effective date has changed and a new policy # rule will regenerate on binding.\n\nWould you like to clear the current policy # and update the policy # rule from \n\n{str1}\nto\n{str2}?", "Clear Current Policy # And Update Policy # Rule?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      {
        CurrentUser.Instance.LogAction($"On saving Quote Info - User opted NOT to clear the old policy # with rule {str1}. New policy # rule available is {str2}", this._quoteGuid);
        flag = false;
      }
      else
      {
        CurrentUser.Instance.LogAction($"On saving Quote Info - User opted to clear the old policy # with rule {str1}. New policy # rule available is {str2}", this._quoteGuid);
        flag = true;
      }
    }
    return flag;
  }

  private void CheckForChangedUnderwriter()
  {
    if (!this.dsQuoteEdit.tblQuotes[0].IsUnderwriterUserGuidNull() && !this._underWriterGuid.Equals(this.dsQuoteEdit.tblQuotes[0].UnderwriterUserGuid))
    {
      this._quote.SendNewSubmissionDiaryItem();
      if (!this.dsQuoteEdit.tblQuotes[0].UnderwriterUserGuid.Equals(Guid.Empty))
      {
        this.UnderwriterChanged(this.dsQuoteEdit.tblQuotes[0].UnderwriterUserGuid);
        Messaging.SendBroadcastMessage(BroadcastMessages.UnderwriterChanged, (object) this.QuoteGuid);
      }
      DefaultDatabase.ExecuteNonQuery("dbo.UpdateUnderwriterOnSubmission", new object[2]
      {
        (object) "@quoteGuid",
        (object) this.QuoteGuid
      });
    }
    if (this.dsQuoteEdit.tblQuotes[0].IsUnderwritingAssistantGuidNull() || this._underWriterAssistantGuid.Equals(Guid.Empty) || this._underWriterAssistantGuid.Equals(this.dsQuoteEdit.tblQuotes[0].UnderwritingAssistantGuid))
      return;
    this.UnderwritingAssistantChanged(this.dsQuoteEdit.tblQuotes[0].UnderwritingAssistantGuid);
  }

  private void CheckForChangedProducerContact()
  {
    if (this.IsNewQuote || ((UltraCombo) this.cboProducerContact).Value == null || this._currentProducerContactGuid.Equals((Guid) ((UltraCombo) this.cboProducerContact).Value) || MessageBox.Show("The producer contact on this quote has been changed.\n\nDo you wish to update the producer contact on the submission level with this new producer contact?", "Update Producer Contact On Submission Level?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblSubmissionGroup SET producerContactID = @prodContID WHERE SubmissionGroupGUID = @subGroupGuid", new object[4]
    {
      (object) "@prodContID",
      (object) DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT ProducerContactID FROM tblProducerContacts WHERE ProducerContactGUID = @prodContGuid", new object[2]
      {
        (object) "@prodContGuid",
        (object) (Guid) ((UltraCombo) this.cboProducerContact).Value
      }),
      (object) "@subGroupGuid",
      (object) this.Quote.SubmissionGroupGuid
    });
  }

  private void LoadFriendlyColumnName(Dictionary<string, string> dictColName)
  {
    Dictionary<string, string> dictionary = dictColName;
    dictionary.Add("QuotingLocationGuid", "Quoting Location");
    dictionary.Add("IssuingLocationGuid", "Issuing Location");
    dictionary.Add("CompanyLocationGuid", "Company Location");
    dictionary.Add("LineGuid", "Line of Business");
    dictionary.Add("StateID", "State");
    dictionary.Add("ProducerContactGuid", "Producer Contact");
    dictionary.Add("RetailerGuid", "Retailer");
    dictionary.Add("QuoteStatusID", "Quote Status");
    dictionary.Add("PolicyTypeID", "Policy Type");
    dictionary.Add("TACSRUserGuid", "TA CSR");
    dictionary.Add("SIC_Code", "SIC_Code");
    dictionary.Add("BillingTypeID", "Billing Type");
    dictionary.Add("MinimumEarnedPercentage", "Minimum Earned Percentage");
    dictionary.Add("RiskDescription", "Risk Description");
    dictionary.Add("UnderwritingAssistantGuid", "Underwriting Assistant");
    dictionary.Add("ProducerLocationID", "Producer Location");
    dictionary.Add("EndorsementComment", "Endorsement Comment");
    dictionary.Add("EndorsementEffective", "Endorsement Effective");
    dictionary.Add("UnderwriterUserGuid", "Underwriter");
    dictionary.Add("FinanceCompanyGuid", "Finance Company");
    dictionary.Add("SecProducerContactGuid", "Producer CSR");
    dictionary.Add("AccountNumber", "Account #");
    dictionary.Add("ExpiringPolicyNumber", "Expiring Policy Number");
    dictionary.Add("PreviousPremium", "Previous Premium");
    dictionary.Add("InspectionCompanyID", "Inspection Company");
  }

  private void GetRowChanges(
    dsQuoteEdit.tblQuotesRow row,
    string colName,
    List<frmQuoteEdit.QuoteStructure> quoteColumnChangesList)
  {
    frmQuoteEdit.QuoteStructure quoteStructure = new frmQuoteEdit.QuoteStructure();
    quoteStructure.ColumnName = colName;
    quoteStructure.CurrValue = row[colName] == DBNull.Value ? string.Empty : row[colName, DataRowVersion.Current].ToString();
    quoteStructure.OrigValue = row[colName, DataRowVersion.Original] == DBNull.Value ? string.Empty : row[colName, DataRowVersion.Original].ToString();
    switch (DatabaseTypeConvertor.ToSqlDbType(row.Table.Columns[colName].DataType))
    {
      case SqlDbType.UniqueIdentifier:
        quoteStructure.EntityType = 'U';
        break;
      case SqlDbType.TinyInt:
        quoteStructure.EntityType = 'T';
        break;
    }
    quoteColumnChangesList.Add(quoteStructure);
  }

  private void LogChanges(
    dsQuoteEdit.tblQuotesRow row,
    Dictionary<string, string> dictColName,
    List<frmQuoteEdit.QuoteStructure> quoteColumnChangesList)
  {
    int num = quoteColumnChangesList.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      frmQuoteEdit.QuoteStructure quoteColumnChanges = quoteColumnChangesList[index];
      if (quoteColumnChanges.EntityType == 'U' || quoteColumnChanges.EntityType == 'T')
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(quoteColumnChanges.OrigValue, string.Empty, false) != 0)
          quoteColumnChanges.OrigValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetQuoteEntityName(@Entity,@SqlType)", new object[4]
          {
            (object) "@Entity",
            (object) quoteColumnChanges.OrigValue,
            (object) "@SqlType",
            (object) quoteColumnChanges.EntityType.ToString()
          })), "").ToString();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(quoteColumnChanges.CurrValue, string.Empty, false) != 0)
          quoteColumnChanges.CurrValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetQuoteEntityName(@Entity,@SqlType)", new object[4]
          {
            (object) "@Entity",
            (object) quoteColumnChanges.CurrValue,
            (object) "@SqlType",
            (object) quoteColumnChanges.EntityType.ToString()
          })), "").ToString();
      }
      string columnName = quoteColumnChanges.ColumnName;
      if (dictColName.ContainsKey(quoteColumnChanges.ColumnName))
        columnName = dictColName[quoteColumnChanges.ColumnName];
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(quoteColumnChanges.OrigValue, string.Empty, false) == 0)
        quoteColumnChanges.OrigValue = "<empty>";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(quoteColumnChanges.CurrValue, string.Empty, false) == 0)
        quoteColumnChanges.CurrValue = "<empty>";
      CurrentUser.Instance.LogAction($"Modify Quote: Changed {columnName} from {quoteColumnChanges.OrigValue} to {quoteColumnChanges.CurrValue}", this.QuoteGuid);
    }
  }

  private void LogChanges()
  {
    Dictionary<string, string> dictColName = new Dictionary<string, string>();
    List<frmQuoteEdit.QuoteStructure> quoteColumnChangesList = new List<frmQuoteEdit.QuoteStructure>();
    if (this.IsNewQuote)
    {
      CurrentUser.Instance.LogAction("New Quote - Control # " + Conversions.ToString(this.dsQuoteEdit.tblQuotes[0].ControlNo), this.dsQuoteEdit.tblQuotes[0].QuoteGuid);
    }
    else
    {
      dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
      if (tblQuote.RowState == DataRowState.Modified)
      {
        this.LoadFriendlyColumnName(dictColName);
        try
        {
          foreach (DataColumn column in (InternalDataCollectionBase) this.dsQuoteEdit.tblQuotes.Columns)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblQuote[column.ColumnName, DataRowVersion.Original].ToString(), tblQuote[column.ColumnName, DataRowVersion.Current].ToString(), false) != 0)
              this.GetRowChanges(tblQuote, column.ColumnName, quoteColumnChangesList);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        this.QuoteDataChanged(tblQuote);
      }
      if (quoteColumnChangesList.Count > 0)
        this.LogChanges(this.dsQuoteEdit.tblQuotes[0], dictColName, quoteColumnChangesList);
      string str = "<empty>";
      if (this.optionAuditable.Value != null)
        str = !(bool) this.optionAuditable.Value ? "Non-Auditable" : "Auditable";
      if (!this._objOriginalAuditable.Equals(str))
        CurrentUser.Instance.LogAction($"Modify Quote - Changed 'Auditable Option' from '{this._objOriginalAuditable}' to '{str}'", this.dsQuoteEdit.tblQuotes[0].QuoteGuid);
    }
    if (!this.IsNewQuote)
    {
      try
      {
        foreach (dsQuoteEdit.tblQuoteDetailsRow tblQuoteDetail in (TypedTableBase<dsQuoteEdit.tblQuoteDetailsRow>) this.dsQuoteEdit.tblQuoteDetails)
        {
          if (tblQuoteDetail.RowState == DataRowState.Modified)
          {
            object objectValue1 = RuntimeHelpers.GetObjectValue(tblQuoteDetail["CompanyCommission", DataRowVersion.Original]);
            object objectValue2 = RuntimeHelpers.GetObjectValue(tblQuoteDetail["CompanyCommission", DataRowVersion.Current]);
            if (!objectValue1.ToString().Equals(objectValue2.ToString()))
              CurrentUser.Instance.LogAction($"Changed Company Commission from {objectValue1.ToString()} to {objectValue2.ToString()}", this.QuoteGuid);
            object objectValue3 = RuntimeHelpers.GetObjectValue(tblQuoteDetail["ProducerCommission", DataRowVersion.Original]);
            object objectValue4 = RuntimeHelpers.GetObjectValue(tblQuoteDetail["ProducerCommission", DataRowVersion.Current]);
            if (!objectValue3.ToString().Equals(objectValue4.ToString()))
              CurrentUser.Instance.LogAction($"Changed Producer Commission from {objectValue3.ToString()}to {objectValue4.ToString()}", this.QuoteGuid);
          }
        }
      }
      finally
      {
        IEnumerator<dsQuoteEdit.tblQuoteDetailsRow> enumerator;
        enumerator?.Dispose();
      }
    }
    if (!this.AllowSaveWithLapseInRenewalPolicyTerms)
      return;
    CurrentUser.Instance.LogAction("Modified the effective date on the current renewal policy and allow lapse in coverage.", this.QuoteGuid);
  }

  private void RefreshForms()
  {
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      switch (mdiChildren[index])
      {
        case frmClearance frmClearance:
          dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
          if (this.IsNewQuote)
          {
            object obj = (object) null;
            string state = string.Empty;
            if (!tblQuote.IsCompanyLocationGuidNull() && !tblQuote.IsStateIDNull())
            {
              obj = (object) tblQuote.CompanyLocationGuid;
              state = this.dsQuoteEdit.lstStates.FindByStateID(tblQuote.StateID).State;
            }
            frmClearance.AddQuote(tblQuote.QuoteGuid, tblQuote.SubmissionGroupGuid, RuntimeHelpers.GetObjectValue(obj), tblQuote.EffectiveDate, tblQuote.ExpirationDate, ((UltraCombo) this.cboLine).Text, ((UltraCombo) this.cboCompanies).Text, tblQuote.ControlNo, state, tblQuote.QuickQuote);
            break;
          }
          frmClearance.UpdateQuote(tblQuote.QuoteGuid);
          break;
        case frmPolicyDetail frmPolicyDetail:
          if (frmPolicyDetail.Quote.QuoteGuid.Equals(this._quoteGuid))
          {
            frmPolicyDetail.RefreshPolicyData();
            break;
          }
          break;
      }
      checked { ++index; }
    }
  }

  private void LaunchSecondScreen()
  {
    if (this.IsQuickQuote)
      return;
    frmQuoteEdit2 objectAs = ObjectFactory.Instance.CreateObjectAs<frmQuoteEdit2>(new object[1]
    {
      (object) this.dsQuoteEdit.tblQuotes[0].QuoteGuid
    });
    objectAs.IsNewQuote = this.IsNewQuote;
    objectAs.IsConvertToFullQuote = this._isConvertToFullQuote;
    objectAs.MdiParent = MDIControls.Instance.MDIParent;
    API.LockWindowUpdate(MDIControls.Instance.MDIParent.Handle);
    objectAs.Show();
    API.LockWindowUpdate(new IntPtr());
    objectAs.BringToFront();
    MDIControls.Instance.MDIParent.Refresh();
  }

  protected virtual void UnderwriterChanged(Guid newUnderwriterGuid)
  {
  }

  private void DdCompanyContacts_BeforeDropDown(object sender, CancelEventArgs e)
  {
    this.dsQuoteEdit.tblCompanyContacts.DefaultView.RowFilter = $"CompanyLocationGuid='{this.GetCompanyLineObject((Guid) ((UltraGridBase) this.ugPolicyDetail).ActiveRow.Cells["CompanyLineGuid"].Value).CompanyLocationGuid.ToString()}'";
  }

  private void DdCompanyContacts_AfterCloseUp(object sender, DropDownEventArgs e)
  {
    this.dsQuoteEdit.tblCompanyContacts.DefaultView.RowFilter = string.Empty;
    ((UltraGridBase) this.ugPolicyDetail).Refresh();
  }

  private void DisableOptionItems()
  {
    ((Control) this.cboLine).Enabled = false;
    ((Control) this.cboState).Enabled = false;
    ((Control) this.cboCompanies).Enabled = this._quote.OptionCount == 0;
    ((Control) this.cboPolicyType).Enabled = false;
    ((Control) this.cboQuotingOffice).Enabled = false;
    if (this._quote.OptionCount > 0)
      this.lnkNewCompanyContact.Text = "Change Company";
    ((Control) this.lblDisabledItems).Visible = true;
    this.lnkConvertQuickQuote.Enabled = false;
    ((Control) this.lblDisabledItems).Top = ((Control) this.btnNext).Top;
    ((Control) this.lblDisabledItems).Height = ((Control) this.btnNext).Height;
  }

  private void DisableBoundItems()
  {
    this.DisableOptionItems();
    ((Control) this.cboUnderwriter).Enabled = false;
    UltraGridBand band = ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Bands[0];
    band.Columns["CompanyCommission"].CellActivation = (Activation) 2;
    band.Columns["ProducerCommission"].CellActivation = (Activation) 2;
    ((Control) this.dtEffectiveDate).Enabled = false;
    ((Control) this.dtExpirationDate).Enabled = false;
    ((Control) this.cboBillingTypes).Enabled = false;
    ((Control) this.cboIssuingOffice).Enabled = false;
    this.lnkConvertQuickQuote.Enabled = false;
    ((Control) this.numExchangeRate).Enabled = false;
    ((ControlBase) this.lblDisabledItems).Text = "Certain items have been disabled because this policy is bound.";
  }

  private void LnkUpdateRetailer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.UpdateRetailer();
    this.ReloadRetailerDropdown();
  }

  private void ReloadRetailerDropdown()
  {
    this.dsQuoteEdit.dtRetailerContacts.Clear();
    this.dsQuoteEdit.dtRetailerContacts.AdddtRetailerContactsRow(string.Empty, Guid.Empty);
    object retailerGuid = (object) DBNull.Value;
    if (!this.dsQuoteEdit.tblQuotes[0].IsRetailerGuidNull())
      retailerGuid = (object) this.dsQuoteEdit.tblQuotes[0].RetailerGuid;
    DefaultDatabase.LoadDataTable((DataTable) this.dsQuoteEdit.dtRetailerContacts, "QuoteEditData_ReloadRetailerContacts", new object[6]
    {
      (object) "@ProducerLocationGuid",
      (object) this.ProducerLocationGuid,
      (object) "@QuoteGuid",
      (object) this.QuoteGuid,
      (object) "@RetailerGuid",
      retailerGuid
    });
  }

  protected virtual void UpdateRetailer()
  {
    using (frmSelection frmSelection = (frmSelection) FormSettings.ShowFormDialog(typeof (frmSelection), new object[1]
    {
      (object) (frmSelection.SelectionTypes) 3
    }))
    {
      if (!frmSelection.ItemSelected)
        return;
      dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
      tblQuote.RetailerGuid = frmSelection.SelectedGuid;
      tblQuote.Retailer = frmSelection.SelectedText;
      ((ControlBase) this.lblRetailer).Text = frmSelection.SelectedText;
    }
  }

  private void LnkRemoveRetailer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    dsQuoteEdit.tblQuotesRow tblQuote = this.dsQuoteEdit.tblQuotes[0];
    tblQuote.SetRetailerGuidNull();
    tblQuote.SetRetailerNull();
    ((ControlBase) this.lblRetailer).Text = string.Empty;
    this.ReloadRetailerDropdown();
  }

  protected virtual void ugPolicyDetail_BeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "ProducerCommission", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "CompanyCommission", false) != 0 || Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.NewValue)))
      return;
    if (e.NewValue != DBNull.Value)
    {
      int num = (int) MessageBox.Show(e.NewValue.ToString() + " is not a valid commission value.", "Invalid Commission", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    ((CancelEventArgs) e).Cancel = true;
  }

  private void CboPolicyType_ValueChanged(object sender, EventArgs e)
  {
    if (!this._readyToShowParticipants || !this.ClientPolicyTypeShowComnPopup || MessageBox.Show("Changing the policy type could affect commission values.\n\nWould you like to re-calculate the default commission values now?", "Recalculate Commissions?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.GetCommissions();
  }

  private void CboUnderwriter_ValueChanged(object sender, EventArgs e)
  {
    this.ProcessUnderwriterChanged(RuntimeHelpers.GetObjectValue(sender));
  }

  protected virtual void ProcessUnderwriterChanged(object sender)
  {
  }

  protected virtual void UnderwritingAssistantChanged(Guid newUnderwritingAssistantGuid)
  {
  }

  private void CheckForChangedProducerContactOnQuote()
  {
    if (this.IsNewQuote || ((UltraCombo) this.cboProducerContact).Value == null || this._currentProducerContactGuid.Equals((Guid) ((UltraCombo) this.cboProducerContact).Value))
      return;
    Messaging.SendBroadcastMessage(BroadcastMessages.ProducerContactChanged, (object) new ProducerContactChangedContext(this._currentProducerContactGuid, (Guid) ((UltraCombo) this.cboProducerContact).Value, new List<Guid>()
    {
      this.QuoteGuid
    }));
  }

  protected virtual void Dispose(bool disposing)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new frmQuoteEdit.DisposeHandler(this.Dispose), (object) disposing);
    }
    else
    {
      if (disposing)
        this.components?.Dispose();
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Form) this).Dispose(disposing));
    }
  }

  Guid IRecreatableEntity.ControlGUID => this._quote.ControlGuid;

  bool IRecreatableEntity.HasControlGUID => !this._isNewQuote && this._quote.HasControlGUID;

  bool IRecreatableEntity.CanReCreateEntity => !this.IsNewQuote;

  Guid IRecreatableEntity.EntityGuid => this._quote.EntityGuid;

  string IRecreatableEntity.EntityName => this._quote.EntityName;

  string IRecreatableEntity.FriendlyEntityName => this._quote.FriendlyEntityName;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT QuoteGuid FROM tblQuotes WHERE ControlGuid=@entityGuid or QuoteGuid = @entityGuid", new object[2]
    {
      (object) "@entityGuid",
      (object) entityGuid.ToString()
    }));
    bool flag;
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
    {
      flag = false;
    }
    else
    {
      this._quoteGuid = (Guid) objectValue;
      this._quote = Quote.FromQuoteGuid(this._quoteGuid);
      this._submissionGroupGuid = this._quote.SubmissionGroupGuid;
      flag = true;
    }
    return flag;
  }

  string IRecreatableEntity.RecreateTypeName
  {
    get => !this.IsNewQuote ? this._quote.RecreateTypeName : string.Empty;
  }

  public bool CanCreateNewNote => !this.IsNewQuote;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged1;

  public bool AllowAddNewDocument => !this.IsNewQuote;

  public Guid EntityQuoteGuid => this._quoteGuid;

  public bool SupportsQuoteContacts => true;

  private void LnkCommentsByLine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Type typeFromString = ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Underwriting.Lines_Risk_Description.FormRiskDescriptionByLines");
    Form form = (Form) null;
    try
    {
      form = (Form) ObjectFactory.Instance.CreateObjectEX(typeFromString, new object[1]
      {
        (object) this.QuoteGuid
      });
      int num = (int) form.ShowDialog();
    }
    finally
    {
      form.Dispose();
    }
  }

  protected virtual void ugPolicyDetail_AfterExitEditMode(object sender, EventArgs e)
  {
    if (this.ugPolicyDetail.ActiveCell == null)
      return;
    bool flag = false;
    UltraGridCell activeCell = this.ugPolicyDetail.ActiveCell;
    if (activeCell.Column.Key.Equals("ProgramID") && this._isBound)
      return;
    this.ugPolicyDetail.AfterExitEditMode -= new EventHandler(this.ugPolicyDetail_AfterExitEditMode);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(activeCell.Column.Key, "ProgramID", false) == 0 && this._programCodeCellChanged)
    {
      if (activeCell.OriginalValue == DBNull.Value & activeCell.Value != null)
        CurrentUser.Instance.LogAction($"Modify Quote: Added ProgramID {activeCell.Value.ToString()} - {activeCell.Text}", this.QuoteGuid);
      else if (activeCell.OriginalValue != null & activeCell.Value != null)
      {
        dsQuoteEdit.tblCompanyProgramCodesRow companyProgramCodesRow = (dsQuoteEdit.tblCompanyProgramCodesRow) this.dsQuoteEdit.tblCompanyProgramCodes.Select("ProgramID=" + activeCell.OriginalValue.ToString())[0];
        if (companyProgramCodesRow != null)
          CurrentUser.Instance.LogAction($"Modify Quote: Changed ProgramID from {companyProgramCodesRow["ProgramID"].ToString()} - {companyProgramCodesRow["ProgCode"].ToString()} to {activeCell.Value.ToString()} - {activeCell.Text}", this.QuoteGuid);
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(activeCell.Column.Key, "ProgramID", false) == 0 && this._programCodeCellChanged && !this._quoteEditIgnoreCommissionsUpdateOnProgramCodeChange && MessageBox.Show("The program code has changed.\n\nWould you like to update commissions on this policy?", "Update Commissions", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      this.GetCommissions();
    try
    {
      if (activeCell.Row.Cells["ProducerCommission"].Value == null || activeCell.Row.Cells["ProducerCommission"].Value == DBNull.Value)
        activeCell.Row.Cells["ProducerCommission"].Value = (object) 0;
      if (activeCell.Row.Cells["CompanyCommission"].Value == null || activeCell.Row.Cells["CompanyCommission"].Value == DBNull.Value)
        activeCell.Row.Cells["CompanyCommission"].Value = (object) 0;
      Decimal d1_1 = (Decimal) activeCell.Row.Cells["CompanyCommission"].Value;
      Decimal d1_2 = (Decimal) activeCell.Row.Cells["ProducerCommission"].Value;
      if (activeCell.Row.DataChanged && Decimal.Compare(d1_1, 1M) >= 0)
      {
        d1_1 = Decimal.Compare(d1_1, 100M) < 0 ? (Decimal.Compare(d1_1, 1M) != 0 ? Decimal.Divide(d1_1, 100M) : 1M) : 1M;
        activeCell.Row.Cells["CompanyCommission"].Value = (object) d1_1;
      }
      if (activeCell.Row.DataChanged & Decimal.Compare(d1_2, 1M) >= 0)
      {
        d1_2 = Decimal.Compare(d1_2, 100M) < 0 ? (Decimal.Compare(d1_2, 1M) != 0 ? Decimal.Divide(d1_2, 100M) : 1M) : 1M;
        activeCell.Row.Cells["ProducerCommission"].Value = (object) d1_2;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(activeCell.Column.Key, "CompanyCommission", false) == 0 && this._companyCommissionCellChanged && ((UltraGridBase) this.ugPolicyDetail).Rows.Count > 1)
      {
        if (MessageBox.Show("Would you like to update the company commission for the other non additive commission lines on this policy?", "Update Company Commission", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          foreach (UltraGridRow row in ((UltraGridBase) this.ugPolicyDetail).Rows)
          {
            if (!Conversions.ToBoolean(row.Cells["UsingAdditiveCommission"].Value))
              row.Cells["CompanyCommission"].Value = (object) d1_1;
          }
        }
        this._companyCommissionCellChanged = false;
      }
      if (!this._producerCommissionCellChanged)
        return;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(activeCell.Column.Key, "ProducerCommission", false) == 0 && ((UltraGridBase) this.ugPolicyDetail).Rows.Count > 1 && MessageBox.Show("Would you like to update the producer commission for the other lines on this policy?", "Update Producer Commission", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        foreach (UltraGridRow row in ((UltraGridBase) this.ugPolicyDetail).Rows)
          row.Cells["ProducerCommission"].Value = (object) d1_2;
        flag = true;
      }
      Cursor.Current = MgaCursors.WaitCursor;
      MDIControls.Instance.StatusBarText = "Calculating additive commission...";
      int integer = Conversions.ToInteger(((UltraCombo) this.cboPolicyType).Value);
      Guid empty1 = Guid.Empty;
      Guid empty2 = Guid.Empty;
      DateTime minValue = DateTime.MinValue;
      if (((UltraDateTimeEditor) this.dtEffectiveDate).Value != null && ((UltraDateTimeEditor) this.dtEffectiveDate).Value != DBNull.Value)
        Conversions.ToDate(Conversions.ToDate(((UltraDateTimeEditor) this.dtEffectiveDate).Value).ToShortDateString());
      if (((UltraCombo) this.cboIssuingOffice).Value != null && ((UltraCombo) this.cboIssuingOffice).Value != DBNull.Value)
      {
        Guid guid = (Guid) ((UltraCombo) this.cboIssuingOffice).Value;
      }
      if (flag)
      {
        foreach (UltraGridRow row in ((UltraGridBase) this.ugPolicyDetail).Rows)
        {
          if (Conversions.ToBoolean(row.Cells["UsingAdditiveCommission"].Value))
          {
            CompanyLine companyLine = new CompanyLine((Guid) row.Cells["CompanyLineGuid"].Value);
            Guid empty3 = Guid.Empty;
            Decimal num = (Decimal) row.Cells["ProducerCommission"].Value;
            if (((UltraCombo) this.comboExpiringCarrier).Value != null)
              empty3 = (Guid) ((UltraCombo) this.comboExpiringCarrier).Value;
            object obj = (object) null;
            if (row.Cells["ProgramID"].Value != null && row.Cells["ProgramID"].Value != DBNull.Value)
              obj = RuntimeHelpers.GetObjectValue(row.Cells["ProgramID"].Value);
            row.Cells["CompanyCommission"].Value = (object) companyLine.GetCommission(this.IsCommissionRenewal, this.ProducerLocationGuid, num, this.EffectiveDate, integer, (SqlTransaction) null, empty3, RuntimeHelpers.GetObjectValue(obj), this.OfficeGuidForProducerLocation);
          }
        }
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(activeCell.Column.Key, "ProducerCommission", false) == 0 && Conversions.ToBoolean(activeCell.Row.Cells["UsingAdditiveCommission"].Value))
      {
        CompanyLine companyLine = new CompanyLine((Guid) activeCell.Row.Cells["CompanyLineGuid"].Value);
        Guid empty4 = Guid.Empty;
        if (((UltraCombo) this.comboExpiringCarrier).Value != null)
          empty4 = (Guid) ((UltraCombo) this.comboExpiringCarrier).Value;
        object obj = (object) null;
        if (activeCell.Row.Cells["ProgramID"].Value != null && activeCell.Row.Cells["ProgramID"].Value != DBNull.Value)
          obj = RuntimeHelpers.GetObjectValue(activeCell.Row.Cells["ProgramID"].Value);
        activeCell.Row.Cells["CompanyCommission"].Value = (object) companyLine.GetCommission(this.IsCommissionRenewal, this.ProducerLocationGuid, d1_2, this.EffectiveDate, integer, (SqlTransaction) null, empty4, RuntimeHelpers.GetObjectValue(obj), this.OfficeGuidForProducerLocation);
      }
      this._producerCommissionCellChanged = false;
      MDIControls.Instance.StatusBarText = string.Empty;
      Cursor.Current = MgaCursors.Default;
    }
    finally
    {
      this.ugPolicyDetail.AfterExitEditMode += new EventHandler(this.ugPolicyDetail_AfterExitEditMode);
    }
  }

  private void UgPolicyDetail_CellChange(object sender, CellEventArgs e)
  {
    this._producerCommissionCellChanged = false;
    this._companyCommissionCellChanged = false;
    this._programCodeCellChanged = false;
    if (e.Cell.Column.Key.Equals("ProducerCommission"))
    {
      this._producerCommissionCellChanged = true;
    }
    else
    {
      if (e.Cell.Column.Key.Equals("CompanyCommission"))
        this._companyCommissionCellChanged = true;
      if (!e.Cell.Column.Key.Equals("ProgramID"))
        return;
      this._programCodeCellChanged = true;
    }
  }

  protected virtual void ClientCellChange(CellEventArgs e)
  {
  }

  private void CboQuotingOffice_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (!this._isMultiCurrencyActive || ((UltraCombo) this.cboQuotingOffice).Value == null || ((UltraCombo) this.cboQuotingOffice).Value == DBNull.Value || ((Guid) ((UltraCombo) this.cboQuotingOffice).Value).Equals(Guid.Empty))
      return;
    this.LoadAuthorizedCurrencies(new Guid(((UltraCombo) this.cboQuotingOffice).Value.ToString()));
  }

  private void LoadAuthorizedCurrencies(Guid officeGuid)
  {
    if (!this._isMultiCurrencyActive)
      return;
    DataTable dt = DefaultDatabase.ExecuteDataTable("spFin_GetAuthorizedCurrencies", new object[2]
    {
      (object) "@OfficeGuid",
      (object) officeGuid
    });
    ((UltraGridBase) this.comboCurrencyCode).DataSource = (object) dt;
    ((UltraDropDownBase) this.comboCurrencyCode).DisplayMember = "CurrencyCode";
    ((UltraDropDownBase) this.comboCurrencyCode).ValueMember = "CurrencyCode";
    if (((UltraGridBase) this.comboCurrencyCode).Rows.Count >= 1)
      ((UltraCombo) this.comboCurrencyCode).Value = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.comboCurrencyCode).Rows[0].Cells["CurrencyCode"].Value);
    else
      ((UltraCombo) this.comboCurrencyCode).Value = (object) "USD";
    ((UltraGridBase) this.cboSettlementCurrency).DataSource = (object) this.SettlementCurrencyDataSource(officeGuid);
    ((UltraDropDownBase) this.cboSettlementCurrency).DisplayMember = "CurrencyCode";
    ((UltraDropDownBase) this.cboSettlementCurrency).ValueMember = "CurrencyCode";
    if (!this.IsNewQuote)
      this.GetQuoteCurrencyCode();
    this.LoadClientCurrencies(dt);
  }

  protected virtual void LoadClientCurrencies(DataTable dt)
  {
  }

  protected virtual void SetStoredProcforClients()
  {
    this._SpNameForClients = "dbo.QuoteEdit_PolicyDetail";
  }

  private void GetQuoteCurrencyCode()
  {
    if (!this._isMultiCurrencyActive || this.Quote == null)
      return;
    int quoteId = this.Quote.QuoteID;
    ((UltraCombo) this.comboCurrencyCode).Value = (object) (this.Quote.CurrencyCode ?? "USD");
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select SettlementCurrencyCode from tblQuotes2 with (nolock) where QuoteID = @QuoteID", new object[2]
    {
      (object) "@QuoteID",
      (object) quoteId
    }));
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
      return;
    ((UltraCombo) this.cboSettlementCurrency).Value = (object) objectValue.ToString();
  }

  private void LblRetailer_MouseHover(object sender, EventArgs e)
  {
    this.tmpToolTip.SetToolTip((Control) this.lblRetailer, ((ControlBase) this.lblRetailer).Text);
  }

  private void CboRiskClass_ValueChanged(object sender, EventArgs e)
  {
    string str = string.Empty;
    if (((UltraCombo) this.cboRiskClass).Value != null && ((UltraCombo) this.cboRiskClass).Value != DBNull.Value)
      str = $"SICCode='{((UltraCombo) this.cboRiskClass).Value.ToString()}'";
    this.dvNAICS.RowFilter = str;
  }

  private void CboNAICSCode_ValueChanged(object sender, EventArgs e)
  {
    string str = string.Empty;
    if (((UltraCombo) this.cboNAICSCode).Value != null && ((UltraCombo) this.cboNAICSCode).Value != DBNull.Value && ((UltraGridBase) this.cboNAICSCode).ActiveRow != null)
      str = $"SIC_Code='{((UltraGridBase) this.cboNAICSCode).ActiveRow.Cells["SICCode"].Value.ToString()}'";
    this.dvSIC.RowFilter = str;
  }

  private void DdProgramCodes_BeforeDropDown(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.ugPolicyDetail).ActiveRow == null || Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugPolicyDetail).ActiveRow.Cells["CompanyLineGuid"].Value)) || Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboIssuingOffice).Value)))
      return;
    DateTime date = Conversions.ToDate(Conversions.ToDate(((UltraDateTimeEditor) this.dtEffectiveDate).Value).ToShortDateString());
    Guid lineGuid = this.GetCompanyLineObject((Guid) ((UltraGridBase) this.ugPolicyDetail).ActiveRow.Cells["CompanyLineGuid"].Value).LineGuid;
    Guid companyLocationGuid = this.GetCompanyLineObject((Guid) ((UltraGridBase) this.ugPolicyDetail).ActiveRow.Cells["CompanyLineGuid"].Value).CompanyLocationGuid;
    string stateId = this.GetCompanyLineObject((Guid) ((UltraGridBase) this.ugPolicyDetail).ActiveRow.Cells["CompanyLineGuid"].Value).StateID;
    foreach (UltraGridRow row in ((UltraGridBase) this.ddProgramCodes).Rows)
      row.Hidden = this.GetQuoteDetailProgramCode(Conversions.ToInteger(row.Cells["ProgramID"].Value), date, stateId, lineGuid, (Guid) ((UltraCombo) this.cboIssuingOffice).Value, companyLocationGuid) == int.MinValue;
  }

  private int GetQuoteDetailProgramCode(
    int tmpProgramID,
    DateTime tmpContEff,
    string tmpStateID,
    Guid tmpLineGuid,
    Guid tmpIssuingOffice,
    Guid tmpCompanyLocationGuid)
  {
    int detailProgramCode = int.MinValue;
    object obj = (object) null;
    Guid empty = Guid.Empty;
    Guid guid;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboLine).Value)))
    {
      guid = (Guid) ((UltraCombo) this.cboLine).Value;
      if (!guid.Equals(tmpLineGuid))
        obj = RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboLine).Value);
    }
    dsQuoteEdit.tblCompanyProgramCodesRow companyProgramCodesRow = (dsQuoteEdit.tblCompanyProgramCodesRow) this.dsQuoteEdit.tblCompanyProgramCodes.Select("ProgramID=" + Conversions.ToString(tmpProgramID))[0];
    if (companyProgramCodesRow.ProgramID == tmpProgramID)
    {
      guid = companyProgramCodesRow.LineGUID;
      if (!guid.Equals(tmpLineGuid))
      {
        guid = companyProgramCodesRow.LineGUID;
        if (!guid.Equals(empty))
          goto label_17;
      }
      if (companyProgramCodesRow.StateID.Equals(tmpStateID) || companyProgramCodesRow.StateID.Equals("&&"))
      {
        guid = companyProgramCodesRow.IssuingOfficeGUID;
        if (!guid.Equals(tmpIssuingOffice))
        {
          guid = companyProgramCodesRow.IssuingOfficeGUID;
          if (!guid.Equals(empty))
            goto label_17;
        }
        guid = companyProgramCodesRow.CompanyLocationGUID;
        if (!guid.Equals(tmpCompanyLocationGuid))
        {
          guid = companyProgramCodesRow.CompanyLocationGUID;
          if (!guid.Equals(empty))
            goto label_17;
        }
        if ((companyProgramCodesRow.IsGroupCodeNull() || companyProgramCodesRow.GroupCode.Equals(this.LineGroupProgramCode(tmpLineGuid)) || companyProgramCodesRow.GroupCode.Equals("&&")) && DateTime.Compare(tmpContEff, companyProgramCodesRow.ContractEffective) >= 0 && DateTime.Compare(tmpContEff, companyProgramCodesRow.ContractExpiration) <= 0)
        {
          if (!companyProgramCodesRow.IsParentLineGUIDNull())
          {
            guid = companyProgramCodesRow.ParentLineGUID;
            if (!guid.Equals(empty))
            {
              if (obj != null)
              {
                guid = companyProgramCodesRow.ParentLineGUID;
                if (!guid.Equals(new Guid(obj.ToString())))
                  goto label_17;
              }
              else
                goto label_17;
            }
          }
          detailProgramCode = companyProgramCodesRow.ProgramID;
        }
      }
    }
label_17:
    return detailProgramCode;
  }

  private void LnkAddCarrier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (frmCompanies formEx = (frmCompanies) ObjectFactory.Instance.CreateFormEX(typeof (frmCompanies), new object[0]))
    {
      formEx.QuoteInformationInvocation = true;
      formEx.QuotingOfficeGuid = ((UltraCombo) this.cboQuotingOffice).Value == null || ((UltraCombo) this.cboQuotingOffice).Value == DBNull.Value ? Guid.Empty : (Guid) ((UltraCombo) this.cboQuotingOffice).Value;
      int num = (int) ((Form) formEx).ShowDialog();
      this.AddExpiringCarriers(formEx.QuoteInvocationLocationGuids);
    }
  }

  private void AddExpiringCarriers(string str)
  {
    if (string.IsNullOrEmpty(str))
      return;
    try
    {
      ((Control) this).Cursor = MgaCursors.WaitCursor;
      string[] strArray1 = str.Split('|');
      int index = 0;
      while (index < strArray1.Length)
      {
        string str1 = strArray1[index];
        if (!string.IsNullOrEmpty(str1))
        {
          string[] strArray2 = str1.Split('^');
          if (this.dsQuoteEdit.ExpiringCarriers.FindByCompanyLocationGuid(new Guid(strArray2[1])) == null)
          {
            dsQuoteEdit.ExpiringCarriersRow row = this.dsQuoteEdit.ExpiringCarriers.NewExpiringCarriersRow();
            row.CompanyLocationGuid = new Guid(strArray2[1]);
            row.LocationName = strArray2[0];
            this.dsQuoteEdit.ExpiringCarriers.Rows.InsertAt((DataRow) row, 0);
          }
        }
        checked { ++index; }
      }
      this.dsQuoteEdit.ExpiringCarriers.AcceptChanges();
      object expiringCarrierObject = frmQuoteEdit._syncLockExpiringCarrierObject;
      ObjectFlowControl.CheckForSyncLockOnValueType(expiringCarrierObject);
      bool lockTaken = false;
      try
      {
        Monitor.Enter(expiringCarrierObject, ref lockTaken);
        frmQuoteEdit._expiringCarrierCache.Clear();
        frmQuoteEdit._expiringCarrierCache.BeginLoadData();
        frmQuoteEdit._expiringCarrierCache.Load((IDataReader) this.dsQuoteEdit.ExpiringCarriers.CreateDataReader());
        frmQuoteEdit._expiringCarrierCache.EndLoadData();
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit(expiringCarrierObject);
      }
    }
    finally
    {
      ((Control) this).Cursor = MgaCursors.Default;
    }
  }

  private void CboRiskClass_AfterCloseUp(object sender, EventArgs e)
  {
    this.RiskClassAfterCloseUp(RuntimeHelpers.GetObjectValue(sender), e);
  }

  protected virtual void RiskClassAfterCloseUp(object sender, EventArgs e)
  {
  }

  private void CboRiskClass_BeforeDropDown(object sender, CancelEventArgs e)
  {
    this.RiskClassBeforeDropDown(RuntimeHelpers.GetObjectValue(sender), e);
  }

  protected virtual void RiskClassBeforeDropDown(object sender, CancelEventArgs e)
  {
  }

  private void CboRiskClass_KeyPress(object sender, KeyPressEventArgs e)
  {
    this.RiskClassKeyPress(RuntimeHelpers.GetObjectValue(sender), e);
  }

  protected virtual void RiskClassKeyPress(object sender, KeyPressEventArgs e)
  {
  }

  private void CreateReplicateQuote()
  {
    if (!this.IsNewQuote || !this.ReplicateQuote || this.ReplicateQuoteGuid.Equals(Guid.Empty))
      return;
    Quote quote = new Quote(this.ReplicateQuoteGuid);
    ((UltraCombo) this.cboQuotingOffice).Value = (object) quote.QuotingLocationGuid;
    ((UltraCombo) this.cboIssuingOffice).Value = (object) quote.IssuingLocationGuid;
    ((UltraCombo) this.cboLine).Value = (object) quote.LineGuid;
    ((UltraCombo) this.cboState).Value = (object) quote.StateID;
    if (!quote.IsQuickQuote)
    {
      ((UltraCombo) this.cboCompanies).Value = (object) quote.CompanyLocationGuid;
      ((UltraCombo) this.cboBillingTypes).Value = (object) quote.BillingTypeID;
    }
    else
      this.IsQuickQuote = true;
    ((UltraCombo) this.cboUnderwriter).Value = (object) quote.UnderwriterUserGuid;
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboUnderwriter).Value)) && this._useCurrentUserAsDefaultUnderwriter && this.dsQuoteEdit.tblUsers.FindByUserGuid(this._currentUserGuid) != null)
      ((UltraCombo) this.cboUnderwriter).Value = (object) this._currentUserGuid;
    ((UltraCombo) this.cboPolicyType).Value = (object) quote.PolicyTypeID;
    ((UltraDateTimeEditor) this.dtEffectiveDate).Value = (object) quote.EffectiveDate;
    ((UltraDateTimeEditor) this.dtExpirationDate).Value = (object) quote.ExpirationDate;
    ((UltraCombo) this.cboProducerContact).Value = (object) quote.ProducerContactGuid;
    ((UltraCombo) this.cboSecProducerContact).Value = (object) quote.SecProducerContactGuid;
    if (quote.HasUnderwriterAssistant)
      ((UltraCombo) this.cboUnderwritingAssistant).Value = (object) quote.UnderwriterAssistant.UserGuid;
    ((UltraCombo) this.cboTA).Value = (object) quote.TACSRUserGuid;
    ((UltraCombo) this.cboRiskClass).Value = string.IsNullOrEmpty(quote.SIC_Code) ? (object) (string) null : (object) quote.SIC_Code;
    ((TextEditorControlBase) this.txtAccountNum).Text = quote.AccountNumber ?? string.Empty;
    if (!quote.IsRetailerNull)
      this.dsQuoteEdit.tblQuotes[0].RetailerGuid = quote.RetailerGuid.Value;
    ((UltraCombo) this.cboFinanceCompany).Value = (object) quote.FinanceCompanyGuid;
    ((UltraCombo) this.cboInspectionCompanies).Value = (object) quote.InspectionCompanyID;
    ((UltraCombo) this.cboNAICSCode).Value = string.IsNullOrEmpty(quote.NAICSCode) ? (object) (string) null : (object) quote.NAICSCode;
    if (this.IsQuickQuote)
      this.ConfigureQuickQuoteAppearance(true);
    this.FillProgramCodeDropDown();
    this.GetCommissions();
  }

  protected virtual bool ClientValidCells(UltraGridCell cell) => false;

  private void FormatExchangeRateDisplay()
  {
    if (SystemSettings.GetSetting<string>("ExchangeRateDisplayInput", (string) null) == null)
      return;
    int int32 = Convert.ToInt32(SystemSettings.GetNumericSetting("ExchangeRateDisplayInput"));
    ((UltraNumericEditor) this.numExchangeRate).MaskInput = "n.";
    int num = int32 - 1;
    for (int index = 0; index <= num; ++index)
    {
      MGANumericEditor numExchangeRate;
      string str = ((UltraNumericEditor) (numExchangeRate = this.numExchangeRate)).MaskInput + "n";
      ((UltraNumericEditor) numExchangeRate).MaskInput = str;
    }
  }

  private void LnkRefreshChildPolicyNumbering_LinkClicked(
    object sender,
    LinkLabelLinkClickedEventArgs e)
  {
    if (this.IsNewQuote)
    {
      int num1 = (int) MessageBox.Show("Save Quote First - Cannot generate child policy #s on new quotes.", "New Quote - No #s To Generate", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      bool flag1 = ((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Bands[0].Columns).Exists("PolicyNumber");
      if (!flag1 && MessageBox.Show("Policy #s are not displayed on detail lines.  Continue?", "Child Policy #s Not Implemented", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      bool flag2 = false;
      List<Guid> guidList = new List<Guid>();
      foreach (UltraGridRow row in ((UltraGridBase) this.ugPolicyDetail).Rows)
      {
        if (row.IsDeleted)
        {
          int num2 = (int) MessageBox.Show("Deleted row(s) present on the grid.", "Refresh Grid - Deleted Rows", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag2 = true;
          break;
        }
        guidList.Add((Guid) row.Cells["CompanyLineGuid"].Value);
      }
      if (flag2)
        return;
      FormChildPolicyNumbersUpdate objectAs = ObjectFactory.Instance.CreateObjectAs<FormChildPolicyNumbersUpdate>(new object[2]
      {
        (object) this.QuoteGuid,
        (object) guidList
      });
      bool hasSaved;
      dsChildPol policyNumberDataset;
      try
      {
        int num3 = (int) objectAs.ShowDialog();
        hasSaved = objectAs.HasSaved;
        policyNumberDataset = objectAs.PolicyNumberDataset;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw;
      }
      if (((!flag1 ? 0 : (hasSaved ? 1 : 0)) & (policyNumberDataset != null ? 1 : 0)) == 0)
        return;
      foreach (UltraGridRow row in ((UltraGridBase) this.ugPolicyDetail).Rows)
      {
        dsChildPol.dtRow byCompanyLineGuid = policyNumberDataset.dt.FindByCompanyLineGuid((Guid) row.Cells["CompanyLineGuid"].Value);
        if (byCompanyLineGuid != null && !byCompanyLineGuid.IsPolicyNumberNull())
          row.Cells["PolicyNumber"].Value = (object) byCompanyLineGuid.PolicyNumber;
      }
    }
  }

  private void UgPolicyDetail_AfterCellUpdate(object sender, CellEventArgs e)
  {
    this.ClientCellChange(e);
  }

  private void LnkOpenExpiring_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(((UltraNumericEditor) this.txtExpiringControlNumber).Value)) & ((UltraNumericEditor) this.txtExpiringControlNumber).Value != DBNull.Value)
    {
      Quote quote = Quote.FromControlNo(Conversions.ToInteger(((UltraNumericEditor) this.txtExpiringControlNumber).Value));
      if (!quote.IsQuickQuote)
      {
        frmPolicyDetail formEx = (frmPolicyDetail) ObjectFactory.Instance.CreateFormEX(typeof (frmPolicyDetail), new object[1]
        {
          ((UltraNumericEditor) this.txtExpiringControlNumber).Value
        });
        ((Form) formEx).StartPosition = FormStartPosition.CenterScreen;
        ((Form) formEx).MdiParent = MDIControls.Instance.MDIParent;
        ((Control) formEx).Show();
      }
      else
      {
        frmQuoteEdit formEx = (frmQuoteEdit) ObjectFactory.Instance.CreateFormEX(typeof (frmQuoteEdit), new object[2]
        {
          (object) quote.QuoteGuid,
          (object) quote.SubmissionGroupGuid
        });
        ((Form) formEx).StartPosition = FormStartPosition.CenterScreen;
        ((Form) formEx).MdiParent = MDIControls.Instance.MDIParent;
        ((Control) formEx).Show();
      }
    }
    else
    {
      int num = (int) Interaction.MsgBox((object) "Expiring Control Number is Invalid", MsgBoxStyle.Critical, (object) "Invalid Expiring ControlNumber.");
    }
  }

  protected virtual void UpdateRenewalSequence()
  {
    if (this._renewalQuoteGuid == null)
      return;
    string str = string.Empty;
    if (((UltraNumericEditor) this.txtExpiringControlNumber).Value != null && ((UltraNumericEditor) this.txtExpiringControlNumber).Value != DBNull.Value)
      str = $"This policy is an IMS renewal of control# {((UltraNumericEditor) this.txtExpiringControlNumber).Value.ToString()}\n\n";
    bool flag = this.AlwaysClearRenewalsPolicyNumberingInfo();
    if (flag || MessageBox.Show($"WARNING: *** The company has changed ***\n\n{str}The IMS renewal link will be broken in order to change the company.\n\nDo you want to keep the renewal / expiring link and Policy # sequence?", "Keep Expiring Policy # Sequence And IMS Renewal Link?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
    {
      DefaultDatabase.ExecuteNonQuery("dbo.spUpdateQuoteRenewalLinkandSequence", new object[4]
      {
        (object) "@quoteGuid",
        (object) this.QuoteGuid,
        (object) "@RS",
        (object) false
      });
      if (!flag)
        CurrentUser.Instance.LogAction("Opted NOT to keep renewal link and policy # sequence on change of company", this.QuoteGuid);
      else
        CurrentUser.Instance.LogAction("System Level Option - Opted NOT to keep renewal link and policy # sequence on change of company", this.QuoteGuid);
      this._keepRenewalSequenceAfterPrompt = false;
    }
    else
    {
      DefaultDatabase.ExecuteNonQuery("dbo.spUpdatePolicyNumberingSequence", new object[4]
      {
        (object) "@quoteID",
        (object) this._quote.QuoteID,
        (object) "@RS",
        (object) true
      });
      CurrentUser.Instance.LogAction("Opted to keep renewal link and policy # sequence on change of company", this.QuoteGuid);
      this._keepRenewalSequenceAfterPrompt = true;
    }
  }

  private void OnCompanyChanged()
  {
    if (!this._onSavingkeepSequenceOnCompanyChange || this.AlreadyPromptOnCompanyChange() || this.dsQuoteEdit.tblQuotes[0].IsCompanyLocationGuidNull() || this.IsNewQuote || this._originalCompanyLocationGuid.Equals(Guid.Empty) || this.Quote.IsQuickQuote || !this.Quote.IsOriginalQuoteRecord || this.Quote.QuoteOptions.Count > 0 || !this.Quote.IsImsRenewal)
      return;
    if (((UltraCombo) this.cboCompanies).Value.Equals((object) this._originalCompanyLocationGuid))
      return;
    try
    {
      this.UpdateRenewalSequence();
    }
    finally
    {
      frmQuoteEdit._promptedForRenewalSequence = (object) true;
    }
  }

  private bool AlreadyPromptOnCompanyChange()
  {
    return !Utility.IsNull(RuntimeHelpers.GetObjectValue(frmQuoteEdit._promptedForRenewalSequence)) && (bool) frmQuoteEdit._promptedForRenewalSequence;
  }

  private void LnkSIC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Type type = typeof (FormSic);
    object[] objArray = new object[1]{ (object) this.dvSIC };
    Form form;
    string selectedSic = ((FormSic) (form = FormSettings.ShowFormDialog(type, objArray))).SelectedSIC;
    form.Dispose();
    if (string.IsNullOrEmpty(selectedSic))
      return;
    if (this.dsQuoteEdit.tblQuotes.Count > 0)
      this.dsQuoteEdit.tblQuotes[0].SIC_Code = selectedSic;
    ((UltraCombo) this.cboRiskClass).Value = (object) selectedSic;
  }

  private bool ValidMaxCompanyCommisison()
  {
    bool flag1;
    if (this._canOverrideMaxCompanyComm)
      flag1 = true;
    else if (!this._validateMaxCompanyCommission)
    {
      flag1 = true;
    }
    else
    {
      bool flag2 = true;
      ProducerLocation producerLocation = new ProducerLocation(this.ProducerLocationGuid);
      foreach (UltraGridRow row in ((UltraGridBase) this.ugPolicyDetail).Rows)
      {
        Guid guid = (Guid) row.Cells["CompanyLineGuid"].Value;
        Decimal d1 = 0M;
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["CompanyCommission"].Value)))
          d1 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row.Cells["CompanyCommission"].Value));
        if (this._isNewQuote || !this._companyCommissionsCache.ContainsKey(guid) || Decimal.Compare(d1, this._companyCommissionsCache[guid]) != 0)
        {
          object obj = (object) null;
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["ProgramID"].Value)))
            obj = RuntimeHelpers.GetObjectValue(row.Cells["ProgramID"].Value);
          Decimal producerCommission = Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["ProducerCommission"].Value)) ? producerLocation.GetCommission(guid, this.IsCommissionRenewal, this.EffectiveDate, (SqlTransaction) null, (object) Conversions.ToInteger(((UltraCombo) this.cboPolicyType).Value), RuntimeHelpers.GetObjectValue(obj), this.OfficeGuidForProducerLocation) : Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row.Cells["ProducerCommission"].Value));
          Decimal companyCommisison = this.GetMaxCompanyCommisison(guid, producerCommission, RuntimeHelpers.GetObjectValue(obj));
          if (Decimal.Compare(d1, companyCommisison) > 0)
          {
            CompanyLine companyLine = new CompanyLine(guid);
            Appearance appearance = row.Cells["CompanyCommission"].Appearance;
            appearance.BackColor = Color.MistyRose;
            appearance.BackColor2 = Color.Red;
            appearance.BackGradientStyle = (GradientStyle) 3;
            flag2 = false;
            try
            {
              this.Tip.SetToolTip((Control) this.ugPolicyDetail, $"The current company commission of {d1:p} must be less than the max of {companyCommisison:p}");
              int num = (int) MessageBox.Show($"'{companyLine.CompanyLineState}' {Environment.NewLine} {Environment.NewLine}Current company commission of {d1:p} must be less than the max of {companyCommisison:p}", "Invalid Company Commission", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (InvalidOperationException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              ProjectData.ClearProjectError();
            }
          }
        }
      }
      flag1 = flag2;
    }
    return flag1;
  }

  private void RefillCompanyCommissions()
  {
    if (!this._validateMaxCompanyCommission)
      return;
    try
    {
      foreach (dsQuoteEdit.tblQuoteDetailsRow row in this.dsQuoteEdit.tblQuoteDetails.Rows)
      {
        if (row.RowState != DataRowState.Deleted)
        {
          if (!this._companyCommissionsCache.ContainsKey(row.CompanyLineGuid))
            this._companyCommissionsCache.Add(row.CompanyLineGuid, !row.IsCompanyCommissionNull() ? row.CompanyCommission : 0M);
          else
            this._companyCommissionsCache[row.CompanyLineGuid] = !row.IsCompanyCommissionNull() ? row.CompanyCommission : 0M;
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

  private void ValidatePolicyNumberOnLineChanged()
  {
    if (this.IsNewQuote || this.IsQuickQuote || Utility.IsNull(RuntimeHelpers.GetObjectValue(this._renewalQuoteGuid)) || Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraNumericEditor) this.txtExpiringControlNumber).Value)) || this._originalLineGuid.Equals(Guid.Empty) || ((UltraCombo) this.cboLine).Value.Equals((object) this._originalLineGuid) || this.dsQuoteEdit.tblQuotes[0].IsLineGuidNull() || this.AlreadyPromptOnCompanyChange() || !this._quote.IsOriginalQuoteRecord)
      return;
    bool flag = this.AlwaysClearRenewalsPolicyNumberingInfo();
    string empty = string.Empty;
    if (flag || MessageBox.Show($"WARNING: *** The Line of business has changed ***\n\n{empty}The IMS renewal link will be broken in order to change the line of business.\n\nDo you want to keep the renewal / expiring link and Policy # sequence?", "Keep Expiring Policy # Sequence And IMS Renewal Link?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
    {
      DefaultDatabase.ExecuteNonQuery("spUpdateQuoteRenewalLinkandSequence", new object[4]
      {
        (object) "@quoteGuid",
        (object) this.QuoteGuid,
        (object) "@RS",
        (object) false
      });
      if (!flag)
        CurrentUser.Instance.LogAction("Opted NOT to keep renewal link and policy # sequence on change of line of business", this.QuoteGuid);
      else
        CurrentUser.Instance.LogAction("System Level Option - Opted NOT to keep renewal link and policy # sequence on change of line of business", this.QuoteGuid);
    }
    else
    {
      DefaultDatabase.ExecuteNonQuery("spUpdatePolicyNumberingSequence", new object[4]
      {
        (object) "@quoteID",
        (object) this._quote.QuoteID,
        (object) "@RS",
        (object) true
      });
      CurrentUser.Instance.LogAction("Opted to keep renewal link and policy # sequence on change of line of business", this.QuoteGuid);
    }
  }

  protected virtual DataTable SettlementCurrencyDataSource(Guid officeGuid)
  {
    return DefaultDatabase.ExecuteDataTable("spFin_GetAuthorizedCurrencies", new object[2]
    {
      (object) "@OfficeGuid",
      (object) officeGuid
    });
  }

  protected virtual bool ValidateChildPolicyNumbers()
  {
    bool flag;
    if (!this._enforceUniqueChildPolicyNumbers)
      flag = true;
    else if (this._isQuickQuote || this._isEndorsement)
      flag = true;
    else if (((UltraGridBase) this.ugPolicyDetail).Rows.Count <= 1)
      flag = true;
    else if (!((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.ugPolicyDetail).DisplayLayout.Bands[0].Columns).Exists("PolicyNumber"))
    {
      flag = true;
    }
    else
    {
      List<string> stringList = new List<string>();
      stringList.Clear();
      foreach (UltraGridRow row in ((UltraGridBase) this.ugPolicyDetail).Rows)
      {
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["PolicyNumber"].Value)) && row.Cells["PolicyNumber"].Value.ToString().Replace(" ", string.Empty).Length != 0)
        {
          bool uniquePolicyNumbers;
          if (this._detailCompanyLine.ContainsKey((Guid) row.Cells["CompanyLineGuid"].Value))
          {
            uniquePolicyNumbers = this._detailCompanyLine[(Guid) row.Cells["CompanyLineGuid"].Value];
          }
          else
          {
            uniquePolicyNumbers = new CompanyLine((Guid) row.Cells["CompanyLineGuid"].Value).EnforceUniquePolicyNumbers;
            this._detailCompanyLine.Add((Guid) row.Cells["CompanyLineGuid"].Value, uniquePolicyNumbers);
          }
          if (uniquePolicyNumbers)
          {
            object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("IsUniqueQuoteDetailPolicyNumber", new object[8]
            {
              (object) "@PolicyNumber",
              row.Cells["PolicyNumber"].Value,
              (object) "@QuoteGuid",
              (object) this._quoteGuid,
              (object) "@CompanyLineGuid",
              row.Cells["CompanyLineGuid"].Value,
              (object) "@IsNewQuote",
              (object) this.IsNewQuote
            }));
            if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) || stringList.Contains(row.Cells["PolicyNumber"].Value.ToString()))
            {
              CompanyLine companyLine = new CompanyLine((Guid) row.Cells["CompanyLineGuid"].Value);
              if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
              {
                if (MessageBox.Show($"{companyLine.CompanyLocation.LocationName}{Environment.NewLine}Policy # {row.Cells["PolicyNumber"].Value} is already in use on control # {objectValue}{Environment.NewLine}{Environment.NewLine}" + "Are you sure you want to use this duplicate policy #?", "Duplicate Detail Policy #", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                  if (!this.IsNewQuote)
                    CurrentUser.Instance.LogAction($"User opted to use duplicate child policy #.{companyLine.CompanyLocation.LocationName}Policy # {RuntimeHelpers.GetObjectValue(row.Cells["PolicyNumber"].Value)} in use on control # {RuntimeHelpers.GetObjectValue(objectValue)}", this._quoteGuid);
                  else
                    CurrentUser.Instance.LogAction($"User opted to use duplicate child policy #.{companyLine.CompanyLocation.LocationName}Policy # {RuntimeHelpers.GetObjectValue(row.Cells["PolicyNumber"].Value)} in use on control # {RuntimeHelpers.GetObjectValue(objectValue)}");
                }
                else
                {
                  flag = false;
                  goto label_30;
                }
              }
              if (stringList.Contains(row.Cells["PolicyNumber"].Value.ToString()))
              {
                if (MessageBox.Show($"Child detail policy # {RuntimeHelpers.GetObjectValue(row.Cells["PolicyNumber"].Value)} is already in use on this policy. {Environment.NewLine}{Environment.NewLine}" + "Are you sure you want to use this duplicate policy #?", "Duplicate Detail Policy #", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                  if (!this.IsNewQuote)
                    CurrentUser.Instance.LogAction($"User opted to use duplicate child policy # on this policy.{companyLine.CompanyLocation.LocationName} Policy # {RuntimeHelpers.GetObjectValue(row.Cells["PolicyNumber"].Value)}", this._quoteGuid);
                  else
                    CurrentUser.Instance.LogAction($"User opted to use duplicate child policy # on this policy.{companyLine.CompanyLocation.LocationName} Policy # {RuntimeHelpers.GetObjectValue(row.Cells["PolicyNumber"].Value)}");
                }
                else
                {
                  flag = false;
                  goto label_30;
                }
              }
            }
          }
          stringList.Add(row.Cells["PolicyNumber"].Value.ToString());
        }
      }
      flag = true;
    }
label_30:
    return flag;
  }

  private Decimal GetMaxCompanyCommisison(
    Guid tmpCompanyLineGuid,
    Decimal producerCommission,
    object tmpProgramCodeID)
  {
    Guid empty = Guid.Empty;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraCombo) this.comboExpiringCarrier).Value)))
      empty = (Guid) ((UltraCombo) this.comboExpiringCarrier).Value;
    Dictionary<string, DbParameter> dictionary = DefaultDatabase.DiscoverParameters("dbo.spGetMaximumCompanyCommission");
    dictionary["@ProducerLocationGuid"].Value = (object) this.ProducerLocationGuid;
    dictionary["@CompanyLineGuid"].Value = (object) tmpCompanyLineGuid;
    dictionary["@Renewal"].Value = (object) this.IsCommissionRenewal;
    dictionary["@QuoteEffectiveDate"].Value = (object) this.EffectiveDate;
    dictionary["@ProducerCommIn"].Value = (object) producerCommission;
    dictionary["@PolicyTypeID"].Value = (object) Conversions.ToInteger(((UltraCombo) this.cboPolicyType).Value);
    dictionary["@ProgramID"].Value = RuntimeHelpers.GetObjectValue(tmpProgramCodeID);
    if (!this.QuotingOfficeGuid.Equals(Guid.Empty))
      dictionary["@QuotingOfficeGuid"].Value = (object) this.QuotingOfficeGuid;
    if (!empty.Equals(Guid.Empty))
      dictionary["@expiringCompanyLocationGuid"].Value = (object) empty;
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spGetMaximumCompanyCommission", 180, (CommandArgumentType) 2, new object[1]
    {
      (object) dictionary
    });
    DbParameter dbParameter = dictionary["@Commission"];
    return Utility.IsNull(RuntimeHelpers.GetObjectValue(dbParameter.Value)) ? 0M : Conversions.ToDecimal(dbParameter.Value);
  }

  protected virtual void LockDownCarrier()
  {
    if (!((Control) this.cboCompanies).Enabled || !this._isBound)
      return;
    ((Control) this.cboCompanies).Enabled = false;
  }

  private bool AreObjectsEqual(object A, object B)
  {
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(A)))
      empty1 = A.ToString();
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(B)))
      empty2 = B.ToString();
    return empty1.Equals(empty2);
  }

  protected virtual void OptionsRemove()
  {
  }

  public delegate void DataLoadCompletedEventHandler();

  private struct QuoteStructure
  {
    public string ColumnName;
    public string OrigValue;
    public string CurrValue;
    public char EntityType;
  }

  public delegate void DisposeHandler(bool disposing);

  private class CostCenterNotFoundException : ApplicationException
  {
    public override string Message
    {
      get => "No system-defined cost center was found for this quoting office.";
    }
  }
}

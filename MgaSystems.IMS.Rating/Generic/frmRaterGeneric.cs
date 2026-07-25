// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.Generic.frmRaterGeneric
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Mga.Wpf.Ims.Interop;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Policies.Rating.Endorsements;
using MGASystems.IMS.Policies.Rating.ExposureCapture;
using MGASystems.IMS.Policies.Rating.Locations;
using MGASystems.InfragisticsExtensions.Editors;
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
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating.Generic;

[DocumentFolderFilter("Generic Rater")]
public class frmRaterGeneric : 
  frmRaterBase,
  ISupportNoteSystem,
  ISupportDocumentSystem,
  ITransactionLogFilter
{
  private IContainer components;
  private ErrorProvider err;
  private dsRaterGeneric ds;
  private SqlDataAdapter daOptions;
  private Label Label1;
  private MGASimpleComboBox cboState;
  private Label Label2;
  private Label Label3;
  private MGATextBox txtAmount;
  private Label Label4;
  private UltraDropDown ddChargeCodes;
  private UltraDropDown ddOffices;
  private DataView dvChargeCodes;
  private DataView dvOffices;
  private SqlCommand cmdOfficeLines;
  private Label Label5;
  private Label Label6;
  private SqlDataAdapter daOptionsGeneric;
  private Label Label7;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private Label Label8;
  private MGAListBox listExposureLines;
  private SqlCommand SqlSelectCommand2;
  private SqlCommand SqlInsertCommand2;
  private SqlCommand SqlUpdateCommand2;
  private SqlCommand SqlDeleteCommand2;
  private RichTextBox txtPerils;
  private UltraGroupBox UltraGroupBox1;
  private UltraGroupBox UltraGroupBox2;
  private UltraGroupBox UltraGroupBox3;
  private RichTextBox txtValuation;
  private RichTextBox txtCovering;
  private UltraGroupBox UltraGroupBox4;
  private RichTextBox txtExcluding;
  private UltraGroupBox UltraGroupBox5;
  private RichTextBox txtAdditionalComments;
  private UltraGroupBox UltraGroupBox6;
  private RichTextBox txtLimit;
  private UltraGroupBox UltraGroupBox7;
  private RichTextBox txtDeductible;
  private UltraGroupBox UltraGroupBox8;
  private RichTextBox txtSubLimits;
  private Label Label9;
  private MGASimpleComboBox cboCompanies;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private SqlDataAdapter daGenericLimits;
  private SqlCommand SqlSelectCommand3;
  private SqlCommand SqlInsertCommand3;
  private SqlCommand SqlUpdateCommand3;
  private SqlCommand SqlDeleteCommand3;
  private string _lineName;
  private Quote _quote;
  private HyperlinkEditor _hlkAddComments;
  private Decimal _factor;
  private frmPremiumAllocation _frmPremiumAllocation;
  private bool _limitsDataChanged;
  private MemoryStream _gridLayout;
  private bool _isEndorsement;
  private bool _isQuoteBound;
  private bool _notRoundingPremiumToDollar;
  private int _quotingOfficeID;
  private bool _roundProRataFactor;
  private bool _hasPremiumDistribution;
  private bool _enableGenericPremiumDistribution;
  private QuoteStatus _quoteStatus;

  protected virtual UltraGrid dgOptions
  {
    get => this._dgOptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.dgOptions_InitializeRow);
      EventHandler eventHandler = new EventHandler(this.dgOptions_AfterRowActivate);
      UltraGrid dgOptions1 = this._dgOptions;
      if (dgOptions1 != null)
      {
        dgOptions1.InitializeRow -= initializeRowEventHandler;
        dgOptions1.AfterRowActivate -= eventHandler;
      }
      this._dgOptions = value;
      UltraGrid dgOptions2 = this._dgOptions;
      if (dgOptions2 == null)
        return;
      dgOptions2.InitializeRow += initializeRowEventHandler;
      dgOptions2.AfterRowActivate += eventHandler;
    }
  }

  private virtual SqlConnection cnSQL
  {
    get => this._cnSQL;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      SqlInfoMessageEventHandler messageEventHandler = new SqlInfoMessageEventHandler(this.cnSQL_InfoMessage);
      SqlConnection cnSql1 = this._cnSQL;
      if (cnSql1 != null)
        cnSql1.InfoMessage -= messageEventHandler;
      this._cnSQL = value;
      SqlConnection cnSql2 = this._cnSQL;
      if (cnSql2 == null)
        return;
      cnSql2.InfoMessage += messageEventHandler;
    }
  }

  private virtual MGASimpleComboBox cboChargeCodes
  {
    get => this._cboChargeCodes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboChargeCodes_SelectedIndexChanged);
      MGASimpleComboBox cboChargeCodes1 = this._cboChargeCodes;
      if (cboChargeCodes1 != null)
        cboChargeCodes1.ValueChanged -= eventHandler;
      this._cboChargeCodes = value;
      MGASimpleComboBox cboChargeCodes2 = this._cboChargeCodes;
      if (cboChargeCodes2 == null)
        return;
      cboChargeCodes2.ValueChanged += eventHandler;
    }
  }

  private virtual MGASimpleComboBox cboOffices
  {
    get => this._cboOffices;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboOffices_SelectedIndexChanged);
      MGASimpleComboBox cboOffices1 = this._cboOffices;
      if (cboOffices1 != null)
        cboOffices1.ValueChanged -= eventHandler;
      this._cboOffices = value;
      MGASimpleComboBox cboOffices2 = this._cboOffices;
      if (cboOffices2 == null)
        return;
      cboOffices2.ValueChanged += eventHandler;
    }
  }

  private virtual MGADateTimePicker dtEffective
  {
    get => this._dtEffective;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dtEffective_ValueChanged);
      MGADateTimePicker dtEffective1 = this._dtEffective;
      if (dtEffective1 != null)
        dtEffective1.ValueChanged -= eventHandler;
      this._dtEffective = value;
      MGADateTimePicker dtEffective2 = this._dtEffective;
      if (dtEffective2 == null)
        return;
      dtEffective2.ValueChanged += eventHandler;
    }
  }

  private virtual MGANumericEditor txtFactor
  {
    get => this._txtFactor;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtFactor_ValueChanged);
      MGANumericEditor txtFactor1 = this._txtFactor;
      if (txtFactor1 != null)
        ((UltraNumericEditorBase) txtFactor1).ValueChanged -= eventHandler;
      this._txtFactor = value;
      MGANumericEditor txtFactor2 = this._txtFactor;
      if (txtFactor2 == null)
        return;
      ((UltraNumericEditorBase) txtFactor2).ValueChanged += eventHandler;
    }
  }

  private virtual RadioButton rbProRata
  {
    get => this._rbProRata;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CalcType_CheckedChanged);
      RadioButton rbProRata1 = this._rbProRata;
      if (rbProRata1 != null)
        rbProRata1.CheckedChanged -= eventHandler;
      this._rbProRata = value;
      RadioButton rbProRata2 = this._rbProRata;
      if (rbProRata2 == null)
        return;
      rbProRata2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbFlat
  {
    get => this._rbFlat;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CalcType_CheckedChanged);
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

  private virtual RadioButton rbShortRate
  {
    get => this._rbShortRate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CalcType_CheckedChanged);
      RadioButton rbShortRate1 = this._rbShortRate;
      if (rbShortRate1 != null)
        rbShortRate1.CheckedChanged -= eventHandler;
      this._rbShortRate = value;
      RadioButton rbShortRate2 = this._rbShortRate;
      if (rbShortRate2 == null)
        return;
      rbShortRate2.CheckedChanged += eventHandler;
    }
  }

  protected virtual UltraTabControl MgaTab1
  {
    get => this._MgaTab1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      SelectedTabChangedEventHandler changedEventHandler = new SelectedTabChangedEventHandler(this.MgaTab1_SelectedTabChanged);
      UltraTabControl mgaTab1_1 = this._MgaTab1;
      if (mgaTab1_1 != null)
        ((UltraTabControlBase) mgaTab1_1).SelectedTabChanged -= changedEventHandler;
      this._MgaTab1 = value;
      UltraTabControl mgaTab1_2 = this._MgaTab1;
      if (mgaTab1_2 == null)
        return;
      ((UltraTabControlBase) mgaTab1_2).SelectedTabChanged += changedEventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  protected virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  protected virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl3")]
  protected virtual UltraTabPageControl UltraTabPageControl3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl4")]
  protected virtual UltraTabPageControl UltraTabPageControl4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl5")]
  protected virtual UltraTabPageControl UltraTabPageControl5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabExposure")]
  protected virtual UltraTabPageControl tabExposure { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnExposure
  {
    get => this._btnExposure;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnExposure_Click);
      MGAButton btnExposure1 = this._btnExposure;
      if (btnExposure1 != null)
        ((Control) btnExposure1).Click -= eventHandler;
      this._btnExposure = value;
      MGAButton btnExposure2 = this._btnExposure;
      if (btnExposure2 == null)
        return;
      ((Control) btnExposure2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabPageControl6")]
  protected virtual UltraTabPageControl UltraTabPageControl6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkFCW
  {
    get => this._lnkFCW;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkFCW_LinkClicked);
      LinkLabel lnkFcw1 = this._lnkFCW;
      if (lnkFcw1 != null)
        lnkFcw1.LinkClicked -= clickedEventHandler;
      this._lnkFCW = value;
      LinkLabel lnkFcw2 = this._lnkFCW;
      if (lnkFcw2 == null)
        return;
      lnkFcw2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler1 = new EventHandler(this.dbSave_UIStateChanged);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedCancel);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_ClickedSave);
      EventHandler eventHandler4 = new EventHandler(this.dbSave_ClickedNew);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingSave -= cancelEventHandler1;
        dbSave1.ClickingNew -= cancelEventHandler2;
        dbSave1.ClickingDelete -= cancelEventHandler3;
        dbSave1.UIStateChanged -= eventHandler1;
        dbSave1.ClickedCancel -= eventHandler2;
        dbSave1.ClickedSave -= eventHandler3;
        dbSave1.ClickedNew -= eventHandler4;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingSave += cancelEventHandler1;
      dbSave2.ClickingNew += cancelEventHandler2;
      dbSave2.ClickingDelete += cancelEventHandler3;
      dbSave2.UIStateChanged += eventHandler1;
      dbSave2.ClickedCancel += eventHandler2;
      dbSave2.ClickedSave += eventHandler3;
      dbSave2.ClickedNew += eventHandler4;
    }
  }

  [field: AccessedThroughProperty("UltraTabPageControl7")]
  protected virtual UltraTabPageControl UltraTabPageControl7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl8")]
  protected virtual UltraTabPageControl UltraTabPageControl8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl9")]
  protected virtual UltraTabPageControl UltraTabPageControl9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkNewOption
  {
    get => this._lnkNewOption;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkNewOption_LinkClicked);
      LinkLabel lnkNewOption1 = this._lnkNewOption;
      if (lnkNewOption1 != null)
        lnkNewOption1.LinkClicked -= clickedEventHandler;
      this._lnkNewOption = value;
      LinkLabel lnkNewOption2 = this._lnkNewOption;
      if (lnkNewOption2 == null)
        return;
      lnkNewOption2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("panelLoading")]
  internal virtual UltraGroupBox panelLoading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelLoadText")]
  internal virtual Label panelLoadText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel linkOffsetTransaction
  {
    get => this._linkOffsetTransaction;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkOffsetTransaction_LinkClicked);
      LinkLabel offsetTransaction1 = this._linkOffsetTransaction;
      if (offsetTransaction1 != null)
        offsetTransaction1.LinkClicked -= clickedEventHandler;
      this._linkOffsetTransaction = value;
      LinkLabel offsetTransaction2 = this._linkOffsetTransaction;
      if (offsetTransaction2 == null)
        return;
      offsetTransaction2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("checkRoundPremiums")]
  internal virtual MGACheckBox checkRoundPremiums { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel linkEndorsementOffsets
  {
    get => this._linkEndorsementOffsets;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkEndorsementOffsets_LinkClicked);
      LinkLabel endorsementOffsets1 = this._linkEndorsementOffsets;
      if (endorsementOffsets1 != null)
        endorsementOffsets1.LinkClicked -= clickedEventHandler;
      this._linkEndorsementOffsets = value;
      LinkLabel endorsementOffsets2 = this._linkEndorsementOffsets;
      if (endorsementOffsets2 == null)
        return;
      endorsementOffsets2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label11")]
  private virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCurrentAnnualPremium")]
  protected virtual MGATextBox txtCurrentAnnualPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkPremiumUI
  {
    get => this._lnkPremiumUI;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPremiumUI_LinkClicked);
      LinkLabel lnkPremiumUi1 = this._lnkPremiumUI;
      if (lnkPremiumUi1 != null)
        lnkPremiumUi1.LinkClicked -= clickedEventHandler;
      this._lnkPremiumUI = value;
      LinkLabel lnkPremiumUi2 = this._lnkPremiumUI;
      if (lnkPremiumUi2 == null)
        return;
      lnkPremiumUi2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkCancellation
  {
    get => this._lnkCancellation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCancellation_LinkClicked);
      LinkLabel lnkCancellation1 = this._lnkCancellation;
      if (lnkCancellation1 != null)
        lnkCancellation1.LinkClicked -= clickedEventHandler;
      this._lnkCancellation = value;
      LinkLabel lnkCancellation2 = this._lnkCancellation;
      if (lnkCancellation2 == null)
        return;
      lnkCancellation2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkViewUnderwritingLocations
  {
    get => this._lnkViewUnderwritingLocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkViewUnderwritingLocations_LinkClicked);
      LinkLabel underwritingLocations1 = this._lnkViewUnderwritingLocations;
      if (underwritingLocations1 != null)
        underwritingLocations1.LinkClicked -= clickedEventHandler;
      this._lnkViewUnderwritingLocations = value;
      LinkLabel underwritingLocations2 = this._lnkViewUnderwritingLocations;
      if (underwritingLocations2 == null)
        return;
      underwritingLocations2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtPolicyLimit")]
  protected virtual MGANumericEditor txtPolicyLimit { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  private virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkIncludeLeapYear")]
  internal virtual MGACheckBox chkIncludeLeapYear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkPremiumAllocation
  {
    get => this._lnkPremiumAllocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPremiumAllocation_LinkClicked);
      LinkLabel premiumAllocation1 = this._lnkPremiumAllocation;
      if (premiumAllocation1 != null)
        premiumAllocation1.LinkClicked -= clickedEventHandler;
      this._lnkPremiumAllocation = value;
      LinkLabel premiumAllocation2 = this._lnkPremiumAllocation;
      if (premiumAllocation2 == null)
        return;
      premiumAllocation2.LinkClicked += clickedEventHandler;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmRaterGeneric));
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    UltraTab ultraTab3 = new UltraTab();
    UltraTab ultraTab4 = new UltraTab();
    UltraTab ultraTab5 = new UltraTab();
    UltraTab ultraTab6 = new UltraTab();
    UltraTab ultraTab7 = new UltraTab();
    UltraTab ultraTab8 = new UltraTab();
    UltraTab ultraTab9 = new UltraTab();
    UltraTab ultraTab10 = new UltraTab();
    Appearance appearance18 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblClientOffices", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("tblClientOfficestblQuoteOptionGeneric");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblClientOfficestblQuoteOptionGeneric", 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("GenericID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("PriorGenericID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("QuoteOptionGUID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Factor");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("UserOverrideFactor");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Premium");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Added");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("EndorsementCalcType");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("RoundToDollar");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("CurrentAnnualPremium");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("IncludeLeapYear");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblFin_PolicyCharges", -1);
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("ChargeID");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("tblFin_PolicyChargestblQuoteOptionGeneric");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblFin_PolicyChargestblQuoteOptionGeneric", 0);
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("GenericID");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("PriorGenericID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("QuoteOptionGUID");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("Factor");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("UserOverrideFactor");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("Premium");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("Added");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("EndorsementCalcType");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("RoundToDollar");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("CurrentAnnualPremium");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("IncludeLeapYear");
    Appearance appearance19 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("tblQuoteOptions", -1);
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("QuoteOptionID");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("QuoteOptionGUID");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("QuoteGUID");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("Premium");
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("DateCreated");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("AdditionalComments");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("AddComments");
    Appearance appearance22 = new Appearance();
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("CompanyLocationID");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("CompanyLocation");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("tblQuoteOptionstblQuoteOptionGeneric");
    UltraGridBand ultraGridBand6 = new UltraGridBand("tblQuoteOptionstblQuoteOptionGeneric", 0);
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("GenericID");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("PriorGenericID");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("QuoteOptionGUID");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("Factor");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("UserOverrideFactor");
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("ChargeCode", -1, (object) "ddChargeCodes");
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("OfficeID", -1, (object) "ddOffices");
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("Premium");
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("Added");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("StateID");
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("EndorsementCalcType");
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("RoundToDollar");
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("CurrentAnnualPremium");
    Appearance appearance31 = new Appearance();
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("IncludeLeapYear");
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.chkIncludeLeapYear = new MGACheckBox();
    this.lnkViewUnderwritingLocations = new LinkLabel();
    this.lnkCancellation = new LinkLabel();
    this.lnkPremiumUI = new LinkLabel();
    this.Label11 = new Label();
    this.txtCurrentAnnualPremium = new MGATextBox();
    this.linkEndorsementOffsets = new LinkLabel();
    this.checkRoundPremiums = new MGACheckBox();
    this.linkOffsetTransaction = new LinkLabel();
    this.lnkNewOption = new LinkLabel();
    this.Label9 = new Label();
    this.cboCompanies = new MGASimpleComboBox();
    this.lnkFCW = new LinkLabel();
    this.Label2 = new Label();
    this.cboChargeCodes = new MGASimpleComboBox();
    this.txtAmount = new MGATextBox();
    this.rbProRata = new RadioButton();
    this.Label1 = new Label();
    this.rbFlat = new RadioButton();
    this.rbShortRate = new RadioButton();
    this.Label6 = new Label();
    this.cboOffices = new MGASimpleComboBox();
    this.Label5 = new Label();
    this.txtFactor = new MGANumericEditor();
    this.Label3 = new Label();
    this.Label7 = new Label();
    this.Label4 = new Label();
    this.dtEffective = new MGADateTimePicker();
    this.cboState = new MGASimpleComboBox();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.UltraTabPageControl7 = new UltraTabPageControl();
    this.Label10 = new Label();
    this.txtPolicyLimit = new MGANumericEditor();
    this.UltraGroupBox6 = new UltraGroupBox();
    this.txtLimit = new RichTextBox();
    this.UltraTabPageControl9 = new UltraTabPageControl();
    this.UltraGroupBox8 = new UltraGroupBox();
    this.txtSubLimits = new RichTextBox();
    this.UltraTabPageControl8 = new UltraTabPageControl();
    this.UltraGroupBox7 = new UltraGroupBox();
    this.txtDeductible = new RichTextBox();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.UltraGroupBox1 = new UltraGroupBox();
    this.txtPerils = new RichTextBox();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.UltraGroupBox2 = new UltraGroupBox();
    this.txtCovering = new RichTextBox();
    this.UltraTabPageControl4 = new UltraTabPageControl();
    this.UltraGroupBox3 = new UltraGroupBox();
    this.txtValuation = new RichTextBox();
    this.UltraTabPageControl5 = new UltraTabPageControl();
    this.UltraGroupBox4 = new UltraGroupBox();
    this.txtExcluding = new RichTextBox();
    this.UltraTabPageControl6 = new UltraTabPageControl();
    this.UltraGroupBox5 = new UltraGroupBox();
    this.txtAdditionalComments = new RichTextBox();
    this.tabExposure = new UltraTabPageControl();
    this.lnkPremiumAllocation = new LinkLabel();
    this.btnExposure = new MGAButton();
    this.listExposureLines = new MGAListBox();
    this.Label8 = new Label();
    this.daOptions = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.err = new ErrorProvider(this.components);
    this.cmdOfficeLines = new SqlCommand();
    this.daOptionsGeneric = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    this.MgaTab1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.daGenericLimits = new SqlDataAdapter();
    this.SqlDeleteCommand3 = new SqlCommand();
    this.SqlInsertCommand3 = new SqlCommand();
    this.SqlSelectCommand3 = new SqlCommand();
    this.SqlUpdateCommand3 = new SqlCommand();
    this.panelLoading = new UltraGroupBox();
    this.panelLoadText = new Label();
    this.PictureBox1 = new PictureBox();
    this.ddOffices = new UltraDropDown();
    this.ds = new dsRaterGeneric();
    this.ddChargeCodes = new UltraDropDown();
    this.dgOptions = new UltraGrid();
    this.dvChargeCodes = new DataView();
    this.dvOffices = new DataView();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.chkIncludeLeapYear).BeginInit();
    ((ISupportInitialize) this.txtCurrentAnnualPremium).BeginInit();
    ((ISupportInitialize) this.checkRoundPremiums).BeginInit();
    ((ISupportInitialize) this.cboCompanies).BeginInit();
    ((ISupportInitialize) this.cboChargeCodes).BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.cboOffices).BeginInit();
    ((ISupportInitialize) this.txtFactor).BeginInit();
    ((ISupportInitialize) this.dtEffective).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((Control) this.UltraTabPageControl7).SuspendLayout();
    ((ISupportInitialize) this.txtPolicyLimit).BeginInit();
    ((ISupportInitialize) this.UltraGroupBox6).BeginInit();
    ((Control) this.UltraGroupBox6).SuspendLayout();
    ((Control) this.UltraTabPageControl9).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox8).BeginInit();
    ((Control) this.UltraGroupBox8).SuspendLayout();
    ((Control) this.UltraTabPageControl8).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox7).BeginInit();
    ((Control) this.UltraGroupBox7).SuspendLayout();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox2).BeginInit();
    ((Control) this.UltraGroupBox2).SuspendLayout();
    ((Control) this.UltraTabPageControl4).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox3).BeginInit();
    ((Control) this.UltraGroupBox3).SuspendLayout();
    ((Control) this.UltraTabPageControl5).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox4).BeginInit();
    ((Control) this.UltraGroupBox4).SuspendLayout();
    ((Control) this.UltraTabPageControl6).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox5).BeginInit();
    ((Control) this.UltraGroupBox5).SuspendLayout();
    ((Control) this.tabExposure).SuspendLayout();
    ((ISupportInitialize) this.btnExposure).BeginInit();
    ((ISupportInitialize) this.listExposureLines).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.MgaTab1).BeginInit();
    ((Control) this.MgaTab1).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.panelLoading).BeginInit();
    ((Control) this.panelLoading).SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.ddOffices).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddChargeCodes).BeginInit();
    ((ISupportInitialize) this.dgOptions).BeginInit();
    this.dvChargeCodes.BeginInit();
    this.dvOffices.BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkIncludeLeapYear);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkViewUnderwritingLocations);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkCancellation);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkPremiumUI);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label11);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtCurrentAnnualPremium);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.linkEndorsementOffsets);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.checkRoundPremiums);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.linkOffsetTransaction);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkNewOption);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label9);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboCompanies);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkFCW);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboChargeCodes);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtAmount);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.rbProRata);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.rbFlat);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.rbShortRate);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label6);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboOffices);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label5);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtFactor);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label7);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dtEffective);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboState);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(763, 248);
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkIncludeLeapYear).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.chkIncludeLeapYear).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkIncludeLeapYear).Location = new Point(450, 17);
    ((Control) this.chkIncludeLeapYear).Name = "chkIncludeLeapYear";
    ((Control) this.chkIncludeLeapYear).Size = new Size(120, 20);
    ((Control) this.chkIncludeLeapYear).TabIndex = 30;
    ((UltraToggleEditorBase) this.chkIncludeLeapYear).Text = "Include Leap Year";
    this.lnkViewUnderwritingLocations.AutoSize = true;
    this.lnkViewUnderwritingLocations.BackColor = Color.Transparent;
    this.lnkViewUnderwritingLocations.Location = new Point(314, 225);
    this.lnkViewUnderwritingLocations.Name = "lnkViewUnderwritingLocations";
    this.lnkViewUnderwritingLocations.Size = new Size(141, 13);
    this.lnkViewUnderwritingLocations.TabIndex = 29;
    this.lnkViewUnderwritingLocations.TabStop = true;
    this.lnkViewUnderwritingLocations.Text = "View Underwriting Locations";
    this.lnkCancellation.AutoSize = true;
    this.lnkCancellation.BackColor = Color.Transparent;
    this.lnkCancellation.Location = new Point(573, 100);
    this.lnkCancellation.Name = "lnkCancellation";
    this.lnkCancellation.Size = new Size(172, 13);
    this.lnkCancellation.TabIndex = 28;
    this.lnkCancellation.TabStop = true;
    this.lnkCancellation.Text = "Cancellation - Premium Distribution";
    this.lnkPremiumUI.AutoSize = true;
    this.lnkPremiumUI.BackColor = Color.Transparent;
    this.lnkPremiumUI.Location = new Point(684, 125);
    this.lnkPremiumUI.Name = "lnkPremiumUI";
    this.lnkPremiumUI.Size = new Size(61, 13);
    this.lnkPremiumUI.TabIndex = 27;
    this.lnkPremiumUI.TabStop = true;
    this.lnkPremiumUI.Text = "Premium UI";
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(226, 196);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size((int) sbyte.MaxValue, 13);
    this.Label11.TabIndex = 26;
    this.Label11.Text = "Current Annual Premium:";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCurrentAnnualPremium).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtCurrentAnnualPremium).BackColor = Color.White;
    ((Control) this.txtCurrentAnnualPremium).Location = new Point(359, 192 /*0xC0*/);
    this.txtCurrentAnnualPremium.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCurrentAnnualPremium).Name = "txtCurrentAnnualPremium";
    ((Control) this.txtCurrentAnnualPremium).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.txtCurrentAnnualPremium).TabIndex = 25;
    ((UltraControlBase) this.txtCurrentAnnualPremium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCurrentAnnualPremium).UseOsThemes = (DefaultableBoolean) 2;
    this.linkEndorsementOffsets.AutoSize = true;
    this.linkEndorsementOffsets.Location = new Point(636, 73);
    this.linkEndorsementOffsets.Name = "linkEndorsementOffsets";
    this.linkEndorsementOffsets.Size = new Size(109, 13);
    this.linkEndorsementOffsets.TabIndex = 24;
    this.linkEndorsementOffsets.TabStop = true;
    this.linkEndorsementOffsets.Text = "Endorsement Offsets";
    this.linkEndorsementOffsets.TextAlign = ContentAlignment.MiddleLeft;
    appearance3.BorderColor = Color.Gray;
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkRoundPremiums).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.checkRoundPremiums).Checked = true;
    ((UltraToggleEditorBase) this.checkRoundPremiums).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.checkRoundPremiums).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkRoundPremiums).Location = new Point(335, 17);
    ((Control) this.checkRoundPremiums).Name = "checkRoundPremiums";
    ((Control) this.checkRoundPremiums).Size = new Size(120, 20);
    ((Control) this.checkRoundPremiums).TabIndex = 23;
    ((UltraToggleEditorBase) this.checkRoundPremiums).Text = "Round To Dollar";
    this.linkOffsetTransaction.AutoSize = true;
    this.linkOffsetTransaction.Location = new Point(574, 46);
    this.linkOffsetTransaction.Name = "linkOffsetTransaction";
    this.linkOffsetTransaction.Size = new Size(171, 13);
    this.linkOffsetTransaction.TabIndex = 22;
    this.linkOffsetTransaction.TabStop = true;
    this.linkOffsetTransaction.Text = "Offset Prior Monetary Transaction";
    this.linkOffsetTransaction.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkNewOption.AutoSize = true;
    this.lnkNewOption.BackColor = Color.Transparent;
    this.lnkNewOption.Location = new Point(660, 19);
    this.lnkNewOption.Name = "lnkNewOption";
    this.lnkNewOption.Size = new Size(85, 13);
    this.lnkNewOption.TabIndex = 21;
    this.lnkNewOption.TabStop = true;
    this.lnkNewOption.Text = "Add New Option";
    this.lnkNewOption.TextAlign = ContentAlignment.MiddleLeft;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(14, 96 /*0x60*/);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(56, 13);
    this.Label9.TabIndex = 19;
    this.Label9.Text = "Company:";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    this.cboCompanies.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCompanies.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCompanies).DropDownWidth = 200;
    ((Control) this.cboCompanies).Location = new Point(75, 92);
    this.cboCompanies.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompanies).Name = "cboCompanies";
    ((Control) this.cboCompanies).Size = new Size(380, 21);
    ((Control) this.cboCompanies).TabIndex = 20;
    ((UltraControlBase) this.cboCompanies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanies).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkFCW.AutoSize = true;
    this.lnkFCW.BackColor = Color.Transparent;
    this.lnkFCW.Location = new Point(75, 225);
    this.lnkFCW.Name = "lnkFCW";
    this.lnkFCW.Size = new Size(147, 13);
    this.lnkFCW.TabIndex = 18;
    this.lnkFCW.TabStop = true;
    this.lnkFCW.Text = "Forms/Conditions/Warranties";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(18, 146);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(51, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Premium:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.cboChargeCodes.BorderStyle = (UIElementBorderStyle) 4;
    this.cboChargeCodes.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboChargeCodes).DropDownWidth = 250;
    ((Control) this.cboChargeCodes).Location = new Point(75, 142);
    this.cboChargeCodes.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboChargeCodes).Name = "cboChargeCodes";
    ((Control) this.cboChargeCodes).Size = new Size(380, 21);
    ((Control) this.cboChargeCodes).TabIndex = 3;
    ((UltraControlBase) this.cboChargeCodes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboChargeCodes).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAmount).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtAmount).BackColor = Color.White;
    ((Control) this.txtAmount).Location = new Point(75, 192 /*0xC0*/);
    this.txtAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAmount).Name = "txtAmount";
    ((Control) this.txtAmount).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.txtAmount).TabIndex = 6;
    ((UltraControlBase) this.txtAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAmount).UseOsThemes = (DefaultableBoolean) 2;
    this.rbProRata.BackColor = Color.Transparent;
    this.rbProRata.Checked = true;
    this.rbProRata.Location = new Point(75, 15);
    this.rbProRata.Name = "rbProRata";
    this.rbProRata.Size = new Size(80 /*0x50*/, 24);
    this.rbProRata.TabIndex = 15;
    this.rbProRata.TabStop = true;
    this.rbProRata.Text = "Pro-Rata";
    this.rbProRata.UseVisualStyleBackColor = false;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(33, 121);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(37, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "State:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.rbFlat.BackColor = Color.Transparent;
    this.rbFlat.Location = new Point(171, 15);
    this.rbFlat.Name = "rbFlat";
    this.rbFlat.Size = new Size(52, 24);
    this.rbFlat.TabIndex = 16 /*0x10*/;
    this.rbFlat.Text = "Flat";
    this.rbFlat.UseVisualStyleBackColor = false;
    this.rbShortRate.BackColor = Color.Transparent;
    this.rbShortRate.Location = new Point(239, 15);
    this.rbShortRate.Name = "rbShortRate";
    this.rbShortRate.Size = new Size(80 /*0x50*/, 24);
    this.rbShortRate.TabIndex = 17;
    this.rbShortRate.Text = "Short-Rate";
    this.rbShortRate.UseVisualStyleBackColor = false;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(28, 72);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(42, 13);
    this.Label6.TabIndex = 10;
    this.Label6.Text = "Factor:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.cboOffices.BorderStyle = (UIElementBorderStyle) 4;
    this.cboOffices.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboOffices).DropDownWidth = 250;
    ((Control) this.cboOffices).Location = new Point(75, 167);
    this.cboOffices.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboOffices).Name = "cboOffices";
    ((Control) this.cboOffices).Size = new Size(380, 21);
    ((Control) this.cboOffices).TabIndex = 5;
    ((UltraControlBase) this.cboOffices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboOffices).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(16 /*0x10*/, 48 /*0x30*/);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(54, 13);
    this.Label5.TabIndex = 8;
    this.Label5.Text = "Effective:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtFactor).Appearance = (AppearanceBase) appearance5;
    ((Control) this.txtFactor).Location = new Point(75, 68);
    this.txtFactor.MaskInput = "n.nnnnnn";
    this.txtFactor.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFactor).Name = "txtFactor";
    this.txtFactor.NumericType = (NumericType) 1;
    ((Control) this.txtFactor).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.txtFactor).TabIndex = 13;
    ((UltraControlBase) this.txtFactor).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFactor).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(30, 171);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(40, 13);
    this.Label3.TabIndex = 4;
    this.Label3.Text = "Office:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(12, 19);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(58, 13);
    this.Label7.TabIndex = 14;
    this.Label7.Text = "Calc Type:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(22, 196);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(48 /*0x30*/, 13);
    this.Label4.TabIndex = 7;
    this.Label4.Text = "Amount:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtEffective.Appearance = (AppearanceBase) appearance6;
    appearance7.AlphaLevel = (short) 14;
    appearance7.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance7.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance7.BackColorAlpha = (Alpha) 2;
    appearance7.BackGradientAlignment = (GradientAlignment) 4;
    appearance7.BackGradientStyle = (GradientStyle) 5;
    appearance7.BorderAlpha = (Alpha) 1;
    appearance7.BorderColor = Color.FromArgb(78, 122, 171);
    appearance7.ForeColor = Color.FromArgb(49, 85, 153);
    appearance7.ForegroundAlpha = (Alpha) 2;
    this.dtEffective.ButtonAppearance = (AppearanceBase) appearance7;
    ((Control) this.dtEffective).Location = new Point(75, 44);
    this.dtEffective.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtEffective).Name = "dtEffective";
    ((Control) this.dtEffective).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dtEffective).TabIndex = 12;
    ((UltraControlBase) this.dtEffective).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEffective).UseOsThemes = (DefaultableBoolean) 2;
    this.cboState.BorderStyle = (UIElementBorderStyle) 4;
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboState).DropDownWidth = 200;
    ((Control) this.cboState).Location = new Point(75, 117);
    this.cboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(380, 21);
    ((Control) this.cboState).TabIndex = 1;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(647, 205);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 2;
    this.dbSave.ToolTipNew = "New Premium";
    ((Control) this.UltraTabPageControl7).Controls.Add((Control) this.Label10);
    ((Control) this.UltraTabPageControl7).Controls.Add((Control) this.txtPolicyLimit);
    ((Control) this.UltraTabPageControl7).Controls.Add((Control) this.UltraGroupBox6);
    ((Control) this.UltraTabPageControl7).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl7).Name = "UltraTabPageControl7";
    ((Control) this.UltraTabPageControl7).Size = new Size(763, 248);
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(597, 25);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(62, 13);
    this.Label10.TabIndex = 27;
    this.Label10.Text = "Policy Limit:";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((UltraNumericEditorBase) this.txtPolicyLimit).Appearance = (AppearanceBase) appearance8;
    ((UltraNumericEditorBase) this.txtPolicyLimit).BackColor = Color.White;
    ((Control) this.txtPolicyLimit).Location = new Point(599, 43);
    this.txtPolicyLimit.MaskInput = "n,nnn,nnn,nnn,nnn,nnn.nn";
    this.txtPolicyLimit.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPolicyLimit).Name = "txtPolicyLimit";
    this.txtPolicyLimit.NumericType = (NumericType) 2;
    ((Control) this.txtPolicyLimit).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.txtPolicyLimit).TabIndex = 26;
    ((UltraControlBase) this.txtPolicyLimit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPolicyLimit).UseOsThemes = (DefaultableBoolean) 2;
    this.UltraGroupBox6.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox6.ContentAreaAppearance = (AppearanceBase) appearance9;
    ((Control) this.UltraGroupBox6).Controls.Add((Control) this.txtLimit);
    ((Control) this.UltraGroupBox6).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox6).Name = "UltraGroupBox6";
    ((Control) this.UltraGroupBox6).Size = new Size(580, 200);
    ((Control) this.UltraGroupBox6).TabIndex = 6;
    this.UltraGroupBox6.Text = "Limit";
    this.txtLimit.AcceptsTab = true;
    this.txtLimit.BackColor = Color.White;
    this.txtLimit.BorderStyle = BorderStyle.None;
    this.txtLimit.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtLimit.ForeColor = Color.Black;
    this.txtLimit.Location = new Point(8, 16 /*0x10*/);
    this.txtLimit.Name = "txtLimit";
    this.txtLimit.Size = new Size(560, 176 /*0xB0*/);
    this.txtLimit.TabIndex = 3;
    this.txtLimit.Text = "";
    ((Control) this.UltraTabPageControl9).Controls.Add((Control) this.UltraGroupBox8);
    ((Control) this.UltraTabPageControl9).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl9).Name = "UltraTabPageControl9";
    ((Control) this.UltraTabPageControl9).Size = new Size(763, 248);
    this.UltraGroupBox8.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox8.ContentAreaAppearance = (AppearanceBase) appearance10;
    ((Control) this.UltraGroupBox8).Controls.Add((Control) this.txtSubLimits);
    ((Control) this.UltraGroupBox8).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox8).Name = "UltraGroupBox8";
    ((Control) this.UltraGroupBox8).Size = new Size(580, 200);
    ((Control) this.UltraGroupBox8).TabIndex = 7;
    this.UltraGroupBox8.Text = "Sub Limits";
    this.txtSubLimits.AcceptsTab = true;
    this.txtSubLimits.BackColor = Color.White;
    this.txtSubLimits.BorderStyle = BorderStyle.None;
    this.txtSubLimits.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtSubLimits.ForeColor = Color.Black;
    this.txtSubLimits.Location = new Point(8, 16 /*0x10*/);
    this.txtSubLimits.Name = "txtSubLimits";
    this.txtSubLimits.Size = new Size(568, 176 /*0xB0*/);
    this.txtSubLimits.TabIndex = 3;
    this.txtSubLimits.Text = "";
    ((Control) this.UltraTabPageControl8).Controls.Add((Control) this.UltraGroupBox7);
    ((Control) this.UltraTabPageControl8).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl8).Name = "UltraTabPageControl8";
    ((Control) this.UltraTabPageControl8).Size = new Size(763, 248);
    this.UltraGroupBox7.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox7.ContentAreaAppearance = (AppearanceBase) appearance11;
    ((Control) this.UltraGroupBox7).Controls.Add((Control) this.txtDeductible);
    ((Control) this.UltraGroupBox7).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox7).Name = "UltraGroupBox7";
    ((Control) this.UltraGroupBox7).Size = new Size(580, 200);
    ((Control) this.UltraGroupBox7).TabIndex = 7;
    this.UltraGroupBox7.Text = "Deductible";
    this.txtDeductible.AcceptsTab = true;
    this.txtDeductible.BackColor = Color.White;
    this.txtDeductible.BorderStyle = BorderStyle.None;
    this.txtDeductible.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtDeductible.ForeColor = Color.Black;
    this.txtDeductible.Location = new Point(5, 16 /*0x10*/);
    this.txtDeductible.Name = "txtDeductible";
    this.txtDeductible.Size = new Size(571, 176 /*0xB0*/);
    this.txtDeductible.TabIndex = 3;
    this.txtDeductible.Text = "";
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.UltraGroupBox1);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(763, 248);
    this.UltraGroupBox1.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance12;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.txtPerils);
    ((Control) this.UltraGroupBox1).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(580, 200);
    ((Control) this.UltraGroupBox1).TabIndex = 4;
    this.UltraGroupBox1.Text = "Perils/Coverage";
    this.txtPerils.AcceptsTab = true;
    this.txtPerils.BackColor = Color.White;
    this.txtPerils.BorderStyle = BorderStyle.None;
    this.txtPerils.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtPerils.ForeColor = Color.Black;
    this.txtPerils.Location = new Point(5, 15);
    this.txtPerils.Name = "txtPerils";
    this.txtPerils.Size = new Size(570, 180);
    this.txtPerils.TabIndex = 3;
    this.txtPerils.Text = "";
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.UltraGroupBox2);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(763, 248);
    this.UltraGroupBox2.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance13;
    ((Control) this.UltraGroupBox2).Controls.Add((Control) this.txtCovering);
    ((Control) this.UltraGroupBox2).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox2).Name = "UltraGroupBox2";
    ((Control) this.UltraGroupBox2).Size = new Size(580, 200);
    ((Control) this.UltraGroupBox2).TabIndex = 5;
    this.UltraGroupBox2.Text = "Covering";
    this.txtCovering.AcceptsTab = true;
    this.txtCovering.BackColor = Color.White;
    this.txtCovering.BorderStyle = BorderStyle.None;
    this.txtCovering.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCovering.ForeColor = Color.Black;
    this.txtCovering.Location = new Point(5, 16 /*0x10*/);
    this.txtCovering.Name = "txtCovering";
    this.txtCovering.Size = new Size(571, 176 /*0xB0*/);
    this.txtCovering.TabIndex = 3;
    this.txtCovering.Text = "";
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.UltraGroupBox3);
    ((Control) this.UltraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(763, 248);
    this.UltraGroupBox3.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox3.ContentAreaAppearance = (AppearanceBase) appearance14;
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.txtValuation);
    ((Control) this.UltraGroupBox3).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox3).Name = "UltraGroupBox3";
    ((Control) this.UltraGroupBox3).Size = new Size(580, 200);
    ((Control) this.UltraGroupBox3).TabIndex = 5;
    this.UltraGroupBox3.Text = "Valuation";
    this.txtValuation.AcceptsTab = true;
    this.txtValuation.BackColor = Color.White;
    this.txtValuation.BorderStyle = BorderStyle.None;
    this.txtValuation.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtValuation.ForeColor = Color.Black;
    this.txtValuation.Location = new Point(5, 16 /*0x10*/);
    this.txtValuation.Name = "txtValuation";
    this.txtValuation.Size = new Size(571, 176 /*0xB0*/);
    this.txtValuation.TabIndex = 3;
    this.txtValuation.Text = "";
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.UltraGroupBox4);
    ((Control) this.UltraTabPageControl5).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl5).Name = "UltraTabPageControl5";
    ((Control) this.UltraTabPageControl5).Size = new Size(763, 248);
    this.UltraGroupBox4.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox4.ContentAreaAppearance = (AppearanceBase) appearance15;
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.txtExcluding);
    ((Control) this.UltraGroupBox4).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox4).Name = "UltraGroupBox4";
    ((Control) this.UltraGroupBox4).Size = new Size(580, 200);
    ((Control) this.UltraGroupBox4).TabIndex = 5;
    this.UltraGroupBox4.Text = "Excluding";
    this.txtExcluding.AcceptsTab = true;
    this.txtExcluding.BackColor = Color.White;
    this.txtExcluding.BorderStyle = BorderStyle.None;
    this.txtExcluding.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtExcluding.ForeColor = Color.Black;
    this.txtExcluding.Location = new Point(5, 24);
    this.txtExcluding.Name = "txtExcluding";
    this.txtExcluding.Size = new Size(571, 168);
    this.txtExcluding.TabIndex = 3;
    this.txtExcluding.Text = "";
    ((Control) this.UltraTabPageControl6).Controls.Add((Control) this.UltraGroupBox5);
    ((Control) this.UltraTabPageControl6).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl6).Name = "UltraTabPageControl6";
    ((Control) this.UltraTabPageControl6).Size = new Size(763, 248);
    this.UltraGroupBox5.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox5.ContentAreaAppearance = (AppearanceBase) appearance16;
    ((Control) this.UltraGroupBox5).Controls.Add((Control) this.txtAdditionalComments);
    ((Control) this.UltraGroupBox5).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox5).Name = "UltraGroupBox5";
    ((Control) this.UltraGroupBox5).Size = new Size(580, 200);
    ((Control) this.UltraGroupBox5).TabIndex = 5;
    this.UltraGroupBox5.Text = "Comments";
    this.txtAdditionalComments.AcceptsTab = true;
    this.txtAdditionalComments.BackColor = Color.White;
    this.txtAdditionalComments.BorderStyle = BorderStyle.None;
    this.txtAdditionalComments.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtAdditionalComments.ForeColor = Color.Black;
    this.txtAdditionalComments.Location = new Point(5, 16 /*0x10*/);
    this.txtAdditionalComments.Name = "txtAdditionalComments";
    this.txtAdditionalComments.Size = new Size(571, 176 /*0xB0*/);
    this.txtAdditionalComments.TabIndex = 3;
    this.txtAdditionalComments.Text = "";
    ((Control) this.tabExposure).Controls.Add((Control) this.lnkPremiumAllocation);
    ((Control) this.tabExposure).Controls.Add((Control) this.btnExposure);
    ((Control) this.tabExposure).Controls.Add((Control) this.listExposureLines);
    ((Control) this.tabExposure).Controls.Add((Control) this.Label8);
    ((Control) this.tabExposure).Location = new Point(-10000, -10000);
    ((Control) this.tabExposure).Name = "tabExposure";
    ((Control) this.tabExposure).Size = new Size(763, 248);
    this.lnkPremiumAllocation.AutoSize = true;
    this.lnkPremiumAllocation.BackColor = Color.Transparent;
    this.lnkPremiumAllocation.Location = new Point(10, 220);
    this.lnkPremiumAllocation.Name = "lnkPremiumAllocation";
    this.lnkPremiumAllocation.Size = new Size(298, 13);
    this.lnkPremiumAllocation.TabIndex = 5;
    this.lnkPremiumAllocation.TabStop = true;
    this.lnkPremiumAllocation.Text = "Click here for premium allocation by state, company, and TIV";
    appearance17.BackColor = Color.FromArgb(248, 248, 248);
    appearance17.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance17.BackGradientStyle = (GradientStyle) 2;
    appearance17.BorderColor = Color.DarkGray;
    appearance17.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance17.Image"));
    appearance17.ImageHAlign = (HAlign) 3;
    appearance17.ImageVAlign = (VAlign) 2;
    ((AppearanceBase) appearance17).TextHAlignAsString = "Left";
    ((ControlBase) this.btnExposure).Appearance = (AppearanceBase) appearance17;
    ((Control) this.btnExposure).Location = new Point(260, 168);
    ((Control) this.btnExposure).Name = "btnExposure";
    ((ControlBase) this.btnExposure).Padding = new Size(5, 0);
    ((Control) this.btnExposure).Size = new Size(120, 30);
    ((Control) this.btnExposure).TabIndex = 4;
    ((ControlBase) this.btnExposure).Text = "Go to Exposure";
    this.btnExposure.UseOSThemes = (DefaultableBoolean) 2;
    this.listExposureLines.BackColor = Color.White;
    this.listExposureLines.ForeColor = Color.Black;
    this.listExposureLines.Location = new Point(10, 40);
    this.listExposureLines.MGAStyle = MGAStyles.Blue;
    this.listExposureLines.Name = "listExposureLines";
    this.listExposureLines.Size = new Size(245, 158);
    this.listExposureLines.TabIndex = 3;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(10, 15);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(310, 20);
    this.Label8.TabIndex = 2;
    this.Label8.Text = "Please select the line you would like to enter exposure for:";
    this.daOptions.DeleteCommand = this.SqlDeleteCommand1;
    this.daOptions.InsertCommand = this.SqlInsertCommand1;
    this.daOptions.SelectCommand = this.SqlSelectCommand1;
    this.daOptions.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteOptions", new DataColumnMapping[8]
      {
        new DataColumnMapping("QuoteOptionGUID", "QuoteOptionGUID"),
        new DataColumnMapping("QuoteGUID", "QuoteGUID"),
        new DataColumnMapping("LineGUID", "LineGUID"),
        new DataColumnMapping("Premium", "Premium"),
        new DataColumnMapping("DateCreated", "DateCreated"),
        new DataColumnMapping("QuoteOptionID", "QuoteOptionID"),
        new DataColumnMapping("AdditionalComments", "AdditionalComments"),
        new DataColumnMapping("CompanyLocationID", "CompanyLocationID")
      })
    });
    this.daOptions.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblQuoteOptions WHERE (QuoteOptionGUID = @Original_QuoteOptionGUID)";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionGUID", DataRowVersion.Original, (object) null)
    });
    this.cnSQL.ConnectionString = "Data Source=MGASYSTEMS;Initial Catalog=IMS;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGUID"),
      new SqlParameter("@QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID"),
      new SqlParameter("@DateCreated", SqlDbType.DateTime, 8, "DateCreated"),
      new SqlParameter("@AdditionalComments", SqlDbType.VarChar, 2000, "AdditionalComments"),
      new SqlParameter("@CompanyLocationID", SqlDbType.Int, 4, "CompanyLocationID")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGUID"),
      new SqlParameter("@QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID"),
      new SqlParameter("@DateCreated", SqlDbType.DateTime, 8, "DateCreated"),
      new SqlParameter("@AdditionalComments", SqlDbType.VarChar, 2000, "AdditionalComments"),
      new SqlParameter("@CompanyLocationID", SqlDbType.Int, 4, "CompanyLocationID"),
      new SqlParameter("@Original_QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionGUID", DataRowVersion.Original, (object) null)
    });
    this.err.ContainerControl = (ContainerControl) this;
    this.cmdOfficeLines.CommandText = "SELECT tblClientOffices.OfficeID FROM tblOfficeLines INNER JOIN tblClientOffices ON tblOfficeLines.OfficeGuid = tblClientOffices.OfficeGUID WHERE (tblOfficeLines.CompanyLineGuid = @CompanyLineGuid)";
    this.cmdOfficeLines.Connection = this.cnSQL;
    this.cmdOfficeLines.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid")
    });
    this.daOptionsGeneric.DeleteCommand = this.SqlDeleteCommand2;
    this.daOptionsGeneric.InsertCommand = this.SqlInsertCommand2;
    this.daOptionsGeneric.SelectCommand = this.SqlSelectCommand2;
    this.daOptionsGeneric.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteOptionGeneric", new DataColumnMapping[10]
      {
        new DataColumnMapping("GenericID", "GenericID"),
        new DataColumnMapping("QuoteOptionGuid", "QuoteOptionGuid"),
        new DataColumnMapping("EffectiveDate", "EffectiveDate"),
        new DataColumnMapping("UserOverrideFactor", "UserOverrideFactor"),
        new DataColumnMapping("ChargeCode", "ChargeCode"),
        new DataColumnMapping("OfficeID", "OfficeID"),
        new DataColumnMapping("Premium", "Premium"),
        new DataColumnMapping("Added", "Added"),
        new DataColumnMapping("EndorsementCalcType", "EndorsementCalcType"),
        new DataColumnMapping("RoundToDollar", "RoundToDollar")
      })
    });
    this.daOptionsGeneric.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM [tblQuoteOptionGeneric] WHERE (([GenericID] = @Original_GenericID))";
    this.SqlDeleteCommand2.Connection = this.cnSQL;
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_GenericID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GenericID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = componentResourceManager.GetString("SqlInsertCommand2.CommandText");
    this.SqlInsertCommand2.Connection = this.cnSQL;
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[11]
    {
      new SqlParameter("@QuoteOptionGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGuid"),
      new SqlParameter("@EffectiveDate", SqlDbType.DateTime, 8, "EffectiveDate"),
      new SqlParameter("@UserOverrideFactor", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 5, (byte) 4, "UserOverrideFactor", DataRowVersion.Current, (object) null),
      new SqlParameter("@ChargeCode", SqlDbType.Int, 4, "ChargeCode"),
      new SqlParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      new SqlParameter("@Premium", SqlDbType.Money, 8, "Premium"),
      new SqlParameter("@Added", SqlDbType.DateTime, 8, "Added"),
      new SqlParameter("@EndorsementCalcType", SqlDbType.Char, 1, "EndorsementCalcType"),
      new SqlParameter("@RoundToDollar", SqlDbType.Bit, 1, "RoundToDollar"),
      new SqlParameter("@CurrentAnnualPremium", SqlDbType.Money, 8, "CurrentAnnualPremium"),
      new SqlParameter("@IncludeLeapYear", SqlDbType.Bit, 0, "IncludeLeapYear")
    });
    this.SqlSelectCommand2.CommandText = componentResourceManager.GetString("SqlSelectCommand2.CommandText");
    this.SqlSelectCommand2.Connection = this.cnSQL;
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID")
    });
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Connection = this.cnSQL;
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[13]
    {
      new SqlParameter("@QuoteOptionGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGuid"),
      new SqlParameter("@EffectiveDate", SqlDbType.DateTime, 8, "EffectiveDate"),
      new SqlParameter("@UserOverrideFactor", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 5, (byte) 4, "UserOverrideFactor", DataRowVersion.Current, (object) null),
      new SqlParameter("@ChargeCode", SqlDbType.Int, 4, "ChargeCode"),
      new SqlParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      new SqlParameter("@Premium", SqlDbType.Money, 8, "Premium"),
      new SqlParameter("@Added", SqlDbType.DateTime, 8, "Added"),
      new SqlParameter("@EndorsementCalcType", SqlDbType.Char, 1, "EndorsementCalcType"),
      new SqlParameter("@RoundToDollar", SqlDbType.Bit, 1, "RoundToDollar"),
      new SqlParameter("@CurrentAnnualPremium", SqlDbType.Money, 8, "CurrentAnnualPremium"),
      new SqlParameter("@Original_GenericID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GenericID", DataRowVersion.Original, (object) null),
      new SqlParameter("@GenericID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GenericID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IncludeLeapYear", SqlDbType.Bit, 0, "IncludeLeapYear")
    });
    ((Control) this.MgaTab1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((UltraTabControlBase) this.MgaTab1).BackColorInternal = Color.White;
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl4);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl5);
    ((Control) this.MgaTab1).Controls.Add((Control) this.tabExposure);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl6);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl7);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl8);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl9);
    ((Control) this.MgaTab1).Location = new Point(10, 220);
    ((Control) this.MgaTab1).Name = "MgaTab1";
    ((UltraTabControlBase) this.MgaTab1).SharedControls.AddRange(new Control[1]
    {
      (Control) this.dbSave
    });
    ((UltraTabControlBase) this.MgaTab1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.MgaTab1).Size = new Size(765, 275);
    ((Control) this.MgaTab1).TabIndex = 9;
    ((UltraTabControlBase) this.MgaTab1).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.MgaTab1).TabPadding = new Size(5, 3);
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ((SubObjectBase) ultraTab1).Tag = (object) "Validate";
    ultraTab1.Text = "Premiums";
    ultraTab2.TabPage = this.UltraTabPageControl7;
    ((SubObjectBase) ultraTab2).Tag = (object) "Validate";
    ultraTab2.Text = "Limit";
    ultraTab3.TabPage = this.UltraTabPageControl9;
    ((SubObjectBase) ultraTab3).Tag = (object) "Validate";
    ultraTab3.Text = "Sub Limits";
    ultraTab4.TabPage = this.UltraTabPageControl8;
    ((SubObjectBase) ultraTab4).Tag = (object) "Validate";
    ultraTab4.Text = "Deductible";
    ultraTab5.TabPage = this.UltraTabPageControl2;
    ((SubObjectBase) ultraTab5).Tag = (object) "Validate";
    ultraTab5.Text = "Perils/Coverage";
    ultraTab6.TabPage = this.UltraTabPageControl3;
    ((SubObjectBase) ultraTab6).Tag = (object) "Validate";
    ultraTab6.Text = "Covering";
    ultraTab7.TabPage = this.UltraTabPageControl4;
    ((SubObjectBase) ultraTab7).Tag = (object) "Validate";
    ultraTab7.Text = "Valuation";
    ultraTab8.TabPage = this.UltraTabPageControl5;
    ultraTab8.Text = "Excluding";
    ultraTab9.TabPage = this.UltraTabPageControl6;
    ultraTab9.Text = "Comments";
    ultraTab10.TabPage = this.tabExposure;
    ultraTab10.Text = "Exposure";
    ((UltraTabControlBase) this.MgaTab1).Tabs.AddRange(new UltraTab[10]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5,
      ultraTab6,
      ultraTab7,
      ultraTab8,
      ultraTab9,
      ultraTab10
    });
    ((UltraControlBase) this.MgaTab1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTab1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTabControlBase) this.MgaTab1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(763, 248);
    this.daGenericLimits.DeleteCommand = this.SqlDeleteCommand3;
    this.daGenericLimits.InsertCommand = this.SqlInsertCommand3;
    this.daGenericLimits.SelectCommand = this.SqlSelectCommand3;
    this.daGenericLimits.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblGenericLimits", new DataColumnMapping[9]
      {
        new DataColumnMapping("QuoteID", "QuoteID"),
        new DataColumnMapping("Limit", "Limit"),
        new DataColumnMapping("SubLimits", "SubLimits"),
        new DataColumnMapping("Perils", "Perils"),
        new DataColumnMapping("Covering", "Covering"),
        new DataColumnMapping("Deductible", "Deductible"),
        new DataColumnMapping("Valuation", "Valuation"),
        new DataColumnMapping("Excluding", "Excluding"),
        new DataColumnMapping("AdditionalComments", "AdditionalComments")
      })
    });
    this.daGenericLimits.UpdateCommand = this.SqlUpdateCommand3;
    this.SqlDeleteCommand3.CommandText = "DELETE FROM dbo.tblGenericLimits WHERE (QuoteID = @Original_QuoteID)";
    this.SqlDeleteCommand3.Connection = this.cnSQL;
    this.SqlDeleteCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_QuoteID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand3.CommandText = componentResourceManager.GetString("SqlInsertCommand3.CommandText");
    this.SqlInsertCommand3.Connection = this.cnSQL;
    this.SqlInsertCommand3.Parameters.AddRange(new SqlParameter[10]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      new SqlParameter("@Limit", SqlDbType.VarChar, int.MaxValue, "Limit"),
      new SqlParameter("@SubLimits", SqlDbType.VarChar, int.MaxValue, "SubLimits"),
      new SqlParameter("@Perils", SqlDbType.VarChar, int.MaxValue, "Perils"),
      new SqlParameter("@Covering", SqlDbType.VarChar, int.MaxValue, "Covering"),
      new SqlParameter("@Deductible", SqlDbType.VarChar, int.MaxValue, "Deductible"),
      new SqlParameter("@Valuation", SqlDbType.VarChar, int.MaxValue, "Valuation"),
      new SqlParameter("@Excluding", SqlDbType.VarChar, int.MaxValue, "Excluding"),
      new SqlParameter("@AdditionalComments", SqlDbType.VarChar, int.MaxValue, "AdditionalComments"),
      new SqlParameter("@PolicyLimit", SqlDbType.VarChar, int.MaxValue, "PolicyLimit")
    });
    this.SqlSelectCommand3.CommandText = "SELECT QuoteID, Limit, SubLimits, Perils, Covering, Deductible, Valuation, Excluding, AdditionalComments,PolicyLimit FROM dbo.tblGenericLimits WHERE (QuoteID = @QuoteID)";
    this.SqlSelectCommand3.Connection = this.cnSQL;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.SqlUpdateCommand3.CommandText = componentResourceManager.GetString("SqlUpdateCommand3.CommandText");
    this.SqlUpdateCommand3.Connection = this.cnSQL;
    this.SqlUpdateCommand3.Parameters.AddRange(new SqlParameter[11]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      new SqlParameter("@Limit", SqlDbType.VarChar, int.MaxValue, "Limit"),
      new SqlParameter("@SubLimits", SqlDbType.VarChar, int.MaxValue, "SubLimits"),
      new SqlParameter("@Perils", SqlDbType.VarChar, int.MaxValue, "Perils"),
      new SqlParameter("@Covering", SqlDbType.VarChar, int.MaxValue, "Covering"),
      new SqlParameter("@Deductible", SqlDbType.VarChar, int.MaxValue, "Deductible"),
      new SqlParameter("@Valuation", SqlDbType.VarChar, int.MaxValue, "Valuation"),
      new SqlParameter("@Excluding", SqlDbType.VarChar, int.MaxValue, "Excluding"),
      new SqlParameter("@AdditionalComments", SqlDbType.VarChar, int.MaxValue, "AdditionalComments"),
      new SqlParameter("@PolicyLimit", SqlDbType.VarChar, int.MaxValue, "PolicyLimit"),
      new SqlParameter("@Original_QuoteID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteID", DataRowVersion.Original, (object) null)
    });
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelLoading.ContentAreaAppearance = (AppearanceBase) appearance18;
    ((Control) this.panelLoading).Controls.Add((Control) this.panelLoadText);
    ((Control) this.panelLoading).Controls.Add((Control) this.PictureBox1);
    ((Control) this.panelLoading).Location = new Point(271, 74);
    ((Control) this.panelLoading).Name = "panelLoading";
    ((Control) this.panelLoading).Size = new Size(240 /*0xF0*/, 48 /*0x30*/);
    ((Control) this.panelLoading).TabIndex = 10;
    this.panelLoadText.AutoSize = true;
    this.panelLoadText.Font = new Font("Tahoma", 11f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.panelLoadText.Location = new Point(47, 15);
    this.panelLoadText.Name = "panelLoadText";
    this.panelLoadText.Size = new Size(173, 18);
    this.panelLoadText.TabIndex = 1;
    this.panelLoadText.Text = "Loading ... please wait ...";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    ((UltraGridBase) this.ddOffices).DataSource = (object) this.ds.tblClientOffices;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 5;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 3;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 6;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 4;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 10;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 9;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 11;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 12;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 14;
    ultraGridBand2.Columns.AddRange(new object[15]
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
      (object) ultraGridColumn18
    });
    ((UltraGridBase) this.ddOffices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ddOffices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddOffices).DisplayMember = "Location";
    ((Control) this.ddOffices).Location = new Point(610, 74);
    ((Control) this.ddOffices).Name = "ddOffices";
    ((Control) this.ddOffices).Size = new Size(160 /*0xA0*/, 65);
    ((Control) this.ddOffices).TabIndex = 5;
    ((UltraDropDownBase) this.ddOffices).ValueMember = "OfficeID";
    ((Control) this.ddOffices).Visible = false;
    this.ds.DataSetName = "dsRaterGeneric";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.ddChargeCodes).DataSource = (object) this.ds.tblFin_PolicyCharges;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 0;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 1;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 2;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 3;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 4;
    ultraGridBand3.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23
    });
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 0;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 3;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 2;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 6;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 8;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 9;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 4;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 7;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 5;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 11;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 10;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 12;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 1;
    ultraGridColumn37.Hidden = true;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 14;
    ultraGridBand4.Columns.AddRange(new object[15]
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
      (object) ultraGridColumn38
    });
    ((UltraGridBase) this.ddChargeCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ddChargeCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraDropDownBase) this.ddChargeCodes).DisplayMember = "ChargeName";
    ((Control) this.ddChargeCodes).Location = new Point(390, 145);
    ((Control) this.ddChargeCodes).Name = "ddChargeCodes";
    ((Control) this.ddChargeCodes).Size = new Size(380, 65);
    ((Control) this.ddChargeCodes).TabIndex = 4;
    ((UltraDropDownBase) this.ddChargeCodes).ValueMember = "ChargeCode";
    ((Control) this.ddChargeCodes).Visible = false;
    ((Control) this.dgOptions).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgOptions).DataSource = (object) this.ds.tblQuoteOptions;
    appearance19.BackColor = Color.White;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Appearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.dgOptions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 0;
    ultraGridColumn39.Hidden = true;
    ultraGridColumn39.Width = 41;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 1;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 129;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 2;
    ultraGridColumn41.Hidden = true;
    ultraGridColumn41.Width = 163;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 3;
    ultraGridColumn42.Hidden = true;
    ultraGridColumn42.Width = 224 /*0xE0*/;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn43.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance20).TextHAlignAsString = "Right";
    ultraGridColumn43.CellAppearance = (AppearanceBase) appearance20;
    ultraGridColumn43.Format = "c";
    ((AppearanceBase) appearance21).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn43.Header).Appearance = (AppearanceBase) appearance21;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 9;
    ultraGridColumn43.Width = 270;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn44.CellActivation = (Activation) 3;
    ultraGridColumn44.Format = "d";
    ((HeaderBase) ultraGridColumn44.Header).Caption = "Added";
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 4;
    ultraGridColumn44.Width = 88;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 5;
    ultraGridColumn45.Hidden = true;
    ultraGridColumn45.Width = 109;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance22.FontData.UnderlineAsString = "True";
    appearance22.ForeColor = Color.Blue;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Center";
    ultraGridColumn46.CellAppearance = (AppearanceBase) appearance22;
    ((HeaderBase) ultraGridColumn46.Header).Caption = "Comments";
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 6;
    ultraGridColumn46.Width = 126;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 7;
    ultraGridColumn47.Hidden = true;
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn48.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 8;
    ultraGridColumn48.Width = 260;
    ultraGridColumn49.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 10;
    ultraGridBand5.Columns.AddRange(new object[11]
    {
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
      (object) ultraGridColumn49
    });
    ultraGridColumn50.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 0;
    ultraGridColumn50.Hidden = true;
    ultraGridColumn50.Width = 24;
    ultraGridColumn51.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 1;
    ultraGridColumn51.Hidden = true;
    ultraGridColumn51.Width = 42;
    ultraGridColumn52.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 2;
    ultraGridColumn52.Hidden = true;
    ultraGridColumn52.Width = 111;
    ultraGridColumn53.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 3;
    ultraGridColumn53.Hidden = true;
    ultraGridColumn53.Width = 89;
    ultraGridColumn54.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.Header.VisiblePosition = 4;
    ultraGridColumn54.Hidden = true;
    ultraGridColumn54.Width = 131;
    ultraGridColumn55.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.Header.VisiblePosition = 5;
    ultraGridColumn55.Hidden = true;
    ultraGridColumn55.Width = 77;
    ultraGridColumn56.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Left";
    ultraGridColumn56.CellAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn56.Header).Appearance = (AppearanceBase) appearance24;
    ((HeaderBase) ultraGridColumn56.Header).Caption = "Premium";
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn56.Header.VisiblePosition = 6;
    ultraGridColumn56.Style = (ColumnStyle) 6;
    ultraGridColumn56.Width = 232;
    ultraGridColumn57.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Left";
    ultraGridColumn57.CellAppearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn57.Header).Appearance = (AppearanceBase) appearance26;
    ((HeaderBase) ultraGridColumn57.Header).Caption = "Office";
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn57.Header.VisiblePosition = 8;
    ultraGridColumn57.Style = (ColumnStyle) 6;
    ultraGridColumn57.Width = 175;
    ultraGridColumn58.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance27.ForeColor = Color.Green;
    ((AppearanceBase) appearance27).TextHAlignAsString = "Right";
    ultraGridColumn58.CellAppearance = (AppearanceBase) appearance27;
    ultraGridColumn58.Format = "c";
    ((AppearanceBase) appearance28).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn58.Header).Appearance = (AppearanceBase) appearance28;
    ((HeaderBase) ultraGridColumn58.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn58.Header.VisiblePosition = 9;
    ultraGridColumn58.Width = 79;
    ultraGridColumn59.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn59.Header.VisiblePosition = 10;
    ultraGridColumn59.Hidden = true;
    ultraGridColumn59.Width = 70;
    ultraGridColumn60.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance29).TextHAlignAsString = "Left";
    ultraGridColumn60.CellAppearance = (AppearanceBase) appearance29;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn60.Header).Appearance = (AppearanceBase) appearance30;
    ((HeaderBase) ultraGridColumn60.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn60.Header.VisiblePosition = 7;
    ultraGridColumn60.Width = 62;
    ultraGridColumn61.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn61.Header.VisiblePosition = 12;
    ultraGridColumn61.Hidden = true;
    ultraGridColumn61.Width = 142;
    ultraGridColumn62.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn62.Header.VisiblePosition = 13;
    ultraGridColumn62.Width = 80 /*0x50*/;
    ((AppearanceBase) appearance31).TextHAlignAsString = "Right";
    ultraGridColumn63.CellAppearance = (AppearanceBase) appearance31;
    ultraGridColumn63.Format = "c";
    ((HeaderBase) ultraGridColumn63.Header).Caption = "Annual Premium";
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn63.Header.VisiblePosition = 11;
    ultraGridColumn63.Width = 97;
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn64.Header.VisiblePosition = 14;
    ultraGridColumn64.Hidden = true;
    ultraGridColumn64.Width = 88;
    ultraGridBand6.Columns.AddRange(new object[15]
    {
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
      (object) ultraGridColumn64
    });
    ultraGridBand6.Override.AllowUpdate = (DefaultableBoolean) 2;
    ultraGridBand6.Override.CellClickAction = (CellClickAction) 2;
    ((UltraGridBase) this.dgOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.dgOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.dgOptions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance32.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance33.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance33;
    appearance34.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance34;
    appearance35.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance35;
    appearance36.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance37.BackColor = Color.Transparent;
    appearance37.ForeColor = Color.Black;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance37;
    ((UltraGridBase) this.dgOptions).DisplayLayout.RowConnectorColor = Color.LightGray;
    ((UltraGridBase) this.dgOptions).DisplayLayout.RowConnectorStyle = (RowConnectorStyle) 4;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgOptions).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgOptions).Location = new Point(10, 8);
    ((Control) this.dgOptions).Name = "dgOptions";
    ((Control) this.dgOptions).Size = new Size(765, 202);
    ((Control) this.dgOptions).TabIndex = 0;
    ((UltraControlBase) this.dgOptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgOptions).UseOsThemes = (DefaultableBoolean) 2;
    this.dvChargeCodes.Table = (DataTable) this.ds.tblFin_PolicyCharges;
    this.dvOffices.Table = (DataTable) this.ds.tblClientOffices;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(782, 501);
    this.Controls.Add((Control) this.panelLoading);
    this.Controls.Add((Control) this.MgaTab1);
    this.Controls.Add((Control) this.ddOffices);
    this.Controls.Add((Control) this.ddChargeCodes);
    this.Controls.Add((Control) this.dgOptions);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmRaterGeneric);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Generic Rater";
    this.Controls.SetChildIndex((Control) this.dgOptions, 0);
    this.Controls.SetChildIndex((Control) this.ddChargeCodes, 0);
    this.Controls.SetChildIndex((Control) this.ddOffices, 0);
    this.Controls.SetChildIndex((Control) this.MgaTab1, 0);
    this.Controls.SetChildIndex((Control) this.panelLoading, 0);
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.chkIncludeLeapYear).EndInit();
    ((ISupportInitialize) this.txtCurrentAnnualPremium).EndInit();
    ((ISupportInitialize) this.checkRoundPremiums).EndInit();
    ((ISupportInitialize) this.cboCompanies).EndInit();
    ((ISupportInitialize) this.cboChargeCodes).EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.cboOffices).EndInit();
    ((ISupportInitialize) this.txtFactor).EndInit();
    ((ISupportInitialize) this.dtEffective).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((Control) this.UltraTabPageControl7).ResumeLayout(false);
    ((Control) this.UltraTabPageControl7).PerformLayout();
    ((ISupportInitialize) this.txtPolicyLimit).EndInit();
    ((ISupportInitialize) this.UltraGroupBox6).EndInit();
    ((Control) this.UltraGroupBox6).ResumeLayout(false);
    ((Control) this.UltraTabPageControl9).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox8).EndInit();
    ((Control) this.UltraGroupBox8).ResumeLayout(false);
    ((Control) this.UltraTabPageControl8).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox7).EndInit();
    ((Control) this.UltraGroupBox7).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox2).EndInit();
    ((Control) this.UltraGroupBox2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl4).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox3).EndInit();
    ((Control) this.UltraGroupBox3).ResumeLayout(false);
    ((Control) this.UltraTabPageControl5).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox4).EndInit();
    ((Control) this.UltraGroupBox4).ResumeLayout(false);
    ((Control) this.UltraTabPageControl6).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox5).EndInit();
    ((Control) this.UltraGroupBox5).ResumeLayout(false);
    ((Control) this.tabExposure).ResumeLayout(false);
    ((Control) this.tabExposure).PerformLayout();
    ((ISupportInitialize) this.btnExposure).EndInit();
    ((ISupportInitialize) this.listExposureLines).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.MgaTab1).EndInit();
    ((Control) this.MgaTab1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((ISupportInitialize) this.panelLoading).EndInit();
    ((Control) this.panelLoading).ResumeLayout(false);
    ((Control) this.panelLoading).PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.ddOffices).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddChargeCodes).EndInit();
    ((ISupportInitialize) this.dgOptions).EndInit();
    this.dvChargeCodes.EndInit();
    this.dvOffices.EndInit();
    this.ResumeLayout(false);
  }

  public frmRaterGeneric()
  {
    this.Load += new EventHandler(this.frmRaterGeneric_Load);
    this._lineName = string.Empty;
    this._gridLayout = new MemoryStream();
    this._notRoundingPremiumToDollar = false;
    this._roundProRataFactor = false;
    this._hasPremiumDistribution = false;
    this._enableGenericPremiumDistribution = false;
    this.InitializeComponent();
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.dbSave.Enabled = false;
    this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  protected virtual void UpdateOtherSubmissionQuotes(
    Guid quoteGuid,
    Guid submissionGroupGuid,
    Guid lineGuid)
  {
  }

  public virtual bool NotRoundingPremiumToDollar => this._notRoundingPremiumToDollar;

  private RaterGeneric GenericRater => (RaterGeneric) this.Rater;

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblQuoteOptionGeneric.TableName];
  }

  private Quote Quote
  {
    get
    {
      if (this._quote == null)
        this._quote = new Quote(this.Rater.QuoteGuid);
      return this._quote;
    }
  }

  private string LineName
  {
    get
    {
      if (this._lineName.Length == 0)
        this._lineName = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT LineName FROM lstLines WHERE (LineGuid = @LineGuid)", new object[2]
        {
          (object) "@LineGuid",
          (object) this.Rater.LineGuid
        });
      return this._lineName;
    }
  }

  private void frmRaterGeneric_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this._isQuoteBound = this.Quote.IsBound;
    this._quoteStatus = this.Rater.Quote.QuoteStatus;
    this.SetScreenEnabled();
    this._enableGenericPremiumDistribution = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("EnableGenericPremiumDistribution");
    this.Cursor = MgaCursors.Working;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Save((Stream) this._gridLayout);
    ((UltraGridBase) this.dgOptions).DataSource = (object) null;
    ((UltraGridBase) this.ddChargeCodes).DataSource = (object) null;
    ((UltraGridBase) this.ddOffices).DataSource = (object) null;
    this.Text = $"{this.Text} - {this.LineName}";
    this._notRoundingPremiumToDollar = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("NotRoundGenericPremiumToDollar");
    this._roundProRataFactor = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("RoundGenericRaterProRataFactor");
    this._quotingOfficeID = this._quote.QuotingLocation.OfficeID;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedLoad));
  }

  private void ThreadedLoad(object state)
  {
    this._isEndorsement = this._quote.IsEndorsement;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblClientOffices"
    }, "dbo.GetRaterOffices");
    this.dvOffices.RowFilter = "0=1";
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstStates"
    }, "dbo.GetGenericRaterStates", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.Rater.QuoteGuid
    });
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblFin_PolicyCharges"
    }, CommandType.Text, "SELECT ChargeCode, StateID + @D + ChargeName AS ChargeName, StateID, ChargeID FROM tblFin_PolicyCharges WHERE (ChargeType = @P) ORDER BY StateID + @D + ChargeName", new object[4]
    {
      (object) "@D",
      (object) " - ",
      (object) "@P",
      (object) "P"
    });
    this.LoadClientData();
    this.dvChargeCodes.RowFilter = "0=1";
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblCompanyLocations"
    }, "dbo.spGenericRaterCompanies", new object[2]
    {
      (object) "@companyLineGuid",
      (object) this.Rater.Quote.CompanyLineGuid
    });
    if (this.ds.tblCompanyLocations.Count == 0)
      ErrorHandler.HandleErrorOnThread((Control) this, (Exception) new InvalidOperationException("No companies loaded in frmRaterGeneric.FillData!"));
    SqlDataAdapter daOptions = this.daOptions;
    daOptions.SelectCommand.Parameters["@QuoteGUID"].Value = (object) this.Rater.QuoteGuid;
    daOptions.SelectCommand.Parameters["@LineGUID"].Value = (object) this.Rater.LineGuid;
    SqlDataAdapter daOptionsGeneric = this.daOptionsGeneric;
    daOptionsGeneric.SelectCommand.Parameters["@QuoteGUID"].Value = (object) this.Rater.QuoteGuid;
    daOptionsGeneric.SelectCommand.Parameters["@LineGUID"].Value = (object) this.Rater.LineGuid;
    this.daGenericLimits.SelectCommand.Parameters["@QuoteID"].Value = (object) this.Rater.Quote.QuoteID;
    this.daGenericLimits.Fill((DataTable) this.ds.tblGenericLimits);
    if (this.ds.tblGenericLimits.Count == 0)
      this.AddGenericLimitsRow();
    this.LoadPremiums();
    MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.LoadComplete));
  }

  protected virtual void LoadClientData()
  {
  }

  private void LoadComplete()
  {
    try
    {
      this.dbSave.Enabled = !this._isQuoteBound;
      this.lnkNewOption.Enabled = !this._isQuoteBound;
      this.linkOffsetTransaction.Enabled = this._isEndorsement;
      this.linkEndorsementOffsets.Enabled = this._isEndorsement;
      this.SetFactorScale();
      this.cboState.ValueChanged += new EventHandler(this.cboState_SelectedIndexChanged);
      ((UltraToggleEditorBase) this.chkIncludeLeapYear).CheckedChanged += new EventHandler(this.chkIncludeLeapYear_CheckedChanged);
      this.HookDataBindings();
      this.ExpandAllRows();
      try
      {
        if (!this.Quote.IsBound)
        {
          this._hlkAddComments = new HyperlinkEditor();
          this._hlkAddComments.HyperLinkOpening += new CancelEventHandler(this.hlkAddComments_HyperLinkOpening);
          ((UltraGridBase) this.dgOptions).DisplayLayout.Bands[0].Columns["AddComments"].Editor = (EmbeddableEditorBase) this._hlkAddComments;
        }
        else
          ((UltraGridBase) this.dgOptions).DisplayLayout.Bands[0].Columns["AddComments"].Hidden = true;
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
        return;
      }
      this.SetScreenEnabled();
      ((Control) this.panelLoading).Visible = false;
      if (this.ds.tblQuoteOptionGeneric.Count == 0 && this.NotRoundingPremiumToDollar)
        ((UltraToggleEditorBase) this.checkRoundPremiums).Checked = false;
      this._hasPremiumDistribution = frmRaterGeneric.IsGenericPremiumDistribution(this.Rater.Quote.QuoteGuid);
      this.EnablePremiumDistributionLink();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void SetFactorScale()
  {
    Decimal? setting = MGASystems.Common.Settings.SystemSettings.GetSetting<Decimal?>("DefaultGenericRaterFactorScale");
    if (!setting.HasValue)
      return;
    if (Decimal.Compare(setting.Value, 3M) < 0 || Decimal.Compare(setting.Value, 6M) > 0)
      throw new InvalidOperationException("Generic rater factor scale cannot be less than 3 or more than 6");
    this.txtFactor.MaskInput = "n.";
    for (int index = 0; index < Convert.ToInt32(setting.Value); ++index)
      this.txtFactor.MaskInput += "n";
  }

  private void EnablePremiumDistributionLink()
  {
    this.lnkPremiumUI.Visible = this._enableGenericPremiumDistribution;
    this.lnkCancellation.Visible = this._enableGenericPremiumDistribution;
    this.lnkPremiumUI.Enabled = this.ds.tblQuoteOptionGeneric.Count > 0;
    this.lnkNewOption.Enabled = !this._hasPremiumDistribution;
    this.linkOffsetTransaction.Enabled = !this._hasPremiumDistribution;
    this.lnkCancellation.Enabled = this._enableGenericPremiumDistribution && this._quoteStatus == QuoteStatus.PendingCancellation;
  }

  private void HookDataBindings()
  {
    try
    {
      MGASimpleComboBox cboState = this.cboState;
      ((UltraGridBase) cboState).DataSource = (object) this.ds.lstStates;
      ((UltraDropDownBase) cboState).DisplayMember = "State";
      ((UltraDropDownBase) cboState).ValueMember = "StateID";
      MGASimpleComboBox cboCompanies = this.cboCompanies;
      ((UltraGridBase) cboCompanies).DataSource = (object) this.ds.tblCompanyLocations;
      ((UltraDropDownBase) cboCompanies).DisplayMember = "Name";
      ((UltraDropDownBase) cboCompanies).ValueMember = "CompanyLocationID";
      MGASimpleComboBox cboChargeCodes = this.cboChargeCodes;
      ((UltraGridBase) cboChargeCodes).DataSource = (object) this.dvChargeCodes;
      ((UltraDropDownBase) cboChargeCodes).DisplayMember = "ChargeName";
      ((UltraDropDownBase) cboChargeCodes).ValueMember = "ChargeCode";
      MGASimpleComboBox cboOffices = this.cboOffices;
      ((UltraGridBase) cboOffices).DataSource = (object) this.dvOffices;
      ((UltraDropDownBase) cboOffices).DisplayMember = "Location";
      ((UltraDropDownBase) cboOffices).ValueMember = "OfficeID";
      UltraDropDown ddChargeCodes = this.ddChargeCodes;
      ((UltraGridBase) ddChargeCodes).DataSource = (object) this.ds.tblFin_PolicyCharges;
      ((UltraDropDownBase) ddChargeCodes).DisplayMember = "ChargeName";
      ((UltraDropDownBase) ddChargeCodes).ValueMember = "ChargeCode";
      UltraDropDown ddOffices = this.ddOffices;
      ((UltraGridBase) ddOffices).DataSource = (object) this.ds.tblClientOffices;
      ((UltraDropDownBase) ddOffices).DisplayMember = "Location";
      ((UltraDropDownBase) ddOffices).ValueMember = "OfficeID";
      ((UltraGridBase) this.dgOptions).DataSource = (object) this.ds.tblQuoteOptions;
      this._gridLayout.Position = 0L;
      ((UltraGridBase) this.dgOptions).DisplayLayout.Load((Stream) this._gridLayout);
      ((UltraGridBase) this.dgOptions).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  public new bool CanCreateNewNote => true;

  Guid IRecreatableEntity.EntityGUID => this.Rater.QuoteGuid;

  string IRecreatableEntity.PrivatelyEntityName => "Policy Detail";

  new string IRecreatableEntity.RecreateTypeName
  {
    get => "MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail";
  }

  public event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  new string IRecreatableEntity.EntityName => this.Rater.EntityName;

  new bool IRecreatableEntity.CanReCreateEntity => false;

  new bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    bool flag;
    return flag;
  }

  new Guid IRecreatableEntity.ControlGUID => Guid.Empty;

  new bool IRecreatableEntity.HasControlGUID => false;

  public Guid? LogIdentifier => new Guid?(new Guid("{2DFA249B-E4DF-436C-9ECF-6857A70CD30A}"));

  private void lnkFCW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowFormDialog(typeof (frmPolicyFCW), (object) this.Rater.Quote.QuoteID).Dispose();
  }

  private void txtFactor_ValueChanged(object sender, EventArgs e)
  {
    if (this.bmb.Position < 0 || !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.txtFactor.Value)))
      return;
    if (Decimal.Compare(Conversions.ToDecimal(this.txtFactor.Value), this._factor) != 0)
      this.ds.tblQuoteOptionGeneric[this.bmb.Position].UserOverrideFactor = Conversions.ToDecimal(this.txtFactor.Value);
    else
      this.ds.tblQuoteOptionGeneric[this.bmb.Position].SetUserOverrideFactorNull();
  }

  private void lnkNewOption_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.AddNewOption();
    this.dbSave.PerformAction(DBSaveUIAction.ClickNewButton);
  }

  private void lnkPremiumAllocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this._frmPremiumAllocation = (frmPremiumAllocation) FormSettings.ShowForm(typeof (frmPremiumAllocation), (object) this.Quote.QuoteGuid, (object) this.GenericRater);
    this._frmPremiumAllocation.Closing += new CancelEventHandler(this.frmPremiumAllocation_Closing);
  }

  private void frmPremiumAllocation_Closing(object sender, CancelEventArgs e)
  {
    if (this._frmPremiumAllocation == null)
      return;
    this._frmPremiumAllocation.Closing -= new CancelEventHandler(this.frmPremiumAllocation_Closing);
    if (this._frmPremiumAllocation.Exported)
    {
      this.LoadPremiums();
      try
      {
        foreach (dsRaterGeneric.tblQuoteOptionsRow tblQuoteOption in (TypedTableBase<dsRaterGeneric.tblQuoteOptionsRow>) this.ds.tblQuoteOptions)
          this.RefreshPremiums(tblQuoteOption.QuoteOptionGUID);
      }
      finally
      {
        IEnumerator<dsRaterGeneric.tblQuoteOptionsRow> enumerator;
        enumerator?.Dispose();
      }
    }
    this._frmPremiumAllocation = (frmPremiumAllocation) null;
  }

  private void LoadPremiums()
  {
    this.ds.tblQuoteOptionGeneric.Clear();
    this.ds.tblQuoteOptions.Clear();
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daOptions, (DataTable) this.ds.tblQuoteOptions);
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daOptionsGeneric, (DataTable) this.ds.tblQuoteOptionGeneric);
    if (!this._quote.IsBound)
    {
      try
      {
        foreach (dsRaterGeneric.tblQuoteOptionsRow tblQuoteOption in (TypedTableBase<dsRaterGeneric.tblQuoteOptionsRow>) this.ds.tblQuoteOptions)
        {
          if (tblQuoteOption.GettblQuoteOptionGenericRows().Length == 0)
          {
            int quoteOptionId = tblQuoteOption.QuoteOptionID;
            tblQuoteOption.Delete();
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET InstallmentBillingQuoteOptionID=NULL WHERE InstallmentBillingQuoteOptionID=@ID", new object[2]
            {
              (object) "@ID",
              (object) quoteOptionId
            });
          }
        }
      }
      finally
      {
        IEnumerator<dsRaterGeneric.tblQuoteOptionsRow> enumerator;
        enumerator?.Dispose();
      }
      try
      {
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daOptions, (DataTable) this.ds.tblQuoteOptions);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
        ProjectData.ClearProjectError();
      }
    }
    this.ExpandAllRows();
  }

  private void ExpandAllRows()
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.ExpandAllRows));
    }
    else
    {
      try
      {
        if (this.dgOptions == null || ((UltraGridBase) this.dgOptions).Rows == null)
          return;
        ((UltraGridBase) this.dgOptions).Rows.ExpandAll(true);
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void SetAdditionalComments(string comments)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new frmRaterGeneric.SetAdditionalCommentsHandler(this.SetAdditionalComments), (object) comments);
    else
      this.txtAdditionalComments.Text = comments;
  }

  private void AddGenericLimitsRow()
  {
    dsRaterGeneric.tblGenericLimitsRow row = this.ds.tblGenericLimits.NewtblGenericLimitsRow();
    row.QuoteID = this.Rater.Quote.QuoteID;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT QuoteAdditionalComments FROM tblCompanyLines WITH(NOLOCK) WHERE CompanyLineGUID = dbo.GetQuoteCompanyLineGuid(@QuoteGuid)", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.Rater.QuoteGuid
    }));
    if (objectValue == DBNull.Value)
    {
      row.SetAdditionalCommentsNull();
    }
    else
    {
      row.AdditionalComments = objectValue.ToString();
      this.SetAdditionalComments(row.AdditionalComments);
    }
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT Perils, Covering, Valuation, Excluding, Comments  FROM tblCompanyLineGenericQuoteWording WHERE CompanyLineID=@CompanyLineID", new object[2]
    {
      (object) "@CompanyLineID",
      (object) this.Quote.CompanyLine.CompanyLineID
    });
    if (dataRow != null)
    {
      dsRaterGeneric.tblGenericLimitsRow genericLimitsRow = row;
      if (dataRow["Perils"] != DBNull.Value)
        genericLimitsRow.Perils = (string) dataRow["Perils"];
      if (dataRow["Covering"] != DBNull.Value)
        genericLimitsRow.Covering = (string) dataRow["Covering"];
      if (dataRow["Valuation"] != DBNull.Value)
        genericLimitsRow.Valuation = (string) dataRow["Valuation"];
      if (dataRow["Excluding"] != DBNull.Value)
        genericLimitsRow.Excluding = (string) dataRow["Excluding"];
      if (dataRow["Comments"] != DBNull.Value)
        genericLimitsRow.AdditionalComments = (string) dataRow["Comments"];
    }
    this.ds.tblGenericLimits.AddtblGenericLimitsRow(row);
  }

  private void CalculateFactor()
  {
    if (!this.Quote.IsEndorsement)
      return;
    int days = this.Quote.ExpirationDate.Subtract(this.Quote.EffectiveDate).Days;
    if (!((UltraToggleEditorBase) this.chkIncludeLeapYear).Checked)
      days -= this.GetLeapDays(this.Quote.EffectiveDate, this.Quote.ExpirationDate);
    DateTime dateTime = this.dtEffective.DateTime;
    DateTime expirationDate = this.Quote.ExpirationDate;
    if (this.rbShortRate.Checked)
      this._factor = MGASystems.Data.Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.CalculateShortRateFactor2(@policyDays, @startDate, @endDate, @IncludeLeapYear)", new object[8]
      {
        (object) "@policyDays",
        (object) days,
        (object) "@startDate",
        (object) dateTime,
        (object) "@endDate",
        (object) expirationDate,
        (object) "@IncludeLeapYear",
        (object) ((UltraToggleEditorBase) this.chkIncludeLeapYear).Checked
      })), 1M);
    else if (this.rbProRata.Checked)
    {
      this._factor = MGASystems.Data.Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.CalculateProRata2(@policyDays, @startDate, @endDate, @IncludeLeapYear)", new object[8]
      {
        (object) "@policyDays",
        (object) days,
        (object) "@startDate",
        (object) dateTime,
        (object) "@endDate",
        (object) expirationDate,
        (object) "@IncludeLeapYear",
        (object) ((UltraToggleEditorBase) this.chkIncludeLeapYear).Checked
      })), 1M);
      if (this._roundProRataFactor)
        this._factor = Math.Round(this._factor, 3);
    }
    else
      this._factor = 1M;
    if (this.bmb.Position == -1)
      return;
    this.ds.tblQuoteOptionGeneric[this.bmb.Position].Factor = this._factor;
    this.txtFactor.Value = (object) this._factor;
  }

  private int GetLeapDays(DateTime startDate, DateTime endDate)
  {
    int leapDays = 0;
    Dictionary<string, DbParameter> dictionary = DefaultDatabase.DiscoverParameters("dbo.CalculateLeapDaysInRange");
    dictionary["@StartDate"].Value = (object) startDate;
    dictionary["@EndDate"].Value = (object) endDate;
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.CalculateLeapDaysInRange", 180, (CommandArgumentType) 2, new object[1]
    {
      (object) dictionary
    });
    DbParameter dbParameter = dictionary["@LeapDays"];
    if (!MGASystems.Data.Utility.IsNull(RuntimeHelpers.GetObjectValue(dbParameter.Value)))
      leapDays = Conversions.ToInteger(dbParameter.Value);
    return leapDays;
  }

  private void dtEffective_ValueChanged(object sender, EventArgs e) => this.CalculateFactor();

  private void hlkAddComments_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    string DefaultResponse = (string) null;
    dsRaterGeneric.tblQuoteOptionsRow tblQuoteOptionsRow = this.ds.tblQuoteOptionGeneric[this.bmb.Position].tblQuoteOptionsRow;
    if (!tblQuoteOptionsRow.IsAdditionalCommentsNull())
      DefaultResponse = tblQuoteOptionsRow.AdditionalComments;
    string Left = Interaction.InputBox("Please enter the comments for this premium", "Premium Comments", DefaultResponse);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, string.Empty, false) != 0)
      tblQuoteOptionsRow.AdditionalComments = Left;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteOptions SET AdditionalComments=@AdditionalComments WHERE QuoteOptionID=@QOID", new object[4]
    {
      (object) "@QOID",
      (object) tblQuoteOptionsRow.QuoteOptionID,
      (object) "@AdditionalComments ",
      (object) tblQuoteOptionsRow.AdditionalComments
    });
    tblQuoteOptionsRow.AcceptChanges();
  }

  private void AddNewOption()
  {
    dsRaterGeneric.tblQuoteOptionsRow row1 = this.ds.tblQuoteOptions.NewtblQuoteOptionsRow();
    row1.QuoteOptionGUID = Guid.NewGuid();
    row1.DateCreated = DateAndTime.Now;
    row1.LineGUID = this.Rater.LineGuid;
    row1.QuoteGUID = this.Rater.QuoteGuid;
    row1.Premium = 0M;
    this.ds.tblQuoteOptions.AddtblQuoteOptionsRow(row1);
    foreach (UltraGridRow row2 in ((UltraGridBase) this.dgOptions).Rows)
    {
      if (row2.Band.Index == 0 && row2.Cells["QuoteOptionGuid"].Value.Equals((object) row1.QuoteOptionGUID))
      {
        ((UltraGridBase) this.dgOptions).ActiveRow = row2;
        break;
      }
    }
  }

  private void cboState_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.bmb.Position == -1 || MGASystems.Data.Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboState.Value)))
      return;
    this.ds.tblQuoteOptionGeneric[this.bmb.Position].StateID = this.cboState.Value.ToString();
    this.dvChargeCodes.RowFilter = $"StateID='{this.cboState.Value.ToString()}'";
    if (this.dvChargeCodes.Count == 1)
    {
      ((UltraDropDownBase) this.cboChargeCodes).SelectedRow = ((UltraGridBase) this.cboChargeCodes).Rows[0];
      this.ds.tblQuoteOptionGeneric[this.bmb.Position].ChargeCode = Conversions.ToInteger(this.cboChargeCodes.Value);
    }
    else
      ((UltraDropDownBase) this.cboChargeCodes).SelectedRow = (UltraGridRow) null;
    this.Cursor = MgaCursors.WaitCursor;
    MDIControls.Instance.StatusBarText = "Finding available offices...";
    try
    {
      this.cmdOfficeLines.Parameters["@CompanyLineGuid"].Value = (object) new CompanyLine(this.Quote.CompanyLocationGuid, this.Quote.LineGuid, this.cboState.Value.ToString()).CompanyLineGuid;
      this.cmdOfficeLines.CommandTimeout = 300;
      this.cnSQL.Open();
      SqlDataReader sqlDataReader = this.cmdOfficeLines.ExecuteReader(CommandBehavior.SingleResult);
      this.dvOffices.RowFilter = "0=1";
      while (sqlDataReader.Read())
      {
        DataView dvOffices;
        string str = $"{(dvOffices = this.dvOffices).RowFilter} OR OfficeID={sqlDataReader[0].ToString()}";
        dvOffices.RowFilter = str;
      }
      sqlDataReader.Close();
      this.cnSQL.Close();
      if (this.dvOffices.Count == 1)
      {
        ((UltraDropDownBase) this.cboOffices).SelectedRow = ((UltraGridBase) this.cboOffices).Rows[0];
        this.ds.tblQuoteOptionGeneric[this.bmb.Position].OfficeID = Conversions.ToInteger(this.cboOffices.Value);
      }
      if (this.dvChargeCodes.Count != 1 || this.dvOffices.Count != 1)
        return;
      ((TextEditorControlBase) this.txtAmount).Focus();
    }
    finally
    {
      this.cnSQL.Close();
      this.Cursor = MgaCursors.Default;
      MDIControls.Instance.StatusBarText = string.Empty;
    }
  }

  private bool ValidForm()
  {
    bool flag1 = true;
    bool flag2;
    if (this.bmb.Position == -1)
    {
      flag2 = false;
    }
    else
    {
      Guid quoteOptionGuid = this.ds.tblQuoteOptionGeneric[this.bmb.Position].QuoteOptionGUID;
      foreach (UltraTab tab in ((UltraTabControlBase) this.MgaTab1).Tabs)
      {
        try
        {
          foreach (Control control in ((Control) tab.TabPage).Controls)
          {
            if (control is MGASimpleComboBox && ((SubObjectBase) tab).Tag != null && ((SubObjectBase) tab).Tag.Equals((object) "Validate"))
            {
              if (((UltraCombo) control).Value == null)
              {
                this.err.SetError(control, "Please select a item from the list.");
                flag1 = false;
              }
              else
                this.err.SetError(control, string.Empty);
            }
            else if (control == this.txtAmount)
            {
              if (control.Text.Length == 0)
              {
                this.err.SetError(control, "Please enter an amount.");
                flag1 = false;
              }
              else if (!Versioned.IsNumeric((object) control.Text))
              {
                this.err.SetError(control, "Please enter an amount.");
                flag1 = false;
              }
              else
                this.err.SetError(control, string.Empty);
            }
            else if (control == this.txtCurrentAnnualPremium)
            {
              if (!this.ValidateAnnualPremium())
              {
                this.err.SetError(control, "Please enter an amount.");
                flag1 = false;
              }
              else
                this.err.SetError(control, string.Empty);
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
      if (flag1)
      {
        int integer1 = Conversions.ToInteger(this.cboChargeCodes.Value);
        int integer2 = Conversions.ToInteger(this.cboOffices.Value);
        string str = this.cboState.Value.ToString();
        if (this.ds.tblQuoteOptionGeneric.Select($"QuoteOptionGuid='{quoteOptionGuid.ToString()}' AND ChargeCode={integer1.ToString()} AND OfficeID={integer2.ToString()} AND StateID='{str.ToString()}'").Length > 1)
        {
          this.err.SetError((Control) this.cboChargeCodes, "This premium item already exists.");
          flag1 = false;
        }
      }
      if (flag1)
      {
        try
        {
          foreach (dsRaterGeneric.tblQuoteOptionGenericRow optionGenericRow in (TypedTableBase<dsRaterGeneric.tblQuoteOptionGenericRow>) this.ds.tblQuoteOptionGeneric)
          {
            if (optionGenericRow.RowState != DataRowState.Added && optionGenericRow.RowState != DataRowState.Deleted && optionGenericRow.IsChargeCodeNull())
            {
              flag1 = false;
              break;
            }
          }
        }
        finally
        {
          IEnumerator<dsRaterGeneric.tblQuoteOptionGenericRow> enumerator;
          enumerator?.Dispose();
        }
      }
      flag2 = flag1;
    }
    return flag2;
  }

  protected virtual bool ValidateAnnualPremium()
  {
    bool flag = true;
    if (!MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("GenericRater.AnnualPremiumMandatory"))
    {
      if (((TextEditorControlBase) this.txtCurrentAnnualPremium).Text.Length > 0 && !Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtCurrentAnnualPremium).Text))
        flag = false;
    }
    else if (((TextEditorControlBase) this.txtCurrentAnnualPremium).Text.Length == 0)
      flag = false;
    else if (!Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtCurrentAnnualPremium).Text))
      flag = false;
    return flag;
  }

  private void RefreshPremiums(Guid quoteOptionGuid)
  {
    QuoteOption quoteOption = new QuoteOption(quoteOptionGuid);
    RaterGeneric.RefreshPremiums(quoteOption);
    this.LogIssue("frmRaterGeneric RefreshPremiums 1");
    MDIControls.Instance.StatusBarText = "Rating option...";
    this.Rater.RateOption(quoteOption.QuoteOptionGuid);
    this.LogIssue("frmRaterGeneric RefreshPremiums END");
  }

  private void CommitDataToDataset()
  {
    dsRaterGeneric.tblQuoteOptionGenericRow optionGenericRow = this.ds.tblQuoteOptionGeneric[this.bmb.Position];
    if (optionGenericRow.IsPremiumNull() || Decimal.Compare(optionGenericRow.Premium, Conversions.ToDecimal(((TextEditorControlBase) this.txtAmount).Text)) != 0)
      optionGenericRow.Premium = Conversions.ToDecimal(((TextEditorControlBase) this.txtAmount).Text);
    optionGenericRow.RoundToDollar = ((UltraToggleEditorBase) this.checkRoundPremiums).Checked;
    optionGenericRow.IncludeLeapYear = ((UltraToggleEditorBase) this.chkIncludeLeapYear).Checked;
    if (optionGenericRow.IsStateIDNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(optionGenericRow.StateID, this.cboState.Value.ToString(), false) != 0)
      optionGenericRow.StateID = this.cboState.Value.ToString();
    if (optionGenericRow.IsChargeCodeNull() || optionGenericRow.ChargeCode != (int) this.cboChargeCodes.Value)
      optionGenericRow.ChargeCode = (int) this.cboChargeCodes.Value;
    if (optionGenericRow.IsOfficeIDNull() || optionGenericRow.OfficeID != (int) this.cboOffices.Value)
      optionGenericRow.OfficeID = (int) this.cboOffices.Value;
    if (optionGenericRow.IsEffectiveDateNull() || DateTime.Compare(optionGenericRow.EffectiveDate.Date, this.dtEffective.DateTime.Date) != 0)
      optionGenericRow.EffectiveDate = this.dtEffective.DateTime.Date;
    if (((TextEditorControlBase) this.txtCurrentAnnualPremium).Text.Length > 0)
      optionGenericRow.CurrentAnnualPremium = Conversions.ToDecimal(((TextEditorControlBase) this.txtCurrentAnnualPremium).Text);
    else
      optionGenericRow.SetCurrentAnnualPremiumNull();
    if (this.ds.tblGenericLimits.Count > 0)
      this.SaveGenericLimitInfo();
  }

  private void SavePerilsInfo(dsRaterGeneric.tblGenericLimitsRow dr)
  {
    if ((!dr.IsPerilsNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPerils.Text, string.Empty, false) == 0) && (dr.IsPerilsNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr.Perils, this.txtPerils.Text, false) == 0))
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPerils.Text, string.Empty, false) == 0)
      dr.SetPerilsNull();
    else
      dr.Perils = this.txtPerils.Rtf;
  }

  private void SaveCoveringInfo(dsRaterGeneric.tblGenericLimitsRow dr)
  {
    if ((!dr.IsCoveringNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCovering.Text, string.Empty, false) == 0) && (dr.IsCoveringNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr.Covering, this.txtCovering.Text, false) == 0))
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCovering.Text, string.Empty, false) == 0)
      dr.SetCoveringNull();
    else
      dr.Covering = this.txtCovering.Rtf;
  }

  private void SaveValuationInfo(dsRaterGeneric.tblGenericLimitsRow dr)
  {
    if ((!dr.IsValuationNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtValuation.Text, string.Empty, false) == 0) && (dr.IsValuationNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr.Valuation, this.txtValuation.Text, false) == 0))
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtValuation.Text, string.Empty, false) == 0)
      dr.SetValuationNull();
    else
      dr.Valuation = this.txtValuation.Rtf;
  }

  private void SaveExcludingInfo(dsRaterGeneric.tblGenericLimitsRow dr)
  {
    if ((!dr.IsExcludingNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtExcluding.Text, string.Empty, false) == 0) && (dr.IsExcludingNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr.Excluding, this.txtExcluding.Text, false) == 0))
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtExcluding.Text, string.Empty, false) == 0)
      dr.SetExcludingNull();
    else
      dr.Excluding = this.txtExcluding.Rtf;
  }

  private void SaveAdditionalComments(dsRaterGeneric.tblGenericLimitsRow dr)
  {
    if ((!dr.IsAdditionalCommentsNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAdditionalComments.Text, string.Empty, false) == 0) && (dr.IsAdditionalCommentsNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr.AdditionalComments, this.txtAdditionalComments.Text, false) == 0))
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAdditionalComments.Text, string.Empty, false) == 0)
      dr.SetAdditionalCommentsNull();
    else
      dr.AdditionalComments = this.txtAdditionalComments.Rtf;
  }

  private void SaveLimits(dsRaterGeneric.tblGenericLimitsRow dr)
  {
    if (dr.IsLimitNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtLimit.Text, string.Empty, false) != 0 || !dr.IsLimitNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr.Limit, this.txtLimit.Text, false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtLimit.Text, string.Empty, false) == 0)
        dr.SetLimitNull();
      else
        dr.Limit = this.txtLimit.Rtf;
    }
    this.SavePolicyLimit(dr);
  }

  protected virtual void SavePolicyLimit(dsRaterGeneric.tblGenericLimitsRow dr)
  {
    if ((!dr.IsPolicyLimitNull() || this.txtPolicyLimit.Value == null) && (dr.IsPolicyLimitNull() || Decimal.Compare(dr.PolicyLimit, Conversions.ToDecimal(this.txtPolicyLimit.Value)) == 0))
      return;
    if (Decimal.Compare(Conversions.ToDecimal(this.txtPolicyLimit.Value), 0M) == 0)
      dr.SetPolicyLimitNull();
    else
      dr.PolicyLimit = Conversions.ToDecimal(this.txtPolicyLimit.Value);
  }

  private void SaveGenericLimitInfo()
  {
    dsRaterGeneric.tblGenericLimitsRow tblGenericLimit = this.ds.tblGenericLimits[0];
    this.SavePerilsInfo(tblGenericLimit);
    this.SaveCoveringInfo(tblGenericLimit);
    this.SaveValuationInfo(tblGenericLimit);
    this.SaveExcludingInfo(tblGenericLimit);
    this.SaveAdditionalComments(tblGenericLimit);
    this.SaveLimits(tblGenericLimit);
    if (tblGenericLimit.IsDeductibleNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDeductible.Text, string.Empty, false) != 0 || !tblGenericLimit.IsDeductibleNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblGenericLimit.Deductible, this.txtDeductible.Text, false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDeductible.Text, string.Empty, false) == 0)
        tblGenericLimit.SetDeductibleNull();
      else
        tblGenericLimit.Deductible = this.txtDeductible.Rtf;
    }
    if (tblGenericLimit.IsSubLimitsNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSubLimits.Text, string.Empty, false) != 0 || !tblGenericLimit.IsSubLimitsNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblGenericLimit.SubLimits, this.txtSubLimits.Text, false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSubLimits.Text, string.Empty, false) == 0)
        tblGenericLimit.SetSubLimitsNull();
      else
        tblGenericLimit.SubLimits = this.txtSubLimits.Rtf;
    }
    if (tblGenericLimit.IsLimitNull() && tblGenericLimit.IsDeductibleNull() && tblGenericLimit.IsCoveringNull() && tblGenericLimit.IsExcludingNull() && tblGenericLimit.IsPerilsNull() && tblGenericLimit.IsValuationNull() && tblGenericLimit.IsAdditionalCommentsNull() && tblGenericLimit.IsSubLimitsNull() && tblGenericLimit.IsPolicyLimitNull())
    {
      if (tblGenericLimit.RowState == DataRowState.Added)
        this.ds.tblGenericLimits.RemovetblGenericLimitsRow(tblGenericLimit);
      else
        tblGenericLimit.Delete();
    }
    if (this.ds.tblGenericLimits.Count <= 0)
      return;
    this.GenericLimitsDataSaved((DataRow) tblGenericLimit);
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this._hasPremiumDistribution)
    {
      int num = (int) MessageBox.Show("Premium distribution data is available on this rater.\n\nPremium updates are done at this level. See 'Premium UI' link.", "Premium Distribution Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else if (!this.ValidForm())
      e.Cancel = true;
    else if (((UltraGridBase) this.dgOptions).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select an option row in the grid.", "Option Row not Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      this.Cursor = MgaCursors.WaitCursor;
      MDIControls.Instance.StatusBarText = "Saving premiums...";
      Guid QuoteOptionGUID;
      switch (((UltraGridBase) this.dgOptions).ActiveRow.Band.Index)
      {
        case 0:
          QuoteOptionGUID = (Guid) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["QuoteOptionGuid"].Value;
          break;
        case 1:
          QuoteOptionGUID = (Guid) ((UltraGridBase) this.dgOptions).ActiveRow.ParentRow.Cells["QuoteOptionGuid"].Value;
          break;
      }
      if (this.ds.tblCompanyLocations.Count > 0)
        this.ds.tblQuoteOptions.FindByQuoteOptionGUID(QuoteOptionGUID).CompanyLocationID = (int) this.cboCompanies.Value;
      this.CommitDataToDataset();
      if (this.ds.HasChanges())
      {
        if (!this.SaveDataToDatabase())
        {
          e.Cancel = true;
          return;
        }
        if (this.ds.tblGenericLimits.Count == 0)
          this.AddGenericLimitsRow();
        ThreadPool.QueueUserWorkItem(new WaitCallback(this.RateOptionThread));
      }
      this.EnablePremiumDistributionLink();
    }
  }

  private bool SaveDataToDatabase()
  {
    frmRaterGeneric frmRaterGeneric = this;
    this.ds.EnforceConstraints = false;
    bool database;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
    {
      try
      {
        if (frmRaterGeneric.ds.tblQuoteOptions.GetChanges() != null)
        {
          SqlDataAdapter daOptions = frmRaterGeneric.daOptions;
          daOptions.UpdateCommand.Transaction = (SqlTransaction) args.Transaction;
          daOptions.InsertCommand.Transaction = (SqlTransaction) args.Transaction;
          daOptions.DeleteCommand.Transaction = (SqlTransaction) args.Transaction;
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) frmRaterGeneric.daOptions, frmRaterGeneric.ds.tblQuoteOptions.GetChanges());
        }
        SqlDataAdapter daOptionsGeneric = frmRaterGeneric.daOptionsGeneric;
        daOptionsGeneric.UpdateCommand.Transaction = (SqlTransaction) args.Transaction;
        daOptionsGeneric.InsertCommand.Transaction = (SqlTransaction) args.Transaction;
        daOptionsGeneric.DeleteCommand.Transaction = (SqlTransaction) args.Transaction;
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) frmRaterGeneric.daOptionsGeneric, (DataTable) frmRaterGeneric.ds.tblQuoteOptionGeneric);
        SqlDataAdapter daGenericLimits = frmRaterGeneric.daGenericLimits;
        daGenericLimits.UpdateCommand.Transaction = (SqlTransaction) args.Transaction;
        daGenericLimits.InsertCommand.Transaction = (SqlTransaction) args.Transaction;
        daGenericLimits.DeleteCommand.Transaction = (SqlTransaction) args.Transaction;
        daGenericLimits.SelectCommand.Transaction = (SqlTransaction) args.Transaction;
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) frmRaterGeneric.daGenericLimits, (DataTable) frmRaterGeneric.ds.tblGenericLimits);
        frmRaterGeneric.ClientSave((SqlTransaction) args.Transaction);
        args.Transaction.Commit();
        database = true;
      }
      catch (SqlException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SqlException sqlException = ex1;
        try
        {
          if (args.Transaction != null)
            args.Transaction.Rollback();
        }
        catch (InvalidOperationException ex2)
        {
          ProjectData.SetProjectError((Exception) ex2);
          ErrorHandler.HandleError((Exception) new InvalidOperationException("Could not roll back transaction.", (Exception) sqlException));
          ProjectData.ClearProjectError();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sqlException.Procedure, "VerifySufficientPremiumForCredit", false) == 0)
        {
          int num = (int) MessageBox.Show(sqlException.Message, "Insufficient Premium For Credit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
          ErrorHandler.HandleError((Exception) sqlException);
        database = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        frmRaterGeneric.ds.EnforceConstraints = true;
        frmRaterGeneric.Cursor = MgaCursors.Default;
        MDIControls.Instance.StatusBarText = string.Empty;
      }
    }));
    return database;
  }

  private void RateOptionThread(object state)
  {
    this.BetterInvoke((Delegate) new frmRaterGeneric.RateOptionHandler(this.RateOption), (object) this.ds.tblQuoteOptionGeneric[this.bmb.Position].QuoteOptionGUID);
  }

  private void RateOption(Guid QuoteOptionGUID)
  {
    this.ds.tblQuoteOptions.AcceptChanges();
    try
    {
      foreach (dsRaterGeneric.tblQuoteOptionsRow tblQuoteOption in (TypedTableBase<dsRaterGeneric.tblQuoteOptionsRow>) this.ds.tblQuoteOptions)
      {
        object objectValue = RuntimeHelpers.GetObjectValue(this.ds.tblQuoteOptionGeneric.Compute("SUM(Premium)", $"QuoteOptionGuid='{tblQuoteOption.QuoteOptionGUID.ToString()}'"));
        if (!MGASystems.Data.Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) && (tblQuoteOption.IsPremiumNull() || Decimal.Compare(tblQuoteOption.Premium, (Decimal) objectValue) != 0))
          tblQuoteOption.Premium = (Decimal) objectValue;
      }
    }
    finally
    {
      IEnumerator<dsRaterGeneric.tblQuoteOptionsRow> enumerator;
      enumerator?.Dispose();
    }
    try
    {
      if (!MGASystems.IMS.NoteDocuments.Common.BlackBoxMode)
        this.Cursor = MgaCursors.WaitCursor;
      this.RefreshPremiums(QuoteOptionGUID);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      if (!MGASystems.IMS.NoteDocuments.Common.BlackBoxMode)
        this.Cursor = MgaCursors.Default;
    }
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (this._hasPremiumDistribution)
    {
      int num = (int) MessageBox.Show("Premium distribution data is available on this rater.\n\nPremium updates are done at this level. See 'Premium UI' link.", "Premium Distribution Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
    {
      if (this.ds.tblQuoteOptions.Rows.Count == 0)
        this.AddNewOption();
      if (((UltraGridBase) this.dgOptions).ActiveRow == null)
      {
        int num = (int) MessageBox.Show("Please select a row in the grid where this premium item will be added.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        e.Cancel = true;
      }
      else
      {
        if (this.ds.tblGenericLimits.Count == 0)
          this.AddGenericLimitsRow();
        Guid quoteOptionGuid;
        switch (((UltraGridBase) this.dgOptions).ActiveRow.Band.Index)
        {
          case 0:
            quoteOptionGuid = (Guid) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["QuoteOptionGuid"].Value;
            break;
          case 1:
            quoteOptionGuid = (Guid) ((UltraGridBase) this.dgOptions).ActiveRow.ParentRow.Cells["QuoteOptionGuid"].Value;
            break;
        }
        this.AddGenericRow(quoteOptionGuid);
        ((UltraGridBase) this.dgOptions).ActiveRow.ExpandAll();
        ((UltraGridBase) this.dgOptions).ActiveRow.ExpandAncestors();
        this.bmb.Position = this.ds.tblQuoteOptionGeneric.Count - 1;
        this.cboState.ValueChanged -= new EventHandler(this.cboState_SelectedIndexChanged);
        foreach (UltraTab tab in ((UltraTabControlBase) this.MgaTab1).Tabs)
        {
          try
          {
            foreach (Control control in ((Control) tab.TabPage).Controls)
            {
              if (control is MGASimpleComboBox)
              {
                ((MGASimpleComboBox) control).SelectedIndex = -1;
                ((MGASimpleComboBox) control).SelectedIndex = -1;
              }
              else if (control is MGATextBox)
                control.Text = string.Empty;
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        this.cboState.ValueChanged += new EventHandler(this.cboState_SelectedIndexChanged);
        if (this.ds.tblCompanyLocations.Count == 1)
          ((UltraDropDownBase) this.cboCompanies).SelectedRow = ((UltraGridBase) this.cboCompanies).Rows[0];
        if (this.ds.lstStates.Rows.Count == 1)
          ((UltraDropDownBase) this.cboState).SelectedRow = ((UltraGridBase) this.cboState).Rows[0];
        else if (this.ds.lstStates.FindByStateID(this.Quote.StateID) != null)
          this.cboState.Value = (object) this.Quote.StateID;
        try
        {
          if (this.ds.tblClientOffices.Count == 1)
            ((UltraDropDownBase) this.cboOffices).SelectedRow = ((UltraGridBase) this.cboOffices).Rows[0];
          else if (this.ds.tblClientOffices.FindByOfficeID(this._quotingOfficeID) != null)
            this.cboOffices.Value = (object) this._quotingOfficeID;
        }
        catch (IndexOutOfRangeException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) MessageBox.Show("Please authorize the client office for this company/line of business.", "Client Office Not Authorized", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          throw;
        }
        if (this.ds.tblQuoteOptionGeneric.Count == 1 && this.cboState.Value != null)
        {
          string str = $"ChargeID='PREM' AND StateID='{this.cboState.Value.ToString()}'";
          if (Conversions.ToInteger(this.ds.tblFin_PolicyCharges.Compute("COUNT(ChargeCode)", str)) == 1)
            this.cboChargeCodes.Value = (object) ((dsRaterGeneric.tblFin_PolicyChargesRow) this.ds.tblFin_PolicyCharges.Select(str)[0]).ChargeCode;
        }
        this.ShowLimitWording();
        this.ClientNew();
      }
    }
  }

  protected virtual void ClientNew()
  {
  }

  private void AddGenericRow(Guid quoteOptionGuid)
  {
    dsRaterGeneric.tblQuoteOptionGenericRow row = this.ds.tblQuoteOptionGeneric.NewtblQuoteOptionGenericRow();
    row.QuoteOptionGUID = quoteOptionGuid;
    row.Added = DateAndTime.Now;
    if (this.Quote.IsEndorsement)
    {
      row.EffectiveDate = this.Quote.EndorsementEffective;
      row.EndorsementCalcType = this.Quote.EndorsementCalcType;
      this.SelectRadioButton(row.EndorsementCalcType);
      this.dtEffective.Value = (object) row.EffectiveDate;
      this.CalculateFactor();
      row.Factor = this._factor;
      this.txtFactor.Value = (object) row.Factor;
    }
    else
    {
      if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("DefaultGenericRaterCalcTypeFlat"))
        this.rbFlat.Checked = true;
      row.EffectiveDate = this.Quote.EffectiveDate;
      row.Factor = 1M;
      this.txtFactor.Value = (object) 1;
    }
    this.dtEffective.DateTime = row.EffectiveDate;
    if (this.NotRoundingPremiumToDollar)
    {
      row.RoundToDollar = false;
      ((UltraToggleEditorBase) this.checkRoundPremiums).Checked = false;
    }
    else
    {
      row.RoundToDollar = true;
      ((UltraToggleEditorBase) this.checkRoundPremiums).Checked = true;
    }
    row.IncludeLeapYear = false;
    ((UltraToggleEditorBase) this.chkIncludeLeapYear).Checked = false;
    this.ds.tblQuoteOptionGeneric.AddtblQuoteOptionGenericRow(row);
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this._hasPremiumDistribution)
    {
      int num = (int) MessageBox.Show("Premium distribution data is available on this rater.\n\nPremium updates are done at this level. See 'Premium UI' link.", "Premium Distribution Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
    {
      if (((UltraGridBase) this.dgOptions).ActiveRow == null)
        return;
      if (((UltraGridBase) this.dgOptions).ActiveRow.Band.Index == 0)
      {
        int num = (int) MessageBox.Show("Please select a premium row to delete.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        if (MessageBox.Show("Are you sure you want to delete this premium?\n\nThis will remove any commissionable entities applied to this premium.", "Delete Option?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        {
          // ISSUE: variable of a compiler-generated type
          frmRaterGeneric._Closure\u0024__303\u002D0 closure3030_1;
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          frmRaterGeneric._Closure\u0024__303\u002D0 closure3030_2 = new frmRaterGeneric._Closure\u0024__303\u002D0(closure3030_1);
          // ISSUE: reference to a compiler-generated field
          closure3030_2.\u0024VB\u0024Me = this;
          MDIControls.Instance.MDIParent.Refresh();
          // ISSUE: reference to a compiler-generated field
          closure3030_2.\u0024VB\u0024Local_quoteOptionGuid = (Guid) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["QuoteOptionGuid"].Value;
          // ISSUE: reference to a compiler-generated field
          closure3030_2.\u0024VB\u0024Local_genericID = (int) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["GenericID"].Value;
          // ISSUE: reference to a compiler-generated field
          closure3030_2.\u0024VB\u0024Local_chargeCode = (int) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["ChargeCode"].Value;
          // ISSUE: reference to a compiler-generated field
          QuoteOption quoteOption = new QuoteOption(closure3030_2.\u0024VB\u0024Local_quoteOptionGuid);
          Decimal premiumWithCents = quoteOption.PremiumWithCents;
          int quoteOptionId = quoteOption.QuoteOptionID;
          // ISSUE: reference to a compiler-generated field
          if (this.ds.tblQuoteOptionGeneric.FindByGenericID(closure3030_2.\u0024VB\u0024Local_genericID).RowState != DataRowState.Added)
          {
            this.Cursor = MgaCursors.WaitCursor;
            // ISSUE: reference to a compiler-generated method
            DefaultDatabase.ExecuteTransaction(new EventHandler<ExecuteTransactionEventArgs>(closure3030_2._Lambda\u0024__0));
            // ISSUE: reference to a compiler-generated field
            if (QuoteOption.QuoteOptionExists(closure3030_2.\u0024VB\u0024Local_quoteOptionGuid))
            {
              // ISSUE: reference to a compiler-generated field
              this.RefreshPremiums(closure3030_2.\u0024VB\u0024Local_quoteOptionGuid);
            }
            CurrentUser.Instance.LogAction($"Deleted Option # {Conversions.ToString(quoteOptionId)} with premium of {premiumWithCents.ToString("c")} on control# {Conversions.ToString(this.Quote.ControlNo)}", this.Quote.QuoteGuid);
          }
        }
        e.Cancel = true;
        this.Reset();
      }
    }
  }

  private void SetScreenEnabled()
  {
    bool flag = this.dbSave.UIState == UIState.Editing;
    ((Control) this.dgOptions).Enabled = !flag;
    ((Control) this.cboCompanies).Enabled = this.ds.tblCompanyLocations.Count > 1 && flag;
    if (!this._isQuoteBound)
      this.lnkNewOption.Enabled = !flag && this.ds.tblQuoteOptions.Count > 0;
    else
      this.lnkNewOption.Enabled = !this._isQuoteBound;
    foreach (UltraTab tab in ((UltraTabControlBase) this.MgaTab1).Tabs)
    {
      if (tab.TabPage != this.tabExposure)
      {
        try
        {
          foreach (Control control in ((Control) tab.TabPage).Controls)
          {
            if (control == this.lnkPremiumAllocation)
              this.lnkPremiumAllocation.Enabled = !flag;
            else if (control == this.txtFactor || control == this.dtEffective || control is RadioButton)
              control.Enabled = this.Quote.IsEndorsement && flag;
            else if (control == this.linkOffsetTransaction || control == this.linkEndorsementOffsets)
              control.Enabled = this._isEndorsement && !flag;
            else if (control != this.dbSave && control != this.lnkNewOption)
              control.Enabled = flag;
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
    if (flag && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboChargeCodes.Text, string.Empty, false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboOffices.Text, string.Empty, false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboState.Text, string.Empty, false) != 0)
      ((TextEditorControlBase) this.txtAmount).Focus();
    this.linkOffsetTransaction.Enabled = !this._isQuoteBound;
    this.EnablePremiumDistributionLink();
    this.ClientSetScreenEnabled();
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e) => this.SetScreenEnabled();

  private void Reset()
  {
    if (this.bmb.Position == -1)
    {
      foreach (UltraTab tab in ((UltraTabControlBase) this.MgaTab1).Tabs)
      {
        try
        {
          foreach (Control control in ((Control) tab.TabPage).Controls)
          {
            if (control is MGASimpleComboBox)
            {
              ((MGASimpleComboBox) control).SelectedIndex = -1;
              ((MGASimpleComboBox) control).SelectedIndex = -1;
            }
            else if (control is MGATextBox)
              control.Text = string.Empty;
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
    this.dbSave.UIState = this.ds.tblQuoteOptionGeneric.Rows.Count <= 0 ? UIState.NoRecordsNotEditing : UIState.HasRecordsNotEditing;
    this.EnablePremiumDistributionLink();
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.tblQuoteOptionGeneric.RejectChanges();
    this.ds.tblQuoteOptions.RejectChanges();
    foreach (UltraTab tab in ((UltraTabControlBase) this.MgaTab1).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
          this.err.SetError(control, string.Empty);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    if (this.ds.tblQuoteOptionGeneric.Count > 0)
    {
      ((UltraGridBase) this.dgOptions).ActiveRow = (UltraGridRow) ((UltraGridBase) this.dgOptions).DisplayLayout.Bands[1].GetRowEnumerator((GridRowType) 1).Cast<object>().ElementAtOrDefault<object>(0);
      this.dgOptions_AfterRowActivate((object) this.dgOptions, new EventArgs());
    }
    this.ClientCancel();
    this.Reset();
  }

  private void dgOptions_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.Row.Cells["Premium"].Value)) || Decimal.Compare(Conversions.ToDecimal(e.Row.Cells["Premium"].Value), 0M) >= 0)
      return;
    e.Row.Cells["Premium"].Appearance.ForeColor = Color.Red;
  }

  private void SelectRadioButton(string calcType)
  {
    string Left = calcType;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "P", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "S", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "F", false) != 0)
          return;
        this.rbFlat.Checked = true;
      }
      else
        this.rbShortRate.Checked = true;
    }
    else
      this.rbProRata.Checked = true;
  }

  private void ShowLimitWording()
  {
    if (this.ds.tblGenericLimits.Count <= 0)
      return;
    dsRaterGeneric.tblGenericLimitsRow tblGenericLimit = this.ds.tblGenericLimits[0];
    if (tblGenericLimit.IsPerilsNull())
    {
      this.txtPerils.Text = string.Empty;
    }
    else
    {
      try
      {
        this.txtPerils.Rtf = tblGenericLimit.Perils;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtPerils.Text = tblGenericLimit.Perils;
        ProjectData.ClearProjectError();
      }
    }
    if (tblGenericLimit.IsCoveringNull())
    {
      this.txtCovering.Text = string.Empty;
    }
    else
    {
      try
      {
        this.txtCovering.Rtf = tblGenericLimit.Covering;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtCovering.Text = tblGenericLimit.Covering;
        ProjectData.ClearProjectError();
      }
    }
    if (tblGenericLimit.IsValuationNull())
    {
      this.txtValuation.Text = string.Empty;
    }
    else
    {
      try
      {
        this.txtValuation.Rtf = tblGenericLimit.Valuation;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtValuation.Text = tblGenericLimit.Valuation;
        ProjectData.ClearProjectError();
      }
    }
    if (tblGenericLimit.IsExcludingNull())
    {
      this.txtExcluding.Text = string.Empty;
    }
    else
    {
      try
      {
        this.txtExcluding.Rtf = tblGenericLimit.Excluding;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtExcluding.Text = tblGenericLimit.Excluding;
        ProjectData.ClearProjectError();
      }
    }
    if (tblGenericLimit.IsLimitNull())
    {
      this.txtLimit.Text = string.Empty;
    }
    else
    {
      try
      {
        this.txtLimit.Rtf = tblGenericLimit.Limit;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtLimit.Text = tblGenericLimit.Limit;
        ProjectData.ClearProjectError();
      }
    }
    this.PopulatePolicyLimit(tblGenericLimit);
    if (tblGenericLimit.IsDeductibleNull())
    {
      this.txtDeductible.Text = string.Empty;
    }
    else
    {
      try
      {
        this.txtDeductible.Rtf = tblGenericLimit.Deductible;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtDeductible.Text = tblGenericLimit.Deductible;
        ProjectData.ClearProjectError();
      }
    }
    if (tblGenericLimit.IsAdditionalCommentsNull())
    {
      this.txtAdditionalComments.Text = string.Empty;
    }
    else
    {
      try
      {
        this.txtAdditionalComments.Rtf = tblGenericLimit.AdditionalComments;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtAdditionalComments.Text = tblGenericLimit.AdditionalComments;
        ProjectData.ClearProjectError();
      }
    }
    if (tblGenericLimit.IsSubLimitsNull())
    {
      this.txtSubLimits.Text = string.Empty;
    }
    else
    {
      try
      {
        this.txtSubLimits.Rtf = tblGenericLimit.SubLimits;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtSubLimits.Text = tblGenericLimit.SubLimits;
        ProjectData.ClearProjectError();
      }
    }
  }

  protected virtual void PopulatePolicyLimit(dsRaterGeneric.tblGenericLimitsRow dr)
  {
    if (dr.IsPolicyLimitNull())
      this.txtPolicyLimit.Value = (object) 0M;
    else
      this.txtPolicyLimit.Value = (object) dr.PolicyLimit;
  }

  private void dgOptions_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgOptions).ActiveRow.Band.Index == 1)
    {
      Guid QuoteOptionGUID = (Guid) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["QuoteOptionGuid"].Value;
      Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgOptions).ActiveRow.Cells["GenericID"].Value), "GenericID", (DataTable) this.ds.tblQuoteOptionGeneric, this.bmb);
      this.rbProRata.CheckedChanged -= new EventHandler(this.CalcType_CheckedChanged);
      this.rbFlat.CheckedChanged -= new EventHandler(this.CalcType_CheckedChanged);
      this.rbShortRate.CheckedChanged -= new EventHandler(this.CalcType_CheckedChanged);
      if (this.ds.tblQuoteOptionGeneric[this.bmb.Position].RowState != DataRowState.Deleted && !this.ds.tblQuoteOptionGeneric[this.bmb.Position].IsEndorsementCalcTypeNull())
        this.SelectRadioButton(this.ds.tblQuoteOptionGeneric[this.bmb.Position].EndorsementCalcType);
      this.rbProRata.CheckedChanged += new EventHandler(this.CalcType_CheckedChanged);
      this.rbFlat.CheckedChanged += new EventHandler(this.CalcType_CheckedChanged);
      this.rbShortRate.CheckedChanged += new EventHandler(this.CalcType_CheckedChanged);
      ((UltraToggleEditorBase) this.checkRoundPremiums).Checked = this.ds.tblQuoteOptionGeneric[this.bmb.Position].RoundToDollar;
      ((UltraToggleEditorBase) this.chkIncludeLeapYear).CheckedChanged -= new EventHandler(this.chkIncludeLeapYear_CheckedChanged);
      if (this.ds.tblQuoteOptionGeneric[this.bmb.Position].IsIncludeLeapYearNull())
        ((UltraToggleEditorBase) this.chkIncludeLeapYear).Checked = false;
      else
        ((UltraToggleEditorBase) this.chkIncludeLeapYear).Checked = this.ds.tblQuoteOptionGeneric[this.bmb.Position].IncludeLeapYear;
      ((UltraToggleEditorBase) this.chkIncludeLeapYear).CheckedChanged += new EventHandler(this.chkIncludeLeapYear_CheckedChanged);
      this.cboState.ValueChanged -= new EventHandler(this.cboState_SelectedIndexChanged);
      this.dtEffective.ValueChanged -= new EventHandler(this.dtEffective_ValueChanged);
      this.dtEffective.DateTime = (DateTime) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["EffectiveDate"].Value;
      this.dtEffective.ValueChanged += new EventHandler(this.dtEffective_ValueChanged);
      if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("GenericRater.RestrictCompanyByOption"))
      {
        this.ds.tblCompanyLocations.Clear();
        DefaultDatabase.LoadDataTable((DataTable) this.ds.tblCompanyLocations, "spGenericRaterCompaniesByOption", new object[2]
        {
          (object) "@QuoteOptionGuid",
          (object) QuoteOptionGUID
        });
      }
      if (this.ds.tblQuoteOptions.FindByQuoteOptionGUID(QuoteOptionGUID).RowState != DataRowState.Deleted && !this.ds.tblQuoteOptions.FindByQuoteOptionGUID(QuoteOptionGUID).IsCompanyLocationIDNull())
        this.cboCompanies.Value = (object) this.ds.tblQuoteOptions.FindByQuoteOptionGUID(QuoteOptionGUID).CompanyLocationID;
      else
        ((UltraDropDownBase) this.cboCompanies).SelectedRow = ((UltraGridBase) this.cboCompanies).Rows[0];
      this.cboState.Value = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgOptions).ActiveRow.Cells["StateID"].Value);
      this.cboState_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
      this.cboState.ValueChanged += new EventHandler(this.cboState_SelectedIndexChanged);
      this.dvChargeCodes.RowFilter = $"StateID='{this.cboState.Value.ToString()}'";
      this.cboChargeCodes.Value = (object) (int) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["ChargeCode"].Value;
      this.cboOffices.Value = (object) (int) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["OfficeID"].Value;
      ((UltraNumericEditorBase) this.txtFactor).ValueChanged -= new EventHandler(this.txtFactor_ValueChanged);
      if (((UltraGridBase) this.dgOptions).ActiveRow.Cells["UserOverrideFactor"].Value == DBNull.Value)
        this.txtFactor.Value = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgOptions).ActiveRow.Cells["Factor"].Value);
      else
        this.txtFactor.Value = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgOptions).ActiveRow.Cells["UserOverrideFactor"].Value);
      ((UltraNumericEditorBase) this.txtFactor).ValueChanged += new EventHandler(this.txtFactor_ValueChanged);
      ((TextEditorControlBase) this.txtAmount).Text = Strings.FormatNumber(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgOptions).ActiveRow.Cells["Premium"].Value), 2);
      if (((UltraGridBase) this.dgOptions).ActiveRow.Cells["CurrentAnnualPremium"].Value != DBNull.Value)
        ((TextEditorControlBase) this.txtCurrentAnnualPremium).Text = Strings.FormatNumber((object) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["CurrentAnnualPremium"].Value.ToString(), 2);
      else
        ((TextEditorControlBase) this.txtCurrentAnnualPremium).Text = string.Empty;
      this.ShowLimitWording();
      this.ds.tblQuoteOptionGeneric[this.bmb.Position].AcceptChanges();
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    }
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    this.ClientAfterRowActivate();
  }

  private void cboChargeCodes_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboChargeCodes.Text, string.Empty, false) == 0)
      return;
    this.ds.tblQuoteOptionGeneric[this.bmb.Position].ChargeCode = (int) this.cboChargeCodes.Value;
  }

  private void cboOffices_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboOffices.Text, string.Empty, false) == 0)
      return;
    this.ds.tblQuoteOptionGeneric[this.bmb.Position].OfficeID = (int) this.cboOffices.Value;
  }

  private void cnSQL_InfoMessage(object sender, SqlInfoMessageEventArgs e)
  {
    int num = (int) MessageBox.Show(e.Message, "Premium Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
  }

  private void CalcType_CheckedChanged(object sender, EventArgs e)
  {
    if (this.bmb.Position == -1)
      return;
    dsRaterGeneric.tblQuoteOptionGenericRow optionGenericRow = this.ds.tblQuoteOptionGeneric[this.bmb.Position];
    if (this.rbShortRate.Checked)
      optionGenericRow.EndorsementCalcType = "S";
    else if (this.rbFlat.Checked)
      optionGenericRow.EndorsementCalcType = "F";
    else if (this.rbProRata.Checked)
      optionGenericRow.EndorsementCalcType = "P";
    this.CalculateFactor();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._hlkAddComments != null)
      {
        this._hlkAddComments.HyperLinkOpening -= new CancelEventHandler(this.hlkAddComments_HyperLinkOpening);
        ((DisposableObject) this._hlkAddComments).Dispose();
      }
    }
    base.Dispose(disposing);
  }

  private void MgaTab1_SelectedTabChanged(object sender, SelectedTabChangedEventArgs e)
  {
    if (((UltraTabControlBase) this.MgaTab1).SelectedTab.TabPage != this.tabExposure || this.listExposureLines.Items.Count != 0)
      return;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ShowExposureCaptures));
  }

  private void ShowExposureCaptures(object state)
  {
    ExposureCaptureAttribute searchAttribute = new ExposureCaptureAttribute();
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) searchAttribute);
    int index = 0;
    while (index < typeArray.Length)
    {
      Type type = typeArray[index];
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new frmRaterGeneric.AddExposureCaptureHandler(this.AddExposureCapture), (object) ((ExposureCaptureAttribute) ObjectFactory.GetAttributeFromType(type, (Attribute) searchAttribute)).LineName, (object) type);
      checked { ++index; }
    }
  }

  private void AddExposureCapture(string captureName, Type t)
  {
    try
    {
      foreach (frmRaterGeneric.ExposureCaptureItem exposureCaptureItem in this.listExposureLines.Items)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(exposureCaptureItem.ToString(), captureName, false) == 0)
          return;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.listExposureLines.Items.Add((object) new frmRaterGeneric.ExposureCaptureItem(captureName, t));
    this.listExposureLines.SelectedIndex = 0;
  }

  private void btnExposure_Click(object sender, EventArgs e)
  {
    if (this.listExposureLines.SelectedItem == null)
      return;
    object objectValue = RuntimeHelpers.GetObjectValue(ObjectFactory.Instance.CreateObject(((frmRaterGeneric.ExposureCaptureItem) this.listExposureLines.SelectedItem).CaptureType));
    IExposureCapture exposureCapture;
    Form form;
    if (objectValue is MgaMdiChildContainer)
    {
      MgaMdiChildContainer mdiChildContainer = (MgaMdiChildContainer) objectValue;
      exposureCapture = (IExposureCapture) mdiChildContainer.MgaMdiChild;
      form = (Form) mdiChildContainer;
    }
    else
    {
      exposureCapture = (IExposureCapture) objectValue;
      form = (Form) objectValue;
    }
    exposureCapture.SetQuoteId(this.Quote.QuoteID);
    try
    {
      form.ShowInTaskbar = false;
      int num = (int) form.ShowDialog();
    }
    finally
    {
      form.Dispose();
    }
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged1;

  private void dbSave_ClickedSave(object sender, EventArgs e)
  {
    if (!this._limitsDataChanged || !this.Quote.IsOriginalQuoteRecord)
      return;
    if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblQuotes WITH (NOLOCK) WHERE SubmissionGroupGuid = @SubGroupGuid AND LineGUID = @LineGuid AND QuoteGuid <> @QuoteGuid", new object[6]
    {
      (object) "@SubGroupGuid",
      (object) this.Quote.SubmissionGroupGuid,
      (object) "@QuoteGuid",
      (object) this.Quote.QuoteGuid,
      (object) "@LineGuid",
      (object) this.Quote.LineGuid
    }) <= 0)
      return;
    this.UpdateOtherSubmissionQuotes(this.Quote.QuoteGuid, this.Quote.SubmissionGroupGuid, this.Quote.LineGuid);
  }

  private void GenericLimitsDataSaved(DataRow dr)
  {
    this._limitsDataChanged = Database.DataHasChanged(dr);
  }

  private void linkOffsetTransaction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to offset the previous transaction?", "Offset Previous Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    Guid quoteOptionGuid = DefaultDatabase.ExecuteScalar<Guid>("dbo.spOffsetPreviousTransaction", new object[4]
    {
      (object) "@controlNo",
      (object) this._quote.ControlNo,
      (object) "@lineGuid",
      (object) this.Rater.LineGuid
    });
    this.RefreshPremiums(quoteOptionGuid);
    QuoteOption quoteOption = new QuoteOption(quoteOptionGuid);
    if (!DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT TOP 1 QuoteOptionGuid FROM tblQuoteOptions WITH (NOLOCK) WHERE QuoteGuid = @QG AND Bound = 1", new object[2]
    {
      (object) "@QG",
      (object) this._quote.PreviousQuote.QuoteGuid
    }).Equals(Guid.Empty) && !this._quote.CompanyLineGuid.Equals((object) this._quote.PreviousQuote.CompanyLineGuid) && MessageBox.Show("Company/line has changed on the current policy.\n\nDo you wish to remove any auto-applied fees not part of the previous transaction?", "Remove Auto-Applied Fees", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteOptionCharges WHERE QuoteOptionGuid = @QOG AND OriginalQuoteOptionGuid IS NULL", new object[2]
      {
        (object) "@QOG",
        (object) quoteOptionGuid
      });
    this.LoadPremiums();
  }

  private void linkOffsetPolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
  }

  private void linkEndorsementOffsets_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormEndorsementOffset endorsementOffset = (FormEndorsementOffset) FormSettings.ShowFormDialog(typeof (FormEndorsementOffset), (object) this._quote.ControlNo);
    if (!endorsementOffset.Saved)
      return;
    this.RefreshPremiums(endorsementOffset.QuoteOptionGuid);
    QuoteOption quoteOption = new QuoteOption(endorsementOffset.QuoteOptionGuid);
    this.LoadPremiums();
  }

  protected virtual void ClientCancel()
  {
  }

  protected virtual void ClientSave(SqlTransaction trans)
  {
  }

  protected virtual void ClientAfterRowActivate()
  {
  }

  protected virtual void ClientSetScreenEnabled()
  {
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    this.lnkPremiumUI.Enabled = this.ds.tblQuoteOptionGeneric.Count > 1 && this._enableGenericPremiumDistribution;
  }

  public static bool IsGenericPremiumDistribution(Guid tmpQuoteGuid)
  {
    return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblGenericPremiumDistribution WHERE QuoteGuid = @QG", new object[2]
    {
      (object) "@QG",
      (object) tmpQuoteGuid
    }) > 0;
  }

  private void lnkPremiumUI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    bool flag = false;
    FormRaterGenericPremiumDist formEx = (FormRaterGenericPremiumDist) ObjectFactory.Instance.CreateFormEX(typeof (FormRaterGenericPremiumDist), (object) this.Rater.Quote.QuoteGuid, (object) this.ds);
    try
    {
      int num = (int) formEx.ShowDialog();
      flag = formEx.UserClickedUpdates;
    }
    finally
    {
      formEx.Dispose();
    }
    if (!flag)
      return;
    this._hasPremiumDistribution = frmRaterGeneric.IsGenericPremiumDistribution(this.Rater.Quote.QuoteGuid);
    if (MessageBox.Show("Update the IMS with the premium distribution schedule?", "Update IMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    Dictionary<string, GenericPremiumCharges> premiumCharges = new GenericPremiumDistribution(this.Rater.Quote.QuoteGuid).GetPremiumCharges();
    if (premiumCharges.Count == 0)
    {
      try
      {
        foreach (dsRaterGeneric.tblQuoteOptionGenericRow row in this.ds.tblQuoteOptionGeneric.Rows)
          row.Premium = 0M;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.UpdateGenericData();
    }
    else
    {
      try
      {
        foreach (KeyValuePair<string, GenericPremiumCharges> keyValuePair in premiumCharges)
        {
          GenericPremiumCharges iCharge = keyValuePair.Value;
          if (this.ds.tblQuoteOptionGeneric.Select($"ChargeCode={iCharge.ChargeCode.ToString()} AND StateID='{iCharge.PremiumStateID}'").Length > 0)
          {
            dsRaterGeneric.tblQuoteOptionGenericRow dr = (dsRaterGeneric.tblQuoteOptionGenericRow) this.ds.tblQuoteOptionGeneric.Select($"ChargeCode={iCharge.ChargeCode.ToString()} AND StateID='{iCharge.PremiumStateID}'")[0];
            dr.Premium = iCharge.AnnualAmount;
            this.SetGenericCalcTypeOnPremiumDistribution(dr, iCharge);
          }
          else
          {
            dsRaterGeneric.tblQuoteOptionGenericRow optionGenericRow = this.ds.tblQuoteOptionGeneric.NewtblQuoteOptionGenericRow();
            optionGenericRow.QuoteOptionGUID = this.ds.tblQuoteOptionGeneric[0].QuoteOptionGUID;
            optionGenericRow.Added = DateAndTime.Now;
            this.SetGenericCalcTypeOnPremiumDistribution(optionGenericRow, iCharge);
            if (this.Quote.IsEndorsement)
            {
              optionGenericRow.EffectiveDate = this.Quote.EndorsementEffective;
            }
            else
            {
              optionGenericRow.EffectiveDate = this.Quote.EffectiveDate;
              optionGenericRow.Factor = 1M;
            }
            optionGenericRow.RoundToDollar = this.ds.tblQuoteOptionGeneric[0].RoundToDollar;
            optionGenericRow.IncludeLeapYear = !this.ds.tblQuoteOptionGeneric[0].IsIncludeLeapYearNull() && this.ds.tblQuoteOptionGeneric[0].IncludeLeapYear;
            optionGenericRow.StateID = iCharge.PremiumStateID;
            optionGenericRow.ChargeCode = iCharge.ChargeCode;
            optionGenericRow.OfficeID = this.ds.tblQuoteOptionGeneric[0].OfficeID;
            optionGenericRow.Premium = iCharge.AnnualAmount;
            this.ds.tblQuoteOptionGeneric.AddtblQuoteOptionGenericRow(optionGenericRow);
          }
        }
      }
      finally
      {
        Dictionary<string, GenericPremiumCharges>.Enumerator enumerator;
        enumerator.Dispose();
      }
      for (int index = this.ds.tblQuoteOptionGeneric.Count - 1; index >= 0; index += -1)
      {
        if (!premiumCharges.ContainsKey($"{this.ds.tblQuoteOptionGeneric[index].StateID}/{this.ds.tblQuoteOptionGeneric[index].ChargeCode.ToString()}"))
          this.ds.tblQuoteOptionGeneric[index].Delete();
      }
      this.UpdateGenericData();
    }
  }

  private void SetGenericCalcTypeOnPremiumDistribution(
    dsRaterGeneric.tblQuoteOptionGenericRow dr,
    GenericPremiumCharges iCharge)
  {
    if (this.Rater.Quote.IsEndorsement)
      dr.EndorsementCalcType = this.Rater.Quote.EndorsementCalcType;
    else if (iCharge.EndCalculationType.Equals("E"))
      dr.EndorsementCalcType = "F";
    else if (iCharge.EndCalculationType.Equals("s") || iCharge.EndCalculationType.Equals("R"))
      dr.EndorsementCalcType = "S";
    else
      dr.EndorsementCalcType = iCharge.EndCalculationType;
  }

  private void RefreshLoadPanel()
  {
    this.panelLoadText.Text = this.panelLoadText.Text;
    ((UltraControlBase) this.panelLoading).Refresh();
  }

  private void UpdateGenericData()
  {
    this.RefreshLoadPanel();
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daOptions, (DataTable) this.ds.tblQuoteOptions);
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daOptionsGeneric, (DataTable) this.ds.tblQuoteOptionGeneric);
    this.ds.AcceptChanges();
    this.RefreshLoadPanel();
    this.RateOption(this.ds.tblQuoteOptionGeneric[0].QuoteOptionGUID);
    this.RefreshLoadPanel();
    UltraGridBand band = ((UltraGridBase) this.dgOptions).DisplayLayout.Bands[1];
    IEnumerator enumerator;
    try
    {
      enumerator = band.GetRowEnumerator((GridRowType) 1).GetEnumerator();
      if (enumerator.MoveNext())
      {
        UltraGridRow current = (UltraGridRow) enumerator.Current;
        current.Selected = true;
        ((UltraGridBase) this.dgOptions).ActiveRow = current;
      }
    }
    finally
    {
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((UltraGridBase) this.dgOptions).UpdateData();
    this.dgOptions_AfterRowActivate((object) null, (EventArgs) null);
  }

  private void lnkCancellation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Continue processing premium distribution on this cancellation?", "Continue Processing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    if (this.Rater.Quote.QuoteStatus != QuoteStatus.PendingCancellation)
    {
      int num = (int) MessageBox.Show("Current quote status must be of 'Pending Cancellation", "Invalid Quote Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      try
      {
        ((Control) this.panelLoading).Visible = true;
        this.RefreshLoadPanel();
        List<GenericCancellationPremiumCharges> cancellationPremiumCharges1 = new GenericPremiumDistribution(this.Rater.Quote.QuoteGuid).GetCancellationPremiumCharges();
        Guid guid;
        if (this.ds.tblQuoteOptions.Count == 0)
        {
          guid = Guid.NewGuid();
          dsRaterGeneric.tblQuoteOptionsRow row = this.ds.tblQuoteOptions.NewtblQuoteOptionsRow();
          row.QuoteOptionGUID = guid;
          row.DateCreated = DateAndTime.Now;
          row.LineGUID = this.Rater.LineGuid;
          row.QuoteGUID = this.Rater.Quote.QuoteGuid;
          if (this.ds.tblCompanyLocations.Count > 1)
            row.CompanyLocationID = this.Rater.Quote.CompanyLocation.CompanyLocationCode;
          else if (this.ds.tblCompanyLocations.Count == 1)
            row.CompanyLocationID = this.ds.tblCompanyLocations[0].CompanyLocationID;
          row.Premium = 0M;
          this.ds.tblQuoteOptions.AddtblQuoteOptionsRow(row);
          this.RefreshLoadPanel();
        }
        else
          guid = this.ds.tblQuoteOptions[0].QuoteOptionGUID;
        try
        {
          foreach (GenericCancellationPremiumCharges cancellationPremiumCharges2 in cancellationPremiumCharges1)
          {
            if (this.ds.tblQuoteOptionGeneric.Select($"ChargeCode={cancellationPremiumCharges2.ChargeCode.ToString()} AND StateID='{cancellationPremiumCharges2.PremiumStateID}'").Length > 0)
            {
              dsRaterGeneric.tblQuoteOptionGenericRow optionGenericRow = (dsRaterGeneric.tblQuoteOptionGenericRow) this.ds.tblQuoteOptionGeneric.Select($"ChargeCode={cancellationPremiumCharges2.ChargeCode.ToString()} AND StateID='{cancellationPremiumCharges2.PremiumStateID}'")[0];
              optionGenericRow.Premium = cancellationPremiumCharges2.AnnualAmount;
              if (Decimal.Compare(optionGenericRow.Premium, 0M) > 0)
                optionGenericRow.Premium = Decimal.Multiply(optionGenericRow.Premium, -1M);
            }
            else
            {
              dsRaterGeneric.tblQuoteOptionGenericRow row = this.ds.tblQuoteOptionGeneric.NewtblQuoteOptionGenericRow();
              row.QuoteOptionGUID = guid;
              row.Added = DateAndTime.Now;
              row.EndorsementCalcType = this.Rater.Quote.EndorsementCalcType;
              row.EffectiveDate = this.Quote.EndorsementEffective;
              row.RoundToDollar = !this.NotRoundingPremiumToDollar;
              row.IncludeLeapYear = false;
              row.StateID = cancellationPremiumCharges2.PremiumStateID;
              row.ChargeCode = cancellationPremiumCharges2.ChargeCode;
              row.OfficeID = this._quotingOfficeID;
              row.Premium = !row.RoundToDollar ? cancellationPremiumCharges2.AnnualAmount : Math.Round(cancellationPremiumCharges2.AnnualAmount);
              if (Decimal.Compare(row.Premium, 0M) > 0)
                row.Premium = Decimal.Multiply(row.Premium, -1M);
              this.ds.tblQuoteOptionGeneric.AddtblQuoteOptionGenericRow(row);
              this.RefreshLoadPanel();
            }
          }
        }
        finally
        {
          List<GenericCancellationPremiumCharges>.Enumerator enumerator;
          enumerator.Dispose();
        }
        this.UpdateGenericData();
      }
      finally
      {
        ((Control) this.panelLoading).Visible = false;
      }
    }
  }

  private void lnkViewUnderwritingLocations_LinkClicked(
    object sender,
    LinkLabelLinkClickedEventArgs e)
  {
    using (FormSettings.ShowFormDialog(typeof (frmUnderwritingLocations), (object) this.Quote.QuoteGuid, (object) true))
      ;
  }

  private void chkIncludeLeapYear_CheckedChanged(object s, EventArgs e) => this.CalculateFactor();

  private void LogIssue(string logMessage)
  {
    if (!MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("RaterSaveLogging"))
      return;
    CurrentUser.Instance.LogAction(logMessage, "TFS 87152");
  }

  private delegate void SetAdditionalCommentsHandler(string comments);

  private delegate void RateOptionHandler(Guid QuoteOptionGUID);

  private delegate void AddExposureCaptureHandler(string captureName, Type t);

  private class ExposureCaptureItem
  {
    private string _captureName;
    private Type _t;

    public ExposureCaptureItem(string captureName, Type t)
    {
      this._captureName = captureName;
      this._t = t;
    }

    public Type CaptureType => this._t;

    public override string ToString() => this._captureName;
  }
}

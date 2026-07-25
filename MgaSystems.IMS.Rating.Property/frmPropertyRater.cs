// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Rating.Property.frmPropertyRater
// Assembly: MgaSystems.IMS.Rating.Property, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B6A893CA-828D-4C72-A3E1-997D4DDF80FA
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.Property.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.Policies.Rating;
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
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.IMS.Rating.Property;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmPropertyRater : frmRaterBase
{
  private IContainer components;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  protected dsPropertyRater ds;
  private SqlDataAdapter daLookups;
  private SqlCommand SqlSelectCommand1;
  private MGASimpleComboBox cboCoInsurance;
  private MGASimpleComboBox cboValuations;
  private MGASimpleComboBox cboPolicyForms;
  private SqlDataAdapter daOptionsProperty;
  private SqlDataAdapter daOptions;
  private SqlCommand SqlCommand1;
  private SqlCommand SqlCommand2;
  private SqlCommand SqlSelectCommand3;
  private SqlCommand SqlCommand3;
  private MGATextBox txtSubLimits;
  private MGATextBox txtOtherDeduct;
  private MGATextBox txtCoverage;
  private Label Label12;
  private Label Label11;
  private Label Label13;
  private Label Label15;
  private Label Label16;
  private Label Label17;
  private MGATextBox txtAdditionalComments;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private UltraTabPageControl UltraTabPageControl3;
  private MGATextBox txtCoInsurance;
  private Label Label8;
  private Label Label9;
  private MGANumericEditor txtPriorRate;
  private MGATextBox txtValuation;
  private MGANumericEditor txtAOPDA;
  protected MGANumericEditor txtTIV;
  private UltraToolbarsDockArea _frmPropertyRater_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmPropertyRater_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _frmPropertyRater_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmPropertyRater_Toolbars_Dock_Area_Bottom;
  private UltraTabPageControl UltraTabPageControl4;
  private SqlDataAdapter daOptionSubLimits;
  private SqlDataAdapter daSubLimits;
  private SqlCommand SqlSelectCommand5;
  private MGASimpleComboBox cboDeductiblePer;
  private SqlCommand SqlSelectCommand4;
  private SqlCommand SqlInsertCommand2;
  private SqlCommand SqlUpdateCommand2;
  private SqlCommand SqlDeleteCommand2;
  private Label Label10;
  private Label Label18;
  private Label Label19;
  private Label Label20;
  private SqlCommand SqlSelectCommand2;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  protected UltraTabPageControl tabUnderlying;
  private Font _strikeoutFont;
  private Font _originalFont;
  private HyperlinkEditor _deleteSublimitsLink;
  private readonly Quote _quote;
  private readonly bool _isIssued;
  private readonly bool _blockExcessPremium;
  private bool _roundToDollar;
  private int _renewedQuoteControlNo;
  private bool _isImsRenewal;
  private Quote _renewedQuote;
  private bool _isQuoteBound;
  private bool _canImportLocationFromExcelWhenBound;
  private readonly SqlConnection _cn;

  private virtual MGASimpleComboBox cboLimitDescriptions
  {
    get => this._cboLimitDescriptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboLimitDescriptions_Validating);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.cboLimitDescriptions_InitializeRow);
      MGASimpleComboBox limitDescriptions1 = this._cboLimitDescriptions;
      if (limitDescriptions1 != null)
      {
        ((Control) limitDescriptions1).Validating -= cancelEventHandler;
        limitDescriptions1.InitializeRow -= initializeRowEventHandler;
      }
      this._cboLimitDescriptions = value;
      MGASimpleComboBox limitDescriptions2 = this._cboLimitDescriptions;
      if (limitDescriptions2 == null)
        return;
      ((Control) limitDescriptions2).Validating += cancelEventHandler;
      limitDescriptions2.InitializeRow += initializeRowEventHandler;
    }
  }

  protected virtual MGASimpleComboBox cboCauseofLoss
  {
    get => this._cboCauseofLoss;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.cboCauseofLoss_BeforeDropDown);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.cboCauseofLoss_InitializeRow);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.cboCauseofLoss_Validating);
      MGASimpleComboBox cboCauseofLoss1 = this._cboCauseofLoss;
      if (cboCauseofLoss1 != null)
      {
        cboCauseofLoss1.BeforeDropDown -= cancelEventHandler1;
        cboCauseofLoss1.InitializeRow -= initializeRowEventHandler;
        ((Control) cboCauseofLoss1).Validating -= cancelEventHandler2;
      }
      this._cboCauseofLoss = value;
      MGASimpleComboBox cboCauseofLoss2 = this._cboCauseofLoss;
      if (cboCauseofLoss2 == null)
        return;
      cboCauseofLoss2.BeforeDropDown += cancelEventHandler1;
      cboCauseofLoss2.InitializeRow += initializeRowEventHandler;
      ((Control) cboCauseofLoss2).Validating += cancelEventHandler2;
    }
  }

  private virtual UltraGrid ugOptions
  {
    get => this._ugOptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugOptions_AfterRowActivate);
      UltraGrid ugOptions1 = this._ugOptions;
      if (ugOptions1 != null)
        ugOptions1.AfterRowActivate -= eventHandler;
      this._ugOptions = value;
      UltraGrid ugOptions2 = this._ugOptions;
      if (ugOptions2 == null)
        return;
      ugOptions2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("err")]
  protected virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblExcessPremium")]
  protected virtual Label lblExcessPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabControl1")]
  protected virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  protected virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  protected virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraCheckEditor chkTerrorism
  {
    get => this._chkTerrorism;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkTerrorism_CheckedChanged);
      UltraCheckEditor chkTerrorism1 = this._chkTerrorism;
      if (chkTerrorism1 != null)
        ((UltraToggleEditorBase) chkTerrorism1).CheckedChanged -= eventHandler;
      this._chkTerrorism = value;
      UltraCheckEditor chkTerrorism2 = this._chkTerrorism;
      if (chkTerrorism2 == null)
        return;
      ((UltraToggleEditorBase) chkTerrorism2).CheckedChanged += eventHandler;
    }
  }

  private virtual LinkLabel lnkFCW
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

  protected virtual MGANumericEditor txtTerrorism
  {
    get => this._txtTerrorism;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.Premiums_ValueChanged);
      EventHandler eventHandler2 = new EventHandler(this.txtPrimary_Enter);
      EventHandler eventHandler3 = new EventHandler(this.txtPrimary_Leave);
      MGANumericEditor txtTerrorism1 = this._txtTerrorism;
      if (txtTerrorism1 != null)
      {
        ((UltraNumericEditorBase) txtTerrorism1).ValueChanged -= eventHandler1;
        ((Control) txtTerrorism1).Enter -= eventHandler2;
        ((Control) txtTerrorism1).Leave -= eventHandler3;
      }
      this._txtTerrorism = value;
      MGANumericEditor txtTerrorism2 = this._txtTerrorism;
      if (txtTerrorism2 == null)
        return;
      ((UltraNumericEditorBase) txtTerrorism2).ValueChanged += eventHandler1;
      ((Control) txtTerrorism2).Enter += eventHandler2;
      ((Control) txtTerrorism2).Leave += eventHandler3;
    }
  }

  [field: AccessedThroughProperty("txtRate")]
  protected virtual MGANumericEditor txtRate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPolicyLimit")]
  protected virtual MGANumericEditor txtPolicyLimit { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraToolbarsManager UltraToolbarsManager1
  {
    get => this._UltraToolbarsManager1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      BeforeToolDropdownEventHandler dropdownEventHandler = new BeforeToolDropdownEventHandler(this.UltraToolbarsManager1_BeforeToolDropdown);
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.UltraToolbarsManager1_ToolClick);
      UltraToolbarsManager toolbarsManager1_1 = this._UltraToolbarsManager1;
      if (toolbarsManager1_1 != null)
      {
        toolbarsManager1_1.BeforeToolDropdown -= dropdownEventHandler;
        toolbarsManager1_1.ToolClick -= clickEventHandler;
      }
      this._UltraToolbarsManager1 = value;
      UltraToolbarsManager toolbarsManager1_2 = this._UltraToolbarsManager1;
      if (toolbarsManager1_2 == null)
        return;
      toolbarsManager1_2.BeforeToolDropdown += dropdownEventHandler;
      toolbarsManager1_2.ToolClick += clickEventHandler;
    }
  }

  private virtual LinkLabel lnkCalculateRate
  {
    get => this._lnkCalculateRate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCalculateRate_LinkClicked);
      LinkLabel lnkCalculateRate1 = this._lnkCalculateRate;
      if (lnkCalculateRate1 != null)
        lnkCalculateRate1.LinkClicked -= clickedEventHandler;
      this._lnkCalculateRate = value;
      LinkLabel lnkCalculateRate2 = this._lnkCalculateRate;
      if (lnkCalculateRate2 == null)
        return;
      lnkCalculateRate2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual UltraDropDown ddLimit
  {
    get => this._ddLimit;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.ddLimit_BeforeDropDown);
      UltraDropDown ddLimit1 = this._ddLimit;
      if (ddLimit1 != null)
        ddLimit1.BeforeDropDown -= cancelEventHandler;
      this._ddLimit = value;
      UltraDropDown ddLimit2 = this._ddLimit;
      if (ddLimit2 == null)
        return;
      ddLimit2.BeforeDropDown += cancelEventHandler;
    }
  }

  private virtual UltraGrid ugSubLimits
  {
    get => this._ugSubLimits;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler = new CellEventHandler(this.ugSubLimits_AfterCellUpdate);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.ugSubLimits_InitializeRow);
      CancelableRowEventHandler cancelableRowEventHandler = new CancelableRowEventHandler(this.ugSubLimits_BeforeRowUpdate);
      RowEventHandler rowEventHandler = new RowEventHandler(this.ugSubLimits_AfterRowInsert);
      UltraGrid ugSubLimits1 = this._ugSubLimits;
      if (ugSubLimits1 != null)
      {
        ugSubLimits1.AfterCellUpdate -= cellEventHandler;
        ugSubLimits1.InitializeRow -= initializeRowEventHandler;
        ugSubLimits1.BeforeRowUpdate -= cancelableRowEventHandler;
        ugSubLimits1.AfterRowInsert -= rowEventHandler;
      }
      this._ugSubLimits = value;
      UltraGrid ugSubLimits2 = this._ugSubLimits;
      if (ugSubLimits2 == null)
        return;
      ugSubLimits2.AfterCellUpdate += cellEventHandler;
      ugSubLimits2.InitializeRow += initializeRowEventHandler;
      ugSubLimits2.BeforeRowUpdate += cancelableRowEventHandler;
      ugSubLimits2.AfterRowInsert += rowEventHandler;
    }
  }

  private virtual LinkLabel lnkMiscPremiums
  {
    get => this._lnkMiscPremiums;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkMiscPremiums_LinkClicked);
      LinkLabel lnkMiscPremiums1 = this._lnkMiscPremiums;
      if (lnkMiscPremiums1 != null)
        lnkMiscPremiums1.LinkClicked -= clickedEventHandler;
      this._lnkMiscPremiums = value;
      LinkLabel lnkMiscPremiums2 = this._lnkMiscPremiums;
      if (lnkMiscPremiums2 == null)
        return;
      lnkMiscPremiums2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkCalculatePremium
  {
    get => this._lnkCalculatePremium;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCalculatePremium_LinkClicked);
      LinkLabel calculatePremium1 = this._lnkCalculatePremium;
      if (calculatePremium1 != null)
        calculatePremium1.LinkClicked -= clickedEventHandler;
      this._lnkCalculatePremium = value;
      LinkLabel calculatePremium2 = this._lnkCalculatePremium;
      if (calculatePremium2 == null)
        return;
      calculatePremium2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtUnderlyingCarrier")]
  protected virtual MGATextBox txtUnderlyingCarrier { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtUnderlyingPolicyNumber")]
  protected virtual MGATextBox txtUnderlyingPolicyNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtUnderlyingLimit")]
  protected virtual MGANumericEditor txtUnderlyingLimit { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtUnderlyingDeductible")]
  protected virtual MGANumericEditor txtUnderlyingDeductible { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTotalPremium")]
  protected virtual UltraLabel lblTotalPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGANumericEditor txtPrimary
  {
    get => this._txtPrimary;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.Premiums_ValueChanged);
      EventHandler eventHandler2 = new EventHandler(this.txtPrimary_Enter);
      EventHandler eventHandler3 = new EventHandler(this.txtPrimary_Leave);
      MGANumericEditor txtPrimary1 = this._txtPrimary;
      if (txtPrimary1 != null)
      {
        ((UltraNumericEditorBase) txtPrimary1).ValueChanged -= eventHandler1;
        ((Control) txtPrimary1).Enter -= eventHandler2;
        ((Control) txtPrimary1).Leave -= eventHandler3;
      }
      this._txtPrimary = value;
      MGANumericEditor txtPrimary2 = this._txtPrimary;
      if (txtPrimary2 == null)
        return;
      ((UltraNumericEditorBase) txtPrimary2).ValueChanged += eventHandler1;
      ((Control) txtPrimary2).Enter += eventHandler2;
      ((Control) txtPrimary2).Leave += eventHandler3;
    }
  }

  protected virtual MGANumericEditor txtExcess
  {
    get => this._txtExcess;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.Premiums_ValueChanged);
      EventHandler eventHandler2 = new EventHandler(this.txtPrimary_Enter);
      EventHandler eventHandler3 = new EventHandler(this.txtPrimary_Leave);
      MGANumericEditor txtExcess1 = this._txtExcess;
      if (txtExcess1 != null)
      {
        ((UltraNumericEditorBase) txtExcess1).ValueChanged -= eventHandler1;
        ((Control) txtExcess1).Enter -= eventHandler2;
        ((Control) txtExcess1).Leave -= eventHandler3;
      }
      this._txtExcess = value;
      MGANumericEditor txtExcess2 = this._txtExcess;
      if (txtExcess2 == null)
        return;
      ((UltraNumericEditorBase) txtExcess2).ValueChanged += eventHandler1;
      ((Control) txtExcess2).Enter += eventHandler2;
      ((Control) txtExcess2).Leave += eventHandler3;
    }
  }

  protected virtual MGANumericEditor txtTerrorismExcess
  {
    get => this._txtTerrorismExcess;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.Premiums_ValueChanged);
      EventHandler eventHandler2 = new EventHandler(this.txtPrimary_Leave);
      MGANumericEditor txtTerrorismExcess1 = this._txtTerrorismExcess;
      if (txtTerrorismExcess1 != null)
      {
        ((UltraNumericEditorBase) txtTerrorismExcess1).ValueChanged -= eventHandler1;
        ((Control) txtTerrorismExcess1).Leave -= eventHandler2;
      }
      this._txtTerrorismExcess = value;
      MGANumericEditor txtTerrorismExcess2 = this._txtTerrorismExcess;
      if (txtTerrorismExcess2 == null)
        return;
      ((UltraNumericEditorBase) txtTerrorismExcess2).ValueChanged += eventHandler1;
      ((Control) txtTerrorismExcess2).Leave += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("Label21")]
  private virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("linkDebugHelper")]
  internal virtual LinkLabel linkDebugHelper { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid ugPrior
  {
    get => this._ugPrior;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler = new RowEventHandler(this.ugPrior_AfterRowInsert);
      BeforeRowInsertEventHandler insertEventHandler = new BeforeRowInsertEventHandler(this.ugPrior_BeforeRowInsert);
      CancelableRowEventHandler cancelableRowEventHandler = new CancelableRowEventHandler(this.ugPrior_BeforeRowUpdate);
      UltraGrid ugPrior1 = this._ugPrior;
      if (ugPrior1 != null)
      {
        ugPrior1.AfterRowInsert -= rowEventHandler;
        ugPrior1.BeforeRowInsert -= insertEventHandler;
        ugPrior1.BeforeRowUpdate -= cancelableRowEventHandler;
      }
      this._ugPrior = value;
      UltraGrid ugPrior2 = this._ugPrior;
      if (ugPrior2 == null)
        return;
      ugPrior2.AfterRowInsert += rowEventHandler;
      ugPrior2.BeforeRowInsert += insertEventHandler;
      ugPrior2.BeforeRowUpdate += cancelableRowEventHandler;
    }
  }

  [field: AccessedThroughProperty("daRates")]
  private virtual SqlDataAdapter daRates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand4")]
  private virtual SqlCommand SqlCommand4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand5")]
  private virtual SqlCommand SqlCommand5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand6")]
  private virtual SqlCommand SqlCommand6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand7")]
  private virtual SqlCommand SqlCommand7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnContinue
  {
    get => this._btnContinue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnContinue_Click);
      MGAButton btnContinue1 = this._btnContinue;
      if (btnContinue1 != null)
        ((Control) btnContinue1).Click -= eventHandler;
      this._btnContinue = value;
      MGAButton btnContinue2 = this._btnContinue;
      if (btnContinue2 == null)
        return;
      ((Control) btnContinue2).Click += eventHandler;
    }
  }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingNew);
      EventHandler eventHandler1 = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingDelete);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingEdit -= cancelEventHandler1;
        dbSave1.ClickingNew -= cancelEventHandler2;
        dbSave1.UIStateChanged -= eventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler3;
        dbSave1.ClickedCancel -= eventHandler2;
        dbSave1.ClickingDelete -= cancelEventHandler4;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingEdit += cancelEventHandler1;
      dbSave2.ClickingNew += cancelEventHandler2;
      dbSave2.UIStateChanged += eventHandler1;
      dbSave2.ClickingSave += cancelEventHandler3;
      dbSave2.ClickedCancel += eventHandler2;
      dbSave2.ClickingDelete += cancelEventHandler4;
    }
  }

  internal virtual LinkLabel lnkCancelPriorRates
  {
    get => this._lnkCancelPriorRates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lnkCancelPriorRates_Click);
      LinkLabel cancelPriorRates1 = this._lnkCancelPriorRates;
      if (cancelPriorRates1 != null)
        cancelPriorRates1.Click -= eventHandler;
      this._lnkCancelPriorRates = value;
      LinkLabel cancelPriorRates2 = this._lnkCancelPriorRates;
      if (cancelPriorRates2 == null)
        return;
      cancelPriorRates2.Click += eventHandler;
    }
  }

  internal virtual LinkLabel lnkCopyOptions
  {
    get => this._lnkCopyOptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopyOptions_LinkClicked);
      LinkLabel lnkCopyOptions1 = this._lnkCopyOptions;
      if (lnkCopyOptions1 != null)
        lnkCopyOptions1.LinkClicked -= clickedEventHandler;
      this._lnkCopyOptions = value;
      LinkLabel lnkCopyOptions2 = this._lnkCopyOptions;
      if (lnkCopyOptions2 == null)
        return;
      lnkCopyOptions2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkLocationExcelImport
  {
    get => this._lnkLocationExcelImport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkLocationExcelImport_LinkClicked);
      LinkLabel locationExcelImport1 = this._lnkLocationExcelImport;
      if (locationExcelImport1 != null)
        locationExcelImport1.LinkClicked -= clickedEventHandler;
      this._lnkLocationExcelImport = value;
      LinkLabel locationExcelImport2 = this._lnkLocationExcelImport;
      if (locationExcelImport2 == null)
        return;
      locationExcelImport2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("options")]
  protected virtual UltraOptionSet options { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstSubLimits", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("SubLimitID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("SubLimit");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("lstSubLimitstblQuoteOptionProperty_SubLimits");
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstSubLimitstblQuoteOptionProperty_SubLimits", 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("PropertyOptionID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("SubLimitID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Limit");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Deductible");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("DeductiblePercentage");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("DeleteLink");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ModificationCode");
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblQuoteOptionProperty_SubLimits", -1);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("PropertyOptionID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("SubLimitID", -1, (object) "ddLimit");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Limit");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Deductible");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("DeductiblePercentage");
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("DeleteLink");
    Appearance appearance18 = new Appearance();
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ModificationCode");
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblPropertyExposuresPriorYears", -1);
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("QuoteOptionID");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("Year");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("PriorRate");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("IncurredLosses");
    Appearance appearance31 = new Appearance();
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("PriorID");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("IsPreviouslyApplied");
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPropertyRater));
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance53 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance54 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance55 = new Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Appearance appearance56 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("contextMenu");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("contextMenu");
    ButtonTool buttonTool1 = new ButtonTool("Copy Option");
    ButtonTool buttonTool2 = new ButtonTool("Copy Option");
    Appearance appearance57 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("tblQuoteOptionProperty", -1);
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("PriorID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("QuoteOptionID");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("TerrorismDeclined");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("CauseofLossID");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("PolicyLimitDescriptionID");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("PolicyFormID");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("ValuationID");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("CoInsuranceID");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("TIV");
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("Coverage");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("PolicyLimit");
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("SubLimits");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("AOPDA");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("DeductiblePerID");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("OtherDeduct");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("PrimaryPremium");
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("ExcessPremium");
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("TerrPremium");
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("AdditionalComments");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("CoInsurance");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("Rate");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("PriorRate");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("Valuation");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("UnderlyingCarrier");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("UnderlyingPolNo");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("UnderlyingLimit");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("UnderlyingDA");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("RateBasedOffTIV");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("TerrorismExcessPremium");
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("tblQuoteOptionPropertytblQuoteOptionProperty_SubLimits");
    UltraGridBand ultraGridBand6 = new UltraGridBand("tblQuoteOptionPropertytblQuoteOptionProperty_SubLimits", 0);
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("PropertyOptionID");
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("SubLimitID");
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("Limit");
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("Deductible");
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("DeductiblePercentage");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("DeleteLink");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("ModificationCode");
    Appearance appearance70 = new Appearance();
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    Appearance appearance73 = new Appearance();
    Appearance appearance74 = new Appearance();
    Appearance appearance75 = new Appearance();
    Appearance appearance76 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.lnkLocationExcelImport = new LinkLabel();
    this.lnkCopyOptions = new LinkLabel();
    this.linkDebugHelper = new LinkLabel();
    this.cboDeductiblePer = new MGASimpleComboBox();
    this.txtTIV = new MGANumericEditor();
    this.ds = new dsPropertyRater();
    this.txtAOPDA = new MGANumericEditor();
    this.txtPolicyLimit = new MGANumericEditor();
    this.txtValuation = new MGATextBox();
    this.txtCoInsurance = new MGATextBox();
    this.txtOtherDeduct = new MGATextBox();
    this.txtCoverage = new MGATextBox();
    this.cboCauseofLoss = new MGASimpleComboBox();
    this.Label4 = new Label();
    this.Label17 = new Label();
    this.Label16 = new Label();
    this.Label15 = new Label();
    this.Label7 = new Label();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.cboCoInsurance = new MGASimpleComboBox();
    this.cboValuations = new MGASimpleComboBox();
    this.cboLimitDescriptions = new MGASimpleComboBox();
    this.cboPolicyForms = new MGASimpleComboBox();
    this.txtSubLimits = new MGATextBox();
    this.btnContinue = new MGAButton();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.UltraTabPageControl4 = new UltraTabPageControl();
    this.ddLimit = new UltraDropDown();
    this.ugSubLimits = new UltraGrid();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.lnkCancelPriorRates = new LinkLabel();
    this.ugPrior = new UltraGrid();
    this.txtTerrorismExcess = new MGANumericEditor();
    this.Label21 = new Label();
    this.options = new UltraOptionSet();
    this.lnkCalculatePremium = new LinkLabel();
    this.lnkMiscPremiums = new LinkLabel();
    this.lnkCalculateRate = new LinkLabel();
    this.txtPriorRate = new MGANumericEditor();
    this.txtRate = new MGANumericEditor();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.txtTerrorism = new MGANumericEditor();
    this.txtExcess = new MGANumericEditor();
    this.txtPrimary = new MGANumericEditor();
    this.Label12 = new Label();
    this.lblTotalPremium = new UltraLabel();
    this.Label11 = new Label();
    this.Label13 = new Label();
    this.lblExcessPremium = new Label();
    this.chkTerrorism = new UltraCheckEditor();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.lnkFCW = new LinkLabel();
    this.txtAdditionalComments = new MGATextBox();
    this.tabUnderlying = new UltraTabPageControl();
    this.txtUnderlyingDeductible = new MGANumericEditor();
    this.Label20 = new Label();
    this.txtUnderlyingLimit = new MGANumericEditor();
    this.Label19 = new Label();
    this.txtUnderlyingPolicyNumber = new MGATextBox();
    this.Label18 = new Label();
    this.txtUnderlyingCarrier = new MGATextBox();
    this.Label10 = new Label();
    this.daLookups = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.err = new ErrorProvider(this.components);
    this.daOptionsProperty = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.daOptions = new SqlDataAdapter();
    this.SqlCommand1 = new SqlCommand();
    this.SqlCommand2 = new SqlCommand();
    this.SqlSelectCommand3 = new SqlCommand();
    this.SqlCommand3 = new SqlCommand();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.ugOptions = new UltraGrid();
    this._frmPropertyRater_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._frmPropertyRater_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmPropertyRater_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmPropertyRater_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.daOptionSubLimits = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand4 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    this.daSubLimits = new SqlDataAdapter();
    this.SqlSelectCommand5 = new SqlCommand();
    this.daRates = new SqlDataAdapter();
    this.SqlCommand4 = new SqlCommand();
    this.SqlCommand5 = new SqlCommand();
    this.SqlCommand6 = new SqlCommand();
    this.SqlCommand7 = new SqlCommand();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.cboDeductiblePer).BeginInit();
    ((ISupportInitialize) this.txtTIV).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.txtAOPDA).BeginInit();
    ((ISupportInitialize) this.txtPolicyLimit).BeginInit();
    ((ISupportInitialize) this.txtValuation).BeginInit();
    ((ISupportInitialize) this.txtCoInsurance).BeginInit();
    ((ISupportInitialize) this.txtOtherDeduct).BeginInit();
    ((ISupportInitialize) this.txtCoverage).BeginInit();
    ((ISupportInitialize) this.cboCauseofLoss).BeginInit();
    ((ISupportInitialize) this.cboCoInsurance).BeginInit();
    ((ISupportInitialize) this.cboValuations).BeginInit();
    ((ISupportInitialize) this.cboLimitDescriptions).BeginInit();
    ((ISupportInitialize) this.cboPolicyForms).BeginInit();
    ((ISupportInitialize) this.txtSubLimits).BeginInit();
    ((ISupportInitialize) this.btnContinue).BeginInit();
    ((Control) this.UltraTabPageControl4).SuspendLayout();
    ((ISupportInitialize) this.ddLimit).BeginInit();
    ((ISupportInitialize) this.ugSubLimits).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.ugPrior).BeginInit();
    ((ISupportInitialize) this.txtTerrorismExcess).BeginInit();
    ((ISupportInitialize) this.options).BeginInit();
    ((ISupportInitialize) this.txtPriorRate).BeginInit();
    ((ISupportInitialize) this.txtRate).BeginInit();
    ((ISupportInitialize) this.txtTerrorism).BeginInit();
    ((ISupportInitialize) this.txtExcess).BeginInit();
    ((ISupportInitialize) this.txtPrimary).BeginInit();
    ((ISupportInitialize) this.chkTerrorism).BeginInit();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.txtAdditionalComments).BeginInit();
    ((Control) this.tabUnderlying).SuspendLayout();
    ((ISupportInitialize) this.txtUnderlyingDeductible).BeginInit();
    ((ISupportInitialize) this.txtUnderlyingLimit).BeginInit();
    ((ISupportInitialize) this.txtUnderlyingPolicyNumber).BeginInit();
    ((ISupportInitialize) this.txtUnderlyingCarrier).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.ugOptions).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkLocationExcelImport);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkCopyOptions);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.linkDebugHelper);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboDeductiblePer);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtTIV);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtAOPDA);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtPolicyLimit);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtValuation);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtCoInsurance);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtOtherDeduct);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtCoverage);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboCauseofLoss);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label17);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label16);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label15);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label7);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label6);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label5);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboCoInsurance);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboValuations);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboLimitDescriptions);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboPolicyForms);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtSubLimits);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnContinue);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(590, 365);
    this.lnkLocationExcelImport.AutoSize = true;
    this.lnkLocationExcelImport.BackColor = Color.Transparent;
    this.lnkLocationExcelImport.Location = new Point(93, 341);
    this.lnkLocationExcelImport.Name = "lnkLocationExcelImport";
    this.lnkLocationExcelImport.Size = new Size(161, 13);
    this.lnkLocationExcelImport.TabIndex = 27;
    this.lnkLocationExcelImport.TabStop = true;
    this.lnkLocationExcelImport.Text = "Import Location Data from Excel";
    this.lnkCopyOptions.AutoSize = true;
    this.lnkCopyOptions.BackColor = Color.Transparent;
    this.lnkCopyOptions.Location = new Point(93, 313);
    this.lnkCopyOptions.Name = "lnkCopyOptions";
    this.lnkCopyOptions.Size = new Size(180, 13);
    this.lnkCopyOptions.TabIndex = 25;
    this.lnkCopyOptions.TabStop = true;
    this.lnkCopyOptions.Text = "Copy Options From Renewed Quote";
    this.linkDebugHelper.AutoSize = true;
    this.linkDebugHelper.BackColor = Color.Transparent;
    this.linkDebugHelper.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.linkDebugHelper.LinkColor = Color.FromArgb(0, 64 /*0x40*/, 0);
    this.linkDebugHelper.Location = new Point(324, 286);
    this.linkDebugHelper.Name = "linkDebugHelper";
    this.linkDebugHelper.Size = new Size(189, 19);
    this.linkDebugHelper.TabIndex = 24;
    this.linkDebugHelper.TabStop = true;
    this.linkDebugHelper.Text = "FILL WITH DEBUG DATA";
    this.cboDeductiblePer.BorderStyle = (UIElementBorderStyle) 4;
    this.cboDeductiblePer.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDeductiblePer).Location = new Point(200, 168);
    this.cboDeductiblePer.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDeductiblePer).Name = "cboDeductiblePer";
    ((Control) this.cboDeductiblePer).Size = new Size(344, 21);
    ((Control) this.cboDeductiblePer).TabIndex = 13;
    ((UltraControlBase) this.cboDeductiblePer).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDeductiblePer).UseOsThemes = (DefaultableBoolean) 2;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtTIV).Appearance = (AppearanceBase) appearance1;
    ((Control) this.txtTIV).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.TIV", true));
    ((UltraNumericEditorBase) this.txtTIV).FormatString = "c";
    ((Control) this.txtTIV).Location = new Point(96 /*0x60*/, 285);
    this.txtTIV.MaskInput = "-nnn,nnn,nnn,nnn,nnn.nn";
    this.txtTIV.MaxValue = (object) 337593543950335L;
    this.txtTIV.MGAStyle = MGAStyles.Blue;
    this.txtTIV.MinValue = (object) 0;
    ((Control) this.txtTIV).Name = "txtTIV";
    this.txtTIV.Nullable = true;
    this.txtTIV.NumericType = (NumericType) 1;
    ((Control) this.txtTIV).Size = new Size(152, 20);
    ((Control) this.txtTIV).TabIndex = 23;
    ((UltraControlBase) this.txtTIV).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTIV).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsPropertyRater";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtAOPDA).Appearance = (AppearanceBase) appearance2;
    ((Control) this.txtAOPDA).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.AOPDA", true));
    ((UltraNumericEditorBase) this.txtAOPDA).FormatString = "c";
    ((Control) this.txtAOPDA).Location = new Point(96 /*0x60*/, 168);
    this.txtAOPDA.MGAStyle = MGAStyles.Blue;
    this.txtAOPDA.MinValue = (object) 0;
    ((Control) this.txtAOPDA).Name = "txtAOPDA";
    this.txtAOPDA.Nullable = true;
    ((Control) this.txtAOPDA).Size = new Size(100, 20);
    ((Control) this.txtAOPDA).TabIndex = 12;
    ((UltraControlBase) this.txtAOPDA).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAOPDA).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtPolicyLimit).Appearance = (AppearanceBase) appearance3;
    ((Control) this.txtPolicyLimit).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.PolicyLimit", true));
    ((UltraNumericEditorBase) this.txtPolicyLimit).FormatString = "c";
    ((Control) this.txtPolicyLimit).Location = new Point(96 /*0x60*/, 75);
    this.txtPolicyLimit.MGAStyle = MGAStyles.Blue;
    this.txtPolicyLimit.MinValue = (object) 0;
    ((Control) this.txtPolicyLimit).Name = "txtPolicyLimit";
    this.txtPolicyLimit.Nullable = true;
    ((Control) this.txtPolicyLimit).Size = new Size(100, 20);
    ((Control) this.txtPolicyLimit).TabIndex = 5;
    ((UltraControlBase) this.txtPolicyLimit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPolicyLimit).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtValuation).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtValuation).BackColor = Color.White;
    ((Control) this.txtValuation).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuoteOptionProperty.Valuation", true));
    ((Control) this.txtValuation).Location = new Point(328, 226);
    ((TextEditorControlBase) this.txtValuation).MaxLength = 500;
    this.txtValuation.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtValuation).Name = "txtValuation";
    ((Control) this.txtValuation).Size = new Size(216, 20);
    ((Control) this.txtValuation).TabIndex = 18;
    ((UltraControlBase) this.txtValuation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtValuation).UseOsThemes = (DefaultableBoolean) 2;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCoInsurance).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtCoInsurance).BackColor = Color.White;
    ((Control) this.txtCoInsurance).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuoteOptionProperty.CoInsurance", true));
    ((Control) this.txtCoInsurance).Location = new Point(328, 256 /*0x0100*/);
    ((TextEditorControlBase) this.txtCoInsurance).MaxLength = 50;
    this.txtCoInsurance.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCoInsurance).Name = "txtCoInsurance";
    ((Control) this.txtCoInsurance).Size = new Size(216, 20);
    ((Control) this.txtCoInsurance).TabIndex = 21;
    ((UltraControlBase) this.txtCoInsurance).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCoInsurance).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtOtherDeduct).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.txtOtherDeduct).BackColor = Color.White;
    ((Control) this.txtOtherDeduct).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuoteOptionProperty.OtherDeduct", true));
    ((Control) this.txtOtherDeduct).Location = new Point(96 /*0x60*/, 196);
    ((TextEditorControlBase) this.txtOtherDeduct).MaxLength = 500;
    this.txtOtherDeduct.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtOtherDeduct).Name = "txtOtherDeduct";
    ((Control) this.txtOtherDeduct).Size = new Size(448, 20);
    ((Control) this.txtOtherDeduct).TabIndex = 15;
    ((UltraControlBase) this.txtOtherDeduct).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtOtherDeduct).UseOsThemes = (DefaultableBoolean) 2;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCoverage).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.txtCoverage).BackColor = Color.White;
    ((Control) this.txtCoverage).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuoteOptionProperty.Coverage", true));
    ((Control) this.txtCoverage).Location = new Point(96 /*0x60*/, 46);
    ((TextEditorControlBase) this.txtCoverage).MaxLength = 500;
    this.txtCoverage.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCoverage).Name = "txtCoverage";
    ((Control) this.txtCoverage).Size = new Size(448, 20);
    ((Control) this.txtCoverage).TabIndex = 3;
    ((UltraControlBase) this.txtCoverage).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCoverage).UseOsThemes = (DefaultableBoolean) 2;
    this.cboCauseofLoss.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCauseofLoss.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCauseofLoss).DropDownWidth = 400;
    ((Control) this.cboCauseofLoss).Location = new Point(96 /*0x60*/, 16 /*0x10*/);
    this.cboCauseofLoss.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCauseofLoss).Name = "cboCauseofLoss";
    ((Control) this.cboCauseofLoss).Size = new Size(448, 21);
    ((Control) this.cboCauseofLoss).TabIndex = 1;
    ((UltraControlBase) this.cboCauseofLoss).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCauseofLoss).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(59, 288);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(27, 13);
    this.Label4.TabIndex = 22;
    this.Label4.Text = "TIV:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(14, 258);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(72, 13);
    this.Label17.TabIndex = 19;
    this.Label17.Text = "CoInsurance:";
    this.Label17.TextAlign = ContentAlignment.MiddleRight;
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(30, 228);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(55, 13);
    this.Label16.TabIndex = 16 /*0x10*/;
    this.Label16.Text = "Valuation:";
    this.Label16.TextAlign = ContentAlignment.MiddleRight;
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(10, 198);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(76, 13);
    this.Label15.TabIndex = 14;
    this.Label15.Text = "Other Deduct:";
    this.Label15.TextAlign = ContentAlignment.MiddleRight;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(17, 171);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(69, 13);
    this.Label7.TabIndex = 11;
    this.Label7.Text = "AOP Deduct:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(19, 138);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(65, 13);
    this.Label6.TabIndex = 9;
    this.Label6.Text = "Policy Form:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(25, 108);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(58, 13);
    this.Label5.TabIndex = 7;
    this.Label5.Text = "Sub Limits:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(21, 78);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(62, 13);
    this.Label3.TabIndex = 4;
    this.Label3.Text = "Policy Limit:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(33, 48 /*0x30*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(54, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Covering:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(8, 18);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(78, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Cause of Loss:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.cboCoInsurance.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCoInsurance.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboCoInsurance).Location = new Point(96 /*0x60*/, 256 /*0x0100*/);
    this.cboCoInsurance.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCoInsurance).Name = "cboCoInsurance";
    ((Control) this.cboCoInsurance).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.cboCoInsurance).TabIndex = 20;
    ((UltraControlBase) this.cboCoInsurance).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCoInsurance).UseOsThemes = (DefaultableBoolean) 2;
    this.cboValuations.BorderStyle = (UIElementBorderStyle) 4;
    this.cboValuations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboValuations).Location = new Point(96 /*0x60*/, 226);
    this.cboValuations.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboValuations).Name = "cboValuations";
    ((Control) this.cboValuations).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.cboValuations).TabIndex = 17;
    ((UltraControlBase) this.cboValuations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboValuations).UseOsThemes = (DefaultableBoolean) 2;
    this.cboLimitDescriptions.BorderStyle = (UIElementBorderStyle) 4;
    this.cboLimitDescriptions.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboLimitDescriptions).Location = new Point(200, 75);
    this.cboLimitDescriptions.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLimitDescriptions).Name = "cboLimitDescriptions";
    ((Control) this.cboLimitDescriptions).Size = new Size(344, 21);
    ((Control) this.cboLimitDescriptions).TabIndex = 6;
    ((UltraControlBase) this.cboLimitDescriptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLimitDescriptions).UseOsThemes = (DefaultableBoolean) 2;
    this.cboPolicyForms.BorderStyle = (UIElementBorderStyle) 4;
    this.cboPolicyForms.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboPolicyForms).Location = new Point(96 /*0x60*/, 136);
    this.cboPolicyForms.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboPolicyForms).Name = "cboPolicyForms";
    ((Control) this.cboPolicyForms).Size = new Size(448, 21);
    ((Control) this.cboPolicyForms).TabIndex = 10;
    ((UltraControlBase) this.cboPolicyForms).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPolicyForms).UseOsThemes = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSubLimits).Appearance = (AppearanceBase) appearance8;
    ((TextEditorControlBase) this.txtSubLimits).BackColor = Color.White;
    ((Control) this.txtSubLimits).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuoteOptionProperty.SubLimits", true));
    ((Control) this.txtSubLimits).Location = new Point(96 /*0x60*/, 106);
    ((TextEditorControlBase) this.txtSubLimits).MaxLength = 1000;
    this.txtSubLimits.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtSubLimits).Name = "txtSubLimits";
    ((Control) this.txtSubLimits).Size = new Size(448, 20);
    ((Control) this.txtSubLimits).TabIndex = 8;
    ((UltraControlBase) this.txtSubLimits).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSubLimits).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnContinue).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance9.BackColor = Color.Gainsboro;
    appearance9.BackColor2 = Color.White;
    appearance9.BackGradientStyle = (GradientStyle) 2;
    appearance9.BorderColor = Color.Gray;
    appearance9.ImageHAlign = (HAlign) 3;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ((ControlBase) this.btnContinue).Appearance = (AppearanceBase) appearance9;
    ((Control) this.btnContinue).Enabled = false;
    ((Control) this.btnContinue).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnContinue).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnContinue).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnContinue).Location = new Point(475, 314);
    ((Control) this.btnContinue).Name = "btnContinue";
    ((ControlBase) this.btnContinue).Padding = new Size(5, 0);
    ((Control) this.btnContinue).Size = new Size(104, 40);
    ((Control) this.btnContinue).TabIndex = 5;
    ((Control) this.btnContinue).Tag = (object) "KeepActive";
    ((ControlBase) this.btnContinue).Text = "Exposure";
    this.btnContinue.UseOSThemes = (DefaultableBoolean) 2;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(339, 314);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 4;
    this.dbSave.Tag = (object) "KeepActive";
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.ddLimit);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.ugSubLimits);
    ((Control) this.UltraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(590, 365);
    ((UltraGridBase) this.ddLimit).DataSource = (object) this.ds.lstSubLimits;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddLimit).DisplayLayout.Appearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ddLimit).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Sub-Limit";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 190;
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
    ultraGridColumn5.Header.VisiblePosition = 1;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 2;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 3;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 4;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 5;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 6;
    ultraGridBand2.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.ddLimit).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ddLimit).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddLimit).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddLimit).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddLimit).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddLimit).DisplayMember = "SubLimit";
    ((Control) this.ddLimit).Location = new Point(32 /*0x20*/, 88);
    ((Control) this.ddLimit).Name = "ddLimit";
    ((Control) this.ddLimit).Size = new Size(192 /*0xC0*/, 72);
    ((Control) this.ddLimit).TabIndex = 1;
    ((UltraControlBase) this.ddLimit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ddLimit).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ddLimit).ValueMember = "SubLimitID";
    ((Control) this.ddLimit).Visible = false;
    ((UltraGridBase) this.ugSubLimits).DataSource = (object) this.ds.tblQuoteOptionProperty_SubLimits;
    ((SpecialBoxBase) ((UltraGridBase) this.ugSubLimits).DisplayLayout.AddNewBox).Hidden = false;
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.AddButtonCaption = "Sub-Limits";
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 0;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 88;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Sub-Limit";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 1;
    ultraGridColumn12.Style = (ColumnStyle) 6;
    ultraGridColumn12.Width = 126;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance12;
    ultraGridColumn13.Format = "c";
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 2;
    ultraGridColumn13.Width = 134;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance14;
    ultraGridColumn14.Format = "c";
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance15;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 3;
    ultraGridColumn14.Width = 143;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance16;
    ultraGridColumn15.Format = "p";
    ((AppearanceBase) appearance17).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance17;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Deductible %";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 4;
    ultraGridColumn15.Width = 104;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.CellActivation = (Activation) 1;
    appearance18.FontData.UnderlineAsString = "True";
    appearance18.ForeColor = Color.Blue;
    ((AppearanceBase) appearance18).TextHAlignAsString = "Center";
    ultraGridColumn16.CellAppearance = (AppearanceBase) appearance18;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Delete";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 5;
    ultraGridColumn16.Width = 81;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 6;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 123;
    ultraGridBand3.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17
    });
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance19.BackColor = Color.LightSteelBlue;
    appearance19.FontData.SizeInPoints = 10f;
    appearance19.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance19;
    appearance20.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance20.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance21.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance21;
    appearance22.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance23.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance23;
    appearance24.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance25.BackColor = Color.Transparent;
    appearance25.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance25;
    appearance26.BackColor = Color.WhiteSmoke;
    appearance26.BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance26;
    appearance27.BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.ugSubLimits).Dock = DockStyle.Top;
    ((Control) this.ugSubLimits).Location = new Point(0, 0);
    ((Control) this.ugSubLimits).Name = "ugSubLimits";
    ((Control) this.ugSubLimits).Size = new Size(590, 276);
    ((Control) this.ugSubLimits).TabIndex = 0;
    ((UltraControlBase) this.ugSubLimits).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugSubLimits).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lnkCancelPriorRates);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.ugPrior);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtTerrorismExcess);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label21);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.options);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lnkCalculatePremium);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lnkMiscPremiums);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lnkCalculateRate);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtPriorRate);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtRate);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label8);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label9);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtTerrorism);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtExcess);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtPrimary);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label12);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblTotalPremium);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label11);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label13);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblExcessPremium);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.chkTerrorism);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(590, 365);
    this.lnkCancelPriorRates.AutoSize = true;
    this.lnkCancelPriorRates.BackColor = Color.Transparent;
    this.lnkCancelPriorRates.Location = new Point(323, 214);
    this.lnkCancelPriorRates.Name = "lnkCancelPriorRates";
    this.lnkCancelPriorRates.Size = new Size(95, 13);
    this.lnkCancelPriorRates.TabIndex = 23;
    this.lnkCancelPriorRates.TabStop = true;
    this.lnkCancelPriorRates.Text = "Cancel Prior Rates";
    ((UltraControlBase) this.ugPrior).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugPrior).DataMember = "tblPropertyExposuresPriorYears";
    ((UltraGridBase) this.ugPrior).DataSource = (object) this.ds;
    appearance28.BackColor = Color.WhiteSmoke;
    appearance28.BorderColor = Color.DarkGray;
    ((SpecialBoxBase) ((UltraGridBase) this.ugPrior).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance28;
    appearance29.BackColor = Color.WhiteSmoke;
    appearance29.BorderColor = Color.WhiteSmoke;
    appearance29.FontData.UnderlineAsString = "True";
    appearance29.ForeColor = Color.Blue;
    ((UltraGridBase) this.ugPrior).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance29;
    ((SpecialBoxBase) ((UltraGridBase) this.ugPrior).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.ugPrior).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.ugPrior).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance30.BackColor = Color.White;
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugPrior).DisplayLayout.Appearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.ugPrior).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand4.AddButtonCaption = "Add Prior Rate";
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 0;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 1;
    ultraGridColumn19.Width = 8;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Prior Rate";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 2;
    ultraGridColumn20.Width = 107;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance31).TextHAlignAsString = "Right";
    ultraGridColumn21.CellAppearance = (AppearanceBase) appearance31;
    ultraGridColumn21.Format = "c";
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Incurred Loss";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 3;
    ultraGridColumn21.Width = 111;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 4;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn23.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn23.Header).Caption = "Auto Applied";
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 5;
    ultraGridColumn23.Width = 67;
    ultraGridBand4.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23
    });
    ((UltraGridBase) this.ugPrior).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ugPrior).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance32.BackColor = Color.LightSteelBlue;
    appearance32.FontData.SizeInPoints = 10f;
    appearance32.ForeColor = Color.Black;
    ((UltraGridBase) this.ugPrior).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance32;
    appearance33.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance33.ForeColor = Color.Black;
    ((UltraGridBase) this.ugPrior).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance33;
    ((UltraGridBase) this.ugPrior).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugPrior).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugPrior).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance34.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugPrior).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance34;
    appearance35.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugPrior).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance35;
    ((UltraGridBase) this.ugPrior).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance36.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugPrior).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance36;
    appearance37.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugPrior).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance37;
    ((UltraGridBase) this.ugPrior).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugPrior).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance38.BackColor = Color.Transparent;
    appearance38.ForeColor = Color.Black;
    ((UltraGridBase) this.ugPrior).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance38;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 2;
    ((UltraGridBase) this.ugPrior).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.ugPrior).Location = new Point(3, 205);
    ((Control) this.ugPrior).Name = "ugPrior";
    ((Control) this.ugPrior).Size = new Size(314, 153);
    ((Control) this.ugPrior).TabIndex = 21;
    ((Control) this.ugPrior).Text = "Prior Rates";
    ((UltraControlBase) this.ugPrior).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugPrior).UseOsThemes = (DefaultableBoolean) 2;
    appearance39.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtTerrorismExcess).Appearance = (AppearanceBase) appearance39;
    ((Control) this.txtTerrorismExcess).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.TerrorismExcessPremium", true));
    ((UltraNumericEditorBase) this.txtTerrorismExcess).FormatString = "c";
    ((Control) this.txtTerrorismExcess).Location = new Point(120, 89);
    this.txtTerrorismExcess.MaskInput = "-nnn,nnn,nnn.nn";
    this.txtTerrorismExcess.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtTerrorismExcess).Name = "txtTerrorismExcess";
    this.txtTerrorismExcess.Nullable = true;
    this.txtTerrorismExcess.NumericType = (NumericType) 1;
    ((Control) this.txtTerrorismExcess).Size = new Size(88, 20);
    ((Control) this.txtTerrorismExcess).TabIndex = 20;
    ((UltraControlBase) this.txtTerrorismExcess).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTerrorismExcess).UseOsThemes = (DefaultableBoolean) 2;
    this.Label21.AutoSize = true;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Location = new Point(9, 93);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(88, 13);
    this.Label21.TabIndex = 19;
    this.Label21.Text = "Terrorism Excess";
    this.Label21.TextAlign = ContentAlignment.MiddleRight;
    appearance40.BackColor = Color.Transparent;
    appearance40.BackColorDisabled = Color.Transparent;
    this.options.Appearance = (AppearanceBase) appearance40;
    this.options.BackColor = Color.Transparent;
    this.options.BackColorInternal = Color.Transparent;
    this.options.BorderStyle = (UIElementBorderStyle) 1;
    this.options.CheckedIndex = 0;
    ((Control) this.options).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.RateBasedOffTIV", true));
    valueListItem1.DataValue = (object) true;
    valueListItem1.DisplayText = "Calculate rate by TIV";
    ((SubObjectBase) valueListItem1).Tag = (object) "Tiv";
    valueListItem2.DataValue = (object) false;
    valueListItem2.DisplayText = "Calculate rate by policy limit";
    ((SubObjectBase) valueListItem2).Tag = (object) "Limit";
    this.options.Items.AddRange(new ValueListItem[2]
    {
      valueListItem1,
      valueListItem2
    });
    this.options.ItemSpacingVertical = 5;
    ((Control) this.options).Location = new Point(288, 155);
    ((Control) this.options).Name = "options";
    ((Control) this.options).Size = new Size(168, 40);
    ((Control) this.options).TabIndex = 18;
    this.options.Text = "Calculate rate by TIV";
    ((UltraControlBase) this.options).UseFlatMode = (DefaultableBoolean) 1;
    this.lnkCalculatePremium.AutoSize = true;
    this.lnkCalculatePremium.BackColor = Color.Transparent;
    this.lnkCalculatePremium.Location = new Point(216, 20);
    this.lnkCalculatePremium.Name = "lnkCalculatePremium";
    this.lnkCalculatePremium.Size = new Size(57, 13);
    this.lnkCalculatePremium.TabIndex = 15;
    this.lnkCalculatePremium.TabStop = true;
    this.lnkCalculatePremium.Text = "(calculate)";
    this.lnkCalculatePremium.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkMiscPremiums.AutoSize = true;
    this.lnkMiscPremiums.BackColor = Color.Transparent;
    this.lnkMiscPremiums.Location = new Point(216, 119);
    this.lnkMiscPremiums.Name = "lnkMiscPremiums";
    this.lnkMiscPremiums.Size = new Size(101, 13);
    this.lnkMiscPremiums.TabIndex = 14;
    this.lnkMiscPremiums.TabStop = true;
    this.lnkMiscPremiums.Text = "Add Misc. Premiums";
    this.lnkMiscPremiums.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkMiscPremiums.Visible = false;
    this.lnkCalculateRate.AutoSize = true;
    this.lnkCalculateRate.BackColor = Color.Transparent;
    this.lnkCalculateRate.Location = new Point(216, 155);
    this.lnkCalculateRate.Name = "lnkCalculateRate";
    this.lnkCalculateRate.Size = new Size(57, 13);
    this.lnkCalculateRate.TabIndex = 11;
    this.lnkCalculateRate.TabStop = true;
    this.lnkCalculateRate.Text = "(calculate)";
    this.lnkCalculateRate.TextAlign = ContentAlignment.MiddleLeft;
    appearance41.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtPriorRate).Appearance = (AppearanceBase) appearance41;
    ((Control) this.txtPriorRate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.PriorRate", true));
    ((Control) this.txtPriorRate).Location = new Point(120, 179);
    this.txtPriorRate.MaskInput = "nn.nnnn";
    this.txtPriorRate.MaxValue = (object) 99.9999;
    this.txtPriorRate.MGAStyle = MGAStyles.Blue;
    this.txtPriorRate.MinValue = (object) 0.0001;
    ((Control) this.txtPriorRate).Name = "txtPriorRate";
    this.txtPriorRate.Nullable = true;
    this.txtPriorRate.NumericType = (NumericType) 1;
    ((Control) this.txtPriorRate).Size = new Size(88, 20);
    ((Control) this.txtPriorRate).TabIndex = 13;
    ((UltraControlBase) this.txtPriorRate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPriorRate).UseOsThemes = (DefaultableBoolean) 2;
    appearance42.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtRate).Appearance = (AppearanceBase) appearance42;
    ((Control) this.txtRate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.Rate", true));
    ((Control) this.txtRate).Location = new Point(120, 155);
    this.txtRate.MaskInput = "nn.nnnn";
    this.txtRate.MaxValue = (object) 99.9999;
    this.txtRate.MGAStyle = MGAStyles.Blue;
    this.txtRate.MinValue = (object) 0.0001;
    ((Control) this.txtRate).Name = "txtRate";
    this.txtRate.Nullable = true;
    this.txtRate.NumericType = (NumericType) 1;
    ((Control) this.txtRate).Size = new Size(88, 20);
    ((Control) this.txtRate).TabIndex = 10;
    ((UltraControlBase) this.txtRate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRate).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(55, 182);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(55, 13);
    this.Label8.TabIndex = 12;
    this.Label8.Text = "Prior Rate";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(82, 158);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(30, 13);
    this.Label9.TabIndex = 9;
    this.Label9.Text = "Rate";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    appearance43.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtTerrorism).Appearance = (AppearanceBase) appearance43;
    ((Control) this.txtTerrorism).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.TerrPremium", true));
    ((UltraNumericEditorBase) this.txtTerrorism).FormatString = "c";
    ((Control) this.txtTerrorism).Location = new Point(120, 64 /*0x40*/);
    this.txtTerrorism.MaskInput = "-nnn,nnn,nnn.nn";
    this.txtTerrorism.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtTerrorism).Name = "txtTerrorism";
    this.txtTerrorism.Nullable = true;
    this.txtTerrorism.NumericType = (NumericType) 1;
    ((Control) this.txtTerrorism).Size = new Size(88, 20);
    ((Control) this.txtTerrorism).TabIndex = 5;
    ((UltraControlBase) this.txtTerrorism).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTerrorism).UseOsThemes = (DefaultableBoolean) 2;
    appearance44.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtExcess).Appearance = (AppearanceBase) appearance44;
    ((Control) this.txtExcess).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.ExcessPremium", true));
    ((UltraNumericEditorBase) this.txtExcess).FormatString = "c";
    ((Control) this.txtExcess).Location = new Point(120, 40);
    this.txtExcess.MaskInput = "-nnn,nnn,nnn.nn";
    this.txtExcess.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtExcess).Name = "txtExcess";
    this.txtExcess.Nullable = true;
    this.txtExcess.NumericType = (NumericType) 1;
    ((Control) this.txtExcess).Size = new Size(88, 20);
    ((Control) this.txtExcess).TabIndex = 3;
    ((UltraControlBase) this.txtExcess).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtExcess).UseOsThemes = (DefaultableBoolean) 2;
    appearance45.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtPrimary).Appearance = (AppearanceBase) appearance45;
    ((Control) this.txtPrimary).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.PrimaryPremium", true));
    ((UltraNumericEditorBase) this.txtPrimary).FormatString = "c";
    ((Control) this.txtPrimary).Location = new Point(120, 16 /*0x10*/);
    this.txtPrimary.MaskInput = "-nnn,nnn,nnn.nn";
    this.txtPrimary.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPrimary).Name = "txtPrimary";
    this.txtPrimary.Nullable = true;
    this.txtPrimary.NumericType = (NumericType) 1;
    ((Control) this.txtPrimary).Size = new Size(88, 20);
    ((Control) this.txtPrimary).TabIndex = 1;
    ((UltraControlBase) this.txtPrimary).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPrimary).UseOsThemes = (DefaultableBoolean) 2;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(9, 119);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(74, 13);
    this.Label12.TabIndex = 7;
    this.Label12.Text = "Total Premium";
    this.Label12.TextAlign = ContentAlignment.MiddleRight;
    appearance46.BackColor = Color.Transparent;
    appearance46.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance46).TextHAlignAsString = "Right";
    ((AppearanceBase) appearance46).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblTotalPremium).Appearance = (AppearanceBase) appearance46;
    ((ControlBase) this.lblTotalPremium).BackColorInternal = Color.WhiteSmoke;
    this.lblTotalPremium.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblTotalPremium).Location = new Point(120, 115);
    ((Control) this.lblTotalPremium).Name = "lblTotalPremium";
    ((Control) this.lblTotalPremium).Size = new Size(88, 21);
    ((Control) this.lblTotalPremium).TabIndex = 8;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(9, 20);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(86, 13);
    this.Label11.TabIndex = 0;
    this.Label11.Text = "Primary Premium";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(9, 68);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(95, 13);
    this.Label13.TabIndex = 4;
    this.Label13.Text = "Terrorism Premium";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    this.lblExcessPremium.AutoSize = true;
    this.lblExcessPremium.BackColor = Color.Transparent;
    this.lblExcessPremium.Location = new Point(9, 44);
    this.lblExcessPremium.Name = "lblExcessPremium";
    this.lblExcessPremium.Size = new Size(83, 13);
    this.lblExcessPremium.TabIndex = 2;
    this.lblExcessPremium.Text = "Excess Premium";
    this.lblExcessPremium.TextAlign = ContentAlignment.MiddleRight;
    ((UltraToggleEditorBase) this.chkTerrorism).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkTerrorism).BackColorInternal = Color.Transparent;
    ((Control) this.chkTerrorism).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblQuoteOptionProperty.TerrorismDeclined", true));
    ((Control) this.chkTerrorism).Location = new Point(216, 64 /*0x40*/);
    ((Control) this.chkTerrorism).Name = "chkTerrorism";
    ((Control) this.chkTerrorism).Size = new Size(72, 20);
    ((Control) this.chkTerrorism).TabIndex = 6;
    ((UltraToggleEditorBase) this.chkTerrorism).Text = "Declined";
    ((UltraControlBase) this.chkTerrorism).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkTerrorism).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lnkFCW);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtAdditionalComments);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(590, 365);
    this.lnkFCW.AutoSize = true;
    this.lnkFCW.BackColor = Color.Transparent;
    this.lnkFCW.Location = new Point(8, 264);
    this.lnkFCW.Name = "lnkFCW";
    this.lnkFCW.Size = new Size(291, 13);
    this.lnkFCW.TabIndex = 1;
    this.lnkFCW.TabStop = true;
    this.lnkFCW.Tag = (object) "keepActive";
    this.lnkFCW.Text = "Click here to add forms/conditions/warranties to this policy.";
    this.txtAdditionalComments.AcceptsReturn = true;
    appearance47.BackColor = Color.White;
    appearance47.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance47.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAdditionalComments).Appearance = (AppearanceBase) appearance47;
    ((TextEditorControlBase) this.txtAdditionalComments).BackColor = Color.White;
    ((Control) this.txtAdditionalComments).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuoteOptionProperty.AdditionalComments", true));
    ((Control) this.txtAdditionalComments).Location = new Point(8, 8);
    ((TextEditorControlBase) this.txtAdditionalComments).MaxLength = 2000;
    this.txtAdditionalComments.MGAStyle = MGAStyles.Blue;
    this.txtAdditionalComments.Multiline = true;
    ((Control) this.txtAdditionalComments).Name = "txtAdditionalComments";
    ((Control) this.txtAdditionalComments).Size = new Size(440, 248);
    ((Control) this.txtAdditionalComments).TabIndex = 0;
    ((UltraControlBase) this.txtAdditionalComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAdditionalComments).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tabUnderlying).Controls.Add((Control) this.txtUnderlyingDeductible);
    ((Control) this.tabUnderlying).Controls.Add((Control) this.Label20);
    ((Control) this.tabUnderlying).Controls.Add((Control) this.txtUnderlyingLimit);
    ((Control) this.tabUnderlying).Controls.Add((Control) this.Label19);
    ((Control) this.tabUnderlying).Controls.Add((Control) this.txtUnderlyingPolicyNumber);
    ((Control) this.tabUnderlying).Controls.Add((Control) this.Label18);
    ((Control) this.tabUnderlying).Controls.Add((Control) this.txtUnderlyingCarrier);
    ((Control) this.tabUnderlying).Controls.Add((Control) this.Label10);
    ((Control) this.tabUnderlying).Location = new Point(-10000, -10000);
    ((Control) this.tabUnderlying).Name = "tabUnderlying";
    ((Control) this.tabUnderlying).Size = new Size(590, 365);
    appearance48.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtUnderlyingDeductible).Appearance = (AppearanceBase) appearance48;
    ((Control) this.txtUnderlyingDeductible).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.UnderlyingDA", true));
    ((UltraNumericEditorBase) this.txtUnderlyingDeductible).FormatString = "c";
    ((Control) this.txtUnderlyingDeductible).Location = new Point(136, 120);
    this.txtUnderlyingDeductible.MGAStyle = MGAStyles.Blue;
    this.txtUnderlyingDeductible.MinValue = (object) 0;
    ((Control) this.txtUnderlyingDeductible).Name = "txtUnderlyingDeductible";
    this.txtUnderlyingDeductible.Nullable = true;
    ((Control) this.txtUnderlyingDeductible).Size = new Size(100, 20);
    ((Control) this.txtUnderlyingDeductible).TabIndex = 26;
    ((UltraControlBase) this.txtUnderlyingDeductible).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtUnderlyingDeductible).UseOsThemes = (DefaultableBoolean) 2;
    this.Label20.AutoSize = true;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Location = new Point(8, 122);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(115, 13);
    this.Label20.TabIndex = 25;
    this.Label20.Text = "Underlying Deductible:";
    this.Label20.TextAlign = ContentAlignment.MiddleRight;
    appearance49.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtUnderlyingLimit).Appearance = (AppearanceBase) appearance49;
    ((Control) this.txtUnderlyingLimit).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.UnderlyingLimit", true));
    ((UltraNumericEditorBase) this.txtUnderlyingLimit).FormatString = "c";
    ((Control) this.txtUnderlyingLimit).Location = new Point(136, 88);
    this.txtUnderlyingLimit.MGAStyle = MGAStyles.Blue;
    this.txtUnderlyingLimit.MinValue = (object) 0;
    ((Control) this.txtUnderlyingLimit).Name = "txtUnderlyingLimit";
    this.txtUnderlyingLimit.Nullable = true;
    ((Control) this.txtUnderlyingLimit).Size = new Size(100, 20);
    ((Control) this.txtUnderlyingLimit).TabIndex = 24;
    ((UltraControlBase) this.txtUnderlyingLimit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtUnderlyingLimit).UseOsThemes = (DefaultableBoolean) 2;
    this.Label19.AutoSize = true;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Location = new Point(37, 90);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(86, 13);
    this.Label19.TabIndex = 8;
    this.Label19.Text = "Underlying Limit:";
    this.Label19.TextAlign = ContentAlignment.MiddleRight;
    appearance50.BackColor = Color.White;
    appearance50.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance50.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtUnderlyingPolicyNumber).Appearance = (AppearanceBase) appearance50;
    ((TextEditorControlBase) this.txtUnderlyingPolicyNumber).BackColor = Color.White;
    ((Control) this.txtUnderlyingPolicyNumber).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuoteOptionProperty.UnderlyingPolNo", true));
    ((Control) this.txtUnderlyingPolicyNumber).Location = new Point(136, 56);
    ((TextEditorControlBase) this.txtUnderlyingPolicyNumber).MaxLength = 50;
    this.txtUnderlyingPolicyNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtUnderlyingPolicyNumber).Name = "txtUnderlyingPolicyNumber";
    ((Control) this.txtUnderlyingPolicyNumber).Size = new Size(216, 20);
    ((Control) this.txtUnderlyingPolicyNumber).TabIndex = 7;
    ((UltraControlBase) this.txtUnderlyingPolicyNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtUnderlyingPolicyNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(21, 58);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(103, 13);
    this.Label18.TabIndex = 6;
    this.Label18.Text = "Underlying Policy #:";
    this.Label18.TextAlign = ContentAlignment.MiddleRight;
    appearance51.BackColor = Color.White;
    appearance51.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance51.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtUnderlyingCarrier).Appearance = (AppearanceBase) appearance51;
    ((TextEditorControlBase) this.txtUnderlyingCarrier).BackColor = Color.White;
    ((Control) this.txtUnderlyingCarrier).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuoteOptionProperty.UnderlyingCarrier", true));
    ((Control) this.txtUnderlyingCarrier).Location = new Point(136, 24);
    ((TextEditorControlBase) this.txtUnderlyingCarrier).MaxLength = 50;
    this.txtUnderlyingCarrier.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtUnderlyingCarrier).Name = "txtUnderlyingCarrier";
    ((Control) this.txtUnderlyingCarrier).Size = new Size(216, 20);
    ((Control) this.txtUnderlyingCarrier).TabIndex = 5;
    ((UltraControlBase) this.txtUnderlyingCarrier).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtUnderlyingCarrier).UseOsThemes = (DefaultableBoolean) 2;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(27, 26);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(98, 13);
    this.Label10.TabIndex = 4;
    this.Label10.Text = "Underlying Carrier:";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    this.daLookups.SelectCommand = this.SqlSelectCommand1;
    this.daLookups.TableMappings.AddRange(new DataTableMapping[5]
    {
      new DataTableMapping("Table", "PropertyRaterLookups", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Peril", "Peril")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("LimitDescrip", "LimitDescrip")
      }),
      new DataTableMapping("Table2", "Table2", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("PolicyForm", "PolicyForm")
      }),
      new DataTableMapping("Table3", "Table3", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Valuation", "Valuation")
      }),
      new DataTableMapping("Table4", "Table4", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("CoIns", "CoIns")
      })
    });
    this.SqlSelectCommand1.CommandText = "[PropertyRaterLookups]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.err.ContainerControl = (ContainerControl) this;
    this.daOptionsProperty.DeleteCommand = this.SqlDeleteCommand1;
    this.daOptionsProperty.InsertCommand = this.SqlInsertCommand1;
    this.daOptionsProperty.SelectCommand = this.SqlSelectCommand2;
    this.daOptionsProperty.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteOptionProperty", new DataColumnMapping[30]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("PriorID", "PriorID"),
        new DataColumnMapping("QuoteOptionID", "QuoteOptionID"),
        new DataColumnMapping("TerrorismDeclined", "TerrorismDeclined"),
        new DataColumnMapping("CauseofLossID", "CauseofLossID"),
        new DataColumnMapping("PolicyLimitDescriptionID", "PolicyLimitDescriptionID"),
        new DataColumnMapping("PolicyFormID", "PolicyFormID"),
        new DataColumnMapping("ValuationID", "ValuationID"),
        new DataColumnMapping("CoInsuranceID", "CoInsuranceID"),
        new DataColumnMapping("TIV", "TIV"),
        new DataColumnMapping("Coverage", "Coverage"),
        new DataColumnMapping("PolicyLimit", "PolicyLimit"),
        new DataColumnMapping("SubLimits", "SubLimits"),
        new DataColumnMapping("AOPDA", "AOPDA"),
        new DataColumnMapping("OtherDeduct", "OtherDeduct"),
        new DataColumnMapping("PrimaryPremium", "PrimaryPremium"),
        new DataColumnMapping("ExcessPremium", "ExcessPremium"),
        new DataColumnMapping("TerrPremium", "TerrPremium"),
        new DataColumnMapping("AdditionalComments", "AdditionalComments"),
        new DataColumnMapping("CoInsurance", "CoInsurance"),
        new DataColumnMapping("Rate", "Rate"),
        new DataColumnMapping("PriorRate", "PriorRate"),
        new DataColumnMapping("Valuation", "Valuation"),
        new DataColumnMapping("DeductiblePerID", "DeductiblePerID"),
        new DataColumnMapping("UnderlyingCarrier", "UnderlyingCarrier"),
        new DataColumnMapping("UnderlyingPolNo", "UnderlyingPolNo"),
        new DataColumnMapping("UnderlyingLimit", "UnderlyingLimit"),
        new DataColumnMapping("UnderlyingDA", "UnderlyingDA"),
        new DataColumnMapping("RateBasedOffTIV", "RateBasedOffTIV"),
        new DataColumnMapping("TerrorismExcessPremium", "TerrorismExcessPremium")
      })
    });
    this.daOptionsProperty.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [tblQuoteOptionProperty] WHERE (([ID] = @Original_ID))";
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[29]
    {
      new SqlParameter("@PriorID", SqlDbType.Int, 0, "PriorID"),
      new SqlParameter("@QuoteOptionID", SqlDbType.Int, 0, "QuoteOptionID"),
      new SqlParameter("@TerrorismDeclined", SqlDbType.Bit, 0, "TerrorismDeclined"),
      new SqlParameter("@CauseofLossID", SqlDbType.Int, 4, "CauseofLossID"),
      new SqlParameter("@PolicyLimitDescriptionID", SqlDbType.TinyInt, 0, "PolicyLimitDescriptionID"),
      new SqlParameter("@PolicyFormID", SqlDbType.TinyInt, 0, "PolicyFormID"),
      new SqlParameter("@ValuationID", SqlDbType.TinyInt, 0, "ValuationID"),
      new SqlParameter("@CoInsuranceID", SqlDbType.TinyInt, 0, "CoInsuranceID"),
      new SqlParameter("@TIV", SqlDbType.Money, 0, "TIV"),
      new SqlParameter("@Coverage", SqlDbType.VarChar, 0, "Coverage"),
      new SqlParameter("@PolicyLimit", SqlDbType.Money, 0, "PolicyLimit"),
      new SqlParameter("@SubLimits", SqlDbType.VarChar, 0, "SubLimits"),
      new SqlParameter("@AOPDA", SqlDbType.Int, 0, "AOPDA"),
      new SqlParameter("@OtherDeduct", SqlDbType.VarChar, 0, "OtherDeduct"),
      new SqlParameter("@PrimaryPremium", SqlDbType.Money, 0, "PrimaryPremium"),
      new SqlParameter("@ExcessPremium", SqlDbType.Money, 0, "ExcessPremium"),
      new SqlParameter("@TerrPremium", SqlDbType.Money, 0, "TerrPremium"),
      new SqlParameter("@AdditionalComments", SqlDbType.VarChar, 0, "AdditionalComments"),
      new SqlParameter("@CoInsurance", SqlDbType.VarChar, 0, "CoInsurance"),
      new SqlParameter("@Rate", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 6, (byte) 4, "Rate", DataRowVersion.Current, (object) null),
      new SqlParameter("@PriorRate", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 6, (byte) 4, "PriorRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@Valuation", SqlDbType.VarChar, 0, "Valuation"),
      new SqlParameter("@DeductiblePerID", SqlDbType.Char, 0, "DeductiblePerID"),
      new SqlParameter("@UnderlyingCarrier", SqlDbType.VarChar, 0, "UnderlyingCarrier"),
      new SqlParameter("@UnderlyingPolNo", SqlDbType.VarChar, 0, "UnderlyingPolNo"),
      new SqlParameter("@UnderlyingLimit", SqlDbType.VarChar, 0, "UnderlyingLimit"),
      new SqlParameter("@UnderlyingDA", SqlDbType.VarChar, 0, "UnderlyingDA"),
      new SqlParameter("@RateBasedOffTIV", SqlDbType.Bit, 0, "RateBasedOffTIV"),
      new SqlParameter("@TerrorismExcessPremium", SqlDbType.Money, 0, "TerrorismExcessPremium")
    });
    this.SqlSelectCommand2.CommandText = componentResourceManager.GetString("SqlSelectCommand2.CommandText");
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[31 /*0x1F*/]
    {
      new SqlParameter("@PriorID", SqlDbType.Int, 0, "PriorID"),
      new SqlParameter("@QuoteOptionID", SqlDbType.Int, 0, "QuoteOptionID"),
      new SqlParameter("@TerrorismDeclined", SqlDbType.Bit, 0, "TerrorismDeclined"),
      new SqlParameter("@CauseofLossID", SqlDbType.Int, 4, "CauseofLossID"),
      new SqlParameter("@PolicyLimitDescriptionID", SqlDbType.TinyInt, 0, "PolicyLimitDescriptionID"),
      new SqlParameter("@PolicyFormID", SqlDbType.TinyInt, 0, "PolicyFormID"),
      new SqlParameter("@ValuationID", SqlDbType.TinyInt, 0, "ValuationID"),
      new SqlParameter("@CoInsuranceID", SqlDbType.TinyInt, 0, "CoInsuranceID"),
      new SqlParameter("@TIV", SqlDbType.Money, 0, "TIV"),
      new SqlParameter("@Coverage", SqlDbType.VarChar, 0, "Coverage"),
      new SqlParameter("@PolicyLimit", SqlDbType.Money, 0, "PolicyLimit"),
      new SqlParameter("@SubLimits", SqlDbType.VarChar, 0, "SubLimits"),
      new SqlParameter("@AOPDA", SqlDbType.Int, 0, "AOPDA"),
      new SqlParameter("@OtherDeduct", SqlDbType.VarChar, 0, "OtherDeduct"),
      new SqlParameter("@PrimaryPremium", SqlDbType.Money, 0, "PrimaryPremium"),
      new SqlParameter("@ExcessPremium", SqlDbType.Money, 0, "ExcessPremium"),
      new SqlParameter("@TerrPremium", SqlDbType.Money, 0, "TerrPremium"),
      new SqlParameter("@AdditionalComments", SqlDbType.VarChar, 0, "AdditionalComments"),
      new SqlParameter("@CoInsurance", SqlDbType.VarChar, 0, "CoInsurance"),
      new SqlParameter("@Rate", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 6, (byte) 4, "Rate", DataRowVersion.Current, (object) null),
      new SqlParameter("@PriorRate", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 6, (byte) 4, "PriorRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@Valuation", SqlDbType.VarChar, 0, "Valuation"),
      new SqlParameter("@DeductiblePerID", SqlDbType.Char, 0, "DeductiblePerID"),
      new SqlParameter("@UnderlyingCarrier", SqlDbType.VarChar, 0, "UnderlyingCarrier"),
      new SqlParameter("@UnderlyingPolNo", SqlDbType.VarChar, 0, "UnderlyingPolNo"),
      new SqlParameter("@UnderlyingLimit", SqlDbType.VarChar, 0, "UnderlyingLimit"),
      new SqlParameter("@UnderlyingDA", SqlDbType.VarChar, 0, "UnderlyingDA"),
      new SqlParameter("@RateBasedOffTIV", SqlDbType.Bit, 0, "RateBasedOffTIV"),
      new SqlParameter("@TerrorismExcessPremium", SqlDbType.Money, 0, "TerrorismExcessPremium"),
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    this.daOptions.DeleteCommand = this.SqlCommand1;
    this.daOptions.InsertCommand = this.SqlCommand2;
    this.daOptions.SelectCommand = this.SqlSelectCommand3;
    this.daOptions.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteOptions", new DataColumnMapping[5]
      {
        new DataColumnMapping("QuoteOptionID", "QuoteOptionID"),
        new DataColumnMapping("QuoteOptionGUID", "QuoteOptionGUID"),
        new DataColumnMapping("QuoteGUID", "QuoteGUID"),
        new DataColumnMapping("LineGUID", "LineGUID"),
        new DataColumnMapping("Premium", "Premium")
      })
    });
    this.daOptions.UpdateCommand = this.SqlCommand3;
    this.SqlCommand1.CommandText = componentResourceManager.GetString("SqlCommand1.CommandText");
    this.SqlCommand1.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@Original_QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Premium", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Premium", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_QuoteOptionID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionID", DataRowVersion.Original, (object) null)
    });
    this.SqlCommand2.CommandText = componentResourceManager.GetString("SqlCommand2.CommandText");
    this.SqlCommand2.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGUID"),
      new SqlParameter("@QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID")
    });
    this.SqlSelectCommand3.CommandText = "SELECT QuoteOptionID, QuoteOptionGUID, QuoteGUID, LineGUID, Premium FROM tblQuoteOptions WHERE (QuoteGUID = @QuoteGuid) AND LineGUID = (@LineGuid)";
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGuid")
    });
    this.SqlCommand3.CommandText = componentResourceManager.GetString("SqlCommand3.CommandText");
    this.SqlCommand3.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGUID"),
      new SqlParameter("@QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID"),
      new SqlParameter("@Original_QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteGUID", DataRowVersion.Original, (object) null)
    });
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl4);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.tabUnderlying);
    ((Control) this.UltraTabControl1).Location = new Point(0, 190);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControls.AddRange(new Control[2]
    {
      (Control) this.btnContinue,
      (Control) this.dbSave
    });
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(592, 392);
    ((Control) this.UltraTabControl1).TabIndex = 1;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.UltraTabControl1).TabPadding = new Size(5, 3);
    appearance52.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance52.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance52;
    ultraTab1.Key = "tabPolicyInfo";
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Policy Info";
    appearance53.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance53.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance53;
    ultraTab2.Key = "tabSubLimits";
    ultraTab2.TabPage = this.UltraTabPageControl4;
    ultraTab2.Text = "Sub-Limits";
    appearance54.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance54.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance54;
    ultraTab3.Key = "tabPremiums";
    ultraTab3.TabPage = this.UltraTabPageControl2;
    ultraTab3.Text = "Premiums / Rates";
    appearance55.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance55.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance55;
    ultraTab4.Key = "tabComments";
    ultraTab4.TabPage = this.UltraTabPageControl3;
    ultraTab4.Text = "Comments";
    appearance56.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance56.Image"));
    ultraTab5.Appearance = (AppearanceBase) appearance56;
    ultraTab5.Key = "tabUnderlying";
    ultraTab5.TabPage = this.tabUnderlying;
    ultraTab5.Text = "Underlying";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[5]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5
    });
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnContinue);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(590, 365);
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (frmRaterBase);
    this.UltraToolbarsManager1.MdiMergeable = false;
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "UltraToolbar1";
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "contextMenu";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool1
    });
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).Caption = "&Copy Option";
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[2]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool2
    });
    this.UltraToolbarsManager1.Visible = false;
    this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.ugOptions, "contextMenu");
    ((UltraControlBase) this.ugOptions).Cursor = Cursors.Default;
    ((UltraGridBase) this.ugOptions).DataSource = (object) this.ds.tblQuoteOptionProperty;
    appearance57.BackColor = Color.White;
    appearance57.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugOptions).DisplayLayout.Appearance = (AppearanceBase) appearance57;
    ((UltraGridBase) this.ugOptions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 5;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 74;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 0;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 8;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 1;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 14;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 2;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 44;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 3;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 20;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 4;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 30;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 6;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 18;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 7;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 17;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 8;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 20;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance58).TextHAlignAsString = "Right";
    ultraGridColumn33.CellAppearance = (AppearanceBase) appearance58;
    ultraGridColumn33.Format = "c";
    ((AppearanceBase) appearance59).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn33.Header).Appearance = (AppearanceBase) appearance59;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 9;
    ultraGridColumn33.Width = 92;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 10;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn34.Width = 72;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance60).TextHAlignAsString = "Right";
    ultraGridColumn35.CellAppearance = (AppearanceBase) appearance60;
    ultraGridColumn35.Format = "c";
    ((AppearanceBase) appearance61).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn35.Header).Appearance = (AppearanceBase) appearance61;
    ((HeaderBase) ultraGridColumn35.Header).Caption = "Policy Limit";
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 11;
    ultraGridColumn35.Width = 138;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 12;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn36.Width = 35;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 13;
    ultraGridColumn37.Hidden = true;
    ultraGridColumn37.Width = 47;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 14;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 30;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 15;
    ultraGridColumn39.Hidden = true;
    ultraGridColumn39.Width = 83;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance62).TextHAlignAsString = "Right";
    ultraGridColumn40.CellAppearance = (AppearanceBase) appearance62;
    ultraGridColumn40.Format = "c";
    ((AppearanceBase) appearance63).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn40.Header).Appearance = (AppearanceBase) appearance63;
    ((HeaderBase) ultraGridColumn40.Header).Caption = "Primary";
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn40.Width = 97;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance64).TextHAlignAsString = "Right";
    ultraGridColumn41.CellAppearance = (AppearanceBase) appearance64;
    ultraGridColumn41.Format = "c";
    ((AppearanceBase) appearance65).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn41.Header).Appearance = (AppearanceBase) appearance65;
    ((HeaderBase) ultraGridColumn41.Header).Caption = "Excess";
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 17;
    ultraGridColumn41.Width = 95;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance66).TextHAlignAsString = "Right";
    ultraGridColumn42.CellAppearance = (AppearanceBase) appearance66;
    ultraGridColumn42.Format = "c";
    ((AppearanceBase) appearance67).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn42.Header).Appearance = (AppearanceBase) appearance67;
    ((HeaderBase) ultraGridColumn42.Header).Caption = "Terrorism";
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 18;
    ultraGridColumn42.Width = 84;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 19;
    ultraGridColumn43.Hidden = true;
    ultraGridColumn43.Width = 45;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 20;
    ultraGridColumn44.Hidden = true;
    ultraGridColumn44.Width = 37;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 21;
    ultraGridColumn45.Hidden = true;
    ultraGridColumn45.Width = 29;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 22;
    ultraGridColumn46.Hidden = true;
    ultraGridColumn46.Width = 29;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 23;
    ultraGridColumn47.Hidden = true;
    ultraGridColumn47.Width = 37;
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 24;
    ultraGridColumn48.Hidden = true;
    ultraGridColumn48.Width = 62;
    ultraGridColumn49.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 25;
    ultraGridColumn49.Hidden = true;
    ultraGridColumn49.Width = 60;
    ultraGridColumn50.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 26;
    ultraGridColumn50.Hidden = true;
    ultraGridColumn50.Width = 59;
    ultraGridColumn51.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 27;
    ultraGridColumn51.Hidden = true;
    ultraGridColumn51.Width = 59;
    ultraGridColumn52.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn52.Header).Caption = "Rate Based Off TIV";
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 28;
    ultraGridColumn52.Hidden = true;
    ultraGridColumn52.Width = 88;
    ultraGridColumn53.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance68).TextHAlignAsString = "Right";
    ultraGridColumn53.CellAppearance = (AppearanceBase) appearance68;
    ultraGridColumn53.Format = "c";
    ((AppearanceBase) appearance69).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn53.Header).Appearance = (AppearanceBase) appearance69;
    ((HeaderBase) ultraGridColumn53.Header).Caption = "Terr Excess";
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 29;
    ultraGridColumn53.Width = 84;
    ultraGridColumn54.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.Header.VisiblePosition = 30;
    ultraGridBand5.Columns.AddRange(new object[31 /*0x1F*/]
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
      (object) ultraGridColumn54
    });
    ultraGridColumn55.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.Header.VisiblePosition = 0;
    ultraGridColumn55.Width = 68;
    ultraGridColumn56.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn56.Header.VisiblePosition = 1;
    ultraGridColumn56.Width = 50;
    ultraGridColumn57.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn57.Header.VisiblePosition = 2;
    ultraGridColumn57.Width = 41;
    ultraGridColumn58.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn58.Header.VisiblePosition = 3;
    ultraGridColumn58.Width = 49;
    ultraGridColumn59.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn59.Header.VisiblePosition = 4;
    ultraGridColumn59.Width = 88;
    ultraGridColumn60.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn60.Header.VisiblePosition = 5;
    ultraGridColumn60.Width = 69;
    ultraGridColumn61.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn61.Header.VisiblePosition = 6;
    ultraGridColumn61.Width = 71;
    ultraGridBand6.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn55,
      (object) ultraGridColumn56,
      (object) ultraGridColumn57,
      (object) ultraGridColumn58,
      (object) ultraGridColumn59,
      (object) ultraGridColumn60,
      (object) ultraGridColumn61
    });
    ((UltraGridBase) this.ugOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ugOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.ugOptions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance70.BackColor = Color.LightSteelBlue;
    appearance70.FontData.SizeInPoints = 10f;
    appearance70.ForeColor = Color.MidnightBlue;
    ((UltraGridBase) this.ugOptions).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance70;
    appearance71.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance71.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance71.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance71;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance72.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance72;
    appearance73.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance73;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance74.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance74;
    appearance75.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance75;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance76.BackColor = Color.Transparent;
    appearance76.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance76;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugOptions).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((UltraGridBase) this.ugOptions).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugOptions).Location = new Point(0, 0);
    ((Control) this.ugOptions).Name = "ugOptions";
    ((Control) this.ugOptions).Size = new Size(592, 184);
    ((Control) this.ugOptions).TabIndex = 0;
    ((Control) this.ugOptions).Text = "Existing Property Options";
    ((UltraControlBase) this.ugOptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugOptions).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._frmPropertyRater_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Left).Location = new Point(0, 24);
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Left).Name = "_frmPropertyRater_Toolbars_Dock_Area_Left";
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Left).Size = new Size(0, 558);
    this._frmPropertyRater_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._frmPropertyRater_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Right).Location = new Point(592, 24);
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Right).Name = "_frmPropertyRater_Toolbars_Dock_Area_Right";
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Right).Size = new Size(0, 558);
    this._frmPropertyRater_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._frmPropertyRater_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Top).Name = "_frmPropertyRater_Toolbars_Dock_Area_Top";
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Top).Size = new Size(592, 27);
    this._frmPropertyRater_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._frmPropertyRater_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Bottom).Location = new Point(0, 582);
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Bottom).Name = "_frmPropertyRater_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmPropertyRater_Toolbars_Dock_Area_Bottom).Size = new Size(592, 0);
    this._frmPropertyRater_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    this.daOptionSubLimits.DeleteCommand = this.SqlDeleteCommand2;
    this.daOptionSubLimits.InsertCommand = this.SqlInsertCommand2;
    this.daOptionSubLimits.SelectCommand = this.SqlSelectCommand4;
    this.daOptionSubLimits.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteOptionProperty_SubLimits", new DataColumnMapping[6]
      {
        new DataColumnMapping("PropertyOptionID", "PropertyOptionID"),
        new DataColumnMapping("SubLimitID", "SubLimitID"),
        new DataColumnMapping("Limit", "Limit"),
        new DataColumnMapping("Deductible", "Deductible"),
        new DataColumnMapping("DeductiblePercentage", "DeductiblePercentage"),
        new DataColumnMapping("ModificationCode", "ModificationCode")
      })
    });
    this.daOptionSubLimits.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM tblQuoteOptionProperty_SubLimits WHERE (PropertyOptionID = @Original_PropertyOptionID) AND (SubLimitID = @Original_SubLimitID)";
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_PropertyOptionID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PropertyOptionID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SubLimitID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SubLimitID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = componentResourceManager.GetString("SqlInsertCommand2.CommandText");
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@PropertyOptionID", SqlDbType.Int, 4, "PropertyOptionID"),
      new SqlParameter("@SubLimitID", SqlDbType.TinyInt, 1, "SubLimitID"),
      new SqlParameter("@Limit", SqlDbType.Int, 4, "Limit"),
      new SqlParameter("@Deductible", SqlDbType.Int, 4, "Deductible"),
      new SqlParameter("@DeductiblePercentage", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 5, "DeductiblePercentage", DataRowVersion.Current, (object) null),
      new SqlParameter("@ModificationCode", SqlDbType.VarChar, 1, "ModificationCode")
    });
    this.SqlSelectCommand4.CommandText = componentResourceManager.GetString("SqlSelectCommand4.CommandText");
    this.SqlSelectCommand4.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID")
    });
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[8]
    {
      new SqlParameter("@PropertyOptionID", SqlDbType.Int, 4, "PropertyOptionID"),
      new SqlParameter("@SubLimitID", SqlDbType.TinyInt, 1, "SubLimitID"),
      new SqlParameter("@Limit", SqlDbType.Int, 4, "Limit"),
      new SqlParameter("@Deductible", SqlDbType.Int, 4, "Deductible"),
      new SqlParameter("@DeductiblePercentage", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 5, "DeductiblePercentage", DataRowVersion.Current, (object) null),
      new SqlParameter("@ModificationCode", SqlDbType.VarChar, 1, "ModificationCode"),
      new SqlParameter("@Original_PropertyOptionID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PropertyOptionID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SubLimitID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SubLimitID", DataRowVersion.Original, (object) null)
    });
    this.daSubLimits.SelectCommand = this.SqlSelectCommand5;
    this.daSubLimits.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstSubLimits", new DataColumnMapping[2]
      {
        new DataColumnMapping("SubLimitID", "SubLimitID"),
        new DataColumnMapping("SubLimit", "SubLimit")
      })
    });
    this.SqlSelectCommand5.CommandText = "SELECT SubLimitID, SubLimit FROM lstSubLimits ORDER BY SubLimit";
    this.daRates.DeleteCommand = this.SqlCommand4;
    this.daRates.InsertCommand = this.SqlCommand5;
    this.daRates.SelectCommand = this.SqlCommand6;
    this.daRates.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblPropertyExposuresPriorYears", new DataColumnMapping[6]
      {
        new DataColumnMapping("QuoteOptionID", "QuoteOptionID"),
        new DataColumnMapping("Year", "Year"),
        new DataColumnMapping("PriorRate", "PriorRate"),
        new DataColumnMapping("IncurredLosses", "IncurredLosses"),
        new DataColumnMapping("PriorID", "PriorID"),
        new DataColumnMapping("IsPreviouslyApplied", "IsPreviouslyApplied")
      })
    });
    this.daRates.UpdateCommand = this.SqlCommand7;
    this.SqlCommand4.CommandText = componentResourceManager.GetString("SqlCommand4.CommandText");
    this.SqlCommand4.Parameters.AddRange(new SqlParameter[9]
    {
      new SqlParameter("@Original_QuoteOptionID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Year", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Year", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_PriorRate", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PriorRate", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_PriorRate", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 6, (byte) 4, "PriorRate", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_IncurredLosses", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IncurredLosses", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_IncurredLosses", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 16 /*0x10*/, (byte) 2, "IncurredLosses", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_PriorID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PriorID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_IsPreviouslyApplied", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IsPreviouslyApplied", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_IsPreviouslyApplied", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IsPreviouslyApplied", DataRowVersion.Original, (object) null)
    });
    this.SqlCommand5.CommandText = componentResourceManager.GetString("SqlCommand5.CommandText");
    this.SqlCommand5.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@QuoteOptionID", SqlDbType.Int, 0, "QuoteOptionID"),
      new SqlParameter("@Year", SqlDbType.Int, 0, "Year"),
      new SqlParameter("@PriorRate", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 6, (byte) 4, "PriorRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@IncurredLosses", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 16 /*0x10*/, (byte) 2, "IncurredLosses", DataRowVersion.Current, (object) null),
      new SqlParameter("@IsPreviouslyApplied", SqlDbType.Bit, 0, "IsPreviouslyApplied")
    });
    this.SqlCommand6.CommandText = "SELECT     QuoteOptionID, Year, PriorRate, IncurredLosses, PriorID, IsPreviouslyApplied\r\nFROM         dbo.tblPropertyExposuresPriorYears\r\nWHERE     (QuoteOptionID = @QuoteOptionID)";
    this.SqlCommand6.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteOptionID", SqlDbType.Int, 4, "QuoteOptionID")
    });
    this.SqlCommand7.CommandText = componentResourceManager.GetString("SqlCommand7.CommandText");
    this.SqlCommand7.Parameters.AddRange(new SqlParameter[15]
    {
      new SqlParameter("@QuoteOptionID", SqlDbType.Int, 0, "QuoteOptionID"),
      new SqlParameter("@Year", SqlDbType.Int, 0, "Year"),
      new SqlParameter("@PriorRate", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 6, (byte) 4, "PriorRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@IncurredLosses", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 16 /*0x10*/, (byte) 2, "IncurredLosses", DataRowVersion.Current, (object) null),
      new SqlParameter("@IsPreviouslyApplied", SqlDbType.Bit, 0, "IsPreviouslyApplied"),
      new SqlParameter("@Original_QuoteOptionID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Year", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Year", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_PriorRate", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PriorRate", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_PriorRate", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 6, (byte) 4, "PriorRate", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_IncurredLosses", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IncurredLosses", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_IncurredLosses", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 16 /*0x10*/, (byte) 2, "IncurredLosses", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_PriorID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PriorID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_IsPreviouslyApplied", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "IsPreviouslyApplied", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_IsPreviouslyApplied", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "IsPreviouslyApplied", DataRowVersion.Original, (object) null),
      new SqlParameter("@PriorID", SqlDbType.Int, 4, "PriorID")
    });
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(592, 582);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Controls.Add((Control) this.ugOptions);
    this.Controls.Add((Control) this._frmPropertyRater_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmPropertyRater_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmPropertyRater_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._frmPropertyRater_Toolbars_Dock_Area_Bottom);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmPropertyRater);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Property Rater";
    this.Controls.SetChildIndex((Control) this._frmPropertyRater_Toolbars_Dock_Area_Bottom, 0);
    this.Controls.SetChildIndex((Control) this._frmPropertyRater_Toolbars_Dock_Area_Top, 0);
    this.Controls.SetChildIndex((Control) this._frmPropertyRater_Toolbars_Dock_Area_Right, 0);
    this.Controls.SetChildIndex((Control) this._frmPropertyRater_Toolbars_Dock_Area_Left, 0);
    this.Controls.SetChildIndex((Control) this.ugOptions, 0);
    this.Controls.SetChildIndex((Control) this.UltraTabControl1, 0);
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.cboDeductiblePer).EndInit();
    ((ISupportInitialize) this.txtTIV).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.txtAOPDA).EndInit();
    ((ISupportInitialize) this.txtPolicyLimit).EndInit();
    ((ISupportInitialize) this.txtValuation).EndInit();
    ((ISupportInitialize) this.txtCoInsurance).EndInit();
    ((ISupportInitialize) this.txtOtherDeduct).EndInit();
    ((ISupportInitialize) this.txtCoverage).EndInit();
    ((ISupportInitialize) this.cboCauseofLoss).EndInit();
    ((ISupportInitialize) this.cboCoInsurance).EndInit();
    ((ISupportInitialize) this.cboValuations).EndInit();
    ((ISupportInitialize) this.cboLimitDescriptions).EndInit();
    ((ISupportInitialize) this.cboPolicyForms).EndInit();
    ((ISupportInitialize) this.txtSubLimits).EndInit();
    ((ISupportInitialize) this.btnContinue).EndInit();
    ((Control) this.UltraTabPageControl4).ResumeLayout(false);
    ((ISupportInitialize) this.ddLimit).EndInit();
    ((ISupportInitialize) this.ugSubLimits).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.ugPrior).EndInit();
    ((ISupportInitialize) this.txtTerrorismExcess).EndInit();
    ((ISupportInitialize) this.options).EndInit();
    ((ISupportInitialize) this.txtPriorRate).EndInit();
    ((ISupportInitialize) this.txtRate).EndInit();
    ((ISupportInitialize) this.txtTerrorism).EndInit();
    ((ISupportInitialize) this.txtExcess).EndInit();
    ((ISupportInitialize) this.txtPrimary).EndInit();
    ((ISupportInitialize) this.chkTerrorism).EndInit();
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((Control) this.UltraTabPageControl3).PerformLayout();
    ((ISupportInitialize) this.txtAdditionalComments).EndInit();
    ((Control) this.tabUnderlying).ResumeLayout(false);
    ((Control) this.tabUnderlying).PerformLayout();
    ((ISupportInitialize) this.txtUnderlyingDeductible).EndInit();
    ((ISupportInitialize) this.txtUnderlyingLimit).EndInit();
    ((ISupportInitialize) this.txtUnderlyingPolicyNumber).EndInit();
    ((ISupportInitialize) this.txtUnderlyingCarrier).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.ugOptions).EndInit();
    this.ResumeLayout(false);
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

  private PropertyRater PropertyRater => (PropertyRater) this.Rater;

  protected BindingManagerBase bmb
  {
    get
    {
      if (this._bmb == null)
        this._bmb = this.BindingContext[(object) this.ds, this.ds.tblQuoteOptionProperty.TableName];
      return this._bmb;
    }
  }

  public int QuoteOptionID => this.ds.tblQuoteOptionProperty[this.bmb.Position].QuoteOptionID;

  public bool IsIssued => this._isIssued;

  public bool IsQuoteBound => this._isQuoteBound;

  public frmPropertyRater()
  {
    this.Load += new EventHandler(this.frmPropertyRater_Load);
    this._deleteSublimitsLink = new HyperlinkEditor();
    this._renewedQuoteControlNo = int.MinValue;
    this._canImportLocationFromExcelWhenBound = false;
    this.InitializeComponent();
  }

  public frmPropertyRater(RaterWithUIBase rater)
  {
    this.Load += new EventHandler(this.frmPropertyRater_Load);
    this._deleteSublimitsLink = new HyperlinkEditor();
    this._renewedQuoteControlNo = int.MinValue;
    this._canImportLocationFromExcelWhenBound = false;
    this.InitializeComponent();
    this.linkDebugHelper.Visible = false;
    ((ControlBase) this.btnContinue).Appearance.Image = (object) ImageCache.Instance.Forward;
    this._cn = DefaultDatabase.CreateConnection();
    this.InitializeAdapterConnections();
    this.Rater = (RaterBase) rater;
    this._quote = new Quote(this.Rater.QuoteGuid);
    this._isIssued = this._quote.IsIssued;
    this._blockExcessPremium = this._quote.CompanyLine.BlockXSPremium;
    if (SystemSettings.KeyExists("RoundPropertyPremiumToDollar"))
      this._roundToDollar = SystemSettings.GetBoolSetting("RoundPropertyPremiumToDollar");
    this.FillOptions();
  }

  private void InitializeAdapterConnections()
  {
    this.daLookups.SelectCommand.Connection = this._cn;
    SqlDataAdapter daOptionsProperty = this.daOptionsProperty;
    daOptionsProperty.SelectCommand.Connection = this._cn;
    daOptionsProperty.InsertCommand.Connection = this._cn;
    daOptionsProperty.DeleteCommand.Connection = this._cn;
    daOptionsProperty.UpdateCommand.Connection = this._cn;
    SqlDataAdapter daOptions = this.daOptions;
    daOptions.SelectCommand.Connection = this._cn;
    daOptions.InsertCommand.Connection = this._cn;
    daOptions.DeleteCommand.Connection = this._cn;
    daOptions.UpdateCommand.Connection = this._cn;
    SqlDataAdapter daOptionSubLimits = this.daOptionSubLimits;
    daOptionSubLimits.SelectCommand.Connection = this._cn;
    daOptionSubLimits.InsertCommand.Connection = this._cn;
    daOptionSubLimits.DeleteCommand.Connection = this._cn;
    daOptionSubLimits.UpdateCommand.Connection = this._cn;
    this.daSubLimits.SelectCommand.Connection = this._cn;
    SqlDataAdapter daRates = this.daRates;
    daRates.SelectCommand.Connection = this._cn;
    daRates.InsertCommand.Connection = this._cn;
    daRates.DeleteCommand.Connection = this._cn;
    daRates.UpdateCommand.Connection = this._cn;
  }

  public bool OptionAreProperlyLoaded
  {
    get => this.ds.tblQuoteOptions.Rows.Count == this.ds.tblQuoteOptionProperty.Count;
  }

  private void frmPropertyRater_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.FillDataThread));
    ((UltraGridBase) this.ugSubLimits).DisplayLayout.Bands[0].Columns["DeleteLink"].Editor = (EmbeddableEditorBase) this._deleteSublimitsLink;
    ((Control) this.btnContinue).Enabled = this.ds.tblQuoteOptionProperty.Count > 0;
    this._isQuoteBound = this._quote.IsBound;
    if (SystemSettings.KeyExists("CanImportLocationFromExcelWhenBound") && SystemSettings.GetBoolSetting("CanImportLocationFromExcelWhenBound"))
      this._canImportLocationFromExcelWhenBound = true;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.UIState = this.ds.tblQuoteOptionProperty.Count <= 0 ? UIState.NoRecordsNotEditing : UIState.HasRecordsNotEditing;
    this.SetTabsEnabledDisabled();
    if (SystemSettings.GetBoolSetting("IssuePolicies"))
      this.dbSave.Enabled = !this._isIssued;
    else
      this.dbSave.Enabled = !this._quote.IsBound;
    if (((UltraGridBase) this.ugOptions).Rows.Count > 0 && this._quote.IsEndorsement)
    {
      this.lnkCalculateRate.Visible = false;
      ((EditorButtonControlBase) this.txtRate).ReadOnly = true;
      ((EditorButtonControlBase) this.txtPriorRate).ReadOnly = true;
    }
    if (this._quote.IsRenewal)
      ((EditorButtonControlBase) this.txtPriorRate).ReadOnly = true;
    if (((UltraGridBase) this.ugOptions).Rows.Count > 0)
    {
      ((UltraGridBase) this.ugOptions).Rows[0].Activate();
      ((UltraGridBase) this.ugOptions).Rows[0].Selected = true;
    }
    this._isImsRenewal = this._quote.IsImsRenewal;
    if (this._isImsRenewal)
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT RenewalOfQuoteGuid, RenewalOfControlNum FROM tblQuotes WITH (NOLOCK) WHERE QuoteGuid = @QG", new object[2]
      {
        (object) "@QG",
        (object) this._quote.QuoteGuid
      });
      if (dataRow[0] != DBNull.Value)
      {
        this._renewedQuote = new Quote((Guid) dataRow[0]);
        this._renewedQuoteControlNo = this._renewedQuote.ControlNo;
      }
      else
      {
        this._renewedQuote = Quote.FromControlNo((int) dataRow[1]);
        this._renewedQuoteControlNo = this._renewedQuote.ControlNo;
      }
    }
    if (this.ds.tblQuoteOptions.Count > 0 && this.bmb.Position != -1)
      this.SetClientData(this.ds.tblQuoteOptions[this.bmb.Position].QuoteOptionGUID);
    this._deleteSublimitsLink.HyperLinkOpening += new CancelEventHandler(this.DeleteSublimit);
    this.OnFormLoad();
  }

  private void FillDataThread(object state)
  {
    DataTableMappingCollection tableMappings = this.daLookups.TableMappings;
    tableMappings.Clear();
    tableMappings.Add("Table", this.ds.lstPropRater_CauseOfLoss.TableName);
    tableMappings.Add("Table1", this.ds.lstPropRater_LimitDescription.TableName);
    tableMappings.Add("Table2", this.ds.lstPolicyForm.TableName);
    tableMappings.Add("Table3", this.ds.lstPropRater_Valuation.TableName);
    tableMappings.Add("Table4", this.ds.lstPropRater_Coinsurance.TableName);
    tableMappings.Add("Table5", this.ds.lstDeductiblePer.TableName);
    this.daLookups.SelectCommand.Connection = DefaultDatabase.CreateConnection();
    try
    {
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLookups, (DataSet) this.ds);
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblPropertyExposuresPriorYears"
      }, "dbo.GetPriorExposureRates", new object[2]
      {
        (object) "@QuoteGUID",
        (object) this.Rater.QuoteGuid
      });
      if (this.IsDisposed && !this.Disposing)
        return;
      this.Invoke((Delegate) new frmPropertyRater.ThreadCompleteDelegate(this.ThreadComplete));
    }
    finally
    {
      if (this.daLookups.SelectCommand.Connection != null)
        this.daLookups.SelectCommand.Connection.Dispose();
      this.daLookups.Dispose();
    }
  }

  private void ThreadComplete()
  {
    MGASimpleComboBox cboCauseofLoss = this.cboCauseofLoss;
    ((UltraGridBase) cboCauseofLoss).DataSource = (object) this.ds.lstPropRater_CauseOfLoss;
    ((UltraDropDownBase) cboCauseofLoss).DisplayMember = "Peril";
    ((UltraDropDownBase) cboCauseofLoss).ValueMember = "ID";
    ((Control) cboCauseofLoss).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.CauseofLossID"));
    MGASimpleComboBox cboCoInsurance = this.cboCoInsurance;
    ((UltraGridBase) cboCoInsurance).DataSource = (object) this.ds.lstPropRater_Coinsurance;
    ((UltraDropDownBase) cboCoInsurance).DisplayMember = "CoIns";
    ((UltraDropDownBase) cboCoInsurance).ValueMember = "ID";
    ((Control) cboCoInsurance).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.CoInsuranceID"));
    MGASimpleComboBox limitDescriptions = this.cboLimitDescriptions;
    ((UltraGridBase) limitDescriptions).DataSource = (object) this.ds.lstPropRater_LimitDescription;
    ((UltraDropDownBase) limitDescriptions).DisplayMember = "LimitDescrip";
    ((UltraDropDownBase) limitDescriptions).ValueMember = "ID";
    ((Control) limitDescriptions).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.PolicyLimitDescriptionID"));
    MGASimpleComboBox cboPolicyForms = this.cboPolicyForms;
    ((UltraGridBase) cboPolicyForms).DataSource = (object) this.ds.lstPolicyForm;
    ((UltraDropDownBase) cboPolicyForms).DisplayMember = "PolicyForm";
    ((UltraDropDownBase) cboPolicyForms).ValueMember = "ID";
    ((Control) cboPolicyForms).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.PolicyFormID"));
    MGASimpleComboBox cboValuations = this.cboValuations;
    ((UltraGridBase) cboValuations).DataSource = (object) this.ds.lstPropRater_Valuation;
    ((UltraDropDownBase) cboValuations).DisplayMember = "Valuation";
    ((UltraDropDownBase) cboValuations).ValueMember = "ID";
    ((Control) cboValuations).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.ValuationID"));
    MGASimpleComboBox cboDeductiblePer = this.cboDeductiblePer;
    ((UltraGridBase) cboDeductiblePer).DataSource = (object) this.ds.lstDeductiblePer;
    ((UltraDropDownBase) cboDeductiblePer).ValueMember = "PerID";
    ((UltraDropDownBase) cboDeductiblePer).DisplayMember = "DeductiblePer";
    ((Control) cboDeductiblePer).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionProperty.DeductiblePerID"));
  }

  private void BlockXSPremium()
  {
    ((Control) this.txtExcess).Enabled = !this._blockExcessPremium;
    ((Control) this.txtTerrorismExcess).Enabled = !this._blockExcessPremium;
  }

  private void lnkCalculatePremium_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.txtRate.Value != DBNull.Value && this.txtTIV.Value != DBNull.Value && Decimal.Compare(Conversions.ToDecimal(((UltraWinEditorMaskedControlBase) this.txtTIV).Text), 0M) > 0 && Decimal.Compare(Conversions.ToDecimal(this.txtTIV.Value), 0M) > 0)
    {
      Decimal num = Decimal.Divide(Decimal.Multiply(Conversions.ToDecimal(this.txtRate.Value), Conversions.ToDecimal(this.txtTIV.Value)), 100M);
      if (this._roundToDollar)
        num = new Decimal(Convert.ToInt32(num));
      this.txtPrimary.Value = (object) num;
    }
    else if (this.txtRate.Value == DBNull.Value)
    {
      int num1 = (int) MessageBox.Show("Unable to calculate premium rate - no rate has been entered.", "Unable to Calculate Premium Rate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      int num2 = (int) MessageBox.Show("Unable to calculate premium rate - no TIV has been entered.", "Unable to Calculate Premium Rate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void ugSubLimits_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.Cell.OriginalValue)) || !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.Cell.Value)) || Decimal.Compare(Conversions.ToDecimal(e.Cell.OriginalValue), Conversions.ToDecimal(e.Cell.Value)) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Row.Cells["ModificationCode"].Value.ToString(), "U", false) != 0)
      return;
    e.Cell.Row.Cells["ModificationCode"].Value = (object) "M";
  }

  private void ugSubLimits_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    string Left = e.Row.Cells["ModificationCode"].Value.ToString();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "M", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "N", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "D", false) != 0)
          return;
        e.Row.Appearance.ForeColor = Color.Red;
        e.Row.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
      }
      else
        e.Row.Appearance.ForeColor = Color.Green;
    }
    else
      e.Row.Appearance.ForeColor = Color.Blue;
  }

  private void lnkMiscPremiums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowFormDialog(typeof (frmMiscPremiums), (object) this.QuoteOptionID);
  }

  private void DeleteSublimit(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    if (MessageBox.Show("Are you sure you want to delete this sub-limit?", "Delete Sub-Limit?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow optionIdSubLimitId = this.ds.tblQuoteOptionProperty_SubLimits.FindByPropertyOptionIDSubLimitID((int) ((UltraGridBase) this.ugSubLimits).ActiveRow.Cells["PropertyOptionID"].Value, (int) ((UltraGridBase) this.ugSubLimits).ActiveRow.Cells["subLimitID"].Value);
    if (optionIdSubLimitId.RowState == DataRowState.Added)
    {
      this.ds.tblQuoteOptionProperty_SubLimits.RemovetblQuoteOptionProperty_SubLimitsRow(optionIdSubLimitId);
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(optionIdSubLimitId.ModificationCode, "N", false) == 0)
      {
        optionIdSubLimitId.Delete();
      }
      else
      {
        optionIdSubLimitId.ModificationCode = "D";
        UltraGridRow activeRow = ((UltraGridBase) this.ugSubLimits).ActiveRow;
        activeRow.Appearance.ForeColor = Color.Red;
        activeRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
      }
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSubLimits, (DataTable) this.ds.tblQuoteOptionProperty_SubLimits);
    }
  }

  private void Premiums_ValueChanged(object sender, EventArgs e)
  {
    if (this.bmb.Position == -1 || this.ds.tblQuoteOptionProperty.Count == 0)
      return;
    Decimal terrorismPremium = 0M;
    if (!this.ds.tblQuoteOptionProperty[this.bmb.Position].TerrorismDeclined && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.txtTerrorism.Value)))
      terrorismPremium = Conversions.ToDecimal(this.txtTerrorism.Value);
    this.CalculateTotalPremium(terrorismPremium);
    MGANumericEditor mgaNumericEditor = (MGANumericEditor) sender;
    if (mgaNumericEditor.Value != DBNull.Value && Decimal.Compare(Conversions.ToDecimal(mgaNumericEditor.Value), 0M) < 0)
      ((UltraNumericEditorBase) mgaNumericEditor).Appearance.ForeColor = Color.Red;
    else
      ((UltraNumericEditorBase) mgaNumericEditor).Appearance.ForeColor = Color.Black;
  }

  protected virtual void CalculateTotalPremium(Decimal terrorismPremium)
  {
    Decimal d1 = 0M;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.txtPrimary.Value)))
      d1 = Conversions.ToDecimal(this.txtPrimary.Value);
    ((ControlBase) this.lblTotalPremium).Text = Strings.FormatCurrency((object) Decimal.Add(d1, terrorismPremium));
  }

  protected virtual Decimal GetPremium() => Conversions.ToDecimal(this.txtPrimary.Value);

  private void lnkCalculateRate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.bmb.Position == -1)
      return;
    if ((bool) this.options.Value)
    {
      if (Conversions.ToInteger(this.txtPrimary.Value) != 0 && this.txtTIV.Value != DBNull.Value && Decimal.Compare(Conversions.ToDecimal(((UltraWinEditorMaskedControlBase) this.txtTIV).Text), 0M) > 0 && Decimal.Compare(Conversions.ToDecimal(this.txtTIV.Value), 0M) > 0)
      {
        Decimal Expression = Decimal.Multiply(Decimal.Divide(this.GetPremium(), Conversions.ToDecimal(this.txtTIV.Value)), 100M);
        if (Convert.ToDouble(Expression) <= 99.9999 && Convert.ToDouble(Expression) >= 0.0001)
        {
          this.ds.tblQuoteOptionProperty[this.bmb.Position].Rate = Expression;
          this.txtRate.Value = (object) Expression;
        }
        else
        {
          int num = (int) MessageBox.Show($"This premium / TIV combination results in an invalid rate of {Strings.FormatNumber((object) Expression, 3)}.\n\nThe primary premium and TIV are being reset to $0.", "Invalid Rate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          dsPropertyRater.tblQuoteOptionPropertyRow optionPropertyRow = this.ds.tblQuoteOptionProperty[this.bmb.Position];
          optionPropertyRow.PrimaryPremium = 0M;
          optionPropertyRow.TIV = 0M;
        }
      }
      else if (Convert.ToInt32(this.GetPremium()) == 0)
      {
        int num1 = (int) MessageBox.Show("Unable to calculate rate - no premium has been entered.", "Unable to Calculate Rate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        int num2 = (int) MessageBox.Show("Unable to calculate rate - no TIV has been entered.", "Unable to Calculate Rate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }
    else if (Conversions.ToInteger(this.txtPrimary.Value) != 0 && this.txtPolicyLimit.Value != DBNull.Value && Decimal.Compare(Conversions.ToDecimal(((UltraWinEditorMaskedControlBase) this.txtPolicyLimit).Text), 0M) > 0 && Decimal.Compare(Conversions.ToDecimal(this.txtPolicyLimit.Value), 0M) > 0)
    {
      Decimal Expression = Decimal.Multiply(Decimal.Divide(this.GetPremium(), Conversions.ToDecimal(this.txtPolicyLimit.Value)), 100M);
      if (Convert.ToDouble(Expression) <= 99.9999 && Convert.ToDouble(Expression) >= 0.0001)
      {
        this.ds.tblQuoteOptionProperty[this.bmb.Position].Rate = Expression;
        this.txtRate.Value = (object) Expression;
      }
      else
      {
        int num3 = (int) MessageBox.Show($"This premium / Limit combination results in an invalid rate of {Strings.FormatNumber((object) Expression, 3)}.\n\nThe primary premium and Limit are being reset to $0.", "Invalid Rate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        dsPropertyRater.tblQuoteOptionPropertyRow optionPropertyRow = this.ds.tblQuoteOptionProperty[this.bmb.Position];
        optionPropertyRow.PrimaryPremium = 0M;
        optionPropertyRow.PolicyLimit = 0M;
      }
    }
    else if (Convert.ToInt32(this.GetPremium()) == 0)
    {
      int num4 = (int) MessageBox.Show("Unable to calculate rate - no premium has been entered.", "Unable to Calculate Rate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      int num5 = (int) MessageBox.Show("Unable to calculate rate - no limit has been entered.", "Unable to Calculate Rate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void txtPrimary_Enter(object sender, EventArgs e)
  {
    MGANumericEditor mgaNumericEditor = (MGANumericEditor) sender;
    if (mgaNumericEditor.Value == DBNull.Value || Conversions.ToInteger(mgaNumericEditor.Value) != 0)
      return;
    mgaNumericEditor.Value = (object) DBNull.Value;
  }

  private void txtPrimary_Leave(object sender, EventArgs e)
  {
    MGANumericEditor mgaNumericEditor = (MGANumericEditor) sender;
    if (mgaNumericEditor.Value != DBNull.Value)
      return;
    mgaNumericEditor.Value = (object) 0;
  }

  private void UltraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Copy Option"].SharedProps.Enabled = ((UltraGridBase) this.ugOptions).ActiveRow != null;
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((ToolEventArgs) e).Tool.Key, "Copy Option", false) != 0)
      return;
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
      {
        this.CopyOptionTransaction(RuntimeHelpers.GetObjectValue(obj), args);
        args.Transaction.Commit();
      }));
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      ProjectData.ClearProjectError();
      return;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    this.FillOptions();
  }

  private object CopyOptionTransaction(object sender, ExecuteTransactionEventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spCopyPropertyOption", new object[2]
    {
      (object) "@quoteOptionID",
      (object) this.QuoteOptionID
    });
    return (object) null;
  }

  private void FillOptions()
  {
    this.ds.tblQuoteOptionProperty_SubLimits.Clear();
    this.ds.tblQuoteOptionProperty.Clear();
    this.ds.tblQuoteOptions.Clear();
    Guid quoteGuid = this.Rater.QuoteGuid;
    this.daOptions.SelectCommand.Parameters["@QuoteGuid"].Value = (object) quoteGuid;
    this.daOptions.SelectCommand.Parameters["@LineGuid"].Value = (object) this.Rater.LineGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daOptions, (DataTable) this.ds.tblQuoteOptions);
    this.daOptionsProperty.SelectCommand.Parameters["@QuoteGuid"].Value = (object) quoteGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daOptionsProperty, (DataTable) this.ds.tblQuoteOptionProperty);
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSubLimits, (DataTable) this.ds.lstSubLimits);
    this.daOptionSubLimits.SelectCommand.Parameters["@QuoteGuid"].Value = (object) quoteGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daOptionSubLimits, (DataTable) this.ds.tblQuoteOptionProperty_SubLimits);
  }

  private void chkTerrorism_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.chkTerrorism).Checked)
    {
      if (this._strikeoutFont == null)
      {
        this._originalFont = ((Control) this.txtTerrorism).Font;
        this._strikeoutFont = new Font(((Control) this.txtTerrorism).Font, FontStyle.Strikeout);
      }
      MGANumericEditor txtTerrorism = this.txtTerrorism;
      ((Control) txtTerrorism).Font = this._strikeoutFont;
      ((UltraNumericEditorBase) txtTerrorism).ForeColor = Color.Red;
      MGANumericEditor txtTerrorismExcess = this.txtTerrorismExcess;
      ((Control) txtTerrorismExcess).Font = this._strikeoutFont;
      ((UltraNumericEditorBase) txtTerrorismExcess).Appearance.ForeColor = Color.Red;
      AppearanceBase cellAppearance = ((UltraGridBase) this.ugOptions).DisplayLayout.Bands[0].Columns["TerrPremium"].CellAppearance;
      cellAppearance.ForeColor = Color.Red;
      cellAppearance.FontData.Strikeout = (DefaultableBoolean) 1;
    }
    else
    {
      MGANumericEditor txtTerrorism = this.txtTerrorism;
      ((Control) txtTerrorism).Font = this._originalFont;
      ((UltraNumericEditorBase) txtTerrorism).ForeColor = Color.Black;
      MGANumericEditor txtTerrorismExcess = this.txtTerrorismExcess;
      ((Control) txtTerrorismExcess).Font = this._originalFont;
      ((UltraNumericEditorBase) txtTerrorismExcess).Appearance.ForeColor = Color.Red;
      AppearanceBase cellAppearance = ((UltraGridBase) this.ugOptions).DisplayLayout.Bands[0].Columns["TerrPremium"].CellAppearance;
      cellAppearance.ForeColor = Color.Black;
      cellAppearance.FontData.Strikeout = (DefaultableBoolean) 2;
    }
  }

  private static Decimal IsNull(string str)
  {
    return Versioned.IsNumeric((object) str) ? Conversions.ToDecimal(str) : 0M;
  }

  private static Decimal DecimalObject(object obj)
  {
    return obj == null || obj == DBNull.Value ? Convert.ToDecimal(0) : Convert.ToDecimal(RuntimeHelpers.GetObjectValue(obj));
  }

  private void lnkFCW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowFormDialog(typeof (frmPolicyFCW), (object) this.Rater.Quote.QuoteID).Dispose();
  }

  private void btnContinue_Click(object sender, EventArgs e)
  {
    if (this.ds.tblQuoteOptions.Count > 1 && ((UltraGridBase) this.ugOptions).ActiveRow == null)
    {
      int num1 = (int) MessageBox.Show("Please select an option in the grid to continue.\n\nThis will be used to determine the class codes on the new option.", "Option Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (((UltraGridBase) this.ugOptions).ActiveRow == null)
        return;
      int num2 = (int) ((UltraGridBase) this.ugOptions).ActiveRow.Cells["QuoteOptionID"].Value;
      Type formType = typeof (frmPropertyRater_Exposure);
      object[] objArray = new object[2]
      {
        (object) num2,
        (object) (PropertyRater) this.Rater
      };
      Form form;
      Decimal tiv = ((frmPropertyRater_Exposure) (form = FormSettings.ShowFormDialog(formType, objArray))).TIV;
      form.Dispose();
      if (Decimal.Compare(tiv, Decimal.MinValue) == 0 || this._quote.IsBound)
        return;
      ((dsPropertyRater.tblQuoteOptionPropertyRow) this.ds.tblQuoteOptionProperty.Select("QuoteOptionID = " + Conversions.ToString(num2))[0]).TIV = tiv;
    }
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e) => this.BlockXSPremium();

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (this._quote.IsEndorsement && this.ds.tblQuoteOptions.Count > 0)
    {
      int num = (int) MessageBox.Show("New options can not be created on endorsements.", "Unable To Create Option", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      dsPropertyRater.tblQuoteOptionsRow row = this.ds.tblQuoteOptions.NewtblQuoteOptionsRow();
      dsPropertyRater.tblQuoteOptionsRow tblQuoteOptionsRow = row;
      tblQuoteOptionsRow.QuoteGUID = this.Rater.QuoteGuid;
      tblQuoteOptionsRow.QuoteOptionGUID = Guid.NewGuid();
      tblQuoteOptionsRow.LineGUID = this.Rater.LineGuid;
      this.ds.tblQuoteOptions.AddtblQuoteOptionsRow(row);
      dsPropertyRater.tblQuoteOptionPropertyRow optionPropertyRow = this.ds.tblQuoteOptionProperty.NewtblQuoteOptionPropertyRow();
      optionPropertyRow.QuoteOptionID = row.QuoteOptionID;
      optionPropertyRow.DeductiblePerID = "O";
      object objectValue = RuntimeHelpers.GetObjectValue(frmPropertyRater.GetCompanyLineAdditionalComments(this.Rater.QuoteGuid));
      if (objectValue == DBNull.Value)
        optionPropertyRow.SetAdditionalCommentsNull();
      else
        optionPropertyRow.AdditionalComments = objectValue.ToString();
      this.OnClickingNew(optionPropertyRow);
      this.ds.tblQuoteOptionProperty.AddtblQuoteOptionPropertyRow(optionPropertyRow);
      this.bmb.Position = checked (this.ds.tblQuoteOptionProperty.Rows.Count - 1);
      this.ds.tblQuoteOptionProperty_SubLimits.DefaultView.RowFilter = "PropertyOptionID=" + this.ds.tblQuoteOptionProperty[this.bmb.Position].ID.ToString();
      try
      {
        foreach (Control control in ((Control) ((UltraTabControlBase) this.UltraTabControl1).Tabs[0].TabPage).Controls)
        {
          if (control is MGASimpleComboBox && control != this.cboDeductiblePer)
            ((UltraCombo) control).Value = (object) null;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.BlockXSPremium();
    }
  }

  private static object GetCompanyLineAdditionalComments(Guid quoteGuid)
  {
    return DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT QuoteAdditionalComments FROM tblCompanyLines WITH(NOLOCK) WHERE CompanyLineGUID = dbo.GetQuoteCompanyLineGuid(@QG)", new object[2]
    {
      (object) "@QG",
      (object) quoteGuid
    });
  }

  private bool ValidateErrorProviders()
  {
    bool flag1 = true;
    if (this.cboCauseofLoss.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboCauseofLoss, "Please enter a valid cause of loss.");
      flag1 = false;
    }
    else if (Conversions.ToBoolean(((UltraDropDownBase) this.cboCauseofLoss).SelectedRow.Cells["Hidden"].Value))
    {
      this.err.SetError((Control) this.cboCauseofLoss, "Please select valid cause of loss.");
      flag1 = false;
    }
    else
      this.err.SetError((Control) this.cboCauseofLoss, string.Empty);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtCoverage).Text, string.Empty, false) == 0)
    {
      this.err.SetError((Control) this.txtCoverage, "Please enter a valid coverage.");
      flag1 = false;
    }
    else
      this.err.SetError((Control) this.txtCoverage, string.Empty);
    if (!Versioned.IsNumeric((object) ((UltraWinEditorMaskedControlBase) this.txtTIV).Text) || Decimal.Compare(Conversions.ToDecimal(((UltraWinEditorMaskedControlBase) this.txtTIV).Text), 0M) < 0)
    {
      this.err.SetError((Control) this.txtTIV, "Please enter a valid TIV value.");
      flag1 = false;
    }
    else
      this.err.SetError((Control) this.txtTIV, string.Empty);
    if (!Versioned.IsNumeric((object) ((UltraWinEditorMaskedControlBase) this.txtPolicyLimit).Text) || Decimal.Compare(Conversions.ToDecimal(((UltraWinEditorMaskedControlBase) this.txtPolicyLimit).Text), 0M) < 0)
    {
      this.err.SetError((Control) this.txtPolicyLimit, "Please enter a valid policy limit.");
      flag1 = false;
    }
    else
      this.err.SetError((Control) this.txtPolicyLimit, string.Empty);
    if (this.cboLimitDescriptions.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboLimitDescriptions, "Please select a limit description.");
      flag1 = false;
    }
    else if (Conversions.ToBoolean(((UltraDropDownBase) this.cboLimitDescriptions).SelectedRow.Cells["Hidden"].Value))
    {
      this.err.SetError((Control) this.cboLimitDescriptions, "Please select valid limit description.");
      flag1 = false;
    }
    else
      this.err.SetError((Control) this.cboLimitDescriptions, string.Empty);
    if (this.cboPolicyForms.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboPolicyForms, "Please select a policy form.");
      flag1 = false;
    }
    else
      this.err.SetError((Control) this.cboPolicyForms, string.Empty);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.txtAOPDA).Text, string.Empty, false) == 0)
    {
      this.err.SetError((Control) this.txtAOPDA, "Please enter a value for AOPDA.");
      flag1 = false;
    }
    else
      this.err.SetError((Control) this.txtAOPDA, string.Empty);
    if (this.cboValuations.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboValuations, "Please select a valuation.");
      flag1 = false;
    }
    else
      this.err.SetError((Control) this.cboValuations, string.Empty);
    if (this.cboCoInsurance.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboCoInsurance, "Please select a value for coinsurance.");
      flag1 = false;
    }
    else
      this.err.SetError((Control) this.cboCoInsurance, string.Empty);
    if (this.cboDeductiblePer.Value == null)
    {
      this.err.SetError((Control) this.cboDeductiblePer, "Please choose a Deductible Per Value.");
      flag1 = false;
    }
    else
      this.err.SetError((Control) this.cboDeductiblePer, string.Empty);
    bool flag2;
    if (!flag1)
    {
      ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[0];
      flag2 = false;
    }
    else
    {
      if (this.txtPrimary.Value == DBNull.Value)
      {
        this.err.SetError((Control) this.txtPrimary, "Please enter a valid premium amount.");
        flag1 = false;
      }
      else
        this.err.SetError((Control) this.txtPrimary, string.Empty);
      if (this.txtTerrorism.Value == DBNull.Value)
      {
        this.err.SetError((Control) this.txtTerrorism, "Please enter a valid premium amount.");
        flag1 = false;
      }
      else
        this.err.SetError((Control) this.txtTerrorism, string.Empty);
      if (this.txtExcess.Value == DBNull.Value)
      {
        this.err.SetError((Control) this.txtExcess, "Please enter a valid premium amount.");
        flag1 = false;
      }
      else
        this.err.SetError((Control) this.txtExcess, string.Empty);
      if (this.txtRate.Value == DBNull.Value)
      {
        this.err.SetError((Control) this.txtRate, "Please enter a valid rate.");
        flag1 = false;
      }
      else
        this.err.SetError((Control) this.txtRate, string.Empty);
      if (!flag1)
      {
        ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[2];
        flag2 = false;
      }
      else
        flag2 = flag1;
    }
    return flag2;
  }

  private bool IsValidPriorRate()
  {
    bool flag = true;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugPrior).Rows)
    {
      if (row.Cells["Year"].Value == DBNull.Value || row.Cells["Year"].Value == null)
      {
        int num = (int) MessageBox.Show("Please fill in the year on the prior rates.", "Year Empty", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
        break;
      }
    }
    return flag;
  }

  protected virtual bool ValidForm()
  {
    bool flag1;
    if (this.ValidateErrorProviders())
    {
      if (!this.IsValidPriorRate())
      {
        flag1 = false;
      }
      else
      {
        if (((Control) this.txtRate).Enabled && this.Rater.Quote.IsOriginalQuoteRecord)
        {
          bool flag2 = false;
          int num = (bool) this.options.Value ? 1 : 0;
          Decimal d;
          if (num != 0 && Decimal.Compare(Conversions.ToDecimal(this.txtTIV.Value), 0M) != 0)
          {
            d = Decimal.Multiply(Decimal.Divide(this.GetPremium(), Conversions.ToDecimal(this.txtTIV.Value)), 100M);
            flag2 = true;
          }
          if (num == 0 && Decimal.Compare(Conversions.ToDecimal(this.txtPolicyLimit.Value), 0M) != 0)
          {
            d = Decimal.Multiply(Decimal.Divide(this.GetPremium(), Conversions.ToDecimal(this.txtPolicyLimit.Value)), 100M);
            flag2 = true;
          }
          if (flag2 && Decimal.Compare(Decimal.Round(d, 4), Decimal.Round(Conversions.ToDecimal(this.txtRate.Value), 4)) != 0)
          {
            ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[2];
            this.err.SetError((Control) this.txtRate, "This rate is not valid for this premium and TIV");
            flag1 = false;
            goto label_12;
          }
        }
        flag1 = true;
      }
    }
    else
      flag1 = false;
label_12:
    return flag1;
  }

  private void SetTabsEnabledDisabled()
  {
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
    {
      if (tab.TabPage != this.tabUnderlying)
      {
        try
        {
          foreach (Control control in ((Control) tab.TabPage).Controls)
          {
            if (control != this.btnContinue && (control.Tag == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Tag.ToString(), "KeepActive", false) != 0))
              control.Enabled = this.dbSave.UIState == UIState.Editing && !this.IsQuoteBound;
            else if (control != this.btnContinue)
              control.Enabled = true;
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
        try
        {
          foreach (Control control in ((Control) tab.TabPage).Controls)
            control.Enabled = !this._isIssued && this.dbSave.UIState == UIState.Editing;
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    this.BlockXSPremium();
    this.lnkCopyOptions.Enabled = !this.IsQuoteBound && this._quote.IsImsRenewal && this._quote.IsOriginalQuoteRecord;
    if (this.IsQuoteBound && this._canImportLocationFromExcelWhenBound)
      this.lnkLocationExcelImport.Enabled = true;
    this.EnableDisableClientControls();
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.ugOptions).Enabled = this.dbSave.UIState != UIState.Editing;
    this.SetTabsEnabledDisabled();
  }

  private void ugOptions_AfterRowActivate(object sender, EventArgs e)
  {
    if (this.bmb.Position == -1)
      return;
    Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugOptions).ActiveRow.Cells["ID"].Value), "ID", (DataTable) this.ds.tblQuoteOptionProperty, this.bmb);
    this.ds.tblQuoteOptionProperty_SubLimits.DefaultView.RowFilter = "PropertyOptionID=" + this.ds.tblQuoteOptionProperty[this.bmb.Position].ID.ToString();
    if (this.dbSave.UIState == UIState.NoRecordsNotEditing)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    ((Control) this.btnContinue).Enabled = this.ds.tblQuoteOptionProperty[this.bmb.Position].RowState != DataRowState.Added;
  }

  private bool ConditionalValidation()
  {
    bool flag = true;
    dsPropertyRaterConditionals raterConditionals = new dsPropertyRaterConditionals();
    DefaultDatabase.LoadDataSet((DataSet) raterConditionals, new string[1]
    {
      "RaterConditionals"
    }, "dbo.GetRaterConditionals", new object[8]
    {
      (object) "@CLG",
      (object) this._quote.CompanyLocationGuid,
      (object) "@LG",
      (object) this._quote.LineGuid,
      (object) "@StateID",
      (object) this._quote.StateID,
      (object) "@raterID",
      (object) 98
    });
    try
    {
      foreach (dsPropertyRaterConditionals.RaterConditionalsRow row in raterConditionals.RaterConditionals.Rows)
      {
        object obj = !row.IsNumericValue ? (object) row.ValueString : (object) row.ValueNumeric;
        if (row.ElementID == (short) 1)
        {
          Decimal d1 = Decimal.MinValue;
          if (!this.ds.tblQuoteOptionProperty[this.bmb.Position].IsPolicyLimitNull())
            d1 = this.ds.tblQuoteOptionProperty[this.bmb.Position].PolicyLimit;
          if (row.RaterConditionalID.Equals("EQ"))
          {
            if (Decimal.Compare(d1, Conversions.ToDecimal(obj)) != 0)
            {
              int num = (int) MessageBox.Show("The current policy limit and the one on the rater conditional setup are not equal.", "Policy Limit Not Equal To " + Conversions.ToDecimal(obj).ToString("c"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              flag = false;
              break;
            }
          }
          else if (row.RaterConditionalID.Equals("GT"))
          {
            if (Decimal.Compare(d1, Conversions.ToDecimal(obj)) < 0)
            {
              Decimal num1 = Conversions.ToDecimal(obj);
              string text = $"The current policy limit should be greater than the limit of {num1.ToString("c")} as specified on the rater conditional setup.";
              num1 = Conversions.ToDecimal(obj);
              string caption = "Policy Limit Not Greater Than " + num1.ToString("c");
              int num2 = (int) MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              flag = false;
              break;
            }
          }
          else if (row.RaterConditionalID.Equals("LT") && Decimal.Compare(d1, Conversions.ToDecimal(obj)) > 0)
          {
            Decimal num3 = Conversions.ToDecimal(obj);
            string text = $"The current policy limit should be less than the limit of {num3.ToString("c")} as specified on the rater conditional setup.";
            num3 = Conversions.ToDecimal(obj);
            string caption = "Policy Limit Not Less Than " + num3.ToString("c");
            int num4 = (int) MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            flag = false;
            break;
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
    return flag;
  }

  private List<string> LoggingInfo(bool isNewRow, bool isDeleted)
  {
    List<string> stringList = new List<string>();
    if (!isNewRow && !isDeleted)
    {
      string str1 = "<NULL>";
      string str2 = "<NULL>";
      if (this.ds.tblQuoteOptionProperty[this.bmb.Position]["TIV", DataRowVersion.Original] != DBNull.Value)
        str1 = this.ds.tblQuoteOptionProperty[this.bmb.Position]["TIV", DataRowVersion.Original].ToString();
      if (this.ds.tblQuoteOptionProperty[this.bmb.Position]["TIV", DataRowVersion.Current] != DBNull.Value)
        str2 = this.ds.tblQuoteOptionProperty[this.bmb.Position]["TIV", DataRowVersion.Current].ToString();
      if (!str1.Equals(str2))
        stringList.Add($"Change TIV from {str1} to {str2}");
      string str3 = "<NULL>";
      string str4 = "<NULL>";
      if (this.ds.tblQuoteOptionProperty[this.bmb.Position]["PolicyLimit", DataRowVersion.Original] != DBNull.Value)
        str3 = this.ds.tblQuoteOptionProperty[this.bmb.Position]["PolicyLimit", DataRowVersion.Original].ToString();
      if (this.ds.tblQuoteOptionProperty[this.bmb.Position]["PolicyLimit", DataRowVersion.Current] != DBNull.Value)
        str4 = this.ds.tblQuoteOptionProperty[this.bmb.Position]["PolicyLimit", DataRowVersion.Current].ToString();
      if (!str3.Equals(str4))
        stringList.Add($"Change Limit from {str3} to {str4}");
    }
    return stringList;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidForm())
      e.Cancel = true;
    else if (!this.ConditionalValidation())
    {
      e.Cancel = true;
    }
    else
    {
      int quoteOptionId = this.ds.tblQuoteOptionProperty[this.bmb.Position].QuoteOptionID;
      this.SaveData(this.ds.tblQuoteOptions.FindByQuoteOptionID(quoteOptionId).QuoteOptionGUID);
      this.ugOptions.Selected.Rows.Clear();
      foreach (UltraGridRow row in ((UltraGridBase) this.ugOptions).Rows)
      {
        if ((int) row.Cells["QuoteOptionID"].Value == quoteOptionId)
        {
          row.Selected = true;
          Database.MoveTo((object) quoteOptionId, this.ds.tblQuoteOptions.QuoteOptionIDColumn.ColumnName, (DataTable) this.ds.tblQuoteOptions, this.bmb);
          this.ds.tblQuoteOptionProperty_SubLimits.DefaultView.RowFilter = "PropertyOptionID=" + this.ds.tblQuoteOptionProperty[this.bmb.Position].ID.ToString();
          break;
        }
      }
      ((Control) this.btnContinue).Enabled = true;
    }
  }

  private void SaveData(Guid quoteOptionGuid)
  {
    // ISSUE: variable of a compiler-generated type
    frmPropertyRater._Closure\u0024__295\u002D0 closure2950_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmPropertyRater._Closure\u0024__295\u002D0 closure2950_2 = new frmPropertyRater._Closure\u0024__295\u002D0(closure2950_1);
    // ISSUE: reference to a compiler-generated field
    closure2950_2.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure2950_2.\u0024VB\u0024Local_quoteOptionGuid = quoteOptionGuid;
    this.bmb.EndCurrentEdit();
    // ISSUE: reference to a compiler-generated field
    closure2950_2.\u0024VB\u0024Local_isNewRow = this.bmb.Position != -1 && this.ds.tblQuoteOptionProperty[this.bmb.Position].RowState == DataRowState.Added;
    // ISSUE: reference to a compiler-generated field
    closure2950_2.\u0024VB\u0024Local_isDeleted = this.bmb.Position == -1 || this.ds.tblQuoteOptionProperty[this.bmb.Position].RowState == DataRowState.Deleted;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    List<string> stringList = this.LoggingInfo(closure2950_2.\u0024VB\u0024Local_isNewRow, closure2950_2.\u0024VB\u0024Local_isDeleted);
    // ISSUE: reference to a compiler-generated field
    closure2950_2.\u0024VB\u0024Local_rowsAffected = 0;
    // ISSUE: reference to a compiler-generated method
    DefaultDatabase.ExecuteTransaction(new EventHandler<ExecuteTransactionEventArgs>(closure2950_2._Lambda\u0024__0));
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    if (closure2950_2.\u0024VB\u0024Local_transactionCommitted && closure2950_2.\u0024VB\u0024Local_rowsAffected > 0)
    {
      // ISSUE: reference to a compiler-generated field
      int num = (int) MessageBox.Show($"The option was saved succesfully.{Environment.NewLine}{Environment.NewLine}{closure2950_2.\u0024VB\u0024Local_rowsAffected} rows of exposure information were copied.", "Option Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    try
    {
      foreach (string action in stringList)
        CurrentUser.Instance.LogAction(action, this.Rater.QuoteGuid);
    }
    finally
    {
      List<string>.Enumerator enumerator;
      enumerator.Dispose();
    }
    // ISSUE: reference to a compiler-generated field
    if (closure2950_2.\u0024VB\u0024Local_isDeleted && !this._quote.IsBound)
    {
      // ISSUE: reference to a compiler-generated field
      this.Rater.OptionDeleted(closure2950_2.\u0024VB\u0024Local_quoteOptionGuid);
    }
    else if (!this._quote.IsBound)
    {
      QuoteOption quoteOption = new QuoteOption(this.QuoteOptionID);
      this.PropertyRater.RefreshPremiums(quoteOption);
      MDIControls.Instance.StatusBarText = "Rating option...";
      this.Rater.RateOption(quoteOption.QuoteOptionGuid);
      MDIControls.Instance.StatusBarText = "Refreshing premium...";
      this.ds.tblQuoteOptions.FindByQuoteOptionID(this.QuoteOptionID).Premium = Conversions.ToDecimal(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Premium FROM tblQuoteOptions WHERE QuoteOptionID=@QOID", new object[2]
      {
        (object) "@QOID",
        (object) this.QuoteOptionID
      }));
    }
    this.Cursor = MgaCursors.Default;
    MDIControls.Instance.StatusBarText = string.Empty;
  }

  private void ugSubLimits_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (!this.CancelRowUpdate(RuntimeHelpers.GetObjectValue(sender), e))
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  private void ugSubLimits_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["PropertyOptionID"].Value = (object) this.ds.tblQuoteOptionProperty[this.bmb.Position].ID;
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.tblQuoteOptionProperty.RejectChanges();
    this.ds.tblQuoteOptions.RejectChanges();
    ((Control) this.btnContinue).Enabled = ((UltraGridBase) this.ugOptions).ActiveRow != null;
    if (this.dbSave.UIState != UIState.Editing)
      this.dbSave.UIState = this.ds.tblQuoteOptionProperty.Count != 0 ? UIState.HasRecordsNotEditing : UIState.NoRecordsNotEditing;
    this.ClearErrorProviders();
    if (this.bmb.Position != -1)
      this.ds.tblQuoteOptionProperty_SubLimits.DefaultView.RowFilter = "PropertyOptionID=" + this.ds.tblQuoteOptionProperty[this.bmb.Position].ID.ToString();
    this.OnClickedCancel();
  }

  private void ClearErrorProviders()
  {
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
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
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
      return;
    if (this.Rater.Quote.IsBound)
    {
      int num = (int) MessageBox.Show("Cannot delete options on a bound policy", "No Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      int quoteOptionId = this.ds.tblQuoteOptionProperty[this.bmb.Position].QuoteOptionID;
      if (MessageBox.Show("Are you sure you want to delete this option?", "Delete Option?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      Guid quoteOptionGuid = this.ds.tblQuoteOptions.FindByQuoteOptionID(quoteOptionId).QuoteOptionGUID;
      this.ds.tblQuoteOptions.FindByQuoteOptionID(quoteOptionId).Delete();
      try
      {
        this.SaveData(quoteOptionGuid);
        this.DeletePriorRates(quoteOptionId);
        ((Control) this.btnContinue).Enabled = this.ds.tblQuoteOptions.Count > 0;
        ((UltraGridBase) this.ugOptions).UpdateData();
        if (this.ds.tblQuoteOptions.Count > 0)
        {
          this.bmb.Position = 0;
          ((UltraGridBase) this.ugOptions).ActiveRow = ((UltraGridBase) this.ugOptions).Rows[0];
          ((UltraGridBase) this.ugOptions).Rows[0].Selected = true;
        }
        if (this.dbSave.UIState != UIState.Editing)
          this.dbSave.UIState = this.ds.tblQuoteOptionProperty.Count != 0 ? UIState.HasRecordsNotEditing : UIState.NoRecordsNotEditing;
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleError((Exception) ex);
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
      this.OnClickingDelete(quoteOptionGuid);
    }
  }

  private void DeletePriorRates(int quoteOptionID)
  {
    try
    {
      foreach (dsPropertyRater.tblPropertyExposuresPriorYearsRow row in this.ds.tblPropertyExposuresPriorYears.Rows)
      {
        if (row.QuoteOptionID == quoteOptionID)
          row.Delete();
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daRates, (DataTable) this.ds.tblPropertyExposuresPriorYears);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this._strikeoutFont != null)
        this._strikeoutFont.Dispose();
      if (this._originalFont != null)
        this._originalFont.Dispose();
      if (this.components != null)
        this.components.Dispose();
      if (this._deleteSublimitsLink != null)
        ((DisposableObject) this._deleteSublimitsLink).Dispose();
      if (this._cn != null)
      {
        this._cn.Close();
        this._cn.Dispose();
      }
    }
    base.Dispose(disposing);
  }

  private void ugPrior_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["QuoteOptionID"].Value = (object) this.QuoteOptionID;
    e.Row.Cells["IsPreviouslyApplied"].Value = (object) false;
  }

  private void _bmb_PositionChanged(object sender, EventArgs e)
  {
    this.ds.tblPropertyExposuresPriorYears.Clear();
    if (this.bmb.Position == -1)
      return;
    this.daRates.SelectCommand.Parameters["@QuoteOptionID"].Value = (object) this.QuoteOptionID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daRates, (DataTable) this.ds.tblPropertyExposuresPriorYears);
    ((UltraGridBase) this.ugPrior).UpdateData();
    this.SetClientData(this.ds.tblQuoteOptions[this.bmb.Position].QuoteOptionGUID);
  }

  private void ugPrior_BeforeRowInsert(object sender, BeforeRowInsertEventArgs e)
  {
    if (this.bmb.Position != -1 && this.ds.tblQuoteOptionProperty[this.bmb.Position].RowState != DataRowState.Added)
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  private void ugPrior_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (e.Row.Cells["IsPreviouslyApplied"].Value == DBNull.Value || e.Row.Cells["IsPreviouslyApplied"].Value == null || !Conversions.ToBoolean(e.Row.Cells["IsPreviouslyApplied"].Value))
      return;
    int num = (int) MessageBox.Show("Cannot Save: At least one 'Auto Applied' row has been modified and will not be saved.", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    ((CancelEventArgs) e).Cancel = true;
  }

  private void lnkCancelPriorRates_Click(object sender, EventArgs e)
  {
    this.ds.tblPropertyExposuresPriorYears.RejectChanges();
    ((UltraControlBase) this.ugPrior).Update();
  }

  private void ddLimit_BeforeDropDown(object sender, CancelEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ddLimit).Rows)
    {
      row.Hidden = false;
      if (this.bmb.Position != -1)
      {
        int id = this.ds.tblQuoteOptionProperty[this.bmb.Position].ID;
        row.Hidden = this.ds.tblQuoteOptionProperty_SubLimits.Select($"SubLimitID={row.Cells["SubLimitID"].Value.ToString()} AND PropertyOptionID = {Conversions.ToString(id)}").Length > 0;
      }
    }
  }

  private void lnkCopyOptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show($"You are about to import options from the renewed quote with control #{this._renewedQuoteControlNo.ToString()}\n\nDo you wish to continue?", "Import Renewal Options", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
      {
        this.ReloadRenewalOptionsTransaction(RuntimeHelpers.GetObjectValue(obj), args);
        args.Transaction.Commit();
      }));
      this.FillOptions();
      this.lnkCalculateRate_LinkClicked((object) this, (LinkLabelLinkClickedEventArgs) null);
      this.dbSave_ClickingSave((object) this, (CancelEventArgs) null);
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private object ReloadRenewalOptionsTransaction(object sender, ExecuteTransactionEventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spCopyOptionsFromRenewedQuote", new object[4]
    {
      (object) "@currentQuoteGuid",
      (object) this.Rater.Quote.QuoteGuid,
      (object) "@userGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    CurrentUser.Instance.LogAction("Copy Options from renewed quote", this.Rater.QuoteGuid);
    return (object) null;
  }

  protected virtual void SaveClientData(SqlTransaction trans, Guid quoteOptionGuid)
  {
  }

  protected virtual void SetClientData(Guid QuoteOptionGuid)
  {
  }

  protected virtual void OnFormLoad()
  {
  }

  protected virtual void CauseOfLossBeforeDropDown(object sender, CancelEventArgs e)
  {
  }

  protected virtual bool CancelRowUpdate(object sender, CancelableRowEventArgs e)
  {
    return e.Row.Cells["Limit"].Value == DBNull.Value || e.Row.Cells["Deductible"].Value == DBNull.Value && e.Row.Cells["DeductiblePercentage"].Value == DBNull.Value;
  }

  private void cboCauseofLoss_BeforeDropDown(object sender, CancelEventArgs e)
  {
    this.CauseOfLossBeforeDropDown(RuntimeHelpers.GetObjectValue(sender), e);
  }

  protected virtual void cboLimitDescriptions_Validating(object sender, CancelEventArgs e)
  {
    if (this.cboLimitDescriptions.Text.Length <= 0 || !Conversions.ToBoolean(((UltraDropDownBase) this.cboLimitDescriptions).SelectedRow.Cells["Hidden"].Value))
      return;
    this.err.SetError((Control) this.cboLimitDescriptions, "Please select valid limit description.");
  }

  private void cboLimitDescriptions_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (!Conversions.ToBoolean(e.Row.Cells["Hidden"].Value))
      return;
    e.Row.Appearance.ForeColor = Color.LightGray;
  }

  private void lnkLocationExcelImport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Form objectEx = (Form) ObjectFactory.Instance.CreateObjectEX(ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Policies.FormLocationExcelImport"), (object) this._quote.QuoteGuid);
    using (objectEx)
    {
      objectEx.ShowInTaskbar = false;
      int num = (int) objectEx.ShowDialog();
    }
  }

  private void cboCauseofLoss_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (!Conversions.ToBoolean(e.Row.Cells["Hidden"].Value))
      return;
    e.Row.Appearance.ForeColor = Color.LightGray;
  }

  private void cboCauseofLoss_Validating(object sender, CancelEventArgs e)
  {
    if (this.cboCauseofLoss.Text.Length <= 0 || !Conversions.ToBoolean(((UltraDropDownBase) this.cboCauseofLoss).SelectedRow.Cells["Hidden"].Value))
      return;
    this.err.SetError((Control) this.cboCauseofLoss, "Please select valid cause of loss.");
  }

  protected virtual void EnableDisableClientControls()
  {
  }

  protected virtual void OnClickingNew(
    dsPropertyRater.tblQuoteOptionPropertyRow propertyRow)
  {
  }

  protected virtual void OnClickingDelete(Guid quoteOptionGuid)
  {
  }

  protected virtual void OnClickedCancel()
  {
  }

  private delegate void ThreadCompleteDelegate();
}

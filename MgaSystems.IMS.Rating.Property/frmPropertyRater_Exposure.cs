// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Rating.Property.frmPropertyRater_Exposure
// Assembly: MgaSystems.IMS.Rating.Property, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B6A893CA-828D-4C72-A3E1-997D4DDF80FA
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.Property.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.Policies.Rating;
using MGASystems.IMS.Policies.Rating.Endorsements;
using MGASystems.IMS.Policies.Rating.Locations;
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
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.IMS.Rating.Property;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
[SecureResource("{7F84EFED-6F80-48ef-BD1C-C3226007951F}", "Can Add Exposure After Policy Bound", "Controls the ability to add exposures after the policy is bound.", "Rating")]
[SecureResource("{FD56285A-8B65-46ae-8C64-5F7731C299FA}", "Can Edit Exposure After Policy Bound", "Controls the ability to edit exposures after the policy is bound.", "Rating")]
[SecureResource("{55B3BB5A-2686-48b2-A511-BA76B2F431A0}", "Can Delete Exposure After Policy Bound", "Controls the ability to delete exposures after the policy is bound.", "Rating")]
[SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
public class frmPropertyRater_Exposure : Form
{
  private IContainer components;
  private SqlDataAdapter daLocations;
  private SqlCommand SqlSelectCommand1;
  private Label lblOptionID;
  private Label Label11;
  private MGASimpleComboBox cboCoInsurance;
  private SqlCommand SqlSelectCommand2;
  private SqlConnection cn;
  private SqlDataAdapter daLookups;
  private MGASimpleComboBox cboLossCauses;
  private MGASimpleComboBox cboValuation;
  private MGASimpleComboBox cboCoverages;
  private UltraLabel lblFactor;
  private MGASimpleComboBox cboCalcType;
  private MGASimpleComboBox cboClientOffices;
  private SqlDataAdapter daExposure;
  private ErrorProvider err;
  private UltraDropDown ddCoverages;
  private MGATextBox txtCoInsurance;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private UltraTabPageControl UltraTabPageControl3;
  private ToolTip ToolTip1;
  private MGASimpleComboBox cboDeductiblePer;
  private UltraToolbarsDockArea _frmPropertyRater_Exposure_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmPropertyRater_Exposure_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _frmPropertyRater_Exposure_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom;
  private MGATextBox txtOtherDeductibles;
  private MGACheckBox chkWaivePremiums;
  private SqlCommand SqlSelectCommand3;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private QuoteOption _quoteOption;
  private Quote _quote;
  private PropertyRater _propRater;
  private Font _strikeoutFont;
  private Font _originalFont;
  private object _terrorismDeclined;
  private int _exposureID;
  private bool _loaded;
  private bool _blockExcessPrem;
  private bool _canAddExposureAfterBind;
  private bool _canEditExposureAfterBind;
  private bool _canDeleteExposureAfterBind;
  private bool _roundToDollar;
  internal const string CanAddExposureAfterBind = "{7F84EFED-6F80-48ef-BD1C-C3226007951F}";
  internal const string CanEditExposureAfterBind = "{FD56285A-8B65-46ae-8C64-5F7731C299FA}";
  internal const string CanDeleteExposureAfterBind = "{55B3BB5A-2686-48b2-A511-BA76B2F431A0}";
  private frmPleaseWait _frmPleaseWait;
  private DateTime _endorsementActionDate;
  private Decimal _endorsementFactor;
  private bool _factorOverridden;
  private int _lastExposureRowInitialized;

  [field: AccessedThroughProperty("ds")]
  protected virtual dsPropertyRater_Exposure ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkModifyLocations
  {
    get => this._lnkModifyLocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkModifyLocations_LinkClicked);
      LinkLabel lnkModifyLocations1 = this._lnkModifyLocations;
      if (lnkModifyLocations1 != null)
        lnkModifyLocations1.LinkClicked -= clickedEventHandler;
      this._lnkModifyLocations = value;
      LinkLabel lnkModifyLocations2 = this._lnkModifyLocations;
      if (lnkModifyLocations2 == null)
        return;
      lnkModifyLocations2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGANumericEditor numTerrPrem
  {
    get => this._numTerrPrem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.UpdatePremiumValues);
      EventHandler eventHandler2 = new EventHandler(this.numLimit_Enter);
      EventHandler eventHandler3 = new EventHandler(this.numLimit_Leave);
      EventHandler eventHandler4 = new EventHandler(this.Terror_ValueChanged);
      MGANumericEditor numTerrPrem1 = this._numTerrPrem;
      if (numTerrPrem1 != null)
      {
        ((UltraNumericEditorBase) numTerrPrem1).ValueChanged -= eventHandler1;
        ((Control) numTerrPrem1).Enter -= eventHandler2;
        ((Control) numTerrPrem1).Leave -= eventHandler3;
        ((UltraNumericEditorBase) numTerrPrem1).ValueChanged -= eventHandler4;
      }
      this._numTerrPrem = value;
      MGANumericEditor numTerrPrem2 = this._numTerrPrem;
      if (numTerrPrem2 == null)
        return;
      ((UltraNumericEditorBase) numTerrPrem2).ValueChanged += eventHandler1;
      ((Control) numTerrPrem2).Enter += eventHandler2;
      ((Control) numTerrPrem2).Leave += eventHandler3;
      ((UltraNumericEditorBase) numTerrPrem2).ValueChanged += eventHandler4;
    }
  }

  private virtual LinkLabel lnkEffective
  {
    get => this._lnkEffective;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkEffective_LinkClicked);
      LinkLabel lnkEffective1 = this._lnkEffective;
      if (lnkEffective1 != null)
        lnkEffective1.LinkClicked -= clickedEventHandler;
      this._lnkEffective = value;
      LinkLabel lnkEffective2 = this._lnkEffective;
      if (lnkEffective2 == null)
        return;
      lnkEffective2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual UltraGrid dgLocations
  {
    get => this._dgLocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.dgLocations_MouseDown);
      EventHandler eventHandler = new EventHandler(this.dgLocations_AfterRowActivate);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.dgLocations_InitializeRow);
      UltraGrid dgLocations1 = this._dgLocations;
      if (dgLocations1 != null)
      {
        ((Control) dgLocations1).MouseDown -= mouseEventHandler;
        dgLocations1.AfterRowActivate -= eventHandler;
        dgLocations1.InitializeRow -= initializeRowEventHandler;
      }
      this._dgLocations = value;
      UltraGrid dgLocations2 = this._dgLocations;
      if (dgLocations2 == null)
        return;
      ((Control) dgLocations2).MouseDown += mouseEventHandler;
      dgLocations2.AfterRowActivate += eventHandler;
      dgLocations2.InitializeRow += initializeRowEventHandler;
    }
  }

  private virtual MGANumericEditor numExcessPrem
  {
    get => this._numExcessPrem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.UpdatePremiumValues);
      EventHandler eventHandler2 = new EventHandler(this.numLimit_Enter);
      EventHandler eventHandler3 = new EventHandler(this.numLimit_Leave);
      EventHandler eventHandler4 = new EventHandler(this.NonTerror_ValueChanged);
      MGANumericEditor numExcessPrem1 = this._numExcessPrem;
      if (numExcessPrem1 != null)
      {
        ((UltraNumericEditorBase) numExcessPrem1).ValueChanged -= eventHandler1;
        ((Control) numExcessPrem1).Enter -= eventHandler2;
        ((Control) numExcessPrem1).Leave -= eventHandler3;
        ((UltraNumericEditorBase) numExcessPrem1).ValueChanged -= eventHandler4;
      }
      this._numExcessPrem = value;
      MGANumericEditor numExcessPrem2 = this._numExcessPrem;
      if (numExcessPrem2 == null)
        return;
      ((UltraNumericEditorBase) numExcessPrem2).ValueChanged += eventHandler1;
      ((Control) numExcessPrem2).Enter += eventHandler2;
      ((Control) numExcessPrem2).Leave += eventHandler3;
      ((UltraNumericEditorBase) numExcessPrem2).ValueChanged += eventHandler4;
    }
  }

  private virtual MGANumericEditor numLimit
  {
    get => this._numLimit;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.numLimit_Enter);
      EventHandler eventHandler2 = new EventHandler(this.numLimit_Leave);
      EventHandler eventHandler3 = new EventHandler(this.numLimit_ValueChanged);
      MGANumericEditor numLimit1 = this._numLimit;
      if (numLimit1 != null)
      {
        ((Control) numLimit1).Enter -= eventHandler1;
        ((Control) numLimit1).Leave -= eventHandler2;
        ((UltraNumericEditorBase) numLimit1).ValueChanged -= eventHandler3;
      }
      this._numLimit = value;
      MGANumericEditor numLimit2 = this._numLimit;
      if (numLimit2 == null)
        return;
      ((Control) numLimit2).Enter += eventHandler1;
      ((Control) numLimit2).Leave += eventHandler2;
      ((UltraNumericEditorBase) numLimit2).ValueChanged += eventHandler3;
    }
  }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  protected virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGANumericEditor numExcessRate
  {
    get => this._numExcessRate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.NonTerrorRates_ValueChanged);
      MGANumericEditor numExcessRate1 = this._numExcessRate;
      if (numExcessRate1 != null)
        ((UltraNumericEditorBase) numExcessRate1).ValueChanged -= eventHandler;
      this._numExcessRate = value;
      MGANumericEditor numExcessRate2 = this._numExcessRate;
      if (numExcessRate2 == null)
        return;
      ((UltraNumericEditorBase) numExcessRate2).ValueChanged += eventHandler;
    }
  }

  private virtual MGANumericEditor numTerrRate
  {
    get => this._numTerrRate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.numTerrRate_ValueChanged);
      MGANumericEditor numTerrRate1 = this._numTerrRate;
      if (numTerrRate1 != null)
        ((UltraNumericEditorBase) numTerrRate1).ValueChanged -= eventHandler;
      this._numTerrRate = value;
      MGANumericEditor numTerrRate2 = this._numTerrRate;
      if (numTerrRate2 == null)
        return;
      ((UltraNumericEditorBase) numTerrRate2).ValueChanged += eventHandler;
    }
  }

  private virtual LinkLabel lnkCalcExcessPremium
  {
    get => this._lnkCalcExcessPremium;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCalcExcessPremium_LinkClicked);
      LinkLabel calcExcessPremium1 = this._lnkCalcExcessPremium;
      if (calcExcessPremium1 != null)
        calcExcessPremium1.LinkClicked -= clickedEventHandler;
      this._lnkCalcExcessPremium = value;
      LinkLabel calcExcessPremium2 = this._lnkCalcExcessPremium;
      if (calcExcessPremium2 == null)
        return;
      calcExcessPremium2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkCalcAccountRate
  {
    get => this._lnkCalcAccountRate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCalcAccountRate_LinkClicked);
      LinkLabel lnkCalcAccountRate1 = this._lnkCalcAccountRate;
      if (lnkCalcAccountRate1 != null)
        lnkCalcAccountRate1.LinkClicked -= clickedEventHandler;
      this._lnkCalcAccountRate = value;
      LinkLabel lnkCalcAccountRate2 = this._lnkCalcAccountRate;
      if (lnkCalcAccountRate2 == null)
        return;
      lnkCalcAccountRate2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGANumericEditor txtAOPDA
  {
    get => this._txtAOPDA;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.numLimit_Enter);
      EventHandler eventHandler2 = new EventHandler(this.numLimit_Leave);
      MGANumericEditor txtAopda1 = this._txtAOPDA;
      if (txtAopda1 != null)
      {
        ((Control) txtAopda1).Enter -= eventHandler1;
        ((Control) txtAopda1).Leave -= eventHandler2;
      }
      this._txtAOPDA = value;
      MGANumericEditor txtAopda2 = this._txtAOPDA;
      if (txtAopda2 == null)
        return;
      ((Control) txtAopda2).Enter += eventHandler1;
      ((Control) txtAopda2).Leave += eventHandler2;
    }
  }

  private virtual UltraToolbarsManager UltraToolbarsManager1
  {
    get => this._UltraToolbarsManager1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.UltraToolbarsManager1_ToolClick);
      UltraToolbarsManager toolbarsManager1_1 = this._UltraToolbarsManager1;
      if (toolbarsManager1_1 != null)
        toolbarsManager1_1.ToolClick -= clickEventHandler;
      this._UltraToolbarsManager1 = value;
      UltraToolbarsManager toolbarsManager1_2 = this._UltraToolbarsManager1;
      if (toolbarsManager1_2 == null)
        return;
      toolbarsManager1_2.ToolClick += clickEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblTotalLocationPremium")]
  private virtual UltraLabel lblTotalLocationPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkModifyFactor
  {
    get => this._lnkModifyFactor;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkModifyFactor_LinkClicked);
      LinkLabel lnkModifyFactor1 = this._lnkModifyFactor;
      if (lnkModifyFactor1 != null)
        lnkModifyFactor1.LinkClicked -= clickedEventHandler;
      this._lnkModifyFactor = value;
      LinkLabel lnkModifyFactor2 = this._lnkModifyFactor;
      if (lnkModifyFactor2 == null)
        return;
      lnkModifyFactor2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkAddMiscPremiums
  {
    get => this._lnkAddMiscPremiums;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddMiscPremiums_LinkClicked);
      LinkLabel lnkAddMiscPremiums1 = this._lnkAddMiscPremiums;
      if (lnkAddMiscPremiums1 != null)
        lnkAddMiscPremiums1.LinkClicked -= clickedEventHandler;
      this._lnkAddMiscPremiums = value;
      LinkLabel lnkAddMiscPremiums2 = this._lnkAddMiscPremiums;
      if (lnkAddMiscPremiums2 == null)
        return;
      lnkAddMiscPremiums2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGANumericEditor numAccountRate
  {
    get => this._numAccountRate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.NonTerrorRates_ValueChanged);
      MGANumericEditor numAccountRate1 = this._numAccountRate;
      if (numAccountRate1 != null)
        ((UltraNumericEditorBase) numAccountRate1).ValueChanged -= eventHandler;
      this._numAccountRate = value;
      MGANumericEditor numAccountRate2 = this._numAccountRate;
      if (numAccountRate2 == null)
        return;
      ((UltraNumericEditorBase) numAccountRate2).ValueChanged += eventHandler;
    }
  }

  private virtual LinkLabel lnkCalculateExcessRate
  {
    get => this._lnkCalculateExcessRate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCalculateExcessRate_LinkClicked);
      LinkLabel calculateExcessRate1 = this._lnkCalculateExcessRate;
      if (calculateExcessRate1 != null)
        calculateExcessRate1.LinkClicked -= clickedEventHandler;
      this._lnkCalculateExcessRate = value;
      LinkLabel calculateExcessRate2 = this._lnkCalculateExcessRate;
      if (calculateExcessRate2 == null)
        return;
      calculateExcessRate2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual MGANumericEditor numExcessTerror
  {
    get => this._numExcessTerror;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Terror_ValueChanged);
      MGANumericEditor numExcessTerror1 = this._numExcessTerror;
      if (numExcessTerror1 != null)
        ((UltraNumericEditorBase) numExcessTerror1).ValueChanged -= eventHandler;
      this._numExcessTerror = value;
      MGANumericEditor numExcessTerror2 = this._numExcessTerror;
      if (numExcessTerror2 == null)
        return;
      ((UltraNumericEditorBase) numExcessTerror2).ValueChanged += eventHandler;
    }
  }

  private virtual LinkLabel lnkCalculateTotalNonTerror
  {
    get => this._lnkCalculateTotalNonTerror;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCalculateTotalNonTerror_LinkClicked);
      LinkLabel calculateTotalNonTerror1 = this._lnkCalculateTotalNonTerror;
      if (calculateTotalNonTerror1 != null)
        calculateTotalNonTerror1.LinkClicked -= clickedEventHandler;
      this._lnkCalculateTotalNonTerror = value;
      LinkLabel calculateTotalNonTerror2 = this._lnkCalculateTotalNonTerror;
      if (calculateTotalNonTerror2 == null)
        return;
      calculateTotalNonTerror2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGANumericEditor numTotalNonTerror
  {
    get => this._numTotalNonTerror;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.NonTerror_ValueChanged);
      MGANumericEditor numTotalNonTerror1 = this._numTotalNonTerror;
      if (numTotalNonTerror1 != null)
        ((UltraNumericEditorBase) numTotalNonTerror1).ValueChanged -= eventHandler;
      this._numTotalNonTerror = value;
      MGANumericEditor numTotalNonTerror2 = this._numTotalNonTerror;
      if (numTotalNonTerror2 == null)
        return;
      ((UltraNumericEditorBase) numTotalNonTerror2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblTotalNonTerrorExcess")]
  private virtual Label lblTotalNonTerrorExcess { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTotalPremium")]
  private virtual Label lblTotalPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTotalTerrorism")]
  private virtual Label lblTotalTerrorism { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTotalTIV")]
  private virtual Label lblTotalTIV { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTotalNonTerror")]
  private virtual Label lblTotalNonTerror { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkCalcExcessTerror
  {
    get => this._lnkCalcExcessTerror;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCalcExcessTerror_LinkClicked);
      LinkLabel calcExcessTerror1 = this._lnkCalcExcessTerror;
      if (calcExcessTerror1 != null)
        calcExcessTerror1.LinkClicked -= clickedEventHandler;
      this._lnkCalcExcessTerror = value;
      LinkLabel calcExcessTerror2 = this._lnkCalcExcessTerror;
      if (calcExcessTerror2 == null)
        return;
      calcExcessTerror2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("numPrimaryRate")]
  private virtual MGANumericEditor numPrimaryRate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numPrimaryTerror")]
  private virtual MGANumericEditor numPrimaryTerror { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numPrimaryPrem")]
  private virtual MGANumericEditor numPrimaryPrem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingEdit);
      EventHandler eventHandler1 = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingDelete);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingEdit -= cancelEventHandler1;
        dbSave1.UIStateChanged -= eventHandler1;
        dbSave1.ClickingNew -= cancelEventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler3;
        dbSave1.ClickedCancel -= eventHandler2;
        dbSave1.ClickingDelete -= cancelEventHandler4;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingEdit += cancelEventHandler1;
      dbSave2.UIStateChanged += eventHandler1;
      dbSave2.ClickingNew += cancelEventHandler2;
      dbSave2.ClickingSave += cancelEventHandler3;
      dbSave2.ClickedCancel += eventHandler2;
      dbSave2.ClickingDelete += cancelEventHandler4;
    }
  }

  private virtual LinkLabel lnkCalcTotalTerrorPremium
  {
    get => this._lnkCalcTotalTerrorPremium;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCalcTotalTerrorPremium_LinkClicked);
      LinkLabel totalTerrorPremium1 = this._lnkCalcTotalTerrorPremium;
      if (totalTerrorPremium1 != null)
        totalTerrorPremium1.LinkClicked -= clickedEventHandler;
      this._lnkCalcTotalTerrorPremium = value;
      LinkLabel totalTerrorPremium2 = this._lnkCalcTotalTerrorPremium;
      if (totalTerrorPremium2 == null)
        return;
      totalTerrorPremium2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabControl1")]
  protected virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel linkDeleteAllSelected
  {
    get => this._linkDeleteAllSelected;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkDeleteAllSelected_LinkClicked);
      LinkLabel deleteAllSelected1 = this._linkDeleteAllSelected;
      if (deleteAllSelected1 != null)
        deleteAllSelected1.LinkClicked -= clickedEventHandler;
      this._linkDeleteAllSelected = value;
      LinkLabel deleteAllSelected2 = this._linkDeleteAllSelected;
      if (deleteAllSelected2 == null)
        return;
      deleteAllSelected2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel linkRestoreExposures
  {
    get => this._linkRestoreExposures;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkRestoreExposures_LinkClicked);
      LinkLabel restoreExposures1 = this._linkRestoreExposures;
      if (restoreExposures1 != null)
        restoreExposures1.LinkClicked -= clickedEventHandler;
      this._linkRestoreExposures = value;
      LinkLabel restoreExposures2 = this._linkRestoreExposures;
      if (restoreExposures2 == null)
        return;
      restoreExposures2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel linkUnselectAll
  {
    get => this._linkUnselectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkUnselectAll_LinkClicked);
      LinkLabel linkUnselectAll1 = this._linkUnselectAll;
      if (linkUnselectAll1 != null)
        linkUnselectAll1.LinkClicked -= clickedEventHandler;
      this._linkUnselectAll = value;
      LinkLabel linkUnselectAll2 = this._linkUnselectAll;
      if (linkUnselectAll2 == null)
        return;
      linkUnselectAll2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel linkSelectAll
  {
    get => this._linkSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkSelectAll_LinkClicked);
      LinkLabel linkSelectAll1 = this._linkSelectAll;
      if (linkSelectAll1 != null)
        linkSelectAll1.LinkClicked -= clickedEventHandler;
      this._linkSelectAll = value;
      LinkLabel linkSelectAll2 = this._linkSelectAll;
      if (linkSelectAll2 == null)
        return;
      linkSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel linkModifyFactorMulti
  {
    get => this._linkModifyFactorMulti;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkModifyFactorMulti_LinkClicked);
      LinkLabel modifyFactorMulti1 = this._linkModifyFactorMulti;
      if (modifyFactorMulti1 != null)
        modifyFactorMulti1.LinkClicked -= clickedEventHandler;
      this._linkModifyFactorMulti = value;
      LinkLabel modifyFactorMulti2 = this._linkModifyFactorMulti;
      if (modifyFactorMulti2 == null)
        return;
      modifyFactorMulti2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel linkDeclineTerrorism
  {
    get => this._linkDeclineTerrorism;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.ToggleTerrorism);
      LinkLabel declineTerrorism1 = this._linkDeclineTerrorism;
      if (declineTerrorism1 != null)
        declineTerrorism1.LinkClicked -= clickedEventHandler;
      this._linkDeclineTerrorism = value;
      LinkLabel declineTerrorism2 = this._linkDeclineTerrorism;
      if (declineTerrorism2 == null)
        return;
      declineTerrorism2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel linkIncludeTerrorism
  {
    get => this._linkIncludeTerrorism;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.ToggleTerrorism);
      LinkLabel includeTerrorism1 = this._linkIncludeTerrorism;
      if (includeTerrorism1 != null)
        includeTerrorism1.LinkClicked -= clickedEventHandler;
      this._linkIncludeTerrorism = value;
      LinkLabel includeTerrorism2 = this._linkIncludeTerrorism;
      if (includeTerrorism2 == null)
        return;
      includeTerrorism2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("labelExcessTerror")]
  private virtual Label labelExcessTerror { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAdditionalInfo")]
  private virtual MGATextBox txtAdditionalInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel linkPolicyExtension
  {
    get => this._linkPolicyExtension;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkPolicyExtension_LinkClicked);
      LinkLabel linkPolicyExtension1 = this._linkPolicyExtension;
      if (linkPolicyExtension1 != null)
        linkPolicyExtension1.LinkClicked -= clickedEventHandler;
      this._linkPolicyExtension = value;
      LinkLabel linkPolicyExtension2 = this._linkPolicyExtension;
      if (linkPolicyExtension2 == null)
        return;
      linkPolicyExtension2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkExportSchedule
  {
    get => this._lnkExportSchedule;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkExportSchedule_LinkClicked);
      LinkLabel lnkExportSchedule1 = this._lnkExportSchedule;
      if (lnkExportSchedule1 != null)
        lnkExportSchedule1.LinkClicked -= clickedEventHandler;
      this._lnkExportSchedule = value;
      LinkLabel lnkExportSchedule2 = this._lnkExportSchedule;
      if (lnkExportSchedule2 == null)
        return;
      lnkExportSchedule2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblExcessTerror")]
  protected virtual Label lblExcessTerror { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblExcessRate")]
  protected virtual Label lblExcessRate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNonTerrorExcess")]
  protected virtual Label lblNonTerrorExcess { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkCalcTerrRate
  {
    get => this._lnkCalcTerrRate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCalcTerrRate_LinkClicked);
      LinkLabel lnkCalcTerrRate1 = this._lnkCalcTerrRate;
      if (lnkCalcTerrRate1 != null)
        lnkCalcTerrRate1.LinkClicked -= clickedEventHandler;
      this._lnkCalcTerrRate = value;
      LinkLabel lnkCalcTerrRate2 = this._lnkCalcTerrRate;
      if (lnkCalcTerrRate2 == null)
        return;
      lnkCalcTerrRate2.LinkClicked += clickedEventHandler;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPropertyRater_Exposure));
    Appearance appearance19 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblUnderwritingLocations", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LocationNo");
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("BuildingNo");
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("PhysicalBuildingNo");
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Address");
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("City");
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("State");
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Zip");
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("TotalPremium");
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("TerrPremium");
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ModificationCode");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("tblUnderwritingLocationstblPropertyExposure");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblUnderwritingLocationstblPropertyExposure", 0);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ExposureID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("OriginalExposureID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("QuoteOptionID");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("TotalNonTerrorPremium");
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("PrimaryPremium");
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ExcessPremium");
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("TerrPremium");
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("TerrorPrimary");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("TerrorExcess");
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("ModificationCode");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("EndorsementCalcType");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("Factor");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("UserAdded");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("CoverageID", -1, (object) "ddCoverages");
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("CoInsuranceID");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("ValuationID");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("CauseOfLossID");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("Deductible");
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("DeductiblePerID");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("Limit");
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("CoInsurance");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("AccountRate");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("PrimaryRate");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("ExcessRate");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("TerrRate");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("UserOverrideFactor");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("OtherDeductibles");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("PremiumsWaived");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("Selected");
    Appearance appearance54 = new Appearance();
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("AdditionalInfo");
    SummarySettings summarySettings1 = new SummarySettings("", (SummaryType) 1, (string) null, "PrimaryPremium", 5, true, "tblUnderwritingLocationstblPropertyExposure", 1, (SummaryPosition) 3, "PrimaryPremium", 5, true);
    Appearance appearance55 = new Appearance();
    SummarySettings summarySettings2 = new SummarySettings("", (SummaryType) 1, (string) null, "ExcessPremium", 6, true, "tblUnderwritingLocationstblPropertyExposure", 1, (SummaryPosition) 3, "ExcessPremium", 6, true);
    Appearance appearance56 = new Appearance();
    SummarySettings summarySettings3 = new SummarySettings("", (SummaryType) 1, (string) null, "TerrPremium", 7, true, "tblUnderwritingLocationstblPropertyExposure", 1, (SummaryPosition) 3, "TerrPremium", 7, true);
    Appearance appearance57 = new Appearance();
    SummarySettings summarySettings4 = new SummarySettings("", (SummaryType) 1, (string) null, "Limit", 22, true, "tblUnderwritingLocationstblPropertyExposure", 1, (SummaryPosition) 3, "Limit", 22, true);
    Appearance appearance58 = new Appearance();
    SummarySettings summarySettings5 = new SummarySettings("", (SummaryType) 1, (string) null, "TotalNonTerrorPremium", 4, true, "tblUnderwritingLocationstblPropertyExposure", 1, (SummaryPosition) 3, "TotalNonTerrorPremium", 4, true);
    Appearance appearance59 = new Appearance();
    SummarySettings summarySettings6 = new SummarySettings("", (SummaryType) 1, (string) null, "TerrorExcess", 9, true, "tblUnderwritingLocationstblPropertyExposure", 1, (SummaryPosition) 3, "TerrorExcess", 9, true);
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstPropRater_CoverageTypes", -1);
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("Coverage");
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance68 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance69 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance70 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance71 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("ContextMenu");
    ButtonTool buttonTool1 = new ButtonTool("Restore Exposure");
    Appearance appearance72 = new Appearance();
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("ContextMenu");
    ButtonTool buttonTool2 = new ButtonTool("Restore Exposure");
    this.lnkCalcTotalTerrorPremium = new LinkLabel();
    this.numPrimaryRate = new MGANumericEditor();
    this.ds = new dsPropertyRater_Exposure();
    this.numPrimaryTerror = new MGANumericEditor();
    this.numPrimaryPrem = new MGANumericEditor();
    this.lnkCalcExcessTerror = new LinkLabel();
    this.lblExcessTerror = new Label();
    this.numExcessTerror = new MGANumericEditor();
    this.lnkCalculateTotalNonTerror = new LinkLabel();
    this.numTotalNonTerror = new MGANumericEditor();
    this.lnkCalculateExcessRate = new LinkLabel();
    this.numAccountRate = new MGANumericEditor();
    this.lnkCalcTerrRate = new LinkLabel();
    this.chkWaivePremiums = new MGACheckBox();
    this.lnkAddMiscPremiums = new LinkLabel();
    this.lnkCalcAccountRate = new LinkLabel();
    this.lnkCalcExcessPremium = new LinkLabel();
    this.numTerrRate = new MGANumericEditor();
    this.numExcessRate = new MGANumericEditor();
    this.lblExcessRate = new Label();
    this.lblNonTerrorExcess = new Label();
    this.numTerrPrem = new MGANumericEditor();
    this.numExcessPrem = new MGANumericEditor();
    this.lblTotalLocationPremium = new UltraLabel();
    this.linkPolicyExtension = new LinkLabel();
    this.linkIncludeTerrorism = new LinkLabel();
    this.linkDeclineTerrorism = new LinkLabel();
    this.linkModifyFactorMulti = new LinkLabel();
    this.linkUnselectAll = new LinkLabel();
    this.linkSelectAll = new LinkLabel();
    this.linkRestoreExposures = new LinkLabel();
    this.linkDeleteAllSelected = new LinkLabel();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.lnkExportSchedule = new LinkLabel();
    this.txtAdditionalInfo = new MGATextBox();
    this.labelExcessTerror = new Label();
    this.txtOtherDeductibles = new MGATextBox();
    this.cboDeductiblePer = new MGASimpleComboBox();
    this.txtAOPDA = new MGANumericEditor();
    this.cboLossCauses = new MGASimpleComboBox();
    this.cboValuation = new MGASimpleComboBox();
    this.cboCoInsurance = new MGASimpleComboBox();
    this.cboCoverages = new MGASimpleComboBox();
    this.txtCoInsurance = new MGATextBox();
    this.cboClientOffices = new MGASimpleComboBox();
    this.numLimit = new MGANumericEditor();
    this.lnkModifyLocations = new LinkLabel();
    this.lblTotalNonTerrorExcess = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.lblTotalPremium = new Label();
    this.lblTotalTIV = new Label();
    this.lblTotalTerrorism = new Label();
    this.lblTotalNonTerror = new Label();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.lnkModifyFactor = new LinkLabel();
    this.cboCalcType = new MGASimpleComboBox();
    this.lblFactor = new UltraLabel();
    this.lnkEffective = new LinkLabel();
    this.daLocations = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cn = new SqlConnection();
    this.dgLocations = new UltraGrid();
    this.lblOptionID = new Label();
    this.Label11 = new Label();
    this.daLookups = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.daExposure = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand3 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.err = new ErrorProvider(this.components);
    this.ddCoverages = new UltraDropDown();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.ToolTip1 = new ToolTip(this.components);
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    Label label4 = new Label();
    Label label5 = new Label();
    Label label6 = new Label();
    Label label7 = new Label();
    Label label8 = new Label();
    Label label9 = new Label();
    UltraTabPageControl ultraTabPageControl1 = new UltraTabPageControl();
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
    UltraTabPageControl ultraTabPageControl2 = new UltraTabPageControl();
    Label label26 = new Label();
    Label label27 = new Label();
    ((Control) ultraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.numPrimaryRate).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.numPrimaryTerror).BeginInit();
    ((ISupportInitialize) this.numPrimaryPrem).BeginInit();
    ((ISupportInitialize) this.numExcessTerror).BeginInit();
    ((ISupportInitialize) this.numTotalNonTerror).BeginInit();
    ((ISupportInitialize) this.numAccountRate).BeginInit();
    ((ISupportInitialize) this.chkWaivePremiums).BeginInit();
    ((ISupportInitialize) this.numTerrRate).BeginInit();
    ((ISupportInitialize) this.numExcessRate).BeginInit();
    ((ISupportInitialize) this.numTerrPrem).BeginInit();
    ((ISupportInitialize) this.numExcessPrem).BeginInit();
    ((Control) ultraTabPageControl2).SuspendLayout();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.txtAdditionalInfo).BeginInit();
    ((ISupportInitialize) this.txtOtherDeductibles).BeginInit();
    ((ISupportInitialize) this.cboDeductiblePer).BeginInit();
    ((ISupportInitialize) this.txtAOPDA).BeginInit();
    ((ISupportInitialize) this.cboLossCauses).BeginInit();
    ((ISupportInitialize) this.cboValuation).BeginInit();
    ((ISupportInitialize) this.cboCoInsurance).BeginInit();
    ((ISupportInitialize) this.cboCoverages).BeginInit();
    ((ISupportInitialize) this.txtCoInsurance).BeginInit();
    ((ISupportInitialize) this.cboClientOffices).BeginInit();
    ((ISupportInitialize) this.numLimit).BeginInit();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.cboCalcType).BeginInit();
    ((ISupportInitialize) this.dgLocations).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ddCoverages).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    label1.AutoSize = true;
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(391, 20);
    label1.Name = "Label26";
    label1.Size = new Size(72, 13);
    label1.TabIndex = 32 /*0x20*/;
    label1.Text = "Account Rate";
    label1.TextAlign = ContentAlignment.MiddleRight;
    label2.AutoSize = true;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(317, 122);
    label2.Name = "Label23";
    label2.Size = new Size(97, 13);
    label2.TabIndex = 29;
    label2.Text = "Other Deductibles:";
    label2.TextAlign = ContentAlignment.MiddleRight;
    label3.AutoSize = true;
    label3.BackColor = Color.Transparent;
    label3.Location = new Point(354, 87);
    label3.Name = "Label6";
    label3.Size = new Size(61, 13);
    label3.TabIndex = 14;
    label3.Text = "Deductible:";
    label3.TextAlign = ContentAlignment.MiddleRight;
    label4.AutoSize = true;
    label4.BackColor = Color.Transparent;
    label4.Location = new Point(338, 54);
    label4.Name = "Label5";
    label4.Size = new Size(78, 13);
    label4.TabIndex = 12;
    label4.Text = "Cause of Loss:";
    label4.TextAlign = ContentAlignment.MiddleRight;
    label5.AutoSize = true;
    label5.BackColor = Color.Transparent;
    label5.Location = new Point(360, 20);
    label5.Name = "Label4";
    label5.Size = new Size(55, 13);
    label5.TabIndex = 10;
    label5.Text = "Valuation:";
    label5.TextAlign = ContentAlignment.MiddleRight;
    label6.AutoSize = true;
    label6.BackColor = Color.Transparent;
    label6.Location = new Point(10, 122);
    label6.Name = "Label3";
    label6.Size = new Size(72, 13);
    label6.TabIndex = 7;
    label6.Text = "CoInsurance:";
    label6.TextAlign = ContentAlignment.MiddleRight;
    label7.AutoSize = true;
    label7.BackColor = Color.Transparent;
    label7.Location = new Point(50, 54);
    label7.Name = "Label2";
    label7.Size = new Size(32 /*0x20*/, 13);
    label7.TabIndex = 2;
    label7.Text = "Limit:";
    label7.TextAlign = ContentAlignment.MiddleRight;
    label8.AutoSize = true;
    label8.BackColor = Color.Transparent;
    label8.Location = new Point(28, 20);
    label8.Name = "Label1";
    label8.Size = new Size(54, 13);
    label8.TabIndex = 0;
    label8.Text = "Covering:";
    label8.TextAlign = ContentAlignment.MiddleRight;
    label9.AutoSize = true;
    label9.BackColor = Color.Transparent;
    label9.Location = new Point(46, 87);
    label9.Name = "Label13";
    label9.Size = new Size(36, 13);
    label9.TabIndex = 5;
    label9.Text = "Office";
    label9.TextAlign = ContentAlignment.MiddleRight;
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.lnkCalcTotalTerrorPremium);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.numPrimaryRate);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.numPrimaryTerror);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.numPrimaryPrem);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.lnkCalcExcessTerror);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.lblExcessTerror);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.numExcessTerror);
    ((Control) ultraTabPageControl1).Controls.Add((Control) label10);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.lnkCalculateTotalNonTerror);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.numTotalNonTerror);
    ((Control) ultraTabPageControl1).Controls.Add((Control) label11);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.lnkCalculateExcessRate);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.numAccountRate);
    ((Control) ultraTabPageControl1).Controls.Add((Control) label1);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.lnkCalcTerrRate);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.chkWaivePremiums);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.lnkAddMiscPremiums);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.lnkCalcAccountRate);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.lnkCalcExcessPremium);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.numTerrRate);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.numExcessRate);
    ((Control) ultraTabPageControl1).Controls.Add((Control) label12);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.lblExcessRate);
    ((Control) ultraTabPageControl1).Controls.Add((Control) label13);
    ((Control) ultraTabPageControl1).Controls.Add((Control) label14);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.lblNonTerrorExcess);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.numTerrPrem);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.numExcessPrem);
    ((Control) ultraTabPageControl1).Controls.Add((Control) this.lblTotalLocationPremium);
    ((Control) ultraTabPageControl1).Controls.Add((Control) label15);
    ((Control) ultraTabPageControl1).Controls.Add((Control) label16);
    ((Control) ultraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) ultraTabPageControl1).Name = "UltraTabPageControl2";
    ((Control) ultraTabPageControl1).Size = new Size(835, 267);
    this.lnkCalcTotalTerrorPremium.AutoSize = true;
    this.lnkCalcTotalTerrorPremium.BackColor = Color.Transparent;
    this.lnkCalcTotalTerrorPremium.Location = new Point(292, 95);
    this.lnkCalcTotalTerrorPremium.Name = "lnkCalcTotalTerrorPremium";
    this.lnkCalcTotalTerrorPremium.Size = new Size(57, 13);
    this.lnkCalcTotalTerrorPremium.TabIndex = 46;
    this.lnkCalcTotalTerrorPremium.TabStop = true;
    this.lnkCalcTotalTerrorPremium.Text = "(calculate)";
    this.lnkCalcTotalTerrorPremium.TextAlign = ContentAlignment.MiddleCenter;
    this.ToolTip1.SetToolTip((Control) this.lnkCalcTotalTerrorPremium, "Calculate the primary premium based on current limit and rate");
    appearance1.BackColorDisabled = Color.Gainsboro;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numPrimaryRate).Appearance = (AppearanceBase) appearance1;
    ((Control) this.numPrimaryRate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.PrimaryRate", true));
    ((Control) this.numPrimaryRate).Enabled = false;
    ((Control) this.numPrimaryRate).Location = new Point(489, 41);
    this.numPrimaryRate.MaskInput = "nn.nnnn";
    this.numPrimaryRate.MaxValue = (object) 99.9999;
    this.numPrimaryRate.MGAStyle = MGAStyles.Blue;
    this.numPrimaryRate.MinValue = (object) 0;
    ((Control) this.numPrimaryRate).Name = "numPrimaryRate";
    this.numPrimaryRate.Nullable = true;
    this.numPrimaryRate.NumericType = (NumericType) 1;
    ((Control) this.numPrimaryRate).Size = new Size(72, 20);
    ((Control) this.numPrimaryRate).TabIndex = 45;
    ((UltraWinEditorMaskedControlBase) this.numPrimaryRate).TabNavigation = (MaskedEditTabNavigation) 0;
    ((Control) this.numPrimaryRate).Tag = (object) "KeepDisabled";
    ((UltraControlBase) this.numPrimaryRate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numPrimaryRate).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsPropertyRater_Exposure";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance2.BackColorDisabled = Color.Gainsboro;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numPrimaryTerror).Appearance = (AppearanceBase) appearance2;
    ((Control) this.numPrimaryTerror).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.TerrorPrimary", true));
    ((Control) this.numPrimaryTerror).Enabled = false;
    ((UltraNumericEditorBase) this.numPrimaryTerror).FormatString = "c";
    ((Control) this.numPrimaryTerror).Location = new Point(172, 117);
    this.numPrimaryTerror.MaxValue = (object) 999999999;
    this.numPrimaryTerror.MGAStyle = MGAStyles.Blue;
    this.numPrimaryTerror.MinValue = (object) -999999999;
    ((Control) this.numPrimaryTerror).Name = "numPrimaryTerror";
    this.numPrimaryTerror.Nullable = true;
    this.numPrimaryTerror.NumericType = (NumericType) 1;
    ((Control) this.numPrimaryTerror).Size = new Size(116, 20);
    ((Control) this.numPrimaryTerror).TabIndex = 44;
    ((UltraWinEditorMaskedControlBase) this.numPrimaryTerror).TabNavigation = (MaskedEditTabNavigation) 0;
    ((Control) this.numPrimaryTerror).Tag = (object) "KeepDisabled";
    ((UltraControlBase) this.numPrimaryTerror).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numPrimaryTerror).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BackColorDisabled = Color.Gainsboro;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numPrimaryPrem).Appearance = (AppearanceBase) appearance3;
    ((Control) this.numPrimaryPrem).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.PrimaryPremium", true));
    ((Control) this.numPrimaryPrem).Enabled = false;
    ((UltraNumericEditorBase) this.numPrimaryPrem).FormatString = "c";
    ((Control) this.numPrimaryPrem).Location = new Point(172, 41);
    this.numPrimaryPrem.MaxValue = (object) 999999999;
    this.numPrimaryPrem.MGAStyle = MGAStyles.Blue;
    this.numPrimaryPrem.MinValue = (object) -999999999;
    ((Control) this.numPrimaryPrem).Name = "numPrimaryPrem";
    this.numPrimaryPrem.Nullable = true;
    this.numPrimaryPrem.NumericType = (NumericType) 1;
    ((Control) this.numPrimaryPrem).Size = new Size(116, 20);
    ((Control) this.numPrimaryPrem).TabIndex = 43;
    ((UltraWinEditorMaskedControlBase) this.numPrimaryPrem).TabNavigation = (MaskedEditTabNavigation) 0;
    ((Control) this.numPrimaryPrem).Tag = (object) "KeepDisabled";
    ((UltraControlBase) this.numPrimaryPrem).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numPrimaryPrem).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkCalcExcessTerror.AutoSize = true;
    this.lnkCalcExcessTerror.BackColor = Color.Transparent;
    this.lnkCalcExcessTerror.Location = new Point(292, 145);
    this.lnkCalcExcessTerror.Name = "lnkCalcExcessTerror";
    this.lnkCalcExcessTerror.Size = new Size(57, 13);
    this.lnkCalcExcessTerror.TabIndex = 42;
    this.lnkCalcExcessTerror.TabStop = true;
    this.lnkCalcExcessTerror.Text = "(calculate)";
    this.lnkCalcExcessTerror.TextAlign = ContentAlignment.MiddleCenter;
    this.ToolTip1.SetToolTip((Control) this.lnkCalcExcessTerror, "Calculate the primary premium based on current limit and rate");
    this.lblExcessTerror.AutoSize = true;
    this.lblExcessTerror.BackColor = Color.Transparent;
    this.lblExcessTerror.Location = new Point(81, 145);
    this.lblExcessTerror.Name = "lblExcessTerror";
    this.lblExcessTerror.Size = new Size(40, 13);
    this.lblExcessTerror.TabIndex = 40;
    this.lblExcessTerror.Text = "Excess";
    this.lblExcessTerror.TextAlign = ContentAlignment.MiddleRight;
    appearance4.BackColorDisabled = Color.Gainsboro;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numExcessTerror).Appearance = (AppearanceBase) appearance4;
    ((Control) this.numExcessTerror).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.TerrorExcess", true));
    ((UltraNumericEditorBase) this.numExcessTerror).FormatString = "c";
    ((Control) this.numExcessTerror).Location = new Point(172, 141);
    this.numExcessTerror.MaxValue = (object) 999999999;
    this.numExcessTerror.MGAStyle = MGAStyles.Blue;
    this.numExcessTerror.MinValue = (object) -999999999;
    ((Control) this.numExcessTerror).Name = "numExcessTerror";
    this.numExcessTerror.Nullable = true;
    this.numExcessTerror.NumericType = (NumericType) 1;
    ((Control) this.numExcessTerror).Size = new Size(116, 20);
    ((Control) this.numExcessTerror).TabIndex = 41;
    ((UltraWinEditorMaskedControlBase) this.numExcessTerror).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numExcessTerror).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numExcessTerror).UseOsThemes = (DefaultableBoolean) 2;
    label10.AutoSize = true;
    label10.BackColor = Color.Transparent;
    label10.Location = new Point(81, 121);
    label10.Name = "Label29";
    label10.Size = new Size(43, 13);
    label10.TabIndex = 38;
    label10.Text = "Primary";
    label10.TextAlign = ContentAlignment.MiddleRight;
    this.lnkCalculateTotalNonTerror.AutoSize = true;
    this.lnkCalculateTotalNonTerror.BackColor = Color.Transparent;
    this.lnkCalculateTotalNonTerror.Location = new Point(292, 20);
    this.lnkCalculateTotalNonTerror.Name = "lnkCalculateTotalNonTerror";
    this.lnkCalculateTotalNonTerror.Size = new Size(57, 13);
    this.lnkCalculateTotalNonTerror.TabIndex = 37;
    this.lnkCalculateTotalNonTerror.TabStop = true;
    this.lnkCalculateTotalNonTerror.Text = "(calculate)";
    this.lnkCalculateTotalNonTerror.TextAlign = ContentAlignment.MiddleCenter;
    this.ToolTip1.SetToolTip((Control) this.lnkCalculateTotalNonTerror, "Calculate the primary premium based on current limit and rate");
    appearance5.BackColorDisabled = Color.Gainsboro;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numTotalNonTerror).Appearance = (AppearanceBase) appearance5;
    ((Control) this.numTotalNonTerror).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.TotalNonTerrorPremium", true));
    ((UltraNumericEditorBase) this.numTotalNonTerror).FormatString = "c";
    ((Control) this.numTotalNonTerror).Location = new Point(172, 16 /*0x10*/);
    this.numTotalNonTerror.MaxValue = (object) 999999999;
    this.numTotalNonTerror.MGAStyle = MGAStyles.Blue;
    this.numTotalNonTerror.MinValue = (object) -999999999;
    ((Control) this.numTotalNonTerror).Name = "numTotalNonTerror";
    this.numTotalNonTerror.Nullable = true;
    this.numTotalNonTerror.NumericType = (NumericType) 1;
    ((Control) this.numTotalNonTerror).Size = new Size(116, 20);
    ((Control) this.numTotalNonTerror).TabIndex = 36;
    ((UltraWinEditorMaskedControlBase) this.numTotalNonTerror).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numTotalNonTerror).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numTotalNonTerror).UseOsThemes = (DefaultableBoolean) 2;
    label11.AutoSize = true;
    label11.BackColor = Color.Transparent;
    label11.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    label11.Location = new Point(11, 20);
    label11.Name = "Label27";
    label11.Size = new Size(155, 13);
    label11.TabIndex = 35;
    label11.Text = "Total Non-Terror Premium";
    label11.TextAlign = ContentAlignment.MiddleRight;
    this.lnkCalculateExcessRate.AutoSize = true;
    this.lnkCalculateExcessRate.BackColor = Color.Transparent;
    this.lnkCalculateExcessRate.Location = new Point(567, 69);
    this.lnkCalculateExcessRate.Name = "lnkCalculateExcessRate";
    this.lnkCalculateExcessRate.Size = new Size(57, 13);
    this.lnkCalculateExcessRate.TabIndex = 34;
    this.lnkCalculateExcessRate.TabStop = true;
    this.lnkCalculateExcessRate.Text = "(calculate)";
    this.lnkCalculateExcessRate.TextAlign = ContentAlignment.MiddleCenter;
    this.ToolTip1.SetToolTip((Control) this.lnkCalculateExcessRate, "Calculate the primary premium based on current limit and rate");
    appearance6.BackColorDisabled = Color.Gainsboro;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numAccountRate).Appearance = (AppearanceBase) appearance6;
    ((Control) this.numAccountRate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.AccountRate", true));
    ((Control) this.numAccountRate).Location = new Point(489, 16 /*0x10*/);
    this.numAccountRate.MaskInput = "nn.nnnn";
    this.numAccountRate.MaxValue = (object) 99.9999;
    this.numAccountRate.MGAStyle = MGAStyles.Blue;
    this.numAccountRate.MinValue = (object) 0;
    ((Control) this.numAccountRate).Name = "numAccountRate";
    this.numAccountRate.Nullable = true;
    this.numAccountRate.NumericType = (NumericType) 1;
    ((Control) this.numAccountRate).Size = new Size(72, 20);
    ((Control) this.numAccountRate).TabIndex = 33;
    ((UltraWinEditorMaskedControlBase) this.numAccountRate).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numAccountRate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numAccountRate).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkCalcTerrRate.AutoSize = true;
    this.lnkCalcTerrRate.BackColor = Color.Transparent;
    this.lnkCalcTerrRate.Location = new Point(567, 95);
    this.lnkCalcTerrRate.Name = "lnkCalcTerrRate";
    this.lnkCalcTerrRate.Size = new Size(57, 13);
    this.lnkCalcTerrRate.TabIndex = 31 /*0x1F*/;
    this.lnkCalcTerrRate.TabStop = true;
    this.lnkCalcTerrRate.Text = "(calculate)";
    this.lnkCalcTerrRate.TextAlign = ContentAlignment.MiddleCenter;
    this.ToolTip1.SetToolTip((Control) this.lnkCalcTerrRate, "Calculate the primary premium based on current limit and rate");
    appearance7.BorderColor = Color.Gray;
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkWaivePremiums).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.chkWaivePremiums).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkWaivePremiums).BackColorInternal = Color.Transparent;
    ((Control) this.chkWaivePremiums).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblPropertyExposure.PremiumsWaived", true));
    ((UltraToggleEditorBase) this.chkWaivePremiums).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkWaivePremiums).Location = new Point(489, 117);
    ((Control) this.chkWaivePremiums).Name = "chkWaivePremiums";
    ((Control) this.chkWaivePremiums).Size = new Size(120, 20);
    ((Control) this.chkWaivePremiums).TabIndex = 29;
    ((UltraToggleEditorBase) this.chkWaivePremiums).Text = "Waive Premiums";
    ((UltraControlBase) this.chkWaivePremiums).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkWaivePremiums).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkAddMiscPremiums.AutoSize = true;
    this.lnkAddMiscPremiums.BackColor = Color.Transparent;
    this.lnkAddMiscPremiums.Location = new Point(486, 145);
    this.lnkAddMiscPremiums.Name = "lnkAddMiscPremiums";
    this.lnkAddMiscPremiums.Size = new Size(101, 13);
    this.lnkAddMiscPremiums.TabIndex = 28;
    this.lnkAddMiscPremiums.TabStop = true;
    this.lnkAddMiscPremiums.Text = "Add Misc. Premiums";
    this.lnkAddMiscPremiums.TextAlign = ContentAlignment.MiddleCenter;
    this.ToolTip1.SetToolTip((Control) this.lnkAddMiscPremiums, "Calculate the primary premium based on current limit and rate");
    this.lnkCalcAccountRate.AutoSize = true;
    this.lnkCalcAccountRate.BackColor = Color.Transparent;
    this.lnkCalcAccountRate.Location = new Point(567, 20);
    this.lnkCalcAccountRate.Name = "lnkCalcAccountRate";
    this.lnkCalcAccountRate.Size = new Size(57, 13);
    this.lnkCalcAccountRate.TabIndex = 11;
    this.lnkCalcAccountRate.TabStop = true;
    this.lnkCalcAccountRate.Text = "(calculate)";
    this.lnkCalcAccountRate.TextAlign = ContentAlignment.MiddleCenter;
    this.lnkCalcExcessPremium.AutoSize = true;
    this.lnkCalcExcessPremium.BackColor = Color.Transparent;
    this.lnkCalcExcessPremium.Location = new Point(292, 69);
    this.lnkCalcExcessPremium.Name = "lnkCalcExcessPremium";
    this.lnkCalcExcessPremium.Size = new Size(57, 13);
    this.lnkCalcExcessPremium.TabIndex = 2;
    this.lnkCalcExcessPremium.TabStop = true;
    this.lnkCalcExcessPremium.Text = "(calculate)";
    this.lnkCalcExcessPremium.TextAlign = ContentAlignment.MiddleCenter;
    this.ToolTip1.SetToolTip((Control) this.lnkCalcExcessPremium, "Calculate the primary premium based on current limit and rate");
    appearance8.BackColorDisabled = Color.Gainsboro;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numTerrRate).Appearance = (AppearanceBase) appearance8;
    ((Control) this.numTerrRate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.TerrRate", true));
    ((Control) this.numTerrRate).Location = new Point(489, 91);
    this.numTerrRate.MaskInput = "nn.nnnn";
    this.numTerrRate.MaxValue = (object) 99.9999;
    this.numTerrRate.MGAStyle = MGAStyles.Blue;
    this.numTerrRate.MinValue = (object) 0;
    ((Control) this.numTerrRate).Name = "numTerrRate";
    this.numTerrRate.Nullable = true;
    this.numTerrRate.NumericType = (NumericType) 1;
    ((Control) this.numTerrRate).Size = new Size(72, 20);
    ((Control) this.numTerrRate).TabIndex = 15;
    ((UltraWinEditorMaskedControlBase) this.numTerrRate).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numTerrRate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numTerrRate).UseOsThemes = (DefaultableBoolean) 2;
    appearance9.BackColorDisabled = Color.Gainsboro;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numExcessRate).Appearance = (AppearanceBase) appearance9;
    ((Control) this.numExcessRate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.ExcessRate", true));
    ((Control) this.numExcessRate).Location = new Point(489, 65);
    this.numExcessRate.MaskInput = "nn.nnnn";
    this.numExcessRate.MaxValue = (object) 99.9999;
    this.numExcessRate.MGAStyle = MGAStyles.Blue;
    this.numExcessRate.MinValue = (object) 0;
    ((Control) this.numExcessRate).Name = "numExcessRate";
    this.numExcessRate.Nullable = true;
    this.numExcessRate.NumericType = (NumericType) 1;
    ((Control) this.numExcessRate).Size = new Size(72, 20);
    ((Control) this.numExcessRate).TabIndex = 13;
    ((UltraWinEditorMaskedControlBase) this.numExcessRate).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numExcessRate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numExcessRate).UseOsThemes = (DefaultableBoolean) 2;
    label12.AutoSize = true;
    label12.BackColor = Color.Transparent;
    label12.Location = new Point(391, 95);
    label12.Name = "Label7";
    label12.Size = new Size(78, 13);
    label12.TabIndex = 14;
    label12.Text = "Terrorism Rate";
    label12.TextAlign = ContentAlignment.MiddleRight;
    this.lblExcessRate.AutoSize = true;
    this.lblExcessRate.BackColor = Color.Transparent;
    this.lblExcessRate.Location = new Point(391, 69);
    this.lblExcessRate.Name = "lblExcessRate";
    this.lblExcessRate.Size = new Size(66, 13);
    this.lblExcessRate.TabIndex = 12;
    this.lblExcessRate.Text = "Excess Rate";
    this.lblExcessRate.TextAlign = ContentAlignment.MiddleRight;
    label13.AutoSize = true;
    label13.BackColor = Color.Transparent;
    label13.Location = new Point(391, 45);
    label13.Name = "Label18";
    label13.Size = new Size(69, 13);
    label13.TabIndex = 9;
    label13.Text = "Primary Rate";
    label13.TextAlign = ContentAlignment.MiddleRight;
    label14.AutoSize = true;
    label14.BackColor = Color.Transparent;
    label14.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    label14.Location = new Point(40, 95);
    label14.Name = "Label10";
    label14.Size = new Size(129, 13);
    label14.TabIndex = 5;
    label14.Text = "Total Terror Premium";
    label14.TextAlign = ContentAlignment.MiddleRight;
    this.lblNonTerrorExcess.AutoSize = true;
    this.lblNonTerrorExcess.BackColor = Color.Transparent;
    this.lblNonTerrorExcess.Location = new Point(81, 69);
    this.lblNonTerrorExcess.Name = "lblNonTerrorExcess";
    this.lblNonTerrorExcess.Size = new Size(40, 13);
    this.lblNonTerrorExcess.TabIndex = 3;
    this.lblNonTerrorExcess.Text = "Excess";
    this.lblNonTerrorExcess.TextAlign = ContentAlignment.MiddleRight;
    appearance10.BackColorDisabled = Color.Gainsboro;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numTerrPrem).Appearance = (AppearanceBase) appearance10;
    ((Control) this.numTerrPrem).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.TerrPremium", true));
    ((UltraNumericEditorBase) this.numTerrPrem).FormatString = "c";
    ((Control) this.numTerrPrem).Location = new Point(172, 91);
    this.numTerrPrem.MaxValue = (object) 999999999;
    this.numTerrPrem.MGAStyle = MGAStyles.Blue;
    this.numTerrPrem.MinValue = (object) -999999999;
    ((Control) this.numTerrPrem).Name = "numTerrPrem";
    this.numTerrPrem.Nullable = true;
    this.numTerrPrem.NumericType = (NumericType) 1;
    ((Control) this.numTerrPrem).Size = new Size(116, 20);
    ((Control) this.numTerrPrem).TabIndex = 6;
    ((UltraWinEditorMaskedControlBase) this.numTerrPrem).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numTerrPrem).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numTerrPrem).UseOsThemes = (DefaultableBoolean) 2;
    appearance11.BackColorDisabled = Color.Gainsboro;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numExcessPrem).Appearance = (AppearanceBase) appearance11;
    ((Control) this.numExcessPrem).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.ExcessPremium", true));
    ((UltraNumericEditorBase) this.numExcessPrem).FormatString = "c";
    ((Control) this.numExcessPrem).Location = new Point(172, 65);
    this.numExcessPrem.MaxValue = (object) 999999999;
    this.numExcessPrem.MGAStyle = MGAStyles.Blue;
    this.numExcessPrem.MinValue = (object) -999999999;
    ((Control) this.numExcessPrem).Name = "numExcessPrem";
    this.numExcessPrem.Nullable = true;
    this.numExcessPrem.NumericType = (NumericType) 1;
    ((Control) this.numExcessPrem).Size = new Size(116, 20);
    ((Control) this.numExcessPrem).TabIndex = 4;
    ((UltraWinEditorMaskedControlBase) this.numExcessPrem).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numExcessPrem).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numExcessPrem).UseOsThemes = (DefaultableBoolean) 2;
    appearance12.BackColor = Color.Transparent;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ((AppearanceBase) appearance12).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblTotalLocationPremium).Appearance = (AppearanceBase) appearance12;
    ((ControlBase) this.lblTotalLocationPremium).BackColorInternal = Color.WhiteSmoke;
    this.lblTotalLocationPremium.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblTotalLocationPremium).Location = new Point(172, 167);
    ((Control) this.lblTotalLocationPremium).Name = "lblTotalLocationPremium";
    ((Control) this.lblTotalLocationPremium).Size = new Size(116, 21);
    ((Control) this.lblTotalLocationPremium).TabIndex = 8;
    ((ControlBase) this.lblTotalLocationPremium).WrapText = false;
    label15.AutoSize = true;
    label15.BackColor = Color.Transparent;
    label15.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    label15.Location = new Point(18, 171);
    label15.Name = "Label12";
    label15.Size = new Size(145, 13);
    label15.TabIndex = 7;
    label15.Text = "Total Exposure Premium";
    label15.TextAlign = ContentAlignment.MiddleRight;
    label16.AutoSize = true;
    label16.BackColor = Color.Transparent;
    label16.Location = new Point(81, 45);
    label16.Name = "Label8";
    label16.Size = new Size(43, 13);
    label16.TabIndex = 0;
    label16.Text = "Primary";
    label16.TextAlign = ContentAlignment.MiddleRight;
    label17.AutoSize = true;
    label17.BackColor = Color.Transparent;
    label17.Font = new Font("Tahoma", 8.25f, FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    label17.Location = new Point(12, 203);
    label17.Name = "Label25";
    label17.Size = new Size(112 /*0x70*/, 13);
    label17.TabIndex = 38;
    label17.Text = "Totals For This Option";
    label17.TextAlign = ContentAlignment.MiddleRight;
    label18.AutoSize = true;
    label18.BackColor = Color.Transparent;
    label18.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    label18.Location = new Point(332, 229);
    label18.Name = "Label21";
    label18.Size = new Size(93, 13);
    label18.TabIndex = 36;
    label18.Text = "Total Premium:";
    label18.TextAlign = ContentAlignment.MiddleRight;
    label19.AutoSize = true;
    label19.BackColor = Color.Transparent;
    label19.Location = new Point(39, 229);
    label19.Name = "Label19";
    label19.Size = new Size(27, 13);
    label19.TabIndex = 28;
    label19.Text = "TIV:";
    label19.TextAlign = ContentAlignment.MiddleRight;
    label20.AutoSize = true;
    label20.BackColor = Color.Transparent;
    label20.Location = new Point(12, 245);
    label20.Name = "Label20";
    label20.Size = new Size(54, 13);
    label20.TabIndex = 30;
    label20.Text = "Non-Terr:";
    label20.TextAlign = ContentAlignment.MiddleRight;
    label21.AutoSize = true;
    label21.BackColor = Color.Transparent;
    label21.Location = new Point(196, 229);
    label21.Name = "Label22";
    label21.Size = new Size(44, 13);
    label21.TabIndex = 32 /*0x20*/;
    label21.Text = "Excess:";
    label21.TextAlign = ContentAlignment.MiddleRight;
    label22.AutoSize = true;
    label22.BackColor = Color.Transparent;
    label22.Location = new Point(184, 245);
    label22.Name = "Label24";
    label22.Size = new Size(56, 13);
    label22.TabIndex = 34;
    label22.Text = "Terrorism:";
    label22.TextAlign = ContentAlignment.MiddleRight;
    label23.AutoSize = true;
    label23.BackColor = Color.Transparent;
    label23.Location = new Point(16 /*0x10*/, 18);
    label23.Name = "Label15";
    label23.Size = new Size(58, 13);
    label23.TabIndex = 0;
    label23.Text = "Calc Type:";
    label23.TextAlign = ContentAlignment.MiddleRight;
    label24.AutoSize = true;
    label24.BackColor = Color.Transparent;
    label24.Location = new Point(38, 50);
    label24.Name = "Label16";
    label24.Size = new Size(38, 13);
    label24.TabIndex = 2;
    label24.Text = "Factor";
    label24.TextAlign = ContentAlignment.MiddleRight;
    label25.AutoSize = true;
    label25.BackColor = Color.Transparent;
    label25.Location = new Point(26, 80 /*0x50*/);
    label25.Name = "Label17";
    label25.Size = new Size(50, 13);
    label25.TabIndex = 4;
    label25.Text = "Effective";
    label25.TextAlign = ContentAlignment.MiddleRight;
    ((Control) ultraTabPageControl2).Controls.Add((Control) this.linkPolicyExtension);
    ((Control) ultraTabPageControl2).Controls.Add((Control) this.linkIncludeTerrorism);
    ((Control) ultraTabPageControl2).Controls.Add((Control) this.linkDeclineTerrorism);
    ((Control) ultraTabPageControl2).Controls.Add((Control) this.linkModifyFactorMulti);
    ((Control) ultraTabPageControl2).Controls.Add((Control) this.linkUnselectAll);
    ((Control) ultraTabPageControl2).Controls.Add((Control) this.linkSelectAll);
    ((Control) ultraTabPageControl2).Controls.Add((Control) this.linkRestoreExposures);
    ((Control) ultraTabPageControl2).Controls.Add((Control) this.linkDeleteAllSelected);
    ((Control) ultraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) ultraTabPageControl2).Name = "tabMultiOperations";
    ((Control) ultraTabPageControl2).Size = new Size(835, 267);
    this.linkPolicyExtension.AutoSize = true;
    this.linkPolicyExtension.BackColor = Color.Transparent;
    this.linkPolicyExtension.Location = new Point(299, 75);
    this.linkPolicyExtension.Name = "linkPolicyExtension";
    this.linkPolicyExtension.Size = new Size(84, 13);
    this.linkPolicyExtension.TabIndex = 47;
    this.linkPolicyExtension.TabStop = true;
    this.linkPolicyExtension.Text = "Policy Extension";
    this.linkPolicyExtension.TextAlign = ContentAlignment.MiddleLeft;
    this.linkIncludeTerrorism.AutoSize = true;
    this.linkIncludeTerrorism.BackColor = Color.Transparent;
    this.linkIncludeTerrorism.Location = new Point(12, (int) sbyte.MaxValue);
    this.linkIncludeTerrorism.Name = "linkIncludeTerrorism";
    this.linkIncludeTerrorism.Size = new Size(168, 13);
    this.linkIncludeTerrorism.TabIndex = 46;
    this.linkIncludeTerrorism.TabStop = true;
    this.linkIncludeTerrorism.Text = "Include Terrorism (TRIA) Premium";
    this.linkIncludeTerrorism.TextAlign = ContentAlignment.MiddleLeft;
    this.linkDeclineTerrorism.AutoSize = true;
    this.linkDeclineTerrorism.BackColor = Color.Transparent;
    this.linkDeclineTerrorism.Location = new Point(12, 101);
    this.linkDeclineTerrorism.Name = "linkDeclineTerrorism";
    this.linkDeclineTerrorism.Size = new Size(167, 13);
    this.linkDeclineTerrorism.TabIndex = 45;
    this.linkDeclineTerrorism.TabStop = true;
    this.linkDeclineTerrorism.Text = "Decline Terrorism (TRIA) Premium";
    this.linkDeclineTerrorism.TextAlign = ContentAlignment.MiddleLeft;
    this.linkModifyFactorMulti.AutoSize = true;
    this.linkModifyFactorMulti.BackColor = Color.Transparent;
    this.linkModifyFactorMulti.Location = new Point(12, 75);
    this.linkModifyFactorMulti.Name = "linkModifyFactorMulti";
    this.linkModifyFactorMulti.Size = new Size(251, 13);
    this.linkModifyFactorMulti.TabIndex = 44;
    this.linkModifyFactorMulti.TabStop = true;
    this.linkModifyFactorMulti.Text = "Modify Endorsement Factor on Selected Exposures";
    this.linkModifyFactorMulti.TextAlign = ContentAlignment.MiddleLeft;
    this.linkUnselectAll.AutoSize = true;
    this.linkUnselectAll.BackColor = Color.Transparent;
    this.linkUnselectAll.Location = new Point(299, 50);
    this.linkUnselectAll.Name = "linkUnselectAll";
    this.linkUnselectAll.Size = new Size(118, 13);
    this.linkUnselectAll.TabIndex = 43;
    this.linkUnselectAll.TabStop = true;
    this.linkUnselectAll.Text = "Un-select all exposures";
    this.linkUnselectAll.TextAlign = ContentAlignment.MiddleLeft;
    this.linkSelectAll.AutoSize = true;
    this.linkSelectAll.BackColor = Color.Transparent;
    this.linkSelectAll.Location = new Point(299, 23);
    this.linkSelectAll.Name = "linkSelectAll";
    this.linkSelectAll.Size = new Size(103, 13);
    this.linkSelectAll.TabIndex = 42;
    this.linkSelectAll.TabStop = true;
    this.linkSelectAll.Text = "Select All Exposures";
    this.linkSelectAll.TextAlign = ContentAlignment.MiddleLeft;
    this.linkRestoreExposures.AutoSize = true;
    this.linkRestoreExposures.BackColor = Color.Transparent;
    this.linkRestoreExposures.Location = new Point(12, 49);
    this.linkRestoreExposures.Name = "linkRestoreExposures";
    this.linkRestoreExposures.Size = new Size(156, 13);
    this.linkRestoreExposures.TabIndex = 41;
    this.linkRestoreExposures.TabStop = true;
    this.linkRestoreExposures.Text = "Restore All Selected Exposures";
    this.linkRestoreExposures.TextAlign = ContentAlignment.MiddleLeft;
    this.linkDeleteAllSelected.AutoSize = true;
    this.linkDeleteAllSelected.BackColor = Color.Transparent;
    this.linkDeleteAllSelected.Location = new Point(12, 23);
    this.linkDeleteAllSelected.Name = "linkDeleteAllSelected";
    this.linkDeleteAllSelected.Size = new Size(149, 13);
    this.linkDeleteAllSelected.TabIndex = 40;
    this.linkDeleteAllSelected.TabStop = true;
    this.linkDeleteAllSelected.Text = "Delete All Selected Exposures";
    this.linkDeleteAllSelected.TextAlign = ContentAlignment.MiddleLeft;
    label26.AutoSize = true;
    label26.BackColor = Color.Transparent;
    label26.Location = new Point(332, 245);
    label26.Name = "Label31";
    label26.Size = new Size(67, 13);
    label26.TabIndex = 40;
    label26.Text = "Excess Terr:";
    label26.TextAlign = ContentAlignment.MiddleRight;
    label27.AutoSize = true;
    label27.BackColor = Color.Transparent;
    label27.Location = new Point(22, 153);
    label27.Name = "Label30";
    label27.Size = new Size(60, 13);
    label27.TabIndex = 43;
    label27.Text = "Add' l Info:";
    label27.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkExportSchedule);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label27);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtAdditionalInfo);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.labelExcessTerror);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label26);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtOtherDeductibles);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboDeductiblePer);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtAOPDA);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label5);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label6);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label7);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label8);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboLossCauses);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboValuation);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboCoInsurance);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboCoverages);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label9);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtCoInsurance);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboClientOffices);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.numLimit);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkModifyLocations);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label17);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label18);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblTotalNonTerrorExcess);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label19);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblTotalPremium);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblTotalTIV);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblTotalTerrorism);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblTotalNonTerror);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label20);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label21);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label22);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(835, 267);
    this.lnkExportSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lnkExportSchedule.AutoSize = true;
    this.lnkExportSchedule.BackColor = Color.Transparent;
    this.lnkExportSchedule.Location = new Point(729, 171);
    this.lnkExportSchedule.Name = "lnkExportSchedule";
    this.lnkExportSchedule.Size = new Size(85, 13);
    this.lnkExportSchedule.TabIndex = 16 /*0x10*/;
    this.lnkExportSchedule.TabStop = true;
    this.lnkExportSchedule.Tag = (object) "keepAlive";
    this.lnkExportSchedule.Text = "Export Schedule";
    this.lnkExportSchedule.TextAlign = ContentAlignment.MiddleCenter;
    this.txtAdditionalInfo.AcceptsReturn = true;
    this.txtAdditionalInfo.AcceptsTab = true;
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAdditionalInfo).Appearance = (AppearanceBase) appearance13;
    ((TextEditorControlBase) this.txtAdditionalInfo).BackColor = Color.White;
    ((Control) this.txtAdditionalInfo).DataBindings.Add(new Binding("Text", (object) this.ds, "tblPropertyExposure.AdditionalInfo", true));
    ((Control) this.txtAdditionalInfo).Location = new Point(88, 153);
    ((TextEditorControlBase) this.txtAdditionalInfo).MaxLength = 2500;
    this.txtAdditionalInfo.MGAStyle = MGAStyles.Blue;
    this.txtAdditionalInfo.Multiline = true;
    ((Control) this.txtAdditionalInfo).Name = "txtAdditionalInfo";
    ((Control) this.txtAdditionalInfo).Size = new Size(219, 47);
    ((Control) this.txtAdditionalInfo).TabIndex = 42;
    ((UltraControlBase) this.txtAdditionalInfo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAdditionalInfo).UseOsThemes = (DefaultableBoolean) 2;
    this.labelExcessTerror.BackColor = Color.Transparent;
    this.labelExcessTerror.Location = new Point(431, 243);
    this.labelExcessTerror.Name = "labelExcessTerror";
    this.labelExcessTerror.Size = new Size(80 /*0x50*/, 17);
    this.labelExcessTerror.TabIndex = 41;
    this.labelExcessTerror.Text = "$0.00";
    this.labelExcessTerror.TextAlign = ContentAlignment.MiddleLeft;
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtOtherDeductibles).Appearance = (AppearanceBase) appearance14;
    ((TextEditorControlBase) this.txtOtherDeductibles).BackColor = Color.White;
    ((Control) this.txtOtherDeductibles).DataBindings.Add(new Binding("Text", (object) this.ds, "tblPropertyExposure.OtherDeductibles", true));
    ((Control) this.txtOtherDeductibles).Location = new Point(424, 118);
    this.txtOtherDeductibles.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtOtherDeductibles).Name = "txtOtherDeductibles";
    ((Control) this.txtOtherDeductibles).Size = new Size(390, 20);
    ((Control) this.txtOtherDeductibles).TabIndex = 30;
    ((UltraControlBase) this.txtOtherDeductibles).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtOtherDeductibles).UseOsThemes = (DefaultableBoolean) 2;
    this.cboDeductiblePer.BorderStyle = (UIElementBorderStyle) 4;
    this.cboDeductiblePer.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboDeductiblePer).DropDownWidth = 300;
    ((Control) this.cboDeductiblePer).Location = new Point(568, 83);
    this.cboDeductiblePer.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDeductiblePer).Name = "cboDeductiblePer";
    ((Control) this.cboDeductiblePer).Size = new Size(246, 21);
    ((Control) this.cboDeductiblePer).TabIndex = 20;
    ((UltraControlBase) this.cboDeductiblePer).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDeductiblePer).UseOsThemes = (DefaultableBoolean) 2;
    appearance15.BackColorDisabled = Color.Gainsboro;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtAOPDA).Appearance = (AppearanceBase) appearance15;
    ((Control) this.txtAOPDA).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.Deductible", true));
    ((UltraNumericEditorBase) this.txtAOPDA).FormatString = "c";
    ((Control) this.txtAOPDA).Location = new Point(424, 83);
    this.txtAOPDA.MGAStyle = MGAStyles.Blue;
    this.txtAOPDA.MinValue = (object) 0;
    ((Control) this.txtAOPDA).Name = "txtAOPDA";
    this.txtAOPDA.Nullable = true;
    ((Control) this.txtAOPDA).Size = new Size(136, 20);
    ((Control) this.txtAOPDA).TabIndex = 18;
    ((UltraControlBase) this.txtAOPDA).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAOPDA).UseOsThemes = (DefaultableBoolean) 2;
    this.cboLossCauses.BorderStyle = (UIElementBorderStyle) 4;
    this.cboLossCauses.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLossCauses).DropDownWidth = 550;
    ((Control) this.cboLossCauses).Location = new Point(424, 50);
    this.cboLossCauses.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLossCauses).Name = "cboLossCauses";
    ((Control) this.cboLossCauses).Size = new Size(390, 21);
    ((Control) this.cboLossCauses).TabIndex = 13;
    ((UltraControlBase) this.cboLossCauses).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLossCauses).UseOsThemes = (DefaultableBoolean) 2;
    this.cboValuation.BorderStyle = (UIElementBorderStyle) 4;
    this.cboValuation.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboValuation).DropDownWidth = 300;
    ((Control) this.cboValuation).Location = new Point(424, 16 /*0x10*/);
    this.cboValuation.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboValuation).Name = "cboValuation";
    ((Control) this.cboValuation).Size = new Size(136, 21);
    ((Control) this.cboValuation).TabIndex = 11;
    ((UltraControlBase) this.cboValuation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboValuation).UseOsThemes = (DefaultableBoolean) 2;
    this.cboCoInsurance.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCoInsurance.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCoInsurance).DropDownWidth = 300;
    ((Control) this.cboCoInsurance).Location = new Point(88, 117);
    this.cboCoInsurance.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCoInsurance).Name = "cboCoInsurance";
    ((Control) this.cboCoInsurance).Size = new Size(136, 21);
    ((Control) this.cboCoInsurance).TabIndex = 8;
    ((UltraControlBase) this.cboCoInsurance).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCoInsurance).UseOsThemes = (DefaultableBoolean) 2;
    this.cboCoverages.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCoverages.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCoverages).DropDownWidth = 300;
    ((Control) this.cboCoverages).Location = new Point(88, 16 /*0x10*/);
    this.cboCoverages.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCoverages).Name = "cboCoverages";
    ((Control) this.cboCoverages).Size = new Size(219, 21);
    ((Control) this.cboCoverages).TabIndex = 1;
    ((UltraControlBase) this.cboCoverages).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCoverages).UseOsThemes = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCoInsurance).Appearance = (AppearanceBase) appearance16;
    ((TextEditorControlBase) this.txtCoInsurance).BackColor = Color.White;
    ((Control) this.txtCoInsurance).DataBindings.Add(new Binding("Text", (object) this.ds, "tblPropertyExposure.CoInsurance", true));
    ((Control) this.txtCoInsurance).Location = new Point(227, 118);
    this.txtCoInsurance.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCoInsurance).Name = "txtCoInsurance";
    ((Control) this.txtCoInsurance).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.txtCoInsurance).TabIndex = 9;
    ((UltraControlBase) this.txtCoInsurance).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCoInsurance).UseOsThemes = (DefaultableBoolean) 2;
    this.cboClientOffices.BorderStyle = (UIElementBorderStyle) 4;
    this.cboClientOffices.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboClientOffices).DropDownWidth = 300;
    ((Control) this.cboClientOffices).Location = new Point(88, 83);
    this.cboClientOffices.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboClientOffices).Name = "cboClientOffices";
    ((Control) this.cboClientOffices).Size = new Size(136, 21);
    ((Control) this.cboClientOffices).TabIndex = 6;
    ((UltraControlBase) this.cboClientOffices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboClientOffices).UseOsThemes = (DefaultableBoolean) 2;
    appearance17.BackColorDisabled = Color.Gainsboro;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numLimit).Appearance = (AppearanceBase) appearance17;
    ((Control) this.numLimit).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.Limit", true));
    ((UltraNumericEditorBase) this.numLimit).FormatString = "c";
    ((Control) this.numLimit).Location = new Point(88, 50);
    this.numLimit.MaxValue = (object) 999999999;
    this.numLimit.MGAStyle = MGAStyles.Blue;
    this.numLimit.MinValue = (object) -999999999;
    ((Control) this.numLimit).Name = "numLimit";
    this.numLimit.Nullable = true;
    ((Control) this.numLimit).Size = new Size(136, 20);
    ((Control) this.numLimit).TabIndex = 3;
    ((UltraWinEditorMaskedControlBase) this.numLimit).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numLimit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numLimit).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkModifyLocations.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lnkModifyLocations.AutoSize = true;
    this.lnkModifyLocations.BackColor = Color.Transparent;
    this.lnkModifyLocations.Location = new Point(729, 193);
    this.lnkModifyLocations.Name = "lnkModifyLocations";
    this.lnkModifyLocations.Size = new Size(87, 13);
    this.lnkModifyLocations.TabIndex = 16 /*0x10*/;
    this.lnkModifyLocations.TabStop = true;
    this.lnkModifyLocations.Tag = (object) "keepAlive";
    this.lnkModifyLocations.Text = "Modify Locations";
    this.lnkModifyLocations.TextAlign = ContentAlignment.MiddleCenter;
    this.lblTotalNonTerrorExcess.BackColor = Color.Transparent;
    this.lblTotalNonTerrorExcess.Location = new Point(252, 227);
    this.lblTotalNonTerrorExcess.Name = "lblTotalNonTerrorExcess";
    this.lblTotalNonTerrorExcess.Size = new Size(80 /*0x50*/, 17);
    this.lblTotalNonTerrorExcess.TabIndex = 33;
    this.lblTotalNonTerrorExcess.Text = "$0.00";
    this.lblTotalNonTerrorExcess.TextAlign = ContentAlignment.MiddleLeft;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(631, 224 /*0xE0*/);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 39;
    this.dbSave.Tag = (object) "keepAlive";
    this.lblTotalPremium.BackColor = Color.Transparent;
    this.lblTotalPremium.Location = new Point(431, 227);
    this.lblTotalPremium.Name = "lblTotalPremium";
    this.lblTotalPremium.Size = new Size(128 /*0x80*/, 17);
    this.lblTotalPremium.TabIndex = 37;
    this.lblTotalPremium.Text = "$0.00";
    this.lblTotalPremium.TextAlign = ContentAlignment.MiddleLeft;
    this.lblTotalTIV.BackColor = Color.Transparent;
    this.lblTotalTIV.Location = new Point(68, 227);
    this.lblTotalTIV.Name = "lblTotalTIV";
    this.lblTotalTIV.Size = new Size(104, 17);
    this.lblTotalTIV.TabIndex = 29;
    this.lblTotalTIV.Text = "$0.00";
    this.lblTotalTIV.TextAlign = ContentAlignment.MiddleLeft;
    this.lblTotalTerrorism.BackColor = Color.Transparent;
    this.lblTotalTerrorism.Location = new Point(252, 243);
    this.lblTotalTerrorism.Name = "lblTotalTerrorism";
    this.lblTotalTerrorism.Size = new Size(80 /*0x50*/, 17);
    this.lblTotalTerrorism.TabIndex = 35;
    this.lblTotalTerrorism.Text = "$0.00";
    this.lblTotalTerrorism.TextAlign = ContentAlignment.MiddleLeft;
    this.lblTotalNonTerror.BackColor = Color.Transparent;
    this.lblTotalNonTerror.Location = new Point(68, 243);
    this.lblTotalNonTerror.Name = "lblTotalNonTerror";
    this.lblTotalNonTerror.Size = new Size(104, 17);
    this.lblTotalNonTerror.TabIndex = 31 /*0x1F*/;
    this.lblTotalNonTerror.Text = "$0.00";
    this.lblTotalNonTerror.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lnkModifyFactor);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.cboCalcType);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) label23);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) label24);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblFactor);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) label25);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lnkEffective);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(835, 267);
    this.lnkModifyFactor.AutoSize = true;
    this.lnkModifyFactor.BackColor = Color.Transparent;
    this.lnkModifyFactor.Location = new Point(224 /*0xE0*/, 50);
    this.lnkModifyFactor.Name = "lnkModifyFactor";
    this.lnkModifyFactor.Size = new Size(79, 13);
    this.lnkModifyFactor.TabIndex = 28;
    this.lnkModifyFactor.TabStop = true;
    this.lnkModifyFactor.Text = "(modify factor)";
    this.lnkModifyFactor.TextAlign = ContentAlignment.MiddleLeft;
    this.cboCalcType.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCalcType.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCalcType).DropDownWidth = 300;
    ((Control) this.cboCalcType).Location = new Point(88, 16 /*0x10*/);
    this.cboCalcType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCalcType).Name = "cboCalcType";
    ((Control) this.cboCalcType).Size = new Size(128 /*0x80*/, 21);
    ((Control) this.cboCalcType).TabIndex = 1;
    ((UltraControlBase) this.cboCalcType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCalcType).UseOsThemes = (DefaultableBoolean) 2;
    appearance18.BackColor = Color.Transparent;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblFactor).Appearance = (AppearanceBase) appearance18;
    ((ControlBase) this.lblFactor).BackColorInternal = Color.WhiteSmoke;
    this.lblFactor.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblFactor).DataBindings.Add(new Binding("Text", (object) this.ds, "tblPropertyExposure.Factor", true));
    ((Control) this.lblFactor).Location = new Point(88, 48 /*0x30*/);
    ((Control) this.lblFactor).Name = "lblFactor";
    ((Control) this.lblFactor).Size = new Size(128 /*0x80*/, 21);
    ((Control) this.lblFactor).TabIndex = 3;
    this.lnkEffective.BackColor = Color.Transparent;
    this.lnkEffective.DataBindings.Add(new Binding("Text", (object) this.ds, "tblPropertyExposure.EffectiveDate", true));
    this.lnkEffective.Location = new Point(88, 80 /*0x50*/);
    this.lnkEffective.Name = "lnkEffective";
    this.lnkEffective.Size = new Size(168, 16 /*0x10*/);
    this.lnkEffective.TabIndex = 5;
    this.lnkEffective.TabStop = true;
    this.lnkEffective.Text = "1/1/01";
    this.lnkEffective.TextAlign = ContentAlignment.MiddleLeft;
    this.daLocations.SelectCommand = this.SqlSelectCommand1;
    this.daLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUnderwritingLocations", new DataColumnMapping[8]
      {
        new DataColumnMapping("LocationID", "LocationID"),
        new DataColumnMapping("LocationNo", "LocationNo"),
        new DataColumnMapping("BuildingNo", "BuildingNo"),
        new DataColumnMapping("PhysicalBuildingNo", "PhysicalBuildingNo"),
        new DataColumnMapping("Address", "Address"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("Zip", "Zip")
      })
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid")
    });
    this.cn.ConnectionString = "Data Source=TEAMMGA;Initial Catalog=IMS;Integrated Security=True";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    ((Control) this.dgLocations).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.dgLocations, "ContextMenu");
    ((UltraGridBase) this.dgLocations).DataSource = (object) this.ds.tblUnderwritingLocations;
    appearance19.BackColor = Color.White;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgLocations).DisplayLayout.Appearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.dgLocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 46;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance20).TextHAlignAsString = "Right";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance21;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Location #";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 69;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Right";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance23;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Building #";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 107;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance25;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Physical #";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 107;
    ultraGridColumn5.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Left";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance26;
    ((AppearanceBase) appearance27).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance27;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 99;
    ultraGridColumn6.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance28).TextHAlignAsString = "Left";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance29;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 92;
    ultraGridColumn7.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Left";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance31;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 99;
    ultraGridColumn8.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance32).TextHAlignAsString = "Left";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance32;
    ((AppearanceBase) appearance33).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance33;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 93;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance34).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance34;
    ultraGridColumn9.Format = "c";
    ((AppearanceBase) appearance35).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance35;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Total Prem";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Width = 84;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance36).TextHAlignAsString = "Right";
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance36;
    ultraGridColumn10.Format = "c";
    ((AppearanceBase) appearance37).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance37;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Terr Prem";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Width = 72;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 92;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridBand1.Columns.AddRange(new object[12]
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
      (object) ultraGridColumn12
    });
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 2;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 0;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 10;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 1;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 31 /*0x1F*/;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 2;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 19;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 3;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 25;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance38).TextHAlignAsString = "Right";
    ultraGridColumn17.CellAppearance = (AppearanceBase) appearance38;
    ultraGridColumn17.Format = "c";
    ((AppearanceBase) appearance39).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn17.Header).Appearance = (AppearanceBase) appearance39;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Non Terr";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 7;
    ultraGridColumn17.Width = 100;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn18.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance40).TextHAlignAsString = "Right";
    ultraGridColumn18.CellAppearance = (AppearanceBase) appearance40;
    ultraGridColumn18.Format = "c";
    ((AppearanceBase) appearance41).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn18.Header).Appearance = (AppearanceBase) appearance41;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Primary";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 8;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 114;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn19.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance42).TextHAlignAsString = "Right";
    ultraGridColumn19.CellAppearance = (AppearanceBase) appearance42;
    ultraGridColumn19.Format = "c";
    ((AppearanceBase) appearance43).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn19.Header).Appearance = (AppearanceBase) appearance43;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Excess";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 9;
    ultraGridColumn19.Width = 100;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn20.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance44).TextHAlignAsString = "Right";
    ultraGridColumn20.CellAppearance = (AppearanceBase) appearance44;
    ultraGridColumn20.Format = "c";
    ((AppearanceBase) appearance45).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn20.Header).Appearance = (AppearanceBase) appearance45;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Terrorism";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 10;
    ultraGridColumn20.Width = 97;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 11;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 62;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance46).TextHAlignAsString = "Right";
    ultraGridColumn22.CellAppearance = (AppearanceBase) appearance46;
    ultraGridColumn22.Format = "c";
    ((AppearanceBase) appearance47).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn22.Header).Appearance = (AppearanceBase) appearance47;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Terror Ex";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 12;
    ultraGridColumn22.Width = 99;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 13;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 32 /*0x20*/;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 14;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 42;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 15;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 27;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 39;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 17;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 85;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 18;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 19;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn29.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance48).TextHAlignAsString = "Left";
    ultraGridColumn29.CellAppearance = (AppearanceBase) appearance48;
    ((AppearanceBase) appearance49).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn29.Header).Appearance = (AppearanceBase) appearance49;
    ((HeaderBase) ultraGridColumn29.Header).Caption = "Coverage";
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 5;
    ultraGridColumn29.Width = 111;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 19;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 39;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 20;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 34;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 21;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 39;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn33.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance50).TextHAlignAsString = "Right";
    ultraGridColumn33.CellAppearance = (AppearanceBase) appearance50;
    ultraGridColumn33.Format = "c";
    ((AppearanceBase) appearance51).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn33.Header).Appearance = (AppearanceBase) appearance51;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 22;
    ultraGridColumn33.Width = 93;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 23;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn34.Width = 43;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn35.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance52).TextHAlignAsString = "Right";
    ultraGridColumn35.CellAppearance = (AppearanceBase) appearance52;
    ultraGridColumn35.Format = "c";
    ((AppearanceBase) appearance53).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn35.Header).Appearance = (AppearanceBase) appearance53;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 6;
    ultraGridColumn35.Width = 123;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 24;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn36.Width = 43;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 28;
    ultraGridColumn37.Hidden = true;
    ultraGridColumn37.Width = 72;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 25;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 35;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 26;
    ultraGridColumn39.Hidden = true;
    ultraGridColumn39.Width = 35;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 27;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 35;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 29;
    ultraGridColumn41.Hidden = true;
    ultraGridColumn41.Width = 49;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 30;
    ultraGridColumn42.Hidden = true;
    ultraGridColumn42.Width = 45;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn43.Hidden = true;
    ultraGridColumn43.Width = 87;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance54.BackColor = Color.Ivory;
    ultraGridColumn44.CellAppearance = (AppearanceBase) appearance54;
    ((HeaderBase) ultraGridColumn44.Header).Caption = "";
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 4;
    ultraGridColumn44.Width = 80 /*0x50*/;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 32 /*0x20*/;
    ultraGridColumn45.Hidden = true;
    ultraGridColumn45.Width = 89;
    ultraGridBand2.Columns.AddRange(new object[33]
    {
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
      (object) ultraGridColumn45
    });
    ultraGridBand2.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    appearance55.BackColor = Color.Ivory;
    ((AppearanceBase) appearance55).TextHAlignAsString = "Right";
    summarySettings1.Appearance = (AppearanceBase) appearance55;
    summarySettings1.DisplayFormat = "{0:c}";
    appearance56.BackColor = Color.Ivory;
    ((AppearanceBase) appearance56).TextHAlignAsString = "Right";
    summarySettings2.Appearance = (AppearanceBase) appearance56;
    summarySettings2.DisplayFormat = "{0:c}";
    appearance57.BackColor = Color.Ivory;
    ((AppearanceBase) appearance57).TextHAlignAsString = "Right";
    summarySettings3.Appearance = (AppearanceBase) appearance57;
    summarySettings3.DisplayFormat = "{0:c}";
    appearance58.BackColor = Color.Ivory;
    ((AppearanceBase) appearance58).TextHAlignAsString = "Right";
    summarySettings4.Appearance = (AppearanceBase) appearance58;
    summarySettings4.DisplayFormat = "{0:c}";
    appearance59.BackColor = Color.Ivory;
    ((AppearanceBase) appearance59).TextHAlignAsString = "Right";
    summarySettings5.Appearance = (AppearanceBase) appearance59;
    summarySettings5.DisplayFormat = "{0:c}";
    appearance60.BackColor = Color.Ivory;
    ((AppearanceBase) appearance60).TextHAlignAsString = "Right";
    summarySettings6.Appearance = (AppearanceBase) appearance60;
    summarySettings6.DisplayFormat = "{0:c}";
    ultraGridBand2.Summaries.AddRange(new SummarySettings[6]
    {
      summarySettings1,
      summarySettings2,
      summarySettings3,
      summarySettings4,
      summarySettings5,
      summarySettings6
    });
    ultraGridBand2.SummaryFooterCaption = "";
    ((UltraGridBase) this.dgLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgLocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance61.BackColor = Color.LightSteelBlue;
    appearance61.FontData.SizeInPoints = 10f;
    appearance61.ForeColor = Color.Black;
    ((UltraGridBase) this.dgLocations).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance61;
    appearance62.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance62.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance62.ForeColor = Color.Black;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance62;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance63.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance63;
    appearance64.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance64;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance65.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance65;
    appearance66.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance66;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance67.BackColor = Color.Transparent;
    appearance67.ForeColor = Color.Black;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance67;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgLocations).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgLocations).Location = new Point(5, 38);
    ((Control) this.dgLocations).Name = "dgLocations";
    ((Control) this.dgLocations).Size = new Size(843, 222);
    ((Control) this.dgLocations).TabIndex = 3;
    ((Control) this.dgLocations).Text = "Locations on this Policy";
    ((UltraControlBase) this.dgLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgLocations).UseOsThemes = (DefaultableBoolean) 2;
    this.lblOptionID.AutoSize = true;
    this.lblOptionID.Font = new Font("Tahoma", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblOptionID.Location = new Point(436, 9);
    this.lblOptionID.Name = "lblOptionID";
    this.lblOptionID.Size = new Size(53, 17);
    this.lblOptionID.TabIndex = 1;
    this.lblOptionID.Text = "12345";
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label11.Location = new Point(237, 9);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(193, 17);
    this.Label11.TabIndex = 0;
    this.Label11.Text = "You are working with option #";
    this.daLookups.SelectCommand = this.SqlSelectCommand2;
    this.daLookups.TableMappings.AddRange(new DataTableMapping[5]
    {
      new DataTableMapping("Table", "GetPropertyRaterExposureData", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("CoIns", "CoIns")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Peril", "Peril")
      }),
      new DataTableMapping("Table2", "Table2", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Valuation", "Valuation")
      }),
      new DataTableMapping("Table3", "Table3", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Deductible", "Deductible")
      }),
      new DataTableMapping("Table4", "Table4", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Coverage", "Coverage")
      })
    });
    this.SqlSelectCommand2.CommandText = "[GetPropertyRaterExposureData]";
    this.SqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.daExposure.DeleteCommand = this.SqlDeleteCommand1;
    this.daExposure.InsertCommand = this.SqlInsertCommand1;
    this.daExposure.SelectCommand = this.SqlSelectCommand3;
    this.daExposure.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblPropertyExposure", new DataColumnMapping[30]
      {
        new DataColumnMapping("ExposureID", "ExposureID"),
        new DataColumnMapping("OriginalExposureID", "OriginalExposureID"),
        new DataColumnMapping("LocationID", "LocationID"),
        new DataColumnMapping("QuoteOptionID", "QuoteOptionID"),
        new DataColumnMapping("TerrPremium", "TerrPremium"),
        new DataColumnMapping("ModificationCode", "ModificationCode"),
        new DataColumnMapping("EndorsementCalcType", "EndorsementCalcType"),
        new DataColumnMapping("EffectiveDate", "EffectiveDate"),
        new DataColumnMapping("UserAdded", "UserAdded"),
        new DataColumnMapping("OfficeID", "OfficeID"),
        new DataColumnMapping("PrimaryPremium", "PrimaryPremium"),
        new DataColumnMapping("ExcessPremium", "ExcessPremium"),
        new DataColumnMapping("Limit", "Limit"),
        new DataColumnMapping("CauseOfLossID", "CauseOfLossID"),
        new DataColumnMapping("ValuationID", "ValuationID"),
        new DataColumnMapping("CoInsuranceID", "CoInsuranceID"),
        new DataColumnMapping("CoverageID", "CoverageID"),
        new DataColumnMapping("CoInsurance", "CoInsurance"),
        new DataColumnMapping("PrimaryRate", "PrimaryRate"),
        new DataColumnMapping("ExcessRate", "ExcessRate"),
        new DataColumnMapping("TerrRate", "TerrRate"),
        new DataColumnMapping("Deductible", "Deductible"),
        new DataColumnMapping("DeductiblePerID", "DeductiblePerID"),
        new DataColumnMapping("UserOverrideFactor", "UserOverrideFactor"),
        new DataColumnMapping("OtherDeductibles", "OtherDeductibles"),
        new DataColumnMapping("PremiumsWaived", "PremiumsWaived"),
        new DataColumnMapping("TotalNonTerrorPremium", "TotalNonTerrorPremium"),
        new DataColumnMapping("TerrorPrimary", "TerrorPrimary"),
        new DataColumnMapping("TerrorExcess", "TerrorExcess"),
        new DataColumnMapping("AccountRate", "AccountRate")
      })
    });
    this.daExposure.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [tblPropertyExposure] WHERE (([ExposureID] = @Original_ExposureID))";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ExposureID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ExposureID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[30]
    {
      new SqlParameter("@OriginalExposureID", SqlDbType.Int, 4, "OriginalExposureID"),
      new SqlParameter("@LocationID", SqlDbType.Int, 4, "LocationID"),
      new SqlParameter("@QuoteOptionID", SqlDbType.Int, 4, "QuoteOptionID"),
      new SqlParameter("@TerrPremium", SqlDbType.Money, 8, "TerrPremium"),
      new SqlParameter("@ModificationCode", SqlDbType.Char, 1, "ModificationCode"),
      new SqlParameter("@EndorsementCalcType", SqlDbType.Char, 1, "EndorsementCalcType"),
      new SqlParameter("@EffectiveDate", SqlDbType.DateTime, 8, "EffectiveDate"),
      new SqlParameter("@UserAdded", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserAdded"),
      new SqlParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      new SqlParameter("@PrimaryPremium", SqlDbType.Money, 8, "PrimaryPremium"),
      new SqlParameter("@ExcessPremium", SqlDbType.Money, 8, "ExcessPremium"),
      new SqlParameter("@Limit", SqlDbType.Money, 8, "Limit"),
      new SqlParameter("@CauseOfLossID", SqlDbType.Int, 4, "CauseOfLossID"),
      new SqlParameter("@ValuationID", SqlDbType.TinyInt, 1, "ValuationID"),
      new SqlParameter("@CoInsuranceID", SqlDbType.TinyInt, 1, "CoInsuranceID"),
      new SqlParameter("@CoverageID", SqlDbType.TinyInt, 1, "CoverageID"),
      new SqlParameter("@CoInsurance", SqlDbType.VarChar, 50, "CoInsurance"),
      new SqlParameter("@PrimaryRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "PrimaryRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@ExcessRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "ExcessRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@TerrRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "TerrRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@Deductible", SqlDbType.Int, 4, "Deductible"),
      new SqlParameter("@DeductiblePerID", SqlDbType.Char, 1, "DeductiblePerID"),
      new SqlParameter("@UserOverrideFactor", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 9, (byte) 8, "UserOverrideFactor", DataRowVersion.Current, (object) null),
      new SqlParameter("@OtherDeductibles", SqlDbType.VarChar, 500, "OtherDeductibles"),
      new SqlParameter("@PremiumsWaived", SqlDbType.Bit, 1, "PremiumsWaived"),
      new SqlParameter("@TotalNonTerrorPremium", SqlDbType.Money, 8, "TotalNonTerrorPremium"),
      new SqlParameter("@TerrorPrimary", SqlDbType.Money, 8, "TerrorPrimary"),
      new SqlParameter("@TerrorExcess", SqlDbType.Money, 8, "TerrorExcess"),
      new SqlParameter("@AccountRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "AccountRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@AdditionalInfo", SqlDbType.VarChar, 2500, "AdditionalInfo")
    });
    this.SqlSelectCommand3.CommandText = componentResourceManager.GetString("SqlSelectCommand3.CommandText");
    this.SqlSelectCommand3.Connection = this.cn;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@ExposureID", SqlDbType.Int, 4, "ExposureID"),
      new SqlParameter("@quoteOptionID", SqlDbType.Int, 4, "QuoteOptionID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[32 /*0x20*/]
    {
      new SqlParameter("@OriginalExposureID", SqlDbType.Int, 4, "OriginalExposureID"),
      new SqlParameter("@LocationID", SqlDbType.Int, 4, "LocationID"),
      new SqlParameter("@QuoteOptionID", SqlDbType.Int, 4, "QuoteOptionID"),
      new SqlParameter("@TerrPremium", SqlDbType.Money, 8, "TerrPremium"),
      new SqlParameter("@ModificationCode", SqlDbType.Char, 1, "ModificationCode"),
      new SqlParameter("@EndorsementCalcType", SqlDbType.Char, 1, "EndorsementCalcType"),
      new SqlParameter("@EffectiveDate", SqlDbType.DateTime, 8, "EffectiveDate"),
      new SqlParameter("@UserAdded", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserAdded"),
      new SqlParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      new SqlParameter("@PrimaryPremium", SqlDbType.Money, 8, "PrimaryPremium"),
      new SqlParameter("@ExcessPremium", SqlDbType.Money, 8, "ExcessPremium"),
      new SqlParameter("@Limit", SqlDbType.Money, 8, "Limit"),
      new SqlParameter("@CauseOfLossID", SqlDbType.Int, 4, "CauseOfLossID"),
      new SqlParameter("@ValuationID", SqlDbType.TinyInt, 1, "ValuationID"),
      new SqlParameter("@CoInsuranceID", SqlDbType.TinyInt, 1, "CoInsuranceID"),
      new SqlParameter("@CoverageID", SqlDbType.TinyInt, 1, "CoverageID"),
      new SqlParameter("@CoInsurance", SqlDbType.VarChar, 50, "CoInsurance"),
      new SqlParameter("@PrimaryRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "PrimaryRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@ExcessRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "ExcessRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@TerrRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "TerrRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@Deductible", SqlDbType.Int, 4, "Deductible"),
      new SqlParameter("@DeductiblePerID", SqlDbType.Char, 1, "DeductiblePerID"),
      new SqlParameter("@UserOverrideFactor", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 9, (byte) 8, "UserOverrideFactor", DataRowVersion.Current, (object) null),
      new SqlParameter("@OtherDeductibles", SqlDbType.VarChar, 500, "OtherDeductibles"),
      new SqlParameter("@PremiumsWaived", SqlDbType.Bit, 1, "PremiumsWaived"),
      new SqlParameter("@TotalNonTerrorPremium", SqlDbType.Money, 8, "TotalNonTerrorPremium"),
      new SqlParameter("@TerrorPrimary", SqlDbType.Money, 8, "TerrorPrimary"),
      new SqlParameter("@TerrorExcess", SqlDbType.Money, 8, "TerrorExcess"),
      new SqlParameter("@AccountRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "AccountRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@AdditionalInfo", SqlDbType.VarChar, 2500, "AdditionalInfo"),
      new SqlParameter("@Original_ExposureID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ExposureID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ExposureID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ExposureID", DataRowVersion.Original, (object) null)
    });
    this.err.ContainerControl = (ContainerControl) this;
    ((UltraGridBase) this.ddCoverages).DataSource = (object) this.ds.lstPropRater_CoverageTypes;
    ((UltraGridBase) this.ddCoverages).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 0;
    ultraGridColumn46.Hidden = true;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 1;
    ultraGridColumn47.Width = 182;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn46,
      (object) ultraGridColumn47
    });
    ((UltraGridBase) this.ddCoverages).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddCoverages).DisplayMember = "Coverage";
    ((Control) this.ddCoverages).Location = new Point(517, 12);
    ((Control) this.ddCoverages).Name = "ddCoverages";
    ((Control) this.ddCoverages).Size = new Size(184, 72);
    ((Control) this.ddCoverages).TabIndex = 2;
    ((UltraDropDownBase) this.ddCoverages).ValueMember = "ID";
    ((Control) this.ddCoverages).Visible = false;
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) ultraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.UltraTabControl1).Controls.Add((Control) ultraTabPageControl2);
    ((Control) this.UltraTabControl1).Location = new Point(12, 266);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControls.AddRange(new Control[13]
    {
      (Control) this.lnkModifyLocations,
      (Control) label17,
      (Control) label18,
      (Control) this.lblTotalNonTerrorExcess,
      (Control) label19,
      (Control) this.dbSave,
      (Control) this.lblTotalPremium,
      (Control) this.lblTotalTIV,
      (Control) this.lblTotalTerrorism,
      (Control) this.lblTotalNonTerror,
      (Control) label20,
      (Control) label21,
      (Control) label22
    });
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(837, 294);
    ((Control) this.UltraTabControl1).TabIndex = 1;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.UltraTabControl1).TabPadding = new Size(5, 3);
    appearance68.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance19.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance68;
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Exposure Information";
    appearance69.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance20.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance69;
    ultraTab2.TabPage = ultraTabPageControl1;
    ultraTab2.Text = "Premiums / Rates";
    appearance70.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance21.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance70;
    ultraTab3.TabPage = this.UltraTabPageControl3;
    ultraTab3.Text = "Rating Information";
    appearance71.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance22.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance71;
    ultraTab4.Key = "tabMultiOperations";
    ultraTab4.TabPage = ultraTabPageControl2;
    ultraTab4.Text = "Multi-Exposure Operations";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[4]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(180, 0);
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lnkModifyLocations);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) label17);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) label18);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblTotalNonTerrorExcess);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) label19);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblTotalPremium);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblTotalTIV);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblTotalTerrorism);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblTotalNonTerror);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) label20);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) label21);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) label22);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(835, 267);
    this.UltraToolbarsManager1.DesignerFlags = 0;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.UltraToolbarsManager1.ImageTransparentColor = Color.Magenta;
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    this.UltraToolbarsManager1.Style = (ToolbarStyle) 3;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedPosition = (DockedPosition) 4;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(266, 524);
    ultraToolbar.FloatingSize = new Size(107, 26);
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((SettingsBase) this.UltraToolbarsManager1.ToolbarSettings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    appearance72.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance23.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance72;
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedPropsInternal).Caption = "Restore Exposure";
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "ContextMenu";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool2
    });
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) popupMenuTool2
    });
    ((UltraComponentControlManagerBase) this.UltraToolbarsManager1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraComponentControlManagerBase) this.UltraToolbarsManager1).UseOsThemes = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.Visible = false;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(229, 229, 215);
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left).Name = "_frmPropertyRater_Exposure_Toolbars_Dock_Area_Left";
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left).Size = new Size(0, 566);
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(229, 229, 215);
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right).Location = new Point(857, 0);
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right).Name = "_frmPropertyRater_Exposure_Toolbars_Dock_Area_Right";
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right).Size = new Size(0, 566);
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(229, 229, 215);
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top).Name = "_frmPropertyRater_Exposure_Toolbars_Dock_Area_Top";
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top).Size = new Size(857, 0);
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(229, 229, 215);
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom).Location = new Point(0, 566);
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom).Name = "_frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom).Size = new Size(857, 0);
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(857, 566);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Controls.Add((Control) this.ddCoverages);
    this.Controls.Add((Control) this.lblOptionID);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.dgLocations);
    this.Controls.Add((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmPropertyRater_Exposure);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "IMS Property Rater - Exposure Information";
    ((Control) ultraTabPageControl1).ResumeLayout(false);
    ((Control) ultraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.numPrimaryRate).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.numPrimaryTerror).EndInit();
    ((ISupportInitialize) this.numPrimaryPrem).EndInit();
    ((ISupportInitialize) this.numExcessTerror).EndInit();
    ((ISupportInitialize) this.numTotalNonTerror).EndInit();
    ((ISupportInitialize) this.numAccountRate).EndInit();
    ((ISupportInitialize) this.chkWaivePremiums).EndInit();
    ((ISupportInitialize) this.numTerrRate).EndInit();
    ((ISupportInitialize) this.numExcessRate).EndInit();
    ((ISupportInitialize) this.numTerrPrem).EndInit();
    ((ISupportInitialize) this.numExcessPrem).EndInit();
    ((Control) ultraTabPageControl2).ResumeLayout(false);
    ((Control) ultraTabPageControl2).PerformLayout();
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.txtAdditionalInfo).EndInit();
    ((ISupportInitialize) this.txtOtherDeductibles).EndInit();
    ((ISupportInitialize) this.cboDeductiblePer).EndInit();
    ((ISupportInitialize) this.txtAOPDA).EndInit();
    ((ISupportInitialize) this.cboLossCauses).EndInit();
    ((ISupportInitialize) this.cboValuation).EndInit();
    ((ISupportInitialize) this.cboCoInsurance).EndInit();
    ((ISupportInitialize) this.cboCoverages).EndInit();
    ((ISupportInitialize) this.txtCoInsurance).EndInit();
    ((ISupportInitialize) this.cboClientOffices).EndInit();
    ((ISupportInitialize) this.numLimit).EndInit();
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((Control) this.UltraTabPageControl3).PerformLayout();
    ((ISupportInitialize) this.cboCalcType).EndInit();
    ((ISupportInitialize) this.dgLocations).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ddCoverages).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).PerformLayout();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmPropertyRater_Exposure(int quoteOptionID, PropertyRater rater)
  {
    this.Load += new EventHandler(this.frmPropertyRater_Exposure_Load);
    this.FormClosing += new FormClosingEventHandler(this.frmPropertyRater_Exposure_FormClosing);
    this._exposureID = -1;
    this._roundToDollar = true;
    this._endorsementActionDate = DateTime.MinValue;
    this.InitializeComponent();
    this._quoteOption = new QuoteOption(quoteOptionID);
    this._quote = Quote.FromQuoteOptionID(quoteOptionID);
    this._propRater = rater;
    this._blockExcessPrem = this._quote.CompanyLine.BlockXSPremium;
    if (!SystemSettings.KeyExists("RoundPropertyPremiumToDollar"))
      return;
    this._roundToDollar = SystemSettings.GetBoolSetting("RoundPropertyPremiumToDollar");
  }

  private EndorsementCalcTypes CalcType
  {
    get
    {
      string Left = this.cboCalcType.Value.ToString();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "S", false) == 0)
        return EndorsementCalcTypes.ShortRate;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "P", false) == 0)
        return EndorsementCalcTypes.ProRata;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "F", false) == 0)
        return EndorsementCalcTypes.Flat;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "M", false) == 0)
        return EndorsementCalcTypes.MinimumEarned;
      throw new InvalidOperationException("Invalid Endorsement Calculation Type");
    }
  }

  private PropertyRater Rater => this._propRater;

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblPropertyExposure.TableName];
  }

  private bool TerrorismDeclined
  {
    get
    {
      if (this._terrorismDeclined == null)
        this._terrorismDeclined = (object) DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT TerrorismDeclined FROM tblQuoteOptionProperty WHERE QuoteOptionID=@QOID", new object[2]
        {
          (object) "@QOID",
          (object) this._quoteOption.QuoteOptionID
        });
      return (bool) this._terrorismDeclined;
    }
  }

  protected Quote Quote => this._quote;

  private void FillDataThread(object state)
  {
    this.daLookups.SelectCommand.Connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    try
    {
      SqlDataAdapter daLookups = this.daLookups;
      daLookups.TableMappings.Clear();
      daLookups.TableMappings.Add("Table", this.ds.lstPropRater_Coinsurance.TableName);
      daLookups.TableMappings.Add("Table1", this.ds.lstPropRater_CauseOfLoss.TableName);
      daLookups.TableMappings.Add("Table2", this.ds.lstPropRater_Valuation.TableName);
      daLookups.TableMappings.Add("Table3", this.ds.lstPropRater_CoverageTypes.TableName);
      daLookups.TableMappings.Add("Table4", this.ds.lstEndorsementCalculationTypes.TableName);
      daLookups.TableMappings.Add("Table5", this.ds.tblClientOffices.TableName);
      daLookups.TableMappings.Add("Table6", this.ds.lstDeductiblePer.TableName);
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLookups, (DataSet) this.ds);
      try
      {
        if (this.IsDisposed || this.Disposing)
          return;
        this.Invoke((Delegate) new frmPropertyRater_Exposure.FillDataThreadCompleteHandler(this.FillDataThreadComplete), (object) this, (object) EventArgs.Empty);
      }
      catch (InvalidOperationException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
    finally
    {
      if (this.daLookups.SelectCommand.Connection != null)
        this.daLookups.SelectCommand.Connection.Dispose();
      this.daLookups.Dispose();
    }
  }

  private void FillDataThreadComplete(object sender, EventArgs e)
  {
    MGASimpleComboBox cboCoInsurance = this.cboCoInsurance;
    ((UltraGridBase) cboCoInsurance).DataSource = (object) this.ds.lstPropRater_Coinsurance;
    ((UltraDropDownBase) cboCoInsurance).DisplayMember = this.ds.lstPropRater_Coinsurance.CoInsColumn.ColumnName;
    ((UltraDropDownBase) cboCoInsurance).ValueMember = this.ds.lstPropRater_Coinsurance.IDColumn.ColumnName;
    ((Control) cboCoInsurance).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.CoInsuranceID"));
    MGASimpleComboBox cboCoverages = this.cboCoverages;
    ((UltraGridBase) cboCoverages).DataSource = (object) this.ds.lstPropRater_CoverageTypes;
    ((UltraDropDownBase) cboCoverages).DisplayMember = this.ds.lstPropRater_CoverageTypes.CoverageColumn.ColumnName;
    ((UltraDropDownBase) cboCoverages).ValueMember = this.ds.lstPropRater_CoverageTypes.IDColumn.ColumnName;
    ((Control) cboCoverages).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.CoverageID"));
    MGASimpleComboBox cboLossCauses = this.cboLossCauses;
    ((UltraGridBase) cboLossCauses).DataSource = (object) this.ds.lstPropRater_CauseOfLoss;
    ((UltraDropDownBase) cboLossCauses).DisplayMember = this.ds.lstPropRater_CauseOfLoss.PerilColumn.ColumnName;
    ((UltraDropDownBase) cboLossCauses).ValueMember = this.ds.lstPropRater_CauseOfLoss.IDColumn.ColumnName;
    ((Control) cboLossCauses).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.CauseOfLossID"));
    MGASimpleComboBox cboValuation = this.cboValuation;
    ((UltraGridBase) cboValuation).DataSource = (object) this.ds.lstPropRater_Valuation;
    ((UltraDropDownBase) cboValuation).DisplayMember = this.ds.lstPropRater_Valuation.ValuationColumn.ColumnName;
    ((UltraDropDownBase) cboValuation).ValueMember = this.ds.lstPropRater_Valuation.IDColumn.ColumnName;
    ((Control) cboValuation).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.ValuationID"));
    MGASimpleComboBox cboClientOffices = this.cboClientOffices;
    ((UltraGridBase) cboClientOffices).DataSource = (object) this.ds.tblClientOffices;
    ((UltraDropDownBase) cboClientOffices).DisplayMember = this.ds.tblClientOffices.LocationColumn.ColumnName;
    ((UltraDropDownBase) cboClientOffices).ValueMember = this.ds.tblClientOffices.OfficeIDColumn.ColumnName;
    ((Control) cboClientOffices).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.OfficeID"));
    MGASimpleComboBox cboCalcType = this.cboCalcType;
    ((UltraGridBase) cboCalcType).DataSource = (object) this.ds.lstEndorsementCalculationTypes;
    ((UltraDropDownBase) cboCalcType).DisplayMember = this.ds.lstEndorsementCalculationTypes.EndorsementCalcTypeColumn.ColumnName;
    ((UltraDropDownBase) cboCalcType).ValueMember = this.ds.lstEndorsementCalculationTypes.IDColumn.ColumnName;
    ((Control) cboCalcType).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.EndorsementCalcType"));
    MGASimpleComboBox cboDeductiblePer = this.cboDeductiblePer;
    ((UltraGridBase) cboDeductiblePer).DataSource = (object) this.ds.lstDeductiblePer;
    ((UltraDropDownBase) cboDeductiblePer).DisplayMember = "DeductiblePer";
    ((UltraDropDownBase) cboDeductiblePer).ValueMember = "PerID";
    ((Control) cboDeductiblePer).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPropertyExposure.DeductiblePerID"));
    try
    {
      this.ds.EnforceConstraints = true;
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    if (this.ds.tblUnderwritingLocations.Count == 0)
      this.OpenUnderwritingLocationsForm();
    this.SetupLimitTotal();
    this._loaded = true;
  }

  private void frmPropertyRater_Exposure_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.lblOptionID.Text = this._quoteOption.QuoteOptionID.ToString();
    ((Control) this.cboCalcType).Enabled = this._quote.IsEndorsement;
    this.ds.EnforceConstraints = false;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.FillDataThread));
    this.daLocations.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._quote.QuoteGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLocations, (DataTable) this.ds.tblUnderwritingLocations);
    SqlDataAdapter daExposure = this.daExposure;
    daExposure.SelectCommand.Parameters["@quoteOptionID"].Value = (object) this._quoteOption.QuoteOptionID;
    daExposure.SelectCommand.Parameters["@exposureID"].Value = (object) DBNull.Value;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daExposure, (DataTable) this.ds.tblPropertyExposure);
    this.SetupTerrorismDeclinedAppearance();
    this.UpdateLocationPremiums();
    this.UpdatePremiumValues(RuntimeHelpers.GetObjectValue(sender), e);
    this.ColorDeletedLocationRows();
    MGASystems.Tools.DBSaveUI.DBSaveUI dbSave = this.dbSave;
    dbSave.UIState = UIState.NoRecordsNotEditing;
    dbSave.EditStyle = EditStyle.ShowEditButton;
    dbSave.Enabled = !this._quote.IsIssued;
    try
    {
      foreach (Control control in ((Control) ((UltraTabControlBase) this.UltraTabControl1).Tabs["tabMultiOperations"].TabPage).Controls)
        control.Enabled = false;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((UltraGridBase) this.dgLocations).Rows.ExpandAll(true);
    ((UltraToggleEditorBase) this.chkWaivePremiums).CheckedChanged += new EventHandler(this.chkWaivePremiums_CheckedChanged);
    this.SetControlsEnabled();
    this._canAddExposureAfterBind = SecurityManager.Instance.AssertPermission("{7F84EFED-6F80-48ef-BD1C-C3226007951F}");
    this._canEditExposureAfterBind = SecurityManager.Instance.AssertPermission("{FD56285A-8B65-46ae-8C64-5F7731C299FA}");
    this._canDeleteExposureAfterBind = SecurityManager.Instance.AssertPermission("{55B3BB5A-2686-48b2-A511-BA76B2F431A0}");
    this.FormLoad();
  }

  protected virtual void FormLoad()
  {
  }

  public Decimal TIV
  {
    get
    {
      Decimal minValue;
      if (this.ds.tblPropertyExposure.Count > 0)
      {
        object obj = RuntimeHelpers.GetObjectValue(this.ds.tblPropertyExposure.Compute("SUM(Limit)", "ModificationCode <> 'D'"));
        if (Utility.IsNull(RuntimeHelpers.GetObjectValue(obj)))
          obj = (object) 0;
        minValue = Conversions.ToDecimal(obj);
      }
      else
        minValue = Decimal.MinValue;
      return minValue;
    }
  }

  private void ColorDeletedLocationRows()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.dgLocations).Rows)
    {
      object Left1 = RuntimeHelpers.GetObjectValue(row.Cells["ModificationCode"].Value);
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(Left1)))
        Left1 = (object) string.Empty;
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "D", false))
      {
        UltraGridRow ultraGridRow = row;
        ultraGridRow.Appearance.ForeColor = Color.Red;
        ultraGridRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
        ultraGridRow.Cells["TotalPremium"].Appearance.ForeColor = Color.Red;
      }
      else
      {
        UltraGridRow ultraGridRow = row;
        ultraGridRow.Appearance.ForeColor = Color.Black;
        ultraGridRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
        Appearance appearance = ultraGridRow.Cells["TotalPremium"].Appearance;
        object obj = RuntimeHelpers.GetObjectValue(row.Cells["TotalPremium"].Value);
        if (Utility.IsNull(RuntimeHelpers.GetObjectValue(obj)))
          obj = (object) 0;
        object Left2 = obj;
        appearance.ForeColor = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectLess(Left2, (object) 0, false) ? (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left2, (object) 0, false) ? Color.Green : Color.Black) : Color.Red;
      }
    }
  }

  private void BlockXSPremium()
  {
    ((Control) this.numExcessPrem).Enabled = !this._blockExcessPrem;
    ((Control) this.numExcessTerror).Enabled = !this._blockExcessPrem;
    ((Control) this.numExcessRate).Enabled = !this._blockExcessPrem;
  }

  private void SetupTerrorismDeclinedAppearance()
  {
    if (this.TerrorismDeclined)
    {
      if (this._strikeoutFont == null)
      {
        this._originalFont = ((Control) this.numTerrPrem).Font;
        this._strikeoutFont = new Font(((Control) this.numTerrPrem).Font, FontStyle.Strikeout);
      }
      MGANumericEditor numTerrPrem = this.numTerrPrem;
      ((Control) numTerrPrem).Font = this._strikeoutFont;
      ((UltraNumericEditorBase) numTerrPrem).ForeColor = Color.Red;
      MGANumericEditor numExcessTerror = this.numExcessTerror;
      ((Control) numExcessTerror).Font = this._strikeoutFont;
      ((UltraNumericEditorBase) numExcessTerror).ForeColor = Color.Red;
      ((Control) this.numPrimaryTerror).Font = this._strikeoutFont;
      AppearanceBase cellAppearance1 = ((UltraGridBase) this.dgLocations).DisplayLayout.Bands[1].Columns["TerrPremium"].CellAppearance;
      cellAppearance1.ForeColor = Color.Red;
      cellAppearance1.FontData.Strikeout = (DefaultableBoolean) 1;
      AppearanceBase cellAppearance2 = ((UltraGridBase) this.dgLocations).DisplayLayout.Bands[1].Columns["TerrorExcess"].CellAppearance;
      cellAppearance2.ForeColor = Color.Red;
      cellAppearance2.FontData.Strikeout = (DefaultableBoolean) 1;
    }
    else
    {
      MGANumericEditor numTerrPrem = this.numTerrPrem;
      ((Control) numTerrPrem).Font = this._originalFont;
      ((UltraNumericEditorBase) numTerrPrem).ForeColor = Color.Black;
      MGANumericEditor numExcessTerror = this.numExcessTerror;
      ((Control) numExcessTerror).Font = this._originalFont;
      ((UltraNumericEditorBase) numExcessTerror).ForeColor = Color.Black;
      ((Control) this.numPrimaryTerror).Font = this._originalFont;
    }
  }

  private void chkWaivePremiums_CheckedChanged(object sender, EventArgs e)
  {
    this.SetControlsEnabled();
  }

  private bool RestoreAvailable
  {
    get
    {
      bool restoreAvailable;
      try
      {
        UIElement lastElementEntered = ((ControlUIElementBase) ((UltraGridBase) this.dgLocations).DisplayLayout.UIElement).LastElementEntered;
        if (lastElementEntered == null)
        {
          restoreAvailable = false;
        }
        else
        {
          UltraGridRow context = (UltraGridRow) lastElementEntered.GetContext(typeof (UltraGridRow), true);
          restoreAvailable = context != null && context.Band.Index == 1 && !this._quote.IsBound;
        }
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        restoreAvailable = false;
        ProjectData.ClearProjectError();
      }
      return restoreAvailable;
    }
  }

  private void dgLocations_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Right)
      return;
    UIElement lastElementEntered = ((ControlUIElementBase) ((UltraGridBase) this.dgLocations).DisplayLayout.UIElement).LastElementEntered;
    if (lastElementEntered == null)
      return;
    UltraGridRow context = (UltraGridRow) lastElementEntered.GetContext(typeof (UltraGridRow), true);
    if (context == null)
      return;
    ((UltraGridBase) this.dgLocations).ActiveRow = context;
    this.dgLocations.Selected.Rows.Clear();
    context.Selected = true;
    ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Restore Exposure"].SharedProps.Enabled = this.RestoreAvailable;
  }

  private void lnkModifyFactor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.cboCalcType.Text.Length == 0)
    {
      int num = (int) MessageBox.Show("Please select an endorsment calculation type before proceeding.", "Calculation Type Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      frmEndorsementActionDate endorsementActionDate = (frmEndorsementActionDate) FormSettings.ShowFormDialog(typeof (frmEndorsementActionDate), (object) new PropertyQuoteOption(this._quoteOption.QuoteOptionID), (object) this._quote, (object) this.CalcType, (object) this.ds.tblPropertyExposure[this.bmb.Position].EffectiveDate);
      MDIControls.Instance.MDIParent.Refresh();
      if (!endorsementActionDate.Saved)
        return;
      dsPropertyRater_Exposure.tblPropertyExposureRow propertyExposureRow = this.ds.tblPropertyExposure[this.bmb.Position];
      propertyExposureRow.EffectiveDate = endorsementActionDate.ActionDate;
      propertyExposureRow.Factor = endorsementActionDate.Factor;
      if (endorsementActionDate.FactorOverridden)
        propertyExposureRow.UserOverrideFactor = endorsementActionDate.Factor;
    }
  }

  private void lnkAddMiscPremiums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowFormDialog(typeof (frmMiscPremiums), (object) this._quoteOption.QuoteOptionID);
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (this._quote.IsBound && !this._canEditExposureAfterBind)
    {
      int num = (int) MessageBox.Show("You do not have the required security to edit exposures after policy is bound.", "Security Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      if (this._quote.IsEndorsement)
      {
        frmEndorsementActionDate endorsementActionDate = (frmEndorsementActionDate) FormSettings.ShowFormDialog(typeof (frmEndorsementActionDate), (object) new PropertyQuoteOption(this._quoteOption.QuoteOptionID), (object) this._quote, (object) this.CalcType, (object) this.ds.tblPropertyExposure[this.bmb.Position].EffectiveDate);
        MDIControls.Instance.MDIParent.Refresh();
        Application.DoEvents();
        if (endorsementActionDate.Saved)
        {
          dsPropertyRater_Exposure.tblPropertyExposureRow propertyExposureRow = this.ds.tblPropertyExposure[this.bmb.Position];
          propertyExposureRow.EffectiveDate = endorsementActionDate.ActionDate;
          propertyExposureRow.Factor = endorsementActionDate.Factor;
          if (endorsementActionDate.FactorOverridden)
            propertyExposureRow.UserOverrideFactor = endorsementActionDate.Factor;
        }
        else
          e.Cancel = true;
      }
      else
        this.dbSave.ClickingEdit -= new CancelEventHandler(this.dbSave_ClickingEdit);
      this.BlockXSPremium();
    }
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((ToolEventArgs) e).Tool.Key, "Restore Exposure", false) != 0)
      return;
    this.RestoreExposure();
  }

  private void TotalTIVChanged()
  {
    object obj = RuntimeHelpers.GetObjectValue(this.ds.tblPropertyExposure.Compute("SUM(Limit)", "ModificationCode <> 'D'"));
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(obj)))
      obj = (object) 0;
    this.lblTotalTIV.Text = Conversions.ToDecimal(obj).ToString("c");
  }

  private void UpdateLocationPremiums()
  {
    try
    {
      foreach (dsPropertyRater_Exposure.tblUnderwritingLocationsRow underwritingLocation in (TypedTableBase<dsPropertyRater_Exposure.tblUnderwritingLocationsRow>) this.ds.tblUnderwritingLocations)
      {
        Decimal d1 = 0M;
        dsPropertyRater_Exposure.tblPropertyExposureDataTable propertyExposure1 = this.ds.tblPropertyExposure;
        int locationId = underwritingLocation.LocationID;
        string filter1 = "LocationID=" + locationId.ToString();
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(propertyExposure1.Compute("SUM(TerrPremium)", filter1))))
        {
          dsPropertyRater_Exposure.tblPropertyExposureDataTable propertyExposure2 = this.ds.tblPropertyExposure;
          locationId = underwritingLocation.LocationID;
          string filter2 = "LocationID=" + locationId.ToString();
          d1 = Conversions.ToDecimal(propertyExposure2.Compute("SUM(TerrPremium)", filter2));
        }
        Decimal d2_1 = 0M;
        dsPropertyRater_Exposure.tblPropertyExposureDataTable propertyExposure3 = this.ds.tblPropertyExposure;
        locationId = underwritingLocation.LocationID;
        string filter3 = "LocationID=" + locationId.ToString();
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(propertyExposure3.Compute("SUM(PrimaryPremium)", filter3))))
        {
          dsPropertyRater_Exposure.tblPropertyExposureDataTable propertyExposure4 = this.ds.tblPropertyExposure;
          locationId = underwritingLocation.LocationID;
          string filter4 = "LocationID=" + locationId.ToString();
          d2_1 = Conversions.ToDecimal(propertyExposure4.Compute("SUM(PrimaryPremium)", filter4));
        }
        Decimal d2_2 = 0M;
        dsPropertyRater_Exposure.tblPropertyExposureDataTable propertyExposure5 = this.ds.tblPropertyExposure;
        locationId = underwritingLocation.LocationID;
        string filter5 = "LocationID=" + locationId.ToString();
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(propertyExposure5.Compute("SUM(ExcessPremium)", filter5))))
        {
          dsPropertyRater_Exposure.tblPropertyExposureDataTable propertyExposure6 = this.ds.tblPropertyExposure;
          locationId = underwritingLocation.LocationID;
          string filter6 = "LocationID=" + locationId.ToString();
          d2_2 = Conversions.ToDecimal(propertyExposure6.Compute("SUM(ExcessPremium)", filter6));
        }
        this.ds.tblUnderwritingLocations.FindByLocationID(underwritingLocation.LocationID).TotalPremium = Decimal.Add(Decimal.Add(d1, d2_1), d2_2);
        this.ds.tblUnderwritingLocations.FindByLocationID(underwritingLocation.LocationID).TerrPremium = d1;
        this.TotalTIVChanged();
        Decimal num1 = 0M;
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.ds.tblPropertyExposure.Compute("SUM(ExcessPremium)", string.Empty))))
          num1 = Conversions.ToDecimal(this.ds.tblPropertyExposure.Compute("SUM(ExcessPremium)", string.Empty));
        Decimal num2 = 0M;
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.ds.tblPropertyExposure.Compute("SUM(TerrorExcess)", string.Empty))))
          num2 = Conversions.ToDecimal(this.ds.tblPropertyExposure.Compute("SUM(TerrorExcess)", string.Empty));
        Decimal num3 = 0M;
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.ds.tblPropertyExposure.Compute("SUM(PrimaryPremium)", string.Empty))))
          num3 = Conversions.ToDecimal(this.ds.tblPropertyExposure.Compute("SUM(PrimaryPremium)", string.Empty));
        Decimal d2_3 = 0M;
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.ds.tblPropertyExposure.Compute("SUM(TerrPremium)", string.Empty))))
          d2_3 = Conversions.ToDecimal(this.ds.tblPropertyExposure.Compute("SUM(TerrPremium)", string.Empty));
        Decimal num4;
        if (this.TerrorismDeclined)
        {
          Label lblTotalNonTerror = this.lblTotalNonTerror;
          num4 = Decimal.Add(num3, num1);
          string str1 = num4.ToString("c");
          lblTotalNonTerror.Text = str1;
          this.lblTotalTerrorism.Text = Strings.FormatCurrency((object) 0);
          this.lblTotalNonTerrorExcess.Text = num1.ToString("c");
          this.labelExcessTerror.Text = Strings.FormatCurrency((object) 0);
          Label lblTotalPremium = this.lblTotalPremium;
          num4 = Decimal.Add(num1, num3);
          string str2 = num4.ToString("c");
          lblTotalPremium.Text = str2;
        }
        else
        {
          Label lblTotalNonTerror = this.lblTotalNonTerror;
          num4 = Decimal.Add(num3, num1);
          string str3 = num4.ToString("c");
          lblTotalNonTerror.Text = str3;
          this.lblTotalTerrorism.Text = d2_3.ToString("c");
          this.lblTotalNonTerrorExcess.Text = num1.ToString("c");
          this.labelExcessTerror.Text = num2.ToString("C");
          Label lblTotalPremium = this.lblTotalPremium;
          num4 = Decimal.Add(Decimal.Add(num3, num1), d2_3);
          string str4 = num4.ToString("c");
          lblTotalPremium.Text = str4;
        }
      }
    }
    finally
    {
      IEnumerator<dsPropertyRater_Exposure.tblUnderwritingLocationsRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void SetControlsEnabled()
  {
    bool flag1 = this.dbSave.UIState == UIState.Editing;
    ((Control) this.dgLocations).Enabled = !flag1;
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tab.Key, "tabMultiOperations", false) != 0)
      {
        try
        {
          foreach (Control control in ((Control) tab.TabPage).Controls)
          {
            if (control != this.dbSave)
            {
              if (control.Tag != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Tag.ToString(), "keepAlive", false) == 0)
                control.Enabled = true;
              else if (control.Tag != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Tag.ToString(), "KeepDisabled", false) == 0)
                control.Enabled = false;
              else if ((control == this.numTotalNonTerror || control == this.numExcessPrem || control == this.numTerrPrem || control == this.numExcessTerror) && flag1)
              {
                bool flag2 = ((UltraToggleEditorBase) this.chkWaivePremiums).Checked;
                ((Control) this.numTotalNonTerror).Enabled = !flag2;
                ((Control) this.numExcessPrem).Enabled = !flag2;
                ((Control) this.numTerrPrem).Enabled = !flag2;
                ((Control) this.numExcessTerror).Enabled = !flag2;
              }
              else
                control.Enabled = flag1;
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
    try
    {
      foreach (Control control in ((Control) ((UltraTabControlBase) this.UltraTabControl1).Tabs["tabMultiOperations"].TabPage).Controls)
        control.Enabled = this.dbSave.Enabled;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.lnkModifyLocations.Enabled = this.dbSave.UIState != UIState.Editing;
    this.BlockXSPremium();
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e) => this.SetControlsEnabled();

  private void SelectedRow(UltraGridRow row, int exposureID, int position)
  {
    UltraGridRow ultraGridRow = (UltraGridRow) null;
    if (row.HasParent())
      ultraGridRow = row.ParentRow;
    if (ultraGridRow == null)
      return;
    int num1 = position;
    int num2 = 0;
    while (num2 <= num1)
    {
      UltraGridRow sibling = ultraGridRow.GetSibling((SiblingRow) 2);
      if (Conversions.ToInteger(sibling.Cells["ExposureID"].Value) == exposureID)
        ((UltraGridBase) this.dgLocations).ActiveRow = sibling;
      checked { ++num2; }
    }
  }

  private void SetGridSelectedRow(int exposureID, int position)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.dgLocations).Rows)
    {
      if (row.Band.Index == 1)
      {
        if (Conversions.ToInteger(row.Cells["ExposureID"].Value) == exposureID)
          ((UltraGridBase) this.dgLocations).ActiveRow = row;
      }
      else
        this.SelectedRow(row, exposureID, position);
    }
  }

  private void dgLocations_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgLocations).ActiveRow == null)
      return;
    if (((UltraGridBase) this.dgLocations).ActiveRow.Band.Index == 0)
    {
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    }
    else
    {
      this.bmb.CancelCurrentEdit();
      Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgLocations).ActiveRow.Cells["ExposureID"].Value), "ExposureID", (DataTable) this.ds.tblPropertyExposure, this.bmb);
      this.UpdatePremiumValues(RuntimeHelpers.GetObjectValue(sender), e);
      this.ds.tblPropertyExposure.AcceptChanges();
      if (this.dbSave.UIState != UIState.Editing && this.ds.tblPropertyExposure.Count > 0)
        this.dbSave.UIState = UIState.HasRecordsNotEditing;
      this.linkRestoreExposures.Enabled = this.RestoreAvailable;
    }
  }

  [SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (this._quote.IsBound && !this._canAddExposureAfterBind)
    {
      int num = (int) MessageBox.Show("You do not have the required security to add new exposures after policy is bound.", "Security Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else if (((UltraGridBase) this.dgLocations).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select a location in the grid to add exposure to.", "Location Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      int num = (int) ((UltraGridBase) this.dgLocations).ActiveRow.Cells["LocationID"].Value;
      dsPropertyRater_Exposure.tblPropertyExposureRow row1 = this.ds.tblPropertyExposure.NewtblPropertyExposureRow();
      row1.QuoteOptionID = this._quoteOption.QuoteOptionID;
      row1.UserAdded = CurrentUser.Instance.UserGUID;
      row1.LocationID = num;
      row1.ModificationCode = "N";
      if (this._quote.IsEndorsement)
      {
        frmEndorsementActionDate endorsementActionDate = (frmEndorsementActionDate) FormSettings.ShowFormDialog(typeof (frmEndorsementActionDate), (object) new PropertyQuoteOption(this._quoteOption.QuoteOptionID), (object) this._quote, (object) this._quote.EndorsementCalculationType, (object) this._quote.EndorsementEffective);
        MDIControls.Instance.MDIParent.Refresh();
        Application.DoEvents();
        if (endorsementActionDate.Saved)
        {
          row1.EffectiveDate = endorsementActionDate.ActionDate;
          row1.Factor = endorsementActionDate.Factor;
          if (endorsementActionDate.FactorOverridden)
            row1.UserOverrideFactor = endorsementActionDate.Factor;
        }
        else
        {
          row1.EffectiveDate = this._quote.EndorsementEffective;
          row1.Factor = 1M;
        }
      }
      else
        row1.Factor = 1M;
      row1.DeductiblePerID = "O";
      if (this.ds.tblClientOffices.Count == 1)
      {
        dsPropertyRater_Exposure.tblClientOfficesRow tblClientOffice = this.ds.tblClientOffices[0];
        row1.OfficeID = tblClientOffice.OfficeID;
      }
      DataRow row2 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT Rate, ValuationID, CoInsuranceID, CauseOfLossID, AOPDA,TerrPremium, PrimaryPremium, OtherDeduct FROM tblQuoteOptionProperty WHERE QuoteOptionID=@QOID", new object[2]
      {
        (object) "@QOID",
        (object) (!this._quote.IsEndorsement || !this._quoteOption.HasPreviousQuoteOptionGuid ? this._quoteOption.QuoteOptionID : new QuoteOption(this._quoteOption.PreviousQuoteOptionGuid).QuoteOptionID)
      }).Rows[0];
      row1.AccountRate = Conversions.ToDecimal(row2[0]);
      row1.ValuationID = Conversions.ToInteger(row2[1]);
      row1.CoInsuranceID = Conversions.ToInteger(row2[2]);
      row1.CauseOfLossID = Conversions.ToInteger(row2[3]);
      row1.Deductible = Conversions.ToInteger(row2[4]);
      if (row2[7] != DBNull.Value)
        row1.OtherDeductibles = (string) row2[7];
      OfficeLocation officeLocation = OfficeLocation.FromOfficeGuid(this._quote.QuotingLocationGuid);
      row1.OfficeID = officeLocation.OfficeID;
      if (this._quote.IsEndorsement)
      {
        row1.EndorsementCalcType = this._quote.EndorsementCalcType;
      }
      else
      {
        if (this._quote.IsShortTerm)
          row1.EndorsementCalcType = "S";
        row1.EffectiveDate = this._quote.EffectiveDate;
      }
      if (Decimal.Compare(Conversions.ToDecimal(row2[6]), 0M) > 0)
        row1.TerrRate = Decimal.Divide(Conversions.ToDecimal(row2[5]), Conversions.ToDecimal(row2[6]));
      this.ds.tblPropertyExposure.AddtblPropertyExposureRow(row1);
      this.bmb.Position = checked (this.ds.tblPropertyExposure.Rows.Count - 1);
      try
      {
        foreach (Control control in ((Control) ((UltraTabControlBase) this.UltraTabControl1).Tabs[0].TabPage).Controls)
        {
          if (control is MGASimpleComboBox)
          {
            MGASimpleComboBox mgaSimpleComboBox = (MGASimpleComboBox) control;
            string bindingField = ((Control) mgaSimpleComboBox).DataBindings[0].BindingMemberInfo.BindingField;
            if (row1[bindingField] == DBNull.Value)
              ((UltraDropDownBase) mgaSimpleComboBox).SelectedRow = (UltraGridRow) null;
            else
              mgaSimpleComboBox.Value = RuntimeHelpers.GetObjectValue(row1[bindingField]);
          }
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

  private void UpdatePremiumValues(object sender, EventArgs e)
  {
    Decimal d2_1 = 0M;
    if (!this.TerrorismDeclined && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numTerrPrem.Value)))
      d2_1 = Conversions.ToDecimal(this.numTerrPrem.Value);
    Decimal d1 = 0M;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numExcessPrem.Value)))
      d1 = Conversions.ToDecimal(this.numExcessPrem.Value);
    Decimal d2_2 = 0M;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numPrimaryPrem.Value)))
      d2_2 = Conversions.ToDecimal(this.numPrimaryPrem.Value);
    ((ControlBase) this.lblTotalLocationPremium).Text = Strings.FormatCurrency((object) Decimal.Add(Decimal.Add(d1, d2_2), d2_1));
  }

  private bool ValidateControls()
  {
    bool flag = true;
    try
    {
      foreach (Control control in ((Control) ((UltraTabControlBase) this.UltraTabControl1).Tabs[0].TabPage).Controls)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Text, string.Empty, false) == 0 && control != this.dbSave && control != this.txtCoInsurance && control != this.txtOtherDeductibles && control != this.txtAdditionalInfo)
        {
          this.err.SetError(control, "Please enter a value.");
          flag = false;
        }
        else
          this.err.SetError(control, string.Empty);
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

  private bool IsValidForm()
  {
    bool flag1 = this.ValidateControls();
    bool flag2;
    if (!flag1)
    {
      ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[0];
      flag2 = false;
    }
    else
    {
      if (this.numPrimaryRate.Value == DBNull.Value || Decimal.Compare(Conversions.ToDecimal(this.numPrimaryRate.Value), 0M) < 0)
      {
        this.err.SetError((Control) this.numPrimaryRate, "Please enter a valid rate.");
        flag1 = false;
      }
      else
        this.err.SetError((Control) this.numPrimaryRate, string.Empty);
      if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.numPrimaryTerror.Value)) && Decimal.Compare(Conversions.ToDecimal(this.numPrimaryTerror.Value), 0M) < 0 && Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.numTerrPrem.Value)) && Decimal.Compare(Conversions.ToDecimal(this.numTerrPrem.Value), 0M) >= 0)
      {
        this.err.SetError((Control) this.numPrimaryTerror, "Primary premium can not be less than zero when total premium is positive.");
        flag1 = false;
      }
      else
        this.err.SetError((Control) this.numPrimaryTerror, string.Empty);
      if (this.numAccountRate.Value == DBNull.Value)
      {
        this.err.SetError((Control) this.numAccountRate, "Please enter a rate.");
        flag1 = false;
      }
      else
        this.err.SetError((Control) this.numAccountRate, string.Empty);
      if (flag1)
        flag1 = this.ValidateRates();
      if (!flag1)
        ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[1];
      flag2 = flag1;
    }
    return flag2;
  }

  private bool ValidateRates()
  {
    bool flag = true;
    Decimal d1_1 = 0M;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numAccountRate.Value)))
      d1_1 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.numAccountRate.Value));
    Decimal d1 = 0M;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numExcessRate.Value)))
      d1 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.numExcessRate.Value));
    Decimal d2 = 0M;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numExcessRate.Value)))
      d2 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.numExcessRate.Value));
    Decimal d1_2 = 0M;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numTerrRate.Value)))
      d1_2 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.numTerrRate.Value));
    if (!((UltraToggleEditorBase) this.chkWaivePremiums).Checked && Decimal.Compare(d1_1, this.CalculateAccountRate()) != 0)
    {
      int num = (int) MessageBox.Show($"The account rate is not valid.  Expected {this.CalculateAccountRate().ToString()}.", "Invalid Account Rate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (!((UltraToggleEditorBase) this.chkWaivePremiums).Checked && Decimal.Compare(Math.Round(d1, 2), Math.Round(this.CalculateExcessRate(), 2)) != 0)
    {
      if (MessageBox.Show($"The excess rate is not valid.\n\nPlease verify that both the excess premium and terrorism excess are correct.\n\nExpected rate based on excess premium amount: {Math.Round(this.CalculateExcessRate(), 2).ToString()}\nExpected rate based on terrorism excess amount: {Math.Round(this.CalculateTerrorismExcessRate(), 2).ToString()}\n\nWould you like to bypass the rate check and save anyway?", "Invalid Excess Rate", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
        flag = false;
      else
        CurrentUser.Instance.LogAction("Agreed to excess rate manual override.", this._quote.QuoteGuid);
    }
    else if (!this.TerrorismDeclined && Decimal.Compare(Conversions.ToDecimal(this.numTerrPrem.Value), 0M) != 0 && !((UltraToggleEditorBase) this.chkWaivePremiums).Checked && Decimal.Compare(Math.Round(d2, 2), Math.Round(this.CalculateTerrorismExcessRate(), 2)) != 0)
    {
      if (MessageBox.Show($"The excess rate is not valid.\n\nPlease verify that both the excess premium and terrorism excess are correct.\n\nExpected (rounded) rate based on excess premium amount: {Math.Round(this.CalculateExcessRate(), 2).ToString()}\nExpected (rounded) rate based on terrorism excess amount: {Math.Round(this.CalculateTerrorismExcessRate(), 2).ToString()}\n\nWould you like to bypass the rate check and save anyway?", "Invalid Excess Rate", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
        flag = false;
      else
        CurrentUser.Instance.LogAction("Agreed to excess rate manual override.", this._quote.QuoteGuid);
    }
    else if (!((UltraToggleEditorBase) this.chkWaivePremiums).Checked && Decimal.Compare(d1_2, this.CalculateTerrorRate()) != 0)
    {
      int num = (int) MessageBox.Show($"The terrorism rate is not valid.  Expected {this.CalculateTerrorRate().ToString()}.", "Invalid Terrorism Rate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    return flag;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.IsValidForm())
    {
      if (!this.SaveData())
      {
        e.Cancel = true;
      }
      else
      {
        if (this._exposureID == -1)
          return;
        this.SetActiveRow();
      }
    }
    else
      e.Cancel = true;
  }

  private void SetActiveRow()
  {
    UltraGridRow ultraGridRow = ((UltraGridBase) this.dgLocations).GetRow((ChildRow) 0);
    while (ultraGridRow != null)
    {
      if (ultraGridRow.Band.Index == 1 && Conversions.ToInteger(ultraGridRow.Cells["ExposureID"].Value) == this._exposureID)
      {
        ((UltraGridBase) this.dgLocations).ActiveRow = ultraGridRow;
        ((UltraGridBase) this.dgLocations).ActiveRow.ParentRow.Expanded = true;
        break;
      }
      if (ultraGridRow.HasChild())
        ultraGridRow = ultraGridRow.GetChild((ChildRow) 0);
      else if (ultraGridRow.HasNextSibling())
        ultraGridRow = ultraGridRow.GetSibling((SiblingRow) 2);
      else if (ultraGridRow.Band.Index > 0)
      {
        for (; !ultraGridRow.HasNextSibling(); ultraGridRow = ultraGridRow.ParentRow)
        {
          if (ultraGridRow.Band.Index <= 0)
          {
            ultraGridRow = (UltraGridRow) null;
            break;
          }
        }
        if (ultraGridRow != null)
          ultraGridRow = ultraGridRow.GetSibling((SiblingRow) 2);
      }
      else
        ultraGridRow = (UltraGridRow) null;
    }
  }

  private bool DataHasChanged(dsPropertyRater_Exposure.tblPropertyExposureRow dr)
  {
    bool flag;
    if (dr.RowState == DataRowState.Modified)
    {
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) this.ds.tblPropertyExposure.Columns)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(column.ColumnName, "Selected", false) != 0)
          {
            object objectValue1 = RuntimeHelpers.GetObjectValue(dr[column.ColumnName, DataRowVersion.Original]);
            object objectValue2 = RuntimeHelpers.GetObjectValue(dr[column.ColumnName, DataRowVersion.Current]);
            if (!(!(Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue1)) & Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue2))) ? Microsoft.VisualBasic.CompilerServices.Operators.CompareString(objectValue1.ToString(), objectValue2.ToString(), false) == 0 : Decimal.Compare(Conversions.ToDecimal(objectValue1), Conversions.ToDecimal(objectValue2)) == 0))
            {
              flag = true;
              goto label_10;
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
    flag = false;
label_10:
    return flag;
  }

  private bool SaveData()
  {
    this.Cursor = MgaCursors.WaitCursor;
    this.bmb.EndCurrentEdit();
    bool flag1 = false;
    this._exposureID = -1;
    try
    {
      foreach (dsPropertyRater_Exposure.tblPropertyExposureRow dr in (TypedTableBase<dsPropertyRater_Exposure.tblPropertyExposureRow>) this.ds.tblPropertyExposure)
      {
        if (this.DataHasChanged(dr) && !dr.IsOriginalExposureIDNull())
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr.ModificationCode, "U", false) == 0)
            dr.ModificationCode = "M";
        }
        else if (dr.RowState == DataRowState.Added || dr.RowState == DataRowState.Modified)
        {
          flag1 = true;
          this._exposureID = dr.ExposureID;
          if (!dr.IsEffectiveDateNull() && (dr.EffectiveDate.Equals(DateTime.MaxValue) || dr.EffectiveDate.Equals(DateTime.MinValue)))
            dr.SetEffectiveDateNull();
        }
      }
    }
    finally
    {
      IEnumerator<dsPropertyRater_Exposure.tblPropertyExposureRow> enumerator;
      enumerator?.Dispose();
    }
    if (!flag1 && ((UltraGridBase) this.dgLocations).ActiveRow != null && ((UltraGridBase) this.dgLocations).ActiveRow.Band.Index > 0)
      this._exposureID = Conversions.ToInteger(((UltraGridBase) this.dgLocations).ActiveRow.Cells["ExposureID"].Value);
    try
    {
      foreach (dsPropertyRater_Exposure.tblPropertyExposureRow propertyExposureRow in (TypedTableBase<dsPropertyRater_Exposure.tblPropertyExposureRow>) this.ds.tblPropertyExposure)
      {
        if (propertyExposureRow.RowState == DataRowState.Modified)
        {
          try
          {
            foreach (DataColumn column in (InternalDataCollectionBase) this.ds.tblPropertyExposure.Columns)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(column.ColumnName, "Selected", false) != 0)
              {
                object objectValue1 = RuntimeHelpers.GetObjectValue(propertyExposureRow[column.ColumnName, DataRowVersion.Original]);
                object objectValue2 = RuntimeHelpers.GetObjectValue(propertyExposureRow[column.ColumnName, DataRowVersion.Current]);
                if (!(!(Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue1)) & Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue2))) ? Microsoft.VisualBasic.CompilerServices.Operators.CompareString(objectValue1.ToString(), objectValue2.ToString(), false) == 0 : Decimal.Compare(Conversions.ToDecimal(objectValue1), Conversions.ToDecimal(objectValue2)) == 0))
                  CurrentUser.Instance.LogAction($"Prop Rater: Changed {column.ColumnName} from {objectValue1.ToString()} to {objectValue2.ToString()} on exposure {propertyExposureRow.ExposureID.ToString()}", propertyExposureRow.ExposureID);
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
    }
    finally
    {
      IEnumerator<dsPropertyRater_Exposure.tblPropertyExposureRow> enumerator;
      enumerator?.Dispose();
    }
    MDIControls.Instance.StatusBarText = "Saving property exposures...";
    ((UltraControlBase) MDIControls.Instance.StatusBar).Refresh();
    bool flag2;
    try
    {
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daExposure, (DataTable) this.ds.tblPropertyExposure);
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      flag2 = false;
      ProjectData.ClearProjectError();
      goto label_36;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    if (!this._quote.IsBound)
      this.RefreshPremiums();
    ((UltraGridBase) this.dgLocations).Rows.ExpandAll(true);
    this.UpdateLocationPremiums();
    flag2 = true;
label_36:
    return flag2;
  }

  private void RefreshPremiums()
  {
    if (this._frmPleaseWait == null)
      this._frmPleaseWait = new frmPleaseWait();
    this._frmPleaseWait.ShowInTaskbar = false;
    this._frmPleaseWait.Show();
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.RefreshPremiumsThread));
  }

  [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
  private void RefreshPremiumsThread(object state)
  {
    try
    {
      this._propRater.RefreshPremiums(this._quoteOption);
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      if (this.IsHandleCreated && !this.IsDisposed && !this.Disposing)
      {
        this.Invoke((Delegate) new frmPropertyRater_Exposure.RefreshPremiumsErrorHandler(this.RefreshPremiumsError), (object) this, (object) new frmPropertyRater_Exposure.RefreshPremiumsErrorEventArgs(ex2));
        ProjectData.ClearProjectError();
        return;
      }
      ProjectData.ClearProjectError();
    }
    if (!this.IsHandleCreated || this.IsDisposed)
      return;
    if (this.Disposing)
      return;
    try
    {
      this.Invoke((Delegate) new frmPropertyRater_Exposure.RefreshPremiumsCompleteHandler(this.RefreshPremiumsComplete), (object) this, (object) EventArgs.Empty);
    }
    catch (NullReferenceException ex3)
    {
      ProjectData.SetProjectError((Exception) ex3);
      NullReferenceException ex4 = ex3;
      if (this.IsHandleCreated && !this.IsDisposed && !this.Disposing)
        this.Invoke((Delegate) new frmPropertyRater_Exposure.RefreshPremiumsErrorHandler(this.RefreshPremiumsError), (object) this, (object) new frmPropertyRater_Exposure.RefreshPremiumsErrorEventArgs((Exception) ex4));
      ProjectData.ClearProjectError();
    }
  }

  private void RefreshPremiumsError(
    object sender,
    frmPropertyRater_Exposure.RefreshPremiumsErrorEventArgs e)
  {
    if (this._frmPleaseWait != null)
      this._frmPleaseWait.Hide();
    ErrorHandler.HandleError(e.Ex);
  }

  private void RefreshPremiumsComplete(object sender, EventArgs e)
  {
    try
    {
      this.Rater.RateOption(this._quoteOption.QuoteOptionGuid);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this.Invoke((Delegate) new frmPropertyRater_Exposure.RefreshPremiumsErrorHandler(this.RefreshPremiumsError), (object) this, (object) new frmPropertyRater_Exposure.RefreshPremiumsErrorEventArgs((Exception) ex));
      ProjectData.ClearProjectError();
      return;
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this.Invoke((Delegate) new frmPropertyRater_Exposure.RefreshPremiumsErrorHandler(this.RefreshPremiumsError), (object) this, (object) new frmPropertyRater_Exposure.RefreshPremiumsErrorEventArgs((Exception) ex));
      ProjectData.ClearProjectError();
      return;
    }
    this._frmPleaseWait.Hide();
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.RejectChanges();
    this.ClearErrorValidators();
  }

  private void ClearErrorValidators()
  {
    try
    {
      foreach (Control control1 in this.Controls)
      {
        if (control1 is GroupBox)
        {
          try
          {
            foreach (Control control2 in control1.Controls)
              this.err.SetError(control2, string.Empty);
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
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

  private void OpenUnderwritingLocationsForm()
  {
    frmUnderwritingLocations formEx = (frmUnderwritingLocations) ObjectFactory.Instance.CreateFormEX(typeof (frmUnderwritingLocations), (object) this._quote.QuoteGuid, (object) true);
    try
    {
      int num = (int) formEx.ShowDialog();
    }
    finally
    {
      formEx.Dispose();
    }
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this.ds.EnforceConstraints = false;
      this.ds.tblUnderwritingLocations.Clear();
      this.daExposure.SelectCommand.Parameters["@ExposureID"].Value = (object) DBNull.Value;
      this.daExposure.SelectCommand.Parameters["@QuoteOptionID"].Value = (object) this._quoteOption.QuoteOptionID;
      this.ds.tblPropertyExposure.Clear();
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daExposure, (DataTable) this.ds.tblPropertyExposure);
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLocations, (DataTable) this.ds.tblUnderwritingLocations);
      this.UpdateLocationPremiums();
      this.ColorDeletedLocationRows();
      this.ds.EnforceConstraints = true;
      ((UltraGridBase) this.dgLocations).Rows.ExpandAll(true);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void lnkModifyLocations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.OpenUnderwritingLocationsForm();
  }

  private bool AcceptedDeleteWarning()
  {
    return MessageBox.Show("Are you sure you want to delete this exposure?", "Delete Exposure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes && (!this._quote.IsBound || MessageBox.Show("WARNING: This policy is bound.\n\nDo you still want to delete this exposure?", "Delete Exposure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes);
  }

  private UltraGridRow FindGridRowByExposureID(int exposureID)
  {
    UltraGridRow gridRowByExposureId;
    foreach (UltraGridRow row in ((UltraGridBase) this.dgLocations).Rows)
    {
      if (row.HasChild())
      {
        for (UltraGridRow ultraGridRow = row.GetChild((ChildRow) 0); ultraGridRow != null; ultraGridRow = ultraGridRow.GetSibling((SiblingRow) 2))
        {
          if ((int) ultraGridRow.Cells["ExposureID"].Value == exposureID)
          {
            gridRowByExposureId = ultraGridRow;
            goto label_9;
          }
        }
      }
    }
    gridRowByExposureId = (UltraGridRow) null;
label_9:
    return gridRowByExposureId;
  }

  private void DeleteExposure(dsPropertyRater_Exposure.tblPropertyExposureRow dr)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr.ModificationCode, "D", false) == 0)
      return;
    if (this._quote.IsEndorsement && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr.ModificationCode, "N", false) != 0)
    {
      IQuoteOption quoteOption = (IQuoteOption) new PropertyQuoteOption(this._quoteOption.QuoteOptionID);
      if (this._endorsementActionDate.Equals(DateTime.MinValue))
      {
        frmEndorsementActionDate endorsementActionDate = (frmEndorsementActionDate) FormSettings.ShowFormDialog(typeof (frmEndorsementActionDate), (object) quoteOption, (object) this._quote, (object) this.CalcType, (object) this._quote.EndorsementEffective);
        if (endorsementActionDate.Saved)
        {
          this._endorsementActionDate = endorsementActionDate.ActionDate;
          this._endorsementFactor = endorsementActionDate.Factor;
          this._factorOverridden = endorsementActionDate.FactorOverridden;
        }
      }
      dsPropertyRater_Exposure.tblPropertyExposureRow propertyExposureRow = dr;
      propertyExposureRow.ModificationCode = "D";
      propertyExposureRow.EffectiveDate = this._endorsementActionDate;
      propertyExposureRow.Factor = this._endorsementFactor;
      if (this._factorOverridden)
        propertyExposureRow.UserOverrideFactor = this._endorsementFactor;
      propertyExposureRow.TotalNonTerrorPremium = 0M;
      propertyExposureRow.PrimaryPremium = 0M;
      propertyExposureRow.ExcessPremium = 0M;
      propertyExposureRow.TerrPremium = 0M;
      propertyExposureRow.TerrorPrimary = 0M;
      propertyExposureRow.TerrorExcess = 0M;
      UltraGridRow gridRowByExposureId = this.FindGridRowByExposureID(dr.ExposureID);
      gridRowByExposureId.Appearance.ForeColor = Color.Red;
      gridRowByExposureId.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
    }
    else
      dr.Delete();
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this._quote.IsBound && !this._canDeleteExposureAfterBind)
    {
      int num = (int) MessageBox.Show("You do not have the required security to delete exposures after policy is bound.", "Security Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      if (this.ds.tblPropertyExposure.Count == 0 || this.bmb.Position == -1 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ds.tblPropertyExposure[this.bmb.Position].ModificationCode, "D", false) == 0)
        return;
      if (this.ds.tblPropertyExposure.Select("Selected=1").Length > 0 && MessageBox.Show("Multiple exposures are currently selected.\n\nWould you like to delete all of the selected exposures?", "Delete Multiple Exposures?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.DeleteMultipleExposures();
      }
      else
      {
        if (!this.AcceptedDeleteWarning())
          return;
        this.DeleteExposure(this.ds.tblPropertyExposure[this.bmb.Position]);
        bool flag = this.SaveData();
        this._endorsementActionDate = DateTime.MinValue;
        e.Cancel = !flag;
      }
    }
  }

  private void dgLocations_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (e.Row.Band.Index != 1)
      return;
    int num = (int) e.Row.Cells["ExposureID"].Value;
    if (this._lastExposureRowInitialized == num && !e.Row.Cells["ModificationCode"].Value.ToString().Equals("M") && !e.Row.Cells["ModificationCode"].Value.ToString().Equals("D"))
      return;
    this._lastExposureRowInitialized = num;
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

  private void lnkEffective_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.cboCalcType.Text.Length == 0)
    {
      int num = (int) MessageBox.Show("Please select an endorsment calculation type before proceeding.", "Calculation Type Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      frmEndorsementActionDate endorsementActionDate = (frmEndorsementActionDate) FormSettings.ShowFormDialog(typeof (frmEndorsementActionDate), (object) new PropertyQuoteOption(this._quoteOption.QuoteOptionID), (object) this._quote, (object) this.CalcType, (object) this._quote.EffectiveDate);
      if (endorsementActionDate.Saved && DateTime.Compare(this.ds.tblPropertyExposure[this.bmb.Position].EffectiveDate, endorsementActionDate.ActionDate) != 0)
      {
        dsPropertyRater_Exposure.tblPropertyExposureRow propertyExposureRow = this.ds.tblPropertyExposure[this.bmb.Position];
        propertyExposureRow.EffectiveDate = endorsementActionDate.ActionDate;
        propertyExposureRow.Factor = endorsementActionDate.Factor;
        if (endorsementActionDate.FactorOverridden)
          propertyExposureRow.UserOverrideFactor = endorsementActionDate.Factor;
      }
      endorsementActionDate.Dispose();
    }
  }

  private void numLimit_Enter(object sender, EventArgs e)
  {
    UltraNumericEditor ultraNumericEditor = (UltraNumericEditor) sender;
    if (ultraNumericEditor.Value == DBNull.Value || Conversions.ToDouble(ultraNumericEditor.Value) != 0.0)
      return;
    ultraNumericEditor.Value = (object) DBNull.Value;
  }

  private void numLimit_Leave(object sender, EventArgs e)
  {
    UltraNumericEditor ultraNumericEditor = (UltraNumericEditor) sender;
    if (ultraNumericEditor.Value != DBNull.Value)
      return;
    ultraNumericEditor.Value = (object) 0;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._strikeoutFont != null)
        this._strikeoutFont.Dispose();
      if (this._frmPleaseWait != null)
        this._frmPleaseWait.Dispose();
    }
    base.Dispose(disposing);
  }

  private Decimal CalculateTotalNonTerrorPremium()
  {
    Decimal nonTerrorPremium;
    if (this.numLimit.Value != DBNull.Value && this.numAccountRate.Value != DBNull.Value)
    {
      Decimal num = Decimal.Divide(Decimal.Multiply(Conversions.ToDecimal(this.numLimit.Value), Conversions.ToDecimal(this.numAccountRate.Value)), 100M);
      if (this._roundToDollar)
        num = new Decimal(Convert.ToInt32(num));
      nonTerrorPremium = num;
    }
    else
      nonTerrorPremium = 0M;
    return nonTerrorPremium;
  }

  private void lnkCalculateTotalNonTerror_LinkClicked(
    object sender,
    LinkLabelLinkClickedEventArgs e)
  {
    if (this.ds.tblPropertyExposure[this.bmb.Position].RowState == DataRowState.Deleted)
      return;
    Decimal nonTerrorPremium = this.CalculateTotalNonTerrorPremium();
    this.ds.tblPropertyExposure[this.bmb.Position].TotalNonTerrorPremium = nonTerrorPremium;
    if (Decimal.Compare(nonTerrorPremium, Conversions.ToDecimal(this.numTotalNonTerror.MaxValue)) > 0 || Decimal.Compare(nonTerrorPremium, Conversions.ToDecimal(this.numTotalNonTerror.MinValue)) < 0)
      return;
    this.numTotalNonTerror.Value = (object) nonTerrorPremium;
  }

  private Decimal CalculateExcessPremium()
  {
    Decimal excessPremium;
    if (this.numLimit.Value != DBNull.Value && this.numExcessRate.Value != DBNull.Value)
    {
      Decimal num = Decimal.Multiply(this.ds.tblPropertyExposure[this.bmb.Position].TotalNonTerrorPremium, Conversions.ToDecimal(this.numExcessRate.Value));
      if (this._roundToDollar)
        num = new Decimal(Convert.ToInt32(num));
      excessPremium = num;
    }
    else
      excessPremium = 0M;
    return excessPremium;
  }

  private void lnkCalcExcessPremium_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Decimal excessPremium = this.CalculateExcessPremium();
    this.ds.tblPropertyExposure[this.bmb.Position].ExcessPremium = excessPremium;
    this.numExcessPrem.Value = (object) excessPremium;
  }

  private Decimal CalculateExcessTerrorPremium()
  {
    Decimal excessTerrorPremium;
    if (this.numExcessRate.Value != DBNull.Value)
    {
      Decimal num = Decimal.Multiply(this.ds.tblPropertyExposure[this.bmb.Position].TerrPremium, Conversions.ToDecimal(this.numExcessRate.Value));
      if (this._roundToDollar)
        num = new Decimal(Convert.ToInt32(num));
      excessTerrorPremium = num;
    }
    else
      excessTerrorPremium = 0M;
    return excessTerrorPremium;
  }

  private void lnkCalcExcessTerror_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Decimal excessTerrorPremium = this.CalculateExcessTerrorPremium();
    this.ds.tblPropertyExposure[this.bmb.Position].TerrorExcess = excessTerrorPremium;
    this.numExcessTerror.Value = (object) excessTerrorPremium;
  }

  private Decimal CalculateTotalTerrorPremium()
  {
    Decimal totalTerrorPremium;
    if (this.numTerrRate.Value != DBNull.Value)
    {
      Decimal num = Decimal.Multiply(this.ds.tblPropertyExposure[this.bmb.Position].TotalNonTerrorPremium, Conversions.ToDecimal(this.numTerrRate.Value));
      if (this._roundToDollar)
        num = new Decimal(Convert.ToInt32(num));
      totalTerrorPremium = num;
    }
    else
      totalTerrorPremium = 0M;
    return totalTerrorPremium;
  }

  private void lnkCalcTotalTerrorPremium_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Decimal totalTerrorPremium = this.CalculateTotalTerrorPremium();
    this.ds.tblPropertyExposure[this.bmb.Position].TerrPremium = totalTerrorPremium;
    this.numTerrPrem.Value = (object) totalTerrorPremium;
  }

  private Decimal CalculateAccountRate()
  {
    Decimal accountRate;
    if (this.numTotalNonTerror.Value != DBNull.Value && this.numLimit.Value != DBNull.Value && Decimal.Compare(Conversions.ToDecimal(this.numLimit.Value), 0M) > 0)
    {
      Decimal num = Math.Round(Decimal.Multiply(Decimal.Divide(Conversions.ToDecimal(this.numTotalNonTerror.Value), Conversions.ToDecimal(this.numLimit.Value)), 100M), 4);
      if (Convert.ToDouble(num) <= 99.9999 && Convert.ToDouble(num) >= 0.0)
      {
        accountRate = num;
      }
      else
      {
        ((UltraNumericEditorBase) this.numAccountRate).Appearance.BackColor = Color.MistyRose;
        accountRate = 0M;
      }
    }
    else
      accountRate = 0M;
    return accountRate;
  }

  private void lnkCalcAccountRate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Decimal accountRate = this.CalculateAccountRate();
    this.ds.tblPropertyExposure[this.bmb.Position].AccountRate = accountRate;
    this.numAccountRate.Value = (object) accountRate;
  }

  private Decimal CalculateExcessRate()
  {
    Decimal excessRate;
    if (this.numExcessPrem.Value != DBNull.Value && this.numLimit.Value != DBNull.Value && Decimal.Compare(Conversions.ToDecimal(this.numLimit.Value), 0M) > 0 && this.numTotalNonTerror.Value != DBNull.Value)
    {
      if (Decimal.Compare(Conversions.ToDecimal(this.numTotalNonTerror.Value), 0M) == 0)
      {
        excessRate = 0M;
      }
      else
      {
        Decimal num = Math.Round(Decimal.Divide(Conversions.ToDecimal(this.numExcessPrem.Value), Conversions.ToDecimal(this.numTotalNonTerror.Value)), 4);
        if (Convert.ToDouble(num) <= 99.9999 && Convert.ToDouble(num) >= 0.0)
        {
          excessRate = num;
        }
        else
        {
          ((UltraNumericEditorBase) this.numExcessRate).Appearance.BackColor = Color.MistyRose;
          excessRate = 0M;
        }
      }
    }
    else
      excessRate = 0M;
    return excessRate;
  }

  private Decimal CalculateTerrorismExcessRate()
  {
    Decimal terrorismExcessRate;
    if (Decimal.Compare(Conversions.ToDecimal(this.numTerrPrem.Value), 0M) != 0 && this.numExcessTerror.Value != DBNull.Value && this.numLimit.Value != DBNull.Value && Decimal.Compare(Conversions.ToDecimal(this.numLimit.Value), 0M) > 0)
    {
      if (Decimal.Compare(Conversions.ToDecimal(this.numTotalNonTerror.Value), 0M) == 0)
      {
        terrorismExcessRate = 0M;
      }
      else
      {
        Decimal num = Math.Round(Decimal.Divide(Conversions.ToDecimal(this.numExcessTerror.Value), Conversions.ToDecimal(this.numTerrPrem.Value)), 4);
        if (Convert.ToDouble(num) <= 99.9999 && Convert.ToDouble(num) >= 0.0)
        {
          terrorismExcessRate = num;
        }
        else
        {
          ((UltraNumericEditorBase) this.numExcessRate).Appearance.BackColor = Color.MistyRose;
          terrorismExcessRate = 0M;
        }
      }
    }
    else
      terrorismExcessRate = 0M;
    return terrorismExcessRate;
  }

  private void lnkCalculateExcessRate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Decimal excessRate = this.CalculateExcessRate();
    this.ds.tblPropertyExposure[this.bmb.Position].ExcessRate = excessRate;
    this.numExcessRate.Value = (object) excessRate;
  }

  private Decimal CalculateTerrorRate()
  {
    Decimal terrorRate;
    if (this.numTerrPrem.Value != DBNull.Value && this.numLimit.Value != DBNull.Value && Decimal.Compare(Conversions.ToDecimal(this.numLimit.Value), 0M) > 0 && Decimal.Compare(Conversions.ToDecimal(this.numTotalNonTerror.Value), 0M) != 0)
    {
      Decimal num = Math.Round(Decimal.Divide(Conversions.ToDecimal(this.numTerrPrem.Value), Conversions.ToDecimal(this.numTotalNonTerror.Value)), 4);
      if (Convert.ToDouble(num) <= 99.9999 && Convert.ToDouble(num) >= 0.0)
      {
        terrorRate = num;
      }
      else
      {
        ((UltraNumericEditorBase) this.numTerrRate).Appearance.BackColor = Color.MistyRose;
        terrorRate = 0M;
      }
    }
    else
      terrorRate = 0M;
    return terrorRate;
  }

  private void lnkCalcTerrRate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Decimal terrorRate = this.CalculateTerrorRate();
    this.ds.tblPropertyExposure[this.bmb.Position].TerrRate = terrorRate;
    this.numTerrRate.Value = (object) terrorRate;
  }

  private void CalculatePrimaryPremium()
  {
    Decimal d1 = 0M;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numTotalNonTerror.Value)))
      d1 = Conversions.ToDecimal(this.numTotalNonTerror.Value);
    Decimal d2 = 0M;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numExcessPrem.Value)))
      d2 = Conversions.ToDecimal(this.numExcessPrem.Value);
    if (this.TerrorismDeclined)
      this.numPrimaryPrem.Value = (object) Decimal.Subtract(d1, d2);
    else
      this.numPrimaryPrem.Value = (object) Decimal.Subtract(d1, d2);
  }

  private void NonTerror_ValueChanged(object sender, EventArgs e)
  {
    if (!this._loaded)
      return;
    this.CalculatePrimaryPremium();
    if (this.numLimit.Value != DBNull.Value && Decimal.Compare(Conversions.ToDecimal(this.numLimit.Value), 0M) > 0)
    {
      Decimal d1_1 = 0M;
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numPrimaryPrem.Value)))
        d1_1 = Conversions.ToDecimal(this.numPrimaryPrem.Value);
      Decimal d1_2 = Decimal.Multiply(Decimal.Divide(d1_1, Conversions.ToDecimal(this.numLimit.Value)), 100M);
      if (Decimal.Compare(d1_2, Conversions.ToDecimal(this.numPrimaryPrem.MinValue)) >= 0 && Decimal.Compare(d1_2, Conversions.ToDecimal(this.numPrimaryPrem.MaxValue)) <= 0 && Decimal.Compare(d1_2, Conversions.ToDecimal(this.numPrimaryRate.MinValue)) > 0 && Decimal.Compare(d1_2, Conversions.ToDecimal(this.numPrimaryRate.MaxValue)) < 0)
        this.numPrimaryRate.Value = (object) d1_2;
    }
    this.ValidateNonTerrorRates();
  }

  private void Terror_ValueChanged(object sender, EventArgs e)
  {
    if (!this._loaded)
      return;
    Decimal d1_1 = 0M;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numTerrPrem.Value)))
      d1_1 = Conversions.ToDecimal(this.numTerrPrem.Value);
    Decimal d2 = 0M;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numExcessTerror.Value)))
      d2 = Conversions.ToDecimal(this.numExcessTerror.Value);
    Decimal d1_2 = 0M;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numPrimaryPrem.Value)))
      d1_2 = Conversions.ToDecimal(this.numPrimaryPrem.Value);
    this.numPrimaryTerror.Value = (object) Decimal.Subtract(d1_1, d2);
    if (this.TerrorismDeclined)
      this.numPrimaryPrem.Value = (object) d1_2;
    else
      this.numPrimaryPrem.Value = (object) Decimal.Subtract(d1_2, d2);
    this.CalculatePrimaryPremium();
    this.ValidateTerrorRate();
  }

  private void ValidateNonTerrorRates()
  {
    Decimal d1_1 = 0M;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numAccountRate.Value)))
      d1_1 = Conversions.ToDecimal(this.numAccountRate.Value);
    Decimal d1_2 = 0M;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numExcessRate.Value)))
      d1_2 = Conversions.ToDecimal(this.numExcessRate.Value);
    if (Decimal.Compare(d1_1, this.CalculateAccountRate()) != 0 && ((UltraNumericEditorBase) this.numAccountRate).BackColor == Color.White)
      ((UltraNumericEditorBase) this.numAccountRate).Appearance.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    else
      ((UltraNumericEditorBase) this.numAccountRate).Appearance.BackColor = Color.White;
    if (Decimal.Compare(d1_2, this.CalculateExcessRate()) != 0 && ((UltraNumericEditorBase) this.numTerrRate).BackColor == Color.White)
      ((UltraNumericEditorBase) this.numExcessRate).Appearance.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    else
      ((UltraNumericEditorBase) this.numExcessRate).Appearance.BackColor = Color.White;
  }

  private void ValidateTerrorRate()
  {
    Decimal d1 = 0M;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numTerrRate.Value)))
      d1 = Conversions.ToDecimal(this.numTerrRate.Value);
    if (Decimal.Compare(d1, this.CalculateTerrorRate()) != 0 && ((UltraNumericEditorBase) this.numTerrRate).Appearance.BackColor == Color.White)
      ((UltraNumericEditorBase) this.numTerrRate).Appearance.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    else
      ((UltraNumericEditorBase) this.numTerrRate).Appearance.BackColor = Color.White;
  }

  private void NonTerrorRates_ValueChanged(object sender, EventArgs e)
  {
    if (!this._loaded)
      return;
    this.ValidateNonTerrorRates();
  }

  private void numTerrRate_ValueChanged(object sender, EventArgs e)
  {
    if (!this._loaded)
      return;
    this.ValidateTerrorRate();
  }

  private void numLimit_ValueChanged(object sender, EventArgs e)
  {
    if (!this._loaded)
      return;
    this.ValidateNonTerrorRates();
  }

  private void linkDeleteAllSelected_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.DeleteMultipleExposures();
  }

  private void DeleteMultipleExposures()
  {
    bool flag = false;
    if (this.AcceptedDeleteWarning())
    {
      try
      {
        foreach (dsPropertyRater_Exposure.tblPropertyExposureRow dr in (TypedTableBase<dsPropertyRater_Exposure.tblPropertyExposureRow>) this.ds.tblPropertyExposure)
        {
          if ((bool) this.FindGridRowByExposureID(dr.ExposureID).Cells["Selected"].Value)
          {
            this.DeleteExposure(dr);
            flag = true;
          }
        }
      }
      finally
      {
        IEnumerator<dsPropertyRater_Exposure.tblPropertyExposureRow> enumerator;
        enumerator?.Dispose();
      }
    }
    this.SaveData();
    if (!flag)
    {
      int num = (int) MessageBox.Show("No exposure rows are currently selected.", "No Exposure Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      this._endorsementActionDate = DateTime.MinValue;
  }

  private void linkRestoreExposures_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    bool flag = false;
    List<int> intList = new List<int>();
    try
    {
      foreach (dsPropertyRater_Exposure.tblPropertyExposureRow propertyExposureRow in (TypedTableBase<dsPropertyRater_Exposure.tblPropertyExposureRow>) this.ds.tblPropertyExposure)
      {
        if (propertyExposureRow.Selected)
        {
          intList.Add(propertyExposureRow.ExposureID);
          flag = true;
        }
      }
    }
    finally
    {
      IEnumerator<dsPropertyRater_Exposure.tblPropertyExposureRow> enumerator;
      enumerator?.Dispose();
    }
    bool promptUser = true;
    try
    {
      foreach (int exposureID in intList)
      {
        this.RestoreExposure(exposureID, promptUser);
        promptUser = false;
      }
    }
    finally
    {
      List<int>.Enumerator enumerator;
      enumerator.Dispose();
    }
    if (flag)
      return;
    int num = (int) MessageBox.Show("No exposure rows are currently selected.", "No Exposure Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  private void RestoreExposure()
  {
    if (this.bmb.Position == -1)
    {
      int num = (int) MessageBox.Show("Please select a location in the grid which you would like to restore.", "No Location Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      this.RestoreExposure(this.ds.tblPropertyExposure[this.bmb.Position].ExposureID, true);
  }

  private void RestoreExposure(int exposureID, bool promptUser)
  {
    dsPropertyRater_Exposure.tblPropertyExposureRow byExposureId = this.ds.tblPropertyExposure.FindByExposureID(exposureID);
    string modificationCode = byExposureId.ModificationCode;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(modificationCode, "D", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(modificationCode, "M", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(modificationCode, "N", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(modificationCode, "U", false) != 0 || !promptUser)
          return;
        int num = (int) MessageBox.Show("This exposure is unchanged, and can not be restored.", "Unchanged Exposure", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        if (!promptUser)
          return;
        int num = (int) MessageBox.Show("This is a new exposure, and can not be restored to a prior version.", "Unchanged Exposure", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
    else
    {
      if ((!promptUser ? DialogResult.Yes : MessageBox.Show("Are you sure you want to restore this exposure?", "Restore Exposure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) != DialogResult.Yes)
        return;
      DefaultDatabase.ExecuteNonQuery("dbo.spRestorePropertyExposure", new object[2]
      {
        (object) "@exposureID",
        (object) exposureID
      });
      this.ds.tblPropertyExposure.RemovetblPropertyExposureRow(byExposureId);
      this.daExposure.SelectCommand.Parameters["@exposureID"].Value = (object) exposureID;
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daExposure, (DataTable) this.ds.tblPropertyExposure);
      this.daExposure.SelectCommand.Parameters["@exposureID"].Value = (object) null;
      if (this._quote.IsBound)
        return;
      this.RefreshPremiums();
    }
  }

  private void linkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      foreach (dsPropertyRater_Exposure.tblPropertyExposureRow propertyExposureRow in (TypedTableBase<dsPropertyRater_Exposure.tblPropertyExposureRow>) this.ds.tblPropertyExposure)
        propertyExposureRow.Selected = true;
    }
    finally
    {
      IEnumerator<dsPropertyRater_Exposure.tblPropertyExposureRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void linkUnselectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      foreach (dsPropertyRater_Exposure.tblPropertyExposureRow propertyExposureRow in (TypedTableBase<dsPropertyRater_Exposure.tblPropertyExposureRow>) this.ds.tblPropertyExposure)
        propertyExposureRow.Selected = false;
    }
    finally
    {
      IEnumerator<dsPropertyRater_Exposure.tblPropertyExposureRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void linkModifyFactorMulti_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.cboCalcType.Text.Length == 0)
    {
      int num = (int) MessageBox.Show("Please select an endorsment calculation type before proceeding.", "Calculation Type Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      frmEndorsementActionDate endorsementActionDate = (frmEndorsementActionDate) FormSettings.ShowFormDialog(typeof (frmEndorsementActionDate), (object) new PropertyQuoteOption(this._quoteOption.QuoteOptionID), (object) this._quote, (object) this.CalcType, (object) this.ds.tblPropertyExposure[this.bmb.Position].EffectiveDate);
      MDIControls.Instance.MDIParent.Refresh();
      if (!endorsementActionDate.Saved)
        return;
      try
      {
        foreach (dsPropertyRater_Exposure.tblPropertyExposureRow propertyExposureRow1 in (TypedTableBase<dsPropertyRater_Exposure.tblPropertyExposureRow>) this.ds.tblPropertyExposure)
        {
          if (propertyExposureRow1.Selected)
          {
            dsPropertyRater_Exposure.tblPropertyExposureRow propertyExposureRow2 = propertyExposureRow1;
            propertyExposureRow2.EffectiveDate = endorsementActionDate.ActionDate;
            propertyExposureRow2.Factor = endorsementActionDate.Factor;
            if (endorsementActionDate.FactorOverridden)
              propertyExposureRow2.UserOverrideFactor = endorsementActionDate.Factor;
          }
        }
      }
      finally
      {
        IEnumerator<dsPropertyRater_Exposure.tblPropertyExposureRow> enumerator;
        enumerator?.Dispose();
      }
      this.SaveData();
    }
  }

  private void linkPolicyExtension_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.Cursor = MgaCursors.WaitCursor;
    int num1 = this._quote.PreviousQuote.ExpirationDate.Subtract(this._quote.ExpirationDate).Days < 0 ? 1 : 0;
    this.Cursor = MgaCursors.Default;
    if (num1 != 0)
    {
      Form form;
      Decimal selectedFactor = ((FormExtensionTermFactor) (form = FormSettings.ShowFormDialog(typeof (FormExtensionTermFactor), (object) this.Rater.GetExtendedPolicyTermFactor()))).SelectedFactor;
      bool saved = ((FormExtensionTermFactor) form).Saved;
      form.Dispose();
      if (!saved)
        return;
      try
      {
        foreach (dsPropertyRater_Exposure.tblPropertyExposureRow propertyExposureRow in (TypedTableBase<dsPropertyRater_Exposure.tblPropertyExposureRow>) this.ds.tblPropertyExposure)
        {
          if (propertyExposureRow.Selected)
          {
            propertyExposureRow.UserOverrideFactor = selectedFactor;
            propertyExposureRow.EndorsementCalcType = "P";
          }
        }
      }
      finally
      {
        IEnumerator<dsPropertyRater_Exposure.tblPropertyExposureRow> enumerator;
        enumerator?.Dispose();
      }
      this.SaveData();
    }
    else
    {
      int num2 = (int) MessageBox.Show("The policy term of has not been extended from the prior transaction.", "Non-Extended Policy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void ToggleTerrorism(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show($"Are you sure you want to {(string) Interaction.IIf(sender == this.linkDeclineTerrorism, (object) "decline", (object) "include")} terrorism on this risk?", "Decline Terrorism?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteOptionProperty SET TerrorismDeclined = @terr WHERE QuoteOptionID=@QOID", new object[4]
    {
      (object) "@terr",
      (object) (sender == this.linkDeclineTerrorism),
      (object) "@QOID",
      (object) this._quoteOption.QuoteOptionID
    });
    this._terrorismDeclined = (object) null;
    this.SetupTerrorismDeclinedAppearance();
    this.SaveData();
  }

  private void SetupLimitTotal()
  {
    try
    {
      if (((UltraGridBase) this.dgLocations).Rows.Count <= 0)
        return;
      UltraGridBand band = ((UltraGridBase) this.dgLocations).DisplayLayout.Bands[1];
      band.Summaries.RemoveAt(3);
      band.Summaries.Add("Limit", (SummaryType) 5, (ICustomSummaryCalculator) new frmPropertyRater_Exposure.LimitSummary(), band.Columns["Limit"], (SummaryPosition) 3, band.Columns["Limit"]);
      band.Summaries["Limit"].DisplayFormat = "{0:c}";
      band.Override.SummaryValueAppearance.TextHAlign = (HAlign) 3;
      band.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void frmPropertyRater_Exposure_FormClosing(object sender, FormClosingEventArgs e)
  {
    try
    {
      foreach (dsPropertyRater_Exposure.tblUnderwritingLocationsRow underwritingLocation in (TypedTableBase<dsPropertyRater_Exposure.tblUnderwritingLocationsRow>) this.ds.tblUnderwritingLocations)
      {
        if (underwritingLocation.GettblPropertyExposureRows().Length != 0)
        {
          int length1 = this.ds.tblPropertyExposure.Select($"LocationID={underwritingLocation.LocationID.ToString()} AND ModificationCode='D'").Length;
          int length2 = this.ds.tblPropertyExposure.Select("LocationID=" + underwritingLocation.LocationID.ToString()).Length;
          if (length1 == length2 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(underwritingLocation.ModificationCode, "D", false) != 0)
          {
            if (MessageBox.Show("WARNING:\n\nOne or more locations have all exposure deleted, but the location is not deleted.\n\nAre you sure you want to close the exposure screen?", "Deleted Exposure Mismatch", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
              CurrentUser.Instance.LogAction("Accepted undeleted location with all deleted exposures warning.", this._quote.ControlGuid);
              break;
            }
            e.Cancel = true;
            return;
          }
          if (length1 != length2 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(underwritingLocation.ModificationCode, "D", false) == 0)
          {
            if (MessageBox.Show("WARNING:\n\nOne or more locations are deleted, but have undeleted exposure on them.\n\nAre you sure you want to close the exposure screen?", "Deleted Exposure Mismatch", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
              CurrentUser.Instance.LogAction("Accepted undeleted exposure on a deleted location warning.", this._quote.ControlGuid);
              break;
            }
            e.Cancel = true;
            return;
          }
        }
      }
    }
    finally
    {
      IEnumerator<dsPropertyRater_Exposure.tblUnderwritingLocationsRow> enumerator;
      enumerator?.Dispose();
    }
    if (e.Cancel)
      return;
    this.ExposureFormClosing();
  }

  protected virtual void ExposureFormClosing()
  {
  }

  private void lnkExportSchedule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.Cursor = MgaCursors.WaitCursor;
    DataTable source = DefaultDatabase.ExecuteDataTable("rptLocationSchedule", new object[2]
    {
      (object) "@QuoteOptionGuid",
      (object) this._quoteOption.QuoteOptionGuid
    });
    string str = $"{MGATempFolder.MGATempPath}LocationSched.csv";
    int num = 0;
    for (; File.Exists(str); str = $"{MGATempFolder.MGATempPath}LocationSched_{num}.csv")
      checked { ++num; }
    ExcelExport.ToExcel(source, str);
    Process.Start(str);
    this.Cursor = MgaCursors.Default;
  }

  private delegate void FillDataThreadCompleteHandler(object sender, EventArgs e);

  private class RefreshPremiumsErrorEventArgs : EventArgs
  {
    private Exception _ex;

    public Exception Ex => this._ex;

    public RefreshPremiumsErrorEventArgs(Exception ex) => this._ex = ex;
  }

  private delegate void RefreshPremiumsCompleteHandler(object sender, EventArgs e);

  private delegate void RefreshPremiumsErrorHandler(
    object sender,
    frmPropertyRater_Exposure.RefreshPremiumsErrorEventArgs e);

  private sealed class LimitSummary : ICustomSummaryCalculator
  {
    private Decimal _sumLimit;

    public LimitSummary() => this._sumLimit = 0M;

    void ICustomSummaryCalculator.AggregateCustomSummary(
      SummarySettings summarySettings,
      UltraGridRow row)
    {
      if (row.Cells["ModificationCode"].Value.ToString().Equals("D") || row.Cells["Limit"].Value == null || row.Cells["Limit"].Value == DBNull.Value)
        return;
      // ISSUE: variable of a reference type
      Decimal& local;
      // ISSUE: explicit reference operation
      Decimal num = Decimal.Add(^(local = ref this._sumLimit), Conversions.ToDecimal(row.Cells["Limit"].Value));
      local = num;
    }

    void ICustomSummaryCalculator.BeginCustomSummary(
      SummarySettings summarySettings,
      RowsCollection rows)
    {
      this._sumLimit = 0M;
    }

    object ICustomSummaryCalculator.EndCustomSummary(
      SummarySettings summarySettings,
      RowsCollection rows)
    {
      return (object) this._sumLimit.ToString("c");
    }
  }
}

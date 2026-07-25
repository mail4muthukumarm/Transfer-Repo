// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.GL.frmGLRater_Exposure
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.InsuredsProducersCompanies.Companies;
using MGASystems.IMS.Policies.Rating.Classes;
using MGASystems.IMS.Policies.Rating.Endorsements;
using MGASystems.IMS.Policies.Rating.Locations;
using MGASystems.Tools;
using MGASystems.Tools.BaseClasses;
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
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating.GL;

public class frmGLRater_Exposure : MGABaseForm
{
  private IContainer components;
  private SqlConnection cn;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private MGANumericEditor UltraNumericEditor1;
  private MGANumericEditor UltraNumericEditor2;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label Label10;
  private UltraGroupBox GroupBox2;
  private UltraGroupBox GroupBox3;
  private MGANumericEditor UltraNumericEditor7;
  private MGANumericEditor UltraNumericEditor8;
  private SqlDataAdapter daExposure;
  private dsGLRaterExposure ds;
  private ErrorProvider err;
  private Label Label11;
  private Label lblOptionID;
  private Label Label12;
  private UltraLabel lblTotalPremium;
  private Label Label13;
  private MGASimpleComboBox cboClientOffices;
  private Label Label15;
  private Label Label16;
  private UltraLabel lblFactor;
  private MGASimpleComboBox cboCalcType;
  private Label Label17;
  private UltraDropDown ddClassCodes;
  private SqlCommand SqlSelectCommand3;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private UltraToolbarsDockArea _frmPropertyRater_Exposure_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _frmPropertyRater_Exposure_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmPropertyRater_Exposure_Toolbars_Dock_Area_Right;
  private SqlCommand SqlSelectCommand1;
  private SqlDataAdapter daLoadData;
  private MGASimpleComboBox cboExposureUnits;
  private readonly QuoteOption _quoteOption;
  private readonly Quote _quote;
  private readonly GLRater _glRater;
  private Font _strikeoutFont;
  private object _terrorismDeclined;

  private virtual UltraGrid dgLocations
  {
    get => this._dgLocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dgLocations_AfterRowActivate);
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.dgLocations_MouseDown);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.dgLocations_InitializeRow);
      UltraGrid dgLocations1 = this._dgLocations;
      if (dgLocations1 != null)
      {
        dgLocations1.AfterRowActivate -= eventHandler;
        ((Control) dgLocations1).MouseDown -= mouseEventHandler;
        dgLocations1.InitializeRow -= initializeRowEventHandler;
      }
      this._dgLocations = value;
      UltraGrid dgLocations2 = this._dgLocations;
      if (dgLocations2 == null)
        return;
      dgLocations2.AfterRowActivate += eventHandler;
      ((Control) dgLocations2).MouseDown += mouseEventHandler;
      dgLocations2.InitializeRow += initializeRowEventHandler;
    }
  }

  private virtual MGASimpleComboBox cboClassCodes
  {
    get => this._cboClassCodes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboClassCodes_ValueChanged);
      MGASimpleComboBox cboClassCodes1 = this._cboClassCodes;
      if (cboClassCodes1 != null)
        cboClassCodes1.ValueChanged -= eventHandler;
      this._cboClassCodes = value;
      MGASimpleComboBox cboClassCodes2 = this._cboClassCodes;
      if (cboClassCodes2 == null)
        return;
      cboClassCodes2.ValueChanged += eventHandler;
    }
  }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingEdit);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedCancel -= eventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler1;
        dbSave1.UIStateChanged -= eventHandler2;
        dbSave1.ClickingNew -= cancelEventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler3;
        dbSave1.ClickingEdit -= cancelEventHandler4;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedCancel += eventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler1;
      dbSave2.UIStateChanged += eventHandler2;
      dbSave2.ClickingNew += cancelEventHandler2;
      dbSave2.ClickingSave += cancelEventHandler3;
      dbSave2.ClickingEdit += cancelEventHandler4;
    }
  }

  private virtual MGANumericEditor numTerrPrem
  {
    get => this._numTerrPrem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.UpdatePremiumValues);
      MGANumericEditor numTerrPrem1 = this._numTerrPrem;
      if (numTerrPrem1 != null)
        ((UltraNumericEditorBase) numTerrPrem1).ValueChanged -= eventHandler;
      this._numTerrPrem = value;
      MGANumericEditor numTerrPrem2 = this._numTerrPrem;
      if (numTerrPrem2 == null)
        return;
      ((UltraNumericEditorBase) numTerrPrem2).ValueChanged += eventHandler;
    }
  }

  private virtual MGANumericEditor numPremisesPrem
  {
    get => this._numPremisesPrem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.UpdatePremiumValues);
      MGANumericEditor numPremisesPrem1 = this._numPremisesPrem;
      if (numPremisesPrem1 != null)
        ((UltraNumericEditorBase) numPremisesPrem1).ValueChanged -= eventHandler;
      this._numPremisesPrem = value;
      MGANumericEditor numPremisesPrem2 = this._numPremisesPrem;
      if (numPremisesPrem2 == null)
        return;
      ((UltraNumericEditorBase) numPremisesPrem2).ValueChanged += eventHandler;
    }
  }

  private virtual MGANumericEditor numProdPrem
  {
    get => this._numProdPrem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.UpdatePremiumValues);
      MGANumericEditor numProdPrem1 = this._numProdPrem;
      if (numProdPrem1 != null)
        ((UltraNumericEditorBase) numProdPrem1).ValueChanged -= eventHandler;
      this._numProdPrem = value;
      MGANumericEditor numProdPrem2 = this._numProdPrem;
      if (numProdPrem2 == null)
        return;
      ((UltraNumericEditorBase) numProdPrem2).ValueChanged += eventHandler;
    }
  }

  private virtual LinkLabel lnkModifyLocations
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

  [field: AccessedThroughProperty("numTerrorismRate")]
  private virtual MGANumericEditor numTerrorismRate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gbExposureInformation")]
  private virtual UltraGroupBox gbExposureInformation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  private virtual LinkLabel lnkClassCodes
  {
    get => this._lnkClassCodes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkClassCodes_LinkClicked);
      LinkLabel lnkClassCodes1 = this._lnkClassCodes;
      if (lnkClassCodes1 != null)
        lnkClassCodes1.LinkClicked -= clickedEventHandler;
      this._lnkClassCodes = value;
      LinkLabel lnkClassCodes2 = this._lnkClassCodes;
      if (lnkClassCodes2 == null)
        return;
      lnkClassCodes2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkCompanyClassCodes
  {
    get => this._lnkCompanyClassCodes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCompanyClassCodes_LinkClicked);
      LinkLabel companyClassCodes1 = this._lnkCompanyClassCodes;
      if (companyClassCodes1 != null)
        companyClassCodes1.LinkClicked -= clickedEventHandler;
      this._lnkCompanyClassCodes = value;
      LinkLabel companyClassCodes2 = this._lnkCompanyClassCodes;
      if (companyClassCodes2 == null)
        return;
      companyClassCodes2.LinkClicked += clickedEventHandler;
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblUnderwritingLocations", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LocationNo");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("BuildingNo");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("PhysicalBuildingNo");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Address");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Zip");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("tblUnderwritingLocationstblGLExposures");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblUnderwritingLocationstblGLExposures", 0);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ExposureID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("OriginalExposureID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("QuoteOptionID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ClassCodeID");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Exposure");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("ExposureUnit");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("PremRate");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ProdRate");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("TerrRate");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("CombinedRate");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("PremPremium");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("ProdPremium");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("TerrPremium");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("TotalPremium");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("UserAdded");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("ModificationCode");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("EndorsementCalcType");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("Factor");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("UserOverrideFactor");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
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
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstClassCodes", -1);
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("ClassCode");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("ClassCodeDescription");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("Access");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("GLExposureUnit");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("ClassCodeID");
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("ContextMenu");
    ButtonTool buttonTool1 = new ButtonTool("Restore Location");
    Appearance appearance41 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmGLRater_Exposure));
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("ContextMenu");
    ButtonTool buttonTool2 = new ButtonTool("Restore Location");
    this.dgLocations = new UltraGrid();
    this.ds = new dsGLRaterExposure();
    this.cn = new SqlConnection();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.cboClassCodes = new MGASimpleComboBox();
    this.UltraNumericEditor1 = new MGANumericEditor();
    this.UltraNumericEditor2 = new MGANumericEditor();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.gbExposureInformation = new UltraGroupBox();
    this.lnkEffective = new LinkLabel();
    this.Label17 = new Label();
    this.lblFactor = new UltraLabel();
    this.Label16 = new Label();
    this.Label15 = new Label();
    this.cboCalcType = new MGASimpleComboBox();
    this.Label13 = new Label();
    this.cboClientOffices = new MGASimpleComboBox();
    this.cboExposureUnits = new MGASimpleComboBox();
    this.GroupBox2 = new UltraGroupBox();
    this.numTerrorismRate = new MGANumericEditor();
    this.UltraNumericEditor8 = new MGANumericEditor();
    this.UltraNumericEditor7 = new MGANumericEditor();
    this.GroupBox3 = new UltraGroupBox();
    this.lblTotalPremium = new UltraLabel();
    this.Label12 = new Label();
    this.numTerrPrem = new MGANumericEditor();
    this.numPremisesPrem = new MGANumericEditor();
    this.numProdPrem = new MGANumericEditor();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.daExposure = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand3 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.err = new ErrorProvider(this.components);
    this.Label11 = new Label();
    this.lblOptionID = new Label();
    this.lnkModifyLocations = new LinkLabel();
    this.ddClassCodes = new UltraDropDown();
    this.lnkClassCodes = new LinkLabel();
    this.lnkCompanyClassCodes = new LinkLabel();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.lnkAddMiscPremiums = new LinkLabel();
    this.daLoadData = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    ((ISupportInitialize) this.dgLocations).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboClassCodes).BeginInit();
    ((ISupportInitialize) this.UltraNumericEditor1).BeginInit();
    ((ISupportInitialize) this.UltraNumericEditor2).BeginInit();
    ((ISupportInitialize) this.gbExposureInformation).BeginInit();
    ((Control) this.gbExposureInformation).SuspendLayout();
    ((ISupportInitialize) this.cboCalcType).BeginInit();
    ((ISupportInitialize) this.cboClientOffices).BeginInit();
    ((ISupportInitialize) this.cboExposureUnits).BeginInit();
    ((ISupportInitialize) this.GroupBox2).BeginInit();
    ((Control) this.GroupBox2).SuspendLayout();
    ((ISupportInitialize) this.numTerrorismRate).BeginInit();
    ((ISupportInitialize) this.UltraNumericEditor8).BeginInit();
    ((ISupportInitialize) this.UltraNumericEditor7).BeginInit();
    ((ISupportInitialize) this.GroupBox3).BeginInit();
    ((Control) this.GroupBox3).SuspendLayout();
    ((ISupportInitialize) this.numTerrPrem).BeginInit();
    ((ISupportInitialize) this.numPremisesPrem).BeginInit();
    ((ISupportInitialize) this.numProdPrem).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ddClassCodes).BeginInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((Control) this.dgLocations).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.dgLocations, "ContextMenu");
    ((UltraGridBase) this.dgLocations).DataSource = (object) this.ds.tblUnderwritingLocations;
    appearance1.BackColor = Color.White;
    appearance1.BackColorAlpha = (Alpha) 1;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgLocations).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgLocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 60;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Center";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Location #";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 79;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Center";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Building #";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 102;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Center";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Physical #";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 112 /*0x70*/;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 102;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 102;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 102;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 102;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridBand1.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ultraGridColumn10.Header.VisiblePosition = 0;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 13;
    ultraGridColumn11.Header.VisiblePosition = 1;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 38;
    ultraGridColumn12.Header.VisiblePosition = 2;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 31 /*0x1F*/;
    ultraGridColumn13.Header.VisiblePosition = 3;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 24;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Class";
    ultraGridColumn14.Header.VisiblePosition = 4;
    ultraGridColumn14.Width = 99;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance7;
    ultraGridColumn15.Format = "c";
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance8;
    ultraGridColumn15.Header.VisiblePosition = 5;
    ultraGridColumn15.Width = 73;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Exposure Unit";
    ultraGridColumn16.Header.VisiblePosition = 6;
    ultraGridColumn16.Width = 116;
    ultraGridColumn17.Header.VisiblePosition = 7;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 27;
    ultraGridColumn18.Header.VisiblePosition = 8;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 27;
    ultraGridColumn19.Header.VisiblePosition = 9;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 27;
    ultraGridColumn20.Header.VisiblePosition = 10;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 30;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ultraGridColumn21.CellAppearance = (AppearanceBase) appearance9;
    ultraGridColumn21.Format = "c";
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn21.Header).Appearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Premises";
    ultraGridColumn21.Header.VisiblePosition = 11;
    ultraGridColumn21.Width = 101;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ultraGridColumn22.CellAppearance = (AppearanceBase) appearance11;
    ultraGridColumn22.Format = "c";
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn22.Header).Appearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Products";
    ultraGridColumn22.Header.VisiblePosition = 12;
    ultraGridColumn22.Width = 98;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ultraGridColumn23.CellAppearance = (AppearanceBase) appearance13;
    ultraGridColumn23.Format = "c";
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn23.Header).Appearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridColumn23.Header).Caption = "Terrorism";
    ultraGridColumn23.Header.VisiblePosition = 13;
    ultraGridColumn23.Width = 94;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ultraGridColumn24.CellAppearance = (AppearanceBase) appearance15;
    ultraGridColumn24.Format = "c";
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn24.Header).Appearance = (AppearanceBase) appearance16;
    ((HeaderBase) ultraGridColumn24.Header).Caption = "Total";
    ultraGridColumn24.Header.VisiblePosition = 14;
    ultraGridColumn24.Width = 101;
    ultraGridColumn25.Header.VisiblePosition = 15;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 79;
    ultraGridColumn26.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 20;
    ((HeaderBase) ultraGridColumn27.Header).Caption = "Mod";
    ultraGridColumn27.Header.VisiblePosition = 17;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 34;
    ultraGridColumn28.Header.VisiblePosition = 18;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 43;
    ultraGridColumn29.Header.VisiblePosition = 19;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 30;
    ultraGridColumn30.Header.VisiblePosition = 20;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 27;
    ultraGridColumn31.Header.VisiblePosition = 21;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 38;
    ultraGridBand2.Columns.AddRange(new object[22]
    {
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
    ((UltraGridBase) this.dgLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgLocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance17.BackColor = Color.LightSteelBlue;
    appearance17.FontData.SizeInPoints = 10f;
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.dgLocations).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance18.ForeColor = Color.Black;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance19.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance19;
    appearance20.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance21.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance21;
    appearance22.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance23.BackColor = Color.Transparent;
    appearance23.ForeColor = Color.Black;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance23;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgLocations).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgLocations).Location = new Point(10, 32 /*0x20*/);
    ((Control) this.dgLocations).Name = "dgLocations";
    ((Control) this.dgLocations).Size = new Size(722, 270);
    ((Control) this.dgLocations).TabIndex = 0;
    ((Control) this.dgLocations).Text = "Locations on this Policy";
    ((UltraControlBase) this.dgLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgLocations).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsGLRaterExposure";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cn.ConnectionString = "workstation id=PSARNOWSKI2;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(9, 50);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(60, 13);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Class Code";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(9, 74);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(52, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Exposure";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(9, 97);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(74, 13);
    this.Label3.TabIndex = 3;
    this.Label3.Text = "Exposure Unit";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(13, 26);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(75, 13);
    this.Label4.TabIndex = 4;
    this.Label4.Text = "Products Rate";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(13, 49);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(75, 13);
    this.Label5.TabIndex = 5;
    this.Label5.Text = "Premises Rate";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.cboClassCodes.BorderStyle = (UIElementBorderStyle) 4;
    this.cboClassCodes.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboClassCodes).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGLExposures.ClassCodeID", true));
    ((UltraGridBase) this.cboClassCodes).DataSource = (object) this.ds.lstClassCodes;
    ((UltraDropDownBase) this.cboClassCodes).DisplayMember = "ClassCodeDescription";
    this.cboClassCodes.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboClassCodes.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboClassCodes).DropDownWidth = 300;
    ((Control) this.cboClassCodes).Location = new Point(88, 46);
    this.cboClassCodes.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboClassCodes).Name = "cboClassCodes";
    ((Control) this.cboClassCodes).Size = new Size(176 /*0xB0*/, 21);
    ((Control) this.cboClassCodes).TabIndex = 6;
    ((UltraControlBase) this.cboClassCodes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboClassCodes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboClassCodes).ValueMember = "ClassCodeID";
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.UltraNumericEditor1).Appearance = (AppearanceBase) appearance24;
    ((Control) this.UltraNumericEditor1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGLExposures.Exposure", true));
    ((UltraNumericEditorBase) this.UltraNumericEditor1).FormatString = "d";
    ((Control) this.UltraNumericEditor1).Location = new Point(88, 70);
    this.UltraNumericEditor1.MaxValue = (object) 999999999;
    this.UltraNumericEditor1.MGAStyle = MGAStyles.Blue;
    this.UltraNumericEditor1.MinValue = (object) 0;
    ((Control) this.UltraNumericEditor1).Name = "UltraNumericEditor1";
    ((Control) this.UltraNumericEditor1).Size = new Size(102, 20);
    ((Control) this.UltraNumericEditor1).TabIndex = 8;
    ((UltraControlBase) this.UltraNumericEditor1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraNumericEditor1).UseOsThemes = (DefaultableBoolean) 2;
    appearance25.BackColorDisabled = Color.WhiteSmoke;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance25).TextHAlignAsString = "Right";
    ((UltraNumericEditorBase) this.UltraNumericEditor2).Appearance = (AppearanceBase) appearance25;
    ((Control) this.UltraNumericEditor2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGLExposures.PremRate", true));
    ((UltraNumericEditorBase) this.UltraNumericEditor2).FormatString = "c";
    ((Control) this.UltraNumericEditor2).Location = new Point(104, 45);
    this.UltraNumericEditor2.MaxValue = (object) 10000;
    this.UltraNumericEditor2.MGAStyle = MGAStyles.Blue;
    this.UltraNumericEditor2.MinValue = (object) 0;
    ((Control) this.UltraNumericEditor2).Name = "UltraNumericEditor2";
    this.UltraNumericEditor2.NumericType = (NumericType) 1;
    ((Control) this.UltraNumericEditor2).Size = new Size(72, 20);
    ((Control) this.UltraNumericEditor2).TabIndex = 9;
    ((UltraControlBase) this.UltraNumericEditor2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraNumericEditor2).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(13, 72);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(80 /*0x50*/, 13);
    this.Label6.TabIndex = 10;
    this.Label6.Text = "Combined Rate";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(13, 95);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(78, 13);
    this.Label7.TabIndex = 11;
    this.Label7.Text = "Terrorism Rate";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(13, 26);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(92, 13);
    this.Label8.TabIndex = 12;
    this.Label8.Text = "Products Premium";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(13, 49);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(92, 13);
    this.Label9.TabIndex = 13;
    this.Label9.Text = "Premises Premium";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(13, 72);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(95, 13);
    this.Label10.TabIndex = 14;
    this.Label10.Text = "Terrorism Premium";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.gbExposureInformation).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance26.BackColor = Color.Transparent;
    this.gbExposureInformation.Appearance = (AppearanceBase) appearance26;
    appearance27.AlphaLevel = (short) 150;
    appearance27.BackColor = Color.GhostWhite;
    appearance27.BackColorDisabled = Color.WhiteSmoke;
    appearance27.BorderAlpha = (Alpha) 2;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gbExposureInformation.ContentAreaAppearance = (AppearanceBase) appearance27;
    ((Control) this.gbExposureInformation).Controls.Add((Control) this.lnkEffective);
    ((Control) this.gbExposureInformation).Controls.Add((Control) this.Label17);
    ((Control) this.gbExposureInformation).Controls.Add((Control) this.lblFactor);
    ((Control) this.gbExposureInformation).Controls.Add((Control) this.Label16);
    ((Control) this.gbExposureInformation).Controls.Add((Control) this.Label15);
    ((Control) this.gbExposureInformation).Controls.Add((Control) this.cboCalcType);
    ((Control) this.gbExposureInformation).Controls.Add((Control) this.Label13);
    ((Control) this.gbExposureInformation).Controls.Add((Control) this.cboClientOffices);
    ((Control) this.gbExposureInformation).Controls.Add((Control) this.Label1);
    ((Control) this.gbExposureInformation).Controls.Add((Control) this.UltraNumericEditor1);
    ((Control) this.gbExposureInformation).Controls.Add((Control) this.cboClassCodes);
    ((Control) this.gbExposureInformation).Controls.Add((Control) this.Label2);
    ((Control) this.gbExposureInformation).Controls.Add((Control) this.Label3);
    ((Control) this.gbExposureInformation).Controls.Add((Control) this.cboExposureUnits);
    ((Control) this.gbExposureInformation).Enabled = false;
    appearance28.ForeColor = Color.Navy;
    this.gbExposureInformation.HeaderAppearance = (AppearanceBase) appearance28;
    ((Control) this.gbExposureInformation).Location = new Point(10, 310);
    ((Control) this.gbExposureInformation).Name = "gbExposureInformation";
    ((Control) this.gbExposureInformation).Size = new Size(287, 200);
    ((Control) this.gbExposureInformation).TabIndex = 16 /*0x10*/;
    this.gbExposureInformation.Text = "Exposure Information";
    this.lnkEffective.AutoSize = true;
    this.lnkEffective.BackColor = Color.Transparent;
    this.lnkEffective.DataBindings.Add(new Binding("Text", (object) this.ds, "tblGLExposures.EffectiveDate", true));
    this.lnkEffective.Location = new Point(88, 168);
    this.lnkEffective.Name = "lnkEffective";
    this.lnkEffective.Size = new Size(39, 13);
    this.lnkEffective.TabIndex = 18;
    this.lnkEffective.TabStop = true;
    this.lnkEffective.Text = "1/1/01";
    this.lnkEffective.TextAlign = ContentAlignment.MiddleLeft;
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(9, 168);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(50, 13);
    this.Label17.TabIndex = 17;
    this.Label17.Text = "Effective";
    this.Label17.TextAlign = ContentAlignment.MiddleRight;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblFactor).Appearance = (AppearanceBase) appearance29;
    ((ControlBase) this.lblFactor).BackColorInternal = Color.WhiteSmoke;
    this.lblFactor.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblFactor).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGLExposures.Factor", true));
    ((Control) this.lblFactor).Location = new Point(88, 141);
    ((Control) this.lblFactor).Name = "lblFactor";
    ((Control) this.lblFactor).Size = new Size(102, 21);
    ((Control) this.lblFactor).TabIndex = 16 /*0x10*/;
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(9, 144 /*0x90*/);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(38, 13);
    this.Label16.TabIndex = 15;
    this.Label16.Text = "Factor";
    this.Label16.TextAlign = ContentAlignment.MiddleRight;
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(9, 120);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(54, 13);
    this.Label15.TabIndex = 13;
    this.Label15.Text = "Calc Type";
    this.Label15.TextAlign = ContentAlignment.MiddleRight;
    this.cboCalcType.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCalcType.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboCalcType).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGLExposures.EndorsementCalcType", true));
    ((UltraGridBase) this.cboCalcType).DataSource = (object) this.ds.lstEndorsementCalculationTypes;
    ((UltraDropDownBase) this.cboCalcType).DisplayMember = "EndorsementCalcType";
    this.cboCalcType.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboCalcType.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCalcType).DropDownWidth = 300;
    ((Control) this.cboCalcType).Location = new Point(88, 117);
    this.cboCalcType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCalcType).Name = "cboCalcType";
    ((Control) this.cboCalcType).Size = new Size(176 /*0xB0*/, 21);
    ((Control) this.cboCalcType).TabIndex = 14;
    ((UltraControlBase) this.cboCalcType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCalcType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCalcType).ValueMember = "ID";
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(9, 26);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(36, 13);
    this.Label13.TabIndex = 9;
    this.Label13.Text = "Office";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    this.cboClientOffices.BorderStyle = (UIElementBorderStyle) 4;
    this.cboClientOffices.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboClientOffices).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGLExposures.OfficeID", true));
    ((UltraGridBase) this.cboClientOffices).DataSource = (object) this.ds.tblClientOffices;
    ((UltraDropDownBase) this.cboClientOffices).DisplayMember = "Location";
    this.cboClientOffices.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboClientOffices.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboClientOffices).DropDownWidth = 300;
    ((Control) this.cboClientOffices).Location = new Point(88, 22);
    this.cboClientOffices.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboClientOffices).Name = "cboClientOffices";
    ((Control) this.cboClientOffices).Size = new Size(176 /*0xB0*/, 21);
    ((Control) this.cboClientOffices).TabIndex = 10;
    ((UltraControlBase) this.cboClientOffices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboClientOffices).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboClientOffices).ValueMember = "OfficeID";
    this.cboExposureUnits.BorderStyle = (UIElementBorderStyle) 4;
    this.cboExposureUnits.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboExposureUnits).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGLExposures.ExposureUnit", true));
    ((UltraGridBase) this.cboExposureUnits).DataSource = (object) this.ds.lstGLExposureUnit;
    ((UltraDropDownBase) this.cboExposureUnits).DisplayMember = "ExposureDescription";
    this.cboExposureUnits.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboExposureUnits.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboExposureUnits).DropDownWidth = 300;
    ((Control) this.cboExposureUnits).Location = new Point(88, 93);
    this.cboExposureUnits.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboExposureUnits).Name = "cboExposureUnits";
    ((Control) this.cboExposureUnits).Size = new Size(176 /*0xB0*/, 21);
    ((Control) this.cboExposureUnits).TabIndex = 35;
    ((UltraControlBase) this.cboExposureUnits).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboExposureUnits).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboExposureUnits).ValueMember = "ExposureUnit";
    ((Control) this.GroupBox2).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.GroupBox2.BackColorInternal = Color.Transparent;
    appearance30.AlphaLevel = (short) 150;
    appearance30.BackColor = Color.GhostWhite;
    appearance30.BackColorDisabled = Color.WhiteSmoke;
    appearance30.BorderAlpha = (Alpha) 2;
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.GroupBox2.ContentAreaAppearance = (AppearanceBase) appearance30;
    ((Control) this.GroupBox2).Controls.Add((Control) this.numTerrorismRate);
    ((Control) this.GroupBox2).Controls.Add((Control) this.UltraNumericEditor8);
    ((Control) this.GroupBox2).Controls.Add((Control) this.UltraNumericEditor7);
    ((Control) this.GroupBox2).Controls.Add((Control) this.Label5);
    ((Control) this.GroupBox2).Controls.Add((Control) this.Label7);
    ((Control) this.GroupBox2).Controls.Add((Control) this.Label6);
    ((Control) this.GroupBox2).Controls.Add((Control) this.Label4);
    ((Control) this.GroupBox2).Controls.Add((Control) this.UltraNumericEditor2);
    ((Control) this.GroupBox2).Enabled = false;
    appearance31.ForeColor = Color.Navy;
    this.GroupBox2.HeaderAppearance = (AppearanceBase) appearance31;
    ((Control) this.GroupBox2).Location = new Point(303, 310);
    ((Control) this.GroupBox2).Name = "GroupBox2";
    ((Control) this.GroupBox2).Size = new Size(199, 128 /*0x80*/);
    ((Control) this.GroupBox2).TabIndex = 17;
    this.GroupBox2.Text = "Rates";
    appearance32.BackColorDisabled = Color.WhiteSmoke;
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance32).TextHAlignAsString = "Right";
    ((UltraNumericEditorBase) this.numTerrorismRate).Appearance = (AppearanceBase) appearance32;
    ((Control) this.numTerrorismRate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGLExposures.TerrRate", true));
    ((UltraNumericEditorBase) this.numTerrorismRate).FormatString = "c";
    ((Control) this.numTerrorismRate).Location = new Point(104, 91);
    this.numTerrorismRate.MaxValue = (object) 10000;
    this.numTerrorismRate.MGAStyle = MGAStyles.Blue;
    this.numTerrorismRate.MinValue = (object) 0;
    ((Control) this.numTerrorismRate).Name = "numTerrorismRate";
    this.numTerrorismRate.NumericType = (NumericType) 1;
    ((Control) this.numTerrorismRate).Size = new Size(72, 20);
    ((Control) this.numTerrorismRate).TabIndex = 14;
    ((UltraControlBase) this.numTerrorismRate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numTerrorismRate).UseOsThemes = (DefaultableBoolean) 2;
    appearance33.BackColorDisabled = Color.WhiteSmoke;
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance33).TextHAlignAsString = "Right";
    ((UltraNumericEditorBase) this.UltraNumericEditor8).Appearance = (AppearanceBase) appearance33;
    ((Control) this.UltraNumericEditor8).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGLExposures.CombinedRate", true));
    ((UltraNumericEditorBase) this.UltraNumericEditor8).FormatString = "c";
    ((Control) this.UltraNumericEditor8).Location = new Point(104, 68);
    this.UltraNumericEditor8.MaxValue = (object) 10000;
    this.UltraNumericEditor8.MGAStyle = MGAStyles.Blue;
    this.UltraNumericEditor8.MinValue = (object) 0;
    ((Control) this.UltraNumericEditor8).Name = "UltraNumericEditor8";
    this.UltraNumericEditor8.NumericType = (NumericType) 1;
    ((Control) this.UltraNumericEditor8).Size = new Size(72, 20);
    ((Control) this.UltraNumericEditor8).TabIndex = 13;
    ((UltraControlBase) this.UltraNumericEditor8).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraNumericEditor8).UseOsThemes = (DefaultableBoolean) 2;
    appearance34.BackColorDisabled = Color.WhiteSmoke;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance34).TextHAlignAsString = "Right";
    ((UltraNumericEditorBase) this.UltraNumericEditor7).Appearance = (AppearanceBase) appearance34;
    ((Control) this.UltraNumericEditor7).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGLExposures.ProdRate", true));
    ((UltraNumericEditorBase) this.UltraNumericEditor7).FormatString = "c";
    ((Control) this.UltraNumericEditor7).Location = new Point(104, 22);
    this.UltraNumericEditor7.MaxValue = (object) 10000;
    this.UltraNumericEditor7.MGAStyle = MGAStyles.Blue;
    this.UltraNumericEditor7.MinValue = (object) 0;
    ((Control) this.UltraNumericEditor7).Name = "UltraNumericEditor7";
    this.UltraNumericEditor7.NumericType = (NumericType) 1;
    ((Control) this.UltraNumericEditor7).Size = new Size(72, 20);
    ((Control) this.UltraNumericEditor7).TabIndex = 12;
    ((UltraControlBase) this.UltraNumericEditor7).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraNumericEditor7).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.GroupBox3).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.GroupBox3.BackColorInternal = Color.Transparent;
    appearance35.AlphaLevel = (short) 150;
    appearance35.BackColor = Color.GhostWhite;
    appearance35.BackColorAlpha = (Alpha) 1;
    appearance35.BackColorDisabled = Color.WhiteSmoke;
    appearance35.BorderAlpha = (Alpha) 2;
    appearance35.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.GroupBox3.ContentAreaAppearance = (AppearanceBase) appearance35;
    ((Control) this.GroupBox3).Controls.Add((Control) this.lblTotalPremium);
    ((Control) this.GroupBox3).Controls.Add((Control) this.Label12);
    ((Control) this.GroupBox3).Controls.Add((Control) this.numTerrPrem);
    ((Control) this.GroupBox3).Controls.Add((Control) this.numPremisesPrem);
    ((Control) this.GroupBox3).Controls.Add((Control) this.numProdPrem);
    ((Control) this.GroupBox3).Controls.Add((Control) this.Label8);
    ((Control) this.GroupBox3).Controls.Add((Control) this.Label10);
    ((Control) this.GroupBox3).Controls.Add((Control) this.Label9);
    ((Control) this.GroupBox3).Enabled = false;
    appearance36.ForeColor = Color.Navy;
    this.GroupBox3.HeaderAppearance = (AppearanceBase) appearance36;
    ((Control) this.GroupBox3).Location = new Point(508, 310);
    ((Control) this.GroupBox3).Name = "GroupBox3";
    ((Control) this.GroupBox3).Size = new Size(224 /*0xE0*/, 128 /*0x80*/);
    ((Control) this.GroupBox3).TabIndex = 18;
    this.GroupBox3.Text = "Premiums";
    appearance37.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance37).TextHAlignAsString = "Right";
    ((ControlBase) this.lblTotalPremium).Appearance = (AppearanceBase) appearance37;
    ((ControlBase) this.lblTotalPremium).BackColorInternal = Color.WhiteSmoke;
    this.lblTotalPremium.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblTotalPremium).Location = new Point(125, 91);
    ((Control) this.lblTotalPremium).Name = "lblTotalPremium";
    ((Control) this.lblTotalPremium).Size = new Size(72, 21);
    ((Control) this.lblTotalPremium).TabIndex = 20;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(13, 95);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(74, 13);
    this.Label12.TabIndex = 19;
    this.Label12.Text = "Total Premium";
    this.Label12.TextAlign = ContentAlignment.MiddleRight;
    appearance38.BackColorDisabled = Color.WhiteSmoke;
    appearance38.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance38).TextHAlignAsString = "Right";
    ((UltraNumericEditorBase) this.numTerrPrem).Appearance = (AppearanceBase) appearance38;
    ((Control) this.numTerrPrem).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGLExposures.TerrPremium", true));
    ((UltraNumericEditorBase) this.numTerrPrem).FormatString = "c";
    ((Control) this.numTerrPrem).Location = new Point(125, 68);
    this.numTerrPrem.MaxValue = (object) 999999999;
    this.numTerrPrem.MGAStyle = MGAStyles.Blue;
    this.numTerrPrem.MinValue = (object) -999999999;
    ((Control) this.numTerrPrem).Name = "numTerrPrem";
    this.numTerrPrem.NumericType = (NumericType) 1;
    ((Control) this.numTerrPrem).Size = new Size(72, 20);
    ((Control) this.numTerrPrem).TabIndex = 18;
    ((UltraControlBase) this.numTerrPrem).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numTerrPrem).UseOsThemes = (DefaultableBoolean) 2;
    appearance39.BackColorDisabled = Color.WhiteSmoke;
    appearance39.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance39).TextHAlignAsString = "Right";
    ((UltraNumericEditorBase) this.numPremisesPrem).Appearance = (AppearanceBase) appearance39;
    ((Control) this.numPremisesPrem).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGLExposures.PremPremium", true));
    ((UltraNumericEditorBase) this.numPremisesPrem).FormatString = "c";
    ((Control) this.numPremisesPrem).Location = new Point(125, 45);
    this.numPremisesPrem.MaxValue = (object) 999999999;
    this.numPremisesPrem.MGAStyle = MGAStyles.Blue;
    this.numPremisesPrem.MinValue = (object) -999999999;
    ((Control) this.numPremisesPrem).Name = "numPremisesPrem";
    this.numPremisesPrem.NumericType = (NumericType) 1;
    ((Control) this.numPremisesPrem).Size = new Size(72, 20);
    ((Control) this.numPremisesPrem).TabIndex = 17;
    ((UltraControlBase) this.numPremisesPrem).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numPremisesPrem).UseOsThemes = (DefaultableBoolean) 2;
    appearance40.BackColorDisabled = Color.WhiteSmoke;
    appearance40.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance40).TextHAlignAsString = "Right";
    ((UltraNumericEditorBase) this.numProdPrem).Appearance = (AppearanceBase) appearance40;
    ((Control) this.numProdPrem).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGLExposures.ProdPremium", true));
    ((UltraNumericEditorBase) this.numProdPrem).FormatString = "c";
    ((Control) this.numProdPrem).Location = new Point(125, 22);
    this.numProdPrem.MaxValue = (object) 999999999;
    this.numProdPrem.MGAStyle = MGAStyles.Blue;
    this.numProdPrem.MinValue = (object) -999999999;
    ((Control) this.numProdPrem).Name = "numProdPrem";
    this.numProdPrem.NumericType = (NumericType) 1;
    ((Control) this.numProdPrem).Size = new Size(72, 20);
    ((Control) this.numProdPrem).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.numProdPrem).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numProdPrem).UseOsThemes = (DefaultableBoolean) 2;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(620, 470);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 19;
    this.daExposure.DeleteCommand = this.SqlDeleteCommand1;
    this.daExposure.InsertCommand = this.SqlInsertCommand1;
    this.daExposure.SelectCommand = this.SqlSelectCommand3;
    this.daExposure.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblGLExposures", new DataColumnMapping[22]
      {
        new DataColumnMapping("ExposureID", "ExposureID"),
        new DataColumnMapping("LocationID", "LocationID"),
        new DataColumnMapping("Exposure", "Exposure"),
        new DataColumnMapping("PremRate", "PremRate"),
        new DataColumnMapping("ProdRate", "ProdRate"),
        new DataColumnMapping("TerrRate", "TerrRate"),
        new DataColumnMapping("CombinedRate", "CombinedRate"),
        new DataColumnMapping("PremPremium", "PremPremium"),
        new DataColumnMapping("ProdPremium", "ProdPremium"),
        new DataColumnMapping("TerrPremium", "TerrPremium"),
        new DataColumnMapping("TotalPremium", "TotalPremium"),
        new DataColumnMapping("UserAdded", "UserAdded"),
        new DataColumnMapping("ExposureUnit", "ExposureUnit"),
        new DataColumnMapping("QuoteOptionID", "QuoteOptionID"),
        new DataColumnMapping("OfficeID", "OfficeID"),
        new DataColumnMapping("ModificationCode", "ModificationCode"),
        new DataColumnMapping("OriginalExposureID", "OriginalExposureID"),
        new DataColumnMapping("EndorsementCalcType", "EndorsementCalcType"),
        new DataColumnMapping("Factor", "Factor"),
        new DataColumnMapping("EffectiveDate", "EffectiveDate"),
        new DataColumnMapping("ClassCodeID", "ClassCodeID"),
        new DataColumnMapping("UserOverrideFactor", "UserOverrideFactor")
      })
    });
    this.daExposure.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblGLExposures WHERE (ExposureID = @Original_ExposureID)";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ExposureID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ExposureID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[19]
    {
      new SqlParameter("@LocationID", SqlDbType.Int, 4, "LocationID"),
      new SqlParameter("@Exposure", SqlDbType.Int, 4, "Exposure"),
      new SqlParameter("@PremRate", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "PremRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@ProdRate", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "ProdRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@TerrRate", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "TerrRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@CombinedRate", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "CombinedRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@PremPremium", SqlDbType.Money, 8, "PremPremium"),
      new SqlParameter("@ProdPremium", SqlDbType.Money, 8, "ProdPremium"),
      new SqlParameter("@TerrPremium", SqlDbType.Money, 8, "TerrPremium"),
      new SqlParameter("@UserAdded", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserAdded"),
      new SqlParameter("@ExposureUnit", SqlDbType.VarChar, 1, "ExposureUnit"),
      new SqlParameter("@QuoteOptionID", SqlDbType.Int, 4, "QuoteOptionID"),
      new SqlParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      new SqlParameter("@ModificationCode", SqlDbType.VarChar, 1, "ModificationCode"),
      new SqlParameter("@OriginalExposureID", SqlDbType.Int, 4, "OriginalExposureID"),
      new SqlParameter("@EndorsementCalcType", SqlDbType.VarChar, 1, "EndorsementCalcType"),
      new SqlParameter("@EffectiveDate", SqlDbType.DateTime, 8, "EffectiveDate"),
      new SqlParameter("@ClassCodeID", SqlDbType.SmallInt, 2, "ClassCodeID"),
      new SqlParameter("@UserOverrideFactor", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 9, (byte) 8, "UserOverrideFactor", DataRowVersion.Current, (object) null)
    });
    this.SqlSelectCommand3.CommandText = componentResourceManager.GetString("SqlSelectCommand3.CommandText");
    this.SqlSelectCommand3.Connection = this.cn;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@QuoteOptionID", SqlDbType.Int, 4, "QuoteOptionID"),
      new SqlParameter("@ExposureID", SqlDbType.Int, 4, "ExposureID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[21]
    {
      new SqlParameter("@LocationID", SqlDbType.Int, 4, "LocationID"),
      new SqlParameter("@Exposure", SqlDbType.Int, 4, "Exposure"),
      new SqlParameter("@PremRate", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "PremRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@ProdRate", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "ProdRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@TerrRate", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "TerrRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@CombinedRate", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "CombinedRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@PremPremium", SqlDbType.Money, 8, "PremPremium"),
      new SqlParameter("@ProdPremium", SqlDbType.Money, 8, "ProdPremium"),
      new SqlParameter("@TerrPremium", SqlDbType.Money, 8, "TerrPremium"),
      new SqlParameter("@UserAdded", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserAdded"),
      new SqlParameter("@ExposureUnit", SqlDbType.VarChar, 1, "ExposureUnit"),
      new SqlParameter("@QuoteOptionID", SqlDbType.Int, 4, "QuoteOptionID"),
      new SqlParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      new SqlParameter("@ModificationCode", SqlDbType.VarChar, 1, "ModificationCode"),
      new SqlParameter("@OriginalExposureID", SqlDbType.Int, 4, "OriginalExposureID"),
      new SqlParameter("@EndorsementCalcType", SqlDbType.VarChar, 1, "EndorsementCalcType"),
      new SqlParameter("@EffectiveDate", SqlDbType.DateTime, 8, "EffectiveDate"),
      new SqlParameter("@ClassCodeID", SqlDbType.SmallInt, 2, "ClassCodeID"),
      new SqlParameter("@UserOverrideFactor", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 9, (byte) 8, "UserOverrideFactor", DataRowVersion.Current, (object) null),
      new SqlParameter("@Original_ExposureID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ExposureID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ExposureID", SqlDbType.Int, 4, "ExposureID")
    });
    this.err.ContainerControl = (ContainerControl) this;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label11.Location = new Point(261, 8);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(193, 17);
    this.Label11.TabIndex = 20;
    this.Label11.Text = "You are working with option #";
    this.lblOptionID.AutoSize = true;
    this.lblOptionID.BackColor = Color.Transparent;
    this.lblOptionID.Font = new Font("Tahoma", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblOptionID.Location = new Point(437, 8);
    this.lblOptionID.Name = "lblOptionID";
    this.lblOptionID.Size = new Size(53, 17);
    this.lblOptionID.TabIndex = 21;
    this.lblOptionID.Text = "12345";
    this.lnkModifyLocations.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkModifyLocations.AutoSize = true;
    this.lnkModifyLocations.BackColor = Color.Transparent;
    this.lnkModifyLocations.Location = new Point(303, 448);
    this.lnkModifyLocations.Name = "lnkModifyLocations";
    this.lnkModifyLocations.Size = new Size(96 /*0x60*/, 13);
    this.lnkModifyLocations.TabIndex = 22;
    this.lnkModifyLocations.TabStop = true;
    this.lnkModifyLocations.Text = "Add/Edit Locations";
    this.lnkModifyLocations.TextAlign = ContentAlignment.MiddleCenter;
    ((UltraGridBase) this.ddClassCodes).DataSource = (object) this.ds.lstClassCodes;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn32.Header.VisiblePosition = 0;
    ultraGridColumn32.Width = 115;
    ultraGridColumn33.Header.VisiblePosition = 1;
    ultraGridColumn33.Width = 139;
    ultraGridColumn34.Header.VisiblePosition = 2;
    ultraGridColumn34.Width = 112 /*0x70*/;
    ultraGridColumn35.Header.VisiblePosition = 3;
    ultraGridColumn35.Width = 112 /*0x70*/;
    ultraGridColumn36.Header.VisiblePosition = 4;
    ultraGridColumn36.Hidden = true;
    ultraGridBand3.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36
    });
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddClassCodes).DisplayMember = "ClassCodeDescription";
    ((Control) this.ddClassCodes).Location = new Point(144 /*0x90*/, 176 /*0xB0*/);
    ((Control) this.ddClassCodes).Name = "ddClassCodes";
    ((Control) this.ddClassCodes).Size = new Size(480, 80 /*0x50*/);
    ((Control) this.ddClassCodes).TabIndex = 23;
    ((UltraDropDownBase) this.ddClassCodes).ValueMember = "ClassCode";
    ((Control) this.ddClassCodes).Visible = false;
    this.lnkClassCodes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkClassCodes.AutoSize = true;
    this.lnkClassCodes.BackColor = Color.Transparent;
    this.lnkClassCodes.Location = new Point(303, 472);
    this.lnkClassCodes.Name = "lnkClassCodes";
    this.lnkClassCodes.Size = new Size(109, 13);
    this.lnkClassCodes.TabIndex = 24;
    this.lnkClassCodes.TabStop = true;
    this.lnkClassCodes.Text = "Add/Edit Class Codes";
    this.lnkClassCodes.TextAlign = ContentAlignment.MiddleCenter;
    this.lnkCompanyClassCodes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCompanyClassCodes.AutoSize = true;
    this.lnkCompanyClassCodes.BackColor = Color.Transparent;
    this.lnkCompanyClassCodes.Location = new Point(303, 496);
    this.lnkCompanyClassCodes.Name = "lnkCompanyClassCodes";
    this.lnkCompanyClassCodes.Size = new Size(172, 13);
    this.lnkCompanyClassCodes.TabIndex = 25;
    this.lnkCompanyClassCodes.TabStop = true;
    this.lnkCompanyClassCodes.Text = "Company/Class Code Assignments";
    this.lnkCompanyClassCodes.TextAlign = ContentAlignment.MiddleCenter;
    this.UltraToolbarsManager1.DesignerFlags = 0;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.UltraToolbarsManager1.ImageTransparentColor = Color.Magenta;
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    this.UltraToolbarsManager1.Style = (ToolbarStyle) 3;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedPosition = (DockedPosition) 4;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(688, 761);
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
    appearance41.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance18.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance41;
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedProps).Caption = "Restore Location";
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedProps).Caption = "ContextMenu";
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
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top).Name = "_frmPropertyRater_Exposure_Toolbars_Dock_Area_Top";
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top).Size = new Size(742, 0);
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom).Location = new Point(0, 516);
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom).Name = "_frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom).Size = new Size(742, 0);
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left).Name = "_frmPropertyRater_Exposure_Toolbars_Dock_Area_Left";
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left).Size = new Size(0, 516);
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right).Location = new Point(742, 0);
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right).Name = "_frmPropertyRater_Exposure_Toolbars_Dock_Area_Right";
    ((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right).Size = new Size(0, 516);
    this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    this.lnkAddMiscPremiums.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAddMiscPremiums.AutoSize = true;
    this.lnkAddMiscPremiums.BackColor = Color.Transparent;
    this.lnkAddMiscPremiums.Location = new Point(631, 448);
    this.lnkAddMiscPremiums.Name = "lnkAddMiscPremiums";
    this.lnkAddMiscPremiums.Size = new Size(101, 13);
    this.lnkAddMiscPremiums.TabIndex = 30;
    this.lnkAddMiscPremiums.TabStop = true;
    this.lnkAddMiscPremiums.Text = "Add Misc. Premiums";
    this.lnkAddMiscPremiums.TextAlign = ContentAlignment.MiddleCenter;
    this.daLoadData.SelectCommand = this.SqlSelectCommand1;
    this.daLoadData.TableMappings.AddRange(new DataTableMapping[5]
    {
      new DataTableMapping("Table", "spGLRater_Exposure", new DataColumnMapping[8]
      {
        new DataColumnMapping("LocationID", "LocationID"),
        new DataColumnMapping("LocationNo", "LocationNo"),
        new DataColumnMapping("BuildingNo", "BuildingNo"),
        new DataColumnMapping("PhysicalBuildingNo", "PhysicalBuildingNo"),
        new DataColumnMapping("Address", "Address"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("Zip", "Zip")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[5]
      {
        new DataColumnMapping("ClassCode", "ClassCode"),
        new DataColumnMapping("ClassCodeDescription", "ClassCodeDescription"),
        new DataColumnMapping("Access", "Access"),
        new DataColumnMapping("GLExposureUnit", "GLExposureUnit"),
        new DataColumnMapping("ClassCodeID", "ClassCodeID")
      }),
      new DataTableMapping("Table2", "Table2", new DataColumnMapping[2]
      {
        new DataColumnMapping("ExposureUnit", "ExposureUnit"),
        new DataColumnMapping("ExposureDescription", "ExposureDescription")
      }),
      new DataTableMapping("Table3", "Table3", new DataColumnMapping[2]
      {
        new DataColumnMapping("OfficeID", "OfficeID"),
        new DataColumnMapping("Location", "Location")
      }),
      new DataTableMapping("Table4", "Table4", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("EndorsementCalcType", "EndorsementCalcType")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spGLRater_Exposure]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      new SqlParameter("@LocationsOnly", SqlDbType.Bit, 1),
      new SqlParameter("@ClassCodesOnly", SqlDbType.Bit, 1)
    });
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(742, 516);
    this.Controls.Add((Control) this.lnkAddMiscPremiums);
    this.Controls.Add((Control) this.lnkCompanyClassCodes);
    this.Controls.Add((Control) this.lnkClassCodes);
    this.Controls.Add((Control) this.lnkModifyLocations);
    this.Controls.Add((Control) this.lblOptionID);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.gbExposureInformation);
    this.Controls.Add((Control) this.ddClassCodes);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.dgLocations);
    this.Controls.Add((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._frmPropertyRater_Exposure_Toolbars_Dock_Area_Bottom);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmGLRater_Exposure);
    this.Text = "IMS General Liability Rater - Exposure Information";
    ((ISupportInitialize) this.dgLocations).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboClassCodes).EndInit();
    ((ISupportInitialize) this.UltraNumericEditor1).EndInit();
    ((ISupportInitialize) this.UltraNumericEditor2).EndInit();
    ((ISupportInitialize) this.gbExposureInformation).EndInit();
    ((Control) this.gbExposureInformation).ResumeLayout(false);
    ((Control) this.gbExposureInformation).PerformLayout();
    ((ISupportInitialize) this.cboCalcType).EndInit();
    ((ISupportInitialize) this.cboClientOffices).EndInit();
    ((ISupportInitialize) this.cboExposureUnits).EndInit();
    ((ISupportInitialize) this.GroupBox2).EndInit();
    ((Control) this.GroupBox2).ResumeLayout(false);
    ((Control) this.GroupBox2).PerformLayout();
    ((ISupportInitialize) this.numTerrorismRate).EndInit();
    ((ISupportInitialize) this.UltraNumericEditor8).EndInit();
    ((ISupportInitialize) this.UltraNumericEditor7).EndInit();
    ((ISupportInitialize) this.GroupBox3).EndInit();
    ((Control) this.GroupBox3).ResumeLayout(false);
    ((Control) this.GroupBox3).PerformLayout();
    ((ISupportInitialize) this.numTerrPrem).EndInit();
    ((ISupportInitialize) this.numPremisesPrem).EndInit();
    ((ISupportInitialize) this.numProdPrem).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ddClassCodes).EndInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
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

  private EndorsementCalcTypes CalcType
  {
    get
    {
      string Left = this.cboCalcType.Value.ToString();
      EndorsementCalcTypes calcType;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "S", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "P", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "F", false) == 0)
            calcType = EndorsementCalcTypes.Flat;
        }
        else
          calcType = EndorsementCalcTypes.ProRata;
      }
      else
        calcType = EndorsementCalcTypes.ShortRate;
      return calcType;
    }
  }

  private GLRater Rater => this._glRater;

  private BindingManagerBase bmb
  {
    get
    {
      if (this._bmb == null)
        this._bmb = this.BindingContext[(object) this.ds, this.ds.tblGLExposures.TableName];
      return this._bmb;
    }
  }

  private bool TerrorismDeclined
  {
    get
    {
      if (this._terrorismDeclined == null)
        this._terrorismDeclined = (object) DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT TerrorismDeclined FROM tblQuoteOptionGL WHERE QuoteOptionID=@QOID", new object[2]
        {
          (object) "@QOID",
          (object) this._quoteOption.QuoteOptionID
        });
      return (bool) this._terrorismDeclined;
    }
  }

  public frmGLRater_Exposure(int quoteOptionID, GLRater rater)
  {
    this.Load += new EventHandler(this.frmGLRater_Exposure_Load);
    this.InitializeComponent();
    this._quoteOption = new QuoteOption(quoteOptionID);
    this._quote = Quote.FromQuoteOptionID(quoteOptionID);
    this._glRater = rater;
  }

  private void frmGLRater_Exposure_Load(object sender, EventArgs e)
  {
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.lblOptionID.Text = this._quoteOption.QuoteOptionID.ToString();
    this.FillData(this.ds);
    try
    {
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLoadData, (DataSet) this.ds);
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    ((Control) this.cboCalcType).Enabled = this._quote.IsEndorsement;
    if (this.TerrorismDeclined)
    {
      this._strikeoutFont = new Font(((Control) this.numTerrorismRate).Font, FontStyle.Strikeout);
      MGANumericEditor numTerrorismRate = this.numTerrorismRate;
      ((Control) numTerrorismRate).Font = this._strikeoutFont;
      ((UltraNumericEditorBase) numTerrorismRate).ForeColor = Color.Red;
      MGANumericEditor numTerrPrem = this.numTerrPrem;
      ((Control) numTerrPrem).Font = this._strikeoutFont;
      ((UltraNumericEditorBase) numTerrPrem).ForeColor = Color.Red;
      AppearanceBase cellAppearance1 = ((UltraGridBase) this.dgLocations).DisplayLayout.Bands[1].Columns["TerrPremium"].CellAppearance;
      cellAppearance1.ForeColor = Color.Red;
      cellAppearance1.FontData.Strikeout = (DefaultableBoolean) 1;
      AppearanceBase cellAppearance2 = ((UltraGridBase) this.dgLocations).DisplayLayout.Bands[1].Columns["TerrRate"].CellAppearance;
      cellAppearance2.ForeColor = Color.Red;
      cellAppearance2.FontData.Strikeout = (DefaultableBoolean) 1;
    }
    SqlDataAdapter daExposure = this.daExposure;
    daExposure.SelectCommand.Parameters["@quoteOptionID"].Value = (object) this._quoteOption.QuoteOptionID;
    daExposure.SelectCommand.Parameters["@exposureID"].Value = (object) DBNull.Value;
    try
    {
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daExposure, (DataTable) this.ds.tblGLExposures);
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    ((UltraGridBase) this.dgLocations).Rows.ExpandAll(true);
    this.cboClassCodes.ValueChanged += new EventHandler(this.cboClassCodes_SelectedIndexChanged);
    if (this.ds.tblUnderwritingLocations.Count != 0)
      return;
    this.ShowUnderwritingLocationsForm();
  }

  protected virtual void FillData(dsGLRaterExposure dsExposure)
  {
    DataTableMappingCollection tableMappings = this.daLoadData.TableMappings;
    tableMappings.Clear();
    tableMappings.Add("Table", dsExposure.tblUnderwritingLocations.TableName);
    tableMappings.Add("Table1", dsExposure.lstClassCodes.TableName);
    tableMappings.Add("Table2", dsExposure.lstGLExposureUnit.TableName);
    tableMappings.Add("Table3", dsExposure.tblClientOffices.TableName);
    tableMappings.Add("Table4", dsExposure.lstEndorsementCalculationTypes.TableName);
    this.daLoadData.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._quote.QuoteGuid;
    this.daLoadData.SelectCommand.Parameters["@LocationsOnly"].Value = (object) 0;
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    if (this.bmb.Position == -1)
      return;
    if (this.ds.tblGLExposures[this.bmb.Position].RowState == DataRowState.Added)
    {
      BindingManagerBase bmb;
      int num = (bmb = this.bmb).Position - 1;
      bmb.Position = num;
    }
    this.ds.tblGLExposures.RejectChanges();
    this.ClearErrorValidators();
    if (((UltraGridBase) this.dgLocations).ActiveRow == null)
      return;
    if (((UltraGridBase) this.dgLocations).ActiveRow.Band.Index == 0)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete this exposure?", "Delete Exposure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    int position = this.bmb.Position;
    if (this._quote.IsEndorsement && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ds.tblGLExposures[this.bmb.Position].ModificationCode, "N", false) != 0)
    {
      frmEndorsementActionDate endorsementActionDate = (frmEndorsementActionDate) FormSettings.ShowFormDialog(typeof (frmEndorsementActionDate), (object) new GLQuoteOption(this._quoteOption.QuoteOptionID), (object) this._quote, (object) this.CalcType, (object) this.ds.tblGLExposures[this.bmb.Position].EffectiveDate);
      MDIControls.Instance.MDIParent.Refresh();
      Application.DoEvents();
      if (!endorsementActionDate.Saved)
        return;
      dsGLRaterExposure.tblGLExposuresRow tblGlExposure = this.ds.tblGLExposures[this.bmb.Position];
      tblGlExposure.EffectiveDate = endorsementActionDate.ActionDate;
      tblGlExposure.Factor = endorsementActionDate.Factor;
      if (endorsementActionDate.FactorOverridden)
        tblGlExposure.UserOverrideFactor = endorsementActionDate.Factor;
      tblGlExposure.PremPremium = 0M;
      tblGlExposure.ProdPremium = 0M;
      tblGlExposure.TerrPremium = 0M;
      this.ds.tblGLExposures[position].ModificationCode = "D";
      UltraGridRow activeRow = ((UltraGridBase) this.dgLocations).ActiveRow;
      activeRow.Appearance.ForeColor = Color.Red;
      activeRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
    }
    else
    {
      this.cboClassCodes.ValueChanged -= new EventHandler(this.cboClassCodes_SelectedIndexChanged);
      this.ds.tblGLExposures[this.bmb.Position].Delete();
      this.cboClassCodes.ValueChanged += new EventHandler(this.cboClassCodes_SelectedIndexChanged);
    }
    if (this.SaveData())
      return;
    e.Cancel = true;
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.dgLocations).Enabled = this.dbSave.UIState != UIState.Editing;
    try
    {
      foreach (Control control in this.Controls)
      {
        if (control is UltraGroupBox)
          control.Enabled = this.dbSave.UIState == UIState.Editing;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.lnkModifyLocations.Enabled = this.dbSave.UIState != UIState.Editing;
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.dgLocations).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select a location in the grid to add exposure to.", "Location Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      int num = (int) ((UltraGridBase) this.dgLocations).ActiveRow.Cells["LocationID"].Value;
      dsGLRaterExposure.tblGLExposuresRow row = this.ds.tblGLExposures.NewtblGLExposuresRow();
      row.QuoteOptionID = this._quoteOption.QuoteOptionID;
      row.UserAdded = CurrentUser.Instance.UserGUID;
      row.LocationID = num;
      row.ModificationCode = "N";
      row.Factor = 1M;
      OfficeLocation officeLocation = OfficeLocation.FromOfficeGuid(this._quote.QuotingLocationGuid);
      row.OfficeID = officeLocation.OfficeID;
      if (this._quote.IsEndorsement)
      {
        row.EndorsementCalcType = this._quote.EndorsementCalcType;
        row.EffectiveDate = this._quote.EndorsementEffective;
      }
      else
      {
        if (this._quote.IsShortTerm)
          row.EndorsementCalcType = "S";
        row.EffectiveDate = this._quote.EffectiveDate;
      }
      this.ds.tblGLExposures.AddtblGLExposuresRow(row);
      this.bmb.Position = this.ds.tblGLExposures.Rows.Count - 1;
      try
      {
        foreach (Control control in ((Control) this.gbExposureInformation).Controls)
        {
          if (control is MGASimpleComboBox)
            ((UltraDropDownBase) control).SelectedRow = (UltraGridRow) null;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ClassCodeID FROM tblUnderwritingLocations WHERE LocationID=@LocationID", new object[2]
      {
        (object) "@LocationID",
        (object) num
      }));
      if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue)) || this.ds.lstClassCodes.FindByClassCodeID(Conversions.ToInteger(objectValue)) == null)
        return;
      row.ClassCodeID = Conversions.ToInteger(objectValue);
      this.cboClassCodes.Value = (object) row.ClassCodeID;
    }
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.IsValidForm())
    {
      if (this.SaveData())
        return;
      e.Cancel = true;
    }
    else
      e.Cancel = true;
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (this._quote.IsEndorsement)
    {
      if (this.cboCalcType.Value == DBNull.Value)
      {
        int num = (int) MessageBox.Show("Please fill in and save a Calc Type before continuing", "Empty Calc Type", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Cancel = true;
      }
      else
      {
        frmEndorsementActionDate endorsementActionDate = (frmEndorsementActionDate) FormSettings.ShowFormDialog(typeof (frmEndorsementActionDate), (object) new GLQuoteOption(this._quoteOption.QuoteOptionID), (object) this._quote, (object) this.CalcType, (object) this.ds.tblGLExposures[this.bmb.Position].EffectiveDate);
        MDIControls.Instance.MDIParent.Refresh();
        Application.DoEvents();
        if (endorsementActionDate.Saved)
        {
          dsGLRaterExposure.tblGLExposuresRow tblGlExposure = this.ds.tblGLExposures[this.bmb.Position];
          tblGlExposure.EffectiveDate = endorsementActionDate.ActionDate;
          tblGlExposure.Factor = endorsementActionDate.Factor;
          if (endorsementActionDate.FactorOverridden)
            tblGlExposure.UserOverrideFactor = endorsementActionDate.Factor;
        }
        else
          e.Cancel = true;
      }
    }
    else
      this.dbSave.ClickingEdit -= new CancelEventHandler(this.dbSave_ClickingEdit);
  }

  private void cboClassCodes_ValueChanged(object sender, EventArgs e)
  {
    if (this.cboClassCodes.Value == DBNull.Value || this.cboClassCodes.Value == null)
      return;
    dsGLRaterExposure.lstClassCodesRow byClassCodeId = this.ds.lstClassCodes.FindByClassCodeID((int) this.cboClassCodes.Value);
    if (byClassCodeId.IsGLExposureUnitNull())
      return;
    this.cboExposureUnits.Value = (object) byClassCodeId.GLExposureUnit;
  }

  private void lnkAddMiscPremiums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowFormDialog(typeof (frmMiscPremiums), (object) this._quoteOption.QuoteOptionID);
  }

  private void lnkCompanyClassCodes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    frmCompanyLineClasses.ShowForm(new CompanyLine(this._quote.CompanyLine.CompanyLineGuid));
    this.Cursor = MgaCursors.WaitCursor;
    this.bmb.SuspendBinding();
    this.ds.EnforceConstraints = false;
    this.ds.lstClassCodes.Clear();
    this.daLoadData.SelectCommand.Parameters["@ClassCodesOnly"].Value = (object) true;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLoadData, (DataSet) this.ds);
    this.ds.EnforceConstraints = true;
    this.bmb.ResumeBinding();
    this.Cursor = MgaCursors.Default;
  }

  private void lnkClassCodes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowFormDialog(typeof (frmAdminRatingClasses)).Dispose();
  }

  private void dgLocations_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgLocations).ActiveRow.Band.Index == 0)
    {
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    }
    else
    {
      Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgLocations).ActiveRow.Cells["ExposureID"].Value), "ExposureID", (DataTable) this.ds.tblGLExposures, this.bmb);
      this.dgLocations.Selected.Rows.Clear();
      ((UltraGridBase) this.dgLocations).ActiveRow.Selected = true;
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    }
  }

  private void cboClassCodes_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.cboClassCodes.Value == null || this.bmb.Position == -1 || this.cboClassCodes.Value == DBNull.Value)
      return;
    dsGLRaterExposure.lstClassCodesRow byClassCodeId = this.ds.lstClassCodes.FindByClassCodeID(Conversions.ToInteger(this.cboClassCodes.Value));
    if (byClassCodeId.IsGLExposureUnitNull())
      return;
    this.cboExposureUnits.Value = (object) byClassCodeId.GLExposureUnit;
  }

  private void UpdatePremiumValues(object sender, EventArgs e)
  {
    Decimal d2_1 = 0M;
    if (!this.TerrorismDeclined && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numTerrPrem.Value)))
      d2_1 = Conversions.ToDecimal(this.numTerrPrem.Value);
    Decimal d1 = 0M;
    Decimal d2_2 = 0M;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numPremisesPrem.Value)))
      d1 = Conversions.ToDecimal(this.numPremisesPrem.Value);
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.numProdPrem.Value)))
      d2_2 = Conversions.ToDecimal(this.numProdPrem.Value);
    ((ControlBase) this.lblTotalPremium).Text = Strings.FormatCurrency((object) Decimal.Add(Decimal.Add(d1, d2_2), d2_1), 0);
  }

  private bool IsValidForm()
  {
    bool flag = true;
    if (this.cboClientOffices.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboClientOffices, "Please select an office.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboClientOffices, string.Empty);
    if (this.cboClassCodes.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboClassCodes, "Please select a class code.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboClassCodes, string.Empty);
    if (this.cboExposureUnits.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboExposureUnits, "Please select an exposure unit.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboExposureUnits, string.Empty);
    if (flag)
    {
      dsGLRaterExposure.lstClassCodesRow byClassCodeId = this.ds.lstClassCodes.FindByClassCodeID(Conversions.ToInteger(this.cboClassCodes.Value));
      if (!byClassCodeId.IsAccessNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(byClassCodeId.Access, "A", false) != 0 && MessageBox.Show($"This class code is {Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(byClassCodeId.Access, "P", false) == 0, (object) "prohibited", (object) "restricted").ToString()}.\n\nWould you like to save anyway?", Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(byClassCodeId.Access, "P", false) == 0, (object) "Prohibited", (object) "Restricted").ToString() + " Class", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
        flag = false;
    }
    if (flag && this.cboCalcType.Text.Length == 0 && this._quote.IsEndorsement)
    {
      this.err.SetError((Control) this.cboCalcType, "Please select a calc type.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboCalcType, string.Empty);
    return flag;
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
    ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Restore Location"].SharedProps.Enabled = context.Band.Index == 1;
  }

  private void RestoreExposure(int exposureID)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spRestoreGLExposure", new object[2]
    {
      (object) "@exposureID",
      (object) exposureID
    });
    this.ds.tblGLExposures.RemovetblGLExposuresRow(this.ds.tblGLExposures.FindByExposureID(exposureID));
    this.daExposure.SelectCommand.Parameters["@exposureID"].Value = (object) exposureID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daExposure, (DataTable) this.ds.tblGLExposures);
    this.daExposure.SelectCommand.Parameters["@exposureID"].Value = (object) null;
    this.RefreshPremiums();
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((ToolEventArgs) e).Tool.Key, "Restore Location", false) != 0)
      return;
    dsGLRaterExposure.tblGLExposuresRow tblGlExposure = this.ds.tblGLExposures[this.bmb.Position];
    string modificationCode = tblGlExposure.ModificationCode;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(modificationCode, "D", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(modificationCode, "M", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(modificationCode, "N", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(modificationCode, "U", false) != 0)
          return;
        int num = (int) MessageBox.Show("This exposure is unchanged, and can not be restored.", "Unchanged Exposure", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        int num1 = (int) MessageBox.Show("This is a new exposure, and can not be restored to a prior version.", "Unchanged Exposure", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to restore this exposure?", "Restore Exposure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      this.RestoreExposure(tblGlExposure.ExposureID);
    }
  }

  private bool SaveData()
  {
    this.Cursor = MgaCursors.WaitCursor;
    this.bmb.EndCurrentEdit();
    if (this.bmb.Position >= 0 && this.ds.tblGLExposures[this.bmb.Position].RowState != DataRowState.Deleted)
    {
      dsGLRaterExposure.tblGLExposuresRow tblGlExposure = this.ds.tblGLExposures[this.bmb.Position];
      string str = this.cboExposureUnits.Value.ToString();
      int num = (int) this.cboClassCodes.Value;
      tblGlExposure.ExposureUnit = str;
      tblGlExposure.ClassCodeID = num;
    }
    try
    {
      foreach (dsGLRaterExposure.tblGLExposuresRow tblGlExposure in (TypedTableBase<dsGLRaterExposure.tblGLExposuresRow>) this.ds.tblGLExposures)
      {
        if (tblGlExposure.RowState != DataRowState.Deleted && !tblGlExposure.IsOriginalExposureIDNull() && tblGlExposure.RowState == DataRowState.Modified && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblGlExposure.ModificationCode, "U", false) == 0)
          tblGlExposure.ModificationCode = "M";
      }
    }
    finally
    {
      IEnumerator<dsGLRaterExposure.tblGLExposuresRow> enumerator;
      enumerator?.Dispose();
    }
    bool flag;
    try
    {
      MDIControls.Instance.StatusBarText = "Saving GL exposures...";
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daExposure, (DataTable) this.ds.tblGLExposures);
    }
    catch (SqlException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      SqlException ex2 = ex1;
      if (ex2.Message.Contains("IX_tblGLExposures"))
      {
        int num = (int) MessageBox.Show("This exposure setup already exists.", "Exposure Exists", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
        ErrorHandler.HandleError((Exception) ex2);
      flag = false;
      ProjectData.ClearProjectError();
      goto label_19;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    if (!this._quote.IsBound)
      this.RefreshPremiums();
    this.Rater.RateOption(this._quoteOption.QuoteOptionGuid);
    ((UltraGridBase) this.dgLocations).Rows.ExpandAll(true);
    flag = true;
label_19:
    return flag;
  }

  private void RefreshPremiumsThread(object state)
  {
    try
    {
      this._glRater.RefreshPremiums(this._quoteOption);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
      ProjectData.ClearProjectError();
      return;
    }
    if (!this.IsHandleCreated || this.IsDisposed)
      return;
    if (this.Disposing)
      return;
    try
    {
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new frmGLRater_Exposure.RefreshPremiumsCompleteHandler(this.RefreshPremiumsComplete), (object) this, (object) EventArgs.Empty);
    }
    catch (ObjectDisposedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void RefreshPremiums()
  {
    if (this._quote.IsBound)
      return;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.RefreshPremiumsThread));
  }

  private void RefreshPremiumsComplete(object sender, EventArgs e)
  {
    try
    {
      Application.DoEvents();
      this.Rater.RateOption(this._quoteOption.QuoteOptionGuid);
    }
    catch (ObjectDisposedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void ClearErrorValidators()
  {
    try
    {
      foreach (Control control1 in this.Controls)
      {
        if (control1 is UltraGroupBox)
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

  private void ShowUnderwritingLocationsForm()
  {
    FormSettings.ShowFormDialog(typeof (frmUnderwritingLocations), (object) this._quote.QuoteGuid, (object) true).Dispose();
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this.ds.EnforceConstraints = false;
      this.ds.tblUnderwritingLocations.Clear();
      this.daLoadData.SelectCommand.Parameters["@LocationsOnly"].Value = (object) 1;
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLoadData, (DataSet) this.ds);
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
    this.ShowUnderwritingLocationsForm();
  }

  private void dgLocations_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (e.Row.Band.Index != 1)
      return;
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
      frmEndorsementActionDate endorsementActionDate = (frmEndorsementActionDate) FormSettings.ShowFormDialog(typeof (frmEndorsementActionDate), (object) new GLQuoteOption(this._quoteOption.QuoteOptionID), (object) this._quote, (object) this.CalcType, (object) this.ds.tblGLExposures[this.bmb.Position].EffectiveDate);
      if (endorsementActionDate.Saved)
      {
        if (endorsementActionDate.FactorOverridden)
          this.ds.tblGLExposures[this.bmb.Position].UserOverrideFactor = endorsementActionDate.Factor;
        else if (DateTime.Compare(this.ds.tblGLExposures[this.bmb.Position].EffectiveDate, endorsementActionDate.ActionDate) != 0)
        {
          dsGLRaterExposure.tblGLExposuresRow tblGlExposure = this.ds.tblGLExposures[this.bmb.Position];
          tblGlExposure.EffectiveDate = endorsementActionDate.ActionDate;
          tblGlExposure.Factor = this._quote.CalculateFactor(this.CalcType, tblGlExposure.EffectiveDate);
        }
      }
      endorsementActionDate.Dispose();
    }
  }

  private void _bmb_PositionChanged(object sender, EventArgs e)
  {
    this.dgLocations.Selected.Rows.Clear();
    foreach (UltraGridRow row in ((UltraGridBase) this.dgLocations).Rows)
    {
      if (row.Band.Index == 1 && (int) row.Cells["ExposureID"].Value == this.ds.tblGLExposures[this.bmb.Position].ExposureID)
        ((UltraGridBase) this.dgLocations).ActiveRow.Selected = true;
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._strikeoutFont != null)
        this._strikeoutFont.Dispose();
    }
    base.Dispose(disposing);
  }

  private delegate void RefreshPremiumsCompleteHandler(object sender, EventArgs e);
}

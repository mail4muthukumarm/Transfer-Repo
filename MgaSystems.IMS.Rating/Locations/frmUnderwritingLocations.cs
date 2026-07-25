// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.Locations.frmUnderwritingLocations
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.AddressResolver;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.InsuredsProducersCompanies.Companies;
using MGASystems.IMS.NoteDocuments;
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
namespace MGASystems.IMS.Policies.Rating.Locations;

public class frmUnderwritingLocations : Form, ISupportDocumentSystem
{
  private IContainer components;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label6;
  private MGATextBox txtProtectionCode;
  private Label Label14;
  private MGACheckBox CheckBox2;
  private MGACheckBox CheckBox4;
  private SqlConnection cn;
  private SqlDataAdapter daLocation;
  private MGATextBox txtLocationNum;
  private MGATextBox txtBuildingNum;
  private MGATextBox txtTerritory;
  protected MGASimpleComboBox cboPolicyClasses;
  private Label Label24;
  private Label Label25;
  private Label Label26;
  private MGAMaskedEdit txtContactPhone;
  private Label Label27;
  private MGATextBox txtComments;
  private UltraToolbarsDockArea _frmUnderwritingLocations_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmUnderwritingLocations_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _frmUnderwritingLocations_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmUnderwritingLocations_Toolbars_Dock_Area_Bottom;
  private DataView dvFire;
  private DataView dvBurglar;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private MGASimpleComboBox cboWindRestriction;
  private Label Label31;
  private DataView dvWindRestriction;
  private readonly Quote _q;
  private Font _strikeoutFont;
  private int _locationId;
  protected bool _editClicked;
  private readonly bool _launchedByExposureScreen;
  private int _DefaultDaysOnRush;
  private bool _revertModifiedLocationsOnEndorsements;

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

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  protected virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ZipCodeResolver1")]
  protected virtual MGA_ZipCodeResolver ZipCodeResolver1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  protected virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblClass")]
  protected virtual Label lblClass { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  protected virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  protected virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  protected virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAdditionalInfo")]
  protected virtual MGATextBox txtAdditionalInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  protected virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  protected virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  protected virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  protected virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  protected virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CheckBox3")]
  protected virtual MGACheckBox CheckBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  protected virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  protected virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  protected virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label21")]
  protected virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label22")]
  protected virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label23")]
  protected virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsUnderwritingLocations ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("txtTaxTerritory")]
  protected virtual MGATextBox txtTaxTerritory { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEQConst")]
  protected virtual MGATextBox txtEQConst { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEarthquakeZone")]
  protected virtual MGATextBox txtEarthquakeZone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  protected virtual MGATextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  protected virtual MGATextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  protected virtual MGATextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  protected virtual MGATextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox8")]
  protected virtual MGATextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox9")]
  protected virtual MGATextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox10")]
  protected virtual MGATextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox11")]
  protected virtual MGATextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPhysBuildNum")]
  private virtual MGATextBox txtPhysBuildNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabLocationInfo")]
  protected virtual UltraTabPageControl tabLocationInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabAdditionalInfo")]
  protected virtual UltraTabPageControl tabAdditionalInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabYears")]
  protected virtual UltraTabPageControl tabYears { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabInspectionInfo")]
  protected virtual UltraTabPageControl tabInspectionInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboConstruction")]
  protected virtual MGASimpleComboBox cboConstruction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkAddInsured
  {
    get => this._lnkAddInsured;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddInsured_LinkClicked);
      LinkLabel lnkAddInsured1 = this._lnkAddInsured;
      if (lnkAddInsured1 != null)
        lnkAddInsured1.LinkClicked -= clickedEventHandler;
      this._lnkAddInsured = value;
      LinkLabel lnkAddInsured2 = this._lnkAddInsured;
      if (lnkAddInsured2 == null)
        return;
      lnkAddInsured2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual MGASimpleComboBox cboInspectionCompanies
  {
    get => this._cboInspectionCompanies;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboInspectionCompanies_ValueChanged);
      MGASimpleComboBox inspectionCompanies1 = this._cboInspectionCompanies;
      if (inspectionCompanies1 != null)
        inspectionCompanies1.ValueChanged -= eventHandler;
      this._cboInspectionCompanies = value;
      MGASimpleComboBox inspectionCompanies2 = this._cboInspectionCompanies;
      if (inspectionCompanies2 == null)
        return;
      inspectionCompanies2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkInspectionRequired")]
  private virtual MGACheckBox chkInspectionRequired { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkEditConstructionTypes
  {
    get => this._lnkEditConstructionTypes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkEditConstructionTypes_LinkClicked);
      LinkLabel constructionTypes1 = this._lnkEditConstructionTypes;
      if (constructionTypes1 != null)
        constructionTypes1.LinkClicked -= clickedEventHandler;
      this._lnkEditConstructionTypes = value;
      LinkLabel constructionTypes2 = this._lnkEditConstructionTypes;
      if (constructionTypes2 == null)
        return;
      constructionTypes2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkEditClassCodes
  {
    get => this._lnkEditClassCodes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkEditClassCodes_LinkClicked);
      LinkLabel lnkEditClassCodes1 = this._lnkEditClassCodes;
      if (lnkEditClassCodes1 != null)
        lnkEditClassCodes1.LinkClicked -= clickedEventHandler;
      this._lnkEditClassCodes = value;
      LinkLabel lnkEditClassCodes2 = this._lnkEditClassCodes;
      if (lnkEditClassCodes2 == null)
        return;
      lnkEditClassCodes2.LinkClicked += clickedEventHandler;
    }
  }

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

  [field: AccessedThroughProperty("Label28")]
  protected virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label29")]
  protected virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label30")]
  protected virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboFireAlarmType")]
  protected virtual MGASimpleComboBox cboFireAlarmType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboBurglarAlarmType")]
  protected virtual MGASimpleComboBox cboBurglarAlarmType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboSprinklerSystem")]
  protected virtual MGASimpleComboBox cboSprinklerSystem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkLockedSecure")]
  protected virtual MGACheckBox chkLockedSecure { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkVacant")]
  protected virtual MGACheckBox chkVacant { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabControl1")]
  protected virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  protected virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInspectionContact")]
  protected virtual MGATextBox txtInspectionContact { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDistToFireStattion")]
  protected virtual MGANumericEditor txtDistToFireStattion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabGeoAddress")]
  protected virtual UltraTabPageControl tabGeoAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("zipCodeResolverGEO")]
  protected virtual MGA_ZipCodeResolver zipCodeResolverGEO { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtGEOPhysBuildNum")]
  protected virtual MGATextBox txtGEOPhysBuildNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label32")]
  protected virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkUseLocationAddress
  {
    get => this._lnkUseLocationAddress;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkUseLocationAddress_LinkClicked);
      LinkLabel useLocationAddress1 = this._lnkUseLocationAddress;
      if (useLocationAddress1 != null)
        useLocationAddress1.LinkClicked -= clickedEventHandler;
      this._lnkUseLocationAddress = value;
      LinkLabel useLocationAddress2 = this._lnkUseLocationAddress;
      if (useLocationAddress2 == null)
        return;
      useLocationAddress2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGACheckBox MgaCheckBox2
  {
    get => this._MgaCheckBox2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MgaCheckBox2_CheckedChanged);
      MGACheckBox mgaCheckBox2_1 = this._MgaCheckBox2;
      if (mgaCheckBox2_1 != null)
        ((UltraToggleEditorBase) mgaCheckBox2_1).CheckedChanged -= eventHandler;
      this._MgaCheckBox2 = value;
      MGACheckBox mgaCheckBox2_2 = this._MgaCheckBox2;
      if (mgaCheckBox2_2 == null)
        return;
      ((UltraToggleEditorBase) mgaCheckBox2_2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("MgaCheckBox1")]
  private virtual MGACheckBox MgaCheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label33")]
  private virtual Label Label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtDueDate")]
  protected virtual MGADateTimePicker dtDueDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkDefaultWarranties
  {
    get => this._lnkDefaultWarranties;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDefaultWarranties_LinkClicked);
      LinkLabel defaultWarranties1 = this._lnkDefaultWarranties;
      if (defaultWarranties1 != null)
        defaultWarranties1.LinkClicked -= clickedEventHandler;
      this._lnkDefaultWarranties = value;
      LinkLabel defaultWarranties2 = this._lnkDefaultWarranties;
      if (defaultWarranties2 == null)
        return;
      defaultWarranties2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkShowMap
  {
    get => this._lnkShowMap;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkShowMap_LinkClicked);
      LinkLabel lnkShowMap1 = this._lnkShowMap;
      if (lnkShowMap1 != null)
        lnkShowMap1.LinkClicked -= clickedEventHandler;
      this._lnkShowMap = value;
      LinkLabel lnkShowMap2 = this._lnkShowMap;
      if (lnkShowMap2 == null)
        return;
      lnkShowMap2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblBaseId")]
  private virtual Label lblBaseId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBaseIdDisplay")]
  private virtual Label lblBaseIdDisplay { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkLocationLookup")]
  protected virtual MGACheckBox chkLocationLookup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox1")]
  protected virtual MGATextBox MgaTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox2")]
  protected virtual MGATextBox MgaTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  protected virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label34")]
  protected virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  protected virtual MGATextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  protected virtual MGATextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  protected virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  protected virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingEdit);
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedNew);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingDelete);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingEdit -= cancelEventHandler1;
        dbSave1.ClickedNew -= eventHandler1;
        dbSave1.UIStateChanged -= eventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickedCancel -= eventHandler3;
        dbSave1.ClickingDelete -= cancelEventHandler3;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingEdit += cancelEventHandler1;
      dbSave2.ClickedNew += eventHandler1;
      dbSave2.UIStateChanged += eventHandler2;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickedCancel += eventHandler3;
      dbSave2.ClickingDelete += cancelEventHandler3;
    }
  }

  [field: AccessedThroughProperty("lblRoofInspectionCompany")]
  protected virtual Label lblRoofInspectionCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboRoofInspectionCompany")]
  protected virtual MGASimpleComboBox cboRoofInspectionCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cmbtxtFloodZone")]
  protected virtual ComboBox cmbtxtFloodZone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkRoofInspectionsInfo
  {
    get => this._lnkRoofInspectionsInfo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkRoofInspectionsInfo_LinkClicked);
      LinkLabel roofInspectionsInfo1 = this._lnkRoofInspectionsInfo;
      if (roofInspectionsInfo1 != null)
        roofInspectionsInfo1.LinkClicked -= clickedEventHandler;
      this._lnkRoofInspectionsInfo = value;
      LinkLabel roofInspectionsInfo2 = this._lnkRoofInspectionsInfo;
      if (roofInspectionsInfo2 == null)
        return;
      roofInspectionsInfo2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkDeSelectAllDelete
  {
    get => this._lnkDeSelectAllDelete;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAllDelete_LinkClicked);
      LinkLabel deSelectAllDelete1 = this._lnkDeSelectAllDelete;
      if (deSelectAllDelete1 != null)
        deSelectAllDelete1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAllDelete = value;
      LinkLabel deSelectAllDelete2 = this._lnkDeSelectAllDelete;
      if (deSelectAllDelete2 == null)
        return;
      deSelectAllDelete2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkDeleteSelectAll
  {
    get => this._lnkDeleteSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeleteSelectAll_LinkClicked);
      LinkLabel lnkDeleteSelectAll1 = this._lnkDeleteSelectAll;
      if (lnkDeleteSelectAll1 != null)
        lnkDeleteSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkDeleteSelectAll = value;
      LinkLabel lnkDeleteSelectAll2 = this._lnkDeleteSelectAll;
      if (lnkDeleteSelectAll2 == null)
        return;
      lnkDeleteSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkAddContacts
  {
    get => this._lnkAddContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddContacts_LinkClicked);
      LinkLabel lnkAddContacts1 = this._lnkAddContacts;
      if (lnkAddContacts1 != null)
        lnkAddContacts1.LinkClicked -= clickedEventHandler;
      this._lnkAddContacts = value;
      LinkLabel lnkAddContacts2 = this._lnkAddContacts;
      if (lnkAddContacts2 == null)
        return;
      lnkAddContacts2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkCopyInspectionInfo
  {
    get => this._lnkCopyInspectionInfo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopyInspectionInfo_LinkClicked);
      LinkLabel copyInspectionInfo1 = this._lnkCopyInspectionInfo;
      if (copyInspectionInfo1 != null)
        copyInspectionInfo1.LinkClicked -= clickedEventHandler;
      this._lnkCopyInspectionInfo = value;
      LinkLabel copyInspectionInfo2 = this._lnkCopyInspectionInfo;
      if (copyInspectionInfo2 == null)
        return;
      copyInspectionInfo2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkCopyLocation
  {
    get => this._lnkCopyLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopyLocation_LinkClicked);
      LinkLabel lnkCopyLocation1 = this._lnkCopyLocation;
      if (lnkCopyLocation1 != null)
        lnkCopyLocation1.LinkClicked -= clickedEventHandler;
      this._lnkCopyLocation = value;
      LinkLabel lnkCopyLocation2 = this._lnkCopyLocation;
      if (lnkCopyLocation2 == null)
        return;
      lnkCopyLocation2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtContactEmail")]
  protected virtual MGATextBox txtContactEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblContactEmail")]
  protected virtual Label lblContactEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkWindCoverage")]
  protected virtual MGACheckBox chkWindCoverage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    UltraGridBand ultraGridBand = new UltraGridBand("tblUnderwritingLocations", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LocationGUID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("QuoteGUID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("LocationNo");
    Appearance appearance41 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("BuildingNo");
    Appearance appearance42 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("PhysicalBuildingNo");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("County");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Zip");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ZipPlus");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ConstructionID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ClassCodeID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("ProtectionCode");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("AddnInformation");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("SqFootage");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("EQZone");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("FloodZone");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("EQConstruction");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("WindCoverage");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("Territory");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("TaxTerritory");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("Inspect");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("Photo");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Diagram");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("CostEstimator");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("UserAdded");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("DateAdded");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("DistToFireHydrant");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("DistToFireStation");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("FireDistrict");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("Stories");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("Basements");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("Elevators");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("YearBuilt");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("WiringYear");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("RoofingYear");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("PlumbingYear");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("HeatingYear");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("ModificationCode");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("InspectionCompanyID");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("InspectionContact");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("InspectionContactPhone");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("Comments");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("FireAlarmTypeID");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("BurglarAlarmTypeID");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("SprinklerTypeID");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("LockedAndSecured");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("Vacant");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("WindRestrictionID");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("GEOPhyBuildNum");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("GEOAddress1");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("GEOAddress2");
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("GEOCity");
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("GEOState");
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("GEOCounty");
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("GEOZip");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("GEOZipPlus");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("RecCheck");
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("Rush");
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("Latitude");
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("Longitude");
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("GeoStatus");
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("GeoURL");
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("LocationLookup");
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("BaseLocationId");
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("DeleteRecord");
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("RoofInspectionCompanyID");
    UltraGridColumn ultraGridColumn72 = new UltraGridColumn("ContactEmail");
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance50 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance51 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmUnderwritingLocations));
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance52 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance53 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance54 = new Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Appearance appearance55 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("contextMenu");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("contextMenu");
    ButtonTool buttonTool1 = new ButtonTool("Copy Location");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("contextMenu");
    ButtonTool buttonTool2 = new ButtonTool("Copy Location");
    ButtonTool buttonTool3 = new ButtonTool("Restore Location");
    ButtonTool buttonTool4 = new ButtonTool("Restore Location");
    this.tabLocationInfo = new UltraTabPageControl();
    this.lnkCopyLocation = new LinkLabel();
    this.lblBaseIdDisplay = new Label();
    this.lblBaseId = new Label();
    this.ds = new dsUnderwritingLocations();
    this.lnkShowMap = new LinkLabel();
    this.Label31 = new Label();
    this.cboWindRestriction = new MGASimpleComboBox();
    this.dvWindRestriction = new DataView();
    this.lnkEditClassCodes = new LinkLabel();
    this.lnkEditConstructionTypes = new LinkLabel();
    this.cboPolicyClasses = new MGASimpleComboBox();
    this.cboConstruction = new MGASimpleComboBox();
    this.txtLocationNum = new MGATextBox();
    this.txtBuildingNum = new MGATextBox();
    this.txtPhysBuildNum = new MGATextBox();
    this.txtProtectionCode = new MGATextBox();
    this.Label6 = new Label();
    this.lblClass = new Label();
    this.Label4 = new Label();
    this.ZipCodeResolver1 = new MGA_ZipCodeResolver();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.Label14 = new Label();
    this.txtTerritory = new MGATextBox();
    this.tabGeoAddress = new UltraTabPageControl();
    this.MgaTextBox1 = new MGATextBox();
    this.MgaTextBox2 = new MGATextBox();
    this.Label5 = new Label();
    this.Label34 = new Label();
    this.lnkUseLocationAddress = new LinkLabel();
    this.zipCodeResolverGEO = new MGA_ZipCodeResolver();
    this.txtGEOPhysBuildNum = new MGATextBox();
    this.Label32 = new Label();
    this.tabAdditionalInfo = new UltraTabPageControl();
    this.cmbtxtFloodZone = new ComboBox();
    this.txtDistToFireStattion = new MGANumericEditor();
    this.chkVacant = new MGACheckBox();
    this.chkLockedSecure = new MGACheckBox();
    this.cboSprinklerSystem = new MGASimpleComboBox();
    this.cboBurglarAlarmType = new MGASimpleComboBox();
    this.dvBurglar = new DataView();
    this.cboFireAlarmType = new MGASimpleComboBox();
    this.dvFire = new DataView();
    this.Label30 = new Label();
    this.Label29 = new Label();
    this.Label28 = new Label();
    this.TextBox6 = new MGATextBox();
    this.TextBox5 = new MGATextBox();
    this.TextBox3 = new MGATextBox();
    this.TextBox2 = new MGATextBox();
    this.TextBox1 = new MGATextBox();
    this.chkWindCoverage = new MGACheckBox();
    this.Label18 = new Label();
    this.Label17 = new Label();
    this.Label16 = new Label();
    this.Label15 = new Label();
    this.txtTaxTerritory = new MGATextBox();
    this.Label13 = new Label();
    this.txtEQConst = new MGATextBox();
    this.Label12 = new Label();
    this.Label11 = new Label();
    this.txtEarthquakeZone = new MGATextBox();
    this.Label10 = new Label();
    this.txtAdditionalInfo = new MGATextBox();
    this.Label9 = new Label();
    this.Label8 = new Label();
    this.Label7 = new Label();
    this.lnkDeSelectAllDelete = new LinkLabel();
    this.lnkDeleteSelectAll = new LinkLabel();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.lnkAddInsured = new LinkLabel();
    this.tabYears = new UltraTabPageControl();
    this.TextBox11 = new MGATextBox();
    this.TextBox10 = new MGATextBox();
    this.TextBox9 = new MGATextBox();
    this.TextBox8 = new MGATextBox();
    this.TextBox7 = new MGATextBox();
    this.Label22 = new Label();
    this.Label19 = new Label();
    this.Label20 = new Label();
    this.Label23 = new Label();
    this.Label21 = new Label();
    this.tabInspectionInfo = new UltraTabPageControl();
    this.lblContactEmail = new Label();
    this.txtContactEmail = new MGATextBox();
    this.lnkCopyInspectionInfo = new LinkLabel();
    this.lnkAddContacts = new LinkLabel();
    this.lnkRoofInspectionsInfo = new LinkLabel();
    this.lblRoofInspectionCompany = new Label();
    this.cboRoofInspectionCompany = new MGASimpleComboBox();
    this.chkLocationLookup = new MGACheckBox();
    this.lnkDefaultWarranties = new LinkLabel();
    this.Label33 = new Label();
    this.dtDueDate = new MGADateTimePicker();
    this.MgaCheckBox2 = new MGACheckBox();
    this.MgaCheckBox1 = new MGACheckBox();
    this.txtComments = new MGATextBox();
    this.Label27 = new Label();
    this.txtContactPhone = new MGAMaskedEdit();
    this.Label26 = new Label();
    this.txtInspectionContact = new MGATextBox();
    this.Label25 = new Label();
    this.Label24 = new Label();
    this.cboInspectionCompanies = new MGASimpleComboBox();
    this.CheckBox4 = new MGACheckBox();
    this.CheckBox3 = new MGACheckBox();
    this.CheckBox2 = new MGACheckBox();
    this.chkInspectionRequired = new MGACheckBox();
    this.dgLocations = new UltraGrid();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.cn = new SqlConnection();
    this.daLocation = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.err = new ErrorProvider(this.components);
    this._frmUnderwritingLocations_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._frmUnderwritingLocations_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmUnderwritingLocations_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmUnderwritingLocations_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((Control) this.tabLocationInfo).SuspendLayout();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboWindRestriction).BeginInit();
    this.dvWindRestriction.BeginInit();
    ((ISupportInitialize) this.cboPolicyClasses).BeginInit();
    ((ISupportInitialize) this.cboConstruction).BeginInit();
    ((ISupportInitialize) this.txtLocationNum).BeginInit();
    ((ISupportInitialize) this.txtBuildingNum).BeginInit();
    ((ISupportInitialize) this.txtPhysBuildNum).BeginInit();
    ((ISupportInitialize) this.txtProtectionCode).BeginInit();
    ((ISupportInitialize) this.txtTerritory).BeginInit();
    ((Control) this.tabGeoAddress).SuspendLayout();
    ((ISupportInitialize) this.MgaTextBox1).BeginInit();
    ((ISupportInitialize) this.MgaTextBox2).BeginInit();
    ((ISupportInitialize) this.txtGEOPhysBuildNum).BeginInit();
    ((Control) this.tabAdditionalInfo).SuspendLayout();
    ((ISupportInitialize) this.txtDistToFireStattion).BeginInit();
    ((ISupportInitialize) this.chkVacant).BeginInit();
    ((ISupportInitialize) this.chkLockedSecure).BeginInit();
    ((ISupportInitialize) this.cboSprinklerSystem).BeginInit();
    ((ISupportInitialize) this.cboBurglarAlarmType).BeginInit();
    this.dvBurglar.BeginInit();
    ((ISupportInitialize) this.cboFireAlarmType).BeginInit();
    this.dvFire.BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.chkWindCoverage).BeginInit();
    ((ISupportInitialize) this.txtTaxTerritory).BeginInit();
    ((ISupportInitialize) this.txtEQConst).BeginInit();
    ((ISupportInitialize) this.txtEarthquakeZone).BeginInit();
    ((ISupportInitialize) this.txtAdditionalInfo).BeginInit();
    ((Control) this.tabYears).SuspendLayout();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((Control) this.tabInspectionInfo).SuspendLayout();
    ((ISupportInitialize) this.txtContactEmail).BeginInit();
    ((ISupportInitialize) this.cboRoofInspectionCompany).BeginInit();
    ((ISupportInitialize) this.chkLocationLookup).BeginInit();
    ((ISupportInitialize) this.dtDueDate).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox2).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox1).BeginInit();
    ((ISupportInitialize) this.txtComments).BeginInit();
    ((ISupportInitialize) this.txtContactPhone).BeginInit();
    ((ISupportInitialize) this.txtInspectionContact).BeginInit();
    ((ISupportInitialize) this.cboInspectionCompanies).BeginInit();
    ((ISupportInitialize) this.CheckBox4).BeginInit();
    ((ISupportInitialize) this.CheckBox3).BeginInit();
    ((ISupportInitialize) this.CheckBox2).BeginInit();
    ((ISupportInitialize) this.chkInspectionRequired).BeginInit();
    ((ISupportInitialize) this.dgLocations).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.lnkCopyLocation);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.lblBaseIdDisplay);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.lblBaseId);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.lnkShowMap);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.Label31);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.cboWindRestriction);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.lnkEditClassCodes);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.lnkEditConstructionTypes);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.cboPolicyClasses);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.cboConstruction);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.txtLocationNum);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.txtBuildingNum);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.txtPhysBuildNum);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.txtProtectionCode);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.Label6);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.lblClass);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.Label4);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.ZipCodeResolver1);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.Label3);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.Label2);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.Label1);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.Label14);
    ((Control) this.tabLocationInfo).Controls.Add((Control) this.txtTerritory);
    ((Control) this.tabLocationInfo).Location = new Point(-10000, -10000);
    ((Control) this.tabLocationInfo).Name = "tabLocationInfo";
    ((Control) this.tabLocationInfo).Size = new Size(674, 301);
    this.lnkCopyLocation.AutoSize = true;
    this.lnkCopyLocation.BackColor = Color.Transparent;
    this.lnkCopyLocation.Location = new Point(322, 123);
    this.lnkCopyLocation.Name = "lnkCopyLocation";
    this.lnkCopyLocation.Size = new Size(173, 13);
    this.lnkCopyLocation.TabIndex = 184;
    this.lnkCopyLocation.TabStop = true;
    this.lnkCopyLocation.Text = "Copy Location(s) to Another Policy";
    this.lblBaseIdDisplay.BackColor = Color.Transparent;
    this.lblBaseIdDisplay.Location = new Point(177, 19);
    this.lblBaseIdDisplay.Name = "lblBaseIdDisplay";
    this.lblBaseIdDisplay.Size = new Size(50, 13);
    this.lblBaseIdDisplay.TabIndex = 183;
    this.lblBaseIdDisplay.Text = "Base Id:";
    this.lblBaseIdDisplay.TextAlign = ContentAlignment.TopRight;
    this.lblBaseIdDisplay.Visible = false;
    this.lblBaseId.BackColor = Color.Transparent;
    this.lblBaseId.DataBindings.Add(new Binding("Text", (object) this.ds, "tblUnderwritingLocations.BaseLocationId", true));
    this.lblBaseId.Location = new Point(224 /*0xE0*/, 19);
    this.lblBaseId.Name = "lblBaseId";
    this.lblBaseId.Size = new Size(79, 13);
    this.lblBaseId.TabIndex = 182;
    this.ds.DataSetName = "dsUnderwritingLocations";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lnkShowMap.AutoSize = true;
    this.lnkShowMap.Location = new Point(322, 98);
    this.lnkShowMap.Name = "lnkShowMap";
    this.lnkShowMap.Size = new Size(70, 13);
    this.lnkShowMap.TabIndex = 180;
    this.lnkShowMap.TabStop = true;
    this.lnkShowMap.Text = "Map Location";
    this.Label31.AutoSize = true;
    this.Label31.BackColor = Color.Transparent;
    this.Label31.Location = new Point(304, 64 /*0x40*/);
    this.Label31.Name = "Label31";
    this.Label31.Size = new Size(89, 13);
    this.Label31.TabIndex = 20;
    this.Label31.Text = "Wind Restriction:";
    this.cboWindRestriction.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboWindRestriction).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.WindRestrictionID", true));
    ((UltraGridBase) this.cboWindRestriction).DataSource = (object) this.dvWindRestriction;
    ((UltraDropDownBase) this.cboWindRestriction).DisplayMember = "Restriction";
    this.cboWindRestriction.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboWindRestriction).DropDownWidth = 300;
    ((Control) this.cboWindRestriction).Location = new Point(400, 64 /*0x40*/);
    this.cboWindRestriction.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboWindRestriction).Name = "cboWindRestriction";
    ((Control) this.cboWindRestriction).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboWindRestriction).TabIndex = 19;
    ((UltraControlBase) this.cboWindRestriction).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboWindRestriction).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboWindRestriction).ValueMember = "RestrictionID";
    this.dvWindRestriction.Table = (DataTable) this.ds.lstWindRestrictions;
    this.lnkEditClassCodes.AutoSize = true;
    this.lnkEditClassCodes.BackColor = Color.Transparent;
    this.lnkEditClassCodes.Location = new Point(290, 256 /*0x0100*/);
    this.lnkEditClassCodes.Name = "lnkEditClassCodes";
    this.lnkEditClassCodes.Size = new Size(112 /*0x70*/, 13);
    this.lnkEditClassCodes.TabIndex = 18;
    this.lnkEditClassCodes.TabStop = true;
    this.lnkEditClassCodes.Text = "(add/edit class codes)";
    this.lnkEditClassCodes.TextAlign = ContentAlignment.MiddleCenter;
    this.lnkEditConstructionTypes.AutoSize = true;
    this.lnkEditConstructionTypes.BackColor = Color.Transparent;
    this.lnkEditConstructionTypes.Location = new Point(290, 232);
    this.lnkEditConstructionTypes.Name = "lnkEditConstructionTypes";
    this.lnkEditConstructionTypes.Size = new Size(147, 13);
    this.lnkEditConstructionTypes.TabIndex = 17;
    this.lnkEditConstructionTypes.TabStop = true;
    this.lnkEditConstructionTypes.Text = "(add/edit construction types)";
    this.lnkEditConstructionTypes.TextAlign = ContentAlignment.MiddleCenter;
    this.cboPolicyClasses.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboPolicyClasses).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.ClassCodeID", true));
    ((UltraGridBase) this.cboPolicyClasses).DataSource = (object) this.ds.lstClassCodes;
    ((UltraDropDownBase) this.cboPolicyClasses).DisplayMember = "ClassCodeDescription";
    this.cboPolicyClasses.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboPolicyClasses).DropDownWidth = 300;
    ((Control) this.cboPolicyClasses).Location = new Point(120, 254);
    this.cboPolicyClasses.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboPolicyClasses).Name = "cboPolicyClasses";
    ((Control) this.cboPolicyClasses).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboPolicyClasses).TabIndex = 10;
    ((UltraControlBase) this.cboPolicyClasses).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPolicyClasses).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboPolicyClasses).ValueMember = "ClassCodeID";
    this.cboConstruction.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboConstruction).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.ConstructionID", true));
    ((UltraGridBase) this.cboConstruction).DataSource = (object) this.ds.lstConstructionTypes;
    ((UltraDropDownBase) this.cboConstruction).DisplayMember = "Type";
    this.cboConstruction.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboConstruction).DropDownWidth = 300;
    ((Control) this.cboConstruction).Location = new Point(120, 232);
    this.cboConstruction.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboConstruction).Name = "cboConstruction";
    ((Control) this.cboConstruction).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboConstruction).TabIndex = 8;
    ((UltraControlBase) this.cboConstruction).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboConstruction).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboConstruction).ValueMember = "ConstructionTypeID";
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLocationNum).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtLocationNum).BackColor = Color.White;
    ((Control) this.txtLocationNum).DataBindings.Add(new Binding("Text", (object) this.ds, "tblUnderwritingLocations.LocationNo", true));
    ((Control) this.txtLocationNum).Location = new Point(120, 16 /*0x10*/);
    ((TextEditorControlBase) this.txtLocationNum).MaxLength = 4;
    this.txtLocationNum.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLocationNum).Name = "txtLocationNum";
    ((Control) this.txtLocationNum).Size = new Size(56, 20);
    ((Control) this.txtLocationNum).TabIndex = 1;
    ((UltraControlBase) this.txtLocationNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLocationNum).UseOsThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtBuildingNum).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtBuildingNum).BackColor = Color.White;
    ((Control) this.txtBuildingNum).DataBindings.Add(new Binding("Text", (object) this.ds, "tblUnderwritingLocations.BuildingNo", true));
    ((Control) this.txtBuildingNum).Location = new Point(120, 40);
    ((TextEditorControlBase) this.txtBuildingNum).MaxLength = 20;
    this.txtBuildingNum.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtBuildingNum).Name = "txtBuildingNum";
    ((Control) this.txtBuildingNum).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.txtBuildingNum).TabIndex = 3;
    ((UltraControlBase) this.txtBuildingNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtBuildingNum).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPhysBuildNum).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtPhysBuildNum).BackColor = Color.White;
    ((Control) this.txtPhysBuildNum).DataBindings.Add(new Binding("Text", (object) this.ds, "tblUnderwritingLocations.PhysicalBuildingNo", true));
    ((Control) this.txtPhysBuildNum).Location = new Point(120, 64 /*0x40*/);
    ((TextEditorControlBase) this.txtPhysBuildNum).MaxLength = 50;
    this.txtPhysBuildNum.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPhysBuildNum).Name = "txtPhysBuildNum";
    ((Control) this.txtPhysBuildNum).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.txtPhysBuildNum).TabIndex = 5;
    ((UltraControlBase) this.txtPhysBuildNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPhysBuildNum).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtProtectionCode).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtProtectionCode).BackColor = Color.White;
    ((Control) this.txtProtectionCode).DataBindings.Add(new Binding("Text", (object) this.ds, "tblUnderwritingLocations.ProtectionCode", true));
    ((Control) this.txtProtectionCode).Location = new Point(400, 16 /*0x10*/);
    ((TextEditorControlBase) this.txtProtectionCode).MaxLength = 5;
    this.txtProtectionCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtProtectionCode).Name = "txtProtectionCode";
    ((Control) this.txtProtectionCode).Size = new Size(53, 20);
    ((Control) this.txtProtectionCode).TabIndex = 12;
    ((UltraControlBase) this.txtProtectionCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProtectionCode).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(304, 18);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(88, 13);
    this.Label6.TabIndex = 11;
    this.Label6.Text = "Protection Code:";
    this.lblClass.AutoSize = true;
    this.lblClass.BackColor = Color.Transparent;
    this.lblClass.Location = new Point(71, 258);
    this.lblClass.Name = "lblClass";
    this.lblClass.Size = new Size(36, 13);
    this.lblClass.TabIndex = 9;
    this.lblClass.Text = "Class:";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(35, 236);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(72, 13);
    this.Label4.TabIndex = 7;
    this.Label4.Text = "Construction:";
    this.ZipCodeResolver1.AddressServiceURL = "";
    this.ZipCodeResolver1.AudibleAlerts = false;
    this.ZipCodeResolver1.AutoScrollMargin = new Size(0, 0);
    this.ZipCodeResolver1.AutoScrollMinSize = new Size(0, 0);
    this.ZipCodeResolver1.BackColor = Color.Transparent;
    this.ZipCodeResolver1.City = "";
    this.ZipCodeResolver1.County = "";
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("City", (object) this.ds, "tblUnderwritingLocations.City", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("County", (object) this.ds, "tblUnderwritingLocations.County", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("State", (object) this.ds, "tblUnderwritingLocations.State", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("Street1", (object) this.ds, "tblUnderwritingLocations.Address1", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("Street2", (object) this.ds, "tblUnderwritingLocations.Address2", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("ZipCode", (object) this.ds, "tblUnderwritingLocations.Zip", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("ZipCodeExtension", (object) this.ds, "tblUnderwritingLocations.ZipPlus", true));
    this.ZipCodeResolver1.GeoRegion = "";
    this.ZipCodeResolver1.ISOCountryCode = "";
    this.ZipCodeResolver1.ISOCountryCodeMember = "";
    this.ZipCodeResolver1.ISOCountryList = (object) null;
    this.ZipCodeResolver1.ISOCountryNameMember = "";
    ((Control) this.ZipCodeResolver1).Location = new Point(56, 83);
    this.ZipCodeResolver1.MGAStyle = MGAStyles.Blue;
    ((Control) this.ZipCodeResolver1).Name = "ZipCodeResolver1";
    this.ZipCodeResolver1.Password = "";
    this.ZipCodeResolver1.ShowGlobal = true;
    ((Control) this.ZipCodeResolver1).Size = new Size(232, 146);
    this.ZipCodeResolver1.State = "";
    this.ZipCodeResolver1.Street1 = "";
    this.ZipCodeResolver1.Street2 = "";
    ((Control) this.ZipCodeResolver1).TabIndex = 6;
    this.ZipCodeResolver1.UserID = "";
    this.ZipCodeResolver1.ZipCode = "";
    this.ZipCodeResolver1.ZipCodeExtension = "";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(8, 66);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(99, 13);
    this.Label3.TabIndex = 4;
    this.Label3.Text = "Physical Building #:";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(51, 42);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(58, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Building #:";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(49, 18);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(62, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Location #:";
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(340, 42);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(53, 13);
    this.Label14.TabIndex = 13;
    this.Label14.Text = "Territory:";
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTerritory).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtTerritory).BackColor = Color.White;
    ((Control) this.txtTerritory).DataBindings.Add(new Binding("Text", (object) this.ds, "tblUnderwritingLocations.Territory", true));
    ((Control) this.txtTerritory).Location = new Point(400, 40);
    ((TextEditorControlBase) this.txtTerritory).MaxLength = 3;
    this.txtTerritory.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtTerritory).Name = "txtTerritory";
    ((Control) this.txtTerritory).Size = new Size(53, 20);
    ((Control) this.txtTerritory).TabIndex = 14;
    ((UltraControlBase) this.txtTerritory).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTerritory).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tabGeoAddress).Controls.Add((Control) this.MgaTextBox1);
    ((Control) this.tabGeoAddress).Controls.Add((Control) this.MgaTextBox2);
    ((Control) this.tabGeoAddress).Controls.Add((Control) this.Label5);
    ((Control) this.tabGeoAddress).Controls.Add((Control) this.Label34);
    ((Control) this.tabGeoAddress).Controls.Add((Control) this.lnkUseLocationAddress);
    ((Control) this.tabGeoAddress).Controls.Add((Control) this.zipCodeResolverGEO);
    ((Control) this.tabGeoAddress).Controls.Add((Control) this.txtGEOPhysBuildNum);
    ((Control) this.tabGeoAddress).Controls.Add((Control) this.Label32);
    ((Control) this.tabGeoAddress).Location = new Point(-10000, -10000);
    ((Control) this.tabGeoAddress).Name = "tabGeoAddress";
    ((Control) this.tabGeoAddress).Size = new Size(674, 301);
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox1).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.MgaTextBox1).BackColor = Color.White;
    ((Control) this.MgaTextBox1).CausesValidation = false;
    ((Control) this.MgaTextBox1).DataBindings.Add(new Binding("Text", (object) this.ds, "tblUnderwritingLocations.Latitude", true));
    ((Control) this.MgaTextBox1).Location = new Point(126, 180);
    ((TextEditorControlBase) this.MgaTextBox1).MaxLength = 200;
    this.MgaTextBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox1).Name = "MgaTextBox1";
    ((Control) this.MgaTextBox1).Size = new Size(157, 20);
    ((Control) this.MgaTextBox1).TabIndex = 21;
    ((Control) this.MgaTextBox1).Tag = (object) "n";
    ((UltraControlBase) this.MgaTextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox1).UseOsThemes = (DefaultableBoolean) 2;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox2).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.MgaTextBox2).BackColor = Color.White;
    ((Control) this.MgaTextBox2).CausesValidation = false;
    ((Control) this.MgaTextBox2).DataBindings.Add(new Binding("Text", (object) this.ds, "tblUnderwritingLocations.Longitude", true));
    ((Control) this.MgaTextBox2).Location = new Point(126, 210);
    ((TextEditorControlBase) this.MgaTextBox2).MaxLength = 200;
    this.MgaTextBox2.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox2).Name = "MgaTextBox2";
    ((Control) this.MgaTextBox2).Size = new Size(157, 20);
    ((Control) this.MgaTextBox2).TabIndex = 22;
    ((Control) this.MgaTextBox2).Tag = (object) "n";
    ((UltraControlBase) this.MgaTextBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox2).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(51, 214);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(58, 13);
    this.Label5.TabIndex = 24;
    this.Label5.Text = "Longitude:";
    this.Label34.AutoSize = true;
    this.Label34.BackColor = Color.Transparent;
    this.Label34.Location = new Point(59, 187);
    this.Label34.Name = "Label34";
    this.Label34.Size = new Size(50, 13);
    this.Label34.TabIndex = 23;
    this.Label34.Text = "Latitude:";
    this.lnkUseLocationAddress.AutoSize = true;
    this.lnkUseLocationAddress.BackColor = Color.Transparent;
    this.lnkUseLocationAddress.Location = new Point(123, 243);
    this.lnkUseLocationAddress.Name = "lnkUseLocationAddress";
    this.lnkUseLocationAddress.Size = new Size(110, 13);
    this.lnkUseLocationAddress.TabIndex = 20;
    this.lnkUseLocationAddress.TabStop = true;
    this.lnkUseLocationAddress.Text = "Use Location Address";
    this.lnkUseLocationAddress.TextAlign = ContentAlignment.MiddleCenter;
    this.zipCodeResolverGEO.AddressServiceURL = "";
    this.zipCodeResolverGEO.AudibleAlerts = false;
    this.zipCodeResolverGEO.AutoScrollMargin = new Size(0, 0);
    this.zipCodeResolverGEO.AutoScrollMinSize = new Size(0, 0);
    this.zipCodeResolverGEO.BackColor = Color.Transparent;
    this.zipCodeResolverGEO.City = "";
    this.zipCodeResolverGEO.County = "";
    ((Control) this.zipCodeResolverGEO).DataBindings.Add(new Binding("City", (object) this.ds, "tblUnderwritingLocations.GEOCity", true));
    ((Control) this.zipCodeResolverGEO).DataBindings.Add(new Binding("County", (object) this.ds, "tblUnderwritingLocations.GEOCounty", true));
    ((Control) this.zipCodeResolverGEO).DataBindings.Add(new Binding("State", (object) this.ds, "tblUnderwritingLocations.GEOState", true));
    ((Control) this.zipCodeResolverGEO).DataBindings.Add(new Binding("Street1", (object) this.ds, "tblUnderwritingLocations.GEOAddress1", true));
    ((Control) this.zipCodeResolverGEO).DataBindings.Add(new Binding("Street2", (object) this.ds, "tblUnderwritingLocations.GEOAddress2", true));
    ((Control) this.zipCodeResolverGEO).DataBindings.Add(new Binding("ZipCode", (object) this.ds, "tblUnderwritingLocations.GEOZip", true));
    ((Control) this.zipCodeResolverGEO).DataBindings.Add(new Binding("ZipCodeExtension", (object) this.ds, "tblUnderwritingLocations.GEOZipPlus", true));
    this.zipCodeResolverGEO.GeoRegion = "";
    this.zipCodeResolverGEO.ISOCountryCode = "";
    this.zipCodeResolverGEO.ISOCountryCodeMember = "";
    this.zipCodeResolverGEO.ISOCountryList = (object) null;
    this.zipCodeResolverGEO.ISOCountryNameMember = "";
    ((Control) this.zipCodeResolverGEO).Location = new Point(62, 29);
    this.zipCodeResolverGEO.MGAStyle = MGAStyles.Blue;
    ((Control) this.zipCodeResolverGEO).Name = "zipCodeResolverGEO";
    this.zipCodeResolverGEO.Password = "";
    this.zipCodeResolverGEO.ShowGlobal = true;
    ((Control) this.zipCodeResolverGEO).Size = new Size(231, 145);
    this.zipCodeResolverGEO.State = "";
    this.zipCodeResolverGEO.Street1 = "";
    this.zipCodeResolverGEO.Street2 = "";
    ((Control) this.zipCodeResolverGEO).TabIndex = 19;
    this.zipCodeResolverGEO.UserID = "";
    this.zipCodeResolverGEO.ZipCode = "";
    this.zipCodeResolverGEO.ZipCodeExtension = "";
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtGEOPhysBuildNum).Appearance = (AppearanceBase) appearance8;
    ((TextEditorControlBase) this.txtGEOPhysBuildNum).BackColor = Color.White;
    ((Control) this.txtGEOPhysBuildNum).DataBindings.Add(new Binding("Text", (object) this.ds, "tblUnderwritingLocations.GEOPhyBuildNum", true));
    ((Control) this.txtGEOPhysBuildNum).Location = new Point(126, 6);
    ((TextEditorControlBase) this.txtGEOPhysBuildNum).MaxLength = 50;
    this.txtGEOPhysBuildNum.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtGEOPhysBuildNum).Name = "txtGEOPhysBuildNum";
    ((Control) this.txtGEOPhysBuildNum).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.txtGEOPhysBuildNum).TabIndex = 18;
    ((UltraControlBase) this.txtGEOPhysBuildNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtGEOPhysBuildNum).UseOsThemes = (DefaultableBoolean) 2;
    this.Label32.AutoSize = true;
    this.Label32.BackColor = Color.Transparent;
    this.Label32.Location = new Point(10, 13);
    this.Label32.Name = "Label32";
    this.Label32.Size = new Size(99, 13);
    this.Label32.TabIndex = 17;
    this.Label32.Text = "Physical Building #:";
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.cmbtxtFloodZone);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.txtDistToFireStattion);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.chkVacant);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.chkLockedSecure);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.cboSprinklerSystem);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.cboBurglarAlarmType);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.cboFireAlarmType);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.Label30);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.Label29);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.Label28);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.TextBox6);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.TextBox5);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.TextBox3);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.TextBox2);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.TextBox1);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.chkWindCoverage);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.Label18);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.Label17);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.Label16);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.Label15);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.txtTaxTerritory);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.Label13);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.txtEQConst);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.Label12);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.Label11);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.txtEarthquakeZone);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.Label10);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.txtAdditionalInfo);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.Label9);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.Label8);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.Label7);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.lnkDeSelectAllDelete);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.lnkDeleteSelectAll);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.dbSave);
    ((Control) this.tabAdditionalInfo).Controls.Add((Control) this.lnkAddInsured);
    ((Control) this.tabAdditionalInfo).Location = new Point(1, 26);
    ((Control) this.tabAdditionalInfo).Name = "tabAdditionalInfo";
    ((Control) this.tabAdditionalInfo).Size = new Size(674, 301);
    this.cmbtxtFloodZone.DataSource = (object) this.ds;
    this.cmbtxtFloodZone.DisplayMember = "lstFloodZones.FloodZone";
    this.cmbtxtFloodZone.Location = new Point(368, 39);
    this.cmbtxtFloodZone.MaxLength = 25;
    this.cmbtxtFloodZone.Name = "cmbtxtFloodZone";
    this.cmbtxtFloodZone.Size = new Size(224 /*0xE0*/, 21);
    this.cmbtxtFloodZone.TabIndex = 26;
    this.cmbtxtFloodZone.ValueMember = "lstFloodZones.FloodZone";
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtDistToFireStattion).Appearance = (AppearanceBase) appearance9;
    ((Control) this.txtDistToFireStattion).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.DistToFireStation", true));
    ((UltraNumericEditorBase) this.txtDistToFireStattion).FormatString = "";
    ((Control) this.txtDistToFireStattion).Location = new Point(152, 64 /*0x40*/);
    this.txtDistToFireStattion.MaskInput = "nnnn.n";
    this.txtDistToFireStattion.MaxValue = (object) 1E+16;
    this.txtDistToFireStattion.MGAStyle = MGAStyles.Blue;
    this.txtDistToFireStattion.MinValue = (object) -1E+16;
    ((Control) this.txtDistToFireStattion).Name = "txtDistToFireStattion";
    this.txtDistToFireStattion.Nullable = true;
    this.txtDistToFireStattion.NumericType = (NumericType) 1;
    ((Control) this.txtDistToFireStattion).Size = new Size(56, 20);
    ((Control) this.txtDistToFireStattion).TabIndex = 2;
    ((UltraControlBase) this.txtDistToFireStattion).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDistToFireStattion).UseOsThemes = (DefaultableBoolean) 2;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkVacant).Appearance = (AppearanceBase) appearance10;
    ((UltraToggleEditorBase) this.chkVacant).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkVacant).BackColorInternal = Color.Transparent;
    ((Control) this.chkVacant).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblUnderwritingLocations.Vacant", true));
    ((UltraToggleEditorBase) this.chkVacant).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkVacant).Location = new Point(400, 160 /*0xA0*/);
    this.chkVacant.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkVacant).Name = "chkVacant";
    ((Control) this.chkVacant).Size = new Size(64 /*0x40*/, 24);
    ((Control) this.chkVacant).TabIndex = 15;
    ((UltraToggleEditorBase) this.chkVacant).Text = "Vacant";
    ((UltraControlBase) this.chkVacant).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkVacant).UseOsThemes = (DefaultableBoolean) 2;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkLockedSecure).Appearance = (AppearanceBase) appearance11;
    ((UltraToggleEditorBase) this.chkLockedSecure).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkLockedSecure).BackColorInternal = Color.Transparent;
    ((Control) this.chkLockedSecure).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblUnderwritingLocations.LockedAndSecured", true));
    ((UltraToggleEditorBase) this.chkLockedSecure).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkLockedSecure).Location = new Point(264, 160 /*0xA0*/);
    this.chkLockedSecure.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkLockedSecure).Name = "chkLockedSecure";
    ((Control) this.chkLockedSecure).Size = new Size(128 /*0x80*/, 24);
    ((Control) this.chkLockedSecure).TabIndex = 14;
    ((UltraToggleEditorBase) this.chkLockedSecure).Text = "Locked & Secured";
    ((UltraControlBase) this.chkLockedSecure).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkLockedSecure).UseOsThemes = (DefaultableBoolean) 2;
    this.cboSprinklerSystem.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboSprinklerSystem).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.SprinklerTypeID", true));
    ((UltraGridBase) this.cboSprinklerSystem).DataSource = (object) this.ds.lstUnderwritingLocations_SprinklerTypes;
    ((UltraDropDownBase) this.cboSprinklerSystem).DisplayMember = "Display";
    this.cboSprinklerSystem.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboSprinklerSystem).Location = new Point(368, 136);
    this.cboSprinklerSystem.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboSprinklerSystem).Name = "cboSprinklerSystem";
    ((Control) this.cboSprinklerSystem).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.cboSprinklerSystem).TabIndex = 11;
    ((UltraControlBase) this.cboSprinklerSystem).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboSprinklerSystem).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboSprinklerSystem).ValueMember = "SprinklerTypeID";
    this.cboBurglarAlarmType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboBurglarAlarmType).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.BurglarAlarmTypeID", true));
    ((UltraGridBase) this.cboBurglarAlarmType).DataSource = (object) this.dvBurglar;
    ((UltraDropDownBase) this.cboBurglarAlarmType).DisplayMember = "AlarmType";
    this.cboBurglarAlarmType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboBurglarAlarmType).Location = new Point(368, 112 /*0x70*/);
    this.cboBurglarAlarmType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboBurglarAlarmType).Name = "cboBurglarAlarmType";
    ((Control) this.cboBurglarAlarmType).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.cboBurglarAlarmType).TabIndex = 10;
    ((UltraControlBase) this.cboBurglarAlarmType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboBurglarAlarmType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboBurglarAlarmType).ValueMember = "AlarmTypeID";
    this.dvBurglar.Table = (DataTable) this.ds.lstUnderwritingLocations_AlarmTypes;
    this.cboFireAlarmType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboFireAlarmType).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.FireAlarmTypeID", true));
    ((UltraGridBase) this.cboFireAlarmType).DataSource = (object) this.dvFire;
    ((UltraDropDownBase) this.cboFireAlarmType).DisplayMember = "AlarmType";
    this.cboFireAlarmType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboFireAlarmType).Location = new Point(368, 88);
    this.cboFireAlarmType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboFireAlarmType).Name = "cboFireAlarmType";
    ((Control) this.cboFireAlarmType).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.cboFireAlarmType).TabIndex = 9;
    ((UltraControlBase) this.cboFireAlarmType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboFireAlarmType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboFireAlarmType).ValueMember = "AlarmTypeID";
    this.dvFire.Table = (DataTable) this.ds.lstUnderwritingLocations_AlarmTypes;
    this.Label30.AutoSize = true;
    this.Label30.BackColor = Color.Transparent;
    this.Label30.Location = new Point(263, 138);
    this.Label30.Name = "Label30";
    this.Label30.Size = new Size(90, 13);
    this.Label30.TabIndex = 25;
    this.Label30.Text = "Sprinkler System:";
    this.Label29.AutoSize = true;
    this.Label29.BackColor = Color.Transparent;
    this.Label29.Location = new Point(250, 114);
    this.Label29.Name = "Label29";
    this.Label29.Size = new Size(102, 13);
    this.Label29.TabIndex = 24;
    this.Label29.Text = "Burglar Alarm Type:";
    this.Label28.AutoSize = true;
    this.Label28.BackColor = Color.Transparent;
    this.Label28.Location = new Point(268, 90);
    this.Label28.Name = "Label28";
    this.Label28.Size = new Size(86, 13);
    this.Label28.TabIndex = 23;
    this.Label28.Text = "Fire Alarm Type:";
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((TextEditorControlBase) this.TextBox6).Appearance = (AppearanceBase) appearance12;
    ((TextEditorControlBase) this.TextBox6).BackColor = Color.White;
    ((Control) this.TextBox6).CausesValidation = false;
    ((Control) this.TextBox6).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.Stories", true, DataSourceUpdateMode.OnPropertyChanged));
    ((Control) this.TextBox6).Location = new Point(152, 88);
    ((TextEditorControlBase) this.TextBox6).MaxLength = 5;
    this.TextBox6.MGAStyle = MGAStyles.Blue;
    ((Control) this.TextBox6).Name = "TextBox6";
    ((Control) this.TextBox6).Size = new Size(56, 20);
    ((Control) this.TextBox6).TabIndex = 3;
    ((Control) this.TextBox6).Tag = (object) "n";
    ((UltraControlBase) this.TextBox6).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.TextBox6).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((TextEditorControlBase) this.TextBox5).Appearance = (AppearanceBase) appearance13;
    ((TextEditorControlBase) this.TextBox5).BackColor = Color.White;
    ((Control) this.TextBox5).CausesValidation = false;
    ((Control) this.TextBox5).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.Basements", true, DataSourceUpdateMode.OnPropertyChanged));
    ((Control) this.TextBox5).Location = new Point(152, 112 /*0x70*/);
    ((TextEditorControlBase) this.TextBox5).MaxLength = 2;
    this.TextBox5.MGAStyle = MGAStyles.Blue;
    ((Control) this.TextBox5).Name = "TextBox5";
    ((Control) this.TextBox5).Size = new Size(56, 20);
    ((Control) this.TextBox5).TabIndex = 4;
    ((Control) this.TextBox5).Tag = (object) "n";
    ((UltraControlBase) this.TextBox5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.TextBox5).UseOsThemes = (DefaultableBoolean) 2;
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((TextEditorControlBase) this.TextBox3).Appearance = (AppearanceBase) appearance14;
    ((TextEditorControlBase) this.TextBox3).BackColor = Color.White;
    ((Control) this.TextBox3).CausesValidation = false;
    ((Control) this.TextBox3).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.Elevators", true, DataSourceUpdateMode.OnPropertyChanged));
    ((Control) this.TextBox3).Location = new Point(152, 136);
    ((TextEditorControlBase) this.TextBox3).MaxLength = 2;
    this.TextBox3.MGAStyle = MGAStyles.Blue;
    ((Control) this.TextBox3).Name = "TextBox3";
    ((Control) this.TextBox3).Size = new Size(56, 20);
    ((Control) this.TextBox3).TabIndex = 5;
    ((Control) this.TextBox3).Tag = (object) "n";
    ((UltraControlBase) this.TextBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.TextBox3).UseOsThemes = (DefaultableBoolean) 2;
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((TextEditorControlBase) this.TextBox2).Appearance = (AppearanceBase) appearance15;
    ((TextEditorControlBase) this.TextBox2).BackColor = Color.White;
    ((Control) this.TextBox2).CausesValidation = false;
    ((Control) this.TextBox2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.DistToFireHydrant", true, DataSourceUpdateMode.OnPropertyChanged));
    ((Control) this.TextBox2).Location = new Point(152, 40);
    ((TextEditorControlBase) this.TextBox2).MaxLength = 6;
    this.TextBox2.MGAStyle = MGAStyles.Blue;
    ((Control) this.TextBox2).Name = "TextBox2";
    ((Control) this.TextBox2).Size = new Size(56, 20);
    ((Control) this.TextBox2).TabIndex = 1;
    ((Control) this.TextBox2).Tag = (object) "n";
    ((UltraControlBase) this.TextBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.TextBox2).UseOsThemes = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((TextEditorControlBase) this.TextBox1).Appearance = (AppearanceBase) appearance16;
    ((TextEditorControlBase) this.TextBox1).BackColor = Color.White;
    ((Control) this.TextBox1).CausesValidation = false;
    ((Control) this.TextBox1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.SqFootage", true, DataSourceUpdateMode.OnPropertyChanged));
    ((Control) this.TextBox1).Location = new Point(152, 12);
    ((TextEditorControlBase) this.TextBox1).MaxLength = 7;
    this.TextBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.TextBox1).Name = "TextBox1";
    ((Control) this.TextBox1).Size = new Size(56, 20);
    ((Control) this.TextBox1).TabIndex = 0;
    ((Control) this.TextBox1).Tag = (object) "n";
    ((UltraControlBase) this.TextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.TextBox1).UseOsThemes = (DefaultableBoolean) 2;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkWindCoverage).Appearance = (AppearanceBase) appearance17;
    ((UltraToggleEditorBase) this.chkWindCoverage).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkWindCoverage).BackColorInternal = Color.Transparent;
    ((Control) this.chkWindCoverage).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblUnderwritingLocations.WindCoverage", true));
    ((UltraToggleEditorBase) this.chkWindCoverage).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkWindCoverage).Location = new Point(152, 162);
    this.chkWindCoverage.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkWindCoverage).Name = "chkWindCoverage";
    ((Control) this.chkWindCoverage).Size = new Size(120, 20);
    ((Control) this.chkWindCoverage).TabIndex = 13;
    ((UltraToggleEditorBase) this.chkWindCoverage).Text = "Wind Coverage";
    ((UltraControlBase) this.chkWindCoverage).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkWindCoverage).UseOsThemes = (DefaultableBoolean) 2;
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(81, 138);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(67, 13);
    this.Label18.TabIndex = 10;
    this.Label18.Text = "# Elevators:";
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(73, 114);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(74, 13);
    this.Label17.TabIndex = 8;
    this.Label17.Text = "# Basements:";
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(93, 90);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(55, 13);
    this.Label16.TabIndex = 6;
    this.Label16.Text = "# Stories:";
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(6, 184);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(117, 13);
    this.Label15.TabIndex = 21;
    this.Label15.Text = "Additional Information:";
    appearance18.BackColor = Color.White;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance18.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTaxTerritory).Appearance = (AppearanceBase) appearance18;
    ((TextEditorControlBase) this.txtTaxTerritory).BackColor = Color.White;
    ((Control) this.txtTaxTerritory).DataBindings.Add(new Binding("Text", (object) this.ds, "tblUnderwritingLocations.TaxTerritory", true));
    ((Control) this.txtTaxTerritory).Location = new Point(520, 12);
    ((TextEditorControlBase) this.txtTaxTerritory).MaxLength = 2;
    this.txtTaxTerritory.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtTaxTerritory).Name = "txtTaxTerritory";
    ((Control) this.txtTaxTerritory).Size = new Size(40, 20);
    ((Control) this.txtTaxTerritory).TabIndex = 12;
    ((UltraControlBase) this.txtTaxTerritory).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTaxTerritory).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(440, 14);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(74, 13);
    this.Label13.TabIndex = 19;
    this.Label13.Text = "Tax Territory:";
    appearance19.BackColor = Color.White;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance19.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEQConst).Appearance = (AppearanceBase) appearance19;
    ((TextEditorControlBase) this.txtEQConst).BackColor = Color.White;
    ((Control) this.txtEQConst).DataBindings.Add(new Binding("Text", (object) this.ds, "tblUnderwritingLocations.EQConstruction", true));
    ((Control) this.txtEQConst).Location = new Point(368, 64 /*0x40*/);
    ((TextEditorControlBase) this.txtEQConst).MaxLength = 2;
    this.txtEQConst.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEQConst).Name = "txtEQConst";
    ((Control) this.txtEQConst).Size = new Size(40, 20);
    ((Control) this.txtEQConst).TabIndex = 8;
    ((UltraControlBase) this.txtEQConst).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEQConst).UseOsThemes = (DefaultableBoolean) 2;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(224 /*0xE0*/, 66);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(130, 13);
    this.Label12.TabIndex = 17;
    this.Label12.Text = "Earthquake Construction:";
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(291, 42);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(64 /*0x40*/, 13);
    this.Label11.TabIndex = 15;
    this.Label11.Text = "Flood Zone:";
    appearance20.BackColor = Color.White;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance20.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEarthquakeZone).Appearance = (AppearanceBase) appearance20;
    ((TextEditorControlBase) this.txtEarthquakeZone).BackColor = Color.White;
    ((Control) this.txtEarthquakeZone).DataBindings.Add(new Binding("Text", (object) this.ds, "tblUnderwritingLocations.EQZone", true));
    ((Control) this.txtEarthquakeZone).Location = new Point(368, 12);
    ((TextEditorControlBase) this.txtEarthquakeZone).MaxLength = 2;
    this.txtEarthquakeZone.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEarthquakeZone).Name = "txtEarthquakeZone";
    ((Control) this.txtEarthquakeZone).Size = new Size(40, 20);
    ((Control) this.txtEarthquakeZone).TabIndex = 6;
    ((UltraControlBase) this.txtEarthquakeZone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEarthquakeZone).UseOsThemes = (DefaultableBoolean) 2;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(262, 14);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(93, 13);
    this.Label10.TabIndex = 13;
    this.Label10.Text = "Earthquake Zone:";
    appearance21.BackColor = Color.White;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance21.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAdditionalInfo).Appearance = (AppearanceBase) appearance21;
    ((TextEditorControlBase) this.txtAdditionalInfo).BackColor = Color.White;
    ((Control) this.txtAdditionalInfo).DataBindings.Add(new Binding("Text", (object) this.ds, "tblUnderwritingLocations.AddnInformation", true));
    ((Control) this.txtAdditionalInfo).Location = new Point(9, 210);
    ((TextEditorControlBase) this.txtAdditionalInfo).MaxLength = 1000;
    this.txtAdditionalInfo.MGAStyle = MGAStyles.Blue;
    this.txtAdditionalInfo.Multiline = true;
    ((Control) this.txtAdditionalInfo).Name = "txtAdditionalInfo";
    ((Control) this.txtAdditionalInfo).Size = new Size(424, 43);
    ((Control) this.txtAdditionalInfo).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.txtAdditionalInfo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAdditionalInfo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(4, 66);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(138, 13);
    this.Label9.TabIndex = 4;
    this.Label9.Text = "Dist. to Fire Station (miles):";
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(6, 42);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(140, 13);
    this.Label8.TabIndex = 2;
    this.Label8.Text = "Dist. to Fire Hydrant (feet):";
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(60, 14);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(88, 13);
    this.Label7.TabIndex = 0;
    this.Label7.Text = "Square Footage:";
    this.lnkDeSelectAllDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkDeSelectAllDelete.AutoSize = true;
    this.lnkDeSelectAllDelete.BackColor = Color.Transparent;
    this.lnkDeSelectAllDelete.Location = new Point(123, 283);
    this.lnkDeSelectAllDelete.Name = "lnkDeSelectAllDelete";
    this.lnkDeSelectAllDelete.Size = new Size(117, 13);
    this.lnkDeSelectAllDelete.TabIndex = 21;
    this.lnkDeSelectAllDelete.TabStop = true;
    this.lnkDeSelectAllDelete.Text = "De-Select all for Delete";
    this.lnkDeSelectAllDelete.TextAlign = ContentAlignment.MiddleCenter;
    this.lnkDeleteSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkDeleteSelectAll.AutoSize = true;
    this.lnkDeleteSelectAll.BackColor = Color.Transparent;
    this.lnkDeleteSelectAll.Location = new Point(3, 283);
    this.lnkDeleteSelectAll.Name = "lnkDeleteSelectAll";
    this.lnkDeleteSelectAll.Size = new Size(100, 13);
    this.lnkDeleteSelectAll.TabIndex = 20;
    this.lnkDeleteSelectAll.TabStop = true;
    this.lnkDeleteSelectAll.Text = "Select all for Delete";
    this.lnkDeleteSelectAll.TextAlign = ContentAlignment.MiddleCenter;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(559, 256 /*0x0100*/);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 18;
    this.lnkAddInsured.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkAddInsured.AutoSize = true;
    this.lnkAddInsured.BackColor = Color.Transparent;
    this.lnkAddInsured.Location = new Point(290, 283);
    this.lnkAddInsured.Name = "lnkAddInsured";
    this.lnkAddInsured.Size = new Size(109, 13);
    this.lnkAddInsured.TabIndex = 13;
    this.lnkAddInsured.TabStop = true;
    this.lnkAddInsured.Text = "Add Insured Location";
    this.lnkAddInsured.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.tabYears).Controls.Add((Control) this.TextBox11);
    ((Control) this.tabYears).Controls.Add((Control) this.TextBox10);
    ((Control) this.tabYears).Controls.Add((Control) this.TextBox9);
    ((Control) this.tabYears).Controls.Add((Control) this.TextBox8);
    ((Control) this.tabYears).Controls.Add((Control) this.TextBox7);
    ((Control) this.tabYears).Controls.Add((Control) this.Label22);
    ((Control) this.tabYears).Controls.Add((Control) this.Label19);
    ((Control) this.tabYears).Controls.Add((Control) this.Label20);
    ((Control) this.tabYears).Controls.Add((Control) this.Label23);
    ((Control) this.tabYears).Controls.Add((Control) this.Label21);
    ((Control) this.tabYears).Location = new Point(-10000, -10000);
    ((Control) this.tabYears).Name = "tabYears";
    ((Control) this.tabYears).Size = new Size(674, 301);
    appearance22.BackColor = Color.White;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance22.ForeColor = Color.Black;
    ((TextEditorControlBase) this.TextBox11).Appearance = (AppearanceBase) appearance22;
    ((TextEditorControlBase) this.TextBox11).BackColor = Color.White;
    ((Control) this.TextBox11).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.YearBuilt", true));
    ((Control) this.TextBox11).Location = new Point(64 /*0x40*/, 16 /*0x10*/);
    ((TextEditorControlBase) this.TextBox11).MaxLength = 4;
    this.TextBox11.MGAStyle = MGAStyles.Blue;
    ((Control) this.TextBox11).Name = "TextBox11";
    ((Control) this.TextBox11).Size = new Size(56, 20);
    ((Control) this.TextBox11).TabIndex = 1;
    ((Control) this.TextBox11).Tag = (object) "y";
    ((UltraControlBase) this.TextBox11).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.TextBox11).UseOsThemes = (DefaultableBoolean) 2;
    appearance23.BackColor = Color.White;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance23.ForeColor = Color.Black;
    ((TextEditorControlBase) this.TextBox10).Appearance = (AppearanceBase) appearance23;
    ((TextEditorControlBase) this.TextBox10).BackColor = Color.White;
    ((Control) this.TextBox10).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.WiringYear", true));
    ((Control) this.TextBox10).Location = new Point(64 /*0x40*/, 40);
    ((TextEditorControlBase) this.TextBox10).MaxLength = 4;
    this.TextBox10.MGAStyle = MGAStyles.Blue;
    ((Control) this.TextBox10).Name = "TextBox10";
    ((Control) this.TextBox10).Size = new Size(56, 20);
    ((Control) this.TextBox10).TabIndex = 3;
    ((Control) this.TextBox10).Tag = (object) "y";
    ((UltraControlBase) this.TextBox10).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.TextBox10).UseOsThemes = (DefaultableBoolean) 2;
    appearance24.BackColor = Color.White;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance24.ForeColor = Color.Black;
    ((TextEditorControlBase) this.TextBox9).Appearance = (AppearanceBase) appearance24;
    ((TextEditorControlBase) this.TextBox9).BackColor = Color.White;
    ((Control) this.TextBox9).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.RoofingYear", true));
    ((Control) this.TextBox9).Location = new Point(216, 16 /*0x10*/);
    ((TextEditorControlBase) this.TextBox9).MaxLength = 4;
    this.TextBox9.MGAStyle = MGAStyles.Blue;
    ((Control) this.TextBox9).Name = "TextBox9";
    ((Control) this.TextBox9).Size = new Size(56, 20);
    ((Control) this.TextBox9).TabIndex = 5;
    ((Control) this.TextBox9).Tag = (object) "y";
    ((UltraControlBase) this.TextBox9).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.TextBox9).UseOsThemes = (DefaultableBoolean) 2;
    appearance25.BackColor = Color.White;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance25.ForeColor = Color.Black;
    ((TextEditorControlBase) this.TextBox8).Appearance = (AppearanceBase) appearance25;
    ((TextEditorControlBase) this.TextBox8).BackColor = Color.White;
    ((Control) this.TextBox8).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.PlumbingYear", true));
    ((Control) this.TextBox8).Location = new Point(216, 40);
    ((TextEditorControlBase) this.TextBox8).MaxLength = 4;
    this.TextBox8.MGAStyle = MGAStyles.Blue;
    ((Control) this.TextBox8).Name = "TextBox8";
    ((Control) this.TextBox8).Size = new Size(56, 20);
    ((Control) this.TextBox8).TabIndex = 7;
    ((Control) this.TextBox8).Tag = (object) "y";
    ((UltraControlBase) this.TextBox8).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.TextBox8).UseOsThemes = (DefaultableBoolean) 2;
    appearance26.BackColor = Color.White;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance26.ForeColor = Color.Black;
    ((TextEditorControlBase) this.TextBox7).Appearance = (AppearanceBase) appearance26;
    ((TextEditorControlBase) this.TextBox7).BackColor = Color.White;
    ((Control) this.TextBox7).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.HeatingYear", true));
    ((Control) this.TextBox7).Location = new Point(368, 16 /*0x10*/);
    ((TextEditorControlBase) this.TextBox7).MaxLength = 4;
    this.TextBox7.MGAStyle = MGAStyles.Blue;
    ((Control) this.TextBox7).Name = "TextBox7";
    ((Control) this.TextBox7).Size = new Size(56, 20);
    ((Control) this.TextBox7).TabIndex = 9;
    ((Control) this.TextBox7).Tag = (object) "y";
    ((UltraControlBase) this.TextBox7).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.TextBox7).UseOsThemes = (DefaultableBoolean) 2;
    this.Label22.AutoSize = true;
    this.Label22.BackColor = Color.Transparent;
    this.Label22.Location = new Point(157, 44);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(53, 13);
    this.Label22.TabIndex = 6;
    this.Label22.Text = "Plumbing:";
    this.Label22.TextAlign = ContentAlignment.MiddleRight;
    this.Label19.AutoSize = true;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Location = new Point(17, 20);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(31 /*0x1F*/, 13);
    this.Label19.TabIndex = 0;
    this.Label19.Text = "Built:";
    this.Label19.TextAlign = ContentAlignment.MiddleRight;
    this.Label20.AutoSize = true;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Location = new Point(17, 44);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(41, 13);
    this.Label20.TabIndex = 2;
    this.Label20.Text = "Wiring:";
    this.Label20.TextAlign = ContentAlignment.MiddleRight;
    this.Label23.AutoSize = true;
    this.Label23.BackColor = Color.Transparent;
    this.Label23.Location = new Point(312, 20);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(48 /*0x30*/, 13);
    this.Label23.TabIndex = 8;
    this.Label23.Text = "Heating:";
    this.Label23.TextAlign = ContentAlignment.MiddleRight;
    this.Label21.AutoSize = true;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Location = new Point(157, 20);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(48 /*0x30*/, 13);
    this.Label21.TabIndex = 4;
    this.Label21.Text = "Roofing:";
    this.Label21.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.lblContactEmail);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.txtContactEmail);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.lnkCopyInspectionInfo);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.lnkAddContacts);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.lnkRoofInspectionsInfo);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.lblRoofInspectionCompany);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.cboRoofInspectionCompany);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.chkLocationLookup);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.lnkDefaultWarranties);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.Label33);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.dtDueDate);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.MgaCheckBox2);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.MgaCheckBox1);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.txtComments);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.Label27);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.txtContactPhone);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.Label26);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.txtInspectionContact);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.Label25);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.Label24);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.cboInspectionCompanies);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.CheckBox4);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.CheckBox3);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.CheckBox2);
    ((Control) this.tabInspectionInfo).Controls.Add((Control) this.chkInspectionRequired);
    ((Control) this.tabInspectionInfo).Location = new Point(-10000, -10000);
    ((Control) this.tabInspectionInfo).Name = "tabInspectionInfo";
    ((Control) this.tabInspectionInfo).Size = new Size(674, 301);
    this.lblContactEmail.AutoSize = true;
    this.lblContactEmail.BackColor = Color.Transparent;
    this.lblContactEmail.Location = new Point(205, 87);
    this.lblContactEmail.Name = "lblContactEmail";
    this.lblContactEmail.Size = new Size(76, 13);
    this.lblContactEmail.TabIndex = 27;
    this.lblContactEmail.Text = "Contact Email:";
    this.lblContactEmail.TextAlign = ContentAlignment.MiddleRight;
    appearance27.BackColor = Color.White;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtContactEmail).Appearance = (AppearanceBase) appearance27;
    ((TextEditorControlBase) this.txtContactEmail).BackColor = Color.White;
    ((Control) this.txtContactEmail).DataBindings.Add(new Binding("Text", (object) this.ds, "tblUnderwritingLocations.ContactEmail", true));
    ((Control) this.txtContactEmail).Location = new Point(291, 83);
    ((TextEditorControlBase) this.txtContactEmail).MaxLength = 60;
    this.txtContactEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtContactEmail).Name = "txtContactEmail";
    ((Control) this.txtContactEmail).Size = new Size(225, 20);
    ((Control) this.txtContactEmail).TabIndex = 11;
    ((UltraControlBase) this.txtContactEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtContactEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkCopyInspectionInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkCopyInspectionInfo.AutoSize = true;
    this.lnkCopyInspectionInfo.BackColor = Color.Transparent;
    this.lnkCopyInspectionInfo.Location = new Point(290, 247);
    this.lnkCopyInspectionInfo.Name = "lnkCopyInspectionInfo";
    this.lnkCopyInspectionInfo.Size = new Size(169, 13);
    this.lnkCopyInspectionInfo.TabIndex = 24;
    this.lnkCopyInspectionInfo.TabStop = true;
    this.lnkCopyInspectionInfo.Text = "Copy Inspection Info to Locations";
    this.lnkCopyInspectionInfo.TextAlign = ContentAlignment.MiddleCenter;
    this.lnkAddContacts.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkAddContacts.AutoSize = true;
    this.lnkAddContacts.BackColor = Color.Transparent;
    this.lnkAddContacts.Location = new Point(532, 34);
    this.lnkAddContacts.Name = "lnkAddContacts";
    this.lnkAddContacts.Size = new Size((int) sbyte.MaxValue, 13);
    this.lnkAddContacts.TabIndex = 23;
    this.lnkAddContacts.TabStop = true;
    this.lnkAddContacts.Text = "Add Insured Contacts ...";
    this.lnkAddContacts.TextAlign = ContentAlignment.MiddleCenter;
    this.lnkRoofInspectionsInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkRoofInspectionsInfo.AutoSize = true;
    this.lnkRoofInspectionsInfo.BackColor = Color.Transparent;
    this.lnkRoofInspectionsInfo.Location = new Point(533, 113);
    this.lnkRoofInspectionsInfo.Name = "lnkRoofInspectionsInfo";
    this.lnkRoofInspectionsInfo.Size = new Size(126, 13);
    this.lnkRoofInspectionsInfo.TabIndex = 22;
    this.lnkRoofInspectionsInfo.TabStop = true;
    this.lnkRoofInspectionsInfo.Text = "Roof Inspections Info ...";
    this.lnkRoofInspectionsInfo.TextAlign = ContentAlignment.MiddleCenter;
    this.lblRoofInspectionCompany.AutoSize = true;
    this.lblRoofInspectionCompany.BackColor = Color.Transparent;
    this.lblRoofInspectionCompany.Location = new Point(147, 113);
    this.lblRoofInspectionCompany.Name = "lblRoofInspectionCompany";
    this.lblRoofInspectionCompany.Size = new Size(135, 13);
    this.lblRoofInspectionCompany.TabIndex = 21;
    this.lblRoofInspectionCompany.Text = "Roof Inspection Company:";
    this.lblRoofInspectionCompany.TextAlign = ContentAlignment.MiddleRight;
    this.cboRoofInspectionCompany.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboRoofInspectionCompany).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.RoofInspectionCompanyID", true));
    ((UltraGridBase) this.cboRoofInspectionCompany).DataMember = "dtRoofInspectionCompanies";
    ((UltraGridBase) this.cboRoofInspectionCompany).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboRoofInspectionCompany).DisplayMember = "PayeeName";
    this.cboRoofInspectionCompany.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboRoofInspectionCompany).Location = new Point(292, 109);
    this.cboRoofInspectionCompany.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboRoofInspectionCompany).Name = "cboRoofInspectionCompany";
    ((Control) this.cboRoofInspectionCompany).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.cboRoofInspectionCompany).TabIndex = 12;
    ((UltraControlBase) this.cboRoofInspectionCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboRoofInspectionCompany).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboRoofInspectionCompany).ValueMember = "PayeeID";
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance28.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkLocationLookup).Appearance = (AppearanceBase) appearance28;
    ((UltraToggleEditorBase) this.chkLocationLookup).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkLocationLookup).BackColorInternal = Color.Transparent;
    ((Control) this.chkLocationLookup).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblUnderwritingLocations.LocationLookup", true));
    ((UltraToggleEditorBase) this.chkLocationLookup).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkLocationLookup).Location = new Point(16 /*0x10*/, 164);
    this.chkLocationLookup.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkLocationLookup).Name = "chkLocationLookup";
    ((Control) this.chkLocationLookup).Size = new Size(120, 20);
    ((Control) this.chkLocationLookup).TabIndex = 6;
    ((UltraToggleEditorBase) this.chkLocationLookup).Text = "Location Look-up";
    ((UltraControlBase) this.chkLocationLookup).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkLocationLookup).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkDefaultWarranties.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkDefaultWarranties.AutoSize = true;
    this.lnkDefaultWarranties.BackColor = Color.Transparent;
    this.lnkDefaultWarranties.Location = new Point(290, 222);
    this.lnkDefaultWarranties.Name = "lnkDefaultWarranties";
    this.lnkDefaultWarranties.Size = new Size(154, 13);
    this.lnkDefaultWarranties.TabIndex = 12;
    this.lnkDefaultWarranties.TabStop = true;
    this.lnkDefaultWarranties.Text = "Copy Warranties to Comments";
    this.lnkDefaultWarranties.TextAlign = ContentAlignment.MiddleCenter;
    this.Label33.AutoSize = true;
    this.Label33.BackColor = Color.Transparent;
    this.Label33.Location = new Point(13, 199);
    this.Label33.Name = "Label33";
    this.Label33.Size = new Size(56, 13);
    this.Label33.TabIndex = 20;
    this.Label33.Text = "Due Date:";
    this.Label33.TextAlign = ContentAlignment.MiddleRight;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtDueDate.Appearance = (AppearanceBase) appearance29;
    appearance30.AlphaLevel = (short) 14;
    appearance30.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance30.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance30.BackColorAlpha = (Alpha) 2;
    appearance30.BackGradientAlignment = (GradientAlignment) 4;
    appearance30.BackGradientStyle = (GradientStyle) 5;
    appearance30.BorderAlpha = (Alpha) 1;
    appearance30.BorderColor = Color.FromArgb(78, 122, 171);
    appearance30.ForeColor = Color.FromArgb(49, 85, 153);
    appearance30.ForegroundAlpha = (Alpha) 2;
    this.dtDueDate.ButtonAppearance = (AppearanceBase) appearance30;
    ((Control) this.dtDueDate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.DueDate", true));
    this.dtDueDate.DateTime = new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((Control) this.dtDueDate).Location = new Point(75, 195);
    this.dtDueDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtDueDate).Name = "dtDueDate";
    ((Control) this.dtDueDate).Size = new Size(100, 20);
    ((Control) this.dtDueDate).TabIndex = 7;
    ((UltraControlBase) this.dtDueDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtDueDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtDueDate.Value = (object) new DateTime(2010, 7, 7, 0, 0, 0, 0);
    appearance31.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance31.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox2).Appearance = (AppearanceBase) appearance31;
    ((UltraToggleEditorBase) this.MgaCheckBox2).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox2).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox2).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblUnderwritingLocations.Rush", true));
    ((UltraToggleEditorBase) this.MgaCheckBox2).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox2).Location = new Point(16 /*0x10*/, 140);
    this.MgaCheckBox2.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaCheckBox2).Name = "MgaCheckBox2";
    ((Control) this.MgaCheckBox2).Size = new Size(120, 20);
    ((Control) this.MgaCheckBox2).TabIndex = 5;
    ((UltraToggleEditorBase) this.MgaCheckBox2).Text = "Rush";
    ((UltraControlBase) this.MgaCheckBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox2).UseOsThemes = (DefaultableBoolean) 2;
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance32.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Appearance = (AppearanceBase) appearance32;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox1).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblUnderwritingLocations.RecCheck", true));
    ((UltraToggleEditorBase) this.MgaCheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox1).Location = new Point(16 /*0x10*/, 109);
    this.MgaCheckBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaCheckBox1).Name = "MgaCheckBox1";
    ((Control) this.MgaCheckBox1).Size = new Size(120, 20);
    ((Control) this.MgaCheckBox1).TabIndex = 4;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Text = "Rec Check";
    ((UltraControlBase) this.MgaCheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    appearance33.BackColor = Color.White;
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance33.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtComments).Appearance = (AppearanceBase) appearance33;
    ((TextEditorControlBase) this.txtComments).BackColor = Color.White;
    ((Control) this.txtComments).DataBindings.Add(new Binding("Text", (object) this.ds, "tblUnderwritingLocations.Comments", true));
    ((Control) this.txtComments).Location = new Point(292, 136);
    ((TextEditorControlBase) this.txtComments).MaxLength = 3000;
    this.txtComments.MGAStyle = MGAStyles.Blue;
    this.txtComments.Multiline = true;
    ((Control) this.txtComments).Name = "txtComments";
    ((Control) this.txtComments).Size = new Size(250, 68);
    ((Control) this.txtComments).TabIndex = 13;
    ((UltraControlBase) this.txtComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtComments).UseOsThemes = (DefaultableBoolean) 2;
    this.Label27.AutoSize = true;
    this.Label27.BackColor = Color.Transparent;
    this.Label27.Location = new Point(220, 140);
    this.Label27.Name = "Label27";
    this.Label27.Size = new Size(61, 13);
    this.Label27.TabIndex = 10;
    this.Label27.Text = "Comments:";
    this.Label27.TextAlign = ContentAlignment.MiddleRight;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtContactPhone.Appearance = (AppearanceBase) appearance34;
    ((Control) this.txtContactPhone).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.InspectionContactPhone", true));
    this.txtContactPhone.EditAs = (EditAsType) 1;
    this.txtContactPhone.InputMask = "###-###-####";
    ((Control) this.txtContactPhone).Location = new Point(292, 56);
    this.txtContactPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtContactPhone).Name = "txtContactPhone";
    this.txtContactPhone.NonAutoSizeHeight = 20;
    ((Control) this.txtContactPhone).Size = new Size(77, 21);
    ((Control) this.txtContactPhone).TabIndex = 10;
    this.txtContactPhone.Text = "--";
    ((UltraControlBase) this.txtContactPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtContactPhone).UseOsThemes = (DefaultableBoolean) 2;
    this.Label26.AutoSize = true;
    this.Label26.BackColor = Color.Transparent;
    this.Label26.Location = new Point(199, 60);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(82, 13);
    this.Label26.TabIndex = 8;
    this.Label26.Text = "Contact Phone:";
    this.Label26.TextAlign = ContentAlignment.MiddleRight;
    appearance35.BackColor = Color.White;
    appearance35.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance35.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInspectionContact).Appearance = (AppearanceBase) appearance35;
    ((TextEditorControlBase) this.txtInspectionContact).BackColor = Color.White;
    ((Control) this.txtInspectionContact).DataBindings.Add(new Binding("Text", (object) this.ds, "tblUnderwritingLocations.InspectionContact", true));
    ((Control) this.txtInspectionContact).Location = new Point(291, 30);
    this.txtInspectionContact.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtInspectionContact).Name = "txtInspectionContact";
    ((Control) this.txtInspectionContact).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.txtInspectionContact).TabIndex = 9;
    ((UltraControlBase) this.txtInspectionContact).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInspectionContact).UseOsThemes = (DefaultableBoolean) 2;
    this.Label25.AutoSize = true;
    this.Label25.BackColor = Color.Transparent;
    this.Label25.Location = new Point(179, 34);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(102, 13);
    this.Label25.TabIndex = 6;
    this.Label25.Text = "Inspection Contact:";
    this.Label25.TextAlign = ContentAlignment.MiddleRight;
    this.Label24.AutoSize = true;
    this.Label24.BackColor = Color.Transparent;
    this.Label24.Location = new Point(172, 7);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(109, 13);
    this.Label24.TabIndex = 4;
    this.Label24.Text = "Inspection Company:";
    this.Label24.TextAlign = ContentAlignment.MiddleRight;
    this.cboInspectionCompanies.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboInspectionCompanies).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUnderwritingLocations.InspectionCompanyID", true));
    ((UltraGridBase) this.cboInspectionCompanies).DataSource = (object) this.ds.tblFin_ExpensePayees;
    ((UltraDropDownBase) this.cboInspectionCompanies).DisplayMember = "PayeeName";
    this.cboInspectionCompanies.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboInspectionCompanies).Location = new Point(292, 3);
    this.cboInspectionCompanies.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboInspectionCompanies).Name = "cboInspectionCompanies";
    ((Control) this.cboInspectionCompanies).Size = new Size(224 /*0xE0*/, 21);
    ((Control) this.cboInspectionCompanies).TabIndex = 8;
    ((UltraControlBase) this.cboInspectionCompanies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInspectionCompanies).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInspectionCompanies).ValueMember = "PayeeID";
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance36.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.CheckBox4).Appearance = (AppearanceBase) appearance36;
    ((UltraToggleEditorBase) this.CheckBox4).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.CheckBox4).BackColorInternal = Color.Transparent;
    ((Control) this.CheckBox4).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblUnderwritingLocations.CostEstimator", true));
    ((UltraToggleEditorBase) this.CheckBox4).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.CheckBox4).Location = new Point(16 /*0x10*/, 83);
    this.CheckBox4.MGAStyle = MGAStyles.Blue;
    ((Control) this.CheckBox4).Name = "CheckBox4";
    ((Control) this.CheckBox4).Size = new Size(110, 20);
    ((Control) this.CheckBox4).TabIndex = 3;
    ((UltraToggleEditorBase) this.CheckBox4).Text = "Cost Estimator";
    ((UltraControlBase) this.CheckBox4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.CheckBox4).UseOsThemes = (DefaultableBoolean) 2;
    appearance37.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance37.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.CheckBox3).Appearance = (AppearanceBase) appearance37;
    ((UltraToggleEditorBase) this.CheckBox3).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.CheckBox3).BackColorInternal = Color.Transparent;
    ((Control) this.CheckBox3).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblUnderwritingLocations.Diagram", true));
    ((UltraToggleEditorBase) this.CheckBox3).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.CheckBox3).Location = new Point(16 /*0x10*/, 56);
    this.CheckBox3.MGAStyle = MGAStyles.Blue;
    ((Control) this.CheckBox3).Name = "CheckBox3";
    ((Control) this.CheckBox3).Size = new Size(99, 20);
    ((Control) this.CheckBox3).TabIndex = 2;
    ((UltraToggleEditorBase) this.CheckBox3).Text = "Diagram";
    ((UltraControlBase) this.CheckBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.CheckBox3).UseOsThemes = (DefaultableBoolean) 2;
    appearance38.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance38.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.CheckBox2).Appearance = (AppearanceBase) appearance38;
    ((UltraToggleEditorBase) this.CheckBox2).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.CheckBox2).BackColorInternal = Color.Transparent;
    ((Control) this.CheckBox2).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblUnderwritingLocations.Photo", true));
    ((UltraToggleEditorBase) this.CheckBox2).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.CheckBox2).Location = new Point(16 /*0x10*/, 30);
    this.CheckBox2.MGAStyle = MGAStyles.Blue;
    ((Control) this.CheckBox2).Name = "CheckBox2";
    ((Control) this.CheckBox2).Size = new Size(99, 20);
    ((Control) this.CheckBox2).TabIndex = 1;
    ((UltraToggleEditorBase) this.CheckBox2).Text = "Photo";
    ((UltraControlBase) this.CheckBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.CheckBox2).UseOsThemes = (DefaultableBoolean) 2;
    appearance39.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance39.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkInspectionRequired).Appearance = (AppearanceBase) appearance39;
    ((UltraToggleEditorBase) this.chkInspectionRequired).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInspectionRequired).BackColorInternal = Color.Transparent;
    ((Control) this.chkInspectionRequired).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblUnderwritingLocations.Inspect", true));
    ((UltraToggleEditorBase) this.chkInspectionRequired).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkInspectionRequired).Location = new Point(16 /*0x10*/, 1);
    this.chkInspectionRequired.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkInspectionRequired).Name = "chkInspectionRequired";
    ((Control) this.chkInspectionRequired).Size = new Size(128 /*0x80*/, 24);
    ((Control) this.chkInspectionRequired).TabIndex = 0;
    ((UltraToggleEditorBase) this.chkInspectionRequired).Text = "Inspection Required";
    ((UltraControlBase) this.chkInspectionRequired).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkInspectionRequired).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.dgLocations).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.dgLocations, "contextMenu");
    ((UltraControlBase) this.dgLocations).Cursor = Cursors.Hand;
    ((UltraGridBase) this.dgLocations).DataSource = (object) this.ds.tblUnderwritingLocations;
    appearance40.BackColor = Color.White;
    appearance40.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgLocations).DisplayLayout.Appearance = (AppearanceBase) appearance40;
    ((UltraGridBase) this.dgLocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 8;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 8;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 8;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance41).TextHAlignAsString = "Center";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance41;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Loc #";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 32 /*0x20*/;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance42).TextHAlignAsString = "Center";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance42;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Bldg #";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 92;
    ultraGridColumn6.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Phys #";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 87;
    ultraGridColumn7.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Address";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 143;
    ultraGridColumn8.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 8;
    ultraGridColumn9.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Width = 102;
    ultraGridColumn10.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Width = 45;
    ultraGridColumn11.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Width = 59;
    ultraGridColumn12.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Width = 57;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 13;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 8;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 14;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 34;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 15;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 18;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 20;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 17;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 13;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 18;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 9;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 19;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 12;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 20;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 12;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 21;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 12;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 22;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 17;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 23;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 12;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 24;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 12;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 25;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 17;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 26;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 17;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 27;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 17;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 28;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 17;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 29;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 30;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 30;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 17;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 13;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 32 /*0x20*/;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 13;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 33;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn33.Width = 12;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 34;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn34.Width = 8;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 35;
    ultraGridColumn35.Hidden = true;
    ultraGridColumn35.Width = 9;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 36;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn36.Width = 8;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 37;
    ultraGridColumn37.Hidden = true;
    ultraGridColumn37.Width = 8;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 38;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 9;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 39;
    ultraGridColumn39.Hidden = true;
    ultraGridColumn39.Width = 10;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 40;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 11;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 41;
    ultraGridColumn41.Hidden = true;
    ultraGridColumn41.Width = 10;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 42;
    ultraGridColumn42.Hidden = true;
    ultraGridColumn42.Width = 13;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 43;
    ultraGridColumn43.Hidden = true;
    ultraGridColumn43.Width = 16 /*0x10*/;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 44;
    ultraGridColumn44.Hidden = true;
    ultraGridColumn44.Width = 13;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 45;
    ultraGridColumn45.Hidden = true;
    ultraGridColumn45.Width = 17;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 46;
    ultraGridColumn46.Hidden = true;
    ultraGridColumn46.Width = 12;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 47;
    ultraGridColumn47.Hidden = true;
    ultraGridColumn47.Width = 13;
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 48 /*0x30*/;
    ultraGridColumn48.Hidden = true;
    ultraGridColumn48.Width = 15;
    ultraGridColumn49.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 49;
    ultraGridColumn49.Hidden = true;
    ultraGridColumn49.Width = 12;
    ultraGridColumn50.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 50;
    ultraGridColumn50.Hidden = true;
    ultraGridColumn50.Width = 17;
    ultraGridColumn51.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 51;
    ultraGridColumn51.Hidden = true;
    ultraGridColumn51.Width = 17;
    ultraGridColumn52.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 52;
    ultraGridColumn52.Hidden = true;
    ultraGridColumn53.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 53;
    ultraGridColumn53.Hidden = true;
    ultraGridColumn53.Width = 47;
    ultraGridColumn54.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.Header.VisiblePosition = 54;
    ultraGridColumn54.Hidden = true;
    ultraGridColumn54.Width = 43;
    ultraGridColumn55.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.Header.VisiblePosition = 55;
    ultraGridColumn55.Hidden = true;
    ultraGridColumn55.Width = 43;
    ultraGridColumn56.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn56.Header.VisiblePosition = 56;
    ultraGridColumn56.Hidden = true;
    ultraGridColumn56.Width = 43;
    ultraGridColumn57.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn57.Header.VisiblePosition = 57;
    ultraGridColumn57.Hidden = true;
    ultraGridColumn57.Width = 43;
    ultraGridColumn58.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn58.Header.VisiblePosition = 58;
    ultraGridColumn58.Hidden = true;
    ultraGridColumn58.Width = 43;
    ultraGridColumn59.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn59.Header.VisiblePosition = 59;
    ultraGridColumn59.Hidden = true;
    ultraGridColumn59.Width = 43;
    ultraGridColumn60.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn60.Header.VisiblePosition = 60;
    ultraGridColumn60.Hidden = true;
    ultraGridColumn60.Width = 43;
    ultraGridColumn61.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn61.Header.VisiblePosition = 61;
    ultraGridColumn61.Hidden = true;
    ultraGridColumn61.Width = 51;
    ultraGridColumn62.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn62.Header.VisiblePosition = 62;
    ultraGridColumn62.Hidden = true;
    ultraGridColumn62.Width = 32 /*0x20*/;
    ultraGridColumn63.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn63.Header.VisiblePosition = 63 /*0x3F*/;
    ultraGridColumn63.Hidden = true;
    ultraGridColumn63.Width = 79;
    ultraGridColumn64.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn64.Header.VisiblePosition = 64 /*0x40*/;
    ultraGridColumn64.Hidden = true;
    ultraGridColumn64.Width = 69;
    ultraGridColumn65.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn65.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn65.Header.VisiblePosition = 65;
    ultraGridColumn65.Hidden = true;
    ultraGridColumn65.Width = 85;
    ultraGridColumn66.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn66.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn66.Header.VisiblePosition = 66;
    ultraGridColumn66.Hidden = true;
    ultraGridColumn66.Width = 76;
    ultraGridColumn67.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn67.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn67.Header.VisiblePosition = 67;
    ultraGridColumn67.Hidden = true;
    ultraGridColumn67.Width = 63 /*0x3F*/;
    ((HeaderBase) ultraGridColumn68.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn68.Header.VisiblePosition = 68;
    ultraGridColumn68.Hidden = true;
    ultraGridColumn68.Width = 83;
    ((HeaderBase) ultraGridColumn69.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn69.Header.VisiblePosition = 69;
    ultraGridColumn69.Hidden = true;
    ultraGridColumn69.Width = 88;
    ((HeaderBase) ultraGridColumn70.Header).Caption = "Delete";
    ((HeaderBase) ultraGridColumn70.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn70.Header.VisiblePosition = 12;
    ultraGridColumn70.Width = 57;
    ((HeaderBase) ultraGridColumn71.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn71.Header.VisiblePosition = 70;
    ultraGridColumn71.Hidden = true;
    ultraGridColumn71.Width = 123;
    ((HeaderBase) ultraGridColumn72.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn72.Header.VisiblePosition = 71;
    ultraGridColumn72.Hidden = true;
    ultraGridColumn72.Width = 87;
    ultraGridBand.Columns.AddRange(new object[72]
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
      (object) ultraGridColumn66,
      (object) ultraGridColumn67,
      (object) ultraGridColumn68,
      (object) ultraGridColumn69,
      (object) ultraGridColumn70,
      (object) ultraGridColumn71,
      (object) ultraGridColumn72
    });
    ((UltraGridBase) this.dgLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgLocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance43.BackColor = Color.LightSteelBlue;
    appearance43.FontData.SizeInPoints = 10f;
    appearance43.ForeColor = Color.Black;
    ((UltraGridBase) this.dgLocations).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance43;
    appearance44.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance44.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance44.ForeColor = Color.Black;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance44;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance45.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance45;
    appearance46.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance46;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance47.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance47;
    appearance48.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance48;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance49.BackColor = Color.Transparent;
    appearance49.ForeColor = Color.Black;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance49;
    appearance50.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance50;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgLocations).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgLocations).Location = new Point(8, 8);
    ((Control) this.dgLocations).Name = "dgLocations";
    ((Control) this.dgLocations).Size = new Size(676, 217);
    ((Control) this.dgLocations).TabIndex = 0;
    ((UltraControlBase) this.dgLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgLocations).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.tabLocationInfo);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.tabAdditionalInfo);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.tabInspectionInfo);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.tabYears);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.tabGeoAddress);
    ((Control) this.UltraTabControl1).Location = new Point(8, 231);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControls.AddRange(new Control[4]
    {
      (Control) this.lnkDeSelectAllDelete,
      (Control) this.lnkDeleteSelectAll,
      (Control) this.dbSave,
      (Control) this.lnkAddInsured
    });
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(676, 328);
    ((Control) this.UltraTabControl1).TabIndex = 0;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.UltraTabControl1).TabPadding = new Size(15, 3);
    appearance51.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance40.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance51;
    ultraTab1.Key = "tabLocationInfo";
    ultraTab1.TabPage = this.tabLocationInfo;
    ultraTab1.Text = "Location Info.";
    appearance52.Image = (object) MGASystems.IMS.Policies.Rating.My.Resources.Resources.page_edit;
    ultraTab2.Appearance = (AppearanceBase) appearance52;
    ultraTab2.Key = "tabGeoAddress";
    ultraTab2.TabPage = this.tabGeoAddress;
    ultraTab2.Text = "GEO Address";
    appearance53.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance42.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance53;
    ultraTab3.Key = "tabAdditionalInfo";
    ultraTab3.TabPage = this.tabAdditionalInfo;
    ultraTab3.Text = "Additional Info.";
    appearance54.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance43.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance54;
    ultraTab4.Key = "tabYears";
    ultraTab4.TabPage = this.tabYears;
    ultraTab4.Text = "Construct. Years";
    appearance55.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance44.Image"));
    ultraTab5.Appearance = (AppearanceBase) appearance55;
    ultraTab5.Key = "tabInspectionInfo";
    ultraTab5.TabPage = this.tabInspectionInfo;
    ultraTab5.Text = "Inspection Info.";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[5]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(150, 0);
    ((UltraControlBase) this.UltraTabControl1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraTabControl1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lnkDeSelectAllDelete);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lnkDeleteSelectAll);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lnkAddInsured);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(674, 301);
    this.cn.ConnectionString = "Data Source=mgasystems2012.ny.mgasystems.com;Initial Catalog=IMS;Integrated Security=True";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.daLocation.DeleteCommand = this.SqlDeleteCommand1;
    this.daLocation.InsertCommand = this.SqlInsertCommand1;
    this.daLocation.SelectCommand = this.SqlSelectCommand1;
    this.daLocation.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUnderwritingLocations", new DataColumnMapping[70]
      {
        new DataColumnMapping("LocationID", "LocationID"),
        new DataColumnMapping("LocationGuid", "LocationGuid"),
        new DataColumnMapping("QuoteGuid", "QuoteGuid"),
        new DataColumnMapping("LocationNo", "LocationNo"),
        new DataColumnMapping("BuildingNo", "BuildingNo"),
        new DataColumnMapping("PhysicalBuildingNo", "PhysicalBuildingNo"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("Zip", "Zip"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("ConstructionID", "ConstructionID"),
        new DataColumnMapping("ProtectionCode", "ProtectionCode"),
        new DataColumnMapping("AddnInformation", "AddnInformation"),
        new DataColumnMapping("SqFootage", "SqFootage"),
        new DataColumnMapping("EQZone", "EQZone"),
        new DataColumnMapping("FloodZone", "FloodZone"),
        new DataColumnMapping("EQConstruction", "EQConstruction"),
        new DataColumnMapping("WindCoverage", "WindCoverage"),
        new DataColumnMapping("Territory", "Territory"),
        new DataColumnMapping("TaxTerritory", "TaxTerritory"),
        new DataColumnMapping("Inspect", "Inspect"),
        new DataColumnMapping("Photo", "Photo"),
        new DataColumnMapping("Diagram", "Diagram"),
        new DataColumnMapping("CostEstimator", "CostEstimator"),
        new DataColumnMapping("UserAdded", "UserAdded"),
        new DataColumnMapping("DateAdded", "DateAdded"),
        new DataColumnMapping("DistToFireHydrant", "DistToFireHydrant"),
        new DataColumnMapping("DistToFireStation", "DistToFireStation"),
        new DataColumnMapping("FireDistrict", "FireDistrict"),
        new DataColumnMapping("Stories", "Stories"),
        new DataColumnMapping("Basements", "Basements"),
        new DataColumnMapping("Elevators", "Elevators"),
        new DataColumnMapping("YearBuilt", "YearBuilt"),
        new DataColumnMapping("WiringYear", "WiringYear"),
        new DataColumnMapping("RoofingYear", "RoofingYear"),
        new DataColumnMapping("PlumbingYear", "PlumbingYear"),
        new DataColumnMapping("HeatingYear", "HeatingYear"),
        new DataColumnMapping("ModificationCode", "ModificationCode"),
        new DataColumnMapping("InspectionCompanyID", "InspectionCompanyID"),
        new DataColumnMapping("InspectionContact", "InspectionContact"),
        new DataColumnMapping("InspectionContactPhone", "InspectionContactPhone"),
        new DataColumnMapping("Comments", "Comments"),
        new DataColumnMapping("ClassCodeID", "ClassCodeID"),
        new DataColumnMapping("FireAlarmTypeID", "FireAlarmTypeID"),
        new DataColumnMapping("BurglarAlarmTypeID", "BurglarAlarmTypeID"),
        new DataColumnMapping("LockedAndSecured", "LockedAndSecured"),
        new DataColumnMapping("SprinklerTypeID", "SprinklerTypeID"),
        new DataColumnMapping("Vacant", "Vacant"),
        new DataColumnMapping("WindRestrictionID", "WindRestrictionID"),
        new DataColumnMapping("GEOPhyBuildNum", "GEOPhyBuildNum"),
        new DataColumnMapping("GEOAddress1", "GEOAddress1"),
        new DataColumnMapping("GEOAddress2", "GEOAddress2"),
        new DataColumnMapping("GEOCity", "GEOCity"),
        new DataColumnMapping("GEOState", "GEOState"),
        new DataColumnMapping("GEOCounty", "GEOCounty"),
        new DataColumnMapping("GEOZip", "GEOZip"),
        new DataColumnMapping("GEOZipPlus", "GEOZipPlus"),
        new DataColumnMapping("RecCheck", "RecCheck"),
        new DataColumnMapping("Rush", "Rush"),
        new DataColumnMapping("DueDate", "DueDate"),
        new DataColumnMapping("Latitude", "Latitude"),
        new DataColumnMapping("Longitude", "Longitude"),
        new DataColumnMapping("GeoStatus", "GeoStatus"),
        new DataColumnMapping("GeoURL", "GeoURL"),
        new DataColumnMapping("BaseLocationId", "BaseLocationId"),
        new DataColumnMapping("LocationLookup", "LocationLookup"),
        new DataColumnMapping("RoofInspectionCompanyID", "RoofInspectionCompanyID")
      })
    });
    this.daLocation.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblUnderwritingLocations] WHERE (([LocationID] = @Original_LocationID))";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_LocationID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LocationID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[69]
    {
      new SqlParameter("@LocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LocationGuid"),
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid"),
      new SqlParameter("@LocationNo", SqlDbType.Int, 4, "LocationNo"),
      new SqlParameter("@BuildingNo", SqlDbType.VarChar, 20, "BuildingNo"),
      new SqlParameter("@PhysicalBuildingNo", SqlDbType.VarChar, 50, "PhysicalBuildingNo"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 500, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 200, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 50, "City"),
      new SqlParameter("@State", SqlDbType.Char, 2, "State"),
      new SqlParameter("@County", SqlDbType.VarChar, 100, "County"),
      new SqlParameter("@Zip", SqlDbType.VarChar, 6, "Zip"),
      new SqlParameter("@ZipPlus", SqlDbType.Char, 4, "ZipPlus"),
      new SqlParameter("@ConstructionID", SqlDbType.TinyInt, 1, "ConstructionID"),
      new SqlParameter("@ProtectionCode", SqlDbType.VarChar, 5, "ProtectionCode"),
      new SqlParameter("@AddnInformation", SqlDbType.VarChar, 1000, "AddnInformation"),
      new SqlParameter("@SqFootage", SqlDbType.Int, 4, "SqFootage"),
      new SqlParameter("@EQZone", SqlDbType.Char, 2, "EQZone"),
      new SqlParameter("@FloodZone", SqlDbType.VarChar, 25, "FloodZone"),
      new SqlParameter("@EQConstruction", SqlDbType.Char, 2, "EQConstruction"),
      new SqlParameter("@WindCoverage", SqlDbType.Bit, 1, "WindCoverage"),
      new SqlParameter("@Territory", SqlDbType.Char, 3, "Territory"),
      new SqlParameter("@TaxTerritory", SqlDbType.Char, 2, "TaxTerritory"),
      new SqlParameter("@Inspect", SqlDbType.Bit, 1, "Inspect"),
      new SqlParameter("@Photo", SqlDbType.Bit, 1, "Photo"),
      new SqlParameter("@Diagram", SqlDbType.Bit, 1, "Diagram"),
      new SqlParameter("@CostEstimator", SqlDbType.Bit, 1, "CostEstimator"),
      new SqlParameter("@UserAdded", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserAdded"),
      new SqlParameter("@DateAdded", SqlDbType.DateTime, 8, "DateAdded"),
      new SqlParameter("@DistToFireHydrant", SqlDbType.Int, 4, "DistToFireHydrant"),
      new SqlParameter("@DistToFireStation", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 5, (byte) 1, "DistToFireStation", DataRowVersion.Current, (object) null),
      new SqlParameter("@FireDistrict", SqlDbType.VarChar, 10, "FireDistrict"),
      new SqlParameter("@Stories", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 4, (byte) 1, "Stories", DataRowVersion.Current, (object) null),
      new SqlParameter("@Basements", SqlDbType.TinyInt, 1, "Basements"),
      new SqlParameter("@Elevators", SqlDbType.TinyInt, 1, "Elevators"),
      new SqlParameter("@YearBuilt", SqlDbType.SmallInt, 2, "YearBuilt"),
      new SqlParameter("@WiringYear", SqlDbType.SmallInt, 2, "WiringYear"),
      new SqlParameter("@RoofingYear", SqlDbType.SmallInt, 2, "RoofingYear"),
      new SqlParameter("@PlumbingYear", SqlDbType.SmallInt, 2, "PlumbingYear"),
      new SqlParameter("@HeatingYear", SqlDbType.SmallInt, 2, "HeatingYear"),
      new SqlParameter("@ModificationCode", SqlDbType.Char, 1, "ModificationCode"),
      new SqlParameter("@InspectionCompanyID", SqlDbType.Int, 4, "InspectionCompanyID"),
      new SqlParameter("@InspectionContact", SqlDbType.VarChar, 100, "InspectionContact"),
      new SqlParameter("@InspectionContactPhone", SqlDbType.VarChar, 12, "InspectionContactPhone"),
      new SqlParameter("@Comments", SqlDbType.VarChar, 3000, "Comments"),
      new SqlParameter("@ClassCodeID", SqlDbType.SmallInt, 2, "ClassCodeID"),
      new SqlParameter("@FireAlarmTypeID", SqlDbType.TinyInt, 1, "FireAlarmTypeID"),
      new SqlParameter("@BurglarAlarmTypeID", SqlDbType.TinyInt, 1, "BurglarAlarmTypeID"),
      new SqlParameter("@LockedAndSecured", SqlDbType.Bit, 1, "LockedAndSecured"),
      new SqlParameter("@SprinklerTypeID", SqlDbType.TinyInt, 1, "SprinklerTypeID"),
      new SqlParameter("@Vacant", SqlDbType.Bit, 1, "Vacant"),
      new SqlParameter("@WindRestrictionID", SqlDbType.TinyInt, 1, "WindRestrictionID"),
      new SqlParameter("@GEOPhyBuildNum", SqlDbType.VarChar, 50, "GEOPhyBuildNum"),
      new SqlParameter("@GEOAddress1", SqlDbType.VarChar, 200, "GEOAddress1"),
      new SqlParameter("@GEOAddress2", SqlDbType.VarChar, 200, "GEOAddress2"),
      new SqlParameter("@GEOCity", SqlDbType.VarChar, 50, "GEOCity"),
      new SqlParameter("@GEOState", SqlDbType.Char, 2, "GEOState"),
      new SqlParameter("@GEOCounty", SqlDbType.VarChar, 20, "GEOCounty"),
      new SqlParameter("@GEOZip", SqlDbType.VarChar, 5, "GEOZip"),
      new SqlParameter("@GEOZipPlus", SqlDbType.VarChar, 4, "GEOZipPlus"),
      new SqlParameter("@RecCheck", SqlDbType.Bit, 1, "RecCheck"),
      new SqlParameter("@Rush", SqlDbType.Bit, 1, "Rush"),
      new SqlParameter("@DueDate", SqlDbType.DateTime, 8, "DueDate"),
      new SqlParameter("@Latitude", SqlDbType.VarChar, 50, "Latitude"),
      new SqlParameter("@Longitude", SqlDbType.VarChar, 50, "Longitude"),
      new SqlParameter("@GeoStatus", SqlDbType.VarChar, 50, "GeoStatus"),
      new SqlParameter("@GeoURL", SqlDbType.VarChar, 500, "GeoURL"),
      new SqlParameter("@LocationLookup", SqlDbType.Bit, 1, "LocationLookup"),
      new SqlParameter("@RoofInspectionCompanyID", SqlDbType.Int, 4, "RoofInspectionCompanyID"),
      new SqlParameter("@ContactEmail", SqlDbType.VarChar, 60, "ContactEmail")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@LocationID", SqlDbType.Int, 4, "LocationID"),
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[71]
    {
      new SqlParameter("@LocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LocationGuid"),
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid"),
      new SqlParameter("@LocationNo", SqlDbType.Int, 4, "LocationNo"),
      new SqlParameter("@BuildingNo", SqlDbType.VarChar, 20, "BuildingNo"),
      new SqlParameter("@PhysicalBuildingNo", SqlDbType.VarChar, 50, "PhysicalBuildingNo"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 500, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 200, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 50, "City"),
      new SqlParameter("@State", SqlDbType.Char, 2, "State"),
      new SqlParameter("@County", SqlDbType.VarChar, 100, "County"),
      new SqlParameter("@Zip", SqlDbType.VarChar, 6, "Zip"),
      new SqlParameter("@ZipPlus", SqlDbType.Char, 4, "ZipPlus"),
      new SqlParameter("@ConstructionID", SqlDbType.TinyInt, 1, "ConstructionID"),
      new SqlParameter("@ProtectionCode", SqlDbType.VarChar, 5, "ProtectionCode"),
      new SqlParameter("@AddnInformation", SqlDbType.VarChar, 1000, "AddnInformation"),
      new SqlParameter("@SqFootage", SqlDbType.Int, 4, "SqFootage"),
      new SqlParameter("@EQZone", SqlDbType.Char, 2, "EQZone"),
      new SqlParameter("@FloodZone", SqlDbType.VarChar, 25, "FloodZone"),
      new SqlParameter("@EQConstruction", SqlDbType.Char, 2, "EQConstruction"),
      new SqlParameter("@WindCoverage", SqlDbType.Bit, 1, "WindCoverage"),
      new SqlParameter("@Territory", SqlDbType.Char, 3, "Territory"),
      new SqlParameter("@TaxTerritory", SqlDbType.Char, 2, "TaxTerritory"),
      new SqlParameter("@Inspect", SqlDbType.Bit, 1, "Inspect"),
      new SqlParameter("@Photo", SqlDbType.Bit, 1, "Photo"),
      new SqlParameter("@Diagram", SqlDbType.Bit, 1, "Diagram"),
      new SqlParameter("@CostEstimator", SqlDbType.Bit, 1, "CostEstimator"),
      new SqlParameter("@UserAdded", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserAdded"),
      new SqlParameter("@DateAdded", SqlDbType.DateTime, 8, "DateAdded"),
      new SqlParameter("@DistToFireHydrant", SqlDbType.Int, 4, "DistToFireHydrant"),
      new SqlParameter("@DistToFireStation", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 5, (byte) 1, "DistToFireStation", DataRowVersion.Current, (object) null),
      new SqlParameter("@FireDistrict", SqlDbType.VarChar, 10, "FireDistrict"),
      new SqlParameter("@Stories", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 4, (byte) 1, "Stories", DataRowVersion.Current, (object) null),
      new SqlParameter("@Basements", SqlDbType.TinyInt, 1, "Basements"),
      new SqlParameter("@Elevators", SqlDbType.TinyInt, 1, "Elevators"),
      new SqlParameter("@YearBuilt", SqlDbType.SmallInt, 2, "YearBuilt"),
      new SqlParameter("@WiringYear", SqlDbType.SmallInt, 2, "WiringYear"),
      new SqlParameter("@RoofingYear", SqlDbType.SmallInt, 2, "RoofingYear"),
      new SqlParameter("@PlumbingYear", SqlDbType.SmallInt, 2, "PlumbingYear"),
      new SqlParameter("@HeatingYear", SqlDbType.SmallInt, 2, "HeatingYear"),
      new SqlParameter("@ModificationCode", SqlDbType.Char, 1, "ModificationCode"),
      new SqlParameter("@InspectionCompanyID", SqlDbType.Int, 4, "InspectionCompanyID"),
      new SqlParameter("@InspectionContact", SqlDbType.VarChar, 100, "InspectionContact"),
      new SqlParameter("@InspectionContactPhone", SqlDbType.VarChar, 12, "InspectionContactPhone"),
      new SqlParameter("@Comments", SqlDbType.VarChar, 3000, "Comments"),
      new SqlParameter("@ClassCodeID", SqlDbType.SmallInt, 2, "ClassCodeID"),
      new SqlParameter("@FireAlarmTypeID", SqlDbType.TinyInt, 1, "FireAlarmTypeID"),
      new SqlParameter("@BurglarAlarmTypeID", SqlDbType.TinyInt, 1, "BurglarAlarmTypeID"),
      new SqlParameter("@LockedAndSecured", SqlDbType.Bit, 1, "LockedAndSecured"),
      new SqlParameter("@SprinklerTypeID", SqlDbType.TinyInt, 1, "SprinklerTypeID"),
      new SqlParameter("@Vacant", SqlDbType.Bit, 1, "Vacant"),
      new SqlParameter("@WindRestrictionID", SqlDbType.TinyInt, 1, "WindRestrictionID"),
      new SqlParameter("@GEOPhyBuildNum", SqlDbType.VarChar, 50, "GEOPhyBuildNum"),
      new SqlParameter("@GEOAddress1", SqlDbType.VarChar, 200, "GEOAddress1"),
      new SqlParameter("@GEOAddress2", SqlDbType.VarChar, 200, "GEOAddress2"),
      new SqlParameter("@GEOCity", SqlDbType.VarChar, 50, "GEOCity"),
      new SqlParameter("@GEOState", SqlDbType.Char, 2, "GEOState"),
      new SqlParameter("@GEOCounty", SqlDbType.VarChar, 20, "GEOCounty"),
      new SqlParameter("@GEOZip", SqlDbType.VarChar, 5, "GEOZip"),
      new SqlParameter("@GEOZipPlus", SqlDbType.VarChar, 4, "GEOZipPlus"),
      new SqlParameter("@RecCheck", SqlDbType.Bit, 1, "RecCheck"),
      new SqlParameter("@Rush", SqlDbType.Bit, 1, "Rush"),
      new SqlParameter("@DueDate", SqlDbType.DateTime, 8, "DueDate"),
      new SqlParameter("@Latitude", SqlDbType.VarChar, 50, "Latitude"),
      new SqlParameter("@Longitude", SqlDbType.VarChar, 50, "Longitude"),
      new SqlParameter("@GeoStatus", SqlDbType.VarChar, 50, "GeoStatus"),
      new SqlParameter("@GeoURL", SqlDbType.VarChar, 500, "GeoURL"),
      new SqlParameter("@LocationLookup", SqlDbType.Bit, 1, "LocationLookup"),
      new SqlParameter("@RoofInspectionCompanyID", SqlDbType.Int, 4, "RoofInspectionCompanyID"),
      new SqlParameter("@ContactEmail", SqlDbType.VarChar, 60, "ContactEmail"),
      new SqlParameter("@Original_LocationID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LocationID", DataRowVersion.Original, (object) null),
      new SqlParameter("@LocationID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LocationID", DataRowVersion.Original, (object) null)
    });
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._frmUnderwritingLocations_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Left).Name = "_frmUnderwritingLocations_Toolbars_Dock_Area_Left";
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Left).Size = new Size(0, 565);
    this._frmUnderwritingLocations_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "contextMenu";
    ultraToolbar.Visible = false;
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedPropsInternal).Caption = "Copy Location";
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "contextMenu";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3
    });
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Restore Location";
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool1,
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool4
    });
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._frmUnderwritingLocations_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Right).Location = new Point(692, 0);
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Right).Name = "_frmUnderwritingLocations_Toolbars_Dock_Area_Right";
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Right).Size = new Size(0, 565);
    this._frmUnderwritingLocations_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._frmUnderwritingLocations_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Top).Name = "_frmUnderwritingLocations_Toolbars_Dock_Area_Top";
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Top).Size = new Size(692, 0);
    this._frmUnderwritingLocations_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._frmUnderwritingLocations_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Bottom).Location = new Point(0, 565);
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Bottom).Name = "_frmUnderwritingLocations_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Bottom).Size = new Size(692, 0);
    this._frmUnderwritingLocations_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(692, 565);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Controls.Add((Control) this.dgLocations);
    this.Controls.Add((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmUnderwritingLocations_Toolbars_Dock_Area_Top);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmUnderwritingLocations);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Underwriting Locations";
    ((Control) this.tabLocationInfo).ResumeLayout(false);
    ((Control) this.tabLocationInfo).PerformLayout();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboWindRestriction).EndInit();
    this.dvWindRestriction.EndInit();
    ((ISupportInitialize) this.cboPolicyClasses).EndInit();
    ((ISupportInitialize) this.cboConstruction).EndInit();
    ((ISupportInitialize) this.txtLocationNum).EndInit();
    ((ISupportInitialize) this.txtBuildingNum).EndInit();
    ((ISupportInitialize) this.txtPhysBuildNum).EndInit();
    ((ISupportInitialize) this.txtProtectionCode).EndInit();
    ((ISupportInitialize) this.txtTerritory).EndInit();
    ((Control) this.tabGeoAddress).ResumeLayout(false);
    ((Control) this.tabGeoAddress).PerformLayout();
    ((ISupportInitialize) this.MgaTextBox1).EndInit();
    ((ISupportInitialize) this.MgaTextBox2).EndInit();
    ((ISupportInitialize) this.txtGEOPhysBuildNum).EndInit();
    ((Control) this.tabAdditionalInfo).ResumeLayout(false);
    ((Control) this.tabAdditionalInfo).PerformLayout();
    ((ISupportInitialize) this.txtDistToFireStattion).EndInit();
    ((ISupportInitialize) this.chkVacant).EndInit();
    ((ISupportInitialize) this.chkLockedSecure).EndInit();
    ((ISupportInitialize) this.cboSprinklerSystem).EndInit();
    ((ISupportInitialize) this.cboBurglarAlarmType).EndInit();
    this.dvBurglar.EndInit();
    ((ISupportInitialize) this.cboFireAlarmType).EndInit();
    this.dvFire.EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.chkWindCoverage).EndInit();
    ((ISupportInitialize) this.txtTaxTerritory).EndInit();
    ((ISupportInitialize) this.txtEQConst).EndInit();
    ((ISupportInitialize) this.txtEarthquakeZone).EndInit();
    ((ISupportInitialize) this.txtAdditionalInfo).EndInit();
    ((Control) this.tabYears).ResumeLayout(false);
    ((Control) this.tabYears).PerformLayout();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((Control) this.tabInspectionInfo).ResumeLayout(false);
    ((Control) this.tabInspectionInfo).PerformLayout();
    ((ISupportInitialize) this.txtContactEmail).EndInit();
    ((ISupportInitialize) this.cboRoofInspectionCompany).EndInit();
    ((ISupportInitialize) this.chkLocationLookup).EndInit();
    ((ISupportInitialize) this.dtDueDate).EndInit();
    ((ISupportInitialize) this.MgaCheckBox2).EndInit();
    ((ISupportInitialize) this.MgaCheckBox1).EndInit();
    ((ISupportInitialize) this.txtComments).EndInit();
    ((ISupportInitialize) this.txtContactPhone).EndInit();
    ((ISupportInitialize) this.txtInspectionContact).EndInit();
    ((ISupportInitialize) this.cboInspectionCompanies).EndInit();
    ((ISupportInitialize) this.CheckBox4).EndInit();
    ((ISupportInitialize) this.CheckBox3).EndInit();
    ((ISupportInitialize) this.CheckBox2).EndInit();
    ((ISupportInitialize) this.chkInspectionRequired).EndInit();
    ((ISupportInitialize) this.dgLocations).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).PerformLayout();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  public MGATextBox PhysicalBuildingNumber => this.txtPhysBuildNum;

  public int RecentlyAddedLocationID
  {
    get
    {
      return this.bmb.Position == -1 || this.ds.tblUnderwritingLocations.Count == 0 ? int.MinValue : this.ds.tblUnderwritingLocations[this.ds.tblUnderwritingLocations.Count - 1].LocationID;
    }
  }

  protected Guid QuoteGuid => this._q.QuoteGuid;

  protected BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblUnderwritingLocations.TableName];
  }

  protected Guid CurrentLocationGuid
  {
    get => this.ds.tblUnderwritingLocations[this.bmb.Position].LocationGUID;
  }

  protected bool IsEditing => this._editClicked;

  protected MGASimpleComboBox FireAlarmType => this.cboFireAlarmType;

  protected MGASimpleComboBox BurglarAlarmType => this.cboBurglarAlarmType;

  protected MGASimpleComboBox SprinklerType => this.cboSprinklerSystem;

  protected virtual bool FormLaunchedViaExposure => this._launchedByExposureScreen;

  protected frmUnderwritingLocations()
  {
    this.Load += new EventHandler(this.frmUnderwritingLocations_Load);
    this._DefaultDaysOnRush = 0;
    this._revertModifiedLocationsOnEndorsements = true;
    this.InitializeComponent();
  }

  public frmUnderwritingLocations(Quote quote)
  {
    this.Load += new EventHandler(this.frmUnderwritingLocations_Load);
    this._DefaultDaysOnRush = 0;
    this._revertModifiedLocationsOnEndorsements = true;
    this._q = quote;
    this.InitializeComponent();
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    MGA_ZipCodeResolver zipCodeResolver1 = this.ZipCodeResolver1;
    zipCodeResolver1.AddressServiceURL = AddressResolverSettings.AddressResolverURL;
    zipCodeResolver1.UserID = AddressResolverSettings.AddressResolveUserName;
    zipCodeResolver1.Password = AddressResolverSettings.AddressResolverPassword;
  }

  public frmUnderwritingLocations(Guid quoteGuid)
    : this(new Quote(quoteGuid))
  {
  }

  public frmUnderwritingLocations(Guid quoteGuid, bool launchedByExposureScreen)
    : this(new Quote(quoteGuid))
  {
    this._launchedByExposureScreen = true;
  }

  private void frmUnderwritingLocations_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.Text = "Underwriting Locations - Control #" + Conversions.ToString(this._q.ControlNo);
    ((UltraToggleEditorBase) this.MgaCheckBox2).CheckedChanged -= new EventHandler(this.MgaCheckBox2_CheckedChanged);
    this.cboInspectionCompanies.ValueChanged -= new EventHandler(this.cboInspectionCompanies_ValueChanged);
    this.SetControlsEnabled();
    dsUnderwritingLocations.lstWindRestrictionsRow row = this.ds.lstWindRestrictions.NewlstWindRestrictionsRow();
    row.Restriction = string.Empty;
    this.ds.lstWindRestrictions.AddlstWindRestrictionsRow(row);
    this.ds.tblFin_ExpensePayees.AddtblFin_ExpensePayeesRow(string.Empty);
    this.ds.dtRoofInspectionCompanies.AdddtRoofInspectionCompaniesRow(string.Empty);
    this.ds.lstFloodZones.AddlstFloodZonesRow(string.Empty);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[9]
    {
      "lstClassCodes",
      "lstConstructionTypes",
      "tblFin_ExpensePayees",
      "lstUnderwritingLocations_AlarmTypes",
      "lstUnderwritingLocations_SprinklerTypes",
      "lstWindRestrictions",
      "dtLocations",
      "lstFloodZones",
      "dtRoofInspectionCompanies"
    }, this.SetLoadDataSelectCommand(), new object[4]
    {
      (object) "@companyLineID",
      (object) this._q.CompanyLine.CompanyLineID,
      (object) "@QuoteGuid",
      (object) this._q.QuoteGuid
    });
    this.LoadUnderwritingLocations();
    this.dbSave.UIState = UIState.NoRecordsNotEditing;
    if (this._q.IsEndorsement)
      this._strikeoutFont = new Font(((Control) this.dgLocations).Font, FontStyle.Strikeout);
    this.AfterFormLoad();
    if (MGASystems.Common.SystemSettings.KeyExists("UnderwritingLocationDefaultDaysOnRush"))
      this._DefaultDaysOnRush = Convert.ToInt32(MGASystems.Common.SystemSettings.GetNumericSetting("UnderwritingLocationDefaultDaysOnRush"));
    this.SetDeleteSelection(false);
    if (MGASystems.Common.SystemSettings.KeyExists("RevertModifiedLocationsOnEndorsements"))
      this._revertModifiedLocationsOnEndorsements = MGASystems.Common.SystemSettings.GetBoolSetting("RevertModifiedLocationsOnEndorsements");
    ((UltraToggleEditorBase) this.MgaCheckBox2).CheckedChanged += new EventHandler(this.MgaCheckBox2_CheckedChanged);
    this.cboInspectionCompanies.ValueChanged += new EventHandler(this.cboInspectionCompanies_ValueChanged);
  }

  private void LoadUnderwritingLocations()
  {
    this.ds.tblUnderwritingLocations.Clear();
    SqlDataAdapter daLocation = this.daLocation;
    daLocation.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._q.QuoteGuid;
    daLocation.SelectCommand.Parameters["@LocationID"].Value = (object) DBNull.Value;
    try
    {
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLocation, (DataTable) this.ds.tblUnderwritingLocations);
      if (Information.IsNothing((object) ((UltraGridBase) this.dgLocations).ActiveRow))
        return;
      this.GetFloodExtra(this._q.QuoteGuid, Conversions.ToInteger(((UltraGridBase) this.dgLocations).ActiveRow.Cells["LocationID"].Value));
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual void GetFloodExtra(Guid Quoteid, int LocationID)
  {
  }

  protected virtual string SetLoadDataSelectCommand() => "dbo.UnderwritingLocationsData";

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e) => this._editClicked = true;

  private void UltraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Restore Location"].SharedProps.Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ds.tblUnderwritingLocations[this.bmb.Position].ModificationCode, "D", false) == 0;
  }

  private void lnkEditConstructionTypes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (SecurityManager.Instance.AssertPermission("{76423BDA-8CC8-4a48-BB91-43C968F3B6C8}"))
    {
      FormSettings.ShowFormDialog(typeof (frmCompanyConstructionTypes), (object) this._q.CompanyLine.CompanyLineID).Dispose();
    }
    else
    {
      int num = (int) MessageBox.Show("You do not have permission to access this form.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
  }

  private void lnkEditClassCodes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (SecurityManager.Instance.AssertPermission("{259189E9-914E-4efb-ABE7-FE0FA3DAB890}"))
    {
      FormSettings.ShowFormDialog(typeof (frmCompanyLineClasses), (object) this._q.CompanyLine.CompanyLineID).Dispose();
    }
    else
    {
      int num = (int) MessageBox.Show("You do not have permission to access this form.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  protected virtual void ClickedNewButton()
  {
  }

  protected virtual bool GetDefaultPhoto() => false;

  protected virtual void GetDefaultDueDate(MGADateTimePicker dueDate)
  {
  }

  protected virtual void GetDefaultFloodZone()
  {
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    this._editClicked = false;
    dsUnderwritingLocations.tblUnderwritingLocationsRow row = this.ds.tblUnderwritingLocations.NewtblUnderwritingLocationsRow();
    dsUnderwritingLocations.tblUnderwritingLocationsRow underwritingLocationsRow = row;
    underwritingLocationsRow.ModificationCode = "N";
    underwritingLocationsRow.LocationGUID = Guid.NewGuid();
    underwritingLocationsRow.QuoteGUID = this._q.QuoteGuid;
    underwritingLocationsRow.UserAdded = CurrentUser.Instance.UserGUID;
    underwritingLocationsRow.DateAdded = DateAndTime.Now;
    object objectValue1 = RuntimeHelpers.GetObjectValue(this.ds.tblUnderwritingLocations.Compute("MAX(LocationNo)", string.Empty));
    underwritingLocationsRow.LocationNo = !MGASystems.Data.Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue1)) ? Conversions.ToInteger(objectValue1) + 1 : 1;
    underwritingLocationsRow.WindCoverage = this.GetWindCoverageDefault();
    underwritingLocationsRow.Photo = this.GetDefaultPhoto();
    this.GetDefaultDueDate(this.dtDueDate);
    underwritingLocationsRow.Rush = false;
    underwritingLocationsRow.RecCheck = false;
    underwritingLocationsRow.Latitude = (string) null;
    underwritingLocationsRow.Longitude = (string) null;
    object objectValue2 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT InspectionCompanyID FROM tblQuotes WHERE QuoteID=@QID", new object[2]
    {
      (object) "@QID",
      (object) this._q.QuoteID
    }));
    if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue2)) && this.ds.tblFin_ExpensePayees.FindByPayeeID(Conversions.ToInteger(objectValue2)) != null)
      row.InspectionCompanyID = (int) objectValue2;
    this.GetDefaultFloodZone();
    this.ds.tblUnderwritingLocations.AddtblUnderwritingLocationsRow(row);
    this.bmb.Position = this.ds.tblUnderwritingLocations.Rows.Count - 1;
    this.ClickedNewButton();
  }

  protected virtual bool GetWindCoverageDefault() => true;

  private void SetControlsEnabled()
  {
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
        {
          if (control != this.dbSave)
            control.Enabled = this.dbSave.UIState == UIState.Editing;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this.lnkDeleteSelectAll.Enabled = this.dbSave.UIState != UIState.Editing;
    this.lnkDeSelectAllDelete.Enabled = this.dbSave.UIState != UIState.Editing;
    this.lnkCopyLocation.Enabled = true;
  }

  private void SetControlsEnabled(bool enabled)
  {
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
        {
          if (control != this.dbSave)
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
  }

  protected virtual void LockDownControls(bool isOverride, bool enabled)
  {
    if (!isOverride)
      return;
    this.SetControlsEnabled(enabled);
  }

  protected virtual void UIStateChanged()
  {
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.dgLocations).Enabled = this.dbSave.UIState != UIState.Editing;
    this.lnkAddInsured.Enabled = this.dbSave.UIState != UIState.Editing;
    this.SetControlsEnabled();
    this.LockDownControls(false, false);
    this.UIStateChanged();
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    // ISSUE: variable of a compiler-generated type
    frmUnderwritingLocations._Closure\u0024__459\u002D0 closure4590_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmUnderwritingLocations._Closure\u0024__459\u002D0 closure4590_2 = new frmUnderwritingLocations._Closure\u0024__459\u002D0(closure4590_1);
    // ISSUE: reference to a compiler-generated field
    closure4590_2.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure4590_2.\u0024VB\u0024Local_e = e;
    this._editClicked = false;
    if (!this.ValidForm())
    {
      // ISSUE: reference to a compiler-generated field
      closure4590_2.\u0024VB\u0024Local_e.Cancel = true;
    }
    else
    {
      bool isNewRecord = this.ds.tblUnderwritingLocations[this.bmb.Position].RowState == DataRowState.Added;
      if (string.IsNullOrEmpty(this.cmbtxtFloodZone.Text))
        this.ds.tblUnderwritingLocations[this.bmb.Position].SetFloodZoneNull();
      else
        this.ds.tblUnderwritingLocations[this.bmb.Position].FloodZone = this.cmbtxtFloodZone.Text;
      if (string.IsNullOrEmpty(this.cboRoofInspectionCompany.Text))
        this.ds.tblUnderwritingLocations[this.bmb.Position].SetRoofInspectionCompanyIDNull();
      this.bmb.EndCurrentEdit();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboWindRestriction.Text, string.Empty, false) == 0)
        this.ds.tblUnderwritingLocations[this.bmb.Position].SetWindRestrictionIDNull();
      else
        this.ds.tblUnderwritingLocations[this.bmb.Position].WindRestrictionID = (int) this.cboWindRestriction.Value;
      this.Cursor = MgaCursors.WaitCursor;
      if (this.ds.tblUnderwritingLocations[this.bmb.Position].RowState == DataRowState.Added)
        this.AutoFillGEOAddress();
      if (this.cboInspectionCompanies.Text.Length == 0 && !this.ds.tblUnderwritingLocations[this.bmb.Position].IsInspectionCompanyIDNull())
        this.ds.tblUnderwritingLocations[this.bmb.Position].SetInspectionCompanyIDNull();
      if (this._revertModifiedLocationsOnEndorsements && this._q.IsEndorsement && this.ds.tblUnderwritingLocations[this.bmb.Position].RowState == DataRowState.Modified)
      {
        this.ds.tblUnderwritingLocations[this.bmb.Position].ModificationCode = "M";
        ((UltraGridBase) this.dgLocations).ActiveRow.Appearance.ForeColor = Color.Blue;
      }
      List<string> changeList = new List<string>();
      if (!isNewRecord)
        this.LogChanges(changeList);
      // ISSUE: reference to a compiler-generated field
      closure4590_2.\u0024VB\u0024Local_successfullSave = false;
      Guid locationGuid = this.ds.tblUnderwritingLocations[this.bmb.Position].LocationGUID;
      // ISSUE: reference to a compiler-generated method
      DefaultDatabase.ExecuteTransaction(new EventHandler<ExecuteTransactionEventArgs>(closure4590_2._Lambda\u0024__0));
      if (isNewRecord)
      {
        CurrentUser.Instance.LogAction($"Added loc #{((TextEditorControlBase) this.txtLocationNum).Text} bldg #{((TextEditorControlBase) this.txtBuildingNum).Text}. Address {this.ZipCodeResolver1.Street1}, {this.ZipCodeResolver1.City} {this.ZipCodeResolver1.ZipCode}", this.QuoteGuid);
      }
      else
      {
        try
        {
          foreach (string action in changeList)
            CurrentUser.Instance.LogAction(action, this.QuoteGuid);
        }
        finally
        {
          List<string>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      this.lblBaseIdDisplay.Visible = this.lblBaseId.Text.Length > 0;
      // ISSUE: reference to a compiler-generated field
      if (!closure4590_2.\u0024VB\u0024Local_successfullSave)
        return;
      this.OnSuccessfulSave(locationGuid, isNewRecord);
      if (Information.IsNothing((object) ((UltraGridBase) this.dgLocations).ActiveRow))
        return;
      this.SaveFloodExtrainfo(this.QuoteGuid, Conversions.ToInteger(((UltraGridBase) this.dgLocations).ActiveRow.Cells["LocationID"].Value));
    }
  }

  protected virtual void SaveFloodExtrainfo(Guid QuoteGuid, int LocationID)
  {
  }

  protected virtual void ClickedCancel()
  {
  }

  protected virtual void OnSuccessfulSave(Guid locationGuid, bool isNewRecord)
  {
  }

  private void LogChanges(List<string> changeList)
  {
    string str1 = string.Empty;
    if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsLocationNoNull())
      str1 = $"Loc # {this.ds.tblUnderwritingLocations[this.bmb.Position].LocationNo}";
    if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsBuildingNoNull())
      str1 = $"{str1} Bldg # {this.ds.tblUnderwritingLocations[this.bmb.Position].BuildingNo}";
    if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsAddress1Null())
      str1 = $"{str1}.  {this.ds.tblUnderwritingLocations[this.bmb.Position].Address1}";
    if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsCityNull())
      str1 = $"{str1}, {this.ds.tblUnderwritingLocations[this.bmb.Position].City}";
    if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsStateNull())
      str1 = $"{str1}, {this.ds.tblUnderwritingLocations[this.bmb.Position].State}";
    if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsZipNull())
      str1 = $"{str1}, {this.ds.tblUnderwritingLocations[this.bmb.Position].Zip}";
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) this.ds.tblUnderwritingLocations.Columns)
      {
        try
        {
          string str2 = string.Empty;
          string str3 = string.Empty;
          if (this.ds.tblUnderwritingLocations[this.bmb.Position][column.ColumnName, DataRowVersion.Original] != null && this.ds.tblUnderwritingLocations[this.bmb.Position][column.ColumnName, DataRowVersion.Original] != DBNull.Value)
          {
            str2 = this.ds.tblUnderwritingLocations[this.bmb.Position][column.ColumnName, DataRowVersion.Original].ToString();
            if (!str2.Equals(string.Empty))
            {
              if (column.ColumnName.Equals("InspectionCompanyID"))
                str2 = this.ds.tblFin_ExpensePayees.FindByPayeeID(Conversions.ToInteger(str2)).PayeeName;
              if (column.ColumnName.Equals("WindRestrictionID"))
                str2 = this.ds.lstWindRestrictions.FindByRestrictionID(Conversions.ToInteger(str2)).Restriction;
              if (column.ColumnName.Equals("ConstructionID"))
                str2 = this.ds.lstConstructionTypes.FindByConstructionTypeID(Conversions.ToInteger(str2)).Type;
              if (column.ColumnName.Equals("ClassCodeID"))
                str2 = this.ds.lstClassCodes.FindByClassCodeID(Conversions.ToInteger(str2)).ClassCodeDescription;
            }
          }
          if (this.ds.tblUnderwritingLocations[this.bmb.Position][column.ColumnName, DataRowVersion.Current] != null && this.ds.tblUnderwritingLocations[this.bmb.Position][column.ColumnName, DataRowVersion.Current] != null)
          {
            str3 = this.ds.tblUnderwritingLocations[this.bmb.Position][column.ColumnName, DataRowVersion.Current].ToString();
            if (!str3.Equals(string.Empty))
            {
              if (column.ColumnName.Equals("InspectionCompanyID"))
                str3 = this.ds.tblFin_ExpensePayees.FindByPayeeID(Conversions.ToInteger(str3)).PayeeName;
              if (column.ColumnName.Equals("WindRestrictionID"))
                str3 = this.ds.lstWindRestrictions.FindByRestrictionID(Conversions.ToInteger(str3)).Restriction;
              if (column.ColumnName.Equals("ConstructionID"))
                str3 = this.ds.lstConstructionTypes.FindByConstructionTypeID(Conversions.ToInteger(str3)).Type;
              if (column.ColumnName.Equals("ClassCodeID"))
                str3 = this.ds.lstClassCodes.FindByClassCodeID(Conversions.ToInteger(str3)).ClassCodeDescription;
            }
          }
          if (str3.Replace(" ", "").Length == 0)
            str3 = "<NULL>";
          if (str2.Replace(" ", "").Length == 0)
            str2 = "<NULL>";
          if (!str2.Equals(str3))
            changeList.Add($"Modified {str1}. Changed {column.ColumnName} from {str2} to {str3}");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num = (int) MessageBox.Show(column.ColumnName, "dd", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          ProjectData.ClearProjectError();
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

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this._editClicked = false;
    this.ds.tblUnderwritingLocations.RejectChanges();
    try
    {
      foreach (Control control in ((Control) ((UltraTabControlBase) this.UltraTabControl1).SelectedTab.TabPage).Controls)
        this.err.SetError(control, string.Empty);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.dbSave.UIState = this.ds.tblUnderwritingLocations.Count != 0 ? UIState.HasRecordsNotEditing : UIState.NoRecordsNotEditing;
    this.ClickedCancel();
    this.dgLocations_AfterRowActivate((object) this, (EventArgs) null);
  }

  protected virtual void LocationsGridRowActivate()
  {
  }

  private void dgLocations_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgLocations).ActiveRow == null)
      return;
    if (Conversions.ToInteger(((UltraGridBase) this.dgLocations).ActiveRow.Cells["LocationID"].Value) != 0)
    {
      Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgLocations).ActiveRow.Cells["LocationID"].Value), "LocationID", (DataTable) this.ds.tblUnderwritingLocations, this.bmb);
      this.GetFloodExtra(this.QuoteGuid, Conversions.ToInteger(((UltraGridBase) this.dgLocations).ActiveRow.Cells["LocationID"].Value));
      if (this.ds.tblUnderwritingLocations[this.bmb.Position].IsFloodZoneNull())
      {
        this.cmbtxtFloodZone.SelectedValue = (object) "NONE";
      }
      else
      {
        this.cmbtxtFloodZone.SelectedValue = (object) this.ds.tblUnderwritingLocations[this.bmb.Position].FloodZone;
        this.cmbtxtFloodZone.Text = this.ds.tblUnderwritingLocations[this.bmb.Position].FloodZone;
      }
      if (this.dbSave.UIState != UIState.Editing)
        this.dbSave.UIState = UIState.HasRecordsNotEditing;
    }
    this.lblBaseIdDisplay.Visible = this.lblBaseId.Text.Length > 0;
    this.LocationsGridRowActivate();
    // ISSUE: reference to a compiler-generated field
    ISupportDocumentSystem.EntityInfoChangedEventHandler infoChangedEvent = this.EntityInfoChangedEvent;
    if (infoChangedEvent == null)
      return;
    infoChangedEvent((object) this, e);
  }

  private object DeleteLocationIDs(object sender, ExecuteTransactionEventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblPropertyExposure WHERE LocationID = @LocID", new object[2]
    {
      (object) "@LocID",
      (object) this._locationId
    });
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteAdditionalInterestsLocations WHERE UnderwritingLocationID = @unWritingLocID", new object[2]
    {
      (object) "@unWritingLocID",
      (object) this._locationId
    });
    return (object) null;
  }

  protected virtual bool CheckIfIssued(CancelEventArgs e) => true;

  protected virtual void DeleteOnClient(int locationID)
  {
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (!this.FormLaunchedViaExposure)
    {
      int num = (int) MessageBox.Show("Locations can not be deleted on this screen without entering through the appropriate rater.\n\nThe rater is required to re-calculate premiums when locations are removed.", "Rater Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
    {
      if (!this.CheckIfIssued(e) || this.bmb.Position == -1)
        return;
      this._editClicked = false;
      Dictionary<int, UltraGridRow> dictionary = new Dictionary<int, UltraGridRow>();
      bool flag = false;
      for (int key = ((UltraGridBase) this.dgLocations).Rows.Count - 1; key >= 0; --key)
      {
        if (((UltraGridBase) this.dgLocations).Rows[key].Cells["DeleteRecord"].Value != DBNull.Value && Conversions.ToBoolean(((UltraGridBase) this.dgLocations).Rows[key].Cells["DeleteRecord"].Value))
        {
          dictionary.Add(key, ((UltraGridBase) this.dgLocations).Rows[key]);
          flag = true;
        }
      }
      if (!flag)
        dictionary.Add(this.bmb.Position, ((UltraGridBase) this.dgLocations).ActiveRow);
      string text = "Are you sure you want to delete this location?";
      string caption = "Delete Location?";
      if (flag)
      {
        text = "Are you sure you want to delete the selected location(s)?";
        caption = "Delete Location(s)?";
      }
      if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      {
        e.Cancel = true;
      }
      else
      {
        bool deleteCompleteOnEndorsement = false;
        string empty1 = string.Empty;
        try
        {
          foreach (KeyValuePair<int, UltraGridRow> keyValuePair in dictionary)
          {
            Conversions.ToInteger(keyValuePair.Value.Cells["LocationID"].Value);
            string empty2 = string.Empty;
            string empty3 = string.Empty;
            string str = string.Empty;
            if (keyValuePair.Value.Cells["LocationNo"].Value != null && keyValuePair.Value.Cells["LocationNo"].Value != DBNull.Value)
              empty2 = keyValuePair.Value.Cells["LocationNo"].Value.ToString();
            if (keyValuePair.Value.Cells["BuildingNo"].Value != null && keyValuePair.Value.Cells["BuildingNo"].Value != DBNull.Value)
              empty3 = keyValuePair.Value.Cells["BuildingNo"].Value.ToString();
            if (keyValuePair.Value.Cells["Address1"].Value != null && keyValuePair.Value.Cells["Address1"].Value != DBNull.Value)
              str += keyValuePair.Value.Cells["Address1"].Value.ToString();
            if (keyValuePair.Value.Cells["City"].Value != null && keyValuePair.Value.Cells["City"].Value != DBNull.Value)
              str = $"{str}, {keyValuePair.Value.Cells["City"].Value.ToString()}";
            if (keyValuePair.Value.Cells["State"].Value != null && keyValuePair.Value.Cells["State"].Value != DBNull.Value)
              str = $"{str}, {keyValuePair.Value.Cells["State"].Value.ToString()}";
            if (keyValuePair.Value.Cells["Zip"].Value != null && keyValuePair.Value.Cells["Zip"].Value != DBNull.Value)
              str = $"{str} {keyValuePair.Value.Cells["Zip"].Value.ToString()}";
            try
            {
              this.DeleteSingleLocation(keyValuePair.Key, ref deleteCompleteOnEndorsement);
            }
            catch (SqlException ex1)
            {
              ProjectData.SetProjectError((Exception) ex1);
              SqlException ex2 = ex1;
              if (ex2.Number == 547)
              {
                this.ds.tblUnderwritingLocations.RejectChanges();
                this.bmb.Position = 0;
                int num = (int) MessageBox.Show("This location can not be removed, because it has data associated with it.", "Unable to Delete Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ProjectData.ClearProjectError();
                break;
              }
              ErrorHandler.HandleError((Exception) ex2);
              e.Cancel = true;
              ProjectData.ClearProjectError();
              break;
            }
            if (this._q.IsEndorsement && !deleteCompleteOnEndorsement)
            {
              UltraGridRow ultraGridRow = keyValuePair.Value;
              ultraGridRow.Appearance.ForeColor = Color.Red;
              ultraGridRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
              CurrentUser.Instance.LogAction($"Mark for deletion. Loc #{empty2} bldg # {empty3} {str}", this.QuoteGuid);
            }
            else
              CurrentUser.Instance.LogAction($"Deleted loc #{empty2} bldg #{empty3} {str}", this.QuoteGuid);
          }
        }
        finally
        {
          Dictionary<int, UltraGridRow>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
    }
  }

  private void DeleteSingleLocation(int recordIndex, ref bool deleteCompleteOnEndorsement)
  {
    int locationId = this.ds.tblUnderwritingLocations[recordIndex].LocationID;
    if (!this._q.IsEndorsement)
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblUnderwritingLocations SET OriginalLocationID = NULL WHERE OriginalLocationID = @locID", new object[2]
      {
        (object) "@locID",
        (object) this.ds.tblUnderwritingLocations[recordIndex].LocationID
      });
      this._locationId = this.ds.tblUnderwritingLocations[recordIndex].LocationID;
      this.ds.tblUnderwritingLocations[recordIndex].Delete();
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
      {
        this.DeleteLocationIDs(RuntimeHelpers.GetObjectValue(obj), args);
        args.Transaction.Commit();
      }));
    }
    else if (this.ds.dtLocations.FindByLocationID(this.ds.tblUnderwritingLocations[recordIndex].LocationID) == null)
    {
      this.ds.tblUnderwritingLocations[recordIndex].Delete();
      deleteCompleteOnEndorsement = true;
    }
    else
      this.ds.tblUnderwritingLocations[recordIndex].ModificationCode = "D";
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daLocation, (DataTable) this.ds.tblUnderwritingLocations);
    this.DeleteOnClient(locationId);
  }

  private void dgLocations_InitializeRow(object sender, InitializeRowEventArgs e)
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

  private void lnkAddInsured_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    DataRow row = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT Address1, Address2, City, County, State, ZipCode, ZipPlus FROM tblInsuredLocations WHERE InsuredLocationGuid=@ILG", new object[2]
    {
      (object) "@ILG",
      (object) this._q.SubmissionGroup.InsuredLocationGuid
    }).Rows[0];
    this.bmb.EndCurrentEdit();
    dsUnderwritingLocations.tblUnderwritingLocationsRow underwritingLocation = this.ds.tblUnderwritingLocations[this.bmb.Position];
    underwritingLocation.Address1 = row[0].ToString();
    underwritingLocation.Address2 = row[1].ToString();
    underwritingLocation.City = row[2].ToString();
    underwritingLocation.County = row[3].ToString();
    underwritingLocation.State = row[4].ToString();
    underwritingLocation.Zip = row[5].ToString();
    underwritingLocation.ZipPlus = row[6].ToString();
    this.OnAddInsured();
  }

  protected virtual void OnAddInsured()
  {
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Copy Location", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Restore Location", false) != 0)
        return;
      this.RestoreLocation();
    }
    else
      this.CopyLocation();
  }

  private void lnkShowMap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.bmb.Position == -1)
      return;
    this.ZipCodeResolver1.ShowInGoogleMaps();
  }

  private void CopyLocation()
  {
    if (MessageBox.Show("Are you sure you want to copy this location?", "Copy Location?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      this.daLocation.SelectCommand.Parameters["@LocationID"].Value = (object) DefaultDatabase.ExecuteScalar<int>("dbo.CopyUnderwritingLocation", new object[2]
      {
        (object) "@locationID",
        (object) (int) ((UltraGridBase) this.dgLocations).ActiveRow.Cells["LocationID"].Value
      });
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLocation, (DataTable) this.ds.tblUnderwritingLocations);
    }
    finally
    {
      this.Cursor = MgaCursors.WaitCursor;
    }
  }

  private void RestoreLocation()
  {
    if (MessageBox.Show("Are you sure you want to restore this location?", "Restore Location?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblUnderwritingLocations SET ModificationCode = @U WHERE LocationID = @ID", new object[4]
    {
      (object) "@ID",
      (object) this.ds.tblUnderwritingLocations[this.bmb.Position].LocationID,
      (object) "@U",
      (object) "U"
    });
    this.ds.tblUnderwritingLocations[this.bmb.Position].ModificationCode = "U";
    UltraGridRow activeRow = ((UltraGridBase) this.dgLocations).ActiveRow;
    activeRow.Appearance.ForeColor = Color.Black;
    activeRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
  }

  protected virtual void AfterFormLoad()
  {
  }

  protected virtual bool ValidForm()
  {
    bool valid1 = this.ValidateLocationInfoTab(true);
    bool flag;
    if (!valid1)
    {
      ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = this.tabLocationInfo.Tab;
      flag = false;
    }
    else
    {
      bool valid2 = this.ValidateAddlInfoTab(valid1);
      if (!valid2)
      {
        ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = this.tabAdditionalInfo.Tab;
        flag = false;
      }
      else
      {
        bool valid3 = this.ValidateConstructionYrsTab(valid2);
        if (!valid3)
        {
          ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = this.tabYears.Tab;
          flag = false;
        }
        else
        {
          bool valid4 = this.ValidateInspectionInfoTab(valid3);
          if (!valid4)
          {
            ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = this.tabInspectionInfo.Tab;
            flag = false;
          }
          else if (!this.ValidGeoCodeAddressTab(valid4))
          {
            ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = this.tabGeoAddress.Tab;
            flag = false;
          }
          else
            flag = true;
        }
      }
    }
    return flag;
  }

  protected virtual bool ValidGeoCodeAddressTab(bool valid) => true;

  protected virtual bool ValidPhysBuildingNum()
  {
    return ((TextEditorControlBase) this.txtPhysBuildNum).Text.Length != 0;
  }

  protected virtual bool ValidBuildingNum()
  {
    return ((TextEditorControlBase) this.txtBuildingNum).Text.Replace(" ", string.Empty).Length > 0;
  }

  private bool ValidateLocationInfoTab(bool valid)
  {
    if (!Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtLocationNum).Text))
    {
      this.err.SetError((Control) this.txtLocationNum, "Invalid Location Number");
      valid = false;
    }
    else
      this.err.SetError((Control) this.txtLocationNum, string.Empty);
    if (!this.ValidBuildingNum())
    {
      this.err.SetError((Control) this.txtBuildingNum, "Building Number Required");
      valid = false;
    }
    else
      this.err.SetError((Control) this.txtBuildingNum, string.Empty);
    if (!this.ValidPhysBuildingNum())
    {
      this.err.SetError((Control) this.txtPhysBuildNum, "Physical Building Number Required");
      valid = false;
    }
    else
      this.err.SetError((Control) this.txtPhysBuildNum, string.Empty);
    if (!this.ZipCodeResolver1.ValidateFields())
      valid = false;
    return valid;
  }

  private bool ValidateAddlInfoTab(bool valid)
  {
    try
    {
      foreach (Control control in ((Control) this.tabAdditionalInfo).Controls)
      {
        if (control.Tag != null)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Tag.ToString(), "n", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Text, string.Empty, false) != 0 && !Versioned.IsNumeric((object) control.Text))
          {
            this.err.SetError(control, "Please enter a number.");
            valid = false;
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
    return valid;
  }

  private bool ValidateConstructionYrsTab(bool valid)
  {
    try
    {
      foreach (Control control in ((Control) this.tabYears).Controls)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.err.GetError(control), string.Empty, false) == 0)
        {
          if (control.Tag != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Tag.ToString(), "y", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Text, string.Empty, false) != 0 && (!Versioned.IsNumeric((object) control.Text) || control.Text.Length != 4 || Conversions.ToInteger(control.Text) > DateAndTime.Now.Year))
          {
            this.err.SetError(control, "Please enter a valid year.");
            valid = false;
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
    return valid;
  }

  private bool ValidateInspectionInfoTab(bool valid)
  {
    if (((UltraToggleEditorBase) this.chkInspectionRequired).Checked || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboInspectionCompanies.Text, string.Empty, false) != 0)
    {
      if (this.cboInspectionCompanies.Text.Length == 0)
      {
        this.err.SetError((Control) this.cboInspectionCompanies, "Inspection company required.");
        valid = false;
      }
      else
        this.err.SetError((Control) this.cboInspectionCompanies, string.Empty);
      if (((TextEditorControlBase) this.txtInspectionContact).Text.Length == 0)
      {
        this.err.SetError((Control) this.txtInspectionContact, "Inspection contact required.");
        valid = false;
      }
      else
        this.err.SetError((Control) this.txtInspectionContact, string.Empty);
      if (this.txtContactPhone.Value.ToString().Length != 12)
      {
        this.err.SetError((Control) this.txtContactPhone, "Contact phone required.");
        valid = false;
      }
      else
        this.err.SetError((Control) this.txtContactPhone, string.Empty);
    }
    return valid;
  }

  protected virtual void SaveData(SqlTransaction trans)
  {
  }

  private void lnkUseLocationAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.bmb.Position == -1)
      return;
    this.DefaultGEOToLocationAddress();
  }

  private void DefaultGEOToLocationAddress()
  {
    this.bmb.EndCurrentEdit();
    dsUnderwritingLocations.tblUnderwritingLocationsRow underwritingLocation = this.ds.tblUnderwritingLocations[this.bmb.Position];
    if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsPhysicalBuildingNoNull())
      underwritingLocation.GEOPhyBuildNum = underwritingLocation.PhysicalBuildingNo;
    if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsZipNull())
      underwritingLocation.GEOZip = underwritingLocation.Zip;
    if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsZipPlusNull())
      underwritingLocation.GEOZipPlus = underwritingLocation.ZipPlus;
    if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsCityNull())
      underwritingLocation.GEOCity = underwritingLocation.City;
    if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsStateNull())
      underwritingLocation.GEOState = underwritingLocation.State;
    if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsCityNull())
      underwritingLocation.GEOCity = underwritingLocation.City;
    if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsAddress1Null())
      underwritingLocation.GEOAddress1 = underwritingLocation.Address1;
    if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsAddress2Null())
      underwritingLocation.GEOAddress2 = underwritingLocation.Address2;
    if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsCountyNull())
      underwritingLocation.GEOCounty = underwritingLocation.County;
  }

  private void AutoFillGEOAddress()
  {
    if (this.bmb.Position == -1 || !this.ds.tblUnderwritingLocations[this.bmb.Position].IsGEOZipNull() || !this.ds.tblUnderwritingLocations[this.bmb.Position].IsGEOAddress1Null() || !this.ds.tblUnderwritingLocations[this.bmb.Position].IsGEOCityNull() || !this.ds.tblUnderwritingLocations[this.bmb.Position].IsGEOStateNull())
      return;
    this.DefaultGEOToLocationAddress();
  }

  private void lnkDefaultWarranties_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("GetDefaultWarranties", new object[2]
    {
      (object) "@QuoteID",
      (object) this._q.QuoteID
    }));
    if (objectValue == null || objectValue == DBNull.Value)
      return;
    ((TextEditorControlBase) this.txtComments).Text = objectValue.ToString();
    if (this.bmb.Position == -1)
      return;
    this.ds.tblUnderwritingLocations[this.bmb.Position].Comments = ((TextEditorControlBase) this.txtComments).Text;
  }

  private void MgaCheckBox2_CheckedChanged(object sender, EventArgs e)
  {
    if (this.dtDueDate.Value != null && this.dtDueDate.Value != DBNull.Value || this._DefaultDaysOnRush == 0 || !((UltraToggleEditorBase) this.MgaCheckBox2).Checked)
      return;
    this.dtDueDate.Value = (object) DateTime.Now.AddDays((double) this._DefaultDaysOnRush);
  }

  private void cboInspectionCompanies_ValueChanged(object sender, EventArgs e)
  {
    this.InspectionCompanyChange(RuntimeHelpers.GetObjectValue(sender), e);
  }

  protected virtual void InspectionCompanyChange(object sender, EventArgs e)
  {
  }

  private void lnkDeleteSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetDeleteSelection(true);
  }

  private void lnkDeSelectAllDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetDeleteSelection(false);
  }

  private void SetDeleteSelection(bool booleanMode)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.dgLocations).Rows)
      row.Cells["DeleteRecord"].Value = (object) booleanMode;
  }

  private void lnkRoofInspectionsInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.bmb.Position == -1)
    {
      int num1 = (int) MessageBox.Show("Please select a valid row in the grid to continue.", "Invalid Row Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (this.ds.tblUnderwritingLocations[this.bmb.Position].RowState == DataRowState.Deleted)
    {
      int num2 = (int) MessageBox.Show("Current row is deleted.", "Current Row Deleted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (this.ds.tblUnderwritingLocations[this.bmb.Position].RowState == DataRowState.Added)
    {
      int num3 = (int) MessageBox.Show("Please save the current row information in order to continue.", "Save Current Row", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (this.ds.tblUnderwritingLocations[this.bmb.Position].IsRoofInspectionCompanyIDNull() || this.ds.tblUnderwritingLocations[this.bmb.Position].RoofInspectionCompanyID == -1)
    {
      int num4 = (int) MessageBox.Show("Please select a Roof Inspection Company in order to continue.", "Missing Roof Inspection Company", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      using (FormSettings.ShowFormDialog(typeof (FormRoofInspectionInfo), (object) this._q.QuoteGuid, (object) this.ds.tblUnderwritingLocations[this.bmb.Position].LocationGUID))
        ;
    }
  }

  private void lnkAddContacts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (Form form = FormSettings.ShowFormDialog(typeof (FormAddInspectionContacts), (object) this._q.QuoteGuid))
    {
      if (!((FormAddInspectionContacts) form).ClickOK)
        return;
      string str = $"{((FormAddInspectionContacts) form).SelectedFirstName} {((FormAddInspectionContacts) form).SelectedLastName}";
      string selectedPhone = ((FormAddInspectionContacts) form).SelectedPhone;
      string selectedEmail = ((FormAddInspectionContacts) form).SelectedEmail;
      if (this.bmb.Position != -1)
      {
        this.ds.tblUnderwritingLocations[this.bmb.Position].InspectionContact = str;
        this.ds.tblUnderwritingLocations[this.bmb.Position].InspectionContactPhone = selectedPhone;
        this.ds.tblUnderwritingLocations[this.bmb.Position].ContactEmail = selectedEmail;
      }
      ((TextEditorControlBase) this.txtInspectionContact).Text = str;
      this.txtContactPhone.Text = selectedPhone;
      ((TextEditorControlBase) this.txtContactEmail).Text = selectedEmail;
    }
  }

  private void lnkCopyInspectionInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.bmb.Position == -1)
      return;
    using (Form form = FormSettings.ShowFormDialog(typeof (FormLocationsDisplay), (object) this.CurrentLocationGuid, (object) this._q.QuoteGuid))
    {
      List<Guid> locationList = ((FormLocationsDisplay) form).LocationList;
      try
      {
        foreach (Guid guid in locationList)
        {
          DataRow[] dataRowArray = this.ds.Tables["tblUnderwritingLocations"].Select($"LocationGuid = '{guid}'");
          if (dataRowArray.Length > 0)
          {
            dataRowArray[0]["InspectionCompanyID"] = this.cboInspectionCompanies.Value == null || this.cboInspectionCompanies.Value == DBNull.Value ? (object) DBNull.Value : RuntimeHelpers.GetObjectValue(this.cboInspectionCompanies.Value);
            dataRowArray[0]["InspectionContact"] = (object) ((TextEditorControlBase) this.txtInspectionContact).Text;
            dataRowArray[0]["InspectionContactPhone"] = (object) this.txtContactPhone.Text;
            dataRowArray[0]["RoofInspectionCompanyID"] = this.cboRoofInspectionCompany.Value == null || this.cboRoofInspectionCompany.Value == DBNull.Value ? (object) DBNull.Value : RuntimeHelpers.GetObjectValue(this.cboRoofInspectionCompany.Value);
            dataRowArray[0]["Comments"] = (object) ((TextEditorControlBase) this.txtComments).Text;
            dataRowArray[0]["Inspect"] = (object) ((UltraToggleEditorBase) this.chkInspectionRequired).Checked;
            dataRowArray[0]["Photo"] = (object) ((UltraToggleEditorBase) this.CheckBox2).Checked;
            dataRowArray[0]["Diagram"] = (object) ((UltraToggleEditorBase) this.CheckBox3).Checked;
            dataRowArray[0]["CostEstimator"] = (object) ((UltraToggleEditorBase) this.CheckBox4).Checked;
            dataRowArray[0]["RecCheck"] = (object) ((UltraToggleEditorBase) this.MgaCheckBox1).Checked;
            dataRowArray[0]["Rush"] = (object) ((UltraToggleEditorBase) this.MgaCheckBox2).Checked;
            dataRowArray[0]["LocationLookup"] = (object) ((UltraToggleEditorBase) this.chkLocationLookup).Checked;
            dataRowArray[0]["DueDate"] = this.dtDueDate.Value == null || this.dtDueDate.Value == DBNull.Value ? (object) DBNull.Value : RuntimeHelpers.GetObjectValue(this.dtDueDate.Value);
            dataRowArray[0]["ContactEmail"] = (object) ((TextEditorControlBase) this.txtContactEmail).Text;
          }
        }
      }
      finally
      {
        List<Guid>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
  }

  private void lnkCopyLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MGASystems.Data.Utility.IsNull(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select top 1 LocationID from tblUnderwritingLocations with (nolock) where QuoteGuid = @QG", new object[2]
    {
      (object) "@QG",
      (object) this.QuoteGuid
    })))))
    {
      int num = (int) MessageBox.Show("No location exists on this policy.\n\nYou must first save existing location(s)", "No Location(s) Exist", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      using (FormSettings.ShowFormDialog(typeof (FormCopyLocations), (object) this.QuoteGuid))
        ;
    }
  }

  public bool AllowAddNewDocument => true;

  string IRecreatableEntity.EntityName
  {
    get
    {
      string entityName;
      if (this.bmb == null || this.bmb.Position == -1)
      {
        entityName = string.Empty;
      }
      else
      {
        string empty = string.Empty;
        string str = string.Empty;
        if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsLocationNoNull())
          empty = this.ds.tblUnderwritingLocations[this.bmb.Position].LocationNo.ToString();
        if (!this.ds.tblUnderwritingLocations[this.bmb.Position].IsBuildingNoNull())
          str = this.ds.tblUnderwritingLocations[this.bmb.Position].BuildingNo;
        entityName = !this._q.HasPolicyNumber ? $"Control:{this._q.ControlNo} / Loc {empty} / Bldg {str} " : $"Policy:{this._q.PolicyNumber} / Loc {empty} / Bldg {str} ";
      }
      return entityName;
    }
  }

  Guid IRecreatableEntity.EntityGuid
  {
    get
    {
      return this.bmb == null || this.bmb.Position == -1 ? Guid.Empty : this.ds.tblUnderwritingLocations[this.bmb.Position].LocationGUID;
    }
  }

  string IRecreatableEntity.FriendlyEntityName => "Underwriting Locations";

  string IRecreatableEntity.RecreateTypeName => typeof (frmUnderwritingLocations).ToString();

  bool IRecreatableEntity.CanReCreateEntity => false;

  bool IRecreatableEntity.HasControlGUID => false;

  Guid IRecreatableEntity.ControlGUID => Guid.Empty;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    bool flag;
    return flag;
  }
}

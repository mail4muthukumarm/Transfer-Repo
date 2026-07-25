// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.ExposureCapture.frmWCExposureCapture
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Policies.Rating.Locations;
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating.ExposureCapture;

[MGASystems.IMS.Policies.Rating.ExposureCapture.ExposureCapture("Worker's Compensation")]
public class frmWCExposureCapture : Form, IExposureCapture
{
  private IContainer components;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private SqlConnection cn;
  private dsWCExposureCapture ds;
  private SqlDataAdapter daExposure;
  private int _quoteId;
  private Quote _quote;
  private int _netRateQuoteID;

  public frmWCExposureCapture()
  {
    this.Load += new EventHandler(this.frmWCExposureCapture_Load);
    this._quoteId = -1;
    this._netRateQuoteID = int.MinValue;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraGrid dgLocations
  {
    get => this._dgLocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dgLocations_AfterRowActivate);
      UltraGrid dgLocations1 = this._dgLocations;
      if (dgLocations1 != null)
        dgLocations1.AfterRowActivate -= eventHandler;
      this._dgLocations = value;
      UltraGrid dgLocations2 = this._dgLocations;
      if (dgLocations2 == null)
        return;
      dgLocations2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabControl1")]
  internal virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  private virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingSave);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedCancel -= eventHandler;
        dbSave1.ClickingDelete -= cancelEventHandler1;
        dbSave1.ClickingEdit -= cancelEventHandler2;
        dbSave1.ClickingNew -= cancelEventHandler3;
        dbSave1.ClickingSave -= cancelEventHandler4;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedCancel += eventHandler;
      dbSave2.ClickingDelete += cancelEventHandler1;
      dbSave2.ClickingEdit += cancelEventHandler2;
      dbSave2.ClickingNew += cancelEventHandler3;
      dbSave2.ClickingSave += cancelEventHandler4;
    }
  }

  [field: AccessedThroughProperty("UltraTabControl2")]
  internal virtual UltraTabControl UltraTabControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage2")]
  private virtual UltraTabSharedControlsPage UltraTabSharedControlsPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabControl3")]
  internal virtual UltraTabControl UltraTabControl3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage3")]
  private virtual UltraTabSharedControlsPage UltraTabSharedControlsPage3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDescription")]
  private virtual MGATextBox txtDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabControl4")]
  private virtual UltraTabControl UltraTabControl4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage4")]
  private virtual UltraTabSharedControlsPage UltraTabSharedControlsPage4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabExposure")]
  private virtual UltraTabPageControl tabExposure { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  private virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daLocations")]
  private virtual SqlDataAdapter daLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand1")]
  private virtual SqlCommand SqlCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAComboBox cboClassCodes
  {
    get => this._cboClassCodes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboClassCodes_ValueChanged);
      MGAComboBox cboClassCodes1 = this._cboClassCodes;
      if (cboClassCodes1 != null)
        cboClassCodes1.ValueChanged -= eventHandler;
      this._cboClassCodes = value;
      MGAComboBox cboClassCodes2 = this._cboClassCodes;
      if (cboClassCodes2 == null)
        return;
      cboClassCodes2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtRenumeration")]
  private virtual MGANumericEditor txtRenumeration { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtRate")]
  private virtual MGANumericEditor txtRate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabControl5")]
  private virtual UltraTabControl UltraTabControl5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage6")]
  private virtual UltraTabSharedControlsPage UltraTabSharedControlsPage6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  private virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox5")]
  private virtual MGATextBox MgaTextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox6")]
  private virtual MGATextBox MgaTextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label21")]
  internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox7")]
  private virtual MGATextBox MgaTextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label22")]
  internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaComboBox3")]
  internal virtual MGAComboBox MgaComboBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage5")]
  private virtual UltraTabSharedControlsPage UltraTabSharedControlsPage5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  private virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor1")]
  private virtual MGANumericEditor MgaNumericEditor1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor2")]
  private virtual MGANumericEditor MgaNumericEditor2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox1")]
  private virtual MGATextBox MgaTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox2")]
  private virtual MGATextBox MgaTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox3")]
  private virtual MGATextBox MgaTextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaComboBox1")]
  internal virtual MGAComboBox MgaComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaComboBox2")]
  internal virtual MGAComboBox MgaComboBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaSimpleComboBox1")]
  private virtual MGASimpleComboBox MgaSimpleComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox4")]
  private virtual MGATextBox MgaTextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("LinkLabel1")]
  private virtual LinkLabel LinkLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("daPol")]
  private virtual SqlDataAdapter daPol { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand2")]
  private virtual SqlCommand SqlCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand3")]
  private virtual SqlCommand SqlCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand4")]
  private virtual SqlCommand SqlCommand4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand5")]
  private virtual SqlCommand SqlCommand5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand")]
  internal virtual SqlCommand SqlDeleteCommand { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand")]
  internal virtual SqlCommand SqlUpdateCommand { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddClassCode")]
  private virtual UltraDropDown ddClassCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox11")]
  private virtual MGATextBox MgaTextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox10")]
  private virtual MGATextBox MgaTextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox9")]
  private virtual MGATextBox MgaTextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox8")]
  private virtual MGATextBox MgaTextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor4")]
  private virtual MGANumericEditor MgaNumericEditor4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor3")]
  private virtual MGANumericEditor MgaNumericEditor3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label23")]
  internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboState")]
  private virtual MGASimpleComboBox cboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmWCExposureCapture));
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstWCLimits", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("WCLimitsID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("WCLimits");
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
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance36 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstClassCodes", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ClassCode");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ClassCodeDescription");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ClassCodeID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ClassCodeKey");
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
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance50 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblUnderwritingLocations", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("LocationNo");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("BuildingNo");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("PhysicalBuildingNo");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Address");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Zip");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ModificationCode");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("NetRateLoc");
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance58 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("lstWCLimits", -1);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("WCLimitsID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("WCLimits");
    Appearance appearance59 = new Appearance();
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
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance72 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstClassCodes", -1);
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ClassCode");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("ClassCodeDescription");
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
    Appearance appearance84 = new Appearance();
    Appearance appearance85 = new Appearance();
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    this.tabExposure = new UltraTabPageControl();
    this.txtRenumeration = new MGANumericEditor();
    this.txtRate = new MGANumericEditor();
    this.Label5 = new Label();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.txtDescription = new MGATextBox();
    this.lnkModifyLocations = new LinkLabel();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.Label9 = new Label();
    this.MgaTextBox11 = new MGATextBox();
    this.Label8 = new Label();
    this.MgaTextBox10 = new MGATextBox();
    this.Label7 = new Label();
    this.MgaTextBox9 = new MGATextBox();
    this.Label6 = new Label();
    this.MgaTextBox8 = new MGATextBox();
    this.btnSave = new MGAButton();
    this.Label19 = new Label();
    this.MgaTextBox5 = new MGATextBox();
    this.Label20 = new Label();
    this.MgaTextBox6 = new MGATextBox();
    this.Label21 = new Label();
    this.MgaTextBox7 = new MGATextBox();
    this.Label22 = new Label();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cn = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.daExposure = new SqlDataAdapter();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.UltraTabControl2 = new UltraTabControl();
    this.UltraTabSharedControlsPage2 = new UltraTabSharedControlsPage();
    this.UltraTabControl3 = new UltraTabControl();
    this.UltraTabSharedControlsPage3 = new UltraTabSharedControlsPage();
    this.UltraTabControl4 = new UltraTabControl();
    this.UltraTabSharedControlsPage4 = new UltraTabSharedControlsPage();
    this.err = new ErrorProvider(this.components);
    this.daLocations = new SqlDataAdapter();
    this.SqlDeleteCommand = new SqlCommand();
    this.SqlCommand1 = new SqlCommand();
    this.SqlUpdateCommand = new SqlCommand();
    this.UltraTabSharedControlsPage5 = new UltraTabSharedControlsPage();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.MgaNumericEditor1 = new MGANumericEditor();
    this.MgaNumericEditor2 = new MGANumericEditor();
    this.Label10 = new Label();
    this.MgaTextBox1 = new MGATextBox();
    this.Label11 = new Label();
    this.MgaTextBox2 = new MGATextBox();
    this.Label12 = new Label();
    this.MgaTextBox3 = new MGATextBox();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.MgaTextBox4 = new MGATextBox();
    this.LinkLabel1 = new LinkLabel();
    this.UltraTabControl5 = new UltraTabControl();
    this.UltraTabSharedControlsPage6 = new UltraTabSharedControlsPage();
    this.daPol = new SqlDataAdapter();
    this.SqlCommand2 = new SqlCommand();
    this.SqlCommand3 = new SqlCommand();
    this.SqlCommand4 = new SqlCommand();
    this.SqlCommand5 = new SqlCommand();
    this.MgaNumericEditor3 = new MGANumericEditor();
    this.Label23 = new Label();
    this.MgaNumericEditor4 = new MGANumericEditor();
    this.Label24 = new Label();
    this.ds = new dsWCExposureCapture();
    this.MgaComboBox3 = new MGAComboBox();
    this.cboClassCodes = new MGAComboBox();
    this.cboState = new MGASimpleComboBox();
    this.dgLocations = new UltraGrid();
    this.MgaComboBox1 = new MGAComboBox();
    this.MgaComboBox2 = new MGAComboBox();
    this.MgaSimpleComboBox1 = new MGASimpleComboBox();
    ((Control) this.tabExposure).SuspendLayout();
    ((ISupportInitialize) this.txtRenumeration).BeginInit();
    ((ISupportInitialize) this.txtRate).BeginInit();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.MgaTextBox11).BeginInit();
    ((ISupportInitialize) this.MgaTextBox10).BeginInit();
    ((ISupportInitialize) this.MgaTextBox9).BeginInit();
    ((ISupportInitialize) this.MgaTextBox8).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.MgaTextBox5).BeginInit();
    ((ISupportInitialize) this.MgaTextBox6).BeginInit();
    ((ISupportInitialize) this.MgaTextBox7).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((ISupportInitialize) this.UltraTabControl2).BeginInit();
    ((ISupportInitialize) this.UltraTabControl3).BeginInit();
    ((ISupportInitialize) this.UltraTabControl4).BeginInit();
    ((Control) this.UltraTabControl4).SuspendLayout();
    ((ISupportInitialize) this.err).BeginInit();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.MgaNumericEditor1).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor2).BeginInit();
    ((ISupportInitialize) this.MgaTextBox1).BeginInit();
    ((ISupportInitialize) this.MgaTextBox2).BeginInit();
    ((ISupportInitialize) this.MgaTextBox3).BeginInit();
    ((ISupportInitialize) this.MgaTextBox4).BeginInit();
    ((ISupportInitialize) this.UltraTabControl5).BeginInit();
    ((Control) this.UltraTabControl5).SuspendLayout();
    ((ISupportInitialize) this.MgaNumericEditor3).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor4).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.MgaComboBox3).BeginInit();
    ((ISupportInitialize) this.cboClassCodes).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((ISupportInitialize) this.dgLocations).BeginInit();
    ((ISupportInitialize) this.MgaComboBox1).BeginInit();
    ((ISupportInitialize) this.MgaComboBox2).BeginInit();
    ((ISupportInitialize) this.MgaSimpleComboBox1).BeginInit();
    this.SuspendLayout();
    ((Control) this.tabExposure).Controls.Add((Control) this.MgaNumericEditor4);
    ((Control) this.tabExposure).Controls.Add((Control) this.Label24);
    ((Control) this.tabExposure).Controls.Add((Control) this.MgaNumericEditor3);
    ((Control) this.tabExposure).Controls.Add((Control) this.Label23);
    ((Control) this.tabExposure).Controls.Add((Control) this.txtRenumeration);
    ((Control) this.tabExposure).Controls.Add((Control) this.txtRate);
    ((Control) this.tabExposure).Controls.Add((Control) this.cboClassCodes);
    ((Control) this.tabExposure).Controls.Add((Control) this.Label5);
    ((Control) this.tabExposure).Controls.Add((Control) this.cboState);
    ((Control) this.tabExposure).Controls.Add((Control) this.Label4);
    ((Control) this.tabExposure).Controls.Add((Control) this.Label3);
    ((Control) this.tabExposure).Controls.Add((Control) this.Label2);
    ((Control) this.tabExposure).Controls.Add((Control) this.Label1);
    ((Control) this.tabExposure).Controls.Add((Control) this.txtDescription);
    ((Control) this.tabExposure).Controls.Add((Control) this.lnkModifyLocations);
    ((Control) this.tabExposure).Controls.Add((Control) this.dbSave);
    ((Control) this.tabExposure).Location = new Point(1, 26);
    ((Control) this.tabExposure).Name = "tabExposure";
    ((Control) this.tabExposure).Size = new Size(736, 199);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtRenumeration).Appearance = (AppearanceBase) appearance1;
    ((Control) this.txtRenumeration).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericWCExposures.Renumeration", true));
    ((UltraNumericEditorBase) this.txtRenumeration).FormatString = "c";
    ((Control) this.txtRenumeration).Location = new Point(116, 40);
    this.txtRenumeration.MaxValue = (object) new Decimal(new int[4]
    {
      1316134911,
      2328,
      0,
      131072 /*0x020000*/
    });
    this.txtRenumeration.MGAStyle = MGAStyles.Blue;
    this.txtRenumeration.MinValue = (object) 0;
    ((Control) this.txtRenumeration).Name = "txtRenumeration";
    this.txtRenumeration.Nullable = true;
    this.txtRenumeration.NumericType = (NumericType) 2;
    ((Control) this.txtRenumeration).Size = new Size(133, 20);
    ((Control) this.txtRenumeration).TabIndex = 1;
    ((UltraControlBase) this.txtRenumeration).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRenumeration).UseOsThemes = (DefaultableBoolean) 2;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtRate).Appearance = (AppearanceBase) appearance2;
    ((Control) this.txtRate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericWCExposures.Rate", true));
    ((UltraNumericEditorBase) this.txtRate).FormatString = "c";
    ((Control) this.txtRate).Location = new Point(465, 40);
    this.txtRate.MaxValue = (object) new Decimal(new int[4]
    {
      1316134911,
      2328,
      0,
      131072 /*0x020000*/
    });
    this.txtRate.MGAStyle = MGAStyles.Blue;
    this.txtRate.MinValue = (object) 0;
    ((Control) this.txtRate).Name = "txtRate";
    this.txtRate.Nullable = true;
    this.txtRate.NumericType = (NumericType) 2;
    ((Control) this.txtRate).Size = new Size(133, 20);
    ((Control) this.txtRate).TabIndex = 3;
    ((UltraControlBase) this.txtRate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRate).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(422, 21);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(37, 13);
    this.Label5.TabIndex = 209;
    this.Label5.Text = "State:";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(32 /*0x20*/, 44);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(78, 13);
    this.Label4.TabIndex = 207;
    this.Label4.Text = "Renumeration:";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(425, 44);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(34, 13);
    this.Label3.TabIndex = 206;
    this.Label3.Text = "Rate:";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(46, 85);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(64 /*0x40*/, 13);
    this.Label2.TabIndex = 203;
    this.Label2.Text = "Description:";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(46, 21);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(64 /*0x40*/, 13);
    this.Label1.TabIndex = 202;
    this.Label1.Text = "Class Code:";
    this.txtDescription.AcceptsReturn = true;
    this.txtDescription.AcceptsTab = true;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescription).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtDescription).BackColor = Color.White;
    ((Control) this.txtDescription).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericWCExposures.Description", true));
    ((Control) this.txtDescription).Location = new Point(116, 84);
    ((TextEditorControlBase) this.txtDescription).MaxLength = 2000;
    this.txtDescription.MGAStyle = MGAStyles.Blue;
    this.txtDescription.Multiline = true;
    ((Control) this.txtDescription).Name = "txtDescription";
    ((Control) this.txtDescription).Size = new Size(556, 60);
    ((Control) this.txtDescription).TabIndex = 4;
    ((UltraControlBase) this.txtDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescription).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkModifyLocations.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkModifyLocations.AutoSize = true;
    this.lnkModifyLocations.BackColor = Color.Transparent;
    this.lnkModifyLocations.Location = new Point(114, 170);
    this.lnkModifyLocations.Name = "lnkModifyLocations";
    this.lnkModifyLocations.Size = new Size(87, 13);
    this.lnkModifyLocations.TabIndex = 199;
    this.lnkModifyLocations.TabStop = true;
    this.lnkModifyLocations.Tag = (object) "keepAlive";
    this.lnkModifyLocations.Text = "Modify Locations";
    this.lnkModifyLocations.TextAlign = ContentAlignment.MiddleCenter;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(622, 157);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 5;
    this.dbSave.Tag = (object) "keepAlive";
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label9);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaTextBox11);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label8);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaTextBox10);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label7);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaTextBox9);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label6);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaTextBox8);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.btnSave);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label19);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaTextBox5);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label20);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaTextBox6);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label21);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaTextBox7);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label22);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaComboBox3);
    ((Control) this.UltraTabPageControl2).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(736, 98);
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(353, 78);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(83, 13);
    this.Label9.TabIndex = 226;
    this.Label9.Text = "# of Indemnity:";
    this.MgaTextBox11.AcceptsReturn = true;
    this.MgaTextBox11.AcceptsTab = true;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox11).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.MgaTextBox11).BackColor = Color.White;
    ((Control) this.MgaTextBox11).DataBindings.Add(new Binding("Text", (object) this.ds, "tblWCPolicyInfo.NoOfIndemnity", true));
    ((Control) this.MgaTextBox11).Location = new Point(446, 74);
    ((TextEditorControlBase) this.MgaTextBox11).MaxLength = 50;
    this.MgaTextBox11.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox11).Name = "MgaTextBox11";
    ((Control) this.MgaTextBox11).Size = new Size(226, 20);
    ((Control) this.MgaTextBox11).TabIndex = 225;
    ((UltraControlBase) this.MgaTextBox11).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox11).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(30, 77);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(70, 13);
    this.Label8.TabIndex = 224 /*0xE0*/;
    this.Label8.Text = "# of Medical:";
    this.Label8.TextAlign = ContentAlignment.TopRight;
    this.MgaTextBox10.AcceptsReturn = true;
    this.MgaTextBox10.AcceptsTab = true;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox10).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.MgaTextBox10).BackColor = Color.White;
    ((Control) this.MgaTextBox10).DataBindings.Add(new Binding("Text", (object) this.ds, "tblWCPolicyInfo.NoOfMedical", true));
    ((Control) this.MgaTextBox10).Location = new Point(109, 73);
    ((TextEditorControlBase) this.MgaTextBox10).MaxLength = 50;
    this.MgaTextBox10.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox10).Name = "MgaTextBox10";
    ((Control) this.MgaTextBox10).Size = new Size(232, 20);
    ((Control) this.MgaTextBox10).TabIndex = 223;
    ((UltraControlBase) this.MgaTextBox10).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox10).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(360, 55);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(76, 13);
    this.Label7.TabIndex = 222;
    this.Label7.Text = "Incurred Loss:";
    this.MgaTextBox9.AcceptsReturn = true;
    this.MgaTextBox9.AcceptsTab = true;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox9).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.MgaTextBox9).BackColor = Color.White;
    ((Control) this.MgaTextBox9).DataBindings.Add(new Binding("Text", (object) this.ds, "tblWCPolicyInfo.IncurredLoss", true));
    ((Control) this.MgaTextBox9).Location = new Point(446, 51);
    ((TextEditorControlBase) this.MgaTextBox9).MaxLength = 50;
    this.MgaTextBox9.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox9).Name = "MgaTextBox9";
    ((Control) this.MgaTextBox9).Size = new Size(226, 20);
    ((Control) this.MgaTextBox9).TabIndex = 221;
    ((UltraControlBase) this.MgaTextBox9).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox9).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(19, 54);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(83, 13);
    this.Label6.TabIndex = 220;
    this.Label6.Text = "Scheduled Mod:";
    this.Label6.TextAlign = ContentAlignment.TopRight;
    this.MgaTextBox8.AcceptsReturn = true;
    this.MgaTextBox8.AcceptsTab = true;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox8).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.MgaTextBox8).BackColor = Color.White;
    ((Control) this.MgaTextBox8).DataBindings.Add(new Binding("Text", (object) this.ds, "tblWCPolicyInfo.ScheduledMod", true));
    ((Control) this.MgaTextBox8).Location = new Point(109, 50);
    ((TextEditorControlBase) this.MgaTextBox8).MaxLength = 50;
    this.MgaTextBox8.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox8).Name = "MgaTextBox8";
    ((Control) this.MgaTextBox8).Size = new Size(232, 20);
    ((Control) this.MgaTextBox8).TabIndex = 219;
    ((UltraControlBase) this.MgaTextBox8).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox8).UseOsThemes = (DefaultableBoolean) 2;
    appearance8.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance24.Image"));
    appearance8.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance8;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(691, 51);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(42, 42);
    ((Control) this.btnSave).TabIndex = 4;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.Label19.AutoSize = true;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Location = new Point(352, 32 /*0x20*/);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(88, 13);
    this.Label19.TabIndex = 218;
    this.Label19.Text = "Schedule Rating:";
    this.MgaTextBox5.AcceptsReturn = true;
    this.MgaTextBox5.AcceptsTab = true;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox5).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.MgaTextBox5).BackColor = Color.White;
    ((Control) this.MgaTextBox5).DataBindings.Add(new Binding("Text", (object) this.ds, "tblWCPolicyInfo.ScheduleRating", true));
    ((Control) this.MgaTextBox5).Location = new Point(446, 28);
    ((TextEditorControlBase) this.MgaTextBox5).MaxLength = 50;
    this.MgaTextBox5.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox5).Name = "MgaTextBox5";
    ((Control) this.MgaTextBox5).Size = new Size(226, 20);
    ((Control) this.MgaTextBox5).TabIndex = 3;
    ((UltraControlBase) this.MgaTextBox5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox5).UseOsThemes = (DefaultableBoolean) 2;
    this.Label20.AutoSize = true;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(87, 13);
    this.Label20.TabIndex = 216;
    this.Label20.Text = "Experience Mod:";
    this.MgaTextBox6.AcceptsReturn = true;
    this.MgaTextBox6.AcceptsTab = true;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox6).Appearance = (AppearanceBase) appearance10;
    ((TextEditorControlBase) this.MgaTextBox6).BackColor = Color.White;
    ((Control) this.MgaTextBox6).DataBindings.Add(new Binding("Text", (object) this.ds, "tblWCPolicyInfo.ExperienceMod", true));
    ((Control) this.MgaTextBox6).Location = new Point(109, 28);
    ((TextEditorControlBase) this.MgaTextBox6).MaxLength = 50;
    this.MgaTextBox6.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox6).Name = "MgaTextBox6";
    ((Control) this.MgaTextBox6).Size = new Size(232, 20);
    ((Control) this.MgaTextBox6).TabIndex = 1;
    ((UltraControlBase) this.MgaTextBox6).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox6).UseOsThemes = (DefaultableBoolean) 2;
    this.Label21.AutoSize = true;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Location = new Point(379, 8);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(61, 13);
    this.Label21.TabIndex = 214;
    this.Label21.Text = "Deductible:";
    this.MgaTextBox7.AcceptsReturn = true;
    this.MgaTextBox7.AcceptsTab = true;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox7).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.MgaTextBox7).BackColor = Color.White;
    ((Control) this.MgaTextBox7).DataBindings.Add(new Binding("Text", (object) this.ds, "tblWCPolicyInfo.Deductible", true));
    ((Control) this.MgaTextBox7).Location = new Point(446, 5);
    ((TextEditorControlBase) this.MgaTextBox7).MaxLength = 50;
    this.MgaTextBox7.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox7).Name = "MgaTextBox7";
    ((Control) this.MgaTextBox7).Size = new Size(226, 20);
    ((Control) this.MgaTextBox7).TabIndex = 2;
    ((UltraControlBase) this.MgaTextBox7).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox7).UseOsThemes = (DefaultableBoolean) 2;
    this.Label22.AutoSize = true;
    this.Label22.BackColor = Color.Transparent;
    this.Label22.Location = new Point(66, 9);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(37, 13);
    this.Label22.TabIndex = 212;
    this.Label22.Text = "Limits:";
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.cn.ConnectionString = "packet size=7168;user id=ims_align;data source=209.112.251.227;persist security info=True;initial catalog=MEJames;password=20aLi12Gn!";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[11]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      new SqlParameter("@Description", SqlDbType.VarChar, 2000, "Description"),
      new SqlParameter("@Rate", SqlDbType.Money, 8, "Rate"),
      new SqlParameter("@Renumeration", SqlDbType.Money, 8, "Renumeration"),
      new SqlParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      new SqlParameter("@LocationID", SqlDbType.Int, 4, "LocationID"),
      new SqlParameter("@ClassCodeID", SqlDbType.Int, 4, "ClassCodeID"),
      new SqlParameter("@ClassCode", SqlDbType.VarChar, 5, "ClassCode"),
      new SqlParameter("@EffectiveRateOfClass", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "EffectiveRateOfClass", DataRowVersion.Current, (object) null),
      new SqlParameter("@NoOfEmployees", SqlDbType.Int, 4, "NoOfEmployees"),
      new SqlParameter("@ExpectedIndemnityClaims", SqlDbType.Int, 4, "ExpectedIndemnityClaims")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[13]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      new SqlParameter("@Description", SqlDbType.VarChar, 2000, "Description"),
      new SqlParameter("@Rate", SqlDbType.Money, 8, "Rate"),
      new SqlParameter("@Renumeration", SqlDbType.Money, 8, "Renumeration"),
      new SqlParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      new SqlParameter("@LocationID", SqlDbType.Int, 4, "LocationID"),
      new SqlParameter("@ClassCode", SqlDbType.VarChar, 5, "ClassCode"),
      new SqlParameter("@ClassCodeID", SqlDbType.Int, 4, "ClassCodeID"),
      new SqlParameter("@EffectiveRateOfClass", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "EffectiveRateOfClass", DataRowVersion.Current, (object) null),
      new SqlParameter("@NoOfEmployees", SqlDbType.Int, 4, "NoOfEmployees"),
      new SqlParameter("@ExpectedIndemnityClaims", SqlDbType.Int, 4, "ExpectedIndemnityClaims"),
      new SqlParameter("@Original_WorkCompID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "WorkCompID", DataRowVersion.Original, (object) null),
      new SqlParameter("@WorkCompID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "WorkCompID", DataRowVersion.Original, (object) null)
    });
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblGenericWCExposures] WHERE (([WorkCompID] = @Original_WorkCompID))";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_WorkCompID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "WorkCompID", DataRowVersion.Original, (object) null)
    });
    this.daExposure.DeleteCommand = this.SqlDeleteCommand1;
    this.daExposure.InsertCommand = this.SqlInsertCommand1;
    this.daExposure.SelectCommand = this.SqlSelectCommand1;
    this.daExposure.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblGenericWCExposures", new DataColumnMapping[11]
      {
        new DataColumnMapping("WorkCompID", "WorkCompID"),
        new DataColumnMapping("QuoteID", "QuoteID"),
        new DataColumnMapping("ClassCode", "ClassCode"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("Rate", "Rate"),
        new DataColumnMapping("Renumeration", "Renumeration"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("LocationID", "LocationID"),
        new DataColumnMapping("EffectiveRateOfClass", "EffectiveRateOfClass"),
        new DataColumnMapping("NoOfEmployees", "NoOfEmployees"),
        new DataColumnMapping("ExpectedIndemnityClaims", "ExpectedIndemnityClaims")
      })
    });
    this.daExposure.UpdateCommand = this.SqlUpdateCommand1;
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraTabControl1).Location = new Point(0, 0);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(200, 100);
    ((Control) this.UltraTabControl1).TabIndex = 0;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(1, 20);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(196, 77);
    ((Control) this.UltraTabControl2).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraTabControl2).Location = new Point(0, 0);
    ((Control) this.UltraTabControl2).Name = "UltraTabControl2";
    ((UltraTabControlBase) this.UltraTabControl2).SharedControlsPage = this.UltraTabSharedControlsPage2;
    ((Control) this.UltraTabControl2).Size = new Size(200, 100);
    ((Control) this.UltraTabControl2).TabIndex = 0;
    ((Control) this.UltraTabSharedControlsPage2).Location = new Point(1, 20);
    ((Control) this.UltraTabSharedControlsPage2).Name = "UltraTabSharedControlsPage2";
    ((Control) this.UltraTabSharedControlsPage2).Size = new Size(196, 77);
    ((Control) this.UltraTabControl3).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraTabControl3).Location = new Point(0, 0);
    ((Control) this.UltraTabControl3).Name = "UltraTabControl3";
    ((UltraTabControlBase) this.UltraTabControl3).SharedControlsPage = this.UltraTabSharedControlsPage3;
    ((Control) this.UltraTabControl3).Size = new Size(200, 100);
    ((Control) this.UltraTabControl3).TabIndex = 0;
    ((Control) this.UltraTabSharedControlsPage3).Location = new Point(1, 20);
    ((Control) this.UltraTabSharedControlsPage3).Name = "UltraTabSharedControlsPage3";
    ((Control) this.UltraTabSharedControlsPage3).Size = new Size(196, 77);
    ((Control) this.UltraTabControl4).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraTabControl4).Controls.Add((Control) this.UltraTabSharedControlsPage4);
    ((Control) this.UltraTabControl4).Controls.Add((Control) this.tabExposure);
    ((Control) this.UltraTabControl4).Location = new Point(12, 356);
    ((Control) this.UltraTabControl4).Name = "UltraTabControl4";
    ((UltraTabControlBase) this.UltraTabControl4).SharedControlsPage = this.UltraTabSharedControlsPage4;
    ((Control) this.UltraTabControl4).Size = new Size(738, 226);
    ((Control) this.UltraTabControl4).TabIndex = 203;
    ((UltraTabControlBase) this.UltraTabControl4).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.UltraTabControl4).TabPadding = new Size(5, 3);
    appearance12.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance42.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance12;
    ultraTab1.TabPage = this.tabExposure;
    ultraTab1.Text = "Exposure Information";
    ((UltraTabControlBase) this.UltraTabControl4).Tabs.AddRange(new UltraTab[1]
    {
      ultraTab1
    });
    ((UltraTabControlBase) this.UltraTabControl4).TabSize = new Size(180, 0);
    ((UltraTabControlBase) this.UltraTabControl4).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage4).Name = "UltraTabSharedControlsPage4";
    ((Control) this.UltraTabSharedControlsPage4).Size = new Size(736, 199);
    this.err.ContainerControl = (ContainerControl) this;
    this.daLocations.DeleteCommand = this.SqlDeleteCommand;
    this.daLocations.SelectCommand = this.SqlCommand1;
    this.daLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUnderwritingLocations", new DataColumnMapping[9]
      {
        new DataColumnMapping("LocationID", "LocationID"),
        new DataColumnMapping("LocationNo", "LocationNo"),
        new DataColumnMapping("BuildingNo", "BuildingNo"),
        new DataColumnMapping("PhysicalBuildingNo", "PhysicalBuildingNo"),
        new DataColumnMapping("Address", "Address"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("Zip", "Zip"),
        new DataColumnMapping("ModificationCode", "ModificationCode")
      })
    });
    this.daLocations.UpdateCommand = this.SqlUpdateCommand;
    this.SqlDeleteCommand.Connection = this.cn;
    this.SqlCommand1.CommandText = componentResourceManager.GetString("SqlCommand1.CommandText");
    this.SqlCommand1.Connection = this.cn;
    this.SqlCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid")
    });
    this.SqlUpdateCommand.CommandText = componentResourceManager.GetString("SqlUpdateCommand.CommandText");
    this.SqlUpdateCommand.Connection = this.cn;
    this.SqlUpdateCommand.Parameters.AddRange(new SqlParameter[9]
    {
      new SqlParameter("@LocationNo", SqlDbType.Int, 0, "LocationNo"),
      new SqlParameter("@BuildingNo", SqlDbType.VarChar, 0, "BuildingNo"),
      new SqlParameter("@PhysicalBuildingNo", SqlDbType.VarChar, 0, "PhysicalBuildingNo"),
      new SqlParameter("@City", SqlDbType.VarChar, 0, "City"),
      new SqlParameter("@State", SqlDbType.Char, 0, "State"),
      new SqlParameter("@Zip", SqlDbType.Char, 0, "Zip"),
      new SqlParameter("@ModificationCode", SqlDbType.Char, 0, "ModificationCode"),
      new SqlParameter("@Original_LocationID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LocationID", DataRowVersion.Original, (object) null),
      new SqlParameter("@LocationID", SqlDbType.Int, 4, "LocationID")
    });
    ((Control) this.UltraTabSharedControlsPage5).Location = new Point(1, 26);
    ((Control) this.UltraTabSharedControlsPage5).Name = "UltraTabSharedControlsPage5";
    ((Control) this.UltraTabSharedControlsPage5).Size = new Size(670, 279);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaNumericEditor1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaNumericEditor2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label10);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTextBox1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label11);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTextBox2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label12);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTextBox3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label13);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaComboBox1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaComboBox2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label14);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaSimpleComboBox1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label15);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label16);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label17);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label18);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTextBox4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.LinkLabel1);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(670, 279);
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor1).Appearance = (AppearanceBase) appearance13;
    ((Control) this.MgaNumericEditor1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericWCExposures.Renumeration", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor1).FormatString = "c";
    ((Control) this.MgaNumericEditor1).Location = new Point(116, 89);
    this.MgaNumericEditor1.MaxValue = (object) 999999999;
    this.MgaNumericEditor1.MGAStyle = MGAStyles.Blue;
    this.MgaNumericEditor1.MinValue = (object) 0;
    ((Control) this.MgaNumericEditor1).Name = "MgaNumericEditor1";
    this.MgaNumericEditor1.Nullable = true;
    ((Control) this.MgaNumericEditor1).Size = new Size(207, 19);
    ((Control) this.MgaNumericEditor1).TabIndex = 2;
    ((UltraControlBase) this.MgaNumericEditor1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor1).UseOsThemes = (DefaultableBoolean) 2;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor2).Appearance = (AppearanceBase) appearance14;
    ((Control) this.MgaNumericEditor2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericWCExposures.Rate", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor2).FormatString = "c";
    ((Control) this.MgaNumericEditor2).Location = new Point(429, 53);
    this.MgaNumericEditor2.MaxValue = (object) 999999999;
    this.MgaNumericEditor2.MGAStyle = MGAStyles.Blue;
    this.MgaNumericEditor2.MinValue = (object) 0;
    ((Control) this.MgaNumericEditor2).Name = "MgaNumericEditor2";
    this.MgaNumericEditor2.Nullable = true;
    ((Control) this.MgaNumericEditor2).Size = new Size(207, 19);
    ((Control) this.MgaNumericEditor2).TabIndex = 5;
    ((UltraControlBase) this.MgaNumericEditor2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor2).UseOsThemes = (DefaultableBoolean) 2;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(335, 128 /*0x80*/);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(89, 13);
    this.Label10.TabIndex = 218;
    this.Label10.Text = "Schedule Rating:";
    this.MgaTextBox1.AcceptsReturn = true;
    this.MgaTextBox1.AcceptsTab = true;
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox1).Appearance = (AppearanceBase) appearance15;
    ((TextEditorControlBase) this.MgaTextBox1).BackColor = Color.White;
    ((Control) this.MgaTextBox1).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericWCExposures.ScheduleRating", true));
    ((Control) this.MgaTextBox1).Location = new Point(429, 124);
    ((TextEditorControlBase) this.MgaTextBox1).MaxLength = 2000;
    this.MgaTextBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox1).Name = "MgaTextBox1";
    ((Control) this.MgaTextBox1).Size = new Size(207, 19);
    ((Control) this.MgaTextBox1).TabIndex = 7;
    ((UltraControlBase) this.MgaTextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(23, 128 /*0x80*/);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(87, 13);
    this.Label11.TabIndex = 216;
    this.Label11.Text = "Experience Mod:";
    this.MgaTextBox2.AcceptsReturn = true;
    this.MgaTextBox2.AcceptsTab = true;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox2).Appearance = (AppearanceBase) appearance16;
    ((TextEditorControlBase) this.MgaTextBox2).BackColor = Color.White;
    ((Control) this.MgaTextBox2).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericWCExposures.ExperienceMod", true));
    ((Control) this.MgaTextBox2).Location = new Point(116, 124);
    ((TextEditorControlBase) this.MgaTextBox2).MaxLength = 2000;
    this.MgaTextBox2.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox2).Name = "MgaTextBox2";
    ((Control) this.MgaTextBox2).Size = new Size(207, 19);
    ((Control) this.MgaTextBox2).TabIndex = 3;
    ((UltraControlBase) this.MgaTextBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox2).UseOsThemes = (DefaultableBoolean) 2;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(362, 93);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(61, 13);
    this.Label12.TabIndex = 214;
    this.Label12.Text = "Deductible:";
    this.MgaTextBox3.AcceptsReturn = true;
    this.MgaTextBox3.AcceptsTab = true;
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox3).Appearance = (AppearanceBase) appearance17;
    ((TextEditorControlBase) this.MgaTextBox3).BackColor = Color.White;
    ((Control) this.MgaTextBox3).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericWCExposures.Deductible", true));
    ((Control) this.MgaTextBox3).Location = new Point(429, 89);
    ((TextEditorControlBase) this.MgaTextBox3).MaxLength = 2000;
    this.MgaTextBox3.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox3).Name = "MgaTextBox3";
    ((Control) this.MgaTextBox3).Size = new Size(207, 19);
    ((Control) this.MgaTextBox3).TabIndex = 6;
    ((UltraControlBase) this.MgaTextBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox3).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(73, 57);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(36, 13);
    this.Label13.TabIndex = 212;
    this.Label13.Text = "Limits:";
    this.Label14.AutoSize = true;
    this.Label14.Location = new Point(386, 21);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(35, 13);
    this.Label14.TabIndex = 209;
    this.Label14.Text = "State:";
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(32 /*0x20*/, 93);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(76, 13);
    this.Label15.TabIndex = 207;
    this.Label15.Text = "Renumeration:";
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(389, 57);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(33, 13);
    this.Label16.TabIndex = 206;
    this.Label16.Text = "Rate:";
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(46, 159);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(63 /*0x3F*/, 13);
    this.Label17.TabIndex = 203;
    this.Label17.Text = "Description:";
    this.Label18.AutoSize = true;
    this.Label18.Location = new Point(46, 21);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(63 /*0x3F*/, 13);
    this.Label18.TabIndex = 202;
    this.Label18.Text = "Class Code:";
    this.MgaTextBox4.AcceptsReturn = true;
    this.MgaTextBox4.AcceptsTab = true;
    appearance18.BackColor = Color.White;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance18.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox4).Appearance = (AppearanceBase) appearance18;
    ((TextEditorControlBase) this.MgaTextBox4).BackColor = Color.White;
    ((Control) this.MgaTextBox4).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericWCExposures.Description", true));
    ((Control) this.MgaTextBox4).Location = new Point(116, 159);
    ((TextEditorControlBase) this.MgaTextBox4).MaxLength = 2000;
    this.MgaTextBox4.MGAStyle = MGAStyles.Blue;
    this.MgaTextBox4.Multiline = true;
    ((Control) this.MgaTextBox4).Name = "MgaTextBox4";
    ((Control) this.MgaTextBox4).Size = new Size(520, 67);
    ((Control) this.MgaTextBox4).TabIndex = 8;
    ((UltraControlBase) this.MgaTextBox4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox4).UseOsThemes = (DefaultableBoolean) 2;
    this.LinkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.LinkLabel1.AutoSize = true;
    this.LinkLabel1.BackColor = Color.Transparent;
    this.LinkLabel1.Location = new Point(113, 251);
    this.LinkLabel1.Name = "LinkLabel1";
    this.LinkLabel1.Size = new Size(87, 13);
    this.LinkLabel1.TabIndex = 199;
    this.LinkLabel1.TabStop = true;
    this.LinkLabel1.Tag = (object) "keepAlive";
    this.LinkLabel1.Text = "Modify Locations";
    this.LinkLabel1.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.UltraTabControl5).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraTabControl5).Controls.Add((Control) this.UltraTabSharedControlsPage6);
    ((Control) this.UltraTabControl5).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl5).Location = new Point(12, 8);
    ((Control) this.UltraTabControl5).Name = "UltraTabControl5";
    ((UltraTabControlBase) this.UltraTabControl5).SharedControlsPage = this.UltraTabSharedControlsPage6;
    ((Control) this.UltraTabControl5).Size = new Size(738, 125);
    ((Control) this.UltraTabControl5).TabIndex = 204;
    ((UltraTabControlBase) this.UltraTabControl5).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.UltraTabControl5).TabPadding = new Size(5, 3);
    appearance19.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance43.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance19;
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "WC Policy Information ";
    ((UltraTabControlBase) this.UltraTabControl5).Tabs.AddRange(new UltraTab[1]
    {
      ultraTab2
    });
    ((UltraTabControlBase) this.UltraTabControl5).TabSize = new Size(180, 0);
    ((UltraTabControlBase) this.UltraTabControl5).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage6).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage6).Name = "UltraTabSharedControlsPage6";
    ((Control) this.UltraTabSharedControlsPage6).Size = new Size(736, 98);
    this.daPol.DeleteCommand = this.SqlCommand2;
    this.daPol.InsertCommand = this.SqlCommand3;
    this.daPol.SelectCommand = this.SqlCommand4;
    this.daPol.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblWCPolicyInfo", new DataColumnMapping[9]
      {
        new DataColumnMapping("QuoteID", "QuoteID"),
        new DataColumnMapping("Deductible", "Deductible"),
        new DataColumnMapping("ExperienceMod", "ExperienceMod"),
        new DataColumnMapping("ScheduleRating", "ScheduleRating"),
        new DataColumnMapping("WCLimit", "WCLimit"),
        new DataColumnMapping("ScheduledMod", "ScheduledMod"),
        new DataColumnMapping("IncurredLoss", "IncurredLoss"),
        new DataColumnMapping("NoOfMedical", "NoOfMedical"),
        new DataColumnMapping("NoOfIndemnity", "NoOfIndemnity")
      })
    });
    this.daPol.UpdateCommand = this.SqlCommand5;
    this.SqlCommand2.CommandText = "DELETE FROM [dbo].[tblWCPolicyInfo] WHERE (([QuoteID] = @Original_QuoteID))";
    this.SqlCommand2.Connection = this.cn;
    this.SqlCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_QuoteID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteID", DataRowVersion.Original, (object) null)
    });
    this.SqlCommand3.CommandText = componentResourceManager.GetString("SqlCommand3.CommandText");
    this.SqlCommand3.Connection = this.cn;
    this.SqlCommand3.Parameters.AddRange(new SqlParameter[9]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      new SqlParameter("@Deductible", SqlDbType.VarChar, 50, "Deductible"),
      new SqlParameter("@ExperienceMod", SqlDbType.VarChar, 50, "ExperienceMod"),
      new SqlParameter("@ScheduleRating", SqlDbType.VarChar, 50, "ScheduleRating"),
      new SqlParameter("@WCLimit", SqlDbType.VarChar, 100, "WCLimit"),
      new SqlParameter("@ScheduledMod", SqlDbType.VarChar, 50, "ScheduledMod"),
      new SqlParameter("@IncurredLoss", SqlDbType.VarChar, 50, "IncurredLoss"),
      new SqlParameter("@NoOfMedical", SqlDbType.VarChar, 50, "NoOfMedical"),
      new SqlParameter("@NoOfIndemnity", SqlDbType.VarChar, 50, "NoOfIndemnity")
    });
    this.SqlCommand4.CommandText = "SELECT        QuoteID, Deductible, ExperienceMod, ScheduleRating, WCLimit, ScheduledMod, IncurredLoss, NoOfMedical, NoOfIndemnity\r\nFROM            tblWCPolicyInfo\r\nWHERE        (QuoteID = @QuoteID)";
    this.SqlCommand4.Connection = this.cn;
    this.SqlCommand4.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.SqlCommand5.CommandText = componentResourceManager.GetString("SqlCommand5.CommandText");
    this.SqlCommand5.Connection = this.cn;
    this.SqlCommand5.Parameters.AddRange(new SqlParameter[10]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      new SqlParameter("@Deductible", SqlDbType.VarChar, 50, "Deductible"),
      new SqlParameter("@ExperienceMod", SqlDbType.VarChar, 50, "ExperienceMod"),
      new SqlParameter("@ScheduleRating", SqlDbType.VarChar, 50, "ScheduleRating"),
      new SqlParameter("@WCLimit", SqlDbType.VarChar, 100, "WCLimit"),
      new SqlParameter("@ScheduledMod", SqlDbType.VarChar, 50, "ScheduledMod"),
      new SqlParameter("@IncurredLoss", SqlDbType.VarChar, 50, "IncurredLoss"),
      new SqlParameter("@NoOfMedical", SqlDbType.VarChar, 50, "NoOfMedical"),
      new SqlParameter("@NoOfIndemnity", SqlDbType.VarChar, 50, "NoOfIndemnity"),
      new SqlParameter("@Original_QuoteID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteID", DataRowVersion.Original, (object) null)
    });
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor3).Appearance = (AppearanceBase) appearance20;
    ((Control) this.MgaNumericEditor3).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericWCExposures.NoOfEmployees", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor3).FormatString = "c";
    ((Control) this.MgaNumericEditor3).Location = new Point(116, 61);
    this.MgaNumericEditor3.MaxValue = (object) new Decimal(new int[4]
    {
      1316134911,
      2328,
      0,
      131072 /*0x020000*/
    });
    this.MgaNumericEditor3.MGAStyle = MGAStyles.Blue;
    this.MgaNumericEditor3.MinValue = (object) 0;
    ((Control) this.MgaNumericEditor3).Name = "MgaNumericEditor3";
    this.MgaNumericEditor3.Nullable = true;
    ((Control) this.MgaNumericEditor3).Size = new Size(133, 20);
    ((Control) this.MgaNumericEditor3).TabIndex = 210;
    ((UltraControlBase) this.MgaNumericEditor3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor3).UseOsThemes = (DefaultableBoolean) 2;
    this.Label23.AutoSize = true;
    this.Label23.BackColor = Color.Transparent;
    this.Label23.Location = new Point(-5, 65);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(114, 13);
    this.Label23.TabIndex = 211;
    this.Label23.Text = "# full-time employees:";
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor4).Appearance = (AppearanceBase) appearance21;
    ((Control) this.MgaNumericEditor4).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericWCExposures.ExpectedIndemnityClaims", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor4).FormatString = "c";
    ((Control) this.MgaNumericEditor4).Location = new Point(465, 61);
    this.MgaNumericEditor4.MaxValue = (object) new Decimal(new int[4]
    {
      1316134911,
      2328,
      0,
      131072 /*0x020000*/
    });
    this.MgaNumericEditor4.MGAStyle = MGAStyles.Blue;
    this.MgaNumericEditor4.MinValue = (object) 0;
    ((Control) this.MgaNumericEditor4).Name = "MgaNumericEditor4";
    this.MgaNumericEditor4.Nullable = true;
    ((Control) this.MgaNumericEditor4).Size = new Size(133, 20);
    ((Control) this.MgaNumericEditor4).TabIndex = 212;
    ((UltraControlBase) this.MgaNumericEditor4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor4).UseOsThemes = (DefaultableBoolean) 2;
    this.Label24.AutoSize = true;
    this.Label24.BackColor = Color.Transparent;
    this.Label24.Location = new Point(319, 65);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(140, 13);
    this.Label24.TabIndex = 213;
    this.Label24.Text = "Expected Indemnity Claims:";
    this.ds.DataSetName = "dsWCExposureCapture";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.MgaComboBox3.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MgaComboBox3).DataBindings.Add(new Binding("Value", (object) this.ds, "tblWCPolicyInfo.WCLimit", true));
    ((UltraGridBase) this.MgaComboBox3).DataMember = "lstWCLimits";
    ((UltraGridBase) this.MgaComboBox3).DataSource = (object) this.ds;
    appearance22.BackColor = Color.White;
    appearance22.BorderColor = Color.FromArgb(78, 122, 171);
    this.MgaComboBox3.DisplayLayout.Appearance = (AppearanceBase) appearance22;
    this.MgaComboBox3.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 101;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 201;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    this.MgaComboBox3.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.MgaComboBox3.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.MgaComboBox3.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance23.BackColor = SystemColors.ActiveBorder;
    appearance23.BackColor2 = SystemColors.ControlDark;
    appearance23.BackGradientStyle = (GradientStyle) 2;
    appearance23.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.MgaComboBox3.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance23;
    appearance24.ForeColor = SystemColors.GrayText;
    this.MgaComboBox3.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance24;
    ((SpecialBoxBase) this.MgaComboBox3.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance25.BackColor = SystemColors.ControlLightLight;
    appearance25.BackColor2 = SystemColors.Control;
    appearance25.BackGradientStyle = (GradientStyle) 3;
    appearance25.ForeColor = SystemColors.GrayText;
    this.MgaComboBox3.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance25;
    this.MgaComboBox3.DisplayLayout.MaxColScrollRegions = 1;
    this.MgaComboBox3.DisplayLayout.MaxRowScrollRegions = 1;
    appearance26.BackColor = SystemColors.Window;
    appearance26.ForeColor = SystemColors.ControlText;
    this.MgaComboBox3.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance26;
    appearance27.BackColor = SystemColors.Highlight;
    appearance27.ForeColor = SystemColors.HighlightText;
    this.MgaComboBox3.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance27;
    this.MgaComboBox3.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.MgaComboBox3.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance28.BackColor = SystemColors.Window;
    this.MgaComboBox3.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance28;
    appearance29.BorderColor = Color.Silver;
    appearance29.TextTrimming = (TextTrimming) 3;
    this.MgaComboBox3.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance29;
    this.MgaComboBox3.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.MgaComboBox3.DisplayLayout.Override.CellPadding = 0;
    appearance30.BackColor = SystemColors.Control;
    appearance30.BackColor2 = SystemColors.ControlDark;
    appearance30.BackGradientAlignment = (GradientAlignment) 1;
    appearance30.BackGradientStyle = (GradientStyle) 3;
    appearance30.BorderColor = SystemColors.Window;
    this.MgaComboBox3.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).TextHAlignAsString = "Left";
    this.MgaComboBox3.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance31;
    this.MgaComboBox3.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.MgaComboBox3.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance32.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance32.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.MgaComboBox3.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance32;
    appearance33.BackColor = SystemColors.Window;
    appearance33.BorderColor = Color.White;
    this.MgaComboBox3.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance33;
    this.MgaComboBox3.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.MgaComboBox3.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance34.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance34.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance34.ForeColor = Color.Black;
    this.MgaComboBox3.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance34;
    appearance35.BackColor = SystemColors.ControlLight;
    this.MgaComboBox3.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance35;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.MgaComboBox3.DisplayLayout.ScrollBarLook = scrollBarLook1;
    this.MgaComboBox3.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.MgaComboBox3.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.MgaComboBox3.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.MgaComboBox3).DisplayMember = "WCLimits";
    this.MgaComboBox3.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.MgaComboBox3).DropDownWidth = 220;
    ((Control) this.MgaComboBox3).Location = new Point(109, 5);
    this.MgaComboBox3.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaComboBox3).Name = "MgaComboBox3";
    ((Control) this.MgaComboBox3).Size = new Size(232, 21);
    ((Control) this.MgaComboBox3).TabIndex = 0;
    ((UltraControlBase) this.MgaComboBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaComboBox3).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaComboBox3).ValueMember = "WCLimits";
    this.cboClassCodes.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboClassCodes).DataMember = "lstClassCodes";
    ((UltraGridBase) this.cboClassCodes).DataSource = (object) this.ds;
    appearance36.BackColor = Color.White;
    appearance36.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboClassCodes.DisplayLayout.Appearance = (AppearanceBase) appearance36;
    this.cboClassCodes.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Width = 64 /*0x40*/;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Description";
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 216;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 70;
    ultraGridColumn6.Header.VisiblePosition = 3;
    ultraGridColumn6.Width = 76;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    this.cboClassCodes.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboClassCodes.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboClassCodes.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance37.BackColor = SystemColors.ActiveBorder;
    appearance37.BackColor2 = SystemColors.ControlDark;
    appearance37.BackGradientStyle = (GradientStyle) 2;
    appearance37.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboClassCodes.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance37;
    appearance38.ForeColor = SystemColors.GrayText;
    this.cboClassCodes.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance38;
    ((SpecialBoxBase) this.cboClassCodes.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance39.BackColor = SystemColors.ControlLightLight;
    appearance39.BackColor2 = SystemColors.Control;
    appearance39.BackGradientStyle = (GradientStyle) 3;
    appearance39.ForeColor = SystemColors.GrayText;
    this.cboClassCodes.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance39;
    this.cboClassCodes.DisplayLayout.MaxColScrollRegions = 1;
    this.cboClassCodes.DisplayLayout.MaxRowScrollRegions = 1;
    appearance40.BackColor = SystemColors.Window;
    appearance40.ForeColor = SystemColors.ControlText;
    this.cboClassCodes.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance40;
    appearance41.BackColor = SystemColors.Highlight;
    appearance41.ForeColor = SystemColors.HighlightText;
    this.cboClassCodes.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance41;
    this.cboClassCodes.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboClassCodes.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance42.BackColor = SystemColors.Window;
    this.cboClassCodes.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance42;
    appearance43.BorderColor = Color.Silver;
    appearance43.TextTrimming = (TextTrimming) 3;
    this.cboClassCodes.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance43;
    this.cboClassCodes.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboClassCodes.DisplayLayout.Override.CellPadding = 0;
    appearance44.BackColor = SystemColors.Control;
    appearance44.BackColor2 = SystemColors.ControlDark;
    appearance44.BackGradientAlignment = (GradientAlignment) 1;
    appearance44.BackGradientStyle = (GradientStyle) 3;
    appearance44.BorderColor = SystemColors.Window;
    this.cboClassCodes.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance44;
    ((AppearanceBase) appearance45).TextHAlignAsString = "Left";
    this.cboClassCodes.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance45;
    this.cboClassCodes.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboClassCodes.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance46.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance46.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboClassCodes.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance46;
    appearance47.BackColor = SystemColors.Window;
    appearance47.BorderColor = Color.White;
    this.cboClassCodes.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance47;
    this.cboClassCodes.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboClassCodes.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance48.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance48.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance48.ForeColor = Color.Black;
    this.cboClassCodes.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance48;
    appearance49.BackColor = SystemColors.ControlLight;
    this.cboClassCodes.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance49;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboClassCodes.DisplayLayout.ScrollBarLook = scrollBarLook2;
    this.cboClassCodes.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboClassCodes.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboClassCodes.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboClassCodes).DisplayMember = "ClassCodeDescription";
    this.cboClassCodes.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboClassCodes).DropDownWidth = 375;
    ((Control) this.cboClassCodes).Location = new Point(116, 17);
    this.cboClassCodes.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboClassCodes).Name = "cboClassCodes";
    ((Control) this.cboClassCodes).Size = new Size(286, 21);
    ((Control) this.cboClassCodes).TabIndex = 0;
    ((UltraControlBase) this.cboClassCodes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboClassCodes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboClassCodes).ValueMember = "ClassCodeKey";
    this.cboState.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboState).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericWCExposures.StateID", true));
    ((UltraGridBase) this.cboState).DataMember = "lstStates";
    ((UltraGridBase) this.cboState).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboState).DropDownWidth = 300;
    ((Control) this.cboState).Location = new Point(465, 17);
    this.cboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(207, 21);
    ((Control) this.cboState).TabIndex = 2;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    ((Control) this.dgLocations).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgLocations).DataMember = "tblUnderwritingLocations";
    ((UltraGridBase) this.dgLocations).DataSource = (object) this.ds;
    appearance50.BackColor = Color.White;
    appearance50.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgLocations).DisplayLayout.Appearance = (AppearanceBase) appearance50;
    ((UltraGridBase) this.dgLocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 44;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Location #";
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn8.Width = 64 /*0x40*/;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Building #";
    ultraGridColumn9.Header.VisiblePosition = 2;
    ultraGridColumn9.Width = 90;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Physical Building #";
    ultraGridColumn10.Header.VisiblePosition = 3;
    ultraGridColumn10.Width = 101;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.Header.VisiblePosition = 4;
    ultraGridColumn11.Width = 177;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.Header.VisiblePosition = 5;
    ultraGridColumn12.Width = 89;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.Header.VisiblePosition = 6;
    ultraGridColumn13.Width = 40;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.Header.VisiblePosition = 7;
    ultraGridColumn14.Width = 85;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Mod... Code";
    ultraGridColumn15.Header.VisiblePosition = 8;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 87;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "NetRate";
    ultraGridColumn16.Header.VisiblePosition = 9;
    ultraGridColumn16.Width = 71;
    ultraGridBand3.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ultraGridBand3.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dgLocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance51.BackColor = Color.LightSteelBlue;
    appearance51.FontData.SizeInPoints = 10f;
    appearance51.ForeColor = Color.Black;
    ((UltraGridBase) this.dgLocations).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance51;
    appearance52.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance52.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance52.ForeColor = Color.Black;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance52;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance53.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance53;
    appearance54.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance54;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance55.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance55;
    appearance56.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance56;
    appearance57.BackColor = Color.Transparent;
    appearance57.ForeColor = Color.Black;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance57;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgLocations).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((Control) this.dgLocations).Location = new Point(12, 139);
    ((Control) this.dgLocations).Name = "dgLocations";
    ((Control) this.dgLocations).Size = new Size(738, 211);
    ((Control) this.dgLocations).TabIndex = 198;
    ((Control) this.dgLocations).Text = "Locations on this Policy";
    ((UltraControlBase) this.dgLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgLocations).UseOsThemes = (DefaultableBoolean) 2;
    this.MgaComboBox1.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MgaComboBox1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericWCExposures.WCLimitID", true));
    ((UltraGridBase) this.MgaComboBox1).DataMember = "lstWCLimits";
    ((UltraGridBase) this.MgaComboBox1).DataSource = (object) this.ds;
    appearance58.BackColor = Color.White;
    appearance58.BorderColor = Color.FromArgb(78, 122, 171);
    this.MgaComboBox1.DisplayLayout.Appearance = (AppearanceBase) appearance58;
    this.MgaComboBox1.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand4.ColHeadersVisible = false;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn17.Header.VisiblePosition = 0;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 101;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn18.Header.VisiblePosition = 1;
    ultraGridColumn18.Width = 181;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn17,
      (object) ultraGridColumn18
    });
    this.MgaComboBox1.DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    this.MgaComboBox1.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.MgaComboBox1.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance59.BackColor = SystemColors.ActiveBorder;
    appearance59.BackColor2 = SystemColors.ControlDark;
    appearance59.BackGradientStyle = (GradientStyle) 2;
    appearance59.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.MgaComboBox1.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance59;
    appearance60.ForeColor = SystemColors.GrayText;
    this.MgaComboBox1.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance60;
    ((SpecialBoxBase) this.MgaComboBox1.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance61.BackColor = SystemColors.ControlLightLight;
    appearance61.BackColor2 = SystemColors.Control;
    appearance61.BackGradientStyle = (GradientStyle) 3;
    appearance61.ForeColor = SystemColors.GrayText;
    this.MgaComboBox1.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance61;
    this.MgaComboBox1.DisplayLayout.MaxColScrollRegions = 1;
    this.MgaComboBox1.DisplayLayout.MaxRowScrollRegions = 1;
    appearance62.BackColor = SystemColors.Window;
    appearance62.ForeColor = SystemColors.ControlText;
    this.MgaComboBox1.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance62;
    appearance63.BackColor = SystemColors.Highlight;
    appearance63.ForeColor = SystemColors.HighlightText;
    this.MgaComboBox1.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance63;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance64.BackColor = SystemColors.Window;
    this.MgaComboBox1.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance64;
    appearance65.BorderColor = Color.Silver;
    appearance65.TextTrimming = (TextTrimming) 3;
    this.MgaComboBox1.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance65;
    this.MgaComboBox1.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.MgaComboBox1.DisplayLayout.Override.CellPadding = 0;
    appearance66.BackColor = SystemColors.Control;
    appearance66.BackColor2 = SystemColors.ControlDark;
    appearance66.BackGradientAlignment = (GradientAlignment) 1;
    appearance66.BackGradientStyle = (GradientStyle) 3;
    appearance66.BorderColor = SystemColors.Window;
    this.MgaComboBox1.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance66;
    ((AppearanceBase) appearance67).TextHAlignAsString = "Left";
    this.MgaComboBox1.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance67;
    this.MgaComboBox1.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.MgaComboBox1.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance68.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance68.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.MgaComboBox1.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance68;
    appearance69.BackColor = SystemColors.Window;
    appearance69.BorderColor = Color.White;
    this.MgaComboBox1.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance69;
    this.MgaComboBox1.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.MgaComboBox1.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance70.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance70.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance70.ForeColor = Color.Black;
    this.MgaComboBox1.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance70;
    appearance71.BackColor = SystemColors.ControlLight;
    this.MgaComboBox1.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance71;
    scrollBarLook4.ViewStyle = (ScrollBarViewStyle) 3;
    this.MgaComboBox1.DisplayLayout.ScrollBarLook = scrollBarLook4;
    this.MgaComboBox1.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.MgaComboBox1.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.MgaComboBox1.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.MgaComboBox1).DisplayMember = "WCLimits";
    this.MgaComboBox1.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.MgaComboBox1).DropDownWidth = 200;
    ((Control) this.MgaComboBox1).Location = new Point(116, 53);
    this.MgaComboBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaComboBox1).Name = "MgaComboBox1";
    ((Control) this.MgaComboBox1).Size = new Size(232, 20);
    ((Control) this.MgaComboBox1).TabIndex = 1;
    ((UltraControlBase) this.MgaComboBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaComboBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaComboBox1).ValueMember = "WCLimitsID";
    this.MgaComboBox2.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MgaComboBox2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericWCExposures.ClassCode", true));
    ((UltraGridBase) this.MgaComboBox2).DataMember = "lstClassCodes";
    ((UltraGridBase) this.MgaComboBox2).DataSource = (object) this.ds;
    appearance72.BackColor = Color.White;
    appearance72.BorderColor = Color.FromArgb(78, 122, 171);
    this.MgaComboBox2.DisplayLayout.Appearance = (AppearanceBase) appearance72;
    this.MgaComboBox2.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand5.ColHeadersVisible = false;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Class Code";
    ultraGridColumn19.Header.VisiblePosition = 1;
    ultraGridColumn19.Width = 61;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Description";
    ultraGridColumn20.Header.VisiblePosition = 0;
    ultraGridColumn20.Width = 220;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn19,
      (object) ultraGridColumn20
    });
    this.MgaComboBox2.DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    this.MgaComboBox2.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.MgaComboBox2.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance73.BackColor = SystemColors.ActiveBorder;
    appearance73.BackColor2 = SystemColors.ControlDark;
    appearance73.BackGradientStyle = (GradientStyle) 2;
    appearance73.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.MgaComboBox2.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance73;
    appearance74.ForeColor = SystemColors.GrayText;
    this.MgaComboBox2.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance74;
    ((SpecialBoxBase) this.MgaComboBox2.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance75.BackColor = SystemColors.ControlLightLight;
    appearance75.BackColor2 = SystemColors.Control;
    appearance75.BackGradientStyle = (GradientStyle) 3;
    appearance75.ForeColor = SystemColors.GrayText;
    this.MgaComboBox2.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance75;
    this.MgaComboBox2.DisplayLayout.MaxColScrollRegions = 1;
    this.MgaComboBox2.DisplayLayout.MaxRowScrollRegions = 1;
    appearance76.BackColor = SystemColors.Window;
    appearance76.ForeColor = SystemColors.ControlText;
    this.MgaComboBox2.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance76;
    appearance77.BackColor = SystemColors.Highlight;
    appearance77.ForeColor = SystemColors.HighlightText;
    this.MgaComboBox2.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance77;
    this.MgaComboBox2.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.MgaComboBox2.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance78.BackColor = SystemColors.Window;
    this.MgaComboBox2.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance78;
    appearance79.BorderColor = Color.Silver;
    appearance79.TextTrimming = (TextTrimming) 3;
    this.MgaComboBox2.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance79;
    this.MgaComboBox2.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.MgaComboBox2.DisplayLayout.Override.CellPadding = 0;
    appearance80.BackColor = SystemColors.Control;
    appearance80.BackColor2 = SystemColors.ControlDark;
    appearance80.BackGradientAlignment = (GradientAlignment) 1;
    appearance80.BackGradientStyle = (GradientStyle) 3;
    appearance80.BorderColor = SystemColors.Window;
    this.MgaComboBox2.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance80;
    ((AppearanceBase) appearance81).TextHAlignAsString = "Left";
    this.MgaComboBox2.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance81;
    this.MgaComboBox2.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.MgaComboBox2.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance82.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance82.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.MgaComboBox2.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance82;
    appearance83.BackColor = SystemColors.Window;
    appearance83.BorderColor = Color.White;
    this.MgaComboBox2.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance83;
    this.MgaComboBox2.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.MgaComboBox2.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance84.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance84.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance84.ForeColor = Color.Black;
    this.MgaComboBox2.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance84;
    appearance85.BackColor = SystemColors.ControlLight;
    this.MgaComboBox2.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance85;
    scrollBarLook5.ViewStyle = (ScrollBarViewStyle) 3;
    this.MgaComboBox2.DisplayLayout.ScrollBarLook = scrollBarLook5;
    this.MgaComboBox2.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.MgaComboBox2.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.MgaComboBox2.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.MgaComboBox2).DisplayMember = "ClassCode";
    this.MgaComboBox2.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.MgaComboBox2).DropDownWidth = 300;
    ((Control) this.MgaComboBox2).Location = new Point(116, 17);
    this.MgaComboBox2.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaComboBox2).Name = "MgaComboBox2";
    ((Control) this.MgaComboBox2).Size = new Size(232, 20);
    ((Control) this.MgaComboBox2).TabIndex = 0;
    ((UltraControlBase) this.MgaComboBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaComboBox2).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaComboBox2).ValueMember = "ClassCode";
    this.MgaSimpleComboBox1.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MgaSimpleComboBox1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericWCExposures.StateID", true));
    ((UltraGridBase) this.MgaSimpleComboBox1).DataMember = "lstStates";
    ((UltraGridBase) this.MgaSimpleComboBox1).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.MgaSimpleComboBox1).DisplayMember = "State";
    this.MgaSimpleComboBox1.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.MgaSimpleComboBox1).DropDownWidth = 300;
    ((Control) this.MgaSimpleComboBox1).Location = new Point(429, 17);
    this.MgaSimpleComboBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaSimpleComboBox1).Name = "MgaSimpleComboBox1";
    ((Control) this.MgaSimpleComboBox1).Size = new Size(207, 20);
    ((Control) this.MgaSimpleComboBox1).TabIndex = 4;
    ((UltraControlBase) this.MgaSimpleComboBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaSimpleComboBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaSimpleComboBox1).ValueMember = "StateID";
    this.AutoScaleMode = AutoScaleMode.None;
    this.BackColor = Color.White;
    this.ClientSize = new Size(762, 594);
    this.Controls.Add((Control) this.UltraTabControl5);
    this.Controls.Add((Control) this.UltraTabControl4);
    this.Controls.Add((Control) this.dgLocations);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmWCExposureCapture);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Worker's Compensation Exposure";
    ((Control) this.tabExposure).ResumeLayout(false);
    ((Control) this.tabExposure).PerformLayout();
    ((ISupportInitialize) this.txtRenumeration).EndInit();
    ((ISupportInitialize) this.txtRate).EndInit();
    ((ISupportInitialize) this.txtDescription).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.MgaTextBox11).EndInit();
    ((ISupportInitialize) this.MgaTextBox10).EndInit();
    ((ISupportInitialize) this.MgaTextBox9).EndInit();
    ((ISupportInitialize) this.MgaTextBox8).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.MgaTextBox5).EndInit();
    ((ISupportInitialize) this.MgaTextBox6).EndInit();
    ((ISupportInitialize) this.MgaTextBox7).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((ISupportInitialize) this.UltraTabControl2).EndInit();
    ((ISupportInitialize) this.UltraTabControl3).EndInit();
    ((ISupportInitialize) this.UltraTabControl4).EndInit();
    ((Control) this.UltraTabControl4).ResumeLayout(false);
    ((ISupportInitialize) this.err).EndInit();
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.MgaNumericEditor1).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor2).EndInit();
    ((ISupportInitialize) this.MgaTextBox1).EndInit();
    ((ISupportInitialize) this.MgaTextBox2).EndInit();
    ((ISupportInitialize) this.MgaTextBox3).EndInit();
    ((ISupportInitialize) this.MgaTextBox4).EndInit();
    ((ISupportInitialize) this.UltraTabControl5).EndInit();
    ((Control) this.UltraTabControl5).ResumeLayout(false);
    ((ISupportInitialize) this.MgaNumericEditor3).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor4).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.MgaComboBox3).EndInit();
    ((ISupportInitialize) this.cboClassCodes).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((ISupportInitialize) this.dgLocations).EndInit();
    ((ISupportInitialize) this.MgaComboBox1).EndInit();
    ((ISupportInitialize) this.MgaComboBox2).EndInit();
    ((ISupportInitialize) this.MgaSimpleComboBox1).EndInit();
    this.ResumeLayout(false);
  }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblGenericWCExposures.TableName];
  }

  private BindingManagerBase bmb_Pol
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblWCPolicyInfo.TableName];
  }

  private BindingManagerBase bmb_Loc
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblUnderwritingLocations.TableName];
  }

  public void SetQuoteId(int quoteId)
  {
    this._quoteId = quoteId;
    this.QuoteIdSet(quoteId);
  }

  protected virtual void QuoteIdSet(int quoteID)
  {
  }

  private void frmWCExposureCapture_Load(object sender, EventArgs e)
  {
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._quote = new Quote(this._quoteId);
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT  NetRate_QuoteID FROM tblQuotes WITH (NOLOCK) WHERE QuoteID = @QID", new object[2]
    {
      (object) "@QID",
      (object) this._quoteId
    }));
    if (objectValue != DBNull.Value && objectValue != null)
      this._netRateQuoteID = Conversions.ToInteger(objectValue);
    if (SystemSettings.KeyExists("WorkersCompExposure.RateDisplayInput"))
    {
      int int32 = Convert.ToInt32(SystemSettings.GetNumericSetting("WorkersCompExposure.RateDisplayInput"));
      ((UltraNumericEditorBase) this.txtRate).FormatString = string.Empty;
      this.txtRate.MaskInput = "nnnnnnnnnnn.";
      int num = int32 - 1;
      for (int index = 0; index <= num; ++index)
      {
        MGANumericEditor txtRate;
        string str = (txtRate = this.txtRate).MaskInput + "n";
        txtRate.MaskInput = str;
      }
    }
    DefaultDatabase.LoadDataTable((DataTable) this.ds.lstClassCodes, CommandType.StoredProcedure, SystemSettings.GetSetting<string>("Rating.spGetAllClassCodesProcName", "spGetAllClassCodes"), 90, (CommandArgumentType) 0, new object[2]
    {
      (object) "@quoteId",
      (object) this._quoteId
    });
    DefaultDatabase.LoadDataTable((DataTable) this.ds.lstStates, CommandType.Text, "SELECT StateID, State FROM lstStates ORDER BY State");
    DefaultDatabase.LoadDataTable((DataTable) this.ds.lstWCLimits, CommandType.Text, "SELECT WCLimitsID, WCLimits FROM lstWCLimits");
    this.GetLocations();
    if (this.ds.tblUnderwritingLocations.Count == 0)
      this.MergeNetRateLocations();
    this.GetExposures();
    this.ds.Relations.Add("ExposureLocations", this.ds.tblUnderwritingLocations.Columns["LocationID"], this.ds.tblGenericWCExposures.Columns["LocationID"]);
    ((UltraGridBase) this.dgLocations).DisplayLayout.Bands[1].Columns["QuoteID"].Hidden = true;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Bands[1].Columns["WorkCompID"].Hidden = true;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Bands[1].Columns["LocationID"].Hidden = true;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Bands[1].Columns["ClassCodeID"].Hidden = true;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Bands[1].Columns["EffectiveRateOfClass"].Hidden = true;
    ((UltraGridBase) this.dgLocations).DisplayLayout.Bands[1].Columns["Renumeration"].Format = "c";
    ((UltraGridBase) this.dgLocations).DisplayLayout.Bands[1].Columns["Rate"].Format = "c";
    this.GetPolicyInformation();
    this.SetPolicyInformation();
    this.ColorDeletedLocationRows();
    this.bmb_Loc.Position = this.ds.tblUnderwritingLocations.Count - 1;
  }

  private void SetPolicyInformation()
  {
    if (this.ds.tblWCPolicyInfo.Count == 0)
    {
      dsWCExposureCapture.tblWCPolicyInfoRow row = this.ds.tblWCPolicyInfo.NewtblWCPolicyInfoRow();
      row.QuoteID = this._quote.QuoteID;
      this.ds.tblWCPolicyInfo.AddtblWCPolicyInfoRow(row);
    }
    this.bmb_Pol.Position = this.ds.tblWCPolicyInfo.Count - 1;
  }

  private void GetPolicyInformation()
  {
    this.ds.tblWCPolicyInfo.Clear();
    this.daPol.SelectCommand.Parameters["@QuoteID"].Value = (object) this._quote.QuoteID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daPol, (DataTable) this.ds.tblWCPolicyInfo);
  }

  private void GetExposures()
  {
    this.ds.tblGenericWCExposures.Clear();
    this.daExposure.SelectCommand.Parameters["@QuoteID"].Value = (object) this._quoteId;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daExposure, (DataTable) this.ds.tblGenericWCExposures);
  }

  private void MergeNetRateLocations()
  {
    if (this._netRateQuoteID == int.MinValue)
      return;
    this.ds.NetRate_Quote_Insur_Quote_Locat.Clear();
    DefaultDatabase.LoadDataTable((DataTable) this.ds.NetRate_Quote_Insur_Quote_Locat, CommandType.Text, "SELECT LocationID, QuoteID, UnitNumber, State, Address, ZipCode, City, [P.O.Box] FROM NetRate_Quote_Insur_Quote_Locat WITH (NOLOCK) WHERE QuoteID = @NID", new object[2]
    {
      (object) "@NID",
      (object) this._netRateQuoteID
    });
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string empty3 = string.Empty;
    string empty4 = string.Empty;
    string str1 = "1";
    string str2 = "1";
    List<int> intList = new List<int>();
    try
    {
      foreach (dsWCExposureCapture.NetRate_Quote_Insur_Quote_LocatRow row in this.ds.NetRate_Quote_Insur_Quote_Locat.Rows)
      {
        string str3 = string.Empty;
        string str4 = string.Empty;
        string str5 = string.Empty;
        string str6 = string.Empty;
        if (!row.IsAddressNull())
          str3 = row.Address;
        if (!row.IsCityNull())
          str4 = row.City;
        if (!row.IsStateNull())
          str5 = row.State;
        if (!row.IsZipCodeNull())
          str6 = row.ZipCode;
        int integer = Conversions.ToInteger(DefaultDatabase.ExecuteScalar("dbo.spAddUnderwritingLocation", new object[18]
        {
          (object) "@quoteGuid",
          (object) this._quote.QuoteGuid,
          (object) "@locNo",
          (object) row.UnitNumber,
          (object) "@PhysicalBuildingNo",
          (object) str2,
          (object) "@Address1",
          (object) str3,
          (object) "@City",
          (object) str4,
          (object) "@State",
          (object) str5,
          (object) "@Zip",
          (object) str6,
          (object) "@bldgNo",
          (object) str1,
          (object) "@UserAdded",
          (object) CurrentUser.Instance.UserGUID
        }) ?? (object) int.MinValue);
        this.InsertLocationIDs(this._quoteId, integer, row.UnitNumber);
        intList.Add(integer);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.GetLocations();
    try
    {
      foreach (dsWCExposureCapture.tblUnderwritingLocationsRow row in this.ds.tblUnderwritingLocations.Rows)
      {
        if (intList.Contains(row.LocationID))
          row.NetRateLoc = true;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((UltraGridBase) this.dgLocations).UpdateData();
  }

  protected virtual void InsertLocationIDs(int quoteID, int locationID, int unitNumber)
  {
  }

  private void GetLocations()
  {
    this.ds.tblUnderwritingLocations.Clear();
    this.daLocations.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._quote.QuoteGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLocations, (DataTable) this.ds.tblUnderwritingLocations);
  }

  private bool IsActiveLocation() => ((UltraGridBase) this.dgLocations).ActiveRow != null;

  private bool IsValidForSave()
  {
    bool flag = true;
    if (string.IsNullOrEmpty(this.cboClassCodes.Text))
    {
      this.err.SetError((Control) this.cboClassCodes, "Please select or type in a value.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboClassCodes, string.Empty);
    if (string.IsNullOrEmpty(this.cboState.Text))
    {
      this.err.SetError((Control) this.cboState, "Please select a value.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboState, string.Empty);
    if (((TextEditorControlBase) this.txtDescription).Text.Replace(" ", string.Empty).Length == 0)
    {
      this.err.SetError((Control) this.txtDescription, "Please enter a value.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtDescription, string.Empty);
    if (((UltraWinEditorMaskedControlBase) this.txtRate).Text.Replace(" ", string.Empty).Length == 0)
    {
      this.err.SetError((Control) this.txtRate, "Please enter a value");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtRate, string.Empty);
    if (((UltraWinEditorMaskedControlBase) this.txtRenumeration).Text.Replace(" ", string.Empty).Length == 0)
    {
      this.err.SetError((Control) this.txtRenumeration, "Please enter a value");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtRenumeration, string.Empty);
    return flag;
  }

  private void ClearErrorProviders()
  {
    try
    {
      foreach (Control control in ((Control) this.tabExposure).Controls)
      {
        if (control is MGASimpleComboBox)
          this.err.SetError(control, string.Empty);
        else if (control is MGATextBox)
          this.err.SetError(control, string.Empty);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void lnkModifyLocations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.OpenUnderwritingLocationsForm();
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
      this.GetLocations();
      this.GetExposures();
      ((UltraGridBase) this.dgLocations).UpdateData();
      this.ColorDeletedLocationRows();
      ((UltraGridBase) this.dgLocations).Rows.ExpandAll(true);
      this.SetSaveState();
    }
    finally
    {
      this.ds.EnforceConstraints = true;
      this.Cursor = MgaCursors.Default;
    }
  }

  private void ColorDeletedLocationRows()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.dgLocations).Rows)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Database.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["ModificationCode"].Value), string.Empty), "D", false) == 0)
      {
        UltraGridRow ultraGridRow = row;
        ultraGridRow.Appearance.ForeColor = Color.Red;
        ultraGridRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
      }
      else
      {
        UltraGridRow ultraGridRow = row;
        ultraGridRow.Appearance.ForeColor = Color.Black;
        ultraGridRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
      }
    }
  }

  private void SetSaveState()
  {
    if (this.ds.tblGenericWCExposures.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void dgLocations_AfterRowActivate(object sender, EventArgs e)
  {
    if (!this.IsActiveLocation())
      return;
    if (((UltraGridBase) this.dgLocations).ActiveRow.Band.Index == 0)
    {
      this.EnableControls(false);
      this.dbSave.UIState = this.ds.tblGenericWCExposures.Select("LocationID = " + Conversions.ToString(Conversions.ToInteger(((UltraGridBase) this.dgLocations).ActiveRow.Cells["LocationID"].Value))).Length <= 0 ? UIState.NoRecordsNotEditing : UIState.HasRecordsNotEditing;
      Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgLocations).ActiveRow.Cells["LocationID"].Value), "LocationID", (DataTable) this.ds.tblUnderwritingLocations, this.bmb_Loc);
    }
    else
    {
      this.bmb.EndCurrentEdit();
      Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgLocations).ActiveRow.Cells["WorkCompID"].Value), "WorkCompID", (DataTable) this.ds.tblGenericWCExposures, this.bmb);
      string text = ((TextEditorControlBase) this.txtDescription).Text;
      dsWCExposureCapture.tblGenericWCExposuresRow genericWcExposure = this.ds.tblGenericWCExposures[this.bmb.Position];
      if (!genericWcExposure.IsClassCodeNull() && !genericWcExposure.IsClassCodeIDNull())
        this.cboClassCodes.Value = (object) (genericWcExposure.ClassCodeID.ToString() + genericWcExposure.ClassCode);
      else if (!genericWcExposure.IsClassCodeIDNull())
      {
        DataRow[] dataRowArray = this.ds.lstClassCodes.Select("ClassCodeID = " + genericWcExposure.ClassCodeID.ToString());
        if (dataRowArray.Length > 0)
          this.cboClassCodes.SelectedIndex = this.ds.lstClassCodes.Rows.IndexOf(dataRowArray[0]);
      }
      else
        this.cboClassCodes.Text = text;
      ((TextEditorControlBase) this.txtDescription).Text = string.IsNullOrEmpty(text) ? ((TextEditorControlBase) this.txtDescription).Text : text;
      if (this.dbSave.UIState == UIState.Editing)
        return;
      this.SetSaveState();
    }
  }

  private void cboClassCodes_ValueChanged(object sender, EventArgs e)
  {
    if (this.bmb.Position <= -1 || ((UltraDropDownBase) this.cboClassCodes).SelectedRow == null || this.cboClassCodes.Value == DBNull.Value)
      return;
    if (((UltraDropDownBase) this.cboClassCodes).SelectedRow.ListIndex > -1)
    {
      dsWCExposureCapture.lstClassCodesRow lstClassCode = this.ds.lstClassCodes[((UltraDropDownBase) this.cboClassCodes).SelectedRow.ListIndex];
      dsWCExposureCapture.tblGenericWCExposuresRow genericWcExposure = this.ds.tblGenericWCExposures[this.bmb.Position];
      genericWcExposure.ClassCode = lstClassCode.ClassCode;
      genericWcExposure.ClassCodeID = (int) lstClassCode.ClassCodeID;
    }
    ((TextEditorControlBase) this.txtDescription).Text = this.cboClassCodes.Text;
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.tblGenericWCExposures.RejectChanges();
    this.ds.AcceptChanges();
    this.ClearErrorProviders();
    this.EnableControls(false);
    this.SetSaveState();
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this._quote.IsBound)
    {
      int num = (int) MessageBox.Show("Cannot delete exposures after policy is bound.", "Policy Bound", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else if (((UltraGridBase) this.dgLocations).ActiveRow == null)
      e.Cancel = true;
    else if (((UltraGridBase) this.dgLocations).ActiveRow.Band.Index < 1)
    {
      int num = (int) MessageBox.Show("Please select an exposure row, not a location, to delete.", "Exposure Row Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else if (MessageBox.Show("Do you wish to continue with delete?", "Continue Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
    {
      e.Cancel = true;
    }
    else
    {
      this.ds.tblGenericWCExposures[this.bmb.Position].Delete();
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daExposure, (DataTable) this.ds.tblGenericWCExposures);
      this.EnableControls(false);
    }
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (this._quote.IsBound)
    {
      int num = (int) MessageBox.Show("Cannot edit exposures after policy is bound.", "Policy Bound", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
      this.EnableControls(true);
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (this._quote.IsBound)
    {
      int num = (int) MessageBox.Show("Cannot add exposures after policy is bound.", "Policy Bound", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else if (!this.IsActiveLocation())
    {
      int num = (int) MessageBox.Show("Please select a location in the grid.", "No Active Location", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      this.cboClassCodes.Value = (object) DBNull.Value;
      int integer;
      string str;
      if (((UltraGridBase) this.dgLocations).ActiveRow.Band.Index == 0)
      {
        integer = Conversions.ToInteger(((UltraGridBase) this.dgLocations).ActiveRow.Cells["LocationID"].Value);
        str = ((UltraGridBase) this.dgLocations).ActiveRow.Cells["State"].Value.ToString();
      }
      else
      {
        integer = Conversions.ToInteger(((UltraGridBase) this.dgLocations).ActiveRow.ParentRow.Cells["locationID"].Value);
        str = ((UltraGridBase) this.dgLocations).ActiveRow.ParentRow.Cells["State"].Value.ToString();
      }
      dsWCExposureCapture.tblGenericWCExposuresRow row = this.ds.tblGenericWCExposures.NewtblGenericWCExposuresRow();
      row.QuoteID = this._quoteId;
      row.LocationID = integer;
      row.StateID = str;
      try
      {
        this.ds.EnforceConstraints = false;
        this.EnableControls(true);
        this.ds.tblGenericWCExposures.AddtblGenericWCExposuresRow(row);
        this.bmb.Position = this.ds.tblGenericWCExposures.Rows.Count - 1;
      }
      finally
      {
        this.ds.EnforceConstraints = true;
      }
    }
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.IsValidForSave())
    {
      e.Cancel = true;
    }
    else
    {
      this.bmb.EndCurrentEdit();
      try
      {
        foreach (dsWCExposureCapture.tblGenericWCExposuresRow genericWcExposure in (TypedTableBase<dsWCExposureCapture.tblGenericWCExposuresRow>) this.ds.tblGenericWCExposures)
        {
          if (genericWcExposure.IsClassCodeNull() && !genericWcExposure.IsDescriptionNull() && genericWcExposure.Description.Contains("-"))
            genericWcExposure.ClassCode = genericWcExposure.Description.Split('-')[0].Trim();
        }
      }
      finally
      {
        IEnumerator<dsWCExposureCapture.tblGenericWCExposuresRow> enumerator;
        enumerator?.Dispose();
      }
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daExposure, (DataTable) this.ds.tblGenericWCExposures);
      this.EnableControls(false);
      ((UltraGridBase) this.dgLocations).Rows.ExpandAll(true);
    }
  }

  private void EnableControls(bool enableVal)
  {
    try
    {
      foreach (Control control in ((Control) this.tabExposure).Controls)
      {
        switch (control)
        {
          case MGASimpleComboBox _:
            control.Enabled = enableVal;
            continue;
          case MGATextBox _:
            control.Enabled = enableVal;
            continue;
          case MGANumericEditor _:
            control.Enabled = enableVal;
            continue;
          default:
            continue;
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

  private void btnSave_Click(object sender, EventArgs e)
  {
    this.bmb_Pol.EndCurrentEdit();
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daPol, (DataTable) this.ds.tblWCPolicyInfo);
  }
}

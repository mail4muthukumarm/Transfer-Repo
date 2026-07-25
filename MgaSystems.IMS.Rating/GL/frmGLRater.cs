// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.GL.frmGLRater
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
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.Policies.Rating.Locations;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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
namespace MGASystems.IMS.Policies.Rating.GL;

public class frmGLRater : frmRaterBase
{
  private IContainer components;
  private UltraCheckEditor CheckBox1;
  private Label Label10;
  private Label Label9;
  private Label Label8;
  private Label Label7;
  private Label Label6;
  private Label Label5;
  private Label Label4;
  private Label Label3;
  private Label Label2;
  private Label Label1;
  private SqlDataAdapter daLimits;
  private SqlCommand SqlSelectCommand1;
  private SqlConnection cn;
  private dsGLRater ds;
  private DataView dvOcc;
  private DataView dvAgg;
  private MGASimpleComboBox cboAgg;
  private MGASimpleComboBox cboPCO;
  private DataView dvPCO;
  private MGASimpleComboBox cboPAI;
  private DataView dvPAI;
  private DataView dvFDL;
  private DataView dvMed;
  private DataView dvPDL;
  private DataView dvLLL;
  private MGASimpleComboBox cboNOH;
  private MGASimpleComboBox cboLLL;
  private MGASimpleComboBox cboPDL;
  private MGASimpleComboBox cboMedPay;
  private MGASimpleComboBox cboFDL;
  private DataView dvNOH;
  private MGASimpleComboBox cboOcc;
  private SqlDataAdapter daDeductibleDescriptions;
  private SqlCommand SqlSelectCommand2;
  private MGASimpleComboBox cboDeductibleDescriptions;
  private SqlDataAdapter daOptions;
  private SqlCommand SqlSelectCommand3;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private SqlDataAdapter daOptionsGL;
  private ErrorProvider err;
  private UltraCurrencyEditor ucDeductible;
  private UltraCheckEditor chkTerrorismDeclined;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private UltraTabPageControl UltraTabPageControl2;
  private MGATextBox txtAdditionalComments;
  private UltraTabPageControl UltraTabPageControl1;
  private Label Label12;
  private Label Label11;
  private Label Label13;
  private Label Label14;
  private Label Label15;
  private UltraLabel lblTotalPremium;
  private RadioButton rbClaimsMade;
  private Label Label16;
  private RadioButton rbOccurrence;
  private SqlCommand SqlSelectCommand4;
  private SqlCommand SqlInsertCommand2;
  private SqlCommand SqlUpdateCommand2;
  private SqlCommand SqlDeleteCommand2;
  private bool _activated;
  private readonly Font _strikeoutFont;

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

  protected virtual UltraGrid ugOptions
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

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_UIStateChanged);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingDelete);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.UIStateChanged -= eventHandler1;
        dbSave1.ClickedCancel -= eventHandler2;
        dbSave1.ClickingNew -= cancelEventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickingDelete -= cancelEventHandler3;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.UIStateChanged += eventHandler1;
      dbSave2.ClickedCancel += eventHandler2;
      dbSave2.ClickingNew += cancelEventHandler1;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickingDelete += cancelEventHandler3;
    }
  }

  [field: AccessedThroughProperty("UltraTabControl1")]
  protected virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabOptionInfo")]
  protected virtual UltraTabPageControl tabOptionInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
      EventHandler eventHandler = new EventHandler(this.UpdatePremiumValues);
      MGANumericEditor txtTerrorism1 = this._txtTerrorism;
      if (txtTerrorism1 != null)
        ((UltraNumericEditorBase) txtTerrorism1).ValueChanged -= eventHandler;
      this._txtTerrorism = value;
      MGANumericEditor txtTerrorism2 = this._txtTerrorism;
      if (txtTerrorism2 == null)
        return;
      ((UltraNumericEditorBase) txtTerrorism2).ValueChanged += eventHandler;
    }
  }

  protected virtual MGANumericEditor txtPremises
  {
    get => this._txtPremises;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.UpdatePremiumValues);
      MGANumericEditor txtPremises1 = this._txtPremises;
      if (txtPremises1 != null)
        ((UltraNumericEditorBase) txtPremises1).ValueChanged -= eventHandler;
      this._txtPremises = value;
      MGANumericEditor txtPremises2 = this._txtPremises;
      if (txtPremises2 == null)
        return;
      ((UltraNumericEditorBase) txtPremises2).ValueChanged += eventHandler;
    }
  }

  private virtual MGANumericEditor txtProducts
  {
    get => this._txtProducts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.UpdatePremiumValues);
      MGANumericEditor txtProducts1 = this._txtProducts;
      if (txtProducts1 != null)
        ((UltraNumericEditorBase) txtProducts1).ValueChanged -= eventHandler;
      this._txtProducts = value;
      MGANumericEditor txtProducts2 = this._txtProducts;
      if (txtProducts2 == null)
        return;
      ((UltraNumericEditorBase) txtProducts2).ValueChanged += eventHandler;
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmGLRater));
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblQuoteOptions", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("QuoteOptionID");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("QuoteOptionGUID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("QuoteGUID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Premium");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("tblQuoteOptionstblQuoteOptionGL");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblQuoteOptionstblQuoteOptionGL", 0);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("QuoteOptionID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("OCC_ID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("AGG_ID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("PCO_ID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("PAI_ID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("FDL_ID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("MED_ID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("LLL_ID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("NOH_ID");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("PDL_ID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Deductible");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("DeductibleDescriptionID");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("AggPerLocation");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("TerrorismDeclined");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("AdditionalComments");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("PremPremium");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("ProdPremium");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("TerrPremium");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("ClaimsMade");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Occurrence");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance20 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance21 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance22 = new Appearance();
    this.tabOptionInfo = new UltraTabPageControl();
    this.lnkModifyLocations = new LinkLabel();
    this.Label16 = new Label();
    this.rbClaimsMade = new RadioButton();
    this.ds = new dsGLRater();
    this.rbOccurrence = new RadioButton();
    this.cboPDL = new MGASimpleComboBox();
    this.dvPDL = new DataView();
    this.cboPCO = new MGASimpleComboBox();
    this.dvPCO = new DataView();
    this.cboLLL = new MGASimpleComboBox();
    this.dvLLL = new DataView();
    this.cboPAI = new MGASimpleComboBox();
    this.dvPAI = new DataView();
    this.cboNOH = new MGASimpleComboBox();
    this.dvNOH = new DataView();
    this.cboFDL = new MGASimpleComboBox();
    this.dvFDL = new DataView();
    this.Label5 = new Label();
    this.Label1 = new Label();
    this.CheckBox1 = new UltraCheckEditor();
    this.Label2 = new Label();
    this.cboDeductibleDescriptions = new MGASimpleComboBox();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.chkTerrorismDeclined = new UltraCheckEditor();
    this.Label6 = new Label();
    this.cboOcc = new MGASimpleComboBox();
    this.dvOcc = new DataView();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.ucDeductible = new UltraCurrencyEditor();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.cboMedPay = new MGASimpleComboBox();
    this.dvMed = new DataView();
    this.cboAgg = new MGASimpleComboBox();
    this.dvAgg = new DataView();
    this.btnContinue = new MGAButton();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.lnkAddMiscPremiums = new LinkLabel();
    this.lblTotalPremium = new UltraLabel();
    this.txtProducts = new MGANumericEditor();
    this.txtPremises = new MGANumericEditor();
    this.txtTerrorism = new MGANumericEditor();
    this.Label12 = new Label();
    this.Label11 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.lnkFCW = new LinkLabel();
    this.Label15 = new Label();
    this.txtAdditionalComments = new MGATextBox();
    this.daLimits = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cn = new SqlConnection();
    this.daDeductibleDescriptions = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.ugOptions = new UltraGrid();
    this.daOptions = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand3 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.daOptionsGL = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand4 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    this.err = new ErrorProvider(this.components);
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    ((Control) this.tabOptionInfo).SuspendLayout();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboPDL).BeginInit();
    this.dvPDL.BeginInit();
    ((ISupportInitialize) this.cboPCO).BeginInit();
    this.dvPCO.BeginInit();
    ((ISupportInitialize) this.cboLLL).BeginInit();
    this.dvLLL.BeginInit();
    ((ISupportInitialize) this.cboPAI).BeginInit();
    this.dvPAI.BeginInit();
    ((ISupportInitialize) this.cboNOH).BeginInit();
    this.dvNOH.BeginInit();
    ((ISupportInitialize) this.cboFDL).BeginInit();
    this.dvFDL.BeginInit();
    ((ISupportInitialize) this.cboDeductibleDescriptions).BeginInit();
    ((ISupportInitialize) this.cboOcc).BeginInit();
    this.dvOcc.BeginInit();
    ((ISupportInitialize) this.ucDeductible).BeginInit();
    ((ISupportInitialize) this.cboMedPay).BeginInit();
    this.dvMed.BeginInit();
    ((ISupportInitialize) this.cboAgg).BeginInit();
    this.dvAgg.BeginInit();
    ((ISupportInitialize) this.btnContinue).BeginInit();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.txtProducts).BeginInit();
    ((ISupportInitialize) this.txtPremises).BeginInit();
    ((ISupportInitialize) this.txtTerrorism).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.txtAdditionalComments).BeginInit();
    ((ISupportInitialize) this.ugOptions).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.lnkModifyLocations);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.Label16);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.rbClaimsMade);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.rbOccurrence);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.cboPDL);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.cboPCO);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.cboLLL);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.cboPAI);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.cboNOH);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.cboFDL);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.Label5);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.Label1);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.CheckBox1);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.Label2);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.cboDeductibleDescriptions);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.Label3);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.Label4);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.chkTerrorismDeclined);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.Label6);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.cboOcc);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.Label7);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.Label8);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.ucDeductible);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.Label9);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.Label10);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.cboMedPay);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.cboAgg);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.btnContinue);
    ((Control) this.tabOptionInfo).Controls.Add((Control) this.dbSave);
    ((Control) this.tabOptionInfo).Location = new Point(1, 26);
    ((Control) this.tabOptionInfo).Name = "tabOptionInfo";
    ((Control) this.tabOptionInfo).Size = new Size(438, 365);
    this.lnkModifyLocations.AutoSize = true;
    this.lnkModifyLocations.BackColor = Color.Transparent;
    this.lnkModifyLocations.Location = new Point(8, 323);
    this.lnkModifyLocations.Name = "lnkModifyLocations";
    this.lnkModifyLocations.Size = new Size(96 /*0x60*/, 13);
    this.lnkModifyLocations.TabIndex = 40;
    this.lnkModifyLocations.TabStop = true;
    this.lnkModifyLocations.Text = "Add/Edit Locations";
    this.lnkModifyLocations.TextAlign = ContentAlignment.MiddleCenter;
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(96 /*0x60*/, 284);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(61, 13);
    this.Label16.TabIndex = 39;
    this.Label16.Text = "Policy Type";
    this.Label16.TextAlign = ContentAlignment.MiddleRight;
    this.rbClaimsMade.BackColor = Color.Transparent;
    this.rbClaimsMade.DataBindings.Add(new Binding("Checked", (object) this.ds, "tblQuoteOptionGL.ClaimsMade", true));
    this.rbClaimsMade.Location = new Point(256 /*0x0100*/, 280);
    this.rbClaimsMade.Name = "rbClaimsMade";
    this.rbClaimsMade.Size = new Size(88, 24);
    this.rbClaimsMade.TabIndex = 38;
    this.rbClaimsMade.Text = "Claims Made";
    this.rbClaimsMade.UseVisualStyleBackColor = false;
    this.ds.DataSetName = "dsGLRater";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.rbOccurrence.BackColor = Color.Transparent;
    this.rbOccurrence.Checked = true;
    this.rbOccurrence.DataBindings.Add(new Binding("Checked", (object) this.ds, "tblQuoteOptionGL.Occurrence", true));
    this.rbOccurrence.Location = new Point(168, 280);
    this.rbOccurrence.Name = "rbOccurrence";
    this.rbOccurrence.Size = new Size(80 /*0x50*/, 24);
    this.rbOccurrence.TabIndex = 37;
    this.rbOccurrence.TabStop = true;
    this.rbOccurrence.Text = "Occurrence";
    this.rbOccurrence.UseVisualStyleBackColor = false;
    this.cboPDL.BorderStyle = (UIElementBorderStyle) 4;
    this.cboPDL.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboPDL).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionGL.PDL_ID", true));
    ((UltraGridBase) this.cboPDL).DataSource = (object) this.dvPDL;
    ((UltraDropDownBase) this.cboPDL).DisplayMember = "LimitDisplay";
    this.cboPDL.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboPDL.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboPDL).Location = new Point(168, 160 /*0xA0*/);
    this.cboPDL.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboPDL).Name = "cboPDL";
    ((Control) this.cboPDL).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboPDL).TabIndex = 7;
    ((UltraControlBase) this.cboPDL).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPDL).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboPDL).ValueMember = "ID";
    this.dvPDL.RowFilter = "(LimitCode='PDL') OR (LimitCode ='')";
    this.dvPDL.Sort = "Limit";
    this.dvPDL.Table = (DataTable) this.ds.tblGLLimits;
    this.cboPCO.BorderStyle = (UIElementBorderStyle) 4;
    this.cboPCO.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboPCO).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionGL.PCO_ID", true));
    ((UltraGridBase) this.cboPCO).DataSource = (object) this.dvPCO;
    ((UltraDropDownBase) this.cboPCO).DisplayMember = "LimitDisplay";
    this.cboPCO.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboPCO.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboPCO).Location = new Point(168, 64 /*0x40*/);
    this.cboPCO.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboPCO).Name = "cboPCO";
    ((Control) this.cboPCO).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboPCO).TabIndex = 3;
    ((Control) this.cboPCO).Tag = (object) "r";
    ((UltraControlBase) this.cboPCO).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPCO).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboPCO).ValueMember = "ID";
    this.dvPCO.RowFilter = "LimitCode='PCO'";
    this.dvPCO.Sort = "Limit";
    this.dvPCO.Table = (DataTable) this.ds.tblGLLimits;
    this.cboLLL.BorderStyle = (UIElementBorderStyle) 4;
    this.cboLLL.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboLLL).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionGL.LLL_ID", true));
    ((UltraGridBase) this.cboLLL).DataSource = (object) this.dvLLL;
    ((UltraDropDownBase) this.cboLLL).DisplayMember = "LimitDisplay";
    this.cboLLL.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboLLL.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboLLL).Location = new Point(168, 184);
    this.cboLLL.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLLL).Name = "cboLLL";
    ((Control) this.cboLLL).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboLLL).TabIndex = 8;
    ((UltraControlBase) this.cboLLL).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLLL).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLLL).ValueMember = "ID";
    this.dvLLL.RowFilter = "LimitCode='LLL' OR (LimitCode ='')";
    this.dvLLL.Sort = "Limit";
    this.dvLLL.Table = (DataTable) this.ds.tblGLLimits;
    this.cboPAI.BorderStyle = (UIElementBorderStyle) 4;
    this.cboPAI.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboPAI).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionGL.PAI_ID", true));
    ((UltraGridBase) this.cboPAI).DataSource = (object) this.dvPAI;
    ((UltraDropDownBase) this.cboPAI).DisplayMember = "LimitDisplay";
    this.cboPAI.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboPAI.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboPAI).Location = new Point(168, 88);
    this.cboPAI.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboPAI).Name = "cboPAI";
    ((Control) this.cboPAI).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboPAI).TabIndex = 4;
    ((Control) this.cboPAI).Tag = (object) "r";
    ((UltraControlBase) this.cboPAI).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPAI).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboPAI).ValueMember = "ID";
    this.dvPAI.RowFilter = "LimitCode='PAI'";
    this.dvPAI.Sort = "Limit";
    this.dvPAI.Table = (DataTable) this.ds.tblGLLimits;
    this.cboNOH.BorderStyle = (UIElementBorderStyle) 4;
    this.cboNOH.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboNOH).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionGL.NOH_ID", true));
    ((UltraGridBase) this.cboNOH).DataSource = (object) this.dvNOH;
    ((UltraDropDownBase) this.cboNOH).DisplayMember = "LimitDisplay";
    this.cboNOH.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboNOH.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboNOH).Location = new Point(168, 208 /*0xD0*/);
    this.cboNOH.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboNOH).Name = "cboNOH";
    ((Control) this.cboNOH).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboNOH).TabIndex = 9;
    ((UltraControlBase) this.cboNOH).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboNOH).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboNOH).ValueMember = "ID";
    this.dvNOH.RowFilter = "LimitCode='NOH' OR (LimitCode ='')";
    this.dvNOH.Sort = "Limit";
    this.dvNOH.Table = (DataTable) this.ds.tblGLLimits;
    this.cboFDL.BorderStyle = (UIElementBorderStyle) 4;
    this.cboFDL.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboFDL).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionGL.FDL_ID", true));
    ((UltraGridBase) this.cboFDL).DataSource = (object) this.dvFDL;
    ((UltraDropDownBase) this.cboFDL).DisplayMember = "LimitDisplay";
    this.cboFDL.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboFDL.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboFDL).Location = new Point(168, 112 /*0x70*/);
    this.cboFDL.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboFDL).Name = "cboFDL";
    ((Control) this.cboFDL).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboFDL).TabIndex = 5;
    ((Control) this.cboFDL).Tag = (object) "r";
    ((UltraControlBase) this.cboFDL).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboFDL).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboFDL).ValueMember = "ID";
    this.dvFDL.RowFilter = "LimitCode='FDL'";
    this.dvFDL.Sort = "Limit";
    this.dvFDL.Table = (DataTable) this.ds.tblGLLimits;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(60, 114);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(95, 13);
    this.Label5.TabIndex = 31 /*0x1F*/;
    this.Label5.Text = "Fire Damage Legal";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(97, 18);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(62, 13);
    this.Label1.TabIndex = 27;
    this.Label1.Text = "Occurrence";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    ((UltraToggleEditorBase) this.CheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.CheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.CheckBox1).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblQuoteOptionGL.AggPerLocation", true));
    ((Control) this.CheckBox1).Location = new Point(336, 38);
    ((Control) this.CheckBox1).Name = "CheckBox1";
    ((Control) this.CheckBox1).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.CheckBox1).TabIndex = 2;
    ((UltraToggleEditorBase) this.CheckBox1).Text = "Per Location";
    ((UltraControlBase) this.CheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.CheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(103, 42);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(58, 13);
    this.Label2.TabIndex = 28;
    this.Label2.Text = "Aggregate";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.cboDeductibleDescriptions.BorderStyle = (UIElementBorderStyle) 4;
    this.cboDeductibleDescriptions.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboDeductibleDescriptions).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionGL.DeductibleDescriptionID", true));
    ((UltraGridBase) this.cboDeductibleDescriptions).DataSource = (object) this.ds.lstGLDeductibleDescriptions;
    ((UltraDropDownBase) this.cboDeductibleDescriptions).DisplayMember = "DeductibleDescription";
    this.cboDeductibleDescriptions.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboDeductibleDescriptions.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDeductibleDescriptions).Location = new Point(256 /*0x0100*/, 232);
    this.cboDeductibleDescriptions.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDeductibleDescriptions).Name = "cboDeductibleDescriptions";
    ((Control) this.cboDeductibleDescriptions).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboDeductibleDescriptions).TabIndex = 11;
    ((UltraControlBase) this.cboDeductibleDescriptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDeductibleDescriptions).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDeductibleDescriptions).ValueMember = "ID";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(28, 66);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size((int) sbyte.MaxValue, 13);
    this.Label3.TabIndex = 29;
    this.Label3.Text = "Product / Completed Ops";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(8, 90);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(147, 13);
    this.Label4.TabIndex = 30;
    this.Label4.Text = "Personal && Advertising Injury";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    ((UltraToggleEditorBase) this.chkTerrorismDeclined).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkTerrorismDeclined).BackColorInternal = Color.Transparent;
    ((Control) this.chkTerrorismDeclined).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblQuoteOptionGL.TerrorismDeclined", true));
    ((Control) this.chkTerrorismDeclined).Location = new Point(168, (int) byte.MaxValue);
    ((Control) this.chkTerrorismDeclined).Name = "chkTerrorismDeclined";
    ((Control) this.chkTerrorismDeclined).Size = new Size(184, 24);
    ((Control) this.chkTerrorismDeclined).TabIndex = 12;
    ((UltraToggleEditorBase) this.chkTerrorismDeclined).Text = "Terrorism Coverage Declined";
    ((UltraControlBase) this.chkTerrorismDeclined).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkTerrorismDeclined).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(65, 138);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(92, 13);
    this.Label6.TabIndex = 32 /*0x20*/;
    this.Label6.Text = "Medical Payments";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.cboOcc.BorderStyle = (UIElementBorderStyle) 4;
    this.cboOcc.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboOcc).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionGL.OCC_ID", true));
    ((UltraGridBase) this.cboOcc).DataSource = (object) this.dvOcc;
    ((UltraDropDownBase) this.cboOcc).DisplayMember = "LimitDisplay";
    this.cboOcc.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboOcc.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboOcc).Location = new Point(168, 16 /*0x10*/);
    this.cboOcc.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboOcc).Name = "cboOcc";
    ((Control) this.cboOcc).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboOcc).TabIndex = 0;
    ((Control) this.cboOcc).Tag = (object) "r";
    ((UltraControlBase) this.cboOcc).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboOcc).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboOcc).ValueMember = "ID";
    this.dvOcc.RowFilter = "LimitCode='OCC'";
    this.dvOcc.Sort = "Limit";
    this.dvOcc.Table = (DataTable) this.ds.tblGLLimits;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(26, 162);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(129, 13);
    this.Label7.TabIndex = 33;
    this.Label7.Text = "Property Damage Liability";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(52, 186);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(102, 13);
    this.Label8.TabIndex = 34;
    this.Label8.Text = "Liquor Legal Liability";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.ucDeductible).Appearance = (AppearanceBase) appearance1;
    ((Control) this.ucDeductible).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionGL.Deductible", true));
    ((Control) this.ucDeductible).Location = new Point(168, 232);
    this.ucDeductible.MaxValue = new Decimal(new int[4]
    {
      9999999,
      0,
      0,
      0
    });
    this.ucDeductible.MinValue = new Decimal(new int[4]);
    ((Control) this.ucDeductible).Name = "ucDeductible";
    ((UltraNumericEditorBase) this.ucDeductible).PromptChar = ' ';
    ((Control) this.ucDeductible).Size = new Size(72, 20);
    ((Control) this.ucDeductible).TabIndex = 10;
    ((UltraControlBase) this.ucDeductible).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ucDeductible).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(27, 210);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(128 /*0x80*/, 13);
    this.Label9.TabIndex = 35;
    this.Label9.Text = "Non-Owned && Hired Auto";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(79, 234);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(78, 13);
    this.Label10.TabIndex = 36;
    this.Label10.Text = "Deductible/SIR";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    this.cboMedPay.BorderStyle = (UIElementBorderStyle) 4;
    this.cboMedPay.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboMedPay).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionGL.MED_ID", true));
    ((UltraGridBase) this.cboMedPay).DataSource = (object) this.dvMed;
    ((UltraDropDownBase) this.cboMedPay).DisplayMember = "LimitDisplay";
    this.cboMedPay.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboMedPay.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboMedPay).Location = new Point(168, 136);
    this.cboMedPay.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboMedPay).Name = "cboMedPay";
    ((Control) this.cboMedPay).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboMedPay).TabIndex = 6;
    ((Control) this.cboMedPay).Tag = (object) "r";
    ((UltraControlBase) this.cboMedPay).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboMedPay).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboMedPay).ValueMember = "ID";
    this.dvMed.RowFilter = "LimitCode='MED'";
    this.dvMed.Sort = "Limit";
    this.dvMed.Table = (DataTable) this.ds.tblGLLimits;
    this.cboAgg.BorderStyle = (UIElementBorderStyle) 4;
    this.cboAgg.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboAgg).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionGL.AGG_ID", true));
    ((UltraGridBase) this.cboAgg).DataSource = (object) this.dvAgg;
    ((UltraDropDownBase) this.cboAgg).DisplayMember = "LimitDisplay";
    this.cboAgg.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboAgg.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboAgg).Location = new Point(168, 40);
    this.cboAgg.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboAgg).Name = "cboAgg";
    ((Control) this.cboAgg).Size = new Size(160 /*0xA0*/, 21);
    ((Control) this.cboAgg).TabIndex = 1;
    ((Control) this.cboAgg).Tag = (object) "r";
    ((UltraControlBase) this.cboAgg).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboAgg).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboAgg).ValueMember = "ID";
    this.dvAgg.RowFilter = "LimitCode='AGG'";
    this.dvAgg.Sort = "Limit";
    this.dvAgg.Table = (DataTable) this.ds.tblGLLimits;
    ((Control) this.btnContinue).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    appearance2.ImageHAlign = (HAlign) 3;
    appearance2.ImageVAlign = (VAlign) 2;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((ControlBase) this.btnContinue).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnContinue).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnContinue).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnContinue).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnContinue).Location = new Point(322, 310);
    ((Control) this.btnContinue).Name = "btnContinue";
    ((ControlBase) this.btnContinue).Padding = new Size(5, 0);
    ((Control) this.btnContinue).Size = new Size(102, 40);
    ((Control) this.btnContinue).TabIndex = 3;
    ((Control) this.btnContinue).Tag = (object) "KeepActive";
    ((ControlBase) this.btnContinue).Text = "Exposure";
    this.btnContinue.UseOSThemes = (DefaultableBoolean) 2;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(208 /*0xD0*/, 310);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 5;
    this.dbSave.Tag = (object) "KeepActive";
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkAddMiscPremiums);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblTotalPremium);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtProducts);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtPremises);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtTerrorism);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label12);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label11);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label13);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label14);
    ((Control) this.UltraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(438, 365);
    this.lnkAddMiscPremiums.BackColor = Color.Transparent;
    this.lnkAddMiscPremiums.Location = new Point(216, 88);
    this.lnkAddMiscPremiums.Name = "lnkAddMiscPremiums";
    this.lnkAddMiscPremiums.Size = new Size(128 /*0x80*/, 23);
    this.lnkAddMiscPremiums.TabIndex = 20;
    this.lnkAddMiscPremiums.TabStop = true;
    this.lnkAddMiscPremiums.Text = "(add misc. premiums)";
    this.lnkAddMiscPremiums.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkAddMiscPremiums.Visible = false;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ((AppearanceBase) appearance3).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblTotalPremium).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.lblTotalPremium).BackColorInternal = Color.WhiteSmoke;
    this.lblTotalPremium.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblTotalPremium).Location = new Point(120, 88);
    ((Control) this.lblTotalPremium).Name = "lblTotalPremium";
    ((Control) this.lblTotalPremium).Size = new Size(88, 23);
    ((Control) this.lblTotalPremium).TabIndex = 19;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtProducts).Appearance = (AppearanceBase) appearance4;
    ((Control) this.txtProducts).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionGL.ProdPremium", true));
    ((UltraNumericEditorBase) this.txtProducts).FormatString = "c";
    ((Control) this.txtProducts).Location = new Point(120, 16 /*0x10*/);
    this.txtProducts.MaskInput = "-nnn,nnn,nnn.nn";
    this.txtProducts.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtProducts).Name = "txtProducts";
    this.txtProducts.NumericType = (NumericType) 1;
    ((Control) this.txtProducts).Size = new Size(88, 20);
    ((Control) this.txtProducts).TabIndex = 18;
    ((UltraControlBase) this.txtProducts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducts).UseOsThemes = (DefaultableBoolean) 2;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtPremises).Appearance = (AppearanceBase) appearance5;
    ((Control) this.txtPremises).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionGL.PremPremium", true));
    ((UltraNumericEditorBase) this.txtPremises).FormatString = "c";
    ((Control) this.txtPremises).Location = new Point(120, 40);
    this.txtPremises.MaskInput = "-nnn,nnn,nnn.nn";
    this.txtPremises.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPremises).Name = "txtPremises";
    this.txtPremises.NumericType = (NumericType) 1;
    ((Control) this.txtPremises).Size = new Size(88, 20);
    ((Control) this.txtPremises).TabIndex = 17;
    ((UltraControlBase) this.txtPremises).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPremises).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtTerrorism).Appearance = (AppearanceBase) appearance6;
    ((Control) this.txtTerrorism).CausesValidation = false;
    ((Control) this.txtTerrorism).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionGL.TerrPremium", true));
    ((UltraNumericEditorBase) this.txtTerrorism).FormatString = "c";
    ((Control) this.txtTerrorism).Location = new Point(120, 64 /*0x40*/);
    this.txtTerrorism.MaskInput = "-nnn,nnn,nnn.nn";
    this.txtTerrorism.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtTerrorism).Name = "txtTerrorism";
    this.txtTerrorism.NumericType = (NumericType) 1;
    ((Control) this.txtTerrorism).Size = new Size(88, 20);
    ((Control) this.txtTerrorism).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.txtTerrorism).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTerrorism).UseOsThemes = (DefaultableBoolean) 2;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(34, 88);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(74, 13);
    this.Label12.TabIndex = 14;
    this.Label12.Text = "Total Premium";
    this.Label12.TextAlign = ContentAlignment.MiddleRight;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(92, 13);
    this.Label11.TabIndex = 8;
    this.Label11.Text = "Products Premium";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(11, 64 /*0x40*/);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(95, 13);
    this.Label13.TabIndex = 12;
    this.Label13.Text = "Terrorism Premium";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(15, 40);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(92, 13);
    this.Label14.TabIndex = 10;
    this.Label14.Text = "Premises Premium";
    this.Label14.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lnkFCW);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label15);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtAdditionalComments);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(438, 365);
    this.lnkFCW.AutoSize = true;
    this.lnkFCW.BackColor = Color.Transparent;
    this.lnkFCW.Location = new Point(8, 280);
    this.lnkFCW.Name = "lnkFCW";
    this.lnkFCW.Size = new Size(291, 13);
    this.lnkFCW.TabIndex = 6;
    this.lnkFCW.TabStop = true;
    this.lnkFCW.Tag = (object) "KeepActive";
    this.lnkFCW.Text = "Click here to add forms/conditions/warranties to this policy.";
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(8, 8);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(111, 13);
    this.Label15.TabIndex = 5;
    this.Label15.Text = "Additional Comments:";
    this.txtAdditionalComments.AcceptsReturn = true;
    ((Control) this.txtAdditionalComments).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.Gray;
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAdditionalComments).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.txtAdditionalComments).BackColor = Color.White;
    ((Control) this.txtAdditionalComments).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuoteOptionGL.AdditionalComments", true));
    ((Control) this.txtAdditionalComments).Location = new Point(8, 32 /*0x20*/);
    this.txtAdditionalComments.Multiline = true;
    ((Control) this.txtAdditionalComments).Name = "txtAdditionalComments";
    ((Control) this.txtAdditionalComments).Size = new Size(418, 235);
    ((Control) this.txtAdditionalComments).TabIndex = 4;
    ((UltraControlBase) this.txtAdditionalComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAdditionalComments).UseOsThemes = (DefaultableBoolean) 2;
    this.daLimits.SelectCommand = this.SqlSelectCommand1;
    this.daLimits.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblGLLimits", new DataColumnMapping[3]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("LimitCode", "LimitCode"),
        new DataColumnMapping("Limit", "Limit")
      })
    });
    this.SqlSelectCommand1.CommandText = "SELECT ID, LimitCode, Limit, LimitDisplay FROM tblGLLimits ORDER BY Limit";
    this.SqlSelectCommand1.Connection = this.cn;
    this.cn.ConnectionString = "workstation id=PSARNOWSKI2;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.daDeductibleDescriptions.SelectCommand = this.SqlSelectCommand2;
    this.daDeductibleDescriptions.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstGLDeductibleDescriptions", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("DeductibleDescription", "DeductibleDescription")
      })
    });
    this.SqlSelectCommand2.CommandText = "SELECT ID, DeductibleDescription FROM lstGLDeductibleDescriptions ORDER BY DeductibleDescription";
    this.SqlSelectCommand2.Connection = this.cn;
    ((Control) this.ugOptions).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugOptions).Cursor = Cursors.Default;
    ((UltraGridBase) this.ugOptions).DataSource = (object) this.ds.tblQuoteOptions;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugOptions).DisplayLayout.Appearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugOptions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ultraGridColumn1.CellAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Option ID";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 94;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    appearance11.ForeColor = Color.Green;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance11;
    ultraGridColumn5.Format = "c";
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance12;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridBand1.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn9.Header.VisiblePosition = 2;
    ultraGridColumn10.Header.VisiblePosition = 3;
    ultraGridColumn11.Header.VisiblePosition = 4;
    ultraGridColumn12.Header.VisiblePosition = 5;
    ultraGridColumn13.Header.VisiblePosition = 6;
    ultraGridColumn14.Header.VisiblePosition = 7;
    ultraGridColumn15.Header.VisiblePosition = 8;
    ultraGridColumn16.Header.VisiblePosition = 9;
    ultraGridColumn17.Header.VisiblePosition = 10;
    ultraGridColumn18.Header.VisiblePosition = 11;
    ultraGridColumn19.Header.VisiblePosition = 12;
    ultraGridColumn20.Header.VisiblePosition = 13;
    ultraGridColumn21.Header.VisiblePosition = 14;
    ultraGridColumn22.Header.VisiblePosition = 15;
    ultraGridColumn23.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn24.Header.VisiblePosition = 17;
    ultraGridColumn25.Header.VisiblePosition = 18;
    ultraGridColumn26.Header.VisiblePosition = 19;
    ultraGridColumn27.Header.VisiblePosition = 20;
    ultraGridBand2.Columns.AddRange(new object[21]
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
      (object) ultraGridColumn27
    });
    ((UltraGridBase) this.ugOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugOptions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance13.BackColor = Color.LightSteelBlue;
    appearance13.FontData.SizeInPoints = 10f;
    appearance13.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOptions).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance15.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance15;
    appearance16.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance17.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance17;
    appearance18.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance19.BackColor = Color.Transparent;
    appearance19.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOptions).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance19;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugOptions).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ugOptions).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugOptions).Location = new Point(8, 8);
    ((Control) this.ugOptions).Name = "ugOptions";
    ((Control) this.ugOptions).Size = new Size(440, 112 /*0x70*/);
    ((Control) this.ugOptions).TabIndex = 0;
    ((UltraControlBase) this.ugOptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugOptions).UseOsThemes = (DefaultableBoolean) 2;
    this.daOptions.DeleteCommand = this.SqlDeleteCommand1;
    this.daOptions.InsertCommand = this.SqlInsertCommand1;
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
    this.daOptions.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = componentResourceManager.GetString("SqlDeleteCommand1.CommandText");
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@Original_QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Premium", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Premium", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_QuoteOptionID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGUID"),
      new SqlParameter("@QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID")
    });
    this.SqlSelectCommand3.CommandText = "SELECT QuoteOptionID, QuoteOptionGUID, QuoteGUID, LineGUID, Premium FROM tblQuoteOptions WHERE (QuoteGUID = @QuoteGuid) AND (LineGuid = @LineGuid)";
    this.SqlSelectCommand3.Connection = this.cn;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGuid")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGUID"),
      new SqlParameter("@QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID"),
      new SqlParameter("@Original_QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteGUID", DataRowVersion.Original, (object) null)
    });
    this.daOptionsGL.DeleteCommand = this.SqlDeleteCommand2;
    this.daOptionsGL.InsertCommand = this.SqlInsertCommand2;
    this.daOptionsGL.SelectCommand = this.SqlSelectCommand4;
    this.daOptionsGL.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteOptionGL", new DataColumnMapping[20]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("OCC_ID", "OCC_ID"),
        new DataColumnMapping("AGG_ID", "AGG_ID"),
        new DataColumnMapping("PCO_ID", "PCO_ID"),
        new DataColumnMapping("PAI_ID", "PAI_ID"),
        new DataColumnMapping("FDL_ID", "FDL_ID"),
        new DataColumnMapping("MED_ID", "MED_ID"),
        new DataColumnMapping("LLL_ID", "LLL_ID"),
        new DataColumnMapping("NOH_ID", "NOH_ID"),
        new DataColumnMapping("PDL_ID", "PDL_ID"),
        new DataColumnMapping("Deductible", "Deductible"),
        new DataColumnMapping("DeductibleDescriptionID", "DeductibleDescriptionID"),
        new DataColumnMapping("AggPerLocation", "AggPerLocation"),
        new DataColumnMapping("TerrorismDeclined", "TerrorismDeclined"),
        new DataColumnMapping("QuoteOptionID", "QuoteOptionID"),
        new DataColumnMapping("AdditionalComments", "AdditionalComments"),
        new DataColumnMapping("PremPremium", "PremPremium"),
        new DataColumnMapping("ProdPremium", "ProdPremium"),
        new DataColumnMapping("TerrPremium", "TerrPremium"),
        new DataColumnMapping("ClaimsMade", "ClaimsMade")
      })
    });
    this.daOptionsGL.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM tblQuoteOptionGL WHERE (ID = @Original_ID)";
    this.SqlDeleteCommand2.Connection = this.cn;
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = componentResourceManager.GetString("SqlInsertCommand2.CommandText");
    this.SqlInsertCommand2.Connection = this.cn;
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[19]
    {
      new SqlParameter("@OCC_ID", SqlDbType.TinyInt, 1, "OCC_ID"),
      new SqlParameter("@AGG_ID", SqlDbType.TinyInt, 1, "AGG_ID"),
      new SqlParameter("@PCO_ID", SqlDbType.TinyInt, 1, "PCO_ID"),
      new SqlParameter("@PAI_ID", SqlDbType.TinyInt, 1, "PAI_ID"),
      new SqlParameter("@FDL_ID", SqlDbType.TinyInt, 1, "FDL_ID"),
      new SqlParameter("@MED_ID", SqlDbType.TinyInt, 1, "MED_ID"),
      new SqlParameter("@LLL_ID", SqlDbType.TinyInt, 1, "LLL_ID"),
      new SqlParameter("@NOH_ID", SqlDbType.TinyInt, 1, "NOH_ID"),
      new SqlParameter("@PDL_ID", SqlDbType.TinyInt, 1, "PDL_ID"),
      new SqlParameter("@Deductible", SqlDbType.Int, 4, "Deductible"),
      new SqlParameter("@DeductibleDescriptionID", SqlDbType.TinyInt, 1, "DeductibleDescriptionID"),
      new SqlParameter("@AggPerLocation", SqlDbType.Bit, 1, "AggPerLocation"),
      new SqlParameter("@TerrorismDeclined", SqlDbType.Bit, 1, "TerrorismDeclined"),
      new SqlParameter("@QuoteOptionID", SqlDbType.Int, 4, "QuoteOptionID"),
      new SqlParameter("@AdditionalComments", SqlDbType.VarChar, 5000, "AdditionalComments"),
      new SqlParameter("@PremPremium", SqlDbType.Money, 8, "PremPremium"),
      new SqlParameter("@ProdPremium", SqlDbType.Money, 8, "ProdPremium"),
      new SqlParameter("@TerrPremium", SqlDbType.Money, 8, "TerrPremium"),
      new SqlParameter("@ClaimsMade", SqlDbType.Bit, 1, "ClaimsMade")
    });
    this.SqlSelectCommand4.CommandText = componentResourceManager.GetString("SqlSelectCommand4.CommandText");
    this.SqlSelectCommand4.Connection = this.cn;
    this.SqlSelectCommand4.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID")
    });
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Connection = this.cn;
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[21]
    {
      new SqlParameter("@OCC_ID", SqlDbType.TinyInt, 1, "OCC_ID"),
      new SqlParameter("@AGG_ID", SqlDbType.TinyInt, 1, "AGG_ID"),
      new SqlParameter("@PCO_ID", SqlDbType.TinyInt, 1, "PCO_ID"),
      new SqlParameter("@PAI_ID", SqlDbType.TinyInt, 1, "PAI_ID"),
      new SqlParameter("@FDL_ID", SqlDbType.TinyInt, 1, "FDL_ID"),
      new SqlParameter("@MED_ID", SqlDbType.TinyInt, 1, "MED_ID"),
      new SqlParameter("@LLL_ID", SqlDbType.TinyInt, 1, "LLL_ID"),
      new SqlParameter("@NOH_ID", SqlDbType.TinyInt, 1, "NOH_ID"),
      new SqlParameter("@PDL_ID", SqlDbType.TinyInt, 1, "PDL_ID"),
      new SqlParameter("@Deductible", SqlDbType.Int, 4, "Deductible"),
      new SqlParameter("@DeductibleDescriptionID", SqlDbType.TinyInt, 1, "DeductibleDescriptionID"),
      new SqlParameter("@AggPerLocation", SqlDbType.Bit, 1, "AggPerLocation"),
      new SqlParameter("@TerrorismDeclined", SqlDbType.Bit, 1, "TerrorismDeclined"),
      new SqlParameter("@QuoteOptionID", SqlDbType.Int, 4, "QuoteOptionID"),
      new SqlParameter("@AdditionalComments", SqlDbType.VarChar, 5000, "AdditionalComments"),
      new SqlParameter("@PremPremium", SqlDbType.Money, 8, "PremPremium"),
      new SqlParameter("@ProdPremium", SqlDbType.Money, 8, "ProdPremium"),
      new SqlParameter("@TerrPremium", SqlDbType.Money, 8, "TerrPremium"),
      new SqlParameter("@ClaimsMade", SqlDbType.Bit, 1, "ClaimsMade"),
      new SqlParameter("@Original_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.tabOptionInfo);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Location = new Point(8, 128 /*0x80*/);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControls.AddRange(new Control[2]
    {
      (Control) this.btnContinue,
      (Control) this.dbSave
    });
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(440, 392);
    ((Control) this.UltraTabControl1).TabIndex = 4;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.UltraTabControl1).TabPadding = new Size(5, 3);
    appearance20.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance20.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance20;
    ultraTab1.TabPage = this.tabOptionInfo;
    ultraTab1.Text = "Option Info";
    appearance21.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance21.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance21;
    ultraTab2.TabPage = this.UltraTabPageControl1;
    ultraTab2.Text = "Premiums";
    appearance22.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance22.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance22;
    ultraTab3.TabPage = this.UltraTabPageControl2;
    ultraTab3.Text = "Additional Items";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[3]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(145, 0);
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnContinue);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(438, 365);
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(456, 534);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Controls.Add((Control) this.ugOptions);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmGLRater);
    this.Text = "IMS General Liability Rater";
    this.Controls.SetChildIndex((Control) this.ugOptions, 0);
    this.Controls.SetChildIndex((Control) this.UltraTabControl1, 0);
    ((Control) this.tabOptionInfo).ResumeLayout(false);
    ((Control) this.tabOptionInfo).PerformLayout();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboPDL).EndInit();
    this.dvPDL.EndInit();
    ((ISupportInitialize) this.cboPCO).EndInit();
    this.dvPCO.EndInit();
    ((ISupportInitialize) this.cboLLL).EndInit();
    this.dvLLL.EndInit();
    ((ISupportInitialize) this.cboPAI).EndInit();
    this.dvPAI.EndInit();
    ((ISupportInitialize) this.cboNOH).EndInit();
    this.dvNOH.EndInit();
    ((ISupportInitialize) this.cboFDL).EndInit();
    this.dvFDL.EndInit();
    ((ISupportInitialize) this.cboDeductibleDescriptions).EndInit();
    ((ISupportInitialize) this.cboOcc).EndInit();
    this.dvOcc.EndInit();
    ((ISupportInitialize) this.ucDeductible).EndInit();
    ((ISupportInitialize) this.cboMedPay).EndInit();
    this.dvMed.EndInit();
    ((ISupportInitialize) this.cboAgg).EndInit();
    this.dvAgg.EndInit();
    ((ISupportInitialize) this.btnContinue).EndInit();
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.txtProducts).EndInit();
    ((ISupportInitialize) this.txtPremises).EndInit();
    ((ISupportInitialize) this.txtTerrorism).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.txtAdditionalComments).EndInit();
    ((ISupportInitialize) this.ugOptions).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public frmGLRater()
  {
    this.Load += new EventHandler(this.frmGLRater_Load);
    this.Activated += new EventHandler(this.frmGLRater_Activated);
    this.InitializeComponent();
    this._strikeoutFont = new Font(((Control) this.txtTerrorism).Font, FontStyle.Strikeout);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._strikeoutFont != null)
        this._strikeoutFont.Dispose();
      this.cboOcc.ValueChanged += new EventHandler(this.cboOcc_SelectedIndexChanged);
      this.Rater.OptionRated += new OptionRatedEventHandler(this.OptionRated);
      this.Rater.OptionRated -= new OptionRatedEventHandler(this.OptionRated);
    }
    base.Dispose(disposing);
  }

  private GLRater GLRater => (GLRater) this.Rater;

  public BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblQuoteOptionGL.TableName];
  }

  public int QuoteOptionID => this.ds.tblQuoteOptionGL[this.bmb.Position].QuoteOptionID;

  public dsGLRater BaseDataSet => this.ds;

  private void frmGLRater_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.bmb.SuspendBinding();
    this.daOptions.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this.Rater.QuoteGuid;
    this.daOptions.SelectCommand.Parameters["@LineGuid"].Value = (object) this.Rater.LineGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daOptions, (DataTable) this.ds.tblQuoteOptions);
    this.daOptionsGL.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this.Rater.QuoteGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daOptionsGL, (DataTable) this.ds.tblQuoteOptionGL);
    this.ds.lstGLDeductibleDescriptions.AddlstGLDeductibleDescriptionsRow(-1, string.Empty);
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daDeductibleDescriptions, (DataTable) this.ds.lstGLDeductibleDescriptions);
    dsGLRater.tblGLLimitsRow row = this.ds.tblGLLimits.NewtblGLLimitsRow();
    row.SetIDNull();
    row.Limit = 0;
    row.LimitCode = string.Empty;
    row.LimitDisplay = string.Empty;
    this.ds.tblGLLimits.AddtblGLLimitsRow(row);
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLimits, (DataTable) this.ds.tblGLLimits);
    this.daLimits.Dispose();
    this.daLimits = (SqlDataAdapter) null;
    bool flag = true;
    if (this.ds.tblQuoteOptions.Rows.Count != this.ds.tblQuoteOptionGL.Count)
    {
      int num = (int) MessageBox.Show("The GL options on this policy are not valid.\n\nIf this policy was originally rated with the generic premium capture,\nchange back to that rater, remove all options, and return to the GL rater.", "Invalid Options", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    ((Control) this.btnContinue).Enabled = this.ds.tblQuoteOptions.Count > 0 && flag;
    if (this.ds.tblQuoteOptions.Count > 0)
    {
      ((UltraGridBase) this.ugOptions).Rows[0].Activate();
      ((UltraGridBase) this.ugOptions).Rows[0].Selected = true;
    }
    this.dbSave.UIState = this.ds.tblQuoteOptionGL.Count != 0 ? UIState.HasRecordsNotEditing : UIState.NoRecordsNotEditing;
    this.SetControlsEnabled();
    this.dbSave.Enabled = !new Quote(this.Rater.QuoteGuid).IsBound && flag;
  }

  private void frmGLRater_Activated(object sender, EventArgs e)
  {
    if (this._activated)
      return;
    this._activated = true;
    this.cboOcc.ValueChanged += new EventHandler(this.cboOcc_SelectedIndexChanged);
    this.Rater.OptionRated += new OptionRatedEventHandler(this.OptionRated);
    this.bmb.ResumeBinding();
  }

  private void lnkFCW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowForm(typeof (frmPolicyFCW), (object) this.Rater.Quote.QuoteID);
  }

  private static Decimal IsNull(string str)
  {
    return Versioned.IsNumeric((object) str) ? Conversions.ToDecimal(str) : 0M;
  }

  private void lnkAddMiscPremiums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowFormDialog(typeof (frmMiscPremiums), (object) this.QuoteOptionID);
  }

  private void UpdatePremiumValues(object sender, EventArgs e)
  {
    if (this.bmb.Position < 0 || this.ds.tblQuoteOptionGL.Count == 0)
      return;
    Decimal d2_1 = 0M;
    Decimal d1 = 0M;
    Decimal d2_2 = 0M;
    if (!this.ds.tblQuoteOptionGL[this.bmb.Position].TerrorismDeclined && this.txtTerrorism.Value != DBNull.Value && this.txtTerrorism.Value != null)
      d2_1 = Conversions.ToDecimal(this.txtTerrorism.Value);
    if (this.txtProducts.Value != DBNull.Value && this.txtProducts.Value != null)
      d1 = Conversions.ToDecimal(this.txtProducts.Value);
    if (this.txtPremises.Value != DBNull.Value && this.txtPremises.Value != null)
      d2_2 = Conversions.ToDecimal(this.txtPremises.Value);
    ((ControlBase) this.lblTotalPremium).Text = Strings.FormatCurrency((object) Decimal.Add(Decimal.Add(d1, d2_2), d2_1));
    MGANumericEditor mgaNumericEditor = (MGANumericEditor) sender;
    if (mgaNumericEditor.Value != DBNull.Value && Decimal.Compare(Conversions.ToDecimal(mgaNumericEditor.Value), 0M) < 0)
      ((UltraNumericEditorBase) mgaNumericEditor).Appearance.ForeColor = Color.Red;
    else
      ((UltraNumericEditorBase) mgaNumericEditor).Appearance.ForeColor = Color.Black;
  }

  private void OptionRated(object sender, OptionRatedEventArgs e)
  {
    this.ds.tblQuoteOptions.FindByQuoteOptionID(e.QuoteOption.QuoteOptionID).Premium = DefaultDatabase.ExecuteScalar<Decimal>(CommandType.Text, "SELECT Premium FROM tblQuoteOptions WHERE QuoteOptionID=@QOID", new object[2]
    {
      (object) "@QOID",
      (object) e.QuoteOption.QuoteOptionID
    });
  }

  private void btnContinue_Click(object sender, EventArgs e)
  {
    if (this.ds.tblQuoteOptions.Count > 1 && ((UltraGridBase) this.ugOptions).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select an option in the grid to continue.\n\nThis will be used to determine the class codes on the new option.", "Option Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      FormSettings.ShowFormDialog(typeof (frmGLRater_Exposure), (object) (int) ((UltraGridBase) this.ugOptions).ActiveRow.Cells["QuoteOptionID"].Value, (object) (GLRater) this.Rater).Dispose();
  }

  private void SetControlsEnabled()
  {
    bool flag = this.dbSave.UIState == UIState.Editing;
    ((Control) this.ugOptions).Enabled = !flag;
    ((Control) this.btnContinue).Enabled = !flag && this.ds.tblQuoteOptionGL.Count > 0;
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
        {
          if (control.Tag == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Tag.ToString(), "KeepActive", false) != 0)
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
    if (flag)
      return;
    if (this.ds.tblQuoteOptionGL.Count == 0)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e) => this.SetControlsEnabled();

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    BindingManagerBase bmb;
    int num = (bmb = this.bmb).Position - 1;
    bmb.Position = num;
    try
    {
      this.ds.tblQuoteOptionGL.RejectChanges();
      this.ds.tblQuoteOptions.RejectChanges();
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    ((Control) this.btnContinue).Enabled = this.ds.tblQuoteOptions.Rows.Count > 0;
    if (this.ds.tblQuoteOptionGL.Count == 0)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    this.ClientCancel();
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    dsGLRater.tblQuoteOptionsRow row1 = this.ds.tblQuoteOptions.NewtblQuoteOptionsRow();
    row1.QuoteGUID = this.Rater.QuoteGuid;
    row1.QuoteOptionGUID = Guid.NewGuid();
    row1.LineGUID = this.Rater.LineGuid;
    this.ds.tblQuoteOptions.AddtblQuoteOptionsRow(row1);
    dsGLRater.tblQuoteOptionGLRow row2 = this.ds.tblQuoteOptionGL.NewtblQuoteOptionGLRow();
    row2.QuoteOptionID = row1.QuoteOptionID;
    object objectValue = RuntimeHelpers.GetObjectValue(frmGLRater.GetCompanyLineAdditionalComments(this.Rater.QuoteGuid));
    if (objectValue == DBNull.Value)
      row2.SetAdditionalCommentsNull();
    else
      row2.AdditionalComments = objectValue.ToString();
    this.ds.tblQuoteOptionGL.AddtblQuoteOptionGLRow(row2);
    this.bmb.Position = this.ds.tblQuoteOptionGL.Rows.Count - 1;
    try
    {
      foreach (Control control in ((Control) this.tabOptionInfo).Controls)
      {
        if (control is ComboBox)
        {
          ((ComboBox) control).SelectedIndex = -1;
          ((ComboBox) control).SelectedIndex = -1;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.ClientNew();
  }

  private static object GetCompanyLineAdditionalComments(Guid quoteGuid)
  {
    return DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT QuoteAdditionalComments FROM tblCompanyLines WITH(NOLOCK) WHERE CompanyLineGUID = dbo.GetQuoteCompanyLineGuid(@QG)", new object[2]
    {
      (object) "@QG",
      (object) quoteGuid
    });
  }

  private static bool NoItemSelected(MGASimpleComboBox cbo)
  {
    return ((UltraDropDownBase) cbo).SelectedRow == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraDropDownBase) cbo).SelectedRow.Cells[((UltraDropDownBase) cbo).DisplayMember].Value.ToString(), string.Empty, false) == 0;
  }

  private bool ValidForm()
  {
    bool flag1 = true;
    try
    {
      foreach (Control control in ((Control) this.tabOptionInfo).Controls)
      {
        if (control is MGASimpleComboBox)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Text, string.Empty, false) == 0 && control.Tag != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Tag.ToString(), "r", false) == 0)
          {
            this.err.SetError(control, "Please select a limit.");
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
    if (Decimal.Compare(this.ucDeductible.Value, 0M) != 0 && frmGLRater.NoItemSelected(this.cboDeductibleDescriptions))
    {
      this.err.SetError((Control) this.cboDeductibleDescriptions, "Please select a deductible description.");
      flag1 = false;
    }
    else
      this.err.SetError((Control) this.cboDeductibleDescriptions, string.Empty);
    bool flag2;
    if (!flag1)
    {
      ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[0];
      flag2 = false;
    }
    else
    {
      if (!Versioned.IsNumeric((object) ((UltraWinEditorMaskedControlBase) this.txtProducts).Text))
      {
        this.err.SetError((Control) this.txtProducts, "Please enter a valid premium amount.");
        flag1 = false;
      }
      else
        this.err.SetError((Control) this.txtProducts, string.Empty);
      if (flag1)
        flag1 = this.IsValidPremisesPremium();
      if (flag1)
        flag1 = this.IsValidTerrorismPremium();
      if (!flag1)
      {
        ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[1];
        flag2 = false;
      }
      else
        flag2 = flag1;
    }
    return flag2;
  }

  protected virtual bool IsValidTerrorismPremium()
  {
    bool flag = true;
    if (!Versioned.IsNumeric((object) ((UltraWinEditorMaskedControlBase) this.txtTerrorism).Text))
    {
      this.err.SetError((Control) this.txtTerrorism, "Please enter a valid premium amount.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtTerrorism, string.Empty);
    return flag;
  }

  protected virtual bool IsValidPremisesPremium()
  {
    bool flag = true;
    if (!Versioned.IsNumeric((object) ((UltraWinEditorMaskedControlBase) this.txtPremises).Text))
    {
      this.err.SetError((Control) this.txtPremises, "Please enter a valid premium amount.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtPremises, string.Empty);
    return flag;
  }

  private void SaveData()
  {
    frmGLRater frmGlRater = this;
    this.bmb.EndCurrentEdit();
    if (this.bmb.Position != -1 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboDeductibleDescriptions.Text, string.Empty, false) == 0 && this.ds.tblQuoteOptionGL[this.bmb.Position].RowState != DataRowState.Deleted)
      this.ds.tblQuoteOptionGL[this.bmb.Position].SetDeductibleDescriptionIDNull();
    int num;
    bool flag;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
    {
      try
      {
        frmGlRater.Cursor = MgaCursors.WaitCursor;
        bool flag1 = frmGlRater.bmb.Position != -1 && frmGlRater.ds.tblQuoteOptionGL[frmGlRater.bmb.Position].RowState == DataRowState.Added;
        SqlDataAdapter daOptions = frmGlRater.daOptions;
        daOptions.DeleteCommand.Transaction = (SqlTransaction) args.Transaction;
        daOptions.UpdateCommand.Transaction = (SqlTransaction) args.Transaction;
        daOptions.InsertCommand.Transaction = (SqlTransaction) args.Transaction;
        daOptions.SelectCommand.Transaction = (SqlTransaction) args.Transaction;
        SqlDataAdapter daOptionsGl = frmGlRater.daOptionsGL;
        daOptionsGl.DeleteCommand.Transaction = (SqlTransaction) args.Transaction;
        daOptionsGl.UpdateCommand.Transaction = (SqlTransaction) args.Transaction;
        daOptionsGl.InsertCommand.Transaction = (SqlTransaction) args.Transaction;
        daOptionsGl.SelectCommand.Transaction = (SqlTransaction) args.Transaction;
        MDIControls.Instance.StatusBarText = "Deleting GL Limits...";
        frmGlRater.daOptionsGL.Update(frmGlRater.ds.tblQuoteOptionGL.Select(string.Empty, string.Empty, DataViewRowState.Deleted));
        MDIControls.Instance.StatusBarText = "Saving quote option information...";
        if (flag1)
        {
          dsGLRater.tblQuoteOptionsRow byQuoteOptionId = frmGlRater.ds.tblQuoteOptions.FindByQuoteOptionID(frmGlRater.ds.tblQuoteOptionGL[frmGlRater.bmb.Position].QuoteOptionID);
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) frmGlRater.daOptions, (DataTable) frmGlRater.ds.tblQuoteOptions);
          frmGlRater.ds.tblQuoteOptionGL[frmGlRater.bmb.Position].QuoteOptionID = byQuoteOptionId.QuoteOptionID;
        }
        else
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) frmGlRater.daOptions, (DataTable) frmGlRater.ds.tblQuoteOptions);
        MDIControls.Instance.StatusBarText = "Saving GL Limits...";
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) frmGlRater.daOptionsGL, (DataTable) frmGlRater.ds.tblQuoteOptionGL);
        if (frmGlRater.ds.tblQuoteOptions.Rows.Count > 1 && flag1)
        {
          int quoteOptionId = frmGlRater.ds.tblQuoteOptionGL[frmGlRater.bmb.Position].QuoteOptionID;
          MDIControls.Instance.StatusBarText = "Copying exposure information...";
          num = DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.CopyGLExposureInformation", 180, (CommandArgumentType) 2, new object[4]
          {
            (object) "@oldOptionID",
            (object) frmGlRater.ds.tblQuoteOptions[0].QuoteOptionID,
            (object) "@newOptionID",
            (object) quoteOptionId
          });
          frmGlRater.ClientSave((SqlTransaction) args.Transaction);
          args.Transaction.Commit();
          flag = true;
        }
        else
        {
          frmGlRater.ClientSave((SqlTransaction) args.Transaction);
          args.Transaction.Commit();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        if (!flag)
          args.Transaction.Rollback();
        throw;
      }
    }));
    if (num > 0)
    {
      int num1 = (int) MessageBox.Show($"The option was saved succesfully.\n\n{num.ToString()} rows of exposure information were copied.", "Option Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    QuoteOption quoteOption = new QuoteOption(this.QuoteOptionID);
    this.GLRater.RefreshPremiums(quoteOption);
    MDIControls.Instance.StatusBarText = "Rating option...";
    this.Rater.RateOption(quoteOption.QuoteOptionGuid);
    MDIControls.Instance.StatusBarText = "Refreshing premium...";
    this.ds.tblQuoteOptions.FindByQuoteOptionID(this.QuoteOptionID).Premium = DefaultDatabase.ExecuteScalar<Decimal>(CommandType.Text, "SELECT Premium FROM tblQuoteOptions WHERE QuoteOptionID=@QOID", new object[2]
    {
      (object) "@QOID",
      (object) this.QuoteOptionID
    });
    this.Cursor = MgaCursors.Default;
    MDIControls.Instance.StatusBarText = string.Empty;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.ValidForm())
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        int quoteOptionId = this.ds.tblQuoteOptionGL[this.bmb.Position].QuoteOptionID;
        this.SaveData();
        this.ugOptions.Selected.Rows.Clear();
        RowEnumerator enumerator = ((UltraGridBase) this.ugOptions).Rows.GetEnumerator();
        while (enumerator.MoveNext())
        {
          UltraGridRow current = enumerator.Current;
          if ((int) current.Cells["QuoteOptionID"].Value == quoteOptionId)
          {
            current.Selected = true;
            Database.MoveTo((object) quoteOptionId, this.ds.tblQuoteOptions.QuoteOptionIDColumn.ColumnName, (DataTable) this.ds.tblQuoteOptions, this.bmb);
          }
        }
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
    else
      e.Cancel = true;
  }

  private void ugOptions_AfterRowActivate(object sender, EventArgs e)
  {
    Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugOptions).ActiveRow.Cells["QuoteOptionID"].Value), this.ds.tblQuoteOptions.QuoteOptionIDColumn.ColumnName, (DataTable) this.ds.tblQuoteOptions, this.bmb);
    if (((UltraToggleEditorBase) this.chkTerrorismDeclined).Checked)
    {
      ((Control) this.txtTerrorism).Font = this._strikeoutFont;
      ((UltraNumericEditorBase) this.txtTerrorism).ForeColor = Color.Red;
    }
    else
    {
      ((Control) this.txtTerrorism).Font = ((Control) this.txtProducts).Font;
      ((UltraNumericEditorBase) this.txtTerrorism).ForeColor = ((UltraNumericEditorBase) this.txtProducts).ForeColor;
    }
    this.ClientAfterRowActive();
  }

  private object DeleteOption(object sender, ExecuteTransactionEventArgs e)
  {
    int quoteOptionId = this.ds.tblQuoteOptionGL[this.bmb.Position].QuoteOptionID;
    object obj;
    try
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET InstallmentBillingQuoteOptionID = NULL WHERE InstallmentBillingQuoteOptionID=@quoteOptionID", new object[2]
      {
        (object) "@quoteOptionID",
        (object) quoteOptionId
      });
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteOptions WHERE QuoteOptionID=@quoteOptionID", new object[2]
      {
        (object) "@quoteOptionID",
        (object) quoteOptionId
      });
    }
    catch (SqlException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      SqlException ex2 = ex1;
      if (ex2.Message.Contains("FK_tblPolicyCommissions_tblQuoteOptionCharges"))
      {
        int num = (int) MessageBox.Show("A commissionable entity exists on the option you are trying to remove.\n\nPlease remove this entity before deleting the option.", "Commissions Established", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        obj = (object) null;
        ProjectData.ClearProjectError();
        goto label_10;
      }
      ErrorHandler.HandleError((Exception) ex2);
      obj = (object) null;
      ProjectData.ClearProjectError();
      goto label_10;
    }
    try
    {
      this.ds.tblQuoteOptions.FindByQuoteOptionID(quoteOptionId).Delete();
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    this.ds.tblQuoteOptions.AcceptChanges();
    this.ds.tblQuoteOptionGL.AcceptChanges();
    if (this.ds.tblQuoteOptions.Count > 0)
      this.bmb.Position = 0;
    obj = (object) null;
label_10:
    return obj;
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1 || this.ds.tblQuoteOptionGL[this.bmb.Position].RowState == DataRowState.Deleted)
      return;
    if (MessageBox.Show("Are you sure you want to delete this option?", "Delete Option?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
    {
      try
      {
        DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
        {
          this.DeleteOption(RuntimeHelpers.GetObjectValue(obj), args);
          args.Transaction.Commit();
        }));
        ((Control) this.btnContinue).Enabled = this.ds.tblQuoteOptions.Rows.Count > 0;
        if (this.ds.tblQuoteOptions.Rows.Count > 0)
        {
          this.bmb.Position = 0;
          ((UltraGridBase) this.ugOptions).ActiveRow = ((UltraGridBase) this.ugOptions).Rows[0];
          ((UltraGridBase) this.ugOptions).Rows[0].Selected = true;
        }
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleError((Exception) ex);
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
    }
    if (this.bmb.Position != -1)
      return;
    this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void cboOcc_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboOcc.Text, string.Empty, false) == 0 || this.dbSave.UIState != UIState.Editing)
      return;
    UltraGridRow selectedRow = ((UltraDropDownBase) this.cboOcc).SelectedRow;
    this.cboOcc.ValueChanged -= new EventHandler(this.cboOcc_SelectedIndexChanged);
    switch (((dsGLRater.tblGLLimitsRow) this.ds.tblGLLimits.Select("ID=" + this.cboOcc.Value.ToString())[0]).Limit)
    {
      case 500000:
        dsGLRater.tblQuoteOptionGLRow quoteOptionGlRow1 = this.ds.tblQuoteOptionGL[this.bmb.Position];
        quoteOptionGlRow1.AGG_ID = this.GetLimitID("AGG", 1000000);
        quoteOptionGlRow1.PCO_ID = this.GetLimitID("PCO", 500000);
        quoteOptionGlRow1.PAI_ID = this.GetLimitID("PAI", 500000);
        quoteOptionGlRow1.FDL_ID = this.GetLimitID("FDL", 50000);
        quoteOptionGlRow1.MED_ID = this.GetLimitID("MED", 5000);
        break;
      case 1000000:
        dsGLRater.tblQuoteOptionGLRow quoteOptionGlRow2 = this.ds.tblQuoteOptionGL[this.bmb.Position];
        quoteOptionGlRow2.AGG_ID = this.GetLimitID("AGG", 2000000);
        quoteOptionGlRow2.PCO_ID = this.GetLimitID("PCO", 1000000);
        quoteOptionGlRow2.PAI_ID = this.GetLimitID("PAI", 1000000);
        quoteOptionGlRow2.FDL_ID = this.GetLimitID("FDL", 50000);
        quoteOptionGlRow2.MED_ID = this.GetLimitID("MED", 5000);
        break;
    }
    ((UltraDropDownBase) this.cboOcc).SelectedRow = selectedRow;
    this.cboOcc.ValueChanged += new EventHandler(this.cboOcc_SelectedIndexChanged);
  }

  private int GetLimitID(string limitCode, int limit)
  {
    return ((dsGLRater.tblGLLimitsRow) this.ds.tblGLLimits.Select($"LimitCode='{limitCode}' AND Limit={limit.ToString()}")[0]).ID;
  }

  protected virtual void ClientSave(SqlTransaction trans)
  {
  }

  protected virtual void ClientCancel()
  {
  }

  protected virtual void ClientAfterRowActive()
  {
  }

  protected virtual void ClientNew()
  {
  }

  private void lnkModifyLocations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowFormDialog(typeof (frmUnderwritingLocations), (object) this.GLRater.Quote.QuoteGuid, (object) true).Dispose();
  }
}

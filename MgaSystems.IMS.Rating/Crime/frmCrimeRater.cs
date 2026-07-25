// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.Crime.frmCrimeRater
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
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
namespace MGASystems.IMS.Policies.Rating.Crime;

public class frmCrimeRater : frmRaterBase
{
  private IContainer components;
  private MGAGroupBox MgaGroupBox1;
  private SqlConnection cn;
  private SqlDataAdapter daCrime;
  private SqlDataAdapter daQuoteOptions;
  private dsCrime ds;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private MGANumericEditor MgaNumericEditor1;
  private MGANumericEditor MgaNumericEditor2;
  private MGANumericEditor MgaNumericEditor3;
  private MGANumericEditor MgaNumericEditor4;
  private MGANumericEditor MgaNumericEditor5;
  private MGANumericEditor MgaNumericEditor6;
  private Label Label5;
  private MGANumericEditor MgaNumericEditor7;
  private MGANumericEditor MgaNumericEditor8;
  private MGANumericEditor MgaNumericEditor9;
  private Label Label6;
  private MGANumericEditor MgaNumericEditor10;
  private MGANumericEditor MgaNumericEditor11;
  private MGANumericEditor MgaNumericEditor12;
  private Label Label7;
  private MGANumericEditor MgaNumericEditor13;
  private MGANumericEditor MgaNumericEditor14;
  private MGANumericEditor MgaNumericEditor15;
  private Label Label8;
  private MGANumericEditor MgaNumericEditor16;
  private MGANumericEditor MgaNumericEditor17;
  private MGANumericEditor MgaNumericEditor18;
  private Label Label9;
  private MGANumericEditor MgaNumericEditor19;
  private MGANumericEditor MgaNumericEditor20;
  private MGANumericEditor MgaNumericEditor21;
  private Label Label10;
  private MGANumericEditor MgaNumericEditor22;
  private MGANumericEditor MgaNumericEditor23;
  private MGANumericEditor MgaNumericEditor24;
  private Label Label11;
  private MGANumericEditor MgaNumericEditor25;
  private Label Label12;
  private MGANumericEditor MgaNumericEditor26;
  private Label Label13;
  private MGANumericEditor MgaNumericEditor27;
  private Label Label14;
  private MGAGroupBox MgaGroupBox2;
  private MGAGroupBox MgaGroupBox3;
  private UltraDropDown ddSubLimits;
  private MGATextBox txtAdditionalComments;
  private SqlDataAdapter daSubLimits;
  private SqlCommand SqlSelectCommand2;
  private SqlCommand SqlInsertCommand2;
  private SqlCommand SqlUpdateCommand2;
  private SqlCommand SqlDeleteCommand2;
  private SqlCommand SqlSelectCommand3;
  private SqlCommand SqlInsertCommand3;
  private SqlCommand SqlUpdateCommand3;
  private SqlCommand SqlDeleteCommand3;
  private MGACheckBox MgaCheckBox1;
  private RadioButton rbShortRate;
  private RadioButton rbFlat;
  private RadioButton rbProRata;
  private Label Label15;
  private Label Label16;
  private Label Label17;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private MGAGroupBox groupEndorsements;
  private Decimal _factor;

  public frmCrimeRater()
  {
    this.Load += new EventHandler(this.frmCrimeRater_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingCancel);
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingNew -= cancelEventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickingDelete -= cancelEventHandler3;
        dbSave1.ClickingCancel -= cancelEventHandler4;
        dbSave1.UIStateChanged -= eventHandler;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingNew += cancelEventHandler1;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickingDelete += cancelEventHandler3;
      dbSave2.ClickingCancel += cancelEventHandler4;
      dbSave2.UIStateChanged += eventHandler;
    }
  }

  private virtual UltraGrid gridOptions
  {
    get => this._gridOptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gridOptions_AfterRowActivate);
      UltraGrid gridOptions1 = this._gridOptions;
      if (gridOptions1 != null)
        gridOptions1.AfterRowActivate -= eventHandler;
      this._gridOptions = value;
      UltraGrid gridOptions2 = this._gridOptions;
      if (gridOptions2 == null)
        return;
      gridOptions2.AfterRowActivate += eventHandler;
    }
  }

  private virtual UltraGrid gridSubLimits
  {
    get => this._gridSubLimits;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler = new RowEventHandler(this.gridSubLimits_AfterRowInsert);
      UltraGrid gridSubLimits1 = this._gridSubLimits;
      if (gridSubLimits1 != null)
        gridSubLimits1.AfterRowInsert -= rowEventHandler;
      this._gridSubLimits = value;
      UltraGrid gridSubLimits2 = this._gridSubLimits;
      if (gridSubLimits2 == null)
        return;
      gridSubLimits2.AfterRowInsert += rowEventHandler;
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCrimeRater));
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblQuoteOptionCrime", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("QuoteOptionID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("TerrorismDeclined");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("EmployeeTheftLimit");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("EmployeeTheftDed");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("EmployeeTheftPrem");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ForgeryLimit");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ForgeryDed");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ForgeryPrem");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("MoneyInsideLimit");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("MoneyInsideDed");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("MoneyInsidePrem");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("SafeInsideLimit");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("SafeInsideDed");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("SafeInsidePrem");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("TheftOutsideLimit");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("TheftOutsideDed");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("TheftOutsidePrem");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ComputerFraudLimit");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("ComputerFraudDed");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("ComputerFraudPrem");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("FundTransferLimit");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("FundTransferDed");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("FundTransferPrem");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("CounterfeitLimit");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("CounterfeitDed");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("CounterfeitPrem");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("TotalPremium");
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("TerrPremium");
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("AdditionalComments");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("Rate");
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("Factor");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("UserOverrideFactor");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("EndorsementCalcType");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("PriorRate");
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("tblQuoteOptionCrimetblQuoteOptionCrime_Sublimits");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblQuoteOptionCrimetblQuoteOptionCrime_Sublimits", 0);
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("OptionSubLimitID");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("CrimeOptionID");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("SubLimitID");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("OriginalOptionSubLimitID");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("Limit");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("Deductible");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("DeductiblePercentage");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("ModificationCode");
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblQuoteOptionCrime_Sublimits", -1);
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("OptionSubLimitID");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("CrimeOptionID");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("SubLimitID", -1, (object) "ddSubLimits");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("OriginalOptionSubLimitID");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("Limit");
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("Deductible");
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("DeductiblePercentage");
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("ModificationCode");
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("lstSubLimits", -1);
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("SubLimitID");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("SubLimit");
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("lstSubLimitstblQuoteOptionCrime_Sublimits");
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstSubLimitstblQuoteOptionCrime_Sublimits", 0);
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("OptionSubLimitID");
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("CrimeOptionID");
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("SubLimitID");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("OriginalOptionSubLimitID");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("Limit");
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("Deductible");
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("DeductiblePercentage");
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("ModificationCode");
    Appearance appearance73 = new Appearance();
    Appearance appearance74 = new Appearance();
    Appearance appearance75 = new Appearance();
    Appearance appearance76 = new Appearance();
    Appearance appearance77 = new Appearance();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.MgaCheckBox1 = new MGACheckBox();
    this.ds = new dsCrime();
    this.MgaNumericEditor27 = new MGANumericEditor();
    this.Label14 = new Label();
    this.MgaNumericEditor26 = new MGANumericEditor();
    this.Label13 = new Label();
    this.MgaNumericEditor25 = new MGANumericEditor();
    this.Label12 = new Label();
    this.MgaNumericEditor22 = new MGANumericEditor();
    this.MgaNumericEditor23 = new MGANumericEditor();
    this.MgaNumericEditor24 = new MGANumericEditor();
    this.Label11 = new Label();
    this.MgaNumericEditor19 = new MGANumericEditor();
    this.MgaNumericEditor20 = new MGANumericEditor();
    this.MgaNumericEditor21 = new MGANumericEditor();
    this.Label10 = new Label();
    this.MgaNumericEditor16 = new MGANumericEditor();
    this.MgaNumericEditor17 = new MGANumericEditor();
    this.MgaNumericEditor18 = new MGANumericEditor();
    this.Label9 = new Label();
    this.MgaNumericEditor13 = new MGANumericEditor();
    this.MgaNumericEditor14 = new MGANumericEditor();
    this.MgaNumericEditor15 = new MGANumericEditor();
    this.Label8 = new Label();
    this.MgaNumericEditor10 = new MGANumericEditor();
    this.MgaNumericEditor11 = new MGANumericEditor();
    this.MgaNumericEditor12 = new MGANumericEditor();
    this.Label7 = new Label();
    this.MgaNumericEditor7 = new MGANumericEditor();
    this.MgaNumericEditor8 = new MGANumericEditor();
    this.MgaNumericEditor9 = new MGANumericEditor();
    this.Label6 = new Label();
    this.MgaNumericEditor4 = new MGANumericEditor();
    this.MgaNumericEditor5 = new MGANumericEditor();
    this.MgaNumericEditor6 = new MGANumericEditor();
    this.Label5 = new Label();
    this.MgaNumericEditor3 = new MGANumericEditor();
    this.MgaNumericEditor2 = new MGANumericEditor();
    this.MgaNumericEditor1 = new MGANumericEditor();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.gridOptions = new UltraGrid();
    this.cn = new SqlConnection();
    this.daCrime = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.daQuoteOptions = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.MgaGroupBox2 = new MGAGroupBox();
    this.gridSubLimits = new UltraGrid();
    this.MgaGroupBox3 = new MGAGroupBox();
    this.txtAdditionalComments = new MGATextBox();
    this.ddSubLimits = new UltraDropDown();
    this.daSubLimits = new SqlDataAdapter();
    this.SqlDeleteCommand3 = new SqlCommand();
    this.SqlInsertCommand3 = new SqlCommand();
    this.SqlSelectCommand3 = new SqlCommand();
    this.SqlUpdateCommand3 = new SqlCommand();
    this.groupEndorsements = new MGAGroupBox();
    this.rbFlat = new RadioButton();
    this.rbShortRate = new RadioButton();
    this.rbProRata = new RadioButton();
    this.Label15 = new Label();
    this.txtFactor = new MGANumericEditor();
    this.dtEffective = new MGADateTimePicker();
    this.Label16 = new Label();
    this.Label17 = new Label();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.MgaCheckBox1).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor27).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor26).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor25).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor22).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor23).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor24).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor19).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor20).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor21).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor16).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor17).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor18).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor13).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor14).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor15).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor10).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor11).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor12).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor7).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor8).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor9).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor4).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor5).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor6).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor3).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor2).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor1).BeginInit();
    ((ISupportInitialize) this.gridOptions).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox2).BeginInit();
    ((Control) this.MgaGroupBox2).SuspendLayout();
    ((ISupportInitialize) this.gridSubLimits).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox3).BeginInit();
    ((Control) this.MgaGroupBox3).SuspendLayout();
    ((ISupportInitialize) this.txtAdditionalComments).BeginInit();
    ((ISupportInitialize) this.ddSubLimits).BeginInit();
    ((ISupportInitialize) this.groupEndorsements).BeginInit();
    ((Control) this.groupEndorsements).SuspendLayout();
    ((ISupportInitialize) this.txtFactor).BeginInit();
    ((ISupportInitialize) this.dtEffective).BeginInit();
    this.SuspendLayout();
    ((Control) this.MgaGroupBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.ForegroundAlpha = (Alpha) 2;
    this.MgaGroupBox1.Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.FromArgb(239, 247, 253);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaCheckBox1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor27);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label14);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor26);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label13);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor25);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label12);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor22);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor23);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor24);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label11);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor19);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor20);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor21);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label10);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor16);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor17);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor18);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label9);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor13);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor14);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor15);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label8);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor10);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor11);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor12);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label7);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor7);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor8);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor9);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label6);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor4);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor5);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor6);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label5);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor3);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label4);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label3);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label1);
    ((Control) this.MgaGroupBox1).Enabled = false;
    appearance3.AlphaLevel = (short) 230;
    appearance3.FontData.SizeInPoints = 10f;
    appearance3.ForeColor = Color.White;
    appearance3.ImageAlpha = (Alpha) 2;
    appearance3.ImageBackground = (Image) componentResourceManager.GetObject("Appearance31.ImageBackground");
    appearance3.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance3;
    ((Control) this.MgaGroupBox1).Location = new Point(8, 120);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(466, 370);
    ((Control) this.MgaGroupBox1).TabIndex = 0;
    this.MgaGroupBox1.Text = "Premiums and Rates";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox1).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblQuoteOptionCrime.TerrorismDeclined", true));
    ((Control) this.MgaCheckBox1).Location = new Point(236, 256 /*0x0100*/);
    this.MgaCheckBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaCheckBox1).Name = "MgaCheckBox1";
    ((Control) this.MgaCheckBox1).Size = new Size(120, 20);
    ((Control) this.MgaCheckBox1).TabIndex = 41;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Text = "Terrorism Declined";
    ((UltraControlBase) this.MgaCheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCrime";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor27).Appearance = (AppearanceBase) appearance5;
    ((Control) this.MgaNumericEditor27).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.PriorRate", true));
    ((Control) this.MgaNumericEditor27).Location = new Point(120, 304);
    this.MgaNumericEditor27.MaskInput = "{LOC}-nnnnnnnnnn.nn";
    this.MgaNumericEditor27.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor27).Name = "MgaNumericEditor27";
    this.MgaNumericEditor27.NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor27).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor27).TabIndex = 40;
    ((UltraControlBase) this.MgaNumericEditor27).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor27).UseOsThemes = (DefaultableBoolean) 2;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(8, 304);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(100, 23);
    this.Label14.TabIndex = 39;
    this.Label14.Text = "Prior Rate";
    this.Label14.TextAlign = ContentAlignment.MiddleRight;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor26).Appearance = (AppearanceBase) appearance6;
    ((Control) this.MgaNumericEditor26).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.Rate", true));
    ((Control) this.MgaNumericEditor26).Location = new Point(120, 280);
    this.MgaNumericEditor26.MaskInput = "{LOC}-nnnnnnnnnn.nn";
    this.MgaNumericEditor26.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor26).Name = "MgaNumericEditor26";
    this.MgaNumericEditor26.NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor26).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor26).TabIndex = 38;
    ((UltraControlBase) this.MgaNumericEditor26).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor26).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(8, 280);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(100, 23);
    this.Label13.TabIndex = 37;
    this.Label13.Text = "Rate";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor25).Appearance = (AppearanceBase) appearance7;
    ((Control) this.MgaNumericEditor25).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.TerrPremium", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor25).FormatString = "c";
    ((Control) this.MgaNumericEditor25).Location = new Point(120, 256 /*0x0100*/);
    this.MgaNumericEditor25.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor25).Name = "MgaNumericEditor25";
    ((Control) this.MgaNumericEditor25).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor25).TabIndex = 36;
    ((UltraControlBase) this.MgaNumericEditor25).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor25).UseOsThemes = (DefaultableBoolean) 2;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(8, 256 /*0x0100*/);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(100, 23);
    this.Label12.TabIndex = 35;
    this.Label12.Text = "Terrorism";
    this.Label12.TextAlign = ContentAlignment.MiddleRight;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor22).Appearance = (AppearanceBase) appearance8;
    ((Control) this.MgaNumericEditor22).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.CounterfeitPrem", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor22).FormatString = "c";
    ((Control) this.MgaNumericEditor22).Location = new Point(352, 232);
    this.MgaNumericEditor22.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor22).Name = "MgaNumericEditor22";
    ((Control) this.MgaNumericEditor22).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor22).TabIndex = 34;
    ((UltraControlBase) this.MgaNumericEditor22).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor22).UseOsThemes = (DefaultableBoolean) 2;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor23).Appearance = (AppearanceBase) appearance9;
    ((Control) this.MgaNumericEditor23).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.CounterfeitDed", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor23).FormatString = "c";
    ((Control) this.MgaNumericEditor23).Location = new Point(236, 232);
    this.MgaNumericEditor23.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor23).Name = "MgaNumericEditor23";
    ((Control) this.MgaNumericEditor23).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor23).TabIndex = 33;
    ((UltraControlBase) this.MgaNumericEditor23).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor23).UseOsThemes = (DefaultableBoolean) 2;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor24).Appearance = (AppearanceBase) appearance10;
    ((Control) this.MgaNumericEditor24).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.CounterfeitLimit", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor24).FormatString = "c";
    ((Control) this.MgaNumericEditor24).Location = new Point(120, 232);
    this.MgaNumericEditor24.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor24).Name = "MgaNumericEditor24";
    ((Control) this.MgaNumericEditor24).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor24).TabIndex = 32 /*0x20*/;
    ((UltraControlBase) this.MgaNumericEditor24).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor24).UseOsThemes = (DefaultableBoolean) 2;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(8, 232);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(100, 23);
    this.Label11.TabIndex = 31 /*0x1F*/;
    this.Label11.Text = "Counterfeit";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor19).Appearance = (AppearanceBase) appearance11;
    ((Control) this.MgaNumericEditor19).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.FundTransferPrem", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor19).FormatString = "c";
    ((Control) this.MgaNumericEditor19).Location = new Point(352, 208 /*0xD0*/);
    this.MgaNumericEditor19.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor19).Name = "MgaNumericEditor19";
    ((Control) this.MgaNumericEditor19).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor19).TabIndex = 30;
    ((UltraControlBase) this.MgaNumericEditor19).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor19).UseOsThemes = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor20).Appearance = (AppearanceBase) appearance12;
    ((Control) this.MgaNumericEditor20).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.FundTransferDed", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor20).FormatString = "c";
    ((Control) this.MgaNumericEditor20).Location = new Point(236, 208 /*0xD0*/);
    this.MgaNumericEditor20.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor20).Name = "MgaNumericEditor20";
    ((Control) this.MgaNumericEditor20).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor20).TabIndex = 29;
    ((UltraControlBase) this.MgaNumericEditor20).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor20).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor21).Appearance = (AppearanceBase) appearance13;
    ((Control) this.MgaNumericEditor21).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.FundTransferLimit", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor21).FormatString = "c";
    ((Control) this.MgaNumericEditor21).Location = new Point(120, 208 /*0xD0*/);
    this.MgaNumericEditor21.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor21).Name = "MgaNumericEditor21";
    ((Control) this.MgaNumericEditor21).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor21).TabIndex = 28;
    ((UltraControlBase) this.MgaNumericEditor21).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor21).UseOsThemes = (DefaultableBoolean) 2;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(8, 208 /*0xD0*/);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(100, 23);
    this.Label10.TabIndex = 27;
    this.Label10.Text = "Fund Transfer";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor16).Appearance = (AppearanceBase) appearance14;
    ((Control) this.MgaNumericEditor16).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.ComputerFraudPrem", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor16).FormatString = "c";
    ((Control) this.MgaNumericEditor16).Location = new Point(352, 184);
    this.MgaNumericEditor16.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor16).Name = "MgaNumericEditor16";
    ((Control) this.MgaNumericEditor16).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor16).TabIndex = 26;
    ((UltraControlBase) this.MgaNumericEditor16).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor16).UseOsThemes = (DefaultableBoolean) 2;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor17).Appearance = (AppearanceBase) appearance15;
    ((Control) this.MgaNumericEditor17).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.ComputerFraudDed", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor17).FormatString = "c";
    ((Control) this.MgaNumericEditor17).Location = new Point(236, 184);
    this.MgaNumericEditor17.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor17).Name = "MgaNumericEditor17";
    ((Control) this.MgaNumericEditor17).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor17).TabIndex = 25;
    ((UltraControlBase) this.MgaNumericEditor17).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor17).UseOsThemes = (DefaultableBoolean) 2;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor18).Appearance = (AppearanceBase) appearance16;
    ((Control) this.MgaNumericEditor18).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.ComputerFraudLimit", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor18).FormatString = "c";
    ((Control) this.MgaNumericEditor18).Location = new Point(120, 184);
    this.MgaNumericEditor18.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor18).Name = "MgaNumericEditor18";
    ((Control) this.MgaNumericEditor18).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor18).TabIndex = 24;
    ((UltraControlBase) this.MgaNumericEditor18).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor18).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(8, 184);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(100, 23);
    this.Label9.TabIndex = 23;
    this.Label9.Text = "Computer Fraud";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor13).Appearance = (AppearanceBase) appearance17;
    ((Control) this.MgaNumericEditor13).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.TheftOutsidePrem", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor13).FormatString = "c";
    ((Control) this.MgaNumericEditor13).Location = new Point(352, 160 /*0xA0*/);
    this.MgaNumericEditor13.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor13).Name = "MgaNumericEditor13";
    ((Control) this.MgaNumericEditor13).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor13).TabIndex = 22;
    ((UltraControlBase) this.MgaNumericEditor13).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor13).UseOsThemes = (DefaultableBoolean) 2;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor14).Appearance = (AppearanceBase) appearance18;
    ((Control) this.MgaNumericEditor14).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.TheftOutsideDed", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor14).FormatString = "c";
    ((Control) this.MgaNumericEditor14).Location = new Point(236, 160 /*0xA0*/);
    this.MgaNumericEditor14.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor14).Name = "MgaNumericEditor14";
    ((Control) this.MgaNumericEditor14).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor14).TabIndex = 21;
    ((UltraControlBase) this.MgaNumericEditor14).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor14).UseOsThemes = (DefaultableBoolean) 2;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor15).Appearance = (AppearanceBase) appearance19;
    ((Control) this.MgaNumericEditor15).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.TheftOutsideLimit", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor15).FormatString = "c";
    ((Control) this.MgaNumericEditor15).Location = new Point(120, 160 /*0xA0*/);
    this.MgaNumericEditor15.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor15).Name = "MgaNumericEditor15";
    ((Control) this.MgaNumericEditor15).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor15).TabIndex = 20;
    ((UltraControlBase) this.MgaNumericEditor15).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor15).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(8, 160 /*0xA0*/);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(100, 23);
    this.Label8.TabIndex = 19;
    this.Label8.Text = "Theft Outside";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor10).Appearance = (AppearanceBase) appearance20;
    ((Control) this.MgaNumericEditor10).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.SafeInsidePrem", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor10).FormatString = "c";
    ((Control) this.MgaNumericEditor10).Location = new Point(352, 136);
    this.MgaNumericEditor10.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor10).Name = "MgaNumericEditor10";
    ((Control) this.MgaNumericEditor10).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor10).TabIndex = 18;
    ((UltraControlBase) this.MgaNumericEditor10).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor10).UseOsThemes = (DefaultableBoolean) 2;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor11).Appearance = (AppearanceBase) appearance21;
    ((Control) this.MgaNumericEditor11).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.SafeInsideDed", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor11).FormatString = "c";
    ((Control) this.MgaNumericEditor11).Location = new Point(236, 136);
    this.MgaNumericEditor11.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor11).Name = "MgaNumericEditor11";
    ((Control) this.MgaNumericEditor11).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor11).TabIndex = 17;
    ((UltraControlBase) this.MgaNumericEditor11).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor11).UseOsThemes = (DefaultableBoolean) 2;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor12).Appearance = (AppearanceBase) appearance22;
    ((Control) this.MgaNumericEditor12).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.SafeInsideLimit", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor12).FormatString = "c";
    ((Control) this.MgaNumericEditor12).Location = new Point(120, 136);
    this.MgaNumericEditor12.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor12).Name = "MgaNumericEditor12";
    ((Control) this.MgaNumericEditor12).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor12).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.MgaNumericEditor12).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor12).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(8, 136);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(100, 23);
    this.Label7.TabIndex = 15;
    this.Label7.Text = "Safe Inside";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor7).Appearance = (AppearanceBase) appearance23;
    ((Control) this.MgaNumericEditor7).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.MoneyInsidePrem", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor7).FormatString = "c";
    ((Control) this.MgaNumericEditor7).Location = new Point(352, 112 /*0x70*/);
    this.MgaNumericEditor7.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor7).Name = "MgaNumericEditor7";
    ((Control) this.MgaNumericEditor7).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor7).TabIndex = 14;
    ((UltraControlBase) this.MgaNumericEditor7).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor7).UseOsThemes = (DefaultableBoolean) 2;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor8).Appearance = (AppearanceBase) appearance24;
    ((Control) this.MgaNumericEditor8).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.MoneyInsideDed", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor8).FormatString = "c";
    ((Control) this.MgaNumericEditor8).Location = new Point(236, 112 /*0x70*/);
    this.MgaNumericEditor8.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor8).Name = "MgaNumericEditor8";
    ((Control) this.MgaNumericEditor8).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor8).TabIndex = 13;
    ((UltraControlBase) this.MgaNumericEditor8).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor8).UseOsThemes = (DefaultableBoolean) 2;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor9).Appearance = (AppearanceBase) appearance25;
    ((Control) this.MgaNumericEditor9).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.MoneyInsideLimit", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor9).FormatString = "c";
    ((Control) this.MgaNumericEditor9).Location = new Point(120, 112 /*0x70*/);
    this.MgaNumericEditor9.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor9).Name = "MgaNumericEditor9";
    ((Control) this.MgaNumericEditor9).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor9).TabIndex = 12;
    ((UltraControlBase) this.MgaNumericEditor9).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor9).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(8, 112 /*0x70*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(100, 23);
    this.Label6.TabIndex = 11;
    this.Label6.Text = "Money Inside";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor4).Appearance = (AppearanceBase) appearance26;
    ((Control) this.MgaNumericEditor4).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.ForgeryPrem", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor4).FormatString = "c";
    ((Control) this.MgaNumericEditor4).Location = new Point(352, 88);
    this.MgaNumericEditor4.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor4).Name = "MgaNumericEditor4";
    ((Control) this.MgaNumericEditor4).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor4).TabIndex = 10;
    ((UltraControlBase) this.MgaNumericEditor4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor4).UseOsThemes = (DefaultableBoolean) 2;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor5).Appearance = (AppearanceBase) appearance27;
    ((Control) this.MgaNumericEditor5).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.ForgeryDed", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor5).FormatString = "c";
    ((Control) this.MgaNumericEditor5).Location = new Point(236, 88);
    this.MgaNumericEditor5.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor5).Name = "MgaNumericEditor5";
    ((Control) this.MgaNumericEditor5).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor5).TabIndex = 9;
    ((UltraControlBase) this.MgaNumericEditor5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor5).UseOsThemes = (DefaultableBoolean) 2;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor6).Appearance = (AppearanceBase) appearance28;
    ((Control) this.MgaNumericEditor6).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.ForgeryLimit", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor6).FormatString = "c";
    ((Control) this.MgaNumericEditor6).Location = new Point(120, 88);
    this.MgaNumericEditor6.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor6).Name = "MgaNumericEditor6";
    ((Control) this.MgaNumericEditor6).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor6).TabIndex = 8;
    ((UltraControlBase) this.MgaNumericEditor6).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor6).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(8, 88);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(100, 23);
    this.Label5.TabIndex = 7;
    this.Label5.Text = "Forgery";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor3).Appearance = (AppearanceBase) appearance29;
    ((Control) this.MgaNumericEditor3).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.EmployeeTheftPrem", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor3).FormatString = "c";
    ((Control) this.MgaNumericEditor3).Location = new Point(352, 64 /*0x40*/);
    this.MgaNumericEditor3.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor3).Name = "MgaNumericEditor3";
    ((Control) this.MgaNumericEditor3).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor3).TabIndex = 6;
    ((UltraControlBase) this.MgaNumericEditor3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor3).UseOsThemes = (DefaultableBoolean) 2;
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor2).Appearance = (AppearanceBase) appearance30;
    ((Control) this.MgaNumericEditor2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.EmployeeTheftDed", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor2).FormatString = "c";
    ((Control) this.MgaNumericEditor2).Location = new Point(236, 64 /*0x40*/);
    this.MgaNumericEditor2.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor2).Name = "MgaNumericEditor2";
    ((Control) this.MgaNumericEditor2).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor2).TabIndex = 5;
    ((UltraControlBase) this.MgaNumericEditor2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor2).UseOsThemes = (DefaultableBoolean) 2;
    appearance31.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor1).Appearance = (AppearanceBase) appearance31;
    ((Control) this.MgaNumericEditor1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionCrime.EmployeeTheftLimit", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor1).FormatString = "c";
    ((Control) this.MgaNumericEditor1).Location = new Point(120, 64 /*0x40*/);
    this.MgaNumericEditor1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor1).Name = "MgaNumericEditor1";
    ((Control) this.MgaNumericEditor1).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor1).TabIndex = 4;
    ((UltraControlBase) this.MgaNumericEditor1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(8, 64 /*0x40*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(100, 23);
    this.Label4.TabIndex = 3;
    this.Label4.Text = "Employee Theft";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(352, 32 /*0x20*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(100, 23);
    this.Label3.TabIndex = 2;
    this.Label3.Text = "Premium";
    this.Label3.TextAlign = ContentAlignment.BottomCenter;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(236, 32 /*0x20*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(100, 23);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Deductible";
    this.Label2.TextAlign = ContentAlignment.BottomCenter;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(120, 32 /*0x20*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(100, 23);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Limit";
    this.Label1.TextAlign = ContentAlignment.BottomCenter;
    ((Control) this.gridOptions).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridOptions).DataSource = (object) this.ds.tblQuoteOptionCrime;
    appearance32.BackColor = Color.White;
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOptions).DisplayLayout.Appearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.gridOptions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 53;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 59;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 37;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 39;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 44;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 47;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 26;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 26;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 22;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 21;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 20;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 15;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 11;
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 10;
    ultraGridColumn15.Header.VisiblePosition = 14;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 8;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 8;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 8;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 8;
    ultraGridColumn19.Header.VisiblePosition = 18;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 8;
    ultraGridColumn20.Header.VisiblePosition = 19;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 8;
    ultraGridColumn21.Header.VisiblePosition = 20;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 8;
    ultraGridColumn22.Header.VisiblePosition = 21;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 8;
    ultraGridColumn23.Header.VisiblePosition = 22;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 8;
    ultraGridColumn24.Header.VisiblePosition = 23;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 8;
    ultraGridColumn25.Header.VisiblePosition = 24;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 8;
    ultraGridColumn26.Header.VisiblePosition = 25;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 8;
    ultraGridColumn27.Header.VisiblePosition = 26;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 8;
    ((AppearanceBase) appearance33).TextHAlignAsString = "Right";
    ultraGridColumn28.CellAppearance = (AppearanceBase) appearance33;
    ultraGridColumn28.Format = "c";
    ((AppearanceBase) appearance34).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn28.Header).Appearance = (AppearanceBase) appearance34;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "Total Premium";
    ultraGridColumn28.Header.VisiblePosition = 27;
    ultraGridColumn28.Width = 225;
    ((AppearanceBase) appearance35).TextHAlignAsString = "Right";
    ultraGridColumn29.CellAppearance = (AppearanceBase) appearance35;
    ultraGridColumn29.Format = "c";
    ((AppearanceBase) appearance36).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn29.Header).Appearance = (AppearanceBase) appearance36;
    ((HeaderBase) ultraGridColumn29.Header).Caption = "Terrorism";
    ultraGridColumn29.Header.VisiblePosition = 28;
    ultraGridColumn29.Width = 234;
    ultraGridColumn30.Header.VisiblePosition = 29;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 124;
    ((AppearanceBase) appearance37).TextHAlignAsString = "Right";
    ultraGridColumn31.CellAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn31.Header).Appearance = (AppearanceBase) appearance38;
    ultraGridColumn31.Header.VisiblePosition = 30;
    ultraGridColumn31.Width = 232;
    ultraGridColumn32.Header.VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 63 /*0x3F*/;
    ultraGridColumn33.Header.VisiblePosition = 33;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn33.Width = 56;
    ultraGridColumn34.Header.VisiblePosition = 35;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn34.Width = 80 /*0x50*/;
    ultraGridColumn35.Header.VisiblePosition = 36;
    ultraGridColumn35.Hidden = true;
    ultraGridColumn35.Width = 91;
    ((AppearanceBase) appearance39).TextHAlignAsString = "Right";
    ultraGridColumn36.CellAppearance = (AppearanceBase) appearance39;
    ((AppearanceBase) appearance40).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn36.Header).Appearance = (AppearanceBase) appearance40;
    ((HeaderBase) ultraGridColumn36.Header).Caption = "Prior Rate";
    ultraGridColumn36.Header.VisiblePosition = 32 /*0x20*/;
    ultraGridColumn36.Width = 235;
    ultraGridColumn37.Header.VisiblePosition = 34;
    ultraGridBand1.Columns.AddRange(new object[37]
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
      (object) ultraGridColumn37
    });
    ultraGridColumn38.Header.VisiblePosition = 0;
    ultraGridColumn38.Width = 77;
    ultraGridColumn39.Header.VisiblePosition = 1;
    ultraGridColumn39.Width = 65;
    ultraGridColumn40.Header.VisiblePosition = 2;
    ultraGridColumn40.Width = 59;
    ultraGridColumn41.Header.VisiblePosition = 3;
    ultraGridColumn41.Width = 109;
    ultraGridColumn42.Header.VisiblePosition = 4;
    ultraGridColumn42.Width = 45;
    ultraGridColumn43.Header.VisiblePosition = 5;
    ultraGridColumn43.Width = 53;
    ultraGridColumn44.Header.VisiblePosition = 6;
    ultraGridColumn44.Width = 97;
    ultraGridColumn45.Header.VisiblePosition = 7;
    ultraGridColumn45.Width = 79;
    ultraGridBand2.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45
    });
    ((UltraGridBase) this.gridOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridOptions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance41.BackColor = Color.LightSteelBlue;
    appearance41.FontData.SizeInPoints = 10f;
    appearance41.ForeColor = Color.Navy;
    ((UltraGridBase) this.gridOptions).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance41;
    appearance42.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance42.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance42.ForeColor = Color.Black;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance42;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance43.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance44.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance44;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance45.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance45;
    appearance46.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance46;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance47.BackColor = Color.Transparent;
    appearance47.ForeColor = Color.Black;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance47;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridOptions).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraGridBase) this.gridOptions).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.gridOptions).Location = new Point(8, 8);
    ((Control) this.gridOptions).Name = "gridOptions";
    ((Control) this.gridOptions).Size = new Size(928, 104);
    ((Control) this.gridOptions).TabIndex = 1;
    ((Control) this.gridOptions).Text = "Existing Options";
    ((UltraControlBase) this.gridOptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridOptions).UseOsThemes = (DefaultableBoolean) 2;
    this.cn.ConnectionString = "workstation id=PSARNOWSKI;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.daCrime.DeleteCommand = this.SqlDeleteCommand1;
    this.daCrime.InsertCommand = this.SqlInsertCommand1;
    this.daCrime.SelectCommand = this.SqlSelectCommand1;
    this.daCrime.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteOptionCrime", new DataColumnMapping[36]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("QuoteOptionID", "QuoteOptionID"),
        new DataColumnMapping("TerrorismDeclined", "TerrorismDeclined"),
        new DataColumnMapping("EmployeeTheftLimit", "EmployeeTheftLimit"),
        new DataColumnMapping("EmployeeTheftDed", "EmployeeTheftDed"),
        new DataColumnMapping("EmployeeTheftPrem", "EmployeeTheftPrem"),
        new DataColumnMapping("ForgeryLimit", "ForgeryLimit"),
        new DataColumnMapping("ForgeryDed", "ForgeryDed"),
        new DataColumnMapping("ForgeryPrem", "ForgeryPrem"),
        new DataColumnMapping("MoneyInsideLimit", "MoneyInsideLimit"),
        new DataColumnMapping("MoneyInsideDed", "MoneyInsideDed"),
        new DataColumnMapping("MoneyInsidePrem", "MoneyInsidePrem"),
        new DataColumnMapping("SafeInsideLimit", "SafeInsideLimit"),
        new DataColumnMapping("SafeInsideDed", "SafeInsideDed"),
        new DataColumnMapping("SafeInsidePrem", "SafeInsidePrem"),
        new DataColumnMapping("TheftOutsideLimit", "TheftOutsideLimit"),
        new DataColumnMapping("TheftOutsideDed", "TheftOutsideDed"),
        new DataColumnMapping("TheftOutsidePrem", "TheftOutsidePrem"),
        new DataColumnMapping("ComputerFraudLimit", "ComputerFraudLimit"),
        new DataColumnMapping("ComputerFraudDed", "ComputerFraudDed"),
        new DataColumnMapping("ComputerFraudPrem", "ComputerFraudPrem"),
        new DataColumnMapping("FundTransferLimit", "FundTransferLimit"),
        new DataColumnMapping("FundTransferDed", "FundTransferDed"),
        new DataColumnMapping("FundTransferPrem", "FundTransferPrem"),
        new DataColumnMapping("CounterfeitLimit", "CounterfeitLimit"),
        new DataColumnMapping("CounterfeitDed", "CounterfeitDed"),
        new DataColumnMapping("CounterfeitPrem", "CounterfeitPrem"),
        new DataColumnMapping("TotalPremium", "TotalPremium"),
        new DataColumnMapping("TerrPremium", "TerrPremium"),
        new DataColumnMapping("AdditionalComments", "AdditionalComments"),
        new DataColumnMapping("Rate", "Rate"),
        new DataColumnMapping("PriorRate", "PriorRate"),
        new DataColumnMapping("EffectiveDate", "EffectiveDate"),
        new DataColumnMapping("UserOverrideFactor", "UserOverrideFactor"),
        new DataColumnMapping("EndorsementCalcType", "EndorsementCalcType"),
        new DataColumnMapping("Factor", "Factor")
      })
    });
    this.daCrime.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblQuoteOptionCrime WHERE (ID = @Original_ID)";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[34]
    {
      new SqlParameter("@QuoteOptionID", SqlDbType.Int, 4, "QuoteOptionID"),
      new SqlParameter("@TerrorismDeclined", SqlDbType.Bit, 1, "TerrorismDeclined"),
      new SqlParameter("@EmployeeTheftLimit", SqlDbType.Money, 8, "EmployeeTheftLimit"),
      new SqlParameter("@EmployeeTheftDed", SqlDbType.Money, 8, "EmployeeTheftDed"),
      new SqlParameter("@EmployeeTheftPrem", SqlDbType.Money, 8, "EmployeeTheftPrem"),
      new SqlParameter("@ForgeryLimit", SqlDbType.Money, 8, "ForgeryLimit"),
      new SqlParameter("@ForgeryDed", SqlDbType.Money, 8, "ForgeryDed"),
      new SqlParameter("@ForgeryPrem", SqlDbType.Money, 8, "ForgeryPrem"),
      new SqlParameter("@MoneyInsideLimit", SqlDbType.Money, 8, "MoneyInsideLimit"),
      new SqlParameter("@MoneyInsideDed", SqlDbType.Money, 8, "MoneyInsideDed"),
      new SqlParameter("@MoneyInsidePrem", SqlDbType.Money, 8, "MoneyInsidePrem"),
      new SqlParameter("@SafeInsideLimit", SqlDbType.Money, 8, "SafeInsideLimit"),
      new SqlParameter("@SafeInsideDed", SqlDbType.Money, 8, "SafeInsideDed"),
      new SqlParameter("@SafeInsidePrem", SqlDbType.Money, 8, "SafeInsidePrem"),
      new SqlParameter("@TheftOutsideLimit", SqlDbType.Money, 8, "TheftOutsideLimit"),
      new SqlParameter("@TheftOutsideDed", SqlDbType.Money, 8, "TheftOutsideDed"),
      new SqlParameter("@TheftOutsidePrem", SqlDbType.Money, 8, "TheftOutsidePrem"),
      new SqlParameter("@ComputerFraudLimit", SqlDbType.Money, 8, "ComputerFraudLimit"),
      new SqlParameter("@ComputerFraudDed", SqlDbType.Money, 8, "ComputerFraudDed"),
      new SqlParameter("@ComputerFraudPrem", SqlDbType.Money, 8, "ComputerFraudPrem"),
      new SqlParameter("@FundTransferLimit", SqlDbType.Money, 8, "FundTransferLimit"),
      new SqlParameter("@FundTransferDed", SqlDbType.Money, 8, "FundTransferDed"),
      new SqlParameter("@FundTransferPrem", SqlDbType.Money, 8, "FundTransferPrem"),
      new SqlParameter("@CounterfeitLimit", SqlDbType.Money, 8, "CounterfeitLimit"),
      new SqlParameter("@CounterfeitDed", SqlDbType.Money, 8, "CounterfeitDed"),
      new SqlParameter("@CounterfeitPrem", SqlDbType.Money, 8, "CounterfeitPrem"),
      new SqlParameter("@TerrPremium", SqlDbType.Money, 8, "TerrPremium"),
      new SqlParameter("@AdditionalComments", SqlDbType.VarChar, 2000, "AdditionalComments"),
      new SqlParameter("@Rate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "Rate", DataRowVersion.Current, (object) null),
      new SqlParameter("@PriorRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "PriorRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@EffectiveDate", SqlDbType.DateTime, 8, "EffectiveDate"),
      new SqlParameter("@UserOverrideFactor", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 5, (byte) 4, "UserOverrideFactor", DataRowVersion.Current, (object) null),
      new SqlParameter("@EndorsementCalcType", SqlDbType.VarChar, 1, "EndorsementCalcType"),
      new SqlParameter("@Factor", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "Factor", DataRowVersion.Current, (object) null)
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[36]
    {
      new SqlParameter("@QuoteOptionID", SqlDbType.Int, 4, "QuoteOptionID"),
      new SqlParameter("@TerrorismDeclined", SqlDbType.Bit, 1, "TerrorismDeclined"),
      new SqlParameter("@EmployeeTheftLimit", SqlDbType.Money, 8, "EmployeeTheftLimit"),
      new SqlParameter("@EmployeeTheftDed", SqlDbType.Money, 8, "EmployeeTheftDed"),
      new SqlParameter("@EmployeeTheftPrem", SqlDbType.Money, 8, "EmployeeTheftPrem"),
      new SqlParameter("@ForgeryLimit", SqlDbType.Money, 8, "ForgeryLimit"),
      new SqlParameter("@ForgeryDed", SqlDbType.Money, 8, "ForgeryDed"),
      new SqlParameter("@ForgeryPrem", SqlDbType.Money, 8, "ForgeryPrem"),
      new SqlParameter("@MoneyInsideLimit", SqlDbType.Money, 8, "MoneyInsideLimit"),
      new SqlParameter("@MoneyInsideDed", SqlDbType.Money, 8, "MoneyInsideDed"),
      new SqlParameter("@MoneyInsidePrem", SqlDbType.Money, 8, "MoneyInsidePrem"),
      new SqlParameter("@SafeInsideLimit", SqlDbType.Money, 8, "SafeInsideLimit"),
      new SqlParameter("@SafeInsideDed", SqlDbType.Money, 8, "SafeInsideDed"),
      new SqlParameter("@SafeInsidePrem", SqlDbType.Money, 8, "SafeInsidePrem"),
      new SqlParameter("@TheftOutsideLimit", SqlDbType.Money, 8, "TheftOutsideLimit"),
      new SqlParameter("@TheftOutsideDed", SqlDbType.Money, 8, "TheftOutsideDed"),
      new SqlParameter("@TheftOutsidePrem", SqlDbType.Money, 8, "TheftOutsidePrem"),
      new SqlParameter("@ComputerFraudLimit", SqlDbType.Money, 8, "ComputerFraudLimit"),
      new SqlParameter("@ComputerFraudDed", SqlDbType.Money, 8, "ComputerFraudDed"),
      new SqlParameter("@ComputerFraudPrem", SqlDbType.Money, 8, "ComputerFraudPrem"),
      new SqlParameter("@FundTransferLimit", SqlDbType.Money, 8, "FundTransferLimit"),
      new SqlParameter("@FundTransferDed", SqlDbType.Money, 8, "FundTransferDed"),
      new SqlParameter("@FundTransferPrem", SqlDbType.Money, 8, "FundTransferPrem"),
      new SqlParameter("@CounterfeitLimit", SqlDbType.Money, 8, "CounterfeitLimit"),
      new SqlParameter("@CounterfeitDed", SqlDbType.Money, 8, "CounterfeitDed"),
      new SqlParameter("@CounterfeitPrem", SqlDbType.Money, 8, "CounterfeitPrem"),
      new SqlParameter("@TerrPremium", SqlDbType.Money, 8, "TerrPremium"),
      new SqlParameter("@AdditionalComments", SqlDbType.VarChar, 2000, "AdditionalComments"),
      new SqlParameter("@Rate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "Rate", DataRowVersion.Current, (object) null),
      new SqlParameter("@PriorRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "PriorRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@EffectiveDate", SqlDbType.DateTime, 8, "EffectiveDate"),
      new SqlParameter("@UserOverrideFactor", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 5, (byte) 4, "UserOverrideFactor", DataRowVersion.Current, (object) null),
      new SqlParameter("@EndorsementCalcType", SqlDbType.VarChar, 1, "EndorsementCalcType"),
      new SqlParameter("@Factor", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "Factor", DataRowVersion.Current, (object) null),
      new SqlParameter("@Original_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    this.daQuoteOptions.DeleteCommand = this.SqlDeleteCommand2;
    this.daQuoteOptions.InsertCommand = this.SqlInsertCommand2;
    this.daQuoteOptions.SelectCommand = this.SqlSelectCommand2;
    this.daQuoteOptions.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteOptions", new DataColumnMapping[5]
      {
        new DataColumnMapping("QuoteOptionGUID", "QuoteOptionGUID"),
        new DataColumnMapping("QuoteGUID", "QuoteGUID"),
        new DataColumnMapping("LineGUID", "LineGUID"),
        new DataColumnMapping("DateCreated", "DateCreated"),
        new DataColumnMapping("AdditionalComments", "AdditionalComments")
      })
    });
    this.daQuoteOptions.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM tblQuoteOptions WHERE (QuoteOptionGUID = @OriginalMyBase.Rater.QuoteOptionGUID)";
    this.SqlDeleteCommand2.Connection = this.cn;
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@OriginalMyBase.Rater.QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionGUID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = componentResourceManager.GetString("SqlInsertCommand2.CommandText");
    this.SqlInsertCommand2.Connection = this.cn;
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGUID"),
      new SqlParameter("@QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID"),
      new SqlParameter("@DateCreated", SqlDbType.DateTime, 8, "DateCreated"),
      new SqlParameter("@AdditionalComments", SqlDbType.VarChar, 2000, "AdditionalComments")
    });
    this.SqlSelectCommand2.CommandText = "SELECT QuoteOptionGUID, QuoteGUID, LineGUID, DateCreated, AdditionalComments, QuoteOptionID FROM tblQuoteOptions WHERE (QuoteGUID = @QuoteGuid)";
    this.SqlSelectCommand2.Connection = this.cn;
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID")
    });
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Connection = this.cn;
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGUID"),
      new SqlParameter("@QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID"),
      new SqlParameter("@DateCreated", SqlDbType.DateTime, 8, "DateCreated"),
      new SqlParameter("@AdditionalComments", SqlDbType.VarChar, 2000, "AdditionalComments"),
      new SqlParameter("@OriginalMyBase.Rater.QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionGUID", DataRowVersion.Original, (object) null)
    });
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(482, 450);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 2;
    appearance48.ForegroundAlpha = (Alpha) 2;
    this.MgaGroupBox2.Appearance = (AppearanceBase) appearance48;
    appearance49.BackColor = Color.FromArgb(239, 247, 253);
    appearance49.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance49;
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.gridSubLimits);
    ((Control) this.MgaGroupBox2).Enabled = false;
    appearance50.AlphaLevel = (short) 230;
    appearance50.FontData.SizeInPoints = 10f;
    appearance50.ForeColor = Color.White;
    appearance50.ImageAlpha = (Alpha) 2;
    appearance50.ImageBackground = (Image) componentResourceManager.GetObject("Appearance67.ImageBackground");
    appearance50.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox2.HeaderAppearance = (AppearanceBase) appearance50;
    ((Control) this.MgaGroupBox2).Location = new Point(480, 120);
    ((Control) this.MgaGroupBox2).Name = "MgaGroupBox2";
    ((Control) this.MgaGroupBox2).Size = new Size(456, 154);
    ((Control) this.MgaGroupBox2).TabIndex = 3;
    this.MgaGroupBox2.Text = "Sub-Limits";
    this.MgaGroupBox2.ViewStyle = (GroupBoxViewStyle) 2;
    ((UltraGridBase) this.gridSubLimits).DataSource = (object) this.ds.tblQuoteOptionCrime_Sublimits;
    appearance51.BackColor = Color.WhiteSmoke;
    appearance51.BorderColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.gridSubLimits).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance51;
    appearance52.BackColor = Color.WhiteSmoke;
    appearance52.FontData.UnderlineAsString = "True";
    appearance52.ForeColor = Color.Blue;
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance52;
    ((SpecialBoxBase) ((UltraGridBase) this.gridSubLimits).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.gridSubLimits).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance53.BackColor = Color.White;
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.Appearance = (AppearanceBase) appearance53;
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand3.AddButtonCaption = "Click here to add a new sub-limit...";
    ultraGridColumn46.Header.VisiblePosition = 0;
    ultraGridColumn46.Hidden = true;
    ultraGridColumn46.Width = 39;
    ultraGridColumn47.Header.VisiblePosition = 1;
    ultraGridColumn47.Hidden = true;
    ultraGridColumn47.Width = 36;
    ((HeaderBase) ultraGridColumn48.Header).Caption = "Sub Limit";
    ultraGridColumn48.Header.VisiblePosition = 2;
    ultraGridColumn48.Style = (ColumnStyle) 6;
    ultraGridColumn48.Width = 226;
    ultraGridColumn49.Header.VisiblePosition = 3;
    ultraGridColumn49.Hidden = true;
    ultraGridColumn49.Width = 56;
    ((AppearanceBase) appearance54).TextHAlignAsString = "Right";
    ultraGridColumn50.CellAppearance = (AppearanceBase) appearance54;
    ultraGridColumn50.Format = "c";
    ((AppearanceBase) appearance55).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn50.Header).Appearance = (AppearanceBase) appearance55;
    ultraGridColumn50.Header.VisiblePosition = 4;
    ultraGridColumn50.Width = 58;
    ((AppearanceBase) appearance56).TextHAlignAsString = "Right";
    ultraGridColumn51.CellAppearance = (AppearanceBase) appearance56;
    ultraGridColumn51.Format = "c";
    ((AppearanceBase) appearance57).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn51.Header).Appearance = (AppearanceBase) appearance57;
    ultraGridColumn51.Header.VisiblePosition = 5;
    ultraGridColumn51.Width = 75;
    ((AppearanceBase) appearance58).TextHAlignAsString = "Right";
    ultraGridColumn52.CellAppearance = (AppearanceBase) appearance58;
    ultraGridColumn52.Format = "p";
    ((AppearanceBase) appearance59).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn52.Header).Appearance = (AppearanceBase) appearance59;
    ((HeaderBase) ultraGridColumn52.Header).Caption = "Deductible %";
    ultraGridColumn52.Header.VisiblePosition = 6;
    ultraGridColumn52.Width = 74;
    ultraGridColumn53.Header.VisiblePosition = 7;
    ultraGridColumn53.Hidden = true;
    ultraGridColumn53.Width = 119;
    ultraGridBand3.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn46,
      (object) ultraGridColumn47,
      (object) ultraGridColumn48,
      (object) ultraGridColumn49,
      (object) ultraGridColumn50,
      (object) ultraGridColumn51,
      (object) ultraGridColumn52,
      (object) ultraGridColumn53
    });
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    appearance60.BackColor = Color.LightSteelBlue;
    appearance60.FontData.SizeInPoints = 10f;
    appearance60.ForeColor = Color.Black;
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance60;
    appearance61.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance61.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance61.ForeColor = Color.Black;
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance61;
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance62.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance62;
    appearance63.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    appearance63.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance63;
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance64.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance64;
    appearance65.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance65;
    appearance66.BackColor = Color.WhiteSmoke;
    appearance66.BorderColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.Override.RowSelectorAppearance = (AppearanceBase) appearance66;
    appearance67.BackColor = Color.Transparent;
    appearance67.ForeColor = Color.Black;
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance67;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridSubLimits).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridSubLimits).Dock = DockStyle.Fill;
    ((Control) this.gridSubLimits).Location = new Point(2, 22);
    ((Control) this.gridSubLimits).Name = "gridSubLimits";
    ((Control) this.gridSubLimits).Size = new Size(452, 130);
    ((Control) this.gridSubLimits).TabIndex = 0;
    ((UltraControlBase) this.gridSubLimits).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridSubLimits).UseOsThemes = (DefaultableBoolean) 2;
    appearance68.ForegroundAlpha = (Alpha) 2;
    this.MgaGroupBox3.Appearance = (AppearanceBase) appearance68;
    appearance69.BackColor = Color.FromArgb(239, 247, 253);
    appearance69.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox3.ContentAreaAppearance = (AppearanceBase) appearance69;
    ((Control) this.MgaGroupBox3).Controls.Add((Control) this.txtAdditionalComments);
    ((Control) this.MgaGroupBox3).Enabled = false;
    appearance70.AlphaLevel = (short) 230;
    appearance70.FontData.SizeInPoints = 10f;
    appearance70.ForeColor = Color.White;
    appearance70.ImageAlpha = (Alpha) 2;
    appearance70.ImageBackground = (Image) componentResourceManager.GetObject("Appearance71.ImageBackground");
    appearance70.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox3.HeaderAppearance = (AppearanceBase) appearance70;
    ((Control) this.MgaGroupBox3).Location = new Point(480, 280);
    ((Control) this.MgaGroupBox3).Name = "MgaGroupBox3";
    ((Control) this.MgaGroupBox3).Size = new Size(240 /*0xF0*/, 164);
    ((Control) this.MgaGroupBox3).TabIndex = 4;
    this.MgaGroupBox3.Text = "Additional Comments";
    this.MgaGroupBox3.ViewStyle = (GroupBoxViewStyle) 2;
    appearance71.BackColor = Color.White;
    appearance71.BorderColor = Color.Gray;
    appearance71.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAdditionalComments).Appearance = (AppearanceBase) appearance71;
    ((TextEditorControlBase) this.txtAdditionalComments).BackColor = Color.White;
    ((TextEditorControlBase) this.txtAdditionalComments).BorderStyle = (UIElementBorderStyle) 1;
    ((Control) this.txtAdditionalComments).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuoteOptionCrime.AdditionalComments", true));
    ((Control) this.txtAdditionalComments).Dock = DockStyle.Fill;
    ((Control) this.txtAdditionalComments).Location = new Point(2, 22);
    this.txtAdditionalComments.Multiline = true;
    ((Control) this.txtAdditionalComments).Name = "txtAdditionalComments";
    ((Control) this.txtAdditionalComments).Size = new Size(236, 140);
    ((Control) this.txtAdditionalComments).TabIndex = 0;
    ((UltraControlBase) this.txtAdditionalComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAdditionalComments).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ddSubLimits).DataSource = (object) this.ds.lstSubLimits;
    appearance72.BorderColor = Color.Gray;
    ((UltraGridBase) this.ddSubLimits).DisplayLayout.Appearance = (AppearanceBase) appearance72;
    ((UltraGridBase) this.ddSubLimits).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand4.ColHeadersVisible = false;
    ultraGridColumn54.Header.VisiblePosition = 0;
    ultraGridColumn54.Hidden = true;
    ultraGridColumn55.Header.VisiblePosition = 1;
    ultraGridColumn55.Width = 198;
    ultraGridColumn56.Header.VisiblePosition = 2;
    ultraGridBand4.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn54,
      (object) ultraGridColumn55,
      (object) ultraGridColumn56
    });
    ultraGridBand4.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ultraGridBand4.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ultraGridColumn57.Header.VisiblePosition = 0;
    ultraGridColumn58.Header.VisiblePosition = 1;
    ultraGridColumn59.Header.VisiblePosition = 2;
    ultraGridColumn60.Header.VisiblePosition = 3;
    ultraGridColumn61.Header.VisiblePosition = 4;
    ultraGridColumn62.Header.VisiblePosition = 5;
    ultraGridColumn63.Header.VisiblePosition = 6;
    ultraGridColumn64.Header.VisiblePosition = 7;
    ultraGridBand5.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn57,
      (object) ultraGridColumn58,
      (object) ultraGridColumn59,
      (object) ultraGridColumn60,
      (object) ultraGridColumn61,
      (object) ultraGridColumn62,
      (object) ultraGridColumn63,
      (object) ultraGridColumn64
    });
    ((UltraGridBase) this.ddSubLimits).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ddSubLimits).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraDropDownBase) this.ddSubLimits).DisplayMember = "SubLimit";
    ((Control) this.ddSubLimits).Location = new Point(651, 450);
    ((Control) this.ddSubLimits).Name = "ddSubLimits";
    ((Control) this.ddSubLimits).Size = new Size(200, 40);
    ((Control) this.ddSubLimits).TabIndex = 5;
    ((UltraControlBase) this.ddSubLimits).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ddSubLimits).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ddSubLimits).ValueMember = "SubLimitID";
    ((Control) this.ddSubLimits).Visible = false;
    this.daSubLimits.DeleteCommand = this.SqlDeleteCommand3;
    this.daSubLimits.InsertCommand = this.SqlInsertCommand3;
    this.daSubLimits.SelectCommand = this.SqlSelectCommand3;
    this.daSubLimits.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteOptionCrime_Sublimits", new DataColumnMapping[8]
      {
        new DataColumnMapping("OptionSubLimitID", "OptionSubLimitID"),
        new DataColumnMapping("CrimeOptionID", "CrimeOptionID"),
        new DataColumnMapping("SubLimitID", "SubLimitID"),
        new DataColumnMapping("OriginalOptionSubLimitID", "OriginalOptionSubLimitID"),
        new DataColumnMapping("Limit", "Limit"),
        new DataColumnMapping("Deductible", "Deductible"),
        new DataColumnMapping("DeductiblePercentage", "DeductiblePercentage"),
        new DataColumnMapping("ModificationCode", "ModificationCode")
      })
    });
    this.daSubLimits.UpdateCommand = this.SqlUpdateCommand3;
    this.SqlDeleteCommand3.CommandText = "DELETE FROM tblQuoteOptionCrime_Sublimits WHERE (OptionSubLimitID = @Original_OptionSubLimitID)";
    this.SqlDeleteCommand3.Connection = this.cn;
    this.SqlDeleteCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_OptionSubLimitID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OptionSubLimitID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand3.CommandText = componentResourceManager.GetString("SqlInsertCommand3.CommandText");
    this.SqlInsertCommand3.Connection = this.cn;
    this.SqlInsertCommand3.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@CrimeOptionID", SqlDbType.Int, 4, "CrimeOptionID"),
      new SqlParameter("@SubLimitID", SqlDbType.TinyInt, 1, "SubLimitID"),
      new SqlParameter("@OriginalOptionSubLimitID", SqlDbType.Int, 4, "OriginalOptionSubLimitID"),
      new SqlParameter("@Limit", SqlDbType.Int, 4, "Limit"),
      new SqlParameter("@Deductible", SqlDbType.Int, 4, "Deductible"),
      new SqlParameter("@DeductiblePercentage", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 5, "DeductiblePercentage", DataRowVersion.Current, (object) null),
      new SqlParameter("@ModificationCode", SqlDbType.VarChar, 1, "ModificationCode")
    });
    this.SqlSelectCommand3.CommandText = componentResourceManager.GetString("SqlSelectCommand3.CommandText");
    this.SqlSelectCommand3.Connection = this.cn;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID")
    });
    this.SqlUpdateCommand3.CommandText = componentResourceManager.GetString("SqlUpdateCommand3.CommandText");
    this.SqlUpdateCommand3.Connection = this.cn;
    this.SqlUpdateCommand3.Parameters.AddRange(new SqlParameter[9]
    {
      new SqlParameter("@CrimeOptionID", SqlDbType.Int, 4, "CrimeOptionID"),
      new SqlParameter("@SubLimitID", SqlDbType.TinyInt, 1, "SubLimitID"),
      new SqlParameter("@OriginalOptionSubLimitID", SqlDbType.Int, 4, "OriginalOptionSubLimitID"),
      new SqlParameter("@Limit", SqlDbType.Int, 4, "Limit"),
      new SqlParameter("@Deductible", SqlDbType.Int, 4, "Deductible"),
      new SqlParameter("@DeductiblePercentage", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 5, "DeductiblePercentage", DataRowVersion.Current, (object) null),
      new SqlParameter("@ModificationCode", SqlDbType.VarChar, 1, "ModificationCode"),
      new SqlParameter("@Original_OptionSubLimitID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OptionSubLimitID", DataRowVersion.Original, (object) null),
      new SqlParameter("@OptionSubLimitID", SqlDbType.Int, 4, "OptionSubLimitID")
    });
    appearance73.BackColor = Color.FromArgb(239, 247, 253);
    appearance73.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupEndorsements.ContentAreaAppearance = (AppearanceBase) appearance73;
    ((Control) this.groupEndorsements).Controls.Add((Control) this.rbFlat);
    ((Control) this.groupEndorsements).Controls.Add((Control) this.rbShortRate);
    ((Control) this.groupEndorsements).Controls.Add((Control) this.rbProRata);
    ((Control) this.groupEndorsements).Controls.Add((Control) this.Label15);
    ((Control) this.groupEndorsements).Controls.Add((Control) this.txtFactor);
    ((Control) this.groupEndorsements).Controls.Add((Control) this.dtEffective);
    ((Control) this.groupEndorsements).Controls.Add((Control) this.Label16);
    ((Control) this.groupEndorsements).Controls.Add((Control) this.Label17);
    appearance74.AlphaLevel = (short) 230;
    appearance74.FontData.SizeInPoints = 10f;
    appearance74.ForeColor = Color.White;
    appearance74.ForegroundAlpha = (Alpha) 2;
    appearance74.ImageAlpha = (Alpha) 2;
    appearance74.ImageBackground = (Image) componentResourceManager.GetObject("Appearance77.ImageBackground");
    appearance74.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.groupEndorsements.HeaderAppearance = (AppearanceBase) appearance74;
    ((Control) this.groupEndorsements).Location = new Point(728, 280);
    ((Control) this.groupEndorsements).Name = "groupEndorsements";
    ((Control) this.groupEndorsements).Size = new Size(208 /*0xD0*/, 164);
    ((Control) this.groupEndorsements).TabIndex = 6;
    this.groupEndorsements.Text = "Endorsement Info";
    this.groupEndorsements.ViewStyle = (GroupBoxViewStyle) 2;
    this.rbFlat.BackColor = Color.Transparent;
    this.rbFlat.Location = new Point(72, 44);
    this.rbFlat.Name = "rbFlat";
    this.rbFlat.Size = new Size(80 /*0x50*/, 24);
    this.rbFlat.TabIndex = 24;
    this.rbFlat.Text = "Flat";
    this.rbFlat.UseVisualStyleBackColor = false;
    this.rbShortRate.BackColor = Color.Transparent;
    this.rbShortRate.Location = new Point(72, 68);
    this.rbShortRate.Name = "rbShortRate";
    this.rbShortRate.Size = new Size(80 /*0x50*/, 24);
    this.rbShortRate.TabIndex = 25;
    this.rbShortRate.Text = "Short-Rate";
    this.rbShortRate.UseVisualStyleBackColor = false;
    this.rbProRata.BackColor = Color.Transparent;
    this.rbProRata.Checked = true;
    this.rbProRata.Location = new Point(72, 23);
    this.rbProRata.Name = "rbProRata";
    this.rbProRata.Size = new Size(80 /*0x50*/, 24);
    this.rbProRata.TabIndex = 23;
    this.rbProRata.TabStop = true;
    this.rbProRata.Text = "Pro-Rata";
    this.rbProRata.UseVisualStyleBackColor = false;
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(6, 28);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(58, 13);
    this.Label15.TabIndex = 22;
    this.Label15.Text = "Calc Type:";
    this.Label15.TextAlign = ContentAlignment.MiddleRight;
    appearance75.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtFactor).Appearance = (AppearanceBase) appearance75;
    ((Control) this.txtFactor).Location = new Point(72, (int) sbyte.MaxValue);
    this.txtFactor.MaskInput = "n.nnnnnn";
    this.txtFactor.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFactor).Name = "txtFactor";
    this.txtFactor.NumericType = (NumericType) 1;
    ((Control) this.txtFactor).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.txtFactor).TabIndex = 21;
    ((UltraControlBase) this.txtFactor).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFactor).UseOsThemes = (DefaultableBoolean) 2;
    appearance76.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtEffective.Appearance = (AppearanceBase) appearance76;
    appearance77.AlphaLevel = (short) 14;
    appearance77.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance77.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance77.BackColorAlpha = (Alpha) 2;
    appearance77.BackGradientAlignment = (GradientAlignment) 4;
    appearance77.BackGradientStyle = (GradientStyle) 5;
    appearance77.BorderAlpha = (Alpha) 1;
    appearance77.BorderColor = Color.FromArgb(78, 122, 171);
    appearance77.ForeColor = Color.FromArgb(49, 85, 153);
    appearance77.ForegroundAlpha = (Alpha) 2;
    this.dtEffective.ButtonAppearance = (AppearanceBase) appearance77;
    ((Control) this.dtEffective).Location = new Point(72, 101);
    this.dtEffective.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtEffective).Name = "dtEffective";
    ((Control) this.dtEffective).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dtEffective).TabIndex = 20;
    ((UltraControlBase) this.dtEffective).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEffective).UseOsThemes = (DefaultableBoolean) 2;
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(24, 130);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(42, 13);
    this.Label16.TabIndex = 19;
    this.Label16.Text = "Factor:";
    this.Label16.TextAlign = ContentAlignment.MiddleRight;
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(12, 104);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(54, 13);
    this.Label17.TabIndex = 18;
    this.Label17.Text = "Effective:";
    this.Label17.TextAlign = ContentAlignment.MiddleRight;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(944, 501);
    this.Controls.Add((Control) this.groupEndorsements);
    this.Controls.Add((Control) this.MgaGroupBox3);
    this.Controls.Add((Control) this.MgaGroupBox2);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Controls.Add((Control) this.gridOptions);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.ddSubLimits);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmCrimeRater);
    this.Text = "Crime Rater";
    this.Controls.SetChildIndex((Control) this.ddSubLimits, 0);
    this.Controls.SetChildIndex((Control) this.dbSave, 0);
    this.Controls.SetChildIndex((Control) this.gridOptions, 0);
    this.Controls.SetChildIndex((Control) this.MgaGroupBox1, 0);
    this.Controls.SetChildIndex((Control) this.MgaGroupBox2, 0);
    this.Controls.SetChildIndex((Control) this.MgaGroupBox3, 0);
    this.Controls.SetChildIndex((Control) this.groupEndorsements, 0);
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.MgaCheckBox1).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.MgaNumericEditor27).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor26).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor25).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor22).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor23).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor24).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor19).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor20).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor21).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor16).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor17).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor18).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor13).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor14).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor15).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor10).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor11).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor12).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor7).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor8).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor9).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor4).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor5).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor6).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor3).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor2).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor1).EndInit();
    ((ISupportInitialize) this.gridOptions).EndInit();
    ((ISupportInitialize) this.MgaGroupBox2).EndInit();
    ((Control) this.MgaGroupBox2).ResumeLayout(false);
    ((ISupportInitialize) this.gridSubLimits).EndInit();
    ((ISupportInitialize) this.MgaGroupBox3).EndInit();
    ((Control) this.MgaGroupBox3).ResumeLayout(false);
    ((Control) this.MgaGroupBox3).PerformLayout();
    ((ISupportInitialize) this.txtAdditionalComments).EndInit();
    ((ISupportInitialize) this.ddSubLimits).EndInit();
    ((ISupportInitialize) this.groupEndorsements).EndInit();
    ((Control) this.groupEndorsements).ResumeLayout(false);
    ((Control) this.groupEndorsements).PerformLayout();
    ((ISupportInitialize) this.txtFactor).EndInit();
    ((ISupportInitialize) this.dtEffective).EndInit();
    this.ResumeLayout(false);
  }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblQuoteOptionCrime.TableName];
  }

  private CrimeRater CrimeRater => (CrimeRater) this.Rater;

  private void frmCrimeRater_Load(object sender, EventArgs e)
  {
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    try
    {
      this.daQuoteOptions.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this.Rater.QuoteGuid;
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daQuoteOptions, (DataTable) this.ds.tblQuoteOptions);
      this.daCrime.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this.Rater.QuoteGuid;
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daCrime, (DataTable) this.ds.tblQuoteOptionCrime);
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "lstSubLimits"
      }, CommandType.Text, "SELECT * FROM lstSubLimits ORDER BY SubLimit");
      this.daSubLimits.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this.Rater.QuoteGuid;
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSubLimits, (DataTable) this.ds.tblQuoteOptionCrime_Sublimits);
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    if (this.ds.tblQuoteOptionCrime.Count == 0)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    dsCrime.tblQuoteOptionsRow row1 = this.ds.tblQuoteOptions.NewtblQuoteOptionsRow();
    dsCrime.tblQuoteOptionsRow tblQuoteOptionsRow = row1;
    tblQuoteOptionsRow.QuoteGUID = this.Rater.QuoteGuid;
    tblQuoteOptionsRow.LineGUID = this.Rater.LineGuid;
    tblQuoteOptionsRow.DateCreated = DateAndTime.Now;
    tblQuoteOptionsRow.QuoteOptionGUID = Guid.NewGuid();
    this.ds.tblQuoteOptions.AddtblQuoteOptionsRow(row1);
    CompanyLine companyLine = new CompanyLine(this.Rater.Quote.CompanyLineGuid.Value);
    dsCrime.tblQuoteOptionCrimeRow row2 = this.ds.tblQuoteOptionCrime.NewtblQuoteOptionCrimeRow();
    row2.QuoteOptionID = row1.QuoteOptionID;
    row2.AdditionalComments = companyLine.DefaultInvoiceComments;
    if (this.Rater.Quote.IsEndorsement)
    {
      row2.EffectiveDate = this.Rater.Quote.EndorsementEffective;
      row2.EndorsementCalcType = this.Rater.Quote.EndorsementCalcType;
      this.SelectRadioButton(row2.EndorsementCalcType);
      this.dtEffective.Value = (object) row2.EffectiveDate;
      this.CalculateFactor();
      row2.Factor = this._factor;
      this.txtFactor.Value = (object) row2.Factor;
    }
    else
    {
      row2.EffectiveDate = this.Rater.Quote.EffectiveDate;
      row2.Factor = 1M;
      this.txtFactor.Value = (object) 1;
    }
    this.ds.tblQuoteOptionCrime.AddtblQuoteOptionCrimeRow(row2);
    this.bmb.Position = this.ds.tblQuoteOptionCrime.Count - 1;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    this.bmb.EndCurrentEdit();
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
    {
      try
      {
        frmCrimeRater.AssignTransaction(this.daQuoteOptions, (SqlTransaction) args.Transaction);
        frmCrimeRater.AssignTransaction(this.daCrime, (SqlTransaction) args.Transaction);
        frmCrimeRater.AssignTransaction(this.daSubLimits, (SqlTransaction) args.Transaction);
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daQuoteOptions, (DataTable) this.ds.tblQuoteOptions);
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daCrime, (DataTable) this.ds.tblQuoteOptionCrime);
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSubLimits, (DataTable) this.ds.tblQuoteOptionCrime_Sublimits);
        args.Transaction.Commit();
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        if (args.Transaction != null)
          args.Transaction.Rollback();
        throw;
      }
    }));
    this.RefreshPremiums(new QuoteOption(this.ds.tblQuoteOptionCrime[this.bmb.Position].QuoteOptionID));
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1 || MessageBox.Show("Are you sure you want to delete this option?", "Delete Option?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    int quoteOptionId = this.ds.tblQuoteOptionCrime[this.bmb.Position].QuoteOptionID;
    dsCrime.tblQuoteOptionCrime_SublimitsRow[] crimeSublimitsRowArray = this.ds.tblQuoteOptionCrime[this.bmb.Position].GettblQuoteOptionCrime_SublimitsRows();
    int index = 0;
    while (index < crimeSublimitsRowArray.Length)
    {
      crimeSublimitsRowArray[index].Delete();
      checked { ++index; }
    }
    this.ds.tblQuoteOptionCrime[this.bmb.Position].Delete();
    this.ds.tblQuoteOptions.FindByQuoteOptionID(quoteOptionId).Delete();
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
    {
      try
      {
        frmCrimeRater.AssignTransaction(this.daQuoteOptions, (SqlTransaction) args.Transaction);
        frmCrimeRater.AssignTransaction(this.daCrime, (SqlTransaction) args.Transaction);
        frmCrimeRater.AssignTransaction(this.daSubLimits, (SqlTransaction) args.Transaction);
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSubLimits, (DataTable) this.ds.tblQuoteOptionCrime_Sublimits);
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daCrime, (DataTable) this.ds.tblQuoteOptionCrime);
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daQuoteOptions, (DataTable) this.ds.tblQuoteOptions);
        args.Transaction.Commit();
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        if (args.Transaction != null)
          args.Transaction.Rollback();
        throw;
      }
    }));
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ds.tblQuoteOptionCrime_Sublimits.RejectChanges();
    this.ds.tblQuoteOptionCrime.RejectChanges();
    this.ds.tblQuoteOptions.RejectChanges();
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    bool flag = this.dbSave.UIState == UIState.Editing;
    ((Control) this.gridOptions).Enabled = !flag;
    try
    {
      foreach (Control control in this.Controls)
      {
        if (control == this.groupEndorsements)
          control.Enabled = this.Rater.Quote.IsEndorsement && flag;
        else if (control is MGAGroupBox)
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

  private void gridOptions_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridOptions).ActiveRow == null)
      return;
    Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.gridOptions).ActiveRow.Cells["ID"].Value), "ID", (DataTable) this.ds.tblQuoteOptionCrime, this.bmb);
    this.ds.tblQuoteOptionCrime_Sublimits.DefaultView.RowFilter = "CrimeOptionID=" + this.ds.tblQuoteOptionCrime[this.bmb.Position].ID.ToString();
  }

  private void RefreshPremiums(QuoteOption qo)
  {
    this.CrimeRater.RefreshPremiums(qo);
    MDIControls.Instance.StatusBarText = "Rating option...";
    this.Rater.RateOption(qo.QuoteOptionGuid);
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

  private void CalculateFactor()
  {
    if (!this.Rater.Quote.IsEndorsement)
      return;
    int days = this.Rater.Quote.ExpirationDate.Subtract(this.Rater.Quote.EffectiveDate).Days;
    DateTime dateTime = this.dtEffective.DateTime;
    DateTime expirationDate = this.Rater.Quote.ExpirationDate;
    if (this.rbShortRate.Checked)
    {
      this._factor = 1M;
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.CalculateShortRateFactor(@policyDays, @startDate, @endDate)", new object[6]
      {
        (object) "@policyDays",
        (object) days,
        (object) "@startDate",
        (object) dateTime,
        (object) "@endDate",
        (object) expirationDate
      }));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
        this._factor = Conversions.ToDecimal(objectValue);
    }
    else if (this.rbProRata.Checked)
    {
      this._factor = 1M;
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.CalculateProRata(@policyDays, @startDate, @endDate)", new object[6]
      {
        (object) "@policyDays",
        (object) days,
        (object) "@startDate",
        (object) dateTime,
        (object) "@endDate",
        (object) expirationDate
      }));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
        this._factor = Conversions.ToDecimal(objectValue);
    }
    else
      this._factor = 1M;
    if (this.bmb.Position == -1)
      return;
    this.ds.tblQuoteOptionCrime[this.bmb.Position].Factor = this._factor;
    this.txtFactor.Value = (object) this._factor;
  }

  private void dtEffective_ValueChanged(object sender, EventArgs e) => this.CalculateFactor();

  private void txtFactor_ValueChanged(object sender, EventArgs e)
  {
    if (this.bmb.Position < 0 || !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.txtFactor.Value)))
      return;
    if (Decimal.Compare(Conversions.ToDecimal(this.txtFactor.Value), this._factor) != 0)
      this.ds.tblQuoteOptionCrime[this.bmb.Position].UserOverrideFactor = Conversions.ToDecimal(this.txtFactor.Value);
    else
      this.ds.tblQuoteOptionCrime[this.bmb.Position].SetUserOverrideFactorNull();
  }

  private static void AssignTransaction(SqlDataAdapter da, SqlTransaction trans)
  {
    SqlDataAdapter sqlDataAdapter = da;
    sqlDataAdapter.SelectCommand.Transaction = trans;
    sqlDataAdapter.DeleteCommand.Transaction = trans;
    sqlDataAdapter.InsertCommand.Transaction = trans;
    sqlDataAdapter.UpdateCommand.Transaction = trans;
  }

  private void gridSubLimits_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["CrimeOptionID"].Value = (object) this.ds.tblQuoteOptionCrime[this.bmb.Position].ID;
    e.Row.Cells["ModificationCode"].Value = (object) "N";
  }
}

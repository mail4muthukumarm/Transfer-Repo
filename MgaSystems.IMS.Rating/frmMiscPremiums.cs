// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.frmMiscPremiums
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Extensions;
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
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public sealed class frmMiscPremiums : Form
{
  private IContainer components;
  private ErrorProvider err;
  private SqlDataAdapter daClientOffices;
  private SqlDataAdapter daPolicyCharges;
  private SqlCommand SqlSelectCommand4;
  private SqlDataAdapter daStates;
  private SqlCommand SqlSelectCommand5;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private MGATextBox txtAmount;
  private Label Label4;
  private UltraDropDown ddChargeCodes;
  private UltraDropDown ddOffices;
  private DataView dvChargeCodes;
  private DataView dvOffices;
  private SqlCommand SqlSelectCommand3;
  private UltraGroupBox GroupBox1;
  private dsMiscPremiums ds;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private string _lineName;
  private Quote _quote;
  private readonly int _quoteOptionID;
  private readonly QuoteOption _quoteOption;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraGrid dgOptions
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

  [field: AccessedThroughProperty("cboState")]
  private virtual MGASimpleComboBox cboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler1 = new EventHandler(this.dbSave_UIStateChanged);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingCancel);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingSave -= cancelEventHandler1;
        dbSave1.ClickingNew -= cancelEventHandler2;
        dbSave1.ClickingDelete -= cancelEventHandler3;
        dbSave1.UIStateChanged -= eventHandler1;
        dbSave1.ClickedCancel -= eventHandler2;
        dbSave1.ClickingCancel -= cancelEventHandler4;
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
      dbSave2.ClickingCancel += cancelEventHandler4;
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

  [field: AccessedThroughProperty("daMiscPremiums")]
  private virtual SqlDataAdapter daMiscPremiums { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMiscPremiums));
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblQuoteOptionMiscPremiums", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("MiscPremiumID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("QuoteOptionGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ChargeCode", -1, (object) "ddChargeCodes");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("OfficeID", -1, (object) "ddOffices");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Premium");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("StateID");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblFin_PolicyCharges", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("tblFin_PolicyChargestblQuoteOptionMiscPremiums");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblFin_PolicyChargestblQuoteOptionMiscPremiums", 0);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("MiscPremiumID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("QuoteOptionGuid");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Premium");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("StateID");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblClientOffices", -1);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("tblClientOfficestblQuoteOptionMiscPremiums");
    UltraGridBand ultraGridBand5 = new UltraGridBand("tblClientOfficestblQuoteOptionMiscPremiums", 0);
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("MiscPremiumID");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("QuoteOptionGuid");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("Premium");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("StateID");
    Appearance appearance13 = new Appearance();
    this.cboOffices = new MGASimpleComboBox();
    this.ds = new dsMiscPremiums();
    this.dvOffices = new DataView();
    this.txtAmount = new MGATextBox();
    this.Label4 = new Label();
    this.Label1 = new Label();
    this.cboState = new MGASimpleComboBox();
    this.Label2 = new Label();
    this.cboChargeCodes = new MGASimpleComboBox();
    this.dvChargeCodes = new DataView();
    this.Label3 = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.cnSQL = new SqlConnection();
    this.err = new ErrorProvider(this.components);
    this.daMiscPremiums = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.dgOptions = new UltraGrid();
    this.daClientOffices = new SqlDataAdapter();
    this.SqlSelectCommand3 = new SqlCommand();
    this.daPolicyCharges = new SqlDataAdapter();
    this.SqlSelectCommand4 = new SqlCommand();
    this.daStates = new SqlDataAdapter();
    this.SqlSelectCommand5 = new SqlCommand();
    this.ddChargeCodes = new UltraDropDown();
    this.ddOffices = new UltraDropDown();
    this.GroupBox1 = new UltraGroupBox();
    ((ISupportInitialize) this.cboOffices).BeginInit();
    this.ds.BeginInit();
    this.dvOffices.BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((ISupportInitialize) this.cboChargeCodes).BeginInit();
    this.dvChargeCodes.BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.dgOptions).BeginInit();
    ((ISupportInitialize) this.ddChargeCodes).BeginInit();
    ((ISupportInitialize) this.ddOffices).BeginInit();
    ((ISupportInitialize) this.GroupBox1).BeginInit();
    ((Control) this.GroupBox1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.cboOffices).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionMiscPremiums.OfficeID", true));
    ((UltraGridBase) this.cboOffices).DataSource = (object) this.dvOffices;
    ((UltraDropDownBase) this.cboOffices).DisplayMember = "Location";
    this.cboOffices.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboOffices).DropDownWidth = 250;
    ((Control) this.cboOffices).Location = new Point(88, 80 /*0x50*/);
    ((Control) this.cboOffices).Name = "cboOffices";
    ((Control) this.cboOffices).Size = new Size(280, 21);
    ((Control) this.cboOffices).TabIndex = 5;
    ((UltraControlBase) this.cboOffices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboOffices).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboOffices).ValueMember = "OfficeID";
    this.ds.DataSetName = "dsMiscPremiums";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.dvOffices.Table = (DataTable) this.ds.tblClientOffices;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAmount).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtAmount).BackColor = Color.White;
    ((Control) this.txtAmount).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionMiscPremiums.Premium", true));
    ((Control) this.txtAmount).Location = new Point(88, 104);
    ((Control) this.txtAmount).Name = "txtAmount";
    ((Control) this.txtAmount).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.txtAmount).TabIndex = 6;
    ((UltraControlBase) this.txtAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAmount).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(29, 106);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(48 /*0x30*/, 13);
    this.Label4.TabIndex = 7;
    this.Label4.Text = "Amount:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(42, 34);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(37, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "State:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.cboState).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionMiscPremiums.StateID", true));
    ((UltraGridBase) this.cboState).DataSource = (object) this.ds.lstStates;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboState).DropDownWidth = 200;
    ((Control) this.cboState).Location = new Point(88, 32 /*0x20*/);
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(280, 21);
    ((Control) this.cboState).TabIndex = 1;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(24, 58);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(51, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Premium:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.cboChargeCodes).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionMiscPremiums.ChargeCode", true));
    ((UltraGridBase) this.cboChargeCodes).DataSource = (object) this.dvChargeCodes;
    ((UltraDropDownBase) this.cboChargeCodes).DisplayMember = "ChargeName";
    this.cboChargeCodes.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboChargeCodes).DropDownWidth = 250;
    ((Control) this.cboChargeCodes).Location = new Point(88, 56);
    ((Control) this.cboChargeCodes).Name = "cboChargeCodes";
    ((Control) this.cboChargeCodes).Size = new Size(280, 21);
    ((Control) this.cboChargeCodes).TabIndex = 3;
    ((UltraControlBase) this.cboChargeCodes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboChargeCodes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboChargeCodes).ValueMember = "ChargeCode";
    this.dvChargeCodes.Table = (DataTable) this.ds.tblFin_PolicyCharges;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(39, 82);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(40, 13);
    this.Label3.TabIndex = 4;
    this.Label3.Text = "Office:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(408, 296);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 1;
    this.dbSave.ToolTipNew = "New Premium";
    this.cnSQL.ConnectionString = "workstation id=PSARNOWSKI2;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.err.ContainerControl = (ContainerControl) this;
    this.daMiscPremiums.DeleteCommand = this.SqlDeleteCommand1;
    this.daMiscPremiums.InsertCommand = this.SqlInsertCommand1;
    this.daMiscPremiums.SelectCommand = this.SqlSelectCommand1;
    this.daMiscPremiums.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteOptionMiscPremiums", new DataColumnMapping[5]
      {
        new DataColumnMapping("MiscPremiumID", "MiscPremiumID"),
        new DataColumnMapping("QuoteOptionGuid", "QuoteOptionGuid"),
        new DataColumnMapping("ChargeCode", "ChargeCode"),
        new DataColumnMapping("OfficeID", "OfficeID"),
        new DataColumnMapping("Premium", "Premium")
      })
    });
    this.daMiscPremiums.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblQuoteOptionMiscPremiums WHERE (MiscPremiumID = @Original_MiscPremiumID)";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_MiscPremiumID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "MiscPremiumID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@QuoteOptionGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGuid"),
      new SqlParameter("@ChargeCode", SqlDbType.Int, 4, "ChargeCode"),
      new SqlParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      new SqlParameter("@Premium", SqlDbType.Money, 8, "Premium")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@quoteOptionGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGuid")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@QuoteOptionGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGuid"),
      new SqlParameter("@ChargeCode", SqlDbType.Int, 4, "ChargeCode"),
      new SqlParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      new SqlParameter("@Premium", SqlDbType.Money, 8, "Premium"),
      new SqlParameter("@Original_MiscPremiumID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "MiscPremiumID", DataRowVersion.Original, (object) null),
      new SqlParameter("@MiscPremiumID", SqlDbType.Int, 4, "MiscPremiumID")
    });
    ((Control) this.dgOptions).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgOptions).DataSource = (object) this.ds.tblQuoteOptionMiscPremiums;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.LightGray;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.dgOptions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 86;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 263;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Item";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Style = (ColumnStyle) 6;
    ultraGridColumn3.Width = 226;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Office";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Style = (ColumnStyle) 6;
    ultraGridColumn4.Width = 170;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance7;
    ultraGridColumn5.Format = "c";
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 5;
    ultraGridColumn5.Width = 95;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 2;
    ultraGridColumn6.Width = 107;
    ultraGridBand1.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.dgOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgOptions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance9.BackColor = Color.LightSteelBlue;
    appearance9.BackColor2 = Color.White;
    appearance9.BackGradientStyle = (GradientStyle) 2;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance10.BackColor = Color.Gainsboro;
    appearance10.BackColor2 = Color.White;
    appearance10.BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance11.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = Color.White;
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    ((Control) this.dgOptions).Location = new Point(8, 8);
    ((Control) this.dgOptions).Name = "dgOptions";
    ((Control) this.dgOptions).Size = new Size(600, 184);
    ((Control) this.dgOptions).TabIndex = 0;
    ((UltraControlBase) this.dgOptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgOptions).UseOsThemes = (DefaultableBoolean) 2;
    this.daClientOffices.SelectCommand = this.SqlSelectCommand3;
    this.daClientOffices.TableMappings.AddRange(new DataTableMapping[2]
    {
      new DataTableMapping("Table", "GetRaterOffices", new DataColumnMapping[2]
      {
        new DataColumnMapping("OfficeID", "OfficeID"),
        new DataColumnMapping("Location", "Location")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[2]
      {
        new DataColumnMapping("OfficeID", "OfficeID"),
        new DataColumnMapping("Location", "Location")
      })
    });
    this.SqlSelectCommand3.CommandText = "[GetRaterOffices]";
    this.SqlSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand3.Connection = this.cnSQL;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.daPolicyCharges.SelectCommand = this.SqlSelectCommand4;
    this.daPolicyCharges.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblFin_PolicyCharges", new DataColumnMapping[2]
      {
        new DataColumnMapping("ChargeCode", "ChargeCode"),
        new DataColumnMapping("ChargeName", "ChargeName")
      })
    });
    this.SqlSelectCommand4.CommandText = "SELECT ChargeCode, StateID + ' - ' + ChargeName AS ChargeName, StateID FROM tblFin_PolicyCharges WHERE (ChargeType = 'P') AND (ChargeID <> 'PREM' AND ChargeID <> 'Terr' OR ChargeID IS NULL)";
    this.SqlSelectCommand4.Connection = this.cnSQL;
    this.daStates.SelectCommand = this.SqlSelectCommand5;
    this.daStates.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstStates", new DataColumnMapping[2]
      {
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("State", "State")
      })
    });
    this.SqlSelectCommand5.CommandText = componentResourceManager.GetString("SqlSelectCommand5.CommandText");
    this.SqlSelectCommand5.Connection = this.cnSQL;
    this.SqlSelectCommand5.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID")
    });
    ((UltraGridBase) this.ddChargeCodes).DataSource = (object) this.ds.tblFin_PolicyCharges;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 3;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 5;
    ultraGridBand3.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ((UltraGridBase) this.ddChargeCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddChargeCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddChargeCodes).DisplayMember = "ChargeName";
    ((Control) this.ddChargeCodes).Location = new Point(32 /*0x20*/, 104);
    ((Control) this.ddChargeCodes).Name = "ddChargeCodes";
    ((Control) this.ddChargeCodes).Size = new Size(312, 80 /*0x50*/);
    ((Control) this.ddChargeCodes).TabIndex = 4;
    ((UltraDropDownBase) this.ddChargeCodes).ValueMember = "ChargeCode";
    ((Control) this.ddChargeCodes).Visible = false;
    ((UltraGridBase) this.ddOffices).DataSource = (object) this.ds.tblClientOffices;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 2;
    ultraGridBand4.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19
    });
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 5;
    ultraGridBand5.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25
    });
    ((UltraGridBase) this.ddOffices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ddOffices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraDropDownBase) this.ddOffices).DisplayMember = "Location";
    ((Control) this.ddOffices).Location = new Point(352, 48 /*0x30*/);
    ((Control) this.ddOffices).Name = "ddOffices";
    ((Control) this.ddOffices).Size = new Size(208 /*0xD0*/, 80 /*0x50*/);
    ((Control) this.ddOffices).TabIndex = 5;
    ((UltraDropDownBase) this.ddOffices).ValueMember = "OfficeID";
    ((Control) this.ddOffices).Visible = false;
    appearance13.BackColor = Color.WhiteSmoke;
    this.GroupBox1.ContentAreaAppearance = (AppearanceBase) appearance13;
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label2);
    ((Control) this.GroupBox1).Controls.Add((Control) this.cboState);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label1);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label4);
    ((Control) this.GroupBox1).Controls.Add((Control) this.txtAmount);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label3);
    ((Control) this.GroupBox1).Controls.Add((Control) this.cboOffices);
    ((Control) this.GroupBox1).Controls.Add((Control) this.cboChargeCodes);
    ((Control) this.GroupBox1).Location = new Point(8, 200);
    ((Control) this.GroupBox1).Name = "GroupBox1";
    ((Control) this.GroupBox1).Size = new Size(392, 136);
    ((Control) this.GroupBox1).TabIndex = 8;
    this.GroupBox1.Text = "Premium Information";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(616, 342);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.ddOffices);
    this.Controls.Add((Control) this.ddChargeCodes);
    this.Controls.Add((Control) this.dgOptions);
    this.Controls.Add((Control) this.dbSave);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmMiscPremiums);
    this.Text = "Misc. Premiums";
    ((ISupportInitialize) this.cboOffices).EndInit();
    this.ds.EndInit();
    this.dvOffices.EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((ISupportInitialize) this.cboChargeCodes).EndInit();
    this.dvChargeCodes.EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.dgOptions).EndInit();
    ((ISupportInitialize) this.ddChargeCodes).EndInit();
    ((ISupportInitialize) this.ddOffices).EndInit();
    ((ISupportInitialize) this.GroupBox1).EndInit();
    ((Control) this.GroupBox1).ResumeLayout(false);
    ((Control) this.GroupBox1).PerformLayout();
    this.ResumeLayout(false);
  }

  public frmMiscPremiums(int quoteOptionID)
  {
    this.Load += new EventHandler(this.frmMiscPremiums_Load);
    this._lineName = string.Empty;
    this.InitializeComponent();
    this._quoteOptionID = quoteOptionID;
    this._quoteOption = new QuoteOption(this._quoteOptionID);
  }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblQuoteOptionMiscPremiums.TableName];
  }

  private Quote Quote
  {
    get
    {
      if (this._quote == null)
        this._quote = new Quote(this._quoteOption.QuoteGuid);
      return this._quote;
    }
  }

  private string LineName
  {
    get
    {
      if (this._lineName.Length == 0)
        this._lineName = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT LineName FROM lstLines WHERE (LineGUID = @LineGUID)", new object[2]
        {
          (object) "@LineGUID",
          (object) this._quoteOption.LineGuid
        });
      return this._lineName;
    }
  }

  private void frmMiscPremiums_Load(object sender, EventArgs e)
  {
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.Text = $"{this.Text} - {this.LineName}";
    this.dbSave.Enabled = !this.Quote.IsBound;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daClientOffices, (DataTable) this.ds.tblClientOffices);
    this.dvOffices.RowFilter = "0=1";
    this.daStates.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._quoteOption.QuoteGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daStates, (DataTable) this.ds.lstStates);
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daPolicyCharges, (DataTable) this.ds.tblFin_PolicyCharges);
    this.dvChargeCodes.RowFilter = "0=1";
    this.daMiscPremiums.SelectCommand.Parameters["@quoteOptionGuid"].Value = (object) this._quoteOption.QuoteOptionGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daMiscPremiums, (DataTable) this.ds.tblQuoteOptionMiscPremiums);
    this.cboState.ValueChanged += new EventHandler(this.cboState_SelectedIndexChanged);
    this.dbSave.UIState = UIState.NoRecordsNotEditing;
    this.SetScreenEnabled();
  }

  private void cboState_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.bmb.Position == -1 || this.cboState.Value == null || this.cboState.Value == DBNull.Value)
      return;
    this.ds.tblQuoteOptionMiscPremiums[this.bmb.Position].StateID = this.cboState.Value.ToString();
    this.dvChargeCodes.RowFilter = $"StateID='{this.cboState.Value.ToString()}'";
    if (this.dvChargeCodes.Count == 1)
    {
      ((UltraDropDownBase) this.cboChargeCodes).SelectedRow = ((UltraGridBase) this.cboChargeCodes).Rows[0];
      this.ds.tblQuoteOptionMiscPremiums[this.bmb.Position].ChargeCode = Conversions.ToInteger(this.cboChargeCodes.Value);
    }
    else
      ((UltraDropDownBase) this.cboChargeCodes).SelectedRow = (UltraGridRow) null;
    this.Cursor = MgaCursors.WaitCursor;
    MDIControls.Instance.StatusBarText = "Finding available offices...";
    try
    {
      Guid guid = (Guid) (RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 tblCompanyLines.CompanyLineGUID FROM tblCompanyLines INNER JOIN tblQuotes On tblCompanyLines.CompanyLocationGUID = tblQuotes.CompanyLocationGUID WHERE (tblCompanyLines.LineGUID = @LineGuid) AND (tblCompanyLines.StateID = @StateID) AND (tblQuotes.QuoteGUID = @QuoteGuid) ", new object[6]
      {
        (object) "@QuoteGuid",
        (object) this._quoteOption.QuoteGuid,
        (object) "@LineGuid",
        (object) this._quoteOption.LineGuid,
        (object) "@StateID",
        this.cboState.Value
      })) ?? throw new InvalidOperationException("No CompanyLineGuid was found for this company and line in " + this.cboState.Value.ToString()));
      string str1 = "SELECT tblClientOffices.OfficeID FROM tblOfficeLines INNER JOIN tblClientOffices ON tblOfficeLines.OfficeGuid = tblClientOffices.OfficeGUID WHERE (tblOfficeLines.CompanyLineGuid = @CompanyLineGuid)";
      this.dvOffices.RowFilter = "0=1";
      try
      {
        foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, str1, new object[2]
        {
          (object) "@CompanyLineGuid",
          (object) guid
        }).Rows)
        {
          DataView dvOffices;
          string str2 = $"{(dvOffices = this.dvOffices).RowFilter} OR OfficeID={row[0].ToString()}";
          dvOffices.RowFilter = str2;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (this.dvOffices.Count == 1)
      {
        ((UltraDropDownBase) this.cboOffices).SelectedRow = ((UltraGridBase) this.cboOffices).Rows[0];
        this.ds.tblQuoteOptionMiscPremiums[this.bmb.Position].OfficeID = Conversions.ToInteger(this.cboOffices.Value);
      }
      else
        ((UltraDropDownBase) this.cboOffices).SelectedRow = (UltraGridRow) null;
      if (this.dvChargeCodes.Count != 1 || this.dvOffices.Count != 1)
        return;
      ((TextEditorControlBase) this.txtAmount).Focus();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
      MDIControls.Instance.StatusBarText = string.Empty;
    }
  }

  private static bool IsWholeNumber(object number)
  {
    return Decimal.Compare(Conversions.ToDecimal(number), new Decimal(Conversions.ToInteger(number))) == 0;
  }

  private bool ValidForm()
  {
    bool flag = true;
    try
    {
      foreach (Control control in ((Control) this.GroupBox1).Controls)
      {
        if (control is MGASimpleComboBox)
        {
          if (((UltraCombo) control).Value == null)
          {
            this.err.SetError(control, "Please select a item from the list.");
            flag = false;
          }
          else
            this.err.SetError(control, string.Empty);
        }
        else if (control is MGATextBox)
        {
          if (control.Text.Length == 0)
          {
            this.err.SetError(control, "Please enter an amount.");
            flag = false;
          }
          else if (!Versioned.IsNumeric((object) control.Text))
          {
            this.err.SetError(control, "Please enter an amount.");
            flag = false;
          }
          else if (!frmMiscPremiums.IsWholeNumber((object) control.Text))
          {
            this.err.SetError(control, "Please enter a whole number.");
            flag = false;
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
    if (flag)
    {
      int integer1 = Conversions.ToInteger(this.cboChargeCodes.Value);
      int integer2 = Conversions.ToInteger(this.cboOffices.Value);
      string str = this.cboState.Value.ToString();
      if (this.ds.tblQuoteOptionMiscPremiums.Select($"ChargeCode={integer1.ToString()} AND OfficeID={integer2.ToString()} AND StateID='{str.ToString()}'").Length > 1)
      {
        this.err.SetError((Control) this.cboChargeCodes, "This premium item already exists.");
        flag = false;
      }
    }
    return flag;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidForm())
    {
      e.Cancel = true;
    }
    else
    {
      this.Cursor = MgaCursors.WaitCursor;
      MDIControls.Instance.StatusBarText = "Saving premiums...";
      this.bmb.EndCurrentEdit();
      if (!this.ds.HasChanges())
        return;
      try
      {
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daMiscPremiums, (DataTable) this.ds.tblQuoteOptionMiscPremiums);
        this.dbSave.UIState = UIState.Editing;
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
        MDIControls.Instance.StatusBarText = string.Empty;
      }
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.RateOptionThread));
    }
  }

  private void RateOptionThread(object state)
  {
    this.BetterInvoke((Delegate) new frmMiscPremiums.RateOptionHandler(this.RateOption), (object) this.ds.tblQuoteOptionMiscPremiums[this.bmb.Position].QuoteOptionGuid);
  }

  private void RateOption(Guid quoteOptionGuid)
  {
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    dsMiscPremiums.tblQuoteOptionMiscPremiumsRow row = this.ds.tblQuoteOptionMiscPremiums.NewtblQuoteOptionMiscPremiumsRow();
    row.QuoteOptionGuid = this._quoteOption.QuoteOptionGuid;
    this.ds.tblQuoteOptionMiscPremiums.AddtblQuoteOptionMiscPremiumsRow(row);
    this.bmb.Position = this.ds.tblQuoteOptionMiscPremiums.Count - 1;
    this.cboState.ValueChanged -= new EventHandler(this.cboState_SelectedIndexChanged);
    try
    {
      foreach (Control control in ((Control) this.GroupBox1).Controls)
      {
        if (control is MGASimpleComboBox)
        {
          ((MGASimpleComboBox) control).SelectedIndex = -1;
          ((MGASimpleComboBox) control).SelectedIndex = -1;
        }
        else if (control is TextBox)
          control.Text = string.Empty;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.cboState.ValueChanged += new EventHandler(this.cboState_SelectedIndexChanged);
    if (this.ds.lstStates.Rows.Count == 1)
    {
      ((UltraDropDownBase) this.cboState).SelectedRow = ((UltraGridBase) this.cboState).Rows[0];
    }
    else
    {
      if (this.ds.lstStates.FindByStateID(this.Quote.StateID) == null)
        return;
      this.cboState.Value = (object) this.Quote.StateID;
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.dgOptions).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select a premium row to delete.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to delete this premium?\n\nThis will remove any commissionable entities applied to this premium.", "Delete Option?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        int MiscPremiumID = (int) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["MiscPremiumID"].Value;
        if (this.ds.tblQuoteOptionMiscPremiums.FindByMiscPremiumID(MiscPremiumID).RowState != DataRowState.Added)
        {
          this.Cursor = MgaCursors.WaitCursor;
          try
          {
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteOptionMiscPremiums WHERE MiscPremiumID=@MiscPremiumID", new object[2]
            {
              (object) "@MiscPremiumID",
              (object) MiscPremiumID
            });
            this.ds.tblQuoteOptionMiscPremiums.FindByMiscPremiumID(MiscPremiumID).Delete();
            this.ds.tblQuoteOptionMiscPremiums.AcceptChanges();
          }
          finally
          {
            this.Cursor = MgaCursors.Default;
          }
        }
      }
      e.Cancel = true;
    }
  }

  private void SetScreenEnabled()
  {
    ((Control) this.dgOptions).Enabled = this.dbSave.UIState != UIState.Editing;
    try
    {
      foreach (Control control in ((Control) this.GroupBox1).Controls)
        control.Enabled = this.dbSave.UIState == UIState.Editing;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e) => this.SetScreenEnabled();

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    try
    {
      this.ds.tblQuoteOptionMiscPremiums.RejectChanges();
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    try
    {
      foreach (Control control in ((Control) this.GroupBox1).Controls)
        this.err.SetError(control, string.Empty);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void dgOptions_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.Row.Cells["Premium"].Value)) || Decimal.Compare(Conversions.ToDecimal(e.Row.Cells["Premium"].Value), 0M) >= 0)
      return;
    e.Row.Cells["Premium"].Appearance.ForeColor = Color.Red;
  }

  private void dgOptions_AfterRowActivate(object sender, EventArgs e)
  {
    if (this.ds.tblQuoteOptionMiscPremiums[this.bmb.Position].RowState == DataRowState.Added)
      return;
    Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgOptions).ActiveRow.Cells["MiscPremiumID"].Value), "MiscPremiumID", (DataTable) this.ds.tblQuoteOptionMiscPremiums, this.bmb);
    this.cboState.ValueChanged -= new EventHandler(this.cboState_SelectedIndexChanged);
    this.cboState.Value = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgOptions).ActiveRow.Cells["StateID"].Value);
    this.cboState_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
    this.cboState.ValueChanged += new EventHandler(this.cboState_SelectedIndexChanged);
    this.dvChargeCodes.RowFilter = $"StateID='{this.cboState.Value.ToString()}'";
    this.cboChargeCodes.Value = (object) (int) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["ChargeCode"].Value;
    this.cboOffices.Value = (object) (int) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["OfficeID"].Value;
    ((TextEditorControlBase) this.txtAmount).Text = Strings.FormatNumber((object) (Decimal) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["Premium"].Value, 2, TriState.True, TriState.False, TriState.False);
    this.ds.tblQuoteOptionMiscPremiums[this.bmb.Position].AcceptChanges();
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private void cboChargeCodes_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboChargeCodes.Text, string.Empty, false) == 0)
      return;
    this.ds.tblQuoteOptionMiscPremiums[this.bmb.Position].ChargeCode = (int) this.cboChargeCodes.Value;
  }

  private void cboOffices_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboOffices.Text, string.Empty, false) == 0)
      return;
    this.ds.tblQuoteOptionMiscPremiums[this.bmb.Position].OfficeID = (int) this.cboOffices.Value;
  }

  private void cnSQL_InfoMessage(object sender, SqlInfoMessageEventArgs e)
  {
    int num = (int) MessageBox.Show(e.Message, "Premium Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
  }

  private delegate void RateOptionHandler(Guid quoteOptionGuid);
}

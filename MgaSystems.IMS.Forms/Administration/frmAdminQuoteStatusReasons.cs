// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Administration.frmAdminQuoteStatusReasons
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Tools;
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
namespace MGASystems.IMS.Forms.Administration;

public class frmAdminQuoteStatusReasons : Form
{
  private IContainer components;
  private SqlDataAdapter daReasons;
  private dsQuoteStatusReasons ds;
  private UltraDropDown ddStatus;
  private SqlCommand SqlSelectCommand2;
  private SqlDataAdapter daStatus;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private Color _defaultColor;
  private bool _formLoading;

  public frmAdminQuoteStatusReasons()
  {
    this.Load += new EventHandler(this.frmAdminQuoteStatusReasons_Load);
    this._formLoading = true;
    this.InitializeComponent();
  }

  private virtual UltraGrid dgReasons
  {
    get => this._dgReasons;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.dgReasons_InitializeRow);
      CellEventHandler cellEventHandler1 = new CellEventHandler(this.dgReasons_ClickCellButton);
      CellEventHandler cellEventHandler2 = new CellEventHandler(this.dgReasons_ClickCellButton);
      CellEventHandler cellEventHandler3 = new CellEventHandler(this.dgReasons_AfterCellUpdate);
      BeforeRowInsertEventHandler insertEventHandler = new BeforeRowInsertEventHandler(this.dgReasons_BeforeRowInsert);
      RowEventHandler rowEventHandler = new RowEventHandler(this.dgReasons_AfterRowInsert);
      UltraGrid dgReasons1 = this._dgReasons;
      if (dgReasons1 != null)
      {
        dgReasons1.InitializeRow -= initializeRowEventHandler;
        dgReasons1.ClickCellButton -= cellEventHandler1;
        dgReasons1.CellChange -= cellEventHandler2;
        dgReasons1.AfterCellUpdate -= cellEventHandler3;
        dgReasons1.BeforeRowInsert -= insertEventHandler;
        dgReasons1.AfterRowInsert -= rowEventHandler;
      }
      this._dgReasons = value;
      UltraGrid dgReasons2 = this._dgReasons;
      if (dgReasons2 == null)
        return;
      dgReasons2.InitializeRow += initializeRowEventHandler;
      dgReasons2.ClickCellButton += cellEventHandler1;
      dgReasons2.CellChange += cellEventHandler2;
      dgReasons2.AfterCellUpdate += cellEventHandler3;
      dgReasons2.BeforeRowInsert += insertEventHandler;
      dgReasons2.AfterRowInsert += rowEventHandler;
    }
  }

  private virtual MGAButton btnSave
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

  private virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ddLine")]
  private virtual UltraDropDown ddLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ucpDisplayColor")]
  internal virtual UltraColorPicker ucpDisplayColor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColorDialog1")]
  internal virtual ColorDialog ColorDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkClearLines
  {
    get => this._lnkClearLines;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkClearLines_LinkClicked);
      LinkLabel lnkClearLines1 = this._lnkClearLines;
      if (lnkClearLines1 != null)
        lnkClearLines1.LinkClicked -= clickedEventHandler;
      this._lnkClearLines = value;
      LinkLabel lnkClearLines2 = this._lnkClearLines;
      if (lnkClearLines2 == null)
        return;
      lnkClearLines2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkDeAct
  {
    get => this._lnkDeAct;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeAct_LinkClicked);
      LinkLabel lnkDeAct1 = this._lnkDeAct;
      if (lnkDeAct1 != null)
        lnkDeAct1.LinkClicked -= clickedEventHandler;
      this._lnkDeAct = value;
      LinkLabel lnkDeAct2 = this._lnkDeAct;
      if (lnkDeAct2 == null)
        return;
      lnkDeAct2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ddGroupCode")]
  private virtual UltraDropDown ddGroupCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkClearGroupCode
  {
    get => this._lnkClearGroupCode;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkClearGroupCode_LinkClicked);
      LinkLabel lnkClearGroupCode1 = this._lnkClearGroupCode;
      if (lnkClearGroupCode1 != null)
        lnkClearGroupCode1.LinkClicked -= clickedEventHandler;
      this._lnkClearGroupCode = value;
      LinkLabel lnkClearGroupCode2 = this._lnkClearGroupCode;
      if (lnkClearGroupCode2 == null)
        return;
      lnkClearGroupCode2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ddEvents")]
  private virtual UltraDropDown ddEvents { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstQuoteStatusReasons", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("QuoteStatusID", -1, (object) "ddStatus");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Reason");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("AutomationID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("LineGuid", -1, (object) "ddLine");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("DisplayColor");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("EventGuid", -1, (object) "ddEvents");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("GroupCode", -1, (object) "ddGroupCode");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdminQuoteStatusReasons));
    Appearance appearance12 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstQuoteStatus", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("QuoteStatusID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("EventGuid");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("lstQuoteStatuslstQuoteStatusReasons");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstQuoteStatuslstQuoteStatusReasons", 0);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("QuoteStatusID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Reason");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("AutomationID");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("DisplayColor");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("EventGuid");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("GroupCode");
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("lstLines_lstQuoteStatusReasons");
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstLines_lstQuoteStatusReasons", 0);
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("QuoteStatusID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("Reason");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("AutomationID");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("DisplayColor");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("EventGuid");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("GroupCode");
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance16 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("lstLineGroups", -1);
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("GroupCode");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("GroupName");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("lstLineGroups_lstQuoteStatusReasons");
    UltraGridBand ultraGridBand7 = new UltraGridBand("lstLineGroups_lstQuoteStatusReasons", 0);
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("QuoteStatusID");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("Reason");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("AutomationID");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("DisplayColor");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("EventGuid");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("GroupCode");
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance17 = new Appearance();
    UltraGridBand ultraGridBand8 = new UltraGridBand("lstAutomationDocumentEvents", -1);
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("EventGuid");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("EventName");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("lstAutomationDocumentEvents_lstQuoteStatusReasons");
    UltraGridBand ultraGridBand9 = new UltraGridBand("lstAutomationDocumentEvents_lstQuoteStatusReasons", 0);
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("QuoteStatusID");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("Reason");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("AutomationID");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("DisplayColor");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("EventGuid");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("GroupCode");
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    this.ucpDisplayColor = new UltraColorPicker();
    this.ds = new dsQuoteStatusReasons();
    this.dgReasons = new UltraGrid();
    this.daReasons = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.ddStatus = new UltraDropDown();
    this.daStatus = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.ddLine = new UltraDropDown();
    this.ColorDialog1 = new ColorDialog();
    this.lnkClearLines = new LinkLabel();
    this.lnkDeAct = new LinkLabel();
    this.ddGroupCode = new UltraDropDown();
    this.lnkClearGroupCode = new LinkLabel();
    this.ddEvents = new UltraDropDown();
    ((ISupportInitialize) this.ucpDisplayColor).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.dgReasons).BeginInit();
    ((ISupportInitialize) this.ddStatus).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.ddLine).BeginInit();
    ((ISupportInitialize) this.ddGroupCode).BeginInit();
    ((ISupportInitialize) this.ddEvents).BeginInit();
    this.SuspendLayout();
    this.ucpDisplayColor.Color = Color.Empty;
    ((TextEditorControlBase) this.ucpDisplayColor).DisplayStyle = (EmbeddableElementDisplayStyle) 1;
    ((Control) this.ucpDisplayColor).Location = new Point(645, 190);
    ((Control) this.ucpDisplayColor).Name = "ucpDisplayColor";
    ((EditorButtonControlBase) this.ucpDisplayColor).ShowInkButton = (ShowInkButton) 2;
    ((Control) this.ucpDisplayColor).Size = new Size(144 /*0x90*/, 22);
    ((Control) this.ucpDisplayColor).TabIndex = 7;
    ((Control) this.ucpDisplayColor).Visible = false;
    this.ds.DataSetName = "dsQuoteStatusReasons";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.dgReasons).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.dgReasons).Cursor = Cursors.Hand;
    ((UltraGridBase) this.dgReasons).DataSource = (object) this.ds.lstQuoteStatusReasons;
    appearance1.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.dgReasons).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.WhiteSmoke;
    appearance2.BorderColor = Color.WhiteSmoke;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((UltraGridBase) this.dgReasons).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.dgReasons).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.dgReasons).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.dgReasons).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgReasons).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgReasons).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand1.AddButtonCaption = "Add new status reason...";
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 146;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Status";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Style = (ColumnStyle) 6;
    ultraGridColumn2.Width = 287;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 282;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Style = (ColumnStyle) 6;
    appearance4.ForeColor = Color.Transparent;
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn6.DefaultCellValue = (object) "-16777216";
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Color";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 7;
    ultraGridColumn6.MaxWidth = 40;
    ultraGridColumn6.Style = (ColumnStyle) 8;
    ultraGridColumn6.Width = 39;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Event";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 5;
    ultraGridColumn7.Style = (ColumnStyle) 6;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Group Code";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 6;
    ultraGridColumn8.Style = (ColumnStyle) 6;
    ultraGridColumn8.Width = 70;
    ultraGridBand1.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgReasons).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgReasons).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance5.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance9.BackColor = Color.Transparent;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.WhiteSmoke;
    appearance10.BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dgReasons).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.dgReasons).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgReasons).Location = new Point(0, 0);
    ((Control) this.dgReasons).Name = "dgReasons";
    ((Control) this.dgReasons).Size = new Size(1003, 498);
    ((Control) this.dgReasons).TabIndex = 2;
    ((UltraControlBase) this.dgReasons).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgReasons).UseOsThemes = (DefaultableBoolean) 2;
    this.daReasons.DeleteCommand = this.SqlDeleteCommand1;
    this.daReasons.InsertCommand = this.SqlInsertCommand1;
    this.daReasons.SelectCommand = this.SqlSelectCommand1;
    this.daReasons.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstQuoteStatusReasons", new DataColumnMapping[8]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("QuoteStatusID", "QuoteStatusID"),
        new DataColumnMapping("Reason", "Reason"),
        new DataColumnMapping("AutomationID", "AutomationID"),
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("DisplayColor", "DisplayColor"),
        new DataColumnMapping("EventGuid", "EventGuid"),
        new DataColumnMapping("GroupCode", "GroupCode")
      })
    });
    this.daReasons.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = componentResourceManager.GetString("SqlDeleteCommand1.CommandText");
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[12]
    {
      new SqlParameter("@Original_ID", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_QuoteStatusID", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteStatusID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Reason", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Reason", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_AutomationID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AutomationID", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_AutomationID", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutomationID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_LineGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LineGuid", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_LineGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_DisplayColor", SqlDbType.BigInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DisplayColor", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_EventGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EventGuid", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_EventGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "EventGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_GroupCode", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GroupCode", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_GroupCode", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GroupCode", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[8]
    {
      new SqlParameter("@ID", SqlDbType.SmallInt, 0, "ID"),
      new SqlParameter("@QuoteStatusID", SqlDbType.TinyInt, 0, "QuoteStatusID"),
      new SqlParameter("@Reason", SqlDbType.VarChar, 0, "Reason"),
      new SqlParameter("@AutomationID", SqlDbType.VarChar, 0, "AutomationID"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 0, "LineGuid"),
      new SqlParameter("@DisplayColor", SqlDbType.BigInt, 0, "DisplayColor"),
      new SqlParameter("@EventGuid", SqlDbType.UniqueIdentifier, 0, "EventGuid"),
      new SqlParameter("@GroupCode", SqlDbType.Char, 0, "GroupCode")
    });
    this.SqlSelectCommand1.CommandText = "SELECT        ID, QuoteStatusID, Reason, AutomationID, LineGuid, DisplayColor, EventGuid, GroupCode\r\nFROM            lstQuoteStatusReasons";
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[20]
    {
      new SqlParameter("@ID", SqlDbType.SmallInt, 0, "ID"),
      new SqlParameter("@QuoteStatusID", SqlDbType.TinyInt, 0, "QuoteStatusID"),
      new SqlParameter("@Reason", SqlDbType.VarChar, 0, "Reason"),
      new SqlParameter("@AutomationID", SqlDbType.VarChar, 0, "AutomationID"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 0, "LineGuid"),
      new SqlParameter("@DisplayColor", SqlDbType.BigInt, 0, "DisplayColor"),
      new SqlParameter("@EventGuid", SqlDbType.UniqueIdentifier, 0, "EventGuid"),
      new SqlParameter("@GroupCode", SqlDbType.Char, 0, "GroupCode"),
      new SqlParameter("@Original_ID", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_QuoteStatusID", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteStatusID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Reason", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Reason", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_AutomationID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AutomationID", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_AutomationID", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutomationID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_LineGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LineGuid", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_LineGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_DisplayColor", SqlDbType.BigInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DisplayColor", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_EventGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "EventGuid", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_EventGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "EventGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_GroupCode", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "GroupCode", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_GroupCode", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GroupCode", DataRowVersion.Original, (object) null)
    });
    ((UltraControlBase) this.ddStatus).Cursor = Cursors.Default;
    ((UltraGridBase) this.ddStatus).DataSource = (object) this.ds.lstQuoteStatus;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ddStatus).DisplayLayout.Appearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ddStatus).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 0;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 1;
    ultraGridColumn10.Width = 422;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 2;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 3;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12
    });
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 0;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 1;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 2;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 3;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 7;
    ultraGridBand3.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20
    });
    ((UltraGridBase) this.ddStatus).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddStatus).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ddStatus).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ddStatus).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraDropDownBase) this.ddStatus).DisplayMember = "Description";
    ((Control) this.ddStatus).Location = new Point(168, 104);
    ((Control) this.ddStatus).Name = "ddStatus";
    ((Control) this.ddStatus).Size = new Size(424, 79);
    ((Control) this.ddStatus).TabIndex = 3;
    ((Control) this.ddStatus).Text = "UltraDropDown1";
    ((UltraControlBase) this.ddStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ddStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ddStatus).ValueMember = "QuoteStatusID";
    ((Control) this.ddStatus).Visible = false;
    this.daStatus.SelectCommand = this.SqlSelectCommand2;
    this.daStatus.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstQuoteStatus", new DataColumnMapping[2]
      {
        new DataColumnMapping("QuoteStatusID", "QuoteStatusID"),
        new DataColumnMapping("Description", "Description")
      })
    });
    this.SqlSelectCommand2.CommandText = "SELECT     QuoteStatusID, Description, EventGuid \r\nFROM         dbo.lstQuoteStatus\r\nORDER BY Description";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance13.BackColor = Color.Gainsboro;
    appearance13.BackColor2 = Color.White;
    appearance13.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance13;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(955, 507);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 39);
    ((Control) this.btnSave).TabIndex = 4;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance14.BackColor = Color.Gainsboro;
    appearance14.BackColor2 = Color.White;
    appearance14.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance14;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(907, 507);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 39);
    ((Control) this.btnCancel).TabIndex = 5;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((UltraControlBase) this.ddLine).Cursor = Cursors.Default;
    ((UltraGridBase) this.ddLine).DataMember = "lstLines";
    ((UltraGridBase) this.ddLine).DataSource = (object) this.ds;
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ddLine).DisplayLayout.Appearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ddLine).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand4.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 0;
    ultraGridColumn21.Hidden = true;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 2;
    ultraGridBand4.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23
    });
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 7;
    ultraGridBand5.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31
    });
    ((UltraGridBase) this.ddLine).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ddLine).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ddLine).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddLine).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddLine).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ddLine).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((UltraDropDownBase) this.ddLine).DisplayMember = "LineName";
    ((Control) this.ddLine).Location = new Point(168, 190);
    ((Control) this.ddLine).Name = "ddLine";
    ((Control) this.ddLine).Size = new Size(424, 80 /*0x50*/);
    ((Control) this.ddLine).TabIndex = 6;
    ((Control) this.ddLine).Text = "UltraDropDown1";
    ((UltraControlBase) this.ddLine).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ddLine).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ddLine).ValueMember = "LineGUID";
    ((Control) this.ddLine).Visible = false;
    this.lnkClearLines.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkClearLines.AutoSize = true;
    this.lnkClearLines.Location = new Point(495, 533);
    this.lnkClearLines.Name = "lnkClearLines";
    this.lnkClearLines.Size = new Size(133, 13);
    this.lnkClearLines.TabIndex = 9;
    this.lnkClearLines.TabStop = true;
    this.lnkClearLines.Text = "Clear Line on Current Row";
    this.lnkDeAct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeAct.AutoSize = true;
    this.lnkDeAct.Location = new Point(276, 533);
    this.lnkDeAct.Name = "lnkDeAct";
    this.lnkDeAct.Size = new Size(104, 13);
    this.lnkDeAct.TabIndex = 10;
    this.lnkDeAct.TabStop = true;
    this.lnkDeAct.Text = "DeActivate Reasons";
    ((UltraControlBase) this.ddGroupCode).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ddGroupCode).DataMember = "lstLineGroups";
    ((UltraGridBase) this.ddGroupCode).DataSource = (object) this.ds;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ddGroupCode).DisplayLayout.Appearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.ddGroupCode).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand6.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 0;
    ultraGridColumn32.Hidden = true;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 2;
    ultraGridBand6.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34
    });
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 7;
    ultraGridBand7.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42
    });
    ((UltraGridBase) this.ddGroupCode).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.ddGroupCode).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    ((UltraGridBase) this.ddGroupCode).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddGroupCode).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddGroupCode).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    scrollBarLook4.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ddGroupCode).DisplayLayout.ScrollBarLook = scrollBarLook4;
    ((UltraDropDownBase) this.ddGroupCode).DisplayMember = "GroupName";
    ((Control) this.ddGroupCode).Location = new Point(168, 286);
    ((Control) this.ddGroupCode).Name = "ddGroupCode";
    ((Control) this.ddGroupCode).Size = new Size(424, 82);
    ((Control) this.ddGroupCode).TabIndex = 11;
    ((Control) this.ddGroupCode).Text = "UltraDropDown1";
    ((UltraControlBase) this.ddGroupCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ddGroupCode).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ddGroupCode).ValueMember = "GroupCode";
    ((Control) this.ddGroupCode).Visible = false;
    this.lnkClearGroupCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkClearGroupCode.AutoSize = true;
    this.lnkClearGroupCode.Location = new Point(680, 533);
    this.lnkClearGroupCode.Name = "lnkClearGroupCode";
    this.lnkClearGroupCode.Size = new Size(92, 13);
    this.lnkClearGroupCode.TabIndex = 12;
    this.lnkClearGroupCode.TabStop = true;
    this.lnkClearGroupCode.Text = "Clear Group Code";
    ((UltraControlBase) this.ddEvents).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ddEvents).DataMember = "lstAutomationDocumentEvents";
    ((UltraGridBase) this.ddEvents).DataSource = (object) this.ds;
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ddEvents).DisplayLayout.Appearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.ddEvents).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand8.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 1;
    ultraGridColumn43.Hidden = true;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 2;
    ultraGridBand8.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45
    });
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 7;
    ultraGridBand9.Columns.AddRange(new object[8]
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
    ((UltraGridBase) this.ddEvents).DisplayLayout.BandsSerializer.Add((object) ultraGridBand8);
    ((UltraGridBase) this.ddEvents).DisplayLayout.BandsSerializer.Add((object) ultraGridBand9);
    ((UltraGridBase) this.ddEvents).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    scrollBarLook5.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ddEvents).DisplayLayout.ScrollBarLook = scrollBarLook5;
    ((UltraDropDownBase) this.ddEvents).DisplayMember = "EventName";
    ((Control) this.ddEvents).Location = new Point(609, 286);
    ((Control) this.ddEvents).Name = "ddEvents";
    ((Control) this.ddEvents).Size = new Size(288, 79);
    ((Control) this.ddEvents).TabIndex = 13;
    ((Control) this.ddEvents).Text = "UltraDropDown1";
    ((UltraControlBase) this.ddEvents).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ddEvents).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ddEvents).ValueMember = "EventGuid";
    ((Control) this.ddEvents).Visible = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(1003, 553);
    this.Controls.Add((Control) this.ddEvents);
    this.Controls.Add((Control) this.lnkClearGroupCode);
    this.Controls.Add((Control) this.ddGroupCode);
    this.Controls.Add((Control) this.lnkDeAct);
    this.Controls.Add((Control) this.lnkClearLines);
    this.Controls.Add((Control) this.ucpDisplayColor);
    this.Controls.Add((Control) this.ddLine);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.ddStatus);
    this.Controls.Add((Control) this.dgReasons);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (frmAdminQuoteStatusReasons);
    this.Text = "Quote Status Reasons Administration";
    ((ISupportInitialize) this.ucpDisplayColor).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.dgReasons).EndInit();
    ((ISupportInitialize) this.ddStatus).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.ddLine).EndInit();
    ((ISupportInitialize) this.ddGroupCode).EndInit();
    ((ISupportInitialize) this.ddEvents).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void frmAdminQuoteStatusReasons_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    this.ResetQuoteStatusColum(true);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[4]
    {
      this.ds.lstLineGroups.TableName,
      this.ds.lstLines.TableName,
      this.ds.lstAutomationDocumentEvents.TableName,
      this.ds.lstQuoteStatus.TableName
    }, "sp_GetquoteStatusReasonsFormData");
    dsQuoteStatusReasons.lstLinesRow lstLinesRow = this.ds.lstLines.AddlstLinesRow(Guid.Empty, "ALL");
    this.ds.lstLineGroups.AddlstLineGroupsRow("$$", "ALL");
    try
    {
      Utility.SetDataAdapterConnections((DbDataAdapter) this.daReasons, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daReasons, (DataTable) this.ds.lstQuoteStatusReasons);
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    List<int> intList = new List<int>();
    try
    {
      foreach (dsQuoteStatusReasons.lstQuoteStatusReasonsRow row in this.ds.lstQuoteStatusReasons.Rows)
      {
        if (!row.IsAutomationIDNull())
          intList.Add(row.ID);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (int ID in intList)
        this.ds.lstQuoteStatusReasons.RemovelstQuoteStatusReasonsRow(this.ds.lstQuoteStatusReasons.FindByID(ID));
    }
    finally
    {
      List<int>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this._defaultColor = ((UltraGridBase) this.dgReasons).Rows[0].Cells["Reason"].Appearance.ForeColor;
    this.MarkDeactivateReasons();
    try
    {
      foreach (dsQuoteStatusReasons.lstQuoteStatusReasonsRow row in this.ds.lstQuoteStatusReasons.Rows)
      {
        if (row.lstLinesRow == null)
          row.lstLinesRow = lstLinesRow;
        else if (row.lstLinesRow != null && row.lstLinesRow.LineName == null)
          row.lstLinesRow.LineName = "All";
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.FilterRows();
    this._formLoading = false;
  }

  protected dsQuoteStatusReasons GetDataSet() => this.ds;

  protected virtual void FilterRows()
  {
  }

  private object GetDefaultEventForStatus(int quoteStatusId)
  {
    dsQuoteStatusReasons.lstQuoteStatusRow byQuoteStatusId = this.ds.lstQuoteStatus.FindByQuoteStatusID(quoteStatusId);
    return byQuoteStatusId == null || byQuoteStatusId.IsEventGuidNull() ? (object) DBNull.Value : (object) byQuoteStatusId.EventGuid;
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnSave_Click(object sender, EventArgs e)
  {
    try
    {
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daReasons, (DataTable) this.ds.lstQuoteStatusReasons);
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      if (ex2.Message.Contains("FK_tblQuotes_lstQuoteStatusReasons"))
      {
        int num = (int) MessageBox.Show("The quote status reason you are trying to remove has already been applied to a quote and cannot be removed.", "Cannot Remove Quote Status Reason", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
        ErrorHandler.HandleError(ex2);
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.Close();
    }
  }

  private void dgReasons_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    Color color = Color.FromArgb(Conversions.ToInteger(e.Row.Cells["DisplayColor"].Value));
    e.Row.Cells["DisplayColor"].ButtonAppearance.BackColor = color;
    e.Row.Cells["DisplayColor"].ButtonAppearance.ForeColor = color;
    e.Row.Cells["DisplayColor"].Appearance.BackColor = color;
    e.Row.Cells["DisplayColor"].Appearance.ForeColor = color;
    if (!e.Row.IsAddRow)
      return;
    this.ResetQuoteStatusColum(false);
  }

  private void dgReasons_ClickCellButton(object sender, CellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "DisplayColor", false) != 0)
      return;
    this.ColorDialog1.Color = Color.FromArgb(Conversions.ToInteger(e.Cell.Value));
    if (this.ColorDialog1.ShowDialog((IWin32Window) this) != DialogResult.OK)
      return;
    Color color = this.ColorDialog1.Color;
    e.Cell.Value = (object) color.ToArgb();
    e.Cell.ButtonAppearance.BackColor = color;
    e.Cell.ButtonAppearance.ForeColor = color;
    e.Cell.Appearance.BackColor = color;
    e.Cell.Appearance.ForeColor = color;
  }

  private void lnkClearLines_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraGridBase) this.dgReasons).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select an active row in the grid to continue.", "Active Row Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (((UltraGridBase) this.dgReasons).ActiveRow.Cells["LineGuid"].Value == null || ((UltraGridBase) this.dgReasons).ActiveRow.Cells["LineGuid"].Value == DBNull.Value || DialogResult.Yes != MessageBox.Show($"Clear Line the following line - \n\n{this.ds.lstLines.FindByLineGUID((Guid) ((UltraGridBase) this.dgReasons).ActiveRow.Cells["LineGuid"].Value).LineName}\n\nContinue?", "Clear Line", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        return;
      this.ds.lstQuoteStatusReasons.FindByID(Conversions.ToInteger(((UltraGridBase) this.dgReasons).ActiveRow.Cells["ID"].Value)).SetLineGuidNull();
      ((UltraGridBase) this.dgReasons).ActiveRow.Cells["LineGuid"].Value = (object) DBNull.Value;
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    if (this.lnkClearLines != null)
      this.lnkClearLines.Dispose();
    base.Dispose(disposing);
  }

  private void lnkDeAct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowFormDialog(typeof (FormDeactivateReasons)).Dispose();
    this.MarkDeactivateReasons();
  }

  private void MarkDeactivateReasons()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "select ReasonID from lstDeActivateReasons with (nolock)");
    foreach (UltraGridRow row in ((UltraGridBase) this.dgReasons).Rows)
    {
      if (dataTable.Select("ReasonID=" + row.Cells["ID"].Value.ToString()).Length > 0)
      {
        row.Activation = (Activation) 3;
        row.Cells["Reason"].Appearance.ForeColor = Color.Red;
        row.Cells["Reason"].Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
      }
      else
      {
        row.Activation = (Activation) 0;
        row.Cells["Reason"].Appearance.ForeColor = this._defaultColor;
        row.Cells["Reason"].Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
      }
    }
  }

  private void LnkClearGroupCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraGridBase) this.dgReasons).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select an active row in the grid to continue.", "Active Row Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (((UltraGridBase) this.dgReasons).ActiveRow.Cells["GroupCode"].Value == null || ((UltraGridBase) this.dgReasons).ActiveRow.Cells["GroupCode"].Value == DBNull.Value || DialogResult.Yes != MessageBox.Show($"Clear the following Group Code - \n\n{((UltraGridBase) this.dgReasons).ActiveRow.Cells["GroupCode"].Text}\n\nContinue?", "Clear Group Code", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        return;
      this.ds.lstQuoteStatusReasons.FindByID(Conversions.ToInteger(((UltraGridBase) this.dgReasons).ActiveRow.Cells["ID"].Value)).SetGroupCodeNull();
      ((UltraGridBase) this.dgReasons).ActiveRow.Cells["GroupCode"].Value = (object) DBNull.Value;
    }
  }

  private void dgReasons_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "QuoteStatusID", false) != 0)
      return;
    if (this._formLoading)
      return;
    try
    {
      this.dgReasons.AfterCellUpdate -= new CellEventHandler(this.dgReasons_AfterCellUpdate);
      e.Cell.Row.Cells["eventguid"].Value = RuntimeHelpers.GetObjectValue(this.GetDefaultEventForStatus(Conversions.ToInteger(e.Cell.Value)));
    }
    finally
    {
      this.dgReasons.AfterCellUpdate += new CellEventHandler(this.dgReasons_AfterCellUpdate);
    }
  }

  private void ResetQuoteStatusColum(bool makeReadonly)
  {
    UltraGridBand band = ((UltraGridBase) this.dgReasons).DisplayLayout.Bands[0];
    band.Columns["QuoteStatusID"].CellActivation = (Activation) 3;
    if (makeReadonly)
      return;
    band.Columns["QuoteStatusID"].CellActivation = (Activation) 0;
  }

  private void dgReasons_BeforeRowInsert(object sender, BeforeRowInsertEventArgs e)
  {
    this.ResetQuoteStatusColum(false);
  }

  private void dgReasons_AfterRowInsert(object sender, RowEventArgs e)
  {
    if (!e.Row.IsAddRow)
      return;
    this.ResetQuoteStatusColum(false);
  }
}

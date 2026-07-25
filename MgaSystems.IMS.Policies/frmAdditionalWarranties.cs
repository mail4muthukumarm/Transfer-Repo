// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmAdditionalWarranties
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Policies.FormsConditionsWarranties;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class frmAdditionalWarranties : Form
{
  private IContainer components;
  private DbDataAdapter da;
  private UltraDropDown ddItemTypes;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  private int _quoteID;
  private Guid _quoteguid;
  private bool _bInsertRow;
  private string _tabSelected;
  private string _itemTypeToShow;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  protected virtual UltraGrid UltraGrid1
  {
    get => this._UltraGrid1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler = new RowEventHandler(this.UltraGrid1_AfterRowInsert);
      CancelableRowEventHandler cancelableRowEventHandler = new CancelableRowEventHandler(this.UltraGrid1_BeforeRowUpdate);
      CellEventHandler cellEventHandler = new CellEventHandler(this.UltraGrid1_CellChange);
      UltraGrid ultraGrid1_1 = this._UltraGrid1;
      if (ultraGrid1_1 != null)
      {
        ultraGrid1_1.AfterRowInsert -= rowEventHandler;
        ultraGrid1_1.BeforeRowUpdate -= cancelableRowEventHandler;
        ultraGrid1_1.CellChange -= cellEventHandler;
      }
      this._UltraGrid1 = value;
      UltraGrid ultraGrid1_2 = this._UltraGrid1;
      if (ultraGrid1_2 == null)
        return;
      ultraGrid1_2.AfterRowInsert += rowEventHandler;
      ultraGrid1_2.BeforeRowUpdate += cancelableRowEventHandler;
      ultraGrid1_2.CellChange += cellEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsAdditionalWarranties ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkDeleteWarranty
  {
    get => this._lnkDeleteWarranty;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeleteWarranty_LinkClicked);
      LinkLabel lnkDeleteWarranty1 = this._lnkDeleteWarranty;
      if (lnkDeleteWarranty1 != null)
        lnkDeleteWarranty1.LinkClicked -= clickedEventHandler;
      this._lnkDeleteWarranty = value;
      LinkLabel lnkDeleteWarranty2 = this._lnkDeleteWarranty;
      if (lnkDeleteWarranty2 == null)
        return;
      lnkDeleteWarranty2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual UltraDropDown ddStatus
  {
    get => this._ddStatus;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.ddStatus_InitializeLayout);
      UltraDropDown ddStatus1 = this._ddStatus;
      if (ddStatus1 != null)
        ddStatus1.InitializeLayout -= layoutEventHandler;
      this._ddStatus = value;
      UltraDropDown ddStatus2 = this._ddStatus;
      if (ddStatus2 == null)
        return;
      ddStatus2.InitializeLayout += layoutEventHandler;
    }
  }

  [field: AccessedThroughProperty("DsAdditionalWarranties")]
  internal virtual dsAdditionalWarranties DsAdditionalWarranties { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdditionalWarranties));
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstAdditionalWarrantyStatus", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Description", -1, (object) null, 0, (SortIndicator) 2, false);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("lstAdditionalWarrantyStatus_tblAdditionalWarranties");
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstAdditionalWarrantyStatus_tblAdditionalWarranties", 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("AdditionalWarrantyID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("QuoteID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ConditionWarranty");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ItemType");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("DateAdded");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("AddedByUserGuid");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ModifiedByUserGuid");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("DateModified");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("StatusID");
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
    UltraGridBand ultraGridBand3 = new UltraGridBand("ItemTypes", -1);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ItemTypeID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ItemType");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ItemTypestblAdditionalWarranties1");
    UltraGridBand ultraGridBand4 = new UltraGridBand("ItemTypestblAdditionalWarranties1", 0);
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("AdditionalWarrantyID");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("QuoteID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ConditionWarranty");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ItemType");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("DateAdded");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("AddedByUserGuid");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("ModifiedByUserGuid");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("DateModified");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("StatusID");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("tblAdditionalWarranties", -1);
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("AdditionalWarrantyID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("QuoteID");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("ConditionWarranty");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("ItemType", -1, (object) "ddItemTypes");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("DateAdded");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("AddedByUserGuid");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("ModifiedByUserGuid");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("DateModified");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("StatusID", -1, (object) "ddStatus");
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.da = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.lnkDeleteWarranty = new LinkLabel();
    this.ddStatus = new UltraDropDown();
    this.ds = new dsAdditionalWarranties();
    this.ddItemTypes = new UltraDropDown();
    this.UltraGrid1 = new UltraGrid();
    this.DsAdditionalWarranties = new dsAdditionalWarranties();
    ((ISupportInitialize) this.ddStatus).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddItemTypes).BeginInit();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    this.DsAdditionalWarranties.BeginInit();
    this.SuspendLayout();
    this.da.DeleteCommand = this.DbDeleteCommand1;
    this.da.InsertCommand = this.DbInsertCommand1;
    this.da.SelectCommand = this.DbSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblAdditionalWarranties", new DataColumnMapping[9]
      {
        new DataColumnMapping("AdditionalWarrantyID", "AdditionalWarrantyID"),
        new DataColumnMapping("QuoteID", "QuoteID"),
        new DataColumnMapping("ConditionWarranty", "ConditionWarranty"),
        new DataColumnMapping("ItemType", "ItemType"),
        new DataColumnMapping("AddedByUserGuid", "AddedByUserGuid"),
        new DataColumnMapping("DateAdded", "DateAdded"),
        new DataColumnMapping("ModifiedByUserGuid", "ModifiedByUserGuid"),
        new DataColumnMapping("DateModified", "DateModified"),
        new DataColumnMapping("StatusID", "StatusID")
      })
    });
    this.da.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = "DELETE FROM tblAdditionalWarranties\r\nWHERE        (AdditionalWarrantyID = @AdditionalWarrantyID)";
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@AdditionalWarrantyID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AdditionalWarrantyID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[8]
    {
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      DefaultDatabase.CreateParameter("@ConditionWarranty", SqlDbType.VarChar, 500, "ConditionWarranty"),
      DefaultDatabase.CreateParameter("@ItemType", SqlDbType.Char, 1, "ItemType"),
      DefaultDatabase.CreateParameter("@AddedByUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "AddedByUserGuid"),
      DefaultDatabase.CreateParameter("@DateAdded", SqlDbType.SmallDateTime, 4, "DateAdded"),
      DefaultDatabase.CreateParameter("@ModifiedByUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ModifiedByUserGuid"),
      DefaultDatabase.CreateParameter("@DateModified", SqlDbType.SmallDateTime, 4, "DateModified"),
      DefaultDatabase.CreateParameter("@StatusID", SqlDbType.Int, 4, "StatusID")
    });
    this.DbSelectCommand1.CommandText = componentResourceManager.GetString("DbSelectCommand1.CommandText");
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[23]
    {
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 0, "QuoteID"),
      DefaultDatabase.CreateParameter("@ConditionWarranty", SqlDbType.VarChar, 0, "ConditionWarranty"),
      DefaultDatabase.CreateParameter("@ItemType", SqlDbType.Char, 0, "ItemType"),
      DefaultDatabase.CreateParameter("@AddedByUserGuid", SqlDbType.UniqueIdentifier, 0, "AddedByUserGuid"),
      DefaultDatabase.CreateParameter("@DateAdded", SqlDbType.SmallDateTime, 0, "DateAdded"),
      DefaultDatabase.CreateParameter("@ModifiedByUserGuid", SqlDbType.UniqueIdentifier, 0, "ModifiedByUserGuid"),
      DefaultDatabase.CreateParameter("@DateModified", SqlDbType.SmallDateTime, 0, "DateModified"),
      DefaultDatabase.CreateParameter("@StatusID", SqlDbType.Int, 0, "StatusID"),
      DefaultDatabase.CreateParameter("@Original_AdditionalWarrantyID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AdditionalWarrantyID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_QuoteID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_ConditionWarranty", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ConditionWarranty", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_ItemType", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ItemType", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_AddedByUserGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AddedByUserGuid", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_AddedByUserGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AddedByUserGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_DateAdded", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DateAdded", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_DateAdded", SqlDbType.SmallDateTime, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DateAdded", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_ModifiedByUserGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ModifiedByUserGuid", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_ModifiedByUserGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ModifiedByUserGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_DateModified", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DateModified", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_DateModified", SqlDbType.SmallDateTime, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DateModified", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_StatusID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "StatusID", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_StatusID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StatusID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@AdditionalWarrantyID", SqlDbType.Int, 4, "AdditionalWarrantyID")
    });
    this.lnkDeleteWarranty.AutoSize = true;
    this.lnkDeleteWarranty.Location = new Point(12, 329);
    this.lnkDeleteWarranty.Name = "lnkDeleteWarranty";
    this.lnkDeleteWarranty.Size = new Size(137, 13);
    this.lnkDeleteWarranty.TabIndex = 3;
    this.lnkDeleteWarranty.TabStop = true;
    this.lnkDeleteWarranty.Text = "Delete Additional Warranty";
    ((UltraGridBase) this.ddStatus).DataMember = "lstAdditionalWarrantyStatus";
    ((UltraGridBase) this.ddStatus).DataSource = (object) this.ds;
    appearance1.BackColor = SystemColors.Window;
    appearance1.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 307;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 7;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 8;
    ultraGridBand2.Columns.AddRange(new object[9]
    {
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
    ((UltraGridBase) this.ddStatus).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ddStatus).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddStatus).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddStatus).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance2.BackColor = SystemColors.ActiveBorder;
    appearance2.BackColor2 = SystemColors.ControlDark;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddStatus).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    appearance3.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddStatus).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.ddStatus).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = SystemColors.ControlLightLight;
    appearance4.BackColor2 = SystemColors.Control;
    appearance4.BackGradientStyle = (GradientStyle) 3;
    appearance4.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddStatus).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ddStatus).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddStatus).DisplayLayout.MaxRowScrollRegions = 1;
    appearance5.BackColor = SystemColors.Window;
    appearance5.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = SystemColors.Highlight;
    appearance6.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance7.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.Silver;
    appearance8.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.CellPadding = 0;
    appearance9.BackColor = SystemColors.Control;
    appearance9.BackColor2 = SystemColors.ControlDark;
    appearance9.BackGradientAlignment = (GradientAlignment) 1;
    appearance9.BackGradientStyle = (GradientStyle) 3;
    appearance9.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance11.BackColor = SystemColors.Window;
    appearance11.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ddStatus).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddStatus).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddStatus).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddStatus).DisplayMember = "Description";
    ((Control) this.ddStatus).Font = new Font("Tahoma", 8.25f);
    ((Control) this.ddStatus).Location = new Point(249, 72);
    ((Control) this.ddStatus).Name = "ddStatus";
    ((Control) this.ddStatus).Size = new Size(385, 116);
    ((Control) this.ddStatus).TabIndex = 4;
    ((Control) this.ddStatus).Text = "UltraDropDown1";
    ((UltraDropDownBase) this.ddStatus).ValueMember = "ID";
    ((Control) this.ddStatus).Visible = false;
    this.ds.DataSetName = "dsAdditionalWarranties";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.ddItemTypes).DataSource = (object) this.ds.ItemTypes;
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.Appearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 0;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 211;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 1;
    ultraGridColumn14.Width = 178;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 2;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15
    });
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 7;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 8;
    ultraGridBand4.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24
    });
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance14.BackColor = Color.LightSteelBlue;
    appearance14.FontData.SizeInPoints = 10f;
    appearance14.ForeColor = Color.Black;
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance14;
    appearance15.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance16.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance16;
    appearance17.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance18.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance18;
    appearance19.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance20.BackColor = Color.Transparent;
    appearance20.ForeColor = Color.Black;
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance20;
    appearance21.BackColor = Color.WhiteSmoke;
    appearance21.BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance21;
    appearance22.BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.ddItemTypes).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraDropDownBase) this.ddItemTypes).DisplayMember = "ItemType";
    ((Control) this.ddItemTypes).Location = new Point(51, 132);
    ((Control) this.ddItemTypes).Name = "ddItemTypes";
    ((Control) this.ddItemTypes).Size = new Size(180, 80 /*0x50*/);
    ((Control) this.ddItemTypes).TabIndex = 1;
    ((Control) this.ddItemTypes).Text = "UltraDropDown1";
    ((UltraDropDownBase) this.ddItemTypes).ValueMember = "ItemTypeID";
    ((Control) this.ddItemTypes).Visible = false;
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.ds.tblAdditionalWarranties;
    appearance23.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance23;
    appearance24.BackColor = Color.WhiteSmoke;
    appearance24.BorderColor = Color.WhiteSmoke;
    appearance24.FontData.UnderlineAsString = "True";
    appearance24.ForeColor = Color.Blue;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance24;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance25.BackColor = Color.White;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand5.AddButtonCaption = "Click here to add a new warranty ...";
    ultraGridColumn25.CellActivation = (Activation) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 0;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 245;
    ultraGridColumn26.CellActivation = (Activation) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 1;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 114;
    ((HeaderBase) ultraGridColumn27.Header).Caption = "Condition/Warranty Text";
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 2;
    ultraGridColumn27.Width = 461;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "Item Type";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 3;
    ultraGridColumn28.Style = (ColumnStyle) 6;
    ultraGridColumn28.Width = 210;
    ultraGridColumn29.CellActivation = (Activation) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 4;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 78;
    ultraGridColumn30.CellActivation = (Activation) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 5;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 166;
    ultraGridColumn31.CellActivation = (Activation) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 6;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 149;
    ultraGridColumn32.CellActivation = (Activation) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 7;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 78;
    ((HeaderBase) ultraGridColumn33.Header).Caption = "Status";
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 8;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn33.Style = (ColumnStyle) 6;
    ultraGridColumn33.Width = 283;
    ultraGridBand5.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33
    });
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance26.BackColor = Color.LightSteelBlue;
    appearance26.FontData.SizeInPoints = 10f;
    appearance26.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance26;
    appearance27.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance27;
    appearance28.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance28;
    appearance29.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance30.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance30;
    appearance31.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance31;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance32.BackColor = Color.Transparent;
    appearance32.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance32;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.UltraGrid1).Dock = DockStyle.Top;
    ((Control) this.UltraGrid1).Location = new Point(0, 0);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(692, 318);
    ((Control) this.UltraGrid1).TabIndex = 0;
    ((UltraControlBase) this.UltraGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraGrid1).UseOsThemes = (DefaultableBoolean) 2;
    this.DsAdditionalWarranties.DataSetName = "dsAdditionalWarranties";
    this.DsAdditionalWarranties.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(692, 351);
    this.Controls.Add((Control) this.ddStatus);
    this.Controls.Add((Control) this.lnkDeleteWarranty);
    this.Controls.Add((Control) this.ddItemTypes);
    this.Controls.Add((Control) this.UltraGrid1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmAdditionalWarranties);
    this.Text = "Additional Warranties";
    ((ISupportInitialize) this.ddStatus).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddItemTypes).EndInit();
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    this.DsAdditionalWarranties.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmAdditionalWarranties()
  {
    this.Load += new EventHandler(this.frmAdditionalWarranties_Load);
    this.Closing += new CancelEventHandler(this.frmAdditionalWarranties_Closing);
    this._bInsertRow = false;
    this.InitializeComponent();
  }

  public frmAdditionalWarranties(int quoteID)
  {
    this.Load += new EventHandler(this.frmAdditionalWarranties_Load);
    this.Closing += new CancelEventHandler(this.frmAdditionalWarranties_Closing);
    this._bInsertRow = false;
    this.InitializeComponent();
    this._quoteID = quoteID;
  }

  public frmAdditionalWarranties(int quoteID, string tabname)
  {
    this.Load += new EventHandler(this.frmAdditionalWarranties_Load);
    this.Closing += new CancelEventHandler(this.frmAdditionalWarranties_Closing);
    this._bInsertRow = false;
    this.InitializeComponent();
    this._quoteID = quoteID;
    this._tabSelected = tabname;
  }

  private void frmAdditionalWarranties_Load(object sender, EventArgs e)
  {
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Override.AllowRowFiltering = (DefaultableBoolean) 1;
    if (SystemSettings.KeyExists("AdditionalWarrantiesShowStatus") && SystemSettings.GetBoolSetting("AdditionalWarrantiesShowStatus"))
      ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["StatusID"].Hidden = false;
    else
      ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["StatusID"].Hidden = true;
    Utility.SetDataAdapterConnections(this.da, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._tabSelected, "Conditions", false) == 0)
    {
      this.ds.ItemTypes.AddItemTypesRow("C", "Condition");
      this._itemTypeToShow = "C";
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._tabSelected, "Warranties", false) == 0)
    {
      this.ds.ItemTypes.AddItemTypesRow("W", "Warranty");
      this._itemTypeToShow = "W";
    }
    else
    {
      this.ds.ItemTypes.AddItemTypesRow("C", "Condition");
      this.ds.ItemTypes.AddItemTypesRow("W", "Warranty");
      this._itemTypeToShow = "";
    }
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
    {
      this.ds.lstAdditionalWarrantyStatus.TableName,
      this.ds.tblAdditionalWarranties.TableName
    }, "spGetAdditionalWarrantyStatusList", new object[4]
    {
      (object) "@QuoteID",
      (object) this._quoteID,
      (object) "@ItemType",
      (object) this._itemTypeToShow
    });
    this.clientLoad();
  }

  protected virtual void clientLoad()
  {
  }

  protected void LogChanges(
    string dtTableName,
    string strAction,
    int identifierID,
    Guid GUIDtoLog,
    string strcontext)
  {
    DataTable table = this.ds.Tables[dtTableName];
    DataRow[] dataRowArray1 = table.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent);
    string str1 = strAction;
    string str2 = strAction;
    string str3 = strAction;
    DataRow[] dataRowArray2 = dataRowArray1;
    int index1 = 0;
    while (index1 < dataRowArray2.Length)
    {
      DataRow dataRow = dataRowArray2[index1];
      string str4 = "";
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
        {
          string Left = dataRow[column, DataRowVersion.Original].ToString();
          string Right = dataRow[column, DataRowVersion.Current].ToString();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Right, false) != 0)
            str4 = $"{str4} Original {column.Caption}: {Left} was changed to: {Right}";
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{str1} User updated record. {str4}", GUIDtoLog, $"{strcontext}: {dataRow[strcontext].ToString()}");
      checked { ++index1; }
    }
    DataRow[] dataRowArray3 = table.Select((string) null, (string) null, DataViewRowState.Added);
    int index2 = 0;
    while (index2 < dataRowArray3.Length)
    {
      DataRow dataRow = dataRowArray3[index2];
      string str5 = "";
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
          str5 = $"{str5}  {column.Caption}: {dataRow[column, DataRowVersion.Current].ToString()}";
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{str2} User inserted new record. {str5}", GUIDtoLog, $"{strcontext}: {dataRow[strcontext].ToString()}");
      checked { ++index2; }
    }
    DataRow[] dataRowArray4 = table.Select((string) null, (string) null, DataViewRowState.Deleted);
    int index3 = 0;
    while (index3 < dataRowArray4.Length)
    {
      DataRow dataRow = dataRowArray4[index3];
      string str6 = "";
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
          str6 = $"{str6} {column.Caption}: {dataRow[column, DataRowVersion.Original].ToString()}";
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{str3} User deleted record. {str6}", GUIDtoLog);
      checked { ++index3; }
    }
  }

  private void frmAdditionalWarranties_Closing(object sender, CancelEventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    ((UltraGridBase) this.UltraGrid1).UpdateData();
    this._quoteguid = new Quote(this._quoteID).QuoteGuid;
    this.LogChanges("tblAdditionalWarranties", $"The Additional Conditions / Warranties was modified for quote. {Conversions.ToString(this._quoteID)} . ", 0, this._quoteguid, "additionalWarrantyID");
    this.SaveData();
    this.clientSave();
  }

  private void SaveData()
  {
    try
    {
      DefaultDatabase.DataAdapterUpdate(this.da, (DataTable) this.ds.tblAdditionalWarranties);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  protected virtual void clientSave()
  {
  }

  private void UltraGrid1_AfterRowInsert(object sender, RowEventArgs e)
  {
    this._bInsertRow = true;
    e.Row.Cells["QuoteID"].Value = (object) this._quoteID;
    e.Row.Cells["AddedByUserGUID"].Value = (object) CurrentUser.Instance.UserGUID;
    e.Row.Cells["DateAdded"].Value = (object) CurrentUser.ServerTime;
    this.clientAfterRowInsert();
  }

  protected virtual void clientAfterRowInsert()
  {
  }

  private void UltraGrid1_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (e.Row.Cells["ConditionWarranty"].Value != DBNull.Value && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Row.Cells["ConditionWarranty"].Value.ToString(), string.Empty, false) != 0)
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  private void lnkDeleteWarranty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.UltraGrid1.ActiveCell == null)
      return;
    this.UltraGrid1.ActiveCell.Row.Selected = true;
    this.UltraGrid1.PerformAction((UltraGridAction) 37);
  }

  private void UltraGrid1_CellChange(object sender, CellEventArgs e)
  {
    e.Cell.Row.Cells["ModifiedByUserGuid"].Value = (object) CurrentUser.Instance.UserGUID;
    e.Cell.Row.Cells["DateModified"].Value = (object) DateTime.Now;
  }

  private void ddStatus_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
  }
}

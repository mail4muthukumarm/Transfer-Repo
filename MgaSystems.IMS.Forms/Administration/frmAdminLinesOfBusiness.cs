// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Administration.frmAdminLinesOfBusiness
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Security;
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
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Administration;

[SecureResource("{2B3123C9-D103-4ad7-ABBA-C5D1ECFB844E}", "Add New Lines of Business", "Controls the ability to add new lines of business.", "Lines")]
[SecureResource("{CE762F49-74E0-49f5-BBB7-E71665330C05}", "Access Lines of Business", "Controls access to lines of business screen.", "Lines")]
[SecureResource("{7C8EA00F-646F-4c45-AD84-B2FAE10E8D08}", "Modify Lines of Business", "Controls the ability to modify existing lines of business.", "Lines")]
public class frmAdminLinesOfBusiness : Form
{
  private IContainer components;
  private SqlDataAdapter daLines;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private dsAdminLinesOfBusiness ds;
  private Dictionary<Guid, frmAdminLinesOfBusiness.lineStructure> _existingLineGuids;
  private int _maxCharactersLineName;
  private Dictionary<string, Guid> _logEntries;
  internal const string AddNewLinesOfBusiness = "{2B3123C9-D103-4ad7-ABBA-C5D1ECFB844E}";
  internal const string ModifyExistingLinesOfBusiness = "{7C8EA00F-646F-4c45-AD84-B2FAE10E8D08}";
  public const string CanViewLinesOfBusiness = "{CE762F49-74E0-49f5-BBB7-E71665330C05}";

  protected virtual UltraGrid UltraGrid1
  {
    get => this._UltraGrid1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler = new RowEventHandler(this.UltraGrid1_AfterRowUpdate);
      CancelableRowEventHandler cancelableRowEventHandler = new CancelableRowEventHandler(this.UltraGrid1_BeforeRowUpdate);
      EventHandler eventHandler = new EventHandler(this.UltraGrid1_AfterRowsDeleted);
      UltraGrid ultraGrid1_1 = this._UltraGrid1;
      if (ultraGrid1_1 != null)
      {
        ultraGrid1_1.AfterRowUpdate -= rowEventHandler;
        ultraGrid1_1.BeforeRowUpdate -= cancelableRowEventHandler;
        ultraGrid1_1.AfterRowsDeleted -= eventHandler;
      }
      this._UltraGrid1 = value;
      UltraGrid ultraGrid1_2 = this._UltraGrid1;
      if (ultraGrid1_2 == null)
        return;
      ultraGrid1_2.AfterRowUpdate += rowEventHandler;
      ultraGrid1_2.BeforeRowUpdate += cancelableRowEventHandler;
      ultraGrid1_2.AfterRowsDeleted += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ddlNetRateLines")]
  internal virtual UltraComboEditor ddlNetRateLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand")]
  internal virtual SqlCommand SqlInsertCommand { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddLineGroup")]
  internal virtual UltraComboEditor ddLineGroup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddIMSLOBGroup")]
  private virtual UltraDropDown ddIMSLOBGroup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdminLinesOfBusiness));
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstImsLOBGroupCode", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CodeName");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Inactive");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ReqTargetPremium");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("NetRate_LOB_Code");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("GroupCode");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("LOBCodeID", -1, (object) "ddIMSLOBGroup");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("LineCode");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    this.daLines = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.ddIMSLOBGroup = new UltraDropDown();
    this.ds = new dsAdminLinesOfBusiness();
    this.ddLineGroup = new UltraComboEditor();
    this.ddlNetRateLines = new UltraComboEditor();
    this.UltraGrid1 = new UltraGrid();
    ((ISupportInitialize) this.ddIMSLOBGroup).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddLineGroup).BeginInit();
    ((ISupportInitialize) this.ddlNetRateLines).BeginInit();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    this.SuspendLayout();
    this.daLines.DeleteCommand = this.SqlDeleteCommand1;
    this.daLines.InsertCommand = this.SqlInsertCommand;
    this.daLines.SelectCommand = this.SqlSelectCommand1;
    this.daLines.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstLines", new DataColumnMapping[7]
      {
        new DataColumnMapping("LineGUID", "LineGUID"),
        new DataColumnMapping("LineName", "LineName"),
        new DataColumnMapping("Inactive", "Inactive"),
        new DataColumnMapping("ReqTargetPremium", "ReqTargetPremium"),
        new DataColumnMapping("NetRate_LOB_Code", "NetRate_LOB_Code"),
        new DataColumnMapping("GroupCode", "GroupCode"),
        new DataColumnMapping("LOBCodeID", "LOBCodeID")
      })
    });
    this.daLines.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [lstLines] WHERE (([LineGUID] = @Original_LineGUID))";
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_LineGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineGUID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand.CommandText = componentResourceManager.GetString("SqlInsertCommand.CommandText");
    this.SqlInsertCommand.Parameters.AddRange(new SqlParameter[8]
    {
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID"),
      new SqlParameter("@LineName", SqlDbType.VarChar, 100, "LineName"),
      new SqlParameter("@Inactive", SqlDbType.Bit, 1, "Inactive"),
      new SqlParameter("@ReqTargetPremium", SqlDbType.Bit, 1, "ReqTargetPremium"),
      new SqlParameter("@NetRate_LOB_Code", SqlDbType.VarChar, 25, "NetRate_LOB_Code"),
      new SqlParameter("@GroupCode", SqlDbType.Char, 2, "GroupCode"),
      new SqlParameter("@LOBCodeID", SqlDbType.Int, 4, "LOBCodeID"),
      new SqlParameter("@LineCode", SqlDbType.VarChar, 15, "LineCode")
    });
    this.SqlSelectCommand1.CommandText = "SELECT      LineGUID, LineName, Inactive, ReqTargetPremium, NetRate_LOB_Code, GroupCode, LOBCodeID, LineCode\r\nFROM         lstLines\r\nORDER BY LineName";
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[9]
    {
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID"),
      new SqlParameter("@LineName", SqlDbType.VarChar, 100, "LineName"),
      new SqlParameter("@Inactive", SqlDbType.Bit, 1, "Inactive"),
      new SqlParameter("@ReqTargetPremium", SqlDbType.Bit, 1, "ReqTargetPremium"),
      new SqlParameter("@NetRate_LOB_Code", SqlDbType.VarChar, 25, "NetRate_LOB_Code"),
      new SqlParameter("@GroupCode", SqlDbType.Char, 2, "GroupCode"),
      new SqlParameter("@LOBCodeID", SqlDbType.Int, 4, "LOBCodeID"),
      new SqlParameter("@LineCode", SqlDbType.VarChar, 15, "LineCode"),
      new SqlParameter("@Original_LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineGUID", DataRowVersion.Original, (object) null)
    });
    ((UltraGridBase) this.ddIMSLOBGroup).DataMember = "lstImsLOBGroupCode";
    ((UltraGridBase) this.ddIMSLOBGroup).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ddIMSLOBGroup).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ddIMSLOBGroup).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 48 /*0x30*/;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 173;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ddIMSLOBGroup).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ddIMSLOBGroup).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ddIMSLOBGroup).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ddIMSLOBGroup).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ddIMSLOBGroup).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ddIMSLOBGroup).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddIMSLOBGroup).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ddIMSLOBGroup).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ddIMSLOBGroup).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ddIMSLOBGroup).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddIMSLOBGroup).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ddIMSLOBGroup).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ddIMSLOBGroup).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ddIMSLOBGroup).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraDropDownBase) this.ddIMSLOBGroup).DisplayMember = "CodeName";
    ((Control) this.ddIMSLOBGroup).Location = new Point(46, 108);
    ((Control) this.ddIMSLOBGroup).Name = "ddIMSLOBGroup";
    ((Control) this.ddIMSLOBGroup).Size = new Size(192 /*0xC0*/, 59);
    ((Control) this.ddIMSLOBGroup).TabIndex = 3;
    ((Control) this.ddIMSLOBGroup).Text = "ddIMSLOBGroup";
    ((UltraDropDownBase) this.ddIMSLOBGroup).ValueMember = "ID";
    ((Control) this.ddIMSLOBGroup).Visible = false;
    this.ds.DataSetName = "dsAdminLinesOfBusiness";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.ddLineGroup.DataMember = "lstLineGroups";
    this.ddLineGroup.DataSource = (object) this.ds;
    this.ddLineGroup.DisplayMember = "GroupName";
    this.ddLineGroup.DropDownStyle = (DropDownStyle) 1;
    ((Control) this.ddLineGroup).Location = new Point(299, 173);
    ((Control) this.ddLineGroup).Name = "ddLineGroup";
    ((Control) this.ddLineGroup).Size = new Size(144 /*0x90*/, 22);
    ((Control) this.ddLineGroup).TabIndex = 2;
    this.ddLineGroup.ValueMember = "GroupCode";
    ((Control) this.ddLineGroup).Visible = false;
    this.ddlNetRateLines.DataMember = "lstNetRateLOBCodes";
    this.ddlNetRateLines.DataSource = (object) this.ds;
    this.ddlNetRateLines.DisplayMember = "NetRate_LOB_Code";
    this.ddlNetRateLines.DropDownStyle = (DropDownStyle) 1;
    ((Control) this.ddlNetRateLines).Location = new Point(299, 145);
    ((Control) this.ddlNetRateLines).Name = "ddlNetRateLines";
    ((Control) this.ddlNetRateLines).Size = new Size(144 /*0x90*/, 22);
    ((Control) this.ddlNetRateLines).TabIndex = 1;
    this.ddlNetRateLines.ValueMember = "NetRate_LOB_Code";
    ((Control) this.ddlNetRateLines).Visible = false;
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.ds.lstLines;
    appearance11.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.WhiteSmoke;
    appearance12.BorderColor = Color.WhiteSmoke;
    appearance12.FontData.UnderlineAsString = "True";
    appearance12.ForeColor = Color.Blue;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance12;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Prompt = " ";
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand2.AddButtonCaption = "Click here to add a new line of business ...";
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 371;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Req Target Premium";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 3;
    ultraGridColumn6.Width = 122;
    ultraGridColumn7.EditorComponent = (Component) this.ddlNetRateLines;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "NetRate Line";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 4;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Style = (ColumnStyle) 6;
    ultraGridColumn8.EditorComponent = (Component) this.ddLineGroup;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 5;
    ultraGridColumn8.Style = (ColumnStyle) 6;
    ultraGridColumn8.Width = 133;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "LOB Code";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 6;
    ultraGridColumn9.Style = (ColumnStyle) 6;
    ultraGridColumn9.Width = 113;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Code";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 7;
    ultraGridBand2.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance14.BackColor = Color.LightSteelBlue;
    appearance14.FontData.SizeInPoints = 10f;
    appearance14.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance14;
    appearance15.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance15;
    appearance16.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance16;
    appearance17.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance18.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance18;
    appearance19.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance20.BackColor = Color.Transparent;
    appearance20.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance20;
    ((Control) this.UltraGrid1).Dock = DockStyle.Fill;
    ((Control) this.UltraGrid1).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.UltraGrid1).Location = new Point(0, 0);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(924, 454);
    ((Control) this.UltraGrid1).TabIndex = 0;
    ((UltraControlBase) this.UltraGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraGrid1).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(924, 454);
    this.Controls.Add((Control) this.ddIMSLOBGroup);
    this.Controls.Add((Control) this.ddLineGroup);
    this.Controls.Add((Control) this.ddlNetRateLines);
    this.Controls.Add((Control) this.UltraGrid1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (frmAdminLinesOfBusiness);
    this.Text = "Lines of Business Administration";
    ((ISupportInitialize) this.ddIMSLOBGroup).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddLineGroup).EndInit();
    ((ISupportInitialize) this.ddlNetRateLines).EndInit();
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmAdminLinesOfBusiness()
  {
    this.Load += new EventHandler(this.frmAdminLinesOfBusiness_Load);
    this.Closing += new CancelEventHandler(this.frmAdminLinesOfBusiness_Closing);
    this._existingLineGuids = new Dictionary<Guid, frmAdminLinesOfBusiness.lineStructure>();
    this._maxCharactersLineName = 100;
    this._logEntries = new Dictionary<string, Guid>();
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    if (this.daLines != null)
      this.daLines.Dispose();
    base.Dispose(disposing);
  }

  protected dsAdminLinesOfBusiness LinesDataset => this.ds;

  private void CheckNetRate()
  {
    try
    {
      ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns[4].Hidden = false;
    }
    catch (FileNotFoundException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns[4].Hidden = true;
      ProjectData.ClearProjectError();
    }
    catch (TypeLoadException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns[4].Hidden = true;
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns[4].Hidden = true;
      ProjectData.ClearProjectError();
    }
  }

  private void frmAdminLinesOfBusiness_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    Utility.SetDataAdapterConnections((DbDataAdapter) this.daLines, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    this.CheckNetRate();
    if (!SecurityManager.Instance.AssertPermission("{2B3123C9-D103-4ad7-ABBA-C5D1ECFB844E}"))
      ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Hidden = true;
    if (!SecurityManager.Instance.AssertPermission("{7C8EA00F-646F-4c45-AD84-B2FAE10E8D08}"))
    {
      UltraGridOverride ultraGridOverride = ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override;
      ultraGridOverride.AllowUpdate = (DefaultableBoolean) 2;
      ultraGridOverride.AllowDelete = (DefaultableBoolean) 2;
    }
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      this.ds.lstLineGroups.TableName
    }, "sp_GetLineGroups");
    this.ds.lstLineGroups.AddlstLineGroupsRow("", "");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      this.ds.lstNetRateLOBCodes.TableName
    }, "sp_GetNetRateLOBCodes");
    this.ds.lstNetRateLOBCodes.AddlstNetRateLOBCodesRow(0, "");
    this.ds.lstImsLOBGroupCode.AddlstImsLOBGroupCodeRow(-1, string.Empty);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      this.ds.lstImsLOBGroupCode.TableName
    }, CommandType.Text, "select ID, CodeName from  lstImsLOBGroupCode order by CodeName");
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLines, (DataTable) this.ds.lstLines);
    try
    {
      foreach (dsAdminLinesOfBusiness.lstLinesRow lstLine in (TypedTableBase<dsAdminLinesOfBusiness.lstLinesRow>) this.ds.lstLines)
      {
        frmAdminLinesOfBusiness.lineStructure lineStructure = new frmAdminLinesOfBusiness.lineStructure();
        dsAdminLinesOfBusiness.lstLinesRow lstLinesRow = lstLine;
        lineStructure.LineGuid = lstLine.LineGUID;
        lineStructure.LineName = lstLine.LineName;
        lineStructure.Inactive = lstLine.Inactive;
        lineStructure.GroupCode = lstLinesRow.IsGroupCodeNull() ? "<NULL>" : this.FindLineGroup(lstLinesRow.GroupCode);
        lineStructure.NetRate_LOB_Code = lstLinesRow.IsNetRate_LOB_CodeNull() ? "<NULL>" : lstLine.NetRate_LOB_Code;
        lineStructure.ReqTargetPremium = lstLine.ReqTargetPremium;
        this._existingLineGuids.Add(lstLine.LineGUID, lineStructure);
      }
    }
    finally
    {
      IEnumerator<dsAdminLinesOfBusiness.lstLinesRow> enumerator;
      enumerator?.Dispose();
    }
    this._maxCharactersLineName = 100;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT COL_LENGTH(@Table,@Col)", new object[4]
    {
      (object) "@Table",
      (object) "lstLines",
      (object) "@Col",
      (object) "LineName"
    }));
    if (objectValue != null && objectValue != DBNull.Value)
      this._maxCharactersLineName = Conversions.ToInteger(objectValue);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["LineName"].MinLength = 1;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["LineName"].MaxLength = this._maxCharactersLineName;
    bool flag = SystemSettings.KeyExists("BusinessLines.ShowIMSLOBCode") && SystemSettings.GetBoolSetting("BusinessLines.ShowIMSLOBCode");
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["LOBCodeID"].Hidden = !flag;
    if (flag)
    {
      this.Width += 50;
      ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["LOBCodeID"].Width = 50;
    }
    this.FormLoaded();
  }

  protected virtual void FormLoaded()
  {
  }

  private void SaveData()
  {
    Cursor.Current = Cursors.WaitCursor;
    this.UltraGrid1.PerformAction((UltraGridAction) 44);
    if (((UltraGridBase) this.UltraGrid1).ActiveRow != null)
      ((UltraGridBase) this.UltraGrid1).ActiveRow.Update();
    ((UltraGridBase) this.UltraGrid1).UpdateData();
    bool flag = true;
    try
    {
      if (((UltraGridBase) this.UltraGrid1).ActiveRow != null)
        this.ds.lstLines.Rows.Find((object) ((UltraGridBase) this.UltraGrid1).ActiveRow.Cells["LineGuid"].Value.ToString());
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daLines, (DataTable) this.ds.lstLines);
      object obj = ((UltraGridBase) this.UltraGrid1).ActiveRow.Cells["LineGuid"].Value;
      this.ClientSaveData(obj != null ? (Guid) obj : new Guid());
    }
    catch (SqlException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      SqlException ex2 = ex1;
      flag = false;
      if (ex2.Message.IndexOf("FK_tblQuotes_lstLines") != -1)
      {
        this.ds.RejectChanges();
        int num = (int) MessageBox.Show("This line of business can not be deleted, because it is currently assigned to one or more policies.", "Unable to Delete Line", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else if (ex2.Message.IndexOf("FK_tblCompanyLines_lstLines") != -1)
      {
        this.ds.RejectChanges();
        int num = (int) MessageBox.Show("This line of business can not be deleted, because it is currently assigned to one or more company/line setups.", "Unable to Delete Line", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
        ErrorHandler.HandleError((Exception) ex2);
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      flag = false;
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
    }
    if (!flag)
      return;
    this.LogChanges();
  }

  protected virtual void ClientSaveData(Guid lineguid)
  {
  }

  private void frmAdminLinesOfBusiness_Closing(object sender, CancelEventArgs e)
  {
    this.SaveData();
    try
    {
      foreach (KeyValuePair<string, Guid> logEntry in this._logEntries)
        CurrentUser.Instance.LogAction(logEntry.Key, logEntry.Value);
    }
    finally
    {
      Dictionary<string, Guid>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (dsAdminLinesOfBusiness.lstLinesRow lstLine in (TypedTableBase<dsAdminLinesOfBusiness.lstLinesRow>) this.ds.lstLines)
      {
        if (!this._existingLineGuids.ContainsKey(lstLine.LineGUID))
        {
          if (MessageBox.Show($"Would you like to make \"{lstLine.LineName}\" available to all users?", "Make Line Available To All Users?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          {
            try
            {
              FormSettings.ShowFormDialog(typeof (frmLineView), (object) lstLine.LineGUID, (object) lstLine.LineName);
            }
            catch (Exception ex1)
            {
              ProjectData.SetProjectError(ex1);
              Exception ex2 = ex1;
              if (ex2.Message.Contains("FK_tblUsersLines_lstLines"))
              {
                int num = (int) MessageBox.Show(lstLine.LineName + " was not made available to all users.", "New Line Not Made Available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              }
              else
                ErrorHandler.HandleError(ex2);
              ProjectData.ClearProjectError();
            }
          }
        }
      }
    }
    finally
    {
      IEnumerator<dsAdminLinesOfBusiness.lstLinesRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void UltraGrid1_AfterRowUpdate(object sender, RowEventArgs e) => this.SaveData();

  private void UltraGrid1_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (e.Row.Cells["LineGuid"].Value == DBNull.Value)
      e.Row.Cells["LineGuid"].Value = (object) Guid.NewGuid();
    if (e.Row.Cells["LineName"].Value != null && e.Row.Cells["LineName"].Value != DBNull.Value && e.Row.Cells["LineName"].Value.ToString().Replace(" ", "").Length != 0)
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  private void UltraGrid1_AfterRowsDeleted(object sender, EventArgs e) => this.SaveData();

  private string FindLineGroup(string groupCode)
  {
    string lineGroup;
    try
    {
      foreach (dsAdminLinesOfBusiness.lstLineGroupsRow row in this.ds.lstLineGroups.Rows)
      {
        if (row.GroupCode.Equals(groupCode))
        {
          lineGroup = row.GroupName;
          goto label_8;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    lineGroup = "<NULL>";
label_8:
    return lineGroup;
  }

  private void LogString(dsAdminLinesOfBusiness.lstLinesRow dr, string columnName)
  {
    string Left = columnName;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "LineName", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Inactive", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "ReqTargetPremium", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "NetRate_LOB_Code", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "GroupCode", false) != 0)
              return;
            string groupCode = this._existingLineGuids[dr.LineGUID].GroupCode;
            string str = "<NULL>";
            if (!dr.IsGroupCodeNull())
              str = this.FindLineGroup(dr.GroupCode);
            if (groupCode.Equals(str))
              return;
            string key = $"Updated Line '{dr.LineName}'.  Changed Group Code from '{groupCode}' to '{str}";
            if (this._logEntries.ContainsKey(key))
              return;
            this._logEntries.Add(key, dr.LineGUID);
          }
          else
          {
            string netRateLobCode = this._existingLineGuids[dr.LineGUID].NetRate_LOB_Code;
            string str = "<NULL>";
            if (!dr.IsNetRate_LOB_CodeNull())
              str = dr.NetRate_LOB_Code;
            if (netRateLobCode.Equals(str))
              return;
            string key = $"Updated Line '{dr.LineName}'.  Changed NetRate LOB Code from '{netRateLobCode}' to '{str}";
            if (this._logEntries.ContainsKey(key))
              return;
            this._logEntries.Add(key, dr.LineGUID);
          }
        }
        else
        {
          if (dr.ReqTargetPremium.Equals(this._existingLineGuids[dr.LineGUID].ReqTargetPremium))
            return;
          string key = $"Updated Line '{dr.LineName}'.  Changed Req Target Premium from '{Conversions.ToString(this._existingLineGuids[dr.LineGUID].ReqTargetPremium)}' to '{Conversions.ToString(dr.ReqTargetPremium)}";
          if (this._logEntries.ContainsKey(key))
            return;
          this._logEntries.Add(key, dr.LineGUID);
        }
      }
      else
      {
        if (dr.Inactive.Equals(this._existingLineGuids[dr.LineGUID].Inactive))
          return;
        string key = $"Updated Line '{dr.LineName}'.  Changed Inactive from '{Conversions.ToString(this._existingLineGuids[dr.LineGUID].Inactive)}' to '{Conversions.ToString(dr.Inactive)}";
        if (this._logEntries.ContainsKey(key))
          return;
        this._logEntries.Add(key, dr.LineGUID);
      }
    }
    else
    {
      if (dr.LineName.Equals(this._existingLineGuids[dr.LineGUID].LineName))
        return;
      string key = $"Changed Line Name '{this._existingLineGuids[dr.LineGUID].LineName}' from '{this._existingLineGuids[dr.LineGUID].LineName}' to '{dr.LineName}";
      if (this._logEntries.ContainsKey(key))
        return;
      this._logEntries.Add(key, dr.LineGUID);
    }
  }

  private void LogChanges()
  {
    try
    {
      foreach (dsAdminLinesOfBusiness.lstLinesRow lstLine in (TypedTableBase<dsAdminLinesOfBusiness.lstLinesRow>) this.ds.lstLines)
      {
        if (!this._existingLineGuids.ContainsKey(lstLine.LineGUID))
        {
          string key = $"Added Line of Business - '{lstLine.LineName}'";
          if (!this._logEntries.ContainsKey(key))
            this._logEntries.Add(key, lstLine.LineGUID);
        }
        else
        {
          try
          {
            foreach (DataColumn column in (InternalDataCollectionBase) this.ds.lstLines.Columns)
              this.LogString(lstLine, column.ColumnName);
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
      IEnumerator<dsAdminLinesOfBusiness.lstLinesRow> enumerator;
      enumerator?.Dispose();
    }
    if (this._existingLineGuids.Count <= this.ds.lstLines.Count)
      return;
    try
    {
      foreach (KeyValuePair<Guid, frmAdminLinesOfBusiness.lineStructure> existingLineGuid in this._existingLineGuids)
      {
        if (this.ds.lstLines.FindByLineGUID(existingLineGuid.Key) == null)
        {
          string key = $"Deleted Line of Business - '{existingLineGuid.Value.LineName}'";
          if (!this._logEntries.ContainsKey(key))
            this._logEntries.Add(key, existingLineGuid.Value.LineGuid);
        }
      }
    }
    finally
    {
      Dictionary<Guid, frmAdminLinesOfBusiness.lineStructure>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private struct lineStructure
  {
    internal Guid LineGuid;
    internal string LineName;
    internal bool Inactive;
    internal bool ReqTargetPremium;
    internal string NetRate_LOB_Code;
    internal string GroupCode;
  }
}

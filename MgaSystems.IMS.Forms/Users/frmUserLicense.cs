// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Users.frmUserLicense
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
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
namespace MGASystems.IMS.Forms.Users;

public sealed class frmUserLicense : Form
{
  private IContainer components;
  private SqlConnection cnSQL;
  private SqlDataAdapter daUserLicense;
  private dsUserLicense ds;
  private UltraDropDown ddLicenseTypes;
  private UltraDropDown ddStates;
  private SqlCommand SqlSelectCommand3;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private readonly Guid _userGuid;

  public frmUserLicense()
  {
    this.Load += new EventHandler(this.frmUserLicense_Load);
    this.Closing += new CancelEventHandler(this.frmUserLicense_Closing);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraGrid ug
  {
    get => this._ug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelableRowEventHandler cancelableRowEventHandler = new CancelableRowEventHandler(this.ug_BeforeRowUpdate);
      RowEventHandler rowEventHandler1 = new RowEventHandler(this.ug_AfterRowInsert);
      RowEventHandler rowEventHandler2 = new RowEventHandler(this.ug_AfterRowUpdate);
      BeforeRowsDeletedEventHandler deletedEventHandler = new BeforeRowsDeletedEventHandler(this.ug_BeforeRowsDeleted);
      UltraGrid ug1 = this._ug;
      if (ug1 != null)
      {
        ug1.BeforeRowUpdate -= cancelableRowEventHandler;
        ug1.AfterRowInsert -= rowEventHandler1;
        ug1.AfterRowUpdate -= rowEventHandler2;
        ug1.BeforeRowsDeleted -= deletedEventHandler;
      }
      this._ug = value;
      UltraGrid ug2 = this._ug;
      if (ug2 == null)
        return;
      ug2.BeforeRowUpdate += cancelableRowEventHandler;
      ug2.AfterRowInsert += rowEventHandler1;
      ug2.AfterRowUpdate += rowEventHandler2;
      ug2.BeforeRowsDeleted += deletedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmUserLicense));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblUserLicenses", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("UserLicenseID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("LicenseTypeID", -1, (object) "ddLicenseTypes");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("StateID", -1, (object) "ddStates");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Expires");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("County");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ZipPlus");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstLicenseTypes", -1);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("LicenseTypeID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("LicenseType");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("lstLicenseTypestblUserLicenses");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstLicenseTypestblUserLicenses", 0);
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("UserLicenseID");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("LicenseTypeID");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Expires");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("County");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("ZipPlus");
    Appearance appearance12 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("lstStatestblUserLicenses");
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstStatestblUserLicenses", 0);
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("UserLicenseID");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("LicenseTypeID");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("Expires");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("County");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("ZipPlus");
    this.cnSQL = new SqlConnection();
    this.daUserLicense = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand3 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.ug = new UltraGrid();
    this.ds = new dsUserLicense();
    this.ddLicenseTypes = new UltraDropDown();
    this.ddStates = new UltraDropDown();
    ((ISupportInitialize) this.ug).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddLicenseTypes).BeginInit();
    ((ISupportInitialize) this.ddStates).BeginInit();
    this.SuspendLayout();
    this.cnSQL.ConnectionString = "Data Source=mgasystems2012.ny.mgasystems.com;Initial Catalog=IMS;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.daUserLicense.DeleteCommand = this.SqlDeleteCommand1;
    this.daUserLicense.InsertCommand = this.SqlInsertCommand1;
    this.daUserLicense.SelectCommand = this.SqlSelectCommand3;
    this.daUserLicense.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUserLicenses", new DataColumnMapping[12]
      {
        new DataColumnMapping("UserGUID", "UserGUID"),
        new DataColumnMapping("LicenseTypeID", "LicenseTypeID"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("Expires", "Expires"),
        new DataColumnMapping("UserLicenseID", "UserLicenseID"),
        new DataColumnMapping("LicenseNumber", "LicenseNumber"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("ZipPlus", "ZipPlus")
      })
    });
    this.daUserLicense.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [tblUserLicenses] WHERE (([UserLicenseID] = @Original_UserLicenseID))";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_UserLicenseID", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 18, (byte) 0, "UserLicenseID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[11]
    {
      new SqlParameter("@UserGUID", SqlDbType.UniqueIdentifier, 0, "UserGUID"),
      new SqlParameter("@LicenseTypeID", SqlDbType.TinyInt, 0, "LicenseTypeID"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@Expires", SqlDbType.DateTime, 0, "Expires"),
      new SqlParameter("@LicenseNumber", SqlDbType.VarChar, 0, "LicenseNumber"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 0, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 0, "County"),
      new SqlParameter("@ZipCode", SqlDbType.Char, 0, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus")
    });
    this.SqlSelectCommand3.CommandText = "SELECT      UserGUID, LicenseTypeID, StateID, Expires, UserLicenseID, LicenseNumber, Address1, Address2, City, County, ZipCode, ZipPlus\r\nFROM         tblUserLicenses\r\nWHERE      (UserGUID = @userGuid)";
    this.SqlSelectCommand3.Connection = this.cnSQL;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@userGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGUID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[13]
    {
      new SqlParameter("@UserGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGUID"),
      new SqlParameter("@LicenseTypeID", SqlDbType.TinyInt, 1, "LicenseTypeID"),
      new SqlParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      new SqlParameter("@Expires", SqlDbType.DateTime, 8, "Expires"),
      new SqlParameter("@LicenseNumber", SqlDbType.VarChar, 20, "LicenseNumber"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 250, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 250, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 50, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 50, "County"),
      new SqlParameter("@ZipCode", SqlDbType.Char, 5, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 4, "ZipPlus"),
      new SqlParameter("@Original_UserLicenseID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "UserLicenseID", DataRowVersion.Original, (object) null),
      new SqlParameter("@UserLicenseID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "UserLicenseID", DataRowVersion.Original, (object) null)
    });
    ((UltraGridBase) this.ug).DataSource = (object) this.ds.tblUserLicenses;
    appearance1.BackColor = Color.White;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).BorderStyle = (UIElementBorderStyle) 1;
    appearance2.BackColor = Color.White;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((UltraGridBase) this.ug).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ug).DisplayLayout.AddNewBox.ButtonStyle = (UIElementButtonStyle) 9;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.ug).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand1.AddButtonCaption = "Add New License...";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 116;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 221;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "License";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Style = (ColumnStyle) 6;
    ultraGridColumn3.Width = 182;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 5;
    ultraGridColumn4.Style = (ColumnStyle) 6;
    ultraGridColumn4.Width = 122;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 99;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "License #";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 3;
    ultraGridColumn6.Width = 139;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 85;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Zip";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Width = 85;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Zip Plus";
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
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 11f;
    ((UltraGridBase) this.ug).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((Control) this.ug).Dock = DockStyle.Fill;
    ((Control) this.ug).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ug).Location = new Point(0, 0);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(1138, 346);
    ((Control) this.ug).TabIndex = 162;
    ((Control) this.ug).Text = "(user name here)";
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsUserLicense";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.ddLicenseTypes).DataSource = (object) this.ds.lstLicenseTypes;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.Gray;
    ((UltraGridBase) this.ddLicenseTypes).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ddLicenseTypes).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand2.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 0;
    ultraGridColumn13.Hidden = true;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 1;
    ultraGridColumn14.Width = 208 /*0xD0*/;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 2;
    ultraGridBand2.Columns.AddRange(new object[3]
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
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 9;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 11;
    ultraGridBand3.Columns.AddRange(new object[12]
    {
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
    ((UltraGridBase) this.ddLicenseTypes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddLicenseTypes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ddLicenseTypes).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddLicenseTypes).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddLicenseTypes).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddLicenseTypes).DisplayMember = "LicenseType";
    ((Control) this.ddLicenseTypes).Location = new Point(14, 98);
    ((Control) this.ddLicenseTypes).Name = "ddLicenseTypes";
    ((Control) this.ddLicenseTypes).Size = new Size(210, 77);
    ((Control) this.ddLicenseTypes).TabIndex = 163;
    ((UltraControlBase) this.ddLicenseTypes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ddLicenseTypes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ddLicenseTypes).ValueMember = "LicenseTypeID";
    ((Control) this.ddLicenseTypes).Visible = false;
    ((UltraGridBase) this.ddStates).DataSource = (object) this.ds.lstStates;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.Gray;
    ((UltraGridBase) this.ddStates).DisplayLayout.Appearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ddStates).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand4.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 0;
    ultraGridColumn28.Hidden = true;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 1;
    ultraGridColumn29.Width = 215;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 2;
    ultraGridBand4.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30
    });
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 7;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 8;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 9;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 11;
    ultraGridBand5.Columns.AddRange(new object[12]
    {
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
      (object) ultraGridColumn42
    });
    ((UltraGridBase) this.ddStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ddStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddStates).DisplayMember = "State";
    ((Control) this.ddStates).Location = new Point(339, 112 /*0x70*/);
    ((Control) this.ddStates).Name = "ddStates";
    ((Control) this.ddStates).Size = new Size(217, 63 /*0x3F*/);
    ((Control) this.ddStates).TabIndex = 164;
    ((UltraControlBase) this.ddStates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ddStates).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ddStates).ValueMember = "StateID";
    ((Control) this.ddStates).Visible = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(1138, 346);
    this.Controls.Add((Control) this.ddStates);
    this.Controls.Add((Control) this.ddLicenseTypes);
    this.Controls.Add((Control) this.ug);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.MaximizeBox = false;
    this.Name = nameof (frmUserLicense);
    this.Text = "User License Management";
    ((ISupportInitialize) this.ug).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddLicenseTypes).EndInit();
    ((ISupportInitialize) this.ddStates).EndInit();
    this.ResumeLayout(false);
  }

  public frmUserLicense(Guid userGUID)
  {
    this.Load += new EventHandler(this.frmUserLicense_Load);
    this.Closing += new CancelEventHandler(this.frmUserLicense_Closing);
    this.InitializeComponent();
    this._userGuid = userGUID;
  }

  private void frmUserLicense_Load(object sender, EventArgs e)
  {
    Utility.SetDataAdapterConnections((DbDataAdapter) this.daUserLicense, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    MGASystems.BusinessObjects.User user = !this._userGuid.Equals(Guid.Empty) ? new MGASystems.BusinessObjects.User(this._userGuid) : throw new InvalidOperationException("UserGuid Not Set");
    ((Control) this.ug).Text = $"{user.FirstName} {user.LastName}";
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
    {
      "lstLicenseTypes",
      "lstStates"
    }, CommandType.Text, "SELECT LicenseTypeID, LicenseType FROM lstLicenseTypes ORDER BY LicenseType; SELECT StateID, State FROM lstStates ORDER BY State");
    this.daUserLicense.SelectCommand.Parameters["@userGuid"].Value = (object) this._userGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daUserLicense, (DataTable) this.ds.tblUserLicenses);
  }

  private void frmUserLicense_Closing(object sender, CancelEventArgs e)
  {
    this.ug.PerformAction((UltraGridAction) 44);
    if (((UltraGridBase) this.ug).ActiveRow != null)
      ((UltraGridBase) this.ug).ActiveRow.Update();
    ((UltraGridBase) this.ug).UpdateData();
    try
    {
      Cursor.Current = Cursors.WaitCursor;
      int num1 = ((UltraGridBase) this.ug).Rows.Count - 1;
      for (int index = 0; index <= num1; ++index)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraGridBase) this.ug).Rows[index].Cells["Expires"].Text, "", false) == 0)
        {
          int num2 = (int) MessageBox.Show("Expires cannot be Null...Add a value before saving or fix the empty Expire field.", "Null Expire Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          e.Cancel = true;
          return;
        }
      }
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daUserLicense, (DataTable) this.ds.tblUserLicenses);
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      if (MessageBox.Show("An error has occured.\n\nWould you like to close the form anyway?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
        e.Cancel = true;
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
    }
  }

  private void ug_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (e.Row.Cells["LicenseNumber"].Value != DBNull.Value)
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  private void ug_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["UserGuid"].Value = (object) this._userGuid;
    CurrentUser.Instance.LogAction("Users Menu - Attempting to add new license.", this._userGuid);
  }

  private void ug_AfterRowUpdate(object sender, RowEventArgs e)
  {
    string str1 = (string) e.Row.Cells["LicenseNumber"].Value;
    int num = (int) e.Row.Cells["UserLicenseID"].Value;
    string str2 = (string) e.Row.Cells["StateID"].Value;
    CurrentUser.Instance.LogAction($"Users Menu - Modified license Information for license number :{str1} and  license ID: {num.ToString()}, state id: {str2}", this._userGuid, Conversions.ToString(num));
  }

  private void ug_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
  {
    string str1 = (string) e.Rows[0].Cells["LicenseNumber"].Value;
    int num = (int) e.Rows[0].Cells["UserLicenseID"].Value;
    string str2 = (string) e.Rows[0].Cells["StateID"].Value;
    CurrentUser.Instance.LogAction($"Users Menu - Deleted license information - license Number:  {str1} , licenseid: {num.ToString()} , State ID: {str2}", this._userGuid, Conversions.ToString(num));
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.ExposureCapture.frmGLExposureCapture
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
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.IMS.Policies.Rating.Locations;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
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
namespace MGASystems.IMS.Policies.Rating.ExposureCapture;

[MGASystems.IMS.Policies.Rating.ExposureCapture.ExposureCapture("General Liability")]
public class frmGLExposureCapture : Form, IExposureCapture
{
  private IContainer components;
  private SqlDataAdapter daLocations;
  private SqlCommand SqlSelectCommand1;
  private SqlConnection cn;
  private dsGLExposureCapture ds;
  private MGAGroupBox MgaGroupBox1;
  private Label Label1;
  private MGASimpleComboBox cboClassCodes;
  private Label Label2;
  private SqlDataAdapter daClassCodes;
  private SqlCommand SqlSelectCommand2;
  private MGANumericEditor txtExposure;
  private SqlDataAdapter daGLExposure;
  private SqlCommand SqlSelectCommand3;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private int _quoteId;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraGrid gridLocations
  {
    get => this._gridLocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gridLocations_AfterRowActivate);
      UltraGrid gridLocations1 = this._gridLocations;
      if (gridLocations1 != null)
        gridLocations1.AfterRowActivate -= eventHandler;
      this._gridLocations = value;
      UltraGrid gridLocations2 = this._gridLocations;
      if (gridLocations2 == null)
        return;
      gridLocations2.AfterRowActivate += eventHandler;
    }
  }

  private virtual LinkLabel lnkLocations
  {
    get => this._lnkLocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkLocations_LinkClicked);
      LinkLabel lnkLocations1 = this._lnkLocations;
      if (lnkLocations1 != null)
        lnkLocations1.LinkClicked -= clickedEventHandler;
      this._lnkLocations = value;
      LinkLabel lnkLocations2 = this._lnkLocations;
      if (lnkLocations2 == null)
        return;
      lnkLocations2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler1 = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedCancel);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingNew -= cancelEventHandler1;
        dbSave1.ClickingCancel -= cancelEventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler3;
        dbSave1.UIStateChanged -= eventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler4;
        dbSave1.ClickedCancel -= eventHandler2;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingNew += cancelEventHandler1;
      dbSave2.ClickingCancel += cancelEventHandler2;
      dbSave2.ClickingSave += cancelEventHandler3;
      dbSave2.UIStateChanged += eventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler4;
      dbSave2.ClickedCancel += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddClassCodes")]
  internal virtual UltraDropDown ddClassCodes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblUnderwritingLocations", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LocationNo");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("BuildingNo");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("PhysicalBuildingNo");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Address");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Zip");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("tblUnderwritingLocations_tblGenericGLExposures");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblUnderwritingLocations_tblGenericGLExposures", 0);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ExposureID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ClassCodeID", -1, (object) "ddClassCodes");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Exposure");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmGLExposureCapture));
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstClassCodes", -1);
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ClassCodeID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ClassCodeDescription");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("lstClassCodestblGenericGLExposures");
    UltraGridBand ultraGridBand4 = new UltraGridBand("lstClassCodestblGenericGLExposures", 0);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ExposureID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ClassCodeID");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Exposure");
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
    this.gridLocations = new UltraGrid();
    this.ds = new dsGLExposureCapture();
    this.daLocations = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cn = new SqlConnection();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.Label1 = new Label();
    this.txtExposure = new MGANumericEditor();
    this.cboClassCodes = new MGASimpleComboBox();
    this.Label2 = new Label();
    this.daClassCodes = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.daGLExposure = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand3 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.lnkLocations = new LinkLabel();
    this.ddClassCodes = new UltraDropDown();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.err = new ErrorProvider(this.components);
    ((ISupportInitialize) this.gridLocations).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.txtExposure).BeginInit();
    ((ISupportInitialize) this.cboClassCodes).BeginInit();
    ((ISupportInitialize) this.ddClassCodes).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    ((Control) this.gridLocations).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridLocations).DataSource = (object) this.ds.tblUnderwritingLocations;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridLocations).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridLocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 56;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Location #";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 61;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Building #";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 96 /*0x60*/;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Phys #";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 99;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 92;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 92;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 92;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 92;
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
    ultraGridColumn10.Width = 157;
    ultraGridColumn11.Header.VisiblePosition = 1;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 145;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Class Code";
    ultraGridColumn12.Header.VisiblePosition = 2;
    ultraGridColumn12.Width = 341;
    ultraGridColumn13.Header.VisiblePosition = 3;
    ultraGridColumn13.Width = 264;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13
    });
    ((UltraGridBase) this.gridLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridLocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.gridLocations).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridLocations).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridLocations).Location = new Point(11, 10);
    ((Control) this.gridLocations).Name = "gridLocations";
    ((Control) this.gridLocations).Size = new Size(645, 389);
    ((Control) this.gridLocations).TabIndex = 0;
    ((Control) this.gridLocations).Text = "Locations on this Policy";
    ((UltraControlBase) this.gridLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridLocations).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsGLExposureCapture";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.daLocations.SelectCommand = this.SqlSelectCommand1;
    this.daLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUnderwritingLocations", new DataColumnMapping[8]
      {
        new DataColumnMapping("LocationID", "LocationID"),
        new DataColumnMapping("LocationNo", "LocationNo"),
        new DataColumnMapping("BuildingNo", "BuildingNo"),
        new DataColumnMapping("PhysicalBuildingNo", "PhysicalBuildingNo"),
        new DataColumnMapping("Address", "Address"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("Zip", "Zip")
      })
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.cn.ConnectionString = "workstation id=PSARNOWSKI;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    ((Control) this.MgaGroupBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance9.BackColor = Color.FromArgb(239, 247, 253);
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance9;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.txtExposure);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboClassCodes);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label2);
    appearance10.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance10;
    ((Control) this.MgaGroupBox1).Location = new Point(11, 409);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(345, 95);
    ((Control) this.MgaGroupBox1).TabIndex = 1;
    this.MgaGroupBox1.Text = "Exposure Information";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(10, 37);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(60, 13);
    this.Label1.TabIndex = 9;
    this.Label1.Text = "Class Code";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtExposure).Appearance = (AppearanceBase) appearance11;
    ((UltraNumericEditorBase) this.txtExposure).FormatString = "c";
    ((Control) this.txtExposure).Location = new Point(80 /*0x50*/, 60);
    this.txtExposure.MaxValue = (object) 999999999;
    this.txtExposure.MGAStyle = MGAStyles.Blue;
    this.txtExposure.MinValue = (object) 0;
    ((Control) this.txtExposure).Name = "txtExposure";
    ((Control) this.txtExposure).Size = new Size(105, 20);
    ((Control) this.txtExposure).TabIndex = 12;
    ((UltraControlBase) this.txtExposure).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtExposure).UseOsThemes = (DefaultableBoolean) 2;
    this.cboClassCodes.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboClassCodes).DataSource = (object) this.ds.lstClassCodes;
    ((UltraDropDownBase) this.cboClassCodes).DisplayMember = "ClassCodeDescription";
    this.cboClassCodes.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboClassCodes).DropDownWidth = 300;
    ((Control) this.cboClassCodes).Location = new Point(80 /*0x50*/, 35);
    this.cboClassCodes.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboClassCodes).Name = "cboClassCodes";
    ((Control) this.cboClassCodes).Size = new Size(250, 21);
    ((Control) this.cboClassCodes).TabIndex = 11;
    ((UltraControlBase) this.cboClassCodes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboClassCodes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboClassCodes).ValueMember = "ClassCodeID";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(18, 62);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(52, 13);
    this.Label2.TabIndex = 10;
    this.Label2.Text = "Exposure";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.daClassCodes.SelectCommand = this.SqlSelectCommand2;
    this.daClassCodes.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstClassCodes", new DataColumnMapping[2]
      {
        new DataColumnMapping("ClassCodeID", "ClassCodeID"),
        new DataColumnMapping("ClassCodeDescription", "ClassCodeDescription")
      })
    });
    this.SqlSelectCommand2.CommandText = "SELECT ClassCodeID, ClassCode + ' - ' + ClassCodeDescription AS ClassCodeDescription FROM lstClassCodes ORDER BY ClassCode";
    this.SqlSelectCommand2.Connection = this.cn;
    this.daGLExposure.DeleteCommand = this.SqlDeleteCommand1;
    this.daGLExposure.InsertCommand = this.SqlInsertCommand1;
    this.daGLExposure.SelectCommand = this.SqlSelectCommand3;
    this.daGLExposure.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblGenericGLExposures", new DataColumnMapping[4]
      {
        new DataColumnMapping("ExposureID", "ExposureID"),
        new DataColumnMapping("LocationID", "LocationID"),
        new DataColumnMapping("ClassCodeID", "ClassCodeID"),
        new DataColumnMapping("Exposure", "Exposure")
      })
    });
    this.daGLExposure.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblGenericGLExposures WHERE (ExposureID = @Original_ExposureID)";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ExposureID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ExposureID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@LocationID", SqlDbType.Int, 4, "LocationID"),
      new SqlParameter("@ClassCodeID", SqlDbType.SmallInt, 2, "ClassCodeID"),
      new SqlParameter("@Exposure", SqlDbType.Int, 4, "Exposure")
    });
    this.SqlSelectCommand3.CommandText = componentResourceManager.GetString("SqlSelectCommand3.CommandText");
    this.SqlSelectCommand3.Connection = this.cn;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@LocationID", SqlDbType.Int, 4, "LocationID"),
      new SqlParameter("@ClassCodeID", SqlDbType.SmallInt, 2, "ClassCodeID"),
      new SqlParameter("@Exposure", SqlDbType.Int, 4, "Exposure"),
      new SqlParameter("@Original_ExposureID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ExposureID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ExposureID", SqlDbType.Int, 4, "ExposureID")
    });
    this.lnkLocations.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkLocations.AutoSize = true;
    this.lnkLocations.Location = new Point(440, 409);
    this.lnkLocations.Name = "lnkLocations";
    this.lnkLocations.Size = new Size(209, 13);
    this.lnkLocations.TabIndex = 3;
    this.lnkLocations.TabStop = true;
    this.lnkLocations.Text = "Click here to modify underwriting locations";
    ((UltraGridBase) this.ddClassCodes).DataMember = "lstClassCodes";
    ((UltraGridBase) this.ddClassCodes).DataSource = (object) this.ds;
    appearance12.BackColor = SystemColors.Window;
    appearance12.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.Appearance = (AppearanceBase) appearance12;
    ultraGridColumn14.Header.VisiblePosition = 1;
    ultraGridColumn15.Header.VisiblePosition = 0;
    ultraGridColumn16.Header.VisiblePosition = 2;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ultraGridColumn17.Header.VisiblePosition = 0;
    ultraGridColumn18.Header.VisiblePosition = 1;
    ultraGridColumn19.Header.VisiblePosition = 2;
    ultraGridColumn20.Header.VisiblePosition = 3;
    ultraGridBand4.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20
    });
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance13.BackColor = SystemColors.ActiveBorder;
    appearance13.BackColor2 = SystemColors.ControlDark;
    appearance13.BackGradientStyle = (GradientStyle) 2;
    appearance13.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddClassCodes).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance13;
    appearance14.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance14;
    ((SpecialBoxBase) ((UltraGridBase) this.ddClassCodes).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance15.BackColor = SystemColors.ControlLightLight;
    appearance15.BackColor2 = SystemColors.Control;
    appearance15.BackGradientStyle = (GradientStyle) 3;
    appearance15.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.MaxRowScrollRegions = 1;
    appearance16.BackColor = SystemColors.Window;
    appearance16.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance16;
    appearance17.BackColor = SystemColors.Highlight;
    appearance17.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance18.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance18;
    appearance19.BorderColor = Color.Silver;
    appearance19.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.Override.CellPadding = 0;
    appearance20.BackColor = SystemColors.Control;
    appearance20.BackColor2 = SystemColors.ControlDark;
    appearance20.BackGradientAlignment = (GradientAlignment) 1;
    appearance20.BackGradientStyle = (GradientStyle) 3;
    appearance20.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance22.BackColor = SystemColors.Window;
    appearance22.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance23.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddClassCodes).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddClassCodes).DisplayMember = "ClassCodeDescription";
    ((Control) this.ddClassCodes).Location = new Point(511 /*0x01FF*/, 259);
    ((Control) this.ddClassCodes).Name = "ddClassCodes";
    ((Control) this.ddClassCodes).Size = new Size(138, 95);
    ((Control) this.ddClassCodes).TabIndex = 6;
    ((Control) this.ddClassCodes).Text = "UltraDropDown1";
    ((UltraDropDownBase) this.ddClassCodes).ValueMember = "ClassCodeID";
    ((Control) this.ddClassCodes).Visible = false;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(362, 464);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 7;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(667, 515);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.ddClassCodes);
    this.Controls.Add((Control) this.lnkLocations);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Controls.Add((Control) this.gridLocations);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmGLExposureCapture);
    this.Text = "GL Exposure Capture";
    ((ISupportInitialize) this.gridLocations).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.txtExposure).EndInit();
    ((ISupportInitialize) this.cboClassCodes).EndInit();
    ((ISupportInitialize) this.ddClassCodes).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmGLExposureCapture()
  {
    this.Load += new EventHandler(this.frmGLExposureCapture_Load);
    this._quoteId = -1;
    this.InitializeComponent();
  }

  public void SetQuoteId(int quoteId) => this._quoteId = quoteId;

  private void SetSaveState()
  {
    if (this.ds.tblGenericGLExposures.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void frmGLExposureCapture_Load(object sender, EventArgs e)
  {
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    dsGLExposureCapture.lstClassCodesRow row = this.ds.lstClassCodes.NewlstClassCodesRow();
    row.ClassCodeID = -1;
    row.ClassCodeDescription = string.Empty;
    this.ds.lstClassCodes.AddlstClassCodesRow(row);
    Database.SafeDataAdapterFill(this.daClassCodes, (DataTable) this.ds.lstClassCodes);
    this.daLocations.SelectCommand.Parameters["@QuoteID"].Value = (object) this._quoteId;
    Database.SafeDataAdapterFill(this.daLocations, (DataTable) this.ds.tblUnderwritingLocations);
    if (this.ds.tblUnderwritingLocations.Count == 0)
      this.ShowUnderwritingLocationsForm();
    this.daGLExposure.SelectCommand.Parameters["@QuoteID"].Value = (object) this._quoteId;
    Database.SafeDataAdapterFill(this.daGLExposure, (DataTable) this.ds.tblGenericGLExposures);
    ((UltraGridBase) this.gridLocations).Rows.ExpandAll(true);
    if (this.ds.tblGenericGLExposures.Count > 0)
      this.SetActiveChildRow(this.ds.tblGenericGLExposures[this.ds.tblGenericGLExposures.Count - 1].ExposureID);
    else if (this.ds.tblUnderwritingLocations.Count > 0)
      ((UltraGridBase) this.gridLocations).ActiveRow = ((UltraGridBase) this.gridLocations).Rows[((UltraGridBase) this.gridLocations).Rows.Count - 1];
    this.SetSaveState();
  }

  private void ShowUnderwritingLocationsForm()
  {
    FormSettings.ShowFormDialog(typeof (frmUnderwritingLocations), (object) new Quote(this._quoteId).QuoteGuid, (object) true).Dispose();
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      this.ds.EnforceConstraints = false;
      this.ds.tblUnderwritingLocations.Clear();
      Database.SafeDataAdapterFill(this.daLocations, (DataTable) this.ds.tblUnderwritingLocations);
      this.ds.EnforceConstraints = true;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.gridLocations).ActiveRow == null)
    {
      e.Cancel = true;
    }
    else
    {
      int num = ((UltraGridBase) this.gridLocations).ActiveRow.Band.Index != 0 ? (int) ((UltraGridBase) this.gridLocations).ActiveRow.ParentRow.Cells["LocationID"].Value : (int) ((UltraGridBase) this.gridLocations).ActiveRow.Cells["LocationID"].Value;
      dsGLExposureCapture.tblGenericGLExposuresRow row = this.ds.tblGenericGLExposures.NewtblGenericGLExposuresRow();
      row.LocationID = num;
      row.SetClassCodeIDNull();
      row.Exposure = 0;
      this.ds.tblGenericGLExposures.AddtblGenericGLExposuresRow(row);
      this.cboClassCodes.Value = (object) DBNull.Value;
      this.txtExposure.Value = (object) 0;
      this.SetActiveChildRow(this.ds.tblGenericGLExposures[this.ds.tblGenericGLExposures.Count - 1].ExposureID);
      this.gridLocations_AfterRowActivate((object) null, (EventArgs) null);
    }
  }

  private bool IsValid()
  {
    bool flag = true;
    this.err.SetError((Control) this.cboClassCodes, string.Empty);
    this.err.SetError((Control) this.txtExposure, string.Empty);
    if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.cboClassCodes.Value)))
    {
      this.err.SetError((Control) this.cboClassCodes, "Please select a class");
      flag = false;
    }
    if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.txtExposure.Value)))
    {
      this.err.SetError((Control) this.txtExposure, "Please enter an exposure amount");
      flag = false;
    }
    return flag;
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ds.RejectChanges();
    try
    {
      foreach (Control control in ((Control) this.MgaGroupBox1).Controls)
        this.err.SetError(control, string.Empty);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.SetSaveState();
    if (this.ds.tblGenericGLExposures.Count > 0)
    {
      this.SetActiveChildRow(this.ds.tblGenericGLExposures[this.ds.tblGenericGLExposures.Count - 1].ExposureID);
    }
    else
    {
      if (this.ds.tblUnderwritingLocations.Count <= 0)
        return;
      ((UltraGridBase) this.gridLocations).ActiveRow = ((UltraGridBase) this.gridLocations).Rows[((UltraGridBase) this.gridLocations).Rows.Count - 1];
    }
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.IsValid())
      e.Cancel = true;
    else if (((UltraGridBase) this.gridLocations).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select an active row in the grid to continue.", "No Active Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
    {
      dsGLExposureCapture.tblGenericGLExposuresRow byExposureId;
      if (this.ds.tblGenericGLExposures.Select(string.Empty, string.Empty, DataViewRowState.Added).Length > 0)
      {
        byExposureId = (dsGLExposureCapture.tblGenericGLExposuresRow) this.ds.tblGenericGLExposures.Select(string.Empty, string.Empty, DataViewRowState.Added)[0];
      }
      else
      {
        if (((UltraGridBase) this.gridLocations).ActiveRow.Band.Index == 0)
        {
          int num = (int) MessageBox.Show("Selection is currently on the location row.\n\nPlease select an active exposure row in the grid to continue.", "No Active Exposure Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          e.Cancel = true;
          return;
        }
        byExposureId = this.ds.tblGenericGLExposures.FindByExposureID((int) ((UltraGridBase) this.gridLocations).ActiveRow.Cells["ExposureID"].Value);
      }
      try
      {
        byExposureId.ClassCodeID = Conversions.ToInteger(this.cboClassCodes.Value);
      }
      catch (ConstraintException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.err.SetError((Control) this.cboClassCodes, "All exposure must be unique on a location");
        e.Cancel = true;
        ProjectData.ClearProjectError();
        return;
      }
      byExposureId.Exposure = Conversions.ToInteger(this.txtExposure.Value);
      this.err.SetError((Control) this.cboClassCodes, string.Empty);
      this.daGLExposure.Update((DataTable) this.ds.tblGenericGLExposures);
    }
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    try
    {
      foreach (Control control in ((Control) this.MgaGroupBox1).Controls)
        control.Enabled = this.dbSave.UIState == UIState.Editing;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((Control) this.gridLocations).Enabled = this.dbSave.UIState != UIState.Editing;
  }

  private void MoveToExposure()
  {
    if (((UltraGridBase) this.gridLocations).ActiveRow == null)
      return;
    int num = (int) ((UltraGridBase) this.gridLocations).ActiveRow.Cells["ExposureID"].Value;
    dsGLExposureCapture.tblGenericGLExposuresRow byExposureId = this.ds.tblGenericGLExposures.FindByExposureID(num);
    if (byExposureId != null)
    {
      if (!byExposureId.IsClassCodeIDNull())
        this.cboClassCodes.Value = (object) byExposureId.ClassCodeID;
      this.txtExposure.Value = (object) byExposureId.Exposure;
    }
    else
    {
      this.cboClassCodes.Value = (object) null;
      this.txtExposure.Value = (object) null;
    }
    this.SetActiveChildRow(num);
  }

  private void gridLocations_AfterRowActivate(object sender, EventArgs e)
  {
    this.cboClassCodes.Value = (object) null;
    this.txtExposure.Value = (object) null;
    if (((UltraGridBase) this.gridLocations).ActiveRow != null && ((UltraGridBase) this.gridLocations).ActiveRow.Band.Index == 1)
      this.MoveToExposure();
    this.SetSaveState();
  }

  private void lnkLocations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ShowUnderwritingLocationsForm();
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.gridLocations).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Select an active row  to continue.", "No Active Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else if (((UltraGridBase) this.gridLocations).ActiveRow.Band.Index == 0)
    {
      int num = (int) MessageBox.Show("Select an active exposure to continue.", "Location Active Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else if (MessageBox.Show("Continue delete?", "Continue Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
    {
      e.Cancel = true;
    }
    else
    {
      this.ds.tblGenericGLExposures.FindByExposureID((int) ((UltraGridBase) this.gridLocations).ActiveRow.Cells["ExposureID"].Value).Delete();
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daGLExposure, (DataTable) this.ds.tblGenericGLExposures);
      if (this.ds.tblGenericGLExposures.Count > 0)
        this.SetActiveChildRow(this.ds.tblGenericGLExposures[this.ds.tblGenericGLExposures.Count - 1].ExposureID);
      else if (this.ds.tblUnderwritingLocations.Count > 0)
        ((UltraGridBase) this.gridLocations).ActiveRow = ((UltraGridBase) this.gridLocations).Rows[((UltraGridBase) this.gridLocations).Rows.Count - 1];
      this.gridLocations_AfterRowActivate((object) null, (EventArgs) null);
      this.SetSaveState();
    }
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e) => this.SetSaveState();

  private void SetActiveChildRow(int exposureID)
  {
    UltraGridBand band = ((UltraGridBase) this.gridLocations).DisplayLayout.Bands[1];
    try
    {
      foreach (UltraGridRow ultraGridRow in band.GetRowEnumerator((GridRowType) 1))
      {
        if ((int) ultraGridRow.Cells["ExposureID"].Value == exposureID)
        {
          ((UltraGridBase) this.gridLocations).ActiveRow = ultraGridRow;
          break;
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
}

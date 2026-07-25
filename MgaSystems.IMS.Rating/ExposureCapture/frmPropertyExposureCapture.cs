// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.ExposureCapture.frmPropertyExposureCapture
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

[MGASystems.IMS.Policies.Rating.ExposureCapture.ExposureCapture("Property")]
public class frmPropertyExposureCapture : Form, IExposureCapture
{
  private IContainer components;
  private SqlDataAdapter daLocations;
  private SqlCommand SqlSelectCommand1;
  private SqlConnection cn;
  private dsPropertyExposureCapture ds;
  private MGAGroupBox MgaGroupBox1;
  private Label Label1;
  private Label Label2;
  private SqlCommand SqlSelectCommand2;
  private SqlDataAdapter daCoverages;
  private MGASimpleComboBox cboCoverages;
  private MGANumericEditor txtLimit;
  private SqlDataAdapter daExposure;
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

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraDropDown1")]
  internal virtual UltraDropDown UltraDropDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingCancel -= cancelEventHandler1;
        dbSave1.ClickingNew -= cancelEventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler3;
        dbSave1.UIStateChanged -= eventHandler;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingCancel += cancelEventHandler1;
      dbSave2.ClickingNew += cancelEventHandler2;
      dbSave2.ClickingSave += cancelEventHandler3;
      dbSave2.UIStateChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboDeductible")]
  internal virtual MGAComboBox comboDeductible { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("tblGenericPropertyExposures_tblUnderwritingLocations");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblGenericPropertyExposures_tblUnderwritingLocations", 0);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ExposureID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("CoverageID", -1, (object) "UltraDropDown1", 0, (SortIndicator) 2, false);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Limit");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Deductible");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPropertyExposureCapture));
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstPropRater_CoverageTypes", -1);
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Coverage");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("lstPropRater_CoverageTypestblGenericPropertyExposures");
    UltraGridBand ultraGridBand4 = new UltraGridBand("lstPropRater_CoverageTypestblGenericPropertyExposures", 0);
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ExposureID");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("CoverageID");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("Limit");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("Deductible");
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
    UltraGridBand ultraGridBand5 = new UltraGridBand("", -1);
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
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.gridLocations = new UltraGrid();
    this.ds = new dsPropertyExposureCapture();
    this.daLocations = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cn = new SqlConnection();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.Label3 = new Label();
    this.Label1 = new Label();
    this.txtLimit = new MGANumericEditor();
    this.cboCoverages = new MGASimpleComboBox();
    this.Label2 = new Label();
    this.daCoverages = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.daExposure = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand3 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.lnkLocations = new LinkLabel();
    this.err = new ErrorProvider(this.components);
    this.UltraDropDown1 = new UltraDropDown();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.comboDeductible = new MGAComboBox();
    ((ISupportInitialize) this.gridLocations).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.txtLimit).BeginInit();
    ((ISupportInitialize) this.cboCoverages).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraDropDown1).BeginInit();
    ((ISupportInitialize) this.comboDeductible).BeginInit();
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
    ultraGridColumn2.Width = 69;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Building #";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 88;
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
    ultraGridColumn10.Width = 159;
    ultraGridColumn11.Header.VisiblePosition = 1;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 144 /*0x90*/;
    ultraGridColumn12.Header.VisiblePosition = 2;
    ultraGridColumn12.Width = 294;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Right";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn13.Format = "c";
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance3;
    ultraGridColumn13.Header.VisiblePosition = 3;
    ultraGridColumn13.Width = 225;
    ultraGridColumn14.Header.VisiblePosition = 4;
    ultraGridColumn14.Width = 86;
    ultraGridBand2.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    ((UltraGridBase) this.gridLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridLocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.gridLocations).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridLocations).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridLocations).Location = new Point(11, 10);
    ((Control) this.gridLocations).Name = "gridLocations";
    ((Control) this.gridLocations).Size = new Size(645, 377);
    ((Control) this.gridLocations).TabIndex = 0;
    ((Control) this.gridLocations).Text = "Locations on this Policy";
    ((UltraControlBase) this.gridLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridLocations).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsPropertyExposureCapture";
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
    this.cn.ConnectionString = "Data Source=TEAMMGA;Initial Catalog=IMS;Integrated Security=True";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    ((Control) this.MgaGroupBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance11.BackColor = Color.FromArgb(239, 247, 253);
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance11;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.comboDeductible);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label3);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.txtLimit);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboCoverages);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label2);
    appearance12.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance12;
    ((Control) this.MgaGroupBox1).Location = new Point(11, 393);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(345, 128 /*0x80*/);
    ((Control) this.MgaGroupBox1).TabIndex = 1;
    this.MgaGroupBox1.Text = "Exposure Information";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(8, 90);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(61, 13);
    this.Label3.TabIndex = 13;
    this.Label3.Text = "Deductible:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(19, 39);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(50, 13);
    this.Label1.TabIndex = 9;
    this.Label1.Text = "Covering";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtLimit).Appearance = (AppearanceBase) appearance13;
    ((UltraNumericEditorBase) this.txtLimit).FormatString = "c";
    ((Control) this.txtLimit).Location = new Point(80 /*0x50*/, 61);
    this.txtLimit.MaxValue = (object) 999999999;
    this.txtLimit.MGAStyle = MGAStyles.Blue;
    this.txtLimit.MinValue = (object) 0;
    ((Control) this.txtLimit).Name = "txtLimit";
    ((Control) this.txtLimit).Size = new Size(105, 20);
    ((Control) this.txtLimit).TabIndex = 12;
    ((UltraControlBase) this.txtLimit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLimit).UseOsThemes = (DefaultableBoolean) 2;
    this.cboCoverages.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCoverages.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboCoverages).DataSource = (object) this.ds.lstPropRater_CoverageTypes;
    ((UltraDropDownBase) this.cboCoverages).DisplayMember = "Coverage";
    this.cboCoverages.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboCoverages.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCoverages).DropDownWidth = 300;
    ((Control) this.cboCoverages).Location = new Point(80 /*0x50*/, 35);
    this.cboCoverages.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCoverages).Name = "cboCoverages";
    ((Control) this.cboCoverages).Size = new Size(250, 21);
    ((Control) this.cboCoverages).TabIndex = 11;
    ((UltraControlBase) this.cboCoverages).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCoverages).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCoverages).ValueMember = "ID";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(41, 65);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(28, 13);
    this.Label2.TabIndex = 10;
    this.Label2.Text = "Limit";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.daCoverages.SelectCommand = this.SqlSelectCommand2;
    this.daCoverages.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstClassCodes", new DataColumnMapping[2]
      {
        new DataColumnMapping("ClassCodeID", "ClassCodeID"),
        new DataColumnMapping("ClassCodeDescription", "ClassCodeDescription")
      })
    });
    this.SqlSelectCommand2.CommandText = "SELECT ID, Type + ' - ' + Coverage AS Coverage FROM lstPropRater_CoverageTypes ORDER BY Type + ' - ' + Coverage";
    this.SqlSelectCommand2.Connection = this.cn;
    this.daExposure.DeleteCommand = this.SqlDeleteCommand1;
    this.daExposure.InsertCommand = this.SqlInsertCommand1;
    this.daExposure.SelectCommand = this.SqlSelectCommand3;
    this.daExposure.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblGenericPropertyExposures", new DataColumnMapping[5]
      {
        new DataColumnMapping("ExposureID", "ExposureID"),
        new DataColumnMapping("LocationID", "LocationID"),
        new DataColumnMapping("Limit", "Limit"),
        new DataColumnMapping("CoverageID", "CoverageID"),
        new DataColumnMapping("Deductible", "Deductible")
      })
    });
    this.daExposure.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [tblGenericPropertyExposures] WHERE (([ExposureID] = @Original_ExposureID))";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ExposureID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ExposureID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@LocationID", SqlDbType.Int, 0, "LocationID"),
      new SqlParameter("@Limit", SqlDbType.Int, 0, "Limit"),
      new SqlParameter("@CoverageID", SqlDbType.TinyInt, 0, "CoverageID"),
      new SqlParameter("@Deductible", SqlDbType.VarChar, 0, "Deductible")
    });
    this.SqlSelectCommand3.CommandText = componentResourceManager.GetString("SqlSelectCommand3.CommandText");
    this.SqlSelectCommand3.Connection = this.cn;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@LocationID", SqlDbType.Int, 0, "LocationID"),
      new SqlParameter("@Limit", SqlDbType.Int, 0, "Limit"),
      new SqlParameter("@CoverageID", SqlDbType.TinyInt, 0, "CoverageID"),
      new SqlParameter("@Deductible", SqlDbType.VarChar, 0, "Deductible"),
      new SqlParameter("@Original_ExposureID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ExposureID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ExposureID", SqlDbType.Int, 4, "ExposureID")
    });
    this.lnkLocations.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkLocations.AutoSize = true;
    this.lnkLocations.Location = new Point(447, 395);
    this.lnkLocations.Name = "lnkLocations";
    this.lnkLocations.Size = new Size(209, 13);
    this.lnkLocations.TabIndex = 3;
    this.lnkLocations.TabStop = true;
    this.lnkLocations.Text = "Click here to modify underwriting locations";
    this.err.ContainerControl = (ContainerControl) this;
    ((UltraGridBase) this.UltraDropDown1).DataMember = "lstPropRater_CoverageTypes";
    ((UltraGridBase) this.UltraDropDown1).DataSource = (object) this.ds;
    appearance14.BackColor = SystemColors.Window;
    appearance14.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Appearance = (AppearanceBase) appearance14;
    ultraGridColumn15.Header.VisiblePosition = 0;
    ultraGridColumn16.Header.VisiblePosition = 1;
    ultraGridColumn17.Header.VisiblePosition = 2;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17
    });
    ultraGridColumn18.Header.VisiblePosition = 0;
    ultraGridColumn19.Header.VisiblePosition = 1;
    ultraGridColumn20.Header.VisiblePosition = 2;
    ultraGridColumn21.Header.VisiblePosition = 3;
    ultraGridColumn22.Header.VisiblePosition = 4;
    ultraGridBand4.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22
    });
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance15.BackColor = SystemColors.ActiveBorder;
    appearance15.BackColor2 = SystemColors.ControlDark;
    appearance15.BackGradientStyle = (GradientStyle) 2;
    appearance15.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraDropDown1).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance15;
    appearance16.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance16;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraDropDown1).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance17.BackColor = SystemColors.ControlLightLight;
    appearance17.BackColor2 = SystemColors.Control;
    appearance17.BackGradientStyle = (GradientStyle) 3;
    appearance17.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.MaxRowScrollRegions = 1;
    appearance18.BackColor = SystemColors.Window;
    appearance18.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance18;
    appearance19.BackColor = SystemColors.Highlight;
    appearance19.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance20.BackColor = SystemColors.Window;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance20;
    appearance21.BorderColor = Color.Silver;
    appearance21.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.CellPadding = 0;
    appearance22.BackColor = SystemColors.Control;
    appearance22.BackColor2 = SystemColors.ControlDark;
    appearance22.BackGradientAlignment = (GradientAlignment) 1;
    appearance22.BackGradientStyle = (GradientStyle) 3;
    appearance22.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Left";
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance24.BackColor = SystemColors.Window;
    appearance24.BorderColor = Color.Silver;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance25.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.UltraDropDown1).DisplayMember = "Coverage";
    ((Control) this.UltraDropDown1).Location = new Point(262, 106);
    ((Control) this.UltraDropDown1).Name = "UltraDropDown1";
    ((Control) this.UltraDropDown1).Size = new Size(331, 55);
    ((Control) this.UltraDropDown1).TabIndex = 6;
    ((Control) this.UltraDropDown1).Text = "UltraDropDown1";
    ((UltraDropDownBase) this.UltraDropDown1).ValueMember = "ID";
    ((Control) this.UltraDropDown1).Visible = false;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(362, 481);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 7;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
    this.comboDeductible.BorderStyle = (UIElementBorderStyle) 4;
    this.comboDeductible.CharacterCasing = CharacterCasing.Normal;
    appearance26.BackColor = Color.White;
    appearance26.BorderColor = Color.FromArgb(78, 122, 171);
    this.comboDeductible.DisplayLayout.Appearance = (AppearanceBase) appearance26;
    this.comboDeductible.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand5.ColHeadersVisible = false;
    this.comboDeductible.DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    this.comboDeductible.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.comboDeductible.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance27.BackColor = SystemColors.ActiveBorder;
    appearance27.BackColor2 = SystemColors.ControlDark;
    appearance27.BackGradientStyle = (GradientStyle) 2;
    appearance27.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.comboDeductible.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance27;
    appearance28.ForeColor = SystemColors.GrayText;
    this.comboDeductible.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance28;
    ((SpecialBoxBase) this.comboDeductible.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance29.BackColor = SystemColors.ControlLightLight;
    appearance29.BackColor2 = SystemColors.Control;
    appearance29.BackGradientStyle = (GradientStyle) 3;
    appearance29.ForeColor = SystemColors.GrayText;
    this.comboDeductible.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance29;
    this.comboDeductible.DisplayLayout.MaxColScrollRegions = 1;
    this.comboDeductible.DisplayLayout.MaxRowScrollRegions = 1;
    appearance30.BackColor = SystemColors.Window;
    appearance30.ForeColor = SystemColors.ControlText;
    this.comboDeductible.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance30;
    appearance31.BackColor = SystemColors.Highlight;
    appearance31.ForeColor = SystemColors.HighlightText;
    this.comboDeductible.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance31;
    this.comboDeductible.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.comboDeductible.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance32.BackColor = SystemColors.Window;
    this.comboDeductible.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance32;
    appearance33.BorderColor = Color.Silver;
    appearance33.TextTrimming = (TextTrimming) 3;
    this.comboDeductible.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance33;
    this.comboDeductible.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.comboDeductible.DisplayLayout.Override.CellPadding = 0;
    appearance34.BackColor = SystemColors.Control;
    appearance34.BackColor2 = SystemColors.ControlDark;
    appearance34.BackGradientAlignment = (GradientAlignment) 1;
    appearance34.BackGradientStyle = (GradientStyle) 3;
    appearance34.BorderColor = SystemColors.Window;
    this.comboDeductible.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance34;
    ((AppearanceBase) appearance35).TextHAlignAsString = "Left";
    this.comboDeductible.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance35;
    this.comboDeductible.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.comboDeductible.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance36.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance36.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.comboDeductible.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance36;
    appearance37.BackColor = SystemColors.Window;
    appearance37.BorderColor = Color.White;
    this.comboDeductible.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance37;
    this.comboDeductible.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.comboDeductible.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance38.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance38.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance38.ForeColor = Color.Black;
    this.comboDeductible.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance38;
    appearance39.BackColor = SystemColors.ControlLight;
    this.comboDeductible.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance39;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.comboDeductible.DisplayLayout.ScrollBarLook = scrollBarLook2;
    this.comboDeductible.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.comboDeductible.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.comboDeductible.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    this.comboDeductible.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    ((Control) this.comboDeductible).Location = new Point(80 /*0x50*/, 87);
    this.comboDeductible.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboDeductible).Name = "comboDeductible";
    ((Control) this.comboDeductible).Size = new Size(250, 21);
    ((Control) this.comboDeductible).TabIndex = 14;
    ((UltraControlBase) this.comboDeductible).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboDeductible).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(667, 532);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.UltraDropDown1);
    this.Controls.Add((Control) this.lnkLocations);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Controls.Add((Control) this.gridLocations);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmPropertyExposureCapture);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Property Exposure Capture";
    ((ISupportInitialize) this.gridLocations).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.txtLimit).EndInit();
    ((ISupportInitialize) this.cboCoverages).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraDropDown1).EndInit();
    ((ISupportInitialize) this.comboDeductible).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblGenericPropertyExposures.TableName];
  }

  public frmPropertyExposureCapture()
  {
    this.Load += new EventHandler(this.frmPropertyExposureCapture_Load);
    this._quoteId = -1;
    this.InitializeComponent();
    this.comboDeductible.DropDownStyle = (UltraComboStyle) 0;
  }

  public void SetQuoteId(int quoteId) => this._quoteId = quoteId;

  private void frmPropertyExposureCapture_Load(object sender, EventArgs e)
  {
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    MGASystems.Common.DataAccess.Database.SafeDataAdapterFill(this.daCoverages, (DataTable) this.ds.lstPropRater_CoverageTypes);
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT DISTINCT Deductible FROM tblGenericPropertyExposures ORDER BY Deductible");
    MGAComboBox comboDeductible = this.comboDeductible;
    ((UltraGridBase) comboDeductible).DataSource = (object) dataTable;
    ((UltraDropDownBase) comboDeductible).DisplayMember = "Deductible";
    ((UltraDropDownBase) comboDeductible).ValueMember = "Deductible";
    this.daLocations.SelectCommand.Parameters["@QuoteID"].Value = (object) this._quoteId;
    MGASystems.Common.DataAccess.Database.SafeDataAdapterFill(this.daLocations, (DataTable) this.ds.tblUnderwritingLocations);
    this.daLocations.Fill((DataTable) this.ds.tblUnderwritingLocations);
    if (this.ds.tblUnderwritingLocations.Count == 0)
      this.ShowUnderwritingLocationsForm();
    this.daExposure.SelectCommand.Parameters["@QuoteID"].Value = (object) this._quoteId;
    MGASystems.Common.DataAccess.Database.SafeDataAdapterFill(this.daExposure, (DataTable) this.ds.tblGenericPropertyExposures);
    ((UltraGridBase) this.gridLocations).Rows.ExpandAll(true);
  }

  private void ShowUnderwritingLocationsForm()
  {
    FormSettings.ShowFormDialog(typeof (frmUnderwritingLocations), (object) new Quote(this._quoteId).QuoteGuid, (object) true).Dispose();
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      this.ds.EnforceConstraints = false;
      this.ds.tblUnderwritingLocations.Clear();
      MGASystems.Common.DataAccess.Database.SafeDataAdapterFill(this.daLocations, (DataTable) this.ds.tblUnderwritingLocations);
      this.ds.EnforceConstraints = true;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void MoveToExposure()
  {
    if (((UltraGridBase) this.gridLocations).ActiveRow == null)
      return;
    int ExposureID = (int) ((UltraGridBase) this.gridLocations).ActiveRow.Cells["ExposureID"].Value;
    MGASystems.Common.Functions.Database.MoveTo((object) ExposureID, this.ds.tblGenericPropertyExposures.ExposureIDColumn.ColumnName, (DataTable) this.ds.tblGenericPropertyExposures, this.bmb);
    dsPropertyExposureCapture.tblGenericPropertyExposuresRow byExposureId = this.ds.tblGenericPropertyExposures.FindByExposureID(ExposureID);
    if (byExposureId != null)
    {
      if (!byExposureId.IsCoverageIDNull())
        this.cboCoverages.Value = (object) byExposureId.CoverageID;
      else
        this.cboCoverages.Value = (object) null;
      if (!byExposureId.IsDeductibleNull())
      {
        this.comboDeductible.Text = byExposureId.Deductible;
      }
      else
      {
        this.comboDeductible.Value = (object) null;
        this.comboDeductible.Text = string.Empty;
      }
      this.txtLimit.Value = (object) byExposureId.Limit;
    }
    else
    {
      this.cboCoverages.Value = (object) null;
      this.txtLimit.Value = (object) null;
      this.comboDeductible.Value = (object) null;
    }
  }

  private void gridLocations_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridLocations).ActiveRow != null && ((UltraGridBase) this.gridLocations).ActiveRow.Band.Index == 1)
    {
      this.MoveToExposure();
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    }
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void lnkLocations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ShowUnderwritingLocationsForm();
  }

  private bool IsValid()
  {
    bool flag = true;
    if (string.IsNullOrEmpty(this.cboCoverages.Text))
    {
      this.err.SetError((Control) this.cboCoverages, "Please enter a value");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboCoverages, string.Empty);
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
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.gridLocations).ActiveRow == null)
      return;
    int num = ((UltraGridBase) this.gridLocations).ActiveRow.Band.Index != 0 ? (int) ((UltraGridBase) this.gridLocations).ActiveRow.ParentRow.Cells["LocationID"].Value : (int) ((UltraGridBase) this.gridLocations).ActiveRow.Cells["LocationID"].Value;
    dsPropertyExposureCapture.tblGenericPropertyExposuresRow row = this.ds.tblGenericPropertyExposures.NewtblGenericPropertyExposuresRow();
    row.LocationID = num;
    this.ds.tblGenericPropertyExposures.AddtblGenericPropertyExposuresRow(row);
    this.cboCoverages.Value = (object) null;
    this.txtLimit.Value = (object) null;
    this.comboDeductible.Value = (object) null;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    bool flag = this.ds.tblGenericPropertyExposures.Select(string.Empty, string.Empty, DataViewRowState.Added).Length > 0;
    if (!this.IsValid() || ((UltraGridBase) this.gridLocations).ActiveRow == null || ((UltraGridBase) this.gridLocations).ActiveRow.Band.Index == 0 && !flag)
    {
      e.Cancel = true;
    }
    else
    {
      dsPropertyExposureCapture.tblGenericPropertyExposuresRow propertyExposuresRow = !flag ? this.ds.tblGenericPropertyExposures.FindByExposureID((int) ((UltraGridBase) this.gridLocations).ActiveRow.Cells["ExposureID"].Value) : (dsPropertyExposureCapture.tblGenericPropertyExposuresRow) this.ds.tblGenericPropertyExposures.Select(string.Empty, string.Empty, DataViewRowState.Added)[0];
      try
      {
        propertyExposuresRow.CoverageID = Conversions.ToInteger(this.cboCoverages.Value);
      }
      catch (ConstraintException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.err.SetError((Control) this.cboCoverages, "All coverages must be unique on a location");
        e.Cancel = true;
        ProjectData.ClearProjectError();
        return;
      }
      this.err.SetError((Control) this.cboCoverages, string.Empty);
      propertyExposuresRow.Limit = Conversions.ToInteger(this.txtLimit.Value);
      if (!string.IsNullOrEmpty(this.comboDeductible.Text))
        propertyExposuresRow.Deductible = this.comboDeductible.Text;
      else if (!propertyExposuresRow.IsDeductibleNull())
        propertyExposuresRow.SetDeductibleNull();
      this.daExposure.Update((DataTable) this.ds.tblGenericPropertyExposures);
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
}

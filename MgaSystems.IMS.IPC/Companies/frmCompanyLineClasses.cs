// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmCompanyLineClasses
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic.CompilerServices;
using System;
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

[SecureResource("{259189E9-914E-4efb-ABE7-FE0FA3DAB890}", "Administer Company Classes", "Controls the ability to assign policy classes to individual company/lines.", "Policy Classes")]
public sealed class frmCompanyLineClasses : Form
{
  private IContainer components;
  private SqlConnection cn;
  private dsCompanyLineClasses ds;
  private SqlDataAdapter daCompanyClassCodes;
  private UltraDropDown UltraDropDown1;
  private UltraDropDown ddAccess;
  private SqlCommand SqlSelectCommand2;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  public const string LaunchFormSecurityID = "{259189E9-914E-4efb-ABE7-FE0FA3DAB890}";
  private readonly int _companyLineID;
  private bool _saved;
  private readonly SqlConnection _cn;

  private virtual UltraGrid ug
  {
    get => this._ug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler1 = new RowEventHandler(this.ug_AfterRowInsert);
      RowEventHandler rowEventHandler2 = new RowEventHandler(this.ug_AfterRowUpdate);
      UltraGrid ug1 = this._ug;
      if (ug1 != null)
      {
        ug1.AfterRowInsert -= rowEventHandler1;
        ug1.AfterRowUpdate -= rowEventHandler2;
      }
      this._ug = value;
      UltraGrid ug2 = this._ug;
      if (ug2 == null)
        return;
      ug2.AfterRowInsert += rowEventHandler1;
      ug2.AfterRowUpdate += rowEventHandler2;
    }
  }

  [field: AccessedThroughProperty("ddCodes")]
  private virtual UltraDropDown ddCodes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkCopyClasses
  {
    get => this._lnkCopyClasses;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopyClasses_LinkClicked);
      LinkLabel lnkCopyClasses1 = this._lnkCopyClasses;
      if (lnkCopyClasses1 != null)
        lnkCopyClasses1.LinkClicked -= clickedEventHandler;
      this._lnkCopyClasses = value;
      LinkLabel lnkCopyClasses2 = this._lnkCopyClasses;
      if (lnkCopyClasses2 == null)
        return;
      lnkCopyClasses2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkAddAll
  {
    get => this._lnkAddAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddAll_LinkClicked);
      LinkLabel lnkAddAll1 = this._lnkAddAll;
      if (lnkAddAll1 != null)
        lnkAddAll1.LinkClicked -= clickedEventHandler;
      this._lnkAddAll = value;
      LinkLabel lnkAddAll2 = this._lnkAddAll;
      if (lnkAddAll2 == null)
        return;
      lnkAddAll2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCompanyLineClasses));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblCompanyClassCodes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ClassCodeID", -1, (object) "ddCodes");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("DefaultGLExposureUnit", -1, (object) "UltraDropDown1");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Access", -1, (object) "ddAccess");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstGLExposureUnit", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ExposureUnit");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ExposureDescription");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("lstGLExposureUnittblCompanyClassCodes");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstGLExposureUnittblCompanyClassCodes", 0);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ClassCodeID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("DefaultGLExposureUnit");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Access");
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("Access", -1);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Access");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("AccessDescription");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("AccesstblCompanyClassCodes");
    UltraGridBand ultraGridBand5 = new UltraGridBand("AccesstblCompanyClassCodes", 0);
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("ClassCodeID");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("DefaultGLExposureUnit");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Access");
    Appearance appearance13 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("lstClassCodes", -1);
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ClassCodeID");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("ClassCode");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("ClassCodeDescription");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("lstClassCodestblCompanyClassCodes");
    UltraGridBand ultraGridBand7 = new UltraGridBand("lstClassCodestblCompanyClassCodes", 0);
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("ClassCodeID");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("DefaultGLExposureUnit");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("Access");
    Appearance appearance17 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    this.cn = new SqlConnection();
    this.daCompanyClassCodes = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.ds = new dsCompanyLineClasses();
    this.ug = new UltraGrid();
    this.UltraDropDown1 = new UltraDropDown();
    this.ddAccess = new UltraDropDown();
    this.ddCodes = new UltraDropDown();
    this.lnkAddAll = new LinkLabel();
    this.lnkCopyClasses = new LinkLabel();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ug).BeginInit();
    ((ISupportInitialize) this.UltraDropDown1).BeginInit();
    ((ISupportInitialize) this.ddAccess).BeginInit();
    ((ISupportInitialize) this.ddCodes).BeginInit();
    this.SuspendLayout();
    this.cn.ConnectionString = "workstation id=PSARNOWSKI2;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.daCompanyClassCodes.DeleteCommand = this.SqlDeleteCommand1;
    this.daCompanyClassCodes.InsertCommand = this.SqlInsertCommand1;
    this.daCompanyClassCodes.SelectCommand = this.SqlSelectCommand2;
    this.daCompanyClassCodes.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyClassCodes", new DataColumnMapping[4]
      {
        new DataColumnMapping("CompanyLineID", "CompanyLineID"),
        new DataColumnMapping("ClassCodeID", "ClassCodeID"),
        new DataColumnMapping("DefaultGLExposureUnit", "DefaultGLExposureUnit"),
        new DataColumnMapping("Access", "Access")
      })
    });
    this.daCompanyClassCodes.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblCompanyClassCodes WHERE (ClassCodeID = @Original_ClassCodeID) AND (CompanyLineID = @Original_CompanyLineID)";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_ClassCodeID", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ClassCodeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_CompanyLineID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = "INSERT INTO tblCompanyClassCodes(CompanyLineID, ClassCodeID, DefaultGLExposureUnit, Access) VALUES (@CompanyLineID, @ClassCodeID, @DefaultGLExposureUnit, @Access)";
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID"),
      new SqlParameter("@ClassCodeID", SqlDbType.SmallInt, 2, "ClassCodeID"),
      new SqlParameter("@DefaultGLExposureUnit", SqlDbType.VarChar, 1, "DefaultGLExposureUnit"),
      new SqlParameter("@Access", SqlDbType.VarChar, 1, "Access")
    });
    this.SqlSelectCommand2.CommandText = componentResourceManager.GetString("SqlSelectCommand2.CommandText");
    this.SqlSelectCommand2.Connection = this.cn;
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID"),
      new SqlParameter("@ClassCodeID", SqlDbType.SmallInt, 2, "ClassCodeID"),
      new SqlParameter("@DefaultGLExposureUnit", SqlDbType.VarChar, 1, "DefaultGLExposureUnit"),
      new SqlParameter("@Access", SqlDbType.VarChar, 1, "Access"),
      new SqlParameter("@Original_ClassCodeID", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ClassCodeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_CompanyLineID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineID", DataRowVersion.Original, (object) null)
    });
    this.ds.DataSetName = "dsCompanyLineClasses";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ug).DataSource = (object) this.ds.tblCompanyClassCodes;
    appearance1.BackColor = Color.WhiteSmoke;
    appearance1.ForeColor = Color.Black;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.WhiteSmoke;
    appearance2.BorderColor = Color.WhiteSmoke;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((UltraGridBase) this.ug).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Hidden = false;
    ((UltraGridBase) this.ug).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.AddButtonCaption = "New Class Code Setup";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Class";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Style = (ColumnStyle) 6;
    ultraGridColumn2.Width = 307;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "GL Exposure Unit";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Style = (ColumnStyle) 6;
    ultraGridColumn3.Width = 148;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Style = (ColumnStyle) 6;
    ultraGridColumn4.Width = 140;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    appearance4.BackColor = Color.Gainsboro;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.WhiteSmoke;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectorAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    appearance6.BackColor = Color.WhiteSmoke;
    appearance6.BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.Silver;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.ug).Location = new Point(0, 0);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(616, 352);
    ((Control) this.ug).TabIndex = 2;
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraDropDown1).DataSource = (object) this.ds.lstGLExposureUnit;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Appearance = (AppearanceBase) appearance8;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Width = 198;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ultraGridColumn8.Header.VisiblePosition = 0;
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn10.Header.VisiblePosition = 2;
    ultraGridColumn11.Header.VisiblePosition = 3;
    ultraGridBand3.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11
    });
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    appearance9.BackColor = Color.Gainsboro;
    appearance9.BackColor2 = Color.White;
    appearance9.BackGradientStyle = (GradientStyle) 2;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.WhiteSmoke;
    appearance10.BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.Silver;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraDropDownBase) this.UltraDropDown1).DisplayMember = "ExposureDescription";
    ((Control) this.UltraDropDown1).Location = new Point(48 /*0x30*/, 168);
    ((Control) this.UltraDropDown1).Name = "UltraDropDown1";
    ((Control) this.UltraDropDown1).Size = new Size(200, 64 /*0x40*/);
    ((Control) this.UltraDropDown1).TabIndex = 3;
    ((UltraControlBase) this.UltraDropDown1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraDropDown1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.UltraDropDown1).ValueMember = "ExposureUnit";
    ((Control) this.UltraDropDown1).Visible = false;
    ((UltraGridBase) this.ddAccess).DataSource = (object) this.ds.Access;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddAccess).DisplayLayout.Appearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ddAccess).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn12.Header.VisiblePosition = 0;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn13.Header.VisiblePosition = 1;
    ultraGridColumn13.Width = 230;
    ultraGridColumn14.Header.VisiblePosition = 2;
    ultraGridBand4.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    ultraGridColumn15.Header.VisiblePosition = 0;
    ultraGridColumn16.Header.VisiblePosition = 1;
    ultraGridColumn17.Header.VisiblePosition = 2;
    ultraGridColumn18.Header.VisiblePosition = 3;
    ultraGridBand5.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18
    });
    ((UltraGridBase) this.ddAccess).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ddAccess).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    appearance13.BackColor = Color.Gainsboro;
    appearance13.BackColor2 = Color.White;
    appearance13.BackGradientStyle = (GradientStyle) 2;
    ((UltraGridBase) this.ddAccess).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.WhiteSmoke;
    appearance14.BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance14;
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.Silver;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ddAccess).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((UltraDropDownBase) this.ddAccess).DisplayMember = "AccessDescription";
    ((Control) this.ddAccess).Location = new Point(112 /*0x70*/, 256 /*0x0100*/);
    ((Control) this.ddAccess).Name = "ddAccess";
    ((Control) this.ddAccess).Size = new Size(232, 64 /*0x40*/);
    ((Control) this.ddAccess).TabIndex = 4;
    ((Control) this.ddAccess).Text = "UltraDropDown2";
    ((UltraControlBase) this.ddAccess).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ddAccess).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ddAccess).ValueMember = "Access";
    ((Control) this.ddAccess).Visible = false;
    ((UltraControlBase) this.ddCodes).Cursor = Cursors.Default;
    ((UltraGridBase) this.ddCodes).DataSource = (object) this.ds.lstClassCodes;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddCodes).DisplayLayout.Appearance = (AppearanceBase) appearance16;
    ultraGridColumn19.Header.VisiblePosition = 0;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 62;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Class Code";
    ultraGridColumn20.Header.VisiblePosition = 2;
    ultraGridColumn20.Width = 116;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Description";
    ultraGridColumn21.Header.VisiblePosition = 1;
    ultraGridColumn21.Width = 154;
    ultraGridColumn22.Header.VisiblePosition = 3;
    ultraGridBand6.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22
    });
    ultraGridColumn23.Header.VisiblePosition = 0;
    ultraGridColumn24.Header.VisiblePosition = 1;
    ultraGridColumn25.Header.VisiblePosition = 2;
    ultraGridColumn26.Header.VisiblePosition = 3;
    ultraGridBand7.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26
    });
    ((UltraGridBase) this.ddCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.ddCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    appearance17.BackColor = Color.Gainsboro;
    appearance17.BackColor2 = Color.White;
    appearance17.BackGradientStyle = (GradientStyle) 2;
    ((UltraGridBase) this.ddCodes).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = Color.WhiteSmoke;
    appearance18.BorderColor = Color.Silver;
    scrollBarLook4.ButtonAppearance = (AppearanceBase) appearance18;
    appearance19.BackColor = Color.White;
    appearance19.BorderColor = Color.Silver;
    scrollBarLook4.TrackAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.ddCodes).DisplayLayout.ScrollBarLook = scrollBarLook4;
    ((UltraDropDownBase) this.ddCodes).DisplayMember = "ClassCodeDescription";
    ((Control) this.ddCodes).Location = new Point(88, 72);
    ((Control) this.ddCodes).Name = "ddCodes";
    ((Control) this.ddCodes).Size = new Size(272, 64 /*0x40*/);
    ((Control) this.ddCodes).TabIndex = 5;
    ((UltraControlBase) this.ddCodes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ddCodes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ddCodes).ValueMember = "ClassCodeID";
    ((Control) this.ddCodes).Visible = false;
    this.lnkAddAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkAddAll.AutoSize = true;
    this.lnkAddAll.Location = new Point(504, 360);
    this.lnkAddAll.Name = "lnkAddAll";
    this.lnkAddAll.Size = new Size(101, 13);
    this.lnkAddAll.TabIndex = 6;
    this.lnkAddAll.TabStop = true;
    this.lnkAddAll.Text = "Add All Class Codes";
    this.lnkCopyClasses.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkCopyClasses.AutoSize = true;
    this.lnkCopyClasses.Location = new Point(12, 360);
    this.lnkCopyClasses.Name = "lnkCopyClasses";
    this.lnkCopyClasses.Size = new Size(148, 13);
    this.lnkCopyClasses.TabIndex = 7;
    this.lnkCopyClasses.TabStop = true;
    this.lnkCopyClasses.Text = "Copy Company / Line Classes";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(616, 382);
    this.Controls.Add((Control) this.lnkCopyClasses);
    this.Controls.Add((Control) this.lnkAddAll);
    this.Controls.Add((Control) this.ddCodes);
    this.Controls.Add((Control) this.ddAccess);
    this.Controls.Add((Control) this.UltraDropDown1);
    this.Controls.Add((Control) this.ug);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmCompanyLineClasses);
    this.Text = "Administration - Company Lines / Classes";
    this.ds.EndInit();
    ((ISupportInitialize) this.ug).EndInit();
    ((ISupportInitialize) this.UltraDropDown1).EndInit();
    ((ISupportInitialize) this.ddAccess).EndInit();
    ((ISupportInitialize) this.ddCodes).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public bool Saved => this._saved;

  public static void ShowForm(CompanyLine cl)
  {
    if (SecurityManager.Instance.AssertPermission("{259189E9-914E-4efb-ABE7-FE0FA3DAB890}"))
    {
      using (FormSettings.ShowFormDialog(typeof (frmCompanyLineClasses), (object) cl.CompanyLineID))
        ;
    }
    else
    {
      int num = (int) MessageBox.Show("You do not have permission to access this form.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblCompanyClassCodes.TableName];
  }

  public frmCompanyLineClasses(int companyLineID)
  {
    this.Load += new EventHandler(this.frmCompanyLineClasses_Load);
    this.Closed += new EventHandler(this.frmCompanyLineClasses_Closed);
    if (!SecurityManager.Instance.AssertPermission("{259189E9-914E-4efb-ABE7-FE0FA3DAB890}"))
      throw new InvalidPermissionException();
    this.InitializeComponent();
    this._companyLineID = companyLineID;
    this._cn = DefaultDatabase.CreateConnection();
  }

  private void frmCompanyLineClasses_Load(object sender, EventArgs e)
  {
    SqlDataAdapter companyClassCodes = this.daCompanyClassCodes;
    companyClassCodes.SelectCommand.Connection = this._cn;
    companyClassCodes.InsertCommand.Connection = this._cn;
    companyClassCodes.DeleteCommand.Connection = this._cn;
    companyClassCodes.UpdateCommand.Connection = this._cn;
    dsCompanyLineClasses.AccessDataTable access = this.ds.Access;
    access.AddAccessRow("A", "Accepted");
    access.AddAccessRow("R", "Restricted");
    access.AddAccessRow("P", "Prohibited");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstClassCodes"
    }, CommandType.Text, "SELECT ClassCode, ClassCodeDescription, ClassCodeID FROM lstClassCodes ORDER BY ClassCodeDescription");
    this.ds.lstGLExposureUnit.AddlstGLExposureUnitRow(string.Empty, string.Empty);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstGLExposureUnit"
    }, CommandType.Text, "SELECT ExposureUnit, ExposureDescription FROM lstGLExposureUnit ORDER BY ExposureDescription");
    this.daCompanyClassCodes.SelectCommand.Parameters["@CompanyLineID"].Value = (object) this._companyLineID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daCompanyClassCodes, (DataTable) this.ds.tblCompanyClassCodes);
  }

  private void frmCompanyLineClasses_Closed(object sender, EventArgs e)
  {
    try
    {
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
      {
        this.SaveData(RuntimeHelpers.GetObjectValue(obj), args);
        args.Transaction.Commit();
      }));
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void SaveData(object sender, ExecuteTransactionEventArgs e)
  {
    ((UltraGridBase) this.ug).UpdateData();
    if (!this.ds.HasChanges())
      return;
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daCompanyClassCodes, (DataTable) this.ds.tblCompanyClassCodes);
    this._saved = true;
  }

  private void ug_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["CompanyLineID"].Value = (object) this._companyLineID;
  }

  private void ug_AfterRowUpdate(object sender, RowEventArgs e)
  {
    if (e.Row.Cells["DefaultGLExposureUnit"].Value == DBNull.Value || e.Row.Cells["DefaultGLExposureUnit"].Value.ToString().Length != 0)
      return;
    e.Row.Cells["DefaultGLExposureUnit"].Value = (object) DBNull.Value;
  }

  private void lnkAddAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      foreach (dsCompanyLineClasses.lstClassCodesRow lstClassCode in (TypedTableBase<dsCompanyLineClasses.lstClassCodesRow>) this.ds.lstClassCodes)
      {
        if (this.ds.tblCompanyClassCodes.FindByCompanyLineIDClassCodeID(this._companyLineID, lstClassCode.ClassCodeID) == null)
        {
          dsCompanyLineClasses.tblCompanyClassCodesRow row = this.ds.tblCompanyClassCodes.NewtblCompanyClassCodesRow();
          row.Access = "A";
          row.ClassCodeID = lstClassCode.ClassCodeID;
          row.CompanyLineID = this._companyLineID;
          this.ds.tblCompanyClassCodes.AddtblCompanyClassCodesRow(row);
        }
      }
    }
    finally
    {
      IEnumerator<dsCompanyLineClasses.lstClassCodesRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void lnkCopyClasses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormCopyCompanyLineClasses companyLineClasses = (FormCopyCompanyLineClasses) null;
    try
    {
      companyLineClasses = new FormCopyCompanyLineClasses(this._companyLineID);
      int num = (int) companyLineClasses.ShowDialog();
      companyLineClasses.TopMost = true;
      companyLineClasses.StartPosition = FormStartPosition.CenterScreen;
    }
    finally
    {
      companyLineClasses?.Dispose();
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._cn != null)
        this._cn.Dispose();
    }
    base.Dispose(disposing);
  }

  private class PolicyClassListItem
  {
    private readonly string _classCode;
    private readonly string _className;

    public PolicyClassListItem(string classCode, string className)
    {
      this._classCode = classCode;
      this._className = className;
    }

    public string ClassCode => this._classCode;

    public string ClassName => this._className;

    public override string ToString() => this._className;
  }
}

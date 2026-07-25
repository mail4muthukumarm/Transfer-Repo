// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.frmAdminInspectionCodes
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common.Functions;
using MGASystems.Data;
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
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmAdminInspectionCodes : Form
{
  private IContainer components;
  private MGASimpleComboBox cboClientOffices;
  private MGASimpleComboBox cboCompany;
  private MGASimpleComboBox cboLine;
  private MGATextBox txtLine;
  private MGASimpleComboBox cboInspectionCompany;
  private SqlCommand SqlSelectCommand2;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private SqlDataAdapter daCodes;
  private UltraDropDown ddInspectionCompanies;
  private UltraDropDown ddOffices;
  private UltraDropDown ddCompanies;
  private UltraDropDown ddLines;
  private readonly SqlConnection _cn;

  [field: AccessedThroughProperty("err")]
  protected virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsAdminInspectionCodes ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid ug
  {
    get => this._ug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ug_AfterRowActivate);
      UltraGrid ug1 = this._ug;
      if (ug1 != null)
        ug1.AfterRowActivate -= eventHandler;
      this._ug = value;
      UltraGrid ug2 = this._ug;
      if (ug2 == null)
        return;
      ug2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("gb")]
  protected virtual UltraGroupBox gb { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_UIStateChanged);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedNew);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_ClickedCancel);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.UIStateChanged -= eventHandler1;
        dbSave1.ClickedNew -= eventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler2;
        dbSave1.ClickedCancel -= eventHandler3;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.UIStateChanged += eventHandler1;
      dbSave2.ClickedNew += eventHandler2;
      dbSave2.ClickingSave += cancelEventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler2;
      dbSave2.ClickedCancel += eventHandler3;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblInspectionClientCodes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("InspectionCompanyID", -1, (object) "ddInspectionCompanies");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("OfficeID", -1, (object) "ddOffices");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CompanyID", -1, (object) "ddCompanies");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("LineID", -1, (object) "ddLines");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ClientCode");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdminInspectionCodes));
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblInspectionCompanies", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("PayeeID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("PayeeName");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("tblInspectionCompanies_tblInspectionClientCodes");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblInspectionCompanies_tblInspectionClientCodes", 0);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("InspectionCompanyID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("CompanyID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("LineID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ClientCode");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblClientOffices", -1);
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("tblClientOffices_tblInspectionClientCodes");
    UltraGridBand ultraGridBand5 = new UltraGridBand("tblClientOffices_tblInspectionClientCodes", 0);
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("InspectionCompanyID");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("CompanyID");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("LineID");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("ClientCode");
    UltraGridBand ultraGridBand6 = new UltraGridBand("tblCompanies", -1);
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("CompanyID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("CompanyName");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("tblCompanies_tblInspectionClientCodes");
    UltraGridBand ultraGridBand7 = new UltraGridBand("tblCompanies_tblInspectionClientCodes", 0);
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("InspectionCompanyID");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("CompanyID");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("LineID");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("ClientCode");
    UltraGridBand ultraGridBand8 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("LineID");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("lstLines_tblInspectionClientCodes");
    UltraGridBand ultraGridBand9 = new UltraGridBand("lstLines_tblInspectionClientCodes", 0);
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("InspectionCompanyID");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("CompanyID");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("LineID");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("ClientCode");
    this.ug = new UltraGrid();
    this.ds = new dsAdminInspectionCodes();
    this.gb = new UltraGroupBox();
    this.cboInspectionCompany = new MGASimpleComboBox();
    this.txtLine = new MGATextBox();
    this.cboLine = new MGASimpleComboBox();
    this.cboCompany = new MGASimpleComboBox();
    this.cboClientOffices = new MGASimpleComboBox();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.err = new ErrorProvider(this.components);
    this.daCodes = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.ddInspectionCompanies = new UltraDropDown();
    this.ddOffices = new UltraDropDown();
    this.ddCompanies = new UltraDropDown();
    this.ddLines = new UltraDropDown();
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    Label label4 = new Label();
    Label label5 = new Label();
    ((ISupportInitialize) this.ug).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.gb).BeginInit();
    ((Control) this.gb).SuspendLayout();
    ((ISupportInitialize) this.cboInspectionCompany).BeginInit();
    ((ISupportInitialize) this.txtLine).BeginInit();
    ((ISupportInitialize) this.cboLine).BeginInit();
    ((ISupportInitialize) this.cboCompany).BeginInit();
    ((ISupportInitialize) this.cboClientOffices).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ddInspectionCompanies).BeginInit();
    ((ISupportInitialize) this.ddOffices).BeginInit();
    ((ISupportInitialize) this.ddCompanies).BeginInit();
    ((ISupportInitialize) this.ddLines).BeginInit();
    this.SuspendLayout();
    label1.AutoSize = true;
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(7, 18);
    label1.Name = "Label5";
    label1.Size = new Size(77, 13);
    label1.TabIndex = 8;
    label1.Text = "Inspection Co:";
    label1.TextAlign = ContentAlignment.MiddleRight;
    label2.AutoSize = true;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(19, 138);
    label2.Name = "Label4";
    label2.Size = new Size(66, 13);
    label2.TabIndex = 6;
    label2.Text = "Client Code:";
    label2.TextAlign = ContentAlignment.MiddleRight;
    label3.AutoSize = true;
    label3.BackColor = Color.Transparent;
    label3.Location = new Point(55, 108);
    label3.Name = "Label3";
    label3.Size = new Size(30, 13);
    label3.TabIndex = 4;
    label3.Text = "Line:";
    label3.TextAlign = ContentAlignment.MiddleRight;
    label4.AutoSize = true;
    label4.BackColor = Color.Transparent;
    label4.Location = new Point(29, 78);
    label4.Name = "Label2";
    label4.Size = new Size(56, 13);
    label4.TabIndex = 2;
    label4.Text = "Company:";
    label4.TextAlign = ContentAlignment.MiddleRight;
    label5.AutoSize = true;
    label5.BackColor = Color.Transparent;
    label5.Location = new Point(15, 48 /*0x30*/);
    label5.Name = "Label1";
    label5.Size = new Size(70, 13);
    label5.TabIndex = 0;
    label5.Text = "Client Office:";
    label5.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ug).Cursor = Cursors.Default;
    ((UltraGridBase) this.ug).DataSource = (object) this.ds.tblInspectionClientCodes;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 85;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Inspection Company";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 205;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Office";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 97;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 122;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 94;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Client Code";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 160 /*0xA0*/;
    ultraGridBand1.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance4.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance5.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance7.BackColor = Color.Transparent;
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ug).Location = new Point(8, 8);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(680, 144 /*0x90*/);
    ((Control) this.ug).TabIndex = 0;
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAdminInspectionCodes";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.gb).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance8.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gb.ContentAreaAppearance = (AppearanceBase) appearance8;
    ((Control) this.gb).Controls.Add((Control) this.cboInspectionCompany);
    ((Control) this.gb).Controls.Add((Control) label1);
    ((Control) this.gb).Controls.Add((Control) this.txtLine);
    ((Control) this.gb).Controls.Add((Control) label2);
    ((Control) this.gb).Controls.Add((Control) this.cboLine);
    ((Control) this.gb).Controls.Add((Control) label3);
    ((Control) this.gb).Controls.Add((Control) this.cboCompany);
    ((Control) this.gb).Controls.Add((Control) label4);
    ((Control) this.gb).Controls.Add((Control) this.cboClientOffices);
    ((Control) this.gb).Controls.Add((Control) label5);
    ((Control) this.gb).Enabled = false;
    ((Control) this.gb).Location = new Point(8, 160 /*0xA0*/);
    ((Control) this.gb).Name = "gb";
    ((Control) this.gb).Size = new Size(504, 168);
    ((Control) this.gb).TabIndex = 1;
    this.cboInspectionCompany.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboInspectionCompany).DataBindings.Add(new Binding("Value", (object) this.ds, "tblInspectionClientCodes.InspectionCompanyID", true));
    ((UltraGridBase) this.cboInspectionCompany).DataSource = (object) this.ds.tblInspectionCompanies;
    ((UltraDropDownBase) this.cboInspectionCompany).DisplayMember = "PayeeName";
    this.cboInspectionCompany.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboInspectionCompany).Location = new Point(96 /*0x60*/, 16 /*0x10*/);
    this.cboInspectionCompany.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboInspectionCompany).Name = "cboInspectionCompany";
    ((Control) this.cboInspectionCompany).Size = new Size(352, 21);
    ((Control) this.cboInspectionCompany).TabIndex = 9;
    ((UltraControlBase) this.cboInspectionCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInspectionCompany).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInspectionCompany).ValueMember = "PayeeID";
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLine).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.txtLine).BackColor = Color.White;
    ((Control) this.txtLine).DataBindings.Add(new Binding("Text", (object) this.ds, "tblInspectionClientCodes.ClientCode", true));
    ((Control) this.txtLine).Location = new Point(96 /*0x60*/, 136);
    this.txtLine.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLine).Name = "txtLine";
    ((Control) this.txtLine).Size = new Size(100, 20);
    ((Control) this.txtLine).TabIndex = 7;
    ((UltraControlBase) this.txtLine).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLine).UseOsThemes = (DefaultableBoolean) 2;
    this.cboLine.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLine).DataBindings.Add(new Binding("Value", (object) this.ds, "tblInspectionClientCodes.LineID", true));
    ((UltraGridBase) this.cboLine).DataSource = (object) this.ds.lstLines;
    ((UltraDropDownBase) this.cboLine).DisplayMember = "LineName";
    this.cboLine.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboLine).Location = new Point(96 /*0x60*/, 106);
    this.cboLine.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLine).Name = "cboLine";
    ((Control) this.cboLine).Size = new Size(352, 21);
    ((Control) this.cboLine).TabIndex = 5;
    ((UltraControlBase) this.cboLine).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLine).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLine).ValueMember = "LineID";
    this.cboCompany.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboCompany).DataBindings.Add(new Binding("Value", (object) this.ds, "tblInspectionClientCodes.CompanyID", true));
    ((UltraGridBase) this.cboCompany).DataSource = (object) this.ds.tblCompanies;
    ((UltraDropDownBase) this.cboCompany).DisplayMember = "CompanyName";
    this.cboCompany.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboCompany).Location = new Point(96 /*0x60*/, 76);
    this.cboCompany.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompany).Name = "cboCompany";
    ((Control) this.cboCompany).Size = new Size(352, 21);
    ((Control) this.cboCompany).TabIndex = 3;
    ((UltraControlBase) this.cboCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompany).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompany).ValueMember = "CompanyID";
    this.cboClientOffices.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboClientOffices).DataBindings.Add(new Binding("Value", (object) this.ds, "tblInspectionClientCodes.OfficeID", true));
    ((UltraGridBase) this.cboClientOffices).DataSource = (object) this.ds.tblClientOffices;
    ((UltraDropDownBase) this.cboClientOffices).DisplayMember = "Location";
    this.cboClientOffices.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboClientOffices).Location = new Point(96 /*0x60*/, 46);
    this.cboClientOffices.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboClientOffices).Name = "cboClientOffices";
    ((Control) this.cboClientOffices).Size = new Size(352, 21);
    ((Control) this.cboClientOffices).TabIndex = 1;
    ((UltraControlBase) this.cboClientOffices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboClientOffices).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboClientOffices).ValueMember = "OfficeID";
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(400, 336);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.daCodes.DeleteCommand = this.SqlDeleteCommand1;
    this.daCodes.InsertCommand = this.SqlInsertCommand1;
    this.daCodes.SelectCommand = this.SqlSelectCommand2;
    this.daCodes.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblInspectionClientCodes", new DataColumnMapping[6]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("InspectionCompanyID", "InspectionCompanyID"),
        new DataColumnMapping("OfficeID", "OfficeID"),
        new DataColumnMapping("CompanyID", "CompanyID"),
        new DataColumnMapping("LineID", "LineID"),
        new DataColumnMapping("ClientCode", "ClientCode")
      })
    });
    this.daCodes.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = componentResourceManager.GetString("SqlDeleteCommand1.CommandText");
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ClientCode", SqlDbType.VarChar, 15, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ClientCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_CompanyID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_InspectionCompanyID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InspectionCompanyID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_LineID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_OfficeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OfficeID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@InspectionCompanyID", SqlDbType.Int, 4, "InspectionCompanyID"),
      new SqlParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      new SqlParameter("@CompanyID", SqlDbType.Int, 4, "CompanyID"),
      new SqlParameter("@LineID", SqlDbType.Int, 4, "LineID"),
      new SqlParameter("@ClientCode", SqlDbType.VarChar, 15, "ClientCode")
    });
    this.SqlSelectCommand2.CommandText = "SELECT ID, InspectionCompanyID, OfficeID, CompanyID, LineID, ClientCode FROM tblInspectionClientCodes";
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[12]
    {
      new SqlParameter("@InspectionCompanyID", SqlDbType.Int, 4, "InspectionCompanyID"),
      new SqlParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      new SqlParameter("@CompanyID", SqlDbType.Int, 4, "CompanyID"),
      new SqlParameter("@LineID", SqlDbType.Int, 4, "LineID"),
      new SqlParameter("@ClientCode", SqlDbType.VarChar, 15, "ClientCode"),
      new SqlParameter("@Original_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ClientCode", SqlDbType.VarChar, 15, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ClientCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_CompanyID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_InspectionCompanyID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InspectionCompanyID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_LineID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_OfficeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OfficeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    ((UltraGridBase) this.ddInspectionCompanies).DataSource = (object) this.ds.tblInspectionCompanies;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 2;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 0;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 1;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 2;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 3;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 4;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 5;
    ultraGridBand3.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15
    });
    ((UltraGridBase) this.ddInspectionCompanies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddInspectionCompanies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddInspectionCompanies).DisplayMember = "PayeeName";
    ((Control) this.ddInspectionCompanies).Location = new Point(56, 336);
    ((Control) this.ddInspectionCompanies).Name = "ddInspectionCompanies";
    ((Control) this.ddInspectionCompanies).Size = new Size(168, 40);
    ((Control) this.ddInspectionCompanies).TabIndex = 3;
    ((UltraDropDownBase) this.ddInspectionCompanies).ValueMember = "PayeeID";
    ((Control) this.ddInspectionCompanies).Visible = false;
    ((UltraGridBase) this.ddOffices).DataSource = (object) this.ds.tblClientOffices;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 0;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 1;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 2;
    ultraGridBand4.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18
    });
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 0;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 1;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 2;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 3;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 4;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 5;
    ultraGridBand5.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24
    });
    ((UltraGridBase) this.ddOffices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ddOffices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraDropDownBase) this.ddOffices).DisplayMember = "Location";
    ((Control) this.ddOffices).Location = new Point(160 /*0xA0*/, 336);
    ((Control) this.ddOffices).Name = "ddOffices";
    ((Control) this.ddOffices).Size = new Size(168, 40);
    ((Control) this.ddOffices).TabIndex = 4;
    ((UltraDropDownBase) this.ddOffices).ValueMember = "OfficeID";
    ((Control) this.ddOffices).Visible = false;
    ((UltraGridBase) this.ddCompanies).DataSource = (object) this.ds.tblCompanies;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 0;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 1;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 2;
    ultraGridBand6.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27
    });
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 0;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 1;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 2;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 3;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 4;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 5;
    ultraGridBand7.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33
    });
    ((UltraGridBase) this.ddCompanies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.ddCompanies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    ((UltraDropDownBase) this.ddCompanies).DisplayMember = "CompanyName";
    ((Control) this.ddCompanies).Location = new Point(8, 336);
    ((Control) this.ddCompanies).Name = "ddCompanies";
    ((Control) this.ddCompanies).Size = new Size(168, 40);
    ((Control) this.ddCompanies).TabIndex = 5;
    ((UltraDropDownBase) this.ddCompanies).ValueMember = "CompanyID";
    ((Control) this.ddCompanies).Visible = false;
    ((UltraGridBase) this.ddLines).DataSource = (object) this.ds.lstLines;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 0;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 1;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 2;
    ultraGridBand8.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36
    });
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 0;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 1;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 2;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 3;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 4;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 5;
    ultraGridBand9.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42
    });
    ((UltraGridBase) this.ddLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand8);
    ((UltraGridBase) this.ddLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand9);
    ((UltraDropDownBase) this.ddLines).DisplayMember = "LineName";
    ((Control) this.ddLines).Location = new Point(216, 336);
    ((Control) this.ddLines).Name = "ddLines";
    ((Control) this.ddLines).Size = new Size(168, 40);
    ((Control) this.ddLines).TabIndex = 6;
    ((UltraDropDownBase) this.ddLines).ValueMember = "LineID";
    ((Control) this.ddLines).Visible = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(696, 382);
    this.Controls.Add((Control) this.ddLines);
    this.Controls.Add((Control) this.ddCompanies);
    this.Controls.Add((Control) this.ddOffices);
    this.Controls.Add((Control) this.ddInspectionCompanies);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.gb);
    this.Controls.Add((Control) this.ug);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmAdminInspectionCodes);
    this.Text = "Administer Inspection Client Codes";
    ((ISupportInitialize) this.ug).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.gb).EndInit();
    ((Control) this.gb).ResumeLayout(false);
    ((Control) this.gb).PerformLayout();
    ((ISupportInitialize) this.cboInspectionCompany).EndInit();
    ((ISupportInitialize) this.txtLine).EndInit();
    ((ISupportInitialize) this.cboLine).EndInit();
    ((ISupportInitialize) this.cboCompany).EndInit();
    ((ISupportInitialize) this.cboClientOffices).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ddInspectionCompanies).EndInit();
    ((ISupportInitialize) this.ddOffices).EndInit();
    ((ISupportInitialize) this.ddCompanies).EndInit();
    ((ISupportInitialize) this.ddLines).EndInit();
    this.ResumeLayout(false);
  }

  public frmAdminInspectionCodes()
  {
    this.Load += new EventHandler(this.frmAdminInspectionCodes_Load);
    this.InitializeComponent();
    this._cn = DefaultDatabase.CreateConnection();
  }

  [field: AccessedThroughProperty("bmb")]
  private virtual BindingManagerBase bmb { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void frmAdminInspectionCodes_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    SqlDataAdapter daCodes = this.daCodes;
    daCodes.SelectCommand.Connection = this._cn;
    daCodes.DeleteCommand.Connection = this._cn;
    daCodes.InsertCommand.Connection = this._cn;
    daCodes.UpdateCommand.Connection = this._cn;
    this.bmb = this.BindingContext[(object) this.ds, this.ds.tblInspectionClientCodes.TableName];
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[4]
    {
      "tblInspectionCompanies",
      "tblClientOffices",
      "tblCompanies",
      "lstLines"
    }, "InspectionClientCodesData");
    this.LoadClientListTables();
    this.daCodes.Fill((DataTable) this.ds.tblInspectionClientCodes);
    this.AfterFormItemsLoad();
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.ug).Enabled = this.dbSave.UIState != UIState.Editing;
    ((Control) this.gb).Enabled = this.dbSave.UIState == UIState.Editing;
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    this.ds.tblInspectionClientCodes.AddtblInspectionClientCodesRow(this.ds.tblInspectionClientCodes.NewtblInspectionClientCodesRow());
    this.bmb.Position = this.ds.tblInspectionClientCodes.Count - 1;
    this.ClientClickedNew();
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.IsValidForm())
    {
      this.bmb.EndCurrentEdit();
      int position;
      try
      {
        position = this.bmb.Position;
        this.daCodes.Update((DataTable) this.ds.tblInspectionClientCodes);
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        e.Cancel = true;
        ProjectData.ClearProjectError();
        return;
      }
      this.ClientClickedSave(position);
    }
    else
      e.Cancel = true;
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
    {
      e.Cancel = true;
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to delete this setup?", "Delete Setup?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      int id = this.ds.tblInspectionClientCodes[this.bmb.Position].ID;
      this.ds.tblInspectionClientCodes[this.bmb.Position].Delete();
      try
      {
        this.daCodes.Update((DataTable) this.ds.tblInspectionClientCodes);
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        e.Cancel = true;
        ProjectData.ClearProjectError();
        return;
      }
      this.ClientClickedDelete(id);
    }
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.tblInspectionClientCodes.RejectChanges();
    this.dbSave.UIState = this.ds.tblInspectionClientCodes.Count <= 0 ? UIState.NoRecordsNotEditing : UIState.HasRecordsNotEditing;
    this.ClientClickedCancel();
  }

  protected virtual void AfterFormItemsLoad()
  {
  }

  protected virtual void LoadClientListTables()
  {
  }

  protected virtual void ClientClickedNew()
  {
  }

  protected virtual void ClientClickedCancel()
  {
  }

  protected virtual void ClientClickedSave(int RowPosition)
  {
  }

  protected virtual void ClientClickedDelete(int RowPositionID)
  {
  }

  protected virtual void ClientRowPositionChange(int rowPositionID)
  {
  }

  private bool IsValidForm()
  {
    bool flag = true;
    try
    {
      foreach (Control control in ((Control) this.gb).Controls)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Text, string.Empty, false) == 0)
        {
          this.err.SetError(control, "Please select a value");
          flag = false;
        }
        else
          this.err.SetError(control, string.Empty);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (flag && this.DuplicateRecord())
    {
      flag = false;
      int num = (int) MessageBox.Show("You are attempting to administer duplicate inspection.\n\nMake sure that a similar record does not exist before proceeding.", "Duplicate Record Exists", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    return flag;
  }

  private bool DuplicateRecord()
  {
    bool flag = false;
    if (this.bmb.Position != -1)
    {
      int companyId = this.ds.tblInspectionClientCodes[this.bmb.Position].CompanyID;
      int inspectionCompanyId = this.ds.tblInspectionClientCodes[this.bmb.Position].InspectionCompanyID;
      int lineId = this.ds.tblInspectionClientCodes[this.bmb.Position].LineID;
      int officeId = this.ds.tblInspectionClientCodes[this.bmb.Position].OfficeID;
      int num = 0;
      try
      {
        foreach (dsAdminInspectionCodes.tblInspectionClientCodesRow row in this.ds.tblInspectionClientCodes.Rows)
        {
          if (num != this.bmb.Position && companyId == row.CompanyID && inspectionCompanyId == row.InspectionCompanyID && lineId == row.LineID && officeId == row.OfficeID)
          {
            flag = true;
            break;
          }
          ++num;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    return flag;
  }

  private void ug_AfterRowActivate(object sender, EventArgs e)
  {
    Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ug).ActiveRow.Cells["ID"].Value), "ID", (DataTable) this.ds.tblInspectionClientCodes, this.bmb);
    if (this.dbSave.UIState != UIState.Editing)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    this.ClientRowPositionChange(Conversions.ToInteger(((UltraGridBase) this.ug).ActiveRow.Cells["ID"].Value));
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
}

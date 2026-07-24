// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.formFiscalConfiguration
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

[SecureResource("{C61CFA14-8F4A-4cbe-95F3-9773FA38F96F}", "Fiscal Configuration Access Rights", "Determines whether or not a user is allowed access to the fiscal year configuration screen.", "Accounting")]
public class formFiscalConfiguration : Form
{
  private Label label1;
  private SqlDataAdapter daGetOfficeLocations;
  private SqlCommand sqlSelectCommand1;
  private SqlConnection FormDataConnection;
  private Label label2;
  private MGAButton buttonCancel;
  private MGAButton buttonSave;
  private UltraGrid gridCurrentConfigurations;
  private Label labelNoConfigurations;
  private SqlDataAdapter daGetFiscalConfigurations;
  private SqlCommand sqlSelectCommand2;
  private Label labelDay;
  private MGASimpleComboBox comboOfficeLocation;
  private MGASimpleComboBox comboMonth;
  private MGASimpleComboBox comboDay;
  private UltraExplorerBar ultraExplorerBar1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
  private dsOfficeLocations dsOfficeLocations1;
  private dsFiscalConfigurations dsFiscalConfigurations1;
  private Label label3;
  private MGASimpleComboBox comboFiscalYearStart;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _formFiscalConfiguration_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formFiscalConfiguration_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formFiscalConfiguration_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _formFiscalConfiguration_Toolbars_Dock_Area_Bottom;
  private IContainer components;

  public formFiscalConfiguration()
  {
    this.InitializeComponent();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.LoadOfficeLocations();
    this.LoadMonthsCombo();
    this.LoadCurrentFiscalConfigurations();
    this.LoadYearAddition();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("Settings", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("FiscalSettingId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("GLCompanyId");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Current");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup3 = new UltraExplorerBarGroup();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formFiscalConfiguration));
    Appearance appearance9 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("ContextToolbar");
    ButtonTool buttonTool1 = new ButtonTool("DELETE");
    Appearance appearance10 = new Appearance();
    PopupMenuTool popupMenuTool = new PopupMenuTool("ContextMenu");
    ButtonTool buttonTool2 = new ButtonTool("DELETE");
    this.ultraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.label3 = new Label();
    this.comboFiscalYearStart = new MGASimpleComboBox();
    this.comboDay = new MGASimpleComboBox();
    this.label1 = new Label();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.dsOfficeLocations1 = new dsOfficeLocations();
    this.label2 = new Label();
    this.labelDay = new Label();
    this.comboMonth = new MGASimpleComboBox();
    this.ultraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.labelNoConfigurations = new Label();
    this.gridCurrentConfigurations = new UltraGrid();
    this.dsFiscalConfigurations1 = new dsFiscalConfigurations();
    this.ultraExplorerBarContainerControl3 = new UltraExplorerBarContainerControl();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.daGetOfficeLocations = new SqlDataAdapter();
    this.sqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.daGetFiscalConfigurations = new SqlDataAdapter();
    this.sqlSelectCommand2 = new SqlCommand();
    this.ultraExplorerBar1 = new UltraExplorerBar();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._formFiscalConfiguration_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formFiscalConfiguration_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formFiscalConfiguration_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formFiscalConfiguration_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((Control) this.ultraExplorerBarContainerControl1).SuspendLayout();
    ((ISupportInitialize) this.comboFiscalYearStart).BeginInit();
    ((ISupportInitialize) this.comboDay).BeginInit();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    this.dsOfficeLocations1.BeginInit();
    ((ISupportInitialize) this.comboMonth).BeginInit();
    ((Control) this.ultraExplorerBarContainerControl2).SuspendLayout();
    ((ISupportInitialize) this.gridCurrentConfigurations).BeginInit();
    this.dsFiscalConfigurations1.BeginInit();
    ((Control) this.ultraExplorerBarContainerControl3).SuspendLayout();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.ultraExplorerBar1).BeginInit();
    ((Control) this.ultraExplorerBar1).SuspendLayout();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.label3);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.comboFiscalYearStart);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.comboDay);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.label1);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.comboOfficeLocation);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.label2);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.labelDay);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.comboMonth);
    ((Control) this.ultraExplorerBarContainerControl1).Location = new Point(14, 38);
    ((Control) this.ultraExplorerBarContainerControl1).Name = "ultraExplorerBarContainerControl1";
    ((Control) this.ultraExplorerBarContainerControl1).Size = new Size(398, 104);
    ((Control) this.ultraExplorerBarContainerControl1).TabIndex = 0;
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(8, 80 /*0x50*/);
    this.label3.Name = "label3";
    this.label3.Size = new Size(60, 13);
    this.label3.TabIndex = 8;
    this.label3.Text = "Year Start:";
    this.comboFiscalYearStart.BorderStyle = (UIElementBorderStyle) 4;
    this.comboFiscalYearStart.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboFiscalYearStart).Location = new Point(96 /*0x60*/, 80 /*0x50*/);
    this.comboFiscalYearStart.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboFiscalYearStart).Name = "comboFiscalYearStart";
    ((Control) this.comboFiscalYearStart).Size = new Size(176 /*0xB0*/, 21);
    ((Control) this.comboFiscalYearStart).TabIndex = 7;
    ((UltraControlBase) this.comboFiscalYearStart).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboFiscalYearStart).UseOsThemes = (DefaultableBoolean) 2;
    this.comboDay.BorderStyle = (UIElementBorderStyle) 4;
    this.comboDay.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboDay).Location = new Point(96 /*0x60*/, 56);
    this.comboDay.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboDay).Name = "comboDay";
    ((Control) this.comboDay).Size = new Size(176 /*0xB0*/, 21);
    ((Control) this.comboDay).TabIndex = 6;
    ((UltraControlBase) this.comboDay).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboDay).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(8, 8);
    this.label1.Name = "label1";
    this.label1.Size = new Size(83, 13);
    this.label1.TabIndex = 1;
    this.label1.Text = "Office Location:";
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboOfficeLocation).DataMember = "spFin_GetOfficeLocations";
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) this.dsOfficeLocations1;
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(96 /*0x60*/, 8);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(288, 21);
    ((Control) this.comboOfficeLocation).TabIndex = 2;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    this.dsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.dsOfficeLocations1.Locale = new CultureInfo("en-US");
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(8, 32 /*0x20*/);
    this.label2.Name = "label2";
    this.label2.Size = new Size(41, 13);
    this.label2.TabIndex = 3;
    this.label2.Text = "Month:";
    this.labelDay.AutoSize = true;
    this.labelDay.BackColor = Color.Transparent;
    this.labelDay.Enabled = false;
    this.labelDay.Location = new Point(8, 56);
    this.labelDay.Name = "labelDay";
    this.labelDay.Size = new Size(30, 13);
    this.labelDay.TabIndex = 5;
    this.labelDay.Text = "Day:";
    this.comboMonth.BorderStyle = (UIElementBorderStyle) 4;
    this.comboMonth.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboMonth).Location = new Point(96 /*0x60*/, 32 /*0x20*/);
    this.comboMonth.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboMonth).Name = "comboMonth";
    ((Control) this.comboMonth).Size = new Size(176 /*0xB0*/, 21);
    ((Control) this.comboMonth).TabIndex = 4;
    ((UltraControlBase) this.comboMonth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboMonth).UseOsThemes = (DefaultableBoolean) 2;
    this.comboMonth.RowSelected += new RowSelectedEventHandler(this.comboMonth_RowSelected);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.labelNoConfigurations);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.gridCurrentConfigurations);
    ((Control) this.ultraExplorerBarContainerControl2).Location = new Point(14, 188);
    ((Control) this.ultraExplorerBarContainerControl2).Name = "ultraExplorerBarContainerControl2";
    ((Control) this.ultraExplorerBarContainerControl2).Size = new Size(398, 133);
    ((Control) this.ultraExplorerBarContainerControl2).TabIndex = 1;
    this.labelNoConfigurations.Dock = DockStyle.Fill;
    this.labelNoConfigurations.Location = new Point(0, 0);
    this.labelNoConfigurations.Name = "labelNoConfigurations";
    this.labelNoConfigurations.Size = new Size(398, 133);
    this.labelNoConfigurations.TabIndex = 10;
    this.labelNoConfigurations.Text = "No offices are currently configured.";
    this.labelNoConfigurations.TextAlign = ContentAlignment.MiddleCenter;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridCurrentConfigurations, "ContextMenu");
    ((UltraGridBase) this.gridCurrentConfigurations).DataMember = "Settings";
    ((UltraGridBase) this.gridCurrentConfigurations).DataSource = (object) this.dsFiscalConfigurations1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 264;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Current Setting";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 132;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance3).BackColor2 = Color.White;
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCurrentConfigurations).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance3;
    ((Control) this.gridCurrentConfigurations).Dock = DockStyle.Fill;
    ((Control) this.gridCurrentConfigurations).Location = new Point(0, 0);
    ((Control) this.gridCurrentConfigurations).Name = "gridCurrentConfigurations";
    ((Control) this.gridCurrentConfigurations).Size = new Size(398, 133);
    ((Control) this.gridCurrentConfigurations).TabIndex = 10;
    ((UltraControlBase) this.gridCurrentConfigurations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridCurrentConfigurations).UseOsThemes = (DefaultableBoolean) 2;
    this.dsFiscalConfigurations1.DataSetName = "dsFiscalConfigurations";
    this.dsFiscalConfigurations1.Locale = new CultureInfo("en-US");
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.buttonCancel);
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.buttonSave);
    ((Control) this.ultraExplorerBarContainerControl3).Location = new Point(14, 342);
    ((Control) this.ultraExplorerBarContainerControl3).Name = "ultraExplorerBarContainerControl3";
    ((Control) this.ultraExplorerBarContainerControl3).Size = new Size(398, 40);
    ((Control) this.ultraExplorerBarContainerControl3).TabIndex = 2;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance4).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance4).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonCancel).Location = new Point(272, 8);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(120, 24);
    ((Control) this.buttonCancel).TabIndex = 8;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance5).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance5).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance5;
    ((Control) this.buttonSave).Location = new Point(144 /*0x90*/, 8);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(120, 24);
    ((Control) this.buttonSave).TabIndex = 7;
    ((Control) this.buttonSave).Text = "Save Configuration";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    this.daGetOfficeLocations.SelectCommand = this.sqlSelectCommand1;
    this.daGetOfficeLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOfficeLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Office Location", "Office Location")
      })
    });
    this.daGetOfficeLocations.RowUpdated += new SqlRowUpdatedEventHandler(this.daGetOfficeLocations_RowUpdated);
    this.sqlSelectCommand1.CommandText = "[spFin_GetOfficeLocations]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.FormDataConnection;
    this.sqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.daGetFiscalConfigurations.SelectCommand = this.sqlSelectCommand2;
    this.daGetFiscalConfigurations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spfin_GetFiscalConfigurations", new DataColumnMapping[4]
      {
        new DataColumnMapping("fiscalSettingId", "fiscalSettingId"),
        new DataColumnMapping("glCompanyid", "glCompanyid"),
        new DataColumnMapping("Location", "Location"),
        new DataColumnMapping("Current", "Current")
      })
    });
    this.sqlSelectCommand2.CommandText = "[spfin_GetFiscalConfigurations]";
    this.sqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand2.Connection = this.FormDataConnection;
    this.sqlSelectCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BackColor2 = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.Appearance = (AppearanceBase) appearance6;
    this.ultraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.ultraExplorerBar1.ColumnSpacing = 30;
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl1);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl2);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl3);
    ((Control) this.ultraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
    explorerBarGroup1.Settings.ContainerHeight = 106;
    ((UltraExplorerBarSettingsBase) explorerBarGroup1.Settings).MaxLines = 100;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "Fiscal Settings";
    explorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
    explorerBarGroup2.Settings.ContainerHeight = 135;
    explorerBarGroup2.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "Current Configurations";
    explorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
    explorerBarGroup3.Settings.ContainerHeight = 42;
    explorerBarGroup3.Settings.HeaderVisible = (DefaultableBoolean) 2;
    explorerBarGroup3.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup3.Settings.Style = (GroupStyle) 6;
    explorerBarGroup3.Text = "Save";
    this.ultraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[3]
    {
      explorerBarGroup1,
      explorerBarGroup2,
      explorerBarGroup3
    });
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(239, 247, 253);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance8).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance8).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance8).BorderColor = Color.White;
    ((AppearanceBase) appearance8).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance8).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance8).ForeColor = Color.DarkBlue;
    ((AppearanceBase) appearance8).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance8).ImageBackground = (Image) componentResourceManager.GetObject("appearance5.ImageBackground");
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance9;
    this.ultraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Bottom = 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Left = 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Right = 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Top = 4;
    this.ultraExplorerBar1.GroupSpacing = 10;
    ((Control) this.ultraExplorerBar1).Location = new Point(0, 0);
    this.ultraExplorerBar1.Margins.Bottom = 8;
    this.ultraExplorerBar1.Margins.Left = 8;
    this.ultraExplorerBar1.Margins.Right = 8;
    this.ultraExplorerBar1.Margins.Top = 8;
    ((Control) this.ultraExplorerBar1).Name = "ultraExplorerBar1";
    this.ultraExplorerBar1.NavigationAllowGroupReorder = false;
    this.ultraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.ultraExplorerBar1).Size = new Size(426, 395);
    ((Control) this.ultraExplorerBar1).TabIndex = 11;
    this.ultraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    ((UltraControlBase) this.ultraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.HideToolbars = true;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.Text = "ContextToolbar";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance10).Image = componentResourceManager.GetObject("appearance7.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance10;
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedPropsInternal).Caption = "Delete Fiscal Setting";
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "ContextMenu";
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool2
    });
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) popupMenuTool
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._formFiscalConfiguration_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Left).Name = "_formFiscalConfiguration_Toolbars_Dock_Area_Left";
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Left).Size = new Size(0, 395);
    this._formFiscalConfiguration_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._formFiscalConfiguration_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Right).Location = new Point(426, 0);
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Right).Name = "_formFiscalConfiguration_Toolbars_Dock_Area_Right";
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Right).Size = new Size(0, 395);
    this._formFiscalConfiguration_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._formFiscalConfiguration_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Top).Name = "_formFiscalConfiguration_Toolbars_Dock_Area_Top";
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Top).Size = new Size(426, 0);
    this._formFiscalConfiguration_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._formFiscalConfiguration_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Bottom).Location = new Point(0, 395);
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Bottom).Name = "_formFiscalConfiguration_Toolbars_Dock_Area_Bottom";
    ((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Bottom).Size = new Size(426, 0);
    this._formFiscalConfiguration_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(426, 395);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ultraExplorerBar1);
    this.Controls.Add((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._formFiscalConfiguration_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formFiscalConfiguration);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Accounting - Fiscal Configuration";
    this.Load += new EventHandler(this.formFiscalConfiguration_Load);
    ((Control) this.ultraExplorerBarContainerControl1).ResumeLayout(false);
    ((Control) this.ultraExplorerBarContainerControl1).PerformLayout();
    ((ISupportInitialize) this.comboFiscalYearStart).EndInit();
    ((ISupportInitialize) this.comboDay).EndInit();
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    this.dsOfficeLocations1.EndInit();
    ((ISupportInitialize) this.comboMonth).EndInit();
    ((Control) this.ultraExplorerBarContainerControl2).ResumeLayout(false);
    ((ISupportInitialize) this.gridCurrentConfigurations).EndInit();
    this.dsFiscalConfigurations1.EndInit();
    ((Control) this.ultraExplorerBarContainerControl3).ResumeLayout(false);
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.ultraExplorerBar1).EndInit();
    ((Control) this.ultraExplorerBar1).ResumeLayout(false);
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  private void LoadOfficeLocations()
  {
    this.dsOfficeLocations1.Clear();
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboOfficeLocation).Rows).Count != 1)
      return;
    this.comboOfficeLocation.Value = ((UltraGridBase) this.comboOfficeLocation).Rows[0].Cells["id"].Value;
  }

  private void LoadMonthsCombo()
  {
    ((UltraGridBase) this.comboMonth).DataSource = (object) new DataSet()
    {
      Tables = {
        new DataTable("Months")
        {
          Columns = {
            new DataColumn("MonthId", typeof (int)),
            new DataColumn("MonthName", typeof (string)),
            new DataColumn("MonthDays", typeof (int))
          },
          Rows = {
            new object[3]
            {
              (object) 1,
              (object) "January",
              (object) 31 /*0x1F*/
            },
            new object[3]
            {
              (object) 2,
              (object) "February",
              (object) 28
            },
            new object[3]
            {
              (object) 3,
              (object) "March",
              (object) 31 /*0x1F*/
            },
            new object[3]{ (object) 4, (object) "April", (object) 30 },
            new object[3]
            {
              (object) 5,
              (object) "May",
              (object) 31 /*0x1F*/
            },
            new object[3]{ (object) 6, (object) "June", (object) 30 },
            new object[3]
            {
              (object) 7,
              (object) "July",
              (object) 31 /*0x1F*/
            },
            new object[3]
            {
              (object) 8,
              (object) "August",
              (object) 31 /*0x1F*/
            },
            new object[3]
            {
              (object) 9,
              (object) "September",
              (object) 30
            },
            new object[3]
            {
              (object) 10,
              (object) "October",
              (object) 31 /*0x1F*/
            },
            new object[3]
            {
              (object) 11,
              (object) "Novemeber",
              (object) 30
            },
            new object[3]
            {
              (object) 12,
              (object) "December",
              (object) 31 /*0x1F*/
            }
          }
        }
      }
    };
    ((UltraGridBase) this.comboMonth).DataMember = "Months";
    ((UltraDropDownBase) this.comboMonth).DisplayMember = "MonthName";
    ((UltraDropDownBase) this.comboMonth).ValueMember = "MonthId";
  }

  private void LoadYearAddition()
  {
    ((UltraGridBase) this.comboFiscalYearStart).DataSource = (object) new DataSet()
    {
      Tables = {
        new DataTable("YearAddition")
        {
          Columns = {
            new DataColumn("YearAdditionId", typeof (int)),
            new DataColumn("YearAddition", typeof (string))
          },
          Rows = {
            new object[2]{ (object) -1, (object) "Last Year" },
            new object[2]{ (object) 0, (object) "Current Year" },
            new object[2]{ (object) 1, (object) "Next Year" }
          }
        }
      }
    };
    ((UltraGridBase) this.comboFiscalYearStart).DataMember = "YearAddition";
    ((UltraDropDownBase) this.comboFiscalYearStart).DisplayMember = "YearAddition";
    ((UltraDropDownBase) this.comboFiscalYearStart).ValueMember = "YearAdditionId";
  }

  private void LoadCurrentFiscalConfigurations()
  {
    this.dsFiscalConfigurations1.Clear();
    this.daGetFiscalConfigurations.Fill((DataTable) this.dsFiscalConfigurations1.Settings);
    this.labelNoConfigurations.Visible = ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridCurrentConfigurations).Rows).Count == 0;
  }

  private void ClearScreen()
  {
    ((Control) this.comboOfficeLocation).ResetText();
    ((Control) this.comboMonth).ResetText();
    ((Control) this.comboDay).ResetText();
    ((Control) this.comboFiscalYearStart).ResetText();
    this.LoadOfficeLocations();
    this.LoadMonthsCombo();
    this.LoadCurrentFiscalConfigurations();
    this.LoadYearAddition();
    this.HideConfiguredOfficeLocations();
  }

  private void HideConfiguredOfficeLocations()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridCurrentConfigurations).Rows).Count == 0)
    {
      ((Control) this.comboOfficeLocation).Enabled = true;
      ((Control) this.comboMonth).Enabled = true;
    }
    else
    {
      int num = 0;
      foreach (UltraGridRow row1 in ((UltraGridBase) this.comboOfficeLocation).Rows)
      {
        foreach (UltraGridRow row2 in ((UltraGridBase) this.gridCurrentConfigurations).Rows)
        {
          if (int.Parse(row1.Cells["id"].Value.ToString()) == int.Parse(row2.Cells["glcompanyid"].Value.ToString()))
          {
            ++num;
            row1.Hidden = true;
            break;
          }
        }
      }
      ((Control) this.comboOfficeLocation).Enabled = num != ((DisposableObjectCollectionBase) ((UltraGridBase) this.comboOfficeLocation).Rows).Count;
      ((Control) this.comboMonth).Enabled = num != ((DisposableObjectCollectionBase) ((UltraGridBase) this.comboOfficeLocation).Rows).Count;
    }
  }

  private bool ValidateForm()
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("OfficeLocationRequired"), MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("RequiredFieldMissingMessageBoxCaption"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.comboOfficeLocation.Focus();
      return false;
    }
    if (((UltraDropDownBase) this.comboMonth).SelectedRow == null)
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("FiscalMonthRequired"), MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("RequiredFieldMissingMessageBoxCaption"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.comboMonth.Focus();
      return false;
    }
    if (((UltraDropDownBase) this.comboDay).SelectedRow == null)
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("FiscalDayRequired"), MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("RequiredFieldMissingMessageBoxCaption"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.comboDay.Focus();
      return false;
    }
    if (((UltraDropDownBase) this.comboFiscalYearStart).SelectedRow != null)
      return true;
    int num1 = (int) MessageBox.Show(MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("FiscalDayRequired"), MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("RequiredFieldMissingMessageBoxCaption"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    this.comboFiscalYearStart.Focus();
    return false;
  }

  private void formFiscalConfiguration_Load(object sender, EventArgs e)
  {
    this.HideConfiguredOfficeLocations();
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.Close();

  private void comboMonth_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboMonth).SelectedRow == null)
      return;
    DataSet dataSet = new DataSet();
    DataTable table = new DataTable("Days");
    table.Columns.Add(new DataColumn("dayValue", typeof (int)));
    table.Columns.Add(new DataColumn("dayDisplay", typeof (int)));
    for (int index = 1; index <= int.Parse(((UltraDropDownBase) this.comboMonth).SelectedRow.Cells["MonthDays"].Value.ToString()); ++index)
      table.Rows.Add((object) index, (object) index);
    dataSet.Tables.Add(table);
    ((UltraGridBase) this.comboDay).DataSource = (object) dataSet;
    ((UltraGridBase) this.comboDay).DataMember = "Days";
    ((UltraDropDownBase) this.comboDay).DisplayMember = "dayDisplay";
    ((UltraDropDownBase) this.comboDay).ValueMember = "dayValue";
    this.labelDay.Enabled = true;
    ((Control) this.comboDay).Enabled = true;
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    this.SaveFiscalConfiguration(int.Parse(this.comboOfficeLocation.Value.ToString()), int.Parse(this.comboMonth.Value.ToString()), int.Parse(this.comboDay.Value.ToString()), int.Parse(this.comboFiscalYearStart.Value.ToString()));
  }

  private void SaveFiscalConfiguration(
    int glCompanyId,
    int fiscalMonth,
    int fiscalDay,
    int yearAddition)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_InsertFiscalSetting", new object[8]
    {
      (object) "@glCompanyId",
      (object) glCompanyId,
      (object) "@fiscalMonth",
      (object) fiscalMonth,
      (object) "@fiscalDay",
      (object) fiscalDay,
      (object) "@yearAddition",
      (object) yearAddition
    });
    this.ClearScreen();
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (!(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key == "DELETE") || ((SparseCollectionBase) this.gridCurrentConfigurations.Selected.Rows).Count == 0)
      return;
    DefaultDatabase.ExecuteNonQuery("spFin_DeleteFiscalConfiguration", new object[2]
    {
      (object) "@fiscalSettingId",
      (object) int.Parse(this.gridCurrentConfigurations.Selected.Rows[0].Cells["FiscalSettingId"].Value.ToString())
    });
    ((Control) this.gridCurrentConfigurations).Refresh();
    this.ClearScreen();
  }

  private void daGetOfficeLocations_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
  {
  }
}

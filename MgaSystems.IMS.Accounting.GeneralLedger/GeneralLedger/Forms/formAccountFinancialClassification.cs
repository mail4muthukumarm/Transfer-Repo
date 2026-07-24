// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.formAccountFinancialClassification
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Forms;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

[TestForm]
public class formAccountFinancialClassification : Form
{
  internal UltraExplorerBar UltraExplorerBar1;
  internal UltraExplorerBarContainerControl UltraExplorerBarContainerControl1;
  internal MGASimpleComboBox comboOfficeLocations;
  internal MGAButton btnSave;
  internal Label Label1;
  internal UltraExplorerBarContainerControl UltraExplorerBarContainerControl2;
  internal UltraGrid gridGlAccounts;
  internal UltraDropDown UltraDropDown1;
  internal UltraExplorerBarContainerControl UltraExplorerBarContainerControl4;
  internal SqlCommand SqlUpdateCommand1;
  internal SqlConnection FormDataConnection;
  internal SqlCommand SqlSelectCommand3;
  internal SqlDataAdapter daGetGLAccountTypes;
  internal SqlCommand SqlSelectCommand2;
  internal SqlDataAdapter daGetGLAccountsFinancialReports;
  internal SqlCommand SqlInsertCommand1;
  internal SqlCommand SqlSelectCommand1;
  internal ContextMenu ContextMenu1;
  internal MenuItem MenuItem1;
  internal MenuItem MenuItem2;
  internal SqlDataAdapter daGetOfficeLocations;
  private dsOfficeLocations DsOfficeLocations1;
  private dsGLAcctsFinancialReports DsGLAcctsFinancialReports1;
  private dsGetGLAcctTypesFinancialReports DsGetGLAcctTypesFinancialReports1;
  private System.ComponentModel.Container components;

  public formAccountFinancialClassification()
  {
    this.InitializeComponent();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.LoadOfficeLocations();
    this.LoadGLAccountTypes();
    this.LoadFinancialTypes();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("AccountList", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("glacctid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("accountclass");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("acctNumber");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("fullname");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("accttypeid");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("AcctTypeDecription");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("AccountTypes", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("AcctTypeId");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("AcctTypeDescription");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("AcctClassName");
    Appearance appearance9 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (formAccountFinancialClassification));
    Appearance appearance12 = new Appearance();
    this.UltraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.comboOfficeLocations = new MGASimpleComboBox();
    this.btnSave = new MGAButton();
    this.Label1 = new Label();
    this.UltraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.gridGlAccounts = new UltraGrid();
    this.ContextMenu1 = new ContextMenu();
    this.MenuItem1 = new MenuItem();
    this.MenuItem2 = new MenuItem();
    this.DsGLAcctsFinancialReports1 = new dsGLAcctsFinancialReports();
    this.UltraDropDown1 = new UltraDropDown();
    this.UltraExplorerBar1 = new UltraExplorerBar();
    this.UltraExplorerBarContainerControl4 = new UltraExplorerBarContainerControl();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.SqlSelectCommand3 = new SqlCommand();
    this.daGetGLAccountTypes = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.daGetGLAccountsFinancialReports = new SqlDataAdapter();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.daGetOfficeLocations = new SqlDataAdapter();
    this.DsOfficeLocations1 = new dsOfficeLocations();
    this.DsGetGLAcctTypesFinancialReports1 = new dsGetGLAcctTypesFinancialReports();
    ((Control) this.UltraExplorerBarContainerControl1).SuspendLayout();
    ((ISupportInitialize) this.comboOfficeLocations).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((Control) this.UltraExplorerBarContainerControl2).SuspendLayout();
    ((ISupportInitialize) this.gridGlAccounts).BeginInit();
    this.DsGLAcctsFinancialReports1.BeginInit();
    ((ISupportInitialize) this.UltraDropDown1).BeginInit();
    ((ISupportInitialize) this.UltraExplorerBar1).BeginInit();
    ((Control) this.UltraExplorerBar1).SuspendLayout();
    this.DsOfficeLocations1.BeginInit();
    this.DsGetGLAcctTypesFinancialReports1.BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.comboOfficeLocations);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.btnSave);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label1);
    ((Control) this.UltraExplorerBarContainerControl1).Location = new Point(14, 38);
    ((Control) this.UltraExplorerBarContainerControl1).Name = "UltraExplorerBarContainerControl1";
    ((Control) this.UltraExplorerBarContainerControl1).Size = new Size(820, 32 /*0x20*/);
    ((Control) this.UltraExplorerBarContainerControl1).TabIndex = 0;
    this.comboOfficeLocations.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocations.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboOfficeLocations).DataMember = "spFin_GetOfficeLocations";
    ((UltraDropDownBase) this.comboOfficeLocations).DisplayMember = "Office Location";
    this.comboOfficeLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocations).Location = new Point(96 /*0x60*/, 8);
    this.comboOfficeLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocations).Name = "comboOfficeLocations";
    ((Control) this.comboOfficeLocations).Size = new Size(304, 20);
    ((Control) this.comboOfficeLocations).TabIndex = 6;
    ((UltraDropDownBase) this.comboOfficeLocations).ValueMember = "ID";
    this.comboOfficeLocations.RowSelected += new RowSelectedEventHandler(this.comboOfficeLocations_RowSelected);
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnSave).Location = new Point(408, 8);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(128 /*0x80*/, 23);
    ((Control) this.btnSave).TabIndex = 5;
    ((Control) this.btnSave).Text = "Save Settings";
    ((Control) this.btnSave).Click += new EventHandler(this.btnSave_Click);
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.Black;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(83, 17);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Office Location:";
    ((Control) this.UltraExplorerBarContainerControl2).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.gridGlAccounts);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.UltraDropDown1);
    ((Control) this.UltraExplorerBarContainerControl2).Location = new Point(14, 116);
    ((Control) this.UltraExplorerBarContainerControl2).Name = "UltraExplorerBarContainerControl2";
    ((Control) this.UltraExplorerBarContainerControl2).Size = new Size(820, 400);
    ((Control) this.UltraExplorerBarContainerControl2).TabIndex = 1;
    ((Control) this.gridGlAccounts).ContextMenu = this.ContextMenu1;
    ((UltraGridBase) this.gridGlAccounts).DataSource = (object) this.DsGLAcctsFinancialReports1;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridGlAccounts).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridGlAccounts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Account Class";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 150;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Account #";
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 279;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Account Name";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 189;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Classification";
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 142;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Width = 200;
    ultraGridBand1.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ultraGridBand1.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand1.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand1.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand1.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand1.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand1.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand1.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 2;
    ultraGridBand1.Override.BorderStyleCardArea = (UIElementBorderStyle) 4;
    ultraGridBand1.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance3).BorderColor = Color.Silver;
    ultraGridBand1.Override.CellAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance4).FontData.BoldAsString = "False";
    ((AppearanceBase) appearance4).FontData.Name = "Tahoma";
    ultraGridBand1.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridBand1.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ultraGridBand1.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridGlAccounts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridGlAccounts).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance6).TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridGlAccounts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridGlAccounts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((Control) this.gridGlAccounts).Dock = DockStyle.Fill;
    ((UltraControlBase) this.gridGlAccounts).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridGlAccounts).Location = new Point(0, 0);
    ((Control) this.gridGlAccounts).Name = "gridGlAccounts";
    ((Control) this.gridGlAccounts).Size = new Size(820, 400);
    ((UltraControlBase) this.gridGlAccounts).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridGlAccounts).TabIndex = 3;
    this.ContextMenu1.MenuItems.AddRange(new MenuItem[2]
    {
      this.MenuItem1,
      this.MenuItem2
    });
    this.MenuItem1.Checked = true;
    this.MenuItem1.Index = 0;
    this.MenuItem1.RadioCheck = true;
    this.MenuItem1.Text = "erwer";
    this.MenuItem2.Checked = true;
    this.MenuItem2.Index = 1;
    this.MenuItem2.RadioCheck = true;
    this.MenuItem2.Text = "werw";
    this.DsGLAcctsFinancialReports1.DataSetName = "dsGLAcctsFinancialReports";
    this.DsGLAcctsFinancialReports1.Locale = new CultureInfo("en-US");
    ((Control) this.UltraDropDown1).Cursor = Cursors.Default;
    ((UltraGridBase) this.UltraDropDown1).DataMember = "AccountTypes";
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Appearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 1;
    ultraGridColumn8.Width = 125;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 2;
    ultraGridColumn9.Width = 65;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ultraGridBand2.GroupHeadersVisible = false;
    ultraGridBand2.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ultraGridBand2.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ultraGridBand2.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ultraGridBand2.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ultraGridBand2.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ultraGridBand2.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ultraGridBand2.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraDropDownBase) this.UltraDropDown1).DisplayMember = "AcctTypeDescription";
    ((Control) this.UltraDropDown1).Location = new Point(8, 32 /*0x20*/);
    ((Control) this.UltraDropDown1).Name = "UltraDropDown1";
    ((Control) this.UltraDropDown1).Size = new Size(192 /*0xC0*/, 80 /*0x50*/);
    ((Control) this.UltraDropDown1).TabIndex = 1;
    ((UltraDropDownBase) this.UltraDropDown1).ValueMember = "AcctTypeId";
    ((Control) this.UltraDropDown1).Visible = false;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BackColor2 = Color.White;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.Appearance = (AppearanceBase) appearance9;
    this.UltraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.UltraExplorerBar1.ColumnSpacing = 30;
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl1);
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl2);
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl4);
    ((Control) this.UltraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup1.Container = this.UltraExplorerBarContainerControl1;
    explorerBarGroup1.Settings.ContainerHeight = 34;
    ((UltraExplorerBarSettingsBase) explorerBarGroup1.Settings).MaxLines = 100;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "GL Account Classifications";
    explorerBarGroup2.Container = this.UltraExplorerBarContainerControl2;
    explorerBarGroup2.Settings.ContainerHeight = 402;
    explorerBarGroup2.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "Current Settings";
    this.UltraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[2]
    {
      explorerBarGroup1,
      explorerBarGroup2
    });
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(239, 247, 253);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance11).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance11).BorderColor = Color.White;
    ((AppearanceBase) appearance11).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance11).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance11).ForeColor = Color.DarkBlue;
    ((AppearanceBase) appearance11).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance11).ImageBackground = (Image) resourceManager.GetObject("appearance11.ImageBackground");
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance12;
    this.UltraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Bottom = 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Left = 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Right = 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Top = 4;
    this.UltraExplorerBar1.GroupSpacing = 10;
    ((Control) this.UltraExplorerBar1).Location = new Point(0, 0);
    this.UltraExplorerBar1.Margins.Bottom = 8;
    this.UltraExplorerBar1.Margins.Left = 8;
    this.UltraExplorerBar1.Margins.Right = 8;
    this.UltraExplorerBar1.Margins.Top = 8;
    ((Control) this.UltraExplorerBar1).Name = "UltraExplorerBar1";
    this.UltraExplorerBar1.NavigationAllowGroupReorder = false;
    this.UltraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.UltraExplorerBar1).Size = new Size(848, 534);
    ((UltraControlBase) this.UltraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraExplorerBar1).TabIndex = 5;
    this.UltraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    ((Control) this.UltraExplorerBarContainerControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraExplorerBarContainerControl4).Name = "UltraExplorerBarContainerControl4";
    ((Control) this.UltraExplorerBarContainerControl4).Size = new Size(203, 103);
    ((Control) this.UltraExplorerBarContainerControl4).TabIndex = 2;
    ((Control) this.UltraExplorerBarContainerControl4).Visible = false;
    this.SqlUpdateCommand1.CommandText = "[spFin_SaveGLAccountSettings]";
    this.SqlUpdateCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlUpdateCommand1.Connection = this.FormDataConnection;
    this.SqlUpdateCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.SqlUpdateCommand1.Parameters.Add(new SqlParameter("@glacctid", SqlDbType.Int, 4, "glacctid"));
    this.SqlUpdateCommand1.Parameters.Add(new SqlParameter("@accttypeid", SqlDbType.Int, 4, "accttypeid"));
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.SqlSelectCommand3.CommandText = "[spFin_GetOfficeLocations]";
    this.SqlSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand3.Connection = this.FormDataConnection;
    this.SqlSelectCommand3.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.daGetGLAccountTypes.SelectCommand = this.SqlSelectCommand2;
    this.daGetGLAccountTypes.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetGLAccountTypesFinancialReports", new DataColumnMapping[2]
      {
        new DataColumnMapping("AcctTypeId", "AcctTypeId"),
        new DataColumnMapping("AcctTypeDescription", "AcctTypeDescription")
      })
    });
    this.SqlSelectCommand2.CommandText = "[spFin_GetGLAccountTypesFinancialReports]";
    this.SqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand2.Connection = this.FormDataConnection;
    this.SqlSelectCommand2.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.daGetGLAccountsFinancialReports.InsertCommand = this.SqlInsertCommand1;
    this.daGetGLAccountsFinancialReports.SelectCommand = this.SqlSelectCommand1;
    this.daGetGLAccountsFinancialReports.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetGLAcctsFinancialReports", new DataColumnMapping[5]
      {
        new DataColumnMapping("glacctid", "glacctid"),
        new DataColumnMapping("AccountClass", "AccountClass"),
        new DataColumnMapping("AcctNumber", "AcctNumber"),
        new DataColumnMapping("fullname", "fullname"),
        new DataColumnMapping("accttypeid", "accttypeid")
      })
    });
    this.daGetGLAccountsFinancialReports.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlInsertCommand1.CommandText = "[spFin_SaveGLAccountSettings]";
    this.SqlInsertCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlInsertCommand1.Connection = this.FormDataConnection;
    this.SqlInsertCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.SqlInsertCommand1.Parameters.Add(new SqlParameter("@glacctid", SqlDbType.Int, 4, "glacctid"));
    this.SqlInsertCommand1.Parameters.Add(new SqlParameter("@accttypeid", SqlDbType.Int, 4, "accttypeid"));
    this.SqlSelectCommand1.CommandText = "[spFin_GetGLAcctsFinancialReports]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@glcompanyid", SqlDbType.Int, 4));
    this.daGetOfficeLocations.SelectCommand = this.SqlSelectCommand3;
    this.daGetOfficeLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOfficeLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Office Location", "Office Location")
      })
    });
    this.DsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.DsOfficeLocations1.Locale = new CultureInfo("en-US");
    this.DsGetGLAcctTypesFinancialReports1.DataSetName = "dsGetGLAcctTypesFinancialReports";
    this.DsGetGLAcctTypesFinancialReports1.Locale = new CultureInfo("en-US");
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(848, 534);
    this.Controls.Add((Control) this.UltraExplorerBar1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (formAccountFinancialClassification);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Account Financial Classification";
    ((Control) this.UltraExplorerBarContainerControl1).ResumeLayout(false);
    ((ISupportInitialize) this.comboOfficeLocations).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((Control) this.UltraExplorerBarContainerControl2).ResumeLayout(false);
    ((ISupportInitialize) this.gridGlAccounts).EndInit();
    this.DsGLAcctsFinancialReports1.EndInit();
    ((ISupportInitialize) this.UltraDropDown1).EndInit();
    ((ISupportInitialize) this.UltraExplorerBar1).EndInit();
    ((Control) this.UltraExplorerBar1).ResumeLayout(false);
    this.DsOfficeLocations1.EndInit();
    this.DsGetGLAcctTypesFinancialReports1.EndInit();
    this.ResumeLayout(false);
  }

  private void LoadGLAccounts(int GLCompanyID)
  {
    this.daGetGLAccountsFinancialReports.SelectCommand.Parameters["@glcompanyid"].Value = (object) GLCompanyID;
    this.DsGLAcctsFinancialReports1.AccountList.Clear();
    this.daGetGLAccountsFinancialReports.Fill((DataTable) this.DsGLAcctsFinancialReports1.AccountList);
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocations).DataSource = (object) Methods.GetOfficeLocationDataset();
  }

  private void LoadGLAccountTypes()
  {
    this.daGetGLAccountTypes.Fill((DataTable) this.DsGetGLAcctTypesFinancialReports1.AccountTypes);
  }

  private void SaveSettings()
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      ((UltraGridBase) this.gridGlAccounts).UpdateData();
      this.daGetGLAccountsFinancialReports.Update((DataTable) this.DsGLAcctsFinancialReports1.AccountList);
      int num = (int) MessageBox.Show("Account settings saved successfully!", "Account Settings Saved!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void LoadFinancialTypes()
  {
    this.ContextMenu1.MenuItems.Clear();
    foreach (dsGetGLAcctTypesFinancialReports.AccountTypesRow row in (InternalDataCollectionBase) this.DsGetGLAcctTypesFinancialReports1.AccountTypes.Rows)
    {
      this.ContextMenu1.MenuItems.Add(row.AcctTypeDescription);
      this.ContextMenu1.MenuItems[this.ContextMenu1.MenuItems.Count - 1].RadioCheck = true;
      this.ContextMenu1.MenuItems[this.ContextMenu1.MenuItems.Count - 1].Click += new EventHandler(this.GridContextMenuClicked);
    }
  }

  private void GridContextMenuClicked(object sender, EventArgs e)
  {
    string text = ((MenuItem) sender).Text;
    this.UpdateGridSettings(Database.Instance.QueryText.PerformScalarQueryInt("Select AcctTypeId from lstGlAcctTypes where Upper(acctTypeDescription) = Upper(@Description)", (object) "@Description", (object) text), text);
  }

  private void UpdateGridSettings(int GLAcctTypeId, string AccountClassification)
  {
    foreach (UltraGridRow row in this.gridGlAccounts.Selected.Rows)
    {
      row.Cells["AcctTypeId"].Value = (object) GLAcctTypeId;
      row.Cells["AcctTypeDescription"].Value = (object) AccountClassification;
      row.Update();
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    this.SaveSettings();
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void comboOfficeLocations_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (e.Row == null)
      return;
    this.Cursor = Cursors.WaitCursor;
    try
    {
      this.LoadGLAccounts(Convert.ToInt32(e.Row.Cells["id"].Value));
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }
}

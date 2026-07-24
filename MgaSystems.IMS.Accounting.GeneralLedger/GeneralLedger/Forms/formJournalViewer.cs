// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.formJournalViewer
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using GrapeCity.ActiveReports;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Reports;
using MGASystems.IMS.Accounting.Services.Forms;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Security;
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

[SecureResource("{FE42072A-5A73-4035-B48E-E5E7FBFC59C1}", "Journal Viewer Rights", "Determines whether or not a user is allowed view the journal viewer.", "Accounting")]
public class formJournalViewer : Form
{
  internal UltraExplorerBar UltraExplorerBar1;
  internal UltraExplorerBarContainerControl UltraExplorerBarContainerControl1;
  internal MGADateTimePicker dateFrom;
  internal MGAButton btnFind;
  internal MGAButton btnPrint;
  internal Label Label2;
  internal MGAButton btnRefresh;
  internal Label Label1;
  internal MGADateTimePicker dateTo;
  internal UltraExplorerBarContainerControl UltraExplorerBarContainerControl2;
  internal UltraGrid gridJournalView;
  internal SqlDataAdapter daJournalView;
  internal SqlCommand SqlSelectCommand1;
  internal ContextMenu ContextMenu1;
  internal MenuItem menuVoidTransaction;
  internal ImageList ImageList1;
  private dsJournalView dsJournalView1;
  internal Label label3;
  private MGASimpleComboBox comboOfficeLocations;
  private IContainer components;
  private DateTime _lastDateFrom;
  private DateTime _lastDateTo;

  public formJournalViewer()
  {
    this.InitializeComponent();
    this.LoadOfficeLocations();
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
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formJournalViewer));
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("spFin_JournalView", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("TRANSACTION #");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("TRANSACTION DATE");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("DATE STUB");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("DAY STUB");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("GL ACCT NAME");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("DEBIT");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CREDIT");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("VOID");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    this.UltraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.label3 = new Label();
    this.comboOfficeLocations = new MGASimpleComboBox();
    this.dateFrom = new MGADateTimePicker();
    this.btnFind = new MGAButton();
    this.btnPrint = new MGAButton();
    this.Label2 = new Label();
    this.btnRefresh = new MGAButton();
    this.Label1 = new Label();
    this.dateTo = new MGADateTimePicker();
    this.UltraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.gridJournalView = new UltraGrid();
    this.ContextMenu1 = new ContextMenu();
    this.menuVoidTransaction = new MenuItem();
    this.dsJournalView1 = new dsJournalView();
    this.UltraExplorerBar1 = new UltraExplorerBar();
    this.daJournalView = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.ImageList1 = new ImageList(this.components);
    ((Control) this.UltraExplorerBarContainerControl1).SuspendLayout();
    ((ISupportInitialize) this.comboOfficeLocations).BeginInit();
    ((ISupportInitialize) this.dateFrom).BeginInit();
    ((ISupportInitialize) this.btnFind).BeginInit();
    ((ISupportInitialize) this.btnPrint).BeginInit();
    ((ISupportInitialize) this.btnRefresh).BeginInit();
    ((ISupportInitialize) this.dateTo).BeginInit();
    ((Control) this.UltraExplorerBarContainerControl2).SuspendLayout();
    ((ISupportInitialize) this.gridJournalView).BeginInit();
    this.dsJournalView1.BeginInit();
    ((ISupportInitialize) this.UltraExplorerBar1).BeginInit();
    ((Control) this.UltraExplorerBar1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.label3);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.comboOfficeLocations);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.dateFrom);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.btnFind);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.btnPrint);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label2);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.btnRefresh);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label1);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.dateTo);
    ((Control) this.UltraExplorerBarContainerControl1).Location = new Point(15, 39);
    ((Control) this.UltraExplorerBarContainerControl1).Name = "UltraExplorerBarContainerControl1";
    ((Control) this.UltraExplorerBarContainerControl1).Size = new Size(874, 63 /*0x3F*/);
    ((Control) this.UltraExplorerBarContainerControl1).TabIndex = 0;
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(8, 8);
    this.label3.Name = "label3";
    this.label3.Size = new Size(88, 13);
    this.label3.TabIndex = 8;
    this.label3.Text = "Office Locations:";
    this.comboOfficeLocations.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocations.CharacterCasing = CharacterCasing.Normal;
    this.comboOfficeLocations.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboOfficeLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocations).Location = new Point(104, 8);
    this.comboOfficeLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocations).Name = "comboOfficeLocations";
    ((Control) this.comboOfficeLocations).Size = new Size(312, 21);
    ((Control) this.comboOfficeLocations).TabIndex = 7;
    ((UltraControlBase) this.comboOfficeLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocations).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateFrom.Appearance = (AppearanceBase) appearance1;
    ((AppearanceBase) appearance2).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance2).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance2).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance2).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance2).ForegroundAlpha = (Alpha) 2;
    this.dateFrom.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dateFrom).Location = new Point(104, 32 /*0x20*/);
    this.dateFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateFrom).Name = "dateFrom";
    ((Control) this.dateFrom).Size = new Size(104, 20);
    ((Control) this.dateFrom).TabIndex = 0;
    ((UltraControlBase) this.dateFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateFrom).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(238, 238, 232);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(238, 238, 232);
    ((AppearanceBase) appearance3).Image = componentResourceManager.GetObject("appearance3.Image");
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnFind).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.btnFind).ImageSize = new Size(32 /*0x20*/, 32 /*0x20*/);
    ((Control) this.btnFind).Location = new Point(424, 8);
    ((Control) this.btnFind).Name = "btnFind";
    ((Control) this.btnFind).Size = new Size(48 /*0x30*/, 46);
    ((Control) this.btnFind).TabIndex = 2;
    ((UltraControlBase) this.btnFind).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnFind).Click += new EventHandler(this.btnFind_Click);
    ((Control) this.btnPrint).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance4).Image = componentResourceManager.GetObject("appearance4.Image");
    ((AppearanceBase) appearance4).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance4).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnPrint).Appearance = (AppearanceBase) appearance4;
    ((ControlBase) this.btnPrint).BackColorInternal = Color.WhiteSmoke;
    ((Control) this.btnPrint).Enabled = false;
    ((Control) this.btnPrint).Location = new Point(776, 32 /*0x20*/);
    ((Control) this.btnPrint).Name = "btnPrint";
    ((Control) this.btnPrint).Size = new Size(88, 24);
    ((Control) this.btnPrint).TabIndex = 6;
    ((Control) this.btnPrint).Text = "Print";
    ((UltraControlBase) this.btnPrint).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnPrint).Click += new EventHandler(this.btnPrint_Click);
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(8, 32 /*0x20*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(75, 13);
    this.Label2.TabIndex = 5;
    this.Label2.Text = "Starting Date:";
    ((Control) this.btnRefresh).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance5).Image = componentResourceManager.GetObject("appearance5.Image");
    ((AppearanceBase) appearance5).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance5).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnRefresh).Appearance = (AppearanceBase) appearance5;
    ((ControlBase) this.btnRefresh).BackColorInternal = Color.WhiteSmoke;
    ((Control) this.btnRefresh).Location = new Point(680, 32 /*0x20*/);
    ((Control) this.btnRefresh).Name = "btnRefresh";
    ((Control) this.btnRefresh).Size = new Size(88, 24);
    ((Control) this.btnRefresh).TabIndex = 4;
    ((Control) this.btnRefresh).Text = "Refresh";
    ((UltraControlBase) this.btnRefresh).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnRefresh).Click += new EventHandler(this.btnRefresh_Click);
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(240 /*0xF0*/, 32 /*0x20*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(69, 13);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Ending Date:";
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTo.Appearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance7).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance7).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance7).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance7).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance7).ForegroundAlpha = (Alpha) 2;
    this.dateTo.ButtonAppearance = (AppearanceBase) appearance7;
    ((Control) this.dateTo).Location = new Point(312, 32 /*0x20*/);
    this.dateTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTo).Name = "dateTo";
    ((Control) this.dateTo).Size = new Size(104, 20);
    ((Control) this.dateTo).TabIndex = 1;
    ((UltraControlBase) this.dateTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTo).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraExplorerBarContainerControl2).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.gridJournalView);
    ((Control) this.UltraExplorerBarContainerControl2).Location = new Point(15, 148);
    ((Control) this.UltraExplorerBarContainerControl2).Name = "UltraExplorerBarContainerControl2";
    ((Control) this.UltraExplorerBarContainerControl2).Size = new Size(874, 578);
    ((Control) this.UltraExplorerBarContainerControl2).TabIndex = 1;
    ((Control) this.gridJournalView).ContextMenu = this.ContextMenu1;
    ((Control) this.gridJournalView).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridJournalView).DataMember = "spFin_JournalView";
    ((UltraGridBase) this.gridJournalView).DataSource = (object) this.dsJournalView1;
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Appearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ((AppearanceBase) appearance9).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance9).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Center";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance9;
    ultraGridColumn3.ColSpan = (short) 2;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Date";
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 87;
    ((AppearanceBase) appearance11).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance11).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Center";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 30;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Account Title";
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 400;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance13;
    ultraGridColumn6.Format = "c";
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Debit";
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Width = 178;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance15;
    ultraGridColumn7.Format = "c";
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance16;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Credit";
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Width = 177;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridBand.Columns.AddRange(new object[8]
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
    ((AppearanceBase) appearance17).TextHAlignAsString = "Left";
    ultraGridBand.Override.HeaderAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridJournalView).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance18).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance19).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.RowSizing = (RowSizing) 5;
    ((AppearanceBase) appearance21).BackColor = Color.SteelBlue;
    ((AppearanceBase) appearance21).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance21).ForeColor = Color.White;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.SummaryFooterAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).BackColor = Color.SteelBlue;
    ((AppearanceBase) appearance22).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance22).ForeColor = Color.White;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.SummaryFooterCaptionAppearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).BackColor = Color.White;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Override.SummaryValueAppearance = (AppearanceBase) appearance23;
    ((Control) this.gridJournalView).Dock = DockStyle.Fill;
    ((Control) this.gridJournalView).Location = new Point(0, 0);
    ((Control) this.gridJournalView).Name = "gridJournalView";
    ((Control) this.gridJournalView).Size = new Size(874, 578);
    ((Control) this.gridJournalView).TabIndex = 3;
    ((UltraControlBase) this.gridJournalView).UseOsThemes = (DefaultableBoolean) 2;
    this.gridJournalView.InitializeLayout += new InitializeLayoutEventHandler(this.gridJournalView_InitializeLayout);
    this.gridJournalView.InitializeRow += new InitializeRowEventHandler(this.gridJournalView_InitializeRow);
    this.ContextMenu1.MenuItems.AddRange(new MenuItem[1]
    {
      this.menuVoidTransaction
    });
    this.ContextMenu1.Popup += new EventHandler(this.ContextMenu1_Popup);
    this.menuVoidTransaction.Index = 0;
    this.menuVoidTransaction.Text = "Void Transaction..";
    this.menuVoidTransaction.Visible = false;
    this.menuVoidTransaction.Click += new EventHandler(this.menuVoidTransaction_Click);
    this.dsJournalView1.DataSetName = "dsJournalView";
    this.dsJournalView1.Locale = new CultureInfo("en-US");
    ((AppearanceBase) appearance24).BackColor = Color.White;
    ((AppearanceBase) appearance24).BackColor2 = Color.White;
    ((AppearanceBase) appearance24).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.Appearance = (AppearanceBase) appearance24;
    this.UltraExplorerBar1.BorderStyle = (UIElementBorderStyle) 4;
    this.UltraExplorerBar1.ColumnSpacing = 30;
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl1);
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl2);
    ((Control) this.UltraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup1.Container = this.UltraExplorerBarContainerControl1;
    explorerBarGroup1.Settings.ContainerHeight = 65;
    ((UltraExplorerBarSettingsBase) explorerBarGroup1.Settings).MaxLines = 100;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "Search Criteria";
    explorerBarGroup2.Container = this.UltraExplorerBarContainerControl2;
    explorerBarGroup2.Settings.ContainerHeight = 580;
    explorerBarGroup2.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "Journal View";
    this.UltraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[2]
    {
      explorerBarGroup1,
      explorerBarGroup2
    });
    ((AppearanceBase) appearance25).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance25).BackColor2 = Color.FromArgb(239, 247, 253);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance26).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance26).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance26).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance26).BorderColor = Color.White;
    ((AppearanceBase) appearance26).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance26).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance26).ForeColor = Color.DarkBlue;
    ((AppearanceBase) appearance26).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance26).ImageBackground = (Image) componentResourceManager.GetObject("appearance26.ImageBackground");
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance26;
    ((AppearanceBase) appearance27).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance27;
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
    ((Control) this.UltraExplorerBar1).Size = new Size(904, 734);
    ((Control) this.UltraExplorerBar1).TabIndex = 8;
    ((UltraControlBase) this.UltraExplorerBar1).UseFlatMode = (DefaultableBoolean) 1;
    this.UltraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    ((UltraControlBase) this.UltraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.daJournalView.SelectCommand = this.SqlSelectCommand1;
    this.daJournalView.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_JournalView", new DataColumnMapping[7]
      {
        new DataColumnMapping("TRANSACTION #", "TRANSACTION #"),
        new DataColumnMapping("TRANSACTION DATE", "TRANSACTION DATE"),
        new DataColumnMapping("DATE STUB", "DATE STUB"),
        new DataColumnMapping("DAY STUB", "DAY STUB"),
        new DataColumnMapping("GL ACCT NAME", "GL ACCT NAME"),
        new DataColumnMapping("DEBIT", "DEBIT"),
        new DataColumnMapping("CREDIT", "CREDIT")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_JournalView]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@DATEFROM", SqlDbType.DateTime, 8),
      new SqlParameter("@DATETO", SqlDbType.DateTime, 8)
    });
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    this.ImageList1.Images.SetKeyName(0, "");
    this.ImageList1.Images.SetKeyName(1, "");
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(904, 734);
    this.Controls.Add((Control) this.UltraExplorerBar1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (formJournalViewer);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Journal Viewer";
    ((Control) this.UltraExplorerBarContainerControl1).ResumeLayout(false);
    ((Control) this.UltraExplorerBarContainerControl1).PerformLayout();
    ((ISupportInitialize) this.comboOfficeLocations).EndInit();
    ((ISupportInitialize) this.dateFrom).EndInit();
    ((ISupportInitialize) this.btnFind).EndInit();
    ((ISupportInitialize) this.btnPrint).EndInit();
    ((ISupportInitialize) this.btnRefresh).EndInit();
    ((ISupportInitialize) this.dateTo).EndInit();
    ((Control) this.UltraExplorerBarContainerControl2).ResumeLayout(false);
    ((ISupportInitialize) this.gridJournalView).EndInit();
    this.dsJournalView1.EndInit();
    ((ISupportInitialize) this.UltraExplorerBar1).EndInit();
    ((Control) this.UltraExplorerBar1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void btnFind_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    this.ExecuteSearch();
  }

  private void gridJournalView_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (e.Row.Index > 0)
    {
      if (e.Row.Cells["DATE STUB"].Value.ToString().Equals(((UltraGridBase) this.gridJournalView).Rows[e.Row.Index - 1].Cells["DATE STUB"].Value.ToString()))
      {
        e.Row.Cells["DATE STUB"].Hidden = true;
        ((AppearanceBase) e.Row.Cells["DATE STUB"].Appearance).BackColor = Color.LightSteelBlue;
        ((AppearanceBase) e.Row.Cells["DATE STUB"].Appearance).BorderAlpha = (Alpha) 3;
      }
      if (int.Parse(e.Row.Cells["TRANSACTION #"].Value.ToString()) == int.Parse(((UltraGridBase) this.gridJournalView).Rows[e.Row.Index - 1].Cells["TRANSACTION #"].Value.ToString()))
        e.Row.Cells["DAY STUB"].Value = (object) DBNull.Value;
      else
        e.Row.RowSpacingBefore = 1;
    }
    if (!e.Row.Cells["DEBIT"].Value.Equals((object) DBNull.Value) && Decimal.Parse(e.Row.Cells["DEBIT"].Value.ToString()) == 0M)
      e.Row.Cells["DEBIT"].Value = (object) DBNull.Value;
    if (!e.Row.Cells["CREDIT"].Value.Equals((object) DBNull.Value) && Decimal.Parse(e.Row.Cells["CREDIT"].Value.ToString()) == 0M)
      e.Row.Cells["CREDIT"].Value = (object) DBNull.Value;
    if (!bool.Parse(e.Row.Cells["void"].Value.ToString()))
      return;
    ((AppearanceBase) e.Row.CellAppearance).FontData.Strikeout = (DefaultableBoolean) 1;
    ((AppearanceBase) e.Row.CellAppearance).FontData.Bold = (DefaultableBoolean) 1;
    ((AppearanceBase) e.Row.CellAppearance).ForeColor = Color.Red;
  }

  private void gridJournalView_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    ((HeaderBase) ((UltraGridBase) this.gridJournalView).DisplayLayout.Bands[0].Columns["DAY STUB"].Header).Caption = " ";
  }

  private void AddSummaries()
  {
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Bands[0].Summaries.Clear();
    SummarySettings summarySettings1 = ((UltraGridBase) this.gridJournalView).DisplayLayout.Bands[0].Summaries.Add("DebitSummary", (SummaryType) 5, (ICustomSummaryCalculator) new formJournalViewer.DebitsTotalSummary(), ((UltraGridBase) this.gridJournalView).DisplayLayout.Bands[0].Columns["DEBIT"], (SummaryPosition) 0, (UltraGridColumn) null);
    summarySettings1.DisplayFormat = "{0:c}";
    summarySettings1.Appearance.TextHAlign = (HAlign) 3;
    summarySettings1.SummaryPosition = (SummaryPosition) 3;
    summarySettings1.Appearance.FontData.Bold = (DefaultableBoolean) 1;
    SummarySettings summarySettings2 = ((UltraGridBase) this.gridJournalView).DisplayLayout.Bands[0].Summaries.Add("CreditSummary", (SummaryType) 5, (ICustomSummaryCalculator) new formJournalViewer.CreditsTotalSummary(), ((UltraGridBase) this.gridJournalView).DisplayLayout.Bands[0].Columns["CREDIT"], (SummaryPosition) 0, (UltraGridColumn) null);
    summarySettings2.DisplayFormat = "{0:c}";
    summarySettings2.Appearance.TextHAlign = (HAlign) 3;
    summarySettings2.SummaryPosition = (SummaryPosition) 3;
    summarySettings2.Appearance.FontData.Bold = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridJournalView).DisplayLayout.Bands[0].SummaryFooterCaption = "Debit/Credit Summaries";
  }

  private bool ValidateForm()
  {
    if (this.dateFrom.DateTime.Equals((object) DBNull.Value))
    {
      int num = (int) MessageBox.Show("Starting date must a valid date!", "Invalid Date!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((Control) this.dateFrom).Focus();
      return false;
    }
    if (this.dateTo.DateTime.Equals((object) DBNull.Value))
    {
      int num = (int) MessageBox.Show("Ending date must a valid date!", "Invalid Date!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((Control) this.dateTo).Focus();
      return false;
    }
    if (!(this.dateFrom.DateTime > this.dateTo.DateTime))
      return true;
    int num1 = (int) MessageBox.Show("Starting date must be greater than ending date!", "Invalid Date!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    ((Control) this.dateFrom).Focus();
    return false;
  }

  private void ExecuteSearch()
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      ((Control) this.btnPrint).Enabled = true;
      this._lastDateFrom = this.dateFrom.DateTime;
      this._lastDateTo = this.dateTo.DateTime;
      this.dsJournalView1.Clear();
      using (SqlConnection sqlConnection = new SqlConnection(CurrentUser.Instance.ConnectionString))
      {
        this.daJournalView.SelectCommand.Connection = sqlConnection;
        this.daJournalView.SelectCommand.CommandText = "spFin_JournalView";
        this.daJournalView.SelectCommand.CommandType = CommandType.StoredProcedure;
        this.daJournalView.SelectCommand.Parameters.Clear();
        this.daJournalView.SelectCommand.Parameters.AddWithValue("@DATEFROM", (object) this.dateFrom.DateTime);
        this.daJournalView.SelectCommand.Parameters.AddWithValue("@DATETO", (object) this.dateTo.DateTime);
        this.daJournalView.SelectCommand.Parameters.AddWithValue("@GLCOMPANYID", (object) int.Parse(this.comboOfficeLocations.Value.ToString()));
        this.dsJournalView1.Clear();
        this.daJournalView.Fill((DataSet) this.dsJournalView1, "spFin_JournalView");
        this.AddSummaries();
      }
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void btnRefresh_Click(object sender, EventArgs e)
  {
    if (this.ValidateForm())
      this.ExecuteSearch();
    else
      this.dsJournalView1.Clear();
  }

  private void frmJournalView_KeyDown(object sender, KeyEventArgs e)
  {
    if (!e.KeyValue.Equals((object) Keys.F))
      return;
    e.Modifiers.Equals((object) Keys.Control);
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      rptGeneralLedger rpt = new rptGeneralLedger(this.dsJournalView1, this._lastDateFrom, this._lastDateTo);
      rpt.Run();
      rpt.Document.Name = "General Ledger";
      ReportFactory.Instance.ShowReport((SectionReport) rpt);
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void VoidJournalTransaction(int transactionNumber)
  {
    if (!SecurityManager.Instance.AssertPermission("{1A4F865E-ABC2-47c1-A976-77B4348F33F3}"))
    {
      int num = (int) MessageBox.Show("You do not have rights to void this trasnsaction.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      using (formVoidTransaction formVoidTransaction = new formVoidTransaction(transactionNumber))
      {
        if (formVoidTransaction.ShowDialog() != DialogResult.OK || !this.ValidateForm())
          return;
        this.ExecuteSearch();
      }
    }
  }

  private void ContextMenu1_Popup(object sender, EventArgs e)
  {
    this.menuVoidTransaction.Visible = ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridJournalView).Rows).Count != 0;
  }

  public bool HasPaymentsPosted(int transactionNumber)
  {
    return Database.Instance.QuerySP.PerformScalarQueryBool("dbo.spFin_HasPaymentsPosted", false, (object) "@TransactNum", (object) transactionNumber);
  }

  private void menuVoidTransaction_Click(object sender, EventArgs e)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridJournalView).Rows).Count == 0)
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridJournalView).Rows)
    {
      if (((GridItemBase) row).Selected)
      {
        int transactionNumber = int.Parse(row.Cells["transaction #"].Value.ToString());
        if (this.HasPaymentsPosted(transactionNumber))
        {
          int num = (int) MessageBox.Show($"Can not void transaction : {transactionNumber.ToString()}. Please void the transaction(s) that are posted against this Invoice/Expense Entry.", "Void Transaction ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          if (MessageBox.Show("This will permanently void this transaction. This operation can not be reversed. Do you wish to permanently void this transaction?", "Permanently Void Transaction?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            break;
          this.VoidJournalTransaction(transactionNumber);
          if (!this.ValidateForm())
            break;
          this.ExecuteSearch();
          break;
        }
      }
    }
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocations).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocations).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocations).ValueMember = "ID";
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboOfficeLocations).Rows).Count == 0)
      throw new Exception("Could not find office location rows.");
    this.comboOfficeLocations.Value = ((UltraGridBase) this.comboOfficeLocations).Rows[0].Cells["ID"].Value;
  }

  private class DebitsTotalSummary : ICustomSummaryCalculator
  {
    private Decimal Total;

    public void AggregateCustomSummary(SummarySettings summarySettings, UltraGridRow row)
    {
      if (bool.Parse(row.GetCellValue(summarySettings.SourceColumn.Band.Columns["VOID"]).ToString()))
        return;
      object cellValue = row.GetCellValue(summarySettings.SourceColumn.Band.Columns["DEBIT"]);
      if (cellValue.Equals((object) DBNull.Value))
        return;
      this.Total += Decimal.Parse(cellValue.ToString());
    }

    public void BeginCustomSummary(SummarySettings summarySettings, RowsCollection rows)
    {
      this.Total = 0M;
    }

    public object EndCustomSummary(SummarySettings summarySettings, RowsCollection rows)
    {
      return (object) this.Total;
    }
  }

  private class CreditsTotalSummary : ICustomSummaryCalculator
  {
    private Decimal Total;

    public void AggregateCustomSummary(SummarySettings summarySettings, UltraGridRow row)
    {
      if (bool.Parse(row.GetCellValue(summarySettings.SourceColumn.Band.Columns["VOID"]).ToString()))
        return;
      object cellValue = row.GetCellValue(summarySettings.SourceColumn.Band.Columns["CREDIT"]);
      if (cellValue.Equals((object) DBNull.Value))
        return;
      this.Total += Decimal.Parse(cellValue.ToString());
    }

    public void BeginCustomSummary(SummarySettings summarySettings, RowsCollection rows)
    {
      this.Total = 0M;
    }

    public object EndCustomSummary(SummarySettings summarySettings, RowsCollection rows)
    {
      return (object) this.Total;
    }
  }
}

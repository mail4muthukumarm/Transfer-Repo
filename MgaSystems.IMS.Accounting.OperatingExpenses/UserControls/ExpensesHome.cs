// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.ExpensesHome
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Shared;
using Infragistics.UltraChart.Resources.Appearance;
using Infragistics.UltraChart.Shared.Styles;
using Infragistics.Win;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.OperatingExpenses.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.UserControls;

public class ExpensesHome : UserControl
{
  internal SqlCommand SqlSelectCommand1;
  internal SqlConnection ControlDataConnection;
  internal ImageList ImageList1;
  internal Label Label3;
  internal SqlDataAdapter daGetScheduledExpenses;
  internal SqlCommand SqlSelectCommand2;
  internal SqlDataAdapter daGetChartData_CurrentYearly;
  private dsOperatingHomeChartData dsOperatingHomeChartData1;
  private UltraExplorerBar ultraExplorerBar1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
  internal Panel panelLoadingChartData;
  internal Label Label2;
  internal Infragistics.Win.UltraWinChart.UltraChart chartGlance;
  internal Panel panelAccountStatus;
  internal UltraGrid gridScheduledExpenses;
  private ToolTip toolTip1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
  private Panel panel1;
  private RadioButton radioShowThisMonth;
  private RadioButton radioShowThisWeek;
  private RadioButton radioShowAll;
  private IContainer components;
  private string str = "The {0} operating account at {1} has a balance of {2}. The current oustanding expense total {3}.";
  private int GlCompanyId;
  private Thread ScheduledExpenseThread;
  private dsScheduledExpenses ds;
  private Thread ExpenseAccountStatusThread;
  private Panel StatusPanelBuffer = new Panel();

  public ExpensesHome(int glCompanyId)
  {
    this.InitializeComponent();
    this.GlCompanyId = glCompanyId;
    this.Dock = DockStyle.Fill;
    this.ControlDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.ExpenseAccountStatusThread = new Thread(new ThreadStart(this.BuildExpenseAcctStatus));
    this.ExpenseAccountStatusThread.Start();
    this.ScheduledExpenseThread = new Thread(new ThreadStart(this.GetScheduledExpenses));
    this.ScheduledExpenseThread.Start();
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
    Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("ScheduledExpenses", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PODate");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PONum");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("PayeeGuid");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Payee");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Amount");
    Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("PaymentDueDate");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("PaymentDueDate2");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("PAYEXPENSE", 0);
    Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (ExpensesHome));
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("UnboundColumn1", 1);
    Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
    PaintElement paintElement1 = new PaintElement();
    PaintElement paintElement2 = new PaintElement();
    Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup3 = new UltraExplorerBarGroup();
    Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
    this.ultraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.panelAccountStatus = new Panel();
    this.ultraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.panelLoadingChartData = new Panel();
    this.Label2 = new Label();
    this.ultraExplorerBarContainerControl4 = new UltraExplorerBarContainerControl();
    this.gridScheduledExpenses = new UltraGrid();
    this.panel1 = new Panel();
    this.radioShowThisMonth = new RadioButton();
    this.radioShowThisWeek = new RadioButton();
    this.radioShowAll = new RadioButton();
    this.chartGlance = new Infragistics.Win.UltraWinChart.UltraChart();
    this.SqlSelectCommand1 = new SqlCommand();
    this.ControlDataConnection = new SqlConnection();
    this.ImageList1 = new ImageList(this.components);
    this.ultraExplorerBar1 = new UltraExplorerBar();
    this.Label3 = new Label();
    this.daGetScheduledExpenses = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.daGetChartData_CurrentYearly = new SqlDataAdapter();
    this.toolTip1 = new ToolTip(this.components);
    ((Control) this.ultraExplorerBarContainerControl1).SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl2).SuspendLayout();
    this.panelLoadingChartData.SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl4).SuspendLayout();
    ((ISupportInitialize) this.gridScheduledExpenses).BeginInit();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.chartGlance).BeginInit();
    ((ISupportInitialize) this.ultraExplorerBar1).BeginInit();
    ((Control) this.ultraExplorerBar1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.panelAccountStatus);
    ((Control) this.ultraExplorerBarContainerControl1).Location = new Point(18, 34);
    ((Control) this.ultraExplorerBarContainerControl1).Name = "ultraExplorerBarContainerControl1";
    ((Control) this.ultraExplorerBarContainerControl1).Size = new Size(450, 288);
    ((Control) this.ultraExplorerBarContainerControl1).TabIndex = 0;
    this.panelAccountStatus.BackColor = Color.Transparent;
    this.panelAccountStatus.Dock = DockStyle.Fill;
    this.panelAccountStatus.Location = new Point(0, 0);
    this.panelAccountStatus.Name = "panelAccountStatus";
    this.panelAccountStatus.Size = new Size(450, 288);
    this.panelAccountStatus.TabIndex = 6;
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.panelLoadingChartData);
    ((Control) this.ultraExplorerBarContainerControl2).Location = new Point(499, 34);
    ((Control) this.ultraExplorerBarContainerControl2).Name = "ultraExplorerBarContainerControl2";
    ((Control) this.ultraExplorerBarContainerControl2).Size = new Size(450, 288);
    ((Control) this.ultraExplorerBarContainerControl2).TabIndex = 1;
    this.panelLoadingChartData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.panelLoadingChartData.BackColor = Color.Transparent;
    this.panelLoadingChartData.Controls.Add((Control) this.Label2);
    this.panelLoadingChartData.Location = new Point(16 /*0x10*/, 24);
    this.panelLoadingChartData.Name = "panelLoadingChartData";
    this.panelLoadingChartData.Size = new Size(421, 240 /*0xF0*/);
    this.panelLoadingChartData.TabIndex = 3;
    this.panelLoadingChartData.Text = "Panel1";
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Dock = DockStyle.Top;
    this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.LightSlateGray;
    this.Label2.Location = new Point(0, 0);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(421, 240 /*0xF0*/);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Loading Chart Data...";
    this.Label2.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.ultraExplorerBarContainerControl4).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.ultraExplorerBarContainerControl4).Controls.Add((Control) this.gridScheduledExpenses);
    ((Control) this.ultraExplorerBarContainerControl4).Controls.Add((Control) this.panel1);
    ((Control) this.ultraExplorerBarContainerControl4).Location = new Point(18, 374);
    ((Control) this.ultraExplorerBarContainerControl4).Name = "ultraExplorerBarContainerControl4";
    ((Control) this.ultraExplorerBarContainerControl4).Size = new Size(931, 400);
    ((Control) this.ultraExplorerBarContainerControl4).TabIndex = 3;
    ((Control) this.gridScheduledExpenses).Cursor = Cursors.Default;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Date Entered";
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 136;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 459;
    ((AppearanceBase) appearance2).TextHAlign = (HAlign) 3;
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn5.Format = "c";
    ((AppearanceBase) appearance3).TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 144 /*0x90*/;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Due Date";
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Width = 146;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 96 /*0x60*/;
    ultraGridColumn8.ButtonDisplayStyle = (ButtonDisplayStyle) 1;
    ((AppearanceBase) appearance4).Cursor = Cursors.Hand;
    ((AppearanceBase) appearance4).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance4).FontData.UnderlineAsString = "True";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).Image = resourceManager.GetObject("appearance5.Image");
    ((AppearanceBase) appearance5).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance5).ImageVAlign = (VAlign) 2;
    ultraGridColumn8.CellButtonAppearance = (AppearanceBase) appearance5;
    ultraGridColumn8.DefaultCellValue = (object) "";
    ((HeaderBase) ultraGridColumn8.Header).Caption = "";
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 7;
    ultraGridColumn8.LockedWidth = true;
    ultraGridColumn8.Style = (ColumnStyle) 8;
    ultraGridColumn8.Width = 22;
    ultraGridColumn9.ButtonDisplayStyle = (ButtonDisplayStyle) 1;
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).Cursor = Cursors.Hand;
    ((AppearanceBase) appearance6).Image = resourceManager.GetObject("appearance6.Image");
    ((AppearanceBase) appearance6).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance6).ImageVAlign = (VAlign) 2;
    ultraGridColumn9.CellButtonAppearance = (AppearanceBase) appearance6;
    ultraGridColumn9.DefaultCellValue = (object) "";
    ((HeaderBase) ultraGridColumn9.Header).Caption = "";
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 8;
    ultraGridColumn9.LockedWidth = true;
    ultraGridColumn9.Style = (ColumnStyle) 8;
    ultraGridColumn9.Width = 22;
    ultraGridBand.Columns.AddRange(new object[9]
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
    ((AppearanceBase) appearance7).BorderColor = Color.Silver;
    ultraGridBand.Override.CellAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.CellMultiLine = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance9).TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    ((Control) this.gridScheduledExpenses).Dock = DockStyle.Fill;
    ((UltraControlBase) this.gridScheduledExpenses).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridScheduledExpenses).Location = new Point(0, 24);
    ((Control) this.gridScheduledExpenses).Name = "gridScheduledExpenses";
    ((Control) this.gridScheduledExpenses).Size = new Size(931, 376);
    ((UltraControlBase) this.gridScheduledExpenses).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridScheduledExpenses).TabIndex = 1;
    this.gridScheduledExpenses.InitializeLayout += new InitializeLayoutEventHandler(this.gridScheduledExpenses_InitializeLayout);
    this.panel1.BackColor = Color.Transparent;
    this.panel1.Controls.Add((Control) this.radioShowThisMonth);
    this.panel1.Controls.Add((Control) this.radioShowThisWeek);
    this.panel1.Controls.Add((Control) this.radioShowAll);
    this.panel1.Dock = DockStyle.Top;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(931, 24);
    this.panel1.TabIndex = 4;
    this.radioShowThisMonth.BackColor = Color.Transparent;
    this.radioShowThisMonth.FlatStyle = FlatStyle.Flat;
    this.radioShowThisMonth.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.radioShowThisMonth.Location = new Point(224 /*0xE0*/, 0);
    this.radioShowThisMonth.Name = "radioShowThisMonth";
    this.radioShowThisMonth.Size = new Size(136, 24);
    this.radioShowThisMonth.TabIndex = 4;
    this.radioShowThisMonth.Text = "Show This Month Only";
    this.radioShowThisMonth.CheckedChanged += new EventHandler(this.ScheduledExpenseOptionsChanged);
    this.radioShowThisWeek.BackColor = Color.Transparent;
    this.radioShowThisWeek.FlatStyle = FlatStyle.Flat;
    this.radioShowThisWeek.Location = new Point(88, 0);
    this.radioShowThisWeek.Name = "radioShowThisWeek";
    this.radioShowThisWeek.Size = new Size(136, 24);
    this.radioShowThisWeek.TabIndex = 3;
    this.radioShowThisWeek.Text = "Show This Week Only";
    this.radioShowThisWeek.CheckedChanged += new EventHandler(this.ScheduledExpenseOptionsChanged);
    this.radioShowAll.BackColor = Color.Transparent;
    this.radioShowAll.Checked = true;
    this.radioShowAll.FlatStyle = FlatStyle.Flat;
    this.radioShowAll.Location = new Point(8, 0);
    this.radioShowAll.Name = "radioShowAll";
    this.radioShowAll.Size = new Size(72, 24);
    this.radioShowAll.TabIndex = 2;
    this.radioShowAll.TabStop = true;
    this.radioShowAll.Text = "Show All";
    this.radioShowAll.CheckedChanged += new EventHandler(this.ScheduledExpenseOptionsChanged);
    this.chartGlance.ChartType = (ChartType) 2;
    ((Control) this.chartGlance).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.X.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.X.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartGlance.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.X.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.X.Labels.SeriesLabels).Flip = false;
    this.chartGlance.Axis.X.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.X.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.X.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.X.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.X.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.X.Labels).VerticalAlign = StringAlignment.Center;
    this.chartGlance.Axis.X.ScrollScale.Height = 10;
    this.chartGlance.Axis.X.ScrollScale.Visible = false;
    this.chartGlance.Axis.X.ScrollScale.Width = 15;
    this.chartGlance.Axis.X.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.X2.Labels).Flip = false;
    this.chartGlance.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.X2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.X2.Labels.SeriesLabels).Flip = false;
    this.chartGlance.Axis.X2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.X2.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.X2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.X2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.X2.Labels).VerticalAlign = StringAlignment.Center;
    this.chartGlance.Axis.X2.ScrollScale.Height = 10;
    this.chartGlance.Axis.X2.ScrollScale.Visible = false;
    this.chartGlance.Axis.X2.ScrollScale.Width = 15;
    this.chartGlance.Axis.X2.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y.Labels).HorizontalAlign = StringAlignment.Far;
    this.chartGlance.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.00>";
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y.Labels.SeriesLabels).Flip = false;
    this.chartGlance.Axis.Y.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Far;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y.Labels).VerticalAlign = StringAlignment.Center;
    this.chartGlance.Axis.Y.ScrollScale.Height = 10;
    this.chartGlance.Axis.Y.ScrollScale.Visible = false;
    this.chartGlance.Axis.Y.ScrollScale.Width = 15;
    this.chartGlance.Axis.Y.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y2.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y2.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartGlance.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.00>";
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y2.Labels.SeriesLabels).Flip = false;
    this.chartGlance.Axis.Y2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Y2.Labels).VerticalAlign = StringAlignment.Center;
    this.chartGlance.Axis.Y2.ScrollScale.Height = 10;
    this.chartGlance.Axis.Y2.ScrollScale.Visible = false;
    this.chartGlance.Axis.Y2.ScrollScale.Width = 15;
    this.chartGlance.Axis.Y2.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z.Labels).VerticalAlign = StringAlignment.Center;
    this.chartGlance.Axis.Z.ScrollScale.Height = 10;
    this.chartGlance.Axis.Z.ScrollScale.Visible = false;
    this.chartGlance.Axis.Z.ScrollScale.Width = 15;
    this.chartGlance.Axis.Z.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z2.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z2.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z2.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartGlance.Axis.Z2.Labels).VerticalAlign = StringAlignment.Center;
    this.chartGlance.Axis.Z2.ScrollScale.Height = 10;
    this.chartGlance.Axis.Z2.ScrollScale.Visible = false;
    this.chartGlance.Axis.Z2.ScrollScale.Width = 15;
    this.chartGlance.Axis.Z2.TickmarkInterval = 0.0;
    ((Control) this.chartGlance).BackColor = Color.Transparent;
    this.chartGlance.ColumnLineChart.Column.SeriesSpacing = 0;
    this.chartGlance.Data.DataMember = "CurrentYearly";
    this.chartGlance.DataMember = "CurrentYearly";
    paintElement1.Fill = Color.Yellow;
    this.chartGlance.GanttChart.CompletePercentagesPE = paintElement1;
    paintElement2.Fill = Color.White;
    this.chartGlance.GanttChart.EmptyPercentagesPE = paintElement2;
    this.chartGlance.GanttChart.LinkLineStyle.DrawStyle = (LineDrawStyle) 0;
    this.chartGlance.GanttChart.LinkLineStyle.EndStyle = (LineCapStyle) 1;
    this.chartGlance.GanttChart.LinkLineStyle.MidPointAnchors = false;
    this.chartGlance.GanttChart.LinkLineStyle.StartStyle = (LineCapStyle) 0;
    this.chartGlance.GanttChart.OwnersLabelStyle.Font = new Font("Microsoft Sans Serif", 7.8f);
    ((Control) this.chartGlance).Location = new Point(16 /*0x10*/, 24);
    ((Control) this.chartGlance).Name = "chartGlance";
    ((Control) this.chartGlance).Size = new Size(321, 240 /*0xF0*/);
    this.chartGlance.TabIndex = 5;
    this.SqlSelectCommand1.CommandText = "[spFin_GetScheduledExpenses]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.ControlDataConnection;
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.ControlDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.ImageList1.ImageSize = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    ((AppearanceBase) appearance13).BackColor = Color.White;
    ((AppearanceBase) appearance13).BackColor2 = Color.White;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.Appearance = (AppearanceBase) appearance13;
    this.ultraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.ultraExplorerBar1.ColumnCount = 2;
    this.ultraExplorerBar1.ColumnSpacing = 10;
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl1);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl2);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl4);
    ((Control) this.ultraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
    explorerBarGroup1.Settings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    explorerBarGroup1.Settings.ContainerHeight = 290;
    ((UltraExplorerBarSettingsBase) explorerBarGroup1.Settings).MaxLines = 100;
    explorerBarGroup1.Settings.NavigationAllowHide = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "Operating Account Status";
    explorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
    explorerBarGroup2.Settings.ContainerHeight = 290;
    explorerBarGroup2.Settings.NavigationAllowHide = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "At A Glance...";
    explorerBarGroup3.ColumnsSpanned = 2;
    explorerBarGroup3.Container = this.ultraExplorerBarContainerControl4;
    explorerBarGroup3.Settings.ContainerHeight = 402;
    explorerBarGroup3.Settings.Style = (GroupStyle) 6;
    explorerBarGroup3.Text = "Scheduled Expense Transactions";
    this.ultraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[3]
    {
      explorerBarGroup1,
      explorerBarGroup2,
      explorerBarGroup3
    });
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance14).BackColor2 = Color.FromArgb(239, 247, 253);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance15).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance15).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance15).BorderColor = Color.White;
    ((AppearanceBase) appearance15).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance15).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance15).ForeColor = Color.DarkBlue;
    ((AppearanceBase) appearance15).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance15).ImageBackground = (Image) resourceManager.GetObject("appearance15.ImageBackground");
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance16;
    this.ultraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Top = 4;
    this.ultraExplorerBar1.GroupSpacing = 11;
    ((Control) this.ultraExplorerBar1).Location = new Point(0, 21);
    this.ultraExplorerBar1.Margins.Bottom = 4;
    this.ultraExplorerBar1.Margins.Left = 4;
    this.ultraExplorerBar1.Margins.Right = 4;
    this.ultraExplorerBar1.Margins.Top = 4;
    ((Control) this.ultraExplorerBar1).Name = "ultraExplorerBar1";
    this.ultraExplorerBar1.NavigationAllowGroupReorder = false;
    this.ultraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.ultraExplorerBar1).Size = new Size(960, 787);
    ((UltraControlBase) this.ultraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraExplorerBar1).TabIndex = 25;
    this.ultraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.ultraExplorerBar1.GroupCollapsed += new GroupCollapsedEventHandler(this.ultraExplorerBar1_GroupCollapsed);
    this.ultraExplorerBar1.GroupCollapsing += new GroupCollapsingEventHandler(this.ultraExplorerBar1_GroupCollapsing);
    this.Label3.BackColor = Color.White;
    this.Label3.Dock = DockStyle.Top;
    this.Label3.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(0, 0);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(960, 21);
    this.Label3.TabIndex = 3;
    this.Label3.Text = "Finances - Operating Expenses";
    this.daGetScheduledExpenses.SelectCommand = this.SqlSelectCommand1;
    this.daGetScheduledExpenses.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetScheduledExpenses", new DataColumnMapping[6]
      {
        new DataColumnMapping("podate", "podate"),
        new DataColumnMapping("ponum", "ponum"),
        new DataColumnMapping("payeeguid", "payeeguid"),
        new DataColumnMapping("Payee", "Payee"),
        new DataColumnMapping("Amount", "Amount"),
        new DataColumnMapping("paymentduedate", "paymentduedate")
      })
    });
    this.SqlSelectCommand2.CommandText = "[spFin_GetOperatingHomeChartData]";
    this.SqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand2.Connection = this.ControlDataConnection;
    this.SqlSelectCommand2.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.daGetChartData_CurrentYearly.SelectCommand = this.SqlSelectCommand2;
    this.daGetChartData_CurrentYearly.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOperatingHomeChartData", new DataColumnMapping[12]
      {
        new DataColumnMapping("JAN", "JAN"),
        new DataColumnMapping("FEB", "FEB"),
        new DataColumnMapping("MAR", "MAR"),
        new DataColumnMapping("APR", "APR"),
        new DataColumnMapping("MAY", "MAY"),
        new DataColumnMapping("JUN", "JUN"),
        new DataColumnMapping("JUL", "JUL"),
        new DataColumnMapping("AUG", "AUG"),
        new DataColumnMapping("SEP", "SEP"),
        new DataColumnMapping("OCT", "OCT"),
        new DataColumnMapping("NOV", "NOV"),
        new DataColumnMapping("DEC", "DEC")
      })
    });
    this.Controls.Add((Control) this.ultraExplorerBar1);
    this.Controls.Add((Control) this.Label3);
    this.Font = new Font("Tahoma", 8f);
    this.Name = nameof (ExpensesHome);
    this.Size = new Size(960, 808);
    ((Control) this.ultraExplorerBarContainerControl1).ResumeLayout(false);
    ((Control) this.ultraExplorerBarContainerControl2).ResumeLayout(false);
    this.panelLoadingChartData.ResumeLayout(false);
    ((Control) this.ultraExplorerBarContainerControl4).ResumeLayout(false);
    ((ISupportInitialize) this.gridScheduledExpenses).EndInit();
    this.panel1.ResumeLayout(false);
    ((ISupportInitialize) this.chartGlance).EndInit();
    ((ISupportInitialize) this.ultraExplorerBar1).EndInit();
    ((Control) this.ultraExplorerBar1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void NewExpensePurchaseOrder()
  {
    Form form = (Form) new formNewExpensePO();
    try
    {
      int num = (int) form.ShowDialog();
    }
    finally
    {
      form.Dispose();
    }
  }

  private void GetScheduledExpenses()
  {
    if (this.ds == null)
      this.ds = new dsScheduledExpenses();
    using (SqlConnection sqlConnection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      this.ds.Clear();
      this.daGetScheduledExpenses.SelectCommand.Connection = sqlConnection;
      this.daGetScheduledExpenses.Fill((DataTable) this.ds.ScheduledExpenses);
    }
    if (!this.IsHandleCreated || this.IsDisposed || this.Disposing)
      return;
    this.Invoke((Delegate) new ExpensesHome.GetScheduledExpensesCompletedHandler(this.GetScheduledExpensesCompleted));
  }

  private void GetScheduledExpensesCompleted()
  {
    ((UltraGridBase) this.gridScheduledExpenses).DataSource = (object) this.ds.ScheduledExpenses;
  }

  private void BuildExpenseAcctStatus()
  {
    SqlCommand sqlCommand = new SqlCommand("spFin_GetOperatingExpensesHome", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Connection.Open();
      SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
      while (sqlDataReader.Read())
      {
        Label label = new Label();
        label.Text = string.Format(this.str, (object) sqlDataReader[1].ToString(), (object) sqlDataReader[2].ToString(), (object) DecimalType.FromString(sqlDataReader[3].ToString()).ToString("c"), (object) DecimalType.FromString(sqlDataReader[4].ToString()).ToString("c"));
        label.Dock = DockStyle.Top;
        this.StatusPanelBuffer.Controls.Add((Control) label);
        label.BringToFront();
      }
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new ExpensesHome.BuildExpenseAcctStatusCompletedHandler(this.BuildExpenseAcctStatusCompleted));
    }
    catch (SqlException ex)
    {
      int num = (int) MessageBox.Show("An error has occurred while trying to get the operating expenses home page.\r\n\r\n" + ex.Errors[0].Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    catch (Exception ex)
    {
      int num = (int) MessageBox.Show("An error has occurred while trying to get the operating expenses home page.\r\n\r\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    finally
    {
      if (sqlCommand.Connection != null)
      {
        if (sqlCommand.Connection.State != ConnectionState.Closed)
          sqlCommand.Connection.Close();
        sqlCommand.Connection.Dispose();
        sqlCommand.Connection = (SqlConnection) null;
      }
      sqlCommand.Dispose();
    }
  }

  private void BuildExpenseAcctStatusCompleted()
  {
    Label label = (Label) null;
    foreach (Control control in (ArrangedElementCollection) this.StatusPanelBuffer.Controls)
    {
      if (control is Label)
      {
        label = new Label();
        label.Text = control.Text;
      }
      label.Size = new Size(this.panelAccountStatus.Width, 50);
      this.panelAccountStatus.Controls.Add((Control) label);
      label.Dock = DockStyle.Top;
      label.BringToFront();
    }
  }

  private void LoadExpenseChartData()
  {
    using (SqlConnection sqlConnection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      this.chartGlance.DataSource = (object) null;
      this.daGetChartData_CurrentYearly.SelectCommand.Connection = sqlConnection;
      if (this.dsOperatingHomeChartData1 == null)
        this.dsOperatingHomeChartData1 = new dsOperatingHomeChartData();
      this.daGetChartData_CurrentYearly.Fill((DataTable) this.dsOperatingHomeChartData1.CurrentYearly);
    }
    if (this.IsDisposed || this.Disposing)
      return;
    this.Invoke((Delegate) new ExpensesHome.LoadExpensedDataCompleteHandler(new ExpensesHome.LoadExpensedDataCompleteHandler(this.LoadExpenseDataComplete).Invoke));
  }

  private void LoadExpenseDataComplete()
  {
    this.chartGlance.DataSource = (object) this.dsOperatingHomeChartData1.CurrentYearly;
    this.panelLoadingChartData.Visible = false;
  }

  private void gridScheduledExpenses_ClickCellButton(object sender, CellEventArgs e)
  {
    if (!(((KeyedSubObjectBase) e.Cell.Column).Key == "PAYEXPENSE") || MessageBox.Show("This will issue a check to the payee for the specified expense, continue?", "Issue Check?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.PayExpenses(Convert.ToInt32(e.Cell.Row.Cells["ponum"].Value));
    this.GetScheduledExpenses();
  }

  private void gridScheduledExpenses_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (Convert.ToDateTime(e.Row.Cells["poDate"].Value) < DateTime.Now)
    {
      ((AppearanceBase) e.Row.Appearance).ForeColor = Color.Red;
      ((AppearanceBase) e.Row.Cells["poDate"].Appearance).Image = (object) this.ImageList1.Images[0];
    }
    else
      ((AppearanceBase) e.Row.Appearance).ForeColor = Color.Black;
    e.Row.Cells["PAYEXPENSE"].Value = (object) "Issue Payment";
  }

  private void PayExpenses(int purchaseOrderNumber)
  {
  }

  private void label5_Click(object sender, EventArgs e)
  {
  }

  private void ScheduledExpenseOptionsChanged(object sender, EventArgs e)
  {
    if (this.radioShowAll.Checked)
    {
      foreach (UltraGridBand band in ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Bands)
        band.ColumnFilters.ClearAllFilters();
    }
    else if (this.radioShowThisWeek.Checked)
    {
      DateTime dateTime1 = DateTime.Now;
      while (dateTime1.DayOfWeek != DayOfWeek.Monday)
        dateTime1 = dateTime1.AddDays(-1.0);
      DateTime dateTime2 = dateTime1;
      while (dateTime2.DayOfWeek != DayOfWeek.Sunday)
        dateTime2 = dateTime2.AddDays(1.0);
      ((UltraGridBase) this.gridScheduledExpenses).Rows.ColumnFilters["PaymentDueDate"].FilterConditions.Add((FilterComparisionOperator) 5, (object) dateTime1);
      if (((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Bands[0].Columns["PaymentDueDate2"] == null)
        return;
      ((UltraGridBase) this.gridScheduledExpenses).Rows.ColumnFilters["PaymentDueDate2"].FilterConditions.Add((FilterComparisionOperator) 3, (object) dateTime2);
    }
    else
    {
      int num = this.radioShowThisMonth.Checked ? 1 : 0;
    }
  }

  private void gridScheduledExpenses_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    if (((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Bands[0].Columns["PaymentDueDate2"] == null)
      return;
    ((UltraGridBase) this.gridScheduledExpenses).DisplayLayout.Bands[0].Columns["PaymentDueDate2"].Hidden = true;
  }

  private void ultraExplorerBar1_GroupCollapsing(object sender, CancelableGroupEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = true;
  }

  private void ultraExplorerBar1_GroupCollapsed(object sender, GroupEventArgs e)
  {
  }

  private delegate void LoadExpensedDataCompleteHandler();

  private delegate void LoadExpenseChartDataHandler();

  private delegate void GetScheduledExpensesCompletedHandler();

  private delegate void BuildExpenseAcctStatusCompletedHandler();
}

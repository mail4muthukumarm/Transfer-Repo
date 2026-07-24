// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.AnalysisMiniView
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.UltraChart.Resources;
using Infragistics.UltraChart.Resources.Appearance;
using Infragistics.UltraChart.Shared.Events;
using Infragistics.UltraChart.Shared.Styles;
using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.UserControls;

public class AnalysisMiniView : UserControl
{
  private MGAGroupBox groupMiniView;
  private Infragistics.Win.UltraWinChart.UltraChart pieChart;
  private Label labelDates;
  private LinkLabel labelMore;
  private Label labelLegend1;
  private Label labelLegend2;
  private Label labelLegend3;
  private Label labelLegend4;
  private Label labelLegend5;
  private Panel panelVergbage;
  private Panel panelRight;
  private Infragistics.Win.UltraWinChart.UltraChart barChart;
  private Panel panelLoading;
  private Label label1;
  private Infragistics.Win.UltraWinChart.UltraChart barChartSeries;
  private System.ComponentModel.Container components;
  private int _glCompanyId;
  private Utilities.AnalysisReportType _reportType;
  private Utilities.AnalysisChartType _chartType;
  private DataSet _dataSet;

  private AnalysisMiniView() => this.InitializeComponent();

  public AnalysisMiniView(
    int glCompanyId,
    Utilities.AnalysisReportType reportType,
    Utilities.AnalysisChartType chartType)
  {
    this.InitializeComponent();
    this._glCompanyId = glCompanyId;
    this._reportType = reportType;
    this._chartType = chartType;
    this.SetGroupText();
    this.HandleCreated += new EventHandler(this.AnalysisMiniView_HandleCreated);
  }

  private void AnalysisMiniView_HandleCreated(object sender, EventArgs e)
  {
    this.LoadData();
    this.HandleCreated -= new EventHandler(this.AnalysisMiniView_HandleCreated);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (AnalysisMiniView));
    GradientEffect gradientEffect1 = new GradientEffect();
    ShadowEffect shadowEffect1 = new ShadowEffect();
    ShadowEffect shadowEffect2 = new ShadowEffect();
    GradientEffect gradientEffect2 = new GradientEffect();
    ShadowEffect shadowEffect3 = new ShadowEffect();
    GradientEffect gradientEffect3 = new GradientEffect();
    this.groupMiniView = new MGAGroupBox();
    this.panelVergbage = new Panel();
    this.labelLegend5 = new Label();
    this.labelLegend4 = new Label();
    this.labelLegend3 = new Label();
    this.labelLegend2 = new Label();
    this.labelLegend1 = new Label();
    this.labelMore = new LinkLabel();
    this.panelRight = new Panel();
    this.barChartSeries = new Infragistics.Win.UltraWinChart.UltraChart();
    this.barChart = new Infragistics.Win.UltraWinChart.UltraChart();
    this.pieChart = new Infragistics.Win.UltraWinChart.UltraChart();
    this.panelLoading = new Panel();
    this.label1 = new Label();
    this.labelDates = new Label();
    ((ISupportInitialize) this.groupMiniView).BeginInit();
    ((Control) this.groupMiniView).SuspendLayout();
    this.panelVergbage.SuspendLayout();
    this.panelRight.SuspendLayout();
    ((ISupportInitialize) this.barChartSeries).BeginInit();
    ((ISupportInitialize) this.barChart).BeginInit();
    ((ISupportInitialize) this.pieChart).BeginInit();
    this.panelLoading.SuspendLayout();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupMiniView.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.groupMiniView).Controls.Add((Control) this.panelVergbage);
    ((Control) this.groupMiniView).Controls.Add((Control) this.panelRight);
    ((Control) this.groupMiniView).Controls.Add((Control) this.labelDates);
    ((Control) this.groupMiniView).Dock = DockStyle.Fill;
    ((AppearanceBase) appearance2).AlphaLevel = (short) 230;
    ((AppearanceBase) appearance2).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance2).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance2).ForeColor = Color.White;
    ((AppearanceBase) appearance2).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).ImageBackground = (Image) resourceManager.GetObject("appearance2.ImageBackground");
    ((AppearanceBase) appearance2).ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.groupMiniView.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.groupMiniView).Location = new Point(0, 0);
    ((Control) this.groupMiniView).Name = "groupMiniView";
    ((Control) this.groupMiniView).Size = new Size(368, 256 /*0x0100*/);
    this.groupMiniView.UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.groupMiniView).TabIndex = 0;
    ((Control) this.groupMiniView).Text = "[MiniView]";
    this.groupMiniView.ViewStyle = (GroupBoxViewStyle) 2;
    this.panelVergbage.BackColor = Color.FromArgb(239, 247, 253);
    this.panelVergbage.Controls.Add((Control) this.labelLegend5);
    this.panelVergbage.Controls.Add((Control) this.labelLegend4);
    this.panelVergbage.Controls.Add((Control) this.labelLegend3);
    this.panelVergbage.Controls.Add((Control) this.labelLegend2);
    this.panelVergbage.Controls.Add((Control) this.labelLegend1);
    this.panelVergbage.Controls.Add((Control) this.labelMore);
    this.panelVergbage.Dock = DockStyle.Fill;
    this.panelVergbage.Location = new Point(160 /*0xA0*/, 48 /*0x30*/);
    this.panelVergbage.Name = "panelVergbage";
    this.panelVergbage.Size = new Size(206, 206);
    this.panelVergbage.TabIndex = 1;
    this.labelLegend5.Dock = DockStyle.Top;
    this.labelLegend5.Font = new Font("Tahoma", 7f);
    this.labelLegend5.Location = new Point(0, 128 /*0x80*/);
    this.labelLegend5.Name = "labelLegend5";
    this.labelLegend5.Size = new Size(206, 24);
    this.labelLegend5.TabIndex = 6;
    this.labelLegend5.TextAlign = ContentAlignment.MiddleCenter;
    this.labelLegend5.UseMnemonic = false;
    this.labelLegend4.Dock = DockStyle.Top;
    this.labelLegend4.Font = new Font("Tahoma", 7f);
    this.labelLegend4.Location = new Point(0, 96 /*0x60*/);
    this.labelLegend4.Name = "labelLegend4";
    this.labelLegend4.Size = new Size(206, 32 /*0x20*/);
    this.labelLegend4.TabIndex = 5;
    this.labelLegend4.TextAlign = ContentAlignment.MiddleCenter;
    this.labelLegend4.UseMnemonic = false;
    this.labelLegend3.Dock = DockStyle.Top;
    this.labelLegend3.Font = new Font("Tahoma", 7f);
    this.labelLegend3.Location = new Point(0, 64 /*0x40*/);
    this.labelLegend3.Name = "labelLegend3";
    this.labelLegend3.Size = new Size(206, 32 /*0x20*/);
    this.labelLegend3.TabIndex = 4;
    this.labelLegend3.TextAlign = ContentAlignment.MiddleCenter;
    this.labelLegend3.UseMnemonic = false;
    this.labelLegend2.Dock = DockStyle.Top;
    this.labelLegend2.Font = new Font("Tahoma", 7f);
    this.labelLegend2.Location = new Point(0, 32 /*0x20*/);
    this.labelLegend2.Name = "labelLegend2";
    this.labelLegend2.Size = new Size(206, 32 /*0x20*/);
    this.labelLegend2.TabIndex = 3;
    this.labelLegend2.TextAlign = ContentAlignment.MiddleCenter;
    this.labelLegend2.UseMnemonic = false;
    this.labelLegend1.Dock = DockStyle.Top;
    this.labelLegend1.Font = new Font("Tahoma", 7f);
    this.labelLegend1.Location = new Point(0, 0);
    this.labelLegend1.Name = "labelLegend1";
    this.labelLegend1.Size = new Size(206, 32 /*0x20*/);
    this.labelLegend1.TabIndex = 2;
    this.labelLegend1.TextAlign = ContentAlignment.MiddleCenter;
    this.labelLegend1.UseMnemonic = false;
    this.labelMore.Dock = DockStyle.Bottom;
    this.labelMore.LinkArea = new LinkArea(55, 4);
    this.labelMore.Location = new Point(0, 174);
    this.labelMore.Name = "labelMore";
    this.labelMore.Size = new Size(206, 32 /*0x20*/);
    this.labelMore.TabIndex = 1;
    this.labelMore.TabStop = true;
    this.labelMore.Text = "For additional information regarding this report click here.";
    this.labelMore.TextAlign = ContentAlignment.BottomRight;
    this.panelRight.Controls.Add((Control) this.barChartSeries);
    this.panelRight.Controls.Add((Control) this.barChart);
    this.panelRight.Controls.Add((Control) this.pieChart);
    this.panelRight.Controls.Add((Control) this.panelLoading);
    this.panelRight.Dock = DockStyle.Left;
    this.panelRight.Location = new Point(2, 48 /*0x30*/);
    this.panelRight.Name = "panelRight";
    this.panelRight.Size = new Size(158, 206);
    this.panelRight.TabIndex = 2;
    this.barChartSeries.Axis.X.Extent = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.X.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.X.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.X.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.X.Labels.SeriesLabels).Flip = false;
    this.barChartSeries.Axis.X.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.X.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.X.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.X.Labels).VerticalAlign = StringAlignment.Center;
    this.barChartSeries.Axis.X.ScrollScale.Height = 10;
    this.barChartSeries.Axis.X.ScrollScale.Visible = false;
    this.barChartSeries.Axis.X.ScrollScale.Width = 15;
    this.barChartSeries.Axis.X.TickmarkInterval = 0.0;
    this.barChartSeries.Axis.X2.Extent = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.X2.Labels).Flip = false;
    this.barChartSeries.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.X2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.X2.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.X2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.X2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.X2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.X2.Labels).VerticalAlign = StringAlignment.Center;
    this.barChartSeries.Axis.X2.ScrollScale.Height = 10;
    this.barChartSeries.Axis.X2.ScrollScale.Visible = false;
    this.barChartSeries.Axis.X2.ScrollScale.Width = 15;
    this.barChartSeries.Axis.X2.TickmarkInterval = 0.0;
    this.barChartSeries.Axis.Y.Extent = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Y.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Y.Labels).HorizontalAlign = StringAlignment.Far;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Y.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Y.Labels.SeriesLabels).Flip = false;
    this.barChartSeries.Axis.Y.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Y.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Y.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Y.Labels).VerticalAlign = StringAlignment.Center;
    this.barChartSeries.Axis.Y.ScrollScale.Height = 10;
    this.barChartSeries.Axis.Y.ScrollScale.Visible = false;
    this.barChartSeries.Axis.Y.ScrollScale.Width = 15;
    this.barChartSeries.Axis.Y.TickmarkInterval = 0.0;
    this.barChartSeries.Axis.Y.TickmarkStyle = (AxisTickStyle) 0;
    this.barChartSeries.Axis.Y2.Extent = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Y2.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Y2.Labels).HorizontalAlign = StringAlignment.Near;
    this.barChartSeries.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.00>";
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Y2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Y2.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Y2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Y2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Y2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Y2.Labels).VerticalAlign = StringAlignment.Center;
    this.barChartSeries.Axis.Y2.ScrollScale.Height = 10;
    this.barChartSeries.Axis.Y2.ScrollScale.Visible = false;
    this.barChartSeries.Axis.Y2.ScrollScale.Width = 15;
    this.barChartSeries.Axis.Y2.TickmarkInterval = 0.0;
    this.barChartSeries.Axis.Y2.TickmarkStyle = (AxisTickStyle) 0;
    this.barChartSeries.Axis.Z.Extent = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z.Labels).VerticalAlign = StringAlignment.Center;
    this.barChartSeries.Axis.Z.ScrollScale.Height = 10;
    this.barChartSeries.Axis.Z.ScrollScale.Visible = false;
    this.barChartSeries.Axis.Z.ScrollScale.Width = 15;
    this.barChartSeries.Axis.Z.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z2.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z2.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z2.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.barChartSeries.Axis.Z2.Labels).VerticalAlign = StringAlignment.Center;
    this.barChartSeries.Axis.Z2.ScrollScale.Height = 10;
    this.barChartSeries.Axis.Z2.ScrollScale.Visible = false;
    this.barChartSeries.Axis.Z2.ScrollScale.Width = 15;
    this.barChartSeries.Axis.Z2.TickmarkInterval = 0.0;
    ((Control) this.barChartSeries).BackColor = Color.FromArgb(239, 247, 253);
    this.barChartSeries.Border.Color = Color.FromArgb(239, 247, 253);
    this.barChartSeries.ColorModel.ColorBegin = Color.RosyBrown;
    this.barChartSeries.ColorModel.ColorEnd = Color.LightSteelBlue;
    this.barChartSeries.Data.ZeroAligned = true;
    ((Control) this.barChartSeries).Dock = DockStyle.Fill;
    gradientEffect1.Coloring = (GradientColoringStyle) 0;
    shadowEffect1.Angle = 45.0;
    this.barChartSeries.Effects.Effects.Add((IEffect) gradientEffect1);
    this.barChartSeries.Effects.Effects.Add((IEffect) shadowEffect1);
    ((Control) this.barChartSeries).Location = new Point(0, 0);
    ((Control) this.barChartSeries).Name = "barChartSeries";
    ((Control) this.barChartSeries).Size = new Size(158, 206);
    this.barChartSeries.TabIndex = 3;
    this.barChartSeries.TitleBottom.Extent = 0;
    this.barChartSeries.TitleBottom.Text = "";
    this.barChartSeries.TitleLeft.Extent = 0;
    this.barChartSeries.TitleLeft.Text = "";
    this.barChartSeries.TitleRight.Extent = 0;
    this.barChartSeries.TitleTop.Extent = 0;
    this.barChartSeries.TitleTop.Text = "";
    this.barChartSeries.Tooltips.FormatString = "<DATA_ROW>,<DATA_COLUMN>: <DATA_VALUE:00.00>";
    this.barChartSeries.Tooltips.UseControl = false;
    this.barChart.Axis.X.Extent = 0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.X.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChart.Axis.X.Labels).HorizontalAlign = StringAlignment.Near;
    this.barChart.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.barChart.Axis.X.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.X.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChart.Axis.X.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.barChart.Axis.X.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.X.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.barChart.Axis.X.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.barChart.Axis.X.Labels).Visible = false;
    this.barChart.Axis.X.ScrollScale.Height = 10;
    this.barChart.Axis.X.ScrollScale.Visible = false;
    this.barChart.Axis.X.ScrollScale.Width = 15;
    this.barChart.Axis.X.TickmarkInterval = 5.0;
    this.barChart.Axis.X.TickmarkStyle = (AxisTickStyle) 0;
    this.barChart.Axis.X.Visible = false;
    ((AxisLabelAppearanceBase) this.barChart.Axis.X2.Labels).Flip = false;
    this.barChart.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.barChart.Axis.X2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.X2.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChart.Axis.X2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.barChart.Axis.X2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.X2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.barChart.Axis.X2.Labels).VerticalAlign = StringAlignment.Center;
    this.barChart.Axis.X2.ScrollScale.Height = 10;
    this.barChart.Axis.X2.ScrollScale.Visible = false;
    this.barChart.Axis.X2.ScrollScale.Width = 15;
    this.barChart.Axis.X2.TickmarkInterval = 0.0;
    this.barChart.Axis.Y.Extent = 0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Y.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Y.Labels).HorizontalAlign = StringAlignment.Far;
    this.barChart.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.00>";
    ((AxisLabelAppearanceBase) this.barChart.Axis.Y.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Y.Labels.SeriesLabels).Flip = false;
    this.barChart.Axis.Y.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.barChart.Axis.Y.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Y.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Y.Labels).VerticalAlign = StringAlignment.Center;
    this.barChart.Axis.Y.ScrollScale.Height = 10;
    this.barChart.Axis.Y.ScrollScale.Visible = false;
    this.barChart.Axis.Y.ScrollScale.Width = 15;
    this.barChart.Axis.Y.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Y2.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Y2.Labels).HorizontalAlign = StringAlignment.Near;
    this.barChart.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.00>";
    ((AxisLabelAppearanceBase) this.barChart.Axis.Y2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Y2.Labels.SeriesLabels).Flip = false;
    this.barChart.Axis.Y2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.barChart.Axis.Y2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Y2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Y2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Y2.Labels).VerticalAlign = StringAlignment.Center;
    this.barChart.Axis.Y2.ScrollScale.Height = 10;
    this.barChart.Axis.Y2.ScrollScale.Visible = false;
    this.barChart.Axis.Y2.ScrollScale.Width = 15;
    this.barChart.Axis.Y2.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z.Labels).HorizontalAlign = StringAlignment.Near;
    this.barChart.Axis.Z.Labels.ItemFormatString = "<DATA_VALUE:00.00>";
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z.Labels).VerticalAlign = StringAlignment.Center;
    this.barChart.Axis.Z.ScrollScale.Height = 10;
    this.barChart.Axis.Z.ScrollScale.Visible = false;
    this.barChart.Axis.Z.ScrollScale.Width = 15;
    this.barChart.Axis.Z.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z2.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z2.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z2.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.barChart.Axis.Z2.Labels).VerticalAlign = StringAlignment.Center;
    this.barChart.Axis.Z2.ScrollScale.Height = 10;
    this.barChart.Axis.Z2.ScrollScale.Visible = false;
    this.barChart.Axis.Z2.ScrollScale.Width = 15;
    this.barChart.Axis.Z2.TickmarkInterval = 0.0;
    ((Control) this.barChart).BackColor = Color.FromArgb(239, 247, 253);
    this.barChart.Border.Color = Color.FromArgb(239, 247, 253);
    this.barChart.ColorModel.AlphaLevel = (byte) 200;
    this.barChart.ColorModel.ColorBegin = Color.DarkSeaGreen;
    this.barChart.ColorModel.ColorEnd = Color.Crimson;
    this.barChart.ColorModel.Scaling = (ColorScaling) 4;
    ((ColumnChart3DAppearance) this.barChart.ColumnChart).ColumnSpacing = 1;
    this.barChart.Data.ZeroAligned = true;
    ((Control) this.barChart).Dock = DockStyle.Fill;
    shadowEffect2.Angle = 45.0;
    gradientEffect2.Coloring = (GradientColoringStyle) 0;
    this.barChart.Effects.Effects.Add((IEffect) shadowEffect2);
    this.barChart.Effects.Effects.Add((IEffect) gradientEffect2);
    ((Control) this.barChart).ForeColor = Color.Black;
    this.barChart.Legend.FormatString = "";
    ((Control) this.barChart).Location = new Point(0, 0);
    ((Control) this.barChart).Name = "barChart";
    ((Control) this.barChart).Size = new Size(158, 206);
    this.barChart.TabIndex = 1;
    this.barChart.TitleBottom.Extent = 0;
    this.barChart.TitleBottom.Text = "";
    this.barChart.TitleLeft.Extent = 0;
    this.barChart.TitleLeft.Text = "";
    this.barChart.TitleRight.Extent = 0;
    this.barChart.TitleRight.Text = "";
    this.barChart.TitleTop.Extent = 0;
    this.barChart.TitleTop.Text = "";
    this.barChart.Tooltips.Display = (TooltipDisplay) 2;
    this.barChart.Tooltips.Font = new Font("Microsoft Sans Serif", 7.8f);
    this.barChart.Tooltips.UseControl = false;
    this.pieChart.ChartType = (ChartType) 4;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X.Labels).HorizontalAlign = StringAlignment.Near;
    this.pieChart.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X.Labels.SeriesLabels).Flip = false;
    this.pieChart.Axis.X.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X.Labels).VerticalAlign = StringAlignment.Center;
    this.pieChart.Axis.X.ScrollScale.Height = 10;
    this.pieChart.Axis.X.ScrollScale.Visible = false;
    this.pieChart.Axis.X.ScrollScale.Width = 15;
    this.pieChart.Axis.X.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X2.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X2.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X2.Labels.SeriesLabels).Flip = false;
    this.pieChart.Axis.X2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.X2.Labels).VerticalAlign = StringAlignment.Center;
    this.pieChart.Axis.X2.ScrollScale.Height = 10;
    this.pieChart.Axis.X2.ScrollScale.Visible = false;
    this.pieChart.Axis.X2.ScrollScale.Width = 15;
    this.pieChart.Axis.X2.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y.Labels).HorizontalAlign = StringAlignment.Far;
    this.pieChart.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.00>";
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y.Labels.SeriesLabels).Flip = false;
    this.pieChart.Axis.Y.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Far;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y.Labels).VerticalAlign = StringAlignment.Center;
    this.pieChart.Axis.Y.ScrollScale.Height = 10;
    this.pieChart.Axis.Y.ScrollScale.Visible = false;
    this.pieChart.Axis.Y.ScrollScale.Width = 15;
    this.pieChart.Axis.Y.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y2.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y2.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y2.Labels.SeriesLabels).Flip = false;
    this.pieChart.Axis.Y2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Y2.Labels).VerticalAlign = StringAlignment.Center;
    this.pieChart.Axis.Y2.ScrollScale.Height = 10;
    this.pieChart.Axis.Y2.ScrollScale.Visible = false;
    this.pieChart.Axis.Y2.ScrollScale.Width = 15;
    this.pieChart.Axis.Y2.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z.Labels).VerticalAlign = StringAlignment.Center;
    this.pieChart.Axis.Z.ScrollScale.Height = 10;
    this.pieChart.Axis.Z.ScrollScale.Visible = false;
    this.pieChart.Axis.Z.ScrollScale.Width = 15;
    this.pieChart.Axis.Z.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z2.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z2.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z2.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.pieChart.Axis.Z2.Labels).VerticalAlign = StringAlignment.Center;
    this.pieChart.Axis.Z2.ScrollScale.Height = 10;
    this.pieChart.Axis.Z2.ScrollScale.Visible = false;
    this.pieChart.Axis.Z2.ScrollScale.Width = 15;
    this.pieChart.Axis.Z2.TickmarkInterval = 0.0;
    ((Control) this.pieChart).BackColor = Color.FromArgb(239, 247, 253);
    this.pieChart.Border.Color = Color.FromArgb(239, 247, 253);
    this.pieChart.ColorModel.ColorBegin = Color.Wheat;
    ((Control) this.pieChart).Dock = DockStyle.Fill;
    shadowEffect3.Angle = 45.0;
    shadowEffect3.Color = Color.DimGray;
    gradientEffect3.Coloring = (GradientColoringStyle) 0;
    this.pieChart.Effects.Effects.Add((IEffect) shadowEffect3);
    this.pieChart.Effects.Effects.Add((IEffect) gradientEffect3);
    this.pieChart.EmptyChartText = "No Date Found!";
    this.pieChart.EnableCrossHair = true;
    ((Control) this.pieChart).Location = new Point(0, 0);
    ((Control) this.pieChart).Name = "pieChart";
    this.pieChart.PieChart.Labels.FormatString = "";
    this.pieChart.PieChart.Labels.LeaderLinesVisible = false;
    this.pieChart.PieChart.RadiusFactor = 100;
    ((Control) this.pieChart).Size = new Size(158, 206);
    this.pieChart.TabIndex = 0;
    this.pieChart.TitleBottom.Extent = 0;
    this.pieChart.TitleBottom.Text = "";
    this.pieChart.TitleLeft.Extent = 0;
    this.pieChart.TitleRight.Extent = 0;
    this.pieChart.TitleTop.Extent = 0;
    this.pieChart.TitleTop.Text = "";
    this.pieChart.ChartDataClicked += new ChartDataClickedEventHandler(this.pieChart_ChartDataClicked);
    this.panelLoading.BackColor = Color.FromArgb(239, 247, 253);
    this.panelLoading.Controls.Add((Control) this.label1);
    this.panelLoading.Dock = DockStyle.Fill;
    this.panelLoading.Location = new Point(0, 0);
    this.panelLoading.Name = "panelLoading";
    this.panelLoading.Size = new Size(158, 206);
    this.panelLoading.TabIndex = 2;
    this.label1.Location = new Point(40, 72);
    this.label1.Name = "label1";
    this.label1.TabIndex = 0;
    this.label1.Text = "Loading...";
    this.label1.TextAlign = ContentAlignment.MiddleCenter;
    this.labelDates.BackColor = Color.FromArgb(239, 247, 253);
    this.labelDates.Dock = DockStyle.Top;
    this.labelDates.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.labelDates.ForeColor = Color.DarkSlateBlue;
    this.labelDates.Location = new Point(2, 22);
    this.labelDates.Name = "labelDates";
    this.labelDates.Size = new Size(364, 26);
    this.labelDates.TabIndex = 0;
    this.labelDates.Text = "01/01/2001 through 12/31/2004";
    this.labelDates.TextAlign = ContentAlignment.MiddleCenter;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.groupMiniView);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (AnalysisMiniView);
    this.Size = new Size(368, 256 /*0x0100*/);
    ((ISupportInitialize) this.groupMiniView).EndInit();
    ((Control) this.groupMiniView).ResumeLayout(false);
    this.panelVergbage.ResumeLayout(false);
    this.panelRight.ResumeLayout(false);
    ((ISupportInitialize) this.barChartSeries).EndInit();
    ((ISupportInitialize) this.barChart).EndInit();
    ((ISupportInitialize) this.pieChart).EndInit();
    this.panelLoading.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public DataSet Data
  {
    get
    {
      if (this._dataSet == null)
        this._dataSet = new DataSet();
      return this._dataSet;
    }
  }

  private void SetGroupText()
  {
    switch (this._reportType)
    {
      case Utilities.AnalysisReportType.BreakoutByExpense:
        ((Control) this.groupMiniView).Text = "Breakout By Expense";
        break;
      case Utilities.AnalysisReportType.CostCenterExpense:
        ((Control) this.groupMiniView).Text = "Expenses by Cost Center";
        break;
      case Utilities.AnalysisReportType.CostCenterExpenseIncome:
        ((Control) this.groupMiniView).Text = "Expenses vs Income by Cost Center";
        break;
      case Utilities.AnalysisReportType.EntityExpenses:
        ((Control) this.groupMiniView).Text = "Expenses by Entity";
        break;
      case Utilities.AnalysisReportType.OfficeLocationExpense:
        ((Control) this.groupMiniView).Text = "Expenses by Office Location";
        break;
      case Utilities.AnalysisReportType.OfficeLocationExpenseIncome:
        ((Control) this.groupMiniView).Text = "Expenses vs Income by Office Location";
        break;
      case Utilities.AnalysisReportType.UnderwriterExpenseIncome:
        ((Control) this.groupMiniView).Text = "Expenses vs Income by Underwriter";
        break;
      default:
        ((Control) this.groupMiniView).Text = "Invalid Report Type!";
        break;
    }
  }

  private void LoadData()
  {
    this.panelLoading.Visible = true;
    this.panelLoading.BringToFront();
    Thread thread;
    switch (this._reportType)
    {
      case Utilities.AnalysisReportType.BreakoutByExpense:
        thread = new Thread(new ThreadStart(this.LoadBreakoutByExpense));
        break;
      case Utilities.AnalysisReportType.BreakoutByExpenseCategory:
        return;
      case Utilities.AnalysisReportType.CostCenterExpense:
        thread = new Thread(new ThreadStart(this.LoadCostCenterExpenses));
        break;
      case Utilities.AnalysisReportType.CostCenterExpenseIncome:
        thread = new Thread(new ThreadStart(this.LoadIncomeExpenseCostCenter));
        break;
      case Utilities.AnalysisReportType.EntityExpenses:
        thread = new Thread(new ThreadStart(this.LoadPayeeExpenses));
        break;
      case Utilities.AnalysisReportType.OfficeLocationExpense:
        thread = new Thread(new ThreadStart(this.LoadOfficeLocationExpenses));
        break;
      case Utilities.AnalysisReportType.OfficeLocationExpenseIncome:
        thread = new Thread(new ThreadStart(this.LoadIncomeExpenseOfficeLocation));
        break;
      case Utilities.AnalysisReportType.UnderwriterExpenseIncome:
        thread = new Thread(new ThreadStart(this.LoadIncomeExpenseUnderwriter));
        break;
      default:
        return;
    }
    thread.Name = "MiniLoadData";
    thread.IsBackground = true;
    thread.Start();
  }

  private void LoadOfficeLocationExpenses()
  {
    using (SqlCommand selectCommand = new SqlCommand("spfin_Analysis_ExpensesOfficeLocation", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      selectCommand.CommandType = CommandType.StoredProcedure;
      selectCommand.Parameters.AddWithValue("@dateTo", (object) DateTime.Now);
      Database.SafeDataAdapterFill(new SqlDataAdapter(selectCommand), this.Data);
      if (this.Data == null || this.Data.Tables.Count == 0 || this.Data.Tables[0].Rows.Count == 0)
        return;
      DataSet dataSet = new DataSet();
      DataTable table = new DataTable("ChartData");
      table.Columns.Add(new DataColumn("OfficeLocation", typeof (string)));
      table.Columns.Add(new DataColumn("Amount", typeof (Decimal)));
      foreach (DataRow row in (InternalDataCollectionBase) this.Data.Tables[0].Rows)
        table.Rows.Add((object) row["location"].ToString(), row["amount"]);
      dataSet.Tables.Add(table);
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new AnalysisMiniView.SetChartDataSourceHandler(this.SetChartDataSource), (object) dataSet);
    }
  }

  private void LoadCostCenterExpenses()
  {
    using (SqlCommand selectCommand = new SqlCommand("spfin_Analysis_ExpensesCostCenter", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      selectCommand.CommandType = CommandType.StoredProcedure;
      selectCommand.Parameters.AddWithValue("@dateTo", (object) DateTime.Now);
      selectCommand.Parameters.AddWithValue("@glCompanyId", (object) this._glCompanyId);
      Database.SafeDataAdapterFill(new SqlDataAdapter(selectCommand), this.Data);
      if (this.Data == null || this.Data.Tables.Count == 0 || this.Data.Tables[0].Rows.Count == 0)
        return;
      DataSet dataSet = new DataSet();
      DataTable table = new DataTable("ChartData");
      foreach (DataRow row in (InternalDataCollectionBase) this.Data.Tables[0].Rows)
        table.Columns.Add(new DataColumn(row["groupname"].ToString(), typeof (Decimal)));
      DataRow row1 = table.NewRow();
      for (int index = 0; index < this.Data.Tables[0].Rows.Count; ++index)
        row1[this.Data.Tables[0].Rows[index]["groupName"].ToString()] = (object) Decimal.Parse(this.Data.Tables[0].Rows[index]["amount"].ToString());
      table.Rows.Add(row1);
      dataSet.Tables.Add(table);
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new AnalysisMiniView.SetChartDataSourceHandler(this.SetChartDataSource), (object) dataSet);
    }
  }

  private void LoadPayeeExpenses()
  {
    using (SqlCommand selectCommand = new SqlCommand("spFin_Analysis_ExpensePayees", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      selectCommand.CommandType = CommandType.StoredProcedure;
      selectCommand.Parameters.AddWithValue("@dateTo", (object) DateTime.Now);
      selectCommand.Parameters.AddWithValue("@glCompanyId", (object) this._glCompanyId);
      Database.SafeDataAdapterFill(new SqlDataAdapter(selectCommand), this.Data);
      if (this.Data == null || this.Data.Tables.Count == 0 || this.Data.Tables[0].Rows.Count == 0)
        return;
      DataSet dataSet = new DataSet();
      DataTable table = new DataTable("ChartData");
      for (int index = 0; index < this.Data.Tables[0].Rows.Count && index < 5; ++index)
        table.Columns.Add(new DataColumn(this.Data.Tables[0].Rows[index]["payee"].ToString(), typeof (Decimal)));
      DataRow row = table.NewRow();
      for (int index = 0; index < this.Data.Tables[0].Rows.Count && index < 5; ++index)
        row[this.Data.Tables[0].Rows[index]["payee"].ToString()] = (object) Decimal.Parse(this.Data.Tables[0].Rows[index]["amount"].ToString());
      table.Rows.Add(row);
      dataSet.Tables.Add(table);
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new AnalysisMiniView.SetChartDataSourceHandler(this.SetChartDataSource), (object) dataSet);
    }
  }

  private void LoadIncomeExpenseOfficeLocation()
  {
    using (SqlCommand selectCommand = new SqlCommand("spFin_Analysis_IncomeExpenseOfficeLocation", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      selectCommand.CommandType = CommandType.StoredProcedure;
      selectCommand.Parameters.AddWithValue("@dateTo", (object) DateTime.Now);
      selectCommand.Parameters.AddWithValue("@glCompanyId", (object) this._glCompanyId);
      Database.SafeDataAdapterFill(new SqlDataAdapter(selectCommand), this.Data);
      if (this.Data == null || this.Data.Tables.Count == 0 || this.Data.Tables[0].Rows.Count == 0)
        return;
      DataSet dataSet = new DataSet();
      DataTable table = new DataTable("ChartData");
      table.Columns.Add(new DataColumn("Location", typeof (string)));
      table.Columns.Add(new DataColumn("Income", typeof (Decimal)));
      table.Columns.Add(new DataColumn("Expense", typeof (Decimal)));
      for (int index = 0; index < this.Data.Tables[0].Rows.Count && index < 5; ++index)
        table.Rows.Add((object) this.Data.Tables[0].Rows[index]["Location"].ToString(), (object) Decimal.Parse(this.Data.Tables[0].Rows[index]["Income"].ToString()), (object) Decimal.Parse(this.Data.Tables[0].Rows[index]["Expenses"].ToString()));
      dataSet.Tables.Add(table);
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new AnalysisMiniView.SetChartDataSourceHandler(this.SetChartDataSource), (object) dataSet);
    }
  }

  private void LoadIncomeExpenseCostCenter()
  {
    using (SqlCommand selectCommand = new SqlCommand("spFin_Analysis_IncomeExpenseCostCenter", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      selectCommand.CommandType = CommandType.StoredProcedure;
      selectCommand.Parameters.AddWithValue("@dateTo", (object) DateTime.Now);
      selectCommand.Parameters.AddWithValue("@glCompanyId", (object) this._glCompanyId);
      Database.SafeDataAdapterFill(new SqlDataAdapter(selectCommand), this.Data);
      if (this.Data == null || this.Data.Tables.Count == 0 || this.Data.Tables[0].Rows.Count == 0)
        return;
      DataSet dataSet = new DataSet();
      DataTable table = new DataTable("ChartData");
      table.Columns.Add(new DataColumn("GroupName", typeof (string)));
      table.Columns.Add(new DataColumn("Income", typeof (Decimal)));
      table.Columns.Add(new DataColumn("Expense", typeof (Decimal)));
      for (int index = 0; index < this.Data.Tables[0].Rows.Count && index < 5; ++index)
        table.Rows.Add((object) this.Data.Tables[0].Rows[index]["GroupName"].ToString(), (object) Decimal.Parse(this.Data.Tables[0].Rows[index]["Income"].ToString()), (object) Decimal.Parse(this.Data.Tables[0].Rows[index]["Expenses"].ToString()));
      dataSet.Tables.Add(table);
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new AnalysisMiniView.SetChartDataSourceHandler(this.SetChartDataSource), (object) dataSet);
    }
  }

  private void LoadIncomeExpenseUnderwriter()
  {
    using (SqlCommand selectCommand = new SqlCommand("spFin_Analysis_IncomeExpenseUnderwriter", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      selectCommand.CommandType = CommandType.StoredProcedure;
      selectCommand.Parameters.AddWithValue("@dateTo", (object) DateTime.Now);
      selectCommand.Parameters.AddWithValue("@glCompanyId", (object) this._glCompanyId);
      Database.SafeDataAdapterFill(new SqlDataAdapter(selectCommand), this.Data);
      if (this.Data == null || this.Data.Tables.Count == 0 || this.Data.Tables[0].Rows.Count == 0)
        return;
      DataSet dataSet = new DataSet();
      DataTable table = new DataTable("ChartData");
      table.Columns.Add(new DataColumn("GroupName", typeof (string)));
      table.Columns.Add(new DataColumn("Income", typeof (Decimal)));
      table.Columns.Add(new DataColumn("Expense", typeof (Decimal)));
      for (int index = 0; index < this.Data.Tables[0].Rows.Count && index < 5; ++index)
        table.Rows.Add((object) this.Data.Tables[0].Rows[index]["Underwriter"].ToString(), (object) Decimal.Parse(this.Data.Tables[0].Rows[index]["Income"].ToString()), (object) Decimal.Parse(this.Data.Tables[0].Rows[index]["Expenses"].ToString()));
      dataSet.Tables.Add(table);
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new AnalysisMiniView.SetChartDataSourceHandler(this.SetChartDataSource), (object) dataSet);
    }
  }

  private void LoadBreakoutByExpense()
  {
    using (SqlCommand selectCommand = new SqlCommand("spfin_Analysis_Expenses", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      selectCommand.CommandType = CommandType.StoredProcedure;
      selectCommand.Parameters.AddWithValue("@dateTo", (object) DateTime.Now);
      selectCommand.Parameters.AddWithValue("@glcompanyid", (object) this._glCompanyId);
      Database.SafeDataAdapterFill(new SqlDataAdapter(selectCommand), this.Data);
      if (this.Data == null || this.Data.Tables.Count == 0 || this.Data.Tables[0].Rows.Count == 0)
        return;
      DataSet dataSet = new DataSet();
      DataTable table = new DataTable("ChartData");
      table.Columns.Add(new DataColumn("OfficeLocation", typeof (string)));
      table.Columns.Add(new DataColumn("Amount", typeof (Decimal)));
      for (int index = 0; index < this.Data.Tables[0].Rows.Count && index < 5; ++index)
        table.Rows.Add((object) this.Data.Tables[0].Rows[index]["ExpenseName"].ToString(), this.Data.Tables[0].Rows[index]["amount"]);
      dataSet.Tables.Add(table);
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new AnalysisMiniView.SetChartDataSourceHandler(this.SetChartDataSource), (object) dataSet);
    }
  }

  private void SetChartDataSource(DataSet ds)
  {
    Label labelDates = this.labelDates;
    DateTime dateTime = DateTime.Parse(this.Data.Tables[1].Rows[0][0].ToString());
    string shortDateString1 = dateTime.ToShortDateString();
    dateTime = DateTime.Parse(this.Data.Tables[1].Rows[0][1].ToString());
    string shortDateString2 = dateTime.ToShortDateString();
    string str1 = $"{shortDateString1} through {shortDateString2}";
    labelDates.Text = str1;
    switch (this._chartType)
    {
      case Utilities.AnalysisChartType.BarChart:
        this.barChart.DataSource = (object) ds;
        for (int index = 0; index < this.Data.Tables[0].Rows.Count && index < 5; ++index)
        {
          switch (index)
          {
            case 0:
              this.labelLegend1.Text = $"{this.Data.Tables[0].Rows[index][1].ToString()}-{Decimal.Parse(this.Data.Tables[0].Rows[index]["Amount"].ToString()).ToString("c")}";
              break;
            case 1:
              this.labelLegend2.Text = $"{this.Data.Tables[0].Rows[index][1].ToString()}-{Decimal.Parse(this.Data.Tables[0].Rows[index]["Amount"].ToString()).ToString("c")}";
              break;
            case 2:
              this.labelLegend3.Text = $"{this.Data.Tables[0].Rows[index][1].ToString()}-{Decimal.Parse(this.Data.Tables[0].Rows[index]["Amount"].ToString()).ToString("c")}";
              break;
            case 3:
              this.labelLegend4.Text = $"{this.Data.Tables[0].Rows[index][1].ToString()}-{Decimal.Parse(this.Data.Tables[0].Rows[index]["Amount"].ToString()).ToString("c")}";
              break;
            case 4:
              this.labelLegend5.Text = $"{this.Data.Tables[0].Rows[index][1].ToString()}-{Decimal.Parse(this.Data.Tables[0].Rows[index]["Amount"].ToString()).ToString("c")}";
              break;
          }
        }
        this.barChart.BringToFront();
        this.panelVergbage.BringToFront();
        break;
      case Utilities.AnalysisChartType.BarChartWithSeries:
        this.barChartSeries.DataSource = (object) ds;
        for (int index = 0; index < this.Data.Tables[0].Rows.Count && index < 5; ++index)
        {
          switch (index)
          {
            case 0:
              this.labelLegend1.Text = $"{this.Data.Tables[0].Rows[index][1].ToString()}\nIncome: {Decimal.Parse(this.Data.Tables[0].Rows[index]["Income"].ToString()).ToString("c")} Expenses: {Decimal.Parse(this.Data.Tables[0].Rows[index]["Expenses"].ToString()).ToString("c")}";
              break;
            case 1:
              this.labelLegend2.Text = $"{this.Data.Tables[0].Rows[index][1].ToString()}\nIncome: {Decimal.Parse(this.Data.Tables[0].Rows[index]["Income"].ToString()).ToString("c")} Expenses: {Decimal.Parse(this.Data.Tables[0].Rows[index]["Expenses"].ToString()).ToString("c")}";
              break;
            case 2:
              this.labelLegend3.Text = $"{this.Data.Tables[0].Rows[index][1].ToString()}\nIncome: {Decimal.Parse(this.Data.Tables[0].Rows[index]["Income"].ToString()).ToString("c")} Expenses: {Decimal.Parse(this.Data.Tables[0].Rows[index]["Expenses"].ToString()).ToString("c")}";
              break;
            case 3:
              this.labelLegend4.Text = $"{this.Data.Tables[0].Rows[index][1].ToString()}\nIncome: {Decimal.Parse(this.Data.Tables[0].Rows[index]["Income"].ToString()).ToString("c")} Expenses: {Decimal.Parse(this.Data.Tables[0].Rows[index]["Expenses"].ToString()).ToString("c")}";
              break;
            case 4:
              this.labelLegend5.Text = $"{this.Data.Tables[0].Rows[index][1].ToString()}\nIncome: {Decimal.Parse(this.Data.Tables[0].Rows[index]["Income"].ToString()).ToString("c")} Expenses: {Decimal.Parse(this.Data.Tables[0].Rows[index]["Expenses"].ToString()).ToString("c")}";
              break;
          }
        }
        this.barChartSeries.BringToFront();
        this.panelVergbage.BringToFront();
        break;
      case Utilities.AnalysisChartType.PieChart:
        this.pieChart.DataSource = (object) ds;
        Decimal num;
        for (int index = 0; index < ds.Tables[0].Rows.Count && index < 5; ++index)
        {
          switch (index)
          {
            case 0:
              Label labelLegend1 = this.labelLegend1;
              string str2 = ds.Tables[0].Rows[index][0].ToString();
              num = Decimal.Parse(ds.Tables[0].Rows[index][1].ToString());
              string str3 = num.ToString("c");
              string str4 = $"{str2}-{str3}";
              labelLegend1.Text = str4;
              break;
            case 1:
              Label labelLegend2 = this.labelLegend2;
              string str5 = ds.Tables[0].Rows[index][0].ToString();
              num = Decimal.Parse(ds.Tables[0].Rows[index][1].ToString());
              string str6 = num.ToString("c");
              string str7 = $"{str5}-{str6}";
              labelLegend2.Text = str7;
              break;
            case 2:
              Label labelLegend3 = this.labelLegend3;
              string str8 = ds.Tables[0].Rows[index][0].ToString();
              num = Decimal.Parse(ds.Tables[0].Rows[index][1].ToString());
              string str9 = num.ToString("c");
              string str10 = $"{str8}-{str9}";
              labelLegend3.Text = str10;
              break;
            case 3:
              Label labelLegend4 = this.labelLegend4;
              string str11 = ds.Tables[0].Rows[index][0].ToString();
              num = Decimal.Parse(ds.Tables[0].Rows[index][1].ToString());
              string str12 = num.ToString("c");
              string str13 = $"{str11}-{str12}";
              labelLegend4.Text = str13;
              break;
            case 4:
              Label labelLegend5 = this.labelLegend5;
              string str14 = ds.Tables[0].Rows[index][0].ToString();
              num = Decimal.Parse(ds.Tables[0].Rows[index][1].ToString());
              string str15 = num.ToString("c");
              string str16 = $"{str14}-{str15}";
              labelLegend5.Text = str16;
              break;
          }
        }
        this.pieChart.BringToFront();
        this.panelVergbage.BringToFront();
        break;
    }
    this.panelLoading.Visible = false;
  }

  private void pieChart_ChartDataClicked(object sender, ChartDataEventArgs e)
  {
  }

  private delegate void SetChartDataSourceHandler(DataSet ds);
}

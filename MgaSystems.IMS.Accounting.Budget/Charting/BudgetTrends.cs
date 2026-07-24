// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Budget.Charting.BudgetTrends
// Assembly: MgaSystems.IMS.Accounting.Budget, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6BC25DF1-D5D5-4DAC-8821-336F88BA639E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Budget.dll

using Infragistics.UltraChart.Resources;
using Infragistics.UltraChart.Resources.Appearance;
using Infragistics.UltraChart.Shared.Styles;
using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using MGASystems.IMS.Accounting.Budget.Datasets;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Budget.Charting;

public class BudgetTrends : UserControl
{
  private dsGLAccountBudgets _data;
  private IContainer components;
  private Infragistics.Win.UltraWinChart.UltraChart ultraChart1;
  private dsBudgetTrends dsBudgetTrends1;
  private MGACheckBox checkQ1Revision;
  private MGACheckBox checkQ2Revision;
  private MGACheckBox checkQ3Revision;
  private MGACheckBox checkQ4Revision;

  public BudgetTrends() => this.InitializeComponent();

  internal void DisplayData(dsGLAccountBudgets data)
  {
    this._data = data;
    DataTable table = this._data.BudgetDetailRevision.DefaultView.ToTable(true, "FiscalPeriod");
    this.dsBudgetTrends1.Clear();
    this.dsBudgetTrends1.Trends.AddTrendsRow("Budget", 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M);
    this.dsBudgetTrends1.Trends.AddTrendsRow("Actual", 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M);
    for (int index = 0; index < table.Rows.Count; ++index)
    {
      this.dsBudgetTrends1.Trends.Columns[index + 1].ColumnName = table.Rows[index]["FiscalPeriod"].ToString();
      this.dsBudgetTrends1.Trends[0][index + 1] = this._data.BudgetDetailRevision.Compute("SUM(Original)", $"FiscalPeriod = '{table.Rows[index]["FiscalPeriod"].ToString()}'");
      this.dsBudgetTrends1.Trends[1][index + 1] = this._data.BudgetDetailRevision.Compute("SUM(Actual)", $"FiscalPeriod = '{table.Rows[index]["FiscalPeriod"].ToString()}'");
    }
  }

  private void checkQ1Revision_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.checkQ1Revision).Checked)
    {
      DataTable table = this._data.BudgetDetailRevision.DefaultView.ToTable(true, "FiscalPeriod");
      dsBudgetTrends.TrendsRow trendsRow = this.dsBudgetTrends1.Trends.AddTrendsRow("Q1 Rev.", 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M);
      for (int index = 0; index < table.Rows.Count; ++index)
        trendsRow[index + 1] = this._data.BudgetDetailRevision.Compute("SUM(Q1)", $"FiscalPeriod = '{table.Rows[index]["FiscalPeriod"].ToString()}'");
    }
    else
    {
      foreach (dsBudgetTrends.TrendsRow row in (InternalDataCollectionBase) this.dsBudgetTrends1.Trends.Rows)
      {
        if (row[0].ToString() == "Q1 Rev.")
        {
          row.Delete();
          ((Control) this.ultraChart1).Refresh();
          break;
        }
      }
    }
  }

  private void checkQ2Revision_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.checkQ2Revision).Checked)
    {
      DataTable table = this._data.BudgetDetailRevision.DefaultView.ToTable(true, "FiscalPeriod");
      dsBudgetTrends.TrendsRow trendsRow = this.dsBudgetTrends1.Trends.AddTrendsRow("Q2 Rev.", 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M);
      for (int index = 0; index < table.Rows.Count; ++index)
        trendsRow[index + 1] = this._data.BudgetDetailRevision.Compute("SUM(Q2)", $"FiscalPeriod = '{table.Rows[index]["FiscalPeriod"].ToString()}'");
    }
    else
    {
      foreach (dsBudgetTrends.TrendsRow row in (InternalDataCollectionBase) this.dsBudgetTrends1.Trends.Rows)
      {
        if (row[0].ToString() == "Q2 Rev.")
        {
          row.Delete();
          ((Control) this.ultraChart1).Refresh();
          break;
        }
      }
    }
  }

  private void checkQ3Revision_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.checkQ3Revision).Checked)
    {
      DataTable table = this._data.BudgetDetailRevision.DefaultView.ToTable(true, "FiscalPeriod");
      dsBudgetTrends.TrendsRow trendsRow = this.dsBudgetTrends1.Trends.AddTrendsRow("Q3 Rev.", 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M);
      for (int index = 0; index < table.Rows.Count; ++index)
        trendsRow[index + 1] = this._data.BudgetDetailRevision.Compute("SUM(Q3)", $"FiscalPeriod = '{table.Rows[index]["FiscalPeriod"].ToString()}'");
    }
    else
    {
      foreach (dsBudgetTrends.TrendsRow row in (InternalDataCollectionBase) this.dsBudgetTrends1.Trends.Rows)
      {
        if (row[0].ToString() == "Q3 Rev.")
        {
          row.Delete();
          ((Control) this.ultraChart1).Refresh();
          break;
        }
      }
    }
  }

  private void checkQ4Revision_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.checkQ4Revision).Checked)
    {
      DataTable table = this._data.BudgetDetailRevision.DefaultView.ToTable(true, "FiscalPeriod");
      dsBudgetTrends.TrendsRow trendsRow = this.dsBudgetTrends1.Trends.AddTrendsRow("Q4 Rev.", 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M, 0M);
      for (int index = 0; index < table.Rows.Count; ++index)
        trendsRow[index + 1] = this._data.BudgetDetailRevision.Compute("SUM(Q4)", $"FiscalPeriod = '{table.Rows[index]["FiscalPeriod"].ToString()}'");
    }
    else
    {
      foreach (dsBudgetTrends.TrendsRow row in (InternalDataCollectionBase) this.dsBudgetTrends1.Trends.Rows)
      {
        if (row[0].ToString() == "Q4 Rev.")
        {
          row.Delete();
          ((Control) this.ultraChart1).Refresh();
          break;
        }
      }
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    PaintElement paintElement = new PaintElement();
    GradientEffect gradientEffect = new GradientEffect();
    ShadowEffect shadowEffect = new ShadowEffect();
    Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
    this.ultraChart1 = new Infragistics.Win.UltraWinChart.UltraChart();
    this.dsBudgetTrends1 = new dsBudgetTrends();
    this.checkQ1Revision = new MGACheckBox();
    this.checkQ2Revision = new MGACheckBox();
    this.checkQ3Revision = new MGACheckBox();
    this.checkQ4Revision = new MGACheckBox();
    ((ISupportInitialize) this.ultraChart1).BeginInit();
    this.dsBudgetTrends1.BeginInit();
    ((ISupportInitialize) this.checkQ1Revision).BeginInit();
    ((ISupportInitialize) this.checkQ2Revision).BeginInit();
    ((ISupportInitialize) this.checkQ3Revision).BeginInit();
    ((ISupportInitialize) this.checkQ4Revision).BeginInit();
    this.SuspendLayout();
    this.ultraChart1.ChartType = (ChartType) 3;
    this.ultraChart1.Axis.BackColor = Color.FromArgb((int) byte.MaxValue, 248, 220);
    paintElement.ElementType = (PaintElementType) 0;
    paintElement.Fill = Color.FromArgb((int) byte.MaxValue, 248, 220);
    this.ultraChart1.Axis.PE = paintElement;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels).HorizontalAlign = StringAlignment.Near;
    this.ultraChart1.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels.SeriesLabels).FontColor = Color.DimGray;
    this.ultraChart1.Axis.X.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels).VerticalAlign = StringAlignment.Center;
    this.ultraChart1.Axis.X.LineThickness = 1;
    this.ultraChart1.Axis.X.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.X.MajorGridLines.Color = Color.Gainsboro;
    this.ultraChart1.Axis.X.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.X.MajorGridLines.Visible = true;
    this.ultraChart1.Axis.X.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.X.MinorGridLines.Color = Color.LightGray;
    this.ultraChart1.Axis.X.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.X.MinorGridLines.Visible = false;
    this.ultraChart1.Axis.X.TickmarkStyle = (AxisTickStyle) 2;
    this.ultraChart1.Axis.X.Visible = true;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels).HorizontalAlign = StringAlignment.Far;
    this.ultraChart1.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels.SeriesLabels).FontColor = Color.Gray;
    this.ultraChart1.Axis.X2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Far;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels).Visible = false;
    this.ultraChart1.Axis.X2.LineThickness = 1;
    this.ultraChart1.Axis.X2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.X2.MajorGridLines.Color = Color.Gainsboro;
    this.ultraChart1.Axis.X2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.X2.MajorGridLines.Visible = true;
    this.ultraChart1.Axis.X2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.X2.MinorGridLines.Color = Color.LightGray;
    this.ultraChart1.Axis.X2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.X2.MinorGridLines.Visible = false;
    this.ultraChart1.Axis.X2.TickmarkStyle = (AxisTickStyle) 2;
    this.ultraChart1.Axis.X2.Visible = false;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels).HorizontalAlign = StringAlignment.Far;
    this.ultraChart1.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:C>";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).FontColor = Color.DimGray;
    this.ultraChart1.Axis.Y.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Far;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels).VerticalAlign = StringAlignment.Center;
    this.ultraChart1.Axis.Y.LineThickness = 1;
    this.ultraChart1.Axis.Y.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.Y.MajorGridLines.Color = Color.Gainsboro;
    this.ultraChart1.Axis.Y.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.Y.MajorGridLines.Visible = true;
    this.ultraChart1.Axis.Y.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.Y.MinorGridLines.Color = Color.LightGray;
    this.ultraChart1.Axis.Y.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.Y.MinorGridLines.Visible = false;
    this.ultraChart1.Axis.Y.TickmarkInterval = 10.0;
    this.ultraChart1.Axis.Y.TickmarkStyle = (AxisTickStyle) 2;
    this.ultraChart1.Axis.Y.Visible = true;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels).HorizontalAlign = StringAlignment.Near;
    this.ultraChart1.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels.SeriesLabels).FontColor = Color.Gray;
    this.ultraChart1.Axis.Y2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels).Visible = false;
    this.ultraChart1.Axis.Y2.LineThickness = 1;
    this.ultraChart1.Axis.Y2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.Y2.MajorGridLines.Color = Color.Gainsboro;
    this.ultraChart1.Axis.Y2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.Y2.MajorGridLines.Visible = true;
    this.ultraChart1.Axis.Y2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.Y2.MinorGridLines.Color = Color.LightGray;
    this.ultraChart1.Axis.Y2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.Y2.MinorGridLines.Visible = false;
    this.ultraChart1.Axis.Y2.TickmarkInterval = 10.0;
    this.ultraChart1.Axis.Y2.TickmarkStyle = (AxisTickStyle) 2;
    this.ultraChart1.Axis.Y2.Visible = false;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z.Labels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z.Labels).HorizontalAlign = StringAlignment.Near;
    this.ultraChart1.Axis.Z.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z.Labels.SeriesLabels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z.Labels).Visible = false;
    this.ultraChart1.Axis.Z.LineThickness = 1;
    this.ultraChart1.Axis.Z.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.Z.MajorGridLines.Color = Color.Gainsboro;
    this.ultraChart1.Axis.Z.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.Z.MajorGridLines.Visible = true;
    this.ultraChart1.Axis.Z.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.Z.MinorGridLines.Color = Color.LightGray;
    this.ultraChart1.Axis.Z.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.Z.MinorGridLines.Visible = false;
    this.ultraChart1.Axis.Z.TickmarkStyle = (AxisTickStyle) 2;
    this.ultraChart1.Axis.Z.Visible = false;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z2.Labels).HorizontalAlign = StringAlignment.Near;
    this.ultraChart1.Axis.Z2.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z2.Labels.SeriesLabels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z2.Labels).Visible = false;
    this.ultraChart1.Axis.Z2.LineThickness = 1;
    this.ultraChart1.Axis.Z2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.Z2.MajorGridLines.Color = Color.Gainsboro;
    this.ultraChart1.Axis.Z2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.Z2.MajorGridLines.Visible = true;
    this.ultraChart1.Axis.Z2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.Z2.MinorGridLines.Color = Color.LightGray;
    this.ultraChart1.Axis.Z2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.Z2.MinorGridLines.Visible = false;
    this.ultraChart1.Axis.Z2.TickmarkStyle = (AxisTickStyle) 2;
    this.ultraChart1.Axis.Z2.Visible = false;
    ((Control) this.ultraChart1).BackColor = Color.Transparent;
    ((Control) this.ultraChart1).BackgroundImageLayout = ImageLayout.Center;
    this.ultraChart1.ColorModel.AlphaLevel = (byte) 150;
    this.ultraChart1.ColorModel.ColorBegin = Color.Yellow;
    this.ultraChart1.ColorModel.ColorEnd = Color.DarkBlue;
    this.ultraChart1.ColorModel.ModelStyle = (ColorModels) 4;
    this.ultraChart1.DataSource = (object) this.dsBudgetTrends1;
    ((Control) this.ultraChart1).Dock = DockStyle.Fill;
    shadowEffect.Angle = 5.0;
    shadowEffect.Depth = 3;
    this.ultraChart1.Effects.Effects.Add((IEffect) gradientEffect);
    this.ultraChart1.Effects.Effects.Add((IEffect) shadowEffect);
    this.ultraChart1.EmptyChartText = "";
    this.ultraChart1.Legend.BackgroundColor = Color.Transparent;
    this.ultraChart1.Legend.BorderColor = Color.Transparent;
    this.ultraChart1.Legend.DataAssociation = (ChartTypeData) 2;
    this.ultraChart1.Legend.Font = new Font("Tahoma", 8.25f);
    this.ultraChart1.Legend.SpanPercentage = 10;
    this.ultraChart1.Legend.Visible = true;
    ((Control) this.ultraChart1).Location = new Point(0, 0);
    ((Control) this.ultraChart1).Name = "ultraChart1";
    ((Control) this.ultraChart1).Size = new Size(1035, 521);
    this.ultraChart1.TabIndex = 0;
    this.ultraChart1.TextRenderingHint = TextRenderingHint.AntiAlias;
    this.ultraChart1.TitleTop.Font = new Font("Tahoma", 10f);
    this.ultraChart1.TitleTop.Text = "Budget Trends";
    this.ultraChart1.Tooltips.HighlightFillColor = Color.DimGray;
    this.ultraChart1.Tooltips.HighlightOutlineColor = Color.DarkGray;
    this.dsBudgetTrends1.DataSetName = "dsBudgetTrends";
    this.dsBudgetTrends1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkQ1Revision).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.checkQ1Revision).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkQ1Revision).Location = new Point(393, 3);
    this.checkQ1Revision.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkQ1Revision).Name = "checkQ1Revision";
    ((Control) this.checkQ1Revision).Size = new Size(120, 20);
    ((Control) this.checkQ1Revision).TabIndex = 1;
    ((Control) this.checkQ1Revision).Text = "Show Q1 Revision";
    ((UltraControlBase) this.checkQ1Revision).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkQ1Revision).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraToggleEditorBase) this.checkQ1Revision).CheckedChanged += new EventHandler(this.checkQ1Revision_CheckedChanged);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkQ2Revision).Appearance = (AppearanceBase) appearance2;
    ((UltraToggleEditorBase) this.checkQ2Revision).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkQ2Revision).Location = new Point(519, 3);
    this.checkQ2Revision.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkQ2Revision).Name = "checkQ2Revision";
    ((Control) this.checkQ2Revision).Size = new Size(120, 20);
    ((Control) this.checkQ2Revision).TabIndex = 2;
    ((Control) this.checkQ2Revision).Text = "Show Q2 Revision";
    ((UltraControlBase) this.checkQ2Revision).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkQ2Revision).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraToggleEditorBase) this.checkQ2Revision).CheckedChanged += new EventHandler(this.checkQ2Revision_CheckedChanged);
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkQ3Revision).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.checkQ3Revision).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkQ3Revision).Location = new Point(645, 3);
    this.checkQ3Revision.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkQ3Revision).Name = "checkQ3Revision";
    ((Control) this.checkQ3Revision).Size = new Size(120, 20);
    ((Control) this.checkQ3Revision).TabIndex = 3;
    ((Control) this.checkQ3Revision).Text = "Show Q3 Revision";
    ((UltraControlBase) this.checkQ3Revision).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkQ3Revision).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraToggleEditorBase) this.checkQ3Revision).CheckedChanged += new EventHandler(this.checkQ3Revision_CheckedChanged);
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkQ4Revision).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.checkQ4Revision).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkQ4Revision).Location = new Point(771, 3);
    this.checkQ4Revision.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkQ4Revision).Name = "checkQ4Revision";
    ((Control) this.checkQ4Revision).Size = new Size(120, 20);
    ((Control) this.checkQ4Revision).TabIndex = 4;
    ((Control) this.checkQ4Revision).Text = "Show Q4 Revision";
    ((UltraControlBase) this.checkQ4Revision).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkQ4Revision).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraToggleEditorBase) this.checkQ4Revision).CheckedChanged += new EventHandler(this.checkQ4Revision_CheckedChanged);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.checkQ4Revision);
    this.Controls.Add((Control) this.checkQ3Revision);
    this.Controls.Add((Control) this.checkQ2Revision);
    this.Controls.Add((Control) this.checkQ1Revision);
    this.Controls.Add((Control) this.ultraChart1);
    this.Name = nameof (BudgetTrends);
    this.Size = new Size(1035, 521);
    ((ISupportInitialize) this.ultraChart1).EndInit();
    this.dsBudgetTrends1.EndInit();
    ((ISupportInitialize) this.checkQ1Revision).EndInit();
    ((ISupportInitialize) this.checkQ2Revision).EndInit();
    ((ISupportInitialize) this.checkQ3Revision).EndInit();
    ((ISupportInitialize) this.checkQ4Revision).EndInit();
    this.ResumeLayout(false);
  }
}

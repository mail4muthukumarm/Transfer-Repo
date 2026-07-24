// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Budget.Charting.QuarterlyByCostCenter
// Assembly: MgaSystems.IMS.Accounting.Budget, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6BC25DF1-D5D5-4DAC-8821-336F88BA639E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Budget.dll

using Infragistics.UltraChart.Resources;
using Infragistics.UltraChart.Resources.Appearance;
using Infragistics.UltraChart.Shared.Styles;
using MGASystems.IMS.Accounting.Budget.Datasets;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Budget.Charting;

public class QuarterlyByCostCenter : UserControl
{
  private IContainer components;
  private Infragistics.Win.UltraWinChart.UltraChart ultraChart1;
  private dsQuarterlyByCostCenter dsQuarterlyByCostCenter1;

  public QuarterlyByCostCenter() => this.InitializeComponent();

  internal void DisplayData(dsGLAccountBudgets data)
  {
    DataTable table1 = data.BudgetDetailRevision.DefaultView.ToTable(true, "FiscalPeriod");
    DataTable table2 = data.BudgetDetailRevision.DefaultView.ToTable(true, "CostCenter");
    this.dsQuarterlyByCostCenter1 = new dsQuarterlyByCostCenter();
    this.dsQuarterlyByCostCenter1.QuarterlyByCostCenter_Budget.AddQuarterlyByCostCenter_BudgetRow("Q1", 0M);
    this.dsQuarterlyByCostCenter1.QuarterlyByCostCenter_Budget.AddQuarterlyByCostCenter_BudgetRow("Q2", 0M);
    this.dsQuarterlyByCostCenter1.QuarterlyByCostCenter_Budget.AddQuarterlyByCostCenter_BudgetRow("Q3", 0M);
    this.dsQuarterlyByCostCenter1.QuarterlyByCostCenter_Budget.AddQuarterlyByCostCenter_BudgetRow("Q4", 0M);
    for (int index = this.dsQuarterlyByCostCenter1.QuarterlyByCostCenter_Budget.Columns.Count - 1; index > 0; --index)
      this.dsQuarterlyByCostCenter1.QuarterlyByCostCenter_Budget.Columns.RemoveAt(index);
    for (int index = this.dsQuarterlyByCostCenter1.QuarterlyByCostCenter_Actual.Columns.Count - 1; index > 0; --index)
      this.dsQuarterlyByCostCenter1.QuarterlyByCostCenter_Actual.Columns.RemoveAt(index);
    foreach (DataRow row in (InternalDataCollectionBase) table2.Rows)
    {
      this.dsQuarterlyByCostCenter1.QuarterlyByCostCenter_Budget.Columns.Add(row["CostCenter"].ToString(), typeof (Decimal));
      this.dsQuarterlyByCostCenter1.QuarterlyByCostCenter_Actual.Columns.Add(row["CostCenter"].ToString(), typeof (Decimal));
    }
    int index1 = 0;
    for (int index2 = 0; index2 < table1.Rows.Count; index2 += 3)
    {
      for (int columnIndex = 1; columnIndex <= table2.Rows.Count; ++columnIndex)
        this.dsQuarterlyByCostCenter1.QuarterlyByCostCenter_Budget[index1][columnIndex] = data.BudgetDetailRevision.Compute("SUM(Original)", $"(FiscalPeriod = '{table1.Rows[index2]["FiscalPeriod"].ToString()}' OR FiscalPeriod = '{table1.Rows[index2 + 1]["FiscalPeriod"].ToString()}' OR FiscalPeriod = '{table1.Rows[index2 + 2]["FiscalPeriod"].ToString()}') AND CostCenter = '{table2.Rows[columnIndex - 1]["CostCenter"].ToString()}'");
      ++index1;
    }
    this.ultraChart1.DataSource = (object) this.dsQuarterlyByCostCenter1.QuarterlyByCostCenter_Budget;
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
    this.ultraChart1 = new Infragistics.Win.UltraWinChart.UltraChart();
    this.dsQuarterlyByCostCenter1 = new dsQuarterlyByCostCenter();
    ((ISupportInitialize) this.ultraChart1).BeginInit();
    this.dsQuarterlyByCostCenter1.BeginInit();
    this.SuspendLayout();
    this.ultraChart1.Axis.BackColor = Color.FromArgb((int) byte.MaxValue, 248, 220);
    paintElement.ElementType = (PaintElementType) 0;
    paintElement.Fill = Color.FromArgb((int) byte.MaxValue, 248, 220);
    this.ultraChart1.Axis.PE = paintElement;
    this.ultraChart1.Axis.X.Extent = 20;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels).HorizontalAlign = StringAlignment.Near;
    this.ultraChart1.Axis.X.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels.SeriesLabels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels).VerticalAlign = StringAlignment.Center;
    this.ultraChart1.Axis.X.LineThickness = 1;
    this.ultraChart1.Axis.X.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.X.MajorGridLines.Color = Color.Gainsboro;
    this.ultraChart1.Axis.X.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.X.MajorGridLines.Visible = true;
    this.ultraChart1.Axis.X.Margin.Far.Value = 600.0 / 223.0;
    this.ultraChart1.Axis.X.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.X.MinorGridLines.Color = Color.LightGray;
    this.ultraChart1.Axis.X.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.X.MinorGridLines.Visible = true;
    this.ultraChart1.Axis.X.TickmarkStyle = (AxisTickStyle) 2;
    this.ultraChart1.Axis.X.Visible = true;
    this.ultraChart1.Axis.X2.Extent = 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels).HorizontalAlign = StringAlignment.Far;
    this.ultraChart1.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels.SeriesLabels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels).VerticalAlign = StringAlignment.Center;
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
    this.ultraChart1.Axis.Y.Extent = 62;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels).HorizontalAlign = StringAlignment.Far;
    this.ultraChart1.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:c>";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).FontColor = Color.DimGray;
    this.ultraChart1.Axis.Y.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Far;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
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
    this.ultraChart1.Axis.Y.MinorGridLines.Visible = true;
    this.ultraChart1.Axis.Y.TickmarkInterval = 10.0;
    this.ultraChart1.Axis.Y.TickmarkStyle = (AxisTickStyle) 2;
    this.ultraChart1.Axis.Y.Visible = true;
    this.ultraChart1.Axis.Y2.Extent = 67;
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
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels).VerticalAlign = StringAlignment.Center;
    this.ultraChart1.Axis.Y2.LineThickness = 1;
    this.ultraChart1.Axis.Y2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.Y2.MajorGridLines.Color = Color.Gainsboro;
    this.ultraChart1.Axis.Y2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.Y2.MajorGridLines.Visible = true;
    this.ultraChart1.Axis.Y2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.Y2.MinorGridLines.Color = Color.LightGray;
    this.ultraChart1.Axis.Y2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.Y2.MinorGridLines.Visible = true;
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
    this.ultraChart1.ColorModel.ColorBegin = Color.Pink;
    this.ultraChart1.ColorModel.ColorEnd = Color.DarkRed;
    this.ultraChart1.ColorModel.ModelStyle = (ColorModels) 4;
    this.ultraChart1.ColorModel.Scaling = (ColorScaling) 1;
    this.ultraChart1.Data.DataMember = "QuarterlyByCostCenter_Budget";
    this.ultraChart1.Data.ZeroAligned = true;
    this.ultraChart1.DataMember = "QuarterlyByCostCenter_Budget";
    this.ultraChart1.DataSource = (object) this.dsQuarterlyByCostCenter1;
    ((Control) this.ultraChart1).Dock = DockStyle.Fill;
    shadowEffect.Angle = 45.0;
    this.ultraChart1.Effects.Effects.Add((IEffect) gradientEffect);
    this.ultraChart1.Effects.Effects.Add((IEffect) shadowEffect);
    this.ultraChart1.EmptyChartText = "";
    this.ultraChart1.Legend.BackgroundColor = Color.Transparent;
    this.ultraChart1.Legend.BorderColor = Color.Transparent;
    this.ultraChart1.Legend.Location = (LegendLocation) 1;
    this.ultraChart1.Legend.Visible = true;
    ((Control) this.ultraChart1).Location = new Point(0, 0);
    ((Control) this.ultraChart1).Name = "ultraChart1";
    ((Control) this.ultraChart1).Size = new Size(853, 468);
    this.ultraChart1.TabIndex = 0;
    this.ultraChart1.TextRenderingHint = TextRenderingHint.AntiAlias;
    this.ultraChart1.TitleTop.Extent = 30;
    this.ultraChart1.TitleTop.Font = new Font("Tahoma", 11f);
    this.ultraChart1.TitleTop.Text = "Quarterly Budgets By Cost Center";
    this.ultraChart1.TitleTop.VerticalAlign = StringAlignment.Near;
    this.ultraChart1.Tooltips.Font = new Font("Tahoma", 8.25f);
    this.ultraChart1.Tooltips.FormatString = "<ITEM_LABEL>: <DATA_VALUE:c>";
    this.ultraChart1.Tooltips.HighlightFillColor = Color.DimGray;
    this.ultraChart1.Tooltips.HighlightOutlineColor = Color.DarkGray;
    this.dsQuarterlyByCostCenter1.DataSetName = "dsQuarterlyByCostCenter";
    this.dsQuarterlyByCostCenter1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.ultraChart1);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (QuarterlyByCostCenter);
    this.Size = new Size(853, 468);
    ((ISupportInitialize) this.ultraChart1).EndInit();
    this.dsQuarterlyByCostCenter1.EndInit();
    this.ResumeLayout(false);
  }
}

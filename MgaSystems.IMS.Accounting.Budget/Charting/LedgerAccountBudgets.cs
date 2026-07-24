// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Budget.Charting.LedgerAccountBudgets
// Assembly: MgaSystems.IMS.Accounting.Budget, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6BC25DF1-D5D5-4DAC-8821-336F88BA639E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Budget.dll

using Infragistics.UltraChart.Resources;
using Infragistics.UltraChart.Resources.Appearance;
using Infragistics.UltraChart.Shared.Styles;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
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

public class LedgerAccountBudgets : UserControl
{
  private dsGLAccountBudgets _data;
  private IContainer components;
  private Infragistics.Win.UltraWinChart.UltraChart ultraChart1;
  private dsLedgerAccountBudgets dsLedgerAccountBudgets1;
  private MGASimpleComboBox comboFiscalMonth;

  public LedgerAccountBudgets() => this.InitializeComponent();

  internal void DisplayData(dsGLAccountBudgets data)
  {
    this._data = data;
    this.SetFiscalMonthComboDataSet(data.BudgetDetailRevision.DefaultView.ToTable(true, "FiscalPeriod"));
  }

  private void DisplayData()
  {
    DataTable table = this._data.Budget.DefaultView.ToTable(true, "GLAcctId", "FullName");
    if (this.comboFiscalMonth.Value == null)
      this.comboFiscalMonth.Value = (object) "January";
    string str1 = this.comboFiscalMonth.Value.ToString();
    this.dsLedgerAccountBudgets1.Clear();
    foreach (DataRow row in (InternalDataCollectionBase) table.Rows)
    {
      string str2 = row["glacctid"].ToString();
      this.dsLedgerAccountBudgets1.LedgerBudgets.AddLedgerBudgetsRow(row["fullname"].ToString(), Decimal.Parse(this._data.BudgetDetailRevision.Compute("SUM(Original)", $"GLAcctId = {str2} AND FiscalPeriod = '{str1}'").ToString()), Decimal.Parse(this._data.BudgetDetailRevision.Compute("SUM(Actual)", $"GLAcctId = {str2} AND FiscalPeriod = '{str1}'").ToString()));
    }
  }

  private void SetFiscalMonthComboDataSet(DataTable dt)
  {
    ((UltraGridBase) this.comboFiscalMonth).DataSource = (object) dt;
    ((UltraDropDownBase) this.comboFiscalMonth).DisplayMember = "FiscalPeriod";
    ((UltraDropDownBase) this.comboFiscalMonth).ValueMember = "FiscalPeriod";
    this.comboFiscalMonth.Value = dt.Rows[0][0];
  }

  private void comboFiscalMonth_RowSelected(object sender, RowSelectedEventArgs e)
  {
    this.DisplayData();
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
    this.comboFiscalMonth = new MGASimpleComboBox();
    this.ultraChart1 = new Infragistics.Win.UltraWinChart.UltraChart();
    this.dsLedgerAccountBudgets1 = new dsLedgerAccountBudgets();
    ((ISupportInitialize) this.comboFiscalMonth).BeginInit();
    ((ISupportInitialize) this.ultraChart1).BeginInit();
    this.dsLedgerAccountBudgets1.BeginInit();
    this.SuspendLayout();
    ((Control) this.comboFiscalMonth).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.comboFiscalMonth.BorderStyle = (UIElementBorderStyle) 4;
    this.comboFiscalMonth.CharacterCasing = CharacterCasing.Normal;
    this.comboFiscalMonth.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboFiscalMonth).Location = new Point(511 /*0x01FF*/, 7);
    this.comboFiscalMonth.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboFiscalMonth).Name = "comboFiscalMonth";
    ((Control) this.comboFiscalMonth).Size = new Size(131, 20);
    ((Control) this.comboFiscalMonth).TabIndex = 0;
    ((UltraControlBase) this.comboFiscalMonth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboFiscalMonth).UseOsThemes = (DefaultableBoolean) 2;
    this.comboFiscalMonth.RowSelected += new RowSelectedEventHandler(this.comboFiscalMonth_RowSelected);
    this.ultraChart1.ChartType = (ChartType) 1;
    this.ultraChart1.Axis.BackColor = Color.FromArgb((int) byte.MaxValue, 248, 220);
    paintElement.ElementType = (PaintElementType) 0;
    paintElement.Fill = Color.FromArgb((int) byte.MaxValue, 248, 220);
    this.ultraChart1.Axis.PE = paintElement;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels).HorizontalAlign = StringAlignment.Near;
    this.ultraChart1.Axis.X.Labels.ItemFormatString = "<DATA_VALUE:c>";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels).Orientation = (TextOrientation) 0;
    this.ultraChart1.Axis.X.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
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
    this.ultraChart1.Axis.X.TickmarkInterval = 10.0;
    this.ultraChart1.Axis.X.TickmarkStyle = (AxisTickStyle) 2;
    this.ultraChart1.Axis.X.Visible = true;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.X2.Labels).HorizontalAlign = StringAlignment.Far;
    this.ultraChart1.Axis.X2.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
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
    this.ultraChart1.Axis.X2.LineThickness = 1;
    this.ultraChart1.Axis.X2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.X2.MajorGridLines.Color = Color.Gainsboro;
    this.ultraChart1.Axis.X2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.X2.MajorGridLines.Visible = true;
    this.ultraChart1.Axis.X2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.X2.MinorGridLines.Color = Color.LightGray;
    this.ultraChart1.Axis.X2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.X2.MinorGridLines.Visible = false;
    this.ultraChart1.Axis.X2.TickmarkInterval = 10.0;
    this.ultraChart1.Axis.X2.TickmarkStyle = (AxisTickStyle) 2;
    this.ultraChart1.Axis.X2.Visible = false;
    this.ultraChart1.Axis.Y.Extent = 15;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels).HorizontalAlign = StringAlignment.Far;
    this.ultraChart1.Axis.Y.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y.Labels).Visible = false;
    this.ultraChart1.Axis.Y.LineThickness = 1;
    this.ultraChart1.Axis.Y.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.Y.MajorGridLines.Color = Color.Gainsboro;
    this.ultraChart1.Axis.Y.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.Y.MajorGridLines.Visible = true;
    this.ultraChart1.Axis.Y.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.ultraChart1.Axis.Y.MinorGridLines.Color = Color.LightGray;
    this.ultraChart1.Axis.Y.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.ultraChart1.Axis.Y.MinorGridLines.Visible = false;
    this.ultraChart1.Axis.Y.TickmarkStyle = (AxisTickStyle) 2;
    this.ultraChart1.Axis.Y.Visible = true;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels).HorizontalAlign = StringAlignment.Near;
    this.ultraChart1.Axis.Y2.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels.SeriesLabels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Y2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Center;
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
    this.ultraChart1.Axis.Y2.MinorGridLines.Visible = false;
    this.ultraChart1.Axis.Y2.TickmarkStyle = (AxisTickStyle) 2;
    this.ultraChart1.Axis.Y2.Visible = false;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z.Labels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z.Labels).HorizontalAlign = StringAlignment.Near;
    this.ultraChart1.Axis.Z.Labels.ItemFormatString = "<ITEM_LABEL>";
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
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z2.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.ultraChart1.Axis.Z2.Labels).VerticalAlign = StringAlignment.Center;
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
    this.ultraChart1.Data.SwapRowsAndColumns = true;
    this.ultraChart1.Data.UseRowLabelsColumn = true;
    this.ultraChart1.Data.ZeroAligned = true;
    this.ultraChart1.DataSource = (object) this.dsLedgerAccountBudgets1;
    ((Control) this.ultraChart1).Dock = DockStyle.Fill;
    this.ultraChart1.Effects.Effects.Add((IEffect) gradientEffect);
    this.ultraChart1.EmptyChartText = "";
    this.ultraChart1.Legend.BackgroundColor = Color.Transparent;
    this.ultraChart1.Legend.BorderColor = Color.Transparent;
    this.ultraChart1.Legend.Visible = true;
    ((Control) this.ultraChart1).Location = new Point(0, 0);
    ((Control) this.ultraChart1).Name = "ultraChart1";
    ((Control) this.ultraChart1).Size = new Size(648, 453);
    this.ultraChart1.TabIndex = 0;
    this.ultraChart1.TextRenderingHint = TextRenderingHint.AntiAlias;
    this.ultraChart1.TitleTop.Font = new Font("Tahoma", 9.75f);
    this.ultraChart1.TitleTop.Text = "Ledger Account Budgets V Actuals";
    this.ultraChart1.Tooltips.HighlightFillColor = Color.DimGray;
    this.ultraChart1.Tooltips.HighlightOutlineColor = Color.DarkGray;
    this.dsLedgerAccountBudgets1.DataSetName = "dsLedgerAccountBudgets";
    this.dsLedgerAccountBudgets1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.comboFiscalMonth);
    this.Controls.Add((Control) this.ultraChart1);
    this.Name = nameof (LedgerAccountBudgets);
    this.Size = new Size(648, 453);
    ((ISupportInitialize) this.comboFiscalMonth).EndInit();
    ((ISupportInitialize) this.ultraChart1).EndInit();
    this.dsLedgerAccountBudgets1.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}

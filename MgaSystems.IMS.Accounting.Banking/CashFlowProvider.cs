// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.CashFlowProvider
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.UltraChart.Resources.Appearance;
using Infragistics.UltraChart.Shared.Styles;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public class CashFlowProvider : UserControl
{
  private IContainer components;

  public CashFlowProvider() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("UltraChart1")]
  internal virtual Infragistics.Win.UltraWinChart.UltraChart UltraChart1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.UltraChart1 = new Infragistics.Win.UltraWinChart.UltraChart();
    ((ISupportInitialize) this.UltraChart1).BeginInit();
    this.SuspendLayout();
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.X.ScrollScale.Height = 10;
    this.UltraChart1.Axis.X.ScrollScale.Visible = false;
    this.UltraChart1.Axis.X.ScrollScale.Width = 15;
    this.UltraChart1.Axis.X.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.X2.ScrollScale.Height = 10;
    this.UltraChart1.Axis.X2.ScrollScale.Visible = false;
    this.UltraChart1.Axis.X2.ScrollScale.Width = 15;
    this.UltraChart1.Axis.X2.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels).HorizontalAlign = StringAlignment.Far;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.Y.ScrollScale.Height = 10;
    this.UltraChart1.Axis.Y.ScrollScale.Visible = false;
    this.UltraChart1.Axis.Y.ScrollScale.Width = 15;
    this.UltraChart1.Axis.Y.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.Y2.ScrollScale.Height = 10;
    this.UltraChart1.Axis.Y2.ScrollScale.Visible = false;
    this.UltraChart1.Axis.Y2.ScrollScale.Width = 15;
    this.UltraChart1.Axis.Y2.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.Z.ScrollScale.Height = 10;
    this.UltraChart1.Axis.Z.ScrollScale.Visible = false;
    this.UltraChart1.Axis.Z.ScrollScale.Width = 15;
    this.UltraChart1.Axis.Z.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels.SeriesLabels).Flip = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.Z2.ScrollScale.Height = 10;
    this.UltraChart1.Axis.Z2.ScrollScale.Visible = false;
    this.UltraChart1.Axis.Z2.ScrollScale.Width = 15;
    this.UltraChart1.Axis.Z2.TickmarkInterval = 0.0;
    this.UltraChart1.Data.EmptyStyle.LineStyle.DrawStyle = (LineDrawStyle) 1;
    this.UltraChart1.Data.EmptyStyle.LineStyle.EndStyle = (LineCapStyle) 0;
    this.UltraChart1.Data.EmptyStyle.LineStyle.MidPointAnchors = false;
    this.UltraChart1.Data.EmptyStyle.LineStyle.StartStyle = (LineCapStyle) 0;
    ((Control) this.UltraChart1).Location = new Point(8, 8);
    ((Control) this.UltraChart1).Name = "UltraChart1";
    ((Control) this.UltraChart1).Size = new Size(584, 200);
    this.UltraChart1.TabIndex = 0;
    this.Controls.Add((Control) this.UltraChart1);
    this.Name = nameof (CashFlowProvider);
    this.Size = new Size(600, 248);
    ((ISupportInitialize) this.UltraChart1).EndInit();
    this.ResumeLayout(false);
  }
}

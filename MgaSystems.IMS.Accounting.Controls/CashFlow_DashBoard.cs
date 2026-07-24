// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.CashFlow_DashBoard
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

using Infragistics.UltraChart.Resources;
using Infragistics.UltraChart.Resources.Appearance;
using Infragistics.UltraChart.Shared.Styles;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinProgressBar;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Forms;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

[DesignerGenerated]
[TestForm]
public class CashFlow_DashBoard : UserControl
{
  private IContainer components;
  private int GlCompanyID;
  private ParameterizedThreadStart _loadDataThreadStart;
  private Thread _loadDataThread;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    PaintElement paintElement = new PaintElement();
    ColumnChartAppearance columnChartAppearance = new ColumnChartAppearance();
    GradientEffect gradientEffect = new GradientEffect();
    this.UltraChart1 = new Infragistics.Win.UltraWinChart.UltraChart();
    this.comboOfficeLocations = new MGASimpleComboBox();
    this.Label1 = new Label();
    this.comboDateOptions = new MGASimpleComboBox();
    this.Label2 = new Label();
    this.linkRefresh = new LinkLabel();
    this.progressDataLoad = new UltraProgressBar();
    ((ISupportInitialize) this.UltraChart1).BeginInit();
    ((ISupportInitialize) this.comboOfficeLocations).BeginInit();
    ((ISupportInitialize) this.comboDateOptions).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraChart1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.UltraChart1.Axis.BackColor = Color.FromArgb((int) byte.MaxValue, 248, 220);
    paintElement.ElementType = (PaintElementType) 0;
    paintElement.Fill = Color.FromArgb((int) byte.MaxValue, 248, 220);
    this.UltraChart1.Axis.PE = paintElement;
    this.UltraChart1.Axis.X.Extent = 60;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels).HorizontalAlign = StringAlignment.Near;
    this.UltraChart1.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels.SeriesLabels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels.SeriesLabels).Visible = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.X.LineThickness = 1;
    this.UltraChart1.Axis.X.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.X.MajorGridLines.Color = Color.Gainsboro;
    this.UltraChart1.Axis.X.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.X.MajorGridLines.Visible = true;
    this.UltraChart1.Axis.X.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.X.MinorGridLines.Color = Color.LightGray;
    this.UltraChart1.Axis.X.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.X.MinorGridLines.Visible = false;
    this.UltraChart1.Axis.X.TickmarkStyle = (AxisTickStyle) 2;
    this.UltraChart1.Axis.X.Visible = true;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels).HorizontalAlign = StringAlignment.Near;
    this.UltraChart1.Axis.X2.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.X2.LineThickness = 1;
    this.UltraChart1.Axis.X2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.X2.MajorGridLines.Color = Color.Gainsboro;
    this.UltraChart1.Axis.X2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.X2.MajorGridLines.Visible = true;
    this.UltraChart1.Axis.X2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.X2.MinorGridLines.Color = Color.LightGray;
    this.UltraChart1.Axis.X2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.X2.MinorGridLines.Visible = false;
    this.UltraChart1.Axis.X2.TickmarkStyle = (AxisTickStyle) 2;
    this.UltraChart1.Axis.X2.Visible = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels).HorizontalAlign = StringAlignment.Far;
    this.UltraChart1.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:c>";
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels.SeriesLabels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.Y.LineThickness = 1;
    this.UltraChart1.Axis.Y.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.Y.MajorGridLines.Color = Color.Gainsboro;
    this.UltraChart1.Axis.Y.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.Y.MajorGridLines.Visible = true;
    this.UltraChart1.Axis.Y.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.Y.MinorGridLines.Color = Color.LightGray;
    this.UltraChart1.Axis.Y.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.Y.MinorGridLines.Visible = false;
    this.UltraChart1.Axis.Y.TickmarkInterval = 50.0;
    this.UltraChart1.Axis.Y.TickmarkStyle = (AxisTickStyle) 2;
    this.UltraChart1.Axis.Y.Visible = true;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels).HorizontalAlign = StringAlignment.Near;
    this.UltraChart1.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels.SeriesLabels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.Y2.LineThickness = 1;
    this.UltraChart1.Axis.Y2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.Y2.MajorGridLines.Color = Color.Gainsboro;
    this.UltraChart1.Axis.Y2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.Y2.MajorGridLines.Visible = true;
    this.UltraChart1.Axis.Y2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.Y2.MinorGridLines.Color = Color.LightGray;
    this.UltraChart1.Axis.Y2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.Y2.MinorGridLines.Visible = false;
    this.UltraChart1.Axis.Y2.TickmarkInterval = 50.0;
    this.UltraChart1.Axis.Y2.TickmarkStyle = (AxisTickStyle) 2;
    this.UltraChart1.Axis.Y2.Visible = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels).HorizontalAlign = StringAlignment.Near;
    this.UltraChart1.Axis.Z.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels.SeriesLabels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.Z.LineThickness = 1;
    this.UltraChart1.Axis.Z.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.Z.MajorGridLines.Color = Color.Gainsboro;
    this.UltraChart1.Axis.Z.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.Z.MajorGridLines.Visible = true;
    this.UltraChart1.Axis.Z.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.Z.MinorGridLines.Color = Color.LightGray;
    this.UltraChart1.Axis.Z.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.Z.MinorGridLines.Visible = false;
    this.UltraChart1.Axis.Z.TickmarkStyle = (AxisTickStyle) 2;
    this.UltraChart1.Axis.Z.Visible = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels).HorizontalAlign = StringAlignment.Near;
    this.UltraChart1.Axis.Z2.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels.SeriesLabels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.Z2.LineThickness = 1;
    this.UltraChart1.Axis.Z2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.Z2.MajorGridLines.Color = Color.Gainsboro;
    this.UltraChart1.Axis.Z2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.Z2.MajorGridLines.Visible = true;
    this.UltraChart1.Axis.Z2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.Z2.MinorGridLines.Color = Color.LightGray;
    this.UltraChart1.Axis.Z2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.Z2.MinorGridLines.Visible = false;
    this.UltraChart1.Axis.Z2.TickmarkStyle = (AxisTickStyle) 2;
    this.UltraChart1.Axis.Z2.Visible = false;
    this.UltraChart1.Border.Color = Color.SteelBlue;
    this.UltraChart1.Border.CornerRadius = 25;
    this.UltraChart1.ColorModel.AlphaLevel = (byte) 150;
    this.UltraChart1.ColorModel.ColorBegin = Color.Turquoise;
    this.UltraChart1.ColorModel.ColorEnd = Color.RoyalBlue;
    ((ColumnChart3DAppearance) columnChartAppearance).ColumnSpacing = 1;
    this.UltraChart1.ColumnChart = columnChartAppearance;
    this.UltraChart1.Effects.Effects.Add((IEffect) gradientEffect);
    ((Control) this.UltraChart1).Location = new Point(3, 37);
    ((Control) this.UltraChart1).Name = "UltraChart1";
    ((Control) this.UltraChart1).Size = new Size(499, 183);
    this.UltraChart1.TabIndex = 0;
    this.UltraChart1.Tooltips.FormatString = "<DATA_VALUE:c>";
    this.UltraChart1.Tooltips.HighlightFillColor = Color.DimGray;
    this.UltraChart1.Tooltips.HighlightOutlineColor = Color.DarkGray;
    ((Control) this.comboOfficeLocations).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.comboOfficeLocations.AutoSelectOnOneItem = true;
    this.comboOfficeLocations.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocations.CharacterCasing = CharacterCasing.Normal;
    this.comboOfficeLocations.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboOfficeLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocations).Location = new Point(98, 11);
    this.comboOfficeLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocations).Name = "comboOfficeLocations";
    ((Control) this.comboOfficeLocations).Size = new Size(169, 20);
    ((Control) this.comboOfficeLocations).TabIndex = 3;
    ((UltraControlBase) this.comboOfficeLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocations).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(10, 11);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(82, 13);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Office Location:";
    ((Control) this.comboDateOptions).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.comboDateOptions.BorderStyle = (UIElementBorderStyle) 4;
    this.comboDateOptions.CharacterCasing = CharacterCasing.Normal;
    this.comboDateOptions.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboDateOptions.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboDateOptions).Location = new Point(325, 11);
    this.comboDateOptions.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboDateOptions).Name = "comboDateOptions";
    ((Control) this.comboDateOptions).Size = new Size(129, 20);
    ((Control) this.comboDateOptions).TabIndex = 5;
    ((UltraControlBase) this.comboDateOptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboDateOptions).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(273, 11);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(46, 13);
    this.Label2.TabIndex = 6;
    this.Label2.Text = "Options:";
    this.linkRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.linkRefresh.Location = new Point(456, 11);
    this.linkRefresh.Name = "linkRefresh";
    this.linkRefresh.Size = new Size(44, 13);
    this.linkRefresh.TabIndex = 8;
    this.linkRefresh.TabStop = true;
    this.linkRefresh.Text = "Refresh";
    this.linkRefresh.TextAlign = ContentAlignment.TopRight;
    ((Control) this.progressDataLoad).Anchor = AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.progressDataLoad).Location = new Point(138, 106);
    ((Control) this.progressDataLoad).Name = "progressDataLoad";
    ((Control) this.progressDataLoad).Size = new Size(259, 15);
    ((Control) this.progressDataLoad).TabIndex = 9;
    this.progressDataLoad.Text = "[Formatted]";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.AliceBlue;
    this.Controls.Add((Control) this.progressDataLoad);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.comboDateOptions);
    this.Controls.Add((Control) this.comboOfficeLocations);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.UltraChart1);
    this.Controls.Add((Control) this.linkRefresh);
    this.Name = nameof (CashFlow_DashBoard);
    this.Size = new Size(505, 223);
    ((ISupportInitialize) this.UltraChart1).EndInit();
    ((ISupportInitialize) this.comboOfficeLocations).EndInit();
    ((ISupportInitialize) this.comboDateOptions).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("UltraChart1")]
  private virtual Infragistics.Win.UltraWinChart.UltraChart UltraChart1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboOfficeLocations")]
  internal virtual MGASimpleComboBox comboOfficeLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox comboDateOptions
  {
    get => this._comboDateOptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.comboDateOptions_RowSelected);
      MGASimpleComboBox comboDateOptions1 = this._comboDateOptions;
      if (comboDateOptions1 != null)
        comboDateOptions1.RowSelected -= selectedEventHandler;
      this._comboDateOptions = value;
      MGASimpleComboBox comboDateOptions2 = this._comboDateOptions;
      if (comboDateOptions2 == null)
        return;
      comboDateOptions2.RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel linkRefresh
  {
    get => this._linkRefresh;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkRefresh_LinkClicked);
      LinkLabel linkRefresh1 = this._linkRefresh;
      if (linkRefresh1 != null)
        linkRefresh1.LinkClicked -= clickedEventHandler;
      this._linkRefresh = value;
      LinkLabel linkRefresh2 = this._linkRefresh;
      if (linkRefresh2 == null)
        return;
      linkRefresh2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("progressDataLoad")]
  internal virtual UltraProgressBar progressDataLoad { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public CashFlow_DashBoard()
  {
    this.Load += new EventHandler(this.CashFlow_DashBoard_Load);
    this.InitializeComponent();
  }

  private void LoadOfficeLocations()
  {
    DataTable tableToFill = new DataTable();
    Database.Instance.QuerySP.PerformTableQuery("spFin_GetOfficeLocations", tableToFill);
    ((UltraGridBase) this.comboOfficeLocations).DataSource = (object) tableToFill;
    if (tableToFill != null)
      ((UltraDropDownBase) this.comboOfficeLocations).DisplayMember = tableToFill.TableName;
    ((UltraDropDownBase) this.comboOfficeLocations).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocations).ValueMember = "ID";
  }

  private void SetUpGetDataInputs(int selectedOptionIndex)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.comboOfficeLocations.Value, (object) null, false))
    {
      int num1 = (int) MessageBox.Show("Please select an office location.", "Office Location Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      ((Control) this.UltraChart1).Visible = false;
      ((Control) this.progressDataLoad).Visible = true;
      ((Control) this.progressDataLoad).BringToFront();
      ((Control) this.comboDateOptions).Enabled = false;
      this.GlCompanyID = int.Parse(this.comboOfficeLocations.Value.ToString());
      int num2 = 1;
      bool flag = false;
      DateTime date = DateTime.Now.Date;
      int num3;
      DateTime dateTime;
      switch (selectedOptionIndex)
      {
        case 0:
          num3 = 7;
          break;
        case 1:
          num3 = 14;
          break;
        case 2:
          dateTime = date.AddMonths(1);
          break;
        case 3:
          dateTime = date.AddMonths(2);
          break;
        case 4:
          dateTime = date.AddMonths(3);
          break;
        case 5:
          num3 = 12;
          flag = true;
          break;
      }
      if (selectedOptionIndex == 4 | selectedOptionIndex == 3 | selectedOptionIndex == 2)
      {
        num2 = 3;
        int days = dateTime.Subtract(date.Date).Days;
        num3 = Convert.ToInt32(Math.Floor(Decimal.Divide(new Decimal(days), 3M)));
        if (days % 3 != 0)
          ++num3;
      }
      this.progressDataLoad.Maximum = num3;
      ArrayList parameter = new ArrayList();
      parameter.Add((object) date);
      parameter.Add((object) num3);
      parameter.Add((object) num2);
      parameter.Add((object) flag);
      this._loadDataThread = new Thread(new ParameterizedThreadStart(this.CreateDataSet));
      this._loadDataThread.IsBackground = true;
      this._loadDataThread.Name = "LoadCashFlowDashboardThread";
      this._loadDataThread.Start((object) parameter);
    }
  }

  private void CreateDataSet(object data)
  {
    DateTime date1 = Conversions.ToDate(((ArrayList) data)[0]);
    int integer1 = Conversions.ToInteger(((ArrayList) data)[1]);
    int integer2 = Conversions.ToInteger(((ArrayList) data)[2]);
    bool boolean = Conversions.ToBoolean(((ArrayList) data)[3]);
    DataSet dataSet = new DataSet();
    dataSet.Tables.Add("dashBoardCashFlow");
    bool isFirstRun = true;
    DataTable table = dataSet.Tables[0];
    Decimal num1 = 0M;
    int columnIndex = 0;
    DateTime NewDate = date1.Date;
    while (columnIndex < integer1)
    {
      int num2;
      if (!boolean)
      {
        NewDate = date1.Date.AddDays((double) (columnIndex * integer2));
        table.Columns.Add(NewDate.ToString("d"), typeof (Decimal));
      }
      else
      {
        num2 = DateTime.DaysInMonth(NewDate.Date.Year, NewDate.Date.Month);
        table.Columns.Add(NewDate.ToString("d"), typeof (Decimal));
      }
      DataRow row;
      if (table.Rows.Count == 0)
      {
        row = table.NewRow();
        table.Rows.Add(row);
      }
      else
        row = table.Rows[0];
      DateTime date2;
      Decimal amount = this.GetAmount(num1, NewDate, date2, isFirstRun);
      num1 = Decimal.Add(num1, amount);
      row[columnIndex] = (object) amount;
      ++columnIndex;
      isFirstRun = false;
      date2 = NewDate.Date;
      if (boolean)
        NewDate = NewDate.AddDays((double) num2);
      if (this.InvokeRequired && !this.Disposing && !this.IsDisposed)
        this.Invoke((Delegate) new CashFlow_DashBoard.UpdateProgressBarHandler(this.UpdateProgressBar));
    }
    if (!this.InvokeRequired || this.Disposing || this.IsDisposed)
      return;
    this.Invoke((Delegate) new CashFlow_DashBoard.GetDataCompletedHandler(this.GetDataCompleted), (object) dataSet);
  }

  private Decimal GetAmount(
    Decimal runningBalance,
    DateTime NewDate,
    DateTime previousDate,
    bool isFirstRun)
  {
    SqlParameter[] sqlParameters;
    if (isFirstRun)
      sqlParameters = new SqlParameter[4]
      {
        new SqlParameter("@date", (object) NewDate),
        new SqlParameter("@getRunningBalance", (object) isFirstRun),
        new SqlParameter("@runningBalance", (object) runningBalance),
        new SqlParameter("@glCompanyID", (object) this.GlCompanyID)
      };
    else
      sqlParameters = new SqlParameter[5]
      {
        new SqlParameter("@date", (object) NewDate),
        new SqlParameter("@dateTo", (object) previousDate),
        new SqlParameter("@getRunningBalance", (object) isFirstRun),
        new SqlParameter("@runningBalance", (object) runningBalance),
        new SqlParameter("@glCompanyID", (object) this.GlCompanyID)
      };
    return Decimal.Parse(Conversions.ToString(Database.Instance.QuerySP.PerformScalarQuery("dbo.spFin_DashboardCashFlow ", sqlParameters)));
  }

  private void CashFlow_DashBoard_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadOfficeLocations();
    this.LoadDateOptions();
    this.SetUpGetDataInputs(this.comboOfficeLocations.SelectedIndex);
  }

  private void comboDateOptions_RowSelected(object sender, RowSelectedEventArgs e)
  {
    this.SetUpGetDataInputs(this.comboDateOptions.SelectedIndex);
  }

  private void LoadDateOptions()
  {
    ((UltraGridBase) this.comboDateOptions).DataSource = (object) new DataTable("DataSource")
    {
      Columns = {
        {
          "Value",
          Type.GetType("System.String")
        }
      },
      Rows = {
        new object[1]{ (object) "Next 7 Days" },
        new object[1]{ (object) "Next 14 days" },
        new object[1]{ (object) "Next month" },
        new object[1]{ (object) "Next 2 months" },
        new object[1]{ (object) "Next 3 months" },
        new object[1]{ (object) "Next 12 months" }
      }
    };
    ((UltraDropDownBase) this.comboDateOptions).DisplayMember = "Value";
    this.comboDateOptions.SelectedIndex = 0;
  }

  private void UpdateProgressBar()
  {
    if (this.progressDataLoad.Value + 1 > this.progressDataLoad.Maximum)
      return;
    UltraProgressBar progressDataLoad;
    int num = (progressDataLoad = this.progressDataLoad).Value + 1;
    progressDataLoad.Value = num;
  }

  private void GetDataCompleted(DataSet ds)
  {
    this.progressDataLoad.Value = this.progressDataLoad.Maximum;
    if (ds != null)
    {
      this.UltraChart1.DataSource = (object) ds;
      this.UltraChart1.DataMember = ds.Tables[0].TableName;
      this.UltraChart1.DataBind();
    }
    ((Control) this.comboDateOptions).Enabled = true;
    ((Control) this.UltraChart1).Visible = true;
    this.comboDateOptions.Focus();
    ((Control) this.progressDataLoad).Visible = false;
    this.progressDataLoad.Value = 0;
  }

  private void linkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.UltraChart1.DataSource = (object) null;
    this.SetUpGetDataInputs(this.comboDateOptions.SelectedIndex);
  }

  public enum DateRangeOptions
  {
    SevenDays,
    FourteenDays,
    Month,
    TwoMonths,
    ThreeMonths,
    TwelveMonths,
  }

  private delegate void GetDataCompletedHandler(DataSet ds);

  private delegate void UpdateProgressBarHandler();
}

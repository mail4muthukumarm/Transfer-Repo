// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.formCostCenterAllocation
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.UltraChart.Resources.Appearance;
using Infragistics.UltraChart.Shared.Styles;
using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Interfaces;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms;

public class formCostCenterAllocation : Form
{
  internal UltraToolbarsManager CostCenterAllocationMenu;
  internal UltraToolbarsDockArea _frmExpenseDetailAllocation_Toolbars_Dock_Area_Top;
  internal UltraToolbarsDockArea _frmExpenseDetailAllocation_Toolbars_Dock_Area_Bottom;
  internal UltraToolbarsDockArea _frmExpenseDetailAllocation_Toolbars_Dock_Area_Left;
  internal UltraToolbarsDockArea _frmExpenseDetailAllocation_Toolbars_Dock_Area_Right;
  internal Panel Panel1;
  internal Panel panelCostCenterAllocation;
  internal Infragistics.Win.UltraWinChart.UltraChart AllocationChart;
  private ToolTip toolTip1;
  private UltraExplorerBar ultraExplorerBar1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
  private Label label1;
  private Label lblAccountName;
  private Label lblTransDate;
  private Label label3;
  private Label lblAmount;
  private Label label4;
  private IContainer components;
  private DataSet ds = new DataSet();
  internal ISupportCostCenterAllocation DetailObject;
  private int glCompanyId;

  private formCostCenterAllocation() => this.InitializeComponent();

  public formCostCenterAllocation(ISupportCostCenterAllocation detailObject, int GlCompanyId)
  {
    this.InitializeComponent();
    this.glCompanyId = GlCompanyId;
    this.DetailObject = (ISupportCostCenterAllocation) detailObject.Clone();
    this.DisplayHeader();
    this.BuildCostCeterAllocationList();
    this.DisplayCurrentAllocations();
    this.AllocationChart.DataSource = (object) this.DetailObject.CostCenterAllocations.ToChartDataTable(this.DetailObject.TransactionTotal);
    this.RefreshTotals();
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
    PieChartAppearance pieChartAppearance = new PieChartAppearance();
    View3DAppearance view3Dappearance = new View3DAppearance();
    Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (formCostCenterAllocation));
    UltraToolbar ultraToolbar = new UltraToolbar("CostCenterAllocation");
    Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
    ButtonTool buttonTool1 = new ButtonTool("ACCT_SAVEDETAILALLOCATION");
    ButtonTool buttonTool2 = new ButtonTool("ACCT_REFRESHDETAILALLOCATION");
    ButtonTool buttonTool3 = new ButtonTool("Cancel");
    ButtonTool buttonTool4 = new ButtonTool("ACCT_SAVEDETAILALLOCATION");
    Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
    ButtonTool buttonTool5 = new ButtonTool("ACCT_REFRESHDETAILALLOCATION");
    Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
    ButtonTool buttonTool6 = new ButtonTool("Cancel");
    Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
    this.ultraExplorerBarContainerControl3 = new UltraExplorerBarContainerControl();
    this.AllocationChart = new Infragistics.Win.UltraWinChart.UltraChart();
    this.ultraExplorerBarContainerControl4 = new UltraExplorerBarContainerControl();
    this.panelCostCenterAllocation = new Panel();
    this.CostCenterAllocationMenu = new UltraToolbarsManager(this.components);
    this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.Panel1 = new Panel();
    this.lblAmount = new Label();
    this.label4 = new Label();
    this.lblTransDate = new Label();
    this.label3 = new Label();
    this.lblAccountName = new Label();
    this.label1 = new Label();
    this.ultraExplorerBar1 = new UltraExplorerBar();
    this.toolTip1 = new ToolTip(this.components);
    ((Control) this.ultraExplorerBarContainerControl3).SuspendLayout();
    ((ISupportInitialize) this.AllocationChart).BeginInit();
    ((Control) this.ultraExplorerBarContainerControl4).SuspendLayout();
    ((ISupportInitialize) this.CostCenterAllocationMenu).BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.ultraExplorerBar1).BeginInit();
    ((Control) this.ultraExplorerBar1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl3).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.AllocationChart);
    ((Control) this.ultraExplorerBarContainerControl3).Location = new Point(14, 38);
    ((Control) this.ultraExplorerBarContainerControl3).Name = "ultraExplorerBarContainerControl3";
    ((Control) this.ultraExplorerBarContainerControl3).Size = new Size(439, 368);
    ((Control) this.ultraExplorerBarContainerControl3).TabIndex = 2;
    this.AllocationChart.ChartType = (ChartType) 4;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X.Labels.SeriesLabels).Flip = false;
    this.AllocationChart.Axis.X.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X.Labels).VerticalAlign = StringAlignment.Center;
    this.AllocationChart.Axis.X.ScrollScale.Height = 10;
    this.AllocationChart.Axis.X.ScrollScale.Visible = false;
    this.AllocationChart.Axis.X.ScrollScale.Width = 15;
    this.AllocationChart.Axis.X.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X2.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X2.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X2.Labels.SeriesLabels).Flip = false;
    this.AllocationChart.Axis.X2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.X2.Labels).VerticalAlign = StringAlignment.Center;
    this.AllocationChart.Axis.X2.ScrollScale.Height = 10;
    this.AllocationChart.Axis.X2.ScrollScale.Visible = false;
    this.AllocationChart.Axis.X2.ScrollScale.Width = 15;
    this.AllocationChart.Axis.X2.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Y.Labels).Flip = false;
    this.AllocationChart.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.00>";
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Y.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Y.Labels.SeriesLabels).Flip = false;
    this.AllocationChart.Axis.Y.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Y.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Y.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Y.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Y.Labels).VerticalAlign = StringAlignment.Center;
    this.AllocationChart.Axis.Y.ScrollScale.Height = 10;
    this.AllocationChart.Axis.Y.ScrollScale.Visible = false;
    this.AllocationChart.Axis.Y.ScrollScale.Width = 15;
    this.AllocationChart.Axis.Y.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Y2.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Y2.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Y2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Y2.Labels.SeriesLabels).Flip = false;
    this.AllocationChart.Axis.Y2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Y2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Y2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Y2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Y2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Y2.Labels).VerticalAlign = StringAlignment.Center;
    this.AllocationChart.Axis.Y2.ScrollScale.Height = 10;
    this.AllocationChart.Axis.Y2.ScrollScale.Visible = false;
    this.AllocationChart.Axis.Y2.ScrollScale.Width = 15;
    this.AllocationChart.Axis.Y2.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z.Labels.SeriesLabels).Flip = false;
    this.AllocationChart.Axis.Z.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z.Labels).VerticalAlign = StringAlignment.Center;
    this.AllocationChart.Axis.Z.ScrollScale.Height = 10;
    this.AllocationChart.Axis.Z.ScrollScale.Visible = false;
    this.AllocationChart.Axis.Z.ScrollScale.Width = 15;
    this.AllocationChart.Axis.Z.TickmarkInterval = 0.0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z2.Labels).Flip = false;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z2.Labels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z2.Labels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z2.Labels.SeriesLabels).Flip = false;
    this.AllocationChart.Axis.Z2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z2.Labels.SeriesLabels).OrientationAngle = 0;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.AllocationChart.Axis.Z2.Labels).VerticalAlign = StringAlignment.Center;
    this.AllocationChart.Axis.Z2.ScrollScale.Height = 10;
    this.AllocationChart.Axis.Z2.ScrollScale.Visible = false;
    this.AllocationChart.Axis.Z2.ScrollScale.Width = 15;
    this.AllocationChart.Axis.Z2.TickmarkInterval = 0.0;
    this.AllocationChart.Border.Color = Color.LightSlateGray;
    this.AllocationChart.ColorModel.ColorBegin = Color.DarkGreen;
    this.AllocationChart.ColorModel.ColorEnd = Color.Honeydew;
    this.AllocationChart.ColorModel.ModelStyle = (ColorModels) 1;
    this.AllocationChart.Data.EmptyStyle.LineStyle.DrawStyle = (LineDrawStyle) 1;
    this.AllocationChart.Data.EmptyStyle.LineStyle.EndStyle = (LineCapStyle) 0;
    this.AllocationChart.Data.EmptyStyle.LineStyle.MidPointAnchors = false;
    this.AllocationChart.Data.EmptyStyle.LineStyle.StartStyle = (LineCapStyle) 0;
    ((Control) this.AllocationChart).Dock = DockStyle.Fill;
    this.AllocationChart.Legend.BackgroundColor = Color.LightSteelBlue;
    this.AllocationChart.Legend.BorderColor = Color.Black;
    this.AllocationChart.Legend.DataAssociation = (ChartTypeData) 1;
    this.AllocationChart.Legend.Margins.Bottom = 0;
    this.AllocationChart.Legend.Margins.Left = 0;
    this.AllocationChart.Legend.Margins.Right = 0;
    this.AllocationChart.Legend.Margins.Top = 0;
    this.AllocationChart.Legend.SpanPercentage = 30;
    ((Control) this.AllocationChart).Location = new Point(0, 0);
    ((Control) this.AllocationChart).Name = "AllocationChart";
    pieChartAppearance.BreakAllSlices = true;
    pieChartAppearance.BreakDistancePercentage = 4;
    pieChartAppearance.Labels.FormatString = "<ITEM_LABEL> <DATA_VALUE:c>";
    pieChartAppearance.OthersCategoryPercent = 0.0;
    pieChartAppearance.PieThickness = 5;
    pieChartAppearance.RadiusFactor = 50;
    pieChartAppearance.StartAngle = 15;
    this.AllocationChart.PieChart = pieChartAppearance;
    ((Control) this.AllocationChart).Size = new Size(439, 368);
    this.AllocationChart.TabIndex = 1;
    this.AllocationChart.TitleTop.Extent = 20;
    this.AllocationChart.TitleTop.Font = new Font("Arial", 11f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.AllocationChart.TitleTop.FontSizeBestFit = true;
    this.AllocationChart.TitleTop.Location = (TitleLocation) 3;
    this.AllocationChart.TitleTop.Margins.Bottom = 0;
    this.AllocationChart.TitleTop.Margins.Left = 0;
    this.AllocationChart.TitleTop.Margins.Right = 0;
    this.AllocationChart.TitleTop.Margins.Top = 0;
    this.AllocationChart.TitleTop.Text = "Cost Center Allocation     ";
    this.AllocationChart.TitleTop.VerticalAlign = StringAlignment.Near;
    this.AllocationChart.Tooltips.FormatString = "<ITEM_LABEL> <DATA_VALUE:c>";
    this.AllocationChart.Tooltips.UseControl = false;
    view3Dappearance.Scale = 80f;
    view3Dappearance.XRotation = 150f;
    this.AllocationChart.Transform3D = view3Dappearance;
    ((Control) this.ultraExplorerBarContainerControl4).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.ultraExplorerBarContainerControl4).Controls.Add((Control) this.panelCostCenterAllocation);
    ((Control) this.ultraExplorerBarContainerControl4).Location = new Point(475, 38);
    ((Control) this.ultraExplorerBarContainerControl4).Name = "ultraExplorerBarContainerControl4";
    ((Control) this.ultraExplorerBarContainerControl4).Size = new Size(439, 368);
    ((Control) this.ultraExplorerBarContainerControl4).TabIndex = 3;
    this.panelCostCenterAllocation.AutoScroll = true;
    this.panelCostCenterAllocation.BackColor = Color.Transparent;
    this.panelCostCenterAllocation.BorderStyle = BorderStyle.FixedSingle;
    this.panelCostCenterAllocation.Dock = DockStyle.Fill;
    this.panelCostCenterAllocation.Location = new Point(0, 0);
    this.panelCostCenterAllocation.Name = "panelCostCenterAllocation";
    this.panelCostCenterAllocation.Size = new Size(439, 368);
    this.panelCostCenterAllocation.TabIndex = 14;
    ((AppearanceBase) appearance1).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance1).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance1).BorderAlpha = (Alpha) 2;
    ((AppearanceBase) appearance1).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance1).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance1).ImageBackground = (Image) resourceManager.GetObject("appearance1.ImageBackground");
    this.CostCenterAllocationMenu.Appearance = (AppearanceBase) appearance1;
    this.CostCenterAllocationMenu.DesignerFlags = 1;
    this.CostCenterAllocationMenu.DockWithinContainer = (Control) this;
    this.CostCenterAllocationMenu.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(166, 202, 238);
    ((SettingsBase) ultraToolbar.Settings).Appearance = (AppearanceBase) appearance2;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.ShowInToolbarList = false;
    ultraToolbar.Text = "CostCenterAllocation";
    ((ToolBase) buttonTool1).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) ((UltraToolbarBase) ultraToolbar).Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3
    });
    this.CostCenterAllocationMenu.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance3).Image = resourceManager.GetObject("appearance3.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance3;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = "Save";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance4).Image = resourceManager.GetObject("appearance4.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance4;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).Caption = "Reset Allocations";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance5).Image = resourceManager.GetObject("appearance5.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance5;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedProps).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.CostCenterAllocationMenu.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6
    });
    this.CostCenterAllocationMenu.ToolClick += new ToolClickEventHandler(this.CostCenterAllocationMenu_ToolClick);
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(166, 202, 238);
    this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Top).Name = "_frmExpenseDetailAllocation_Toolbars_Dock_Area_Top";
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Top).Size = new Size(928, 24);
    this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Top.ToolbarsManager = this.CostCenterAllocationMenu;
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(166, 202, 238);
    this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Bottom).Location = new Point(0, 526);
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Bottom).Name = "_frmExpenseDetailAllocation_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Bottom).Size = new Size(928, 0);
    this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.CostCenterAllocationMenu;
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(166, 202, 238);
    this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Left).Location = new Point(0, 24);
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Left).Name = "_frmExpenseDetailAllocation_Toolbars_Dock_Area_Left";
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Left).Size = new Size(0, 502);
    this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Left.ToolbarsManager = this.CostCenterAllocationMenu;
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(166, 202, 238);
    this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Right).Location = new Point(928, 24);
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Right).Name = "_frmExpenseDetailAllocation_Toolbars_Dock_Area_Right";
    ((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Right).Size = new Size(0, 502);
    this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Right.ToolbarsManager = this.CostCenterAllocationMenu;
    this.Panel1.BackColor = Color.White;
    this.Panel1.Controls.Add((Control) this.lblAmount);
    this.Panel1.Controls.Add((Control) this.label4);
    this.Panel1.Controls.Add((Control) this.lblTransDate);
    this.Panel1.Controls.Add((Control) this.label3);
    this.Panel1.Controls.Add((Control) this.lblAccountName);
    this.Panel1.Controls.Add((Control) this.label1);
    this.Panel1.Controls.Add((Control) this.ultraExplorerBar1);
    this.Panel1.Dock = DockStyle.Fill;
    this.Panel1.Location = new Point(0, 24);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(928, 502);
    this.Panel1.TabIndex = 14;
    this.lblAmount.AutoSize = true;
    this.lblAmount.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblAmount.Location = new Point(136, 56);
    this.lblAmount.Name = "lblAmount";
    this.lblAmount.Size = new Size(12, 16 /*0x10*/);
    this.lblAmount.TabIndex = 31 /*0x1F*/;
    this.lblAmount.Text = "{}";
    this.lblAmount.TextAlign = ContentAlignment.MiddleCenter;
    this.label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label4.Location = new Point(16 /*0x10*/, 56);
    this.label4.Name = "label4";
    this.label4.Size = new Size(56, 16 /*0x10*/);
    this.label4.TabIndex = 30;
    this.label4.Text = "Amount :";
    this.lblTransDate.AutoSize = true;
    this.lblTransDate.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblTransDate.Location = new Point(136, 32 /*0x20*/);
    this.lblTransDate.Name = "lblTransDate";
    this.lblTransDate.Size = new Size(12, 16 /*0x10*/);
    this.lblTransDate.TabIndex = 29;
    this.lblTransDate.Text = "{}";
    this.label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label3.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.label3.Name = "label3";
    this.label3.Size = new Size(104, 16 /*0x10*/);
    this.label3.TabIndex = 28;
    this.label3.Text = "Transaction Date:";
    this.lblAccountName.AutoSize = true;
    this.lblAccountName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblAccountName.Location = new Point(136, 8);
    this.lblAccountName.Name = "lblAccountName";
    this.lblAccountName.Size = new Size(12, 16 /*0x10*/);
    this.lblAccountName.TabIndex = 27;
    this.lblAccountName.Text = "{}";
    this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(16 /*0x10*/, 8);
    this.label1.Name = "label1";
    this.label1.Size = new Size(88, 16 /*0x10*/);
    this.label1.TabIndex = 26;
    this.label1.Text = "Account Name :";
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BackColor2 = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.Appearance = (AppearanceBase) appearance6;
    this.ultraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.ultraExplorerBar1.ColumnCount = 2;
    this.ultraExplorerBar1.ColumnSpacing = 10;
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl3);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl4);
    explorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
    explorerBarGroup1.Settings.ContainerHeight = 370;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "Allocation Breakout";
    explorerBarGroup2.Container = this.ultraExplorerBarContainerControl4;
    explorerBarGroup2.Settings.ContainerHeight = 370;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "Allocate Detail Item";
    this.ultraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[2]
    {
      explorerBarGroup1,
      explorerBarGroup2
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
    ((AppearanceBase) appearance8).ImageBackground = (Image) resourceManager.GetObject("appearance8.ImageBackground");
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance9;
    this.ultraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Bottom = 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Left = 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Right = 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Top = 4;
    this.ultraExplorerBar1.GroupSpacing = 10;
    ((Control) this.ultraExplorerBar1).Location = new Point(0, 80 /*0x50*/);
    this.ultraExplorerBar1.Margins.Bottom = 8;
    this.ultraExplorerBar1.Margins.Left = 8;
    this.ultraExplorerBar1.Margins.Right = 8;
    this.ultraExplorerBar1.Margins.Top = 8;
    ((Control) this.ultraExplorerBar1).Name = "ultraExplorerBar1";
    this.ultraExplorerBar1.NavigationAllowGroupReorder = false;
    this.ultraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.ultraExplorerBar1).Size = new Size(928, 632);
    ((UltraControlBase) this.ultraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraExplorerBar1).TabIndex = 25;
    this.ultraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(928, 526);
    this.ControlBox = false;
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._frmExpenseDetailAllocation_Toolbars_Dock_Area_Bottom);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formCostCenterAllocation);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Expense Detail - Cost Center Allocations";
    ((Control) this.ultraExplorerBarContainerControl3).ResumeLayout(false);
    ((ISupportInitialize) this.AllocationChart).EndInit();
    ((Control) this.ultraExplorerBarContainerControl4).ResumeLayout(false);
    ((ISupportInitialize) this.CostCenterAllocationMenu).EndInit();
    this.Panel1.ResumeLayout(false);
    ((ISupportInitialize) this.ultraExplorerBar1).EndInit();
    ((Control) this.ultraExplorerBar1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void DisplayHeader()
  {
    this.lblAccountName.Text = this.DetailObject.GLAccountName;
    this.lblAmount.Text = this.DetailObject.TransactionTotal.ToString();
    this.lblTransDate.Text = this.DetailObject.TransactionDate.ToShortDateString();
  }

  private void BuildCostCeterAllocationList()
  {
    DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("spFin_GetCostCenterAllocationList", (object) "@glcompanyid", (object) this.glCompanyId);
    int y = 4;
    Label label1;
    MGATextBox mgaTextBox1;
    foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
    {
      Label label2 = new Label();
      label2.Name = "lbl" + row[1].ToString();
      label2.Size = new Size(140, 16 /*0x10*/);
      label2.Font = new Font("Arial", 8.25f, FontStyle.Bold);
      label2.Text = row[1].ToString();
      label2.Tag = row[0];
      this.toolTip1.SetToolTip((Control) label2, row[1].ToString());
      if (Convert.ToBoolean(row[2]))
        label2.ForeColor = Color.Black;
      else
        label2.ForeColor = SystemColors.ControlDarkDark;
      this.panelCostCenterAllocation.Controls.Add((Control) label2);
      label2.Location = new Point(4, y);
      label1 = (Label) null;
      MGATextBox mgaTextBox2 = new MGATextBox();
      mgaTextBox2.MGAStyle = MGAStyles.Blue;
      ((Control) mgaTextBox2).Name = "txt" + row[1].ToString();
      ((Control) mgaTextBox2).Tag = row[0];
      ((Control) mgaTextBox2).Size = new Size(130, 16 /*0x10*/);
      ((Control) mgaTextBox2).Text = "$0.00";
      this.toolTip1.SetToolTip((Control) mgaTextBox2, "Enter Allocation For: " + row[1].ToString());
      ((Control) mgaTextBox2).Validating += new CancelEventHandler(this.ValidateAllocations);
      this.panelCostCenterAllocation.Controls.Add((Control) mgaTextBox2);
      ((Control) mgaTextBox2).Location = new Point(148, y);
      mgaTextBox1 = (MGATextBox) null;
      Label label3 = new Label();
      label3.BorderStyle = BorderStyle.FixedSingle;
      label3.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
      label3.Text = "%";
      label3.Font = new Font("Arial", 9f, FontStyle.Bold);
      label3.Cursor = Cursors.Hand;
      label3.Tag = (object) false;
      label3.Click += new EventHandler(this.PercentLabelClick);
      this.panelCostCenterAllocation.Controls.Add((Control) label3);
      label3.Location = new Point(279, y);
      y += 22;
    }
    Label label4 = new Label();
    label4.Name = "lblLine";
    label4.Text = "";
    label4.Size = new Size(138, 1);
    label4.BackColor = Color.Black;
    this.panelCostCenterAllocation.Controls.Add((Control) label4);
    label4.Location = new Point(140, y + 4);
    label1 = (Label) null;
    Label label5 = new Label();
    label5.Size = new Size(140, 16 /*0x10*/);
    label5.Name = "lblAmtRemaining";
    label5.Text = "Amt. Remaining:";
    label5.Font = new Font("Arial", 9f, FontStyle.Bold);
    label5.ForeColor = Color.Black;
    this.panelCostCenterAllocation.Controls.Add((Control) label5);
    label5.Location = new Point(4, y + 8);
    label1 = (Label) null;
    MGATextBox mgaTextBox3 = new MGATextBox();
    ((Control) mgaTextBox3).Name = "txtAmtRem";
    ((Control) mgaTextBox3).Size = new Size(130, 16 /*0x10*/);
    ((Control) mgaTextBox3).Font = new Font("Arial", 9f, FontStyle.Bold);
    ((EditorButtonControlBase) mgaTextBox3).ReadOnly = true;
    ((Control) mgaTextBox3).TabStop = false;
    ((Control) mgaTextBox3).ForeColor = Color.Black;
    ((Control) mgaTextBox3).Text = this.DetailObject.TransactionTotal.ToString("c");
    this.panelCostCenterAllocation.Controls.Add((Control) mgaTextBox3);
    ((Control) mgaTextBox3).Location = new Point(148, y + 8);
    mgaTextBox1 = (MGATextBox) null;
    Label label6 = new Label();
    label6.Size = new Size(140, 16 /*0x10*/);
    label6.Name = "lblTotal";
    label6.Text = "Total:";
    label6.Font = new Font("Arial", 9f, FontStyle.Bold);
    label6.ForeColor = Color.Black;
    this.panelCostCenterAllocation.Controls.Add((Control) label6);
    label6.Location = new Point(4, y + 30);
    label1 = (Label) null;
    MGATextBox mgaTextBox4 = new MGATextBox();
    ((Control) mgaTextBox4).Name = "txtTotal";
    ((Control) mgaTextBox4).Size = new Size(130, 16 /*0x10*/);
    ((Control) mgaTextBox4).Font = new Font("Arial", 9f, FontStyle.Bold);
    ((EditorButtonControlBase) mgaTextBox4).ReadOnly = true;
    ((Control) mgaTextBox4).TabStop = false;
    ((Control) mgaTextBox4).ForeColor = Color.Black;
    ((Control) mgaTextBox4).Text = "$0.00";
    this.panelCostCenterAllocation.Controls.Add((Control) mgaTextBox4);
    ((Control) mgaTextBox4).Location = new Point(148, y + 30);
    mgaTextBox1 = (MGATextBox) null;
  }

  private void PercentLabelClick(object sender, EventArgs e)
  {
    if (!(sender is Label))
      return;
    int index = int.Parse(this.panelCostCenterAllocation.Controls.IndexOf((Control) sender).ToString());
    if (this.panelCostCenterAllocation.Controls[index - 1].Text == string.Empty)
      return;
    if (this.panelCostCenterAllocation.Controls[index - 1] is TextBox)
    {
      if (this.panelCostCenterAllocation.Controls[index - 1].Text.Equals(string.Empty))
        return;
      if (!Information.IsNumeric((object) this.panelCostCenterAllocation.Controls[index - 1].Text))
      {
        int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.Services.StringResourceManager.GetString("AllocatedAmountMustBeNumeric"), MGASystems.IMS.Accounting.Services.StringResourceManager.GetString("INVALIDENTRY"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ((Control) sender).BackColor = SystemColors.Control;
        ((Control) sender).Tag = (object) false;
        return;
      }
    }
    if (Convert.ToBoolean(this.panelCostCenterAllocation.Controls[index].Tag))
    {
      ((Control) sender).BackColor = SystemColors.Control;
      ((Control) sender).Tag = (object) false;
    }
    else
    {
      if (DecimalType.FromString(this.panelCostCenterAllocation.Controls[index - 1].Text) > 100M)
      {
        int num = (int) MessageBox.Show("Percentage can not be greater than 100.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        ((Control) sender).BackColor = SystemColors.Control;
        ((Control) sender).Tag = (object) false;
      }
      else
      {
        Decimal num = this.DetailObject.TransactionTotal * (Decimal.Parse(this.panelCostCenterAllocation.Controls[index - 1].Text.Replace("$", string.Empty)) / 100M);
        this.panelCostCenterAllocation.Controls[index - 1].Text = num.ToString("c");
        this.ValidateAllocations((object) (MGATextBox) this.panelCostCenterAllocation.Controls[index - 1], new CancelEventArgs());
      }
      ((Control) sender).BackColor = Color.LightSteelBlue;
      ((Control) sender).Tag = (object) true;
    }
  }

  private void ValidateAllocations(object sender, CancelEventArgs e)
  {
    if (!(sender is MGATextBox))
      return;
    Decimal num1 = Decimal.Parse(((Control) (sender as MGATextBox)).Text, NumberStyles.Any);
    if (((Control) sender).Text.Equals(string.Empty))
      this.RemoveAllocation(int.Parse(((Control) sender).Tag.ToString()));
    else if (!Information.IsNumeric((object) ((Control) sender).Text))
    {
      int num2 = (int) MessageBox.Show(MGASystems.IMS.Accounting.Services.StringResourceManager.GetString("AllocatedAmountMustBeNumeric"), MGASystems.IMS.Accounting.Services.StringResourceManager.GetString("INVALIDENTRY"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
      ((TextEditorControlBase) sender).Focus();
    }
    else
    {
      this.RemoveAllocation(int.Parse(((Control) sender).Tag.ToString()));
      if (num1 + this.DetailObject.CostCenterAllocations.AllocationsTotal() > this.DetailObject.TransactionTotal)
      {
        int num3 = (int) MessageBox.Show(MGASystems.IMS.Accounting.Services.StringResourceManager.GetString("AllocationGreaterThanExpense"), MGASystems.IMS.Accounting.Services.StringResourceManager.GetString("InvalidAllocation"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Cancel = true;
      }
      else if (num1 > this.DetailObject.CostCenterAllocations.UnAllocatedTotal(this.DetailObject.TransactionTotal))
      {
        int num4 = (int) MessageBox.Show(MGASystems.IMS.Accounting.Services.StringResourceManager.GetString("AllocationWillExceedUnAllocatedBalance"), MGASystems.IMS.Accounting.Services.StringResourceManager.GetString("InvalidAllocation"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Cancel = true;
      }
      else
      {
        ((Control) sender).Text = num1.ToString("c");
        try
        {
          if (((Control) sender).Text == "$0.00")
          {
            this.RemoveAllocation(int.Parse(((Control) sender).Tag.ToString()));
          }
          else
          {
            this.DetailObject.CostCenterAllocations.Add(new CostCenterAllocation(int.Parse(((Control) sender).Tag.ToString()), Decimal.Parse(((Control) sender).Text, NumberStyles.Currency)), this.DetailObject.TransactionTotal);
            this.RefreshChartData();
          }
        }
        catch (Exception ex)
        {
          int num5 = (int) MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
    }
  }

  private void RemoveAllocation(int CostCenterId)
  {
    foreach (CostCenterAllocation centerAllocation in (CollectionBase) this.DetailObject.CostCenterAllocations)
    {
      if (centerAllocation.CostCenterId == CostCenterId)
      {
        this.DetailObject.CostCenterAllocations.Remove(this.DetailObject.CostCenterAllocations.IndexOf(centerAllocation));
        break;
      }
    }
    this.RefreshChartData();
  }

  private void RefreshTotals()
  {
    if (this.panelCostCenterAllocation.Controls.Count == 0 || !(this.panelCostCenterAllocation.Controls[this.panelCostCenterAllocation.Controls.Count - 1] is MGATextBox))
      return;
    Decimal num = this.DetailObject.TransactionTotal - this.DetailObject.CostCenterAllocations.AllocationsTotal();
    this.panelCostCenterAllocation.Controls[this.panelCostCenterAllocation.Controls.Count - 1].Text = this.DetailObject.CostCenterAllocations.AllocationsTotal().ToString("c");
    this.panelCostCenterAllocation.Controls[this.panelCostCenterAllocation.Controls.Count - 3].Text = num.ToString("c");
  }

  private void ResetAllocations()
  {
    this.DetailObject.CostCenterAllocations.Clear();
    foreach (Control control in (ArrangedElementCollection) this.panelCostCenterAllocation.Controls)
    {
      if (control is MGATextBox)
        control.Text = MGASystems.IMS.Accounting.Services.StringResourceManager.GetString("EmptyString");
    }
    this.AllocationChart.DataSource = (object) this.DetailObject.CostCenterAllocations.ToChartDataTable(this.DetailObject.TransactionTotal);
    this.RefreshTotals();
  }

  private void AllocationListChanged(object sender, EventArgs e) => this.RefreshChartData();

  private void RefreshChartData()
  {
    this.AllocationChart.DataSource = (object) this.DetailObject.CostCenterAllocations.ToChartDataTable(this.DetailObject.TransactionTotal);
    this.RefreshTotals();
  }

  private void CostCenterAllocationMenu_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "ACCT_SAVEDETAILALLOCATION":
        if (this.DetailObject.CostCenterAllocations.UnAllocatedTotal(this.DetailObject.TransactionTotal) == 0M)
        {
          this.DialogResult = DialogResult.OK;
          this.Close();
          break;
        }
        int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.Services.StringResourceManager.GetString("ExpenseMustBeFullyAllocated"), MGASystems.IMS.Accounting.Services.StringResourceManager.GetString("ExpenseAllocationNotComplete"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      case "ACCT_REFRESHDETAILALLOCATION":
        try
        {
          this.Cursor = Cursors.WaitCursor;
          this.ResetAllocations();
          break;
        }
        finally
        {
          this.Cursor = Cursors.Default;
        }
      case "Cancel":
        this.DialogResult = DialogResult.Cancel;
        this.Close();
        break;
    }
  }

  private void DisplayCurrentAllocations()
  {
    if (this.DetailObject == null || this.DetailObject.CostCenterAllocations == null || this.DetailObject.CostCenterAllocations.Count == 0)
      return;
    foreach (CostCenterAllocation centerAllocation in (CollectionBase) this.DetailObject.CostCenterAllocations)
    {
      foreach (Control control in (ArrangedElementCollection) this.panelCostCenterAllocation.Controls)
      {
        if (control is MGATextBox && control.Tag != null && control.Tag.ToString() == centerAllocation.CostCenterId.ToString())
          control.Text = centerAllocation.AllocatedAmount.ToString("c");
      }
    }
  }

  public ISupportCostCenterAllocation TransactionDetail
  {
    get
    {
      if (this.DialogResult != DialogResult.OK)
        return (ISupportCostCenterAllocation) null;
      int index = 0;
      while (index < this.DetailObject.CostCenterAllocations.Count)
      {
        if (this.DetailObject.CostCenterAllocations[index].AllocatedAmount == 0.0M)
          this.DetailObject.CostCenterAllocations.Remove(index);
        else
          ++index;
      }
      return this.DetailObject;
    }
  }
}

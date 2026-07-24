// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.ExpenseSchedule
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinSchedule;
using Infragistics.Win.UltraWinToolbars;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.UserControls;

public class ExpenseSchedule : UserControl
{
  private UltraMonthViewSingle ultraMonthViewSingle1;
  private UltraDayView ultraDayView1;
  private UltraWeekView ultraWeekView1;
  private Panel panelMonthView;
  private Panel panelDayView;
  private Panel panelWeekView;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _ExpenseSchedule_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _ExpenseSchedule_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _ExpenseSchedule_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _ExpenseSchedule_Toolbars_Dock_Area_Bottom;
  private UltraCalendarLook ultraCalendarLook1;
  private UltraCalendarInfo ultraCalendarInfo1;
  private IContainer components;

  public ExpenseSchedule() => this.InitializeComponent();

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
    UltraToolbar ultraToolbar = new UltraToolbar("ExpenseScheduleTools");
    Appearance appearance2 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (ExpenseSchedule));
    LabelTool labelTool1 = new LabelTool("Expense Scheduler");
    ButtonTool buttonTool1 = new ButtonTool("DayView");
    ButtonTool buttonTool2 = new ButtonTool("WeekView");
    ButtonTool buttonTool3 = new ButtonTool("MonthView");
    LabelTool labelTool2 = new LabelTool("Expense Scheduler");
    Appearance appearance3 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("DayView");
    Appearance appearance4 = new Appearance();
    ButtonTool buttonTool5 = new ButtonTool("WeekView");
    Appearance appearance5 = new Appearance();
    ButtonTool buttonTool6 = new ButtonTool("MonthView");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    DayOfWeekLook dayOfWeekLook1 = new DayOfWeekLook(DayOfWeek.Sunday);
    Appearance appearance9 = new Appearance();
    DayOfWeekLook dayOfWeekLook2 = new DayOfWeekLook(DayOfWeek.Monday);
    Appearance appearance10 = new Appearance();
    DayOfWeekLook dayOfWeekLook3 = new DayOfWeekLook(DayOfWeek.Tuesday);
    Appearance appearance11 = new Appearance();
    DayOfWeekLook dayOfWeekLook4 = new DayOfWeekLook(DayOfWeek.Wednesday);
    Appearance appearance12 = new Appearance();
    DayOfWeekLook dayOfWeekLook5 = new DayOfWeekLook(DayOfWeek.Thursday);
    Appearance appearance13 = new Appearance();
    DayOfWeekLook dayOfWeekLook6 = new DayOfWeekLook(DayOfWeek.Friday);
    Appearance appearance14 = new Appearance();
    DayOfWeekLook dayOfWeekLook7 = new DayOfWeekLook(DayOfWeek.Saturday);
    Appearance appearance15 = new Appearance();
    this.ultraMonthViewSingle1 = new UltraMonthViewSingle();
    this.ultraDayView1 = new UltraDayView();
    this.ultraWeekView1 = new UltraWeekView();
    this.panelMonthView = new Panel();
    this.panelDayView = new Panel();
    this.panelWeekView = new Panel();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._ExpenseSchedule_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._ExpenseSchedule_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._ExpenseSchedule_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._ExpenseSchedule_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.ultraCalendarLook1 = new UltraCalendarLook(this.components);
    this.ultraCalendarInfo1 = new UltraCalendarInfo(this.components);
    ((ISupportInitialize) this.ultraMonthViewSingle1).BeginInit();
    ((ISupportInitialize) this.ultraDayView1).BeginInit();
    ((ISupportInitialize) this.ultraWeekView1).BeginInit();
    this.panelMonthView.SuspendLayout();
    this.panelDayView.SuspendLayout();
    this.panelWeekView.SuspendLayout();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((UltraMonthViewSingleBase) this.ultraMonthViewSingle1).BorderStyle = (UIElementBorderStyle) 1;
    ((UltraMonthViewSingleBase) this.ultraMonthViewSingle1).BorderStyleDay = (UIElementBorderStyle) 4;
    this.ultraMonthViewSingle1.BorderStyleDayOfWeekHeader = (UIElementBorderStyle) 4;
    this.ultraMonthViewSingle1.BorderStyleWeekNumber = (UIElementBorderStyle) 1;
    ((UltraScheduleControlBase) this.ultraMonthViewSingle1).CalendarLook = this.ultraCalendarLook1;
    ((UltraMonthViewSingleBase) this.ultraMonthViewSingle1).DayDisplayStyle = (DayDisplayStyleEnum) 1;
    ((Control) this.ultraMonthViewSingle1).Dock = DockStyle.Fill;
    ((UltraControlBase) this.ultraMonthViewSingle1).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.ultraMonthViewSingle1).Location = new Point(0, 0);
    ((Control) this.ultraMonthViewSingle1).Name = "ultraMonthViewSingle1";
    ((Control) this.ultraMonthViewSingle1).Size = new Size(736, 536);
    ((UltraControlBase) this.ultraMonthViewSingle1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraMonthViewSingle1).TabIndex = 0;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    this.ultraDayView1.Appearance = (AppearanceBase) appearance1;
    ((Control) this.ultraDayView1).Dock = DockStyle.Fill;
    ((Control) this.ultraDayView1).Location = new Point(0, 0);
    ((Control) this.ultraDayView1).Name = "ultraDayView1";
    ((Control) this.ultraDayView1).Size = new Size(736, 536);
    ((Control) this.ultraDayView1).TabIndex = 1;
    ((Control) this.ultraDayView1).Text = "ultraDayView1";
    ((UltraScheduleControlBase) this.ultraWeekView1).CalendarLook = this.ultraCalendarLook1;
    ((Control) this.ultraWeekView1).Dock = DockStyle.Fill;
    ((UltraControlBase) this.ultraWeekView1).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.ultraWeekView1).Location = new Point(0, 0);
    ((Control) this.ultraWeekView1).Name = "ultraWeekView1";
    ((Control) this.ultraWeekView1).Size = new Size(736, 536);
    ((Control) this.ultraWeekView1).TabIndex = 3;
    this.panelMonthView.Controls.Add((Control) this.ultraMonthViewSingle1);
    this.panelMonthView.Dock = DockStyle.Fill;
    this.panelMonthView.Location = new Point(0, 24);
    this.panelMonthView.Name = "panelMonthView";
    this.panelMonthView.Size = new Size(736, 536);
    this.panelMonthView.TabIndex = 7;
    this.panelDayView.Controls.Add((Control) this.ultraDayView1);
    this.panelDayView.Dock = DockStyle.Fill;
    this.panelDayView.Location = new Point(0, 24);
    this.panelDayView.Name = "panelDayView";
    this.panelDayView.Size = new Size(736, 536);
    this.panelDayView.TabIndex = 8;
    this.panelWeekView.Controls.Add((Control) this.ultraWeekView1);
    this.panelWeekView.Dock = DockStyle.Fill;
    this.panelWeekView.Location = new Point(0, 24);
    this.panelWeekView.Name = "panelWeekView";
    this.panelWeekView.Size = new Size(736, 536);
    this.panelWeekView.TabIndex = 9;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 1;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).ImageBackground = (Image) resourceManager.GetObject("appearance2.ImageBackground");
    ((SettingsBase) ultraToolbar.Settings).Appearance = (AppearanceBase) appearance2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.Text = "Expense Scheduler";
    ((ToolsCollectionBase) ((UltraToolbarBase) ultraToolbar).Tools).AddRange(new ToolBase[4]
    {
      (ToolBase) labelTool1,
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3
    });
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolBase) labelTool2).SharedProps.AllowMultipleInstances = false;
    ((AppearanceBase) appearance3).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance3).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance3).FontData.SizeInPoints = 12f;
    ((AppearanceBase) appearance3).ForeColor = Color.White;
    ((AppearanceBase) appearance3).TextHAlign = (HAlign) 1;
    ((ToolPropsBase) ((ToolBase) labelTool2).SharedProps).AppearancesSmall.AppearanceOnToolbar = (AppearanceBase) appearance3;
    ((ToolPropsBase) ((ToolBase) labelTool2).SharedProps).Caption = "Expense Scheduler";
    ((ToolPropsBase) ((ToolBase) labelTool2).SharedProps).DisplayStyle = (ToolDisplayStyle) 2;
    ((ToolPropsBase) ((ToolBase) labelTool2).SharedProps).Width = 200;
    ((AppearanceBase) appearance4).ForeColor = Color.White;
    ((AppearanceBase) appearance4).Image = resourceManager.GetObject("appearance4.Image");
    ((AppearanceBase) appearance4).TextHAlign = (HAlign) 3;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).AppearancesSmall.AppearanceOnToolbar = (AppearanceBase) appearance4;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = "Day View";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance5).ForeColor = Color.White;
    ((AppearanceBase) appearance5).Image = resourceManager.GetObject("appearance5.Image");
    ((AppearanceBase) appearance5).TextHAlign = (HAlign) 3;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).AppearancesSmall.AppearanceOnToolbar = (AppearanceBase) appearance5;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).Caption = "Week View";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance6).ForeColor = Color.White;
    ((AppearanceBase) appearance6).Image = resourceManager.GetObject("appearance6.Image");
    ((AppearanceBase) appearance6).TextHAlign = (HAlign) 3;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedProps).AppearancesSmall.AppearanceOnToolbar = (AppearanceBase) appearance6;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedProps).Caption = "Month View";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[4]
    {
      (ToolBase) labelTool2,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6
    });
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._ExpenseSchedule_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Left).Location = new Point(0, 24);
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Left).Name = "_ExpenseSchedule_Toolbars_Dock_Area_Left";
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Left).Size = new Size(0, 536);
    this._ExpenseSchedule_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._ExpenseSchedule_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Right).Location = new Point(736, 24);
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Right).Name = "_ExpenseSchedule_Toolbars_Dock_Area_Right";
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Right).Size = new Size(0, 536);
    this._ExpenseSchedule_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._ExpenseSchedule_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Top).Name = "_ExpenseSchedule_Toolbars_Dock_Area_Top";
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Top).Size = new Size(736, 24);
    this._ExpenseSchedule_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._ExpenseSchedule_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Bottom).Location = new Point(0, 560);
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Bottom).Name = "_ExpenseSchedule_Toolbars_Dock_Area_Bottom";
    ((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Bottom).Size = new Size(736, 0);
    this._ExpenseSchedule_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    ((AppearanceBase) appearance7).BackColor = Color.LightSteelBlue;
    this.ultraCalendarLook1.DayHeaderAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.LightSteelBlue;
    this.ultraCalendarLook1.DayOfWeekHeaderAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    dayOfWeekLook1.HeaderAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BackColor = Color.LightSteelBlue;
    dayOfWeekLook2.HeaderAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.LightSteelBlue;
    dayOfWeekLook3.HeaderAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.LightSteelBlue;
    dayOfWeekLook4.HeaderAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BackColor = Color.LightSteelBlue;
    dayOfWeekLook5.HeaderAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BackColor = Color.LightSteelBlue;
    dayOfWeekLook6.HeaderAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    dayOfWeekLook7.HeaderAppearance = (AppearanceBase) appearance15;
    ((SubObjectsArrayBase) this.ultraCalendarLook1.DaysOfWeekLook).Add((SubObjectBase) dayOfWeekLook1);
    ((SubObjectsArrayBase) this.ultraCalendarLook1.DaysOfWeekLook).Add((SubObjectBase) dayOfWeekLook2);
    ((SubObjectsArrayBase) this.ultraCalendarLook1.DaysOfWeekLook).Add((SubObjectBase) dayOfWeekLook3);
    ((SubObjectsArrayBase) this.ultraCalendarLook1.DaysOfWeekLook).Add((SubObjectBase) dayOfWeekLook4);
    ((SubObjectsArrayBase) this.ultraCalendarLook1.DaysOfWeekLook).Add((SubObjectBase) dayOfWeekLook5);
    ((SubObjectsArrayBase) this.ultraCalendarLook1.DaysOfWeekLook).Add((SubObjectBase) dayOfWeekLook6);
    ((SubObjectsArrayBase) this.ultraCalendarLook1.DaysOfWeekLook).Add((SubObjectBase) dayOfWeekLook7);
    ((DataBindingsBase) this.ultraCalendarInfo1.DataBindingsForAppointments).BindingContextControl = (Control) this;
    ((DataBindingsBase) this.ultraCalendarInfo1.DataBindingsForOwners).BindingContextControl = (Control) this;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.panelWeekView);
    this.Controls.Add((Control) this.panelMonthView);
    this.Controls.Add((Control) this.panelDayView);
    this.Controls.Add((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._ExpenseSchedule_Toolbars_Dock_Area_Bottom);
    this.Name = nameof (ExpenseSchedule);
    this.Size = new Size(736, 560);
    ((ISupportInitialize) this.ultraMonthViewSingle1).EndInit();
    ((ISupportInitialize) this.ultraDayView1).EndInit();
    ((ISupportInitialize) this.ultraWeekView1).EndInit();
    this.panelMonthView.ResumeLayout(false);
    this.panelDayView.ResumeLayout(false);
    this.panelWeekView.ResumeLayout(false);
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }
}

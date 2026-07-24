// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.FormNOCDeactivation
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinSchedule;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Forms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services;

[TestForm]
public class FormNOCDeactivation : Form
{
  private const string DEFAULT_SUBJECT = "NOC Blackout Date";
  private IContainer components;
  private UltraMonthViewSingle monthViewSingle;
  private UltraMonthViewMulti monthViewMulti;
  private UltraCalendarLook ultraCalendarLook1;
  private UltraCalendarInfo ultraCalendarInfo1;
  private UltraToolbarsDockArea _FormNOCDeactivation_Toolbars_Dock_Area_Left;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _FormNOCDeactivation_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormNOCDeactivation_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _FormNOCDeactivation_Toolbars_Dock_Area_Bottom;
  private dsBlackoutDates dsBlackoutDates1;

  public FormNOCDeactivation()
  {
    this.InitializeComponent();
    this.LoadBlackoutDates();
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "ADD":
        this.AddBlackoutDate();
        break;
      case "REMOVE":
        this.DeleteBlackoutDate();
        break;
    }
  }

  private void AddBlackoutDate()
  {
    DateTime dateTime = this.ultraCalendarInfo1.SelectedDateRanges[0].EndDate;
    DateTime date1 = dateTime.Date;
    dateTime = DateTime.Now;
    DateTime date2 = dateTime.Date;
    if (date1 < date2)
    {
      int num1 = (int) MessageBox.Show("You can not enter blackout dates for past periods. All blackout dates older than 6 months will automatically be deleted from the data table.", "Invalid Entry Date!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      using (Appointment appointment = new Appointment(this.ultraCalendarInfo1.SelectedDateRanges[0].StartDate, this.ultraCalendarInfo1.SelectedDateRanges[0].EndDate))
      {
        if (this.BlackoutDateExists(appointment.StartDateTime, appointment.EndDateTime))
        {
          int num2 = (int) MessageBox.Show("The blackout date or a date within the range of blackout dates you are adding already exists. Please check the date(s) and try again.", "Date Already Exists!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        appointment.Subject = "NOC Blackout Date";
        appointment.AllDayEvent = true;
        this.AddBlackoutDate(appointment.StartDateTime, appointment.EndDateTime);
        this.ultraCalendarInfo1.Appointments.Add(appointment);
      }
      this.LoadBlackoutDates();
    }
  }

  private void AddBlackoutDate(DateTime startDate, DateTime endDate)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_AddAutomatedNOCBlackOutDate", new object[8]
    {
      (object) "@startDate",
      (object) startDate,
      (object) "@endDate",
      (object) endDate,
      (object) "@description",
      (object) "NOC Blackout Date",
      (object) "@userGuid",
      (object) CurrentUser.Instance.UserGUID
    });
  }

  private void LoadBlackoutDates()
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      if (this.dsBlackoutDates1 != null)
        this.dsBlackoutDates1.Clear();
      DefaultDatabase.LoadDataSet((DataSet) this.dsBlackoutDates1, new string[1]
      {
        "BlackoutDates"
      }, "spFin_GetAutomatedNOCBlackoutDates");
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private bool BlackoutDateExists(DateTime startDate, DateTime endDate)
  {
    return (bool) DefaultDatabase.ExecuteScalar(CommandType.Text, "Select dbo.BlackoutDateExists(@startDate, @endDate)", new object[4]
    {
      (object) "@startDate",
      (object) startDate,
      (object) "@endDate",
      (object) endDate
    });
  }

  private void DeleteBlackoutDate()
  {
    Appointment appointment = this.ultraCalendarInfo1.SelectedDateRanges[0].CalendarInfo.Appointments[0];
    if (appointment == null)
      return;
    DefaultDatabase.ExecuteNonQuery("spFin_DeleteBlackoutDate", new object[2]
    {
      (object) "@rowId",
      (object) (int) appointment.DataKey
    });
    this.ultraCalendarInfo1.Appointments.Remove(appointment);
    ((DisposableObject) appointment).Dispose();
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
    Appearance appearance = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("MainToolbar");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("CalendarContext");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("CalendarContext");
    ButtonTool buttonTool1 = new ButtonTool("ADD");
    ButtonTool buttonTool2 = new ButtonTool("REMOVE");
    ButtonTool buttonTool3 = new ButtonTool("ADD");
    ButtonTool buttonTool4 = new ButtonTool("REMOVE");
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormNOCDeactivation));
    this.monthViewSingle = new UltraMonthViewSingle();
    this.ultraCalendarInfo1 = new UltraCalendarInfo(this.components);
    this.dsBlackoutDates1 = new dsBlackoutDates();
    this.ultraCalendarLook1 = new UltraCalendarLook(this.components);
    this.monthViewMulti = new UltraMonthViewMulti();
    this._FormNOCDeactivation_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormNOCDeactivation_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormNOCDeactivation_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormNOCDeactivation_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.monthViewSingle).BeginInit();
    this.dsBlackoutDates1.BeginInit();
    ((ISupportInitialize) this.monthViewMulti).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((UltraMonthViewSingleBase) this.monthViewSingle).AutoAppointmentDialog = false;
    ((UltraScheduleControlBase) this.monthViewSingle).CalendarInfo = this.ultraCalendarInfo1;
    ((UltraScheduleControlBase) this.monthViewSingle).CalendarLook = this.ultraCalendarLook1;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.monthViewSingle, "CalendarContext");
    ((Control) this.monthViewSingle).Dock = DockStyle.Fill;
    ((Control) this.monthViewSingle).Location = new Point(156, 0);
    ((Control) this.monthViewSingle).Name = "monthViewSingle";
    ((UltraMonthViewSingleBase) this.monthViewSingle).ShowClickToAddIndicator = (DefaultableBoolean) 2;
    ((Control) this.monthViewSingle).Size = new Size(824, 794);
    ((Control) this.monthViewSingle).TabIndex = 0;
    ((UltraMonthViewSingleBase) this.monthViewSingle).TimeDisplayStyle = (TimeDisplayStyleEnum) 3;
    ((UltraControlBase) this.monthViewSingle).UseFlatMode = (DefaultableBoolean) 2;
    ((UltraControlBase) this.monthViewSingle).UseOsThemes = (DefaultableBoolean) 2;
    this.monthViewSingle.WeekendDisplayStyle = (WeekendDisplayStyleEnum) 2;
    this.monthViewSingle.WeekHeaderDisplayStyle = (WeekHeaderDisplayStyle) 1;
    this.ultraCalendarInfo1.AllowRecurringAppointments = true;
    this.ultraCalendarInfo1.DataBindingsForAppointments.AllDayEventMember = "AllDayEvent";
    ((DataBindingsBase) this.ultraCalendarInfo1.DataBindingsForAppointments).BindingContextControl = (Control) this;
    this.ultraCalendarInfo1.DataBindingsForAppointments.DataKeyMember = "RowId";
    ((DataBindingsBase) this.ultraCalendarInfo1.DataBindingsForAppointments).DataMember = "BlackoutDates";
    ((DataBindingsBase) this.ultraCalendarInfo1.DataBindingsForAppointments).DataSource = (object) this.dsBlackoutDates1;
    this.ultraCalendarInfo1.DataBindingsForAppointments.EndDateTimeMember = "BlackoutEndDate";
    this.ultraCalendarInfo1.DataBindingsForAppointments.StartDateTimeMember = "BlackoutStartDate";
    this.ultraCalendarInfo1.DataBindingsForAppointments.SubjectMember = "BlackoutDescription";
    ((DataBindingsBase) this.ultraCalendarInfo1.DataBindingsForOwners).BindingContextControl = (Control) this;
    this.dsBlackoutDates1.DataSetName = "dsBlackoutDates";
    this.dsBlackoutDates1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((AppearanceBase) appearance).BackColor = Color.FromArgb((int) byte.MaxValue, 192 /*0xC0*/, 192 /*0xC0*/);
    this.ultraCalendarLook1.HolidayAppearance = (AppearanceBase) appearance;
    this.ultraCalendarLook1.ViewStyle = (ViewStyle) 4;
    ((UltraScheduleControlBase) this.monthViewMulti).CalendarInfo = this.ultraCalendarInfo1;
    ((UltraScheduleControlBase) this.monthViewMulti).CalendarLook = this.ultraCalendarLook1;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.monthViewMulti, "CalendarContext");
    ((Control) this.monthViewMulti).Dock = DockStyle.Left;
    ((Control) this.monthViewMulti).Location = new Point(0, 0);
    ((UltraMonthViewMultiBase) this.monthViewMulti).MonthDimensions = new Size(1, 6);
    ((Control) this.monthViewMulti).Name = "monthViewMulti";
    ((Control) this.monthViewMulti).Size = new Size(156, 792);
    ((Control) this.monthViewMulti).TabIndex = 1;
    ((UltraMonthViewMultiBase) this.monthViewMulti).TrailingDaysVisible = false;
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._FormNOCDeactivation_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Left).Name = "_FormNOCDeactivation_Toolbars_Dock_Area_Left";
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Left).Size = new Size(0, 794);
    this._FormNOCDeactivation_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "MainToolbar";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedProps).Caption = "CalendarContext";
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).Caption = "Add Blackout Date";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = "Remove Blackout Date";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._FormNOCDeactivation_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Right).Location = new Point(980, 0);
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Right).Name = "_FormNOCDeactivation_Toolbars_Dock_Area_Right";
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Right).Size = new Size(0, 794);
    this._FormNOCDeactivation_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._FormNOCDeactivation_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Top).Name = "_FormNOCDeactivation_Toolbars_Dock_Area_Top";
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Top).Size = new Size(980, 0);
    this._FormNOCDeactivation_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._FormNOCDeactivation_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Bottom).Location = new Point(0, 794);
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Bottom).Name = "_FormNOCDeactivation_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Bottom).Size = new Size(980, 0);
    this._FormNOCDeactivation_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(980, 794);
    this.Controls.Add((Control) this.monthViewSingle);
    this.Controls.Add((Control) this.monthViewMulti);
    this.Controls.Add((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._FormNOCDeactivation_Toolbars_Dock_Area_Bottom);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MinimumSize = new Size(988, 828);
    this.Name = nameof (FormNOCDeactivation);
    this.Text = "Automated NOC Deactivation Dates";
    ((ISupportInitialize) this.monthViewSingle).EndInit();
    this.dsBlackoutDates1.EndInit();
    ((ISupportInitialize) this.monthViewMulti).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }
}

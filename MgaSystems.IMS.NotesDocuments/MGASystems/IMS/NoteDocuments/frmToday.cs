// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmToday
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.IMS.NoteDocuments.Serialization;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SecureResource("{a5a1a012-9648-44a7-9c7c-7ef769fe287a}", "Mark All Read", "Controls whether or not a user can mark all messages read on the Today UI.", "Users")]
[SecureResource("{7ad09705-4768-4619-9a14-a88fd2ead2d2}", "Complete All Tasks", "Controls whether or not a user can complete all tasks on the Today UI.", "Users")]
[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
[Preference("Screens.Today.TaskGrid.ColumnWidths.Body", 119, false)]
[Preference("Screens.Today.TaskGrid.ColumnWidths.DueDate", 70, false)]
[Preference("Screens.Today.ShowOnStartup", true, false)]
[Preference("Screens.Today.TasksToDisplay", typeof (TaskDisplayStyle), "AllOpen", false)]
[Preference("Screens.Today.TaskGrid.ColumnWidths.PolicyNumber", 105, false)]
[Preference("Screens.Today.TaskGrid.ColumnWidths.InsuredPolicyName", 133, false)]
[Preference("Screens.Today.TaskGrid.NoteGridPreference", "", false)]
[Preference("Screens.Today.TaskGrid.TaskGridPreference", "", false)]
public class frmToday : Form, IFormSettingsIgnore, IUIElementDrawFilter
{
  private IContainer components;
  private dsToday DsToday;
  private bool _formLoaded;
  public const string PreferenceTodayTasksToDisplay = "Screens.Today.TasksToDisplay";
  [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId = "Member")]
  public const string PREFERENCE_TODAY_SHOWONSTARTUP = "Screens.Today.ShowOnStartup";
  public const string PreferenceTodayGridColumnWidthsBody = "Screens.Today.TaskGrid.ColumnWidths.Body";
  public const string PreferenceTodayGridColumnWidthsDueDate = "Screens.Today.TaskGrid.ColumnWidths.DueDate";
  public const string PreferenceTodayGridColumnWidthsPolicyNumber = "Screens.Today.TaskGrid.ColumnWidths.PolicyNumber";
  public const string PreferenceTodayGridColumnWidthsInsuredPolicyName = "Screens.Today.TaskGrid.ColumnWidths.InsuredPolicyName";
  public const string NoteGridPreference = "Screens.Today.TaskGrid.NoteGridPreference";
  public const string TaskGridPreference = "Screens.Today.TaskGrid.TaskGridPreference";
  public const string _MarkAllReadResource = "{a5a1a012-9648-44a7-9c7c-7ef769fe287a}";
  public const string _CompleteAllTasksResource = "{7ad09705-4768-4619-9a14-a88fd2ead2d2}";
  private ObservableCollection<DataGridColumnInfo> taskColList;
  private ObservableCollection<DataGridColumnInfo> noteColList;
  private bool setNotePreferences;
  private bool setTaskPreferences;
  private string[] alwaysHidden;

  private virtual MGACheckBox chkShow
  {
    get => this._chkShow;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkShow_CheckedChanged);
      MGACheckBox chkShow1 = this._chkShow;
      if (chkShow1 != null)
        ((UltraToggleEditorBase) chkShow1).CheckedChanged -= eventHandler;
      this._chkShow = value;
      MGACheckBox chkShow2 = this._chkShow;
      if (chkShow2 == null)
        return;
      ((UltraToggleEditorBase) chkShow2).CheckedChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkHideCompleted
  {
    get => this._chkHideCompleted;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkHideCompleted_CheckedChanged);
      MGACheckBox chkHideCompleted1 = this._chkHideCompleted;
      if (chkHideCompleted1 != null)
        ((UltraToggleEditorBase) chkHideCompleted1).CheckedChanged -= eventHandler;
      this._chkHideCompleted = value;
      MGACheckBox chkHideCompleted2 = this._chkHideCompleted;
      if (chkHideCompleted2 == null)
        return;
      ((UltraToggleEditorBase) chkHideCompleted2).CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rdoTasksDisplayAll
  {
    get => this._rdoTasksDisplayAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rdo_CheckedChanged);
      RadioButton rdoTasksDisplayAll1 = this._rdoTasksDisplayAll;
      if (rdoTasksDisplayAll1 != null)
        rdoTasksDisplayAll1.CheckedChanged -= eventHandler;
      this._rdoTasksDisplayAll = value;
      RadioButton rdoTasksDisplayAll2 = this._rdoTasksDisplayAll;
      if (rdoTasksDisplayAll2 == null)
        return;
      rdoTasksDisplayAll2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rdoTasksTodayAndPast
  {
    get => this._rdoTasksTodayAndPast;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rdo_CheckedChanged);
      RadioButton tasksTodayAndPast1 = this._rdoTasksTodayAndPast;
      if (tasksTodayAndPast1 != null)
        tasksTodayAndPast1.CheckedChanged -= eventHandler;
      this._rdoTasksTodayAndPast = value;
      RadioButton tasksTodayAndPast2 = this._rdoTasksTodayAndPast;
      if (tasksTodayAndPast2 == null)
        return;
      tasksTodayAndPast2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rdoTasksTodayOnly
  {
    get => this._rdoTasksTodayOnly;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rdo_CheckedChanged);
      RadioButton rdoTasksTodayOnly1 = this._rdoTasksTodayOnly;
      if (rdoTasksTodayOnly1 != null)
        rdoTasksTodayOnly1.CheckedChanged -= eventHandler;
      this._rdoTasksTodayOnly = value;
      RadioButton rdoTasksTodayOnly2 = this._rdoTasksTodayOnly;
      if (rdoTasksTodayOnly2 == null)
        return;
      rdoTasksTodayOnly2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("MgaGroupBox3")]
  internal virtual MGAGroupBox MgaGroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Splitter1")]
  internal virtual Splitter Splitter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaGroupBox4")]
  internal virtual MGAGroupBox MgaGroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual UltraGrid grdNotes
  {
    get => this._grdNotes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.UltraGrid_InitializeRow);
      CellEventHandler cellEventHandler = new CellEventHandler(this.grd_CellChange);
      EventHandler eventHandler = new EventHandler(this.grd_Click);
      UIElementEventHandler elementEventHandler1 = new UIElementEventHandler(this.grd_MouseEnterElement);
      UIElementEventHandler elementEventHandler2 = new UIElementEventHandler(this.grd_MouseLeaveElement);
      AfterRowFilterChangedEventHandler changedEventHandler1 = new AfterRowFilterChangedEventHandler(this.grdNotes_AfterRowFilterChanged);
      AfterColPosChangedEventHandler changedEventHandler2 = new AfterColPosChangedEventHandler(this.grdNotes_AfterColPosChanged);
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.grdNotes_InitializeLayout);
      UltraGrid grdNotes1 = this._grdNotes;
      if (grdNotes1 != null)
      {
        grdNotes1.InitializeRow -= initializeRowEventHandler;
        grdNotes1.CellChange -= cellEventHandler;
        ((Control) grdNotes1).Click -= eventHandler;
        ((UltraControlBase) grdNotes1).MouseEnterElement -= elementEventHandler1;
        ((UltraControlBase) grdNotes1).MouseLeaveElement -= elementEventHandler2;
        ((UltraGridBase) grdNotes1).AfterRowFilterChanged -= changedEventHandler1;
        ((UltraGridBase) grdNotes1).AfterColPosChanged -= changedEventHandler2;
        grdNotes1.InitializeLayout -= layoutEventHandler;
      }
      this._grdNotes = value;
      UltraGrid grdNotes2 = this._grdNotes;
      if (grdNotes2 == null)
        return;
      grdNotes2.InitializeRow += initializeRowEventHandler;
      grdNotes2.CellChange += cellEventHandler;
      ((Control) grdNotes2).Click += eventHandler;
      ((UltraControlBase) grdNotes2).MouseEnterElement += elementEventHandler1;
      ((UltraControlBase) grdNotes2).MouseLeaveElement += elementEventHandler2;
      ((UltraGridBase) grdNotes2).AfterRowFilterChanged += changedEventHandler1;
      ((UltraGridBase) grdNotes2).AfterColPosChanged += changedEventHandler2;
      grdNotes2.InitializeLayout += layoutEventHandler;
    }
  }

  protected internal virtual UltraGrid grdTasks
  {
    get => this._grdTasks;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.UltraGrid_InitializeRow);
      CellEventHandler cellEventHandler = new CellEventHandler(this.grd_CellChange);
      EventHandler eventHandler = new EventHandler(this.grd_Click);
      UIElementEventHandler elementEventHandler1 = new UIElementEventHandler(this.grd_MouseEnterElement);
      UIElementEventHandler elementEventHandler2 = new UIElementEventHandler(this.grd_MouseLeaveElement);
      AfterRowFilterChangedEventHandler changedEventHandler1 = new AfterRowFilterChangedEventHandler(this.grdTasks_AfterRowFilterChanged);
      AfterColPosChangedEventHandler changedEventHandler2 = new AfterColPosChangedEventHandler(this.grdTasks_AfterColPosChanged);
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.grdTasks_InitializeLayout);
      UltraGrid grdTasks1 = this._grdTasks;
      if (grdTasks1 != null)
      {
        grdTasks1.InitializeRow -= initializeRowEventHandler;
        grdTasks1.CellChange -= cellEventHandler;
        ((Control) grdTasks1).Click -= eventHandler;
        ((UltraControlBase) grdTasks1).MouseEnterElement -= elementEventHandler1;
        ((UltraControlBase) grdTasks1).MouseLeaveElement -= elementEventHandler2;
        ((UltraGridBase) grdTasks1).AfterRowFilterChanged -= changedEventHandler1;
        ((UltraGridBase) grdTasks1).AfterColPosChanged -= changedEventHandler2;
        grdTasks1.InitializeLayout -= layoutEventHandler;
      }
      this._grdTasks = value;
      UltraGrid grdTasks2 = this._grdTasks;
      if (grdTasks2 == null)
        return;
      grdTasks2.InitializeRow += initializeRowEventHandler;
      grdTasks2.CellChange += cellEventHandler;
      ((Control) grdTasks2).Click += eventHandler;
      ((UltraControlBase) grdTasks2).MouseEnterElement += elementEventHandler1;
      ((UltraControlBase) grdTasks2).MouseLeaveElement += elementEventHandler2;
      ((UltraGridBase) grdTasks2).AfterRowFilterChanged += changedEventHandler1;
      ((UltraGridBase) grdTasks2).AfterColPosChanged += changedEventHandler2;
      grdTasks2.InitializeLayout += layoutEventHandler;
    }
  }

  internal virtual LinkLabel lnkRefreshData
  {
    get => this._lnkRefreshData;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkRefreshData_LinkClicked);
      LinkLabel lnkRefreshData1 = this._lnkRefreshData;
      if (lnkRefreshData1 != null)
        lnkRefreshData1.LinkClicked -= clickedEventHandler;
      this._lnkRefreshData = value;
      LinkLabel lnkRefreshData2 = this._lnkRefreshData;
      if (lnkRefreshData2 == null)
        return;
      lnkRefreshData2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("grpTasks")]
  internal virtual MGAGroupBox grpTasks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpDateRange")]
  internal virtual Panel grpDateRange { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGACheckBox chkDateRange
  {
    get => this._chkDateRange;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkDateRange_CheckedChanged);
      MGACheckBox chkDateRange1 = this._chkDateRange;
      if (chkDateRange1 != null)
        ((UltraToggleEditorBase) chkDateRange1).CheckedChanged -= eventHandler;
      this._chkDateRange = value;
      MGACheckBox chkDateRange2 = this._chkDateRange;
      if (chkDateRange2 == null)
        return;
      ((UltraToggleEditorBase) chkDateRange2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dvDiaries")]
  internal virtual DataView dvDiaries { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtTo")]
  internal virtual MGADateTimePicker dtTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtFrom")]
  internal virtual MGADateTimePicker dtFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvNotes")]
  internal virtual DataView dvNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraToolbarsManager1")]
  internal virtual UltraToolbarsManager UltraToolbarsManager1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("frmToday_Fill_Panel")]
  internal virtual Panel frmToday_Fill_Panel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmToday_Toolbars_Dock_Area_Left")]
  internal virtual UltraToolbarsDockArea _frmToday_Toolbars_Dock_Area_Left { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmToday_Toolbars_Dock_Area_Right")]
  internal virtual UltraToolbarsDockArea _frmToday_Toolbars_Dock_Area_Right { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmToday_Toolbars_Dock_Area_Top")]
  internal virtual UltraToolbarsDockArea _frmToday_Toolbars_Dock_Area_Top { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmToday_Toolbars_Dock_Area_Bottom")]
  internal virtual UltraToolbarsDockArea _frmToday_Toolbars_Dock_Area_Bottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Timer RefreshTimer
  {
    get => this._RefreshTimer;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RefreshTimer_Tick);
      Timer refreshTimer1 = this._RefreshTimer;
      if (refreshTimer1 != null)
        refreshTimer1.Tick -= eventHandler;
      this._RefreshTimer = value;
      Timer refreshTimer2 = this._RefreshTimer;
      if (refreshTimer2 == null)
        return;
      refreshTimer2.Tick += eventHandler;
    }
  }

  internal virtual Button btnTaskColumns
  {
    get => this._btnTaskColumns;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnTaskColumns_Click);
      Button btnTaskColumns1 = this._btnTaskColumns;
      if (btnTaskColumns1 != null)
        btnTaskColumns1.Click -= eventHandler;
      this._btnTaskColumns = value;
      Button btnTaskColumns2 = this._btnTaskColumns;
      if (btnTaskColumns2 == null)
        return;
      btnTaskColumns2.Click += eventHandler;
    }
  }

  internal virtual Button btnMessageColumns
  {
    get => this._btnMessageColumns;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnMessageColumns_Click);
      Button btnMessageColumns1 = this._btnMessageColumns;
      if (btnMessageColumns1 != null)
        btnMessageColumns1.Click -= eventHandler;
      this._btnMessageColumns = value;
      Button btnMessageColumns2 = this._btnMessageColumns;
      if (btnMessageColumns2 == null)
        return;
      btnMessageColumns2.Click += eventHandler;
    }
  }

  internal virtual Button btnSelectAllTasks
  {
    get => this._btnSelectAllTasks;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelectAllTasks_Click);
      Button btnSelectAllTasks1 = this._btnSelectAllTasks;
      if (btnSelectAllTasks1 != null)
        btnSelectAllTasks1.Click -= eventHandler;
      this._btnSelectAllTasks = value;
      Button btnSelectAllTasks2 = this._btnSelectAllTasks;
      if (btnSelectAllTasks2 == null)
        return;
      btnSelectAllTasks2.Click += eventHandler;
    }
  }

  internal virtual Button btnMessageMarkAllRead
  {
    get => this._btnMessageMarkAllRead;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnMessageMarkAllRead_Click);
      Button messageMarkAllRead1 = this._btnMessageMarkAllRead;
      if (messageMarkAllRead1 != null)
        messageMarkAllRead1.Click -= eventHandler;
      this._btnMessageMarkAllRead = value;
      Button messageMarkAllRead2 = this._btnMessageMarkAllRead;
      if (messageMarkAllRead2 == null)
        return;
      messageMarkAllRead2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("grpMessages")]
  internal virtual MGAGroupBox grpMessages { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblNotes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("EntryGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Completed", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Body");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("InsuredPolicyName");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CreatedDate");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("NoteType");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Subject");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ProducerContact");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("LineOfBusiness");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("QuoteStatus");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("PolicyType");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("UnderwriterName");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("IsRead");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Premium");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("From");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("NeededByDate");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("ClaimNumber");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("ProducerLocationName");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("DBA");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblUrgentDiaries", -1);
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("EntryGUID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("Completed");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Body");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("InsuredPolicyName");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("NoteType");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("CreatedDate");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("Subject");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("ProducerContact");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("LineOfBusiness");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("QuoteStatus");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("PolicyType");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("UnderwriterName", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("Premium");
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("From");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("NeededByDate");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("ClaimNumber");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("ProducerLocationName");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    this.chkShow = new MGACheckBox();
    this.chkHideCompleted = new MGACheckBox();
    this.rdoTasksDisplayAll = new RadioButton();
    this.rdoTasksTodayAndPast = new RadioButton();
    this.rdoTasksTodayOnly = new RadioButton();
    this.Panel1 = new Panel();
    this.Splitter1 = new Splitter();
    this.grpMessages = new MGAGroupBox();
    this.grdNotes = new UltraGrid();
    this.grpTasks = new MGAGroupBox();
    this.grdTasks = new UltraGrid();
    this.MgaGroupBox3 = new MGAGroupBox();
    this.MgaGroupBox4 = new MGAGroupBox();
    this.btnMessageMarkAllRead = new Button();
    this.btnSelectAllTasks = new Button();
    this.btnTaskColumns = new Button();
    this.btnMessageColumns = new Button();
    this.lnkRefreshData = new LinkLabel();
    this.chkDateRange = new MGACheckBox();
    this.grpDateRange = new Panel();
    this.dtTo = new MGADateTimePicker();
    this.Label2 = new Label();
    this.dtFrom = new MGADateTimePicker();
    this.Label1 = new Label();
    this.frmToday_Fill_Panel = new Panel();
    this._frmToday_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._frmToday_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmToday_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmToday_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.RefreshTimer = new Timer(this.components);
    this.dvNotes = new DataView();
    this.DsToday = new dsToday();
    this.dvDiaries = new DataView();
    ((ISupportInitialize) this.chkShow).BeginInit();
    ((ISupportInitialize) this.chkHideCompleted).BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.grpMessages).BeginInit();
    ((Control) this.grpMessages).SuspendLayout();
    ((ISupportInitialize) this.grdNotes).BeginInit();
    ((ISupportInitialize) this.grpTasks).BeginInit();
    ((Control) this.grpTasks).SuspendLayout();
    ((ISupportInitialize) this.grdTasks).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox3).BeginInit();
    ((Control) this.MgaGroupBox3).SuspendLayout();
    ((ISupportInitialize) this.MgaGroupBox4).BeginInit();
    ((Control) this.MgaGroupBox4).SuspendLayout();
    ((ISupportInitialize) this.chkDateRange).BeginInit();
    this.grpDateRange.SuspendLayout();
    ((ISupportInitialize) this.dtTo).BeginInit();
    ((ISupportInitialize) this.dtFrom).BeginInit();
    this.frmToday_Fill_Panel.SuspendLayout();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    this.dvNotes.BeginInit();
    this.DsToday.BeginInit();
    this.dvDiaries.BeginInit();
    this.SuspendLayout();
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkShow).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.chkShow).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkShow).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkShow).Checked = true;
    ((UltraToggleEditorBase) this.chkShow).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkShow).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkShow).Location = new Point(11, 193);
    this.chkShow.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkShow).Name = "chkShow";
    ((Control) this.chkShow).Size = new Size(136, 32 /*0x20*/);
    ((Control) this.chkShow).TabIndex = 10;
    ((UltraToggleEditorBase) this.chkShow).Text = "Show on startup";
    ((UltraControlBase) this.chkShow).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkShow).UseOsThemes = (DefaultableBoolean) 2;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHideCompleted).Appearance = (AppearanceBase) appearance2;
    ((UltraToggleEditorBase) this.chkHideCompleted).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideCompleted).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideCompleted).Checked = true;
    ((UltraToggleEditorBase) this.chkHideCompleted).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkHideCompleted).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHideCompleted).Location = new Point(11, 169);
    this.chkHideCompleted.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkHideCompleted).Name = "chkHideCompleted";
    ((Control) this.chkHideCompleted).Size = new Size(136, 24);
    ((Control) this.chkHideCompleted).TabIndex = 12;
    ((UltraToggleEditorBase) this.chkHideCompleted).Text = "Hide completed/read";
    ((UltraControlBase) this.chkHideCompleted).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHideCompleted).UseOsThemes = (DefaultableBoolean) 2;
    this.rdoTasksDisplayAll.BackColor = Color.Transparent;
    this.rdoTasksDisplayAll.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.rdoTasksDisplayAll.Name = "rdoTasksDisplayAll";
    this.rdoTasksDisplayAll.Size = new Size(144 /*0x90*/, 16 /*0x10*/);
    this.rdoTasksDisplayAll.TabIndex = 13;
    this.rdoTasksDisplayAll.Text = "Display all open tasks";
    this.rdoTasksDisplayAll.UseVisualStyleBackColor = false;
    this.rdoTasksTodayAndPast.BackColor = Color.Transparent;
    this.rdoTasksTodayAndPast.Location = new Point(16 /*0x10*/, 64 /*0x40*/);
    this.rdoTasksTodayAndPast.Name = "rdoTasksTodayAndPast";
    this.rdoTasksTodayAndPast.Size = new Size(248, 16 /*0x10*/);
    this.rdoTasksTodayAndPast.TabIndex = 14;
    this.rdoTasksTodayAndPast.Text = "Display today's, and past due open tasks only";
    this.rdoTasksTodayAndPast.UseVisualStyleBackColor = false;
    this.rdoTasksTodayOnly.BackColor = Color.Transparent;
    this.rdoTasksTodayOnly.Location = new Point(16 /*0x10*/, 48 /*0x30*/);
    this.rdoTasksTodayOnly.Name = "rdoTasksTodayOnly";
    this.rdoTasksTodayOnly.Size = new Size(200, 16 /*0x10*/);
    this.rdoTasksTodayOnly.TabIndex = 15;
    this.rdoTasksTodayOnly.Text = "Display today's open tasks only";
    this.rdoTasksTodayOnly.UseVisualStyleBackColor = false;
    this.Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.Panel1.Controls.Add((Control) this.Splitter1);
    this.Panel1.Controls.Add((Control) this.grpMessages);
    this.Panel1.Controls.Add((Control) this.grpTasks);
    this.Panel1.Location = new Point(8, 12);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(784, 349);
    this.Panel1.TabIndex = 20;
    this.Splitter1.Dock = DockStyle.Bottom;
    this.Splitter1.Location = new Point(0, 194);
    this.Splitter1.Name = "Splitter1";
    this.Splitter1.Size = new Size(784, 3);
    this.Splitter1.TabIndex = 23;
    this.Splitter1.TabStop = false;
    this.grpMessages.BackColorInternal = Color.White;
    appearance3.BackColor = Color.FromArgb(239, 247, 253);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpMessages.ContentAreaAppearance = (AppearanceBase) appearance3;
    ((Control) this.grpMessages).Controls.Add((Control) this.grdNotes);
    this.grpMessages.Dock = DockStyle.Fill;
    ((Control) this.grpMessages).Font = new Font("Tahoma", 8f);
    ((Control) this.grpMessages).ForeColor = Color.Black;
    appearance4.ForeColor = Color.FromArgb(21, 66, 139);
    this.grpMessages.HeaderAppearance = (AppearanceBase) appearance4;
    ((Control) this.grpMessages).Location = new Point(0, 0);
    ((Control) this.grpMessages).Name = "grpMessages";
    ((Control) this.grpMessages).Size = new Size(784, 197);
    ((Control) this.grpMessages).TabIndex = 22;
    this.grpMessages.Text = "Messages";
    this.grpMessages.ViewStyle = (GroupBoxViewStyle) 2;
    ((UltraGridBase) this.grdNotes).DataSource = (object) this.dvNotes;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.grdNotes).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 152;
    ultraGridColumn2.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellClickAction = (CellClickAction) 1;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 45;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 62;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Width = 63 /*0x3F*/;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Ins. Policy Name";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 7;
    ultraGridColumn5.Width = 77;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Created";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 3;
    ultraGridColumn6.Width = 70;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Type";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 9;
    ultraGridColumn7.Width = 61;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Effective";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 11;
    ultraGridColumn8.Width = 54;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Ctrl#";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 6;
    ultraGridColumn9.Width = 56;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 10;
    ultraGridColumn10.Width = 35;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Prod. Contact";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 8;
    ultraGridColumn11.Width = 67;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "LOB";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 12;
    ultraGridColumn12.Width = 62;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Status";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 13;
    ultraGridColumn13.Width = 61;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Policy Type";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 14;
    ultraGridColumn14.Width = 72;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 15;
    ultraGridColumn15.Width = 66;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Policy Underwriter";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Hidden = true;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ultraGridColumn18.CellAppearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 18;
    ultraGridColumn20.CellActivation = (Activation) 3;
    ultraGridColumn20.CellClickAction = (CellClickAction) 2;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Needed By Date";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 19;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Claim No";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 20;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 21;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 22;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 23;
    ultraGridBand1.Columns.AddRange(new object[24]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24
    });
    ((UltraGridBase) this.grdNotes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.grdNotes).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance7.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.grdNotes).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.grdNotes).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.grdNotes).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.grdNotes).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdNotes).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.grdNotes).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance9.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.grdNotes).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.grdNotes).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.grdNotes).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance10.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.grdNotes).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    appearance11.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdNotes).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.grdNotes).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = Color.Transparent;
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.grdNotes).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.grdNotes).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.grdNotes).Dock = DockStyle.Fill;
    ((Control) this.grdNotes).Font = new Font("Tahoma", 8f);
    ((Control) this.grdNotes).Location = new Point(2, 19);
    ((Control) this.grdNotes).Name = "grdNotes";
    ((Control) this.grdNotes).Size = new Size(780, 176 /*0xB0*/);
    ((Control) this.grdNotes).TabIndex = 17;
    ((UltraControlBase) this.grdNotes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.grdNotes).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BackColor = Color.FromArgb(239, 247, 253);
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpTasks.ContentAreaAppearance = (AppearanceBase) appearance13;
    ((Control) this.grpTasks).Controls.Add((Control) this.grdTasks);
    this.grpTasks.Dock = DockStyle.Bottom;
    appearance14.ForeColor = Color.FromArgb(21, 66, 139);
    this.grpTasks.HeaderAppearance = (AppearanceBase) appearance14;
    ((Control) this.grpTasks).Location = new Point(0, 197);
    ((Control) this.grpTasks).Name = "grpTasks";
    ((Control) this.grpTasks).Size = new Size(784, 152);
    ((Control) this.grpTasks).TabIndex = 21;
    this.grpTasks.Text = "Tasks";
    this.grpTasks.ViewStyle = (GroupBoxViewStyle) 2;
    ((UltraGridBase) this.grdTasks).DataSource = (object) this.dvDiaries;
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.grdTasks).DisplayLayout.Appearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.grdTasks).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 0;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 26;
    ultraGridColumn26.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn26.CellClickAction = (CellClickAction) 1;
    ((HeaderBase) ultraGridColumn26.Header).Caption = "";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 1;
    ultraGridColumn26.Width = 35;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 2;
    ultraGridColumn27.Width = 77;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn28.CellActivation = (Activation) 3;
    ultraGridColumn28.CellClickAction = (CellClickAction) 2;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "Due";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 3;
    ultraGridColumn28.Width = 63 /*0x3F*/;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 4;
    ultraGridColumn29.Width = 90;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Ins. Policy Name";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 7;
    ultraGridColumn30.Width = 99;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Caption = "Type";
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 9;
    ultraGridColumn31.Width = 79;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn32.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn32.Header).Caption = "Effective";
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 11;
    ultraGridColumn32.Width = 88;
    ultraGridColumn33.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 12;
    ultraGridColumn33.Width = 78;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn34.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn34.Header).Caption = "Ctrl #";
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 6;
    ultraGridColumn34.Width = 70;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn36.Header).Caption = "Producer Contact";
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 8;
    ((HeaderBase) ultraGridColumn37.Header).Caption = "LOB";
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn38.Header).Caption = "Status";
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn39.Header).Caption = "Policy Type";
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 15;
    ((HeaderBase) ultraGridColumn40.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 16 /*0x10*/;
    ((HeaderBase) ultraGridColumn41.Header).Caption = "Policy Underwriter";
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 5;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ultraGridColumn42.CellAppearance = (AppearanceBase) appearance16;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 17;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 18;
    ultraGridColumn44.CellActivation = (Activation) 3;
    ultraGridColumn44.CellClickAction = (CellClickAction) 2;
    ((HeaderBase) ultraGridColumn44.Header).Caption = "Needed By Date";
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 19;
    ((HeaderBase) ultraGridColumn45.Header).Caption = "Claim No";
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 20;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 21;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 22;
    ultraGridBand2.Columns.AddRange(new object[23]
    {
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47
    });
    ((UltraGridBase) this.grdTasks).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.grdTasks).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance17.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.grdTasks).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.grdTasks).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.grdTasks).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.grdTasks).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.grdTasks).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance18.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdTasks).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.grdTasks).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance19.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.grdTasks).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.grdTasks).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.grdTasks).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance20.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.grdTasks).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance20;
    appearance21.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdTasks).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.grdTasks).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance22.BackColor = Color.Transparent;
    appearance22.ForeColor = Color.Black;
    ((UltraGridBase) this.grdTasks).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance22;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.grdTasks).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.grdTasks).Dock = DockStyle.Fill;
    ((Control) this.grdTasks).Font = new Font("Tahoma", 8f);
    ((Control) this.grdTasks).Location = new Point(2, 19);
    ((Control) this.grdTasks).Name = "grdTasks";
    ((Control) this.grdTasks).Size = new Size(780, 131);
    ((Control) this.grdTasks).TabIndex = 0;
    ((UltraControlBase) this.grdTasks).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.grdTasks).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaGroupBox3).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance23.BackColor = Color.FromArgb(239, 247, 253);
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox3.ContentAreaAppearance = (AppearanceBase) appearance23;
    ((Control) this.MgaGroupBox3).Controls.Add((Control) this.rdoTasksTodayOnly);
    ((Control) this.MgaGroupBox3).Controls.Add((Control) this.rdoTasksTodayAndPast);
    ((Control) this.MgaGroupBox3).Controls.Add((Control) this.rdoTasksDisplayAll);
    appearance24.ForeColor = Color.FromArgb(21, 66, 139);
    this.MgaGroupBox3.HeaderAppearance = (AppearanceBase) appearance24;
    ((Control) this.MgaGroupBox3).Location = new Point(8, 367);
    ((Control) this.MgaGroupBox3).Name = "MgaGroupBox3";
    ((Control) this.MgaGroupBox3).Size = new Size(972, 91);
    ((Control) this.MgaGroupBox3).TabIndex = 16 /*0x10*/;
    this.MgaGroupBox3.Text = "Task Specific Criteria";
    this.MgaGroupBox3.ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.MgaGroupBox4).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    appearance25.BackColor = Color.FromArgb(239, 247, 253);
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox4.ContentAreaAppearance = (AppearanceBase) appearance25;
    ((Control) this.MgaGroupBox4).Controls.Add((Control) this.btnMessageMarkAllRead);
    ((Control) this.MgaGroupBox4).Controls.Add((Control) this.btnSelectAllTasks);
    ((Control) this.MgaGroupBox4).Controls.Add((Control) this.btnTaskColumns);
    ((Control) this.MgaGroupBox4).Controls.Add((Control) this.btnMessageColumns);
    ((Control) this.MgaGroupBox4).Controls.Add((Control) this.lnkRefreshData);
    ((Control) this.MgaGroupBox4).Controls.Add((Control) this.chkDateRange);
    ((Control) this.MgaGroupBox4).Controls.Add((Control) this.grpDateRange);
    ((Control) this.MgaGroupBox4).Controls.Add((Control) this.chkShow);
    ((Control) this.MgaGroupBox4).Controls.Add((Control) this.chkHideCompleted);
    appearance26.ForeColor = Color.FromArgb(21, 66, 139);
    this.MgaGroupBox4.HeaderAppearance = (AppearanceBase) appearance26;
    ((Control) this.MgaGroupBox4).Location = new Point(798, 12);
    ((Control) this.MgaGroupBox4).Name = "MgaGroupBox4";
    ((Control) this.MgaGroupBox4).Size = new Size(182, 349);
    ((Control) this.MgaGroupBox4).TabIndex = 0;
    this.MgaGroupBox4.Text = "Common Criteria";
    this.MgaGroupBox4.ViewStyle = (GroupBoxViewStyle) 2;
    this.btnMessageMarkAllRead.Location = new Point(8, 253);
    this.btnMessageMarkAllRead.Name = "btnMessageMarkAllRead";
    this.btnMessageMarkAllRead.Size = new Size(157, 23);
    this.btnMessageMarkAllRead.TabIndex = 21;
    this.btnMessageMarkAllRead.Text = "Mark All Messages Read";
    this.btnMessageMarkAllRead.UseVisualStyleBackColor = true;
    this.btnSelectAllTasks.Location = new Point(8, 311);
    this.btnSelectAllTasks.Name = "btnSelectAllTasks";
    this.btnSelectAllTasks.Size = new Size(157, 23);
    this.btnSelectAllTasks.TabIndex = 20;
    this.btnSelectAllTasks.Text = "Complete All Tasks";
    this.btnSelectAllTasks.UseVisualStyleBackColor = true;
    this.btnTaskColumns.Location = new Point(8, 283);
    this.btnTaskColumns.Name = "btnTaskColumns";
    this.btnTaskColumns.Size = new Size(157, 23);
    this.btnTaskColumns.TabIndex = 19;
    this.btnTaskColumns.Text = "Show/Hide Task Columns";
    this.btnTaskColumns.UseVisualStyleBackColor = true;
    this.btnMessageColumns.Location = new Point(8, 224 /*0xE0*/);
    this.btnMessageColumns.Name = "btnMessageColumns";
    this.btnMessageColumns.Size = new Size(157, 23);
    this.btnMessageColumns.TabIndex = 18;
    this.btnMessageColumns.Text = "Show/Hide Message Columns";
    this.btnMessageColumns.UseVisualStyleBackColor = true;
    this.lnkRefreshData.AutoSize = true;
    this.lnkRefreshData.BackColor = Color.Transparent;
    this.lnkRefreshData.Location = new Point(8, 144 /*0x90*/);
    this.lnkRefreshData.Name = "lnkRefreshData";
    this.lnkRefreshData.Size = new Size(71, 13);
    this.lnkRefreshData.TabIndex = 17;
    this.lnkRefreshData.TabStop = true;
    this.lnkRefreshData.Text = "Refresh Data";
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDateRange).Appearance = (AppearanceBase) appearance27;
    ((UltraToggleEditorBase) this.chkDateRange).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDateRange).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDateRange).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDateRange).Location = new Point(8, 32 /*0x20*/);
    this.chkDateRange.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkDateRange).Name = "chkDateRange";
    ((Control) this.chkDateRange).Size = new Size(128 /*0x80*/, 16 /*0x10*/);
    ((Control) this.chkDateRange).TabIndex = 16 /*0x10*/;
    ((UltraToggleEditorBase) this.chkDateRange).Text = "Filter by date";
    ((UltraControlBase) this.chkDateRange).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDateRange).UseOsThemes = (DefaultableBoolean) 2;
    this.grpDateRange.BackColor = Color.Transparent;
    this.grpDateRange.Controls.Add((Control) this.dtTo);
    this.grpDateRange.Controls.Add((Control) this.Label2);
    this.grpDateRange.Controls.Add((Control) this.dtFrom);
    this.grpDateRange.Controls.Add((Control) this.Label1);
    this.grpDateRange.Location = new Point(8, 48 /*0x30*/);
    this.grpDateRange.Name = "grpDateRange";
    this.grpDateRange.Size = new Size(136, 88);
    this.grpDateRange.TabIndex = 15;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtTo.Appearance = (AppearanceBase) appearance28;
    appearance29.AlphaLevel = (short) 14;
    appearance29.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance29.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance29.BackColorAlpha = (Alpha) 2;
    appearance29.BackGradientAlignment = (GradientAlignment) 4;
    appearance29.BackGradientStyle = (GradientStyle) 5;
    appearance29.BorderAlpha = (Alpha) 1;
    appearance29.BorderColor = Color.FromArgb(78, 122, 171);
    appearance29.ForeColor = Color.FromArgb(49, 85, 153);
    appearance29.ForegroundAlpha = (Alpha) 2;
    this.dtTo.ButtonAppearance = (AppearanceBase) appearance29;
    ((Control) this.dtTo).Location = new Point(16 /*0x10*/, 64 /*0x40*/);
    this.dtTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtTo).Name = "dtTo";
    ((Control) this.dtTo).Size = new Size(112 /*0x70*/, 20);
    ((Control) this.dtTo).TabIndex = 3;
    ((UltraControlBase) this.dtTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtTo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.Location = new Point(8, 48 /*0x30*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(32 /*0x20*/, 16 /*0x10*/);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "To";
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtFrom.Appearance = (AppearanceBase) appearance30;
    appearance31.AlphaLevel = (short) 14;
    appearance31.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance31.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance31.BackColorAlpha = (Alpha) 2;
    appearance31.BackGradientAlignment = (GradientAlignment) 4;
    appearance31.BackGradientStyle = (GradientStyle) 5;
    appearance31.BorderAlpha = (Alpha) 1;
    appearance31.BorderColor = Color.FromArgb(78, 122, 171);
    appearance31.ForeColor = Color.FromArgb(49, 85, 153);
    appearance31.ForegroundAlpha = (Alpha) 2;
    this.dtFrom.ButtonAppearance = (AppearanceBase) appearance31;
    ((Control) this.dtFrom).Location = new Point(16 /*0x10*/, 24);
    this.dtFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtFrom).Name = "dtFrom";
    ((Control) this.dtFrom).Size = new Size(112 /*0x70*/, 20);
    ((Control) this.dtFrom).TabIndex = 1;
    ((UltraControlBase) this.dtFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(32 /*0x20*/, 16 /*0x10*/);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "From";
    this.frmToday_Fill_Panel.Controls.Add((Control) this.MgaGroupBox3);
    this.frmToday_Fill_Panel.Controls.Add((Control) this.MgaGroupBox4);
    this.frmToday_Fill_Panel.Controls.Add((Control) this.Panel1);
    this.frmToday_Fill_Panel.Dock = DockStyle.Fill;
    this.frmToday_Fill_Panel.Location = new Point(0, 0);
    this.frmToday_Fill_Panel.Name = "frmToday_Fill_Panel";
    this.frmToday_Fill_Panel.Size = new Size(992, 470);
    this.frmToday_Fill_Panel.TabIndex = 0;
    ((Control) this._frmToday_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmToday_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmToday_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmToday_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmToday_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._frmToday_Toolbars_Dock_Area_Left).Name = "_frmToday_Toolbars_Dock_Area_Left";
    ((Control) this._frmToday_Toolbars_Dock_Area_Left).Size = new Size(0, 470);
    this._frmToday_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.UltraToolbarsManager1.Style = (ToolbarStyle) 5;
    ((Control) this._frmToday_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmToday_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmToday_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmToday_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmToday_Toolbars_Dock_Area_Right).Location = new Point(992, 0);
    ((Control) this._frmToday_Toolbars_Dock_Area_Right).Name = "_frmToday_Toolbars_Dock_Area_Right";
    ((Control) this._frmToday_Toolbars_Dock_Area_Right).Size = new Size(0, 470);
    this._frmToday_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmToday_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmToday_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmToday_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmToday_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmToday_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmToday_Toolbars_Dock_Area_Top).Name = "_frmToday_Toolbars_Dock_Area_Top";
    ((Control) this._frmToday_Toolbars_Dock_Area_Top).Size = new Size(992, 0);
    this._frmToday_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmToday_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmToday_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmToday_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmToday_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmToday_Toolbars_Dock_Area_Bottom).Location = new Point(0, 470);
    ((Control) this._frmToday_Toolbars_Dock_Area_Bottom).Name = "_frmToday_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmToday_Toolbars_Dock_Area_Bottom).Size = new Size(992, 0);
    this._frmToday_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    this.RefreshTimer.Interval = 300000;
    this.dvNotes.Table = (DataTable) this.DsToday.tblNotes;
    this.DsToday.DataSetName = "dsToday";
    this.DsToday.Locale = new CultureInfo("en-US");
    this.DsToday.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.dvDiaries.Table = (DataTable) this.DsToday.tblUrgentDiaries;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(992, 470);
    this.Controls.Add((Control) this.frmToday_Fill_Panel);
    this.Controls.Add((Control) this._frmToday_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmToday_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmToday_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmToday_Toolbars_Dock_Area_Top);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.MinimumSize = new Size(680, 464);
    this.Name = nameof (frmToday);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Today";
    ((ISupportInitialize) this.chkShow).EndInit();
    ((ISupportInitialize) this.chkHideCompleted).EndInit();
    this.Panel1.ResumeLayout(false);
    ((ISupportInitialize) this.grpMessages).EndInit();
    ((Control) this.grpMessages).ResumeLayout(false);
    ((ISupportInitialize) this.grdNotes).EndInit();
    ((ISupportInitialize) this.grpTasks).EndInit();
    ((Control) this.grpTasks).ResumeLayout(false);
    ((ISupportInitialize) this.grdTasks).EndInit();
    ((ISupportInitialize) this.MgaGroupBox3).EndInit();
    ((Control) this.MgaGroupBox3).ResumeLayout(false);
    ((ISupportInitialize) this.MgaGroupBox4).EndInit();
    ((Control) this.MgaGroupBox4).ResumeLayout(false);
    ((Control) this.MgaGroupBox4).PerformLayout();
    ((ISupportInitialize) this.chkDateRange).EndInit();
    this.grpDateRange.ResumeLayout(false);
    this.grpDateRange.PerformLayout();
    ((ISupportInitialize) this.dtTo).EndInit();
    ((ISupportInitialize) this.dtFrom).EndInit();
    this.frmToday_Fill_Panel.ResumeLayout(false);
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    this.dvNotes.EndInit();
    this.DsToday.EndInit();
    this.dvDiaries.EndInit();
    this.ResumeLayout(false);
  }

  private void frmToday_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.TaskViewStyle = (TaskDisplayStyle) Conversions.ToInteger(Preferences.GetPreference("Screens.Today.TasksToDisplay"));
    ((UltraToggleEditorBase) this.chkShow).Checked = Preferences.GetPreferenceBool("Screens.Today.ShowOnStartup");
    ((UltraControlBase) this.grdNotes).DrawFilter = (IUIElementDrawFilter) this;
    ((UltraControlBase) this.grdTasks).DrawFilter = (IUIElementDrawFilter) this;
    ColumnsCollection columns1 = ((UltraGridBase) this.grdNotes).DisplayLayout.Bands[0].Columns;
    columns1["Body"].Width = Preferences.GetPreferenceInt("Screens.Today.TaskGrid.ColumnWidths.Body");
    columns1["PolicyNumber"].Width = Preferences.GetPreferenceInt("Screens.Today.TaskGrid.ColumnWidths.PolicyNumber");
    columns1["InsuredPolicyName"].Width = Preferences.GetPreferenceInt("Screens.Today.TaskGrid.ColumnWidths.InsuredPolicyName");
    columns1["Premium"].Format = "$###,###,##0.00";
    ColumnsCollection columns2 = ((UltraGridBase) this.grdTasks).DisplayLayout.Bands[0].Columns;
    columns2["Body"].Width = Preferences.GetPreferenceInt("Screens.Today.TaskGrid.ColumnWidths.Body");
    columns2["DueDate"].Width = Preferences.GetPreferenceInt("Screens.Today.TaskGrid.ColumnWidths.DueDate");
    columns2["PolicyNumber"].Width = Preferences.GetPreferenceInt("Screens.Today.TaskGrid.ColumnWidths.PolicyNumber");
    columns2["InsuredPolicyName"].Width = Preferences.GetPreferenceInt("Screens.Today.TaskGrid.ColumnWidths.InsuredPolicyName");
    columns2["Premium"].Format = "$###,###,##0.00";
    SendProducerDiaries.SendDiaryNotes();
    SendProducerDiaries.SendDriversDiaries();
    this._formLoaded = true;
    this.RefreshEntireView();
  }

  private TaskDisplayStyle TaskViewStyle
  {
    get
    {
      TaskDisplayStyle taskViewStyle;
      if (this.rdoTasksDisplayAll.Checked)
        taskViewStyle = TaskDisplayStyle.AllOpen;
      else if (this.rdoTasksTodayOnly.Checked)
        taskViewStyle = TaskDisplayStyle.TodayOnly;
      else if (this.rdoTasksTodayAndPast.Checked)
        taskViewStyle = TaskDisplayStyle.TodayAndPastDueOnly;
      return taskViewStyle;
    }
    set
    {
      switch (value)
      {
        case TaskDisplayStyle.AllOpen:
          this.rdoTasksDisplayAll.Checked = true;
          break;
        case TaskDisplayStyle.TodayOnly:
          this.rdoTasksTodayOnly.Checked = true;
          break;
        case TaskDisplayStyle.TodayAndPastDueOnly:
          this.rdoTasksTodayAndPast.Checked = true;
          break;
      }
    }
  }

  private bool HideCompletedItems => ((UltraToggleEditorBase) this.chkHideCompleted).Checked;

  public frmToday()
  {
    this.Load += new EventHandler(this.frmToday_Load);
    this.taskColList = new ObservableCollection<DataGridColumnInfo>();
    this.noteColList = new ObservableCollection<DataGridColumnInfo>();
    this.setNotePreferences = false;
    this.setTaskPreferences = false;
    this.alwaysHidden = new string[1]{ "EntryGUID" };
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    Preferences.SetPreference("Screens.Today.ShowOnStartup", ((UltraToggleEditorBase) this.chkShow).Checked);
    Preferences.SetPreference("Screens.Today.TasksToDisplay", (int) this.TaskViewStyle);
    ColumnsCollection columns = ((UltraGridBase) this.grdTasks).DisplayLayout.Bands[0].Columns;
    Preferences.SetPreference("Screens.Today.TaskGrid.ColumnWidths.Body", columns["Body"].Width);
    Preferences.SetPreference("Screens.Today.TaskGrid.ColumnWidths.DueDate", columns["DueDate"].Width);
    Preferences.SetPreference("Screens.Today.TaskGrid.ColumnWidths.PolicyNumber", columns["PolicyNumber"].Width);
    Preferences.SetPreference("Screens.Today.TaskGrid.ColumnWidths.InsuredPolicyName", columns["InsuredPolicyName"].Width);
    this.SetGridPreferences();
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void LoadDiaryCheckBoxes()
  {
    this.Cursor = MgaCursors.WaitCursor;
    short num = 0;
    switch (this.TaskViewStyle)
    {
      case TaskDisplayStyle.AllOpen:
        num = (short) 2;
        break;
      case TaskDisplayStyle.TodayOnly:
        num = (short) 1;
        break;
      case TaskDisplayStyle.TodayAndPastDueOnly:
        num = (short) 3;
        break;
    }
    BackgroundWorker backgroundWorker = new BackgroundWorker();
    backgroundWorker.DoWork += new DoWorkEventHandler(this.DiaryLoadWorker);
    backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.DiaryLoadWorkerComplete);
    backgroundWorker.RunWorkerAsync((object) new object[3]
    {
      (object) CurrentUser.Instance.UserGUID,
      (object) this.HideCompletedItems,
      (object) num
    });
  }

  private void DiaryLoadWorker(object sender, DoWorkEventArgs e)
  {
    ((BackgroundWorker) sender).DoWork -= new DoWorkEventHandler(this.DiaryLoadWorker);
    object[] objArray = (object[]) e.Argument;
    Guid guid = (Guid) objArray[0];
    bool flag = (bool) objArray[1];
    short num = (short) objArray[2];
    string setting = SystemSettings.GetSetting<string>("NoteSystem.Today.FetchTodayDiariesProcName", "dbo.NoteSystem_GetDiaryNoteEntries");
    e.Result = (object) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, setting, 300, (CommandArgumentType) 0, new object[6]
    {
      (object) "@UserGUID",
      (object) guid,
      (object) "@HideCompleted",
      (object) flag,
      (object) "@NoteTypeToLoad",
      (object) num
    });
  }

  private void DiaryLoadWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
  {
    if (this.IsDisposed)
      return;
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    try
    {
      ((BackgroundWorker) sender).RunWorkerCompleted -= new RunWorkerCompletedEventHandler(this.DiaryLoadWorkerComplete);
      DataTable result = (DataTable) e.Result;
      try
      {
        if (this.DsToday.tblUrgentDiaries.Count > 0)
          this.DsToday.tblUrgentDiaries.Clear();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      HashSet<string> stringSet = new HashSet<string>();
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) result.Columns)
        {
          if (!this.DsToday.tblUrgentDiaries.Columns.Contains(column.ColumnName) && column.ColumnName.StartsWith("AddUICol"))
          {
            string str = column.ColumnName.Replace("AddUICol", "");
            if (!this.DsToday.tblUrgentDiaries.Columns.Contains(str))
              this.DsToday.tblUrgentDiaries.Columns.Add(str, typeof (string));
            stringSet.Add(str);
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        foreach (DataRow row in result.Rows)
        {
          dsToday.tblUrgentDiariesRow urgentDiariesRow = this.DsToday.tblUrgentDiaries.NewtblUrgentDiariesRow();
          try
          {
            foreach (string columnName in stringSet)
              urgentDiariesRow[columnName] = (object) Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["AddUICol" + columnName]), "Unknown");
          }
          finally
          {
            HashSet<string>.Enumerator enumerator;
            enumerator.Dispose();
          }
          string str1 = "Unknown";
          string str2 = string.Empty;
          urgentDiariesRow.Body = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["Body"]), "Unknown");
          urgentDiariesRow.DueDate = Conversions.ToDate(row["DueDate"]);
          urgentDiariesRow.Completed = !row.IsNull("CompletedDate");
          urgentDiariesRow.EntryGUID = (Guid) row["EntryGUID"];
          urgentDiariesRow.Subject = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["Subject"]), "Unknown");
          urgentDiariesRow.ProducerContact = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["ProducerContact"]), "");
          if (!row.IsNull("PolicyNumber"))
            str1 = $"[{Conversions.ToString(row["PolicyNumber"])}]";
          if (!row.IsNull("InsuredPolicyName"))
            str2 = $"[{Conversions.ToString(row["InsuredPolicyName"])}]";
          if (row.Table.Columns.Contains("ControlNo") && !row.IsNull("ControlNo"))
            urgentDiariesRow.ControlNo = (int) row["ControlNo"];
          urgentDiariesRow.PolicyNumber = str1;
          urgentDiariesRow.InsuredPolicyName = str2;
          urgentDiariesRow.NoteType = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["NoteType"]), "Unknown");
          if (row["EffectiveDate"] != null && row["EffectiveDate"] != DBNull.Value)
            urgentDiariesRow.EffectiveDate = Conversions.ToDate(row["EffectiveDate"]);
          else
            urgentDiariesRow.SetEffectiveDateNull();
          if (row["CreatedDate"] != null && row["CreatedDate"] != DBNull.Value)
            urgentDiariesRow.CreatedDate = Conversions.ToDate(row["CreatedDate"]);
          else
            urgentDiariesRow.SetCreatedDateNull();
          urgentDiariesRow.LineOfBusiness = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["LineOfBusiness"]), "Unknown");
          urgentDiariesRow.QuoteStatus = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["QuoteStatus"]), "Unknown");
          if (row["PolicyType"] != null && row["PolicyType"] != DBNull.Value)
            urgentDiariesRow.PolicyType = row["PolicyType"].ToString();
          else
            urgentDiariesRow.SetPolicyTypeNull();
          if (row["StateID"] != null && row["StateID"] != DBNull.Value)
            urgentDiariesRow.StateID = row["StateID"].ToString();
          else
            urgentDiariesRow.SetStateIDNull();
          if (row.Table.Columns.Contains("UnderwriterName"))
          {
            if (row["UnderwriterName"] != null && row["UnderwriterName"] != DBNull.Value)
              urgentDiariesRow.UnderwriterName = row["UnderwriterName"].ToString();
            else
              urgentDiariesRow.SetUnderwriterNameNull();
          }
          else
            urgentDiariesRow.SetUnderwriterNameNull();
          if (row.Table.Columns.Contains("Premium"))
          {
            if (row["Premium"] != null && row["Premium"] != DBNull.Value)
              urgentDiariesRow.Premium = Conversions.ToDecimal(row["Premium"]);
            else
              urgentDiariesRow.SetPremiumNull();
          }
          else
            urgentDiariesRow.SetPremiumNull();
          if (row.Table.Columns.Contains("From"))
          {
            if (row["From"] != null && row["From"] != DBNull.Value)
              urgentDiariesRow.From = row["From"].ToString();
            else
              urgentDiariesRow.SetFromNull();
          }
          else
            urgentDiariesRow.SetFromNull();
          if (row.Table.Columns.Contains("NeededByDate"))
          {
            if (row["NeededByDate"] != null && row["NeededByDate"] != DBNull.Value)
              urgentDiariesRow.NeededByDate = Conversions.ToDate(row["NeededByDate"]);
            else
              urgentDiariesRow.SetNeededByDateNull();
          }
          else
            urgentDiariesRow.SetNeededByDateNull();
          if (row.Table.Columns.Contains("ClaimNumber"))
          {
            if (row["ClaimNumber"] != null && row["ClaimNumber"] != DBNull.Value)
              urgentDiariesRow.ClaimNumber = row["ClaimNumber"].ToString();
            else
              urgentDiariesRow.SetClaimNumberNull();
          }
          else
            urgentDiariesRow.SetClaimNumberNull();
          if (row.Table.Columns.Contains("ExpirationDate"))
          {
            if (row["ExpirationDate"] != null && row["ExpirationDate"] != DBNull.Value)
              urgentDiariesRow.ExpirationDate = Conversions.ToDate(row["ExpirationDate"]);
            else
              urgentDiariesRow.SetExpirationDateNull();
          }
          else
            urgentDiariesRow.SetExpirationDateNull();
          if (row.Table.Columns.Contains("ProducerLocationName"))
          {
            if (row["ProducerLocationName"] != null && row["ProducerLocationName"] != DBNull.Value)
              urgentDiariesRow.ProducerLocationName = row["ProducerLocationName"].ToString();
            else
              urgentDiariesRow.SetProducerLocationNameNull();
          }
          else
            urgentDiariesRow.SetProducerLocationNameNull();
          if (row.Table.Columns.Contains("DBA"))
          {
            if (!row.IsNull("DBA"))
              urgentDiariesRow.DBA = row.Field<string>("DBA");
            else
              urgentDiariesRow.SetDBANull();
          }
          else
            urgentDiariesRow.SetDBANull();
          this.SetClientAdditionalDiaryColumns(row, urgentDiariesRow);
          this.DsToday.tblUrgentDiaries.AddtblUrgentDiariesRow(urgentDiariesRow);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (((UltraToggleEditorBase) this.chkDateRange).Checked)
      {
        DataView dvDiaries = this.dvDiaries;
        DateTime dateTime = this.dtFrom.DateTime;
        string shortDateString1 = dateTime.ToShortDateString();
        dateTime = this.dtTo.DateTime;
        string shortDateString2 = dateTime.ToShortDateString();
        string str = $"DueDate >= #{shortDateString1}# AND DueDate <= #{shortDateString2}#";
        dvDiaries.RowFilter = str;
      }
      else
        this.dvDiaries.RowFilter = string.Empty;
      this.Cursor = MgaCursors.Default;
      this.grpTasks.Text = $"Tasks ({((UltraGridBase) this.grdTasks).Rows.Count} items)";
      if (stringSet.Count <= 0)
        return;
      this.SetDataGridLayout(this.grdTasks, Preferences.GetPreferenceString("Screens.Today.TaskGrid.TaskGridPreference"));
      this.BuildTaskColumnCollection();
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual void SetClientAdditionalDiaryColumns(
    DataRow row,
    dsToday.tblUrgentDiariesRow urgentDiaryRow)
  {
  }

  private void LoadNoteCheckBoxes()
  {
    BackgroundWorker backgroundWorker = new BackgroundWorker();
    backgroundWorker.DoWork += new DoWorkEventHandler(this.NoteLoadWorker);
    backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.NoteLoadWorkerComplete);
    backgroundWorker.RunWorkerAsync((object) new object[2]
    {
      (object) CurrentUser.Instance.UserGUID,
      (object) !((UltraToggleEditorBase) this.chkHideCompleted).Checked
    });
  }

  private void NoteLoadWorker(object sender, DoWorkEventArgs e)
  {
    ((BackgroundWorker) sender).DoWork -= new DoWorkEventHandler(this.NoteLoadWorker);
    object[] objArray = (object[]) e.Argument;
    Guid guid = (Guid) objArray[0];
    bool flag = (bool) objArray[1];
    string setting = SystemSettings.GetSetting<string>("NoteSystem.Today.FetchTodayNotesProcName", "dbo.NoteSystem_GetUserNoteEntries");
    e.Result = (object) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, setting, 300, (CommandArgumentType) 0, new object[4]
    {
      (object) "@UserGUID",
      (object) guid,
      (object) "@IsRead",
      (object) flag
    });
  }

  private void NoteLoadWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
  {
    if (this.IsDisposed)
      return;
    try
    {
      ((BackgroundWorker) sender).RunWorkerCompleted -= new RunWorkerCompletedEventHandler(this.NoteLoadWorkerComplete);
      try
      {
        if (this.DsToday.tblNotes.Count > 0)
          this.DsToday.tblNotes.Clear();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      DataTable result = (DataTable) e.Result;
      HashSet<string> stringSet = new HashSet<string>();
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) result.Columns)
        {
          if (!this.DsToday.tblNotes.Columns.Contains(column.ColumnName) && column.ColumnName.StartsWith("AddUICol"))
          {
            string str = column.ColumnName.Replace("AddUICol", "");
            if (!this.DsToday.tblNotes.Columns.Contains(str))
              this.DsToday.tblNotes.Columns.Add(str, typeof (string));
            stringSet.Add(str);
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        foreach (DataRow row in result.Rows)
        {
          dsToday.tblNotesRow tblNotesRow = this.DsToday.tblNotes.NewtblNotesRow();
          try
          {
            foreach (string columnName in stringSet)
              tblNotesRow[columnName] = (object) Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["AddUICol" + columnName]), "Unknown");
          }
          finally
          {
            HashSet<string>.Enumerator enumerator;
            enumerator.Dispose();
          }
          tblNotesRow.Body = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["Body"]), "Unknown");
          tblNotesRow.Completed = Utility.IsNull<bool>(RuntimeHelpers.GetObjectValue(row["IsRead"]), false);
          tblNotesRow.CreatedDate = Utility.IsNull<DateTime>(RuntimeHelpers.GetObjectValue(row["CreatedDate"]), DateAndTime.Now);
          tblNotesRow.EntryGUID = (Guid) row["EntryGUID"];
          tblNotesRow.PolicyNumber = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["PolicyNumber"]), "Unknown");
          tblNotesRow.Subject = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["Subject"]), "Unknown");
          tblNotesRow.ProducerContact = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["ProducerContact"]), "");
          if (row.Table.Columns.Contains("ControlNo") && !row.IsNull("ControlNo"))
            tblNotesRow.ControlNo = (int) row["ControlNo"];
          tblNotesRow.InsuredPolicyName = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["InsuredPolicyName"]), "Unknown");
          tblNotesRow.NoteType = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["NoteType"]), "Unknown");
          tblNotesRow.LineOfBusiness = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["LineOfBusiness"]), "Unknown");
          if (row["EffectiveDate"] != DBNull.Value && row["EffectiveDate"] != null)
            tblNotesRow.EffectiveDate = Conversions.ToDate(row["EffectiveDate"]);
          else
            tblNotesRow.SetEffectiveDateNull();
          tblNotesRow.QuoteStatus = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["QuoteStatus"]), "Unknown");
          if (row["PolicyType"] != DBNull.Value && row["PolicyType"] != null)
            tblNotesRow.PolicyType = row["PolicyType"].ToString();
          else
            tblNotesRow.SetPolicyTypeNull();
          if (row["StateID"] != DBNull.Value && row["StateID"] != null)
            tblNotesRow.StateID = row["StateID"].ToString();
          else
            tblNotesRow.SetStateIDNull();
          if (row.Table.Columns.Contains("UnderwriterName"))
          {
            if (row["UnderwriterName"] != DBNull.Value && row["UnderwriterName"] != null)
              tblNotesRow.UnderwriterName = row["UnderwriterName"].ToString();
            else
              tblNotesRow.SetUnderwriterNameNull();
          }
          else
            tblNotesRow.SetUnderwriterNameNull();
          if (row.Table.Columns.Contains("Premium"))
          {
            if (row["Premium"] != DBNull.Value && row["Premium"] != null)
              tblNotesRow.Premium = Conversions.ToDecimal(row["Premium"]);
            else
              tblNotesRow.SetPremiumNull();
          }
          else
            tblNotesRow.SetPremiumNull();
          if (row.Table.Columns.Contains("From"))
          {
            if (row["From"] != null && row["From"] != DBNull.Value)
              tblNotesRow.From = row["From"].ToString();
            else
              tblNotesRow.SetFromNull();
          }
          else
            tblNotesRow.SetFromNull();
          if (row.Table.Columns.Contains("NeededByDate"))
          {
            if (row["NeededByDate"] != DBNull.Value && row["NeededByDate"] != null)
              tblNotesRow.NeededByDate = Conversions.ToDate(row["NeededByDate"]);
            else
              tblNotesRow.SetNeededByDateNull();
          }
          else
            tblNotesRow.SetNeededByDateNull();
          if (row.Table.Columns.Contains("ClaimNumber"))
          {
            if (row["ClaimNumber"] != null && row["ClaimNumber"] != DBNull.Value)
              tblNotesRow.ClaimNumber = row["ClaimNumber"].ToString();
            else
              tblNotesRow.SetClaimNumberNull();
          }
          else
            tblNotesRow.SetClaimNumberNull();
          if (row.Table.Columns.Contains("ExpirationDate"))
          {
            if (row["ExpirationDate"] != null && row["ExpirationDate"] != DBNull.Value)
              tblNotesRow.ExpirationDate = Conversions.ToDate(row["ExpirationDate"]);
            else
              tblNotesRow.SetExpirationDateNull();
          }
          else
            tblNotesRow.SetExpirationDateNull();
          if (row.Table.Columns.Contains("ProducerLocationName"))
          {
            if (row["ProducerLocationName"] != null && row["ProducerLocationName"] != DBNull.Value)
              tblNotesRow.ProducerLocationName = row["ProducerLocationName"].ToString();
            else
              tblNotesRow.SetProducerLocationNameNull();
          }
          else
            tblNotesRow.SetProducerLocationNameNull();
          if (row.Table.Columns.Contains("DBA"))
          {
            if (!row.IsNull("DBA"))
              tblNotesRow.DBA = row.Field<string>("DBA");
            else
              tblNotesRow.SetDBANull();
          }
          else
            tblNotesRow.SetDBANull();
          this.SetClientAdditionalNoteColumns(row, tblNotesRow);
          if (row.IsNull("EditParent"))
            this.DsToday.tblNotes.AddtblNotesRow(tblNotesRow);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.dvNotes.RowFilter = !((UltraToggleEditorBase) this.chkDateRange).Checked ? string.Empty : $"CreatedDate >= #{this.dtFrom.DateTime.ToShortDateString()}# AND CreatedDate <= #{this.dtTo.DateTime.ToShortDateString()}#";
      this.grpMessages.Text = $"Messages ({((UltraGridBase) this.grdNotes).Rows.Count} items)";
      if (stringSet.Count > 0)
      {
        this.SetDataGridLayout(this.grdNotes, Preferences.GetPreferenceString("Screens.Today.TaskGrid.NoteGridPreference"));
        this.BuildNoteColumnCollection();
      }
      ((UltraGridBase) this.grdNotes).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
      ((UltraGridBase) this.grdNotes).Refresh();
      ((UltraGridBase) this.grdNotes).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual void SetClientAdditionalNoteColumns(DataRow row, dsToday.tblNotesRow notesRow)
  {
  }

  private void chkOnlyTodayTasks_CheckedChanged(object sender, EventArgs e)
  {
    if (!this._formLoaded)
      return;
    this.RefreshEntireView();
  }

  private void rdo_CheckedChanged(object sender, EventArgs e)
  {
    if (!this._formLoaded || !((RadioButton) sender).Checked)
      return;
    this.RefreshTaskView();
  }

  private void chkShow_CheckedChanged(object sender, EventArgs e)
  {
    if (!this._formLoaded)
      return;
    Preferences.SetPreference("Screens.Today.ShowOnStartup", ((UltraToggleEditorBase) this.chkShow).Checked);
  }

  private void RefreshTaskView() => this.LoadDiaryCheckBoxes();

  private void RefreshMessageView() => this.LoadNoteCheckBoxes();

  private void RefreshEntireView()
  {
    if (!this._formLoaded)
      return;
    this.RefreshMessageView();
    this.RefreshTaskView();
  }

  private void UltraGrid_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (Conversions.ToBoolean(e.Row.Cells["Completed"].Text))
      e.Row.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
    else
      e.Row.Appearance.FontData.Reset();
    if (sender != this.grdTasks)
      return;
    if (!Conversions.ToBoolean(e.Row.Cells["Completed"].Text) && DateTime.Compare(Conversions.ToDate(e.Row.Cells["DueDate"].Text), DateTime.Now) < 0)
      e.Row.Appearance.ForeColor = Color.Red;
    else
      ((AppearanceBase) e.Row.Appearance).ResetForeColor();
  }

  private void chkHideCompleted_CheckedChanged(object sender, EventArgs e)
  {
    if (!this._formLoaded)
      return;
    this.RefreshEntireView();
  }

  private void RefreshData()
  {
    this.SetGridPreferences();
    this.RefreshEntireView();
  }

  private void lnkRefreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.RefreshData();
  }

  public bool DrawElement(DrawPhase drawPhase, ref UIElementDrawParams drawParams)
  {
    bool flag;
    if (drawPhase == 128 /*0x80*/)
    {
      if (((UIElementDrawParams) ref drawParams).Element is HeaderUIElement)
      {
        if (((HeaderBase) ((UIElementDrawParams) ref drawParams).Element.GetContext(typeof (HeaderBase))).Caption.Length > 0)
          ((UIElementDrawParams) ref drawParams).DrawBorders((UIElementBorderStyle) 4, Border3DSide.Right);
        flag = true;
      }
      else
        flag = false;
    }
    else
      flag = true;
    return flag;
  }

  public DrawPhase GetPhasesToFilter(ref UIElementDrawParams drawParams) => (DrawPhase) 32896;

  private void grd_CellChange(object sender, CellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "Completed", false) != 0)
      return;
    Guid guid = (Guid) e.Cell.Row.Cells["EntryGUID"].Value;
    bool boolean = Conversions.ToBoolean(e.Cell.Text);
    e.Cell.Row.Appearance.FontData.Strikeout = !boolean ? (DefaultableBoolean) 2 : (DefaultableBoolean) 1;
    if (sender == this.grdTasks)
      Note_System.Instance.NonInteractive.CompleteDiaryEntry(guid, CurrentUser.Instance.UserGUID, boolean);
    else
      Note_System.Instance.NonInteractive.MarkNoteRead(guid, CurrentUser.Instance.UserGUID, true);
  }

  private void grd_Click(object sender, EventArgs e)
  {
    UIElement uiElement = ((ControlUIElementBase) ((UltraGridBase) sender).DisplayLayout.UIElement).LastElementEntered;
    if (uiElement == null)
      return;
    if (!(uiElement is CellUIElement))
      uiElement = uiElement.GetAncestor(typeof (CellUIElement));
    if (uiElement == null)
      return;
    UltraGridCell context = (UltraGridCell) uiElement.GetContext(typeof (UltraGridCell));
    Guid entryGuid = (Guid) context.Row.Cells["EntryGUID"].Value;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Column.Key, "Completed", false) == 0)
      return;
    this.OnDisplayNote(entryGuid);
  }

  protected virtual void OnDisplayNote(Guid entryGuid)
  {
    Note_System.Instance.UIInteractive.ViewNoteFromEntryGUID(entryGuid, false, (ISupportNoteSystem) null);
  }

  private void grd_MouseEnterElement(object sender, UIElementEventArgs e)
  {
    if (!(e.Element is RowUIElement))
      return;
    ((UltraGridRow) e.Element.GetContext(typeof (UltraGridRow))).Appearance.FontData.Underline = (DefaultableBoolean) 1;
  }

  private void grd_MouseLeaveElement(object sender, UIElementEventArgs e)
  {
    if (!(e.Element is RowUIElement))
      return;
    UltraGridRow context = (UltraGridRow) e.Element.GetContext(typeof (UltraGridRow));
    context.Appearance.FontData.Underline = (DefaultableBoolean) 2;
    bool flag;
    try
    {
      flag = context.Cells["Completed"].Text != null && Conversions.ToBoolean(context.Cells["Completed"].Text);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      flag = false;
      ProjectData.ClearProjectError();
    }
    if (flag)
      context.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
    else
      context.Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
  }

  private void chkDateRange_CheckedChanged(object sender, EventArgs e)
  {
    this.grpDateRange.Enabled = ((UltraToggleEditorBase) this.chkDateRange).Checked;
  }

  private void grdNotes_AfterRowFilterChanged(object sender, AfterRowFilterChangedEventArgs e)
  {
    this.grpMessages.Text = $"Messages ({this.GetUnfilteredRowCount(((UltraGridBase) this.grdNotes).Rows)} items)";
  }

  private void grdTasks_AfterRowFilterChanged(object sender, AfterRowFilterChangedEventArgs e)
  {
    this.grpTasks.Text = $"Messages ({this.GetUnfilteredRowCount(((UltraGridBase) this.grdTasks).Rows)} items)";
  }

  private int GetUnfilteredRowCount(RowsCollection rows)
  {
    int unfilteredRowCount = 0;
    foreach (UltraGridRow row in rows)
    {
      if (!row.IsFilteredOut)
        ++unfilteredRowCount;
    }
    return unfilteredRowCount;
  }

  private void RefreshTimer_Tick(object sender, EventArgs e) => this.RefreshEntireView();

  private void btnMessageColumns_Click(object sender, EventArgs e)
  {
    ObservableCollection<DataGridColumnInfo> newListForChooser = DataGridColumnInfo.CreateNewListForChooser(this.noteColList);
    System.Func<DataGridColumnInfo, int> keySelector;
    // ISSUE: reference to a compiler-generated field
    if (frmToday._Closure\u0024__.\u0024I189\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      keySelector = frmToday._Closure\u0024__.\u0024I189\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmToday._Closure\u0024__.\u0024I189\u002D0 = keySelector = (System.Func<DataGridColumnInfo, int>) ([SpecialName] (k) => k.Position);
    }
    IOrderedEnumerable<DataGridColumnInfo> columnList = newListForChooser.OrderBy<DataGridColumnInfo, int>(keySelector);
    IOrderedEnumerable<DataGridColumnInfo> orderedEnumerable = (IOrderedEnumerable<DataGridColumnInfo>) ObjectFactory.Instance.CreateObjectAs<ColumnChooserController>().DisplayUI((object) columnList);
    if (orderedEnumerable == null)
      return;
    this.noteColList = new ObservableCollection<DataGridColumnInfo>();
    try
    {
      foreach (DataGridColumnInfo dataGridColumnInfo in (IEnumerable<DataGridColumnInfo>) orderedEnumerable)
        this.noteColList.Add(dataGridColumnInfo);
    }
    finally
    {
      IEnumerator<DataGridColumnInfo> enumerator;
      enumerator?.Dispose();
    }
    try
    {
      foreach (DataGridColumnInfo noteCol in (Collection<DataGridColumnInfo>) this.noteColList)
        ((UltraGridBase) this.grdNotes).DisplayLayout.Bands[0].Columns[noteCol.ColumnKey].Hidden = noteCol.Hidden;
    }
    finally
    {
      IEnumerator<DataGridColumnInfo> enumerator;
      enumerator?.Dispose();
    }
  }

  private void btnTaskColumns_Click(object sender, EventArgs e)
  {
    ObservableCollection<DataGridColumnInfo> newListForChooser = DataGridColumnInfo.CreateNewListForChooser(this.taskColList);
    System.Func<DataGridColumnInfo, int> keySelector;
    // ISSUE: reference to a compiler-generated field
    if (frmToday._Closure\u0024__.\u0024I190\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      keySelector = frmToday._Closure\u0024__.\u0024I190\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmToday._Closure\u0024__.\u0024I190\u002D0 = keySelector = (System.Func<DataGridColumnInfo, int>) ([SpecialName] (k) => k.Position);
    }
    IOrderedEnumerable<DataGridColumnInfo> columnList = newListForChooser.OrderBy<DataGridColumnInfo, int>(keySelector);
    IOrderedEnumerable<DataGridColumnInfo> orderedEnumerable = (IOrderedEnumerable<DataGridColumnInfo>) ObjectFactory.Instance.CreateObjectAs<ColumnChooserController>().DisplayUI((object) columnList);
    if (orderedEnumerable == null)
      return;
    this.taskColList = new ObservableCollection<DataGridColumnInfo>();
    try
    {
      foreach (DataGridColumnInfo dataGridColumnInfo in (IEnumerable<DataGridColumnInfo>) orderedEnumerable)
        this.taskColList.Add(dataGridColumnInfo);
    }
    finally
    {
      IEnumerator<DataGridColumnInfo> enumerator;
      enumerator?.Dispose();
    }
    try
    {
      foreach (DataGridColumnInfo taskCol in (Collection<DataGridColumnInfo>) this.taskColList)
        ((UltraGridBase) this.grdTasks).DisplayLayout.Bands[0].Columns[taskCol.ColumnKey].Hidden = taskCol.Hidden;
    }
    finally
    {
      IEnumerator<DataGridColumnInfo> enumerator;
      enumerator?.Dispose();
    }
  }

  private void BuildNoteColumnCollection()
  {
    this.noteColList = new ObservableCollection<DataGridColumnInfo>();
    foreach (UltraGridColumn column in ((UltraGridBase) this.grdNotes).DisplayLayout.Bands[0].Columns)
    {
      if (!((IEnumerable<string>) this.alwaysHidden).Contains<string>(column.Key) && !string.IsNullOrEmpty(((HeaderBase) column.Header).Caption))
        this.noteColList.Add(DataGridColumnInfo.Allocate(column.Key, column.Hidden, ((HeaderBase) column.Header).Caption, column.Header.VisiblePosition));
    }
  }

  private void BuildTaskColumnCollection()
  {
    this.taskColList = new ObservableCollection<DataGridColumnInfo>();
    foreach (UltraGridColumn column in ((UltraGridBase) this.grdTasks).DisplayLayout.Bands[0].Columns)
    {
      if (!((IEnumerable<string>) this.alwaysHidden).Contains<string>(column.Key) && !string.IsNullOrEmpty(((HeaderBase) column.Header).Caption))
        this.taskColList.Add(DataGridColumnInfo.Allocate(column.Key, column.Hidden, ((HeaderBase) column.Header).Caption, column.Header.VisiblePosition));
    }
  }

  private void grdNotes_AfterColPosChanged(object sender, AfterColPosChangedEventArgs e)
  {
    this.BuildNoteColumnCollection();
  }

  private void grdTasks_AfterColPosChanged(object sender, AfterColPosChangedEventArgs e)
  {
    this.BuildTaskColumnCollection();
  }

  private void SetDataGridLayout(UltraGrid dg, string preferences)
  {
    if (string.IsNullOrEmpty(preferences))
      return;
    string[] source1 = preferences.Split(',');
    System.Func<string, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (frmToday._Closure\u0024__.\u0024I195\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = frmToday._Closure\u0024__.\u0024I195\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmToday._Closure\u0024__.\u0024I195\u002D0 = predicate = (System.Func<string, bool>) ([SpecialName] (cv) => cv.Contains("=") && cv.IndexOf("=") < cv.IndexOf("|"));
    }
    IEnumerable<string> source2 = ((IEnumerable<string>) source1).Where<string>(predicate);
    System.Func<string, (string, bool, int?)> selector;
    // ISSUE: reference to a compiler-generated field
    if (frmToday._Closure\u0024__.\u0024I195\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = frmToday._Closure\u0024__.\u0024I195\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmToday._Closure\u0024__.\u0024I195\u002D1 = selector = (System.Func<string, (string, bool, int?)>) ([SpecialName] (cv) =>
      {
        string[] strArray1 = cv.Split('=');
        string[] strArray2 = strArray1[1].Split('|');
        int result;
        return (strArray1[0].Trim(), bool.Parse(strArray2[0]), int.TryParse(strArray2[1], out result) ? new int?(result) : new int?());
      });
    }
    (string, bool, int?)[] array = source2.Select<string, (string, bool, int?)>(selector).ToArray<(string, bool, int?)>();
    int index = 0;
    while (index < array.Length)
    {
      (string, bool, int?) tuple = array[index];
      try
      {
        if (((KeyedSubObjectsCollectionBase) ((UltraGridBase) dg).DisplayLayout.Bands[0].Columns).Exists(tuple.Item1))
        {
          ((UltraGridBase) dg).DisplayLayout.Bands[0].Columns[tuple.Item1].Hidden = tuple.Item2;
          if (tuple.Item3.HasValue)
            ((UltraGridBase) dg).DisplayLayout.Bands[0].Columns[tuple.Item1].Header.VisiblePosition = tuple.Item3.Value;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.SilentLogError(ex);
        ProjectData.ClearProjectError();
      }
      checked { ++index; }
    }
  }

  private void grdNotes_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    if (this.DesignMode || this.setNotePreferences)
      return;
    this.SetDataGridLayout(this.grdNotes, Preferences.GetPreferenceString("Screens.Today.TaskGrid.NoteGridPreference"));
    this.BuildNoteColumnCollection();
    this.setNotePreferences = true;
  }

  private void grdTasks_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    if (this.DesignMode || this.setTaskPreferences)
      return;
    this.SetDataGridLayout(this.grdTasks, Preferences.GetPreferenceString("Screens.Today.TaskGrid.TaskGridPreference"));
    this.BuildTaskColumnCollection();
    this.setTaskPreferences = true;
  }

  private void btnSelectAllTasks_Click(object sender, EventArgs e)
  {
    if (SecurityManager.Instance.AssertPermission("{7ad09705-4768-4619-9a14-a88fd2ead2d2}"))
    {
      if (MessageBox.Show("Complete All Tasks", "Please confirm you'd like to complete all tasks.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      int num = ((UltraGridBase) this.grdTasks).Rows.Count - 1;
      for (int index = 0; index <= num; ++index)
      {
        if (!((UltraGridBase) this.grdTasks).Rows[index].IsFilteredOut && !(bool) ((UltraGridBase) this.grdTasks).Rows[index].Cells["Completed"].Value)
        {
          ((UltraGridBase) this.grdTasks).Rows[index].Cells["Completed"].Value = (object) true;
          Note_System.Instance.NonInteractive.CompleteDiaryEntry((Guid) ((UltraGridBase) this.grdTasks).Rows[index].Cells["EntryGUID"].Value, CurrentUser.Instance.UserGUID, true);
        }
      }
      this.RefreshData();
    }
    else
    {
      int num1 = (int) MessageBox.Show("You do not have permission to Complete All Tasks", "Security Halt", MessageBoxButtons.OK);
    }
  }

  private void btnMessageMarkAllRead_Click(object sender, EventArgs e)
  {
    if (SecurityManager.Instance.AssertPermission("{a5a1a012-9648-44a7-9c7c-7ef769fe287a}"))
    {
      if (MessageBox.Show("Mark All Messages Read", "Please confirm you'd like to mark all messages read.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      int num = ((UltraGridBase) this.grdNotes).Rows.Count - 1;
      for (int index = 0; index <= num; ++index)
      {
        if (!((UltraGridBase) this.grdNotes).Rows[index].IsFilteredOut)
        {
          if (((UltraGridBase) this.grdNotes).Rows[index].Cells["IsRead"].Value == null | ((UltraGridBase) this.grdNotes).Rows[index].Cells["IsRead"].Value == DBNull.Value)
            ((UltraGridBase) this.grdNotes).Rows[index].Cells["IsRead"].Value = (object) 0;
          if (!(bool) ((UltraGridBase) this.grdNotes).Rows[index].Cells["IsRead"].Value)
          {
            ((UltraGridBase) this.grdNotes).Rows[index].Cells["IsRead"].Value = (object) 1;
            Note_System.Instance.NonInteractive.MarkNoteRead((Guid) ((UltraGridBase) this.grdNotes).Rows[index].Cells["EntryGUID"].Value, CurrentUser.Instance.UserGUID, true);
          }
        }
      }
      this.RefreshData();
    }
    else
    {
      int num1 = (int) MessageBox.Show("You do not have permission to Mark All Messages Read", "Security Halt", MessageBoxButtons.OK);
    }
  }

  private void SetGridPreferences()
  {
    if (this.noteColList.Count > 0)
    {
      ObservableCollection<DataGridColumnInfo> noteColList = this.noteColList;
      System.Func<DataGridColumnInfo, string> selector;
      // ISSUE: reference to a compiler-generated field
      if (frmToday._Closure\u0024__.\u0024I200\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = frmToday._Closure\u0024__.\u0024I200\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmToday._Closure\u0024__.\u0024I200\u002D0 = selector = (System.Func<DataGridColumnInfo, string>) ([SpecialName] (ncl) => $"{ncl.ColumnKey}={ncl.Hidden}|{ncl.Position}");
      }
      Preferences.SetPreference("Screens.Today.TaskGrid.NoteGridPreference", string.Join(",", noteColList.Select<DataGridColumnInfo, string>(selector)));
    }
    if (this.taskColList.Count <= 0)
      return;
    ObservableCollection<DataGridColumnInfo> taskColList = this.taskColList;
    System.Func<DataGridColumnInfo, string> selector1;
    // ISSUE: reference to a compiler-generated field
    if (frmToday._Closure\u0024__.\u0024I200\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector1 = frmToday._Closure\u0024__.\u0024I200\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmToday._Closure\u0024__.\u0024I200\u002D1 = selector1 = (System.Func<DataGridColumnInfo, string>) ([SpecialName] (tcl) => $"{tcl.ColumnKey}={tcl.Hidden}|{tcl.Position}");
    }
    Preferences.SetPreference("Screens.Today.TaskGrid.TaskGridPreference", string.Join(",", taskColList.Select<DataGridColumnInfo, string>(selector1)));
  }
}

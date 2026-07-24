// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.BullPenForm
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
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
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SecureResource("{0B44D698-0256-4090-AE50-8A78159C210A}", "Diary Bull Pen Administration", "Allows the user to view others tasks and reassign them", "Note System")]
[SecureResource("{A9048583-8BB9-470E-BA14-C5D5C5F86F9F}", "View Others Task and Cannot Reassign", "Allows the user to view others tasks and NOT reassign them", "Note System")]
[Preference("Screens.BullPen.UserTaskGridPreference", "", false)]
[Preference("Screens.BullPen.AvailableTaskGridPreference", "", false)]
[Preference("Screens.BullPen.TestPreference", "", false)]
public class BullPenForm : Form
{
  private IContainer components;
  private bool AllOpenTasksFilteredByUserEnabled;
  private bool DefaultAnyForUnrestrictedUser;
  private readonly string UserFilteredAnyText;
  private bool UserIssuingOfficeViewIsRestricted;
  private bool AnyUserFilteredTaskSelected;
  internal const string SECURITYID_AdminPanel = "{0B44D698-0256-4090-AE50-8A78159C210A}";
  internal const string ViewTasksAndCannotReassign = "{A9048583-8BB9-470E-BA14-C5D5C5F86F9F}";
  internal const string AvailableTaskGridPreference = "Screens.BullPen.AvailableTaskGridPreference";
  internal const string UserTaskGridPreference = "Screens.BullPen.UserTaskGridPreference";
  private const string DeleteUserFromEntry = "DELETE FROM dbo.tblNoteRecipients WHERE UserGuid = @UserGuid AND EntryGuid = @EntryGuid";
  private const string SelectAllUsers = "SELECT tu.UserGuid, tu.Name_LastFirst AS FullName FROM dbo.tblUsers tu (NOLOCK) LEFT JOIN dbo.tblUserQuotingOffice qo WITH(NOLOCK) ON qo.UserGuid = @CurrentUserGuid WHERE StatusID != 3 AND ISNULL(qo.OfficeGuid, tu.OfficeGuid) = tu.OfficeGuid ORDER BY FullName";
  private const string IsAnotherUserOnThisDiary = "SELECT COUNT(1) FROM tblNoteRecipients (NOLOCK) WHERE EntryGUID = @EntryGuid AND IsDiary = 1";
  private const string fillIssuingOffice = "SELECT co.OfficeGUID, co.Location FROM dbo.tblClientOffices co WITH(NOLOCK) LEFT JOIN dbo.tblUserQuotingOffice qo WITH(NOLOCK) ON qo.UserGuid = @CurrentUserGuid WHERE ISNULL(qo.OfficeGuid, co.OfficeGUID) = co.OfficeGUID ORDER BY co.Location";
  private bool _userlistLoaded;
  private bool _issuingOfficeLoaded;
  private bool _ViewAndAssign;
  private bool _ViewOnly;
  private string opentaskproc;
  private BullPenForm.GridLayoutManager _layoutManagerAllItemsGrid;
  private BullPenForm.GridLayoutManager _layoutManagerMyItemsGrid;
  private ObservableCollection<DataGridColumnInfo> userColList;
  private ObservableCollection<DataGridColumnInfo> availableColList;
  private bool setAvailableTaskPreferences;
  private bool setUserTaskPreferences;
  private string[] alwaysHidden;

  internal virtual MGAButton btnCapture
  {
    get => this._btnCapture;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCapture_Click);
      MGAButton btnCapture1 = this._btnCapture;
      if (btnCapture1 != null)
        ((Control) btnCapture1).Click -= eventHandler;
      this._btnCapture = value;
      MGAButton btnCapture2 = this._btnCapture;
      if (btnCapture2 == null)
        return;
      ((Control) btnCapture2).Click += eventHandler;
    }
  }

  internal virtual LinkLabel lnkRefreshOpenTasks
  {
    get => this._lnkRefreshOpenTasks;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkRefreshOpenTasks_LinkClicked);
      LinkLabel refreshOpenTasks1 = this._lnkRefreshOpenTasks;
      if (refreshOpenTasks1 != null)
        refreshOpenTasks1.LinkClicked -= clickedEventHandler;
      this._lnkRefreshOpenTasks = value;
      LinkLabel refreshOpenTasks2 = this._lnkRefreshOpenTasks;
      if (refreshOpenTasks2 == null)
        return;
      refreshOpenTasks2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("grpOpenTasks")]
  internal virtual MGAGroupBox grpOpenTasks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual BackgroundWorker BackgroundWorkerAllTasks
  {
    get => this._BackgroundWorkerAllTasks;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorkerAllTasks_DoWork);
      RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorkerAllTasks_RunWorkerCompleted);
      BackgroundWorker backgroundWorkerAllTasks1 = this._BackgroundWorkerAllTasks;
      if (backgroundWorkerAllTasks1 != null)
      {
        backgroundWorkerAllTasks1.DoWork -= workEventHandler;
        backgroundWorkerAllTasks1.RunWorkerCompleted -= completedEventHandler;
      }
      this._BackgroundWorkerAllTasks = value;
      BackgroundWorker backgroundWorkerAllTasks2 = this._BackgroundWorkerAllTasks;
      if (backgroundWorkerAllTasks2 == null)
        return;
      backgroundWorkerAllTasks2.DoWork += workEventHandler;
      backgroundWorkerAllTasks2.RunWorkerCompleted += completedEventHandler;
    }
  }

  [field: AccessedThroughProperty("DsIMSTaskManagement")]
  internal virtual dsIMSTaskManagement DsIMSTaskManagement { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraGrid dgAvailableTasks
  {
    get => this._dgAvailableTasks;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DoubleClickCellEventHandler cellEventHandler = new DoubleClickCellEventHandler(this.dg_DoubleClickCell);
      AfterColPosChangedEventHandler changedEventHandler = new AfterColPosChangedEventHandler(this.dgAvailableTasks_AfterColPosChanged);
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.dgAvailableTasks_InitializeLayout);
      UltraGrid dgAvailableTasks1 = this._dgAvailableTasks;
      if (dgAvailableTasks1 != null)
      {
        dgAvailableTasks1.DoubleClickCell -= cellEventHandler;
        ((UltraGridBase) dgAvailableTasks1).AfterColPosChanged -= changedEventHandler;
        dgAvailableTasks1.InitializeLayout -= layoutEventHandler;
      }
      this._dgAvailableTasks = value;
      UltraGrid dgAvailableTasks2 = this._dgAvailableTasks;
      if (dgAvailableTasks2 == null)
        return;
      dgAvailableTasks2.DoubleClickCell += cellEventHandler;
      ((UltraGridBase) dgAvailableTasks2).AfterColPosChanged += changedEventHandler;
      dgAvailableTasks2.InitializeLayout += layoutEventHandler;
    }
  }

  [field: AccessedThroughProperty("grpMyTasks")]
  internal virtual MGAGroupBox grpMyTasks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlAdmin")]
  internal virtual Panel pnlAdmin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox cboCurrentUser
  {
    get => this._cboCurrentUser;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboCurrentUser_ValueChanged);
      MGASimpleComboBox cboCurrentUser1 = this._cboCurrentUser;
      if (cboCurrentUser1 != null)
        cboCurrentUser1.ValueChanged -= eventHandler;
      this._cboCurrentUser = value;
      MGASimpleComboBox cboCurrentUser2 = this._cboCurrentUser;
      if (cboCurrentUser2 == null)
        return;
      cboCurrentUser2.ValueChanged += eventHandler;
    }
  }

  internal virtual MGAButton btnRelease
  {
    get => this._btnRelease;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnRelease_Click);
      MGAButton btnRelease1 = this._btnRelease;
      if (btnRelease1 != null)
        ((Control) btnRelease1).Click -= eventHandler;
      this._btnRelease = value;
      MGAButton btnRelease2 = this._btnRelease;
      if (btnRelease2 == null)
        return;
      ((Control) btnRelease2).Click += eventHandler;
    }
  }

  internal virtual LinkLabel lnkRefreshMyTasks
  {
    get => this._lnkRefreshMyTasks;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkRefreshMyTasks_LinkClicked);
      LinkLabel lnkRefreshMyTasks1 = this._lnkRefreshMyTasks;
      if (lnkRefreshMyTasks1 != null)
        lnkRefreshMyTasks1.LinkClicked -= clickedEventHandler;
      this._lnkRefreshMyTasks = value;
      LinkLabel lnkRefreshMyTasks2 = this._lnkRefreshMyTasks;
      if (lnkRefreshMyTasks2 == null)
        return;
      lnkRefreshMyTasks2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("SplitContainer1")]
  internal virtual SplitContainer SplitContainer1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraGrid dgMyTasks
  {
    get => this._dgMyTasks;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DoubleClickCellEventHandler cellEventHandler = new DoubleClickCellEventHandler(this.dg_DoubleClickCell);
      AfterColPosChangedEventHandler changedEventHandler = new AfterColPosChangedEventHandler(this.dgMyTasks_AfterColPosChanged);
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.dgMyTasks_InitializeLayout);
      UltraGrid dgMyTasks1 = this._dgMyTasks;
      if (dgMyTasks1 != null)
      {
        dgMyTasks1.DoubleClickCell -= cellEventHandler;
        ((UltraGridBase) dgMyTasks1).AfterColPosChanged -= changedEventHandler;
        dgMyTasks1.InitializeLayout -= layoutEventHandler;
      }
      this._dgMyTasks = value;
      UltraGrid dgMyTasks2 = this._dgMyTasks;
      if (dgMyTasks2 == null)
        return;
      dgMyTasks2.DoubleClickCell += cellEventHandler;
      ((UltraGridBase) dgMyTasks2).AfterColPosChanged += changedEventHandler;
      dgMyTasks2.InitializeLayout += layoutEventHandler;
    }
  }

  internal virtual BackgroundWorker BackgroundWorkerMyTasks
  {
    get => this._BackgroundWorkerMyTasks;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorkerMyTasks_DoWork);
      RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorkerMyTasks_RunWorkerCompleted);
      BackgroundWorker backgroundWorkerMyTasks1 = this._BackgroundWorkerMyTasks;
      if (backgroundWorkerMyTasks1 != null)
      {
        backgroundWorkerMyTasks1.DoWork -= workEventHandler;
        backgroundWorkerMyTasks1.RunWorkerCompleted -= completedEventHandler;
      }
      this._BackgroundWorkerMyTasks = value;
      BackgroundWorker backgroundWorkerMyTasks2 = this._BackgroundWorkerMyTasks;
      if (backgroundWorkerMyTasks2 == null)
        return;
      backgroundWorkerMyTasks2.DoWork += workEventHandler;
      backgroundWorkerMyTasks2.RunWorkerCompleted += completedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblHelp")]
  internal virtual Label lblHelp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnMyOpenTasksColumns
  {
    get => this._btnMyOpenTasksColumns;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnMyOpenTasksColumns_Click);
      Button openTasksColumns1 = this._btnMyOpenTasksColumns;
      if (openTasksColumns1 != null)
        openTasksColumns1.Click -= eventHandler;
      this._btnMyOpenTasksColumns = value;
      Button openTasksColumns2 = this._btnMyOpenTasksColumns;
      if (openTasksColumns2 == null)
        return;
      openTasksColumns2.Click += eventHandler;
    }
  }

  internal virtual Button btnAvailableTaskCols
  {
    get => this._btnAvailableTaskCols;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAvailableTaskCols_Click);
      Button availableTaskCols1 = this._btnAvailableTaskCols;
      if (availableTaskCols1 != null)
        availableTaskCols1.Click -= eventHandler;
      this._btnAvailableTaskCols = value;
      Button availableTaskCols2 = this._btnAvailableTaskCols;
      if (availableTaskCols2 == null)
        return;
      availableTaskCols2.Click += eventHandler;
    }
  }

  internal virtual MGASimpleComboBox cboIssuingOffice
  {
    get => this._cboIssuingOffice;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboIssuingOffice_ValueChanged);
      MGASimpleComboBox cboIssuingOffice1 = this._cboIssuingOffice;
      if (cboIssuingOffice1 != null)
        cboIssuingOffice1.ValueChanged -= eventHandler;
      this._cboIssuingOffice = value;
      MGASimpleComboBox cboIssuingOffice2 = this._cboIssuingOffice;
      if (cboIssuingOffice2 == null)
        return;
      cboIssuingOffice2.ValueChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("AllOpenTasks", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("EntryGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("NoteGUID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CreatedDate");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Body");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Type");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Subject");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("InsuredPolicyName");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("UnderwriterName");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Producer");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("NoteType");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("DisplayStatus");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ClaimNumber");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("PolicyType");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("LOB");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Premium");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("NeededByDate");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("Carrier");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("UserOpenTasks", -1);
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("EntryGUID");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("NoteGUID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("CreatedDate");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("Body");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("Type");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("Subject");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("InsuredPolicyName", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("UnderwriterName");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("Producer");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("NoteType");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("DisplayStatus");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("ClaimNumber");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("PolicyType");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("LOB");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("Premium");
    Appearance appearance20 = new Appearance();
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("NeededByDate");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("Carrier");
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance32 = new Appearance();
    this.DsIMSTaskManagement = new dsIMSTaskManagement();
    this.BackgroundWorkerAllTasks = new BackgroundWorker();
    this.SplitContainer1 = new SplitContainer();
    this.grpOpenTasks = new MGAGroupBox();
    this.btnAvailableTaskCols = new Button();
    this.lblHelp = new Label();
    this.dgAvailableTasks = new UltraGrid();
    this.cboIssuingOffice = new MGASimpleComboBox();
    this.Label4 = new Label();
    this.lnkRefreshOpenTasks = new LinkLabel();
    this.btnCapture = new MGAButton();
    this.grpMyTasks = new MGAGroupBox();
    this.btnMyOpenTasksColumns = new Button();
    this.dgMyTasks = new UltraGrid();
    this.pnlAdmin = new Panel();
    this.Label1 = new Label();
    this.cboCurrentUser = new MGASimpleComboBox();
    this.btnRelease = new MGAButton();
    this.lnkRefreshMyTasks = new LinkLabel();
    this.BackgroundWorkerMyTasks = new BackgroundWorker();
    this.DsIMSTaskManagement.BeginInit();
    this.SplitContainer1.BeginInit();
    this.SplitContainer1.Panel1.SuspendLayout();
    this.SplitContainer1.Panel2.SuspendLayout();
    this.SplitContainer1.SuspendLayout();
    ((ISupportInitialize) this.grpOpenTasks).BeginInit();
    ((Control) this.grpOpenTasks).SuspendLayout();
    ((ISupportInitialize) this.dgAvailableTasks).BeginInit();
    ((ISupportInitialize) this.cboIssuingOffice).BeginInit();
    ((ISupportInitialize) this.btnCapture).BeginInit();
    ((ISupportInitialize) this.grpMyTasks).BeginInit();
    ((Control) this.grpMyTasks).SuspendLayout();
    ((ISupportInitialize) this.dgMyTasks).BeginInit();
    this.pnlAdmin.SuspendLayout();
    ((ISupportInitialize) this.cboCurrentUser).BeginInit();
    ((ISupportInitialize) this.btnRelease).BeginInit();
    this.SuspendLayout();
    this.DsIMSTaskManagement.DataSetName = "dsIMSTaskManagement";
    this.DsIMSTaskManagement.EnforceConstraints = false;
    this.DsIMSTaskManagement.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.BackgroundWorkerAllTasks.WorkerSupportsCancellation = true;
    this.SplitContainer1.Dock = DockStyle.Fill;
    this.SplitContainer1.Location = new Point(0, 0);
    this.SplitContainer1.Name = "SplitContainer1";
    this.SplitContainer1.Orientation = Orientation.Horizontal;
    this.SplitContainer1.Panel1.Controls.Add((Control) this.grpOpenTasks);
    this.SplitContainer1.Panel2.Controls.Add((Control) this.grpMyTasks);
    this.SplitContainer1.Size = new Size(963, 566);
    this.SplitContainer1.SplitterDistance = 259;
    this.SplitContainer1.TabIndex = 4;
    appearance1.BackColor = Color.FromArgb(239, 247, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpOpenTasks.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.grpOpenTasks).Controls.Add((Control) this.btnAvailableTaskCols);
    ((Control) this.grpOpenTasks).Controls.Add((Control) this.lblHelp);
    ((Control) this.grpOpenTasks).Controls.Add((Control) this.dgAvailableTasks);
    ((Control) this.grpOpenTasks).Controls.Add((Control) this.cboIssuingOffice);
    ((Control) this.grpOpenTasks).Controls.Add((Control) this.Label4);
    ((Control) this.grpOpenTasks).Controls.Add((Control) this.lnkRefreshOpenTasks);
    ((Control) this.grpOpenTasks).Controls.Add((Control) this.btnCapture);
    this.grpOpenTasks.Dock = DockStyle.Fill;
    appearance2.ForeColor = Color.FromArgb(21, 66, 139);
    this.grpOpenTasks.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.grpOpenTasks).Location = new Point(0, 0);
    ((Control) this.grpOpenTasks).Name = "grpOpenTasks";
    ((Control) this.grpOpenTasks).Size = new Size(963, 259);
    ((Control) this.grpOpenTasks).TabIndex = 0;
    this.grpOpenTasks.Text = "Available Tasks";
    this.grpOpenTasks.ViewStyle = (GroupBoxViewStyle) 2;
    this.btnAvailableTaskCols.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.btnAvailableTaskCols.Location = new Point(143, 221);
    this.btnAvailableTaskCols.Name = "btnAvailableTaskCols";
    this.btnAvailableTaskCols.Size = new Size((int) sbyte.MaxValue, 23);
    this.btnAvailableTaskCols.TabIndex = 14;
    this.btnAvailableTaskCols.Text = "Show / Hide Columns";
    this.btnAvailableTaskCols.UseVisualStyleBackColor = true;
    this.lblHelp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lblHelp.AutoSize = true;
    this.lblHelp.BackColor = Color.Transparent;
    this.lblHelp.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.lblHelp.Location = new Point(341, 227);
    this.lblHelp.Name = "lblHelp";
    this.lblHelp.Size = new Size(225, 13);
    this.lblHelp.TabIndex = 12;
    this.lblHelp.Text = "Choose a Quoting Office to get started.";
    ((Control) this.dgAvailableTasks).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgAvailableTasks).DataMember = "AllOpenTasks";
    ((UltraGridBase) this.dgAvailableTasks).DataSource = (object) this.DsIMSTaskManagement;
    appearance3.BackColor = SystemColors.Window;
    appearance3.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ultraGridColumn3.CellClickAction = (CellClickAction) 2;
    ultraGridColumn3.Format = "d";
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Created";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 13;
    ultraGridColumn3.Width = 67;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Format = "d";
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Due";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Width = 67;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 3;
    ultraGridColumn5.Width = 111;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 8;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 52;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Subject/Action";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Width = 111;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Policy Num.";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 5;
    ultraGridColumn8.Width = 96 /*0x60*/;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Ins. Policy Name";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 7;
    ultraGridColumn9.Width = 110;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Underwriter";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 11;
    ultraGridColumn10.Width = 83;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 12;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Type";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 10;
    ultraGridColumn12.Width = 82;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Ctrl#";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Effective";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 9;
    ultraGridColumn14.Width = 67;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Status";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Policy Type";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 18;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn20.CellAppearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 19;
    ultraGridColumn21.CellActivation = (Activation) 3;
    ultraGridColumn21.CellClickAction = (CellClickAction) 2;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Needed By Date";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 20;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 21;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 22;
    ultraGridBand1.Columns.AddRange(new object[23]
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
      (object) ultraGridColumn23
    });
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance5.BackColor = SystemColors.ActiveBorder;
    appearance5.BackColor2 = SystemColors.ControlDark;
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance5;
    appearance6.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance6;
    ((SpecialBoxBase) ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((SpecialBoxBase) ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.GroupByBox).Hidden = true;
    appearance7.BackColor = SystemColors.ControlLightLight;
    appearance7.BackColor2 = SystemColors.Control;
    appearance7.BackGradientStyle = (GradientStyle) 3;
    appearance7.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.MaxRowScrollRegions = 1;
    appearance8.BackColor = SystemColors.Window;
    appearance8.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = SystemColors.Highlight;
    appearance9.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance10.BackColor = SystemColors.Window;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance10;
    appearance11.BorderColor = Color.Silver;
    appearance11.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.CellPadding = 0;
    appearance12.BackColor = SystemColors.Control;
    appearance12.BackColor2 = SystemColors.ControlDark;
    appearance12.BackGradientAlignment = (GradientAlignment) 1;
    appearance12.BackGradientStyle = (GradientStyle) 3;
    appearance12.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance14.BackColor = SystemColors.Window;
    appearance14.BorderColor = Color.Silver;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance15.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance15;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.dgAvailableTasks).Font = new Font("Tahoma", 8f);
    ((Control) this.dgAvailableTasks).Location = new Point(8, 22);
    ((Control) this.dgAvailableTasks).Name = "dgAvailableTasks";
    ((Control) this.dgAvailableTasks).Size = new Size(947, 191);
    ((Control) this.dgAvailableTasks).TabIndex = 11;
    ((UltraControlBase) this.dgAvailableTasks).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgAvailableTasks).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.cboIssuingOffice).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.cboIssuingOffice.BorderStyle = (UIElementBorderStyle) 4;
    this.cboIssuingOffice.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboIssuingOffice).Location = new Point(683, 223);
    this.cboIssuingOffice.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboIssuingOffice).Name = "cboIssuingOffice";
    ((Control) this.cboIssuingOffice).Size = new Size(200, 21);
    ((Control) this.cboIssuingOffice).TabIndex = 10;
    ((UltraControlBase) this.cboIssuingOffice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboIssuingOffice).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(604, 227);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(77, 13);
    this.Label4.TabIndex = 9;
    this.Label4.Text = "Quoting Office";
    this.lnkRefreshOpenTasks.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkRefreshOpenTasks.AutoSize = true;
    this.lnkRefreshOpenTasks.BackColor = Color.Transparent;
    this.lnkRefreshOpenTasks.Location = new Point(16 /*0x10*/, 227);
    this.lnkRefreshOpenTasks.Name = "lnkRefreshOpenTasks";
    this.lnkRefreshOpenTasks.Size = new Size(121, 13);
    this.lnkRefreshOpenTasks.TabIndex = 6;
    this.lnkRefreshOpenTasks.TabStop = true;
    this.lnkRefreshOpenTasks.Text = "Refresh Available Tasks";
    ((Control) this.btnCapture).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance16.BackColor = Color.FromArgb(248, 248, 248);
    appearance16.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance16.BackGradientStyle = (GradientStyle) 2;
    appearance16.BorderColor = Color.DarkGray;
    appearance16.ImageHAlign = (HAlign) 2;
    appearance16.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCapture).Appearance = (AppearanceBase) appearance16;
    ((Control) this.btnCapture).Location = new Point(891, 219);
    ((Control) this.btnCapture).Name = "btnCapture";
    ((Control) this.btnCapture).Size = new Size(64 /*0x40*/, 32 /*0x20*/);
    ((Control) this.btnCapture).TabIndex = 2;
    ((ControlBase) this.btnCapture).Text = "Capture";
    this.btnCapture.UseOSThemes = (DefaultableBoolean) 2;
    appearance17.BackColor = Color.FromArgb(239, 247, 253);
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpMyTasks.ContentAreaAppearance = (AppearanceBase) appearance17;
    ((Control) this.grpMyTasks).Controls.Add((Control) this.btnMyOpenTasksColumns);
    ((Control) this.grpMyTasks).Controls.Add((Control) this.dgMyTasks);
    ((Control) this.grpMyTasks).Controls.Add((Control) this.pnlAdmin);
    ((Control) this.grpMyTasks).Controls.Add((Control) this.lnkRefreshMyTasks);
    this.grpMyTasks.Dock = DockStyle.Fill;
    appearance18.ForeColor = Color.FromArgb(21, 66, 139);
    this.grpMyTasks.HeaderAppearance = (AppearanceBase) appearance18;
    ((Control) this.grpMyTasks).Location = new Point(0, 0);
    ((Control) this.grpMyTasks).Name = "grpMyTasks";
    ((Control) this.grpMyTasks).Size = new Size(963, 303);
    ((Control) this.grpMyTasks).TabIndex = 3;
    this.grpMyTasks.Text = "My Open Tasks";
    this.grpMyTasks.ViewStyle = (GroupBoxViewStyle) 2;
    this.btnMyOpenTasksColumns.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.btnMyOpenTasksColumns.Location = new Point(183, 261);
    this.btnMyOpenTasksColumns.Name = "btnMyOpenTasksColumns";
    this.btnMyOpenTasksColumns.Size = new Size((int) sbyte.MaxValue, 23);
    this.btnMyOpenTasksColumns.TabIndex = 13;
    this.btnMyOpenTasksColumns.Text = "Show / Hide Columns";
    this.btnMyOpenTasksColumns.UseVisualStyleBackColor = true;
    ((Control) this.dgMyTasks).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgMyTasks).DataMember = "UserOpenTasks";
    ((UltraGridBase) this.dgMyTasks).DataSource = (object) this.DsIMSTaskManagement;
    appearance19.BackColor = SystemColors.Window;
    appearance19.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Appearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 0;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 1;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn26.CellActivation = (Activation) 3;
    ultraGridColumn26.Format = "d";
    ((HeaderBase) ultraGridColumn26.Header).Caption = "Created";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 13;
    ultraGridColumn26.Width = 87;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn27.Format = "d";
    ((HeaderBase) ultraGridColumn27.Header).Caption = "Due";
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 4;
    ultraGridColumn27.Width = 59;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 3;
    ultraGridColumn28.Width = 111;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 9;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 52;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Subject/Action";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 2;
    ultraGridColumn30.Width = 111;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Caption = "Policy Num.";
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 5;
    ultraGridColumn31.Width = 96 /*0x60*/;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Caption = "Ins. Policy Name";
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 7;
    ultraGridColumn32.Width = 125;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Caption = "Underwriter";
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 11;
    ultraGridColumn33.Width = 83;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 12;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Caption = "Type";
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 10;
    ultraGridColumn35.Width = 79;
    ((HeaderBase) ultraGridColumn36.Header).Caption = "Ctrl#";
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn37.Header).Caption = "Effective";
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 8;
    ultraGridColumn37.Width = 69;
    ((HeaderBase) ultraGridColumn38.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn39.Header).Caption = "Status";
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 15;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 16 /*0x10*/;
    ((HeaderBase) ultraGridColumn41.Header).Caption = "Policy Type";
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 17;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 18;
    ((AppearanceBase) appearance20).TextHAlignAsString = "Right";
    ultraGridColumn43.CellAppearance = (AppearanceBase) appearance20;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 19;
    ultraGridColumn44.CellActivation = (Activation) 3;
    ultraGridColumn44.CellClickAction = (CellClickAction) 2;
    ((HeaderBase) ultraGridColumn44.Header).Caption = "Needed By Date";
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 20;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 21;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 22;
    ultraGridBand2.Columns.AddRange(new object[23]
    {
      (object) ultraGridColumn24,
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
      (object) ultraGridColumn46
    });
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance21.BackColor = SystemColors.ActiveBorder;
    appearance21.BackColor2 = SystemColors.ControlDark;
    appearance21.BackGradientStyle = (GradientStyle) 2;
    appearance21.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dgMyTasks).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance21;
    appearance22.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance22;
    ((SpecialBoxBase) ((UltraGridBase) this.dgMyTasks).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((SpecialBoxBase) ((UltraGridBase) this.dgMyTasks).DisplayLayout.GroupByBox).Hidden = true;
    appearance23.BackColor = SystemColors.ControlLightLight;
    appearance23.BackColor2 = SystemColors.Control;
    appearance23.BackGradientStyle = (GradientStyle) 3;
    appearance23.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.MaxRowScrollRegions = 1;
    appearance24.BackColor = SystemColors.Window;
    appearance24.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance24;
    appearance25.BackColor = SystemColors.Highlight;
    appearance25.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance26.BackColor = SystemColors.Window;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance26;
    appearance27.BorderColor = Color.Silver;
    appearance27.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.CellPadding = 0;
    appearance28.BackColor = SystemColors.Control;
    appearance28.BackColor2 = SystemColors.ControlDark;
    appearance28.BackGradientAlignment = (GradientAlignment) 1;
    appearance28.BackGradientStyle = (GradientStyle) 3;
    appearance28.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance30.BackColor = SystemColors.Window;
    appearance30.BorderColor = Color.Silver;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance31.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance31;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.dgMyTasks).Font = new Font("Tahoma", 8f);
    ((Control) this.dgMyTasks).Location = new Point(8, 22);
    ((Control) this.dgMyTasks).Name = "dgMyTasks";
    ((Control) this.dgMyTasks).Size = new Size(947, 225);
    ((Control) this.dgMyTasks).TabIndex = 12;
    ((UltraControlBase) this.dgMyTasks).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgMyTasks).UseOsThemes = (DefaultableBoolean) 2;
    this.pnlAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.pnlAdmin.BackColor = Color.Transparent;
    this.pnlAdmin.Controls.Add((Control) this.Label1);
    this.pnlAdmin.Controls.Add((Control) this.cboCurrentUser);
    this.pnlAdmin.Controls.Add((Control) this.btnRelease);
    this.pnlAdmin.Location = new Point(571, 253);
    this.pnlAdmin.Name = "pnlAdmin";
    this.pnlAdmin.Size = new Size(384, 45);
    this.pnlAdmin.TabIndex = 8;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 18);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(62, 13);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Active User";
    this.cboCurrentUser.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCurrentUser.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboCurrentUser).Location = new Point(72, 16 /*0x10*/);
    this.cboCurrentUser.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCurrentUser).Name = "cboCurrentUser";
    ((Control) this.cboCurrentUser).Size = new Size(216, 21);
    ((Control) this.cboCurrentUser).TabIndex = 3;
    ((UltraControlBase) this.cboCurrentUser).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCurrentUser).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnRelease).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance32.BackColor = Color.FromArgb(248, 248, 248);
    appearance32.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance32.BackGradientStyle = (GradientStyle) 2;
    appearance32.BorderColor = Color.DarkGray;
    appearance32.ImageHAlign = (HAlign) 2;
    appearance32.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnRelease).Appearance = (AppearanceBase) appearance32;
    ((Control) this.btnRelease).Location = new Point(312, 10);
    ((Control) this.btnRelease).Name = "btnRelease";
    ((Control) this.btnRelease).Size = new Size(64 /*0x40*/, 32 /*0x20*/);
    ((Control) this.btnRelease).TabIndex = 1;
    ((ControlBase) this.btnRelease).Text = "Release";
    this.btnRelease.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkRefreshMyTasks.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkRefreshMyTasks.AutoSize = true;
    this.lnkRefreshMyTasks.BackColor = Color.Transparent;
    this.lnkRefreshMyTasks.Location = new Point(24, 271);
    this.lnkRefreshMyTasks.Name = "lnkRefreshMyTasks";
    this.lnkRefreshMyTasks.Size = new Size(153, 13);
    this.lnkRefreshMyTasks.TabIndex = 7;
    this.lnkRefreshMyTasks.TabStop = true;
    this.lnkRefreshMyTasks.Text = "Refresh Tasks Assigned To Me";
    this.BackgroundWorkerMyTasks.WorkerSupportsCancellation = true;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(963, 566);
    this.Controls.Add((Control) this.SplitContainer1);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.MinimumSize = new Size(475, 325);
    this.Name = nameof (BullPenForm);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "IMS Task Management";
    this.DsIMSTaskManagement.EndInit();
    this.SplitContainer1.Panel1.ResumeLayout(false);
    this.SplitContainer1.Panel2.ResumeLayout(false);
    this.SplitContainer1.EndInit();
    this.SplitContainer1.ResumeLayout(false);
    ((ISupportInitialize) this.grpOpenTasks).EndInit();
    ((Control) this.grpOpenTasks).ResumeLayout(false);
    ((Control) this.grpOpenTasks).PerformLayout();
    ((ISupportInitialize) this.dgAvailableTasks).EndInit();
    ((ISupportInitialize) this.cboIssuingOffice).EndInit();
    ((ISupportInitialize) this.btnCapture).EndInit();
    ((ISupportInitialize) this.grpMyTasks).EndInit();
    ((Control) this.grpMyTasks).ResumeLayout(false);
    ((Control) this.grpMyTasks).PerformLayout();
    ((ISupportInitialize) this.dgMyTasks).EndInit();
    this.pnlAdmin.ResumeLayout(false);
    this.pnlAdmin.PerformLayout();
    ((ISupportInitialize) this.cboCurrentUser).EndInit();
    ((ISupportInitialize) this.btnRelease).EndInit();
    this.ResumeLayout(false);
  }

  public BullPenForm()
  {
    this.FormClosing += new FormClosingEventHandler(this.BullPenForm_FormClosing);
    this.Load += new EventHandler(this.BullPenForm_Load);
    this.AllOpenTasksFilteredByUserEnabled = false;
    this.DefaultAnyForUnrestrictedUser = false;
    this.UserFilteredAnyText = "(Any)";
    this.UserIssuingOfficeViewIsRestricted = false;
    this.AnyUserFilteredTaskSelected = false;
    this.userColList = new ObservableCollection<DataGridColumnInfo>();
    this.availableColList = new ObservableCollection<DataGridColumnInfo>();
    this.setAvailableTaskPreferences = false;
    this.setUserTaskPreferences = false;
    this.alwaysHidden = new string[3]
    {
      "EntryGUID",
      "NoteGUID",
      "Type"
    };
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (this.availableColList.Count > 0)
    {
      ObservableCollection<DataGridColumnInfo> availableColList = this.availableColList;
      System.Func<DataGridColumnInfo, string> selector;
      // ISSUE: reference to a compiler-generated field
      if (BullPenForm._Closure\u0024__.\u0024I88\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = BullPenForm._Closure\u0024__.\u0024I88\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        BullPenForm._Closure\u0024__.\u0024I88\u002D0 = selector = (System.Func<DataGridColumnInfo, string>) ([SpecialName] (tcl) => $"{tcl.ColumnKey}={tcl.Hidden}|{tcl.Position}");
      }
      Preferences.SetPreference("Screens.BullPen.AvailableTaskGridPreference", string.Join(",", availableColList.Select<DataGridColumnInfo, string>(selector)));
    }
    if (this.userColList.Count > 0)
    {
      ObservableCollection<DataGridColumnInfo> userColList = this.userColList;
      System.Func<DataGridColumnInfo, string> selector;
      // ISSUE: reference to a compiler-generated field
      if (BullPenForm._Closure\u0024__.\u0024I88\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = BullPenForm._Closure\u0024__.\u0024I88\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        BullPenForm._Closure\u0024__.\u0024I88\u002D1 = selector = (System.Func<DataGridColumnInfo, string>) ([SpecialName] (ucl) => $"{ucl.ColumnKey}={ucl.Hidden}|{ucl.Position}");
      }
      Preferences.SetPreference("Screens.BullPen.UserTaskGridPreference", string.Join(",", userColList.Select<DataGridColumnInfo, string>(selector)));
    }
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void BullPenForm_FormClosing(object sender, FormClosingEventArgs e)
  {
    e.Cancel = false;
    try
    {
      if (this.BackgroundWorkerAllTasks.IsBusy)
        this.BackgroundWorkerAllTasks.CancelAsync();
      if (!this.BackgroundWorkerMyTasks.IsBusy)
        return;
      this.BackgroundWorkerMyTasks.CancelAsync();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void BullPenForm_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.AllOpenTasksFilteredByUserEnabled = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("NoteSystem.AllOpenTasksFilteredByUserEnabled");
    this.DefaultAnyForUnrestrictedUser = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("NoteSystem.DefaultAnyForUnrestrictedUser");
    this._layoutManagerAllItemsGrid = new BullPenForm.GridLayoutManager(this.dgAvailableTasks);
    this._layoutManagerMyItemsGrid = new BullPenForm.GridLayoutManager(this.dgMyTasks);
    ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Bands[0].Columns["Premium"].Format = "$###,###,##0.00";
    ((UltraGridBase) this.dgMyTasks).DisplayLayout.Bands[0].Columns["Premium"].Format = "$###,###,##0.00";
    this._ViewAndAssign = SecurityManager.Instance.AssertPermission("{0B44D698-0256-4090-AE50-8A78159C210A}");
    this._ViewOnly = SecurityManager.Instance.AssertPermission("{A9048583-8BB9-470E-BA14-C5D5C5F86F9F}");
    SendProducerDiaries.SendDiaryNotes();
    SendProducerDiaries.SendDriversDiaries();
    this.RefreshMyTasks();
    // ISSUE: reference to a compiler-generated method
    Task.WhenAll((IEnumerable<Task>) new List<Task>()
    {
      Task.Factory.StartNew<DataTable>(new Func<DataTable>(this.LoadUsersTask)).ContinueWith(new Action<Task<DataTable>>(this.LoadUsersComplete), TaskScheduler.FromCurrentSynchronizationContext()),
      Task.Factory.StartNew<DataTable>(new System.Func<object, DataTable>(this.FillOfficesTask), (object) this.UserGuid).ContinueWith(new Action<Task<DataTable>>(this.FillOfficesComplete), TaskScheduler.FromCurrentSynchronizationContext())
    }).ContinueWith((Action<Task>) ([SpecialName] (a0) => this._Lambda\u0024__105\u002D0()), TaskScheduler.FromCurrentSynchronizationContext());
    this.AddClientColumns(this.DsIMSTaskManagement);
  }

  protected virtual void AddClientColumns(dsIMSTaskManagement dsIMSTaskManagement)
  {
  }

  private DataTable LoadUsersTask()
  {
    return DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT tu.UserGuid, tu.Name_LastFirst AS FullName FROM dbo.tblUsers tu (NOLOCK) LEFT JOIN dbo.tblUserQuotingOffice qo WITH(NOLOCK) ON qo.UserGuid = @CurrentUserGuid WHERE StatusID != 3 AND ISNULL(qo.OfficeGuid, tu.OfficeGuid) = tu.OfficeGuid ORDER BY FullName", new object[2]
    {
      (object) "@CurrentUserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
  }

  private void LoadUsersComplete(Task<DataTable> dtTask)
  {
    ((UltraGridBase) this.cboCurrentUser).DataSource = (object) dtTask.Result;
    ((UltraDropDownBase) this.cboCurrentUser).ValueMember = "UserGuid";
    ((UltraDropDownBase) this.cboCurrentUser).DisplayMember = "FullName";
    this.cboCurrentUser.Value = (object) this.UserGuid;
    this._userlistLoaded = true;
  }

  private DataTable FillOfficesTask(object taskObj)
  {
    return DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT co.OfficeGUID, co.Location FROM dbo.tblClientOffices co WITH(NOLOCK) LEFT JOIN dbo.tblUserQuotingOffice qo WITH(NOLOCK) ON qo.UserGuid = @CurrentUserGuid WHERE ISNULL(qo.OfficeGuid, co.OfficeGUID) = co.OfficeGUID ORDER BY co.Location", new object[2]
    {
      (object) "@CurrentUserGuid",
      (object) (Guid) taskObj
    });
  }

  private void FillOfficesComplete(Task<DataTable> dtTask)
  {
    DataTable result = dtTask.Result;
    if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(1) from dbo.tblUserQuotingOffice WITH(NOLOCK) WHERE UserGuid = @CurrentUserGuid", new object[2]
    {
      (object) "@CurrentUserGuid",
      (object) this.UserGuid
    }) == 0)
    {
      this.UserIssuingOfficeViewIsRestricted = false;
      result.Rows.Add((object) Guid.Empty, (object) "(Any)");
    }
    else
    {
      this.UserIssuingOfficeViewIsRestricted = true;
      if (this.AllOpenTasksFilteredByUserEnabled)
        result.Rows.Add((object) Guid.Empty, (object) this.UserFilteredAnyText);
      this.cboIssuingOffice.AutoSelectOnOneItem = true;
      this.cboIssuingOffice.LimitToList = true;
    }
    ((UltraGridBase) this.cboIssuingOffice).DataSource = (object) new DataView(result);
    ((UltraDropDownBase) this.cboIssuingOffice).ValueMember = "OfficeGUID";
    ((UltraDropDownBase) this.cboIssuingOffice).DisplayMember = "Location";
    this._issuingOfficeLoaded = true;
    if (this.UserIssuingOfficeViewIsRestricted && this.AllOpenTasksFilteredByUserEnabled)
      this.cboIssuingOffice.SelectedText = this.UserFilteredAnyText;
    if (this.UserIssuingOfficeViewIsRestricted || !this.DefaultAnyForUnrestrictedUser)
      return;
    this.cboIssuingOffice.SelectedText = "(Any)";
  }

  private static void SetupNoteTypes(DataTable noteTypesTable, MGASimpleComboBox typesCombo)
  {
    ((UltraGridBase) typesCombo).DataSource = (object) new DataView(noteTypesTable);
    ((UltraDropDownBase) typesCombo).ValueMember = "NoteTypeID";
    ((UltraDropDownBase) typesCombo).DisplayMember = "Description";
    typesCombo.Value = (object) -99;
  }

  private void TableQuery_Completed(object sender, TableQueryMultithreadEventArgs e)
  {
    string key = (string) e.Key;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "LoadUsers", false) != 0)
      Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "IssuingOffice", false);
    this.Cursor = MgaCursors.Default;
  }

  private void lnkRefreshMyTasks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.RefreshMyTasks();
  }

  private void lnkRefreshOpenTasks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.RefreshOpenTasks();
  }

  private void btnCapture_Click(object sender, EventArgs e)
  {
    List<Guid> guidList = new List<Guid>();
    foreach (UltraGridRow row in this.dgAvailableTasks.Selected.Rows)
    {
      if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(1) FROM tblNoteRecipients (NOLOCK) WHERE EntryGUID = @EntryGuid AND IsDiary = 1", new object[2]
      {
        (object) "@EntryGuid",
        row.Cells["EntryGuid"].Value
      }) > 0)
      {
        if (MessageBox.Show("Would you still like to add this to your tasks?", "Another user has already taken ownership of this diary", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          DefaultDatabase.ExecuteNonQuery("NoteSystem_AddDiaryRecipient", new object[4]
          {
            (object) "@UserGuid",
            (object) this.UserGuid,
            (object) "@EntryGuid",
            row.Cells["EntryGuid"].Value
          });
          dsIMSTaskManagement.AllOpenTasksRow byEntryGuid = this.DsIMSTaskManagement.AllOpenTasks.FindByEntryGUID((Guid) row.Cells["EntryGuid"].Value);
          dsIMSTaskManagement.UserOpenTasksRow userOpenTasksRow = this.DsIMSTaskManagement.UserOpenTasks.NewUserOpenTasksRow();
          this.CopyRowValues((DataRow) userOpenTasksRow, (DataRow) byEntryGuid);
          this.DsIMSTaskManagement.UserOpenTasks.AddUserOpenTasksRow(userOpenTasksRow);
          guidList.Add(byEntryGuid.EntryGUID);
          CurrentUser.Instance.LogAction($"Note captured - Recipient:{row.Cells["UnderwriterName"].Text} Body:{row.Cells["Body"].Text}", Guid.Parse("58157792-2325-44C9-A5C7-DFFAE2E9208A"), row.Cells["EntryGuid"].Text);
        }
      }
      else
      {
        DefaultDatabase.ExecuteNonQuery("NoteSystem_AddDiaryRecipient", new object[4]
        {
          (object) "@UserGuid",
          (object) this.UserGuid,
          (object) "@EntryGuid",
          row.Cells["EntryGuid"].Value
        });
        dsIMSTaskManagement.AllOpenTasksRow byEntryGuid = this.DsIMSTaskManagement.AllOpenTasks.FindByEntryGUID((Guid) row.Cells["EntryGuid"].Value);
        dsIMSTaskManagement.UserOpenTasksRow userOpenTasksRow = this.DsIMSTaskManagement.UserOpenTasks.NewUserOpenTasksRow();
        this.CopyRowValues((DataRow) userOpenTasksRow, (DataRow) byEntryGuid);
        this.DsIMSTaskManagement.UserOpenTasks.AddUserOpenTasksRow(userOpenTasksRow);
        guidList.Add(byEntryGuid.EntryGUID);
        CurrentUser.Instance.LogAction($"Note captured - Recipient:{row.Cells["UnderwriterName"].Text} Body:{row.Cells["Body"].Text}", Guid.Parse("58157792-2325-44C9-A5C7-DFFAE2E9208A"), row.Cells["EntryGuid"].Text);
      }
    }
    try
    {
      foreach (Guid guid in guidList)
      {
        DataRow byEntryGuid = (DataRow) this.DsIMSTaskManagement.AllOpenTasks.FindByEntryGUID(guid);
        if (byEntryGuid != null)
        {
          this.LogCaptureAction(guid, (dsIMSTaskManagement.AllOpenTasksRow) byEntryGuid);
          byEntryGuid.Delete();
        }
      }
    }
    finally
    {
      List<Guid>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this.EnableButtons();
  }

  private void LogCaptureAction(Guid entry, dsIMSTaskManagement.AllOpenTasksRow row)
  {
    if (!SystemSettings.GetSetting<bool>("Task.log.Capture.button", false))
      return;
    string action = $"Task Management Capture button was triggered. - Subject: {row.Subject}";
    if (!row.IsControlNoNull())
    {
      Guid identifier = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT  q.QuoteGUID  From dbo.tblQuotes q INNER Join dbo.tblNoteEntities Ne On Ne.ControlGuid = q.ControlGuid WHERE Ne.NoteGUID = @NoteGUID", new object[2]
      {
        (object) "@NoteGUID",
        (object) row.NoteGUID
      });
      CurrentUser.Instance.LogAction(action, identifier, "Quoteguid");
    }
    else
      CurrentUser.Instance.LogAction(action, entry, "EntryGuid");
  }

  private void CopyRowValues(DataRow newRow, DataRow originalRow)
  {
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) originalRow.Table.Columns)
      {
        if (!originalRow.IsNull(column.ColumnName))
          newRow[column.ColumnName] = RuntimeHelpers.GetObjectValue(originalRow[column.ColumnName]);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void btnRelease_Click(object sender, EventArgs e)
  {
    List<Guid> guidList = new List<Guid>();
    foreach (UltraGridRow row in this.dgMyTasks.Selected.Rows)
    {
      Guid EntryGUID = (Guid) row.Cells["EntryGuid"].Value;
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM dbo.tblNoteRecipients WHERE UserGuid = @UserGuid AND EntryGuid = @EntryGuid", new object[4]
      {
        (object) "@UserGuid",
        (object) this.UserGuid,
        (object) "@EntryGuid",
        (object) EntryGUID
      });
      dsIMSTaskManagement.UserOpenTasksRow byEntryGuid = this.DsIMSTaskManagement.UserOpenTasks.FindByEntryGUID(EntryGUID);
      dsIMSTaskManagement.AllOpenTasksRow allOpenTasksRow = this.DsIMSTaskManagement.AllOpenTasks.NewAllOpenTasksRow();
      this.CopyRowValues((DataRow) allOpenTasksRow, (DataRow) byEntryGuid);
      this.DsIMSTaskManagement.AllOpenTasks.AddAllOpenTasksRow(allOpenTasksRow);
      guidList.Add(byEntryGuid.EntryGUID);
    }
    try
    {
      foreach (Guid guid in guidList)
      {
        DataRow byEntryGuid = (DataRow) this.DsIMSTaskManagement.UserOpenTasks.FindByEntryGUID(guid);
        if (byEntryGuid != null)
        {
          BullPenForm.LogReleaseAction(guid, (dsIMSTaskManagement.UserOpenTasksRow) byEntryGuid);
          byEntryGuid.Delete();
        }
      }
    }
    finally
    {
      List<Guid>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this.EnableButtons();
  }

  private static void LogReleaseAction(Guid entry, dsIMSTaskManagement.UserOpenTasksRow row)
  {
    if (!SystemSettings.GetSetting<bool>("Task.log.Release.button", false))
      return;
    string action = $"Task Management Release button was triggered. - Subject: {row.Subject}";
    if (!row.IsControlNoNull())
    {
      Guid identifier = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT  q.QuoteGUID  From dbo.tblQuotes q INNER Join dbo.tblNoteEntities Ne On Ne.ControlGuid = q.ControlGuid WHERE Ne.NoteGUID = @NoteGUID", new object[2]
      {
        (object) "@NoteGUID",
        (object) row.NoteGUID
      });
      CurrentUser.Instance.LogAction(action, identifier, "Quoteguid");
    }
    else
      CurrentUser.Instance.LogAction(action, entry, "EntryGuid");
  }

  private void EnableButtons()
  {
    ((Control) this.btnCapture).Enabled = ((UltraGridBase) this.dgAvailableTasks).Rows.Count > 0;
    ((Control) this.btnRelease).Enabled = ((UltraGridBase) this.dgMyTasks).Rows.Count > 0 && this._ViewAndAssign;
    ((Control) this.cboCurrentUser).Enabled = this._ViewAndAssign || this._ViewOnly;
  }

  private Guid UserGuid
  {
    get
    {
      Guid userGuid;
      if (this.cboCurrentUser.Value == null || ((UltraGridBase) this.cboCurrentUser).Rows.Count == 0)
      {
        userGuid = CurrentUser.Instance.UserGUID;
      }
      else
      {
        object obj = this.cboCurrentUser.Value;
        userGuid = obj != null ? (Guid) obj : new Guid();
      }
      return userGuid;
    }
  }

  private void cboCurrentUser_ValueChanged(object sender, EventArgs e)
  {
    if (!this._userlistLoaded)
      return;
    this.grpMyTasks.Text = "Loading...";
    this.RefreshMyTasks();
  }

  private void cboIssuingOffice_ValueChanged(object sender, EventArgs e) => this.RefreshOpenTasks();

  private void AddComboParameter(
    Dictionary<string, DbParameter> list,
    MGASimpleComboBox cbo,
    string parameterName)
  {
    if (this.AllOpenTasksFilteredByUserEnabled)
    {
      this.AnyUserFilteredTaskSelected = !string.IsNullOrEmpty(cbo.Text) && cbo.Value != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cbo.Text, this.UserFilteredAnyText, false) == 0 && this.UserIssuingOfficeViewIsRestricted;
      if (string.IsNullOrEmpty(cbo.Text) || cbo.Value == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cbo.Text, "(Any)", false) == 0 | this.AnyUserFilteredTaskSelected)
        return;
      list.Add(parameterName, DefaultDatabase.CreateParameter(ParameterDirection.Input, parameterName, RuntimeHelpers.GetObjectValue(cbo.Value)));
    }
    else
    {
      if (string.IsNullOrEmpty(cbo.Text) || cbo.Value == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cbo.Text, "(Any)", false) == 0)
        return;
      list.Add(parameterName, DefaultDatabase.CreateParameter(ParameterDirection.Input, parameterName, RuntimeHelpers.GetObjectValue(cbo.Value)));
    }
  }

  private void RefreshMyTasks()
  {
    if (this.BackgroundWorkerMyTasks.IsBusy)
      return;
    ((Control) this.grpMyTasks).Enabled = false;
    this._layoutManagerMyItemsGrid.SaveLayout();
    this.Cursor = MgaCursors.WaitCursor;
    this.grpMyTasks.Text = "Loading...";
    ((UltraGridBase) this.dgMyTasks).DataSource = (object) null;
    this.DsIMSTaskManagement.UserOpenTasks.Clear();
    this.BackgroundWorkerMyTasks.RunWorkerAsync((object) this.UserGuid);
  }

  private void RefreshOpenTasks()
  {
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("IssuingOfficeRqdForTaskRefresh") && Information.IsNothing(RuntimeHelpers.GetObjectValue(this.cboIssuingOffice.Value)))
    {
      int num = (int) MessageBox.Show("An Issuing Office must be selected before refreshing tasks", "Select an Issuing Office", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (!this._issuingOfficeLoaded || this.BackgroundWorkerAllTasks.IsBusy)
        return;
      this._layoutManagerAllItemsGrid.SaveLayout();
      this.Cursor = MgaCursors.WaitCursor;
      this.grpOpenTasks.Text = "Loading...";
      Dictionary<string, DbParameter> list = new Dictionary<string, DbParameter>();
      this.AddComboParameter(list, this.cboIssuingOffice, "@OfficeGUID");
      if (this.AllOpenTasksFilteredByUserEnabled && this.AnyUserFilteredTaskSelected)
        list.Add("@UserGuid", DefaultDatabase.CreateParameter(ParameterDirection.Input, "@UserGuid", (object) CurrentUser.Instance.UserGUID));
      ((Control) this.grpOpenTasks).Enabled = false;
      ((UltraGridBase) this.dgAvailableTasks).DataSource = (object) null;
      this.DsIMSTaskManagement.AllOpenTasks.Clear();
      this.BackgroundWorkerAllTasks.RunWorkerAsync((object) list);
    }
  }

  private void BackgroundWorkerAllTasks_DoWork(object sender, DoWorkEventArgs e)
  {
    Dictionary<string, DbParameter> dictionary = e.Argument as Dictionary<string, DbParameter>;
    string setting = SystemSettings.GetSetting<string>("NoteSystem.AllOpenTasksProcName", "dbo.spLoadAllOpenTasks");
    if (this.AllOpenTasksFilteredByUserEnabled && this.AnyUserFilteredTaskSelected)
      setting = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("NoteSystem.AllOpenTasksFilteredByUserProcName", string.Empty);
    this.opentaskproc = setting;
    if (dictionary == null)
      return;
    DefaultDatabase.LoadDataTable((DataTable) this.DsIMSTaskManagement.AllOpenTasks, CommandType.StoredProcedure, setting, 500, (CommandArgumentType) 2, new object[1]
    {
      (object) dictionary
    });
    dsIMSTaskManagement.AllOpenTasksDataTable allOpenTasks1 = this.DsIMSTaskManagement.AllOpenTasks;
    System.Func<dsIMSTaskManagement.AllOpenTasksRow, bool> predicate1;
    // ISSUE: reference to a compiler-generated field
    if (BullPenForm._Closure\u0024__.\u0024I128\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate1 = BullPenForm._Closure\u0024__.\u0024I128\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      BullPenForm._Closure\u0024__.\u0024I128\u002D0 = predicate1 = (System.Func<dsIMSTaskManagement.AllOpenTasksRow, bool>) ([SpecialName] (aot) => !aot.IsControlNoNull() && aot.IsExpirationDateNull());
    }
    if (!allOpenTasks1.Any<dsIMSTaskManagement.AllOpenTasksRow>(predicate1))
      return;
    dsIMSTaskManagement.AllOpenTasksDataTable allOpenTasks2 = this.DsIMSTaskManagement.AllOpenTasks;
    System.Func<dsIMSTaskManagement.AllOpenTasksRow, bool> predicate2;
    // ISSUE: reference to a compiler-generated field
    if (BullPenForm._Closure\u0024__.\u0024I128\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate2 = BullPenForm._Closure\u0024__.\u0024I128\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      BullPenForm._Closure\u0024__.\u0024I128\u002D1 = predicate2 = (System.Func<dsIMSTaskManagement.AllOpenTasksRow, bool>) ([SpecialName] (aot) => !aot.IsControlNoNull() && aot.IsExpirationDateNull());
    }
    EnumerableRowCollection<dsIMSTaskManagement.AllOpenTasksRow> source = allOpenTasks2.Where<dsIMSTaskManagement.AllOpenTasksRow>(predicate2);
    System.Func<dsIMSTaskManagement.AllOpenTasksRow, int> selector;
    // ISSUE: reference to a compiler-generated field
    if (BullPenForm._Closure\u0024__.\u0024I128\u002D2 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = BullPenForm._Closure\u0024__.\u0024I128\u002D2;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      BullPenForm._Closure\u0024__.\u0024I128\u002D2 = selector = (System.Func<dsIMSTaskManagement.AllOpenTasksRow, int>) ([SpecialName] (ot) => ot.ControlNo);
    }
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.AllTaskExperationDates", new object[2]
    {
      (object) "@ControlNosString",
      (object) string.Join<int>(",", (IEnumerable<int>) source.Select<dsIMSTaskManagement.AllOpenTasksRow, int>(selector))
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        BullPenForm._Closure\u0024__128\u002D0 closure1280 = new BullPenForm._Closure\u0024__128\u002D0(closure1280);
        if (!row.IsNull("ExpirationDate"))
        {
          // ISSUE: reference to a compiler-generated field
          closure1280.\u0024VB\u0024Local_controlNo = row.Field<int>("ControlNo");
          // ISSUE: reference to a compiler-generated method
          List<dsIMSTaskManagement.AllOpenTasksRow> list = this.DsIMSTaskManagement.AllOpenTasks.Where<dsIMSTaskManagement.AllOpenTasksRow>(new System.Func<dsIMSTaskManagement.AllOpenTasksRow, bool>(closure1280._Lambda\u0024__3)).ToList<dsIMSTaskManagement.AllOpenTasksRow>();
          if (list != null)
          {
            try
            {
              foreach (dsIMSTaskManagement.AllOpenTasksRow allOpenTasksRow in list)
              {
                if (allOpenTasksRow.IsExpirationDateNull())
                  allOpenTasksRow.ExpirationDate = row.Field<DateTime>("ExpirationDate");
              }
            }
            finally
            {
              List<dsIMSTaskManagement.AllOpenTasksRow>.Enumerator enumerator;
              enumerator.Dispose();
            }
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void BackgroundWorkerAllTasks_RunWorkerCompleted(
    object sender,
    RunWorkerCompletedEventArgs e)
  {
    try
    {
      ((Control) this.grpOpenTasks).Enabled = true;
      this.lblHelp.Visible = false;
      ((UltraGridBase) this.dgAvailableTasks).DataSource = (object) this.DsIMSTaskManagement;
      ((UltraGridBase) this.dgAvailableTasks).DataMember = "AllOpenTasks";
      this._layoutManagerAllItemsGrid.LoadLayout();
      ((UltraGridBase) this.dgAvailableTasks).DataSource = (object) this.DsIMSTaskManagement;
      this._layoutManagerAllItemsGrid.LoadLayout();
      this.grpOpenTasks.Text = "Available Tasks";
      if (((UltraGridBase) this.dgAvailableTasks).Rows == null)
        return;
      if (((UltraGridBase) this.dgAvailableTasks).Rows.Count > 0)
        ((UltraGridBase) this.dgAvailableTasks).Rows[0].Selected = true;
      else
        ((Control) this.btnCapture).Enabled = false;
      this.Cursor = Cursors.Default;
      this.EnableButtons();
      this.FormatClientColumns(this.dgAvailableTasks);
      this.BuildAvailableColumnCollection();
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual void FormatClientColumns(UltraGrid CurrentGrid)
  {
  }

  private void dg_DoubleClickCell(object sender, DoubleClickCellEventArgs e)
  {
    if (ObjectFactory.Instance.CreateObjectEX(typeof (NoteOverrideInformation), (object) "viewing note from bullpen or my tasks double click", (object) new object[2]
    {
      (object) (Guid) e.Cell.Row.Cells["NoteGuid"].Value,
      (object) (Guid) e.Cell.Row.Cells["EntryGuid"].Value
    }) is NoteOverrideInformation objectEx && objectEx.CancelOperation)
      objectEx.PerformOverrideAction();
    else
      Note_System.Instance.UIInteractive.ViewNote((Guid) e.Cell.Row.Cells["NoteGuid"].Value);
  }

  private void BackgroundWorkerMyTasks_DoWork(object sender, DoWorkEventArgs e)
  {
    try
    {
      DefaultDatabase.LoadDataTable((DataTable) this.DsIMSTaskManagement.UserOpenTasks, CommandType.StoredProcedure, SystemSettings.GetSetting<string>("NoteSystem.UserOpenTasksProcName", "dbo.spLoadUserOpenTasks"), 500, (CommandArgumentType) 0, new object[2]
      {
        (object) "@UserGuid",
        (object) (Guid) e.Argument
      });
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.SilentLogError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void BackgroundWorkerMyTasks_RunWorkerCompleted(
    object sender,
    RunWorkerCompletedEventArgs e)
  {
    try
    {
      ((Control) this.grpMyTasks).Enabled = true;
      ((UltraGridBase) this.dgMyTasks).DataSource = (object) this.DsIMSTaskManagement;
      ((UltraGridBase) this.dgMyTasks).DataMember = "UserOpenTasks";
      this._layoutManagerMyItemsGrid.LoadLayout();
      if (((UltraGridBase) this.dgMyTasks).Rows == null)
        return;
      this.grpMyTasks.Text = "My Open Tasks";
      if (((UltraGridBase) this.dgMyTasks).Rows.Count > 0)
        ((UltraGridBase) this.dgMyTasks).Rows[0].Selected = true;
      this.Cursor = MgaCursors.Default;
      this.EnableButtons();
      this.FormatClientColumns(this.dgMyTasks);
      this.BuildMyTaskColumnCollection();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void btnMyOpenTasksColumns_Click(object sender, EventArgs e)
  {
    ObservableCollection<DataGridColumnInfo> newListForChooser = DataGridColumnInfo.CreateNewListForChooser(this.userColList);
    System.Func<DataGridColumnInfo, int> keySelector;
    // ISSUE: reference to a compiler-generated field
    if (BullPenForm._Closure\u0024__.\u0024I140\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      keySelector = BullPenForm._Closure\u0024__.\u0024I140\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      BullPenForm._Closure\u0024__.\u0024I140\u002D0 = keySelector = (System.Func<DataGridColumnInfo, int>) ([SpecialName] (k) => k.Position);
    }
    IOrderedEnumerable<DataGridColumnInfo> columnList = newListForChooser.OrderBy<DataGridColumnInfo, int>(keySelector);
    IOrderedEnumerable<DataGridColumnInfo> orderedEnumerable = (IOrderedEnumerable<DataGridColumnInfo>) ObjectFactory.Instance.CreateObjectAs<ColumnChooserController>().DisplayUI((object) columnList);
    if (orderedEnumerable == null)
      return;
    this.userColList = new ObservableCollection<DataGridColumnInfo>();
    try
    {
      foreach (DataGridColumnInfo dataGridColumnInfo in (IEnumerable<DataGridColumnInfo>) orderedEnumerable)
        this.userColList.Add(dataGridColumnInfo);
    }
    finally
    {
      IEnumerator<DataGridColumnInfo> enumerator;
      enumerator?.Dispose();
    }
    try
    {
      foreach (DataGridColumnInfo userCol in (Collection<DataGridColumnInfo>) this.userColList)
        ((UltraGridBase) this.dgMyTasks).DisplayLayout.Bands[0].Columns[userCol.ColumnKey].Hidden = userCol.Hidden;
    }
    finally
    {
      IEnumerator<DataGridColumnInfo> enumerator;
      enumerator?.Dispose();
    }
  }

  private void btnAvailableTaskCols_Click(object sender, EventArgs e)
  {
    if (this.availableColList.Count == 0)
      this.BuildAvailableColumnCollection();
    ObservableCollection<DataGridColumnInfo> newListForChooser = DataGridColumnInfo.CreateNewListForChooser(this.availableColList);
    System.Func<DataGridColumnInfo, int> keySelector;
    // ISSUE: reference to a compiler-generated field
    if (BullPenForm._Closure\u0024__.\u0024I141\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      keySelector = BullPenForm._Closure\u0024__.\u0024I141\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      BullPenForm._Closure\u0024__.\u0024I141\u002D0 = keySelector = (System.Func<DataGridColumnInfo, int>) ([SpecialName] (k) => k.Position);
    }
    IOrderedEnumerable<DataGridColumnInfo> columnList = newListForChooser.OrderBy<DataGridColumnInfo, int>(keySelector);
    IOrderedEnumerable<DataGridColumnInfo> orderedEnumerable = (IOrderedEnumerable<DataGridColumnInfo>) ObjectFactory.Instance.CreateObjectAs<ColumnChooserController>().DisplayUI((object) columnList);
    if (orderedEnumerable == null)
      return;
    this.availableColList = new ObservableCollection<DataGridColumnInfo>();
    try
    {
      foreach (DataGridColumnInfo dataGridColumnInfo in (IEnumerable<DataGridColumnInfo>) orderedEnumerable)
        this.availableColList.Add(dataGridColumnInfo);
    }
    finally
    {
      IEnumerator<DataGridColumnInfo> enumerator;
      enumerator?.Dispose();
    }
    try
    {
      foreach (DataGridColumnInfo availableCol in (Collection<DataGridColumnInfo>) this.availableColList)
        ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Bands[0].Columns[availableCol.ColumnKey].Hidden = availableCol.Hidden;
    }
    finally
    {
      IEnumerator<DataGridColumnInfo> enumerator;
      enumerator?.Dispose();
    }
  }

  private void BuildAvailableColumnCollection()
  {
    this.availableColList = new ObservableCollection<DataGridColumnInfo>();
    foreach (UltraGridColumn column in ((UltraGridBase) this.dgAvailableTasks).DisplayLayout.Bands[0].Columns)
    {
      if (!((IEnumerable<string>) this.alwaysHidden).Contains<string>(column.Key))
        this.availableColList.Add(DataGridColumnInfo.Allocate(column.Key, column.Hidden, ((HeaderBase) column.Header).Caption, column.Header.VisiblePosition));
    }
  }

  private void BuildMyTaskColumnCollection()
  {
    this.userColList = new ObservableCollection<DataGridColumnInfo>();
    foreach (UltraGridColumn column in ((UltraGridBase) this.dgMyTasks).DisplayLayout.Bands[0].Columns)
    {
      if (!((IEnumerable<string>) this.alwaysHidden).Contains<string>(column.Key))
        this.userColList.Add(DataGridColumnInfo.Allocate(column.Key, column.Hidden, ((HeaderBase) column.Header).Caption, column.Header.VisiblePosition));
    }
  }

  private void dgAvailableTasks_AfterColPosChanged(object sender, AfterColPosChangedEventArgs e)
  {
    this.BuildAvailableColumnCollection();
  }

  private void dgMyTasks_AfterColPosChanged(object sender, AfterColPosChangedEventArgs e)
  {
    this.BuildMyTaskColumnCollection();
  }

  private void SetDataGridLayout(UltraGrid dg, string preferences)
  {
    if (string.IsNullOrEmpty(preferences))
      return;
    string[] source1 = preferences.Split(',');
    System.Func<string, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (BullPenForm._Closure\u0024__.\u0024I146\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = BullPenForm._Closure\u0024__.\u0024I146\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      BullPenForm._Closure\u0024__.\u0024I146\u002D0 = predicate = (System.Func<string, bool>) ([SpecialName] (cv) => cv.Contains("=") && cv.IndexOf("=") < cv.IndexOf("|"));
    }
    IEnumerable<string> source2 = ((IEnumerable<string>) source1).Where<string>(predicate);
    System.Func<string, (string, bool, int?)> selector;
    // ISSUE: reference to a compiler-generated field
    if (BullPenForm._Closure\u0024__.\u0024I146\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = BullPenForm._Closure\u0024__.\u0024I146\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      BullPenForm._Closure\u0024__.\u0024I146\u002D1 = selector = (System.Func<string, (string, bool, int?)>) ([SpecialName] (cv) =>
      {
        string[] strArray1 = cv.Split('=');
        string[] strArray2 = strArray1[1].Split('|');
        int result;
        return (strArray1[0], bool.Parse(strArray2[0]), int.TryParse(strArray2[1], out result) ? new int?(result) : new int?());
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

  private void dgAvailableTasks_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    if (this.setAvailableTaskPreferences)
      return;
    this.SetDataGridLayout(this.dgAvailableTasks, Preferences.GetPreferenceString("Screens.BullPen.AvailableTaskGridPreference"));
    this.BuildAvailableColumnCollection();
    this.setAvailableTaskPreferences = true;
  }

  private void dgMyTasks_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    if (this.setUserTaskPreferences)
      return;
    this.SetDataGridLayout(this.dgMyTasks, Preferences.GetPreferenceString("Screens.BullPen.UserTaskGridPreference"));
    this.BuildMyTaskColumnCollection();
    this.setUserTaskPreferences = true;
  }

  private class GridLayoutManager
  {
    private MemoryStream _layout;
    private UltraGrid _grid;

    public GridLayoutManager(UltraGrid grid)
    {
      this._grid = grid;
      ((UltraGridBase) this._grid).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
      ((Control) this._grid).FindForm().FormClosing += new FormClosingEventHandler(this.FormClosing);
    }

    public void SaveLayout()
    {
      this.ReleaseLayout();
      this._layout = new MemoryStream();
      if (this._grid == null)
        return;
      try
      {
        ((UltraGridBase) this._grid).DisplayLayout.Save((Stream) this._layout);
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }

    public void LoadLayout()
    {
      if (this._layout == null)
        return;
      this._layout.Position = 0L;
      if (this._grid == null)
        return;
      try
      {
        ((UltraGridBase) this._grid).DisplayLayout.Load((Stream) this._layout);
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }

    private void FormClosing(object sender, FormClosingEventArgs e)
    {
      ((Form) sender).FormClosing -= new FormClosingEventHandler(this.FormClosing);
      this._grid = (UltraGrid) null;
      this.ReleaseLayout();
    }

    private void ReleaseLayout()
    {
      if (this._layout == null)
        return;
      this._layout.Dispose();
      this._layout = (MemoryStream) null;
    }
  }
}

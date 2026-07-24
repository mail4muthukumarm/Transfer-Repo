// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.TabNoteSearch
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinDock;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.DockingManagement;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SecureTabResource("{78CF79DA-1392-43a5-A52D-E87DEEADDA8B}", "Access Note Search Tab", "Ability of user to access the tab at all", "Note Search System")]
public class TabNoteSearch : DelayLoadUserControl, IDockingInfoProvider
{
  internal const string SecurityIDViewNoteSearchTab = "{78CF79DA-1392-43a5-A52D-E87DEEADDA8B}";
  private IContainer components;
  private SqlDataAdapter daNoteTypes;
  private SqlCommand SqlSelectCommand1;
  private SqlConnection cnSQL;
  private dsTabNoteSearch DsTabNoteSearch;
  private SqlDataAdapter daUsers;
  private SqlCommand SqlSelectCommand2;
  private DataView vwUsers;
  private SqlCommand SqlSelectCommand3;
  private SqlDataAdapter daAssociationTypes;
  private SqlDataAdapter daEntities;
  private SqlCommand SqlSelectCommand4;
  private Panel Panel1;
  private MGATab MgaTab1;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private UltraTabPageControl UltraTabPageControl1;
  private Panel Panel3;
  private Label Label6;
  private Label Label10;
  private MGADateTimePicker dtCreatedTo;
  private MGADateTimePicker dtCreatedFrom;
  private RadioButton rbCreatedPastYear;
  private RadioButton rbCreatedPastMonth;
  private RadioButton rbCreatedLastWeek;
  private RadioButton rbCreatedDontRemember;
  private Label Label11;
  private Label Label12;
  private Label Label13;
  private UltraTabPageControl UltraTabPageControl2;
  private Label Label2;
  private Panel Panel2;
  private Label Label17;
  private Label Label18;
  private MGADateTimePicker dtModifiedTo;
  private MGADateTimePicker dtModifiedFrom;
  private RadioButton rbModifiedPastYear;
  private RadioButton rbModifiedPastMonth;
  private RadioButton rbModifiedLastWeek;
  private RadioButton rbModifiedDontRemember;
  private Label Label8;
  private Label Label9;
  private UltraTabPageControl UltraTabPageControl3;
  private UltraTabPageControl UltraTabPageControl4;
  private Label Label4;
  private MGASimpleComboBox cboAssociationName;
  private Label Label3;
  private MGASimpleComboBox cboAssociatedToEntityType;
  private Label Label1;
  private Label Label15;
  private MGASimpleComboBox cboUserCreated;
  private Label Label16;
  private MGASimpleComboBox cboUsersModified;
  private Label Label5;
  private MGATextBox txtSubject;
  private Label Label14;
  private MGATextBox txtBody;
  private Label Label7;
  private MGASimpleComboBox cboNoteType;
  private MGACheckBox chkDispResultsInNewWindow;
  private MGACheckBox chkDisplayProgress;
  private DataView vwAssignedTo;
  private Label Label20;
  private Label Label21;
  private DataView vwCreatedBy;
  private MGASimpleComboBox cboEntryCreatedBy;
  private MGASimpleComboBox cboEntryAssignedTo;
  private Panel Panel4;
  private Label Label19;
  private Label Label22;
  private Label Label23;
  private Label Label24;
  private Label Label25;
  private RadioButton rbDiaryWithinLastYear;
  private RadioButton rbDiaryPastMonth;
  private RadioButton rbDiaryLastWeek;
  private RadioButton rbDiaryDontRemember;
  private MGADateTimePicker dtDiaryTo;
  private MGADateTimePicker dtDiaryFrom;
  private Label Label26;
  private Panel Panel5;
  private RadioButton rbDiaryStatusDontRemember;
  private RadioButton rbDiaryStatusCompleted;
  private RadioButton rbDiaryStatusNotCompleted;
  private string _cboUserCreated_displayMember;
  private string _cboUserCreated_valueMember;
  private string _cboNoteTypes_displayMember;
  private string _cboNoteTypes_valueMember;
  private string _cboAssociatedType_displayMember;
  private string _cboAssociatedType_valueMember;
  private string _cboAssociatedEntity_displayMember;
  private string _cboAssociatedEntity_valueMember;
  private bool _addedWhere;
  private bool _ShowDueDate;
  private bool _showAssociatedEntity;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual RadioButton rbCreatedSpecify
  {
    get => this._rbCreatedSpecify;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbCreatedSpecify_CheckedChanged);
      RadioButton rbCreatedSpecify1 = this._rbCreatedSpecify;
      if (rbCreatedSpecify1 != null)
        rbCreatedSpecify1.CheckedChanged -= eventHandler;
      this._rbCreatedSpecify = value;
      RadioButton rbCreatedSpecify2 = this._rbCreatedSpecify;
      if (rbCreatedSpecify2 == null)
        return;
      rbCreatedSpecify2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbModifiedSpecify
  {
    get => this._rbModifiedSpecify;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbModifiedSpecify_CheckedChanged);
      RadioButton rbModifiedSpecify1 = this._rbModifiedSpecify;
      if (rbModifiedSpecify1 != null)
        rbModifiedSpecify1.CheckedChanged -= eventHandler;
      this._rbModifiedSpecify = value;
      RadioButton rbModifiedSpecify2 = this._rbModifiedSpecify;
      if (rbModifiedSpecify2 == null)
        return;
      rbModifiedSpecify2.CheckedChanged += eventHandler;
    }
  }

  private virtual MGAButton btnReset
  {
    get => this._btnReset;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnReset_Click);
      MGAButton btnReset1 = this._btnReset;
      if (btnReset1 != null)
        ((Control) btnReset1).Click -= eventHandler;
      this._btnReset = value;
      MGAButton btnReset2 = this._btnReset;
      if (btnReset2 == null)
        return;
      ((Control) btnReset2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnSearch
  {
    get => this._btnSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSearch_Click);
      MGAButton btnSearch1 = this._btnSearch;
      if (btnSearch1 != null)
        ((Control) btnSearch1).Click -= eventHandler;
      this._btnSearch = value;
      MGAButton btnSearch2 = this._btnSearch;
      if (btnSearch2 == null)
        return;
      ((Control) btnSearch2).Click += eventHandler;
    }
  }

  private virtual RadioButton rbDiaryDates
  {
    get => this._rbDiaryDates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbDiaryDates_CheckedChanged);
      RadioButton rbDiaryDates1 = this._rbDiaryDates;
      if (rbDiaryDates1 != null)
        rbDiaryDates1.CheckedChanged -= eventHandler;
      this._rbDiaryDates = value;
      RadioButton rbDiaryDates2 = this._rbDiaryDates;
      if (rbDiaryDates2 == null)
        return;
      rbDiaryDates2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label29")]
  private virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtCompletedto")]
  private virtual MGADateTimePicker dtCompletedto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGADateTimePicker dtCompletedFrom
  {
    get => this._dtCompletedFrom;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dtCompletedFrom_ValueChanged);
      MGADateTimePicker dtCompletedFrom1 = this._dtCompletedFrom;
      if (dtCompletedFrom1 != null)
        dtCompletedFrom1.ValueChanged -= eventHandler;
      this._dtCompletedFrom = value;
      MGADateTimePicker dtCompletedFrom2 = this._dtCompletedFrom;
      if (dtCompletedFrom2 == null)
        return;
      dtCompletedFrom2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label30")]
  private virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label27")]
  private virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cboCompletedBy
  {
    get => this._cboCompletedBy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboCompletedBy_ValueChanged);
      MGASimpleComboBox cboCompletedBy1 = this._cboCompletedBy;
      if (cboCompletedBy1 != null)
        cboCompletedBy1.ValueChanged -= eventHandler;
      this._cboCompletedBy = value;
      MGASimpleComboBox cboCompletedBy2 = this._cboCompletedBy;
      if (cboCompletedBy2 == null)
        return;
      cboCompletedBy2.ValueChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkCompletedDt
  {
    get => this._chkCompletedDt;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkCompletedDt_CheckedChanged);
      MGACheckBox chkCompletedDt1 = this._chkCompletedDt;
      if (chkCompletedDt1 != null)
        ((UltraToggleEditorBase) chkCompletedDt1).CheckedChanged -= eventHandler;
      this._chkCompletedDt = value;
      MGACheckBox chkCompletedDt2 = this._chkCompletedDt;
      if (chkCompletedDt2 == null)
        return;
      ((UltraToggleEditorBase) chkCompletedDt2).CheckedChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
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
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    UltraTab ultraTab3 = new UltraTab();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.Panel3 = new Panel();
    this.Label6 = new Label();
    this.Label10 = new Label();
    this.dtCreatedTo = new MGADateTimePicker();
    this.dtCreatedFrom = new MGADateTimePicker();
    this.rbCreatedSpecify = new RadioButton();
    this.rbCreatedPastYear = new RadioButton();
    this.rbCreatedPastMonth = new RadioButton();
    this.rbCreatedLastWeek = new RadioButton();
    this.rbCreatedDontRemember = new RadioButton();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.Label2 = new Label();
    this.Panel2 = new Panel();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.dtModifiedTo = new MGADateTimePicker();
    this.dtModifiedFrom = new MGADateTimePicker();
    this.rbModifiedSpecify = new RadioButton();
    this.rbModifiedPastYear = new RadioButton();
    this.rbModifiedPastMonth = new RadioButton();
    this.rbModifiedLastWeek = new RadioButton();
    this.rbModifiedDontRemember = new RadioButton();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.Label21 = new Label();
    this.cboEntryAssignedTo = new MGASimpleComboBox();
    this.vwAssignedTo = new DataView();
    this.DsTabNoteSearch = new dsTabNoteSearch();
    this.Label20 = new Label();
    this.cboEntryCreatedBy = new MGASimpleComboBox();
    this.vwCreatedBy = new DataView();
    this.UltraTabPageControl4 = new UltraTabPageControl();
    this.Panel5 = new Panel();
    this.rbDiaryStatusNotCompleted = new RadioButton();
    this.rbDiaryStatusCompleted = new RadioButton();
    this.rbDiaryStatusDontRemember = new RadioButton();
    this.Label26 = new Label();
    this.Label25 = new Label();
    this.Panel4 = new Panel();
    this.Label19 = new Label();
    this.Label22 = new Label();
    this.dtDiaryTo = new MGADateTimePicker();
    this.dtDiaryFrom = new MGADateTimePicker();
    this.rbDiaryDates = new RadioButton();
    this.rbDiaryWithinLastYear = new RadioButton();
    this.rbDiaryPastMonth = new RadioButton();
    this.rbDiaryLastWeek = new RadioButton();
    this.rbDiaryDontRemember = new RadioButton();
    this.Label23 = new Label();
    this.Label24 = new Label();
    this.vwUsers = new DataView();
    this.daNoteTypes = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.daUsers = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.daAssociationTypes = new SqlDataAdapter();
    this.SqlSelectCommand3 = new SqlCommand();
    this.daEntities = new SqlDataAdapter();
    this.SqlSelectCommand4 = new SqlCommand();
    this.Panel1 = new Panel();
    this.chkCompletedDt = new MGACheckBox();
    this.Label29 = new Label();
    this.dtCompletedto = new MGADateTimePicker();
    this.dtCompletedFrom = new MGADateTimePicker();
    this.Label30 = new Label();
    this.Label27 = new Label();
    this.cboCompletedBy = new MGASimpleComboBox();
    this.MgaTab1 = new MGATab();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.Label4 = new Label();
    this.cboAssociationName = new MGASimpleComboBox();
    this.Label3 = new Label();
    this.cboAssociatedToEntityType = new MGASimpleComboBox();
    this.btnReset = new MGAButton();
    this.Label1 = new Label();
    this.btnSearch = new MGAButton();
    this.Label15 = new Label();
    this.cboUserCreated = new MGASimpleComboBox();
    this.Label16 = new Label();
    this.cboUsersModified = new MGASimpleComboBox();
    this.Label5 = new Label();
    this.txtSubject = new MGATextBox();
    this.Label14 = new Label();
    this.txtBody = new MGATextBox();
    this.Label7 = new Label();
    this.cboNoteType = new MGASimpleComboBox();
    this.chkDispResultsInNewWindow = new MGACheckBox();
    this.chkDisplayProgress = new MGACheckBox();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    this.Panel3.SuspendLayout();
    ((ISupportInitialize) this.dtCreatedTo).BeginInit();
    ((ISupportInitialize) this.dtCreatedFrom).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.dtModifiedTo).BeginInit();
    ((ISupportInitialize) this.dtModifiedFrom).BeginInit();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.cboEntryAssignedTo).BeginInit();
    this.vwAssignedTo.BeginInit();
    this.DsTabNoteSearch.BeginInit();
    ((ISupportInitialize) this.cboEntryCreatedBy).BeginInit();
    this.vwCreatedBy.BeginInit();
    ((Control) this.UltraTabPageControl4).SuspendLayout();
    this.Panel5.SuspendLayout();
    this.Panel4.SuspendLayout();
    ((ISupportInitialize) this.dtDiaryTo).BeginInit();
    ((ISupportInitialize) this.dtDiaryFrom).BeginInit();
    this.vwUsers.BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.chkCompletedDt).BeginInit();
    ((ISupportInitialize) this.dtCompletedto).BeginInit();
    ((ISupportInitialize) this.dtCompletedFrom).BeginInit();
    ((ISupportInitialize) this.cboCompletedBy).BeginInit();
    ((ISupportInitialize) this.MgaTab1).BeginInit();
    ((Control) this.MgaTab1).SuspendLayout();
    ((ISupportInitialize) this.cboAssociationName).BeginInit();
    ((ISupportInitialize) this.cboAssociatedToEntityType).BeginInit();
    ((ISupportInitialize) this.btnReset).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.cboUserCreated).BeginInit();
    ((ISupportInitialize) this.cboUsersModified).BeginInit();
    ((ISupportInitialize) this.txtSubject).BeginInit();
    ((ISupportInitialize) this.txtBody).BeginInit();
    ((ISupportInitialize) this.cboNoteType).BeginInit();
    ((ISupportInitialize) this.chkDispResultsInNewWindow).BeginInit();
    ((ISupportInitialize) this.chkDisplayProgress).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Panel3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label13);
    ((Control) this.UltraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(294, 261);
    this.Panel3.BackColor = Color.Transparent;
    this.Panel3.Controls.Add((Control) this.Label6);
    this.Panel3.Controls.Add((Control) this.Label10);
    this.Panel3.Controls.Add((Control) this.dtCreatedTo);
    this.Panel3.Controls.Add((Control) this.dtCreatedFrom);
    this.Panel3.Controls.Add((Control) this.rbCreatedSpecify);
    this.Panel3.Controls.Add((Control) this.rbCreatedPastYear);
    this.Panel3.Controls.Add((Control) this.rbCreatedPastMonth);
    this.Panel3.Controls.Add((Control) this.rbCreatedLastWeek);
    this.Panel3.Controls.Add((Control) this.rbCreatedDontRemember);
    this.Panel3.Controls.Add((Control) this.Label11);
    this.Panel3.Controls.Add((Control) this.Label12);
    this.Panel3.Location = new Point(8, 24);
    this.Panel3.Name = "Panel3";
    this.Panel3.Size = new Size(224 /*0xE0*/, 152);
    this.Panel3.TabIndex = 32 /*0x20*/;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label6.Location = new Point(24, 96 /*0x60*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(29, 13);
    this.Label6.TabIndex = 16 /*0x10*/;
    this.Label6.Text = "from";
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label10.Location = new Point(32 /*0x20*/, 120);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(17, 13);
    this.Label10.TabIndex = 17;
    this.Label10.Text = "to";
    appearance1.BorderColor = Color.Gray;
    this.dtCreatedTo.Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.LightGray;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.LightGray;
    appearance2.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtCreatedTo.ButtonAppearance = (AppearanceBase) appearance2;
    this.dtCreatedTo.DateTime = new DateTime(2004, 9, 2, 10, 5, 33, 683);
    ((Control) this.dtCreatedTo).Enabled = false;
    ((Control) this.dtCreatedTo).Location = new Point(56, 120);
    ((Control) this.dtCreatedTo).Name = "dtCreatedTo";
    ((Control) this.dtCreatedTo).Size = new Size(104, 20);
    ((Control) this.dtCreatedTo).TabIndex = 9;
    ((UltraControlBase) this.dtCreatedTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtCreatedTo).UseOsThemes = (DefaultableBoolean) 2;
    this.dtCreatedTo.Value = (object) new DateTime(2004, 9, 2, 10, 5, 33, 683);
    appearance3.BorderColor = Color.Gray;
    this.dtCreatedFrom.Appearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.LightGray;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.LightGray;
    appearance4.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtCreatedFrom.ButtonAppearance = (AppearanceBase) appearance4;
    this.dtCreatedFrom.DateTime = new DateTime(2004, 9, 2, 10, 5, 33, 730);
    ((Control) this.dtCreatedFrom).Enabled = false;
    ((Control) this.dtCreatedFrom).Location = new Point(56, 96 /*0x60*/);
    ((Control) this.dtCreatedFrom).Name = "dtCreatedFrom";
    ((Control) this.dtCreatedFrom).Size = new Size(104, 20);
    ((Control) this.dtCreatedFrom).TabIndex = 8;
    ((UltraControlBase) this.dtCreatedFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtCreatedFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.dtCreatedFrom.Value = (object) new DateTime(2004, 9, 2, 10, 5, 33, 730);
    this.rbCreatedSpecify.BackColor = Color.Transparent;
    this.rbCreatedSpecify.FlatStyle = FlatStyle.Flat;
    this.rbCreatedSpecify.Location = new Point(8, 72);
    this.rbCreatedSpecify.Name = "rbCreatedSpecify";
    this.rbCreatedSpecify.Size = new Size(184, 24);
    this.rbCreatedSpecify.TabIndex = 6;
    this.rbCreatedSpecify.Text = "Specify dates";
    this.rbCreatedSpecify.UseVisualStyleBackColor = false;
    this.rbCreatedPastYear.BackColor = Color.Transparent;
    this.rbCreatedPastYear.FlatStyle = FlatStyle.Flat;
    this.rbCreatedPastYear.Location = new Point(8, 54);
    this.rbCreatedPastYear.Name = "rbCreatedPastYear";
    this.rbCreatedPastYear.Size = new Size(184, 24);
    this.rbCreatedPastYear.TabIndex = 5;
    this.rbCreatedPastYear.Text = "Within the past year";
    this.rbCreatedPastYear.UseVisualStyleBackColor = false;
    this.rbCreatedPastMonth.BackColor = Color.Transparent;
    this.rbCreatedPastMonth.FlatStyle = FlatStyle.Flat;
    this.rbCreatedPastMonth.Location = new Point(8, 36);
    this.rbCreatedPastMonth.Name = "rbCreatedPastMonth";
    this.rbCreatedPastMonth.Size = new Size(184, 24);
    this.rbCreatedPastMonth.TabIndex = 4;
    this.rbCreatedPastMonth.Text = "Past month";
    this.rbCreatedPastMonth.UseVisualStyleBackColor = false;
    this.rbCreatedLastWeek.BackColor = Color.Transparent;
    this.rbCreatedLastWeek.FlatStyle = FlatStyle.Flat;
    this.rbCreatedLastWeek.Location = new Point(8, 18);
    this.rbCreatedLastWeek.Name = "rbCreatedLastWeek";
    this.rbCreatedLastWeek.Size = new Size(184, 24);
    this.rbCreatedLastWeek.TabIndex = 3;
    this.rbCreatedLastWeek.Text = "Within the last week";
    this.rbCreatedLastWeek.UseVisualStyleBackColor = false;
    this.rbCreatedDontRemember.BackColor = Color.Transparent;
    this.rbCreatedDontRemember.Checked = true;
    this.rbCreatedDontRemember.FlatStyle = FlatStyle.Flat;
    this.rbCreatedDontRemember.Location = new Point(8, 0);
    this.rbCreatedDontRemember.Name = "rbCreatedDontRemember";
    this.rbCreatedDontRemember.Size = new Size(184, 24);
    this.rbCreatedDontRemember.TabIndex = 2;
    this.rbCreatedDontRemember.TabStop = true;
    this.rbCreatedDontRemember.Text = "Don't Remember";
    this.rbCreatedDontRemember.UseVisualStyleBackColor = false;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label11.Location = new Point(24, 88);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(0, 13);
    this.Label11.TabIndex = 14;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label12.Location = new Point(32 /*0x20*/, 104);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(0, 13);
    this.Label12.TabIndex = 15;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label13.Location = new Point(8, 8);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size((int) sbyte.MaxValue, 16 /*0x10*/);
    this.Label13.TabIndex = 31 /*0x1F*/;
    this.Label13.Text = "When was it created?";
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label2);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Panel2);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(294, 261);
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(8, 8);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(120, 13);
    this.Label2.TabIndex = 33;
    this.Label2.Text = "When was it edited?";
    this.Panel2.BackColor = Color.Transparent;
    this.Panel2.Controls.Add((Control) this.Label17);
    this.Panel2.Controls.Add((Control) this.Label18);
    this.Panel2.Controls.Add((Control) this.dtModifiedTo);
    this.Panel2.Controls.Add((Control) this.dtModifiedFrom);
    this.Panel2.Controls.Add((Control) this.rbModifiedSpecify);
    this.Panel2.Controls.Add((Control) this.rbModifiedPastYear);
    this.Panel2.Controls.Add((Control) this.rbModifiedPastMonth);
    this.Panel2.Controls.Add((Control) this.rbModifiedLastWeek);
    this.Panel2.Controls.Add((Control) this.rbModifiedDontRemember);
    this.Panel2.Controls.Add((Control) this.Label8);
    this.Panel2.Controls.Add((Control) this.Label9);
    this.Panel2.Location = new Point(8, 24);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(232, 152);
    this.Panel2.TabIndex = 34;
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label17.Location = new Point(24, 96 /*0x60*/);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(29, 13);
    this.Label17.TabIndex = 16 /*0x10*/;
    this.Label17.Text = "from";
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label18.Location = new Point(32 /*0x20*/, 120);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(17, 13);
    this.Label18.TabIndex = 17;
    this.Label18.Text = "to";
    appearance5.BorderColor = Color.Gray;
    this.dtModifiedTo.Appearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.LightGray;
    appearance6.BackColor2 = Color.White;
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.LightGray;
    appearance6.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtModifiedTo.ButtonAppearance = (AppearanceBase) appearance6;
    this.dtModifiedTo.DateTime = new DateTime(2004, 9, 2, 10, 5, 33, 683);
    ((Control) this.dtModifiedTo).Enabled = false;
    ((Control) this.dtModifiedTo).Location = new Point(56, 120);
    ((Control) this.dtModifiedTo).Name = "dtModifiedTo";
    ((Control) this.dtModifiedTo).Size = new Size(104, 20);
    ((Control) this.dtModifiedTo).TabIndex = 9;
    ((UltraControlBase) this.dtModifiedTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtModifiedTo).UseOsThemes = (DefaultableBoolean) 2;
    this.dtModifiedTo.Value = (object) new DateTime(2004, 9, 2, 10, 5, 33, 683);
    appearance7.BorderColor = Color.Gray;
    this.dtModifiedFrom.Appearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.LightGray;
    appearance8.BackColor2 = Color.White;
    appearance8.BackGradientStyle = (GradientStyle) 2;
    appearance8.BorderColor = Color.LightGray;
    appearance8.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtModifiedFrom.ButtonAppearance = (AppearanceBase) appearance8;
    this.dtModifiedFrom.DateTime = new DateTime(2004, 9, 2, 10, 5, 33, 730);
    ((Control) this.dtModifiedFrom).Enabled = false;
    ((Control) this.dtModifiedFrom).Location = new Point(56, 96 /*0x60*/);
    ((Control) this.dtModifiedFrom).Name = "dtModifiedFrom";
    ((Control) this.dtModifiedFrom).Size = new Size(104, 20);
    ((Control) this.dtModifiedFrom).TabIndex = 8;
    ((UltraControlBase) this.dtModifiedFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtModifiedFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.dtModifiedFrom.Value = (object) new DateTime(2004, 9, 2, 10, 5, 33, 730);
    this.rbModifiedSpecify.BackColor = Color.Transparent;
    this.rbModifiedSpecify.FlatStyle = FlatStyle.Flat;
    this.rbModifiedSpecify.Location = new Point(8, 72);
    this.rbModifiedSpecify.Name = "rbModifiedSpecify";
    this.rbModifiedSpecify.Size = new Size(184, 24);
    this.rbModifiedSpecify.TabIndex = 6;
    this.rbModifiedSpecify.Text = "Specify dates";
    this.rbModifiedSpecify.UseVisualStyleBackColor = false;
    this.rbModifiedPastYear.BackColor = Color.Transparent;
    this.rbModifiedPastYear.FlatStyle = FlatStyle.Flat;
    this.rbModifiedPastYear.Location = new Point(8, 54);
    this.rbModifiedPastYear.Name = "rbModifiedPastYear";
    this.rbModifiedPastYear.Size = new Size(184, 24);
    this.rbModifiedPastYear.TabIndex = 5;
    this.rbModifiedPastYear.Text = "Within the past year";
    this.rbModifiedPastYear.UseVisualStyleBackColor = false;
    this.rbModifiedPastMonth.BackColor = Color.Transparent;
    this.rbModifiedPastMonth.FlatStyle = FlatStyle.Flat;
    this.rbModifiedPastMonth.Location = new Point(8, 36);
    this.rbModifiedPastMonth.Name = "rbModifiedPastMonth";
    this.rbModifiedPastMonth.Size = new Size(184, 24);
    this.rbModifiedPastMonth.TabIndex = 4;
    this.rbModifiedPastMonth.Text = "Past month";
    this.rbModifiedPastMonth.UseVisualStyleBackColor = false;
    this.rbModifiedLastWeek.BackColor = Color.Transparent;
    this.rbModifiedLastWeek.FlatStyle = FlatStyle.Flat;
    this.rbModifiedLastWeek.Location = new Point(8, 18);
    this.rbModifiedLastWeek.Name = "rbModifiedLastWeek";
    this.rbModifiedLastWeek.Size = new Size(184, 24);
    this.rbModifiedLastWeek.TabIndex = 3;
    this.rbModifiedLastWeek.Text = "Within the last week";
    this.rbModifiedLastWeek.UseVisualStyleBackColor = false;
    this.rbModifiedDontRemember.BackColor = Color.Transparent;
    this.rbModifiedDontRemember.Checked = true;
    this.rbModifiedDontRemember.FlatStyle = FlatStyle.Flat;
    this.rbModifiedDontRemember.Location = new Point(8, 0);
    this.rbModifiedDontRemember.Name = "rbModifiedDontRemember";
    this.rbModifiedDontRemember.Size = new Size(184, 24);
    this.rbModifiedDontRemember.TabIndex = 2;
    this.rbModifiedDontRemember.TabStop = true;
    this.rbModifiedDontRemember.Text = "Don't Remember";
    this.rbModifiedDontRemember.UseVisualStyleBackColor = false;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label8.Location = new Point(24, 96 /*0x60*/);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(0, 13);
    this.Label8.TabIndex = 14;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label9.Location = new Point(32 /*0x20*/, 120);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(0, 13);
    this.Label9.TabIndex = 15;
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label21);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.cboEntryAssignedTo);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label20);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.cboEntryCreatedBy);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(294, 261);
    this.Label21.AutoSize = true;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label21.Location = new Point(8, 56);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(67, 13);
    this.Label21.TabIndex = 53;
    this.Label21.Text = "Assigned to:";
    ((UltraGridBase) this.cboEntryAssignedTo).DataSource = (object) this.vwAssignedTo;
    ((UltraDropDownBase) this.cboEntryAssignedTo).DisplayMember = "fullname";
    this.cboEntryAssignedTo.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboEntryAssignedTo).Location = new Point(8, 74);
    ((Control) this.cboEntryAssignedTo).Name = "cboEntryAssignedTo";
    ((Control) this.cboEntryAssignedTo).Size = new Size(120, 21);
    ((Control) this.cboEntryAssignedTo).TabIndex = 52;
    ((UltraControlBase) this.cboEntryAssignedTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboEntryAssignedTo).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboEntryAssignedTo).ValueMember = "UserGUID";
    this.vwAssignedTo.Table = (DataTable) this.DsTabNoteSearch.tblUsers;
    this.DsTabNoteSearch.DataSetName = "dsTabNoteSearch";
    this.DsTabNoteSearch.Locale = new CultureInfo("en-US");
    this.DsTabNoteSearch.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label20.AutoSize = true;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label20.Location = new Point(8, 8);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(65, 13);
    this.Label20.TabIndex = 51;
    this.Label20.Text = "Created By:";
    ((UltraGridBase) this.cboEntryCreatedBy).DataSource = (object) this.vwCreatedBy;
    ((UltraDropDownBase) this.cboEntryCreatedBy).DisplayMember = "fullname";
    this.cboEntryCreatedBy.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboEntryCreatedBy).Location = new Point(8, 26);
    ((Control) this.cboEntryCreatedBy).Name = "cboEntryCreatedBy";
    ((Control) this.cboEntryCreatedBy).Size = new Size(120, 21);
    ((Control) this.cboEntryCreatedBy).TabIndex = 50;
    ((UltraControlBase) this.cboEntryCreatedBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboEntryCreatedBy).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboEntryCreatedBy).ValueMember = "UserGUID";
    this.vwCreatedBy.Table = (DataTable) this.DsTabNoteSearch.tblUsers;
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Panel5);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Label26);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Label25);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.Panel4);
    ((Control) this.UltraTabPageControl4).Location = new Point(1, 24);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(294, 261);
    this.Panel5.Controls.Add((Control) this.rbDiaryStatusNotCompleted);
    this.Panel5.Controls.Add((Control) this.rbDiaryStatusCompleted);
    this.Panel5.Controls.Add((Control) this.rbDiaryStatusDontRemember);
    this.Panel5.Location = new Point(8, 192 /*0xC0*/);
    this.Panel5.Name = "Panel5";
    this.Panel5.Size = new Size(280, 64 /*0x40*/);
    this.Panel5.TabIndex = 36;
    this.rbDiaryStatusNotCompleted.BackColor = Color.Transparent;
    this.rbDiaryStatusNotCompleted.FlatStyle = FlatStyle.Flat;
    this.rbDiaryStatusNotCompleted.Location = new Point(8, 36);
    this.rbDiaryStatusNotCompleted.Name = "rbDiaryStatusNotCompleted";
    this.rbDiaryStatusNotCompleted.Size = new Size(110, 24);
    this.rbDiaryStatusNotCompleted.TabIndex = 8;
    this.rbDiaryStatusNotCompleted.Text = "Not Completed";
    this.rbDiaryStatusNotCompleted.UseVisualStyleBackColor = false;
    this.rbDiaryStatusCompleted.BackColor = Color.Transparent;
    this.rbDiaryStatusCompleted.FlatStyle = FlatStyle.Flat;
    this.rbDiaryStatusCompleted.Location = new Point(8, 18);
    this.rbDiaryStatusCompleted.Name = "rbDiaryStatusCompleted";
    this.rbDiaryStatusCompleted.Size = new Size(103, 24);
    this.rbDiaryStatusCompleted.TabIndex = 7;
    this.rbDiaryStatusCompleted.Text = "Completed";
    this.rbDiaryStatusCompleted.UseVisualStyleBackColor = false;
    this.rbDiaryStatusDontRemember.BackColor = Color.Transparent;
    this.rbDiaryStatusDontRemember.Checked = true;
    this.rbDiaryStatusDontRemember.FlatStyle = FlatStyle.Flat;
    this.rbDiaryStatusDontRemember.Location = new Point(8, 0);
    this.rbDiaryStatusDontRemember.Name = "rbDiaryStatusDontRemember";
    this.rbDiaryStatusDontRemember.Size = new Size(110, 24);
    this.rbDiaryStatusDontRemember.TabIndex = 6;
    this.rbDiaryStatusDontRemember.TabStop = true;
    this.rbDiaryStatusDontRemember.Text = "Don't Remember";
    this.rbDiaryStatusDontRemember.UseVisualStyleBackColor = false;
    this.Label26.AutoSize = true;
    this.Label26.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label26.Location = new Point(8, 176 /*0xB0*/);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(80 /*0x50*/, 13);
    this.Label26.TabIndex = 35;
    this.Label26.Text = "Diary Status:";
    this.Label25.AutoSize = true;
    this.Label25.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label25.Location = new Point(8, 8);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(89, 13);
    this.Label25.TabIndex = 34;
    this.Label25.Text = "When is it due:";
    this.Panel4.BackColor = Color.Transparent;
    this.Panel4.Controls.Add((Control) this.Label19);
    this.Panel4.Controls.Add((Control) this.Label22);
    this.Panel4.Controls.Add((Control) this.dtDiaryTo);
    this.Panel4.Controls.Add((Control) this.dtDiaryFrom);
    this.Panel4.Controls.Add((Control) this.rbDiaryDates);
    this.Panel4.Controls.Add((Control) this.rbDiaryWithinLastYear);
    this.Panel4.Controls.Add((Control) this.rbDiaryPastMonth);
    this.Panel4.Controls.Add((Control) this.rbDiaryLastWeek);
    this.Panel4.Controls.Add((Control) this.rbDiaryDontRemember);
    this.Panel4.Controls.Add((Control) this.Label23);
    this.Panel4.Controls.Add((Control) this.Label24);
    this.Panel4.Location = new Point(8, 24);
    this.Panel4.Name = "Panel4";
    this.Panel4.Size = new Size(280, 152);
    this.Panel4.TabIndex = 33;
    this.Label19.AutoSize = true;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label19.Location = new Point(24, 96 /*0x60*/);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(29, 13);
    this.Label19.TabIndex = 16 /*0x10*/;
    this.Label19.Text = "from";
    this.Label22.AutoSize = true;
    this.Label22.BackColor = Color.Transparent;
    this.Label22.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label22.Location = new Point(32 /*0x20*/, 120);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(17, 13);
    this.Label22.TabIndex = 17;
    this.Label22.Text = "to";
    appearance9.BorderColor = Color.Gray;
    this.dtDiaryTo.Appearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.LightGray;
    appearance10.BackColor2 = Color.White;
    appearance10.BackGradientStyle = (GradientStyle) 2;
    appearance10.BorderColor = Color.LightGray;
    appearance10.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtDiaryTo.ButtonAppearance = (AppearanceBase) appearance10;
    this.dtDiaryTo.DateTime = new DateTime(2004, 9, 2, 10, 5, 33, 683);
    ((Control) this.dtDiaryTo).Enabled = false;
    ((Control) this.dtDiaryTo).Location = new Point(56, 120);
    ((Control) this.dtDiaryTo).Name = "dtDiaryTo";
    ((Control) this.dtDiaryTo).Size = new Size(104, 20);
    ((Control) this.dtDiaryTo).TabIndex = 9;
    ((UltraControlBase) this.dtDiaryTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtDiaryTo).UseOsThemes = (DefaultableBoolean) 2;
    this.dtDiaryTo.Value = (object) new DateTime(2004, 9, 2, 10, 5, 33, 683);
    appearance11.BorderColor = Color.Gray;
    this.dtDiaryFrom.Appearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.LightGray;
    appearance12.BackColor2 = Color.White;
    appearance12.BackGradientStyle = (GradientStyle) 2;
    appearance12.BorderColor = Color.LightGray;
    appearance12.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtDiaryFrom.ButtonAppearance = (AppearanceBase) appearance12;
    this.dtDiaryFrom.DateTime = new DateTime(2004, 9, 2, 10, 5, 33, 730);
    ((Control) this.dtDiaryFrom).Enabled = false;
    ((Control) this.dtDiaryFrom).Location = new Point(56, 96 /*0x60*/);
    ((Control) this.dtDiaryFrom).Name = "dtDiaryFrom";
    ((Control) this.dtDiaryFrom).Size = new Size(104, 20);
    ((Control) this.dtDiaryFrom).TabIndex = 8;
    ((UltraControlBase) this.dtDiaryFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtDiaryFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.dtDiaryFrom.Value = (object) new DateTime(2004, 9, 2, 10, 5, 33, 730);
    this.rbDiaryDates.BackColor = Color.Transparent;
    this.rbDiaryDates.FlatStyle = FlatStyle.Flat;
    this.rbDiaryDates.Location = new Point(8, 72);
    this.rbDiaryDates.Name = "rbDiaryDates";
    this.rbDiaryDates.Size = new Size(184, 24);
    this.rbDiaryDates.TabIndex = 6;
    this.rbDiaryDates.Text = "Specify dates";
    this.rbDiaryDates.UseVisualStyleBackColor = false;
    this.rbDiaryWithinLastYear.BackColor = Color.Transparent;
    this.rbDiaryWithinLastYear.FlatStyle = FlatStyle.Flat;
    this.rbDiaryWithinLastYear.Location = new Point(8, 54);
    this.rbDiaryWithinLastYear.Name = "rbDiaryWithinLastYear";
    this.rbDiaryWithinLastYear.Size = new Size(184, 24);
    this.rbDiaryWithinLastYear.TabIndex = 5;
    this.rbDiaryWithinLastYear.Text = "Within the past year";
    this.rbDiaryWithinLastYear.UseVisualStyleBackColor = false;
    this.rbDiaryPastMonth.BackColor = Color.Transparent;
    this.rbDiaryPastMonth.FlatStyle = FlatStyle.Flat;
    this.rbDiaryPastMonth.Location = new Point(8, 36);
    this.rbDiaryPastMonth.Name = "rbDiaryPastMonth";
    this.rbDiaryPastMonth.Size = new Size(184, 24);
    this.rbDiaryPastMonth.TabIndex = 4;
    this.rbDiaryPastMonth.Text = "Past month";
    this.rbDiaryPastMonth.UseVisualStyleBackColor = false;
    this.rbDiaryLastWeek.BackColor = Color.Transparent;
    this.rbDiaryLastWeek.FlatStyle = FlatStyle.Flat;
    this.rbDiaryLastWeek.Location = new Point(8, 18);
    this.rbDiaryLastWeek.Name = "rbDiaryLastWeek";
    this.rbDiaryLastWeek.Size = new Size(184, 24);
    this.rbDiaryLastWeek.TabIndex = 3;
    this.rbDiaryLastWeek.Text = "Within the last week";
    this.rbDiaryLastWeek.UseVisualStyleBackColor = false;
    this.rbDiaryDontRemember.BackColor = Color.Transparent;
    this.rbDiaryDontRemember.Checked = true;
    this.rbDiaryDontRemember.FlatStyle = FlatStyle.Flat;
    this.rbDiaryDontRemember.Location = new Point(8, 0);
    this.rbDiaryDontRemember.Name = "rbDiaryDontRemember";
    this.rbDiaryDontRemember.Size = new Size(184, 24);
    this.rbDiaryDontRemember.TabIndex = 2;
    this.rbDiaryDontRemember.TabStop = true;
    this.rbDiaryDontRemember.Text = "Don't Remember";
    this.rbDiaryDontRemember.UseVisualStyleBackColor = false;
    this.Label23.AutoSize = true;
    this.Label23.BackColor = Color.Transparent;
    this.Label23.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label23.Location = new Point(24, 88);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(0, 13);
    this.Label23.TabIndex = 14;
    this.Label24.AutoSize = true;
    this.Label24.BackColor = Color.Transparent;
    this.Label24.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label24.Location = new Point(32 /*0x20*/, 104);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(0, 13);
    this.Label24.TabIndex = 15;
    this.vwUsers.Table = (DataTable) this.DsTabNoteSearch.tblUsers;
    this.daNoteTypes.SelectCommand = this.SqlSelectCommand1;
    this.daNoteTypes.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstNoteTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("NoteTypeID", "NoteTypeID"),
        new DataColumnMapping("Description", "Description")
      })
    });
    this.SqlSelectCommand1.CommandText = "SELECT NoteTypeID, Description FROM lstNoteTypes ORDER BY Description ASC";
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.cnSQL.ConnectionString = "workstation id=DOMENIC;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.daUsers.SelectCommand = this.SqlSelectCommand2;
    this.daUsers.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUsers", new DataColumnMapping[2]
      {
        new DataColumnMapping("UserGUID", "UserGUID"),
        new DataColumnMapping("fullname", "fullname")
      })
    });
    this.SqlSelectCommand2.CommandText = "SELECT UserGUID, LastName + ', ' + FirstName AS fullname FROM tblUsers ORDER BY FullName ASC";
    this.SqlSelectCommand2.Connection = this.cnSQL;
    this.daAssociationTypes.SelectCommand = this.SqlSelectCommand3;
    this.daAssociationTypes.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblNoteEntityTypes", new DataColumnMapping[1]
      {
        new DataColumnMapping("EntityFormName", "EntityFormName")
      })
    });
    this.SqlSelectCommand3.CommandText = "SELECT DISTINCT EntityFormName FROM tblNoteEntities ORDER BY EntityFormName";
    this.SqlSelectCommand3.Connection = this.cnSQL;
    this.daEntities.SelectCommand = this.SqlSelectCommand4;
    this.daEntities.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblNoteEntities", new DataColumnMapping[1]
      {
        new DataColumnMapping("EntityName", "EntityName")
      })
    });
    this.SqlSelectCommand4.CommandText = "SELECT DISTINCT EntityName FROM tblNoteEntities ORDER BY EntityName";
    this.SqlSelectCommand4.Connection = this.cnSQL;
    this.Panel1.BackColor = Color.Transparent;
    this.Panel1.Controls.Add((Control) this.chkCompletedDt);
    this.Panel1.Controls.Add((Control) this.Label29);
    this.Panel1.Controls.Add((Control) this.dtCompletedto);
    this.Panel1.Controls.Add((Control) this.dtCompletedFrom);
    this.Panel1.Controls.Add((Control) this.Label30);
    this.Panel1.Controls.Add((Control) this.Label27);
    this.Panel1.Controls.Add((Control) this.cboCompletedBy);
    this.Panel1.Controls.Add((Control) this.MgaTab1);
    this.Panel1.Controls.Add((Control) this.Label4);
    this.Panel1.Controls.Add((Control) this.cboAssociationName);
    this.Panel1.Controls.Add((Control) this.Label3);
    this.Panel1.Controls.Add((Control) this.cboAssociatedToEntityType);
    this.Panel1.Controls.Add((Control) this.btnReset);
    this.Panel1.Controls.Add((Control) this.Label1);
    this.Panel1.Controls.Add((Control) this.btnSearch);
    this.Panel1.Controls.Add((Control) this.Label15);
    this.Panel1.Controls.Add((Control) this.cboUserCreated);
    this.Panel1.Controls.Add((Control) this.Label16);
    this.Panel1.Controls.Add((Control) this.cboUsersModified);
    this.Panel1.Controls.Add((Control) this.Label5);
    this.Panel1.Controls.Add((Control) this.txtSubject);
    this.Panel1.Controls.Add((Control) this.Label14);
    this.Panel1.Controls.Add((Control) this.txtBody);
    this.Panel1.Controls.Add((Control) this.Label7);
    this.Panel1.Controls.Add((Control) this.cboNoteType);
    this.Panel1.Controls.Add((Control) this.chkDispResultsInNewWindow);
    this.Panel1.Controls.Add((Control) this.chkDisplayProgress);
    this.Panel1.Dock = DockStyle.Fill;
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(312, 600);
    this.Panel1.TabIndex = 3;
    appearance13.BorderColor = Color.Gray;
    appearance13.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCompletedDt).Appearance = (AppearanceBase) appearance13;
    ((UltraToggleEditorBase) this.chkCompletedDt).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCompletedDt).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCompletedDt).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCompletedDt).Location = new Point(13, 216);
    ((Control) this.chkCompletedDt).Name = "chkCompletedDt";
    ((Control) this.chkCompletedDt).Size = new Size(107, 17);
    ((Control) this.chkCompletedDt).TabIndex = 58;
    ((UltraToggleEditorBase) this.chkCompletedDt).Text = "Completed Date";
    this.Label29.AutoSize = true;
    this.Label29.BackColor = Color.Transparent;
    this.Label29.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label29.Location = new Point(208 /*0xD0*/, 217);
    this.Label29.Name = "Label29";
    this.Label29.Size = new Size(17, 13);
    this.Label29.TabIndex = 56;
    this.Label29.Text = "to";
    appearance14.BorderColor = Color.Gray;
    this.dtCompletedto.Appearance = (AppearanceBase) appearance14;
    appearance15.BackColor = Color.LightGray;
    appearance15.BackColor2 = Color.White;
    appearance15.BackGradientStyle = (GradientStyle) 2;
    appearance15.BorderColor = Color.LightGray;
    appearance15.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtCompletedto.ButtonAppearance = (AppearanceBase) appearance15;
    this.dtCompletedto.DateTime = new DateTime(2004, 9, 2, 10, 5, 33, 683);
    ((Control) this.dtCompletedto).Enabled = false;
    ((Control) this.dtCompletedto).Location = new Point(228, 212);
    ((Control) this.dtCompletedto).Name = "dtCompletedto";
    ((Control) this.dtCompletedto).Size = new Size(77, 20);
    ((Control) this.dtCompletedto).TabIndex = 53;
    ((UltraControlBase) this.dtCompletedto).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtCompletedto).UseOsThemes = (DefaultableBoolean) 2;
    this.dtCompletedto.Value = (object) new DateTime(2004, 9, 2, 10, 5, 33, 683);
    appearance16.BorderColor = Color.Gray;
    this.dtCompletedFrom.Appearance = (AppearanceBase) appearance16;
    appearance17.BackColor = Color.LightGray;
    appearance17.BackColor2 = Color.White;
    appearance17.BackGradientStyle = (GradientStyle) 2;
    appearance17.BorderColor = Color.LightGray;
    appearance17.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtCompletedFrom.ButtonAppearance = (AppearanceBase) appearance17;
    this.dtCompletedFrom.DateTime = new DateTime(2004, 9, 2, 10, 5, 33, 730);
    ((Control) this.dtCompletedFrom).Enabled = false;
    ((Control) this.dtCompletedFrom).Location = new Point(123, 213);
    ((Control) this.dtCompletedFrom).Name = "dtCompletedFrom";
    ((Control) this.dtCompletedFrom).Size = new Size(82, 20);
    ((Control) this.dtCompletedFrom).TabIndex = 52;
    ((UltraControlBase) this.dtCompletedFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtCompletedFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.dtCompletedFrom.Value = (object) new DateTime(2004, 9, 2, 10, 5, 33, 730);
    this.Label30.AutoSize = true;
    this.Label30.BackColor = Color.Transparent;
    this.Label30.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label30.Location = new Point(169, 189);
    this.Label30.Name = "Label30";
    this.Label30.Size = new Size(0, 13);
    this.Label30.TabIndex = 54;
    this.Label27.AutoSize = true;
    this.Label27.BackColor = Color.Transparent;
    this.Label27.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label27.Location = new Point(14, 189);
    this.Label27.Name = "Label27";
    this.Label27.Size = new Size(77, 13);
    this.Label27.TabIndex = 51;
    this.Label27.Text = "Completed By:";
    ((UltraGridBase) this.cboCompletedBy).DataSource = (object) this.DsTabNoteSearch.tblUsers;
    ((UltraDropDownBase) this.cboCompletedBy).DisplayMember = "fullname";
    this.cboCompletedBy.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboCompletedBy).Location = new Point(97, 186);
    ((Control) this.cboCompletedBy).Name = "cboCompletedBy";
    ((Control) this.cboCompletedBy).Size = new Size(208 /*0xD0*/, 21);
    ((Control) this.cboCompletedBy).TabIndex = 50;
    ((UltraControlBase) this.cboCompletedBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompletedBy).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompletedBy).ValueMember = "UserGUID";
    ((Control) this.MgaTab1).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance18.BackColor = Color.Gainsboro;
    ((UltraTabControlBase) this.MgaTab1).Appearance = (AppearanceBase) appearance18;
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl4);
    ((Control) this.MgaTab1).Location = new Point(8, 240 /*0xF0*/);
    ((Control) this.MgaTab1).Name = "MgaTab1";
    appearance19.BackColor = Color.WhiteSmoke;
    appearance19.BorderColor = Color.Gray;
    ((UltraTabControlBase) this.MgaTab1).SelectedTabAppearance = (AppearanceBase) appearance19;
    ((UltraTabControlBase) this.MgaTab1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.MgaTab1).Size = new Size(296, 286);
    ((UltraTabControlBase) this.MgaTab1).Style = (UltraTabControlStyle) 12;
    ((Control) this.MgaTab1).TabIndex = 49;
    ((UltraTabControlBase) this.MgaTab1).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.MgaTab1).TabPadding = new Size(10, 3);
    ultraTab1.Key = "CREATED";
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Created";
    ultraTab2.Key = "EDITED";
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Edited";
    ultraTab3.Key = "ENTRY";
    ultraTab3.TabPage = this.UltraTabPageControl3;
    ultraTab3.Text = "Entry";
    ultraTab4.Key = "DIARY";
    ultraTab4.TabPage = this.UltraTabPageControl4;
    ultraTab4.Text = "Diary";
    ((UltraTabControlBase) this.MgaTab1).Tabs.AddRange(new UltraTab[4]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4
    });
    ((UltraControlBase) this.MgaTab1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTab1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(294, 261);
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label4.Location = new Point(8, 136);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(94, 13);
    this.Label4.TabIndex = 48 /*0x30*/;
    this.Label4.Text = "Association name:";
    ((UltraGridBase) this.cboAssociationName).DataSource = (object) this.DsTabNoteSearch.tblNoteEntities;
    ((UltraDropDownBase) this.cboAssociationName).DisplayMember = "EntityName";
    this.cboAssociationName.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboAssociationName).Location = new Point(8, 154);
    ((Control) this.cboAssociationName).Name = "cboAssociationName";
    ((Control) this.cboAssociationName).Size = new Size(120, 21);
    ((Control) this.cboAssociationName).TabIndex = 47;
    ((UltraControlBase) this.cboAssociationName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboAssociationName).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboAssociationName).ValueMember = "EntityName";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(136, 136);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(92, 13);
    this.Label3.TabIndex = 46;
    this.Label3.Text = "Association Type:";
    ((Control) this.cboAssociatedToEntityType).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.cboAssociatedToEntityType).DataSource = (object) this.DsTabNoteSearch.tblNoteEntityTypes;
    ((UltraDropDownBase) this.cboAssociatedToEntityType).DisplayMember = "EntityFormName";
    this.cboAssociatedToEntityType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboAssociatedToEntityType).Location = new Point(136, 154);
    ((Control) this.cboAssociatedToEntityType).Name = "cboAssociatedToEntityType";
    ((Control) this.cboAssociatedToEntityType).Size = new Size(169, 21);
    ((Control) this.cboAssociatedToEntityType).TabIndex = 45;
    ((UltraControlBase) this.cboAssociatedToEntityType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboAssociatedToEntityType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboAssociatedToEntityType).ValueMember = "EntityFormName";
    ((Control) this.btnReset).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance20.BackColor = Color.FromArgb(248, 248, 248);
    appearance20.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance20.BackGradientStyle = (GradientStyle) 2;
    appearance20.BorderColor = Color.DarkGray;
    appearance20.ImageHAlign = (HAlign) 2;
    appearance20.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnReset).Appearance = (AppearanceBase) appearance20;
    ((Control) this.btnReset).Location = new Point(136, 568);
    ((Control) this.btnReset).Name = "btnReset";
    ((Control) this.btnReset).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnReset).TabIndex = 43;
    ((ControlBase) this.btnReset).Text = "Reset";
    this.btnReset.UseOSThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(8, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(237, 13);
    this.Label1.TabIndex = 27;
    this.Label1.Text = "Search by any or all of the criteria below.";
    ((Control) this.btnSearch).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance21.BackColor = Color.FromArgb(248, 248, 248);
    appearance21.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance21.BackGradientStyle = (GradientStyle) 2;
    appearance21.BorderColor = Color.DarkGray;
    appearance21.ImageHAlign = (HAlign) 2;
    appearance21.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance21;
    ((Control) this.btnSearch).Location = new Point(225, 568);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnSearch).TabIndex = 41;
    ((ControlBase) this.btnSearch).Text = "Search";
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label15.Location = new Point(8, 16 /*0x10*/);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(65, 13);
    this.Label15.TabIndex = 39;
    this.Label15.Text = "Created By:";
    ((UltraGridBase) this.cboUserCreated).DataSource = (object) this.DsTabNoteSearch.tblUsers;
    ((UltraDropDownBase) this.cboUserCreated).DisplayMember = "fullname";
    this.cboUserCreated.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboUserCreated).Location = new Point(8, 34);
    ((Control) this.cboUserCreated).Name = "cboUserCreated";
    ((Control) this.cboUserCreated).Size = new Size(120, 21);
    ((Control) this.cboUserCreated).TabIndex = 38;
    ((UltraControlBase) this.cboUserCreated).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUserCreated).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUserCreated).ValueMember = "UserGUID";
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label16.Location = new Point(136, 16 /*0x10*/);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(60, 16 /*0x10*/);
    this.Label16.TabIndex = 44;
    this.Label16.Text = "Edited By:";
    ((Control) this.cboUsersModified).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.cboUsersModified).DataSource = (object) this.vwUsers;
    ((UltraDropDownBase) this.cboUsersModified).DisplayMember = "fullname";
    this.cboUsersModified.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboUsersModified).Location = new Point(136, 34);
    ((Control) this.cboUsersModified).Name = "cboUsersModified";
    ((Control) this.cboUsersModified).Size = new Size(169, 21);
    ((Control) this.cboUsersModified).TabIndex = 42;
    ((UltraControlBase) this.cboUsersModified).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUsersModified).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUsersModified).ValueMember = "UserGUID";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label5.Location = new Point(8, 56);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(43, 13);
    this.Label5.TabIndex = 29;
    this.Label5.Text = "Subject";
    appearance22.BackColor = Color.White;
    appearance22.BorderColor = Color.Gray;
    appearance22.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSubject).Appearance = (AppearanceBase) appearance22;
    ((TextEditorControlBase) this.txtSubject).BackColor = Color.White;
    ((Control) this.txtSubject).Location = new Point(8, 74);
    ((Control) this.txtSubject).Name = "txtSubject";
    ((Control) this.txtSubject).Size = new Size(120, 20);
    ((Control) this.txtSubject).TabIndex = 26;
    ((UltraControlBase) this.txtSubject).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSubject).UseOsThemes = (DefaultableBoolean) 2;
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label14.Location = new Point(8, 96 /*0x60*/);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(31 /*0x1F*/, 13);
    this.Label14.TabIndex = 36;
    this.Label14.Text = "Body";
    ((Control) this.txtBody).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance23.BackColor = Color.White;
    appearance23.BorderColor = Color.Gray;
    appearance23.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtBody).Appearance = (AppearanceBase) appearance23;
    ((TextEditorControlBase) this.txtBody).BackColor = Color.White;
    ((Control) this.txtBody).Location = new Point(8, 114);
    ((Control) this.txtBody).Name = "txtBody";
    ((Control) this.txtBody).Size = new Size(298, 20);
    ((Control) this.txtBody).TabIndex = 35;
    ((UltraControlBase) this.txtBody).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtBody).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label7.Location = new Point(136, 56);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(73, 13);
    this.Label7.TabIndex = 30;
    this.Label7.Text = "Type of note:";
    ((Control) this.cboNoteType).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.cboNoteType).DataSource = (object) this.DsTabNoteSearch.lstNoteTypes;
    ((UltraDropDownBase) this.cboNoteType).DisplayMember = "Description";
    this.cboNoteType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboNoteType).Location = new Point(136, 74);
    ((Control) this.cboNoteType).Name = "cboNoteType";
    ((Control) this.cboNoteType).Size = new Size(168, 21);
    ((Control) this.cboNoteType).TabIndex = 28;
    ((UltraControlBase) this.cboNoteType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboNoteType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboNoteType).ValueMember = "NoteTypeID";
    appearance24.BorderColor = Color.Gray;
    appearance24.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDispResultsInNewWindow).Appearance = (AppearanceBase) appearance24;
    ((UltraToggleEditorBase) this.chkDispResultsInNewWindow).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDispResultsInNewWindow).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDispResultsInNewWindow).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDispResultsInNewWindow).Location = new Point(8, 548);
    ((Control) this.chkDispResultsInNewWindow).Name = "chkDispResultsInNewWindow";
    ((Control) this.chkDispResultsInNewWindow).Size = new Size(216, 16 /*0x10*/);
    ((Control) this.chkDispResultsInNewWindow).TabIndex = 37;
    ((UltraToggleEditorBase) this.chkDispResultsInNewWindow).Text = "Display results in new window.";
    appearance25.BorderColor = Color.Gray;
    appearance25.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDisplayProgress).Appearance = (AppearanceBase) appearance25;
    ((UltraToggleEditorBase) this.chkDisplayProgress).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDisplayProgress).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDisplayProgress).Checked = true;
    ((UltraToggleEditorBase) this.chkDisplayProgress).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkDisplayProgress).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDisplayProgress).Location = new Point(8, 532);
    ((Control) this.chkDisplayProgress).Name = "chkDisplayProgress";
    ((Control) this.chkDisplayProgress).Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    ((Control) this.chkDisplayProgress).TabIndex = 40;
    ((UltraToggleEditorBase) this.chkDisplayProgress).Text = "Display Progress";
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.Panel1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (TabNoteSearch);
    this.Size = new Size(312, 600);
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    this.Panel3.ResumeLayout(false);
    this.Panel3.PerformLayout();
    ((ISupportInitialize) this.dtCreatedTo).EndInit();
    ((ISupportInitialize) this.dtCreatedFrom).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    ((ISupportInitialize) this.dtModifiedTo).EndInit();
    ((ISupportInitialize) this.dtModifiedFrom).EndInit();
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((Control) this.UltraTabPageControl3).PerformLayout();
    ((ISupportInitialize) this.cboEntryAssignedTo).EndInit();
    this.vwAssignedTo.EndInit();
    this.DsTabNoteSearch.EndInit();
    ((ISupportInitialize) this.cboEntryCreatedBy).EndInit();
    this.vwCreatedBy.EndInit();
    ((Control) this.UltraTabPageControl4).ResumeLayout(false);
    ((Control) this.UltraTabPageControl4).PerformLayout();
    this.Panel5.ResumeLayout(false);
    this.Panel4.ResumeLayout(false);
    this.Panel4.PerformLayout();
    ((ISupportInitialize) this.dtDiaryTo).EndInit();
    ((ISupportInitialize) this.dtDiaryFrom).EndInit();
    this.vwUsers.EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    ((ISupportInitialize) this.chkCompletedDt).EndInit();
    ((ISupportInitialize) this.dtCompletedto).EndInit();
    ((ISupportInitialize) this.dtCompletedFrom).EndInit();
    ((ISupportInitialize) this.cboCompletedBy).EndInit();
    ((ISupportInitialize) this.MgaTab1).EndInit();
    ((Control) this.MgaTab1).ResumeLayout(false);
    ((ISupportInitialize) this.cboAssociationName).EndInit();
    ((ISupportInitialize) this.cboAssociatedToEntityType).EndInit();
    ((ISupportInitialize) this.btnReset).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.cboUserCreated).EndInit();
    ((ISupportInitialize) this.cboUsersModified).EndInit();
    ((ISupportInitialize) this.txtSubject).EndInit();
    ((ISupportInitialize) this.txtBody).EndInit();
    ((ISupportInitialize) this.cboNoteType).EndInit();
    ((ISupportInitialize) this.chkDispResultsInNewWindow).EndInit();
    ((ISupportInitialize) this.chkDisplayProgress).EndInit();
    this.ResumeLayout(false);
  }

  public void InitializeOnSplashLoad()
  {
  }

  void IMdiActivationListener.MDIChildActivating(Form mdiChild)
  {
  }

  void IMdiActivationListener.MDIChildDeActivate(Form mdiChild)
  {
  }

  public void AfterLogon()
  {
  }

  public void BeforeLogOut()
  {
  }

  public DockWindowCreationInfo CreationInfo
  {
    get
    {
      return new DockWindowCreationInfo(false, "TabNoteSearchPanel", "Note Search", (DockedLocation) 1, "LeftGroupKey", ImageCache.Instance.Search, true);
    }
  }

  private event EventHandler checkedChanged;

  public TabNoteSearch()
  {
    this.DelayLoad += new EventHandler(this.TabNoteSearch_DelayLoad);
    this.Load += new EventHandler(this.TabNoteSearch_Load);
    this.InitializeComponent();
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
  }

  private void TabNoteSearch_DelayLoad(object sender, EventArgs e)
  {
    this._cboUserCreated_displayMember = ((UltraDropDownBase) this.cboUserCreated).DisplayMember;
    this._cboUserCreated_valueMember = ((UltraDropDownBase) this.cboUserCreated).ValueMember;
    this._cboNoteTypes_displayMember = ((UltraDropDownBase) this.cboNoteType).DisplayMember;
    this._cboNoteTypes_valueMember = ((UltraDropDownBase) this.cboNoteType).ValueMember;
    this._cboAssociatedType_displayMember = ((UltraDropDownBase) this.cboAssociatedToEntityType).DisplayMember;
    this._cboAssociatedType_valueMember = ((UltraDropDownBase) this.cboAssociatedToEntityType).ValueMember;
    this._cboAssociatedEntity_displayMember = ((UltraDropDownBase) this.cboAssociationName).DisplayMember;
    this._cboAssociatedEntity_valueMember = ((UltraDropDownBase) this.cboAssociationName).ValueMember;
    this._ShowDueDate = SystemSettings.GetSetting<bool>("Notes.Search.Result.ShowDueDate", false);
    this._showAssociatedEntity = SystemSettings.GetSetting<bool>("Notes.Search.Result.showAssociatedEntity", false);
    this.rbDiaryStatusCompleted.CheckedChanged += new EventHandler(this.rbDiaryStatusCompleted_CheckedChanged);
    this.ResetForm();
  }

  private void ResetForm()
  {
    if (((Control) this.cboAssociatedToEntityType).Enabled)
    {
      ((Control) this.cboAssociatedToEntityType).Enabled = false;
      ((UltraGridBase) this.cboAssociatedToEntityType).DataSource = (object) null;
      this.DsTabNoteSearch.tblNoteEntityTypes.Clear();
      this.cboAssociatedToEntityType.Text = "Loading";
      Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "AssociationType", this.daAssociationTypes, new TableQueryMultithreadEventHandler(this.TableFilled), (DataTable) this.DsTabNoteSearch.tblNoteEntityTypes);
    }
    if (((Control) this.cboUserCreated).Enabled && ((Control) this.cboUsersModified).Enabled)
    {
      ((Control) this.cboUserCreated).Enabled = false;
      ((UltraGridBase) this.cboUserCreated).DataSource = (object) null;
      this.cboUserCreated.Text = "Loading";
      ((Control) this.cboUsersModified).Enabled = false;
      ((UltraGridBase) this.cboUsersModified).DataSource = (object) null;
      this.DsTabNoteSearch.tblUsers.Clear();
      this.cboUsersModified.Text = "Loading";
      Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "Users", this.daUsers, new TableQueryMultithreadEventHandler(this.TableFilled), (DataTable) this.DsTabNoteSearch.tblUsers);
    }
    if (((Control) this.cboNoteType).Enabled)
    {
      ((Control) this.cboNoteType).Enabled = false;
      ((UltraGridBase) this.cboNoteType).DataSource = (object) null;
      this.DsTabNoteSearch.lstNoteTypes.Clear();
      this.cboNoteType.Text = "Loading";
      Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "NoteTypes", this.daNoteTypes, new TableQueryMultithreadEventHandler(this.TableFilled), (DataTable) this.DsTabNoteSearch.lstNoteTypes);
    }
    if (((Control) this.cboAssociationName).Enabled)
    {
      ((Control) this.cboAssociationName).Enabled = false;
      ((UltraGridBase) this.cboAssociationName).DataSource = (object) null;
      this.DsTabNoteSearch.tblNoteEntities.Clear();
      this.cboAssociationName.Text = "Loading";
      Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "AssociationName", this.daEntities, new TableQueryMultithreadEventHandler(this.TableFilled), (DataTable) this.DsTabNoteSearch.tblNoteEntities);
    }
    this.rbDiaryDontRemember.Checked = true;
    this.cboEntryAssignedTo.Value = (object) null;
    this.cboEntryCreatedBy.Value = (object) null;
    ((TextEditorControlBase) this.txtBody).Text = "";
    ((TextEditorControlBase) this.txtSubject).Text = "";
    this.rbDiaryStatusDontRemember.Checked = true;
    this.rbCreatedDontRemember.Checked = true;
    this.rbModifiedDontRemember.Checked = true;
  }

  private void TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(e.Key), "Users", false) == 0)
    {
      this.DsTabNoteSearch.tblUsers.AddtblUsersRow(Guid.Empty, "");
      MGASimpleComboBox cboUserCreated = this.cboUserCreated;
      ((UltraGridBase) cboUserCreated).DataSource = (object) this.DsTabNoteSearch.tblUsers;
      ((UltraDropDownBase) cboUserCreated).DisplayMember = this._cboUserCreated_displayMember;
      ((UltraDropDownBase) cboUserCreated).ValueMember = this._cboUserCreated_valueMember;
      cboUserCreated.Text = string.Empty;
      ((Control) cboUserCreated).Enabled = true;
      MGASimpleComboBox cboUsersModified = this.cboUsersModified;
      ((UltraGridBase) cboUsersModified).DataSource = (object) this.vwUsers;
      ((UltraDropDownBase) cboUsersModified).DisplayMember = this._cboUserCreated_displayMember;
      ((UltraDropDownBase) cboUsersModified).ValueMember = this._cboUserCreated_valueMember;
      cboUsersModified.Text = string.Empty;
      ((Control) cboUsersModified).Enabled = true;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(e.Key), "NoteTypes", false) == 0)
    {
      this.DsTabNoteSearch.lstNoteTypes.AddlstNoteTypesRow("");
      MGASimpleComboBox cboNoteType = this.cboNoteType;
      ((UltraGridBase) cboNoteType).DataSource = (object) this.DsTabNoteSearch.lstNoteTypes;
      ((UltraDropDownBase) cboNoteType).DisplayMember = this._cboNoteTypes_displayMember;
      ((UltraDropDownBase) cboNoteType).ValueMember = this._cboNoteTypes_valueMember;
      cboNoteType.Text = string.Empty;
      ((Control) cboNoteType).Enabled = true;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(e.Key), "AssociationType", false) == 0)
    {
      this.DsTabNoteSearch.tblNoteEntityTypes.AddtblNoteEntityTypesRow(string.Empty);
      MGASimpleComboBox associatedToEntityType = this.cboAssociatedToEntityType;
      ((UltraGridBase) associatedToEntityType).DataSource = (object) e.Table;
      ((UltraDropDownBase) associatedToEntityType).DisplayMember = this._cboAssociatedType_displayMember;
      ((UltraDropDownBase) associatedToEntityType).ValueMember = this._cboAssociatedType_valueMember;
      associatedToEntityType.Text = string.Empty;
      ((Control) associatedToEntityType).Enabled = true;
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(e.Key), "AssociationName", false) != 0)
        return;
      this.DsTabNoteSearch.tblNoteEntities.AddtblNoteEntitiesRow(string.Empty);
      MGASimpleComboBox cboAssociationName = this.cboAssociationName;
      ((UltraGridBase) cboAssociationName).DataSource = (object) e.Table;
      ((UltraDropDownBase) cboAssociationName).DisplayMember = this._cboAssociatedEntity_displayMember;
      ((UltraDropDownBase) cboAssociationName).ValueMember = this._cboAssociatedEntity_valueMember;
      cboAssociationName.Text = string.Empty;
      ((Control) cboAssociationName).Enabled = true;
    }
  }

  private void btnReset_Click(object sender, EventArgs e) => this.ResetForm();

  private void rbCreatedSpecify_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.dtCreatedFrom).Enabled = this.rbCreatedSpecify.Checked;
    ((Control) this.dtCreatedTo).Enabled = this.rbCreatedSpecify.Checked;
  }

  private void rbModifiedSpecify_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.dtModifiedFrom).Enabled = this.rbModifiedSpecify.Checked;
    ((Control) this.dtModifiedTo).Enabled = this.rbModifiedSpecify.Checked;
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    string whereClause = this.WHEREClause;
    frmNoteSearchResults noteSearchResults = !((UltraToggleEditorBase) this.chkDispResultsInNewWindow).Checked ? (frmNoteSearchResults) MDIControls.Instance.ActivateForm(typeof (frmNoteSearchResults), true) : (frmNoteSearchResults) FormSettings.ShowForm(typeof (frmNoteSearchResults));
    noteSearchResults.DoSearch($"{this.SELECTClause}{whereClause} ORDER BY tblNoteStore.CreatedDate ASC ", this.SELECTCountClause + whereClause, ((UltraToggleEditorBase) this.chkDisplayProgress).Checked);
    if (this.ShowCompletedColumns() & !this.cboCompletedBy.Value.Equals((object) Guid.Empty) || this.ShowCompletedColumns() & ((UltraToggleEditorBase) this.chkCompletedDt).Checked)
    {
      noteSearchResults.ColumnHeader2.Width = 120;
      noteSearchResults.ColumnHeader3.Width = 120;
      noteSearchResults.Width = 805;
    }
    else
    {
      noteSearchResults.ColumnHeader2.Width = 0;
      noteSearchResults.ColumnHeader3.Width = 0;
      noteSearchResults.Width = 540;
    }
    if (!this._ShowDueDate)
      noteSearchResults.DueDate.Width = 0;
    if (this._showAssociatedEntity)
      return;
    noteSearchResults.AssociatedEntity.Width = 0;
  }

  private string SELECTCountClause
  {
    get
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append("SELECT DISTINCT COUNT(tblNoteStore.ID) FROM dbo.tblNoteStore ");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboAssociatedToEntityType.Text, string.Empty, false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboAssociatedToEntityType.Text, "Loading", false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboAssociationName.Text, string.Empty, false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboAssociationName.Text, "Loading", false) != 0)
        stringBuilder.Append(" INNER JOIN dbo.tblNoteEntities ON dbo.tblNoteStore.ID = dbo.tblNoteEntities.NoteGUID ");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboUsersModified.Text, string.Empty, false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboUsersModified.Text, "Loading", false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtBody).Text, string.Empty, false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboEntryAssignedTo.Text, string.Empty, false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboEntryCreatedBy.Text, string.Empty, false) != 0 || !this.rbDiaryDontRemember.Checked || !this.rbDiaryStatusDontRemember.Checked || !this.rbModifiedDontRemember.Checked)
        stringBuilder.Append(" INNER JOIN dbo.tblNoteEntries ON dbo.tblNoteStore.ID = dbo.tblNoteEntries.NoteGUID ");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboEntryAssignedTo.Text, string.Empty, false) != 0 || !this.rbModifiedDontRemember.Checked || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboEntryCreatedBy.Text, string.Empty, false) != 0 || !this.rbDiaryStatusDontRemember.Checked)
        stringBuilder.Append(" INNER JOIN dbo.tblNoteRecipients ON dbo.tblNoteEntries.ID = dbo.tblNoteRecipients.EntryGUID ");
      if (!this.rbDiaryDontRemember.Checked)
        stringBuilder.Append(" INNER JOIN dbo.tblNoteDiaries ON dbo.tblNoteEntries.ID = dbo.tblNoteDiaries.EntryGUID ");
      return stringBuilder.ToString();
    }
  }

  private string SELECTClause
  {
    get
    {
      StringBuilder stringBuilder = new StringBuilder();
      string completedDateSql = this.GetCompletedby_CompletedDateSql("");
      stringBuilder.Append($"SELECT DISTINCT (CAST(dbo.tblNoteStore.ID AS VARCHAR(50))) , dbo.tblNoteStore.ID,  dbo.tblNoteStore.CreatedDate,  dbo.tblNoteStore.Subject,  ISNULL(tblUsers.LastName + ', ' + tblUsers.FirstName, (SELECT Description FROM lstSystemEntities WHERE SystemEntityID = tblNoteStore.SystemEntityID)) AS FullName {completedDateSql}{this.GetDueDate()}{this.GetAssociatedEntity()}FROM dbo.tblNoteStore  LEFT OUTER JOIN dbo.tblUsers ON dbo.tblNoteStore.UserGUID = dbo.tblUsers.UserGUID ");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboAssociatedToEntityType.Text, string.Empty, false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboAssociatedToEntityType.Text, "Loading", false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboAssociationName.Text, string.Empty, false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboAssociationName.Text, "Loading", false) != 0)
        stringBuilder.Append(" INNER JOIN dbo.tblNoteEntities ON dbo.tblNoteStore.ID = dbo.tblNoteEntities.NoteGUID ");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboUsersModified.Text, string.Empty, false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboUsersModified.Text, "Loading", false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtBody).Text, string.Empty, false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboEntryAssignedTo.Text, string.Empty, false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboEntryCreatedBy.Text, string.Empty, false) != 0 || !this.rbDiaryDontRemember.Checked || !this.rbDiaryStatusDontRemember.Checked || !this.rbModifiedDontRemember.Checked)
        stringBuilder.Append(" INNER JOIN dbo.tblNoteEntries ON dbo.tblNoteStore.ID = dbo.tblNoteEntries.NoteGUID ");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboEntryAssignedTo.Text, string.Empty, false) != 0 || !this.rbModifiedDontRemember.Checked || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboEntryCreatedBy.Text, string.Empty, false) != 0 || !this.rbDiaryStatusDontRemember.Checked)
        stringBuilder.Append(" INNER JOIN dbo.tblNoteRecipients ON dbo.tblNoteEntries.ID = dbo.tblNoteRecipients.EntryGUID ");
      if (!this.rbDiaryDontRemember.Checked)
        stringBuilder.Append(" INNER JOIN dbo.tblNoteDiaries ON dbo.tblNoteEntries.ID = dbo.tblNoteDiaries.EntryGUID ");
      return stringBuilder.ToString();
    }
  }

  private string GetCompletedby_CompletedDateSql(string CompDate_CompUser)
  {
    if (this.ShowCompletedColumns())
      CompDate_CompUser = this.cboCompletedBy.Value == null ? ", (   SELECT TOP 1 CompletedDate  FROM dbo.tblNoteRecipients  WHERE EntryGUID = dbo.tblNoteEntries.ID                                    AND CompletedDate IS NOT NULL) CompletedDate,dbo.GetUserName(  (   SELECT TOP 1 UserGUID  FROM dbo.tblNoteRecipients                                  WHERE EntryGUID = dbo.tblNoteEntries.ID   AND CompletedDate IS NOT NULL) ) CompletedBy  " : $", (   SELECT TOP 1 CompletedDate  FROM dbo.tblNoteRecipients  WHERE EntryGUID = dbo.tblNoteEntries.ID                                    AND CompletedDate IS NOT NULL) CompletedDate,dbo.GetUserName(  (   SELECT TOP 1 UserGUID  FROM dbo.tblNoteRecipients                                  WHERE EntryGUID = dbo.tblNoteEntries.ID   AND dbo.tblNoteRecipients.UserGUID = '{this.cboCompletedBy.Value.ToString()}') ) CompletedBy  ";
    return CompDate_CompUser;
  }

  private bool ShowCompletedColumns()
  {
    return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboUsersModified.Text, string.Empty, false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboUsersModified.Text, "Loading", false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtBody).Text, string.Empty, false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboEntryAssignedTo.Text, string.Empty, false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboEntryCreatedBy.Text, string.Empty, false) != 0 || !this.rbDiaryDontRemember.Checked || !this.rbDiaryStatusDontRemember.Checked || !this.rbModifiedDontRemember.Checked;
  }

  private void AddMgaComboWhereText(
    MGASimpleComboBox combo,
    string whereText,
    object whereValue,
    StringBuilder sqlWhere)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combo.Text, string.Empty, false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(combo.Text, "Loading", false) == 0)
      return;
    sqlWhere.Append(this.AddWhereAnd);
    sqlWhere.Append(string.Format(whereText, RuntimeHelpers.GetObjectValue(whereValue)));
  }

  private void AddMgaTextboxWhereText(
    MGATextBox textBox,
    string whereText,
    object whereValue,
    StringBuilder sqlWhere)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) textBox).Text, string.Empty, false) == 0)
      return;
    sqlWhere.Append(this.AddWhereAnd);
    sqlWhere.Append(string.Format(whereText, RuntimeHelpers.GetObjectValue(whereValue)));
  }

  private void AddCreatedDateText(StringBuilder sqlWhere)
  {
    if (this.rbCreatedDontRemember.Checked)
      return;
    sqlWhere.Append(this.AddWhereAnd);
    if (!this.rbCreatedSpecify.Checked)
    {
      TimeSpan timeSpan;
      if (this.rbCreatedLastWeek.Checked)
        timeSpan = new TimeSpan(7, 0, 0, 0);
      else if (this.rbCreatedPastMonth.Checked)
        timeSpan = new TimeSpan(31 /*0x1F*/, 0, 0, 0);
      else if (this.rbCreatedPastYear.Checked)
        timeSpan = new TimeSpan(365, 0, 0, 0);
      DateTime dateTime = DateAndTime.Now.Subtract(timeSpan);
      sqlWhere.Append($" CAST(CONVERT(VARCHAR(50),dbo.tblNoteStore.CreatedDate,101) AS DATETIME) >= '{dateTime.ToShortDateString()}'");
    }
    else
    {
      DateTime dateTime1 = Database.IsNull(RuntimeHelpers.GetObjectValue(this.dtCreatedFrom.Value), DateAndTime.Now);
      DateTime dateTime2 = Database.IsNull(RuntimeHelpers.GetObjectValue(this.dtCreatedTo.Value), DateAndTime.Now);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.dtCreatedFrom).Text, string.Empty, false) != 0)
      {
        sqlWhere.Append($" CAST(CONVERT(VARCHAR(50),dbo.tblNoteStore.CreatedDate,101) AS DATETIME) >= '{dateTime1.ToShortDateString()}' ");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.dtCreatedFrom).Text, string.Empty, false) != 0)
          sqlWhere.Append(" AND ");
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.dtCreatedTo).Text, string.Empty, false) == 0)
        return;
      sqlWhere.Append($" CAST( CONVERT(VARCHAR(50),dbo.tblNoteStore.CreatedDate,101) AS DATETIME)<= '{dateTime2.ToShortDateString()}' ");
    }
  }

  private void AddModifiedDateText(StringBuilder sqlWhere)
  {
    if (this.rbModifiedDontRemember.Checked)
      return;
    sqlWhere.Append(this.AddWhereAnd);
    if (!this.rbModifiedSpecify.Checked)
    {
      TimeSpan timeSpan;
      if (this.rbModifiedLastWeek.Checked)
        timeSpan = new TimeSpan(7, 0, 0, 0);
      else if (this.rbModifiedPastMonth.Checked)
        timeSpan = new TimeSpan(31 /*0x1F*/, 0, 0, 0);
      else if (this.rbModifiedPastYear.Checked)
        timeSpan = new TimeSpan(365, 0, 0, 0);
      DateTime dateTime = DateAndTime.Now.Subtract(timeSpan);
      sqlWhere.Append($" CAST(CONVERT(VARCHAR(50),dbo.tblNoteStore.CreatedDate,101) AS DATETIME) >= '{dateTime.ToShortDateString()}'");
    }
    else
    {
      DateTime dateTime1 = Database.IsNull(RuntimeHelpers.GetObjectValue(this.dtModifiedFrom.Value), DateAndTime.Now);
      DateTime dateTime2 = Database.IsNull(RuntimeHelpers.GetObjectValue(this.dtModifiedTo.Value), DateAndTime.Now);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.dtModifiedTo).Text, string.Empty, false) != 0)
      {
        sqlWhere.Append($" CAST(CONVERT(VARCHAR(50),dbo.tblNoteEntries.EditedDate,101) AS DATETIME)  >= '{dateTime1.ToShortDateString()}' ");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.dtModifiedFrom).Text, string.Empty, false) != 0)
          sqlWhere.Append(" AND ");
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.dtModifiedFrom).Text, string.Empty, false) == 0)
        return;
      sqlWhere.Append($" CAST(CONVERT(VARCHAR(50),dbo.tblNoteEntries.EditedDate,101) AS DATETIME) <= '{dateTime2.ToShortDateString()}' ");
    }
  }

  private void AddDiaryDateWhereText(StringBuilder sqlWhere)
  {
    if (!this.rbDiaryStatusDontRemember.Checked)
    {
      sqlWhere.Append(this.AddWhereAnd);
      if (this.rbDiaryStatusCompleted.Checked)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.dtCompletedFrom).Text, string.Empty, false) != 0 && ((UltraToggleEditorBase) this.chkCompletedDt).Checked)
          this.AddCompletedByWhereClause(sqlWhere);
        else
          sqlWhere.Append("(dbo.tblNoteRecipients.CompletedDate IS NOT NULL)");
      }
      else
        sqlWhere.Append("(dbo.tblNoteRecipients.CompletedDate IS NULL)");
    }
    if (this.rbDiaryDontRemember.Checked)
      return;
    sqlWhere.Append(this.AddWhereAnd);
    if (!this.rbDiaryDates.Checked)
    {
      TimeSpan timeSpan;
      if (this.rbDiaryLastWeek.Checked)
        timeSpan = new TimeSpan(7, 0, 0, 0);
      else if (this.rbDiaryPastMonth.Checked)
        timeSpan = new TimeSpan(31 /*0x1F*/, 0, 0, 0);
      else if (this.rbDiaryWithinLastYear.Checked)
        timeSpan = new TimeSpan(365, 0, 0, 0);
      DateTime dateTime = DateAndTime.Now.Subtract(timeSpan);
      sqlWhere.Append($" CAST(CONVERT(VARCHAR(50),dbo.tblNoteDiaries.DueDate,101) AS DATETIME) >= '{dateTime.ToShortDateString()}'");
    }
    else
    {
      DateTime dateTime1 = Database.IsNull(RuntimeHelpers.GetObjectValue(this.dtDiaryFrom.Value), DateAndTime.Now);
      DateTime dateTime2 = Database.IsNull(RuntimeHelpers.GetObjectValue(this.dtDiaryTo.Value), DateAndTime.Now);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.dtDiaryFrom).Text, string.Empty, false) != 0)
      {
        sqlWhere.Append($" CAST(CONVERT(VARCHAR(50),dbo.tblNoteDiaries.DueDate,101) AS DATETIME) >= '{dateTime1.ToShortDateString()}' ");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.dtDiaryFrom).Text, string.Empty, false) != 0)
          sqlWhere.Append(" AND ");
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.dtDiaryTo).Text, string.Empty, false) == 0)
        return;
      sqlWhere.Append($" CAST( CONVERT(VARCHAR(50),dbo.tblNoteDiaries.DueDate,101) AS DATETIME)<= '{dateTime2.ToShortDateString()}' ");
    }
  }

  private void AddCompletedByWhereClause(StringBuilder sqlWhere)
  {
    DateTime dateTime1 = Database.IsNull(RuntimeHelpers.GetObjectValue(this.dtCompletedFrom.Value), DateAndTime.Now);
    DateTime dateTime2 = Database.IsNull(RuntimeHelpers.GetObjectValue(this.dtCompletedto.Value), DateAndTime.Now);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.dtCompletedFrom).Text, string.Empty, false) != 0)
    {
      sqlWhere.Append($" CAST(CONVERT(VARCHAR(50),dbo.tblNoteRecipients.CompletedDate,101) AS DATETIME) >= '{dateTime1.ToShortDateString()}' ");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.dtCompletedFrom).Text, string.Empty, false) != 0)
        sqlWhere.Append(" AND ");
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.dtCompletedto).Text, string.Empty, false) == 0)
      return;
    sqlWhere.Append($" CAST( CONVERT(VARCHAR(50),dbo.tblNoteRecipients.CompletedDate,101) AS DATETIME)<= '{dateTime2.ToShortDateString()}' ");
  }

  private string WHEREClause
  {
    get
    {
      this._addedWhere = false;
      StringBuilder sqlWhere = new StringBuilder();
      this.AddMgaComboWhereText(this.cboUserCreated, "dbo.tblNoteStore.UserGUID = '{0}'", (object) Database.IsNull(RuntimeHelpers.GetObjectValue(this.cboUserCreated.Value), Guid.Empty), sqlWhere);
      this.AddMgaComboWhereText(this.cboUsersModified, "dbo.tblNoteEntries.EditedByUserGUID = '{0}'", (object) Database.IsNull(RuntimeHelpers.GetObjectValue(this.cboUsersModified.Value), Guid.Empty), sqlWhere);
      this.AddMgaTextboxWhereText(this.txtSubject, "dbo.tblNoteStore.Subject LIKE '%{0}%'", (object) ((TextEditorControlBase) this.txtSubject).Text.Replace("'", "''"), sqlWhere);
      this.AddMgaTextboxWhereText(this.txtBody, "dbo.tblNoteEntries.Body LIKE '%{0}%'", (object) ((TextEditorControlBase) this.txtBody).Text.Replace("'", "''"), sqlWhere);
      this.AddMgaComboWhereText(this.cboNoteType, " dbo.tblNoteStore.Type = {0}", (object) Database.IsNull(RuntimeHelpers.GetObjectValue(this.cboNoteType.Value), -1), sqlWhere);
      this.AddMgaComboWhereText(this.cboAssociationName, "dbo.tblNoteEntities.EntityName = '{0}'", (object) this.cboAssociationName.Text.Replace("'", "''"), sqlWhere);
      this.AddMgaComboWhereText(this.cboAssociatedToEntityType, "dbo.tblNoteEntities.EntityFormName = '{0}'", (object) this.cboAssociatedToEntityType.Text.Replace("'", "''"), sqlWhere);
      this.AddDiaryDateWhereText(sqlWhere);
      this.AddCreatedDateText(sqlWhere);
      this.AddModifiedDateText(sqlWhere);
      if (this.cboEntryAssignedTo.Value != null)
        this.AddMgaComboWhereText(this.cboEntryAssignedTo, "(dbo.tblNoteRecipients.UserGUID = '{0}')", (object) this.cboEntryAssignedTo.Value.ToString(), sqlWhere);
      if (this.cboEntryCreatedBy.Value != null)
        this.AddMgaComboWhereText(this.cboEntryCreatedBy, "(dbo.tblNoteEntries.UserGUID = '{0}')", (object) this.cboEntryCreatedBy.Value.ToString(), sqlWhere);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboCompletedBy.Text, string.Empty, false) != 0)
        this.AddMgaComboWhereText(this.cboCompletedBy, "dbo.tblNoteRecipients.UserGUID = '{0}'", (object) Database.IsNull(RuntimeHelpers.GetObjectValue(this.cboCompletedBy.Value), Guid.Empty), sqlWhere);
      return sqlWhere.ToString();
    }
  }

  private string AddWhereAnd
  {
    get
    {
      string addWhereAnd;
      if (!this._addedWhere)
      {
        this._addedWhere = true;
        addWhereAnd = " WHERE ";
      }
      else
        addWhereAnd = " AND ";
      return addWhereAnd;
    }
  }

  private void TabNoteSearch_Load(object sender, EventArgs e)
  {
    this.dtCreatedFrom.Value = (object) DateAndTime.Now;
    this.dtCreatedTo.Value = (object) DateAndTime.Now;
    this.dtModifiedFrom.Value = (object) DateAndTime.Now;
    this.dtModifiedTo.Value = (object) DateAndTime.Now;
    this.dtCompletedFrom.Value = (object) DateAndTime.Now;
    this.dtCompletedto.Value = (object) DateAndTime.Now;
  }

  private void rbDiaryDates_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.dtDiaryFrom).Enabled = this.rbDiaryDates.Checked;
    ((Control) this.dtDiaryTo).Enabled = this.rbDiaryDates.Checked;
  }

  public int PreferredPosition => 4;

  private void dtCompletedFrom_ValueChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.dtCompletedFrom).Text, string.Empty, false) != 0)
    {
      this.rbDiaryStatusCompleted.Checked = true;
    }
    else
    {
      if (!this.cboCompletedBy.Value.Equals((object) Guid.Empty) && this.cboCompletedBy.Value != null)
        return;
      this.rbDiaryStatusDontRemember.Checked = true;
    }
  }

  private void chkCompletedDt_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.chkCompletedDt).Checked)
    {
      ((Control) this.dtCompletedFrom).Enabled = true;
      ((Control) this.dtCompletedto).Enabled = true;
      this.rbDiaryStatusCompleted.Checked = true;
    }
    else
    {
      ((Control) this.dtCompletedFrom).Enabled = false;
      ((Control) this.dtCompletedto).Enabled = false;
      if (this.cboCompletedBy.Value != null && !this.cboCompletedBy.Value.Equals((object) Guid.Empty))
        return;
      this.rbDiaryStatusDontRemember.Checked = true;
    }
  }

  private void cboCompletedBy_ValueChanged(object sender, EventArgs e)
  {
    if (this.cboCompletedBy.Value != null && !this.cboCompletedBy.Value.Equals((object) Guid.Empty))
    {
      this.rbDiaryStatusCompleted.Checked = true;
    }
    else
    {
      if (((UltraToggleEditorBase) this.chkCompletedDt).Checked)
        return;
      this.rbDiaryStatusDontRemember.Checked = true;
    }
  }

  private void rbDiaryStatusCompleted_CheckedChanged(object sender, EventArgs e)
  {
    if (this.rbDiaryStatusCompleted.Checked)
      return;
    this.cboCompletedBy.Value = (object) Guid.Empty;
    ((UltraToggleEditorBase) this.chkCompletedDt).Checked = false;
  }

  private string GetDueDate()
  {
    return !this._ShowDueDate ? string.Empty : ",(SELECT TOP 1 DueDate  FROM tblNoteDiaries\t INNER JOIN dbo.tblNoteEntries ON dbo.tblNoteStore.ID       = dbo.tblNoteEntries.NoteGUID   WHERE dbo.tblNoteDiaries.EntryGUID = dbo.tblNoteEntries.ID) DueDate ";
  }

  private string GetAssociatedEntity()
  {
    return !this._showAssociatedEntity ? string.Empty : ",(  SELECT TOP 1\r\n                    ISNULL(CASE\r\n                         WHEN tblNoteEntities.ControlGuid IS NOT NULL THEN\r\n                             'Control - ' + (   SELECT TOP 1 TRY_CAST(ControlNo AS VARCHAR(100))\r\n                                                  FROM dbo.tblQuotes\r\n                                                 WHERE ControlGuid = tblNoteEntities.ControlGuid)\r\n                          WHEN EntityType='MGASystems.IMS.Claims.FormClaims' THEN \r\n\t\t\t\t\t\t'Claim - ' + (SELECT ClaimNumber FROM dbo.tblClaims_Claim WHERE ClaimGuid=dbo.tblNoteEntities.AssociatedEntityGUID) \r\n\t\t\t\t\t\tELSE ''END,'') FROM tblNoteEntities  WHERE dbo.tblNoteStore.ID = dbo.tblNoteEntities.NoteGUID) AssociatedEntity ";
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.NoteAutomationEventManagementForm
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common.DataAccess;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public sealed class NoteAutomationEventManagementForm : Form
{
  private Guid _companyLineGuid;
  private DataTable _documentAutomationEventsTable;
  private bool _documentAutomationEventsDataFetched;
  private DataTable _noteAutomationRecipientsTable;
  private bool _noteAutomationRecipientsDataFetched;
  private DataTable _noteAutomationTable;
  private bool _noteAutomationDataFetched;
  private DataTable _noteTypesTable;
  private bool _noteTypesDataFetched;
  private IContainer components;

  public NoteAutomationEventManagementForm(Guid companyLineGuid)
  {
    this.Load += new EventHandler(this.NoteAutomationEventManagement_Load);
    this.Closing += new CancelEventHandler(this.NoteAutomationEventManagementForm_Closing);
    this.InitializeComponent();
    this._companyLineGuid = !companyLineGuid.Equals(Guid.Empty) ? companyLineGuid : throw new ArgumentException("CompanyLineGuid cannot be empty");
    AppearanceBase appearance1 = ((ControlBase) this.btnSave).Appearance;
    appearance1.Image = (object) ImageCache.Instance.Save;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    AppearanceBase appearance2 = ((ControlBase) this.btnCancel).Appearance;
    appearance2.Image = (object) ImageCache.Instance.Undo;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("MainGroup")]
  internal virtual MGAGroupBox MainGroup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraGrid NoteAutomationGrid
  {
    get => this._NoteAutomationGrid;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      BeforeCellUpdateEventHandler updateEventHandler = new BeforeCellUpdateEventHandler(this.NoteAutomationGrid_BeforeCellUpdate);
      RowEventHandler rowEventHandler = new RowEventHandler(this.NoteAutomationGrid_AfterRowInsert);
      UltraGrid noteAutomationGrid1 = this._NoteAutomationGrid;
      if (noteAutomationGrid1 != null)
      {
        noteAutomationGrid1.BeforeCellUpdate -= updateEventHandler;
        noteAutomationGrid1.AfterRowInsert -= rowEventHandler;
      }
      this._NoteAutomationGrid = value;
      UltraGrid noteAutomationGrid2 = this._NoteAutomationGrid;
      if (noteAutomationGrid2 == null)
        return;
      noteAutomationGrid2.BeforeCellUpdate += updateEventHandler;
      noteAutomationGrid2.AfterRowInsert += rowEventHandler;
    }
  }

  internal virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  internal virtual LinkLabel lnkEventListing
  {
    get => this._lnkEventListing;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkEventListing_LinkClicked);
      LinkLabel lnkEventListing1 = this._lnkEventListing;
      if (lnkEventListing1 != null)
        lnkEventListing1.LinkClicked -= clickedEventHandler;
      this._lnkEventListing = value;
      LinkLabel lnkEventListing2 = this._lnkEventListing;
      if (lnkEventListing2 == null)
        return;
      lnkEventListing2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkCopyNotes
  {
    get => this._lnkCopyNotes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopyNotes_LinkClicked);
      LinkLabel lnkCopyNotes1 = this._lnkCopyNotes;
      if (lnkCopyNotes1 != null)
        lnkCopyNotes1.LinkClicked -= clickedEventHandler;
      this._lnkCopyNotes = value;
      LinkLabel lnkCopyNotes2 = this._lnkCopyNotes;
      if (lnkCopyNotes2 == null)
        return;
      lnkCopyNotes2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (NoteAutomationEventManagementForm));
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.MainGroup = new MGAGroupBox();
    this.lnkEventListing = new LinkLabel();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.NoteAutomationGrid = new UltraGrid();
    this.lnkCopyNotes = new LinkLabel();
    ((ISupportInitialize) this.MainGroup).BeginInit();
    ((Control) this.MainGroup).SuspendLayout();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.NoteAutomationGrid).BeginInit();
    this.SuspendLayout();
    ((Control) this.MainGroup).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(239, 247, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MainGroup.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.MainGroup).Controls.Add((Control) this.lnkCopyNotes);
    ((Control) this.MainGroup).Controls.Add((Control) this.lnkEventListing);
    ((Control) this.MainGroup).Controls.Add((Control) this.btnSave);
    ((Control) this.MainGroup).Controls.Add((Control) this.btnCancel);
    ((Control) this.MainGroup).Controls.Add((Control) this.NoteAutomationGrid);
    appearance2.AlphaLevel = (short) 230;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.White;
    appearance2.ForegroundAlpha = (Alpha) 2;
    appearance2.ImageAlpha = (Alpha) 2;
    appearance2.ImageBackground = (Image) resourceManager.GetObject("Appearance2.ImageBackground");
    appearance2.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MainGroup.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.MainGroup).Location = new Point(8, 8);
    ((Control) this.MainGroup).Name = "MainGroup";
    ((Control) this.MainGroup).Size = new Size(912, 352);
    this.MainGroup.SupportThemes = false;
    ((Control) this.MainGroup).TabIndex = 0;
    this.MainGroup.Text = "Loading Event Information...";
    this.MainGroup.ViewStyle = (GroupBoxViewStyle) 2;
    this.lnkEventListing.BackColor = Color.Transparent;
    this.lnkEventListing.Location = new Point(16 /*0x10*/, 320);
    this.lnkEventListing.Name = "lnkEventListing";
    this.lnkEventListing.Size = new Size(128 /*0x80*/, 16 /*0x10*/);
    this.lnkEventListing.TabIndex = 3;
    this.lnkEventListing.TabStop = true;
    this.lnkEventListing.Text = "View Listing Of Events";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(808, 304);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).TabIndex = 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance4;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(856, 304);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).TabIndex = 1;
    ((Control) this.NoteAutomationGrid).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.NoteAutomationGrid).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((Control) this.NoteAutomationGrid).Location = new Point(16 /*0x10*/, 41);
    ((Control) this.NoteAutomationGrid).Name = "NoteAutomationGrid";
    ((Control) this.NoteAutomationGrid).Size = new Size(880, (int) byte.MaxValue);
    ((Control) this.NoteAutomationGrid).TabIndex = 0;
    this.lnkCopyNotes.BackColor = Color.Transparent;
    this.lnkCopyNotes.Location = new Point(184, 320);
    this.lnkCopyNotes.Name = "lnkCopyNotes";
    this.lnkCopyNotes.Size = new Size(224 /*0xE0*/, 16 /*0x10*/);
    this.lnkCopyNotes.TabIndex = 4;
    this.lnkCopyNotes.TabStop = true;
    this.lnkCopyNotes.Text = "Copy All Notes To A Different CompanyLine";
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(930, 368);
    this.Controls.Add((Control) this.MainGroup);
    this.Font = new Font("Tahoma", 8f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (NoteAutomationEventManagementForm);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Note Automation Event Manager";
    ((ISupportInitialize) this.MainGroup).EndInit();
    ((Control) this.MainGroup).ResumeLayout(false);
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.NoteAutomationGrid).EndInit();
    this.ResumeLayout(false);
  }

  private Guid CompanyLineGuid => this._companyLineGuid;

  private void NoteAutomationEventManagement_Load(object sender, EventArgs e)
  {
    Database.Instance.QueryMultithreadedText.PerformTableQuery(new TableQueryMultithreadEventHandler(this.TableQuery_Completed), (Control) this, (object) "lstAutomationDocumentEvents", "SELECT EventGuid, EventName FROM lstAutomationDocumentEvents (NOLOCK)");
    Database.Instance.QueryMultithreadedText.PerformTableQuery(new TableQueryMultithreadEventHandler(this.TableQuery_Completed), (Control) this, (object) "lstNoteAutomationRecipients", "SELECT NoteAutomationRecipientID, RecipientName FROM lstNoteAutomationRecipients (NOLOCK) where HiddenFromAutomation = 0");
    Database.Instance.QueryMultithreadedText.PerformTableQuery(new TableQueryMultithreadEventHandler(this.TableQuery_Completed), (Control) this, (object) "tblNoteAutomation", "SELECT NoteAutomationID, CompanyLineGUID, EventGUID, NoteSubject, NoteBody, DueInDays, NoteAutomationRecipientID, Type, Popup, DiaryStartDateID FROM tblNoteAutomation (NOLOCK) WHERE CompanyLineGuid = @CompanyLineGuid", (object) "@CompanyLineGuid", (object) this.CompanyLineGuid);
    Database.Instance.QueryMultithreadedText.PerformTableQuery(new TableQueryMultithreadEventHandler(this.TableQuery_Completed), (Control) this, (object) "lstNoteTypes", "select NoteTypeId, [Description] from lstnotetypes (NOLOCK)");
  }

  private void ScalarQuery_Completed(object sender, ScalarQueryMultithreadedEventArgs e)
  {
    this.MainGroup.Text = Conversions.ToString(e.Result);
  }

  private void TableQuery_Completed(object sender, TableQueryMultithreadEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString((string) e.Key, "lstNoteTypes", false) == 0)
    {
      this._noteTypesTable = e.Table;
      this._noteTypesDataFetched = true;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString((string) e.Key, "lstAutomationDocumentEvents", false) == 0)
    {
      this._documentAutomationEventsTable = e.Table;
      this._documentAutomationEventsDataFetched = true;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString((string) e.Key, "lstNoteAutomationRecipients", false) == 0)
    {
      this._noteAutomationRecipientsTable = e.Table;
      this._noteAutomationRecipientsDataFetched = true;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString((string) e.Key, "tblNoteAutomation", false) == 0)
    {
      this._noteAutomationTable = e.Table;
      this._noteAutomationDataFetched = true;
    }
    if (!this._documentAutomationEventsDataFetched || !this._noteAutomationRecipientsDataFetched || !this._noteTypesDataFetched || !this._noteAutomationDataFetched)
      return;
    Database.Instance.QueryMultithreadedText.PerformScalarQuery((Control) this, (object) "CompanyLocationName", "SELECT dbo.tblCompanyLocations.Name + '     [' + dbo.lstLines.LineName + ']' AS FullName FROM dbo.tblCompanyLocations (NOLOCK) INNER JOIN dbo.tblCompanyLines (NOLOCK) ON dbo.tblCompanyLocations.CompanyLocationGUID = dbo.tblCompanyLines.CompanyLocationGUID INNER JOIN dbo.lstLines (NOLOCK) ON dbo.tblCompanyLines.LineGUID = dbo.lstLines.LineGUID AND dbo.tblCompanyLines.LineGUID = dbo.lstLines.LineGUID WHERE (dbo.tblCompanyLines.CompanyLineGUID = @CompanyLineGUID)", new ScalarQueryMultithreadedEventHandler(this.ScalarQuery_Completed), (object) "@CompanyLineGUID", (object) this._companyLineGuid);
    this._noteAutomationTable.AcceptChanges();
    this.SetupEventGrid(this.NoteAutomationGrid);
  }

  private void SetupEventGrid(UltraGrid grid)
  {
    ((UltraGridBase) grid).DataSource = (object) this._noteAutomationTable;
    ((SpecialBoxBase) ((UltraGridBase) grid).DisplayLayout.AddNewBox).Hidden = false;
    ColumnsCollection columns = ((UltraGridBase) grid).DisplayLayout.Bands[0].Columns;
    columns["NoteAutomationID"].Hidden = true;
    columns["CompanyLineGuid"].Hidden = true;
    UltraGridColumn ultraGridColumn1 = columns["EventGuid"];
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Event";
    ultraGridColumn1.ValueList = (IValueList) IGHelperModule.CreateIGValueList("EventList", "EventName", "EventGuid", this._documentAutomationEventsTable);
    ultraGridColumn1.Style = (ColumnStyle) 6;
    ultraGridColumn1.Width = 125;
    UltraGridColumn ultraGridColumn2 = columns["NoteSubject"];
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Subject/Action";
    ultraGridColumn2.Width = 100;
    UltraGridColumn ultraGridColumn3 = columns["NoteBody"];
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Body";
    ultraGridColumn3.Width = 220;
    UltraGridColumn ultraGridColumn4 = columns["DueInDays"];
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Lead Time";
    ultraGridColumn4.Width = 60;
    UltraGridColumn ultraGridColumn5 = columns["NoteAutomationRecipientID"];
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Recipient";
    ultraGridColumn5.ValueList = (IValueList) IGHelperModule.CreateIGValueList("RecipientList", "RecipientName", "NoteAutomationRecipientID", this._noteAutomationRecipientsTable);
    ultraGridColumn5.Style = (ColumnStyle) 6;
    UltraGridColumn ultraGridColumn6 = columns["Type"];
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Type";
    ultraGridColumn6.ValueList = (IValueList) IGHelperModule.CreateIGValueList("NoteTypeList", "Description", "NoteTypeID", this._noteTypesTable);
    ultraGridColumn6.Style = (ColumnStyle) 6;
    ultraGridColumn6.Width = 80 /*0x50*/;
    UltraGridColumn ultraGridColumn7 = columns["DiaryStartDateID"];
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Diary Start";
    ultraGridColumn7.ValueList = (IValueList) IGHelperModule.CreateIGValueList("DiaryStartList", "Description", "DiaryStartDateID", new DataTable()
    {
      Columns = {
        {
          "Description",
          typeof (string)
        },
        {
          "DiaryStartDateID",
          typeof (short)
        }
      },
      Rows = {
        new object[2]{ (object) "On Creation", (object) 0 },
        new object[2]{ (object) "On Risk Effective", (object) 1 },
        new object[2]{ (object) "On Risk Expiration", (object) 2 }
      }
    });
    ultraGridColumn7.Style = (ColumnStyle) 6;
    ultraGridColumn7.Width = 120;
    UltraGridColumn ultraGridColumn8 = columns["Popup"];
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Is Popup";
    ultraGridColumn8.Style = (ColumnStyle) 3;
    ultraGridColumn8.Width = 60;
    MGAGridProps props = MGAGridProps.SetAppearances | MGAGridProps.AutoColumnSizingOn | MGAGridProps.SetBorderStyle | MGAGridProps.Flat;
    MGAGrid.ApplyMGALayout(((UltraGridBase) grid).DisplayLayout, props);
  }

  private void NoteAutomationGrid_BeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "DueInDays", false) == 0)
    {
      if (e.NewValue != null && Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.NewValue)))
        return;
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "NoteSubject", false) != 0 || Conversions.ToString(e.NewValue).Length != 0)
        return;
      ((CancelEventArgs) e).Cancel = true;
    }
  }

  private void NoteAutomationGrid_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["NoteAutomationID"].Value = (object) Guid.NewGuid();
    e.Row.Cells["CompanyLineGuid"].Value = (object) this._companyLineGuid;
    e.Row.Cells["Popup"].Value = (object) false;
    e.Row.Cells["Type"].Value = (object) -1;
    e.Row.Cells["DiaryStartDateID"].Value = (object) 0;
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void NoteAutomationEventManagementForm_Closing(object sender, CancelEventArgs e)
  {
    ((UltraGridBase) this.NoteAutomationGrid).UpdateData();
    if (this.DialogResult == DialogResult.OK)
    {
      this.DoSave();
    }
    else
    {
      if (this._noteAutomationTable == null)
        return;
      DataTable changes = this._noteAutomationTable.GetChanges();
      if (changes == null || changes.Rows.Count < 1)
        return;
      switch (MessageBox.Show("Changes have been detected that were not saved. Would you like to save now?", "Changes Detected", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
      {
        case DialogResult.Cancel:
          e.Cancel = true;
          break;
        case DialogResult.Yes:
          this.DoSave();
          break;
      }
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void DoSave()
  {
    Database.Instance.PerformTransactionQuerySet(new Database.TransactionQuerySetEventHandler(this.SaveChanges_TransactionedQuerySet));
  }

  private object SaveChanges_TransactionedQuerySet(object sender, QuerySetHandlerEventArgs e)
  {
    DataTable changes1 = this._noteAutomationTable.GetChanges(DataRowState.Added);
    if (changes1 != null)
    {
      try
      {
        foreach (DataRow row in changes1.Rows)
          e.Database.QueryText.PerformNonQuery("INSERT INTO tblNoteAutomation (NoteAutomationID, CompanyLineGuid, EventGuid, NoteSubject, NoteBody, DueInDays, NoteAutomationRecipientID, Popup, Type, DiaryStartDateID) VALUES (@NoteAutomationID, @CompanyLineGuid, @EventGuid, @NoteSubject, @NoteBody, @DueInDays, @NoteAutomationRecipientID, @Popup, @Type, @DiaryStartDateID)", (object) "@NoteAutomationID", row["NoteAutomationID"], (object) "@CompanyLineGuid", row["CompanyLineGuid"], (object) "@EventGuid", row["EventGuid"], (object) "@NoteSubject", row["NoteSubject"], (object) "@NoteBody", row["NoteBody"], (object) "@DueInDays", row["DueInDays"], (object) "@NoteAutomationRecipientID", row["NoteAutomationRecipientID"], (object) "@Type", row["Type"], (object) "@Popup", row["Popup"], (object) "@DiaryStartDateID", row["DiaryStartDateID"]);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    DataTable changes2 = this._noteAutomationTable.GetChanges(DataRowState.Modified);
    if (changes2 != null)
    {
      try
      {
        foreach (DataRow row in changes2.Rows)
          e.Database.QueryText.PerformNonQuery("UPDATE tblNoteAutomation SET EventGuid = @EventGuid, NoteSubject = @NoteSubject, NoteBody = @NoteBody, DueInDays = @DueInDays, NoteAutomationRecipientID = @NoteAutomationRecipientID, Popup = @Popup, Type = @Type, DiaryStartDateID = @DiaryStartDateID WHERE NoteAutomationID = @NoteAutomationID ", (object) "@NoteAutomationID", row["NoteAutomationID"], (object) "@CompanyLineGuid", row["CompanyLineGuid"], (object) "@EventGuid", row["EventGuid"], (object) "@NoteSubject", row["NoteSubject"], (object) "@NoteBody", row["NoteBody"], (object) "@DueInDays", row["DueInDays"], (object) "@NoteAutomationRecipientID", row["NoteAutomationRecipientID"], (object) "@Type", row["Type"], (object) "@Popup", row["Popup"], (object) "@DiaryStartDateID", row["DiaryStartDateID"]);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    DataTable changes3 = this._noteAutomationTable.GetChanges(DataRowState.Deleted);
    if (changes3 != null)
    {
      changes3.RejectChanges();
      try
      {
        foreach (DataRow row in changes3.Rows)
          e.Database.QueryText.PerformNonQuery("DELETE FROM tblNoteAutomation WHERE NoteAutomationID = @NoteAutomationID", (object) "@NoteAutomationID", row["NoteAutomationID"]);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    return (object) null;
  }

  private void lnkEventListing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (frmViewAutomationEvents automationEvents = new frmViewAutomationEvents())
    {
      this.SetupEventGrid(automationEvents.ugViewEvents);
      ((SpecialBoxBase) ((UltraGridBase) automationEvents.ugViewEvents).DisplayLayout.AddNewBox).Hidden = true;
      ((UltraGridBase) automationEvents.ugViewEvents).DisplayLayout.Bands[0].Override.AllowUpdate = (DefaultableBoolean) 2;
      int num = (int) automationEvents.ShowDialog();
    }
  }

  private void lnkCopyNotes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraGridBase) this.NoteAutomationGrid).Rows.Count < 1)
      return;
    new frmCopyNotesToCompanyLines(this._companyLineGuid).Show();
  }
}

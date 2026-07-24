// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.PendingNoteForm
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinDataSource;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SecureResource("{18E990AA-31DA-46A6-9A95-87E60C34068B}", "Send Automated Notes on inactive Users", "Controls the ability of the user to send automated notes to inactive users during quote document generation", "User")]
public class PendingNoteForm : Form
{
  public const string SecurityIdAllowNotesWithNonActiveUser = "{18E990AA-31DA-46A6-9A95-87E60C34068B}";
  private List<PendingNote> _pendingNotes;
  private int _quoteID;
  private string _subject;
  private IContainer components;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("MgaGroupBox1")]
  internal virtual MGAGroupBox MgaGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  internal virtual UltraGrid PendingNoteGrid
  {
    get => this._PendingNoteGrid;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PendingNoteGrid_Click);
      UltraGrid pendingNoteGrid1 = this._PendingNoteGrid;
      if (pendingNoteGrid1 != null)
        ((Control) pendingNoteGrid1).Click -= eventHandler;
      this._PendingNoteGrid = value;
      UltraGrid pendingNoteGrid2 = this._PendingNoteGrid;
      if (pendingNoteGrid2 == null)
        return;
      ((Control) pendingNoteGrid2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cnSQL")]
  internal virtual SqlConnection cnSQL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daUsers")]
  internal virtual SqlDataAdapter daUsers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsPendingNotes")]
  internal virtual dsPendingNotes DsPendingNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraDataSource UltraDataSource1
  {
    get => this._UltraDataSource1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellDataUpdatedEventHandler updatedEventHandler = new CellDataUpdatedEventHandler(this.UltraDataSource1_CellDataUpdated);
      UltraDataSource ultraDataSource1_1 = this._UltraDataSource1;
      if (ultraDataSource1_1 != null)
        ultraDataSource1_1.CellDataUpdated -= updatedEventHandler;
      this._UltraDataSource1 = value;
      UltraDataSource ultraDataSource1_2 = this._UltraDataSource1;
      if (ultraDataSource1_2 == null)
        return;
      ultraDataSource1_2.CellDataUpdated += updatedEventHandler;
    }
  }

  internal virtual UltraDropDown UltraDropDown1
  {
    get => this._UltraDropDown1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.UltraDropDown1_InitializeRow);
      UltraDropDown ultraDropDown1_1 = this._UltraDropDown1;
      if (ultraDropDown1_1 != null)
        ultraDropDown1_1.InitializeRow -= initializeRowEventHandler;
      this._UltraDropDown1 = value;
      UltraDropDown ultraDropDown1_2 = this._UltraDropDown1;
      if (ultraDropDown1_2 == null)
        return;
      ultraDropDown1_2.InitializeRow += initializeRowEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblUsers", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("FullName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("StatusID");
    UltraGridBand ultraGridBand2 = new UltraGridBand("Band 0", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Due");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Subject/Action");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Body");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Assigned To:", -1, (object) "UltraDropDown1");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("PendingNoteTag");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Remove");
    UltraDataColumn ultraDataColumn1 = new UltraDataColumn("Due");
    UltraDataColumn ultraDataColumn2 = new UltraDataColumn("Subject/Action");
    UltraDataColumn ultraDataColumn3 = new UltraDataColumn("Body");
    UltraDataColumn ultraDataColumn4 = new UltraDataColumn("Assigned To:");
    UltraDataColumn ultraDataColumn5 = new UltraDataColumn("PendingNoteTag");
    UltraDataColumn ultraDataColumn6 = new UltraDataColumn("Remove");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.UltraDropDown1 = new UltraDropDown();
    this.DsPendingNotes = new dsPendingNotes();
    this.PendingNoteGrid = new UltraGrid();
    this.UltraDataSource1 = new UltraDataSource(this.components);
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.cnSQL = new SqlConnection();
    this.daUsers = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.UltraDropDown1).BeginInit();
    this.DsPendingNotes.BeginInit();
    ((ISupportInitialize) this.PendingNoteGrid).BeginInit();
    ((ISupportInitialize) this.UltraDataSource1).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    ((Control) this.MgaGroupBox1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(239, 247, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.UltraDropDown1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.PendingNoteGrid);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.btnSave);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.btnCancel);
    appearance2.AlphaLevel = (short) 230;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.White;
    appearance2.ForegroundAlpha = (Alpha) 2;
    appearance2.ImageAlpha = (Alpha) 2;
    appearance2.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.MgaGroupBox1).Location = new Point(8, 8);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(698, 370);
    ((Control) this.MgaGroupBox1).TabIndex = 0;
    this.MgaGroupBox1.Text = "The following notes are scheduled to be sent.";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    ((UltraGridBase) this.UltraDropDown1).DataSource = (object) this.DsPendingNotes.tblUsers;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 198;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraDropDownBase) this.UltraDropDown1).DisplayMember = "FullName";
    ((Control) this.UltraDropDown1).Location = new Point(64 /*0x40*/, 304);
    ((Control) this.UltraDropDown1).Name = "UltraDropDown1";
    ((Control) this.UltraDropDown1).Size = new Size(224 /*0xE0*/, 56);
    ((Control) this.UltraDropDown1).TabIndex = 6;
    ((Control) this.UltraDropDown1).Text = "UltraDropDown1";
    ((UltraDropDownBase) this.UltraDropDown1).ValueMember = "UserGUID";
    ((Control) this.UltraDropDown1).Visible = false;
    this.DsPendingNotes.DataSetName = "dsPendingNotes";
    this.DsPendingNotes.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.PendingNoteGrid).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.PendingNoteGrid).DataSource = (object) this.UltraDataSource1;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn4.Width = 84;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ultraGridColumn5.Width = 157;
    ultraGridColumn6.Header.VisiblePosition = 2;
    ultraGridColumn6.Width = 86;
    ultraGridColumn7.Header.VisiblePosition = 3;
    ultraGridColumn7.Style = (ColumnStyle) 6;
    ultraGridColumn7.Width = 214;
    ultraGridColumn8.Header.VisiblePosition = 4;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ultraGridColumn9.Header.VisiblePosition = 5;
    ultraGridBand2.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ((UltraGridBase) this.PendingNoteGrid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.PendingNoteGrid).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((Control) this.PendingNoteGrid).Location = new Point(16 /*0x10*/, 39);
    ((Control) this.PendingNoteGrid).Name = "PendingNoteGrid";
    ((Control) this.PendingNoteGrid).Size = new Size(672, 281);
    ((Control) this.PendingNoteGrid).TabIndex = 5;
    ultraDataColumn1.AllowDBNull = (DefaultableBoolean) 2;
    ultraDataColumn1.DataType = typeof (DateTime);
    ultraDataColumn1.DefaultValue = (object) new DateTime(0L);
    ultraDataColumn1.ReadOnly = (DefaultableBoolean) 2;
    ultraDataColumn2.AllowDBNull = (DefaultableBoolean) 2;
    ultraDataColumn2.ReadOnly = (DefaultableBoolean) 2;
    ultraDataColumn3.AllowDBNull = (DefaultableBoolean) 2;
    ultraDataColumn3.ReadOnly = (DefaultableBoolean) 2;
    ultraDataColumn4.AllowDBNull = (DefaultableBoolean) 2;
    ultraDataColumn4.DataType = typeof (Guid);
    ultraDataColumn4.ReadOnly = (DefaultableBoolean) 2;
    ultraDataColumn5.AllowDBNull = (DefaultableBoolean) 2;
    ultraDataColumn5.DataType = typeof (object);
    ultraDataColumn5.ReadOnly = (DefaultableBoolean) 2;
    ultraDataColumn6.DefaultValue = (object) "Remove";
    this.UltraDataSource1.Band.Columns.AddRange(new object[6]
    {
      (object) ultraDataColumn1,
      (object) ultraDataColumn2,
      (object) ultraDataColumn3,
      (object) ultraDataColumn4,
      (object) ultraDataColumn5,
      (object) ultraDataColumn6
    });
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnSave).Location = new Point(482, 330);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(96 /*0x60*/, 32 /*0x20*/);
    ((Control) this.btnSave).TabIndex = 4;
    ((ControlBase) this.btnSave).Text = "Send";
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance4;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(594, 330);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(96 /*0x60*/, 32 /*0x20*/);
    ((Control) this.btnCancel).TabIndex = 3;
    ((ControlBase) this.btnCancel).Text = "Cancel all notes";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.cnSQL.ConnectionString = "workstation id=DALBANO;packet size=4096;user id=mgasystems;data source=\"69.211.73.181\";persist security info=False;initial catalog=Aegis";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.daUsers.SelectCommand = this.SqlSelectCommand1;
    this.daUsers.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUsers", new DataColumnMapping[2]
      {
        new DataColumnMapping("UserGUID", "UserGUID"),
        new DataColumnMapping("FullName", "FullName")
      })
    });
    this.SqlSelectCommand1.CommandText = "SELECT tu.UserGUID, tu.LastName + ', ' + FirstName AS FullName FROM tblUsers tu inner join lstStatus s on s.StatusId = tu.StatusId where s.Disable = 0 ORDER BY FullName";
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(714, 384);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Font = new Font("Tahoma", 8f);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (PendingNoteForm);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Pending Notes";
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.UltraDropDown1).EndInit();
    this.DsPendingNotes.EndInit();
    ((ISupportInitialize) this.PendingNoteGrid).EndInit();
    ((ISupportInitialize) this.UltraDataSource1).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
  }

  public PendingNoteForm(List<PendingNote> pendingNotes, int QuoteID)
  {
    this.Load += new EventHandler(this.PendingNoteForm_Load);
    this.Closing += new CancelEventHandler(this.PendingNoteForm_Closing);
    this._quoteID = int.MinValue;
    this._subject = string.Empty;
    this.InitializeComponent();
    this._pendingNotes = pendingNotes;
    this._quoteID = QuoteID;
  }

  public PendingNoteForm(List<PendingNote> pendingNotes)
  {
    this.Load += new EventHandler(this.PendingNoteForm_Load);
    this.Closing += new CancelEventHandler(this.PendingNoteForm_Closing);
    this._quoteID = int.MinValue;
    this._subject = string.Empty;
    this.InitializeComponent();
    this._pendingNotes = pendingNotes;
  }

  private void PendingNoteForm_Load(object sender, EventArgs e)
  {
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    DefaultDatabase.LoadDataSet((DataSet) this.DsPendingNotes, new string[1]
    {
      "tblUsers"
    }, "GetPendingNotesUsers", new object[2]
    {
      (object) "@CurrentUserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    this.DsPendingNotes.tblUsers.AddtblUsersRow(Guid.Empty, "None", 1);
    if (this._quoteID != int.MinValue)
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT ControlNo, InsuredPolicyName FROM tblQuotes WITH (NOLOCK) WHERE QuoteID = @QD", new object[2]
      {
        (object) "@QD",
        (object) this._quoteID
      });
      if (dataRow != null)
        this._subject = $". Control #: {dataRow[0].ToString()}. Insured: {dataRow[1].ToString()}";
    }
    string str = "SELECT Name_LastFirst , StatusID FROM tblUsers  WITH (NOLOCK) WHERE UserGUID = @UG";
    try
    {
      foreach (PendingNote pendingNote in this._pendingNotes)
      {
        Guid UserGUID;
        if (pendingNote.GetDiaryRecipients().Length == 0)
        {
          UserGUID = Guid.Empty;
        }
        else
        {
          UserGUID = pendingNote.GetDiaryRecipients()[0];
          if (this.DsPendingNotes.tblUsers.FindByUserGUID(UserGUID) == null)
          {
            DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, str, new object[2]
            {
              (object) "@UG",
              (object) UserGUID
            });
            object objectValue = RuntimeHelpers.GetObjectValue(row["StatusID"]);
            int StatusID = -1;
            if (objectValue != null)
              StatusID = Conversions.ToInteger(objectValue);
            this.DsPendingNotes.tblUsers.AddtblUsersRow(UserGUID, row.Field<string>("Name_LastFirst"), StatusID);
          }
        }
        this.UltraDataSource1.Rows.Add(false, new object[5]
        {
          (object) pendingNote.DueDate,
          (object) pendingNote.Subject,
          (object) pendingNote.Body,
          (object) UserGUID,
          (object) pendingNote
        });
      }
    }
    finally
    {
      List<PendingNote>.Enumerator enumerator;
      enumerator.Dispose();
    }
    PendingNoteForm.SetupGrid(this.PendingNoteGrid);
  }

  private static void SetupGrid(UltraGrid grid)
  {
    MGAGridProps props = MGAGridProps.AutoColumnSizingOn | MGAGridProps.SetBorderStyle | MGAGridProps.Flat;
    MGAGrid.ApplyMGALayout(((UltraGridBase) grid).DisplayLayout, props);
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (this.HasInactiveUsers() && !SecurityManager.Instance.AssertPermission("{18E990AA-31DA-46A6-9A95-87E60C34068B}"))
    {
      int num = (int) MessageBox.Show("You do not have permission to send notes to inactive users. Please select active users prior to sending the notes.", "Unable to send notes to inactive users", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      ((UltraGridBase) this.PendingNoteGrid).UpdateData();
      this.DialogResult = DialogResult.OK;
      this.SendEmails();
      this.Close();
    }
  }

  private bool HasInactiveUsers()
  {
    bool flag;
    foreach (UltraGridRow row in ((UltraGridBase) this.PendingNoteGrid).Rows)
    {
      if (this.DsPendingNotes.tblUsers.FindByUserGUID((Guid) row.Cells["Assigned To:"].Value).StatusID != 1)
      {
        flag = true;
        goto label_5;
      }
    }
    flag = false;
label_5:
    return flag;
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void PendingNoteForm_Closing(object sender, CancelEventArgs e)
  {
    if (this.DialogResult != DialogResult.Cancel)
      return;
    if (MessageBox.Show("Are you sure you want to cancel all notes?", "Cancel Pending Notes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      this._pendingNotes.Clear();
    else
      e.Cancel = true;
  }

  private void UltraDataSource1_CellDataUpdated(object sender, CellDataUpdatedEventArgs e)
  {
    PendingNote pendingNote1 = (PendingNote) e.Row["PendingNoteTag"];
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Column.Key, "Due", false) == 0)
      pendingNote1.DueDate = Conversions.ToDate(e.NewValue);
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Column.Key, "Subject/Action", false) == 0)
    {
      string str = Conversions.ToString(e.NewValue);
      if (str.Length <= 0)
        return;
      pendingNote1.Subject = str;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Column.Key, "Body", false) == 0)
    {
      string str = Conversions.ToString(e.NewValue);
      if (str.Length <= 0)
        return;
      pendingNote1.Body = str;
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Column.Key, "Assigned To:", false) != 0)
        return;
      PendingNote pendingNote2 = pendingNote1;
      Guid[] diaryRecipients = new Guid[1];
      object newValue = e.NewValue;
      diaryRecipients[0] = newValue != null ? (Guid) newValue : new Guid();
      pendingNote2.SetDiaryRecipients(diaryRecipients);
    }
  }

  private void PendingNoteGrid_Click(object sender, EventArgs e)
  {
    UIElement lastElementEntered = ((ControlUIElementBase) ((UltraGridBase) this.PendingNoteGrid).DisplayLayout.UIElement).LastElementEntered;
    if (lastElementEntered == null)
      return;
    object objectValue = RuntimeHelpers.GetObjectValue(lastElementEntered.GetContext(typeof (UltraGridCell), true));
    if (objectValue == null)
      return;
    UltraGridCell ultraGridCell = (UltraGridCell) objectValue;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ultraGridCell.Column.Key, "Remove", false) != 0)
      return;
    PendingNote pendingNote = (PendingNote) ultraGridCell.Row.Cells["PendingNoteTag"].Value;
    ultraGridCell.Row.Delete(false);
    this._pendingNotes.Remove(pendingNote);
  }

  private void SendEmails()
  {
    if (!CurrentUser.Instance.HasValidMailSettings)
      return;
    string str = "SELECT ISNULL(EmailAddress, HomeEmailAddress) FROM tblUsers WITH (NOLOCK) WHERE UserGUID = @UG";
    try
    {
      foreach (UltraDataRow row in (IEnumerable) this.UltraDataSource1.Rows)
      {
        PendingNote pendingNote = (PendingNote) row["PendingNoteTag"];
        if (pendingNote.IncludeEmail)
        {
          Guid[] diaryRecipients = pendingNote.GetDiaryRecipients();
          int index = 0;
          while (index < diaryRecipients.Length)
          {
            Guid guid = diaryRecipients[index];
            object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, str, new object[2]
            {
              (object) "@UG",
              (object) guid
            }));
            if (objectValue != null && objectValue != DBNull.Value)
              new UserEmail(CurrentUser.Instance.UserGUID).SendMail(CurrentUser.Instance.Email.Address, objectValue.ToString(), pendingNote.Subject + this._subject, pendingNote.Body);
            checked { ++index; }
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

  public virtual void ProcessBoundNotesOnClient(Dictionary<Guid, PendingNote> boundGuidList)
  {
  }

  private void UltraDropDown1_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if ((int) e.Row.Cells["StatusID"].Value == 1)
      return;
    UltraGridCell cell = e.Row.Cells["FullName"];
    cell.Appearance.BackColor = Color.Red;
    cell.ToolTipText = "Inactive User";
  }
}

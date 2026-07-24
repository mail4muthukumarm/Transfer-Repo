// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmNoteUserSelectEx
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win.Misc;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.BaseClasses;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase")]
[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public sealed class frmNoteUserSelectEx : MGABaseForm
{
  private MGANoteRecipientListBox _list;
  private bool _isDiary;
  private IContainer components;
  private DbConnection cnSql;
  private DbDataAdapter daUsers;
  private Label Label1;
  private Label Label2;
  private DataView vwStdRecips;
  private DataView vwDiaryRecips;
  private DbCommand DbSelectCommand1;
  private DataView vwAllRecips;
  private DsUserSelectionEx DsUserSelectionEx;
  private ContextMenu ctxAdd;
  private Label lblDiaryRecips;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnOK
  {
    get => this._btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOK_Click);
      MGAButton btnOk1 = this._btnOK;
      if (btnOk1 != null)
        ((Control) btnOk1).Click -= eventHandler;
      this._btnOK = value;
      MGAButton btnOk2 = this._btnOK;
      if (btnOk2 == null)
        return;
      ((Control) btnOk2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnCancel
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

  private virtual MGAButton btnAddStdRecipient
  {
    get => this._btnAddStdRecipient;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAddStdRecipient_Click);
      MGAButton btnAddStdRecipient1 = this._btnAddStdRecipient;
      if (btnAddStdRecipient1 != null)
        ((Control) btnAddStdRecipient1).Click -= eventHandler;
      this._btnAddStdRecipient = value;
      MGAButton btnAddStdRecipient2 = this._btnAddStdRecipient;
      if (btnAddStdRecipient2 == null)
        return;
      ((Control) btnAddStdRecipient2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnAddDiaryRecipient
  {
    get => this._btnAddDiaryRecipient;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAddDiaryRecipient_Click);
      MGAButton addDiaryRecipient1 = this._btnAddDiaryRecipient;
      if (addDiaryRecipient1 != null)
        ((Control) addDiaryRecipient1).Click -= eventHandler;
      this._btnAddDiaryRecipient = value;
      MGAButton addDiaryRecipient2 = this._btnAddDiaryRecipient;
      if (addDiaryRecipient2 == null)
        return;
      ((Control) addDiaryRecipient2).Click += eventHandler;
    }
  }

  private virtual MGAListBox lbAllUsers
  {
    get => this._lbAllUsers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lbAllUsers_DoubleClick);
      MGAListBox lbAllUsers1 = this._lbAllUsers;
      if (lbAllUsers1 != null)
        lbAllUsers1.DoubleClick -= eventHandler;
      this._lbAllUsers = value;
      MGAListBox lbAllUsers2 = this._lbAllUsers;
      if (lbAllUsers2 == null)
        return;
      lbAllUsers2.DoubleClick += eventHandler;
    }
  }

  private virtual MGAListBox lbStdUsers
  {
    get => this._lbStdUsers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.lbStdUsers_KeyDown);
      EventHandler eventHandler = new EventHandler(this.lbStdUsers_DoubleClick);
      MGAListBox lbStdUsers1 = this._lbStdUsers;
      if (lbStdUsers1 != null)
      {
        lbStdUsers1.KeyDown -= keyEventHandler;
        lbStdUsers1.DoubleClick -= eventHandler;
      }
      this._lbStdUsers = value;
      MGAListBox lbStdUsers2 = this._lbStdUsers;
      if (lbStdUsers2 == null)
        return;
      lbStdUsers2.KeyDown += keyEventHandler;
      lbStdUsers2.DoubleClick += eventHandler;
    }
  }

  private virtual MGAListBox lbDiaryUsers
  {
    get => this._lbDiaryUsers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.lbDiaryUsers_KeyDown);
      EventHandler eventHandler = new EventHandler(this.lbDiaryUsers_DoubleClick);
      MGAListBox lbDiaryUsers1 = this._lbDiaryUsers;
      if (lbDiaryUsers1 != null)
      {
        lbDiaryUsers1.KeyDown -= keyEventHandler;
        lbDiaryUsers1.DoubleClick -= eventHandler;
      }
      this._lbDiaryUsers = value;
      MGAListBox lbDiaryUsers2 = this._lbDiaryUsers;
      if (lbDiaryUsers2 == null)
        return;
      lbDiaryUsers2.KeyDown += keyEventHandler;
      lbDiaryUsers2.DoubleClick += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ctxRemove")]
  private virtual ContextMenu ctxRemove { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MenuItem mnuRemove
  {
    get => this._mnuRemove;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuRemove_Click);
      MenuItem mnuRemove1 = this._mnuRemove;
      if (mnuRemove1 != null)
        mnuRemove1.Click -= eventHandler;
      this._mnuRemove = value;
      MenuItem mnuRemove2 = this._mnuRemove;
      if (mnuRemove2 == null)
        return;
      mnuRemove2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuAddStd
  {
    get => this._mnuAddStd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuAddStd_Click);
      MenuItem mnuAddStd1 = this._mnuAddStd;
      if (mnuAddStd1 != null)
        mnuAddStd1.Click -= eventHandler;
      this._mnuAddStd = value;
      MenuItem mnuAddStd2 = this._mnuAddStd;
      if (mnuAddStd2 == null)
        return;
      mnuAddStd2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuAddDiary
  {
    get => this._mnuAddDiary;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuAddDiary_Click);
      MenuItem mnuAddDiary1 = this._mnuAddDiary;
      if (mnuAddDiary1 != null)
        mnuAddDiary1.Click -= eventHandler;
      this._mnuAddDiary = value;
      MenuItem mnuAddDiary2 = this._mnuAddDiary;
      if (mnuAddDiary2 == null)
        return;
      mnuAddDiary2.Click += eventHandler;
    }
  }

  internal virtual MGAButton btnRemoveDiaryRec
  {
    get => this._btnRemoveDiaryRec;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnRemoveDiaryRec_Click);
      MGAButton btnRemoveDiaryRec1 = this._btnRemoveDiaryRec;
      if (btnRemoveDiaryRec1 != null)
        ((Control) btnRemoveDiaryRec1).Click -= eventHandler;
      this._btnRemoveDiaryRec = value;
      MGAButton btnRemoveDiaryRec2 = this._btnRemoveDiaryRec;
      if (btnRemoveDiaryRec2 == null)
        return;
      ((Control) btnRemoveDiaryRec2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnRemoveStandRec
  {
    get => this._btnRemoveStandRec;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnRemoveStandRec_Click);
      MGAButton btnRemoveStandRec1 = this._btnRemoveStandRec;
      if (btnRemoveStandRec1 != null)
        ((Control) btnRemoveStandRec1).Click -= eventHandler;
      this._btnRemoveStandRec = value;
      MGAButton btnRemoveStandRec2 = this._btnRemoveStandRec;
      if (btnRemoveStandRec2 == null)
        return;
      ((Control) btnRemoveStandRec2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.btnOK = new MGAButton();
    this.btnCancel = new MGAButton();
    this.cnSql = DefaultDatabase.CreateDbConnection();
    this.daUsers = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.lbAllUsers = new MGAListBox();
    this.ctxAdd = new ContextMenu();
    this.mnuAddStd = new MenuItem();
    this.mnuAddDiary = new MenuItem();
    this.vwAllRecips = new DataView();
    this.DsUserSelectionEx = new DsUserSelectionEx();
    this.Label1 = new Label();
    this.lbStdUsers = new MGAListBox();
    this.ctxRemove = new ContextMenu();
    this.mnuRemove = new MenuItem();
    this.vwStdRecips = new DataView();
    this.Label2 = new Label();
    this.lblDiaryRecips = new Label();
    this.lbDiaryUsers = new MGAListBox();
    this.vwDiaryRecips = new DataView();
    this.btnAddStdRecipient = new MGAButton();
    this.btnAddDiaryRecipient = new MGAButton();
    this.btnRemoveStandRec = new MGAButton();
    this.btnRemoveDiaryRec = new MGAButton();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.lbAllUsers).BeginInit();
    this.vwAllRecips.BeginInit();
    this.DsUserSelectionEx.BeginInit();
    ((ISupportInitialize) this.lbStdUsers).BeginInit();
    this.vwStdRecips.BeginInit();
    ((ISupportInitialize) this.lbDiaryUsers).BeginInit();
    this.vwDiaryRecips.BeginInit();
    ((ISupportInitialize) this.btnAddStdRecipient).BeginInit();
    ((ISupportInitialize) this.btnAddDiaryRecipient).BeginInit();
    ((ISupportInitialize) this.btnRemoveStandRec).BeginInit();
    ((ISupportInitialize) this.btnRemoveDiaryRec).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnOK).Location = new Point(168, 300);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(64 /*0x40*/, 24);
    ((Control) this.btnOK).TabIndex = 1;
    ((ControlBase) this.btnOK).Text = "OK";
    ((Control) this.btnCancel).Location = new Point(248, 300);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(64 /*0x40*/, 24);
    ((Control) this.btnCancel).TabIndex = 2;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.daUsers.SelectCommand = this.DbSelectCommand1;
    this.daUsers.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUsers", new DataColumnMapping[4]
      {
        new DataColumnMapping("UserGUID", "UserGUID"),
        new DataColumnMapping("FullName", "FullName"),
        new DataColumnMapping("StdRecip", "StdRecip"),
        new DataColumnMapping("DiaryRecip", "DiaryRecip")
      })
    });
    this.DbSelectCommand1.CommandText = "SELECT UserGUID, LastName + ', ' + FirstName AS FullName, 0 AS StdRecip, 0 AS DiaryRecip FROM dbo.tblUsers WHERE (StatusID = 1) ORDER BY FullName";
    this.DbSelectCommand1.Connection = this.cnSql;
    this.lbAllUsers.BackColor = Color.White;
    this.lbAllUsers.ContextMenu = this.ctxAdd;
    this.lbAllUsers.DataSource = (object) this.vwAllRecips;
    this.lbAllUsers.DisplayMember = "FullName";
    this.lbAllUsers.ForeColor = Color.Black;
    this.lbAllUsers.IntegralHeight = false;
    this.lbAllUsers.Location = new Point(8, 24);
    this.lbAllUsers.Name = "lbAllUsers";
    this.lbAllUsers.Size = new Size(176 /*0xB0*/, 264);
    this.lbAllUsers.TabIndex = 3;
    this.lbAllUsers.ValueMember = "UserGUID";
    this.ctxAdd.MenuItems.AddRange(new MenuItem[2]
    {
      this.mnuAddStd,
      this.mnuAddDiary
    });
    this.mnuAddStd.Index = 0;
    this.mnuAddStd.Text = "Add to standard";
    this.mnuAddDiary.Index = 1;
    this.mnuAddDiary.Text = "Add to diary";
    this.vwAllRecips.Table = (DataTable) this.DsUserSelectionEx.tblUsers;
    this.DsUserSelectionEx.DataSetName = "DsUserSelectionEx";
    this.DsUserSelectionEx.Locale = new CultureInfo("en-US");
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 5);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(37, 17);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Name:";
    this.lbStdUsers.BackColor = Color.White;
    this.lbStdUsers.ContextMenu = this.ctxRemove;
    this.lbStdUsers.DataSource = (object) this.vwStdRecips;
    this.lbStdUsers.DisplayMember = "FullName";
    this.lbStdUsers.ForeColor = Color.Black;
    this.lbStdUsers.IntegralHeight = false;
    this.lbStdUsers.Location = new Point(296, 24);
    this.lbStdUsers.Name = "lbStdUsers";
    this.lbStdUsers.Size = new Size(168, 112 /*0x70*/);
    this.lbStdUsers.Sorted = true;
    this.lbStdUsers.TabIndex = 5;
    this.lbStdUsers.ValueMember = "UserGUID";
    this.ctxRemove.MenuItems.AddRange(new MenuItem[1]
    {
      this.mnuRemove
    });
    this.mnuRemove.Index = 0;
    this.mnuRemove.Text = "Remove";
    this.vwStdRecips.RowFilter = "stdRecip = 1";
    this.vwStdRecips.Table = (DataTable) this.DsUserSelectionEx.tblUsers;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(295, 5);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(107, 17);
    this.Label2.TabIndex = 6;
    this.Label2.Text = "Standard Recipients:";
    this.lblDiaryRecips.AutoSize = true;
    this.lblDiaryRecips.Location = new Point(295, 150);
    this.lblDiaryRecips.Name = "lblDiaryRecips";
    this.lblDiaryRecips.Size = new Size(88, 17);
    this.lblDiaryRecips.TabIndex = 8;
    this.lblDiaryRecips.Text = "Diary Recipients:";
    this.lbDiaryUsers.BackColor = Color.White;
    this.lbDiaryUsers.ContextMenu = this.ctxRemove;
    this.lbDiaryUsers.DataSource = (object) this.vwDiaryRecips;
    this.lbDiaryUsers.DisplayMember = "FullName";
    this.lbDiaryUsers.ForeColor = Color.Black;
    this.lbDiaryUsers.IntegralHeight = false;
    this.lbDiaryUsers.Location = new Point(296, 168);
    this.lbDiaryUsers.Name = "lbDiaryUsers";
    this.lbDiaryUsers.Size = new Size(168, 120);
    this.lbDiaryUsers.TabIndex = 7;
    this.lbDiaryUsers.ValueMember = "UserGUID";
    this.vwDiaryRecips.RowFilter = "DiaryRecip = 1";
    this.vwDiaryRecips.Table = (DataTable) this.DsUserSelectionEx.tblUsers;
    ((Control) this.btnAddStdRecipient).Location = new Point(205, 40);
    ((Control) this.btnAddStdRecipient).Name = "btnAddStdRecipient";
    ((Control) this.btnAddStdRecipient).Size = new Size(64 /*0x40*/, 24);
    ((Control) this.btnAddStdRecipient).TabIndex = 9;
    ((ControlBase) this.btnAddStdRecipient).Text = ">>";
    ((Control) this.btnAddDiaryRecipient).Location = new Point(200, 195);
    ((Control) this.btnAddDiaryRecipient).Name = "btnAddDiaryRecipient";
    ((Control) this.btnAddDiaryRecipient).Size = new Size(64 /*0x40*/, 24);
    ((Control) this.btnAddDiaryRecipient).TabIndex = 10;
    ((ControlBase) this.btnAddDiaryRecipient).Text = ">>";
    ((Control) this.btnRemoveStandRec).Location = new Point(205, 70);
    ((Control) this.btnRemoveStandRec).Name = "btnRemoveStandRec";
    ((Control) this.btnRemoveStandRec).Size = new Size(64 /*0x40*/, 24);
    ((Control) this.btnRemoveStandRec).TabIndex = 11;
    ((ControlBase) this.btnRemoveStandRec).Text = "<<";
    ((Control) this.btnRemoveDiaryRec).Location = new Point(200, 225);
    ((Control) this.btnRemoveDiaryRec).Name = "btnRemoveDiaryRec";
    ((Control) this.btnRemoveDiaryRec).Size = new Size(64 /*0x40*/, 24);
    ((Control) this.btnRemoveDiaryRec).TabIndex = 12;
    ((ControlBase) this.btnRemoveDiaryRec).Text = "<<";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.FromArgb(250, 250, 250);
    this.ClientSize = new Size(480, 333);
    this.Controls.Add((Control) this.btnRemoveDiaryRec);
    this.Controls.Add((Control) this.btnRemoveStandRec);
    this.Controls.Add((Control) this.btnAddDiaryRecipient);
    this.Controls.Add((Control) this.btnAddStdRecipient);
    this.Controls.Add((Control) this.lblDiaryRecips);
    this.Controls.Add((Control) this.lbDiaryUsers);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.lbStdUsers);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lbAllUsers);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOK);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmNoteUserSelectEx);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Select Names";
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.lbAllUsers).EndInit();
    this.vwAllRecips.EndInit();
    this.DsUserSelectionEx.EndInit();
    ((ISupportInitialize) this.lbStdUsers).EndInit();
    this.vwStdRecips.EndInit();
    ((ISupportInitialize) this.lbDiaryUsers).EndInit();
    this.vwDiaryRecips.EndInit();
    ((ISupportInitialize) this.btnAddStdRecipient).EndInit();
    ((ISupportInitialize) this.btnAddDiaryRecipient).EndInit();
    ((ISupportInitialize) this.btnRemoveStandRec).EndInit();
    ((ISupportInitialize) this.btnRemoveDiaryRec).EndInit();
    this.ResumeLayout(false);
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    this._list.Clear();
    try
    {
      foreach (DataRowView vwDiaryRecip in this.vwDiaryRecips)
      {
        DsUserSelectionEx.tblUsersRow row = (DsUserSelectionEx.tblUsersRow) vwDiaryRecip.Row;
        this._list.AddUser(row.UserGUID, row.FullName, false, MGANoteRecipientListBox.DiaryStatus.NotComplete);
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
      foreach (DataRowView vwStdRecip in this.vwStdRecips)
      {
        DsUserSelectionEx.tblUsersRow row = (DsUserSelectionEx.tblUsersRow) vwStdRecip.Row;
        this._list.AddUser(row.UserGUID, row.FullName, false, MGANoteRecipientListBox.DiaryStatus.None);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    frmNoteUserSelectEx.VerifyRelevantRecipients(this._isDiary, this._list);
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  public static bool VerifyRelevantRecipients(
    bool isDiary,
    MGANoteRecipientListBox list,
    bool showUI = true)
  {
    bool flag;
    if (SystemSettings.GetSetting<bool>("NoteMustHaveRelaventRecipient", true))
    {
      if (isDiary)
      {
        try
        {
          foreach (MGANoteRecipientListBox.MGANoteRecipientListItem recipientListItem in list.Items)
          {
            if (recipientListItem.Diary != MGANoteRecipientListBox.DiaryStatus.None)
            {
              flag = true;
              goto label_22;
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        list.AddUser(CurrentUser.Instance.UserGUID, $"{CurrentUser.Instance.LastName}, {CurrentUser.Instance.FirstName}", true, MGANoteRecipientListBox.DiaryStatus.NotComplete);
        if (showUI)
        {
          int num = (int) MessageBox.Show("You must have at least one diary recipient on a diary. The system will add you as a diary recipient for this task.", "Please check your recipients", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      else
      {
        try
        {
          foreach (MGANoteRecipientListBox.MGANoteRecipientListItem recipientListItem in list.Items)
          {
            if (recipientListItem.Diary == MGANoteRecipientListBox.DiaryStatus.None)
            {
              flag = true;
              goto label_22;
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        list.AddUser(CurrentUser.Instance.UserGUID, $"{CurrentUser.Instance.LastName}, {CurrentUser.Instance.FirstName}", true, MGANoteRecipientListBox.DiaryStatus.None);
        if (showUI)
        {
          int num = (int) MessageBox.Show("You must have at least one standard recipient on a note. The system will add you as a standard recipient for this note.", "Please check your recipients", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      flag = false;
    }
    else
      flag = true;
label_22:
    return flag;
  }

  [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
  public MustCompleteContextGUID[] SelectedUsers => (MustCompleteContextGUID[]) null;

  private void ShowDiaryRecips(bool show)
  {
    if (show)
    {
      this.lblDiaryRecips.Visible = true;
      this.lbDiaryUsers.Visible = true;
      this.lbStdUsers.Height = 112 /*0x70*/;
      ((Control) this.btnAddDiaryRecipient).Visible = true;
      ((Control) this.btnAddStdRecipient).Top = 48 /*0x30*/;
    }
    else
    {
      this.lblDiaryRecips.Visible = false;
      this.lbDiaryUsers.Visible = false;
      this.lbStdUsers.Height = 264;
      ((Control) this.btnAddDiaryRecipient).Visible = false;
      ((Control) this.btnAddStdRecipient).Top = 144 /*0x90*/;
    }
  }

  private void frmNoteUserSelectEx_Load(object sender, EventArgs e)
  {
    this.vwAllRecips.RowFilter = "StdRecip = 0 AND DiaryRecip = 0";
    DefaultDatabase.DataAdapterFill(this.daUsers, (DataTable) this.DsUserSelectionEx.tblUsers);
    try
    {
      foreach (MGANoteRecipientListBox.MGANoteRecipientListItem recipientListItem in this._list.Items)
      {
        DsUserSelectionEx.tblUsersRow byUserGuid = this.DsUserSelectionEx.tblUsers.FindByUserGUID(recipientListItem.UserGUID);
        if (byUserGuid != null)
        {
          if (recipientListItem.Diary != MGANoteRecipientListBox.DiaryStatus.None)
          {
            byUserGuid.DiaryRecip = 1;
            byUserGuid.StdRecip = 0;
          }
          else
          {
            byUserGuid.DiaryRecip = 0;
            byUserGuid.StdRecip = 1;
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

  public frmNoteUserSelectEx(MGANoteRecipientListBox list, bool isDiary)
  {
    this.Load += new EventHandler(this.frmNoteUserSelectEx_Load);
    this._isDiary = true;
    this._isDiary = isDiary;
    this.InitializeComponent();
    this.ShowDiaryRecips(isDiary);
    this._list = list;
  }

  private void btnAddStdRecipient_Click(object sender, EventArgs e)
  {
    if (this.lbAllUsers.SelectedValue == null)
      return;
    object selectedValue = this.lbAllUsers.SelectedValue;
    this.DsUserSelectionEx.tblUsers.FindByUserGUID(selectedValue != null ? (Guid) selectedValue : new Guid()).StdRecip = 1;
  }

  private void btnAddDiaryRecipient_Click(object sender, EventArgs e)
  {
    if (this.lbAllUsers.SelectedValue == null)
      return;
    object selectedValue = this.lbAllUsers.SelectedValue;
    this.DsUserSelectionEx.tblUsers.FindByUserGUID(selectedValue != null ? (Guid) selectedValue : new Guid()).DiaryRecip = 1;
  }

  private void lbStdUsers_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Delete || this.lbStdUsers.SelectedValue == null)
      return;
    object selectedValue = this.lbStdUsers.SelectedValue;
    this.DsUserSelectionEx.tblUsers.FindByUserGUID(selectedValue != null ? (Guid) selectedValue : new Guid()).StdRecip = 0;
  }

  private void lbDiaryUsers_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Delete || this.lbDiaryUsers.SelectedValue == null)
      return;
    object selectedValue = this.lbDiaryUsers.SelectedValue;
    this.DsUserSelectionEx.tblUsers.FindByUserGUID(selectedValue != null ? (Guid) selectedValue : new Guid()).DiaryRecip = 0;
  }

  private void lbAllUsers_DoubleClick(object sender, EventArgs e)
  {
    if (this.lbAllUsers.SelectedValue == null)
      return;
    object selectedValue = this.lbAllUsers.SelectedValue;
    Guid UserGUID = selectedValue != null ? (Guid) selectedValue : new Guid();
    if (this._isDiary)
      this.DsUserSelectionEx.tblUsers.FindByUserGUID(UserGUID).DiaryRecip = 1;
    else
      this.DsUserSelectionEx.tblUsers.FindByUserGUID(UserGUID).StdRecip = 1;
  }

  private void lbDiaryUsers_DoubleClick(object sender, EventArgs e)
  {
    if (this.lbDiaryUsers.SelectedValue == null)
      return;
    object selectedValue = this.lbDiaryUsers.SelectedValue;
    this.DsUserSelectionEx.tblUsers.FindByUserGUID(selectedValue != null ? (Guid) selectedValue : new Guid()).DiaryRecip = 0;
  }

  private void lbStdUsers_DoubleClick(object sender, EventArgs e)
  {
    if (this.lbStdUsers.SelectedValue == null)
      return;
    object selectedValue = this.lbStdUsers.SelectedValue;
    this.DsUserSelectionEx.tblUsers.FindByUserGUID(selectedValue != null ? (Guid) selectedValue : new Guid()).StdRecip = 0;
  }

  private void mnuAddStd_Click(object sender, EventArgs e)
  {
    if (this.lbAllUsers.SelectedValue == null)
      return;
    object selectedValue = this.lbAllUsers.SelectedValue;
    this.DsUserSelectionEx.tblUsers.FindByUserGUID(selectedValue != null ? (Guid) selectedValue : new Guid()).StdRecip = 1;
  }

  private void mnuAddDiary_Click(object sender, EventArgs e)
  {
    if (this.lbAllUsers.SelectedValue == null)
      return;
    object selectedValue = this.lbAllUsers.SelectedValue;
    this.DsUserSelectionEx.tblUsers.FindByUserGUID(selectedValue != null ? (Guid) selectedValue : new Guid()).DiaryRecip = 1;
  }

  private void mnuRemove_Click(object sender, EventArgs e)
  {
    if (this.lbStdUsers.SelectedValue != null)
    {
      this.DsUserSelectionEx.tblUsers.FindByUserGUID((Guid) ((DataRowView) this.lbStdUsers.Items[0]).Row["UserGuid"]).StdRecip = 0;
      this.DsUserSelectionEx.AcceptChanges();
    }
    if (this.lbDiaryUsers.SelectedValue == null)
      return;
    this.DsUserSelectionEx.tblUsers.FindByUserGUID((Guid) ((DataRowView) this.lbDiaryUsers.Items[0]).Row["UserGuid"]).DiaryRecip = 0;
    this.DsUserSelectionEx.AcceptChanges();
  }

  private void btnRemoveDiaryRec_Click(object sender, EventArgs e)
  {
    if (this.lbDiaryUsers.SelectedItems.Count <= 0)
      return;
    this.DsUserSelectionEx.tblUsers.FindByUserGUID((Guid) ((DataRowView) this.lbDiaryUsers.Items[0]).Row["UserGuid"]).DiaryRecip = 0;
    this.DsUserSelectionEx.AcceptChanges();
  }

  private void btnRemoveStandRec_Click(object sender, EventArgs e)
  {
    if (this.lbStdUsers.SelectedItems.Count <= 0)
      return;
    this.DsUserSelectionEx.tblUsers.FindByUserGUID((Guid) ((DataRowView) this.lbStdUsers.Items[0]).Row["UserGuid"]).StdRecip = 0;
    this.DsUserSelectionEx.AcceptChanges();
  }
}

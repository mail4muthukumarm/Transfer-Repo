// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmNoteEditLog
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Data;
using MGASystems.Data.DbExtensions;
using System;
using System.Collections;
using System.Collections.Generic;
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

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public sealed class frmNoteEditLog : Form
{
  private IContainer components;
  private DbConnection cnSQL;
  private DbDataAdapter daEdits;
  private TextBox TextBox1;
  private Splitter Splitter1;
  private DbCommand DbSelectCommand1;
  private dsNoteEditLog DsNoteEditLog;
  private DbCommand DbSelectCommand2;
  private Guid _entryGUID;

  public frmNoteEditLog()
  {
    this.Load += new EventHandler(this.frmClaimNoteEditLog_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual ListBox ListBox1
  {
    get => this._ListBox1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ListBox1_SelectedIndexChanged);
      ListBox listBox1_1 = this._ListBox1;
      if (listBox1_1 != null)
        listBox1_1.SelectedIndexChanged -= eventHandler;
      this._ListBox1 = value;
      ListBox listBox1_2 = this._ListBox1;
      if (listBox1_2 == null)
        return;
      listBox1_2.SelectedIndexChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.daEdits = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand2 = DefaultDatabase.CreateCommand();
    this.cnSQL = DefaultDatabase.CreateDbConnection();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.ListBox1 = new ListBox();
    this.TextBox1 = new TextBox();
    this.Splitter1 = new Splitter();
    this.DsNoteEditLog = new dsNoteEditLog();
    this.DsNoteEditLog.BeginInit();
    this.SuspendLayout();
    this.daEdits.SelectCommand = this.DbSelectCommand2;
    this.daEdits.TableMappings.AddRange(new DataTableMapping[2]
    {
      new DataTableMapping("Table", "dbo_NoteSystem_GetEntryEdits", new DataColumnMapping[5]
      {
        new DataColumnMapping("Body", "Body"),
        new DataColumnMapping("FullName", "FullName"),
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("EditParent", "EditParent"),
        new DataColumnMapping("CreatedDate", "CreatedDate")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[5]
      {
        new DataColumnMapping("Body", "Body"),
        new DataColumnMapping("FullName", "FullName"),
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("EditParent", "EditParent"),
        new DataColumnMapping("CreatedDate", "CreatedDate")
      })
    });
    this.DbSelectCommand2.CommandText = "dbo.[NoteSystem_GetEntryEdits]";
    this.DbSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.DbSelectCommand2.Connection = this.cnSQL;
    DbParameterCollectionExtensions.DerivedAdd(this.DbSelectCommand2.Parameters, DefaultDatabase.CreateParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    DbParameterCollectionExtensions.DerivedAdd(this.DbSelectCommand2.Parameters, DefaultDatabase.CreateParameter("@EntryGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/));
    this.DbSelectCommand1.CommandText = "[NoteSystem_GetEntryEdits]";
    this.DbSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.DbSelectCommand1.Connection = this.cnSQL;
    DbParameterCollectionExtensions.DerivedAdd(this.DbSelectCommand1.Parameters, DefaultDatabase.CreateParameter("@NoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "NoteGUID"));
    this.ListBox1.BackColor = Color.White;
    this.ListBox1.Dock = DockStyle.Left;
    this.ListBox1.ForeColor = Color.Black;
    this.ListBox1.IntegralHeight = false;
    this.ListBox1.Items.AddRange(new object[1]
    {
      (object) "No Edits On This Entry"
    });
    this.ListBox1.Location = new Point(0, 0);
    this.ListBox1.Name = "ListBox1";
    this.ListBox1.Size = new Size(232, 302);
    this.ListBox1.TabIndex = 0;
    this.TextBox1.BackColor = Color.White;
    this.TextBox1.Dock = DockStyle.Fill;
    this.TextBox1.ForeColor = Color.Black;
    this.TextBox1.Location = new Point(232, 0);
    this.TextBox1.Multiline = true;
    this.TextBox1.Name = "TextBox1";
    this.TextBox1.ReadOnly = true;
    this.TextBox1.ScrollBars = ScrollBars.Vertical;
    this.TextBox1.Size = new Size(264, 302);
    this.TextBox1.TabIndex = 1;
    this.TextBox1.Text = "";
    this.Splitter1.Location = new Point(232, 0);
    this.Splitter1.Name = "Splitter1";
    this.Splitter1.Size = new Size(2, 302);
    this.Splitter1.TabIndex = 2;
    this.Splitter1.TabStop = false;
    this.DsNoteEditLog.DataSetName = "dsNoteEditLog";
    this.DsNoteEditLog.Locale = new CultureInfo("en-US");
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(496, 302);
    this.Controls.Add((Control) this.Splitter1);
    this.Controls.Add((Control) this.TextBox1);
    this.Controls.Add((Control) this.ListBox1);
    this.Font = new Font("Tahoma", 8.25f);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmNoteEditLog);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Entry Edit Log";
    this.DsNoteEditLog.EndInit();
    this.ResumeLayout(false);
  }

  public frmNoteEditLog(Guid entryGUID)
    : this()
  {
    this._entryGUID = entryGUID;
  }

  private void frmClaimNoteEditLog_Load(object sender, EventArgs e)
  {
    this.daEdits.SelectCommand.Parameters["@EntryGUID"].Value = (object) this._entryGUID;
    DefaultDatabase.DataAdapterFill(this.daEdits, (DataTable) this.DsNoteEditLog.tblNoteEntries);
    this.ListBox1.Items.Clear();
    dsNoteEditLog.tblNoteEntriesDataTable entriesDataTable = frmNoteEditLog.SortEntriesTable(this.DsNoteEditLog.tblNoteEntries);
    try
    {
      foreach (dsNoteEditLog.tblNoteEntriesRow row in entriesDataTable.Rows)
        this.ListBox1.Items.Add((object) new frmNoteEditLog.UserEditDisplayString(row));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (this.ListBox1.Items.Count <= 0)
      return;
    this.ListBox1.SelectedItem = RuntimeHelpers.GetObjectValue(this.ListBox1.Items[0]);
  }

  private static dsNoteEditLog.tblNoteEntriesDataTable SortEntriesTable(
    dsNoteEditLog.tblNoteEntriesDataTable tbl)
  {
    dsNoteEditLog.tblNoteEntriesDataTable entriesDataTable1;
    if (tbl.Rows.Count == 0 || tbl.Rows.Count == 1)
    {
      entriesDataTable1 = tbl;
    }
    else
    {
      List<DataRow> dataRowList = new List<DataRow>();
      DataRow[] dataRowArray1 = tbl.Select("EditParent IS NULL");
      if (dataRowArray1.Length >= 1)
      {
        dataRowList.Add(dataRowArray1[0]);
        int count = tbl.Rows.Count;
        for (int index = 0; index <= count; ++index)
        {
          dsNoteEditLog.tblNoteEntriesRow tblNoteEntriesRow = (dsNoteEditLog.tblNoteEntriesRow) dataRowList[index];
          DataRow[] dataRowArray2 = tbl.Select($"EditParent = '{tblNoteEntriesRow.ID.ToString()}'");
          if (dataRowArray2.Length >= 1)
          {
            dataRowList.Add(dataRowArray2[0]);
            if (index > tbl.Rows.Count - 1)
              break;
          }
          else
            break;
        }
      }
      dsNoteEditLog.tblNoteEntriesDataTable entriesDataTable2 = new dsNoteEditLog.tblNoteEntriesDataTable();
      try
      {
        foreach (DataRow dataRow in dataRowList)
          entriesDataTable2.Rows.Add(dataRow.ItemArray);
      }
      finally
      {
        List<DataRow>.Enumerator enumerator;
        enumerator.Dispose();
      }
      entriesDataTable1 = entriesDataTable2;
    }
    return entriesDataTable1;
  }

  private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.TextBox1.Text = ((frmNoteEditLog.UserEditDisplayString) this.ListBox1.SelectedItem).Body;
  }

  private sealed class UserEditDisplayString
  {
    private dsNoteEditLog.tblNoteEntriesRow _logRow;

    public UserEditDisplayString(dsNoteEditLog.tblNoteEntriesRow logRow) => this._logRow = logRow;

    public string Body => this._logRow.Body;

    public override string ToString()
    {
      string fullName = this._logRow.FullName;
      DateTime createdDate = this._logRow.CreatedDate;
      string shortDateString = createdDate.ToShortDateString();
      createdDate = this._logRow.CreatedDate;
      string shortTimeString = createdDate.ToShortTimeString();
      return $"{fullName}, {shortDateString} [{shortTimeString}]";
    }
  }
}

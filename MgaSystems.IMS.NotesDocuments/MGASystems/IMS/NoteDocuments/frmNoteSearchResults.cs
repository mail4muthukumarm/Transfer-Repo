// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmNoteSearchResults
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinProgressBar;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmNoteSearchResults : Form
{
  private IContainer components;
  private UltraExplorerBar UltraExplorerBar1;
  private UltraExplorerBarContainerControl UltraExplorerBarContainerControl1;
  private Label lblStatus;
  private UltraProgressBar UltraProgressBar1;
  private ColumnHeader ColumnHeader6;
  private ColumnHeader ColumnHeader7;
  private ImageList ImageList1;
  private ColumnHeader ColumnHeader1;
  public ColumnHeader ColumnHeader2;
  public ColumnHeader ColumnHeader3;
  private bool _searchInProgress;
  private int _recordCount;
  private frmNoteSearchResults.ListViewSortComparer _listViewSorter;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual ListView ListView1
  {
    get => this._ListView1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ListView1_DoubleClick);
      ColumnClickEventHandler clickEventHandler = new ColumnClickEventHandler(this.ListView1_ColumnClick);
      ListView listView1_1 = this._ListView1;
      if (listView1_1 != null)
      {
        listView1_1.DoubleClick -= eventHandler;
        listView1_1.ColumnClick -= clickEventHandler;
      }
      this._ListView1 = value;
      ListView listView1_2 = this._ListView1;
      if (listView1_2 == null)
        return;
      listView1_2.DoubleClick += eventHandler;
      listView1_2.ColumnClick += clickEventHandler;
    }
  }

  [field: AccessedThroughProperty("DueDate")]
  public virtual ColumnHeader DueDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("AssociatedEntity")]
  public virtual ColumnHeader AssociatedEntity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnStop
  {
    get => this._btnStop;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnStop_Click);
      MGAButton btnStop1 = this._btnStop;
      if (btnStop1 != null)
        ((Control) btnStop1).Click -= eventHandler;
      this._btnStop = value;
      MGAButton btnStop2 = this._btnStop;
      if (btnStop2 == null)
        return;
      ((Control) btnStop2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance = new Appearance();
    UltraExplorerBarGroup explorerBarGroup = new UltraExplorerBarGroup();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmNoteSearchResults));
    this.UltraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.btnStop = new MGAButton();
    this.lblStatus = new Label();
    this.UltraProgressBar1 = new UltraProgressBar();
    this.UltraExplorerBar1 = new UltraExplorerBar();
    this.ListView1 = new ListView();
    this.ColumnHeader6 = new ColumnHeader();
    this.ColumnHeader7 = new ColumnHeader();
    this.ColumnHeader1 = new ColumnHeader();
    this.ColumnHeader2 = new ColumnHeader();
    this.ColumnHeader3 = new ColumnHeader();
    this.DueDate = new ColumnHeader();
    this.AssociatedEntity = new ColumnHeader();
    this.ImageList1 = new ImageList(this.components);
    ((Control) this.UltraExplorerBarContainerControl1).SuspendLayout();
    ((ISupportInitialize) this.btnStop).BeginInit();
    ((ISupportInitialize) this.UltraExplorerBar1).BeginInit();
    ((Control) this.UltraExplorerBar1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.btnStop);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.lblStatus);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.UltraProgressBar1);
    ((Control) this.UltraExplorerBarContainerControl1).Location = new Point(28, 24);
    ((Control) this.UltraExplorerBarContainerControl1).Name = "UltraExplorerBarContainerControl1";
    ((Control) this.UltraExplorerBarContainerControl1).Size = new Size(475, 56);
    ((Control) this.UltraExplorerBarContainerControl1).TabIndex = 0;
    appearance.BackColor = Color.FromArgb(248, 248, 248);
    appearance.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance.BackGradientStyle = (GradientStyle) 2;
    appearance.BorderColor = Color.DarkGray;
    appearance.ImageHAlign = (HAlign) 2;
    appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnStop).Appearance = (AppearanceBase) appearance;
    ((Control) this.btnStop).Location = new Point(416, 32 /*0x20*/);
    ((Control) this.btnStop).Name = "btnStop";
    ((Control) this.btnStop).Size = new Size(48 /*0x30*/, 24);
    ((Control) this.btnStop).TabIndex = 3;
    ((ControlBase) this.btnStop).Text = "Stop";
    this.btnStop.UseOSThemes = (DefaultableBoolean) 2;
    this.lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblStatus.AutoSize = true;
    this.lblStatus.BackColor = Color.Transparent;
    this.lblStatus.Location = new Point(8, 27);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size((int) sbyte.MaxValue, 13);
    this.lblStatus.TabIndex = 2;
    this.lblStatus.Text = "Searching, please wait...";
    ((Control) this.UltraProgressBar1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraProgressBar1).Location = new Point(8, 11);
    ((Control) this.UltraProgressBar1).Name = "UltraProgressBar1";
    ((Control) this.UltraProgressBar1).Size = new Size(460, 10);
    ((Control) this.UltraProgressBar1).TabIndex = 0;
    this.UltraProgressBar1.Text = "[Formatted]";
    this.UltraProgressBar1.TextVisible = false;
    ((Control) this.UltraExplorerBar1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl1);
    explorerBarGroup.Container = this.UltraExplorerBarContainerControl1;
    explorerBarGroup.Settings.ContainerHeight = 56;
    explorerBarGroup.Settings.HeaderVisible = (DefaultableBoolean) 2;
    explorerBarGroup.Settings.Style = (GroupStyle) 6;
    explorerBarGroup.Text = "New Group";
    this.UltraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[1]
    {
      explorerBarGroup
    });
    ((Control) this.UltraExplorerBar1).Location = new Point(0, 432);
    ((Control) this.UltraExplorerBar1).Name = "UltraExplorerBar1";
    this.UltraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.UltraExplorerBar1).Size = new Size(524, 104);
    ((Control) this.UltraExplorerBar1).TabIndex = 3;
    this.ListView1.AllowColumnReorder = true;
    this.ListView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ListView1.BackColor = Color.White;
    this.ListView1.BorderStyle = BorderStyle.None;
    this.ListView1.Columns.AddRange(new ColumnHeader[7]
    {
      this.ColumnHeader6,
      this.ColumnHeader7,
      this.ColumnHeader1,
      this.ColumnHeader2,
      this.ColumnHeader3,
      this.DueDate,
      this.AssociatedEntity
    });
    this.ListView1.ForeColor = Color.Black;
    this.ListView1.HideSelection = false;
    this.ListView1.LargeImageList = this.ImageList1;
    this.ListView1.Location = new Point(0, -1);
    this.ListView1.Name = "ListView1";
    this.ListView1.Size = new Size(524, 425);
    this.ListView1.SmallImageList = this.ImageList1;
    this.ListView1.TabIndex = 2;
    this.ListView1.UseCompatibleStateImageBehavior = false;
    this.ListView1.View = View.Details;
    this.ColumnHeader6.Text = "Subject";
    this.ColumnHeader6.Width = 287;
    this.ColumnHeader7.Text = "Created Date";
    this.ColumnHeader7.Width = 102;
    this.ColumnHeader1.Text = "Created By";
    this.ColumnHeader1.Width = 124;
    this.ColumnHeader2.Text = "Completed Date";
    this.ColumnHeader2.Width = 120;
    this.ColumnHeader3.Text = "Completed by";
    this.ColumnHeader3.Width = 120;
    this.DueDate.Text = "Due Date";
    this.DueDate.Width = 120;
    this.AssociatedEntity.Text = "Associated Entity ID";
    this.AssociatedEntity.Width = 120;
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Magenta;
    this.ImageList1.Images.SetKeyName(0, "");
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(524, 534);
    this.Controls.Add((Control) this.UltraExplorerBar1);
    this.Controls.Add((Control) this.ListView1);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmNoteSearchResults);
    this.Text = "Searching, Please wait...";
    ((Control) this.UltraExplorerBarContainerControl1).ResumeLayout(false);
    ((Control) this.UltraExplorerBarContainerControl1).PerformLayout();
    ((ISupportInitialize) this.btnStop).EndInit();
    ((ISupportInitialize) this.UltraExplorerBar1).EndInit();
    ((Control) this.UltraExplorerBar1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public frmNoteSearchResults()
  {
    this._listViewSorter = new frmNoteSearchResults.ListViewSortComparer();
    this.InitializeComponent();
  }

  public void DoSearch(string sqlSearch, string sqlCount, bool displayProgress)
  {
    if (this._searchInProgress)
      return;
    ((Control) this.btnStop).Visible = true;
    this.Visible = true;
    this._searchInProgress = true;
    this.ListView1.Items.Clear();
    if (displayProgress)
    {
      this.Text = "Note Search Results";
      ((Control) this.UltraProgressBar1).Visible = true;
      ((Control) this.btnStop).Visible = true;
      this._recordCount = Database.Instance.QueryText.PerformScalarQueryInt(sqlCount);
      this.lblStatus.Text = $"{this._recordCount} results found matching your criteria";
      Database.Instance.QueryMultithreadedText.PerformTableQuery(new TableQueryMultithreadEventHandler(this.QueryCompleted), new TableFillingEventHandler(this.SearchProgress), (Control) this, (object) "Note Search", sqlSearch);
    }
    else
    {
      ((Control) this.UltraProgressBar1).Visible = false;
      ((Control) this.btnStop).Visible = false;
      Database.Instance.QueryMultithreadedText.PerformTableQuery(new TableQueryMultithreadEventHandler(this.QueryCompleted), (Control) this, (object) "Note Search", sqlSearch);
    }
  }

  private void SearchProgress(object sender, TableFillingEventArgs e)
  {
    if (((Control) this.UltraProgressBar1).Visible && !((Control) this.btnStop).Visible)
    {
      e.StopFill = true;
    }
    else
    {
      UltraProgressBar ultraProgressBar1 = this.UltraProgressBar1;
      ultraProgressBar1.Maximum = this._recordCount - 1;
      ultraProgressBar1.Minimum = 0;
      ultraProgressBar1.Value = (int) e.CurrentRow;
      if (!((Control) this.btnStop).Visible)
        e.Cancel = true;
      this.ListView1.Items.Add((ListViewItem) new frmNoteSearchResults.NoteListItem(e.Row));
    }
  }

  private void DisplaySearchResults(DataTable tbl)
  {
    if (!((Control) this.UltraProgressBar1).Visible)
    {
      this.Text = "Note Search Results";
      try
      {
        foreach (DataRow row in tbl.Rows)
          this.ListView1.Items.Add((ListViewItem) new frmNoteSearchResults.NoteListItem(row));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.lblStatus.Text = $"{tbl.Rows.Count} results found matching your criteria";
    }
    else
      this.lblStatus.Text = $"{tbl.Rows.Count} results found matching your criteria";
  }

  private void QueryCompleted(object sender, TableQueryMultithreadEventArgs e)
  {
    this.DisplaySearchResults(e.Table);
    ((Control) this.btnStop).Visible = false;
    this.lblStatus.Text = $"{e.Table.Rows.Count} results found matching your criteria";
    this._searchInProgress = false;
  }

  private void btnStop_Click(object sender, EventArgs e)
  {
    ((Control) this.btnStop).Visible = false;
  }

  private void ListView1_DoubleClick(object sender, EventArgs e)
  {
    Point client = this.ListView1.PointToClient(Cursor.Position);
    if (!(this.ListView1.GetItemAt(client.X, client.Y) is frmNoteSearchResults.NoteListItem itemAt))
      return;
    this.DisplayNote(itemAt.NoteGUID);
  }

  [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "0#")]
  protected virtual void DisplayNote(Guid noteGUID)
  {
    Note_System.Instance.UIInteractive.ViewNote(noteGUID);
  }

  private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
  {
    frmNoteSearchResults.ListViewSortComparer listViewSorter1 = this._listViewSorter;
    listViewSorter1.ColumnIndex = e.Column;
    listViewSorter1.SortAsType = e.Column == 0 || e.Column == 2 || e.Column == 4 || e.Column == 5 || e.Column == 6 ? typeof (string) : typeof (DateTime);
    this.ListView1.ListViewItemSorter = (IComparer) this._listViewSorter;
    frmNoteSearchResults.ListViewSortComparer listViewSorter2 = this._listViewSorter;
    if (listViewSorter2.Sorting == SortOrder.None || listViewSorter2.Sorting == SortOrder.Descending)
      listViewSorter2.Sorting = SortOrder.Ascending;
    else if (listViewSorter2.Sorting == SortOrder.Ascending)
      listViewSorter2.Sorting = SortOrder.Descending;
    this.ListView1.Sort();
  }

  private sealed class NoteListItem : ListViewItem
  {
    private Guid _noteGUID;
    private DateTime _createdDate;
    private string _createdBy;
    private DateTime _CompletedDate;
    private string _CompletedBy;
    private string _DueDate;
    private string _AssociatedEntity;

    public NoteListItem(DataRow row)
      : base(Conversions.ToString(row["Subject"]))
    {
      this._DueDate = string.Empty;
      this._AssociatedEntity = string.Empty;
      object obj = row["ID"];
      this._noteGUID = obj != null ? (Guid) obj : new Guid();
      this._createdDate = Conversions.ToDate(row["CreatedDate"]);
      this._createdBy = Conversions.ToString(row["FullName"]);
      if (row.Table.Columns.Contains("CompletedDate") && row["CompletedDate"] != null && row["CompletedDate"] != DBNull.Value)
        this._CompletedDate = Conversions.ToDate(row["CompletedDate"]);
      if (row.Table.Columns.Contains("CompletedBy") && row["CompletedBy"] != null && row["CompletedBy"] != DBNull.Value)
        this._CompletedBy = Conversions.ToString(row["CompletedBy"]);
      if (row.Table.Columns.Contains("DueDate") && row["DueDate"] != null && row["DueDate"] != DBNull.Value)
        this._DueDate = Conversions.ToDate(row["DueDate"]).ToShortDateString();
      if (row.Table.Columns.Contains("AssociatedEntity") && row["AssociatedEntity"] != null && row["AssociatedEntity"] != DBNull.Value)
        this._AssociatedEntity = Conversions.ToString(row["AssociatedEntity"]);
      this.ImageIndex = 0;
      this.SubItems.Add(this._createdDate.ToShortDateString());
      this.SubItems.Add(this._createdBy);
      this.SubItems.Add(this._CompletedDate.ToShortDateString());
      this.SubItems.Add(this._CompletedBy);
      this.SubItems.Add(this._DueDate);
      this.SubItems.Add(this._AssociatedEntity.ToString());
    }

    public Guid NoteGUID => this._noteGUID;
  }

  private sealed class ListViewSortComparer : IComparer
  {
    private Type _columnType;
    private int _columnIndex;
    private SortOrder _sortOrder;

    public ListViewSortComparer()
    {
      this._columnIndex = -1;
      this._sortOrder = SortOrder.None;
    }

    public SortOrder Sorting
    {
      get => this._sortOrder;
      set => this._sortOrder = value;
    }

    public int ColumnIndex
    {
      set => this._columnIndex = value;
    }

    public Type SortAsType
    {
      set => this._columnType = value;
    }

    private static long LongFromString(string str)
    {
      StringBuilder stringBuilder = new StringBuilder();
      char[] charArray = str.ToCharArray();
      int index = 0;
      while (index < charArray.Length)
      {
        char c = charArray[index];
        if (char.IsDigit(c) || char.IsNumber(c) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(c), ".", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(c), ",", false) == 0)
          stringBuilder.Append(c);
        checked { ++index; }
      }
      return Conversions.ToLong(stringBuilder.ToString());
    }

    public int Compare(object x, object y)
    {
      if (x == null)
        throw new ArgumentNullException(nameof (x));
      if (y == null)
        throw new ArgumentNullException(nameof (y));
      x = (object) ((ListViewItem) x).SubItems[this._columnIndex].Text;
      y = (object) ((ListViewItem) y).SubItems[this._columnIndex].Text;
      int num1;
      if (this._columnType.Equals(typeof (string)))
        num1 = string.Compare(Conversions.ToString(x), Conversions.ToString(y));
      else if (this._columnType.Equals(typeof (DateTime)))
        num1 = DateTime.Compare(Conversions.ToDate(x), Conversions.ToDate(y));
      else if (this._columnType.Equals(typeof (long)))
      {
        long num2 = frmNoteSearchResults.ListViewSortComparer.LongFromString(Conversions.ToString(x));
        long num3 = frmNoteSearchResults.ListViewSortComparer.LongFromString(Conversions.ToString(y));
        num1 = num2 <= num3 ? (num2 >= num3 ? 0 : -1) : 1;
      }
      else
        num1 = 0;
      int num4;
      switch (this._sortOrder)
      {
        case SortOrder.None:
          num4 = 0;
          break;
        case SortOrder.Ascending:
          num4 = num1;
          break;
        case SortOrder.Descending:
          num4 = num1 * -1;
          break;
      }
      return num4;
    }
  }
}

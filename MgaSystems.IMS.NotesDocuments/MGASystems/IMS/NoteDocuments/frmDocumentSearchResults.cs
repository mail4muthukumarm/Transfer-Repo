// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmDocumentSearchResults
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinProgressBar;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.DockingManagement;
using MGASystems.Common.NativeWindowMethods;
using MGASystems.Common.NativeWindowMethods.SafeAPICalls;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.NoteDocuments.Serialization;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
[Preference("Screens.DocumentSearchResults.ViewStyle", typeof (View), "Details")]
public sealed class frmDocumentSearchResults : Form, ISupportDocumentSystem
{
  internal const string Preference_ResultViewStyle = "Screens.DocumentSearchResults.ViewStyle";
  private IContainer components;
  private ImageList smallImages;
  private ImageList largeImages;
  private ColumnHeader ColumnHeader1;
  private ColumnHeader ColumnHeader2;
  private ColumnHeader ColumnHeader3;
  private UltraExplorerBar UltraExplorerBar1;
  private UltraExplorerBarContainerControl UltraExplorerBarContainerControl1;
  private UltraProgressBar UltraProgressBar1;
  private ColumnHeader ColumnHeader4;
  private ColumnHeader ColumnHeader5;
  private MenuItem MenuItem1;
  private Label lblStatus;
  private ZipUtility ZipUtility1;
  private FolderBrowserDialog FolderBrowserDialog1;
  private Label lblSrchStats;
  private MenuItem MenuItem3;
  private Guid _lastSearchKey;
  private frmDocumentSearchResults.DocumentImageListInitializer _documentListInitializer;
  private bool _lastSearchDisplaysProgress;
  private string _lastCriteria;
  private bool _lastDispProg;
  private bool _searchInProgress;
  private long _totalRows;
  private int _lastPercentage;
  private double _rowMultiplier;
  private TempFileCollection _tempFileCollection;
  private Rectangle dragBoxFromMouseDown;
  private ISupportDocumentSystem _lastFormSupportingDocSystem;
  private frmDocumentSearchResults.ListViewSortComparer _listViewSorter;

  public frmDocumentSearchResults()
  {
    this.Load += new EventHandler(this.frmDocumentSearchResults_Load);
    this.Closing += new CancelEventHandler(this.frmDocumentSearchResults_Closing);
    this.Activated += new EventHandler(this.frmDocumentSearchResults_Activated);
    this._lastSearchKey = Guid.Empty;
    this._listViewSorter = new frmDocumentSearchResults.ListViewSortComparer();
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    this.CleanUpDynamicMenuItems();
    if (this._documentListInitializer != null)
      this._documentListInitializer.Dispose();
    base.Dispose(disposing);
  }

  private virtual ListView ListView1
  {
    get => this._ListView1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ListView1_DoubleClick);
      MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.ListView1_MouseDown);
      MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.ListView1_MouseUp);
      MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.ListView1_MouseMove);
      ColumnClickEventHandler clickEventHandler = new ColumnClickEventHandler(this.ListView1_ColumnClick);
      ListView listView1_1 = this._ListView1;
      if (listView1_1 != null)
      {
        listView1_1.DoubleClick -= eventHandler;
        listView1_1.MouseDown -= mouseEventHandler1;
        listView1_1.MouseUp -= mouseEventHandler2;
        listView1_1.MouseMove -= mouseEventHandler3;
        listView1_1.ColumnClick -= clickEventHandler;
      }
      this._ListView1 = value;
      ListView listView1_2 = this._ListView1;
      if (listView1_2 == null)
        return;
      listView1_2.DoubleClick += eventHandler;
      listView1_2.MouseDown += mouseEventHandler1;
      listView1_2.MouseUp += mouseEventHandler2;
      listView1_2.MouseMove += mouseEventHandler3;
      listView1_2.ColumnClick += clickEventHandler;
    }
  }

  private virtual ContextMenu ContextMenu1
  {
    get => this._ContextMenu1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ContextMenu1_Popup);
      ContextMenu contextMenu1_1 = this._ContextMenu1;
      if (contextMenu1_1 != null)
        contextMenu1_1.Popup -= eventHandler;
      this._ContextMenu1 = value;
      ContextMenu contextMenu1_2 = this._ContextMenu1;
      if (contextMenu1_2 == null)
        return;
      contextMenu1_2.Popup += eventHandler;
    }
  }

  private virtual MenuItem mnuLargeIcons
  {
    get => this._mnuLargeIcons;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuLargeIcons_Click);
      MenuItem mnuLargeIcons1 = this._mnuLargeIcons;
      if (mnuLargeIcons1 != null)
        mnuLargeIcons1.Click -= eventHandler;
      this._mnuLargeIcons = value;
      MenuItem mnuLargeIcons2 = this._mnuLargeIcons;
      if (mnuLargeIcons2 == null)
        return;
      mnuLargeIcons2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuSmallIcons
  {
    get => this._mnuSmallIcons;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuSmallIcons_Click);
      MenuItem mnuSmallIcons1 = this._mnuSmallIcons;
      if (mnuSmallIcons1 != null)
        mnuSmallIcons1.Click -= eventHandler;
      this._mnuSmallIcons = value;
      MenuItem mnuSmallIcons2 = this._mnuSmallIcons;
      if (mnuSmallIcons2 == null)
        return;
      mnuSmallIcons2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuDetails
  {
    get => this._mnuDetails;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuDetails_Click);
      MenuItem mnuDetails1 = this._mnuDetails;
      if (mnuDetails1 != null)
        mnuDetails1.Click -= eventHandler;
      this._mnuDetails = value;
      MenuItem mnuDetails2 = this._mnuDetails;
      if (mnuDetails2 == null)
        return;
      mnuDetails2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuList
  {
    get => this._mnuList;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuList_Click);
      MenuItem mnuList1 = this._mnuList;
      if (mnuList1 != null)
        mnuList1.Click -= eventHandler;
      this._mnuList = value;
      MenuItem mnuList2 = this._mnuList;
      if (mnuList2 == null)
        return;
      mnuList2.Click += eventHandler;
    }
  }

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

  private virtual MenuItem mnuOpenDoc
  {
    get => this._mnuOpenDoc;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuOpenDoc_Click);
      MenuItem mnuOpenDoc1 = this._mnuOpenDoc;
      if (mnuOpenDoc1 != null)
        mnuOpenDoc1.Click -= eventHandler;
      this._mnuOpenDoc = value;
      MenuItem mnuOpenDoc2 = this._mnuOpenDoc;
      if (mnuOpenDoc2 == null)
        return;
      mnuOpenDoc2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuOpenDocProperties
  {
    get => this._mnuOpenDocProperties;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuOpenDocProperties_Click);
      MenuItem openDocProperties1 = this._mnuOpenDocProperties;
      if (openDocProperties1 != null)
        openDocProperties1.Click -= eventHandler;
      this._mnuOpenDocProperties = value;
      MenuItem openDocProperties2 = this._mnuOpenDocProperties;
      if (openDocProperties2 == null)
        return;
      openDocProperties2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuZipAndEmail
  {
    get => this._mnuZipAndEmail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuZipAndEmail_Click);
      MenuItem mnuZipAndEmail1 = this._mnuZipAndEmail;
      if (mnuZipAndEmail1 != null)
        mnuZipAndEmail1.Click -= eventHandler;
      this._mnuZipAndEmail = value;
      MenuItem mnuZipAndEmail2 = this._mnuZipAndEmail;
      if (mnuZipAndEmail2 == null)
        return;
      mnuZipAndEmail2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuDeleteDocs
  {
    get => this._mnuDeleteDocs;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuDeleteDocs_Click);
      MenuItem mnuDeleteDocs1 = this._mnuDeleteDocs;
      if (mnuDeleteDocs1 != null)
        mnuDeleteDocs1.Click -= eventHandler;
      this._mnuDeleteDocs = value;
      MenuItem mnuDeleteDocs2 = this._mnuDeleteDocs;
      if (mnuDeleteDocs2 == null)
        return;
      mnuDeleteDocs2.Click += eventHandler;
    }
  }

  private virtual BackgroundWorker bwSearch
  {
    get => this._bwSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.bwSearch_DoWork);
      ProgressChangedEventHandler changedEventHandler = new ProgressChangedEventHandler(this.bwSearch_ProgressChanged);
      RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.bwSearch_RunWorkerCompleted);
      BackgroundWorker bwSearch1 = this._bwSearch;
      if (bwSearch1 != null)
      {
        bwSearch1.DoWork -= workEventHandler;
        bwSearch1.ProgressChanged -= changedEventHandler;
        bwSearch1.RunWorkerCompleted -= completedEventHandler;
      }
      this._bwSearch = value;
      BackgroundWorker bwSearch2 = this._bwSearch;
      if (bwSearch2 == null)
        return;
      bwSearch2.DoWork += workEventHandler;
      bwSearch2.ProgressChanged += changedEventHandler;
      bwSearch2.RunWorkerCompleted += completedEventHandler;
    }
  }

  internal virtual MenuItem mnuPinDocument
  {
    get => this._mnuPinDocument;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuPinDocument_Click);
      MenuItem mnuPinDocument1 = this._mnuPinDocument;
      if (mnuPinDocument1 != null)
        mnuPinDocument1.Click -= eventHandler;
      this._mnuPinDocument = value;
      MenuItem mnuPinDocument2 = this._mnuPinDocument;
      if (mnuPinDocument2 == null)
        return;
      mnuPinDocument2.Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance = new Appearance();
    UltraExplorerBarGroup explorerBarGroup = new UltraExplorerBarGroup();
    this.UltraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.lblSrchStats = new Label();
    this.lblStatus = new Label();
    this.btnStop = new MGAButton();
    this.UltraProgressBar1 = new UltraProgressBar();
    this.ListView1 = new ListView();
    this.ColumnHeader1 = new ColumnHeader();
    this.ColumnHeader2 = new ColumnHeader();
    this.ColumnHeader3 = new ColumnHeader();
    this.ColumnHeader4 = new ColumnHeader();
    this.ColumnHeader5 = new ColumnHeader();
    this.ContextMenu1 = new ContextMenu();
    this.mnuOpenDoc = new MenuItem();
    this.MenuItem1 = new MenuItem();
    this.MenuItem3 = new MenuItem();
    this.mnuDetails = new MenuItem();
    this.mnuList = new MenuItem();
    this.mnuLargeIcons = new MenuItem();
    this.mnuSmallIcons = new MenuItem();
    this.mnuOpenDocProperties = new MenuItem();
    this.mnuZipAndEmail = new MenuItem();
    this.mnuDeleteDocs = new MenuItem();
    this.mnuPinDocument = new MenuItem();
    this.smallImages = new ImageList(this.components);
    this.largeImages = new ImageList(this.components);
    this.UltraExplorerBar1 = new UltraExplorerBar();
    this.FolderBrowserDialog1 = new FolderBrowserDialog();
    this.bwSearch = new BackgroundWorker();
    ((Control) this.UltraExplorerBarContainerControl1).SuspendLayout();
    ((ISupportInitialize) this.btnStop).BeginInit();
    ((ISupportInitialize) this.UltraExplorerBar1).BeginInit();
    ((Control) this.UltraExplorerBar1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.lblSrchStats);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.lblStatus);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.btnStop);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.UltraProgressBar1);
    ((Control) this.UltraExplorerBarContainerControl1).Location = new Point(28, 24);
    ((Control) this.UltraExplorerBarContainerControl1).Name = "UltraExplorerBarContainerControl1";
    ((Control) this.UltraExplorerBarContainerControl1).Size = new Size(487, 64 /*0x40*/);
    ((Control) this.UltraExplorerBarContainerControl1).TabIndex = 0;
    this.lblSrchStats.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblSrchStats.AutoSize = true;
    this.lblSrchStats.BackColor = Color.Transparent;
    this.lblSrchStats.Location = new Point(8, 51);
    this.lblSrchStats.Name = "lblSrchStats";
    this.lblSrchStats.Size = new Size(205, 13);
    this.lblSrchStats.TabIndex = 3;
    this.lblSrchStats.Text = "Compiling search statistics, please wait...";
    this.lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblStatus.AutoSize = true;
    this.lblStatus.BackColor = Color.Transparent;
    this.lblStatus.Location = new Point(8, 35);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size((int) sbyte.MaxValue, 13);
    this.lblStatus.TabIndex = 2;
    this.lblStatus.Text = "Searching, please wait...";
    ((Control) this.btnStop).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance.BackColor = Color.FromArgb(248, 248, 248);
    appearance.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance.BackGradientStyle = (GradientStyle) 2;
    appearance.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnStop).Appearance = (AppearanceBase) appearance;
    ((Control) this.btnStop).Location = new Point(384, 39);
    ((Control) this.btnStop).Name = "btnStop";
    ((Control) this.btnStop).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.btnStop).TabIndex = 1;
    ((ControlBase) this.btnStop).Text = "Stop";
    this.btnStop.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraProgressBar1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraProgressBar1).Location = new Point(8, 19);
    ((Control) this.UltraProgressBar1).Name = "UltraProgressBar1";
    ((Control) this.UltraProgressBar1).Size = new Size(472, 10);
    ((Control) this.UltraProgressBar1).TabIndex = 0;
    this.UltraProgressBar1.Text = "[Formatted]";
    this.UltraProgressBar1.TextVisible = false;
    this.ListView1.AllowColumnReorder = true;
    this.ListView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ListView1.BackColor = Color.White;
    this.ListView1.BorderStyle = BorderStyle.None;
    this.ListView1.Columns.AddRange(new ColumnHeader[5]
    {
      this.ColumnHeader1,
      this.ColumnHeader2,
      this.ColumnHeader3,
      this.ColumnHeader4,
      this.ColumnHeader5
    });
    this.ListView1.ContextMenu = this.ContextMenu1;
    this.ListView1.ForeColor = Color.Black;
    this.ListView1.Location = new Point(0, 0);
    this.ListView1.Name = "ListView1";
    this.ListView1.Size = new Size(536, 424);
    this.ListView1.TabIndex = 0;
    this.ListView1.UseCompatibleStateImageBehavior = false;
    this.ListView1.View = View.Details;
    this.ColumnHeader1.Text = "File Name";
    this.ColumnHeader1.Width = 288;
    this.ColumnHeader2.Text = "Type";
    this.ColumnHeader2.Width = 51;
    this.ColumnHeader3.Text = "Date Added";
    this.ColumnHeader3.Width = 104;
    this.ColumnHeader4.Text = "Description";
    this.ColumnHeader4.Width = 101;
    this.ColumnHeader5.Text = "Size";
    this.ColumnHeader5.Width = 273;
    this.ContextMenu1.MenuItems.AddRange(new MenuItem[7]
    {
      this.mnuOpenDoc,
      this.MenuItem1,
      this.MenuItem3,
      this.mnuOpenDocProperties,
      this.mnuZipAndEmail,
      this.mnuDeleteDocs,
      this.mnuPinDocument
    });
    this.mnuOpenDoc.DefaultItem = true;
    this.mnuOpenDoc.Index = 0;
    this.mnuOpenDoc.Text = "Open Document";
    this.MenuItem1.Index = 1;
    this.MenuItem1.Text = "-";
    this.MenuItem3.Index = 2;
    this.MenuItem3.MenuItems.AddRange(new MenuItem[4]
    {
      this.mnuDetails,
      this.mnuList,
      this.mnuLargeIcons,
      this.mnuSmallIcons
    });
    this.MenuItem3.Text = "View";
    this.mnuDetails.Index = 0;
    this.mnuDetails.Text = "Details";
    this.mnuList.Index = 1;
    this.mnuList.Text = "List";
    this.mnuLargeIcons.Index = 2;
    this.mnuLargeIcons.Text = "Large Icons";
    this.mnuSmallIcons.Index = 3;
    this.mnuSmallIcons.Text = "Small Icons";
    this.mnuOpenDocProperties.Index = 3;
    this.mnuOpenDocProperties.Text = "Properties";
    this.mnuZipAndEmail.Index = 4;
    this.mnuZipAndEmail.Text = "Zip and Email";
    this.mnuDeleteDocs.Index = 5;
    this.mnuDeleteDocs.Text = "Delete";
    this.mnuPinDocument.Index = 6;
    this.mnuPinDocument.Text = "Pin Document";
    this.smallImages.ColorDepth = ColorDepth.Depth24Bit;
    this.smallImages.ImageSize = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.smallImages.TransparentColor = Color.Transparent;
    this.largeImages.ColorDepth = ColorDepth.Depth24Bit;
    this.largeImages.ImageSize = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.largeImages.TransparentColor = Color.Transparent;
    ((Control) this.UltraExplorerBar1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl1);
    explorerBarGroup.Container = this.UltraExplorerBarContainerControl1;
    explorerBarGroup.Settings.ContainerHeight = 64 /*0x40*/;
    explorerBarGroup.Settings.HeaderVisible = (DefaultableBoolean) 2;
    explorerBarGroup.Settings.Style = (GroupStyle) 6;
    this.UltraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[1]
    {
      explorerBarGroup
    });
    ((Control) this.UltraExplorerBar1).Location = new Point(0, 432);
    ((Control) this.UltraExplorerBar1).Name = "UltraExplorerBar1";
    this.UltraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.UltraExplorerBar1).Size = new Size(536, 112 /*0x70*/);
    ((Control) this.UltraExplorerBar1).TabIndex = 1;
    this.bwSearch.WorkerReportsProgress = true;
    this.bwSearch.WorkerSupportsCancellation = true;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(536, 542);
    this.Controls.Add((Control) this.UltraExplorerBar1);
    this.Controls.Add((Control) this.ListView1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmDocumentSearchResults);
    this.Text = "Searching, Please Wait...";
    ((Control) this.UltraExplorerBarContainerControl1).ResumeLayout(false);
    ((Control) this.UltraExplorerBarContainerControl1).PerformLayout();
    ((ISupportInitialize) this.btnStop).EndInit();
    ((ISupportInitialize) this.UltraExplorerBar1).EndInit();
    ((Control) this.UltraExplorerBar1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public void DoSearch(string criteria, bool displayProgress)
  {
    if (this._searchInProgress)
      return;
    this._lastCriteria = criteria;
    this._lastDispProg = displayProgress;
    string queryText1 = " SELECT CAST(SUM(CONVERT(BIGINT,ActualFileSize)) / 1048576.0 AS DECIMAL(38,2)) AS [COMPRESSED_MB_ON_SERVER], CAST(SUM(CONVERT(BIGINT,OriginalFileSize)) / 1048576.0 AS DECIMAL(38,2)) AS [UNCOMPRESSED_MB_ON_SERVER] FROM tblDocumentStore (NOLOCK)  ";
    this.lblSrchStats.Text = "Compiling search statistics, please wait...";
    this.lblStatus.Text = "Searching, Please wait...";
    this.Visible = true;
    string queryText2 = "SELECT DocumentStoreGuid, OriginalFileSize, FileName , Description, FileAssociation, DateAdded FROM tblDocumentStore (NOLOCK) ";
    string queryText3 = "SELECT COUNT(*) FROM tblDocumentStore (NOLOCK) ";
    switch (criteria)
    {
      case null:
        throw new ArgumentNullException(nameof (criteria));
      case "":
        this._lastSearchKey = Guid.NewGuid();
        ((Control) this.btnStop).Visible = true;
        this.ListView1.Items.Clear();
        this._lastSearchDisplaysProgress = displayProgress;
        this._searchInProgress = true;
        if (displayProgress)
        {
          this.Text = "Document Search Results";
          ((Control) this.UltraProgressBar1).Visible = true;
          ((Control) this.btnStop).Visible = true;
          this._totalRows = Conversions.ToLong(Database.Instance.QueryText.PerformScalarQuery(queryText3));
          this._rowMultiplier = 100.0 / (double) this._totalRows;
          this._lastPercentage = 0;
          if (this.bwSearch.IsBusy)
            this.bwSearch.CancelAsync();
          else
            this.bwSearch.RunWorkerAsync((object) queryText2);
        }
        else
        {
          ((Control) this.UltraProgressBar1).Visible = false;
          ((Control) this.btnStop).Visible = false;
          Database.Instance.QueryMultithreadedText.PerformTableQuery(new TableQueryMultithreadEventHandler(this.QueryCompleted), (Control) this, (object) this._lastSearchKey, queryText2);
        }
        Database.Instance.QueryMultithreadedText.PerformRowQuery((Control) this, (object) this._lastSearchKey, queryText1, new RowQueryMultithreadedEventHandler(this.rowQuery_Completed));
        break;
      default:
        queryText2 += criteria;
        queryText1 += criteria;
        queryText3 += criteria;
        goto case "";
    }
  }

  private void RefreshQuery()
  {
    if (this._searchInProgress)
      return;
    this.DoSearch(this._lastCriteria, this._lastDispProg);
  }

  private void rowQuery_Completed(object sender, RowQueryMultithreadedEventArgs e)
  {
    double num1 = Math.Round((double) Database.IsNull(RuntimeHelpers.GetObjectValue(e.Row["COMPRESSED_MB_ON_SERVER"]), 0), 2);
    double num2 = Math.Round((double) Database.IsNull(RuntimeHelpers.GetObjectValue(e.Row["UNCOMPRESSED_MB_ON_SERVER"]), 0), 2);
    double num3 = Math.Round(num1 / num2 * 100.0, 2);
    this.lblSrchStats.Text = $"Storage space used on server: {num1}(MB), compression level {100.0 - num3}%".Replace("NaN", "0");
  }

  private void SearchProgress(object sender, TableFillingEventArgs e)
  {
    long num = (long) Math.Round(this._rowMultiplier * (double) e.CurrentRow);
    if (num > 100L)
      num = 100L;
    if (num == (long) this._lastPercentage)
      return;
    this._lastPercentage = (int) num;
    this.bwSearch.ReportProgress(this._lastPercentage);
  }

  private void QueryCompleted(object sender, TableQueryMultithreadEventArgs e)
  {
    this.HandleQueryResults(e.Table);
  }

  private void DisplaySearchResults(DataTable tbl)
  {
    this.Text = "Document Search Results";
    frmDocumentSearchResults.DocumentImageListInitializer imageListInitializer = new frmDocumentSearchResults.DocumentImageListInitializer(this.smallImages, this.largeImages, this.ListView1);
    try
    {
      foreach (DataRow row in tbl.Rows)
      {
        Guid documentGuid = (Guid) row["DocumentStoreGuid"];
        int integer = Conversions.ToInteger(row["OriginalFileSize"]);
        string fileName = Conversions.ToString(row["FileName"]);
        string description = Conversions.ToString(row["Description"]);
        string fileAssociation = Conversions.ToString(row["FileAssociation"]);
        DateTime date = Conversions.ToDate(row["DateAdded"]);
        imageListInitializer.AddItem(fileName, integer, documentGuid, description, fileAssociation, date);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.lblStatus.Text = $"{tbl.Rows.Count} results found matching your criteria";
    imageListInitializer.Dispose();
  }

  private void mnuDetails_Click(object sender, EventArgs e) => this.ListView1.View = View.Details;

  private void mnuSmallIcons_Click(object sender, EventArgs e)
  {
    this.ListView1.View = View.SmallIcon;
  }

  private void mnuLargeIcons_Click(object sender, EventArgs e)
  {
    this.ListView1.View = View.LargeIcon;
  }

  private void mnuList_Click(object sender, EventArgs e) => this.ListView1.View = View.List;

  private void btnStop_Click(object sender, EventArgs e)
  {
    ((Control) this.btnStop).Visible = false;
  }

  private void mnuOpenDoc_Click(object sender, EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.ListView1.SelectedItems)
        frmDocumentSearchResults.OpenDocument((Guid) selectedItem.Tag);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void frmDocumentSearchResults_Load(object sender, EventArgs e)
  {
    this._documentListInitializer = new frmDocumentSearchResults.DocumentImageListInitializer(this.smallImages, this.largeImages, this.ListView1);
    this.ListView1.View = (View) Preferences.GetPreferenceInt("Screens.DocumentSearchResults.ViewStyle");
    this.ListView1.Enabled = false;
  }

  private void frmDocumentSearchResults_Closing(object sender, CancelEventArgs e)
  {
    Preferences.SetPreference("Screens.DocumentSearchResults.ViewStyle", (int) this.ListView1.View);
  }

  private void SaveDocumentToDisk(Guid documentGuid)
  {
    string empty = string.Empty;
    try
    {
      MDIControls.Instance.MDIParent.Cursor = MgaCursors.WaitCursor;
      DataRow dataRow = Database.Instance.QueryText.PerformRowQuery($"SELECT Compressed, FileName, Document FROM tblDocumentStore (NOLOCK) WHERE DocumentStoreGuid = '{documentGuid}'");
      byte[] array = (byte[]) dataRow["Document"];
      bool boolean = Conversions.ToBoolean(dataRow["Compressed"]);
      string str1 = Conversions.ToString(dataRow["FileName"]);
      FolderBrowserDialog folderBrowserDialog1 = this.FolderBrowserDialog1;
      folderBrowserDialog1.Description = $"Please choose a directory to save {str1}";
      folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
      if (folderBrowserDialog1.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      string selectedPath = folderBrowserDialog1.SelectedPath;
      string path = $"{selectedPath}\\{str1}";
      string str2 = $"{selectedPath}\\{"TempZip.zip"}";
      if (boolean)
      {
        using (FileStream fileStream = new FileStream(str2, FileMode.Create))
        {
          fileStream.Write(array, 0, array.Length);
          fileStream.Close();
        }
        this.ZipUtility1.ExtractFilesFromZipArchive(str2, $"{selectedPath}\\");
        File.Delete(str2);
      }
      else
      {
        try
        {
          using (FileStream fileStream = new FileStream(path, FileMode.Create))
          {
            fileStream.Write(array, 0, array.Length);
            fileStream.Close();
          }
        }
        catch (IOException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) MessageBox.Show("This item is already open", "Cannot open two instances of the same document", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          ProjectData.ClearProjectError();
        }
      }
    }
    catch (Win32Exception ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      Win32Exception win32Exception = ex;
      if (win32Exception.ErrorCode == -2147467259 /*0x80004005*/)
      {
        int num = (int) MessageBox.Show(win32Exception.Message, "Windows Cannot Open File", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      ProjectData.ClearProjectError();
    }
    finally
    {
      MDIControls.Instance.MDIParent.Cursor = MgaCursors.Default;
    }
  }

  public static void OpenDocument(Guid documentGuid)
  {
    DocumentManager.BeginViewDocument(documentGuid);
  }

  private TempFileCollection TempFileCollection
  {
    get
    {
      if (this._tempFileCollection == null)
        this._tempFileCollection = new TempFileCollection(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
      return this._tempFileCollection;
    }
  }

  private static void StartProcess(string fileName)
  {
    Process process = Process.Start(fileName);
    if (Screen.AllScreens.Length > 1 && process != null)
    {
      process.WaitForInputIdle(10000);
      int foregroundWindow = SafeAPI.GetForegroundWindow();
      int int32 = MDIControls.Instance.MDIParent.Handle.ToInt32();
      int num = 0;
      while (int32 == foregroundWindow)
      {
        Thread.Sleep(500);
        foregroundWindow = SafeAPI.GetForegroundWindow();
        ++num;
        if (num > 5)
          break;
      }
      if (foregroundWindow != 0 && Preferences.GetPreferenceBool("DockingTabs.Documents.OpenOnSecondMonitor"))
        SystemInfo.MoveWindowToSecondaryMonitorRestored(foregroundWindow);
    }
    process?.Dispose();
  }

  private void ListView1_DoubleClick(object sender, EventArgs e)
  {
    Point client = this.ListView1.PointToClient(Cursor.Position);
    ListViewItem itemAt = this.ListView1.GetItemAt(client.X, client.Y);
    if (itemAt == null)
      return;
    frmDocumentSearchResults.OpenDocument((Guid) itemAt.Tag);
  }

  private void CleanUpDynamicMenuItems()
  {
    List<MenuItem> menuItemList = new List<MenuItem>();
    try
    {
      foreach (MenuItem menuItem in this.ContextMenu1.MenuItems)
        menuItemList.Add(menuItem);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (MenuItem menuItem in menuItemList)
      {
        if (menuItem is frmDocumentSearchResults.TaggedMenuItem taggedMenuItem)
        {
          if (taggedMenuItem.Tag is DataRow)
            taggedMenuItem.Click -= new EventHandler(this.mnuOpenEntity_Click);
          else if (taggedMenuItem.Tag is Guid)
            taggedMenuItem.Click -= new EventHandler(this.mnuSaveAs_Click);
          this.ContextMenu1.MenuItems.Remove((MenuItem) taggedMenuItem);
          taggedMenuItem.Dispose();
        }
      }
    }
    finally
    {
      List<MenuItem>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void ContextMenu1_Popup(object sender, EventArgs e)
  {
    if (this.ListView1.SelectedItems.Count == 0)
      return;
    ListViewItem selectedItem = this.ListView1.SelectedItems[0];
    Guid tag = (Guid) selectedItem.Tag;
    DataTable dataTable = Database.Instance.QueryText.PerformTableQuery($"SELECT DocumentStoreGuid, AssociatedEntityGuid, AssociatedEntityType, AssociatedEntityName, AssociatedEntityFormName FROM dbo.tblDocumentAssociations (NOLOCK) WHERE DocumentStoreGuid = '{tag}' AND AssociatedEntityGuid NOT IN (SELECT [ID] FROM tblNoteStore (NOLOCK))");
    this.CleanUpDynamicMenuItems();
    frmDocumentSearchResults.TaggedMenuItem taggedMenuItem1 = new frmDocumentSearchResults.TaggedMenuItem($"Save {selectedItem.Text} As...", (object) tag);
    taggedMenuItem1.Click += new EventHandler(this.mnuSaveAs_Click);
    this.ContextMenu1.MenuItems.Add(1, (MenuItem) taggedMenuItem1);
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        string str = $"Open Association [{Database.IsNull(RuntimeHelpers.GetObjectValue(row["AssociatedEntityName"]), "Unknown")}]";
        frmDocumentSearchResults.TaggedMenuItem taggedMenuItem2 = new frmDocumentSearchResults.TaggedMenuItem(str, (object) row);
        this.ContextMenu1.MenuItems.Add(1, (MenuItem) taggedMenuItem2);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Open Association [Unknown]", false) == 0)
          taggedMenuItem2.Enabled = false;
        taggedMenuItem2.Click += new EventHandler(this.mnuOpenEntity_Click);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void mnuSaveAs_Click(object sender, EventArgs e)
  {
    if (!(sender is frmDocumentSearchResults.TaggedMenuItem taggedMenuItem))
      return;
    this.SaveDocumentToDisk((Guid) taggedMenuItem.Tag);
  }

  private void mnuOpenEntity_Click(object sender, EventArgs e)
  {
    if (!(sender is frmDocumentSearchResults.TaggedMenuItem taggedMenuItem) || taggedMenuItem.Tag == null || !(taggedMenuItem.Tag is DataRow))
      return;
    DataRow tag = (DataRow) taggedMenuItem.Tag;
    if (tag.IsNull("AssociatedEntityType") || tag.IsNull("AssociatedEntityGuid"))
      return;
    string typeName = Conversions.ToString(tag["AssociatedEntityType"]);
    Guid entityGuid = (Guid) tag["AssociatedEntityGuid"];
    Type typeFromString = ObjectFactory.Instance.CreateTypeFromString(typeName);
    if ((object) typeFromString == null)
      return;
    IRecreatableEntity recreatableEntity = (IRecreatableEntity) ObjectFactory.Instance.CreateObject(typeFromString);
    if (recreatableEntity == null || !recreatableEntity.CanReCreateEntity)
      return;
    recreatableEntity.RecreateEntityInitialize(entityGuid);
    if (recreatableEntity is Form form)
    {
      form.MdiParent = MDIControls.Instance.MDIParent;
      form.Show();
      DockingManager.ShowAndActivate("TabUserDocumentPanel");
    }
    else
    {
      int num = (int) MessageBox.Show("Currently this document does not support opening it's associated entity. Please check back soon for added support of this entity type.", "Unable to open associated entity", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private void ListView1_MouseDown(object sender, MouseEventArgs e)
  {
    if (this.ListView1.GetItemAt(e.X, e.Y) != null)
    {
      Size dragSize = SystemInformation.DragSize;
      this.dragBoxFromMouseDown = new Rectangle(new Point((int) Math.Round((double) e.X - (double) dragSize.Width / 2.0), (int) Math.Round((double) e.Y - (double) dragSize.Height / 2.0)), dragSize);
    }
    else
      this.dragBoxFromMouseDown = Rectangle.Empty;
  }

  private void ListView1_MouseUp(object sender, MouseEventArgs e)
  {
    this.dragBoxFromMouseDown = Rectangle.Empty;
  }

  private void ListView1_MouseMove(object sender, MouseEventArgs e)
  {
    if ((e.Button & MouseButtons.Left) != MouseButtons.Left)
      return;
    ListViewItem itemAt = this.ListView1.GetItemAt(e.X, e.Y);
    if (!(this.dragBoxFromMouseDown != Rectangle.Empty & !this.dragBoxFromMouseDown.Contains(e.X, e.Y)))
      return;
    int num = (int) this.ListView1.DoDragDrop(RuntimeHelpers.GetObjectValue(itemAt.Tag), DragDropEffects.All);
  }

  private void frmDocumentSearchResults_Activated(object sender, EventArgs e)
  {
    this._lastFormSupportingDocSystem = MDIControls.Instance.LastActivatedVisibleForm as ISupportDocumentSystem;
  }

  public bool AllowAddNewDocument
  {
    get
    {
      return this._lastFormSupportingDocSystem != null && !(this._lastFormSupportingDocSystem is frmDocumentSearchResults) && this._lastFormSupportingDocSystem.AllowAddNewDocument;
    }
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  bool IRecreatableEntity.CanReCreateEntity
  {
    get
    {
      return this._lastFormSupportingDocSystem != null && !(this._lastFormSupportingDocSystem is frmDocumentSearchResults) && this._lastFormSupportingDocSystem.CanReCreateEntity;
    }
  }

  Guid IRecreatableEntity.EntityGuid
  {
    get
    {
      return this._lastFormSupportingDocSystem != null ? this._lastFormSupportingDocSystem.EntityGuid : throw new InvalidOperationException("Entity Guid not available");
    }
  }

  string IRecreatableEntity.EntityName
  {
    get
    {
      return this._lastFormSupportingDocSystem != null ? this._lastFormSupportingDocSystem.EntityName : throw new InvalidOperationException("Entity Name not available");
    }
  }

  string IRecreatableEntity.FriendlyEntityName
  {
    get
    {
      return this._lastFormSupportingDocSystem != null ? this._lastFormSupportingDocSystem.FriendlyEntityName : throw new InvalidOperationException("Friendly Entity Name not available");
    }
  }

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    return this._lastFormSupportingDocSystem != null ? this._lastFormSupportingDocSystem.RecreateEntityInitialize(entityGuid) : throw new InvalidOperationException("Cannot Recreate entity");
  }

  string IRecreatableEntity.RecreateTypeName
  {
    get
    {
      return this._lastFormSupportingDocSystem != null ? this._lastFormSupportingDocSystem.RecreateTypeName : throw new InvalidOperationException("Friendly Entity Name not available");
    }
  }

  Guid IRecreatableEntity.ControlGUID => Guid.Empty;

  bool IRecreatableEntity.HasControlGUID => false;

  private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
  {
    frmDocumentSearchResults.ListViewSortComparer listViewSorter1 = this._listViewSorter;
    listViewSorter1.ColumnIndex = e.Column;
    listViewSorter1.SortAsType = e.Column != 2 ? (e.Column != 4 ? typeof (string) : typeof (long)) : typeof (DateTime);
    this.ListView1.ListViewItemSorter = (IComparer) this._listViewSorter;
    frmDocumentSearchResults.ListViewSortComparer listViewSorter2 = this._listViewSorter;
    if (listViewSorter2.Sorting == System.Windows.Forms.SortOrder.None || listViewSorter2.Sorting == System.Windows.Forms.SortOrder.Descending)
      listViewSorter2.Sorting = System.Windows.Forms.SortOrder.Ascending;
    else if (listViewSorter2.Sorting == System.Windows.Forms.SortOrder.Ascending)
      listViewSorter2.Sorting = System.Windows.Forms.SortOrder.Descending;
    this.ListView1.Sort();
  }

  private void mnuOpenDocProperties_Click(object sender, EventArgs e)
  {
    bool flag = false;
    try
    {
      foreach (ListViewItem selectedItem in this.ListView1.SelectedItems)
      {
        using (frmDocumentProperties documentProperties = frmDocumentProperties.Create((Guid) selectedItem.Tag))
        {
          DialogResult dialogResult = documentProperties.ShowDialog((IWin32Window) this);
          if (!flag)
          {
            if (dialogResult == DialogResult.OK)
              flag = true;
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
    if (!flag || this._searchInProgress)
      return;
    this.DoSearch(this._lastCriteria, false);
  }

  private void mnuZipAndEmail_Click(object sender, EventArgs e)
  {
    List<Guid> guidList = new List<Guid>();
    try
    {
      foreach (ListViewItem selectedItem in this.ListView1.SelectedItems)
        guidList.Add((Guid) selectedItem.Tag);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    Guid[] array = guidList.ToArray();
    using (frmAssociatedEntities associatedEntities = new frmAssociatedEntities(array))
    {
      if (associatedEntities.HasAssociatedEntites)
      {
        int num = (int) associatedEntities.ShowDialog();
        DocumentManager.EmailDocuments(array, associatedEntities.SelectedEmails.ToArray());
      }
      else
        DocumentManager.EmailDocuments(array);
    }
  }

  private void mnuDeleteDocs_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete the selected documents?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    List<ListViewItem> listViewItemList = new List<ListViewItem>();
    bool flag;
    try
    {
      foreach (ListViewItem selectedItem in this.ListView1.SelectedItems)
      {
        if (!DocumentManager.BeginDeleteDocument((Guid) selectedItem.Tag))
        {
          selectedItem.ForeColor = Color.Red;
          flag = true;
        }
        else
          listViewItemList.Add(selectedItem);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (flag)
    {
      int num = (int) MessageBox.Show("The items marked in red are bound and cannot be deleted", "Cannot delete documents that are bound", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    try
    {
      foreach (ListViewItem listViewItem in listViewItemList)
        this.ListView1.Items.Remove(listViewItem);
    }
    finally
    {
      List<ListViewItem>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void mnuPinDocument_Click(object sender, EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.ListView1.SelectedItems)
        DocumentManager.PinDocument((Guid) selectedItem.Tag);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void bwSearch_DoWork(object sender, DoWorkEventArgs e)
  {
    if (this.IsDisposed || this._lastSearchDisplaysProgress && !((Control) this.btnStop).Visible)
      return;
    e.Result = (object) Database.Instance.QueryText.PerformTableQuery((string) e.Argument, (SqlParameter[]) null, new TableFillingEventHandler(this.SearchProgress));
  }

  private void bwSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
  {
    this.UltraProgressBar1.Value = e.ProgressPercentage;
  }

  private void bwSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    this.HandleQueryResults((DataTable) e.Result);
  }

  private void HandleQueryResults(DataTable results)
  {
    this.DisplaySearchResults(results);
    ((Control) this.btnStop).Visible = false;
    this.lblStatus.Text = $"{results.Rows.Count} results found matching your criteria";
    this._searchInProgress = false;
    this.ListView1.Enabled = true;
  }

  private sealed class DocumentImageListInitializer : IDisposable
  {
    private ImageList _imgSmall;
    private ImageList _imgLarge;
    private ListView _listView;
    private Dictionary<string, int> _fileTypeImageIndexHash;

    public DocumentImageListInitializer(ImageList imgSmall, ImageList imgLarge, ListView listview)
    {
      this._imgSmall = (ImageList) null;
      this._imgLarge = (ImageList) null;
      this._listView = (ListView) null;
      this._fileTypeImageIndexHash = new Dictionary<string, int>();
      this._listView = listview;
      this._imgLarge = imgLarge;
      this._imgSmall = imgSmall;
      this._imgLarge.ColorDepth = ColorDepth.Depth32Bit;
      this._imgSmall.ColorDepth = ColorDepth.Depth32Bit;
      this._listView.LargeImageList = this._imgLarge;
      this._listView.SmallImageList = this._imgSmall;
    }

    public void AddItem(
      string fileName,
      int size,
      Guid documentGuid,
      string description,
      string fileAssociation,
      DateTime dateadded)
    {
      string key1 = fileName.IndexOf(".") != -1 ? fileName.Substring(fileName.LastIndexOf(".")) : ".xxx";
      int imageIndex;
      if (this._fileTypeImageIndexHash.ContainsKey(key1))
      {
        imageIndex = this._fileTypeImageIndexHash[key1];
      }
      else
      {
        string key2 = Guid.NewGuid().ToString();
        this._imgSmall.Images.Add(FileInfoEx.GetSmallIcon("test" + key1));
        this._imgLarge.Images.Add(key2, FileInfoEx.GetLargeIcon("test" + key1));
        imageIndex = this._imgLarge.Images.IndexOfKey(key2);
        this._fileTypeImageIndexHash.Add(key1, imageIndex);
      }
      ListViewItem listViewItem = new ListViewItem(fileName, imageIndex);
      listViewItem.Tag = (object) documentGuid;
      listViewItem.SubItems.Add(fileAssociation);
      listViewItem.SubItems.Add(dateadded.ToShortDateString());
      listViewItem.SubItems.Add(description);
      long num = (long) Math.Round((double) size / 1024.0);
      if (num == 0L)
        ++num;
      listViewItem.SubItems.Add($"{num} KB");
      this._listView.Items.Add(listViewItem);
    }

    public void Dispose()
    {
      this._imgSmall = (ImageList) null;
      this._imgLarge = (ImageList) null;
      this._listView = (ListView) null;
      this._fileTypeImageIndexHash = (Dictionary<string, int>) null;
    }
  }

  private sealed class TaggedMenuItem : MenuItem
  {
    private object _tag;

    public TaggedMenuItem(string text, object tag)
      : base(text)
    {
      this._tag = RuntimeHelpers.GetObjectValue(tag);
    }

    public new object Tag => this._tag;
  }

  private sealed class ListViewSortComparer : IComparer
  {
    private Type _columnType;
    private int _columnIndex;
    private System.Windows.Forms.SortOrder _sortOrder;

    public ListViewSortComparer()
    {
      this._columnIndex = -1;
      this._sortOrder = System.Windows.Forms.SortOrder.None;
    }

    public System.Windows.Forms.SortOrder Sorting
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
        long num2 = frmDocumentSearchResults.ListViewSortComparer.LongFromString(Conversions.ToString(x));
        long num3 = frmDocumentSearchResults.ListViewSortComparer.LongFromString(Conversions.ToString(y));
        num1 = num2 <= num3 ? (num2 >= num3 ? 0 : -1) : 1;
      }
      else
        num1 = 0;
      int num4;
      switch (this._sortOrder)
      {
        case System.Windows.Forms.SortOrder.None:
          num4 = 0;
          break;
        case System.Windows.Forms.SortOrder.Ascending:
          num4 = num1;
          break;
        case System.Windows.Forms.SortOrder.Descending:
          num4 = num1 * -1;
          break;
      }
      return num4;
    }
  }
}

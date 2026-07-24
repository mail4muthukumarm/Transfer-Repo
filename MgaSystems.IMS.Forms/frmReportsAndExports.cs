// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmReportsAndExports
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinTree;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Logging;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.Attributes;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

public class frmReportsAndExports : Form
{
  private Hashtable _reportList;
  private IContainer components;

  public frmReportsAndExports()
  {
    this.Load += new EventHandler(this.frmReportsAndExports_Load);
    this._reportList = new Hashtable();
    this.InitializeComponent();
    this.pnlMGAProcedureList.Visible = false;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("images")]
  internal virtual ImageList images { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaGroupBox2")]
  internal virtual MGAGroupBox MgaGroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblReportTitle")]
  internal virtual Label lblReportTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblReportDescription")]
  internal virtual Label lblReportDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaGroupBox1")]
  internal virtual MGAGroupBox MgaGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATreeView trvFolders
  {
    get => this._trvFolders;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      AfterNodeSelectEventHandler selectEventHandler = new AfterNodeSelectEventHandler(this.trvFolders_AfterSelect);
      MGATreeView trvFolders1 = this._trvFolders;
      if (trvFolders1 != null)
        trvFolders1.AfterSelect -= selectEventHandler;
      this._trvFolders = value;
      MGATreeView trvFolders2 = this._trvFolders;
      if (trvFolders2 == null)
        return;
      trvFolders2.AfterSelect += selectEventHandler;
    }
  }

  internal virtual ListView lstReports
  {
    get => this._lstReports;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.lstReports_DoubleClick);
      EventHandler eventHandler2 = new EventHandler(this.lstReports_SelectedIndexChanged);
      ListView lstReports1 = this._lstReports;
      if (lstReports1 != null)
      {
        lstReports1.DoubleClick -= eventHandler1;
        lstReports1.SelectedIndexChanged -= eventHandler2;
      }
      this._lstReports = value;
      ListView lstReports2 = this._lstReports;
      if (lstReports2 == null)
        return;
      lstReports2.DoubleClick += eventHandler1;
      lstReports2.SelectedIndexChanged += eventHandler2;
    }
  }

  internal virtual LinkLabel linkDataDictionary
  {
    get => this._linkDataDictionary;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkDataDictionary_LinkClicked);
      LinkLabel linkDataDictionary1 = this._linkDataDictionary;
      if (linkDataDictionary1 != null)
        linkDataDictionary1.LinkClicked -= clickedEventHandler;
      this._linkDataDictionary = value;
      LinkLabel linkDataDictionary2 = this._linkDataDictionary;
      if (linkDataDictionary2 == null)
        return;
      linkDataDictionary2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("pnlMGAProcedureList")]
  internal virtual Panel pnlMGAProcedureList { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDetectedProcedures")]
  internal virtual TextBox txtDetectedProcedures { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblDetectedProcedures")]
  internal virtual Label lblDetectedProcedures { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkLastUpdated
  {
    get => this._lnkLastUpdated;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkLastUpdated_LinkClicked);
      LinkLabel lnkLastUpdated1 = this._lnkLastUpdated;
      if (lnkLastUpdated1 != null)
        lnkLastUpdated1.LinkClicked -= clickedEventHandler;
      this._lnkLastUpdated = value;
      LinkLabel lnkLastUpdated2 = this._lnkLastUpdated;
      if (lnkLastUpdated2 == null)
        return;
      lnkLastUpdated2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolTip")]
  internal virtual ToolTip ToolTip { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Title")]
  internal virtual ColumnHeader Title { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportsAndExports));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    this.images = new ImageList(this.components);
    this.MgaGroupBox2 = new MGAGroupBox();
    this.pnlMGAProcedureList = new Panel();
    this.txtDetectedProcedures = new TextBox();
    this.lblDetectedProcedures = new Label();
    this.linkDataDictionary = new LinkLabel();
    this.lblReportTitle = new Label();
    this.lblReportDescription = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.trvFolders = new MGATreeView();
    this.lstReports = new ListView();
    this.Title = new ColumnHeader();
    this.lnkLastUpdated = new LinkLabel();
    this.ToolTip = new ToolTip(this.components);
    ((ISupportInitialize) this.MgaGroupBox2).BeginInit();
    ((Control) this.MgaGroupBox2).SuspendLayout();
    this.pnlMGAProcedureList.SuspendLayout();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.trvFolders).BeginInit();
    this.SuspendLayout();
    this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
    this.images.TransparentColor = Color.Transparent;
    this.images.Images.SetKeyName(0, "");
    this.images.Images.SetKeyName(1, "");
    ((Control) this.MgaGroupBox2).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(239, 247, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.pnlMGAProcedureList);
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.linkDataDictionary);
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.lblReportTitle);
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.lblReportDescription);
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.Label3);
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.Label2);
    appearance2.AlphaLevel = (short) 230;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.White;
    appearance2.ForegroundAlpha = (Alpha) 2;
    appearance2.ImageAlpha = (Alpha) 2;
    appearance2.ImageBackground = (Image) componentResourceManager.GetObject("Appearance2.ImageBackground");
    appearance2.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox2.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.MgaGroupBox2).Location = new Point(8, 233);
    ((Control) this.MgaGroupBox2).Name = "MgaGroupBox2";
    ((Control) this.MgaGroupBox2).Size = new Size(552, 160 /*0xA0*/);
    ((Control) this.MgaGroupBox2).TabIndex = 3;
    this.MgaGroupBox2.Text = "Report Information";
    this.MgaGroupBox2.ViewStyle = (GroupBoxViewStyle) 2;
    this.pnlMGAProcedureList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pnlMGAProcedureList.BackColor = Color.Transparent;
    this.pnlMGAProcedureList.Controls.Add((Control) this.lnkLastUpdated);
    this.pnlMGAProcedureList.Controls.Add((Control) this.txtDetectedProcedures);
    this.pnlMGAProcedureList.Controls.Add((Control) this.lblDetectedProcedures);
    this.pnlMGAProcedureList.Location = new Point(8, 67);
    this.pnlMGAProcedureList.Name = "pnlMGAProcedureList";
    this.pnlMGAProcedureList.Size = new Size(413, 85);
    this.pnlMGAProcedureList.TabIndex = 5;
    this.txtDetectedProcedures.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.txtDetectedProcedures.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtDetectedProcedures.ForeColor = Color.Black;
    this.txtDetectedProcedures.Location = new Point(3, 21);
    this.txtDetectedProcedures.Multiline = true;
    this.txtDetectedProcedures.Name = "txtDetectedProcedures";
    this.txtDetectedProcedures.ReadOnly = true;
    this.txtDetectedProcedures.ScrollBars = ScrollBars.Vertical;
    this.txtDetectedProcedures.Size = new Size(407, 64 /*0x40*/);
    this.txtDetectedProcedures.TabIndex = 3;
    this.txtDetectedProcedures.Text = "Run the report to generate the procedure list.";
    this.lblDetectedProcedures.BackColor = Color.Transparent;
    this.lblDetectedProcedures.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblDetectedProcedures.ForeColor = Color.Black;
    this.lblDetectedProcedures.Location = new Point(0, 0);
    this.lblDetectedProcedures.Name = "lblDetectedProcedures";
    this.lblDetectedProcedures.Size = new Size(176 /*0xB0*/, 21);
    this.lblDetectedProcedures.TabIndex = 2;
    this.lblDetectedProcedures.Text = "Detected Procedures (mga only)";
    this.ToolTip.SetToolTip((Control) this.lblDetectedProcedures, "Requires Database.CommandDetail log to be enabled.");
    this.linkDataDictionary.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.linkDataDictionary.AutoSize = true;
    this.linkDataDictionary.BackColor = Color.FromArgb(239, 247, 253);
    this.linkDataDictionary.Location = new Point(442, 139);
    this.linkDataDictionary.Name = "linkDataDictionary";
    this.linkDataDictionary.Size = new Size(106, 13);
    this.linkDataDictionary.TabIndex = 4;
    this.linkDataDictionary.TabStop = true;
    this.linkDataDictionary.Text = "View Data Dictionary";
    this.lblReportTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.lblReportTitle.BackColor = Color.Transparent;
    this.lblReportTitle.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblReportTitle.ForeColor = Color.Black;
    this.lblReportTitle.Location = new Point(112 /*0x70*/, 33);
    this.lblReportTitle.Name = "lblReportTitle";
    this.lblReportTitle.Size = new Size(432, 16 /*0x10*/);
    this.lblReportTitle.TabIndex = 3;
    this.lblReportDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.lblReportDescription.BackColor = Color.Transparent;
    this.lblReportDescription.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblReportDescription.ForeColor = Color.Black;
    this.lblReportDescription.Location = new Point(112 /*0x70*/, 49);
    this.lblReportDescription.Name = "lblReportDescription";
    this.lblReportDescription.Size = new Size(432, 83);
    this.lblReportDescription.TabIndex = 2;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.Black;
    this.Label3.Location = new Point(8, 48 /*0x30*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.Label3.TabIndex = 1;
    this.Label3.Text = "Description:";
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.Black;
    this.Label2.Location = new Point(8, 32 /*0x20*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.Label2.TabIndex = 0;
    this.Label2.Text = "Report:";
    ((Control) this.MgaGroupBox1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(239, 247, 253);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance3;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.trvFolders);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.lstReports);
    appearance4.AlphaLevel = (short) 230;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.White;
    appearance4.ImageAlpha = (Alpha) 2;
    appearance4.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance4;
    ((Control) this.MgaGroupBox1).Location = new Point(8, 8);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(552, 219);
    ((Control) this.MgaGroupBox1).TabIndex = 4;
    this.MgaGroupBox1.Text = "Reports";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.trvFolders).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    appearance5.BorderColor = Color.Gray;
    appearance5.Image = (object) 0;
    this.trvFolders.Appearance = (AppearanceBase) appearance5;
    this.trvFolders.BorderStyle = (UIElementBorderStyle) 4;
    this.trvFolders.ImageList = this.images;
    ((Control) this.trvFolders).Location = new Point(8, 35);
    ((Control) this.trvFolders).Name = "trvFolders";
    this.trvFolders.PathSeparator = "/";
    this.trvFolders.ShowLines = false;
    ((Control) this.trvFolders).Size = new Size(176 /*0xB0*/, 171);
    ((Control) this.trvFolders).TabIndex = 0;
    this.lstReports.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstReports.BorderStyle = BorderStyle.FixedSingle;
    this.lstReports.Columns.AddRange(new ColumnHeader[1]
    {
      this.Title
    });
    this.lstReports.HeaderStyle = ColumnHeaderStyle.None;
    this.lstReports.HideSelection = false;
    this.lstReports.Location = new Point(192 /*0xC0*/, 34);
    this.lstReports.Name = "lstReports";
    this.lstReports.Size = new Size(355, 171);
    this.lstReports.SmallImageList = this.images;
    this.lstReports.Sorting = SortOrder.Ascending;
    this.lstReports.TabIndex = 1;
    this.lstReports.UseCompatibleStateImageBehavior = false;
    this.lstReports.View = View.Details;
    this.Title.Text = "Title";
    this.Title.Width = 300;
    this.lnkLastUpdated.AutoSize = true;
    this.lnkLastUpdated.Location = new Point(182, 0);
    this.lnkLastUpdated.Name = "lnkLastUpdated";
    this.lnkLastUpdated.Size = new Size(63 /*0x3F*/, 13);
    this.lnkLastUpdated.TabIndex = 4;
    this.lnkLastUpdated.TabStop = true;
    this.lnkLastUpdated.Text = "Last Traced";
    this.ToolTip.SetToolTip((Control) this.lnkLastUpdated, "Click to clear last trace. (Traces automatically clear after 30 days)");
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(568, 398);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Controls.Add((Control) this.MgaGroupBox2);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MinimumSize = new Size(576, 400);
    this.Name = nameof (frmReportsAndExports);
    this.Text = "Reporting";
    ((ISupportInitialize) this.MgaGroupBox2).EndInit();
    ((Control) this.MgaGroupBox2).ResumeLayout(false);
    ((Control) this.MgaGroupBox2).PerformLayout();
    this.pnlMGAProcedureList.ResumeLayout(false);
    this.pnlMGAProcedureList.PerformLayout();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.trvFolders).EndInit();
    this.ResumeLayout(false);
  }

  private static string GeneratePath(string[] Categories, int EndIndex)
  {
    StringBuilder stringBuilder = new StringBuilder();
    int num = EndIndex;
    for (int index = 0; index <= num; ++index)
    {
      stringBuilder.Append(Categories[index]);
      if (index != EndIndex)
        stringBuilder.Append("|");
    }
    return stringBuilder.ToString();
  }

  private static string[] SplitCategoryString(string Category)
  {
    string[] strArray;
    if (Category.IndexOf("|") > -1)
    {
      ArrayList arrayList = new ArrayList();
      for (Category += "|"; Category.IndexOf("|") > -1; Category = Category.Substring(Category.IndexOf("|") + 1, Category.Length - Category.IndexOf("|") - 1))
        arrayList.Add((object) Category.Substring(0, Category.IndexOf("|")));
      strArray = (string[]) arrayList.ToArray(typeof (string));
    }
    else
      strArray = new string[1]{ Category };
    return strArray;
  }

  private void AddFolder(TreeNodesCollection NodeCollection, string[] Categories, int Index)
  {
    if (Categories.Length == 1)
    {
      NodeCollection.Add(Categories[0], Categories[0]);
    }
    else
    {
      if (Categories.Length <= 1 || Index >= Categories.Length)
        return;
      string path = frmReportsAndExports.GeneratePath(Categories, Index);
      if (!((KeyedSubObjectsCollectionBase) NodeCollection).Exists(path))
        NodeCollection.Add(path, Categories[Index]);
      this.AddFolder(NodeCollection[path].Nodes, Categories, Index + 1);
    }
  }

  private void CreateFolderNodes()
  {
    try
    {
      foreach (ReportNode reportNode in (IEnumerable) this._reportList.Values)
      {
        if (!((KeyedSubObjectsCollectionBase) this.trvFolders.Nodes).Exists(reportNode.Category))
          this.AddFolder(this.trvFolders.Nodes, frmReportsAndExports.SplitCategoryString(reportNode.Category), 0);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void CreateReportNodes()
  {
    SecureReportResourceAttribute searchAttribute = new SecureReportResourceAttribute();
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithInterface(typeof (IReport));
    int index = 0;
    while (index < typeArray.Length)
    {
      Type type = typeArray[index];
      SecureReportResourceAttribute attributeFromType1 = (SecureReportResourceAttribute) ObjectFactory.GetAttributeFromType(type, (Attribute) searchAttribute);
      SuppressReportVisibleAttribute attributeFromType2 = ObjectFactory.GetAttributeFromType(type, (Attribute) new SuppressReportVisibleAttribute()) as SuppressReportVisibleAttribute;
      if (attributeFromType1 != null && attributeFromType2 == null && !SecurityManager.Instance.IsPermissionDenied(attributeFromType1.UniqueIdentifier))
      {
        ReportNode reportNode = new ReportNode(attributeFromType1.UniqueIdentifier, type, attributeFromType1.ReportCategory, attributeFromType1.Name, attributeFromType1.ReportDescription);
        reportNode.ImageIndex = 1;
        this._reportList.Add((object) attributeFromType1.UniqueIdentifier.ToString(), (object) reportNode);
      }
      checked { ++index; }
    }
    this.CreateAdHocReportNodes();
  }

  private void CreateAdHocReportNodes()
  {
    if (DefaultDatabase.ExecuteScalar<int>("AdhocReportCount") == 0)
      return;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ReportGUID,ReportName,GroupName,Description FROM tblAdHocReports WHERE Published=1");
    Type type = typeof (AdHocReportDisplay);
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        if (!SecurityManager.Instance.IsPermissionDenied(row["ReportGUID"].ToString()))
        {
          ReportNode reportNode = new ReportNode(new Guid(row["ReportGUID"].ToString()), type, row["GroupName"].ToString(), row["ReportName"].ToString(), row["Description"].ToString() + " (AdHoc)");
          reportNode.ImageIndex = 1;
          this._reportList.Add((object) row["ReportGUID"].ToString(), (object) reportNode);
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

  private void UpdateReportList(string selectedReportCategory)
  {
    Cursor.Current = Cursors.WaitCursor;
    this.lstReports.Items.Clear();
    try
    {
      foreach (ReportNode reportNode in (IEnumerable) this._reportList.Values)
      {
        if (string.Equals(reportNode.Category, selectedReportCategory, StringComparison.CurrentCultureIgnoreCase))
          this.lstReports.Items.Add((ListViewItem) reportNode);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (this.lstReports.SelectedItems.Count == 1)
      this.UpdateReportInformation((ReportNode) this.lstReports.SelectedItems[0]);
    else if (this.lstReports.Items.Count > 0)
    {
      this.lstReports.Items[0].Selected = true;
    }
    else
    {
      this.lblReportTitle.Text = string.Empty;
      this.lblReportDescription.Text = string.Empty;
    }
    Cursor.Current = Cursors.Default;
  }

  private void UpdateReportInformation(ReportNode selectedReportNode)
  {
    Cursor.Current = Cursors.WaitCursor;
    this.lblReportTitle.Text = selectedReportNode.Title;
    this.lblReportDescription.Text = selectedReportNode.Description;
    this.pnlMGAProcedureList.Enabled = frmReportsAndExports.IsLogEnabled("MGASystems.Data.Utility.CommandDetail");
    this.lnkLastUpdated.Visible = false;
    Cursor.Current = Cursors.Default;
    try
    {
      if (!CurrentUser.IsMGADeveloper)
        return;
      DataTable dataTable = DefaultDatabase.ExecuteDataTable("FetchReportProcedureLogDetail", new object[2]
      {
        (object) "@reportGuid",
        (object) selectedReportNode.ReportID
      });
      if (dataTable != null && dataTable.Rows.Count == 1)
      {
        string str = dataTable.Rows[0].Field<string>("ProceduresCalled");
        bool flag = dataTable.Rows[0].Field<bool>("IsAdHoc");
        DateTime dateTime = dataTable.Rows[0].Field<DateTime>("LastUpdated");
        this.txtDetectedProcedures.Text = $"{(flag ? (object) "AdHoc Report" : (object) "Built-in Report")}{Environment.NewLine}" + $"Procedures Called:{Environment.NewLine}{str}";
        this.lnkLastUpdated.Text = $"Last Traced {dateTime.ToShortDateString()}.";
        this.lnkLastUpdated.Visible = true;
      }
      else
        this.txtDetectedProcedures.Text = "Run the report to generate the procedure list.";
      this.pnlMGAProcedureList.Visible = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private static void LaunchReport(ReportNode nodeToLaunch)
  {
    Cursor.Current = Cursors.WaitCursor;
    if (SecurityManager.Instance.AssertPermission(nodeToLaunch.ReportID))
    {
      IReport report = (IReport) ObjectFactory.Instance.CreateObject(nodeToLaunch.Type, typeof (IReport));
      ((MGAReport) report).CurrentUserGuid = CurrentUser.Instance.UserGUID;
      Type getLaunchForm = report.getLaunchForm;
      BaseReportControl[] getReportControls1 = report.getReportControls;
      if ((object) getLaunchForm != null)
      {
        Form formEx = ObjectFactory.Instance.CreateFormEX(getLaunchForm);
        formEx.ShowInTaskbar = false;
        formEx.AutoScroll = true;
        formEx.MdiParent = MDIControls.Instance.MDIParent;
        formEx.Show();
      }
      else if (getReportControls1 != null)
      {
        frmGenericReportLauncher genericReportLauncher = new frmGenericReportLauncher(nodeToLaunch.Type, nodeToLaunch.Title, getReportControls1);
        genericReportLauncher.ShowInTaskbar = false;
        genericReportLauncher.AutoScroll = true;
        genericReportLauncher.MdiParent = MDIControls.Instance.MDIParent;
        genericReportLauncher.Show();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(report.GetType().Name, "AdHocReportDisplay", false) == 0)
      {
        BaseReportControl[] getReportControls2 = new AdHocReport(nodeToLaunch.ReportID).getReportControls;
        frmGenericReportLauncher genericReportLauncher = new frmGenericReportLauncher(nodeToLaunch.Type, nodeToLaunch.Title, getReportControls2, nodeToLaunch.ReportID);
        genericReportLauncher.ShowInTaskbar = false;
        genericReportLauncher.AutoScroll = true;
        genericReportLauncher.MdiParent = MDIControls.Instance.MDIParent;
        genericReportLauncher.Show();
      }
      else
      {
        frmThreadedReportGeneration reportGeneration = new frmThreadedReportGeneration(nodeToLaunch.Type, nodeToLaunch.Title);
        reportGeneration.ShowBouncingProgress(true);
        reportGeneration.MdiParent = MDIControls.Instance.MDIParent;
        reportGeneration.Show();
      }
    }
    else
    {
      int num = (int) MessageBox.Show($"You do not have permission to run {nodeToLaunch.Title}.", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    Cursor.Current = Cursors.Default;
  }

  private void trvFolders_AfterSelect(object sender, SelectEventArgs e)
  {
    if (((DisposableObjectCollectionBase) e.NewSelections).Count != 1)
      return;
    this.UpdateReportList(e.NewSelections[0].Key);
  }

  private void lstReports_DoubleClick(object sender, EventArgs e)
  {
    if (this.lstReports.SelectedItems.Count != 1)
      return;
    frmReportsAndExports.LaunchReport((ReportNode) this.lstReports.SelectedItems[0]);
  }

  private void lstReports_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.lstReports.SelectedItems.Count != 1)
      return;
    this.UpdateReportInformation((ReportNode) this.lstReports.SelectedItems[0]);
  }

  private void frmReportsAndExports_Load(object sender, EventArgs e)
  {
    this.CreateReportNodes();
    this.CreateFolderNodes();
    if (this.trvFolders.Nodes.Count <= 0)
      return;
    this.trvFolders.Override.Sort = (SortType) 1;
    this.trvFolders.RefreshSort();
    this.trvFolders.Nodes[0].Selected = true;
  }

  private void linkDataDictionary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.lstReports.SelectedItems.Count != 1)
      return;
    this.ShowReportDictionary((ReportNode) this.lstReports.SelectedItems[0]);
  }

  private void ShowReportDictionary(ReportNode nodeToLaunch)
  {
    if (!(Activator.CreateInstance(nodeToLaunch.Type) is ISupportReportDictionary instance))
    {
      int num1 = (int) MessageBox.Show("The dictionary for the selected report is not available at this time. Please try again later.", "Dictionary Not Avaiable!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      using (formReportDataDictionary reportDataDictionary = new formReportDataDictionary(instance))
      {
        int num2 = (int) reportDataDictionary.ShowDialog();
      }
    }
  }

  private void lnkLastUpdated_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (!(this.lstReports.SelectedItems[0] is ReportNode selectedItem))
      return;
    DefaultDatabase.ExecuteNonQuery("DeleteReportProcedureLog", new object[2]
    {
      (object) "@ReportGuid",
      (object) selectedItem.ReportID
    });
    int num = (int) MessageBox.Show("Please re-run report to update Trace", "Trace Cleared", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  private static bool IsLogEnabled(string logKey)
  {
    LogDestination logDestination;
    return MGASystems.IMS.Logging.Log.LogCategoryDestinations != null && MGASystems.IMS.Logging.Log.LogCategoryDestinations.TryGetValue(logKey, out logDestination) && logDestination != LogDestination.Disabled;
  }
}

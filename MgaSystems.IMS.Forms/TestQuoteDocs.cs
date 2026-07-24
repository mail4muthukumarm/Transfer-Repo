// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.TestQuoteDocs
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using GrapeCity.ActiveReports;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.AutomationReports;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class TestQuoteDocs : Form
{
  private IContainer components;
  private DataTable dtForms;
  private bool OptOk;
  private bool OptCancel;
  private TestQuoteDocsData aDocuments;
  private DataView DataGridDataView;
  private string SortByNameString;
  private bool Filtering;
  private string FilterByType;
  private string FilterByInput;
  private Dictionary<string, string> SearchStringsCollection;
  private bool InRecursion;

  public TestQuoteDocs()
  {
    this.Load += new EventHandler(this.TestQuoteDocss_Load);
    this.Resize += new EventHandler(this.TestQuoteDocs_Resize);
    this.OptOk = false;
    this.OptCancel = false;
    this.aDocuments = new TestQuoteDocsData();
    this.DataGridDataView = new DataView();
    this.SortByNameString = "Name ASC";
    this.Filtering = false;
    this.FilterByType = "";
    this.FilterByInput = "";
    this.SearchStringsCollection = new Dictionary<string, string>();
    this.InRecursion = false;
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TestQuoteDocs));
    this.Panel1 = new Panel();
    this.txtControlNo = new TextBox();
    this.btnGenerate = new Button();
    this.Label1 = new Label();
    this.PanelOptions = new Panel();
    this.Panel3 = new Panel();
    this.lstOptions = new ListBox();
    this.Panel4 = new Panel();
    this.btnCancel = new Button();
    this.btnOk = new Button();
    this.Panel2 = new Panel();
    this.Label2 = new Label();
    this.ToolTip1 = new ToolTip(this.components);
    this.Panel5 = new Panel();
    this.btnClearSearch = new Button();
    this.txtFilter = new TextBox();
    this.Label4 = new Label();
    this.DataGridView1 = new DataGridView();
    this.AutomationDocumentID = new DataGridViewTextBoxColumn();
    this.DocName = new DataGridViewTextBoxColumn();
    this.TypeName = new DataGridViewTextBoxColumn();
    this.Description = new DataGridViewTextBoxColumn();
    this.DocumentType = new DataGridViewTextBoxColumn();
    this.ReportType = new DataGridViewTextBoxColumn();
    this.Info = new DataGridViewImageColumn();
    this.AutomationDocumentsBindingSource = new BindingSource(this.components);
    this.TestQuoteDocsData = new TestQuoteDocsData();
    this.ImageList1 = new ImageList(this.components);
    this.BackgroundWorkerPopulateDatabase = new BackgroundWorker();
    this.lblPleaseWait = new Label();
    this.pnlFilterType = new Panel();
    this.chkFilterType = new CheckedListBox();
    this.Panel6 = new Panel();
    this.btnFilterCancel = new Button();
    this.btnFilterOk = new Button();
    this.QuoteDocsData = new TestQuoteDocsData();
    this.DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
    this.lblProgress = new Label();
    this.lblApplying = new Label();
    this.BackgroundWorkerFilter = new BackgroundWorker();
    this.Panel1.SuspendLayout();
    this.PanelOptions.SuspendLayout();
    this.Panel3.SuspendLayout();
    this.Panel4.SuspendLayout();
    this.Panel2.SuspendLayout();
    this.Panel5.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.AutomationDocumentsBindingSource).BeginInit();
    this.TestQuoteDocsData.BeginInit();
    this.pnlFilterType.SuspendLayout();
    this.Panel6.SuspendLayout();
    this.QuoteDocsData.BeginInit();
    this.SuspendLayout();
    this.Panel1.BorderStyle = BorderStyle.FixedSingle;
    this.Panel1.Controls.Add((Control) this.txtControlNo);
    this.Panel1.Controls.Add((Control) this.btnGenerate);
    this.Panel1.Controls.Add((Control) this.Label1);
    this.Panel1.Dock = DockStyle.Top;
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(450, 30);
    this.Panel1.TabIndex = 0;
    this.txtControlNo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtControlNo.Location = new Point(95, 4);
    this.txtControlNo.Name = "txtControlNo";
    this.txtControlNo.Size = new Size(196, 20);
    this.txtControlNo.TabIndex = 8;
    this.btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnGenerate.Location = new Point(303, 3);
    this.btnGenerate.Name = "btnGenerate";
    this.btnGenerate.Size = new Size(133, 23);
    this.btnGenerate.TabIndex = 7;
    this.btnGenerate.Text = "SHOW DOCUMENT";
    this.btnGenerate.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(4, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(80 /*0x50*/, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Control Number";
    this.PanelOptions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.PanelOptions.Controls.Add((Control) this.Panel3);
    this.PanelOptions.Controls.Add((Control) this.Panel4);
    this.PanelOptions.Controls.Add((Control) this.Panel2);
    this.PanelOptions.Location = new Point(0, 0);
    this.PanelOptions.Name = "PanelOptions";
    this.PanelOptions.Size = new Size(387, 342);
    this.PanelOptions.TabIndex = 7;
    this.PanelOptions.Visible = false;
    this.Panel3.Controls.Add((Control) this.lstOptions);
    this.Panel3.Dock = DockStyle.Fill;
    this.Panel3.Location = new Point(0, 23);
    this.Panel3.Name = "Panel3";
    this.Panel3.Size = new Size(387, 286);
    this.Panel3.TabIndex = 2;
    this.lstOptions.Dock = DockStyle.Fill;
    this.lstOptions.FormattingEnabled = true;
    this.lstOptions.Location = new Point(0, 0);
    this.lstOptions.Name = "lstOptions";
    this.lstOptions.Size = new Size(387, 286);
    this.lstOptions.TabIndex = 0;
    this.Panel4.Controls.Add((Control) this.btnCancel);
    this.Panel4.Controls.Add((Control) this.btnOk);
    this.Panel4.Dock = DockStyle.Bottom;
    this.Panel4.Location = new Point(0, 309);
    this.Panel4.Name = "Panel4";
    this.Panel4.Size = new Size(387, 33);
    this.Panel4.TabIndex = 3;
    this.btnCancel.Anchor = AnchorStyles.Bottom;
    this.btnCancel.Location = new Point(217, 5);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(75, 23);
    this.btnCancel.TabIndex = 1;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.btnOk.Anchor = AnchorStyles.Bottom;
    this.btnOk.Location = new Point(95, 5);
    this.btnOk.Name = "btnOk";
    this.btnOk.Size = new Size(75, 23);
    this.btnOk.TabIndex = 0;
    this.btnOk.Text = "Ok";
    this.btnOk.UseVisualStyleBackColor = true;
    this.Panel2.BackColor = SystemColors.GradientActiveCaption;
    this.Panel2.Controls.Add((Control) this.Label2);
    this.Panel2.Dock = DockStyle.Top;
    this.Panel2.Location = new Point(0, 0);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(387, 23);
    this.Panel2.TabIndex = 1;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(16 /*0x10*/, 3);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(92, 16 /*0x10*/);
    this.Label2.TabIndex = 0;
    this.Label2.Text = "Quote Options";
    this.ToolTip1.AutomaticDelay = 300;
    this.ToolTip1.AutoPopDelay = 5000;
    this.ToolTip1.InitialDelay = 300;
    this.ToolTip1.IsBalloon = true;
    this.ToolTip1.ReshowDelay = 60;
    this.Panel5.BorderStyle = BorderStyle.FixedSingle;
    this.Panel5.Controls.Add((Control) this.btnClearSearch);
    this.Panel5.Controls.Add((Control) this.txtFilter);
    this.Panel5.Controls.Add((Control) this.Label4);
    this.Panel5.Dock = DockStyle.Top;
    this.Panel5.Location = new Point(0, 30);
    this.Panel5.Name = "Panel5";
    this.Panel5.Size = new Size(450, 30);
    this.Panel5.TabIndex = 8;
    this.btnClearSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnClearSearch.BackColor = Color.White;
    this.btnClearSearch.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
    this.btnClearSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.btnClearSearch.FlatStyle = FlatStyle.Popup;
    this.btnClearSearch.Font = new Font("Microsoft Sans Serif", 6.5f);
    this.btnClearSearch.Location = new Point(413, 4);
    this.btnClearSearch.Name = "btnClearSearch";
    this.btnClearSearch.Size = new Size(23, 20);
    this.btnClearSearch.TabIndex = 9;
    this.btnClearSearch.Text = "X";
    this.btnClearSearch.TextImageRelation = TextImageRelation.TextAboveImage;
    this.btnClearSearch.UseVisualStyleBackColor = false;
    this.txtFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtFilter.Enabled = false;
    this.txtFilter.Location = new Point(48 /*0x30*/, 4);
    this.txtFilter.Name = "txtFilter";
    this.txtFilter.Size = new Size(367, 20);
    this.txtFilter.TabIndex = 8;
    this.txtFilter.WordWrap = false;
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(4, 8);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(41, 13);
    this.Label4.TabIndex = 0;
    this.Label4.Text = "Search";
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.AllowUserToDeleteRows = false;
    this.DataGridView1.AllowUserToOrderColumns = true;
    this.DataGridView1.AllowUserToResizeColumns = false;
    this.DataGridView1.AutoGenerateColumns = false;
    this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.DataGridView1.Columns.AddRange((DataGridViewColumn) this.AutomationDocumentID, (DataGridViewColumn) this.DocName, (DataGridViewColumn) this.TypeName, (DataGridViewColumn) this.Description, (DataGridViewColumn) this.DocumentType, (DataGridViewColumn) this.ReportType, (DataGridViewColumn) this.Info);
    this.DataGridView1.DataSource = (object) this.AutomationDocumentsBindingSource;
    this.DataGridView1.Dock = DockStyle.Fill;
    this.DataGridView1.Location = new Point(0, 60);
    this.DataGridView1.MultiSelect = false;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.DataGridView1.Size = new Size(450, 378);
    this.DataGridView1.TabIndex = 9;
    this.AutomationDocumentID.DataPropertyName = "AutomationDocumentID";
    this.AutomationDocumentID.HeaderText = "AutomationDocumentID";
    this.AutomationDocumentID.Name = "AutomationDocumentID";
    this.AutomationDocumentID.Visible = false;
    this.DocName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.DocName.DataPropertyName = "Name";
    this.DocName.FillWeight = 92.79695f;
    this.DocName.HeaderText = "Name";
    this.DocName.Name = "DocName";
    this.DocName.SortMode = DataGridViewColumnSortMode.Programmatic;
    this.TypeName.DataPropertyName = "TypeName";
    this.TypeName.HeaderText = "TypeName";
    this.TypeName.Name = "TypeName";
    this.TypeName.Visible = false;
    this.Description.DataPropertyName = "Description";
    this.Description.HeaderText = "Description";
    this.Description.Name = "Description";
    this.Description.Visible = false;
    this.DocumentType.DataPropertyName = "DocumentType";
    this.DocumentType.HeaderText = "DocumentType";
    this.DocumentType.Name = "DocumentType";
    this.DocumentType.Visible = false;
    this.ReportType.DataPropertyName = "Type";
    this.ReportType.HeaderText = "Type";
    this.ReportType.Name = "ReportType";
    this.ReportType.Visible = false;
    this.Info.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.Info.FillWeight = 8.203046f;
    this.Info.HeaderText = "Info";
    this.Info.MinimumWidth = 16 /*0x10*/;
    this.Info.Name = "Info";
    this.Info.Resizable = DataGridViewTriState.False;
    this.AutomationDocumentsBindingSource.DataMember = "AutomationDocuments";
    this.AutomationDocumentsBindingSource.DataSource = (object) this.TestQuoteDocsData;
    this.TestQuoteDocsData.DataSetName = "TestQuoteDocsData";
    this.TestQuoteDocsData.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    this.ImageList1.Images.SetKeyName(0, "code");
    this.ImageList1.Images.SetKeyName(1, "pdf");
    this.ImageList1.Images.SetKeyName(2, "word");
    this.BackgroundWorkerPopulateDatabase.WorkerSupportsCancellation = true;
    this.lblPleaseWait.AutoSize = true;
    this.lblPleaseWait.BackColor = SystemColors.AppWorkspace;
    this.lblPleaseWait.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblPleaseWait.ForeColor = SystemColors.ControlLightLight;
    this.lblPleaseWait.Location = new Point(148, 233);
    this.lblPleaseWait.Name = "lblPleaseWait";
    this.lblPleaseWait.Size = new Size(155, 58);
    this.lblPleaseWait.TabIndex = 10;
    this.lblPleaseWait.Text = "Please wait.\r\nLoading.";
    this.lblPleaseWait.TextAlign = ContentAlignment.MiddleCenter;
    this.pnlFilterType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.pnlFilterType.BorderStyle = BorderStyle.FixedSingle;
    this.pnlFilterType.Controls.Add((Control) this.chkFilterType);
    this.pnlFilterType.Controls.Add((Control) this.Panel6);
    this.pnlFilterType.Location = new Point(312, 65);
    this.pnlFilterType.Name = "pnlFilterType";
    this.pnlFilterType.Size = new Size(135, 90);
    this.pnlFilterType.TabIndex = 11;
    this.pnlFilterType.Visible = false;
    this.chkFilterType.CheckOnClick = true;
    this.chkFilterType.Dock = DockStyle.Fill;
    this.chkFilterType.FormattingEnabled = true;
    this.chkFilterType.Items.AddRange(new object[4]
    {
      (object) "Select All",
      (object) "Automation Documents",
      (object) "Word Templates",
      (object) "PDF Templates"
    });
    this.chkFilterType.Location = new Point(0, 0);
    this.chkFilterType.Name = "chkFilterType";
    this.chkFilterType.Size = new Size(133, 64 /*0x40*/);
    this.chkFilterType.TabIndex = 1;
    this.Panel6.Controls.Add((Control) this.btnFilterCancel);
    this.Panel6.Controls.Add((Control) this.btnFilterOk);
    this.Panel6.Dock = DockStyle.Bottom;
    this.Panel6.Location = new Point(0, 64 /*0x40*/);
    this.Panel6.Name = "Panel6";
    this.Panel6.Size = new Size(133, 24);
    this.Panel6.TabIndex = 0;
    this.btnFilterCancel.Location = new Point(67, 0);
    this.btnFilterCancel.Name = "btnFilterCancel";
    this.btnFilterCancel.Size = new Size(67, 23);
    this.btnFilterCancel.TabIndex = 1;
    this.btnFilterCancel.Text = "Close";
    this.btnFilterCancel.UseVisualStyleBackColor = true;
    this.btnFilterOk.Location = new Point(1, 0);
    this.btnFilterOk.Name = "btnFilterOk";
    this.btnFilterOk.Size = new Size(67, 23);
    this.btnFilterOk.TabIndex = 0;
    this.btnFilterOk.Text = "Apply";
    this.btnFilterOk.UseVisualStyleBackColor = true;
    this.QuoteDocsData.DataSetName = "QuoteDocsData";
    this.QuoteDocsData.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.DataGridViewTextBoxColumn1.DataPropertyName = "Type";
    this.DataGridViewTextBoxColumn1.HeaderText = "Type";
    this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
    this.DataGridViewTextBoxColumn1.Visible = false;
    this.lblProgress.BackColor = SystemColors.AppWorkspace;
    this.lblProgress.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblProgress.ForeColor = SystemColors.ControlLightLight;
    this.lblProgress.Location = new Point(148, 297);
    this.lblProgress.Name = "lblProgress";
    this.lblProgress.Size = new Size(155, 40);
    this.lblProgress.TabIndex = 12;
    this.lblProgress.TextAlign = ContentAlignment.MiddleCenter;
    this.lblApplying.AutoSize = true;
    this.lblApplying.BackColor = SystemColors.AppWorkspace;
    this.lblApplying.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblApplying.ForeColor = SystemColors.ControlLightLight;
    this.lblApplying.Location = new Point(135, 234);
    this.lblApplying.Name = "lblApplying";
    this.lblApplying.Size = new Size(180, 58);
    this.lblApplying.TabIndex = 13;
    this.lblApplying.Text = "Please wait.\r\nApplying filter.";
    this.lblApplying.TextAlign = ContentAlignment.MiddleCenter;
    this.lblApplying.Visible = false;
    this.BackgroundWorkerFilter.WorkerSupportsCancellation = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(450, 438);
    this.Controls.Add((Control) this.lblApplying);
    this.Controls.Add((Control) this.lblProgress);
    this.Controls.Add((Control) this.pnlFilterType);
    this.Controls.Add((Control) this.lblPleaseWait);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.Panel5);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.PanelOptions);
    this.Name = nameof (TestQuoteDocs);
    this.ShowInTaskbar = false;
    this.Text = "Test Quote Documents";
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.PanelOptions.ResumeLayout(false);
    this.Panel3.ResumeLayout(false);
    this.Panel4.ResumeLayout(false);
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    this.Panel5.ResumeLayout(false);
    this.Panel5.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.AutomationDocumentsBindingSource).EndInit();
    this.TestQuoteDocsData.EndInit();
    this.pnlFilterType.ResumeLayout(false);
    this.Panel6.ResumeLayout(false);
    this.QuoteDocsData.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnGenerate
  {
    get => this._btnGenerate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGenerate_Click);
      Button btnGenerate1 = this._btnGenerate;
      if (btnGenerate1 != null)
        btnGenerate1.Click -= eventHandler;
      this._btnGenerate = value;
      Button btnGenerate2 = this._btnGenerate;
      if (btnGenerate2 == null)
        return;
      btnGenerate2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtControlNo")]
  internal virtual TextBox txtControlNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PanelOptions")]
  internal virtual Panel PanelOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel3")]
  internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lstOptions")]
  internal virtual ListBox lstOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel4")]
  internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      Button btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        btnCancel1.Click -= eventHandler;
      this._btnCancel = value;
      Button btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      btnCancel2.Click += eventHandler;
    }
  }

  internal virtual Button btnOk
  {
    get => this._btnOk;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOk_Click);
      Button btnOk1 = this._btnOk;
      if (btnOk1 != null)
        btnOk1.Click -= eventHandler;
      this._btnOk = value;
      Button btnOk2 = this._btnOk;
      if (btnOk2 == null)
        return;
      btnOk2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolTip1")]
  internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel5")]
  internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual TextBox txtFilter
  {
    get => this._txtFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtFilter_KeyUp);
      TextBox txtFilter1 = this._txtFilter;
      if (txtFilter1 != null)
        txtFilter1.KeyUp -= keyEventHandler;
      this._txtFilter = value;
      TextBox txtFilter2 = this._txtFilter;
      if (txtFilter2 == null)
        return;
      txtFilter2.KeyUp += keyEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnClearSearch
  {
    get => this._btnClearSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnClearSearch_Click);
      Button btnClearSearch1 = this._btnClearSearch;
      if (btnClearSearch1 != null)
        btnClearSearch1.Click -= eventHandler;
      this._btnClearSearch = value;
      Button btnClearSearch2 = this._btnClearSearch;
      if (btnClearSearch2 == null)
        return;
      btnClearSearch2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("QuoteDocsData")]
  internal virtual TestQuoteDocsData QuoteDocsData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual DataGridView DataGridView1
  {
    get => this._DataGridView1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewDataErrorEventHandler errorEventHandler = new DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
      DataGridViewCellFormattingEventHandler formattingEventHandler = new DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting);
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellClick);
      DataGridView dataGridView1_1 = this._DataGridView1;
      if (dataGridView1_1 != null)
      {
        dataGridView1_1.DataError -= errorEventHandler;
        dataGridView1_1.CellFormatting -= formattingEventHandler;
        dataGridView1_1.CellClick -= cellEventHandler;
      }
      this._DataGridView1 = value;
      DataGridView dataGridView1_2 = this._DataGridView1;
      if (dataGridView1_2 == null)
        return;
      dataGridView1_2.DataError += errorEventHandler;
      dataGridView1_2.CellFormatting += formattingEventHandler;
      dataGridView1_2.CellClick += cellEventHandler;
    }
  }

  [field: AccessedThroughProperty("AutomationDocumentsBindingSource")]
  internal virtual BindingSource AutomationDocumentsBindingSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TestQuoteDocsData")]
  internal virtual TestQuoteDocsData TestQuoteDocsData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ImageList1")]
  internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual BackgroundWorker BackgroundWorkerPopulateDatabase
  {
    get => this._BackgroundWorkerPopulateDatabase;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.PopulateDatatset);
      RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
      BackgroundWorker populateDatabase1 = this._BackgroundWorkerPopulateDatabase;
      if (populateDatabase1 != null)
      {
        populateDatabase1.DoWork -= workEventHandler;
        populateDatabase1.RunWorkerCompleted -= completedEventHandler;
      }
      this._BackgroundWorkerPopulateDatabase = value;
      BackgroundWorker populateDatabase2 = this._BackgroundWorkerPopulateDatabase;
      if (populateDatabase2 == null)
        return;
      populateDatabase2.DoWork += workEventHandler;
      populateDatabase2.RunWorkerCompleted += completedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblPleaseWait")]
  internal virtual Label lblPleaseWait { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlFilterType")]
  internal virtual Panel pnlFilterType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual CheckedListBox chkFilterType
  {
    get => this._chkFilterType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.chkFilterType_ItemCheck);
      CheckedListBox chkFilterType1 = this._chkFilterType;
      if (chkFilterType1 != null)
        chkFilterType1.ItemCheck -= checkEventHandler;
      this._chkFilterType = value;
      CheckedListBox chkFilterType2 = this._chkFilterType;
      if (chkFilterType2 == null)
        return;
      chkFilterType2.ItemCheck += checkEventHandler;
    }
  }

  [field: AccessedThroughProperty("Panel6")]
  internal virtual Panel Panel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnFilterCancel
  {
    get => this._btnFilterCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnFilterCancel_Click);
      Button btnFilterCancel1 = this._btnFilterCancel;
      if (btnFilterCancel1 != null)
        btnFilterCancel1.Click -= eventHandler;
      this._btnFilterCancel = value;
      Button btnFilterCancel2 = this._btnFilterCancel;
      if (btnFilterCancel2 == null)
        return;
      btnFilterCancel2.Click += eventHandler;
    }
  }

  internal virtual Button btnFilterOk
  {
    get => this._btnFilterOk;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnFilterOk_Click);
      Button btnFilterOk1 = this._btnFilterOk;
      if (btnFilterOk1 != null)
        btnFilterOk1.Click -= eventHandler;
      this._btnFilterOk = value;
      Button btnFilterOk2 = this._btnFilterOk;
      if (btnFilterOk2 == null)
        return;
      btnFilterOk2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("DataGridViewTextBoxColumn1")]
  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblProgress")]
  internal virtual Label lblProgress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblApplying")]
  internal virtual Label lblApplying { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual BackgroundWorker BackgroundWorkerFilter
  {
    get => this._BackgroundWorkerFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker_SetFilter);
      RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorker_SetFilterCompleted);
      BackgroundWorker backgroundWorkerFilter1 = this._BackgroundWorkerFilter;
      if (backgroundWorkerFilter1 != null)
      {
        backgroundWorkerFilter1.DoWork -= workEventHandler;
        backgroundWorkerFilter1.RunWorkerCompleted -= completedEventHandler;
      }
      this._BackgroundWorkerFilter = value;
      BackgroundWorker backgroundWorkerFilter2 = this._BackgroundWorkerFilter;
      if (backgroundWorkerFilter2 == null)
        return;
      backgroundWorkerFilter2.DoWork += workEventHandler;
      backgroundWorkerFilter2.RunWorkerCompleted += completedEventHandler;
    }
  }

  [field: AccessedThroughProperty("AutomationDocumentID")]
  internal virtual DataGridViewTextBoxColumn AutomationDocumentID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DocName")]
  internal virtual DataGridViewTextBoxColumn DocName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TypeName")]
  internal virtual DataGridViewTextBoxColumn TypeName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Description")]
  internal virtual DataGridViewTextBoxColumn Description { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DocumentType")]
  internal virtual DataGridViewTextBoxColumn DocumentType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportType")]
  internal virtual DataGridViewTextBoxColumn ReportType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Info")]
  internal virtual DataGridViewImageColumn Info { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void TestQuoteDocss_Load(object sender, EventArgs e)
  {
    this.BackgroundWorkerPopulateDatabase.RunWorkerAsync();
    this.chkFilterType.SelectedIndex = 0;
    this.chkFilterType.SetItemChecked(0, true);
    this.ResizeOptionsPanel();
    this.btnClearSearch.Top = this.txtFilter.Top;
    this.btnClearSearch.Height = this.txtFilter.Height;
  }

  private void PopulateDatatset(object sender, DoWorkEventArgs e)
  {
    this.WaitMessage("querying object factory");
    Tuple<string, TestQuoteDocs.clsReportList> automationReports = this.GetAutomationReports();
    TestQuoteDocs.clsReportList clsReportList = automationReports.Item2;
    this.WaitMessage("querying database");
    DefaultDatabase.LoadDataSet((DataSet) this.QuoteDocsData, new string[3]
    {
      "AutomationDocuments",
      "Properties",
      "LookUpStrings"
    }, "GetAutomationDocumentsInfo", new object[2]
    {
      (object) "@ReportGuids",
      (object) automationReports.Item1
    });
    this.WaitMessage("combining accrued data");
    try
    {
      foreach (TestQuoteDocsData.AutomationDocumentsRow automationDocument in (TypedTableBase<TestQuoteDocsData.AutomationDocumentsRow>) this.QuoteDocsData.AutomationDocuments)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(automationDocument.DocumentType, "R", false) == 0)
        {
          TestQuoteDocs.clsReportListItem Expression = clsReportList[automationDocument.AutomationDocumentID];
          if (!Information.IsNothing((object) Expression))
          {
            automationDocument.Name = Expression.Title;
            automationDocument.TypeName = Expression.TypeName;
            automationDocument.Description = Expression.Description;
            automationDocument.Type = (object) Expression.ReportType;
            automationDocument.AcceptChanges();
            string str = $"||{Expression.Title}||{Expression.TypeName}||{Expression.Description}";
            DataRow[] dataRowArray = this.QuoteDocsData.LookUpStrings.Select($"AutomationDocumentID = '{automationDocument.AutomationDocumentID}'");
            if (dataRowArray.Length > 1)
            {
              int num = (int) MessageBox.Show("Too Many Search Strings");
              Debugger.Break();
            }
            dataRowArray[0]["SearchString"] = (object) (dataRowArray[0]["SearchString"].ToString() + str);
            dataRowArray[0].AcceptChanges();
            this.QuoteDocsData.Properties.Rows.Add((object) automationDocument.AutomationDocumentID, (object) "Report Name", (object) Expression.Title);
            this.QuoteDocsData.Properties.Rows.Add((object) automationDocument.AutomationDocumentID, (object) "Description", (object) Expression.Description);
            this.QuoteDocsData.Properties.Rows.Add((object) automationDocument.AutomationDocumentID, (object) "Type Name", (object) Expression.TypeName);
            this.QuoteDocsData.Properties.Rows.Add((object) automationDocument.AutomationDocumentID, (object) "Namespace", (object) Expression.ReportType.Namespace);
            this.QuoteDocsData.Properties.AcceptChanges();
          }
        }
      }
    }
    finally
    {
      IEnumerator<TestQuoteDocsData.AutomationDocumentsRow> enumerator;
      enumerator?.Dispose();
    }
    try
    {
      foreach (TestQuoteDocsData.LookUpStringsRow lookUpString in (TypedTableBase<TestQuoteDocsData.LookUpStringsRow>) this.QuoteDocsData.LookUpStrings)
        this.SearchStringsCollection.Add(lookUpString.AutomationDocumentID, lookUpString.SearchString.ToUpper());
    }
    finally
    {
      IEnumerator<TestQuoteDocsData.LookUpStringsRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    this.lblPleaseWait.Visible = false;
    this.lblProgress.Visible = false;
    this.DataGridDataView = new DataView((DataTable) this.QuoteDocsData.AutomationDocuments, "", this.SortByNameString, DataViewRowState.CurrentRows);
    this.DataGridView1.DataSource = (object) this.DataGridDataView;
    this.txtFilter.Enabled = true;
  }

  private void btnGenerate_Click(object sender, EventArgs e)
  {
    if (this.DataGridView1.SelectedRows.Count == 0)
    {
      int num1 = (int) MessageBox.Show("Select document for output.", "No document selected", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else if (this.txtControlNo.Text.Equals(string.Empty) || !Versioned.IsNumeric((object) this.txtControlNo.Text))
    {
      int num2 = (int) MessageBox.Show("Enter the Control Number for the Page you want to Print.");
    }
    else
    {
      string Left = this.DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "R", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "P", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "W", false) != 0)
            return;
          this.GenerateWordTemplate(this.DataGridView1.SelectedRows[0]);
        }
        else
          this.GenerateWordTemplate(this.DataGridView1.SelectedRows[0]);
      }
      else
        this.GenerateReport(this.DataGridView1.SelectedRows[0]);
    }
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    if (this.lstOptions.SelectedIndices.Count < 1)
    {
      int num = (int) MessageBox.Show("Select option", "Option Not selected", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else
      this.OptOk = true;
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.OptCancel = true;

  private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
  {
    if (e.ColumnIndex < 0)
      return;
    int columnIndex = e.ColumnIndex;
    int rowIndex = e.RowIndex;
    string name = this.DataGridView1.Columns[e.ColumnIndex].Name;
  }

  private void TestQuoteDocs_Resize(object sender, EventArgs e) => this.ResizeOptionsPanel();

  private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
  {
    if (this.Filtering || !this.DataGridView1.Columns[e.ColumnIndex].Name.Equals("Info") || !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.DataGridView1[e.ColumnIndex, e.RowIndex].Value)))
      return;
    string Left = this.DataGridView1[4, e.RowIndex].Value.ToString();
    DataGridViewCell dataGridViewCell = this.DataGridView1[e.ColumnIndex, e.RowIndex];
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "R", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "P", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "W", false) != 0)
          return;
        dataGridViewCell.Value = (object) this.ImageList1.Images["word"];
      }
      else
        dataGridViewCell.Value = (object) this.ImageList1.Images["pdf"];
    }
    else
      dataGridViewCell.Value = (object) this.ImageList1.Images["code"];
  }

  private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
  {
    if (!this.DataGridView1.Columns[e.ColumnIndex].Name.Equals("Info"))
    {
      if (e.RowIndex >= 0 || !this.DataGridView1.Columns[e.ColumnIndex].Name.Equals("DocName"))
        return;
      this.SortByName();
    }
    else if (this.DataGridView1.Columns[e.ColumnIndex].Name.Equals("Info") && e.RowIndex < 0)
    {
      this.pnlFilterType.Visible = !this.pnlFilterType.Visible;
    }
    else
    {
      string str1 = this.DataGridView1[5, e.RowIndex].Value.ToString();
      string str2 = this.DataGridView1[0, e.RowIndex].Value.ToString();
      DataRow[] source = this.QuoteDocsData.Properties.Select($"AutomationDocumentID = '{str2}'", "PropertyName ASC");
      Point screen = this.DataGridView1.PointToScreen(this.DataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location);
      TestQuoteDocInfo testQuoteDocInfo;
      if (source.Length > 0)
        testQuoteDocInfo = new TestQuoteDocInfo(new DataView(((IEnumerable<DataRow>) source).CopyToDataTable<DataRow>()).ToTable(true, "PropertyName", "PropertyValue"), str1, str2, screen);
      else
        testQuoteDocInfo = new TestQuoteDocInfo(str1, str2, screen);
      testQuoteDocInfo.Show();
    }
  }

  private void txtFilter_KeyUp(object sender, KeyEventArgs e)
  {
    if (this.BackgroundWorkerFilter.IsBusy)
      this.BackgroundWorkerFilter.CancelAsync();
    while (this.BackgroundWorkerFilter.IsBusy)
      Application.DoEvents();
    this.BackgroundWorkerFilter.RunWorkerAsync((object) this.txtFilter.Text.ToUpper());
  }

  private void BackgroundWorker_SetFilter(object sender, DoWorkEventArgs e)
  {
    Thread.CurrentThread.Priority = ThreadPriority.Lowest;
    this.ShowWaitFilterMessage(true);
    this.Filtering = true;
    this.SetFiters(e.Argument.ToString());
  }

  private void BackgroundWorker_SetFilterCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    if (e.Cancelled)
      return;
    this.Filtering = false;
    this.DataGridView1Refresh();
    this.ShowWaitFilterMessage(false);
  }

  private void chkFilterType_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    if (this.InRecursion)
      return;
    this.InRecursion = true;
    bool flag = true;
    if (e.Index == 0)
    {
      if (e.NewValue == CheckState.Checked)
      {
        int num = this.chkFilterType.Items.Count - 1;
        for (int index = 1; index <= num; ++index)
          this.chkFilterType.SetItemCheckState(index, CheckState.Checked);
      }
      else if (e.NewValue == CheckState.Unchecked)
      {
        int num = this.chkFilterType.Items.Count - 1;
        for (int index = 1; index <= num; ++index)
          this.chkFilterType.SetItemCheckState(index, CheckState.Unchecked);
      }
    }
    else if (e.NewValue == CheckState.Unchecked)
    {
      flag = false;
    }
    else
    {
      int num = this.chkFilterType.Items.Count - 1;
      for (int index = 1; index <= num; ++index)
      {
        if (index == e.Index)
        {
          if (e.NewValue == CheckState.Unchecked)
          {
            flag = false;
            break;
          }
        }
        else if (!this.chkFilterType.GetItemChecked(index))
        {
          flag = false;
          break;
        }
      }
    }
    if (flag)
      this.chkFilterType.SetItemCheckState(0, CheckState.Checked);
    else
      this.chkFilterType.SetItemCheckState(0, CheckState.Unchecked);
    this.InRecursion = false;
  }

  private void btnFilterCancel_Click(object sender, EventArgs e)
  {
    this.pnlFilterType.Visible = false;
  }

  private void btnFilterOk_Click(object sender, EventArgs e)
  {
    string Left = "";
    this.pnlFilterType.Visible = false;
    if (this.chkFilterType.GetItemChecked(0))
    {
      this.FilterByType = "";
    }
    else
    {
      if (this.chkFilterType.GetItemChecked(1))
        Left = "DocumentType = 'R'";
      if (this.chkFilterType.GetItemChecked(2))
        Left = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0 ? Left + " OR DocumentType = 'W'" : "DocumentType = 'W'";
      if (this.chkFilterType.GetItemChecked(3))
        Left = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0 ? Left + " OR DocumentType = 'P'" : "DocumentType = 'P'";
      this.FilterByType = $"({Left})";
      this.DataGridView1Refresh();
    }
  }

  private void btnClearSearch_Click(object sender, EventArgs e)
  {
    this.txtFilter.Text = "";
    this.FilterByInput = "";
    this.DataGridView1Refresh();
  }

  private void SetFiters(string fltr)
  {
    if (string.IsNullOrEmpty(fltr) || string.IsNullOrWhiteSpace(fltr))
    {
      this.FilterByInput = "";
    }
    else
    {
      List<string> values = new List<string>();
      values.Add($"'{Guid.NewGuid().ToString()}'");
      try
      {
        foreach (KeyValuePair<string, string> searchStrings in this.SearchStringsCollection)
        {
          if (searchStrings.Value.Contains(fltr))
            values.Add($"'{searchStrings.Key}'");
        }
      }
      finally
      {
        Dictionary<string, string>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this.FilterByInput = $"(AutomationDocumentID IN ({string.Join(",", (IEnumerable<string>) values)}))";
    }
  }

  private void WaitMessage(string v)
  {
    TestQuoteDocs testQuoteDocs = this;
    string str = v;
    if (this.InvokeRequired)
      this.Invoke((Delegate) ([SpecialName] () => testQuoteDocs.lblProgress.Text = str));
    else
      this.lblProgress.Text = str;
    Application.DoEvents();
  }

  private Tuple<string, TestQuoteDocs.clsReportList> GetAutomationReports()
  {
    string Left = "";
    TestQuoteDocs.clsReportList clsReportList = new TestQuoteDocs.clsReportList();
    try
    {
      foreach (Type ReportType in Cache.AutomationReportMap.Values)
      {
        object[] customAttributes = ReportType.GetCustomAttributes(typeof (AutomationReportAttribute), false);
        int index = 0;
        while (index < customAttributes.Length)
        {
          AutomationReportAttribute automationReportAttribute = (AutomationReportAttribute) customAttributes[index];
          if (automationReportAttribute != null)
          {
            Guid automationReportGuid = automationReportAttribute.AutomationReportGuid;
            clsReportList.AddReport(automationReportGuid, automationReportAttribute.Title, ReportType.Name, automationReportAttribute.Description, ReportType);
            Left = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0 ? $"{Left},{automationReportGuid.ToString()}" : automationReportGuid.ToString();
          }
          checked { ++index; }
        }
      }
    }
    finally
    {
      Dictionary<Guid, Type>.ValueCollection.Enumerator enumerator;
      enumerator.Dispose();
    }
    return new Tuple<string, TestQuoteDocs.clsReportList>(Left, clsReportList);
  }

  private void ShowWaitFilterMessage(bool show)
  {
    TestQuoteDocs testQuoteDocs = this;
    bool flag = show;
    if (this.InvokeRequired)
      this.Invoke((Delegate) ([SpecialName] () => testQuoteDocs.lblApplying.Visible = flag));
    else
      this.lblApplying.Visible = flag;
    Application.DoEvents();
  }

  private void DataGridView1Refresh()
  {
    TestQuoteDocs testQuoteDocs = this;
    string str = "";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.FilterByType, "", false) != 0)
      str = this.FilterByType;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.FilterByInput, "", false) != 0)
      str = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "", false) == 0 ? this.FilterByInput : $"{str} AND {this.FilterByInput}";
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) ([SpecialName] () =>
      {
        testQuoteDocs.DataGridDataView = new DataView((DataTable) testQuoteDocs.QuoteDocsData.AutomationDocuments, str, testQuoteDocs.SortByNameString, DataViewRowState.CurrentRows);
        testQuoteDocs.DataGridView1.DataSource = (object) testQuoteDocs.DataGridDataView;
      }));
    }
    else
    {
      this.DataGridDataView = new DataView((DataTable) this.QuoteDocsData.AutomationDocuments, str, this.SortByNameString, DataViewRowState.CurrentRows);
      this.DataGridView1.DataSource = (object) this.DataGridDataView;
    }
    Application.DoEvents();
  }

  private void GenerateWordTemplate(DataGridViewRow dataGridViewRow)
  {
    Guid quoteGuid = this.GetQuoteGuid();
    if (quoteGuid.Equals(Guid.Empty))
      return;
    string s1 = dataGridViewRow.Cells["AutomationDocumentID"].Value.ToString();
    int result1;
    if (!int.TryParse(s1, out result1))
    {
      int num1 = (int) MessageBox.Show("Cannot understand template id:" + s1);
    }
    else
    {
      try
      {
        string s2 = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT automationGroupID FROM tblDocumentTemplates WHERE TemplateID=@TID", new object[2]
        {
          (object) "@TID",
          (object) result1
        }).ToString();
        int result2;
        if (!int.TryParse(s2, out result2))
        {
          int num2 = (int) MessageBox.Show("Cannot understand Automation Group id:" + s2);
        }
        else
        {
          TagParserBase tagParser = ((TagParserFactory) ObjectFactory.Instance.CreateObject(typeof (TagParserFactory))).GetTagParser(result2, (object) quoteGuid, (object) Guid.Empty);
          DocumentHandling objectEx = (DocumentHandling) ObjectFactory.Instance.CreateObjectEX(typeof (DocumentHandling), (object) result1);
          Guid quoteOptionGuid;
          if (tagParser.SupportsQuoteOptionGuids())
            quoteOptionGuid = this.GetQuoteOptionGuid(quoteGuid);
          if (!quoteOptionGuid.Equals(Guid.Empty))
            objectEx.ShowMergedDocument((object) quoteGuid, (object) quoteOptionGuid);
          else
            objectEx.ShowMergedDocument((object) quoteGuid, (object) Guid.Empty);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        string message = ex.Message;
        ProjectData.ClearProjectError();
      }
      finally
      {
        GC.Collect();
        GC.WaitForPendingFinalizers();
      }
    }
  }

  private void GenerateReport(DataGridViewRow dataGridViewRow)
  {
    Guid quoteGuid = this.GetQuoteGuid();
    if (quoteGuid.Equals(Guid.Empty))
      return;
    Type baseType = (Type) dataGridViewRow.Cells["ReportType"].Value;
    Guid guid = new Guid(dataGridViewRow.Cells["AutomationDocumentID"].Value.ToString());
    string str = dataGridViewRow.Cells["DocName"].Value.ToString();
    object objectValue;
    try
    {
      objectValue = RuntimeHelpers.GetObjectValue(ObjectFactory.Instance.CreateObjectEX(baseType, (object) quoteGuid));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show($"{$"{$"{$"Error creating document. \r\nDocument: {str}\r\n"}Type: {baseType.Name}\r\n"}Automation GUID: {guid.ToString()}\r\n"}Quote GUID: {quoteGuid.ToString()}", "Error creating document.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
      return;
    }
    IQuoteDocument quoteDocument = objectValue as IQuoteDocument;
    bool flag = quoteDocument.RequiresQuoteOptionGuids();
    Guid quoteOptionGuid;
    if (flag)
    {
      quoteOptionGuid = this.GetQuoteOptionGuid(quoteGuid);
      if (quoteOptionGuid.Equals(Guid.Empty) && MessageBox.Show("Cannot find options. Do you want to continue with emply quote option?", "Cannot find options", MessageBoxButtons.YesNo) == DialogResult.No)
        return;
    }
    if (flag)
      quoteDocument.SetQuoteOptionGuids(new Guid[1]
      {
        quoteOptionGuid
      });
    SectionReport report;
    try
    {
      report = (SectionReport) objectValue;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      int num = (int) MessageBox.Show($"{$"{$"{$"{$"Error casting document to SectionReport. \r\nDocument: {str}\r\n"}Type: {baseType.Name}\r\n"}Automation GUID: {guid.ToString()}\r\n"}Quote GUID: {quoteGuid.ToString()}\r\n"}Exception: {exception.ToString()}", "Error executing document.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
      return;
    }
    try
    {
      report.Run();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      int num = (int) MessageBox.Show($"{$"{$"{$"{$"Error executing document. \r\nDocument: {str}\r\n"}Type: {baseType.Name}\r\n"}Automation GUID: {guid.ToString()}\r\n"}Quote GUID: {quoteGuid.ToString()}\r\n"}Exception: {exception.ToString()}", "Error executing document.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
      return;
    }
    new frmPrint(report).Show();
  }

  private Guid GetQuoteGuid()
  {
    Guid guid;
    Guid quoteGuid;
    try
    {
      guid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "Select TOP 1 QuoteGUID FROM tblQuotes WHERE ControlNo = @ControlNo order by tblQuotes.QuoteID DESC ", new object[2]
      {
        (object) "@ControlNo",
        (object) Conversions.ToInteger(this.txtControlNo.Text)
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("Incorrect Control Number", "Control Number not found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      quoteGuid = Guid.Empty;
      ProjectData.ClearProjectError();
      goto label_3;
    }
    quoteGuid = guid;
label_3:
    return quoteGuid;
  }

  private Guid GetQuoteOptionGuid(Guid QuoteGuid)
  {
    string str = "SELECT        tblQuoteOptions.QuoteOptionGUID, tblQuoteOptions.Bound, CONVERT(char(8), tblQuoteOptions.DateCreated, 1) + CHAR(32) + CHAR(45) + CHAR(32) + lstLines.LineName  + CHAR(32) + CHAR(45) + CHAR(32) +  IsNull(tblCompanyLocations.LocationName,CHAR(32)) as Name  FROM            tblQuoteOptions INNER JOIN                          tblCompanyLocations ON tblQuoteOptions.CompanyLocationID = tblCompanyLocations.CompanyLocationCode INNER JOIN                          lstLines ON tblQuoteOptions.LineGUID = lstLines.LineGUID WHERE        (tblQuoteOptions.QuoteGUID = @QuoteGUID) ORDER BY tblQuoteOptions.Bound DESC ";
    int num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "Select COUNT(*) FROM tblQuoteOptions WHERE QuoteGUID = @QuoteGUID", new object[2]
    {
      (object) "@QuoteGUID",
      (object) QuoteGuid.ToString()
    });
    Guid quoteOptionGuid;
    Guid guid;
    if (num > 1)
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, str, new object[2]
      {
        (object) "@QuoteGUID",
        (object) QuoteGuid.ToString()
      });
      this.lstOptions.Items.Clear();
      try
      {
        foreach (DataRow row in dataTable.Rows)
          this.lstOptions.Items.Add((object) new TestQuoteDocs.QuoteDocFormInfo()
          {
            Name = ((!(bool) row["Bound"] ? "      - " : "Bound - ") + row["Name"].ToString()),
            AutomationReportGuid = new Guid(row["QuoteOptionGUID"].ToString())
          });
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.PanelOptions.BringToFront();
      this.PanelOptions.Visible = true;
      this.lstOptions.Select();
      while (!(this.OptOk | this.OptCancel))
        Application.DoEvents();
      this.PanelOptions.Visible = false;
      Application.DoEvents();
      if (this.OptCancel)
      {
        this.OptCancel = false;
        this.OptOk = false;
        quoteOptionGuid = Guid.Empty;
        goto label_18;
      }
      if (this.OptOk)
      {
        this.OptCancel = false;
        this.OptOk = false;
        guid = ((TestQuoteDocs.QuoteDocFormInfo) this.lstOptions.SelectedItem).AutomationReportGuid;
      }
    }
    if (num == 1)
      guid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "Select TOP 1 QuoteOptionGUID FROM tblQuoteOptions WHERE QuoteGUID = @QuoteGUID ORDER BY tblQuoteOptions.Bound DESC", new object[2]
      {
        (object) "@QuoteGUID",
        (object) QuoteGuid.ToString()
      });
    quoteOptionGuid = num >= 1 ? guid : Guid.Empty;
label_18:
    return quoteOptionGuid;
  }

  private void ResizeOptionsPanel()
  {
    this.PanelOptions.Width = this.ClientSize.Width;
    this.PanelOptions.Height = this.ClientSize.Height;
  }

  private void SortByName()
  {
    this.SortByNameString = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SortByNameString, "Name ASC", false) != 0 ? "Name ASC" : "Name DESC";
    this.btnFilterOk_Click((object) null, (EventArgs) null);
  }

  private class QuoteDocFormInfo
  {
    public string Name;
    public Guid AutomationReportGuid;

    public override string ToString() => this.Name;
  }

  private class clsReportList : Dictionary<string, TestQuoteDocs.clsReportListItem>
  {
    public void AddReport(
      Guid AutomationReportGuid,
      string Title,
      string TypeName,
      string Description,
      Type ReportType)
    {
      this.Add(AutomationReportGuid.ToString().ToUpper(), new TestQuoteDocs.clsReportListItem(AutomationReportGuid, Title, TypeName, Description, ReportType));
    }
  }

  private class clsReportListItem
  {
    public Guid AutomationReportGuid;
    public string Title;
    public string TypeName;
    public string Description;
    public Type ReportType;

    public clsReportListItem(
      Guid AutomationReportGuid,
      string Title,
      string TypeName,
      string Description,
      Type ReportType)
    {
      this.AutomationReportGuid = AutomationReportGuid;
      this.Title = Title;
      this.TypeName = TypeName;
      this.Description = Description;
      this.ReportType = ReportType;
    }

    public string AutomationDocumentID
    {
      get => this.AutomationReportGuid.ToString();
      set => this.AutomationReportGuid = new Guid(value);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.PrintAllQuoteDocs
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.DbExtensions;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.AutomationReports;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
[TestForm]
public class PrintAllQuoteDocs : Form
{
  private IContainer components;
  private string SQL;
  private DataTable dtForms;
  private Dictionary<Guid, PrintAllQuoteDocs.QuoteDocFormInfo> AvailableReports;
  private bool Cancel;

  public PrintAllQuoteDocs()
  {
    this.Load += new EventHandler(this.PrintAllQuoteDocs_Load);
    this.Cancel = false;
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
    this.Panel1 = new Panel();
    this.btnGenerate = new Button();
    this.btnPopulateList = new Button();
    this.btnSelectFolder = new Button();
    this.txtOutputFolder = new TextBox();
    this.Label2 = new Label();
    this.DateTimePicker1 = new DateTimePicker();
    this.Label1 = new Label();
    this.CheckedListBox1 = new CheckedListBox();
    this.ContextMenuStrip1 = new ContextMenuStrip(this.components);
    this.CheckAllToolStripMenuItem = new ToolStripMenuItem();
    this.UnCheckAllToolStripMenuItem = new ToolStripMenuItem();
    this.pnlBounce = new Panel();
    this.Label3 = new Label();
    this.ProgressBar1 = new PrintAllQuoteDocs.MyProgressBar();
    this.Panel1.SuspendLayout();
    this.ContextMenuStrip1.SuspendLayout();
    this.pnlBounce.SuspendLayout();
    this.SuspendLayout();
    this.Panel1.Controls.Add((Control) this.btnGenerate);
    this.Panel1.Controls.Add((Control) this.ProgressBar1);
    this.Panel1.Controls.Add((Control) this.btnPopulateList);
    this.Panel1.Controls.Add((Control) this.btnSelectFolder);
    this.Panel1.Controls.Add((Control) this.txtOutputFolder);
    this.Panel1.Controls.Add((Control) this.Label2);
    this.Panel1.Controls.Add((Control) this.DateTimePicker1);
    this.Panel1.Controls.Add((Control) this.Label1);
    this.Panel1.Dock = DockStyle.Top;
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(450, 94);
    this.Panel1.TabIndex = 0;
    this.btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnGenerate.Location = new Point(163, 60);
    this.btnGenerate.Name = "btnGenerate";
    this.btnGenerate.Size = new Size(125, 23);
    this.btnGenerate.TabIndex = 7;
    this.btnGenerate.Text = "GENERATE";
    this.btnGenerate.UseVisualStyleBackColor = true;
    this.btnPopulateList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnPopulateList.Location = new Point(319, 3);
    this.btnPopulateList.Name = "btnPopulateList";
    this.btnPopulateList.Size = new Size(125, 23);
    this.btnPopulateList.TabIndex = 5;
    this.btnPopulateList.Text = "Refresh List";
    this.btnPopulateList.UseVisualStyleBackColor = true;
    this.btnSelectFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnSelectFolder.Location = new Point(385, 28);
    this.btnSelectFolder.Name = "btnSelectFolder";
    this.btnSelectFolder.Size = new Size(22, 20);
    this.btnSelectFolder.TabIndex = 4;
    this.btnSelectFolder.Text = "..";
    this.btnSelectFolder.UseVisualStyleBackColor = true;
    this.txtOutputFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtOutputFolder.Location = new Point(155, 29);
    this.txtOutputFolder.Name = "txtOutputFolder";
    this.txtOutputFolder.Size = new Size(230, 20);
    this.txtOutputFolder.TabIndex = 3;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(5, 33);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(124, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Save results to the folder";
    this.DateTimePicker1.CustomFormat = "MM/dd/yyyy";
    this.DateTimePicker1.Format = DateTimePickerFormat.Custom;
    this.DateTimePicker1.Location = new Point(154, 4);
    this.DateTimePicker1.Name = "DateTimePicker1";
    this.DateTimePicker1.Size = new Size(96 /*0x60*/, 20);
    this.DateTimePicker1.TabIndex = 1;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(4, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(147, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Forms that last time used after";
    this.CheckedListBox1.CheckOnClick = true;
    this.CheckedListBox1.ContextMenuStrip = this.ContextMenuStrip1;
    this.CheckedListBox1.Dock = DockStyle.Fill;
    this.CheckedListBox1.FormattingEnabled = true;
    this.CheckedListBox1.Location = new Point(0, 94);
    this.CheckedListBox1.Name = "CheckedListBox1";
    this.CheckedListBox1.Size = new Size(450, 344);
    this.CheckedListBox1.TabIndex = 1;
    this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.CheckAllToolStripMenuItem,
      (ToolStripItem) this.UnCheckAllToolStripMenuItem
    });
    this.ContextMenuStrip1.Name = "ContextMenuStrip1";
    this.ContextMenuStrip1.Size = new Size(140, 48 /*0x30*/);
    this.CheckAllToolStripMenuItem.Name = "CheckAllToolStripMenuItem";
    this.CheckAllToolStripMenuItem.Size = new Size(139, 22);
    this.CheckAllToolStripMenuItem.Text = "Check All";
    this.UnCheckAllToolStripMenuItem.Name = "UnCheckAllToolStripMenuItem";
    this.UnCheckAllToolStripMenuItem.Size = new Size(139, 22);
    this.UnCheckAllToolStripMenuItem.Text = "UnCheck All";
    this.pnlBounce.Controls.Add((Control) this.Label3);
    this.pnlBounce.Location = new Point(95, 195);
    this.pnlBounce.Name = "pnlBounce";
    this.pnlBounce.Size = new Size(260, 30);
    this.pnlBounce.TabIndex = 6;
    this.pnlBounce.Visible = false;
    this.Label3.Font = new Font("Arial Narrow", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(5, 4);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(248, 24);
    this.Label3.TabIndex = 5;
    this.Label3.Text = "Retrieving list of forms";
    this.ProgressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.ProgressBar1.Location = new Point(13, 60);
    this.ProgressBar1.Name = "ProgressBar1";
    this.ProgressBar1.Size = new Size(422, 23);
    this.ProgressBar1.TabIndex = 6;
    this.ProgressBar1.Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(450, 438);
    this.Controls.Add((Control) this.pnlBounce);
    this.Controls.Add((Control) this.CheckedListBox1);
    this.Controls.Add((Control) this.Panel1);
    this.Name = nameof (PrintAllQuoteDocs);
    this.Text = nameof (PrintAllQuoteDocs);
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.ContextMenuStrip1.ResumeLayout(false);
    this.pnlBounce.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DateTimePicker1")]
  internal virtual DateTimePicker DateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnPopulateList
  {
    get => this._btnPopulateList;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPopulateList_Click);
      Button btnPopulateList1 = this._btnPopulateList;
      if (btnPopulateList1 != null)
        btnPopulateList1.Click -= eventHandler;
      this._btnPopulateList = value;
      Button btnPopulateList2 = this._btnPopulateList;
      if (btnPopulateList2 == null)
        return;
      btnPopulateList2.Click += eventHandler;
    }
  }

  internal virtual Button btnSelectFolder
  {
    get => this._btnSelectFolder;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelectFolder_Click);
      Button btnSelectFolder1 = this._btnSelectFolder;
      if (btnSelectFolder1 != null)
        btnSelectFolder1.Click -= eventHandler;
      this._btnSelectFolder = value;
      Button btnSelectFolder2 = this._btnSelectFolder;
      if (btnSelectFolder2 == null)
        return;
      btnSelectFolder2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtOutputFolder")]
  internal virtual TextBox txtOutputFolder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  private virtual PrintAllQuoteDocs.MyProgressBar ProgressBar1
  {
    get => this._ProgressBar1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ProgressBar1_Click);
      PrintAllQuoteDocs.MyProgressBar progressBar1_1 = this._ProgressBar1;
      if (progressBar1_1 != null)
        progressBar1_1.Click -= eventHandler;
      this._ProgressBar1 = value;
      PrintAllQuoteDocs.MyProgressBar progressBar1_2 = this._ProgressBar1;
      if (progressBar1_2 == null)
        return;
      progressBar1_2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("CheckedListBox1")]
  internal virtual CheckedListBox CheckedListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ContextMenuStrip1")]
  internal virtual ContextMenuStrip ContextMenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem CheckAllToolStripMenuItem
  {
    get => this._CheckAllToolStripMenuItem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CheckAllToolStripMenuItem_Click);
      ToolStripMenuItem toolStripMenuItem1 = this._CheckAllToolStripMenuItem;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this._CheckAllToolStripMenuItem = value;
      ToolStripMenuItem toolStripMenuItem2 = this._CheckAllToolStripMenuItem;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem UnCheckAllToolStripMenuItem
  {
    get => this._UnCheckAllToolStripMenuItem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.UnCheckAllToolStripMenuItem_Click);
      ToolStripMenuItem toolStripMenuItem1 = this._UnCheckAllToolStripMenuItem;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this._UnCheckAllToolStripMenuItem = value;
      ToolStripMenuItem toolStripMenuItem2 = this._UnCheckAllToolStripMenuItem;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("pnlBounce")]
  private virtual Panel pnlBounce { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void PrintAllQuoteDocs_Load(object sender, EventArgs e)
  {
    this.DateTimePicker1.Value = DateTime.Now.AddYears(-2);
    this.SQL = "SELECT DateIssued as LastDateIssued, (SELECT TOP 1 QuoteGUID FROM tblQuotes WHERE tblQuotes.QuoteID=ig.QuoteID) as QuoteGUID, AutomationReportGuid, FormNumber,FormName, (SELECT TOP 1 tblQuoteOptions.QuoteOptionGUID FROM tblQuotes INNER JOIN tblQuoteOptions  ON tblQuoteOptions.QuoteGUID = tblQuotes.QuoteGUID WHERE (tblQuoteOptions.Bound = 1) AND (tblQuotes.QuoteID = ig.QuoteID)) as QuoteOptionGUID, IsNull(FormName, '-- no name --') + IsNull(' [' + FormNumber + ']', ' [-- no form number --]') + ' [FormID#' + CAST(FormID as VARCHAR(10)) + '] [ControlNo#' + (SELECT TOP 1 CAST(ControlNo as VARCHAR(10)) FROM tblQuotes WHERE tblQuotes.QuoteID=ig.QuoteID) + '].pdf' as filename FROM (SELECT  TOP 100 PERCENT MAX(tblQuotes.QuoteID) AS QuoteID, MAX(tblQuotes.DateIssued) AS DateIssued, tblPolicyForms.AutomationReportGuid, tblPolicyForms.FormName,                          tblPolicyForms.FormNumber, tblPolicyForms.FormID FROM            tblQuotes INNER JOIN                          tblQuoteFormsConditionsWarranties ON tblQuotes.QuoteID = tblQuoteFormsConditionsWarranties.QuoteID INNER JOIN                          tblPolicyForms ON tblQuoteFormsConditionsWarranties.PolicyFormID = tblPolicyForms.FormID WHERE        (tblQuotes.OriginalQuoteGUID IS NULL) AND (tblPolicyForms.AutomationReportGuid IS NOT NULL) \t\t\t AND (DateIssued > @DateIssued) GROUP BY tblPolicyForms.AutomationReportGuid, tblPolicyForms.FormName, tblPolicyForms.FormNumber, tblPolicyForms.FormID ORDER BY tblPolicyForms.FormID) ig ";
    this.GetAutomationReports();
  }

  private void GetAutomationReports()
  {
    this.AvailableReports = new Dictionary<Guid, PrintAllQuoteDocs.QuoteDocFormInfo>();
    try
    {
      foreach (Type type in Cache.AutomationReportMap.Values)
      {
        try
        {
          foreach (AutomationReportAttribute automationReportAttribute in type.GetCustomAttributes(typeof (AutomationReportAttribute), false).Cast<AutomationReportAttribute>())
          {
            if (automationReportAttribute != null && !this.AvailableReports.ContainsKey(automationReportAttribute.AutomationReportGuid))
              this.AvailableReports.Add(automationReportAttribute.AutomationReportGuid, new PrintAllQuoteDocs.QuoteDocFormInfo()
              {
                AutomationReportGuid = automationReportAttribute.AutomationReportGuid,
                Description = automationReportAttribute.Description,
                Name = automationReportAttribute.Title,
                DocumentType = type,
                AutomationReportGroup = automationReportAttribute.Group
              });
          }
        }
        finally
        {
          IEnumerator<AutomationReportAttribute> enumerator;
          enumerator?.Dispose();
        }
      }
    }
    finally
    {
      Dictionary<Guid, Type>.ValueCollection.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void btnPopulateList_Click(object sender, EventArgs e)
  {
    this.showBouncingProgressBar(true);
    Application.DoEvents();
    using (DbConnection dbConnection = DefaultDatabase.CreateDbConnection())
    {
      using (DbCommand command = DefaultDatabase.CreateCommand(this.SQL, dbConnection))
      {
        using (DbDataAdapter dataAdapter = DefaultDatabase.CreateDataAdapter(command))
        {
          this.dtForms = new DataTable();
          command.CommandType = CommandType.Text;
          command.CommandTimeout = 0;
          DbParameterCollectionExtensions.DerivedAdd(command.Parameters, "@DateIssued", SqlDbType.Date);
          command.Parameters["@DateIssued"].Value = (object) this.DateTimePicker1.Value;
          DefaultDatabase.DataAdapterFill(dataAdapter, this.dtForms);
        }
      }
    }
    this.CheckedListBox1.Items.Clear();
    try
    {
      foreach (DataRow row in this.dtForms.Rows)
      {
        PrintAllQuoteDocs.QuoteDocFormInfo quoteDocFormInfo = new PrintAllQuoteDocs.QuoteDocFormInfo();
        quoteDocFormInfo.AutomationReportGuid = new Guid(row["AutomationReportGuid"].ToString());
        quoteDocFormInfo.Name = row["FormName"].ToString();
        quoteDocFormInfo.QuoteGuid = new Guid(row["QuoteGUID"].ToString());
        quoteDocFormInfo.Filename = row["filename"].ToString();
        quoteDocFormInfo.FormNumber = row["FormNumber"].ToString();
        quoteDocFormInfo.QuoteOptionGUID = new Guid(row["QuoteOptionGUID"].ToString());
        if (this.AvailableReports.ContainsKey(quoteDocFormInfo.AutomationReportGuid))
          quoteDocFormInfo.DocumentType = this.AvailableReports[quoteDocFormInfo.AutomationReportGuid].DocumentType;
        this.CheckedListBox1.Items.Add((object) quoteDocFormInfo);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.showBouncingProgressBar(false);
  }

  private void CheckAllToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = this.CheckedListBox1.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
      this.CheckedListBox1.SetItemChecked(index, true);
  }

  private void UnCheckAllToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = this.CheckedListBox1.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
      this.CheckedListBox1.SetItemChecked(index, true);
  }

  private void btnGenerate_Click(object sender, EventArgs e)
  {
    if (!Directory.Exists(this.txtOutputFolder.Text))
    {
      int num1 = (int) MessageBox.Show("Select output folder.", "Output folder Not defined", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else if (this.CheckedListBox1.CheckedItems.Count < 1)
    {
      int num2 = (int) MessageBox.Show("Select documents to for output.", "No documents selected", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else
    {
      int num3 = 0;
      this.ProgressBar1.Maximum = this.CheckedListBox1.CheckedIndices.Count;
      this.ProgressBar1.Value = 0;
      this.ProgressBar1.Visible = true;
      this.btnGenerate.Visible = false;
      try
      {
        foreach (object checkedIndex in this.CheckedListBox1.CheckedIndices)
        {
          PrintAllQuoteDocs.QuoteDocFormInfo quoteDocFormInfo = (PrintAllQuoteDocs.QuoteDocFormInfo) this.CheckedListBox1.Items[Conversions.ToInteger(checkedIndex)];
          object objectValue = RuntimeHelpers.GetObjectValue(ObjectFactory.Instance.CreateObjectEX(quoteDocFormInfo.DocumentType, (object) quoteDocFormInfo.QuoteGuid));
          IQuoteDocument quoteDocument = objectValue as IQuoteDocument;
          if (quoteDocument.RequiresQuoteOptionGuids())
            quoteDocument.SetQuoteOptionGuids(new Guid[1]
            {
              quoteDocFormInfo.QuoteOptionGUID
            });
          SectionReport sectionReport = objectValue as SectionReport;
          sectionReport.Run();
          PdfExport pdfExport = new PdfExport();
          string str1 = $"{this.txtOutputFolder.Text}\\{string.Join("_", quoteDocFormInfo.Filename.Split(Path.GetInvalidFileNameChars()))}";
          SectionDocument document = sectionReport.Document;
          string str2 = str1;
          pdfExport.Export(document, str2);
          ++num3;
          this.ProgressBar1.Value = num3;
          Application.DoEvents();
          if (this.Cancel)
          {
            this.Cancel = false;
            break;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.ProgressBar1.Visible = false;
      this.btnGenerate.Visible = true;
    }
  }

  private void btnSelectFolder_Click(object sender, EventArgs e)
  {
    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
    folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
    folderBrowserDialog.SelectedPath = "C:\\Team System Projects\\IMS Client Projects";
    if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
      return;
    this.txtOutputFolder.Text = folderBrowserDialog.SelectedPath;
  }

  private void ProgressBar1_Click(object sender, EventArgs e) => this.Cancel = true;

  private void showBouncingProgressBar(bool show)
  {
    this.pnlBounce.Visible = show;
    if (show)
      this.pnlBounce.BringToFront();
    else
      this.pnlBounce.SendToBack();
  }

  private class QuoteDocFormInfo
  {
    private Guid _AutomationReportGuid;
    private Guid _QuoteGuid;
    private Guid _QuoteOptionGUID;

    public string Name { get; set; }

    public Guid AutomationReportGuid
    {
      get => this._AutomationReportGuid;
      set => this._AutomationReportGuid = value;
    }

    public Guid QuoteGuid
    {
      get => this._QuoteGuid;
      set => this._QuoteGuid = value;
    }

    public string Filename { get; set; }

    public Type DocumentType { get; set; }

    public string Description { get; set; }

    public Enums.AutomationDocGroups AutomationReportGroup { get; set; }

    public string FormNumber { get; set; }

    public Guid QuoteOptionGUID
    {
      get => this._QuoteOptionGUID;
      set => this._QuoteOptionGUID = value;
    }

    public override string ToString()
    {
      string str = this.Name;
      if (!this.FormNumber.Equals(string.Empty))
        str = $"{str} [{this.FormNumber}]";
      return str;
    }
  }

  private class MyProgressBar : ProgressBar
  {
    public MyProgressBar()
    {
      this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      Rectangle clientRectangle = this.ClientRectangle;
      Graphics graphics = e.Graphics;
      ProgressBarRenderer.DrawHorizontalBar(graphics, clientRectangle);
      clientRectangle.Inflate(-3, -3);
      if (this.Value > 0)
      {
        Rectangle bounds = new Rectangle(clientRectangle.X, clientRectangle.Y, (int) Math.Round((double) this.Value / (double) this.Maximum * (double) clientRectangle.Width), clientRectangle.Height);
        ProgressBarRenderer.DrawHorizontalChunks(graphics, bounds);
      }
      string str = "click here to cancel";
      using (Font font = new Font(FontFamily.GenericMonospace, 10f))
      {
        SizeF sizeF = graphics.MeasureString(str, font);
        Point point = new Point((int) Math.Round((double) clientRectangle.Width / 2.0 - (double) sizeF.Width / 2.0), (int) Math.Round((double) clientRectangle.Height / 2.0 - (double) sizeF.Height / 2.0));
        graphics.DrawString(str, font, Brushes.Black, (PointF) point);
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentSystem.AdvancedPrintOptions
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinProgressBar;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTree;
using MGASystems.AsposeFacade.PDF;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Tools;
using MGASystems.Tools.BaseClasses;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.DocumentSystem;

[DesignerGenerated]
public class AdvancedPrintOptions : MGABaseForm
{
  private IContainer components;
  private string _pdfBundleFilename;

  public AdvancedPrintOptions()
  {
    this.Load += new EventHandler(this.AdvancedPrintOptions_Load);
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
    Appearance appearance1 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AdvancedPrintOptions));
    this.labelChooseFolder = new Label();
    this.treeFolders = new UltraTree();
    this.Label2 = new Label();
    this.dateFrom = new MGADateTimePicker();
    this.dateTo = new MGADateTimePicker();
    this.Label3 = new Label();
    this.buttonPrint = new MGAButton();
    this.linkClearSelection = new LinkLabel();
    this.progress = new UltraProgressBar();
    ((ISupportInitialize) this.treeFolders).BeginInit();
    ((ISupportInitialize) this.dateFrom).BeginInit();
    ((ISupportInitialize) this.dateTo).BeginInit();
    ((ISupportInitialize) this.buttonPrint).BeginInit();
    this.SuspendLayout();
    this.labelChooseFolder.AutoSize = true;
    this.labelChooseFolder.BackColor = Color.Transparent;
    this.labelChooseFolder.Location = new Point(13, 61);
    this.labelChooseFolder.Name = "labelChooseFolder";
    this.labelChooseFolder.Size = new Size(136, 13);
    this.labelChooseFolder.TabIndex = 3;
    this.labelChooseFolder.Text = "Choose a folder (optional):";
    this.labelChooseFolder.TextAlign = ContentAlignment.MiddleLeft;
    appearance1.BorderColor = Color.Gray;
    this.treeFolders.Appearance = (AppearanceBase) appearance1;
    this.treeFolders.HideSelection = false;
    ((Control) this.treeFolders).Location = new Point(12, 81);
    ((Control) this.treeFolders).Name = "treeFolders";
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.treeFolders.ScrollBarLook = scrollBarLook;
    ((Control) this.treeFolders).Size = new Size(307, 240 /*0xF0*/);
    ((Control) this.treeFolders).TabIndex = 2;
    ((UltraControlBase) this.treeFolders).UseFlatMode = (DefaultableBoolean) 1;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(12, 28);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(91, 13);
    this.Label2.TabIndex = 5;
    this.Label2.Text = "Bind Date Range:";
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateFrom.Appearance = (AppearanceBase) appearance2;
    appearance3.AlphaLevel = (short) 14;
    appearance3.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance3.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance3.BackColorAlpha = (Alpha) 2;
    appearance3.BackGradientAlignment = (GradientAlignment) 4;
    appearance3.BackGradientStyle = (GradientStyle) 5;
    appearance3.BorderAlpha = (Alpha) 1;
    appearance3.BorderColor = Color.FromArgb(78, 122, 171);
    appearance3.ForeColor = Color.FromArgb(49, 85, 153);
    appearance3.ForegroundAlpha = (Alpha) 2;
    this.dateFrom.ButtonAppearance = (AppearanceBase) appearance3;
    ((Control) this.dateFrom).Location = new Point(109, 25);
    this.dateFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateFrom).Name = "dateFrom";
    ((Control) this.dateFrom).Size = new Size(90, 20);
    ((Control) this.dateFrom).TabIndex = 6;
    ((UltraControlBase) this.dateFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateFrom).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTo.Appearance = (AppearanceBase) appearance4;
    appearance5.AlphaLevel = (short) 14;
    appearance5.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance5.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance5.BackColorAlpha = (Alpha) 2;
    appearance5.BackGradientAlignment = (GradientAlignment) 4;
    appearance5.BackGradientStyle = (GradientStyle) 5;
    appearance5.BorderAlpha = (Alpha) 1;
    appearance5.BorderColor = Color.FromArgb(78, 122, 171);
    appearance5.ForeColor = Color.FromArgb(49, 85, 153);
    appearance5.ForegroundAlpha = (Alpha) 2;
    this.dateTo.ButtonAppearance = (AppearanceBase) appearance5;
    ((Control) this.dateTo).Location = new Point(227, 25);
    this.dateTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTo).Name = "dateTo";
    ((Control) this.dateTo).Size = new Size(90, 20);
    ((Control) this.dateTo).TabIndex = 7;
    ((UltraControlBase) this.dateTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(204, 29);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(17, 13);
    this.Label3.TabIndex = 8;
    this.Label3.Text = "to";
    appearance6.BackColor = Color.FromArgb(248, 248, 248);
    appearance6.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.DarkGray;
    appearance6.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance6.Image"));
    appearance6.ImageHAlign = (HAlign) 1;
    appearance6.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonPrint).Appearance = (AppearanceBase) appearance6;
    ((Control) this.buttonPrint).Location = new Point(192 /*0xC0*/, 327);
    ((Control) this.buttonPrint).Name = "buttonPrint";
    ((Control) this.buttonPrint).Size = new Size((int) sbyte.MaxValue, 27);
    ((Control) this.buttonPrint).TabIndex = 9;
    ((ControlBase) this.buttonPrint).Text = "Print Documents";
    this.buttonPrint.UseOSThemes = (DefaultableBoolean) 2;
    this.linkClearSelection.AutoSize = true;
    this.linkClearSelection.BackColor = Color.Transparent;
    this.linkClearSelection.Location = new Point(239, 61);
    this.linkClearSelection.Name = "linkClearSelection";
    this.linkClearSelection.Size = new Size(78, 13);
    this.linkClearSelection.TabIndex = 10;
    this.linkClearSelection.TabStop = true;
    this.linkClearSelection.Text = "Clear Selection";
    ((Control) this.progress).Location = new Point(16 /*0x10*/, 369);
    ((Control) this.progress).Name = "progress";
    ((Control) this.progress).Size = new Size(303, 15);
    ((Control) this.progress).TabIndex = 11;
    this.progress.Text = "[Formatted]";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(331, 396);
    this.Controls.Add((Control) this.progress);
    this.Controls.Add((Control) this.linkClearSelection);
    this.Controls.Add((Control) this.buttonPrint);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.dateTo);
    this.Controls.Add((Control) this.dateFrom);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.labelChooseFolder);
    this.Controls.Add((Control) this.treeFolders);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (AdvancedPrintOptions);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Advanced Print Options";
    ((ISupportInitialize) this.treeFolders).EndInit();
    ((ISupportInitialize) this.dateFrom).EndInit();
    ((ISupportInitialize) this.dateTo).EndInit();
    ((ISupportInitialize) this.buttonPrint).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("treeFolders")]
  private virtual UltraTree treeFolders { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dateFrom")]
  internal virtual MGADateTimePicker dateFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dateTo")]
  internal virtual MGADateTimePicker dateTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonPrint
  {
    get => this._buttonPrint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonPrint_Click);
      MGAButton buttonPrint1 = this._buttonPrint;
      if (buttonPrint1 != null)
        ((Control) buttonPrint1).Click -= eventHandler;
      this._buttonPrint = value;
      MGAButton buttonPrint2 = this._buttonPrint;
      if (buttonPrint2 == null)
        return;
      ((Control) buttonPrint2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("labelChooseFolder")]
  private virtual Label labelChooseFolder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel linkClearSelection
  {
    get => this._linkClearSelection;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkClearSelection_LinkClicked);
      LinkLabel linkClearSelection1 = this._linkClearSelection;
      if (linkClearSelection1 != null)
        linkClearSelection1.LinkClicked -= clickedEventHandler;
      this._linkClearSelection = value;
      LinkLabel linkClearSelection2 = this._linkClearSelection;
      if (linkClearSelection2 == null)
        return;
      linkClearSelection2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("progress")]
  internal virtual UltraProgressBar progress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void AdvancedPrintOptions_Load(object sender, EventArgs e)
  {
    frmFetchDoc.PopulateFolders(this.treeFolders, false);
  }

  private void buttonPrint_Click(object sender, EventArgs e)
  {
    DataTable documentsTable = this.GetDocumentsTable(false);
    int count = documentsTable.Rows.Count;
    if (count > 0)
    {
      if (MessageBox.Show($"This will print {count.ToString()} document{Interaction.IIf(count == 1, (object) string.Empty, (object) "s").ToString()}.", "Ready to Print", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.OK)
        return;
      this.PrintDocuments(documentsTable);
    }
    else
    {
      int num = (int) MessageBox.Show("No documents matching your criteria were found.", "No Documents Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private DataTable GetDocumentsTable(bool includeDocuments)
  {
    int FalsePart = -1;
    if (((DisposableObjectCollectionBase) this.treeFolders.SelectedNodes).Count == 1)
      FalsePart = Conversions.ToInteger(((frmFetchDoc.FolderNode) this.treeFolders.SelectedNodes[0]).FolderID);
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Cursor.Current = MgaCursors.Default;
      ProjectData.ClearProjectError();
    }
    return Database.Instance.QuerySP.PerformTableQuery("dbo.AdvancedDocumentPrint", (object) "@startDate", this.dateFrom.Value, (object) "@endDate", this.dateTo.Value, (object) "@folderID", Interaction.IIf(FalsePart == -1, (object) null, (object) FalsePart));
  }

  private void linkClearSelection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.treeFolders.SelectedNodes.Clear();
  }

  private void PrintDocuments(DataTable dt)
  {
    this.progress.Value = 0;
    this.progress.Maximum = dt.Rows.Count;
    try
    {
      foreach (DataRow row in dt.Rows)
      {
        using (frmDownloadDocument downloadDocument1 = new frmDownloadDocument((Guid) row[0], new frmDownloadDocument.DownloadComplete(this.DownloadDocument)))
        {
          frmDownloadDocument downloadDocument2 = downloadDocument1;
          downloadDocument2.ShowInTaskbar = false;
          downloadDocument2.LaunchFileWhenDone = false;
          downloadDocument2.StartPosition = FormStartPosition.CenterScreen;
          int num = (int) downloadDocument2.ShowDialog();
          if (downloadDocument1.DownloadAborted)
          {
            this._pdfBundleFilename = string.Empty;
            break;
          }
        }
        UltraProgressBar progress;
        int num1 = (progress = this.progress).Value + 1;
        progress.Value = num1;
        ((UltraControlBase) this.progress).Refresh();
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (!string.IsNullOrEmpty(this._pdfBundleFilename))
    {
      string str1;
      if (((DisposableObjectCollectionBase) this.treeFolders.SelectedNodes).Count == 1)
      {
        str1 = this.treeFolders.SelectedNodes[0].Text;
        char[] invalidFileNameChars = DocumentManager.GetInvalidFileNameChars();
        int index = 0;
        while (index < invalidFileNameChars.Length)
        {
          char ch = invalidFileNameChars[index];
          str1 = str1.Replace(Conversions.ToString(ch), string.Empty);
          checked { ++index; }
        }
      }
      else
        str1 = "IMS Combined Documents";
      string str2 = $"{MGATempFolder.MGATempRandomFolderPath}{str1}.pdf";
      File.Move(this._pdfBundleFilename, str2);
      Process.Start(str2);
      this._pdfBundleFilename = string.Empty;
    }
    this.progress.Value = 0;
  }

  private void DownloadDocument(string fullPath)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Path.GetExtension(fullPath), ".pdf", false) == 0)
      this.AddPDF(fullPath);
    else
      this.AddWordDocument((object) fullPath);
  }

  private void AddPDF(string fullPath)
  {
    if (string.IsNullOrEmpty(this._pdfBundleFilename))
    {
      this._pdfBundleFilename = fullPath;
    }
    else
    {
      PdfFileEditor pdfFileEditor = new PdfFileEditor();
      string str = MGATempFolder.MGATempRandomFolderPath + Path.GetFileName(fullPath);
      try
      {
        pdfFileEditor.Concatenate(fullPath, this._pdfBundleFilename, str);
      }
      catch (IOException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        IOException ex2 = ex1;
        if (ex2.Message.Contains("head signature is not found"))
        {
          ProjectData.ClearProjectError();
          return;
        }
        Utility.ErrorHandling.HandleError((Exception) ex2);
        ProjectData.ClearProjectError();
        return;
      }
      try
      {
        File.Delete(this._pdfBundleFilename);
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      this._pdfBundleFilename = str;
    }
  }

  private void AddWordDocument(object state)
  {
    string wordDocFileName = (string) state;
    string pdf;
    try
    {
      pdf = MGASystems.Common.PDF.ConvertWordDocToPDF(wordDocFileName);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
      return;
    }
    this.AddPDF(pdf);
  }
}

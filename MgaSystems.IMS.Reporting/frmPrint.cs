// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.frmPrint
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using GrapeCity.ActiveReports.Export.Word.Section;
using GrapeCity.ActiveReports.Viewer.Win;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.ErrorHandling;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.Reporting;

public sealed class frmPrint : Form
{
  private SectionReport _report;
  private SaveReportDocuments SaveReport;
  private bool _issueInvoice;
  private List<int> _invoiceNumbers;
  private IContainer components;
  private UltraToolbarsDockArea _frmPrint_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmPrint_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _frmPrint_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmPrint_Toolbars_Dock_Area_Bottom;
  private RtfExport RtfExporter;
  private Label lblWait;

  private virtual GrapeCity.ActiveReports.Viewer.Win.Viewer DocumentViewer
  {
    get => this._DocumentViewer;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      HyperLinkEventHandler linkEventHandler = new HyperLinkEventHandler(this.DocumentViewer_HyperLink);
      LoadCompletedEventHandler completedEventHandler = new LoadCompletedEventHandler(this.DocumentViewer_LoadCompleted);
      GrapeCity.ActiveReports.Viewer.Win.Viewer documentViewer1 = this._DocumentViewer;
      if (documentViewer1 != null)
      {
        documentViewer1.HyperLink -= linkEventHandler;
        documentViewer1.LoadCompleted -= completedEventHandler;
      }
      this._DocumentViewer = value;
      GrapeCity.ActiveReports.Viewer.Win.Viewer documentViewer2 = this._DocumentViewer;
      if (documentViewer2 == null)
        return;
      documentViewer2.HyperLink += linkEventHandler;
      documentViewer2.LoadCompleted += completedEventHandler;
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraToolbarsManager utmMain
  {
    get => this._utmMain;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.utmMain_ToolClick);
      UltraToolbarsManager utmMain1 = this._utmMain;
      if (utmMain1 != null)
        utmMain1.ToolClick -= clickEventHandler;
      this._utmMain = value;
      UltraToolbarsManager utmMain2 = this._utmMain;
      if (utmMain2 == null)
        return;
      utmMain2.ToolClick += clickEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    UltraToolbar ultraToolbar = new UltraToolbar("Toolbar");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("File");
    ButtonTool buttonTool1 = new ButtonTool("Print");
    ButtonTool buttonTool2 = new ButtonTool("Excel");
    ButtonTool buttonTool3 = new ButtonTool("Save");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("File");
    ButtonTool buttonTool4 = new ButtonTool("Save");
    ButtonTool buttonTool5 = new ButtonTool("Print");
    ButtonTool buttonTool6 = new ButtonTool("Excel");
    ButtonTool buttonTool7 = new ButtonTool("RTF");
    ButtonTool buttonTool8 = new ButtonTool("To IMS");
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPrint));
    this.DocumentViewer = new GrapeCity.ActiveReports.Viewer.Win.Viewer();
    this.utmMain = new UltraToolbarsManager(this.components);
    this._frmPrint_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._frmPrint_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmPrint_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmPrint_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.RtfExporter = new RtfExport();
    this.lblWait = new Label();
    ((ISupportInitialize) this.utmMain).BeginInit();
    this.SuspendLayout();
    ((Control) this.DocumentViewer).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((ScrollableControl) this.DocumentViewer).AutoScroll = true;
    ((Control) this.DocumentViewer).BackColor = SystemColors.Control;
    this.DocumentViewer.CurrentPage = 0;
    ((Control) this.DocumentViewer).Location = new Point(0, 0);
    ((Control) this.DocumentViewer).Name = "DocumentViewer";
    this.DocumentViewer.PreviewPages = 0;
    ((SidebarPanel) this.DocumentViewer.Sidebar.ParametersPanel).ContextMenu = (ContextMenu) null;
    ((SidebarPanel) this.DocumentViewer.Sidebar.ParametersPanel).Width = 200;
    ((SidebarPanel) this.DocumentViewer.Sidebar.SearchPanel).ContextMenu = (ContextMenu) null;
    ((SidebarPanel) this.DocumentViewer.Sidebar.SearchPanel).Width = 200;
    ((SidebarPanel) this.DocumentViewer.Sidebar.ThumbnailsPanel).ContextMenu = (ContextMenu) null;
    ((SidebarPanel) this.DocumentViewer.Sidebar.ThumbnailsPanel).Width = 200;
    this.DocumentViewer.Sidebar.ThumbnailsPanel.Zoom = 0.1;
    this.DocumentViewer.Sidebar.TocPanel.ContextMenu = (ContextMenu) null;
    this.DocumentViewer.Sidebar.TocPanel.Expanded = true;
    ((SidebarPanel) this.DocumentViewer.Sidebar.TocPanel).Width = 200;
    this.DocumentViewer.Sidebar.Width = 200;
    ((Control) this.DocumentViewer).Size = new Size(896, 605);
    ((Control) this.DocumentViewer).TabIndex = 0;
    this.utmMain.DesignerFlags = 1;
    this.utmMain.DockWithinContainer = (Control) this;
    this.utmMain.DockWithinContainerBaseType = typeof (Form);
    this.utmMain.SettingsKey = "frmPrint.utmMain";
    this.utmMain.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "Toolbar";
    this.utmMain.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedPropsInternal).Caption = "Print";
    ((ToolBase) buttonTool1).SharedPropsInternal.Category = "File";
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).Caption = "Export To Excel";
    ((ToolBase) buttonTool2).SharedPropsInternal.Category = "File";
    ((ToolBase) buttonTool2).SharedPropsInternal.Enabled = false;
    ((ToolBase) buttonTool2).SharedPropsInternal.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Save";
    ((ToolBase) buttonTool3).SharedPropsInternal.Category = "File";
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "File";
    ((ToolBase) popupMenuTool2).SharedPropsInternal.Category = "File";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6
    });
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).Caption = "Export to RTF";
    ((ToolBase) buttonTool7).SharedPropsInternal.Category = "File";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Save to IMS";
    this.utmMain.Tools.AddRange(new ToolBase[6]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8
    });
    ((Control) this._frmPrint_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPrint_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._frmPrint_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmPrint_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._frmPrint_Toolbars_Dock_Area_Left).Location = new Point(0, 21);
    ((Control) this._frmPrint_Toolbars_Dock_Area_Left).Name = "_frmPrint_Toolbars_Dock_Area_Left";
    ((Control) this._frmPrint_Toolbars_Dock_Area_Left).Size = new Size(0, 584);
    this._frmPrint_Toolbars_Dock_Area_Left.ToolbarsManager = this.utmMain;
    ((Control) this._frmPrint_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPrint_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._frmPrint_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmPrint_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._frmPrint_Toolbars_Dock_Area_Right).Location = new Point(896, 21);
    ((Control) this._frmPrint_Toolbars_Dock_Area_Right).Name = "_frmPrint_Toolbars_Dock_Area_Right";
    ((Control) this._frmPrint_Toolbars_Dock_Area_Right).Size = new Size(0, 584);
    this._frmPrint_Toolbars_Dock_Area_Right.ToolbarsManager = this.utmMain;
    ((Control) this._frmPrint_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPrint_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._frmPrint_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmPrint_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._frmPrint_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmPrint_Toolbars_Dock_Area_Top).Name = "_frmPrint_Toolbars_Dock_Area_Top";
    ((Control) this._frmPrint_Toolbars_Dock_Area_Top).Size = new Size(896, 21);
    this._frmPrint_Toolbars_Dock_Area_Top.ToolbarsManager = this.utmMain;
    ((Control) this._frmPrint_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPrint_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._frmPrint_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmPrint_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._frmPrint_Toolbars_Dock_Area_Bottom).Location = new Point(0, 605);
    ((Control) this._frmPrint_Toolbars_Dock_Area_Bottom).Name = "_frmPrint_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmPrint_Toolbars_Dock_Area_Bottom).Size = new Size(896, 0);
    this._frmPrint_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.utmMain;
    this.RtfExporter.EnableShapes = false;
    this.RtfExporter.Pagination = true;
    this.lblWait.Anchor = AnchorStyles.None;
    this.lblWait.BackColor = Color.White;
    this.lblWait.BorderStyle = BorderStyle.FixedSingle;
    this.lblWait.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblWait.Location = new Point(280, 280);
    this.lblWait.Name = "lblWait";
    this.lblWait.Size = new Size(328, 40);
    this.lblWait.TabIndex = 5;
    this.lblWait.Text = "Generating...";
    this.lblWait.TextAlign = ContentAlignment.MiddleCenter;
    this.lblWait.Visible = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(896, 605);
    this.Controls.Add((Control) this.lblWait);
    this.Controls.Add((Control) this.DocumentViewer);
    this.Controls.Add((Control) this._frmPrint_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmPrint_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmPrint_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmPrint_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmPrint);
    ((ISupportInitialize) this.utmMain).EndInit();
    this.ResumeLayout(false);
  }

  private void PrintDocument()
  {
    PaperKind paperKind = this._report.PageSettings.PaperKind;
    PrintDialog printDialog1 = new PrintDialog();
    try
    {
      PrintDialog printDialog2 = printDialog1;
      printDialog2.PrinterSettings = ((System.Drawing.Printing.PrintDocument) this.DocumentViewer.Document.Printer).PrinterSettings;
      printDialog2.AllowSomePages = true;
      printDialog2.PrinterSettings.FromPage = 1;
      printDialog2.PrinterSettings.ToPage = this.DocumentViewer.Document.Pages.Count;
      this.DocumentViewer.Document.Printer.PrinterName = (string) null;
      if (printDialog1.ShowDialog() == DialogResult.Cancel)
        return;
      ((System.Drawing.Printing.PrintDocument) this.DocumentViewer.Document.Printer).PrinterSettings = printDialog1.PrinterSettings;
      this.DocumentViewer.Document.Printer.PaperKind = paperKind;
      PrintExtension.Print(this.DocumentViewer.Document, false, false);
      if (!this.IssueInvoices)
        return;
      this.MarkInvoicesAsPrinted();
    }
    finally
    {
      printDialog1.Dispose();
    }
  }

  public void ShowWaitMessage()
  {
    this.lblWait.Visible = true;
    this.lblWait.BringToFront();
  }

  public void HideWaitMessage() => this.lblWait.Hide();

  private void MarkInvoicesAsPrinted()
  {
    try
    {
      foreach (int invoiceNumber in this._invoiceNumbers)
        Messaging.SendBroadcastMessage(BroadcastMessages.InvoicePrinted, (object) invoiceNumber);
    }
    finally
    {
      List<int>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  internal static string FormatReportName(SectionReport rpt)
  {
    return Operators.CompareString(rpt.Document.Name.ToLower(), "activereports document", false) == 0 || Operators.CompareString(rpt.Document.Name.ToLower(), "arnet document", false) == 0 ? rpt.ToString() : rpt.Document.Name;
  }

  public void ShowReport()
  {
    this.Text = frmPrint.FormatReportName(this._report);
    this.SaveReport = new SaveReportDocuments(ref this._report);
    if (((Control) this.DocumentViewer).IsDisposed)
      return;
    try
    {
      this._report.Document.Printer.PrinterName = (string) null;
      this.DocumentViewer.LoadDocument(this._report.Document);
    }
    catch (IndexOutOfRangeException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("An error has occured while trying to display this report.\n\nIf this problem persists, please contact technical support.", "Error Displaying Report", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    catch (ApplicationException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ApplicationException innerException = ex;
      if (innerException.Message.Equals("Printer does not support the given paper size"))
      {
        ErrorHandler.SilentHandleError((Exception) new ApplicationException($"{innerException.Message} Printer Name: {((System.Drawing.Printing.PrintDocument) this._report.Document.Printer).PrinterSettings.PrinterName}", (Exception) innerException));
        int num = (int) MessageBox.Show("Printer does not support this report's paper size.\n\nPlease be aware if you try to print this document it might not output as expected.", "Unsupported printer paper size", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      ProjectData.ClearProjectError();
    }
    catch (OutOfMemoryException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("The report is too large to display. Please export to Excel.", "Error Displaying Report", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    catch (InvalidPrinterException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("Default printer not set. Please setup Default Printer and try again.", "Error Displaying Report", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    this.EnableButtons();
  }

  private void SaveFile()
  {
    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
    {
      PdfExport pdfExport = (PdfExport) null;
      try
      {
        saveFileDialog.DefaultExt = ".pdf";
        saveFileDialog.Filter = "PDF Files(*.pdf)|*.pdf";
        if ((object) this.Report.GetType().GetProperty("DefaultFileName") != null)
        {
          string defaultFileName = ((MGAReport) this._report).DefaultFileName;
          if (Operators.CompareString(defaultFileName.Trim(), "", false) != 0)
            saveFileDialog.FileName = defaultFileName.Trim();
        }
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
          return;
        pdfExport = new PdfExport();
        pdfExport.Export(this.DocumentViewer.Document, saveFileDialog.FileName);
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show("The file was unable to be saved.  Please make sure the file you are saving to is not currently open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
      finally
      {
        ((Component) pdfExport)?.Dispose();
      }
    }
  }

  private void ExportToExcel()
  {
    if (!(this._report is MGAReport) || !((MGAReport) this._report).HasRecords)
      return;
    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
    {
      try
      {
        if (ReportingExcelExport.ExcelExportFormatPreference() == 6)
        {
          saveFileDialog.DefaultExt = ".xlsx";
          saveFileDialog.Filter = "Excel File (*.xlsx)|*.xlsx|Excel File 97-2003 (*.xls)|*.xls";
        }
        else
        {
          saveFileDialog.DefaultExt = ".xls";
          saveFileDialog.Filter = "Excel Files(*.xls)|*.xls";
        }
        if ((object) this.Report.GetType().GetProperty("DefaultFileName") != null)
        {
          string defaultFileName = ((MGAReport) this._report).DefaultFileName;
          if (Operators.CompareString(defaultFileName.Trim(), "", false) != 0)
            saveFileDialog.FileName = defaultFileName.Trim();
        }
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
          return;
        ((MGAReport) this._report).ExportToExcel(saveFileDialog.FileName);
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show("The file was unable to be saved.  Please make sure the file you are saving to is not currently open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void ExportToExcelEx()
  {
    if (!(this.Report is MGAReport) || !((MGAReport) this._report).HasRecords)
      return;
    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
    {
      try
      {
        if (ReportingExcelExport.ExcelExportFormatPreference() == 6)
        {
          saveFileDialog.DefaultExt = ".xlsx";
          saveFileDialog.Filter = "Excel File (*.xlsx)|*.xlsx|Excel File 97-2003 (*.xls)|*.xls";
        }
        else
        {
          saveFileDialog.DefaultExt = ".xls";
          saveFileDialog.Filter = "Excel Files(*.xls)|*.xls";
        }
        if ((object) this.Report.GetType().GetProperty("DefaultFileName") != null)
        {
          string defaultFileName = ((MGAReport) this._report).DefaultFileName;
          if (Operators.CompareString(defaultFileName.Trim(), "", false) != 0)
            saveFileDialog.FileName = defaultFileName.Trim();
        }
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
          return;
        ((MGAReport) this._report).ExportToExcel(saveFileDialog.FileName);
        Process.Start(saveFileDialog.FileName);
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show("The file was unable to be saved.  Please make sure the file you are saving to is not currently open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void ExportToEmail()
  {
    if (this._report is MGAReport)
    {
      if (((MGAReport) this._report).HasRecords)
      {
        try
        {
          ((MGAReport) this._report).Email();
          return;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num = (int) MessageBox.Show("This report cannot be saved.  Please make sure the file you are saving to is not currently open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
          return;
        }
      }
    }
    if (!(this._report is SectionReport))
      return;
    if (this._report.Document == null)
      return;
    try
    {
      using (MGAReport mgaReport = new MGAReport())
      {
        mgaReport.Document.Pages.AddRange(this._report.Document.Pages);
        mgaReport.Email();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("This report cannot be saved.  Please make sure the file you are saving to is not currently open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
  }

  private void ExportLayout()
  {
    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
    {
      try
      {
        saveFileDialog.DefaultExt = ".rpx";
        saveFileDialog.Filter = "ActiveReports Layout Files(*.rpx)|*.rpx";
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
          return;
        using (XmlWriter xmlWriter = XmlWriter.Create(saveFileDialog.FileName))
        {
          this._report.SaveLayout(xmlWriter);
          xmlWriter.Close();
        }
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show("The file was unable to be saved.  Please make sure the file you are saving to is not currently open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void ExportToRTF()
  {
    using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
    {
      try
      {
        SaveFileDialog saveFileDialog2 = saveFileDialog1;
        saveFileDialog2.DefaultExt = ".rtf";
        saveFileDialog2.FileName = "";
        saveFileDialog2.Filter = "Rich Text Document(*.rtf)|*.rtf";
        if ((object) this.Report.GetType().GetProperty("DefaultFileName") != null)
        {
          string defaultFileName = ((MGAReport) this._report).DefaultFileName;
          if (Operators.CompareString(defaultFileName.Trim(), "", false) != 0)
            saveFileDialog1.FileName = defaultFileName.Trim();
        }
        if (saveFileDialog1.ShowDialog() != DialogResult.OK)
          return;
        this.RtfExporter.Export(this._report.Document, saveFileDialog1.FileName);
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show("The file was unable to be saved.  Please make sure the file you are saving to is not currently open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void SaveToDocHandler()
  {
    try
    {
      new SaveReportDocuments(ref this._report).SaveToFolder();
    }
    catch (IOException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      IOException ex2 = ex1;
      if (ex2.Message.Contains("used by another process"))
      {
        int num = (int) MessageBox.Show("Cannot execute this request at the momemt because it is being used by another process", "Report Being Used By Another Process", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
        ErrorHandler.HandleError((Exception) ex2);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private bool CheckQuoteGuid() => this.SaveReport != null && this.SaveReport.CanSave;

  private void DisplayReport(SectionReport rpt)
  {
    this._report = rpt;
    this.ShowReport();
  }

  public SectionReport Report
  {
    get => this._report;
    set => this._report = value;
  }

  public string WaitMessage
  {
    get => this.lblWait.Text;
    set => this.lblWait.Text = value;
  }

  public bool IssueInvoices
  {
    get => this._issueInvoice;
    set => this._issueInvoice = value;
  }

  public List<int> InvoiceNumbers
  {
    get => this._invoiceNumbers;
    set => this._invoiceNumbers = value;
  }

  public frmPrint()
  {
    this.Load += new EventHandler(this.frmPrint_Load);
    this.MdiParent = MDIControls.Instance.MDIParent;
    this.InitializeComponent();
    this.MdiParent = (Form) null;
    this.DocumentViewer.Toolbar.ToolStrip.ItemClicked += new ToolStripItemClickedEventHandler(this.DocumentViewer_ToolClick);
  }

  public frmPrint(SectionReport report)
  {
    this.Load += new EventHandler(this.frmPrint_Load);
    this.MdiParent = MDIControls.Instance.MDIParent;
    this.InitializeComponent();
    this.MdiParent = (Form) null;
    this._report = report;
    if (this._report != null && this._report.GetType().BaseType == typeof (MGAReport) && ((MGAReport) this._report).ExcelOnly)
    {
      this.ExportToExcelEx();
    }
    else
    {
      this.DocumentViewer.Toolbar.ToolStrip.ItemClicked += new ToolStripItemClickedEventHandler(this.DocumentViewer_ToolClick);
      this.ShowReport();
    }
  }

  private void frmPrint_Load(object sender, EventArgs e)
  {
    if (this._report != null && this._report.GetType().BaseType == typeof (MGAReport) && ((MGAReport) this._report).ExcelOnly)
    {
      this.BeginInvoke((Delegate) new MethodInvoker(((Form) this).Close));
    }
    else
    {
      this.DocumentViewer.Toolbar.ToolStrip.Items.RemoveByKey("tsbPrint");
      this.DocumentViewer.Toolbar.ToolStrip.Items.RemoveByKey("cancelButton");
      this.DocumentViewer.Toolbar.ToolStrip.Items.RemoveByKey("tsbRefresh");
      this.DocumentViewer.Toolbar.ToolStrip.Items.RemoveByKey("tsbFind");
      this.DocumentViewer.Toolbar.ToolStrip.Items.RemoveByKey("tsSep5");
      this.DocumentViewer.Toolbar.ToolStrip.Items.RemoveByKey("tsSep4");
      this.AddMenuItems();
      if (this._report == null)
        this.DisableButtons();
      if (this._report is MGAExcelReport)
      {
        if (((MGAReport) this._report).HasRecords)
        {
          try
          {
            ((MGAExcelReport) this._report).Export();
            this.BeginInvoke((Delegate) new MethodInvoker(((Form) this).Close));
          }
          catch (IOException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            int num = (int) MessageBox.Show("The file was unable to be saved.  Please make sure the file you are saving to is not currently open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            ProjectData.ClearProjectError();
          }
        }
      }
      if (!(this._report is MGAReport) || !((MGAReport) this._report).HasRecords)
        return;
      if (!((MGAReport) this._report).ExcelOnly)
        return;
      try
      {
        this.ExportToExcelEx();
        this.BeginInvoke((Delegate) new MethodInvoker(((Form) this).Close));
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show("The file was unable to be saved.  Please make sure the file you are saving to is not currently open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void utmMain_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (((ToolEventArgs) e).Tool == null)
      return;
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Operators.CompareString(key, "Print", false) != 0)
    {
      if (Operators.CompareString(key, "Save", false) != 0)
      {
        if (Operators.CompareString(key, "Excel", false) != 0)
        {
          if (Operators.CompareString(key, "RTF", false) != 0)
          {
            if (Operators.CompareString(key, "Save to IMS", false) != 0)
              return;
            this.SaveToDocHandler();
          }
          else
            this.ExportToRTF();
        }
        else
          this.ExportToExcel();
      }
      else
        this.SaveFile();
    }
    else
      this.PrintDocument();
  }

  private void DocumentViewer_ToolClick(object sender, ToolStripItemClickedEventArgs e)
  {
    if (e.ClickedItem.Tag == null)
      return;
    switch ((frmPrint.ToolIds) e.ClickedItem.Tag)
    {
      case frmPrint.ToolIds.Print:
        this.PrintDocument();
        break;
      case frmPrint.ToolIds.Save:
        this.SaveFile();
        break;
      case frmPrint.ToolIds.Email:
        this.ExportToEmail();
        break;
      case frmPrint.ToolIds.ToExcel:
        this.ExportToExcel();
        break;
      case frmPrint.ToolIds.ToRTF:
        this.ExportToRTF();
        break;
      case frmPrint.ToolIds.ToDocHandler:
        this.SaveToDocHandler();
        break;
      case frmPrint.ToolIds.Find:
        this.DocumentViewer.Sidebar.Visible = !this.DocumentViewer.Sidebar.Visible;
        this.DocumentViewer.Sidebar.SelectedIndex = 2;
        break;
      case frmPrint.ToolIds.ExportLayout:
        this.ExportLayout();
        break;
    }
  }

  private void AddMenuItems()
  {
    this.DocumentViewer.Toolbar.ToolStrip.ImageList = new ImageList();
    this.DocumentViewer.Toolbar.ToolStrip.ImageList.Images.Add(ImageCache.Instance.Save);
    ToolStripButton toolStripButton1 = new ToolStripButton();
    ToolStripButton toolStripButton2 = toolStripButton1;
    toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
    toolStripButton2.ImageIndex = this.DocumentViewer.Toolbar.ToolStrip.ImageList.Images.Count - 1;
    toolStripButton2.Tag = (object) frmPrint.ToolIds.Save;
    toolStripButton2.Text = "Save";
    toolStripButton2.ToolTipText = "Save Document";
    this.DocumentViewer.Toolbar.ToolStrip.Items.Insert(0, (ToolStripItem) toolStripButton1);
    if (this._report is MGAReport)
    {
      this.DocumentViewer.Toolbar.ToolStrip.ImageList.Images.Add(ImageCache.Instance.Excel);
      ToolStripButton toolStripButton3 = new ToolStripButton();
      toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
      ToolStripButton toolStripButton4 = toolStripButton3;
      ToolStripButton toolStripButton5 = toolStripButton4;
      toolStripButton5.ImageIndex = this.DocumentViewer.Toolbar.ToolStrip.ImageList.Images.Count - 1;
      toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
      toolStripButton5.Tag = (object) frmPrint.ToolIds.ToExcel;
      toolStripButton5.Text = "To Excel";
      toolStripButton5.ToolTipText = "Export to Excel";
      this.DocumentViewer.Toolbar.ToolStrip.Items.Insert(1, (ToolStripItem) toolStripButton4);
      ((ToolsCollectionBase) this.utmMain.Tools)["Excel"].SharedProps.Enabled = true;
      ((ToolsCollectionBase) this.utmMain.Tools)["Excel"].SharedProps.Visible = true;
    }
    this.DocumentViewer.Toolbar.ToolStrip.ImageList.Images.Add(ImageCache.Instance.RTFExport);
    ToolStripButton toolStripButton6 = new ToolStripButton();
    toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
    ToolStripButton toolStripButton7 = toolStripButton6;
    ToolStripButton toolStripButton8 = toolStripButton7;
    toolStripButton8.ImageIndex = this.DocumentViewer.Toolbar.ToolStrip.ImageList.Images.Count - 1;
    toolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
    toolStripButton8.Tag = (object) frmPrint.ToolIds.ToRTF;
    toolStripButton8.Text = "To RTF";
    toolStripButton8.ToolTipText = "Export to Rich Text File";
    this.DocumentViewer.Toolbar.ToolStrip.Items.Insert(2, (ToolStripItem) toolStripButton7);
    this.DocumentViewer.Toolbar.ToolStrip.ImageList.Images.Add(ImageCache.Instance.Print_Small);
    ToolStripButton toolStripButton9 = new ToolStripButton();
    toolStripButton9.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
    ToolStripButton toolStripButton10 = toolStripButton9;
    ToolStripButton toolStripButton11 = toolStripButton10;
    toolStripButton11.ImageIndex = this.DocumentViewer.Toolbar.ToolStrip.ImageList.Images.Count - 1;
    toolStripButton11.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
    toolStripButton11.Tag = (object) frmPrint.ToolIds.Print;
    toolStripButton11.Text = " Print... ";
    toolStripButton11.ToolTipText = "Print Report";
    this.DocumentViewer.Toolbar.ToolStrip.Items.Insert(3, (ToolStripItem) toolStripButton10);
    if (this.SaveReport == null)
      this.SaveReport = new SaveReportDocuments(ref this._report);
    if (this.SaveReport.CanSave)
    {
      this.DocumentViewer.Toolbar.ToolStrip.ImageList.Images.Add(ImageCache.Instance.DocAssociated);
      ToolStripButton toolStripButton12 = new ToolStripButton();
      toolStripButton12.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
      ToolStripButton toolStripButton13 = toolStripButton12;
      ToolStripButton toolStripButton14 = toolStripButton13;
      toolStripButton14.ImageIndex = this.DocumentViewer.Toolbar.ToolStrip.ImageList.Images.Count - 1;
      toolStripButton14.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
      toolStripButton14.Tag = (object) frmPrint.ToolIds.ToDocHandler;
      toolStripButton14.Text = "To IMS";
      toolStripButton14.ToolTipText = "Save to IMS Documents";
      toolStripButton14.Visible = this.CheckQuoteGuid();
      this.DocumentViewer.Toolbar.ToolStrip.Items.Insert(4, (ToolStripItem) toolStripButton13);
    }
    this.DocumentViewer.Toolbar.ToolStrip.ImageList.Images.Add(ImageCache.Instance.BulkEmail);
    ToolStripButton toolStripButton15 = new ToolStripButton();
    ToolStripButton toolStripButton16 = toolStripButton15;
    toolStripButton16.ImageIndex = this.DocumentViewer.Toolbar.ToolStrip.ImageList.Images.Count - 1;
    toolStripButton16.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
    toolStripButton16.Tag = (object) frmPrint.ToolIds.Email;
    toolStripButton16.Text = "Email";
    toolStripButton16.ToolTipText = "Email Report using Outlook";
    this.DocumentViewer.Toolbar.ToolStrip.Items.Insert(5, (ToolStripItem) toolStripButton15);
    this.DocumentViewer.Toolbar.ToolStrip.ImageList.Images.Add(ImageCache.Instance.Search);
    ToolStripButton toolStripButton17 = new ToolStripButton();
    ToolStripButton toolStripButton18 = toolStripButton17;
    toolStripButton18.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
    toolStripButton18.ImageIndex = this.DocumentViewer.Toolbar.ToolStrip.ImageList.Images.Count - 1;
    toolStripButton18.Tag = (object) frmPrint.ToolIds.Find;
    toolStripButton18.Text = "Find";
    toolStripButton18.ToolTipText = "Find";
    this.DocumentViewer.Toolbar.ToolStrip.Items.Insert(6, (ToolStripItem) toolStripButton17);
    if (!CurrentUser.IsMGADeveloper)
      return;
    this.DocumentViewer.Toolbar.ToolStrip.ImageList.Images.Add(ImageCache.Instance.ReportGeneration);
    ToolStripButton toolStripButton19 = new ToolStripButton();
    ToolStripButton toolStripButton20 = toolStripButton19;
    toolStripButton20.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
    toolStripButton20.ImageIndex = this.DocumentViewer.Toolbar.ToolStrip.ImageList.Images.Count - 1;
    toolStripButton20.Tag = (object) frmPrint.ToolIds.ExportLayout;
    toolStripButton20.Text = "Layout";
    toolStripButton20.ToolTipText = "Layout Export";
    this.DocumentViewer.Toolbar.ToolStrip.Items.Insert(7, (ToolStripItem) toolStripButton19);
  }

  private void DocumentViewer_HyperLink(object sender, HyperLinkEventArgs e)
  {
    if (!(this._report is MGAReport))
      return;
    ((MGAReport) this._report).Hyperlink(RuntimeHelpers.GetObjectValue(sender), e);
  }

  private void DocumentViewer_LoadCompleted(object sender, EventArgs e)
  {
    if (this.SaveReport == null || !this.SaveReport.ShouldSave)
      return;
    this.SaveReport.SaveToFolder();
  }

  private void SetButtonsEnabledProperty(bool enabled)
  {
    int num = this.DocumentViewer.Toolbar.ToolStrip.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (this.DocumentViewer.Toolbar.ToolStrip.Items[index] != null)
        this.DocumentViewer.Toolbar.ToolStrip.Items[index].Enabled = enabled;
    }
  }

  private void DisableButtons() => this.SetButtonsEnabledProperty(false);

  private void EnableButtons() => this.SetButtonsEnabledProperty(true);

  public enum ToolIds
  {
    Print = 5001, // 0x00001389
    Save = 5002, // 0x0000138A
    Email = 5003, // 0x0000138B
    ToExcel = 5004, // 0x0000138C
    ToRTF = 5005, // 0x0000138D
    ToDocHandler = 5006, // 0x0000138E
    Find = 5007, // 0x0000138F
    ExportLayout = 5008, // 0x00001390
  }
}

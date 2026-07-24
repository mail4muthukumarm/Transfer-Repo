// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmCheckPrinting
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Viewer.Win;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

public sealed class frmCheckPrinting : Form
{
  private IContainer components;

  public frmCheckPrinting() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.docViewer = new GrapeCity.ActiveReports.Viewer.Win.Viewer();
    this.SuspendLayout();
    ((Control) this.docViewer).BackColor = SystemColors.Control;
    ((Control) this.docViewer).Dock = DockStyle.Fill;
    ((Control) this.docViewer).Location = new Point(0, 0);
    ((Control) this.docViewer).Name = "docViewer";
    this.docViewer.ReportViewer.CurrentPage = 0;
    this.docViewer.ReportViewer.MultiplePageCols = 3;
    this.docViewer.ReportViewer.MultiplePageRows = 2;
    ((Control) this.docViewer).Size = new Size(792, 573);
    ((Control) this.docViewer).TabIndex = 0;
    this.docViewer.TableOfContents.Text = "Contents";
    ((SidebarPanel) this.docViewer.TableOfContents).Width = 200;
    this.docViewer.Toolbar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(792, 573);
    this.Controls.Add((Control) this.docViewer);
    this.Name = nameof (frmCheckPrinting);
    this.Text = nameof (frmCheckPrinting);
    this.ResumeLayout(false);
  }

  public void LoadReport(SectionReport rptReport)
  {
    rptReport.Run();
    this.docViewer.Document = rptReport.Document;
    CheckDetail checkDetail = new CheckDetail(Conversions.ToInteger(rptReport.Fields["transactNum"].Value));
    checkDetail.Run();
    PrintExtension.Print(checkDetail.Document, false, false);
  }

  [field: AccessedThroughProperty("docViewer")]
  internal virtual GrapeCity.ActiveReports.Viewer.Win.Viewer docViewer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}

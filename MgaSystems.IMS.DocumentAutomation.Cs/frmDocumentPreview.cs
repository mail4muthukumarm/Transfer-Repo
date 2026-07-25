// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.DocumentPreview.frmDocumentPreview
// Assembly: MgaSystems.IMS.DocumentAutomation.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 40237120-7607-4A2A-83F2-11594214BFC1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.DocumentAutomation.Cs.dll

using MgaSystems.IMS.DocumentAutomation.DocumentPreview;
using MGASystems.Tools.BaseClasses;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.DocumentPreview;

public class frmDocumentPreview : MGABaseForm
{
  private IContainer components;
  private Panel panel;
  private PreviewHandlerHost previewHandlerHost;

  public string FileName { get; set; }

  public frmDocumentPreview(string fileName)
  {
    this.InitializeComponent();
    this.FileName = fileName;
    this.previewHandlerHost.Open(this.FileName);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.panel = new Panel();
    this.previewHandlerHost = new PreviewHandlerHost();
    this.SuspendLayout();
    this.panel.Controls.Add((Control) this.previewHandlerHost);
    this.panel.Dock = DockStyle.Fill;
    this.panel.Location = new Point(0, 0);
    this.panel.Name = "panel";
    this.panel.Padding = new Padding(12);
    this.panel.Size = new Size(800, 450);
    this.panel.TabIndex = 4;
    this.previewHandlerHost.Dock = DockStyle.Fill;
    this.previewHandlerHost.Location = new Point(12, 12);
    this.previewHandlerHost.Name = "previewHandlerHost";
    this.previewHandlerHost.Size = new Size(600, 370);
    this.previewHandlerHost.TabIndex = 1;
    this.previewHandlerHost.Text = "previewHandlerHost1";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(800, 450);
    this.Controls.Add((Control) this.panel);
    this.Name = nameof (frmDocumentPreview);
    this.Text = "Document Preview";
    this.ResumeLayout(false);
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmDocumentExplorer
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public sealed class frmDocumentExplorer : Form
{
  private IContainer components;
  private ListView lvDocs;
  private ImageList Images;

  public frmDocumentExplorer() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ResourceManager resourceManager = new ResourceManager(typeof (frmDocumentExplorer));
    this.lvDocs = new ListView();
    this.Images = new ImageList(this.components);
    this.SuspendLayout();
    this.lvDocs.BackColor = Color.White;
    this.lvDocs.Dock = DockStyle.Fill;
    this.lvDocs.ForeColor = Color.Black;
    this.lvDocs.LargeImageList = this.Images;
    this.lvDocs.Location = new Point(0, 0);
    this.lvDocs.Name = "lvDocs";
    this.lvDocs.Size = new Size(632, 390);
    this.lvDocs.TabIndex = 0;
    this.Images.ColorDepth = ColorDepth.Depth24Bit;
    this.Images.ImageSize = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.Images.ImageStream = (ImageListStreamer) resourceManager.GetObject("Images.ImageStream");
    this.Images.TransparentColor = Color.Transparent;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(632, 390);
    this.Controls.Add((Control) this.lvDocs);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmDocumentExplorer);
    this.Text = "Document Explorer";
    this.ResumeLayout(false);
  }
}

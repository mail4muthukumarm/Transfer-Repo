// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentSystem.frmDownloadDocumentNonThreaded
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win.Misc.CommonControls;
using MGASystems.Common;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.DocumentSystem;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmDownloadDocumentNonThreaded : Form
{
  private IContainer components;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("AnimationControl1")]
  internal virtual AnimationControl AnimationControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lnkCancel")]
  internal virtual LinkLabel lnkCancel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.AnimationControl1 = new AnimationControl();
    this.Label1 = new Label();
    this.lnkCancel = new LinkLabel();
    this.SuspendLayout();
    this.AnimationControl1.AnimationSource = (AnimationType) 160 /*0xA0*/;
    this.AnimationControl1.BorderStyle = BorderStyle.None;
    ((Control) this.AnimationControl1).Location = new Point(141, 55);
    ((Control) this.AnimationControl1).Name = "AnimationControl1";
    ((Control) this.AnimationControl1).Size = new Size(272, 60);
    ((Control) this.AnimationControl1).TabIndex = 0;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 12f);
    this.Label1.Location = new Point(89, 20);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(369, 19);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Please wait while the system downloads your file...";
    this.lnkCancel.Location = new Point(227, 150);
    this.lnkCancel.Name = "lnkCancel";
    this.lnkCancel.Size = new Size(100, 23);
    this.lnkCancel.TabIndex = 3;
    this.lnkCancel.TabStop = true;
    this.lnkCancel.Text = "Cancel Download";
    this.lnkCancel.TextAlign = ContentAlignment.MiddleCenter;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(554, 176 /*0xB0*/);
    this.Controls.Add((Control) this.lnkCancel);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.AnimationControl1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmDownloadDocumentNonThreaded);
    this.Text = "Downloading \"{0}\"..";
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void frmDownloadDocument_Load(object sender, EventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    this.AnimationControl1.Play();
    this.Cursor = MgaCursors.Working;
  }

  public frmDownloadDocumentNonThreaded(string fileName)
  {
    this.Load += new EventHandler(this.frmDownloadDocument_Load);
    this.InitializeComponent();
    this.Text = string.Format(this.Text, (object) fileName);
  }
}

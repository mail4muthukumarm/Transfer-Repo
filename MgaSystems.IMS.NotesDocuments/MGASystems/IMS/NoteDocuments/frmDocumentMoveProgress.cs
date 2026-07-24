// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmDocumentMoveProgress
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinProgressBar;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public sealed class frmDocumentMoveProgress : Form
{
  private IContainer components;
  private Label Label1;
  private UltraProgressBar UltraProgressBar1;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.Label1 = new Label();
    this.UltraProgressBar1 = new UltraProgressBar();
    this.SuspendLayout();
    this.Label1.Location = new Point(11, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(493, 88);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Downloading Files X, Y, and Z";
    appearance.BackColor = Color.White;
    this.UltraProgressBar1.Appearance = (AppearanceBase) appearance;
    ((Control) this.UltraProgressBar1).Location = new Point(11, 100);
    ((Control) this.UltraProgressBar1).Name = "UltraProgressBar1";
    ((Control) this.UltraProgressBar1).Size = new Size(493, 22);
    ((Control) this.UltraProgressBar1).TabIndex = 1;
    this.UltraProgressBar1.Text = "[Formatted]";
    ((UltraControlBase) this.UltraProgressBar1).UseFlatMode = (DefaultableBoolean) 1;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(516, 134);
    this.ControlBox = false;
    this.Controls.Add((Control) this.UltraProgressBar1);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.Name = nameof (frmDocumentMoveProgress);
    this.Text = "Document Management";
    this.ResumeLayout(false);
  }

  public frmDocumentMoveProgress(string title)
  {
    this.InitializeComponent();
    this.Text = title;
  }

  public void SetProgress(string action, int value, int max)
  {
    this.UltraProgressBar1.Minimum = 0;
    this.UltraProgressBar1.Maximum = max;
    if (value <= max)
      this.UltraProgressBar1.Value = value;
    this.Label1.Text = action;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentSystem.frmUploadDocument
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc.CommonControls;
using Infragistics.Win.UltraWinProgressBar;
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
public class frmUploadDocument : Form
{
  private IContainer components;
  private AnimationControl AnimationControl1;
  private Label Label1;
  private UltraProgressBar progress;
  private bool _cancelRequested;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual LinkLabel lnkCancel
  {
    get => this._lnkCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCancel_LinkClicked);
      LinkLabel lnkCancel1 = this._lnkCancel;
      if (lnkCancel1 != null)
        lnkCancel1.LinkClicked -= clickedEventHandler;
      this._lnkCancel = value;
      LinkLabel lnkCancel2 = this._lnkCancel;
      if (lnkCancel2 == null)
        return;
      lnkCancel2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblDescription")]
  internal virtual Label lblDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.AnimationControl1 = new AnimationControl();
    this.Label1 = new Label();
    this.progress = new UltraProgressBar();
    this.lnkCancel = new LinkLabel();
    this.lblDescription = new Label();
    this.SuspendLayout();
    this.AnimationControl1.AnimationSource = (AnimationType) 160 /*0xA0*/;
    this.AnimationControl1.BorderStyle = BorderStyle.None;
    ((Control) this.AnimationControl1).Location = new Point(141, 75);
    ((Control) this.AnimationControl1).Name = "AnimationControl1";
    ((Control) this.AnimationControl1).Size = new Size(272, 60);
    ((Control) this.AnimationControl1).TabIndex = 0;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 12f);
    this.Label1.Location = new Point(100, 20);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(355, 23);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Please wait while the system uploads your file...";
    this.Label1.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.progress).Location = new Point(15, 150);
    ((Control) this.progress).Name = "progress";
    ((Control) this.progress).Size = new Size(525, 15);
    ((Control) this.progress).TabIndex = 2;
    this.progress.Text = "[Formatted]";
    this.lnkCancel.Location = new Point(227, 170);
    this.lnkCancel.Name = "lnkCancel";
    this.lnkCancel.TabIndex = 3;
    this.lnkCancel.TabStop = true;
    this.lnkCancel.Text = "Cancel Upload";
    this.lnkCancel.TextAlign = ContentAlignment.MiddleCenter;
    this.lblDescription.Location = new Point(10, 50);
    this.lblDescription.Name = "lblDescription";
    this.lblDescription.Size = new Size(530, 23);
    this.lblDescription.TabIndex = 4;
    this.lblDescription.Text = "(a description of the file will appear here...)";
    this.lblDescription.TextAlign = ContentAlignment.MiddleCenter;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(554, 201);
    this.Controls.Add((Control) this.lblDescription);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lnkCancel);
    this.Controls.Add((Control) this.progress);
    this.Controls.Add((Control) this.AnimationControl1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmUploadDocument);
    this.Text = "Uploading Document...";
    this.ResumeLayout(false);
  }

  internal bool CancelRequested => this._cancelRequested;

  public frmUploadDocument(string description)
  {
    this.Load += new EventHandler(this.frmUploadDocument_Load);
    this.InitializeComponent();
    this.lblDescription.Text = description;
  }

  private void frmUploadDocument_Load(object sender, EventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    this.AnimationControl1.Play();
  }

  public void SetProgressBarMax(int max) => this.progress.Maximum = max;

  public void SetProgressBarValue(int value)
  {
    this.progress.Value = Math.Min(Math.Max(this.progress.Minimum, value), this.progress.Maximum);
    ((UltraControlBase) this.progress).Refresh();
    Application.DoEvents();
  }

  private void lnkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this._cancelRequested = true;
  }
}

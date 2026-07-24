// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmCheckOptions
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

public sealed class frmCheckOptions : Form
{
  private IContainer components;

  public frmCheckOptions() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("ImageList1")]
  internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox2")]
  internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox3")]
  internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox4")]
  internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ResourceManager resourceManager = new ResourceManager(typeof (frmCheckOptions));
    this.ImageList1 = new ImageList(this.components);
    this.PictureBox1 = new PictureBox();
    this.PictureBox2 = new PictureBox();
    this.PictureBox3 = new PictureBox();
    this.PictureBox4 = new PictureBox();
    this.Panel1 = new Panel();
    this.Panel1.SuspendLayout();
    this.SuspendLayout();
    this.ImageList1.ImageSize = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.ImageList1.TransparentColor = Color.Transparent;
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(0, 168);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(120, 80 /*0x50*/);
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    this.PictureBox2.Image = (Image) resourceManager.GetObject("PictureBox2.Image");
    this.PictureBox2.Location = new Point(0, 72);
    this.PictureBox2.Name = "PictureBox2";
    this.PictureBox2.Size = new Size(76, 95);
    this.PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox2.TabIndex = 1;
    this.PictureBox2.TabStop = false;
    this.PictureBox3.Image = (Image) resourceManager.GetObject("PictureBox3.Image");
    this.PictureBox3.Location = new Point(64 /*0x40*/, 0);
    this.PictureBox3.Name = "PictureBox3";
    this.PictureBox3.Size = new Size(100, 64 /*0x40*/);
    this.PictureBox3.TabIndex = 2;
    this.PictureBox3.TabStop = false;
    this.PictureBox4.Image = (Image) resourceManager.GetObject("PictureBox4.Image");
    this.PictureBox4.Location = new Point(120, 152);
    this.PictureBox4.Name = "PictureBox4";
    this.PictureBox4.Size = new Size(88, 96 /*0x60*/);
    this.PictureBox4.TabIndex = 3;
    this.PictureBox4.TabStop = false;
    this.Panel1.BackColor = Color.White;
    this.Panel1.Controls.Add((Control) this.PictureBox4);
    this.Panel1.Controls.Add((Control) this.PictureBox1);
    this.Panel1.Controls.Add((Control) this.PictureBox2);
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(224 /*0xE0*/, 248);
    this.Panel1.TabIndex = 4;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(640, 266);
    this.Controls.Add((Control) this.PictureBox3);
    this.Controls.Add((Control) this.Panel1);
    this.Name = nameof (frmCheckOptions);
    this.Text = nameof (frmCheckOptions);
    this.Panel1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormUnbindPleaseWait
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
internal class FormUnbindPleaseWait : Form
{
  private IContainer components;
  private PictureBox PictureBox1;

  public FormUnbindPleaseWait() => this.InitializeComponent();

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
    Appearance appearance = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormUnbindPleaseWait));
    this.PictureBox1 = new PictureBox();
    UltraGroupBox ultraGroupBox = new UltraGroupBox();
    Label label = new Label();
    ((ISupportInitialize) ultraGroupBox).BeginInit();
    ((Control) ultraGroupBox).SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.SuspendLayout();
    appearance.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGroupBox.ContentAreaAppearance = (AppearanceBase) appearance;
    ((Control) ultraGroupBox).Controls.Add((Control) this.PictureBox1);
    ((Control) ultraGroupBox).Controls.Add((Control) label);
    ultraGroupBox.Dock = DockStyle.Fill;
    ((Control) ultraGroupBox).Location = new Point(0, 0);
    ((Control) ultraGroupBox).Name = "UltraGroupBox1";
    ((Control) ultraGroupBox).Size = new Size(470, 117);
    ((Control) ultraGroupBox).TabIndex = 1;
    label.AutoSize = true;
    label.Font = new Font("Tahoma", 12f);
    label.Location = new Point(63 /*0x3F*/, 63 /*0x3F*/);
    label.Name = "Label1";
    label.Size = new Size(345, 19);
    label.TabIndex = 1;
    label.Text = "Please wait while this transaction is unbound ...";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(219, 13);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 2;
    this.PictureBox1.TabStop = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(470, 117);
    this.Controls.Add((Control) ultraGroupBox);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (FormUnbindPleaseWait);
    this.Text = nameof (FormUnbindPleaseWait);
    ((ISupportInitialize) ultraGroupBox).EndInit();
    ((Control) ultraGroupBox).ResumeLayout(false);
    ((Control) ultraGroupBox).PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.ResumeLayout(false);
  }
}

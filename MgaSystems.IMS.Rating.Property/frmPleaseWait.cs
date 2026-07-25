// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Rating.Property.frmPleaseWait
// Assembly: MgaSystems.IMS.Rating.Property, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B6A893CA-828D-4C72-A3E1-997D4DDF80FA
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.Property.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.IMS.Rating.Property;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmPleaseWait : Form
{
  private IContainer components;
  private UltraGroupBox UltraGroupBox1;
  private Label Label1;
  private PictureBox PictureBox1;

  public frmPleaseWait() => this.InitializeComponent();

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
    ResourceManager resourceManager = new ResourceManager(typeof (frmPleaseWait));
    this.UltraGroupBox1 = new UltraGroupBox();
    this.PictureBox1 = new PictureBox();
    this.Label1 = new Label();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    this.SuspendLayout();
    appearance.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.PictureBox1);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.Label1);
    this.UltraGroupBox1.Dock = DockStyle.Fill;
    ((Control) this.UltraGroupBox1).Location = new Point(0, 0);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(576, 104);
    this.UltraGroupBox1.UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraGroupBox1).TabIndex = 0;
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(48 /*0x30*/, 36);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 1;
    this.PictureBox1.TabStop = false;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 12f);
    this.Label1.Location = new Point(104, 44);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(429, 23);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Please wait while the  premiums and fees are calculated...";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(576, 104);
    this.Controls.Add((Control) this.UltraGroupBox1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (frmPleaseWait);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmPleaseWait);
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    this.ResumeLayout(false);
  }
}

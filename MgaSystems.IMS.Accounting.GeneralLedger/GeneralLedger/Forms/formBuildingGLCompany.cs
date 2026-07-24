// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.formBuildingGLCompany
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using MGASystems.Tools;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

public class formBuildingGLCompany : Form
{
  private Label label2;
  private PictureBox pictureBox1;
  private Label label1;
  private BouncingProgress bouncingProgress1;
  private System.ComponentModel.Container components;

  public formBuildingGLCompany() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (formBuildingGLCompany));
    this.label2 = new Label();
    this.pictureBox1 = new PictureBox();
    this.label1 = new Label();
    this.bouncingProgress1 = new BouncingProgress();
    this.SuspendLayout();
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 10f, FontStyle.Bold);
    this.label2.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label2.Location = new Point(96 /*0x60*/, 0);
    this.label2.Name = "label2";
    this.label2.Size = new Size(80 /*0x50*/, 20);
    this.label2.TabIndex = 5;
    this.label2.Text = "Processing";
    this.pictureBox1.Image = (Image) resourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(0, 0);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(84, 65);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox1.TabIndex = 4;
    this.pictureBox1.TabStop = false;
    this.label1.ForeColor = Color.DimGray;
    this.label1.Location = new Point(96 /*0x60*/, 24);
    this.label1.Name = "label1";
    this.label1.Size = new Size(200, 32 /*0x20*/);
    this.label1.TabIndex = 3;
    this.label1.Text = "Building GL company accounts, this may take a minute or two.";
    this.label1.TextAlign = ContentAlignment.MiddleLeft;
    this.bouncingProgress1.Border = BorderStyle.FixedSingle;
    this.bouncingProgress1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.bouncingProgress1.Bounce = true;
    this.bouncingProgress1.BounceColor = Color.FromArgb(239, 247, 253);
    this.bouncingProgress1.Location = new Point(96 /*0x60*/, 62);
    this.bouncingProgress1.Name = "bouncingProgress1";
    this.bouncingProgress1.Size = new Size(192 /*0xC0*/, 8);
    this.bouncingProgress1.TabIndex = 6;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(292, 72);
    this.ControlBox = false;
    this.Controls.Add((Control) this.bouncingProgress1);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.pictureBox1);
    this.Controls.Add((Control) this.label1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (formBuildingGLCompany);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Building GL Chart of Accounts";
    this.ResumeLayout(false);
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formAccessDenied
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class formAccessDenied : Form
{
  private MGAButton buttonOk;
  private PictureBox pictureBox1;
  private Label label1;
  private Label label2;
  private System.ComponentModel.Container components;

  public formAccessDenied() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (formAccessDenied));
    this.buttonOk = new MGAButton();
    this.pictureBox1 = new PictureBox();
    this.label1 = new Label();
    this.label2 = new Label();
    ((ISupportInitialize) this.buttonOk).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonOk).Appearance = (AppearanceBase) appearance;
    ((Control) this.buttonOk).Location = new Point(88, 168);
    ((Control) this.buttonOk).Name = "buttonOk";
    ((Control) this.buttonOk).Size = new Size(112 /*0x70*/, 24);
    ((Control) this.buttonOk).TabIndex = 0;
    ((Control) this.buttonOk).Text = "OK";
    ((Control) this.buttonOk).Click += new EventHandler(this.buttonOk_Click);
    this.pictureBox1.Image = (Image) resourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(8, 8);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(280, 72);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox1.TabIndex = 1;
    this.pictureBox1.TabStop = false;
    this.label1.Font = new Font("Tahoma", 12f, FontStyle.Bold);
    this.label1.Location = new Point(8, 72);
    this.label1.Name = "label1";
    this.label1.Size = new Size(280, 23);
    this.label1.TabIndex = 3;
    this.label1.Text = "Access Denied!";
    this.label1.TextAlign = ContentAlignment.TopCenter;
    this.label2.Location = new Point(8, 96 /*0x60*/);
    this.label2.Name = "label2";
    this.label2.Size = new Size(280, 64 /*0x40*/);
    this.label2.TabIndex = 4;
    this.label2.Text = "You do not have rights to access the specified resource. If you feel you should have access to this resource, please consult your system administrator for further assistance.";
    this.label2.TextAlign = ContentAlignment.TopCenter;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(290, 208 /*0xD0*/);
    this.ControlBox = false;
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.buttonOk);
    this.Controls.Add((Control) this.pictureBox1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formAccessDenied);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Access Denied!";
    ((ISupportInitialize) this.buttonOk).EndInit();
    this.ResumeLayout(false);
  }

  private void buttonOk_Click(object sender, EventArgs e) => this.Close();
}

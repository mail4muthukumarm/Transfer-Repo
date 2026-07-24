// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.formReloadingGLAccounts
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using MGASystems.Common;
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

public class formReloadingGLAccounts : Form
{
  private Label label1;
  private PictureBox pictureBox1;
  private Label label2;
  private System.ComponentModel.Container components;

  public formReloadingGLAccounts() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (formReloadingGLAccounts));
    this.label1 = new Label();
    this.pictureBox1 = new PictureBox();
    this.label2 = new Label();
    this.SuspendLayout();
    this.label1.ForeColor = Color.DimGray;
    this.label1.Location = new Point(104, 40);
    this.label1.Name = "label1";
    this.label1.Size = new Size(200, 32 /*0x20*/);
    this.label1.TabIndex = 0;
    this.label1.Text = "Re-loading child accounts, this may take a minute or two.";
    this.label1.TextAlign = ContentAlignment.MiddleLeft;
    this.pictureBox1.Image = (Image) resourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(8, 8);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(84, 65);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox1.TabIndex = 1;
    this.pictureBox1.TabStop = false;
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 10f, FontStyle.Bold);
    this.label2.ForeColor = Color.Black;
    this.label2.Location = new Point(104, 8);
    this.label2.Name = "label2";
    this.label2.Size = new Size(80 /*0x50*/, 20);
    this.label2.TabIndex = 2;
    this.label2.Text = "Processing";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(314, 80 /*0x50*/);
    this.ControlBox = false;
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.pictureBox1);
    this.Controls.Add((Control) this.label1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (formReloadingGLAccounts);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = " Reloading child accounts....";
    this.Load += new EventHandler(this.formReloadingGLAccounts_Load);
    this.ResumeLayout(false);
  }

  private void formReloadingGLAccounts_Load(object sender, EventArgs e)
  {
    Application.DoEvents();
    foreach (Form mdiChild in MDIControls.Instance.MDIParent.MdiChildren)
    {
      if (mdiChild is formGLAccountManagement)
      {
        (mdiChild as formGLAccountManagement).RefreshChildNodes();
        break;
      }
    }
    this.Close();
  }
}

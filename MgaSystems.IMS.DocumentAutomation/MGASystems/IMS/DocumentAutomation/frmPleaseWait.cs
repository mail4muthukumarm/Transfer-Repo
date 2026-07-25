// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.frmPleaseWait
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinProgressBar;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public sealed class frmPleaseWait : Form
{
  private IContainer components;
  internal UltraProgressBar progress;
  internal UltraLabel lblStatus;
  private const int CS_DROPSHADOW = 131072 /*0x020000*/;

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
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPleaseWait));
    this.progress = new UltraProgressBar();
    this.lblStatus = new UltraLabel();
    Label label = new Label();
    Panel panel = new Panel();
    PictureBox pictureBox = new PictureBox();
    panel.SuspendLayout();
    ((ISupportInitialize) pictureBox).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.White;
    this.progress.Appearance = (AppearanceBase) appearance1;
    ((Control) this.progress).Location = new Point(8, 56);
    ((Control) this.progress).Name = "progress";
    ((Control) this.progress).Size = new Size(528, 16 /*0x10*/);
    ((Control) this.progress).TabIndex = 2;
    this.progress.Text = "[Formatted]";
    label.AutoSize = true;
    label.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label.Location = new Point(117, 19);
    label.Name = "Label1";
    label.Size = new Size(346, 19);
    label.TabIndex = 0;
    label.Text = "Please wait while your documents are created...";
    label.TextAlign = ContentAlignment.MiddleCenter;
    panel.BackColor = Color.White;
    panel.BorderStyle = BorderStyle.FixedSingle;
    panel.Controls.Add((Control) pictureBox);
    panel.Controls.Add((Control) this.lblStatus);
    panel.Controls.Add((Control) label);
    panel.Controls.Add((Control) this.progress);
    panel.Dock = DockStyle.Fill;
    panel.Location = new Point(0, 0);
    panel.Name = "Panel1";
    panel.Size = new Size(544, 104);
    panel.TabIndex = 3;
    appearance2.BorderColor = Color.Silver;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Center";
    ((ControlBase) this.lblStatus).Appearance = (AppearanceBase) appearance2;
    this.lblStatus.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblStatus).Location = new Point(8, 80 /*0x50*/);
    ((Control) this.lblStatus).Name = "lblStatus";
    ((Control) this.lblStatus).Size = new Size(528, 16 /*0x10*/);
    ((Control) this.lblStatus).TabIndex = 3;
    pictureBox.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    pictureBox.Location = new Point(79, 11);
    pictureBox.Name = "PictureBox1";
    pictureBox.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
    pictureBox.TabIndex = 4;
    pictureBox.TabStop = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(544, 104);
    this.Controls.Add((Control) panel);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (frmPleaseWait);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmPleaseWait);
    panel.ResumeLayout(false);
    panel.PerformLayout();
    ((ISupportInitialize) pictureBox).EndInit();
    this.ResumeLayout(false);
  }

  protected override CreateParams CreateParams
  {
    get
    {
      CreateParams createParams1;
      if (frmPleaseWait.UsingWindowsXP())
      {
        CreateParams createParams2 = base.CreateParams;
        createParams2.ClassStyle |= 131072 /*0x020000*/;
        createParams1 = createParams2;
      }
      else
        createParams1 = base.CreateParams;
      return createParams1;
    }
  }

  private static bool UsingWindowsXP()
  {
    return Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1 || Environment.OSVersion.Version.Minor > 5;
  }
}

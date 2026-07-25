// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Bulk_Renewal_Utility.frmPleaseWaitMessage
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Underwriting.Bulk_Renewal_Utility;

public class frmPleaseWaitMessage : Form
{
  private const int CS_DROPSHADOW = 131072 /*0x020000*/;
  private IContainer components;
  private PictureBox PictureBox1;
  private Label lblWaitMessage;
  private UltraGroupBox UltraGroupBox1;

  public frmPleaseWaitMessage() => this.InitializeComponent();

  public frmPleaseWaitMessage(string message)
    : this()
  {
    this.lblWaitMessage.Text = message;
  }

  protected override CreateParams CreateParams
  {
    get
    {
      CreateParams createParams = base.CreateParams;
      if (frmPleaseWaitMessage.UsingWindowsXP())
        createParams.ClassStyle |= 131072 /*0x020000*/;
      return createParams;
    }
  }

  private static bool UsingWindowsXP()
  {
    return Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1 || Environment.OSVersion.Version.Minor > 5;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPleaseWaitMessage));
    Appearance appearance = new Appearance();
    this.PictureBox1 = new PictureBox();
    this.lblWaitMessage = new Label();
    this.UltraGroupBox1 = new UltraGroupBox();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    this.SuspendLayout();
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(24, 36);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 1;
    this.PictureBox1.TabStop = false;
    this.lblWaitMessage.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblWaitMessage.Location = new Point(64 /*0x40*/, 21);
    this.lblWaitMessage.Name = "lblWaitMessage";
    this.lblWaitMessage.Size = new Size(358, 63 /*0x3F*/);
    this.lblWaitMessage.TabIndex = 0;
    this.lblWaitMessage.Text = "Please wait while your documents are created...";
    this.lblWaitMessage.TextAlign = ContentAlignment.MiddleCenter;
    this.UltraGroupBox1.BackColorInternal = Color.White;
    ((AppearanceBase) appearance).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.PictureBox1);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.lblWaitMessage);
    ((Control) this.UltraGroupBox1).Dock = DockStyle.Fill;
    ((Control) this.UltraGroupBox1).Location = new Point(0, 0);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(448, 104);
    ((Control) this.UltraGroupBox1).TabIndex = 3;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(448, 104);
    this.Controls.Add((Control) this.UltraGroupBox1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (frmPleaseWaitMessage);
    this.Text = nameof (frmPleaseWaitMessage);
    this.TransparencyKey = Color.WhiteSmoke;
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    ((Control) this.UltraGroupBox1).PerformLayout();
    this.ResumeLayout(false);
  }
}

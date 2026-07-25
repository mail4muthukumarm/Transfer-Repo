// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.frmPleaseWaitNoProgress
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public sealed class frmPleaseWaitNoProgress : Form
{
  private IContainer components;
  private Label Label1;
  private const int CS_DROPSHADOW = 131072 /*0x020000*/;

  public frmPleaseWaitNoProgress() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox1")]
  internal virtual UltraGroupBox UltraGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (frmPleaseWaitNoProgress));
    Appearance appearance = new Appearance();
    this.Label1 = new Label();
    this.PictureBox1 = new PictureBox();
    this.UltraGroupBox1 = new UltraGroupBox();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(64 /*0x40*/, 41);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(355, 23);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Please wait while your documents are created...";
    this.Label1.TextAlign = ContentAlignment.MiddleCenter;
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(24, 36);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 1;
    this.PictureBox1.TabStop = false;
    this.UltraGroupBox1.BackColor = Color.White;
    appearance.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.PictureBox1);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.Label1);
    this.UltraGroupBox1.Dock = DockStyle.Fill;
    ((Control) this.UltraGroupBox1).Location = new Point(0, 0);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(448, 104);
    this.UltraGroupBox1.SupportThemes = false;
    ((Control) this.UltraGroupBox1).TabIndex = 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(448, 104);
    this.Controls.Add((Control) this.UltraGroupBox1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (frmPleaseWaitNoProgress);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmPleaseWaitNoProgress);
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  protected override CreateParams CreateParams
  {
    get
    {
      CreateParams createParams1;
      if (frmPleaseWaitNoProgress.UsingWindowsXP())
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

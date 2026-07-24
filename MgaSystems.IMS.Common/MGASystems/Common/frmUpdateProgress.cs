// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.frmUpdateProgress
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinProgressBar;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

public sealed class frmUpdateProgress : Form
{
  private IContainer components;
  private Label Label1;
  private UltraProgressBar UltraProgressBar1;
  private UltraGroupBox UltraGroupBox1;
  private frmUpdateProgress.ProgressModes _progressMode;

  public frmUpdateProgress()
  {
    this.Load += new EventHandler(this.frmUpdateProgress_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("BouncingProgress1")]
  internal virtual BouncingProgress BouncingProgress1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    this.Label1 = new Label();
    this.UltraProgressBar1 = new UltraProgressBar();
    this.UltraGroupBox1 = new UltraGroupBox();
    this.BouncingProgress1 = new BouncingProgress();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Font = new Font("Tahoma", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(107, 16 /*0x10*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(202, 26);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Saving... Please Wait...";
    appearance1.BackColor = Color.White;
    this.UltraProgressBar1.Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.MidnightBlue;
    this.UltraProgressBar1.FillAppearance = (AppearanceBase) appearance2;
    ((Control) this.UltraProgressBar1).Location = new Point(16 /*0x10*/, 54);
    ((Control) this.UltraProgressBar1).Name = "UltraProgressBar1";
    ((Control) this.UltraProgressBar1).Size = new Size(384, 16 /*0x10*/);
    ((Control) this.UltraProgressBar1).TabIndex = 1;
    this.UltraProgressBar1.Text = "[Formatted]";
    this.UltraProgressBar1.TextVisible = false;
    this.UltraProgressBar1.Value = 50;
    appearance3.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance3;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.BouncingProgress1);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.Label1);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.UltraProgressBar1);
    this.UltraGroupBox1.Dock = DockStyle.Fill;
    ((Control) this.UltraGroupBox1).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.UltraGroupBox1).Location = new Point(0, 0);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(416, 88);
    this.UltraGroupBox1.SupportThemes = false;
    ((Control) this.UltraGroupBox1).TabIndex = 2;
    this.BouncingProgress1.Border = BorderStyle.FixedSingle;
    this.BouncingProgress1.BorderColor = Color.DarkGray;
    this.BouncingProgress1.Bounce = true;
    this.BouncingProgress1.BounceColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.BouncingProgress1.Location = new Point(56, 32 /*0x20*/);
    this.BouncingProgress1.Name = "BouncingProgress1";
    this.BouncingProgress1.Size = new Size(384, 8);
    this.BouncingProgress1.TabIndex = 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(416, 88);
    this.Controls.Add((Control) this.UltraGroupBox1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (frmUpdateProgress);
    this.Text = nameof (frmUpdateProgress);
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public frmUpdateProgress.ProgressModes ProgressMode
  {
    get => this._progressMode;
    set
    {
      this._progressMode = value;
      if (value == frmUpdateProgress.ProgressModes.BouncingProgress)
      {
        this.BouncingProgress1.Left = ((Control) this.UltraProgressBar1).Left;
        this.BouncingProgress1.Top = ((Control) this.UltraProgressBar1).Top;
        this.BouncingProgress1.Visible = true;
        this.BouncingProgress1.Bounce = true;
        ((Control) this.UltraProgressBar1).Visible = false;
      }
      else
      {
        this.BouncingProgress1.Visible = false;
        ((Control) this.UltraProgressBar1).Visible = true;
      }
    }
  }

  public UltraProgressBar ProgressBar => this.UltraProgressBar1;

  private void frmUpdateProgress_Load(object sender, EventArgs e)
  {
    this.Height = 88;
    this.Width = 416;
  }

  public enum ProgressModes
  {
    BouncingProgress,
    ProgressBar,
  }
}

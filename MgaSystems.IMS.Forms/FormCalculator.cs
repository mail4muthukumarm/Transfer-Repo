// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormCalculator
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win.UltraWinEditors.UltraWinCalc;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

public sealed class FormCalculator : Form
{
  private IContainer components;
  private Panel FormCalculator_Fill_Panel;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Calc")]
  private virtual UltraCalculator Calc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.Calc = new UltraCalculator();
    this.FormCalculator_Fill_Panel = new Panel();
    this.FormCalculator_Fill_Panel.SuspendLayout();
    this.SuspendLayout();
    ((Control) this.Calc).Dock = DockStyle.Fill;
    ((Control) this.Calc).Location = new Point(0, 0);
    ((Control) this.Calc).Name = "Calc";
    ((Control) this.Calc).Size = new Size(294, 268);
    ((Control) this.Calc).TabIndex = 0;
    this.Calc.Text = "0.";
    this.FormCalculator_Fill_Panel.Controls.Add((Control) this.Calc);
    this.FormCalculator_Fill_Panel.Cursor = Cursors.Default;
    this.FormCalculator_Fill_Panel.Dock = DockStyle.Fill;
    this.FormCalculator_Fill_Panel.Location = new Point(0, 0);
    this.FormCalculator_Fill_Panel.Name = "FormCalculator_Fill_Panel";
    this.FormCalculator_Fill_Panel.Size = new Size(294, 268);
    this.FormCalculator_Fill_Panel.TabIndex = 0;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(294, 268);
    this.Controls.Add((Control) this.FormCalculator_Fill_Panel);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.Name = nameof (FormCalculator);
    this.Text = "Calculator";
    this.FormCalculator_Fill_Panel.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public FormCalculator() => this.InitializeComponent();

  public FormCalculator(Decimal defaultValue)
  {
    this.InitializeComponent();
    this.Calc.Text = defaultValue.ToString();
  }
}

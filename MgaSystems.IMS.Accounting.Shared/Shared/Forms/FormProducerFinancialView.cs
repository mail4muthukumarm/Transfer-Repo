// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Shared.Forms.FormProducerFinancialView
// Assembly: MgaSystems.IMS.Accounting.Shared, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2F2619CC-F01B-4DB6-A722-33DC5B19310E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Shared.dll

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Shared.Forms;

public class FormProducerFinancialView : Form
{
  private IContainer components;

  public FormProducerFinancialView() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.SuspendLayout();
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(856, 619);
    this.Name = nameof (FormProducerFinancialView);
    this.Text = "Financial View";
    this.ResumeLayout(false);
  }
}

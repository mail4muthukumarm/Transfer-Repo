// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.formPaymentMethod
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

public class formPaymentMethod : Form
{
  private Label label1;
  private System.ComponentModel.Container components;

  public formPaymentMethod() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.label1 = new Label();
    this.SuspendLayout();
    this.label1.Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.label1.Name = "label1";
    this.label1.TabIndex = 0;
    this.label1.Text = "label1";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(712, 486);
    this.Controls.Add((Control) this.label1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (formPaymentMethod);
    this.Text = nameof (formPaymentMethod);
    this.ResumeLayout(false);
  }
}

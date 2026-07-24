// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formPurchaseOrderPaymentOptions
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using MGASystems.IMS.Accounting.Services;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

public class formPurchaseOrderPaymentOptions : AccountingNoteDocumentSupport
{
  private Label label1;
  private CheckBox chkPrePaid;
  private RadioButton radioPayLater;
  private RadioButton radioPayNow;
  private Label label2;
  private System.ComponentModel.Container components;

  public formPurchaseOrderPaymentOptions() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.label1 = new Label();
    this.chkPrePaid = new CheckBox();
    this.radioPayLater = new RadioButton();
    this.radioPayNow = new RadioButton();
    this.label2 = new Label();
    this.SuspendLayout();
    this.label1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label1.ForeColor = Color.Black;
    this.label1.Location = new Point(8, 0);
    this.label1.Name = "label1";
    this.label1.Size = new Size(240 /*0xF0*/, 32 /*0x20*/);
    this.label1.TabIndex = 1;
    this.label1.Text = "Please specify the purchase order expense payment type.";
    this.label1.TextAlign = ContentAlignment.TopCenter;
    this.chkPrePaid.CheckAlign = ContentAlignment.TopLeft;
    this.chkPrePaid.FlatStyle = FlatStyle.Flat;
    this.chkPrePaid.ForeColor = Color.Black;
    this.chkPrePaid.Location = new Point(120, 40);
    this.chkPrePaid.Name = "chkPrePaid";
    this.chkPrePaid.Size = new Size(109, 16 /*0x10*/);
    this.chkPrePaid.TabIndex = 2;
    this.chkPrePaid.Text = "Pre-Paid Expense";
    this.radioPayLater.FlatStyle = FlatStyle.Flat;
    this.radioPayLater.ForeColor = Color.Black;
    this.radioPayLater.Location = new Point(32 /*0x20*/, 64 /*0x40*/);
    this.radioPayLater.Name = "radioPayLater";
    this.radioPayLater.Size = new Size(88, 16 /*0x10*/);
    this.radioPayLater.TabIndex = 3;
    this.radioPayLater.Text = "Pay Later";
    this.radioPayNow.Checked = true;
    this.radioPayNow.FlatStyle = FlatStyle.Flat;
    this.radioPayNow.ForeColor = Color.Black;
    this.radioPayNow.Location = new Point(32 /*0x20*/, 40);
    this.radioPayNow.Name = "radioPayNow";
    this.radioPayNow.Size = new Size(72, 16 /*0x10*/);
    this.radioPayNow.TabIndex = 4;
    this.radioPayNow.TabStop = true;
    this.radioPayNow.Text = "Pay Now";
    this.label2.AutoSize = true;
    this.label2.ForeColor = Color.Black;
    this.label2.Location = new Point(109, 40);
    this.label2.Name = "label2";
    this.label2.Size = new Size(137, 17);
    this.label2.TabIndex = 7;
    this.label2.Text = "(                                  )";
    this.AutoScaleBaseSize = new Size(6, 14);
    this.BackColor = Color.GhostWhite;
    this.ClientSize = new Size(256 /*0x0100*/, 126);
    this.ControlBox = false;
    this.Controls.Add((Control) this.radioPayNow);
    this.Controls.Add((Control) this.radioPayLater);
    this.Controls.Add((Control) this.chkPrePaid);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.label2);
    this.Font = new Font("Tahoma", 8.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (formPurchaseOrderPaymentOptions);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Payment Options";
    this.ResumeLayout(false);
  }
}

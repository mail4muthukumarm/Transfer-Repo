// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.ExpenseCommissionsInvoiceSummaryEntry
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win.Misc;
using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.UserControls;

public class ExpenseCommissionsInvoiceSummaryEntry : UserControl
{
  private UltraLabel lblAmount;
  private UltraLabel lblPolicyNum;
  private UltraLabel lblDescription;
  private UltraLabel lblInvoiceNum;
  private System.ComponentModel.Container components;

  private ExpenseCommissionsInvoiceSummaryEntry() => this.InitializeComponent();

  public ExpenseCommissionsInvoiceSummaryEntry(
    string invoiceNum,
    string policyNum,
    string description,
    Decimal amount)
  {
    this.InitializeComponent();
    ((Control) this.lblAmount).Text = amount.ToString("c");
    ((Control) this.lblDescription).Text = description;
    ((Control) this.lblInvoiceNum).Text = "Invoice # " + invoiceNum;
    ((Control) this.lblPolicyNum).Text = "Policy # " + policyNum;
    this.Dock = DockStyle.Top;
  }

  public ExpenseCommissionsInvoiceSummaryEntry(
    string accountName,
    string itemDescription,
    Decimal amount)
  {
    this.InitializeComponent();
    ((Control) this.lblDescription).AutoSize = true;
    ((Control) this.lblDescription).Text = itemDescription;
    this.Controls.Remove((Control) this.lblPolicyNum);
    UltraLabel lblDescription = this.lblDescription;
    Point location = ((Control) this.lblInvoiceNum).Location;
    int x = location.X + 175;
    location = ((Control) this.lblInvoiceNum).Location;
    int y = location.Y;
    Point point = new Point(x, y);
    ((Control) lblDescription).Location = point;
    ((Control) this.lblInvoiceNum).Text = accountName;
    ((Control) this.lblAmount).Text = amount.ToString("c");
    this.Dock = DockStyle.Top;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.lblAmount = new UltraLabel();
    this.lblPolicyNum = new UltraLabel();
    this.lblDescription = new UltraLabel();
    this.lblInvoiceNum = new UltraLabel();
    this.SuspendLayout();
    ((Control) this.lblAmount).AutoSize = true;
    ((Control) this.lblAmount).Font = new Font("Tahoma", 8f);
    ((Control) this.lblAmount).Location = new Point(464, 0);
    ((Control) this.lblAmount).Name = "lblAmount";
    ((Control) this.lblAmount).RightToLeft = RightToLeft.Yes;
    ((Control) this.lblAmount).Size = new Size(32 /*0x20*/, 17);
    ((Control) this.lblAmount).TabIndex = 13;
    ((Control) this.lblAmount).Text = "$0.0";
    ((ControlBase) this.lblAmount).UseMnemonic = false;
    ((Control) this.lblPolicyNum).Font = new Font("Tahoma", 8f);
    ((Control) this.lblPolicyNum).Location = new Point(152, 0);
    ((Control) this.lblPolicyNum).Name = "lblPolicyNum";
    ((Control) this.lblPolicyNum).Size = new Size(144 /*0x90*/, 16 /*0x10*/);
    ((Control) this.lblPolicyNum).TabIndex = 14;
    ((Control) this.lblDescription).Font = new Font("Tahoma", 8f);
    ((Control) this.lblDescription).Location = new Point(304, 0);
    ((Control) this.lblDescription).Name = "lblDescription";
    ((Control) this.lblDescription).Size = new Size(152, 16 /*0x10*/);
    ((Control) this.lblDescription).TabIndex = 15;
    ((Control) this.lblInvoiceNum).Font = new Font("Tahoma", 8f);
    ((Control) this.lblInvoiceNum).Location = new Point(0, 0);
    ((Control) this.lblInvoiceNum).Name = "lblInvoiceNum";
    ((Control) this.lblInvoiceNum).Size = new Size(136, 16 /*0x10*/);
    ((Control) this.lblInvoiceNum).TabIndex = 16 /*0x10*/;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.lblInvoiceNum);
    this.Controls.Add((Control) this.lblDescription);
    this.Controls.Add((Control) this.lblPolicyNum);
    this.Controls.Add((Control) this.lblAmount);
    this.Name = nameof (ExpenseCommissionsInvoiceSummaryEntry);
    this.Size = new Size(560, 24);
    this.ResumeLayout(false);
  }
}

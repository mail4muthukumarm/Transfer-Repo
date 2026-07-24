// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.TestingGLAccountControl
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

[TestForm]
public class TestingGLAccountControl : AccountingNoteDocumentSupport
{
  private MultipleExtendedTreeViewDropDown multi;
  private CashFlow_DashBoard cashFlow_DashBoard1;
  private Button btnFirst;
  private Button button1;
  private System.ComponentModel.Container components;

  public TestingGLAccountControl() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.multi = new MultipleExtendedTreeViewDropDown();
    this.cashFlow_DashBoard1 = new CashFlow_DashBoard();
    this.button1 = new Button();
    this.SuspendLayout();
    this.multi.DropDownHeight = 0;
    this.multi.DropDownWidth = 0;
    this.multi.Font = new Font("Tahoma", 8f);
    this.multi.Location = new Point(2, 12);
    this.multi.Name = "multi";
    this.multi.Size = new Size(263, 21);
    this.multi.TabIndex = 1;
    this.multi.UseCheckedStateSelectionOverride = false;
    this.cashFlow_DashBoard1.BackColor = Color.LightSteelBlue;
    this.cashFlow_DashBoard1.Location = new Point(2, 30);
    this.cashFlow_DashBoard1.Name = "cashFlow_DashBoard1";
    this.cashFlow_DashBoard1.Size = new Size(576, 290);
    this.cashFlow_DashBoard1.TabIndex = 2;
    this.button1.Location = new Point(403, 13);
    this.button1.Name = "button1";
    this.button1.Size = new Size(75, 23);
    this.button1.TabIndex = 3;
    this.button1.Text = "button1";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.ClientSize = new Size(586, 341);
    this.Controls.Add((Control) this.cashFlow_DashBoard1);
    this.Controls.Add((Control) this.multi);
    this.Name = nameof (TestingGLAccountControl);
    this.ResumeLayout(false);
  }

  private void button1_Click(object sender, EventArgs e)
  {
  }
}

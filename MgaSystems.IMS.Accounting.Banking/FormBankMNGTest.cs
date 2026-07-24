// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.FormBankMNGTest
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win.Misc;
using MGASystems.IMS.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

[DesignerGenerated]
[TestForm]
public class FormBankMNGTest : Form
{
  private IContainer components;

  public FormBankMNGTest()
  {
    this.Load += new EventHandler(this.FormBankMNGTest_Load);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.BankManagementAccount1 = new BankManagementAccount();
    this.UltraFlowLayoutManager1 = new UltraFlowLayoutManager(this.components);
    this.Panel1 = new Panel();
    ((ISupportInitialize) this.UltraFlowLayoutManager1).BeginInit();
    this.SuspendLayout();
    this.BankManagementAccount1.BackColor = Color.White;
    this.BankManagementAccount1.Font = new Font("Tahoma", 8.25f);
    this.BankManagementAccount1.Location = new Point(115, 218);
    this.BankManagementAccount1.Name = "BankManagementAccount1";
    this.BankManagementAccount1.Size = new Size(249, 119);
    this.BankManagementAccount1.TabIndex = 0;
    ((ControlLayoutManagerBase) this.UltraFlowLayoutManager1).ContainerControl = (Control) this.Panel1;
    this.Panel1.Dock = DockStyle.Top;
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(1014, 100);
    this.Panel1.TabIndex = 1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1014, 761);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.BankManagementAccount1);
    this.Name = nameof (FormBankMNGTest);
    this.Text = nameof (FormBankMNGTest);
    ((ISupportInitialize) this.UltraFlowLayoutManager1).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("BankManagementAccount1")]
  internal virtual BankManagementAccount BankManagementAccount1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraFlowLayoutManager1")]
  internal virtual UltraFlowLayoutManager UltraFlowLayoutManager1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void FormBankMNGTest_Load(object sender, EventArgs e)
  {
    int num = 1;
    do
    {
      this.Panel1.Controls.Add((Control) new BankManagementAccount());
      ++num;
    }
    while (num <= 5);
    this.UltraFlowLayoutManager1.Orientation = Orientation.Horizontal;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.TestForm
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

using MGASystems.IMS.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

[DesignerGenerated]
[TestForm]
public class TestForm : Form
{
  private IContainer components;

  public TestForm()
  {
    this.Leave += new EventHandler(this.TestForm_Leave);
    this.Load += new EventHandler(this.TestForm_Load);
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
    this.GlAccountDropTree1 = new GLAccountDropTree();
    this.SuspendLayout();
    this.GlAccountDropTree1.Location = new Point(12, 12);
    this.GlAccountDropTree1.Name = "GlAccountDropTree1";
    this.GlAccountDropTree1.ShowAssetAccounts = GLAccountDropTree.Assets.All;
    this.GlAccountDropTree1.ShowEquityAccounts = true;
    this.GlAccountDropTree1.ShowExpenseAccounts = true;
    this.GlAccountDropTree1.ShowIncomeAccounts = true;
    this.GlAccountDropTree1.ShowLiabilityAccounts = GLAccountDropTree.Liabilities.All;
    this.GlAccountDropTree1.ShowSystemDefinedAccounts = true;
    this.GlAccountDropTree1.Size = new Size(209, 20);
    this.GlAccountDropTree1.TabIndex = 0;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(292, 266);
    this.Controls.Add((Control) this.GlAccountDropTree1);
    this.Name = nameof (TestForm);
    this.Text = nameof (TestForm);
    this.ResumeLayout(false);
  }

  internal virtual GLAccountDropTree GlAccountDropTree1
  {
    get => this._GlAccountDropTree1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      GLAccountDropTree.GLAccountSelectedEventHandler selectedEventHandler = new GLAccountDropTree.GLAccountSelectedEventHandler(this.GlAccountDropTree1_GLAccountSelected);
      GLAccountDropTree accountDropTree1_1 = this._GlAccountDropTree1;
      if (accountDropTree1_1 != null)
        accountDropTree1_1.GLAccountSelected -= selectedEventHandler;
      this._GlAccountDropTree1 = value;
      GLAccountDropTree accountDropTree1_2 = this._GlAccountDropTree1;
      if (accountDropTree1_2 == null)
        return;
      accountDropTree1_2.GLAccountSelected += selectedEventHandler;
    }
  }

  private void TestForm_Leave(object sender, EventArgs e)
  {
  }

  private void TestForm_Load(object sender, EventArgs e)
  {
    this.GlAccountDropTree1.LoadGLAccounts(18);
  }

  private void GlAccountDropTree1_GLAccountSelected(object sender, GLAccountSelectedEventArgs e)
  {
    int num1 = (int) MessageBox.Show(e.ShortName);
    int num2 = (int) MessageBox.Show(e.GLAccountID.ToString());
    int num3 = (int) MessageBox.Show(e.FullName);
  }
}

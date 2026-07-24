// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.Master_GL_Accounts.FormSubledger
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.Master_GL_Accounts;

public class FormSubledger : Form
{
  private IContainer components;

  public FormSubledger() => this.InitializeComponent();

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
    this.ClientSize = new Size(890, 609);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormSubledger);
    this.Text = "Sub-Ledger Definition";
    this.ResumeLayout(false);
  }
}

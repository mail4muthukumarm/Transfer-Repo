// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formSearch
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

public class formSearch : AccountingNoteDocumentSupport
{
  private Label label1;
  private MGATextBox mgaTextBox1;
  private System.ComponentModel.Container components;

  public formSearch() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.label1 = new Label();
    this.mgaTextBox1 = new MGATextBox();
    ((ISupportInitialize) this.mgaTextBox1).BeginInit();
    this.SuspendLayout();
    this.label1.Location = new Point(8, 8);
    this.label1.Name = "label1";
    this.label1.Size = new Size(72, 16 /*0x10*/);
    this.label1.TabIndex = 0;
    this.label1.Text = "Find What : ";
    ((AppearanceBase) appearance).BackColor = Color.White;
    ((AppearanceBase) appearance).BorderColor = Color.Gray;
    ((AppearanceBase) appearance).ForeColor = Color.Black;
    ((TextEditorControlBase) this.mgaTextBox1).Appearance = (AppearanceBase) appearance;
    ((Control) this.mgaTextBox1).Location = new Point(80 /*0x50*/, 8);
    ((Control) this.mgaTextBox1).Name = "mgaTextBox1";
    ((Control) this.mgaTextBox1).Size = new Size(100, 19);
    ((Control) this.mgaTextBox1).TabIndex = 1;
    ((Control) this.mgaTextBox1).Text = "mgaTextBox1";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(384, 78);
    this.Controls.Add((Control) this.mgaTextBox1);
    this.Controls.Add((Control) this.label1);
    this.Name = nameof (formSearch);
    this.Text = nameof (formSearch);
    ((ISupportInitialize) this.mgaTextBox1).EndInit();
    this.ResumeLayout(false);
  }
}

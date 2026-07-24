// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.MultiLineEdit.MultiLineTextEditView
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.View;
using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.MultiLineEdit;

public class MultiLineTextEditView : MvcViewBase<MultiLineTextEditModel, MultiLineTextEditController>
{
  private TextBox textEdit;

  public MultiLineTextEditView() => this.InitializeComponent();

  public void UserSetText(string text) => this.Controller.RequestSetText(text);

  protected override void ChildUpdateFromModel(MultiLineTextEditModel model)
  {
    this.textEdit.Text = model.MultiLineText;
  }

  protected override void ChildUnWireUp() => this.textEdit.Text = string.Empty;

  private void textEdit_TextChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.UserSetText(this.textEdit.Text)));
  }

  private void InitializeComponent()
  {
    this.textEdit = new TextBox();
    this.SuspendLayout();
    this.textEdit.Dock = DockStyle.Fill;
    this.textEdit.Location = new Point(0, 0);
    this.textEdit.Multiline = true;
    this.textEdit.Name = "textEdit";
    this.textEdit.Size = new Size(15, 15);
    this.textEdit.TabIndex = 0;
    this.textEdit.TextChanged += new EventHandler(this.textEdit_TextChanged);
    this.Controls.Add((Control) this.textEdit);
    this.Name = nameof (MultiLineTextEditView);
    this.Size = new Size(15, 15);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}

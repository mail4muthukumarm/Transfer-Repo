// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.View.MvcComboBoxView
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.Model;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.View;

public class MvcComboBoxView : 
  MvcViewBase<IMvcComboBoxModel, IMvcComboBoxController>,
  IMvcComboBoxView,
  IMvcView<IMvcComboBoxModel, IMvcComboBoxController>,
  IMvcView,
  IModelObserver,
  IModelObserver<IMvcComboBoxModel>
{
  private IContainer components;
  private MGAComboBox cbWrappedComboBox;

  public MvcComboBoxView() => this.InitializeComponent();

  public void SetDropDownWidth(int width)
  {
    ((UltraDropDownBase) this.cbWrappedComboBox).DropDownWidth = width;
  }

  protected override void ChildUpdateFromModel(IMvcComboBoxModel model)
  {
    this.cbWrappedComboBox.Value = this.Model.HasSelectedItem() ? this.Model.SelectedItem : (object) null;
  }

  protected override void ChildWireUp() => this.Controller.WireUpComboBox(this.cbWrappedComboBox);

  private void cbWrappedComboBox_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.Controller.RequestSetSelectedValue(this.cbWrappedComboBox.Value)));
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.cbWrappedComboBox = new MGAComboBox();
    ((ISupportInitialize) this.cbWrappedComboBox).BeginInit();
    this.SuspendLayout();
    this.cbWrappedComboBox.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbWrappedComboBox).Dock = DockStyle.Fill;
    this.cbWrappedComboBox.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbWrappedComboBox).Location = new Point(0, 0);
    this.cbWrappedComboBox.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbWrappedComboBox).Name = "cbWrappedComboBox";
    ((Control) this.cbWrappedComboBox).Size = new Size(100, 20);
    ((Control) this.cbWrappedComboBox).TabIndex = 3;
    ((UltraControlBase) this.cbWrappedComboBox).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbWrappedComboBox).UseOsThemes = (DefaultableBoolean) 2;
    this.cbWrappedComboBox.AfterCloseUp += new EventHandler(this.cbWrappedComboBox_ValueChanged);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.cbWrappedComboBox);
    this.Name = nameof (MvcComboBoxView);
    this.Size = new Size(100, 20);
    ((ISupportInitialize) this.cbWrappedComboBox).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}

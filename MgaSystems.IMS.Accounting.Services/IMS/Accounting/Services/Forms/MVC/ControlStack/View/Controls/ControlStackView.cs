// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.ControlStackView
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.StackEntry;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls;

public class ControlStackView : 
  MvcViewBase<IControlStackObjectAdapterModel, IControlStackController>,
  IControlStackView,
  IMvcView,
  IModelObserver
{
  private FlowLayoutPanel controlFlow;

  public ControlStackView() => this.InitializeComponent();

  public void ResizeControlsToFlowLayout()
  {
    foreach (IStackEntryControl control in (ArrangedElementCollection) this.controlFlow.Controls)
      control.Width = this.controlFlow.ClientSize.Width;
  }

  protected override void ChildWireUp()
  {
    base.ChildWireUp();
    this.Invoke((Delegate) (() => this.Controller.FillControlFlow(this.controlFlow)));
  }

  protected override void ChildUpdateFromModel(IControlStackObjectAdapterModel model)
  {
    base.ChildUpdateFromModel(model);
    this.Controller.UpdateControlValuesFromModel((object) model);
  }

  private void controlFlow_SizeChanged(object sender, EventArgs e)
  {
    this.ResizeControlsToFlowLayout();
    this.ResizeControlsToFlowLayout();
  }

  private void InitializeComponent()
  {
    this.controlFlow = new FlowLayoutPanel();
    this.SuspendLayout();
    this.controlFlow.AutoScroll = true;
    this.controlFlow.AutoSize = true;
    this.controlFlow.BackColor = SystemColors.Control;
    this.controlFlow.Dock = DockStyle.Fill;
    this.controlFlow.FlowDirection = FlowDirection.TopDown;
    this.controlFlow.Location = new Point(0, 0);
    this.controlFlow.Margin = new Padding(0);
    this.controlFlow.Name = "controlFlow";
    this.controlFlow.Size = new Size(400, 200);
    this.controlFlow.TabIndex = 0;
    this.controlFlow.WrapContents = false;
    this.BackColor = SystemColors.Control;
    this.Controls.Add((Control) this.controlFlow);
    this.Margin = new Padding(0);
    this.Name = nameof (ControlStackView);
    this.Size = new Size(400, 200);
    this.SizeChanged += new EventHandler(this.controlFlow_SizeChanged);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}

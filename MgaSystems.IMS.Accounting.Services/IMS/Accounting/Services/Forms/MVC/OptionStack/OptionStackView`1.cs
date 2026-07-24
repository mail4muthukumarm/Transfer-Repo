// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.OptionStackView`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.BaseClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack;

[Obsolete]
public class OptionStackView<TDisplayItem> : 
  MvcViewBase<IOptionStackModel, IOptionStackController>,
  IOptionStackView<TDisplayItem>,
  IOptionStackView,
  IMvcView,
  IModelObserver
{
  private FlowLayoutPanel controlFlow;

  public IEnumerable<IOptionStackOptionSetting<TDisplayItem>> ControlSettings { get; private set; }

  public OptionStackView() => this.InitializeComponent();

  public void CreateControls(
    IEnumerable<IOptionStackOptionSetting<TDisplayItem>> controlSettings)
  {
    this.ControlSettings = controlSettings ?? throw new ArgumentNullException(nameof (controlSettings));
    this.controlFlow.Controls.AddRange(this.ControlSettings.Select<IOptionStackOptionSetting<TDisplayItem>, Control>((Func<IOptionStackOptionSetting<TDisplayItem>, Control>) (setting => setting.CreatedControl)).ToArray<Control>());
  }

  public void SetControlValues(TDisplayItem displayItem)
  {
    foreach (IOptionStackOptionSetting<TDisplayItem> controlSetting in this.ControlSettings)
      controlSetting.SetDisplayValue(displayItem);
  }

  public void SetControlValues(object displayItem)
  {
    if (!(displayItem is TDisplayItem displayItem1))
      throw new InvalidOperationException("Cannot set control values for displayItem that is not of type TDisplayItem");
    this.SetControlValues(displayItem1);
  }

  private void InitializeComponent()
  {
    this.controlFlow = new FlowLayoutPanel();
    this.SuspendLayout();
    this.controlFlow.Dock = DockStyle.Fill;
    this.controlFlow.FlowDirection = FlowDirection.TopDown;
    this.controlFlow.Location = new Point(0, 0);
    this.controlFlow.Name = "controlFlow";
    this.controlFlow.Size = new Size(400, 200);
    this.controlFlow.TabIndex = 0;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.controlFlow);
    this.Name = nameof (OptionStackView<TDisplayItem>);
    this.Size = new Size(400, 200);
    this.ResumeLayout(false);
  }
}

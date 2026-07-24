// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.BaseClasses.NamedValueSackOptionSetting`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.BaseClasses;

[Obsolete]
public abstract class NamedValueSackOptionSetting<TDisplayItem, TControl> : 
  IOptionStackOptionSetting<TDisplayItem>,
  IOptionStackOptionSetting
  where TControl : Control
{
  private OptionStackOptionControl _createdControl;

  protected NamedValueSackOptionSetting(string displayText)
  {
    this.DisplayText = displayText ?? throw new ArgumentNullException(nameof (displayText));
  }

  Control IOptionStackOptionSetting<TDisplayItem>.CreatedControl => (Control) this.CreatedControl;

  public OptionStackOptionControl CreatedControl
  {
    get
    {
      if (this._createdControl == null)
        this._createdControl = this.CreateControl();
      return this._createdControl;
    }
  }

  protected TControl ValueControl { get; private set; }

  public void SetDisplayValue(TDisplayItem item) => this.ChildSetDisplayValue(item);

  public void UpdateDisplayItem(TDisplayItem displayItem)
  {
    this.ChildUpdateDisplayItem(displayItem);
  }

  protected abstract TControl ChildCreateValueControl();

  protected virtual void ChildSetDisplayValue(TDisplayItem item)
  {
  }

  protected virtual void ChildUpdateDisplayItem(TDisplayItem displayItem)
  {
  }

  public string DisplayText { get; }

  private OptionStackOptionControl CreateControl()
  {
    OptionStackOptionControl control = new OptionStackOptionControl();
    this.CreateValueControl();
    control.Height = this.ValueControl.Height + 1;
    control.SetValueControl((Control) this.ValueControl);
    control.SetDisplayText(this.DisplayText);
    return control;
  }

  private void CreateValueControl()
  {
    this.ValueControl = this.ChildCreateValueControl();
    this.ValueControl.Padding = new Padding(0);
    this.ValueControl.Margin = new Padding(0, 0, 0, 1);
  }
}

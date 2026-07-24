// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.BaseClasses.NamedValueControlStackEntry`3
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.StackEntry;
using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.View.Controls.BaseClasses;

public abstract class NamedValueControlStackEntry<TDisplayItem, TDisplayField, TControl> : 
  UniqueObject<string>,
  IControlStackEntry<TDisplayItem>,
  IControlStackEntry
  where TControl : Control
{
  private IStackEntryControl _createdControl;
  private TControl _valueControl;

  public event Action ValueChanged;

  protected virtual int MinimumValueControlWidth { get; } = 10;

  protected TControl ValueControl
  {
    get
    {
      if ((object) this._valueControl == null)
        this._valueControl = this.CreateValueControl();
      return this._valueControl;
    }
  }

  public override string UniqueIdentifier { get; }

  public string DisplayText { get; }

  public int ValueControlMaxWidth { get; }

  public IStackEntryControl CreatedControl
  {
    get
    {
      if (this._createdControl == null)
        this._createdControl = this.CreateControl();
      return this._createdControl;
    }
  }

  protected NamedValueControlStackEntry(
    string displayText,
    int valueControlMaxWidth,
    Func<TDisplayItem, TDisplayField> getValueFromDisplayItemFunc,
    Action<TDisplayField> setDisplayItemValueAction)
    : this(new Guid().ToString(), displayText, valueControlMaxWidth, getValueFromDisplayItemFunc, setDisplayItemValueAction)
  {
  }

  protected NamedValueControlStackEntry(
    string uniqueIdentifier,
    string displayText,
    int valueControlMaxWidth,
    Func<TDisplayItem, TDisplayField> getValueFromDisplayItemFunc,
    Action<TDisplayField> setDisplayItemValueAction)
  {
    this.UniqueIdentifier = uniqueIdentifier ?? throw new ArgumentNullException(nameof (uniqueIdentifier));
    this.GetValueFunc = getValueFromDisplayItemFunc ?? throw new ArgumentNullException(nameof (getValueFromDisplayItemFunc));
    this.SetValueAction = setDisplayItemValueAction ?? throw new ArgumentNullException(nameof (setDisplayItemValueAction));
    this.DisplayText = displayText ?? throw new ArgumentNullException(nameof (displayText));
    this.ValueControlMaxWidth = valueControlMaxWidth > 0 ? valueControlMaxWidth : throw new ArgumentException("valueControlMaxWidth must be > 0");
  }

  public void SetDisplayValue(TDisplayItem item)
  {
    this.ChildSetControlValue(this.GetValueFunc(item));
  }

  public void UpdateDisplayItem()
  {
    this.SetValueAction(this.GetControlValue());
    Action valueChanged = this.ValueChanged;
    if (valueChanged == null)
      return;
    valueChanged();
  }

  protected abstract TControl ChildCreateValueControl();

  protected abstract IStackEntryControl CreateControl();

  protected abstract void SetUpValueChangedEvent(TControl valueControl, EventHandler onValueChanged);

  protected Func<TDisplayItem, TDisplayField> GetValueFunc { get; }

  protected abstract void ChildSetControlValue(TDisplayField value);

  protected Action<TDisplayField> SetValueAction { get; }

  protected abstract TDisplayField GetControlValue();

  private void OnValueChanged(object sender, EventArgs e) => this.UpdateDisplayItem();

  private TControl CreateValueControl()
  {
    TControl valueControl = this.ChildCreateValueControl();
    // ISSUE: variable of a boxed type
    __Boxed<TControl> local = (object) valueControl;
    Size size1 = valueControl.MaximumSize;
    int width = size1.Width;
    size1 = valueControl.Size;
    int height = size1.Height;
    Size size2 = new Size(width, height);
    local.MaximumSize = size2;
    valueControl.MinimumSize = new Size(this.MinimumValueControlWidth, valueControl.Size.Height);
    valueControl.Margin = new Padding(0, 0, 0, 0);
    valueControl.TabStop = true;
    valueControl.TabIndex = 0;
    this.SetUpValueChangedEvent(valueControl, new EventHandler(this.OnValueChanged));
    return valueControl;
  }
}

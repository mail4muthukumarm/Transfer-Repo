// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.DropDownEditorControl
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (ComboBox))]
[DefaultEvent("QueryControlValue")]
[DefaultProperty("Control")]
public class DropDownEditorControl : EditorWithTextDropDownControlBase
{
  private Control _control;

  protected override EditorWithText CreateEditorWithText()
  {
    return (EditorWithText) new DropDownEditor(this);
  }

  protected override EditorWithText CreateEditorWithText(EmbeddableEditorOwnerBase owner)
  {
    return (EditorWithText) new DropDownEditor(owner, this);
  }

  [Description("Fires when the control is attempting to validate a potential new value")]
  public event CancelEventHandler ValidatingControlValue;

  [Description("Fires when the control is querying for a new value")]
  public event QueryControlValueEventHandler QueryControlValue;

  [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
  protected virtual void OnValidatingControlValue(object sender, CancelEventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    CancelEventHandler controlValueEvent = this.ValidatingControlValueEvent;
    if (controlValueEvent == null)
      return;
    controlValueEvent(RuntimeHelpers.GetObjectValue(sender), e);
  }

  [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
  protected virtual void OnQueryControlValue(object sender, QueryControlValueEventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    QueryControlValueEventHandler controlValueEvent = this.QueryControlValueEvent;
    if (controlValueEvent == null)
      return;
    controlValueEvent(RuntimeHelpers.GetObjectValue(sender), e);
  }

  internal void FireQueryControlValue(object sender, QueryControlValueEventArgs e)
  {
    this.OnQueryControlValue(RuntimeHelpers.GetObjectValue(sender), e);
  }

  internal void FireValidatingControlValue(object sender, CancelEventArgs e)
  {
    this.OnValidatingControlValue(RuntimeHelpers.GetObjectValue(sender), e);
  }

  [DefaultValue(typeof (Control), "Nothing")]
  [Description("The control that will be dropped down")]
  [Category("Behavior")]
  public Control Control
  {
    get => this._control;
    set
    {
      if (value == this._control)
        return;
      this._control = value;
      EventHandler controlChangedEvent = this.ControlChangedEvent;
      if (controlChangedEvent == null)
        return;
      controlChangedEvent((object) this, EventArgs.Empty);
    }
  }

  public event EventHandler ControlChanged;
}

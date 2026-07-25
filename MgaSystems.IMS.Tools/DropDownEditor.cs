// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.DropDownEditor
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public class DropDownEditor : EditorWithTextAndDropDownBase
{
  private Control _control;
  private DropDownEditorControl _dropDownEditorControl;

  public event CancelEventHandler ValidatingControlValue;

  public event QueryControlValueEventHandler QueryControlValue;

  protected override Control ControlToDrop
  {
    get
    {
      return this._control != null ? this._control : throw new InvalidOperationException("Control Property Cannot Be NOTHING");
    }
  }

  protected override EditorWithTextAndDropDownUIElementBase CreateEmbeddableUIElement(
    UIElement parentElement,
    EmbeddableEditorOwnerBase owner,
    object ownerContext,
    bool includeEditElements,
    bool reserveSpaceForEditElements,
    bool drawOuterBorders,
    bool isToolTip)
  {
    return new EditorWithTextAndDropDownUIElementBase(parentElement, owner, (EmbeddableEditorBase) this, RuntimeHelpers.GetObjectValue(ownerContext), includeEditElements, reserveSpaceForEditElements, drawOuterBorders, isToolTip);
  }

  protected override object ControlToDropValue
  {
    get
    {
      QueryControlValueEventArgs e = new QueryControlValueEventArgs();
      this.OnQueryControlValue((object) this, e);
      this._dropDownEditorControl.FireQueryControlValue((object) this, e);
      return e.Value;
    }
  }

  protected override bool ShouldCommitControlToDropValue
  {
    get
    {
      CancelEventArgs e = new CancelEventArgs(false);
      this.OnValidatingControlValue((object) this, e);
      this._dropDownEditorControl.FireValidatingControlValue((object) this, e);
      return !e.Cancel;
    }
  }

  public Control Control
  {
    get => this._control;
    set => this._control = value;
  }

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

  public DropDownEditor(EmbeddableEditorOwnerBase defaultOwnder, DropDownEditorControl ownerControl)
    : base(defaultOwnder)
  {
    this._dropDownEditorControl = ownerControl != null ? ownerControl : throw new ArgumentNullException(nameof (ownerControl));
    this._dropDownEditorControl.ControlChanged += new EventHandler(this.DropDownControl_ControlChanged);
  }

  public DropDownEditor(DropDownEditorControl ownerControl)
  {
    this._dropDownEditorControl = ownerControl != null ? ownerControl : throw new ArgumentNullException(nameof (ownerControl));
    this._dropDownEditorControl.ControlChanged += new EventHandler(this.DropDownControl_ControlChanged);
  }

  protected override void OnDispose()
  {
    this._dropDownEditorControl.ControlChanged -= new EventHandler(this.DropDownControl_ControlChanged);
    ((EditorWithText) this).OnDispose();
  }

  private void DropDownControl_ControlChanged(object sender, EventArgs e)
  {
    this.Control = this._dropDownEditorControl.Control;
  }

  public override bool IsValid => true;

  public override Type GetEmbeddableElementType()
  {
    return typeof (EditorWithTextAndDropDownUIElementBase);
  }
}

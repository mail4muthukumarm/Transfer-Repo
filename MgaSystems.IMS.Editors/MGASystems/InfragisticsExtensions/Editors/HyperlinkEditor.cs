// Decompiled with JetBrains decompiler
// Type: MGASystems.InfragisticsExtensions.Editors.HyperlinkEditor
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using Infragistics.Win;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.InfragisticsExtensions.Editors;

public class HyperlinkEditor : EmbeddableEditorBase
{
  private CancelEventArgs cancelEventArgs;
  private HyperlinkEditor.UrlClickAction openInNewInstance;
  private string editText = string.Empty;

  public event CancelEventHandler HyperLinkOpening;

  public event EventHandler HyperLinkOpened;

  public override bool CanEditType(Type type) => true;

  public override bool CanRenderType(Type type) => true;

  public override string CurrentEditText => this.editText;

  public override bool CanFocus => false;

  public override bool Focus() => false;

  public override bool Focused => false;

  public override Type GetEmbeddableElementType() => typeof (HyperLinkEmbeddableUIElement);

  public override bool IsInputKey(Keys keyData) => false;

  protected internal virtual bool FireHyperLinkOpening()
  {
    CancelEventArgs cancelEventArgs = this.CancelEventArgs;
    try
    {
      if (this.HyperLinkOpening != null)
        this.HyperLinkOpening((object) this, cancelEventArgs);
    }
    catch
    {
    }
    return cancelEventArgs.Cancel;
  }

  protected internal virtual void FireHyperLinkOpened()
  {
    try
    {
      if (this.HyperLinkOpened == null)
        return;
      this.HyperLinkOpened((object) this, EventArgs.Empty);
    }
    catch
    {
    }
  }

  public override EmbeddableUIElementBase GetEmbeddableElement(
    UIElement parentElement,
    EmbeddableEditorOwnerBase owner,
    object ownerContext,
    bool includeEditElements,
    bool reserveSpaceForEditElements,
    bool drawOuterBorders,
    bool isToolTip,
    EmbeddableUIElementBase previousElement)
  {
    HyperLinkEmbeddableUIElement embeddableUiElement = (HyperLinkEmbeddableUIElement) null;
    if (previousElement != null && previousElement.GetType() == typeof (HyperLinkEmbeddableUIElement))
      embeddableUiElement = previousElement as HyperLinkEmbeddableUIElement;
    if (previousElement != null && this.ElementBeingEdited == previousElement)
      return previousElement;
    if (embeddableUiElement == null || ((UIElement) embeddableUiElement).Parent != parentElement)
      return (EmbeddableUIElementBase) new HyperLinkEmbeddableUIElement(parentElement, owner, (EmbeddableEditorBase) this, ownerContext, includeEditElements, reserveSpaceForEditElements, drawOuterBorders, isToolTip);
    previousElement.Initialize(owner, (EmbeddableEditorBase) this, ownerContext, includeEditElements, reserveSpaceForEditElements, drawOuterBorders, isToolTip);
    return previousElement;
  }

  public string GetElementText(EmbeddableUIElementBase element)
  {
    HyperlinkEditor editor = element.Editor as HyperlinkEditor;
    object obj = element.Owner.GetValue(element.OwnerContext);
    string empty = string.Empty;
    element.Owner.GetNullText(element.OwnerContext, ref empty);
    switch (obj)
    {
      case null:
      case DBNull _:
        return empty;
      default:
        return this.DataValueToText(obj, element.Owner, element.OwnerContext) ?? empty;
    }
  }

  private CancelEventArgs CancelEventArgs
  {
    get
    {
      if (this.cancelEventArgs == null)
        this.cancelEventArgs = new CancelEventArgs();
      this.cancelEventArgs.Cancel = false;
      return this.cancelEventArgs;
    }
  }

  public HyperlinkEditor.UrlClickAction ClickAction
  {
    get => this.openInNewInstance;
    set => this.openInNewInstance = value;
  }

  public override bool IsValid => true;

  public override object Value
  {
    get => (object) this.editText;
    set => this.editText = (string) value;
  }

  public override EmbeddableEditorBase Clone(EmbeddableEditorOwnerBase defaultOwner)
  {
    return (EmbeddableEditorBase) new HyperlinkEditor()
    {
      ClickAction = this.ClickAction
    };
  }

  protected override Size GetSize(ref EmbeddableEditorBase.EditorSizeInfo sizeInfo)
  {
    AppearanceData appearanceData = new AppearanceData();
    AppearancePropFlags appearancePropFlags = (AppearancePropFlags) 65011976L;
    ((EmbeddableEditorBase.EditorSizeInfo) ref sizeInfo).Owner.ResolveAppearance(((EmbeddableEditorBase.EditorSizeInfo) ref sizeInfo).OwnerContext, ref appearanceData, ref appearancePropFlags, (EmbeddableEditorArea) 1);
    Font font1 = (Font) null;
    Font font2 = ((EmbeddableEditorBase.EditorSizeInfo) ref sizeInfo).Owner.GetControl(((EmbeddableEditorBase.EditorSizeInfo) ref sizeInfo).OwnerContext).Font;
    if (((AppearanceData) ref appearanceData).HasFontData)
    {
      font1 = ((AppearanceData) ref appearanceData).CreateFont(font2);
      if (font1 != null)
        font2 = font1;
    }
    Graphics graphics = ((EmbeddableEditorBase.EditorSizeInfo) ref sizeInfo).Owner.GetControl(((EmbeddableEditorBase.EditorSizeInfo) ref sizeInfo).OwnerContext).CreateGraphics();
    object obj = ((EmbeddableEditorBase.EditorSizeInfo) ref sizeInfo).Owner.GetValue(((EmbeddableEditorBase.EditorSizeInfo) ref sizeInfo).OwnerContext);
    string empty = string.Empty;
    if (obj == null)
      ((EmbeddableEditorBase.EditorSizeInfo) ref sizeInfo).Owner.GetNullText(((EmbeddableEditorBase.EditorSizeInfo) ref sizeInfo).OwnerContext, ref empty);
    else
      empty = obj.ToString();
    Size size = graphics.MeasureString(empty, font2).ToSize();
    font1?.Dispose();
    graphics.Dispose();
    return size;
  }

  public enum UrlClickAction
  {
    None,
    OpenInNewInstance,
    OpenInExistingInstance,
  }
}

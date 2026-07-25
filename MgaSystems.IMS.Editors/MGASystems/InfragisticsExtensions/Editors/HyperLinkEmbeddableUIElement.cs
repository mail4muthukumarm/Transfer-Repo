// Decompiled with JetBrains decompiler
// Type: MGASystems.InfragisticsExtensions.Editors.HyperLinkEmbeddableUIElement
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using Infragistics.Win;
using MGASystems.Common;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.InfragisticsExtensions.Editors;

public class HyperLinkEmbeddableUIElement(
  UIElement parentElement,
  EmbeddableEditorOwnerBase owner,
  EmbeddableEditorBase editor,
  object ownerContext,
  bool includeEditElements,
  bool reserveSpaceForEditElements,
  bool drawOuterBorders,
  bool isToolTip) : EmbeddableUIElementBase(parentElement, owner, editor, ownerContext, includeEditElements, reserveSpaceForEditElements, drawOuterBorders, isToolTip)
{
  protected override void PositionChildElements()
  {
    string elementText = ((HyperlinkEditor) this.Editor).GetElementText((EmbeddableUIElementBase) this);
    TextUIElement textUiElement = this.TextUIElement;
    ((TextUIElementBase) textUiElement).Text = elementText;
    textUiElement.TextHAlign = (HAlign) 2;
    textUiElement.TextVAlign = (VAlign) 2;
    ((UIElement) textUiElement).Rect = ((UIElement) this).RectInsideBorders;
    ((UIElement) textUiElement).Enabled = ((UIElement) this).Enabled;
    string str = (string) this.Editor.Value;
    if (elementText != str)
      this.Editor.Value = (object) elementText;
    ((UIElement) this).PositionChildElements();
  }

  protected override void OnClick()
  {
    if (!((UIElement) this).Enabled)
      return;
    HyperlinkEditor editor = this.Editor as HyperlinkEditor;
    if (!editor.FireHyperLinkOpening())
    {
      if (editor.ClickAction == HyperlinkEditor.UrlClickAction.OpenInExistingInstance)
        Process.Start(((TextUIElementBase) this.TextUIElement).Text);
      else if (editor.ClickAction == HyperlinkEditor.UrlClickAction.OpenInNewInstance)
        Process.Start("IExplore.exe", ((TextUIElementBase) this.TextUIElement).Text);
      editor.FireHyperLinkOpened();
    }
    base.OnClick();
  }

  protected override void InitAppearance(
    ref AppearanceData appearance,
    ref AppearancePropFlags requestedProps)
  {
    if (this.IsMouseOverElement && ((UIElement) this).Enabled)
    {
      ((AppearanceData) ref appearance).FontData.Underline = (DefaultableBoolean) 1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(long&) ref requestedProps = ^(long&) ref requestedProps & -8388609L;
    }
    this.Owner.ResolveAppearance(this.OwnerContext, ref appearance, ref requestedProps);
    ((UIElement) this).InitAppearance(ref appearance, ref requestedProps);
  }

  private TextUIElement TextUIElement
  {
    get
    {
      if (!(UIElement.ExtractExistingElement((ArrayList) ((UIElement) this).ChildElements, typeof (TextUIElement), false) is TextUIElement textUiElement))
      {
        textUiElement = new TextUIElement((UIElement) this, string.Empty);
        ((UIElement) this).ChildElements.Add((UIElement) textUiElement);
      }
      return textUiElement;
    }
  }

  public override Cursor Cursor
  {
    get => ((UIElement) this).Enabled ? MgaCursors.Hand : ((UIElement) this).Cursor;
  }
}

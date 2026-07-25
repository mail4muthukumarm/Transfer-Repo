// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGATreeView
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinTree;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public sealed class MGATreeView : UltraTree, IUIElementDrawFilter, IUIElementCreationFilter
{
  private Dictionary<Image, Icon> _iconImages;
  private Dictionary<string, Bitmap> _placeHolders;
  private MGAStyles _mgaStyle;

  public MGATreeView()
  {
    this._iconImages = new Dictionary<Image, Icon>();
    this._placeHolders = new Dictionary<string, Bitmap>();
    this._mgaStyle = MGAStyles.Gray;
    MGATreeView.InitializeAppearance(this.Appearance, MGAStyles.Gray);
    this.BorderStyle = (UIElementBorderStyle) 4;
    this.ShowLines = false;
    this.SupportThemes = false;
    ((UltraControlBase) this).DrawFilter = (IUIElementDrawFilter) this;
    ((UltraControlBase) this).CreationFilter = (IUIElementCreationFilter) this;
    ((Control) this).DoubleBuffered = true;
  }

  public bool DrawElement(DrawPhase drawPhase, ref UIElementDrawParams drawParams)
  {
    bool flag;
    if (drawPhase == 512 /*0x0200*/ && ((UIElementDrawParams) ref drawParams).Element is ImageUIElement)
    {
      ImageUIElement element = (ImageUIElement) ((UIElementDrawParams) ref drawParams).Element;
      if (this._iconImages.ContainsKey(element.Image))
      {
        Icon iconImage = this._iconImages[element.Image];
        Rectangle rect = ((UIElement) element).Rect;
        ((UIElementDrawParams) ref drawParams).Graphics.DrawIcon(iconImage, rect.X, rect.Y);
        flag = true;
        goto label_4;
      }
    }
    flag = false;
label_4:
    return flag;
  }

  public DrawPhase GetPhasesToFilter(ref UIElementDrawParams drawParams)
  {
    return !(((UIElementDrawParams) ref drawParams).Element is ImageUIElement) ? (DrawPhase) 0 : (DrawPhase) 512 /*0x0200*/;
  }

  public void AfterCreateChildElements(UIElement parent)
  {
  }

  public bool BeforeCreateChildElements(UIElement parent)
  {
    if (parent is TreeNodeUIElement)
    {
      UltraTreeNode context = (UltraTreeNode) parent.GetContext(typeof (UltraTreeNode));
      if (((DisposableObjectCollectionBase) context.LeftImages).Count > 0)
      {
        int num = ((DisposableObjectCollectionBase) context.LeftImages).Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (context.LeftImages[index] is Icon)
          {
            Icon leftImage = (Icon) context.LeftImages[index];
            Image placeHolderImage = this.GetPlaceHolderImage(leftImage);
            context.LeftImages[index] = (object) placeHolderImage;
            if (!this._iconImages.ContainsKey(placeHolderImage))
              this._iconImages.Add(placeHolderImage, leftImage);
          }
        }
      }
    }
    return false;
  }

  private Image GetPlaceHolderImage(Icon ic)
  {
    string key = ic.Handle.ToString();
    Image placeHolderImage;
    if (this._placeHolders.ContainsKey(key))
    {
      placeHolderImage = (Image) this._placeHolders[key];
    }
    else
    {
      Bitmap bitmap = new Bitmap(ic.Size.Width, ic.Size.Height);
      this._placeHolders.Add(key, bitmap);
      placeHolderImage = (Image) bitmap;
    }
    return placeHolderImage;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      this._iconImages.Clear();
      this._placeHolders.Clear();
    }
    base.Dispose(disposing);
  }

  [DefaultValue(typeof (MGAStyles), "Gray")]
  public MGAStyles MGAStyle
  {
    get => this._mgaStyle;
    set
    {
      if (this._mgaStyle != value)
      {
        this._mgaStyle = value;
        MGATreeView.InitializeAppearance(this.Appearance, this._mgaStyle);
      }
      this.Refresh();
    }
  }

  public static void InitializeAppearance(AppearanceBase app, MGAStyles style)
  {
    AppearanceBase appearanceBase = app;
    switch (style)
    {
      case MGAStyles.Gray:
        appearanceBase.BorderColor = Color.Gray;
        break;
      case MGAStyles.Blue:
        appearanceBase.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
        break;
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public bool FlatMode
  {
    get => ((UltraControlBase) this).UseFlatMode > 0;
    set
    {
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public bool SupportThemes
  {
    get => ((UltraControlBase) this).UseOsThemes > 0;
    set
    {
    }
  }
}

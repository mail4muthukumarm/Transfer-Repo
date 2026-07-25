// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGAGrid
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System;
using System.ComponentModel;
using System.Drawing;

#nullable disable
namespace MGASystems.Tools;

public sealed class MGAGrid : UltraGrid
{
  public MGAGrid()
  {
    ((UltraControlBase) this).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this).UseOsThemes = (DefaultableBoolean) 2;
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public UltraGridLayout DisplayLayout => ((UltraGridBase) this).DisplayLayout;

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public DefaultableBoolean FlatMode
  {
    get => ((UltraControlBase) this).UseFlatMode;
    set => ((UltraControlBase) this).UseFlatMode = value;
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public DefaultableBoolean SupportThemes
  {
    get => ((UltraControlBase) this).UseOsThemes;
    set => ((UltraControlBase) this).UseOsThemes = value;
  }

  public static void ApplyMGALayout(UltraGridLayout layout)
  {
    MGAGrid.ApplyMGALayout(layout, MGAGridProps.All);
  }

  public static void ApplyMGALayout(UltraGridLayout layout, MGAGridProps props)
  {
    UltraGridLayout ultraGridLayout = layout != null ? layout : throw new ArgumentNullException(nameof (layout));
    if ((props & MGAGridProps.SetAppearances) != MGAGridProps.None)
    {
      ultraGridLayout.Appearance.BackColor = Color.White;
      ultraGridLayout.Appearance.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
      ultraGridLayout.Override.ActiveRowAppearance.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
      ultraGridLayout.Override.ActiveRowAppearance.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
      ultraGridLayout.Override.ActiveRowAppearance.ForeColor = Color.Black;
      ultraGridLayout.Override.CellAppearance.BorderColor = Color.LightGray;
      ultraGridLayout.Override.HeaderAppearance.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
      ultraGridLayout.Override.RowAlternateAppearance.BackColor = Color.FromArgb(246, 250, 253);
      ultraGridLayout.Override.SelectedRowAppearance.BackColor = Color.Transparent;
      ultraGridLayout.Override.SelectedRowAppearance.ForeColor = Color.Black;
      ultraGridLayout.Override.RowAppearance.BorderColor = Color.LightGray;
      ultraGridLayout.ScrollBarLook.ButtonAppearance.BackColor = Color.WhiteSmoke;
      ultraGridLayout.ScrollBarLook.ButtonAppearance.BorderColor = Color.Silver;
      ultraGridLayout.ScrollBarLook.TrackAppearance.BackColor = Color.White;
    }
    if ((props & MGAGridProps.RowSelect) != MGAGridProps.None)
      ultraGridLayout.Override.CellClickAction = (CellClickAction) 2;
    if ((props & MGAGridProps.AutoColumnSizingOn) != MGAGridProps.None)
    {
      ultraGridLayout.Override.AllowColSizing = (AllowColSizing) 3;
      ultraGridLayout.AutoFitStyle = (AutoFitStyle) 2;
    }
    if ((props & MGAGridProps.SetBorderStyle) != MGAGridProps.None)
      ultraGridLayout.BorderStyle = (UIElementBorderStyle) 4;
    if ((props & MGAGridProps.HideRowSelectors) != MGAGridProps.None)
      ultraGridLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    if ((props & MGAGridProps.AllowDeleting) != MGAGridProps.None)
      ultraGridLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    if ((props & MGAGridProps.AllowUpdating) != MGAGridProps.None)
      ultraGridLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    if ((props & MGAGridProps.Flat) != MGAGridProps.None)
    {
      if (((UltraControlBase) layout.Grid).UseOsThemes == 1)
        ((UltraControlBase) layout.Grid).UseOsThemes = (DefaultableBoolean) 2;
      if (((UltraControlBase) layout.Grid).UseFlatMode == 2)
        ((UltraControlBase) layout.Grid).UseFlatMode = (DefaultableBoolean) 1;
    }
    ultraGridLayout.Override.MaxSelectedRows = 1;
  }

  protected override void OnInitializeLayout(InitializeLayoutEventArgs e)
  {
    base.OnInitializeLayout(e);
    MGAGrid.ApplyMGALayout(e.Layout);
  }
}

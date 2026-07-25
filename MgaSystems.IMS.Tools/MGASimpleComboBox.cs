// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGASimpleComboBox
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public class MGASimpleComboBox : UltraCombo
{
  private MGAStyles _mgaStyle;
  private bool _autoSelectOnOneItem;

  public MGASimpleComboBox()
  {
    this.BeforeDropDown += new CancelEventHandler(this.MGASimpleComboBox_BeforeDropDown);
    ((Control) this).KeyDown += new KeyEventHandler(this.MGASimpleComboBox_KeyDown);
    this._mgaStyle = MGAStyles.Gray;
    ((Control) this).DoubleBuffered = true;
    this.DropDownStyle = (UltraComboStyle) 1;
    this.SetupAppearances();
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public bool FlatMode
  {
    get => ((UltraControlBase) this).UseFlatMode == 1;
    set
    {
      if (value)
        ((UltraControlBase) this).UseFlatMode = (DefaultableBoolean) 1;
      else
        ((UltraControlBase) this).UseFlatMode = (DefaultableBoolean) 2;
    }
  }

  [DefaultValue(false)]
  public bool AutoSelectOnOneItem
  {
    get => this._autoSelectOnOneItem;
    set => this._autoSelectOnOneItem = value;
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public bool SupportThemes
  {
    get => ((UltraControlBase) this).UseOsThemes != 2;
    set
    {
      if (!value)
        ((UltraControlBase) this).UseOsThemes = (DefaultableBoolean) 2;
      else
        ((UltraControlBase) this).UseOsThemes = (DefaultableBoolean) 1;
    }
  }

  [Bindable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public int SelectedIndex
  {
    set
    {
      if (((UltraGridBase) this).DataSource == null)
        return;
      if (value == -1)
        ((UltraDropDownBase) this).SelectedRow = (UltraGridRow) null;
      else
        ((UltraDropDownBase) this).SelectedRow = ((UltraGridBase) this).Rows[value];
    }
    get
    {
      return ((UltraDropDownBase) this).SelectedRow != null ? ((UltraDropDownBase) this).SelectedRow.Index : -1;
    }
  }

  [DefaultValue(typeof (MGAStyles), "Gray")]
  public MGAStyles MGAStyle
  {
    get => this._mgaStyle;
    set
    {
      if (value == this._mgaStyle)
        return;
      this._mgaStyle = value;
      this.SetupAppearances();
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public UltraGridLayout DisplayLayout => ((UltraGridBase) this).DisplayLayout;

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public AppearanceBase Appearance
  {
    get => base.Appearance;
    set => base.Appearance = value;
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public AppearanceBase ButtonAppearance
  {
    get => base.ButtonAppearance;
    set => base.ButtonAppearance = value;
  }

  public virtual void DropDown()
  {
    if (((UltraDropDownBase) this).DropDownWidth < ((Control) this).Width)
      ((UltraDropDownBase) this).DropDownWidth = ((Control) this).Width;
    foreach (UltraGridColumn column in this.DisplayLayout.Bands[0].Columns)
    {
      if (Operators.CompareString(column.Key.ToLower(), ((UltraDropDownBase) this).DisplayMember.ToLower(), false) != 0)
        column.Hidden = true;
    }
  }

  private void MGASimpleComboBox_BeforeDropDown(object sender, CancelEventArgs e)
  {
    this.BeforeDropDown -= new CancelEventHandler(this.MGASimpleComboBox_BeforeDropDown);
    this.DropDown();
    this.BeforeDropDown += new CancelEventHandler(this.MGASimpleComboBox_BeforeDropDown);
  }

  protected override void OnInitializeLayout(InitializeLayoutEventArgs e)
  {
    base.OnInitializeLayout(e);
    if (this.MGAStyle == MGAStyles.Blue)
      this.SetBlueAppearance();
    else
      this.SetGrayAppearance();
    if (!(((UltraGridBase) this).Rows != null & ((UltraGridBase) this).Rows.Count == 1 & this.AutoSelectOnOneItem))
      return;
    this.SelectedIndex = 0;
  }

  private void SetupAppearances()
  {
    if (this.MGAStyle == MGAStyles.Blue)
      this.SetBlueAppearance();
    else
      this.SetGrayAppearance();
  }

  private void SetCommonAppearances()
  {
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
    ((UltraControlBase) this).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this).UseOsThemes = (DefaultableBoolean) 2;
    Infragistics.Win.Appearance appearance2 = appearance1;
    appearance2.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance2.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.Appearance.ForeColor = Color.Black;
    UltraGridLayout displayLayout = this.DisplayLayout;
    displayLayout.ScrollBarLook = scrollBarLook;
    displayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance1;
    displayLayout.Override.RowAppearance.BorderColor = Color.White;
    displayLayout.Appearance.BorderColor = Color.LightGray;
    displayLayout.Override.RowSpacingAfter = 1;
    displayLayout.BorderStyle = (UIElementBorderStyle) 4;
    displayLayout.AutoFitStyle = (AutoFitStyle) 1;
    displayLayout.Bands[0].ColHeadersVisible = false;
    displayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    displayLayout.Appearance.BackColor = Color.White;
    displayLayout.Override.SelectedRowAppearance.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    displayLayout.Override.SelectedRowAppearance.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    displayLayout.Override.SelectedRowAppearance.ForeColor = Color.Black;
  }

  private void SetGrayAppearance()
  {
    this.SetCommonAppearances();
    this.Appearance.BorderColor = Color.Gray;
    AppearanceBase buttonAppearance = this.ButtonAppearance;
    buttonAppearance.BackColor = Color.LightGray;
    buttonAppearance.BackColor2 = Color.White;
    buttonAppearance.BackGradientStyle = (GradientStyle) 2;
    buttonAppearance.BorderColor = Color.LightGray;
    buttonAppearance.ForeColor = Color.FromArgb(60, 60, 60);
  }

  private void SetBlueAppearance()
  {
    this.SetCommonAppearances();
    this.Appearance.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.BorderStyle = (UIElementBorderStyle) 4;
    this.CharacterCasing = CharacterCasing.Normal;
    AppearanceBase buttonAppearance = this.ButtonAppearance;
    buttonAppearance.AlphaLevel = (short) 14;
    buttonAppearance.BackColor = Color.FromArgb(0, 0, 246, 253);
    buttonAppearance.BackColor2 = Color.FromArgb(133, 162, 221);
    buttonAppearance.BackColorAlpha = (Alpha) 2;
    buttonAppearance.BackGradientAlignment = (GradientAlignment) 4;
    buttonAppearance.BackGradientStyle = (GradientStyle) 5;
    buttonAppearance.BorderAlpha = (Alpha) 1;
    buttonAppearance.BorderColor = Color.FromArgb(78, 122, 171);
    buttonAppearance.ForeColor = Color.FromArgb(49, 85, 153);
    buttonAppearance.ForegroundAlpha = (Alpha) 2;
    this.DisplayLayout.Appearance.BorderColor = Color.FromArgb(78, 122, 171);
  }

  private void MGASimpleComboBox_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Delete)
      return;
    this.Value = (object) null;
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    try
    {
      base.OnPaint(e);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }
}

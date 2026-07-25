// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGAStatusLook
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (MGAStatusLook))]
public sealed class MGAStatusLook : Component
{
  private IContainer components;
  private MGAStatusLook.DisplayAction _activeValueDisplayAction;
  private int _inactiveValue;
  private int _activeValue;
  private MGAStatusLook.DisplayAction _inActiveValueDisplayAction;
  private int _closedValue;
  private MGAStatusLook.DisplayAction _closedValueDisplayAction;
  private Brush _actionBrushError;
  private Brush _actionBrushNormal;
  private Brush _actionBrushDisabled;
  private Brush _actionBrushDisabledStrike;
  private Color _normalForeColor;
  private Color _errorForeColor;
  private Color _disabledForeColor;
  private Color _disabledStrikeThruForeColor;

  public MGAStatusLook(IContainer container)
    : this()
  {
    if (container == null)
      throw new ArgumentNullException(nameof (container));
    container.Add((IComponent) this);
  }

  public MGAStatusLook()
  {
    this._activeValueDisplayAction = MGAStatusLook.DisplayAction.Normal;
    this._inactiveValue = 2;
    this._activeValue = 1;
    this._inActiveValueDisplayAction = MGAStatusLook.DisplayAction.Disabled;
    this._closedValue = 3;
    this._closedValueDisplayAction = MGAStatusLook.DisplayAction.DisabledStrike;
    this._normalForeColor = SystemColors.ControlText;
    this._errorForeColor = Color.Red;
    this._disabledForeColor = SystemColors.GrayText;
    this._disabledStrikeThruForeColor = SystemColors.GrayText;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    this.CleanUp();
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent() => this.components = (IContainer) new System.ComponentModel.Container();

  [Category("Appearance")]
  [Description("Determines how to display items that are active.")]
  [DefaultValue(typeof (MGAStatusLook.DisplayAction), "Normal")]
  public MGAStatusLook.DisplayAction ActiveValueDisplayAction
  {
    get => this._activeValueDisplayAction;
    set => this._activeValueDisplayAction = value;
  }

  [Category("Appearance")]
  [Description("The default value used to identify InActiveValue items.")]
  [DefaultValue(2)]
  public int InActiveValue
  {
    get => this._inactiveValue;
    set => this._inactiveValue = value;
  }

  [Category("Appearance")]
  [Description("The default value used to identify ActiveValue items.")]
  [DefaultValue(1)]
  public int ActiveValue
  {
    get => this._activeValue;
    set => this._activeValue = value;
  }

  [Category("Appearance")]
  [Description("Determines how to display items that are inactive.")]
  [DefaultValue(typeof (MGAStatusLook.DisplayAction), "Disabled")]
  public MGAStatusLook.DisplayAction InActiveValueDisplayAction
  {
    get => this._inActiveValueDisplayAction;
    set => this._inActiveValueDisplayAction = value;
  }

  [Category("Appearance")]
  [Description("The default value used to identify Closed items.")]
  [DefaultValue(3)]
  public int ClosedValue
  {
    get => this._closedValue;
    set => this._closedValue = value;
  }

  [Category("Appearance")]
  [Description("Determines how to display items that are closed.")]
  [DefaultValue(typeof (MGAStatusLook.DisplayAction), "DisabledStrike")]
  public MGAStatusLook.DisplayAction ClosedValueDisplayAction
  {
    get => this._closedValueDisplayAction;
    set => this._closedValueDisplayAction = value;
  }

  [Browsable(false)]
  public Brush ActionBrushError
  {
    get
    {
      if (this._actionBrushError == null)
        this._actionBrushError = (Brush) new SolidBrush(this.ErrorForeColor);
      return this._actionBrushError;
    }
  }

  [Browsable(false)]
  public Brush ActionBrushNormal
  {
    get
    {
      if (this._actionBrushNormal == null)
        this._actionBrushNormal = (Brush) new SolidBrush(this.NormalForeColor);
      return this._actionBrushNormal;
    }
  }

  [Browsable(false)]
  public Brush ActionBrushDisabled
  {
    get
    {
      if (this._actionBrushDisabled == null)
        this._actionBrushDisabled = (Brush) new SolidBrush(this.DisabledForeColor);
      return this._actionBrushDisabled;
    }
  }

  [Browsable(false)]
  public Brush ActionBrushDisabledStrike
  {
    get
    {
      if (this._actionBrushDisabledStrike == null)
        this._actionBrushDisabledStrike = (Brush) new SolidBrush(this.DisabledStrikeThruForeColor);
      return this._actionBrushDisabledStrike;
    }
  }

  [Category("Appearance")]
  [Description("The default color used to identify normal items.")]
  public Color NormalForeColor
  {
    get => this._normalForeColor;
    set
    {
      this._normalForeColor = value;
      this.ResetBrushes();
    }
  }

  private void ResetNormalForeColor() => this._normalForeColor = SystemColors.ControlText;

  private bool ShouldSerializeNormalForeColor()
  {
    this._normalForeColor.Equals((object) SystemColors.ControlText);
    bool flag;
    return flag;
  }

  [Category("Appearance")]
  [Description("The default color used to identify error items.")]
  public Color ErrorForeColor
  {
    get => this._errorForeColor;
    set
    {
      this._errorForeColor = value;
      this.ResetBrushes();
    }
  }

  private void ResetErrorForeColor() => this._errorForeColor = Color.Red;

  private bool ShouldSerializeErrorForeColor()
  {
    this._errorForeColor.Equals((object) Color.Red);
    bool flag;
    return flag;
  }

  [Category("Appearance")]
  [Description("The default color used to identify disabled items.")]
  public Color DisabledForeColor
  {
    get => this._disabledForeColor;
    set
    {
      this._disabledForeColor = value;
      this.ResetBrushes();
    }
  }

  private void ResetDisabledForeColor() => this._disabledForeColor = SystemColors.GrayText;

  private bool ShouldSerializeDisabledForeColor()
  {
    this._disabledForeColor.Equals((object) SystemColors.GrayText);
    bool flag;
    return flag;
  }

  [Category("Appearance")]
  [Description("The default color used to identify disabled strikethru items.")]
  public Color DisabledStrikeThruForeColor
  {
    get => this._disabledStrikeThruForeColor;
    set
    {
      this._disabledStrikeThruForeColor = value;
      this.ResetBrushes();
    }
  }

  private void ResetDisabledStrikeThruForeColor()
  {
    this._disabledStrikeThruForeColor = SystemColors.GrayText;
  }

  private bool ShouldSerializeDisabledStrikeThruForeColor()
  {
    this._disabledStrikeThruForeColor.Equals((object) SystemColors.GrayText);
    bool flag;
    return flag;
  }

  private void ResetBrushes()
  {
    if (this.DesignMode)
      return;
    this.CleanUp();
  }

  private void CleanUp()
  {
    if (this._actionBrushDisabled != null)
    {
      this._actionBrushDisabled.Dispose();
      this._actionBrushDisabled = (Brush) null;
    }
    if (this._actionBrushError != null)
    {
      this._actionBrushError.Dispose();
      this._actionBrushError = (Brush) null;
    }
    if (this._actionBrushNormal != null)
    {
      this._actionBrushNormal.Dispose();
      this._actionBrushNormal = (Brush) null;
    }
    if (this._actionBrushDisabledStrike == null)
      return;
    this._actionBrushDisabledStrike.Dispose();
    this._actionBrushDisabledStrike = (Brush) null;
  }

  public enum DisplayAction
  {
    Error,
    Normal,
    Disabled,
    DisabledStrike,
  }
}

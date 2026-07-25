// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.RequiredFieldValidator
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (System.Web.UI.WebControls.RequiredFieldValidator))]
public sealed class RequiredFieldValidator : ValidatorBase
{
  private Color _validBackcolor;
  private Color _invalidBackcolor;

  [Category("Appearance")]
  [Description("Color displayed when control is in valid state")]
  public Color ValidBackcolor
  {
    get => this._validBackcolor;
    set => this._validBackcolor = value;
  }

  private void ResetValidBackcolor() => this._validBackcolor = SystemColors.Window;

  private bool ShouldSerializeValidBackcolor()
  {
    return !this._validBackcolor.Equals((object) SystemColors.Window);
  }

  [Category("Appearance")]
  [Description("Color displayed when control is in invalid state")]
  public Color InvalidBackcolor
  {
    get => this._invalidBackcolor;
    set => this._invalidBackcolor = value;
  }

  private void ResetInvalidBackcolor() => this._invalidBackcolor = SystemColors.Window;

  private bool ShouldSerializeInvalidBackcolor()
  {
    return !this._invalidBackcolor.Equals((object) Color.LightYellow);
  }

  protected internal override Type[] GetAcceptableFieldToValidateTypes()
  {
    return new Type[8]
    {
      typeof (string),
      typeof (int),
      typeof (double),
      typeof (DateTime),
      typeof (Decimal),
      typeof (object),
      typeof (long),
      typeof (float)
    };
  }

  public RequiredFieldValidator(IContainer container)
    : base(container)
  {
    this._validBackcolor = SystemColors.Window;
    this._invalidBackcolor = Color.LightYellow;
    base.ErrorMessage = "Required Field";
  }

  public RequiredFieldValidator()
  {
    this._validBackcolor = SystemColors.Window;
    this._invalidBackcolor = Color.LightYellow;
    base.ErrorMessage = "Required Field";
  }

  [Category("Appearance")]
  [Description("Message to display when control is not valid")]
  [DefaultValue("Required Field")]
  public override string ErrorMessage
  {
    get => base.ErrorMessage;
    set => base.ErrorMessage = value;
  }

  public override void EndInit()
  {
    base.EndInit();
    PropertyInfo property = this.ControlToValidate.GetType().GetProperty("ReadOnly");
    if ((object) property != null)
    {
      if (Conversions.ToBoolean(property.GetValue((object) this.ControlToValidate, (object[]) null)) || !this.ControlToValidate.Enabled)
        return;
      RequiredFieldValidator.SetupControlBackColor(this.ControlToValidate, this._invalidBackcolor);
    }
    else
    {
      if (!this.ControlToValidate.Enabled)
        return;
      RequiredFieldValidator.SetupControlBackColor(this.ControlToValidate, this._invalidBackcolor);
    }
  }

  private static void SetupControlBackColor(Control control, Color newColor)
  {
    if (control == null)
      return;
    if (control is UltraControlBase)
    {
      PropertyInfo property = control.GetType().GetProperty("Appearance");
      if ((object) property == null)
        return;
      AppearanceBase appearanceBase = (AppearanceBase) property.GetValue((object) control, (object[]) null);
      if (appearanceBase == null)
        return;
      appearanceBase.BackColor = newColor;
    }
    else
      control.BackColor = newColor;
  }

  protected override void ControlToValidateChanged(Control oldControl)
  {
    base.ControlToValidateChanged(oldControl);
    RequiredFieldValidator.SetupControlBackColor(oldControl, this._validBackcolor);
    RequiredFieldValidator.SetupControlBackColor(this.ControlToValidate, this._invalidBackcolor);
  }

  protected override void OnValidated(EventArgs e)
  {
    base.OnValidated(e);
    if (this.IsValid)
      RequiredFieldValidator.SetupControlBackColor(this.ControlToValidate, this._validBackcolor);
    else
      RequiredFieldValidator.SetupControlBackColor(this.ControlToValidate, this._invalidBackcolor);
  }

  protected override bool EvaluateIsValid()
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this.ValueToTest);
    return objectValue != null && (objectValue == null || objectValue.ToString().Length != 0);
  }
}

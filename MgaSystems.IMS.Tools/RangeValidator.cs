// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.RangeValidator
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (System.Web.UI.WebControls.RangeValidator))]
public sealed class RangeValidator : ValidatorBase
{
  private string _minimumValue;
  private string _maximumValue;

  public RangeValidator(IContainer container)
    : base(container)
  {
  }

  public RangeValidator()
  {
  }

  protected internal override Type[] GetAcceptableFieldToValidateTypes()
  {
    return new Type[5]
    {
      typeof (string),
      typeof (int),
      typeof (double),
      typeof (DateTime),
      typeof (Decimal)
    };
  }

  [Category("Behavior")]
  [Description("Maximum value for the control being validated")]
  [DefaultValue("")]
  public string MaximumValue
  {
    get => this._maximumValue;
    set => this._maximumValue = value;
  }

  [Category("Behavior")]
  [Description("Minimum value for the control being validated")]
  [DefaultValue("")]
  public string MinimumValue
  {
    get => this._minimumValue;
    set => this._minimumValue = value;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public override string ErrorMessage
  {
    get
    {
      object objectValue = RuntimeHelpers.GetObjectValue(this.ValueToTest);
      return !(Versioned.IsNumeric((object) this.MaximumValue) & !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue))) ? (!(Information.IsDate((object) this.MaximumValue) & !Information.IsDate(RuntimeHelpers.GetObjectValue(objectValue))) ? $"Value must be between {this.MinimumValue} and {this.MaximumValue}" : "Value must be a date") : "Value must be numeric";
    }
    set => base.ErrorMessage = value;
  }

  protected override bool EvaluateIsValid()
  {
    if (this.MaximumValue == null || Operators.CompareString(this.MaximumValue, string.Empty, false) == 0)
      throw new ValidationException("Maximum value cannot be empty");
    if (this.MinimumValue == null || Operators.CompareString(this.MinimumValue, string.Empty, false) == 0)
      throw new ValidationException("MinimumValue value cannot be empty");
    bool isValid;
    if (this.ValueToTest == null)
    {
      isValid = true;
    }
    else
    {
      object objectValue = RuntimeHelpers.GetObjectValue(this.ValueToTest);
      if (objectValue != null)
      {
        if (Information.IsDate(RuntimeHelpers.GetObjectValue(objectValue)) && Information.IsDate((object) this.MaximumValue) && Information.IsDate((object) this.MinimumValue))
        {
          DateTime t2_1 = DateTime.Parse(this.MaximumValue);
          DateTime t2_2 = DateTime.Parse(this.MinimumValue);
          DateTime date = Conversions.ToDate(objectValue);
          isValid = DateTime.Compare(date, t2_1) <= 0 && DateTime.Compare(date, t2_2) >= 0;
        }
        else if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue)) && Versioned.IsNumeric((object) this.MaximumValue) && Versioned.IsNumeric((object) this.MinimumValue))
        {
          Decimal d1 = Decimal.Parse(objectValue.ToString());
          Decimal d2_1 = Decimal.Parse(this.MaximumValue);
          Decimal d2_2 = Decimal.Parse(this.MinimumValue);
          isValid = Decimal.Compare(d1, d2_1) <= 0 && Decimal.Compare(d1, d2_2) >= 0;
        }
        else
          isValid = false;
      }
      else
        isValid = false;
    }
    return isValid;
  }
}

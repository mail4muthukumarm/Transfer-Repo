// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.CompareValidator
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (System.Web.UI.WebControls.CompareValidator))]
public sealed class CompareValidator : ValidatorBase
{
  private ValidationCompareOperator _compareOperator;
  private Control _controlToValidateAgainst;
  private TypeEnum _type;

  protected internal override System.Type[] GetAcceptableFieldToValidateTypes()
  {
    return new System.Type[5]
    {
      typeof (string),
      typeof (int),
      typeof (double),
      typeof (DateTime),
      typeof (Decimal)
    };
  }

  public CompareValidator(IContainer container)
    : base(container)
  {
    this._compareOperator = ValidationCompareOperator.Equal;
    this._type = TypeEnum.String;
  }

  public CompareValidator()
  {
    this._compareOperator = ValidationCompareOperator.Equal;
    this._type = TypeEnum.String;
  }

  [Category("Behavior")]
  [Description("Comparison operation to apply to values")]
  [DefaultValue(typeof (ValidationCompareOperator), "Equal")]
  public ValidationCompareOperator CompareOperator
  {
    get => this._compareOperator;
    set => this._compareOperator = value;
  }

  [Category("Behavior")]
  [Description("Control to validate against")]
  [DefaultValue(typeof (ValidationCompareOperator), "Equal")]
  public Control ControlToValidateAgainst
  {
    get => this._controlToValidateAgainst;
    set => this._controlToValidateAgainst = value;
  }

  [Category("Behavior")]
  [Description("Comparison type to apply to values")]
  [DefaultValue(typeof (TypeEnum), "String")]
  public TypeEnum Type
  {
    get => this._type;
    set => this._type = value;
  }

  private bool ComparisonIsValid(object objToCompare, object objValueToCompareAgainst)
  {
    bool flag;
    switch (this._compareOperator)
    {
      case ValidationCompareOperator.Equal:
        switch (this._type)
        {
          case TypeEnum.String:
            flag = Operators.CompareString(Conversions.ToString(objToCompare), Conversions.ToString(objValueToCompareAgainst), false) == 0;
            break;
          case TypeEnum.Date:
            flag = DateTime.Compare(Conversions.ToDate(objToCompare), Conversions.ToDate(objValueToCompareAgainst)) == 0;
            break;
          default:
            flag = Decimal.Compare(Conversions.ToDecimal(objToCompare), Conversions.ToDecimal(objValueToCompareAgainst)) == 0;
            break;
        }
        break;
      case ValidationCompareOperator.NotEqual:
        switch (this._type)
        {
          case TypeEnum.String:
            flag = Operators.CompareString(Conversions.ToString(objToCompare), Conversions.ToString(objValueToCompareAgainst), false) != 0;
            break;
          case TypeEnum.Date:
            flag = DateTime.Compare(Conversions.ToDate(objToCompare), Conversions.ToDate(objValueToCompareAgainst)) != 0;
            break;
          default:
            flag = Decimal.Compare(Conversions.ToDecimal(objToCompare), Conversions.ToDecimal(objValueToCompareAgainst)) != 0;
            break;
        }
        break;
      case ValidationCompareOperator.GreaterThan:
        switch (this._type)
        {
          case TypeEnum.String:
            flag = Operators.CompareString(Conversions.ToString(objToCompare), Conversions.ToString(objValueToCompareAgainst), false) > 0;
            break;
          case TypeEnum.Date:
            flag = DateTime.Compare(Conversions.ToDate(objToCompare), Conversions.ToDate(objValueToCompareAgainst)) > 0;
            break;
          default:
            flag = Decimal.Compare(Conversions.ToDecimal(objToCompare), Conversions.ToDecimal(objValueToCompareAgainst)) > 0;
            break;
        }
        break;
      case ValidationCompareOperator.GreaterThanEqual:
        switch (this._type)
        {
          case TypeEnum.String:
            flag = Operators.CompareString(Conversions.ToString(objToCompare), Conversions.ToString(objValueToCompareAgainst), false) >= 0;
            break;
          case TypeEnum.Date:
            flag = DateTime.Compare(Conversions.ToDate(objToCompare), Conversions.ToDate(objValueToCompareAgainst)) >= 0;
            break;
          default:
            flag = Decimal.Compare(Conversions.ToDecimal(objToCompare), Conversions.ToDecimal(objValueToCompareAgainst)) >= 0;
            break;
        }
        break;
      case ValidationCompareOperator.LessThan:
        switch (this._type)
        {
          case TypeEnum.String:
            flag = Operators.CompareString(Conversions.ToString(objToCompare), Conversions.ToString(objValueToCompareAgainst), false) < 0;
            break;
          case TypeEnum.Date:
            flag = DateTime.Compare(Conversions.ToDate(objToCompare), Conversions.ToDate(objValueToCompareAgainst)) < 0;
            break;
          default:
            flag = Decimal.Compare(Conversions.ToDecimal(objToCompare), Conversions.ToDecimal(objValueToCompareAgainst)) < 0;
            break;
        }
        break;
      case ValidationCompareOperator.LessThanEqual:
        switch (this._type)
        {
          case TypeEnum.String:
            flag = Operators.CompareString(Conversions.ToString(objToCompare), Conversions.ToString(objValueToCompareAgainst), false) <= 0;
            break;
          case TypeEnum.Date:
            flag = DateTime.Compare(Conversions.ToDate(objToCompare), Conversions.ToDate(objValueToCompareAgainst)) <= 0;
            break;
          default:
            flag = Decimal.Compare(Conversions.ToDecimal(objToCompare), Conversions.ToDecimal(objValueToCompareAgainst)) <= 0;
            break;
        }
        break;
      case ValidationCompareOperator.DataTypeCheck:
        throw new ValidationException("DataTypeCheck comparison Not supported");
    }
    return flag;
  }

  protected override bool EvaluateIsValid()
  {
    bool isValid;
    if (this._controlToValidateAgainst == null)
    {
      isValid = false;
    }
    else
    {
      PropertyInfo property = this._controlToValidateAgainst.GetType().GetProperty(this.FieldToValidate);
      if ((object) property == null)
      {
        isValid = false;
      }
      else
      {
        object objectValue = RuntimeHelpers.GetObjectValue(property.GetValue((object) this._controlToValidateAgainst, (object[]) null));
        isValid = objectValue != null && this.ComparisonIsValid(RuntimeHelpers.GetObjectValue(this.ValueToTest), RuntimeHelpers.GetObjectValue(objectValue));
      }
    }
    return isValid;
  }
}

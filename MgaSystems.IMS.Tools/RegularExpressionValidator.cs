// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.RegularExpressionValidator
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Design;
using System.Text.RegularExpressions;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (System.Web.UI.WebControls.RegularExpressionValidator))]
public sealed class RegularExpressionValidator : ValidatorBase
{
  private string _validationExpression;

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

  public RegularExpressionValidator(IContainer container)
    : base(container)
  {
    this._validationExpression = "";
  }

  public RegularExpressionValidator() => this._validationExpression = "";

  [DefaultValue("")]
  [Description("Regular expression to determine validity")]
  [Editor("System.Web.UI.Design.WebControls.RegexTypeEditor,System.Design", typeof (UITypeEditor))]
  [Category("Behavior")]
  public string ValidationExpression
  {
    get => this._validationExpression;
    set => this._validationExpression = value;
  }

  [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
  protected override bool EvaluateIsValid()
  {
    string input = this.ValueToTest.ToString();
    bool isValid;
    if (input != null)
    {
      if (input.Trim().Length != 0)
      {
        bool flag;
        try
        {
          Match match = Regex.Match(input, this.ValidationExpression);
          flag = match.Success && match.Index == 0 && match.Length == input.Length;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          flag = true;
          ProjectData.ClearProjectError();
        }
        isValid = flag;
        goto label_6;
      }
    }
    isValid = true;
label_6:
    return isValid;
  }
}

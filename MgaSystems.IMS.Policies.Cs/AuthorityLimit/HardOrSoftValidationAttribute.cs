// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.AuthorityLimit.HardOrSoftValidationAttribute
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System.ComponentModel.DataAnnotations;
using System.Reflection;

#nullable disable
namespace MgaSystems.IMS.Policies.AuthorityLimit;

public class HardOrSoftValidationAttribute : ValidationAttribute
{
  private readonly string softProperty;

  public HardOrSoftValidationAttribute(string softProp, string errMsg)
  {
    this.softProperty = softProp;
    this.ErrorMessage = errMsg;
  }

  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
  {
    if (validationContext.ObjectType.GetProperty(this.softProperty) == (PropertyInfo) null)
      return new ValidationResult($"Unknown property: {this.softProperty}");
    PropertyInfo property = validationContext.ObjectInstance.GetType().GetProperty(this.softProperty);
    return property != (PropertyInfo) null && property.GetValue(validationContext.ObjectInstance, (object[]) null) is bool flag1 && flag1 && value is bool flag2 && flag2 ? new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName)) : (ValidationResult) null;
  }
}

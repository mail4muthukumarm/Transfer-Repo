// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.AuthorityLimit.DatabaseFieldAttribute
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System.ComponentModel.DataAnnotations;
using System.Reflection;

#nullable disable
namespace MgaSystems.IMS.Policies.AuthorityLimit;

public class DatabaseFieldAttribute : ValidationAttribute
{
  private readonly string hasValueSetProperty;

  public DatabaseFieldAttribute(string hasValueSetProp)
  {
    this.hasValueSetProperty = hasValueSetProp;
    this.ErrorMessage = "Field must be chosen if value is set for Min/Max or Approval Min/Max";
  }

  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
  {
    if (validationContext.ObjectType.GetProperty(this.hasValueSetProperty) == (PropertyInfo) null)
      return new ValidationResult($"Unknown property: {this.hasValueSetProperty}");
    PropertyInfo property = validationContext.ObjectInstance.GetType().GetProperty(this.hasValueSetProperty);
    return property != (PropertyInfo) null && property.GetValue(validationContext.ObjectInstance, (object[]) null) is bool flag && flag && (value == null || string.IsNullOrEmpty(value.ToString())) ? new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName)) : (ValidationResult) null;
  }
}

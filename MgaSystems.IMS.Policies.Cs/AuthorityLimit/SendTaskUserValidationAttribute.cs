// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.AuthorityLimit.SendTaskUserValidationAttribute
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MgaSystems.IMS.Policies.AuthorityLimit.Lib;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

#nullable disable
namespace MgaSystems.IMS.Policies.AuthorityLimit;

public class SendTaskUserValidationAttribute : ValidationAttribute
{
  private readonly string sendTaskBindRequiredProperty;
  private readonly string sendTaskQuoteRequiredProperty;

  public SendTaskUserValidationAttribute(
    string sendTaskBindRequiredProp,
    string sendTaskQuoteRequiredProp)
  {
    this.sendTaskBindRequiredProperty = sendTaskBindRequiredProp;
    this.sendTaskQuoteRequiredProperty = sendTaskQuoteRequiredProp;
    if (AuthorityLimitCheckManager.RunAuthorityCheckAtStartup)
      this.ErrorMessage = "Send Task User required if Send Task (Bind) or Send Task (Quote) checked";
    else
      this.ErrorMessage = "Send Task User required if Send Task checked";
  }

  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
  {
    PropertyInfo property1 = validationContext.ObjectType.GetProperty(this.sendTaskBindRequiredProperty);
    PropertyInfo property2 = validationContext.ObjectType.GetProperty(this.sendTaskQuoteRequiredProperty);
    if (property1 == (PropertyInfo) null)
      return new ValidationResult($"Unknown property: {this.sendTaskBindRequiredProperty}");
    if (property2 == (PropertyInfo) null)
      return new ValidationResult($"Unknown property: {this.sendTaskQuoteRequiredProperty}");
    Type type = validationContext.ObjectInstance.GetType();
    bool flag1 = false;
    PropertyInfo property3 = type.GetProperty(this.sendTaskBindRequiredProperty);
    if (property3 != (PropertyInfo) null && property3.GetValue(validationContext.ObjectInstance, (object[]) null) is bool flag2 && flag2 && value == null)
      flag1 = true;
    PropertyInfo property4 = type.GetProperty(this.sendTaskQuoteRequiredProperty);
    if (property4 != (PropertyInfo) null && property4.GetValue(validationContext.ObjectInstance, (object[]) null) is bool flag3 && flag3 && value == null)
      flag1 = true;
    return flag1 ? new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName)) : (ValidationResult) null;
  }
}

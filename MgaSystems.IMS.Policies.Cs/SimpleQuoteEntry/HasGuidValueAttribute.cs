// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.HasGuidValueAttribute
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System;
using System.ComponentModel.DataAnnotations;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public sealed class HasGuidValueAttribute : ValidationAttribute
{
  public override bool IsValid(object value)
  {
    bool flag = true;
    if ((Guid) value == Guid.Empty)
      flag = false;
    return flag;
  }
}

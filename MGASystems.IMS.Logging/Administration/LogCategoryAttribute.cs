// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Logging.Administration.LogCategoryAttribute
// Assembly: MGASystems.IMS.Logging, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DEDE5ABB-2A35-47E4-BD3C-0B33B15168EB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Logging.dll

using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Logging.Administration;

[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
public sealed class LogCategoryAttribute : Attribute
{
  public string Category { get; }

  public string CategoryCode { get; }

  public LogCategoryAttribute(string category, string categoryCode)
  {
    this.Category = category;
    this.CategoryCode = categoryCode;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public override bool Match(object obj) => obj is LogCategoryAttribute;
}

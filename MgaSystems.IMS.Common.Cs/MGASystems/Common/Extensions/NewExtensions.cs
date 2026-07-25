// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Extensions.NewExtensions
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

#nullable disable
namespace MGASystems.Common.Extensions;

public static class NewExtensions
{
  public static bool HasDefaultConstructor(this Type t)
  {
    return t.IsValueType || t.GetConstructor(Type.EmptyTypes) != (ConstructorInfo) null;
  }

  public static TObj CreateNewObject<TObj>(this DataRow dr) => NewObject<TObj>.FromDataRow(dr);

  public static TObj CreateMappedObject<TObj>(this DataRow dr) => NewObject<TObj>.FromMappedRow(dr);

  public static IEnumerable<TObj> CreateNewObjects<TObj>(this DataTable dt)
  {
    return NewObject<TObj>.FromDataTable(dt);
  }

  public static IEnumerable<TObj> CreateMappedObjects<TObj>(this DataTable dt)
  {
    return NewObject<TObj>.FromMappedTable(dt);
  }
}

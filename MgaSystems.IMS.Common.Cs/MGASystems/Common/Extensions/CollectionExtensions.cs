// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Extensions.CollectionExtensions
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

#nullable disable
namespace MGASystems.Common.Extensions;

public static class CollectionExtensions
{
  public static bool ValueIn<T>(this T value, params T[] checkValues)
  {
    return checkValues != null && ((IEnumerable<T>) checkValues).Contains<T>(value);
  }

  public static bool ValueIn<T>(this T value, IEnumerable<T> checkValues)
  {
    return checkValues != null && checkValues.Contains<T>(value);
  }

  public static bool ValueIn<T>(
    this T value,
    IEqualityComparer<T> comparer,
    params T[] checkValues)
  {
    return checkValues != null && ((IEnumerable<T>) checkValues).Contains<T>(value, comparer);
  }

  public static bool ValueIn<T>(
    this T value,
    IEqualityComparer<T> comparer,
    IEnumerable<T> checkValues)
  {
    return checkValues != null && checkValues.Contains<T>(value, comparer);
  }

  public static bool ValueInNoCase(this string value, params string[] checkValues)
  {
    return value.ValueIn<string>((IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase, checkValues);
  }

  public static bool ValueInNoCase(this string value, IEnumerable<string> checkValues)
  {
    return value.ValueIn<string>((IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase, checkValues);
  }

  public static IEnumerable<TOut> SelectWhere<TIn, TOut>(
    this IEnumerable<TIn> source,
    System.Func<TIn, TOut> selector,
    System.Func<TOut, bool> predicate)
  {
    return source.Select<TIn, TOut>(selector).Where<TOut>(predicate);
  }

  public static IEnumerable<TOut> WhereSelect<TIn, TOut>(
    this IEnumerable<TIn> source,
    System.Func<TIn, bool> predicate,
    System.Func<TIn, TOut> selector)
  {
    return source.Where<TIn>(predicate).Select<TIn, TOut>(selector);
  }

  public static IEnumerable<string> WhereNullOrEmpty(this IEnumerable<string> collection)
  {
    return collection.Where<string>(new System.Func<string, bool>(string.IsNullOrEmpty));
  }

  public static IEnumerable<string> WhereNullOrWhitespace(this IEnumerable<string> collection)
  {
    return collection.Where<string>(new System.Func<string, bool>(string.IsNullOrWhiteSpace));
  }

  public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> source, System.Func<T, bool> predicate)
  {
    if (predicate == null)
      throw new ArgumentNullException(nameof (predicate));
    return source.Where<T>((System.Func<T, bool>) (t => !predicate(t)));
  }

  public static IEnumerable<string> WhereNotNullOrEmpty(this IEnumerable<string> collection)
  {
    return collection.WhereNot<string>(new System.Func<string, bool>(string.IsNullOrEmpty));
  }

  public static IEnumerable<string> WhereNotNullOrWhitespace(this IEnumerable<string> collection)
  {
    return collection.WhereNot<string>(new System.Func<string, bool>(string.IsNullOrWhiteSpace));
  }

  public static IEnumerable<TSource[]> YieldChunk<TSource>(
    this IEnumerable<TSource> source,
    int size)
  {
    if (source == null)
      throw new ArgumentNullException(nameof (source));
    if (size < 1)
      throw new ArgumentOutOfRangeException(nameof (size));
    using (IEnumerator<TSource> e = source.GetEnumerator())
    {
      if (e.MoveNext())
      {
        int arraySize = Math.Min(size, 4);
        int i;
        do
        {
          TSource[] array = new TSource[arraySize];
          array[0] = e.Current;
          i = 1;
          if (size != array.Length)
          {
            for (; i < size && e.MoveNext(); ++i)
            {
              if (i >= array.Length)
              {
                arraySize = (int) Math.Min((uint) size, (uint) (2 * array.Length));
                Array.Resize<TSource>(ref array, arraySize);
              }
              array[i] = e.Current;
            }
          }
          else
          {
            for (TSource[] sourceArray = array; (uint) i < (uint) sourceArray.Length && e.MoveNext(); ++i)
              sourceArray[i] = e.Current;
          }
          if (i != array.Length)
            Array.Resize<TSource>(ref array, i);
          yield return array;
        }
        while (i >= size && e.MoveNext());
      }
    }
  }

  public static DataTable ToDataTable<T>(this IEnumerable<T> data)
  {
    PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof (T));
    DataTable table = CollectionExtensions.BuildTableFromAllPublicProperties(properties);
    CollectionExtensions.PopulateTable<T>(data, properties, table);
    return table;
  }

  private static void PopulateTable<T>(
    IEnumerable<T> data,
    PropertyDescriptorCollection props,
    DataTable table)
  {
    foreach (T obj in data)
      CollectionExtensions.PopulateRow<T>(props, table, obj);
  }

  private static void PopulateRow<T>(PropertyDescriptorCollection props, DataTable table, T item)
  {
    object[] objArray = new object[props.Count];
    for (int index = 0; index < objArray.Length; ++index)
      objArray[index] = props[index].GetValue((object) item);
    table.Rows.Add(objArray);
  }

  private static DataTable BuildTableFromAllPublicProperties(PropertyDescriptorCollection props)
  {
    DataTable dataTable = new DataTable();
    for (int index = 0; index < props.Count; ++index)
    {
      PropertyDescriptor prop = props[index];
      dataTable.Columns.Add(prop.Name, prop.PropertyType);
    }
    return dataTable;
  }
}

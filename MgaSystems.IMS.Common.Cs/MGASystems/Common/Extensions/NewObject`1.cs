// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Extensions.NewObject`1
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.ErrorHandling;
using MGASystems.Data.DataMapping;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.Common.Extensions;

public static class NewObject<T>
{
  public static readonly Func<T> Instance = NewObject<T>.Creator();
  private static readonly ConcurrentDictionary<Type[], System.Func<object[], T>> cachedDynamicConstructors = new ConcurrentDictionary<Type[], System.Func<object[], T>>();
  private static readonly Lazy<IReadOnlyDictionary<string, PropertyInfo>> propertyMappings = new Lazy<IReadOnlyDictionary<string, PropertyInfo>>((Func<IReadOnlyDictionary<string, PropertyInfo>>) (() => (IReadOnlyDictionary<string, PropertyInfo>) new ReadOnlyDictionary<string, PropertyInfo>((IDictionary<string, PropertyInfo>) ((IEnumerable<PropertyInfo>) typeof (T).GetProperties(BindingFlags.Instance | BindingFlags.Public)).ToDictionary<PropertyInfo, string>((System.Func<PropertyInfo, string>) (prop => prop.Name), (IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase))), true);
  private static readonly Lazy<IReadOnlyDictionary<string, string>> tableFieldMappings = new Lazy<IReadOnlyDictionary<string, string>>((Func<IReadOnlyDictionary<string, string>>) (() =>
  {
    Dictionary<string, string> dictionary = new Dictionary<string, string>((IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
    foreach (KeyValuePair<PropertyInfo, IEnumerable<TableFieldMappingAttribute>> keyValuePair in NewObject<T>.propertyMappings.Value.Values.ToDictionary<PropertyInfo, PropertyInfo, IEnumerable<TableFieldMappingAttribute>>((System.Func<PropertyInfo, PropertyInfo>) (tprop => tprop), (System.Func<PropertyInfo, IEnumerable<TableFieldMappingAttribute>>) (tprop => tprop.GetCustomAttributes<TableFieldMappingAttribute>(true))).Where<KeyValuePair<PropertyInfo, IEnumerable<TableFieldMappingAttribute>>>((System.Func<KeyValuePair<PropertyInfo, IEnumerable<TableFieldMappingAttribute>>, bool>) (group => group.Key.CanWrite)))
    {
      foreach (TableFieldMappingAttribute mappingAttribute in keyValuePair.Value.Where<TableFieldMappingAttribute>((System.Func<TableFieldMappingAttribute, bool>) (map => map.Mode != 1)))
        dictionary.Add(string.IsNullOrEmpty(mappingAttribute.FieldName) ? keyValuePair.Key.Name : mappingAttribute.FieldName, keyValuePair.Key.Name);
    }
    return (IReadOnlyDictionary<string, string>) new ReadOnlyDictionary<string, string>((IDictionary<string, string>) dictionary);
  }), true);

  private static Func<T> Creator()
  {
    Type t = typeof (T);
    Type type = ObjectFactory.Instance.GetDerivedType(t);
    if ((object) type == null)
      type = t;
    t = type;
    if (t == typeof (string))
      return ((Expression<Func<T>>) (() => string.Empty)).Compile();
    return t.HasDefaultConstructor() ? ((Expression<Func<T>>) (() => Expression.New(t))).Compile() : (Func<T>) (() => (T) FormatterServices.GetUninitializedObject(t));
  }

  public static T CreateUsing<T1>(T1 v1)
  {
    return NewObject<T>.CreateUsingInternal(new Type[1]
    {
      typeof (T1)
    }, (object) v1);
  }

  public static T CreateUsing<T1, T2>(T1 v1, T2 v2)
  {
    return NewObject<T>.CreateUsingInternal(new Type[2]
    {
      typeof (T1),
      typeof (T2)
    }, (object) v1, (object) v2);
  }

  public static T CreateUsing<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3)
  {
    return NewObject<T>.CreateUsingInternal(new Type[3]
    {
      typeof (T1),
      typeof (T2),
      typeof (T3)
    }, (object) arg1, (object) arg2, (object) arg3);
  }

  public static T CreateUsing<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  {
    return NewObject<T>.CreateUsingInternal(new Type[4]
    {
      typeof (T1),
      typeof (T2),
      typeof (T3),
      typeof (T4)
    }, (object) arg1, (object) arg2, (object) arg3, (object) arg4);
  }

  public static T CreateUsing<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  {
    return NewObject<T>.CreateUsingInternal(new Type[5]
    {
      typeof (T1),
      typeof (T2),
      typeof (T3),
      typeof (T4),
      typeof (T5)
    }, (object) arg1, (object) arg2, (object) arg3, (object) arg4, (object) arg5);
  }

  public static T CreateUsing<T1, T2, T3, T4, T5, T6>(
    T1 arg1,
    T2 arg2,
    T3 arg3,
    T4 arg4,
    T5 arg5,
    T6 arg6)
  {
    return NewObject<T>.CreateUsingInternal(new Type[6]
    {
      typeof (T1),
      typeof (T2),
      typeof (T3),
      typeof (T4),
      typeof (T5),
      typeof (T6)
    }, (object) arg1, (object) arg2, (object) arg3, (object) arg4, (object) arg5, (object) arg6);
  }

  public static T CreateUsing<T1, T2, T3, T4, T5, T6, T7>(
    T1 arg1,
    T2 arg2,
    T3 arg3,
    T4 arg4,
    T5 arg5,
    T6 arg6,
    T7 arg7)
  {
    return NewObject<T>.CreateUsingInternal(new Type[7]
    {
      typeof (T1),
      typeof (T2),
      typeof (T3),
      typeof (T4),
      typeof (T5),
      typeof (T6),
      typeof (T7)
    }, (object) arg1, (object) arg2, (object) arg3, (object) arg4, (object) arg5, (object) arg6, (object) arg7);
  }

  public static T CreateUsing<T1, T2, T3, T4, T5, T6, T7, T8>(
    T1 arg1,
    T2 arg2,
    T3 arg3,
    T4 arg4,
    T5 arg5,
    T6 arg6,
    T7 arg7,
    T8 arg8)
  {
    return NewObject<T>.CreateUsingInternal(new Type[8]
    {
      typeof (T1),
      typeof (T2),
      typeof (T3),
      typeof (T4),
      typeof (T5),
      typeof (T6),
      typeof (T7),
      typeof (T8)
    }, (object) arg1, (object) arg2, (object) arg3, (object) arg4, (object) arg5, (object) arg6, (object) arg7, (object) arg8);
  }

  private static T CreateUsingInternal(Type[] argumentTypes, params object[] argumentValues)
  {
    if (argumentTypes == null)
      throw new ArgumentNullException(nameof (argumentTypes));
    if (argumentValues == null)
      throw new ArgumentNullException(nameof (argumentValues));
    if (argumentValues.Length != argumentTypes.Length)
      throw new ArgumentOutOfRangeException(nameof (argumentValues), "Specified number of constructor values must match defined type argument length.");
    System.Func<object[], T> orAdd = NewObject<T>.cachedDynamicConstructors.GetOrAdd(argumentTypes, (System.Func<Type[], System.Func<object[], T>>) (targs =>
    {
      Type newType = typeof (T);
      ConstructorInfo constructor = newType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, targs, (ParameterModifier[]) null);
      if (constructor == (ConstructorInfo) null)
        return (System.Func<object[], T>) (v => (T) Activator.CreateInstance(newType, v));
      ParameterExpression inParam = Expression.Parameter(typeof (object[]), "inVals");
      List<UnaryExpression> list = ((IEnumerable<Type>) targs).Select<Type, UnaryExpression>((Func<Type, int, UnaryExpression>) ((ptype, pidx) => Expression.Convert((Expression) Expression.ArrayIndex((Expression) inParam, (Expression) Expression.Constant((object) pidx)), ptype))).ToList<UnaryExpression>();
      return Expression.Lambda<System.Func<object[], T>>((Expression) Expression.New(constructor, (IEnumerable<Expression>) list), inParam).Compile();
    }));
    return orAdd != null ? orAdd(argumentValues) : default (T);
  }

  public static T FromDataRow(DataRow dr)
  {
    return NewObject<T>.FromDataTable(dr?.Table).FirstOrDefault<T>();
  }

  public static T FromMappedRow(DataRow dr)
  {
    return NewObject<T>.FromMappedTable(dr?.Table).FirstOrDefault<T>();
  }

  public static IEnumerable<T> FromDataTable(DataTable dt)
  {
    return NewObject<T>.FromMappingSource(dt, (System.Func<DataColumn, bool>) (col => NewObject<T>.propertyMappings.Value.ContainsKey(col.ColumnName)), (System.Func<DataColumn, PropertyInfo>) (col => NewObject<T>.propertyMappings.Value[col.ColumnName]));
  }

  public static IEnumerable<T> FromMappedTable(DataTable dt)
  {
    return NewObject<T>.FromMappingSource(dt, (System.Func<DataColumn, bool>) (col => NewObject<T>.tableFieldMappings.Value.ContainsKey(col.ColumnName)), (System.Func<DataColumn, PropertyInfo>) (col => NewObject<T>.propertyMappings.Value[NewObject<T>.tableFieldMappings.Value[col.ColumnName]]));
  }

  private static IEnumerable<T> FromMappingSource(
    DataTable dt,
    System.Func<DataColumn, bool> findMapping,
    System.Func<DataColumn, PropertyInfo> selectProperty)
  {
    if (dt != null && dt.AsEnumerable().Any<DataRow>())
    {
      List<(DataColumn, PropertyInfo)> foundProps = dt.Columns.OfType<DataColumn>().WhereSelect<DataColumn, (DataColumn, PropertyInfo)>(findMapping, (System.Func<DataColumn, (DataColumn, PropertyInfo)>) (col => (col, selectProperty(col)))).ToList<(DataColumn, PropertyInfo)>();
      foreach (DataRow row in (InternalDataCollectionBase) dt.Rows)
      {
        T obj = NewObject<T>.Instance();
        foreach ((DataColumn column, PropertyInfo propertyInfo) in foundProps)
        {
          if (!row.IsNull(column))
          {
            try
            {
              propertyInfo.SetValue((object) obj, NewObject<T>.TryConvert(row[column], column.DataType, propertyInfo.PropertyType));
            }
            catch (Exception ex)
            {
              ex.Data.Add((object) "Column", (object) column.ColumnName);
              ex.Data.Add((object) "Property", (object) propertyInfo.Name);
              ErrorHandler.SilentLogError(ex);
            }
          }
        }
        yield return obj;
      }
    }
  }

  private static object TryConvert(object changeObj, Type fromType, Type toType)
  {
    Type type1 = Nullable.GetUnderlyingType(fromType);
    if ((object) type1 == null)
      type1 = fromType;
    Type sourceType = type1;
    Type type2 = Nullable.GetUnderlyingType(toType);
    if ((object) type2 == null)
      type2 = toType;
    Type type3 = type2;
    if (changeObj == null || sourceType == type3)
      return changeObj;
    TypeConverter converter = TypeDescriptor.GetConverter(type3);
    if (converter.CanConvertFrom(sourceType))
      return converter.ConvertFrom(changeObj);
    try
    {
      return Convert.ChangeType(changeObj, type3);
    }
    catch (Exception ex)
    {
      throw new InvalidCastException($"Unable to convert {changeObj} from {fromType.Name} to {type3.Name}", ex);
    }
  }
}

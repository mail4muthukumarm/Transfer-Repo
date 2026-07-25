// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Data.CommonMappedObject`1
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using MGASystems.Data.QueryBuilder;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

#nullable disable
namespace MGASystems.Common.Data;

public abstract class CommonMappedObject<TSelf> : MappedObject<TSelf> where TSelf : CommonMappedObject<TSelf>
{
  public bool HasValues(params string[] columns)
  {
    return ((IEnumerable<string>) columns).All<string>(new System.Func<string, bool>(((MappedObject<TSelf>) this).HasValue));
  }

  protected override void HandleRefreshError(Exception ex) => base.SilentHandleError(ex);

  protected override void SilentHandleError(Exception ex)
  {
    ex.Data[(object) "ObjectType"] = (object) ((object) this).GetType().FullName;
    ErrorHandler.SilentHandleError(ex);
  }

  protected virtual void HandleError(Exception ex)
  {
    ex.Data[(object) "ObjectType"] = (object) ((object) this).GetType().FullName;
    ErrorHandler.HandleError(ex);
  }

  public static List<TIn> SelectMany<TIn>(string whereClause, params object[] keys) where TIn : TSelf
  {
    return CommonMappedObject<TSelf>.SelectManyAndSet<TIn>(whereClause, (Action<TIn>) null, keys);
  }

  public static List<TSelf> SelectMany(string whereClause, params object[] keys)
  {
    return CommonMappedObject<TSelf>.SelectManyAndSet<TSelf>(whereClause, (Action<TSelf>) null, keys);
  }

  public static List<TSelf> SelectManyAndSet(
    string whereClause,
    Action<TSelf> setAction,
    params object[] keys)
  {
    return CommonMappedObject<TSelf>.SelectManyAndSet<TSelf>(whereClause, setAction, keys);
  }

  public static List<TIn> SelectManyAndSet<TIn>(
    string whereClause,
    Action<TIn> setAction,
    params object[] keys)
    where TIn : TSelf
  {
    if (keys == null || keys.Length == 0)
      return new List<TIn>();
    (Type type, MappingCacheEntry mappingCacheEntry) = CommonMappedObject<TSelf>.ResolveOrInitializeCacheEntry(typeof (TIn));
    if (type == (Type) null || mappingCacheEntry == null)
      return (List<TIn>) null;
    List<TIn> inList = new List<TIn>();
    try
    {
      SqlQuery sqlQuery = mappingCacheEntry.SqlBuilder.ClearConditions();
      if (sqlQuery.ParsePredicates(whereClause) == 0)
        return inList;
      Dictionary<string, PropertyInfo> keyRows = mappingCacheEntry.KeyPropertyMappings(type);
      DataTable source = DefaultDatabase.ExecuteDataTable(CommandType.Text, sqlQuery.Compile(), keys);
      if (source != null)
        inList.AddRange((IEnumerable<TIn>) source.AsEnumerable().Select<DataRow, TIn>((System.Func<DataRow, TIn>) (dr =>
        {
          TIn @in = NewObject<TIn>.Instance();
          DataTable dataTable = dr.Table.Clone();
          @in.ObjectDataStore = dataTable.Rows.Add(dr.ItemArray);
          List<object> objectList = new List<object>();
          foreach (KeyValuePair<string, PropertyInfo> keyValuePair in keyRows)
          {
            keyValuePair.Value.SetValue((object) @in, dr[keyValuePair.Key]);
            objectList.AddRange((IEnumerable<object>) new object[2]
            {
              (object) ("@" + keyValuePair.Key),
              dr[keyValuePair.Key]
            });
          }
          @in.SelectKeys = objectList.ToArray();
          Action<TIn> action = setAction;
          if (action != null)
            action(@in);
          return @in;
        })));
    }
    catch (Exception ex)
    {
      ex.Data.Add((object) "WhereClause", (object) whereClause);
      ex.Data.Add((object) "Parameters", (object) JsonConvert.SerializeObject((object) keys));
      ex.Data.Add((object) "ObjectType", (object) typeof (TIn).FullName);
      throw;
    }
    return inList;
  }

  public static List<TIn> SelectMultiple<TIn>(params object[] pkValues) where TIn : TSelf
  {
    return CommonMappedObject<TSelf>.SelectMultipleAndSet<TIn>((Action<TIn>) null, pkValues);
  }

  public static List<TSelf> SelectMultiple(params object[] pkValues)
  {
    return CommonMappedObject<TSelf>.SelectMultipleAndSet<TSelf>((Action<TSelf>) null, pkValues);
  }

  public static List<TSelf> SelectMultipleAndSet(Action<TSelf> setAction, params object[] pkValues)
  {
    return CommonMappedObject<TSelf>.SelectMultipleAndSet<TSelf>(setAction, pkValues);
  }

  public static List<TIn> SelectMultipleAndSet<TIn>(Action<TIn> setAction, params object[] pkValues) where TIn : TSelf
  {
    if (pkValues == null || pkValues.Length == 0)
      return new List<TIn>();
    if (pkValues != null && pkValues.Length == 1 && pkValues[0] is IEnumerable pkValue)
      return CommonMappedObject<TSelf>.SelectMultipleAndSet<TIn>(setAction, pkValue.Cast<object>().ToArray<object>());
    (Type type, MappingCacheEntry mappingCacheEntry) = CommonMappedObject<TSelf>.ResolveOrInitializeCacheEntry(typeof (TIn));
    if (type == (Type) null || mappingCacheEntry == null)
      return (List<TIn>) null;
    List<TIn> inList = new List<TIn>();
    try
    {
      KeyValuePair<string, PropertyInfo> keyValuePair = mappingCacheEntry.KeyPropertyMappings(type).SingleOrDefault<KeyValuePair<string, PropertyInfo>>();
      string key = keyValuePair.Key;
      PropertyInfo keyProperty = keyValuePair.Value;
      string keyColumnName = key;
      string str1 = mappingCacheEntry.SqlBuilder.ClearConditions().AddCompareCondition(keyColumnName).Compile().Replace("= @" + keyColumnName, "IN ");
      List<object> objectList = new List<object>();
      string str2;
      if (pkValues.Length <= 30)
      {
        Dictionary<string, object> dictionary = ((IEnumerable<object>) pkValues).Select<object, (string, object)>((Func<object, int, (string, object)>) ((pk, idx) => ($"@PK{idx}", pk))).ToDictionary<(string, object), string, object>((System.Func<(string, object), string>) (tpk => tpk.ParamName), (System.Func<(string, object), object>) (tpk => tpk.ParamValue));
        str2 = $"{str1}({string.Join(",", (IEnumerable<string>) dictionary.Keys)})";
        objectList.AddRange(dictionary.SelectMany<KeyValuePair<string, object>, object>((System.Func<KeyValuePair<string, object>, IEnumerable<object>>) (kvp => (IEnumerable<object>) new object[2]
        {
          (object) kvp.Key,
          kvp.Value
        })));
      }
      else
      {
        str2 = str1 + "(SELECT value FROM STRING_SPLIT(@valuesSeparated, @separater))";
        objectList.AddRange((IEnumerable<object>) new object[4]
        {
          (object) "@valuesSeparated",
          (object) string.Join("|", pkValues),
          (object) "@separater",
          (object) "|"
        });
      }
      DataTable selectedData = DefaultDatabase.ExecuteDataTable(CommandType.Text, str2, objectList.ToArray());
      if (selectedData != null)
        inList.AddRange((IEnumerable<TIn>) selectedData.AsEnumerable().Select<DataRow, TIn>((System.Func<DataRow, TIn>) (dr =>
        {
          TIn @in = NewObject<TIn>.Instance();
          DataTable dataTable = selectedData.Clone();
          @in.ObjectDataStore = dataTable.Rows.Add(dr.ItemArray);
          keyProperty.SetValue((object) @in, dr[keyColumnName]);
          @in.SelectKeys = new object[2]
          {
            (object) ("@" + keyColumnName),
            dr[keyColumnName]
          };
          Action<TIn> action = setAction;
          if (action != null)
            action(@in);
          return @in;
        })));
    }
    catch (Exception ex)
    {
      ex.Data.Add((object) "ObjectType", (object) typeof (TIn).FullName);
      throw;
    }
    return inList;
  }

  private static (Type, MappingCacheEntry) ResolveOrInitializeCacheEntry(Type selectType)
  {
    MappingCacheEntry typeCache = MappedObject<TSelf>.FindTypeCache(selectType);
    if (typeCache == null)
    {
      try
      {
        TSelf self = NewObject<TSelf>.Instance();
        selectType = ((object) self).GetType();
        self.AllowMissingRecord = true;
        self.RefreshData();
      }
      catch (Exception ex)
      {
        ex.Data.Add((object) "Type", (object) selectType);
        ErrorHandler.SilentLogError(ex);
      }
      typeCache = MappedObject<TSelf>.FindTypeCache(selectType);
      if (string.IsNullOrEmpty(typeCache?.SelectQuery))
        return ((Type) null, (MappingCacheEntry) null);
    }
    return (selectType, typeCache);
  }
}

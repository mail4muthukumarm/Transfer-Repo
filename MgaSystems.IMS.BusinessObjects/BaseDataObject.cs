// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.BaseDataObject
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects;

public abstract class BaseDataObject
{
  protected DataRow ObjectDataStore;
  protected static ConcurrentDictionary<Type, string> ObjectSelectionCache = new ConcurrentDictionary<Type, string>();
  private static readonly ConcurrentDictionary<Type, DataTable> ColumnPropertyCache = new ConcurrentDictionary<Type, DataTable>();
  protected object[] SelectKeys;

  protected BaseDataObject()
  {
    this.SelectKeys = (object[]) null;
    this.AllowMissingRecord = false;
  }

  public virtual bool AllowMissingRecord { get; set; }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Discarding returns when loading and adding to underlying stores.")]
  public bool RefreshData()
  {
    bool refreshed;
    try
    {
      string str1 = (string) null;
      Type type = this.GetType();
      DataTable source1 = (DataTable) null;
      if (!BaseDataObject.ObjectSelectionCache.TryGetValue(type, out str1))
      {
        for (Type baseType = type.BaseType; !baseType.Equals(typeof (BaseDataObject)); baseType = baseType.BaseType)
        {
          if (BaseDataObject.ColumnPropertyCache.TryGetValue(baseType, out source1))
          {
            source1 = source1.Copy();
            break;
          }
        }
        if (source1 == null)
        {
          source1 = new DataTable();
          source1.Columns.AddRange(new DataColumn[5]
          {
            new DataColumn("PropertyName", typeof (string)),
            new DataColumn("ColumnAlias", typeof (string)),
            new DataColumn("IsKey", typeof (bool)),
            new DataColumn("SelectorFunction", typeof (System.Func<BaseDataObject, object>)),
            new DataColumn("RetrieveLogic", typeof (string))
          });
          source1.PrimaryKey = new DataColumn[1]
          {
            source1.Columns[1]
          };
        }
        PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
        TableMappingAttribute customAttribute = type.GetCustomAttribute<TableMappingAttribute>(true);
        if (customAttribute == null || string.IsNullOrEmpty(customAttribute.TableName))
          throw new InvalidOperationException($"Type {type.FullName} missing TableMappingAttribute.");
        IEnumerable<DataColumn> source2 = DefaultDatabase.ExecuteDataTable(CommandType.Text, $"SELECT TOP(0) * FROM {customAttribute.TableName} WITH(NOLOCK)").Columns.OfType<DataColumn>();
        System.Func<DataColumn, string> keySelector;
        // ISSUE: reference to a compiler-generated field
        if (BaseDataObject._Closure\u0024__.\u0024I11\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          keySelector = BaseDataObject._Closure\u0024__.\u0024I11\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          BaseDataObject._Closure\u0024__.\u0024I11\u002D0 = keySelector = (System.Func<DataColumn, string>) ([SpecialName] (dc) => dc.ColumnName);
        }
        StringComparer cultureIgnoreCase = StringComparer.InvariantCultureIgnoreCase;
        Dictionary<string, DataColumn> dictionary = source2.ToDictionary<DataColumn, string>(keySelector, (IEqualityComparer<string>) cultureIgnoreCase);
        PropertyInfo[] propertyInfoArray = properties;
        int index = 0;
        while (index < propertyInfoArray.Length)
        {
          PropertyInfo propertyInfo = propertyInfoArray[index];
          Attribute[] array = propertyInfo.GetCustomAttributes<Attribute>(true).ToArray<Attribute>();
          DataKeyAttribute dataKeyAttribute = array.OfType<DataKeyAttribute>().FirstOrDefault<DataKeyAttribute>();
          TableFieldMappingAttribute mappingAttribute = array.OfType<TableFieldMappingAttribute>().FirstOrDefault<TableFieldMappingAttribute>();
          if (mappingAttribute != null || dataKeyAttribute != null)
          {
            System.Func<BaseDataObject, object> func = (System.Func<BaseDataObject, object>) null;
            string key = propertyInfo.Name;
            string str2 = (string) null;
            if (mappingAttribute != null)
            {
              if (!string.IsNullOrEmpty(mappingAttribute.FieldName))
              {
                key = mappingAttribute.FieldName.Trim();
                if (key.Contains(" "))
                {
                  string[] source3 = key.Split(new string[1]
                  {
                    " "
                  }, StringSplitOptions.RemoveEmptyEntries);
                  str2 = string.Join(" ", ((IEnumerable<string>) source3).Take<string>(source3.Length - 1));
                  key = source3[source3.Length - 1];
                }
                else if (!dictionary.ContainsKey(key))
                  str2 = "CAST(NULL AS SQL_VARIANT)";
              }
              else if (!dictionary.ContainsKey(key))
                str2 = "CAST(NULL AS SQL_VARIANT)";
            }
            if (source1.Rows.Find((object) key) == null)
            {
              if (dataKeyAttribute != null)
              {
                ParameterExpression parameterExpression;
                func = Expression.Lambda<System.Func<BaseDataObject, object>>((Expression) Expression.TypeAs((Expression) Expression.Property((Expression) Expression.TypeAs((Expression) parameterExpression, propertyInfo.DeclaringType), propertyInfo), typeof (object)), parameterExpression).Compile();
              }
              source1.Rows.Add((object) propertyInfo.Name, (object) key, (object) (dataKeyAttribute != null), (object) func, (object) str2);
            }
          }
          checked { ++index; }
        }
        if (source1.Rows.Count == 0)
          throw this.BaseDataObjectException($"Type {type.FullName} missing data annotations.");
        source1.AcceptChanges();
        BaseDataObject.ColumnPropertyCache.TryAdd(type, source1);
        EnumerableRowCollection<DataRow> source4 = source1.AsEnumerable();
        System.Func<DataRow, string> selector1;
        // ISSUE: reference to a compiler-generated field
        if (BaseDataObject._Closure\u0024__.\u0024I11\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector1 = BaseDataObject._Closure\u0024__.\u0024I11\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          BaseDataObject._Closure\u0024__.\u0024I11\u002D1 = selector1 = (System.Func<DataRow, string>) ([SpecialName] (dr) => $"{dr.Field<string>(4)} {dr.Field<string>(1)}".Trim());
        }
        string str3 = string.Join(", ", (IEnumerable<string>) source4.Select<DataRow, string>(selector1));
        EnumerableRowCollection<DataRow> source5 = source1.AsEnumerable();
        System.Func<DataRow, bool> predicate;
        // ISSUE: reference to a compiler-generated field
        if (BaseDataObject._Closure\u0024__.\u0024I11\u002D2 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate = BaseDataObject._Closure\u0024__.\u0024I11\u002D2;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          BaseDataObject._Closure\u0024__.\u0024I11\u002D2 = predicate = (System.Func<DataRow, bool>) ([SpecialName] (dr) => dr.Field<bool>(2));
        }
        EnumerableRowCollection<DataRow> source6 = source5.Where<DataRow>(predicate);
        System.Func<DataRow, string> selector2;
        // ISSUE: reference to a compiler-generated field
        if (BaseDataObject._Closure\u0024__.\u0024I11\u002D3 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector2 = BaseDataObject._Closure\u0024__.\u0024I11\u002D3;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          BaseDataObject._Closure\u0024__.\u0024I11\u002D3 = selector2 = (System.Func<DataRow, string>) ([SpecialName] (dr) => string.Format("{0} = @{0}", (object) dr.Field<string>(1)));
        }
        string str4 = string.Join(" AND ", (IEnumerable<string>) source6.Select<DataRow, string>(selector2));
        string format = $"SELECT {{0}} FROM {customAttribute.TableName} WITH(NOLOCK) WHERE {str4}";
        str1 = string.Format(format, (object) str3);
        source1.TableName = format;
        BaseDataObject.ObjectSelectionCache.TryAdd(type, str1);
      }
      if (source1 == null && !BaseDataObject.ColumnPropertyCache.TryGetValue(type, out source1))
        throw new InvalidOperationException($"Missing data mappings For {type.FullName} after parsing type.");
      if (this.SelectKeys == null)
        this.SelectKeys = ((IEnumerable<DataRow>) source1.Select($"{"IsKey"} = 1")).SelectMany<DataRow, object>((System.Func<DataRow, IEnumerable<object>>) ([SpecialName] (dr) => (IEnumerable<object>) new object[2]
        {
          (object) $"@{dr.Field<string>(1)}",
          dr.Field<System.Func<BaseDataObject, object>>(3)(this)
        })).ToArray<object>();
      this.ObjectDataStore = DefaultDatabase.ExecuteDataRow(CommandType.Text, str1, this.SelectKeys);
      if (((IEnumerable<DataRow>) source1.Select($"{"IsKey"} = 1")).Where<DataRow>((System.Func<DataRow, bool>) ([SpecialName] (dr) => this.ObjectDataStore.IsNull(dr.Field<string>(1)))).ToArray<DataRow>().Length > 0)
        throw new InvalidOperationException($"{type.Name}: Key of returned record is null ({string.Join(", ", this.SelectKeys).Replace("@", string.Empty)})");
      refreshed = true;
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      if (!this.AllowMissingRecord)
      {
        ErrorHandler.SilentHandleError(ex2);
        this.ObjectDataStore = (DataRow) null;
        refreshed = false;
        ProjectData.ClearProjectError();
      }
      else
      {
        refreshed = true;
        ProjectData.ClearProjectError();
      }
    }
    finally
    {
      this.OnDataRefresh(refreshed);
    }
    return refreshed;
  }

  protected T GetField<T>(string columnName, [CallerMemberName] string propName = "GetField")
  {
    if (this.ObjectDataStore == null && !this.RefreshData())
      throw this.BaseDataObjectException($"Specified {this.GetType().Name} does not exist");
    try
    {
      return this.ObjectDataStore.Field<T>(columnName);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception innerException = ex;
      throw new InvalidOperationException($"{this.GetType().Name}.{propName}: {innerException.Message}", innerException);
    }
  }

  protected T GetFieldAs<T>(string columnName, [CallerMemberName] string propName = "GetFieldAs")
  {
    if (this.ObjectDataStore == null && !this.RefreshData())
      throw this.BaseDataObjectException($"Specified {this.GetType().Name} does not exist");
    try
    {
      return ExtensionsMethods.FieldAs<T>(this.ObjectDataStore, columnName, DataRowVersion.Current);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception innerException = ex;
      throw new InvalidOperationException($"{this.GetType().Name}.{propName}: {innerException.Message}", innerException);
    }
  }

  [SuppressMessage("Style", "IDE0004:Remove Unnecessary Cast", Justification = "Casting to explicitly state we're getting default(T).")]
  protected T GetUncachedField<T>(string columnName)
  {
    if (this.ObjectDataStore == null && !this.RefreshData())
      throw this.BaseDataObjectException($"Specified {this.GetType().Name} does not exist");
    DataTable dataTable = (DataTable) null;
    return !BaseDataObject.ColumnPropertyCache.TryGetValue(this.GetType(), out dataTable) ? default (T) : DefaultDatabase.ExecuteScalar<T>(CommandType.Text, string.Format(dataTable.TableName, (object) columnName), this.SelectKeys);
  }

  protected T GetLazyField<T>(string columnAlias, string selectText = null)
  {
    if (this.ObjectDataStore == null && !this.RefreshData())
      throw this.BaseDataObjectException($"Specified {this.GetType().Name} does not exist");
    T lazyField;
    if (this.HasValue(columnAlias))
    {
      lazyField = this.ObjectDataStore.Field<T>(columnAlias);
    }
    else
    {
      T uncachedField = this.GetUncachedField<T>(string.Join(" ", selectText, columnAlias).Trim());
      lazyField = this.TryAddValue<T>(columnAlias, uncachedField);
    }
    return lazyField;
  }

  protected bool RetrieveFields(params string[] columns)
  {
    return this.InternalRetrieveFields(columns, false);
  }

  protected bool RefreshFields(params string[] columns)
  {
    return this.InternalRetrieveFields(columns, true);
  }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Disregard rowcount returned by query.")]
  private bool InternalRetrieveFields(string[] colList, bool forceRefresh)
  {
    // ISSUE: variable of a compiler-generated type
    BaseDataObject._Closure\u0024__18\u002D0 closure180_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    BaseDataObject._Closure\u0024__18\u002D0 closure180_2 = new BaseDataObject._Closure\u0024__18\u002D0(closure180_1);
    // ISSUE: reference to a compiler-generated field
    closure180_2.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure180_2.\u0024VB\u0024Local_forceRefresh = forceRefresh;
    if (this.ObjectDataStore == null && !this.RefreshData())
      throw this.BaseDataObjectException($"Specified {this.GetType().Name} does not exist");
    // ISSUE: reference to a compiler-generated method
    IEnumerable<string> strings = ((IEnumerable<string>) colList).Where<string>(new System.Func<string, bool>(closure180_2._Lambda\u0024__0));
    bool flag;
    if (strings.Count<string>() == 0)
    {
      flag = true;
    }
    else
    {
      DataTable dataTable = (DataTable) null;
      if (BaseDataObject.ColumnPropertyCache.TryGetValue(this.GetType(), out dataTable))
      {
        try
        {
          DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, string.Format(dataTable.TableName, (object) string.Join(", ", strings)), this.SelectKeys);
          lock ((object) this.ObjectDataStore)
          {
            try
            {
              foreach (DataColumn column in (InternalDataCollectionBase) dataRow.Table.Columns)
              {
                if (!this.HasValue(column.ColumnName))
                  this.ObjectDataStore.Table.Columns.Add(column.ColumnName, column.DataType);
                this.ObjectDataStore[column.ColumnName] = RuntimeHelpers.GetObjectValue(dataRow[column]);
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
          }
          // ISSUE: reference to a compiler-generated field
          closure180_2.\u0024VB\u0024Local_forceRefresh = false;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ErrorHandler.SilentHandleError(ex);
          ProjectData.ClearProjectError();
        }
      }
      flag = strings.Count<string>() == 0;
    }
    return flag;
  }

  [SuppressMessage("Style", "IDE0031:Use null propagation", Justification = "Cannot use null propagation since we store object type in the underlying row. T might not be a nullable type.")]
  protected T CacheManualValue<T>(string columnAlias, Func<T> valueSelector = null)
  {
    if (this.ObjectDataStore == null && !this.RefreshData())
      throw this.BaseDataObjectException($"Specified {this.GetType().Name} does not exist");
    T obj;
    if (this.HasValue(columnAlias))
    {
      obj = this.GetField<T>(columnAlias, nameof (CacheManualValue));
    }
    else
    {
      T val = valueSelector == null ? default (T) : valueSelector();
      obj = this.TryAddValue<T>(columnAlias, val);
    }
    return obj;
  }

  protected T TryAddValue<T>(string columnName, T val)
  {
    lock ((object) this.ObjectDataStore)
    {
      if (!this.HasValue(columnName))
      {
        DataColumnCollection columns = this.ObjectDataStore.Table.Columns;
        string columnName1 = columnName;
        Type type = Nullable.GetUnderlyingType(typeof (T));
        if ((object) type == null)
          type = typeof (T);
        columns.Add(columnName1, type);
      }
      this.ObjectDataStore.SetField<T>(columnName, val);
    }
    return val;
  }

  protected void ClearValues(params string[] columnAliases)
  {
    if (this.ObjectDataStore == null || columnAliases == null || columnAliases.Length == 0)
      return;
    DataTable dataTable = (DataTable) null;
    if (!BaseDataObject.ColumnPropertyCache.TryGetValue(this.GetType(), out dataTable))
      return;
    string[] strArray = columnAliases;
    int index = 0;
    while (index < strArray.Length)
    {
      string str = strArray[index];
      if (dataTable.Rows.Find((object) str) == null && this.ObjectDataStore.Table.Columns.Contains(str))
        this.ObjectDataStore.Table.Columns.Remove(str);
      checked { ++index; }
    }
  }

  protected bool HasValue(string colName)
  {
    DataRow objectDataStore = this.ObjectDataStore;
    if (objectDataStore == null)
      return false;
    DataTable table = objectDataStore.Table;
    if (table == null)
      return false;
    DataColumnCollection columns = table.Columns;
    return columns != null && columns.Contains(colName);
  }

  public bool RecordExists()
  {
    bool flag;
    if (this.ObjectDataStore == null)
    {
      DataTable dataTable = (DataTable) null;
      if (BaseDataObject.ColumnPropertyCache.TryGetValue(this.GetType(), out dataTable))
      {
        object[] array = ((IEnumerable<DataRow>) dataTable.Select($"{"IsKey"} = 1")).SelectMany<DataRow, object>((System.Func<DataRow, IEnumerable<object>>) ([SpecialName] (dr) =>
        {
          object[] objArray = new object[2]
          {
            (object) $"@{dr.Field<string>(1)}",
            null
          };
          System.Func<BaseDataObject, object> func = dr.Field<System.Func<BaseDataObject, object>>(3);
          objArray[1] = func != null ? func(this) : (object) null;
          return (IEnumerable<object>) objArray;
        })).ToArray<object>();
        flag = array == null ? this.RefreshData() : DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, string.Format(dataTable.TableName, (object) "1"), array).HasValue;
      }
      else
        flag = this.RefreshData();
    }
    else
      flag = this.GetUncachedField<int?>("1").HasValue;
    return flag;
  }

  protected virtual Exception BaseDataObjectException(string errorMessage)
  {
    return (Exception) new InvalidOperationException(errorMessage);
  }

  protected virtual void OnDataRefresh(bool refreshed)
  {
  }

  public static List<T> SelectMany<T>(string whereClause, params object[] keys) where T : BaseDataObject
  {
    return BaseDataObject.SelectManyAndSet<T>(whereClause, (Action<T>) null, keys);
  }

  public static List<T> SelectManyAndSet<T>(
    string whereClause,
    Action<T> setAction,
    params object[] keys)
    where T : BaseDataObject
  {
    // ISSUE: variable of a compiler-generated type
    BaseDataObject._Closure\u0024__27\u002D0<T> closure270_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    BaseDataObject._Closure\u0024__27\u002D0<T> closure270_2 = new BaseDataObject._Closure\u0024__27\u002D0<T>(closure270_1);
    // ISSUE: reference to a compiler-generated field
    closure270_2.\u0024VB\u0024Local_setAction = setAction;
    string str1 = (string) null;
    // ISSUE: reference to a compiler-generated field
    closure270_2.\u0024VB\u0024Local_selectType = typeof (T);
    List<T> objList1;
    // ISSUE: reference to a compiler-generated field
    if (!BaseDataObject.ObjectSelectionCache.TryGetValue(closure270_2.\u0024VB\u0024Local_selectType, out str1))
    {
      try
      {
        T obj = NewObject<T>.Instance();
        // ISSUE: reference to a compiler-generated field
        closure270_2.\u0024VB\u0024Local_selectType = obj.GetType();
        obj.AllowMissingRecord = true;
        obj.RefreshData();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      // ISSUE: reference to a compiler-generated field
      if (!BaseDataObject.ObjectSelectionCache.TryGetValue(closure270_2.\u0024VB\u0024Local_selectType, out str1))
      {
        objList1 = (List<T>) null;
        goto label_13;
      }
    }
    List<T> objList2 = new List<T>();
    try
    {
      // ISSUE: variable of a compiler-generated type
      BaseDataObject._Closure\u0024__27\u002D1<T> closure271_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      BaseDataObject._Closure\u0024__27\u002D1<T> closure271_2 = new BaseDataObject._Closure\u0024__27\u002D1<T>(closure271_1);
      // ISSUE: reference to a compiler-generated field
      closure271_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2 = closure270_2;
      string str2 = "WITH(NOLOCK) WHERE ";
      string str3 = str1.Substring(0, str1.IndexOf(str2, StringComparison.InvariantCultureIgnoreCase) + str2.Length) + whereClause;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      DataTable dataTable = BaseDataObject.ColumnPropertyCache[closure271_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_selectType];
      // ISSUE: variable of a compiler-generated type
      BaseDataObject._Closure\u0024__27\u002D1<T> closure271_3 = closure271_2;
      DataRow[] source1 = dataTable.Select($"{"IsKey"} = 1");
      System.Func<DataRow, string> keySelector;
      // ISSUE: reference to a compiler-generated field
      if (BaseDataObject._Closure\u0024__27<T>.\u0024I27\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        keySelector = BaseDataObject._Closure\u0024__27<T>.\u0024I27\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        BaseDataObject._Closure\u0024__27<T>.\u0024I27\u002D0 = keySelector = (System.Func<DataRow, string>) ([SpecialName] (dr) => dr.Field<string>(1));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      System.Func<DataRow, PropertyInfo> elementSelector = new System.Func<DataRow, PropertyInfo>(closure271_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2._Lambda\u0024__1);
      Dictionary<string, PropertyInfo> dictionary = ((IEnumerable<DataRow>) source1).ToDictionary<DataRow, string, PropertyInfo>(keySelector, elementSelector);
      // ISSUE: reference to a compiler-generated field
      closure271_3.\u0024VB\u0024Local_keyRows = dictionary;
      DataTable source2 = DefaultDatabase.ExecuteDataTable(CommandType.Text, str3, keys);
      if (source2 != null)
      {
        // ISSUE: reference to a compiler-generated method
        objList2.AddRange((IEnumerable<T>) source2.AsEnumerable().Select<DataRow, T>(new System.Func<DataRow, T>(closure271_2._Lambda\u0024__2)));
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
    }
    objList1 = objList2;
label_13:
    return objList1;
  }

  public static List<T> SelectMultiple<T>(params object[] pkValues) where T : BaseDataObject
  {
    return BaseDataObject.SelectMultipleAndSet<T>((Action<T>) null, pkValues);
  }

  public static List<T> SelectMultipleAndSet<T>(Action<T> setAction, params object[] pkValues) where T : BaseDataObject
  {
    Action<\u0024CLS0> setAction1 = setAction;
    List<T> objList1;
    if (pkValues.Length == 1 && pkValues[0] is IEnumerable)
    {
      IEnumerable pkValue = (IEnumerable) pkValues[0];
      objList1 = BaseDataObject.SelectMultipleAndSet<T>(setAction1, pkValue.Cast<object>().ToArray<object>());
    }
    else
    {
      string str1 = (string) null;
      Type key = typeof (T);
      if (!BaseDataObject.ObjectSelectionCache.TryGetValue(key, out str1))
      {
        try
        {
          T obj = NewObject<T>.Instance();
          key = obj.GetType();
          obj.AllowMissingRecord = true;
          obj.RefreshData();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        if (!BaseDataObject.ObjectSelectionCache.TryGetValue(key, out str1))
        {
          objList1 = (List<T>) null;
          goto label_28;
        }
      }
      List<T> objList2 = new List<T>();
      if ((pkValues != null ? pkValues.Length : 0) == 0)
      {
        objList1 = objList2;
      }
      else
      {
        try
        {
          DataRow row = ((IEnumerable<DataRow>) BaseDataObject.ColumnPropertyCache[key].Select($"{"IsKey"} = 1")).SingleOrDefault<DataRow>();
          string columnName = row.Field<string>(1);
          PropertyInfo property = key.GetProperty(row.Field<string>(0));
          string str2 = "WITH(NOLOCK) WHERE ";
          string str3 = str1.Substring(0, str1.IndexOf(str2, StringComparison.InvariantCultureIgnoreCase) + str2.Length) + $"{columnName} IN ";
          List<object> objectList1 = new List<object>();
          string str4;
          if (pkValues.Length <= 30)
          {
            object[] source1 = pkValues;
            Func<object, int, (string, object)> selector1;
            // ISSUE: reference to a compiler-generated field
            if (BaseDataObject._Closure\u0024__29<T>.\u0024I29\u002D0 != null)
            {
              // ISSUE: reference to a compiler-generated field
              selector1 = BaseDataObject._Closure\u0024__29<T>.\u0024I29\u002D0;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              BaseDataObject._Closure\u0024__29<T>.\u0024I29\u002D0 = selector1 = (Func<object, int, (string, object)>) ([SpecialName] (pk, idx) => ($"@PK{idx}", pk));
            }
            IEnumerable<(string, object)> source2 = ((IEnumerable<object>) source1).Select<object, (string, object)>(selector1);
            System.Func<(string, object), string> keySelector;
            // ISSUE: reference to a compiler-generated field
            if (BaseDataObject._Closure\u0024__29<T>.\u0024I29\u002D1 != null)
            {
              // ISSUE: reference to a compiler-generated field
              keySelector = BaseDataObject._Closure\u0024__29<T>.\u0024I29\u002D1;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              BaseDataObject._Closure\u0024__29<T>.\u0024I29\u002D1 = keySelector = (System.Func<(string, object), string>) ([SpecialName] (tpk) => tpk.ParamName);
            }
            System.Func<(string, object), object> elementSelector;
            // ISSUE: reference to a compiler-generated field
            if (BaseDataObject._Closure\u0024__29<T>.\u0024I29\u002D2 != null)
            {
              // ISSUE: reference to a compiler-generated field
              elementSelector = BaseDataObject._Closure\u0024__29<T>.\u0024I29\u002D2;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              BaseDataObject._Closure\u0024__29<T>.\u0024I29\u002D2 = elementSelector = (System.Func<(string, object), object>) ([SpecialName] (tpk) => tpk.ParamValue);
            }
            Dictionary<string, object> dictionary = source2.ToDictionary<(string, object), string, object>(keySelector, elementSelector);
            str4 = str3 + $"({string.Join(",", (IEnumerable<string>) dictionary.Keys)})";
            List<object> objectList2 = objectList1;
            Dictionary<string, object> source3 = dictionary;
            System.Func<KeyValuePair<string, object>, IEnumerable<object>> selector2;
            // ISSUE: reference to a compiler-generated field
            if (BaseDataObject._Closure\u0024__29<T>.\u0024I29\u002D3 != null)
            {
              // ISSUE: reference to a compiler-generated field
              selector2 = BaseDataObject._Closure\u0024__29<T>.\u0024I29\u002D3;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              BaseDataObject._Closure\u0024__29<T>.\u0024I29\u002D3 = selector2 = (System.Func<KeyValuePair<string, object>, IEnumerable<object>>) ([SpecialName] (kvp) => (IEnumerable<object>) new object[2]
              {
                (object) kvp.Key,
                kvp.Value
              });
            }
            IEnumerable<object> collection = source3.SelectMany<KeyValuePair<string, object>, object>(selector2);
            objectList2.AddRange(collection);
          }
          else
          {
            str4 = str3 + "(SELECT value FROM STRING_SPLIT(@valuesSeparated, @separater))";
            objectList1.AddRange((IEnumerable<object>) new object[4]
            {
              (object) "@valuesSeparated",
              (object) string.Join("|", pkValues),
              (object) "@separater",
              (object) "|"
            });
          }
          DataTable source = DefaultDatabase.ExecuteDataTable(CommandType.Text, str4, objectList1.ToArray());
          if (source != null)
            objList2.AddRange((IEnumerable<T>) source.AsEnumerable().Select<DataRow, T>((System.Func<DataRow, T>) ([SpecialName] (dr) =>
            {
              \u0024CLS0 clS0 = NewObject<\u0024CLS0>.Instance();
              DataTable dataTable = dr.Table.Clone();
              clS0.ObjectDataStore = dataTable.Rows.Add(dr.ItemArray);
              property.SetValue((object) clS0, RuntimeHelpers.GetObjectValue(dr[columnName]));
              clS0.SelectKeys = new object[2]
              {
                (object) $"@{columnName}",
                dr[columnName]
              };
              if (setAction != null)
                setAction(clS0);
              return clS0;
            })));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ErrorHandler.SilentHandleError(ex);
          ProjectData.ClearProjectError();
        }
        objList1 = objList2;
      }
    }
label_28:
    return objList1;
  }

  internal enum Model
  {
    PropertyName,
    ColumnAlias,
    IsKey,
    SelectorFunction,
    RetrieveLogic,
  }
}

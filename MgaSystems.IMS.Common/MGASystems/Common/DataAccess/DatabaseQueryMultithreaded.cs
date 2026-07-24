// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.DatabaseQueryMultithreaded
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.DataAccess;

[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class DatabaseQueryMultithreaded
{
  private static SqlParameter[] ParseNamevalueArgs(params object[] namevalueArgs)
  {
    List<SqlParameter> sqlParameterList = new List<SqlParameter>();
    bool flag = true;
    string parameterName = string.Empty;
    int num = namevalueArgs.Length - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (flag)
        parameterName = namevalueArgs[index] is string ? Conversions.ToString(namevalueArgs[index]) : throw new DatabaseException(MGASystems.Common.SR.GetString("DB_ArgMustBeString"));
      else
        sqlParameterList.Add(new SqlParameter(parameterName, RuntimeHelpers.GetObjectValue(Database.IsNull(RuntimeHelpers.GetObjectValue(namevalueArgs[index]), (object) DBNull.Value))));
      flag = !flag;
    }
    return sqlParameterList.Count <= 0 ? (SqlParameter[]) null : sqlParameterList.ToArray();
  }

  public void PerformScalarQuery(
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    ScalarQueryMultithreadedEventHandler completedHandler)
  {
    this.CreateScalarQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters, completedHandler).StartThread();
  }

  public void PerformScalarQuery(
    Control uiContext,
    object key,
    string queryText,
    ScalarQueryMultithreadedEventHandler completedHandler,
    params object[] namevalueArgs)
  {
    this.CreateScalarQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, DatabaseQueryMultithreaded.ParseNamevalueArgs(namevalueArgs), completedHandler).StartThread();
  }

  public void PerformScalarQuery(
    ThreadPriority priority,
    Control uiContext,
    object key,
    string queryText,
    ScalarQueryMultithreadedEventHandler completedHandler,
    params object[] namevalueArgs)
  {
    this.CreateScalarQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, DatabaseQueryMultithreaded.ParseNamevalueArgs(namevalueArgs), completedHandler).StartThread(priority);
  }

  public void PerformScalarQuery(
    Control uiContext,
    object key,
    string queryText,
    ScalarQueryMultithreadedEventHandler completedHandler)
  {
    this.CreateScalarQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, (SqlParameter[]) null, completedHandler).StartThread();
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  protected internal abstract ScalarQueryThreadText CreateScalarQueryThread(
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    ScalarQueryMultithreadedEventHandler completedHandler);

  public void PerformRowQuery(
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    RowQueryMultithreadedEventHandler completedHandler)
  {
    this.CreateRowQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters, completedHandler).StartThread();
  }

  public void PerformRowQuery(
    Control uiContext,
    object key,
    string queryText,
    RowQueryMultithreadedEventHandler completedHandler,
    params object[] namevalueArgs)
  {
    this.CreateRowQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, DatabaseQueryMultithreaded.ParseNamevalueArgs(namevalueArgs), completedHandler).StartThread();
  }

  public void PerformRowQuery(
    Control uiContext,
    object key,
    string queryText,
    RowQueryMultithreadedEventHandler completedHandler)
  {
    this.CreateRowQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, (SqlParameter[]) null, completedHandler).StartThread();
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  protected internal abstract RowQueryThreadText CreateRowQueryThread(
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    RowQueryMultithreadedEventHandler completedHandler);

  public void PerformTableQuery(
    ThreadPriority priority,
    TableQueryMultithreadEventHandler completedHandler,
    Control uiContext,
    object key,
    string queryText,
    params object[] namevalueArgs)
  {
    this.CreateTableQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, DatabaseQueryMultithreaded.ParseNamevalueArgs(namevalueArgs), completedHandler, (TableFillingEventHandler) null).StartThread(priority);
  }

  public void PerformTableQuery(
    TableQueryMultithreadEventHandler completedHandler,
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters)
  {
    this.CreateTableQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters, completedHandler, (TableFillingEventHandler) null).StartThread();
  }

  public void PerformTableQuery(
    TableQueryMultithreadEventHandler completedHandler,
    Control uiContext,
    object key,
    string queryText,
    params object[] namevalueArgs)
  {
    this.CreateTableQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, DatabaseQueryMultithreaded.ParseNamevalueArgs(namevalueArgs), completedHandler, (TableFillingEventHandler) null).StartThread();
  }

  public void PerformTableQuery(
    TableQueryMultithreadEventHandler completedHandler,
    Control uiContext,
    object key,
    string queryText)
  {
    this.CreateTableQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, (SqlParameter[]) null, completedHandler, (TableFillingEventHandler) null).StartThread();
  }

  public void PerformTableQuery(
    TableQueryMultithreadEventHandler completedHandler,
    TableFillingEventHandler fillingHandler,
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters)
  {
    this.CreateTableQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters, completedHandler, fillingHandler).StartThread();
  }

  public void PerformTableQuery(
    TableQueryMultithreadEventHandler completedHandler,
    TableFillingEventHandler fillingHandler,
    Control uiContext,
    object key,
    string queryText,
    params object[] namevalueArgs)
  {
    this.CreateTableQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, DatabaseQueryMultithreaded.ParseNamevalueArgs(namevalueArgs), completedHandler, fillingHandler).StartThread();
  }

  public void PerformTableQuery(
    TableQueryMultithreadEventHandler completedHandler,
    TableFillingEventHandler fillingHandler,
    Control uiContext,
    object key,
    string queryText)
  {
    this.CreateTableQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, (SqlParameter[]) null, completedHandler, fillingHandler).StartThread();
  }

  public void PerformTableQueryBG(
    TableQueryMultithreadEventHandler completedHandler,
    object key,
    string queryText,
    SqlParameter[] sqlParameters)
  {
    this.CreateTableQueryThreadNonUISafe(RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters, completedHandler, (TableFillingEventHandler) null).StartThread();
  }

  public void PerformTableQueryBG(
    TableQueryMultithreadEventHandler completedHandler,
    object key,
    string queryText,
    params object[] namevalueArgs)
  {
    this.CreateTableQueryThreadNonUISafe(RuntimeHelpers.GetObjectValue(key), queryText, DatabaseQueryMultithreaded.ParseNamevalueArgs(namevalueArgs), completedHandler, (TableFillingEventHandler) null).StartThread();
  }

  public void PerformTableQueryBG(
    TableQueryMultithreadEventHandler completedHandler,
    object key,
    string queryText)
  {
    this.CreateTableQueryThreadNonUISafe(RuntimeHelpers.GetObjectValue(key), queryText, (SqlParameter[]) null, completedHandler, (TableFillingEventHandler) null).StartThread();
  }

  public void PerformTableQueryBG(
    TableQueryMultithreadEventHandler completedHandler,
    TableFillingEventHandler fillingHandler,
    object key,
    string queryText,
    SqlParameter[] sqlParameters)
  {
    this.CreateTableQueryThreadNonUISafe(RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters, completedHandler, fillingHandler).StartThread();
  }

  public void PerformTableQueryBG(
    TableQueryMultithreadEventHandler completedHandler,
    TableFillingEventHandler fillingHandler,
    object key,
    string queryText,
    params object[] namevalueArgs)
  {
    this.CreateTableQueryThreadNonUISafe(RuntimeHelpers.GetObjectValue(key), queryText, DatabaseQueryMultithreaded.ParseNamevalueArgs(namevalueArgs), completedHandler, fillingHandler).StartThread();
  }

  public void PerformTableQueryBG(
    TableQueryMultithreadEventHandler completedHandler,
    TableFillingEventHandler fillingHandler,
    object key,
    string queryText)
  {
    this.CreateTableQueryThreadNonUISafe(RuntimeHelpers.GetObjectValue(key), queryText, (SqlParameter[]) null, completedHandler, fillingHandler).StartThread();
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  protected internal abstract TableQueryThreadText CreateTableQueryThread(
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    TableQueryMultithreadEventHandler completedHandler,
    TableFillingEventHandler fillingHandler);

  [EditorBrowsable(EditorBrowsableState.Never)]
  protected internal abstract TableQueryThreadText CreateTableQueryThreadNonUISafe(
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    TableQueryMultithreadEventHandler completedHandler,
    TableFillingEventHandler fillingHandler);

  public void PerformNonQuery(
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    NonQueryMultithreadEventHandler completedHandler)
  {
    this.CreateNonQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters, completedHandler).StartThread();
  }

  public void PerformNonQuery(
    Control uiContext,
    object key,
    string queryText,
    NonQueryMultithreadEventHandler completedHandler,
    params object[] namevalueArgs)
  {
    this.CreateNonQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, DatabaseQueryMultithreaded.ParseNamevalueArgs(namevalueArgs), completedHandler).StartThread();
  }

  public void PerformNonQuery(
    Control uiContext,
    object key,
    string queryText,
    NonQueryMultithreadEventHandler completedHandler)
  {
    this.CreateNonQueryThread(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, (SqlParameter[]) null, completedHandler).StartThread();
  }

  public void PerformNonQuery(string queryText)
  {
    this.CreateNonQueryThread((Control) null, (object) string.Empty, queryText, (SqlParameter[]) null, (NonQueryMultithreadEventHandler) null).StartThread();
  }

  public void PerformNonQuery(string queryText, SqlParameter[] sqlParameters)
  {
    this.CreateNonQueryThread((Control) null, (object) string.Empty, queryText, sqlParameters, (NonQueryMultithreadEventHandler) null).StartThread();
  }

  public void PerformNonQuery(string queryText, params object[] namevalueArgs)
  {
    this.CreateNonQueryThread((Control) null, (object) string.Empty, queryText, DatabaseQueryMultithreaded.ParseNamevalueArgs(namevalueArgs), (NonQueryMultithreadEventHandler) null).StartThread();
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  protected internal abstract NonQueryThreadText CreateNonQueryThread(
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    NonQueryMultithreadEventHandler completedHandler);
}

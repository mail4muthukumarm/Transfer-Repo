// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.DatabaseQueryMultithreadedText
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.ComponentModel;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.DataAccess;

[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class DatabaseQueryMultithreadedText : DatabaseQueryMultithreaded
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  protected internal override NonQueryThreadText CreateNonQueryThread(
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    NonQueryMultithreadEventHandler completedHandler)
  {
    return new NonQueryThreadText(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters, completedHandler);
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  protected internal override ScalarQueryThreadText CreateScalarQueryThread(
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    ScalarQueryMultithreadedEventHandler completedHandler)
  {
    return new ScalarQueryThreadText(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters, completedHandler);
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  protected internal override RowQueryThreadText CreateRowQueryThread(
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    RowQueryMultithreadedEventHandler completedHandler)
  {
    return new RowQueryThreadText(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters, completedHandler);
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  protected internal override TableQueryThreadText CreateTableQueryThread(
    Control uiContext,
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    TableQueryMultithreadEventHandler completedHandler,
    TableFillingEventHandler fillingHandler)
  {
    return new TableQueryThreadText(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters, completedHandler, fillingHandler);
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  protected internal override TableQueryThreadText CreateTableQueryThreadNonUISafe(
    object key,
    string queryText,
    SqlParameter[] sqlParameters,
    TableQueryMultithreadEventHandler completedHandler,
    TableFillingEventHandler fillingHandler)
  {
    return new TableQueryThreadText((Control) null, RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters, completedHandler, fillingHandler);
  }
}

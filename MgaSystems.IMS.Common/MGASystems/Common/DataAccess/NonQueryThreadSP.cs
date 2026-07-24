// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.NonQueryThreadSP
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.DataAccess;

internal class NonQueryThreadSP(
  Control uiContext,
  object key,
  string queryText,
  SqlParameter[] sqlParameters,
  NonQueryMultithreadEventHandler completedHandler) : NonQueryThreadText(uiContext, RuntimeHelpers.GetObjectValue(key), queryText, sqlParameters, completedHandler)
{
  protected override void ThreadProcBG()
  {
    this.RowsAffected = this.DB.QuerySP.PerformNonQuery(this.QueryText, this.GetSqlParameters());
  }
}

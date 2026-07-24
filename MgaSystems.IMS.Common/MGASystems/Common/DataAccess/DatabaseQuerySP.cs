// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.DatabaseQuerySP
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.ComponentModel;
using System.Data;

#nullable disable
namespace MGASystems.Common.DataAccess;

[EditorBrowsable(EditorBrowsableState.Never)]
public class DatabaseQuerySP : DatabaseQuery
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal DatabaseQuerySP(Database db)
    : base(db)
  {
  }

  protected override CommandType CommandType => CommandType.StoredProcedure;
}

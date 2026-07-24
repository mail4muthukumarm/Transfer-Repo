// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.AuthorityLimit.Lib.AuthorityLimitCellType
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Data;
using MGASystems.Data.Binding;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.AuthorityLimit.Lib;

public abstract class AuthorityLimitCellType : BindingObject
{
  public virtual int CellTypeID { get; set; }

  public virtual string CellType { get; set; }

  internal static AuthorityLimitCellType Create(DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<AuthorityLimitCellType>(new object[1]
    {
      (object) row
    });
  }

  public AuthorityLimitCellType(DataRow row)
  {
    this.CellTypeID = row.Field<int>(nameof (CellTypeID));
    this.CellType = row.Field<string>(nameof (CellType));
  }

  public static ObservableCollection<AuthorityLimitCellType> GetAuthorityLimitCellTypeList()
  {
    return new ObservableCollection<AuthorityLimitCellType>((IEnumerable<AuthorityLimitCellType>) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM tblAuthorityLimitCellType").AsEnumerable().Select<DataRow, AuthorityLimitCellType>((System.Func<DataRow, AuthorityLimitCellType>) (row => AuthorityLimitCellType.Create(row))));
  }
}

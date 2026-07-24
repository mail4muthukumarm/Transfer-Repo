// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.AuthorityLimit.Lib.RaterField
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Data;
using MGASystems.Data;
using MGASystems.Data.Binding;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.AuthorityLimit.Lib;

public abstract class RaterField : BindingObject
{
  [NotificationProperty]
  public virtual string DatabaseField { get; set; }

  internal static RaterField Create(DataRow row)
  {
    return NotifyProxyTypeManager.Allocate<RaterField>(new object[1]
    {
      (object) row
    });
  }

  public RaterField(DataRow row) => this.DatabaseField = row.Field<string>(nameof (DatabaseField));

  public static ObservableCollection<SearchObject> GetDatabaseFields(int raterTypeID)
  {
    return new ObservableCollection<SearchObject>((IEnumerable<SearchObject>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spGetDatabaseFieldsExcelRater", new object[2]
    {
      (object) "@RaterTypeID",
      (object) raterTypeID
    }).AsEnumerable().Select<DataRow, SearchObject>((System.Func<DataRow, SearchObject>) (row => SearchObject.Create(0, row.Field<string>("DatabaseField"), (object) RaterField.Create(row)))));
  }
}

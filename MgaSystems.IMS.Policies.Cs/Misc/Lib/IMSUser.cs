// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.Misc.Lib.IMSUser
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Data;
using MGASystems.Data;
using MGASystems.Data.Binding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.Misc.Lib;

public abstract class IMSUser : BindingObject
{
  public Guid UserGUID { get; set; }

  [NotificationProperty]
  public virtual string Name_FirstLast { get; set; }

  public IMSUser(Guid userGuid, string firstLastName)
  {
    this.UserGUID = userGuid;
    this.Name_FirstLast = firstLastName;
  }

  public static IMSUser Create(Guid userGuid, string firstLastName)
  {
    return NotifyProxyTypeManager.Allocate<IMSUser>(new object[2]
    {
      (object) userGuid,
      (object) firstLastName
    });
  }

  public static ObservableCollection<SearchObject> GetUserList()
  {
    return new ObservableCollection<SearchObject>((IEnumerable<SearchObject>) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT UserGUID, Name_FirstLast FROM tblUsers WHERE StatusID = 1 ORDER BY Name_FirstLast").AsEnumerable().Select<DataRow, SearchObject>((System.Func<DataRow, SearchObject>) (row =>
    {
      string firstLastName = row.Field<string>("Name_FirstLast");
      return SearchObject.Create(0, firstLastName, (object) IMSUser.Create(row.Field<Guid>("UserGUID"), firstLastName));
    })));
  }
}

// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.Line
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Data;
using MGASystems.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels;

public class Line
{
  public Guid LineGuid { get; set; }

  public Guid OfficeGuid { get; set; }

  public string LineName { get; set; }

  public static ObservableCollection<SearchObject> GetThresholdLines()
  {
    return new ObservableCollection<SearchObject>((IEnumerable<SearchObject>) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT LineGuid, LineName FROM lstLines WITH (NOLOCK) WHERE LineGuid in (select LineGuid from tblCompanyLines WITH (NOLOCK) where ParentCompanyLineGUID is null) ORDER BY LineName").AsEnumerable().Select<DataRow, SearchObject>((System.Func<DataRow, SearchObject>) (row => SearchObject.Create(0, row.Field<string>("LineName"), (object) new Line()
    {
      LineGuid = row.Field<Guid>("LineGuid"),
      LineName = row.Field<string>("LineName")
    }))));
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.CompanyLocation
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Mga.Wpf.Ims.Collections;
using MGASystems.Data;
using MGASystems.Data.Binding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public abstract class CompanyLocation : BindingObject
{
  [NotificationProperty]
  public virtual Guid CompanyLocationGuid { get; set; }

  [NotificationProperty]
  public virtual string Name { get; set; }

  public CompanyLocation(Guid _companyLocGuid, string _name)
  {
    this.CompanyLocationGuid = _companyLocGuid;
    this.Name = _name;
  }

  public static CompanyLocation Create(Guid _companyLocGuid, string _name)
  {
    return NotifyProxyTypeManager.Allocate<CompanyLocation>(new object[2]
    {
      (object) _companyLocGuid,
      (object) _name
    });
  }

  public static ObservableCollection<CompanyLocation> GetCompanyLocationList()
  {
    DataTable source1 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT CompanyLocationGUID, Name FROM tblCompanyLocations WITH (NOLOCK) ORDER BY Name");
    BulkObservableCollection<CompanyLocation> companyLocationList = new BulkObservableCollection<CompanyLocation>();
    ((Collection<CompanyLocation>) companyLocationList).Add(CompanyLocation.Create(Guid.Empty, "Any"));
    EnumerableRowCollection<DataRow> source2 = source1.AsEnumerable();
    System.Func<DataRow, CompanyLocation> selector;
    // ISSUE: reference to a compiler-generated field
    if (CompanyLocation._Closure\u0024__.\u0024I10\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = CompanyLocation._Closure\u0024__.\u0024I10\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      CompanyLocation._Closure\u0024__.\u0024I10\u002D0 = selector = (System.Func<DataRow, CompanyLocation>) ([SpecialName] (row) => CompanyLocation.Create(row.Field<Guid>("CompanyLocationGUID"), row.Field<string>("Name")));
    }
    companyLocationList.AddRange((IEnumerable<CompanyLocation>) new ObservableCollection<CompanyLocation>((IEnumerable<CompanyLocation>) source2.Select<DataRow, CompanyLocation>(selector)));
    return (ObservableCollection<CompanyLocation>) companyLocationList;
  }
}

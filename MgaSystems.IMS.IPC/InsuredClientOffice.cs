// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.InsuredClientOffice
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using MGASystems.Data;
using MGASystems.Data.Binding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

public abstract class InsuredClientOffice : BindingObject
{
  public Guid OfficeGuid { get; set; }

  public string Location { get; set; }

  [NotificationProperty]
  public virtual bool AllowView { get; set; }

  public static InsuredClientOffice Create(DataRow dr)
  {
    return NotifyProxyTypeManager.Allocate<InsuredClientOffice>(new object[1]
    {
      (object) dr
    });
  }

  public InsuredClientOffice(DataRow dr)
  {
    this.OfficeGuid = dr.Field<Guid>(nameof (OfficeGuid));
    this.Location = dr.Field<string>(nameof (Location));
    this.AllowView = dr.Field<bool>(nameof (AllowView));
  }

  public static ObservableCollection<InsuredClientOffice> GetInsuredClientOffices(Guid insuredGuid)
  {
    EnumerableRowCollection<DataRow> source = DefaultDatabase.ExecuteDataTable("spGetInsuredClientOfficeData", new object[2]
    {
      (object) "@InsuredGuid",
      (object) insuredGuid
    }).AsEnumerable();
    System.Func<DataRow, InsuredClientOffice> selector;
    // ISSUE: reference to a compiler-generated field
    if (InsuredClientOffice._Closure\u0024__.\u0024I14\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = InsuredClientOffice._Closure\u0024__.\u0024I14\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      InsuredClientOffice._Closure\u0024__.\u0024I14\u002D0 = selector = (System.Func<DataRow, InsuredClientOffice>) ([SpecialName] (row) => InsuredClientOffice.Create(row));
    }
    return new ObservableCollection<InsuredClientOffice>((IEnumerable<InsuredClientOffice>) source.Select<DataRow, InsuredClientOffice>(selector));
  }

  public static void UpdateClientOffice(Guid insuredGuid, Guid officeGuid, bool allowView)
  {
    DefaultDatabase.ExecuteNonQuery("UpdateInsuredClientOffice", new object[6]
    {
      (object) "@OfficeGuid",
      (object) officeGuid,
      (object) "@InsuredGuid",
      (object) insuredGuid,
      (object) "@AllowView",
      (object) allowView
    });
  }
}

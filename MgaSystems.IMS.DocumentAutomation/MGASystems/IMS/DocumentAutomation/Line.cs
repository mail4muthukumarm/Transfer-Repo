// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.Line
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

public abstract class Line : BindingObject
{
  [NotificationProperty]
  public virtual Guid LineGuid { get; set; }

  [NotificationProperty]
  public virtual string Name { get; set; }

  public Line(Guid _lineGuid, string _name)
  {
    this.LineGuid = _lineGuid;
    this.Name = _name;
  }

  public static Line Create(Guid _lineGuid, string _name)
  {
    return NotifyProxyTypeManager.Allocate<Line>(new object[2]
    {
      (object) _lineGuid,
      (object) _name
    });
  }

  public static ObservableCollection<Line> GetLineList()
  {
    DataTable source1 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT LineGUID, LineName FROM lstLines ORDER BY LineName");
    BulkObservableCollection<Line> lineList = new BulkObservableCollection<Line>();
    ((Collection<Line>) lineList).Add(Line.Create(Guid.Empty, "Any"));
    EnumerableRowCollection<DataRow> source2 = source1.AsEnumerable();
    System.Func<DataRow, Line> selector;
    // ISSUE: reference to a compiler-generated field
    if (Line._Closure\u0024__.\u0024I10\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = Line._Closure\u0024__.\u0024I10\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      Line._Closure\u0024__.\u0024I10\u002D0 = selector = (System.Func<DataRow, Line>) ([SpecialName] (row) => Line.Create(row.Field<Guid>("LineGUID"), row.Field<string>("LineName")));
    }
    lineList.AddRange((IEnumerable<Line>) new ObservableCollection<Line>((IEnumerable<Line>) source2.Select<DataRow, Line>(selector)));
    return (ObservableCollection<Line>) lineList;
  }
}

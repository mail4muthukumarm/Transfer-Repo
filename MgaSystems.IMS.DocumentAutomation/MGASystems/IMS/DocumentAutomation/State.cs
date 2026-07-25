// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.State
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Mga.Wpf.Ims.Collections;
using MGASystems.Data;
using MGASystems.Data.Binding;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public abstract class State : BindingObject
{
  [NotificationProperty]
  public virtual string StateID { get; set; }

  [NotificationProperty]
  public virtual string Name { get; set; }

  public State(string _stateID, string _name)
  {
    this.StateID = _stateID;
    this.Name = _name;
  }

  public static State Create(string _stateID, string _name)
  {
    return NotifyProxyTypeManager.Allocate<State>(new object[2]
    {
      (object) _stateID,
      (object) _name
    });
  }

  public static ObservableCollection<State> GetStateList()
  {
    DataTable source1 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT StateID, State FROM lstStates ORDER BY State");
    BulkObservableCollection<State> stateList = new BulkObservableCollection<State>();
    ((Collection<State>) stateList).Add(State.Create("", "Any"));
    EnumerableRowCollection<DataRow> source2 = source1.AsEnumerable();
    System.Func<DataRow, State> selector;
    // ISSUE: reference to a compiler-generated field
    if (State._Closure\u0024__.\u0024I10\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = State._Closure\u0024__.\u0024I10\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      State._Closure\u0024__.\u0024I10\u002D0 = selector = (System.Func<DataRow, State>) ([SpecialName] (row) => State.Create(row.Field<string>("StateID"), row.Field<string>(nameof (State))));
    }
    stateList.AddRange((IEnumerable<State>) new ObservableCollection<State>((IEnumerable<State>) source2.Select<DataRow, State>(selector)));
    return (ObservableCollection<State>) stateList;
  }
}

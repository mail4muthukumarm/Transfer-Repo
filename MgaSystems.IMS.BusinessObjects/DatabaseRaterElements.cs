// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.DatabaseRaterElements
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

#nullable disable
namespace MGASystems.BusinessObjects;

public class DatabaseRaterElements
{
  protected Dictionary<int, RaterConditionalElement> StoredConditionals { get; }

  protected int RaterID { get; }

  protected virtual string ConditionalProcedure => "dbo.RaterConditionals_GetConditionList";

  public DatabaseRaterElements(int RaterID, string LineCode)
  {
    this.StoredConditionals = new Dictionary<int, RaterConditionalElement>();
    this.RaterID = RaterID;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(this.ConditionalProcedure, new object[4]
    {
      (object) "@raterID",
      (object) RaterID,
      (object) "@lineCode",
      (object) LineCode
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
        this.Add(DatabaseConditionalElement.Create($"{row.Field<string>("ConditionName")} [DB]", row.Field<int>("ConditionID"), row.Field<string>("ConditionType"), RaterID, row.Field<string>("StoredProcedure")));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public bool Add(RaterConditionalElement condition)
  {
    bool flag;
    if (condition == null || condition.RaterID < 0 || condition.RaterID != this.RaterID)
      flag = false;
    else if (!this.StoredConditionals.ContainsKey(condition.ConditionalID))
    {
      this.StoredConditionals.Add(condition.ConditionalID, condition);
      flag = true;
    }
    else
      flag = false;
    return flag;
  }

  public RaterConditionalElement Find(int conditionID)
  {
    RaterConditionalElement conditionalElement = (RaterConditionalElement) null;
    this.StoredConditionals.TryGetValue(conditionID, out conditionalElement);
    return conditionalElement;
  }

  public List<RaterConditionalElement> ConditionalElements
  {
    get
    {
      Dictionary<int, RaterConditionalElement> storedConditionals = this.StoredConditionals;
      return storedConditionals == null ? (List<RaterConditionalElement>) null : storedConditionals.Values.ToList<RaterConditionalElement>();
    }
  }
}

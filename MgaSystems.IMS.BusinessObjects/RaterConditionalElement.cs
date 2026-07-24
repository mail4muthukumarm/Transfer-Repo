// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.RaterConditionalElement
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

#nullable disable
namespace MGASystems.BusinessObjects;

public class RaterConditionalElement
{
  public string Condition { get; }

  public int ConditionalID { get; }

  public string ConditionType { get; }

  public int RaterID { get; }

  public RaterConditionalElement(
    string condition,
    int conditionalID,
    string conditionType,
    int raterID)
  {
    this.Condition = condition;
    this.ConditionalID = conditionalID;
    this.ConditionType = conditionType;
    this.RaterID = raterID;
  }

  public bool IsDatabaseConditional
  {
    get
    {
      return !string.IsNullOrEmpty(this is DatabaseConditionalElement conditionalElement ? conditionalElement.StoredProcedure : (string) null);
    }
  }
}

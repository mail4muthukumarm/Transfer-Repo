// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.DatabaseConditionalElement
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;

#nullable disable
namespace MGASystems.BusinessObjects;

public class DatabaseConditionalElement(
  string condition,
  int conditionalID,
  string conditionType,
  int raterID) : RaterConditionalElement(condition, conditionalID, conditionType, raterID)
{
  public string StoredProcedure { get; }

  public DatabaseConditionalElement(
    string condition,
    int conditionalID,
    string conditionType,
    int raterID,
    string storedProcedure)
    : this(condition, conditionalID, conditionType, raterID)
  {
    this.StoredProcedure = storedProcedure;
  }

  public static RaterConditionalElement Create(
    string condition,
    int conditionalID,
    string conditionType,
    int raterID,
    string storedProcedure)
  {
    return (RaterConditionalElement) ObjectFactory.Instance.CreateObjectAs<DatabaseConditionalElement>((object) condition, (object) conditionalID, (object) conditionType, (object) raterID, (object) storedProcedure);
  }
}

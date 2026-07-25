// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.RaterConditionCompare
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.BusinessObjects;
using MGASystems.Data;
using System;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public class RaterConditionCompare
{
  private const int Earthquake_Coverage_Exists = 900;
  private const int Flood_Coverage_Exists = 901;
  private const int Property_Rater_Limit = 902;
  private const int TerrorismDeclined = 903;
  private const int SIC_Code = 904;
  private const int Cause_Of_Loss_Exists = 905;

  public bool ValidateCondition(
    int conditionID,
    ConditionalOperators conditions,
    object amount,
    Guid QuoteGuid)
  {
    bool flag;
    switch (conditionID)
    {
      case 900:
      case 901:
      case 902:
      case 903:
      case 904:
      case 905:
        flag = DefaultDatabase.ExecuteScalar<bool>("PropertyRaterFormConditionals", new object[8]
        {
          (object) "@QuoteGuid",
          (object) QuoteGuid,
          (object) "@ConditionalID",
          (object) conditionID,
          (object) "@Conditions",
          (object) conditions,
          (object) "@Amount",
          amount
        });
        break;
      default:
        flag = false;
        break;
    }
    return flag;
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.RatingFunctions
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.Data;
using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public sealed class RatingFunctions
{
  private static Hashtable _chargeCodeHash;

  private RatingFunctions()
  {
  }

  public static int GetPremiumChargeCode(string stateId, string chargeId)
  {
    if (RatingFunctions._chargeCodeHash == null)
      RatingFunctions._chargeCodeHash = new Hashtable();
    string key = stateId + chargeId;
    int premiumChargeCode;
    if (!RatingFunctions._chargeCodeHash.ContainsKey((object) key))
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ChargeCode FROM tblFin_PolicyCharges WHERE ChargeType=@P AND ChargeID=@CID AND StateID=@SID", new object[6]
      {
        (object) "@CID",
        (object) chargeId,
        (object) "@SID",
        (object) stateId,
        (object) "@P",
        (object) "P"
      }));
      premiumChargeCode = objectValue != null ? (int) objectValue : throw new InvalidOperationException($"Could not find the premium ChargeCode with ChargeID \"{chargeId}\" and in {stateId}");
      RatingFunctions._chargeCodeHash.Add((object) key, RuntimeHelpers.GetObjectValue(objectValue));
    }
    else
      premiumChargeCode = (int) RatingFunctions._chargeCodeHash[(object) key];
    return premiumChargeCode;
  }
}

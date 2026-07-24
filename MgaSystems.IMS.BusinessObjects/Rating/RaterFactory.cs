// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.Rating.RaterFactory
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.BusinessObjects.Rating;

public sealed class RaterFactory
{
  private static ConcurrentDictionary<int, Type> RaterTypeHash { get; } = new ConcurrentDictionary<int, Type>();

  private RaterFactory()
  {
  }

  [SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId = "0#")]
  public static IRater GetRater(int raterID)
  {
    Type baseType = (Type) null;
    IRater rater1;
    if (!RaterFactory.RaterTypeHash.TryGetValue(raterID, out baseType))
    {
      Type[] typeArray1 = ObjectFactory.Instance.QueryTypesWithInterface(typeof (IRaterFactoryExtension));
      if (typeArray1 != null && typeArray1.Length > 0)
      {
        Type[] typeArray2 = typeArray1;
        int index = 0;
        while (index < typeArray2.Length)
        {
          IRaterFactoryExtension factoryExtension = (IRaterFactoryExtension) ObjectFactory.Instance.CreateObject(typeArray2[index]);
          if (factoryExtension != null)
          {
            IRater rater2 = factoryExtension.GetRater(raterID);
            if (rater2 != null)
            {
              rater1 = rater2;
              goto label_16;
            }
          }
          checked { ++index; }
        }
      }
      Type[] typeArray3 = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new RaterInformationAttribute());
      int index1 = 0;
      while (index1 < typeArray3.Length)
      {
        Type type = typeArray3[index1];
        RaterInformationAttribute attribute = (RaterInformationAttribute) TypeDescriptor.GetAttributes(type)[typeof (RaterInformationAttribute)];
        if (attribute != null && attribute.RaterID == raterID)
        {
          IRater rater3 = (IRater) ObjectFactory.Instance.CreateObject(type, typeof (IRater));
          if (rater3 != null)
          {
            RaterFactory.RaterTypeHash.TryAdd(raterID, type);
            rater1 = rater3;
            goto label_16;
          }
        }
        checked { ++index1; }
      }
      rater1 = (IRater) null;
    }
    else
      rater1 = (IRater) ObjectFactory.Instance.CreateObject(baseType, typeof (IRater));
label_16:
    return rater1;
  }

  public static int GetRaterID(IRater Rater)
  {
    int raterId;
    if (Rater == null)
    {
      raterId = -1;
    }
    else
    {
      Type type = Rater?.GetType();
      try
      {
        foreach (KeyValuePair<int, Type> keyValuePair in RaterFactory.RaterTypeHash)
        {
          if (keyValuePair.Value == type)
          {
            raterId = keyValuePair.Key;
            goto label_11;
          }
        }
      }
      finally
      {
        IEnumerator<KeyValuePair<int, Type>> enumerator;
        enumerator?.Dispose();
      }
      raterId = -1;
    }
label_11:
    return raterId;
  }
}

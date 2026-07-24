// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.OfacSearchSetting`1
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

#nullable disable
namespace MGASystems.BusinessObjects;

public abstract class OfacSearchSetting<TSearchResult>(int ofacId) : OfacSetting(ofacId)
{
  protected virtual TSearchResult ClientProcessResult(TSearchResult result) => result;

  protected abstract bool IsOfacHit(TSearchResult result);
}

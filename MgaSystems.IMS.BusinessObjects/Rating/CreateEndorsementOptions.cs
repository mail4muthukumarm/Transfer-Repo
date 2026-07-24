// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.Rating.CreateEndorsementOptions
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

#nullable disable
namespace MGASystems.BusinessObjects.Rating;

public class CreateEndorsementOptions
{
  public EndorsementOption CalculationType;

  public CreateEndorsementOptions()
  {
    this.CalculationType = EndorsementOption.ProRata | EndorsementOption.ShortRate | EndorsementOption.Flat | EndorsementOption.MinEarned;
  }
}

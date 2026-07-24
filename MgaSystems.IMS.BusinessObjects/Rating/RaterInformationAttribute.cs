// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.Rating.RaterInformationAttribute
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using System;
using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.BusinessObjects.Rating;

[AttributeUsage(AttributeTargets.Class)]
public sealed class RaterInformationAttribute : Attribute
{
  private int _raterID;
  private string _raterName;

  public RaterInformationAttribute(int raterID, string raterName)
  {
    this._raterID = raterID;
    this._raterName = raterName;
  }

  public RaterInformationAttribute()
  {
  }

  public string RaterName => this._raterName;

  [SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId = "Member")]
  public int RaterID => this._raterID;

  public override bool Match(object obj) => obj is RaterInformationAttribute;
}

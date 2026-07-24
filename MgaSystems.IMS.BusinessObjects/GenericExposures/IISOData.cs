// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.GenericExposures.IISOData
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

#nullable disable
namespace MGASystems.BusinessObjects.GenericExposures;

public interface IISOData
{
  string ASLOB { get; }

  string Subline { get; }

  string ClassCode { get; }

  string ASLOBDescription { get; }

  string SublineDescription { get; }
}

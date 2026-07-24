// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.SystemDefinedInsuredContactNotFoundException
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using System;

#nullable disable
namespace MGASystems.BusinessObjects;

public class SystemDefinedInsuredContactNotFoundException : Exception
{
  private readonly string _systemDefinedCode;

  public SystemDefinedInsuredContactNotFoundException(string systemDefinedCode)
  {
    this._systemDefinedCode = systemDefinedCode;
  }

  public override string Message
  {
    get => $"The system defined insured contact for {this._systemDefinedCode} was not found.";
  }
}

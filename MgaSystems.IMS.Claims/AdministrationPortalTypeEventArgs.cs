// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.AdministrationPortalTypeEventArgs
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using System;

#nullable disable
namespace MGASystems.IMS.Claims;

public class AdministrationPortalTypeEventArgs : EventArgs
{
  private ClaimsAdministrationPortal.AdministrationPortalType _oldPortalType;
  private ClaimsAdministrationPortal.AdministrationPortalType _newPortalType;

  public AdministrationPortalTypeEventArgs(
    ClaimsAdministrationPortal.AdministrationPortalType oldType,
    ClaimsAdministrationPortal.AdministrationPortalType newType)
  {
    this._oldPortalType = oldType;
    this._newPortalType = newType;
  }

  public ClaimsAdministrationPortal.AdministrationPortalType OldPortalType => this._oldPortalType;

  public ClaimsAdministrationPortal.AdministrationPortalType NewPortalType => this._newPortalType;
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ViewLayoutEventArgs
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using System;

#nullable disable
namespace MGASystems.IMS.Claims;

public class ViewLayoutEventArgs : EventArgs
{
  private ClaimsAdministrationPortal.ViewType _oldViewType;
  private ClaimsAdministrationPortal.ViewType _newViewType;

  public ViewLayoutEventArgs(
    ClaimsAdministrationPortal.ViewType oldType,
    ClaimsAdministrationPortal.ViewType newType)
  {
    this._oldViewType = oldType;
    this._newViewType = newType;
  }

  public ClaimsAdministrationPortal.ViewType OldViewType => this._oldViewType;

  public ClaimsAdministrationPortal.ViewType NewViewType => this._newViewType;
}

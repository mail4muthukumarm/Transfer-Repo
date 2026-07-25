// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Security.AssertPermissionEventArgs
// Assembly: MgaSystems.IMS.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: A5FACEA8-628E-4FEB-97EB-CBBA0F666906
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Security.dll

using System;

#nullable disable
namespace MGASystems.IMS.Security;

public class AssertPermissionEventArgs : EventArgs
{
  private Guid _resourceGuid;
  private bool _granted;

  public AssertPermissionEventArgs(Guid resourceGuid, bool granted)
  {
    this._resourceGuid = resourceGuid;
    this._granted = granted;
  }

  public bool Granted => this._granted;

  public Guid ResourceGuid => this._resourceGuid;
}

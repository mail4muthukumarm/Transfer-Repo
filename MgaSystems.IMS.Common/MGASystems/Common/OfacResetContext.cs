// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.OfacResetContext
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;

#nullable disable
namespace MGASystems.Common;

public class OfacResetContext
{
  public Guid EntityGuid { get; }

  public Guid? ParentEntityGuid { get; }

  public bool ResetOfac { get; }

  public bool ResetHit { get; }

  public OfacResetContext(Guid ofacGuid, Guid? ofacParentGuid, bool ofac, bool hit)
  {
    this.EntityGuid = ofacGuid;
    this.ParentEntityGuid = ofacParentGuid;
    this.ResetOfac = ofac;
    this.ResetHit = hit;
  }
}

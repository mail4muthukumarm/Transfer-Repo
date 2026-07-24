// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.OfacClearContext
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;

#nullable disable
namespace MGASystems.Common;

public class OfacClearContext
{
  public Guid EntityGuid { get; }

  public Guid? ParentEntityGuid { get; }

  public Guid ClearUserGuid { get; }

  public DateTime? ClearDate { get; }

  public string ClearReasonText { get; }

  public int? ClearReasonID { get; }

  public string ClearNotes { get; }

  public OfacClearContext(
    Guid ofacGuid,
    Guid? ofacParentGuid,
    Guid clearUser,
    DateTime? dateCleared,
    string reason,
    int? reasonID,
    string notes)
  {
    this.EntityGuid = ofacGuid;
    this.ParentEntityGuid = ofacParentGuid;
    this.ClearUserGuid = clearUser;
    this.ClearDate = dateCleared;
    this.ClearReasonText = reason;
    this.ClearReasonID = reasonID;
    this.ClearNotes = notes;
  }
}

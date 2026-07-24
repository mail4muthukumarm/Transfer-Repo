// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.NoteAutomationRecipientManager
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using MGASystems.Common.DataAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class NoteAutomationRecipientManager
{
  [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
  public virtual List<Guid> ResolveAutomationRecipients(
    int recipientId,
    Guid controlGuid,
    Guid companyLineGuid,
    int quoteId)
  {
    return NoteAutomationRecipientManager.OnResolveAutomationRecipients(recipientId, controlGuid);
  }

  public virtual int GetRecipientType(
    List<PendingNote> noteList,
    Guid eventGuid,
    Guid controlGuid,
    Guid companyLineGuid,
    int quoteId)
  {
    return 1;
  }

  [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
  protected static List<Guid> OnResolveAutomationRecipients(int recipientId, Guid controlGuid)
  {
    List<Guid> guidList = new List<Guid>();
    switch (recipientId)
    {
      case 0:
        guidList.Add(Database.IsNull(RuntimeHelpers.GetObjectValue(Database.Instance.QueryText.PerformScalarQuery("SELECT TACSRUserGuid FROM dbo.tblQuotes (NOLOCK) WHERE (ControlGuid = @ControlGuid)", (object) "@ControlGuid", (object) controlGuid)), CurrentUser.Instance.UserGUID));
        break;
      case 1:
        guidList.Add(Database.Instance.QueryText.PerformScalarQueryGuid("SELECT UnderWriterUserGuid FROM dbo.tblQuotes (NOLOCK) WHERE (ControlGuid = @ControlGuid)", (object) "@ControlGuid", (object) controlGuid));
        break;
      case 2:
        guidList.Add(CurrentUser.Instance.UserGUID);
        break;
      case 5:
        guidList.Add(Database.IsNull(RuntimeHelpers.GetObjectValue(Database.Instance.QueryText.PerformScalarQuery("SELECT UnderWritingAssistantGuid FROM dbo.tblQuotes (NOLOCK) WHERE (ControlGuid = @ControlGuid)", (object) "@ControlGuid", (object) controlGuid)), CurrentUser.Instance.UserGUID));
        break;
    }
    return guidList;
  }
}

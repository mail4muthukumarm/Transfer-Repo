// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.NoteAutomationRecipientManager
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using System;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Claims;

[Override(typeof (NoteAutomationRecipientManager))]
public class NoteAutomationRecipientManager : NoteAutomationRecipientManager
{
  private const string INHOUSEADJUSTER = "select \t\tInhouseAdjuster \tfrom \t\ttblClaims_Claim \twhere \t\tClaimGuid = @ClaimGuid";

  public virtual List<Guid> ResolveAutomationRecipients(
    int recipientID,
    Guid controlGuid,
    Guid companyLineGuid,
    int quoteID)
  {
    return recipientID == 10 ? NoteAutomationRecipientManager.InternalResolveRecipients(controlGuid, "select \t\tInhouseAdjuster \tfrom \t\ttblClaims_Claim \twhere \t\tClaimGuid = @ClaimGuid") : base.ResolveAutomationRecipients(recipientID, controlGuid, companyLineGuid, quoteID);
  }

  private static List<Guid> InternalResolveRecipients(Guid claimGuid, string queryText)
  {
    return new List<Guid>()
    {
      Utility.IsNull<Guid>((object) DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, queryText, new object[2]
      {
        (object) "@ClaimGuid",
        (object) claimGuid
      }), CurrentUser.Instance.UserGUID)
    };
  }
}

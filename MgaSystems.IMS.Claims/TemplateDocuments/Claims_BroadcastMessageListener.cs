// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.TemplateDocuments.Claims_BroadcastMessageListener
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.Forms.BroadcastMessaging;
using MGASystems.IMS.NoteDocuments;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.TemplateDocuments;

[Override(typeof (BroadcastMessageListener))]
internal class Claims_BroadcastMessageListener : BroadcastMessageListener
{
  public new void ReceiveMessage(object sender, Messaging.MessageEventArgs e)
  {
    if (!(e.EventGuid == new Guid("{258FBE46-67CB-4059-8D07-E3E014CA210E}")) && !(e.EventGuid == new Guid("{6300B08D-A940-46ed-9B86-03D27EF14C5C}")) && !(e.EventGuid == new Guid("{C9573B52-04AF-47e7-AAED-62586FCB3576}")) && !(e.EventGuid == new Guid("{AE832DAE-49F6-4c57-BED9-3B19A0FBDCDC}")) && !(e.EventGuid == new Guid("{2369F1BA-5534-4DF7-8A1D-E72C370BB90B}")) && !(e.EventGuid == new Guid("{395AB552-44F5-4ca6-AAAF-7D5E07A8F726}")))
      return;
    NoteAutomation.FireEvent(e.EventGuid, new Guid(e.Context.ToString()), new int?());
    if (!e.Context.ToString().IsGuid())
      return;
    Guid guidFromClaimGuid = Utility.GetQuoteGuidFromClaimGuid(new Guid(e.Context.ToString()));
    if (!(guidFromClaimGuid != Guid.Empty))
      return;
    Claims_CompanyDocumentAutomation ca = new Claims_CompanyDocumentAutomation(new Quote(guidFromClaimGuid).CompanyLineGuid.Value, e);
    CompanyDocumentAutomation.Initialize();
    ca.SetQuoteGuid(guidFromClaimGuid);
    ca.SetClaimGuid(new Guid(e.Context.ToString()));
    ca.SetEventGuid(e.EventGuid);
    this.CreatePDFPackage((CompanyDocumentAutomation) ca);
  }
}

// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.TemplateDocuments.Claims_DocumentHandling
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.NoteDocuments;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.TemplateDocuments;

[Override(typeof (DocumentHandling))]
public class Claims_DocumentHandling(int templateId) : DocumentHandling(templateId)
{
  public override void SendToCurrentEntity(
    int automationGroup,
    int templateId,
    WordDocumentSavedEventArgs e,
    object[] args)
  {
    switch ((Utility.AutomationDocumentGroups) automationGroup)
    {
      case Utility.AutomationDocumentGroups.Claim:
        foreach (Form mdiChild in MDIControls.Instance.MDIParent.MdiChildren)
        {
          if (mdiChild is FormClaims)
          {
            DocumentHandling.SaveTemplateToDocumentHandler(templateId, e, (ISupportDocumentSystem) mdiChild, new Guid(args[0].ToString()));
            break;
          }
        }
        break;
      case Utility.AutomationDocumentGroups.Claimant:
        foreach (Form mdiChild in MDIControls.Instance.MDIParent.MdiChildren)
        {
          if (mdiChild is FormClaimant)
          {
            DocumentHandling.SaveTemplateToDocumentHandler(templateId, e, (ISupportDocumentSystem) mdiChild, new Guid(args[0].ToString()));
            break;
          }
        }
        break;
      default:
        base.SendToCurrentEntity(automationGroup, templateId, e, args);
        break;
    }
  }
}

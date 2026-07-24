// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.TemplateDocuments.Claims_CompanyDocumentAutomation
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Claims.TemplateDocuments;

[Override(typeof (CompanyDocumentAutomation))]
public class Claims_CompanyDocumentAutomation : CompanyDocumentAutomation
{
  private Guid _claimGuid;
  private Guid _eventGuid;

  public Claims_CompanyDocumentAutomation(Guid automationReportGuid)
    : base(automationReportGuid)
  {
  }

  public Claims_CompanyDocumentAutomation(int templateID)
    : base(templateID)
  {
  }

  public Claims_CompanyDocumentAutomation(byte[] pdf, string fileName)
    : base(pdf, fileName)
  {
  }

  public Claims_CompanyDocumentAutomation(Guid automationReportGuid, int placedByCompanyLineID)
    : base(automationReportGuid, placedByCompanyLineID)
  {
  }

  public Claims_CompanyDocumentAutomation(Guid companyLineGuid, Messaging.MessageEventArgs e)
    : base(companyLineGuid, e)
  {
  }

  public Claims_CompanyDocumentAutomation(int templateID, int placedByCompanyLineID)
    : base(templateID, placedByCompanyLineID)
  {
  }

  public Claims_CompanyDocumentAutomation(
    Guid companyLineGuid,
    Messaging.MessageEventArgs e,
    int printTypeID)
    : base(companyLineGuid, e, printTypeID)
  {
  }

  public Claims_CompanyDocumentAutomation(
    int templateID,
    int placedByCompanyLineID,
    int policyFormID)
    : base(templateID, placedByCompanyLineID, policyFormID)
  {
  }

  public Claims_CompanyDocumentAutomation(
    int templateID,
    int placedByCompanyLineID,
    int policyFormID,
    string oncePer)
    : base(templateID, placedByCompanyLineID, policyFormID, oncePer)
  {
  }

  public Claims_CompanyDocumentAutomation(AutomationDoc doc)
    : base(doc)
  {
  }

  public Guid ClaimGuid
  {
    get => this._claimGuid;
    set => this._claimGuid = value;
  }

  protected override void PerformPrePackagingOperations() => base.PerformPrePackagingOperations();

  public override object GetConstructorArgument(int automationDocGroup)
  {
    Utility.AutomationDocumentGroups automationDocumentGroups = (Utility.AutomationDocumentGroups) automationDocGroup;
    object constructorArgument = base.GetConstructorArgument(automationDocGroup);
    switch (automationDocumentGroups)
    {
      case Utility.AutomationDocumentGroups.Claim:
      case Utility.AutomationDocumentGroups.Claimant:
        constructorArgument = (object) this.ClaimGuid;
        break;
    }
    return constructorArgument;
  }

  public override void PackageCompleted(string fileName)
  {
    Quote quote = new Quote(this.QuoteGuid);
    int num = (int) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetDocumentFolder(@CompanyLineGuid,@AutomationEventGuid,@QuoteGuid)", new object[6]
    {
      (object) "@CompanyLineGuid",
      (object) quote.CompanyLineGuid,
      (object) "@AutomationEventGuid",
      (object) this._eventGuid,
      (object) "@QuoteGuid",
      (object) quote.QuoteGuid
    });
    for (int index = 0; index < MDIControls.Instance.MDIParent.MdiChildren.Length; ++index)
    {
      if ((MDIControls.Instance.MDIParent.MdiChildren[index].GetType() == typeof (FormClaims) || MDIControls.Instance.MDIParent.MdiChildren[index].GetType().IsSubclassOf(typeof (FormClaims))) && (MDIControls.Instance.MDIParent.MdiChildren[index] as FormClaims).CurrentClaim.ClaimGuid == this._claimGuid)
      {
        FormClaims mdiChild = MDIControls.Instance.MDIParent.MdiChildren[index] as FormClaims;
        DocumentManager.FileAddWithBind(fileName, num, string.Empty, (ISupportDocumentSystem) mdiChild, false);
        break;
      }
    }
    base.PackageCompleted(fileName);
  }

  public void SetQuoteGuid(Guid quoteGuid) => this.QuoteGuid = quoteGuid;

  public void SetClaimGuid(Guid claimGuid) => this._claimGuid = claimGuid;

  public void SetEventGuid(Guid eventGuid) => this._eventGuid = eventGuid;
}

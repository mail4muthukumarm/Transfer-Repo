// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.TemplateDocuments.Claims_TagParserFactory
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.TemplateDocuments;

[Override(typeof (TagParserFactory))]
public class Claims_TagParserFactory : TagParserFactory
{
  public override void GetAvailableTagList(int templateGroupID, dsTemplateDocs.TagsDataTable dt)
  {
    switch ((Utility.AutomationDocumentGroups) Enum.Parse(typeof (Utility.AutomationDocumentGroups), templateGroupID.ToString()))
    {
      case Utility.AutomationDocumentGroups.Claim:
        this.AddClaimTags(dt);
        this.AddClaimantTags(dt);
        break;
      case Utility.AutomationDocumentGroups.Claimant:
        this.AddClaimTags(dt);
        this.AddClaimantTags(dt);
        break;
      default:
        base.GetAvailableTagList(templateGroupID, dt);
        break;
    }
  }

  private void AddClaimTags(dsTemplateDocs.TagsDataTable dt)
  {
    dt.AddTagsRow("clm_number", "Claim Number", "Claims");
    dt.AddTagsRow("clm_carrier", "Claim Carrier", "Claims");
    dt.AddTagsRow("clm_policynumber", "Policy Number", "Claims");
    dt.AddTagsRow("clm_insuredname", "Insured Name", "Claims");
    dt.AddTagsRow("clm_insuredaddress", "Insured Address", "Claims");
    dt.AddTagsRow("clm_effective", "Policy Effective Date", "Claims");
    dt.AddTagsRow("clm_expiration", "Policy Expiration Date", "Claims");
    dt.AddTagsRow("loss_date", "Loss Date", "Claims");
    dt.AddTagsRow("clm_catcode", "Catastrophe Code", "Claims");
    dt.AddTagsRow("clm_totalreserves", "Total Reserves", "Claims");
    dt.AddTagsRow("clm_totalpayments", "Total Payments", "Claims");
    dt.AddTagsRow("clm_remreserves", "Remaining Reserves", "Claims");
    dt.AddTagsRow("clm_numberofclmnts", "Number Of Claimants", "Claims");
    dt.AddTagsRow("clm_accidentaddress", "Accident Location", "Claims");
    dt.AddTagsRow("clm_accidenttime", "Accident Time", "Claims");
    dt.AddTagsRow("clm_accidenttype", "Accident Type", "Claims");
    dt.AddTagsRow("clm_accidentdescription", "Accident Description", "Claims");
    dt.AddTagsRow("clm_adjustername", "Claim Adjuster Name", "Claims");
    dt.AddTagsRow("clm_producername", "Claim Producer Name", "Claims");
    dt.AddTagsRow("clm_produceraddress", "Claim Producer Address", "Claims");
    dt.AddTagsRow("clm_adjusternameemail", "Claim Adjuster Email", "Claims");
    dt.AddTagsRow("clm_adjusternamephone", "Claim Adjuster Phone Number", "Claims");
    dt.AddTagsRow("clm_adjusternamephoneext", "Claim Adjuster Phone Ext", "Claims");
    dt.AddTagsRow("clm_comments", "Claim Level Comments", "Claims");
    dt.AddTagsRow("clm_adjusternametitle", "Claim Adjuster Title", "Claims");
    dt.AddTagsRow("uaddress1", "User Address Street 1", "User");
    dt.AddTagsRow("uaddress2", "User Address Street 2", "User");
    dt.AddTagsRow("ucity", "User Address City", "User");
    dt.AddTagsRow("ucounty", "User Address County", "User");
    dt.AddTagsRow("uinit", "User Initials", "User");
    dt.AddTagsRow("uregion", "User Address Region", "User");
    dt.AddTagsRow("user_signature", "User Signature", "User");
    dt.AddTagsRow("useremail", "User Email", "User");
    dt.AddTagsRow("userext", "User Extension", "User");
    dt.AddTagsRow("userfax", "User Fax", "User");
    dt.AddTagsRow("username", "User name", "User");
    dt.AddTagsRow("userphone", "User Phone", "User");
    dt.AddTagsRow("usertitle", "User Title", "User");
    dt.AddTagsRow("ustate", "User Address State", "User");
    dt.AddTagsRow("uzipcode", "User Address Zip", "User");
    dt.AddTagsRow("uzipplus", "User AddressZip4", "User");
  }

  private void AddClaimantTags(dsTemplateDocs.TagsDataTable dt)
  {
    dt.AddTagsRow("clmt_name", "Claimant Name", "Claimant");
    dt.AddTagsRow("clmt_address", "Claimant Address", "Claimant");
    dt.AddTagsRow("clmt_mailingaddress", "Claimant Mailing Address", "Claimant");
    dt.AddTagsRow("clmt_dob", "Claimant DOB", "Claimant");
    dt.AddTagsRow("clmt_datereported", "Claimant Date Reported", "Claimant");
    dt.AddTagsRow("clmt_defattorney", "Defense Attorney", "Claimant");
    dt.AddTagsRow("clmt_lawfirm", "Claimant Law Firm", "Claimant");
    dt.AddTagsRow("clmt_attorney", "Claimant Attorney", "Claimant");
    dt.AddTagsRow("clmt_attorneyaddress", "Claimant Attorney Address", "Claimant");
    dt.AddTagsRow("clmt_outadjustername", "Claim Outside Adjuster Name", "Claimant");
    dt.AddTagsRow("clmt_number", "Claimant Number", "Claimant");
    dt.AddTagsRow("clmt_comments", "Claimant Comments", "Claimant");
    dt.AddTagsRow("clmt_losstype", "Claimant Loss Type", "Claimant");
    dt.AddTagsRow("clmt_addressphonenumbers", "Claimant Address Phone Number", "Claimant");
    dt.AddTagsRow("clmt_mailingaddressphonenumbers", "Claimant Mailing Address Phone Number", "Claimant");
    dt.AddTagsRow("clmt_email", "Claimant Email", "Claimant");
  }

  public override TagParserBase GetTagParser(int TemplateGroupID, params object[] args)
  {
    Guid guid;
    switch ((Utility.AutomationDocumentGroups) Enum.Parse(typeof (Utility.AutomationDocumentGroups), TemplateGroupID.ToString()))
    {
      case Utility.AutomationDocumentGroups.Claim:
        guid = !args[0].ToString().IsGuid() ? Guid.Empty : new Guid(args[0].ToString());
        break;
      case Utility.AutomationDocumentGroups.Claimant:
        guid = !args[0].ToString().IsGuid() ? Guid.Empty : Utility.GetClaimGuid(new Guid(args[0].ToString()));
        break;
      default:
        return base.GetTagParser(TemplateGroupID, args);
    }
    return (TagParserBase) ObjectFactory.Instance.CreateObject(typeof (Claims_PolicyTagParser), new object[1]
    {
      (object) guid
    });
  }
}

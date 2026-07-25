// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.TemplateDocuments.TagParserFactory
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Reporting.AutomationReports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.TemplateDocuments;

public class TagParserFactory : ITagParserFactory
{
  public virtual TagParserBase GetTagParser(int TemplateGroupID, params object[] args)
  {
    return TagParserFactory.GetTagParser((Enums.AutomationDocGroups) Enum.Parse(typeof (Enums.AutomationDocGroups), TemplateGroupID.ToString()), args);
  }

  private static TagParserBase GetTagParser(Enums.AutomationDocGroups group, params object[] args)
  {
    TagParserBase tagParser = (TagParserBase) null;
    switch (group)
    {
      case Enums.AutomationDocGroups.PolicyDoc:
        if (((IEnumerable<object>) args).Count<object>() == 1)
        {
          tagParser = (TagParserBase) ObjectFactory.Instance.CreateObjectEX(typeof (PolicyTagParser), typeof (TagParserBase), (object) (Guid) args[0]);
          break;
        }
        tagParser = (TagParserBase) ObjectFactory.Instance.CreateObjectEX(typeof (PolicyTagParser), typeof (TagParserBase), (object) (Guid) args[0], (object) (Guid) args[1]);
        break;
      case Enums.AutomationDocGroups.InvoiceDoc:
        tagParser = (TagParserBase) new InvoiceTagParser((int) args[0]);
        break;
      case Enums.AutomationDocGroups.SubmissionDoc:
        tagParser = (TagParserBase) new SubmissionTagParser((Guid) args[0]);
        break;
      case Enums.AutomationDocGroups.InsuredLocationDoc:
        tagParser = (TagParserBase) new InsuredLocationTagParser((Guid) args[0]);
        break;
      case Enums.AutomationDocGroups.DriverDoc:
        tagParser = (TagParserBase) new DriverInfoTagParser((long) args[0]);
        break;
      case Enums.AutomationDocGroups.AdditionalInterestDocuments:
        int num = (int) args[0];
        tagParser = (TagParserBase) new AdditionalInterestTagParser(num, AdditionalInterestTagParser.GetQuoteGuid(num));
        break;
    }
    return tagParser;
  }

  internal dsTemplateDocs.TagsDataTable GetAvailableTagList(int templateGroupID)
  {
    dsTemplateDocs.TagsDataTable dt = new dsTemplateDocs.TagsDataTable();
    this.GetAvailableTagList(templateGroupID, dt);
    return dt;
  }

  public virtual void GetAvailableTagList(int templateGroupID, dsTemplateDocs.TagsDataTable dt)
  {
    Enums.AutomationDocGroups automationDocGroups = (Enums.AutomationDocGroups) Enum.Parse(typeof (Enums.AutomationDocGroups), templateGroupID.ToString());
    ExcelDynamicTagManager dynamicTagManager = (ExcelDynamicTagManager) ObjectFactory.Instance.CreateObject(typeof (ExcelDynamicTagManager));
    switch (automationDocGroups)
    {
      case Enums.AutomationDocGroups.PolicyDoc:
        this.AddInsuredItems(dt);
        this.AddSubmissionItems(dt);
        this.AddPolicyItems(dt);
        DynamicTagManager.GetAvailableTagList(dt);
        dynamicTagManager.GetAvailableTagList(dt);
        if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("EnableDocuSign", false))
          ((DocuSignTagManager) ObjectFactory.Instance.CreateObject(typeof (DocuSignTagManager))).GetAvailableTagList(dt);
        TagParserFactory.AddQuoteOptionAvailableTags(dt);
        break;
      case Enums.AutomationDocGroups.InvoiceDoc:
        this.AddInsuredItems(dt);
        this.AddSubmissionItems(dt);
        this.AddPolicyItems(dt);
        DynamicTagManager.GetAvailableTagList(dt);
        dynamicTagManager.GetAvailableTagList(dt);
        if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("EnableDocuSign", false))
          ((DocuSignTagManager) ObjectFactory.Instance.CreateObject(typeof (DocuSignTagManager))).GetAvailableTagList(dt);
        TagParserFactory.AddQuoteOptionAvailableTags(dt);
        this.AddInvoiceItems(dt);
        break;
      case Enums.AutomationDocGroups.SubmissionDoc:
        this.AddInsuredItems(dt);
        this.AddSubmissionItems(dt);
        break;
      case Enums.AutomationDocGroups.InsuredLocationDoc:
        this.AddInsuredItems(dt);
        break;
      case Enums.AutomationDocGroups.DriverDoc:
        this.AddInsuredItems(dt);
        this.AddSubmissionItems(dt);
        this.AddPolicyItems(dt);
        DynamicTagManager.GetAvailableTagList(dt);
        dynamicTagManager.GetAvailableTagList(dt);
        if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("EnableDocuSign", false))
          ((DocuSignTagManager) ObjectFactory.Instance.CreateObject(typeof (DocuSignTagManager))).GetAvailableTagList(dt);
        TagParserFactory.AddQuoteOptionAvailableTags(dt);
        this.AddInvoiceItems(dt);
        this.AddDriverInfoItems(dt);
        break;
      case Enums.AutomationDocGroups.AdditionalInterestDocuments:
        this.AddInsuredItems(dt);
        this.AddSubmissionItems(dt);
        this.AddPolicyItems(dt);
        DynamicTagManager.GetAvailableTagList(dt);
        dynamicTagManager.GetAvailableTagList(dt);
        if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("EnableDocuSign", false))
          ((DocuSignTagManager) ObjectFactory.Instance.CreateObject(typeof (DocuSignTagManager))).GetAvailableTagList(dt);
        TagParserFactory.AddQuoteOptionAvailableTags(dt);
        this.AddInvoiceItems(dt);
        break;
    }
  }

  private static void AddQuoteOptionAvailableTags(dsTemplateDocs.TagsDataTable dt)
  {
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new QuoteOptionTagParserAttribute());
    int num = typeArray.Length - 1;
    for (int index = 0; index <= num; ++index)
      ((IQuoteOptionTagParser) ObjectFactory.Instance.CreateObject(typeArray[index], typeof (IQuoteOptionTagParser))).AddAvailableTags(dt);
  }

  protected void AddInsuredItems(dsTemplateDocs.TagsDataTable dt)
  {
    string name = new Client().Name;
    dsTemplateDocs.TagsDataTable tagsDataTable = dt;
    tagsDataTable.AddTagsRow("cinsfein", "Insured FEIN", "Insured");
    tagsDataTable.AddTagsRow("cinsdba", "Insured DBA", "Insured");
    tagsDataTable.AddTagsRow("cinsured", "Current Insured Name", "Insured");
    tagsDataTable.AddTagsRow("cinsadr", "Current Insured Address 1 and 2", "Insured");
    tagsDataTable.AddTagsRow("cinsadr1", "Current Insured Address 1", "Insured");
    tagsDataTable.AddTagsRow("cinsadr2", "Current Insured Address 2", "Insured");
    tagsDataTable.AddTagsRow("cinscity", "Current Insured City", "Insured");
    tagsDataTable.AddTagsRow("cinscounty", "Current Insured County", "Insured");
    tagsDataTable.AddTagsRow("cinscountry", "Current Insured Country", "Insured");
    tagsDataTable.AddTagsRow("cis", "Current Insured State", "Insured");
    tagsDataTable.AddTagsRow("cizc", "Current Insured Zip", "Insured");
    tagsDataTable.AddTagsRow("cizp", "Current Insured Zip 4", "Insured");
    tagsDataTable.AddTagsRow("cinsadrfull", "Current Insured Address Full", "Insured");
    tagsDataTable.AddTagsRow("cinsphone", "Current Insured Phone", "Insured");
    tagsDataTable.AddTagsRow("cinsmobilephone", "Current Insured Mobile Phone", "Insured");
    tagsDataTable.AddTagsRow("cinsemail", "Current Insured Email", "Insured");
    tagsDataTable.AddTagsRow("cinsfax", "Current Insured Fax", "Insured");
    tagsDataTable.AddTagsRow("insbustype", "Insured Business Type", "Insured");
    tagsDataTable.AddTagsRow("cinsconf", "Insured Contact (First)", "Insured");
    tagsDataTable.AddTagsRow("cinsconl", "Insured Contact (First)", "Insured");
    tagsDataTable.AddTagsRow("clossconf", "Insured Loss Control Contact (First)", "Insured");
    tagsDataTable.AddTagsRow("clossconl", "Insured Loss Control Contact (Last)", "Insured");
    tagsDataTable.AddTagsRow("primary_contact_first", "Primary Contact First", "Insured");
    tagsDataTable.AddTagsRow("primary_contact_last", "Primary Contact Last", "Insured");
    tagsDataTable.AddTagsRow("effdate_first_yr_written", "Effective date of the first year the insured was written", "Insured");
    tagsDataTable.AddTagsRow("insinspcontact_first", "Insured Inspection Contact (First)", "Insured");
    tagsDataTable.AddTagsRow("insinspcontact_last", "Insured Inspection Contact (Last)", "Insured");
    tagsDataTable.AddTagsRow("insinspcontact_phone", "Insured Inspection Contact Phone", "Insured");
    tagsDataTable.AddTagsRow("username", "User name", "User");
    tagsDataTable.AddTagsRow("usertitle", "User Title", "User");
    tagsDataTable.AddTagsRow("userphone", "User Phone", "User");
    tagsDataTable.AddTagsRow("userforeignphone", "User Foreign Phone", "User");
    tagsDataTable.AddTagsRow("userext", "User Extension", "User");
    tagsDataTable.AddTagsRow("userfax", "User Fax", "User");
    tagsDataTable.AddTagsRow("useremail", "User Email", "User");
    tagsDataTable.AddTagsRow("uinit", "User Initials", "User");
    tagsDataTable.AddTagsRow("user_signature", "User Signature", "User");
    tagsDataTable.AddTagsRow("uaddress1", "User Address Street 1", "User");
    tagsDataTable.AddTagsRow("uaddress2", "User Address Street 2", "User");
    tagsDataTable.AddTagsRow("ucity", "User Address City", "User");
    tagsDataTable.AddTagsRow("uzipcode", "User Address Zip", "User");
    tagsDataTable.AddTagsRow("uzipplus", "User Address Zip4", "User");
    tagsDataTable.AddTagsRow("ustate", "User Address State", "User");
    tagsDataTable.AddTagsRow("ucounty", "User Address County", "User");
    tagsDataTable.AddTagsRow("uregion", "User Address Region", "User");
    tagsDataTable.AddTagsRow("clientname", name, "Client");
    tagsDataTable.AddTagsRow("clientphone", name + " Phone", "Client");
    tagsDataTable.AddTagsRow("clientfax", name + " Fax", "Client");
    tagsDataTable.AddTagsRow("clientaddress1", name + " Address 1", "Client");
    tagsDataTable.AddTagsRow("clientaddress2", name + " Address 2", "Client");
    tagsDataTable.AddTagsRow("clientcity", name + " City", "Client");
    tagsDataTable.AddTagsRow("clientstate", name + " State", "Client");
    tagsDataTable.AddTagsRow("clientzip", name + " Zip", "Client");
    tagsDataTable.AddTagsRow("clientzip4", name + "Zip 4", "Client");
    tagsDataTable.AddTagsRow("now", "Today's Date/Time");
  }

  protected void AddSubmissionItems(dsTemplateDocs.TagsDataTable dt)
  {
    dsTemplateDocs.TagsDataTable tagsDataTable = dt;
    tagsDataTable.AddTagsRow("tacsrfs", "Submission TA/CSR - First", "Submissions");
    tagsDataTable.AddTagsRow("tacsrfl", "Submission TA/CSR - Last", "Submissions");
    tagsDataTable.AddTagsRow("tacsri", "Submission TA/CSR - Initials", "Submissions");
    tagsDataTable.AddTagsRow("producer", "Producer", "Producers");
    tagsDataTable.AddTagsRow("prodloc", "Producer Location", "Producers");
    tagsDataTable.AddTagsRow("submitted", "Submission Date", "Submissions");
    tagsDataTable.AddTagsRow("prodad1", "Producer Address 1", "Producers");
    tagsDataTable.AddTagsRow("prodad2", "Producer Address 2", "Producers");
    tagsDataTable.AddTagsRow("prodcity", "Producer City", "Producers");
    tagsDataTable.AddTagsRow("prodcounty", "Producer County", "Producers");
    tagsDataTable.AddTagsRow("ps", "Producer State", "Producers");
    tagsDataTable.AddTagsRow("pz", "Producer Zip", "Producers");
    tagsDataTable.AddTagsRow("pzp", "Producer Zip 4", "Producers");
    tagsDataTable.AddTagsRow("prodphone", "Producer Phone", "Producers");
    tagsDataTable.AddTagsRow("prodfax", "Producer Fax", "Producers");
    tagsDataTable.AddTagsRow("Prodlogo", "Producer Logo", "Producers");
  }

  protected void AddInvoiceItems(dsTemplateDocs.TagsDataTable dt)
  {
    dsTemplateDocs.TagsDataTable tagsDataTable = dt;
    tagsDataTable.AddTagsRow("invnum", "System Invoice Number", "Invoice");
    tagsDataTable.AddTagsRow("offinvnum", "Office Invoice Number", "Invoice");
    tagsDataTable.AddTagsRow("amount", "Invoice Amount (Premium + Fees)", "Invoice");
    tagsDataTable.AddTagsRow("invprem", "Invoice Premium", "Invoice");
    tagsDataTable.AddTagsRow("totalfees", "Invoice Fees", "Invoice");
    tagsDataTable.AddTagsRow("due", "Due Date", "Invoice");
    tagsDataTable.AddTagsRow("invnetdue", "Invoice Net Due", "Invoice");
  }

  protected void AddDriverInfoItems(dsTemplateDocs.TagsDataTable dt)
  {
    string group = "Driver Info";
    dsTemplateDocs.TagsDataTable tagsDataTable = dt;
    tagsDataTable.AddTagsRow(DriverInfoTags.LicenseNo.Name, DriverInfoTags.LicenseNo.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.FirstName.Name, DriverInfoTags.FirstName.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.LastName.Name, DriverInfoTags.LastName.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.Comments.Name, DriverInfoTags.Comments.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.DOB.Name, DriverInfoTags.DOB.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.Status.Name, DriverInfoTags.Status.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.State.Name, DriverInfoTags.State.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.NoPoints.Name, DriverInfoTags.NoPoints.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.Deleted.Name, DriverInfoTags.Deleted.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.Added.Name, DriverInfoTags.Added.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.FullOrPartTime.Name, DriverInfoTags.FullOrPartTime.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.LicenseExp.Name, DriverInfoTags.LicenseExp.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.MedicalExp.Name, DriverInfoTags.MedicalExp.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.RatingFactor.Name, DriverInfoTags.RatingFactor.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.LicenseClass.Name, DriverInfoTags.LicenseClass.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.CDL.Name, DriverInfoTags.CDL.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.MVR.Name, DriverInfoTags.MVR.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.Street1.Name, DriverInfoTags.Street1.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.Street2.Name, DriverInfoTags.Street2.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.City.Name, DriverInfoTags.City.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.ZipCode.Name, DriverInfoTags.ZipCode.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.FurnishedCar.Name, DriverInfoTags.FurnishedCar.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.CopyRenewql.Name, DriverInfoTags.CopyRenewql.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.NoFaultAcc.Name, DriverInfoTags.NoFaultAcc.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.NoOtherAcc.Name, DriverInfoTags.NoOtherAcc.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.SpeedLT10.Name, DriverInfoTags.SpeedLT10.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.SpeedGT10.Name, DriverInfoTags.SpeedGT10.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.SecViolation.Name, DriverInfoTags.SecViolation.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.EquipViolation.Name, DriverInfoTags.EquipViolation.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.OtherViolation.Name, DriverInfoTags.OtherViolation.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.TotalViolations.Name, DriverInfoTags.TotalViolations.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.HireDate.Name, DriverInfoTags.HireDate.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.OrigCDLDate.Name, DriverInfoTags.OrigCDLDate.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.YearsTruckExp.Name, DriverInfoTags.YearsTruckExp.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.DriverExcluded.Name, DriverInfoTags.DriverExcluded.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.Recipient.Name, DriverInfoTags.Recipient.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.Subject.Name, DriverInfoTags.Subject.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.DaysDue.Name, DriverInfoTags.DaysDue.Description, group);
    tagsDataTable.AddTagsRow(DriverInfoTags.Body.Name, DriverInfoTags.Body.Description, group);
  }

  protected void AddPolicyItems(dsTemplateDocs.TagsDataTable dt)
  {
    dsTemplateDocs.TagsDataTable tagsDataTable = dt;
    tagsDataTable.AddTagsRow("forms", "Policy Forms - Comma Separated", "Forms");
    tagsDataTable.AddTagsRow("forms-showonquote", "Policy Forms(ShowOnQuote) - Comma Separated", "Forms");
    tagsDataTable.AddTagsRow("forms-crlf", "Policy Forms - Line Separated", "Forms");
    tagsDataTable.AddTagsRow("forms-editdate-crlf", "Policy Forms Edit Date - Line Separated", "Forms");
    tagsDataTable.AddTagsRow("formnumbers", "Policy Form Numbers - Comma Separated", "Forms");
    tagsDataTable.AddTagsRow("formnumbers-crlf", "Policy Form Numbers - Line Separated", "Forms");
    tagsDataTable.AddTagsRow("forms-crlf-number-name", "Policy Form Numbers Then Names - Line Separated", "Forms");
    tagsDataTable.AddTagsRow("forms-crlf-number-slash-name", "Policy Form Numbers Then Slash Then Names - Line Separated", "Forms");
    tagsDataTable.AddTagsRow("forms-crlf-number-name-showonquote", "Policy Form Numbers Then Names(Show On Quote)- Line Separated", "Forms");
    tagsDataTable.AddTagsRow("forms-number-name", "Policy Form Numbers Then Names - Comma Separated", "Forms");
    tagsDataTable.AddTagsRow("forms-crlf-name-number", "Policy Form Names Then Numbers - Line Separated", "Forms");
    tagsDataTable.AddTagsRow("forms-crlf-name-number-showonquote", "Policy Form Names Then Numbers (Show On Quote) - Line Separated", "Forms");
    tagsDataTable.AddTagsRow("forms-name-number", "Policy Form Names Then Numbers - Comma Separated", "Forms");
    tagsDataTable.AddTagsRow("forms-name-number-table", "Policy Form Names Then Numbers - Table", "Forms");
    tagsDataTable.AddTagsRow("forms-endorse-number-name-edit-table", "Policy Form Endorsement No - Number - Names - Edition Table", "Forms");
    tagsDataTable.AddTagsRow("forms-number-edit-name-table", "Policy Form Number - Edition - Names Table", "Forms");
    tagsDataTable.AddTagsRow("forms-number-name-table", "Policy Form Numbers Then Names - Table", "Forms");
    tagsDataTable.AddTagsRow("forms-number-name-table-marknew", "Policy Form Numbers Then Names - Table(mark as new)", "Forms");
    tagsDataTable.AddTagsRow("forms-number-name-table-wrap", "Policy Form Numbers Then Wrapped Names - Table", "Forms");
    tagsDataTable.AddTagsRow("forms_count", "# of Policy Form selected/applied to policy", "Forms");
    tagsDataTable.AddTagsRow("forms-endorsement-number", "Form Endorsement Number", "Forms");
    tagsDataTable.AddTagsRow("forms-endorsement-number-fcw", "Form Endorsement Number(End# in FCW GUI)", "Forms");
    tagsDataTable.AddTagsRow("forms-number-endorsement-fcw", "Form name", "Forms");
    tagsDataTable.AddTagsRow("forms-comment-fcw", "Form comment", "Forms");
    tagsDataTable.AddTagsRow("warranties", "Policy Warranties", "Warranties");
    tagsDataTable.AddTagsRow("warranties-crlf", "Policy Warranties - Line Separated", "Warranties");
    tagsDataTable.AddTagsRow("conditions", "Policy Conditions", "Conditions");
    tagsDataTable.AddTagsRow("conditions-crlf", "Policy Conditions - Line Separated", "Conditions");
    tagsDataTable.AddTagsRow("premium", "Policy Premium", "Premium and Fees");
    tagsDataTable.AddTagsRow("premium-return", "Policy Return Premium", "Premium and Fees");
    tagsDataTable.AddTagsRow("premium-additional", "Policy Additional Premium", "Premium and Fees");
    tagsDataTable.AddTagsRow("premiumfees-return", "Policy Return Premium and Fees", "Premium and Fees");
    tagsDataTable.AddTagsRow("premiumfees-additional", "Policy Additional Premium and Fees", "Premium and Fees");
    tagsDataTable.AddTagsRow("fees-return", "Policy Return Fees", "Premium and Fees");
    tagsDataTable.AddTagsRow("fees-additional", "Policy Additional Fees", "Premium and Fees");
    tagsDataTable.AddTagsRow("premium-without-tria", "Policy Premium without terrorism", "Premium and Fees");
    tagsDataTable.AddTagsRow("bound_terrorism_premium", "Total Bound Terrorism Premium", "Premium and Fees");
    tagsDataTable.AddTagsRow("quoted_terrorism_premium", "Total Quoted Terrorism Premium", "Premium and Fees");
    tagsDataTable.AddTagsRow("bound_fees", "Total Bound Fees", "Premium and Fees");
    tagsDataTable.AddTagsRow("policy_fees", "Policy Fees Only", "Premium and Fees");
    tagsDataTable.AddTagsRow("inspection_fees", "Inspection Fees Only", "Premium and Fees");
    tagsDataTable.AddTagsRow("policy_and_inspection_fees", "Policy and Inspection Fees Only", "Premium and Fees");
    tagsDataTable.AddTagsRow("quoted_fees", "Total Fees", "Premium and Fees");
    tagsDataTable.AddTagsRow("bound_taxes_only", "Total Bound Taxes", "Premium and Fees");
    tagsDataTable.AddTagsRow("quoted_taxes_only", "Total Taxes", "Premium and Fees");
    tagsDataTable.AddTagsRow("bound_nontaxes_only", "Total Bound Non-Taxes", "Premium and Fees");
    tagsDataTable.AddTagsRow("bound_premiumandfees", "Total Bound Premium & Fees(policy level)", "Premium and Fees");
    tagsDataTable.AddTagsRow("quoted_nontaxes_only", "Total Non-Taxes", "Premium and Fees");
    tagsDataTable.AddTagsRow("quotedpremiumandfees", "Sum of the premium and fees of options that are marked as Quoted", "Premium and Fees");
    tagsDataTable.AddTagsRow("feelisting", "List of Policy Fees", "Premium and Fees");
    tagsDataTable.AddTagsRow("feelisting_linebreaks", "List of bound Policy Fees with a line break between each", "Premium and Fees");
    tagsDataTable.AddTagsRow("feelisting_linebreaks_showall", "List of all Policy Fees with a line break between each", "Premium and Fees");
    tagsDataTable.AddTagsRow("totalpremiumandfees", "Total Invoiced Premium and Fees", "Premium and Fees");
    tagsDataTable.AddTagsRow("feesandpremiums", "Listing of Fees and Premiums with a total", "Premium and Fees");
    tagsDataTable.AddTagsRow("feesandpremiums_v2", "Listing of Fees and Premiums with a total, v2 to fix spacing", "Premium and Fees");
    tagsDataTable.AddTagsRow("feesandpremiums_table", "Table of Fees and Premiums with a total", "Premium and Fees");
    tagsDataTable.AddTagsRow("optionpremiums", "Listing of Option Premiums", "Premium and Fees");
    tagsDataTable.AddTagsRow("boundoptionpremiums", "Listing of Bound Option Premiums", "Premium and Fees");
    tagsDataTable.AddTagsRow("minearnpct-desc", "Minimum Earned Percent with Description", "Premium and Fees");
    tagsDataTable.AddTagsRow("minearnpct", "Minimum Earned Percent", "Premium and Fees");
    tagsDataTable.AddTagsRow("earnedpremiumtype", "Earned Premium Type", "Premium and Fees");
    tagsDataTable.AddTagsRow("feelisting_linebreaks_namefirst", "List of bound Policy Fees, names first, with a line break between each", "Premium and Fees");
    tagsDataTable.AddTagsRow("feelisting_namefirst", "List of Policy Fees with fee names first", "Premium and Fees");
    tagsDataTable.AddTagsRow("feelisting_linebreaks_showall_namefirst", "List of all Policy Fees, with fee names first, with a line break between each", "Premium and Fees");
    tagsDataTable.AddTagsRow("endorsement_premium", "Displays premium only when current transaction is an endorsement", "Premium and Fees");
    tagsDataTable.AddTagsRow("total_indicated_premium", "Displays the sum of the premium from all options", "Premium and Fees");
    tagsDataTable.AddTagsRow("total_indicated_fees", "Displays the sum of the fees from all options", "Premium and Fees");
    tagsDataTable.AddTagsRow("total_billed_premium", "Displays the sum of the billed premium from all options", "Premium and Fees");
    tagsDataTable.AddTagsRow("fee_rates_table", "Displays table fee name and percentage", "Premium and Fees");
    tagsDataTable.AddTagsRow("pmnt_schd_wo_dnpayment_table", "Displays table PaymentSchedule w/o DownPayment", "Premium and Fees");
    tagsDataTable.AddTagsRow("insurerquotashare_table", "Table of Insurer Quota Share(Insurer, Policy#, Quote Share%)", "Multi Carrier Rater");
    tagsDataTable.AddTagsRow("insurerquotashare_table_a", "Table of Insurer Quota Share(Insurer, Policy#)", "Multi Carrier Rater");
    tagsDataTable.AddTagsRow("insurerquotashare_table_b", "Table of Insurer Quota Share(Insurer, Policy#, Endorsement#, Endorsement EffectiveDate)", "Multi Carrier Rater");
    tagsDataTable.AddTagsRow("insurerquotashare_table_c", "Table of Insurer Quota Share(Policy#, PCF PCL and Producer#, Insurer)", "Multi Carrier Rater");
    tagsDataTable.AddTagsRow("effective", "Effective Date", "Policy");
    tagsDataTable.AddTagsRow("issueddate", "Issued  Date", "Policy");
    tagsDataTable.AddTagsRow("expiration", "Expiration Date", "Policy");
    tagsDataTable.AddTagsRow("polnum", "Policy Number", "Policy");
    tagsDataTable.AddTagsRow("exppolnum", "Previous Policy Number", "Policy");
    tagsDataTable.AddTagsRow("controlno", "Control #", "Policy");
    tagsDataTable.AddTagsRow("non_renewed", "Non-Renewed Policy", "Policy", true);
    tagsDataTable.AddTagsRow("account_number", "Account #", "Policy");
    tagsDataTable.AddTagsRow("quoteid", "Quote ID", "Policy");
    tagsDataTable.AddTagsRow("createddate", "Created Date", "Policy");
    tagsDataTable.AddTagsRow("boundyn", "Bound Y/N", "Policy");
    tagsDataTable.AddTagsRow("billing_type", "Billing Type", "Policy");
    tagsDataTable.AddTagsRow("uwat", "Underwriter Assistant - Title", "Policy");
    tagsDataTable.AddTagsRow("uwaf", "Underwriter Assistant - First", "Policy");
    tagsDataTable.AddTagsRow("uwal", "Underwriter Assistant - Last", "Policy");
    tagsDataTable.AddTagsRow("uwa_email", "Underwriter Assistant - Email", "Policy");
    tagsDataTable.AddTagsRow("uwa_homeemail", "Underwriter Assistant - Home Email", "Policy");
    tagsDataTable.AddTagsRow("uwa_signature", "Underwriter Assistant - Signature", "Policy");
    tagsDataTable.AddTagsRow("uwa_phone", "Underwriter Assistant - Phone", "Policy");
    tagsDataTable.AddTagsRow("uwa_phoneExtension", "Underwriter Assistant - Phone Extension", "Policy");
    tagsDataTable.AddTagsRow("uwa_fax", "Underwriter Assistant - Fax", "Policy");
    tagsDataTable.AddTagsRow("uwa_initials", "Underwriter Assistant - Initials", "Policy");
    tagsDataTable.AddTagsRow("quotestatuscomment", "Quote Status Comments", "Policy");
    tagsDataTable.AddTagsRow("riskdesc", "Quote Risk Description", "Policy");
    tagsDataTable.AddTagsRow("policy_sic_code", "Policy SIC_CODE", "Policy");
    tagsDataTable.AddTagsRow("sic-desc", "SIC Description", "Policy");
    tagsDataTable.AddTagsRow("auditable", "'Subject to Audit' or 'Non Auditable'", "Policy");
    tagsDataTable.AddTagsRow("policy_paymentplan", "Policy Payment Plan Description", "Policy");
    tagsDataTable.AddTagsRow("rated_locations", "Rated Location Addresses", "Policy");
    tagsDataTable.AddTagsRow("stateid", "Policy State", "Policy");
    tagsDataTable.AddTagsRow("policytype", "Policy Type", "Policy");
    tagsDataTable.AddTagsRow("quotestatus", "Quote Status", "Policy");
    tagsDataTable.AddTagsRow("quotestatusreason", "Quote Status Reason", "Policy");
    tagsDataTable.AddTagsRow("uwt", "Underwriter - Title", "Policy");
    tagsDataTable.AddTagsRow("uwf", "Underwriter - First", "Policy");
    tagsDataTable.AddTagsRow("uwl", "Underwriter - Last", "Policy");
    tagsDataTable.AddTagsRow("uwi", "Underwriter - Initials", "Policy");
    tagsDataTable.AddTagsRow("ufax", "Underwriter Fax #", "Policy");
    tagsDataTable.AddTagsRow("uphone", "Underwriter Phone #", "Policy");
    tagsDataTable.AddTagsRow("uext", "Underwriter Phone Extension", "Policy");
    tagsDataTable.AddTagsRow("underwriteremail", "Underwriter E-mail Address", "Policy");
    tagsDataTable.AddTagsRow("underwriter_homeemail", "Underwriter Home E-mail Address", "Policy");
    tagsDataTable.AddTagsRow("underwriteraddress", "Underwriter Location Address", "Policy");
    tagsDataTable.AddTagsRow("underwriter_signature", "Underwriter Signature", "Policy");
    tagsDataTable.AddTagsRow("ucellphone", "Underwriter Cell Phone #", "Policy");
    tagsDataTable.AddTagsRow("tacsrfq", "Policy TA/CSR - First", "Policy");
    tagsDataTable.AddTagsRow("tacsrlq", "Policy TA/CSR - Last", "Policy");
    tagsDataTable.AddTagsRow("csrphone", "CSR/TA Phone #", "Policy");
    tagsDataTable.AddTagsRow("csrfax", "CSR/TA Fax #", "Policy");
    tagsDataTable.AddTagsRow("csrext", "CSR/TA Phone Extension", "Policy");
    tagsDataTable.AddTagsRow("csremail", "CSR/TA Email Address", "Policy");
    tagsDataTable.AddTagsRow("csr_homeemail", "CSR/TA Home Email Address", "Policy");
    tagsDataTable.AddTagsRow("csri", "CSR/TA Initials", "Policy");
    tagsDataTable.AddTagsRow("csr_title", "CSR/TA Title", "Policy");
    tagsDataTable.AddTagsRow("csr_signature", "CSR/TA Signature", "Policy");
    tagsDataTable.AddTagsRow("pol_dp", "Installment Billing - Downpayment Amount (Policy Level)", "Policy");
    tagsDataTable.AddTagsRow("pol_dpp", "Installment Billing - Downpayment % (Policy Level)", "Policy");
    tagsDataTable.AddTagsRow("pol_np", "Installment Billing - # Payments (Policy Level)", "Policy");
    tagsDataTable.AddTagsRow("pol_dpandfees", "Installment Billing - Downpayment Amount Plus Fees(Policy Level)", "Policy");
    tagsDataTable.AddTagsRow("lineofbusiness", "Line of business", "Policy");
    tagsDataTable.AddTagsRow("mgacommission", "MGA Commission", "Policy");
    tagsDataTable.AddTagsRow("binderexpirationdate", "Binder Expiration Date", "Policy");
    tagsDataTable.AddTagsRow("paymentschedule", "Payment Schedule", "Policy");
    tagsDataTable.AddTagsRow("llc", "Returns 'X' if Policies Business Type is LLC", "Policy");
    tagsDataTable.AddTagsRow("corp", "Returns 'X' if Policies Business Type is Corporation", "Policy");
    tagsDataTable.AddTagsRow("individual", "Returns 'X' if Policies Business Type is Individual", "Policy");
    tagsDataTable.AddTagsRow("jv", "Returns 'X' if Policies Business Type is JV", "Policy");
    tagsDataTable.AddTagsRow("trust", "Returns 'X' if Policies Business Type is Trust", "Policy");
    tagsDataTable.AddTagsRow("partner", "Returns 'X' if Policies Business Type is Partner", "Policy");
    tagsDataTable.AddTagsRow("other", "Returns 'X' if Policies Business Type is Other", "Policy");
    tagsDataTable.AddTagsRow("limitedpartnership", "Returns 'X' if Policies Business Type is Limited Partnership", "Policy");
    tagsDataTable.AddTagsRow("insured", "Insured Name on Policy", "Insured");
    tagsDataTable.AddTagsRow("insureddba", "Insured DBA on Policy", "Insured");
    tagsDataTable.AddTagsRow("insureddba_withdba", "If DBA exist, return 'DBA' + Insured DBA on Policy", "Insured");
    tagsDataTable.AddTagsRow("insadr", "Insured Address 1 and 2 on Policy", "Insured");
    tagsDataTable.AddTagsRow("insadr1", "Insured Address 1 on Policy", "Insured");
    tagsDataTable.AddTagsRow("insadr2", "Insured Address 2 on Policy", "Insured");
    tagsDataTable.AddTagsRow("inscity", "Insured City on Policy", "Insured");
    tagsDataTable.AddTagsRow("inscounty", "Insured County on Policy", "Insured");
    tagsDataTable.AddTagsRow("insadrfull", "Insured Address Full on Policy", "Insured");
    tagsDataTable.AddTagsRow("insadrwithcountry", "Insured Address Full on Policy with Full Country Name", "Insured");
    tagsDataTable.AddTagsRow("insbusclass", "Insured Business Class", "Insured");
    tagsDataTable.AddTagsRow("is", "Insured State on Policy", "Insured");
    tagsDataTable.AddTagsRow("izc", "Insured Zip on Policy", "Insured");
    tagsDataTable.AddTagsRow("izp", "Insured Zip 4 on Policy", "Insured");
    tagsDataTable.AddTagsRow("insphone", "Insured Phone on Policy", "Insured");
    tagsDataTable.AddTagsRow("insmobilephone", "Insured Mobile Phone on Policy", "Insured");
    tagsDataTable.AddTagsRow("insemail", "Insured Email on Policy", "Insured");
    tagsDataTable.AddTagsRow("insfax", "Insured Fax on Policy", "Insured");
    tagsDataTable.AddTagsRow("insnum", "Insured Number", "Insured");
    tagsDataTable.AddTagsRow("ins_fullAddress", "Insured's Full Address", "Insured");
    tagsDataTable.AddTagsRow("ins_billingaddress", "Insured's Billing Address", "Insured");
    tagsDataTable.AddTagsRow("ins_billingaddress1", "Insured's Billing Address1", "Insured");
    tagsDataTable.AddTagsRow("ins_billingaddress2", "Insured's Billing Address2", "Insured");
    tagsDataTable.AddTagsRow("ins_billingcity", "Insured's Billing City", "Insured");
    tagsDataTable.AddTagsRow("ins_billingstate", "Insured's Billing State", "Insured");
    tagsDataTable.AddTagsRow("ins_billingzip", "Insured's Billing Zip Code", "Insured");
    tagsDataTable.AddTagsRow("ins_fullAddr_oneln", "Insured's Full Address printed on one line", "Insured");
    tagsDataTable.AddTagsRow("ins_taxid", "Insured's Tax ID", "Insured");
    tagsDataTable.AddTagsRow("ins_dob", "Insured's Date of Birth", "Insured");
    tagsDataTable.AddTagsRow("cmpnycntct_salutation", "Company Contact Salutation", "Companies");
    tagsDataTable.AddTagsRow("cmpnycntct_fname", "Company Contact First Name", "Companies");
    tagsDataTable.AddTagsRow("cmpnycntct_lname", "Company Contact Last Name", "Companies");
    tagsDataTable.AddTagsRow("cmpnycntct_title", "Company Contact Title", "Companies");
    tagsDataTable.AddTagsRow("cmpnycntct_phone", "Company Contact Phone", "Companies");
    tagsDataTable.AddTagsRow("cmpnycntct_ext", "Company Contact Extension", "Companies");
    tagsDataTable.AddTagsRow("cmpnycntct_cell", "Company Contact Cell", "Companies");
    tagsDataTable.AddTagsRow("cmpnycntct_fax", "Company Contact Fax", "Companies");
    tagsDataTable.AddTagsRow("cmpnycntct_email", "Company Contact Email", "Companies");
    tagsDataTable.AddTagsRow("cmpnycntct_ncci", "Company Contact NCCI", "Companies");
    tagsDataTable.AddTagsRow("cl", "Company Location", "Companies");
    tagsDataTable.AddTagsRow("clad1", "Company Location - Address 1", "Companies");
    tagsDataTable.AddTagsRow("clad2", "Company Location - Address 2", "Companies");
    tagsDataTable.AddTagsRow("clcity", "Company Location - City", "Companies");
    tagsDataTable.AddTagsRow("clcounty", "Company Location - County", "Companies");
    tagsDataTable.AddTagsRow("cls", "Company Location - State", "Companies");
    tagsDataTable.AddTagsRow("clzip", "Company Location - Zip", "Companies");
    tagsDataTable.AddTagsRow("clzp", "Company Location - Zip 4", "Companies");
    tagsDataTable.AddTagsRow("clphone", "Company Location - Phone", "Companies");
    tagsDataTable.AddTagsRow("clfax", "Company Location - Fax", "Companies");
    tagsDataTable.AddTagsRow("clclaimphone", "Company Location - Claim Phone", "Companies");
    tagsDataTable.AddTagsRow("clclaimfax", "Company Location - Claim Fax", "Companies");
    tagsDataTable.AddTagsRow("clregion", "Company Location - Region", "Companies");
    tagsDataTable.AddTagsRow("clc", "Company Location Code", "Companies");
    tagsDataTable.AddTagsRow("clcode", "Custom Company Location Code", "Companies");
    tagsDataTable.AddTagsRow("minearn", "Minimum Earned %", "Companies");
    tagsDataTable.AddTagsRow("company", "Company", "Companies");
    tagsDataTable.AddTagsRow("compcom", "Company Composite Commission %", "Companies");
    tagsDataTable.AddTagsRow("company_strength", "Company Strength", "Companies");
    tagsDataTable.AddTagsRow("company_size", "Company Size", "Companies");
    tagsDataTable.AddTagsRow("company_naic", "Company NAIC", "Companies");
    tagsDataTable.AddTagsRow("company_fulladdress", "Company Full Address", "Companies");
    tagsDataTable.AddTagsRow("finance_company_name", "Finance Company Name", "Companies");
    tagsDataTable.AddTagsRow("finance_company_fulladdress", "Finance Company Full Address", "Companies");
    tagsDataTable.AddTagsRow("cpny_line_signature", "Company Line Authorized Rep Signature", "Companies");
    tagsDataTable.AddTagsRow("cpny_line_signature_secretary", "Company Line Authorized Rep Signature(Secretary)", "Companies");
    tagsDataTable.AddTagsRow("cpny_line_signature_ceo", "Company Line Signature(CEO)", "Companies");
    tagsDataTable.AddTagsRow("cpny_line_signature_ceo_name", "Company Line Signature(CEO) Name", "Companies");
    tagsDataTable.AddTagsRow("cpny_line_signature_endorsement", "Company Line Authorized Rep Signature(endorsement)", "Companies");
    tagsDataTable.AddTagsRow("cpny_line_signature_name", "Company Line Signature Name", "Companies");
    tagsDataTable.AddTagsRow("cpny_line_signature_title", "Company Line Signature Title", "Companies");
    tagsDataTable.AddTagsRow("company_rating_bureau", "Company Rating Bureau", "Companies");
    tagsDataTable.AddTagsRow("admitted_or_nonadmitted", "Company/Line - Admitted / Non-Admitted", "Companies");
    tagsDataTable.AddTagsRow("company_logo", "Company Logo", "Companies");
    tagsDataTable.AddTagsRow("company_surplusfl", "Returns d/b/a Homesite Assurance Company", "Companies");
    tagsDataTable.AddTagsRow("intermediary_name", "Intermediary Info - Intermediary Name", "Companies");
    tagsDataTable.AddTagsRow("intermediary_address1", "Intermediary Info - Address 1", "Companies");
    tagsDataTable.AddTagsRow("intermediary_address2", "Intermediary Info - Address 2", "Companies");
    tagsDataTable.AddTagsRow("intermediary_city", "Intermediary Info - City", "Companies");
    tagsDataTable.AddTagsRow("intermediary_state", "Intermediary Info - State", "Companies");
    tagsDataTable.AddTagsRow("intermediary_zipcode", "Intermediary Info - Zip Code", "Companies");
    tagsDataTable.AddTagsRow("intermediary_phone", "Intermediary Info - Phone", "Companies");
    tagsDataTable.AddTagsRow("intermediary_email", "Intermediary Info - Email", "Companies");
    tagsDataTable.AddTagsRow("ql", "Quoting Location", "Quoting Location");
    tagsDataTable.AddTagsRow("qla1", "Quoting Location - Address 1", "Quoting Location");
    tagsDataTable.AddTagsRow("qla2", "Quoting Location - Address 2", "Quoting Location");
    tagsDataTable.AddTagsRow("qlc", "Quoting Location - City", "Quoting Location");
    tagsDataTable.AddTagsRow("qlcnt", "Quoting Location - County", "Quoting Location");
    tagsDataTable.AddTagsRow("qls", "Quoting Location - State", "Quoting Location");
    tagsDataTable.AddTagsRow("qlp", "Quoting Location - Phone", "Quoting Location");
    tagsDataTable.AddTagsRow("qlf", "Quoting Location - Fax", "Quoting Location");
    tagsDataTable.AddTagsRow("qlz", "Quoting Location - Zip", "Quoting Location");
    tagsDataTable.AddTagsRow("qlzp", "Quoting Location - Zip 4", "Quoting Location");
    tagsDataTable.AddTagsRow("qlemail", "Quoting Location - Email", "Quoting Location");
    tagsDataTable.AddTagsRow("ql_fulladdress", "Quoting Location Full Address", "Quoting Location");
    tagsDataTable.AddTagsRow("quoting_office_dba", "Quoting Office's DBA", "Quoting Location");
    tagsDataTable.AddTagsRow("quoting_office_license_num", "Quoting Office's License Number", "Quoting Location");
    tagsDataTable.AddTagsRow("quoting_user_license_num", "Quoting User's License Number", "Quoting Location");
    tagsDataTable.AddTagsRow("qllogo", "Quoting Location Logo", "Quoting Location");
    tagsDataTable.AddTagsRow("il", "Issuing Location", "Issuing Location");
    tagsDataTable.AddTagsRow("ila1", "Issuing Location - Address 1", "Issuing Location");
    tagsDataTable.AddTagsRow("ila2", "Issuing Location - Address 2", "Issuing Location");
    tagsDataTable.AddTagsRow("ilc", "Issuing Location - City", "Issuing Location");
    tagsDataTable.AddTagsRow("ilcnt", "Issuing Location - County", "Issuing Location");
    tagsDataTable.AddTagsRow("ils", "Issuing Location - State", "Issuing Location");
    tagsDataTable.AddTagsRow("ilp", "Issuing Location - Phone", "Issuing Location");
    tagsDataTable.AddTagsRow("ilf", "Issuing Location - Fax", "Issuing Location");
    tagsDataTable.AddTagsRow("ilz", "Issuing Location - Zip", "Issuing Location");
    tagsDataTable.AddTagsRow("ilzp", "Issuing Location - Zip 4", "Issuing Location");
    tagsDataTable.AddTagsRow("ilemail", "Issuing Location - Email", "Issuing Location");
    tagsDataTable.AddTagsRow("il_fulladdress", "Issuing Location Full Address", "Issuing Location");
    tagsDataTable.AddTagsRow("illogo", "Issuing Location Logo", "Issuing Location");
    tagsDataTable.AddTagsRow("gl_perils", "Generic Limit Perils", "Generic Rater");
    tagsDataTable.AddTagsRow("gl_limit", "Generic Rater Limit", "Generic Rater");
    tagsDataTable.AddTagsRow("gl_deduct", "Generic Limit Deductible", "Generic Rater");
    tagsDataTable.AddTagsRow("gl_covering", "Generic Limit Covering", "Generic Rater");
    tagsDataTable.AddTagsRow("gl_valuation", "Generic Limit Valuation", "Generic Rater");
    tagsDataTable.AddTagsRow("gl_excluding", "Generic Limit Excluding", "Generic Rater");
    tagsDataTable.AddTagsRow("gl_additionalcomments", "Generic Limit Additional Comments", "Generic Rater");
    tagsDataTable.AddTagsRow("sublimit", "Sub-Limit Field from the Generic Rater", "Generic Rater");
    tagsDataTable.AddTagsRow("netrate-nonowened-phydam-limit", "Non Owned Trailer Phys Dam Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-nonowened-phydam-premium", "Non Owned Trailer Phys Dam Premium", "NetRate");
    tagsDataTable.AddTagsRow("netrate-ba-um-pp", "Business Auto Uninsured Limit Per Person", "NetRate");
    tagsDataTable.AddTagsRow("netrate-ba-um-pa", "Business Auto Uninsured Limit Per Accident", "NetRate");
    tagsDataTable.AddTagsRow("netrate-ba-liab-limit", "Business Auto Liability Limit from NetRate", "NetRate");
    tagsDataTable.AddTagsRow("netrate-ba-liab-da", "Business Auto Liability Deductible from NetRate", "NetRate");
    tagsDataTable.AddTagsRow("netrate-ba-bi-pp-da", "Business Auto Bodily Injury Per Person Deductible from NetRate", "NetRate");
    tagsDataTable.AddTagsRow("netrate-ba-bi-pa-da", "Business Auto Bodily Injury Per Accident Deductible from NetRate", "NetRate");
    tagsDataTable.AddTagsRow("netrate-ba-propdmg-pa-da", "Business Auto Property Damage Per Accident Deductible from NetRate", "NetRate");
    tagsDataTable.AddTagsRow("netrate-bi-coins", "NetRate-entered Business Income Coinsurance", "NetRate");
    tagsDataTable.AddTagsRow("netrate-bi-valuation", "NetRate-entered Business Income Valuation", "NetRate");
    tagsDataTable.AddTagsRow("netrate-bi-limit", "NetRate-entered Business Income Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-bi-indemnity", "NetRate-entered Business Income Indemnity", "NetRate");
    tagsDataTable.AddTagsRow("netrate-biagreedval", "NetRate-entered Business Income Agreed Value", "NetRate");
    tagsDataTable.AddTagsRow("netrate-bi-da", "NetRate-entered Business Income Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-pp-coins", "NetRate-entered Property Coinsurance", "NetRate");
    tagsDataTable.AddTagsRow("netrate-pp-valuation", "NetRate-entered Property Valuation", "NetRate");
    tagsDataTable.AddTagsRow("netrate-pp-limit", "NetRate-entered Property Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-pp-da", "NetRate-entered Property Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-pp-wind-da", "NetRate-entered Property Wind Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-building-coins", "NetRate-entered Building Coinsurance", "NetRate");
    tagsDataTable.AddTagsRow("netrate-building-valuation", "NetRate-entered Building Valuation", "NetRate");
    tagsDataTable.AddTagsRow("netrate-building-limit", "NetRate-entered Building Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-building-da", "NetRate-entered Building Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-building-wind-da", "NetRate-entered Building Wind Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-genagg", "Netrate-entered GL General Aggregate", "NetRate");
    tagsDataTable.AddTagsRow("netrate-prodagg", "Netrate-entered GL Products Aggregate", "NetRate");
    tagsDataTable.AddTagsRow("netrate-peradv", "Netrate-entered GL Personal and Advertising Injury", "NetRate");
    tagsDataTable.AddTagsRow("netrate-eaocc", "Netrate-entered GL Each Occurrence", "NetRate");
    tagsDataTable.AddTagsRow("netrate-firelegal", "Netrate-entered GL Fire Legal Liability", "NetRate");
    tagsDataTable.AddTagsRow("netrate-medexp", "Netrate-entered GL Medical Expenses", "NetRate");
    tagsDataTable.AddTagsRow("netrate-da", "Netrate-entered GL Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-da-type", "Netrate-entered GL Deductible Type", "NetRate");
    tagsDataTable.AddTagsRow("netrate-gl-bi-da-per-claim", "Netrate-entered GL BI Deductible Per Claim", "NetRate");
    tagsDataTable.AddTagsRow("netrate-gl-bi-da-per-occ", "Netrate-entered GL BI Deductible Per Occurrence", "NetRate");
    tagsDataTable.AddTagsRow("netrate-gl-pd-da-per-claim", "Netrate-entered GL PD Deductible Per Claim", "NetRate");
    tagsDataTable.AddTagsRow("netrate-gl-pd-da-per-occ", "Netrate-entered GL PD Deductible Per Occurrence", "NetRate");
    tagsDataTable.AddTagsRow("netrate-gl-combined-da-per-claim", "Netrate-entered GL Combined Deductible Per Claim", "NetRate");
    tagsDataTable.AddTagsRow("netrate-gl-combined-da-per-occ", "Netrate-entered GL Combined Deductible Per Occurrence", "NetRate");
    tagsDataTable.AddTagsRow("netrate-bi-perperson", "Netrate-entered Business Auto Bodily Injury per person", "NetRate");
    tagsDataTable.AddTagsRow("netrate-bi-peracc", "Netrate-entered Business Auto Bodily Injury per accident", "NetRate");
    tagsDataTable.AddTagsRow("netrate-prop-dmg", "Netrate-entered Business Auto Property Damage", "NetRate");
    tagsDataTable.AddTagsRow("netrate-unins-motorist", "Netrate-entered Business Auto Uninsured Motorist Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-unins-motor-pd", "Netrate-entered Business Auto Uninsured Motorist Property Damage Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-dealers-med-limit", "Netrate-entered Business Auto Dealers Medical Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-vehicle-comp-da", "Netrate-entered Business Auto Vehicle Comp Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-vehicle-coll-da", "Netrate-entered Business Auto Vehicle Coll Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-vehicle-uninsured-limit", "Netrate-entered Business Auto Vehicle uninsured Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-vehicle-uninsured-pd-limit", "Netrate-entered Business Auto Vehicle uninsured PD Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-vehicle-uninsured-pd-premium", "Netrate-entered Business Auto Vehicle uninsured PD Premium", "NetRate");
    tagsDataTable.AddTagsRow("netrate-vehicle-uninsured-bipd-limit", "Netrate-entered Business Auto Vehicle uninsured BIPD Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-vehicle-underinsured-limit", "Netrate-entered Business Auto Vehicle underinsured Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-vehicle-underinsured-bipd-limit", "Netrate-entered Business Auto Vehicle underinsured BIPD Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-vehicle-extendedmedbenefits-limit", "Netrate-entered Business Auto Vehicle Extended Med Benefits Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-addedvehicles", "List of endorsement added vehicles", "NetRate");
    tagsDataTable.AddTagsRow("netrate-addedvehicles-stated-amount", "List of endorsement added vehicles with stated amount", "NetRate");
    tagsDataTable.AddTagsRow("netrate-motorcarrier-premium", "motor carrier premium", "NetRate");
    tagsDataTable.AddTagsRow("netrate-prior-motorcarrier-premium", "prior motor carrier premium", "NetRate");
    tagsDataTable.AddTagsRow("netrate-change-motorcarrier-premium", "difference with prior motor carrier premium", "NetRate");
    tagsDataTable.AddTagsRow("netrate-removedvehicles", "List of endorsement deleted vehicles", "NetRate");
    tagsDataTable.AddTagsRow("netrate-removedvehicles-stated-amount", "List of endorsement deleted vehicles with stated amount", "NetRate");
    tagsDataTable.AddTagsRow("netrate-prorata", "Pro Rata from NetRate", "NetRate");
    tagsDataTable.AddTagsRow("netrate_risk_address", "First Location Address in NetRate", "NetRate");
    tagsDataTable.AddTagsRow("netrate_risk_all_addresses", "All Location Addresses in NetRate", "NetRate");
    tagsDataTable.AddTagsRow("netrate_annual_trans_premium", "Annualized transaction premium from NetRate", "NetRate");
    tagsDataTable.AddTagsRow("netrate_business_personal_property_coinsurance", "NetRate Business Personal Property Coinsurance", "NetRate");
    tagsDataTable.AddTagsRow("netrate_business_income_monthly_limit", "NetRate Business Income Monthly Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-perauto-dealer-comp-ded", "NetRate Per Auto Dealer Comp Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-perclaim-dealer-comp-ded", "NetRate Per Claim Dealer Comp Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-blanketcoll-ded", "NetRate Dealer Blanket Collision Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-perauto-gk-comp-ded", "NetRate Per Auto Geragekeepers Comp Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-perclaim-gk-comp-ded", "NetRate Per Claim Garagekeepers Comp Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-dealer-liab-limit", "NetRate Dealer Liability Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-dealer-agg-liab-limit", "NetRate Dealer Aggregate Liability Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-dealer-medical-limit", "NetRate Dealer Medical Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-dealer-um-limit", "NetRate Dealer Uninsured Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-dealer-um-pd-limit", "NetRate Dealer Uninsured PD Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-dealer-um-bipd-limit", "NetRate Dealer Uninsured BIPD Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-dealer-false-ptnse-limit", "NetRate Dealer False Pretense Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-gk-collision-ded", "NetRate Garagekeepers Collision Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-blanket-limit-business-income", "NetRate Business Income Blanket Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-blanket-limit-building", "NetRate Building Blanket Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-blanket-limit-contents", "NetRate Contents Blanket Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-blanket-limit-building-contents", "NetRate Building and Contents Blanket Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-pip-premamt", "NetRate PIP", "NetRate");
    tagsDataTable.AddTagsRow("netrate-pip-limit", "NetRate PIP Limit", "NetRate");
    tagsDataTable.AddTagsRow("test", "this is a test", "NetRate");
    tagsDataTable.AddTagsRow("netrate-crime-EmployeeTheftLimit", "NetRate Crime Employee Theft Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-crime-EmployeeTheftDeductible", "NetRate Crime Employee Theft Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-crime-ForgeryLimit", "NetRate Crime Forgery Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-crime-ForgeryDeductible", "NetRate Crime Forgery Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-crime-InsideTheftLimit", "NetRate Crime Inside Theft Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-crime-InsideTheftDeduct", "NetRate Crime Inside Theft Deduct", "NetRate");
    tagsDataTable.AddTagsRow("netrate-crime-InsideRobberyLimit", "NetRate Crime Inside Robbery Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-crime-InsideRobberyDeduct", "NetRate Crime Inside Robbery Deduct", "NetRate");
    tagsDataTable.AddTagsRow("netrate-crime-outsideLimit", "NetRate Crime outside Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-crime-outsideDeductible", "NetRate Crime outside Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-crime-ComputerTransferLimit", "NetRate Crime Computer Transfer Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-crime-ComputerTransferDeductible", "NetRate Crime Computer Transfer Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-crime-MoneyOrderLimit", "NetRate Crime Money Order Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-crime-MoneyOrderDeductible", "NetRate Crime Money Order Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-crime-TotalPremium", "NetRate Crime Total Premium", "NetRate");
    tagsDataTable.AddTagsRow("netrate-inlMarine-FineArtsLimit", "NetRate Inland Marine Fine Arts Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-inlMarine-ScheduledLimit", "NetRate Inland Marine Scheduled Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-inlMarine-UnscheduledLimit", "NetRate Inland Marine Unscheduled Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-inlMarine-Deductible", "NetRate Inland Marine Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate-inlMarine-TotalPremium", "NetRate Inland Marine Total Premium", "NetRate");
    tagsDataTable.AddTagsRow("netrate-gl-AbuseLiabLimit", "NetRate General Liability Coverage code 'AbuseLiabClaims' Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-gl-AbuseLiabDeduct", "NetRate General Liability Coverage code 'AbuseLiabClaims' Deduct", "NetRate");
    tagsDataTable.AddTagsRow("netrate-gl-AbuseLiabPremium", "NetRate General Liability Coverage code 'AbuseLiabClaims' Premium", "NetRate");
    tagsDataTable.AddTagsRow("netrate-gl-AbuseLiabDate", "NetRate General Liability Coverage code 'AbuseLiabClaims' Date", "NetRate");
    tagsDataTable.AddTagsRow("netrate-gl-ProfessionalLiabLimit", "NetRate General Liability Coverage Code 'U-GL-2165' Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate-gl-ProfessionalLiabDeduct", "NetRate General Liability Coverage Code 'U-GL-2165' Deduct", "NetRate");
    tagsDataTable.AddTagsRow("netrate-gl-ProfessionalLiabPremium", "NetRate General Liability Coverage Code 'U-GL-2165' Premium", "NetRate");
    tagsDataTable.AddTagsRow("netrate_PropertyOptional_table", "NetRate Property Optional Table", "NetRate");
    tagsDataTable.AddTagsRow("netrate-glpremtotal", "NetRate General Liability Total Premium", "NetRate");
    tagsDataTable.AddTagsRow("netrate-PropertyPremTotal", "NetRate Property Total Premium", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_retrodate", "Retro Date", "NetRate");
    tagsDataTable.AddTagsRow("netrate_addinfo_coveragetype", "Coverage Type", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_bod_inj_each_acc", "Bodily Injury By Accident (Each Accident)", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_bod_inj_dis_agg", "Bodily Injury By Disease (Aggregate Limit)", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additonaldata_bod_inj_dis_empl", "Bodily Injury By Disease (Each Employee)", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionalcomments", "NetRate Additional Comments", "NetRate");
    tagsDataTable.AddTagsRow("netrate-rejected-terr", "NetRate Rejected Terrorism", "NetRate");
    tagsDataTable.AddTagsRow("netrate-accepted-terr", "NetRate Accepted Terrorism", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_comments", "NetRate Add'l Data - Auto Comments", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_lia_sym", "NetRate Add'l Data - Auto Liability Symbol", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_prop_pro_sym", "NetRate Add'l Data - Property Protection Symbol", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_add_pro_sym", "NetRate Add'l Data - Additional Protection Symbol", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_pip_sym", "NetRate Add'l Data - PIP Symbol", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_medpay_sym", "NetRate Add'l Data - Medical Payments Symbol", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_un_mot_sym", "NetRate Add'l Data - Uninsured Motorist Symbol", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_undn_mot_sym", "NetRate Add'l Data - Underinsured Motorist Symbol", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_rep_basis", "NetRate Add'l Data - Reporting Basis", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_nonrep_basis", "NetRate Add'l Data - Non Reporting Basis", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_qrep_basis", "NetRate Add'l Data - Quarterly Reporting Basis", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_mrep_basis", "NetRate Add'l Data - Monthly Reporting Basis", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_ncomp", "NetRate Add'l Data - Auto New Comprehensive", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_nscloss", "NetRate Add'l Data - Auto New Spec Cause Loss", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_ncoll", "NetRate Add'l Data - Auto New Collision", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_uscomp", "NetRate Add'l Data - Auto Used Comprehensive", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_uscl", "NetRate Add'l Data - Auto Used Spec Cause Loss", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_usdcoll", "NetRate Add'l Data - Auto Used Collision", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_iccomp", "NetRate Add'l Data - Interest Covered Comprehensive", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_icscl", "NetRate Add'l Data - Interest Covered Spec Cause Loss", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_aicoll", "NetRate Add'l Data - Interest Covered Collision", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_fincomp", "NetRate Add'l Data - Finance Auto Comprehensive", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_fascl", "NetRate Add'l Data - Finance Auto Spec Cause Loss", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_fincoll", "NetRate Add'l Data - Finance Auto Collision", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_lpcomp", "NetRate Add'l Data - Loss Payee Comprehensive", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_lpscl", "NetRate Add'l Data - Loss Payee Spec Cause Loss", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_lpcoll", "NetRate Add'l Data - Loss Payee Collision", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_conscomp", "NetRate Add'l Data - Consign Comprehensive", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_conscl", "NetRate Add'l Data - Consign Spec Cause Loss", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_concoll", "NetRate Add'l Data - Consign Collision", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_garks", "NetRate Add'l Data - Garage Keepers Symbol", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_pdcs", "NetRate Add'l Data - Phys Damage Comp Symbol", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_pdcfls", "NetRate Add'l Data - Phys Damage Cause Loss Symbol", "NetRate");
    tagsDataTable.AddTagsRow("netrate_additionaldata_auto_pdcols", "NetRate Add'l Data - Phys Damage Collision Symbol", "NetRate");
    tagsDataTable.AddTagsRow("netrate_keyemployeename", "NetRate Key Employee Name", "NetRate");
    tagsDataTable.AddTagsRow("netrate_keyemployeelocation", "Key Employee Location", "NetRate");
    tagsDataTable.AddTagsRow("netrate_keyemployeedescription", "Key Employee Description", "NetRate");
    tagsDataTable.AddTagsRow("netrate_keyemployeelimit", "Key Employee Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate_trailer_comp_limit", "Trailer Comprehensive Limit", "NetRate");
    tagsDataTable.AddTagsRow("netrate_trailer_comp_premium", "Trailer Comprehensive Premium", "NetRate");
    tagsDataTable.AddTagsRow("netrate_trailer_coll_deductible", "Trailer Collision Deductible", "NetRate");
    tagsDataTable.AddTagsRow("netrate_building_ordinance_table", "Building Ordinance Coverage Table", "NetRate");
    tagsDataTable.AddTagsRow("property-coins", "Property Coinsurance", "Property");
    tagsDataTable.AddTagsRow("property-valuation", "Property Valuation", "Property");
    tagsDataTable.AddTagsRow("prop-causeofloss", "Property Cause of Loss", "Property");
    tagsDataTable.AddTagsRow("prop-causeofloss-full", "Property Cause of Loss", "Property");
    tagsDataTable.AddTagsRow("prop-covering", "Property Covering", "Property");
    tagsDataTable.AddTagsRow("prop-limit", "Property Policy Limit with Description", "Property");
    tagsDataTable.AddTagsRow("prop-limit-no-desc", "Property Policy Limit without Description", "Property");
    tagsDataTable.AddTagsRow("prop-primaryprem", "Property Primary Premium", "Property");
    tagsDataTable.AddTagsRow("prop-%deductible", "Property – % Deductible", "Property");
    tagsDataTable.AddTagsRow("prop-deductible-type", "Property – Deductible Type", "Property");
    tagsDataTable.AddTagsRow("prop-floodlimit", "Property – Flood Limit", "Property");
    tagsDataTable.AddTagsRow("prop-sublimit-buildingord", "Property – Sub Limit(Building Ordiance)", "Property");
    tagsDataTable.AddTagsRow("prop-flooddeduct", "Property – Flood Deductible", "Property");
    tagsDataTable.AddTagsRow("prop-timeelement-deduct", "Property – Time Element Deductible", "Property");
    tagsDataTable.AddTagsRow("Prop_AOPDA_curr_int", "Property - AOP Deductible(Currency Integer)", "Property");
    tagsDataTable.AddTagsRow("annual_property_premium", "Annual Property Premium", "Property");
    tagsDataTable.AddTagsRow("prop-policyform", "Property Policy Form", "Property");
    tagsDataTable.AddTagsRow("prop_underlying_policy_limit", "Underlying Policy Limit", "Property");
    tagsDataTable.AddTagsRow("prop_underlying_carrier", "Underlying Carrier", "Property");
    tagsDataTable.AddTagsRow("prop_underlying_policy_num", "Underlying Policy #", "Property");
    tagsDataTable.AddTagsRow("prop_underlying_deductible", "Underlying Deductible", "Property");
    tagsDataTable.AddTagsRow("prop_sublimits", "Property Rater Sublimits", "Property");
    tagsDataTable.AddTagsRow("prop_sublimits_limits", "Property Rater Sublimits (Limits Only)", "Property");
    tagsDataTable.AddTagsRow("prop_sublimits_desc", "Property Rater Sublimits (Desc Only)", "Property");
    tagsDataTable.AddTagsRow("prop_additional_comments", "Property Rater Additional Comments", "Property");
    tagsDataTable.AddTagsRow("gl_totalpremium", "GL Total Premium", "General Liability");
    tagsDataTable.AddTagsRow("gl_genagg", "General Liability General Aggregate", "General Liability");
    tagsDataTable.AddTagsRow("gl_peradv", "General Liability Personal Advertising", "General Liability");
    tagsDataTable.AddTagsRow("gl_eaocc", "General Liability Each Occurrence", "General Liability");
    tagsDataTable.AddTagsRow("gl_firelegal", "General Liability Fire and Legal", "General Liability");
    tagsDataTable.AddTagsRow("gl_medexp", "General Liability Medical Expenses", "General Liability");
    tagsDataTable.AddTagsRow("gl_da", "General Liability Deductible", "General Liability");
    tagsDataTable.AddTagsRow("gl_addlcomments", "General Liability Addl Comments", "General Liability");
    tagsDataTable.AddTagsRow("glrater_prodcomp_ops_limit", "GL Rater Products/Completed Ops Limit", "General Liability");
    tagsDataTable.AddTagsRow("glrater_deductible_Desc", "GL Rater Deductible Description", "General Liability");
    tagsDataTable.AddTagsRow("glrater_coverage_type", "GL Rater Coverage Type(Occurrence or Claims)", "General Liability");
    tagsDataTable.AddTagsRow("gl_bi_ded", "General Liability Bodily Injury", "General Liability");
    tagsDataTable.AddTagsRow("gl_pd_ded", "General Liability Property Damage", "General Liability");
    tagsDataTable.AddTagsRow("gl_bipd_ded", "General Liability Bodily Injury And Property Damage Combined", "General Liability");
    tagsDataTable.AddTagsRow("adint", "Additional Interests(at one line)", "Additional Interests");
    tagsDataTable.AddTagsRow("adint-name-crlf-address", "Additional Interests for Additional Interest only(at same column)", "Additional Interests");
    tagsDataTable.AddTagsRow("wc_bi_each_acc", "Workers Comp Bodily Injury Each Accident", "Workers Comp");
    tagsDataTable.AddTagsRow("wc_bi_policy", "Workers Comp Bodily Injury Policy Limit", "Workers Comp");
    tagsDataTable.AddTagsRow("wc_bi_each_emp", "Workers Comp Bodily Injury Each Employee", "Workers Comp");
    tagsDataTable.AddTagsRow("wc_expenseconstant", "Workers Comp Expense Constant", "Workers Comp");
    tagsDataTable.AddTagsRow("wc_annivdate", "Workers Comp Anniversary Date", "Workers Comp");
    tagsDataTable.AddTagsRow("wc_states", "Workers Comp States", "Workers Comp");
    tagsDataTable.AddTagsRow("wc_ncci_riskid", "Workers Risk ID", "Workers Comp");
    tagsDataTable.AddTagsRow("wc_experiencemod", "Workers Experience Mod", "Workers Comp");
    tagsDataTable.AddTagsRow("wc_premiumdiscount", "Workers Comp Premium Discount", "Workers Comp");
    tagsDataTable.AddTagsRow("wc_domestic_terr_table", "Workers Comp Domestic Terrorism Table", "Workers Comp");
    tagsDataTable.AddTagsRow("wc_foreign_terr_table", "Workers Comp Foreign Terrorism Table", "Workers Comp");
    tagsDataTable.AddTagsRow("auto_umlimit", "Auto Uninsured Limit", "Auto");
    tagsDataTable.AddTagsRow("auto_uimlimit", "Auto Underinsured Limit", "Auto");
    tagsDataTable.AddTagsRow("auto_liabilitylimit", "Auto Liability Limit", "Auto");
    tagsDataTable.AddTagsRow("auto_liabilitylimit_csl", "Auto Liability Limit when CSL", "Auto");
    tagsDataTable.AddTagsRow("auto_liabilitylimit_csl_check", "X when Auto Liability Limit is CSL", "Auto");
    tagsDataTable.AddTagsRow("driver_list", "List of Drivers", "Auto");
    dt.AddTagsRow("dealer_service_coll_waiver", "Dealer/Service Collision Waiver", "Auto");
    dt.AddTagsRow("auto_fire_theft", "Auto Fire, Fire and Theft Table", "Auto");
    dt.AddTagsRow("false_pretense_inventory_value", "False Pretense Inventory Value", "Auto");
    dt.AddTagsRow("dealer_service_fire_legal_limit", "Dealer/Service Fire Legal Liability", "Auto");
    dt.AddTagsRow("broad_fire_legal_limit", "Broadened Coverages Fire Legal Liability Limit", "Auto");
    dt.AddTagsRow("doc_interests", "List of Comma-seperated DOC Interests", "Auto");
    dt.AddTagsRow("driveother_med", "Drive Other Car Med Pay Limit", "Auto");
    dt.AddTagsRow("driveother_um_deductible", "Hired Auto Uninsured Motorist Deductible", "Auto");
    dt.AddTagsRow("driveother_med_prem_incl", "Drive Other Car Med Pay Premium Included", "Auto");
    dt.AddTagsRow("driveother_um_comp_included", "Drive Other UM Comp Included", "Auto");
    dt.AddTagsRow("driveother_um_coll_included", "Drive Other UM Coll Included", "Auto");
    dt.AddTagsRow("driveother_um_premium_included", "Drive Other UM Premium Included", "Auto");
    dt.AddTagsRow("driveother_uim_premium_included", "Drive Other UIM Premium Included", "Auto");
    dt.AddTagsRow("pip_deathbenefits", "PIP Death Benefits Limit", "Auto");
    dt.AddTagsRow("pip_deathbenefits_prem", "PIP Death Benefits Premium", "Auto");
    dt.AddTagsRow("pip_workloss", "PIP Work Loss Limit", "Auto");
    dt.AddTagsRow("pip_workloss_prem", "PIP Work Loss Premium", "Auto");
    dt.AddTagsRow("doc_named_broad_cvg", "DOC Named Broadened Coverage Table", "Auto");
    dt.AddTagsRow("netrate_auto_um_no_ded_optn", "Auto Georgia No Deductible Option", "NetRate");
    dt.AddTagsRow("netrate_auto_vehicle_um", "Auto Vehicle Uninsured Limit", "NetRate");
    dt.AddTagsRow("netrate_ky_funeralexpenses", "Auto Kentucky Funeral Expenses Limit", "NetRate");
    dt.AddTagsRow("netrate_ky_weeklyloss", "Auto Kentucky Weekly Loss Coverage", "NetRate");
    dt.AddTagsRow("netrate_alaska_bi_only_limit", "Alaska BI Only Limit", "NetRate");
    dt.AddTagsRow("netrate_alaska_bi_only_x", "Alaska BI Only X", "NetRate");
    dt.AddTagsRow("netrate_alaska_bi_pd_limit", "Alaska BI & PD Limit", "NetRate");
    dt.AddTagsRow("netrate_dealer_service_med_limit", "Dealer/Service Medical Limit", "NetRate");
    dt.AddTagsRow("netrate_dealer_service_mi_broad_coll", "Dealer/Service MI Broadened Svc Cvg", "NetRate");
    dt.AddTagsRow("netrate_dealer_uim", "Dealer Underinsured Motorist Limit", "NetRate");
    dt.AddTagsRow("netrate_dealer_um", "Dealer Uninsured Motorist Limit", "NetRate");
    dt.AddTagsRow("netrate_driveother_uim", "Drive Other Car Underinsured Motorist Limit", "NetRate");
    dt.AddTagsRow("netrate_driveother_um", "Drive Other Car Uninsured Motorist Limit", "NetRate");
    dt.AddTagsRow("netrate_in_bi_only_um", "IN BI Only Uninsured Limit", "NetRate");
    dt.AddTagsRow("netrate_in_bi_pd_um", "IN BI And PD Uninsured Limit", "NetRate");
    dt.AddTagsRow("netrate_nc_um_check", "NC UM Checkbox", "NetRate");
    dt.AddTagsRow("driveother_liability_premium", "Drive Other Car Liability Premium", "NetRate");
    dt.AddTagsRow("driveother-liab-limit", "Drive Other Car Liability Limit", "NetRate");
    dt.AddTagsRow("driveother_med_limit", "Drive Other Car Medical Limit", "NetRate");
    dt.AddTagsRow("driveother_comp_ded", "Drive Other Car Comprehensive Deductible", "NetRate");
    dt.AddTagsRow("driveother_coll_ded", "Drive Other Car Collision Deductible", "NetRate");
    dt.AddTagsRow("driveother_med_premium", "Drive Other Car Medical Premium", "NetRate");
    dt.AddTagsRow("driveother_comp_premium", "Drive Other Car Comprehensive Premium", "NetRate");
    dt.AddTagsRow("driveother_coll_premium", "Drive Other Car Collision Premium", "NetRate");
    dt.AddTagsRow("driveother_um_premium", "Drive Other Car Uninsured Premium", "NetRate");
    dt.AddTagsRow("driveother_uim_premium", "Drive Other Car Underinsured Premium", "NetRate");
    dt.AddTagsRow("hired_auto_limit", "Hired Auto limit", "NetRate");
    dt.AddTagsRow("nonowned_auto_limit", "Non-Owned Auto limit", "NetRate");
    tagsDataTable.AddTagsRow("policy_effective_time", "Policy Effective Time");
    tagsDataTable.AddTagsRow("retailer_name", "Retailer Name", "Retailer");
    tagsDataTable.AddTagsRow("retailer_address1", "Retailer Address1", "Retailer");
    tagsDataTable.AddTagsRow("retailer_address2", "Retailer Address2", "Retailer");
    tagsDataTable.AddTagsRow("retailer_city", "Retailer City", "Retailer");
    tagsDataTable.AddTagsRow("retailer_state", "Retailer State", "Retailer");
    tagsDataTable.AddTagsRow("retailer_zipcode", "Retailer Zip Code", "Retailer");
    tagsDataTable.AddTagsRow("retailer_zipplus", "Retailer Zip Plus", "Retailer");
    tagsDataTable.AddTagsRow("retailer_fulladdress", "Retailer Full Address", "Retailer");
    tagsDataTable.AddTagsRow("retailer_contact_email", "Retailer Contact Email Address", "Retailer");
    tagsDataTable.AddTagsRow("retailer_fax", "Retailer Fax #", "Retailer");
    tagsDataTable.AddTagsRow("retailer_phone", "Retailer Phone #", "Retailer");
    tagsDataTable.AddTagsRow("retailer_contact_fname", "Retailer Contact First Name", "Retailer");
    tagsDataTable.AddTagsRow("retailer_contact_lname", "Retailer Contact Last Name", "Retailer");
    tagsDataTable.AddTagsRow("pcs", "Producer Contact - Salutation", "Producers");
    tagsDataTable.AddTagsRow("pcf", "Producer Contact - First", "Producers");
    tagsDataTable.AddTagsRow("pcl", "Producer Contact - Last", "Producers");
    tagsDataTable.AddTagsRow("pcsrf", "Producer CSR - First", "Producers");
    tagsDataTable.AddTagsRow("pcsrl", "Producer CSR - Last", "Producers");
    tagsDataTable.AddTagsRow("pcsre", "Producer CSR - Email", "Producers");
    tagsDataTable.AddTagsRow("pcsrp", "Producer CSR - Phone", "Producers");
    tagsDataTable.AddTagsRow("pcp", "Producer Contact - Phone", "Producers");
    tagsDataTable.AddTagsRow("pcfax", "Producer Contact - Fax", "Producers");
    tagsDataTable.AddTagsRow("prodloc_fulladdress", "Producer Location's Full Address", "Producers");
    tagsDataTable.AddTagsRow("pc_email", "Producer Contact Email", "Producers");
    tagsDataTable.AddTagsRow("prod_loc_code", "Producer Location Code", "Producers");
    tagsDataTable.AddTagsRow("prod_code", "Producer Code", "Producers");
    tagsDataTable.AddTagsRow("prodcom", "Producer Composite Commission %", "Producers");
    tagsDataTable.AddTagsRow("prodloc_email", "Producer Location - Email", "Producers");
    tagsDataTable.AddTagsRow("underwriting_location", "Underwriting Location", "Underwriting Location");
    tagsDataTable.AddTagsRow("endnum", "Endorsement #", "Endorsement");
    tagsDataTable.AddTagsRow("endeff", "Endorsement Effective", "Endorsement");
    tagsDataTable.AddTagsRow("endcom", "Endorsement Comment", "Endorsement");
    tagsDataTable.AddTagsRow("endcomoi", "Endorsement Comment (Other Info)", "Endorsement");
    tagsDataTable.AddTagsRow("endinfo_coveragepartsaffected", "Endorsement Info. Coverage Parts Affected", "Endorsement");
    tagsDataTable.AddTagsRow("endinfo_coveredproplocdesc", "Endorsement Infor. Covered Property / Location Description", "Endorsement");
    tagsDataTable.AddTagsRow("endinfo_deductible", "Endorsement Info. Deductible", "Endorsement");
    tagsDataTable.AddTagsRow("endinfo_limitsexposure", "Endorsement Info. Limits/Exposures", "Endorsement");
    tagsDataTable.AddTagsRow("endinfo_covformsendorse", "Endorsement Info. Coverage Forms and Endorsements", "Endorsement");
    tagsDataTable.AddTagsRow("endinfo_addintparties", "Endorsement Info. Additional Interested Parties", "Endorsement");
    tagsDataTable.AddTagsRow("endinfo_insuredlegalstatus", "Endorsement Info. Insured' Legal Status/Business of Insured", "Endorsement");
    tagsDataTable.AddTagsRow("endinfo_insuredname", "Endorsement Info. Insured Name", "Endorsement");
    tagsDataTable.AddTagsRow("autoexp_tableinfo", "Table of Generic Auto Exposure Info", "Generic Rater");
    tagsDataTable.AddTagsRow("statefilingimage", "SL Filing Image", "SL Filing");
    tagsDataTable.AddTagsRow("statefilingcomments", "SL Filing Comments", "SL Filing");
    tagsDataTable.AddTagsRow("statefilingNotes", "SL Filing User Notes", "SL Filing");
    tagsDataTable.AddTagsRow("filingNotes", "SL Filing User Filling Notes", "SL Filing");
    tagsDataTable.AddTagsRow("noc_pastdueamount", "Amount of money past due on a policy.", "Notice Of Cancellation");
    tagsDataTable.AddTagsRow("noc_DateOfCancellation", "Date of Cancellation for an account under NOC.", "Notice Of Cancellation");
    tagsDataTable.AddTagsRow("riskdescperline", "Risk Description per line.", "Policy");
    tagsDataTable.AddTagsRow("underwritingteam", "Underwriting Team", "Users");
    tagsDataTable.AddTagsRow("intermediarycontactsignature", "Intermediary Contact", "Policy");
    tagsDataTable.AddTagsRow("program_code", "Program Code", "Policy");
    tagsDataTable.AddTagsRow("clientdba", "Client DBA", "Client");
    tagsDataTable.AddTagsRow("in_prod_first_name", "Inhouse Producer First Name", "Submission");
    tagsDataTable.AddTagsRow("in_prod_last_name", "Inhouse Producer Last Name", "Submission");
    tagsDataTable.AddTagsRow("in_prod_title", "Inhouse Producer Title", "Submission");
    tagsDataTable.AddTagsRow("in_prod_phone", "Inhouse Producer Phone", "Submission");
    tagsDataTable.AddTagsRow("in_prod_fax", "Inhouse Producer Fax", "Submission");
    tagsDataTable.AddTagsRow("in_prod_signature", "Inhouse Producer Signature", "Submission");
    tagsDataTable.AddTagsRow("in_prod_email", "Inhouse Producer Email address", "Submission");
    tagsDataTable.AddTagsRow("in_prod_phone_ext", "Inhouse Producer Phone Ext", "Submission");
    this.AddEntitySpecificTags(dt);
  }

  private void AddEntitySpecificTags(dsTemplateDocs.TagsDataTable dt)
  {
    dt.AddTagsRow("ain", "Additional Interest Name", "Additional Interests");
    dt.AddTagsRow("aidesc", "Additional Interest Description", "Additional Interests");
    if (this.MPL_Tag() == 1)
    {
      dt.AddTagsRow("ail1", "Additional Interest - MaxLimitOpt1", "Additional Interests");
      dt.AddTagsRow("ail2", "Additional Interest - MaxLimitOpt2", "Additional Interests");
      dt.AddTagsRow("ail3", "Additional Interest - MaxLimitOpt3", "Additional Interests");
      dt.AddTagsRow("ail4", "Additional Interest - MaxLimitOpt4", "Additional Interests");
      dt.AddTagsRow("aio1", "Additional Interest - OptRate1", "Additional Interests");
      dt.AddTagsRow("aio2", "Additional Interest - OptRate2", "Additional Interests");
      dt.AddTagsRow("aio3", "Additional Interest - OptRate3", "Additional Interests");
      dt.AddTagsRow("aio4", "Additional Interest - OptRate4", "Additional Interests");
      dt.AddTagsRow("aicrl", "Additional Interest - Claim Rpt Limit", "Additional Interests");
      dt.AddTagsRow("aieffdate", "Additional Interest - Effective Date", "Additional Interests");
      dt.AddTagsRow("aiexpdate", "Additional Interest - Expiration Date", "Additional Interests");
    }
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT InterestType, AdditionalInterest, VehicleRequired, ISNULL(IsNetrate,0) IsNetrate FROM lstAdditionalInterestTypes ORDER BY AdditionalInterest");
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        string str1 = row.Field<string>("InterestType");
        string str2 = row.Field<string>("AdditionalInterest");
        bool? nullable = row.Field<bool?>("IsNetrate");
        if (!nullable.GetValueOrDefault())
        {
          dt.AddTagsRow($"ai-{str1}", $"Additional Interest - {str2}", "Additional Interests");
          dt.AddTagsRow($"aia-{str1}", $"A.I. Address (one line) - {str2}", "Additional Interests");
          dt.AddTagsRow($"aii-{str1}", $"Add. Int. - Interest - {str2}", "Additional Interests");
          dt.AddTagsRow($"ain-{str1}", $"Add. Int. - Name Only - {str2}", "Additional Interests");
          dt.AddTagsRow($"ail-{str1}", $"Add. Int. - Location - {str2}", "Additional Interests");
          dt.AddTagsRow($"aill-{str1}", $"Add. Int. - Mulit-Locations - {str2}", "Additional Interests");
          dt.AddTagsRow($"aillb-{str1}", $"Add. Int. - Mulit-Loc# & Bldg# - {str2}", "Additional Interests");
          dt.AddTagsRow($"aiml-{str1}", $"Add. Int. - Multi-Loc# - {str2}", "Additional Interests");
          dt.AddTagsRow($"aimb-{str1}", $"Add. Int. - Multi-Bldg# - {str2}", "Additional Interests");
          dt.AddTagsRow($"aiac-{str1}", $"A.I. Address (one line) with Country Name - {str2}", "Additional Interests");
          dt.AddTagsRow($"aiaddress-{str1}", $"Add. Int. - Address - {str2}", "Additional Interests");
          dt.AddTagsRow($"aicity-{str1}", $"Add. Int. - City - {str2}", "Additional Interests");
          dt.AddTagsRow($"aistate-{str1}", $"Add. Int. - State - {str2}", "Additional Interests");
          dt.AddTagsRow($"aizip-{str1}", $"Add. Int. - Zipcode - {str2}", "Additional Interests");
          dt.AddTagsRow($"aifn-{str1}", $"Add. Int. - First Name - {str2}", "Additional Interests");
          dt.AddTagsRow($"ailn-{str1}", $"Add. Int. - Last Name - {str2}", "Additional Interests");
          nullable = row.Field<bool?>("VehicleRequired");
          if (nullable.GetValueOrDefault())
          {
            dt.AddTagsRow($"aiv-{str1}", $"Add. Int. - Vehicles - {str2}", "Additional Interests");
            dt.AddTagsRow($"aiv-comp-{str1}", $"Add. Int. - Vehicle Comp Ded. - {str2}", "Additional Interests");
            dt.AddTagsRow($"aiv-col-{str1}", $"Add. Int. - Vehicle COL Ded. - {str2}", "Additional Interests");
            dt.AddTagsRow($"aiv-coll-{str1}", $"Add. Int. - Vehicle Coll Ded. - {str2}", "Additional Interests");
          }
        }
        else
        {
          dt.AddTagsRow($"NRAI-{str1.Replace(" ", "")}", $"[{str1}]: Coverage Code - {str2}", "Netrate Additional Interests");
          dt.AddTagsRow($"NRAIC-{str1.Replace(" ", "")}", $"[{str1}]: Coverage Name - {str2}", "Netrate Additional Interests");
          dt.AddTagsRow($"NRAIB-{str1.Replace(" ", "")}", $"[{str1}]: Line of Business - {str2}", "Netrate Additional Interests");
          dt.AddTagsRow($"NRAIN-{str1.Replace(" ", "")}", $"[{str1}]: Name Text - {str2}", "Netrate Additional Interests");
          dt.AddTagsRow($"NRAIL-{str1.Replace(" ", "")}", $"[{str1}]: Address Text - {str2}", "Netrate Additional Interests");
          dt.AddTagsRow($"NRAID-{str1.Replace(" ", "")}", $"[{str1}]: Description Text - {str2}", "Netrate Additional Interests");
          dt.AddTagsRow($"NRAIP-{str1.Replace(" ", "")}", $"[{str1}]: Premium - {str2}", "Netrate Additional Interests");
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    dt.AddTagsRow("netrate-ai-veh-comp-da", "Netrate-entered Business Auto Vehicle Comp Deductible", "Additional Interests");
    dt.AddTagsRow("netrate-ai-veh-coll-da", "Netrate-entered Business Auto Vehicle Coll Deductible", "Additional Interests");
  }

  public virtual int MPL_Tag() => 0;

  protected virtual void RemoveTags(dsTemplateDocs.TagsDataTable dt, params object[] args)
  {
    for (int index1 = dt.Rows.Count - 1; index1 >= 0; index1 += -1)
    {
      int num = args.GetLength(0) - 1;
      for (int index2 = 0; index2 <= num; ++index2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString((string) args.GetValue(index2), (string) dt.Rows[index1]["TagName"], false) == 0)
        {
          DataRow row = dt.Rows[index1];
          dt.Rows.Remove(row);
          dt.AcceptChanges();
          break;
        }
      }
    }
  }

  object ITagParserFactory.QueryTagParser(int TemplateGroupID, params object[] args)
  {
    return (object) this.GetTagParser(TemplateGroupID, args);
  }
}

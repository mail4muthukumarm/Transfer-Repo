// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.TemplateDocuments.Claims_PolicyTagParser
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Claims.TemplateDocuments;

[Override(typeof (PolicyTagParser))]
public class Claims_PolicyTagParser : PolicyTagParser
{
  private Guid _claimGuid;

  public Claims_PolicyTagParser(Guid claimGuid)
    : base(Utility.GetQuoteGuidFromClaimGuid(claimGuid))
  {
    this._claimGuid = claimGuid;
  }

  public Claims_PolicyTagParser(Guid quoteGuid, Guid quoteOptionGuid)
    : base(quoteGuid, quoteOptionGuid)
  {
  }

  public override List<DocTag> ProcessTags(
    List<DocTag> tags,
    object entityId,
    int placedByCompanyLineID)
  {
    foreach (DocTag tag in tags)
    {
      string lower = tag.InnerTagName.ToLower();
      if (lower != null)
      {
        switch (lower.Length)
        {
          case 8:
            if (lower == "clmt_dob")
              break;
            continue;
          case 9:
            switch (lower[0])
            {
              case 'c':
                if (lower == "clmt_name")
                  break;
                continue;
              case 'l':
                if (lower == "loss_date")
                  break;
                continue;
              default:
                continue;
            }
            break;
          case 10:
            switch (lower[3])
            {
              case '_':
                if (lower == "clm_number")
                  break;
                continue;
              case 't':
                if (lower == "clmt_email")
                  break;
                continue;
              default:
                continue;
            }
            break;
          case 11:
            switch (lower[6])
            {
              case 'r':
                if (lower == "clm_carrier")
                  break;
                continue;
              case 't':
                if (lower == "clm_catcode")
                  break;
                continue;
              case 'u':
                if (lower == "clmt_number")
                  break;
                continue;
              default:
                continue;
            }
            break;
          case 12:
            switch (lower[5])
            {
              case 'a':
                if (lower == "clmt_address")
                  break;
                continue;
              case 'l':
                if (lower == "clmt_lawfirm")
                  break;
                continue;
              case 'o':
                if (lower == "clm_comments")
                  break;
                continue;
              default:
                continue;
            }
            break;
          case 13:
            switch (lower[5])
            {
              case 'a':
                if (lower == "clmt_attorney")
                  break;
                continue;
              case 'c':
                if (lower == "clmt_comments")
                  break;
                continue;
              case 'f':
                if (lower == "clm_effective")
                  break;
                continue;
              case 'l':
                if (lower == "clmt_losstype")
                  break;
                continue;
              default:
                continue;
            }
            break;
          case 14:
            if (lower == "clm_expiration")
              break;
            continue;
          case 15:
            switch (lower[4])
            {
              case 'i':
                if (lower == "clm_insuredname")
                  break;
                continue;
              case 'r':
                if (lower == "clm_remreserves")
                  break;
                continue;
              default:
                continue;
            }
            break;
          case 16 /*0x10*/:
            switch (lower[6])
            {
              case 'c':
                if (lower == "clm_accidenttime" || lower == "clm_accidenttype")
                  break;
                continue;
              case 'e':
                if (lower == "clmt_defattorney")
                  break;
                continue;
              case 'j':
                if (lower == "clm_adjustername")
                  break;
                continue;
              case 'l':
                if (lower == "clm_policynumber")
                  break;
                continue;
              case 'o':
                if (lower == "clm_producername")
                  break;
                continue;
              default:
                continue;
            }
            break;
          case 17:
            switch (lower[11])
            {
              case 'p':
                if (lower == "clmt_datereported")
                  break;
                continue;
              case 's':
                if (lower == "clm_totalreserves")
                  break;
                continue;
              case 'y':
                if (lower == "clm_totalpayments")
                  break;
                continue;
              default:
                continue;
            }
            break;
          case 18:
            switch (lower[4])
            {
              case 'i':
                if (lower == "clm_insuredaddress")
                  break;
                continue;
              case 'n':
                if (lower == "clm_numberofclmnts")
                  break;
                continue;
              default:
                continue;
            }
            break;
          case 19:
            switch (lower[4])
            {
              case '_':
                if (lower == "clmt_mailingaddress")
                  break;
                continue;
              case 'a':
                if (lower == "clm_accidentaddress")
                  break;
                continue;
              case 'p':
                if (lower == "clm_produceraddress")
                  break;
                continue;
              default:
                continue;
            }
            break;
          case 20:
            switch (lower[5])
            {
              case 'a':
                if (lower == "clmt_attorneyaddress")
                  break;
                continue;
              case 'o':
                if (lower == "clmt_outadjustername")
                  break;
                continue;
              default:
                continue;
            }
            break;
          case 21:
            switch (lower[16 /*0x10*/])
            {
              case 'e':
                if (lower == "clm_adjusternameemail")
                  break;
                continue;
              case 'p':
                if (lower == "clm_adjusternamephone")
                  break;
                continue;
              case 't':
                if (lower == "clm_adjusternametitle")
                  break;
                continue;
              default:
                continue;
            }
            break;
          case 23:
            if (lower == "clm_accidentdescription")
              break;
            continue;
          case 24:
            switch (lower[3])
            {
              case '_':
                if (lower == "clm_adjusternamephoneext")
                  break;
                continue;
              case 't':
                if (lower == "clmt_addressphonenumbers")
                  break;
                continue;
              default:
                continue;
            }
            break;
          case 31 /*0x1F*/:
            if (!(lower == "clmt_mailingaddressphonenumbers"))
              continue;
            break;
          default:
            continue;
        }
        object obj = DefaultDatabase.ExecuteScalar("spClaims_GetTemplateTags", new object[4]
        {
          (object) "@ClaimGuid",
          (object) this._claimGuid,
          (object) "@TagName",
          (object) tag.InnerTagName
        });
        tag.TagValue = obj != null ? obj.ToString() : string.Empty;
      }
    }
    return base.ProcessTags(tags, entityId, placedByCompanyLineID);
  }
}

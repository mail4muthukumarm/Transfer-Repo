// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.TemplateDocuments.AdditionalInterestTagParser
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Enums;
using MGASystems.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.TemplateDocuments;

public class AdditionalInterestTagParser : PolicyTagParser
{
  private int id;
  private static object _lock = RuntimeHelpers.GetObjectValue(new object());
  private Quote _quote;
  private Guid _quoteGuid;
  [CLSCompliant(false)]
  protected new Guid[] _quoteOptionGuids;
  private bool? _quoteHasIntermediary;
  private CompanyContact _companyContact;
  private IntermediaryContact _intermediaryContact;

  public AdditionalInterestTagParser(int _addlInterestID, Guid qGuid)
    : base(qGuid)
  {
    this._quoteGuid = qGuid;
    this.id = _addlInterestID;
  }

  public static Guid GetQuoteGuid(int addlInterestID)
  {
    object obj = DefaultDatabase.ExecuteScalar("dbo.GetQuoteGuidFromAiId", new object[2]
    {
      (object) "@AdditionalInterestID",
      (object) addlInterestID
    });
    return obj == null ? new Guid() : (Guid) obj;
  }

  public override List<DocTag> ProcessTags(
    List<DocTag> tags,
    object entityId,
    int placedByCompanyLineID)
  {
    Predicate<DocTag> match = new Predicate<DocTag>(PolicyTagParser.IsCompanyContactTagInList);
    if (tags.Exists(match))
      this.InitializeQuoteCompanyContact(this._quote.QuoteGuid);
    try
    {
      foreach (DocTag tag in tags)
      {
        this.ProcessEntitySpecificTag(tag, this.id);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tag.TagValue, string.Empty, false) == 0)
        {
          string lower = tag.InnerTagName.ToLower();
          DateTime dateTime;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(lower))
          {
            case 14632193:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-prior-motorcarrier-premium", false) == 0)
                goto label_753;
              continue;
            case 37735555:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_medpay_sym", false) == 0)
                goto label_787;
              continue;
            case 56352225:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "auto_liabilitylimit", false) == 0)
                goto label_815;
              continue;
            case 59780555:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cls", false) == 0)
              {
                tag.TagValue = this.Quote.CompanyLocation.State;
                continue;
              }
              continue;
            case 69588311:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_auto_um_no_ded_optn", false) == 0)
                goto label_736;
              continue;
            case 70691527:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-biagreedval", false) == 0)
                goto label_736;
              continue;
            case 82720925:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_icscl", false) == 0)
                goto label_787;
              continue;
            case 89911059:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uext", false) == 0)
                break;
              continue;
            case 100147214:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "csri", false) == 0)
                goto label_634;
              continue;
            case 111742496:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uwal", false) == 0)
              {
                tag.TagValue = !this.Quote.HasUnderwriterAssistant ? string.Empty : this.Quote.UnderwriterAssistant.LastName;
                continue;
              }
              continue;
            case 120009315:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms-number-name-table", false) == 0)
              {
                tag.TagTable = this.FormsTableNumberName(this.Quote.QuoteGuid);
                continue;
              }
              continue;
            case 123527986:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_auto_vehicle_um", false) == 0)
                goto label_736;
              continue;
            case 125179175:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "feelisting_linebreaks_showall", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("spGetFeeListing", new object[6]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@LineBreaks",
                  (object) true,
                  (object) "@BoundOnly",
                  (object) false
                }).ToString();
                continue;
              }
              continue;
            case 126531272:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother_med_prem_incl", false) == 0)
                goto label_816;
              continue;
            case 130659518:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "retailer_contact_lname", false) == 0)
                goto label_763;
              continue;
            case 130834694:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop-timeelement-deduct", false) == 0)
                break;
              continue;
            case 132139222:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-firelegal", false) == 0)
                goto label_736;
              continue;
            case 133334055:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_business_personal_property_coinsurance", false) == 0)
                goto label_736;
              continue;
            case 146921323:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-dealer-um-limit", false) == 0)
                goto label_736;
              continue;
            case 175496865:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additonaldata_bod_inj_dis_empl", false) == 0)
                goto label_787;
              continue;
            case 182628607:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clientdba", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("GetClientDBAName", new object[2]
                {
                  (object) "@QuoteID",
                  (object) this.Quote.QuoteID
                })), "");
                continue;
              }
              continue;
            case 202624826:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prodloc_fulladdress", false) == 0)
                goto label_762;
              continue;
            case 203153343:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cmpnycntct_title", false) == 0)
              {
                tag.TagValue = this._quoteHasIntermediary.HasValue ? (!this._quoteHasIntermediary.Value ? this._companyContact.Title : this._intermediaryContact.Title) : string.Empty;
                continue;
              }
              continue;
            case 206217123:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "bound_nontaxes_only", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateTotalNonTaxes", new object[4]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@Bound",
                  (object) true
                });
                continue;
              }
              continue;
            case 207817148:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_trailer_comp_limit", false) == 0)
                goto label_736;
              continue;
            case 212570970:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "wc_ncci_riskid", false) == 0)
                goto label_811;
              continue;
            case 217258941:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-prodagg", false) == 0)
                goto label_736;
              continue;
            case 224561029:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "formnumbers-crlf", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocForms", new object[10]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@LineFeedSeperated",
                  (object) true,
                  (object) "@ShowFormNumbers",
                  (object) true,
                  (object) "@ShowFormNames",
                  (object) false,
                  (object) "@NamesThenNumbers",
                  (object) false
                });
                continue;
              }
              continue;
            case 226149123:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "qlcnt", false) == 0)
              {
                tag.TagValue = this.Quote.QuotingLocation.County;
                continue;
              }
              continue;
            case 243634272:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "company_fulladdress", false) == 0)
                goto label_756;
              continue;
            case 249425500:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ins_billingstate", false) == 0)
                goto label_762;
              continue;
            case 249716139:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_ncoll", false) == 0)
                goto label_787;
              continue;
            case 260437228:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_perils", false) == 0)
              {
                tag.TagValue = PolicyTagParser.StripRTF(Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select perils from tblGenericLimits where QuoteID = @QuoteID", new object[2]
                {
                  (object) "@QuoteID",
                  (object) this.Quote.QuoteID
                })), string.Empty));
                continue;
              }
              continue;
            case 276595990:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-motorcarrier-premium", false) == 0)
                goto label_753;
              continue;
            case 279518686:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uwaf", false) == 0)
              {
                tag.TagValue = !this.Quote.HasUnderwriterAssistant ? string.Empty : this.Quote.UnderwriterAssistant.FirstName;
                continue;
              }
              continue;
            case 295548488:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cmpnycntct_ncci", false) == 0)
              {
                if (!this._quoteHasIntermediary.HasValue)
                {
                  tag.TagValue = string.Empty;
                  continue;
                }
                tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "Select tblCompanies.NCCI FROM tblCompanies INNER JOIN tblCompanyLocations ON tblCompanies.CompanyGUID = tblCompanyLocations.CompanyGUID INNER JOIN tblQuotes ON tblCompanyLocations.CompanyLocationGUID = tblQuotes.CompanyLocationGuid WHERE (tblQuotes.QuoteGUID = @QuoteGUID)", new object[2]
                {
                  (object) "@QuoteGUID",
                  (object) this._quoteGuid
                })), "");
                continue;
              }
              continue;
            case 297558702:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "quoting_office_license_num", false) == 0)
                break;
              continue;
            case 298984538:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ins_billingzip", false) == 0)
                goto label_762;
              continue;
            case 304986653:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "mgacommission", false) == 0)
                break;
              continue;
            case 306609153:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_keyemployeelocation", false) == 0)
                goto label_765;
              continue;
            case 311796710:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-bi-limit", false) == 0)
                goto label_736;
              continue;
            case 312042576:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "endinfo_deductible", false) == 0)
                goto label_802;
              continue;
            case 326684274:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms-crlf-name-number", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocForms", new object[10]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@LineFeedSeperated",
                  (object) true,
                  (object) "@ShowFormNumbers",
                  (object) true,
                  (object) "@ShowFormNames",
                  (object) true,
                  (object) "@NamesThenNumbers",
                  (object) true
                });
                continue;
              }
              continue;
            case 328222459:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clc", false) == 0)
              {
                tag.TagValue = this.Quote.CompanyLocation.CompanyLocationCode.ToString();
                continue;
              }
              continue;
            case 336686891:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "admitted_or_nonadmitted", false) == 0)
              {
                tag.TagValue = Interaction.IIf(this.Quote.CompanyLine.IsAdmitted, (object) "Admitted", (object) "Non-Admitted").ToString();
                continue;
              }
              continue;
            case 346513032:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother_med_premium", false) == 0)
                goto label_736;
              continue;
            case 350234758:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_ncomp", false) == 0)
                goto label_787;
              continue;
            case 354625238:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_lpcomp", false) == 0)
                goto label_787;
              continue;
            case 404578660:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-addedvehicles", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateAddedVehicles", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid
                });
                continue;
              }
              continue;
            case 428323445:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-ba-liab-da", false) == 0)
                goto label_736;
              continue;
            case 432158846:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "company_logo", false) == 0)
              {
                try
                {
                  byte[] buffer = (byte[]) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT top 1 dbo.tblCompanies.Logo FROM  dbo.tblQuotes INNER JOIN dbo.tblCompanyLocations ON dbo.tblQuotes.CompanyLocationGuid = dbo.tblCompanyLocations.CompanyLocationGUID INNER JOIN dbo.tblCompanies ON dbo.tblCompanyLocations.CompanyGUID = dbo.tblCompanies.CompanyGUID WHERE dbo.tblQuotes.CompanyLocationGuid = @CompanyLocationGuid", new object[2]
                  {
                    (object) "@CompanyLocationGuid",
                    (object) this.Quote.CompanyLocationGuid
                  });
                  if (buffer != null)
                  {
                    tag.TagImage = (Image) new Bitmap((Stream) new MemoryStream(buffer));
                    continue;
                  }
                  continue;
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                  continue;
                }
              }
              else
                continue;
            case 453007297:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "wc_domestic_terr_table", false) == 0)
              {
                tag.TagTable = this.WorkersCompDomesticTerrorismTable(this._quoteGuid, placedByCompanyLineID);
                continue;
              }
              continue;
            case 462682768:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "adint-name-crlf-address", false) == 0)
              {
                tag.TagValue = string.Empty;
                DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT InterestName + char(10) + dbo.formataddress(Address1, Address2, City, StateID, ZipCode, ZipPlus) AS Address FROM dbo.tblQuoteAdditionalInterests INNER JOIN dbo.tblQuoteAdditionalInterestTypes ON dbo.tblQuoteAdditionalInterests.ID = dbo.tblQuoteAdditionalInterestTypes.AdditionalInterestID WHERE (dbo.tblQuoteAdditionalInterestTypes.AdditionalInterestType = @AdditionalInterestType) and ID=@ID", new object[4]
                {
                  (object) "@ID",
                  (object) this.id,
                  (object) "@AdditionalInterestType",
                  (object) "I"
                });
                try
                {
                  foreach (DataRow row in dataTable.Rows)
                  {
                    DocTag docTag;
                    string str = $"{(docTag = tag).TagValue}{row[0].ToString()}\r\n\r\n";
                    docTag.TagValue = str;
                  }
                  continue;
                }
                finally
                {
                  IEnumerator enumerator;
                  if (enumerator is IDisposable)
                    (enumerator as IDisposable).Dispose();
                }
              }
              else
                continue;
            case 470954325:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insphone", false) == 0)
              {
                tag.TagValue = this.Quote.InsuredPhone;
                continue;
              }
              continue;
            case 487798056:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_bipd_ded", false) == 0)
                goto label_543;
              continue;
            case 491705196:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-medexp", false) == 0)
                goto label_736;
              continue;
            case 494943047:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "in_prod_first_name", false) == 0)
                goto label_841;
              continue;
            case 505035620:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "auto_umlimit", false) == 0)
                goto label_815;
              continue;
            case 512990060:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-gl-pd-da-per-claim", false) == 0)
                goto label_764;
              continue;
            case 514405352:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uwat", false) == 0)
              {
                tag.TagValue = !this.Quote.HasUnderwriterAssistant ? string.Empty : this.Quote.UnderwriterAssistant.Title ?? string.Empty;
                continue;
              }
              continue;
            case 523619721:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "retailer_fax", false) == 0)
                goto label_763;
              continue;
            case 534704648:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother_um_premium", false) == 0)
                goto label_736;
              continue;
            case 541631469:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clcity", false) == 0)
              {
                tag.TagValue = this.Quote.CompanyLocation.City;
                continue;
              }
              continue;
            case 546051587:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "retailer_state", false) == 0)
                goto label_763;
              continue;
            case 553291762:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "glrater_coverage_type", false) == 0)
                goto label_801;
              continue;
            case 564179583:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-vehicle-uninsured-bipd-limit", false) == 0)
                goto label_736;
              continue;
            case 571641065:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_keyemployeename", false) == 0)
                goto label_765;
              continue;
            case 579610625:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-unins-motor-pd", false) == 0)
                goto label_736;
              continue;
            case 586970773:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clfax", false) == 0)
              {
                tag.TagValue = this.Quote.CompanyLocation.Fax;
                continue;
              }
              continue;
            case 594558953:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-removedvehicles-stated-amount", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateRemovedVehicles", new object[4]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@StateAmount",
                  (object) "Y"
                });
                continue;
              }
              continue;
            case 594792930:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-blanketcoll-ded", false) == 0)
                goto label_736;
              continue;
            case 606540246:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "noc_pastdueamount", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar("spGetNOCTagValue", new object[4]
                {
                  (object) "@ControlNumber",
                  (object) this.Quote.ControlNo,
                  (object) "@tagValue",
                  (object) tag.InnerTagName.ToLower()
                }).ToString();
                continue;
              }
              continue;
            case 613568944:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "wc_experiencemod", false) == 0)
                goto label_811;
              continue;
            case 619251015:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "endcomoi", false) == 0)
              {
                using (RichTextBox richTextBox = new RichTextBox())
                {
                  richTextBox.Rtf = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select EndorsementText from tblEndorsementInfo where QuoteID = @QuoteID", new object[2]
                  {
                    (object) "@QuoteID",
                    (object) this.Quote.QuoteID
                  })), "");
                  tag.TagValue = richTextBox.Text;
                  continue;
                }
              }
              continue;
            case 624704614:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clregion", false) == 0)
              {
                tag.TagValue = this.Quote.CompanyLocation.Region;
                continue;
              }
              continue;
            case 628124275:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms-number-name-table-marknew", false) == 0)
              {
                tag.TagTable = this.FormsTableNumberName_marknew(this.Quote.QuoteGuid);
                continue;
              }
              continue;
            case 635788106:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "noc_dateofcancellation", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar("spGetNOCTagValue", new object[4]
                {
                  (object) "@ControlNumber",
                  (object) this.Quote.ControlNo,
                  (object) "@tagValue",
                  (object) tag.InnerTagName.ToLower()
                }).ToString();
                continue;
              }
              continue;
            case 636870025:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "quoted_nontaxes_only", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateTotalNonTaxes", new object[4]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@Bound",
                  (object) false
                });
                continue;
              }
              continue;
            case 639004743:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "warranties-crlf", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocWarranties", new object[4]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid,
                  (object) "@LineSeparated",
                  (object) true
                });
                continue;
              }
              continue;
            case 650367404:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "sic-desc", false) == 0)
                break;
              continue;
            case 653867298:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms-number-edit-name-table", false) == 0)
              {
                tag.TagTable = this.FormsTableNumberEditName(this.Quote.QuoteGuid);
                continue;
              }
              continue;
            case 660553440:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionalcomments", false) == 0)
              {
                object netRateTagValue = (object) this.GetNetRateTagValue(tag.InnerTagName.ToLower(), placedByCompanyLineID);
                tag.TagValue = netRateTagValue.ToString();
                RichTextBox richTextBox = new RichTextBox();
                try
                {
                  richTextBox.Rtf = netRateTagValue.ToString();
                  tag.TagValue = richTextBox.Text.Replace("\n", "\r\n");
                  continue;
                }
                catch (ArgumentException ex)
                {
                  ProjectData.SetProjectError((Exception) ex);
                  ProjectData.ClearProjectError();
                  continue;
                }
                finally
                {
                  richTextBox.Dispose();
                }
              }
              else
                continue;
            case 671708503:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_un_mot_sym", false) == 0)
                goto label_787;
              continue;
            case 676515892:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "wc_annivdate", false) == 0)
                goto label_811;
              continue;
            case 705506939:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "feesandpremiums", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocFeeAndPremiumListing", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid
                });
                continue;
              }
              continue;
            case 712843449:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ins_billingaddress", false) == 0)
                goto label_762;
              continue;
            case 713261162:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-blanket-limit-building-contents", false) == 0)
                goto label_736;
              continue;
            case 714869625:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uwf", false) == 0)
              {
                tag.TagValue = this.Quote.Underwriter.FirstName;
                continue;
              }
              continue;
            case 716908828:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother_coll_ded", false) == 0)
                goto label_736;
              continue;
            case 717037299:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-dealer-false-ptnse-limit", false) == 0)
                goto label_736;
              continue;
            case 717641980:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_mrep_basis", false) == 0)
                goto label_787;
              continue;
            case 723335921:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "feelisting_namefirst", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("spGetFeeListingNameFirst", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid
                }).ToString();
                continue;
              }
              continue;
            case 726043763:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "quoting_office_dba", false) == 0)
                break;
              continue;
            case 740367312:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_qrep_basis", false) == 0)
                goto label_787;
              continue;
            case 741499301:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "in_prod_phone_ext", false) == 0)
                goto label_841;
              continue;
            case 742420063:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_driveother_uim", false) == 0)
                goto label_736;
              continue;
            case 748186334:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insureddba", false) == 0)
              {
                tag.TagValue = this.Quote.InsuredDBA;
                continue;
              }
              continue;
            case 764755291:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insurerquotashare_table", false) == 0)
              {
                tag.TagTable = this.insurerquotashare_table(this.Quote.QuoteGuid);
                continue;
              }
              continue;
            case 765121275:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "underwriter_signature", false) == 0)
                goto label_827;
              continue;
            case 774004334:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "retailer_phone", false) == 0)
                goto label_763;
              continue;
            case 779364471:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pol_np", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>((object) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT NumPayments FROM tblInstallmentBilling INNER JOIN tblQuotes ON tblQuotes.InstallmentBillingQuoteOptionID=tblInstallmentBilling.QuoteOptionID WHERE tblQuotes.QuoteGuid=@QuoteGuid", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid
                }).ToString(), string.Empty);
                continue;
              }
              continue;
            case 783506531:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "in_prod_signature", false) == 0)
              {
                byte[] buffer = DefaultDatabase.ExecuteScalar<byte[]>("GetTemplateInHouseProducerInfo", new object[4]
                {
                  (object) "@quoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@TagName",
                  (object) tag.InnerTagName.ToLower()
                });
                if (buffer != null)
                {
                  Bitmap bitmap = new Bitmap((Stream) new MemoryStream(buffer));
                  tag.TagImage = (Image) bitmap;
                  continue;
                }
                continue;
              }
              continue;
            case 790990427:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_lpcoll", false) == 0)
                goto label_787;
              continue;
            case 797781456:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "glrater_deductible_desc", false) == 0)
                goto label_801;
              continue;
            case 815535339:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uwl", false) == 0)
              {
                tag.TagValue = this.Quote.Underwriter.LastName;
                continue;
              }
              continue;
            case 818536030:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "glrater_prodcomp_ops_limit", false) == 0)
                goto label_801;
              continue;
            case 828726049:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cpny_line_signature_ceo_name", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>(CommandType.StoredProcedure, "TemplateCompanyLineSignature_FirstLastName", new object[4]
                {
                  (object) "@quoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@Title",
                  (object) "CEO"
                });
                continue;
              }
              continue;
            case 844766312:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "dealer_service_coll_waiver", false) == 0)
                goto label_816;
              continue;
            case 844900829:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pol_dp", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>((object) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Downpayment FROM tblInstallmentBilling INNER JOIN tblQuotes ON tblQuotes.InstallmentBillingQuoteOptionID=tblInstallmentBilling.QuoteOptionID WHERE tblQuotes.QuoteGuid=@QuoteGuid", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid
                }).ToString(), string.Empty);
                continue;
              }
              continue;
            case 865868196:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uwi", false) == 0)
              {
                tag.TagValue = this.Quote.Underwriter.Initials;
                continue;
              }
              continue;
            case 882297658:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cmpnycntct_fax", false) == 0)
              {
                tag.TagValue = this._quoteHasIntermediary.HasValue ? (!this._quoteHasIntermediary.Value ? this._companyContact.Fax : this._intermediaryContact.Fax) : string.Empty;
                continue;
              }
              continue;
            case 907387132:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_ky_weeklyloss", false) == 0)
                goto label_736;
              continue;
            case 908348472:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "wc_bi_policy", false) == 0)
                goto label_811;
              continue;
            case 917783134:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pmnt_schd_wo_dnpayment_table", false) == 0)
              {
                tag.TagTable = this.pmnt_schd_wo_dnpayment_table(this.Quote.QuoteGuid);
                continue;
              }
              continue;
            case 918929339:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-addedvehicles-stated-amount", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateAddedVehicleswithStateAmt", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid
                });
                continue;
              }
              continue;
            case 939569534:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-prorata", false) == 0)
                goto label_736;
              continue;
            case 949756291:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uwt", false) == 0)
              {
                tag.TagValue = this.Quote.Underwriter.Title;
                continue;
              }
              continue;
            case 955570958:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-vehicle-uninsured-pd-limit", false) == 0)
                goto label_736;
              continue;
            case 962834523:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cmpnycntct_cell", false) == 0)
              {
                tag.TagValue = this._quoteHasIntermediary.HasValue ? (!this._quoteHasIntermediary.Value ? this._companyContact.Cell : this._intermediaryContact.Cell) : string.Empty;
                continue;
              }
              continue;
            case 967346001:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_aicoll", false) == 0)
                goto label_787;
              continue;
            case 968149581:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "feelisting", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("spGetFeeListing", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid
                }).ToString();
                continue;
              }
              continue;
            case 970216833:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clzip", false) == 0)
              {
                tag.TagValue = this.Quote.CompanyLocation.ZipCode;
                continue;
              }
              continue;
            case 981147449:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-da-type", false) == 0)
                goto label_736;
              continue;
            case 995211343:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-building-da", false) == 0)
                goto label_736;
              continue;
            case 1000095396:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "company_naic", false) == 0)
                goto label_756;
              continue;
            case 1000248993:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "quotestatus", false) == 0)
                break;
              continue;
            case 1013288276:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother_uim_premium_included", false) == 0)
                goto label_816;
              continue;
            case 1032931577:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prodcom", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("TemplateDocCommissionPercent", new object[4]
                {
                  (object) "@QuoteID",
                  (object) this.Quote.QuoteID,
                  (object) "@Type",
                  (object) "P"
                })), string.Empty);
                continue;
              }
              continue;
            case 1053922179:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insmobilephone", false) == 0)
              {
                tag.TagValue = this.Quote.InsuredMobileNumber;
                continue;
              }
              continue;
            case 1057691198:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-removedvehicles", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateRemovedVehicles", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid
                });
                continue;
              }
              continue;
            case 1060665208:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "il", false) == 0)
              {
                tag.TagValue = this.Quote.IssuingLocation.LocationName;
                continue;
              }
              continue;
            case 1067206518:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-gk-collision-ded", false) == 0)
                goto label_736;
              continue;
            case 1067837467:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-perclaim-gk-comp-ded", false) == 0)
                goto label_736;
              continue;
            case 1087940282:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clphone", false) == 0)
              {
                tag.TagValue = this.Quote.CompanyLocation.Phone;
                continue;
              }
              continue;
            case 1088558192:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clzp", false) == 0)
              {
                tag.TagValue = this.Quote.CompanyLocation.ZipPlus;
                continue;
              }
              continue;
            case 1088687970:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ilzp", false) == 0)
              {
                tag.TagValue = this.Quote.IssuingLocation.ZipPlus;
                continue;
              }
              continue;
            case 1089974139:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_garks", false) == 0)
                goto label_787;
              continue;
            case 1092024576:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms_count", false) == 0)
              {
                tag.TagValue = Utility.IsNull<int>((object) DefaultDatabase.ExecuteScalar<int?>("spGetNumPolicyForms", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid
                }).ToString(), 0).ToString();
                continue;
              }
              continue;
            case 1094367707:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "premiumfees-additional", false) == 0)
                goto label_555;
              continue;
            case 1112040416:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pcsre", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.tblProducerContacts.Email FROM dbo.tblQuotes INNER JOIN  dbo.tblProducerContacts ON dbo.tblQuotes.SecProducerContactGuid = dbo.tblProducerContacts.ProducerContactGUID WHERE QuoteGuid=@QuoteGuid", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid
                })), string.Empty);
                continue;
              }
              continue;
            case 1117469535:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pol_dpandfees", false) == 0)
                break;
              continue;
            case 1118853384:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-dealers-med-limit", false) == 0)
                goto label_736;
              continue;
            case 1124108189:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_underlying_carrier", false) == 0)
                break;
              continue;
            case 1142157939:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-ba-bi-pp-da", false) == 0)
                goto label_736;
              continue;
            case 1143559708:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-vehicle-underinsured-limit", false) == 0)
                goto label_736;
              continue;
            case 1146443482:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother_um_coll_included", false) == 0)
                goto label_816;
              continue;
            case 1160081746:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-eaocc", false) == 0)
                goto label_736;
              continue;
            case 1160992154:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "wc_premiumdiscount", false) == 0)
                goto label_811;
              continue;
            case 1162373273:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pcsrf", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.tblProducerContacts.FName FROM dbo.tblQuotes INNER JOIN  dbo.tblProducerContacts ON dbo.tblQuotes.SecProducerContactGuid = dbo.tblProducerContacts.ProducerContactGUID WHERE QuoteGuid=@QuoteGuid", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid
                })), string.Empty);
                continue;
              }
              continue;
            case 1188458103:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "in_prod_title", false) == 0)
                goto label_841;
              continue;
            case 1193648272:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother-liab-limit", false) == 0)
                goto label_736;
              continue;
            case 1196413478:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pcf", false) == 0)
              {
                tag.TagValue = this.Quote.ProducerContactFirst;
                continue;
              }
              continue;
            case 1211694507:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "auto_liabilitylimit_csl_check", false) == 0)
                goto label_815;
              continue;
            case 1221479392:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop-limit-no-desc", false) == 0)
                break;
              continue;
            case 1221875183:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop-primaryprem", false) == 0)
                break;
              continue;
            case 1225995709:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother_comp_premium", false) == 0)
                goto label_736;
              continue;
            case 1239087876:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_building_ordinance_table", false) == 0)
              {
                tag.TagTable = this.OrdinanceTbl(this.Quote.QuoteGuid, placedByCompanyLineID);
                continue;
              }
              continue;
            case 1260821332:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother_coll_premium", false) == 0)
                goto label_736;
              continue;
            case 1263038987:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pcsrl", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.tblProducerContacts.LName FROM dbo.tblQuotes INNER JOIN  dbo.tblProducerContacts ON dbo.tblQuotes.SecProducerContactGuid = dbo.tblProducerContacts.ProducerContactGUID WHERE QuoteGuid=@QuoteGuid", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid
                })), string.Empty);
                continue;
              }
              continue;
            case 1263117669:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insadrfull", false) == 0)
              {
                tag.TagValue = this.Quote.InsuredAddressFull;
                continue;
              }
              continue;
            case 1281713313:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uwa_signature", false) == 0)
                goto label_827;
              continue;
            case 1282132022:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_in_bi_only_um", false) == 0)
                goto label_736;
              continue;
            case 1293876647:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-dealer-um-bipd-limit", false) == 0)
                goto label_736;
              continue;
            case 1297079192:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pcl", false) == 0)
              {
                tag.TagValue = this.Quote.ProducerContactLast;
                continue;
              }
              continue;
            case 1301395106:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "quotestatuscomment", false) == 0)
                break;
              continue;
            case 1307770422:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "csrfax", false) == 0)
                goto label_634;
              continue;
            case 1311453577:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_lpscl", false) == 0)
                goto label_787;
              continue;
            case 1312329493:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "is", false) == 0)
              {
                tag.TagValue = this.Quote.InsuredState;
                continue;
              }
              continue;
            case 1323334768:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "wc_expenseconstant", false) == 0)
                goto label_811;
              continue;
            case 1326395456:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "feesandpremiums_table", false) == 0)
              {
                tag.TagTable = this.feesandpremiums_table(this.Quote.QuoteGuid);
                continue;
              }
              continue;
            case 1345364684:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "retailer_address2", false) == 0)
                goto label_763;
              continue;
            case 1350283210:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "underwriteraddress", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.FormatAddress(tblUsers.Address1, tblUsers.Address2, tblUsers.City, tblUsers.State, tblUsers.ZipCode, tblUsers.ZipPlus) FROM tblUsers WHERE UserGuid = @UserGuid", new object[2]
                {
                  (object) "@UserGuid",
                  (object) this.Quote.Underwriter.UserGuid
                })), string.Empty);
                continue;
              }
              continue;
            case 1363453464:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms-crlf", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocForms", new object[4]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@LineFeedSeperated",
                  (object) true
                });
                continue;
              }
              continue;
            case 1369915685:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_concoll", false) == 0)
                goto label_787;
              continue;
            case 1378541934:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "underwriteremail", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT EmailAddress FROM tblUsers WHERE UserGuid = @UserGuid", new object[2]
                {
                  (object) "@UserGuid",
                  (object) this.Quote.Underwriter.UserGuid
                })), "");
                continue;
              }
              continue;
            case 1387876424:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "company_size", false) == 0)
                break;
              continue;
            case 1395697541:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "retailer_address1", false) == 0)
                goto label_763;
              continue;
            case 1396025799:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "policytype", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>((object) DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT lstPolicyTypes.Description FROM tblQuotes INNER JOIN lstPolicyTypes ON tblQuotes.PolicyTypeID = lstPolicyTypes.PolicyTypeID WHERE QuoteGuid = @QuoteGuid", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid
                }), string.Empty);
                continue;
              }
              continue;
            case 1396259624:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop-causeofloss", false) == 0)
                break;
              continue;
            case 1403252331:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prodlogo", false) == 0)
              {
                try
                {
                  byte[] buffer = (byte[]) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT  top 1   dbo.tblProducers.Logo  FROM   dbo.tblQuotes INNER JOIN  dbo.tblSubmissionGroup ON dbo.tblQuotes.SubmissionGroupGuid = dbo.tblSubmissionGroup.SubmissionGroupGUID INNER JOIN  dbo.tblProducerLocations ON dbo.tblSubmissionGroup.ProducerLocationGuid = dbo.tblProducerLocations.ProducerLocationGUID INNER JOIN dbo.tblProducers ON dbo.tblProducerLocations.ProducerGUID = dbo.tblProducers.ProducerGUID WHERE dbo.tblQuotes.Quoteguid = @QuoteGuid", new object[2]
                  {
                    (object) "@QuoteGuid",
                    (object) this.Quote.QuoteGuid
                  });
                  if (buffer != null)
                  {
                    tag.TagImage = (Image) new Bitmap((Stream) new MemoryStream(buffer));
                    continue;
                  }
                  continue;
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                  continue;
                }
              }
              else
                continue;
            case 1404517567:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "feelisting_linebreaks_showall_namefirst", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("spGetFeeListingNameFirst", new object[6]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@LineBreaks",
                  (object) true,
                  (object) "@BoundOnly",
                  (object) false
                }).ToString();
                continue;
              }
              continue;
            case 1405770769:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms-editdate-crlf", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("Forms_EditDate", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid
                });
                continue;
              }
              continue;
            case 1411496040:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "expiration", false) == 0)
              {
                DocTag docTag = tag;
                dateTime = Quote.FromControlNo(this.Quote.ControlNo).ExpirationDate;
                string str = dateTime.ToString();
                docTag.TagValue = str;
                continue;
              }
              continue;
            case 1411954731:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-gl-pd-da-per-occ", false) == 0)
                goto label_764;
              continue;
            case 1415265986:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "in_prod_fax", false) == 0)
                goto label_841;
              continue;
            case 1439697521:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "minearn", false) == 0)
              {
                object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT MinimumEarnedPercentage FROM tblQuotes WHERE QuoteGuid=@QuoteGuid", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid
                }));
                tag.TagValue = objectValue != DBNull.Value ? Conversions.ToDouble(objectValue).ToString("p0") : string.Empty;
                continue;
              }
              continue;
            case 1440592234:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "qlzp", false) == 0)
              {
                tag.TagValue = this.Quote.QuotingLocation.ZipPlus;
                continue;
              }
              continue;
            case 1448084483:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms-name-number-table", false) == 0)
              {
                tag.TagTable = this.FormsTableNameNumber(this.Quote.QuoteGuid);
                continue;
              }
              continue;
            case 1451793163:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "riskdesc", false) == 0)
              {
                tag.TagValue = this.Quote.RiskDescription;
                continue;
              }
              continue;
            case 1452964680:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-bi-indemnity", false) == 0)
                goto label_736;
              continue;
            case 1464370415:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pcsrp", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.tblProducerContacts.Phone FROM dbo.tblQuotes INNER JOIN  dbo.tblProducerContacts ON dbo.tblQuotes.SecProducerContactGuid = dbo.tblProducerContacts.ProducerContactGUID WHERE QuoteGuid=@QuoteGuid", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid
                })), string.Empty);
                continue;
              }
              continue;
            case 1477434251:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_risk_address", false) == 0)
              {
                if (this.Quote.RatedInNetRate)
                {
                  tag.TagValue = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT TOP 1 dbo.FormatAddress(Address, [P.O.Box], City, State, ZipCode, NULL) FROM NetRate_Quote_Insur_Quote_Locat WHERE QuoteID = @QID", new object[2]
                  {
                    (object) "@QID",
                    (object) this.Quote.NetRateQuoteID
                  }) ?? string.Empty;
                  continue;
                }
                tag.TagValue = string.Empty;
                continue;
              }
              continue;
            case 1483522505:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother_comp_ded", false) == 0)
                goto label_736;
              continue;
            case 1493145534:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-pp-lim", false) == 0)
                goto label_736;
              continue;
            case 1495251085:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insured", false) == 0)
              {
                tag.TagValue = this.Quote.InsuredPolicyName;
                continue;
              }
              continue;
            case 1498410620:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pcp", false) == 0)
                break;
              continue;
            case 1499991159:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ins_fulladdr_oneln", false) == 0)
                goto label_762;
              continue;
            case 1508342650:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insfax", false) == 0)
              {
                tag.TagValue = this.Quote.InsuredFax;
                continue;
              }
              continue;
            case 1517920767:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cpny_line_signature", false) == 0)
              {
                byte[] buffer = (byte[]) DefaultDatabase.ExecuteScalar("TemplateCompanyLineAuthorizedSignature", new object[4]
                {
                  (object) "@quoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@companyLineID",
                  (object) placedByCompanyLineID
                });
                if (buffer != null)
                {
                  Bitmap bitmap = new Bitmap((Stream) new MemoryStream(buffer));
                  tag.TagImage = (Image) bitmap;
                  continue;
                }
                continue;
              }
              continue;
            case 1522959449:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms-showonquote", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocForms", new object[14]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@LineFeedSeperated",
                  (object) 0,
                  (object) "@ShowFormNumbers",
                  (object) 0,
                  (object) "@ShowFormNames",
                  (object) 1,
                  (object) "@NamesThenNumbers",
                  (object) 0,
                  (object) "@NameNumberSeperator",
                  (object) "  ",
                  (object) "@ShowonQuote",
                  (object) "Y"
                });
                continue;
              }
              continue;
            case 1543062005:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_sublimits", false) == 0)
              {
                tag.TagTable = this.PropertySublimits(this.Quote.QuoteGuid);
                continue;
              }
              continue;
            case 1544316724:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-dealer-medical-limit", false) == 0)
                goto label_736;
              continue;
            case 1545468608:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "policy_and_inspection_fees", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplatePolicyAndInspectionFees", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid
                });
                continue;
              }
              continue;
            case 1548743477:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pcs", false) == 0)
              {
                tag.TagValue = this.Quote.ProducerContactSalutation;
                continue;
              }
              continue;
            case 1549467185:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clclaimfax", false) == 0)
              {
                tag.TagValue = this.Quote.CompanyLocation.ClaimFax;
                continue;
              }
              continue;
            case 1552581826:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "endinfo_limitsexposure", false) == 0)
                goto label_802;
              continue;
            case 1588223688:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driver_list", false) == 0)
                goto label_815;
              continue;
            case 1590916463:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_risk_all_addresses", false) == 0)
              {
                if (this.Quote.RatedInNetRate)
                {
                  tag.TagValue = DefaultDatabase.ExecuteScalar<string>("spGetNetrateRiskAllAddresses", new object[2]
                  {
                    (object) "@QuoteGuid",
                    (object) this.Quote.QuoteGuid
                  }).ToString();
                  continue;
                }
                tag.TagValue = string.Empty;
                continue;
              }
              continue;
            case 1594655258:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "totalpremiumandfees", false) == 0)
                break;
              continue;
            case 1598828944:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ql", false) == 0)
              {
                tag.TagValue = this.Quote.QuotingLocation.LocationName;
                continue;
              }
              continue;
            case 1622938974:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_prop_pro_sym", false) == 0)
                goto label_787;
              continue;
            case 1623064831:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "dealer_service_fire_legal_limit", false) == 0)
                goto label_816;
              continue;
            case 1635016058:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-gl-combined-da-per-occ", false) == 0)
                goto label_764;
              continue;
            case 1637046008:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother_um_deductible", false) == 0)
                goto label_816;
              continue;
            case 1642175994:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-building-wind-da", false) == 0)
                goto label_736;
              continue;
            case 1651953364:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_limit", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar("TemplateDocQuoteProperty", new object[6]
                {
                  (object) "@placedByCompanyLineID",
                  (object) placedByCompanyLineID,
                  (object) "@quoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@tagName",
                  (object) tag.InnerTagName.ToLower()
                }).ToString();
                continue;
              }
              continue;
            case 1656997532:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "retailer_zipcode", false) == 0)
                goto label_763;
              continue;
            case 1663673754:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cl", false) == 0)
              {
                tag.TagValue = this.Quote.CompanyLocation.LocationName;
                continue;
              }
              continue;
            case 1673224789:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "fees-return", false) == 0)
                goto label_564;
              continue;
            case 1679125321:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_alaska_bi_only_limit", false) == 0)
                goto label_736;
              continue;
            case 1681973609:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother_liability_premium", false) == 0)
                goto label_736;
              continue;
            case 1688635212:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "il_fulladdress", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateClientOfficeInfo", new object[4]
                {
                  (object) "@ClientOfficeGuid",
                  (object) this.Quote.IssuingLocationGuid,
                  (object) "@TagName",
                  (object) tag.InnerTagName.ToLower()
                });
                continue;
              }
              continue;
            case 1694606815:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_annual_trans_premium", false) == 0)
                goto label_736;
              continue;
            case 1707051868:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "company_strength", false) == 0)
                break;
              continue;
            case 1708007138:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "broad_fire_legal_limit", false) == 0)
                goto label_816;
              continue;
            case 1725631071:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "bound_terrorism_premium", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateTotalTerrorism", new object[4]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@Bound",
                  (object) true
                });
                continue;
              }
              continue;
            case 1740730629:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "endeff", false) == 0)
                break;
              continue;
            case 1749941337:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "quoting_user_license_num", false) == 0)
                break;
              continue;
            case 1762874208:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insadr", false) == 0)
              {
                tag.TagValue = (this.Quote.InsuredAddress1?.TrimEnd() ?? string.Empty).TrimEnd() + (string.IsNullOrEmpty(this.Quote.InsuredAddress2) ? string.Empty : ", " + this.Quote.InsuredAddress2);
                continue;
              }
              continue;
            case 1770036119:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_conscl", false) == 0)
                goto label_787;
              continue;
            case 1771888475:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "quoted_fees", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateTotalFees", new object[8]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@Bound",
                  (object) false,
                  (object) "@Payable",
                  (object) true,
                  (object) "@NonPayable",
                  (object) true
                });
                continue;
              }
              continue;
            case 1779611368:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cmpnycntct_fname", false) == 0)
              {
                tag.TagValue = this._quoteHasIntermediary.HasValue ? (!this._quoteHasIntermediary.Value ? this._companyContact.FName : this._intermediaryContact.FName) : string.Empty;
                continue;
              }
              continue;
            case 1786193705:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "total_indicated_fees", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateQuoteInfo", new object[4]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@TagName",
                  (object) tag.InnerTagName.ToLower()
                });
                continue;
              }
              continue;
            case 1794782744:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ins_billingaddress1", false) == 0)
                goto label_762;
              continue;
            case 1804648989:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "retailer_zipplus", false) == 0)
                goto label_763;
              continue;
            case 1807674885:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_lia_sym", false) == 0)
                goto label_787;
              continue;
            case 1816087046:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_alaska_bi_only_x", false) == 0)
                goto label_736;
              continue;
            case 1824916977:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "auto_fire_theft", false) == 0)
              {
                tag.TagTable = this.AutoFireTheft(this.Quote.QuoteGuid, placedByCompanyLineID);
                continue;
              }
              continue;
            case 1845115601:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ins_billingaddress2", false) == 0)
                goto label_762;
              continue;
            case 1846846460:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "retailer_contact_fname", false) == 0)
                goto label_763;
              continue;
            case 1850750004:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_additionalcomments", false) == 0)
              {
                tag.TagValue = PolicyTagParser.StripRTF(Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select additionalcomments from tblGenericLimits where QuoteID = @QuoteID", new object[2]
                {
                  (object) "@QuoteID",
                  (object) this.Quote.QuoteID
                })), string.Empty));
                continue;
              }
              continue;
            case 1853744238:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_limit", false) == 0)
              {
                tag.TagValue = PolicyTagParser.StripRTF(Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select Limit from tblGenericLimits where QuoteID = @QuoteID", new object[2]
                {
                  (object) "@QuoteID",
                  (object) this.Quote.QuoteID
                })), string.Empty));
                continue;
              }
              continue;
            case 1855606137:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "adint", false) == 0)
              {
                DataRow row = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT InterestName, Address1 + ISNULL(@comma + Address2, cast(0x as varchar)) + ISNULL(@space + City, cast(0x as varchar)) + ISNULL(@comma + StateID, cast(0x as varchar)) + ISNULL(@space + ZipCode, cast(0x as varchar)) AS Address FROM tblQuoteAdditionalInterests WHERE ID=@ID", new object[6]
                {
                  (object) "@ID",
                  (object) this.id,
                  (object) "@comma",
                  (object) ", ",
                  (object) "@space",
                  (object) " "
                }).Rows[0];
                tag.TagValue = $"{row[0].ToString()}   {row[1].ToString()}\n";
                continue;
              }
              continue;
            case 1887504519:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pcfax", false) == 0)
                break;
              continue;
            case 1903605733:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "endinfo_coveredproplocdesc", false) == 0)
                goto label_802;
              continue;
            case 1907931906:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_pdcols", false) == 0)
                goto label_787;
              continue;
            case 1911377647:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "policy_effective_time", false) == 0)
                goto label_762;
              continue;
            case 1932095114:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_ky_funeralexpenses", false) == 0)
                goto label_736;
              continue;
            case 1932336919:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prod_loc_code", false) == 0)
                break;
              continue;
            case 1948879580:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-nonowened-phydam-premium", false) == 0)
                goto label_736;
              continue;
            case 1961014030:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_uscomp", false) == 0)
                goto label_787;
              continue;
            case 1963269595:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ins_fulladdress", false) == 0)
                goto label_762;
              continue;
            case 1972623155:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ufax", false) == 0)
                break;
              continue;
            case 1977690054:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_add_pro_sym", false) == 0)
                goto label_787;
              continue;
            case 1979780695:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-bi-coins", false) == 0)
                goto label_736;
              continue;
            case 1984656398:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "quotedpremiumandfees", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateQuotedPremiumAndFees", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid
                });
                continue;
              }
              continue;
            case 1987510781:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-dealer-liab-limit", false) == 0)
                goto label_736;
              continue;
            case 1990835990:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cpny_line_signature_title", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>(CommandType.StoredProcedure, "TemplateCompanyLineAuthorizedSignature_Title", new object[4]
                {
                  (object) "@quoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@companyLineID",
                  (object) placedByCompanyLineID
                });
                continue;
              }
              continue;
            case 2011796244:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "feesandpremiums_v2", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocFeeAndPremiumListing_v2", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid
                });
                continue;
              }
              continue;
            case 2025706540:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "minearnpct", false) == 0)
                break;
              continue;
            case 2047152733:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "retailer_name", false) == 0)
                goto label_763;
              continue;
            case 2047814436:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cpny_line_signature_endorsement", false) == 0)
              {
                byte[] buffer = (byte[]) DefaultDatabase.ExecuteScalar("TemplateCompanyLineAuthorizedSignature", new object[6]
                {
                  (object) "@quoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@companyLineID",
                  (object) placedByCompanyLineID,
                  (object) "@endorsement",
                  (object) "YES"
                });
                if (buffer != null)
                {
                  Bitmap bitmap = new Bitmap((Stream) new MemoryStream(buffer));
                  tag.TagImage = (Image) bitmap;
                  continue;
                }
                continue;
              }
              continue;
            case 2051440024:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ucellphone", false) == 0)
                break;
              continue;
            case 2053753696:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "premiumfees-return", false) == 0)
                goto label_555;
              continue;
            case 2054026138:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop-causeofloss-full", false) == 0)
                break;
              continue;
            case 2059451223:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-bi-perperson", false) == 0)
                goto label_736;
              continue;
            case 2070003832:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-perauto-gk-comp-ded", false) == 0)
                goto label_736;
              continue;
            case 2073558866:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pip_workloss_prem", false) == 0)
                goto label_816;
              continue;
            case 2080443357:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "doc_interests", false) == 0)
                goto label_816;
              continue;
            case 2082303575:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clad2", false) == 0)
              {
                tag.TagValue = this.Quote.CompanyLocation.Address2;
                continue;
              }
              continue;
            case 2093361157:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cmpnycntct_salutation", false) == 0)
              {
                tag.TagValue = this._quoteHasIntermediary.HasValue ? (!this._quoteHasIntermediary.Value ? this._companyContact.Salutation : this._intermediaryContact.Salutation) : string.Empty;
                continue;
              }
              continue;
            case 2099081194:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clad1", false) == 0)
              {
                tag.TagValue = this.Quote.CompanyLocation.Address1;
                continue;
              }
              continue;
            case 2112829827:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "qla2", false) == 0)
              {
                tag.TagValue = this.Quote.QuotingLocation.Address2;
                continue;
              }
              continue;
            case 2117118014:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "premium", false) == 0)
                goto label_546;
              continue;
            case 2122697689:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "retailer_city", false) == 0)
                goto label_763;
              continue;
            case 2129607446:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "qla1", false) == 0)
              {
                tag.TagValue = this.Quote.QuotingLocation.Address1;
                continue;
              }
              continue;
            case 2137749094:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-nonowened-phydam-limit", false) == 0)
                goto label_736;
              continue;
            case 2143393500:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocForms", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid
                });
                continue;
              }
              continue;
            case 2149903855:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-bi-peracc", false) == 0)
                goto label_736;
              continue;
            case 2162217143:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "conditions", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocConditions", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid
                });
                continue;
              }
              continue;
            case 2181427033:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "filingnotes", false) == 0)
              {
                using (RichTextBox richTextBox = new RichTextBox())
                {
                  richTextBox.Rtf = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.tblStateSLRules.OtherInfo FROM dbo.tblCompanyLines INNER JOIN dbo.tblQuotes ON dbo.tblCompanyLines.CompanyLineGUID = dbo.tblQuotes.CompanyLineGuid INNER JOIN dbo.tblStateSLRules ON dbo.tblCompanyLines.StateID = dbo.tblStateSLRules.StateID where QuoteID = @QuoteID", new object[2]
                  {
                    (object) "@QuoteID",
                    (object) this.Quote.QuoteID
                  })), "");
                  tag.TagValue = richTextBox.Text;
                  continue;
                }
              }
              continue;
            case 2198839654:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-dealer-um-pd-limit", false) == 0)
                goto label_736;
              continue;
            case 2213250777:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_dealer_service_mi_broad_coll", false) == 0)
                goto label_736;
              continue;
            case 2218805117:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_undn_mot_sym", false) == 0)
                goto label_787;
              continue;
            case 2222100877:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_bod_inj_dis_agg", false) == 0)
                goto label_787;
              continue;
            case 2223450696:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "statefilingnotes", false) == 0)
              {
                object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT S.Description  FROM  tblStateSLRules S WITH (NOLOCK) INNER JOIN tblQuotes Q WITH (NOLOCK) ON S.StateID = Q.StateID WHERE (Q.QuoteGUID = @QG) ", new object[2]
                {
                  (object) "@QG",
                  (object) this.Quote.QuoteGuid
                }));
                if (objectValue != null && objectValue != DBNull.Value)
                {
                  tag.TagValue = PolicyTagParser.StripRTF(objectValue.ToString());
                  continue;
                }
                continue;
              }
              continue;
            case 2226190772:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ins_billingcity", false) == 0)
                goto label_762;
              continue;
            case 2254926436:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "feelisting_linebreaks_namefirst", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("spGetFeeListingNameFirst", new object[4]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@LineBreaks",
                  (object) true
                }).ToString();
                continue;
              }
              continue;
            case 2274057857:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "nonowned_auto_limit", false) == 0)
                goto label_736;
              continue;
            case 2279823398:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ilz", false) == 0)
              {
                tag.TagValue = this.Quote.IssuingLocation.ZipCode;
                continue;
              }
              continue;
            case 2289287652:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "endinfo_covformsendorse", false) == 0)
                goto label_802;
              continue;
            case 2289663794:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-perclaim-dealer-comp-ded", false) == 0)
                goto label_736;
              continue;
            case 2300369227:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ila2", false) == 0)
              {
                tag.TagValue = this.Quote.IssuingLocation.Address2;
                continue;
              }
              continue;
            case 2304795942:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-da", false) == 0)
                goto label_736;
              continue;
            case 2311621431:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pip_deathbenefits", false) == 0)
                goto label_816;
              continue;
            case 2317146846:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ila1", false) == 0)
              {
                tag.TagValue = this.Quote.IssuingLocation.Address1;
                continue;
              }
              continue;
            case 2324616902:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_covering", false) == 0)
              {
                tag.TagValue = PolicyTagParser.StripRTF(Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select covering from tblGenericLimits where QuoteID = @QuoteID", new object[2]
                {
                  (object) "@QuoteID",
                  (object) this.Quote.QuoteID
                })), string.Empty));
                continue;
              }
              continue;
            case 2352565782:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-ba-propdmg-pa-da", false) == 0)
                goto label_736;
              continue;
            case 2359167316:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop-floodlimit", false) == 0)
                break;
              continue;
            case 2361861790:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "csr_signature", false) == 0)
                goto label_827;
              continue;
            case 2362298226:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms-crlf-number-slash-name", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocForms", new object[12]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@LineFeedSeperated",
                  (object) true,
                  (object) "@ShowFormNumbers",
                  (object) true,
                  (object) "@ShowFormNames",
                  (object) true,
                  (object) "@NamesThenNumbers",
                  (object) false,
                  (object) "@NameNumberSeperator",
                  (object) " / "
                });
                continue;
              }
              continue;
            case 2380489112:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ilp", false) == 0)
              {
                tag.TagValue = this.Quote.IssuingLocation.Phone;
                continue;
              }
              continue;
            case 2381765611:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_aopda_curr_int", false) == 0)
                break;
              continue;
            case 2396291428:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uwa_fax", false) == 0)
              {
                tag.TagValue = !this.Quote.HasUnderwriterAssistant ? string.Empty : this.Quote.UnderwriterAssistant.Fax;
                continue;
              }
              continue;
            case 2401608645:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cmpnycntct_email", false) == 0)
              {
                tag.TagValue = this._quoteHasIntermediary.HasValue ? (!this._quoteHasIntermediary.Value ? this._companyContact.Email : this._intermediaryContact.Email) : string.Empty;
                continue;
              }
              continue;
            case 2418378165:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "retailer_fulladdress", false) == 0)
                goto label_763;
              continue;
            case 2430821969:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ils", false) == 0)
              {
                tag.TagValue = this.Quote.IssuingLocation.State;
                continue;
              }
              continue;
            case 2432038038:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "endinfo_insuredlegalstatus", false) == 0)
                goto label_802;
              continue;
            case 2434662106:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_sublimits_limits", false) == 0)
                break;
              continue;
            case 2451248350:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "izp", false) == 0)
              {
                tag.TagValue = this.Quote.InsuredZipPlus;
                continue;
              }
              continue;
            case 2451451421:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "statefilingcomments", false) == 0)
              {
                object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT S.Comments FROM  tblStateSLRules S WITH (NOLOCK) INNER JOIN tblQuotes Q WITH (NOLOCK) ON S.StateID = Q.StateID WHERE (Q.QuoteGUID = @QG) ", new object[2]
                {
                  (object) "@QG",
                  (object) this.Quote.QuoteGuid
                }));
                if (objectValue != null && objectValue != DBNull.Value)
                {
                  tag.TagValue = PolicyTagParser.StripRTF(objectValue.ToString());
                  continue;
                }
                continue;
              }
              continue;
            case 2460472916:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "polnum", false) == 0)
              {
                tag.TagValue = this.Quote.PolicyNumber;
                continue;
              }
              continue;
            case 2464062799:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-pp-valuation", false) == 0)
                goto label_736;
              continue;
            case 2480560140:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uphone", false) == 0)
                break;
              continue;
            case 2532392078:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-unins-motorist", false) == 0)
                goto label_736;
              continue;
            case 2549141620:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_totalpremium", false) == 0)
                break;
              continue;
            case 2553942048:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "intermediarycontactsignature", false) == 0)
              {
                byte[] buffer = (byte[]) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 IC.ContactSignature FROM tblQuoteDetails AS QD WITH (NOLOCK) INNER JOIN  tblIntermediaryContacts AS IC WITH (NOLOCK) ON QD.IntermediaryContactGuid = IC.IntermediaryContactGUID WHERE  QD.QuoteGuid = @QuoteGuid AND IC.ContactSignature IS NOT NULL", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid
                });
                if (buffer != null)
                {
                  Bitmap bitmap = new Bitmap((Stream) new MemoryStream(buffer));
                  tag.TagImage = (Image) bitmap;
                  continue;
                }
                continue;
              }
              continue;
            case 2560826844:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_da", false) == 0)
                break;
              continue;
            case 2573851037:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother_um_comp_included", false) == 0)
                goto label_816;
              continue;
            case 2576044171:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "stateid", false) == 0)
              {
                tag.TagValue = this.Quote.StateID;
                continue;
              }
              continue;
            case 2579702419:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-ba-um-pa", false) == 0)
                goto label_736;
              continue;
            case 2581202641:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "doc_named_broad_cvg", false) == 0)
              {
                tag.TagTable = this.DOCBroadenedCoverage(this.Quote.QuoteGuid, placedByCompanyLineID);
                continue;
              }
              continue;
            case 2585291329:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_keyemployeelimit", false) == 0)
                goto label_765;
              continue;
            case 2588869856:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "auditable", false) == 0)
                break;
              continue;
            case 2602756611:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "company_rating_bureau", false) == 0)
                goto label_756;
              continue;
            case 2606223220:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "fee_rates_table", false) == 0)
              {
                tag.TagTable = this.fee_rates_table(this.Quote.QuoteGuid);
                continue;
              }
              continue;
            case 2617925948:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_pip_sym", false) == 0)
                goto label_787;
              continue;
            case 2621681234:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "premium-without-tria", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateQuoteInfo", new object[4]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@TagName",
                  (object) tag.InnerTagName.ToLower()
                });
                continue;
              }
              continue;
            case 2627057699:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-change-motorcarrier-premium", false) == 0)
                goto label_753;
              continue;
            case 2630081863:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-pp-da", false) == 0)
                goto label_736;
              continue;
            case 2656521351:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_business_income_monthly_limit", false) == 0)
                goto label_736;
              continue;
            case 2657319637:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_pdcfls", false) == 0)
                goto label_787;
              continue;
            case 2659579467:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-building-limit", false) == 0)
                goto label_736;
              continue;
            case 2661035139:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uwa_phone", false) == 0)
              {
                tag.TagValue = !this.Quote.HasUnderwriterAssistant ? string.Empty : this.Quote.UnderwriterAssistant.Phone;
                continue;
              }
              continue;
            case 2664037326:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "minearnpct-desc", false) == 0)
                break;
              continue;
            case 2665183760:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_addlcomments", false) == 0)
                break;
              continue;
            case 2668602079:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "bound_premiumandfees", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateBoundPremiumAndFees", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid
                });
                continue;
              }
              continue;
            case 2675033238:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_trailer_comp_premium", false) == 0)
                goto label_736;
              continue;
            case 2676740984:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "feelisting_linebreaks", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("spGetFeeListing", new object[4]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@LineBreaks",
                  (object) true
                }).ToString();
                continue;
              }
              continue;
            case 2680961665:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "warranties", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocWarranties", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid
                });
                continue;
              }
              continue;
            case 2699098868:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-vehicle-uninsured-pd-premium", false) == 0)
                goto label_736;
              continue;
            case 2699263873:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ilc", false) == 0)
              {
                tag.TagValue = this.Quote.IssuingLocation.City;
                continue;
              }
              continue;
            case 2702912635:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "izc", false) == 0)
              {
                tag.TagValue = this.Quote.InsuredZipCode;
                continue;
              }
              continue;
            case 2703040456:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_in_bi_pd_um", false) == 0)
                goto label_736;
              continue;
            case 2716699230:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms-name-number", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocForms", new object[10]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@LineFeedSeperated",
                  (object) false,
                  (object) "@ShowFormNumbers",
                  (object) true,
                  (object) "@ShowFormNames",
                  (object) true,
                  (object) "@NamesThenNumbers",
                  (object) true
                });
                continue;
              }
              continue;
            case 2719074256:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-accepted-terr", false) == 0)
                goto label_736;
              continue;
            case 2725340072:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_dealer_uim", false) == 0)
                goto label_736;
              continue;
            case 2725936548:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pip_deathbenefits_prem", false) == 0)
                goto label_816;
              continue;
            case 2739692530:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_medexp", false) == 0)
                break;
              continue;
            case 2740946323:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_peradv", false) == 0)
                break;
              continue;
            case 2749596730:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ilf", false) == 0)
              {
                tag.TagValue = this.Quote.IssuingLocation.Fax;
                continue;
              }
              continue;
            case 2773863875:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "in_prod_last_name", false) == 0)
                goto label_841;
              continue;
            case 2775352346:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cmpnycntct_ext", false) == 0)
              {
                tag.TagValue = this._quoteHasIntermediary.HasValue ? (!this._quoteHasIntermediary.Value ? this._companyContact.Extension : this._intermediaryContact.Extension) : string.Empty;
                continue;
              }
              continue;
            case 2779105929:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "exppolnum", false) == 0)
              {
                tag.TagValue = this.Quote.PolicyType != PolicyTypes.NewBusiness ? this.Quote.ExpiringPolicyNumber : "New";
                continue;
              }
              continue;
            case 2782447220:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_nonrep_basis", false) == 0)
                goto label_787;
              continue;
            case 2786500600:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prod_code", false) == 0)
                break;
              continue;
            case 2820090113:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "retailer_contact_email", false) == 0)
                goto label_763;
              continue;
            case 2823511344:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-vehicle-coll-da", false) == 0)
                goto label_736;
              continue;
            case 2831366704:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-ba-um-pp", false) == 0)
                goto label_736;
              continue;
            case 2843015034:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother_med", false) == 0)
                goto label_816;
              continue;
            case 2848139834:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop-covering", false) == 0)
                break;
              continue;
            case 2858608828:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "company", false) == 0)
              {
                tag.TagValue = this.Quote.Company;
                continue;
              }
              continue;
            case 2867784669:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "finance_company_fulladdress", false) == 0)
                goto label_757;
              continue;
            case 2873645193:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother_um_premium_included", false) == 0)
                goto label_816;
              continue;
            case 2879640944:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_genagg", false) == 0)
                break;
              continue;
            case 2881875985:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop-%deductible", false) == 0)
                break;
              continue;
            case 2882201037:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "quotestatusreason", false) == 0)
                break;
              continue;
            case 2890817944:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clcounty", false) == 0)
              {
                tag.TagValue = this.Quote.CompanyLocation.County;
                continue;
              }
              continue;
            case 2897619556:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_deduct", false) == 0)
              {
                tag.TagValue = PolicyTagParser.StripRTF(Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select Deductible from tblGenericLimits where QuoteID = @QuoteID", new object[2]
                {
                  (object) "@QuoteID",
                  (object) this.Quote.QuoteID
                })), string.Empty));
                continue;
              }
              continue;
            case 2911069609:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pip_workloss", false) == 0)
                goto label_816;
              continue;
            case 2914004188:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "endinfo_insuredname", false) == 0)
                goto label_802;
              continue;
            case 2919207717:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insnum", false) == 0)
                break;
              continue;
            case 2921235716:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "sublimit", false) == 0)
              {
                using (RichTextBox richTextBox = new RichTextBox())
                {
                  richTextBox.Rtf = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT ISNULL(tblGenericLimits.SubLimits, cast(0x as varchar)) FROM tblQuotes INNER JOIN tblGenericLimits ON tblQuotes.QuoteID = tblGenericLimits.QuoteID WHERE tblQuotes.QuoteGUid = @QuoteGuid", new object[2]
                  {
                    (object) "@QuoteGuid",
                    (object) this.Quote.QuoteGuid
                  });
                  tag.TagValue = richTextBox.Text;
                  continue;
                }
              }
              continue;
            case 2923577071:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_conscomp", false) == 0)
                goto label_787;
              continue;
            case 2929086978:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-genagg", false) == 0)
                goto label_736;
              continue;
            case 2945113508:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_fincoll", false) == 0)
                goto label_787;
              continue;
            case 2946673533:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "conditions-crlf", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocConditions", new object[4]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid,
                  (object) "@LineSeparated",
                  (object) true
                });
                continue;
              }
              continue;
            case 2977452688:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "statefilingimage", false) == 0)
              {
                object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("spGetStateFilingImage", new object[4]
                {
                  (object) "@StateID",
                  (object) this.Quote.StateID,
                  (object) "@quoteGuid",
                  (object) this.Quote.QuoteGuid
                }));
                if (objectValue != DBNull.Value && objectValue != null)
                {
                  Bitmap bitmap = new Bitmap((Stream) new MemoryStream((byte[]) objectValue));
                  tag.TagImage = (Image) bitmap;
                  continue;
                }
                continue;
              }
              continue;
            case 2985895154:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "effective", false) == 0)
              {
                DocTag docTag = tag;
                dateTime = Quote.FromControlNo(this.Quote.ControlNo).EffectiveDate;
                string str = dateTime.ToString();
                docTag.TagValue = str;
                continue;
              }
              continue;
            case 2988844295:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop-deductible-type", false) == 0)
                break;
              continue;
            case 2989919814:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "autoexp_tableinfo", false) == 0)
              {
                tag.TagTable = this.GetAutoExposureValues(this.Quote.QuoteID);
                continue;
              }
              continue;
            case 2996306386:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "csr_title", false) == 0)
                goto label_634;
              continue;
            case 3002287040:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_excluding", false) == 0)
              {
                tag.TagValue = PolicyTagParser.StripRTF(Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select excluding from tblGenericLimits where QuoteID = @QuoteID", new object[2]
                {
                  (object) "@QuoteID",
                  (object) this.Quote.QuoteID
                })), string.Empty));
                continue;
              }
              continue;
            case 3009218856:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "issueddate", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT CONVERT(varchar(11), DateIssued, 101) FROM dbo.tblQuotes WHERE tblQuotes.QuoteGuid=@QuoteGuid", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid
                })), string.Empty);
                continue;
              }
              continue;
            case 3018241560:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "bound_taxes_only", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateTotalTaxes", new object[4]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@Bound",
                  (object) true
                });
                continue;
              }
              continue;
            case 3018725232:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_nscloss", false) == 0)
                goto label_787;
              continue;
            case 3034933540:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop-sublimit-buildingord", false) == 0)
                break;
              continue;
            case 3045859539:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "premium-return", false) == 0)
                goto label_546;
              continue;
            case 3050479965:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "wc_bi_each_acc", false) == 0)
                goto label_811;
              continue;
            case 3053037142:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_bod_inj_each_acc", false) == 0)
                goto label_787;
              continue;
            case 3061200890:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop-limit", false) == 0)
                break;
              continue;
            case 3061955832:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "riskdescperline", false) == 0)
              {
                tag.TagTable = this.RiskDescriptionPerLine(this.Quote.QuoteGuid);
                continue;
              }
              continue;
            case 3062879605:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_pd_ded", false) == 0)
                goto label_543;
              continue;
            case 3069556329:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_trailer_coll_deductible", false) == 0)
                goto label_736;
              continue;
            case 3097310004:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insureddba_withdba", false) == 0)
              {
                tag.TagValue = !this.Quote.InsuredDBA.Equals(string.Empty) ? "DBA " + this.Quote.InsuredDBA : "";
                continue;
              }
              continue;
            case 3113036793:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_fincomp", false) == 0)
                goto label_787;
              continue;
            case 3127650435:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insadr1", false) == 0)
              {
                tag.TagValue = this.Quote.InsuredAddress1;
                continue;
              }
              continue;
            case 3134665541:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prodloc_email", false) == 0)
                break;
              continue;
            case 3141871203:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cpny_line_signature_name", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>(CommandType.StoredProcedure, "TemplateCompanyLineAuthorizedSignature_Name", new object[4]
                {
                  (object) "@quoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@companyLineID",
                  (object) placedByCompanyLineID
                });
                continue;
              }
              continue;
            case 3144428054:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insadr2", false) == 0)
              {
                tag.TagValue = this.Quote.InsuredAddress2;
                continue;
              }
              continue;
            case 3145595883:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop-policyform", false) == 0)
                break;
              continue;
            case 3145723493:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-blanket-limit-building", false) == 0)
                goto label_736;
              continue;
            case 3153254002:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "optionpremiums", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocOptionPremiumListing", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid
                });
                continue;
              }
              continue;
            case 3153686706:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-pp-wind-da", false) == 0)
                goto label_736;
              continue;
            case 3170916915:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "compcom", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("TemplateDocCommissionPercent", new object[4]
                {
                  (object) "@QuoteID",
                  (object) this.Quote.QuoteID,
                  (object) "@Type",
                  (object) "C"
                })), string.Empty);
                continue;
              }
              continue;
            case 3176958052:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uwa_phoneextension", false) == 0)
              {
                tag.TagValue = !this.Quote.HasUnderwriterAssistant ? string.Empty : this.Quote.UnderwriterAssistant.ContactPhoneExtension;
                continue;
              }
              continue;
            case 3178082228:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "annual_property_premium", false) == 0)
                break;
              continue;
            case 3179257736:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-gl-bi-da-per-occ", false) == 0)
                goto label_764;
              continue;
            case 3185991740:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_bi_ded", false) == 0)
                goto label_543;
              continue;
            case 3202657165:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "wc_foreign_terr_table", false) == 0)
              {
                tag.TagTable = this.WorkersCompForeignTerrorismTable(this._quoteGuid, placedByCompanyLineID);
                continue;
              }
              continue;
            case 3230818469:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "quoted_terrorism_premium", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateTotalTerrorism", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid
                });
                continue;
              }
              continue;
            case 3240502096:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_underlying_deductible", false) == 0)
                break;
              continue;
            case 3244066434:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-vehicle-underinsured-bipd-limit", false) == 0)
                goto label_736;
              continue;
            case 3245386486:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_uscl", false) == 0)
                goto label_787;
              continue;
            case 3246165301:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-ba-liab-limit", false) == 0)
                goto label_736;
              continue;
            case 3264126432:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ins_taxid", false) == 0)
                break;
              continue;
            case 3283462675:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother_uim_premium", false) == 0)
                goto label_736;
              continue;
            case 3290099428:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-bi-da", false) == 0)
                goto label_736;
              continue;
            case 3291129409:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "effdate_first_yr_written", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>((object) DefaultDatabase.ExecuteScalar("spGetFirstYearInsuredWritten", new object[4]
                {
                  (object) "@ControlNo",
                  (object) this.Quote.ControlNo,
                  (object) "@InsuredGuid",
                  (object) this.Quote.SubmissionGroup.InsuredGuid
                }).ToString(), string.Empty);
                continue;
              }
              continue;
            case 3293691351:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insurerquotashare_table_a", false) == 0)
              {
                tag.TagTable = this.insurerquotashare_tableA(this.Quote.QuoteGuid);
                continue;
              }
              continue;
            case 3310468970:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insurerquotashare_table_b", false) == 0)
              {
                tag.TagTable = this.insurerquotashare_tableB(this.Quote.QuoteGuid);
                continue;
              }
              continue;
            case 3317659105:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_retrodate", false) == 0)
                goto label_787;
              continue;
            case 3319067461:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-gl-combined-da-per-claim", false) == 0)
                goto label_764;
              continue;
            case 3324644372:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "boundoptionpremiums", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("TemplateDocOptionPremiumListing", new object[8]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid,
                  (object) "@OnlyBound",
                  (object) true,
                  (object) "@ShowFees",
                  (object) false,
                  (object) "@OnlyShowOriginalBound",
                  (object) true
                })), string.Empty);
                continue;
              }
              continue;
            case 3327246589:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insurerquotashare_table_c", false) == 0)
              {
                tag.TagTable = this.insurerquotashare_tableC(this.Quote.QuoteGuid);
                continue;
              }
              continue;
            case 3329823182:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "csrext", false) == 0)
                goto label_634;
              continue;
            case 3332285889:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_underlying_policy_limit", false) == 0)
                break;
              continue;
            case 3361743574:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clclaimphone", false) == 0)
              {
                tag.TagValue = this.Quote.CompanyLocation.ClaimPhone;
                continue;
              }
              continue;
            case 3374555585:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "tacsrlq", false) == 0)
              {
                tag.TagValue = this.Quote.TACSRLast;
                continue;
              }
              continue;
            case 3378033332:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "total_billed_premium", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateQuoteInfo", new object[4]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@TagName",
                  (object) tag.InnerTagName.ToLower()
                });
                continue;
              }
              continue;
            case 3403542124:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uwa_initials", false) == 0)
              {
                tag.TagValue = !this.Quote.HasUnderwriterAssistant ? string.Empty : this.Quote.UnderwriterAssistant.Initials;
                continue;
              }
              continue;
            case 3412831055:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "underwriting_location", false) == 0)
                goto label_801;
              continue;
            case 3414198448:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_eaocc", false) == 0)
                break;
              continue;
            case 3416093546:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-pp-coins", false) == 0)
                goto label_736;
              continue;
            case 3421105817:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "program_code", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("GetProgramCode", new object[2]
                {
                  (object) "@QuoteID",
                  (object) this.Quote.QuoteID
                })), "");
                continue;
              }
              continue;
            case 3422443541:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cmpnycntct_phone", false) == 0)
              {
                tag.TagValue = this._quoteHasIntermediary.HasValue ? (!this._quoteHasIntermediary.Value ? this._companyContact.Phone : this._intermediaryContact.Phone) : string.Empty;
                continue;
              }
              continue;
            case 3424947329:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "csrphone", false) == 0)
                goto label_634;
              continue;
            case 3439988775:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "tacsrfq", false) == 0)
              {
                tag.TagValue = this.Quote.TACSRFirst;
                continue;
              }
              continue;
            case 3441205423:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms-endorse-number-name-edit-table", false) == 0)
              {
                tag.TagTable = this.FormsTableEndorseNumberNameEdit(this.Quote.QuoteGuid);
                continue;
              }
              continue;
            case 3458790712:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_nc_um_check", false) == 0)
                goto label_736;
              continue;
            case 3474003369:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-vehicle-extendedmedbenefits-limit", false) == 0)
                goto label_736;
              continue;
            case 3483112479:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_sublimits_desc", false) == 0)
                break;
              continue;
            case 3484606737:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-rejected-terr", false) == 0)
                goto label_736;
              continue;
            case 3492245318:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "rated_locations", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar("TemplateUnderwritingLocations", new object[6]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@tagName",
                  (object) tag.InnerTagName.ToLower(),
                  (object) "@placedByCompanyLineID",
                  (object) placedByCompanyLineID
                }).ToString();
                continue;
              }
              continue;
            case 3507526679:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "earnedpremiumtype", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT ISNULL(lstEarnedPremiumType.EarnedPremiumType, cast(0x as varchar)) FROM  tblQuotes WITH (NOLOCK) INNER JOIN lstEarnedPremiumType ON tblQuotes.EarnedPremiumTypeID = lstEarnedPremiumType.ID WHERE tblQuotes.QuoteGuid = @QG", new object[2]
                {
                  (object) "@QG",
                  (object) this.Quote.QuoteGuid
                });
                continue;
              }
              continue;
            case 3508777893:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "hired_auto_limit", false) == 0)
                goto label_736;
              continue;
            case 3509410387:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pc_email", false) == 0)
                break;
              continue;
            case 3518101925:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-peradv", false) == 0)
                goto label_736;
              continue;
            case 3556584875:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "non_renewed", false) == 0)
              {
                tag.TagCheckbox = this.Quote.QuoteStatus == QuoteStatus.NonRenewed;
                continue;
              }
              continue;
            case 3559955754:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "driveother_med_limit", false) == 0)
                goto label_736;
              continue;
            case 3563886504:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "inscity", false) == 0)
              {
                tag.TagValue = this.Quote.InsuredCity;
                continue;
              }
              continue;
            case 3566432447:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms-crlf-name-number-showonquote", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocForms", new object[14]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@LineFeedSeperated",
                  (object) true,
                  (object) "@ShowFormNumbers",
                  (object) true,
                  (object) "@ShowFormNames",
                  (object) true,
                  (object) "@NamesThenNumbers",
                  (object) true,
                  (object) "@NameNumberSeperator",
                  (object) " - ",
                  (object) "@ShowonQuote",
                  (object) "Y"
                });
                continue;
              }
              continue;
            case 3571458147:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "property-coins", false) == 0)
                break;
              continue;
            case 3600319720:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "binderexpirationdate", false) == 0)
              {
                DocTag docTag = tag;
                dateTime = DefaultDatabase.ExecuteScalar<DateTime>(CommandType.Text, "select dbo.GetBinderExpirationDate(@QuoteGuid)", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid
                });
                string str = dateTime.ToString();
                docTag.TagValue = str;
                continue;
              }
              continue;
            case 3606743887:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-vehicle-comp-da", false) == 0)
                goto label_736;
              continue;
            case 3607114482:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop-flooddeduct", false) == 0)
                break;
              continue;
            case 3634941993:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_usdcoll", false) == 0)
                goto label_787;
              continue;
            case 3639619958:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "fees-additional", false) == 0)
                goto label_564;
              continue;
            case 3640529031:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_comments", false) == 0)
                goto label_787;
              continue;
            case 3643271340:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_firelegal", false) == 0)
                break;
              continue;
            case 3644331572:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_driveother_um", false) == 0)
                goto label_736;
              continue;
            case 3644898000:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "lineofbusiness", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT LineName FROM lstLines WHERE LineGuid = @LineGuid", new object[2]
                {
                  (object) "@LineGuid",
                  (object) this.Quote.LineGuid
                });
                continue;
              }
              continue;
            case 3658906658:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "property-valuation", false) == 0)
                break;
              continue;
            case 3663588335:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "formnumbers", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocForms", new object[10]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@LineFeedSeperated",
                  (object) false,
                  (object) "@ShowFormNumbers",
                  (object) true,
                  (object) "@ShowFormNames",
                  (object) false,
                  (object) "@NamesThenNumbers",
                  (object) false
                });
                continue;
              }
              continue;
            case 3668149855:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "policy_sic_code", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT SIC_Code FROM tblQuotes (NOLOCK) WHERE QuoteGuid = @QG", new object[2]
                {
                  (object) "@QG",
                  (object) this.Quote.QuoteGuid
                })), string.Empty);
                continue;
              }
              continue;
            case 3674035839:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "illogo", false) == 0)
              {
                byte[] buffer = (byte[]) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Logo FROM tblClientOffices WHERE OfficeGuid = @ClientOfficeGuid", new object[2]
                {
                  (object) "@ClientOfficeGuid",
                  (object) this.Quote.IssuingLocationGuid
                });
                if (buffer != null)
                {
                  tag.TagImage = (Image) new Bitmap((Stream) new MemoryStream(buffer));
                  continue;
                }
                continue;
              }
              continue;
            case 3675574901:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "finance_company_name", false) == 0)
                goto label_757;
              continue;
            case 3688442515:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-blanket-limit-contents", false) == 0)
                goto label_736;
              continue;
            case 3699769382:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "underwritingteam", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("dbo.GetUnderwritingTeamInfo", new object[4]
                {
                  (object) "@QuoteID",
                  (object) this.Quote.QuoteID,
                  (object) "@tagValue",
                  (object) tag.InnerTagName.ToLower()
                }) ?? string.Empty;
                continue;
              }
              continue;
            case 3735980275:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "endcom", false) == 0)
              {
                tag.TagValue = this.Quote.EndorsementComment;
                continue;
              }
              continue;
            case 3746243390:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms-number-name", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocForms", new object[10]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@LineFeedSeperated",
                  (object) false,
                  (object) "@ShowFormNumbers",
                  (object) true,
                  (object) "@ShowFormNames",
                  (object) true,
                  (object) "@NamesThenNumbers",
                  (object) false
                });
                continue;
              }
              continue;
            case 3762973659:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "uwa_email", false) == 0)
              {
                tag.TagValue = !this.Quote.HasUnderwriterAssistant ? string.Empty : this.Quote.UnderwriterAssistant.Email;
                continue;
              }
              continue;
            case 3779508238:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_fascl", false) == 0)
                goto label_787;
              continue;
            case 3794157300:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "false_pretense_inventory_value", false) == 0)
                goto label_816;
              continue;
            case 3801941930:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_underlying_policy_num", false) == 0)
                break;
              continue;
            case 3816050868:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ql_fulladdress", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateClientOfficeInfo", new object[4]
                {
                  (object) "@ClientOfficeGuid",
                  (object) this.Quote.QuotingLocationGuid,
                  (object) "@TagName",
                  (object) tag.InnerTagName.ToLower()
                });
                continue;
              }
              continue;
            case 3829009442:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "endnum", false) == 0)
              {
                tag.TagValue = this.Quote.EndorsementNum.ToString();
                continue;
              }
              continue;
            case 3841098656:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "qlp", false) == 0)
              {
                tag.TagValue = this.Quote.QuotingLocation.Phone;
                continue;
              }
              continue;
            case 3876574393:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-prop-dmg", false) == 0)
                goto label_736;
              continue;
            case 3887476839:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-building-valuation", false) == 0)
                goto label_736;
              continue;
            case 3891431513:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "qls", false) == 0)
              {
                tag.TagValue = this.Quote.QuotingLocation.State;
                continue;
              }
              continue;
            case 3892501679:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "auto_uimlimit", false) == 0)
                goto label_815;
              continue;
            case 3899409053:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "bound_fees", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateTotalFees", new object[8]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@Bound",
                  (object) true,
                  (object) "@Payable",
                  (object) true,
                  (object) "@NonPayable",
                  (object) true
                });
                continue;
              }
              continue;
            case 3914125842:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms-crlf-number-name", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocForms", new object[10]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@LineFeedSeperated",
                  (object) true,
                  (object) "@ShowFormNumbers",
                  (object) true,
                  (object) "@ShowFormNames",
                  (object) true,
                  (object) "@NamesThenNumbers",
                  (object) false
                });
                continue;
              }
              continue;
            case 3918437383:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "qllogo", false) == 0)
              {
                byte[] logo = this.Quote.QuotingLocation.Logo;
                if (logo != null)
                {
                  tag.TagImage = (Image) new Bitmap((Stream) new MemoryStream(logo));
                  continue;
                }
                continue;
              }
              continue;
            case 3919457751:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "clcode", false) == 0)
              {
                tag.TagValue = this.Quote.CompanyLocation.LocationCode ?? string.Empty;
                continue;
              }
              continue;
            case 3925426514:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-building-coins", false) == 0)
                goto label_736;
              continue;
            case 3926079706:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cmpnycntct_lname", false) == 0)
              {
                tag.TagValue = this._quoteHasIntermediary.HasValue ? (!this._quoteHasIntermediary.Value ? this._companyContact.LName : this._intermediaryContact.LName) : string.Empty;
                continue;
              }
              continue;
            case 3931793877:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "endinfo_coveragepartsaffected", false) == 0)
                goto label_802;
              continue;
            case 3941653120:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "paymentschedule", false) == 0)
              {
                tag.TagTable = this.paymentschedule(this.Quote.QuoteGuid);
                continue;
              }
              continue;
            case 3964410137:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_addinfo_coveragetype", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>((object) DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT lstGLCoverageType.CoverageType FROM tblNetRateAdditionalData INNER JOIN lstGLCoverageType ON tblNetRateAdditionalData.CoverageTypeID = lstGLCoverageType.ID WHERE tblNetRateAdditionalData.QuoteGuid = @QG", new object[2]
                {
                  (object) "@QG",
                  (object) this.Quote.QuoteGuid
                }), string.Empty);
                continue;
              }
              continue;
            case 3974063989:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "inscounty", false) == 0)
              {
                tag.TagValue = this.Quote.InsuredCounty;
                continue;
              }
              continue;
            case 3995431403:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "ilcnt", false) == 0)
              {
                tag.TagValue = this.Quote.IssuingLocation.County;
                continue;
              }
              continue;
            case 4008874846:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "qlz", false) == 0)
              {
                tag.TagValue = this.Quote.QuotingLocation.ZipCode;
                continue;
              }
              continue;
            case 4017741617:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "csremail", false) == 0)
                goto label_634;
              continue;
            case 4029308004:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "account_number", false) == 0)
              {
                tag.TagValue = this.Quote.AccountNumber;
                continue;
              }
              continue;
            case 4034028162:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-ba-bi-pa-da", false) == 0)
                goto label_736;
              continue;
            case 4043369299:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-vehicle-uninsured-limit", false) == 0)
                goto label_736;
              continue;
            case 4045310121:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-blanket-limit-business-income", false) == 0)
                goto label_736;
              continue;
            case 4057176092:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "auto_liabilitylimit_csl", false) == 0)
                goto label_815;
              continue;
            case 4057621215:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "forms-crlf-number-name-showonquote", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateDocForms", new object[14]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@LineFeedSeperated",
                  (object) true,
                  (object) "@ShowFormNumbers",
                  (object) true,
                  (object) "@ShowFormNames",
                  (object) true,
                  (object) "@NamesThenNumbers",
                  (object) false,
                  (object) "@NameNumberSeperator",
                  (object) " - ",
                  (object) "@ShowonQuote",
                  (object) "Y"
                });
                continue;
              }
              continue;
            case 4064767757:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-dealer-agg-liab-limit", false) == 0)
                goto label_736;
              continue;
            case 4069734481:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "endinfo_addintparties", false) == 0)
                goto label_802;
              continue;
            case 4071342765:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "controlno", false) == 0)
              {
                tag.TagValue = this.Quote.ControlNo.ToString();
                continue;
              }
              continue;
            case 4077926738:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cpny_line_signature_secretary", false) == 0)
              {
                byte[] buffer = (byte[]) DefaultDatabase.ExecuteScalar("TemplateCompanyLineSignature", new object[4]
                {
                  (object) "@quoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@Title",
                  (object) "Secretary"
                });
                if (buffer != null)
                {
                  Bitmap bitmap = new Bitmap((Stream) new MemoryStream(buffer));
                  tag.TagImage = (Image) bitmap;
                  continue;
                }
                continue;
              }
              continue;
            case 4084022179:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_dealer_service_med_limit", false) == 0)
                goto label_736;
              continue;
            case 4095056727:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "pol_dpp", false) == 0)
              {
                object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT DownpaymentPercentage FROM tblInstallmentBilling INNER JOIN tblQuotes ON tblQuotes.InstallmentBillingQuoteOptionID=tblInstallmentBilling.QuoteOptionID WHERE tblQuotes.QuoteGuid=@QuoteGuid", new object[2]
                {
                  (object) "@QuoteGuid",
                  (object) this._quoteGuid
                }));
                tag.TagValue = objectValue == DBNull.Value || objectValue == null ? string.Empty : ((Decimal) objectValue).ToString("p");
                continue;
              }
              continue;
            case 4108256915:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-pp-limit", false) == 0)
                goto label_736;
              continue;
            case 4110134910:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "gl_valuation", false) == 0)
              {
                tag.TagValue = PolicyTagParser.StripRTF(Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select valuation from tblGenericLimits where QuoteID = @QuoteID", new object[2]
                {
                  (object) "@QuoteID",
                  (object) this.Quote.QuoteID
                })), string.Empty));
                continue;
              }
              continue;
            case 4123013449:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "endorsement_premium", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateQuoteInfo", new object[4]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@TagName",
                  (object) tag.InnerTagName.ToLower()
                });
                continue;
              }
              continue;
            case 4146408443:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_additional_comments", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar("TemplateDocQuoteProperty", new object[6]
                {
                  (object) "@placedByCompanyLineID",
                  (object) placedByCompanyLineID,
                  (object) "@quoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@tagName",
                  (object) tag.InnerTagName.ToLower()
                }).ToString();
                continue;
              }
              continue;
            case 4147269197:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "in_prod_email", false) == 0)
                goto label_841;
              continue;
            case 4152357001:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_dealer_um", false) == 0)
                goto label_736;
              continue;
            case 4153434510:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "quoted_taxes_only", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateTotalTaxes", new object[4]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@Bound",
                  (object) false
                });
                continue;
              }
              continue;
            case 4158754401:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "cpny_line_signature_ceo", false) == 0)
              {
                byte[] buffer = DefaultDatabase.ExecuteScalar<byte[]>(CommandType.StoredProcedure, "TemplateCompanyLineSignature", new object[4]
                {
                  (object) "@quoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@Title",
                  (object) "CEO"
                });
                if (buffer != null)
                {
                  Bitmap bitmap = new Bitmap((Stream) new MemoryStream(buffer));
                  tag.TagImage = (Image) bitmap;
                  continue;
                }
                continue;
              }
              continue;
            case 4159873417:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "qlc", false) == 0)
              {
                tag.TagValue = this.Quote.QuotingLocation.City;
                continue;
              }
              continue;
            case 4161729961:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "total_indicated_premium", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateQuoteInfo", new object[4]
                {
                  (object) "@QuoteGuid",
                  (object) this.Quote.QuoteGuid,
                  (object) "@TagName",
                  (object) tag.InnerTagName.ToLower()
                });
                continue;
              }
              continue;
            case 4162358123:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_rep_basis", false) == 0)
                goto label_787;
              continue;
            case 4169048035:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-gl-bi-da-per-claim", false) == 0)
                goto label_764;
              continue;
            case 4180077973:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-perauto-dealer-comp-ded", false) == 0)
                goto label_736;
              continue;
            case 4185610112:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "premium-additional", false) == 0)
                goto label_546;
              continue;
            case 4193032309:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "policy_paymentplan", false) == 0)
                break;
              continue;
            case 4203415183:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_pdcs", false) == 0)
                goto label_787;
              continue;
            case 4204026262:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "wc_bi_each_emp", false) == 0)
                goto label_811;
              continue;
            case 4210206274:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "qlf", false) == 0)
              {
                tag.TagValue = this.Quote.QuotingLocation.Fax;
                continue;
              }
              continue;
            case 4216021341:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "in_prod_phone", false) == 0)
                goto label_841;
              continue;
            case 4230841257:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "insbusclass", false) == 0)
                break;
              continue;
            case 4232312564:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_keyemployeedescription", false) == 0)
                goto label_765;
              continue;
            case 4238310614:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate-bi-valuation", false) == 0)
                goto label_736;
              continue;
            case 4240835994:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_additionaldata_auto_iccomp", false) == 0)
                goto label_787;
              continue;
            case 4244913519:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "netrate_alaska_bi_pd_limit", false) == 0)
                goto label_736;
              continue;
            case 4266567874:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "wc_states", false) == 0)
                goto label_811;
              continue;
            default:
              continue;
          }
          tag.TagValue = this.GetQuoteTagValue(tag.InnerTagName.ToLower());
          continue;
label_543:
          tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("TemplateDocQuoteGeneralLiability", new object[6]
          {
            (object) "@placedByCompanyLineID",
            (object) -1,
            (object) "@QuoteGuid",
            (object) this._quoteGuid,
            (object) "@tagName",
            (object) tag.InnerTagName.ToLower()
          })), string.Empty);
          continue;
label_546:
          if (this.Quote.HasBoundOptions())
            tag.TagValue = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.FormatNumber(dbo.GetQuotePremium(@QuoteGuid,null), 2)", new object[2]
            {
              (object) "@QuoteGuid",
              (object) this._quoteGuid
            });
          else if (this.Quote.OptionCount == 1)
            tag.TagValue = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.FormatNumber(Premium, 2) FROM tblQuoteOptions WHERE QuoteGuid=@QuoteGuid", new object[2]
            {
              (object) "@QuoteGuid",
              (object) this._quoteGuid
            }).ToString();
          else
            tag.TagValue = string.Empty;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tag.InnerTagName.ToLower(), "premium-return", false) == 0)
          {
            tag.TagValue = Interaction.IIf(Conversion.Val(tag.TagValue) <= 0.0, (object) (Conversion.Val(Strings.Replace(tag.TagValue, ",", "")) * -1.0), (object) 0).ToString();
            tag.TagValue = string.Format("{0:###,###,###,##0.00}", (object) Decimal.Parse(tag.TagValue));
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tag.InnerTagName.ToLower(), "premium-additional", false) == 0)
          {
            tag.TagValue = Interaction.IIf(Conversion.Val(tag.TagValue) >= 0.0, (object) tag.TagValue, (object) "0.00").ToString();
            continue;
          }
          continue;
label_555:
          string empty;
          if (this.Quote.HasBoundOptions())
          {
            tag.TagValue = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT convert(varchar(50), dbo.GetQuotePremium(@QuoteGuid,null))", new object[2]
            {
              (object) "@QuoteGuid",
              (object) this._quoteGuid
            });
            empty = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT sum(dbo.tblQuoteOptionCharges.Amount) FROM  dbo.tblQuoteOptions INNER JOIN dbo.tblQuoteOptionCharges ON dbo.tblQuoteOptions.QuoteOptionGUID = dbo.tblQuoteOptionCharges.QuoteOptionGuid  WHERE dbo.tblQuoteOptions.Bound = 1 And dbo.tblQuoteOptionCharges.WaivedByUserGuid Is NULL And tblQuoteOptions.QuoteGuid=@QuoteGuid ", new object[2]
            {
              (object) "@QuoteGuid",
              (object) this._quoteGuid
            }).ToString();
          }
          else if (this.Quote.OptionCount == 1)
          {
            tag.TagValue = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Premium FROM tblQuoteOptions WHERE QuoteGuid=@QuoteGuid", new object[2]
            {
              (object) "@QuoteGuid",
              (object) this._quoteGuid
            }).ToString();
            empty = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT sum(dbo.tblQuoteOptionCharges.Amount) FROM  dbo.tblQuoteOptions INNER JOIN dbo.tblQuoteOptionCharges ON dbo.tblQuoteOptions.QuoteOptionGUID = dbo.tblQuoteOptionCharges.QuoteOptionGuid  WHERE dbo.tblQuoteOptionCharges.WaivedByUserGuid Is NULL And tblQuoteOptions.QuoteGuid=@QuoteGuid ", new object[2]
            {
              (object) "@QuoteGuid",
              (object) this._quoteGuid
            }).ToString();
          }
          else
          {
            tag.TagValue = string.Empty;
            empty = string.Empty;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tag.InnerTagName.ToLower(), "premiumfees-return", false) == 0)
          {
            tag.TagValue = Interaction.IIf(Conversion.Val(tag.TagValue) + Conversion.Val(empty) <= 0.0, (object) ((Conversion.Val(tag.TagValue) + Conversion.Val(empty)) * -1.0), (object) 0).ToString();
            tag.TagValue = string.Format("{0:###,###,###,##0.00}", (object) Decimal.Parse(tag.TagValue));
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tag.InnerTagName.ToLower(), "premiumfees-additional", false) == 0)
          {
            tag.TagValue = Interaction.IIf(Conversion.Val(tag.TagValue) + Conversion.Val(empty) >= 0.0, (object) (Conversion.Val(tag.TagValue) + Conversion.Val(empty)), (object) "0.00").ToString();
            continue;
          }
          continue;
label_564:
          string InputStr;
          if (this.Quote.HasBoundOptions())
            InputStr = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.FormatNumber(dbo.GetQuotePremium(@QuoteGuid,null), 2)", new object[2]
            {
              (object) "@QuoteGuid",
              (object) this._quoteGuid
            });
          else if (this.Quote.OptionCount == 1)
            InputStr = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.FormatNumber(Premium, 0) FROM tblQuoteOptions WHERE QuoteGuid=@QuoteGuid", new object[2]
            {
              (object) "@QuoteGuid",
              (object) this._quoteGuid
            }).ToString();
          else
            InputStr = string.Empty;
          tag.TagValue = "";
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tag.InnerTagName.ToLower(), "fees-additional", false) == 0 && Conversion.Val(InputStr) > 0.0)
            tag.TagValue = DefaultDatabase.ExecuteScalar<string>("spGetFeeListingNameFirst", new object[4]
            {
              (object) "@QuoteGuid",
              (object) this.Quote.QuoteGuid,
              (object) "@LineBreaks",
              (object) true
            }).ToString();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tag.InnerTagName.ToLower(), "fees-return", false) == 0 && Conversion.Val(InputStr) <= 0.0)
          {
            tag.TagValue = DefaultDatabase.ExecuteScalar<string>("spGetFeeListingNameFirst", new object[4]
            {
              (object) "@QuoteGuid",
              (object) this.Quote.QuoteGuid,
              (object) "@LineBreaks",
              (object) true
            }).ToString();
            continue;
          }
          continue;
label_634:
          tag.TagValue = this.Quote.TACSR == null ? string.Empty : this.GetQuoteTagValue(tag.TagName);
          continue;
label_736:
          tag.TagValue = this.GetNetRateTagValue(tag.InnerTagName.ToLower(), placedByCompanyLineID);
          continue;
label_753:
          tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateMotorCarrierPremium", new object[4]
          {
            (object) "@QuoteGuid",
            (object) this.Quote.QuoteGuid,
            (object) "@TagName",
            (object) tag.InnerTagName.ToLower()
          });
          continue;
label_756:
          tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateQuoteCompanyInfo", new object[4]
          {
            (object) "@QuoteGuid",
            (object) this.Quote.QuoteGuid,
            (object) "@TagName",
            (object) tag.InnerTagName.ToLower()
          });
          continue;
label_757:
          tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateQuoteFinanceCompanyInfo", new object[4]
          {
            (object) "@QuoteGuid",
            (object) this.Quote.QuoteGuid,
            (object) "@TagName",
            (object) tag.InnerTagName.ToLower()
          });
          continue;
label_762:
          tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateQuoteInfo", new object[4]
          {
            (object) "@QuoteGuid",
            (object) this.Quote.QuoteGuid,
            (object) "@TagName",
            (object) tag.InnerTagName.ToLower()
          });
          continue;
label_763:
          tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateQuoteRetailerInfo", new object[4]
          {
            (object) "@QuoteGuid",
            (object) this.Quote.QuoteGuid,
            (object) "@TagName",
            (object) tag.InnerTagName.ToLower()
          });
          continue;
label_764:
          tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateNetRateGLDeductible", new object[6]
          {
            (object) "@QuoteGuid",
            (object) this.Quote.QuoteGuid,
            (object) "@TagName",
            (object) tag.InnerTagName.ToLower(),
            (object) "@CompanyLineID",
            (object) placedByCompanyLineID
          });
          continue;
label_765:
          tag.TagValue = DefaultDatabase.ExecuteScalar<string>("TemplateNetRateKeyEmployee", new object[4]
          {
            (object) "@QuoteGuid",
            (object) this.Quote.QuoteGuid,
            (object) "@TagName",
            (object) tag.InnerTagName.ToLower()
          });
          continue;
label_787:
          if (this.Quote.UsingNetRate)
          {
            tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("dbo.spGetNetRateAdditionalDataInfo", new object[4]
            {
              (object) "@quoteGuid",
              (object) this.Quote.QuoteGuid,
              (object) "@tagName",
              (object) tag.InnerTagName.ToLower()
            })), string.Empty);
            continue;
          }
          tag.TagValue = string.Empty;
          continue;
label_801:
          tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("dbo.GetGLRaterTags", new object[4]
          {
            (object) "@QuoteGuid",
            (object) this.Quote.QuoteGuid,
            (object) "@tag",
            (object) tag.InnerTagName.ToLower()
          })), string.Empty);
          continue;
label_802:
          tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("dbo.spGetAdditionalEndorsementInfo", new object[4]
          {
            (object) "@QuoteID",
            (object) this.Quote.QuoteID,
            (object) "@tagValue",
            (object) tag.InnerTagName.ToLower()
          })), string.Empty);
          continue;
label_811:
          tag.TagValue = DefaultDatabase.ExecuteScalar("TemplateDocQuoteWorkersComp", new object[6]
          {
            (object) "@placedByCompanyLineID",
            (object) placedByCompanyLineID,
            (object) "@quoteGuid",
            (object) this.Quote.QuoteGuid,
            (object) "@tagName",
            (object) tag.InnerTagName.ToLower()
          }).ToString();
          continue;
label_815:
          tag.TagValue = DefaultDatabase.ExecuteScalar("TemplateDocQuoteAuto", new object[6]
          {
            (object) "@placedByCompanyLineID",
            (object) placedByCompanyLineID,
            (object) "@quoteGuid",
            (object) this.Quote.QuoteGuid,
            (object) "@tagName",
            (object) tag.InnerTagName.ToLower()
          }).ToString();
          continue;
label_816:
          tag.TagValue = this.GetNetRateTagValue(tag.InnerTagName.ToLower(), placedByCompanyLineID);
          continue;
label_827:
          byte[] buffer1 = (byte[]) DefaultDatabase.ExecuteScalar("spGetUnderwriterSignature", new object[4]
          {
            (object) "@quoteGuid",
            (object) this.Quote.QuoteGuid,
            (object) "@tagName",
            (object) tag.InnerTagName.ToLower()
          });
          if (buffer1 != null)
          {
            tag.TagImage = (Image) new Bitmap((Stream) new MemoryStream(buffer1));
            continue;
          }
          continue;
label_841:
          tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("dbo.GetTemplateInHouseProducerInfo", new object[4]
          {
            (object) "@QuoteGuid",
            (object) this.Quote.QuoteGuid,
            (object) "@TagName",
            (object) tag.InnerTagName.ToLower()
          })), string.Empty);
        }
      }
    }
    finally
    {
      List<DocTag>.Enumerator enumerator;
      enumerator.Dispose();
    }
    if (this._quoteOptionGuids != null)
      this.ProcessQuoteOptionTags(tags);
    DynamicTagManager.ProcessTags(tags, RuntimeHelpers.GetObjectValue(entityId), placedByCompanyLineID, this._quoteGuid);
    ((ExcelDynamicTagManager) ObjectFactory.Instance.CreateObject(typeof (ExcelDynamicTagManager))).ProcessTags(tags, RuntimeHelpers.GetObjectValue(entityId), placedByCompanyLineID, this._quoteGuid);
    if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("EnableDocuSign", false))
      ((DocuSignTagManager) ObjectFactory.Instance.CreateObject(typeof (DocuSignTagManager))).ProcessTags(tags, RuntimeHelpers.GetObjectValue(entityId), placedByCompanyLineID, this._quoteGuid);
    tags = base.ProcessTags(tags, RuntimeHelpers.GetObjectValue(entityId), placedByCompanyLineID);
    return tags;
  }

  private void InitializeQuoteCompanyContact(Guid QuoteGuid)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("TemplateDocGetQuoteCompanyContact", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.Quote.QuoteGuid
    });
    if (dataTable.Rows.Count <= 0)
      return;
    if (!dataTable.Rows[0]["CompanyContactGuid"].Equals((object) DBNull.Value))
    {
      this._companyContact = new CompanyContact(new Guid(dataTable.Rows[0]["CompanyContactGuid"].ToString()));
      this._quoteHasIntermediary = new bool?(false);
    }
    else
    {
      if (dataTable.Rows[0]["IntermediaryContactGuid"].Equals((object) DBNull.Value))
        return;
      this._intermediaryContact = new IntermediaryContact(new Guid(dataTable.Rows[0]["IntermediaryContactGuid"].ToString()));
      this._quoteHasIntermediary = new bool?(true);
    }
  }
}

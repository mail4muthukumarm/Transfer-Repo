// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.QuoteOptionTagParser
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.BusinessObjects;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

[QuoteOptionTagParser]
public sealed class QuoteOptionTagParser : IQuoteOptionTagParser
{
  public void AddAvailableTags(dsTemplateDocs.TagsDataTable dt)
  {
    dsTemplateDocs.TagsDataTable tagsDataTable = dt;
    tagsDataTable.AddTagsRow("opt_dp", "Installment Billing - Downpayment Amount (Option Level)", "Premium and Fees");
    tagsDataTable.AddTagsRow("opt_dpp", "Installment Billing - Downpayment % (Option Level)", "Premium and Fees");
    tagsDataTable.AddTagsRow("opt_np", "Installment Billing - # Payments (Option Level)", "Premium and Fees");
    tagsDataTable.AddTagsRow("terrprem", "Terrorism Premium (Option Level)", "Premium and Fees");
    tagsDataTable.AddTagsRow("terrprem_Policy", "Terrorism Premium (Policy Level)", "Premium and Fees");
    tagsDataTable.AddTagsRow("prop_tiv", "Property - TIV (2 decimal)", "Property");
    tagsDataTable.AddTagsRow("prop_tiv_integer", "Property - TIV (Integer)", "Property");
    tagsDataTable.AddTagsRow("prop_rate", "Property - Rate", "Property");
    tagsDataTable.AddTagsRow("totpremopt", "Total Premium (Option Level)", "Premium and Fees");
    tagsDataTable.AddTagsRow("totpremopt_v2", "Total Premium (Option Level) (2 decimal)", "Premium and Fees");
  }

  public bool ApplicableToThisOption(Guid quoteOptionGuid) => true;

  public List<DocTag> ProcessTags(Guid quoteOptionGuid, List<DocTag> tags)
  {
    QuoteOption quoteOption = new QuoteOption(quoteOptionGuid);
    try
    {
      foreach (DocTag tag in tags)
      {
        if (string.IsNullOrEmpty(tag.TagValue))
        {
          string lower = tag.InnerTagName.ToLower();
          Decimal num;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(lower))
          {
            case 140840873:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "opt_dpp", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>((object) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT DownpaymentPercentage FROM tblInstallmentBilling WHERE QuoteOptionID=@ID", new object[2]
                {
                  (object) "@ID",
                  (object) quoteOption.QuoteOptionID
                })?.ToString(), string.Empty);
                continue;
              }
              continue;
            case 1445563501:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "terrprem_policy", false) == 0)
              {
                tag.TagValue = Utility.IsNull<int>((object) DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT dbo.GetTerrorismPremium(@QuoteID)", new object[2]
                {
                  (object) "@QuoteID",
                  (object) quoteOption.Quote.QuoteID
                }), 0).ToString("N2");
                continue;
              }
              continue;
            case 1968529187:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "opt_dp", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>((object) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Downpayment FROM tblInstallmentBilling WHERE QuoteOptionID=@ID", new object[2]
                {
                  (object) "@ID",
                  (object) quoteOption.QuoteOptionID
                })?.ToString(), string.Empty);
                continue;
              }
              continue;
            case 2034065545:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "opt_np", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>((object) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT NumPayments FROM tblInstallmentBilling WHERE QuoteOptionID=@ID", new object[2]
                {
                  (object) "@ID",
                  (object) quoteOption.QuoteOptionID
                })?.ToString(), string.Empty);
                continue;
              }
              continue;
            case 2716405669:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_tiv_integer", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.FormatCurrency(TIV, 0) FROM tblQuoteOptionProperty WHERE QuoteOptionID = @QuoteOptionID", new object[2]
                {
                  (object) "@QuoteOptionID",
                  (object) quoteOption.QuoteOptionID
                });
                continue;
              }
              continue;
            case 3165639815:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_rate", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.FormatNumber(Rate, 4) FROM tblQuoteOptionProperty WHERE QuoteOptionID = @QuoteOptionID", new object[2]
                {
                  (object) "@QuoteOptionID",
                  (object) quoteOption.QuoteOptionID
                });
                continue;
              }
              continue;
            case 3694850232:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_tiv", false) == 0)
              {
                tag.TagValue = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.FormatCurrency(TIV, 2) FROM tblQuoteOptionProperty WHERE QuoteOptionID = @QuoteOptionID", new object[2]
                {
                  (object) "@QuoteOptionID",
                  (object) quoteOption.QuoteOptionID
                });
                continue;
              }
              continue;
            case 3953020950:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "terrprem", false) == 0)
              {
                DocTag docTag = tag;
                num = Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetTerrorismPremiumAmount(@QuoteOptionGUID)", new object[2]
                {
                  (object) "@QuoteOptionGUID",
                  (object) quoteOption.QuoteOptionGuid
                })), 0M);
                string str = num.ToString();
                docTag.TagValue = str;
                continue;
              }
              continue;
            case 4068518838:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "totpremopt_v2", false) == 0)
              {
                tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Convert(varchar, dbo.GetOptionPremium(@QOG))", new object[2]
                {
                  (object) "@QOG",
                  (object) quoteOption.QuoteOptionGuid
                })), "0.00");
                continue;
              }
              continue;
            case 4256273965:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "totpremopt", false) == 0)
              {
                DocTag docTag = tag;
                num = Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetOptionPremium(@QOG)", new object[2]
                {
                  (object) "@QOG",
                  (object) quoteOption.QuoteOptionGuid
                })), 0M);
                string str = num.ToString();
                docTag.TagValue = str;
                continue;
              }
              continue;
            default:
              continue;
          }
        }
      }
    }
    finally
    {
      List<DocTag>.Enumerator enumerator;
      enumerator.Dispose();
    }
    return (List<DocTag>) null;
  }
}

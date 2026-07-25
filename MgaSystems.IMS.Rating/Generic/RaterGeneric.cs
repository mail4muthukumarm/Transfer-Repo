// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.Generic.RaterGeneric
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Data;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating.Generic;

[RaterInformation(0, "Generic Premium Capture")]
public class RaterGeneric : RaterWithUIBase, IMultiCompanyRater, IAutoCreateZeroPremiumOptions
{
  private RaterConditionElements _conditionElements;
  private RaterConditionCompare _compare;

  protected override Form CreateUI() => ObjectFactory.Instance.CreateForm(typeof (frmRaterGeneric));

  public override string GetOptionDescription(Guid quoteOptionGuid)
  {
    QuoteOption quoteOption = new QuoteOption(quoteOptionGuid);
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("Rating.OptionDescriptionResolutionProcName", nameof (GetOptionDescription)), new object[4]
    {
      (object) "@raterID",
      (object) quoteOption.RaterID,
      (object) "@quoteOptionGuid",
      (object) quoteOptionGuid
    });
    string optionDescription;
    if (dataTable != null && dataTable.Rows.Count > 0)
    {
      StringBuilder stringBuilder = new StringBuilder();
      bool flag = true;
      try
      {
        foreach (DataRow row in dataTable.Rows)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row.Field<string>("OptionItemLabel"), "IMS_STANDARD", false) == 0)
          {
            string Left = row.Field<string>("OptionItemDesc");
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "OPTION_PREMIUM", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "OPTION_ADDLCOMMENTS", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "OPTION_LIMITSANDEXPOSURES", false) == 0)
                {
                  string str = this.AppendLimitsAndExposures("", 0);
                  if (!string.IsNullOrWhiteSpace(str))
                  {
                    if (!flag)
                      stringBuilder.AppendLine("");
                    stringBuilder.AppendLine(str);
                  }
                }
                else
                {
                  if (!flag)
                    stringBuilder.AppendLine("");
                  stringBuilder.AppendLine($"{row.Field<string>("OptionItemLabel")}: {row.Field<string>("OptionItemDesc")}");
                }
              }
              else
              {
                string empty = string.Empty;
                object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT AdditionalComments FROM tblQuoteOptions WHERE QuoteOptionGuid=@QOG", new object[2]
                {
                  (object) "@QOG",
                  (object) quoteOptionGuid
                }));
                if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
                  empty = objectValue.ToString();
                if (!string.IsNullOrEmpty(empty))
                {
                  if (!flag)
                    stringBuilder.AppendLine("");
                  stringBuilder.AppendLine(empty);
                }
              }
            }
            else
            {
              if (!flag)
                stringBuilder.AppendLine("");
              stringBuilder.AppendLine("The premium for this option is " + Strings.FormatCurrency((object) quoteOption.Premium));
            }
          }
          else
          {
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine($"{row.Field<string>("OptionItemLabel")}: {row.Field<string>("OptionItemDesc")}");
          }
          flag = false;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      optionDescription = stringBuilder.ToString();
    }
    else
    {
      string description = "The premium for this option is " + Strings.FormatCurrency((object) quoteOption.Premium);
      string empty = string.Empty;
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT AdditionalComments FROM tblQuoteOptions WHERE QuoteOptionGuid=@QOG", new object[2]
      {
        (object) "@QOG",
        (object) quoteOptionGuid
      }));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
        empty = objectValue.ToString();
      if (!string.IsNullOrEmpty(empty))
        description = $"{description}\n\n{empty}";
      optionDescription = this.AppendLimitsAndExposures(description, 2);
    }
    return optionDescription;
  }

  private string AppendLimitsAndExposures(string description, int lineFeedCount)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT * FROM tblGenericLimits WHERE QuoteID = @QuoteID", new object[2]
    {
      (object) "@QuoteID",
      (object) this.Quote.QuoteID
    });
    if (dataRow != null)
    {
      int num = lineFeedCount - 1;
      for (int index = 0; index <= num; ++index)
        description += "\n";
      RichTextBox richTextBox = (RichTextBox) null;
      try
      {
        try
        {
          foreach (DataColumn column in (InternalDataCollectionBase) dataRow.Table.Columns)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(column.ColumnName, "QuoteID", false) != 0 && dataRow[column.ColumnName] != DBNull.Value)
            {
              if (richTextBox == null)
                richTextBox = new RichTextBox();
              richTextBox.Rtf = (string) dataRow[column.ColumnName];
              description = $"{description}{column.ColumnName}:\n\n{richTextBox.Text}\n\n";
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      finally
      {
        richTextBox?.Dispose();
      }
    }
    return description;
  }

  protected override void OnCopyBoundOption(SqlCommand cmd, OnCopyBoundOptionArgs e)
  {
  }

  internal static void RefreshPremiums(QuoteOption quoteOption)
  {
    Decimal premiumWithCents1 = quoteOption.PremiumWithCents;
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spGenericRater_RefreshPremiums", 0, (CommandArgumentType) 0, new object[2]
    {
      (object) "@quoteOptionGuid",
      (object) quoteOption.QuoteOptionGuid
    });
    Decimal premiumWithCents2 = quoteOption.PremiumWithCents;
    RaterBase.LogPremiumChanges(quoteOption, premiumWithCents1, Convert.ToDouble(premiumWithCents2));
    Messaging.SendBroadcastMessage(BroadcastMessages.PremiumChanged, (object) new object[2]
    {
      (object) quoteOption.QuoteGuid,
      (object) premiumWithCents2
    });
  }

  public void SetCompanyLocationID(int companyLocationId)
  {
  }

  public override bool SupportsUnderwritingLocations => true;

  public void CreateZeroPremiumOptions(
    Guid quoteGuid,
    Guid companyLineGuid,
    Guid lineGuid,
    string stateID)
  {
    DefaultDatabase.ExecuteNonQuery("spGenericRaterCreateZeroPremiumOption", new object[8]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid,
      (object) "@CompanyLineGuid",
      (object) companyLineGuid,
      (object) "@LineGUID",
      (object) lineGuid,
      (object) "@StateID",
      (object) stateID
    });
  }

  public override bool DoesConditionApply(
    int conditionalID,
    ConditionalOperators conditions,
    object amount)
  {
    bool flag;
    if (this.RaterID == 0)
    {
      if (this._compare == null)
        this._compare = (RaterConditionCompare) ObjectFactory.Instance.CreateObject(typeof (RaterConditionCompare));
      flag = this._compare.ValidateCondition(conditionalID, conditions, RuntimeHelpers.GetObjectValue(amount), this.QuoteGuid);
    }
    else
      flag = base.DoesConditionApply(conditionalID, conditions, RuntimeHelpers.GetObjectValue(amount));
    return flag;
  }

  public override List<RaterConditionalElement> RaterConditionalElements(string LineCode)
  {
    if (this._conditionElements == null)
      this._conditionElements = (RaterConditionElements) ObjectFactory.Instance.CreateObject(typeof (RaterConditionElements), new object[1]
      {
        (object) this.RaterID
      });
    return this._conditionElements.RaterConditionals();
  }
}

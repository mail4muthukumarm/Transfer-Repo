// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyNumbering.DefaultIMSPolicyNumberingEngine
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.CustomExceptions;
using MGASystems.Common.Email;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Settings;
using MGASystems.Common.ThreadingFunctions;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.IMS.Policies.PolicyBusinessObjects;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyNumbering;

public class DefaultIMSPolicyNumberingEngine : PolicyEngineBase
{
  private bool _suffixSeparatorApplied;
  private Quote _quote;
  private string _additionalPrefix;
  private dsPolicyNumberAdmin.tblPolicyNumberRulesRow _drPreviousRule;

  public DefaultIMSPolicyNumberingEngine()
  {
    this._suffixSeparatorApplied = false;
    this._additionalPrefix = string.Empty;
    this._drPreviousRule = (dsPolicyNumberAdmin.tblPolicyNumberRulesRow) null;
  }

  public override PolicyInfo GetNextPolicy(Guid quoteGuid, Guid companyLineGuid)
  {
    RuntimeHelpers.GetObjectValue(new object());
    this._quote = new Quote(quoteGuid);
    PolicyInfo pol = new PolicyInfo()
    {
      PolicyNumber = string.Empty
    };
    object objectValue1 = RuntimeHelpers.GetObjectValue(this.GetPolicyNumberRuleId(quoteGuid, companyLineGuid));
    int num1 = objectValue1 != DBNull.Value && Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue1)) ? Conversions.ToInteger(objectValue1) : throw new InvalidOperationException("The system was unable to get the next policy number, because there is no policy numbering rule assigned to this company line.");
    dsPolicyNumberAdmin.tblPolicyNumberRulesDataTable numberRulesDataTable = new dsPolicyNumberAdmin.tblPolicyNumberRulesDataTable();
    DefaultDatabase.LoadDataTable((DataTable) numberRulesDataTable, CommandType.Text, "SELECT TOP 1 * FROM dbo.tblPolicyNumberRules WHERE RuleID=@RuleID", new object[2]
    {
      (object) "@RuleID",
      (object) num1
    });
    dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr = numberRulesDataTable[0];
    bool submissionGroupNumbering = dr.UseSubmissionGroupNumbering;
    if (!dr.IsUsePolicyNumberingFromRuleIdNull())
    {
      if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(1) FROM dbo.tblPolicyNumberRules WHERE RuleID = @RuleID", new object[2]
      {
        (object) "@RuleId",
        (object) dr.UsePolicyNumberingFromRuleId
      }) > 0)
      {
        this._additionalPrefix = dr.IsPrefixNull() ? string.Empty : dr.Prefix;
        num1 = dr.UsePolicyNumberingFromRuleId;
        numberRulesDataTable.Clear();
        DefaultDatabase.LoadDataTable((DataTable) numberRulesDataTable, CommandType.Text, "SELECT TOP 1 * FROM dbo.tblPolicyNumberRules WHERE RuleID=@RuleID", new object[2]
        {
          (object) "@RuleID",
          (object) num1
        });
        dr = numberRulesDataTable[0];
        submissionGroupNumbering = dr.UseSubmissionGroupNumbering;
      }
    }
    this.CheckForManualPolicyNumberRequired(dr);
    bool companyLinesDifferent = DefaultDatabase.ExecuteScalar<bool>("dbo.spPolicyNumberingCompanyLineCheck", new object[4]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid,
      (object) "@CompanyLineGuid",
      Interaction.IIf(companyLineGuid.Equals(Guid.Empty), (object) null, (object) companyLineGuid)
    });
    bool flag = companyLinesDifferent;
    pol.PolicyNumberRuleID = num1;
    DataRow drPrevious = (DataRow) null;
    bool usingPrevious = false;
    if (this._quote.IsTrueImsRenewal)
    {
      if (companyLinesDifferent)
        companyLinesDifferent = this.KeepCompanyLinesDifferent(quoteGuid, companyLineGuid);
      if (!companyLinesDifferent && !dr.ForceCheckOnRenewal)
      {
        if (companyLineGuid.Equals(Guid.Empty))
          drPrevious = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT TOP 1 tblQuotes_1.PolicyNumber, tblQuotes_1.PolicyNumberIndex, ISNULL(tblQuotes_1.PolicyNumberRuleId, -1) AS PolicyNumberRuleId, tblQuotes_1.QuoteGuid FROM dbo.tblQuotes INNER JOIN dbo.tblQuotes tblQuotes_1 ON tblQuotes.RenewalOfControlNum = tblQuotes_1.ControlNo WHERE tblQuotes.ControlNo = @controlNo AND tblQuotes_1.OriginalQuoteGuid IS NULL ORDER BY tblQuotes_1.QuoteID DESC ", new object[2]
          {
            (object) "@controlNo",
            (object) this._quote.ControlNo
          });
        else
          drPrevious = DefaultDatabase.ExecuteDataRow("dbo.GetPreviousChildPolicyNumber", new object[6]
          {
            (object) "@controlNo",
            (object) this._quote.ControlNo,
            (object) "@CompanyLineChanged",
            (object) flag,
            (object) "@CompanyLineGuid",
            (object) companyLineGuid
          });
        if (drPrevious != null)
          usingPrevious = this.TryUsingPrevious(drPrevious, pol);
      }
    }
    bool useInsuredNumber = dr.UseInsuredNumber;
    int assignedIndex;
    if (!usingPrevious && !dr.UseTableBasedNumbering && !useInsuredNumber)
    {
      int? nullable = DefaultDatabase.ExecuteScalar<int?>("dbo.GetHighestPolicyNumber", new object[8]
      {
        (object) "@QuoteGUID",
        (object) quoteGuid,
        (object) "@CompanyLineGUID",
        (object) companyLineGuid,
        (object) "@PolicyNumberRuleID",
        (object) num1,
        (object) "@ignoreRenewals",
        (object) this.IgnoreRenewals(companyLinesDifferent, (Quote) this._quote, dr)
      });
      if (!nullable.HasValue)
      {
        if (!dr.IsBlockStartNull())
          assignedIndex = dr.BlockStart;
      }
      else
      {
        assignedIndex = nullable.Value + 1;
        if (assignedIndex > dr.BlockEnd)
          this.ThrowExceptionOnUIThread((Exception) new NoPolicyNumbersRemainingException());
      }
      pol.PolicyIndex = assignedIndex;
    }
    if (submissionGroupNumbering)
    {
      pol.PolicyIndex = this.GetSubmissionBasedPolicyNumberIndex(quoteGuid, dr.RuleID);
      assignedIndex = pol.PolicyIndex;
    }
    PolicyInfo nextPolicy;
    if (!usingPrevious && dr.UseTableBasedNumbering)
    {
      int num2 = Conversions.ToInteger(DefaultDatabase.ExecuteScalar("dbo.spGetRemainingTableBasedPolicyNumbers", new object[2]
      {
        (object) "@PolicyNumberRuleId",
        (object) dr.RuleID
      })) - 1;
      if (num2 < 0 && this.TableBasedRemainNumbersCheck(dr.RuleID, quoteGuid))
      {
        MessageBox.Show($"The table based policy numbering rule {dr.RuleName} has run out of policy numbers", "No Remaining Numbers", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        nextPolicy = new PolicyInfo()
        {
          PolicyNumber = (string) null
        };
        goto label_79;
      }
      if (!dr.IsWarnLowBlockCountNull() && dr.WarnLowBlockCount > 0 && num2 <= dr.WarnLowBlockCount)
        Note_System.Instance.NonInteractive.CreateNote((Note_System.NonInteractiveNoteManipulator.SystemEntity) 1, "Low Table Policy # Count", $"There are only {num2} policy numbers left for rule \"{dr.RuleName}\".", new Guid[1]
        {
          dr.WarnUser
        });
      string str = DefaultDatabase.ExecuteFunction<string>("dbo.GetNextPolicyNumber", new object[2]
      {
        (object) "@ruleID",
        (object) dr.RuleID
      });
      if (Utility.IsNull((object) str))
      {
        if (this.EnforceTableBasedNumberLookup(dr.RuleID, quoteGuid))
          throw new InvalidOperationException("Unable to get the next policy number from the lookup table");
      }
      else
      {
        pol.PolicyIndex = 1;
        pol.PolicyNumberRuleID = dr.RuleID;
        pol.TableBasedPolicyNumber = str;
        pol.PolicyNumber = str;
      }
    }
    if (!usingPrevious && !dr.UseTableBasedNumbering)
    {
      string prefix = this.GetPrefix(dr, quoteGuid, usingPrevious);
      if (useInsuredNumber)
      {
        int num3 = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT InsuredID FROM dbo.tblInsureds WHERE InsuredGuid = @IG", new object[2]
        {
          (object) "@IG",
          (object) this._quote.SubmissionGroup.InsuredGuid
        });
        prefix += num3.ToString();
      }
      pol.PolicyNumber = !useInsuredNumber ? (string.IsNullOrEmpty(this._additionalPrefix) ? (!string.IsNullOrEmpty(prefix) ? prefix + assignedIndex.ToString().PadLeft(dr.TotalBlockDigits, '0') : assignedIndex.ToString().PadLeft(dr.TotalBlockDigits, '0')) : (string.IsNullOrEmpty(prefix) ? this._additionalPrefix + assignedIndex.ToString().PadLeft(dr.TotalBlockDigits, '0') : this._additionalPrefix + prefix + assignedIndex.ToString().PadLeft(dr.TotalBlockDigits, '0'))) : this._additionalPrefix + prefix;
      if (dr.IsAlphaSuffixRenewalOnlyNull() || !dr.AlphaSuffixRenewalOnly || this._quote.IsRenewal)
        this.ApplySuffixSeparator(pol, dr);
    }
    else if (dr.UseTableBasedNumbering)
    {
      if (usingPrevious)
        this.ApplyRenewalTableBasedNumber(pol, drPrevious, dr, companyLineGuid);
      string prefix = this.GetPrefix(dr, quoteGuid, usingPrevious);
      if (!this._quote.IsRenewal || this._quote.IsRenewal && companyLinesDifferent && string.IsNullOrEmpty(this._additionalPrefix))
        pol.PolicyNumber = prefix + pol.PolicyNumber;
      if (string.IsNullOrEmpty(this._additionalPrefix) && !pol.PolicyNumber.Contains(prefix))
      {
        if (usingPrevious && (pol.TableBasedPolicyNumber == null || string.IsNullOrEmpty(pol.TableBasedPolicyNumber)))
        {
          object objectValue2 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 PolicyNumber FROM dbo.tblPolicyNumbers WHERE UsedOnQuoteGuid = @PreviousQuoteGuid", new object[2]
          {
            (object) "@PreviousQuoteGuid",
            drPrevious["QuoteGuid"]
          }));
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)))
            pol.TableBasedPolicyNumber = objectValue2.ToString();
        }
        pol.PolicyNumber = !this._quote.IsRenewal || companyLinesDifferent || string.IsNullOrEmpty(pol.TableBasedPolicyNumber) ? prefix + pol.PolicyNumber : prefix + pol.TableBasedPolicyNumber;
      }
      if (!string.IsNullOrEmpty(this._additionalPrefix))
        pol.PolicyNumber = this._additionalPrefix + pol.PolicyNumber;
      this.ApplySuffixSeparator(pol, dr);
    }
    else if (usingPrevious && this._drPreviousRule.UseRenewalDigitYear || dr.UseRenewalDigitYear)
    {
      string prefix = this.GetPrefix(dr, quoteGuid, usingPrevious);
      pol.PolicyNumber = Strings.Replace(pol.PolicyNumber, Strings.Left(pol.PolicyNumber, prefix.Length), prefix);
    }
    if (usingPrevious)
      this.HandleRenewalSuffix(pol, drPrevious, dr);
    if (!dr.IsYearSuffixNull() && dr.YearSuffix && (!usingPrevious || dr.UseTableBasedNumbering && this._quote.IsRenewal))
    {
      if (Utility.IsNull((object) this._quote.EffectiveDate))
        throw new InvalidOperationException("Can't get the next policy number:\n\nThis policy does not have an effective date, and the policy number requires one.");
      if (!dr.FourYearSuffix)
      {
        // ISSUE: variable of a reference type
        string& local;
        // ISSUE: explicit reference operation
        string str = ^(local = ref pol.PolicyNumber) + this._quote.EffectiveDate.Year.ToString().Substring(2, 2);
        local = str;
      }
      else
      {
        // ISSUE: variable of a reference type
        string& local;
        // ISSUE: explicit reference operation
        string str = ^(local = ref pol.PolicyNumber) + this._quote.EffectiveDate.Year.ToString();
        local = str;
      }
    }
    else if (!dr.IsFixedvalueNull() && (!usingPrevious || dr.UseTableBasedNumbering && this._quote.IsRenewal))
    {
      // ISSUE: variable of a reference type
      string& local;
      // ISSUE: explicit reference operation
      string str = ^(local = ref pol.PolicyNumber) + dr.Fixedvalue.ToUpper();
      local = str;
      if (pol.PolicyNumber.Contains("{YYYY}"))
      {
        if (Utility.IsNull((object) this._quote.EffectiveDate))
          throw new InvalidOperationException("Can't get the next policy number:\n\nThis policy does not have an effective date, and the policy number requires one.");
        pol.PolicyNumber = pol.PolicyNumber.Replace("{YYYY}", this._quote.EffectiveDate.ToString("yyyy"));
      }
    }
    else if (!dr.IsSequentialStartNull())
      this.ApplySequentialSuffix(usingPrevious, dr, pol);
    else if (!dr.IsAlphaSuffixNull())
    {
      if ((dr.IsAlphaSuffixRenewalOnlyNull() ? 0 : (dr.AlphaSuffixRenewalOnly ? 1 : 0)) == 0 || this._quote.IsRenewal)
        DefaultIMSPolicyNumberingEngine.ApplyAlphaSuffix(usingPrevious, dr, pol);
    }
    else if (!dr.IsYearSuffixSequentialStartNull())
      DefaultIMSPolicyNumberingEngine.ApplyYearSequence(usingPrevious, dr, pol, (Quote) this._quote, companyLineGuid);
    if (!dr.IsNumericalSuffixRenewalOnlyNull() && ((dr.IsNumericalSuffixRenewalOnlyNull() ? 0 : (dr.NumericalSuffixRenewalOnly ? 1 : 0)) == 0 || this._quote.IsRenewal))
      DefaultIMSPolicyNumberingEngine.ApplyNumericSuffix(usingPrevious, pol);
    if (!dr.IsPolicyNumberSuffixNull())
    {
      // ISSUE: variable of a reference type
      string& local;
      // ISSUE: explicit reference operation
      string str = ^(local = ref pol.PolicyNumber) + dr.PolicyNumberSuffix;
      local = str;
    }
    if (!dr.IsNumericalSuffixRenewalOnlyNull() && dr.NumericalSuffixRenewalOnly && !this._quote.IsRenewal)
      pol.PolicyNumber = pol.PolicyNumber.RemoveAfterLastDash();
    DefaultIMSPolicyNumberingEngine.SendNoteOnLowPolicyNumberCount(dr, assignedIndex);
    DefaultIMSPolicyNumberingEngine.SendEmailOnLowPolicyNumberCount(dr, assignedIndex);
    nextPolicy = pol;
label_79:
    return nextPolicy;
  }

  private bool TryUsingPrevious(DataRow drPrevious, PolicyInfo pol)
  {
    bool flag = false;
    dsPolicyNumberAdmin.tblPolicyNumberRulesDataTable numberRulesDataTable = new dsPolicyNumberAdmin.tblPolicyNumberRulesDataTable();
    DefaultDatabase.LoadDataTable((DataTable) numberRulesDataTable, CommandType.Text, "SELECT TOP 1 * FROM dbo.tblPolicyNumberRules WHERE RuleID=@RuleID", new object[2]
    {
      (object) "@RuleID",
      drPrevious["PolicyNumberRuleId"]
    });
    if (numberRulesDataTable.Rows.Count > 0)
    {
      this._drPreviousRule = numberRulesDataTable[0];
      if (!this.UseNewNumberOnRenewal(drPrevious))
      {
        pol.PolicyNumber = drPrevious.Field<string>("PolicyNumber");
        if (Versioned.IsNumeric((object) drPrevious.Field<int?>("PolicyNumberIndex")))
          pol.PolicyIndex = drPrevious.Field<int>("PolicyNumberIndex");
        flag = true;
      }
    }
    return flag;
  }

  private void CheckForManualPolicyNumberRequired(dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr)
  {
    if (!dr.ManualNumberOnPurchasedBook && !dr.ManualNumberOnRenewal)
      return;
    string Left = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT TOP 1 pt.Type FROM dbo.tblQuotes q WITH (NOLOCK) INNER JOIN dbo.lstPolicyTypes PT WITH (NOLOCK) ON pt.PolicyTypeID = q.PolicyTypeID WHERE q.QuoteGuid = @quoteGuid", new object[2]
    {
      (object) "@quoteGuid",
      (object) this._quote.QuoteGuid
    });
    if (dr.ManualNumberOnPurchasedBook && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "PB", false) == 0)
      throw new ManualEntryRequiredException();
    if (this._quote.IsRenewal && dr.ManualNumberOnRenewal)
      throw new ManualEntryRequiredException();
  }

  private void ApplyRenewalTableBasedNumber(
    PolicyInfo pol,
    DataRow drPrevious,
    dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr,
    Guid companyLineGuid)
  {
    Guid? nullable = DefaultDatabase.ExecuteFunction<Guid?>("dbo.GetOriginalQuoteGuidFromRenewalForPolicyNumberRule", new object[4]
    {
      (object) "@PreviousQuoteGuid",
      drPrevious["QuoteGuid"],
      (object) "@PolicyNumberRuleID",
      drPrevious["PolicyNumberRuleId"]
    });
    if (Utility.IsNull((object) nullable))
      return;
    string str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT TOP 1 PolicyNumber FROM dbo.tblPolicyNumbers WHERE UsedOnQuoteGuid = @PreviousQuoteGuid", new object[2]
    {
      (object) "@PreviousQuoteGuid",
      (object) nullable
    });
    if (Utility.IsNull((object) str))
      return;
    pol.TableBasedPolicyNumber = str;
    if (!dr.IsSequentialStartNull() || !dr.IsAlphaSuffixNull())
      return;
    pol.PolicyNumber = str;
  }

  private void HandleRenewalSuffix(
    PolicyInfo pol,
    DataRow drPrevious,
    dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr)
  {
    short? nullable1 = drPrevious.Field<short?>("PolicyNumberRuleID");
    int? nullable2 = nullable1.HasValue ? new int?((int) nullable1.GetValueOrDefault()) : new int?();
    if (!Utility.IsNull((object) nullable2))
    {
      int? nullable3 = nullable2;
      if ((nullable3.HasValue ? new bool?(nullable3.GetValueOrDefault() != -1) : new bool?()).GetValueOrDefault())
      {
        pol.PolicyNumberRuleID = nullable2.Value;
        string str = pol.PolicyNumber;
        if (!this._drPreviousRule.IsPrefixNull() && this._drPreviousRule.Prefix.ToString().Contains("-") | this._drPreviousRule.Prefix.ToString().Contains(" "))
          str = str.Substring(this._drPreviousRule.Prefix.ToString().Length);
        this._suffixSeparatorApplied = this._drPreviousRule.SuffixDash & str.Contains("-") | this._drPreviousRule.SuffixSeparateSpace & str.Contains(" ");
      }
    }
    if (dr.UseTableBasedNumbering || dr.IsYearSuffixNull() || !dr.YearSuffix)
      return;
    Quote renewalOfQuote = new Quote(this._quote.RenewalOfQuoteGuid.Value);
    if (Utility.IsNull((object) renewalOfQuote.EffectiveDate))
      throw new InvalidOperationException("Can't get the next policy number:\n\nThis previous policy does not have an effective date, and the policy number requires one.");
    if (Utility.IsNull((object) this._quote.EffectiveDate))
      throw new InvalidOperationException("Can't get the next policy number:\n\nThis policy does not have an effective date, and the policy number requires one.");
    this.RemoveYearSuffix(pol, drPrevious, renewalOfQuote, dr);
    this.ApplySuffixSeparator(pol, dr);
    if (!dr.FourYearSuffix)
    {
      // ISSUE: variable of a reference type
      string& local;
      // ISSUE: explicit reference operation
      string str = ^(local = ref pol.PolicyNumber) + this._quote.EffectiveDate.Year.ToString().Substring(2, 2);
      local = str;
    }
    else
    {
      // ISSUE: variable of a reference type
      string& local;
      // ISSUE: explicit reference operation
      string str = ^(local = ref pol.PolicyNumber) + this._quote.EffectiveDate.Year.ToString();
      local = str;
    }
  }

  private bool KeepCompanyLinesDifferent(Guid quoteGuid, Guid companyLineGuid)
  {
    bool flag;
    if (SystemSettings.GetSetting<bool>("RetainPolicyNumberSequenceOnRenewalCompanyLineChanged", false))
      flag = false;
    else
      flag = !DefaultDatabase.ExecuteScalar<bool>("dbo.spKeepPolicyNumberRenewalSequence", new object[4]
      {
        (object) "@companyLineGuid",
        Interaction.IIf(companyLineGuid.Equals(Guid.Empty), (object) null, (object) companyLineGuid),
        (object) "@quoteGuid",
        (object) quoteGuid
      });
    return flag;
  }

  private bool UseNewNumberOnRenewal(DataRow drPrevious)
  {
    short? nullable1 = drPrevious.Field<short?>("PolicyNumberRuleID");
    int? nullable2 = nullable1.HasValue ? new int?((int) nullable1.GetValueOrDefault()) : new int?();
    bool flag;
    if (drPrevious != null && !Utility.IsNull((object) nullable2))
    {
      int? nullable3 = nullable2;
      if ((nullable3.HasValue ? new bool?(nullable3.GetValueOrDefault() != -1) : new bool?()).GetValueOrDefault())
      {
        flag = this._drPreviousRule.NewNumberOnRenewal;
        goto label_4;
      }
    }
    flag = true;
label_4:
    return flag;
  }

  private bool RemoveYearSuffix(
    PolicyInfo pol,
    DataRow drPrevious,
    Quote renewalOfQuote,
    dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr)
  {
    bool fourYearSuffix = this._drPreviousRule.FourYearSuffix;
    string str1 = drPrevious["PolicyNumber"].ToString();
    string str2 = renewalOfQuote.EffectiveDate.ToString(fourYearSuffix ? "yyyy" : "yy");
    int num = (fourYearSuffix ? 4 : 2) + (this._suffixSeparatorApplied ? 1 : 0);
    if (!dr.IsPolicyNumberSuffixNull() && dr.PolicyNumberSuffix.Replace(" ", string.Empty).Length > 0)
      num += dr.PolicyNumberSuffix.Length;
    string str3 = $"{(this._suffixSeparatorApplied ? (dr.SuffixDash ? (object) "-" : (object) " ") : (object) string.Empty)}{str2}";
    if (str1.LastIndexOf(str3) == str1.Length - num)
    {
      pol.PolicyNumber = str1.Substring(0, str1.Length - num);
      this._suffixSeparatorApplied = false;
    }
    bool flag;
    return flag;
  }

  private bool ApplySuffixSeparator(PolicyInfo pol, dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr)
  {
    if (!this._suffixSeparatorApplied && dr.SuffixDash)
    {
      // ISSUE: variable of a reference type
      string& local;
      // ISSUE: explicit reference operation
      string str = ^(local = ref pol.PolicyNumber) + "-";
      local = str;
      this._suffixSeparatorApplied = true;
    }
    if (!this._suffixSeparatorApplied && !dr.IsSuffixSeparateSpaceNull() && dr.SuffixSeparateSpace)
    {
      // ISSUE: variable of a reference type
      string& local;
      // ISSUE: explicit reference operation
      string str = ^(local = ref pol.PolicyNumber) + " ";
      local = str;
      this._suffixSeparatorApplied = true;
    }
    bool flag;
    return flag;
  }

  private static void ApplyNumericSuffix(bool usingPrevious, PolicyInfo pol)
  {
    if (!usingPrevious)
      return;
    if (pol.PolicyNumber.Contains("-"))
    {
      string Expression = Strings.Right(pol.PolicyNumber, 1);
      string str = pol.PolicyNumber.Split('-')[pol.PolicyNumber.Split('-').Length - 1];
      if (Versioned.IsNumeric((object) Expression) && !string.IsNullOrWhiteSpace(str) && str.Length < 3)
      {
        int length = str.Length;
        int num = Convert.ToInt32(str) + 1;
        pol.PolicyNumber = pol.PolicyNumber.Replace("-" + str, "-" + num.ToString().PadLeft(length, '0'));
      }
      else
        pol.PolicyNumber = $"{pol.PolicyNumber}-01";
    }
    else
      pol.PolicyNumber = $"{pol.PolicyNumber}-01";
  }

  private string GetPrefix(
    dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr,
    Guid quoteGuid,
    bool usingPrevious)
  {
    string prefix;
    if (dr.IsNetrateSunset1PrefixNull() && dr.IsNetrateSunset2PrefixNull() && dr.IsNetrateSunset3PrefixNull() && dr.IsNetrateClaimsMadePrefixNull())
    {
      prefix = this.GetDefaultPrefix(dr, quoteGuid, usingPrevious);
    }
    else
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("dbo.GetNetRatePolicyType", new object[2]
      {
        (object) "@quoteGuid",
        (object) quoteGuid
      }));
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
      {
        prefix = this.GetDefaultPrefix(dr, quoteGuid, usingPrevious);
      }
      else
      {
        string Left = objectValue.ToString();
        prefix = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Sunset 1", false) == 0 ? dr.NetrateSunset1Prefix : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Sunset 2", false) == 0 ? dr.NetrateSunset2Prefix : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Sunset 3", false) == 0 ? dr.NetrateSunset3Prefix : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Claims Made", false) == 0 ? dr.NetrateClaimsMadePrefix : this.GetDefaultPrefix(dr, quoteGuid, usingPrevious))));
      }
    }
    return prefix;
  }

  private string GetDefaultPrefix(
    dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr,
    Guid quoteGuid,
    bool usingPrevious)
  {
    string str1 = string.Empty;
    string str2 = string.Empty;
    string str3 = string.Empty;
    if (!dr.IsPrefixNull())
      str1 = usingPrevious ? this._drPreviousRule.Prefix : dr.Prefix;
    if (usingPrevious && !this._drPreviousRule.IsAppendTwoDigitYearNull() && this._drPreviousRule.AppendTwoDigitYear || !usingPrevious && !dr.IsAppendTwoDigitYearNull() && dr.AppendTwoDigitYear)
      str2 = this._quote.EffectiveDate.Year.ToString().Substring(2, 2);
    if (usingPrevious && !this._drPreviousRule.IsAppendFourDigitYearNull() && this._drPreviousRule.AppendFourDigitYear || !usingPrevious && !dr.IsAppendFourDigitYearNull() && dr.AppendFourDigitYear)
      str2 = this._quote.EffectiveDate.Year.ToString();
    if (!dr.IsAppendPrefixNull())
      str3 = usingPrevious ? this._drPreviousRule.AppendPrefix : dr.AppendPrefix;
    return str1 + str2 + str3;
  }

  public virtual string AppendCustomPolicyNumberSQL(int policyNumberRuleID) => string.Empty;

  protected virtual bool IgnoreRenewals(
    bool companyLinesDifferent,
    Quote q,
    dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr)
  {
    return false;
  }

  private static void ApplyAlphaSuffix(
    bool usingPrevious,
    dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr,
    PolicyInfo pol)
  {
    if (usingPrevious)
    {
      bool flag = true;
      string str1;
      if (dr.SuffixDash)
      {
        if (pol.PolicyNumber.Contains("-"))
        {
          string input = pol.PolicyNumber.Split('-')[pol.PolicyNumber.Split('-').Length - 1];
          str1 = input != null && Regex.IsMatch(input, "[a-zA-Z]") && input.Length == 1 ? input : throw new InvalidOperationException("Unable to parse policy number suffix");
        }
        else
        {
          str1 = "A";
          flag = false;
        }
      }
      else
      {
        str1 = Strings.Right(pol.PolicyNumber, 1);
        if (Versioned.IsNumeric((object) str1))
          flag = false;
      }
      if (flag)
      {
        str1 = Conversions.ToString(Strings.ChrW(Strings.Asc(str1) + 1));
        pol.PolicyNumber = Strings.Left(pol.PolicyNumber, Strings.Len(pol.PolicyNumber) - 1);
      }
      if (dr.SuffixDash && !flag)
      {
        // ISSUE: variable of a reference type
        string& local;
        // ISSUE: explicit reference operation
        string str2 = ^(local = ref pol.PolicyNumber) + "-";
        local = str2;
      }
      if (Versioned.IsNumeric((object) str1))
      {
        // ISSUE: variable of a reference type
        string& local;
        // ISSUE: explicit reference operation
        string str3 = ^(local = ref pol.PolicyNumber) + "A";
        local = str3;
      }
      else
      {
        // ISSUE: variable of a reference type
        string& local;
        // ISSUE: explicit reference operation
        string str4 = ^(local = ref pol.PolicyNumber) + str1;
        local = str4;
      }
    }
    else
    {
      // ISSUE: variable of a reference type
      string& local;
      // ISSUE: explicit reference operation
      string str = ^(local = ref pol.PolicyNumber) + "A";
      local = str;
    }
  }

  private void ApplySequentialSuffix(
    bool usingPrevious,
    dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr,
    PolicyInfo pol)
  {
    if (usingPrevious)
    {
      if (!dr.IsPrefixNull() && dr.Prefix.Contains("-") && !dr.IsNumericalSuffixRenewalOnlyNull() && dr.NumericalSuffixRenewalOnly && dr.SuffixDash)
        return;
      string str1 = string.Empty;
      bool flag = true;
      int num1;
      if (dr.SuffixDash)
      {
        if (pol.PolicyNumber.Contains("-"))
        {
          this._suffixSeparatorApplied = true;
          string Expression1 = pol.PolicyNumber.Split('-')[pol.PolicyNumber.Split('-').Length - 1];
          if (Versioned.IsNumeric((object) Expression1))
          {
            num1 = Conversions.ToInteger(Expression1);
          }
          else
          {
            str1 = "-" + Expression1;
            int num2 = 0;
            string policyNumber = pol.PolicyNumber;
            int index = 0;
            while (index < policyNumber.Length)
            {
              if (policyNumber[index].ToString().Equals("-"))
                ++num2;
              checked { ++index; }
            }
            string Expression2 = pol.PolicyNumber.Split('-')[pol.PolicyNumber.Split('-').Length - num2];
            num1 = Versioned.IsNumeric((object) Expression2) ? Conversions.ToInteger(Expression2) : throw new InvalidOperationException("Unable to parse policy number suffix");
          }
        }
        else
        {
          num1 = 0;
          flag = false;
        }
      }
      else
        num1 = Conversions.ToInteger(Strings.Right(pol.PolicyNumber, dr.SequentialTotalDigits));
      if (flag)
      {
        ++num1;
        pol.PolicyNumber = Strings.Left(pol.PolicyNumber, Strings.Len(pol.PolicyNumber) - dr.SequentialTotalDigits);
      }
      this.ApplySuffixSeparator(pol, dr);
      // ISSUE: variable of a reference type
      string& local1;
      // ISSUE: explicit reference operation
      string str2 = ^(local1 = ref pol.PolicyNumber) + num1.ToString().PadLeft(dr.SequentialTotalDigits, '0');
      local1 = str2;
      if (str1.Equals(string.Empty))
        return;
      // ISSUE: variable of a reference type
      string& local2;
      // ISSUE: explicit reference operation
      string str3 = ^(local2 = ref pol.PolicyNumber) + str1;
      local2 = str3;
    }
    else
    {
      // ISSUE: variable of a reference type
      string& local;
      // ISSUE: explicit reference operation
      string str = ^(local = ref pol.PolicyNumber) + dr.SequentialStart.ToString().PadLeft(dr.SequentialTotalDigits, '0');
      local = str;
    }
  }

  private void ThrowExceptionOnUIThread(Exception ex)
  {
    if (MDIControls.Instance.MDIParent != null && MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.Invoke((Delegate) new DefaultIMSPolicyNumberingEngine.ThrowExceptionOnUIThreadHandler(this.ThrowExceptionOnUIThread), (object) ex);
    else
      ExceptionDispatchInfo.Capture(ex).Throw();
  }

  private static void SendNoteOnLowPolicyNumberCount(
    dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr,
    int assignedIndex)
  {
    if (dr.IsWarnLowBlockCountNull() || dr.WarnLowBlockCount <= 0)
      return;
    int num = dr.BlockEnd - assignedIndex;
    if (num > dr.WarnLowBlockCount)
      return;
    List<Guid> guidList = new List<Guid>();
    if (!dr.IsWarnUserNull())
      guidList.Add(dr.WarnUser);
    string str = "SELECT UserGuid FROM dbo.tblPolicyNumberNotesUsers WITH (NOLOCK) WHERE RuleID = @RuleID";
    try
    {
      foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, str, new object[2]
      {
        (object) "@RuleID",
        (object) dr.RuleID
      }).Rows)
      {
        if (!guidList.Contains(row.Field<Guid>("UserGuid")))
          guidList.Add(row.Field<Guid>("UserGuid"));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (Guid guid in guidList)
        Note_System.Instance.NonInteractive.CreateNote((Note_System.NonInteractiveNoteManipulator.SystemEntity) 1, "Low Policy # Count", $"There are only {num} policy numbers left for rule \"{dr.RuleName}\".", new Guid[1]
        {
          guid
        });
    }
    finally
    {
      List<Guid>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private static void SendEmailOnLowPolicyNumberCount(
    dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr,
    int assignedIndex)
  {
    if (dr.IsWarnLowBlockCountNull() || dr.WarnLowBlockCount <= 0)
      return;
    int num = dr.BlockEnd - assignedIndex;
    if (num > dr.WarnLowBlockCount || !SystemSettings.GetSetting<bool>("PolicyNumber.SendEmailOnLowCount", false))
      return;
    User user = new User(dr.WarnUser);
    try
    {
      if (!user.HasEmail)
        throw new InvalidOperationException($"Policy # Rule - '{dr.RuleName}'. Emailing On Low Policy Count - User {user.Name_FirstLast} does not have an email address");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
      return;
    }
    try
    {
      if (!CurrentUser.Instance.Email.ValidSettings)
        throw new InvalidOperationException($"Policy # Rule '{dr.RuleName}'. Emailing On Low Policy Count - User {CurrentUser.Instance.LastName}, {CurrentUser.Instance.FirstName} does not have any valid email settings");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
      return;
    }
    try
    {
      new UserEmail(CurrentUser.Instance.UserGUID).SendMail(new MessageObject()
      {
        ToAddress = user.Email,
        Subject = "Low Policy # Count",
        TextBody = $"There are only {num} policy numbers left for rule \"{dr.RuleName}\".",
        FromAddress = CurrentUser.Instance.Email.Address
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private int GetSubmissionBasedPolicyNumberIndex(Guid quoteGuid, int policyRuleID)
  {
    return DefaultDatabase.ExecuteScalar<int>("dbo.spGetSubmissionBasedPolicyNumberIndex", new object[4]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid,
      (object) "@ruleID",
      (object) policyRuleID
    });
  }

  private static void ApplyYearSequence(
    bool usingPrevious,
    dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr,
    PolicyInfo pol,
    Quote q,
    Guid companyLineGuid)
  {
    string str1 = dr.TwoYearSuffixSeq ? q.EffectiveDate.Year.ToString().Substring(2, 2) : q.EffectiveDate.Year.ToString();
    if (!usingPrevious)
    {
      // ISSUE: variable of a reference type
      string& local;
      // ISSUE: explicit reference operation
      string str2 = ^(local = ref pol.PolicyNumber) + str1 + dr.YearSuffixSequentialStart.ToString().PadLeft(dr.YearSuffixSequentialTotalDigits, '0');
      local = str2;
    }
    else
    {
      if (!usingPrevious || !q.IsImsRenewal)
        return;
      Quote quote = new Quote(q.RenewalOfQuoteGuid.Value);
      DataRow dataRow = DefaultDatabase.ExecuteDataRow("dbo.GetOriginalPolicyNumberInfo", new object[4]
      {
        (object) "@ControlNo",
        (object) quote.ControlNo,
        (object) "@CompanyLineGuid",
        (object) companyLineGuid
      });
      if (dataRow == null || dataRow.Table.Rows.Count == 0)
        return;
      string str3 = ExtensionsMethods.FieldAs<string>(dataRow, "SuffixSeparatorCharacter", DataRowVersion.Current);
      string str4 = Strings.Left(pol.PolicyNumber, pol.PolicyNumber.LastIndexOf(str3) + 1) + str1;
      string str5;
      if (q.EffectiveDate.Year == quote.EffectiveDate.Year || SystemSettings.GetSetting<bool>("PolicyNumber.IncrementYearSuffixStart", false))
      {
        string str6 = dataRow["PolicyNumber"].ToString();
        int Length = str6.Length - 1 - str6.LastIndexOf(str3);
        int num = Conversions.ToInteger(Strings.Right(str6, Length).Remove(0, ExtensionsMethods.FieldAs<bool>(dataRow, "FourYearSuffixSeq", DataRowVersion.Current) ? 4 : 2)) + 1;
        str5 = str4 + num.ToString().PadLeft(dr.YearSuffixSequentialTotalDigits, '0');
      }
      else
        str5 = str4 + dr.YearSuffixSequentialStart.ToString().PadLeft(dr.YearSuffixSequentialTotalDigits, '0');
      pol.PolicyNumber = str5;
    }
  }

  protected virtual bool TableBasedRemainNumbersCheck(int ruleID, Guid quoteGuid) => true;

  protected virtual bool EnforceTableBasedNumberLookup(int ruleID, Guid quoteGuid) => true;

  protected virtual object GetPolicyNumberRuleId(Guid quoteGuid, Guid companyLineGuid)
  {
    return DefaultDatabase.ExecuteScalar("dbo.GetPolicyNumberRule", new object[4]
    {
      (object) "@companyLineGuid",
      Interaction.IIf(companyLineGuid.Equals(Guid.Empty), (object) null, (object) companyLineGuid),
      (object) "@quoteGuid",
      (object) quoteGuid
    });
  }

  private delegate void ThrowExceptionOnUIThreadHandler(Exception ex);
}

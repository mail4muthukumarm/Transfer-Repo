// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Rating.Property.PropertyRater
// Assembly: MgaSystems.IMS.Rating.Property, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B6A893CA-828D-4C72-A3E1-997D4DDF80FA
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.Property.dll

using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.Policies.Rating;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.IMS.Rating.Property;

[RaterInformation(98, "Property")]
[QuoteOptionTagParser]
public class PropertyRater : RaterWithUIBase, IQuoteOptionTagParser
{
  private int _missingConstructionCount;
  private int _missingProtectiveSafeguardsCount;
  private int _inspectionRem;
  private bool _premiumsMatch;
  private bool _effectiveDatesMatch;
  private static object _syncLock = RuntimeHelpers.GetObjectValue(new object());
  private List<PropertyRater.PropertyPremiumInfo> _premiumInfo;
  private RaterConditionElements _conditionElements;
  private RaterConditionCompare _compare;

  public PropertyRater()
  {
    this._effectiveDatesMatch = true;
    this._premiumInfo = new List<PropertyRater.PropertyPremiumInfo>();
  }

  protected virtual bool VerifyPremiumsMatch()
  {
    return DefaultDatabase.ExecuteScalar<bool>("dbo.spPropertyRater_PremiumsMatch", new object[2]
    {
      (object) "@quoteGuid",
      (object) this.QuoteGuid
    });
  }

  public override bool IsReadyForPolicyIssuance
  {
    get
    {
      this._missingConstructionCount = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblUnderwritingLocations WHERE QuoteGuid=@QuoteGuid AND ConstructionID IS NULL", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid
      });
      this._missingProtectiveSafeguardsCount = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblUnderwritingLocations WHERE QuoteGuid=@QuoteGuid AND (FireAlarmTypeID IS NULL OR BurglarAlarmTypeID IS NULL OR SprinklerTypeID IS NULL)", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid
      });
      this._premiumsMatch = this.VerifyPremiumsMatch();
      this._inspectionRem = 0;
      bool flag;
      if (this.IsRenewal())
        flag = DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT AllowIssuanceWithoutInspection FROM tblCompanyLines WHERE CompanyLineGUID = @compGuid", new object[2]
        {
          (object) "@compGuid",
          (object) this.Quote.CompanyLineGuid
        });
      else
        flag = DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT AllowIssuanceWithoutInspectionRenewal FROM tblCompanyLines WHERE CompanyLineGUID = @compGuid", new object[2]
        {
          (object) "@compGuid",
          (object) this.Quote.CompanyLineGuid
        });
      if (!flag)
        this._inspectionRem = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT (*) FROM tblUnderwritingLocations WHERE (InspectionCompanyID IS NOT NULL AND InspectionRequested IS NULL) AND QuoteGuid = @QuoteGuid", new object[2]
        {
          (object) "@QuoteGuid",
          (object) this.QuoteGuid
        });
      return this._missingConstructionCount == 0 && this._premiumsMatch && this._missingProtectiveSafeguardsCount == 0 && this._inspectionRem == 0;
    }
  }

  [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
  public override List<string> NotReadyForPolicyIssuanceReasons
  {
    get
    {
      List<string> policyIssuanceReasons = new List<string>();
      if (this._missingConstructionCount == 1)
        policyIssuanceReasons.Add("1 location with a missing construction type.");
      else if (this._missingConstructionCount > 1)
        policyIssuanceReasons.Add(this._missingConstructionCount.ToString() + " locations with missing construction types.");
      if (this._missingProtectiveSafeguardsCount > 0)
        policyIssuanceReasons.Add(this._missingProtectiveSafeguardsCount.ToString() + " locations with missing protective safeguards.");
      if (!this._premiumsMatch)
        policyIssuanceReasons.Add("The billed premiums do not match the premiums allocated on locations.");
      if (this._inspectionRem != 0)
        policyIssuanceReasons.Add("Inspection Not Requested.");
      return policyIssuanceReasons;
    }
  }

  public override string GetOptionDescription(Guid quoteOptionGuid)
  {
    DataRow row = DefaultDatabase.ExecuteDataTable("dbo.GetPropertyOptionDescription", new object[2]
    {
      (object) "@quoteOptionGuid",
      (object) quoteOptionGuid
    }).Rows[0];
    string optionDescription = string.Empty;
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) row.Table.Columns)
      {
        string empty = string.Empty;
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row[column])))
          empty = Conversions.ToString(row[column]);
        optionDescription = $"{optionDescription}{column.ToString()}: {empty}\n";
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return optionDescription;
  }

  public override bool IsReadyForBind
  {
    get
    {
      bool isReadyForBind;
      if (!this.Quote.IsEndorsement)
      {
        DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT TerrorismDeclined, TerrPremium FROM tblQuoteOptionProperty WHERE QuoteOptionID=@QOID", new object[2]
        {
          (object) "@QOID",
          (object) this.QuoteOptionId
        });
        if (dataTable.Rows.Count == 0)
          throw new InvalidOperationException("Could not find a property option row for this property policy!");
        if (!Conversions.ToBoolean(dataTable.Rows[0][0]))
        {
          bool flag = MessageBox.Show("Terrorism coverage has been offered on this risk.\n\nHas the insured elected to take this coverage?", "Terrorism Coverage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No;
          if (flag)
          {
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteOptionProperty SET TerrorismDeclined=@TD WHERE QuoteOptionID=@QOID", new object[4]
            {
              (object) "@TD",
              (object) flag,
              (object) "@QOID",
              (object) this.QuoteOptionId.ToString()
            });
            this.ExecuteTerrorismDeclined(this.QuoteOptionId);
          }
          this.RefreshPremiums(new QuoteOption(this.QuoteOptionId));
        }
      }
      else if (!DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.IsEffectiveDatesMatch(@quoteGuid,@effDate)", new object[4]
      {
        (object) "@quoteGuid",
        (object) this.QuoteGuid,
        (object) "@effDate",
        (object) this.Quote.EndorsementEffective
      }) && MessageBox.Show("The endorsement effective date on this policy does not match the effective dates on the property exposure.\n\nContinue the binding process?", "Endorsement Effective Date Not Matching Exposure Dates", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      {
        this._effectiveDatesMatch = false;
        isReadyForBind = false;
        goto label_10;
      }
      isReadyForBind = true;
label_10:
      return isReadyForBind;
    }
  }

  protected virtual void ExecuteTerrorismDeclined(int QuoteOptionID)
  {
  }

  [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
  public override List<string> NotReadyToBindReason
  {
    get
    {
      List<string> readyToBindReason = new List<string>();
      if (!this._effectiveDatesMatch)
        readyToBindReason.Add("End. Effective date not matching effective date(s) on exposures.");
      return readyToBindReason;
    }
  }

  public override bool SupportsUnderwritingLocations => true;

  public override bool HasUI => false;

  public override void DoNonUIWork()
  {
    frmPropertyRater formEx = (frmPropertyRater) ObjectFactory.Instance.CreateFormEX(typeof (frmPropertyRater), (object) this);
    try
    {
      if (formEx.OptionAreProperlyLoaded)
      {
        formEx.ShowInTaskbar = false;
        int num = (int) formEx.ShowDialog();
      }
      else
      {
        int num1 = (int) MessageBox.Show("The options for the property portion of this policy are not valid.\n\nPlease contact technical support.", "Invalid Options", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }
    finally
    {
      formEx.Dispose();
    }
  }

  protected override Form CreateUI() => (Form) null;

  protected override void OnCopyBoundOption(SqlCommand cmd, OnCopyBoundOptionArgs e)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    PropertyRater._Closure\u0024__25\u002D0 closure250 = new PropertyRater._Closure\u0024__25\u002D0();
    // ISSUE: reference to a compiler-generated field
    closure250.\u0024VB\u0024Local_e = e;
    // ISSUE: reference to a compiler-generated field
    closure250.\u0024VB\u0024Local_CopyPropertyInfoProc = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("CopyPropertyInfoProc", "dbo.CopyPropertyInfo");
    if (cmd.Transaction == null)
    {
      // ISSUE: reference to a compiler-generated method
      DefaultDatabase.ExecuteTransaction(new EventHandler<ExecuteTransactionEventArgs>(closure250._Lambda\u0024__0));
    }
    else
    {
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) cmd.Transaction, new ExecuteHandler((object) closure250, __methodptr(_Lambda\u0024__1)));
    }
  }

  private void RefreshBinderPremiums(QuoteOption quoteOption)
  {
    DataRow row = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT PrimaryPremium, ExcessPremium, TerrPremium, TerrorismDeclined, TerrorismExcessPremium FROM tblQuoteOptionProperty WHERE QuoteOptionID=@QID", new object[2]
    {
      (object) "@QID",
      (object) quoteOption.QuoteOptionID
    }).Rows[0];
    Decimal premium = Conversions.ToDecimal(row[0]);
    bool boolean = Conversions.ToBoolean(row[3]);
    Decimal terrorismPremium = Conversions.ToDecimal(row[2]);
    Decimal excessPremium = Conversions.ToDecimal(row[1]);
    Decimal num1 = Conversions.ToDecimal(row[4]);
    int officeId = quoteOption.Quote.QuotingLocation.OfficeID;
    this.UpdatePremiums(quoteOption, premium, excessPremium, officeId);
    int premiumChargeCode1 = RatingFunctions.GetPremiumChargeCode(quoteOption.Quote.StateID, "TERR");
    int premiumChargeCode2 = RatingFunctions.GetPremiumChargeCode(quoteOption.Quote.StateID, "EXTR");
    Decimal num2 = this.ModifyTerrorismPremium(terrorismPremium, num1);
    if (!boolean)
    {
      this.UpdatePremium(quoteOption.QuoteOptionGuid, num2, num2, officeId, premiumChargeCode1);
      this.UpdatePremium(quoteOption.QuoteOptionGuid, num1, num1, officeId, premiumChargeCode2);
    }
    else
    {
      this.DeletePremium(quoteOption.QuoteOptionGuid, premiumChargeCode1, officeId);
      this.DeletePremium(quoteOption.QuoteOptionGuid, premiumChargeCode2, officeId);
    }
  }

  protected virtual Decimal ModifyTerrorismPremium(
    Decimal terrorismPremium,
    Decimal excessTerrorismPremium)
  {
    return terrorismPremium;
  }

  protected virtual void UpdatePremiums(
    QuoteOption qo,
    Decimal premium,
    Decimal excessPremium,
    int officeId)
  {
    this.UpdatePremium(qo.QuoteOptionGuid, premium, premium, officeId, RatingFunctions.GetPremiumChargeCode(qo.Quote.StateID, "PREM"));
    int premiumChargeCode = RatingFunctions.GetPremiumChargeCode(qo.Quote.StateID, "EXCS");
    if (Decimal.Compare(excessPremium, 0M) != 0)
      this.UpdatePremium(qo.QuoteOptionGuid, excessPremium, excessPremium, officeId, premiumChargeCode);
    else
      this.DeletePremium(qo.QuoteOptionGuid, premiumChargeCode, officeId);
  }

  protected static bool ZeroPremiumsOnLocations(QuoteOption quoteOption)
  {
    bool flag;
    if (quoteOption.Quote.IsEndorsement)
      flag = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblPropertyExposure WHERE QuoteOptionID=@QOID", new object[2]
      {
        (object) "@QOID",
        (object) quoteOption.QuoteOptionID.ToString()
      }) == 0;
    else
      flag = Decimal.Compare(DefaultDatabase.ExecuteScalar<Decimal>(CommandType.Text, "SELECT ISNULL(SUM(TotalPremium),0) FROM tblPropertyExposure WHERE QuoteOptionID=@QOID", new object[2]
      {
        (object) "@QOID",
        (object) quoteOption.QuoteOptionID
      }), 0M) == 0;
    return flag;
  }

  protected virtual bool IsRenewal() => this.Quote.IsRenewal;

  internal void RefreshPremiums(QuoteOption quoteOption)
  {
    // ISSUE: variable of a compiler-generated type
    PropertyRater._Closure\u0024__33\u002D0 closure330_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    PropertyRater._Closure\u0024__33\u002D0 closure330_2 = new PropertyRater._Closure\u0024__33\u002D0(closure330_1);
    // ISSUE: reference to a compiler-generated field
    closure330_2.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure330_2.\u0024VB\u0024Local_quoteOption = quoteOption;
    object syncLock = PropertyRater._syncLock;
    ObjectFlowControl.CheckForSyncLockOnValueType(syncLock);
    bool lockTaken = false;
    try
    {
      Monitor.Enter(syncLock, ref lockTaken);
      this._premiumInfo.Clear();
      // ISSUE: reference to a compiler-generated field
      if (PropertyRater.ZeroPremiumsOnLocations(closure330_2.\u0024VB\u0024Local_quoteOption) || this.IsRenewal() && !this.Quote.IsBound && !this.Quote.IsEndorsement)
      {
        // ISSUE: reference to a compiler-generated field
        this.RefreshBinderPremiums(closure330_2.\u0024VB\u0024Local_quoteOption);
      }
      else
      {
        // ISSUE: variable of a compiler-generated type
        PropertyRater._Closure\u0024__33\u002D1 closure331_1;
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        PropertyRater._Closure\u0024__33\u002D1 closure331_2 = new PropertyRater._Closure\u0024__33\u002D1(closure331_1)
        {
          \u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2 = closure330_2
        };
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        closure331_2.\u0024VB\u0024Local_ignoreProRateOnOriginalBinder = closure331_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_quoteOption.Quote.IsOriginalQuoteRecord && MGASystems.Common.SystemSettings.KeyExists("IgnoreProRatingOnOriginalBinder") && MGASystems.Common.SystemSettings.GetBoolSetting("IgnoreProRatingOnOriginalBinder");
        // ISSUE: reference to a compiler-generated field
        closure331_2.\u0024VB\u0024Local_useOverrideFactorForExtPolicyTerm = MGASystems.Common.SystemSettings.KeyExists("UseOverrideFactorForExtPolicyTerm") && MGASystems.Common.SystemSettings.GetBoolSetting("UseOverrideFactorForExtPolicyTerm");
        // ISSUE: reference to a compiler-generated field
        closure331_2.\u0024VB\u0024Local_isEndorsement = this.Quote.IsEndorsement;
        // ISSUE: reference to a compiler-generated field
        closure331_2.\u0024VB\u0024Local_originalTerrorismDeclined = false;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (this.Quote.IsEndorsement && closure331_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_quoteOption.HasPreviousQuoteOptionGuid)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          closure331_2.\u0024VB\u0024Local_originalTerrorismDeclined = (DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT TerrorismDeclined FROM tblQuoteOptionProperty WHERE QuoteOptionID=@ID", new object[2]
          {
            (object) "@ID",
            (object) new QuoteOption(closure331_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_quoteOption.PreviousQuoteOptionGuid).QuoteOptionID
          }) ? 1 : 0) != 0;
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        closure331_2.\u0024VB\u0024Local_terrorismDeclined = (DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT TerrorismDeclined FROM tblQuoteOptionProperty WHERE QuoteOptionID=@ID", new object[2]
        {
          (object) "@ID",
          (object) closure331_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_quoteOption.QuoteOptionID
        }) ? 1 : 0) != 0;
        // ISSUE: reference to a compiler-generated field
        closure331_2.\u0024VB\u0024Local_policyTermExtended = false;
        if (this.Quote.IsEndorsement)
        {
          // ISSUE: reference to a compiler-generated field
          closure331_2.\u0024VB\u0024Local_policyTermExtended = this.Quote.ExpirationDate.Subtract(this.Quote.PreviousQuote.ExpirationDate).Days > 0;
        }
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        DefaultDatabase.ExecuteReader(new EventHandler<ExecuteReaderArgs>(closure331_2._Lambda\u0024__0), CommandType.Text, "SELECT PrimaryPremium, ExcessPremium, TerrorPrimary, TerrorExcess, Factor, OfficeID, ModificationCode, OriginalExposureID, PremiumsWaived, EndorsementCalcType, UserOverrideFactor FROM tblPropertyExposure WHERE QuoteOptionID=@QuoteOptionID", new object[2]
        {
          (object) "@QuoteOptionID",
          (object) closure331_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_quoteOption.QuoteOptionID
        });
        this._premiumInfo.Clear();
      }
      // ISSUE: reference to a compiler-generated field
      RaterBase.RefreshMiscPremiums(closure330_2.\u0024VB\u0024Local_quoteOption.QuoteOptionID);
    }
    finally
    {
      if (lockTaken)
        Monitor.Exit(syncLock);
    }
  }

  internal Decimal GetExtendedPolicyTermFactor()
  {
    return DefaultDatabase.ExecuteScalar<Decimal>(CommandType.Text, "SELECT dbo.CalculateEndorsementFactor(@policyDays, @endorsementCalcType, @startDate, @endDate)", new object[8]
    {
      (object) "@policyDays",
      (object) this.Quote.PreviousQuote.ExpirationDate.Subtract(this.Quote.PreviousQuote.EffectiveDate).Days,
      (object) "@endorsementCalcType",
      (object) "P",
      (object) "@startDate",
      (object) this.Quote.EffectiveDate,
      (object) "@endDate",
      (object) this.Quote.ExpirationDate
    });
  }

  private void SendPremiums(
    QuoteOption quoteOption,
    bool terrorismDeclined,
    bool originalTerrorismDeclined)
  {
    try
    {
      bool flag = false;
      if (MGASystems.Common.SystemSettings.KeyExists("RoundPropertyPremiumToDollar"))
        flag = MGASystems.Common.SystemSettings.GetBoolSetting("RoundPropertyPremiumToDollar");
      try
      {
        foreach (PropertyRater.PropertyPremiumInfo propertyPremiumInfo in this._premiumInfo)
        {
          if (flag)
          {
            propertyPremiumInfo.ExcessPremium = new Decimal(Convert.ToInt32(propertyPremiumInfo.ExcessPremium));
            propertyPremiumInfo.Premium = new Decimal(Convert.ToInt32(propertyPremiumInfo.Premium));
            propertyPremiumInfo.TerrorismExcessPremium = new Decimal(Convert.ToInt32(propertyPremiumInfo.TerrorismExcessPremium));
            propertyPremiumInfo.TerrorismPremium = new Decimal(Convert.ToInt32(propertyPremiumInfo.TerrorismPremium));
          }
          this.UpdatePremiums(quoteOption, propertyPremiumInfo.Premium, propertyPremiumInfo.ExcessPremium, propertyPremiumInfo.OfficeID);
          if (!terrorismDeclined || this.Quote.IsEndorsement && terrorismDeclined && !originalTerrorismDeclined)
          {
            int premiumChargeCode1 = RatingFunctions.GetPremiumChargeCode(propertyPremiumInfo.StateID, "TERR");
            if (Decimal.Compare(propertyPremiumInfo.TerrorismPremium, 0M) != 0)
              this.UpdatePremium(quoteOption.QuoteOptionGuid, propertyPremiumInfo.TerrorismPremium, propertyPremiumInfo.TerrorismPremium, propertyPremiumInfo.OfficeID, premiumChargeCode1);
            else
              this.DeletePremium(quoteOption.QuoteOptionGuid, premiumChargeCode1, propertyPremiumInfo.OfficeID);
            int premiumChargeCode2 = RatingFunctions.GetPremiumChargeCode(quoteOption.Quote.StateID, "EXTR");
            if (Decimal.Compare(propertyPremiumInfo.TerrorismExcessPremium, 0M) != 0)
              this.UpdatePremium(quoteOption.QuoteOptionGuid, propertyPremiumInfo.TerrorismExcessPremium, propertyPremiumInfo.TerrorismExcessPremium, propertyPremiumInfo.OfficeID, premiumChargeCode2);
            else
              this.DeletePremium(quoteOption.QuoteOptionGuid, premiumChargeCode2, propertyPremiumInfo.OfficeID);
          }
          else
          {
            object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT PremiumID FROM tblQuoteOptionPremiums INNER JOIN tblFin_PolicyCharges ON tblQuoteOptionPremiums.ChargeCode = tblFin_PolicyCharges.ChargeCode WHERE QuoteOptionGuid=@QuoteOptionGuid AND tblFin_PolicyCharges.ChargeID = @TERR", new object[4]
            {
              (object) "@QuoteOptionGuid",
              (object) quoteOption.QuoteOptionGuid,
              (object) "@TERR",
              (object) "TERR"
            }));
            if (objectValue != null)
            {
              DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblPolicyCommissions WHERE PremiumID=@PremiumID", new object[2]
              {
                (object) "@PremiumID",
                objectValue
              });
              DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteOptionPremiums WHERE PremiumID=@PremiumID", new object[2]
              {
                (object) "@PremiumID",
                objectValue
              });
            }
          }
        }
      }
      finally
      {
        List<PropertyRater.PropertyPremiumInfo>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    finally
    {
      MDIControls.Instance.StatusBarText = string.Empty;
    }
  }

  private PropertyRater.PropertyPremiumInfo GetPropertyPremiumInfo(int officeID, string stateID)
  {
    PropertyRater.PropertyPremiumInfo propertyPremiumInfo1;
    try
    {
      foreach (PropertyRater.PropertyPremiumInfo propertyPremiumInfo2 in this._premiumInfo)
      {
        if (propertyPremiumInfo2.OfficeID == officeID && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(propertyPremiumInfo2.StateID, stateID, false) == 0)
        {
          propertyPremiumInfo1 = propertyPremiumInfo2;
          goto label_6;
        }
      }
    }
    finally
    {
      List<PropertyRater.PropertyPremiumInfo>.Enumerator enumerator;
      enumerator.Dispose();
    }
    PropertyRater.PropertyPremiumInfo propertyPremiumInfo3 = new PropertyRater.PropertyPremiumInfo();
    propertyPremiumInfo3.StateID = stateID;
    propertyPremiumInfo3.OfficeID = officeID;
    this._premiumInfo.Add(propertyPremiumInfo3);
    propertyPremiumInfo1 = propertyPremiumInfo3;
label_6:
    return propertyPremiumInfo1;
  }

  public void AddAvailableTags(dsTemplateDocs.TagsDataTable dt)
  {
    if (dt == null)
      throw new ArgumentNullException(nameof (dt));
    if (dt.Select("Tagname='Prop_AOPDA'").Length > 0)
      return;
    dsTemplateDocs.TagsDataTable tagsDataTable = dt;
    tagsDataTable.AddTagsRow("Prop_AOPDA", "Property - AOP Deductible");
    tagsDataTable.AddTagsRow("Prop_Limit", "Property - Policy Limit");
    tagsDataTable.AddTagsRow("Prop_Terr", "Property - Terrorism Premium");
    tagsDataTable.AddTagsRow("Prop_OtherDA", "Property - Other Deductible", "Property");
  }

  public bool ApplicableToThisOption(Guid quoteOptionGuid)
  {
    QuoteOption quoteOption = new QuoteOption(quoteOptionGuid);
    return quoteOption.RaterID.HasValue && quoteOption.RaterID.Value == 98;
  }

  [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
  public List<DocTag> ProcessTags(Guid quoteOptionGuid, List<DocTag> tags)
  {
    QuoteOption quoteOption = new QuoteOption(quoteOptionGuid);
    int quoteOptionId = quoteOption.QuoteOptionID;
    CompanyLine companyLine = new CompanyLine(quoteOption.CompanyLineGuid);
    try
    {
      foreach (DocTag tag in tags)
      {
        string lower = tag.InnerTagName.ToLower();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_aopda", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_limit", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_terr", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "prop_otherda", false) == 0)
                tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT OtherDeduct FROM tblQuoteOptionProperty WHERE quoteOptionID = @QOID", new object[2]
                {
                  (object) "@QOID",
                  (object) quoteOptionId
                })), string.Empty);
            }
            else
              tag.TagValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT CASE WHEN TerrorismDeclined = 0 THEN TerrPremium ELSE 0 END FROM tblQuoteOptionProperty WHERE QuoteOptionID=@QOID", new object[2]
              {
                (object) "@QOID",
                (object) quoteOptionId
              })), string.Empty);
          }
          else
            tag.TagValue = DefaultDatabase.ExecuteScalar("TemplateDocQuoteProperty", new object[8]
            {
              (object) "@placedByCompanyLineID",
              (object) companyLine.CompanyLineID,
              (object) "@quoteGuid",
              (object) quoteOption.QuoteGuid,
              (object) "@quoteOptionGuid",
              (object) quoteOption.QuoteOptionGuid,
              (object) "@tagName",
              (object) tag.InnerTagName.ToLower()
            }).ToString();
        }
        else
          tag.TagValue = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT AOPDA FROM tblQuoteOptionProperty WHERE quoteOptionID = @QOID", new object[2]
          {
            (object) "@QOID",
            (object) quoteOptionId
          }).ToString();
      }
    }
    finally
    {
      List<DocTag>.Enumerator enumerator;
      enumerator.Dispose();
    }
    return (List<DocTag>) null;
  }

  public virtual string CauseOfLossConditionalStoredProc => "PropertyRaterFormConditionals";

  public override bool DoesConditionApply(
    int conditionalID,
    ConditionalOperators conditions,
    object amount)
  {
    bool flag;
    if (this.RaterID == 98)
    {
      if (conditionalID == 905)
      {
        flag = (bool) DefaultDatabase.ExecuteScalar(this.CauseOfLossConditionalStoredProc, new object[8]
        {
          (object) "@QuoteGuid",
          (object) this.QuoteGuid,
          (object) "@ConditionalID",
          (object) conditionalID,
          (object) "@Conditions",
          (object) conditions,
          (object) "@Amount",
          amount
        });
      }
      else
      {
        if (this._compare == null)
          this._compare = (RaterConditionCompare) ObjectFactory.Instance.CreateObject(typeof (RaterConditionCompare));
        flag = this._compare.ValidateCondition(conditionalID, conditions, RuntimeHelpers.GetObjectValue(amount), this.QuoteGuid);
      }
    }
    else
      flag = base.DoesConditionApply(conditionalID, conditions, RuntimeHelpers.GetObjectValue(amount));
    return flag;
  }

  public override List<RaterConditionalElement> RaterConditionalElements(string LineCode)
  {
    if (this._conditionElements == null)
      this._conditionElements = new RaterConditionElements(this.RaterID);
    return this._conditionElements.RaterConditionals();
  }

  private sealed class PropertyPremiumInfo
  {
    public int OfficeID;
    public string StateID;
    public Decimal Premium;
    public Decimal ExcessPremium;
    public Decimal TerrorismPremium;
    public Decimal TerrorismExcessPremium;
  }
}
